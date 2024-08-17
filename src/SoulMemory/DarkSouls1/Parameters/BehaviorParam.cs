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
    public class BehaviorParam : BaseParam
    {
        public BehaviorParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int VariationId
        {
            get => _VariationId;
            set => WriteParamField(ref _VariationId, value);
        }
        private int _VariationId;

        [ParamField(0x4, ParamType.I32)]
        public int BehaviorJudgeId
        {
            get => _BehaviorJudgeId;
            set => WriteParamField(ref _BehaviorJudgeId, value);
        }
        private int _BehaviorJudgeId;

        [ParamField(0x8, ParamType.U8)]
        public byte EzStateBehaviorType_old
        {
            get => _EzStateBehaviorType_old;
            set => WriteParamField(ref _EzStateBehaviorType_old, value);
        }
        private byte _EzStateBehaviorType_old;

        [ParamField(0x9, ParamType.U8)]
        public byte RefType
        {
            get => _RefType;
            set => WriteParamField(ref _RefType, value);
        }
        private byte _RefType;

        [ParamField(0xA, ParamType.Dummy8, 2)]
        public byte[] Pad0
        {
            get => _Pad0;
            set => WriteParamField(ref _Pad0, value);
        }
        private byte[] _Pad0;

        [ParamField(0xC, ParamType.I32)]
        public int RefId
        {
            get => _RefId;
            set => WriteParamField(ref _RefId, value);
        }
        private int _RefId;

        [ParamField(0x10, ParamType.I32)]
        public int SfxVariationId
        {
            get => _SfxVariationId;
            set => WriteParamField(ref _SfxVariationId, value);
        }
        private int _SfxVariationId;

        [ParamField(0x14, ParamType.I32)]
        public int Stamina
        {
            get => _Stamina;
            set => WriteParamField(ref _Stamina, value);
        }
        private int _Stamina;

        [ParamField(0x18, ParamType.I32)]
        public int Mp
        {
            get => _Mp;
            set => WriteParamField(ref _Mp, value);
        }
        private int _Mp;

        [ParamField(0x1C, ParamType.U8)]
        public byte Category
        {
            get => _Category;
            set => WriteParamField(ref _Category, value);
        }
        private byte _Category;

        [ParamField(0x1D, ParamType.U8)]
        public byte HeroPoint
        {
            get => _HeroPoint;
            set => WriteParamField(ref _HeroPoint, value);
        }
        private byte _HeroPoint;

        [ParamField(0x1E, ParamType.Dummy8, 2)]
        public byte[] Pad1
        {
            get => _Pad1;
            set => WriteParamField(ref _Pad1, value);
        }
        private byte[] _Pad1;

    }
}
