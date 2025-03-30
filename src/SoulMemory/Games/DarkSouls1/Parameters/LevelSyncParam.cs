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

namespace SoulMemory.Games.DarkSouls1.Parameters;

[ExcludeFromCodeCoverage]
public class LevelSyncParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I16)]
    public short Sclua
    {
        get => _sclua;
        set => WriteParamField(ref _sclua, value);
    }
    private short _sclua;

    [ParamField(0x2, ParamType.I16)]
    public short Sdclur
    {
        get => _sdclur;
        set => WriteParamField(ref _sdclur, value);
    }
    private short _sdclur;

    [ParamField(0x4, ParamType.I16)]
    public short Sdcwlm
    {
        get => _sdcwlm;
        set => WriteParamField(ref _sdcwlm, value);
    }
    private short _sdcwlm;

    [ParamField(0x6, ParamType.U8)]
    public byte Mlwsur
    {
        get => _mlwsur;
        set => WriteParamField(ref _mlwsur, value);
    }
    private byte _mlwsur;

    [ParamField(0x7, ParamType.U8)]
    public byte Mlwsua
    {
        get => _mlwsua;
        set => WriteParamField(ref _mlwsua, value);
    }
    private byte _mlwsua;

    [ParamField(0x8, ParamType.U8)]
    public byte Mlrsur
    {
        get => _mlrsur;
        set => WriteParamField(ref _mlrsur, value);
    }
    private byte _mlrsur;

    [ParamField(0x9, ParamType.U8)]
    public byte Mlrsua
    {
        get => _mlrsua;
        set => WriteParamField(ref _mlrsua, value);
    }
    private byte _mlrsua;

    [ParamField(0xA, ParamType.U8)]
    public byte Mwluws0
    {
        get => _mwluws0;
        set => WriteParamField(ref _mwluws0, value);
    }
    private byte _mwluws0;

    [ParamField(0xB, ParamType.U8)]
    public byte Mwluws1
    {
        get => _mwluws1;
        set => WriteParamField(ref _mwluws1, value);
    }
    private byte _mwluws1;

    [ParamField(0xC, ParamType.U8)]
    public byte Mwluws2
    {
        get => _mwluws2;
        set => WriteParamField(ref _mwluws2, value);
    }
    private byte _mwluws2;

    [ParamField(0xD, ParamType.U8)]
    public byte Mwluws3
    {
        get => _mwluws3;
        set => WriteParamField(ref _mwluws3, value);
    }
    private byte _mwluws3;

    [ParamField(0xE, ParamType.U8)]
    public byte Mwluws4
    {
        get => _mwluws4;
        set => WriteParamField(ref _mwluws4, value);
    }
    private byte _mwluws4;

    [ParamField(0xF, ParamType.U8)]
    public byte Mwluws5
    {
        get => _mwluws5;
        set => WriteParamField(ref _mwluws5, value);
    }
    private byte _mwluws5;

    [ParamField(0x10, ParamType.U8)]
    public byte Mwluws6
    {
        get => _mwluws6;
        set => WriteParamField(ref _mwluws6, value);
    }
    private byte _mwluws6;

    [ParamField(0x11, ParamType.U8)]
    public byte Mwluws7
    {
        get => _mwluws7;
        set => WriteParamField(ref _mwluws7, value);
    }
    private byte _mwluws7;

    [ParamField(0x12, ParamType.U8)]
    public byte Mwluws8
    {
        get => _mwluws8;
        set => WriteParamField(ref _mwluws8, value);
    }
    private byte _mwluws8;

    [ParamField(0x13, ParamType.U8)]
    public byte Mwluws9
    {
        get => _mwluws9;
        set => WriteParamField(ref _mwluws9, value);
    }
    private byte _mwluws9;

    [ParamField(0x14, ParamType.U8)]
    public byte Mwluws10
    {
        get => _mwluws10;
        set => WriteParamField(ref _mwluws10, value);
    }
    private byte _mwluws10;

    [ParamField(0x15, ParamType.U8)]
    public byte Mwlurs0
    {
        get => _mwlurs0;
        set => WriteParamField(ref _mwlurs0, value);
    }
    private byte _mwlurs0;

    [ParamField(0x16, ParamType.U8)]
    public byte Mwlurs1
    {
        get => _mwlurs1;
        set => WriteParamField(ref _mwlurs1, value);
    }
    private byte _mwlurs1;

    [ParamField(0x17, ParamType.U8)]
    public byte Mwlurs2
    {
        get => _mwlurs2;
        set => WriteParamField(ref _mwlurs2, value);
    }
    private byte _mwlurs2;

    [ParamField(0x18, ParamType.U8)]
    public byte Mwlurs3
    {
        get => _mwlurs3;
        set => WriteParamField(ref _mwlurs3, value);
    }
    private byte _mwlurs3;

    [ParamField(0x19, ParamType.U8)]
    public byte Mwlurs4
    {
        get => _mwlurs4;
        set => WriteParamField(ref _mwlurs4, value);
    }
    private byte _mwlurs4;

    [ParamField(0x1A, ParamType.U8)]
    public byte Mwlurs5
    {
        get => _mwlurs5;
        set => WriteParamField(ref _mwlurs5, value);
    }
    private byte _mwlurs5;

    [ParamField(0x1B, ParamType.U8)]
    public byte Mwlurs6
    {
        get => _mwlurs6;
        set => WriteParamField(ref _mwlurs6, value);
    }
    private byte _mwlurs6;

    [ParamField(0x1C, ParamType.U8)]
    public byte Mwlurs7
    {
        get => _mwlurs7;
        set => WriteParamField(ref _mwlurs7, value);
    }
    private byte _mwlurs7;

    [ParamField(0x1D, ParamType.U8)]
    public byte Mwlurs8
    {
        get => _mwlurs8;
        set => WriteParamField(ref _mwlurs8, value);
    }
    private byte _mwlurs8;

    [ParamField(0x1E, ParamType.U8)]
    public byte Mwlurs9
    {
        get => _mwlurs9;
        set => WriteParamField(ref _mwlurs9, value);
    }
    private byte _mwlurs9;

    [ParamField(0x1F, ParamType.U8)]
    public byte Mwlurs10
    {
        get => _mwlurs10;
        set => WriteParamField(ref _mwlurs10, value);
    }
    private byte _mwlurs10;

    [ParamField(0x20, ParamType.U8)]
    public byte Mwlua0
    {
        get => _mwlua0;
        set => WriteParamField(ref _mwlua0, value);
    }
    private byte _mwlua0;

    [ParamField(0x21, ParamType.U8)]
    public byte Mwlua1
    {
        get => _mwlua1;
        set => WriteParamField(ref _mwlua1, value);
    }
    private byte _mwlua1;

    [ParamField(0x22, ParamType.U8)]
    public byte Mwlua2
    {
        get => _mwlua2;
        set => WriteParamField(ref _mwlua2, value);
    }
    private byte _mwlua2;

    [ParamField(0x23, ParamType.U8)]
    public byte Mwlua3
    {
        get => _mwlua3;
        set => WriteParamField(ref _mwlua3, value);
    }
    private byte _mwlua3;

    [ParamField(0x24, ParamType.U8)]
    public byte Mwlua4
    {
        get => _mwlua4;
        set => WriteParamField(ref _mwlua4, value);
    }
    private byte _mwlua4;

    [ParamField(0x25, ParamType.U8)]
    public byte Mwlua5
    {
        get => _mwlua5;
        set => WriteParamField(ref _mwlua5, value);
    }
    private byte _mwlua5;

    [ParamField(0x26, ParamType.U8)]
    public byte Mwlua6
    {
        get => _mwlua6;
        set => WriteParamField(ref _mwlua6, value);
    }
    private byte _mwlua6;

    [ParamField(0x27, ParamType.U8)]
    public byte Mwlua7
    {
        get => _mwlua7;
        set => WriteParamField(ref _mwlua7, value);
    }
    private byte _mwlua7;

    [ParamField(0x28, ParamType.U8)]
    public byte Mwlua8
    {
        get => _mwlua8;
        set => WriteParamField(ref _mwlua8, value);
    }
    private byte _mwlua8;

    [ParamField(0x29, ParamType.U8)]
    public byte Mwlua9
    {
        get => _mwlua9;
        set => WriteParamField(ref _mwlua9, value);
    }
    private byte _mwlua9;

    [ParamField(0x2A, ParamType.U8)]
    public byte Mwlua10
    {
        get => _mwlua10;
        set => WriteParamField(ref _mwlua10, value);
    }
    private byte _mwlua10;

    [ParamField(0x2B, ParamType.U8)]
    public byte Mlasur
    {
        get => _mlasur;
        set => WriteParamField(ref _mlasur, value);
    }
    private byte _mlasur;

    [ParamField(0x2C, ParamType.U8)]
    public byte Mlasua
    {
        get => _mlasua;
        set => WriteParamField(ref _mlasua, value);
    }
    private byte _mlasua;

    [ParamField(0x2D, ParamType.Dummy8, 3)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

    [ParamField(0x30, ParamType.F32)]
    public float SummonTimeoutTime
    {
        get => _summonTimeoutTime;
        set => WriteParamField(ref _summonTimeoutTime, value);
    }
    private float _summonTimeoutTime;

    [ParamField(0x34, ParamType.U32)]
    public uint SingGetMax
    {
        get => _singGetMax;
        set => WriteParamField(ref _singGetMax, value);
    }
    private uint _singGetMax;

    [ParamField(0x38, ParamType.F32)]
    public float SignDownloadSpan
    {
        get => _signDownloadSpan;
        set => WriteParamField(ref _signDownloadSpan, value);
    }
    private float _signDownloadSpan;

    [ParamField(0x3C, ParamType.F32)]
    public float NitoSignDownloadSpan
    {
        get => _nitoSignDownloadSpan;
        set => WriteParamField(ref _nitoSignDownloadSpan, value);
    }
    private float _nitoSignDownloadSpan;

    [ParamField(0x40, ParamType.F32)]
    public float SignUpdateSpan
    {
        get => _signUpdateSpan;
        set => WriteParamField(ref _signUpdateSpan, value);
    }
    private float _signUpdateSpan;

    [ParamField(0x44, ParamType.U32)]
    public uint MaxBreakInTargetListCount
    {
        get => _maxBreakInTargetListCount;
        set => WriteParamField(ref _maxBreakInTargetListCount, value);
    }
    private uint _maxBreakInTargetListCount;

    [ParamField(0x48, ParamType.F32)]
    public float BreakInRequestIntervalTimeSec
    {
        get => _breakInRequestIntervalTimeSec;
        set => WriteParamField(ref _breakInRequestIntervalTimeSec, value);
    }
    private float _breakInRequestIntervalTimeSec;

    [ParamField(0x4C, ParamType.F32)]
    public float BreakInRequestTimeOutSec
    {
        get => _breakInRequestTimeOutSec;
        set => WriteParamField(ref _breakInRequestTimeOutSec, value);
    }
    private float _breakInRequestTimeOutSec;

    [ParamField(0x50, ParamType.U32)]
    public uint ReloadSignTotalCount0
    {
        get => _reloadSignTotalCount0;
        set => WriteParamField(ref _reloadSignTotalCount0, value);
    }
    private uint _reloadSignTotalCount0;

    [ParamField(0x54, ParamType.F32)]
    public float ReloadSignIntervalTime0
    {
        get => _reloadSignIntervalTime0;
        set => WriteParamField(ref _reloadSignIntervalTime0, value);
    }
    private float _reloadSignIntervalTime0;

    [ParamField(0x58, ParamType.F32)]
    public float ReloadSignIntervalTime1
    {
        get => _reloadSignIntervalTime1;
        set => WriteParamField(ref _reloadSignIntervalTime1, value);
    }
    private float _reloadSignIntervalTime1;

    [ParamField(0x5C, ParamType.U32)]
    public uint ReloadSignTotalCount1
    {
        get => _reloadSignTotalCount1;
        set => WriteParamField(ref _reloadSignTotalCount1, value);
    }
    private uint _reloadSignTotalCount1;

    [ParamField(0x60, ParamType.U32)]
    public uint ReloadSignCellCount
    {
        get => _reloadSignCellCount;
        set => WriteParamField(ref _reloadSignCellCount, value);
    }
    private uint _reloadSignCellCount;

    [ParamField(0x64, ParamType.F32)]
    public float ReloadSignIntervalTime2
    {
        get => _reloadSignIntervalTime2;
        set => WriteParamField(ref _reloadSignIntervalTime2, value);
    }
    private float _reloadSignIntervalTime2;

    [ParamField(0x68, ParamType.U32)]
    public uint ReloadGhostTotalCount
    {
        get => _reloadGhostTotalCount;
        set => WriteParamField(ref _reloadGhostTotalCount, value);
    }
    private uint _reloadGhostTotalCount;

    [ParamField(0x6C, ParamType.U32)]
    public uint ReloadGhostCellCount
    {
        get => _reloadGhostCellCount;
        set => WriteParamField(ref _reloadGhostCellCount, value);
    }
    private uint _reloadGhostCellCount;

    [ParamField(0x70, ParamType.U32)]
    public uint MaxGhostTotalCount
    {
        get => _maxGhostTotalCount;
        set => WriteParamField(ref _maxGhostTotalCount, value);
    }
    private uint _maxGhostTotalCount;

    [ParamField(0x74, ParamType.F32)]
    public float UpdateWanderGhostIntervalTime
    {
        get => _updateWanderGhostIntervalTime;
        set => WriteParamField(ref _updateWanderGhostIntervalTime, value);
    }
    private float _updateWanderGhostIntervalTime;

    [ParamField(0x78, ParamType.F32)]
    public float MinReplayIntervalTime
    {
        get => _minReplayIntervalTime;
        set => WriteParamField(ref _minReplayIntervalTime, value);
    }
    private float _minReplayIntervalTime;

    [ParamField(0x7C, ParamType.F32)]
    public float MaxReplayIntervalTime
    {
        get => _maxReplayIntervalTime;
        set => WriteParamField(ref _maxReplayIntervalTime, value);
    }
    private float _maxReplayIntervalTime;

    [ParamField(0x80, ParamType.F32)]
    public float ReloadGhostIntervalTime
    {
        get => _reloadGhostIntervalTime;
        set => WriteParamField(ref _reloadGhostIntervalTime, value);
    }
    private float _reloadGhostIntervalTime;

    [ParamField(0x84, ParamType.F32)]
    public float ReplayBonfireModeRange
    {
        get => _replayBonfireModeRange;
        set => WriteParamField(ref _replayBonfireModeRange, value);
    }
    private float _replayBonfireModeRange;

    [ParamField(0x88, ParamType.F32)]
    public float WanderGhostIntervalLifeTime
    {
        get => _wanderGhostIntervalLifeTime;
        set => WriteParamField(ref _wanderGhostIntervalLifeTime, value);
    }
    private float _wanderGhostIntervalLifeTime;

    [ParamField(0x8C, ParamType.F32)]
    public float SummonMessageInterval
    {
        get => _summonMessageInterval;
        set => WriteParamField(ref _summonMessageInterval, value);
    }
    private float _summonMessageInterval;

    [ParamField(0x90, ParamType.F32)]
    public float HostRegisterUpdateTime
    {
        get => _hostRegisterUpdateTime;
        set => WriteParamField(ref _hostRegisterUpdateTime, value);
    }
    private float _hostRegisterUpdateTime;

    [ParamField(0x94, ParamType.U32)]
    public uint RequestSearchQuickMatchLimit
    {
        get => _requestSearchQuickMatchLimit;
        set => WriteParamField(ref _requestSearchQuickMatchLimit, value);
    }
    private uint _requestSearchQuickMatchLimit;

    [ParamField(0x98, ParamType.F32)]
    public float MyTeamInviteTimeoutTime
    {
        get => _myTeamInviteTimeoutTime;
        set => WriteParamField(ref _myTeamInviteTimeoutTime, value);
    }
    private float _myTeamInviteTimeoutTime;

    [ParamField(0x9C, ParamType.U32)]
    public uint VisitorListMax
    {
        get => _visitorListMax;
        set => WriteParamField(ref _visitorListMax, value);
    }
    private uint _visitorListMax;

    [ParamField(0xA0, ParamType.F32)]
    public float VisitorTimeOutTime
    {
        get => _visitorTimeOutTime;
        set => WriteParamField(ref _visitorTimeOutTime, value);
    }
    private float _visitorTimeOutTime;

    [ParamField(0xA4, ParamType.F32)]
    public float DownloadSpan
    {
        get => _downloadSpan;
        set => WriteParamField(ref _downloadSpan, value);
    }
    private float _downloadSpan;

    [ParamField(0xA8, ParamType.F32)]
    public float BonfireLowerBoundCoolTime
    {
        get => _bonfireLowerBoundCoolTime;
        set => WriteParamField(ref _bonfireLowerBoundCoolTime, value);
    }
    private float _bonfireLowerBoundCoolTime;

    [ParamField(0xAC, ParamType.F32)]
    public float BonfireUpperBoundCoolTime
    {
        get => _bonfireUpperBoundCoolTime;
        set => WriteParamField(ref _bonfireUpperBoundCoolTime, value);
    }
    private float _bonfireUpperBoundCoolTime;

    [ParamField(0xB0, ParamType.F32)]
    public float ResonanceMagicDbDistInterval
    {
        get => _resonanceMagicDbDistInterval;
        set => WriteParamField(ref _resonanceMagicDbDistInterval, value);
    }
    private float _resonanceMagicDbDistInterval;

    [ParamField(0xB4, ParamType.F32)]
    public float InputTimeoutSec
    {
        get => _inputTimeoutSec;
        set => WriteParamField(ref _inputTimeoutSec, value);
    }
    private float _inputTimeoutSec;

    [ParamField(0xB8, ParamType.F32)]
    public float GeneralPurposeParam1
    {
        get => _generalPurposeParam1;
        set => WriteParamField(ref _generalPurposeParam1, value);
    }
    private float _generalPurposeParam1;

    [ParamField(0xBC, ParamType.F32)]
    public float GeneralPurposeParam2
    {
        get => _generalPurposeParam2;
        set => WriteParamField(ref _generalPurposeParam2, value);
    }
    private float _generalPurposeParam2;

    [ParamField(0xC0, ParamType.F32)]
    public float GeneralPurposeParam3
    {
        get => _generalPurposeParam3;
        set => WriteParamField(ref _generalPurposeParam3, value);
    }
    private float _generalPurposeParam3;

    [ParamField(0xC4, ParamType.F32)]
    public float GeneralPurposeParam4
    {
        get => _generalPurposeParam4;
        set => WriteParamField(ref _generalPurposeParam4, value);
    }
    private float _generalPurposeParam4;

    [ParamField(0xC8, ParamType.F32)]
    public float GeneralPurposeParam5
    {
        get => _generalPurposeParam5;
        set => WriteParamField(ref _generalPurposeParam5, value);
    }
    private float _generalPurposeParam5;

    [ParamField(0xCC, ParamType.U8)]
    public byte Mwluws11
    {
        get => _mwluws11;
        set => WriteParamField(ref _mwluws11, value);
    }
    private byte _mwluws11;

    [ParamField(0xCD, ParamType.U8)]
    public byte Mwluws12
    {
        get => _mwluws12;
        set => WriteParamField(ref _mwluws12, value);
    }
    private byte _mwluws12;

    [ParamField(0xCE, ParamType.U8)]
    public byte Mwluws13
    {
        get => _mwluws13;
        set => WriteParamField(ref _mwluws13, value);
    }
    private byte _mwluws13;

    [ParamField(0xCF, ParamType.U8)]
    public byte Mwluws14
    {
        get => _mwluws14;
        set => WriteParamField(ref _mwluws14, value);
    }
    private byte _mwluws14;

    [ParamField(0xD0, ParamType.U8)]
    public byte Mwluws15
    {
        get => _mwluws15;
        set => WriteParamField(ref _mwluws15, value);
    }
    private byte _mwluws15;

    [ParamField(0xD1, ParamType.U8)]
    public byte Mwlurs11
    {
        get => _mwlurs11;
        set => WriteParamField(ref _mwlurs11, value);
    }
    private byte _mwlurs11;

    [ParamField(0xD2, ParamType.U8)]
    public byte Mwlurs12
    {
        get => _mwlurs12;
        set => WriteParamField(ref _mwlurs12, value);
    }
    private byte _mwlurs12;

    [ParamField(0xD3, ParamType.U8)]
    public byte Mwlurs13
    {
        get => _mwlurs13;
        set => WriteParamField(ref _mwlurs13, value);
    }
    private byte _mwlurs13;

    [ParamField(0xD4, ParamType.U8)]
    public byte Mwlurs14
    {
        get => _mwlurs14;
        set => WriteParamField(ref _mwlurs14, value);
    }
    private byte _mwlurs14;

    [ParamField(0xD5, ParamType.U8)]
    public byte Mwlurs15
    {
        get => _mwlurs15;
        set => WriteParamField(ref _mwlurs15, value);
    }
    private byte _mwlurs15;

    [ParamField(0xD6, ParamType.U8)]
    public byte Mwluar11
    {
        get => _mwluar11;
        set => WriteParamField(ref _mwluar11, value);
    }
    private byte _mwluar11;

    [ParamField(0xD7, ParamType.U8)]
    public byte Mwluar12
    {
        get => _mwluar12;
        set => WriteParamField(ref _mwluar12, value);
    }
    private byte _mwluar12;

    [ParamField(0xD8, ParamType.U8)]
    public byte Mwluar13
    {
        get => _mwluar13;
        set => WriteParamField(ref _mwluar13, value);
    }
    private byte _mwluar13;

    [ParamField(0xD9, ParamType.U8)]
    public byte Mwluar14
    {
        get => _mwluar14;
        set => WriteParamField(ref _mwluar14, value);
    }
    private byte _mwluar14;

    [ParamField(0xDA, ParamType.U8)]
    public byte Mwluar15
    {
        get => _mwluar15;
        set => WriteParamField(ref _mwluar15, value);
    }
    private byte _mwluar15;

    [ParamField(0xDB, ParamType.U8)]
    public byte GeneralPurposeParam6
    {
        get => _generalPurposeParam6;
        set => WriteParamField(ref _generalPurposeParam6, value);
    }
    private byte _generalPurposeParam6;

}
