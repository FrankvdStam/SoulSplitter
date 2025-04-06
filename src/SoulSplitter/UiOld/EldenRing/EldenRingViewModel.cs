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
using System.Xml.Serialization;
using SoulMemory.Games.EldenRing;
using SoulSplitter.Splits.EldenRing;
using SoulSplitter.UiOld.Generic;

namespace SoulSplitter.UiOld.EldenRing;

public class EldenRingViewModel : ICustomNotifyPropertyChanged
{
    public EldenRingViewModel()
    {
    }

    public bool StartAutomatically
    {
        get => _startAutomatically;
        set => this.SetField(ref _startAutomatically, value);
    }
    private bool _startAutomatically = true;

    public bool LockIgtToZero
    {
        get => _lockIgtToZero;
        set => this.SetField(ref _lockIgtToZero, value);
    }
    private bool _lockIgtToZero;

    [XmlIgnore]
    public PositionViewModel CurrentPosition
    {
        get => _currentPosition;
        set => this.SetField(ref _currentPosition, value);
    }
    private PositionViewModel _currentPosition = new();


    #region Adding new splits ================================================================================================================

    [XmlIgnore]
    public TimingType? NewSplitTimingType
    {
        get => _newSplitTimingType;
        set
        {
            this.SetField(ref _newSplitTimingType, value);
            EnabledSplitType = NewSplitTimingType.HasValue;
        }
    }
    private TimingType? _newSplitTimingType;

    [XmlIgnore]
    public bool EnabledSplitType
    {
        get => _enabledSplitType;
        set => this.SetField(ref _enabledSplitType, value);
    }
    private bool _enabledSplitType;

    [XmlIgnore]
    public EldenRingSplitType? NewSplitType
    {
        get => _newSplitType;
        set
        {
            this.SetField(ref _newSplitType, value);

            EnabledAddSplit = false;
            VisibleBossSplit = false;
            VisibleGraceSplit = false;
            VisibleItemPickupSplit = false;
            VisibleKnownFlagSplit = false;
            VisibleFlagSplit = false;
            VisibleItemSplit = false;
            VisiblePositionSplit = false;

            switch (NewSplitType)
            {
                default:
                    throw new ArgumentException($"split type not supported: {NewSplitType}");

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

                case EldenRingSplitType.KnownFlag:
                    VisibleKnownFlagSplit = true;
                    break;

                case EldenRingSplitType.Flag:
                    VisibleFlagSplit = true;
                    break;

                case EldenRingSplitType.Item:
                    VisibleItemSplit = true;
                    break;

                case EldenRingSplitType.Position:
                    NewSplitPosition = new PositionViewModel();
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
            this.SetField(ref _newSplitBoss, value);
            EnabledAddSplit = NewSplitBoss.HasValue;
        }
    }
    private Boss? _newSplitBoss;

    [XmlIgnore]
    public bool VisibleBossSplit
    {
        get => _visibleBossSplit;
        set => this.SetField(ref _visibleBossSplit, value);
    }
    private bool _visibleBossSplit;

    [XmlIgnore]
    public Grace? NewSplitGrace
    {
        get => _newSplitGrace;
        set
        {
            this.SetField(ref _newSplitGrace, value);
            EnabledAddSplit = NewSplitGrace.HasValue;
        }
    }
    private Grace? _newSplitGrace;

    [XmlIgnore]
    public bool VisibleGraceSplit
    {
        get => _visibleGraceSplit;
        set => this.SetField(ref _visibleGraceSplit, value);
    }
    private bool _visibleGraceSplit;

    [XmlIgnore]
    public uint? NewSplitFlag
    {
        get => _newSplitFlag;
        set
        {
            this.SetField(ref _newSplitFlag, value);
            EnabledAddSplit = NewSplitFlag.HasValue;
        }
    }
    private uint? _newSplitFlag;

    [XmlIgnore]
    public bool VisibleFlagSplit
    {
        get => _visibleFlagSplit;
        set => this.SetField(ref _visibleFlagSplit, value);
    }
    private bool _visibleFlagSplit;

    [XmlIgnore]
    public Item? NewSplitItem
    {
        get => _newSplitItem;
        set
        {
            this.SetField(ref _newSplitItem, value);
            EnabledAddSplit = NewSplitItem != null;
        }
    }
    private Item? _newSplitItem;

    [XmlIgnore]
    public bool VisibleItemSplit
    {
        get => _visibleItemSplit;
        set => this.SetField(ref _visibleItemSplit, value);
    }
    private bool _visibleItemSplit;

    [XmlIgnore]
    public PositionViewModel? NewSplitPosition
    {
        get => _newSplitPosition;
        set
        {
            this.SetField(ref _newSplitPosition, value);
            EnabledAddSplit = _newSplitPosition != null;
        }
    }
    private PositionViewModel? _newSplitPosition;

    [XmlIgnore]
    public bool VisiblePositionSplit
    {
        get => _visiblePositionSplit;
        set => this.SetField(ref _visiblePositionSplit, value);
    }
    private bool _visiblePositionSplit;

    [XmlIgnore]
    public bool VisibleItemPickupSplit
    {
        get => _visibleItemPickupSplit;
        set => this.SetField(ref _visibleItemPickupSplit, value);
    }
    private bool _visibleItemPickupSplit;

    [XmlIgnore]
    public ItemPickup? NewSplitItemPickup
    {
        get => _newSplitItemPickup;
        set
        {
            this.SetField(ref _newSplitItemPickup, value);
            EnabledAddSplit = NewSplitItemPickup.HasValue;
        }
    }
    private ItemPickup? _newSplitItemPickup;

    [XmlIgnore]
    public bool VisibleKnownFlagSplit
    {
        get => _visibleKnownFlagSplit;
        set => this.SetField(ref _visibleKnownFlagSplit, value);
    }
    private bool _visibleKnownFlagSplit;

    [XmlIgnore]
    public KnownFlag? NewSplitKnownFlag
    {
        get => _newSplitKnownFlag;
        set
        {
            this.SetField(ref _newSplitKnownFlag, value);
            EnabledAddSplit = NewSplitKnownFlag.HasValue;
        }
    }
    private KnownFlag? _newSplitKnownFlag;


    [XmlIgnore]
    public bool EnabledAddSplit
    {
        get => _enabledAddSplit;
        set => this.SetField(ref _enabledAddSplit, value);
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
                throw new ArgumentException($"split type not supported: {NewSplitType}");

            case EldenRingSplitType.Boss:
                if (hierarchicalSplitType.Children.All(i => (Boss)i.Split != NewSplitBoss))
                {
                    hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitBoss!.Value, Parent = hierarchicalSplitType });
                }
                break;

