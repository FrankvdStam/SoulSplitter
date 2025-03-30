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

namespace SoulMSoulMemory.Gamesemory.DarkSouls1.Parameters;

[ExcludeFromCodeCoverage]
public class ShopLineupParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int EquipId
    {
        get => _equipId;
        set => WriteParamField(ref _equipId, value);
    }
    private int _equipId;

    [ParamField(0x4, ParamType.I32)]
    public int Value
    {
        get => _value;
        set => WriteParamField(ref _value, value);
    }
    private int _value;

    [ParamField(0x8, ParamType.I32)]
    public int MtrlId
    {
        get => _mtrlId;
        set => WriteParamField(ref _mtrlId, value);
    }
    private int _mtrlId;

    [ParamField(0xC, ParamType.I32)]
    public int EventFlag
    {
        get => _eventFlag;
        set => WriteParamField(ref _eventFlag, value);
    }
    private int _eventFlag;

    [ParamField(0x10, ParamType.I32)]
    public int QwcId
    {
        get => _qwcId;
        set => WriteParamField(ref _qwcId, value);
    }
    private int _qwcId;

    [ParamField(0x14, ParamType.I16)]
    public short SellQuantity
    {
        get => _sellQuantity;
        set => WriteParamField(ref _sellQuantity, value);
    }
    private short _sellQuantity;

    [ParamField(0x16, ParamType.U8)]
    public byte ShopType
    {
        get => _shopType;
        set => WriteParamField(ref _shopType, value);
    }
    private byte _shopType;

    [ParamField(0x17, ParamType.U8)]
    public byte EquipType
    {
        get => _equipType;
        set => WriteParamField(ref _equipType, value);
    }
    private byte _equipType;

    [ParamField(0x18, ParamType.Dummy8, 8)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

}
