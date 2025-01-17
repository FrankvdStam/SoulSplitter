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

using System.ComponentModel;

namespace SoulSplitter.UI.Generic
{
    public class FlagDescription : ICustomNotifyPropertyChanged
    {
        public uint Flag
        {
            get => _flag;
            set => this.SetField(ref _flag, value);
        }
        private uint _flag;

        public string Description
        {
            get => _description;
            set => this.SetField(ref _description, value);
        }
        private string _description = "";

        public bool State
        {
            get => _state;
            set => this.SetField(ref _state, value);
        }
        private bool _state;

        public override string ToString()
        {
            return $"{Flag} {Description}";
        }


        #region ICustomNotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        public void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
