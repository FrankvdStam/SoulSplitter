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
using System.Windows.Data;
using System.Windows.Media;

namespace SoulSplitter.UI.Converters;

public class ColorToHexTextConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Color color)
        {
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        throw new NotSupportedException($"Type not supported {targetType}");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string hex)
        {
            try
            {
                int rgb = System.Convert.ToInt32(hex.Remove(0, 1), 16);
                var r = (byte)((rgb & 0xff0000) >> 16);
                var g = (byte)((rgb & 0xff00) >> 8);
                var b = (byte)(rgb & 0xff);
                return Color.FromRgb(r, g, b);
            }
            catch
            {
                throw new ArgumentException($"{hex} is not a valid RGB hex");
            }
        }

        throw new NotSupportedException($"Type not supported {targetType}");
    }
}
