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
using System.Linq;
using SoulMemory.MemoryV2.Memory;

namespace SoulMemory.MemoryV2.PointerTreeBuilder
{
    /// <summary>
    /// Define a structure of relative and absolute scans, resulting in a tree of pointers
    /// Resolve the scans against an IMemory instance
    /// </summary>
    public class PointerTreeBuilder
    {
        public List<PointerNode> Tree = new List<PointerNode>();

        public PointerAppender ScanRelative(string name, string pattern, long addressOffset, long instructionSize)
        {
            var node = new PointerNode
            {
                PointerNodeType = PointerNodeType.RelativeScan,
                Name = name,
                Pattern = pattern,
                AddressOffset = addressOffset,
                InstructionSize = instructionSize,
            };
            Tree.Add(node);
            return new PointerAppender(node);
        }

        public PointerAppender ScanAbsolute(string name, string pattern, long offset)
        {
            var node = new PointerNode
            {
                PointerNodeType = PointerNodeType.AbsoluteScan,
                Name = name,
                Pattern = pattern,
                Offset = offset,
            };
            Tree.Add(node);
            return new PointerAppender(node);
        }

        #region Resolving pointers ==============================================================================================================================

        /// <summary>
        /// Resolve pointers to their correct address by scanning for patterns in a running process
        /// </summary>
        public ResultErr<RefreshError> TryResolvePointers(IMemory memory, long baseAddress, int memorySize, bool is64Bit)
        {
            var bytes = memory.ReadBytes(baseAddress, memorySize);

            //Resolve nodes with the above data
            var errors = new List<string>();
            foreach (var node in Tree)
            {
                long scanResult = 0;
                bool success = false;
                switch (node.PointerNodeType)
                {
                    default:
                        return Result.Err(new RefreshError(RefreshErrorReason.ScansFailed, $"Incorrect node type at base level: {node.PointerNodeType}"));

                    case PointerNodeType.RelativeScan:
                        success = bytes.TryScanRelative(baseAddress, node, out scanResult);
                        if (success)
                        {
                            foreach (var p in node.Pointers)
                            {
                                var temp = node.Offsets.ToList();
                                temp.Insert(0, scanResult);
                                var offsets = temp.ToArray();

                                p.Pointer.Path = offsets.Select(i => new PointerPath { Address = 0, Offset = i }).ToList();
                            }
                        }
                        break;

                    case PointerNodeType.AbsoluteScan:
                        success = bytes.TryScanAbsolute(baseAddress, node, out scanResult);
                        if (success)
                        {
                            foreach (var p in node.Pointers)
                            {
                                p.Pointer.AbsoluteOffset = scanResult;
                            }
                        }
                        break;
                }

                if (!success)
                {
                    errors.Add(node.Name);
                }
            }

            if (errors.Any())
            {
                return Result.Err(new RefreshError(RefreshErrorReason.ScansFailed, $"Scans failed for {string.Join(", ", errors)}"));
            }
            return Result.Ok();
        }
        #endregion
    }
}
