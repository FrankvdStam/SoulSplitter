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
    public class EnvLightTexBank : BaseParam
    {
        public EnvLightTexBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I8)]
        public sbyte IsUse
        {
            get => _IsUse;
            set => WriteParamField(ref _IsUse, value);
        }
        private sbyte _IsUse;

        [ParamField(0x1, ParamType.I8)]
        public sbyte AutoUpdate
        {
            get => _AutoUpdate;
            set => WriteParamField(ref _AutoUpdate, value);
        }
        private sbyte _AutoUpdate;

        [ParamField(0x2, ParamType.Dummy8, 12)]
        public byte[] Pad_0
        {
            get => _Pad_0;
            set => WriteParamField(ref _Pad_0, value);
        }
        private byte[] _Pad_0;

        [ParamField(0xE, ParamType.I16)]
        public short InvMulCol
        {
            get => _InvMulCol;
            set => WriteParamField(ref _InvMulCol, value);
        }
        private short _InvMulCol;

        [ParamField(0x10, ParamType.I16)]
        public short ResNameId_Dif0
        {
            get => _ResNameId_Dif0;
            set => WriteParamField(ref _ResNameId_Dif0, value);
        }
        private short _ResNameId_Dif0;

        [ParamField(0x12, ParamType.I16)]
        public short InvMulCol_Dif0
        {
            get => _InvMulCol_Dif0;
            set => WriteParamField(ref _InvMulCol_Dif0, value);
        }
        private short _InvMulCol_Dif0;

        [ParamField(0x14, ParamType.F32)]
        public float SepcPow_Dif0
        {
            get => _SepcPow_Dif0;
            set => WriteParamField(ref _SepcPow_Dif0, value);
        }
        private float _SepcPow_Dif0;

        [ParamField(0x18, ParamType.Dummy8, 8)]
        public byte[] Pad_Dif0
        {
            get => _Pad_Dif0;
            set => WriteParamField(ref _Pad_Dif0, value);
        }
        private byte[] _Pad_Dif0;

        [ParamField(0x20, ParamType.I16)]
        public short ResNameId_Spc0
        {
            get => _ResNameId_Spc0;
            set => WriteParamField(ref _ResNameId_Spc0, value);
        }
        private short _ResNameId_Spc0;

        [ParamField(0x22, ParamType.I16)]
        public short InvMulCol_Spc0
        {
            get => _InvMulCol_Spc0;
            set => WriteParamField(ref _InvMulCol_Spc0, value);
        }
        private short _InvMulCol_Spc0;

        [ParamField(0x24, ParamType.F32)]
        public float SepcPow_Spc0
        {
            get => _SepcPow_Spc0;
            set => WriteParamField(ref _SepcPow_Spc0, value);
        }
        private float _SepcPow_Spc0;

        [ParamField(0x28, ParamType.Dummy8, 8)]
        public byte[] Pad_Spc0
        {
            get => _Pad_Spc0;
            set => WriteParamField(ref _Pad_Spc0, value);
        }
        private byte[] _Pad_Spc0;

        [ParamField(0x30, ParamType.I16)]
        public short ResNameId_Spc1
        {
            get => _ResNameId_Spc1;
            set => WriteParamField(ref _ResNameId_Spc1, value);
        }
        private short _ResNameId_Spc1;

        [ParamField(0x32, ParamType.I16)]
        public short InvMulCol_Spc1
        {
            get => _InvMulCol_Spc1;
            set => WriteParamField(ref _InvMulCol_Spc1, value);
        }
        private short _InvMulCol_Spc1;

        [ParamField(0x34, ParamType.F32)]
        public float SepcPow_Spc1
        {
            get => _SepcPow_Spc1;
            set => WriteParamField(ref _SepcPow_Spc1, value);
        }
        private float _SepcPow_Spc1;

        [ParamField(0x38, ParamType.Dummy8, 8)]
        public byte[] Pad_Spc1
        {
            get => _Pad_Spc1;
            set => WriteParamField(ref _Pad_Spc1, value);
        }
        private byte[] _Pad_Spc1;

        [ParamField(0x40, ParamType.I16)]
        public short ResNameId_Spc2
        {
            get => _ResNameId_Spc2;
            set => WriteParamField(ref _ResNameId_Spc2, value);
        }
        private short _ResNameId_Spc2;

        [ParamField(0x42, ParamType.I16)]
        public short InvMulCol_Spc2
        {
            get => _InvMulCol_Spc2;
            set => WriteParamField(ref _InvMulCol_Spc2, value);
        }
        private short _InvMulCol_Spc2;

        [ParamField(0x44, ParamType.F32)]
        public float SepcPow_Spc2
        {
            get => _SepcPow_Spc2;
            set => WriteParamField(ref _SepcPow_Spc2, value);
        }
        private float _SepcPow_Spc2;

        [ParamField(0x48, ParamType.Dummy8, 8)]
        public byte[] Pad_Spc2
        {
            get => _Pad_Spc2;
            set => WriteParamField(ref _Pad_Spc2, value);
        }
        private byte[] _Pad_Spc2;

        [ParamField(0x50, ParamType.I16)]
        public short ResNameId_Spc3
        {
            get => _ResNameId_Spc3;
            set => WriteParamField(ref _ResNameId_Spc3, value);
        }
        private short _ResNameId_Spc3;

        [ParamField(0x52, ParamType.I16)]
        public short InvMulCol_Spc3
        {
            get => _InvMulCol_Spc3;
            set => WriteParamField(ref _InvMulCol_Spc3, value);
        }
        private short _InvMulCol_Spc3;

        [ParamField(0x54, ParamType.F32)]
        public float SepcPow_Spc3
        {
            get => _SepcPow_Spc3;
            set => WriteParamField(ref _SepcPow_Spc3, value);
        }
        private float _SepcPow_Spc3;

        [ParamField(0x58, ParamType.Dummy8, 8)]
        public byte[] Pad_Spc3
        {
            get => _Pad_Spc3;
            set => WriteParamField(ref _Pad_Spc3, value);
        }
        private byte[] _Pad_Spc3;

        [ParamField(0x60, ParamType.I16)]
        public short DegRotX_00
        {
            get => _DegRotX_00;
            set => WriteParamField(ref _DegRotX_00, value);
        }
        private short _DegRotX_00;

        [ParamField(0x62, ParamType.I16)]
        public short DegRotY_00
        {
            get => _DegRotY_00;
            set => WriteParamField(ref _DegRotY_00, value);
        }
        private short _DegRotY_00;

        [ParamField(0x64, ParamType.I16)]
        public short ColR_00
        {
            get => _ColR_00;
            set => WriteParamField(ref _ColR_00, value);
        }
        private short _ColR_00;

        [ParamField(0x66, ParamType.I16)]
        public short ColG_00
        {
            get => _ColG_00;
            set => WriteParamField(ref _ColG_00, value);
        }
        private short _ColG_00;

        [ParamField(0x68, ParamType.I16)]
        public short ColB_00
        {
            get => _ColB_00;
            set => WriteParamField(ref _ColB_00, value);
        }
        private short _ColB_00;

        [ParamField(0x6A, ParamType.I16)]
        public short ColA_00
        {
            get => _ColA_00;
            set => WriteParamField(ref _ColA_00, value);
        }
        private short _ColA_00;

        [ParamField(0x6C, ParamType.Dummy8, 4)]
        public byte[] Pad_00
        {
            get => _Pad_00;
            set => WriteParamField(ref _Pad_00, value);
        }
        private byte[] _Pad_00;

        [ParamField(0x70, ParamType.I16)]
        public short DegRotX_01
        {
            get => _DegRotX_01;
            set => WriteParamField(ref _DegRotX_01, value);
        }
        private short _DegRotX_01;

        [ParamField(0x72, ParamType.I16)]
        public short DegRotY_01
        {
            get => _DegRotY_01;
            set => WriteParamField(ref _DegRotY_01, value);
        }
        private short _DegRotY_01;

        [ParamField(0x74, ParamType.I16)]
        public short ColR_01
        {
            get => _ColR_01;
            set => WriteParamField(ref _ColR_01, value);
        }
        private short _ColR_01;

        [ParamField(0x76, ParamType.I16)]
        public short ColG_01
        {
            get => _ColG_01;
            set => WriteParamField(ref _ColG_01, value);
        }
        private short _ColG_01;

        [ParamField(0x78, ParamType.I16)]
        public short ColB_01
        {
            get => _ColB_01;
            set => WriteParamField(ref _ColB_01, value);
        }
        private short _ColB_01;

        [ParamField(0x7A, ParamType.I16)]
        public short ColA_01
        {
            get => _ColA_01;
            set => WriteParamField(ref _ColA_01, value);
        }
        private short _ColA_01;

        [ParamField(0x7C, ParamType.Dummy8, 4)]
        public byte[] Pad_01
        {
            get => _Pad_01;
            set => WriteParamField(ref _Pad_01, value);
        }
        private byte[] _Pad_01;

        [ParamField(0x80, ParamType.I16)]
        public short DegRotX_02
        {
            get => _DegRotX_02;
            set => WriteParamField(ref _DegRotX_02, value);
        }
        private short _DegRotX_02;

        [ParamField(0x82, ParamType.I16)]
        public short DegRotY_02
        {
            get => _DegRotY_02;
            set => WriteParamField(ref _DegRotY_02, value);
        }
        private short _DegRotY_02;

        [ParamField(0x84, ParamType.I16)]
        public short ColR_02
        {
            get => _ColR_02;
            set => WriteParamField(ref _ColR_02, value);
        }
        private short _ColR_02;

        [ParamField(0x86, ParamType.I16)]
        public short ColG_02
        {
            get => _ColG_02;
            set => WriteParamField(ref _ColG_02, value);
        }
        private short _ColG_02;

        [ParamField(0x88, ParamType.I16)]
        public short ColB_02
        {
            get => _ColB_02;
            set => WriteParamField(ref _ColB_02, value);
        }
        private short _ColB_02;

        [ParamField(0x8A, ParamType.I16)]
        public short ColA_02
        {
            get => _ColA_02;
            set => WriteParamField(ref _ColA_02, value);
        }
        private short _ColA_02;

        [ParamField(0x8C, ParamType.Dummy8, 4)]
        public byte[] Pad_02
        {
            get => _Pad_02;
            set => WriteParamField(ref _Pad_02, value);
        }
        private byte[] _Pad_02;

        [ParamField(0x90, ParamType.I16)]
        public short DegRotX_03
        {
            get => _DegRotX_03;
            set => WriteParamField(ref _DegRotX_03, value);
        }
        private short _DegRotX_03;

        [ParamField(0x92, ParamType.I16)]
        public short DegRotY_03
        {
            get => _DegRotY_03;
            set => WriteParamField(ref _DegRotY_03, value);
        }
        private short _DegRotY_03;

        [ParamField(0x94, ParamType.I16)]
        public short ColR_03
        {
            get => _ColR_03;
            set => WriteParamField(ref _ColR_03, value);
        }
        private short _ColR_03;

        [ParamField(0x96, ParamType.I16)]
        public short ColG_03
        {
            get => _ColG_03;
            set => WriteParamField(ref _ColG_03, value);
        }
        private short _ColG_03;

        [ParamField(0x98, ParamType.I16)]
        public short ColB_03
        {
            get => _ColB_03;
            set => WriteParamField(ref _ColB_03, value);
        }
        private short _ColB_03;

        [ParamField(0x9A, ParamType.I16)]
        public short ColA_03
        {
            get => _ColA_03;
            set => WriteParamField(ref _ColA_03, value);
        }
        private short _ColA_03;

        [ParamField(0x9C, ParamType.Dummy8, 4)]
        public byte[] Pad_03
        {
            get => _Pad_03;
            set => WriteParamField(ref _Pad_03, value);
        }
        private byte[] _Pad_03;

        [ParamField(0xA0, ParamType.I16)]
        public short DegRotX_04
        {
            get => _DegRotX_04;
            set => WriteParamField(ref _DegRotX_04, value);
        }
        private short _DegRotX_04;

        [ParamField(0xA2, ParamType.I16)]
        public short DegRotY_04
        {
            get => _DegRotY_04;
            set => WriteParamField(ref _DegRotY_04, value);
        }
        private short _DegRotY_04;

        [ParamField(0xA4, ParamType.I16)]
        public short ColR_04
        {
            get => _ColR_04;
            set => WriteParamField(ref _ColR_04, value);
        }
        private short _ColR_04;

        [ParamField(0xA6, ParamType.I16)]
        public short ColG_04
        {
            get => _ColG_04;
            set => WriteParamField(ref _ColG_04, value);
        }
        private short _ColG_04;

        [ParamField(0xA8, ParamType.I16)]
        public short ColB_04
        {
            get => _ColB_04;
            set => WriteParamField(ref _ColB_04, value);
        }
        private short _ColB_04;

        [ParamField(0xAA, ParamType.I16)]
        public short ColA_04
        {
            get => _ColA_04;
            set => WriteParamField(ref _ColA_04, value);
        }
        private short _ColA_04;

        [ParamField(0xAC, ParamType.Dummy8, 4)]
        public byte[] Pad_04
        {
            get => _Pad_04;
            set => WriteParamField(ref _Pad_04, value);
        }
        private byte[] _Pad_04;

        [ParamField(0xB0, ParamType.I16)]
        public short DegRotX_05
        {
            get => _DegRotX_05;
            set => WriteParamField(ref _DegRotX_05, value);
        }
        private short _DegRotX_05;

        [ParamField(0xB2, ParamType.I16)]
        public short DegRotY_05
        {
            get => _DegRotY_05;
            set => WriteParamField(ref _DegRotY_05, value);
        }
        private short _DegRotY_05;

        [ParamField(0xB4, ParamType.I16)]
        public short ColR_05
        {
            get => _ColR_05;
            set => WriteParamField(ref _ColR_05, value);
        }
        private short _ColR_05;

        [ParamField(0xB6, ParamType.I16)]
        public short ColG_05
        {
            get => _ColG_05;
            set => WriteParamField(ref _ColG_05, value);
        }
        private short _ColG_05;

        [ParamField(0xB8, ParamType.I16)]
        public short ColB_05
        {
            get => _ColB_05;
            set => WriteParamField(ref _ColB_05, value);
        }
        private short _ColB_05;

        [ParamField(0xBA, ParamType.I16)]
        public short ColA_05
        {
            get => _ColA_05;
            set => WriteParamField(ref _ColA_05, value);
        }
        private short _ColA_05;

        [ParamField(0xBC, ParamType.Dummy8, 4)]
        public byte[] Pad_05
        {
            get => _Pad_05;
            set => WriteParamField(ref _Pad_05, value);
        }
        private byte[] _Pad_05;

        [ParamField(0xC0, ParamType.I16)]
        public short DegRotX_06
        {
            get => _DegRotX_06;
            set => WriteParamField(ref _DegRotX_06, value);
        }
        private short _DegRotX_06;

        [ParamField(0xC2, ParamType.I16)]
        public short DegRotY_06
        {
            get => _DegRotY_06;
            set => WriteParamField(ref _DegRotY_06, value);
        }
        private short _DegRotY_06;

        [ParamField(0xC4, ParamType.I16)]
        public short ColR_06
        {
            get => _ColR_06;
            set => WriteParamField(ref _ColR_06, value);
        }
        private short _ColR_06;

        [ParamField(0xC6, ParamType.I16)]
        public short ColG_06
        {
            get => _ColG_06;
            set => WriteParamField(ref _ColG_06, value);
        }
        private short _ColG_06;

        [ParamField(0xC8, ParamType.I16)]
        public short ColB_06
        {
            get => _ColB_06;
            set => WriteParamField(ref _ColB_06, value);
        }
        private short _ColB_06;

        [ParamField(0xCA, ParamType.I16)]
        public short ColA_06
        {
            get => _ColA_06;
            set => WriteParamField(ref _ColA_06, value);
        }
        private short _ColA_06;

        [ParamField(0xCC, ParamType.Dummy8, 4)]
        public byte[] Pad_06
        {
            get => _Pad_06;
            set => WriteParamField(ref _Pad_06, value);
        }
        private byte[] _Pad_06;

        [ParamField(0xD0, ParamType.I16)]
        public short DegRotX_07
        {
            get => _DegRotX_07;
            set => WriteParamField(ref _DegRotX_07, value);
        }
        private short _DegRotX_07;

        [ParamField(0xD2, ParamType.I16)]
        public short DegRotY_07
        {
            get => _DegRotY_07;
            set => WriteParamField(ref _DegRotY_07, value);
        }
        private short _DegRotY_07;

        [ParamField(0xD4, ParamType.I16)]
        public short ColR_07
        {
            get => _ColR_07;
            set => WriteParamField(ref _ColR_07, value);
        }
        private short _ColR_07;

        [ParamField(0xD6, ParamType.I16)]
        public short ColG_07
        {
            get => _ColG_07;
            set => WriteParamField(ref _ColG_07, value);
        }
        private short _ColG_07;

        [ParamField(0xD8, ParamType.I16)]
        public short ColB_07
        {
            get => _ColB_07;
            set => WriteParamField(ref _ColB_07, value);
        }
        private short _ColB_07;

        [ParamField(0xDA, ParamType.I16)]
        public short ColA_07
        {
            get => _ColA_07;
            set => WriteParamField(ref _ColA_07, value);
        }
        private short _ColA_07;

        [ParamField(0xDC, ParamType.Dummy8, 4)]
        public byte[] Pad_07
        {
            get => _Pad_07;
            set => WriteParamField(ref _Pad_07, value);
        }
        private byte[] _Pad_07;

        [ParamField(0xE0, ParamType.I16)]
        public short DegRotX_08
        {
            get => _DegRotX_08;
            set => WriteParamField(ref _DegRotX_08, value);
        }
        private short _DegRotX_08;

        [ParamField(0xE2, ParamType.I16)]
        public short DegRotY_08
        {
            get => _DegRotY_08;
            set => WriteParamField(ref _DegRotY_08, value);
        }
        private short _DegRotY_08;

        [ParamField(0xE4, ParamType.I16)]
        public short ColR_08
        {
            get => _ColR_08;
            set => WriteParamField(ref _ColR_08, value);
        }
        private short _ColR_08;

        [ParamField(0xE6, ParamType.I16)]
        public short ColG_08
        {
            get => _ColG_08;
            set => WriteParamField(ref _ColG_08, value);
        }
        private short _ColG_08;

        [ParamField(0xE8, ParamType.I16)]
        public short ColB_08
        {
            get => _ColB_08;
            set => WriteParamField(ref _ColB_08, value);
        }
        private short _ColB_08;

        [ParamField(0xEA, ParamType.I16)]
        public short ColA_08
        {
            get => _ColA_08;
            set => WriteParamField(ref _ColA_08, value);
        }
        private short _ColA_08;

        [ParamField(0xEC, ParamType.Dummy8, 4)]
        public byte[] Pad_08
        {
            get => _Pad_08;
            set => WriteParamField(ref _Pad_08, value);
        }
        private byte[] _Pad_08;

        [ParamField(0xF0, ParamType.I16)]
        public short DegRotX_09
        {
            get => _DegRotX_09;
            set => WriteParamField(ref _DegRotX_09, value);
        }
        private short _DegRotX_09;

        [ParamField(0xF2, ParamType.I16)]
        public short DegRotY_09
        {
            get => _DegRotY_09;
            set => WriteParamField(ref _DegRotY_09, value);
        }
        private short _DegRotY_09;

        [ParamField(0xF4, ParamType.I16)]
        public short ColR_09
        {
            get => _ColR_09;
            set => WriteParamField(ref _ColR_09, value);
        }
        private short _ColR_09;

        [ParamField(0xF6, ParamType.I16)]
        public short ColG_09
        {
            get => _ColG_09;
            set => WriteParamField(ref _ColG_09, value);
        }
        private short _ColG_09;

        [ParamField(0xF8, ParamType.I16)]
        public short ColB_09
        {
            get => _ColB_09;
            set => WriteParamField(ref _ColB_09, value);
        }
        private short _ColB_09;

        [ParamField(0xFA, ParamType.I16)]
        public short ColA_09
        {
            get => _ColA_09;
            set => WriteParamField(ref _ColA_09, value);
        }
        private short _ColA_09;

        [ParamField(0xFC, ParamType.Dummy8, 4)]
        public byte[] Pad_09
        {
            get => _Pad_09;
            set => WriteParamField(ref _Pad_09, value);
        }
        private byte[] _Pad_09;

    }
}
