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
    public class LodBank : BaseParam
    {
        public LodBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float Lv01_BorderDist
        {
            get => _Lv01_BorderDist;
            set => WriteParamField(ref _Lv01_BorderDist, value);
        }
        private float _Lv01_BorderDist;

        [ParamField(0x4, ParamType.F32)]
        public float Lv01_PlayDist
        {
            get => _Lv01_PlayDist;
            set => WriteParamField(ref _Lv01_PlayDist, value);
        }
        private float _Lv01_PlayDist;

        [ParamField(0x8, ParamType.F32)]
        public float Lv12_BorderDist
        {
            get => _Lv12_BorderDist;
            set => WriteParamField(ref _Lv12_BorderDist, value);
        }
        private float _Lv12_BorderDist;

        [ParamField(0xC, ParamType.F32)]
        public float Lv12_PlayDist
        {
            get => _Lv12_PlayDist;
            set => WriteParamField(ref _Lv12_PlayDist, value);
        }
        private float _Lv12_PlayDist;

    }
}
