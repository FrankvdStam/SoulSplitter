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
public class MoveParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int StayId
    {
        get => _stayId;
        set => WriteParamField(ref _stayId, value);
    }
    private int _stayId;

    [ParamField(0x4, ParamType.I32)]
    public int WalkF
    {
        get => _walkF;
        set => WriteParamField(ref _walkF, value);
    }
    private int _walkF;

    [ParamField(0x8, ParamType.I32)]
    public int WalkB
    {
        get => _walkB;
        set => WriteParamField(ref _walkB, value);
    }
    private int _walkB;

    [ParamField(0xC, ParamType.I32)]
    public int WalkL
    {
        get => _walkL;
        set => WriteParamField(ref _walkL, value);
    }
    private int _walkL;

    [ParamField(0x10, ParamType.I32)]
    public int WalkR
    {
        get => _walkR;
        set => WriteParamField(ref _walkR, value);
    }
    private int _walkR;

    [ParamField(0x14, ParamType.I32)]
    public int DashF
    {
        get => _dashF;
        set => WriteParamField(ref _dashF, value);
    }
    private int _dashF;

    [ParamField(0x18, ParamType.I32)]
    public int DashB
    {
        get => _dashB;
        set => WriteParamField(ref _dashB, value);
    }
    private int _dashB;

    [ParamField(0x1C, ParamType.I32)]
    public int DashL
    {
        get => _dashL;
        set => WriteParamField(ref _dashL, value);
    }
    private int _dashL;

    [ParamField(0x20, ParamType.I32)]
    public int DashR
    {
        get => _dashR;
        set => WriteParamField(ref _dashR, value);
    }
    private int _dashR;

    [ParamField(0x24, ParamType.I32)]
    public int SuperDash
    {
        get => _superDash;
        set => WriteParamField(ref _superDash, value);
    }
    private int _superDash;

    [ParamField(0x28, ParamType.I32)]
    public int EscapeF
    {
        get => _escapeF;
        set => WriteParamField(ref _escapeF, value);
    }
    private int _escapeF;

    [ParamField(0x2C, ParamType.I32)]
    public int EscapeB
    {
        get => _escapeB;
        set => WriteParamField(ref _escapeB, value);
    }
    private int _escapeB;

    [ParamField(0x30, ParamType.I32)]
    public int EscapeL
    {
        get => _escapeL;
        set => WriteParamField(ref _escapeL, value);
    }
    private int _escapeL;

    [ParamField(0x34, ParamType.I32)]
    public int EscapeR
    {
        get => _escapeR;
        set => WriteParamField(ref _escapeR, value);
    }
    private int _escapeR;

    [ParamField(0x38, ParamType.I32)]
    public int TurnL
    {
        get => _turnL;
        set => WriteParamField(ref _turnL, value);
    }
    private int _turnL;

    [ParamField(0x3C, ParamType.I32)]
    public int TrunR
    {
        get => _trunR;
        set => WriteParamField(ref _trunR, value);
    }
    private int _trunR;

    [ParamField(0x40, ParamType.I32)]
    public int LargeTurnL
    {
        get => _largeTurnL;
        set => WriteParamField(ref _largeTurnL, value);
    }
    private int _largeTurnL;

    [ParamField(0x44, ParamType.I32)]
    public int LargeTurnR
    {
        get => _largeTurnR;
        set => WriteParamField(ref _largeTurnR, value);
    }
    private int _largeTurnR;

    [ParamField(0x48, ParamType.I32)]
    public int StepMove
    {
        get => _stepMove;
        set => WriteParamField(ref _stepMove, value);
    }
    private int _stepMove;

    [ParamField(0x4C, ParamType.I32)]
    public int FlyStay
    {
        get => _flyStay;
        set => WriteParamField(ref _flyStay, value);
    }
    private int _flyStay;

    [ParamField(0x50, ParamType.I32)]
    public int FlyWalkF
    {
        get => _flyWalkF;
        set => WriteParamField(ref _flyWalkF, value);
    }
    private int _flyWalkF;

    [ParamField(0x54, ParamType.I32)]
    public int FlyWalkFl
    {
        get => _flyWalkFl;
        set => WriteParamField(ref _flyWalkFl, value);
    }
    private int _flyWalkFl;

    [ParamField(0x58, ParamType.I32)]
    public int FlyWalkFr
    {
        get => _flyWalkFr;
        set => WriteParamField(ref _flyWalkFr, value);
    }
    private int _flyWalkFr;

    [ParamField(0x5C, ParamType.I32)]
    public int FlyWalkFl2
    {
        get => _flyWalkFl2;
        set => WriteParamField(ref _flyWalkFl2, value);
    }
    private int _flyWalkFl2;

    [ParamField(0x60, ParamType.I32)]
    public int FlyWalkFr2
    {
        get => _flyWalkFr2;
        set => WriteParamField(ref _flyWalkFr2, value);
    }
    private int _flyWalkFr2;

    [ParamField(0x64, ParamType.I32)]
    public int FlyDashF
    {
        get => _flyDashF;
        set => WriteParamField(ref _flyDashF, value);
    }
    private int _flyDashF;

    [ParamField(0x68, ParamType.I32)]
    public int FlyDashFl
    {
        get => _flyDashFl;
        set => WriteParamField(ref _flyDashFl, value);
    }
    private int _flyDashFl;

    [ParamField(0x6C, ParamType.I32)]
    public int FlyDashFr
    {
        get => _flyDashFr;
        set => WriteParamField(ref _flyDashFr, value);
    }
    private int _flyDashFr;

    [ParamField(0x70, ParamType.I32)]
    public int FlyDashFl2
    {
        get => _flyDashFl2;
        set => WriteParamField(ref _flyDashFl2, value);
    }
    private int _flyDashFl2;

    [ParamField(0x74, ParamType.I32)]
    public int FlyDashFr2
    {
        get => _flyDashFr2;
        set => WriteParamField(ref _flyDashFr2, value);
    }
    private int _flyDashFr2;

    [ParamField(0x78, ParamType.I32)]
    public int DashEscapeF
    {
        get => _dashEscapeF;
        set => WriteParamField(ref _dashEscapeF, value);
    }
    private int _dashEscapeF;

    [ParamField(0x7C, ParamType.I32)]
    public int DashEscapeB
    {
        get => _dashEscapeB;
        set => WriteParamField(ref _dashEscapeB, value);
    }
    private int _dashEscapeB;

    [ParamField(0x80, ParamType.I32)]
    public int DashEscapeL
    {
        get => _dashEscapeL;
        set => WriteParamField(ref _dashEscapeL, value);
    }
    private int _dashEscapeL;

    [ParamField(0x84, ParamType.I32)]
    public int DashEscapeR
    {
        get => _dashEscapeR;
        set => WriteParamField(ref _dashEscapeR, value);
    }
    private int _dashEscapeR;

    [ParamField(0x88, ParamType.I32)]
    public int AnalogMoveParamId
    {
        get => _analogMoveParamId;
        set => WriteParamField(ref _analogMoveParamId, value);
    }
    private int _analogMoveParamId;

    [ParamField(0x8C, ParamType.Dummy8, 4)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
