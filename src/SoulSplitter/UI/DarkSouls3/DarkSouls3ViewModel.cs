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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using SoulMemory.DarkSouls3;
using SoulSplitter.UI.Generic;
using Attribute = SoulSplitter.Splits.DarkSouls3.Attribute;
using SplitType = SoulSplitter.Splits.DarkSouls3.SplitType;

namespace SoulSplitter.UI.DarkSouls3
{
    public class DarkSouls3ViewModel : INotifyPropertyChanged
    {
        public bool StartAutomatically
        {
            get => _startAutomatically;
            set => SetField(ref _startAutomatically, value);
        }
        private bool _startAutomatically = true;

        #region add/remove splits ============================================================================================================================================
        public void AddSplit()
        {
            if (NewSplitTimingType == null ||
                NewSplitType == null ||
                NewSplitValue == null)
            {
                return;
            }

            var hierarchicalTimingType = Splits.FirstOrDefault(i => i.TimingType == NewSplitTimingType);
            if (hierarchicalTimingType == null)
            {
                hierarchicalTimingType = new HierarchicalTimingTypeViewModel() { TimingType = NewSplitTimingType.Value };
                Splits.Add(hierarchicalTimingType);
            }

            var hierarchicalSplitType = hierarchicalTimingType.Children.FirstOrDefault(i => i.SplitType == NewSplitType);
            if (hierarchicalSplitType == null)
            {
                hierarchicalSplitType = new HierarchicalSplitTypeViewModel() { SplitType = NewSplitType.Value, Parent = hierarchicalTimingType };
                hierarchicalTimingType.Children.Add(hierarchicalSplitType);
            }

            switch (NewSplitType)
            {
                default:
                    throw new Exception($"split type not supported: {NewSplitType}");

                case SplitType.Boss:
                    var boss = (Boss)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => (Boss)i.Split != boss))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = boss, Parent = hierarchicalSplitType });
                    }
                    break;

                case SplitType.Bonfire:
                    var bonfire = (Bonfire)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => (Bonfire)i.Split != bonfire))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = bonfire, Parent = hierarchicalSplitType });
                    }
                    break;

                case SplitType.ItemPickup:
                    var itemPickup = (ItemPickup)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => (ItemPickup)i.Split != itemPickup))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = itemPickup, Parent = hierarchicalSplitType });
                    }
                    break;

                case SplitType.Attribute:
                    var attribute = (Attribute)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => ((Attribute)i.Split).ToString() != attribute.ToString()))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = attribute, Parent = hierarchicalSplitType });
                    }
                    break;

                case SplitType.Flag:
                    var flag = (uint)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => (uint)i.Split != flag))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = flag, Parent = hierarchicalSplitType });
                    }
                    break;
            }

            NewSplitTimingType = null;
            NewSplitType = null;
            NewSplitValue = null;
        }

        public void RemoveSplit()
        {
            if (SelectedSplit != null)
            {
                var parent = SelectedSplit.Parent;
                parent.Children.Remove(SelectedSplit);
                if (parent.Children.Count <= 0)
                {
                    var nextParent = parent.Parent;
                    nextParent.Children.Remove(parent);
                    if (nextParent.Children.Count <= 0)
                    {
                        Splits.Remove(nextParent);
                    }
                }

                SelectedSplit = null;
            }
        }

        
        public ObservableCollection<HierarchicalTimingTypeViewModel> Splits { get; set; } = new ObservableCollection<HierarchicalTimingTypeViewModel>();
        #endregion

        #region Properties for new splits ============================================================================================================================================

        [XmlIgnore]
        public TimingType? NewSplitTimingType
        {
            get => _newSplitTimingType;
            set
            {
                SetField(ref _newSplitTimingType, value);
                NewSplitTypeEnabled = true;
            }
        }
        private TimingType? _newSplitTimingType = null;

        [XmlIgnore]
        public SplitType? NewSplitType
        {
            get => _newSplitType;
            set
            {
                NewSplitBossEnabled       = false;
                NewSplitBonfireEnabled    = false;
                NewSplitItemPickupEnabled = false;
                NewSplitAttributeEnabled  = false;
                NewSplitFlagEnabled       = false;

                SetField(ref _newSplitType, value);
                switch (NewSplitType)
                {
                    case null:
                        break;

                    case SplitType.Boss:
                        NewSplitBossEnabled = true;
                        break;

                    case SplitType.Bonfire:
                        NewSplitBonfireEnabled = true;
                        break;

                    case SplitType.ItemPickup:
                        NewSplitItemPickupEnabled = true;
                        break;

                    case SplitType.Attribute:
                        NewSplitAttributeEnabled = true;
                        NewSplitValue = new Attribute(){AttributeType = SoulMemory.DarkSouls3.Attribute.Vigor, Level = 10};
                        break;

                    case SplitType.Flag:
                        NewSplitFlagEnabled = true;
                        break;

                    default: 
                        throw new Exception($"Unsupported split type: {NewSplitType}");
                }
            }
        }
        private SplitType? _newSplitType = null;

        [XmlIgnore]
        public object NewSplitValue
        {
            get => _newSplitValue;
            set
            {
                SetField(ref _newSplitValue, value);
                NewSplitAddEnabled = NewSplitValue != null;
            }
        }

        private object _newSplitValue = null;

        [XmlIgnore]
        public bool NewSplitTypeEnabled
        {
            get => _newSplitTypeEnabled;
            set => SetField(ref _newSplitTypeEnabled, value);
        }
        private bool _newSplitTypeEnabled = false;

        [XmlIgnore]
        public bool NewSplitBossEnabled
        {
            get => _newSplitBossEnabled;
            set => SetField(ref _newSplitBossEnabled, value);
        }
        private bool _newSplitBossEnabled = false;

        [XmlIgnore]
        public bool NewSplitBonfireEnabled
        {
            get => _newSplitBonfireEnabled;
            set => SetField(ref _newSplitBonfireEnabled, value);
        }
        private bool _newSplitBonfireEnabled = false;

        [XmlIgnore]
        public bool NewSplitItemPickupEnabled
        {
            get => _newSplitItemPickupEnabled;
            set => SetField(ref _newSplitItemPickupEnabled, value);
        }
        private bool _newSplitItemPickupEnabled = false;

        [XmlIgnore]
        public bool NewSplitAttributeEnabled
        {
            get => _newSplitAttributeEnabled;
            set => SetField(ref _newSplitAttributeEnabled, value);
        }
        private bool _newSplitAttributeEnabled = false;

        [XmlIgnore]
        public bool NewSplitFlagEnabled
        {
            get => _newSplitFlagEnabled;
            set => SetField(ref _newSplitFlagEnabled, value);
        }
        private bool _newSplitFlagEnabled = false;

        [XmlIgnore]
        public bool NewSplitAddEnabled
        {
            get => _newSplitAddEnabled;
            set => SetField(ref _newSplitAddEnabled, value);
        }
        private bool _newSplitAddEnabled = false;

        [XmlIgnore]
        public bool RemoveSplitEnabled
        {
            get => _removeSplitEnabled;
            set => SetField(ref _removeSplitEnabled, value);
        }
        private bool _removeSplitEnabled = false;

        [XmlIgnore]
        public HierarchicalSplitViewModel SelectedSplit
        {
            get => _selectedSplit;
            set
            {
                SetField(ref _selectedSplit, value);
                RemoveSplitEnabled = SelectedSplit != null;
            }
        }
        private HierarchicalSplitViewModel _selectedSplit = null;

        #endregion

        #region Splits hierarchy
        public void RestoreHierarchy()
        {
            //When serializing the model, we can't serialize the parent relation, because that would be a circular reference. Instead, parent's are not serialized.
            //After deserializing, the parent relations must be restored.

            foreach (var timingType in Splits)
            {
                foreach (var splitType in timingType.Children)
                {
                    splitType.Parent = timingType;
                    foreach (var split in splitType.Children)
                    {
                        split.Parent = splitType;
                    }
                }
            }
        }

        #endregion

        #region Static UI source data ============================================================================================================================================

        public static ObservableCollection<EnumFlagViewModel<Boss>> Bosses { get; set; } = new ObservableCollection<EnumFlagViewModel<Boss>>(Enum.GetValues(typeof(Boss)).Cast<Boss>().Select(i => new EnumFlagViewModel<Boss>(i)));
        public static ObservableCollection<EnumFlagViewModel<Bonfire>> Bonfires { get; set; } = new ObservableCollection<EnumFlagViewModel<Bonfire>>(Enum.GetValues(typeof(Bonfire)).Cast<Bonfire>().Select(i => new EnumFlagViewModel<Bonfire>(i)));
        public static ObservableCollection<EnumFlagViewModel<ItemPickup>> ItemPickups { get; set; } = new ObservableCollection<EnumFlagViewModel<ItemPickup>>(Enum.GetValues(typeof(ItemPickup)).Cast<ItemPickup>().Select(i => new EnumFlagViewModel<ItemPickup>(i)));

        #endregion

        #region INotifyPropertyChanged ============================================================================================================================================

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
