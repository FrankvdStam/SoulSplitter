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
    public class EquipParamWeapon : BaseParam
    {
        public EquipParamWeapon(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int BehaviorVariationId
        {
            get => _BehaviorVariationId;
            set => WriteParamField(ref _BehaviorVariationId, value);
        }
        private int _BehaviorVariationId;

        [ParamField(0x4, ParamType.I32)]
        public int SortId
        {
            get => _SortId;
            set => WriteParamField(ref _SortId, value);
        }
        private int _SortId;

        [ParamField(0x8, ParamType.U32)]
        public uint WanderingEquipId
        {
            get => _WanderingEquipId;
            set => WriteParamField(ref _WanderingEquipId, value);
        }
        private uint _WanderingEquipId;

        [ParamField(0xC, ParamType.F32)]
        public float Weight
        {
            get => _Weight;
            set => WriteParamField(ref _Weight, value);
        }
        private float _Weight;

        [ParamField(0x10, ParamType.F32)]
        public float WeaponWeightRate
        {
            get => _WeaponWeightRate;
            set => WriteParamField(ref _WeaponWeightRate, value);
        }
        private float _WeaponWeightRate;

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
        public float CorrectStrength
        {
            get => _CorrectStrength;
            set => WriteParamField(ref _CorrectStrength, value);
        }
        private float _CorrectStrength;

        [ParamField(0x24, ParamType.F32)]
        public float CorrectAgility
        {
            get => _CorrectAgility;
            set => WriteParamField(ref _CorrectAgility, value);
        }
        private float _CorrectAgility;

        [ParamField(0x28, ParamType.F32)]
        public float CorrectMagic
        {
            get => _CorrectMagic;
            set => WriteParamField(ref _CorrectMagic, value);
        }
        private float _CorrectMagic;

        [ParamField(0x2C, ParamType.F32)]
        public float CorrectFaith
        {
            get => _CorrectFaith;
            set => WriteParamField(ref _CorrectFaith, value);
        }
        private float _CorrectFaith;

        [ParamField(0x30, ParamType.F32)]
        public float PhysGuardCutRate
        {
            get => _PhysGuardCutRate;
            set => WriteParamField(ref _PhysGuardCutRate, value);
        }
        private float _PhysGuardCutRate;

        [ParamField(0x34, ParamType.F32)]
        public float MagGuardCutRate
        {
            get => _MagGuardCutRate;
            set => WriteParamField(ref _MagGuardCutRate, value);
        }
        private float _MagGuardCutRate;

        [ParamField(0x38, ParamType.F32)]
        public float FireGuardCutRate
        {
            get => _FireGuardCutRate;
            set => WriteParamField(ref _FireGuardCutRate, value);
        }
        private float _FireGuardCutRate;

        [ParamField(0x3C, ParamType.F32)]
        public float ThunGuardCutRate
        {
            get => _ThunGuardCutRate;
            set => WriteParamField(ref _ThunGuardCutRate, value);
        }
        private float _ThunGuardCutRate;

        [ParamField(0x40, ParamType.I32)]
        public int SpEffectBehaviorId0
        {
            get => _SpEffectBehaviorId0;
            set => WriteParamField(ref _SpEffectBehaviorId0, value);
        }
        private int _SpEffectBehaviorId0;

        [ParamField(0x44, ParamType.I32)]
        public int SpEffectBehaviorId1
        {
            get => _SpEffectBehaviorId1;
            set => WriteParamField(ref _SpEffectBehaviorId1, value);
        }
        private int _SpEffectBehaviorId1;

        [ParamField(0x48, ParamType.I32)]
        public int SpEffectBehaviorId2
        {
            get => _SpEffectBehaviorId2;
            set => WriteParamField(ref _SpEffectBehaviorId2, value);
        }
        private int _SpEffectBehaviorId2;

        [ParamField(0x4C, ParamType.I32)]
        public int ResidentSpEffectId
        {
            get => _ResidentSpEffectId;
            set => WriteParamField(ref _ResidentSpEffectId, value);
        }
        private int _ResidentSpEffectId;

        [ParamField(0x50, ParamType.I32)]
        public int ResidentSpEffectId1
        {
            get => _ResidentSpEffectId1;
            set => WriteParamField(ref _ResidentSpEffectId1, value);
        }
        private int _ResidentSpEffectId1;

        [ParamField(0x54, ParamType.I32)]
        public int ResidentSpEffectId2
        {
            get => _ResidentSpEffectId2;
            set => WriteParamField(ref _ResidentSpEffectId2, value);
        }
        private int _ResidentSpEffectId2;

        [ParamField(0x58, ParamType.I32)]
        public int MaterialSetId
        {
            get => _MaterialSetId;
            set => WriteParamField(ref _MaterialSetId, value);
        }
        private int _MaterialSetId;

        [ParamField(0x5C, ParamType.I32)]
        public int OriginEquipWep
        {
            get => _OriginEquipWep;
            set => WriteParamField(ref _OriginEquipWep, value);
        }
        private int _OriginEquipWep;

        [ParamField(0x60, ParamType.I32)]
        public int OriginEquipWep1
        {
            get => _OriginEquipWep1;
            set => WriteParamField(ref _OriginEquipWep1, value);
        }
        private int _OriginEquipWep1;

        [ParamField(0x64, ParamType.I32)]
        public int OriginEquipWep2
        {
            get => _OriginEquipWep2;
            set => WriteParamField(ref _OriginEquipWep2, value);
        }
        private int _OriginEquipWep2;

        [ParamField(0x68, ParamType.I32)]
        public int OriginEquipWep3
        {
            get => _OriginEquipWep3;
            set => WriteParamField(ref _OriginEquipWep3, value);
        }
        private int _OriginEquipWep3;

        [ParamField(0x6C, ParamType.I32)]
        public int OriginEquipWep4
        {
            get => _OriginEquipWep4;
            set => WriteParamField(ref _OriginEquipWep4, value);
        }
        private int _OriginEquipWep4;

        [ParamField(0x70, ParamType.I32)]
        public int OriginEquipWep5
        {
            get => _OriginEquipWep5;
            set => WriteParamField(ref _OriginEquipWep5, value);
        }
        private int _OriginEquipWep5;

        [ParamField(0x74, ParamType.I32)]
        public int OriginEquipWep6
        {
            get => _OriginEquipWep6;
            set => WriteParamField(ref _OriginEquipWep6, value);
        }
        private int _OriginEquipWep6;

        [ParamField(0x78, ParamType.I32)]
        public int OriginEquipWep7
        {
            get => _OriginEquipWep7;
            set => WriteParamField(ref _OriginEquipWep7, value);
        }
        private int _OriginEquipWep7;

        [ParamField(0x7C, ParamType.I32)]
        public int OriginEquipWep8
        {
            get => _OriginEquipWep8;
            set => WriteParamField(ref _OriginEquipWep8, value);
        }
        private int _OriginEquipWep8;

        [ParamField(0x80, ParamType.I32)]
        public int OriginEquipWep9
        {
            get => _OriginEquipWep9;
            set => WriteParamField(ref _OriginEquipWep9, value);
        }
        private int _OriginEquipWep9;

        [ParamField(0x84, ParamType.I32)]
        public int OriginEquipWep10
        {
            get => _OriginEquipWep10;
            set => WriteParamField(ref _OriginEquipWep10, value);
        }
        private int _OriginEquipWep10;

        [ParamField(0x88, ParamType.I32)]
        public int OriginEquipWep11
        {
            get => _OriginEquipWep11;
            set => WriteParamField(ref _OriginEquipWep11, value);
        }
        private int _OriginEquipWep11;

        [ParamField(0x8C, ParamType.I32)]
        public int OriginEquipWep12
        {
            get => _OriginEquipWep12;
            set => WriteParamField(ref _OriginEquipWep12, value);
        }
        private int _OriginEquipWep12;

        [ParamField(0x90, ParamType.I32)]
        public int OriginEquipWep13
        {
            get => _OriginEquipWep13;
            set => WriteParamField(ref _OriginEquipWep13, value);
        }
        private int _OriginEquipWep13;

        [ParamField(0x94, ParamType.I32)]
        public int OriginEquipWep14
        {
            get => _OriginEquipWep14;
            set => WriteParamField(ref _OriginEquipWep14, value);
        }
        private int _OriginEquipWep14;

        [ParamField(0x98, ParamType.I32)]
        public int OriginEquipWep15
        {
            get => _OriginEquipWep15;
            set => WriteParamField(ref _OriginEquipWep15, value);
        }
        private int _OriginEquipWep15;

        [ParamField(0x9C, ParamType.F32)]
        public float AntiDemonDamageRate
        {
            get => _AntiDemonDamageRate;
            set => WriteParamField(ref _AntiDemonDamageRate, value);
        }
        private float _AntiDemonDamageRate;

        [ParamField(0xA0, ParamType.F32)]
        public float AntSaintDamageRate
        {
            get => _AntSaintDamageRate;
            set => WriteParamField(ref _AntSaintDamageRate, value);
        }
        private float _AntSaintDamageRate;

        [ParamField(0xA4, ParamType.F32)]
        public float AntWeakA_DamageRate
        {
            get => _AntWeakA_DamageRate;
            set => WriteParamField(ref _AntWeakA_DamageRate, value);
        }
        private float _AntWeakA_DamageRate;

        [ParamField(0xA8, ParamType.F32)]
        public float AntWeakB_DamageRate
        {
            get => _AntWeakB_DamageRate;
            set => WriteParamField(ref _AntWeakB_DamageRate, value);
        }
        private float _AntWeakB_DamageRate;

        [ParamField(0xAC, ParamType.I32)]
        public int VagrantItemLotId
        {
            get => _VagrantItemLotId;
            set => WriteParamField(ref _VagrantItemLotId, value);
        }
        private int _VagrantItemLotId;

        [ParamField(0xB0, ParamType.I32)]
        public int VagrantBonusEneDropItemLotId
        {
            get => _VagrantBonusEneDropItemLotId;
            set => WriteParamField(ref _VagrantBonusEneDropItemLotId, value);
        }
        private int _VagrantBonusEneDropItemLotId;

        [ParamField(0xB4, ParamType.I32)]
        public int VagrantItemEneDropItemLotId
        {
            get => _VagrantItemEneDropItemLotId;
            set => WriteParamField(ref _VagrantItemEneDropItemLotId, value);
        }
        private int _VagrantItemEneDropItemLotId;

        [ParamField(0xB8, ParamType.U16)]
        public ushort EquipModelId
        {
            get => _EquipModelId;
            set => WriteParamField(ref _EquipModelId, value);
        }
        private ushort _EquipModelId;

        [ParamField(0xBA, ParamType.U16)]
        public ushort IconId
        {
            get => _IconId;
            set => WriteParamField(ref _IconId, value);
        }
        private ushort _IconId;

        [ParamField(0xBC, ParamType.U16)]
        public ushort Durability
        {
            get => _Durability;
            set => WriteParamField(ref _Durability, value);
        }
        private ushort _Durability;

        [ParamField(0xBE, ParamType.U16)]
        public ushort DurabilityMax
        {
            get => _DurabilityMax;
            set => WriteParamField(ref _DurabilityMax, value);
        }
        private ushort _DurabilityMax;

        [ParamField(0xC0, ParamType.U16)]
        public ushort AttackThrowEscape
        {
            get => _AttackThrowEscape;
            set => WriteParamField(ref _AttackThrowEscape, value);
        }
        private ushort _AttackThrowEscape;

        [ParamField(0xC2, ParamType.I16)]
        public short ParryDamageLife
        {
            get => _ParryDamageLife;
            set => WriteParamField(ref _ParryDamageLife, value);
        }
        private short _ParryDamageLife;

        [ParamField(0xC4, ParamType.U16)]
        public ushort AttackBasePhysics
        {
            get => _AttackBasePhysics;
            set => WriteParamField(ref _AttackBasePhysics, value);
        }
        private ushort _AttackBasePhysics;

        [ParamField(0xC6, ParamType.U16)]
        public ushort AttackBaseMagic
        {
            get => _AttackBaseMagic;
            set => WriteParamField(ref _AttackBaseMagic, value);
        }
        private ushort _AttackBaseMagic;

        [ParamField(0xC8, ParamType.U16)]
        public ushort AttackBaseFire
        {
            get => _AttackBaseFire;
            set => WriteParamField(ref _AttackBaseFire, value);
        }
        private ushort _AttackBaseFire;

        [ParamField(0xCA, ParamType.U16)]
        public ushort AttackBaseThunder
        {
            get => _AttackBaseThunder;
            set => WriteParamField(ref _AttackBaseThunder, value);
        }
        private ushort _AttackBaseThunder;

        [ParamField(0xCC, ParamType.U16)]
        public ushort AttackBaseStamina
        {
            get => _AttackBaseStamina;
            set => WriteParamField(ref _AttackBaseStamina, value);
        }
        private ushort _AttackBaseStamina;

        [ParamField(0xCE, ParamType.U16)]
        public ushort SaWeaponDamage
        {
            get => _SaWeaponDamage;
            set => WriteParamField(ref _SaWeaponDamage, value);
        }
        private ushort _SaWeaponDamage;

        [ParamField(0xD0, ParamType.I16)]
        public short SaDurability
        {
            get => _SaDurability;
            set => WriteParamField(ref _SaDurability, value);
        }
        private short _SaDurability;

        [ParamField(0xD2, ParamType.I16)]
        public short GuardAngle
        {
            get => _GuardAngle;
            set => WriteParamField(ref _GuardAngle, value);
        }
        private short _GuardAngle;

        [ParamField(0xD4, ParamType.I16)]
        public short StaminaGuardDef
        {
            get => _StaminaGuardDef;
            set => WriteParamField(ref _StaminaGuardDef, value);
        }
        private short _StaminaGuardDef;

        [ParamField(0xD6, ParamType.I16)]
        public short ReinforceTypeId
        {
            get => _ReinforceTypeId;
            set => WriteParamField(ref _ReinforceTypeId, value);
        }
        private short _ReinforceTypeId;

        [ParamField(0xD8, ParamType.I16)]
        public short TrophySGradeId
        {
            get => _TrophySGradeId;
            set => WriteParamField(ref _TrophySGradeId, value);
        }
        private short _TrophySGradeId;

        [ParamField(0xDA, ParamType.I16)]
        public short TrophySeqId
        {
            get => _TrophySeqId;
            set => WriteParamField(ref _TrophySeqId, value);
        }
        private short _TrophySeqId;

        [ParamField(0xDC, ParamType.I16)]
        public short ThrowAtkRate
        {
            get => _ThrowAtkRate;
            set => WriteParamField(ref _ThrowAtkRate, value);
        }
        private short _ThrowAtkRate;

        [ParamField(0xDE, ParamType.I16)]
        public short BowDistRate
        {
            get => _BowDistRate;
            set => WriteParamField(ref _BowDistRate, value);
        }
        private short _BowDistRate;

        [ParamField(0xE0, ParamType.U8)]
        public byte EquipModelCategory
        {
            get => _EquipModelCategory;
            set => WriteParamField(ref _EquipModelCategory, value);
        }
        private byte _EquipModelCategory;

        [ParamField(0xE1, ParamType.U8)]
        public byte EquipModelGender
        {
            get => _EquipModelGender;
            set => WriteParamField(ref _EquipModelGender, value);
        }
        private byte _EquipModelGender;

        [ParamField(0xE2, ParamType.U8)]
        public byte WeaponCategory
        {
            get => _WeaponCategory;
            set => WriteParamField(ref _WeaponCategory, value);
        }
        private byte _WeaponCategory;

        [ParamField(0xE3, ParamType.U8)]
        public byte WepmotionCategory
        {
            get => _WepmotionCategory;
            set => WriteParamField(ref _WepmotionCategory, value);
        }
        private byte _WepmotionCategory;

        [ParamField(0xE4, ParamType.U8)]
        public byte GuardmotionCategory
        {
            get => _GuardmotionCategory;
            set => WriteParamField(ref _GuardmotionCategory, value);
        }
        private byte _GuardmotionCategory;

        [ParamField(0xE5, ParamType.U8)]
        public byte AtkMaterial
        {
            get => _AtkMaterial;
            set => WriteParamField(ref _AtkMaterial, value);
        }
        private byte _AtkMaterial;

        [ParamField(0xE6, ParamType.U8)]
        public byte DefMaterial
        {
            get => _DefMaterial;
            set => WriteParamField(ref _DefMaterial, value);
        }
        private byte _DefMaterial;

        [ParamField(0xE7, ParamType.U8)]
        public byte DefSfxMaterial
        {
            get => _DefSfxMaterial;
            set => WriteParamField(ref _DefSfxMaterial, value);
        }
        private byte _DefSfxMaterial;

        [ParamField(0xE8, ParamType.U8)]
        public byte CorrectType
        {
            get => _CorrectType;
            set => WriteParamField(ref _CorrectType, value);
        }
        private byte _CorrectType;

        [ParamField(0xE9, ParamType.U8)]
        public byte SpAttribute
        {
            get => _SpAttribute;
            set => WriteParamField(ref _SpAttribute, value);
        }
        private byte _SpAttribute;

        [ParamField(0xEA, ParamType.U8)]
        public byte SpAtkcategory
        {
            get => _SpAtkcategory;
            set => WriteParamField(ref _SpAtkcategory, value);
        }
        private byte _SpAtkcategory;

        [ParamField(0xEB, ParamType.U8)]
        public byte WepmotionOneHandId
        {
            get => _WepmotionOneHandId;
            set => WriteParamField(ref _WepmotionOneHandId, value);
        }
        private byte _WepmotionOneHandId;

        [ParamField(0xEC, ParamType.U8)]
        public byte WepmotionBothHandId
        {
            get => _WepmotionBothHandId;
            set => WriteParamField(ref _WepmotionBothHandId, value);
        }
        private byte _WepmotionBothHandId;

        [ParamField(0xED, ParamType.U8)]
        public byte ProperStrength
        {
            get => _ProperStrength;
            set => WriteParamField(ref _ProperStrength, value);
        }
        private byte _ProperStrength;

        [ParamField(0xEE, ParamType.U8)]
        public byte ProperAgility
        {
            get => _ProperAgility;
            set => WriteParamField(ref _ProperAgility, value);
        }
        private byte _ProperAgility;

        [ParamField(0xEF, ParamType.U8)]
        public byte ProperMagic
        {
            get => _ProperMagic;
            set => WriteParamField(ref _ProperMagic, value);
        }
        private byte _ProperMagic;

        [ParamField(0xF0, ParamType.U8)]
        public byte ProperFaith
        {
            get => _ProperFaith;
            set => WriteParamField(ref _ProperFaith, value);
        }
        private byte _ProperFaith;

        [ParamField(0xF1, ParamType.U8)]
        public byte OverStrength
        {
            get => _OverStrength;
            set => WriteParamField(ref _OverStrength, value);
        }
        private byte _OverStrength;

        [ParamField(0xF2, ParamType.U8)]
        public byte AttackBaseParry
        {
            get => _AttackBaseParry;
            set => WriteParamField(ref _AttackBaseParry, value);
        }
        private byte _AttackBaseParry;

        [ParamField(0xF3, ParamType.U8)]
        public byte DefenseBaseParry
        {
            get => _DefenseBaseParry;
            set => WriteParamField(ref _DefenseBaseParry, value);
        }
        private byte _DefenseBaseParry;

        [ParamField(0xF4, ParamType.U8)]
        public byte GuardBaseRepel
        {
            get => _GuardBaseRepel;
            set => WriteParamField(ref _GuardBaseRepel, value);
        }
        private byte _GuardBaseRepel;

        [ParamField(0xF5, ParamType.U8)]
        public byte AttackBaseRepel
        {
            get => _AttackBaseRepel;
            set => WriteParamField(ref _AttackBaseRepel, value);
        }
        private byte _AttackBaseRepel;

        [ParamField(0xF6, ParamType.I8)]
        public sbyte GuardCutCancelRate
        {
            get => _GuardCutCancelRate;
            set => WriteParamField(ref _GuardCutCancelRate, value);
        }
        private sbyte _GuardCutCancelRate;

        [ParamField(0xF7, ParamType.I8)]
        public sbyte GuardLevel
        {
            get => _GuardLevel;
            set => WriteParamField(ref _GuardLevel, value);
        }
        private sbyte _GuardLevel;

        [ParamField(0xF8, ParamType.I8)]
        public sbyte SlashGuardCutRate
        {
            get => _SlashGuardCutRate;
            set => WriteParamField(ref _SlashGuardCutRate, value);
        }
        private sbyte _SlashGuardCutRate;

        [ParamField(0xF9, ParamType.I8)]
        public sbyte BlowGuardCutRate
        {
            get => _BlowGuardCutRate;
            set => WriteParamField(ref _BlowGuardCutRate, value);
        }
        private sbyte _BlowGuardCutRate;

        [ParamField(0xFA, ParamType.I8)]
        public sbyte ThrustGuardCutRate
        {
            get => _ThrustGuardCutRate;
            set => WriteParamField(ref _ThrustGuardCutRate, value);
        }
        private sbyte _ThrustGuardCutRate;

        [ParamField(0xFB, ParamType.I8)]
        public sbyte PoisonGuardResist
        {
            get => _PoisonGuardResist;
            set => WriteParamField(ref _PoisonGuardResist, value);
        }
        private sbyte _PoisonGuardResist;

        [ParamField(0xFC, ParamType.I8)]
        public sbyte DiseaseGuardResist
        {
            get => _DiseaseGuardResist;
            set => WriteParamField(ref _DiseaseGuardResist, value);
        }
        private sbyte _DiseaseGuardResist;

        [ParamField(0xFD, ParamType.I8)]
        public sbyte BloodGuardResist
        {
            get => _BloodGuardResist;
            set => WriteParamField(ref _BloodGuardResist, value);
        }
        private sbyte _BloodGuardResist;

        [ParamField(0xFE, ParamType.I8)]
        public sbyte CurseGuardResist
        {
            get => _CurseGuardResist;
            set => WriteParamField(ref _CurseGuardResist, value);
        }
        private sbyte _CurseGuardResist;

        [ParamField(0xFF, ParamType.U8)]
        public byte IsDurabilityDivergence
        {
            get => _IsDurabilityDivergence;
            set => WriteParamField(ref _IsDurabilityDivergence, value);
        }
        private byte _IsDurabilityDivergence;

        #region BitField RightHandEquipableBitfield ==============================================================================

        [ParamField(0x100, ParamType.U8)]
        public byte RightHandEquipableBitfield
        {
            get => _RightHandEquipableBitfield;
            set => WriteParamField(ref _RightHandEquipableBitfield, value);
        }
        private byte _RightHandEquipableBitfield;

        [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 0)]
        public byte RightHandEquipable
        {
            get => GetbitfieldValue(_RightHandEquipableBitfield);
            set => SetBitfieldValue(ref _RightHandEquipableBitfield, value);
        }

        [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 1)]
        public byte LeftHandEquipable
        {
            get => GetbitfieldValue(_RightHandEquipableBitfield);
            set => SetBitfieldValue(ref _RightHandEquipableBitfield, value);
        }

        [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 2)]
        public byte BothHandEquipable
        {
            get => GetbitfieldValue(_RightHandEquipableBitfield);
            set => SetBitfieldValue(ref _RightHandEquipableBitfield, value);
        }

        [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 3)]
        public byte ArrowSlotEquipable
        {
            get => GetbitfieldValue(_RightHandEquipableBitfield);
            set => SetBitfieldValue(ref _RightHandEquipableBitfield, value);
        }

        [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 4)]
        public byte BoltSlotEquipable
        {
            get => GetbitfieldValue(_RightHandEquipableBitfield);
            set => SetBitfieldValue(ref _RightHandEquipableBitfield, value);
        }

        [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 5)]
        public byte EnableGuard
        {
            get => GetbitfieldValue(_RightHandEquipableBitfield);
            set => SetBitfieldValue(ref _RightHandEquipableBitfield, value);
        }

        [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 6)]
        public byte EnableParry
        {
            get => GetbitfieldValue(_RightHandEquipableBitfield);
            set => SetBitfieldValue(ref _RightHandEquipableBitfield, value);
        }

        [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 7)]
        public byte EnableMagic
        {
            get => GetbitfieldValue(_RightHandEquipableBitfield);
            set => SetBitfieldValue(ref _RightHandEquipableBitfield, value);
        }

        #endregion BitField RightHandEquipableBitfield

        #region BitField EnableSorceryBitfield ==============================================================================

        [ParamField(0x101, ParamType.U8)]
        public byte EnableSorceryBitfield
        {
            get => _EnableSorceryBitfield;
            set => WriteParamField(ref _EnableSorceryBitfield, value);
        }
        private byte _EnableSorceryBitfield;

        [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 0)]
        public byte EnableSorcery
        {
            get => GetbitfieldValue(_EnableSorceryBitfield);
            set => SetBitfieldValue(ref _EnableSorceryBitfield, value);
        }

        [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 1)]
        public byte EnableMiracle
        {
            get => GetbitfieldValue(_EnableSorceryBitfield);
            set => SetBitfieldValue(ref _EnableSorceryBitfield, value);
        }

        [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 2)]
        public byte EnableVowMagic
        {
            get => GetbitfieldValue(_EnableSorceryBitfield);
            set => SetBitfieldValue(ref _EnableSorceryBitfield, value);
        }

        [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 3)]
        public byte IsNormalAttackType
        {
            get => GetbitfieldValue(_EnableSorceryBitfield);
            set => SetBitfieldValue(ref _EnableSorceryBitfield, value);
        }

        [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 4)]
        public byte IsBlowAttackType
        {
            get => GetbitfieldValue(_EnableSorceryBitfield);
            set => SetBitfieldValue(ref _EnableSorceryBitfield, value);
        }

        [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 5)]
        public byte IsSlashAttackType
        {
            get => GetbitfieldValue(_EnableSorceryBitfield);
            set => SetBitfieldValue(ref _EnableSorceryBitfield, value);
        }

        [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 6)]
        public byte IsThrustAttackType
        {
            get => GetbitfieldValue(_EnableSorceryBitfield);
            set => SetBitfieldValue(ref _EnableSorceryBitfield, value);
        }

        [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 7)]
        public byte IsEnhance
        {
            get => GetbitfieldValue(_EnableSorceryBitfield);
            set => SetBitfieldValue(ref _EnableSorceryBitfield, value);
        }

        #endregion BitField EnableSorceryBitfield

        #region BitField IsLuckCorrectBitfield ==============================================================================

        [ParamField(0x102, ParamType.U8)]
        public byte IsLuckCorrectBitfield
        {
            get => _IsLuckCorrectBitfield;
            set => WriteParamField(ref _IsLuckCorrectBitfield, value);
        }
        private byte _IsLuckCorrectBitfield;

        [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 0)]
        public byte IsLuckCorrect
        {
            get => GetbitfieldValue(_IsLuckCorrectBitfield);
            set => SetBitfieldValue(ref _IsLuckCorrectBitfield, value);
        }

        [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 1)]
        public byte IsCustom
        {
            get => GetbitfieldValue(_IsLuckCorrectBitfield);
            set => SetBitfieldValue(ref _IsLuckCorrectBitfield, value);
        }

        [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 2)]
        public byte DisableBaseChangeReset
        {
            get => GetbitfieldValue(_IsLuckCorrectBitfield);
            set => SetBitfieldValue(ref _IsLuckCorrectBitfield, value);
        }

        [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 3)]
        public byte DisableRepair
        {
            get => GetbitfieldValue(_IsLuckCorrectBitfield);
            set => SetBitfieldValue(ref _IsLuckCorrectBitfield, value);
        }

        [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 4)]
        public byte IsDarkHand
        {
            get => GetbitfieldValue(_IsLuckCorrectBitfield);
            set => SetBitfieldValue(ref _IsLuckCorrectBitfield, value);
        }

        [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 5)]
        public byte SimpleModelForDlc
        {
            get => GetbitfieldValue(_IsLuckCorrectBitfield);
            set => SetBitfieldValue(ref _IsLuckCorrectBitfield, value);
        }

        [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 6)]
        public byte LanternWep
        {
            get => GetbitfieldValue(_IsLuckCorrectBitfield);
            set => SetBitfieldValue(ref _IsLuckCorrectBitfield, value);
        }

        [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 7)]
        public byte IsVersusGhostWep
        {
            get => GetbitfieldValue(_IsLuckCorrectBitfield);
            set => SetBitfieldValue(ref _IsLuckCorrectBitfield, value);
        }

        #endregion BitField IsLuckCorrectBitfield

        #region BitField BaseChangeCategoryBitfield ==============================================================================

        [ParamField(0x103, ParamType.U8)]
        public byte BaseChangeCategoryBitfield
        {
            get => _BaseChangeCategoryBitfield;
            set => WriteParamField(ref _BaseChangeCategoryBitfield, value);
        }
        private byte _BaseChangeCategoryBitfield;

        [ParamBitField(nameof(BaseChangeCategoryBitfield), bits: 6, bitsOffset: 0)]
        public byte BaseChangeCategory
        {
            get => GetbitfieldValue(_BaseChangeCategoryBitfield);
            set => SetBitfieldValue(ref _BaseChangeCategoryBitfield, value);
        }

        [ParamBitField(nameof(BaseChangeCategoryBitfield), bits: 1, bitsOffset: 6)]
        public byte IsDragonSlayer
        {
            get => GetbitfieldValue(_BaseChangeCategoryBitfield);
            set => SetBitfieldValue(ref _BaseChangeCategoryBitfield, value);
        }

        [ParamBitField(nameof(BaseChangeCategoryBitfield), bits: 1, bitsOffset: 7)]
        public byte IsDeposit
        {
            get => GetbitfieldValue(_BaseChangeCategoryBitfield);
            set => SetBitfieldValue(ref _BaseChangeCategoryBitfield, value);
        }

        #endregion BitField BaseChangeCategoryBitfield

        [ParamField(0x105, ParamType.Dummy8, 1)]
        public byte[] Pad_0
        {
            get => _Pad_0;
            set => WriteParamField(ref _Pad_0, value);
        }
        private byte[] _Pad_0 = null!;

        [ParamField(0x106, ParamType.I16)]
        public short OldSortId
        {
            get => _OldSortId;
            set => WriteParamField(ref _OldSortId, value);
        }
        private short _OldSortId;

        [ParamField(0x108, ParamType.I16)]
        public short LevelSyncCorrectID
        {
            get => _LevelSyncCorrectID;
            set => WriteParamField(ref _LevelSyncCorrectID, value);
        }
        private short _LevelSyncCorrectID;

        [ParamField(0x10A, ParamType.Dummy8, 6)]
        public byte[] Pad_1
        {
            get => _Pad_1;
            set => WriteParamField(ref _Pad_1, value);
        }
        private byte[] _Pad_1 = null!;

    }
}
