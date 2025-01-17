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
public class FaceGenParam : BaseParam
{
    public FaceGenParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

    [ParamField(0x0, ParamType.U8)]
    public byte FaceGeoData00
    {
        get => _FaceGeoData00;
        set => WriteParamField(ref _FaceGeoData00, value);
    }
    private byte _FaceGeoData00;

    [ParamField(0x1, ParamType.U8)]
    public byte FaceGeoData01
    {
        get => _FaceGeoData01;
        set => WriteParamField(ref _FaceGeoData01, value);
    }
    private byte _FaceGeoData01;

    [ParamField(0x2, ParamType.U8)]
    public byte FaceGeoData02
    {
        get => _FaceGeoData02;
        set => WriteParamField(ref _FaceGeoData02, value);
    }
    private byte _FaceGeoData02;

    [ParamField(0x3, ParamType.U8)]
    public byte FaceGeoData03
    {
        get => _FaceGeoData03;
        set => WriteParamField(ref _FaceGeoData03, value);
    }
    private byte _FaceGeoData03;

    [ParamField(0x4, ParamType.U8)]
    public byte FaceGeoData04
    {
        get => _FaceGeoData04;
        set => WriteParamField(ref _FaceGeoData04, value);
    }
    private byte _FaceGeoData04;

    [ParamField(0x5, ParamType.U8)]
    public byte FaceGeoData05
    {
        get => _FaceGeoData05;
        set => WriteParamField(ref _FaceGeoData05, value);
    }
    private byte _FaceGeoData05;

    [ParamField(0x6, ParamType.U8)]
    public byte FaceGeoData06
    {
        get => _FaceGeoData06;
        set => WriteParamField(ref _FaceGeoData06, value);
    }
    private byte _FaceGeoData06;

    [ParamField(0x7, ParamType.U8)]
    public byte FaceGeoData07
    {
        get => _FaceGeoData07;
        set => WriteParamField(ref _FaceGeoData07, value);
    }
    private byte _FaceGeoData07;

    [ParamField(0x8, ParamType.U8)]
    public byte FaceGeoData08
    {
        get => _FaceGeoData08;
        set => WriteParamField(ref _FaceGeoData08, value);
    }
    private byte _FaceGeoData08;

    [ParamField(0x9, ParamType.U8)]
    public byte FaceGeoData09
    {
        get => _FaceGeoData09;
        set => WriteParamField(ref _FaceGeoData09, value);
    }
    private byte _FaceGeoData09;

    [ParamField(0xA, ParamType.U8)]
    public byte FaceGeoData10
    {
        get => _FaceGeoData10;
        set => WriteParamField(ref _FaceGeoData10, value);
    }
    private byte _FaceGeoData10;

    [ParamField(0xB, ParamType.U8)]
    public byte FaceGeoData11
    {
        get => _FaceGeoData11;
        set => WriteParamField(ref _FaceGeoData11, value);
    }
    private byte _FaceGeoData11;

    [ParamField(0xC, ParamType.U8)]
    public byte FaceGeoData12
    {
        get => _FaceGeoData12;
        set => WriteParamField(ref _FaceGeoData12, value);
    }
    private byte _FaceGeoData12;

    [ParamField(0xD, ParamType.U8)]
    public byte FaceGeoData13
    {
        get => _FaceGeoData13;
        set => WriteParamField(ref _FaceGeoData13, value);
    }
    private byte _FaceGeoData13;

    [ParamField(0xE, ParamType.U8)]
    public byte FaceGeoData14
    {
        get => _FaceGeoData14;
        set => WriteParamField(ref _FaceGeoData14, value);
    }
    private byte _FaceGeoData14;

    [ParamField(0xF, ParamType.U8)]
    public byte FaceGeoData15
    {
        get => _FaceGeoData15;
        set => WriteParamField(ref _FaceGeoData15, value);
    }
    private byte _FaceGeoData15;

    [ParamField(0x10, ParamType.U8)]
    public byte FaceGeoData16
    {
        get => _FaceGeoData16;
        set => WriteParamField(ref _FaceGeoData16, value);
    }
    private byte _FaceGeoData16;

