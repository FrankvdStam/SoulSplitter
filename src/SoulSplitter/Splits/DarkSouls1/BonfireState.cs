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

using System.ComponentModel;
using System.Xml.Serialization;
using SoulMemory.Games.DarkSouls1;
using SoulMemory.Memory;
using SoulSplitter.UiOld.Generic;

namespace SoulSplitter.Splits.DarkSouls1;

[XmlType(Namespace = "DarkSouls1")]
public class BonfireState : ICustomNotifyPropertyChanged
{
    public Bonfire? Bonfire
    {
        get => _bonfire;
        set => this.SetField(ref _bonfire, value);
    }
    private Bonfire? _bonfire;

    public SoulMemory.Games.DarkSouls1.BonfireState State
    {
        get => _state;
        set => this.SetField(ref _state, value);
    }
    private SoulMemory.Games.DarkSouls1.BonfireState _state;

    public override string ToString()
    {
        return $"{Bonfire?.GetDisplayName()} {State.GetDisplayName()}";
    }

    #region ICustomNotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void InvokePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
