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
public class ToneMapBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I16)]
    public short BloomBegin
    {
        get => _bloomBegin;
        set => WriteParamField(ref _bloomBegin, value);
    }
    private short _bloomBegin;

    [ParamField(0x2, ParamType.I16)]
    public short BloomMul
    {
        get => _bloomMul;
        set => WriteParamField(ref _bloomMul, value);
    }
    private short _bloomMul;

    [ParamField(0x4, ParamType.I16)]
    public short BloomBeginFar
    {
        get => _bloomBeginFar;
        set => WriteParamField(ref _bloomBeginFar, value);
    }
    private short _bloomBeginFar;

    [ParamField(0x6, ParamType.I16)]
    public short BloomMulFar
    {
        get => _bloomMulFar;
        set => WriteParamField(ref _bloomMulFar, value);
    }
    private short _bloomMulFar;

    [ParamField(0x8, ParamType.F32)]
    public float BloomNearDist
    {
        get => _bloomNearDist;
        set => WriteParamField(ref _bloomNearDist, value);
    }
    private float _bloomNearDist;

    [ParamField(0xC, ParamType.F32)]
    public float BloomFarDist
    {
        get => _bloomFarDist;
        set => WriteParamField(ref _bloomFarDist, value);
    }
    private float _bloomFarDist;

    [ParamField(0x10, ParamType.F32)]
    public float GrayKeyValue
    {
        get => _grayKeyValue;
        set => WriteParamField(ref _grayKeyValue, value);
    }
    private float _grayKeyValue;

    [ParamField(0x14, ParamType.F32)]
    public float MinAdaptedLum
    {
        get => _minAdaptedLum;
        set => WriteParamField(ref _minAdaptedLum, value);
    }
    private float _minAdaptedLum;

    [ParamField(0x18, ParamType.F32)]
    public float MaxAdapredLum
    {
        get => _maxAdapredLum;
        set => WriteParamField(ref _maxAdapredLum, value);
    }
    private float _maxAdapredLum;

    [ParamField(0x1C, ParamType.F32)]
    public float AdaptSpeed
    {
        get => _adaptSpeed;
        set => WriteParamField(ref _adaptSpeed, value);
    }
    private float _adaptSpeed;

    [ParamField(0x20, ParamType.I8)]
    public sbyte LightShaftBegin
    {
        get => _lightShaftBegin;
        set => WriteParamField(ref _lightShaftBegin, value);
    }
    private sbyte _lightShaftBegin;

    [ParamField(0x21, ParamType.Dummy8, 3)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

    [ParamField(0x24, ParamType.F32)]
    public float LightShaftPower
    {
        get => _lightShaftPower;
        set => WriteParamField(ref _lightShaftPower, value);
    }
    private float _lightShaftPower;

    [ParamField(0x28, ParamType.F32)]
    public float LightShaftAttenRate
    {
        get => _lightShaftAttenRate;
        set => WriteParamField(ref _lightShaftAttenRate, value);
    }
    private float _lightShaftAttenRate;

    [ParamField(0x2C, ParamType.F32)]
    public float InverseToneMapMul
    {
        get => _inverseToneMapMul;
        set => WriteParamField(ref _inverseToneMapMul, value);
    }
    private float _inverseToneMapMul;

}