    [ParamField(0x11, ParamType.U8)]
    public byte FaceGeoData17
    {
        get => _FaceGeoData17;
        set => WriteParamField(ref _FaceGeoData17, value);
    }
    private byte _FaceGeoData17;

    [ParamField(0x12, ParamType.U8)]
    public byte FaceGeoData18
    {
        get => _FaceGeoData18;
        set => WriteParamField(ref _FaceGeoData18, value);
    }
    private byte _FaceGeoData18;

    [ParamField(0x13, ParamType.U8)]
    public byte FaceGeoData19
    {
        get => _FaceGeoData19;
        set => WriteParamField(ref _FaceGeoData19, value);
    }
    private byte _FaceGeoData19;

    [ParamField(0x14, ParamType.U8)]
    public byte FaceGeoData20
    {
        get => _FaceGeoData20;
        set => WriteParamField(ref _FaceGeoData20, value);
    }
    private byte _FaceGeoData20;

    [ParamField(0x15, ParamType.U8)]
    public byte FaceGeoData21
    {
        get => _FaceGeoData21;
        set => WriteParamField(ref _FaceGeoData21, value);
    }
    private byte _FaceGeoData21;

    [ParamField(0x16, ParamType.U8)]
    public byte FaceGeoData22
    {
        get => _FaceGeoData22;
        set => WriteParamField(ref _FaceGeoData22, value);
    }
    private byte _FaceGeoData22;

    [ParamField(0x17, ParamType.U8)]
    public byte FaceGeoData23
    {
        get => _FaceGeoData23;
        set => WriteParamField(ref _FaceGeoData23, value);
    }
    private byte _FaceGeoData23;

    [ParamField(0x18, ParamType.U8)]
    public byte FaceGeoData24
    {
        get => _FaceGeoData24;
        set => WriteParamField(ref _FaceGeoData24, value);
    }
    private byte _FaceGeoData24;

    [ParamField(0x19, ParamType.U8)]
    public byte FaceGeoData25
    {
        get => _FaceGeoData25;
        set => WriteParamField(ref _FaceGeoData25, value);
    }
    private byte _FaceGeoData25;

    [ParamField(0x1A, ParamType.U8)]
    public byte FaceGeoData26
    {
        get => _FaceGeoData26;
        set => WriteParamField(ref _FaceGeoData26, value);
    }
    private byte _FaceGeoData26;

    [ParamField(0x1B, ParamType.U8)]
    public byte FaceGeoData27
    {
        get => _FaceGeoData27;
        set => WriteParamField(ref _FaceGeoData27, value);
    }
    private byte _FaceGeoData27;

    [ParamField(0x1C, ParamType.U8)]
    public byte FaceGeoData28
    {
        get => _FaceGeoData28;
        set => WriteParamField(ref _FaceGeoData28, value);
    }
    private byte _FaceGeoData28;

    [ParamField(0x1D, ParamType.U8)]
    public byte FaceGeoData29
    {
        get => _FaceGeoData29;
        set => WriteParamField(ref _FaceGeoData29, value);
    }
    private byte _FaceGeoData29;

    [ParamField(0x1E, ParamType.U8)]
    public byte FaceGeoData30
    {
        get => _FaceGeoData30;
        set => WriteParamField(ref _FaceGeoData30, value);
    }
    private byte _FaceGeoData30;

    [ParamField(0x1F, ParamType.U8)]
    public byte FaceGeoData31
    {
        get => _FaceGeoData31;
        set => WriteParamField(ref _FaceGeoData31, value);
    }
    private byte _FaceGeoData31;

    [ParamField(0x20, ParamType.U8)]
    public byte FaceGeoData32
    {
        get => _FaceGeoData32;
        set => WriteParamField(ref _FaceGeoData32, value);
    }
    private byte _FaceGeoData32;

    [ParamField(0x21, ParamType.U8)]
    public byte FaceGeoData33
    {
        get => _FaceGeoData33;
        set => WriteParamField(ref _FaceGeoData33, value);
    }
    private byte _FaceGeoData33;

    [ParamField(0x22, ParamType.U8)]
    public byte FaceGeoData34
    {
        get => _FaceGeoData34;
        set => WriteParamField(ref _FaceGeoData34, value);
    }
    private byte _FaceGeoData34;

