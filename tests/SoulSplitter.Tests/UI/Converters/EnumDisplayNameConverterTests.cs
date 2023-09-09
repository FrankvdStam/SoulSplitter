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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulSplitter.UI.Converters;

namespace SoulSplitter.Tests.UI.Converters
{
    [TestClass]
    public class EnumDisplayNameConverterTests
    {
        [TestMethod]
        public void Convert_Enums()
        {
            var converter = new EnumDisplayNameConverter();
            Assert.AreEqual("Capra Demon", converter.Convert(SoulMemory.DarkSouls1.Boss.CapraDemon, null, null, null));
            Assert.AreEqual("Abandoned Cave", converter.Convert(SoulMemory.EldenRing.Grace.AbandonedCave, null, null, null));
        }

        [TestMethod]
        public void Convert_Unsupported_Type()
        {
            var converter = new EnumDisplayNameConverter();
            Assert.AreEqual("", converter.Convert(20, null, null, null));
            Assert.AreEqual("", converter.Convert(new object(), null, null, null));
            Assert.AreEqual("", converter.Convert("test", null, null, null));
        }

        [TestMethod]
        public void ConvertBack_Exception()
        {
            var converter = new EnumDisplayNameConverter();
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(20, null, null, null));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(new object(), null, null, null));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack("test", null, null, null));
        }
    }
}
