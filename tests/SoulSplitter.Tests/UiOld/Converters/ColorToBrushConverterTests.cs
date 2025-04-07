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
using System.Windows.Media;
using SoulSplitter.Ui.Converters;

namespace SoulSplitter.Tests.Ui.Converters
{
    [TestClass]
    public class ColorToBrushConverterTests
    {
        [TestMethod]
        public void Convert_Happy_Flow()
        {
            var converter = new ColorToBrushConverter();
            var color = new Color
            {
                A = 1,
                R = 2,
                G = 3,
                B = 4
            };

            var brush = converter.Convert(color, null!, null, null!);
            Assert.IsInstanceOfType<SolidColorBrush>(brush);
            Assert.AreEqual("#01020304", ((SolidColorBrush)brush).Color.ToString());
        }

        [TestMethod]
        public void Convert_Exception()
        {
            var converter = new ColorToBrushConverter();
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert("test", null!, null, null!));
        }

        [TestMethod]
        public void ConvertBack_Exception()
        {
            var converter = new ColorToBrushConverter();
            Assert.ThrowsException<NotImplementedException>(() => converter.ConvertBack(new SolidColorBrush(), null!, null, null!));
        }
    }
}
