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

using System;
using System.Diagnostics;
using SoulMemory.Native;
using SoulMemory.Shared;

namespace SoulMemory.Memory
{
    /// <summary>
    /// Helper class for fluent API
    /// </summary>
    public class CodeCache
    {
        public bool Is64Bit;
        public Process Process;
        public byte[] Bytes;
        public long ScanResult;
    }

    public static class PointerFactory
    {
        /// <summary>
        /// Copies the executable's code to a buffer. All scanning will take place on this 'snapshot' buffer, rather than recreating this buffer for each scan
        /// </summary>
        public static CodeCache ScanCache(this Process process)
        {
            if (process.MainModule == null)
            {
                throw new InvalidOperationException("ScanCache MainModule is null");
            }

            var buffer = new byte[process.MainModule.ModuleMemorySize];
            int read = 0;
            Kernel32.ReadProcessMemory(process.Handle, process.MainModule.BaseAddress, buffer, buffer.Length, ref read);

            Kernel32.IsWow64Process(process.Handle, out bool isWow64Result);

            return new CodeCache
            {
                Is64Bit = !isWow64Result,
                Process = process,
                Bytes = buffer,
            };
        }


        #region scanning

        /// <summary>
        /// Scan for a pattern to a relative address and resolve the relative addressing
        /// </summary>
        public static CodeCache ScanRelative(this CodeCache cache, string errorName, string pattern, int addressOffset, int instructionSize) => ScanRelative(cache, errorName, pattern.ToByteArray(), addressOffset, instructionSize);


        /// <summary>
        /// Scan for a pattern to a relative address and resolve the relative addressing
        /// </summary>
        public static CodeCache ScanRelative(this CodeCache cache, string errorName, byte?[] pattern, int addressOffset, int instructionSize)
        {
            cache.ScanResult = PatternScanner.Scan(cache.Bytes, pattern);
            
            if (cache.ScanResult == 0)
            {
                throw new InvalidOperationException($"scan failed {errorName}. Process name: {cache.Process.ProcessName} cache size: {cache.Bytes.Length}");
            }

            var address = BitConverter.ToInt32(cache.Bytes, (int)cache.ScanResult + addressOffset);
            var result = cache.Process.MainModule.BaseAddress.ToInt64() + cache.ScanResult + address + instructionSize;

            cache.ScanResult = result;

            return cache;
        }

        /// <summary>
        /// Scan for a pattern to an absolute address
        /// </summary>
        public static CodeCache ScanAbsolute(this CodeCache cache, string errorName, string pattern, long? offset = null) => ScanAbsolute(cache, errorName, pattern.ToByteArray(), offset);

        /// <summary>
        /// Scan for a pattern to an absolute address
        /// </summary>
        public static CodeCache ScanAbsolute(this CodeCache cache, string errorName, byte?[] pattern, long? offset = null)
        {
            cache.ScanResult =PatternScanner.Scan(cache.Bytes, pattern);
            if (cache.ScanResult == 0)
            {
                throw new InvalidOperationException($"scan failed {errorName}");
            }

            cache.ScanResult += cache.Process.MainModule.BaseAddress.ToInt64();

            if (offset.HasValue)
            {
                cache.ScanResult += offset.Value;
            }

            return cache;
        }

        #endregion


        /// <summary>
        /// Create a pointer from the last scan
        /// </summary>
        public static CodeCache CreatePointer(this CodeCache cache, out Pointer pointer, params long[] offsets)
        {
            pointer = new Pointer(cache.Process, cache.Is64Bit, cache.ScanResult, offsets);
            return cache;
        }
    }
}
