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
public class LockCamParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float CamDistTarget
    {
        get => _camDistTarget;
        set => WriteParamField(ref _camDistTarget, value);
    }
    private float _camDistTarget;

    [ParamField(0x4, ParamType.F32)]
    public float RotRangeMinX
    {
        get => _rotRangeMinX;
        set => WriteParamField(ref _rotRangeMinX, value);
    }
    private float _rotRangeMinX;

    [ParamField(0x8, ParamType.F32)]
    public float LockRotXShiftRatio
    {
        get => _lockRotXShiftRatio;
        set => WriteParamField(ref _lockRotXShiftRatio, value);
    }
    private float _lockRotXShiftRatio;

    [ParamField(0xC, ParamType.F32)]
    public float ChrOrgOffsetY
    {
        get => _chrOrgOffsetY;
        set => WriteParamField(ref _chrOrgOffsetY, value);
    }
    private float _chrOrgOffsetY;

    [ParamField(0x10, ParamType.F32)]
    public float ChrLockRangeMaxRadius
    {
        get => _chrLockRangeMaxRadius;
        set => WriteParamField(ref _chrLockRangeMaxRadius, value);
    }
    private float _chrLockRangeMaxRadius;

    [ParamField(0x14, ParamType.F32)]
    public float CamFovY
    {
        get => _camFovY;
        set => WriteParamField(ref _camFovY, value);
    }
    private float _camFovY;

    [ParamField(0x18, ParamType.Dummy8, 8)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
