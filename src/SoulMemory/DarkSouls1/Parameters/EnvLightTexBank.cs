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
public class EnvLightTexBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I8)]
    public sbyte IsUse
    {
        get => _isUse;
        set => WriteParamField(ref _isUse, value);
    }
    private sbyte _isUse;

    [ParamField(0x1, ParamType.I8)]
    public sbyte AutoUpdate
    {
        get => _autoUpdate;
        set => WriteParamField(ref _autoUpdate, value);
    }
    private sbyte _autoUpdate;

    [ParamField(0x2, ParamType.Dummy8, 12)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

    [ParamField(0xE, ParamType.I16)]
    public short InvMulCol
    {
        get => _invMulCol;
        set => WriteParamField(ref _invMulCol, value);
    }
    private short _invMulCol;

    [ParamField(0x10, ParamType.I16)]
    public short ResNameIdDif0
    {
        get => _resNameIdDif0;
        set => WriteParamField(ref _resNameIdDif0, value);
    }
    private short _resNameIdDif0;

    [ParamField(0x12, ParamType.I16)]
    public short InvMulColDif0
    {
        get => _invMulColDif0;
        set => WriteParamField(ref _invMulColDif0, value);
    }
    private short _invMulColDif0;

    [ParamField(0x14, ParamType.F32)]
    public float SepcPowDif0
    {
        get => _sepcPowDif0;
        set => WriteParamField(ref _sepcPowDif0, value);
    }
    private float _sepcPowDif0;

    [ParamField(0x18, ParamType.Dummy8, 8)]
    public byte[] PadDif0
    {
        get => _padDif0;
        set => WriteParamField(ref _padDif0, value);
    }
    private byte[] _padDif0 = null!;

    [ParamField(0x20, ParamType.I16)]
    public short ResNameIdSpc0
    {
        get => _resNameIdSpc0;
        set => WriteParamField(ref _resNameIdSpc0, value);
    }
    private short _resNameIdSpc0;

    [ParamField(0x22, ParamType.I16)]
    public short InvMulColSpc0
    {
        get => _invMulColSpc0;
        set => WriteParamField(ref _invMulColSpc0, value);
    }
    private short _invMulColSpc0;

    [ParamField(0x24, ParamType.F32)]
    public float SepcPowSpc0
    {
        get => _sepcPowSpc0;
        set => WriteParamField(ref _sepcPowSpc0, value);
    }
    private float _sepcPowSpc0;

    [ParamField(0x28, ParamType.Dummy8, 8)]
    public byte[] PadSpc0
    {
        get => _padSpc0;
        set => WriteParamField(ref _padSpc0, value);
    }
    private byte[] _padSpc0 = null!;

    [ParamField(0x30, ParamType.I16)]
    public short ResNameIdSpc1
    {
        get => _resNameIdSpc1;
        set => WriteParamField(ref _resNameIdSpc1, value);
    }
    private short _resNameIdSpc1;

    [ParamField(0x32, ParamType.I16)]
    public short InvMulColSpc1
    {
        get => _invMulColSpc1;
        set => WriteParamField(ref _invMulColSpc1, value);
    }
    private short _invMulColSpc1;

    [ParamField(0x34, ParamType.F32)]
    public float SepcPowSpc1
    {
        get => _sepcPowSpc1;
        set => WriteParamField(ref _sepcPowSpc1, value);
    }
    private float _sepcPowSpc1;

    [ParamField(0x38, ParamType.Dummy8, 8)]
    public byte[] PadSpc1
    {
        get => _padSpc1;
        set => WriteParamField(ref _padSpc1, value);
    }
    private byte[] _padSpc1 = null!;

    [ParamField(0x40, ParamType.I16)]
    public short ResNameIdSpc2
    {
        get => _resNameIdSpc2;
        set => WriteParamField(ref _resNameIdSpc2, value);
    }
    private short _resNameIdSpc2;

    [ParamField(0x42, ParamType.I16)]
    public short InvMulColSpc2
    {
        get => _invMulColSpc2;
        set => WriteParamField(ref _invMulColSpc2, value);
    }
    private short _invMulColSpc2;

    [ParamField(0x44, ParamType.F32)]
    public float SepcPowSpc2
    {
        get => _sepcPowSpc2;
        set => WriteParamField(ref _sepcPowSpc2, value);
    }
    private float _sepcPowSpc2;

    [ParamField(0x48, ParamType.Dummy8, 8)]
    public byte[] PadSpc2
    {
        get => _padSpc2;
        set => WriteParamField(ref _padSpc2, value);
    }
    private byte[] _padSpc2 = null!;

    [ParamField(0x50, ParamType.I16)]
    public short ResNameIdSpc3
    {
        get => _resNameIdSpc3;
        set => WriteParamField(ref _resNameIdSpc3, value);
    }
    private short _resNameIdSpc3;

    [ParamField(0x52, ParamType.I16)]
    public short InvMulColSpc3
    {
        get => _invMulColSpc3;
        set => WriteParamField(ref _invMulColSpc3, value);
    }
    private short _invMulColSpc3;

    [ParamField(0x54, ParamType.F32)]
    public float SepcPowSpc3
    {
        get => _sepcPowSpc3;
        set => WriteParamField(ref _sepcPowSpc3, value);
    }
    private float _sepcPowSpc3;

    [ParamField(0x58, ParamType.Dummy8, 8)]
    public byte[] PadSpc3
    {
        get => _padSpc3;
        set => WriteParamField(ref _padSpc3, value);
    }
    private byte[] _padSpc3 = null!;

    [ParamField(0x60, ParamType.I16)]
    public short DegRotX00
    {
        get => _degRotX00;
        set => WriteParamField(ref _degRotX00, value);
    }
    private short _degRotX00;

    [ParamField(0x62, ParamType.I16)]
    public short DegRotY00
    {
        get => _degRotY00;
        set => WriteParamField(ref _degRotY00, value);
    }
    private short _degRotY00;

    [ParamField(0x64, ParamType.I16)]
    public short ColR00
    {
        get => _colR00;
        set => WriteParamField(ref _colR00, value);
    }
    private short _colR00;

    [ParamField(0x66, ParamType.I16)]
    public short ColG00
    {
        get => _colG00;
        set => WriteParamField(ref _colG00, value);
    }
    private short _colG00;

    [ParamField(0x68, ParamType.I16)]
    public short ColB00
    {
        get => _colB00;
        set => WriteParamField(ref _colB00, value);
    }
    private short _colB00;

    [ParamField(0x6A, ParamType.I16)]
    public short ColA00
    {
        get => _colA00;
        set => WriteParamField(ref _colA00, value);
    }
    private short _colA00;

    [ParamField(0x6C, ParamType.Dummy8, 4)]
    public byte[] Pad00
    {
        get => _pad00;
        set => WriteParamField(ref _pad00, value);
    }
    private byte[] _pad00 = null!;

    [ParamField(0x70, ParamType.I16)]
    public short DegRotX01
    {
        get => _degRotX01;
        set => WriteParamField(ref _degRotX01, value);
    }
    private short _degRotX01;

    [ParamField(0x72, ParamType.I16)]
    public short DegRotY01
    {
        get => _degRotY01;
        set => WriteParamField(ref _degRotY01, value);
    }
    private short _degRotY01;

    [ParamField(0x74, ParamType.I16)]
    public short ColR01
    {
        get => _colR01;
        set => WriteParamField(ref _colR01, value);
    }
    private short _colR01;

    [ParamField(0x76, ParamType.I16)]
    public short ColG01
    {
        get => _colG01;
        set => WriteParamField(ref _colG01, value);
    }
    private short _colG01;

    [ParamField(0x78, ParamType.I16)]
    public short ColB01
    {
        get => _colB01;
        set => WriteParamField(ref _colB01, value);
    }
    private short _colB01;

    [ParamField(0x7A, ParamType.I16)]
    public short ColA01
    {
        get => _colA01;
        set => WriteParamField(ref _colA01, value);
    }
    private short _colA01;

    [ParamField(0x7C, ParamType.Dummy8, 4)]
    public byte[] Pad01
    {
        get => _pad01;
        set => WriteParamField(ref _pad01, value);
    }
    private byte[] _pad01 = null!;

    [ParamField(0x80, ParamType.I16)]
    public short DegRotX02
    {
        get => _degRotX02;
        set => WriteParamField(ref _degRotX02, value);
    }
    private short _degRotX02;

    [ParamField(0x82, ParamType.I16)]
    public short DegRotY02
    {
        get => _degRotY02;
        set => WriteParamField(ref _degRotY02, value);
    }
    private short _degRotY02;

    [ParamField(0x84, ParamType.I16)]
    public short ColR02
    {
        get => _colR02;
        set => WriteParamField(ref _colR02, value);
    }
    private short _colR02;

    [ParamField(0x86, ParamType.I16)]
    public short ColG02
    {
        get => _colG02;
        set => WriteParamField(ref _colG02, value);
    }
    private short _colG02;

    [ParamField(0x88, ParamType.I16)]
    public short ColB02
    {
        get => _colB02;
        set => WriteParamField(ref _colB02, value);
    }
    private short _colB02;

    [ParamField(0x8A, ParamType.I16)]
    public short ColA02
    {
        get => _colA02;
        set => WriteParamField(ref _colA02, value);
    }
    private short _colA02;

    [ParamField(0x8C, ParamType.Dummy8, 4)]
    public byte[] Pad02
    {
        get => _pad02;
        set => WriteParamField(ref _pad02, value);
    }
    private byte[] _pad02 = null!;

    [ParamField(0x90, ParamType.I16)]
    public short DegRotX03
    {
        get => _degRotX03;
        set => WriteParamField(ref _degRotX03, value);
    }
    private short _degRotX03;

    [ParamField(0x92, ParamType.I16)]
    public short DegRotY03
    {
        get => _degRotY03;
        set => WriteParamField(ref _degRotY03, value);
    }
    private short _degRotY03;

    [ParamField(0x94, ParamType.I16)]
    public short ColR03
    {
        get => _colR03;
        set => WriteParamField(ref _colR03, value);
    }
    private short _colR03;

    [ParamField(0x96, ParamType.I16)]
    public short ColG03
    {
        get => _colG03;
        set => WriteParamField(ref _colG03, value);
    }
    private short _colG03;

    [ParamField(0x98, ParamType.I16)]
    public short ColB03
    {
        get => _colB03;
        set => WriteParamField(ref _colB03, value);
    }
    private short _colB03;

    [ParamField(0x9A, ParamType.I16)]
    public short ColA03
    {
        get => _colA03;
        set => WriteParamField(ref _colA03, value);
    }
    private short _colA03;

    [ParamField(0x9C, ParamType.Dummy8, 4)]
    public byte[] Pad03
    {
        get => _pad03;
        set => WriteParamField(ref _pad03, value);
    }
    private byte[] _pad03 = null!;

    [ParamField(0xA0, ParamType.I16)]
    public short DegRotX04
    {
        get => _degRotX04;
        set => WriteParamField(ref _degRotX04, value);
    }
    private short _degRotX04;

    [ParamField(0xA2, ParamType.I16)]
    public short DegRotY04
    {
        get => _degRotY04;
        set => WriteParamField(ref _degRotY04, value);
    }
    private short _degRotY04;

    [ParamField(0xA4, ParamType.I16)]
    public short ColR04
    {
        get => _colR04;
        set => WriteParamField(ref _colR04, value);
    }
    private short _colR04;

    [ParamField(0xA6, ParamType.I16)]
    public short ColG04
    {
        get => _colG04;
        set => WriteParamField(ref _colG04, value);
    }
    private short _colG04;

    [ParamField(0xA8, ParamType.I16)]
    public short ColB04
    {
        get => _colB04;
        set => WriteParamField(ref _colB04, value);
    }
    private short _colB04;

    [ParamField(0xAA, ParamType.I16)]
    public short ColA04
    {
        get => _colA04;
        set => WriteParamField(ref _colA04, value);
    }
    private short _colA04;

    [ParamField(0xAC, ParamType.Dummy8, 4)]
    public byte[] Pad04
    {
        get => _pad04;
        set => WriteParamField(ref _pad04, value);
    }
    private byte[] _pad04 = null!;

    [ParamField(0xB0, ParamType.I16)]
    public short DegRotX05
    {
        get => _degRotX05;
        set => WriteParamField(ref _degRotX05, value);
    }
    private short _degRotX05;

    [ParamField(0xB2, ParamType.I16)]
    public short DegRotY05
    {
        get => _degRotY05;
        set => WriteParamField(ref _degRotY05, value);
    }
    private short _degRotY05;

    [ParamField(0xB4, ParamType.I16)]
    public short ColR05
    {
        get => _colR05;
        set => WriteParamField(ref _colR05, value);
    }
    private short _colR05;

    [ParamField(0xB6, ParamType.I16)]
    public short ColG05
    {
        get => _colG05;
        set => WriteParamField(ref _colG05, value);
    }
    private short _colG05;

    [ParamField(0xB8, ParamType.I16)]
    public short ColB05
    {
        get => _colB05;
        set => WriteParamField(ref _colB05, value);
    }
    private short _colB05;

    [ParamField(0xBA, ParamType.I16)]
    public short ColA05
    {
        get => _colA05;
        set => WriteParamField(ref _colA05, value);
    }
    private short _colA05;

    [ParamField(0xBC, ParamType.Dummy8, 4)]
    public byte[] Pad05
    {
        get => _pad05;
        set => WriteParamField(ref _pad05, value);
    }
    private byte[] _pad05 = null!;

    [ParamField(0xC0, ParamType.I16)]
    public short DegRotX06
    {
        get => _degRotX06;
        set => WriteParamField(ref _degRotX06, value);
    }
    private short _degRotX06;

    [ParamField(0xC2, ParamType.I16)]
    public short DegRotY06
    {
        get => _degRotY06;
        set => WriteParamField(ref _degRotY06, value);
    }
    private short _degRotY06;

    [ParamField(0xC4, ParamType.I16)]
    public short ColR06
    {
        get => _colR06;
        set => WriteParamField(ref _colR06, value);
    }
    private short _colR06;

    [ParamField(0xC6, ParamType.I16)]
    public short ColG06
    {
        get => _colG06;
        set => WriteParamField(ref _colG06, value);
    }
    private short _colG06;

    [ParamField(0xC8, ParamType.I16)]
    public short ColB06
    {
        get => _colB06;
        set => WriteParamField(ref _colB06, value);
    }
    private short _colB06;

    [ParamField(0xCA, ParamType.I16)]
    public short ColA06
    {
        get => _colA06;
        set => WriteParamField(ref _colA06, value);
    }
    private short _colA06;

    [ParamField(0xCC, ParamType.Dummy8, 4)]
    public byte[] Pad06
    {
        get => _pad06;
        set => WriteParamField(ref _pad06, value);
    }
    private byte[] _pad06 = null!;

    [ParamField(0xD0, ParamType.I16)]
    public short DegRotX07
    {
        get => _degRotX07;
        set => WriteParamField(ref _degRotX07, value);
    }
    private short _degRotX07;

    [ParamField(0xD2, ParamType.I16)]
    public short DegRotY07
    {
        get => _degRotY07;
        set => WriteParamField(ref _degRotY07, value);
    }
    private short _degRotY07;

    [ParamField(0xD4, ParamType.I16)]
    public short ColR07
    {
        get => _colR07;
        set => WriteParamField(ref _colR07, value);
    }
    private short _colR07;

    [ParamField(0xD6, ParamType.I16)]
    public short ColG07
    {
        get => _colG07;
        set => WriteParamField(ref _colG07, value);
    }
    private short _colG07;

    [ParamField(0xD8, ParamType.I16)]
    public short ColB07
    {
        get => _colB07;
        set => WriteParamField(ref _colB07, value);
    }
    private short _colB07;

    [ParamField(0xDA, ParamType.I16)]
    public short ColA07
    {
        get => _colA07;
        set => WriteParamField(ref _colA07, value);
    }
    private short _colA07;

    [ParamField(0xDC, ParamType.Dummy8, 4)]
    public byte[] Pad07
    {
        get => _pad07;
        set => WriteParamField(ref _pad07, value);
    }
    private byte[] _pad07 = null!;

    [ParamField(0xE0, ParamType.I16)]
    public short DegRotX08
    {
        get => _degRotX08;
        set => WriteParamField(ref _degRotX08, value);
    }
    private short _degRotX08;

    [ParamField(0xE2, ParamType.I16)]
    public short DegRotY08
    {
        get => _degRotY08;
        set => WriteParamField(ref _degRotY08, value);
    }
    private short _degRotY08;

    [ParamField(0xE4, ParamType.I16)]
    public short ColR08
    {
        get => _colR08;
        set => WriteParamField(ref _colR08, value);
    }
    private short _colR08;

    [ParamField(0xE6, ParamType.I16)]
    public short ColG08
    {
        get => _colG08;
        set => WriteParamField(ref _colG08, value);
    }
    private short _colG08;

    [ParamField(0xE8, ParamType.I16)]
    public short ColB08
    {
        get => _colB08;
        set => WriteParamField(ref _colB08, value);
    }
    private short _colB08;

    [ParamField(0xEA, ParamType.I16)]
    public short ColA08
    {
        get => _colA08;
        set => WriteParamField(ref _colA08, value);
    }
    private short _colA08;

    [ParamField(0xEC, ParamType.Dummy8, 4)]
    public byte[] Pad08
    {
        get => _pad08;
        set => WriteParamField(ref _pad08, value);
    }
    private byte[] _pad08 = null!;

    [ParamField(0xF0, ParamType.I16)]
    public short DegRotX09
    {
        get => _degRotX09;
        set => WriteParamField(ref _degRotX09, value);
    }
    private short _degRotX09;

    [ParamField(0xF2, ParamType.I16)]
    public short DegRotY09
    {
        get => _degRotY09;
        set => WriteParamField(ref _degRotY09, value);
    }
    private short _degRotY09;

    [ParamField(0xF4, ParamType.I16)]
    public short ColR09
    {
        get => _colR09;
        set => WriteParamField(ref _colR09, value);
    }
    private short _colR09;

    [ParamField(0xF6, ParamType.I16)]
    public short ColG09
    {
        get => _colG09;
        set => WriteParamField(ref _colG09, value);
    }
    private short _colG09;

    [ParamField(0xF8, ParamType.I16)]
    public short ColB09
    {
        get => _colB09;
        set => WriteParamField(ref _colB09, value);
    }
    private short _colB09;

    [ParamField(0xFA, ParamType.I16)]
    public short ColA09
    {
        get => _colA09;
        set => WriteParamField(ref _colA09, value);
    }
    private short _colA09;

    [ParamField(0xFC, ParamType.Dummy8, 4)]
    public byte[] Pad09
    {
        get => _pad09;
        set => WriteParamField(ref _pad09, value);
    }
    private byte[] _pad09 = null!;

}
