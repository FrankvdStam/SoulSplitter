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
    public class ObjectParam : BaseParam
    {
        public ObjectParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I16)]
        public short Hp
        {
            get => _Hp;
            set => WriteParamField(ref _Hp, value);
        }
        private short _Hp;

        [ParamField(0x2, ParamType.U16)]
        public ushort Defense
        {
            get => _Defense;
            set => WriteParamField(ref _Defense, value);
        }
        private ushort _Defense;

        [ParamField(0x4, ParamType.I16)]
        public short ExtRefTexId
        {
            get => _ExtRefTexId;
            set => WriteParamField(ref _ExtRefTexId, value);
        }
        private short _ExtRefTexId;

        [ParamField(0x6, ParamType.I16)]
        public short MaterialId
        {
            get => _MaterialId;
            set => WriteParamField(ref _MaterialId, value);
        }
        private short _MaterialId;

        [ParamField(0x8, ParamType.U8)]
        public byte AnimBreakIdMax
        {
            get => _AnimBreakIdMax;
            set => WriteParamField(ref _AnimBreakIdMax, value);
        }
        private byte _AnimBreakIdMax;

        #region BitField IsCamHitBitfield ==============================================================================

        [ParamField(0x9, ParamType.U8)]
        public byte IsCamHitBitfield
        {
            get => _IsCamHitBitfield;
            set => WriteParamField(ref _IsCamHitBitfield, value);
        }
        private byte _IsCamHitBitfield;

        [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 0)]
        public byte IsCamHit
        {
            get => GetbitfieldValue(_IsCamHitBitfield);
            set => SetBitfieldValue(ref _IsCamHitBitfield, value);
        }

        [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 1)]
        public byte IsBreakByPlayerCollide
        {
            get => GetbitfieldValue(_IsCamHitBitfield);
            set => SetBitfieldValue(ref _IsCamHitBitfield, value);
        }

        [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 2)]
        public byte IsAnimBreak
        {
            get => GetbitfieldValue(_IsCamHitBitfield);
            set => SetBitfieldValue(ref _IsCamHitBitfield, value);
        }

        [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 3)]
        public byte IsPenetrationBulletHit
        {
            get => GetbitfieldValue(_IsCamHitBitfield);
            set => SetBitfieldValue(ref _IsCamHitBitfield, value);
        }

        [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 4)]
        public byte IsChrHit
        {
            get => GetbitfieldValue(_IsCamHitBitfield);
            set => SetBitfieldValue(ref _IsCamHitBitfield, value);
        }

        [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 5)]
        public byte IsAttackBacklash
        {
            get => GetbitfieldValue(_IsCamHitBitfield);
            set => SetBitfieldValue(ref _IsCamHitBitfield, value);
        }

        [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 6)]
        public byte IsDisableBreakForFirstAppear
        {
            get => GetbitfieldValue(_IsCamHitBitfield);
            set => SetBitfieldValue(ref _IsCamHitBitfield, value);
        }

        [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 7)]
        public byte IsLadder
        {
            get => GetbitfieldValue(_IsCamHitBitfield);
            set => SetBitfieldValue(ref _IsCamHitBitfield, value);
        }

        #endregion BitField IsCamHitBitfield

        #region BitField IsAnimPauseOnRemoPlayBitfield ==============================================================================

        [ParamField(0xA, ParamType.U8)]
        public byte IsAnimPauseOnRemoPlayBitfield
        {
            get => _IsAnimPauseOnRemoPlayBitfield;
            set => WriteParamField(ref _IsAnimPauseOnRemoPlayBitfield, value);
        }
        private byte _IsAnimPauseOnRemoPlayBitfield;

        [ParamBitField(nameof(IsAnimPauseOnRemoPlayBitfield), bits: 1, bitsOffset: 0)]
        public byte IsAnimPauseOnRemoPlay
        {
            get => GetbitfieldValue(_IsAnimPauseOnRemoPlayBitfield);
            set => SetBitfieldValue(ref _IsAnimPauseOnRemoPlayBitfield, value);
        }

        [ParamBitField(nameof(IsAnimPauseOnRemoPlayBitfield), bits: 1, bitsOffset: 1)]
        public byte IsDamageNoHit
        {
            get => GetbitfieldValue(_IsAnimPauseOnRemoPlayBitfield);
            set => SetBitfieldValue(ref _IsAnimPauseOnRemoPlayBitfield, value);
        }

        [ParamBitField(nameof(IsAnimPauseOnRemoPlayBitfield), bits: 1, bitsOffset: 2)]
        public byte IsMoveObj
        {
            get => GetbitfieldValue(_IsAnimPauseOnRemoPlayBitfield);
            set => SetBitfieldValue(ref _IsAnimPauseOnRemoPlayBitfield, value);
        }

        [ParamBitField(nameof(IsAnimPauseOnRemoPlayBitfield), bits: 5, bitsOffset: 3)]
        public byte Pad_1
        {
            get => GetbitfieldValue(_IsAnimPauseOnRemoPlayBitfield);
            set => SetBitfieldValue(ref _IsAnimPauseOnRemoPlayBitfield, value);
        }

        #endregion BitField IsAnimPauseOnRemoPlayBitfield

        [ParamField(0xB, ParamType.I8)]
        public sbyte DefaultLodParamId
        {
            get => _DefaultLodParamId;
            set => WriteParamField(ref _DefaultLodParamId, value);
        }
        private sbyte _DefaultLodParamId;

        [ParamField(0xC, ParamType.I32)]
        public int BreakSfxId
        {
            get => _BreakSfxId;
            set => WriteParamField(ref _BreakSfxId, value);
        }
        private int _BreakSfxId;

    }
}
