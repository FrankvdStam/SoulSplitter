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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulMemory.MemoryV2;
using SoulMemory.MemoryV2.Memory;

namespace SoulMemory.Tests.MemoryV2
{
    [TestClass]
    public class MemoryTests
    {
        private static readonly byte[] PointerJumpsTestData = new byte[]
        {
            //Ptr to address 8
            0x8,  0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            //Ptr to address 16
            0x10, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            //Ptr to address 24
            0x18, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            //Ptr to address 32
            0x20, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            //End
            0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
        };

        [TestMethod]
        public void Pointer64_PointerBaseAddressTests()
        {
            var memory = new ByteArrayMemory(PointerJumpsTestData);

            Assert.AreEqual(8, memory.Pointer64(0x0).ResolveOffsets());
            Assert.AreEqual(16, memory.Pointer64(0x0, 0x0).ResolveOffsets());
            Assert.AreEqual(24, memory.Pointer64(0x0, 0x0, 0x0).ResolveOffsets());
            Assert.AreEqual(32, memory.Pointer64(0x0, 0x0, 0x0, 0x0).ResolveOffsets());

            Assert.AreEqual(8, memory.Pointer64(0x0).ResolveOffsets());
            Assert.AreEqual(16, memory.Pointer64(0x0).Pointer64(0x0).ResolveOffsets());
            Assert.AreEqual(24, memory.Pointer64(0x0).Pointer64(0x0).Pointer64(0x0).ResolveOffsets());
            Assert.AreEqual(32, memory.Pointer64(0x0).Pointer64(0x0).Pointer64(0x0).Pointer64(0x0).ResolveOffsets());
        }

        [TestMethod]
        public void Pointer64_PointerRelativeReadsTests()
        {
            var memory = new ByteArrayMemory(PointerJumpsTestData);

            var ptr1 = memory.Pointer64(0x0);
            Assert.AreEqual(16, ptr1.ReadInt64(0));
            Assert.AreEqual(24, ptr1.ReadInt64(8));
            Assert.AreEqual(32, ptr1.ReadInt64(16));

            var ptr2 = memory.Pointer64(0x0, 0x0);
            Assert.AreEqual(24, ptr2.ReadInt64(0));
            Assert.AreEqual(32, ptr2.ReadInt64(8));

            ptr2 = memory.Pointer64(0x0).Pointer64(0x0);
            Assert.AreEqual(24, ptr2.ReadInt64(0));
            Assert.AreEqual(32, ptr2.ReadInt64(8));

            var ptr3 = memory.Pointer64(0x0, 0x0, 0x0);
            Assert.AreEqual(32, ptr3.ReadInt64(0));

            ptr3 = memory.Pointer64(0x0).Pointer64(0x0).Pointer64(0x0);
            Assert.AreEqual(32, ptr3.ReadInt64(0));

            var testy = ptr3.ToString();
        }


        private static readonly byte[] DataTypesTestData = new byte[]
        {
            //Ptr to address 8
            0x8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                
            //Byte/sbyte
            0xa3,
                
            //short/ushort
            0x23, 0xff,

            //int/uint
            //0x4a, 0xff, 0x23, 0xff,
            0x32, 0xF5, 0x53, 0xff,

            //long/ulong
            0x32, 0xF5, 0x53, 0xff, 0x32, 0xF5, 0x53, 0xff,

            //float
            0xff, 0x7a, 0xfa, 0x42,

            //double
            0x66, 0x66, 0x66, 0x66, 0x66, 0xf6, 0x55, 0x40,
        };


        [TestMethod]
        public void MemoryExtensions_DataTypes()
        {
            var memory = new ByteArrayMemory(DataTypesTestData);
            var ptr = memory.Pointer64(0x0);

            var f = BitConverter.GetBytes(125.24f);
            var da = BitConverter.GetBytes(87.85d);

            var a = memory.ReadFloat(23);
            var d = memory.ReadDouble(27);
            var v = memory.ReadUInt64(15);

            Assert.AreEqual(-93, memory.ReadSByte(8));
            Assert.AreEqual(163, memory.ReadByte(8));
            Assert.AreEqual(-93, ptr.ReadSByte(0));
            Assert.AreEqual(163, ptr.ReadByte(0));

            Assert.AreEqual(-221, memory.ReadInt16(9));
            Assert.AreEqual(65315, memory.ReadUInt16(9));
            Assert.AreEqual(-221, ptr.ReadInt16(1));
            Assert.AreEqual(65315, ptr.ReadUInt16(1));

            Assert.AreEqual(-11274958, memory.ReadInt32(11));
            Assert.AreEqual(4283692338, memory.ReadUInt32(11));
            Assert.AreEqual(-11274958, ptr.ReadInt32(3));
            Assert.AreEqual(4283692338, ptr.ReadUInt32(3));

            Assert.AreEqual(-48425571590081230, memory.ReadInt64(15));
            Assert.AreEqual(18398318502119470386, memory.ReadUInt64(15));
            Assert.AreEqual(-48425571590081230, ptr.ReadInt64(7));
            Assert.AreEqual(18398318502119470386, ptr.ReadUInt64(7));

            Assert.AreEqual(125.24022674560547, memory.ReadFloat(23));
            Assert.AreEqual(125.24022674560547, ptr.ReadFloat(15));
            Assert.AreEqual(87.85, memory.ReadDouble(27));
            Assert.AreEqual(87.85, ptr.ReadDouble(19));
        }
    }
}
