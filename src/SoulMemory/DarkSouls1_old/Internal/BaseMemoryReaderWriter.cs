using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Shared;
using SoulMemory.Native;

namespace SoulMemory.DarkSouls1_Old.Internal
{
    public class BaseMemoryReaderWriter
    {
        public Process _process;
        public bool _isHooked = false;


        internal bool AttachByName(string name)
        {
            //If we hooked before, "Refresh" the existing hook
            if (_isHooked)
            {
                if (_process.HasExited)
                {
                    _isHooked = false;
                    _process = null;
                }
            }
            else
            {
                _process = Process.GetProcessesByName(name).FirstOrDefault();
                if (_process != null)
                {
                    _isHooked = true;
                }
            }
            return _isHooked;
        }


        internal bool TryScan(byte?[] pattern, out IntPtr pointer)
        {
            pointer = IntPtr.Zero;


            try
            {
                //Save as the scan function, except I don't want to immediately read the result
                var regions = GetRegions(_process);
                foreach (var region in regions)
                {
                    var bytes = region.Value;
                    for (int i = 0; i < bytes.Length - pattern.Length; i++)
                    {
                        bool found = true;
                        for (int j = 0; j < pattern.Length; j++)
                        {
                            if (pattern[j] != null)
                            {
                                if (pattern[j] != bytes[i + j])
                                {
                                    found = false;
                                    break;
                                }
                            }
                        }

                        if (found)
                        {
                            pointer = region.Key + i;
                            return true;
                        }
                    }
                }
            }
            catch
            {
                //When the game closes, an exception will be thrown from GetRegions. We can just ignore it - re-hooking is implemented at a higher level in the code.
            }

            return false;
        }
        
        //We scan signatures in the code - this memory never changes. No need to copy these bytes out every time we do a scan.
        //Makes the program use more memory, but gives a lot of performance back
        private Dictionary<IntPtr, byte[]> _cachedRegions;
        internal Dictionary<IntPtr, byte[]> GetRegions(Process process)
        {
            if (_cachedRegions != null)
            {
                return _cachedRegions;
            }

            const uint MEM_COMMIT = 0x1000;
            const uint PAGE_GUARD = 0x100;
            const uint PAGE_EXECUTE_ANY = 0xF0;

            List<MemoryRegion> regions = new List<MemoryRegion>();

            var mainModule = process.MainModule;

            IntPtr baseAddress = mainModule.BaseAddress;
            IntPtr regionAddress = baseAddress;
            IntPtr mainModuleEnd = baseAddress + mainModule.ModuleMemorySize;

            uint queryResult;

            do
            {
                MemoryRegion region = new MemoryRegion();
                queryResult = Kernel32.VirtualQueryEx(process.Handle, regionAddress, out region, (uint)Marshal.SizeOf(region));

                if (queryResult != 0)
                {
                    if ((region.State & MEM_COMMIT) != 0 &&
                        (region.Protect & PAGE_GUARD) == 0 &&
                        (region.Protect & PAGE_EXECUTE_ANY) != 0)
                    {
                        regions.Add(region);
                    }

                    regionAddress = (IntPtr)((ulong)region.BaseAddress.ToInt64() + region.RegionSize);
                }
            }
            while (queryResult != 0 && regionAddress.ToInt64() < mainModuleEnd.ToInt64());

            var memory = new Dictionary<IntPtr, byte[]>();

            foreach (MemoryRegion memRegion in regions)
            {
                memory[memRegion.BaseAddress] = ReadBytes(memRegion.BaseAddress, (int)memRegion.RegionSize);
            }

            _cachedRegions = memory;
            return memory;
        }

        internal bool ReadBoolean(IntPtr address)
        {
            int bytesRead = 0;
            byte[] bytes = new byte[1];

            Kernel32.ReadProcessMemory(_process.Handle, address, bytes, bytes.Length, ref bytesRead);

            return BitConverter.ToBoolean(bytes, 0);
        }

        internal byte ReadByte(IntPtr address)
        {
            int bytesRead = 0;
            byte[] bytes = new byte[1];

            Kernel32.ReadProcessMemory(_process.Handle, address, bytes, bytes.Length, ref bytesRead);

            return bytes[0];
        }

        internal byte[] ReadBytes(IntPtr address, int count)
        {
            int bytesRead = 0;
            byte[] bytes = new byte[count];

            Kernel32.ReadProcessMemory(_process.Handle, address, bytes, bytes.Length, ref bytesRead);

            return bytes;
        }

        internal int ReadInt32(IntPtr address)
        {
            int bytesRead = 0;
            byte[] bytes = new byte[4];

            Kernel32.ReadProcessMemory(_process.Handle, address, bytes, bytes.Length, ref bytesRead);

            return BitConverter.ToInt32(bytes, 0);
        }

        internal long ReadInt64(IntPtr address)
        {
            int bytesRead = 0;
            byte[] bytes = new byte[8];

            Kernel32.ReadProcessMemory(_process.Handle, address, bytes, bytes.Length, ref bytesRead);

            return BitConverter.ToInt64(bytes, 0);
        }

        internal float ReadFloat(IntPtr address)
        {
            int bytesRead = 0;
            byte[] bytes = new byte[4];

            Kernel32.ReadProcessMemory(_process.Handle, address, bytes, bytes.Length, ref bytesRead);

            return BitConverter.ToSingle(bytes, 0);
        }

        internal IntPtr ReadPtr(IntPtr ptr)
        {
            return (IntPtr)ReadInt32(ptr);
        }

        internal void Write(IntPtr address, uint value)
        {
            Kernel32.WriteProcessMemory(_process.Handle, address, BitConverter.GetBytes(value), 4, out _);
        }

        internal void Write(IntPtr address, byte[] bytes)
        {
            Kernel32.WriteProcessMemory(_process.Handle, address, bytes, (uint)bytes.Length, out _);
        }

        internal void WriteInt32(IntPtr address, int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            Write(address, bytes);
        }

        internal void WriteFloat(IntPtr address, float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            Write(address, bytes);
        }

        #region assembly execution
        //Stolen from Nordgaren, https://github.com/Nordgaren/DSR-Gadget-Local-Loader
        public IntPtr Allocate(uint size, uint flProtect = Kernel32.PAGE_READWRITE)
        {
            return Kernel32.VirtualAllocEx(_process.Handle, IntPtr.Zero, (IntPtr)size, Kernel32.MEM_COMMIT, flProtect);
        }

        public bool Free(IntPtr address)
        {
            return Kernel32.VirtualFreeEx(_process.Handle, address, IntPtr.Zero, Kernel32.MEM_RELEASE);
        }
        public uint Execute(IntPtr address, uint timeout = 0xFFFFFFFF)
        {
            IntPtr thread = Kernel32.CreateRemoteThread(_process.Handle, IntPtr.Zero, 0, address, IntPtr.Zero, 0, IntPtr.Zero);
            uint result = Kernel32.WaitForSingleObject(thread, timeout);
            Kernel32.CloseHandle(thread);
            return result;
        }
        public uint Execute(byte[] bytes, uint timeout = 0xFFFFFFFF)
        {
            IntPtr address = Allocate((uint)bytes.Length, Kernel32.PAGE_EXECUTE_READWRITE);
            Write(address, bytes);
            uint result = Execute(address, timeout);
            Free(address);
            return result;
        }
        #endregion
    }
}
