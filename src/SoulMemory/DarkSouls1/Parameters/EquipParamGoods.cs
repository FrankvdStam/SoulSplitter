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

namespace SoulMemory.DarkSouls1.Parameters
{
    public class EquipParamGoods : BaseParam
    {
        public EquipParamGoods(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

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
        public int BasicPrice
        {
            get => _BasicPrice;
            set => WriteParamField(ref _BasicPrice, value);
        }
        private int _BasicPrice;

        [ParamField(0x10, ParamType.I32)]
        public int SellValue
        {
            get => _SellValue;
            set => WriteParamField(ref _SellValue, value);
        }
        private int _SellValue;

        [ParamField(0x14, ParamType.I32)]
        public int BehaviorId
        {
            get => _BehaviorId;
            set => WriteParamField(ref _BehaviorId, value);
        }
        private int _BehaviorId;

        [ParamField(0x18, ParamType.I32)]
        public int ReplaceItemId
        {
            get => _ReplaceItemId;
            set => WriteParamField(ref _ReplaceItemId, value);
        }
        private int _ReplaceItemId;

        [ParamField(0x1C, ParamType.I32)]
        public int SortId
        {
            get => _SortId;
            set => WriteParamField(ref _SortId, value);
        }
        private int _SortId;

        [ParamField(0x20, ParamType.I32)]
        public int QwcId
        {
            get => _QwcId;
            set => WriteParamField(ref _QwcId, value);
        }
        private int _QwcId;

        [ParamField(0x24, ParamType.I32)]
        public int YesNoDialogMessageId
        {
            get => _YesNoDialogMessageId;
            set => WriteParamField(ref _YesNoDialogMessageId, value);
        }
        private int _YesNoDialogMessageId;

        [ParamField(0x28, ParamType.I32)]
        public int MagicId
        {
            get => _MagicId;
            set => WriteParamField(ref _MagicId, value);
        }
        private int _MagicId;

        [ParamField(0x2C, ParamType.U16)]
        public ushort IconId
        {
            get => _IconId;
            set => WriteParamField(ref _IconId, value);
        }
        private ushort _IconId;

        [ParamField(0x2E, ParamType.U16)]
        public ushort ModelId
        {
            get => _ModelId;
            set => WriteParamField(ref _ModelId, value);
        }
        private ushort _ModelId;

        [ParamField(0x30, ParamType.I16)]
        public short ShopLv
        {
            get => _ShopLv;
            set => WriteParamField(ref _ShopLv, value);
        }
        private short _ShopLv;

        [ParamField(0x32, ParamType.I16)]
        public short CompTrophySedId
        {
            get => _CompTrophySedId;
            set => WriteParamField(ref _CompTrophySedId, value);
        }
        private short _CompTrophySedId;

        [ParamField(0x34, ParamType.I16)]
        public short TrophySeqId
        {
            get => _TrophySeqId;
            set => WriteParamField(ref _TrophySeqId, value);
        }
        private short _TrophySeqId;

        [ParamField(0x36, ParamType.I16)]
        public short MaxNum
        {
            get => _MaxNum;
            set => WriteParamField(ref _MaxNum, value);
        }
        private short _MaxNum;

        [ParamField(0x38, ParamType.U8)]
        public byte ConsumeHeroPoint
        {
            get => _ConsumeHeroPoint;
            set => WriteParamField(ref _ConsumeHeroPoint, value);
        }
        private byte _ConsumeHeroPoint;

        [ParamField(0x39, ParamType.U8)]
        public byte OverDexterity
        {
            get => _OverDexterity;
            set => WriteParamField(ref _OverDexterity, value);
        }
        private byte _OverDexterity;

        [ParamField(0x3A, ParamType.U8)]
        public byte GoodsType
        {
            get => _GoodsType;
            set => WriteParamField(ref _GoodsType, value);
        }
        private byte _GoodsType;

        [ParamField(0x3B, ParamType.U8)]
        public byte RefCategory
        {
            get => _RefCategory;
            set => WriteParamField(ref _RefCategory, value);
        }
        private byte _RefCategory;

        [ParamField(0x3C, ParamType.U8)]
        public byte SpEffectCategory
        {
            get => _SpEffectCategory;
            set => WriteParamField(ref _SpEffectCategory, value);
        }
        private byte _SpEffectCategory;

        [ParamField(0x3D, ParamType.U8)]
        public byte GoodsCategory
        {
            get => _GoodsCategory;
            set => WriteParamField(ref _GoodsCategory, value);
        }
        private byte _GoodsCategory;

        [ParamField(0x3E, ParamType.U8)]
        public byte GoodsUseAnim
        {
            get => _GoodsUseAnim;
            set => WriteParamField(ref _GoodsUseAnim, value);
        }
        private byte _GoodsUseAnim;

        [ParamField(0x3F, ParamType.U8)]
        public byte OpmeMenuType
        {
            get => _OpmeMenuType;
            set => WriteParamField(ref _OpmeMenuType, value);
        }
        private byte _OpmeMenuType;

        [ParamField(0x40, ParamType.U8)]
        public byte UseLimitCategory
        {
            get => _UseLimitCategory;
            set => WriteParamField(ref _UseLimitCategory, value);
        }
        private byte _UseLimitCategory;

        [ParamField(0x41, ParamType.U8)]
        public byte ReplaceCategory
        {
            get => _ReplaceCategory;
            set => WriteParamField(ref _ReplaceCategory, value);
        }
        private byte _ReplaceCategory;

        #region BitField VowType0Bitfield ==============================================================================

        [ParamField(0x42, ParamType.U8)]
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

        #region BitField VowType8Bitfield ==============================================================================

        [ParamField(0x43, ParamType.U8)]
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

        #region BitField Enable_liveBitfield ==============================================================================

        [ParamField(0x44, ParamType.U8)]
        public byte Enable_liveBitfield
        {
            get => _Enable_liveBitfield;
            set => WriteParamField(ref _Enable_liveBitfield, value);
        }
        private byte _Enable_liveBitfield;

        [ParamBitField(nameof(Enable_liveBitfield), bits: 1, bitsOffset: 0)]
        public byte Enable_live
        {
            get => GetbitfieldValue(_Enable_liveBitfield);
            set => SetBitfieldValue(ref _Enable_liveBitfield, value);
        }

        [ParamBitField(nameof(Enable_liveBitfield), bits: 1, bitsOffset: 1)]
        public byte Enable_gray
        {
            get => GetbitfieldValue(_Enable_liveBitfield);
            set => SetBitfieldValue(ref _Enable_liveBitfield, value);
        }

        [ParamBitField(nameof(Enable_liveBitfield), bits: 1, bitsOffset: 2)]
        public byte Enable_white
        {
            get => GetbitfieldValue(_Enable_liveBitfield);
            set => SetBitfieldValue(ref _Enable_liveBitfield, value);
        }

        [ParamBitField(nameof(Enable_liveBitfield), bits: 1, bitsOffset: 3)]
        public byte Enable_black
        {
            get => GetbitfieldValue(_Enable_liveBitfield);
            set => SetBitfieldValue(ref _Enable_liveBitfield, value);
        }

        [ParamBitField(nameof(Enable_liveBitfield), bits: 1, bitsOffset: 4)]
        public byte Enable_multi
        {
            get => GetbitfieldValue(_Enable_liveBitfield);
            set => SetBitfieldValue(ref _Enable_liveBitfield, value);
        }

        [ParamBitField(nameof(Enable_liveBitfield), bits: 1, bitsOffset: 5)]
        public byte Enable_pvp
        {
            get => GetbitfieldValue(_Enable_liveBitfield);
            set => SetBitfieldValue(ref _Enable_liveBitfield, value);
        }

        [ParamBitField(nameof(Enable_liveBitfield), bits: 1, bitsOffset: 6)]
        public byte Disable_offline
        {
            get => GetbitfieldValue(_Enable_liveBitfield);
            set => SetBitfieldValue(ref _Enable_liveBitfield, value);
        }

        [ParamBitField(nameof(Enable_liveBitfield), bits: 1, bitsOffset: 7)]
        public byte IsEquip
        {
            get => GetbitfieldValue(_Enable_liveBitfield);
            set => SetBitfieldValue(ref _Enable_liveBitfield, value);
        }

        #endregion BitField Enable_liveBitfield

        #region BitField IsConsumeBitfield ==============================================================================

        [ParamField(0x45, ParamType.U8)]
        public byte IsConsumeBitfield
        {
            get => _IsConsumeBitfield;
            set => WriteParamField(ref _IsConsumeBitfield, value);
        }
        private byte _IsConsumeBitfield;

        [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 0)]
        public byte IsConsume
        {
            get => GetbitfieldValue(_IsConsumeBitfield);
            set => SetBitfieldValue(ref _IsConsumeBitfield, value);
        }

