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
    public class LensFlareBank : BaseParam
    {
        public LensFlareBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I8)]
        public sbyte TexId
        {
            get => _TexId;
            set => WriteParamField(ref _TexId, value);
        }
        private sbyte _TexId;

        [ParamField(0x1, ParamType.U8)]
        public byte IsFlare
        {
            get => _IsFlare;
            set => WriteParamField(ref _IsFlare, value);
        }
        private byte _IsFlare;

        [ParamField(0x2, ParamType.U8)]
        public byte EnableRoll
        {
            get => _EnableRoll;
            set => WriteParamField(ref _EnableRoll, value);
        }
        private byte _EnableRoll;

        [ParamField(0x3, ParamType.U8)]
        public byte EnableScale
        {
            get => _EnableScale;
            set => WriteParamField(ref _EnableScale, value);
        }
        private byte _EnableScale;

        [ParamField(0x4, ParamType.F32)]
        public float LocateDistRate
        {
            get => _LocateDistRate;
            set => WriteParamField(ref _LocateDistRate, value);
        }
        private float _LocateDistRate;

        [ParamField(0x8, ParamType.F32)]
        public float TexScale
        {
            get => _TexScale;
            set => WriteParamField(ref _TexScale, value);
        }
        private float _TexScale;

        [ParamField(0xC, ParamType.I16)]
        public short ColR
        {
            get => _ColR;
            set => WriteParamField(ref _ColR, value);
        }
        private short _ColR;

        [ParamField(0xE, ParamType.I16)]
        public short ColG
        {
            get => _ColG;
            set => WriteParamField(ref _ColG, value);
        }
        private short _ColG;

        [ParamField(0x10, ParamType.I16)]
        public short ColB
        {
            get => _ColB;
            set => WriteParamField(ref _ColB, value);
        }
        private short _ColB;

        [ParamField(0x12, ParamType.I16)]
        public short ColA
        {
            get => _ColA;
            set => WriteParamField(ref _ColA, value);
        }
        private short _ColA;

    }
}
