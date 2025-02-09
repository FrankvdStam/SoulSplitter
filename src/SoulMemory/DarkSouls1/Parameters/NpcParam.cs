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
public class NpcParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int BehaviorVariationId
    {
        get => _behaviorVariationId;
        set => WriteParamField(ref _behaviorVariationId, value);
    }
    private int _behaviorVariationId;

    [ParamField(0x4, ParamType.I32)]
    public int AiThinkId
    {
        get => _aiThinkId;
        set => WriteParamField(ref _aiThinkId, value);
    }
    private int _aiThinkId;

    [ParamField(0x8, ParamType.I32)]
    public int NameId
    {
        get => _nameId;
        set => WriteParamField(ref _nameId, value);
    }
    private int _nameId;

    [ParamField(0xC, ParamType.F32)]
    public float TurnVellocity
    {
        get => _turnVellocity;
        set => WriteParamField(ref _turnVellocity, value);
    }
    private float _turnVellocity;

    [ParamField(0x10, ParamType.F32)]
    public float HitHeight
    {
        get => _hitHeight;
        set => WriteParamField(ref _hitHeight, value);
    }
    private float _hitHeight;

    [ParamField(0x14, ParamType.F32)]
    public float HitRadius
    {
        get => _hitRadius;
        set => WriteParamField(ref _hitRadius, value);
    }
    private float _hitRadius;

    [ParamField(0x18, ParamType.U32)]
    public uint Weight
    {
        get => _weight;
        set => WriteParamField(ref _weight, value);
    }
    private uint _weight;

    [ParamField(0x1C, ParamType.F32)]
    public float HitYOffset
    {
        get => _hitYOffset;
        set => WriteParamField(ref _hitYOffset, value);
    }
    private float _hitYOffset;

    [ParamField(0x20, ParamType.U32)]
    public uint Hp
    {
        get => _hp;
        set => WriteParamField(ref _hp, value);
    }
    private uint _hp;

    [ParamField(0x24, ParamType.U32)]
    public uint Mp
    {
        get => _mp;
        set => WriteParamField(ref _mp, value);
    }
    private uint _mp;

    [ParamField(0x28, ParamType.U32)]
    public uint GetSoul
    {
        get => _getSoul;
        set => WriteParamField(ref _getSoul, value);
    }
    private uint _getSoul;

    [ParamField(0x2C, ParamType.I32)]
    public int ItemLotId1
    {
        get => _itemLotId1;
        set => WriteParamField(ref _itemLotId1, value);
    }
    private int _itemLotId1;

    [ParamField(0x30, ParamType.I32)]
    public int ItemLotId2
    {
        get => _itemLotId2;
        set => WriteParamField(ref _itemLotId2, value);
    }
    private int _itemLotId2;

    [ParamField(0x34, ParamType.I32)]
    public int ItemLotId3
    {
        get => _itemLotId3;
        set => WriteParamField(ref _itemLotId3, value);
    }
    private int _itemLotId3;

    [ParamField(0x38, ParamType.I32)]
    public int ItemLotId4
    {
        get => _itemLotId4;
        set => WriteParamField(ref _itemLotId4, value);
    }
    private int _itemLotId4;

    [ParamField(0x3C, ParamType.I32)]
    public int ItemLotId5
    {
        get => _itemLotId5;
        set => WriteParamField(ref _itemLotId5, value);
    }
    private int _itemLotId5;

    [ParamField(0x40, ParamType.I32)]
    public int ItemLotId6
    {
        get => _itemLotId6;
        set => WriteParamField(ref _itemLotId6, value);
    }
    private int _itemLotId6;

    [ParamField(0x44, ParamType.I32)]
    public int HumanityLotId
    {
        get => _humanityLotId;
        set => WriteParamField(ref _humanityLotId, value);
    }
    private int _humanityLotId;

    [ParamField(0x48, ParamType.I32)]
    public int SpEffectId0
    {
        get => _spEffectId0;
        set => WriteParamField(ref _spEffectId0, value);
    }
    private int _spEffectId0;

    [ParamField(0x4C, ParamType.I32)]
    public int SpEffectId1
    {
        get => _spEffectId1;
        set => WriteParamField(ref _spEffectId1, value);
    }
    private int _spEffectId1;

    [ParamField(0x50, ParamType.I32)]
    public int SpEffectId2
    {
        get => _spEffectId2;
        set => WriteParamField(ref _spEffectId2, value);
    }
    private int _spEffectId2;

    [ParamField(0x54, ParamType.I32)]
    public int SpEffectId3
    {
        get => _spEffectId3;
        set => WriteParamField(ref _spEffectId3, value);
    }
    private int _spEffectId3;

    [ParamField(0x58, ParamType.I32)]
    public int SpEffectId4
    {
        get => _spEffectId4;
        set => WriteParamField(ref _spEffectId4, value);
    }
    private int _spEffectId4;

    [ParamField(0x5C, ParamType.I32)]
    public int SpEffectId5
    {
        get => _spEffectId5;
        set => WriteParamField(ref _spEffectId5, value);
    }
    private int _spEffectId5;

    [ParamField(0x60, ParamType.I32)]
    public int SpEffectId6
    {
        get => _spEffectId6;
        set => WriteParamField(ref _spEffectId6, value);
    }
    private int _spEffectId6;

    [ParamField(0x64, ParamType.I32)]
    public int SpEffectId7
    {
        get => _spEffectId7;
        set => WriteParamField(ref _spEffectId7, value);
    }
    private int _spEffectId7;

    [ParamField(0x68, ParamType.I32)]
    public int GameClearSpEffectId
    {
        get => _gameClearSpEffectId;
        set => WriteParamField(ref _gameClearSpEffectId, value);
    }
    private int _gameClearSpEffectId;

    [ParamField(0x6C, ParamType.F32)]
    public float PhysGuardCutRate
    {
        get => _physGuardCutRate;
        set => WriteParamField(ref _physGuardCutRate, value);
    }
    private float _physGuardCutRate;

    [ParamField(0x70, ParamType.F32)]
    public float MagGuardCutRate
    {
        get => _magGuardCutRate;
        set => WriteParamField(ref _magGuardCutRate, value);
    }
    private float _magGuardCutRate;

    [ParamField(0x74, ParamType.F32)]
    public float FireGuardCutRate
    {
        get => _fireGuardCutRate;
        set => WriteParamField(ref _fireGuardCutRate, value);
    }
    private float _fireGuardCutRate;

    [ParamField(0x78, ParamType.F32)]
    public float ThunGuardCutRate
    {
        get => _thunGuardCutRate;
        set => WriteParamField(ref _thunGuardCutRate, value);
    }
    private float _thunGuardCutRate;

    [ParamField(0x7C, ParamType.I32)]
    public int AnimIdOffset
    {
        get => _animIdOffset;
        set => WriteParamField(ref _animIdOffset, value);
    }
    private int _animIdOffset;

    [ParamField(0x80, ParamType.I32)]
    public int MoveAnimId
    {
        get => _moveAnimId;
        set => WriteParamField(ref _moveAnimId, value);
    }
    private int _moveAnimId;

    [ParamField(0x84, ParamType.I32)]
    public int SpMoveAnimId1
    {
        get => _spMoveAnimId1;
        set => WriteParamField(ref _spMoveAnimId1, value);
    }
    private int _spMoveAnimId1;

    [ParamField(0x88, ParamType.I32)]
    public int SpMoveAnimId2
    {
        get => _spMoveAnimId2;
        set => WriteParamField(ref _spMoveAnimId2, value);
    }
    private int _spMoveAnimId2;

    [ParamField(0x8C, ParamType.F32)]
    public float NetworkWarpDist
    {
        get => _networkWarpDist;
        set => WriteParamField(ref _networkWarpDist, value);
    }
    private float _networkWarpDist;

    [ParamField(0x90, ParamType.I32)]
    public int DbgBehaviorR1
    {
        get => _dbgBehaviorR1;
        set => WriteParamField(ref _dbgBehaviorR1, value);
    }
    private int _dbgBehaviorR1;

    [ParamField(0x94, ParamType.I32)]
    public int DbgBehaviorL1
    {
        get => _dbgBehaviorL1;
        set => WriteParamField(ref _dbgBehaviorL1, value);
    }
    private int _dbgBehaviorL1;

    [ParamField(0x98, ParamType.I32)]
    public int DbgBehaviorR2
    {
        get => _dbgBehaviorR2;
        set => WriteParamField(ref _dbgBehaviorR2, value);
    }
    private int _dbgBehaviorR2;

    [ParamField(0x9C, ParamType.I32)]
    public int DbgBehaviorL2
    {
        get => _dbgBehaviorL2;
        set => WriteParamField(ref _dbgBehaviorL2, value);
    }
    private int _dbgBehaviorL2;

    [ParamField(0xA0, ParamType.I32)]
    public int DbgBehaviorRl
    {
        get => _dbgBehaviorRl;
        set => WriteParamField(ref _dbgBehaviorRl, value);
    }
    private int _dbgBehaviorRl;

    [ParamField(0xA4, ParamType.I32)]
    public int DbgBehaviorRr
    {
        get => _dbgBehaviorRr;
        set => WriteParamField(ref _dbgBehaviorRr, value);
    }
    private int _dbgBehaviorRr;

    [ParamField(0xA8, ParamType.I32)]
    public int DbgBehaviorRd
    {
        get => _dbgBehaviorRd;
        set => WriteParamField(ref _dbgBehaviorRd, value);
    }
    private int _dbgBehaviorRd;

    [ParamField(0xAC, ParamType.I32)]
    public int DbgBehaviorRu
    {
        get => _dbgBehaviorRu;
        set => WriteParamField(ref _dbgBehaviorRu, value);
    }
    private int _dbgBehaviorRu;

    [ParamField(0xB0, ParamType.I32)]
    public int DbgBehaviorLl
    {
        get => _dbgBehaviorLl;
        set => WriteParamField(ref _dbgBehaviorLl, value);
    }
    private int _dbgBehaviorLl;

    [ParamField(0xB4, ParamType.I32)]
    public int DbgBehaviorLr
    {
        get => _dbgBehaviorLr;
        set => WriteParamField(ref _dbgBehaviorLr, value);
    }
    private int _dbgBehaviorLr;

    [ParamField(0xB8, ParamType.I32)]
    public int DbgBehaviorLd
    {
        get => _dbgBehaviorLd;
        set => WriteParamField(ref _dbgBehaviorLd, value);
    }
    private int _dbgBehaviorLd;

    [ParamField(0xBC, ParamType.I32)]
    public int DbgBehaviorLu
    {
        get => _dbgBehaviorLu;
        set => WriteParamField(ref _dbgBehaviorLu, value);
    }
    private int _dbgBehaviorLu;

    [ParamField(0xC0, ParamType.I32)]
    public int AnimIdOffset2
    {
        get => _animIdOffset2;
        set => WriteParamField(ref _animIdOffset2, value);
    }
    private int _animIdOffset2;

    [ParamField(0xC4, ParamType.F32)]
    public float PartsDamageRate1
    {
        get => _partsDamageRate1;
        set => WriteParamField(ref _partsDamageRate1, value);
    }
    private float _partsDamageRate1;

    [ParamField(0xC8, ParamType.F32)]
    public float PartsDamageRate2
    {
        get => _partsDamageRate2;
        set => WriteParamField(ref _partsDamageRate2, value);
    }
    private float _partsDamageRate2;

    [ParamField(0xCC, ParamType.F32)]
    public float PartsDamageRate3
    {
        get => _partsDamageRate3;
        set => WriteParamField(ref _partsDamageRate3, value);
    }
    private float _partsDamageRate3;

    [ParamField(0xD0, ParamType.F32)]
    public float PartsDamageRate4
    {
        get => _partsDamageRate4;
        set => WriteParamField(ref _partsDamageRate4, value);
    }
    private float _partsDamageRate4;

    [ParamField(0xD4, ParamType.F32)]
    public float PartsDamageRate5
    {
        get => _partsDamageRate5;
        set => WriteParamField(ref _partsDamageRate5, value);
    }
    private float _partsDamageRate5;

    [ParamField(0xD8, ParamType.F32)]
    public float PartsDamageRate6
    {
        get => _partsDamageRate6;
        set => WriteParamField(ref _partsDamageRate6, value);
    }
    private float _partsDamageRate6;

    [ParamField(0xDC, ParamType.F32)]
    public float PartsDamageRate7
    {
        get => _partsDamageRate7;
        set => WriteParamField(ref _partsDamageRate7, value);
    }
    private float _partsDamageRate7;

    [ParamField(0xE0, ParamType.F32)]
    public float PartsDamageRate8
    {
        get => _partsDamageRate8;
        set => WriteParamField(ref _partsDamageRate8, value);
    }
    private float _partsDamageRate8;

    [ParamField(0xE4, ParamType.F32)]
    public float WeakPartsDamageRate
    {
        get => _weakPartsDamageRate;
        set => WriteParamField(ref _weakPartsDamageRate, value);
    }
    private float _weakPartsDamageRate;

    [ParamField(0xE8, ParamType.F32)]
    public float SuperArmorRecoverCorrection
    {
        get => _superArmorRecoverCorrection;
        set => WriteParamField(ref _superArmorRecoverCorrection, value);
    }
    private float _superArmorRecoverCorrection;

    [ParamField(0xEC, ParamType.F32)]
    public float SuperArmorBrakeKnockbackDist
    {
        get => _superArmorBrakeKnockbackDist;
        set => WriteParamField(ref _superArmorBrakeKnockbackDist, value);
    }
    private float _superArmorBrakeKnockbackDist;

    [ParamField(0xF0, ParamType.U16)]
    public ushort Stamina
    {
        get => _stamina;
        set => WriteParamField(ref _stamina, value);
    }
    private ushort _stamina;

    [ParamField(0xF2, ParamType.U16)]
    public ushort StaminaRecoverBaseVel
    {
        get => _staminaRecoverBaseVel;
        set => WriteParamField(ref _staminaRecoverBaseVel, value);
    }
    private ushort _staminaRecoverBaseVel;

    [ParamField(0xF4, ParamType.U16)]
    public ushort DefPhys
    {
        get => _defPhys;
        set => WriteParamField(ref _defPhys, value);
    }
    private ushort _defPhys;

    [ParamField(0xF6, ParamType.I16)]
    public short DefSlash
    {
        get => _defSlash;
        set => WriteParamField(ref _defSlash, value);
    }
    private short _defSlash;

    [ParamField(0xF8, ParamType.I16)]
    public short DefBlow
    {
        get => _defBlow;
        set => WriteParamField(ref _defBlow, value);
    }
    private short _defBlow;

    [ParamField(0xFA, ParamType.I16)]
    public short DefThrust
    {
        get => _defThrust;
        set => WriteParamField(ref _defThrust, value);
    }
    private short _defThrust;

    [ParamField(0xFC, ParamType.U16)]
    public ushort DefMag
    {
        get => _defMag;
        set => WriteParamField(ref _defMag, value);
    }
    private ushort _defMag;

    [ParamField(0xFE, ParamType.U16)]
    public ushort DefFire
    {
        get => _defFire;
        set => WriteParamField(ref _defFire, value);
    }
    private ushort _defFire;

    [ParamField(0x100, ParamType.U16)]
    public ushort DefThunder
    {
        get => _defThunder;
        set => WriteParamField(ref _defThunder, value);
    }
    private ushort _defThunder;

    [ParamField(0x102, ParamType.U16)]
    public ushort DefFlickPower
    {
        get => _defFlickPower;
        set => WriteParamField(ref _defFlickPower, value);
    }
    private ushort _defFlickPower;

    [ParamField(0x104, ParamType.U16)]
    public ushort ResistPoison
    {
        get => _resistPoison;
        set => WriteParamField(ref _resistPoison, value);
    }
    private ushort _resistPoison;

    [ParamField(0x106, ParamType.U16)]
    public ushort ResistDesease
    {
        get => _resistDesease;
        set => WriteParamField(ref _resistDesease, value);
    }
    private ushort _resistDesease;

    [ParamField(0x108, ParamType.U16)]
    public ushort ResistBlood
    {
        get => _resistBlood;
        set => WriteParamField(ref _resistBlood, value);
    }
    private ushort _resistBlood;

    [ParamField(0x10A, ParamType.U16)]
    public ushort ResistCurse
    {
        get => _resistCurse;
        set => WriteParamField(ref _resistCurse, value);
    }
    private ushort _resistCurse;

    [ParamField(0x10C, ParamType.I16)]
    public short GhostModelId
    {
        get => _ghostModelId;
        set => WriteParamField(ref _ghostModelId, value);
    }
    private short _ghostModelId;

    [ParamField(0x10E, ParamType.I16)]
    public short NormalChangeResouceId
    {
        get => _normalChangeResouceId;
        set => WriteParamField(ref _normalChangeResouceId, value);
    }
    private short _normalChangeResouceId;

    [ParamField(0x110, ParamType.I16)]
    public short GuardAngle
    {
        get => _guardAngle;
        set => WriteParamField(ref _guardAngle, value);
    }
    private short _guardAngle;

    [ParamField(0x112, ParamType.I16)]
    public short SlashGuardCutRate
    {
        get => _slashGuardCutRate;
        set => WriteParamField(ref _slashGuardCutRate, value);
    }
    private short _slashGuardCutRate;

    [ParamField(0x114, ParamType.I16)]
    public short BlowGuardCutRate
    {
        get => _blowGuardCutRate;
        set => WriteParamField(ref _blowGuardCutRate, value);
    }
    private short _blowGuardCutRate;

    [ParamField(0x116, ParamType.I16)]
    public short ThrustGuardCutRate
    {
        get => _thrustGuardCutRate;
        set => WriteParamField(ref _thrustGuardCutRate, value);
    }
    private short _thrustGuardCutRate;

    [ParamField(0x118, ParamType.I16)]
    public short SuperArmorDurability
    {
        get => _superArmorDurability;
        set => WriteParamField(ref _superArmorDurability, value);
    }
    private short _superArmorDurability;

    [ParamField(0x11A, ParamType.I16)]
    public short NormalChangeTexChrId
    {
        get => _normalChangeTexChrId;
        set => WriteParamField(ref _normalChangeTexChrId, value);
    }
    private short _normalChangeTexChrId;

    [ParamField(0x11C, ParamType.U16)]
    public ushort DropType
    {
        get => _dropType;
        set => WriteParamField(ref _dropType, value);
    }
    private ushort _dropType;

    [ParamField(0x11E, ParamType.U8)]
    public byte KnockbackRate
    {
        get => _knockbackRate;
        set => WriteParamField(ref _knockbackRate, value);
    }
    private byte _knockbackRate;

    [ParamField(0x11F, ParamType.U8)]
    public byte KnockbackParamId
    {
        get => _knockbackParamId;
        set => WriteParamField(ref _knockbackParamId, value);
    }
    private byte _knockbackParamId;

    [ParamField(0x120, ParamType.U8)]
    public byte FallDamageDump
    {
        get => _fallDamageDump;
        set => WriteParamField(ref _fallDamageDump, value);
    }
    private byte _fallDamageDump;

    [ParamField(0x121, ParamType.U8)]
    public byte StaminaGuardDef
    {
        get => _staminaGuardDef;
        set => WriteParamField(ref _staminaGuardDef, value);
    }
    private byte _staminaGuardDef;

    [ParamField(0x122, ParamType.U8)]
    public byte PcAttrB
    {
        get => _pcAttrB;
        set => WriteParamField(ref _pcAttrB, value);
    }
    private byte _pcAttrB;

    [ParamField(0x123, ParamType.U8)]
    public byte PcAttrW
    {
        get => _pcAttrW;
        set => WriteParamField(ref _pcAttrW, value);
    }
    private byte _pcAttrW;

    [ParamField(0x124, ParamType.U8)]
    public byte PcAttrL
    {
        get => _pcAttrL;
        set => WriteParamField(ref _pcAttrL, value);
    }
    private byte _pcAttrL;

    [ParamField(0x125, ParamType.U8)]
    public byte PcAttrR
    {
        get => _pcAttrR;
        set => WriteParamField(ref _pcAttrR, value);
    }
    private byte _pcAttrR;

    [ParamField(0x126, ParamType.U8)]
    public byte AreaAttrB
    {
        get => _areaAttrB;
        set => WriteParamField(ref _areaAttrB, value);
    }
    private byte _areaAttrB;

    [ParamField(0x127, ParamType.U8)]
    public byte AreaAttrW
    {
        get => _areaAttrW;
        set => WriteParamField(ref _areaAttrW, value);
    }
    private byte _areaAttrW;

    [ParamField(0x128, ParamType.U8)]
    public byte AreaAttrL
    {
        get => _areaAttrL;
        set => WriteParamField(ref _areaAttrL, value);
    }
    private byte _areaAttrL;

    [ParamField(0x129, ParamType.U8)]
    public byte AreaAttrR
    {
        get => _areaAttrR;
        set => WriteParamField(ref _areaAttrR, value);
    }
    private byte _areaAttrR;

    [ParamField(0x12A, ParamType.U8)]
    public byte MpRecoverBaseVel
    {
        get => _mpRecoverBaseVel;
        set => WriteParamField(ref _mpRecoverBaseVel, value);
    }
    private byte _mpRecoverBaseVel;

    [ParamField(0x12B, ParamType.U8)]
    public byte FlickDamageCutRate
    {
        get => _flickDamageCutRate;
        set => WriteParamField(ref _flickDamageCutRate, value);
    }
    private byte _flickDamageCutRate;

    [ParamField(0x12C, ParamType.I8)]
    public sbyte DefaultLodParamId
    {
        get => _defaultLodParamId;
        set => WriteParamField(ref _defaultLodParamId, value);
    }
    private sbyte _defaultLodParamId;

    [ParamField(0x12D, ParamType.U8)]
    public byte DrawType
    {
        get => _drawType;
        set => WriteParamField(ref _drawType, value);
    }
    private byte _drawType;

    [ParamField(0x12E, ParamType.U8)]
    public byte NpcType
    {
        get => _npcType;
        set => WriteParamField(ref _npcType, value);
    }
    private byte _npcType;

    [ParamField(0x12F, ParamType.U8)]
    public byte TeamType
    {
        get => _teamType;
        set => WriteParamField(ref _teamType, value);
    }
    private byte _teamType;

    [ParamField(0x130, ParamType.U8)]
    public byte MoveType
    {
        get => _moveType;
        set => WriteParamField(ref _moveType, value);
    }
    private byte _moveType;

    [ParamField(0x131, ParamType.U8)]
    public byte LockDist
    {
        get => _lockDist;
        set => WriteParamField(ref _lockDist, value);
    }
    private byte _lockDist;

    [ParamField(0x132, ParamType.U8)]
    public byte Material
    {
        get => _material;
        set => WriteParamField(ref _material, value);
    }
    private byte _material;

    [ParamField(0x133, ParamType.U8)]
    public byte MaterialSfx
    {
        get => _materialSfx;
        set => WriteParamField(ref _materialSfx, value);
    }
    private byte _materialSfx;

    [ParamField(0x134, ParamType.U8)]
    public byte MaterialWeak
    {
        get => _materialWeak;
        set => WriteParamField(ref _materialWeak, value);
    }
    private byte _materialWeak;

    [ParamField(0x135, ParamType.U8)]
    public byte MaterialSfxWeak
    {
        get => _materialSfxWeak;
        set => WriteParamField(ref _materialSfxWeak, value);
    }
    private byte _materialSfxWeak;

    [ParamField(0x136, ParamType.U8)]
    public byte PartsDamageType
    {
        get => _partsDamageType;
        set => WriteParamField(ref _partsDamageType, value);
    }
    private byte _partsDamageType;

    [ParamField(0x137, ParamType.U8)]
    public byte MaxUndurationAng
    {
        get => _maxUndurationAng;
        set => WriteParamField(ref _maxUndurationAng, value);
    }
    private byte _maxUndurationAng;

    [ParamField(0x138, ParamType.I8)]
    public sbyte GuardLevel
    {
        get => _guardLevel;
        set => WriteParamField(ref _guardLevel, value);
    }
    private sbyte _guardLevel;

    [ParamField(0x139, ParamType.U8)]
    public byte BurnSfxType
    {
        get => _burnSfxType;
        set => WriteParamField(ref _burnSfxType, value);
    }
    private byte _burnSfxType;

    [ParamField(0x13A, ParamType.I8)]
    public sbyte PoisonGuardResist
    {
        get => _poisonGuardResist;
        set => WriteParamField(ref _poisonGuardResist, value);
    }
    private sbyte _poisonGuardResist;

    [ParamField(0x13B, ParamType.I8)]
    public sbyte DiseaseGuardResist
    {
        get => _diseaseGuardResist;
        set => WriteParamField(ref _diseaseGuardResist, value);
    }
    private sbyte _diseaseGuardResist;

    [ParamField(0x13C, ParamType.I8)]
    public sbyte BloodGuardResist
    {
        get => _bloodGuardResist;
        set => WriteParamField(ref _bloodGuardResist, value);
    }
    private sbyte _bloodGuardResist;

    [ParamField(0x13D, ParamType.I8)]
    public sbyte CurseGuardResist
    {
        get => _curseGuardResist;
        set => WriteParamField(ref _curseGuardResist, value);
    }
    private sbyte _curseGuardResist;

    [ParamField(0x13E, ParamType.U8)]
    public byte ParryAttack
    {
        get => _parryAttack;
        set => WriteParamField(ref _parryAttack, value);
    }
    private byte _parryAttack;

    [ParamField(0x13F, ParamType.U8)]
    public byte ParryDefence
    {
        get => _parryDefence;
        set => WriteParamField(ref _parryDefence, value);
    }
    private byte _parryDefence;

    [ParamField(0x140, ParamType.U8)]
    public byte SfxSize
    {
        get => _sfxSize;
        set => WriteParamField(ref _sfxSize, value);
    }
    private byte _sfxSize;

    [ParamField(0x141, ParamType.U8)]
    public byte PushOutCamRegionRadius
    {
        get => _pushOutCamRegionRadius;
        set => WriteParamField(ref _pushOutCamRegionRadius, value);
    }
    private byte _pushOutCamRegionRadius;

    [ParamField(0x142, ParamType.U8)]
    public byte HitStopType
    {
        get => _hitStopType;
        set => WriteParamField(ref _hitStopType, value);
    }
    private byte _hitStopType;

    [ParamField(0x143, ParamType.U8)]
    public byte LadderEndChkOffsetTop
    {
        get => _ladderEndChkOffsetTop;
        set => WriteParamField(ref _ladderEndChkOffsetTop, value);
    }
    private byte _ladderEndChkOffsetTop;

    [ParamField(0x144, ParamType.U8)]
    public byte LadderEndChkOffsetLow
    {
        get => _ladderEndChkOffsetLow;
        set => WriteParamField(ref _ladderEndChkOffsetLow, value);
    }
    private byte _ladderEndChkOffsetLow;

    #region BitField UseRagdollCamHitBitfield ==============================================================================

    [ParamField(0x145, ParamType.U8)]
    public byte UseRagdollCamHitBitfield
    {
        get => _useRagdollCamHitBitfield;
        set => WriteParamField(ref _useRagdollCamHitBitfield, value);
    }
    private byte _useRagdollCamHitBitfield;

    [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 0)]
    public byte UseRagdollCamHit
    {
        get => GetbitfieldValue(_useRagdollCamHitBitfield);
        set => SetBitfieldValue(ref _useRagdollCamHitBitfield, value);
    }

    [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 1)]
    public byte DisableClothRigidHit
    {
        get => GetbitfieldValue(_useRagdollCamHitBitfield);
        set => SetBitfieldValue(ref _useRagdollCamHitBitfield, value);
    }

    [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 2)]
    public byte UseRagdoll
    {
        get => GetbitfieldValue(_useRagdollCamHitBitfield);
        set => SetBitfieldValue(ref _useRagdollCamHitBitfield, value);
    }

    [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 3)]
    public byte IsDemon
    {
        get => GetbitfieldValue(_useRagdollCamHitBitfield);
        set => SetBitfieldValue(ref _useRagdollCamHitBitfield, value);
    }

    [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 4)]
    public byte IsGhost
    {
        get => GetbitfieldValue(_useRagdollCamHitBitfield);
        set => SetBitfieldValue(ref _useRagdollCamHitBitfield, value);
    }

    [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 5)]
    public byte IsNoDamageMotion
    {
        get => GetbitfieldValue(_useRagdollCamHitBitfield);
        set => SetBitfieldValue(ref _useRagdollCamHitBitfield, value);
    }

    [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 6)]
    public byte IsUnduration
    {
        get => GetbitfieldValue(_useRagdollCamHitBitfield);
        set => SetBitfieldValue(ref _useRagdollCamHitBitfield, value);
    }

    [ParamBitField(nameof(UseRagdollCamHitBitfield), bits: 1, bitsOffset: 7)]
    public byte IsChangeWanderGhost
    {
        get => GetbitfieldValue(_useRagdollCamHitBitfield);
        set => SetBitfieldValue(ref _useRagdollCamHitBitfield, value);
    }

    #endregion BitField UseRagdollCamHitBitfield

    #region BitField ModelDispMask0Bitfield ==============================================================================

    [ParamField(0x146, ParamType.U8)]
    public byte ModelDispMask0Bitfield
    {
        get => _modelDispMask0Bitfield;
        set => WriteParamField(ref _modelDispMask0Bitfield, value);
    }
    private byte _modelDispMask0Bitfield;

    [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 0)]
    public byte ModelDispMask0
    {
        get => GetbitfieldValue(_modelDispMask0Bitfield);
        set => SetBitfieldValue(ref _modelDispMask0Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 1)]
    public byte ModelDispMask1
    {
        get => GetbitfieldValue(_modelDispMask0Bitfield);
        set => SetBitfieldValue(ref _modelDispMask0Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 2)]
    public byte ModelDispMask2
    {
        get => GetbitfieldValue(_modelDispMask0Bitfield);
        set => SetBitfieldValue(ref _modelDispMask0Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 3)]
    public byte ModelDispMask3
    {
        get => GetbitfieldValue(_modelDispMask0Bitfield);
        set => SetBitfieldValue(ref _modelDispMask0Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 4)]
    public byte ModelDispMask4
    {
        get => GetbitfieldValue(_modelDispMask0Bitfield);
        set => SetBitfieldValue(ref _modelDispMask0Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 5)]
    public byte ModelDispMask5
    {
        get => GetbitfieldValue(_modelDispMask0Bitfield);
        set => SetBitfieldValue(ref _modelDispMask0Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 6)]
    public byte ModelDispMask6
    {
        get => GetbitfieldValue(_modelDispMask0Bitfield);
        set => SetBitfieldValue(ref _modelDispMask0Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask0Bitfield), bits: 1, bitsOffset: 7)]
    public byte ModelDispMask7
    {
        get => GetbitfieldValue(_modelDispMask0Bitfield);
        set => SetBitfieldValue(ref _modelDispMask0Bitfield, value);
    }

    #endregion BitField ModelDispMask0Bitfield

    #region BitField ModelDispMask8Bitfield ==============================================================================

    [ParamField(0x147, ParamType.U8)]
    public byte ModelDispMask8Bitfield
    {
        get => _modelDispMask8Bitfield;
        set => WriteParamField(ref _modelDispMask8Bitfield, value);
    }
    private byte _modelDispMask8Bitfield;

    [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 0)]
    public byte ModelDispMask8
    {
        get => GetbitfieldValue(_modelDispMask8Bitfield);
        set => SetBitfieldValue(ref _modelDispMask8Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 1)]
    public byte ModelDispMask9
    {
        get => GetbitfieldValue(_modelDispMask8Bitfield);
        set => SetBitfieldValue(ref _modelDispMask8Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 2)]
    public byte ModelDispMask10
    {
        get => GetbitfieldValue(_modelDispMask8Bitfield);
        set => SetBitfieldValue(ref _modelDispMask8Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 3)]
    public byte ModelDispMask11
    {
        get => GetbitfieldValue(_modelDispMask8Bitfield);
        set => SetBitfieldValue(ref _modelDispMask8Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 4)]
    public byte ModelDispMask12
    {
        get => GetbitfieldValue(_modelDispMask8Bitfield);
        set => SetBitfieldValue(ref _modelDispMask8Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 5)]
    public byte ModelDispMask13
    {
        get => GetbitfieldValue(_modelDispMask8Bitfield);
        set => SetBitfieldValue(ref _modelDispMask8Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 6)]
    public byte ModelDispMask14
    {
        get => GetbitfieldValue(_modelDispMask8Bitfield);
        set => SetBitfieldValue(ref _modelDispMask8Bitfield, value);
    }

    [ParamBitField(nameof(ModelDispMask8Bitfield), bits: 1, bitsOffset: 7)]
    public byte ModelDispMask15
    {
        get => GetbitfieldValue(_modelDispMask8Bitfield);
        set => SetBitfieldValue(ref _modelDispMask8Bitfield, value);
    }

    #endregion BitField ModelDispMask8Bitfield

    #region BitField IsEnableNeckTurnBitfield ==============================================================================

    [ParamField(0x148, ParamType.U8)]
    public byte IsEnableNeckTurnBitfield
    {
        get => _isEnableNeckTurnBitfield;
        set => WriteParamField(ref _isEnableNeckTurnBitfield, value);
    }
    private byte _isEnableNeckTurnBitfield;

    [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 0)]
    public byte IsEnableNeckTurn
    {
        get => GetbitfieldValue(_isEnableNeckTurnBitfield);
        set => SetBitfieldValue(ref _isEnableNeckTurnBitfield, value);
    }

    [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 1)]
    public byte DisableRespawn
    {
        get => GetbitfieldValue(_isEnableNeckTurnBitfield);
        set => SetBitfieldValue(ref _isEnableNeckTurnBitfield, value);
    }

    [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 2)]
    public byte IsMoveAnimWait
    {
        get => GetbitfieldValue(_isEnableNeckTurnBitfield);
        set => SetBitfieldValue(ref _isEnableNeckTurnBitfield, value);
    }

    [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 3)]
    public byte IsCrowd
    {
        get => GetbitfieldValue(_isEnableNeckTurnBitfield);
        set => SetBitfieldValue(ref _isEnableNeckTurnBitfield, value);
    }

    [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 4)]
    public byte IsWeakSaint
    {
        get => GetbitfieldValue(_isEnableNeckTurnBitfield);
        set => SetBitfieldValue(ref _isEnableNeckTurnBitfield, value);
    }

    [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 5)]
    public byte IsWeakA
    {
        get => GetbitfieldValue(_isEnableNeckTurnBitfield);
        set => SetBitfieldValue(ref _isEnableNeckTurnBitfield, value);
    }

    [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 6)]
    public byte IsWeakB
    {
        get => GetbitfieldValue(_isEnableNeckTurnBitfield);
        set => SetBitfieldValue(ref _isEnableNeckTurnBitfield, value);
    }

    [ParamBitField(nameof(IsEnableNeckTurnBitfield), bits: 1, bitsOffset: 7)]
    public byte Pad1
    {
        get => GetbitfieldValue(_isEnableNeckTurnBitfield);
        set => SetBitfieldValue(ref _isEnableNeckTurnBitfield, value);
    }

    #endregion BitField IsEnableNeckTurnBitfield

    #region BitField VowTypeBitfield ==============================================================================

    [ParamField(0x149, ParamType.U8)]
    public byte VowTypeBitfield
    {
        get => _vowTypeBitfield;
        set => WriteParamField(ref _vowTypeBitfield, value);
    }
    private byte _vowTypeBitfield;

    [ParamBitField(nameof(VowTypeBitfield), bits: 3, bitsOffset: 0)]
    public byte VowType
    {
        get => GetbitfieldValue(_vowTypeBitfield);
        set => SetBitfieldValue(ref _vowTypeBitfield, value);
    }

    [ParamBitField(nameof(VowTypeBitfield), bits: 1, bitsOffset: 3)]
    public byte DisableInitializeDead
    {
        get => GetbitfieldValue(_vowTypeBitfield);
        set => SetBitfieldValue(ref _vowTypeBitfield, value);
    }

    [ParamBitField(nameof(VowTypeBitfield), bits: 4, bitsOffset: 4)]
    public byte Pad3
    {
        get => GetbitfieldValue(_vowTypeBitfield);
        set => SetBitfieldValue(ref _vowTypeBitfield, value);
    }

    #endregion BitField VowTypeBitfield

    [ParamField(0x14A, ParamType.Dummy8, 6)]
    public byte[] Pad2
    {
        get => _pad2;
        set => WriteParamField(ref _pad2, value);
    }
    private byte[] _pad2 = null!;

}
