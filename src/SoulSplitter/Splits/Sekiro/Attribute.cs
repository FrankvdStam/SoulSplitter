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
using System.Xml.Serialization;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splits.Sekiro
{
    [XmlType(Namespace = "Sekiro")]
    public class Attribute : ICustomNotifyPropertyChanged
    {
        [XmlElement(Namespace = "Sekiro")]
        public SoulMemory.Sekiro.Attribute AttributeType
        {
            get => _attributeType;
            set => this.SetField(ref _attributeType, value);
        }
        private SoulMemory.Sekiro.Attribute _attributeType;

        public int Level
        {
            get => _level;
            set => this.SetField(ref _level, value);
        }
        private int _level;

        public override string ToString()
        {
            return $"{AttributeType} {Level}";
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
