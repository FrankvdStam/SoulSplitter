using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls1_Old.Internal
{
    public static class Extensions
    {
        public static int GetDigit(this int value, int index)
        {
            return (value % (index * 10)) - (value % index);
        }

        public static bool IsBitSet(this int b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        public static bool IsBitSet(this byte b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        public static byte?[] ToAob(this string aobStr)
        {
            var result = new List<byte?>();
            aobStr = aobStr.Replace("\r", string.Empty).Replace("\n", String.Empty);
            var split = aobStr.Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries);

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

        public static bool TryParseEnum<T>(this int value, out T result)
        {
            result = default;
            if (Enum.IsDefined(typeof(T), value))
            {
                result = (T)(object)value;
                return true;
            }
            return false;
        }

        public static bool TryParseEnum<T>(this uint value, out T result)
        {
            result = default;
            if (Enum.IsDefined(typeof(T), value))
            {
                result = (T)(object)value;
                return true;
            }
            return false;
        }


        public static void InsertSorted<T>(this LinkedList<T> list, T value) where T : IComparable<T>
        {
            if (list.Count == 0)
            {
                list.AddLast(value);

                return;
            }

            LinkedListNode<T> node = list.First;

            while (node != null && value.CompareTo(node.Value) > 0)
            {
                node = node.Next;
            }

            if (node == null)
            {
                list.AddLast(value);

                return;
            }

            list.AddBefore(node, value);
        }

        public static int ToHex(this int value)
        {
            string hex = value.ToString("X");

            // This function is used to compute categories (so you only need the first hex digit).
            return int.Parse(hex[0].ToString());
        }

        public static int ToHex(this byte value)
        {
            string hex = value.ToString("X");

            // This function is used to compute categories (so you only need the first hex digit).
            return int.Parse(hex[0].ToString());
        }



        // This function is used to strip the category off raw item flags. Felt most reasonable to include it in this
        // utility class.
        public static int StripHighestDigit(this int rawId, out int digit)
        {
            digit = rawId;

            int divisor = 1;

            // See https://stackoverflow.com/a/701355/7281613.
            while (digit > 10)
            {
                digit /= 10;
                divisor *= 10;
            }

            return rawId % divisor;
        }

        public static float DegreeToRadians(this decimal degree)
        {
            return (float)((double)degree / 360 * (Math.PI * 2) - Math.PI);
        }

        public static float DegreeToRadians(this float degree)
        {
            return (float)((double)degree / 360 * (Math.PI * 2) - Math.PI);
        }
    }
}
