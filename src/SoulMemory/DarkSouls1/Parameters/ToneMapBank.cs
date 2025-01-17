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

namespace SoulMemory.DarkSouls1.Parameters
{
    [ExcludeFromCodeCoverage]
    public class ToneMapBank : BaseParam
    {
        public ToneMapBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I16)]
        public short BloomBegin
        {
            get => _BloomBegin;
            set => WriteParamField(ref _BloomBegin, value);
        }
        private short _BloomBegin;

        [ParamField(0x2, ParamType.I16)]
        public short BloomMul
        {
            get => _BloomMul;
            set => WriteParamField(ref _BloomMul, value);
        }
        private short _BloomMul;

        [ParamField(0x4, ParamType.I16)]
        public short BloomBeginFar
        {
            get => _BloomBeginFar;
            set => WriteParamField(ref _BloomBeginFar, value);
        }
        private short _BloomBeginFar;

        [ParamField(0x6, ParamType.I16)]
        public short BloomMulFar
        {
            get => _BloomMulFar;
            set => WriteParamField(ref _BloomMulFar, value);
        }
        private short _BloomMulFar;

        [ParamField(0x8, ParamType.F32)]
        public float BloomNearDist
        {
            get => _BloomNearDist;
            set => WriteParamField(ref _BloomNearDist, value);
        }
        private float _BloomNearDist;

        [ParamField(0xC, ParamType.F32)]
        public float BloomFarDist
        {
            get => _BloomFarDist;
            set => WriteParamField(ref _BloomFarDist, value);
        }
        private float _BloomFarDist;

        [ParamField(0x10, ParamType.F32)]
        public float GrayKeyValue
        {
            get => _GrayKeyValue;
            set => WriteParamField(ref _GrayKeyValue, value);
        }
        private float _GrayKeyValue;

        [ParamField(0x14, ParamType.F32)]
        public float MinAdaptedLum
        {
            get => _MinAdaptedLum;
            set => WriteParamField(ref _MinAdaptedLum, value);
        }
        private float _MinAdaptedLum;

        [ParamField(0x18, ParamType.F32)]
        public float MaxAdapredLum
        {
            get => _MaxAdapredLum;
            set => WriteParamField(ref _MaxAdapredLum, value);
        }
        private float _MaxAdapredLum;

        [ParamField(0x1C, ParamType.F32)]
        public float AdaptSpeed
        {
            get => _AdaptSpeed;
            set => WriteParamField(ref _AdaptSpeed, value);
        }
        private float _AdaptSpeed;

        [ParamField(0x20, ParamType.I8)]
        public sbyte LightShaftBegin
        {
            get => _LightShaftBegin;
            set => WriteParamField(ref _LightShaftBegin, value);
        }
        private sbyte _LightShaftBegin;

        [ParamField(0x21, ParamType.Dummy8, 3)]
        public byte[] Pad_0
        {
            get => _Pad_0;
            set => WriteParamField(ref _Pad_0, value);
        }
        private byte[] _Pad_0 = null!;

        [ParamField(0x24, ParamType.F32)]
        public float LightShaftPower
        {
            get => _LightShaftPower;
            set => WriteParamField(ref _LightShaftPower, value);
        }
        private float _LightShaftPower;

        [ParamField(0x28, ParamType.F32)]
        public float LightShaftAttenRate
        {
            get => _LightShaftAttenRate;
            set => WriteParamField(ref _LightShaftAttenRate, value);
        }
        private float _LightShaftAttenRate;

        [ParamField(0x2C, ParamType.F32)]
        public float InverseToneMapMul
        {
            get => _InverseToneMapMul;
            set => WriteParamField(ref _InverseToneMapMul, value);
        }
        private float _InverseToneMapMul;

    }
}
