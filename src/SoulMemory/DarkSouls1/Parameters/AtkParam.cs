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
    public class AtkParam : BaseParam
    {
        public AtkParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float Hit0_Radius
        {
            get => _Hit0_Radius;
            set => WriteParamField(ref _Hit0_Radius, value);
        }
        private float _Hit0_Radius;

        [ParamField(0x4, ParamType.F32)]
        public float Hit1_Radius
        {
            get => _Hit1_Radius;
            set => WriteParamField(ref _Hit1_Radius, value);
        }
        private float _Hit1_Radius;

        [ParamField(0x8, ParamType.F32)]
        public float Hit2_Radius
        {
            get => _Hit2_Radius;
            set => WriteParamField(ref _Hit2_Radius, value);
        }
        private float _Hit2_Radius;

        [ParamField(0xC, ParamType.F32)]
        public float Hit3_Radius
        {
            get => _Hit3_Radius;
            set => WriteParamField(ref _Hit3_Radius, value);
        }
        private float _Hit3_Radius;

        [ParamField(0x10, ParamType.F32)]
        public float KnockbackDist
        {
            get => _KnockbackDist;
            set => WriteParamField(ref _KnockbackDist, value);
        }
        private float _KnockbackDist;

        [ParamField(0x14, ParamType.F32)]
        public float HitStopTime
        {
            get => _HitStopTime;
            set => WriteParamField(ref _HitStopTime, value);
        }
        private float _HitStopTime;

        [ParamField(0x18, ParamType.I32)]
        public int SpEffectId0
        {
            get => _SpEffectId0;
            set => WriteParamField(ref _SpEffectId0, value);
        }
        private int _SpEffectId0;

        [ParamField(0x1C, ParamType.I32)]
        public int SpEffectId1
        {
            get => _SpEffectId1;
            set => WriteParamField(ref _SpEffectId1, value);
        }
        private int _SpEffectId1;

        [ParamField(0x20, ParamType.I32)]
        public int SpEffectId2
        {
            get => _SpEffectId2;
            set => WriteParamField(ref _SpEffectId2, value);
        }
        private int _SpEffectId2;

        [ParamField(0x24, ParamType.I32)]
        public int SpEffectId3
        {
            get => _SpEffectId3;
            set => WriteParamField(ref _SpEffectId3, value);
        }
        private int _SpEffectId3;

        [ParamField(0x28, ParamType.I32)]
        public int SpEffectId4
        {
            get => _SpEffectId4;
            set => WriteParamField(ref _SpEffectId4, value);
        }
        private int _SpEffectId4;

        [ParamField(0x2C, ParamType.I16)]
        public short Hit0_DmyPoly1
        {
            get => _Hit0_DmyPoly1;
            set => WriteParamField(ref _Hit0_DmyPoly1, value);
        }
        private short _Hit0_DmyPoly1;

        [ParamField(0x2E, ParamType.I16)]
        public short Hit1_DmyPoly1
        {
            get => _Hit1_DmyPoly1;
            set => WriteParamField(ref _Hit1_DmyPoly1, value);
        }
        private short _Hit1_DmyPoly1;

        [ParamField(0x30, ParamType.I16)]
        public short Hit2_DmyPoly1
        {
            get => _Hit2_DmyPoly1;
            set => WriteParamField(ref _Hit2_DmyPoly1, value);
        }
        private short _Hit2_DmyPoly1;

        [ParamField(0x32, ParamType.I16)]
        public short Hit3_DmyPoly1
        {
            get => _Hit3_DmyPoly1;
            set => WriteParamField(ref _Hit3_DmyPoly1, value);
        }
        private short _Hit3_DmyPoly1;

        [ParamField(0x34, ParamType.I16)]
        public short Hit0_DmyPoly2
        {
            get => _Hit0_DmyPoly2;
            set => WriteParamField(ref _Hit0_DmyPoly2, value);
        }
        private short _Hit0_DmyPoly2;

        [ParamField(0x36, ParamType.I16)]
        public short Hit1_DmyPoly2
        {
            get => _Hit1_DmyPoly2;
            set => WriteParamField(ref _Hit1_DmyPoly2, value);
        }
        private short _Hit1_DmyPoly2;

        [ParamField(0x38, ParamType.I16)]
        public short Hit2_DmyPoly2
        {
            get => _Hit2_DmyPoly2;
            set => WriteParamField(ref _Hit2_DmyPoly2, value);
        }
        private short _Hit2_DmyPoly2;

        [ParamField(0x3A, ParamType.I16)]
        public short Hit3_DmyPoly2
        {
            get => _Hit3_DmyPoly2;
            set => WriteParamField(ref _Hit3_DmyPoly2, value);
        }
        private short _Hit3_DmyPoly2;

        [ParamField(0x3C, ParamType.U16)]
        public ushort BlowingCorrection
        {
            get => _BlowingCorrection;
            set => WriteParamField(ref _BlowingCorrection, value);
        }
        private ushort _BlowingCorrection;

        [ParamField(0x3E, ParamType.U16)]
        public ushort AtkPhysCorrection
        {
            get => _AtkPhysCorrection;
            set => WriteParamField(ref _AtkPhysCorrection, value);
        }
        private ushort _AtkPhysCorrection;

        [ParamField(0x40, ParamType.U16)]
        public ushort AtkMagCorrection
        {
            get => _AtkMagCorrection;
            set => WriteParamField(ref _AtkMagCorrection, value);
        }
        private ushort _AtkMagCorrection;

        [ParamField(0x42, ParamType.U16)]
        public ushort AtkFireCorrection
        {
            get => _AtkFireCorrection;
            set => WriteParamField(ref _AtkFireCorrection, value);
        }
        private ushort _AtkFireCorrection;

        [ParamField(0x44, ParamType.U16)]
        public ushort AtkThunCorrection
        {
            get => _AtkThunCorrection;
            set => WriteParamField(ref _AtkThunCorrection, value);
        }
        private ushort _AtkThunCorrection;

        [ParamField(0x46, ParamType.U16)]
        public ushort AtkStamCorrection
        {
            get => _AtkStamCorrection;
            set => WriteParamField(ref _AtkStamCorrection, value);
        }
        private ushort _AtkStamCorrection;

        [ParamField(0x48, ParamType.U16)]
        public ushort GuardAtkRateCorrection
        {
            get => _GuardAtkRateCorrection;
            set => WriteParamField(ref _GuardAtkRateCorrection, value);
        }
        private ushort _GuardAtkRateCorrection;

        [ParamField(0x4A, ParamType.U16)]
        public ushort GuardBreakCorrection
        {
            get => _GuardBreakCorrection;
            set => WriteParamField(ref _GuardBreakCorrection, value);
        }
        private ushort _GuardBreakCorrection;

        [ParamField(0x4C, ParamType.U16)]
        public ushort AtkThrowEscapeCorrection
        {
            get => _AtkThrowEscapeCorrection;
            set => WriteParamField(ref _AtkThrowEscapeCorrection, value);
        }
        private ushort _AtkThrowEscapeCorrection;

        [ParamField(0x4E, ParamType.U16)]
        public ushort AtkSuperArmorCorrection
        {
            get => _AtkSuperArmorCorrection;
            set => WriteParamField(ref _AtkSuperArmorCorrection, value);
        }
        private ushort _AtkSuperArmorCorrection;

        [ParamField(0x50, ParamType.U16)]
        public ushort AtkPhys
        {
            get => _AtkPhys;
            set => WriteParamField(ref _AtkPhys, value);
        }
        private ushort _AtkPhys;

        [ParamField(0x52, ParamType.U16)]
        public ushort AtkMag
        {
            get => _AtkMag;
            set => WriteParamField(ref _AtkMag, value);
        }
        private ushort _AtkMag;

        [ParamField(0x54, ParamType.U16)]
        public ushort AtkFire
        {
            get => _AtkFire;
            set => WriteParamField(ref _AtkFire, value);
        }
        private ushort _AtkFire;

        [ParamField(0x56, ParamType.U16)]
        public ushort AtkThun
        {
            get => _AtkThun;
            set => WriteParamField(ref _AtkThun, value);
        }
        private ushort _AtkThun;

        [ParamField(0x58, ParamType.U16)]
        public ushort AtkStam
        {
            get => _AtkStam;
            set => WriteParamField(ref _AtkStam, value);
        }
        private ushort _AtkStam;

        [ParamField(0x5A, ParamType.U16)]
        public ushort GuardAtkRate
        {
            get => _GuardAtkRate;
            set => WriteParamField(ref _GuardAtkRate, value);
        }
        private ushort _GuardAtkRate;

        [ParamField(0x5C, ParamType.U16)]
        public ushort GuardBreakRate
        {
            get => _GuardBreakRate;
            set => WriteParamField(ref _GuardBreakRate, value);
        }
        private ushort _GuardBreakRate;

        [ParamField(0x5E, ParamType.U16)]
        public ushort AtkSuperArmor
        {
            get => _AtkSuperArmor;
            set => WriteParamField(ref _AtkSuperArmor, value);
        }
        private ushort _AtkSuperArmor;

        [ParamField(0x60, ParamType.U16)]
        public ushort AtkThrowEscape
        {
            get => _AtkThrowEscape;
            set => WriteParamField(ref _AtkThrowEscape, value);
        }
        private ushort _AtkThrowEscape;

        [ParamField(0x62, ParamType.U16)]
        public ushort AtkObj
        {
            get => _AtkObj;
            set => WriteParamField(ref _AtkObj, value);
        }
        private ushort _AtkObj;

        [ParamField(0x64, ParamType.I16)]
        public short GuardStaminaCutRate
        {
            get => _GuardStaminaCutRate;
            set => WriteParamField(ref _GuardStaminaCutRate, value);
        }
        private short _GuardStaminaCutRate;

        [ParamField(0x66, ParamType.I16)]
        public short GuardRate
        {
            get => _GuardRate;
            set => WriteParamField(ref _GuardRate, value);
        }
        private short _GuardRate;

        [ParamField(0x68, ParamType.U16)]
        public ushort ThrowTypeId
        {
            get => _ThrowTypeId;
            set => WriteParamField(ref _ThrowTypeId, value);
        }
        private ushort _ThrowTypeId;

        [ParamField(0x6A, ParamType.U8)]
        public byte Hit0_hitType
        {
            get => _Hit0_hitType;
            set => WriteParamField(ref _Hit0_hitType, value);
        }
        private byte _Hit0_hitType;

        [ParamField(0x6B, ParamType.U8)]
        public byte Hit1_hitType
        {
            get => _Hit1_hitType;
            set => WriteParamField(ref _Hit1_hitType, value);
        }
        private byte _Hit1_hitType;

        [ParamField(0x6C, ParamType.U8)]
        public byte Hit2_hitType
        {
            get => _Hit2_hitType;
            set => WriteParamField(ref _Hit2_hitType, value);
        }
        private byte _Hit2_hitType;

        [ParamField(0x6D, ParamType.U8)]
        public byte Hit3_hitType
        {
            get => _Hit3_hitType;
            set => WriteParamField(ref _Hit3_hitType, value);
        }
        private byte _Hit3_hitType;

        [ParamField(0x6E, ParamType.U8)]
        public byte Hti0_Priority
        {
            get => _Hti0_Priority;
            set => WriteParamField(ref _Hti0_Priority, value);
        }
        private byte _Hti0_Priority;

        [ParamField(0x6F, ParamType.U8)]
        public byte Hti1_Priority
        {
            get => _Hti1_Priority;
            set => WriteParamField(ref _Hti1_Priority, value);
        }
        private byte _Hti1_Priority;

        [ParamField(0x70, ParamType.U8)]
        public byte Hti2_Priority
        {
            get => _Hti2_Priority;
            set => WriteParamField(ref _Hti2_Priority, value);
        }
        private byte _Hti2_Priority;

        [ParamField(0x71, ParamType.U8)]
        public byte Hti3_Priority
        {
            get => _Hti3_Priority;
            set => WriteParamField(ref _Hti3_Priority, value);
        }
        private byte _Hti3_Priority;

        [ParamField(0x72, ParamType.U8)]
        public byte DmgLevel
        {
            get => _DmgLevel;
            set => WriteParamField(ref _DmgLevel, value);
        }
        private byte _DmgLevel;

        [ParamField(0x73, ParamType.U8)]
        public byte MapHitType
        {
            get => _MapHitType;
            set => WriteParamField(ref _MapHitType, value);
        }
        private byte _MapHitType;

        [ParamField(0x74, ParamType.I8)]
        public sbyte GuardCutCancelRate
        {
            get => _GuardCutCancelRate;
            set => WriteParamField(ref _GuardCutCancelRate, value);
        }
        private sbyte _GuardCutCancelRate;

        [ParamField(0x75, ParamType.U8)]
        public byte AtkAttribute
        {
            get => _AtkAttribute;
            set => WriteParamField(ref _AtkAttribute, value);
        }
        private byte _AtkAttribute;

        [ParamField(0x76, ParamType.U8)]
        public byte SpAttribute
        {
            get => _SpAttribute;
            set => WriteParamField(ref _SpAttribute, value);
        }
        private byte _SpAttribute;

        [ParamField(0x77, ParamType.U8)]
        public byte AtkType
        {
            get => _AtkType;
            set => WriteParamField(ref _AtkType, value);
        }
        private byte _AtkType;

        [ParamField(0x78, ParamType.U8)]
        public byte AtkMaterial
        {
            get => _AtkMaterial;
            set => WriteParamField(ref _AtkMaterial, value);
        }
        private byte _AtkMaterial;

        [ParamField(0x79, ParamType.U8)]
        public byte AtkSize
        {
            get => _AtkSize;
            set => WriteParamField(ref _AtkSize, value);
        }
        private byte _AtkSize;

        [ParamField(0x7A, ParamType.U8)]
        public byte DefMaterial
        {
            get => _DefMaterial;
            set => WriteParamField(ref _DefMaterial, value);
        }
        private byte _DefMaterial;

        [ParamField(0x7B, ParamType.U8)]
        public byte DefSfxMaterial
        {
            get => _DefSfxMaterial;
            set => WriteParamField(ref _DefSfxMaterial, value);
        }
        private byte _DefSfxMaterial;

        [ParamField(0x7C, ParamType.U8)]
        public byte HitSourceType
        {
            get => _HitSourceType;
            set => WriteParamField(ref _HitSourceType, value);
        }
        private byte _HitSourceType;

        [ParamField(0x7D, ParamType.U8)]
        public byte ThrowFlag
        {
            get => _ThrowFlag;
            set => WriteParamField(ref _ThrowFlag, value);
        }
        private byte _ThrowFlag;

        #region BitField DisableGuardBitfield ==============================================================================

        [ParamField(0x7E, ParamType.U8)]
        public byte DisableGuardBitfield
        {
            get => _DisableGuardBitfield;
            set => WriteParamField(ref _DisableGuardBitfield, value);
        }
        private byte _DisableGuardBitfield;

        [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 0)]
        public byte DisableGuard
        {
            get => GetbitfieldValue(_DisableGuardBitfield);
            set => SetBitfieldValue(ref _DisableGuardBitfield, value);
        }

        [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 1)]
        public byte DisableStaminaAttack
        {
            get => GetbitfieldValue(_DisableGuardBitfield);
            set => SetBitfieldValue(ref _DisableGuardBitfield, value);
        }

        [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 2)]
        public byte DisableHitSpEffect
        {
            get => GetbitfieldValue(_DisableGuardBitfield);
            set => SetBitfieldValue(ref _DisableGuardBitfield, value);
        }

        [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 3)]
        public byte IgnoreNotifyMissSwingForAI
        {
            get => GetbitfieldValue(_DisableGuardBitfield);
            set => SetBitfieldValue(ref _DisableGuardBitfield, value);
        }

        [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 4)]
        public byte RepeatHitSfx
        {
            get => GetbitfieldValue(_DisableGuardBitfield);
            set => SetBitfieldValue(ref _DisableGuardBitfield, value);
        }

        [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 5)]
        public byte IsArrowAtk
        {
            get => GetbitfieldValue(_DisableGuardBitfield);
            set => SetBitfieldValue(ref _DisableGuardBitfield, value);
        }

        [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 6)]
        public byte IsGhostAtk
        {
            get => GetbitfieldValue(_DisableGuardBitfield);
            set => SetBitfieldValue(ref _DisableGuardBitfield, value);
        }

        [ParamBitField(nameof(DisableGuardBitfield), bits: 1, bitsOffset: 7)]
        public byte IsDisableNoDamage
        {
            get => GetbitfieldValue(_DisableGuardBitfield);
            set => SetBitfieldValue(ref _DisableGuardBitfield, value);
        }

        #endregion BitField DisableGuardBitfield

        [ParamField(0x7F, ParamType.Dummy8, 1)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad = null!;

    }
}
