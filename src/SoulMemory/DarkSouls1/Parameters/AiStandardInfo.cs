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
public class AiStandardInfo(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.U16)]
    public ushort RadarRange
    {
        get => _radarRange;
        set => WriteParamField(ref _radarRange, value);
    }
    private ushort _radarRange;

    [ParamField(0x2, ParamType.U8)]
    public byte RadarAngleX
    {
        get => _radarAngleX;
        set => WriteParamField(ref _radarAngleX, value);
    }
    private byte _radarAngleX;

    [ParamField(0x3, ParamType.U8)]
    public byte RadarAngleY
    {
        get => _radarAngleY;
        set => WriteParamField(ref _radarAngleY, value);
    }
    private byte _radarAngleY;

    [ParamField(0x4, ParamType.U16)]
    public ushort TerritorySize
    {
        get => _territorySize;
        set => WriteParamField(ref _territorySize, value);
    }
    private ushort _territorySize;

    [ParamField(0x6, ParamType.U8)]
    public byte ThreatBeforeAttackRate
    {
        get => _threatBeforeAttackRate;
        set => WriteParamField(ref _threatBeforeAttackRate, value);
    }
    private byte _threatBeforeAttackRate;

    [ParamField(0x7, ParamType.U8)]
    public byte ForceThreatOnFirstLocked
    {
        get => _forceThreatOnFirstLocked;
        set => WriteParamField(ref _forceThreatOnFirstLocked, value);
    }
    private byte _forceThreatOnFirstLocked;

    [ParamField(0x8, ParamType.Dummy8, 24)]
    public byte[] Reserve0
    {
        get => _reserve0;
        set => WriteParamField(ref _reserve0, value);
    }
    private byte[] _reserve0 = null!;

    [ParamField(0x20, ParamType.U16)]
    public ushort Attack1Distance
    {
        get => _attack1Distance;
        set => WriteParamField(ref _attack1Distance, value);
    }
    private ushort _attack1Distance;

    [ParamField(0x22, ParamType.U16)]
    public ushort Attack1Margin
    {
        get => _attack1Margin;
        set => WriteParamField(ref _attack1Margin, value);
    }
    private ushort _attack1Margin;

    [ParamField(0x24, ParamType.U8)]
    public byte Attack1Rate
    {
        get => _attack1Rate;
        set => WriteParamField(ref _attack1Rate, value);
    }
    private byte _attack1Rate;

    [ParamField(0x25, ParamType.U8)]
    public byte Attack1ActionId
    {
        get => _attack1ActionId;
        set => WriteParamField(ref _attack1ActionId, value);
    }
    private byte _attack1ActionId;

    [ParamField(0x26, ParamType.U8)]
    public byte Attack1DelayMin
    {
        get => _attack1DelayMin;
        set => WriteParamField(ref _attack1DelayMin, value);
    }
    private byte _attack1DelayMin;

    [ParamField(0x27, ParamType.U8)]
    public byte Attack1DelayMax
    {
        get => _attack1DelayMax;
        set => WriteParamField(ref _attack1DelayMax, value);
    }
    private byte _attack1DelayMax;

    [ParamField(0x28, ParamType.U8)]
    public byte Attack1ConeAngle
    {
        get => _attack1ConeAngle;
        set => WriteParamField(ref _attack1ConeAngle, value);
    }
    private byte _attack1ConeAngle;

    [ParamField(0x29, ParamType.Dummy8, 7)]
    public byte[] Reserve10
    {
        get => _reserve10;
        set => WriteParamField(ref _reserve10, value);
    }
    private byte[] _reserve10 = null!;

    [ParamField(0x30, ParamType.U16)]
    public ushort Attack2Distance
    {
        get => _attack2Distance;
        set => WriteParamField(ref _attack2Distance, value);
    }
    private ushort _attack2Distance;

    [ParamField(0x32, ParamType.U16)]
    public ushort Attack2Margin
    {
        get => _attack2Margin;
        set => WriteParamField(ref _attack2Margin, value);
    }
    private ushort _attack2Margin;

    [ParamField(0x34, ParamType.U8)]
    public byte Attack2Rate
    {
        get => _attack2Rate;
        set => WriteParamField(ref _attack2Rate, value);
    }
    private byte _attack2Rate;

    [ParamField(0x35, ParamType.U8)]
    public byte Attack2ActionId
    {
        get => _attack2ActionId;
        set => WriteParamField(ref _attack2ActionId, value);
    }
    private byte _attack2ActionId;

    [ParamField(0x36, ParamType.U8)]
    public byte Attack2DelayMin
    {
        get => _attack2DelayMin;
        set => WriteParamField(ref _attack2DelayMin, value);
    }
    private byte _attack2DelayMin;

    [ParamField(0x37, ParamType.U8)]
    public byte Attack2DelayMax
    {
        get => _attack2DelayMax;
        set => WriteParamField(ref _attack2DelayMax, value);
    }
    private byte _attack2DelayMax;

    [ParamField(0x38, ParamType.U8)]
    public byte Attack2ConeAngle
    {
        get => _attack2ConeAngle;
        set => WriteParamField(ref _attack2ConeAngle, value);
    }
    private byte _attack2ConeAngle;

    [ParamField(0x39, ParamType.Dummy8, 7)]
    public byte[] Reserve11
    {
        get => _reserve11;
        set => WriteParamField(ref _reserve11, value);
    }
    private byte[] _reserve11 = null!;

    [ParamField(0x40, ParamType.U16)]
    public ushort Attack3Distance
    {
        get => _attack3Distance;
        set => WriteParamField(ref _attack3Distance, value);
    }
    private ushort _attack3Distance;

    [ParamField(0x42, ParamType.U16)]
    public ushort Attack3Margin
    {
        get => _attack3Margin;
        set => WriteParamField(ref _attack3Margin, value);
    }
    private ushort _attack3Margin;

    [ParamField(0x44, ParamType.U8)]
    public byte Attack3Rate
    {
        get => _attack3Rate;
        set => WriteParamField(ref _attack3Rate, value);
    }
    private byte _attack3Rate;

    [ParamField(0x45, ParamType.U8)]
    public byte Attack3ActionId
    {
        get => _attack3ActionId;
        set => WriteParamField(ref _attack3ActionId, value);
    }
    private byte _attack3ActionId;

    [ParamField(0x46, ParamType.U8)]
    public byte Attack3DelayMin
    {
        get => _attack3DelayMin;
        set => WriteParamField(ref _attack3DelayMin, value);
    }
    private byte _attack3DelayMin;

    [ParamField(0x47, ParamType.U8)]
    public byte Attack3DelayMax
    {
        get => _attack3DelayMax;
        set => WriteParamField(ref _attack3DelayMax, value);
    }
    private byte _attack3DelayMax;

    [ParamField(0x48, ParamType.U8)]
    public byte Attack3ConeAngle
    {
        get => _attack3ConeAngle;
        set => WriteParamField(ref _attack3ConeAngle, value);
    }
    private byte _attack3ConeAngle;

    [ParamField(0x49, ParamType.Dummy8, 7)]
    public byte[] Reserve12
    {
        get => _reserve12;
        set => WriteParamField(ref _reserve12, value);
    }
    private byte[] _reserve12 = null!;

    [ParamField(0x50, ParamType.U16)]
    public ushort Attack4Distance
    {
        get => _attack4Distance;
        set => WriteParamField(ref _attack4Distance, value);
    }
    private ushort _attack4Distance;

    [ParamField(0x52, ParamType.U16)]
    public ushort Attack4Margin
    {
        get => _attack4Margin;
        set => WriteParamField(ref _attack4Margin, value);
    }
    private ushort _attack4Margin;

    [ParamField(0x54, ParamType.U8)]
    public byte Attack4Rate
    {
        get => _attack4Rate;
        set => WriteParamField(ref _attack4Rate, value);
    }
    private byte _attack4Rate;

    [ParamField(0x55, ParamType.U8)]
    public byte Attack4ActionId
    {
        get => _attack4ActionId;
        set => WriteParamField(ref _attack4ActionId, value);
    }
    private byte _attack4ActionId;

    [ParamField(0x56, ParamType.U8)]
    public byte Attack4DelayMin
    {
        get => _attack4DelayMin;
        set => WriteParamField(ref _attack4DelayMin, value);
    }
    private byte _attack4DelayMin;

    [ParamField(0x57, ParamType.U8)]
    public byte Attack4DelayMax
    {
        get => _attack4DelayMax;
        set => WriteParamField(ref _attack4DelayMax, value);
    }
    private byte _attack4DelayMax;

    [ParamField(0x58, ParamType.U8)]
    public byte Attack4ConeAngle
    {
        get => _attack4ConeAngle;
        set => WriteParamField(ref _attack4ConeAngle, value);
    }
    private byte _attack4ConeAngle;

    [ParamField(0x59, ParamType.Dummy8, 7)]
    public byte[] Reserve13
    {
        get => _reserve13;
        set => WriteParamField(ref _reserve13, value);
    }
    private byte[] _reserve13 = null!;

    [ParamField(0x60, ParamType.Dummy8, 32)]
    public byte[] ReserveLast
    {
        get => _reserveLast;
        set => WriteParamField(ref _reserveLast, value);
    }
    private byte[] _reserveLast = null!;

}
