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
                    if (pattern[j] != null && pattern[j] != code[i + j])
                    {
                        found = false;
                        break;                        
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
                    if (pattern[j] != null && pattern[j] != code[i + j])
                    {
                        found = false;
                        break;
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
