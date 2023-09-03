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
    public class ReinforceParamProtector : BaseParam
    {
        public ReinforceParamProtector(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float PhysicsDefRate
        {
            get => _PhysicsDefRate;
            set => WriteParamField(ref _PhysicsDefRate, value);
        }
        private float _PhysicsDefRate;

        [ParamField(0x4, ParamType.F32)]
        public float MagicDefRate
        {
            get => _MagicDefRate;
            set => WriteParamField(ref _MagicDefRate, value);
        }
        private float _MagicDefRate;

        [ParamField(0x8, ParamType.F32)]
        public float FireDefRate
        {
            get => _FireDefRate;
            set => WriteParamField(ref _FireDefRate, value);
        }
        private float _FireDefRate;

        [ParamField(0xC, ParamType.F32)]
        public float ThunderDefRate
        {
            get => _ThunderDefRate;
            set => WriteParamField(ref _ThunderDefRate, value);
        }
        private float _ThunderDefRate;

        [ParamField(0x10, ParamType.F32)]
        public float SlashDefRate
        {
            get => _SlashDefRate;
            set => WriteParamField(ref _SlashDefRate, value);
        }
        private float _SlashDefRate;

        [ParamField(0x14, ParamType.F32)]
        public float BlowDefRate
        {
            get => _BlowDefRate;
            set => WriteParamField(ref _BlowDefRate, value);
        }
        private float _BlowDefRate;

        [ParamField(0x18, ParamType.F32)]
        public float ThrustDefRate
        {
            get => _ThrustDefRate;
            set => WriteParamField(ref _ThrustDefRate, value);
        }
        private float _ThrustDefRate;

        [ParamField(0x1C, ParamType.F32)]
        public float ResistPoisonRate
        {
            get => _ResistPoisonRate;
            set => WriteParamField(ref _ResistPoisonRate, value);
        }
        private float _ResistPoisonRate;

        [ParamField(0x20, ParamType.F32)]
        public float ResistDiseaseRate
        {
            get => _ResistDiseaseRate;
            set => WriteParamField(ref _ResistDiseaseRate, value);
        }
        private float _ResistDiseaseRate;

        [ParamField(0x24, ParamType.F32)]
        public float ResistBloodRate
        {
            get => _ResistBloodRate;
            set => WriteParamField(ref _ResistBloodRate, value);
        }
        private float _ResistBloodRate;

        [ParamField(0x28, ParamType.F32)]
        public float ResistCurseRate
        {
            get => _ResistCurseRate;
            set => WriteParamField(ref _ResistCurseRate, value);
        }
        private float _ResistCurseRate;

        [ParamField(0x2C, ParamType.U8)]
        public byte ResidentSpEffectId1
        {
            get => _ResidentSpEffectId1;
            set => WriteParamField(ref _ResidentSpEffectId1, value);
        }
        private byte _ResidentSpEffectId1;

        [ParamField(0x2D, ParamType.U8)]
        public byte ResidentSpEffectId2
        {
            get => _ResidentSpEffectId2;
            set => WriteParamField(ref _ResidentSpEffectId2, value);
        }
        private byte _ResidentSpEffectId2;

        [ParamField(0x2E, ParamType.U8)]
        public byte ResidentSpEffectId3
        {
            get => _ResidentSpEffectId3;
            set => WriteParamField(ref _ResidentSpEffectId3, value);
        }
        private byte _ResidentSpEffectId3;

        [ParamField(0x2F, ParamType.U8)]
        public byte MaterialSetId
        {
            get => _MaterialSetId;
            set => WriteParamField(ref _MaterialSetId, value);
        }
        private byte _MaterialSetId;

    }
}
