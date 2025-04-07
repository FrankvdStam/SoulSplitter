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
using System.Linq;
using System.Xml.Serialization;
using SoulMemory.Games.DarkSouls1;
using SoulSplitter.Splits.DarkSouls1;
using SoulSplitter.Ui.RelayCommand;
using SoulSplitter.UiOld.Generic;
using BonfireState = SoulMemory.Games.DarkSouls1.BonfireState;

namespace SoulSplitter.UiOld.DarkSouls1;

public class DarkSouls1ViewModel : BaseViewModel
{
    public DarkSouls1ViewModel()
    {
        AddSplitCommand = new RelayCommand(AddSplit, CanAddSplit);
    }

    public bool ResetInventoryIndices
    {
        get => _resetInventoryIndices;
        set => SetField(ref _resetInventoryIndices, value);
    }
    private bool _resetInventoryIndices = true;


    public DropModType DropModType
    {
        get => _dropModType;
        set
        {
            var oldValue = _dropModType;
            SetField(ref _dropModType, value);
            OnDropModSettingsChanged(oldValue, value);
        }
    }
    private DropModType _dropModType = DropModType.None;

    #region
    [XmlIgnore]
    public bool DropModRequestGameExit;

    [XmlIgnore]
    public bool DropModRequestInitialisation;
    private void OnDropModSettingsChanged(DropModType oldValue, DropModType newValue)
    {
        //When dropmod is turned off, the game should be closed to ensure no modifications are left behind in memory
        if (oldValue is DropModType.AnyPercent or DropModType.AllAchievements && newValue == DropModType.None)
        {
            DropModRequestGameExit = true;
        }

        if(newValue != DropModType.None)
        {
            DropModRequestInitialisation = true;
        }
    }

    #endregion

    #region add/remove splits ============================================================================================================================================

    private bool CanAddSplit(object? param)
    {
        if (!NewSplitTimingType.HasValue || !NewSplitType.HasValue)
        {
            return false;
        }

        return NewSplitType switch
        {
            SplitType.Boss or SplitType.KnownFlag or SplitType.Attribute => NewSplitValue != null,
            SplitType.Position => Position != null,
            SplitType.Flag => FlagDescription != null,
            SplitType.Bonfire => NewSplitBonfireState is { Bonfire: not null },
            SplitType.Item => NewSplitItemState is { ItemType: not null },
            SplitType.Credits => NewSplitTimingType != null,
            _ => throw new ArgumentException($"{NewSplitType} not supported")
        };
    }

    private void AddSplit(object? param)
    {
        var split = NewSplitType switch
        {
            SplitType.Boss or SplitType.KnownFlag or SplitType.Attribute => NewSplitValue,
            SplitType.Position => Position,
            SplitType.Flag => FlagDescription,
            SplitType.Bonfire => NewSplitBonfireState,
            SplitType.Item => NewSplitItemState,
            SplitType.Credits => "Credits",
            _ => throw new ArgumentException($"{NewSplitType} not supported")
        };
        SplitsViewModel.AddSplit(NewSplitTimingType!.Value, NewSplitType.Value, split!);

        NewSplitTimingType = null;
        NewSplitEnabledSplitType = false;
        NewSplitType = null;
    }


    #endregion

    #region Properties for new splits ============================================================================================================================================

    [XmlIgnore]
    public new SplitType? NewSplitType
    {
        get => _newSplitType;
        set
        {
            SetField(ref _newSplitType, value);

            switch (NewSplitType)
            {
                case SplitType.Attribute:
                    NewSplitValue = new Splits.DarkSouls1.Attribute() { AttributeType = SoulMemory.Games.DarkSouls1.Attribute.Vitality, Level = 10 };
                    break;

                case SplitType.Position:
                    Position = new VectorSize() { Position = CurrentPosition.Clone() };
                    break;

                case SplitType.Flag:
                    FlagDescription = new FlagDescription();
                    break;

                case SplitType.Bonfire:
                    NewSplitBonfireState = new Splits.DarkSouls1.BonfireState() { State = SoulMemory.Games.DarkSouls1.BonfireState.Unlocked };
                    break;

                case SplitType.Item:
                    NewSplitItemState = new ItemState();
                    break;
            }
        }
    }
    private SplitType? _newSplitType;

    [XmlIgnore]
    public Splits.DarkSouls1.BonfireState NewSplitBonfireState
    {
        get => _newSplitBonfireState;
        set => SetField(ref _newSplitBonfireState, value);
    }
    private Splits.DarkSouls1.BonfireState _newSplitBonfireState = null!;

    [XmlIgnore]
    public ItemState NewSplitItemState
    {
        get => _newSplitItemState;
        set => SetField(ref _newSplitItemState, value);
    }
    private ItemState _newSplitItemState = null!;

    #endregion

    #region Static UI source data ============================================================================================================================================

    public static ObservableCollection<EnumFlagViewModel<Boss>> Bosses { get; set; } = new(Enum.GetValues(typeof(Boss)).Cast<Boss>().Select(i => new EnumFlagViewModel<Boss>(i)));
    public static ObservableCollection<EnumFlagViewModel<KnownFlag>> KnownFlags { get; set; } = 
        new(
            Enum
                .GetValues(typeof(KnownFlag))
                .Cast<KnownFlag>()
                .Select(i => new EnumFlagViewModel<KnownFlag>(i))
        );
    public static ObservableCollection<EnumFlagViewModel<Bonfire>> Bonfires { get; set; } = new(Enum.GetValues(typeof(Bonfire)).Cast<Bonfire>().Select(i => new EnumFlagViewModel<Bonfire>(i)));
    public static ObservableCollection<Item> Items { get; set; } = new(Item.AllItems);

    #endregion
}
