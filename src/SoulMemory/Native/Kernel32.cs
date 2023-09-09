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
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SoulMemory.Native
{
    [ExcludeFromCodeCoverage]
    public static class Kernel32
    {
        #region Read process memory ==================================================================================================================

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        public static byte[] ReadProcessMemoryNoError(this Process process, long address, int size)
        {
            var buffer = new byte[size];
            var bytesRead = 0;
            ReadProcessMemory(process.Handle, (IntPtr)address, buffer, buffer.Length, ref bytesRead);
            return buffer;
        }

        public static ResultOk<byte[]> ReadProcessMemory(this Process process, long address, int size)
        {
            if (process == null)
            {
                return Result.Err();
            }

            var buffer = new byte[size];
            var bytesRead = 0;
            var result = ReadProcessMemory(process.Handle, (IntPtr)address, buffer, buffer.Length, ref bytesRead);

            if(!result || bytesRead != size)
            {
                return Result.Err();
            }
            return Result.Ok(buffer);
        }

        public static ResultOk<T> ReadMemory<T>(this Process process, long address, [CallerMemberName] string callerMemberName = null)
        {
            if (process == null)
            {
                return Result.Err();
            }
            
            var type = typeof(T);
            var size = Marshal.SizeOf(type);
            var bytes = process.ReadProcessMemory(address, size).Unwrap(callerMemberName);
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            var result = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), type);

            handle.Free();
            return Result.Ok(result);

            //TODO: find a conversion method that doesn't allocate memory
            //var test = (T)Convert.ChangeType(bytes, typeof(T));
        }

        [DllImport("kernel32.dll")]
        private static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MemoryBasicInformation64 lpBuffer, uint dwLength);
        [StructLayout(LayoutKind.Sequential)]
        public struct MemoryBasicInformation64
        {
            public ulong BaseAddress;
            public ulong AllocationBase;
            public int AllocationProtect;
            public int __alignment1;
            public ulong RegionSize;
            public int State;
            public int Protect;
            public int Type;
            public int __alignment2;
        }

        public static ResultOk<List<MemoryBasicInformation64>> GetMemoryRegions(this Process process)
        {
            if (process?.MainModule == null)
            {
                return Result.Err();
            }

            var result = new List<MemoryBasicInformation64>();
            var maxAddress = (process.MainModule.BaseAddress + process.MainModule.ModuleMemorySize).ToInt64();
            long address = process.MainModule.BaseAddress.ToInt64();

            while (address < maxAddress)
            {
                var queryEx = VirtualQueryEx(process.Handle, (IntPtr)address, out MemoryBasicInformation64 memoryBasicInformation64, (uint)Marshal.SizeOf(typeof(MemoryBasicInformation64)));
                if (queryEx == 0)
                {
                    return Result.Err();
                }
                result.Add(memoryBasicInformation64);
                address = (long)memoryBasicInformation64.BaseAddress + (long)memoryBasicInformation64.RegionSize;
            }
            return Result.Ok(result);
        }
        #endregion

        #region Write process memory ==================================================================================================================

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesWritten);

        public static void WriteProcessMemoryNoError(this Process process, long address, byte[] buffer) => WriteProcessMemory(process, address, buffer);

        public static Result WriteProcessMemory(this Process process, long address, byte[] buffer)
        {
            var result = WriteProcessMemory(process.Handle, (IntPtr)address, buffer, (uint)buffer.Length, out uint bytesWritten);

            if (!result || bytesWritten != buffer.Length)
            {
                return Result.Err();
            }
            return Result.Ok();
        }

        #endregion

        #region misc process  ==================================================================================================================

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool IsWow64Process(IntPtr processHandle, out bool wow64Process);

        public static ResultOk<bool> Is64Bit(this Process process)
        {
            var result = IsWow64Process(process.Handle, out bool isWow64Result);
            if (!result)
            {
                return Result.Err();
            }
            return Result.Ok(!isWow64Result);
        }

        #endregion

        #region Allocations ==================================================================================================================


        [DllImport("kernel32.dll")]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

        public static IntPtr Allocate(this Process process, int size)
        {
            return VirtualAllocEx(process.Handle, IntPtr.Zero, (IntPtr)size, MEM_COMMIT, PAGE_EXECUTE_READWRITE);
        }

        [DllImport("kernel32.dll")]
        private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint dwFreeType);

        public static void Free(this Process process, IntPtr pointer) => VirtualFreeEx(process.Handle, pointer, (IntPtr)0, MEM_RELEASE);

        #endregion

        #region Execute ==================================================================================================================

        [DllImport("kernel32.dll")]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll")]
        private static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr hObject);

        public static void Execute(this Process process, byte[] instructions, IntPtr? parameter = null)
        {
            var address = process.Allocate(instructions.Length);
            process.WriteProcessMemory((long)address, instructions);
            process.Execute(address, parameter);
            process.Free(address);
        }

        public static void Execute(this Process process, IntPtr startAddress, IntPtr? parameter = null)
        {
            process.NtSuspendProcess();
            IntPtr thread;
            if(parameter.HasValue)
            {
                thread = CreateRemoteThread(process.Handle, IntPtr.Zero, 0, startAddress, parameter.Value, 0, IntPtr.Zero);
            }
            else
            {
                thread = CreateRemoteThread(process.Handle, IntPtr.Zero, 0, startAddress, IntPtr.Zero, 0, IntPtr.Zero);
            }
            WaitForSingleObject(thread, 5000);
            process.NtResumeProcess();
            CloseHandle(thread);
        }

        #endregion

        #region DLL injection ==================================================================================================================

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        internal static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        public static void InjectDll(this Process process, string dllPath)
        {
            //Make sure path is null terminated
            if(!dllPath.EndsWith("\0"))
            {
                dllPath = dllPath + '\0';
            }

            //Write the name of the dll to be injected into a buffer
            var dllFilepathPointer = process.Allocate(dllPath.Length * Marshal.SizeOf(typeof(char)));
            process.WriteProcessMemory((long)dllFilepathPointer, Encoding.Default.GetBytes(dllPath));

            //Get the address of LoadLibraryA
            var loadLibraryA = Kernel32.GetProcAddress(Kernel32.GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            //Execute LoadLibraryA inside the target process with the dll path as parameter
            process.Execute(loadLibraryA, dllFilepathPointer);

            //Cleanup
            process.Free(dllFilepathPointer);
        }

        #endregion


        public const uint PAGE_EXECUTE_READWRITE = 0x40;
        public const uint PAGE_READWRITE = 0x04;
        public const uint MEM_COMMIT = 0x00001000;
        public const uint MEM_RESERVE = 0x00002000;
        public const uint MEM_RELEASE = 0x00008000;

        public const int PROCESS_CREATE_THREAD = 0x0002;
        public const int PROCESS_QUERY_INFORMATION = 0x0400;
        public const int PROCESS_VM_OPERATION = 0x0008;
        public const int PROCESS_VM_WRITE = 0x0020;
        public const int PROCESS_VM_READ = 0x0010;

    }
}
