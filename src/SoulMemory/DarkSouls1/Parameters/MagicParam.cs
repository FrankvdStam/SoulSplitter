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
using System;
using System.Diagnostics.CodeAnalysis;

namespace SoulMemory.DarkSouls1.Parameters
{
    [ExcludeFromCodeCoverage]
    public class MagicParam : BaseParam
    {
        public MagicParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int YesNoDialogMessageId
        {
            get => _YesNoDialogMessageId;
            set => WriteParamField(ref _YesNoDialogMessageId, value);
        }
        private int _YesNoDialogMessageId;

        [ParamField(0x4, ParamType.I32)]
        public int LimitCancelSpEffectId
        {
            get => _LimitCancelSpEffectId;
            set => WriteParamField(ref _LimitCancelSpEffectId, value);
        }
        private int _LimitCancelSpEffectId;

        [ParamField(0x8, ParamType.I16)]
        public short SortId
        {
            get => _SortId;
            set => WriteParamField(ref _SortId, value);
        }
        private short _SortId;

        [ParamField(0xA, ParamType.I16)]
        public short RefId
        {
            get => _RefId;
            set => WriteParamField(ref _RefId, value);
        }
        private short _RefId;

        [ParamField(0xC, ParamType.I16)]
        public short Mp
        {
            get => _Mp;
            set => WriteParamField(ref _Mp, value);
        }
        private short _Mp;

        [ParamField(0xE, ParamType.I16)]
        public short Stamina
        {
            get => _Stamina;
            set => WriteParamField(ref _Stamina, value);
        }
        private short _Stamina;

        [ParamField(0x10, ParamType.I16)]
        public short IconId
        {
            get => _IconId;
            set => WriteParamField(ref _IconId, value);
        }
        private short _IconId;

        [ParamField(0x12, ParamType.I16)]
        public short BehaviorId
        {
            get => _BehaviorId;
            set => WriteParamField(ref _BehaviorId, value);
        }
        private short _BehaviorId;

        [ParamField(0x14, ParamType.I16)]
        public short MtrlItemId
        {
            get => _MtrlItemId;
            set => WriteParamField(ref _MtrlItemId, value);
        }
        private short _MtrlItemId;

        [ParamField(0x16, ParamType.I16)]
        public short ReplaceMagicId
        {
            get => _ReplaceMagicId;
            set => WriteParamField(ref _ReplaceMagicId, value);
        }
        private short _ReplaceMagicId;

        [ParamField(0x18, ParamType.I16)]
        public short MaxQuantity
        {
            get => _MaxQuantity;
            set => WriteParamField(ref _MaxQuantity, value);
        }
        private short _MaxQuantity;

        [ParamField(0x1A, ParamType.U8)]
        public byte HeroPoint
        {
            get => _HeroPoint;
            set => WriteParamField(ref _HeroPoint, value);
        }
        private byte _HeroPoint;

        [ParamField(0x1B, ParamType.U8)]
        public byte OverDexterity
        {
            get => _OverDexterity;
            set => WriteParamField(ref _OverDexterity, value);
        }
        private byte _OverDexterity;

        [ParamField(0x1C, ParamType.I8)]
        public sbyte SfxVariationId
        {
            get => _SfxVariationId;
            set => WriteParamField(ref _SfxVariationId, value);
        }
        private sbyte _SfxVariationId;

        [ParamField(0x1D, ParamType.U8)]
        public byte SlotLength
        {
            get => _SlotLength;
            set => WriteParamField(ref _SlotLength, value);
        }
        private byte _SlotLength;

        [ParamField(0x1E, ParamType.U8)]
        public byte RequirementIntellect
        {
            get => _RequirementIntellect;
            set => WriteParamField(ref _RequirementIntellect, value);
        }
        private byte _RequirementIntellect;

        [ParamField(0x1F, ParamType.U8)]
        public byte RequirementFaith
        {
            get => _RequirementFaith;
            set => WriteParamField(ref _RequirementFaith, value);
        }
        private byte _RequirementFaith;

        [ParamField(0x20, ParamType.U8)]
        public byte AnalogDexiterityMin
        {
            get => _AnalogDexiterityMin;
            set => WriteParamField(ref _AnalogDexiterityMin, value);
        }
        private byte _AnalogDexiterityMin;

        [ParamField(0x21, ParamType.U8)]
        public byte AnalogDexiterityMax
        {
            get => _AnalogDexiterityMax;
            set => WriteParamField(ref _AnalogDexiterityMax, value);
        }
        private byte _AnalogDexiterityMax;

        [ParamField(0x22, ParamType.U8)]
        public byte EzStateBehaviorType
        {
            get => _EzStateBehaviorType;
            set => WriteParamField(ref _EzStateBehaviorType, value);
        }
        private byte _EzStateBehaviorType;

