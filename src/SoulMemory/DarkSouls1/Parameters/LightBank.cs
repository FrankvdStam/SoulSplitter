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

namespace SoulMemory.DarkSouls1.Parameters
{
    public class LightBank : BaseParam
    {
        public LightBank(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I16)]
        public short DegRotX_0
        {
            get => _DegRotX_0;
            set => WriteParamField(ref _DegRotX_0, value);
        }
        private short _DegRotX_0;

        [ParamField(0x2, ParamType.I16)]
        public short DegRotY_0
        {
            get => _DegRotY_0;
            set => WriteParamField(ref _DegRotY_0, value);
        }
        private short _DegRotY_0;

        [ParamField(0x4, ParamType.I16)]
        public short ColR_0
        {
            get => _ColR_0;
            set => WriteParamField(ref _ColR_0, value);
        }
        private short _ColR_0;

        [ParamField(0x6, ParamType.I16)]
        public short ColG_0
        {
            get => _ColG_0;
            set => WriteParamField(ref _ColG_0, value);
        }
        private short _ColG_0;

        [ParamField(0x8, ParamType.I16)]
        public short ColB_0
        {
            get => _ColB_0;
            set => WriteParamField(ref _ColB_0, value);
        }
        private short _ColB_0;

        [ParamField(0xA, ParamType.I16)]
        public short ColA_0
        {
            get => _ColA_0;
            set => WriteParamField(ref _ColA_0, value);
        }
        private short _ColA_0;

        [ParamField(0xC, ParamType.I16)]
        public short DegRotX_1
        {
            get => _DegRotX_1;
            set => WriteParamField(ref _DegRotX_1, value);
        }
        private short _DegRotX_1;

        [ParamField(0xE, ParamType.I16)]
        public short DegRotY_1
        {
            get => _DegRotY_1;
            set => WriteParamField(ref _DegRotY_1, value);
        }
        private short _DegRotY_1;

        [ParamField(0x10, ParamType.I16)]
        public short ColR_1
        {
            get => _ColR_1;
            set => WriteParamField(ref _ColR_1, value);
        }
        private short _ColR_1;

        [ParamField(0x12, ParamType.I16)]
        public short ColG_1
        {
            get => _ColG_1;
            set => WriteParamField(ref _ColG_1, value);
        }
        private short _ColG_1;

        [ParamField(0x14, ParamType.I16)]
        public short ColB_1
        {
            get => _ColB_1;
            set => WriteParamField(ref _ColB_1, value);
        }
        private short _ColB_1;

        [ParamField(0x16, ParamType.I16)]
        public short ColA_1
        {
            get => _ColA_1;
            set => WriteParamField(ref _ColA_1, value);
        }
        private short _ColA_1;

        [ParamField(0x18, ParamType.I16)]
        public short DegRotX_2
        {
            get => _DegRotX_2;
            set => WriteParamField(ref _DegRotX_2, value);
        }
        private short _DegRotX_2;

        [ParamField(0x1A, ParamType.I16)]
        public short DegRotY_2
        {
            get => _DegRotY_2;
            set => WriteParamField(ref _DegRotY_2, value);
        }
        private short _DegRotY_2;

        [ParamField(0x1C, ParamType.I16)]
        public short ColR_2
        {
            get => _ColR_2;
            set => WriteParamField(ref _ColR_2, value);
        }
        private short _ColR_2;

        [ParamField(0x1E, ParamType.I16)]
        public short ColG_2
        {
            get => _ColG_2;
            set => WriteParamField(ref _ColG_2, value);
        }
        private short _ColG_2;

        [ParamField(0x20, ParamType.I16)]
        public short ColB_2
        {
            get => _ColB_2;
            set => WriteParamField(ref _ColB_2, value);
        }
        private short _ColB_2;

        [ParamField(0x22, ParamType.I16)]
        public short ColA_2
        {
            get => _ColA_2;
            set => WriteParamField(ref _ColA_2, value);
        }
        private short _ColA_2;

        [ParamField(0x24, ParamType.I16)]
        public short ColR_u
        {
            get => _ColR_u;
            set => WriteParamField(ref _ColR_u, value);
        }
        private short _ColR_u;

        [ParamField(0x26, ParamType.I16)]
        public short ColG_u
        {
            get => _ColG_u;
            set => WriteParamField(ref _ColG_u, value);
        }
        private short _ColG_u;

        [ParamField(0x28, ParamType.I16)]
        public short ColB_u
        {
            get => _ColB_u;
            set => WriteParamField(ref _ColB_u, value);
        }
        private short _ColB_u;

        [ParamField(0x2A, ParamType.I16)]
        public short ColA_u
        {
            get => _ColA_u;
            set => WriteParamField(ref _ColA_u, value);
        }
        private short _ColA_u;

        [ParamField(0x2C, ParamType.I16)]
        public short ColR_d
        {
            get => _ColR_d;
            set => WriteParamField(ref _ColR_d, value);
        }
        private short _ColR_d;

