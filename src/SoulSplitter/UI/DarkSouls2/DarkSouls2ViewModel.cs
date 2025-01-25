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
using SoulMemory;
using SoulMemory.DarkSouls2;
using SoulSplitter.Splits.DarkSouls2;
using SoulSplitter.UI.Generic;
using Attribute = SoulSplitter.Splits.DarkSouls2.Attribute;

namespace SoulSplitter.UI.DarkSouls2;

public class DarkSouls2ViewModel : ICustomNotifyPropertyChanged
{
    public bool StartAutomatically
    {
        get => _startAutomatically;
        set => this.SetField(ref _startAutomatically, value);
    }
    private bool _startAutomatically = true;

    [XmlIgnore]
    public Vector3f CurrentPosition
    {
        get => _currentPosition;
        set => this.SetField(ref _currentPosition, value);
    }
    private Vector3f _currentPosition = new(0f,0f,0f);


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
                throw new ArgumentException($"split type not supported: {NewSplitType}");

            case DarkSouls2SplitType.Position:
                var position = (Vector3f)NewSplitValue;
                if (hierarchicalSplitType.Children.All(i => ((Vector3f)i.Split).ToString() != position.ToString()))
                {
                    hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = position, Parent = hierarchicalSplitType });
                }
                break;

            case DarkSouls2SplitType.BossKill:
                var bossKill = (BossKill)NewSplitValue;
                if (hierarchicalSplitType.Children.All(i => ((BossKill)i.Split).ToString() != bossKill.ToString()))
                {
                    hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = bossKill, Parent = hierarchicalSplitType });
                }
                break;

            case DarkSouls2SplitType.Attribute:
                var attribute = (Attribute)NewSplitValue;
                if (hierarchicalSplitType.Children.All(i => ((Attribute)i.Split).ToString() != attribute.ToString()))
                {
                    hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = attribute, Parent = hierarchicalSplitType });
                }
                break;

            case DarkSouls2SplitType.Flag:
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

    
    public ObservableCollection<HierarchicalTimingTypeViewModel> Splits { get; set; } = [];
    #endregion

    #region Properties for new splits ============================================================================================================================================

    [XmlIgnore]
    public TimingType? NewSplitTimingType
    {
        get => _newSplitTimingType;
        set
        {
            this.SetField(ref _newSplitTimingType, value);
            NewSplitTypeEnabled = true;
        }
    }
    private TimingType? _newSplitTimingType;

    [XmlIgnore]
    public DarkSouls2SplitType? NewSplitType
    {
        get => _newSplitType;
        set
        {
            NewSplitPositionEnabled = false;
            NewSplitBossKillEnabled = false;
            NewSplitAttributeEnabled = false;
            NewSplitFlagEnabled = false;

            this.SetField(ref _newSplitType, value);
            switch (NewSplitType)
            {
                case null:
                    break;

                case DarkSouls2SplitType.Position:
                    NewSplitPositionEnabled = true;
                    NewSplitValue = new Vector3f(CurrentPosition.X, CurrentPosition.Y, CurrentPosition.Z);
                    break;

                case DarkSouls2SplitType.BossKill:
                    NewSplitBossKillEnabled = true;
                    NewSplitValue = new BossKill();
                    break;

                case DarkSouls2SplitType.Attribute:
                    NewSplitAttributeEnabled = true;
                    NewSplitValue = new Splits.DarkSouls2.Attribute();
                    break;

                case DarkSouls2SplitType.Flag:
                    NewSplitFlagEnabled = true;
                    break;

                default: 
                    throw new ArgumentException($"Unsupported split type: {NewSplitType}");
            }
        }
    }
    private DarkSouls2SplitType? _newSplitType;

    [XmlIgnore]
    public object? NewSplitValue
    {
        get => _newSplitValue;
        set
        {
            this.SetField(ref _newSplitValue, value);
            NewSplitAddEnabled = NewSplitValue != null;
        }
    }
    private object? _newSplitValue;
    
    [XmlIgnore]
    public bool NewSplitTypeEnabled
    {
        get => _newSplitTypeEnabled;
        set => this.SetField(ref _newSplitTypeEnabled, value);
    }
    private bool _newSplitTypeEnabled;

    [XmlIgnore]
    public bool NewSplitPositionEnabled
    {
        get => _newSplitPositionEnabled;
        set => this.SetField(ref _newSplitPositionEnabled, value);
    }
    private bool _newSplitPositionEnabled;

    [XmlIgnore]
    public bool NewSplitBossKillEnabled
    {
        get => _newSplitBossKillEnabled;
        set => this.SetField(ref _newSplitBossKillEnabled, value);
    }
    private bool _newSplitBossKillEnabled;

    [XmlIgnore]
    public bool NewSplitAttributeEnabled
    {
        get => _newSplitAttributeEnabled;
        set => this.SetField(ref _newSplitAttributeEnabled, value);
    }
    private bool _newSplitAttributeEnabled;

    [XmlIgnore]
    public bool NewSplitFlagEnabled
    {
        get => _newSplitFlagEnabled;
        set => this.SetField(ref _newSplitFlagEnabled, value);
    }
    private bool _newSplitFlagEnabled;

    [XmlIgnore]
    public bool NewSplitAddEnabled
    {
        get => _newSplitAddEnabled;
        set => this.SetField(ref _newSplitAddEnabled, value);
    }
    private bool _newSplitAddEnabled;

    [XmlIgnore]
    public bool RemoveSplitEnabled
    {
        get => _removeSplitEnabled;
        set => this.SetField(ref _removeSplitEnabled, value);
    }
    private bool _removeSplitEnabled;

    [XmlIgnore]
    public HierarchicalSplitViewModel? SelectedSplit
    {
        get => _selectedSplit;
        set
        {
            this.SetField(ref _selectedSplit, value);
            RemoveSplitEnabled = SelectedSplit != null;
        }
    }
    private HierarchicalSplitViewModel? _selectedSplit;

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

    public static ObservableCollection<EnumFlagViewModel<BossType>> Bosses { get; set; } = new(Enum.GetValues(typeof(BossType)).Cast<BossType>().Select(i => new EnumFlagViewModel<BossType>(i)));


    #endregion

    #region ICustomNotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void InvokePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
