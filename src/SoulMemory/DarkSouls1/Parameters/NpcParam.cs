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
    public class NpcParam : BaseParam
    {
        public NpcParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I32)]
        public int BehaviorVariationId
        {
            get => _BehaviorVariationId;
            set => WriteParamField(ref _BehaviorVariationId, value);
        }
        private int _BehaviorVariationId;

        [ParamField(0x4, ParamType.I32)]
        public int AiThinkId
        {
            get => _AiThinkId;
            set => WriteParamField(ref _AiThinkId, value);
        }
        private int _AiThinkId;

        [ParamField(0x8, ParamType.I32)]
        public int NameId
        {
            get => _NameId;
            set => WriteParamField(ref _NameId, value);
        }
        private int _NameId;

        [ParamField(0xC, ParamType.F32)]
        public float TurnVellocity
        {
            get => _TurnVellocity;
            set => WriteParamField(ref _TurnVellocity, value);
        }
        private float _TurnVellocity;

        [ParamField(0x10, ParamType.F32)]
        public float HitHeight
        {
            get => _HitHeight;
            set => WriteParamField(ref _HitHeight, value);
        }
        private float _HitHeight;

        [ParamField(0x14, ParamType.F32)]
        public float HitRadius
        {
            get => _HitRadius;
            set => WriteParamField(ref _HitRadius, value);
        }
        private float _HitRadius;

        [ParamField(0x18, ParamType.U32)]
        public uint Weight
        {
            get => _Weight;
            set => WriteParamField(ref _Weight, value);
        }
        private uint _Weight;

        [ParamField(0x1C, ParamType.F32)]
        public float HitYOffset
        {
            get => _HitYOffset;
            set => WriteParamField(ref _HitYOffset, value);
        }
        private float _HitYOffset;

        [ParamField(0x20, ParamType.U32)]
        public uint Hp
        {
            get => _Hp;
            set => WriteParamField(ref _Hp, value);
        }
        private uint _Hp;

        [ParamField(0x24, ParamType.U32)]
        public uint Mp
        {
            get => _Mp;
            set => WriteParamField(ref _Mp, value);
        }
        private uint _Mp;

        [ParamField(0x28, ParamType.U32)]
        public uint GetSoul
        {
            get => _GetSoul;
            set => WriteParamField(ref _GetSoul, value);
        }
        private uint _GetSoul;

        [ParamField(0x2C, ParamType.I32)]
        public int ItemLotId_1
        {
            get => _ItemLotId_1;
            set => WriteParamField(ref _ItemLotId_1, value);
        }
        private int _ItemLotId_1;

        [ParamField(0x30, ParamType.I32)]
        public int ItemLotId_2
        {
            get => _ItemLotId_2;
            set => WriteParamField(ref _ItemLotId_2, value);
        }
        private int _ItemLotId_2;

        [ParamField(0x34, ParamType.I32)]
        public int ItemLotId_3
        {
            get => _ItemLotId_3;
            set => WriteParamField(ref _ItemLotId_3, value);
        }
        private int _ItemLotId_3;

        [ParamField(0x38, ParamType.I32)]
        public int ItemLotId_4
        {
            get => _ItemLotId_4;
            set => WriteParamField(ref _ItemLotId_4, value);
        }
        private int _ItemLotId_4;

        [ParamField(0x3C, ParamType.I32)]
        public int ItemLotId_5
        {
            get => _ItemLotId_5;
            set => WriteParamField(ref _ItemLotId_5, value);
        }
        private int _ItemLotId_5;

        [ParamField(0x40, ParamType.I32)]
        public int ItemLotId_6
        {
            get => _ItemLotId_6;
            set => WriteParamField(ref _ItemLotId_6, value);
        }
        private int _ItemLotId_6;

        [ParamField(0x44, ParamType.I32)]
        public int HumanityLotId
        {
            get => _HumanityLotId;
            set => WriteParamField(ref _HumanityLotId, value);
        }
        private int _HumanityLotId;

        [ParamField(0x48, ParamType.I32)]
        public int SpEffectID0
        {
            get => _SpEffectID0;
            set => WriteParamField(ref _SpEffectID0, value);
        }
        private int _SpEffectID0;

        [ParamField(0x4C, ParamType.I32)]
        public int SpEffectID1
        {
            get => _SpEffectID1;
            set => WriteParamField(ref _SpEffectID1, value);
        }
        private int _SpEffectID1;

        [ParamField(0x50, ParamType.I32)]
        public int SpEffectID2
        {
            get => _SpEffectID2;
            set => WriteParamField(ref _SpEffectID2, value);
        }
        private int _SpEffectID2;

        [ParamField(0x54, ParamType.I32)]
        public int SpEffectID3
        {
            get => _SpEffectID3;
            set => WriteParamField(ref _SpEffectID3, value);
        }
        private int _SpEffectID3;

        [ParamField(0x58, ParamType.I32)]
        public int SpEffectID4
        {
            get => _SpEffectID4;
            set => WriteParamField(ref _SpEffectID4, value);
        }
        private int _SpEffectID4;

        [ParamField(0x5C, ParamType.I32)]
        public int SpEffectID5
        {
            get => _SpEffectID5;
            set => WriteParamField(ref _SpEffectID5, value);
        }
        private int _SpEffectID5;

        [ParamField(0x60, ParamType.I32)]
        public int SpEffectID6
        {
            get => _SpEffectID6;
            set => WriteParamField(ref _SpEffectID6, value);
        }
        private int _SpEffectID6;

        [ParamField(0x64, ParamType.I32)]
        public int SpEffectID7
        {
            get => _SpEffectID7;
            set => WriteParamField(ref _SpEffectID7, value);
        }
        private int _SpEffectID7;

        [ParamField(0x68, ParamType.I32)]
        public int GameClearSpEffectID
        {
            get => _GameClearSpEffectID;
            set => WriteParamField(ref _GameClearSpEffectID, value);
        }
        private int _GameClearSpEffectID;

        [ParamField(0x6C, ParamType.F32)]
        public float PhysGuardCutRate
        {
            get => _PhysGuardCutRate;
            set => WriteParamField(ref _PhysGuardCutRate, value);
        }
        private float _PhysGuardCutRate;

        [ParamField(0x70, ParamType.F32)]
        public float MagGuardCutRate
        {
            get => _MagGuardCutRate;
            set => WriteParamField(ref _MagGuardCutRate, value);
        }
        private float _MagGuardCutRate;

        [ParamField(0x74, ParamType.F32)]
        public float FireGuardCutRate
        {
            get => _FireGuardCutRate;
            set => WriteParamField(ref _FireGuardCutRate, value);
        }
        private float _FireGuardCutRate;

        [ParamField(0x78, ParamType.F32)]
        public float ThunGuardCutRate
        {
            get => _ThunGuardCutRate;
            set => WriteParamField(ref _ThunGuardCutRate, value);
        }
        private float _ThunGuardCutRate;

        [ParamField(0x7C, ParamType.I32)]
        public int AnimIdOffset
        {
            get => _AnimIdOffset;
            set => WriteParamField(ref _AnimIdOffset, value);
        }
        private int _AnimIdOffset;

        [ParamField(0x80, ParamType.I32)]
        public int MoveAnimId
        {
            get => _MoveAnimId;
            set => WriteParamField(ref _MoveAnimId, value);
        }
        private int _MoveAnimId;

        [ParamField(0x84, ParamType.I32)]
        public int SpMoveAnimId1
        {
            get => _SpMoveAnimId1;
            set => WriteParamField(ref _SpMoveAnimId1, value);
        }
        private int _SpMoveAnimId1;

        [ParamField(0x88, ParamType.I32)]
        public int SpMoveAnimId2
        {
            get => _SpMoveAnimId2;
            set => WriteParamField(ref _SpMoveAnimId2, value);
        }
        private int _SpMoveAnimId2;

        [ParamField(0x8C, ParamType.F32)]
        public float NetworkWarpDist
        {
            get => _NetworkWarpDist;
            set => WriteParamField(ref _NetworkWarpDist, value);
        }
        private float _NetworkWarpDist;

        [ParamField(0x90, ParamType.I32)]
        public int DbgBehaviorR1
        {
            get => _DbgBehaviorR1;
            set => WriteParamField(ref _DbgBehaviorR1, value);
        }
        private int _DbgBehaviorR1;

        [ParamField(0x94, ParamType.I32)]
        public int DbgBehaviorL1
        {
            get => _DbgBehaviorL1;
            set => WriteParamField(ref _DbgBehaviorL1, value);
        }
        private int _DbgBehaviorL1;

        [ParamField(0x98, ParamType.I32)]
        public int DbgBehaviorR2
        {
            get => _DbgBehaviorR2;
            set => WriteParamField(ref _DbgBehaviorR2, value);
        }
        private int _DbgBehaviorR2;

        [ParamField(0x9C, ParamType.I32)]
        public int DbgBehaviorL2
        {
            get => _DbgBehaviorL2;
            set => WriteParamField(ref _DbgBehaviorL2, value);
        }
        private int _DbgBehaviorL2;

        [ParamField(0xA0, ParamType.I32)]
        public int DbgBehaviorRL
        {
            get => _DbgBehaviorRL;
            set => WriteParamField(ref _DbgBehaviorRL, value);
        }
        private int _DbgBehaviorRL;

        [ParamField(0xA4, ParamType.I32)]
        public int DbgBehaviorRR
        {
            get => _DbgBehaviorRR;
            set => WriteParamField(ref _DbgBehaviorRR, value);
        }
        private int _DbgBehaviorRR;

        [ParamField(0xA8, ParamType.I32)]
        public int DbgBehaviorRD
        {
            get => _DbgBehaviorRD;
            set => WriteParamField(ref _DbgBehaviorRD, value);
        }
        private int _DbgBehaviorRD;

        [ParamField(0xAC, ParamType.I32)]
        public int DbgBehaviorRU
        {
            get => _DbgBehaviorRU;
            set => WriteParamField(ref _DbgBehaviorRU, value);
        }
        private int _DbgBehaviorRU;

        [ParamField(0xB0, ParamType.I32)]
        public int DbgBehaviorLL
        {
            get => _DbgBehaviorLL;
            set => WriteParamField(ref _DbgBehaviorLL, value);
        }
        private int _DbgBehaviorLL;

        [ParamField(0xB4, ParamType.I32)]
        public int DbgBehaviorLR
        {
            get => _DbgBehaviorLR;
            set => WriteParamField(ref _DbgBehaviorLR, value);
        }
        private int _DbgBehaviorLR;

        [ParamField(0xB8, ParamType.I32)]
        public int DbgBehaviorLD
        {
            get => _DbgBehaviorLD;
            set => WriteParamField(ref _DbgBehaviorLD, value);
        }
        private int _DbgBehaviorLD;

        [ParamField(0xBC, ParamType.I32)]
        public int DbgBehaviorLU
        {
            get => _DbgBehaviorLU;
            set => WriteParamField(ref _DbgBehaviorLU, value);
        }
        private int _DbgBehaviorLU;

        [ParamField(0xC0, ParamType.I32)]
        public int AnimIdOffset2
        {
            get => _AnimIdOffset2;
            set => WriteParamField(ref _AnimIdOffset2, value);
        }
        private int _AnimIdOffset2;

        [ParamField(0xC4, ParamType.F32)]
        public float PartsDamageRate1
        {
            get => _PartsDamageRate1;
            set => WriteParamField(ref _PartsDamageRate1, value);
        }
        private float _PartsDamageRate1;

        [ParamField(0xC8, ParamType.F32)]
        public float PartsDamageRate2
        {
            get => _PartsDamageRate2;
            set => WriteParamField(ref _PartsDamageRate2, value);
        }
        private float _PartsDamageRate2;

        [ParamField(0xCC, ParamType.F32)]
        public float PartsDamageRate3
        {
            get => _PartsDamageRate3;
            set => WriteParamField(ref _PartsDamageRate3, value);
        }
        private float _PartsDamageRate3;

        [ParamField(0xD0, ParamType.F32)]
        public float PartsDamageRate4
        {
            get => _PartsDamageRate4;
            set => WriteParamField(ref _PartsDamageRate4, value);
        }
        private float _PartsDamageRate4;

        [ParamField(0xD4, ParamType.F32)]
        public float PartsDamageRate5
        {
            get => _PartsDamageRate5;
            set => WriteParamField(ref _PartsDamageRate5, value);
        }
        private float _PartsDamageRate5;

        [ParamField(0xD8, ParamType.F32)]
        public float PartsDamageRate6
        {
            get => _PartsDamageRate6;
            set => WriteParamField(ref _PartsDamageRate6, value);
        }
        private float _PartsDamageRate6;

        [ParamField(0xDC, ParamType.F32)]
        public float PartsDamageRate7
        {
            get => _PartsDamageRate7;
            set => WriteParamField(ref _PartsDamageRate7, value);
        }
        private float _PartsDamageRate7;

        [ParamField(0xE0, ParamType.F32)]
        public float PartsDamageRate8
        {
            get => _PartsDamageRate8;
            set => WriteParamField(ref _PartsDamageRate8, value);
        }
        private float _PartsDamageRate8;

        [ParamField(0xE4, ParamType.F32)]
        public float WeakPartsDamageRate
        {
            get => _WeakPartsDamageRate;
            set => WriteParamField(ref _WeakPartsDamageRate, value);
        }
        private float _WeakPartsDamageRate;

        [ParamField(0xE8, ParamType.F32)]
        public float SuperArmorRecoverCorrection
        {
            get => _SuperArmorRecoverCorrection;
            set => WriteParamField(ref _SuperArmorRecoverCorrection, value);
        }
        private float _SuperArmorRecoverCorrection;

        [ParamField(0xEC, ParamType.F32)]
        public float SuperArmorBrakeKnockbackDist
        {
            get => _SuperArmorBrakeKnockbackDist;
            set => WriteParamField(ref _SuperArmorBrakeKnockbackDist, value);
        }
        private float _SuperArmorBrakeKnockbackDist;

        [ParamField(0xF0, ParamType.U16)]
        public ushort Stamina
        {
            get => _Stamina;
            set => WriteParamField(ref _Stamina, value);
        }
        private ushort _Stamina;

        [ParamField(0xF2, ParamType.U16)]
        public ushort StaminaRecoverBaseVel
        {
            get => _StaminaRecoverBaseVel;
            set => WriteParamField(ref _StaminaRecoverBaseVel, value);
        }
        private ushort _StaminaRecoverBaseVel;

        [ParamField(0xF4, ParamType.U16)]
        public ushort Def_phys
        {
            get => _Def_phys;
            set => WriteParamField(ref _Def_phys, value);
        }
        private ushort _Def_phys;

        [ParamField(0xF6, ParamType.I16)]
        public short Def_slash
        {
            get => _Def_slash;
            set => WriteParamField(ref _Def_slash, value);
        }
        private short _Def_slash;

        [ParamField(0xF8, ParamType.I16)]
        public short Def_blow
        {
            get => _Def_blow;
            set => WriteParamField(ref _Def_blow, value);
        }
        private short _Def_blow;

        [ParamField(0xFA, ParamType.I16)]
        public short Def_thrust
        {
            get => _Def_thrust;
            set => WriteParamField(ref _Def_thrust, value);
        }
        private short _Def_thrust;

        [ParamField(0xFC, ParamType.U16)]
        public ushort Def_mag
        {
            get => _Def_mag;
            set => WriteParamField(ref _Def_mag, value);
        }
        private ushort _Def_mag;

        [ParamField(0xFE, ParamType.U16)]
        public ushort Def_fire
        {
            get => _Def_fire;
            set => WriteParamField(ref _Def_fire, value);
        }
        private ushort _Def_fire;

        [ParamField(0x100, ParamType.U16)]
        public ushort Def_thunder
        {
            get => _Def_thunder;
            set => WriteParamField(ref _Def_thunder, value);
        }
        private ushort _Def_thunder;

        [ParamField(0x102, ParamType.U16)]
        public ushort DefFlickPower
        {
            get => _DefFlickPower;
            set => WriteParamField(ref _DefFlickPower, value);
        }
        private ushort _DefFlickPower;

        [ParamField(0x104, ParamType.U16)]
        public ushort Resist_poison
        {
            get => _Resist_poison;
            set => WriteParamField(ref _Resist_poison, value);
        }
        private ushort _Resist_poison;

        [ParamField(0x106, ParamType.U16)]
        public ushort Resist_desease
        {
            get => _Resist_desease;
            set => WriteParamField(ref _Resist_desease, value);
        }
        private ushort _Resist_desease;

        [ParamField(0x108, ParamType.U16)]
        public ushort Resist_blood
        {
            get => _Resist_blood;
            set => WriteParamField(ref _Resist_blood, value);
        }
        private ushort _Resist_blood;

        [ParamField(0x10A, ParamType.U16)]
        public ushort Resist_curse
        {
            get => _Resist_curse;
            set => WriteParamField(ref _Resist_curse, value);
        }
        private ushort _Resist_curse;

        [ParamField(0x10C, ParamType.I16)]
        public short GhostModelId
        {
            get => _GhostModelId;
            set => WriteParamField(ref _GhostModelId, value);
        }
        private short _GhostModelId;

        [ParamField(0x10E, ParamType.I16)]
        public short NormalChangeResouceId
        {
            get => _NormalChangeResouceId;
            set => WriteParamField(ref _NormalChangeResouceId, value);
        }
        private short _NormalChangeResouceId;

        [ParamField(0x110, ParamType.I16)]
        public short GuardAngle
        {
            get => _GuardAngle;
            set => WriteParamField(ref _GuardAngle, value);
        }
        private short _GuardAngle;

        [ParamField(0x112, ParamType.I16)]
        public short SlashGuardCutRate
        {
            get => _SlashGuardCutRate;
            set => WriteParamField(ref _SlashGuardCutRate, value);
        }
        private short _SlashGuardCutRate;

        [ParamField(0x114, ParamType.I16)]
        public short BlowGuardCutRate
        {
            get => _BlowGuardCutRate;
            set => WriteParamField(ref _BlowGuardCutRate, value);
        }
        private short _BlowGuardCutRate;

        [ParamField(0x116, ParamType.I16)]
        public short ThrustGuardCutRate
        {
            get => _ThrustGuardCutRate;
            set => WriteParamField(ref _ThrustGuardCutRate, value);
        }
        private short _ThrustGuardCutRate;

        [ParamField(0x118, ParamType.I16)]
        public short SuperArmorDurability
        {
            get => _SuperArmorDurability;
            set => WriteParamField(ref _SuperArmorDurability, value);
        }
        private short _SuperArmorDurability;

        [ParamField(0x11A, ParamType.I16)]
        public short NormalChangeTexChrId
        {
            get => _NormalChangeTexChrId;
            set => WriteParamField(ref _NormalChangeTexChrId, value);
        }
        private short _NormalChangeTexChrId;

        [ParamField(0x11C, ParamType.U16)]
        public ushort DropType
        {
            get => _DropType;
            set => WriteParamField(ref _DropType, value);
        }
        private ushort _DropType;

        [ParamField(0x11E, ParamType.U8)]
        public byte KnockbackRate
        {
            get => _KnockbackRate;
            set => WriteParamField(ref _KnockbackRate, value);
        }
        private byte _KnockbackRate;

        [ParamField(0x11F, ParamType.U8)]
        public byte KnockbackParamId
        {
            get => _KnockbackParamId;
            set => WriteParamField(ref _KnockbackParamId, value);
        }
        private byte _KnockbackParamId;

        [ParamField(0x120, ParamType.U8)]
        public byte FallDamageDump
        {
            get => _FallDamageDump;
            set => WriteParamField(ref _FallDamageDump, value);
        }
        private byte _FallDamageDump;

        [ParamField(0x121, ParamType.U8)]
        public byte StaminaGuardDef
        {
            get => _StaminaGuardDef;
            set => WriteParamField(ref _StaminaGuardDef, value);
        }
        private byte _StaminaGuardDef;

        [ParamField(0x122, ParamType.U8)]
        public byte PcAttrB
        {
            get => _PcAttrB;
            set => WriteParamField(ref _PcAttrB, value);
        }
        private byte _PcAttrB;

        [ParamField(0x123, ParamType.U8)]
        public byte PcAttrW
        {
            get => _PcAttrW;
            set => WriteParamField(ref _PcAttrW, value);
        }
        private byte _PcAttrW;

        [ParamField(0x124, ParamType.U8)]
        public byte PcAttrL
        {
            get => _PcAttrL;
            set => WriteParamField(ref _PcAttrL, value);
        }
        private byte _PcAttrL;

        [ParamField(0x125, ParamType.U8)]
        public byte PcAttrR
        {
            get => _PcAttrR;
            set => WriteParamField(ref _PcAttrR, value);
        }
        private byte _PcAttrR;

        [ParamField(0x126, ParamType.U8)]
        public byte AreaAttrB
        {
            get => _AreaAttrB;
            set => WriteParamField(ref _AreaAttrB, value);
        }
        private byte _AreaAttrB;

        [ParamField(0x127, ParamType.U8)]
        public byte AreaAttrW
        {
            get => _AreaAttrW;
            set => WriteParamField(ref _AreaAttrW, value);
        }
        private byte _AreaAttrW;

        [ParamField(0x128, ParamType.U8)]
        public byte AreaAttrL
        {
            get => _AreaAttrL;
            set => WriteParamField(ref _AreaAttrL, value);
        }
        private byte _AreaAttrL;

        [ParamField(0x129, ParamType.U8)]
        public byte AreaAttrR
        {
            get => _AreaAttrR;
            set => WriteParamField(ref _AreaAttrR, value);
        }
        private byte _AreaAttrR;

        [ParamField(0x12A, ParamType.U8)]
        public byte MpRecoverBaseVel
        {
            get => _MpRecoverBaseVel;
            set => WriteParamField(ref _MpRecoverBaseVel, value);
        }
        private byte _MpRecoverBaseVel;

        [ParamField(0x12B, ParamType.U8)]
        public byte FlickDamageCutRate
        {
            get => _FlickDamageCutRate;
            set => WriteParamField(ref _FlickDamageCutRate, value);
        }
        private byte _FlickDamageCutRate;

        [ParamField(0x12C, ParamType.I8)]
        public sbyte DefaultLodParamId
        {
            get => _DefaultLodParamId;
            set => WriteParamField(ref _DefaultLodParamId, value);
        }
        private sbyte _DefaultLodParamId;

        [ParamField(0x12D, ParamType.U8)]
        public byte DrawType
        {
            get => _DrawType;
            set => WriteParamField(ref _DrawType, value);
        }
        private byte _DrawType;

        [ParamField(0x12E, ParamType.U8)]
        public byte NpcType
        {
            get => _NpcType;
            set => WriteParamField(ref _NpcType, value);
        }
        private byte _NpcType;

        [ParamField(0x12F, ParamType.U8)]
        public byte TeamType
        {
            get => _TeamType;
            set => WriteParamField(ref _TeamType, value);
        }
        private byte _TeamType;

        [ParamField(0x130, ParamType.U8)]
        public byte MoveType
        {
            get => _MoveType;
            set => WriteParamField(ref _MoveType, value);
        }
        private byte _MoveType;

        [ParamField(0x131, ParamType.U8)]
        public byte LockDist
        {
            get => _LockDist;
            set => WriteParamField(ref _LockDist, value);
        }
        private byte _LockDist;

        [ParamField(0x132, ParamType.U8)]
        public byte Material
        {
            get => _Material;
            set => WriteParamField(ref _Material, value);
        }
        private byte _Material;

        [ParamField(0x133, ParamType.U8)]
        public byte MaterialSfx
        {
            get => _MaterialSfx;
            set => WriteParamField(ref _MaterialSfx, value);
        }
        private byte _MaterialSfx;

        [ParamField(0x134, ParamType.U8)]
        public byte Material_Weak
        {
            get => _Material_Weak;
            set => WriteParamField(ref _Material_Weak, value);
        }
        private byte _Material_Weak;

        [ParamField(0x135, ParamType.U8)]
        public byte MaterialSfx_Weak
        {
            get => _MaterialSfx_Weak;
            set => WriteParamField(ref _MaterialSfx_Weak, value);
        }
        private byte _MaterialSfx_Weak;

        [ParamField(0x136, ParamType.U8)]
        public byte PartsDamageType
        {
            get => _PartsDamageType;
            set => WriteParamField(ref _PartsDamageType, value);
        }
        private byte _PartsDamageType;

        [ParamField(0x137, ParamType.U8)]
        public byte MaxUndurationAng
        {
            get => _MaxUndurationAng;
            set => WriteParamField(ref _MaxUndurationAng, value);
        }
        private byte _MaxUndurationAng;

        [ParamField(0x138, ParamType.I8)]
        public sbyte GuardLevel
        {
            get => _GuardLevel;
            set => WriteParamField(ref _GuardLevel, value);
        }
        private sbyte _GuardLevel;

        [ParamField(0x139, ParamType.U8)]
        public byte BurnSfxType
        {
            get => _BurnSfxType;
            set => WriteParamField(ref _BurnSfxType, value);
        }
        private byte _BurnSfxType;

        [ParamField(0x13A, ParamType.I8)]
        public sbyte PoisonGuardResist
        {
            get => _PoisonGuardResist;
            set => WriteParamField(ref _PoisonGuardResist, value);
        }
        private sbyte _PoisonGuardResist;

        [ParamField(0x13B, ParamType.I8)]
        public sbyte DiseaseGuardResist
        {
            get => _DiseaseGuardResist;
            set => WriteParamField(ref _DiseaseGuardResist, value);
        }
        private sbyte _DiseaseGuardResist;

        [ParamField(0x13C, ParamType.I8)]
        public sbyte BloodGuardResist
        {
            get => _BloodGuardResist;
            set => WriteParamField(ref _BloodGuardResist, value);
        }
        private sbyte _BloodGuardResist;

        [ParamField(0x13D, ParamType.I8)]
        public sbyte CurseGuardResist
        {
            get => _CurseGuardResist;
            set => WriteParamField(ref _CurseGuardResist, value);
        }
        private sbyte _CurseGuardResist;

        [ParamField(0x13E, ParamType.U8)]
        public byte ParryAttack
        {
            get => _ParryAttack;
            set => WriteParamField(ref _ParryAttack, value);
        }
        private byte _ParryAttack;

        [ParamField(0x13F, ParamType.U8)]
        public byte ParryDefence
        {
            get => _ParryDefence;
            set => WriteParamField(ref _ParryDefence, value);
        }
        private byte _ParryDefence;

        [ParamField(0x140, ParamType.U8)]
        public byte SfxSize
        {
            get => _SfxSize;
            set => WriteParamField(ref _SfxSize, value);
        }
        private byte _SfxSize;

        [ParamField(0x141, ParamType.U8)]
        public byte PushOutCamRegionRadius
        {
            get => _PushOutCamRegionRadius;
            set => WriteParamField(ref _PushOutCamRegionRadius, value);
        }
        private byte _PushOutCamRegionRadius;

        [ParamField(0x142, ParamType.U8)]
        public byte HitStopType
        {
            get => _HitStopType;
            set => WriteParamField(ref _HitStopType, value);
        }
        private byte _HitStopType;

        [ParamField(0x143, ParamType.U8)]
        public byte LadderEndChkOffsetTop
        {
            get => _LadderEndChkOffsetTop;
            set => WriteParamField(ref _LadderEndChkOffsetTop, value);
        }
        private byte _LadderEndChkOffsetTop;

        [ParamField(0x144, ParamType.U8)]
        public byte LadderEndChkOffsetLow
        {
            get => _LadderEndChkOffsetLow;
            set => WriteParamField(ref _LadderEndChkOffsetLow, value);
        }
        private byte _LadderEndChkOffsetLow;

        #region BitField UseRagdollCamHitBitfield ==============================================================================

        [ParamField(0x145, ParamType.U8)]
        public byte UseRagdollCamHitBitfield
        {
            get => _UseRagdollCamHitBitfield;
            set => WriteParamField(ref _UseRagdollCamHitBitfield, value);
        }
        private byte _UseRagdollCamHitBitfield;

        [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 0)]
        public byte UseRagdollCamHit
        {
            get => GetbitfieldValue(_UseRagdollCamHitBitfield);
            set => SetBitfieldValue(ref _UseRagdollCamHitBitfield, value);
        }

        [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 1)]
        public byte DisableClothRigidHit
        {
            get => GetbitfieldValue(_UseRagdollCamHitBitfield);
            set => SetBitfieldValue(ref _UseRagdollCamHitBitfield, value);
        }

        [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 2)]
        public byte UseRagdoll
        {
            get => GetbitfieldValue(_UseRagdollCamHitBitfield);
            set => SetBitfieldValue(ref _UseRagdollCamHitBitfield, value);
        }

        [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 3)]
        public byte IsDemon
        {
            get => GetbitfieldValue(_UseRagdollCamHitBitfield);
            set => SetBitfieldValue(ref _UseRagdollCamHitBitfield, value);
        }

        [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 4)]
        public byte IsGhost
        {
            get => GetbitfieldValue(_UseRagdollCamHitBitfield);
            set => SetBitfieldValue(ref _UseRagdollCamHitBitfield, value);
        }

        [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 5)]
        public byte IsNoDamageMotion
        {
            get => GetbitfieldValue(_UseRagdollCamHitBitfield);
            set => SetBitfieldValue(ref _UseRagdollCamHitBitfield, value);
        }

        [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 6)]
        public byte IsUnduration
        {
            get => GetbitfieldValue(_UseRagdollCamHitBitfield);
            set => SetBitfieldValue(ref _UseRagdollCamHitBitfield, value);
        }

        [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 7)]
        public byte IsChangeWanderGhost
        {
            get => GetbitfieldValue(_UseRagdollCamHitBitfield);
            set => SetBitfieldValue(ref _UseRagdollCamHitBitfield, value);
        }

        #endregion BitField UseRagdollCamHitBitfield

        #region BitField ModelDispMask0Bitfield ==============================================================================

        [ParamField(0x146, ParamType.U8)]
        public byte ModelDispMask0Bitfield
        {
            get => _ModelDispMask0Bitfield;
            set => WriteParamField(ref _ModelDispMask0Bitfield, value);
        }
        private byte _ModelDispMask0Bitfield;

        [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 0)]
        public byte ModelDispMask0
        {
            get => GetbitfieldValue(_ModelDispMask0Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask0Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 1)]
        public byte ModelDispMask1
        {
            get => GetbitfieldValue(_ModelDispMask0Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask0Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 2)]
        public byte ModelDispMask2
        {
            get => GetbitfieldValue(_ModelDispMask0Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask0Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 3)]
        public byte ModelDispMask3
        {
            get => GetbitfieldValue(_ModelDispMask0Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask0Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 4)]
        public byte ModelDispMask4
        {
            get => GetbitfieldValue(_ModelDispMask0Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask0Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 5)]
        public byte ModelDispMask5
        {
            get => GetbitfieldValue(_ModelDispMask0Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask0Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 6)]
        public byte ModelDispMask6
        {
            get => GetbitfieldValue(_ModelDispMask0Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask0Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 7)]
        public byte ModelDispMask7
        {
            get => GetbitfieldValue(_ModelDispMask0Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask0Bitfield, value);
        }

        #endregion BitField ModelDispMask0Bitfield

        #region BitField ModelDispMask8Bitfield ==============================================================================

        [ParamField(0x147, ParamType.U8)]
        public byte ModelDispMask8Bitfield
        {
            get => _ModelDispMask8Bitfield;
            set => WriteParamField(ref _ModelDispMask8Bitfield, value);
        }
        private byte _ModelDispMask8Bitfield;

        [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 0)]
        public byte ModelDispMask8
        {
            get => GetbitfieldValue(_ModelDispMask8Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask8Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 1)]
        public byte ModelDispMask9
        {
            get => GetbitfieldValue(_ModelDispMask8Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask8Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 2)]
        public byte ModelDispMask10
        {
            get => GetbitfieldValue(_ModelDispMask8Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask8Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 3)]
        public byte ModelDispMask11
        {
            get => GetbitfieldValue(_ModelDispMask8Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask8Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 4)]
        public byte ModelDispMask12
        {
            get => GetbitfieldValue(_ModelDispMask8Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask8Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 5)]
        public byte ModelDispMask13
        {
            get => GetbitfieldValue(_ModelDispMask8Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask8Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 6)]
        public byte ModelDispMask14
        {
            get => GetbitfieldValue(_ModelDispMask8Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask8Bitfield, value);
        }

        [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 7)]
        public byte ModelDispMask15
        {
            get => GetbitfieldValue(_ModelDispMask8Bitfield);
            set => SetBitfieldValue(ref _ModelDispMask8Bitfield, value);
        }

        #endregion BitField ModelDispMask8Bitfield

        #region BitField IsEnableNeckTurnBitfield ==============================================================================

        [ParamField(0x148, ParamType.U8)]
        public byte IsEnableNeckTurnBitfield
        {
            get => _IsEnableNeckTurnBitfield;
            set => WriteParamField(ref _IsEnableNeckTurnBitfield, value);
        }
        private byte _IsEnableNeckTurnBitfield;

        [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 0)]
        public byte IsEnableNeckTurn
        {
            get => GetbitfieldValue(_IsEnableNeckTurnBitfield);
            set => SetBitfieldValue(ref _IsEnableNeckTurnBitfield, value);
        }

        [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 1)]
        public byte DisableRespawn
        {
            get => GetbitfieldValue(_IsEnableNeckTurnBitfield);
            set => SetBitfieldValue(ref _IsEnableNeckTurnBitfield, value);
        }

        [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 2)]
        public byte IsMoveAnimWait
        {
            get => GetbitfieldValue(_IsEnableNeckTurnBitfield);
            set => SetBitfieldValue(ref _IsEnableNeckTurnBitfield, value);
        }

        [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 3)]
        public byte IsCrowd
        {
            get => GetbitfieldValue(_IsEnableNeckTurnBitfield);
            set => SetBitfieldValue(ref _IsEnableNeckTurnBitfield, value);
        }

        [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 4)]
        public byte IsWeakSaint
        {
            get => GetbitfieldValue(_IsEnableNeckTurnBitfield);
            set => SetBitfieldValue(ref _IsEnableNeckTurnBitfield, value);
        }

        [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 5)]
        public byte IsWeakA
        {
            get => GetbitfieldValue(_IsEnableNeckTurnBitfield);
            set => SetBitfieldValue(ref _IsEnableNeckTurnBitfield, value);
        }

        [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 6)]
        public byte IsWeakB
        {
            get => GetbitfieldValue(_IsEnableNeckTurnBitfield);
            set => SetBitfieldValue(ref _IsEnableNeckTurnBitfield, value);
        }

        [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 7)]
        public byte Pad1
        {
            get => GetbitfieldValue(_IsEnableNeckTurnBitfield);
            set => SetBitfieldValue(ref _IsEnableNeckTurnBitfield, value);
        }

        #endregion BitField IsEnableNeckTurnBitfield

        #region BitField VowTypeBitfield ==============================================================================

        [ParamField(0x149, ParamType.U8)]
        public byte VowTypeBitfield
        {
            get => _VowTypeBitfield;
            set => WriteParamField(ref _VowTypeBitfield, value);
        }
        private byte _VowTypeBitfield;

        [ParamBitField(nameof(VowTypeBitfield), bits: 3, bitsOffset: 0)]
        public byte VowType
        {
            get => GetbitfieldValue(_VowTypeBitfield);
            set => SetBitfieldValue(ref _VowTypeBitfield, value);
        }

        [ParamBitField(nameof(VowTypeBitfield), bits: 1, bitsOffset: 3)]
        public byte DisableInitializeDead
        {
            get => GetbitfieldValue(_VowTypeBitfield);
            set => SetBitfieldValue(ref _VowTypeBitfield, value);
        }

        [ParamBitField(nameof(VowTypeBitfield), bits: 4, bitsOffset: 4)]
        public byte Pad3
        {
            get => GetbitfieldValue(_VowTypeBitfield);
            set => SetBitfieldValue(ref _VowTypeBitfield, value);
        }

        #endregion BitField VowTypeBitfield

        [ParamField(0x14A, ParamType.Dummy8, 6)]
        public byte[] Pad2
        {
            get => _Pad2;
            set => WriteParamField(ref _Pad2, value);
        }
        private byte[] _Pad2 = null!;

    }
}
