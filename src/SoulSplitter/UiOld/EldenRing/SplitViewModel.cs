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
using SoulMemory.Games.EldenRing;
using SoulSplitter.Splits.EldenRing;
using SoulSplitter.Ui.ViewModels;
using SoulSplitter.UiOld.Generic;

namespace SoulSplitter.UiOld.EldenRing;

public class HierarchicalTimingTypeViewModel : NotifyPropertyChanged
{
    public TimingType TimingType
    {
        get => _timingType;
        set => SetField(ref _timingType, value);
    }
    private TimingType _timingType;

    public ObservableCollection<HierarchicalSplitTypeViewModel> Children { get; set; } = [];
}

public class HierarchicalSplitTypeViewModel : NotifyPropertyChanged
{
    [XmlIgnore]
    [NonSerialized]
    public HierarchicalTimingTypeViewModel? Parent;

    public EldenRingSplitType EldenRingSplitType
    {
        get => _eldenRingSplitType;
        set => SetField(ref _eldenRingSplitType, value);
    }
    private EldenRingSplitType _eldenRingSplitType;

    public ObservableCollection<HierarchicalSplitViewModel> Children { get; set; } = [];
}

[XmlInclude(typeof(Boss))]
[XmlInclude(typeof(Grace))]
[XmlInclude(typeof(ItemPickup))]
[XmlInclude(typeof(uint))]
[XmlInclude(typeof(Item))]
[XmlInclude(typeof(Position))]
public class HierarchicalSplitViewModel : NotifyPropertyChanged
{
    [XmlIgnore]
    [NonSerialized]
    public HierarchicalSplitTypeViewModel? Parent;

    public object Split
    {
        get => _split;
        set => SetField(ref _split, value);
    }
    private object _split = null!;
}
