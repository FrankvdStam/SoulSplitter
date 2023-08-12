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
    public class AiStandardInfo : BaseParam
    {
        public AiStandardInfo(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.U16)]
        public ushort RadarRange
        {
            get => _RadarRange;
            set => WriteParamField(ref _RadarRange, value);
        }
        private ushort _RadarRange;

        [ParamField(0x2, ParamType.U8)]
        public byte RadarAngleX
        {
            get => _RadarAngleX;
            set => WriteParamField(ref _RadarAngleX, value);
        }
        private byte _RadarAngleX;

        [ParamField(0x3, ParamType.U8)]
        public byte RadarAngleY
        {
            get => _RadarAngleY;
            set => WriteParamField(ref _RadarAngleY, value);
        }
        private byte _RadarAngleY;

        [ParamField(0x4, ParamType.U16)]
        public ushort TerritorySize
        {
            get => _TerritorySize;
            set => WriteParamField(ref _TerritorySize, value);
        }
        private ushort _TerritorySize;

        [ParamField(0x6, ParamType.U8)]
        public byte ThreatBeforeAttackRate
        {
            get => _ThreatBeforeAttackRate;
            set => WriteParamField(ref _ThreatBeforeAttackRate, value);
        }
        private byte _ThreatBeforeAttackRate;

        [ParamField(0x7, ParamType.U8)]
        public byte ForceThreatOnFirstLocked
        {
            get => _ForceThreatOnFirstLocked;
            set => WriteParamField(ref _ForceThreatOnFirstLocked, value);
        }
        private byte _ForceThreatOnFirstLocked;

        [ParamField(0x8, ParamType.Dummy8, 24)]
        public byte[] Reserve0
        {
            get => _Reserve0;
            set => WriteParamField(ref _Reserve0, value);
        }
        private byte[] _Reserve0;

        [ParamField(0x20, ParamType.U16)]
        public ushort Attack1_Distance
        {
            get => _Attack1_Distance;
            set => WriteParamField(ref _Attack1_Distance, value);
        }
        private ushort _Attack1_Distance;

        [ParamField(0x22, ParamType.U16)]
        public ushort Attack1_Margin
        {
            get => _Attack1_Margin;
            set => WriteParamField(ref _Attack1_Margin, value);
        }
        private ushort _Attack1_Margin;

        [ParamField(0x24, ParamType.U8)]
        public byte Attack1_Rate
        {
            get => _Attack1_Rate;
            set => WriteParamField(ref _Attack1_Rate, value);
        }
        private byte _Attack1_Rate;

        [ParamField(0x25, ParamType.U8)]
        public byte Attack1_ActionID
        {
            get => _Attack1_ActionID;
            set => WriteParamField(ref _Attack1_ActionID, value);
        }
        private byte _Attack1_ActionID;

        [ParamField(0x26, ParamType.U8)]
        public byte Attack1_DelayMin
        {
            get => _Attack1_DelayMin;
            set => WriteParamField(ref _Attack1_DelayMin, value);
        }
        private byte _Attack1_DelayMin;

        [ParamField(0x27, ParamType.U8)]
        public byte Attack1_DelayMax
        {
            get => _Attack1_DelayMax;
            set => WriteParamField(ref _Attack1_DelayMax, value);
        }
        private byte _Attack1_DelayMax;

        [ParamField(0x28, ParamType.U8)]
        public byte Attack1_ConeAngle
        {
            get => _Attack1_ConeAngle;
            set => WriteParamField(ref _Attack1_ConeAngle, value);
        }
        private byte _Attack1_ConeAngle;

        [ParamField(0x29, ParamType.Dummy8, 7)]
        public byte[] Reserve10
        {
            get => _Reserve10;
            set => WriteParamField(ref _Reserve10, value);
        }
        private byte[] _Reserve10;

        [ParamField(0x30, ParamType.U16)]
        public ushort Attack2_Distance
        {
            get => _Attack2_Distance;
            set => WriteParamField(ref _Attack2_Distance, value);
        }
        private ushort _Attack2_Distance;

        [ParamField(0x32, ParamType.U16)]
        public ushort Attack2_Margin
        {
            get => _Attack2_Margin;
            set => WriteParamField(ref _Attack2_Margin, value);
        }
        private ushort _Attack2_Margin;

        [ParamField(0x34, ParamType.U8)]
        public byte Attack2_Rate
        {
            get => _Attack2_Rate;
            set => WriteParamField(ref _Attack2_Rate, value);
        }
        private byte _Attack2_Rate;

        [ParamField(0x35, ParamType.U8)]
        public byte Attack2_ActionID
        {
            get => _Attack2_ActionID;
            set => WriteParamField(ref _Attack2_ActionID, value);
        }
        private byte _Attack2_ActionID;

        [ParamField(0x36, ParamType.U8)]
        public byte Attack2_DelayMin
        {
            get => _Attack2_DelayMin;
            set => WriteParamField(ref _Attack2_DelayMin, value);
        }
        private byte _Attack2_DelayMin;

        [ParamField(0x37, ParamType.U8)]
        public byte Attack2_DelayMax
        {
            get => _Attack2_DelayMax;
            set => WriteParamField(ref _Attack2_DelayMax, value);
        }
        private byte _Attack2_DelayMax;

        [ParamField(0x38, ParamType.U8)]
        public byte Attack2_ConeAngle
        {
            get => _Attack2_ConeAngle;
            set => WriteParamField(ref _Attack2_ConeAngle, value);
        }
        private byte _Attack2_ConeAngle;

        [ParamField(0x39, ParamType.Dummy8, 7)]
        public byte[] Reserve11
        {
            get => _Reserve11;
            set => WriteParamField(ref _Reserve11, value);
        }
        private byte[] _Reserve11;

        [ParamField(0x40, ParamType.U16)]
        public ushort Attack3_Distance
        {
            get => _Attack3_Distance;
            set => WriteParamField(ref _Attack3_Distance, value);
        }
        private ushort _Attack3_Distance;

        [ParamField(0x42, ParamType.U16)]
        public ushort Attack3_Margin
        {
            get => _Attack3_Margin;
            set => WriteParamField(ref _Attack3_Margin, value);
        }
        private ushort _Attack3_Margin;

        [ParamField(0x44, ParamType.U8)]
        public byte Attack3_Rate
        {
            get => _Attack3_Rate;
            set => WriteParamField(ref _Attack3_Rate, value);
        }
        private byte _Attack3_Rate;

        [ParamField(0x45, ParamType.U8)]
        public byte Attack3_ActionID
        {
            get => _Attack3_ActionID;
            set => WriteParamField(ref _Attack3_ActionID, value);
        }
        private byte _Attack3_ActionID;

        [ParamField(0x46, ParamType.U8)]
        public byte Attack3_DelayMin
        {
            get => _Attack3_DelayMin;
            set => WriteParamField(ref _Attack3_DelayMin, value);
        }
        private byte _Attack3_DelayMin;

        [ParamField(0x47, ParamType.U8)]
        public byte Attack3_DelayMax
        {
            get => _Attack3_DelayMax;
            set => WriteParamField(ref _Attack3_DelayMax, value);
        }
        private byte _Attack3_DelayMax;

        [ParamField(0x48, ParamType.U8)]
        public byte Attack3_ConeAngle
        {
            get => _Attack3_ConeAngle;
            set => WriteParamField(ref _Attack3_ConeAngle, value);
        }
        private byte _Attack3_ConeAngle;

        [ParamField(0x49, ParamType.Dummy8, 7)]
        public byte[] Reserve12
        {
            get => _Reserve12;
            set => WriteParamField(ref _Reserve12, value);
        }
        private byte[] _Reserve12;

        [ParamField(0x50, ParamType.U16)]
        public ushort Attack4_Distance
        {
            get => _Attack4_Distance;
            set => WriteParamField(ref _Attack4_Distance, value);
        }
        private ushort _Attack4_Distance;

        [ParamField(0x52, ParamType.U16)]
        public ushort Attack4_Margin
        {
            get => _Attack4_Margin;
            set => WriteParamField(ref _Attack4_Margin, value);
        }
        private ushort _Attack4_Margin;

        [ParamField(0x54, ParamType.U8)]
        public byte Attack4_Rate
        {
            get => _Attack4_Rate;
            set => WriteParamField(ref _Attack4_Rate, value);
        }
        private byte _Attack4_Rate;

        [ParamField(0x55, ParamType.U8)]
        public byte Attack4_ActionID
        {
            get => _Attack4_ActionID;
            set => WriteParamField(ref _Attack4_ActionID, value);
        }
        private byte _Attack4_ActionID;

        [ParamField(0x56, ParamType.U8)]
        public byte Attack4_DelayMin
        {
            get => _Attack4_DelayMin;
            set => WriteParamField(ref _Attack4_DelayMin, value);
        }
        private byte _Attack4_DelayMin;

        [ParamField(0x57, ParamType.U8)]
        public byte Attack4_DelayMax
        {
            get => _Attack4_DelayMax;
            set => WriteParamField(ref _Attack4_DelayMax, value);
        }
        private byte _Attack4_DelayMax;

        [ParamField(0x58, ParamType.U8)]
        public byte Attack4_ConeAngle
        {
            get => _Attack4_ConeAngle;
            set => WriteParamField(ref _Attack4_ConeAngle, value);
        }
        private byte _Attack4_ConeAngle;

        [ParamField(0x59, ParamType.Dummy8, 7)]
        public byte[] Reserve13
        {
            get => _Reserve13;
            set => WriteParamField(ref _Reserve13, value);
        }
        private byte[] _Reserve13;

        [ParamField(0x60, ParamType.Dummy8, 32)]
        public byte[] Reserve_last
        {
            get => _Reserve_last;
            set => WriteParamField(ref _Reserve_last, value);
        }
        private byte[] _Reserve_last;

    }
}
