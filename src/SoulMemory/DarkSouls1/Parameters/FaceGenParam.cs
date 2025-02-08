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
public class FaceGenParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.U8)]
    public byte FaceGeoData00
    {
        get => _faceGeoData00;
        set => WriteParamField(ref _faceGeoData00, value);
    }
    private byte _faceGeoData00;

    [ParamField(0x1, ParamType.U8)]
    public byte FaceGeoData01
    {
        get => _faceGeoData01;
        set => WriteParamField(ref _faceGeoData01, value);
    }
    private byte _faceGeoData01;

    [ParamField(0x2, ParamType.U8)]
    public byte FaceGeoData02
    {
        get => _faceGeoData02;
        set => WriteParamField(ref _faceGeoData02, value);
    }
    private byte _faceGeoData02;

    [ParamField(0x3, ParamType.U8)]
    public byte FaceGeoData03
    {
        get => _faceGeoData03;
        set => WriteParamField(ref _faceGeoData03, value);
    }
    private byte _faceGeoData03;

    [ParamField(0x4, ParamType.U8)]
    public byte FaceGeoData04
    {
        get => _faceGeoData04;
        set => WriteParamField(ref _faceGeoData04, value);
    }
    private byte _faceGeoData04;

    [ParamField(0x5, ParamType.U8)]
    public byte FaceGeoData05
    {
        get => _faceGeoData05;
        set => WriteParamField(ref _faceGeoData05, value);
    }
    private byte _faceGeoData05;

    [ParamField(0x6, ParamType.U8)]
    public byte FaceGeoData06
    {
        get => _faceGeoData06;
        set => WriteParamField(ref _faceGeoData06, value);
    }
    private byte _faceGeoData06;

    [ParamField(0x7, ParamType.U8)]
    public byte FaceGeoData07
    {
        get => _faceGeoData07;
        set => WriteParamField(ref _faceGeoData07, value);
    }
    private byte _faceGeoData07;

    [ParamField(0x8, ParamType.U8)]
    public byte FaceGeoData08
    {
        get => _faceGeoData08;
        set => WriteParamField(ref _faceGeoData08, value);
    }
    private byte _faceGeoData08;

    [ParamField(0x9, ParamType.U8)]
    public byte FaceGeoData09
    {
        get => _faceGeoData09;
        set => WriteParamField(ref _faceGeoData09, value);
    }
    private byte _faceGeoData09;

    [ParamField(0xA, ParamType.U8)]
    public byte FaceGeoData10
    {
        get => _faceGeoData10;
        set => WriteParamField(ref _faceGeoData10, value);
    }
    private byte _faceGeoData10;

    [ParamField(0xB, ParamType.U8)]
    public byte FaceGeoData11
    {
        get => _faceGeoData11;
        set => WriteParamField(ref _faceGeoData11, value);
    }
    private byte _faceGeoData11;

    [ParamField(0xC, ParamType.U8)]
    public byte FaceGeoData12
    {
        get => _faceGeoData12;
        set => WriteParamField(ref _faceGeoData12, value);
    }
    private byte _faceGeoData12;

    [ParamField(0xD, ParamType.U8)]
    public byte FaceGeoData13
    {
        get => _faceGeoData13;
        set => WriteParamField(ref _faceGeoData13, value);
    }
    private byte _faceGeoData13;

    [ParamField(0xE, ParamType.U8)]
    public byte FaceGeoData14
    {
        get => _faceGeoData14;
        set => WriteParamField(ref _faceGeoData14, value);
    }
    private byte _faceGeoData14;

    [ParamField(0xF, ParamType.U8)]
    public byte FaceGeoData15
    {
        get => _faceGeoData15;
        set => WriteParamField(ref _faceGeoData15, value);
    }
    private byte _faceGeoData15;

    [ParamField(0x10, ParamType.U8)]
    public byte FaceGeoData16
    {
        get => _faceGeoData16;
        set => WriteParamField(ref _faceGeoData16, value);
    }
    private byte _faceGeoData16;

    [ParamField(0x11, ParamType.U8)]
    public byte FaceGeoData17
    {
        get => _faceGeoData17;
        set => WriteParamField(ref _faceGeoData17, value);
    }
    private byte _faceGeoData17;

    [ParamField(0x12, ParamType.U8)]
    public byte FaceGeoData18
    {
        get => _faceGeoData18;
        set => WriteParamField(ref _faceGeoData18, value);
    }
    private byte _faceGeoData18;

    [ParamField(0x13, ParamType.U8)]
    public byte FaceGeoData19
    {
        get => _faceGeoData19;
        set => WriteParamField(ref _faceGeoData19, value);
    }
    private byte _faceGeoData19;

    [ParamField(0x14, ParamType.U8)]
    public byte FaceGeoData20
    {
        get => _faceGeoData20;
        set => WriteParamField(ref _faceGeoData20, value);
    }
    private byte _faceGeoData20;

    [ParamField(0x15, ParamType.U8)]
    public byte FaceGeoData21
    {
        get => _faceGeoData21;
        set => WriteParamField(ref _faceGeoData21, value);
    }
    private byte _faceGeoData21;

    [ParamField(0x16, ParamType.U8)]
    public byte FaceGeoData22
    {
        get => _faceGeoData22;
        set => WriteParamField(ref _faceGeoData22, value);
    }
    private byte _faceGeoData22;

    [ParamField(0x17, ParamType.U8)]
    public byte FaceGeoData23
    {
        get => _faceGeoData23;
        set => WriteParamField(ref _faceGeoData23, value);
    }
    private byte _faceGeoData23;

    [ParamField(0x18, ParamType.U8)]
    public byte FaceGeoData24
    {
        get => _faceGeoData24;
        set => WriteParamField(ref _faceGeoData24, value);
    }
    private byte _faceGeoData24;

    [ParamField(0x19, ParamType.U8)]
    public byte FaceGeoData25
    {
        get => _faceGeoData25;
        set => WriteParamField(ref _faceGeoData25, value);
    }
    private byte _faceGeoData25;

    [ParamField(0x1A, ParamType.U8)]
    public byte FaceGeoData26
    {
        get => _faceGeoData26;
        set => WriteParamField(ref _faceGeoData26, value);
    }
    private byte _faceGeoData26;

    [ParamField(0x1B, ParamType.U8)]
    public byte FaceGeoData27
    {
        get => _faceGeoData27;
        set => WriteParamField(ref _faceGeoData27, value);
    }
    private byte _faceGeoData27;

    [ParamField(0x1C, ParamType.U8)]
    public byte FaceGeoData28
    {
        get => _faceGeoData28;
        set => WriteParamField(ref _faceGeoData28, value);
    }
    private byte _faceGeoData28;

    [ParamField(0x1D, ParamType.U8)]
    public byte FaceGeoData29
    {
        get => _faceGeoData29;
        set => WriteParamField(ref _faceGeoData29, value);
    }
    private byte _faceGeoData29;

    [ParamField(0x1E, ParamType.U8)]
    public byte FaceGeoData30
    {
        get => _faceGeoData30;
        set => WriteParamField(ref _faceGeoData30, value);
    }
    private byte _faceGeoData30;

    [ParamField(0x1F, ParamType.U8)]
    public byte FaceGeoData31
    {
        get => _faceGeoData31;
        set => WriteParamField(ref _faceGeoData31, value);
    }
    private byte _faceGeoData31;

    [ParamField(0x20, ParamType.U8)]
    public byte FaceGeoData32
    {
        get => _faceGeoData32;
        set => WriteParamField(ref _faceGeoData32, value);
    }
    private byte _faceGeoData32;

    [ParamField(0x21, ParamType.U8)]
    public byte FaceGeoData33
    {
        get => _faceGeoData33;
        set => WriteParamField(ref _faceGeoData33, value);
    }
    private byte _faceGeoData33;

    [ParamField(0x22, ParamType.U8)]
    public byte FaceGeoData34
    {
        get => _faceGeoData34;
        set => WriteParamField(ref _faceGeoData34, value);
    }
    private byte _faceGeoData34;

    [ParamField(0x23, ParamType.U8)]
    public byte FaceGeoData35
    {
        get => _faceGeoData35;
        set => WriteParamField(ref _faceGeoData35, value);
    }
    private byte _faceGeoData35;

    [ParamField(0x24, ParamType.U8)]
    public byte FaceGeoData36
    {
        get => _faceGeoData36;
        set => WriteParamField(ref _faceGeoData36, value);
    }
    private byte _faceGeoData36;

    [ParamField(0x25, ParamType.U8)]
    public byte FaceGeoData37
    {
        get => _faceGeoData37;
        set => WriteParamField(ref _faceGeoData37, value);
    }
    private byte _faceGeoData37;

    [ParamField(0x26, ParamType.U8)]
    public byte FaceGeoData38
    {
        get => _faceGeoData38;
        set => WriteParamField(ref _faceGeoData38, value);
    }
    private byte _faceGeoData38;

    [ParamField(0x27, ParamType.U8)]
    public byte FaceGeoData39
    {
        get => _faceGeoData39;
        set => WriteParamField(ref _faceGeoData39, value);
    }
    private byte _faceGeoData39;

    [ParamField(0x28, ParamType.U8)]
    public byte FaceGeoData40
    {
        get => _faceGeoData40;
        set => WriteParamField(ref _faceGeoData40, value);
    }
    private byte _faceGeoData40;

    [ParamField(0x29, ParamType.U8)]
    public byte FaceGeoData41
    {
        get => _faceGeoData41;
        set => WriteParamField(ref _faceGeoData41, value);
    }
    private byte _faceGeoData41;

    [ParamField(0x2A, ParamType.U8)]
    public byte FaceGeoData42
    {
        get => _faceGeoData42;
        set => WriteParamField(ref _faceGeoData42, value);
    }
    private byte _faceGeoData42;

    [ParamField(0x2B, ParamType.U8)]
    public byte FaceGeoData43
    {
        get => _faceGeoData43;
        set => WriteParamField(ref _faceGeoData43, value);
    }
    private byte _faceGeoData43;

    [ParamField(0x2C, ParamType.U8)]
    public byte FaceGeoData44
    {
        get => _faceGeoData44;
        set => WriteParamField(ref _faceGeoData44, value);
    }
    private byte _faceGeoData44;

    [ParamField(0x2D, ParamType.U8)]
    public byte FaceGeoData45
    {
        get => _faceGeoData45;
        set => WriteParamField(ref _faceGeoData45, value);
    }
    private byte _faceGeoData45;

    [ParamField(0x2E, ParamType.U8)]
    public byte FaceGeoData46
    {
        get => _faceGeoData46;
        set => WriteParamField(ref _faceGeoData46, value);
    }
    private byte _faceGeoData46;

    [ParamField(0x2F, ParamType.U8)]
    public byte FaceGeoData47
    {
        get => _faceGeoData47;
        set => WriteParamField(ref _faceGeoData47, value);
    }
    private byte _faceGeoData47;

    [ParamField(0x30, ParamType.U8)]
    public byte FaceGeoData48
    {
        get => _faceGeoData48;
        set => WriteParamField(ref _faceGeoData48, value);
    }
    private byte _faceGeoData48;

    [ParamField(0x31, ParamType.U8)]
    public byte FaceGeoData49
    {
        get => _faceGeoData49;
        set => WriteParamField(ref _faceGeoData49, value);
    }
    private byte _faceGeoData49;

    [ParamField(0x32, ParamType.U8)]
    public byte FaceTexData00
    {
        get => _faceTexData00;
        set => WriteParamField(ref _faceTexData00, value);
    }
    private byte _faceTexData00;

    [ParamField(0x33, ParamType.U8)]
    public byte FaceTexData01
    {
        get => _faceTexData01;
        set => WriteParamField(ref _faceTexData01, value);
    }
    private byte _faceTexData01;

    [ParamField(0x34, ParamType.U8)]
    public byte FaceTexData02
    {
        get => _faceTexData02;
        set => WriteParamField(ref _faceTexData02, value);
    }
    private byte _faceTexData02;

    [ParamField(0x35, ParamType.U8)]
    public byte FaceTexData03
    {
        get => _faceTexData03;
        set => WriteParamField(ref _faceTexData03, value);
    }
    private byte _faceTexData03;

    [ParamField(0x36, ParamType.U8)]
    public byte FaceTexData04
    {
        get => _faceTexData04;
        set => WriteParamField(ref _faceTexData04, value);
    }
    private byte _faceTexData04;

    [ParamField(0x37, ParamType.U8)]
    public byte FaceTexData05
    {
        get => _faceTexData05;
        set => WriteParamField(ref _faceTexData05, value);
    }
    private byte _faceTexData05;

    [ParamField(0x38, ParamType.U8)]
    public byte FaceTexData06
    {
        get => _faceTexData06;
        set => WriteParamField(ref _faceTexData06, value);
    }
    private byte _faceTexData06;

    [ParamField(0x39, ParamType.U8)]
    public byte FaceTexData07
    {
        get => _faceTexData07;
        set => WriteParamField(ref _faceTexData07, value);
    }
    private byte _faceTexData07;

    [ParamField(0x3A, ParamType.U8)]
    public byte FaceTexData08
    {
        get => _faceTexData08;
        set => WriteParamField(ref _faceTexData08, value);
    }
    private byte _faceTexData08;

    [ParamField(0x3B, ParamType.U8)]
    public byte FaceTexData09
    {
        get => _faceTexData09;
        set => WriteParamField(ref _faceTexData09, value);
    }
    private byte _faceTexData09;

    [ParamField(0x3C, ParamType.U8)]
    public byte FaceTexData10
    {
        get => _faceTexData10;
        set => WriteParamField(ref _faceTexData10, value);
    }
    private byte _faceTexData10;

    [ParamField(0x3D, ParamType.U8)]
    public byte FaceTexData11
    {
        get => _faceTexData11;
        set => WriteParamField(ref _faceTexData11, value);
    }
    private byte _faceTexData11;

    [ParamField(0x3E, ParamType.U8)]
    public byte FaceTexData12
    {
        get => _faceTexData12;
        set => WriteParamField(ref _faceTexData12, value);
    }
    private byte _faceTexData12;

    [ParamField(0x3F, ParamType.U8)]
    public byte FaceTexData13
    {
        get => _faceTexData13;
        set => WriteParamField(ref _faceTexData13, value);
    }
    private byte _faceTexData13;

    [ParamField(0x40, ParamType.U8)]
    public byte FaceTexData14
    {
        get => _faceTexData14;
        set => WriteParamField(ref _faceTexData14, value);
    }
    private byte _faceTexData14;

    [ParamField(0x41, ParamType.U8)]
    public byte FaceTexData15
    {
        get => _faceTexData15;
        set => WriteParamField(ref _faceTexData15, value);
    }
    private byte _faceTexData15;

    [ParamField(0x42, ParamType.U8)]
    public byte FaceTexData16
    {
        get => _faceTexData16;
        set => WriteParamField(ref _faceTexData16, value);
    }
    private byte _faceTexData16;

    [ParamField(0x43, ParamType.U8)]
    public byte FaceTexData17
    {
        get => _faceTexData17;
        set => WriteParamField(ref _faceTexData17, value);
    }
    private byte _faceTexData17;

    [ParamField(0x44, ParamType.U8)]
    public byte FaceTexData18
    {
        get => _faceTexData18;
        set => WriteParamField(ref _faceTexData18, value);
    }
    private byte _faceTexData18;

    [ParamField(0x45, ParamType.U8)]
    public byte FaceTexData19
    {
        get => _faceTexData19;
        set => WriteParamField(ref _faceTexData19, value);
    }
    private byte _faceTexData19;

    [ParamField(0x46, ParamType.U8)]
    public byte FaceTexData20
    {
        get => _faceTexData20;
        set => WriteParamField(ref _faceTexData20, value);
    }
    private byte _faceTexData20;

    [ParamField(0x47, ParamType.U8)]
    public byte FaceTexData21
    {
        get => _faceTexData21;
        set => WriteParamField(ref _faceTexData21, value);
    }
    private byte _faceTexData21;

    [ParamField(0x48, ParamType.U8)]
    public byte FaceTexData22
    {
        get => _faceTexData22;
        set => WriteParamField(ref _faceTexData22, value);
    }
    private byte _faceTexData22;

    [ParamField(0x49, ParamType.U8)]
    public byte FaceTexData23
    {
        get => _faceTexData23;
        set => WriteParamField(ref _faceTexData23, value);
    }
    private byte _faceTexData23;

    [ParamField(0x4A, ParamType.U8)]
    public byte FaceTexData24
    {
        get => _faceTexData24;
        set => WriteParamField(ref _faceTexData24, value);
    }
    private byte _faceTexData24;

    [ParamField(0x4B, ParamType.U8)]
    public byte FaceTexData25
    {
        get => _faceTexData25;
        set => WriteParamField(ref _faceTexData25, value);
    }
    private byte _faceTexData25;

    [ParamField(0x4C, ParamType.U8)]
    public byte FaceTexData26
    {
        get => _faceTexData26;
        set => WriteParamField(ref _faceTexData26, value);
    }
    private byte _faceTexData26;

    [ParamField(0x4D, ParamType.U8)]
    public byte FaceTexData27
    {
        get => _faceTexData27;
        set => WriteParamField(ref _faceTexData27, value);
    }
    private byte _faceTexData27;

    [ParamField(0x4E, ParamType.U8)]
    public byte FaceTexData28
    {
        get => _faceTexData28;
        set => WriteParamField(ref _faceTexData28, value);
    }
    private byte _faceTexData28;

    [ParamField(0x4F, ParamType.U8)]
    public byte FaceTexData29
    {
        get => _faceTexData29;
        set => WriteParamField(ref _faceTexData29, value);
    }
    private byte _faceTexData29;

    [ParamField(0x50, ParamType.U8)]
    public byte FaceTexData30
    {
        get => _faceTexData30;
        set => WriteParamField(ref _faceTexData30, value);
    }
    private byte _faceTexData30;

    [ParamField(0x51, ParamType.U8)]
    public byte FaceTexData31
    {
        get => _faceTexData31;
        set => WriteParamField(ref _faceTexData31, value);
    }
    private byte _faceTexData31;

    [ParamField(0x52, ParamType.U8)]
    public byte FaceTexData32
    {
        get => _faceTexData32;
        set => WriteParamField(ref _faceTexData32, value);
    }
    private byte _faceTexData32;

    [ParamField(0x53, ParamType.U8)]
    public byte FaceTexData33
    {
        get => _faceTexData33;
        set => WriteParamField(ref _faceTexData33, value);
    }
    private byte _faceTexData33;

    [ParamField(0x54, ParamType.U8)]
    public byte FaceTexData34
    {
        get => _faceTexData34;
        set => WriteParamField(ref _faceTexData34, value);
    }
    private byte _faceTexData34;

    [ParamField(0x55, ParamType.U8)]
    public byte FaceTexData35
    {
        get => _faceTexData35;
        set => WriteParamField(ref _faceTexData35, value);
    }
    private byte _faceTexData35;

    [ParamField(0x56, ParamType.U8)]
    public byte FaceTexData36
    {
        get => _faceTexData36;
        set => WriteParamField(ref _faceTexData36, value);
    }
    private byte _faceTexData36;

    [ParamField(0x57, ParamType.U8)]
    public byte FaceTexData37
    {
        get => _faceTexData37;
        set => WriteParamField(ref _faceTexData37, value);
    }
    private byte _faceTexData37;

    [ParamField(0x58, ParamType.U8)]
    public byte FaceTexData38
    {
        get => _faceTexData38;
        set => WriteParamField(ref _faceTexData38, value);
    }
    private byte _faceTexData38;

    [ParamField(0x59, ParamType.U8)]
    public byte FaceTexData39
    {
        get => _faceTexData39;
        set => WriteParamField(ref _faceTexData39, value);
    }
    private byte _faceTexData39;

    [ParamField(0x5A, ParamType.U8)]
    public byte FaceTexData40
    {
        get => _faceTexData40;
        set => WriteParamField(ref _faceTexData40, value);
    }
    private byte _faceTexData40;

    [ParamField(0x5B, ParamType.U8)]
    public byte FaceTexData41
    {
        get => _faceTexData41;
        set => WriteParamField(ref _faceTexData41, value);
    }
    private byte _faceTexData41;

    [ParamField(0x5C, ParamType.U8)]
    public byte FaceTexData42
    {
        get => _faceTexData42;
        set => WriteParamField(ref _faceTexData42, value);
    }
    private byte _faceTexData42;

    [ParamField(0x5D, ParamType.U8)]
    public byte FaceTexData43
    {
        get => _faceTexData43;
        set => WriteParamField(ref _faceTexData43, value);
    }
    private byte _faceTexData43;

    [ParamField(0x5E, ParamType.U8)]
    public byte FaceTexData44
    {
        get => _faceTexData44;
        set => WriteParamField(ref _faceTexData44, value);
    }
    private byte _faceTexData44;

    [ParamField(0x5F, ParamType.U8)]
    public byte FaceTexData45
    {
        get => _faceTexData45;
        set => WriteParamField(ref _faceTexData45, value);
    }
    private byte _faceTexData45;

    [ParamField(0x60, ParamType.U8)]
    public byte FaceTexData46
    {
        get => _faceTexData46;
        set => WriteParamField(ref _faceTexData46, value);
    }
    private byte _faceTexData46;

    [ParamField(0x61, ParamType.U8)]
    public byte FaceTexData47
    {
        get => _faceTexData47;
        set => WriteParamField(ref _faceTexData47, value);
    }
    private byte _faceTexData47;

    [ParamField(0x62, ParamType.U8)]
    public byte FaceTexData48
    {
        get => _faceTexData48;
        set => WriteParamField(ref _faceTexData48, value);
    }
    private byte _faceTexData48;

    [ParamField(0x63, ParamType.U8)]
    public byte FaceTexData49
    {
        get => _faceTexData49;
        set => WriteParamField(ref _faceTexData49, value);
    }
    private byte _faceTexData49;

    [ParamField(0x64, ParamType.U8)]
    public byte HairStyle
    {
        get => _hairStyle;
        set => WriteParamField(ref _hairStyle, value);
    }
    private byte _hairStyle;

    [ParamField(0x65, ParamType.U8)]
    public byte HairColorBase
    {
        get => _hairColorBase;
        set => WriteParamField(ref _hairColorBase, value);
    }
    private byte _hairColorBase;

    [ParamField(0x66, ParamType.U8)]
    public byte HairColorR
    {
        get => _hairColorR;
        set => WriteParamField(ref _hairColorR, value);
    }
    private byte _hairColorR;

    [ParamField(0x67, ParamType.U8)]
    public byte HairColorG
    {
        get => _hairColorG;
        set => WriteParamField(ref _hairColorG, value);
    }
    private byte _hairColorG;

    [ParamField(0x68, ParamType.U8)]
    public byte HairColorB
    {
        get => _hairColorB;
        set => WriteParamField(ref _hairColorB, value);
    }
    private byte _hairColorB;

    [ParamField(0x69, ParamType.U8)]
    public byte EyeColorR
    {
        get => _eyeColorR;
        set => WriteParamField(ref _eyeColorR, value);
    }
    private byte _eyeColorR;

    [ParamField(0x6A, ParamType.U8)]
    public byte EyeColorG
    {
        get => _eyeColorG;
        set => WriteParamField(ref _eyeColorG, value);
    }
    private byte _eyeColorG;

    [ParamField(0x6B, ParamType.U8)]
    public byte EyeColorB
    {
        get => _eyeColorB;
        set => WriteParamField(ref _eyeColorB, value);
    }
    private byte _eyeColorB;

    [ParamField(0x6C, ParamType.Dummy8, 20)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
