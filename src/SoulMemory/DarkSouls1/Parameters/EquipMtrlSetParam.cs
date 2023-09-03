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
    public class EquipMtrlSetParam : BaseParam
    {
        public EquipMtrlSetParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int MaterialId01
        {
            get => _MaterialId01;
            set => WriteParamField(ref _MaterialId01, value);
        }
        private int _MaterialId01;

        [ParamField(0x4, ParamType.I32)]
        public int MaterialId02
        {
            get => _MaterialId02;
            set => WriteParamField(ref _MaterialId02, value);
        }
        private int _MaterialId02;

        [ParamField(0x8, ParamType.I32)]
        public int MaterialId03
        {
            get => _MaterialId03;
            set => WriteParamField(ref _MaterialId03, value);
        }
        private int _MaterialId03;

        [ParamField(0xC, ParamType.I32)]
        public int MaterialId04
        {
            get => _MaterialId04;
            set => WriteParamField(ref _MaterialId04, value);
        }
        private int _MaterialId04;

        [ParamField(0x10, ParamType.I32)]
        public int MaterialId05
        {
            get => _MaterialId05;
            set => WriteParamField(ref _MaterialId05, value);
        }
        private int _MaterialId05;

        [ParamField(0x14, ParamType.I8)]
        public sbyte ItemNum01
        {
            get => _ItemNum01;
            set => WriteParamField(ref _ItemNum01, value);
        }
        private sbyte _ItemNum01;

        [ParamField(0x15, ParamType.I8)]
        public sbyte ItemNum02
        {
            get => _ItemNum02;
            set => WriteParamField(ref _ItemNum02, value);
        }
        private sbyte _ItemNum02;

        [ParamField(0x16, ParamType.I8)]
        public sbyte ItemNum03
        {
            get => _ItemNum03;
            set => WriteParamField(ref _ItemNum03, value);
        }
        private sbyte _ItemNum03;

        [ParamField(0x17, ParamType.I8)]
        public sbyte ItemNum04
        {
            get => _ItemNum04;
            set => WriteParamField(ref _ItemNum04, value);
        }
        private sbyte _ItemNum04;

        [ParamField(0x18, ParamType.I8)]
        public sbyte ItemNum05
        {
            get => _ItemNum05;
            set => WriteParamField(ref _ItemNum05, value);
        }
        private sbyte _ItemNum05;

        #region BitField IsDisableDispNum01Bitfield ==============================================================================

        [ParamField(0x19, ParamType.U8)]
        public byte IsDisableDispNum01Bitfield
        {
            get => _IsDisableDispNum01Bitfield;
            set => WriteParamField(ref _IsDisableDispNum01Bitfield, value);
        }
        private byte _IsDisableDispNum01Bitfield;

        [ParamBitField(nameof(IsDisableDispNum01Bitfield), bits: 1, bitsOffset: 0)]
        public byte IsDisableDispNum01
        {
            get => GetbitfieldValue(_IsDisableDispNum01Bitfield);
            set => SetBitfieldValue(ref _IsDisableDispNum01Bitfield, value);
        }

        [ParamBitField(nameof(IsDisableDispNum01Bitfield), bits: 1, bitsOffset: 1)]
        public byte IsDisableDispNum02
        {
            get => GetbitfieldValue(_IsDisableDispNum01Bitfield);
            set => SetBitfieldValue(ref _IsDisableDispNum01Bitfield, value);
        }

        [ParamBitField(nameof(IsDisableDispNum01Bitfield), bits: 1, bitsOffset: 2)]
        public byte IsDisableDispNum03
        {
            get => GetbitfieldValue(_IsDisableDispNum01Bitfield);
            set => SetBitfieldValue(ref _IsDisableDispNum01Bitfield, value);
        }

        [ParamBitField(nameof(IsDisableDispNum01Bitfield), bits: 1, bitsOffset: 3)]
        public byte IsDisableDispNum04
        {
            get => GetbitfieldValue(_IsDisableDispNum01Bitfield);
            set => SetBitfieldValue(ref _IsDisableDispNum01Bitfield, value);
        }

        [ParamBitField(nameof(IsDisableDispNum01Bitfield), bits: 1, bitsOffset: 4)]
        public byte IsDisableDispNum05
        {
            get => GetbitfieldValue(_IsDisableDispNum01Bitfield);
            set => SetBitfieldValue(ref _IsDisableDispNum01Bitfield, value);
        }

        #endregion BitField IsDisableDispNum01Bitfield

        [ParamField(0x1A, ParamType.Dummy8, 6)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad;

    }
}
