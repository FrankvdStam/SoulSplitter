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
using SoulMemory.Parameters;
using System.Diagnostics.CodeAnalysis;

namespace SoulMemory.DarkSouls1.Parameters;

[ExcludeFromCodeCoverage]
public class MenuParamColorTable(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.U8)]
    public byte R
    {
        get => _r;
        set => WriteParamField(ref _r, value);
    }
    private byte _r;

    [ParamField(0x1, ParamType.U8)]
    public byte G
    {
        get => _g;
        set => WriteParamField(ref _g, value);
    }
    private byte _g;

    [ParamField(0x2, ParamType.U8)]
    public byte B
    {
        get => _b;
        set => WriteParamField(ref _b, value);
    }
    private byte _b;

    [ParamField(0x3, ParamType.U8)]
    public byte A
    {
        get => _a;
        set => WriteParamField(ref _a, value);
    }
    private byte _a;

}
