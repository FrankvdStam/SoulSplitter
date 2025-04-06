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
using System.Windows;
using SoulMemory.Enums;

namespace SoulSplitterUIv2.Resources
{
    public class LanguageManager : ILanguageManager
    {
        private ResourceDictionary _languageDictionary = null!;

        /// <inheritdoc />
        public Language CurrentLanguage { get; set; }

        /// <inheritdoc />
        public event CurrentLanguageChangedEventHandler? OnLanguageChanged;

        /// <inheritdoc />
        public void LoadLanguage(Language language)
        {
            _languageDictionary = new ResourceDictionary();
            _languageDictionary.Source = new Uri($"pack://application:,,,/SoulSplitterUIv2;component/Resources/{language}/Language.xaml", UriKind.RelativeOrAbsolute);

            for (int i = 0; i < Application.Current.Resources.MergedDictionaries.Count; i++)
            {
                var dict = Application.Current.Resources.MergedDictionaries[i];
                if (dict.Contains("Language"))
                {
                    Application.Current.Resources.MergedDictionaries[i] = _languageDictionary;
                    break;
                }
            }

            CurrentLanguage = language;
            OnLanguageChanged?.Invoke(this, CurrentLanguage);
        }

        /// <inheritdoc />
        public object Get(object key) => _languageDictionary[key];
    }
}
