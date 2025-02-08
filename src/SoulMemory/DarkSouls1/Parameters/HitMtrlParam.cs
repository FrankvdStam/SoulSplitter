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
public class HitMtrlParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float AiVolumeRate
    {
        get => _aiVolumeRate;
        set => WriteParamField(ref _aiVolumeRate, value);
    }
    private float _aiVolumeRate;

    [ParamField(0x4, ParamType.I32)]
    public int SpEffectIdOnHit0
    {
        get => _spEffectIdOnHit0;
        set => WriteParamField(ref _spEffectIdOnHit0, value);
    }
    private int _spEffectIdOnHit0;

    [ParamField(0x8, ParamType.I32)]
    public int SpEffectIdOnHit1
    {
        get => _spEffectIdOnHit1;
        set => WriteParamField(ref _spEffectIdOnHit1, value);
    }
    private int _spEffectIdOnHit1;

    #region BitField FootEffectHeightTypeBitfield ==============================================================================

    [ParamField(0xC, ParamType.U8)]
    public byte FootEffectHeightTypeBitfield
    {
        get => _footEffectHeightTypeBitfield;
        set => WriteParamField(ref _footEffectHeightTypeBitfield, value);
    }
    private byte _footEffectHeightTypeBitfield;

    [ParamBitField(nameof(FootEffectHeightTypeBitfield), bits: 2, bitsOffset: 0)]
    public byte FootEffectHeightType
    {
        get => GetbitfieldValue(_footEffectHeightTypeBitfield);
        set => SetBitfieldValue(ref _footEffectHeightTypeBitfield, value);
    }

    [ParamBitField(nameof(FootEffectHeightTypeBitfield), bits: 2, bitsOffset: 2)]
    public byte FootEffectDirType
    {
        get => GetbitfieldValue(_footEffectHeightTypeBitfield);
        set => SetBitfieldValue(ref _footEffectHeightTypeBitfield, value);
    }

    [ParamBitField(nameof(FootEffectHeightTypeBitfield), bits: 2, bitsOffset: 4)]
    public byte FloorHeightType
    {
        get => GetbitfieldValue(_footEffectHeightTypeBitfield);
        set => SetBitfieldValue(ref _footEffectHeightTypeBitfield, value);
    }

    #endregion BitField FootEffectHeightTypeBitfield

    [ParamField(0xD, ParamType.Dummy8, 3)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

}
