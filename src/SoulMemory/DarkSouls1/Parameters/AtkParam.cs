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
public class AtkParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float Hit0Radius
    {
        get => _hit0Radius;
        set => WriteParamField(ref _hit0Radius, value);
    }
    private float _hit0Radius;

    [ParamField(0x4, ParamType.F32)]
    public float Hit1Radius
    {
        get => _hit1Radius;
        set => WriteParamField(ref _hit1Radius, value);
    }
    private float _hit1Radius;

    [ParamField(0x8, ParamType.F32)]
    public float Hit2Radius
    {
        get => _hit2Radius;
        set => WriteParamField(ref _hit2Radius, value);
    }
    private float _hit2Radius;

    [ParamField(0xC, ParamType.F32)]
    public float Hit3Radius
    {
        get => _hit3Radius;
        set => WriteParamField(ref _hit3Radius, value);
    }
    private float _hit3Radius;

    [ParamField(0x10, ParamType.F32)]
    public float KnockbackDist
    {
        get => _knockbackDist;
        set => WriteParamField(ref _knockbackDist, value);
    }
    private float _knockbackDist;

    [ParamField(0x14, ParamType.F32)]
    public float HitStopTime
    {
        get => _hitStopTime;
        set => WriteParamField(ref _hitStopTime, value);
    }
    private float _hitStopTime;

    [ParamField(0x18, ParamType.I32)]
    public int SpEffectId0
    {
        get => _spEffectId0;
        set => WriteParamField(ref _spEffectId0, value);
    }
    private int _spEffectId0;

    [ParamField(0x1C, ParamType.I32)]
    public int SpEffectId1
    {
        get => _spEffectId1;
        set => WriteParamField(ref _spEffectId1, value);
    }
    private int _spEffectId1;

    [ParamField(0x20, ParamType.I32)]
    public int SpEffectId2
    {
        get => _spEffectId2;
        set => WriteParamField(ref _spEffectId2, value);
    }
    private int _spEffectId2;

    [ParamField(0x24, ParamType.I32)]
    public int SpEffectId3
    {
        get => _spEffectId3;
        set => WriteParamField(ref _spEffectId3, value);
    }
    private int _spEffectId3;

    [ParamField(0x28, ParamType.I32)]
    public int SpEffectId4
    {
        get => _spEffectId4;
        set => WriteParamField(ref _spEffectId4, value);
    }
    private int _spEffectId4;

    [ParamField(0x2C, ParamType.I16)]
    public short Hit0DmyPoly1
    {
        get => _hit0DmyPoly1;
        set => WriteParamField(ref _hit0DmyPoly1, value);
    }
    private short _hit0DmyPoly1;

    [ParamField(0x2E, ParamType.I16)]
    public short Hit1DmyPoly1
    {
        get => _hit1DmyPoly1;
        set => WriteParamField(ref _hit1DmyPoly1, value);
    }
    private short _hit1DmyPoly1;

    [ParamField(0x30, ParamType.I16)]
    public short Hit2DmyPoly1
    {
        get => _hit2DmyPoly1;
        set => WriteParamField(ref _hit2DmyPoly1, value);
    }
    private short _hit2DmyPoly1;

    [ParamField(0x32, ParamType.I16)]
    public short Hit3DmyPoly1
    {
        get => _hit3DmyPoly1;
        set => WriteParamField(ref _hit3DmyPoly1, value);
    }
    private short _hit3DmyPoly1;

    [ParamField(0x34, ParamType.I16)]
    public short Hit0DmyPoly2
    {
        get => _hit0DmyPoly2;
        set => WriteParamField(ref _hit0DmyPoly2, value);
    }
    private short _hit0DmyPoly2;

    [ParamField(0x36, ParamType.I16)]
    public short Hit1DmyPoly2
    {
        get => _hit1DmyPoly2;
        set => WriteParamField(ref _hit1DmyPoly2, value);
    }
    private short _hit1DmyPoly2;

    [ParamField(0x38, ParamType.I16)]
    public short Hit2DmyPoly2
    {
        get => _hit2DmyPoly2;
        set => WriteParamField(ref _hit2DmyPoly2, value);
    }
    private short _hit2DmyPoly2;

    [ParamField(0x3A, ParamType.I16)]
    public short Hit3DmyPoly2
    {
        get => _hit3DmyPoly2;
        set => WriteParamField(ref _hit3DmyPoly2, value);
    }
    private short _hit3DmyPoly2;

    [ParamField(0x3C, ParamType.U16)]
    public ushort BlowingCorrection
    {
        get => _blowingCorrection;
        set => WriteParamField(ref _blowingCorrection, value);
    }
    private ushort _blowingCorrection;

    [ParamField(0x3E, ParamType.U16)]
    public ushort AtkPhysCorrection
    {
        get => _atkPhysCorrection;
        set => WriteParamField(ref _atkPhysCorrection, value);
    }
    private ushort _atkPhysCorrection;

    [ParamField(0x40, ParamType.U16)]
    public ushort AtkMagCorrection
    {
        get => _atkMagCorrection;
        set => WriteParamField(ref _atkMagCorrection, value);
    }
    private ushort _atkMagCorrection;

    [ParamField(0x42, ParamType.U16)]
    public ushort AtkFireCorrection
    {
        get => _atkFireCorrection;
        set => WriteParamField(ref _atkFireCorrection, value);
    }
    private ushort _atkFireCorrection;

    [ParamField(0x44, ParamType.U16)]
    public ushort AtkThunCorrection
    {
        get => _atkThunCorrection;
        set => WriteParamField(ref _atkThunCorrection, value);
    }
    private ushort _atkThunCorrection;

    [ParamField(0x46, ParamType.U16)]
    public ushort AtkStamCorrection
    {
        get => _atkStamCorrection;
        set => WriteParamField(ref _atkStamCorrection, value);
    }
    private ushort _atkStamCorrection;

    [ParamField(0x48, ParamType.U16)]
    public ushort GuardAtkRateCorrection
    {
        get => _guardAtkRateCorrection;
        set => WriteParamField(ref _guardAtkRateCorrection, value);
    }
    private ushort _guardAtkRateCorrection;

    [ParamField(0x4A, ParamType.U16)]
    public ushort GuardBreakCorrection
    {
        get => _guardBreakCorrection;
        set => WriteParamField(ref _guardBreakCorrection, value);
    }
    private ushort _guardBreakCorrection;

    [ParamField(0x4C, ParamType.U16)]
    public ushort AtkThrowEscapeCorrection
    {
        get => _atkThrowEscapeCorrection;
        set => WriteParamField(ref _atkThrowEscapeCorrection, value);
    }
    private ushort _atkThrowEscapeCorrection;

    [ParamField(0x4E, ParamType.U16)]
    public ushort AtkSuperArmorCorrection
    {
        get => _atkSuperArmorCorrection;
        set => WriteParamField(ref _atkSuperArmorCorrection, value);
    }
    private ushort _atkSuperArmorCorrection;

    [ParamField(0x50, ParamType.U16)]
    public ushort AtkPhys
    {
        get => _atkPhys;
        set => WriteParamField(ref _atkPhys, value);
    }
    private ushort _atkPhys;

    [ParamField(0x52, ParamType.U16)]
    public ushort AtkMag
    {
        get => _atkMag;
        set => WriteParamField(ref _atkMag, value);
    }
    private ushort _atkMag;

    [ParamField(0x54, ParamType.U16)]
    public ushort AtkFire
    {
        get => _atkFire;
        set => WriteParamField(ref _atkFire, value);
    }
    private ushort _atkFire;

    [ParamField(0x56, ParamType.U16)]
    public ushort AtkThun
    {
        get => _atkThun;
        set => WriteParamField(ref _atkThun, value);
    }
    private ushort _atkThun;

    [ParamField(0x58, ParamType.U16)]
    public ushort AtkStam
    {
        get => _atkStam;
        set => WriteParamField(ref _atkStam, value);
    }
    private ushort _atkStam;

    [ParamField(0x5A, ParamType.U16)]
    public ushort GuardAtkRate
    {
        get => _guardAtkRate;
        set => WriteParamField(ref _guardAtkRate, value);
    }
    private ushort _guardAtkRate;

    [ParamField(0x5C, ParamType.U16)]
    public ushort GuardBreakRate
    {
        get => _guardBreakRate;
        set => WriteParamField(ref _guardBreakRate, value);
    }
    private ushort _guardBreakRate;

    [ParamField(0x5E, ParamType.U16)]
    public ushort AtkSuperArmor
    {
        get => _atkSuperArmor;
        set => WriteParamField(ref _atkSuperArmor, value);
    }
    private ushort _atkSuperArmor;

    [ParamField(0x60, ParamType.U16)]
    public ushort AtkThrowEscape
    {
        get => _atkThrowEscape;
        set => WriteParamField(ref _atkThrowEscape, value);
    }
    private ushort _atkThrowEscape;

    [ParamField(0x62, ParamType.U16)]
    public ushort AtkObj
    {
        get => _atkObj;
        set => WriteParamField(ref _atkObj, value);
    }
    private ushort _atkObj;

    [ParamField(0x64, ParamType.I16)]
    public short GuardStaminaCutRate
    {
        get => _guardStaminaCutRate;
        set => WriteParamField(ref _guardStaminaCutRate, value);
    }
    private short _guardStaminaCutRate;

    [ParamField(0x66, ParamType.I16)]
    public short GuardRate
    {
        get => _guardRate;
        set => WriteParamField(ref _guardRate, value);
    }
    private short _guardRate;

    [ParamField(0x68, ParamType.U16)]
    public ushort ThrowTypeId
    {
        get => _throwTypeId;
        set => WriteParamField(ref _throwTypeId, value);
    }
    private ushort _throwTypeId;

    [ParamField(0x6A, ParamType.U8)]
    public byte Hit0HitType
    {
        get => _hit0HitType;
        set => WriteParamField(ref _hit0HitType, value);
    }
    private byte _hit0HitType;

    [ParamField(0x6B, ParamType.U8)]
    public byte Hit1HitType
    {
        get => _hit1HitType;
        set => WriteParamField(ref _hit1HitType, value);
    }
    private byte _hit1HitType;

    [ParamField(0x6C, ParamType.U8)]
    public byte Hit2HitType
    {
        get => _hit2HitType;
        set => WriteParamField(ref _hit2HitType, value);
    }
    private byte _hit2HitType;

    [ParamField(0x6D, ParamType.U8)]
    public byte Hit3HitType
    {
        get => _hit3HitType;
        set => WriteParamField(ref _hit3HitType, value);
    }
    private byte _hit3HitType;

    [ParamField(0x6E, ParamType.U8)]
    public byte Hti0Priority
    {
        get => _hti0Priority;
        set => WriteParamField(ref _hti0Priority, value);
    }
    private byte _hti0Priority;

    [ParamField(0x6F, ParamType.U8)]
    public byte Hti1Priority
    {
        get => _hti1Priority;
        set => WriteParamField(ref _hti1Priority, value);
    }
    private byte _hti1Priority;

    [ParamField(0x70, ParamType.U8)]
    public byte Hti2Priority
    {
        get => _hti2Priority;
        set => WriteParamField(ref _hti2Priority, value);
    }
    private byte _hti2Priority;

    [ParamField(0x71, ParamType.U8)]
    public byte Hti3Priority
    {
        get => _hti3Priority;
        set => WriteParamField(ref _hti3Priority, value);
    }
    private byte _hti3Priority;

    [ParamField(0x72, ParamType.U8)]
    public byte DmgLevel
    {
        get => _dmgLevel;
        set => WriteParamField(ref _dmgLevel, value);
    }
    private byte _dmgLevel;

    [ParamField(0x73, ParamType.U8)]
    public byte MapHitType
    {
        get => _mapHitType;
        set => WriteParamField(ref _mapHitType, value);
    }
    private byte _mapHitType;

    [ParamField(0x74, ParamType.I8)]
    public sbyte GuardCutCancelRate
    {
        get => _guardCutCancelRate;
        set => WriteParamField(ref _guardCutCancelRate, value);
    }
    private sbyte _guardCutCancelRate;

    [ParamField(0x75, ParamType.U8)]
    public byte AtkAttribute
    {
        get => _atkAttribute;
        set => WriteParamField(ref _atkAttribute, value);
    }
    private byte _atkAttribute;

    [ParamField(0x76, ParamType.U8)]
    public byte SpAttribute
    {
        get => _spAttribute;
        set => WriteParamField(ref _spAttribute, value);
    }
    private byte _spAttribute;

    [ParamField(0x77, ParamType.U8)]
    public byte AtkType
    {
        get => _atkType;
        set => WriteParamField(ref _atkType, value);
    }
    private byte _atkType;

    [ParamField(0x78, ParamType.U8)]
    public byte AtkMaterial
    {
        get => _atkMaterial;
        set => WriteParamField(ref _atkMaterial, value);
    }
    private byte _atkMaterial;

    [ParamField(0x79, ParamType.U8)]
    public byte AtkSize
    {
        get => _atkSize;
        set => WriteParamField(ref _atkSize, value);
    }
    private byte _atkSize;

    [ParamField(0x7A, ParamType.U8)]
    public byte DefMaterial
    {
        get => _defMaterial;
        set => WriteParamField(ref _defMaterial, value);
    }
    private byte _defMaterial;

    [ParamField(0x7B, ParamType.U8)]
    public byte DefSfxMaterial
    {
        get => _defSfxMaterial;
        set => WriteParamField(ref _defSfxMaterial, value);
    }
    private byte _defSfxMaterial;

    [ParamField(0x7C, ParamType.U8)]
    public byte HitSourceType
    {
        get => _hitSourceType;
        set => WriteParamField(ref _hitSourceType, value);
    }
    private byte _hitSourceType;

    [ParamField(0x7D, ParamType.U8)]
    public byte ThrowFlag
    {
        get => _throwFlag;
        set => WriteParamField(ref _throwFlag, value);
    }
    private byte _throwFlag;

    #region BitField DisableGuardBitfield ==============================================================================

    [ParamField(0x7E, ParamType.U8)]
    public byte DisableGuardBitfield
    {
        get => _disableGuardBitfield;
        set => WriteParamField(ref _disableGuardBitfield, value);
    }
    private byte _disableGuardBitfield;

    [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 0)]
    public byte DisableGuard
    {
        get => GetbitfieldValue(_disableGuardBitfield);
        set => SetBitfieldValue(ref _disableGuardBitfield, value);
    }

    [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 1)]
    public byte DisableStaminaAttack
    {
        get => GetbitfieldValue(_disableGuardBitfield);
        set => SetBitfieldValue(ref _disableGuardBitfield, value);
    }

    [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 2)]
    public byte DisableHitSpEffect
    {
        get => GetbitfieldValue(_disableGuardBitfield);
        set => SetBitfieldValue(ref _disableGuardBitfield, value);
    }

    [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 3)]
    public byte IgnoreNotifyMissSwingForAi
    {
        get => GetbitfieldValue(_disableGuardBitfield);
        set => SetBitfieldValue(ref _disableGuardBitfield, value);
    }

    [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 4)]
    public byte RepeatHitSfx
    {
        get => GetbitfieldValue(_disableGuardBitfield);
        set => SetBitfieldValue(ref _disableGuardBitfield, value);
    }

    [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 5)]
    public byte IsArrowAtk
    {
        get => GetbitfieldValue(_disableGuardBitfield);
        set => SetBitfieldValue(ref _disableGuardBitfield, value);
    }

    [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 6)]
    public byte IsGhostAtk
    {
        get => GetbitfieldValue(_disableGuardBitfield);
        set => SetBitfieldValue(ref _disableGuardBitfield, value);
    }

    [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 7)]
    public byte IsDisableNoDamage
    {
        get => GetbitfieldValue(_disableGuardBitfield);
        set => SetBitfieldValue(ref _disableGuardBitfield, value);
    }

    #endregion BitField DisableGuardBitfield

    [ParamField(0x7F, ParamType.Dummy8, 1)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