        [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 1)]
        public byte IsAutoEquip
        {
            get => GetbitfieldValue(_IsConsumeBitfield);
            set => SetBitfieldValue(ref _IsConsumeBitfield, value);
        }

        [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 2)]
        public byte IsEstablishment
        {
            get => GetbitfieldValue(_IsConsumeBitfield);
            set => SetBitfieldValue(ref _IsConsumeBitfield, value);
        }

        [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 3)]
        public byte IsOnlyOne
        {
            get => GetbitfieldValue(_IsConsumeBitfield);
            set => SetBitfieldValue(ref _IsConsumeBitfield, value);
        }

        [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 4)]
        public byte IsDrop
        {
            get => GetbitfieldValue(_IsConsumeBitfield);
            set => SetBitfieldValue(ref _IsConsumeBitfield, value);
        }

        [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 5)]
        public byte IsDeposit
        {
            get => GetbitfieldValue(_IsConsumeBitfield);
            set => SetBitfieldValue(ref _IsConsumeBitfield, value);
        }

        [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 6)]
        public byte IsDisableHand
        {
            get => GetbitfieldValue(_IsConsumeBitfield);
            set => SetBitfieldValue(ref _IsConsumeBitfield, value);
        }

        [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 7)]
        public byte IsTravelItem
        {
            get => GetbitfieldValue(_IsConsumeBitfield);
            set => SetBitfieldValue(ref _IsConsumeBitfield, value);
        }

        #endregion BitField IsConsumeBitfield

        #region BitField IsSuppleItemBitfield ==============================================================================

        [ParamField(0x46, ParamType.U8)]
        public byte IsSuppleItemBitfield
        {
            get => _IsSuppleItemBitfield;
            set => WriteParamField(ref _IsSuppleItemBitfield, value);
        }
        private byte _IsSuppleItemBitfield;

        [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 0)]
        public byte IsSuppleItem
        {
            get => GetbitfieldValue(_IsSuppleItemBitfield);
            set => SetBitfieldValue(ref _IsSuppleItemBitfield, value);
        }

        [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 1)]
        public byte IsFullSuppleItem
        {
            get => GetbitfieldValue(_IsSuppleItemBitfield);
            set => SetBitfieldValue(ref _IsSuppleItemBitfield, value);
        }

        [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 2)]
        public byte IsEnhance
        {
            get => GetbitfieldValue(_IsSuppleItemBitfield);
            set => SetBitfieldValue(ref _IsSuppleItemBitfield, value);
        }

        [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 3)]
        public byte IsFixItem
        {
            get => GetbitfieldValue(_IsSuppleItemBitfield);
            set => SetBitfieldValue(ref _IsSuppleItemBitfield, value);
        }

        [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 4)]
        public byte DisableMultiDropShare
        {
            get => GetbitfieldValue(_IsSuppleItemBitfield);
            set => SetBitfieldValue(ref _IsSuppleItemBitfield, value);
        }

        [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 5)]
        public byte DisableUseAtColiseum
        {
            get => GetbitfieldValue(_IsSuppleItemBitfield);
            set => SetBitfieldValue(ref _IsSuppleItemBitfield, value);
        }

        [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 6)]
        public byte DisableUseAtOutOfColiseum
        {
            get => GetbitfieldValue(_IsSuppleItemBitfield);
            set => SetBitfieldValue(ref _IsSuppleItemBitfield, value);
        }

        #endregion BitField IsSuppleItemBitfield

        [ParamField(0x47, ParamType.Dummy8, 9)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad;

        [ParamField(0x50, ParamType.I32)]
        public int VagrantItemLotId
        {
            get => _VagrantItemLotId;
            set => WriteParamField(ref _VagrantItemLotId, value);
        }
        private int _VagrantItemLotId;

        [ParamField(0x54, ParamType.I32)]
        public int VagrantBonusEneDropItemLotId
        {
            get => _VagrantBonusEneDropItemLotId;
            set => WriteParamField(ref _VagrantBonusEneDropItemLotId, value);
        }
        private int _VagrantBonusEneDropItemLotId;

        [ParamField(0x58, ParamType.I32)]
        public int VagrantItemEneDropItemLotId
        {
            get => _VagrantItemEneDropItemLotId;
            set => WriteParamField(ref _VagrantItemEneDropItemLotId, value);
        }
        private int _VagrantItemEneDropItemLotId;

    }
}
