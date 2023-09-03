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
using System;
using System.Diagnostics.CodeAnalysis;

namespace SoulMemory.DarkSouls1.Parameters
{
    [ExcludeFromCodeCoverage]
    public class CharaInitParam : BaseParam
    {
        public CharaInitParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float BaseRec_mp
        {
            get => _BaseRec_mp;
            set => WriteParamField(ref _BaseRec_mp, value);
        }
        private float _BaseRec_mp;

        [ParamField(0x4, ParamType.F32)]
        public float BaseRec_sp
        {
            get => _BaseRec_sp;
            set => WriteParamField(ref _BaseRec_sp, value);
        }
        private float _BaseRec_sp;

        [ParamField(0x8, ParamType.F32)]
        public float Red_Falldam
        {
            get => _Red_Falldam;
            set => WriteParamField(ref _Red_Falldam, value);
        }
        private float _Red_Falldam;

        [ParamField(0xC, ParamType.I32)]
        public int Soul
        {
            get => _Soul;
            set => WriteParamField(ref _Soul, value);
        }
        private int _Soul;

        [ParamField(0x10, ParamType.I32)]
        public int Equip_Wep_Right
        {
            get => _Equip_Wep_Right;
            set => WriteParamField(ref _Equip_Wep_Right, value);
        }
        private int _Equip_Wep_Right;

        [ParamField(0x14, ParamType.I32)]
        public int Equip_Subwep_Right
        {
            get => _Equip_Subwep_Right;
            set => WriteParamField(ref _Equip_Subwep_Right, value);
        }
        private int _Equip_Subwep_Right;

        [ParamField(0x18, ParamType.I32)]
        public int Equip_Wep_Left
        {
            get => _Equip_Wep_Left;
            set => WriteParamField(ref _Equip_Wep_Left, value);
        }
        private int _Equip_Wep_Left;

        [ParamField(0x1C, ParamType.I32)]
        public int Equip_Subwep_Left
        {
            get => _Equip_Subwep_Left;
            set => WriteParamField(ref _Equip_Subwep_Left, value);
        }
        private int _Equip_Subwep_Left;

        [ParamField(0x20, ParamType.I32)]
        public int Equip_Helm
        {
            get => _Equip_Helm;
            set => WriteParamField(ref _Equip_Helm, value);
        }
        private int _Equip_Helm;

        [ParamField(0x24, ParamType.I32)]
        public int Equip_Armer
        {
            get => _Equip_Armer;
            set => WriteParamField(ref _Equip_Armer, value);
        }
        private int _Equip_Armer;

        [ParamField(0x28, ParamType.I32)]
        public int Equip_Gaunt
        {
            get => _Equip_Gaunt;
            set => WriteParamField(ref _Equip_Gaunt, value);
        }
        private int _Equip_Gaunt;

        [ParamField(0x2C, ParamType.I32)]
        public int Equip_Leg
        {
            get => _Equip_Leg;
            set => WriteParamField(ref _Equip_Leg, value);
        }
        private int _Equip_Leg;

        [ParamField(0x30, ParamType.I32)]
        public int Equip_Arrow
        {
            get => _Equip_Arrow;
            set => WriteParamField(ref _Equip_Arrow, value);
        }
        private int _Equip_Arrow;

        [ParamField(0x34, ParamType.I32)]
        public int Equip_Bolt
        {
            get => _Equip_Bolt;
            set => WriteParamField(ref _Equip_Bolt, value);
        }
        private int _Equip_Bolt;

        [ParamField(0x38, ParamType.I32)]
        public int Equip_SubArrow
        {
            get => _Equip_SubArrow;
            set => WriteParamField(ref _Equip_SubArrow, value);
        }
        private int _Equip_SubArrow;

        [ParamField(0x3C, ParamType.I32)]
        public int Equip_SubBolt
        {
            get => _Equip_SubBolt;
            set => WriteParamField(ref _Equip_SubBolt, value);
        }
        private int _Equip_SubBolt;

        [ParamField(0x40, ParamType.I32)]
        public int Equip_Accessory01
        {
            get => _Equip_Accessory01;
            set => WriteParamField(ref _Equip_Accessory01, value);
        }
        private int _Equip_Accessory01;

