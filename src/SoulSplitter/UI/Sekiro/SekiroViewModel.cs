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
using SoulMemory.Sekiro;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.UI.Sekiro;

public class SekiroViewModel : BaseViewModel
{
    public SekiroViewModel()
    {
        AddSplitCommand = new RelayCommand(AddSplit, CanAddSplit);
    }

    public bool OverwriteIgtOnStart
    {
        get => _overwriteIgtOnStart;
        set => this.SetField(ref _overwriteIgtOnStart, value);
    }
    private bool _overwriteIgtOnStart;
    

    #region add/remove splits ============================================================================================================================================

    private bool CanAddSplit()
    {
        if (!NewSplitTimingType.HasValue || !NewSplitType.HasValue)
        {
            return false;
        }

        return NewSplitType switch
        {
            SplitType.Boss or SplitType.Bonfire or SplitType.Attribute => NewSplitValue != null,
            SplitType.Position => Position != null,
            SplitType.Flag => FlagDescription != null,
            _ => throw new ArgumentException($"{NewSplitType} not supported")
        };
    }

    private void AddSplit()
    {
        var split = NewSplitType switch
        {
            SplitType.Boss or SplitType.Bonfire => NewSplitValue,
            SplitType.Position => Position,
            SplitType.Attribute => NewSplitValue,
            SplitType.Flag => FlagDescription,
            _ => throw new ArgumentException($"{NewSplitType} not supported")
        };
        SplitsViewModel.AddSplit(NewSplitTimingType!.Value, NewSplitType.Value, split!);

        NewSplitTimingType = null;
        NewSplitEnabledSplitType = false;
        NewSplitType = null;
    }


    #endregion

    #region Static UI source data ============================================================================================================================================

    public static ObservableCollection<EnumFlagViewModel<Boss>> Bosses { get; set; } = new(Enum.GetValues(typeof(Boss)).Cast<Boss>().Select(i => new EnumFlagViewModel<Boss>(i)));
    public static ObservableCollection<EnumFlagViewModel<Idol>> Idols { get; set; } = new(Enum.GetValues(typeof(Idol)).Cast<Idol>().Select(i => new EnumFlagViewModel<Idol>(i)));
    
    #endregion
}
