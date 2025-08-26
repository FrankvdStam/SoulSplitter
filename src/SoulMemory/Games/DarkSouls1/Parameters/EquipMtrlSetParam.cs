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

namespace SoulMemory.Games.DarkSouls1.Parameters;

[ExcludeFromCodeCoverage]
public class EquipMtrlSetParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int MaterialId01
    {
        get => _materialId01;
        set => WriteParamField(ref _materialId01, value);
    }
    private int _materialId01;

    [ParamField(0x4, ParamType.I32)]
    public int MaterialId02
    {
        get => _materialId02;
        set => WriteParamField(ref _materialId02, value);
    }
    private int _materialId02;

    [ParamField(0x8, ParamType.I32)]
    public int MaterialId03
    {
        get => _materialId03;
        set => WriteParamField(ref _materialId03, value);
    }
    private int _materialId03;

    [ParamField(0xC, ParamType.I32)]
    public int MaterialId04
    {
        get => _materialId04;
        set => WriteParamField(ref _materialId04, value);
    }
    private int _materialId04;

    [ParamField(0x10, ParamType.I32)]
    public int MaterialId05
    {
        get => _materialId05;
        set => WriteParamField(ref _materialId05, value);
    }
    private int _materialId05;

    [ParamField(0x14, ParamType.I8)]
    public sbyte ItemNum01
    {
        get => _itemNum01;
        set => WriteParamField(ref _itemNum01, value);
    }
    private sbyte _itemNum01;

    [ParamField(0x15, ParamType.I8)]
    public sbyte ItemNum02
    {
        get => _itemNum02;
        set => WriteParamField(ref _itemNum02, value);
    }
    private sbyte _itemNum02;

    [ParamField(0x16, ParamType.I8)]
    public sbyte ItemNum03
    {
        get => _itemNum03;
        set => WriteParamField(ref _itemNum03, value);
    }
    private sbyte _itemNum03;

    [ParamField(0x17, ParamType.I8)]
    public sbyte ItemNum04
    {
        get => _itemNum04;
        set => WriteParamField(ref _itemNum04, value);
    }
    private sbyte _itemNum04;

    [ParamField(0x18, ParamType.I8)]
    public sbyte ItemNum05
    {
        get => _itemNum05;
        set => WriteParamField(ref _itemNum05, value);
    }
    private sbyte _itemNum05;

    #region BitField IsDisableDispNum01Bitfield ==============================================================================

    [ParamField(0x19, ParamType.U8)]
    public byte IsDisableDispNum01Bitfield
    {
        get => _isDisableDispNum01Bitfield;
        set => WriteParamField(ref _isDisableDispNum01Bitfield, value);
    }
    private byte _isDisableDispNum01Bitfield;

    [ParamBitField(nameof(IsDisableDispNum01Bitfield), bits: 1, bitsOffset: 0)]
    public byte IsDisableDispNum01
    {
        get => GetbitfieldValue(_isDisableDispNum01Bitfield);
        set => SetBitfieldValue(ref _isDisableDispNum01Bitfield, value);
    }

    [ParamBitField(nameof(IsDisableDispNum01Bitfield), bits: 1, bitsOffset: 1)]
    public byte IsDisableDispNum02
    {
        get => GetbitfieldValue(_isDisableDispNum01Bitfield);
        set => SetBitfieldValue(ref _isDisableDispNum01Bitfield, value);
    }

    [ParamBitField(nameof(IsDisableDispNum01Bitfield), bits: 1, bitsOffset: 2)]
    public byte IsDisableDispNum03
    {
        get => GetbitfieldValue(_isDisableDispNum01Bitfield);
        set => SetBitfieldValue(ref _isDisableDispNum01Bitfield, value);
    }

    [ParamBitField(nameof(IsDisableDispNum01Bitfield), bits: 1, bitsOffset: 3)]
    public byte IsDisableDispNum04
    {
        get => GetbitfieldValue(_isDisableDispNum01Bitfield);
        set => SetBitfieldValue(ref _isDisableDispNum01Bitfield, value);
    }

    [ParamBitField(nameof(IsDisableDispNum01Bitfield), bits: 1, bitsOffset: 4)]
    public byte IsDisableDispNum05
    {
        get => GetbitfieldValue(_isDisableDispNum01Bitfield);
        set => SetBitfieldValue(ref _isDisableDispNum01Bitfield, value);
    }

    #endregion BitField IsDisableDispNum01Bitfield

    [ParamField(0x1A, ParamType.Dummy8, 6)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
