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
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulMemory.Enums;
using SoulSplitter.Ui.Converters;

namespace SoulSplitter.Tests.Ui.Converters
{
    [TestClass]
    public class SplitTypeVisibilityConverterTests
    {
        [TestMethod]
        public void Convert()
        {
            var converter = new SplitTypeVisibilityConverter();
            Assert.AreEqual(Visibility.Visible, converter.Convert(SplitType.Attribute, null!, "Attribute", null!));
            Assert.AreEqual(Visibility.Visible, converter.Convert(SplitType.Boss, null!, "Boss", null!));
            Assert.AreEqual(Visibility.Visible, converter.Convert(SplitType.Bonfire, null!, "Bonfire", null!));

            Assert.AreEqual(Visibility.Collapsed, converter.Convert(SplitType.Attribute, null!, "Boss", null!));
            Assert.AreEqual(Visibility.Collapsed, converter.Convert(SplitType.Boss, null!, "Bonfire", null!));
            Assert.AreEqual(Visibility.Collapsed, converter.Convert(SplitType.Bonfire, null!, "Attribute", null!));

            Assert.AreEqual(Visibility.Collapsed, converter.Convert("test", null!, "Attribute", null!));
            Assert.AreEqual(Visibility.Collapsed, converter.Convert(SplitType.Bonfire, null!, new object(), null!));
        }

        [TestMethod]
        public void ConvertBack()
        {
            var converter = new SplitTypeVisibilityConverter();
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(SplitType.Attribute, null!, "Attribute", null!));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(SplitType.Boss, null!, "Bonfire", null!));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(SplitType.Bonfire, null!, new object(), null!));
        }
    }
}
