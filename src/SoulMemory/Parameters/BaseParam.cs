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
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Text;
using Pointer = SoulMemory.Memory.Pointer;
using SoulMemory.Memory;

namespace SoulMemory.Parameters;

public abstract class BaseParam
{
    private readonly List<(PropertyInfo propertyInfo, ParamFieldAttribute paramFieldAttribute)> _paramFieldPropertyCache;
    private readonly List<(PropertyInfo propertyInfo, ParamBitFieldAttribute paramFieldAttribute)> _paramBitfieldPropertyCache;

    protected BaseParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry)
    {
        BasePointer = basePointer;
        Id = paramTableEntry.Id;

        _paramFieldPropertyCache = GetType()
            .GetProperties()
            .Where(i => i.IsDefined(typeof(ParamFieldAttribute)))
            .Select(i => (i, i.GetCustomAttribute<ParamFieldAttribute>()))
            .OrderBy(i => i.Item2.Offset)
            .ToList();

        _paramBitfieldPropertyCache = GetType()
            .GetProperties()
            .Where(i => i.IsDefined(typeof(ParamBitFieldAttribute)))
            .Select(i => (i, i.GetCustomAttribute<ParamBitFieldAttribute>()))
            .ToList();

        foreach (var field in _paramFieldPropertyCache)
        {
            var fieldOffset = offset + field.paramFieldAttribute.Offset;
            var paramType = field.paramFieldAttribute.ParamType;

            switch (paramType)
            {
                case ParamType.Dummy8:
                case ParamType.U8:
                    field.propertyInfo.SetValue(this, memory.ReadByte(fieldOffset));
                    break;

                case ParamType.I8:
                    field.propertyInfo.SetValue(this, memory.ReadSByte(fieldOffset));
                    break;

                case ParamType.U16:
                    field.propertyInfo.SetValue(this, memory.ReadUInt16(fieldOffset));
                    break;

                case ParamType.I16:
                    field.propertyInfo.SetValue(this, memory.ReadInt16(fieldOffset));
                    break;

                case ParamType.U32:
                    field.propertyInfo.SetValue(this, memory.ReadUInt32(fieldOffset));
                    break;

                case ParamType.I32:
                    field.propertyInfo.SetValue(this, memory.ReadInt32(fieldOffset));
                    break;

                case ParamType.F32:
                    field.propertyInfo.SetValue(this, memory.ReadFloat(fieldOffset));
                    break;

                default:
                    throw new InvalidOperationException($"Unsupported param type {paramType}");
            }
        }

        WriteEnabled = true;
    }

    public int Id { get; set; }

    public readonly Pointer BasePointer;

    #region Writing fields ======================================================================================================================================================

    public bool WriteEnabled { get; set; }

    protected void WriteParamField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return;
        }

        field = value;

        if (WriteEnabled)
        {
            var property = GetType().GetProperties().First(i => i.Name == propertyName);
            var offset = property.GetCustomAttribute<ParamFieldAttribute>().Offset;
            var paramType = property.GetCustomAttribute<ParamFieldAttribute>().ParamType;

            switch (paramType)
            {
                case ParamType.Dummy8:
                case ParamType.U8:
                    BasePointer.WriteByte(offset, (byte)Convert.ChangeType(value, typeof(byte)));
                    break;

                case ParamType.I8:
                    BasePointer.WriteSByte(offset, (sbyte)Convert.ChangeType(value, typeof(sbyte)));
                    break;

                case ParamType.U16:
                    BasePointer.WriteUInt16(offset, (ushort)Convert.ChangeType(value, typeof(ushort)));
                    break;

                case ParamType.I16:
                    BasePointer.WriteInt16(offset, (short)Convert.ChangeType(value, typeof(short)));
                    break;

                case ParamType.U32:
                    BasePointer.WriteUint32(offset, (uint)Convert.ChangeType(value, typeof(uint)));
                    break;

                case ParamType.I32:
                    BasePointer.WriteInt32(offset, (int)Convert.ChangeType(value, typeof(int)));
                    break;

                case ParamType.F32:
                    BasePointer.WriteFloat(offset, (float)Convert.ChangeType(value, typeof(float)));
                    break;
            }
        }
    }

    #endregion

    #region Bitfields ======================================================================================================================================================

    protected T GetbitfieldValue<T>(T field, [CallerMemberName] string? propertyName = null)
    {
        var bitfield = _paramBitfieldPropertyCache.First(i => i.propertyInfo.Name == propertyName);
        var currentValue = (long)Convert.ChangeType(field, typeof(long));
        
        var bitIndex = 0;
        long result = 0;
        for (int i = bitfield.paramFieldAttribute.BitsOffset; i < bitfield.paramFieldAttribute.BitsOffset + bitfield.paramFieldAttribute.Bits; i++)
        {
            if (currentValue.IsBitSet(i))
            {
                result = result.SetBit(bitIndex);
            }

            bitIndex++;
        }

        return (T)Convert.ChangeType(result, typeof(T));
    }

    protected void SetBitfieldValue<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        var bitfield = _paramBitfieldPropertyCache.First(i => i.propertyInfo.Name == propertyName);
        var currentValue = (long)Convert.ChangeType(field, typeof(long));
        var newValue = (long)Convert.ChangeType(value, typeof(long));

        var bitIndex = 0;
        for (int i = bitfield.paramFieldAttribute.BitsOffset; i < bitfield.paramFieldAttribute.BitsOffset + bitfield.paramFieldAttribute.Bits; i++)
        {
            if (newValue.IsBitSet(bitIndex))
            {
                currentValue = currentValue.SetBit(i);
            }
            else
            {
                currentValue = currentValue.ClearBit(i);
            }

            bitIndex++;
        }

        var calculatedValue = (T)Convert.ChangeType(currentValue, typeof(T));
        WriteParamField(ref field, calculatedValue, bitfield.paramFieldAttribute.ParamFieldName);
    }


    #endregion
    
    public override string ToString()
    {
        var fields = GetType()
            .GetProperties()
            .Where(i => i.IsDefined(typeof(ParamFieldAttribute)))
            .OrderBy(i => i.GetCustomAttribute<ParamFieldAttribute>().Offset)
            .ToList();

        var sb = new StringBuilder();
        foreach (var f in fields)
        {
            sb.Append(f.Name.PadRight(15));
            sb.Append(": ");
            sb.AppendLine(f.GetValue(f).ToString());
        }

        return sb.ToString();
    }
}
