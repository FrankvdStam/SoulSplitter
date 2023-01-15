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

using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace SoulSplitter.UI.Validation
{
    internal class TextToRgbHexConverter : ValidationRule
    {
        private static readonly Regex _rgbValidator = new Regex("^#(?:[0-9a-fA-F]{3}){1,2}$");

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is string hex)
            {
                if(_rgbValidator.Match(hex).Success)
                {
                    return new ValidationResult(true, null);
                }
            }
            return new ValidationResult(false, $"{value} is not a valid RGB hex");
        }
    }
}
