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

namespace SoulMemory.DarkSouls1.Parameters;

[ExcludeFromCodeCoverage]
public class NpcThinkParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int LogicId
    {
        get => _logicId;
        set => WriteParamField(ref _logicId, value);
    }
    private int _logicId;

    [ParamField(0x4, ParamType.I32)]
    public int BattleGoalId
    {
        get => _battleGoalId;
        set => WriteParamField(ref _battleGoalId, value);
    }
    private int _battleGoalId;

    [ParamField(0x8, ParamType.F32)]
    public float NearDist
    {
        get => _nearDist;
        set => WriteParamField(ref _nearDist, value);
    }
    private float _nearDist;

    [ParamField(0xC, ParamType.F32)]
    public float MidDist
    {
        get => _midDist;
        set => WriteParamField(ref _midDist, value);
    }
    private float _midDist;

    [ParamField(0x10, ParamType.F32)]
    public float FarDist
    {
        get => _farDist;
        set => WriteParamField(ref _farDist, value);
    }
    private float _farDist;

    [ParamField(0x14, ParamType.F32)]
    public float OutDist
    {
        get => _outDist;
        set => WriteParamField(ref _outDist, value);
    }
    private float _outDist;

    [ParamField(0x18, ParamType.F32)]
    public float BackHomeLifeOnHitEneWal
    {
        get => _backHomeLifeOnHitEneWal;
        set => WriteParamField(ref _backHomeLifeOnHitEneWal, value);
    }
    private float _backHomeLifeOnHitEneWal;

    [ParamField(0x1C, ParamType.I32)]
    public int GoalIdToCaution
    {
        get => _goalIdToCaution;
        set => WriteParamField(ref _goalIdToCaution, value);
    }
    private int _goalIdToCaution;

    [ParamField(0x20, ParamType.I32)]
    public int IdAttackCannotMove
    {
        get => _idAttackCannotMove;
        set => WriteParamField(ref _idAttackCannotMove, value);
    }
    private int _idAttackCannotMove;

    [ParamField(0x24, ParamType.I32)]
    public int GoalIdToFind
    {
        get => _goalIdToFind;
        set => WriteParamField(ref _goalIdToFind, value);
    }
    private int _goalIdToFind;

    [ParamField(0x28, ParamType.I32)]
    public int CallHelpActionAnimId
    {
        get => _callHelpActionAnimId;
        set => WriteParamField(ref _callHelpActionAnimId, value);
    }
    private int _callHelpActionAnimId;

    [ParamField(0x2C, ParamType.I32)]
    public int CallHelpCallActionId
    {
        get => _callHelpCallActionId;
        set => WriteParamField(ref _callHelpCallActionId, value);
    }
    private int _callHelpCallActionId;

    [ParamField(0x30, ParamType.U16)]
    public ushort EyeDist
    {
        get => _eyeDist;
        set => WriteParamField(ref _eyeDist, value);
    }
    private ushort _eyeDist;

    [ParamField(0x32, ParamType.U16)]
    public ushort EarDist
    {
        get => _earDist;
        set => WriteParamField(ref _earDist, value);
    }
    private ushort _earDist;

    [ParamField(0x34, ParamType.U16)]
    public ushort EarSoundcutDist
    {
        get => _earSoundcutDist;
        set => WriteParamField(ref _earSoundcutDist, value);
    }
    private ushort _earSoundcutDist;

    [ParamField(0x36, ParamType.U16)]
    public ushort NoseDist
    {
        get => _noseDist;
        set => WriteParamField(ref _noseDist, value);
    }
    private ushort _noseDist;

    [ParamField(0x38, ParamType.U16)]
    public ushort MaxBackhomeDist
    {
        get => _maxBackhomeDist;
        set => WriteParamField(ref _maxBackhomeDist, value);
    }
    private ushort _maxBackhomeDist;

    [ParamField(0x3A, ParamType.U16)]
    public ushort BackhomeDist
    {
        get => _backhomeDist;
        set => WriteParamField(ref _backhomeDist, value);
    }
    private ushort _backhomeDist;

    [ParamField(0x3C, ParamType.U16)]
    public ushort BackhomeBattleDist
    {
        get => _backhomeBattleDist;
        set => WriteParamField(ref _backhomeBattleDist, value);
    }
    private ushort _backhomeBattleDist;

    [ParamField(0x3E, ParamType.U16)]
    public ushort NonBattleActLife
    {
        get => _nonBattleActLife;
        set => WriteParamField(ref _nonBattleActLife, value);
    }
    private ushort _nonBattleActLife;

    [ParamField(0x40, ParamType.U16)]
    public ushort BackHomeLookTargetTime
    {
        get => _backHomeLookTargetTime;
        set => WriteParamField(ref _backHomeLookTargetTime, value);
    }
    private ushort _backHomeLookTargetTime;

    [ParamField(0x42, ParamType.U16)]
    public ushort BackHomeLookTargetDist
    {
        get => _backHomeLookTargetDist;
        set => WriteParamField(ref _backHomeLookTargetDist, value);
    }
    private ushort _backHomeLookTargetDist;

    [ParamField(0x44, ParamType.U16)]
    public ushort SightTargetForgetTime
    {
        get => _sightTargetForgetTime;
        set => WriteParamField(ref _sightTargetForgetTime, value);
    }
    private ushort _sightTargetForgetTime;

    [ParamField(0x46, ParamType.U16)]
    public ushort SoundTargetForgetTime
    {
        get => _soundTargetForgetTime;
        set => WriteParamField(ref _soundTargetForgetTime, value);
    }
    private ushort _soundTargetForgetTime;

    [ParamField(0x48, ParamType.U16)]
    public ushort BattleStartDist
    {
        get => _battleStartDist;
        set => WriteParamField(ref _battleStartDist, value);
    }
    private ushort _battleStartDist;

    [ParamField(0x4A, ParamType.U16)]
    public ushort CallHelpMyPeerId
    {
        get => _callHelpMyPeerId;
        set => WriteParamField(ref _callHelpMyPeerId, value);
    }
    private ushort _callHelpMyPeerId;

    [ParamField(0x4C, ParamType.U16)]
    public ushort CallHelpCallPeerId
    {
        get => _callHelpCallPeerId;
        set => WriteParamField(ref _callHelpCallPeerId, value);
    }
    private ushort _callHelpCallPeerId;

    [ParamField(0x4E, ParamType.U16)]
    public ushort TargetSysDmgEffectRate
    {
        get => _targetSysDmgEffectRate;
        set => WriteParamField(ref _targetSysDmgEffectRate, value);
    }
    private ushort _targetSysDmgEffectRate;

    [ParamField(0x50, ParamType.U8)]
    public byte TeamAttackEffectivity
    {
        get => _teamAttackEffectivity;
        set => WriteParamField(ref _teamAttackEffectivity, value);
    }
    private byte _teamAttackEffectivity;

    [ParamField(0x51, ParamType.U8)]
    public byte EyeAngX
    {
        get => _eyeAngX;
        set => WriteParamField(ref _eyeAngX, value);
    }
    private byte _eyeAngX;

    [ParamField(0x52, ParamType.U8)]
    public byte EyeAngY
    {
        get => _eyeAngY;
        set => WriteParamField(ref _eyeAngY, value);
    }
    private byte _eyeAngY;

    [ParamField(0x53, ParamType.U8)]
    public byte EarAngX
    {
        get => _earAngX;
        set => WriteParamField(ref _earAngX, value);
    }
    private byte _earAngX;

    [ParamField(0x54, ParamType.U8)]
    public byte EarAngY
    {
        get => _earAngY;
        set => WriteParamField(ref _earAngY, value);
    }
    private byte _earAngY;

    [ParamField(0x55, ParamType.U8)]
    public byte CallHelpCallValidMinDistTarget
    {
        get => _callHelpCallValidMinDistTarget;
        set => WriteParamField(ref _callHelpCallValidMinDistTarget, value);
    }
    private byte _callHelpCallValidMinDistTarget;

    [ParamField(0x56, ParamType.U8)]
    public byte CallHelpCallValidRange
    {
        get => _callHelpCallValidRange;
        set => WriteParamField(ref _callHelpCallValidRange, value);
    }
    private byte _callHelpCallValidRange;

    [ParamField(0x57, ParamType.U8)]
    public byte CallHelpForgetTimeByArrival
    {
        get => _callHelpForgetTimeByArrival;
        set => WriteParamField(ref _callHelpForgetTimeByArrival, value);
    }
    private byte _callHelpForgetTimeByArrival;

    [ParamField(0x58, ParamType.U8)]
    public byte CallHelpMinWaitTime
    {
        get => _callHelpMinWaitTime;
        set => WriteParamField(ref _callHelpMinWaitTime, value);
    }
    private byte _callHelpMinWaitTime;

    [ParamField(0x59, ParamType.U8)]
    public byte CallHelpMaxWaitTime
    {
        get => _callHelpMaxWaitTime;
        set => WriteParamField(ref _callHelpMaxWaitTime, value);
    }
    private byte _callHelpMaxWaitTime;

    [ParamField(0x5A, ParamType.U8)]
    public byte GoalActionToCaution
    {
        get => _goalActionToCaution;
        set => WriteParamField(ref _goalActionToCaution, value);
    }
    private byte _goalActionToCaution;

    [ParamField(0x5B, ParamType.U8)]
    public byte GoalActionToFind
    {
        get => _goalActionToFind;
        set => WriteParamField(ref _goalActionToFind, value);
    }
    private byte _goalActionToFind;

    [ParamField(0x5C, ParamType.U8)]
    public byte CallHelpReplyBehaviorType
    {
        get => _callHelpReplyBehaviorType;
        set => WriteParamField(ref _callHelpReplyBehaviorType, value);
    }
    private byte _callHelpReplyBehaviorType;

    [ParamField(0x5D, ParamType.U8)]
    public byte DisablePathMove
    {
        get => _disablePathMove;
        set => WriteParamField(ref _disablePathMove, value);
    }
    private byte _disablePathMove;

    [ParamField(0x5E, ParamType.U8)]
    public byte SkipArrivalVisibleCheck
    {
        get => _skipArrivalVisibleCheck;
        set => WriteParamField(ref _skipArrivalVisibleCheck, value);
    }
    private byte _skipArrivalVisibleCheck;

    [ParamField(0x5F, ParamType.U8)]
    public byte ThinkAttrDoAdmirer
    {
        get => _thinkAttrDoAdmirer;
        set => WriteParamField(ref _thinkAttrDoAdmirer, value);
    }
    private byte _thinkAttrDoAdmirer;

    #region BitField EnableNaviFlg_EdgeBitfield ==============================================================================

    [ParamField(0x60, ParamType.U8)]
    public byte EnableNaviFlgEdgeBitfield
    {
        get => _enableNaviFlgEdgeBitfield;
        set => WriteParamField(ref _enableNaviFlgEdgeBitfield, value);
    }
    private byte _enableNaviFlgEdgeBitfield;

    [ParamBitField(nameof(EnableNaviFlgEdgeBitfield), bits: 1, bitsOffset: 0)]
    public byte EnableNaviFlgEdge
    {
        get => GetbitfieldValue(_enableNaviFlgEdgeBitfield);
        set => SetBitfieldValue(ref _enableNaviFlgEdgeBitfield, value);
    }

    [ParamBitField(nameof(EnableNaviFlgEdgeBitfield), bits: 1, bitsOffset: 1)]
    public byte EnableNaviFlgLargeSpace
    {
        get => GetbitfieldValue(_enableNaviFlgEdgeBitfield);
        set => SetBitfieldValue(ref _enableNaviFlgEdgeBitfield, value);
    }

    [ParamBitField(nameof(EnableNaviFlgEdgeBitfield), bits: 1, bitsOffset: 2)]
    public byte EnableNaviFlgLadder
    {
        get => GetbitfieldValue(_enableNaviFlgEdgeBitfield);
        set => SetBitfieldValue(ref _enableNaviFlgEdgeBitfield, value);
    }

    [ParamBitField(nameof(EnableNaviFlgEdgeBitfield), bits: 1, bitsOffset: 3)]
    public byte EnableNaviFlgHole
    {
        get => GetbitfieldValue(_enableNaviFlgEdgeBitfield);
        set => SetBitfieldValue(ref _enableNaviFlgEdgeBitfield, value);
    }

    [ParamBitField(nameof(EnableNaviFlgEdgeBitfield), bits: 1, bitsOffset: 4)]
    public byte EnableNaviFlgDoor
    {
        get => GetbitfieldValue(_enableNaviFlgEdgeBitfield);
        set => SetBitfieldValue(ref _enableNaviFlgEdgeBitfield, value);
    }

    [ParamBitField(nameof(EnableNaviFlgEdgeBitfield), bits: 1, bitsOffset: 5)]
    public byte EnableNaviFlgInSideWall
    {
        get => GetbitfieldValue(_enableNaviFlgEdgeBitfield);
        set => SetBitfieldValue(ref _enableNaviFlgEdgeBitfield, value);
    }

    [ParamBitField(nameof(EnableNaviFlgEdgeBitfield), bits: 2, bitsOffset: 6)]
    public byte EnableNaviFlgReserve0
    {
        get => GetbitfieldValue(_enableNaviFlgEdgeBitfield);
        set => SetBitfieldValue(ref _enableNaviFlgEdgeBitfield, value);
    }

    #endregion BitField EnableNaviFlg_EdgeBitfield

    [ParamField(0x61, ParamType.Dummy8, 3)]
    public byte[] EnableNaviFlgReserve1
    {
        get => _enableNaviFlgReserve1;
        set => WriteParamField(ref _enableNaviFlgReserve1, value);
    }
    private byte[] _enableNaviFlgReserve1 = null!;

    [ParamField(0x64, ParamType.Dummy8, 12)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

}
