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
public class LodBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float Lv01BorderDist
    {
        get => _lv01BorderDist;
        set => WriteParamField(ref _lv01BorderDist, value);
    }
    private float _lv01BorderDist;

    [ParamField(0x4, ParamType.F32)]
    public float Lv01PlayDist
    {
        get => _lv01PlayDist;
        set => WriteParamField(ref _lv01PlayDist, value);
    }
    private float _lv01PlayDist;

    [ParamField(0x8, ParamType.F32)]
    public float Lv12BorderDist
    {
        get => _lv12BorderDist;
        set => WriteParamField(ref _lv12BorderDist, value);
    }
    private float _lv12BorderDist;

    [ParamField(0xC, ParamType.F32)]
    public float Lv12PlayDist
    {
        get => _lv12PlayDist;
        set => WriteParamField(ref _lv12PlayDist, value);
    }
    private float _lv12PlayDist;

}
