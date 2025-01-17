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
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace SoulSplitter.UI.Converters;

public class EnumToVisibilityConverter : IMultiValueConverter, IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        var valueEnum = (Enum)value;
        var paramEnum = (Enum)parameter;
        if (valueEnum != null && paramEnum != null && valueEnum.Equals(paramEnum))
        {
            return Visibility.Visible;
        }
        return Visibility.Collapsed;
    }

    public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (values == null || parameter == null)
        {
            throw new ArgumentException($"{nameof(values)} and {nameof(parameter)} can't be null");
        }

        var valueEnums = values.Cast<Enum>().ToList();
        var paramEnums = ((object[])parameter).Cast<Enum>().ToList();

        if (valueEnums.Count != paramEnums.Count)
        {
            throw new ArgumentException("value count should match parameter count");
        }

        if (valueEnums.Where((t, i) => !t.Equals(paramEnums[i])).Any())
        {
            return Visibility.Collapsed;
        }

        return Visibility.Visible;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotSupportedException();
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
