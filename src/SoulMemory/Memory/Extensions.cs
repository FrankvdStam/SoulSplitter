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
    }
}
