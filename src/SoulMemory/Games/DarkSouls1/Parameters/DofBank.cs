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
public class DofBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float FarDofBegin
    {
        get => _farDofBegin;
        set => WriteParamField(ref _farDofBegin, value);
    }
    private float _farDofBegin;

    [ParamField(0x4, ParamType.F32)]
    public float FarDofEnd
    {
        get => _farDofEnd;
        set => WriteParamField(ref _farDofEnd, value);
    }
    private float _farDofEnd;

    [ParamField(0x8, ParamType.U8)]
    public byte FarDofMul
    {
        get => _farDofMul;
        set => WriteParamField(ref _farDofMul, value);
    }
    private byte _farDofMul;

    [ParamField(0x9, ParamType.Dummy8, 3)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

    [ParamField(0xC, ParamType.F32)]
    public float NearDofBegin
    {
        get => _nearDofBegin;
        set => WriteParamField(ref _nearDofBegin, value);
    }
    private float _nearDofBegin;

    [ParamField(0x10, ParamType.F32)]
    public float NearDofEnd
    {
        get => _nearDofEnd;
        set => WriteParamField(ref _nearDofEnd, value);
    }
    private float _nearDofEnd;

    [ParamField(0x14, ParamType.U8)]
    public byte NearDofMul
    {
        get => _nearDofMul;
        set => WriteParamField(ref _nearDofMul, value);
    }
    private byte _nearDofMul;

    [ParamField(0x15, ParamType.Dummy8, 3)]
    public byte[] Pad1
    {
        get => _pad1;
        set => WriteParamField(ref _pad1, value);
    }
    private byte[] _pad1 = null!;

    [ParamField(0x18, ParamType.F32)]
    public float DispersionSq
    {
        get => _dispersionSq;
        set => WriteParamField(ref _dispersionSq, value);
    }
    private float _dispersionSq;

}