        [ParamField(0x2E, ParamType.I16)]
        public short ColG_d
        {
            get => _ColG_d;
            set => WriteParamField(ref _ColG_d, value);
        }
        private short _ColG_d;

        [ParamField(0x30, ParamType.I16)]
        public short ColB_d
        {
            get => _ColB_d;
            set => WriteParamField(ref _ColB_d, value);
        }
        private short _ColB_d;

        [ParamField(0x32, ParamType.I16)]
        public short ColA_d
        {
            get => _ColA_d;
            set => WriteParamField(ref _ColA_d, value);
        }
        private short _ColA_d;

        [ParamField(0x34, ParamType.I16)]
        public short DegRotX_s
        {
            get => _DegRotX_s;
            set => WriteParamField(ref _DegRotX_s, value);
        }
        private short _DegRotX_s;

        [ParamField(0x36, ParamType.I16)]
        public short DegRotY_s
        {
            get => _DegRotY_s;
            set => WriteParamField(ref _DegRotY_s, value);
        }
        private short _DegRotY_s;

        [ParamField(0x38, ParamType.I16)]
        public short ColR_s
        {
            get => _ColR_s;
            set => WriteParamField(ref _ColR_s, value);
        }
        private short _ColR_s;

        [ParamField(0x3A, ParamType.I16)]
        public short ColG_s
        {
            get => _ColG_s;
            set => WriteParamField(ref _ColG_s, value);
        }
        private short _ColG_s;

        [ParamField(0x3C, ParamType.I16)]
        public short ColB_s
        {
            get => _ColB_s;
            set => WriteParamField(ref _ColB_s, value);
        }
        private short _ColB_s;

        [ParamField(0x3E, ParamType.I16)]
        public short ColA_s
        {
            get => _ColA_s;
            set => WriteParamField(ref _ColA_s, value);
        }
        private short _ColA_s;

        [ParamField(0x40, ParamType.I16)]
        public short EnvDif_colR
        {
            get => _EnvDif_colR;
            set => WriteParamField(ref _EnvDif_colR, value);
        }
        private short _EnvDif_colR;

        [ParamField(0x42, ParamType.I16)]
        public short EnvDif_colG
        {
            get => _EnvDif_colG;
            set => WriteParamField(ref _EnvDif_colG, value);
        }
        private short _EnvDif_colG;

        [ParamField(0x44, ParamType.I16)]
        public short EnvDif_colB
        {
            get => _EnvDif_colB;
            set => WriteParamField(ref _EnvDif_colB, value);
        }
        private short _EnvDif_colB;

        [ParamField(0x46, ParamType.I16)]
        public short EnvDif_colA
        {
            get => _EnvDif_colA;
            set => WriteParamField(ref _EnvDif_colA, value);
        }
        private short _EnvDif_colA;

        [ParamField(0x48, ParamType.I16)]
        public short EnvSpc_colR
        {
            get => _EnvSpc_colR;
            set => WriteParamField(ref _EnvSpc_colR, value);
        }
        private short _EnvSpc_colR;

        [ParamField(0x4A, ParamType.I16)]
        public short EnvSpc_colG
        {
            get => _EnvSpc_colG;
            set => WriteParamField(ref _EnvSpc_colG, value);
        }
        private short _EnvSpc_colG;

        [ParamField(0x4C, ParamType.I16)]
        public short EnvSpc_colB
        {
            get => _EnvSpc_colB;
            set => WriteParamField(ref _EnvSpc_colB, value);
        }
        private short _EnvSpc_colB;

        [ParamField(0x4E, ParamType.I16)]
        public short EnvSpc_colA
        {
            get => _EnvSpc_colA;
            set => WriteParamField(ref _EnvSpc_colA, value);
        }
        private short _EnvSpc_colA;

        [ParamField(0x50, ParamType.I16)]
        public short EnvDif
        {
            get => _EnvDif;
            set => WriteParamField(ref _EnvDif, value);
        }
        private short _EnvDif;

        [ParamField(0x52, ParamType.I16)]
        public short EnvSpc_0
        {
            get => _EnvSpc_0;
            set => WriteParamField(ref _EnvSpc_0, value);
        }
        private short _EnvSpc_0;

        [ParamField(0x54, ParamType.I16)]
        public short EnvSpc_1
        {
            get => _EnvSpc_1;
            set => WriteParamField(ref _EnvSpc_1, value);
        }
        private short _EnvSpc_1;

        [ParamField(0x56, ParamType.I16)]
        public short EnvSpc_2
        {
            get => _EnvSpc_2;
            set => WriteParamField(ref _EnvSpc_2, value);
        }
        private short _EnvSpc_2;

        [ParamField(0x58, ParamType.I16)]
        public short EnvSpc_3
        {
            get => _EnvSpc_3;
            set => WriteParamField(ref _EnvSpc_3, value);
        }
        private short _EnvSpc_3;

        [ParamField(0x5A, ParamType.Dummy8, 2)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad;

    }
}
