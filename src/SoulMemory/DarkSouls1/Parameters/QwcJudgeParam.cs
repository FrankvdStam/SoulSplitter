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
    public class QwcJudgeParam : BaseParam
    {
        public QwcJudgeParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.I16)]
        public short PcJudgeUnderWB
        {
            get => _PcJudgeUnderWB;
            set => WriteParamField(ref _PcJudgeUnderWB, value);
        }
        private short _PcJudgeUnderWB;

        [ParamField(0x2, ParamType.I16)]
        public short PcJudgeTopWB
        {
            get => _PcJudgeTopWB;
            set => WriteParamField(ref _PcJudgeTopWB, value);
        }
        private short _PcJudgeTopWB;

        [ParamField(0x4, ParamType.I16)]
        public short PcJudgeUnderLR
        {
            get => _PcJudgeUnderLR;
            set => WriteParamField(ref _PcJudgeUnderLR, value);
        }
        private short _PcJudgeUnderLR;

        [ParamField(0x6, ParamType.I16)]
        public short PcJudgeTopLR
        {
            get => _PcJudgeTopLR;
            set => WriteParamField(ref _PcJudgeTopLR, value);
        }
        private short _PcJudgeTopLR;

        [ParamField(0x8, ParamType.I16)]
        public short AreaJudgeUnderWB
        {
            get => _AreaJudgeUnderWB;
            set => WriteParamField(ref _AreaJudgeUnderWB, value);
        }
        private short _AreaJudgeUnderWB;

        [ParamField(0xA, ParamType.I16)]
        public short AreaJudgeTopWB
        {
            get => _AreaJudgeTopWB;
            set => WriteParamField(ref _AreaJudgeTopWB, value);
        }
        private short _AreaJudgeTopWB;

        [ParamField(0xC, ParamType.I16)]
        public short AreaJudgeUnderLR
        {
            get => _AreaJudgeUnderLR;
            set => WriteParamField(ref _AreaJudgeUnderLR, value);
        }
        private short _AreaJudgeUnderLR;

        [ParamField(0xE, ParamType.I16)]
        public short AreaJudgeTopLR
        {
            get => _AreaJudgeTopLR;
            set => WriteParamField(ref _AreaJudgeTopLR, value);
        }
        private short _AreaJudgeTopLR;

    }
}
