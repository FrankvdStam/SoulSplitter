using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory
{
    public static class Extensions
    {
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
    }
}
