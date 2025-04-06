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
using SoulSplitter.UiOld.Converters;

namespace SoulSplitter.Tests.UI.Converters
{
    [TestClass]
    public class DoubleToGridLengthConverterTests
    {
        [TestMethod]
        public void Convert()
        {
            var converter = new DoubleToGridLengthConverter();
            Assert.AreEqual(new GridLength(10.0), converter.Convert((double)10.0, null!, null, null!));
            Assert.AreEqual(new GridLength(1234.5678), converter.Convert((double)1234.5678, null!, null, null!));
        }

        [TestMethod]
        public void Convert_Throws()
        {
            var converter = new DoubleToGridLengthConverter();
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert((long)1234, null!, null, null!));
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert((float)1.4, null!, null, null!));
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert("test", null!, null, null!));
            Assert.ThrowsException<NotSupportedException>(() => converter.Convert(new object(), null!, null, null!));
        }

        [TestMethod]
        public void ConvertBack()
        {
            var converter = new DoubleToGridLengthConverter();
            Assert.AreEqual((double)10.0     , converter.ConvertBack(new GridLength(10.0), null!, null, null!));
            Assert.AreEqual((double)1234.5678, converter.ConvertBack(new GridLength(1234.5678), null!, null, null!));
        }

        [TestMethod]
        public void ConvertBack_Throws()
        {
            var converter = new DoubleToGridLengthConverter();
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack((long)1234, null!, null, null!));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack((float)1.4, null!, null, null!));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack("test", null!, null, null!));
            Assert.ThrowsException<NotSupportedException>(() => converter.ConvertBack(new object(), null!, null, null!));
        }
    }
}
