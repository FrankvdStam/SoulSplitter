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

using SoulMemory.Enums;

namespace SoulSplitterUIv2.Resources
{
    public delegate void CurrentLanguageChangedEventHandler(object sender, Language newLanguage);

    public interface ILanguageManager
    {
        /// <summary>
        /// Load the given language
        /// </summary>
        void LoadLanguage(Language language);

        /// <summary>
        /// Returns the current selected and loaded language
        /// </summary>
        Language CurrentLanguage { get; }

        /// <summary>
        /// Event raised whenever a new language is loaded
        /// </summary>
        event CurrentLanguageChangedEventHandler OnLanguageChanged;

        /// <summary>
        /// Attempt to retrieve a language specific object of the current selected language with the given key
        /// </summary>
        object Get(object key);
    }
}
