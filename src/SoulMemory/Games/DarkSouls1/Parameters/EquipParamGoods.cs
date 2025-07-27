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
public class EquipParamGoods(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
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
    public int BasicPrice
    {
        get => _basicPrice;
        set => WriteParamField(ref _basicPrice, value);
    }
    private int _basicPrice;

    [ParamField(0x10, ParamType.I32)]
    public int SellValue
    {
        get => _sellValue;
        set => WriteParamField(ref _sellValue, value);
    }
    private int _sellValue;

    [ParamField(0x14, ParamType.I32)]
    public int BehaviorId
    {
        get => _behaviorId;
        set => WriteParamField(ref _behaviorId, value);
    }
    private int _behaviorId;

    [ParamField(0x18, ParamType.I32)]
    public int ReplaceItemId
    {
        get => _replaceItemId;
        set => WriteParamField(ref _replaceItemId, value);
    }
    private int _replaceItemId;

    [ParamField(0x1C, ParamType.I32)]
    public int SortId
    {
        get => _sortId;
        set => WriteParamField(ref _sortId, value);
    }
    private int _sortId;

    [ParamField(0x20, ParamType.I32)]
    public int QwcId
    {
        get => _qwcId;
        set => WriteParamField(ref _qwcId, value);
    }
    private int _qwcId;

    [ParamField(0x24, ParamType.I32)]
    public int YesNoDialogMessageId
    {
        get => _yesNoDialogMessageId;
        set => WriteParamField(ref _yesNoDialogMessageId, value);
    }
    private int _yesNoDialogMessageId;

    [ParamField(0x28, ParamType.I32)]
    public int MagicId
    {
        get => _magicId;
        set => WriteParamField(ref _magicId, value);
    }
    private int _magicId;

    [ParamField(0x2C, ParamType.U16)]
    public ushort IconId
    {
        get => _iconId;
        set => WriteParamField(ref _iconId, value);
    }
    private ushort _iconId;

    [ParamField(0x2E, ParamType.U16)]
    public ushort ModelId
    {
        get => _modelId;
        set => WriteParamField(ref _modelId, value);
    }
    private ushort _modelId;

    [ParamField(0x30, ParamType.I16)]
    public short ShopLv
    {
        get => _shopLv;
        set => WriteParamField(ref _shopLv, value);
    }
    private short _shopLv;

    [ParamField(0x32, ParamType.I16)]
    public short CompTrophySedId
    {
        get => _compTrophySedId;
        set => WriteParamField(ref _compTrophySedId, value);
    }
    private short _compTrophySedId;

    [ParamField(0x34, ParamType.I16)]
    public short TrophySeqId
    {
        get => _trophySeqId;
        set => WriteParamField(ref _trophySeqId, value);
    }
    private short _trophySeqId;

    [ParamField(0x36, ParamType.I16)]
    public short MaxNum
    {
        get => _maxNum;
        set => WriteParamField(ref _maxNum, value);
    }
    private short _maxNum;

    [ParamField(0x38, ParamType.U8)]
    public byte ConsumeHeroPoint
    {
        get => _consumeHeroPoint;
        set => WriteParamField(ref _consumeHeroPoint, value);
    }
    private byte _consumeHeroPoint;

    [ParamField(0x39, ParamType.U8)]
    public byte OverDexterity
    {
        get => _overDexterity;
        set => WriteParamField(ref _overDexterity, value);
    }
    private byte _overDexterity;

    [ParamField(0x3A, ParamType.U8)]
    public byte GoodsType
    {
        get => _goodsType;
        set => WriteParamField(ref _goodsType, value);
    }
    private byte _goodsType;

    [ParamField(0x3B, ParamType.U8)]
    public byte RefCategory
    {
        get => _refCategory;
        set => WriteParamField(ref _refCategory, value);
    }
    private byte _refCategory;

    [ParamField(0x3C, ParamType.U8)]
    public byte SpEffectCategory
    {
        get => _spEffectCategory;
        set => WriteParamField(ref _spEffectCategory, value);
    }
    private byte _spEffectCategory;

    [ParamField(0x3D, ParamType.U8)]
    public byte GoodsCategory
    {
        get => _goodsCategory;
        set => WriteParamField(ref _goodsCategory, value);
    }
    private byte _goodsCategory;

    [ParamField(0x3E, ParamType.U8)]
    public byte GoodsUseAnim
    {
        get => _goodsUseAnim;
        set => WriteParamField(ref _goodsUseAnim, value);
    }
    private byte _goodsUseAnim;

    [ParamField(0x3F, ParamType.U8)]
    public byte OpmeMenuType
    {
        get => _opmeMenuType;
        set => WriteParamField(ref _opmeMenuType, value);
    }
    private byte _opmeMenuType;

    [ParamField(0x40, ParamType.U8)]
    public byte UseLimitCategory
    {
        get => _useLimitCategory;
        set => WriteParamField(ref _useLimitCategory, value);
    }
    private byte _useLimitCategory;

    [ParamField(0x41, ParamType.U8)]
    public byte ReplaceCategory
    {
        get => _replaceCategory;
        set => WriteParamField(ref _replaceCategory, value);
    }
    private byte _replaceCategory;

    #region BitField VowType0Bitfield ==============================================================================

    [ParamField(0x42, ParamType.U8)]
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

    #region BitField VowType8Bitfield ==============================================================================

    [ParamField(0x43, ParamType.U8)]
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

    #region BitField Enable_liveBitfield ==============================================================================

    [ParamField(0x44, ParamType.U8)]
    public byte EnableLiveBitfield
    {
        get => _enableLiveBitfield;
        set => WriteParamField(ref _enableLiveBitfield, value);
    }
    private byte _enableLiveBitfield;

    [ParamBitField(nameof(EnableLiveBitfield), bits: 1, bitsOffset: 0)]
    public byte EnableLive
    {
        get => GetbitfieldValue(_enableLiveBitfield);
        set => SetBitfieldValue(ref _enableLiveBitfield, value);
    }

    [ParamBitField(nameof(EnableLiveBitfield), bits: 1, bitsOffset: 1)]
    public byte EnableGray
    {
        get => GetbitfieldValue(_enableLiveBitfield);
        set => SetBitfieldValue(ref _enableLiveBitfield, value);
    }

    [ParamBitField(nameof(EnableLiveBitfield), bits: 1, bitsOffset: 2)]
    public byte EnableWhite
    {
        get => GetbitfieldValue(_enableLiveBitfield);
        set => SetBitfieldValue(ref _enableLiveBitfield, value);
    }

    [ParamBitField(nameof(EnableLiveBitfield), bits: 1, bitsOffset: 3)]
    public byte EnableBlack
    {
        get => GetbitfieldValue(_enableLiveBitfield);
        set => SetBitfieldValue(ref _enableLiveBitfield, value);
    }

    [ParamBitField(nameof(EnableLiveBitfield), bits: 1, bitsOffset: 4)]
    public byte EnableMulti
    {
        get => GetbitfieldValue(_enableLiveBitfield);
        set => SetBitfieldValue(ref _enableLiveBitfield, value);
    }

    [ParamBitField(nameof(EnableLiveBitfield), bits: 1, bitsOffset: 5)]
    public byte EnablePvp
    {
        get => GetbitfieldValue(_enableLiveBitfield);
        set => SetBitfieldValue(ref _enableLiveBitfield, value);
    }

    [ParamBitField(nameof(EnableLiveBitfield), bits: 1, bitsOffset: 6)]
    public byte DisableOffline
    {
        get => GetbitfieldValue(_enableLiveBitfield);
        set => SetBitfieldValue(ref _enableLiveBitfield, value);
    }

    [ParamBitField(nameof(EnableLiveBitfield), bits: 1, bitsOffset: 7)]
    public byte IsEquip
    {
        get => GetbitfieldValue(_enableLiveBitfield);
        set => SetBitfieldValue(ref _enableLiveBitfield, value);
    }

    #endregion BitField Enable_liveBitfield

    #region BitField IsConsumeBitfield ==============================================================================

    [ParamField(0x45, ParamType.U8)]
    public byte IsConsumeBitfield
    {
        get => _isConsumeBitfield;
        set => WriteParamField(ref _isConsumeBitfield, value);
    }
    private byte _isConsumeBitfield;

    [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 0)]
    public byte IsConsume
    {
        get => GetbitfieldValue(_isConsumeBitfield);
        set => SetBitfieldValue(ref _isConsumeBitfield, value);
    }

    [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 1)]
    public byte IsAutoEquip
    {
        get => GetbitfieldValue(_isConsumeBitfield);
        set => SetBitfieldValue(ref _isConsumeBitfield, value);
    }

    [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 2)]
    public byte IsEstablishment
    {
        get => GetbitfieldValue(_isConsumeBitfield);
        set => SetBitfieldValue(ref _isConsumeBitfield, value);
    }

    [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 3)]
    public byte IsOnlyOne
    {
        get => GetbitfieldValue(_isConsumeBitfield);
        set => SetBitfieldValue(ref _isConsumeBitfield, value);
    }

    [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 4)]
    public byte IsDrop
    {
        get => GetbitfieldValue(_isConsumeBitfield);
        set => SetBitfieldValue(ref _isConsumeBitfield, value);
    }

    [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 5)]
    public byte IsDeposit
    {
        get => GetbitfieldValue(_isConsumeBitfield);
        set => SetBitfieldValue(ref _isConsumeBitfield, value);
    }

    [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 6)]
    public byte IsDisableHand
    {
        get => GetbitfieldValue(_isConsumeBitfield);
        set => SetBitfieldValue(ref _isConsumeBitfield, value);
    }

    [ParamBitField(nameof(IsConsumeBitfield), bits: 1, bitsOffset: 7)]
    public byte IsTravelItem
    {
        get => GetbitfieldValue(_isConsumeBitfield);
        set => SetBitfieldValue(ref _isConsumeBitfield, value);
    }

    #endregion BitField IsConsumeBitfield

    #region BitField IsSuppleItemBitfield ==============================================================================

    [ParamField(0x46, ParamType.U8)]
    public byte IsSuppleItemBitfield
    {
        get => _isSuppleItemBitfield;
        set => WriteParamField(ref _isSuppleItemBitfield, value);
    }
    private byte _isSuppleItemBitfield;

    [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 0)]
    public byte IsSuppleItem
    {
        get => GetbitfieldValue(_isSuppleItemBitfield);
        set => SetBitfieldValue(ref _isSuppleItemBitfield, value);
    }

    [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 1)]
    public byte IsFullSuppleItem
    {
        get => GetbitfieldValue(_isSuppleItemBitfield);
        set => SetBitfieldValue(ref _isSuppleItemBitfield, value);
    }

    [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 2)]
    public byte IsEnhance
    {
        get => GetbitfieldValue(_isSuppleItemBitfield);
        set => SetBitfieldValue(ref _isSuppleItemBitfield, value);
    }

    [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 3)]
    public byte IsFixItem
    {
        get => GetbitfieldValue(_isSuppleItemBitfield);
        set => SetBitfieldValue(ref _isSuppleItemBitfield, value);
    }

    [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 4)]
    public byte DisableMultiDropShare
    {
        get => GetbitfieldValue(_isSuppleItemBitfield);
        set => SetBitfieldValue(ref _isSuppleItemBitfield, value);
    }

    [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 5)]
    public byte DisableUseAtColiseum
    {
        get => GetbitfieldValue(_isSuppleItemBitfield);
        set => SetBitfieldValue(ref _isSuppleItemBitfield, value);
    }

    [ParamBitField(nameof(IsSuppleItemBitfield), bits: 1, bitsOffset: 6)]
    public byte DisableUseAtOutOfColiseum
    {
        get => GetbitfieldValue(_isSuppleItemBitfield);
        set => SetBitfieldValue(ref _isSuppleItemBitfield, value);
    }

    #endregion BitField IsSuppleItemBitfield

    [ParamField(0x47, ParamType.Dummy8, 9)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

    [ParamField(0x50, ParamType.I32)]
    public int VagrantItemLotId
    {
        get => _vagrantItemLotId;
        set => WriteParamField(ref _vagrantItemLotId, value);
    }
    private int _vagrantItemLotId;

    [ParamField(0x54, ParamType.I32)]
    public int VagrantBonusEneDropItemLotId
    {
        get => _vagrantBonusEneDropItemLotId;
        set => WriteParamField(ref _vagrantBonusEneDropItemLotId, value);
    }
    private int _vagrantBonusEneDropItemLotId;

    [ParamField(0x58, ParamType.I32)]
    public int VagrantItemEneDropItemLotId
    {
        get => _vagrantItemEneDropItemLotId;
        set => WriteParamField(ref _vagrantItemEneDropItemLotId, value);
    }
    private int _vagrantItemEneDropItemLotId;

}
