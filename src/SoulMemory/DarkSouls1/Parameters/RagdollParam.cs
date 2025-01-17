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
    public class RagdollParam : BaseParam
    {
        public RagdollParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float HierarchyGain
        {
            get => _HierarchyGain;
            set => WriteParamField(ref _HierarchyGain, value);
        }
        private float _HierarchyGain;

        [ParamField(0x4, ParamType.F32)]
        public float VelocityDamping
        {
            get => _VelocityDamping;
            set => WriteParamField(ref _VelocityDamping, value);
        }
        private float _VelocityDamping;

        [ParamField(0x8, ParamType.F32)]
        public float AccelGain
        {
            get => _AccelGain;
            set => WriteParamField(ref _AccelGain, value);
        }
        private float _AccelGain;

        [ParamField(0xC, ParamType.F32)]
        public float VelocityGain
        {
            get => _VelocityGain;
            set => WriteParamField(ref _VelocityGain, value);
        }
        private float _VelocityGain;

        [ParamField(0x10, ParamType.F32)]
        public float PositionGain
        {
            get => _PositionGain;
            set => WriteParamField(ref _PositionGain, value);
        }
        private float _PositionGain;

        [ParamField(0x14, ParamType.F32)]
        public float MaxLinerVelocity
        {
            get => _MaxLinerVelocity;
            set => WriteParamField(ref _MaxLinerVelocity, value);
        }
        private float _MaxLinerVelocity;

        [ParamField(0x18, ParamType.F32)]
        public float MaxAngularVelocity
        {
            get => _MaxAngularVelocity;
            set => WriteParamField(ref _MaxAngularVelocity, value);
        }
        private float _MaxAngularVelocity;

        [ParamField(0x1C, ParamType.F32)]
        public float SnapGain
        {
            get => _SnapGain;
            set => WriteParamField(ref _SnapGain, value);
        }
        private float _SnapGain;

        [ParamField(0x20, ParamType.U8)]
        public byte Enable
        {
            get => _Enable;
            set => WriteParamField(ref _Enable, value);
        }
        private byte _Enable;

        [ParamField(0x21, ParamType.I8)]
        public sbyte PartsHitMaskNo
        {
            get => _PartsHitMaskNo;
            set => WriteParamField(ref _PartsHitMaskNo, value);
        }
        private sbyte _PartsHitMaskNo;

        [ParamField(0x22, ParamType.Dummy8, 14)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad = null!;

    }
}
