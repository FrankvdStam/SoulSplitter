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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using SoulMemory.Memory;

namespace SoulSplitter.UI.Generic
{
    public class EnumFlagViewModel<T> : ICustomNotifyPropertyChanged where T : Enum
    {
        public EnumFlagViewModel(T tEnum)
        {
            Value = tEnum;
            Name = Value.GetDisplayName();
            Area = Value.GetDisplayDescription();
            Flag = Convert.ToUInt32(Value);
        }
        
        public T Value
        {
            get => _value;
            set => this.SetField(ref _value, value);
        }
        private T _value = default(T)!;

        public string Area
        {
            get => _area;
            set => this.SetField(ref _area, value);
        }
        private string _area = null!;

        public string Name
        {
            get => _name;
            set => this.SetField(ref _name, value);
        }
        private string _name = null!;

        public uint Flag
        {
            get => _flag;
            set => this.SetField(ref _flag, value);
        }
        private uint _flag;

        /// <summary>
        /// Used to compare items in the filtered combobox
        /// </summary>
        public override string ToString()
        {
            return Name;
        }

        #region ICustomNotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        public void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        public static ObservableCollection<EnumFlagViewModel<T>> GetEnumViewModels()
        {
            return new ObservableCollection<EnumFlagViewModel<T>>(Enum.GetValues(typeof(T)).Cast<T>().Select(i => new EnumFlagViewModel<T>(i)));
        }
    }
}
