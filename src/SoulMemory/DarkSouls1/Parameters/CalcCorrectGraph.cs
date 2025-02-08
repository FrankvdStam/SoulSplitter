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
public class CalcCorrectGraph(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float StageMaxVal0
    {
        get => _stageMaxVal0;
        set => WriteParamField(ref _stageMaxVal0, value);
    }
    private float _stageMaxVal0;

    [ParamField(0x4, ParamType.F32)]
    public float StageMaxVal1
    {
        get => _stageMaxVal1;
        set => WriteParamField(ref _stageMaxVal1, value);
    }
    private float _stageMaxVal1;

    [ParamField(0x8, ParamType.F32)]
    public float StageMaxVal2
    {
        get => _stageMaxVal2;
        set => WriteParamField(ref _stageMaxVal2, value);
    }
    private float _stageMaxVal2;

    [ParamField(0xC, ParamType.F32)]
    public float StageMaxVal3
    {
        get => _stageMaxVal3;
        set => WriteParamField(ref _stageMaxVal3, value);
    }
    private float _stageMaxVal3;

    [ParamField(0x10, ParamType.F32)]
    public float StageMaxVal4
    {
        get => _stageMaxVal4;
        set => WriteParamField(ref _stageMaxVal4, value);
    }
    private float _stageMaxVal4;

    [ParamField(0x14, ParamType.F32)]
    public float StageMaxGrowVal0
    {
        get => _stageMaxGrowVal0;
        set => WriteParamField(ref _stageMaxGrowVal0, value);
    }
    private float _stageMaxGrowVal0;

    [ParamField(0x18, ParamType.F32)]
    public float StageMaxGrowVal1
    {
        get => _stageMaxGrowVal1;
        set => WriteParamField(ref _stageMaxGrowVal1, value);
    }
    private float _stageMaxGrowVal1;

    [ParamField(0x1C, ParamType.F32)]
    public float StageMaxGrowVal2
    {
        get => _stageMaxGrowVal2;
        set => WriteParamField(ref _stageMaxGrowVal2, value);
    }
    private float _stageMaxGrowVal2;

    [ParamField(0x20, ParamType.F32)]
    public float StageMaxGrowVal3
    {
        get => _stageMaxGrowVal3;
        set => WriteParamField(ref _stageMaxGrowVal3, value);
    }
    private float _stageMaxGrowVal3;

    [ParamField(0x24, ParamType.F32)]
    public float StageMaxGrowVal4
    {
        get => _stageMaxGrowVal4;
        set => WriteParamField(ref _stageMaxGrowVal4, value);
    }
    private float _stageMaxGrowVal4;

    [ParamField(0x28, ParamType.F32)]
    public float AdjPtMaxGrowVal0
    {
        get => _adjPtMaxGrowVal0;
        set => WriteParamField(ref _adjPtMaxGrowVal0, value);
    }
    private float _adjPtMaxGrowVal0;

    [ParamField(0x2C, ParamType.F32)]
    public float AdjPtMaxGrowVal1
    {
        get => _adjPtMaxGrowVal1;
        set => WriteParamField(ref _adjPtMaxGrowVal1, value);
    }
    private float _adjPtMaxGrowVal1;

    [ParamField(0x30, ParamType.F32)]
    public float AdjPtMaxGrowVal2
    {
        get => _adjPtMaxGrowVal2;
        set => WriteParamField(ref _adjPtMaxGrowVal2, value);
    }
    private float _adjPtMaxGrowVal2;

    [ParamField(0x34, ParamType.F32)]
    public float AdjPtMaxGrowVal3
    {
        get => _adjPtMaxGrowVal3;
        set => WriteParamField(ref _adjPtMaxGrowVal3, value);
    }
    private float _adjPtMaxGrowVal3;

    [ParamField(0x38, ParamType.F32)]
    public float AdjPtMaxGrowVal4
    {
        get => _adjPtMaxGrowVal4;
        set => WriteParamField(ref _adjPtMaxGrowVal4, value);
    }
    private float _adjPtMaxGrowVal4;

    [ParamField(0x3C, ParamType.F32)]
    public float InitInclinationSoul
    {
        get => _initInclinationSoul;
        set => WriteParamField(ref _initInclinationSoul, value);
    }
    private float _initInclinationSoul;

    [ParamField(0x40, ParamType.F32)]
    public float AdjustmentValue
    {
        get => _adjustmentValue;
        set => WriteParamField(ref _adjustmentValue, value);
    }
    private float _adjustmentValue;

    [ParamField(0x44, ParamType.F32)]
    public float BoundryInclinationSoul
    {
        get => _boundryInclinationSoul;
        set => WriteParamField(ref _boundryInclinationSoul, value);
    }
    private float _boundryInclinationSoul;

    [ParamField(0x48, ParamType.F32)]
    public float BoundryValue
    {
        get => _boundryValue;
        set => WriteParamField(ref _boundryValue, value);
    }
    private float _boundryValue;

    [ParamField(0x4C, ParamType.Dummy8, 4)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
