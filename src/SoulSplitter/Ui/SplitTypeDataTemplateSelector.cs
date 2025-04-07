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
using SoulSplitter.Resources;
using SoulSplitter.Ui.ViewModels;

namespace SoulSplitter.Ui
{
    public class SplitTypeDataTemplateSelector : DataTemplateSelector
    {
        public ILanguageManager LanguageManager { get; set; } = null!;
        public DataTemplate EventFlagDataTemplate { get; set; } = null!;
        public DataTemplate EnumDataTemplate { get; set; } = null!;
        public DataTemplate PositionViewModelDataTemplate { get; set; } = null!;
        public DataTemplate FlagDataTemplate { get; set; } = null!;
        public DataTemplate AttributeViewModelDataTemplate { get; set; } = null!;
        public DataTemplate DefaultDataTemplate { get; set; } = new DataTemplate();

        public override DataTemplate SelectTemplate(object? item, DependencyObject container)
        {
            switch (item)
            {
                case Enum e:
                {
                    var languageItem = LanguageManager.Get(e);
                    var enumType = languageItem.GetType();

                    if (enumType == typeof(EventFlag))
                    {
                        return EventFlagDataTemplate;
                    }
                    return EnumDataTemplate;
                }
                case PositionViewModel:
                    return PositionViewModelDataTemplate;
                case int:
                    return FlagDataTemplate;
                case AttributeViewModel:
                    return AttributeViewModelDataTemplate;
                default:
                    return DefaultDataTemplate;
            }
        }
    }
}
