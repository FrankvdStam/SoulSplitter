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
public class TalkParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int MsgId
    {
        get => _msgId;
        set => WriteParamField(ref _msgId, value);
    }
    private int _msgId;

    [ParamField(0x4, ParamType.I32)]
    public int VoiceId
    {
        get => _voiceId;
        set => WriteParamField(ref _voiceId, value);
    }
    private int _voiceId;

    [ParamField(0x8, ParamType.I32)]
    public int MotionId
    {
        get => _motionId;
        set => WriteParamField(ref _motionId, value);
    }
    private int _motionId;

    [ParamField(0xC, ParamType.I32)]
    public int ReturnPos
    {
        get => _returnPos;
        set => WriteParamField(ref _returnPos, value);
    }
    private int _returnPos;

    [ParamField(0x10, ParamType.I32)]
    public int ReactionId
    {
        get => _reactionId;
        set => WriteParamField(ref _reactionId, value);
    }
    private int _reactionId;

    [ParamField(0x14, ParamType.I32)]
    public int EventId
    {
        get => _eventId;
        set => WriteParamField(ref _eventId, value);
    }
    private int _eventId;

    [ParamField(0x18, ParamType.U8)]
    public byte IsMotionLoop
    {
        get => _isMotionLoop;
        set => WriteParamField(ref _isMotionLoop, value);
    }
    private byte _isMotionLoop;

    [ParamField(0x19, ParamType.Dummy8, 7)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

}
