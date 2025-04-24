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
public class CharaInitParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.F32)]
    public float BaseRecMp
    {
        get => _baseRecMp;
        set => WriteParamField(ref _baseRecMp, value);
    }
    private float _baseRecMp;

    [ParamField(0x4, ParamType.F32)]
    public float BaseRecSp
    {
        get => _baseRecSp;
        set => WriteParamField(ref _baseRecSp, value);
    }
    private float _baseRecSp;

    [ParamField(0x8, ParamType.F32)]
    public float RedFalldam
    {
        get => _redFalldam;
        set => WriteParamField(ref _redFalldam, value);
    }
    private float _redFalldam;

    [ParamField(0xC, ParamType.I32)]
    public int Soul
    {
        get => _soul;
        set => WriteParamField(ref _soul, value);
    }
    private int _soul;

    [ParamField(0x10, ParamType.I32)]
    public int EquipWepRight
    {
        get => _equipWepRight;
        set => WriteParamField(ref _equipWepRight, value);
    }
    private int _equipWepRight;

    [ParamField(0x14, ParamType.I32)]
    public int EquipSubwepRight
    {
        get => _equipSubwepRight;
        set => WriteParamField(ref _equipSubwepRight, value);
    }
    private int _equipSubwepRight;

    [ParamField(0x18, ParamType.I32)]
    public int EquipWepLeft
    {
        get => _equipWepLeft;
        set => WriteParamField(ref _equipWepLeft, value);
    }
    private int _equipWepLeft;

    [ParamField(0x1C, ParamType.I32)]
    public int EquipSubwepLeft
    {
        get => _equipSubwepLeft;
        set => WriteParamField(ref _equipSubwepLeft, value);
    }
    private int _equipSubwepLeft;

    [ParamField(0x20, ParamType.I32)]
    public int EquipHelm
    {
        get => _equipHelm;
        set => WriteParamField(ref _equipHelm, value);
    }
    private int _equipHelm;

    [ParamField(0x24, ParamType.I32)]
    public int EquipArmer
    {
        get => _equipArmer;
        set => WriteParamField(ref _equipArmer, value);
    }
    private int _equipArmer;

    [ParamField(0x28, ParamType.I32)]
    public int EquipGaunt
    {
        get => _equipGaunt;
        set => WriteParamField(ref _equipGaunt, value);
    }
    private int _equipGaunt;

    [ParamField(0x2C, ParamType.I32)]
    public int EquipLeg
    {
        get => _equipLeg;
        set => WriteParamField(ref _equipLeg, value);
    }
    private int _equipLeg;

    [ParamField(0x30, ParamType.I32)]
    public int EquipArrow
    {
        get => _equipArrow;
        set => WriteParamField(ref _equipArrow, value);
    }
    private int _equipArrow;

    [ParamField(0x34, ParamType.I32)]
    public int EquipBolt
    {
        get => _equipBolt;
        set => WriteParamField(ref _equipBolt, value);
    }
    private int _equipBolt;

    [ParamField(0x38, ParamType.I32)]
    public int EquipSubArrow
    {
        get => _equipSubArrow;
        set => WriteParamField(ref _equipSubArrow, value);
    }
    private int _equipSubArrow;

    [ParamField(0x3C, ParamType.I32)]
    public int EquipSubBolt
    {
        get => _equipSubBolt;
        set => WriteParamField(ref _equipSubBolt, value);
    }
    private int _equipSubBolt;

    [ParamField(0x40, ParamType.I32)]
    public int EquipAccessory01
    {
        get => _equipAccessory01;
        set => WriteParamField(ref _equipAccessory01, value);
    }
    private int _equipAccessory01;

    [ParamField(0x44, ParamType.I32)]
    public int EquipAccessory02
    {
        get => _equipAccessory02;
        set => WriteParamField(ref _equipAccessory02, value);
    }
    private int _equipAccessory02;

    [ParamField(0x48, ParamType.I32)]
    public int EquipAccessory03
    {
        get => _equipAccessory03;
        set => WriteParamField(ref _equipAccessory03, value);
    }
    private int _equipAccessory03;

    [ParamField(0x4C, ParamType.I32)]
    public int EquipAccessory04
    {
        get => _equipAccessory04;
        set => WriteParamField(ref _equipAccessory04, value);
    }
    private int _equipAccessory04;

    [ParamField(0x50, ParamType.I32)]
    public int EquipAccessory05
    {
        get => _equipAccessory05;
        set => WriteParamField(ref _equipAccessory05, value);
    }
    private int _equipAccessory05;

    [ParamField(0x54, ParamType.I32)]
    public int EquipSkill01
    {
        get => _equipSkill01;
        set => WriteParamField(ref _equipSkill01, value);
    }
    private int _equipSkill01;

    [ParamField(0x58, ParamType.I32)]
    public int EquipSkill02
    {
        get => _equipSkill02;
        set => WriteParamField(ref _equipSkill02, value);
    }
    private int _equipSkill02;

    [ParamField(0x5C, ParamType.I32)]
    public int EquipSkill03
    {
        get => _equipSkill03;
        set => WriteParamField(ref _equipSkill03, value);
    }
    private int _equipSkill03;

    [ParamField(0x60, ParamType.I32)]
    public int EquipSpell01
    {
        get => _equipSpell01;
        set => WriteParamField(ref _equipSpell01, value);
    }
    private int _equipSpell01;

    [ParamField(0x64, ParamType.I32)]
    public int EquipSpell02
    {
        get => _equipSpell02;
        set => WriteParamField(ref _equipSpell02, value);
    }
    private int _equipSpell02;

    [ParamField(0x68, ParamType.I32)]
    public int EquipSpell03
    {
        get => _equipSpell03;
        set => WriteParamField(ref _equipSpell03, value);
    }
    private int _equipSpell03;

    [ParamField(0x6C, ParamType.I32)]
    public int EquipSpell04
    {
        get => _equipSpell04;
        set => WriteParamField(ref _equipSpell04, value);
    }
    private int _equipSpell04;

    [ParamField(0x70, ParamType.I32)]
    public int EquipSpell05
    {
        get => _equipSpell05;
        set => WriteParamField(ref _equipSpell05, value);
    }
    private int _equipSpell05;

    [ParamField(0x74, ParamType.I32)]
    public int EquipSpell06
    {
        get => _equipSpell06;
        set => WriteParamField(ref _equipSpell06, value);
    }
    private int _equipSpell06;

    [ParamField(0x78, ParamType.I32)]
    public int EquipSpell07
    {
        get => _equipSpell07;
        set => WriteParamField(ref _equipSpell07, value);
    }
    private int _equipSpell07;

    [ParamField(0x7C, ParamType.I32)]
    public int Item01
    {
        get => _item01;
        set => WriteParamField(ref _item01, value);
    }
    private int _item01;

    [ParamField(0x80, ParamType.I32)]
    public int Item02
    {
        get => _item02;
        set => WriteParamField(ref _item02, value);
    }
    private int _item02;

    [ParamField(0x84, ParamType.I32)]
    public int Item03
    {
        get => _item03;
        set => WriteParamField(ref _item03, value);
    }
    private int _item03;

    [ParamField(0x88, ParamType.I32)]
    public int Item04
    {
        get => _item04;
        set => WriteParamField(ref _item04, value);
    }
    private int _item04;

    [ParamField(0x8C, ParamType.I32)]
    public int Item05
    {
        get => _item05;
        set => WriteParamField(ref _item05, value);
    }
    private int _item05;

    [ParamField(0x90, ParamType.I32)]
    public int Item06
    {
        get => _item06;
        set => WriteParamField(ref _item06, value);
    }
    private int _item06;

    [ParamField(0x94, ParamType.I32)]
    public int Item07
    {
        get => _item07;
        set => WriteParamField(ref _item07, value);
    }
    private int _item07;

    [ParamField(0x98, ParamType.I32)]
    public int Item08
    {
        get => _item08;
        set => WriteParamField(ref _item08, value);
    }
    private int _item08;

    [ParamField(0x9C, ParamType.I32)]
    public int Item09
    {
        get => _item09;
        set => WriteParamField(ref _item09, value);
    }
    private int _item09;

    [ParamField(0xA0, ParamType.I32)]
    public int Item10
    {
        get => _item10;
        set => WriteParamField(ref _item10, value);
    }
    private int _item10;

    [ParamField(0xA4, ParamType.I32)]
    public int NpcPlayerFaceGenId
    {
        get => _npcPlayerFaceGenId;
        set => WriteParamField(ref _npcPlayerFaceGenId, value);
    }
    private int _npcPlayerFaceGenId;

    [ParamField(0xA8, ParamType.I32)]
    public int NpcPlayerThinkId
    {
        get => _npcPlayerThinkId;
        set => WriteParamField(ref _npcPlayerThinkId, value);
    }
    private int _npcPlayerThinkId;

    [ParamField(0xAC, ParamType.U16)]
    public ushort BaseHp
    {
        get => _baseHp;
        set => WriteParamField(ref _baseHp, value);
    }
    private ushort _baseHp;

    [ParamField(0xAE, ParamType.U16)]
    public ushort BaseMp
    {
        get => _baseMp;
        set => WriteParamField(ref _baseMp, value);
    }
    private ushort _baseMp;

    [ParamField(0xB0, ParamType.U16)]
    public ushort BaseSp
    {
        get => _baseSp;
        set => WriteParamField(ref _baseSp, value);
    }
    private ushort _baseSp;

    [ParamField(0xB2, ParamType.U16)]
    public ushort ArrowNum
    {
        get => _arrowNum;
        set => WriteParamField(ref _arrowNum, value);
    }
    private ushort _arrowNum;

    [ParamField(0xB4, ParamType.U16)]
    public ushort BoltNum
    {
        get => _boltNum;
        set => WriteParamField(ref _boltNum, value);
    }
    private ushort _boltNum;

    [ParamField(0xB6, ParamType.U16)]
    public ushort SubArrowNum
    {
        get => _subArrowNum;
        set => WriteParamField(ref _subArrowNum, value);
    }
    private ushort _subArrowNum;

    [ParamField(0xB8, ParamType.U16)]
    public ushort SubBoltNum
    {
        get => _subBoltNum;
        set => WriteParamField(ref _subBoltNum, value);
    }
    private ushort _subBoltNum;

    [ParamField(0xBA, ParamType.I16)]
    public short QwcSb
    {
        get => _qwcSb;
        set => WriteParamField(ref _qwcSb, value);
    }
    private short _qwcSb;

    [ParamField(0xBC, ParamType.I16)]
    public short QwcMw
    {
        get => _qwcMw;
        set => WriteParamField(ref _qwcMw, value);
    }
    private short _qwcMw;

    [ParamField(0xBE, ParamType.I16)]
    public short QwcCd
    {
        get => _qwcCd;
        set => WriteParamField(ref _qwcCd, value);
    }
    private short _qwcCd;

    [ParamField(0xC0, ParamType.I16)]
    public short SoulLv
    {
        get => _soulLv;
        set => WriteParamField(ref _soulLv, value);
    }
    private short _soulLv;

    [ParamField(0xC2, ParamType.U8)]
    public byte BaseVit
    {
        get => _baseVit;
        set => WriteParamField(ref _baseVit, value);
    }
    private byte _baseVit;

    [ParamField(0xC3, ParamType.U8)]
    public byte BaseWil
    {
        get => _baseWil;
        set => WriteParamField(ref _baseWil, value);
    }
    private byte _baseWil;

    [ParamField(0xC4, ParamType.U8)]
    public byte BaseEnd
    {
        get => _baseEnd;
        set => WriteParamField(ref _baseEnd, value);
    }
    private byte _baseEnd;

    [ParamField(0xC5, ParamType.U8)]
    public byte BaseStr
    {
        get => _baseStr;
        set => WriteParamField(ref _baseStr, value);
    }
    private byte _baseStr;

    [ParamField(0xC6, ParamType.U8)]
    public byte BaseDex
    {
        get => _baseDex;
        set => WriteParamField(ref _baseDex, value);
    }
    private byte _baseDex;

    [ParamField(0xC7, ParamType.U8)]
    public byte BaseMag
    {
        get => _baseMag;
        set => WriteParamField(ref _baseMag, value);
    }
    private byte _baseMag;

    [ParamField(0xC8, ParamType.U8)]
    public byte BaseFai
    {
        get => _baseFai;
        set => WriteParamField(ref _baseFai, value);
    }
    private byte _baseFai;

    [ParamField(0xC9, ParamType.U8)]
    public byte BaseLuc
    {
        get => _baseLuc;
        set => WriteParamField(ref _baseLuc, value);
    }
    private byte _baseLuc;

    [ParamField(0xCA, ParamType.U8)]
    public byte BaseHeroPoint
    {
        get => _baseHeroPoint;
        set => WriteParamField(ref _baseHeroPoint, value);
    }
    private byte _baseHeroPoint;

    [ParamField(0xCB, ParamType.U8)]
    public byte BaseDurability
    {
        get => _baseDurability;
        set => WriteParamField(ref _baseDurability, value);
    }
    private byte _baseDurability;

    [ParamField(0xCC, ParamType.U8)]
    public byte ItemNum01
    {
        get => _itemNum01;
        set => WriteParamField(ref _itemNum01, value);
    }
    private byte _itemNum01;

    [ParamField(0xCD, ParamType.U8)]
    public byte ItemNum02
    {
        get => _itemNum02;
        set => WriteParamField(ref _itemNum02, value);
    }
    private byte _itemNum02;

    [ParamField(0xCE, ParamType.U8)]
    public byte ItemNum03
    {
        get => _itemNum03;
        set => WriteParamField(ref _itemNum03, value);
    }
    private byte _itemNum03;

    [ParamField(0xCF, ParamType.U8)]
    public byte ItemNum04
    {
        get => _itemNum04;
        set => WriteParamField(ref _itemNum04, value);
    }
    private byte _itemNum04;

    [ParamField(0xD0, ParamType.U8)]
    public byte ItemNum05
    {
        get => _itemNum05;
        set => WriteParamField(ref _itemNum05, value);
    }
    private byte _itemNum05;

    [ParamField(0xD1, ParamType.U8)]
    public byte ItemNum06
    {
        get => _itemNum06;
        set => WriteParamField(ref _itemNum06, value);
    }
    private byte _itemNum06;

    [ParamField(0xD2, ParamType.U8)]
    public byte ItemNum07
    {
        get => _itemNum07;
        set => WriteParamField(ref _itemNum07, value);
    }
    private byte _itemNum07;

    [ParamField(0xD3, ParamType.U8)]
    public byte ItemNum08
    {
        get => _itemNum08;
        set => WriteParamField(ref _itemNum08, value);
    }
    private byte _itemNum08;

    [ParamField(0xD4, ParamType.U8)]
    public byte ItemNum09
    {
        get => _itemNum09;
        set => WriteParamField(ref _itemNum09, value);
    }
    private byte _itemNum09;

    [ParamField(0xD5, ParamType.U8)]
    public byte ItemNum10
    {
        get => _itemNum10;
        set => WriteParamField(ref _itemNum10, value);
    }
    private byte _itemNum10;

    [ParamField(0xD6, ParamType.I8)]
    public sbyte BodyScaleHead
    {
        get => _bodyScaleHead;
        set => WriteParamField(ref _bodyScaleHead, value);
    }
    private sbyte _bodyScaleHead;

    [ParamField(0xD7, ParamType.I8)]
    public sbyte BodyScaleBreast
    {
        get => _bodyScaleBreast;
        set => WriteParamField(ref _bodyScaleBreast, value);
    }
    private sbyte _bodyScaleBreast;

    [ParamField(0xD8, ParamType.I8)]
    public sbyte BodyScaleAbdomen
    {
        get => _bodyScaleAbdomen;
        set => WriteParamField(ref _bodyScaleAbdomen, value);
    }
    private sbyte _bodyScaleAbdomen;

    [ParamField(0xD9, ParamType.I8)]
    public sbyte BodyScaleArm
    {
        get => _bodyScaleArm;
        set => WriteParamField(ref _bodyScaleArm, value);
    }
    private sbyte _bodyScaleArm;

    [ParamField(0xDA, ParamType.I8)]
    public sbyte BodyScaleLeg
    {
        get => _bodyScaleLeg;
        set => WriteParamField(ref _bodyScaleLeg, value);
    }
    private sbyte _bodyScaleLeg;

    [ParamField(0xDB, ParamType.I8)]
    public sbyte GestureId0
    {
        get => _gestureId0;
        set => WriteParamField(ref _gestureId0, value);
    }
    private sbyte _gestureId0;

    [ParamField(0xDC, ParamType.I8)]
    public sbyte GestureId1
    {
        get => _gestureId1;
        set => WriteParamField(ref _gestureId1, value);
    }
    private sbyte _gestureId1;

    [ParamField(0xDD, ParamType.I8)]
    public sbyte GestureId2
    {
        get => _gestureId2;
        set => WriteParamField(ref _gestureId2, value);
    }
    private sbyte _gestureId2;

    [ParamField(0xDE, ParamType.I8)]
    public sbyte GestureId3
    {
        get => _gestureId3;
        set => WriteParamField(ref _gestureId3, value);
    }
    private sbyte _gestureId3;

    [ParamField(0xDF, ParamType.I8)]
    public sbyte GestureId4
    {
        get => _gestureId4;
        set => WriteParamField(ref _gestureId4, value);
    }
    private sbyte _gestureId4;

    [ParamField(0xE0, ParamType.I8)]
    public sbyte GestureId5
    {
        get => _gestureId5;
        set => WriteParamField(ref _gestureId5, value);
    }
    private sbyte _gestureId5;

    [ParamField(0xE1, ParamType.I8)]
    public sbyte GestureId6
    {
        get => _gestureId6;
        set => WriteParamField(ref _gestureId6, value);
    }
    private sbyte _gestureId6;

    [ParamField(0xE2, ParamType.U8)]
    public byte NpcPlayerType
    {
        get => _npcPlayerType;
        set => WriteParamField(ref _npcPlayerType, value);
    }
    private byte _npcPlayerType;

    [ParamField(0xE3, ParamType.U8)]
    public byte NpcPlayerDrawType
    {
        get => _npcPlayerDrawType;
        set => WriteParamField(ref _npcPlayerDrawType, value);
    }
    private byte _npcPlayerDrawType;

    [ParamField(0xE4, ParamType.U8)]
    public byte NpcPlayerSex
    {
        get => _npcPlayerSex;
        set => WriteParamField(ref _npcPlayerSex, value);
    }
    private byte _npcPlayerSex;

    #region BitField VowTypeBitfield ==============================================================================

    [ParamField(0xE5, ParamType.U8)]
    public byte VowTypeBitfield
    {
        get => _vowTypeBitfield;
        set => WriteParamField(ref _vowTypeBitfield, value);
    }
    private byte _vowTypeBitfield;

    [ParamBitField(nameof(VowTypeBitfield), bits: 4, bitsOffset: 0)]
    public byte VowType
    {
        get => GetbitfieldValue(_vowTypeBitfield);
        set => SetBitfieldValue(ref _vowTypeBitfield, value);
    }

    [ParamBitField(nameof(VowTypeBitfield), bits: 4, bitsOffset: 4)]
    public byte Pad
    {
        get => GetbitfieldValue(_vowTypeBitfield);
        set => SetBitfieldValue(ref _vowTypeBitfield, value);
    }

    #endregion BitField VowTypeBitfield

    [ParamField(0xE6, ParamType.Dummy8, 10)]
    public byte[] Pad0
    {
        get => _pad0;
        set => WriteParamField(ref _pad0, value);
    }
    private byte[] _pad0 = null!;

}