        [ParamField(0x44, ParamType.I32)]
        public int Equip_Accessory02
        {
            get => _Equip_Accessory02;
            set => WriteParamField(ref _Equip_Accessory02, value);
        }
        private int _Equip_Accessory02;

        [ParamField(0x48, ParamType.I32)]
        public int Equip_Accessory03
        {
            get => _Equip_Accessory03;
            set => WriteParamField(ref _Equip_Accessory03, value);
        }
        private int _Equip_Accessory03;

        [ParamField(0x4C, ParamType.I32)]
        public int Equip_Accessory04
        {
            get => _Equip_Accessory04;
            set => WriteParamField(ref _Equip_Accessory04, value);
        }
        private int _Equip_Accessory04;

        [ParamField(0x50, ParamType.I32)]
        public int Equip_Accessory05
        {
            get => _Equip_Accessory05;
            set => WriteParamField(ref _Equip_Accessory05, value);
        }
        private int _Equip_Accessory05;

        [ParamField(0x54, ParamType.I32)]
        public int Equip_Skill_01
        {
            get => _Equip_Skill_01;
            set => WriteParamField(ref _Equip_Skill_01, value);
        }
        private int _Equip_Skill_01;

        [ParamField(0x58, ParamType.I32)]
        public int Equip_Skill_02
        {
            get => _Equip_Skill_02;
            set => WriteParamField(ref _Equip_Skill_02, value);
        }
        private int _Equip_Skill_02;

        [ParamField(0x5C, ParamType.I32)]
        public int Equip_Skill_03
        {
            get => _Equip_Skill_03;
            set => WriteParamField(ref _Equip_Skill_03, value);
        }
        private int _Equip_Skill_03;

        [ParamField(0x60, ParamType.I32)]
        public int Equip_Spell_01
        {
            get => _Equip_Spell_01;
            set => WriteParamField(ref _Equip_Spell_01, value);
        }
        private int _Equip_Spell_01;

        [ParamField(0x64, ParamType.I32)]
        public int Equip_Spell_02
        {
            get => _Equip_Spell_02;
            set => WriteParamField(ref _Equip_Spell_02, value);
        }
        private int _Equip_Spell_02;

        [ParamField(0x68, ParamType.I32)]
        public int Equip_Spell_03
        {
            get => _Equip_Spell_03;
            set => WriteParamField(ref _Equip_Spell_03, value);
        }
        private int _Equip_Spell_03;

        [ParamField(0x6C, ParamType.I32)]
        public int Equip_Spell_04
        {
            get => _Equip_Spell_04;
            set => WriteParamField(ref _Equip_Spell_04, value);
        }
        private int _Equip_Spell_04;

        [ParamField(0x70, ParamType.I32)]
        public int Equip_Spell_05
        {
            get => _Equip_Spell_05;
            set => WriteParamField(ref _Equip_Spell_05, value);
        }
        private int _Equip_Spell_05;

        [ParamField(0x74, ParamType.I32)]
        public int Equip_Spell_06
        {
            get => _Equip_Spell_06;
            set => WriteParamField(ref _Equip_Spell_06, value);
        }
        private int _Equip_Spell_06;

        [ParamField(0x78, ParamType.I32)]
        public int Equip_Spell_07
        {
            get => _Equip_Spell_07;
            set => WriteParamField(ref _Equip_Spell_07, value);
        }
        private int _Equip_Spell_07;

        [ParamField(0x7C, ParamType.I32)]
        public int Item_01
        {
            get => _Item_01;
            set => WriteParamField(ref _Item_01, value);
        }
        private int _Item_01;

        [ParamField(0x80, ParamType.I32)]
        public int Item_02
        {
            get => _Item_02;
            set => WriteParamField(ref _Item_02, value);
        }
        private int _Item_02;

        [ParamField(0x84, ParamType.I32)]
        public int Item_03
        {
            get => _Item_03;
            set => WriteParamField(ref _Item_03, value);
        }
        private int _Item_03;

        [ParamField(0x88, ParamType.I32)]
        public int Item_04
        {
            get => _Item_04;
            set => WriteParamField(ref _Item_04, value);
        }
        private int _Item_04;

        [ParamField(0x8C, ParamType.I32)]
        public int Item_05
        {
            get => _Item_05;
            set => WriteParamField(ref _Item_05, value);
        }
        private int _Item_05;

