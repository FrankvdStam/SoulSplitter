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
public class SkeletonParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float NeckTurnGain
    {
        get => _neckTurnGain;
        set => WriteParamField(ref _neckTurnGain, value);
    }
    private float _neckTurnGain;

    [ParamField(0x4, ParamType.I16)]
    public short OriginalGroundHeightMs
    {
        get => _originalGroundHeightMs;
        set => WriteParamField(ref _originalGroundHeightMs, value);
    }
    private short _originalGroundHeightMs;

    [ParamField(0x6, ParamType.I16)]
    public short MinAnkleHeightMs
    {
        get => _minAnkleHeightMs;
        set => WriteParamField(ref _minAnkleHeightMs, value);
    }
    private short _minAnkleHeightMs;

    [ParamField(0x8, ParamType.I16)]
    public short MaxAnkleHeightMs
    {
        get => _maxAnkleHeightMs;
        set => WriteParamField(ref _maxAnkleHeightMs, value);
    }
    private short _maxAnkleHeightMs;

    [ParamField(0xA, ParamType.I16)]
    public short CosineMaxKneeAngle
    {
        get => _cosineMaxKneeAngle;
        set => WriteParamField(ref _cosineMaxKneeAngle, value);
    }
    private short _cosineMaxKneeAngle;

    [ParamField(0xC, ParamType.I16)]
    public short CosineMinKneeAngle
    {
        get => _cosineMinKneeAngle;
        set => WriteParamField(ref _cosineMinKneeAngle, value);
    }
    private short _cosineMinKneeAngle;

    [ParamField(0xE, ParamType.I16)]
    public short FootPlantedAnkleHeightMs
    {
        get => _footPlantedAnkleHeightMs;
        set => WriteParamField(ref _footPlantedAnkleHeightMs, value);
    }
    private short _footPlantedAnkleHeightMs;

    [ParamField(0x10, ParamType.I16)]
    public short FootRaisedAnkleHeightMs
    {
        get => _footRaisedAnkleHeightMs;
        set => WriteParamField(ref _footRaisedAnkleHeightMs, value);
    }
    private short _footRaisedAnkleHeightMs;

    [ParamField(0x12, ParamType.I16)]
    public short RaycastDistanceUp
    {
        get => _raycastDistanceUp;
        set => WriteParamField(ref _raycastDistanceUp, value);
    }
    private short _raycastDistanceUp;

    [ParamField(0x14, ParamType.I16)]
    public short RaycastDistanceDown
    {
        get => _raycastDistanceDown;
        set => WriteParamField(ref _raycastDistanceDown, value);
    }
    private short _raycastDistanceDown;

    [ParamField(0x16, ParamType.I16)]
    public short FootEndLsX
    {
        get => _footEndLsX;
        set => WriteParamField(ref _footEndLsX, value);
    }
    private short _footEndLsX;

    [ParamField(0x18, ParamType.I16)]
    public short FootEndLsY
    {
        get => _footEndLsY;
        set => WriteParamField(ref _footEndLsY, value);
    }
    private short _footEndLsY;

    [ParamField(0x1A, ParamType.I16)]
    public short FootEndLsZ
    {
        get => _footEndLsZ;
        set => WriteParamField(ref _footEndLsZ, value);
    }
    private short _footEndLsZ;

    [ParamField(0x1C, ParamType.I16)]
    public short OnOffGain
    {
        get => _onOffGain;
        set => WriteParamField(ref _onOffGain, value);
    }
    private short _onOffGain;

    [ParamField(0x1E, ParamType.I16)]
    public short GroundAscendingGain
    {
        get => _groundAscendingGain;
        set => WriteParamField(ref _groundAscendingGain, value);
    }
    private short _groundAscendingGain;

    [ParamField(0x20, ParamType.I16)]
    public short GroundDescendingGain
    {
        get => _groundDescendingGain;
        set => WriteParamField(ref _groundDescendingGain, value);
    }
    private short _groundDescendingGain;

    [ParamField(0x22, ParamType.I16)]
    public short FootRaisedGain
    {
        get => _footRaisedGain;
        set => WriteParamField(ref _footRaisedGain, value);
    }
    private short _footRaisedGain;

    [ParamField(0x24, ParamType.I16)]
    public short FootPlantedGain
    {
        get => _footPlantedGain;
        set => WriteParamField(ref _footPlantedGain, value);
    }
    private short _footPlantedGain;

    [ParamField(0x26, ParamType.I16)]
    public short FootUnlockGain
    {
        get => _footUnlockGain;
        set => WriteParamField(ref _footUnlockGain, value);
    }
    private short _footUnlockGain;

    [ParamField(0x28, ParamType.U8)]
    public byte KneeAxisType
    {
        get => _kneeAxisType;
        set => WriteParamField(ref _kneeAxisType, value);
    }
    private byte _kneeAxisType;

    [ParamField(0x29, ParamType.U8)]
    public byte UseFootLocking
    {
        get => _useFootLocking;
        set => WriteParamField(ref _useFootLocking, value);
    }
    private byte _useFootLocking;

    [ParamField(0x2A, ParamType.U8)]
    public byte FootPlacementOn
    {
        get => _footPlacementOn;
        set => WriteParamField(ref _footPlacementOn, value);
    }
    private byte _footPlacementOn;

    [ParamField(0x2B, ParamType.U8)]
    public byte TwistKneeAxisType
    {
        get => _twistKneeAxisType;
        set => WriteParamField(ref _twistKneeAxisType, value);
    }
    private byte _twistKneeAxisType;

    [ParamField(0x2C, ParamType.I8)]
    public sbyte NeckTurnPriority
    {
        get => _neckTurnPriority;
        set => WriteParamField(ref _neckTurnPriority, value);
    }
    private sbyte _neckTurnPriority;

    [ParamField(0x2D, ParamType.U8)]
    public byte NeckTurnMaxAngle
    {
        get => _neckTurnMaxAngle;
        set => WriteParamField(ref _neckTurnMaxAngle, value);
    }
    private byte _neckTurnMaxAngle;

    [ParamField(0x2E, ParamType.Dummy8, 2)]
    public byte[] Pad1
    {
        get => _pad1;
        set => WriteParamField(ref _pad1, value);
    }
    private byte[] _pad1 = null!;

}
