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
    public class CoolTimeParam : BaseParam
    {
        public CoolTimeParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float LimitationTime_0
        {
            get => _LimitationTime_0;
            set => WriteParamField(ref _LimitationTime_0, value);
        }
        private float _LimitationTime_0;

        [ParamField(0x4, ParamType.F32)]
        public float ObservationTime_0
        {
            get => _ObservationTime_0;
            set => WriteParamField(ref _ObservationTime_0, value);
        }
        private float _ObservationTime_0;

        [ParamField(0x8, ParamType.F32)]
        public float LimitationTime_1
        {
            get => _LimitationTime_1;
            set => WriteParamField(ref _LimitationTime_1, value);
        }
        private float _LimitationTime_1;

        [ParamField(0xC, ParamType.F32)]
        public float ObservationTime_1
        {
            get => _ObservationTime_1;
            set => WriteParamField(ref _ObservationTime_1, value);
        }
        private float _ObservationTime_1;

        [ParamField(0x10, ParamType.F32)]
        public float LimitationTime_2
        {
            get => _LimitationTime_2;
            set => WriteParamField(ref _LimitationTime_2, value);
        }
        private float _LimitationTime_2;

        [ParamField(0x14, ParamType.F32)]
        public float ObservationTime_2
        {
            get => _ObservationTime_2;
            set => WriteParamField(ref _ObservationTime_2, value);
        }
        private float _ObservationTime_2;

        [ParamField(0x18, ParamType.F32)]
        public float LimitationTime_3
        {
            get => _LimitationTime_3;
            set => WriteParamField(ref _LimitationTime_3, value);
        }
        private float _LimitationTime_3;

        [ParamField(0x1C, ParamType.F32)]
        public float ObservationTime_3
        {
            get => _ObservationTime_3;
            set => WriteParamField(ref _ObservationTime_3, value);
        }
        private float _ObservationTime_3;

    }
}