    [ParamField(0x23, ParamType.U8)]
    public byte FaceGeoData35
    {
        get => _FaceGeoData35;
        set => WriteParamField(ref _FaceGeoData35, value);
    }
    private byte _FaceGeoData35;

    [ParamField(0x24, ParamType.U8)]
    public byte FaceGeoData36
    {
        get => _FaceGeoData36;
        set => WriteParamField(ref _FaceGeoData36, value);
    }
    private byte _FaceGeoData36;

    [ParamField(0x25, ParamType.U8)]
    public byte FaceGeoData37
    {
        get => _FaceGeoData37;
        set => WriteParamField(ref _FaceGeoData37, value);
    }
    private byte _FaceGeoData37;

    [ParamField(0x26, ParamType.U8)]
    public byte FaceGeoData38
    {
        get => _FaceGeoData38;
        set => WriteParamField(ref _FaceGeoData38, value);
    }
    private byte _FaceGeoData38;

    [ParamField(0x27, ParamType.U8)]
    public byte FaceGeoData39
    {
        get => _FaceGeoData39;
        set => WriteParamField(ref _FaceGeoData39, value);
    }
    private byte _FaceGeoData39;

    [ParamField(0x28, ParamType.U8)]
    public byte FaceGeoData40
    {
        get => _FaceGeoData40;
        set => WriteParamField(ref _FaceGeoData40, value);
    }
    private byte _FaceGeoData40;

    [ParamField(0x29, ParamType.U8)]
    public byte FaceGeoData41
    {
        get => _FaceGeoData41;
        set => WriteParamField(ref _FaceGeoData41, value);
    }
    private byte _FaceGeoData41;

    [ParamField(0x2A, ParamType.U8)]
    public byte FaceGeoData42
    {
        get => _FaceGeoData42;
        set => WriteParamField(ref _FaceGeoData42, value);
    }
    private byte _FaceGeoData42;

    [ParamField(0x2B, ParamType.U8)]
    public byte FaceGeoData43
    {
        get => _FaceGeoData43;
        set => WriteParamField(ref _FaceGeoData43, value);
    }
    private byte _FaceGeoData43;

    [ParamField(0x2C, ParamType.U8)]
    public byte FaceGeoData44
    {
        get => _FaceGeoData44;
        set => WriteParamField(ref _FaceGeoData44, value);
    }
    private byte _FaceGeoData44;

    [ParamField(0x2D, ParamType.U8)]
    public byte FaceGeoData45
    {
        get => _FaceGeoData45;
        set => WriteParamField(ref _FaceGeoData45, value);
    }
    private byte _FaceGeoData45;

    [ParamField(0x2E, ParamType.U8)]
    public byte FaceGeoData46
    {
        get => _FaceGeoData46;
        set => WriteParamField(ref _FaceGeoData46, value);
    }
    private byte _FaceGeoData46;

    [ParamField(0x2F, ParamType.U8)]
    public byte FaceGeoData47
    {
        get => _FaceGeoData47;
        set => WriteParamField(ref _FaceGeoData47, value);
    }
    private byte _FaceGeoData47;

    [ParamField(0x30, ParamType.U8)]
    public byte FaceGeoData48
    {
        get => _FaceGeoData48;
        set => WriteParamField(ref _FaceGeoData48, value);
    }
    private byte _FaceGeoData48;

    [ParamField(0x31, ParamType.U8)]
    public byte FaceGeoData49
    {
        get => _FaceGeoData49;
        set => WriteParamField(ref _FaceGeoData49, value);
    }
    private byte _FaceGeoData49;

    [ParamField(0x32, ParamType.U8)]
    public byte FaceTexData00
    {
        get => _FaceTexData00;
        set => WriteParamField(ref _FaceTexData00, value);
    }
    private byte _FaceTexData00;

    [ParamField(0x33, ParamType.U8)]
    public byte FaceTexData01
    {
        get => _FaceTexData01;
        set => WriteParamField(ref _FaceTexData01, value);
    }
    private byte _FaceTexData01;

    [ParamField(0x34, ParamType.U8)]
    public byte FaceTexData02
    {
        get => _FaceTexData02;
        set => WriteParamField(ref _FaceTexData02, value);
    }
    private byte _FaceTexData02;

