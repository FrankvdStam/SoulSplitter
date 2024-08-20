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
using System.Windows.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulSplitter.UI.Converters;

namespace SoulSplitter.Tests.UI.Converters
{
    [TestClass]
    public class ColorToHexTextConverterTests
    {
        [TestMethod]
        public void Convert()
        {
            var converter = new ColorToHexTextConverter();
            Assert.AreEqual("#000000", converter.Convert(Colors.Black, null, null, null));
            Assert.AreEqual("#8A2BE2", converter.Convert(Colors.BlueViolet, null, null, null));
            Assert.AreEqual("#8B0000", converter.Convert(Colors.DarkRed, null, null, null));
        }

        [TestMethod]
        public void Convert_Throws()
        {
            var converter = new ColorToHexTextConverter();
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert((long)1234, null, null, null));
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert((float)1.4, null, null, null));
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert("Test", null, null, null));
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert(new object(), null, null, null));
        }

        [TestMethod]
        public void ConvertBack()
        {
            var converter = new ColorToHexTextConverter();
            Assert.AreEqual(Colors.Black     , converter.ConvertBack("#000000", null, null, null));
            Assert.AreEqual(Colors.BlueViolet, converter.ConvertBack("#8A2BE2", null, null, null));
            Assert.AreEqual(Colors.DarkRed   , converter.ConvertBack("#8B0000", null, null, null));
        }

        [TestMethod]
        public void Convert_Back_Throws()
        {
            var converter = new ColorToHexTextConverter();
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack((long)1234, null, null, null));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack((float)1.4, null, null, null));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(new object(), null, null, null));
            Assert.ThrowsException<ArgumentException>(()     => converter.ConvertBack("Test", null, null, null));
        }
    }
}
