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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace SoulMemory.soulmods;

[StructLayout(LayoutKind.Sequential)]
public struct MorphemeMessage
{
    public uint MessageId;
    public uint EventActionCategory;
}

[StructLayout(LayoutKind.Sequential)]
public struct MorphemeMessageBuffer
{
    public uint Length;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public MorphemeMessage[] Buffer;
}

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class RustCallAttribute : Attribute
{
    public string MethodName { get; set; } = null!;
}

public static class Soulmods
{
    private static string SoulmodsModuleName(this Process process)
    {
        return process.Is64Bit().Unwrap() ? "soulmods_x64.dll" : "soulmods_x86.dll";
    }

    public static ResultOk<Dictionary<string, long>> Inject(Process process)
    {
        var dir = Path.GetDirectoryName(typeof(Soulmods).Assembly.Location)!;
        var soulmodsModuleName = process.SoulmodsModuleName();
        var path = Path.Combine(dir, soulmodsModuleName);

        //potentially its already injecting, if this is the case we re-use it
        var modules = process.GetModulesViaSnapshot();
        if (modules.Any(processModule => processModule.szModule == soulmodsModuleName))
        {
            _soulmodsExports = process.GetModuleExports(soulmodsModuleName);
            return Result.Ok(_soulmodsExports);
        }

        //If not, inject
        process.InjectDll(path);

        //Make sure it is in the module list now
        modules = process.GetModulesViaSnapshot();
        if (modules.Any(processModule => processModule.szModule == soulmodsModuleName))
        {
            _soulmodsExports = process.GetModuleExports(soulmodsModuleName);
            return Result.Ok(_soulmodsExports);
        }

        return Result.Err();
    }

    private static Dictionary<string, long>? _soulmodsExports;


    /*
    public static MorphemeMessageBuffer GetMorphemeMessages2(Process process) => process.RustCall<MorphemeMessageBuffer>("GetQueuedDarkSouls2MorphemeMessages2");
    
    public static TSized RustCall<TSized>(this Process process, string function, TSized? parameter = null) where TSized : struct
    {
        _soulmodsExports ??= process.GetModuleExports(process.Is64Bit().Unwrap() ? "soulmods_x64.dll" :"soulmods_x86.dll");
        var functionPtr = _soulmodsExports[function];

        var buffer = process.Allocate(Marshal.SizeOf<TSized>());
        if (parameter.HasValue)
        {
            process.WriteMemory(buffer.ToInt64(), parameter.Value);
        }
        process.Execute((IntPtr)functionPtr, buffer);
        var result = process.ReadMemory<TSized>(buffer.ToInt64()).Unwrap();
        process.Free(buffer);
        return result;
    }


    public static void GetMorphemeMessages(Process process)
    {
        //Get function address
        var soulmods = process.GetModuleExports(process.Is64Bit().Unwrap() ? "soulmods_x64.dll" : "soulmods_x86.dll");
        var func = soulmods["GetQueuedDarkSouls2MorphemeMessages"];

        //Get buffer size
        var buffer = process.Allocate(4);
        process.Execute((IntPtr)func, buffer);
        var requestedSize = process.ReadMemory<uint>(buffer.ToInt64()).Unwrap();
        process.Free(buffer);

        //Get data of requestedSize
        if (requestedSize > 0)
        {
            var totalSize = (int)(4 + (requestedSize * Marshal.SizeOf<MorphemeMessage>()));
            buffer = process.Allocate(totalSize);
            process.WriteProcessMemory(buffer.ToInt64(), BitConverter.GetBytes(requestedSize));
            process.Execute((IntPtr)func, buffer);

            var data = process.ReadProcessMemory(buffer.ToInt64(), totalSize).Unwrap();
            process.Free(buffer);
        }
    }
    */
}
