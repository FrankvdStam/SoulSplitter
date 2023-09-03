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
    public class ShopLineupParam : BaseParam
    {
        public ShopLineupParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int EquipId
        {
            get => _EquipId;
            set => WriteParamField(ref _EquipId, value);
        }
        private int _EquipId;

        [ParamField(0x4, ParamType.I32)]
        public int Value
        {
            get => _Value;
            set => WriteParamField(ref _Value, value);
        }
        private int _Value;

        [ParamField(0x8, ParamType.I32)]
        public int MtrlId
        {
            get => _MtrlId;
            set => WriteParamField(ref _MtrlId, value);
        }
        private int _MtrlId;

        [ParamField(0xC, ParamType.I32)]
        public int EventFlag
        {
            get => _EventFlag;
            set => WriteParamField(ref _EventFlag, value);
        }
        private int _EventFlag;

        [ParamField(0x10, ParamType.I32)]
        public int QwcId
        {
            get => _QwcId;
            set => WriteParamField(ref _QwcId, value);
        }
        private int _QwcId;

        [ParamField(0x14, ParamType.I16)]
        public short SellQuantity
        {
            get => _SellQuantity;
            set => WriteParamField(ref _SellQuantity, value);
        }
        private short _SellQuantity;

        [ParamField(0x16, ParamType.U8)]
        public byte ShopType
        {
            get => _ShopType;
            set => WriteParamField(ref _ShopType, value);
        }
        private byte _ShopType;

        [ParamField(0x17, ParamType.U8)]
        public byte EquipType
        {
            get => _EquipType;
            set => WriteParamField(ref _EquipType, value);
        }
        private byte _EquipType;

        [ParamField(0x18, ParamType.Dummy8, 8)]
        public byte[] Pad_0
        {
            get => _Pad_0;
            set => WriteParamField(ref _Pad_0, value);
        }
        private byte[] _Pad_0;

    }
}
