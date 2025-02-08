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
public class MagicParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int YesNoDialogMessageId
    {
        get => _yesNoDialogMessageId;
        set => WriteParamField(ref _yesNoDialogMessageId, value);
    }
    private int _yesNoDialogMessageId;

    [ParamField(0x4, ParamType.I32)]
    public int LimitCancelSpEffectId
    {
        get => _limitCancelSpEffectId;
        set => WriteParamField(ref _limitCancelSpEffectId, value);
    }
    private int _limitCancelSpEffectId;

    [ParamField(0x8, ParamType.I16)]
    public short SortId
    {
        get => _sortId;
        set => WriteParamField(ref _sortId, value);
    }
    private short _sortId;

    [ParamField(0xA, ParamType.I16)]
    public short RefId
    {
        get => _refId;
        set => WriteParamField(ref _refId, value);
    }
    private short _refId;

    [ParamField(0xC, ParamType.I16)]
    public short Mp
    {
        get => _mp;
        set => WriteParamField(ref _mp, value);
    }
    private short _mp;

    [ParamField(0xE, ParamType.I16)]
    public short Stamina
    {
        get => _stamina;
        set => WriteParamField(ref _stamina, value);
    }
    private short _stamina;

    [ParamField(0x10, ParamType.I16)]
    public short IconId
    {
        get => _iconId;
        set => WriteParamField(ref _iconId, value);
    }
    private short _iconId;

    [ParamField(0x12, ParamType.I16)]
    public short BehaviorId
    {
        get => _behaviorId;
        set => WriteParamField(ref _behaviorId, value);
    }
    private short _behaviorId;

    [ParamField(0x14, ParamType.I16)]
    public short MtrlItemId
    {
        get => _mtrlItemId;
        set => WriteParamField(ref _mtrlItemId, value);
    }
    private short _mtrlItemId;

    [ParamField(0x16, ParamType.I16)]
    public short ReplaceMagicId
    {
        get => _replaceMagicId;
        set => WriteParamField(ref _replaceMagicId, value);
    }
    private short _replaceMagicId;

    [ParamField(0x18, ParamType.I16)]
    public short MaxQuantity
    {
        get => _maxQuantity;
        set => WriteParamField(ref _maxQuantity, value);
    }
    private short _maxQuantity;

    [ParamField(0x1A, ParamType.U8)]
    public byte HeroPoint
    {
        get => _heroPoint;
        set => WriteParamField(ref _heroPoint, value);
    }
    private byte _heroPoint;

    [ParamField(0x1B, ParamType.U8)]
    public byte OverDexterity
    {
        get => _overDexterity;
        set => WriteParamField(ref _overDexterity, value);
    }
    private byte _overDexterity;

    [ParamField(0x1C, ParamType.I8)]
    public sbyte SfxVariationId
    {
        get => _sfxVariationId;
        set => WriteParamField(ref _sfxVariationId, value);
    }
    private sbyte _sfxVariationId;

    [ParamField(0x1D, ParamType.U8)]
    public byte SlotLength
    {
        get => _slotLength;
        set => WriteParamField(ref _slotLength, value);
    }
    private byte _slotLength;

    [ParamField(0x1E, ParamType.U8)]
    public byte RequirementIntellect
    {
        get => _requirementIntellect;
        set => WriteParamField(ref _requirementIntellect, value);
    }
    private byte _requirementIntellect;

    [ParamField(0x1F, ParamType.U8)]
    public byte RequirementFaith
    {
        get => _requirementFaith;
        set => WriteParamField(ref _requirementFaith, value);
    }
    private byte _requirementFaith;

    [ParamField(0x20, ParamType.U8)]
    public byte AnalogDexiterityMin
    {
        get => _analogDexiterityMin;
        set => WriteParamField(ref _analogDexiterityMin, value);
    }
    private byte _analogDexiterityMin;

    [ParamField(0x21, ParamType.U8)]
    public byte AnalogDexiterityMax
    {
        get => _analogDexiterityMax;
        set => WriteParamField(ref _analogDexiterityMax, value);
    }
    private byte _analogDexiterityMax;

    [ParamField(0x22, ParamType.U8)]
    public byte EzStateBehaviorType
    {
        get => _ezStateBehaviorType;
        set => WriteParamField(ref _ezStateBehaviorType, value);
    }
    private byte _ezStateBehaviorType;

    [ParamField(0x23, ParamType.U8)]
    public byte RefCategory
    {
        get => _refCategory;
        set => WriteParamField(ref _refCategory, value);
    }
    private byte _refCategory;

    [ParamField(0x24, ParamType.U8)]
    public byte SpEffectCategory
    {
        get => _spEffectCategory;
        set => WriteParamField(ref _spEffectCategory, value);
    }
    private byte _spEffectCategory;

    [ParamField(0x25, ParamType.U8)]
    public byte RefType
    {
        get => _refType;
        set => WriteParamField(ref _refType, value);
    }
    private byte _refType;

    [ParamField(0x26, ParamType.U8)]
    public byte OpmeMenuType
    {
        get => _opmeMenuType;
        set => WriteParamField(ref _opmeMenuType, value);
    }
    private byte _opmeMenuType;

    [ParamField(0x27, ParamType.U8)]
    public byte HasSpEffectType
    {
        get => _hasSpEffectType;
        set => WriteParamField(ref _hasSpEffectType, value);
    }
    private byte _hasSpEffectType;

    [ParamField(0x28, ParamType.U8)]
    public byte ReplaceCategory
    {
        get => _replaceCategory;
        set => WriteParamField(ref _replaceCategory, value);
    }
    private byte _replaceCategory;

    [ParamField(0x29, ParamType.U8)]
    public byte UseLimitCategory
    {
        get => _useLimitCategory;
        set => WriteParamField(ref _useLimitCategory, value);
    }
    private byte _useLimitCategory;

    #region BitField VowType0Bitfield ==============================================================================

    [ParamField(0x2A, ParamType.U8)]
    public byte VowType0Bitfield
    {
        get => _vowType0Bitfield;
        set => WriteParamField(ref _vowType0Bitfield, value);
    }
    private byte _vowType0Bitfield;

    [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 0)]
    public byte VowType0
    {
        get => GetbitfieldValue(_vowType0Bitfield);
        set => SetBitfieldValue(ref _vowType0Bitfield, value);
    }

    [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 1)]
    public byte VowType1
    {
        get => GetbitfieldValue(_vowType0Bitfield);
        set => SetBitfieldValue(ref _vowType0Bitfield, value);
    }

    [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 2)]
    public byte VowType2
    {
        get => GetbitfieldValue(_vowType0Bitfield);
        set => SetBitfieldValue(ref _vowType0Bitfield, value);
    }

    [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 3)]
    public byte VowType3
    {
        get => GetbitfieldValue(_vowType0Bitfield);
        set => SetBitfieldValue(ref _vowType0Bitfield, value);
    }

    [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 4)]
    public byte VowType4
    {
        get => GetbitfieldValue(_vowType0Bitfield);
        set => SetBitfieldValue(ref _vowType0Bitfield, value);
    }

    [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 5)]
    public byte VowType5
    {
        get => GetbitfieldValue(_vowType0Bitfield);
        set => SetBitfieldValue(ref _vowType0Bitfield, value);
    }

    [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 6)]
    public byte VowType6
    {
        get => GetbitfieldValue(_vowType0Bitfield);
        set => SetBitfieldValue(ref _vowType0Bitfield, value);
    }

    [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 7)]
    public byte VowType7
    {
        get => GetbitfieldValue(_vowType0Bitfield);
        set => SetBitfieldValue(ref _vowType0Bitfield, value);
    }

    #endregion BitField VowType0Bitfield

    #region BitField Enable_multiBitfield ==============================================================================

    [ParamField(0x2B, ParamType.U8)]
    public byte EnableMultiBitfield
    {
        get => _enableMultiBitfield;
        set => WriteParamField(ref _enableMultiBitfield, value);
    }
    private byte _enableMultiBitfield;

    [ParamBitField(nameof(EnableMultiBitfield), bits: 1, bitsOffset: 0)]
    public byte EnableMulti
    {
        get => GetbitfieldValue(_enableMultiBitfield);
        set => SetBitfieldValue(ref _enableMultiBitfield, value);
    }

    [ParamBitField(nameof(EnableMultiBitfield), bits: 1, bitsOffset: 1)]
    public byte EnableMultiOnly
    {
        get => GetbitfieldValue(_enableMultiBitfield);
        set => SetBitfieldValue(ref _enableMultiBitfield, value);
    }

    [ParamBitField(nameof(EnableMultiBitfield), bits: 1, bitsOffset: 2)]
    public byte IsEnchant
    {
        get => GetbitfieldValue(_enableMultiBitfield);
        set => SetBitfieldValue(ref _enableMultiBitfield, value);
    }

    [ParamBitField(nameof(EnableMultiBitfield), bits: 1, bitsOffset: 3)]
    public byte IsShieldEnchant
    {
        get => GetbitfieldValue(_enableMultiBitfield);
        set => SetBitfieldValue(ref _enableMultiBitfield, value);
    }

    [ParamBitField(nameof(EnableMultiBitfield), bits: 1, bitsOffset: 4)]
    public byte EnableLive
    {
        get => GetbitfieldValue(_enableMultiBitfield);
        set => SetBitfieldValue(ref _enableMultiBitfield, value);
    }

    [ParamBitField(nameof(EnableMultiBitfield), bits: 1, bitsOffset: 5)]
    public byte EnableGray
    {
        get => GetbitfieldValue(_enableMultiBitfield);
        set => SetBitfieldValue(ref _enableMultiBitfield, value);
    }

    [ParamBitField(nameof(EnableMultiBitfield), bits: 1, bitsOffset: 6)]
    public byte EnableWhite
    {
        get => GetbitfieldValue(_enableMultiBitfield);
        set => SetBitfieldValue(ref _enableMultiBitfield, value);
    }

    [ParamBitField(nameof(EnableMultiBitfield), bits: 1, bitsOffset: 7)]
    public byte EnableBlack
    {
        get => GetbitfieldValue(_enableMultiBitfield);
        set => SetBitfieldValue(ref _enableMultiBitfield, value);
    }

    #endregion BitField Enable_multiBitfield

    #region BitField DisableOfflineBitfield ==============================================================================

    [ParamField(0x2C, ParamType.U8)]
    public byte DisableOfflineBitfield
    {
        get => _disableOfflineBitfield;
        set => WriteParamField(ref _disableOfflineBitfield, value);
    }
    private byte _disableOfflineBitfield;

    [ParamBitField(nameof(DisableOfflineBitfield), bits: 1, bitsOffset: 0)]
    public byte DisableOffline
    {
        get => GetbitfieldValue(_disableOfflineBitfield);
        set => SetBitfieldValue(ref _disableOfflineBitfield, value);
    }

    [ParamBitField(nameof(DisableOfflineBitfield), bits: 1, bitsOffset: 1)]
    public byte CastResonanceMagic
    {
        get => GetbitfieldValue(_disableOfflineBitfield);
        set => SetBitfieldValue(ref _disableOfflineBitfield, value);
    }

    [ParamBitField(nameof(DisableOfflineBitfield), bits: 6, bitsOffset: 2)]
    public byte Pad1
    {
        get => GetbitfieldValue(_disableOfflineBitfield);
        set => SetBitfieldValue(ref _disableOfflineBitfield, value);
    }

    #endregion BitField DisableOfflineBitfield

    #region BitField VowType8Bitfield ==============================================================================

    [ParamField(0x2D, ParamType.U8)]
    public byte VowType8Bitfield
    {
        get => _vowType8Bitfield;
        set => WriteParamField(ref _vowType8Bitfield, value);
    }
    private byte _vowType8Bitfield;

    [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 0)]
    public byte VowType8
    {
        get => GetbitfieldValue(_vowType8Bitfield);
        set => SetBitfieldValue(ref _vowType8Bitfield, value);
    }

    [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 1)]
    public byte VowType9
    {
        get => GetbitfieldValue(_vowType8Bitfield);
        set => SetBitfieldValue(ref _vowType8Bitfield, value);
    }

    [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 2)]
    public byte VowType10
    {
        get => GetbitfieldValue(_vowType8Bitfield);
        set => SetBitfieldValue(ref _vowType8Bitfield, value);
    }

    [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 3)]
    public byte VowType11
    {
        get => GetbitfieldValue(_vowType8Bitfield);
        set => SetBitfieldValue(ref _vowType8Bitfield, value);
    }

    [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 4)]
    public byte VowType12
    {
        get => GetbitfieldValue(_vowType8Bitfield);
        set => SetBitfieldValue(ref _vowType8Bitfield, value);
    }

    [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 5)]
    public byte VowType13
    {
        get => GetbitfieldValue(_vowType8Bitfield);
        set => SetBitfieldValue(ref _vowType8Bitfield, value);
    }

    [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 6)]
    public byte VowType14
    {
        get => GetbitfieldValue(_vowType8Bitfield);
        set => SetBitfieldValue(ref _vowType8Bitfield, value);
    }

    [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 7)]
    public byte VowType15
    {
        get => GetbitfieldValue(_vowType8Bitfield);
        set => SetBitfieldValue(ref _vowType8Bitfield, value);
    }

    #endregion BitField VowType8Bitfield

    [ParamField(0x2E, ParamType.Dummy8, 2)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
