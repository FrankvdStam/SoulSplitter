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
    public class ShadowBank : BaseParam
    {
        public ShadowBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I16)]
        public short LightDegRotX
        {
            get => _LightDegRotX;
            set => WriteParamField(ref _LightDegRotX, value);
        }
        private short _LightDegRotX;

        [ParamField(0x2, ParamType.I16)]
        public short LightDegRotY
        {
            get => _LightDegRotY;
            set => WriteParamField(ref _LightDegRotY, value);
        }
        private short _LightDegRotY;

        [ParamField(0x4, ParamType.I16)]
        public short DensityRatio
        {
            get => _DensityRatio;
            set => WriteParamField(ref _DensityRatio, value);
        }
        private short _DensityRatio;

        [ParamField(0x6, ParamType.I16)]
        public short ColR
        {
            get => _ColR;
            set => WriteParamField(ref _ColR, value);
        }
        private short _ColR;

        [ParamField(0x8, ParamType.I16)]
        public short ColG
        {
            get => _ColG;
            set => WriteParamField(ref _ColG, value);
        }
        private short _ColG;

        [ParamField(0xA, ParamType.I16)]
        public short ColB
        {
            get => _ColB;
            set => WriteParamField(ref _ColB, value);
        }
        private short _ColB;

        [ParamField(0xC, ParamType.F32)]
        public float BeginDist
        {
            get => _BeginDist;
            set => WriteParamField(ref _BeginDist, value);
        }
        private float _BeginDist;

        [ParamField(0x10, ParamType.F32)]
        public float EndDist
        {
            get => _EndDist;
            set => WriteParamField(ref _EndDist, value);
        }
        private float _EndDist;

        [ParamField(0x14, ParamType.F32)]
        public float CalibulateFar
        {
            get => _CalibulateFar;
            set => WriteParamField(ref _CalibulateFar, value);
        }
        private float _CalibulateFar;

        [ParamField(0x18, ParamType.F32)]
        public float FadeBeginDist
        {
            get => _FadeBeginDist;
            set => WriteParamField(ref _FadeBeginDist, value);
        }
        private float _FadeBeginDist;

        [ParamField(0x1C, ParamType.F32)]
        public float FadeDist
        {
            get => _FadeDist;
            set => WriteParamField(ref _FadeDist, value);
        }
        private float _FadeDist;

        [ParamField(0x20, ParamType.F32)]
        public float PersedDepthOffset
        {
            get => _PersedDepthOffset;
            set => WriteParamField(ref _PersedDepthOffset, value);
        }
        private float _PersedDepthOffset;

        [ParamField(0x24, ParamType.F32)]
        public float ＧradFactor
        {
            get => _ＧradFactor;
            set => WriteParamField(ref _ＧradFactor, value);
        }
        private float _ＧradFactor;

        [ParamField(0x28, ParamType.F32)]
        public float ShadowVolumeDepth
        {
            get => _ShadowVolumeDepth;
            set => WriteParamField(ref _ShadowVolumeDepth, value);
        }
        private float _ShadowVolumeDepth;

    }
}
