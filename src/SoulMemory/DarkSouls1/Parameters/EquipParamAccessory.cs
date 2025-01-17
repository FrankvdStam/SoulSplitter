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
public class EquipParamAccessory : BaseParam
{
    public EquipParamAccessory(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

    [ParamField(0x0, ParamType.I32)]
    public int RefId
    {
        get => _RefId;
        set => WriteParamField(ref _RefId, value);
    }
    private int _RefId;

    [ParamField(0x4, ParamType.I32)]
    public int SfxVariationId
    {
        get => _SfxVariationId;
        set => WriteParamField(ref _SfxVariationId, value);
    }
    private int _SfxVariationId;

    [ParamField(0x8, ParamType.F32)]
    public float Weight
    {
        get => _Weight;
        set => WriteParamField(ref _Weight, value);
    }
    private float _Weight;

    [ParamField(0xC, ParamType.I32)]
    public int BehaviorId
    {
        get => _BehaviorId;
        set => WriteParamField(ref _BehaviorId, value);
    }
    private int _BehaviorId;

    [ParamField(0x10, ParamType.I32)]
    public int BasicPrice
    {
        get => _BasicPrice;
        set => WriteParamField(ref _BasicPrice, value);
    }
    private int _BasicPrice;

    [ParamField(0x14, ParamType.I32)]
    public int SellValue
    {
        get => _SellValue;
        set => WriteParamField(ref _SellValue, value);
    }
    private int _SellValue;

    [ParamField(0x18, ParamType.I32)]
    public int SortId
    {
        get => _SortId;
        set => WriteParamField(ref _SortId, value);
    }
    private int _SortId;

    [ParamField(0x1C, ParamType.I32)]
    public int QwcId
    {
        get => _QwcId;
        set => WriteParamField(ref _QwcId, value);
    }
    private int _QwcId;

    [ParamField(0x20, ParamType.U16)]
    public ushort EquipModelId
    {
        get => _EquipModelId;
        set => WriteParamField(ref _EquipModelId, value);
    }
    private ushort _EquipModelId;

    [ParamField(0x22, ParamType.U16)]
    public ushort IconId
    {
        get => _IconId;
        set => WriteParamField(ref _IconId, value);
    }
    private ushort _IconId;

    [ParamField(0x24, ParamType.I16)]
    public short ShopLv
    {
        get => _ShopLv;
        set => WriteParamField(ref _ShopLv, value);
    }
    private short _ShopLv;

    [ParamField(0x26, ParamType.I16)]
    public short TrophySGradeId
    {
        get => _TrophySGradeId;
        set => WriteParamField(ref _TrophySGradeId, value);
    }
    private short _TrophySGradeId;

    [ParamField(0x28, ParamType.I16)]
    public short TrophySeqId
    {
        get => _TrophySeqId;
        set => WriteParamField(ref _TrophySeqId, value);
    }
    private short _TrophySeqId;

    [ParamField(0x2A, ParamType.U8)]
    public byte EquipModelCategory
    {
        get => _EquipModelCategory;
        set => WriteParamField(ref _EquipModelCategory, value);
    }
    private byte _EquipModelCategory;

    [ParamField(0x2B, ParamType.U8)]
    public byte EquipModelGender
    {
        get => _EquipModelGender;
        set => WriteParamField(ref _EquipModelGender, value);
    }
    private byte _EquipModelGender;

    [ParamField(0x2C, ParamType.U8)]
    public byte AccessoryCategory
    {
        get => _AccessoryCategory;
        set => WriteParamField(ref _AccessoryCategory, value);
    }
    private byte _AccessoryCategory;

    [ParamField(0x2D, ParamType.U8)]
    public byte RefCategory
    {
        get => _RefCategory;
        set => WriteParamField(ref _RefCategory, value);
    }
    private byte _RefCategory;

    [ParamField(0x2E, ParamType.U8)]
    public byte SpEffectCategory
    {
        get => _SpEffectCategory;
        set => WriteParamField(ref _SpEffectCategory, value);
    }
    private byte _SpEffectCategory;

    [ParamField(0x2F, ParamType.Dummy8, 1)]
    public byte[] Pad
    {
        get => _Pad;
        set => WriteParamField(ref _Pad, value);
    }
    private byte[] _Pad = null!;

    [ParamField(0x30, ParamType.I32)]
    public int VagrantItemLotId
    {
        get => _VagrantItemLotId;
        set => WriteParamField(ref _VagrantItemLotId, value);
    }
    private int _VagrantItemLotId;

    [ParamField(0x34, ParamType.I32)]
    public int VagrantBonusEneDropItemLotId
    {
        get => _VagrantBonusEneDropItemLotId;
        set => WriteParamField(ref _VagrantBonusEneDropItemLotId, value);
    }
    private int _VagrantBonusEneDropItemLotId;

    [ParamField(0x38, ParamType.I32)]
    public int VagrantItemEneDropItemLotId
    {
        get => _VagrantItemEneDropItemLotId;
        set => WriteParamField(ref _VagrantItemEneDropItemLotId, value);
    }
    private int _VagrantItemEneDropItemLotId;

    #region BitField IsDepositBitfield ==============================================================================

    [ParamField(0x3C, ParamType.U8)]
    public byte IsDepositBitfield
    {
        get => _IsDepositBitfield;
        set => WriteParamField(ref _IsDepositBitfield, value);
    }
    private byte _IsDepositBitfield;

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 0)]
    public byte IsDeposit
    {
        get => GetbitfieldValue(_IsDepositBitfield);
        set => SetBitfieldValue(ref _IsDepositBitfield, value);
    }

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 1)]
    public byte IsEquipOutBrake
    {
        get => GetbitfieldValue(_IsDepositBitfield);
        set => SetBitfieldValue(ref _IsDepositBitfield, value);
    }

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 2)]
    public byte DisableMultiDropShare
    {
        get => GetbitfieldValue(_IsDepositBitfield);
        set => SetBitfieldValue(ref _IsDepositBitfield, value);
    }

    #endregion BitField IsDepositBitfield

    [ParamField(0x3D, ParamType.Dummy8, 3)]
    public byte[] Pad1
    {
        get => _Pad1;
        set => WriteParamField(ref _Pad1, value);
    }
    private byte[] _Pad1 = null!;

}
