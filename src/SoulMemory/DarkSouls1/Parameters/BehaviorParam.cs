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
public class BehaviorParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int VariationId
    {
        get => _variationId;
        set => WriteParamField(ref _variationId, value);
    }
    private int _variationId;

    [ParamField(0x4, ParamType.I32)]
    public int BehaviorJudgeId
    {
        get => _behaviorJudgeId;
        set => WriteParamField(ref _behaviorJudgeId, value);
    }
    private int _behaviorJudgeId;

    [ParamField(0x8, ParamType.U8)]
    public byte EzStateBehaviorTypeOld
    {
        get => _ezStateBehaviorTypeOld;
        set => WriteParamField(ref _ezStateBehaviorTypeOld, value);
    }
    private byte _ezStateBehaviorTypeOld;

    [ParamField(0x9, ParamType.U8)]
    public byte RefType
    {
        get => _refType;
        set => WriteParamField(ref _refType, value);
    }
    private byte _refType;

    [ParamField(0xA, ParamType.Dummy8, 2)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

    [ParamField(0xC, ParamType.I32)]
    public int RefId
    {
        get => _refId;
        set => WriteParamField(ref _refId, value);
    }
    private int _refId;

    [ParamField(0x10, ParamType.I32)]
    public int SfxVariationId
    {
        get => _sfxVariationId;
        set => WriteParamField(ref _sfxVariationId, value);
    }
    private int _sfxVariationId;

    [ParamField(0x14, ParamType.I32)]
    public int Stamina
    {
        get => _stamina;
        set => WriteParamField(ref _stamina, value);
    }
    private int _stamina;

    [ParamField(0x18, ParamType.I32)]
    public int Mp
    {
        get => _mp;
        set => WriteParamField(ref _mp, value);
    }
    private int _mp;

    [ParamField(0x1C, ParamType.U8)]
    public byte Category
    {
        get => _category;
        set => WriteParamField(ref _category, value);
    }
    private byte _category;

    [ParamField(0x1D, ParamType.U8)]
    public byte HeroPoint
    {
        get => _heroPoint;
        set => WriteParamField(ref _heroPoint, value);
    }
    private byte _heroPoint;

    [ParamField(0x1E, ParamType.Dummy8, 2)]
    public byte[] Pad1
    {
        get => _pad1;
        set => WriteParamField(ref _pad1, value);
    }
    private byte[] _pad1 = null!;

}
