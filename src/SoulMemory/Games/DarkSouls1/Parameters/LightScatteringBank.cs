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
public class LightScatteringBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I16)]
    public short SunRotX
    {
        get => _sunRotX;
        set => WriteParamField(ref _sunRotX, value);
    }
    private short _sunRotX;

    [ParamField(0x2, ParamType.I16)]
    public short SunRotY
    {
        get => _sunRotY;
        set => WriteParamField(ref _sunRotY, value);
    }
    private short _sunRotY;

    [ParamField(0x4, ParamType.I16)]
    public short DistanceMul
    {
        get => _distanceMul;
        set => WriteParamField(ref _distanceMul, value);
    }
    private short _distanceMul;

    [ParamField(0x6, ParamType.I16)]
    public short SunR
    {
        get => _sunR;
        set => WriteParamField(ref _sunR, value);
    }
    private short _sunR;

    [ParamField(0x8, ParamType.I16)]
    public short SunG
    {
        get => _sunG;
        set => WriteParamField(ref _sunG, value);
    }
    private short _sunG;

    [ParamField(0xA, ParamType.I16)]
    public short SunB
    {
        get => _sunB;
        set => WriteParamField(ref _sunB, value);
    }
    private short _sunB;

    [ParamField(0xC, ParamType.I16)]
    public short SunA
    {
        get => _sunA;
        set => WriteParamField(ref _sunA, value);
    }
    private short _sunA;

    [ParamField(0xE, ParamType.Dummy8, 2)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

    [ParamField(0x10, ParamType.F32)]
    public float LsHGg
    {
        get => _lsHGg;
        set => WriteParamField(ref _lsHGg, value);
    }
    private float _lsHGg;

    [ParamField(0x14, ParamType.F32)]
    public float LsBetaRay
    {
        get => _lsBetaRay;
        set => WriteParamField(ref _lsBetaRay, value);
    }
    private float _lsBetaRay;

    [ParamField(0x18, ParamType.F32)]
    public float LsBetaMie
    {
        get => _lsBetaMie;
        set => WriteParamField(ref _lsBetaMie, value);
    }
    private float _lsBetaMie;

    [ParamField(0x1C, ParamType.I16)]
    public short BlendCoef
    {
        get => _blendCoef;
        set => WriteParamField(ref _blendCoef, value);
    }
    private short _blendCoef;

    [ParamField(0x1E, ParamType.I16)]
    public short ReflectanceR
    {
        get => _reflectanceR;
        set => WriteParamField(ref _reflectanceR, value);
    }
    private short _reflectanceR;

    [ParamField(0x20, ParamType.I16)]
    public short ReflectanceG
    {
        get => _reflectanceG;
        set => WriteParamField(ref _reflectanceG, value);
    }
    private short _reflectanceG;

    [ParamField(0x22, ParamType.I16)]
    public short ReflectanceB
    {
        get => _reflectanceB;
        set => WriteParamField(ref _reflectanceB, value);
    }
    private short _reflectanceB;

    [ParamField(0x24, ParamType.I16)]
    public short ReflectanceA
    {
        get => _reflectanceA;
        set => WriteParamField(ref _reflectanceA, value);
    }
    private short _reflectanceA;

    [ParamField(0x26, ParamType.Dummy8, 2)]
    public byte[] Pad1
    {
        get => _pad1;
        set => WriteParamField(ref _pad1, value);
    }
    private byte[] _pad1 = null!;

}
