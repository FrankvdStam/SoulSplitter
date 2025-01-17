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

namespace SoulMemory.DarkSouls1.Parameters
{
    [ExcludeFromCodeCoverage]
    public class EquipParamProtector : BaseParam
    {
        public EquipParamProtector(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int SortId
        {
            get => _SortId;
            set => WriteParamField(ref _SortId, value);
        }
        private int _SortId;

        [ParamField(0x4, ParamType.U32)]
        public uint WanderingEquipId
        {
            get => _WanderingEquipId;
            set => WriteParamField(ref _WanderingEquipId, value);
        }
        private uint _WanderingEquipId;

        [ParamField(0x8, ParamType.I32)]
        public int VagrantItemLotId
        {
            get => _VagrantItemLotId;
            set => WriteParamField(ref _VagrantItemLotId, value);
        }
        private int _VagrantItemLotId;

        [ParamField(0xC, ParamType.I32)]
        public int VagrantBonusEneDropItemLotId
        {
            get => _VagrantBonusEneDropItemLotId;
            set => WriteParamField(ref _VagrantBonusEneDropItemLotId, value);
        }
        private int _VagrantBonusEneDropItemLotId;

        [ParamField(0x10, ParamType.I32)]
        public int VagrantItemEneDropItemLotId
        {
            get => _VagrantItemEneDropItemLotId;
            set => WriteParamField(ref _VagrantItemEneDropItemLotId, value);
        }
        private int _VagrantItemEneDropItemLotId;

        [ParamField(0x14, ParamType.I32)]
        public int FixPrice
        {
            get => _FixPrice;
            set => WriteParamField(ref _FixPrice, value);
        }
        private int _FixPrice;

        [ParamField(0x18, ParamType.I32)]
        public int BasicPrice
        {
            get => _BasicPrice;
            set => WriteParamField(ref _BasicPrice, value);
        }
        private int _BasicPrice;

        [ParamField(0x1C, ParamType.I32)]
        public int SellValue
        {
            get => _SellValue;
            set => WriteParamField(ref _SellValue, value);
        }
        private int _SellValue;

        [ParamField(0x20, ParamType.F32)]
        public float Weight
        {
            get => _Weight;
            set => WriteParamField(ref _Weight, value);
        }
        private float _Weight;

        [ParamField(0x24, ParamType.I32)]
        public int ResidentSpEffectId
        {
            get => _ResidentSpEffectId;
            set => WriteParamField(ref _ResidentSpEffectId, value);
        }
        private int _ResidentSpEffectId;

        [ParamField(0x28, ParamType.I32)]
        public int ResidentSpEffectId2
        {
            get => _ResidentSpEffectId2;
            set => WriteParamField(ref _ResidentSpEffectId2, value);
        }
        private int _ResidentSpEffectId2;

        [ParamField(0x2C, ParamType.I32)]
        public int ResidentSpEffectId3
        {
            get => _ResidentSpEffectId3;
            set => WriteParamField(ref _ResidentSpEffectId3, value);
        }
        private int _ResidentSpEffectId3;

        [ParamField(0x30, ParamType.I32)]
        public int MaterialSetId
        {
            get => _MaterialSetId;
            set => WriteParamField(ref _MaterialSetId, value);
        }
        private int _MaterialSetId;

        [ParamField(0x34, ParamType.F32)]
        public float PartsDamageRate
        {
            get => _PartsDamageRate;
            set => WriteParamField(ref _PartsDamageRate, value);
        }
        private float _PartsDamageRate;

        [ParamField(0x38, ParamType.F32)]
        public float CorectSARecover
        {
            get => _CorectSARecover;
            set => WriteParamField(ref _CorectSARecover, value);
        }
        private float _CorectSARecover;

        [ParamField(0x3C, ParamType.I32)]
        public int OriginEquipPro
        {
            get => _OriginEquipPro;
            set => WriteParamField(ref _OriginEquipPro, value);
        }
        private int _OriginEquipPro;

        [ParamField(0x40, ParamType.I32)]
        public int OriginEquipPro1
        {
            get => _OriginEquipPro1;
            set => WriteParamField(ref _OriginEquipPro1, value);
        }
        private int _OriginEquipPro1;

        [ParamField(0x44, ParamType.I32)]
        public int OriginEquipPro2
        {
            get => _OriginEquipPro2;
            set => WriteParamField(ref _OriginEquipPro2, value);
        }
        private int _OriginEquipPro2;

        [ParamField(0x48, ParamType.I32)]
        public int OriginEquipPro3
        {
            get => _OriginEquipPro3;
            set => WriteParamField(ref _OriginEquipPro3, value);
        }
        private int _OriginEquipPro3;

        [ParamField(0x4C, ParamType.I32)]
        public int OriginEquipPro4
        {
            get => _OriginEquipPro4;
            set => WriteParamField(ref _OriginEquipPro4, value);
        }
        private int _OriginEquipPro4;

        [ParamField(0x50, ParamType.I32)]
        public int OriginEquipPro5
        {
            get => _OriginEquipPro5;
            set => WriteParamField(ref _OriginEquipPro5, value);
        }
        private int _OriginEquipPro5;

        [ParamField(0x54, ParamType.I32)]
        public int OriginEquipPro6
        {
            get => _OriginEquipPro6;
            set => WriteParamField(ref _OriginEquipPro6, value);
        }
        private int _OriginEquipPro6;

        [ParamField(0x58, ParamType.I32)]
        public int OriginEquipPro7
        {
            get => _OriginEquipPro7;
            set => WriteParamField(ref _OriginEquipPro7, value);
        }
        private int _OriginEquipPro7;

        [ParamField(0x5C, ParamType.I32)]
        public int OriginEquipPro8
        {
            get => _OriginEquipPro8;
            set => WriteParamField(ref _OriginEquipPro8, value);
        }
        private int _OriginEquipPro8;

        [ParamField(0x60, ParamType.I32)]
        public int OriginEquipPro9
        {
            get => _OriginEquipPro9;
            set => WriteParamField(ref _OriginEquipPro9, value);
        }
        private int _OriginEquipPro9;

        [ParamField(0x64, ParamType.I32)]
        public int OriginEquipPro10
        {
            get => _OriginEquipPro10;
            set => WriteParamField(ref _OriginEquipPro10, value);
        }
        private int _OriginEquipPro10;

        [ParamField(0x68, ParamType.I32)]
        public int OriginEquipPro11
        {
            get => _OriginEquipPro11;
            set => WriteParamField(ref _OriginEquipPro11, value);
        }
        private int _OriginEquipPro11;

        [ParamField(0x6C, ParamType.I32)]
        public int OriginEquipPro12
        {
            get => _OriginEquipPro12;
            set => WriteParamField(ref _OriginEquipPro12, value);
        }
        private int _OriginEquipPro12;

        [ParamField(0x70, ParamType.I32)]
        public int OriginEquipPro13
        {
            get => _OriginEquipPro13;
            set => WriteParamField(ref _OriginEquipPro13, value);
        }
        private int _OriginEquipPro13;

        [ParamField(0x74, ParamType.I32)]
        public int OriginEquipPro14
        {
            get => _OriginEquipPro14;
            set => WriteParamField(ref _OriginEquipPro14, value);
        }
        private int _OriginEquipPro14;

        [ParamField(0x78, ParamType.I32)]
        public int OriginEquipPro15
        {
            get => _OriginEquipPro15;
            set => WriteParamField(ref _OriginEquipPro15, value);
        }
        private int _OriginEquipPro15;

        [ParamField(0x7C, ParamType.F32)]
        public float FaceScaleM_ScaleX
        {
            get => _FaceScaleM_ScaleX;
            set => WriteParamField(ref _FaceScaleM_ScaleX, value);
        }
        private float _FaceScaleM_ScaleX;

        [ParamField(0x80, ParamType.F32)]
        public float FaceScaleM_ScaleZ
        {
            get => _FaceScaleM_ScaleZ;
            set => WriteParamField(ref _FaceScaleM_ScaleZ, value);
        }
        private float _FaceScaleM_ScaleZ;

        [ParamField(0x84, ParamType.F32)]
        public float FaceScaleM_MaxX
        {
            get => _FaceScaleM_MaxX;
            set => WriteParamField(ref _FaceScaleM_MaxX, value);
        }
        private float _FaceScaleM_MaxX;

        [ParamField(0x88, ParamType.F32)]
        public float FaceScaleM_MaxZ
        {
            get => _FaceScaleM_MaxZ;
            set => WriteParamField(ref _FaceScaleM_MaxZ, value);
        }
        private float _FaceScaleM_MaxZ;

        [ParamField(0x8C, ParamType.F32)]
        public float FaceScaleF_ScaleX
        {
            get => _FaceScaleF_ScaleX;
            set => WriteParamField(ref _FaceScaleF_ScaleX, value);
        }
        private float _FaceScaleF_ScaleX;

        [ParamField(0x90, ParamType.F32)]
        public float FaceScaleF_ScaleZ
        {
            get => _FaceScaleF_ScaleZ;
            set => WriteParamField(ref _FaceScaleF_ScaleZ, value);
        }
        private float _FaceScaleF_ScaleZ;

        [ParamField(0x94, ParamType.F32)]
        public float FaceScaleF_MaxX
        {
            get => _FaceScaleF_MaxX;
            set => WriteParamField(ref _FaceScaleF_MaxX, value);
        }
        private float _FaceScaleF_MaxX;

        [ParamField(0x98, ParamType.F32)]
        public float FaceScaleF_MaxZ
        {
            get => _FaceScaleF_MaxZ;
            set => WriteParamField(ref _FaceScaleF_MaxZ, value);
        }
        private float _FaceScaleF_MaxZ;

        [ParamField(0x9C, ParamType.I32)]
        public int QwcId
        {
            get => _QwcId;
            set => WriteParamField(ref _QwcId, value);
        }
        private int _QwcId;

        [ParamField(0xA0, ParamType.U16)]
        public ushort EquipModelId
        {
            get => _EquipModelId;
            set => WriteParamField(ref _EquipModelId, value);
        }
        private ushort _EquipModelId;

        [ParamField(0xA2, ParamType.U16)]
        public ushort IconIdM
        {
            get => _IconIdM;
            set => WriteParamField(ref _IconIdM, value);
        }
        private ushort _IconIdM;

        [ParamField(0xA4, ParamType.U16)]
        public ushort IconIdF
        {
            get => _IconIdF;
            set => WriteParamField(ref _IconIdF, value);
        }
        private ushort _IconIdF;

        [ParamField(0xA6, ParamType.U16)]
        public ushort KnockBack
        {
            get => _KnockBack;
            set => WriteParamField(ref _KnockBack, value);
        }
        private ushort _KnockBack;

        [ParamField(0xA8, ParamType.U16)]
        public ushort KnockbackBounceRate
        {
            get => _KnockbackBounceRate;
            set => WriteParamField(ref _KnockbackBounceRate, value);
        }
        private ushort _KnockbackBounceRate;

        [ParamField(0xAA, ParamType.U16)]
        public ushort Durability
        {
            get => _Durability;
            set => WriteParamField(ref _Durability, value);
        }
        private ushort _Durability;

        [ParamField(0xAC, ParamType.U16)]
        public ushort DurabilityMax
        {
            get => _DurabilityMax;
            set => WriteParamField(ref _DurabilityMax, value);
        }
        private ushort _DurabilityMax;

        [ParamField(0xAE, ParamType.I16)]
        public short SaDurability
        {
            get => _SaDurability;
            set => WriteParamField(ref _SaDurability, value);
        }
        private short _SaDurability;

        [ParamField(0xB0, ParamType.U16)]
        public ushort DefFlickPower
        {
            get => _DefFlickPower;
            set => WriteParamField(ref _DefFlickPower, value);
        }
        private ushort _DefFlickPower;

        [ParamField(0xB2, ParamType.U16)]
        public ushort DefensePhysics
        {
            get => _DefensePhysics;
            set => WriteParamField(ref _DefensePhysics, value);
        }
        private ushort _DefensePhysics;

        [ParamField(0xB4, ParamType.U16)]
        public ushort DefenseMagic
        {
            get => _DefenseMagic;
            set => WriteParamField(ref _DefenseMagic, value);
        }
        private ushort _DefenseMagic;

        [ParamField(0xB6, ParamType.U16)]
        public ushort DefenseFire
        {
            get => _DefenseFire;
            set => WriteParamField(ref _DefenseFire, value);
        }
        private ushort _DefenseFire;

        [ParamField(0xB8, ParamType.U16)]
        public ushort DefenseThunder
        {
            get => _DefenseThunder;
            set => WriteParamField(ref _DefenseThunder, value);
        }
        private ushort _DefenseThunder;

        [ParamField(0xBA, ParamType.I16)]
        public short DefenseSlash
        {
            get => _DefenseSlash;
            set => WriteParamField(ref _DefenseSlash, value);
        }
        private short _DefenseSlash;

        [ParamField(0xBC, ParamType.I16)]
        public short DefenseBlow
        {
            get => _DefenseBlow;
            set => WriteParamField(ref _DefenseBlow, value);
        }
        private short _DefenseBlow;

        [ParamField(0xBE, ParamType.I16)]
        public short DefenseThrust
        {
            get => _DefenseThrust;
            set => WriteParamField(ref _DefenseThrust, value);
        }
        private short _DefenseThrust;

        [ParamField(0xC0, ParamType.U16)]
        public ushort ResistPoison
        {
            get => _ResistPoison;
            set => WriteParamField(ref _ResistPoison, value);
        }
        private ushort _ResistPoison;

        [ParamField(0xC2, ParamType.U16)]
        public ushort ResistDisease
        {
            get => _ResistDisease;
            set => WriteParamField(ref _ResistDisease, value);
        }
        private ushort _ResistDisease;

        [ParamField(0xC4, ParamType.U16)]
        public ushort ResistBlood
        {
            get => _ResistBlood;
            set => WriteParamField(ref _ResistBlood, value);
        }
        private ushort _ResistBlood;

        [ParamField(0xC6, ParamType.U16)]
        public ushort ResistCurse
        {
            get => _ResistCurse;
            set => WriteParamField(ref _ResistCurse, value);
        }
        private ushort _ResistCurse;

        [ParamField(0xC8, ParamType.I16)]
        public short ReinforceTypeId
        {
            get => _ReinforceTypeId;
            set => WriteParamField(ref _ReinforceTypeId, value);
        }
        private short _ReinforceTypeId;

        [ParamField(0xCA, ParamType.I16)]
        public short TrophySGradeId
        {
            get => _TrophySGradeId;
            set => WriteParamField(ref _TrophySGradeId, value);
        }
        private short _TrophySGradeId;

        [ParamField(0xCC, ParamType.I16)]
        public short ShopLv
        {
            get => _ShopLv;
            set => WriteParamField(ref _ShopLv, value);
        }
        private short _ShopLv;

        [ParamField(0xCE, ParamType.U8)]
        public byte KnockbackParamId
        {
            get => _KnockbackParamId;
            set => WriteParamField(ref _KnockbackParamId, value);
        }
        private byte _KnockbackParamId;

        [ParamField(0xCF, ParamType.U8)]
        public byte FlickDamageCutRate
        {
            get => _FlickDamageCutRate;
            set => WriteParamField(ref _FlickDamageCutRate, value);
        }
        private byte _FlickDamageCutRate;

        [ParamField(0xD0, ParamType.U8)]
        public byte EquipModelCategory
        {
            get => _EquipModelCategory;
            set => WriteParamField(ref _EquipModelCategory, value);
        }
        private byte _EquipModelCategory;

        [ParamField(0xD1, ParamType.U8)]
        public byte EquipModelGender
        {
            get => _EquipModelGender;
            set => WriteParamField(ref _EquipModelGender, value);
        }
        private byte _EquipModelGender;

        [ParamField(0xD2, ParamType.U8)]
        public byte ProtectorCategory
        {
            get => _ProtectorCategory;
            set => WriteParamField(ref _ProtectorCategory, value);
        }
        private byte _ProtectorCategory;

        [ParamField(0xD3, ParamType.U8)]
        public byte DefenseMaterial
        {
            get => _DefenseMaterial;
            set => WriteParamField(ref _DefenseMaterial, value);
        }
        private byte _DefenseMaterial;

        [ParamField(0xD4, ParamType.U8)]
        public byte DefenseMaterialSfx
        {
            get => _DefenseMaterialSfx;
            set => WriteParamField(ref _DefenseMaterialSfx, value);
        }
        private byte _DefenseMaterialSfx;

        [ParamField(0xD5, ParamType.U8)]
        public byte PartsDmgType
        {
            get => _PartsDmgType;
            set => WriteParamField(ref _PartsDmgType, value);
        }
        private byte _PartsDmgType;

        [ParamField(0xD6, ParamType.U8)]
        public byte DefenseMaterial_Weak
        {
            get => _DefenseMaterial_Weak;
            set => WriteParamField(ref _DefenseMaterial_Weak, value);
        }
        private byte _DefenseMaterial_Weak;

        [ParamField(0xD7, ParamType.U8)]
        public byte DefenseMaterialSfx_Weak
        {
            get => _DefenseMaterialSfx_Weak;
            set => WriteParamField(ref _DefenseMaterialSfx_Weak, value);
        }
        private byte _DefenseMaterialSfx_Weak;

        #region BitField IsDepositBitfield ==============================================================================

        [ParamField(0xD8, ParamType.U8)]
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
        public byte HeadEquip
        {
            get => GetbitfieldValue(_IsDepositBitfield);
            set => SetBitfieldValue(ref _IsDepositBitfield, value);
        }

        [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 2)]
        public byte BodyEquip
        {
            get => GetbitfieldValue(_IsDepositBitfield);
            set => SetBitfieldValue(ref _IsDepositBitfield, value);
        }

