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
public class EnemyStandardInfo(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int EnemyBehaviorId
    {
        get => _enemyBehaviorId;
        set => WriteParamField(ref _enemyBehaviorId, value);
    }
    private int _enemyBehaviorId;

    [ParamField(0x4, ParamType.U16)]
    public ushort Hp
    {
        get => _hp;
        set => WriteParamField(ref _hp, value);
    }
    private ushort _hp;

    [ParamField(0x6, ParamType.U16)]
    public ushort AttackPower
    {
        get => _attackPower;
        set => WriteParamField(ref _attackPower, value);
    }
    private ushort _attackPower;

    [ParamField(0x8, ParamType.I32)]
    public int ChrType
    {
        get => _chrType;
        set => WriteParamField(ref _chrType, value);
    }
    private int _chrType;

    [ParamField(0xC, ParamType.F32)]
    public float HitHeight
    {
        get => _hitHeight;
        set => WriteParamField(ref _hitHeight, value);
    }
    private float _hitHeight;

    [ParamField(0x10, ParamType.F32)]
    public float HitRadius
    {
        get => _hitRadius;
        set => WriteParamField(ref _hitRadius, value);
    }
    private float _hitRadius;

    [ParamField(0x14, ParamType.F32)]
    public float Weight
    {
        get => _weight;
        set => WriteParamField(ref _weight, value);
    }
    private float _weight;

    [ParamField(0x18, ParamType.F32)]
    public float DynamicFriction
    {
        get => _dynamicFriction;
        set => WriteParamField(ref _dynamicFriction, value);
    }
    private float _dynamicFriction;

    [ParamField(0x1C, ParamType.F32)]
    public float StaticFriction
    {
        get => _staticFriction;
        set => WriteParamField(ref _staticFriction, value);
    }
    private float _staticFriction;

    [ParamField(0x20, ParamType.I32)]
    public int UpperDefState
    {
        get => _upperDefState;
        set => WriteParamField(ref _upperDefState, value);
    }
    private int _upperDefState;

    [ParamField(0x24, ParamType.I32)]
    public int ActionDefState
    {
        get => _actionDefState;
        set => WriteParamField(ref _actionDefState, value);
    }
    private int _actionDefState;

    [ParamField(0x28, ParamType.F32)]
    public float RotYPerSecond
    {
        get => _rotYPerSecond;
        set => WriteParamField(ref _rotYPerSecond, value);
    }
    private float _rotYPerSecond;

    [ParamField(0x2C, ParamType.Dummy8, 20)]
    public byte[] Reserve0
    {
        get => _reserve0;
        set => WriteParamField(ref _reserve0, value);
    }
    private byte[] _reserve0 = null!;

    [ParamField(0x40, ParamType.U8)]
    public byte RotYPerSecondOld
    {
        get => _rotYPerSecondOld;
        set => WriteParamField(ref _rotYPerSecondOld, value);
    }
    private byte _rotYPerSecondOld;

    [ParamField(0x41, ParamType.U8)]
    public byte EnableSideStep
    {
        get => _enableSideStep;
        set => WriteParamField(ref _enableSideStep, value);
    }
    private byte _enableSideStep;

    [ParamField(0x42, ParamType.U8)]
    public byte UseRagdollHit
    {
        get => _useRagdollHit;
        set => WriteParamField(ref _useRagdollHit, value);
    }
    private byte _useRagdollHit;

    [ParamField(0x43, ParamType.Dummy8, 5)]
    public byte[] ReserveLast
    {
        get => _reserveLast;
        set => WriteParamField(ref _reserveLast, value);
    }
    private byte[] _reserveLast = null!;

    [ParamField(0x48, ParamType.U16)]
    public ushort Stamina
    {
        get => _stamina;
        set => WriteParamField(ref _stamina, value);
    }
    private ushort _stamina;

    [ParamField(0x4A, ParamType.U16)]
    public ushort StaminaRecover
    {
        get => _staminaRecover;
        set => WriteParamField(ref _staminaRecover, value);
    }
    private ushort _staminaRecover;

    [ParamField(0x4C, ParamType.U16)]
    public ushort StaminaConsumption
    {
        get => _staminaConsumption;
        set => WriteParamField(ref _staminaConsumption, value);
    }
    private ushort _staminaConsumption;

    [ParamField(0x4E, ParamType.U16)]
    public ushort DeffenctPhys
    {
        get => _deffenctPhys;
        set => WriteParamField(ref _deffenctPhys, value);
    }
    private ushort _deffenctPhys;

    [ParamField(0x50, ParamType.Dummy8, 48)]
    public byte[] ReserveLast2
    {
        get => _reserveLast2;
        set => WriteParamField(ref _reserveLast2, value);
    }
    private byte[] _reserveLast2 = null!;

}
