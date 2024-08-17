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
    public class SpEffectVfx : BaseParam
    {
        public SpEffectVfx(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int MidstSfxId
        {
            get => _MidstSfxId;
            set => WriteParamField(ref _MidstSfxId, value);
        }
        private int _MidstSfxId;

        [ParamField(0x4, ParamType.I32)]
        public int MidstSeId
        {
            get => _MidstSeId;
            set => WriteParamField(ref _MidstSeId, value);
        }
        private int _MidstSeId;

        [ParamField(0x8, ParamType.I32)]
        public int InitSfxId
        {
            get => _InitSfxId;
            set => WriteParamField(ref _InitSfxId, value);
        }
        private int _InitSfxId;

        [ParamField(0xC, ParamType.I32)]
        public int InitSeId
        {
            get => _InitSeId;
            set => WriteParamField(ref _InitSeId, value);
        }
        private int _InitSeId;

        [ParamField(0x10, ParamType.I32)]
        public int FinishSfxId
        {
            get => _FinishSfxId;
            set => WriteParamField(ref _FinishSfxId, value);
        }
        private int _FinishSfxId;

        [ParamField(0x14, ParamType.I32)]
        public int FinishSeId
        {
            get => _FinishSeId;
            set => WriteParamField(ref _FinishSeId, value);
        }
        private int _FinishSeId;

        [ParamField(0x18, ParamType.F32)]
        public float CamouflageBeginDist
        {
            get => _CamouflageBeginDist;
            set => WriteParamField(ref _CamouflageBeginDist, value);
        }
        private float _CamouflageBeginDist;

        [ParamField(0x1C, ParamType.F32)]
        public float CamouflageEndDist
        {
            get => _CamouflageEndDist;
            set => WriteParamField(ref _CamouflageEndDist, value);
        }
        private float _CamouflageEndDist;

        [ParamField(0x20, ParamType.I32)]
        public int TransformProtectorId
        {
            get => _TransformProtectorId;
            set => WriteParamField(ref _TransformProtectorId, value);
        }
        private int _TransformProtectorId;

        [ParamField(0x24, ParamType.I16)]
        public short MidstDmyId
        {
            get => _MidstDmyId;
            set => WriteParamField(ref _MidstDmyId, value);
        }
        private short _MidstDmyId;

        [ParamField(0x26, ParamType.I16)]
        public short InitDmyId
        {
            get => _InitDmyId;
            set => WriteParamField(ref _InitDmyId, value);
        }
        private short _InitDmyId;

        [ParamField(0x28, ParamType.I16)]
        public short FinishDmyId
        {
            get => _FinishDmyId;
            set => WriteParamField(ref _FinishDmyId, value);
        }
        private short _FinishDmyId;

        [ParamField(0x2A, ParamType.U8)]
        public byte EffectType
        {
            get => _EffectType;
            set => WriteParamField(ref _EffectType, value);
        }
        private byte _EffectType;

        [ParamField(0x2B, ParamType.U8)]
        public byte SoulParamIdForWepEnchant
        {
            get => _SoulParamIdForWepEnchant;
            set => WriteParamField(ref _SoulParamIdForWepEnchant, value);
        }
        private byte _SoulParamIdForWepEnchant;

        [ParamField(0x2C, ParamType.U8)]
        public byte PlayCategory
        {
            get => _PlayCategory;
            set => WriteParamField(ref _PlayCategory, value);
        }
        private byte _PlayCategory;

        [ParamField(0x2D, ParamType.U8)]
        public byte PlayPriority
        {
            get => _PlayPriority;
            set => WriteParamField(ref _PlayPriority, value);
        }
        private byte _PlayPriority;

        #region BitField ExistEffectForLargeBitfield ==============================================================================

        [ParamField(0x2E, ParamType.U8)]
        public byte ExistEffectForLargeBitfield
        {
            get => _ExistEffectForLargeBitfield;
            set => WriteParamField(ref _ExistEffectForLargeBitfield, value);
        }
        private byte _ExistEffectForLargeBitfield;

        [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 0)]
        public byte ExistEffectForLarge
        {
            get => GetbitfieldValue(_ExistEffectForLargeBitfield);
            set => SetBitfieldValue(ref _ExistEffectForLargeBitfield, value);
        }

        [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 1)]
        public byte ExistEffectForSoul
        {
            get => GetbitfieldValue(_ExistEffectForLargeBitfield);
            set => SetBitfieldValue(ref _ExistEffectForLargeBitfield, value);
        }

        [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 2)]
        public byte EffectInvisibleAtCamouflage
        {
            get => GetbitfieldValue(_ExistEffectForLargeBitfield);
            set => SetBitfieldValue(ref _ExistEffectForLargeBitfield, value);
        }

        [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 3)]
        public byte UseCamouflage
        {
            get => GetbitfieldValue(_ExistEffectForLargeBitfield);
            set => SetBitfieldValue(ref _ExistEffectForLargeBitfield, value);
        }

        [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 4)]
        public byte InvisibleAtFriendCamouflage
        {
            get => GetbitfieldValue(_ExistEffectForLargeBitfield);
            set => SetBitfieldValue(ref _ExistEffectForLargeBitfield, value);
        }

        [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 5)]
        public byte AddMapAreaBlockOffset
        {
            get => GetbitfieldValue(_ExistEffectForLargeBitfield);
            set => SetBitfieldValue(ref _ExistEffectForLargeBitfield, value);
        }

        [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 6)]
        public byte HalfCamouflage
        {
            get => GetbitfieldValue(_ExistEffectForLargeBitfield);
            set => SetBitfieldValue(ref _ExistEffectForLargeBitfield, value);
        }

        [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 7)]
        public byte IsFullBodyTransformProtectorId
        {
            get => GetbitfieldValue(_ExistEffectForLargeBitfield);
            set => SetBitfieldValue(ref _ExistEffectForLargeBitfield, value);
        }

        #endregion BitField ExistEffectForLargeBitfield

        #region BitField IsInvisibleWeaponBitfield ==============================================================================

        [ParamField(0x2F, ParamType.U8)]
        public byte IsInvisibleWeaponBitfield
        {
            get => _IsInvisibleWeaponBitfield;
            set => WriteParamField(ref _IsInvisibleWeaponBitfield, value);
        }
        private byte _IsInvisibleWeaponBitfield;

        [ParamBitField(nameof(IsInvisibleWeaponBitfield), bits: 1, bitsOffset: 0)]
        public byte IsInvisibleWeapon
        {
            get => GetbitfieldValue(_IsInvisibleWeaponBitfield);
            set => SetBitfieldValue(ref _IsInvisibleWeaponBitfield, value);
        }

        [ParamBitField(nameof(IsInvisibleWeaponBitfield), bits: 1, bitsOffset: 1)]
        public byte IsSilence
        {
            get => GetbitfieldValue(_IsInvisibleWeaponBitfield);
            set => SetBitfieldValue(ref _IsInvisibleWeaponBitfield, value);
        }

        [ParamBitField(nameof(IsInvisibleWeaponBitfield), bits: 6, bitsOffset: 2)]
        public byte Pad_1
        {
            get => GetbitfieldValue(_IsInvisibleWeaponBitfield);
            set => SetBitfieldValue(ref _IsInvisibleWeaponBitfield, value);
        }

        #endregion BitField IsInvisibleWeaponBitfield

        [ParamField(0x30, ParamType.Dummy8, 16)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad;

    }
}
