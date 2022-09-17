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
using System.Windows.Data;
using SoulMemory.EldenRing;
using SoulMemory.Memory;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.UI.Converters
{
    public class SplitObjectToDescriptionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Enum e)
            {
                return e.GetDisplayName();
            }

            if (value is Item i)
            {
                return i.Name;
            }

            if (value is FlagDescription f)
            {
                return f.ToString();
            }

            if (value is uint u)
            {
                return u;
            }

            if (value?.GetType().IsClass ?? false)
            {
                return value.ToString();
            }
            
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
