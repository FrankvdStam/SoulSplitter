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
    public class BoolDescriptionViewModel : ICustomNotifyPropertyChanged
    {
        public string Description
        {
            get => _description;
            set => this.SetField(ref _description, value);
        }
        private string _description = "";

        public bool Value
        {
            get => _value;
            set => this.SetField(ref _value, value);
        }
        private bool _value;

        public override string ToString()
        {
            return $"{Value} {Description}";
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
