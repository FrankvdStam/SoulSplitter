using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
