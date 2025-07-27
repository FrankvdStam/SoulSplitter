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
public class SpEffectVfx(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int MidstSfxId
    {
        get => _midstSfxId;
        set => WriteParamField(ref _midstSfxId, value);
    }
    private int _midstSfxId;

    [ParamField(0x4, ParamType.I32)]
    public int MidstSeId
    {
        get => _midstSeId;
        set => WriteParamField(ref _midstSeId, value);
    }
    private int _midstSeId;

    [ParamField(0x8, ParamType.I32)]
    public int InitSfxId
    {
        get => _initSfxId;
        set => WriteParamField(ref _initSfxId, value);
    }
    private int _initSfxId;

    [ParamField(0xC, ParamType.I32)]
    public int InitSeId
    {
        get => _initSeId;
        set => WriteParamField(ref _initSeId, value);
    }
    private int _initSeId;

    [ParamField(0x10, ParamType.I32)]
    public int FinishSfxId
    {
        get => _finishSfxId;
        set => WriteParamField(ref _finishSfxId, value);
    }
    private int _finishSfxId;

    [ParamField(0x14, ParamType.I32)]
    public int FinishSeId
    {
        get => _finishSeId;
        set => WriteParamField(ref _finishSeId, value);
    }
    private int _finishSeId;

    [ParamField(0x18, ParamType.F32)]
    public float CamouflageBeginDist
    {
        get => _camouflageBeginDist;
        set => WriteParamField(ref _camouflageBeginDist, value);
    }
    private float _camouflageBeginDist;

    [ParamField(0x1C, ParamType.F32)]
    public float CamouflageEndDist
    {
        get => _camouflageEndDist;
        set => WriteParamField(ref _camouflageEndDist, value);
    }
    private float _camouflageEndDist;

    [ParamField(0x20, ParamType.I32)]
    public int TransformProtectorId
    {
        get => _transformProtectorId;
        set => WriteParamField(ref _transformProtectorId, value);
    }
    private int _transformProtectorId;

    [ParamField(0x24, ParamType.I16)]
    public short MidstDmyId
    {
        get => _midstDmyId;
        set => WriteParamField(ref _midstDmyId, value);
    }
    private short _midstDmyId;

    [ParamField(0x26, ParamType.I16)]
    public short InitDmyId
    {
        get => _initDmyId;
        set => WriteParamField(ref _initDmyId, value);
    }
    private short _initDmyId;

    [ParamField(0x28, ParamType.I16)]
    public short FinishDmyId
    {
        get => _finishDmyId;
        set => WriteParamField(ref _finishDmyId, value);
    }
    private short _finishDmyId;

    [ParamField(0x2A, ParamType.U8)]
    public byte EffectType
    {
        get => _effectType;
        set => WriteParamField(ref _effectType, value);
    }
    private byte _effectType;

    [ParamField(0x2B, ParamType.U8)]
    public byte SoulParamIdForWepEnchant
    {
        get => _soulParamIdForWepEnchant;
        set => WriteParamField(ref _soulParamIdForWepEnchant, value);
    }
    private byte _soulParamIdForWepEnchant;

    [ParamField(0x2C, ParamType.U8)]
    public byte PlayCategory
    {
        get => _playCategory;
        set => WriteParamField(ref _playCategory, value);
    }
    private byte _playCategory;

    [ParamField(0x2D, ParamType.U8)]
    public byte PlayPriority
    {
        get => _playPriority;
        set => WriteParamField(ref _playPriority, value);
    }
    private byte _playPriority;

    #region BitField ExistEffectForLargeBitfield ==============================================================================

    [ParamField(0x2E, ParamType.U8)]
    public byte ExistEffectForLargeBitfield
    {
        get => _existEffectForLargeBitfield;
        set => WriteParamField(ref _existEffectForLargeBitfield, value);
    }
    private byte _existEffectForLargeBitfield;

    [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 0)]
    public byte ExistEffectForLarge
    {
        get => GetbitfieldValue(_existEffectForLargeBitfield);
        set => SetBitfieldValue(ref _existEffectForLargeBitfield, value);
    }

    [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 1)]
    public byte ExistEffectForSoul
    {
        get => GetbitfieldValue(_existEffectForLargeBitfield);
        set => SetBitfieldValue(ref _existEffectForLargeBitfield, value);
    }

    [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 2)]
    public byte EffectInvisibleAtCamouflage
    {
        get => GetbitfieldValue(_existEffectForLargeBitfield);
        set => SetBitfieldValue(ref _existEffectForLargeBitfield, value);
    }

    [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 3)]
    public byte UseCamouflage
    {
        get => GetbitfieldValue(_existEffectForLargeBitfield);
        set => SetBitfieldValue(ref _existEffectForLargeBitfield, value);
    }

    [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 4)]
    public byte InvisibleAtFriendCamouflage
    {
        get => GetbitfieldValue(_existEffectForLargeBitfield);
        set => SetBitfieldValue(ref _existEffectForLargeBitfield, value);
    }

    [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 5)]
    public byte AddMapAreaBlockOffset
    {
        get => GetbitfieldValue(_existEffectForLargeBitfield);
        set => SetBitfieldValue(ref _existEffectForLargeBitfield, value);
    }

    [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 6)]
    public byte HalfCamouflage
    {
        get => GetbitfieldValue(_existEffectForLargeBitfield);
        set => SetBitfieldValue(ref _existEffectForLargeBitfield, value);
    }

    [ParamBitField(nameof(ExistEffectForLargeBitfield), bits: 1, bitsOffset: 7)]
    public byte IsFullBodyTransformProtectorId
    {
        get => GetbitfieldValue(_existEffectForLargeBitfield);
        set => SetBitfieldValue(ref _existEffectForLargeBitfield, value);
    }

    #endregion BitField ExistEffectForLargeBitfield

    #region BitField IsInvisibleWeaponBitfield ==============================================================================

    [ParamField(0x2F, ParamType.U8)]
    public byte IsInvisibleWeaponBitfield
    {
        get => _isInvisibleWeaponBitfield;
        set => WriteParamField(ref _isInvisibleWeaponBitfield, value);
    }
    private byte _isInvisibleWeaponBitfield;

    [ParamBitField(nameof(IsInvisibleWeaponBitfield), bits: 1, bitsOffset: 0)]
    public byte IsInvisibleWeapon
    {
        get => GetbitfieldValue(_isInvisibleWeaponBitfield);
        set => SetBitfieldValue(ref _isInvisibleWeaponBitfield, value);
    }

    [ParamBitField(nameof(IsInvisibleWeaponBitfield), bits: 1, bitsOffset: 1)]
    public byte IsSilence
    {
        get => GetbitfieldValue(_isInvisibleWeaponBitfield);
        set => SetBitfieldValue(ref _isInvisibleWeaponBitfield, value);
    }

    [ParamBitField(nameof(IsInvisibleWeaponBitfield), bits: 6, bitsOffset: 2)]
    public byte Pad1
    {
        get => GetbitfieldValue(_isInvisibleWeaponBitfield);
        set => SetBitfieldValue(ref _isInvisibleWeaponBitfield, value);
    }

    #endregion BitField IsInvisibleWeaponBitfield

    [ParamField(0x30, ParamType.Dummy8, 16)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
