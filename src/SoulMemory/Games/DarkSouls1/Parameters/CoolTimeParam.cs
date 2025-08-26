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
public class CoolTimeParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float LimitationTime0
    {
        get => _limitationTime0;
        set => WriteParamField(ref _limitationTime0, value);
    }
    private float _limitationTime0;

    [ParamField(0x4, ParamType.F32)]
    public float ObservationTime0
    {
        get => _observationTime0;
        set => WriteParamField(ref _observationTime0, value);
    }
    private float _observationTime0;

    [ParamField(0x8, ParamType.F32)]
    public float LimitationTime1
    {
        get => _limitationTime1;
        set => WriteParamField(ref _limitationTime1, value);
    }
    private float _limitationTime1;

    [ParamField(0xC, ParamType.F32)]
    public float ObservationTime1
    {
        get => _observationTime1;
        set => WriteParamField(ref _observationTime1, value);
    }
    private float _observationTime1;

    [ParamField(0x10, ParamType.F32)]
    public float LimitationTime2
    {
        get => _limitationTime2;
        set => WriteParamField(ref _limitationTime2, value);
    }
    private float _limitationTime2;

    [ParamField(0x14, ParamType.F32)]
    public float ObservationTime2
    {
        get => _observationTime2;
        set => WriteParamField(ref _observationTime2, value);
    }
    private float _observationTime2;

    [ParamField(0x18, ParamType.F32)]
    public float LimitationTime3
    {
        get => _limitationTime3;
        set => WriteParamField(ref _limitationTime3, value);
    }
    private float _limitationTime3;

    [ParamField(0x1C, ParamType.F32)]
    public float ObservationTime3
    {
        get => _observationTime3;
        set => WriteParamField(ref _observationTime3, value);
    }
    private float _observationTime3;

}
