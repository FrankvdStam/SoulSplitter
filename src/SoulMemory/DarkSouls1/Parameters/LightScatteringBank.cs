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
    public class LightScatteringBank : BaseParam
    {
        public LightScatteringBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I16)]
        public short SunRotX
        {
            get => _SunRotX;
            set => WriteParamField(ref _SunRotX, value);
        }
        private short _SunRotX;

        [ParamField(0x2, ParamType.I16)]
        public short SunRotY
        {
            get => _SunRotY;
            set => WriteParamField(ref _SunRotY, value);
        }
        private short _SunRotY;

        [ParamField(0x4, ParamType.I16)]
        public short DistanceMul
        {
            get => _DistanceMul;
            set => WriteParamField(ref _DistanceMul, value);
        }
        private short _DistanceMul;

        [ParamField(0x6, ParamType.I16)]
        public short SunR
        {
            get => _SunR;
            set => WriteParamField(ref _SunR, value);
        }
        private short _SunR;

        [ParamField(0x8, ParamType.I16)]
        public short SunG
        {
            get => _SunG;
            set => WriteParamField(ref _SunG, value);
        }
        private short _SunG;

        [ParamField(0xA, ParamType.I16)]
        public short SunB
        {
            get => _SunB;
            set => WriteParamField(ref _SunB, value);
        }
        private short _SunB;

        [ParamField(0xC, ParamType.I16)]
        public short SunA
        {
            get => _SunA;
            set => WriteParamField(ref _SunA, value);
        }
        private short _SunA;

        [ParamField(0xE, ParamType.Dummy8, 2)]
        public byte[] Pad_0
        {
            get => _Pad_0;
            set => WriteParamField(ref _Pad_0, value);
        }
        private byte[] _Pad_0 = null!;

        [ParamField(0x10, ParamType.F32)]
        public float LsHGg
        {
            get => _LsHGg;
            set => WriteParamField(ref _LsHGg, value);
        }
        private float _LsHGg;

        [ParamField(0x14, ParamType.F32)]
        public float LsBetaRay
        {
            get => _LsBetaRay;
            set => WriteParamField(ref _LsBetaRay, value);
        }
        private float _LsBetaRay;

        [ParamField(0x18, ParamType.F32)]
        public float LsBetaMie
        {
            get => _LsBetaMie;
            set => WriteParamField(ref _LsBetaMie, value);
        }
        private float _LsBetaMie;

        [ParamField(0x1C, ParamType.I16)]
        public short BlendCoef
        {
            get => _BlendCoef;
            set => WriteParamField(ref _BlendCoef, value);
        }
        private short _BlendCoef;

        [ParamField(0x1E, ParamType.I16)]
        public short ReflectanceR
        {
            get => _ReflectanceR;
            set => WriteParamField(ref _ReflectanceR, value);
        }
        private short _ReflectanceR;

        [ParamField(0x20, ParamType.I16)]
        public short ReflectanceG
        {
            get => _ReflectanceG;
            set => WriteParamField(ref _ReflectanceG, value);
        }
        private short _ReflectanceG;

        [ParamField(0x22, ParamType.I16)]
        public short ReflectanceB
        {
            get => _ReflectanceB;
            set => WriteParamField(ref _ReflectanceB, value);
        }
        private short _ReflectanceB;

        [ParamField(0x24, ParamType.I16)]
        public short ReflectanceA
        {
            get => _ReflectanceA;
            set => WriteParamField(ref _ReflectanceA, value);
        }
        private short _ReflectanceA;

        [ParamField(0x26, ParamType.Dummy8, 2)]
        public byte[] Pad_1
        {
            get => _Pad_1;
            set => WriteParamField(ref _Pad_1, value);
        }
        private byte[] _Pad_1 = null!;

    }
}
