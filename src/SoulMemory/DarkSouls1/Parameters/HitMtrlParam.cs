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
using System;
using System.Diagnostics.CodeAnalysis;

namespace SoulMemory.DarkSouls1.Parameters
{
    [ExcludeFromCodeCoverage]
    public class HitMtrlParam : BaseParam
    {
        public HitMtrlParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float AiVolumeRate
        {
            get => _AiVolumeRate;
            set => WriteParamField(ref _AiVolumeRate, value);
        }
        private float _AiVolumeRate;

        [ParamField(0x4, ParamType.I32)]
        public int SpEffectIdOnHit0
        {
            get => _SpEffectIdOnHit0;
            set => WriteParamField(ref _SpEffectIdOnHit0, value);
        }
        private int _SpEffectIdOnHit0;

        [ParamField(0x8, ParamType.I32)]
        public int SpEffectIdOnHit1
        {
            get => _SpEffectIdOnHit1;
            set => WriteParamField(ref _SpEffectIdOnHit1, value);
        }
        private int _SpEffectIdOnHit1;

        #region BitField FootEffectHeightTypeBitfield ==============================================================================

        [ParamField(0xC, ParamType.U8)]
        public byte FootEffectHeightTypeBitfield
        {
            get => _FootEffectHeightTypeBitfield;
            set => WriteParamField(ref _FootEffectHeightTypeBitfield, value);
        }
        private byte _FootEffectHeightTypeBitfield;

        [ParamBitField(nameof(FootEffectHeightTypeBitfield), bits: 2, bitsOffset: 0)]
        public byte FootEffectHeightType
        {
            get => GetbitfieldValue(_FootEffectHeightTypeBitfield);
            set => SetBitfieldValue(ref _FootEffectHeightTypeBitfield, value);
        }

        [ParamBitField(nameof(FootEffectHeightTypeBitfield), bits: 2, bitsOffset: 2)]
        public byte FootEffectDirType
        {
            get => GetbitfieldValue(_FootEffectHeightTypeBitfield);
            set => SetBitfieldValue(ref _FootEffectHeightTypeBitfield, value);
        }

        [ParamBitField(nameof(FootEffectHeightTypeBitfield), bits: 2, bitsOffset: 4)]
        public byte FloorHeightType
        {
            get => GetbitfieldValue(_FootEffectHeightTypeBitfield);
            set => SetBitfieldValue(ref _FootEffectHeightTypeBitfield, value);
        }

        #endregion BitField FootEffectHeightTypeBitfield

        [ParamField(0xD, ParamType.Dummy8, 3)]
        public byte[] Pad0
        {
            get => _Pad0;
            set => WriteParamField(ref _Pad0, value);
        }
        private byte[] _Pad0;

    }
}
