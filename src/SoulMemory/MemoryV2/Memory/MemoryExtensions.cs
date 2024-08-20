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
using System.Linq;
using System.Text;

namespace SoulMemory.MemoryV2.Memory
{
    public static class MemoryExtensions
    {
        #region Pointers

        public static Pointer Pointer64(this IMemory memory, params long[] offsets)
        {
            var sourceMemory = memory;
            
            if (memory is Pointer p)
            {
                //Pointers read memory relatively, must get their source to keep reading correctly
                sourceMemory = p.Memory;
                var temp = p.Path.Select(i => i.Offset).ToList();
                temp.AddRange(offsets);
                offsets = temp.ToArray();
            }

            return new Pointer(sourceMemory, offsets);
        }

        #endregion

        #region Reading
        
        public static byte ReadByte(this IMemory memory, long offset)
        {
            return memory.ReadBytes(offset, 1)[0];
        }

        public static sbyte ReadSByte(this IMemory memory, long offset)
        {
            var b = memory.ReadBytes(offset, 1)[0];
            return unchecked((sbyte)b); //unchecked -> overflow allowed
        }

        public static short ReadInt16(this IMemory memory, long offset)
        {
            return BitConverter.ToInt16(memory.ReadBytes(offset, 2), 0);
        }

        public static ushort ReadUInt16(this IMemory memory, long offset)
        {
            return BitConverter.ToUInt16(memory.ReadBytes(offset, 2), 0);
        }
        
        public static int ReadInt32(this IMemory memory, long offset)
        {
            return BitConverter.ToInt32(memory.ReadBytes(offset, 4), 0);
        }

        public static uint ReadUInt32(this IMemory memory, long offset)
        {
            return BitConverter.ToUInt32(memory.ReadBytes(offset, 4), 0);
        }
        
        public static long ReadInt64(this IMemory memory, long offset)
        {
            return BitConverter.ToInt64(memory.ReadBytes(offset, 8), 0);
        }

        public static ulong ReadUInt64(this IMemory memory, long offset)
        {
            return BitConverter.ToUInt64(memory.ReadBytes(offset, 8), 0);
        }

        public static float ReadFloat(this IMemory memory, long offset)
        {
            return BitConverter.ToSingle(memory.ReadBytes(offset, 4), 0);
        }

        public static double ReadDouble(this IMemory memory, long offset)
        {
            return BitConverter.ToDouble(memory.ReadBytes(offset, 8), 0);
        }

        public static string ReadUnicodeString(this IMemory memory, long offset, out int length, int maxSize = 1000)
        {
            var data = memory.ReadBytes(offset, maxSize);
            length = 0;
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i - 1] == 0 && data[i] == 0)
                {
                    length = i;
                    break;
                }
            }
        
            return Encoding.Unicode.GetString(data);
        }

        #endregion

        #region Writing
        
        public static void WriteByte(this IMemory memory, long offset, byte value)
        {
            memory.WriteBytes(offset, new byte[] { value });
        }

        public static void WriteSByte(this IMemory memory, long offset, sbyte value)
        {
            var b = unchecked((byte)value);
            memory.WriteBytes(offset, new byte[] { b });
        }

        public static void WriteInt16(this IMemory memory, long offset, short value)
        {
            memory.WriteBytes(offset, BitConverter.GetBytes(value));
        }
        
        public static void WriteUInt16(this IMemory memory, long offset, ushort value)
        {
            memory.WriteBytes(offset, BitConverter.GetBytes(value));
        }

        public static void WriteInt32(this IMemory memory, long offset, int value)
        {
            memory.WriteBytes(offset, BitConverter.GetBytes(value));
        }
        
        public static void WriteUInt32(this IMemory memory, long offset, uint value)
        {
            memory.WriteBytes(offset, BitConverter.GetBytes(value));
        }

        public static void WriteInt64(this IMemory memory, long offset, long value)
        {
            memory.WriteBytes(offset, BitConverter.GetBytes(value));
        }

        public static void WriteUInt64(this IMemory memory, long offset, ulong value)
        {
            memory.WriteBytes(offset, BitConverter.GetBytes(value));
        }

        public static void WriteFloat(this IMemory memory, long offset, float value)
        {
            memory.WriteBytes(offset, BitConverter.GetBytes(value));
        }

        public static void WriteDouble(this IMemory memory, long offset, double value)
        {
            memory.WriteBytes(offset, BitConverter.GetBytes(value));
        }

        #endregion
    }
}
