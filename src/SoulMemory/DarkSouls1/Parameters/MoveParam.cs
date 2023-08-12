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
    public class MoveParam : BaseParam
    {
        public MoveParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int StayId
        {
            get => _StayId;
            set => WriteParamField(ref _StayId, value);
        }
        private int _StayId;

        [ParamField(0x4, ParamType.I32)]
        public int WalkF
        {
            get => _WalkF;
            set => WriteParamField(ref _WalkF, value);
        }
        private int _WalkF;

        [ParamField(0x8, ParamType.I32)]
        public int WalkB
        {
            get => _WalkB;
            set => WriteParamField(ref _WalkB, value);
        }
        private int _WalkB;

        [ParamField(0xC, ParamType.I32)]
        public int WalkL
        {
            get => _WalkL;
            set => WriteParamField(ref _WalkL, value);
        }
        private int _WalkL;

        [ParamField(0x10, ParamType.I32)]
        public int WalkR
        {
            get => _WalkR;
            set => WriteParamField(ref _WalkR, value);
        }
        private int _WalkR;

        [ParamField(0x14, ParamType.I32)]
        public int DashF
        {
            get => _DashF;
            set => WriteParamField(ref _DashF, value);
        }
        private int _DashF;

        [ParamField(0x18, ParamType.I32)]
        public int DashB
        {
            get => _DashB;
            set => WriteParamField(ref _DashB, value);
        }
        private int _DashB;

        [ParamField(0x1C, ParamType.I32)]
        public int DashL
        {
            get => _DashL;
            set => WriteParamField(ref _DashL, value);
        }
        private int _DashL;

        [ParamField(0x20, ParamType.I32)]
        public int DashR
        {
            get => _DashR;
            set => WriteParamField(ref _DashR, value);
        }
        private int _DashR;

        [ParamField(0x24, ParamType.I32)]
        public int SuperDash
        {
            get => _SuperDash;
            set => WriteParamField(ref _SuperDash, value);
        }
        private int _SuperDash;

        [ParamField(0x28, ParamType.I32)]
        public int EscapeF
        {
            get => _EscapeF;
            set => WriteParamField(ref _EscapeF, value);
        }
        private int _EscapeF;

        [ParamField(0x2C, ParamType.I32)]
        public int EscapeB
        {
            get => _EscapeB;
            set => WriteParamField(ref _EscapeB, value);
        }
        private int _EscapeB;

        [ParamField(0x30, ParamType.I32)]
        public int EscapeL
        {
            get => _EscapeL;
            set => WriteParamField(ref _EscapeL, value);
        }
        private int _EscapeL;

        [ParamField(0x34, ParamType.I32)]
        public int EscapeR
        {
            get => _EscapeR;
            set => WriteParamField(ref _EscapeR, value);
        }
        private int _EscapeR;

        [ParamField(0x38, ParamType.I32)]
        public int TurnL
        {
            get => _TurnL;
            set => WriteParamField(ref _TurnL, value);
        }
        private int _TurnL;

        [ParamField(0x3C, ParamType.I32)]
        public int TrunR
        {
            get => _TrunR;
            set => WriteParamField(ref _TrunR, value);
        }
        private int _TrunR;

        [ParamField(0x40, ParamType.I32)]
        public int LargeTurnL
        {
            get => _LargeTurnL;
            set => WriteParamField(ref _LargeTurnL, value);
        }
        private int _LargeTurnL;

        [ParamField(0x44, ParamType.I32)]
        public int LargeTurnR
        {
            get => _LargeTurnR;
            set => WriteParamField(ref _LargeTurnR, value);
        }
        private int _LargeTurnR;

        [ParamField(0x48, ParamType.I32)]
        public int StepMove
        {
            get => _StepMove;
            set => WriteParamField(ref _StepMove, value);
        }
        private int _StepMove;

        [ParamField(0x4C, ParamType.I32)]
        public int FlyStay
        {
            get => _FlyStay;
            set => WriteParamField(ref _FlyStay, value);
        }
        private int _FlyStay;

        [ParamField(0x50, ParamType.I32)]
        public int FlyWalkF
        {
            get => _FlyWalkF;
            set => WriteParamField(ref _FlyWalkF, value);
        }
        private int _FlyWalkF;

        [ParamField(0x54, ParamType.I32)]
        public int FlyWalkFL
        {
            get => _FlyWalkFL;
            set => WriteParamField(ref _FlyWalkFL, value);
        }
        private int _FlyWalkFL;

        [ParamField(0x58, ParamType.I32)]
        public int FlyWalkFR
        {
            get => _FlyWalkFR;
            set => WriteParamField(ref _FlyWalkFR, value);
        }
        private int _FlyWalkFR;

        [ParamField(0x5C, ParamType.I32)]
        public int FlyWalkFL2
        {
            get => _FlyWalkFL2;
            set => WriteParamField(ref _FlyWalkFL2, value);
        }
        private int _FlyWalkFL2;

        [ParamField(0x60, ParamType.I32)]
        public int FlyWalkFR2
        {
            get => _FlyWalkFR2;
            set => WriteParamField(ref _FlyWalkFR2, value);
        }
        private int _FlyWalkFR2;

        [ParamField(0x64, ParamType.I32)]
        public int FlyDashF
        {
            get => _FlyDashF;
            set => WriteParamField(ref _FlyDashF, value);
        }
        private int _FlyDashF;

        [ParamField(0x68, ParamType.I32)]
        public int FlyDashFL
        {
            get => _FlyDashFL;
            set => WriteParamField(ref _FlyDashFL, value);
        }
        private int _FlyDashFL;

        [ParamField(0x6C, ParamType.I32)]
        public int FlyDashFR
        {
            get => _FlyDashFR;
            set => WriteParamField(ref _FlyDashFR, value);
        }
        private int _FlyDashFR;

        [ParamField(0x70, ParamType.I32)]
        public int FlyDashFL2
        {
            get => _FlyDashFL2;
            set => WriteParamField(ref _FlyDashFL2, value);
        }
        private int _FlyDashFL2;

        [ParamField(0x74, ParamType.I32)]
        public int FlyDashFR2
        {
            get => _FlyDashFR2;
            set => WriteParamField(ref _FlyDashFR2, value);
        }
        private int _FlyDashFR2;

        [ParamField(0x78, ParamType.I32)]
        public int DashEscapeF
        {
            get => _DashEscapeF;
            set => WriteParamField(ref _DashEscapeF, value);
        }
        private int _DashEscapeF;

        [ParamField(0x7C, ParamType.I32)]
        public int DashEscapeB
        {
            get => _DashEscapeB;
            set => WriteParamField(ref _DashEscapeB, value);
        }
        private int _DashEscapeB;

        [ParamField(0x80, ParamType.I32)]
        public int DashEscapeL
        {
            get => _DashEscapeL;
            set => WriteParamField(ref _DashEscapeL, value);
        }
        private int _DashEscapeL;

        [ParamField(0x84, ParamType.I32)]
        public int DashEscapeR
        {
            get => _DashEscapeR;
            set => WriteParamField(ref _DashEscapeR, value);
        }
        private int _DashEscapeR;

        [ParamField(0x88, ParamType.I32)]
        public int AnalogMoveParamId
        {
            get => _AnalogMoveParamId;
            set => WriteParamField(ref _AnalogMoveParamId, value);
        }
        private int _AnalogMoveParamId;

        [ParamField(0x8C, ParamType.Dummy8, 4)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad;

    }
}
