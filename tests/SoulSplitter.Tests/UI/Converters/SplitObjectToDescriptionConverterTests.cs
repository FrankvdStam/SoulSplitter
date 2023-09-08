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
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Tests.UI.Converters
{
    [TestClass]
    public class SplitObjectToDescriptionConverterTests
    {
        [TestMethod]
        public void Convert_Enum()
        {
            var converter = new SplitObjectToDescriptionConverter();
            Assert.AreEqual("The Bed of Chaos", converter.Convert(SoulMemory.DarkSouls1.Boss.BedOfChaos));
            Assert.AreEqual("Beside the Rampart Gaol", converter.Convert(SoulMemory.EldenRing.Grace.BesideTheRampartGaol));
        }

        [TestMethod]
        public void Convert_Object_ToString()
        {
            var converter = new SplitObjectToDescriptionConverter();
            Assert.AreEqual("12345 Test flag", converter.Convert(new FlagDescription(){ Description = "Test flag", Flag = 12345}));
            Assert.AreEqual("Dexterity 10", converter.Convert(new SoulSplitter.Splits.DarkSouls1.Attribute{AttributeType = SoulMemory.DarkSouls1.Attribute.Dexterity, Level = 10}));
        }

        [TestMethod]
        public void Convert_Uint()
        {
            var converter = new SplitObjectToDescriptionConverter();
            Assert.AreEqual((uint)12345, converter.Convert((uint)12345));
            Assert.AreEqual((uint)999999, converter.Convert((uint)999999));
        }

        [TestMethod]
        public void Convert_Other_Types()
        {
            var converter = new SplitObjectToDescriptionConverter();
            Assert.AreEqual("", converter.Convert((long)12345));
            Assert.AreEqual("", converter.Convert((float)999999));
            Assert.AreEqual("", converter.Convert((double)1.2));
            Assert.AreEqual("", converter.Convert(new Color()));
        }

        [TestMethod]
        public void ConvertBack()
        {
            var converter = new SplitObjectToDescriptionConverter();
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(new FlagDescription() { Description = "Test flag", Flag = 12345 }));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack((uint)12345));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack((long)12345));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack((float)999999));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack((double)1.2));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(new Color()));
        }
    }
}
