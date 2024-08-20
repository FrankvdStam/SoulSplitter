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
    public class GameAreaParam : BaseParam
    {
        public GameAreaParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.U32)]
        public uint BonusSoul_single
        {
            get => _BonusSoul_single;
            set => WriteParamField(ref _BonusSoul_single, value);
        }
        private uint _BonusSoul_single;

        [ParamField(0x4, ParamType.U32)]
        public uint BonusSoul_multi
        {
            get => _BonusSoul_multi;
            set => WriteParamField(ref _BonusSoul_multi, value);
        }
        private uint _BonusSoul_multi;

        [ParamField(0x8, ParamType.I32)]
        public int HumanityPointCountFlagIdTop
        {
            get => _HumanityPointCountFlagIdTop;
            set => WriteParamField(ref _HumanityPointCountFlagIdTop, value);
        }
        private int _HumanityPointCountFlagIdTop;

        [ParamField(0xC, ParamType.U16)]
        public ushort HumanityDropPoint1
        {
            get => _HumanityDropPoint1;
            set => WriteParamField(ref _HumanityDropPoint1, value);
        }
        private ushort _HumanityDropPoint1;

        [ParamField(0xE, ParamType.U16)]
        public ushort HumanityDropPoint2
        {
            get => _HumanityDropPoint2;
            set => WriteParamField(ref _HumanityDropPoint2, value);
        }
        private ushort _HumanityDropPoint2;

        [ParamField(0x10, ParamType.U16)]
        public ushort HumanityDropPoint3
        {
            get => _HumanityDropPoint3;
            set => WriteParamField(ref _HumanityDropPoint3, value);
        }
        private ushort _HumanityDropPoint3;

        [ParamField(0x12, ParamType.U16)]
        public ushort HumanityDropPoint4
        {
            get => _HumanityDropPoint4;
            set => WriteParamField(ref _HumanityDropPoint4, value);
        }
        private ushort _HumanityDropPoint4;

        [ParamField(0x14, ParamType.U16)]
        public ushort HumanityDropPoint5
        {
            get => _HumanityDropPoint5;
            set => WriteParamField(ref _HumanityDropPoint5, value);
        }
        private ushort _HumanityDropPoint5;

        [ParamField(0x16, ParamType.U16)]
        public ushort HumanityDropPoint6
        {
            get => _HumanityDropPoint6;
            set => WriteParamField(ref _HumanityDropPoint6, value);
        }
        private ushort _HumanityDropPoint6;

        [ParamField(0x18, ParamType.U16)]
        public ushort HumanityDropPoint7
        {
            get => _HumanityDropPoint7;
            set => WriteParamField(ref _HumanityDropPoint7, value);
        }
        private ushort _HumanityDropPoint7;

        [ParamField(0x1A, ParamType.U16)]
        public ushort HumanityDropPoint8
        {
            get => _HumanityDropPoint8;
            set => WriteParamField(ref _HumanityDropPoint8, value);
        }
        private ushort _HumanityDropPoint8;

        [ParamField(0x1C, ParamType.U16)]
        public ushort HumanityDropPoint9
        {
            get => _HumanityDropPoint9;
            set => WriteParamField(ref _HumanityDropPoint9, value);
        }
        private ushort _HumanityDropPoint9;

        [ParamField(0x1E, ParamType.U16)]
        public ushort HumanityDropPoint10
        {
            get => _HumanityDropPoint10;
            set => WriteParamField(ref _HumanityDropPoint10, value);
        }
        private ushort _HumanityDropPoint10;

    }
}