        [ParamField(0x90, ParamType.I32)]
        public int Item_06
        {
            get => _Item_06;
            set => WriteParamField(ref _Item_06, value);
        }
        private int _Item_06;

        [ParamField(0x94, ParamType.I32)]
        public int Item_07
        {
            get => _Item_07;
            set => WriteParamField(ref _Item_07, value);
        }
        private int _Item_07;

        [ParamField(0x98, ParamType.I32)]
        public int Item_08
        {
            get => _Item_08;
            set => WriteParamField(ref _Item_08, value);
        }
        private int _Item_08;

        [ParamField(0x9C, ParamType.I32)]
        public int Item_09
        {
            get => _Item_09;
            set => WriteParamField(ref _Item_09, value);
        }
        private int _Item_09;

        [ParamField(0xA0, ParamType.I32)]
        public int Item_10
        {
            get => _Item_10;
            set => WriteParamField(ref _Item_10, value);
        }
        private int _Item_10;

        [ParamField(0xA4, ParamType.I32)]
        public int NpcPlayerFaceGenId
        {
            get => _NpcPlayerFaceGenId;
            set => WriteParamField(ref _NpcPlayerFaceGenId, value);
        }
        private int _NpcPlayerFaceGenId;

        [ParamField(0xA8, ParamType.I32)]
        public int NpcPlayerThinkId
        {
            get => _NpcPlayerThinkId;
            set => WriteParamField(ref _NpcPlayerThinkId, value);
        }
        private int _NpcPlayerThinkId;

        [ParamField(0xAC, ParamType.U16)]
        public ushort BaseHp
        {
            get => _BaseHp;
            set => WriteParamField(ref _BaseHp, value);
        }
        private ushort _BaseHp;

        [ParamField(0xAE, ParamType.U16)]
        public ushort BaseMp
        {
            get => _BaseMp;
            set => WriteParamField(ref _BaseMp, value);
        }
        private ushort _BaseMp;

        [ParamField(0xB0, ParamType.U16)]
        public ushort BaseSp
        {
            get => _BaseSp;
            set => WriteParamField(ref _BaseSp, value);
        }
        private ushort _BaseSp;

        [ParamField(0xB2, ParamType.U16)]
        public ushort ArrowNum
        {
            get => _ArrowNum;
            set => WriteParamField(ref _ArrowNum, value);
        }
        private ushort _ArrowNum;

        [ParamField(0xB4, ParamType.U16)]
        public ushort BoltNum
        {
            get => _BoltNum;
            set => WriteParamField(ref _BoltNum, value);
        }
        private ushort _BoltNum;

        [ParamField(0xB6, ParamType.U16)]
        public ushort SubArrowNum
        {
            get => _SubArrowNum;
            set => WriteParamField(ref _SubArrowNum, value);
        }
        private ushort _SubArrowNum;

        [ParamField(0xB8, ParamType.U16)]
        public ushort SubBoltNum
        {
            get => _SubBoltNum;
            set => WriteParamField(ref _SubBoltNum, value);
        }
        private ushort _SubBoltNum;

        [ParamField(0xBA, ParamType.I16)]
        public short QWC_sb
        {
            get => _QWC_sb;
            set => WriteParamField(ref _QWC_sb, value);
        }
        private short _QWC_sb;

        [ParamField(0xBC, ParamType.I16)]
        public short QWC_mw
        {
            get => _QWC_mw;
            set => WriteParamField(ref _QWC_mw, value);
        }
        private short _QWC_mw;

        [ParamField(0xBE, ParamType.I16)]
        public short QWC_cd
        {
            get => _QWC_cd;
            set => WriteParamField(ref _QWC_cd, value);
        }
        private short _QWC_cd;

        [ParamField(0xC0, ParamType.I16)]
        public short SoulLv
        {
            get => _SoulLv;
            set => WriteParamField(ref _SoulLv, value);
        }
        private short _SoulLv;

        [ParamField(0xC2, ParamType.U8)]
        public byte BaseVit
        {
            get => _BaseVit;
            set => WriteParamField(ref _BaseVit, value);
        }
        private byte _BaseVit;

        [ParamField(0xC3, ParamType.U8)]
        public byte BaseWil
        {
            get => _BaseWil;
            set => WriteParamField(ref _BaseWil, value);
        }
        private byte _BaseWil;