        [ParamField(0x23, ParamType.U8)]
        public byte RefCategory
        {
            get => _RefCategory;
            set => WriteParamField(ref _RefCategory, value);
        }
        private byte _RefCategory;

        [ParamField(0x24, ParamType.U8)]
        public byte SpEffectCategory
        {
            get => _SpEffectCategory;
            set => WriteParamField(ref _SpEffectCategory, value);
        }
        private byte _SpEffectCategory;

        [ParamField(0x25, ParamType.U8)]
        public byte RefType
        {
            get => _RefType;
            set => WriteParamField(ref _RefType, value);
        }
        private byte _RefType;

        [ParamField(0x26, ParamType.U8)]
        public byte OpmeMenuType
        {
            get => _OpmeMenuType;
            set => WriteParamField(ref _OpmeMenuType, value);
        }
        private byte _OpmeMenuType;

        [ParamField(0x27, ParamType.U8)]
        public byte HasSpEffectType
        {
            get => _HasSpEffectType;
            set => WriteParamField(ref _HasSpEffectType, value);
        }
        private byte _HasSpEffectType;

        [ParamField(0x28, ParamType.U8)]
        public byte ReplaceCategory
        {
            get => _ReplaceCategory;
            set => WriteParamField(ref _ReplaceCategory, value);
        }
        private byte _ReplaceCategory;

        [ParamField(0x29, ParamType.U8)]
        public byte UseLimitCategory
        {
            get => _UseLimitCategory;
            set => WriteParamField(ref _UseLimitCategory, value);
        }
        private byte _UseLimitCategory;

        #region BitField VowType0Bitfield ==============================================================================

        [ParamField(0x2A, ParamType.U8)]
        public byte VowType0Bitfield
        {
            get => _VowType0Bitfield;
            set => WriteParamField(ref _VowType0Bitfield, value);
        }
        private byte _VowType0Bitfield;

        [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 0)]
        public byte VowType0
        {
            get => GetbitfieldValue(_VowType0Bitfield);
            set => SetBitfieldValue(ref _VowType0Bitfield, value);
        }

