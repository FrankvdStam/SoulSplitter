using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SoulSplitter.UI.Validation
{
    internal enum NumericType
    {
        Int,
        Uint,
        Float,
    }


    internal class TextToNumberValidation : ValidationRule
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

            if (value.GetType() != typeof(string))
            {
                return new ValidationResult(false, "Input is not a valid text");
            }

            var text = value as string;
            if (string.IsNullOrWhiteSpace(text) && IsRequired)
            {
                return new ValidationResult(false, "Value is required");
            }

            switch (NumericType)
            {
                default:
                    throw new Exception($"Unsupported type {NumericType}");

                case NumericType.Int:
                    if (!int.TryParse(text, out int i))
                    {
                        return new ValidationResult(false, "Input is not a valid number");
                    }
                    
                    if (!AllowNegative && i < 0)
                    {
                        return new ValidationResult(false, "Input can not be negative");
                    }
                    
                    return new ValidationResult(true, null);

                case NumericType.Uint:
                    if (!uint.TryParse(text, out uint u))
                    {
                        return new ValidationResult(false, "Input is not a valid positive number");
                    }

                    return new ValidationResult(true, null);

                case NumericType.Float:
                    if (!float.TryParse(text, out float f))
                    {
                        return new ValidationResult(false, "Input is not a valid decimal number");
                    }

                    if (!AllowNegative && f < 0)
                    {
                        return new ValidationResult(false, "Input can not be negative");
                    }

                    return new ValidationResult(true, null);
            }
        }

        public bool IsRequired { get; set; } = false;
        public bool AllowNegative { get; set; } = true;
        public NumericType NumericType { get; set; } = NumericType.Int;

    }
}
