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
        get => _physicsAtkRate;
        set => WriteParamField(ref _physicsAtkRate, value);
    }
    private float _physicsAtkRate;

    [ParamField(0x4, ParamType.F32)]
    public float MagicAtkRate
    {
        get => _magicAtkRate;
        set => WriteParamField(ref _magicAtkRate, value);
    }
    private float _magicAtkRate;

    [ParamField(0x8, ParamType.F32)]
    public float FireAtkRate
    {
        get => _fireAtkRate;
        set => WriteParamField(ref _fireAtkRate, value);
    }
    private float _fireAtkRate;

    [ParamField(0xC, ParamType.F32)]
    public float ThunderAtkRate
    {
        get => _thunderAtkRate;
        set => WriteParamField(ref _thunderAtkRate, value);
    }
    private float _thunderAtkRate;

    [ParamField(0x10, ParamType.F32)]
    public float StaminaAtkRate
    {
        get => _staminaAtkRate;
        set => WriteParamField(ref _staminaAtkRate, value);
    }
    private float _staminaAtkRate;

    [ParamField(0x14, ParamType.F32)]
    public float SaWeaponAtkRate
    {
        get => _saWeaponAtkRate;
        set => WriteParamField(ref _saWeaponAtkRate, value);
    }
    private float _saWeaponAtkRate;

    [ParamField(0x18, ParamType.F32)]
    public float SaDurabilityRate
    {
        get => _saDurabilityRate;
        set => WriteParamField(ref _saDurabilityRate, value);
    }
    private float _saDurabilityRate;

    [ParamField(0x1C, ParamType.F32)]
    public float CorrectStrengthRate
    {
        get => _correctStrengthRate;
        set => WriteParamField(ref _correctStrengthRate, value);
    }
    private float _correctStrengthRate;

    [ParamField(0x20, ParamType.F32)]
    public float CorrectAgilityRate
    {
        get => _correctAgilityRate;
        set => WriteParamField(ref _correctAgilityRate, value);
    }
    private float _correctAgilityRate;

    [ParamField(0x24, ParamType.F32)]
    public float CorrectMagicRate
    {
        get => _correctMagicRate;
        set => WriteParamField(ref _correctMagicRate, value);
    }
    private float _correctMagicRate;

    [ParamField(0x28, ParamType.F32)]
    public float CorrectFaithRate
    {
        get => _correctFaithRate;
        set => WriteParamField(ref _correctFaithRate, value);
    }
    private float _correctFaithRate;

    [ParamField(0x2C, ParamType.F32)]
    public float PhysicsGuardCutRate
    {
        get => _physicsGuardCutRate;
        set => WriteParamField(ref _physicsGuardCutRate, value);
    }
    private float _physicsGuardCutRate;

    [ParamField(0x30, ParamType.F32)]
    public float MagicGuardCutRate
    {
        get => _magicGuardCutRate;
        set => WriteParamField(ref _magicGuardCutRate, value);
    }
    private float _magicGuardCutRate;

    [ParamField(0x34, ParamType.F32)]
    public float FireGuardCutRate
    {
        get => _fireGuardCutRate;
        set => WriteParamField(ref _fireGuardCutRate, value);
    }
    private float _fireGuardCutRate;

    [ParamField(0x38, ParamType.F32)]
    public float ThunderGuardCutRate
    {
        get => _thunderGuardCutRate;
        set => WriteParamField(ref _thunderGuardCutRate, value);
    }
    private float _thunderGuardCutRate;

    [ParamField(0x3C, ParamType.F32)]
    public float PoisonGuardResistRate
    {
        get => _poisonGuardResistRate;
        set => WriteParamField(ref _poisonGuardResistRate, value);
    }
    private float _poisonGuardResistRate;

    [ParamField(0x40, ParamType.F32)]
    public float DiseaseGuardResistRate
    {
        get => _diseaseGuardResistRate;
        set => WriteParamField(ref _diseaseGuardResistRate, value);
    }
    private float _diseaseGuardResistRate;

    [ParamField(0x44, ParamType.F32)]
    public float BloodGuardResistRate
    {
        get => _bloodGuardResistRate;
        set => WriteParamField(ref _bloodGuardResistRate, value);
    }
    private float _bloodGuardResistRate;

    [ParamField(0x48, ParamType.F32)]
    public float CurseGuardResistRate
    {
        get => _curseGuardResistRate;
        set => WriteParamField(ref _curseGuardResistRate, value);
    }
    private float _curseGuardResistRate;

    [ParamField(0x4C, ParamType.F32)]
    public float StaminaGuardDefRate
    {
        get => _staminaGuardDefRate;
        set => WriteParamField(ref _staminaGuardDefRate, value);
    }
    private float _staminaGuardDefRate;

    [ParamField(0x50, ParamType.U8)]
    public byte SpEffectId1
    {
        get => _spEffectId1;
        set => WriteParamField(ref _spEffectId1, value);
    }
    private byte _spEffectId1;

    [ParamField(0x51, ParamType.U8)]
    public byte SpEffectId2
    {
        get => _spEffectId2;
        set => WriteParamField(ref _spEffectId2, value);
    }
    private byte _spEffectId2;

    [ParamField(0x52, ParamType.U8)]
    public byte SpEffectId3
    {
        get => _spEffectId3;
        set => WriteParamField(ref _spEffectId3, value);
    }
    private byte _spEffectId3;

    [ParamField(0x53, ParamType.U8)]
    public byte ResidentSpEffectId1
    {
        get => _residentSpEffectId1;
        set => WriteParamField(ref _residentSpEffectId1, value);
    }
    private byte _residentSpEffectId1;

    [ParamField(0x54, ParamType.U8)]
    public byte ResidentSpEffectId2
    {
        get => _residentSpEffectId2;
        set => WriteParamField(ref _residentSpEffectId2, value);
    }
    private byte _residentSpEffectId2;

    [ParamField(0x55, ParamType.U8)]
    public byte ResidentSpEffectId3
    {
        get => _residentSpEffectId3;
        set => WriteParamField(ref _residentSpEffectId3, value);
    }
    private byte _residentSpEffectId3;

    [ParamField(0x56, ParamType.U8)]
    public byte MaterialSetId
    {
        get => _materialSetId;
        set => WriteParamField(ref _materialSetId, value);
    }
    private byte _materialSetId;

    [ParamField(0x57, ParamType.U8)]
    public byte ReinforcementLevel
    {
        get => _reinforcementLevel;
        set => WriteParamField(ref _reinforcementLevel, value);
    }
    private byte _reinforcementLevel;

}
