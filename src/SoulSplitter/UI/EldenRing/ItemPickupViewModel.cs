﻿// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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
using SoulMemory.EldenRing;
using SoulMemory.Memory;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.UI.EldenRing;

public class ItemPickupViewModel : ICustomNotifyPropertyChanged
{
    public ItemPickupViewModel(ItemPickup i)
    {
        Name = i.GetDisplayName();
        Flag = (uint)i;
        ItemPickup = i;
    }

    public override string ToString()
    {
        return Name;
    }

    public ItemPickup ItemPickup
    {
        get => _itemPickup;
        set => this.SetField(ref _itemPickup, value);
    }
    private ItemPickup _itemPickup;

    public string Name
    {
        get => _name;
        set => this.SetField(ref _name, value);
    }
    private string _name = null!;

    public uint Flag
    {
        get => _flag;
        set => this.SetField(ref _flag, value);
    }
    private uint _flag;


    #region ICustomNotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void InvokePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
