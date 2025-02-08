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
public class KnockBackParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float DamageMinContTime
    {
        get => _damageMinContTime;
        set => WriteParamField(ref _damageMinContTime, value);
    }
    private float _damageMinContTime;

    [ParamField(0x4, ParamType.F32)]
    public float DamageSContTime
    {
        get => _damageSContTime;
        set => WriteParamField(ref _damageSContTime, value);
    }
    private float _damageSContTime;

    [ParamField(0x8, ParamType.F32)]
    public float DamageMContTime
    {
        get => _damageMContTime;
        set => WriteParamField(ref _damageMContTime, value);
    }
    private float _damageMContTime;

    [ParamField(0xC, ParamType.F32)]
    public float DamageLContTime
    {
        get => _damageLContTime;
        set => WriteParamField(ref _damageLContTime, value);
    }
    private float _damageLContTime;

    [ParamField(0x10, ParamType.F32)]
    public float DamageBlowSContTime
    {
        get => _damageBlowSContTime;
        set => WriteParamField(ref _damageBlowSContTime, value);
    }
    private float _damageBlowSContTime;

    [ParamField(0x14, ParamType.F32)]
    public float DamageBlowMContTime
    {
        get => _damageBlowMContTime;
        set => WriteParamField(ref _damageBlowMContTime, value);
    }
    private float _damageBlowMContTime;

    [ParamField(0x18, ParamType.F32)]
    public float DamageStrikeContTime
    {
        get => _damageStrikeContTime;
        set => WriteParamField(ref _damageStrikeContTime, value);
    }
    private float _damageStrikeContTime;

    [ParamField(0x1C, ParamType.F32)]
    public float DamageUppercutContTime
    {
        get => _damageUppercutContTime;
        set => WriteParamField(ref _damageUppercutContTime, value);
    }
    private float _damageUppercutContTime;

    [ParamField(0x20, ParamType.F32)]
    public float DamagePushContTime
    {
        get => _damagePushContTime;
        set => WriteParamField(ref _damagePushContTime, value);
    }
    private float _damagePushContTime;

    [ParamField(0x24, ParamType.F32)]
    public float DamageBreathContTime
    {
        get => _damageBreathContTime;
        set => WriteParamField(ref _damageBreathContTime, value);
    }
    private float _damageBreathContTime;

    [ParamField(0x28, ParamType.F32)]
    public float DamageHeadShotContTime
    {
        get => _damageHeadShotContTime;
        set => WriteParamField(ref _damageHeadShotContTime, value);
    }
    private float _damageHeadShotContTime;

    [ParamField(0x2C, ParamType.F32)]
    public float GuardSContTime
    {
        get => _guardSContTime;
        set => WriteParamField(ref _guardSContTime, value);
    }
    private float _guardSContTime;

    [ParamField(0x30, ParamType.F32)]
    public float GuardLContTime
    {
        get => _guardLContTime;
        set => WriteParamField(ref _guardLContTime, value);
    }
    private float _guardLContTime;

    [ParamField(0x34, ParamType.F32)]
    public float GuardLlContTime
    {
        get => _guardLlContTime;
        set => WriteParamField(ref _guardLlContTime, value);
    }
    private float _guardLlContTime;

    [ParamField(0x38, ParamType.F32)]
    public float GuardBrakeContTime
    {
        get => _guardBrakeContTime;
        set => WriteParamField(ref _guardBrakeContTime, value);
    }
    private float _guardBrakeContTime;

    [ParamField(0x3C, ParamType.F32)]
    public float DamageMinDecTime
    {
        get => _damageMinDecTime;
        set => WriteParamField(ref _damageMinDecTime, value);
    }
    private float _damageMinDecTime;

    [ParamField(0x40, ParamType.F32)]
    public float DamageSDecTime
    {
        get => _damageSDecTime;
        set => WriteParamField(ref _damageSDecTime, value);
    }
    private float _damageSDecTime;

    [ParamField(0x44, ParamType.F32)]
    public float DamageMDecTime
    {
        get => _damageMDecTime;
        set => WriteParamField(ref _damageMDecTime, value);
    }
    private float _damageMDecTime;

    [ParamField(0x48, ParamType.F32)]
    public float DamageLDecTime
    {
        get => _damageLDecTime;
        set => WriteParamField(ref _damageLDecTime, value);
    }
    private float _damageLDecTime;

    [ParamField(0x4C, ParamType.F32)]
    public float DamageBlowSDecTime
    {
        get => _damageBlowSDecTime;
        set => WriteParamField(ref _damageBlowSDecTime, value);
    }
    private float _damageBlowSDecTime;

    [ParamField(0x50, ParamType.F32)]
    public float DamageBlowMDecTime
    {
        get => _damageBlowMDecTime;
        set => WriteParamField(ref _damageBlowMDecTime, value);
    }
    private float _damageBlowMDecTime;

    [ParamField(0x54, ParamType.F32)]
    public float DamageStrikeDecTime
    {
        get => _damageStrikeDecTime;
        set => WriteParamField(ref _damageStrikeDecTime, value);
    }
    private float _damageStrikeDecTime;

    [ParamField(0x58, ParamType.F32)]
    public float DamageUppercutDecTime
    {
        get => _damageUppercutDecTime;
        set => WriteParamField(ref _damageUppercutDecTime, value);
    }
    private float _damageUppercutDecTime;

    [ParamField(0x5C, ParamType.F32)]
    public float DamagePushDecTime
    {
        get => _damagePushDecTime;
        set => WriteParamField(ref _damagePushDecTime, value);
    }
    private float _damagePushDecTime;

    [ParamField(0x60, ParamType.F32)]
    public float DamageBreathDecTime
    {
        get => _damageBreathDecTime;
        set => WriteParamField(ref _damageBreathDecTime, value);
    }
    private float _damageBreathDecTime;

    [ParamField(0x64, ParamType.F32)]
    public float DamageHeadShotDecTime
    {
        get => _damageHeadShotDecTime;
        set => WriteParamField(ref _damageHeadShotDecTime, value);
    }
    private float _damageHeadShotDecTime;

    [ParamField(0x68, ParamType.F32)]
    public float GuardSDecTime
    {
        get => _guardSDecTime;
        set => WriteParamField(ref _guardSDecTime, value);
    }
    private float _guardSDecTime;

    [ParamField(0x6C, ParamType.F32)]
    public float GuardLDecTime
    {
        get => _guardLDecTime;
        set => WriteParamField(ref _guardLDecTime, value);
    }
    private float _guardLDecTime;

    [ParamField(0x70, ParamType.F32)]
    public float GuardLlDecTime
    {
        get => _guardLlDecTime;
        set => WriteParamField(ref _guardLlDecTime, value);
    }
    private float _guardLlDecTime;

    [ParamField(0x74, ParamType.F32)]
    public float GuardBrakeDecTime
    {
        get => _guardBrakeDecTime;
        set => WriteParamField(ref _guardBrakeDecTime, value);
    }
    private float _guardBrakeDecTime;

    [ParamField(0x78, ParamType.Dummy8, 8)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
