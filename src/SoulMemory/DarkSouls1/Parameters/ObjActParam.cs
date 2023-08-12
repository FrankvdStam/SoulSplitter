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
    public class ObjActParam : BaseParam
    {
        public ObjActParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int ActionEnableMsgId
        {
            get => _ActionEnableMsgId;
            set => WriteParamField(ref _ActionEnableMsgId, value);
        }
        private int _ActionEnableMsgId;

        [ParamField(0x4, ParamType.I32)]
        public int ActionFailedMsgId
        {
            get => _ActionFailedMsgId;
            set => WriteParamField(ref _ActionFailedMsgId, value);
        }
        private int _ActionFailedMsgId;

        [ParamField(0x8, ParamType.I32)]
        public int SpQualifiedPassEventFlag
        {
            get => _SpQualifiedPassEventFlag;
            set => WriteParamField(ref _SpQualifiedPassEventFlag, value);
        }
        private int _SpQualifiedPassEventFlag;

        [ParamField(0xC, ParamType.U16)]
        public ushort ValidDist
        {
            get => _ValidDist;
            set => WriteParamField(ref _ValidDist, value);
        }
        private ushort _ValidDist;

        [ParamField(0xE, ParamType.U16)]
        public ushort PlayerAnimId
        {
            get => _PlayerAnimId;
            set => WriteParamField(ref _PlayerAnimId, value);
        }
        private ushort _PlayerAnimId;

        [ParamField(0x10, ParamType.U16)]
        public ushort ChrAnimId
        {
            get => _ChrAnimId;
            set => WriteParamField(ref _ChrAnimId, value);
        }
        private ushort _ChrAnimId;

        [ParamField(0x12, ParamType.U16)]
        public ushort SpQualifiedId
        {
            get => _SpQualifiedId;
            set => WriteParamField(ref _SpQualifiedId, value);
        }
        private ushort _SpQualifiedId;

        [ParamField(0x14, ParamType.U16)]
        public ushort SpQualifiedId2
        {
            get => _SpQualifiedId2;
            set => WriteParamField(ref _SpQualifiedId2, value);
        }
        private ushort _SpQualifiedId2;

        [ParamField(0x16, ParamType.U8)]
        public byte ObjDummyId
        {
            get => _ObjDummyId;
            set => WriteParamField(ref _ObjDummyId, value);
        }
        private byte _ObjDummyId;

        [ParamField(0x17, ParamType.U8)]
        public byte ObjAnimId
        {
            get => _ObjAnimId;
            set => WriteParamField(ref _ObjAnimId, value);
        }
        private byte _ObjAnimId;

        [ParamField(0x18, ParamType.U8)]
        public byte ValidPlayerAngle
        {
            get => _ValidPlayerAngle;
            set => WriteParamField(ref _ValidPlayerAngle, value);
        }
        private byte _ValidPlayerAngle;

        [ParamField(0x19, ParamType.U8)]
        public byte SpQualifiedType
        {
            get => _SpQualifiedType;
            set => WriteParamField(ref _SpQualifiedType, value);
        }
        private byte _SpQualifiedType;

        [ParamField(0x1A, ParamType.U8)]
        public byte SpQualifiedType2
        {
            get => _SpQualifiedType2;
            set => WriteParamField(ref _SpQualifiedType2, value);
        }
        private byte _SpQualifiedType2;

        [ParamField(0x1B, ParamType.U8)]
        public byte ValidObjAngle
        {
            get => _ValidObjAngle;
            set => WriteParamField(ref _ValidObjAngle, value);
        }
        private byte _ValidObjAngle;

        [ParamField(0x1C, ParamType.U8)]
        public byte ChrSorbType
        {
            get => _ChrSorbType;
            set => WriteParamField(ref _ChrSorbType, value);
        }
        private byte _ChrSorbType;

        [ParamField(0x1D, ParamType.U8)]
        public byte EventKickTiming
        {
            get => _EventKickTiming;
            set => WriteParamField(ref _EventKickTiming, value);
        }
        private byte _EventKickTiming;

        [ParamField(0x1E, ParamType.Dummy8, 2)]
        public byte[] Pad1
        {
            get => _Pad1;
            set => WriteParamField(ref _Pad1, value);
        }
        private byte[] _Pad1;

    }
}
