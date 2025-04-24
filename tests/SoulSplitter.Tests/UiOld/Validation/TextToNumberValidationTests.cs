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

using SoulSplitter.Ui.Validation;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoulSplitter.Tests.UI.Validation
{
    [TestClass]
    public class TextToNumberValidationTests
    {
        private static IEnumerable<object[]> TestCases
        {
            get
            {
                return new[]
                {
                    new object[] { "123"  , false, false, NumericType.Uint , true },
                    new object[] { "-123" , false, false, NumericType.Uint , false},
                    new object[] { "-123" , false, true , NumericType.Int  , true },
                    new object[] { "123.3", false, true , NumericType.Int  , false},
                    new object[] { "123.3", false, true , NumericType.Float, true },
                    new object[] { ""     , true , true , NumericType.Float, false},
                    new object[] { "asd"  , true , true , NumericType.Float, false},
                    new object[] { null!  , true , true , NumericType.Float, false}
                };
            }
        }
    
        [TestMethod]
        [DynamicData(nameof(TestCases))]
        public void TestDataTypes(object value, bool isRequired, bool allowNegative, NumericType numericType, bool expected)
        {
            var validator = new TextToNumberValidation { AllowNegative = allowNegative, IsRequired = isRequired, NumericType = numericType };
            Assert.AreEqual(expected, validator.Validate(value, CultureInfo.InvariantCulture).IsValid);
        }
    }
}
