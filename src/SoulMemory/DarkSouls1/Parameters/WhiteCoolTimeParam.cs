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
    public class WhiteCoolTimeParam : BaseParam
    {
        public WhiteCoolTimeParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float TimeLimit0
        {
            get => _TimeLimit0;
            set => WriteParamField(ref _TimeLimit0, value);
        }
        private float _TimeLimit0;

        [ParamField(0x4, ParamType.F32)]
        public float TimeLimit1
        {
            get => _TimeLimit1;
            set => WriteParamField(ref _TimeLimit1, value);
        }
        private float _TimeLimit1;

        [ParamField(0x8, ParamType.F32)]
        public float TimeLimit2
        {
            get => _TimeLimit2;
            set => WriteParamField(ref _TimeLimit2, value);
        }
        private float _TimeLimit2;

        [ParamField(0xC, ParamType.F32)]
        public float TimeLimit3
        {
            get => _TimeLimit3;
            set => WriteParamField(ref _TimeLimit3, value);
        }
        private float _TimeLimit3;

    }
}
