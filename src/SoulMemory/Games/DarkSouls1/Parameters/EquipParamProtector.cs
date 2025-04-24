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
public class EquipParamProtector(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int SortId
    {
        get => _sortId;
        set => WriteParamField(ref _sortId, value);
    }
    private int _sortId;

    [ParamField(0x4, ParamType.U32)]
    public uint WanderingEquipId
    {
        get => _wanderingEquipId;
        set => WriteParamField(ref _wanderingEquipId, value);
    }
    private uint _wanderingEquipId;

    [ParamField(0x8, ParamType.I32)]
    public int VagrantItemLotId
    {
        get => _vagrantItemLotId;
        set => WriteParamField(ref _vagrantItemLotId, value);
    }
    private int _vagrantItemLotId;

    [ParamField(0xC, ParamType.I32)]
    public int VagrantBonusEneDropItemLotId
    {
        get => _vagrantBonusEneDropItemLotId;
        set => WriteParamField(ref _vagrantBonusEneDropItemLotId, value);
    }
    private int _vagrantBonusEneDropItemLotId;

    [ParamField(0x10, ParamType.I32)]
    public int VagrantItemEneDropItemLotId
    {
        get => _vagrantItemEneDropItemLotId;
        set => WriteParamField(ref _vagrantItemEneDropItemLotId, value);
    }
    private int _vagrantItemEneDropItemLotId;

    [ParamField(0x14, ParamType.I32)]
    public int FixPrice
    {
        get => _fixPrice;
        set => WriteParamField(ref _fixPrice, value);
    }
    private int _fixPrice;

    [ParamField(0x18, ParamType.I32)]
    public int BasicPrice
    {
        get => _basicPrice;
        set => WriteParamField(ref _basicPrice, value);
    }
    private int _basicPrice;

    [ParamField(0x1C, ParamType.I32)]
    public int SellValue
    {
        get => _sellValue;
        set => WriteParamField(ref _sellValue, value);
    }
    private int _sellValue;

    [ParamField(0x20, ParamType.F32)]
    public float Weight
    {
        get => _weight;
        set => WriteParamField(ref _weight, value);
    }
    private float _weight;

    [ParamField(0x24, ParamType.I32)]
    public int ResidentSpEffectId
    {
        get => _residentSpEffectId;
        set => WriteParamField(ref _residentSpEffectId, value);
    }
    private int _residentSpEffectId;

    [ParamField(0x28, ParamType.I32)]
    public int ResidentSpEffectId2
    {
        get => _residentSpEffectId2;
        set => WriteParamField(ref _residentSpEffectId2, value);
    }
    private int _residentSpEffectId2;

    [ParamField(0x2C, ParamType.I32)]
    public int ResidentSpEffectId3
    {
        get => _residentSpEffectId3;
        set => WriteParamField(ref _residentSpEffectId3, value);
    }
    private int _residentSpEffectId3;

    [ParamField(0x30, ParamType.I32)]
    public int MaterialSetId
    {
        get => _materialSetId;
        set => WriteParamField(ref _materialSetId, value);
    }
    private int _materialSetId;

    [ParamField(0x34, ParamType.F32)]
    public float PartsDamageRate
    {
        get => _partsDamageRate;
        set => WriteParamField(ref _partsDamageRate, value);
    }
    private float _partsDamageRate;

    [ParamField(0x38, ParamType.F32)]
    public float CorectSaRecover
    {
        get => _corectSaRecover;
        set => WriteParamField(ref _corectSaRecover, value);
    }
    private float _corectSaRecover;

    [ParamField(0x3C, ParamType.I32)]
    public int OriginEquipPro
    {
        get => _originEquipPro;
        set => WriteParamField(ref _originEquipPro, value);
    }
    private int _originEquipPro;

    [ParamField(0x40, ParamType.I32)]
    public int OriginEquipPro1
    {
        get => _originEquipPro1;
        set => WriteParamField(ref _originEquipPro1, value);
    }
    private int _originEquipPro1;

    [ParamField(0x44, ParamType.I32)]
    public int OriginEquipPro2
    {
        get => _originEquipPro2;
        set => WriteParamField(ref _originEquipPro2, value);
    }
    private int _originEquipPro2;

    [ParamField(0x48, ParamType.I32)]
    public int OriginEquipPro3
    {
        get => _originEquipPro3;
        set => WriteParamField(ref _originEquipPro3, value);
    }
    private int _originEquipPro3;

    [ParamField(0x4C, ParamType.I32)]
    public int OriginEquipPro4
    {
        get => _originEquipPro4;
        set => WriteParamField(ref _originEquipPro4, value);
    }
    private int _originEquipPro4;

    [ParamField(0x50, ParamType.I32)]
    public int OriginEquipPro5
    {
        get => _originEquipPro5;
        set => WriteParamField(ref _originEquipPro5, value);
    }
    private int _originEquipPro5;

    [ParamField(0x54, ParamType.I32)]
    public int OriginEquipPro6
    {
        get => _originEquipPro6;
        set => WriteParamField(ref _originEquipPro6, value);
    }
    private int _originEquipPro6;

    [ParamField(0x58, ParamType.I32)]
    public int OriginEquipPro7
    {
        get => _originEquipPro7;
        set => WriteParamField(ref _originEquipPro7, value);
    }
    private int _originEquipPro7;

    [ParamField(0x5C, ParamType.I32)]
    public int OriginEquipPro8
    {
        get => _originEquipPro8;
        set => WriteParamField(ref _originEquipPro8, value);
    }
    private int _originEquipPro8;

    [ParamField(0x60, ParamType.I32)]
    public int OriginEquipPro9
    {
        get => _originEquipPro9;
        set => WriteParamField(ref _originEquipPro9, value);
    }
    private int _originEquipPro9;

    [ParamField(0x64, ParamType.I32)]
    public int OriginEquipPro10
    {
        get => _originEquipPro10;
        set => WriteParamField(ref _originEquipPro10, value);
    }
    private int _originEquipPro10;

    [ParamField(0x68, ParamType.I32)]
    public int OriginEquipPro11
    {
        get => _originEquipPro11;
        set => WriteParamField(ref _originEquipPro11, value);
    }
    private int _originEquipPro11;

    [ParamField(0x6C, ParamType.I32)]
    public int OriginEquipPro12
    {
        get => _originEquipPro12;
        set => WriteParamField(ref _originEquipPro12, value);
    }
    private int _originEquipPro12;

    [ParamField(0x70, ParamType.I32)]
    public int OriginEquipPro13
    {
        get => _originEquipPro13;
        set => WriteParamField(ref _originEquipPro13, value);
    }
    private int _originEquipPro13;

    [ParamField(0x74, ParamType.I32)]
    public int OriginEquipPro14
    {
        get => _originEquipPro14;
        set => WriteParamField(ref _originEquipPro14, value);
    }
    private int _originEquipPro14;

    [ParamField(0x78, ParamType.I32)]
    public int OriginEquipPro15
    {
        get => _originEquipPro15;
        set => WriteParamField(ref _originEquipPro15, value);
    }
    private int _originEquipPro15;

    [ParamField(0x7C, ParamType.F32)]
    public float FaceScaleMScaleX
    {
        get => _faceScaleMScaleX;
        set => WriteParamField(ref _faceScaleMScaleX, value);
    }
    private float _faceScaleMScaleX;

    [ParamField(0x80, ParamType.F32)]
    public float FaceScaleMScaleZ
    {
        get => _faceScaleMScaleZ;
        set => WriteParamField(ref _faceScaleMScaleZ, value);
    }
    private float _faceScaleMScaleZ;

    [ParamField(0x84, ParamType.F32)]
    public float FaceScaleMMaxX
    {
        get => _faceScaleMMaxX;
        set => WriteParamField(ref _faceScaleMMaxX, value);
    }
    private float _faceScaleMMaxX;

    [ParamField(0x88, ParamType.F32)]
    public float FaceScaleMMaxZ
    {
        get => _faceScaleMMaxZ;
        set => WriteParamField(ref _faceScaleMMaxZ, value);
    }
    private float _faceScaleMMaxZ;

    [ParamField(0x8C, ParamType.F32)]
    public float FaceScaleFScaleX
    {
        get => _faceScaleFScaleX;
        set => WriteParamField(ref _faceScaleFScaleX, value);
    }
    private float _faceScaleFScaleX;

    [ParamField(0x90, ParamType.F32)]
    public float FaceScaleFScaleZ
    {
        get => _faceScaleFScaleZ;
        set => WriteParamField(ref _faceScaleFScaleZ, value);
    }
    private float _faceScaleFScaleZ;

    [ParamField(0x94, ParamType.F32)]
    public float FaceScaleFMaxX
    {
        get => _faceScaleFMaxX;
        set => WriteParamField(ref _faceScaleFMaxX, value);
    }
    private float _faceScaleFMaxX;

    [ParamField(0x98, ParamType.F32)]
    public float FaceScaleFMaxZ
    {
        get => _faceScaleFMaxZ;
        set => WriteParamField(ref _faceScaleFMaxZ, value);
    }
    private float _faceScaleFMaxZ;

    [ParamField(0x9C, ParamType.I32)]
    public int QwcId
    {
        get => _qwcId;
        set => WriteParamField(ref _qwcId, value);
    }
    private int _qwcId;

    [ParamField(0xA0, ParamType.U16)]
    public ushort EquipModelId
    {
        get => _equipModelId;
        set => WriteParamField(ref _equipModelId, value);
    }
    private ushort _equipModelId;

    [ParamField(0xA2, ParamType.U16)]
    public ushort IconIdM
    {
        get => _iconIdM;
        set => WriteParamField(ref _iconIdM, value);
    }
    private ushort _iconIdM;

    [ParamField(0xA4, ParamType.U16)]
    public ushort IconIdF
    {
        get => _iconIdF;
        set => WriteParamField(ref _iconIdF, value);
    }
    private ushort _iconIdF;

    [ParamField(0xA6, ParamType.U16)]
    public ushort KnockBack
    {
        get => _knockBack;
        set => WriteParamField(ref _knockBack, value);
    }
    private ushort _knockBack;

    [ParamField(0xA8, ParamType.U16)]
    public ushort KnockbackBounceRate
    {
        get => _knockbackBounceRate;
        set => WriteParamField(ref _knockbackBounceRate, value);
    }
    private ushort _knockbackBounceRate;

    [ParamField(0xAA, ParamType.U16)]
    public ushort Durability
    {
        get => _durability;
        set => WriteParamField(ref _durability, value);
    }
    private ushort _durability;

    [ParamField(0xAC, ParamType.U16)]
    public ushort DurabilityMax
    {
        get => _durabilityMax;
        set => WriteParamField(ref _durabilityMax, value);
    }
    private ushort _durabilityMax;

    [ParamField(0xAE, ParamType.I16)]
    public short SaDurability
    {
        get => _saDurability;
        set => WriteParamField(ref _saDurability, value);
    }
    private short _saDurability;

    [ParamField(0xB0, ParamType.U16)]
    public ushort DefFlickPower
    {
        get => _defFlickPower;
        set => WriteParamField(ref _defFlickPower, value);
    }
    private ushort _defFlickPower;

    [ParamField(0xB2, ParamType.U16)]
    public ushort DefensePhysics
    {
        get => _defensePhysics;
        set => WriteParamField(ref _defensePhysics, value);
    }
    private ushort _defensePhysics;

    [ParamField(0xB4, ParamType.U16)]
    public ushort DefenseMagic
    {
        get => _defenseMagic;
        set => WriteParamField(ref _defenseMagic, value);
    }
    private ushort _defenseMagic;

    [ParamField(0xB6, ParamType.U16)]
    public ushort DefenseFire
    {
        get => _defenseFire;
        set => WriteParamField(ref _defenseFire, value);
    }
    private ushort _defenseFire;

    [ParamField(0xB8, ParamType.U16)]
    public ushort DefenseThunder
    {
        get => _defenseThunder;
        set => WriteParamField(ref _defenseThunder, value);
    }
    private ushort _defenseThunder;

    [ParamField(0xBA, ParamType.I16)]
    public short DefenseSlash
    {
        get => _defenseSlash;
        set => WriteParamField(ref _defenseSlash, value);
    }
    private short _defenseSlash;

    [ParamField(0xBC, ParamType.I16)]
    public short DefenseBlow
    {
        get => _defenseBlow;
        set => WriteParamField(ref _defenseBlow, value);
    }
    private short _defenseBlow;

    [ParamField(0xBE, ParamType.I16)]
    public short DefenseThrust
    {
        get => _defenseThrust;
        set => WriteParamField(ref _defenseThrust, value);
    }
    private short _defenseThrust;

    [ParamField(0xC0, ParamType.U16)]
    public ushort ResistPoison
    {
        get => _resistPoison;
        set => WriteParamField(ref _resistPoison, value);
    }
    private ushort _resistPoison;

    [ParamField(0xC2, ParamType.U16)]
    public ushort ResistDisease
    {
        get => _resistDisease;
        set => WriteParamField(ref _resistDisease, value);
    }
    private ushort _resistDisease;

    [ParamField(0xC4, ParamType.U16)]
    public ushort ResistBlood
    {
        get => _resistBlood;
        set => WriteParamField(ref _resistBlood, value);
    }
    private ushort _resistBlood;

    [ParamField(0xC6, ParamType.U16)]
    public ushort ResistCurse
    {
        get => _resistCurse;
        set => WriteParamField(ref _resistCurse, value);
    }
    private ushort _resistCurse;

    [ParamField(0xC8, ParamType.I16)]
    public short ReinforceTypeId
    {
        get => _reinforceTypeId;
        set => WriteParamField(ref _reinforceTypeId, value);
    }
    private short _reinforceTypeId;

    [ParamField(0xCA, ParamType.I16)]
    public short TrophySGradeId
    {
        get => _trophySGradeId;
        set => WriteParamField(ref _trophySGradeId, value);
    }
    private short _trophySGradeId;

    [ParamField(0xCC, ParamType.I16)]
    public short ShopLv
    {
        get => _shopLv;
        set => WriteParamField(ref _shopLv, value);
    }
    private short _shopLv;

    [ParamField(0xCE, ParamType.U8)]
    public byte KnockbackParamId
    {
        get => _knockbackParamId;
        set => WriteParamField(ref _knockbackParamId, value);
    }
    private byte _knockbackParamId;

    [ParamField(0xCF, ParamType.U8)]
    public byte FlickDamageCutRate
    {
        get => _flickDamageCutRate;
        set => WriteParamField(ref _flickDamageCutRate, value);
    }
    private byte _flickDamageCutRate;

    [ParamField(0xD0, ParamType.U8)]
    public byte EquipModelCategory
    {
        get => _equipModelCategory;
        set => WriteParamField(ref _equipModelCategory, value);
    }
    private byte _equipModelCategory;

    [ParamField(0xD1, ParamType.U8)]
    public byte EquipModelGender
    {
        get => _equipModelGender;
        set => WriteParamField(ref _equipModelGender, value);
    }
    private byte _equipModelGender;

    [ParamField(0xD2, ParamType.U8)]
    public byte ProtectorCategory
    {
        get => _protectorCategory;
        set => WriteParamField(ref _protectorCategory, value);
    }
    private byte _protectorCategory;

    [ParamField(0xD3, ParamType.U8)]
    public byte DefenseMaterial
    {
        get => _defenseMaterial;
        set => WriteParamField(ref _defenseMaterial, value);
    }
    private byte _defenseMaterial;

    [ParamField(0xD4, ParamType.U8)]
    public byte DefenseMaterialSfx
    {
        get => _defenseMaterialSfx;
        set => WriteParamField(ref _defenseMaterialSfx, value);
    }
    private byte _defenseMaterialSfx;

    [ParamField(0xD5, ParamType.U8)]
    public byte PartsDmgType
    {
        get => _partsDmgType;
        set => WriteParamField(ref _partsDmgType, value);
    }
    private byte _partsDmgType;

    [ParamField(0xD6, ParamType.U8)]
    public byte DefenseMaterialWeak
    {
        get => _defenseMaterialWeak;
        set => WriteParamField(ref _defenseMaterialWeak, value);
    }
    private byte _defenseMaterialWeak;

    [ParamField(0xD7, ParamType.U8)]
    public byte DefenseMaterialSfxWeak
    {
        get => _defenseMaterialSfxWeak;
        set => WriteParamField(ref _defenseMaterialSfxWeak, value);
    }
    private byte _defenseMaterialSfxWeak;

    #region BitField IsDepositBitfield ==============================================================================

    [ParamField(0xD8, ParamType.U8)]
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
    public byte HeadEquip
    {
        get => GetbitfieldValue(_isDepositBitfield);
        set => SetBitfieldValue(ref _isDepositBitfield, value);
    }

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 2)]
    public byte BodyEquip
    {
        get => GetbitfieldValue(_isDepositBitfield);
        set => SetBitfieldValue(ref _isDepositBitfield, value);
    }

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 3)]
    public byte ArmEquip
    {
        get => GetbitfieldValue(_isDepositBitfield);
        set => SetBitfieldValue(ref _isDepositBitfield, value);
    }

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 4)]
    public byte LegEquip
    {
        get => GetbitfieldValue(_isDepositBitfield);
        set => SetBitfieldValue(ref _isDepositBitfield, value);
    }

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 5)]
    public byte UseFaceScale
    {
        get => GetbitfieldValue(_isDepositBitfield);
        set => SetBitfieldValue(ref _isDepositBitfield, value);
    }

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 6)]
    public byte InvisibleFlag00
    {
        get => GetbitfieldValue(_isDepositBitfield);
        set => SetBitfieldValue(ref _isDepositBitfield, value);
    }

    [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 7)]
    public byte InvisibleFlag01
    {
        get => GetbitfieldValue(_isDepositBitfield);
        set => SetBitfieldValue(ref _isDepositBitfield, value);
    }

    #endregion BitField IsDepositBitfield

    #region BitField InvisibleFlag02Bitfield ==============================================================================

    [ParamField(0xD9, ParamType.U8)]
    public byte InvisibleFlag02Bitfield
    {
        get => _invisibleFlag02Bitfield;
        set => WriteParamField(ref _invisibleFlag02Bitfield, value);
    }
    private byte _invisibleFlag02Bitfield;

    [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 0)]
    public byte InvisibleFlag02
    {
        get => GetbitfieldValue(_invisibleFlag02Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag02Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 1)]
    public byte InvisibleFlag03
    {
        get => GetbitfieldValue(_invisibleFlag02Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag02Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 2)]
    public byte InvisibleFlag04
    {
        get => GetbitfieldValue(_invisibleFlag02Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag02Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 3)]
    public byte InvisibleFlag05
    {
        get => GetbitfieldValue(_invisibleFlag02Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag02Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 4)]
    public byte InvisibleFlag06
    {
        get => GetbitfieldValue(_invisibleFlag02Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag02Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 5)]
    public byte InvisibleFlag07
    {
        get => GetbitfieldValue(_invisibleFlag02Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag02Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 6)]
    public byte InvisibleFlag08
    {
        get => GetbitfieldValue(_invisibleFlag02Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag02Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 7)]
    public byte InvisibleFlag09
    {
        get => GetbitfieldValue(_invisibleFlag02Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag02Bitfield, value);
    }

    #endregion BitField InvisibleFlag02Bitfield

    #region BitField InvisibleFlag10Bitfield ==============================================================================

    [ParamField(0xDA, ParamType.U8)]
    public byte InvisibleFlag10Bitfield
    {
        get => _invisibleFlag10Bitfield;
        set => WriteParamField(ref _invisibleFlag10Bitfield, value);
    }
    private byte _invisibleFlag10Bitfield;

    [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 0)]
    public byte InvisibleFlag10
    {
        get => GetbitfieldValue(_invisibleFlag10Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag10Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 1)]
    public byte InvisibleFlag11
    {
        get => GetbitfieldValue(_invisibleFlag10Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag10Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 2)]
    public byte InvisibleFlag12
    {
        get => GetbitfieldValue(_invisibleFlag10Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag10Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 3)]
    public byte InvisibleFlag13
    {
        get => GetbitfieldValue(_invisibleFlag10Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag10Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 4)]
    public byte InvisibleFlag14
    {
        get => GetbitfieldValue(_invisibleFlag10Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag10Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 5)]
    public byte InvisibleFlag15
    {
        get => GetbitfieldValue(_invisibleFlag10Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag10Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 6)]
    public byte InvisibleFlag16
    {
        get => GetbitfieldValue(_invisibleFlag10Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag10Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 7)]
    public byte InvisibleFlag17
    {
        get => GetbitfieldValue(_invisibleFlag10Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag10Bitfield, value);
    }

    #endregion BitField InvisibleFlag10Bitfield

    #region BitField InvisibleFlag18Bitfield ==============================================================================

    [ParamField(0xDB, ParamType.U8)]
    public byte InvisibleFlag18Bitfield
    {
        get => _invisibleFlag18Bitfield;
        set => WriteParamField(ref _invisibleFlag18Bitfield, value);
    }
    private byte _invisibleFlag18Bitfield;

    [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 0)]
    public byte InvisibleFlag18
    {
        get => GetbitfieldValue(_invisibleFlag18Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag18Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 1)]
    public byte InvisibleFlag19
    {
        get => GetbitfieldValue(_invisibleFlag18Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag18Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 2)]
    public byte InvisibleFlag20
    {
        get => GetbitfieldValue(_invisibleFlag18Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag18Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 3)]
    public byte InvisibleFlag21
    {
        get => GetbitfieldValue(_invisibleFlag18Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag18Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 4)]
    public byte InvisibleFlag22
    {
        get => GetbitfieldValue(_invisibleFlag18Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag18Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 5)]
    public byte InvisibleFlag23
    {
        get => GetbitfieldValue(_invisibleFlag18Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag18Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 6)]
    public byte InvisibleFlag24
    {
        get => GetbitfieldValue(_invisibleFlag18Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag18Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 7)]
    public byte InvisibleFlag25
    {
        get => GetbitfieldValue(_invisibleFlag18Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag18Bitfield, value);
    }

    #endregion BitField InvisibleFlag18Bitfield

    #region BitField InvisibleFlag26Bitfield ==============================================================================

    [ParamField(0xDC, ParamType.U8)]
    public byte InvisibleFlag26Bitfield
    {
        get => _invisibleFlag26Bitfield;
        set => WriteParamField(ref _invisibleFlag26Bitfield, value);
    }
    private byte _invisibleFlag26Bitfield;

    [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 0)]
    public byte InvisibleFlag26
    {
        get => GetbitfieldValue(_invisibleFlag26Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag26Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 1)]
    public byte InvisibleFlag27
    {
        get => GetbitfieldValue(_invisibleFlag26Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag26Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 2)]
    public byte InvisibleFlag28
    {
        get => GetbitfieldValue(_invisibleFlag26Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag26Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 3)]
    public byte InvisibleFlag29
    {
        get => GetbitfieldValue(_invisibleFlag26Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag26Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 4)]
    public byte InvisibleFlag30
    {
        get => GetbitfieldValue(_invisibleFlag26Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag26Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 5)]
    public byte InvisibleFlag31
    {
        get => GetbitfieldValue(_invisibleFlag26Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag26Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 6)]
    public byte InvisibleFlag32
    {
        get => GetbitfieldValue(_invisibleFlag26Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag26Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 7)]
    public byte InvisibleFlag33
    {
        get => GetbitfieldValue(_invisibleFlag26Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag26Bitfield, value);
    }

    #endregion BitField InvisibleFlag26Bitfield

    #region BitField InvisibleFlag34Bitfield ==============================================================================

    [ParamField(0xDD, ParamType.U8)]
    public byte InvisibleFlag34Bitfield
    {
        get => _invisibleFlag34Bitfield;
        set => WriteParamField(ref _invisibleFlag34Bitfield, value);
    }
    private byte _invisibleFlag34Bitfield;

    [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 0)]
    public byte InvisibleFlag34
    {
        get => GetbitfieldValue(_invisibleFlag34Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag34Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 1)]
    public byte InvisibleFlag35
    {
        get => GetbitfieldValue(_invisibleFlag34Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag34Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 2)]
    public byte InvisibleFlag36
    {
        get => GetbitfieldValue(_invisibleFlag34Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag34Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 3)]
    public byte InvisibleFlag37
    {
        get => GetbitfieldValue(_invisibleFlag34Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag34Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 4)]
    public byte InvisibleFlag38
    {
        get => GetbitfieldValue(_invisibleFlag34Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag34Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 5)]
    public byte InvisibleFlag39
    {
        get => GetbitfieldValue(_invisibleFlag34Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag34Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 6)]
    public byte InvisibleFlag40
    {
        get => GetbitfieldValue(_invisibleFlag34Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag34Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 7)]
    public byte InvisibleFlag41
    {
        get => GetbitfieldValue(_invisibleFlag34Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag34Bitfield, value);
    }

    #endregion BitField InvisibleFlag34Bitfield

    #region BitField InvisibleFlag42Bitfield ==============================================================================

    [ParamField(0xDE, ParamType.U8)]
    public byte InvisibleFlag42Bitfield
    {
        get => _invisibleFlag42Bitfield;
        set => WriteParamField(ref _invisibleFlag42Bitfield, value);
    }
    private byte _invisibleFlag42Bitfield;

    [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 0)]
    public byte InvisibleFlag42
    {
        get => GetbitfieldValue(_invisibleFlag42Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag42Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 1)]
    public byte InvisibleFlag43
    {
        get => GetbitfieldValue(_invisibleFlag42Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag42Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 2)]
    public byte InvisibleFlag44
    {
        get => GetbitfieldValue(_invisibleFlag42Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag42Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 3)]
    public byte InvisibleFlag45
    {
        get => GetbitfieldValue(_invisibleFlag42Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag42Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 4)]
    public byte InvisibleFlag46
    {
        get => GetbitfieldValue(_invisibleFlag42Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag42Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 5)]
    public byte InvisibleFlag47
    {
        get => GetbitfieldValue(_invisibleFlag42Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag42Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 6)]
    public byte DisableMultiDropShare
    {
        get => GetbitfieldValue(_invisibleFlag42Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag42Bitfield, value);
    }

    [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 7)]
    public byte SimpleModelForDlc
    {
        get => GetbitfieldValue(_invisibleFlag42Bitfield);
        set => SetBitfieldValue(ref _invisibleFlag42Bitfield, value);
    }

    #endregion BitField InvisibleFlag42Bitfield

    [ParamField(0xDF, ParamType.Dummy8, 1)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

    [ParamField(0xE0, ParamType.I16)]
    public short OldSortId
    {
        get => _oldSortId;
        set => WriteParamField(ref _oldSortId, value);
    }
    private short _oldSortId;

    [ParamField(0xE2, ParamType.Dummy8, 6)]
    public byte[] Pad1
    {
        get => _pad1;
        set => WriteParamField(ref _pad1, value);
    }
    private byte[] _pad1 = null!;

}
