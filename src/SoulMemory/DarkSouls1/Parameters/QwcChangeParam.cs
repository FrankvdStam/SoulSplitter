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
    public class QwcChangeParam : BaseParam
    {
        public QwcChangeParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I16)]
        public short PcAttrB
        {
            get => _PcAttrB;
            set => WriteParamField(ref _PcAttrB, value);
        }
        private short _PcAttrB;

        [ParamField(0x2, ParamType.I16)]
        public short PcAttrW
        {
            get => _PcAttrW;
            set => WriteParamField(ref _PcAttrW, value);
        }
        private short _PcAttrW;

        [ParamField(0x4, ParamType.I16)]
        public short PcAttrL
        {
            get => _PcAttrL;
            set => WriteParamField(ref _PcAttrL, value);
        }
        private short _PcAttrL;

        [ParamField(0x6, ParamType.I16)]
        public short PcAttrR
        {
            get => _PcAttrR;
            set => WriteParamField(ref _PcAttrR, value);
        }
        private short _PcAttrR;

        [ParamField(0x8, ParamType.I16)]
        public short AreaAttrB
        {
            get => _AreaAttrB;
            set => WriteParamField(ref _AreaAttrB, value);
        }
        private short _AreaAttrB;

        [ParamField(0xA, ParamType.I16)]
        public short AreaAttrW
        {
            get => _AreaAttrW;
            set => WriteParamField(ref _AreaAttrW, value);
        }
        private short _AreaAttrW;

        [ParamField(0xC, ParamType.I16)]
        public short AreaAttrL
        {
            get => _AreaAttrL;
            set => WriteParamField(ref _AreaAttrL, value);
        }
        private short _AreaAttrL;

        [ParamField(0xE, ParamType.I16)]
        public short AreaAttrR
        {
            get => _AreaAttrR;
            set => WriteParamField(ref _AreaAttrR, value);
        }
        private short _AreaAttrR;

    }
}
