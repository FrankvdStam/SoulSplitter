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

namespace SoulMemory.DarkSouls1.Parameters
{
    public abstract class BaseParam
    {
        protected BaseParam(Pointer basePointer, ArraySegment<byte> arraySegment, ParamTableEntry paramTableEntry)
        {
            BasePointer = basePointer;
            Id = paramTableEntry.Id;

            if (arraySegment.Array == null)
            {
                throw new ArgumentException("ArraySegment internal array can't be null.", nameof(arraySegment));
            }

            var fields = GetType()
                .GetProperties()
                .Where(i => i.IsDefined(typeof(ParamFieldAttribute)))
                .OrderBy(i => i.GetCustomAttribute<ParamFieldAttribute>().Offset)
                .ToList();

            foreach (var field in fields)
            {
                var offset = arraySegment.Offset + field.GetCustomAttribute<ParamFieldAttribute>().Offset;
                var paramType = field.GetCustomAttribute<ParamFieldAttribute>().ParamType;

                switch (paramType)
                {
                    case ParamType.U8:
                        field.SetValue(this, arraySegment.Array[offset]);
                        break;

                    case ParamType.U16:
                        var u16 = BitConverter.ToUInt16(arraySegment.Array, offset);
                        field.SetValue(this, u16);
                        break;

                    case ParamType.I32:
                        var i32 = BitConverter.ToInt32(arraySegment.Array, offset);
                        field.SetValue(this, i32);
                        break;

                    default:
                        throw new InvalidOperationException($"Unsupported param type {paramType}");
                }
            }

            WriteEnabled = true;
        }
        public int Id { get; set; }

        protected readonly Pointer BasePointer;
        public bool WriteEnabled { get; set; } = false;

        protected void WriteParamField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
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
                    case ParamType.U8:
                        BasePointer.WriteByte(offset, (byte)Convert.ChangeType(value, typeof(byte)));
                        break;

                    case ParamType.U16:
                        BasePointer.WriteUInt16(offset, (ushort)Convert.ChangeType(value, typeof(ushort)));
                        break;

                    case ParamType.I32:
                        BasePointer.WriteInt32(offset, (int)Convert.ChangeType(value, typeof(int)));
                        break;
                }
            }
        }

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
}
