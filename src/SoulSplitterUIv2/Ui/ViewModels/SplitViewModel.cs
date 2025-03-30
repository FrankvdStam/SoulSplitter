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

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SoulMemory.Enums;

namespace SoulSplitterUIv2.Ui.ViewModels
{
    public class SplitViewModel : INotifyPropertyChanged
    {
        public SplitViewModel(){}

        public SplitViewModel(Game game, int newGamePlusLevel, TimingType timingType, SplitType splitType, object split, string userDescription)
        {
            Game = game;
            NewGamePlusLevel = newGamePlusLevel;
            TimingType = timingType;
            SplitType = splitType;
            Split = split;
            Description = userDescription;
        }

        #region Bindable
        public string Description { get; set; }

        public Game Game { get; set; }
        public int NewGamePlusLevel { get; set; }
        public TimingType TimingType { get; set; }
        public SplitType SplitType { get; set; }
        public object Split{ get; set; }

        #endregion

        #region INotifyPropertyChanged
        private bool SetField<TField>(ref TField field, TField value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<TField>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion
    }
}
