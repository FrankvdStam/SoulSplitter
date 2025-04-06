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
using System.Globalization;
using System.Windows.Controls;

namespace SoulSplitterUIv2.Ui.Validation;

public enum NumericType
{
    Int,
    Uint,
    Float
}


public class TextToNumberValidation : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {

        if (value == null)
        {
            if (IsRequired)
            {
                return new ValidationResult(false, "Value is required");
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }

        if (value is not string text)
        {
            return new ValidationResult(false, "Input is not a valid text");
        }

        if (string.IsNullOrWhiteSpace(text) && IsRequired)
        {
            return new ValidationResult(false, "Value is required");
        }

        switch (NumericType)
        {
            default:
                throw new ArgumentException($"Unsupported type {NumericType}");

            case NumericType.Int:
                if (!int.TryParse(text, out var i))
                {
                    return new ValidationResult(false, "Input is not a valid number");
                }

                if (!AllowNegative && i < 0)
                {
                    return new ValidationResult(false, "Input can not be negative");
                }

                if (MinValue is int min && i < min)
                {
                    return new ValidationResult(false, $"Input can not be less than {min}");
                }

                if (MaxValue is int max && i > max)
                {
                    return new ValidationResult(false, $"Input can not be less than {max}");
                }

                return new ValidationResult(true, null);

            case NumericType.Uint:
                if (!uint.TryParse(text, out var u))
                {
                    return new ValidationResult(false, "Input is not a valid positive number");
                }

                if (MinValue is uint umin && u < umin)
                {
                    return new ValidationResult(false, $"Input can not be less than {umin}");
                }

                if (MaxValue is uint umax && u > umax)
                {
                    return new ValidationResult(false, $"Input can not be less than {umax}");
                }

                return new ValidationResult(true, null);

            case NumericType.Float:
                if (!float.TryParse(text, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out var f))
                {
                    return new ValidationResult(false, "Input is not a valid decimal number");
                }

                if (!AllowNegative && f < 0)
                {
                    return new ValidationResult(false, "Input can not be negative");
                }

                if (MinValue is float fmin && f < fmin)
                {
                    return new ValidationResult(false, $"Input can not be less than {fmin}");
                }

                if (MaxValue is float fmax && f > fmax)
                {
                    return new ValidationResult(false, $"Input can not be less than {fmax}");
                }

                return new ValidationResult(true, null);
        }
    }

    public bool IsRequired { get; set; }
    public bool AllowNegative { get; set; } = true;
    public NumericType NumericType { get; set; } = NumericType.Int;
    public object MinValue { get; set; }
    public object MaxValue { get; set; }
}
