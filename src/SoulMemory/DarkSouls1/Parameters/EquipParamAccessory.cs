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
public class EquipParamAccessory(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int RefId
    {
        get => _refId;
        set => WriteParamField(ref _refId, value);
    }
    private int _refId;

    [ParamField(0x4, ParamType.I32)]
    public int SfxVariationId
    {
        get => _sfxVariationId;
        set => WriteParamField(ref _sfxVariationId, value);
    }
    private int _sfxVariationId;

    [ParamField(0x8, ParamType.F32)]
    public float Weight
    {
        get => _weight;
        set => WriteParamField(ref _weight, value);
    }
    private float _weight;

    [ParamField(0xC, ParamType.I32)]
    public int BehaviorId
    {
        get => _behaviorId;
        set => WriteParamField(ref _behaviorId, value);
    }
    private int _behaviorId;

    [ParamField(0x10, ParamType.I32)]
    public int BasicPrice
    {
        get => _basicPrice;
        set => WriteParamField(ref _basicPrice, value);
    }
    private int _basicPrice;

    [ParamField(0x14, ParamType.I32)]
    public int SellValue
    {
        get => _sellValue;
        set => WriteParamField(ref _sellValue, value);
    }
    private int _sellValue;

    [ParamField(0x18, ParamType.I32)]
    public int SortId
    {
        get => _sortId;
        set => WriteParamField(ref _sortId, value);
    }
    private int _sortId;

    [ParamField(0x1C, ParamType.I32)]
    public int QwcId
    {
        get => _qwcId;
        set => WriteParamField(ref _qwcId, value);
    }
    private int _qwcId;

    [ParamField(0x20, ParamType.U16)]
    public ushort EquipModelId
    {
        get => _equipModelId;
        set => WriteParamField(ref _equipModelId, value);
    }
    private ushort _equipModelId;

    [ParamField(0x22, ParamType.U16)]
    public ushort IconId
    {
        get => _iconId;
        set => WriteParamField(ref _iconId, value);
    }
    private ushort _iconId;

    [ParamField(0x24, ParamType.I16)]
    public short ShopLv
    {
        get => _shopLv;
        set => WriteParamField(ref _shopLv, value);
    }
    private short _shopLv;

    [ParamField(0x26, ParamType.I16)]
    public short TrophySGradeId
    {
        get => _trophySGradeId;
        set => WriteParamField(ref _trophySGradeId, value);
    }
    private short _trophySGradeId;

    [ParamField(0x28, ParamType.I16)]
    public short TrophySeqId
    {
        get => _trophySeqId;
        set => WriteParamField(ref _trophySeqId, value);
    }
    private short _trophySeqId;

    [ParamField(0x2A, ParamType.U8)]
    public byte EquipModelCategory
    {
        get => _equipModelCategory;
        set => WriteParamField(ref _equipModelCategory, value);
    }
    private byte _equipModelCategory;

    [ParamField(0x2B, ParamType.U8)]
    public byte EquipModelGender
    {
        get => _equipModelGender;
        set => WriteParamField(ref _equipModelGender, value);
    }
    private byte _equipModelGender;

    [ParamField(0x2C, ParamType.U8)]
    public byte AccessoryCategory
    {
        get => _accessoryCategory;
        set => WriteParamField(ref _accessoryCategory, value);
    }
    private byte _accessoryCategory;

    [ParamField(0x2D, ParamType.U8)]
    public byte RefCategory
    {
        get => _refCategory;
        set => WriteParamField(ref _refCategory, value);
    }
    private byte _refCategory;

    [ParamField(0x2E, ParamType.U8)]
    public byte SpEffectCategory
    {
        get => _spEffectCategory;
        set => WriteParamField(ref _spEffectCategory, value);
    }
    private byte _spEffectCategory;

    [ParamField(0x2F, ParamType.Dummy8, 1)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

    [ParamField(0x30, ParamType.I32)]
    public int VagrantItemLotId
    {
        get => _vagrantItemLotId;
        set => WriteParamField(ref _vagrantItemLotId, value);
    }
    private int _vagrantItemLotId;

    [ParamField(0x34, ParamType.I32)]
    public int VagrantBonusEneDropItemLotId
    {
        get => _vagrantBonusEneDropItemLotId;
        set => WriteParamField(ref _vagrantBonusEneDropItemLotId, value);
    }
    private int _vagrantBonusEneDropItemLotId;

    [ParamField(0x38, ParamType.I32)]
    public int VagrantItemEneDropItemLotId
    {
        get => _vagrantItemEneDropItemLotId;
        set => WriteParamField(ref _vagrantItemEneDropItemLotId, value);
    }
    private int _vagrantItemEneDropItemLotId;

    #region BitField IsDepositBitfield ==============================================================================

    [ParamField(0x3C, ParamType.U8)]
    public byte IsDepositBitfield
    {
        get => _isDepositBitfield;
        set => WriteParamField(ref _isDepositBitfield, value);
    }
    private byte _isDepositBitfield;

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 0)]
    public byte IsDeposit
    {
        get => GetbitfieldValue(_isDepositBitfield);
        set => SetBitfieldValue(ref _isDepositBitfield, value);
    }

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 1)]
    public byte IsEquipOutBrake
    {
        get => GetbitfieldValue(_isDepositBitfield);
        set => SetBitfieldValue(ref _isDepositBitfield, value);
    }

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 2)]
    public byte DisableMultiDropShare
    {
        get => GetbitfieldValue(_isDepositBitfield);
        set => SetBitfieldValue(ref _isDepositBitfield, value);
    }

    #endregion BitField IsDepositBitfield

    [ParamField(0x3D, ParamType.Dummy8, 3)]
    public byte[] Pad1
    {
        get => _pad1;
        set => WriteParamField(ref _pad1, value);
    }
    private byte[] _pad1 = null!;

}
