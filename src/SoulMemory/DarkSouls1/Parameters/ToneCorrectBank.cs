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

namespace SoulMemory.DarkSouls1.Parameters
{
    public class ToneCorrectBank : BaseParam
    {
        public ToneCorrectBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float BrightnessR
        {
            get => _BrightnessR;
            set => WriteParamField(ref _BrightnessR, value);
        }
        private float _BrightnessR;

        [ParamField(0x4, ParamType.F32)]
        public float BrightnessG
        {
            get => _BrightnessG;
            set => WriteParamField(ref _BrightnessG, value);
        }
        private float _BrightnessG;

        [ParamField(0x8, ParamType.F32)]
        public float BrightnessB
        {
            get => _BrightnessB;
            set => WriteParamField(ref _BrightnessB, value);
        }
        private float _BrightnessB;

        [ParamField(0xC, ParamType.F32)]
        public float ContrastR
        {
            get => _ContrastR;
            set => WriteParamField(ref _ContrastR, value);
        }
        private float _ContrastR;

        [ParamField(0x10, ParamType.F32)]
        public float ContrastG
        {
            get => _ContrastG;
            set => WriteParamField(ref _ContrastG, value);
        }
        private float _ContrastG;

        [ParamField(0x14, ParamType.F32)]
        public float ContrastB
        {
            get => _ContrastB;
            set => WriteParamField(ref _ContrastB, value);
        }
        private float _ContrastB;

        [ParamField(0x18, ParamType.F32)]
        public float Saturation
        {
            get => _Saturation;
            set => WriteParamField(ref _Saturation, value);
        }
        private float _Saturation;

        [ParamField(0x1C, ParamType.F32)]
        public float Hue
        {
            get => _Hue;
            set => WriteParamField(ref _Hue, value);
        }
        private float _Hue;

        [ParamField(0x20, ParamType.F32)]
        public float SfxMultiplier
        {
            get => _SfxMultiplier;
            set => WriteParamField(ref _SfxMultiplier, value);
        }
        private float _SfxMultiplier;

    }
}
