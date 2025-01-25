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

using SoulMemory.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Pointer = SoulMemory.Memory.Pointer;

namespace SoulMemory.Parameters;

public static class ParamReader
{
    public static List<TextTableEntry> GetTextTables(Pointer textBasePointer)
    {
        var rowCount = textBasePointer.ReadUInt16(0xc);

        var tableBytes = textBasePointer.ReadBytes(12 * rowCount, 0x18);

        var data = new List<TextTableEntry>();
        for (int i = 0; i < rowCount; i++)
        {
            var offset = i * 12;

            var textTableEntry = new TextTableEntry
            {
                ItemLowRange = BitConverter.ToUInt32(tableBytes, offset),
                DataOffset = BitConverter.ToUInt32(tableBytes, offset + 0x4),
                ItemHighRange = BitConverter.ToUInt32(tableBytes, offset + 0x8),
            };
            data.Add(textTableEntry);
        }

        return data;
    }

    public static List<T> ReadParam<T>(Pointer paramBasePointer) where T : BaseParam
    {
        var dataOffset = paramBasePointer.ReadUInt16(0x4);
        var rowCount = paramBasePointer.ReadUInt16(0xa);

        var rowSize = typeof(T)
            .GetProperties()
            .Where(i => i.IsDefined(typeof(ParamFieldAttribute)))
            .Sum(i => ParamData.ParamByteSize[i.GetCustomAttribute<ParamFieldAttribute>().ParamType]);

        var paramTableBytes = paramBasePointer.ReadBytes(12 * rowCount, 0x30);
        var parameterRawBytes = paramBasePointer.ReadBytes(rowCount * rowSize, dataOffset);

        var parameterMemory = new ByteArrayMemory(parameterRawBytes);

        var parameters = new List<T>();

        for (int i = 0; i < rowCount; i++)
        {
            var offset = i * 12;

            var paramTableEntry = new ParamTableEntry
            {
                Id = BitConverter.ToInt32(paramTableBytes, offset),
                DataOffset = BitConverter.ToUInt32(paramTableBytes, offset + 0x4),
                NameOffset = BitConverter.ToUInt32(paramTableBytes, offset + 0x8),
            };

            var rowBasePointer = paramBasePointer.Copy();
            rowBasePointer.Offsets.Clear();
            rowBasePointer.BaseAddress = paramBasePointer.BaseAddress + dataOffset + i * rowSize;
           
            parameters.Add(
                (T)Activator.CreateInstance(typeof(T),
                    rowBasePointer,
                    parameterMemory,
                    i * rowSize,
                    paramTableEntry)
                );
        }

        return parameters;
    }
}
