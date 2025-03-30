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
public class EquipParamWeapon(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int BehaviorVariationId
    {
        get => _behaviorVariationId;
        set => WriteParamField(ref _behaviorVariationId, value);
    }
    private int _behaviorVariationId;

    [ParamField(0x4, ParamType.I32)]
    public int SortId
    {
        get => _sortId;
        set => WriteParamField(ref _sortId, value);
    }
    private int _sortId;

    [ParamField(0x8, ParamType.U32)]
    public uint WanderingEquipId
    {
        get => _wanderingEquipId;
        set => WriteParamField(ref _wanderingEquipId, value);
    }
    private uint _wanderingEquipId;

    [ParamField(0xC, ParamType.F32)]
    public float Weight
    {
        get => _weight;
        set => WriteParamField(ref _weight, value);
    }
    private float _weight;

    [ParamField(0x10, ParamType.F32)]
    public float WeaponWeightRate
    {
        get => _weaponWeightRate;
        set => WriteParamField(ref _weaponWeightRate, value);
    }
    private float _weaponWeightRate;

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
    public float CorrectStrength
    {
        get => _correctStrength;
        set => WriteParamField(ref _correctStrength, value);
    }
    private float _correctStrength;

    [ParamField(0x24, ParamType.F32)]
    public float CorrectAgility
    {
        get => _correctAgility;
        set => WriteParamField(ref _correctAgility, value);
    }
    private float _correctAgility;

    [ParamField(0x28, ParamType.F32)]
    public float CorrectMagic
    {
        get => _correctMagic;
        set => WriteParamField(ref _correctMagic, value);
    }
    private float _correctMagic;

    [ParamField(0x2C, ParamType.F32)]
    public float CorrectFaith
    {
        get => _correctFaith;
        set => WriteParamField(ref _correctFaith, value);
    }
    private float _correctFaith;

    [ParamField(0x30, ParamType.F32)]
    public float PhysGuardCutRate
    {
        get => _physGuardCutRate;
        set => WriteParamField(ref _physGuardCutRate, value);
    }
    private float _physGuardCutRate;

    [ParamField(0x34, ParamType.F32)]
    public float MagGuardCutRate
    {
        get => _magGuardCutRate;
        set => WriteParamField(ref _magGuardCutRate, value);
    }
    private float _magGuardCutRate;

    [ParamField(0x38, ParamType.F32)]
    public float FireGuardCutRate
    {
        get => _fireGuardCutRate;
        set => WriteParamField(ref _fireGuardCutRate, value);
    }
    private float _fireGuardCutRate;

    [ParamField(0x3C, ParamType.F32)]
    public float ThunGuardCutRate
    {
        get => _thunGuardCutRate;
        set => WriteParamField(ref _thunGuardCutRate, value);
    }
    private float _thunGuardCutRate;

    [ParamField(0x40, ParamType.I32)]
    public int SpEffectBehaviorId0
    {
        get => _spEffectBehaviorId0;
        set => WriteParamField(ref _spEffectBehaviorId0, value);
    }
    private int _spEffectBehaviorId0;

    [ParamField(0x44, ParamType.I32)]
    public int SpEffectBehaviorId1
    {
        get => _spEffectBehaviorId1;
        set => WriteParamField(ref _spEffectBehaviorId1, value);
    }
    private int _spEffectBehaviorId1;

    [ParamField(0x48, ParamType.I32)]
    public int SpEffectBehaviorId2
    {
        get => _spEffectBehaviorId2;
        set => WriteParamField(ref _spEffectBehaviorId2, value);
    }
    private int _spEffectBehaviorId2;

    [ParamField(0x4C, ParamType.I32)]
    public int ResidentSpEffectId
    {
        get => _residentSpEffectId;
        set => WriteParamField(ref _residentSpEffectId, value);
    }
    private int _residentSpEffectId;

    [ParamField(0x50, ParamType.I32)]
    public int ResidentSpEffectId1
    {
        get => _residentSpEffectId1;
        set => WriteParamField(ref _residentSpEffectId1, value);
    }
    private int _residentSpEffectId1;

    [ParamField(0x54, ParamType.I32)]
    public int ResidentSpEffectId2
    {
        get => _residentSpEffectId2;
        set => WriteParamField(ref _residentSpEffectId2, value);
    }
    private int _residentSpEffectId2;

    [ParamField(0x58, ParamType.I32)]
    public int MaterialSetId
    {
        get => _materialSetId;
        set => WriteParamField(ref _materialSetId, value);
    }
    private int _materialSetId;

    [ParamField(0x5C, ParamType.I32)]
    public int OriginEquipWep
    {
        get => _originEquipWep;
        set => WriteParamField(ref _originEquipWep, value);
    }
    private int _originEquipWep;

    [ParamField(0x60, ParamType.I32)]
    public int OriginEquipWep1
    {
        get => _originEquipWep1;
        set => WriteParamField(ref _originEquipWep1, value);
    }
    private int _originEquipWep1;

    [ParamField(0x64, ParamType.I32)]
    public int OriginEquipWep2
    {
        get => _originEquipWep2;
        set => WriteParamField(ref _originEquipWep2, value);
    }
    private int _originEquipWep2;

    [ParamField(0x68, ParamType.I32)]
    public int OriginEquipWep3
    {
        get => _originEquipWep3;
        set => WriteParamField(ref _originEquipWep3, value);
    }
    private int _originEquipWep3;

    [ParamField(0x6C, ParamType.I32)]
    public int OriginEquipWep4
    {
        get => _originEquipWep4;
        set => WriteParamField(ref _originEquipWep4, value);
    }
    private int _originEquipWep4;

    [ParamField(0x70, ParamType.I32)]
    public int OriginEquipWep5
    {
        get => _originEquipWep5;
        set => WriteParamField(ref _originEquipWep5, value);
    }
    private int _originEquipWep5;

    [ParamField(0x74, ParamType.I32)]
    public int OriginEquipWep6
    {
        get => _originEquipWep6;
        set => WriteParamField(ref _originEquipWep6, value);
    }
    private int _originEquipWep6;

    [ParamField(0x78, ParamType.I32)]
    public int OriginEquipWep7
    {
        get => _originEquipWep7;
        set => WriteParamField(ref _originEquipWep7, value);
    }
    private int _originEquipWep7;

    [ParamField(0x7C, ParamType.I32)]
    public int OriginEquipWep8
    {
        get => _originEquipWep8;
        set => WriteParamField(ref _originEquipWep8, value);
    }
    private int _originEquipWep8;

    [ParamField(0x80, ParamType.I32)]
    public int OriginEquipWep9
    {
        get => _originEquipWep9;
        set => WriteParamField(ref _originEquipWep9, value);
    }
    private int _originEquipWep9;

    [ParamField(0x84, ParamType.I32)]
    public int OriginEquipWep10
    {
        get => _originEquipWep10;
        set => WriteParamField(ref _originEquipWep10, value);
    }
    private int _originEquipWep10;

    [ParamField(0x88, ParamType.I32)]
    public int OriginEquipWep11
    {
        get => _originEquipWep11;
        set => WriteParamField(ref _originEquipWep11, value);
    }
    private int _originEquipWep11;

    [ParamField(0x8C, ParamType.I32)]
    public int OriginEquipWep12
    {
        get => _originEquipWep12;
        set => WriteParamField(ref _originEquipWep12, value);
    }
    private int _originEquipWep12;

    [ParamField(0x90, ParamType.I32)]
    public int OriginEquipWep13
    {
        get => _originEquipWep13;
        set => WriteParamField(ref _originEquipWep13, value);
    }
    private int _originEquipWep13;

    [ParamField(0x94, ParamType.I32)]
    public int OriginEquipWep14
    {
        get => _originEquipWep14;
        set => WriteParamField(ref _originEquipWep14, value);
    }
    private int _originEquipWep14;

    [ParamField(0x98, ParamType.I32)]
    public int OriginEquipWep15
    {
        get => _originEquipWep15;
        set => WriteParamField(ref _originEquipWep15, value);
    }
    private int _originEquipWep15;

    [ParamField(0x9C, ParamType.F32)]
    public float AntiDemonDamageRate
    {
        get => _antiDemonDamageRate;
        set => WriteParamField(ref _antiDemonDamageRate, value);
    }
    private float _antiDemonDamageRate;

    [ParamField(0xA0, ParamType.F32)]
    public float AntSaintDamageRate
    {
        get => _antSaintDamageRate;
        set => WriteParamField(ref _antSaintDamageRate, value);
    }
    private float _antSaintDamageRate;

    [ParamField(0xA4, ParamType.F32)]
    public float AntWeakADamageRate
    {
        get => _antWeakADamageRate;
        set => WriteParamField(ref _antWeakADamageRate, value);
    }
    private float _antWeakADamageRate;

    [ParamField(0xA8, ParamType.F32)]
    public float AntWeakBDamageRate
    {
        get => _antWeakBDamageRate;
        set => WriteParamField(ref _antWeakBDamageRate, value);
    }
    private float _antWeakBDamageRate;

    [ParamField(0xAC, ParamType.I32)]
    public int VagrantItemLotId
    {
        get => _vagrantItemLotId;
        set => WriteParamField(ref _vagrantItemLotId, value);
    }
    private int _vagrantItemLotId;

    [ParamField(0xB0, ParamType.I32)]
    public int VagrantBonusEneDropItemLotId
    {
        get => _vagrantBonusEneDropItemLotId;
        set => WriteParamField(ref _vagrantBonusEneDropItemLotId, value);
    }
    private int _vagrantBonusEneDropItemLotId;

    [ParamField(0xB4, ParamType.I32)]
    public int VagrantItemEneDropItemLotId
    {
        get => _vagrantItemEneDropItemLotId;
        set => WriteParamField(ref _vagrantItemEneDropItemLotId, value);
    }
    private int _vagrantItemEneDropItemLotId;

    [ParamField(0xB8, ParamType.U16)]
    public ushort EquipModelId
    {
        get => _equipModelId;
        set => WriteParamField(ref _equipModelId, value);
    }
    private ushort _equipModelId;

    [ParamField(0xBA, ParamType.U16)]
    public ushort IconId
    {
        get => _iconId;
        set => WriteParamField(ref _iconId, value);
    }
    private ushort _iconId;

    [ParamField(0xBC, ParamType.U16)]
    public ushort Durability
    {
        get => _durability;
        set => WriteParamField(ref _durability, value);
    }
    private ushort _durability;

    [ParamField(0xBE, ParamType.U16)]
    public ushort DurabilityMax
    {
        get => _durabilityMax;
        set => WriteParamField(ref _durabilityMax, value);
    }
    private ushort _durabilityMax;

    [ParamField(0xC0, ParamType.U16)]
    public ushort AttackThrowEscape
    {
        get => _attackThrowEscape;
        set => WriteParamField(ref _attackThrowEscape, value);
    }
    private ushort _attackThrowEscape;

    [ParamField(0xC2, ParamType.I16)]
    public short ParryDamageLife
    {
        get => _parryDamageLife;
        set => WriteParamField(ref _parryDamageLife, value);
    }
    private short _parryDamageLife;

    [ParamField(0xC4, ParamType.U16)]
    public ushort AttackBasePhysics
    {
        get => _attackBasePhysics;
        set => WriteParamField(ref _attackBasePhysics, value);
    }
    private ushort _attackBasePhysics;

    [ParamField(0xC6, ParamType.U16)]
    public ushort AttackBaseMagic
    {
        get => _attackBaseMagic;
        set => WriteParamField(ref _attackBaseMagic, value);
    }
    private ushort _attackBaseMagic;

    [ParamField(0xC8, ParamType.U16)]
    public ushort AttackBaseFire
    {
        get => _attackBaseFire;
        set => WriteParamField(ref _attackBaseFire, value);
    }
    private ushort _attackBaseFire;

    [ParamField(0xCA, ParamType.U16)]
    public ushort AttackBaseThunder
    {
        get => _attackBaseThunder;
        set => WriteParamField(ref _attackBaseThunder, value);
    }
    private ushort _attackBaseThunder;

    [ParamField(0xCC, ParamType.U16)]
    public ushort AttackBaseStamina
    {
        get => _attackBaseStamina;
        set => WriteParamField(ref _attackBaseStamina, value);
    }
    private ushort _attackBaseStamina;

    [ParamField(0xCE, ParamType.U16)]
    public ushort SaWeaponDamage
    {
        get => _saWeaponDamage;
        set => WriteParamField(ref _saWeaponDamage, value);
    }
    private ushort _saWeaponDamage;

    [ParamField(0xD0, ParamType.I16)]
    public short SaDurability
    {
        get => _saDurability;
        set => WriteParamField(ref _saDurability, value);
    }
    private short _saDurability;

    [ParamField(0xD2, ParamType.I16)]
    public short GuardAngle
    {
        get => _guardAngle;
        set => WriteParamField(ref _guardAngle, value);
    }
    private short _guardAngle;

    [ParamField(0xD4, ParamType.I16)]
    public short StaminaGuardDef
    {
        get => _staminaGuardDef;
        set => WriteParamField(ref _staminaGuardDef, value);
    }
    private short _staminaGuardDef;

    [ParamField(0xD6, ParamType.I16)]
    public short ReinforceTypeId
    {
        get => _reinforceTypeId;
        set => WriteParamField(ref _reinforceTypeId, value);
    }
    private short _reinforceTypeId;

    [ParamField(0xD8, ParamType.I16)]
    public short TrophySGradeId
    {
        get => _trophySGradeId;
        set => WriteParamField(ref _trophySGradeId, value);
    }
    private short _trophySGradeId;

    [ParamField(0xDA, ParamType.I16)]
    public short TrophySeqId
    {
        get => _trophySeqId;
        set => WriteParamField(ref _trophySeqId, value);
    }
    private short _trophySeqId;

    [ParamField(0xDC, ParamType.I16)]
    public short ThrowAtkRate
    {
        get => _throwAtkRate;
        set => WriteParamField(ref _throwAtkRate, value);
    }
    private short _throwAtkRate;

    [ParamField(0xDE, ParamType.I16)]
    public short BowDistRate
    {
        get => _bowDistRate;
        set => WriteParamField(ref _bowDistRate, value);
    }
    private short _bowDistRate;

    [ParamField(0xE0, ParamType.U8)]
    public byte EquipModelCategory
    {
        get => _equipModelCategory;
        set => WriteParamField(ref _equipModelCategory, value);
    }
    private byte _equipModelCategory;

    [ParamField(0xE1, ParamType.U8)]
    public byte EquipModelGender
    {
        get => _equipModelGender;
        set => WriteParamField(ref _equipModelGender, value);
    }
    private byte _equipModelGender;

    [ParamField(0xE2, ParamType.U8)]
    public byte WeaponCategory
    {
        get => _weaponCategory;
        set => WriteParamField(ref _weaponCategory, value);
    }
    private byte _weaponCategory;

    [ParamField(0xE3, ParamType.U8)]
    public byte WepmotionCategory
    {
        get => _wepmotionCategory;
        set => WriteParamField(ref _wepmotionCategory, value);
    }
    private byte _wepmotionCategory;

    [ParamField(0xE4, ParamType.U8)]
    public byte GuardmotionCategory
    {
        get => _guardmotionCategory;
        set => WriteParamField(ref _guardmotionCategory, value);
    }
    private byte _guardmotionCategory;

    [ParamField(0xE5, ParamType.U8)]
    public byte AtkMaterial
    {
        get => _atkMaterial;
        set => WriteParamField(ref _atkMaterial, value);
    }
    private byte _atkMaterial;

    [ParamField(0xE6, ParamType.U8)]
    public byte DefMaterial
    {
        get => _defMaterial;
        set => WriteParamField(ref _defMaterial, value);
    }
    private byte _defMaterial;

    [ParamField(0xE7, ParamType.U8)]
    public byte DefSfxMaterial
    {
        get => _defSfxMaterial;
        set => WriteParamField(ref _defSfxMaterial, value);
    }
    private byte _defSfxMaterial;

    [ParamField(0xE8, ParamType.U8)]
    public byte CorrectType
    {
        get => _correctType;
        set => WriteParamField(ref _correctType, value);
    }
    private byte _correctType;

    [ParamField(0xE9, ParamType.U8)]
    public byte SpAttribute
    {
        get => _spAttribute;
        set => WriteParamField(ref _spAttribute, value);
    }
    private byte _spAttribute;

    [ParamField(0xEA, ParamType.U8)]
    public byte SpAtkcategory
    {
        get => _spAtkcategory;
        set => WriteParamField(ref _spAtkcategory, value);
    }
    private byte _spAtkcategory;

    [ParamField(0xEB, ParamType.U8)]
    public byte WepmotionOneHandId
    {
        get => _wepmotionOneHandId;
        set => WriteParamField(ref _wepmotionOneHandId, value);
    }
    private byte _wepmotionOneHandId;

    [ParamField(0xEC, ParamType.U8)]
    public byte WepmotionBothHandId
    {
        get => _wepmotionBothHandId;
        set => WriteParamField(ref _wepmotionBothHandId, value);
    }
    private byte _wepmotionBothHandId;

    [ParamField(0xED, ParamType.U8)]
    public byte ProperStrength
    {
        get => _properStrength;
        set => WriteParamField(ref _properStrength, value);
    }
    private byte _properStrength;

    [ParamField(0xEE, ParamType.U8)]
    public byte ProperAgility
    {
        get => _properAgility;
        set => WriteParamField(ref _properAgility, value);
    }
    private byte _properAgility;

    [ParamField(0xEF, ParamType.U8)]
    public byte ProperMagic
    {
        get => _properMagic;
        set => WriteParamField(ref _properMagic, value);
    }
    private byte _properMagic;

    [ParamField(0xF0, ParamType.U8)]
    public byte ProperFaith
    {
        get => _properFaith;
        set => WriteParamField(ref _properFaith, value);
    }
    private byte _properFaith;

    [ParamField(0xF1, ParamType.U8)]
    public byte OverStrength
    {
        get => _overStrength;
        set => WriteParamField(ref _overStrength, value);
    }
    private byte _overStrength;

    [ParamField(0xF2, ParamType.U8)]
    public byte AttackBaseParry
    {
        get => _attackBaseParry;
        set => WriteParamField(ref _attackBaseParry, value);
    }
    private byte _attackBaseParry;

    [ParamField(0xF3, ParamType.U8)]
    public byte DefenseBaseParry
    {
        get => _defenseBaseParry;
        set => WriteParamField(ref _defenseBaseParry, value);
    }
    private byte _defenseBaseParry;

    [ParamField(0xF4, ParamType.U8)]
    public byte GuardBaseRepel
    {
        get => _guardBaseRepel;
        set => WriteParamField(ref _guardBaseRepel, value);
    }
    private byte _guardBaseRepel;

    [ParamField(0xF5, ParamType.U8)]
    public byte AttackBaseRepel
    {
        get => _attackBaseRepel;
        set => WriteParamField(ref _attackBaseRepel, value);
    }
    private byte _attackBaseRepel;

    [ParamField(0xF6, ParamType.I8)]
    public sbyte GuardCutCancelRate
    {
        get => _guardCutCancelRate;
        set => WriteParamField(ref _guardCutCancelRate, value);
    }
    private sbyte _guardCutCancelRate;

    [ParamField(0xF7, ParamType.I8)]
    public sbyte GuardLevel
    {
        get => _guardLevel;
        set => WriteParamField(ref _guardLevel, value);
    }
    private sbyte _guardLevel;

    [ParamField(0xF8, ParamType.I8)]
    public sbyte SlashGuardCutRate
    {
        get => _slashGuardCutRate;
        set => WriteParamField(ref _slashGuardCutRate, value);
    }
    private sbyte _slashGuardCutRate;

    [ParamField(0xF9, ParamType.I8)]
    public sbyte BlowGuardCutRate
    {
        get => _blowGuardCutRate;
        set => WriteParamField(ref _blowGuardCutRate, value);
    }
    private sbyte _blowGuardCutRate;

    [ParamField(0xFA, ParamType.I8)]
    public sbyte ThrustGuardCutRate
    {
        get => _thrustGuardCutRate;
        set => WriteParamField(ref _thrustGuardCutRate, value);
    }
    private sbyte _thrustGuardCutRate;

    [ParamField(0xFB, ParamType.I8)]
    public sbyte PoisonGuardResist
    {
        get => _poisonGuardResist;
        set => WriteParamField(ref _poisonGuardResist, value);
    }
    private sbyte _poisonGuardResist;

    [ParamField(0xFC, ParamType.I8)]
    public sbyte DiseaseGuardResist
    {
        get => _diseaseGuardResist;
        set => WriteParamField(ref _diseaseGuardResist, value);
    }
    private sbyte _diseaseGuardResist;

    [ParamField(0xFD, ParamType.I8)]
    public sbyte BloodGuardResist
    {
        get => _bloodGuardResist;
        set => WriteParamField(ref _bloodGuardResist, value);
    }
    private sbyte _bloodGuardResist;

    [ParamField(0xFE, ParamType.I8)]
    public sbyte CurseGuardResist
    {
        get => _curseGuardResist;
        set => WriteParamField(ref _curseGuardResist, value);
    }
    private sbyte _curseGuardResist;

    [ParamField(0xFF, ParamType.U8)]
    public byte IsDurabilityDivergence
    {
        get => _isDurabilityDivergence;
        set => WriteParamField(ref _isDurabilityDivergence, value);
    }
    private byte _isDurabilityDivergence;

    #region BitField RightHandEquipableBitfield ==============================================================================

    [ParamField(0x100, ParamType.U8)]
    public byte RightHandEquipableBitfield
    {
        get => _rightHandEquipableBitfield;
        set => WriteParamField(ref _rightHandEquipableBitfield, value);
    }
    private byte _rightHandEquipableBitfield;

    [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 0)]
    public byte RightHandEquipable
    {
        get => GetbitfieldValue(_rightHandEquipableBitfield);
        set => SetBitfieldValue(ref _rightHandEquipableBitfield, value);
    }

    [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 1)]
    public byte LeftHandEquipable
    {
        get => GetbitfieldValue(_rightHandEquipableBitfield);
        set => SetBitfieldValue(ref _rightHandEquipableBitfield, value);
    }

    [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 2)]
    public byte BothHandEquipable
    {
        get => GetbitfieldValue(_rightHandEquipableBitfield);
        set => SetBitfieldValue(ref _rightHandEquipableBitfield, value);
    }

    [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 3)]
    public byte ArrowSlotEquipable
    {
        get => GetbitfieldValue(_rightHandEquipableBitfield);
        set => SetBitfieldValue(ref _rightHandEquipableBitfield, value);
    }

    [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 4)]
    public byte BoltSlotEquipable
    {
        get => GetbitfieldValue(_rightHandEquipableBitfield);
        set => SetBitfieldValue(ref _rightHandEquipableBitfield, value);
    }

    [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 5)]
    public byte EnableGuard
    {
        get => GetbitfieldValue(_rightHandEquipableBitfield);
        set => SetBitfieldValue(ref _rightHandEquipableBitfield, value);
    }

    [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 6)]
    public byte EnableParry
    {
        get => GetbitfieldValue(_rightHandEquipableBitfield);
        set => SetBitfieldValue(ref _rightHandEquipableBitfield, value);
    }

    [ParamBitField(nameof(RightHandEquipableBitfield), bits: 1, bitsOffset: 7)]
    public byte EnableMagic
    {
        get => GetbitfieldValue(_rightHandEquipableBitfield);
        set => SetBitfieldValue(ref _rightHandEquipableBitfield, value);
    }

    #endregion BitField RightHandEquipableBitfield

    #region BitField EnableSorceryBitfield ==============================================================================

    [ParamField(0x101, ParamType.U8)]
    public byte EnableSorceryBitfield
    {
        get => _enableSorceryBitfield;
        set => WriteParamField(ref _enableSorceryBitfield, value);
    }
    private byte _enableSorceryBitfield;

    [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 0)]
    public byte EnableSorcery
    {
        get => GetbitfieldValue(_enableSorceryBitfield);
        set => SetBitfieldValue(ref _enableSorceryBitfield, value);
    }

    [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 1)]
    public byte EnableMiracle
    {
        get => GetbitfieldValue(_enableSorceryBitfield);
        set => SetBitfieldValue(ref _enableSorceryBitfield, value);
    }

    [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 2)]
    public byte EnableVowMagic
    {
        get => GetbitfieldValue(_enableSorceryBitfield);
        set => SetBitfieldValue(ref _enableSorceryBitfield, value);
    }

    [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 3)]
    public byte IsNormalAttackType
    {
        get => GetbitfieldValue(_enableSorceryBitfield);
        set => SetBitfieldValue(ref _enableSorceryBitfield, value);
    }

    [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 4)]
    public byte IsBlowAttackType
    {
        get => GetbitfieldValue(_enableSorceryBitfield);
        set => SetBitfieldValue(ref _enableSorceryBitfield, value);
    }

    [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 5)]
    public byte IsSlashAttackType
    {
        get => GetbitfieldValue(_enableSorceryBitfield);
        set => SetBitfieldValue(ref _enableSorceryBitfield, value);
    }

    [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 6)]
    public byte IsThrustAttackType
    {
        get => GetbitfieldValue(_enableSorceryBitfield);
        set => SetBitfieldValue(ref _enableSorceryBitfield, value);
    }

    [ParamBitField(nameof(EnableSorceryBitfield), bits: 1, bitsOffset: 7)]
    public byte IsEnhance
    {
        get => GetbitfieldValue(_enableSorceryBitfield);
        set => SetBitfieldValue(ref _enableSorceryBitfield, value);
    }

    #endregion BitField EnableSorceryBitfield

    #region BitField IsLuckCorrectBitfield ==============================================================================

    [ParamField(0x102, ParamType.U8)]
    public byte IsLuckCorrectBitfield
    {
        get => _isLuckCorrectBitfield;
        set => WriteParamField(ref _isLuckCorrectBitfield, value);
    }
    private byte _isLuckCorrectBitfield;

    [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 0)]
    public byte IsLuckCorrect
    {
        get => GetbitfieldValue(_isLuckCorrectBitfield);
        set => SetBitfieldValue(ref _isLuckCorrectBitfield, value);
    }

    [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 1)]
    public byte IsCustom
    {
        get => GetbitfieldValue(_isLuckCorrectBitfield);
        set => SetBitfieldValue(ref _isLuckCorrectBitfield, value);
    }

    [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 2)]
    public byte DisableBaseChangeReset
    {
        get => GetbitfieldValue(_isLuckCorrectBitfield);
        set => SetBitfieldValue(ref _isLuckCorrectBitfield, value);
    }

    [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 3)]
    public byte DisableRepair
    {
        get => GetbitfieldValue(_isLuckCorrectBitfield);
        set => SetBitfieldValue(ref _isLuckCorrectBitfield, value);
    }

    [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 4)]
    public byte IsDarkHand
    {
        get => GetbitfieldValue(_isLuckCorrectBitfield);
        set => SetBitfieldValue(ref _isLuckCorrectBitfield, value);
    }

    [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 5)]
    public byte SimpleModelForDlc
    {
        get => GetbitfieldValue(_isLuckCorrectBitfield);
        set => SetBitfieldValue(ref _isLuckCorrectBitfield, value);
    }

    [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 6)]
    public byte LanternWep
    {
        get => GetbitfieldValue(_isLuckCorrectBitfield);
        set => SetBitfieldValue(ref _isLuckCorrectBitfield, value);
    }

    [ParamBitField(nameof(IsLuckCorrectBitfield), bits: 1, bitsOffset: 7)]
    public byte IsVersusGhostWep
    {
        get => GetbitfieldValue(_isLuckCorrectBitfield);
        set => SetBitfieldValue(ref _isLuckCorrectBitfield, value);
    }

    #endregion BitField IsLuckCorrectBitfield

    #region BitField BaseChangeCategoryBitfield ==============================================================================

    [ParamField(0x103, ParamType.U8)]
    public byte BaseChangeCategoryBitfield
    {
        get => _baseChangeCategoryBitfield;
        set => WriteParamField(ref _baseChangeCategoryBitfield, value);
    }
    private byte _baseChangeCategoryBitfield;

    [ParamBitField(nameof(BaseChangeCategoryBitfield), bits: 6, bitsOffset: 0)]
    public byte BaseChangeCategory
    {
        get => GetbitfieldValue(_baseChangeCategoryBitfield);
        set => SetBitfieldValue(ref _baseChangeCategoryBitfield, value);
    }

    [ParamBitField(nameof(BaseChangeCategoryBitfield), bits: 1, bitsOffset: 6)]
    public byte IsDragonSlayer
    {
        get => GetbitfieldValue(_baseChangeCategoryBitfield);
        set => SetBitfieldValue(ref _baseChangeCategoryBitfield, value);
    }

    [ParamBitField(nameof(BaseChangeCategoryBitfield), bits: 1, bitsOffset: 7)]
    public byte IsDeposit
    {
        get => GetbitfieldValue(_baseChangeCategoryBitfield);
        set => SetBitfieldValue(ref _baseChangeCategoryBitfield, value);
    }

    #endregion BitField BaseChangeCategoryBitfield

    [ParamField(0x105, ParamType.Dummy8, 1)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

    [ParamField(0x106, ParamType.I16)]
    public short OldSortId
    {
        get => _oldSortId;
        set => WriteParamField(ref _oldSortId, value);
    }
    private short _oldSortId;

    [ParamField(0x108, ParamType.I16)]
    public short LevelSyncCorrectId
    {
        get => _levelSyncCorrectId;
        set => WriteParamField(ref _levelSyncCorrectId, value);
    }
    private short _levelSyncCorrectId;

    [ParamField(0x10A, ParamType.Dummy8, 6)]
    public byte[] Pad1
    {
        get => _pad1;
        set => WriteParamField(ref _pad1, value);
    }
    private byte[] _pad1 = null!;

}
