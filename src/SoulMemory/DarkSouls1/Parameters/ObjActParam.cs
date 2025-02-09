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
public class ObjActParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int ActionEnableMsgId
    {
        get => _actionEnableMsgId;
        set => WriteParamField(ref _actionEnableMsgId, value);
    }
    private int _actionEnableMsgId;

    [ParamField(0x4, ParamType.I32)]
    public int ActionFailedMsgId
    {
        get => _actionFailedMsgId;
        set => WriteParamField(ref _actionFailedMsgId, value);
    }
    private int _actionFailedMsgId;

    [ParamField(0x8, ParamType.I32)]
    public int SpQualifiedPassEventFlag
    {
        get => _spQualifiedPassEventFlag;
        set => WriteParamField(ref _spQualifiedPassEventFlag, value);
    }
    private int _spQualifiedPassEventFlag;

    [ParamField(0xC, ParamType.U16)]
    public ushort ValidDist
    {
        get => _validDist;
        set => WriteParamField(ref _validDist, value);
    }
    private ushort _validDist;

    [ParamField(0xE, ParamType.U16)]
    public ushort PlayerAnimId
    {
        get => _playerAnimId;
        set => WriteParamField(ref _playerAnimId, value);
    }
    private ushort _playerAnimId;

    [ParamField(0x10, ParamType.U16)]
    public ushort ChrAnimId
    {
        get => _chrAnimId;
        set => WriteParamField(ref _chrAnimId, value);
    }
    private ushort _chrAnimId;

    [ParamField(0x12, ParamType.U16)]
    public ushort SpQualifiedId
    {
        get => _spQualifiedId;
        set => WriteParamField(ref _spQualifiedId, value);
    }
    private ushort _spQualifiedId;

    [ParamField(0x14, ParamType.U16)]
    public ushort SpQualifiedId2
    {
        get => _spQualifiedId2;
        set => WriteParamField(ref _spQualifiedId2, value);
    }
    private ushort _spQualifiedId2;

    [ParamField(0x16, ParamType.U8)]
    public byte ObjDummyId
    {
        get => _objDummyId;
        set => WriteParamField(ref _objDummyId, value);
    }
    private byte _objDummyId;

    [ParamField(0x17, ParamType.U8)]
    public byte ObjAnimId
    {
        get => _objAnimId;
        set => WriteParamField(ref _objAnimId, value);
    }
    private byte _objAnimId;

    [ParamField(0x18, ParamType.U8)]
    public byte ValidPlayerAngle
    {
        get => _validPlayerAngle;
        set => WriteParamField(ref _validPlayerAngle, value);
    }
    private byte _validPlayerAngle;

    [ParamField(0x19, ParamType.U8)]
    public byte SpQualifiedType
    {
        get => _spQualifiedType;
        set => WriteParamField(ref _spQualifiedType, value);
    }
    private byte _spQualifiedType;

    [ParamField(0x1A, ParamType.U8)]
    public byte SpQualifiedType2
    {
        get => _spQualifiedType2;
        set => WriteParamField(ref _spQualifiedType2, value);
    }
    private byte _spQualifiedType2;

    [ParamField(0x1B, ParamType.U8)]
    public byte ValidObjAngle
    {
        get => _validObjAngle;
        set => WriteParamField(ref _validObjAngle, value);
    }
    private byte _validObjAngle;

    [ParamField(0x1C, ParamType.U8)]
    public byte ChrSorbType
    {
        get => _chrSorbType;
        set => WriteParamField(ref _chrSorbType, value);
    }
    private byte _chrSorbType;

    [ParamField(0x1D, ParamType.U8)]
    public byte EventKickTiming
    {
        get => _eventKickTiming;
        set => WriteParamField(ref _eventKickTiming, value);
    }
    private byte _eventKickTiming;

    [ParamField(0x1E, ParamType.Dummy8, 2)]
    public byte[] Pad1
    {
        get => _pad1;
        set => WriteParamField(ref _pad1, value);
    }
    private byte[] _pad1 = null!;

}
