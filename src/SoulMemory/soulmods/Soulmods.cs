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
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using SoulMemory.Native;

namespace SoulMemory.soulmods
{
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
        public string MethodName { get; set; }
    }

    public static class Soulmods
    {
        

        public static bool Inject(Process process)
        {
            var basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "soulsplitter");

            var dllPath64 = Path.Combine(basePath, @"x64\soulmods.dll");
            OverwriteFile("SoulMemory.soulmods.x64.soulmods.dll", dllPath64);

            if (process.Is64Bit())
            {
                process.InjectDll(dllPath64);
            }

            foreach (ProcessModule processModule in process.Modules)
            {
                if (processModule.ModuleName == "soulmods.dll")
                {
                    return true;
                }
            }
            return false;
        }

        public static MorphemeMessageBuffer GetMorphemeMessages2(Process process) => process.RustCall<MorphemeMessageBuffer>("GetQueuedDarkSouls2MorphemeMessages2");
        


        private static List<(string name, long address)> _soulmodsMethods;
        public static TSized RustCall<TSized>(this Process process, string function, TSized? parameter = null) where TSized : struct
        {
            if (_soulmodsMethods == null)
            {
                _soulmodsMethods = process.GetModuleExportedFunctions("soulmods.dll");
            }
            var functionPtr = _soulmodsMethods.First(i => i.name == function).address;

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
            var soulmods = process.GetModuleExportedFunctions("soulmods.dll");
            var func = soulmods.First(i => i.name == "GetQueuedDarkSouls2MorphemeMessages").address;

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

        private static void OverwriteFile(string manifestResourceName, string path)
        {
            byte[] buffer;
            using (var stream = typeof(Soulmods).Assembly.GetManifestResourceStream(manifestResourceName))
            {
                buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
            }
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            try
            {
                File.WriteAllBytes(path, buffer);

            }
            catch (IOException)
            {
                // ignore exception when overwriting existing file, may be in use by game process
            }

           
        }
    }
}