        [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 3)]
        public byte ArmEquip
        {
            get => GetbitfieldValue(_IsDepositBitfield);
            set => SetBitfieldValue(ref _IsDepositBitfield, value);
        }

        [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 4)]
        public byte LegEquip
        {
            get => GetbitfieldValue(_IsDepositBitfield);
            set => SetBitfieldValue(ref _IsDepositBitfield, value);
        }

        [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 5)]
        public byte UseFaceScale
        {
            get => GetbitfieldValue(_IsDepositBitfield);
            set => SetBitfieldValue(ref _IsDepositBitfield, value);
        }

        [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 6)]
        public byte InvisibleFlag00
        {
            get => GetbitfieldValue(_IsDepositBitfield);
            set => SetBitfieldValue(ref _IsDepositBitfield, value);
        }

        [ParamBitField(nameof(IsDepositBitfield), bits: 1, bitsOffset: 7)]
        public byte InvisibleFlag01
        {
            get => GetbitfieldValue(_IsDepositBitfield);
            set => SetBitfieldValue(ref _IsDepositBitfield, value);
        }

        #endregion BitField IsDepositBitfield

        #region BitField InvisibleFlag02Bitfield ==============================================================================

        [ParamField(0xD9, ParamType.U8)]
        public byte InvisibleFlag02Bitfield
        {
            get => _InvisibleFlag02Bitfield;
            set => WriteParamField(ref _InvisibleFlag02Bitfield, value);
        }
        private byte _InvisibleFlag02Bitfield;

        [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 0)]
        public byte InvisibleFlag02
        {
            get => GetbitfieldValue(_InvisibleFlag02Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag02Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 1)]
        public byte InvisibleFlag03
        {
            get => GetbitfieldValue(_InvisibleFlag02Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag02Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 2)]
        public byte InvisibleFlag04
        {
            get => GetbitfieldValue(_InvisibleFlag02Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag02Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 3)]
        public byte InvisibleFlag05
        {
            get => GetbitfieldValue(_InvisibleFlag02Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag02Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 4)]
        public byte InvisibleFlag06
        {
            get => GetbitfieldValue(_InvisibleFlag02Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag02Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 5)]
        public byte InvisibleFlag07
        {
            get => GetbitfieldValue(_InvisibleFlag02Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag02Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 6)]
        public byte InvisibleFlag08
        {
            get => GetbitfieldValue(_InvisibleFlag02Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag02Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag02Bitfield), bits: 1, bitsOffset: 7)]
        public byte InvisibleFlag09
        {
            get => GetbitfieldValue(_InvisibleFlag02Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag02Bitfield, value);
        }

        #endregion BitField InvisibleFlag02Bitfield

        #region BitField InvisibleFlag10Bitfield ==============================================================================

        [ParamField(0xDA, ParamType.U8)]
        public byte InvisibleFlag10Bitfield
        {
            get => _InvisibleFlag10Bitfield;
            set => WriteParamField(ref _InvisibleFlag10Bitfield, value);
        }
        private byte _InvisibleFlag10Bitfield;

        [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 0)]
        public byte InvisibleFlag10
        {
            get => GetbitfieldValue(_InvisibleFlag10Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag10Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 1)]
        public byte InvisibleFlag11
        {
            get => GetbitfieldValue(_InvisibleFlag10Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag10Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 2)]
        public byte InvisibleFlag12
        {
            get => GetbitfieldValue(_InvisibleFlag10Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag10Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 3)]
        public byte InvisibleFlag13
        {
            get => GetbitfieldValue(_InvisibleFlag10Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag10Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 4)]
        public byte InvisibleFlag14
        {
            get => GetbitfieldValue(_InvisibleFlag10Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag10Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 5)]
        public byte InvisibleFlag15
        {
            get => GetbitfieldValue(_InvisibleFlag10Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag10Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 6)]
        public byte InvisibleFlag16
        {
            get => GetbitfieldValue(_InvisibleFlag10Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag10Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag10Bitfield), bits: 1, bitsOffset: 7)]
        public byte InvisibleFlag17
        {
            get => GetbitfieldValue(_InvisibleFlag10Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag10Bitfield, value);
        }

        #endregion BitField InvisibleFlag10Bitfield

        #region BitField InvisibleFlag18Bitfield ==============================================================================

        [ParamField(0xDB, ParamType.U8)]
        public byte InvisibleFlag18Bitfield
        {
            get => _InvisibleFlag18Bitfield;
            set => WriteParamField(ref _InvisibleFlag18Bitfield, value);
        }
        private byte _InvisibleFlag18Bitfield;

        [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 0)]
        public byte InvisibleFlag18
        {
            get => GetbitfieldValue(_InvisibleFlag18Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag18Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 1)]
        public byte InvisibleFlag19
        {
            get => GetbitfieldValue(_InvisibleFlag18Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag18Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 2)]
        public byte InvisibleFlag20
        {
            get => GetbitfieldValue(_InvisibleFlag18Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag18Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 3)]
        public byte InvisibleFlag21
        {
            get => GetbitfieldValue(_InvisibleFlag18Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag18Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 4)]
        public byte InvisibleFlag22
        {
            get => GetbitfieldValue(_InvisibleFlag18Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag18Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 5)]
        public byte InvisibleFlag23
        {
            get => GetbitfieldValue(_InvisibleFlag18Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag18Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 6)]
        public byte InvisibleFlag24
        {
            get => GetbitfieldValue(_InvisibleFlag18Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag18Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag18Bitfield), bits: 1, bitsOffset: 7)]
        public byte InvisibleFlag25
        {
            get => GetbitfieldValue(_InvisibleFlag18Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag18Bitfield, value);
        }

        #endregion BitField InvisibleFlag18Bitfield

        #region BitField InvisibleFlag26Bitfield ==============================================================================

        [ParamField(0xDC, ParamType.U8)]
        public byte InvisibleFlag26Bitfield
        {
            get => _InvisibleFlag26Bitfield;
            set => WriteParamField(ref _InvisibleFlag26Bitfield, value);
        }
        private byte _InvisibleFlag26Bitfield;

        [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 0)]
        public byte InvisibleFlag26
        {
            get => GetbitfieldValue(_InvisibleFlag26Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag26Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 1)]
        public byte InvisibleFlag27
        {
            get => GetbitfieldValue(_InvisibleFlag26Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag26Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 2)]
        public byte InvisibleFlag28
        {
            get => GetbitfieldValue(_InvisibleFlag26Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag26Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 3)]
        public byte InvisibleFlag29
        {
            get => GetbitfieldValue(_InvisibleFlag26Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag26Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 4)]
        public byte InvisibleFlag30
        {
            get => GetbitfieldValue(_InvisibleFlag26Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag26Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 5)]
        public byte InvisibleFlag31
        {
            get => GetbitfieldValue(_InvisibleFlag26Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag26Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 6)]
        public byte InvisibleFlag32
        {
            get => GetbitfieldValue(_InvisibleFlag26Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag26Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag26Bitfield), bits: 1, bitsOffset: 7)]
        public byte InvisibleFlag33
        {
            get => GetbitfieldValue(_InvisibleFlag26Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag26Bitfield, value);
        }

        #endregion BitField InvisibleFlag26Bitfield

        #region BitField InvisibleFlag34Bitfield ==============================================================================

        [ParamField(0xDD, ParamType.U8)]
        public byte InvisibleFlag34Bitfield
        {
            get => _InvisibleFlag34Bitfield;
            set => WriteParamField(ref _InvisibleFlag34Bitfield, value);
        }
        private byte _InvisibleFlag34Bitfield;

        [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 0)]
        public byte InvisibleFlag34
        {
            get => GetbitfieldValue(_InvisibleFlag34Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag34Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 1)]
        public byte InvisibleFlag35
        {
            get => GetbitfieldValue(_InvisibleFlag34Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag34Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 2)]
        public byte InvisibleFlag36
        {
            get => GetbitfieldValue(_InvisibleFlag34Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag34Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 3)]
        public byte InvisibleFlag37
        {
            get => GetbitfieldValue(_InvisibleFlag34Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag34Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 4)]
        public byte InvisibleFlag38
        {
            get => GetbitfieldValue(_InvisibleFlag34Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag34Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 5)]
        public byte InvisibleFlag39
        {
            get => GetbitfieldValue(_InvisibleFlag34Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag34Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 6)]
        public byte InvisibleFlag40
        {
            get => GetbitfieldValue(_InvisibleFlag34Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag34Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag34Bitfield), bits: 1, bitsOffset: 7)]
        public byte InvisibleFlag41
        {
            get => GetbitfieldValue(_InvisibleFlag34Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag34Bitfield, value);
        }

        #endregion BitField InvisibleFlag34Bitfield

        #region BitField InvisibleFlag42Bitfield ==============================================================================

        [ParamField(0xDE, ParamType.U8)]
        public byte InvisibleFlag42Bitfield
        {
            get => _InvisibleFlag42Bitfield;
            set => WriteParamField(ref _InvisibleFlag42Bitfield, value);
        }
        private byte _InvisibleFlag42Bitfield;

        [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 0)]
        public byte InvisibleFlag42
        {
            get => GetbitfieldValue(_InvisibleFlag42Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag42Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 1)]
        public byte InvisibleFlag43
        {
            get => GetbitfieldValue(_InvisibleFlag42Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag42Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 2)]
        public byte InvisibleFlag44
        {
            get => GetbitfieldValue(_InvisibleFlag42Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag42Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 3)]
        public byte InvisibleFlag45
        {
            get => GetbitfieldValue(_InvisibleFlag42Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag42Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 4)]
        public byte InvisibleFlag46
        {
            get => GetbitfieldValue(_InvisibleFlag42Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag42Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 5)]
        public byte InvisibleFlag47
        {
            get => GetbitfieldValue(_InvisibleFlag42Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag42Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 6)]
        public byte DisableMultiDropShare
        {
            get => GetbitfieldValue(_InvisibleFlag42Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag42Bitfield, value);
        }

        [ParamBitField(nameof(InvisibleFlag42Bitfield), bits: 1, bitsOffset: 7)]
        public byte SimpleModelForDlc
        {
            get => GetbitfieldValue(_InvisibleFlag42Bitfield);
            set => SetBitfieldValue(ref _InvisibleFlag42Bitfield, value);
        }

        #endregion BitField InvisibleFlag42Bitfield

        [ParamField(0xDF, ParamType.Dummy8, 1)]
        public byte[] Pad_0
        {
            get => _Pad_0;
            set => WriteParamField(ref _Pad_0, value);
        }
        private byte[] _Pad_0 = null!;

        [ParamField(0xE0, ParamType.I16)]
        public short OldSortId
        {
            get => _OldSortId;
            set => WriteParamField(ref _OldSortId, value);
        }
        private short _OldSortId;

        [ParamField(0xE2, ParamType.Dummy8, 6)]
        public byte[] Pad_1
        {
            get => _Pad_1;
            set => WriteParamField(ref _Pad_1, value);
        }
        private byte[] _Pad_1 = null!;

    }
}
