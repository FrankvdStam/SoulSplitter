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
using SoulMemory.MemoryV2.Memory;

namespace SoulMemory.MemoryV2
{
    /// <summary>
    /// IMemory access to an array of memory. Allows resolving pointers and reading data/writing data.
    /// </summary>
    public class ByteArrayMemory : IMemory
    {
        private readonly byte[] _data;
        public ByteArrayMemory(byte[] data)
        {
            _data = data;
        }

        public byte[] ReadBytes(long offset, int length)
        {
            var buffer = new byte[length];
            Array.Copy(_data, offset, buffer, 0, length);
            return buffer;
        }

        public void WriteBytes(long offset, byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                _data[offset + i] = bytes[i];
            }
        }
    }
}