    [ParamField(0x35, ParamType.U8)]
    public byte FaceTexData03
    {
        get => _FaceTexData03;
        set => WriteParamField(ref _FaceTexData03, value);
    }
    private byte _FaceTexData03;

    [ParamField(0x36, ParamType.U8)]
    public byte FaceTexData04
    {
        get => _FaceTexData04;
        set => WriteParamField(ref _FaceTexData04, value);
    }
    private byte _FaceTexData04;

    [ParamField(0x37, ParamType.U8)]
    public byte FaceTexData05
    {
        get => _FaceTexData05;
        set => WriteParamField(ref _FaceTexData05, value);
    }
    private byte _FaceTexData05;

    [ParamField(0x38, ParamType.U8)]
    public byte FaceTexData06
    {
        get => _FaceTexData06;
        set => WriteParamField(ref _FaceTexData06, value);
    }
    private byte _FaceTexData06;

    [ParamField(0x39, ParamType.U8)]
    public byte FaceTexData07
    {
        get => _FaceTexData07;
        set => WriteParamField(ref _FaceTexData07, value);
    }
    private byte _FaceTexData07;

    [ParamField(0x3A, ParamType.U8)]
    public byte FaceTexData08
    {
        get => _FaceTexData08;
        set => WriteParamField(ref _FaceTexData08, value);
    }
    private byte _FaceTexData08;

    [ParamField(0x3B, ParamType.U8)]
    public byte FaceTexData09
    {
        get => _FaceTexData09;
        set => WriteParamField(ref _FaceTexData09, value);
    }
    private byte _FaceTexData09;

    [ParamField(0x3C, ParamType.U8)]
    public byte FaceTexData10
    {
        get => _FaceTexData10;
        set => WriteParamField(ref _FaceTexData10, value);
    }
    private byte _FaceTexData10;

    [ParamField(0x3D, ParamType.U8)]
    public byte FaceTexData11
    {
        get => _FaceTexData11;
        set => WriteParamField(ref _FaceTexData11, value);
    }
    private byte _FaceTexData11;

    [ParamField(0x3E, ParamType.U8)]
    public byte FaceTexData12
    {
        get => _FaceTexData12;
        set => WriteParamField(ref _FaceTexData12, value);
    }
    private byte _FaceTexData12;

    [ParamField(0x3F, ParamType.U8)]
    public byte FaceTexData13
    {
        get => _FaceTexData13;
        set => WriteParamField(ref _FaceTexData13, value);
    }
    private byte _FaceTexData13;

    [ParamField(0x40, ParamType.U8)]
    public byte FaceTexData14
    {
        get => _FaceTexData14;
        set => WriteParamField(ref _FaceTexData14, value);
    }
    private byte _FaceTexData14;

    [ParamField(0x41, ParamType.U8)]
    public byte FaceTexData15
    {
        get => _FaceTexData15;
        set => WriteParamField(ref _FaceTexData15, value);
    }
    private byte _FaceTexData15;

    [ParamField(0x42, ParamType.U8)]
    public byte FaceTexData16
    {
        get => _FaceTexData16;
        set => WriteParamField(ref _FaceTexData16, value);
    }
    private byte _FaceTexData16;

    [ParamField(0x43, ParamType.U8)]
    public byte FaceTexData17
    {
        get => _FaceTexData17;
        set => WriteParamField(ref _FaceTexData17, value);
    }
    private byte _FaceTexData17;

    [ParamField(0x44, ParamType.U8)]
    public byte FaceTexData18
    {
        get => _FaceTexData18;
        set => WriteParamField(ref _FaceTexData18, value);
    }
    private byte _FaceTexData18;

    [ParamField(0x45, ParamType.U8)]
    public byte FaceTexData19
    {
        get => _FaceTexData19;
        set => WriteParamField(ref _FaceTexData19, value);
    }
    private byte _FaceTexData19;

    [ParamField(0x46, ParamType.U8)]
    public byte FaceTexData20
    {
        get => _FaceTexData20;
        set => WriteParamField(ref _FaceTexData20, value);
    }
    private byte _FaceTexData20;

    [ParamField(0x47, ParamType.U8)]
    public byte FaceTexData21
    {
        get => _FaceTexData21;
        set => WriteParamField(ref _FaceTexData21, value);
    }
    private byte _FaceTexData21;

