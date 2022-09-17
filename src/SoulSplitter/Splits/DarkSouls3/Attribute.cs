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
using System.Xml.Serialization;

namespace SoulSplitter.Splits.DarkSouls3
{
    [XmlType(Namespace = "DarkSouls3")]
    public class Attribute : INotifyPropertyChanged
    {
        [XmlElement(Namespace = "DarkSouls3")]
        public SoulMemory.DarkSouls3.Attribute AttributeType
        {
            get => _attributeType;
            set => SetField(ref _attributeType, value);
        }
        private SoulMemory.DarkSouls3.Attribute _attributeType;

        public int Level
        {
            get => _level;
            set => SetField(ref _level, value);
        }
        private int _level;

        public override string ToString()
        {
            return $"{AttributeType} {Level}";
        }

        #region INotifyPropertyChanged
        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
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
