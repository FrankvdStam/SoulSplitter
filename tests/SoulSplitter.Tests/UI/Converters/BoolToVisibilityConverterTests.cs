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
using SoulSplitter.UI.Converters;
using System;
using System.Windows;

namespace SoulSplitter.Tests.UI.Converters
{
    [TestClass]
    public class BoolToVisibilityConverterTests
    {
        [TestMethod]
        public void Convert_Happy_Flow()
        {
            var converter = new BoolToVisibilityConverter();
            Assert.AreEqual(Visibility.Visible, converter.Convert(true, null!, null, null!));
            Assert.AreEqual(Visibility.Collapsed, converter.Convert(false, null!, null, null!));
        }

        [TestMethod]
        public void Convert_Exception()
        {
            var converter = new BoolToVisibilityConverter();
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert("test", null!, null, null!));
        }

        [TestMethod]
        public void ConvertBack_Exception()
        {
            var converter = new BoolToVisibilityConverter();
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(Visibility.Visible, null!, null, null!));
        }
    }
}
