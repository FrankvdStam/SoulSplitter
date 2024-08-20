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
    public class SkeletonParam : BaseParam
    {
        public SkeletonParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float NeckTurnGain
        {
            get => _NeckTurnGain;
            set => WriteParamField(ref _NeckTurnGain, value);
        }
        private float _NeckTurnGain;

        [ParamField(0x4, ParamType.I16)]
        public short OriginalGroundHeightMS
        {
            get => _OriginalGroundHeightMS;
            set => WriteParamField(ref _OriginalGroundHeightMS, value);
        }
        private short _OriginalGroundHeightMS;

        [ParamField(0x6, ParamType.I16)]
        public short MinAnkleHeightMS
        {
            get => _MinAnkleHeightMS;
            set => WriteParamField(ref _MinAnkleHeightMS, value);
        }
        private short _MinAnkleHeightMS;

        [ParamField(0x8, ParamType.I16)]
        public short MaxAnkleHeightMS
        {
            get => _MaxAnkleHeightMS;
            set => WriteParamField(ref _MaxAnkleHeightMS, value);
        }
        private short _MaxAnkleHeightMS;

        [ParamField(0xA, ParamType.I16)]
        public short CosineMaxKneeAngle
        {
            get => _CosineMaxKneeAngle;
            set => WriteParamField(ref _CosineMaxKneeAngle, value);
        }
        private short _CosineMaxKneeAngle;

        [ParamField(0xC, ParamType.I16)]
        public short CosineMinKneeAngle
        {
            get => _CosineMinKneeAngle;
            set => WriteParamField(ref _CosineMinKneeAngle, value);
        }
        private short _CosineMinKneeAngle;

        [ParamField(0xE, ParamType.I16)]
        public short FootPlantedAnkleHeightMS
        {
            get => _FootPlantedAnkleHeightMS;
            set => WriteParamField(ref _FootPlantedAnkleHeightMS, value);
        }
        private short _FootPlantedAnkleHeightMS;

        [ParamField(0x10, ParamType.I16)]
        public short FootRaisedAnkleHeightMS
        {
            get => _FootRaisedAnkleHeightMS;
            set => WriteParamField(ref _FootRaisedAnkleHeightMS, value);
        }
        private short _FootRaisedAnkleHeightMS;

        [ParamField(0x12, ParamType.I16)]
        public short RaycastDistanceUp
        {
            get => _RaycastDistanceUp;
            set => WriteParamField(ref _RaycastDistanceUp, value);
        }
        private short _RaycastDistanceUp;

        [ParamField(0x14, ParamType.I16)]
        public short RaycastDistanceDown
        {
            get => _RaycastDistanceDown;
            set => WriteParamField(ref _RaycastDistanceDown, value);
        }
        private short _RaycastDistanceDown;

        [ParamField(0x16, ParamType.I16)]
        public short FootEndLS_X
        {
            get => _FootEndLS_X;
            set => WriteParamField(ref _FootEndLS_X, value);
        }
        private short _FootEndLS_X;

        [ParamField(0x18, ParamType.I16)]
        public short FootEndLS_Y
        {
            get => _FootEndLS_Y;
            set => WriteParamField(ref _FootEndLS_Y, value);
        }
        private short _FootEndLS_Y;

        [ParamField(0x1A, ParamType.I16)]
        public short FootEndLS_Z
        {
            get => _FootEndLS_Z;
            set => WriteParamField(ref _FootEndLS_Z, value);
        }
        private short _FootEndLS_Z;

        [ParamField(0x1C, ParamType.I16)]
        public short OnOffGain
        {
            get => _OnOffGain;
            set => WriteParamField(ref _OnOffGain, value);
        }
        private short _OnOffGain;

        [ParamField(0x1E, ParamType.I16)]
        public short GroundAscendingGain
        {
            get => _GroundAscendingGain;
            set => WriteParamField(ref _GroundAscendingGain, value);
        }
        private short _GroundAscendingGain;

        [ParamField(0x20, ParamType.I16)]
        public short GroundDescendingGain
        {
            get => _GroundDescendingGain;
            set => WriteParamField(ref _GroundDescendingGain, value);
        }
        private short _GroundDescendingGain;

        [ParamField(0x22, ParamType.I16)]
        public short FootRaisedGain
        {
            get => _FootRaisedGain;
            set => WriteParamField(ref _FootRaisedGain, value);
        }
        private short _FootRaisedGain;

        [ParamField(0x24, ParamType.I16)]
        public short FootPlantedGain
        {
            get => _FootPlantedGain;
            set => WriteParamField(ref _FootPlantedGain, value);
        }
        private short _FootPlantedGain;

        [ParamField(0x26, ParamType.I16)]
        public short FootUnlockGain
        {
            get => _FootUnlockGain;
            set => WriteParamField(ref _FootUnlockGain, value);
        }
        private short _FootUnlockGain;

        [ParamField(0x28, ParamType.U8)]
        public byte KneeAxisType
        {
            get => _KneeAxisType;
            set => WriteParamField(ref _KneeAxisType, value);
        }
        private byte _KneeAxisType;

        [ParamField(0x29, ParamType.U8)]
        public byte UseFootLocking
        {
            get => _UseFootLocking;
            set => WriteParamField(ref _UseFootLocking, value);
        }
        private byte _UseFootLocking;

        [ParamField(0x2A, ParamType.U8)]
        public byte FootPlacementOn
        {
            get => _FootPlacementOn;
            set => WriteParamField(ref _FootPlacementOn, value);
        }
        private byte _FootPlacementOn;

        [ParamField(0x2B, ParamType.U8)]
        public byte TwistKneeAxisType
        {
            get => _TwistKneeAxisType;
            set => WriteParamField(ref _TwistKneeAxisType, value);
        }
        private byte _TwistKneeAxisType;

        [ParamField(0x2C, ParamType.I8)]
        public sbyte NeckTurnPriority
        {
            get => _NeckTurnPriority;
            set => WriteParamField(ref _NeckTurnPriority, value);
        }
        private sbyte _NeckTurnPriority;

        [ParamField(0x2D, ParamType.U8)]
        public byte NeckTurnMaxAngle
        {
            get => _NeckTurnMaxAngle;
            set => WriteParamField(ref _NeckTurnMaxAngle, value);
        }
        private byte _NeckTurnMaxAngle;

        [ParamField(0x2E, ParamType.Dummy8, 2)]
        public byte[] Pad1
        {
            get => _Pad1;
            set => WriteParamField(ref _Pad1, value);
        }
        private byte[] _Pad1;

    }
}
