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
public class SpEffect : BaseParam
{
    public SpEffect(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

    [ParamField(0x0, ParamType.I32)]
    public int IconId
    {
        get => _IconId;
        set => WriteParamField(ref _IconId, value);
    }
    private int _IconId;

    [ParamField(0x4, ParamType.F32)]
    public float ConditionHp
    {
        get => _ConditionHp;
        set => WriteParamField(ref _ConditionHp, value);
    }
    private float _ConditionHp;

    [ParamField(0x8, ParamType.F32)]
    public float EffectEndurance
    {
        get => _EffectEndurance;
        set => WriteParamField(ref _EffectEndurance, value);
    }
    private float _EffectEndurance;

    [ParamField(0xC, ParamType.F32)]
    public float MotionInterval
    {
        get => _MotionInterval;
        set => WriteParamField(ref _MotionInterval, value);
    }
    private float _MotionInterval;

    [ParamField(0x10, ParamType.F32)]
    public float MaxHpRate
    {
        get => _MaxHpRate;
        set => WriteParamField(ref _MaxHpRate, value);
    }
    private float _MaxHpRate;

    [ParamField(0x14, ParamType.F32)]
    public float MaxMpRate
    {
        get => _MaxMpRate;
        set => WriteParamField(ref _MaxMpRate, value);
    }
    private float _MaxMpRate;

    [ParamField(0x18, ParamType.F32)]
    public float MaxStaminaRate
    {
        get => _MaxStaminaRate;
        set => WriteParamField(ref _MaxStaminaRate, value);
    }
    private float _MaxStaminaRate;

    [ParamField(0x1C, ParamType.F32)]
    public float SlashDamageCutRate
    {
        get => _SlashDamageCutRate;
        set => WriteParamField(ref _SlashDamageCutRate, value);
    }
    private float _SlashDamageCutRate;

    [ParamField(0x20, ParamType.F32)]
    public float BlowDamageCutRate
    {
        get => _BlowDamageCutRate;
        set => WriteParamField(ref _BlowDamageCutRate, value);
    }
    private float _BlowDamageCutRate;

    [ParamField(0x24, ParamType.F32)]
    public float ThrustDamageCutRate
    {
        get => _ThrustDamageCutRate;
        set => WriteParamField(ref _ThrustDamageCutRate, value);
    }
    private float _ThrustDamageCutRate;

    [ParamField(0x28, ParamType.F32)]
    public float NeutralDamageCutRate
    {
        get => _NeutralDamageCutRate;
        set => WriteParamField(ref _NeutralDamageCutRate, value);
    }
    private float _NeutralDamageCutRate;

    [ParamField(0x2C, ParamType.F32)]
    public float MagicDamageCutRate
    {
        get => _MagicDamageCutRate;
        set => WriteParamField(ref _MagicDamageCutRate, value);
    }
    private float _MagicDamageCutRate;

    [ParamField(0x30, ParamType.F32)]
    public float FireDamageCutRate
    {
        get => _FireDamageCutRate;
        set => WriteParamField(ref _FireDamageCutRate, value);
    }
    private float _FireDamageCutRate;

    [ParamField(0x34, ParamType.F32)]
    public float ThunderDamageCutRate
    {
        get => _ThunderDamageCutRate;
        set => WriteParamField(ref _ThunderDamageCutRate, value);
    }
    private float _ThunderDamageCutRate;

    [ParamField(0x38, ParamType.F32)]
    public float PhysicsAttackRate
    {
        get => _PhysicsAttackRate;
        set => WriteParamField(ref _PhysicsAttackRate, value);
    }
    private float _PhysicsAttackRate;

    [ParamField(0x3C, ParamType.F32)]
    public float MagicAttackRate
    {
        get => _MagicAttackRate;
        set => WriteParamField(ref _MagicAttackRate, value);
    }
    private float _MagicAttackRate;

    [ParamField(0x40, ParamType.F32)]
    public float FireAttackRate
    {
        get => _FireAttackRate;
        set => WriteParamField(ref _FireAttackRate, value);
    }
    private float _FireAttackRate;

    [ParamField(0x44, ParamType.F32)]
    public float ThunderAttackRate
    {
        get => _ThunderAttackRate;
        set => WriteParamField(ref _ThunderAttackRate, value);
    }
    private float _ThunderAttackRate;

    [ParamField(0x48, ParamType.F32)]
    public float PhysicsAttackPowerRate
    {
        get => _PhysicsAttackPowerRate;
        set => WriteParamField(ref _PhysicsAttackPowerRate, value);
    }
    private float _PhysicsAttackPowerRate;

    [ParamField(0x4C, ParamType.F32)]
    public float MagicAttackPowerRate
    {
        get => _MagicAttackPowerRate;
        set => WriteParamField(ref _MagicAttackPowerRate, value);
    }
    private float _MagicAttackPowerRate;

    [ParamField(0x50, ParamType.F32)]
    public float FireAttackPowerRate
    {
        get => _FireAttackPowerRate;
        set => WriteParamField(ref _FireAttackPowerRate, value);
    }
    private float _FireAttackPowerRate;

    [ParamField(0x54, ParamType.F32)]
    public float ThunderAttackPowerRate
    {
        get => _ThunderAttackPowerRate;
        set => WriteParamField(ref _ThunderAttackPowerRate, value);
    }
    private float _ThunderAttackPowerRate;

    [ParamField(0x58, ParamType.I32)]
    public int PhysicsAttackPower
    {
        get => _PhysicsAttackPower;
        set => WriteParamField(ref _PhysicsAttackPower, value);
    }
    private int _PhysicsAttackPower;

    [ParamField(0x5C, ParamType.I32)]
    public int MagicAttackPower
    {
        get => _MagicAttackPower;
        set => WriteParamField(ref _MagicAttackPower, value);
    }
    private int _MagicAttackPower;

    [ParamField(0x60, ParamType.I32)]
    public int FireAttackPower
    {
        get => _FireAttackPower;
        set => WriteParamField(ref _FireAttackPower, value);
    }
    private int _FireAttackPower;

    [ParamField(0x64, ParamType.I32)]
    public int ThunderAttackPower
    {
        get => _ThunderAttackPower;
        set => WriteParamField(ref _ThunderAttackPower, value);
    }
    private int _ThunderAttackPower;

    [ParamField(0x68, ParamType.F32)]
    public float PhysicsDiffenceRate
    {
        get => _PhysicsDiffenceRate;
        set => WriteParamField(ref _PhysicsDiffenceRate, value);
    }
    private float _PhysicsDiffenceRate;

    [ParamField(0x6C, ParamType.F32)]
    public float MagicDiffenceRate
    {
        get => _MagicDiffenceRate;
        set => WriteParamField(ref _MagicDiffenceRate, value);
    }
    private float _MagicDiffenceRate;

    [ParamField(0x70, ParamType.F32)]
    public float FireDiffenceRate
    {
        get => _FireDiffenceRate;
        set => WriteParamField(ref _FireDiffenceRate, value);
    }
    private float _FireDiffenceRate;

    [ParamField(0x74, ParamType.F32)]
    public float ThunderDiffenceRate
    {
        get => _ThunderDiffenceRate;
        set => WriteParamField(ref _ThunderDiffenceRate, value);
    }
    private float _ThunderDiffenceRate;

    [ParamField(0x78, ParamType.I32)]
    public int PhysicsDiffence
    {
        get => _PhysicsDiffence;
        set => WriteParamField(ref _PhysicsDiffence, value);
    }
    private int _PhysicsDiffence;

    [ParamField(0x7C, ParamType.I32)]
    public int MagicDiffence
    {
        get => _MagicDiffence;
        set => WriteParamField(ref _MagicDiffence, value);
    }
    private int _MagicDiffence;

    [ParamField(0x80, ParamType.I32)]
    public int FireDiffence
    {
        get => _FireDiffence;
        set => WriteParamField(ref _FireDiffence, value);
    }
    private int _FireDiffence;

    [ParamField(0x84, ParamType.I32)]
    public int ThunderDiffence
    {
        get => _ThunderDiffence;
        set => WriteParamField(ref _ThunderDiffence, value);
    }
    private int _ThunderDiffence;

    [ParamField(0x88, ParamType.F32)]
    public float NoGuardDamageRate
    {
        get => _NoGuardDamageRate;
        set => WriteParamField(ref _NoGuardDamageRate, value);
    }
    private float _NoGuardDamageRate;

    [ParamField(0x8C, ParamType.F32)]
    public float VitalSpotChangeRate
    {
        get => _VitalSpotChangeRate;
        set => WriteParamField(ref _VitalSpotChangeRate, value);
    }
    private float _VitalSpotChangeRate;

    [ParamField(0x90, ParamType.F32)]
    public float NormalSpotChangeRate
    {
        get => _NormalSpotChangeRate;
        set => WriteParamField(ref _NormalSpotChangeRate, value);
    }
    private float _NormalSpotChangeRate;

    [ParamField(0x94, ParamType.F32)]
    public float MaxHpChangeRate
    {
        get => _MaxHpChangeRate;
        set => WriteParamField(ref _MaxHpChangeRate, value);
    }
    private float _MaxHpChangeRate;

    [ParamField(0x98, ParamType.I32)]
    public int BehaviorId
    {
        get => _BehaviorId;
        set => WriteParamField(ref _BehaviorId, value);
    }
    private int _BehaviorId;

    [ParamField(0x9C, ParamType.F32)]
    public float ChangeHpRate
    {
        get => _ChangeHpRate;
        set => WriteParamField(ref _ChangeHpRate, value);
    }
    private float _ChangeHpRate;

    [ParamField(0xA0, ParamType.I32)]
    public int ChangeHpPoint
    {
        get => _ChangeHpPoint;
        set => WriteParamField(ref _ChangeHpPoint, value);
    }
    private int _ChangeHpPoint;

    [ParamField(0xA4, ParamType.F32)]
    public float ChangeMpRate
    {
        get => _ChangeMpRate;
        set => WriteParamField(ref _ChangeMpRate, value);
    }
    private float _ChangeMpRate;

    [ParamField(0xA8, ParamType.I32)]
    public int ChangeMpPoint
    {
        get => _ChangeMpPoint;
        set => WriteParamField(ref _ChangeMpPoint, value);
    }
    private int _ChangeMpPoint;

    [ParamField(0xAC, ParamType.I32)]
    public int MpRecoverChangeSpeed
    {
        get => _MpRecoverChangeSpeed;
        set => WriteParamField(ref _MpRecoverChangeSpeed, value);
    }
    private int _MpRecoverChangeSpeed;

    [ParamField(0xB0, ParamType.F32)]
    public float ChangeStaminaRate
    {
        get => _ChangeStaminaRate;
        set => WriteParamField(ref _ChangeStaminaRate, value);
    }
    private float _ChangeStaminaRate;

    [ParamField(0xB4, ParamType.I32)]
    public int ChangeStaminaPoint
    {
        get => _ChangeStaminaPoint;
        set => WriteParamField(ref _ChangeStaminaPoint, value);
    }
    private int _ChangeStaminaPoint;

    [ParamField(0xB8, ParamType.I32)]
    public int StaminaRecoverChangeSpeed
    {
        get => _StaminaRecoverChangeSpeed;
        set => WriteParamField(ref _StaminaRecoverChangeSpeed, value);
    }
    private int _StaminaRecoverChangeSpeed;

    [ParamField(0xBC, ParamType.F32)]
    public float MagicEffectTimeChange
    {
        get => _MagicEffectTimeChange;
        set => WriteParamField(ref _MagicEffectTimeChange, value);
    }
    private float _MagicEffectTimeChange;

    [ParamField(0xC0, ParamType.I32)]
    public int InsideDurability
    {
        get => _InsideDurability;
        set => WriteParamField(ref _InsideDurability, value);
    }
    private int _InsideDurability;

    [ParamField(0xC4, ParamType.I32)]
    public int MaxDurability
    {
        get => _MaxDurability;
        set => WriteParamField(ref _MaxDurability, value);
    }
    private int _MaxDurability;

    [ParamField(0xC8, ParamType.F32)]
    public float StaminaAttackRate
    {
        get => _StaminaAttackRate;
        set => WriteParamField(ref _StaminaAttackRate, value);
    }
    private float _StaminaAttackRate;

    [ParamField(0xCC, ParamType.I32)]
    public int PoizonAttackPower
    {
        get => _PoizonAttackPower;
        set => WriteParamField(ref _PoizonAttackPower, value);
    }
    private int _PoizonAttackPower;

    [ParamField(0xD0, ParamType.I32)]
    public int RegistIllness
    {
        get => _RegistIllness;
        set => WriteParamField(ref _RegistIllness, value);
    }
    private int _RegistIllness;

    [ParamField(0xD4, ParamType.I32)]
    public int RegistBlood
    {
        get => _RegistBlood;
        set => WriteParamField(ref _RegistBlood, value);
    }
    private int _RegistBlood;

    [ParamField(0xD8, ParamType.I32)]
    public int RegistCurse
    {
        get => _RegistCurse;
        set => WriteParamField(ref _RegistCurse, value);
    }
    private int _RegistCurse;

    [ParamField(0xDC, ParamType.F32)]
    public float FallDamageRate
    {
        get => _FallDamageRate;
        set => WriteParamField(ref _FallDamageRate, value);
    }
    private float _FallDamageRate;

    [ParamField(0xE0, ParamType.F32)]
    public float SoulRate
    {
        get => _SoulRate;
        set => WriteParamField(ref _SoulRate, value);
    }
    private float _SoulRate;

    [ParamField(0xE4, ParamType.F32)]
    public float EquipWeightChangeRate
    {
        get => _EquipWeightChangeRate;
        set => WriteParamField(ref _EquipWeightChangeRate, value);
    }
    private float _EquipWeightChangeRate;

    [ParamField(0xE8, ParamType.F32)]
    public float AllItemWeightChangeRate
    {
        get => _AllItemWeightChangeRate;
        set => WriteParamField(ref _AllItemWeightChangeRate, value);
    }
    private float _AllItemWeightChangeRate;

    [ParamField(0xEC, ParamType.I32)]
    public int Soul
    {
        get => _Soul;
        set => WriteParamField(ref _Soul, value);
    }
    private int _Soul;

    [ParamField(0xF0, ParamType.I32)]
    public int AnimIdOffset
    {
        get => _AnimIdOffset;
        set => WriteParamField(ref _AnimIdOffset, value);
    }
    private int _AnimIdOffset;

    [ParamField(0xF4, ParamType.F32)]
    public float HaveSoulRate
    {
        get => _HaveSoulRate;
        set => WriteParamField(ref _HaveSoulRate, value);
    }
    private float _HaveSoulRate;

    [ParamField(0xF8, ParamType.F32)]
    public float TargetPriority
    {
        get => _TargetPriority;
        set => WriteParamField(ref _TargetPriority, value);
    }
    private float _TargetPriority;

    [ParamField(0xFC, ParamType.I32)]
    public int SightSearchEnemyCut
    {
        get => _SightSearchEnemyCut;
        set => WriteParamField(ref _SightSearchEnemyCut, value);
    }
    private int _SightSearchEnemyCut;

    [ParamField(0x100, ParamType.I32)]
    public int HearingSearchEnemyCut
    {
        get => _HearingSearchEnemyCut;
        set => WriteParamField(ref _HearingSearchEnemyCut, value);
    }
    private int _HearingSearchEnemyCut;

    [ParamField(0x104, ParamType.F32)]
    public float GrabityRate
    {
        get => _GrabityRate;
        set => WriteParamField(ref _GrabityRate, value);
    }
    private float _GrabityRate;

    [ParamField(0x108, ParamType.F32)]
    public float RegistPoizonChangeRate
    {
        get => _RegistPoizonChangeRate;
        set => WriteParamField(ref _RegistPoizonChangeRate, value);
    }
    private float _RegistPoizonChangeRate;

    [ParamField(0x10C, ParamType.F32)]
    public float RegistIllnessChangeRate
    {
        get => _RegistIllnessChangeRate;
        set => WriteParamField(ref _RegistIllnessChangeRate, value);
    }
    private float _RegistIllnessChangeRate;

    [ParamField(0x110, ParamType.F32)]
    public float RegistBloodChangeRate
    {
        get => _RegistBloodChangeRate;
        set => WriteParamField(ref _RegistBloodChangeRate, value);
    }
    private float _RegistBloodChangeRate;

    [ParamField(0x114, ParamType.F32)]
    public float RegistCurseChangeRate
    {
        get => _RegistCurseChangeRate;
        set => WriteParamField(ref _RegistCurseChangeRate, value);
    }
    private float _RegistCurseChangeRate;

    [ParamField(0x118, ParamType.F32)]
    public float SoulStealRate
    {
        get => _SoulStealRate;
        set => WriteParamField(ref _SoulStealRate, value);
    }
    private float _SoulStealRate;

    [ParamField(0x11C, ParamType.F32)]
    public float LifeReductionRate
    {
        get => _LifeReductionRate;
        set => WriteParamField(ref _LifeReductionRate, value);
    }
    private float _LifeReductionRate;

    [ParamField(0x120, ParamType.F32)]
    public float HpRecoverRate
    {
        get => _HpRecoverRate;
        set => WriteParamField(ref _HpRecoverRate, value);
    }
    private float _HpRecoverRate;

    [ParamField(0x124, ParamType.I32)]
    public int ReplaceSpEffectId
    {
        get => _ReplaceSpEffectId;
        set => WriteParamField(ref _ReplaceSpEffectId, value);
    }
    private int _ReplaceSpEffectId;

    [ParamField(0x128, ParamType.I32)]
    public int CycleOccurrenceSpEffectId
    {
        get => _CycleOccurrenceSpEffectId;
        set => WriteParamField(ref _CycleOccurrenceSpEffectId, value);
    }
    private int _CycleOccurrenceSpEffectId;

    [ParamField(0x12C, ParamType.I32)]
    public int AtkOccurrenceSpEffectId
    {
        get => _AtkOccurrenceSpEffectId;
        set => WriteParamField(ref _AtkOccurrenceSpEffectId, value);
    }
    private int _AtkOccurrenceSpEffectId;

    [ParamField(0x130, ParamType.F32)]
    public float GuardDefFlickPowerRate
    {
        get => _GuardDefFlickPowerRate;
        set => WriteParamField(ref _GuardDefFlickPowerRate, value);
    }
    private float _GuardDefFlickPowerRate;

    [ParamField(0x134, ParamType.F32)]
    public float GuardStaminaCutRate
    {
        get => _GuardStaminaCutRate;
        set => WriteParamField(ref _GuardStaminaCutRate, value);
    }
    private float _GuardStaminaCutRate;

    [ParamField(0x138, ParamType.I16)]
    public short RayCastPassedTime
    {
        get => _RayCastPassedTime;
        set => WriteParamField(ref _RayCastPassedTime, value);
    }
    private short _RayCastPassedTime;

    [ParamField(0x13A, ParamType.I16)]
    public short ChangeSuperArmorPoint
    {
        get => _ChangeSuperArmorPoint;
        set => WriteParamField(ref _ChangeSuperArmorPoint, value);
    }
    private short _ChangeSuperArmorPoint;

    [ParamField(0x13C, ParamType.I16)]
    public short BowDistRate
    {
        get => _BowDistRate;
        set => WriteParamField(ref _BowDistRate, value);
    }
    private short _BowDistRate;

    [ParamField(0x13E, ParamType.U16)]
    public ushort SpCategory
    {
        get => _SpCategory;
        set => WriteParamField(ref _SpCategory, value);
    }
    private ushort _SpCategory;

    [ParamField(0x140, ParamType.U8)]
    public byte CategoryPriority
    {
        get => _CategoryPriority;
        set => WriteParamField(ref _CategoryPriority, value);
    }
    private byte _CategoryPriority;

    [ParamField(0x141, ParamType.I8)]
    public sbyte SaveCategory
    {
        get => _SaveCategory;
        set => WriteParamField(ref _SaveCategory, value);
    }
    private sbyte _SaveCategory;

    [ParamField(0x142, ParamType.U8)]
    public byte ChangeMagicSlot
    {
        get => _ChangeMagicSlot;
        set => WriteParamField(ref _ChangeMagicSlot, value);
    }
    private byte _ChangeMagicSlot;

    [ParamField(0x143, ParamType.U8)]
    public byte ChangeMiracleSlot
    {
        get => _ChangeMiracleSlot;
        set => WriteParamField(ref _ChangeMiracleSlot, value);
    }
    private byte _ChangeMiracleSlot;

    [ParamField(0x144, ParamType.I8)]
    public sbyte HeroPointDamage
    {
        get => _HeroPointDamage;
        set => WriteParamField(ref _HeroPointDamage, value);
    }
    private sbyte _HeroPointDamage;

    [ParamField(0x145, ParamType.U8)]
    public byte DefFlickPower
    {
        get => _DefFlickPower;
        set => WriteParamField(ref _DefFlickPower, value);
    }
    private byte _DefFlickPower;

    [ParamField(0x146, ParamType.U8)]
    public byte FlickDamageCutRate
    {
        get => _FlickDamageCutRate;
        set => WriteParamField(ref _FlickDamageCutRate, value);
    }
    private byte _FlickDamageCutRate;

    [ParamField(0x147, ParamType.U8)]
    public byte BloodDamageRate
    {
        get => _BloodDamageRate;
        set => WriteParamField(ref _BloodDamageRate, value);
    }
    private byte _BloodDamageRate;

    [ParamField(0x148, ParamType.I8)]
    public sbyte DmgLv_None
    {
        get => _DmgLv_None;
        set => WriteParamField(ref _DmgLv_None, value);
    }
    private sbyte _DmgLv_None;

    [ParamField(0x149, ParamType.I8)]
    public sbyte DmgLv_S
    {
        get => _DmgLv_S;
        set => WriteParamField(ref _DmgLv_S, value);
    }
    private sbyte _DmgLv_S;

    [ParamField(0x14A, ParamType.I8)]
    public sbyte DmgLv_M
    {
        get => _DmgLv_M;
        set => WriteParamField(ref _DmgLv_M, value);
    }
    private sbyte _DmgLv_M;

    [ParamField(0x14B, ParamType.I8)]
    public sbyte DmgLv_L
    {
        get => _DmgLv_L;
        set => WriteParamField(ref _DmgLv_L, value);
    }
    private sbyte _DmgLv_L;

    [ParamField(0x14C, ParamType.I8)]
    public sbyte DmgLv_BlowM
    {
        get => _DmgLv_BlowM;
        set => WriteParamField(ref _DmgLv_BlowM, value);
    }
    private sbyte _DmgLv_BlowM;

    [ParamField(0x14D, ParamType.I8)]
    public sbyte DmgLv_Push
    {
        get => _DmgLv_Push;
        set => WriteParamField(ref _DmgLv_Push, value);
    }
    private sbyte _DmgLv_Push;

    [ParamField(0x14E, ParamType.I8)]
    public sbyte DmgLv_Strike
    {
        get => _DmgLv_Strike;
        set => WriteParamField(ref _DmgLv_Strike, value);
    }
    private sbyte _DmgLv_Strike;

    [ParamField(0x14F, ParamType.I8)]
    public sbyte DmgLv_BlowS
    {
        get => _DmgLv_BlowS;
        set => WriteParamField(ref _DmgLv_BlowS, value);
    }
    private sbyte _DmgLv_BlowS;

    [ParamField(0x150, ParamType.I8)]
    public sbyte DmgLv_Min
    {
        get => _DmgLv_Min;
        set => WriteParamField(ref _DmgLv_Min, value);
    }
    private sbyte _DmgLv_Min;

    [ParamField(0x151, ParamType.I8)]
    public sbyte DmgLv_Uppercut
    {
        get => _DmgLv_Uppercut;
        set => WriteParamField(ref _DmgLv_Uppercut, value);
    }
    private sbyte _DmgLv_Uppercut;

    [ParamField(0x152, ParamType.I8)]
    public sbyte DmgLv_BlowLL
    {
        get => _DmgLv_BlowLL;
        set => WriteParamField(ref _DmgLv_BlowLL, value);
    }
    private sbyte _DmgLv_BlowLL;

    [ParamField(0x153, ParamType.I8)]
    public sbyte DmgLv_Breath
    {
        get => _DmgLv_Breath;
        set => WriteParamField(ref _DmgLv_Breath, value);
    }
    private sbyte _DmgLv_Breath;

    [ParamField(0x154, ParamType.U8)]
    public byte AtkAttribute
    {
        get => _AtkAttribute;
        set => WriteParamField(ref _AtkAttribute, value);
    }
    private byte _AtkAttribute;

    [ParamField(0x155, ParamType.U8)]
    public byte SpAttribute
    {
        get => _SpAttribute;
        set => WriteParamField(ref _SpAttribute, value);
    }
    private byte _SpAttribute;

    [ParamField(0x156, ParamType.U8)]
    public byte StateInfo
    {
        get => _StateInfo;
        set => WriteParamField(ref _StateInfo, value);
    }
    private byte _StateInfo;

    [ParamField(0x157, ParamType.U8)]
    public byte WepParamChange
    {
        get => _WepParamChange;
        set => WriteParamField(ref _WepParamChange, value);
    }
    private byte _WepParamChange;

    [ParamField(0x158, ParamType.U8)]
    public byte MoveType
    {
        get => _MoveType;
        set => WriteParamField(ref _MoveType, value);
    }
    private byte _MoveType;

    [ParamField(0x159, ParamType.U8)]
    public byte LifeReductionType
    {
        get => _LifeReductionType;
        set => WriteParamField(ref _LifeReductionType, value);
    }
    private byte _LifeReductionType;

    [ParamField(0x15A, ParamType.U8)]
    public byte ThrowCondition
    {
        get => _ThrowCondition;
        set => WriteParamField(ref _ThrowCondition, value);
    }
    private byte _ThrowCondition;

    [ParamField(0x15B, ParamType.I8)]
    public sbyte AddBehaviorJudgeId_condition
    {
        get => _AddBehaviorJudgeId_condition;
        set => WriteParamField(ref _AddBehaviorJudgeId_condition, value);
    }
    private sbyte _AddBehaviorJudgeId_condition;

    [ParamField(0x15C, ParamType.U8)]
    public byte AddBehaviorJudgeId_add
    {
        get => _AddBehaviorJudgeId_add;
        set => WriteParamField(ref _AddBehaviorJudgeId_add, value);
    }
    private byte _AddBehaviorJudgeId_add;

    #region BitField EffectTargetSelfBitfield ==============================================================================

    [ParamField(0x15D, ParamType.U8)]
    public byte EffectTargetSelfBitfield
    {
        get => _EffectTargetSelfBitfield;
        set => WriteParamField(ref _EffectTargetSelfBitfield, value);
    }
    private byte _EffectTargetSelfBitfield;

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 0)]
    public byte EffectTargetSelf
    {
        get => GetbitfieldValue(_EffectTargetSelfBitfield);
        set => SetBitfieldValue(ref _EffectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 1)]
    public byte EffectTargetFriend
    {
        get => GetbitfieldValue(_EffectTargetSelfBitfield);
        set => SetBitfieldValue(ref _EffectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 2)]
    public byte EffectTargetEnemy
    {
        get => GetbitfieldValue(_EffectTargetSelfBitfield);
        set => SetBitfieldValue(ref _EffectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 3)]
    public byte EffectTargetPlayer
    {
        get => GetbitfieldValue(_EffectTargetSelfBitfield);
        set => SetBitfieldValue(ref _EffectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 4)]
    public byte EffectTargetAI
    {
        get => GetbitfieldValue(_EffectTargetSelfBitfield);
        set => SetBitfieldValue(ref _EffectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 5)]
    public byte EffectTargetLive
    {
        get => GetbitfieldValue(_EffectTargetSelfBitfield);
        set => SetBitfieldValue(ref _EffectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 6)]
    public byte EffectTargetGhost
    {
        get => GetbitfieldValue(_EffectTargetSelfBitfield);
        set => SetBitfieldValue(ref _EffectTargetSelfBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetSelfBitfield), bits: 1, bitsOffset: 7)]
    public byte EffectTargetWhiteGhost
    {
        get => GetbitfieldValue(_EffectTargetSelfBitfield);
        set => SetBitfieldValue(ref _EffectTargetSelfBitfield, value);
    }

    #endregion BitField EffectTargetSelfBitfield

    #region BitField EffectTargetBlackGhostBitfield ==============================================================================

    [ParamField(0x15E, ParamType.U8)]
    public byte EffectTargetBlackGhostBitfield
    {
        get => _EffectTargetBlackGhostBitfield;
        set => WriteParamField(ref _EffectTargetBlackGhostBitfield, value);
    }
    private byte _EffectTargetBlackGhostBitfield;

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 0)]
    public byte EffectTargetBlackGhost
    {
        get => GetbitfieldValue(_EffectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _EffectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 1)]
    public byte EffectTargetAttacker
    {
        get => GetbitfieldValue(_EffectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _EffectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 2)]
    public byte DispIconNonactive
    {
        get => GetbitfieldValue(_EffectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _EffectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 3)]
    public byte UseSpEffectEffect
    {
        get => GetbitfieldValue(_EffectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _EffectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 4)]
    public byte BAdjustMagicAblity
    {
        get => GetbitfieldValue(_EffectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _EffectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 5)]
    public byte BAdjustFaithAblity
    {
        get => GetbitfieldValue(_EffectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _EffectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 6)]
    public byte BGameClearBonus
    {
        get => GetbitfieldValue(_EffectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _EffectTargetBlackGhostBitfield, value);
    }

    [ParamBitField(nameof(EffectTargetBlackGhostBitfield), bits: 1, bitsOffset: 7)]
    public byte MagParamChange
    {
        get => GetbitfieldValue(_EffectTargetBlackGhostBitfield);
        set => SetBitfieldValue(ref _EffectTargetBlackGhostBitfield, value);
    }

    #endregion BitField EffectTargetBlackGhostBitfield

    #region BitField MiracleParamChangeBitfield ==============================================================================

    [ParamField(0x15F, ParamType.U8)]
    public byte MiracleParamChangeBitfield
    {
        get => _MiracleParamChangeBitfield;
        set => WriteParamField(ref _MiracleParamChangeBitfield, value);
    }
    private byte _MiracleParamChangeBitfield;

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 0)]
    public byte MiracleParamChange
    {
        get => GetbitfieldValue(_MiracleParamChangeBitfield);
        set => SetBitfieldValue(ref _MiracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 1)]
    public byte ClearSoul
    {
        get => GetbitfieldValue(_MiracleParamChangeBitfield);
        set => SetBitfieldValue(ref _MiracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 2)]
    public byte RequestSOS
    {
        get => GetbitfieldValue(_MiracleParamChangeBitfield);
        set => SetBitfieldValue(ref _MiracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 3)]
    public byte RequestBlackSOS
    {
        get => GetbitfieldValue(_MiracleParamChangeBitfield);
        set => SetBitfieldValue(ref _MiracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 4)]
    public byte RequestForceJoinBlackSOS
    {
        get => GetbitfieldValue(_MiracleParamChangeBitfield);
        set => SetBitfieldValue(ref _MiracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 5)]
    public byte RequestKickSession
    {
        get => GetbitfieldValue(_MiracleParamChangeBitfield);
        set => SetBitfieldValue(ref _MiracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 6)]
    public byte RequestLeaveSession
    {
        get => GetbitfieldValue(_MiracleParamChangeBitfield);
        set => SetBitfieldValue(ref _MiracleParamChangeBitfield, value);
    }

    [ParamBitField(nameof(MiracleParamChangeBitfield), bits: 1, bitsOffset: 7)]
    public byte RequestNpcInveda
    {
        get => GetbitfieldValue(_MiracleParamChangeBitfield);
        set => SetBitfieldValue(ref _MiracleParamChangeBitfield, value);
    }

    #endregion BitField MiracleParamChangeBitfield

    #region BitField NoDeadBitfield ==============================================================================

    [ParamField(0x160, ParamType.U8)]
    public byte NoDeadBitfield
    {
        get => _NoDeadBitfield;
        set => WriteParamField(ref _NoDeadBitfield, value);
    }
    private byte _NoDeadBitfield;

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 0)]
    public byte NoDead
    {
        get => GetbitfieldValue(_NoDeadBitfield);
        set => SetBitfieldValue(ref _NoDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 1)]
    public byte BCurrHPIndependeMaxHP
    {
        get => GetbitfieldValue(_NoDeadBitfield);
        set => SetBitfieldValue(ref _NoDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 2)]
    public byte CorrosionIgnore
    {
        get => GetbitfieldValue(_NoDeadBitfield);
        set => SetBitfieldValue(ref _NoDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 3)]
    public byte SightSearchCutIgnore
    {
        get => GetbitfieldValue(_NoDeadBitfield);
        set => SetBitfieldValue(ref _NoDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 4)]
    public byte HearingSearchCutIgnore
    {
        get => GetbitfieldValue(_NoDeadBitfield);
        set => SetBitfieldValue(ref _NoDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 5)]
    public byte AntiMagicIgnore
    {
        get => GetbitfieldValue(_NoDeadBitfield);
        set => SetBitfieldValue(ref _NoDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 6)]
    public byte FakeTargetIgnore
    {
        get => GetbitfieldValue(_NoDeadBitfield);
        set => SetBitfieldValue(ref _NoDeadBitfield, value);
    }

    [ParamBitField(nameof(NoDeadBitfield), bits: 1, bitsOffset: 7)]
    public byte FakeTargetIgnoreUndead
    {
        get => GetbitfieldValue(_NoDeadBitfield);
        set => SetBitfieldValue(ref _NoDeadBitfield, value);
    }

    #endregion BitField NoDeadBitfield

    #region BitField FakeTargetIgnoreAnimalBitfield ==============================================================================

    [ParamField(0x161, ParamType.U8)]
    public byte FakeTargetIgnoreAnimalBitfield
    {
        get => _FakeTargetIgnoreAnimalBitfield;
        set => WriteParamField(ref _FakeTargetIgnoreAnimalBitfield, value);
    }
    private byte _FakeTargetIgnoreAnimalBitfield;

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 0)]
    public byte FakeTargetIgnoreAnimal
    {
        get => GetbitfieldValue(_FakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _FakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 1)]
    public byte GrabityIgnore
    {
        get => GetbitfieldValue(_FakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _FakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 2)]
    public byte DisablePoison
    {
        get => GetbitfieldValue(_FakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _FakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 3)]
    public byte DisableDisease
    {
        get => GetbitfieldValue(_FakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _FakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 4)]
    public byte DisableBlood
    {
        get => GetbitfieldValue(_FakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _FakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 5)]
    public byte DisableCurse
    {
        get => GetbitfieldValue(_FakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _FakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 6)]
    public byte EnableCharm
    {
        get => GetbitfieldValue(_FakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _FakeTargetIgnoreAnimalBitfield, value);
    }

    [ParamBitField(nameof(FakeTargetIgnoreAnimalBitfield), bits: 1, bitsOffset: 7)]
    public byte EnableLifeTime
    {
        get => GetbitfieldValue(_FakeTargetIgnoreAnimalBitfield);
        set => SetBitfieldValue(ref _FakeTargetIgnoreAnimalBitfield, value);
    }

    #endregion BitField FakeTargetIgnoreAnimalBitfield

    #region BitField HasTargetBitfield ==============================================================================

    [ParamField(0x162, ParamType.U8)]
    public byte HasTargetBitfield
    {
        get => _HasTargetBitfield;
        set => WriteParamField(ref _HasTargetBitfield, value);
    }
    private byte _HasTargetBitfield;

    [ParamBitField(nameof(HasTargetBitfield), bits: 1, bitsOffset: 0)]
    public byte HasTarget
    {
        get => GetbitfieldValue(_HasTargetBitfield);
        set => SetBitfieldValue(ref _HasTargetBitfield, value);
    }

    [ParamBitField(nameof(HasTargetBitfield), bits: 1, bitsOffset: 1)]
    public byte IsFireDamageCancel
    {
        get => GetbitfieldValue(_HasTargetBitfield);
        set => SetBitfieldValue(ref _HasTargetBitfield, value);
    }

    [ParamBitField(nameof(HasTargetBitfield), bits: 1, bitsOffset: 2)]
    public byte IsExtendSpEffectLife
    {
        get => GetbitfieldValue(_HasTargetBitfield);
        set => SetBitfieldValue(ref _HasTargetBitfield, value);
    }

    [ParamBitField(nameof(HasTargetBitfield), bits: 1, bitsOffset: 3)]
    public byte RequestLeaveColiseumSession
    {
        get => GetbitfieldValue(_HasTargetBitfield);
        set => SetBitfieldValue(ref _HasTargetBitfield, value);
    }

    [ParamBitField(nameof(HasTargetBitfield), bits: 4, bitsOffset: 4)]
    public byte Pad_2
    {
        get => GetbitfieldValue(_HasTargetBitfield);
        set => SetBitfieldValue(ref _HasTargetBitfield, value);
    }

    #endregion BitField HasTargetBitfield

    #region BitField VowType0Bitfield ==============================================================================

    [ParamField(0x163, ParamType.U8)]
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

    [ParamField(0x164, ParamType.U8)]
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

    [ParamField(0x165, ParamType.Dummy8, 11)]
    public byte[] Pad1
    {
        get => _Pad1;
        set => WriteParamField(ref _Pad1, value);
    }
    private byte[] _Pad1 = null!;

}
