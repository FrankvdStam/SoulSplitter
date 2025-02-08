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
using System.Text;

namespace SoulMemory.Memory;

public interface IMemory
{
    byte[] ReadBytes(long? offset, int length);
    void WriteBytes(long? offset, byte[] bytes);
}

public class ByteArrayMemory(byte[] data) : IMemory
{
    public byte[] ReadBytes(long? offset, int length)
    {
        offset ??= 0;

        var buffer = new byte[length];
        Array.Copy(data, offset.Value, buffer, 0, length);
        return buffer;
    }

    public void WriteBytes(long? offset, byte[] bytes)
    {
        offset ??= 0;

        for (var i = 0; i < bytes.Length; i++)
        {
            data[offset.Value + i] = bytes[i];
        }
    }
}

public static class MemoryExtensions
{
    #region Read
    public static byte[] ReadBytes(this IMemory memory, int length) => memory.ReadBytes(null, length);

    public static int ReadInt32(this IMemory memory, long? offset = null)
    {
        return BitConverter.ToInt32(memory.ReadBytes(offset, 4), 0);
    }
    public static uint ReadUInt32(this IMemory memory, long? offset = null)
    {
        return BitConverter.ToUInt32(memory.ReadBytes(offset, 4), 0);
    }

    public static long ReadInt64(this IMemory memory, long? offset = null)
    {
        return BitConverter.ToInt64(memory.ReadBytes(offset, 8), 0);
    }

    public static bool ReadBool(this IMemory memory, long? offset = null)
    {
        return BitConverter.ToBoolean(memory.ReadBytes(offset, 1), 0);
    }
    public static byte ReadByte(this IMemory memory, long? offset = null)
    {
        return memory.ReadBytes(offset, 1)[0];
    }

    public static sbyte ReadSByte(this IMemory memory, long? offset = null)
    {
        var b = memory.ReadBytes(offset, 1)[0];
        return unchecked((sbyte)b); //unchecked -> overflow allowed
    }

    public static short ReadInt16(this IMemory memory, long? offset = null)
    {
        return BitConverter.ToInt16(memory.ReadBytes(offset, 2), 0);
    }

    public static ushort ReadUInt16(this IMemory memory, long? offset = null)
    {
        return BitConverter.ToUInt16(memory.ReadBytes(offset, 2), 0);
    }

    public static float ReadFloat(this IMemory memory, long? offset = null)
    {
        return BitConverter.ToSingle(memory.ReadBytes(offset, 4), 0);
    }

    public static string ReadUnicodeString(this IMemory memory, out int length, int maxSize = 1000, long? offset = null)
    {
        var data = memory.ReadBytes(offset, maxSize);
        length = 0;
        for (var i = 1; i < data.Length; i++)
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

    #region Write

    public static void WriteBytes(this IMemory memory, byte[] value) => memory.WriteBytes(null, value);

    public static void WriteInt16(this IMemory memory, short value) => memory.WriteInt16(null, value);

    public static void WriteInt16(this IMemory memory, long? offset, short value)
    {
        memory.WriteBytes(offset, BitConverter.GetBytes(value));
    }

    public static void WriteUInt16(this IMemory memory, ushort value) => memory.WriteUInt16(null, value);

    public static void WriteUInt16(this IMemory memory, long? offset, ushort value)
    {
        memory.WriteBytes(offset, BitConverter.GetBytes(value));
    }

    public static void WriteInt32(this IMemory memory, int value) => memory.WriteInt32(null, value);


    public static void WriteInt32(this IMemory memory, long? offset, int value)
    {
        memory.WriteBytes(offset, BitConverter.GetBytes(value));
    }

    public static void WriteUInt32(this IMemory memory, uint value) => memory.WriteUInt32(null, value);

    public static void WriteUInt32(this IMemory memory, long? offset, uint value)
    {
        memory.WriteBytes(offset, BitConverter.GetBytes(value));
    }

    public static void WriteInt64(this IMemory memory, long? offset, long value)
    {
        memory.WriteBytes(offset, BitConverter.GetBytes(value));
    }

    public static void WriteBool(this IMemory memory, long? offset, bool value)
    {
        memory.WriteBytes(offset, BitConverter.GetBytes(value));
    }

    public static void WriteByte(this IMemory memory, long? offset, byte value)
    {
        memory.WriteBytes(offset, [value]);
    }

    public static void WriteSByte(this IMemory memory, long? offset, sbyte value)
    {
        var b = unchecked((byte)value);
        memory.WriteBytes(offset, [b]);
    }

    public static void WriteFloat(this IMemory memory, float value) => memory.WriteFloat(null, value);

    public static void WriteFloat(this IMemory memory, long? offset, float value)
    {
        memory.WriteBytes(offset, BitConverter.GetBytes(value));
    }

    #endregion

}
