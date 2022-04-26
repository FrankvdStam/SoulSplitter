using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Native;

namespace SoulMemory.Shared
{
    public static class PatternScanner
    {
        public static long Scan(byte[] code, byte?[] pattern)
        {
            //Find the pattern
            for (int i = 0; i < code.Length - pattern.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (pattern[j] != null)
                    {
                        if (pattern[j] != code[i + j])
                        {
                            found = false;
                            break;
                        }
                    }
                }

                if (found)
                {
                    return i;
                }
            }
            return 0;
        }



        public static long Count(byte[] code, byte?[] pattern)
        {
            var count = 0;

            //Find the pattern
            for (int i = 0; i < code.Length - pattern.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (pattern[j] != null)
                    {
                        if (pattern[j] != code[i + j])
                        {
                            found = false;
                            break;
                        }
                    }
                }

                if (found)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
