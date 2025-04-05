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
using System.Windows.Controls;
using System.Windows;
using SoulSplitterUIv2.Resources;
using SoulSplitterUIv2.Ui.ViewModels;

namespace SoulSplitterUIv2.Ui
{
    public class SplitTypeDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EventFlagDataTemplate { get; set; }
        public DataTemplate EnumDataTemplate { get; set; }
        public DataTemplate PositionViewModelDataTemplate { get; set; }
        public DataTemplate FlagDataTemplate { get; set; }

        public ILanguageManager LanguageManager { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
            {
                return null;
            }

            if (item is Enum e)
            {
                var languageItem = LanguageManager.Get(e);
                var enumType = languageItem.GetType();

                if (enumType == typeof(EventFlag))
                {
                    return EventFlagDataTemplate;
                }
                return EnumDataTemplate;
            }

            if (item is PositionViewModel)
            {
                return PositionViewModelDataTemplate;
            }

            if (item is int)
            {
                return FlagDataTemplate;
            }

            return EnumDataTemplate;
        }
    }
}
