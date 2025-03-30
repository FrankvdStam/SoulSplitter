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
public class LensFlareBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I8)]
    public sbyte TexId
    {
        get => _texId;
        set => WriteParamField(ref _texId, value);
    }
    private sbyte _texId;

    [ParamField(0x1, ParamType.U8)]
    public byte IsFlare
    {
        get => _isFlare;
        set => WriteParamField(ref _isFlare, value);
    }
    private byte _isFlare;

    [ParamField(0x2, ParamType.U8)]
    public byte EnableRoll
    {
        get => _enableRoll;
        set => WriteParamField(ref _enableRoll, value);
    }
    private byte _enableRoll;

    [ParamField(0x3, ParamType.U8)]
    public byte EnableScale
    {
        get => _enableScale;
        set => WriteParamField(ref _enableScale, value);
    }
    private byte _enableScale;

    [ParamField(0x4, ParamType.F32)]
    public float LocateDistRate
    {
        get => _locateDistRate;
        set => WriteParamField(ref _locateDistRate, value);
    }
    private float _locateDistRate;

    [ParamField(0x8, ParamType.F32)]
    public float TexScale
    {
        get => _texScale;
        set => WriteParamField(ref _texScale, value);
    }
    private float _texScale;

    [ParamField(0xC, ParamType.I16)]
    public short ColR
    {
        get => _colR;
        set => WriteParamField(ref _colR, value);
    }
    private short _colR;

    [ParamField(0xE, ParamType.I16)]
    public short ColG
    {
        get => _colG;
        set => WriteParamField(ref _colG, value);
    }
    private short _colG;

    [ParamField(0x10, ParamType.I16)]
    public short ColB
    {
        get => _colB;
        set => WriteParamField(ref _colB, value);
    }
    private short _colB;

    [ParamField(0x12, ParamType.I16)]
    public short ColA
    {
        get => _colA;
        set => WriteParamField(ref _colA, value);
    }
    private short _colA;

}
