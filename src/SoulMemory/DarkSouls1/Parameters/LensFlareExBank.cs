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
public class LensFlareExBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I16)]
    public short LightDegRotX
    {
        get => _lightDegRotX;
        set => WriteParamField(ref _lightDegRotX, value);
    }
    private short _lightDegRotX;

    [ParamField(0x2, ParamType.I16)]
    public short LightDegRotY
    {
        get => _lightDegRotY;
        set => WriteParamField(ref _lightDegRotY, value);
    }
    private short _lightDegRotY;

    [ParamField(0x4, ParamType.I16)]
    public short ColR
    {
        get => _colR;
        set => WriteParamField(ref _colR, value);
    }
    private short _colR;

    [ParamField(0x6, ParamType.I16)]
    public short ColG
    {
        get => _colG;
        set => WriteParamField(ref _colG, value);
    }
    private short _colG;

    [ParamField(0x8, ParamType.I16)]
    public short ColB
    {
        get => _colB;
        set => WriteParamField(ref _colB, value);
    }
    private short _colB;

    [ParamField(0xA, ParamType.I16)]
    public short ColA
    {
        get => _colA;
        set => WriteParamField(ref _colA, value);
    }
    private short _colA;

    [ParamField(0xC, ParamType.F32)]
    public float LightDist
    {
        get => _lightDist;
        set => WriteParamField(ref _lightDist, value);
    }
    private float _lightDist;

}
