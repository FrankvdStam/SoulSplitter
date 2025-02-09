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
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using SoulMemory.Native.Enums;
using SoulMemory.Native.Structs;
using SoulMemory.Native.Structs.Image;
using SoulMemory.Native.Structs.Module;

namespace SoulMemory.Native;

[ExcludeFromCodeCoverage]
public static class Kernel32
{
    #region Read process memory ==================================================================================================================


    public static byte[] ReadProcessMemoryNoError(this Process process, long address, int size)
    {
        var buffer = new byte[size];
        var bytesRead = 0;
        NativeMethods.ReadProcessMemory(process.Handle, (IntPtr)address, buffer, buffer.Length, ref bytesRead);
        return buffer;
    }

    public static ResultOk<byte[]> ReadProcessMemory(this Process process, long address, int size)
    {
        var buffer = new byte[size];
        var bytesRead = 0;
        var result = NativeMethods.ReadProcessMemory(process.Handle, (IntPtr)address, buffer, buffer.Length, ref bytesRead);

        if(!result || bytesRead != size)
        {
            return Result.Err();
        }
        return Result.Ok(buffer);
    }

    public static ResultOk<T> ReadMemory<T>(this Process process, long address, [CallerMemberName] string? callerMemberName = null)
    {
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

    public static Result WriteMemory<T>(this Process process, long address, T data, [CallerMemberName] string? callerMemberName = null)
    {
        var type = typeof(T);
        var size = Marshal.SizeOf(type);
        var bytes = new byte[size];
        var ptr = IntPtr.Zero;
        try
        {
            ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(data, ptr, true);
            Marshal.Copy(ptr, bytes, 0, size);
        }
        finally
        {
            Marshal.FreeHGlobal(ptr);
        }

        process.WriteProcessMemory(address, bytes);
        return Result.Ok();
    }

    public static string ReadAsciiString(this Process process, long address, int initialBufferSize = 20, [CallerMemberName] string? callerMemberName = null)
    {
        var endByte = (byte)'\0';
        var bytes = Array.Empty<byte>();
        while (!bytes.Contains(endByte))
        {
            if (initialBufferSize > 100000)
            {
                throw new ArgumentException($"String at {address} is too big.");
            }

            bytes = process.ReadProcessMemory(address, initialBufferSize).Unwrap(callerMemberName);
            initialBufferSize *= 2;
        }

        var endIndex = Array.IndexOf(bytes, endByte);
        var str = Encoding.ASCII.GetString(bytes, 0, endIndex);
        return str;
    }
    
    

    public static ResultOk<List<MemoryBasicInformation64>> GetMemoryRegions(this Process process)
    {
        if (process.MainModule == null)
        {
            return Result.Err();
        }

        var result = new List<MemoryBasicInformation64>();
        var maxAddress = (process.MainModule.BaseAddress + process.MainModule.ModuleMemorySize).ToInt64();
        var address = process.MainModule.BaseAddress.ToInt64();

        while (address < maxAddress)
        {
            var queryEx = NativeMethods.VirtualQueryEx(process.Handle, (IntPtr)address, out var memoryBasicInformation64, (uint)Marshal.SizeOf(typeof(MemoryBasicInformation64)));
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

    public static void WriteProcessMemoryNoError(this Process process, long address, byte[] buffer) => WriteProcessMemory(process, address, buffer);

    public static Result WriteProcessMemory(this Process process, long address, byte[] buffer)
    {
        var result = NativeMethods.WriteProcessMemory(process.Handle, (IntPtr)address, buffer, (uint)buffer.Length, out var bytesWritten);

        if (!result || bytesWritten != buffer.Length)
        {
            return Result.Err();
        }
        return Result.Ok();
    }

    #endregion

    #region misc process  ==================================================================================================================

    

    public static ResultOk<bool> Is64Bit(this Process process)
    {
        var result = NativeMethods.IsWow64Process(process.Handle, out var isWow64Result);
        if (!result)
        {
            return Result.Err();
        }
        return Result.Ok(!isWow64Result);
    }

    #endregion

    #region Allocations ==================================================================================================================


   
    public static IntPtr Allocate(this Process process, int size)
    {
        return NativeMethods.VirtualAllocEx(process.Handle, IntPtr.Zero, (IntPtr)size, MEM_COMMIT, PAGE_EXECUTE_READWRITE);
    }


    public static void Free(this Process process, IntPtr pointer) => NativeMethods.VirtualFreeEx(process.Handle, pointer, (IntPtr)0, MEM_RELEASE);

    #endregion

    #region Execute ==================================================================================================================

   

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
        var thread = NativeMethods.CreateRemoteThread(process.Handle, IntPtr.Zero, 0, startAddress, parameter ?? IntPtr.Zero, 0, IntPtr.Zero);
        NativeMethods.WaitForSingleObject(thread, 5000);
        process.NtResumeProcess();
        NativeMethods.CloseHandle(thread);
    }

    #endregion

    #region DLL injection ==================================================================================================================

    

    public static void InjectDll(this Process process, string dllPath)
    {
        //Make sure path is null terminated
        if(!dllPath.EndsWith("\0"))
        {
            dllPath = dllPath + '\0';
        }

        //Write the name of the dll to be injected into a buffer
        var dllFilepathPointer = process.Allocate(dllPath.Length * Marshal.SizeOf(typeof(UInt16)));
        process.WriteProcessMemory((long)dllFilepathPointer, Encoding.Unicode.GetBytes(dllPath));

        //Get the address of LoadLibraryW
        var loadLibraryW = NativeMethods.GetProcAddress(NativeMethods.GetModuleHandleW("kernel32.dll"), "LoadLibraryW");

        //Execute LoadLibraryA inside the target process with the dll path as parameter
        process.Execute(loadLibraryW, dllFilepathPointer);

        //Cleanup
        process.Free(dllFilepathPointer);
    }

    #endregion

    #region Remote modules ==================================================================================================================

    

    // To avoid cleaning the list,
    // the number of modules is returned with a tuple
    public static (IntPtr[] List, uint Length) GetProcessModules(this Process process)
    {
        uint arraySize = 256;
        var processMods = new IntPtr[arraySize];
        var arrayBytesSize = arraySize * (uint)IntPtr.Size;
        uint bytesCopied = 0;

        // Loop until all modules are listed
        // See: https://docs.microsoft.com/en-us/windows/win32/api/psapi/nf-psapi-enumprocessmodules#:~:text=If%20lpcbNeeded%20is%20greater%20than%20cb%2C%20increase%20the%20size%20of%20the%20array%20and%20call%20EnumProcessModules%20again.
        // Stops if:
        //   - EnumProcessModulesEx return 0 (call failed)
        //   - All modules are listed
        //   - The next size of the list is greater than uint.MaxValue
        while (NativeMethods.EnumProcessModulesEx(process.Handle, processMods, arrayBytesSize, out bytesCopied, ListModules.LIST_MODULES_ALL) &&
               arrayBytesSize == bytesCopied && arraySize <= uint.MaxValue - 128)
        {
            arraySize += 128;
            processMods = new IntPtr[arraySize];
            arrayBytesSize = arraySize * (uint)IntPtr.Size;
        }

        return (List: processMods, Length: bytesCopied >> 2);
    }


    // get the parent process given a pid
    public static List<MODULEENTRY32W> GetModulesViaSnapshot(this Process process)
    {
        var modules = new List<MODULEENTRY32W>();
        var handleToSnapshot = IntPtr.Zero;

        void CleanupSnapshot()
        {
            if (handleToSnapshot != IntPtr.Zero)
            {
                NativeMethods.CloseHandle(handleToSnapshot);
                handleToSnapshot = IntPtr.Zero;
            }
        }
        
        try
        {
            var procEntry = new MODULEENTRY32W();
            procEntry.dwSize = (UInt32)Marshal.SizeOf(typeof(MODULEENTRY32W));
            handleToSnapshot = NativeMethods.CreateToolhelp32Snapshot((uint)SnapshotFlags.Module | (uint)SnapshotFlags.Module32, (uint)process.Id);
            if (NativeMethods.Module32FirstW(handleToSnapshot, ref procEntry))
            {
                do
                {
                    modules.Add(procEntry);
                } while (NativeMethods.Module32NextW(handleToSnapshot, ref procEntry));
            }
            else
            {
                throw new Win32Exception(Marshal.GetLastWin32Error(), "Module32FirstW failed");
            }
        }
        catch
        {
            CleanupSnapshot();
            throw;
        }
        finally
        {
            CleanupSnapshot();
        }
        return modules;
    }


    

    public static Dictionary<string, long> GetModuleExports(this Process process, string hModuleName)
    {
        var modules = process.GetModulesViaSnapshot();
        var module = modules.First(i => i.szModule.ToLowerInvariant() == hModuleName.ToLowerInvariant());

        var moduleImageDosHeader = process.ReadMemory<IMAGE_DOS_HEADER>(module.modBaseAddr.ToInt64()).Unwrap();
        //moduleImageDosHeader.isValid

        uint exportTableAddress = 0;
        if (Is64Bit(process).Unwrap())
        {
            var moduleImageNtHeaders = process.ReadMemory<IMAGE_NT_HEADERS64>(module.modBaseAddr.ToInt64() + moduleImageDosHeader.e_lfanew).Unwrap();
            //moduleImageNtHeaders.isValid

            exportTableAddress = moduleImageNtHeaders.OptionalHeader.ExportTable.VirtualAddress;
        }
        else
        {
            var moduleImageNtHeaders = process.ReadMemory<IMAGE_NT_HEADERS32>(module.modBaseAddr.ToInt64() + moduleImageDosHeader.e_lfanew).Unwrap();
            //moduleImageNtHeaders.isValid

            exportTableAddress = moduleImageNtHeaders.OptionalHeader.ExportTable.VirtualAddress;
        }

        var exportTable = process.ReadMemory<IMAGE_EXPORT_DIRECTORY>(module.modBaseAddr.ToInt64() + exportTableAddress).Unwrap();

        var nameOffsetTable = module.modBaseAddr.ToInt64() + exportTable.AddressOfNames;
        var ordinalTable = module.modBaseAddr.ToInt64() + exportTable.AddressOfNameOrdinals;
        var functionOffsetTable = module.modBaseAddr.ToInt64() + exportTable.AddressOfFunctions;

        var functions = new Dictionary<string, long>();
        for (var i = 0; i < exportTable.NumberOfNames; i++)
        {
            //Function name offset is an array of 4byte numbers
            var functionNameOffset = process.ReadMemory<uint>(nameOffsetTable + i * sizeof(uint)).Unwrap();
            var functionName = process.ReadAsciiString(module.modBaseAddr.ToInt64() + functionNameOffset);

            //Ordinal seems to be an index
            process.ReadMemory<ushort>(ordinalTable + i * sizeof(ushort)).Unwrap();

            //Function offset table is an array of 4byte numbers
            var functionOffset = process.ReadMemory<uint>(functionOffsetTable + i * sizeof(uint)).Unwrap();
            var functionAddress = module.modBaseAddr.ToInt64() + functionOffset;

            functions.Add(functionName, functionAddress);
        }

        return functions;
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

    public const int LIST_MODULES_32BIT = 0x01;
    public const int LIST_MODULES_64BIT = 0x02;
    public const int LIST_MODULES_ALL = 0x03;


}
