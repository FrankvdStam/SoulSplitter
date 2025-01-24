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
public class ReinforceParamWeapon(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float PhysicsAtkRate
    {
        get => _PhysicsAtkRate;
        set => WriteParamField(ref _PhysicsAtkRate, value);
    }
    private float _PhysicsAtkRate;

    [ParamField(0x4, ParamType.F32)]
    public float MagicAtkRate
    {
        get => _MagicAtkRate;
        set => WriteParamField(ref _MagicAtkRate, value);
    }
    private float _MagicAtkRate;

    [ParamField(0x8, ParamType.F32)]
    public float FireAtkRate
    {
        get => _FireAtkRate;
        set => WriteParamField(ref _FireAtkRate, value);
    }
    private float _FireAtkRate;

    [ParamField(0xC, ParamType.F32)]
    public float ThunderAtkRate
    {
        get => _ThunderAtkRate;
        set => WriteParamField(ref _ThunderAtkRate, value);
    }
    private float _ThunderAtkRate;

    [ParamField(0x10, ParamType.F32)]
    public float StaminaAtkRate
    {
        get => _StaminaAtkRate;
        set => WriteParamField(ref _StaminaAtkRate, value);
    }
    private float _StaminaAtkRate;

    [ParamField(0x14, ParamType.F32)]
    public float SaWeaponAtkRate
    {
        get => _SaWeaponAtkRate;
        set => WriteParamField(ref _SaWeaponAtkRate, value);
    }
    private float _SaWeaponAtkRate;

    [ParamField(0x18, ParamType.F32)]
    public float SaDurabilityRate
    {
        get => _SaDurabilityRate;
        set => WriteParamField(ref _SaDurabilityRate, value);
    }
    private float _SaDurabilityRate;

    [ParamField(0x1C, ParamType.F32)]
    public float CorrectStrengthRate
    {
        get => _CorrectStrengthRate;
        set => WriteParamField(ref _CorrectStrengthRate, value);
    }
    private float _CorrectStrengthRate;

    [ParamField(0x20, ParamType.F32)]
    public float CorrectAgilityRate
    {
        get => _CorrectAgilityRate;
        set => WriteParamField(ref _CorrectAgilityRate, value);
    }
    private float _CorrectAgilityRate;

    [ParamField(0x24, ParamType.F32)]
    public float CorrectMagicRate
    {
        get => _CorrectMagicRate;
        set => WriteParamField(ref _CorrectMagicRate, value);
    }
    private float _CorrectMagicRate;

    [ParamField(0x28, ParamType.F32)]
    public float CorrectFaithRate
    {
        get => _CorrectFaithRate;
        set => WriteParamField(ref _CorrectFaithRate, value);
    }
    private float _CorrectFaithRate;

    [ParamField(0x2C, ParamType.F32)]
    public float PhysicsGuardCutRate
    {
        get => _PhysicsGuardCutRate;
        set => WriteParamField(ref _PhysicsGuardCutRate, value);
    }
    private float _PhysicsGuardCutRate;

    [ParamField(0x30, ParamType.F32)]
    public float MagicGuardCutRate
    {
        get => _MagicGuardCutRate;
        set => WriteParamField(ref _MagicGuardCutRate, value);
    }
    private float _MagicGuardCutRate;

    [ParamField(0x34, ParamType.F32)]
    public float FireGuardCutRate
    {
        get => _FireGuardCutRate;
        set => WriteParamField(ref _FireGuardCutRate, value);
    }
    private float _FireGuardCutRate;

    [ParamField(0x38, ParamType.F32)]
    public float ThunderGuardCutRate
    {
        get => _ThunderGuardCutRate;
        set => WriteParamField(ref _ThunderGuardCutRate, value);
    }
    private float _ThunderGuardCutRate;

    [ParamField(0x3C, ParamType.F32)]
    public float PoisonGuardResistRate
    {
        get => _PoisonGuardResistRate;
        set => WriteParamField(ref _PoisonGuardResistRate, value);
    }
    private float _PoisonGuardResistRate;

    [ParamField(0x40, ParamType.F32)]
    public float DiseaseGuardResistRate
    {
        get => _DiseaseGuardResistRate;
        set => WriteParamField(ref _DiseaseGuardResistRate, value);
    }
    private float _DiseaseGuardResistRate;

    [ParamField(0x44, ParamType.F32)]
    public float BloodGuardResistRate
    {
        get => _BloodGuardResistRate;
        set => WriteParamField(ref _BloodGuardResistRate, value);
    }
    private float _BloodGuardResistRate;

    [ParamField(0x48, ParamType.F32)]
    public float CurseGuardResistRate
    {
        get => _CurseGuardResistRate;
        set => WriteParamField(ref _CurseGuardResistRate, value);
    }
    private float _CurseGuardResistRate;

    [ParamField(0x4C, ParamType.F32)]
    public float StaminaGuardDefRate
    {
        get => _StaminaGuardDefRate;
        set => WriteParamField(ref _StaminaGuardDefRate, value);
    }
    private float _StaminaGuardDefRate;

    [ParamField(0x50, ParamType.U8)]
    public byte SpEffectId1
    {
        get => _SpEffectId1;
        set => WriteParamField(ref _SpEffectId1, value);
    }
    private byte _SpEffectId1;

    [ParamField(0x51, ParamType.U8)]
    public byte SpEffectId2
    {
        get => _SpEffectId2;
        set => WriteParamField(ref _SpEffectId2, value);
    }
    private byte _SpEffectId2;

    [ParamField(0x52, ParamType.U8)]
    public byte SpEffectId3
    {
        get => _SpEffectId3;
        set => WriteParamField(ref _SpEffectId3, value);
    }
    private byte _SpEffectId3;

    [ParamField(0x53, ParamType.U8)]
    public byte ResidentSpEffectId1
    {
        get => _ResidentSpEffectId1;
        set => WriteParamField(ref _ResidentSpEffectId1, value);
    }
    private byte _ResidentSpEffectId1;

    [ParamField(0x54, ParamType.U8)]
    public byte ResidentSpEffectId2
    {
        get => _ResidentSpEffectId2;
        set => WriteParamField(ref _ResidentSpEffectId2, value);
    }
    private byte _ResidentSpEffectId2;

    [ParamField(0x55, ParamType.U8)]
    public byte ResidentSpEffectId3
    {
        get => _ResidentSpEffectId3;
        set => WriteParamField(ref _ResidentSpEffectId3, value);
    }
    private byte _ResidentSpEffectId3;

    [ParamField(0x56, ParamType.U8)]
    public byte MaterialSetId
    {
        get => _MaterialSetId;
        set => WriteParamField(ref _MaterialSetId, value);
    }
    private byte _MaterialSetId;

    [ParamField(0x57, ParamType.U8)]
    public byte ReinforcementLevel
    {
        get => _ReinforcementLevel;
        set => WriteParamField(ref _ReinforcementLevel, value);
    }
    private byte _ReinforcementLevel;

}
