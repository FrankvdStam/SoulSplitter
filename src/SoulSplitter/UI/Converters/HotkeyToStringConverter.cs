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

using SoulSplitter.Hotkeys;
using SoulSplitter.UI.EldenRing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace SoulSplitter.UI.Converters
{
    public class HotkeyToStringConverter : IValueConverter
    {
        private static List<ModifierKeys> _modifiers = Enum.GetValues(typeof(ModifierKeys)).Cast<ModifierKeys>().Where(i => i != ModifierKeys.None).ToList();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Hotkey hotkey)
            {
                var sb = new StringBuilder();
                foreach (var modifier in _modifiers)
                {
                    if (hotkey.Modifiers.HasFlag(modifier))
                    {
                        sb.Append(modifier);
                        sb.Append(" + ");
                    }
                }
                sb.Append(hotkey.Key);
                return sb.ToString();
            }

            throw new ArgumentException($"{value} is not a {nameof(Hotkey)}", nameof(value));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "";
        }
    }
}
