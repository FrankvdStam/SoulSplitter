using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Native;

namespace SoulMemory.Shared
{
    public static class PatternScanner
    {
        #region Code cache

        private static Dictionary<string, byte[]> _memoryCache = new Dictionary<string, byte[]>();
        private static byte[] GetCodeMemory(Process p)
        {
            var name = p.ProcessName + p.MainModule.FileName + p.MainModule.FileVersionInfo.ProductVersion + p.MainModule.ModuleMemorySize;
            byte[] buffer;

            if (!_memoryCache.TryGetValue(name, out buffer))
            {
                buffer = new byte[p.MainModule.ModuleMemorySize];
                int read = 0;
                Kernel32.ReadProcessMemory(p.Handle, p.MainModule.BaseAddress, buffer, buffer.Length, ref read);
                _memoryCache[name] = buffer;
            }
            return buffer;
        }

        #endregion

        public static long RelativeScan(Process p, string pattern, int addressOffset, int instructionSize)
        {
            return RelativeScan(p, pattern.ToPattern(), addressOffset, instructionSize);
        }

        public static long RelativeScan(Process p, byte?[] pattern, int addressOffset, int instructionSize)
        {
            //int Read(long address)
            //{
            //    int read = 0;
            //    var buffer = new byte[4];
            //    Kernel32.ReadProcessMemory(p.Handle, (IntPtr)address, buffer, buffer.Length, ref read);
            //    return BitConverter.ToInt32(buffer, 0);
            //}

            var scanResult = Scan(p, pattern);
            if (scanResult != 0)
            {
                var codeBytes = GetCodeMemory(p);
                var address = BitConverter.ToInt32(codeBytes, (int)scanResult + addressOffset);
                var result = p.MainModule.BaseAddress.ToInt64() + scanResult + address + instructionSize;
                return result;
            }

            return 0;
        }


        public static long Scan(Process p, string pattern)
        {
            return Scan(p, pattern.ToPattern());
        }


        public static long Scan(Process p, byte?[] pattern)
        {
            var codeBytes = GetCodeMemory(p);
            
            //Find the pattern
            for (int i = 0; i < codeBytes.Length - pattern.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (pattern[j] != null)
                    {
                        if (pattern[j] != codeBytes[i + j])
                        {
                            found = false;
                            break;
                        }
                    }
                }

                if (found)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
