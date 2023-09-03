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
    public class DofBank : BaseParam
    {
        public DofBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float FarDofBegin
        {
            get => _FarDofBegin;
            set => WriteParamField(ref _FarDofBegin, value);
        }
        private float _FarDofBegin;

        [ParamField(0x4, ParamType.F32)]
        public float FarDofEnd
        {
            get => _FarDofEnd;
            set => WriteParamField(ref _FarDofEnd, value);
        }
        private float _FarDofEnd;

        [ParamField(0x8, ParamType.U8)]
        public byte FarDofMul
        {
            get => _FarDofMul;
            set => WriteParamField(ref _FarDofMul, value);
        }
        private byte _FarDofMul;

        [ParamField(0x9, ParamType.Dummy8, 3)]
        public byte[] Pad_0
        {
            get => _Pad_0;
            set => WriteParamField(ref _Pad_0, value);
        }
        private byte[] _Pad_0;

        [ParamField(0xC, ParamType.F32)]
        public float NearDofBegin
        {
            get => _NearDofBegin;
            set => WriteParamField(ref _NearDofBegin, value);
        }
        private float _NearDofBegin;

        [ParamField(0x10, ParamType.F32)]
        public float NearDofEnd
        {
            get => _NearDofEnd;
            set => WriteParamField(ref _NearDofEnd, value);
        }
        private float _NearDofEnd;

        [ParamField(0x14, ParamType.U8)]
        public byte NearDofMul
        {
            get => _NearDofMul;
            set => WriteParamField(ref _NearDofMul, value);
        }
        private byte _NearDofMul;

        [ParamField(0x15, ParamType.Dummy8, 3)]
        public byte[] Pad_1
        {
            get => _Pad_1;
            set => WriteParamField(ref _Pad_1, value);
        }
        private byte[] _Pad_1;

        [ParamField(0x18, ParamType.F32)]
        public float DispersionSq
        {
            get => _DispersionSq;
            set => WriteParamField(ref _DispersionSq, value);
        }
        private float _DispersionSq;

    }
}
