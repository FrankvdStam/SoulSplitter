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

using SoulMemory.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SoulMemory.Memory;

public class Pointer
{
    public Process? Process;
    public long BaseAddress;
    public List<long> Offsets = [];
    public bool Is64Bit;
    private bool _initialized;


    public void Initialize(Process process, bool is64Bit, long baseAddress, params long[] offsets)
    {
        Process = process;
        Is64Bit = is64Bit;
        BaseAddress = baseAddress;
        Offsets = offsets.ToList();
        _initialized = true;
    }

    public void Clear()
    {
        _initialized = false;
        Process = null;
        BaseAddress = 0;
        Offsets.Clear();
    }


    public Pointer Copy()
    {
        var p = new Pointer();
        p.Initialize(Process!, Is64Bit, BaseAddress, Offsets.ToArray());
        return p;
    }

    /// <summary>
    /// Creates a new pointer with the address of the old pointer as base address
    /// </summary>
    /// <returns></returns>
    public Pointer CreatePointerFromAddress(long? offset = null)
    {
        var copy = Copy();
        var offsets = Offsets.ToList();
        if (offset.HasValue)
        {
            offsets.Add(offset.Value);
        }

        offsets.Add(0);

        copy.BaseAddress = ResolveOffsets(offsets);
        copy.Offsets.Clear();
        return copy;
    }

  

    private long ResolveOffsets(List<long> offsets, StringBuilder? debugStringBuilder = null)
    {
        if (Process == null)
        {
            return 0;
        }

        debugStringBuilder?.Append($" 0x{BaseAddress:x}");

        long ptr = BaseAddress;
        for (int i = 0; i < offsets.Count; i++)
        {
            var offset = offsets[i];

            //Create a copy for debug output
            var debugCopy = ptr;

            //Resolve an offset
            var address = ptr + offset;

            //Not the last offset = resolve as pointer
            if (i + 1 < offsets.Count)
            {
                if (Is64Bit)
                {
                    ptr = Process.ReadMemory<long>(address).Unwrap();
                }
                else
                {
                    ptr = Process.ReadMemory<int>(address).Unwrap();
                }

                debugStringBuilder?.Append($"\r\n[0x{debugCopy:x} + 0x{offset:x}]: 0x{ptr:x}");

                if (ptr == 0)
                {
                    return 0;
                }
            }
            else
            {
                ptr = address;
                debugStringBuilder?.Append($"\r\n 0x{debugCopy:x} + 0x{offset:x}: 0x{ptr:x}");
            }
        }

        return ptr;
    }


    //Debug representation, shows in IDE
    public string Path { get; private set; } = null!;

    public override string ToString()
    {
        var sb = new StringBuilder();
        ResolveOffsets(Offsets, sb);
        Path = sb.ToString();
        return Path;
    }

    #region Append offsets

    public Pointer Append(params long[] offsets)
    {
        var copy = Copy();
        copy.Offsets.AddRange(offsets);
        return copy;
    }

    #endregion

    #region Read/write memory

    private byte[] ReadMemory(long? offset, int length)
    {
        if (!_initialized)
        {
            return new byte[length];
        }

        var offsetsCopy = Offsets.ToList();
        if (offset.HasValue)
        {
            offsetsCopy.Add(offset.Value);
        }

        var address = ResolveOffsets(offsetsCopy);
        var result = Process!.ReadProcessMemory(address, length);
        if(result.IsErr)
        {
            return new byte[length];
        }
        return result.Unwrap();
    }

    private void WriteMemory(long? offset, byte[] bytes)
    {
        var offsetsCopy = Offsets.ToList();
        if (offset.HasValue)
        {
            offsetsCopy.Add(offset.Value);
        }
        var address = ResolveOffsets(offsetsCopy);
        Process!.WriteProcessMemory(address, bytes).Unwrap();
    }

    public bool IsNullPtr()
    {
        return GetAddress() == 0;
    }

    public long GetAddress()
    {
        return ResolveOffsets(Offsets);
    }

    #region Read
    public int ReadInt32(long? offset = null)
    {
        return BitConverter.ToInt32(ReadMemory(offset, 4), 0);
    }
    public uint ReadUInt32(long? offset = null)
    {
        return BitConverter.ToUInt32(ReadMemory(offset, 4), 0);
    }

    public long ReadInt64(long? offset = null)
    {
        return BitConverter.ToInt64(ReadMemory(offset, 8), 0);
    }

    public bool ReadBool(long? offset = null)
    {
        return BitConverter.ToBoolean(ReadMemory(offset, 1), 0);
    }
    public byte ReadByte(long? offset = null)
    {
        return ReadMemory(offset, 1)[0];
    }

    public short ReadInt16(long? offset = null)
    {
        return BitConverter.ToInt16(ReadMemory(offset, 2), 0);
    }

    public ushort ReadUInt16(long? offset = null)
    {
        return BitConverter.ToUInt16(ReadMemory(offset, 2), 0);
    }

    public byte[] ReadBytes(int size, long? offset = null)
    {
        return ReadMemory(offset, size);
    }

    public float ReadFloat(long? offset = null)
    {
        return BitConverter.ToSingle(ReadMemory(offset, 4), 0);
    }

    public string ReadUnicodeString(out int length, int maxSize = 1000, long? offset = null)
    {
        var data = ReadMemory(offset, maxSize);
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

    #region Write

    public void WriteInt16(short value) => WriteInt16(null, value);

    public void WriteInt16(long? offset, short value)
    {
        WriteMemory(offset, BitConverter.GetBytes(value));
    }

    public void WriteUInt16(ushort value) => WriteUInt16(null, value);

    public void WriteUInt16(long? offset, ushort value)
    {
        WriteMemory(offset, BitConverter.GetBytes(value));
    }

    public void WriteInt32(int value) => WriteInt32(null, value);


    public void WriteInt32(long? offset, int value)
    {
        WriteMemory(offset, BitConverter.GetBytes(value));
    }

    public void WriteUint32(uint value) => WriteUint32(null, value);

    public void WriteUint32(long? offset, uint value)
    {
        WriteMemory(offset, BitConverter.GetBytes(value));
    }

    public void WriteInt64(long? offset, long value)
    {
        WriteMemory(offset, BitConverter.GetBytes(value));
    }

    public void WriteBool(long? offset, bool value)
    {
        WriteMemory(offset, BitConverter.GetBytes(value));
    }

    public void WriteByte(long? offset, byte value)
    {
        WriteMemory(offset, [value]);
    }

    public void WriteSByte(long? offset, sbyte value)
    {
        var b = unchecked((byte)value);
        WriteMemory(offset, [b]);
    }

    public void WriteBytes(long? offset, byte[] value)
    {
        WriteMemory(offset, value);
    }

    public void WriteFloat(float value) => WriteFloat(null, value);

    public void WriteFloat(long? offset, float value)
    {
        WriteMemory(offset, BitConverter.GetBytes(value));
    }
    
    #endregion

    #endregion
}
