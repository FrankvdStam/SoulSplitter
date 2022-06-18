using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Native;

namespace SoulMemory.Memory
{
    public static class Extensions
    {
        public static byte?[] ToByteArray(this string pattern)
        {
            var result = new List<byte?>();
            pattern = pattern.Replace("\r", string.Empty).Replace("\n", string.Empty);
            var split = pattern.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in split)
            {
                if (s != "?" && s != "??" && s != "x" && s != "xx")
                {
                    result.Add(Convert.ToByte(s, 16));
                }
                else
                {
                    result.Add(null);
                }
            }
            return result.ToArray();
        }

        public static string ToHexString(this byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", " ");
        }

        public static string ToHexString(this byte?[] bytes)
        {
            var sb = new StringBuilder();
            foreach (var b in bytes)
            {
                if (b == null)
                {
                    sb.Append("?");
                }
                else
                {
                    sb.AppendFormat("{0:x2}", b);
                }
            }

            return sb.ToString();
        }

        public static string GetDisplayName(this Enum enumValue)
        {
            var displayName = enumValue
                .GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                .GetCustomAttribute<DisplayAttribute>()?
                .GetName();

            if (string.IsNullOrEmpty(displayName))
            {
                displayName = enumValue.ToString();
            }
            return displayName;
        }

        public static string GetDisplayDescription(this Enum enumValue)
        {
            var displayName = enumValue
                .GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                .GetCustomAttribute<DisplayAttribute>()?
                .GetDescription();

            if (string.IsNullOrEmpty(displayName))
            {
                displayName = enumValue.ToString();
            }
            return displayName;
        }


        public static byte[] ReadMemory(this Process process, IntPtr address, int size)
        {
            var readBuffer = new byte[size];
            int readBytes = 0;
            Kernel32.ReadProcessMemory(process.Handle, address, readBuffer, readBuffer.Length, ref readBytes);
            return readBuffer;
        }

        public static T ReadMemory<T>(this Process process, IntPtr address)
        {
            var type = typeof(T);
            var size = Marshal.SizeOf(type);
            var bytes = process.ReadMemory(address, size);
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            var result = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), type);
            handle.Free();
            return result;
        }

        public static bool WriteMemory(this Process process, IntPtr address, byte[] bytes)
        {
            uint writtenBytes = 0;
            var result = Kernel32.WriteProcessMemory(process.Handle, address, bytes, (uint)bytes.Length, out writtenBytes);
            return result && writtenBytes == bytes.Length;
        }

        public static void InjectDll(this Process process, string dllPath)
        {
            //Get a process handle
            IntPtr processHandle = Kernel32.OpenProcess(Kernel32.PROCESS_CREATE_THREAD |
                                                        Kernel32.PROCESS_QUERY_INFORMATION |
                                                        Kernel32.PROCESS_VM_OPERATION |
                                                        Kernel32.PROCESS_VM_WRITE |
                                                        Kernel32.PROCESS_VM_READ, false, process.Id);

            //Allocate a buffer in the target process, copy the path to the target dll into this 
            IntPtr allocatedDllFileName = Kernel32.VirtualAllocEx(processHandle, IntPtr.Zero, (IntPtr)((dllPath.Length + 1) * Marshal.SizeOf(typeof(char))), Kernel32.MEM_COMMIT | Kernel32.MEM_RESERVE, Kernel32.PAGE_READWRITE);
            Kernel32.WriteProcessMemory(processHandle, allocatedDllFileName, Encoding.Default.GetBytes(dllPath), (uint)((dllPath.Length + 1) * Marshal.SizeOf(typeof(char))), out uint _);

            //Get handles to library loading related functions
            IntPtr loadLibraryA = Kernel32.GetProcAddress(Kernel32.GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            //Load dll by having the target process call loadLibraryA
            var loadThread = Kernel32.CreateRemoteThread(processHandle, IntPtr.Zero, 0, loadLibraryA, allocatedDllFileName, 0, IntPtr.Zero);
            Kernel32.WaitForSingleObject(loadThread, 10000);

            Kernel32.VirtualFreeEx(processHandle, allocatedDllFileName, IntPtr.Zero, Kernel32.MEM_RELEASE);
        }
    }
}
