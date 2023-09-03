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
    public class CalcCorrectGraph : BaseParam
    {
        public CalcCorrectGraph(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float StageMaxVal0
        {
            get => _StageMaxVal0;
            set => WriteParamField(ref _StageMaxVal0, value);
        }
        private float _StageMaxVal0;

        [ParamField(0x4, ParamType.F32)]
        public float StageMaxVal1
        {
            get => _StageMaxVal1;
            set => WriteParamField(ref _StageMaxVal1, value);
        }
        private float _StageMaxVal1;

        [ParamField(0x8, ParamType.F32)]
        public float StageMaxVal2
        {
            get => _StageMaxVal2;
            set => WriteParamField(ref _StageMaxVal2, value);
        }
        private float _StageMaxVal2;

        [ParamField(0xC, ParamType.F32)]
        public float StageMaxVal3
        {
            get => _StageMaxVal3;
            set => WriteParamField(ref _StageMaxVal3, value);
        }
        private float _StageMaxVal3;

        [ParamField(0x10, ParamType.F32)]
        public float StageMaxVal4
        {
            get => _StageMaxVal4;
            set => WriteParamField(ref _StageMaxVal4, value);
        }
        private float _StageMaxVal4;

        [ParamField(0x14, ParamType.F32)]
        public float StageMaxGrowVal0
        {
            get => _StageMaxGrowVal0;
            set => WriteParamField(ref _StageMaxGrowVal0, value);
        }
        private float _StageMaxGrowVal0;

        [ParamField(0x18, ParamType.F32)]
        public float StageMaxGrowVal1
        {
            get => _StageMaxGrowVal1;
            set => WriteParamField(ref _StageMaxGrowVal1, value);
        }
        private float _StageMaxGrowVal1;

        [ParamField(0x1C, ParamType.F32)]
        public float StageMaxGrowVal2
        {
            get => _StageMaxGrowVal2;
            set => WriteParamField(ref _StageMaxGrowVal2, value);
        }
        private float _StageMaxGrowVal2;

        [ParamField(0x20, ParamType.F32)]
        public float StageMaxGrowVal3
        {
            get => _StageMaxGrowVal3;
            set => WriteParamField(ref _StageMaxGrowVal3, value);
        }
        private float _StageMaxGrowVal3;

        [ParamField(0x24, ParamType.F32)]
        public float StageMaxGrowVal4
        {
            get => _StageMaxGrowVal4;
            set => WriteParamField(ref _StageMaxGrowVal4, value);
        }
        private float _StageMaxGrowVal4;

        [ParamField(0x28, ParamType.F32)]
        public float AdjPt_maxGrowVal0
        {
            get => _AdjPt_maxGrowVal0;
            set => WriteParamField(ref _AdjPt_maxGrowVal0, value);
        }
        private float _AdjPt_maxGrowVal0;

        [ParamField(0x2C, ParamType.F32)]
        public float AdjPt_maxGrowVal1
        {
            get => _AdjPt_maxGrowVal1;
            set => WriteParamField(ref _AdjPt_maxGrowVal1, value);
        }
        private float _AdjPt_maxGrowVal1;

        [ParamField(0x30, ParamType.F32)]
        public float AdjPt_maxGrowVal2
        {
            get => _AdjPt_maxGrowVal2;
            set => WriteParamField(ref _AdjPt_maxGrowVal2, value);
        }
        private float _AdjPt_maxGrowVal2;

        [ParamField(0x34, ParamType.F32)]
        public float AdjPt_maxGrowVal3
        {
            get => _AdjPt_maxGrowVal3;
            set => WriteParamField(ref _AdjPt_maxGrowVal3, value);
        }
        private float _AdjPt_maxGrowVal3;

        [ParamField(0x38, ParamType.F32)]
        public float AdjPt_maxGrowVal4
        {
            get => _AdjPt_maxGrowVal4;
            set => WriteParamField(ref _AdjPt_maxGrowVal4, value);
        }
        private float _AdjPt_maxGrowVal4;

        [ParamField(0x3C, ParamType.F32)]
        public float Init_inclination_soul
        {
            get => _Init_inclination_soul;
            set => WriteParamField(ref _Init_inclination_soul, value);
        }
        private float _Init_inclination_soul;

        [ParamField(0x40, ParamType.F32)]
        public float Adjustment_value
        {
            get => _Adjustment_value;
            set => WriteParamField(ref _Adjustment_value, value);
        }
        private float _Adjustment_value;

        [ParamField(0x44, ParamType.F32)]
        public float Boundry_inclination_soul
        {
            get => _Boundry_inclination_soul;
            set => WriteParamField(ref _Boundry_inclination_soul, value);
        }
        private float _Boundry_inclination_soul;

        [ParamField(0x48, ParamType.F32)]
        public float Boundry_value
        {
            get => _Boundry_value;
            set => WriteParamField(ref _Boundry_value, value);
        }
        private float _Boundry_value;

        [ParamField(0x4C, ParamType.Dummy8, 4)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad;

    }
}