            case EldenRingSplitType.Grace:
                if (hierarchicalSplitType.Children.All(i => (Grace)i.Split != NewSplitGrace))
                {
                    hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitGrace!.Value, Parent = hierarchicalSplitType });
                }
                break;

            case EldenRingSplitType.ItemPickup:
                if (hierarchicalSplitType.Children.All(i => (ItemPickup)i.Split != NewSplitItemPickup))
                {
                    hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitItemPickup!.Value, Parent = hierarchicalSplitType });
                }
                break;

            case EldenRingSplitType.KnownFlag:
                if (hierarchicalSplitType.Children.All(i => (KnownFlag)i.Split != NewSplitKnownFlag))
                {
                    hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitKnownFlag!.Value, Parent = hierarchicalSplitType });
                }
                break;

            case EldenRingSplitType.Flag:
                if (hierarchicalSplitType.Children.All(i => (uint)i.Split != NewSplitFlag))
                {
                    hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitFlag!.Value, Parent = hierarchicalSplitType });
                }
                break;

            case EldenRingSplitType.Item:
                if (hierarchicalSplitType.Children.All(i => (Item)i.Split != NewSplitItem))
                { 
                    hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitItem!, Parent = hierarchicalSplitType });
                }
                break;

            case EldenRingSplitType.Position:
                if (hierarchicalSplitType.Children.All(i => i.Split.ToString() != NewSplitPosition!.Position.ToString()))
                {
                    hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = NewSplitPosition!.Position, Parent = hierarchicalSplitType });
                }
                break;
        }

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
        set => this.SetField(ref _enabledRemoveSplit, value);
    }
    private bool _enabledRemoveSplit;

    public HierarchicalSplitViewModel? SelectedSplit
    {
        get => _selectedSplit;
        set
        {
            this.SetField(ref _selectedSplit, value);
            EnabledRemoveSplit = SelectedSplit != null;
        }
    }
    private HierarchicalSplitViewModel? _selectedSplit;
    
    public void RemoveSplit()
    {
        if (SelectedSplit != null)
        {
            var parent = SelectedSplit.Parent;
            parent!.Children.Remove(SelectedSplit);
            if (parent.Children.Count <= 0)
            {
                var nextParent = parent.Parent;
                nextParent!.Children.Remove(parent);
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


    public ObservableCollection<HierarchicalTimingTypeViewModel> Splits { get; }= [];
    
    //source lists
    public static ObservableCollection<BossViewModel> Bosses { get; } = new(Enum.GetValues(typeof(Boss)).Cast<Boss>().Select(i => new BossViewModel(i)));
    public static ObservableCollection<GraceViewModel> Graces { get; } = new(Enum.GetValues(typeof(Grace)).Cast<Grace>().Select(i => new GraceViewModel(i)));
    public static ObservableCollection<ItemPickupViewModel> ItemPickups { get; } = new(Enum.GetValues(typeof(ItemPickup)).Cast<ItemPickup>().Select(i => new ItemPickupViewModel(i)));
    public static ObservableCollection<KnownFlagViewModel> KnownFlags { get; } = new(Enum.GetValues(typeof(KnownFlag)).Cast<KnownFlag>().Select(i => new KnownFlagViewModel(i)));


    #region ICustomNotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void InvokePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}

public class ItemViewModel : ICustomNotifyPropertyChanged
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
        set => this.SetField(ref _item, value);
    }
    private Item _item = null!;

    public Category Category
    {
        get => _category;
        set => this.SetField(ref _category, value);
    }
    private Category _category;

    public string GroupName
    {
        get => _groupName;
        set => this.SetField(ref _groupName, value);
    }
    private string _groupName = null!;


    public string Name
    {
        get => _name;
        set => this.SetField(ref _name, value);
    }
    private string _name = null!;

    public uint Id
    {
        get => _id;
        set => this.SetField(ref _id, value);
    }
    private uint _id;




    #region ICustomNotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void InvokePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
