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
    public class LevelSyncParam : BaseParam
    {
        public LevelSyncParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I16)]
        public short SCLUA
        {
            get => _SCLUA;
            set => WriteParamField(ref _SCLUA, value);
        }
        private short _SCLUA;

        [ParamField(0x2, ParamType.I16)]
        public short SDCLUR
        {
            get => _SDCLUR;
            set => WriteParamField(ref _SDCLUR, value);
        }
        private short _SDCLUR;

        [ParamField(0x4, ParamType.I16)]
        public short SDCWLM
        {
            get => _SDCWLM;
            set => WriteParamField(ref _SDCWLM, value);
        }
        private short _SDCWLM;

        [ParamField(0x6, ParamType.U8)]
        public byte MLWSUR
        {
            get => _MLWSUR;
            set => WriteParamField(ref _MLWSUR, value);
        }
        private byte _MLWSUR;

        [ParamField(0x7, ParamType.U8)]
        public byte MLWSUA
        {
            get => _MLWSUA;
            set => WriteParamField(ref _MLWSUA, value);
        }
        private byte _MLWSUA;

        [ParamField(0x8, ParamType.U8)]
        public byte MLRSUR
        {
            get => _MLRSUR;
            set => WriteParamField(ref _MLRSUR, value);
        }
        private byte _MLRSUR;

        [ParamField(0x9, ParamType.U8)]
        public byte MLRSUA
        {
            get => _MLRSUA;
            set => WriteParamField(ref _MLRSUA, value);
        }
        private byte _MLRSUA;

        [ParamField(0xA, ParamType.U8)]
        public byte MWLUWS0
        {
            get => _MWLUWS0;
            set => WriteParamField(ref _MWLUWS0, value);
        }
        private byte _MWLUWS0;

        [ParamField(0xB, ParamType.U8)]
        public byte MWLUWS1
        {
            get => _MWLUWS1;
            set => WriteParamField(ref _MWLUWS1, value);
        }
        private byte _MWLUWS1;

        [ParamField(0xC, ParamType.U8)]
        public byte MWLUWS2
        {
            get => _MWLUWS2;
            set => WriteParamField(ref _MWLUWS2, value);
        }
        private byte _MWLUWS2;

        [ParamField(0xD, ParamType.U8)]
        public byte MWLUWS3
        {
            get => _MWLUWS3;
            set => WriteParamField(ref _MWLUWS3, value);
        }
        private byte _MWLUWS3;

        [ParamField(0xE, ParamType.U8)]
        public byte MWLUWS4
        {
            get => _MWLUWS4;
            set => WriteParamField(ref _MWLUWS4, value);
        }
        private byte _MWLUWS4;

        [ParamField(0xF, ParamType.U8)]
        public byte MWLUWS5
        {
            get => _MWLUWS5;
            set => WriteParamField(ref _MWLUWS5, value);
        }
        private byte _MWLUWS5;

        [ParamField(0x10, ParamType.U8)]
        public byte MWLUWS6
        {
            get => _MWLUWS6;
            set => WriteParamField(ref _MWLUWS6, value);
        }
        private byte _MWLUWS6;

        [ParamField(0x11, ParamType.U8)]
        public byte MWLUWS7
        {
            get => _MWLUWS7;
            set => WriteParamField(ref _MWLUWS7, value);
        }
        private byte _MWLUWS7;

        [ParamField(0x12, ParamType.U8)]
        public byte MWLUWS8
        {
            get => _MWLUWS8;
            set => WriteParamField(ref _MWLUWS8, value);
        }
        private byte _MWLUWS8;

        [ParamField(0x13, ParamType.U8)]
        public byte MWLUWS9
        {
            get => _MWLUWS9;
            set => WriteParamField(ref _MWLUWS9, value);
        }
        private byte _MWLUWS9;

        [ParamField(0x14, ParamType.U8)]
        public byte MWLUWS10
        {
            get => _MWLUWS10;
            set => WriteParamField(ref _MWLUWS10, value);
        }
        private byte _MWLUWS10;

        [ParamField(0x15, ParamType.U8)]
        public byte MWLURS0
        {
            get => _MWLURS0;
            set => WriteParamField(ref _MWLURS0, value);
        }
        private byte _MWLURS0;

        [ParamField(0x16, ParamType.U8)]
        public byte MWLURS1
        {
            get => _MWLURS1;
            set => WriteParamField(ref _MWLURS1, value);
        }
        private byte _MWLURS1;

        [ParamField(0x17, ParamType.U8)]
        public byte MWLURS2
        {
            get => _MWLURS2;
            set => WriteParamField(ref _MWLURS2, value);
        }
        private byte _MWLURS2;

        [ParamField(0x18, ParamType.U8)]
        public byte MWLURS3
        {
            get => _MWLURS3;
            set => WriteParamField(ref _MWLURS3, value);
        }
        private byte _MWLURS3;

        [ParamField(0x19, ParamType.U8)]
        public byte MWLURS4
        {
            get => _MWLURS4;
            set => WriteParamField(ref _MWLURS4, value);
        }
        private byte _MWLURS4;

        [ParamField(0x1A, ParamType.U8)]
        public byte MWLURS5
        {
            get => _MWLURS5;
            set => WriteParamField(ref _MWLURS5, value);
        }
        private byte _MWLURS5;

        [ParamField(0x1B, ParamType.U8)]
        public byte MWLURS6
        {
            get => _MWLURS6;
            set => WriteParamField(ref _MWLURS6, value);
        }
        private byte _MWLURS6;

        [ParamField(0x1C, ParamType.U8)]
        public byte MWLURS7
        {
            get => _MWLURS7;
            set => WriteParamField(ref _MWLURS7, value);
        }
        private byte _MWLURS7;

        [ParamField(0x1D, ParamType.U8)]
        public byte MWLURS8
        {
            get => _MWLURS8;
            set => WriteParamField(ref _MWLURS8, value);
        }
        private byte _MWLURS8;

        [ParamField(0x1E, ParamType.U8)]
        public byte MWLURS9
        {
            get => _MWLURS9;
            set => WriteParamField(ref _MWLURS9, value);
        }
        private byte _MWLURS9;

        [ParamField(0x1F, ParamType.U8)]
        public byte MWLURS10
        {
            get => _MWLURS10;
            set => WriteParamField(ref _MWLURS10, value);
        }
        private byte _MWLURS10;

        [ParamField(0x20, ParamType.U8)]
        public byte MWLUA0
        {
            get => _MWLUA0;
            set => WriteParamField(ref _MWLUA0, value);
        }
        private byte _MWLUA0;

        [ParamField(0x21, ParamType.U8)]
        public byte MWLUA1
        {
            get => _MWLUA1;
            set => WriteParamField(ref _MWLUA1, value);
        }
        private byte _MWLUA1;

        [ParamField(0x22, ParamType.U8)]
        public byte MWLUA2
        {
            get => _MWLUA2;
            set => WriteParamField(ref _MWLUA2, value);
        }
        private byte _MWLUA2;

        [ParamField(0x23, ParamType.U8)]
        public byte MWLUA3
        {
            get => _MWLUA3;
            set => WriteParamField(ref _MWLUA3, value);
        }
        private byte _MWLUA3;

        [ParamField(0x24, ParamType.U8)]
        public byte MWLUA4
        {
            get => _MWLUA4;
            set => WriteParamField(ref _MWLUA4, value);
        }
        private byte _MWLUA4;

        [ParamField(0x25, ParamType.U8)]
        public byte MWLUA5
        {
            get => _MWLUA5;
            set => WriteParamField(ref _MWLUA5, value);
        }
        private byte _MWLUA5;

        [ParamField(0x26, ParamType.U8)]
        public byte MWLUA6
        {
            get => _MWLUA6;
            set => WriteParamField(ref _MWLUA6, value);
        }
        private byte _MWLUA6;

        [ParamField(0x27, ParamType.U8)]
        public byte MWLUA7
        {
            get => _MWLUA7;
            set => WriteParamField(ref _MWLUA7, value);
        }
        private byte _MWLUA7;

        [ParamField(0x28, ParamType.U8)]
        public byte MWLUA8
        {
            get => _MWLUA8;
            set => WriteParamField(ref _MWLUA8, value);
        }
        private byte _MWLUA8;

        [ParamField(0x29, ParamType.U8)]
        public byte MWLUA9
        {
            get => _MWLUA9;
            set => WriteParamField(ref _MWLUA9, value);
        }
        private byte _MWLUA9;

        [ParamField(0x2A, ParamType.U8)]
        public byte MWLUA10
        {
            get => _MWLUA10;
            set => WriteParamField(ref _MWLUA10, value);
        }
        private byte _MWLUA10;

        [ParamField(0x2B, ParamType.U8)]
        public byte MLASUR
        {
            get => _MLASUR;
            set => WriteParamField(ref _MLASUR, value);
        }
        private byte _MLASUR;

        [ParamField(0x2C, ParamType.U8)]
        public byte MLASUA
        {
            get => _MLASUA;
            set => WriteParamField(ref _MLASUA, value);
        }
        private byte _MLASUA;

        [ParamField(0x2D, ParamType.Dummy8, 3)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad;

        [ParamField(0x30, ParamType.F32)]
        public float SummonTimeoutTime
        {
            get => _SummonTimeoutTime;
            set => WriteParamField(ref _SummonTimeoutTime, value);
        }
        private float _SummonTimeoutTime;

        [ParamField(0x34, ParamType.U32)]
        public uint SingGetMax
        {
            get => _SingGetMax;
            set => WriteParamField(ref _SingGetMax, value);
        }
        private uint _SingGetMax;

        [ParamField(0x38, ParamType.F32)]
        public float SignDownloadSpan
        {
            get => _SignDownloadSpan;
            set => WriteParamField(ref _SignDownloadSpan, value);
        }
        private float _SignDownloadSpan;

        [ParamField(0x3C, ParamType.F32)]
        public float NitoSignDownloadSpan
        {
            get => _NitoSignDownloadSpan;
            set => WriteParamField(ref _NitoSignDownloadSpan, value);
        }
        private float _NitoSignDownloadSpan;

        [ParamField(0x40, ParamType.F32)]
        public float SignUpdateSpan
        {
            get => _SignUpdateSpan;
            set => WriteParamField(ref _SignUpdateSpan, value);
        }
        private float _SignUpdateSpan;

        [ParamField(0x44, ParamType.U32)]
        public uint MaxBreakInTargetListCount
        {
            get => _MaxBreakInTargetListCount;
            set => WriteParamField(ref _MaxBreakInTargetListCount, value);
        }
        private uint _MaxBreakInTargetListCount;

        [ParamField(0x48, ParamType.F32)]
        public float BreakInRequestIntervalTimeSec
        {
            get => _BreakInRequestIntervalTimeSec;
            set => WriteParamField(ref _BreakInRequestIntervalTimeSec, value);
        }
        private float _BreakInRequestIntervalTimeSec;

        [ParamField(0x4C, ParamType.F32)]
        public float BreakInRequestTimeOutSec
        {
            get => _BreakInRequestTimeOutSec;
            set => WriteParamField(ref _BreakInRequestTimeOutSec, value);
        }
        private float _BreakInRequestTimeOutSec;

        [ParamField(0x50, ParamType.U32)]
        public uint ReloadSignTotalCount_0
        {
            get => _ReloadSignTotalCount_0;
            set => WriteParamField(ref _ReloadSignTotalCount_0, value);
        }
        private uint _ReloadSignTotalCount_0;

        [ParamField(0x54, ParamType.F32)]
        public float ReloadSignIntervalTime_0
        {
            get => _ReloadSignIntervalTime_0;
            set => WriteParamField(ref _ReloadSignIntervalTime_0, value);
        }
        private float _ReloadSignIntervalTime_0;

        [ParamField(0x58, ParamType.F32)]
        public float ReloadSignIntervalTime_1
        {
            get => _ReloadSignIntervalTime_1;
            set => WriteParamField(ref _ReloadSignIntervalTime_1, value);
        }
        private float _ReloadSignIntervalTime_1;

        [ParamField(0x5C, ParamType.U32)]
        public uint ReloadSignTotalCount_1
        {
            get => _ReloadSignTotalCount_1;
            set => WriteParamField(ref _ReloadSignTotalCount_1, value);
        }
        private uint _ReloadSignTotalCount_1;

        [ParamField(0x60, ParamType.U32)]
        public uint ReloadSignCellCount
        {
            get => _ReloadSignCellCount;
            set => WriteParamField(ref _ReloadSignCellCount, value);
        }
        private uint _ReloadSignCellCount;

        [ParamField(0x64, ParamType.F32)]
        public float ReloadSignIntervalTime_2
        {
            get => _ReloadSignIntervalTime_2;
            set => WriteParamField(ref _ReloadSignIntervalTime_2, value);
        }
        private float _ReloadSignIntervalTime_2;

        [ParamField(0x68, ParamType.U32)]
        public uint ReloadGhostTotalCount
        {
            get => _ReloadGhostTotalCount;
            set => WriteParamField(ref _ReloadGhostTotalCount, value);
        }
        private uint _ReloadGhostTotalCount;

        [ParamField(0x6C, ParamType.U32)]
        public uint ReloadGhostCellCount
        {
            get => _ReloadGhostCellCount;
            set => WriteParamField(ref _ReloadGhostCellCount, value);
        }
        private uint _ReloadGhostCellCount;

        [ParamField(0x70, ParamType.U32)]
        public uint MaxGhostTotalCount
        {
            get => _MaxGhostTotalCount;
            set => WriteParamField(ref _MaxGhostTotalCount, value);
        }
        private uint _MaxGhostTotalCount;

        [ParamField(0x74, ParamType.F32)]
        public float UpdateWanderGhostIntervalTime
        {
            get => _UpdateWanderGhostIntervalTime;
            set => WriteParamField(ref _UpdateWanderGhostIntervalTime, value);
        }
        private float _UpdateWanderGhostIntervalTime;

        [ParamField(0x78, ParamType.F32)]
        public float MinReplayIntervalTime
        {
            get => _MinReplayIntervalTime;
            set => WriteParamField(ref _MinReplayIntervalTime, value);
        }
        private float _MinReplayIntervalTime;

        [ParamField(0x7C, ParamType.F32)]
        public float MaxReplayIntervalTime
        {
            get => _MaxReplayIntervalTime;
            set => WriteParamField(ref _MaxReplayIntervalTime, value);
        }
        private float _MaxReplayIntervalTime;

        [ParamField(0x80, ParamType.F32)]
        public float ReloadGhostIntervalTime
        {
            get => _ReloadGhostIntervalTime;
            set => WriteParamField(ref _ReloadGhostIntervalTime, value);
        }
        private float _ReloadGhostIntervalTime;

        [ParamField(0x84, ParamType.F32)]
        public float ReplayBonfireModeRange
        {
            get => _ReplayBonfireModeRange;
            set => WriteParamField(ref _ReplayBonfireModeRange, value);
        }
        private float _ReplayBonfireModeRange;

        [ParamField(0x88, ParamType.F32)]
        public float WanderGhostIntervalLifeTime
        {
            get => _WanderGhostIntervalLifeTime;
            set => WriteParamField(ref _WanderGhostIntervalLifeTime, value);
        }
        private float _WanderGhostIntervalLifeTime;

        [ParamField(0x8C, ParamType.F32)]
        public float SummonMessageInterval
        {
            get => _SummonMessageInterval;
            set => WriteParamField(ref _SummonMessageInterval, value);
        }
        private float _SummonMessageInterval;

        [ParamField(0x90, ParamType.F32)]
        public float HostRegisterUpdateTime
        {
            get => _HostRegisterUpdateTime;
            set => WriteParamField(ref _HostRegisterUpdateTime, value);
        }
        private float _HostRegisterUpdateTime;

        [ParamField(0x94, ParamType.U32)]
        public uint RequestSearchQuickMatchLimit
        {
            get => _RequestSearchQuickMatchLimit;
            set => WriteParamField(ref _RequestSearchQuickMatchLimit, value);
        }
        private uint _RequestSearchQuickMatchLimit;

        [ParamField(0x98, ParamType.F32)]
        public float MyTeamInviteTimeoutTime
        {
            get => _MyTeamInviteTimeoutTime;
            set => WriteParamField(ref _MyTeamInviteTimeoutTime, value);
        }
        private float _MyTeamInviteTimeoutTime;

        [ParamField(0x9C, ParamType.U32)]
        public uint VisitorListMax
        {
            get => _VisitorListMax;
            set => WriteParamField(ref _VisitorListMax, value);
        }
        private uint _VisitorListMax;

        [ParamField(0xA0, ParamType.F32)]
        public float VisitorTimeOutTime
        {
            get => _VisitorTimeOutTime;
            set => WriteParamField(ref _VisitorTimeOutTime, value);
        }
        private float _VisitorTimeOutTime;

        [ParamField(0xA4, ParamType.F32)]
        public float DownloadSpan
        {
            get => _DownloadSpan;
            set => WriteParamField(ref _DownloadSpan, value);
        }
        private float _DownloadSpan;

        [ParamField(0xA8, ParamType.F32)]
        public float BonfireLowerBoundCoolTime
        {
            get => _BonfireLowerBoundCoolTime;
            set => WriteParamField(ref _BonfireLowerBoundCoolTime, value);
        }
        private float _BonfireLowerBoundCoolTime;

        [ParamField(0xAC, ParamType.F32)]
        public float BonfireUpperBoundCoolTime
        {
            get => _BonfireUpperBoundCoolTime;
            set => WriteParamField(ref _BonfireUpperBoundCoolTime, value);
        }
        private float _BonfireUpperBoundCoolTime;

        [ParamField(0xB0, ParamType.F32)]
        public float ResonanceMagicDbDistInterval
        {
            get => _ResonanceMagicDbDistInterval;
            set => WriteParamField(ref _ResonanceMagicDbDistInterval, value);
        }
        private float _ResonanceMagicDbDistInterval;

        [ParamField(0xB4, ParamType.F32)]
        public float InputTimeoutSec
        {
            get => _InputTimeoutSec;
            set => WriteParamField(ref _InputTimeoutSec, value);
        }
        private float _InputTimeoutSec;

        [ParamField(0xB8, ParamType.F32)]
        public float GeneralPurposeParam1
        {
            get => _GeneralPurposeParam1;
            set => WriteParamField(ref _GeneralPurposeParam1, value);
        }
        private float _GeneralPurposeParam1;

        [ParamField(0xBC, ParamType.F32)]
        public float GeneralPurposeParam2
        {
            get => _GeneralPurposeParam2;
            set => WriteParamField(ref _GeneralPurposeParam2, value);
        }
        private float _GeneralPurposeParam2;

        [ParamField(0xC0, ParamType.F32)]
        public float GeneralPurposeParam3
        {
            get => _GeneralPurposeParam3;
            set => WriteParamField(ref _GeneralPurposeParam3, value);
        }
        private float _GeneralPurposeParam3;

        [ParamField(0xC4, ParamType.F32)]
        public float GeneralPurposeParam4
        {
            get => _GeneralPurposeParam4;
            set => WriteParamField(ref _GeneralPurposeParam4, value);
        }
        private float _GeneralPurposeParam4;

        [ParamField(0xC8, ParamType.F32)]
        public float GeneralPurposeParam5
        {
            get => _GeneralPurposeParam5;
            set => WriteParamField(ref _GeneralPurposeParam5, value);
        }
        private float _GeneralPurposeParam5;

        [ParamField(0xCC, ParamType.U8)]
        public byte MWLUWS_11
        {
            get => _MWLUWS_11;
            set => WriteParamField(ref _MWLUWS_11, value);
        }
        private byte _MWLUWS_11;

        [ParamField(0xCD, ParamType.U8)]
        public byte MWLUWS_12
        {
            get => _MWLUWS_12;
            set => WriteParamField(ref _MWLUWS_12, value);
        }
        private byte _MWLUWS_12;

        [ParamField(0xCE, ParamType.U8)]
        public byte MWLUWS_13
        {
            get => _MWLUWS_13;
            set => WriteParamField(ref _MWLUWS_13, value);
        }
        private byte _MWLUWS_13;

        [ParamField(0xCF, ParamType.U8)]
        public byte MWLUWS_14
        {
            get => _MWLUWS_14;
            set => WriteParamField(ref _MWLUWS_14, value);
        }
        private byte _MWLUWS_14;

        [ParamField(0xD0, ParamType.U8)]
        public byte MWLUWS_15
        {
            get => _MWLUWS_15;
            set => WriteParamField(ref _MWLUWS_15, value);
        }
        private byte _MWLUWS_15;

        [ParamField(0xD1, ParamType.U8)]
        public byte MWLURS_11
        {
            get => _MWLURS_11;
            set => WriteParamField(ref _MWLURS_11, value);
        }
        private byte _MWLURS_11;

        [ParamField(0xD2, ParamType.U8)]
        public byte MWLURS_12
        {
            get => _MWLURS_12;
            set => WriteParamField(ref _MWLURS_12, value);
        }
        private byte _MWLURS_12;

        [ParamField(0xD3, ParamType.U8)]
        public byte MWLURS_13
        {
            get => _MWLURS_13;
            set => WriteParamField(ref _MWLURS_13, value);
        }
        private byte _MWLURS_13;

        [ParamField(0xD4, ParamType.U8)]
        public byte MWLURS_14
        {
            get => _MWLURS_14;
            set => WriteParamField(ref _MWLURS_14, value);
        }
        private byte _MWLURS_14;

        [ParamField(0xD5, ParamType.U8)]
        public byte MWLURS_15
        {
            get => _MWLURS_15;
            set => WriteParamField(ref _MWLURS_15, value);
        }
        private byte _MWLURS_15;

        [ParamField(0xD6, ParamType.U8)]
        public byte MWLUAR_11
        {
            get => _MWLUAR_11;
            set => WriteParamField(ref _MWLUAR_11, value);
        }
        private byte _MWLUAR_11;

        [ParamField(0xD7, ParamType.U8)]
        public byte MWLUAR_12
        {
            get => _MWLUAR_12;
            set => WriteParamField(ref _MWLUAR_12, value);
        }
        private byte _MWLUAR_12;

        [ParamField(0xD8, ParamType.U8)]
        public byte MWLUAR_13
        {
            get => _MWLUAR_13;
            set => WriteParamField(ref _MWLUAR_13, value);
        }
        private byte _MWLUAR_13;

        [ParamField(0xD9, ParamType.U8)]
        public byte MWLUAR_14
        {
            get => _MWLUAR_14;
            set => WriteParamField(ref _MWLUAR_14, value);
        }
        private byte _MWLUAR_14;

        [ParamField(0xDA, ParamType.U8)]
        public byte MWLUAR_15
        {
            get => _MWLUAR_15;
            set => WriteParamField(ref _MWLUAR_15, value);
        }
        private byte _MWLUAR_15;

        [ParamField(0xDB, ParamType.U8)]
        public byte GeneralPurposeParam6
        {
            get => _GeneralPurposeParam6;
            set => WriteParamField(ref _GeneralPurposeParam6, value);
        }
        private byte _GeneralPurposeParam6;

    }
}