        [ParamField(0xC4, ParamType.U8)]
        public byte BaseEnd
        {
            get => _BaseEnd;
            set => WriteParamField(ref _BaseEnd, value);
        }
        private byte _BaseEnd;

        [ParamField(0xC5, ParamType.U8)]
        public byte BaseStr
        {
            get => _BaseStr;
            set => WriteParamField(ref _BaseStr, value);
        }
        private byte _BaseStr;

        [ParamField(0xC6, ParamType.U8)]
        public byte BaseDex
        {
            get => _BaseDex;
            set => WriteParamField(ref _BaseDex, value);
        }
        private byte _BaseDex;

        [ParamField(0xC7, ParamType.U8)]
        public byte BaseMag
        {
            get => _BaseMag;
            set => WriteParamField(ref _BaseMag, value);
        }
        private byte _BaseMag;

        [ParamField(0xC8, ParamType.U8)]
        public byte BaseFai
        {
            get => _BaseFai;
            set => WriteParamField(ref _BaseFai, value);
        }
        private byte _BaseFai;

        [ParamField(0xC9, ParamType.U8)]
        public byte BaseLuc
        {
            get => _BaseLuc;
            set => WriteParamField(ref _BaseLuc, value);
        }
        private byte _BaseLuc;

        [ParamField(0xCA, ParamType.U8)]
        public byte BaseHeroPoint
        {
            get => _BaseHeroPoint;
            set => WriteParamField(ref _BaseHeroPoint, value);
        }
        private byte _BaseHeroPoint;

        [ParamField(0xCB, ParamType.U8)]
        public byte BaseDurability
        {
            get => _BaseDurability;
            set => WriteParamField(ref _BaseDurability, value);
        }
        private byte _BaseDurability;

        [ParamField(0xCC, ParamType.U8)]
        public byte ItemNum_01
        {
            get => _ItemNum_01;
            set => WriteParamField(ref _ItemNum_01, value);
        }
        private byte _ItemNum_01;

        [ParamField(0xCD, ParamType.U8)]
        public byte ItemNum_02
        {
            get => _ItemNum_02;
            set => WriteParamField(ref _ItemNum_02, value);
        }
        private byte _ItemNum_02;

        [ParamField(0xCE, ParamType.U8)]
        public byte ItemNum_03
        {
            get => _ItemNum_03;
            set => WriteParamField(ref _ItemNum_03, value);
        }
        private byte _ItemNum_03;

        [ParamField(0xCF, ParamType.U8)]
        public byte ItemNum_04
        {
            get => _ItemNum_04;
            set => WriteParamField(ref _ItemNum_04, value);
        }
        private byte _ItemNum_04;

        [ParamField(0xD0, ParamType.U8)]
        public byte ItemNum_05
        {
            get => _ItemNum_05;
            set => WriteParamField(ref _ItemNum_05, value);
        }
        private byte _ItemNum_05;

        [ParamField(0xD1, ParamType.U8)]
        public byte ItemNum_06
        {
            get => _ItemNum_06;
            set => WriteParamField(ref _ItemNum_06, value);
        }
        private byte _ItemNum_06;

        [ParamField(0xD2, ParamType.U8)]
        public byte ItemNum_07
        {
            get => _ItemNum_07;
            set => WriteParamField(ref _ItemNum_07, value);
        }
        private byte _ItemNum_07;

        [ParamField(0xD3, ParamType.U8)]
        public byte ItemNum_08
        {
            get => _ItemNum_08;
            set => WriteParamField(ref _ItemNum_08, value);
        }
        private byte _ItemNum_08;

        [ParamField(0xD4, ParamType.U8)]
        public byte ItemNum_09
        {
            get => _ItemNum_09;
            set => WriteParamField(ref _ItemNum_09, value);
        }
        private byte _ItemNum_09;

        [ParamField(0xD5, ParamType.U8)]
        public byte ItemNum_10
        {
            get => _ItemNum_10;
            set => WriteParamField(ref _ItemNum_10, value);
        }
        private byte _ItemNum_10;

        [ParamField(0xD6, ParamType.I8)]
        public sbyte BodyScaleHead
        {
            get => _BodyScaleHead;
            set => WriteParamField(ref _BodyScaleHead, value);
        }
        private sbyte _BodyScaleHead;

        [ParamField(0xD7, ParamType.I8)]
        public sbyte BodyScaleBreast
        {
            get => _BodyScaleBreast;
            set => WriteParamField(ref _BodyScaleBreast, value);
        }
        private sbyte _BodyScaleBreast;

