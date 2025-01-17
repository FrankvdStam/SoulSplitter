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
public class TalkParam : BaseParam
{
    public TalkParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

    [ParamField(0x0, ParamType.I32)]
    public int MsgId
    {
        get => _MsgId;
        set => WriteParamField(ref _MsgId, value);
    }
    private int _MsgId;

    [ParamField(0x4, ParamType.I32)]
    public int VoiceId
    {
        get => _VoiceId;
        set => WriteParamField(ref _VoiceId, value);
    }
    private int _VoiceId;

    [ParamField(0x8, ParamType.I32)]
    public int MotionId
    {
        get => _MotionId;
        set => WriteParamField(ref _MotionId, value);
    }
    private int _MotionId;

    [ParamField(0xC, ParamType.I32)]
    public int ReturnPos
    {
        get => _ReturnPos;
        set => WriteParamField(ref _ReturnPos, value);
    }
    private int _ReturnPos;

    [ParamField(0x10, ParamType.I32)]
    public int ReactionId
    {
        get => _ReactionId;
        set => WriteParamField(ref _ReactionId, value);
    }
    private int _ReactionId;

    [ParamField(0x14, ParamType.I32)]
    public int EventId
    {
        get => _EventId;
        set => WriteParamField(ref _EventId, value);
    }
    private int _EventId;

    [ParamField(0x18, ParamType.U8)]
    public byte IsMotionLoop
    {
        get => _IsMotionLoop;
        set => WriteParamField(ref _IsMotionLoop, value);
    }
    private byte _IsMotionLoop;

    [ParamField(0x19, ParamType.Dummy8, 7)]
    public byte[] Pad0
    {
        get => _Pad0;
        set => WriteParamField(ref _Pad0, value);
    }
    private byte[] _Pad0 = null!;

}
