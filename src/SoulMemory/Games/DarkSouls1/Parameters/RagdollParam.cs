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
public class RagdollParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float HierarchyGain
    {
        get => _hierarchyGain;
        set => WriteParamField(ref _hierarchyGain, value);
    }
    private float _hierarchyGain;

    [ParamField(0x4, ParamType.F32)]
    public float VelocityDamping
    {
        get => _velocityDamping;
        set => WriteParamField(ref _velocityDamping, value);
    }
    private float _velocityDamping;

    [ParamField(0x8, ParamType.F32)]
    public float AccelGain
    {
        get => _accelGain;
        set => WriteParamField(ref _accelGain, value);
    }
    private float _accelGain;

    [ParamField(0xC, ParamType.F32)]
    public float VelocityGain
    {
        get => _velocityGain;
        set => WriteParamField(ref _velocityGain, value);
    }
    private float _velocityGain;

    [ParamField(0x10, ParamType.F32)]
    public float PositionGain
    {
        get => _positionGain;
        set => WriteParamField(ref _positionGain, value);
    }
    private float _positionGain;

    [ParamField(0x14, ParamType.F32)]
    public float MaxLinerVelocity
    {
        get => _maxLinerVelocity;
        set => WriteParamField(ref _maxLinerVelocity, value);
    }
    private float _maxLinerVelocity;

    [ParamField(0x18, ParamType.F32)]
    public float MaxAngularVelocity
    {
        get => _maxAngularVelocity;
        set => WriteParamField(ref _maxAngularVelocity, value);
    }
    private float _maxAngularVelocity;

    [ParamField(0x1C, ParamType.F32)]
    public float SnapGain
    {
        get => _snapGain;
        set => WriteParamField(ref _snapGain, value);
    }
    private float _snapGain;

    [ParamField(0x20, ParamType.U8)]
    public byte Enable
    {
        get => _enable;
        set => WriteParamField(ref _enable, value);
    }
    private byte _enable;

    [ParamField(0x21, ParamType.I8)]
    public sbyte PartsHitMaskNo
    {
        get => _partsHitMaskNo;
        set => WriteParamField(ref _partsHitMaskNo, value);
    }
    private sbyte _partsHitMaskNo;

    [ParamField(0x22, ParamType.Dummy8, 14)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
