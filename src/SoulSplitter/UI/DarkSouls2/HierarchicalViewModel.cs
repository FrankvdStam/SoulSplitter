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
using System.Xml.Serialization;
using SoulMemory;
using SoulSplitter.Splits.DarkSouls2;
using SoulSplitter.UI.Generic;
using Attribute = SoulSplitter.Splits.DarkSouls2.Attribute;

namespace SoulSplitter.UI.DarkSouls2
{
    [XmlType(Namespace = "DarkSouls2")]
    public class HierarchicalTimingTypeViewModel : ICustomNotifyPropertyChanged
    {
        public TimingType TimingType
        {
            get => _timingType;
            set => this.SetField(ref _timingType, value);
        }
        private TimingType _timingType;
        
        public ObservableCollection<HierarchicalSplitTypeViewModel> Children { get; set; } = new ObservableCollection<HierarchicalSplitTypeViewModel>();

        #region ICustomNotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        public void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

    [XmlType(Namespace = "DarkSouls2")]
    public class HierarchicalSplitTypeViewModel : ICustomNotifyPropertyChanged
    {
        [XmlIgnore]
        [NonSerialized]
        public HierarchicalTimingTypeViewModel? Parent;

        public DarkSouls2SplitType SplitType
        {
            get => _splitType;
            set => this.SetField(ref _splitType, value);
        }
        private DarkSouls2SplitType _splitType;


        public ObservableCollection<HierarchicalSplitViewModel> Children { get; set; } = new ObservableCollection<HierarchicalSplitViewModel>();

        #region ICustomNotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        public void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }


    [XmlType(Namespace = "DarkSouls2")]
    [XmlInclude(typeof(Vector3f)), 
     XmlInclude(typeof(BossKill)), 
     XmlInclude(typeof(Attribute)), 
     XmlInclude(typeof(uint))]
    public class HierarchicalSplitViewModel : ICustomNotifyPropertyChanged
    {
        [XmlIgnore]
        [NonSerialized]
        public HierarchicalSplitTypeViewModel? Parent;

        [XmlElement(Namespace = "DarkSouls2")]
        public object Split
        {
            get => _split;
            set => this.SetField(ref _split, value);
        }
        private object _split = null!;

        #region ICustomNotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        public void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