        [ParamField(0xD8, ParamType.I8)]
        public sbyte BodyScaleAbdomen
        {
            get => _BodyScaleAbdomen;
            set => WriteParamField(ref _BodyScaleAbdomen, value);
        }
        private sbyte _BodyScaleAbdomen;

        [ParamField(0xD9, ParamType.I8)]
        public sbyte BodyScaleArm
        {
            get => _BodyScaleArm;
            set => WriteParamField(ref _BodyScaleArm, value);
        }
        private sbyte _BodyScaleArm;

        [ParamField(0xDA, ParamType.I8)]
        public sbyte BodyScaleLeg
        {
            get => _BodyScaleLeg;
            set => WriteParamField(ref _BodyScaleLeg, value);
        }
        private sbyte _BodyScaleLeg;

        [ParamField(0xDB, ParamType.I8)]
        public sbyte GestureId0
        {
            get => _GestureId0;
            set => WriteParamField(ref _GestureId0, value);
        }
        private sbyte _GestureId0;

        [ParamField(0xDC, ParamType.I8)]
        public sbyte GestureId1
        {
            get => _GestureId1;
            set => WriteParamField(ref _GestureId1, value);
        }
        private sbyte _GestureId1;

        [ParamField(0xDD, ParamType.I8)]
        public sbyte GestureId2
        {
            get => _GestureId2;
            set => WriteParamField(ref _GestureId2, value);
        }
        private sbyte _GestureId2;

        [ParamField(0xDE, ParamType.I8)]
        public sbyte GestureId3
        {
            get => _GestureId3;
            set => WriteParamField(ref _GestureId3, value);
        }
        private sbyte _GestureId3;

        [ParamField(0xDF, ParamType.I8)]
        public sbyte GestureId4
        {
            get => _GestureId4;
            set => WriteParamField(ref _GestureId4, value);
        }
        private sbyte _GestureId4;

        [ParamField(0xE0, ParamType.I8)]
        public sbyte GestureId5
        {
            get => _GestureId5;
            set => WriteParamField(ref _GestureId5, value);
        }
        private sbyte _GestureId5;

        [ParamField(0xE1, ParamType.I8)]
        public sbyte GestureId6
        {
            get => _GestureId6;
            set => WriteParamField(ref _GestureId6, value);
        }
        private sbyte _GestureId6;

        [ParamField(0xE2, ParamType.U8)]
        public byte NpcPlayerType
        {
            get => _NpcPlayerType;
            set => WriteParamField(ref _NpcPlayerType, value);
        }
        private byte _NpcPlayerType;

        [ParamField(0xE3, ParamType.U8)]
        public byte NpcPlayerDrawType
        {
            get => _NpcPlayerDrawType;
            set => WriteParamField(ref _NpcPlayerDrawType, value);
        }
        private byte _NpcPlayerDrawType;

        [ParamField(0xE4, ParamType.U8)]
        public byte NpcPlayerSex
        {
            get => _NpcPlayerSex;
            set => WriteParamField(ref _NpcPlayerSex, value);
        }
        private byte _NpcPlayerSex;

        #region BitField VowTypeBitfield ==============================================================================

        [ParamField(0xE5, ParamType.U8)]
        public byte VowTypeBitfield
        {
            get => _VowTypeBitfield;
            set => WriteParamField(ref _VowTypeBitfield, value);
        }
        private byte _VowTypeBitfield;

        [ParamBitField(nameof(VowTypeBitfield), bits: 4, bitsOffset: 0)]
        public byte VowType
        {
            get => GetbitfieldValue(_VowTypeBitfield);
            set => SetBitfieldValue(ref _VowTypeBitfield, value);
        }

        [ParamBitField(nameof(VowTypeBitfield), bits: 4, bitsOffset: 4)]
        public byte Pad
        {
            get => GetbitfieldValue(_VowTypeBitfield);
            set => SetBitfieldValue(ref _VowTypeBitfield, value);
        }

        #endregion BitField VowTypeBitfield

        [ParamField(0xE6, ParamType.Dummy8, 10)]
        public byte[] Pad0
        {
            get => _Pad0;
            set => WriteParamField(ref _Pad0, value);
        }
        private byte[] _Pad0;

    }
}
