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
using SoulSplitter.UI.Validation;

namespace SoulSplitter.Tests.UI.Validation
{
    [TestClass]
    public class TextToRgbHexValidatorTests
    {
        [TestMethod]
        public void Validate()
        {
            var validator = new TextToRgbHexValidator();
            Assert.IsTrue(validator.Validate("#123456", null!).IsValid);
            Assert.IsTrue(validator.Validate("#A2C4DD", null!).IsValid);
        }


        [TestMethod]
        public void Validate_Invalid_Hex()
        {
            var validator = new TextToRgbHexValidator();
            Assert.IsFalse(validator.Validate("123456", null!).IsValid);
            Assert.IsFalse(validator.Validate("#12345G", null!).IsValid);
            Assert.IsFalse(validator.Validate("test", null!).IsValid);
            Assert.AreEqual("test is not a valid RGB hex", validator.Validate("test", null!).ErrorContent);
        }
    }
}