        [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 1)]
        public byte VowType1
        {
            get => GetbitfieldValue(_VowType0Bitfield);
            set => SetBitfieldValue(ref _VowType0Bitfield, value);
        }

        [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 2)]
        public byte VowType2
        {
            get => GetbitfieldValue(_VowType0Bitfield);
            set => SetBitfieldValue(ref _VowType0Bitfield, value);
        }

        [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 3)]
        public byte VowType3
        {
            get => GetbitfieldValue(_VowType0Bitfield);
            set => SetBitfieldValue(ref _VowType0Bitfield, value);
        }

        [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 4)]
        public byte VowType4
        {
            get => GetbitfieldValue(_VowType0Bitfield);
            set => SetBitfieldValue(ref _VowType0Bitfield, value);
        }

        [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 5)]
        public byte VowType5
        {
            get => GetbitfieldValue(_VowType0Bitfield);
            set => SetBitfieldValue(ref _VowType0Bitfield, value);
        }

        [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 6)]
        public byte VowType6
        {
            get => GetbitfieldValue(_VowType0Bitfield);
            set => SetBitfieldValue(ref _VowType0Bitfield, value);
        }

        [ParamBitField(nameof(VowType0Bitfield), bits: 1, bitsOffset: 7)]
        public byte VowType7
        {
            get => GetbitfieldValue(_VowType0Bitfield);
            set => SetBitfieldValue(ref _VowType0Bitfield, value);
        }

        #endregion BitField VowType0Bitfield

        #region BitField Enable_multiBitfield ==============================================================================

        [ParamField(0x2B, ParamType.U8)]
        public byte Enable_multiBitfield
        {
            get => _Enable_multiBitfield;
            set => WriteParamField(ref _Enable_multiBitfield, value);
        }
        private byte _Enable_multiBitfield;

        [ParamBitField(nameof(Enable_multiBitfield), bits: 1, bitsOffset: 0)]
        public byte Enable_multi
        {
            get => GetbitfieldValue(_Enable_multiBitfield);
            set => SetBitfieldValue(ref _Enable_multiBitfield, value);
        }

        [ParamBitField(nameof(Enable_multiBitfield), bits: 1, bitsOffset: 1)]
        public byte Enable_multi_only
        {
            get => GetbitfieldValue(_Enable_multiBitfield);
            set => SetBitfieldValue(ref _Enable_multiBitfield, value);
        }

        [ParamBitField(nameof(Enable_multiBitfield), bits: 1, bitsOffset: 2)]
        public byte IsEnchant
        {
            get => GetbitfieldValue(_Enable_multiBitfield);
            set => SetBitfieldValue(ref _Enable_multiBitfield, value);
        }

        [ParamBitField(nameof(Enable_multiBitfield), bits: 1, bitsOffset: 3)]
        public byte IsShieldEnchant
        {
            get => GetbitfieldValue(_Enable_multiBitfield);
            set => SetBitfieldValue(ref _Enable_multiBitfield, value);
        }

        [ParamBitField(nameof(Enable_multiBitfield), bits: 1, bitsOffset: 4)]
        public byte Enable_live
        {
            get => GetbitfieldValue(_Enable_multiBitfield);
            set => SetBitfieldValue(ref _Enable_multiBitfield, value);
        }

        [ParamBitField(nameof(Enable_multiBitfield), bits: 1, bitsOffset: 5)]
        public byte Enable_gray
        {
            get => GetbitfieldValue(_Enable_multiBitfield);
            set => SetBitfieldValue(ref _Enable_multiBitfield, value);
        }

        [ParamBitField(nameof(Enable_multiBitfield), bits: 1, bitsOffset: 6)]
        public byte Enable_white
        {
            get => GetbitfieldValue(_Enable_multiBitfield);
            set => SetBitfieldValue(ref _Enable_multiBitfield, value);
        }

        [ParamBitField(nameof(Enable_multiBitfield), bits: 1, bitsOffset: 7)]
        public byte Enable_black
        {
            get => GetbitfieldValue(_Enable_multiBitfield);
            set => SetBitfieldValue(ref _Enable_multiBitfield, value);
        }

        #endregion BitField Enable_multiBitfield

        #region BitField DisableOfflineBitfield ==============================================================================

        [ParamField(0x2C, ParamType.U8)]
        public byte DisableOfflineBitfield
        {
            get => _DisableOfflineBitfield;
            set => WriteParamField(ref _DisableOfflineBitfield, value);
        }
        private byte _DisableOfflineBitfield;

        [ParamBitField(nameof(DisableOfflineBitfield), bits: 1, bitsOffset: 0)]
        public byte DisableOffline
        {
            get => GetbitfieldValue(_DisableOfflineBitfield);
            set => SetBitfieldValue(ref _DisableOfflineBitfield, value);
        }

        [ParamBitField(nameof(DisableOfflineBitfield), bits: 1, bitsOffset: 1)]
        public byte CastResonanceMagic
        {
            get => GetbitfieldValue(_DisableOfflineBitfield);
            set => SetBitfieldValue(ref _DisableOfflineBitfield, value);
        }

        [ParamBitField(nameof(DisableOfflineBitfield), bits: 6, bitsOffset: 2)]
        public byte Pad_1
        {
            get => GetbitfieldValue(_DisableOfflineBitfield);
            set => SetBitfieldValue(ref _DisableOfflineBitfield, value);
        }

        #endregion BitField DisableOfflineBitfield

        #region BitField VowType8Bitfield ==============================================================================

        [ParamField(0x2D, ParamType.U8)]
        public byte VowType8Bitfield
        {
            get => _VowType8Bitfield;
            set => WriteParamField(ref _VowType8Bitfield, value);
        }
        private byte _VowType8Bitfield;

        [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 0)]
        public byte VowType8
        {
            get => GetbitfieldValue(_VowType8Bitfield);
            set => SetBitfieldValue(ref _VowType8Bitfield, value);
        }

        [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 1)]
        public byte VowType9
        {
            get => GetbitfieldValue(_VowType8Bitfield);
            set => SetBitfieldValue(ref _VowType8Bitfield, value);
        }

        [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 2)]
        public byte VowType10
        {
            get => GetbitfieldValue(_VowType8Bitfield);
            set => SetBitfieldValue(ref _VowType8Bitfield, value);
        }

        [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 3)]
        public byte VowType11
        {
            get => GetbitfieldValue(_VowType8Bitfield);
            set => SetBitfieldValue(ref _VowType8Bitfield, value);
        }

        [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 4)]
        public byte VowType12
        {
            get => GetbitfieldValue(_VowType8Bitfield);
            set => SetBitfieldValue(ref _VowType8Bitfield, value);
        }

        [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 5)]
        public byte VowType13
        {
            get => GetbitfieldValue(_VowType8Bitfield);
            set => SetBitfieldValue(ref _VowType8Bitfield, value);
        }

        [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 6)]
        public byte VowType14
        {
            get => GetbitfieldValue(_VowType8Bitfield);
            set => SetBitfieldValue(ref _VowType8Bitfield, value);
        }

        [ParamBitField(nameof(VowType8Bitfield), bits: 1, bitsOffset: 7)]
        public byte VowType15
        {
            get => GetbitfieldValue(_VowType8Bitfield);
            set => SetBitfieldValue(ref _VowType8Bitfield, value);
        }

        #endregion BitField VowType8Bitfield

        [ParamField(0x2E, ParamType.Dummy8, 2)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad;

    }
}
