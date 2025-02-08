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
public class GameAreaParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.U32)]
    public uint BonusSoulSingle
    {
        get => _bonusSoulSingle;
        set => WriteParamField(ref _bonusSoulSingle, value);
    }
    private uint _bonusSoulSingle;

    [ParamField(0x4, ParamType.U32)]
    public uint BonusSoulMulti
    {
        get => _bonusSoulMulti;
        set => WriteParamField(ref _bonusSoulMulti, value);
    }
    private uint _bonusSoulMulti;

    [ParamField(0x8, ParamType.I32)]
    public int HumanityPointCountFlagIdTop
    {
        get => _humanityPointCountFlagIdTop;
        set => WriteParamField(ref _humanityPointCountFlagIdTop, value);
    }
    private int _humanityPointCountFlagIdTop;

    [ParamField(0xC, ParamType.U16)]
    public ushort HumanityDropPoint1
    {
        get => _humanityDropPoint1;
        set => WriteParamField(ref _humanityDropPoint1, value);
    }
    private ushort _humanityDropPoint1;

    [ParamField(0xE, ParamType.U16)]
    public ushort HumanityDropPoint2
    {
        get => _humanityDropPoint2;
        set => WriteParamField(ref _humanityDropPoint2, value);
    }
    private ushort _humanityDropPoint2;

    [ParamField(0x10, ParamType.U16)]
    public ushort HumanityDropPoint3
    {
        get => _humanityDropPoint3;
        set => WriteParamField(ref _humanityDropPoint3, value);
    }
    private ushort _humanityDropPoint3;

    [ParamField(0x12, ParamType.U16)]
    public ushort HumanityDropPoint4
    {
        get => _humanityDropPoint4;
        set => WriteParamField(ref _humanityDropPoint4, value);
    }
    private ushort _humanityDropPoint4;

    [ParamField(0x14, ParamType.U16)]
    public ushort HumanityDropPoint5
    {
        get => _humanityDropPoint5;
        set => WriteParamField(ref _humanityDropPoint5, value);
    }
    private ushort _humanityDropPoint5;

    [ParamField(0x16, ParamType.U16)]
    public ushort HumanityDropPoint6
    {
        get => _humanityDropPoint6;
        set => WriteParamField(ref _humanityDropPoint6, value);
    }
    private ushort _humanityDropPoint6;

    [ParamField(0x18, ParamType.U16)]
    public ushort HumanityDropPoint7
    {
        get => _humanityDropPoint7;
        set => WriteParamField(ref _humanityDropPoint7, value);
    }
    private ushort _humanityDropPoint7;

    [ParamField(0x1A, ParamType.U16)]
    public ushort HumanityDropPoint8
    {
        get => _humanityDropPoint8;
        set => WriteParamField(ref _humanityDropPoint8, value);
    }
    private ushort _humanityDropPoint8;

    [ParamField(0x1C, ParamType.U16)]
    public ushort HumanityDropPoint9
    {
        get => _humanityDropPoint9;
        set => WriteParamField(ref _humanityDropPoint9, value);
    }
    private ushort _humanityDropPoint9;

    [ParamField(0x1E, ParamType.U16)]
    public ushort HumanityDropPoint10
    {
        get => _humanityDropPoint10;
        set => WriteParamField(ref _humanityDropPoint10, value);
    }
    private ushort _humanityDropPoint10;

}
