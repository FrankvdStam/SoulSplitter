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

using System.Collections.Generic;

namespace SoulMemory.Memory
{
    internal class Node
    {
        public NodeType NodeType;

        //Used for scans
        public string Name = "";
        public string Pattern = "";

        //Used for relative scans
        public long AddressOffset;
        public long InstructionSize;

        //used for absolute scans
        public long? Offset;

        //used for pointers
        public long[] Offsets = new long[] { };
        public Pointer Pointer = new Pointer();

        public List<Node> Pointers = new List<Node>();

        public override string ToString() => Name;
    }
}
