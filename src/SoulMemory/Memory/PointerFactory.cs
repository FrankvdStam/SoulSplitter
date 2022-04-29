using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                throw new Exception($"scan failed {errorName}");
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
                throw new Exception($"scan failed {errorName}");
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
