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
public class SpEffect(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int IconId
    {
        get => _iconId;
        set => WriteParamField(ref _iconId, value);
    }
    private int _iconId;

    [ParamField(0x4, ParamType.F32)]
    public float ConditionHp
    {
        get => _conditionHp;
        set => WriteParamField(ref _conditionHp, value);
    }
    private float _conditionHp;

    [ParamField(0x8, ParamType.F32)]
    public float EffectEndurance
    {
        get => _effectEndurance;
        set => WriteParamField(ref _effectEndurance, value);
    }
    private float _effectEndurance;

    [ParamField(0xC, ParamType.F32)]
    public float MotionInterval
    {
        get => _motionInterval;
        set => WriteParamField(ref _motionInterval, value);
    }
    private float _motionInterval;

    [ParamField(0x10, ParamType.F32)]
    public float MaxHpRate
    {
        get => _maxHpRate;
        set => WriteParamField(ref _maxHpRate, value);
    }
    private float _maxHpRate;

    [ParamField(0x14, ParamType.F32)]
    public float MaxMpRate
    {
        get => _maxMpRate;
        set => WriteParamField(ref _maxMpRate, value);
    }
    private float _maxMpRate;

    [ParamField(0x18, ParamType.F32)]
    public float MaxStaminaRate
    {
        get => _maxStaminaRate;
        set => WriteParamField(ref _maxStaminaRate, value);
    }
    private float _maxStaminaRate;

    [ParamField(0x1C, ParamType.F32)]
    public float SlashDamageCutRate
    {
        get => _slashDamageCutRate;
        set => WriteParamField(ref _slashDamageCutRate, value);
    }
    private float _slashDamageCutRate;

    [ParamField(0x20, ParamType.F32)]
    public float BlowDamageCutRate
    {
        get => _blowDamageCutRate;
        set => WriteParamField(ref _blowDamageCutRate, value);
    }
    private float _blowDamageCutRate;

    [ParamField(0x24, ParamType.F32)]
    public float ThrustDamageCutRate
    {
        get => _thrustDamageCutRate;
        set => WriteParamField(ref _thrustDamageCutRate, value);
    }
    private float _thrustDamageCutRate;

    [ParamField(0x28, ParamType.F32)]
    public float NeutralDamageCutRate
    {
        get => _neutralDamageCutRate;
        set => WriteParamField(ref _neutralDamageCutRate, value);
    }
    private float _neutralDamageCutRate;

    [ParamField(0x2C, ParamType.F32)]
    public float MagicDamageCutRate
    {
        get => _magicDamageCutRate;
        set => WriteParamField(ref _magicDamageCutRate, value);
    }
    private float _magicDamageCutRate;

    [ParamField(0x30, ParamType.F32)]
    public float FireDamageCutRate
    {
        get => _fireDamageCutRate;
        set => WriteParamField(ref _fireDamageCutRate, value);
    }
    private float _fireDamageCutRate;

    [ParamField(0x34, ParamType.F32)]
    public float ThunderDamageCutRate
    {
        get => _thunderDamageCutRate;
        set => WriteParamField(ref _thunderDamageCutRate, value);
    }
    private float _thunderDamageCutRate;

    [ParamField(0x38, ParamType.F32)]
    public float PhysicsAttackRate
    {
        get => _physicsAttackRate;
        set => WriteParamField(ref _physicsAttackRate, value);
    }
    private float _physicsAttackRate;

    [ParamField(0x3C, ParamType.F32)]
    public float MagicAttackRate
    {
        get => _magicAttackRate;
        set => WriteParamField(ref _magicAttackRate, value);
    }
    private float _magicAttackRate;

    [ParamField(0x40, ParamType.F32)]
    public float FireAttackRate
    {
        get => _fireAttackRate;
        set => WriteParamField(ref _fireAttackRate, value);
    }
    private float _fireAttackRate;

    [ParamField(0x44, ParamType.F32)]
    public float ThunderAttackRate
    {
        get => _thunderAttackRate;
        set => WriteParamField(ref _thunderAttackRate, value);
    }
    private float _thunderAttackRate;

    [ParamField(0x48, ParamType.F32)]
    public float PhysicsAttackPowerRate
    {
        get => _physicsAttackPowerRate;
        set => WriteParamField(ref _physicsAttackPowerRate, value);
    }
    private float _physicsAttackPowerRate;

    [ParamField(0x4C, ParamType.F32)]
    public float MagicAttackPowerRate
    {
        get => _magicAttackPowerRate;
        set => WriteParamField(ref _magicAttackPowerRate, value);
    }
    private float _magicAttackPowerRate;

    [ParamField(0x50, ParamType.F32)]
    public float FireAttackPowerRate
    {
        get => _fireAttackPowerRate;
        set => WriteParamField(ref _fireAttackPowerRate, value);
    }
    private float _fireAttackPowerRate;

    [ParamField(0x54, ParamType.F32)]
    public float ThunderAttackPowerRate
    {
        get => _thunderAttackPowerRate;
        set => WriteParamField(ref _thunderAttackPowerRate, value);
    }
    private float _thunderAttackPowerRate;

    [ParamField(0x58, ParamType.I32)]
    public int PhysicsAttackPower
    {
        get => _physicsAttackPower;
        set => WriteParamField(ref _physicsAttackPower, value);
    }
    private int _physicsAttackPower;

    [ParamField(0x5C, ParamType.I32)]
    public int MagicAttackPower
    {
        get => _magicAttackPower;
        set => WriteParamField(ref _magicAttackPower, value);
    }
    private int _magicAttackPower;

    [ParamField(0x60, ParamType.I32)]
    public int FireAttackPower
    {
        get => _fireAttackPower;
        set => WriteParamField(ref _fireAttackPower, value);
    }
    private int _fireAttackPower;

    [ParamField(0x64, ParamType.I32)]
    public int ThunderAttackPower
    {
        get => _thunderAttackPower;
        set => WriteParamField(ref _thunderAttackPower, value);
    }
    private int _thunderAttackPower;

    [ParamField(0x68, ParamType.F32)]
    public float PhysicsDiffenceRate
    {
        get => _physicsDiffenceRate;
        set => WriteParamField(ref _physicsDiffenceRate, value);
    }
    private float _physicsDiffenceRate;

    [ParamField(0x6C, ParamType.F32)]
    public float MagicDiffenceRate
    {
        get => _magicDiffenceRate;
        set => WriteParamField(ref _magicDiffenceRate, value);
    }
    private float _magicDiffenceRate;

    [ParamField(0x70, ParamType.F32)]
    public float FireDiffenceRate
    {
        get => _fireDiffenceRate;
        set => WriteParamField(ref _fireDiffenceRate, value);
    }
    private float _fireDiffenceRate;

    [ParamField(0x74, ParamType.F32)]
    public float ThunderDiffenceRate
    {
        get => _thunderDiffenceRate;
        set => WriteParamField(ref _thunderDiffenceRate, value);
    }
    private float _thunderDiffenceRate;

    [ParamField(0x78, ParamType.I32)]
    public int PhysicsDiffence
    {
        get => _physicsDiffence;
        set => WriteParamField(ref _physicsDiffence, value);
    }
    private int _physicsDiffence;

    [ParamField(0x7C, ParamType.I32)]
    public int MagicDiffence
    {
        get => _magicDiffence;
        set => WriteParamField(ref _magicDiffence, value);
    }
    private int _magicDiffence;

    [ParamField(0x80, ParamType.I32)]
    public int FireDiffence
    {
        get => _fireDiffence;
        set => WriteParamField(ref _fireDiffence, value);
    }
    private int _fireDiffence;

    [ParamField(0x84, ParamType.I32)]
    public int ThunderDiffence
    {
        get => _thunderDiffence;
        set => WriteParamField(ref _thunderDiffence, value);
    }
    private int _thunderDiffence;

    [ParamField(0x88, ParamType.F32)]
    public float NoGuardDamageRate
    {
        get => _noGuardDamageRate;
        set => WriteParamField(ref _noGuardDamageRate, value);
    }
    private float _noGuardDamageRate;

    [ParamField(0x8C, ParamType.F32)]
    public float VitalSpotChangeRate
    {
        get => _vitalSpotChangeRate;
        set => WriteParamField(ref _vitalSpotChangeRate, value);
    }
    private float _vitalSpotChangeRate;

    [ParamField(0x90, ParamType.F32)]
    public float NormalSpotChangeRate
    {
        get => _normalSpotChangeRate;
        set => WriteParamField(ref _normalSpotChangeRate, value);
    }
    private float _normalSpotChangeRate;

    [ParamField(0x94, ParamType.F32)]
    public float MaxHpChangeRate
    {
        get => _maxHpChangeRate;
        set => WriteParamField(ref _maxHpChangeRate, value);
    }
    private float _maxHpChangeRate;

    [ParamField(0x98, ParamType.I32)]
    public int BehaviorId
    {
        get => _behaviorId;
        set => WriteParamField(ref _behaviorId, value);
    }
    private int _behaviorId;

    [ParamField(0x9C, ParamType.F32)]
    public float ChangeHpRate
    {
        get => _changeHpRate;
        set => WriteParamField(ref _changeHpRate, value);
    }
    private float _changeHpRate;

    [ParamField(0xA0, ParamType.I32)]
    public int ChangeHpPoint
    {
        get => _changeHpPoint;
        set => WriteParamField(ref _changeHpPoint, value);
    }
    private int _changeHpPoint;

    [ParamField(0xA4, ParamType.F32)]
    public float ChangeMpRate
    {
        get => _changeMpRate;
        set => WriteParamField(ref _changeMpRate, value);
    }
    private float _changeMpRate;

    [ParamField(0xA8, ParamType.I32)]
    public int ChangeMpPoint
    {
        get => _changeMpPoint;
        set => WriteParamField(ref _changeMpPoint, value);
    }
    private int _changeMpPoint;

    [ParamField(0xAC, ParamType.I32)]
    public int MpRecoverChangeSpeed
    {
        get => _mpRecoverChangeSpeed;
        set => WriteParamField(ref _mpRecoverChangeSpeed, value);
    }
    private int _mpRecoverChangeSpeed;

    [ParamField(0xB0, ParamType.F32)]
    public float ChangeStaminaRate
    {
        get => _changeStaminaRate;
        set => WriteParamField(ref _changeStaminaRate, value);
    }
    private float _changeStaminaRate;

    [ParamField(0xB4, ParamType.I32)]
    public int ChangeStaminaPoint
    {
        get => _changeStaminaPoint;
        set => WriteParamField(ref _changeStaminaPoint, value);
    }
    private int _changeStaminaPoint;

    [ParamField(0xB8, ParamType.I32)]
    public int StaminaRecoverChangeSpeed
    {
        get => _staminaRecoverChangeSpeed;
        set => WriteParamField(ref _staminaRecoverChangeSpeed, value);
    }
    private int _staminaRecoverChangeSpeed;

    [ParamField(0xBC, ParamType.F32)]
    public float MagicEffectTimeChange
    {
        get => _magicEffectTimeChange;
        set => WriteParamField(ref _magicEffectTimeChange, value);
    }
    private float _magicEffectTimeChange;

    [ParamField(0xC0, ParamType.I32)]
    public int InsideDurability
    {
        get => _insideDurability;
        set => WriteParamField(ref _insideDurability, value);
    }
    private int _insideDurability;

    [ParamField(0xC4, ParamType.I32)]
    public int MaxDurability
    {
        get => _maxDurability;
        set => WriteParamField(ref _maxDurability, value);
    }
    private int _maxDurability;

    [ParamField(0xC8, ParamType.F32)]
    public float StaminaAttackRate
    {
        get => _staminaAttackRate;
        set => WriteParamField(ref _staminaAttackRate, value);
    }
    private float _staminaAttackRate;

    [ParamField(0xCC, ParamType.I32)]
    public int PoizonAttackPower
    {
        get => _poizonAttackPower;
        set => WriteParamField(ref _poizonAttackPower, value);
    }
    private int _poizonAttackPower;

    [ParamField(0xD0, ParamType.I32)]
    public int RegistIllness
    {
        get => _registIllness;
        set => WriteParamField(ref _registIllness, value);
    }
    private int _registIllness;

    [ParamField(0xD4, ParamType.I32)]
    public int RegistBlood
    {
        get => _registBlood;
        set => WriteParamField(ref _registBlood, value);
    }
    private int _registBlood;

    [ParamField(0xD8, ParamType.I32)]
    public int RegistCurse
    {
        get => _registCurse;
        set => WriteParamField(ref _registCurse, value);
    }
    private int _registCurse;

    [ParamField(0xDC, ParamType.F32)]
    public float FallDamageRate
    {
        get => _fallDamageRate;
        set => WriteParamField(ref _fallDamageRate, value);
    }
    private float _fallDamageRate;

    [ParamField(0xE0, ParamType.F32)]
    public float SoulRate
    {
        get => _soulRate;
        set => WriteParamField(ref _soulRate, value);
    }
    private float _soulRate;

    [ParamField(0xE4, ParamType.F32)]
    public float EquipWeightChangeRate
    {
        get => _equipWeightChangeRate;
        set => WriteParamField(ref _equipWeightChangeRate, value);
    }
    private float _equipWeightChangeRate;

    [ParamField(0xE8, ParamType.F32)]
    public float AllItemWeightChangeRate
    {
        get => _allItemWeightChangeRate;
        set => WriteParamField(ref _allItemWeightChangeRate, value);
    }
    private float _allItemWeightChangeRate;

    [ParamField(0xEC, ParamType.I32)]
    public int Soul
    {
        get => _soul;
        set => WriteParamField(ref _soul, value);
    }
    private int _soul;

    [ParamField(0xF0, ParamType.I32)]
    public int AnimIdOffset
    {
        get => _animIdOffset;
        set => WriteParamField(ref _animIdOffset, value);
    }
    private int _animIdOffset;

    [ParamField(0xF4, ParamType.F32)]
    public float HaveSoulRate
    {
        get => _haveSoulRate;
        set => WriteParamField(ref _haveSoulRate, value);
    }
    private float _haveSoulRate;

    [ParamField(0xF8, ParamType.F32)]
    public float TargetPriority
    {
        get => _targetPriority;
        set => WriteParamField(ref _targetPriority, value);
    }
    private float _targetPriority;

    [ParamField(0xFC, ParamType.I32)]
    public int SightSearchEnemyCut
    {
        get => _sightSearchEnemyCut;
        set => WriteParamField(ref _sightSearchEnemyCut, value);
    }
    private int _sightSearchEnemyCut;

    [ParamField(0x100, ParamType.I32)]
    public int HearingSearchEnemyCut
    {
        get => _hearingSearchEnemyCut;
        set => WriteParamField(ref _hearingSearchEnemyCut, value);
    }
    private int _hearingSearchEnemyCut;

    [ParamField(0x104, ParamType.F32)]
    public float GrabityRate
    {
        get => _grabityRate;
        set => WriteParamField(ref _grabityRate, value);
    }
    private float _grabityRate;

    [ParamField(0x108, ParamType.F32)]
    public float RegistPoizonChangeRate
    {
        get => _registPoizonChangeRate;
        set => WriteParamField(ref _registPoizonChangeRate, value);
    }
    private float _registPoizonChangeRate;

    [ParamField(0x10C, ParamType.F32)]
    public float RegistIllnessChangeRate
    {
        get => _registIllnessChangeRate;
        set => WriteParamField(ref _registIllnessChangeRate, value);
    }
    private float _registIllnessChangeRate;

    [ParamField(0x110, ParamType.F32)]
    public float RegistBloodChangeRate
    {
        get => _registBloodChangeRate;
        set => WriteParamField(ref _registBloodChangeRate, value);
    }
    private float _registBloodChangeRate;

    [ParamField(0x114, ParamType.F32)]
    public float RegistCurseChangeRate
    {
        get => _registCurseChangeRate;
        set => WriteParamField(ref _registCurseChangeRate, value);
    }
    private float _registCurseChangeRate;

    [ParamField(0x118, ParamType.F32)]
    public float SoulStealRate
    {
        get => _soulStealRate;
        set => WriteParamField(ref _soulStealRate, value);
    }
    private float _soulStealRate;

    [ParamField(0x11C, ParamType.F32)]
    public float LifeReductionRate
    {
        get => _lifeReductionRate;
        set => WriteParamField(ref _lifeReductionRate, value);
    }
    private float _lifeReductionRate;

    [ParamField(0x120, ParamType.F32)]
    public float HpRecoverRate
    {
        get => _hpRecoverRate;
        set => WriteParamField(ref _hpRecoverRate, value);
    }
    private float _hpRecoverRate;

    [ParamField(0x124, ParamType.I32)]
    public int ReplaceSpEffectId
    {
        get => _replaceSpEffectId;
        set => WriteParamField(ref _replaceSpEffectId, value);
    }
    private int _replaceSpEffectId;

    [ParamField(0x128, ParamType.I32)]
    public int CycleOccurrenceSpEffectId
    {
        get => _cycleOccurrenceSpEffectId;
        set => WriteParamField(ref _cycleOccurrenceSpEffectId, value);
    }
    private int _cycleOccurrenceSpEffectId;

    [ParamField(0x12C, ParamType.I32)]
    public int AtkOccurrenceSpEffectId
    {
        get => _atkOccurrenceSpEffectId;
        set => WriteParamField(ref _atkOccurrenceSpEffectId, value);
    }
    private int _atkOccurrenceSpEffectId;

    [ParamField(0x130, ParamType.F32)]
    public float GuardDefFlickPowerRate
    {
        get => _guardDefFlickPowerRate;
        set => WriteParamField(ref _guardDefFlickPowerRate, value);
    }
    private float _guardDefFlickPowerRate;

    [ParamField(0x134, ParamType.F32)]
    public float GuardStaminaCutRate
    {
        get => _guardStaminaCutRate;
        set => WriteParamField(ref _guardStaminaCutRate, value);
    }
    private float _guardStaminaCutRate;

    [ParamField(0x138, ParamType.I16)]
    public short RayCastPassedTime
    {
        get => _rayCastPassedTime;
        set => WriteParamField(ref _rayCastPassedTime, value);
    }
    private short _rayCastPassedTime;

    [ParamField(0x13A, ParamType.I16)]
    public short ChangeSuperArmorPoint
    {
        get => _changeSuperArmorPoint;
        set => WriteParamField(ref _changeSuperArmorPoint, value);
    }
    private short _changeSuperArmorPoint;

    [ParamField(0x13C, ParamType.I16)]
    public short BowDistRate
    {
        get => _bowDistRate;
        set => WriteParamField(ref _bowDistRate, value);
    }
    private short _bowDistRate;

    [ParamField(0x13E, ParamType.U16)]
    public ushort SpCategory
    {
        get => _spCategory;
        set => WriteParamField(ref _spCategory, value);
    }
    private ushort _spCategory;

    [ParamField(0x140, ParamType.U8)]
    public byte CategoryPriority
    {
        get => _categoryPriority;
        set => WriteParamField(ref _categoryPriority, value);
    }
    private byte _categoryPriority;

    [ParamField(0x141, ParamType.I8)]
    public sbyte SaveCategory
    {
        get => _saveCategory;
        set => WriteParamField(ref _saveCategory, value);
    }
    private sbyte _saveCategory;

    [ParamField(0x142, ParamType.U8)]
    public byte ChangeMagicSlot
    {
        get => _changeMagicSlot;
        set => WriteParamField(ref _changeMagicSlot, value);
    }
    private byte _changeMagicSlot;

    [ParamField(0x143, ParamType.U8)]
    public byte ChangeMiracleSlot
    {
        get => _changeMiracleSlot;
        set => WriteParamField(ref _changeMiracleSlot, value);
    }
    private byte _changeMiracleSlot;

    [ParamField(0x144, ParamType.I8)]
    public sbyte HeroPointDamage
    {
        get => _heroPointDamage;
        set => WriteParamField(ref _heroPointDamage, value);
    }
    private sbyte _heroPointDamage;

    [ParamField(0x145, ParamType.U8)]
    public byte DefFlickPower
    {
        get => _defFlickPower;
        set => WriteParamField(ref _defFlickPower, value);
    }
    private byte _defFlickPower;

    [ParamField(0x146, ParamType.U8)]
    public byte FlickDamageCutRate
    {
        get => _flickDamageCutRate;
        set => WriteParamField(ref _flickDamageCutRate, value);
    }
    private byte _flickDamageCutRate;

    [ParamField(0x147, ParamType.U8)]
    public byte BloodDamageRate
    {
        get => _bloodDamageRate;
        set => WriteParamField(ref _bloodDamageRate, value);
    }
    private byte _bloodDamageRate;

    [ParamField(0x148, ParamType.I8)]
    public sbyte DmgLvNone
    {
        get => _dmgLvNone;
        set => WriteParamField(ref _dmgLvNone, value);
    }
    private sbyte _dmgLvNone;

    [ParamField(0x149, ParamType.I8)]
    public sbyte DmgLvS
    {
        get => _dmgLvS;
        set => WriteParamField(ref _dmgLvS, value);
    }
    private sbyte _dmgLvS;

    [ParamField(0x14A, ParamType.I8)]
    public sbyte DmgLvM
    {
        get => _dmgLvM;
        set => WriteParamField(ref _dmgLvM, value);
    }
    private sbyte _dmgLvM;

    [ParamField(0x14B, ParamType.I8)]
    public sbyte DmgLvL
    {
        get => _dmgLvL;
        set => WriteParamField(ref _dmgLvL, value);
    }
    private sbyte _dmgLvL;

    [ParamField(0x14C, ParamType.I8)]
    public sbyte DmgLvBlowM
    {
        get => _dmgLvBlowM;
        set => WriteParamField(ref _dmgLvBlowM, value);
    }
    private sbyte _dmgLvBlowM;

    [ParamField(0x14D, ParamType.I8)]
    public sbyte DmgLvPush
    {
        get => _dmgLvPush;
        set => WriteParamField(ref _dmgLvPush, value);
    }
    private sbyte _dmgLvPush;

    [ParamField(0x14E, ParamType.I8)]
    public sbyte DmgLvStrike
    {
        get => _dmgLvStrike;
        set => WriteParamField(ref _dmgLvStrike, value);
    }
    private sbyte _dmgLvStrike;

    [ParamField(0x14F, ParamType.I8)]
    public sbyte DmgLvBlowS
    {
        get => _dmgLvBlowS;
        set => WriteParamField(ref _dmgLvBlowS, value);
    }
    private sbyte _dmgLvBlowS;

    [ParamField(0x150, ParamType.I8)]
    public sbyte DmgLvMin
    {
        get => _dmgLvMin;
        set => WriteParamField(ref _dmgLvMin, value);
    }
    private sbyte _dmgLvMin;

    [ParamField(0x151, ParamType.I8)]
    public sbyte DmgLvUppercut
    {
        get => _dmgLvUppercut;
        set => WriteParamField(ref _dmgLvUppercut, value);
    }
    private sbyte _dmgLvUppercut;

    [ParamField(0x152, ParamType.I8)]
    public sbyte DmgLvBlowLl
    {
        get => _dmgLvBlowLl;
        set => WriteParamField(ref _dmgLvBlowLl, value);
    }
    private sbyte _dmgLvBlowLl;

    [ParamField(0x153, ParamType.I8)]
    public sbyte DmgLvBreath
    {
        get => _dmgLvBreath;
        set => WriteParamField(ref _dmgLvBreath, value);
    }
    private sbyte _dmgLvBreath;

    [ParamField(0x154, ParamType.U8)]
    public byte AtkAttribute
    {
        get => _atkAttribute;
        set => WriteParamField(ref _atkAttribute, value);
    }
    private byte _atkAttribute;

    [ParamField(0x155, ParamType.U8)]
    public byte SpAttribute
    {
        get => _spAttribute;
        set => WriteParamField(ref _spAttribute, value);
    }
    private byte _spAttribute;

    [ParamField(0x156, ParamType.U8)]
    public byte StateInfo
    {
        get => _stateInfo;
        set => WriteParamField(ref _stateInfo, value);
    }
    private byte _stateInfo;

    [ParamField(0x157, ParamType.U8)]
    public byte WepParamChange
    {
        get => _wepParamChange;
        set => WriteParamField(ref _wepParamChange, value);
    }
    private byte _wepParamChange;

    [ParamField(0x158, ParamType.U8)]
    public byte MoveType
    {
        get => _moveType;
        set => WriteParamField(ref _moveType, value);
    }
    private byte _moveType;

    [ParamField(0x159, ParamType.U8)]
    public byte LifeReductionType
    {
        get => _lifeReductionType;
        set => WriteParamField(ref _lifeReductionType, value);
    }
    private byte _lifeReductionType;

    [ParamField(0x15A, ParamType.U8)]
    public byte ThrowCondition
    {
        get => _throwCondition;
        set => WriteParamField(ref _throwCondition, value);
    }
    private byte _throwCondition;

    [ParamField(0x15B, ParamType.I8)]
    public sbyte AddBehaviorJudgeIdCondition
    {
        get => _addBehaviorJudgeIdCondition;
        set => WriteParamField(ref _addBehaviorJudgeIdCondition, value);
    }
    private sbyte _addBehaviorJudgeIdCondition;

    [ParamField(0x15C, ParamType.U8)]
    public byte AddBehaviorJudgeIdAdd
    {
        get => _addBehaviorJudgeIdAdd;
        set => WriteParamField(ref _addBehaviorJudgeIdAdd, value);
    }
    private byte _addBehaviorJudgeIdAdd;

    #region BitField EffectTargetSelfBitfield ==============================================================================

    [ParamField(0x15D, ParamType.U8)]
    public byte EffectTargetSelfBitfield
    {
        get => _effectTargetSelfBitfield;
        set => WriteParamField(ref _effectTargetSelfBitfield, value);
    }
    private byte _effectTargetSelfBitfield;

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 0)]
    public byte EffectTargetSelf
    {
        get => GetbitfieldValue(_effectTargetSelfBitfield);
        set => SetBitfieldValue(ref _effectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 1)]
    public byte EffectTargetFriend
    {
        get => GetbitfieldValue(_effectTargetSelfBitfield);
        set => SetBitfieldValue(ref _effectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 2)]
    public byte EffectTargetEnemy
    {
        get => GetbitfieldValue(_effectTargetSelfBitfield);
        set => SetBitfieldValue(ref _effectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 3)]
    public byte EffectTargetPlayer
    {
        get => GetbitfieldValue(_effectTargetSelfBitfield);
        set => SetBitfieldValue(ref _effectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 4)]
    public byte EffectTargetAi
    {
        get => GetbitfieldValue(_effectTargetSelfBitfield);
        set => SetBitfieldValue(ref _effectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 5)]
    public byte EffectTargetLive
    {
        get => GetbitfieldValue(_effectTargetSelfBitfield);
        set => SetBitfieldValue(ref _effectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 6)]
    public byte EffectTargetGhost
    {
        get => GetbitfieldValue(_effectTargetSelfBitfield);
        set => SetBitfieldValue(ref _effectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 7)]
    public byte EffectTargetWhiteGhost
    {
        get => GetbitfieldValue(_effectTargetSelfBitfield);
        set => SetBitfieldValue(ref _effectTargetSelfBitfield, value);
    }

    #endregion BitField EffectTargetSelfBitfield

    #region BitField EffectTargetBlackGhostBitfield ==============================================================================

    [ParamField(0x15E, ParamType.U8)]
    public byte EffectTargetBlackGhostBitfield
    {
        get => _effectTargetBlackGhostBitfield;
        set => WriteParamField(ref _effectTargetBlackGhostBitfield, value);
    }
    private byte _effectTargetBlackGhostBitfield;

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 0)]
    public byte EffectTargetBlackGhost
    {
        get => GetbitfieldValue(_effectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _effectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 1)]
    public byte EffectTargetAttacker
    {
        get => GetbitfieldValue(_effectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _effectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 2)]
    public byte DispIconNonactive
    {
        get => GetbitfieldValue(_effectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _effectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 3)]
    public byte UseSpEffectEffect
    {
        get => GetbitfieldValue(_effectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _effectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 4)]
    public byte BAdjustMagicAblity
    {
        get => GetbitfieldValue(_effectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _effectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 5)]
    public byte BAdjustFaithAblity
    {
        get => GetbitfieldValue(_effectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _effectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 6)]
    public byte BGameClearBonus
    {
        get => GetbitfieldValue(_effectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _effectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 7)]
    public byte MagParamChange
    {
        get => GetbitfieldValue(_effectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _effectTargetBlackGhostBitfield, value);
    }

    #endregion BitField EffectTargetBlackGhostBitfield

    #region BitField MiracleParamChangeBitfield ==============================================================================

    [ParamField(0x15F, ParamType.U8)]
    public byte MiracleParamChangeBitfield
    {
        get => _miracleParamChangeBitfield;
        set => WriteParamField(ref _miracleParamChangeBitfield, value);
    }
    private byte _miracleParamChangeBitfield;

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 0)]
    public byte MiracleParamChange
    {
        get => GetbitfieldValue(_miracleParamChangeBitfield);
        set => SetBitfieldValue(ref _miracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 1)]
    public byte ClearSoul
    {
        get => GetbitfieldValue(_miracleParamChangeBitfield);
        set => SetBitfieldValue(ref _miracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 2)]
    public byte RequestSos
    {
        get => GetbitfieldValue(_miracleParamChangeBitfield);
        set => SetBitfieldValue(ref _miracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 3)]
    public byte RequestBlackSos
    {
        get => GetbitfieldValue(_miracleParamChangeBitfield);
        set => SetBitfieldValue(ref _miracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 4)]
    public byte RequestForceJoinBlackSos
    {
        get => GetbitfieldValue(_miracleParamChangeBitfield);
        set => SetBitfieldValue(ref _miracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 5)]
    public byte RequestKickSession
    {
        get => GetbitfieldValue(_miracleParamChangeBitfield);
        set => SetBitfieldValue(ref _miracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 6)]
    public byte RequestLeaveSession
    {
        get => GetbitfieldValue(_miracleParamChangeBitfield);
        set => SetBitfieldValue(ref _miracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 7)]
    public byte RequestNpcInveda
    {
        get => GetbitfieldValue(_miracleParamChangeBitfield);
        set => SetBitfieldValue(ref _miracleParamChangeBitfield, value);
    }

    #endregion BitField MiracleParamChangeBitfield

    #region BitField NoDeadBitfield ==============================================================================

    [ParamField(0x160, ParamType.U8)]
    public byte NoDeadBitfield
    {
        get => _noDeadBitfield;
        set => WriteParamField(ref _noDeadBitfield, value);
    }
    private byte _noDeadBitfield;

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 0)]
    public byte NoDead
    {
        get => GetbitfieldValue(_noDeadBitfield);
        set => SetBitfieldValue(ref _noDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 1)]
    public byte BCurrHpIndependeMaxHp
    {
        get => GetbitfieldValue(_noDeadBitfield);
        set => SetBitfieldValue(ref _noDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 2)]
    public byte CorrosionIgnore
    {
        get => GetbitfieldValue(_noDeadBitfield);
        set => SetBitfieldValue(ref _noDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 3)]
    public byte SightSearchCutIgnore
    {
        get => GetbitfieldValue(_noDeadBitfield);
        set => SetBitfieldValue(ref _noDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 4)]
    public byte HearingSearchCutIgnore
    {
        get => GetbitfieldValue(_noDeadBitfield);
        set => SetBitfieldValue(ref _noDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 5)]
    public byte AntiMagicIgnore
    {
        get => GetbitfieldValue(_noDeadBitfield);
        set => SetBitfieldValue(ref _noDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 6)]
    public byte FakeTargetIgnore
    {
        get => GetbitfieldValue(_noDeadBitfield);
        set => SetBitfieldValue(ref _noDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 7)]
    public byte FakeTargetIgnoreUndead
    {
        get => GetbitfieldValue(_noDeadBitfield);
        set => SetBitfieldValue(ref _noDeadBitfield, value);
    }

    #endregion BitField NoDeadBitfield

    #region BitField FakeTargetIgnoreAnimalBitfield ==============================================================================

    [ParamField(0x161, ParamType.U8)]
    public byte FakeTargetIgnoreAnimalBitfield
    {
        get => _fakeTargetIgnoreAnimalBitfield;
        set => WriteParamField(ref _fakeTargetIgnoreAnimalBitfield, value);
    }
    private byte _fakeTargetIgnoreAnimalBitfield;

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 0)]
    public byte FakeTargetIgnoreAnimal
    {
        get => GetbitfieldValue(_fakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _fakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 1)]
    public byte GrabityIgnore
    {
        get => GetbitfieldValue(_fakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _fakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 2)]
    public byte DisablePoison
    {
        get => GetbitfieldValue(_fakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _fakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 3)]
    public byte DisableDisease
    {
        get => GetbitfieldValue(_fakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _fakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 4)]
    public byte DisableBlood
    {
        get => GetbitfieldValue(_fakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _fakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 5)]
    public byte DisableCurse
    {
        get => GetbitfieldValue(_fakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _fakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 6)]
    public byte EnableCharm
    {
        get => GetbitfieldValue(_fakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _fakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 7)]
    public byte EnableLifeTime
    {
        get => GetbitfieldValue(_fakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _fakeTargetIgnoreAnimalBitfield, value);
    }

    #endregion BitField FakeTargetIgnoreAnimalBitfield

    #region BitField HasTargetBitfield ==============================================================================

    [ParamField(0x162, ParamType.U8)]
    public byte HasTargetBitfield
    {
        get => _hasTargetBitfield;
        set => WriteParamField(ref _hasTargetBitfield, value);
    }
    private byte _hasTargetBitfield;

    [ParamBitField(nameof(HasTargetBitfield), bits: 1, bitsOffset: 0)]
    public byte HasTarget
    {
        get => GetbitfieldValue(_hasTargetBitfield);
        set => SetBitfieldValue(ref _hasTargetBitfield, value);
    }

    [ParamBitField(nameof(HasTargetBitfield), bits: 1, bitsOffset: 1)]
    public byte IsFireDamageCancel
    {
        get => GetbitfieldValue(_hasTargetBitfield);
        set => SetBitfieldValue(ref _hasTargetBitfield, value);
    }

    [ParamBitField(nameof(HasTargetBitfield), bits: 1, bitsOffset: 2)]
    public byte IsExtendSpEffectLife
    {
        get => GetbitfieldValue(_hasTargetBitfield);
        set => SetBitfieldValue(ref _hasTargetBitfield, value);
    }

    [ParamBitField(nameof(HasTargetBitfield), bits: 1, bitsOffset: 3)]
    public byte RequestLeaveColiseumSession
    {
        get => GetbitfieldValue(_hasTargetBitfield);
        set => SetBitfieldValue(ref _hasTargetBitfield, value);
    }

    [ParamBitField(nameof(HasTargetBitfield), bits: 4, bitsOffset: 4)]
    public byte Pad2
    {
        get => GetbitfieldValue(_hasTargetBitfield);
        set => SetBitfieldValue(ref _hasTargetBitfield, value);
    }

    #endregion BitField HasTargetBitfield

    #region BitField VowType0Bitfield ==============================================================================

    [ParamField(0x163, ParamType.U8)]
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

    [ParamField(0x164, ParamType.U8)]
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

    [ParamField(0x165, ParamType.Dummy8, 11)]
    public byte[] Pad1
    {
        get => _pad1;
        set => WriteParamField(ref _pad1, value);
    }
    private byte[] _pad1 = null!;

}
