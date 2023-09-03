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
    public class NpcThinkParam : BaseParam
    {
        public NpcThinkParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int LogicId
        {
            get => _LogicId;
            set => WriteParamField(ref _LogicId, value);
        }
        private int _LogicId;

        [ParamField(0x4, ParamType.I32)]
        public int BattleGoalID
        {
            get => _BattleGoalID;
            set => WriteParamField(ref _BattleGoalID, value);
        }
        private int _BattleGoalID;

        [ParamField(0x8, ParamType.F32)]
        public float NearDist
        {
            get => _NearDist;
            set => WriteParamField(ref _NearDist, value);
        }
        private float _NearDist;

        [ParamField(0xC, ParamType.F32)]
        public float MidDist
        {
            get => _MidDist;
            set => WriteParamField(ref _MidDist, value);
        }
        private float _MidDist;

        [ParamField(0x10, ParamType.F32)]
        public float FarDist
        {
            get => _FarDist;
            set => WriteParamField(ref _FarDist, value);
        }
        private float _FarDist;

        [ParamField(0x14, ParamType.F32)]
        public float OutDist
        {
            get => _OutDist;
            set => WriteParamField(ref _OutDist, value);
        }
        private float _OutDist;

        [ParamField(0x18, ParamType.F32)]
        public float BackHomeLife_OnHitEneWal
        {
            get => _BackHomeLife_OnHitEneWal;
            set => WriteParamField(ref _BackHomeLife_OnHitEneWal, value);
        }
        private float _BackHomeLife_OnHitEneWal;

        [ParamField(0x1C, ParamType.I32)]
        public int GoalID_ToCaution
        {
            get => _GoalID_ToCaution;
            set => WriteParamField(ref _GoalID_ToCaution, value);
        }
        private int _GoalID_ToCaution;

        [ParamField(0x20, ParamType.I32)]
        public int IdAttackCannotMove
        {
            get => _IdAttackCannotMove;
            set => WriteParamField(ref _IdAttackCannotMove, value);
        }
        private int _IdAttackCannotMove;

        [ParamField(0x24, ParamType.I32)]
        public int GoalID_ToFind
        {
            get => _GoalID_ToFind;
            set => WriteParamField(ref _GoalID_ToFind, value);
        }
        private int _GoalID_ToFind;

        [ParamField(0x28, ParamType.I32)]
        public int CallHelp_ActionAnimId
        {
            get => _CallHelp_ActionAnimId;
            set => WriteParamField(ref _CallHelp_ActionAnimId, value);
        }
        private int _CallHelp_ActionAnimId;

        [ParamField(0x2C, ParamType.I32)]
        public int CallHelp_CallActionId
        {
            get => _CallHelp_CallActionId;
            set => WriteParamField(ref _CallHelp_CallActionId, value);
        }
        private int _CallHelp_CallActionId;

        [ParamField(0x30, ParamType.U16)]
        public ushort Eye_dist
        {
            get => _Eye_dist;
            set => WriteParamField(ref _Eye_dist, value);
        }
        private ushort _Eye_dist;

        [ParamField(0x32, ParamType.U16)]
        public ushort Ear_dist
        {
            get => _Ear_dist;
            set => WriteParamField(ref _Ear_dist, value);
        }
        private ushort _Ear_dist;

        [ParamField(0x34, ParamType.U16)]
        public ushort Ear_soundcut_dist
        {
            get => _Ear_soundcut_dist;
            set => WriteParamField(ref _Ear_soundcut_dist, value);
        }
        private ushort _Ear_soundcut_dist;

        [ParamField(0x36, ParamType.U16)]
        public ushort Nose_dist
        {
            get => _Nose_dist;
            set => WriteParamField(ref _Nose_dist, value);
        }
        private ushort _Nose_dist;

        [ParamField(0x38, ParamType.U16)]
        public ushort MaxBackhomeDist
        {
            get => _MaxBackhomeDist;
            set => WriteParamField(ref _MaxBackhomeDist, value);
        }
        private ushort _MaxBackhomeDist;

        [ParamField(0x3A, ParamType.U16)]
        public ushort BackhomeDist
        {
            get => _BackhomeDist;
            set => WriteParamField(ref _BackhomeDist, value);
        }
        private ushort _BackhomeDist;

        [ParamField(0x3C, ParamType.U16)]
        public ushort BackhomeBattleDist
        {
            get => _BackhomeBattleDist;
            set => WriteParamField(ref _BackhomeBattleDist, value);
        }
        private ushort _BackhomeBattleDist;

        [ParamField(0x3E, ParamType.U16)]
        public ushort NonBattleActLife
        {
            get => _NonBattleActLife;
            set => WriteParamField(ref _NonBattleActLife, value);
        }
        private ushort _NonBattleActLife;

        [ParamField(0x40, ParamType.U16)]
        public ushort BackHome_LookTargetTime
        {
            get => _BackHome_LookTargetTime;
            set => WriteParamField(ref _BackHome_LookTargetTime, value);
        }
        private ushort _BackHome_LookTargetTime;

        [ParamField(0x42, ParamType.U16)]
        public ushort BackHome_LookTargetDist
        {
            get => _BackHome_LookTargetDist;
            set => WriteParamField(ref _BackHome_LookTargetDist, value);
        }
        private ushort _BackHome_LookTargetDist;

        [ParamField(0x44, ParamType.U16)]
        public ushort SightTargetForgetTime
        {
            get => _SightTargetForgetTime;
            set => WriteParamField(ref _SightTargetForgetTime, value);
        }
        private ushort _SightTargetForgetTime;

        [ParamField(0x46, ParamType.U16)]
        public ushort SoundTargetForgetTime
        {
            get => _SoundTargetForgetTime;
            set => WriteParamField(ref _SoundTargetForgetTime, value);
        }
        private ushort _SoundTargetForgetTime;

        [ParamField(0x48, ParamType.U16)]
        public ushort BattleStartDist
        {
            get => _BattleStartDist;
            set => WriteParamField(ref _BattleStartDist, value);
        }
        private ushort _BattleStartDist;

        [ParamField(0x4A, ParamType.U16)]
        public ushort CallHelp_MyPeerId
        {
            get => _CallHelp_MyPeerId;
            set => WriteParamField(ref _CallHelp_MyPeerId, value);
        }
        private ushort _CallHelp_MyPeerId;

        [ParamField(0x4C, ParamType.U16)]
        public ushort CallHelp_CallPeerId
        {
            get => _CallHelp_CallPeerId;
            set => WriteParamField(ref _CallHelp_CallPeerId, value);
        }
        private ushort _CallHelp_CallPeerId;

        [ParamField(0x4E, ParamType.U16)]
        public ushort TargetSys_DmgEffectRate
        {
            get => _TargetSys_DmgEffectRate;
            set => WriteParamField(ref _TargetSys_DmgEffectRate, value);
        }
        private ushort _TargetSys_DmgEffectRate;

        [ParamField(0x50, ParamType.U8)]
        public byte TeamAttackEffectivity
        {
            get => _TeamAttackEffectivity;
            set => WriteParamField(ref _TeamAttackEffectivity, value);
        }
        private byte _TeamAttackEffectivity;

        [ParamField(0x51, ParamType.U8)]
        public byte Eye_angX
        {
            get => _Eye_angX;
            set => WriteParamField(ref _Eye_angX, value);
        }
        private byte _Eye_angX;

        [ParamField(0x52, ParamType.U8)]
        public byte Eye_angY
        {
            get => _Eye_angY;
            set => WriteParamField(ref _Eye_angY, value);
        }
        private byte _Eye_angY;

        [ParamField(0x53, ParamType.U8)]
        public byte Ear_angX
        {
            get => _Ear_angX;
            set => WriteParamField(ref _Ear_angX, value);
        }
        private byte _Ear_angX;

        [ParamField(0x54, ParamType.U8)]
        public byte Ear_angY
        {
            get => _Ear_angY;
            set => WriteParamField(ref _Ear_angY, value);
        }
        private byte _Ear_angY;

        [ParamField(0x55, ParamType.U8)]
        public byte CallHelp_CallValidMinDistTarget
        {
            get => _CallHelp_CallValidMinDistTarget;
            set => WriteParamField(ref _CallHelp_CallValidMinDistTarget, value);
        }
        private byte _CallHelp_CallValidMinDistTarget;

        [ParamField(0x56, ParamType.U8)]
        public byte CallHelp_CallValidRange
        {
            get => _CallHelp_CallValidRange;
            set => WriteParamField(ref _CallHelp_CallValidRange, value);
        }
        private byte _CallHelp_CallValidRange;

        [ParamField(0x57, ParamType.U8)]
        public byte CallHelp_ForgetTimeByArrival
        {
            get => _CallHelp_ForgetTimeByArrival;
            set => WriteParamField(ref _CallHelp_ForgetTimeByArrival, value);
        }
        private byte _CallHelp_ForgetTimeByArrival;

        [ParamField(0x58, ParamType.U8)]
        public byte CallHelp_MinWaitTime
        {
            get => _CallHelp_MinWaitTime;
            set => WriteParamField(ref _CallHelp_MinWaitTime, value);
        }
        private byte _CallHelp_MinWaitTime;

        [ParamField(0x59, ParamType.U8)]
        public byte CallHelp_MaxWaitTime
        {
            get => _CallHelp_MaxWaitTime;
            set => WriteParamField(ref _CallHelp_MaxWaitTime, value);
        }
        private byte _CallHelp_MaxWaitTime;

        [ParamField(0x5A, ParamType.U8)]
        public byte GoalAction_ToCaution
        {
            get => _GoalAction_ToCaution;
            set => WriteParamField(ref _GoalAction_ToCaution, value);
        }
        private byte _GoalAction_ToCaution;

        [ParamField(0x5B, ParamType.U8)]
        public byte GoalAction_ToFind
        {
            get => _GoalAction_ToFind;
            set => WriteParamField(ref _GoalAction_ToFind, value);
        }
        private byte _GoalAction_ToFind;

        [ParamField(0x5C, ParamType.U8)]
        public byte CallHelp_ReplyBehaviorType
        {
            get => _CallHelp_ReplyBehaviorType;
            set => WriteParamField(ref _CallHelp_ReplyBehaviorType, value);
        }
        private byte _CallHelp_ReplyBehaviorType;

        [ParamField(0x5D, ParamType.U8)]
        public byte DisablePathMove
        {
            get => _DisablePathMove;
            set => WriteParamField(ref _DisablePathMove, value);
        }
        private byte _DisablePathMove;

        [ParamField(0x5E, ParamType.U8)]
        public byte SkipArrivalVisibleCheck
        {
            get => _SkipArrivalVisibleCheck;
            set => WriteParamField(ref _SkipArrivalVisibleCheck, value);
        }
        private byte _SkipArrivalVisibleCheck;

        [ParamField(0x5F, ParamType.U8)]
        public byte ThinkAttr_doAdmirer
        {
            get => _ThinkAttr_doAdmirer;
            set => WriteParamField(ref _ThinkAttr_doAdmirer, value);
        }
        private byte _ThinkAttr_doAdmirer;

        #region BitField EnableNaviFlg_EdgeBitfield ==============================================================================

        [ParamField(0x60, ParamType.U8)]
        public byte EnableNaviFlg_EdgeBitfield
        {
            get => _EnableNaviFlg_EdgeBitfield;
            set => WriteParamField(ref _EnableNaviFlg_EdgeBitfield, value);
        }
        private byte _EnableNaviFlg_EdgeBitfield;

        [ParamBitField(nameof(EnableNaviFlg_EdgeBitfield), bits: 1, bitsOffset: 0)]
        public byte EnableNaviFlg_Edge
        {
            get => GetbitfieldValue(_EnableNaviFlg_EdgeBitfield);
            set => SetBitfieldValue(ref _EnableNaviFlg_EdgeBitfield, value);
        }

        [ParamBitField(nameof(EnableNaviFlg_EdgeBitfield), bits: 1, bitsOffset: 1)]
        public byte EnableNaviFlg_LargeSpace
        {
            get => GetbitfieldValue(_EnableNaviFlg_EdgeBitfield);
            set => SetBitfieldValue(ref _EnableNaviFlg_EdgeBitfield, value);
        }

        [ParamBitField(nameof(EnableNaviFlg_EdgeBitfield), bits: 1, bitsOffset: 2)]
        public byte EnableNaviFlg_Ladder
        {
            get => GetbitfieldValue(_EnableNaviFlg_EdgeBitfield);
            set => SetBitfieldValue(ref _EnableNaviFlg_EdgeBitfield, value);
        }

        [ParamBitField(nameof(EnableNaviFlg_EdgeBitfield), bits: 1, bitsOffset: 3)]
        public byte EnableNaviFlg_Hole
        {
            get => GetbitfieldValue(_EnableNaviFlg_EdgeBitfield);
            set => SetBitfieldValue(ref _EnableNaviFlg_EdgeBitfield, value);
        }

        [ParamBitField(nameof(EnableNaviFlg_EdgeBitfield), bits: 1, bitsOffset: 4)]
        public byte EnableNaviFlg_Door
        {
            get => GetbitfieldValue(_EnableNaviFlg_EdgeBitfield);
            set => SetBitfieldValue(ref _EnableNaviFlg_EdgeBitfield, value);
        }

        [ParamBitField(nameof(EnableNaviFlg_EdgeBitfield), bits: 1, bitsOffset: 5)]
        public byte EnableNaviFlg_InSideWall
        {
            get => GetbitfieldValue(_EnableNaviFlg_EdgeBitfield);
            set => SetBitfieldValue(ref _EnableNaviFlg_EdgeBitfield, value);
        }

        [ParamBitField(nameof(EnableNaviFlg_EdgeBitfield), bits: 2, bitsOffset: 6)]
        public byte EnableNaviFlg_reserve0
        {
            get => GetbitfieldValue(_EnableNaviFlg_EdgeBitfield);
            set => SetBitfieldValue(ref _EnableNaviFlg_EdgeBitfield, value);
        }

        #endregion BitField EnableNaviFlg_EdgeBitfield

        [ParamField(0x61, ParamType.Dummy8, 3)]
        public byte[] EnableNaviFlg_reserve1
        {
            get => _EnableNaviFlg_reserve1;
            set => WriteParamField(ref _EnableNaviFlg_reserve1, value);
        }
        private byte[] _EnableNaviFlg_reserve1;

        [ParamField(0x64, ParamType.Dummy8, 12)]
        public byte[] Pad0
        {
            get => _Pad0;
            set => WriteParamField(ref _Pad0, value);
        }
        private byte[] _Pad0;

    }
}
