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
    public class ThrowParam : BaseParam
    {
        public ThrowParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int AtkChrId
        {
            get => _AtkChrId;
            set => WriteParamField(ref _AtkChrId, value);
        }
        private int _AtkChrId;

        [ParamField(0x4, ParamType.I32)]
        public int DefChrId
        {
            get => _DefChrId;
            set => WriteParamField(ref _DefChrId, value);
        }
        private int _DefChrId;

        [ParamField(0x8, ParamType.F32)]
        public float Dist
        {
            get => _Dist;
            set => WriteParamField(ref _Dist, value);
        }
        private float _Dist;

        [ParamField(0xC, ParamType.F32)]
        public float DiffAngMin
        {
            get => _DiffAngMin;
            set => WriteParamField(ref _DiffAngMin, value);
        }
        private float _DiffAngMin;

        [ParamField(0x10, ParamType.F32)]
        public float DiffAngMax
        {
            get => _DiffAngMax;
            set => WriteParamField(ref _DiffAngMax, value);
        }
        private float _DiffAngMax;

        [ParamField(0x14, ParamType.F32)]
        public float UpperYRange
        {
            get => _UpperYRange;
            set => WriteParamField(ref _UpperYRange, value);
        }
        private float _UpperYRange;

        [ParamField(0x18, ParamType.F32)]
        public float LowerYRange
        {
            get => _LowerYRange;
            set => WriteParamField(ref _LowerYRange, value);
        }
        private float _LowerYRange;

        [ParamField(0x1C, ParamType.F32)]
        public float DiffAngMyToDef
        {
            get => _DiffAngMyToDef;
            set => WriteParamField(ref _DiffAngMyToDef, value);
        }
        private float _DiffAngMyToDef;

        [ParamField(0x20, ParamType.I32)]
        public int ThrowTypeId
        {
            get => _ThrowTypeId;
            set => WriteParamField(ref _ThrowTypeId, value);
        }
        private int _ThrowTypeId;

        [ParamField(0x24, ParamType.I32)]
        public int AtkAnimId
        {
            get => _AtkAnimId;
            set => WriteParamField(ref _AtkAnimId, value);
        }
        private int _AtkAnimId;

        [ParamField(0x28, ParamType.I32)]
        public int DefAnimId
        {
            get => _DefAnimId;
            set => WriteParamField(ref _DefAnimId, value);
        }
        private int _DefAnimId;

        [ParamField(0x2C, ParamType.U16)]
        public ushort EscHp
        {
            get => _EscHp;
            set => WriteParamField(ref _EscHp, value);
        }
        private ushort _EscHp;

        [ParamField(0x2E, ParamType.U16)]
        public ushort SelfEscCycleTime
        {
            get => _SelfEscCycleTime;
            set => WriteParamField(ref _SelfEscCycleTime, value);
        }
        private ushort _SelfEscCycleTime;

        [ParamField(0x30, ParamType.U16)]
        public ushort SphereCastRadiusRateTop
        {
            get => _SphereCastRadiusRateTop;
            set => WriteParamField(ref _SphereCastRadiusRateTop, value);
        }
        private ushort _SphereCastRadiusRateTop;

        [ParamField(0x32, ParamType.U16)]
        public ushort SphereCastRadiusRateLow
        {
            get => _SphereCastRadiusRateLow;
            set => WriteParamField(ref _SphereCastRadiusRateLow, value);
        }
        private ushort _SphereCastRadiusRateLow;

        [ParamField(0x34, ParamType.U8)]
        public byte PadType
        {
            get => _PadType;
            set => WriteParamField(ref _PadType, value);
        }
        private byte _PadType;

        [ParamField(0x35, ParamType.U8)]
        public byte AtkEnableState
        {
            get => _AtkEnableState;
            set => WriteParamField(ref _AtkEnableState, value);
        }
        private byte _AtkEnableState;

        [ParamField(0x36, ParamType.U8)]
        public byte AtkSorbDmyId
        {
            get => _AtkSorbDmyId;
            set => WriteParamField(ref _AtkSorbDmyId, value);
        }
        private byte _AtkSorbDmyId;

        [ParamField(0x37, ParamType.U8)]
        public byte DefSorbDmyId
        {
            get => _DefSorbDmyId;
            set => WriteParamField(ref _DefSorbDmyId, value);
        }
        private byte _DefSorbDmyId;

        [ParamField(0x38, ParamType.U8)]
        public byte ThrowType
        {
            get => _ThrowType;
            set => WriteParamField(ref _ThrowType, value);
        }
        private byte _ThrowType;

        [ParamField(0x39, ParamType.U8)]
        public byte SelfEscCycleCnt
        {
            get => _SelfEscCycleCnt;
            set => WriteParamField(ref _SelfEscCycleCnt, value);
        }
        private byte _SelfEscCycleCnt;

        [ParamField(0x3A, ParamType.U8)]
        public byte DmyHasChrDirType
        {
            get => _DmyHasChrDirType;
            set => WriteParamField(ref _DmyHasChrDirType, value);
        }
        private byte _DmyHasChrDirType;

        #region BitField IsTurnAtkerBitfield ==============================================================================

        [ParamField(0x3B, ParamType.U8)]
        public byte IsTurnAtkerBitfield
        {
            get => _IsTurnAtkerBitfield;
            set => WriteParamField(ref _IsTurnAtkerBitfield, value);
        }
        private byte _IsTurnAtkerBitfield;

        [ParamBitField(nameof(IsTurnAtkerBitfield), bits: 1, bitsOffset: 0)]
        public byte IsTurnAtker
        {
            get => GetbitfieldValue(_IsTurnAtkerBitfield);
            set => SetBitfieldValue(ref _IsTurnAtkerBitfield, value);
        }

        [ParamBitField(nameof(IsTurnAtkerBitfield), bits: 1, bitsOffset: 1)]
        public byte IsSkipWepCate
        {
            get => GetbitfieldValue(_IsTurnAtkerBitfield);
            set => SetBitfieldValue(ref _IsTurnAtkerBitfield, value);
        }

        [ParamBitField(nameof(IsTurnAtkerBitfield), bits: 1, bitsOffset: 2)]
        public byte IsSkipSphereCast
        {
            get => GetbitfieldValue(_IsTurnAtkerBitfield);
            set => SetBitfieldValue(ref _IsTurnAtkerBitfield, value);
        }

        [ParamBitField(nameof(IsTurnAtkerBitfield), bits: 5, bitsOffset: 3)]
        public byte Pad0
        {
            get => GetbitfieldValue(_IsTurnAtkerBitfield);
            set => SetBitfieldValue(ref _IsTurnAtkerBitfield, value);
        }

        #endregion BitField IsTurnAtkerBitfield

        [ParamField(0x3C, ParamType.Dummy8, 4)]
        public byte[] Pad1
        {
            get => _Pad1;
            set => WriteParamField(ref _Pad1, value);
        }
        private byte[] _Pad1 = null!;

    }
}
