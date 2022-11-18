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

using NUnit.Framework;
using SoulSplitter.UI.Validation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSplitter.Tests.UI.Validation
{
    [TestFixture]
    public class TextToNumberValidationTests
    {
        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData("123", false, false, NumericType.Uint).Returns(true);
                yield return new TestCaseData("-123", false, false, NumericType.Uint).Returns(false);
                yield return new TestCaseData("-123", false, true, NumericType.Int).Returns(true);
                yield return new TestCaseData("123.3", false, true, NumericType.Int).Returns(false);
                yield return new TestCaseData("123.3", false, true, NumericType.Float).Returns(true);
                yield return new TestCaseData("", true, true, NumericType.Float).Returns(false);
                yield return new TestCaseData("asd", true, true, NumericType.Float).Returns(false);
                yield return new TestCaseData(null, true, true, NumericType.Float).Returns(false);
            }
        }

        [Test, TestCaseSource("TestCases")]
        public bool TestDataTypes(object value, bool isRequired, bool allowNegative, NumericType numericType)
        {
            var validator = new TextToNumberValidation { AllowNegative = allowNegative, IsRequired = isRequired, NumericType = numericType };
            return validator.Validate(value, CultureInfo.InvariantCulture).IsValid;
        }
    }
}
