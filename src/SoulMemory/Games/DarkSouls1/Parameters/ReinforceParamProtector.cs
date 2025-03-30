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
public class ReinforceParamProtector(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float PhysicsDefRate
    {
        get => _physicsDefRate;
        set => WriteParamField(ref _physicsDefRate, value);
    }
    private float _physicsDefRate;

    [ParamField(0x4, ParamType.F32)]
    public float MagicDefRate
    {
        get => _magicDefRate;
        set => WriteParamField(ref _magicDefRate, value);
    }
    private float _magicDefRate;

    [ParamField(0x8, ParamType.F32)]
    public float FireDefRate
    {
        get => _fireDefRate;
        set => WriteParamField(ref _fireDefRate, value);
    }
    private float _fireDefRate;

    [ParamField(0xC, ParamType.F32)]
    public float ThunderDefRate
    {
        get => _thunderDefRate;
        set => WriteParamField(ref _thunderDefRate, value);
    }
    private float _thunderDefRate;

    [ParamField(0x10, ParamType.F32)]
    public float SlashDefRate
    {
        get => _slashDefRate;
        set => WriteParamField(ref _slashDefRate, value);
    }
    private float _slashDefRate;

    [ParamField(0x14, ParamType.F32)]
    public float BlowDefRate
    {
        get => _blowDefRate;
        set => WriteParamField(ref _blowDefRate, value);
    }
    private float _blowDefRate;

    [ParamField(0x18, ParamType.F32)]
    public float ThrustDefRate
    {
        get => _thrustDefRate;
        set => WriteParamField(ref _thrustDefRate, value);
    }
    private float _thrustDefRate;

    [ParamField(0x1C, ParamType.F32)]
    public float ResistPoisonRate
    {
        get => _resistPoisonRate;
        set => WriteParamField(ref _resistPoisonRate, value);
    }
    private float _resistPoisonRate;

    [ParamField(0x20, ParamType.F32)]
    public float ResistDiseaseRate
    {
        get => _resistDiseaseRate;
        set => WriteParamField(ref _resistDiseaseRate, value);
    }
    private float _resistDiseaseRate;

    [ParamField(0x24, ParamType.F32)]
    public float ResistBloodRate
    {
        get => _resistBloodRate;
        set => WriteParamField(ref _resistBloodRate, value);
    }
    private float _resistBloodRate;

    [ParamField(0x28, ParamType.F32)]
    public float ResistCurseRate
    {
        get => _resistCurseRate;
        set => WriteParamField(ref _resistCurseRate, value);
    }
    private float _resistCurseRate;

    [ParamField(0x2C, ParamType.U8)]
    public byte ResidentSpEffectId1
    {
        get => _residentSpEffectId1;
        set => WriteParamField(ref _residentSpEffectId1, value);
    }
    private byte _residentSpEffectId1;

    [ParamField(0x2D, ParamType.U8)]
    public byte ResidentSpEffectId2
    {
        get => _residentSpEffectId2;
        set => WriteParamField(ref _residentSpEffectId2, value);
    }
    private byte _residentSpEffectId2;

    [ParamField(0x2E, ParamType.U8)]
    public byte ResidentSpEffectId3
    {
        get => _residentSpEffectId3;
        set => WriteParamField(ref _residentSpEffectId3, value);
    }
    private byte _residentSpEffectId3;

    [ParamField(0x2F, ParamType.U8)]
    public byte MaterialSetId
    {
        get => _materialSetId;
        set => WriteParamField(ref _materialSetId, value);
    }
    private byte _materialSetId;

}
