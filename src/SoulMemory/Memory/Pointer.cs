using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using SoulMemory.Native;

namespace SoulMemory.Shared
{
    public class Pointer
    {
        public Pointer(Process process, bool is64Bit, long baseAddress, params long[] offsets)
        {
            Process     = process;
            Is64Bit     = is64Bit;
            BaseAddress = baseAddress;
            Offsets     = offsets.ToList();
        }

        public Pointer Copy()
        {
            return new Pointer(Process, Is64Bit, BaseAddress, Offsets.ToArray());
        }

        /// <summary>
        /// Creates a new pointer with the address of the old pointer as base address
        /// </summary>
        /// <returns></returns>
        public Pointer CreatePointerFromAddress(long? offset = null)
        {
            var copy = Copy();
            var offsets = Offsets.ToList();
            if (offset.HasValue)
            {
                offsets.Add(offset.Value);
            }
            offsets.Add(0);

            copy.BaseAddress = ResolveOffsets(offsets);
            copy.Offsets.Clear();
            return copy;
        }

        public Process Process;
        public long BaseAddress;
        public List<long> Offsets;
        public bool Is64Bit;

        private long ResolveOffsets(List<long> offsets, StringBuilder debugStringBuilder = null)
        {
            debugStringBuilder?.Append($" 0x{BaseAddress:x}");

            long ptr = BaseAddress;
            for (int i = 0; i < offsets.Count; i++)
            {
                var offset = offsets[i];

                //Create a copy for debug output
                var debugCopy = ptr;

                //Resolve an offset
                var address = ptr + offset;

                //Not the last offset = resolve as pointer
                int unused = 0;
                if (i + 1 < offsets.Count)
                {
                    if (Is64Bit)
                    {
                        var buffer = new byte[8];
                        Kernel32.ReadProcessMemory(Process.Handle, (IntPtr)address, buffer, buffer.Length, ref unused);
                        ptr = BitConverter.ToInt64(buffer, 0);
                    }
                    else
                    {
                        var buffer = new byte[4];
                        Kernel32.ReadProcessMemory(Process.Handle, (IntPtr)address, buffer, buffer.Length, ref unused);
                        ptr = BitConverter.ToInt32(buffer, 0);
                    }

                    debugStringBuilder?.Append($"\r\n[0x{debugCopy:x} + 0x{offset:x}]: 0x{ptr:x}");

                    if (ptr == 0)
                    {
                        return 0;
                    }
                }
                else
                {
                    ptr = address;
                    debugStringBuilder?.Append($"\r\n 0x{debugCopy:x} + 0x{offset:x}: 0x{ptr:x}");
                }
            }

            return ptr;
        }


        //Debug representation, shows in IDE
        public string Path { get; private set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            ResolveOffsets(Offsets, sb);
            Path = sb.ToString();
            return Path;
        }

        #region Read/write memory

        private byte[] ReadMemory(long? offset, int length)
        { 
            int bytesRead = 0;
            byte[] buffer = new byte[length];

            var offsetsCopy = Offsets.ToList();
            if (offset.HasValue)
            {
                offsetsCopy.Add(offset.Value);
            }

            var address = (IntPtr)ResolveOffsets(offsetsCopy);
            Kernel32.ReadProcessMemory(Process.Handle, address, buffer, length, ref bytesRead);
            return buffer;
        }

        private void WriteMemory(long? offset, byte[] bytes)
        {
            var offsetsCopy = Offsets.ToList();
            if (offset.HasValue)
            {
                offsetsCopy.Add(offset.Value);
            }
            var address = ResolveOffsets(offsetsCopy);
            Kernel32.WriteProcessMemory(Process.Handle, (IntPtr)address, bytes, (uint)bytes.Length, out uint written);
        }

        public bool IsNullPtr()
        {
            return GetAddress() == 0;
        }

        public long GetAddress()
        {
            return ResolveOffsets(Offsets);
        }

        #region Read
        public int ReadInt32(long? offset = null)
        {
            return BitConverter.ToInt32(ReadMemory(offset, 4), 0);
        }

        public long ReadInt64(long? offset = null)
        {
            return BitConverter.ToInt64(ReadMemory(offset, 8), 0);
        }

        public bool ReadBool(long? offset = null)
        {
            return BitConverter.ToBoolean(ReadMemory(offset, 1), 0);
        }
        public byte ReadByte(long? offset = null)
        {
            return ReadMemory(offset, 1)[0];
        }

        public byte[] ReadBytes(int size, long? offset = null)
        {
            return ReadMemory(offset, size);
        }

        public float ReadFloat(long? offset = null)
        {
            return BitConverter.ToSingle(ReadMemory(offset, 4), 0);
        }
        #endregion

        #region Write

        public void WriteInt32(int value) => WriteInt32(null, value);
        

        public void WriteInt32(long? offset, int value)
        {
            WriteMemory(offset, BitConverter.GetBytes(value));
        }

        public void WriteInt64(long? offset, long value)
        {
            WriteMemory(offset, BitConverter.GetBytes(value));
        }

        public void WriteBool(long? offset, bool value)
        {
            WriteMemory(offset, BitConverter.GetBytes(value));
        }
        
        public void WriteByte(long? offset, byte value)
        {
            WriteMemory(offset, new byte[]{value});
        }

        public void WriteBytes(long? offset, byte[] value)
        {
            WriteMemory(offset, value);
        }

        public void WriteFloat(float value) => WriteFloat(null, value);

        public void WriteFloat(long? offset, float value)
        {
            WriteMemory(offset, BitConverter.GetBytes(value));
        }

        #endregion

        #endregion

        #region Assembly

        private IntPtr Allocate(uint size, uint flProtect = Kernel32.PAGE_READWRITE)
        {
            return Kernel32.VirtualAllocEx(Process.Handle, IntPtr.Zero, (IntPtr)size, Kernel32.MEM_COMMIT, flProtect);
        }

        private bool Free(IntPtr address)
        {
            return Kernel32.VirtualFreeEx(Process.Handle, address, IntPtr.Zero, Kernel32.MEM_RELEASE);
        }
        public uint Execute(IntPtr address, uint timeout = 0xFFFFFFFF)
        {
            IntPtr thread = Kernel32.CreateRemoteThread(Process.Handle, IntPtr.Zero, 0, address, IntPtr.Zero, 0, IntPtr.Zero);
            uint result = Kernel32.WaitForSingleObject(thread, timeout);
            Kernel32.CloseHandle(thread);
            return result;
        }
        public uint Execute(byte[] bytes, uint timeout = 0xFFFFFFFF)
        {
            IntPtr address = Allocate((uint)bytes.Length, Kernel32.PAGE_EXECUTE_READWRITE);
            Kernel32.WriteProcessMemory(Process.Handle, address, bytes, (uint)bytes.Length, out _);
            uint result = Execute(address, timeout);
            Free(address);
            return result;
        }

        #endregion
    }
}
