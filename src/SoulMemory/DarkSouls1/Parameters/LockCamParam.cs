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
    public class LockCamParam : BaseParam
    {
        public LockCamParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float CamDistTarget
        {
            get => _CamDistTarget;
            set => WriteParamField(ref _CamDistTarget, value);
        }
        private float _CamDistTarget;

        [ParamField(0x4, ParamType.F32)]
        public float RotRangeMinX
        {
            get => _RotRangeMinX;
            set => WriteParamField(ref _RotRangeMinX, value);
        }
        private float _RotRangeMinX;

        [ParamField(0x8, ParamType.F32)]
        public float LockRotXShiftRatio
        {
            get => _LockRotXShiftRatio;
            set => WriteParamField(ref _LockRotXShiftRatio, value);
        }
        private float _LockRotXShiftRatio;

        [ParamField(0xC, ParamType.F32)]
        public float ChrOrgOffset_Y
        {
            get => _ChrOrgOffset_Y;
            set => WriteParamField(ref _ChrOrgOffset_Y, value);
        }
        private float _ChrOrgOffset_Y;

        [ParamField(0x10, ParamType.F32)]
        public float ChrLockRangeMaxRadius
        {
            get => _ChrLockRangeMaxRadius;
            set => WriteParamField(ref _ChrLockRangeMaxRadius, value);
        }
        private float _ChrLockRangeMaxRadius;

        [ParamField(0x14, ParamType.F32)]
        public float CamFovY
        {
            get => _CamFovY;
            set => WriteParamField(ref _CamFovY, value);
        }
        private float _CamFovY;

        [ParamField(0x18, ParamType.Dummy8, 8)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad;

    }
}
