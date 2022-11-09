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

using System;
using System.Collections.Generic;
using System.Text;

namespace SoulMemory.MemoryV2
{
    /// <summary>
    /// A TreeBuilder lets you define a data tree, from scans and offsets, that end in pointers.
    /// The tree doesn't do anything on it's own, but you can pass it to the MemoryScanner to resolve the pointers,
    /// or to validate the patterns.
    /// </summary>
    public class TreeBuilder
    {
        internal List<Node> Tree = new List<Node>();

        public PointerAppender ScanRelative(string name, string pattern, long addressOffset, long instructionSize)
        {
            var node = new Node
            {
                NodeType = NodeType.RelativeScan,
                Name = name,
                Pattern = pattern,
                AddressOffset = addressOffset,
                InstructionSize = instructionSize,
            };
            Tree.Add(node);
            return new PointerAppender(node);
        }

        public PointerAppender ScanAbsolute(string name, string pattern, long? offset)
        {
            var node = new Node
            {
                NodeType = NodeType.AbsoluteScan,
                Name = name,
                Pattern = pattern,
                Offset = offset,
            };
            Tree.Add(node);
            return new PointerAppender(node);
        }
    }
}