    [ParamField(0x48, ParamType.U8)]
    public byte FaceTexData22
    {
        get => _FaceTexData22;
        set => WriteParamField(ref _FaceTexData22, value);
    }
    private byte _FaceTexData22;

    [ParamField(0x49, ParamType.U8)]
    public byte FaceTexData23
    {
        get => _FaceTexData23;
        set => WriteParamField(ref _FaceTexData23, value);
    }
    private byte _FaceTexData23;

    [ParamField(0x4A, ParamType.U8)]
    public byte FaceTexData24
    {
        get => _FaceTexData24;
        set => WriteParamField(ref _FaceTexData24, value);
    }
    private byte _FaceTexData24;

    [ParamField(0x4B, ParamType.U8)]
    public byte FaceTexData25
    {
        get => _FaceTexData25;
        set => WriteParamField(ref _FaceTexData25, value);
    }
    private byte _FaceTexData25;

    [ParamField(0x4C, ParamType.U8)]
    public byte FaceTexData26
    {
        get => _FaceTexData26;
        set => WriteParamField(ref _FaceTexData26, value);
    }
    private byte _FaceTexData26;

    [ParamField(0x4D, ParamType.U8)]
    public byte FaceTexData27
    {
        get => _FaceTexData27;
        set => WriteParamField(ref _FaceTexData27, value);
    }
    private byte _FaceTexData27;

    [ParamField(0x4E, ParamType.U8)]
    public byte FaceTexData28
    {
        get => _FaceTexData28;
        set => WriteParamField(ref _FaceTexData28, value);
    }
    private byte _FaceTexData28;

    [ParamField(0x4F, ParamType.U8)]
    public byte FaceTexData29
    {
        get => _FaceTexData29;
        set => WriteParamField(ref _FaceTexData29, value);
    }
    private byte _FaceTexData29;

    [ParamField(0x50, ParamType.U8)]
    public byte FaceTexData30
    {
        get => _FaceTexData30;
        set => WriteParamField(ref _FaceTexData30, value);
    }
    private byte _FaceTexData30;

    [ParamField(0x51, ParamType.U8)]
    public byte FaceTexData31
    {
        get => _FaceTexData31;
        set => WriteParamField(ref _FaceTexData31, value);
    }
    private byte _FaceTexData31;

    [ParamField(0x52, ParamType.U8)]
    public byte FaceTexData32
    {
        get => _FaceTexData32;
        set => WriteParamField(ref _FaceTexData32, value);
    }
    private byte _FaceTexData32;

    [ParamField(0x53, ParamType.U8)]
    public byte FaceTexData33
    {
        get => _FaceTexData33;
        set => WriteParamField(ref _FaceTexData33, value);
    }
    private byte _FaceTexData33;

    [ParamField(0x54, ParamType.U8)]
    public byte FaceTexData34
    {
        get => _FaceTexData34;
        set => WriteParamField(ref _FaceTexData34, value);
    }
    private byte _FaceTexData34;

    [ParamField(0x55, ParamType.U8)]
    public byte FaceTexData35
    {
        get => _FaceTexData35;
        set => WriteParamField(ref _FaceTexData35, value);
    }
    private byte _FaceTexData35;

    [ParamField(0x56, ParamType.U8)]
    public byte FaceTexData36
    {
        get => _FaceTexData36;
        set => WriteParamField(ref _FaceTexData36, value);
    }
    private byte _FaceTexData36;

    [ParamField(0x57, ParamType.U8)]
    public byte FaceTexData37
    {
        get => _FaceTexData37;
        set => WriteParamField(ref _FaceTexData37, value);
    }
    private byte _FaceTexData37;

    [ParamField(0x58, ParamType.U8)]
    public byte FaceTexData38
    {
        get => _FaceTexData38;
        set => WriteParamField(ref _FaceTexData38, value);
    }
    private byte _FaceTexData38;

    [ParamField(0x59, ParamType.U8)]
    public byte FaceTexData39
    {
        get => _FaceTexData39;
        set => WriteParamField(ref _FaceTexData39, value);
    }
    private byte _FaceTexData39;

