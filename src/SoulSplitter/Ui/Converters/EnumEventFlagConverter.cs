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

using SoulSplitter.Resources;
using System;
using System.Globalization;
using System.Windows.Data;

namespace SoulSplitter.Ui.Converters
{
    public enum EnumEventFlagConverterTarget
    {
        NumericFlag,
        Name,
        Description,
        Location,
    }

    /// <summary>
    /// Converts an event flag enum to a language target type, name/description etc.
    /// </summary>
    public class EnumEventFlagConverter : IValueConverter
    {
        public ILanguageManager LanguageManager { get; set; } = null!;

        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is Enum key && parameter is EnumEventFlagConverterTarget target)
            {
                var obj = LanguageManager.Get(key);
                if (obj is EventFlag eventFlag)
                {
                    switch (target)
                    {
                        case EnumEventFlagConverterTarget.NumericFlag:
                            return System.Convert.ToInt32(key);
                        case EnumEventFlagConverterTarget.Name:
                            return eventFlag.Name;
                        case EnumEventFlagConverterTarget.Description:
                            return eventFlag.Description;
                        case EnumEventFlagConverterTarget.Location:
                            return eventFlag.Location;
                    }
                }
                throw new ArgumentException($"{key} is not an event flag. Cannot convert.");
            }
            throw new NotImplementedException();
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
