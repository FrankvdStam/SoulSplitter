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
    public class ItemLotParam : BaseParam
    {
        public ItemLotParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int LotItemId01
        {
            get => _LotItemId01;
            set => WriteParamField(ref _LotItemId01, value);
        }
        private int _LotItemId01;

        [ParamField(0x4, ParamType.I32)]
        public int LotItemId02
        {
            get => _LotItemId02;
            set => WriteParamField(ref _LotItemId02, value);
        }
        private int _LotItemId02;

        [ParamField(0x8, ParamType.I32)]
        public int LotItemId03
        {
            get => _LotItemId03;
            set => WriteParamField(ref _LotItemId03, value);
        }
        private int _LotItemId03;

        [ParamField(0xC, ParamType.I32)]
        public int LotItemId04
        {
            get => _LotItemId04;
            set => WriteParamField(ref _LotItemId04, value);
        }
        private int _LotItemId04;

        [ParamField(0x10, ParamType.I32)]
        public int LotItemId05
        {
            get => _LotItemId05;
            set => WriteParamField(ref _LotItemId05, value);
        }
        private int _LotItemId05;

        [ParamField(0x14, ParamType.I32)]
        public int LotItemId06
        {
            get => _LotItemId06;
            set => WriteParamField(ref _LotItemId06, value);
        }
        private int _LotItemId06;

        [ParamField(0x18, ParamType.I32)]
        public int LotItemId07
        {
            get => _LotItemId07;
            set => WriteParamField(ref _LotItemId07, value);
        }
        private int _LotItemId07;

        [ParamField(0x1C, ParamType.I32)]
        public int LotItemId08
        {
            get => _LotItemId08;
            set => WriteParamField(ref _LotItemId08, value);
        }
        private int _LotItemId08;

        [ParamField(0x20, ParamType.I32)]
        public int LotItemCategory01
        {
            get => _LotItemCategory01;
            set => WriteParamField(ref _LotItemCategory01, value);
        }
        private int _LotItemCategory01;

        [ParamField(0x24, ParamType.I32)]
        public int LotItemCategory02
        {
            get => _LotItemCategory02;
            set => WriteParamField(ref _LotItemCategory02, value);
        }
        private int _LotItemCategory02;

        [ParamField(0x28, ParamType.I32)]
        public int LotItemCategory03
        {
            get => _LotItemCategory03;
            set => WriteParamField(ref _LotItemCategory03, value);
        }
        private int _LotItemCategory03;

        [ParamField(0x2C, ParamType.I32)]
        public int LotItemCategory04
        {
            get => _LotItemCategory04;
            set => WriteParamField(ref _LotItemCategory04, value);
        }
        private int _LotItemCategory04;

        [ParamField(0x30, ParamType.I32)]
        public int LotItemCategory05
        {
            get => _LotItemCategory05;
            set => WriteParamField(ref _LotItemCategory05, value);
        }
        private int _LotItemCategory05;

        [ParamField(0x34, ParamType.I32)]
        public int LotItemCategory06
        {
            get => _LotItemCategory06;
            set => WriteParamField(ref _LotItemCategory06, value);
        }
        private int _LotItemCategory06;

        [ParamField(0x38, ParamType.I32)]
        public int LotItemCategory07
        {
            get => _LotItemCategory07;
            set => WriteParamField(ref _LotItemCategory07, value);
        }
        private int _LotItemCategory07;

        [ParamField(0x3C, ParamType.I32)]
        public int LotItemCategory08
        {
            get => _LotItemCategory08;
            set => WriteParamField(ref _LotItemCategory08, value);
        }
        private int _LotItemCategory08;

        [ParamField(0x40, ParamType.U16)]
        public ushort LotItemBasePoint01
        {
            get => _LotItemBasePoint01;
            set => WriteParamField(ref _LotItemBasePoint01, value);
        }
        private ushort _LotItemBasePoint01;

        [ParamField(0x42, ParamType.U16)]
        public ushort LotItemBasePoint02
        {
            get => _LotItemBasePoint02;
            set => WriteParamField(ref _LotItemBasePoint02, value);
        }
        private ushort _LotItemBasePoint02;

        [ParamField(0x44, ParamType.U16)]
        public ushort LotItemBasePoint03
        {
            get => _LotItemBasePoint03;
            set => WriteParamField(ref _LotItemBasePoint03, value);
        }
        private ushort _LotItemBasePoint03;

        [ParamField(0x46, ParamType.U16)]
        public ushort LotItemBasePoint04
        {
            get => _LotItemBasePoint04;
            set => WriteParamField(ref _LotItemBasePoint04, value);
        }
        private ushort _LotItemBasePoint04;

        [ParamField(0x48, ParamType.U16)]
        public ushort LotItemBasePoint05
        {
            get => _LotItemBasePoint05;
            set => WriteParamField(ref _LotItemBasePoint05, value);
        }
        private ushort _LotItemBasePoint05;

        [ParamField(0x4A, ParamType.U16)]
        public ushort LotItemBasePoint06
        {
            get => _LotItemBasePoint06;
            set => WriteParamField(ref _LotItemBasePoint06, value);
        }
        private ushort _LotItemBasePoint06;

        [ParamField(0x4C, ParamType.U16)]
        public ushort LotItemBasePoint07
        {
            get => _LotItemBasePoint07;
            set => WriteParamField(ref _LotItemBasePoint07, value);
        }
        private ushort _LotItemBasePoint07;

        [ParamField(0x4E, ParamType.U16)]
        public ushort LotItemBasePoint08
        {
            get => _LotItemBasePoint08;
            set => WriteParamField(ref _LotItemBasePoint08, value);
        }
        private ushort _LotItemBasePoint08;

        [ParamField(0x50, ParamType.U16)]
        public ushort CumulateLotPoint01
        {
            get => _CumulateLotPoint01;
            set => WriteParamField(ref _CumulateLotPoint01, value);
        }
        private ushort _CumulateLotPoint01;

        [ParamField(0x52, ParamType.U16)]
        public ushort CumulateLotPoint02
        {
            get => _CumulateLotPoint02;
            set => WriteParamField(ref _CumulateLotPoint02, value);
        }
        private ushort _CumulateLotPoint02;

        [ParamField(0x54, ParamType.U16)]
        public ushort CumulateLotPoint03
        {
            get => _CumulateLotPoint03;
            set => WriteParamField(ref _CumulateLotPoint03, value);
        }
        private ushort _CumulateLotPoint03;

        [ParamField(0x56, ParamType.U16)]
        public ushort CumulateLotPoint04
        {
            get => _CumulateLotPoint04;
            set => WriteParamField(ref _CumulateLotPoint04, value);
        }
        private ushort _CumulateLotPoint04;

        [ParamField(0x58, ParamType.U16)]
        public ushort CumulateLotPoint05
        {
            get => _CumulateLotPoint05;
            set => WriteParamField(ref _CumulateLotPoint05, value);
        }
        private ushort _CumulateLotPoint05;

        [ParamField(0x5A, ParamType.U16)]
        public ushort CumulateLotPoint06
        {
            get => _CumulateLotPoint06;
            set => WriteParamField(ref _CumulateLotPoint06, value);
        }
        private ushort _CumulateLotPoint06;

        [ParamField(0x5C, ParamType.U16)]
        public ushort CumulateLotPoint07
        {
            get => _CumulateLotPoint07;
            set => WriteParamField(ref _CumulateLotPoint07, value);
        }
        private ushort _CumulateLotPoint07;

        [ParamField(0x5E, ParamType.U16)]
        public ushort CumulateLotPoint08
        {
            get => _CumulateLotPoint08;
            set => WriteParamField(ref _CumulateLotPoint08, value);
        }
        private ushort _CumulateLotPoint08;

        [ParamField(0x60, ParamType.I32)]
        public int GetItemFlagId01
        {
            get => _GetItemFlagId01;
            set => WriteParamField(ref _GetItemFlagId01, value);
        }
        private int _GetItemFlagId01;

        [ParamField(0x64, ParamType.I32)]
        public int GetItemFlagId02
        {
            get => _GetItemFlagId02;
            set => WriteParamField(ref _GetItemFlagId02, value);
        }
        private int _GetItemFlagId02;

        [ParamField(0x68, ParamType.I32)]
        public int GetItemFlagId03
        {
            get => _GetItemFlagId03;
            set => WriteParamField(ref _GetItemFlagId03, value);
        }
        private int _GetItemFlagId03;

        [ParamField(0x6C, ParamType.I32)]
        public int GetItemFlagId04
        {
            get => _GetItemFlagId04;
            set => WriteParamField(ref _GetItemFlagId04, value);
        }
        private int _GetItemFlagId04;

        [ParamField(0x70, ParamType.I32)]
        public int GetItemFlagId05
        {
            get => _GetItemFlagId05;
            set => WriteParamField(ref _GetItemFlagId05, value);
        }
        private int _GetItemFlagId05;

        [ParamField(0x74, ParamType.I32)]
        public int GetItemFlagId06
        {
            get => _GetItemFlagId06;
            set => WriteParamField(ref _GetItemFlagId06, value);
        }
        private int _GetItemFlagId06;

        [ParamField(0x78, ParamType.I32)]
        public int GetItemFlagId07
        {
            get => _GetItemFlagId07;
            set => WriteParamField(ref _GetItemFlagId07, value);
        }
        private int _GetItemFlagId07;

        [ParamField(0x7C, ParamType.I32)]
        public int GetItemFlagId08
        {
            get => _GetItemFlagId08;
            set => WriteParamField(ref _GetItemFlagId08, value);
        }
        private int _GetItemFlagId08;

        [ParamField(0x80, ParamType.I32)]
        public int GetItemFlagId
        {
            get => _GetItemFlagId;
            set => WriteParamField(ref _GetItemFlagId, value);
        }
        private int _GetItemFlagId;

        [ParamField(0x84, ParamType.I32)]
        public int CumulateNumFlagId
        {
            get => _CumulateNumFlagId;
            set => WriteParamField(ref _CumulateNumFlagId, value);
        }
        private int _CumulateNumFlagId;

        [ParamField(0x88, ParamType.U8)]
        public byte CumulateNumMax
        {
            get => _CumulateNumMax;
            set => WriteParamField(ref _CumulateNumMax, value);
        }
        private byte _CumulateNumMax;

        [ParamField(0x89, ParamType.U8)]
        public byte LotItem_Rarity
        {
            get => _LotItem_Rarity;
            set => WriteParamField(ref _LotItem_Rarity, value);
        }
        private byte _LotItem_Rarity;

        [ParamField(0x8A, ParamType.U8)]
        public byte LotItemNum01
        {
            get => _LotItemNum01;
            set => WriteParamField(ref _LotItemNum01, value);
        }
        private byte _LotItemNum01;

        [ParamField(0x8B, ParamType.U8)]
        public byte LotItemNum02
        {
            get => _LotItemNum02;
            set => WriteParamField(ref _LotItemNum02, value);
        }
        private byte _LotItemNum02;

        [ParamField(0x8C, ParamType.U8)]
        public byte LotItemNum03
        {
            get => _LotItemNum03;
            set => WriteParamField(ref _LotItemNum03, value);
        }
        private byte _LotItemNum03;

        [ParamField(0x8D, ParamType.U8)]
        public byte LotItemNum04
        {
            get => _LotItemNum04;
            set => WriteParamField(ref _LotItemNum04, value);
        }
        private byte _LotItemNum04;

        [ParamField(0x8E, ParamType.U8)]
        public byte LotItemNum05
        {
            get => _LotItemNum05;
            set => WriteParamField(ref _LotItemNum05, value);
        }
        private byte _LotItemNum05;

        [ParamField(0x8F, ParamType.U8)]
        public byte LotItemNum06
        {
            get => _LotItemNum06;
            set => WriteParamField(ref _LotItemNum06, value);
        }
        private byte _LotItemNum06;

        [ParamField(0x90, ParamType.U8)]
        public byte LotItemNum07
        {
            get => _LotItemNum07;
            set => WriteParamField(ref _LotItemNum07, value);
        }
        private byte _LotItemNum07;

        [ParamField(0x91, ParamType.U8)]
        public byte LotItemNum08
        {
            get => _LotItemNum08;
            set => WriteParamField(ref _LotItemNum08, value);
        }
        private byte _LotItemNum08;

        #region BitField EnableLuck01Bitfield ==============================================================================

        [ParamField(0x92, ParamType.U16)]
        public ushort EnableLuck01Bitfield
        {
            get => _EnableLuck01Bitfield;
            set => WriteParamField(ref _EnableLuck01Bitfield, value);
        }
        private ushort _EnableLuck01Bitfield;

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 0)]
        public ushort EnableLuck01
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 1)]
        public ushort EnableLuck02
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 2)]
        public ushort EnableLuck03
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 3)]
        public ushort EnableLuck04
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 4)]
        public ushort EnableLuck05
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 5)]
        public ushort EnableLuck06
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 6)]
        public ushort EnableLuck07
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 7)]
        public ushort EnableLuck08
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 8)]
        public ushort CumulateReset01
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 9)]
        public ushort CumulateReset02
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 10)]
        public ushort CumulateReset03
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 11)]
        public ushort CumulateReset04
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 12)]
        public ushort CumulateReset05
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 13)]
        public ushort CumulateReset06
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 14)]
        public ushort CumulateReset07
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 15)]
        public ushort CumulateReset08
        {
            get => GetbitfieldValue(_EnableLuck01Bitfield);
            set => SetBitfieldValue(ref _EnableLuck01Bitfield, value);
        }

        #endregion BitField EnableLuck01Bitfield

    }
}
