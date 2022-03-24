using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryRegion
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;

        public uint AllocationProtect;
        public ulong RegionSize;
        public uint State;
        public uint Protect;
        public uint Type;
    }

}
