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
public class ThrowParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int AtkChrId
    {
        get => _atkChrId;
        set => WriteParamField(ref _atkChrId, value);
    }
    private int _atkChrId;

    [ParamField(0x4, ParamType.I32)]
    public int DefChrId
    {
        get => _defChrId;
        set => WriteParamField(ref _defChrId, value);
    }
    private int _defChrId;

    [ParamField(0x8, ParamType.F32)]
    public float Dist
    {
        get => _dist;
        set => WriteParamField(ref _dist, value);
    }
    private float _dist;

    [ParamField(0xC, ParamType.F32)]
    public float DiffAngMin
    {
        get => _diffAngMin;
        set => WriteParamField(ref _diffAngMin, value);
    }
    private float _diffAngMin;

    [ParamField(0x10, ParamType.F32)]
    public float DiffAngMax
    {
        get => _diffAngMax;
        set => WriteParamField(ref _diffAngMax, value);
    }
    private float _diffAngMax;

    [ParamField(0x14, ParamType.F32)]
    public float UpperYRange
    {
        get => _upperYRange;
        set => WriteParamField(ref _upperYRange, value);
    }
    private float _upperYRange;

    [ParamField(0x18, ParamType.F32)]
    public float LowerYRange
    {
        get => _lowerYRange;
        set => WriteParamField(ref _lowerYRange, value);
    }
    private float _lowerYRange;

    [ParamField(0x1C, ParamType.F32)]
    public float DiffAngMyToDef
    {
        get => _diffAngMyToDef;
        set => WriteParamField(ref _diffAngMyToDef, value);
    }
    private float _diffAngMyToDef;

    [ParamField(0x20, ParamType.I32)]
    public int ThrowTypeId
    {
        get => _throwTypeId;
        set => WriteParamField(ref _throwTypeId, value);
    }
    private int _throwTypeId;

    [ParamField(0x24, ParamType.I32)]
    public int AtkAnimId
    {
        get => _atkAnimId;
        set => WriteParamField(ref _atkAnimId, value);
    }
    private int _atkAnimId;

    [ParamField(0x28, ParamType.I32)]
    public int DefAnimId
    {
        get => _defAnimId;
        set => WriteParamField(ref _defAnimId, value);
    }
    private int _defAnimId;

    [ParamField(0x2C, ParamType.U16)]
    public ushort EscHp
    {
        get => _escHp;
        set => WriteParamField(ref _escHp, value);
    }
    private ushort _escHp;

    [ParamField(0x2E, ParamType.U16)]
    public ushort SelfEscCycleTime
    {
        get => _selfEscCycleTime;
        set => WriteParamField(ref _selfEscCycleTime, value);
    }
    private ushort _selfEscCycleTime;

    [ParamField(0x30, ParamType.U16)]
    public ushort SphereCastRadiusRateTop
    {
        get => _sphereCastRadiusRateTop;
        set => WriteParamField(ref _sphereCastRadiusRateTop, value);
    }
    private ushort _sphereCastRadiusRateTop;

    [ParamField(0x32, ParamType.U16)]
    public ushort SphereCastRadiusRateLow
    {
        get => _sphereCastRadiusRateLow;
        set => WriteParamField(ref _sphereCastRadiusRateLow, value);
    }
    private ushort _sphereCastRadiusRateLow;

    [ParamField(0x34, ParamType.U8)]
    public byte PadType
    {
        get => _padType;
        set => WriteParamField(ref _padType, value);
    }
    private byte _padType;

    [ParamField(0x35, ParamType.U8)]
    public byte AtkEnableState
    {
        get => _atkEnableState;
        set => WriteParamField(ref _atkEnableState, value);
    }
    private byte _atkEnableState;

    [ParamField(0x36, ParamType.U8)]
    public byte AtkSorbDmyId
    {
        get => _atkSorbDmyId;
        set => WriteParamField(ref _atkSorbDmyId, value);
    }
    private byte _atkSorbDmyId;

    [ParamField(0x37, ParamType.U8)]
    public byte DefSorbDmyId
    {
        get => _defSorbDmyId;
        set => WriteParamField(ref _defSorbDmyId, value);
    }
    private byte _defSorbDmyId;

    [ParamField(0x38, ParamType.U8)]
    public byte ThrowType
    {
        get => _throwType;
        set => WriteParamField(ref _throwType, value);
    }
    private byte _throwType;

    [ParamField(0x39, ParamType.U8)]
    public byte SelfEscCycleCnt
    {
        get => _selfEscCycleCnt;
        set => WriteParamField(ref _selfEscCycleCnt, value);
    }
    private byte _selfEscCycleCnt;

    [ParamField(0x3A, ParamType.U8)]
    public byte DmyHasChrDirType
    {
        get => _dmyHasChrDirType;
        set => WriteParamField(ref _dmyHasChrDirType, value);
    }
    private byte _dmyHasChrDirType;

    #region BitField IsTurnAtkerBitfield ==============================================================================

    [ParamField(0x3B, ParamType.U8)]
    public byte IsTurnAtkerBitfield
    {
        get => _isTurnAtkerBitfield;
        set => WriteParamField(ref _isTurnAtkerBitfield, value);
    }
    private byte _isTurnAtkerBitfield;

    [ParamBitField(nameof(IsTurnAtkerBitfield), bits: 1, bitsOffset: 0)]
    public byte IsTurnAtker
    {
        get => GetbitfieldValue(_isTurnAtkerBitfield);
        set => SetBitfieldValue(ref _isTurnAtkerBitfield, value);
    }

    [ParamBitField(nameof(IsTurnAtkerBitfield), bits: 1, bitsOffset: 1)]
    public byte IsSkipWepCate
    {
        get => GetbitfieldValue(_isTurnAtkerBitfield);
        set => SetBitfieldValue(ref _isTurnAtkerBitfield, value);
    }

    [ParamBitField(nameof(IsTurnAtkerBitfield), bits: 1, bitsOffset: 2)]
    public byte IsSkipSphereCast
    {
        get => GetbitfieldValue(_isTurnAtkerBitfield);
        set => SetBitfieldValue(ref _isTurnAtkerBitfield, value);
    }

    [ParamBitField(nameof(IsTurnAtkerBitfield), bits: 5, bitsOffset: 3)]
    public byte Pad0
    {
        get => GetbitfieldValue(_isTurnAtkerBitfield);
        set => SetBitfieldValue(ref _isTurnAtkerBitfield, value);
    }

    #endregion BitField IsTurnAtkerBitfield

    [ParamField(0x3C, ParamType.Dummy8, 4)]
    public byte[] Pad1
    {
        get => _pad1;
        set => WriteParamField(ref _pad1, value);
    }
    private byte[] _pad1 = null!;

}
