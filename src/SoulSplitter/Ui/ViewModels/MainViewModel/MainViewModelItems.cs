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
using SoulMemory;
using SoulMemory.Games.DarkSouls1;

namespace SoulSplitter.Ui.ViewModels.MainViewModel;

/// <summary>
/// This part of MainViewModel contains all the bindable properties required for all the different split types
/// </summary>
public partial class MainViewModel
{
    public ItemType? SelectedDarkSouls1Item
    {
        get => _selectedDarkSouls1Item;
        set => SetField(ref _selectedDarkSouls1Item, value);
    }
    private ItemType? _selectedDarkSouls1Item;

    public static ObservableCollection<Item> DarkSouls1Items { get; set; } = new(Item.AllItems);
}
