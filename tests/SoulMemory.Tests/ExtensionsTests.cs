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
using System.Xml;

namespace SoulMemory.Tests
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public void Xml_GetChildByName_Single()
        {
            var doc = new XmlDocument();
            doc.LoadXml(@"<outer>
                              <inner>test</inner>
                          </outer>");
            var inner = doc.GetChildNodeByName("outer").GetChildNodeByName("inner");
            Assert.IsNotNull(inner);
            Assert.AreEqual("test", inner.InnerText);
        }

        [TestMethod]
        public void Xml_GetChildByName_Multiple()
        {
            var doc = new XmlDocument();
            doc.LoadXml(@"<outer>
                              <inner1>test1</inner1>
                              <inner2>test2</inner2>
                              <inner3>test3</inner3>
                              <inner4>test4</inner4>
                              <inner5>test5</inner5>
                          </outer>");
            var inner = doc.GetChildNodeByName("outer").GetChildNodeByName("inner4");
            Assert.IsNotNull(inner);
            Assert.AreEqual("test4", inner.InnerText);
        }

        [TestMethod]
        public void Xml_Enumerate()
        {
            var doc = new XmlDocument();
            doc.LoadXml(@"<outer>
                              <inner1>test1</inner1>
                              <inner2>test2</inner2>
                              <inner3>test3</inner3>
                              <inner4>test4</inner4>
                              <inner5>test5</inner5>
                          </outer>");
            var list = doc.GetChildNodeByName("outer").ChildNodes.Enumerate().ToList();
            Assert.AreEqual(5, list.Count);
            Assert.AreEqual("test1", list[0].InnerText);
            Assert.AreEqual("test2", list[1].InnerText);
            Assert.AreEqual("test3", list[2].InnerText);
            Assert.AreEqual("test4", list[3].InnerText);
            Assert.AreEqual("test5", list[4].InnerText);
        }


        [DataTestMethod]
        [DataRow(1, 0, true)]
        [DataRow(429983647, 21, true)]
        [DataRow(8200589659459, 23, false)]
        public void IsBitSet_Tests(long data, int index, bool expected)
        {
            Assert.AreEqual(expected, data.IsBitSet(index));
        }

        [DataTestMethod]
        [DataRow(15, 0, 1, 2, 3)]
        [DataRow(4163, 0, 1, 6, 12)]
        [DataRow(8200589659459, 0, 1, 6, 8, 10, 11, 14, 15, 16, 17, 19, 20, 21, 24, 27, 28, 30, 32, 34, 36, 37, 38, 40, 41, 42)]
        public void SetBit_Tests(long expected, params int[] bits)
        {
            long data = 0;
            foreach (var bit in bits)
            {
                data = data.SetBit(bit);
            }
            Assert.AreEqual(expected, data);
        }

        [DataTestMethod]
        [DataRow(0, 15, 0, 1, 2, 3)]
        [DataRow(0, 4163, 0, 1, 6, 12)]
        [DataRow(0, 8200589659459, 0, 1, 6, 8, 10, 11, 14, 15, 16, 17, 19, 20, 21, 24, 27, 28, 30, 32, 34, 36, 37, 38, 40, 41, 42)]
        public void ClearBit_Tests(long expected, long input, params int[] bits)
        {
            foreach (var bit in bits)
            {
                input = input.ClearBit(bit);
            }
            Assert.AreEqual(expected, input);
        }
    }
}
