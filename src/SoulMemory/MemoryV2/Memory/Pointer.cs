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
using System.IO;
using System.Linq;
using System.Text;

namespace SoulMemory.MemoryV2.Memory
{
    public class Pointer : IMemory
    {
        public readonly IMemory Memory;
        public List<PointerPath> Path;
        public long AbsoluteOffset = 0;

        public Pointer(IMemory memory)
        {
            if (memory is Pointer p)
            {
                throw new ArgumentException("Can't initialize pointer object with another pointer.", nameof(memory));
            }

            Memory = memory;
            Path = new List<PointerPath>();
        }

        public Pointer(IMemory memory, params long[] offsets)
        {
            if (memory is Pointer p)
            {
                throw new ArgumentException("Can't initialize pointer object with another pointer.", nameof(memory));
            }

            Memory = memory;
            Path = offsets.Select(i => new PointerPath { Address = 0, Offset = i }).ToList();
        }

        public long ResolveOffsets()
        {
            long currentAddress = AbsoluteOffset;//0 for standard pointers. Only has a value when coming from an absolute scan

            //Resolve offsets
            foreach (var step in Path)
            {
                currentAddress = Memory.ReadInt64(currentAddress + step.Offset);
                step.Address = currentAddress;
            }

            return currentAddress;
        }

        public override string ToString()
        {
            //Populate path
            ResolveOffsets();

            //Format
            var stringBuilder = new StringBuilder();
            foreach (var p in Path)
            {
                stringBuilder.AppendLine($"0x{p.Offset:x8} - 0x{p.Address:x8}");
            }

            return stringBuilder.ToString();
        }

        public byte[] ReadBytes(long offset, int length) => Memory.ReadBytes(ResolveOffsets() + offset, length);
        public void WriteBytes(long offset, byte[] bytes) => Memory.WriteBytes(ResolveOffsets() + offset, bytes);
    }
}
