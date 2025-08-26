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
public class QwcJudgeParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I16)]
    public short PcJudgeUnderWb
    {
        get => _pcJudgeUnderWb;
        set => WriteParamField(ref _pcJudgeUnderWb, value);
    }
    private short _pcJudgeUnderWb;

    [ParamField(0x2, ParamType.I16)]
    public short PcJudgeTopWb
    {
        get => _pcJudgeTopWb;
        set => WriteParamField(ref _pcJudgeTopWb, value);
    }
    private short _pcJudgeTopWb;

    [ParamField(0x4, ParamType.I16)]
    public short PcJudgeUnderLr
    {
        get => _pcJudgeUnderLr;
        set => WriteParamField(ref _pcJudgeUnderLr, value);
    }
    private short _pcJudgeUnderLr;

    [ParamField(0x6, ParamType.I16)]
    public short PcJudgeTopLr
    {
        get => _pcJudgeTopLr;
        set => WriteParamField(ref _pcJudgeTopLr, value);
    }
    private short _pcJudgeTopLr;

    [ParamField(0x8, ParamType.I16)]
    public short AreaJudgeUnderWb
    {
        get => _areaJudgeUnderWb;
        set => WriteParamField(ref _areaJudgeUnderWb, value);
    }
    private short _areaJudgeUnderWb;

    [ParamField(0xA, ParamType.I16)]
    public short AreaJudgeTopWb
    {
        get => _areaJudgeTopWb;
        set => WriteParamField(ref _areaJudgeTopWb, value);
    }
    private short _areaJudgeTopWb;

    [ParamField(0xC, ParamType.I16)]
    public short AreaJudgeUnderLr
    {
        get => _areaJudgeUnderLr;
        set => WriteParamField(ref _areaJudgeUnderLr, value);
    }
    private short _areaJudgeUnderLr;

    [ParamField(0xE, ParamType.I16)]
    public short AreaJudgeTopLr
    {
        get => _areaJudgeTopLr;
        set => WriteParamField(ref _areaJudgeTopLr, value);
    }
    private short _areaJudgeTopLr;

}
