using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Data;
using System.Xml.Serialization;
using SoulMemory.EldenRing;
using SoulMemory.Memory;
using SoulSplitter.Splits.EldenRing;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.UI.EldenRing
{
    public class EldenRingViewModel : INotifyPropertyChanged
    {
        public EldenRingViewModel()
        {
        }

        public bool StartAutomatically
        {
            get => _startAutomatically;
            set => SetField(ref _startAutomatically, value);
        }
        private bool _startAutomatically = true;

        public bool LockIgtToZero
        {
            get => _lockIgtToZero;
            set => SetField(ref _lockIgtToZero, value);
        }
        private bool _lockIgtToZero;

        [XmlIgnore]
        public PositionViewModel CurrentPosition
        {
            get => _currentPosition;
            set => SetField(ref _currentPosition, value);
        }
        private PositionViewModel _currentPosition = new PositionViewModel();


        #region Adding new splits ================================================================================================================

        [XmlIgnore]
        public TimingType? NewSplitTimingType
        {
            get => _newSplitTimingType;
            set
            {
                SetField(ref _newSplitTimingType, value);
                EnabledSplitType = NewSplitTimingType.HasValue;
            }
        }
        private TimingType? _newSplitTimingType;

        [XmlIgnore]
        public bool EnabledSplitType
        {
            get => _enabledSplitType;
            set => SetField(ref _enabledSplitType, value);
        }
        private bool _enabledSplitType = false;

        [XmlIgnore]
        public EldenRingSplitType? NewSplitType
        {
            get => _newSplitType;
            set
            {
                SetField(ref _newSplitType, value);

                EnabledAddSplit = false;
                VisibleBossSplit = false;
                VisibleGraceSplit = false;
                VisibleItemPickupSplit = false;
                VisibleFlagSplit = false;
                VisibleItemSplit = false;
                VisiblePositionSplit = false;

                switch (NewSplitType)
                {
                    default:
                        throw new Exception($"split type not supported: {NewSplitType}");

                    case null:
                        break;

                    case EldenRingSplitType.Boss:
                        VisibleBossSplit = true;
                        break;

                    case EldenRingSplitType.Grace:
                        VisibleGraceSplit = true;
                        break;

                    case EldenRingSplitType.ItemPickup:
                        VisibleItemPickupSplit = true;
                        break;

                    case EldenRingSplitType.Flag:
                        VisibleFlagSplit = true;
                        break;

                    case EldenRingSplitType.Item:
                        VisibleItemSplit = true;
                        break;

                    case EldenRingSplitType.Position:
                        VisiblePositionSplit = true;
                        EnabledAddSplit = true;
                        break;
                }
            }
        }
        private EldenRingSplitType? _newSplitType;

        [XmlIgnore]
        public Boss? NewSplitBoss
        {
            get => _newSplitBoss;
            set
            {
                SetField(ref _newSplitBoss, value);
                EnabledAddSplit = NewSplitBoss.HasValue;
            }
        }
        private Boss? _newSplitBoss;

        [XmlIgnore]
        public bool VisibleBossSplit
        {
            get => _visibleBossSplit;
            set => SetField(ref _visibleBossSplit, value);
        }
        private bool _visibleBossSplit;

        [XmlIgnore]
        public Grace? NewSplitGrace
        {
            get => _newSplitGrace;
            set
            {
                SetField(ref _newSplitGrace, value);
                EnabledAddSplit = NewSplitGrace.HasValue;
            }
        }
        private Grace? _newSplitGrace;

        [XmlIgnore]
        public bool VisibleGraceSplit
        {
            get => _visibleGraceSplit;
            set => SetField(ref _visibleGraceSplit, value);
        }
        private bool _visibleGraceSplit;

        [XmlIgnore]
        public uint? NewSplitFlag
        {
            get => _newSplitFlag;
            set
            {
                SetField(ref _newSplitFlag, value);
                EnabledAddSplit = NewSplitFlag.HasValue;
            }
        }
        private uint? _newSplitFlag;

        [XmlIgnore]
        public bool VisibleFlagSplit
        {
            get => _visibleFlagSplit;
            set => SetField(ref _visibleFlagSplit, value);
        }
        private bool _visibleFlagSplit;

        [XmlIgnore]
        public Item NewSplitItem
        {
            get => _newSplitItem;
            set
            {
                SetField(ref _newSplitItem, value);
                EnabledAddSplit = NewSplitItem != null;
            }
        }
        private Item _newSplitItem;

        [XmlIgnore]
        public bool VisibleItemSplit
        {
            get => _visibleItemSplit;
            set => SetField(ref _visibleItemSplit, value);
        }
        private bool _visibleItemSplit;

        [XmlIgnore]
        public PositionViewModel NewSplitPosition
        {
            get => _newSplitPosition;
            set
            {
                SetField(ref _newSplitPosition, value);
                EnabledAddSplit = _newSplitPosition != null;
            }
        }
        private PositionViewModel _newSplitPosition = new PositionViewModel();

        [XmlIgnore]
        public bool VisiblePositionSplit
        {
            get => _visiblePositionSplit;
            set => SetField(ref _visiblePositionSplit, value);
        }
        private bool _visiblePositionSplit;

        [XmlIgnore]
        public bool VisibleItemPickupSplit
        {
            get => _visibleItemPickupSplit;
            set => SetField(ref _visibleItemPickupSplit, value);
        }
        private bool _visibleItemPickupSplit;

        [XmlIgnore]
        public ItemPickup? NewSplitItemPickup
        {
            get => _newSplitItemPickup;
            set
            {
                SetField(ref _newSplitItemPickup, value);
                EnabledAddSplit = NewSplitItemPickup.HasValue;
            }
        }
        private ItemPickup? _newSplitItemPickup;


        [XmlIgnore]
        public bool EnabledAddSplit
        {
            get => _enabledAddSplit;
            set => SetField(ref _enabledAddSplit, value);
        }
        private bool _enabledAddSplit;




        public void AddSplit()
        {
            if (!NewSplitTimingType.HasValue || !NewSplitType.HasValue)
            {
                return;
            }

            var hierarchicalTimingType = Splits.FirstOrDefault(i => i.TimingType == NewSplitTimingType);
            if (hierarchicalTimingType == null)
            {
                hierarchicalTimingType = new HierarchicalTimingTypeViewModel() { TimingType = NewSplitTimingType.Value };
                Splits.Add(hierarchicalTimingType);
            }

            var hierarchicalSplitType = hierarchicalTimingType.Children.FirstOrDefault(i => i.EldenRingSplitType == NewSplitType);
            if (hierarchicalSplitType == null)
            {
                hierarchicalSplitType = new HierarchicalSplitTypeViewModel() { EldenRingSplitType = NewSplitType.Value, Parent = hierarchicalTimingType };
                hierarchicalTimingType.Children.Add(hierarchicalSplitType);
            }

            switch (NewSplitType)
            {
                default:
                    throw new Exception($"split type not supported: {NewSplitType}");

                case EldenRingSplitType.Boss:
                    if (hierarchicalSplitType.Children.All(i => (Boss)i.Split != NewSplitBoss))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitBoss.Value, Parent = hierarchicalSplitType });
                    }
                    break;

                case EldenRingSplitType.Grace:
                    if (hierarchicalSplitType.Children.All(i => (Grace)i.Split != NewSplitGrace))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitGrace.Value, Parent = hierarchicalSplitType });
                    }
                    break;

                case EldenRingSplitType.ItemPickup:
                    if (hierarchicalSplitType.Children.All(i => (ItemPickup)i.Split != NewSplitItemPickup))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitItemPickup.Value, Parent = hierarchicalSplitType });
                    }
                    break;

                case EldenRingSplitType.Flag:
                    if (hierarchicalSplitType.Children.All(i => (uint)i.Split != NewSplitFlag))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitFlag.Value, Parent = hierarchicalSplitType });
                    }
                    break;

                case EldenRingSplitType.Item:
                    if (hierarchicalSplitType.Children.All(i => (Item)i.Split != NewSplitItem))
                    { 
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitItem, Parent = hierarchicalSplitType });
                    }
                    break;

                case EldenRingSplitType.Position:
                    if (hierarchicalSplitType.Children.All(i => i.Split.ToString() != NewSplitPosition.Position.ToString()))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitPosition.Position, Parent = hierarchicalSplitType });
                    }
                    break;
            }

            //NewSplitTimingType = null;
            //NewSplitType = null;
            NewSplitBoss = null;
            NewSplitGrace = null;
            NewSplitFlag = null;
            NewSplitItem = null;
            NewSplitItemPickup = null;
            NewSplitPosition = new PositionViewModel();

            NewSplitTimingType = null;
            NewSplitType = null;
        }



        #endregion

        #region Removing splits
        public bool EnabledRemoveSplit
        {
            get => _enabledRemoveSplit;
            set => SetField(ref _enabledRemoveSplit, value);
        }
        private bool _enabledRemoveSplit;

        public HierarchicalSplitViewModel SelectedSplit
        {
            get => _selectedSplit;
            set
            {
                SetField(ref _selectedSplit, value);
                EnabledRemoveSplit = SelectedSplit != null;
            }
        }
        private HierarchicalSplitViewModel _selectedSplit = null;
        
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


        public ObservableCollection<HierarchicalTimingTypeViewModel> Splits { get; set; }= new ObservableCollection<HierarchicalTimingTypeViewModel>();
        
        //source lists
        public static ObservableCollection<BossViewModel> Bosses { get; set; } = new ObservableCollection<BossViewModel>(Enum.GetValues(typeof(Boss)).Cast<Boss>().Select(i => new BossViewModel(i)));
        public static ObservableCollection<GraceViewModel> Graces { get; set; } = new ObservableCollection<GraceViewModel>(Enum.GetValues(typeof(Grace)).Cast<Grace>().Select(i => new GraceViewModel(i)));
        public static ObservableCollection<ItemPickupViewModel> ItemPickups { get; set; } = new ObservableCollection<ItemPickupViewModel>(Enum.GetValues(typeof(ItemPickup)).Cast<ItemPickup>().Select(i => new ItemPickupViewModel(i)));


        //public static ObservableCollection<ItemViewModel> Items { get; set; } = new ObservableCollection<ItemViewModel>(Item.LookupTable.Select(i => new ItemViewModel(i)));

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

    public class ItemViewModel
    {
        public override string ToString()
        {
            return Name;
        }

        public ItemViewModel(Item i)
        {
            Item = i;
            Category = i.Category;
            GroupName = i.GroupName;
            Name = i.Name;
            Id = i.Id;
        }

        public Item Item
        {
            get => _item;
            set => SetField(ref _item, value);
        }
        private Item _item;

        public Category Category
        {
            get => _category;
            set => SetField(ref _category, value);
        }
        private Category _category;

        public string GroupName
        {
            get => _groupName;
            set => SetField(ref _groupName, value);
        }
        private string _groupName;


        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }
        private string _name;

        public uint Id
        {
            get => _id;
            set => SetField(ref _id, value);
        }
        private uint _id;



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
