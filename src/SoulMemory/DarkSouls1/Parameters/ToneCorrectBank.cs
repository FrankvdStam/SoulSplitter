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
public class ToneCorrectBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float BrightnessR
    {
        get => _brightnessR;
        set => WriteParamField(ref _brightnessR, value);
    }
    private float _brightnessR;

    [ParamField(0x4, ParamType.F32)]
    public float BrightnessG
    {
        get => _brightnessG;
        set => WriteParamField(ref _brightnessG, value);
    }
    private float _brightnessG;

    [ParamField(0x8, ParamType.F32)]
    public float BrightnessB
    {
        get => _brightnessB;
        set => WriteParamField(ref _brightnessB, value);
    }
    private float _brightnessB;

    [ParamField(0xC, ParamType.F32)]
    public float ContrastR
    {
        get => _contrastR;
        set => WriteParamField(ref _contrastR, value);
    }
    private float _contrastR;

    [ParamField(0x10, ParamType.F32)]
    public float ContrastG
    {
        get => _contrastG;
        set => WriteParamField(ref _contrastG, value);
    }
    private float _contrastG;

    [ParamField(0x14, ParamType.F32)]
    public float ContrastB
    {
        get => _contrastB;
        set => WriteParamField(ref _contrastB, value);
    }
    private float _contrastB;

    [ParamField(0x18, ParamType.F32)]
    public float Saturation
    {
        get => _saturation;
        set => WriteParamField(ref _saturation, value);
    }
    private float _saturation;

    [ParamField(0x1C, ParamType.F32)]
    public float Hue
    {
        get => _hue;
        set => WriteParamField(ref _hue, value);
    }
    private float _hue;

    [ParamField(0x20, ParamType.F32)]
    public float SfxMultiplier
    {
        get => _sfxMultiplier;
        set => WriteParamField(ref _sfxMultiplier, value);
    }
    private float _sfxMultiplier;

}
