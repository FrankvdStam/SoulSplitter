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
    public class BasePointer
    {
        public Process Process;
        public bool Is64Bit;
        public long Address;

        public BasePointer CreatePointer(out Pointer pointer, params long[] offsets)
        {
            pointer = new Pointer(Process, Is64Bit, Address, offsets);
            return this;
        }
    }

    public static class PointerFactory
    {
        public static BasePointer ScanPatternRelative(this Process process, string pattern, int addressOffset, int instructionSize)
        {
            return ScanPatternRelative(process, pattern.ToPattern(), addressOffset, instructionSize);
        }

        public static BasePointer ScanPatternRelative(this Process process, byte?[] pattern, int addressOffset, int instructionSize)
        {
            var basePointer = new BasePointer();
            basePointer.Process = process;
            basePointer.Address = PatternScanner.RelativeScan(process, pattern, addressOffset, instructionSize);
    
            if (basePointer.Address == 0)
            {
                throw new Exception($"Pattern scan failed for {process.ProcessName}, {pattern}.");
            }

            Kernel32.IsWow64Process(process.Handle, out bool result);
            basePointer.Is64Bit = !result;

            return basePointer;
        }
    }
}