    [ParamField(0x5A, ParamType.U8)]
    public byte FaceTexData40
    {
        get => _FaceTexData40;
        set => WriteParamField(ref _FaceTexData40, value);
    }
    private byte _FaceTexData40;

    [ParamField(0x5B, ParamType.U8)]
    public byte FaceTexData41
    {
        get => _FaceTexData41;
        set => WriteParamField(ref _FaceTexData41, value);
    }
    private byte _FaceTexData41;

    [ParamField(0x5C, ParamType.U8)]
    public byte FaceTexData42
    {
        get => _FaceTexData42;
        set => WriteParamField(ref _FaceTexData42, value);
    }
    private byte _FaceTexData42;

    [ParamField(0x5D, ParamType.U8)]
    public byte FaceTexData43
    {
        get => _FaceTexData43;
        set => WriteParamField(ref _FaceTexData43, value);
    }
    private byte _FaceTexData43;

    [ParamField(0x5E, ParamType.U8)]
    public byte FaceTexData44
    {
        get => _FaceTexData44;
        set => WriteParamField(ref _FaceTexData44, value);
    }
    private byte _FaceTexData44;

    [ParamField(0x5F, ParamType.U8)]
    public byte FaceTexData45
    {
        get => _FaceTexData45;
        set => WriteParamField(ref _FaceTexData45, value);
    }
    private byte _FaceTexData45;

    [ParamField(0x60, ParamType.U8)]
    public byte FaceTexData46
    {
        get => _FaceTexData46;
        set => WriteParamField(ref _FaceTexData46, value);
    }
    private byte _FaceTexData46;

    [ParamField(0x61, ParamType.U8)]
    public byte FaceTexData47
    {
        get => _FaceTexData47;
        set => WriteParamField(ref _FaceTexData47, value);
    }
    private byte _FaceTexData47;

    [ParamField(0x62, ParamType.U8)]
    public byte FaceTexData48
    {
        get => _FaceTexData48;
        set => WriteParamField(ref _FaceTexData48, value);
    }
    private byte _FaceTexData48;

    [ParamField(0x63, ParamType.U8)]
    public byte FaceTexData49
    {
        get => _FaceTexData49;
        set => WriteParamField(ref _FaceTexData49, value);
    }
    private byte _FaceTexData49;

    [ParamField(0x64, ParamType.U8)]
    public byte HairStyle
    {
        get => _HairStyle;
        set => WriteParamField(ref _HairStyle, value);
    }
    private byte _HairStyle;

    [ParamField(0x65, ParamType.U8)]
    public byte HairColor_Base
    {
        get => _HairColor_Base;
        set => WriteParamField(ref _HairColor_Base, value);
    }
    private byte _HairColor_Base;

    [ParamField(0x66, ParamType.U8)]
    public byte HairColor_R
    {
        get => _HairColor_R;
        set => WriteParamField(ref _HairColor_R, value);
    }
    private byte _HairColor_R;

    [ParamField(0x67, ParamType.U8)]
    public byte HairColor_G
    {
        get => _HairColor_G;
        set => WriteParamField(ref _HairColor_G, value);
    }
    private byte _HairColor_G;

    [ParamField(0x68, ParamType.U8)]
    public byte HairColor_B
    {
        get => _HairColor_B;
        set => WriteParamField(ref _HairColor_B, value);
    }
    private byte _HairColor_B;

    [ParamField(0x69, ParamType.U8)]
    public byte EyeColor_R
    {
        get => _EyeColor_R;
        set => WriteParamField(ref _EyeColor_R, value);
    }
    private byte _EyeColor_R;

    [ParamField(0x6A, ParamType.U8)]
    public byte EyeColor_G
    {
        get => _EyeColor_G;
        set => WriteParamField(ref _EyeColor_G, value);
    }
    private byte _EyeColor_G;

    [ParamField(0x6B, ParamType.U8)]
    public byte EyeColor_B
    {
        get => _EyeColor_B;
        set => WriteParamField(ref _EyeColor_B, value);
    }
    private byte _EyeColor_B;

    [ParamField(0x6C, ParamType.Dummy8, 20)]
    public byte[] Pad
    {
        get => _Pad;
        set => WriteParamField(ref _Pad, value);
    }
    private byte[] _Pad = null!;

}
