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
    public class PointLightBank : BaseParam
    {
        public PointLightBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float DwindleBegin
        {
            get => _DwindleBegin;
            set => WriteParamField(ref _DwindleBegin, value);
        }
        private float _DwindleBegin;

        [ParamField(0x4, ParamType.F32)]
        public float DwindleEnd
        {
            get => _DwindleEnd;
            set => WriteParamField(ref _DwindleEnd, value);
        }
        private float _DwindleEnd;

        [ParamField(0x8, ParamType.I16)]
        public short ColR
        {
            get => _ColR;
            set => WriteParamField(ref _ColR, value);
        }
        private short _ColR;

        [ParamField(0xA, ParamType.I16)]
        public short ColG
        {
            get => _ColG;
            set => WriteParamField(ref _ColG, value);
        }
        private short _ColG;

        [ParamField(0xC, ParamType.I16)]
        public short ColB
        {
            get => _ColB;
            set => WriteParamField(ref _ColB, value);
        }
        private short _ColB;

        [ParamField(0xE, ParamType.I16)]
        public short ColA
        {
            get => _ColA;
            set => WriteParamField(ref _ColA, value);
        }
        private short _ColA;

    }
}
