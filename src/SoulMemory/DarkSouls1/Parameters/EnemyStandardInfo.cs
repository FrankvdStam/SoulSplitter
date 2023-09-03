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
    public class EnemyStandardInfo : BaseParam
    {
        public EnemyStandardInfo(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int EnemyBehaviorID
        {
            get => _EnemyBehaviorID;
            set => WriteParamField(ref _EnemyBehaviorID, value);
        }
        private int _EnemyBehaviorID;

        [ParamField(0x4, ParamType.U16)]
        public ushort HP
        {
            get => _HP;
            set => WriteParamField(ref _HP, value);
        }
        private ushort _HP;

        [ParamField(0x6, ParamType.U16)]
        public ushort AttackPower
        {
            get => _AttackPower;
            set => WriteParamField(ref _AttackPower, value);
        }
        private ushort _AttackPower;

        [ParamField(0x8, ParamType.I32)]
        public int ChrType
        {
            get => _ChrType;
            set => WriteParamField(ref _ChrType, value);
        }
        private int _ChrType;

        [ParamField(0xC, ParamType.F32)]
        public float HitHeight
        {
            get => _HitHeight;
            set => WriteParamField(ref _HitHeight, value);
        }
        private float _HitHeight;

        [ParamField(0x10, ParamType.F32)]
        public float HitRadius
        {
            get => _HitRadius;
            set => WriteParamField(ref _HitRadius, value);
        }
        private float _HitRadius;

        [ParamField(0x14, ParamType.F32)]
        public float Weight
        {
            get => _Weight;
            set => WriteParamField(ref _Weight, value);
        }
        private float _Weight;

        [ParamField(0x18, ParamType.F32)]
        public float DynamicFriction
        {
            get => _DynamicFriction;
            set => WriteParamField(ref _DynamicFriction, value);
        }
        private float _DynamicFriction;

        [ParamField(0x1C, ParamType.F32)]
        public float StaticFriction
        {
            get => _StaticFriction;
            set => WriteParamField(ref _StaticFriction, value);
        }
        private float _StaticFriction;

        [ParamField(0x20, ParamType.I32)]
        public int UpperDefState
        {
            get => _UpperDefState;
            set => WriteParamField(ref _UpperDefState, value);
        }
        private int _UpperDefState;

        [ParamField(0x24, ParamType.I32)]
        public int ActionDefState
        {
            get => _ActionDefState;
            set => WriteParamField(ref _ActionDefState, value);
        }
        private int _ActionDefState;

        [ParamField(0x28, ParamType.F32)]
        public float RotY_per_Second
        {
            get => _RotY_per_Second;
            set => WriteParamField(ref _RotY_per_Second, value);
        }
        private float _RotY_per_Second;

        [ParamField(0x2C, ParamType.Dummy8, 20)]
        public byte[] Reserve0
        {
            get => _Reserve0;
            set => WriteParamField(ref _Reserve0, value);
        }
        private byte[] _Reserve0;

        [ParamField(0x40, ParamType.U8)]
        public byte RotY_per_Second_old
        {
            get => _RotY_per_Second_old;
            set => WriteParamField(ref _RotY_per_Second_old, value);
        }
        private byte _RotY_per_Second_old;

        [ParamField(0x41, ParamType.U8)]
        public byte EnableSideStep
        {
            get => _EnableSideStep;
            set => WriteParamField(ref _EnableSideStep, value);
        }
        private byte _EnableSideStep;

        [ParamField(0x42, ParamType.U8)]
        public byte UseRagdollHit
        {
            get => _UseRagdollHit;
            set => WriteParamField(ref _UseRagdollHit, value);
        }
        private byte _UseRagdollHit;

        [ParamField(0x43, ParamType.Dummy8, 5)]
        public byte[] Reserve_last
        {
            get => _Reserve_last;
            set => WriteParamField(ref _Reserve_last, value);
        }
        private byte[] _Reserve_last;

        [ParamField(0x48, ParamType.U16)]
        public ushort Stamina
        {
            get => _Stamina;
            set => WriteParamField(ref _Stamina, value);
        }
        private ushort _Stamina;

        [ParamField(0x4A, ParamType.U16)]
        public ushort StaminaRecover
        {
            get => _StaminaRecover;
            set => WriteParamField(ref _StaminaRecover, value);
        }
        private ushort _StaminaRecover;

        [ParamField(0x4C, ParamType.U16)]
        public ushort StaminaConsumption
        {
            get => _StaminaConsumption;
            set => WriteParamField(ref _StaminaConsumption, value);
        }
        private ushort _StaminaConsumption;

        [ParamField(0x4E, ParamType.U16)]
        public ushort Deffenct_Phys
        {
            get => _Deffenct_Phys;
            set => WriteParamField(ref _Deffenct_Phys, value);
        }
        private ushort _Deffenct_Phys;

        [ParamField(0x50, ParamType.Dummy8, 48)]
        public byte[] Reserve_last2
        {
            get => _Reserve_last2;
            set => WriteParamField(ref _Reserve_last2, value);
        }
        private byte[] _Reserve_last2;

    }
}
