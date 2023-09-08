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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulMemory.ArmoredCore6;
using SoulSplitter.UI.Converters;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Tests.UI.Converters
{
    [TestClass]
    public class GameToSelectedIndexConverterTests
    {
        [TestMethod]
        public void Convert_Valid_Cases()
        {
            var converter = new GameToSelectedIndexConverter();

            Assert.AreEqual(0, converter.Convert(Game.DarkSouls1));
            Assert.AreEqual(1, converter.Convert(Game.DarkSouls2));
            Assert.AreEqual(2, converter.Convert(Game.DarkSouls3));
            Assert.AreEqual(3, converter.Convert(Game.Sekiro));
            Assert.AreEqual(4, converter.Convert(Game.EldenRing));
            Assert.AreEqual(5, converter.Convert(Game.ArmoredCore6));

            Assert.AreEqual(Game.DarkSouls1  , converter.ConvertBack(0));
            Assert.AreEqual(Game.DarkSouls2  , converter.ConvertBack(1));
            Assert.AreEqual(Game.DarkSouls3  , converter.ConvertBack(2));
            Assert.AreEqual(Game.Sekiro      , converter.ConvertBack(3));
            Assert.AreEqual(Game.EldenRing   , converter.ConvertBack(4));
            Assert.AreEqual(Game.ArmoredCore6, converter.ConvertBack(5));

            Assert.ThrowsException<NotSupportedException>(() => converter.Convert(""));
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert(1));
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert(new object()));

            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(""));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(Game.ArmoredCore6));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(new object()));
        }
    }
}
