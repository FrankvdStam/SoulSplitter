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
using System.Linq;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulSplitter.UI.Converters;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Tests.UI.Converters
{
    [TestClass]
    public class EnumToVisibilityConverterTests
    {
        [TestMethod]
        public void Convert_Single_Enum()
        {
            var converter = new EnumToVisibilityConverter();

            Assert.AreEqual(Visibility.Visible, converter.Convert(SplitType.Attribute, null, SplitType.Attribute, null));
            Assert.AreEqual(Visibility.Visible, converter.Convert(SplitType.Boss, null, SplitType.Boss, null));
            Assert.AreEqual(Visibility.Visible, converter.Convert(SplitType.Bonfire, null, SplitType.Bonfire, null));

            Assert.AreEqual(Visibility.Collapsed, converter.Convert(SplitType.Attribute, null, SplitType.Boss, null));
            Assert.AreEqual(Visibility.Collapsed, converter.Convert(SplitType.Boss, null, SplitType.Bonfire, null));
            Assert.AreEqual(Visibility.Collapsed, converter.Convert(SplitType.Bonfire, null, SplitType.Attribute, null));

            Assert.AreEqual(Visibility.Collapsed, converter.Convert((object)null, null, null, null));
            Assert.AreEqual(Visibility.Collapsed, converter.Convert(SplitType.Attribute, null, null, null));
            Assert.AreEqual(Visibility.Collapsed, converter.Convert((object)null, null, null, null));

            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(SplitType.Attribute, (Type)null, SplitType.Attribute, null));
        }

        [TestMethod]
        public void Convert_Multiple_Enums()
        {
            var converter = new EnumToVisibilityConverter();

            Assert.AreEqual(Visibility.Visible, converter.Convert(
                new[] { (object)SplitType.Attribute, (object)GameType.DarkSouls1 }, null,
                new[] { (object)SplitType.Attribute, (object)GameType.DarkSouls1 }, null));
            
            //Index based logic. Maybe have to fix that.
            Assert.AreEqual(Visibility.Collapsed, converter.Convert(
                new[] { (object)SplitType.Bonfire, (object)GameType.EldenRing }, null,
                new[] { (object)GameType.EldenRing, (object)SplitType.Bonfire }, null));

            Assert.AreEqual(Visibility.Collapsed, converter.Convert(
                new[] { (object)SplitType.Attribute, (object)GameType.EldenRing }, null,
                new[] { (object)GameType.EldenRing, (object)SplitType.Bonfire }, null));
        }


        [TestMethod]
        public void Convert_Multi_Enum_Exceptions()
        {
            var converter = new EnumToVisibilityConverter();
            
            Assert.ThrowsException<ArgumentException>(() => converter.Convert(null, null, new[]{ SplitType.Attribute }, null));
            Assert.ThrowsException<ArgumentException>(() => converter.Convert(new[] { SplitType.Attribute }.Cast<object>().ToArray(), null, null, null));

            Assert.ThrowsException<ArgumentException>(() => converter.Convert(
                new[] { (object)SplitType.Attribute, (object)GameType.DarkSouls1 }, null,
                new[] { (object)SplitType.Attribute }, null));

            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(SplitType.Attribute, (Type[])null, SplitType.Attribute, null));
        }
    }
}
