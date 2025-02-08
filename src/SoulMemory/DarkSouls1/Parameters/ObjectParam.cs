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
public class ObjectParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I16)]
    public short Hp
    {
        get => _hp;
        set => WriteParamField(ref _hp, value);
    }
    private short _hp;

    [ParamField(0x2, ParamType.U16)]
    public ushort Defense
    {
        get => _defense;
        set => WriteParamField(ref _defense, value);
    }
    private ushort _defense;

    [ParamField(0x4, ParamType.I16)]
    public short ExtRefTexId
    {
        get => _extRefTexId;
        set => WriteParamField(ref _extRefTexId, value);
    }
    private short _extRefTexId;

    [ParamField(0x6, ParamType.I16)]
    public short MaterialId
    {
        get => _materialId;
        set => WriteParamField(ref _materialId, value);
    }
    private short _materialId;

    [ParamField(0x8, ParamType.U8)]
    public byte AnimBreakIdMax
    {
        get => _animBreakIdMax;
        set => WriteParamField(ref _animBreakIdMax, value);
    }
    private byte _animBreakIdMax;

    #region BitField IsCamHitBitfield ==============================================================================

    [ParamField(0x9, ParamType.U8)]
    public byte IsCamHitBitfield
    {
        get => _isCamHitBitfield;
        set => WriteParamField(ref _isCamHitBitfield, value);
    }
    private byte _isCamHitBitfield;

    [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 0)]
    public byte IsCamHit
    {
        get => GetbitfieldValue(_isCamHitBitfield);
        set => SetBitfieldValue(ref _isCamHitBitfield, value);
    }

    [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 1)]
    public byte IsBreakByPlayerCollide
    {
        get => GetbitfieldValue(_isCamHitBitfield);
        set => SetBitfieldValue(ref _isCamHitBitfield, value);
    }

    [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 2)]
    public byte IsAnimBreak
    {
        get => GetbitfieldValue(_isCamHitBitfield);
        set => SetBitfieldValue(ref _isCamHitBitfield, value);
    }

    [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 3)]
    public byte IsPenetrationBulletHit
    {
        get => GetbitfieldValue(_isCamHitBitfield);
        set => SetBitfieldValue(ref _isCamHitBitfield, value);
    }

    [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 4)]
    public byte IsChrHit
    {
        get => GetbitfieldValue(_isCamHitBitfield);
        set => SetBitfieldValue(ref _isCamHitBitfield, value);
    }

    [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 5)]
    public byte IsAttackBacklash
    {
        get => GetbitfieldValue(_isCamHitBitfield);
        set => SetBitfieldValue(ref _isCamHitBitfield, value);
    }

    [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 6)]
    public byte IsDisableBreakForFirstAppear
    {
        get => GetbitfieldValue(_isCamHitBitfield);
        set => SetBitfieldValue(ref _isCamHitBitfield, value);
    }

    [ParamBitField(nameof(IsCamHitBitfield), bits: 1, bitsOffset: 7)]
    public byte IsLadder
    {
        get => GetbitfieldValue(_isCamHitBitfield);
        set => SetBitfieldValue(ref _isCamHitBitfield, value);
    }

    #endregion BitField IsCamHitBitfield

    #region BitField IsAnimPauseOnRemoPlayBitfield ==============================================================================

    [ParamField(0xA, ParamType.U8)]
    public byte IsAnimPauseOnRemoPlayBitfield
    {
        get => _isAnimPauseOnRemoPlayBitfield;
        set => WriteParamField(ref _isAnimPauseOnRemoPlayBitfield, value);
    }
    private byte _isAnimPauseOnRemoPlayBitfield;

    [ParamBitField(nameof(IsAnimPauseOnRemoPlayBitfield), bits: 1, bitsOffset: 0)]
    public byte IsAnimPauseOnRemoPlay
    {
        get => GetbitfieldValue(_isAnimPauseOnRemoPlayBitfield);
        set => SetBitfieldValue(ref _isAnimPauseOnRemoPlayBitfield, value);
    }

    [ParamBitField(nameof(IsAnimPauseOnRemoPlayBitfield), bits: 1, bitsOffset: 1)]
    public byte IsDamageNoHit
    {
        get => GetbitfieldValue(_isAnimPauseOnRemoPlayBitfield);
        set => SetBitfieldValue(ref _isAnimPauseOnRemoPlayBitfield, value);
    }

    [ParamBitField(nameof(IsAnimPauseOnRemoPlayBitfield), bits: 1, bitsOffset: 2)]
    public byte IsMoveObj
    {
        get => GetbitfieldValue(_isAnimPauseOnRemoPlayBitfield);
        set => SetBitfieldValue(ref _isAnimPauseOnRemoPlayBitfield, value);
    }

    [ParamBitField(nameof(IsAnimPauseOnRemoPlayBitfield), bits: 5, bitsOffset: 3)]
    public byte Pad1
    {
        get => GetbitfieldValue(_isAnimPauseOnRemoPlayBitfield);
        set => SetBitfieldValue(ref _isAnimPauseOnRemoPlayBitfield, value);
    }

    #endregion BitField IsAnimPauseOnRemoPlayBitfield

    [ParamField(0xB, ParamType.I8)]
    public sbyte DefaultLodParamId
    {
        get => _defaultLodParamId;
        set => WriteParamField(ref _defaultLodParamId, value);
    }
    private sbyte _defaultLodParamId;

    [ParamField(0xC, ParamType.I32)]
    public int BreakSfxId
    {
        get => _breakSfxId;
        set => WriteParamField(ref _breakSfxId, value);
    }
    private int _breakSfxId;

}
