// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using SoulMemory.Native;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.MemoryV2
{
    public static class MemoryScanner
    {
        #region Resolving pointers ==============================================================================================================================

        /// <summary>
        /// Resolve pointers to their correct address by scanning for patterns in a running process
        /// </summary>
        /// <param name="treeBuilder"></param>
        /// <param name="process"></param>
        /// <param name="errors"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static ResultErr<RefreshError> TryResolvePointers(TreeBuilder treeBuilder, Process process)
        {
            if (process.MainModule == null)
            {
                return Result.Err(new RefreshError(RefreshErrorReason.MainModuleNull, "Main module is null. Try running as admin."));
            }

            //Gather some information about the process that can be reused throughout the resolving process
            var bytes = new byte[process.MainModule.ModuleMemorySize];
            int read = 0;
            Kernel32.ReadProcessMemory(process.Handle, process.MainModule.BaseAddress, bytes, bytes.Length, ref read);
            var baseAddress = process.MainModule.BaseAddress.ToInt64();
            Kernel32.IsWow64Process(process.Handle, out bool isWow64Result);
            var is64Bit = !isWow64Result;

            //Resolve nodes with the above data
            var errors = new List<string>();
            foreach (var node in treeBuilder.Tree)
            {
                long scanResult = 0;
                bool success = false;
                switch (node.NodeType)
                {
                    default:
                        return Result.Err(new RefreshError(RefreshErrorReason.UnknownException, $"Incorrect node type at base level: {node.NodeType}"));

                    case NodeType.RelativeScan:
                        success = bytes.TryScanRelative(baseAddress, node, out scanResult);
                        break;

                    case NodeType.AbsoluteScan:
                        success = bytes.TryScanAbsolute(baseAddress, node, out scanResult);
                        break;
                }

                if (success)
                {
                    foreach (var p in node.Pointers)
                    {
                        p.Pointer.Initialize(process, is64Bit, scanResult, p.Offsets);
                    }
                }
                else
                {
                    errors.Add(node.Name);
                }
            }

            if (errors.Any())
            {
                return Result.Err(new RefreshError(RefreshErrorReason.ScansFailed, $"Scans failed for {string.Join(",", errors)}"));
            }
            return Result.Ok();
        }
        #endregion

        #region Validate patterns from file ==============================================================================================================================

        /// <summary>
        /// Validate patterns in a TreeBuilder by counting the patterns in a given file.
        /// </summary>
        public static bool TryValidatePatterns(TreeBuilder treeBuilder, List<string> filepaths, out List<(string fileName, string patternName, long count)> errors)
        {
            var files = new List<(string name, byte[] bytes)>();

            foreach (var path in filepaths)
            {
                files.Add((Path.GetFileName(path), File.ReadAllBytes(path)));
            }

            object errorLock = new object();
            var errorsList = new List<(string fileName, string patternName, long count)>();

            //Count every pattern in every file; any count that returns something other than 1 is either missing or not exclusive, and thus erroneaus
            Parallel.For(0, files.Count, i => 
            {
                foreach (var n in treeBuilder.Tree)
                {
                    var pattern = n.Pattern.ToBytePattern();
                    var count = files[i].bytes.BoyerMooreCount(pattern); //BoyerMooreCount
                    if (count != 1)
                    {
                        lock(errorLock)
                        {
                            errorsList.Add((files[i].name, n.Name, count));
                        }
                    }
                }
            });

            errors = errorsList;
            return !errors.Any();
        }

        #endregion

        #region Utility ==============================================================================================================================

        /// <summary>
        /// Refresh a process instance
        /// </summary>
        /// <returns></returns>
        public static ResultErr<RefreshError> TryRefresh(ref Process process, string name, Func<ResultErr<RefreshError>> initialize, Action reset)
        {
            try
            {
                //Process not attached - find it in the process list
                if (process == null)
                {
                    process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower() == name.ToLower() && !i.HasExited);
                    if (process == null)
                    {
                        return Result.Err(new RefreshError(RefreshErrorReason.ProcessNotRunning, $"Process {name} not running or inaccessible. Try running livesplit as admin."));
                    }
                    else
                    {
                        //Propogate init result upwards
                        return initialize();
                    }
                }
                //Process is attached, make sure it is still running
                else
                {
                    if (process.HasExited)
                    {
                        process = null;
                        reset();
                        return Result.Err(new RefreshError(RefreshErrorReason.ProcessExited));
                    }

                    //Nothing going on, process still running
                    return Result.Ok();
                }
            }
            catch (Exception e)
            {
                reset();
                process = null;

                if (e.Message == "Access is denied")
                {
                    return Result.Err(new RefreshError(RefreshErrorReason.AccessDenied, "Access is denied. Make sure you disable easy anti cheat and try running livesplit as admin."));
                }

                return RefreshError.FromException(e);
            }
        }

        /// <summary>
        /// Scan a previously created buffer of bytes for a given pattern, then interpret the data as AMD64 assembly, where the target address is a relative address
        /// Returns the static address of the given instruction
        /// </summary>
        private static bool TryScanRelative(this byte[] bytes, long baseAddress, Node node, out long result)
        {
            result = 0;
            var pattern = node.Pattern.ToBytePattern();
            if (bytes.TryBoyerMooreSearch(pattern, out long scanResult))
            {
                var address = BitConverter.ToInt32(bytes, (int)(scanResult + node.AddressOffset));
                result = baseAddress + scanResult + address + node.InstructionSize;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Scan a previously created buffer of bytes for a given pattern, then interpret the data as assembly, where the target address is an absolute address
        /// </summary>
        private static bool TryScanAbsolute(this byte[] bytes, long baseAddress, Node node, out long result)
        {
            result = 0;
            var pattern = node.Pattern.ToBytePattern();
            if (bytes.TryBoyerMooreSearch(pattern, out long scanResult))
            {
                scanResult += baseAddress;
                if (node.Offset.HasValue)
                {
                    scanResult += node.Offset.Value;
                }
                result = scanResult;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Convert a string of hexadecimal symbols with wildcards into an array of bytes (with null as wildcard values)
        /// </summary>
        /// <param name="pattern">Hex string, separated with whitespaces and ?/??/x/xx as wildcards. Example: "48 8b 05 ? ? ? ? c6 40 18 00"</param>
        /// <returns>byte representation of the input string</returns>
        public static byte?[] ToBytePattern(this string pattern)
        {
            var result = new List<byte?>();
            pattern = pattern.Replace("\r", string.Empty).Replace("\n", string.Empty);
            var split = pattern.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in split)
            {
                if (s != "?" && s != "??" && s != "x" && s != "xx")
                {
                    result.Add(Convert.ToByte(s, 16));
                }
                else
                {
                    result.Add(null);
                }
            }
            return result.ToArray();
        }


        /// <summary>
        /// Searches for needle in haystack with wildcards, based on Boyer–Moore–Horspool
        /// https://en.wikipedia.org/wiki/Boyer%E2%80%93Moore%E2%80%93Horspool_algorithm
        /// Will return the first match it finds.
        /// </summary>
        public static bool TryBoyerMooreSearch(this byte[] haystack, byte?[] needle, out long result)
        {
            result = 0;
            var lastPatternIndex = needle.Length - 1;

            var diff = lastPatternIndex - Math.Max(Array.LastIndexOf(needle, null), 0);
            if (diff == 0)
            {
                diff = 1;
            }

            var badCharacters = new int[256];
            for (var i = 0; i < badCharacters.Length; i++)
            {
                badCharacters[i] = diff;
            }

            for (var i = lastPatternIndex - diff; i < lastPatternIndex; i++)
            {
                badCharacters[needle[i] ?? 0] = lastPatternIndex - i;
            }

            for (var i = 0; i <= haystack.Length - needle.Length; i += Math.Max(badCharacters[haystack[i + lastPatternIndex] & 0xFF], 1))
            {
                for (var j = lastPatternIndex; !needle[j].HasValue || haystack[i + j] == needle[j]; --j)
                {
                    if (j == 0)
                    {
                        result = i;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Searches for needle in haystack with wildcards, based on Boyer–Moore–Horspool
        /// https://en.wikipedia.org/wiki/Boyer%E2%80%93Moore%E2%80%93Horspool_algorithm
        /// Will return the first match it finds.
        /// </summary>
        public static List<long> BoyerMooreSearch(this byte[] haystack, byte?[] needle)
        {
            var result = new List<long>();
            var lastPatternIndex = needle.Length - 1;

            var diff = lastPatternIndex - Math.Max(Array.LastIndexOf(needle, null), 0);
            if (diff == 0)
            {
                diff = 1;
            }

            var badCharacters = new int[256];
            for (var i = 0; i < badCharacters.Length; i++)
            {
                badCharacters[i] = diff;
            }

            for (var i = lastPatternIndex - diff; i < lastPatternIndex; i++)
            {
                badCharacters[needle[i] ?? 0] = lastPatternIndex - i;
            }

            for (var i = 0; i <= haystack.Length - needle.Length; i += Math.Max(badCharacters[haystack[i + lastPatternIndex] & 0xFF], 1))
            {
                for (var j = lastPatternIndex; !needle[j].HasValue || haystack[i + j] == needle[j]; --j)
                {
                    if (j == 0)
                    {
                        result.Add(i);
                        break;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Searches for needle in haystack with wildcards, based on Boyer–Moore–Horspool
        /// https://en.wikipedia.org/wiki/Boyer%E2%80%93Moore%E2%80%93Horspool_algorithm
        /// Will return how many matches are found
        /// </summary>
        public static int BoyerMooreCount(this byte[] haystack, byte?[] needle)
        {
            int result = 0;
            var lastPatternIndex = needle.Length - 1;

            var diff = lastPatternIndex - Math.Max(Array.LastIndexOf(needle, null), 0);
            if (diff == 0)
            {
                diff = 1;
            }

            var badCharacters = new int[256];
            for (var i = 0; i < badCharacters.Length; i++)
            {
                badCharacters[i] = diff;
            }

            for (var i = lastPatternIndex - diff; i < lastPatternIndex; i++)
            {
                badCharacters[needle[i] ?? 0] = lastPatternIndex - i;
            }

            for (var i = 0; i <= haystack.Length - needle.Length; i += Math.Max(badCharacters[haystack[i + lastPatternIndex] & 0xFF], 1))
            {
                for (var j = lastPatternIndex; !needle[j].HasValue || haystack[i + j] == needle[j]; --j)
                {
                    if (j == 0)
                    {
                        result++;
                        break;
                    }
                }
            }

            return result;
        }

        #endregion
    }
}
