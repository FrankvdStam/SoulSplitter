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
public class LightBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I16)]
    public short DegRotX0
    {
        get => _degRotX0;
        set => WriteParamField(ref _degRotX0, value);
    }
    private short _degRotX0;

    [ParamField(0x2, ParamType.I16)]
    public short DegRotY0
    {
        get => _degRotY0;
        set => WriteParamField(ref _degRotY0, value);
    }
    private short _degRotY0;

    [ParamField(0x4, ParamType.I16)]
    public short ColR0
    {
        get => _colR0;
        set => WriteParamField(ref _colR0, value);
    }
    private short _colR0;

    [ParamField(0x6, ParamType.I16)]
    public short ColG0
    {
        get => _colG0;
        set => WriteParamField(ref _colG0, value);
    }
    private short _colG0;

    [ParamField(0x8, ParamType.I16)]
    public short ColB0
    {
        get => _colB0;
        set => WriteParamField(ref _colB0, value);
    }
    private short _colB0;

    [ParamField(0xA, ParamType.I16)]
    public short ColA0
    {
        get => _colA0;
        set => WriteParamField(ref _colA0, value);
    }
    private short _colA0;

    [ParamField(0xC, ParamType.I16)]
    public short DegRotX1
    {
        get => _degRotX1;
        set => WriteParamField(ref _degRotX1, value);
    }
    private short _degRotX1;

    [ParamField(0xE, ParamType.I16)]
    public short DegRotY1
    {
        get => _degRotY1;
        set => WriteParamField(ref _degRotY1, value);
    }
    private short _degRotY1;

    [ParamField(0x10, ParamType.I16)]
    public short ColR1
    {
        get => _colR1;
        set => WriteParamField(ref _colR1, value);
    }
    private short _colR1;

    [ParamField(0x12, ParamType.I16)]
    public short ColG1
    {
        get => _colG1;
        set => WriteParamField(ref _colG1, value);
    }
    private short _colG1;

    [ParamField(0x14, ParamType.I16)]
    public short ColB1
    {
        get => _colB1;
        set => WriteParamField(ref _colB1, value);
    }
    private short _colB1;

    [ParamField(0x16, ParamType.I16)]
    public short ColA1
    {
        get => _colA1;
        set => WriteParamField(ref _colA1, value);
    }
    private short _colA1;

    [ParamField(0x18, ParamType.I16)]
    public short DegRotX2
    {
        get => _degRotX2;
        set => WriteParamField(ref _degRotX2, value);
    }
    private short _degRotX2;

    [ParamField(0x1A, ParamType.I16)]
    public short DegRotY2
    {
        get => _degRotY2;
        set => WriteParamField(ref _degRotY2, value);
    }
    private short _degRotY2;

    [ParamField(0x1C, ParamType.I16)]
    public short ColR2
    {
        get => _colR2;
        set => WriteParamField(ref _colR2, value);
    }
    private short _colR2;

    [ParamField(0x1E, ParamType.I16)]
    public short ColG2
    {
        get => _colG2;
        set => WriteParamField(ref _colG2, value);
    }
    private short _colG2;

    [ParamField(0x20, ParamType.I16)]
    public short ColB2
    {
        get => _colB2;
        set => WriteParamField(ref _colB2, value);
    }
    private short _colB2;

    [ParamField(0x22, ParamType.I16)]
    public short ColA2
    {
        get => _colA2;
        set => WriteParamField(ref _colA2, value);
    }
    private short _colA2;

    [ParamField(0x24, ParamType.I16)]
    public short ColRu
    {
        get => _colRu;
        set => WriteParamField(ref _colRu, value);
    }
    private short _colRu;

    [ParamField(0x26, ParamType.I16)]
    public short ColGu
    {
        get => _colGu;
        set => WriteParamField(ref _colGu, value);
    }
    private short _colGu;

    [ParamField(0x28, ParamType.I16)]
    public short ColBu
    {
        get => _colBu;
        set => WriteParamField(ref _colBu, value);
    }
    private short _colBu;

    [ParamField(0x2A, ParamType.I16)]
    public short ColAu
    {
        get => _colAu;
        set => WriteParamField(ref _colAu, value);
    }
    private short _colAu;

    [ParamField(0x2C, ParamType.I16)]
    public short ColRd
    {
        get => _colRd;
        set => WriteParamField(ref _colRd, value);
    }
    private short _colRd;

    [ParamField(0x2E, ParamType.I16)]
    public short ColGd
    {
        get => _colGd;
        set => WriteParamField(ref _colGd, value);
    }
    private short _colGd;

    [ParamField(0x30, ParamType.I16)]
    public short ColBd
    {
        get => _colBd;
        set => WriteParamField(ref _colBd, value);
    }
    private short _colBd;

    [ParamField(0x32, ParamType.I16)]
    public short ColAd
    {
        get => _colAd;
        set => WriteParamField(ref _colAd, value);
    }
    private short _colAd;

    [ParamField(0x34, ParamType.I16)]
    public short DegRotXs
    {
        get => _degRotXs;
        set => WriteParamField(ref _degRotXs, value);
    }
    private short _degRotXs;

    [ParamField(0x36, ParamType.I16)]
    public short DegRotYs
    {
        get => _degRotYs;
        set => WriteParamField(ref _degRotYs, value);
    }
    private short _degRotYs;

    [ParamField(0x38, ParamType.I16)]
    public short ColRs
    {
        get => _colRs;
        set => WriteParamField(ref _colRs, value);
    }
    private short _colRs;

    [ParamField(0x3A, ParamType.I16)]
    public short ColGs
    {
        get => _colGs;
        set => WriteParamField(ref _colGs, value);
    }
    private short _colGs;

    [ParamField(0x3C, ParamType.I16)]
    public short ColBs
    {
        get => _colBs;
        set => WriteParamField(ref _colBs, value);
    }
    private short _colBs;

    [ParamField(0x3E, ParamType.I16)]
    public short ColAs
    {
        get => _colAs;
        set => WriteParamField(ref _colAs, value);
    }
    private short _colAs;

    [ParamField(0x40, ParamType.I16)]
    public short EnvDifColR
    {
        get => _envDifColR;
        set => WriteParamField(ref _envDifColR, value);
    }
    private short _envDifColR;

    [ParamField(0x42, ParamType.I16)]
    public short EnvDifColG
    {
        get => _envDifColG;
        set => WriteParamField(ref _envDifColG, value);
    }
    private short _envDifColG;

    [ParamField(0x44, ParamType.I16)]
    public short EnvDifColB
    {
        get => _envDifColB;
        set => WriteParamField(ref _envDifColB, value);
    }
    private short _envDifColB;

    [ParamField(0x46, ParamType.I16)]
    public short EnvDifColA
    {
        get => _envDifColA;
        set => WriteParamField(ref _envDifColA, value);
    }
    private short _envDifColA;

    [ParamField(0x48, ParamType.I16)]
    public short EnvSpcColR
    {
        get => _envSpcColR;
        set => WriteParamField(ref _envSpcColR, value);
    }
    private short _envSpcColR;

    [ParamField(0x4A, ParamType.I16)]
    public short EnvSpcColG
    {
        get => _envSpcColG;
        set => WriteParamField(ref _envSpcColG, value);
    }
    private short _envSpcColG;

    [ParamField(0x4C, ParamType.I16)]
    public short EnvSpcColB
    {
        get => _envSpcColB;
        set => WriteParamField(ref _envSpcColB, value);
    }
    private short _envSpcColB;

    [ParamField(0x4E, ParamType.I16)]
    public short EnvSpcColA
    {
        get => _envSpcColA;
        set => WriteParamField(ref _envSpcColA, value);
    }
    private short _envSpcColA;

    [ParamField(0x50, ParamType.I16)]
    public short EnvDif
    {
        get => _envDif;
        set => WriteParamField(ref _envDif, value);
    }
    private short _envDif;

    [ParamField(0x52, ParamType.I16)]
    public short EnvSpc0
    {
        get => _envSpc0;
        set => WriteParamField(ref _envSpc0, value);
    }
    private short _envSpc0;

    [ParamField(0x54, ParamType.I16)]
    public short EnvSpc1
    {
        get => _envSpc1;
        set => WriteParamField(ref _envSpc1, value);
    }
    private short _envSpc1;

    [ParamField(0x56, ParamType.I16)]
    public short EnvSpc2
    {
        get => _envSpc2;
        set => WriteParamField(ref _envSpc2, value);
    }
    private short _envSpc2;

    [ParamField(0x58, ParamType.I16)]
    public short EnvSpc3
    {
        get => _envSpc3;
        set => WriteParamField(ref _envSpc3, value);
    }
    private short _envSpc3;

    [ParamField(0x5A, ParamType.Dummy8, 2)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
