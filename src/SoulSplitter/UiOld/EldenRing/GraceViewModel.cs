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
using SoulMemory.Games.EldenRing;
using SoulMemory.Memory;
using SoulSplitter.Ui.ViewModels;
using SoulSplitter.UiOld.Generic;

namespace SoulSplitter.UiOld.EldenRing;

public class GraceViewModel : NotifyPropertyChanged
{
    public GraceViewModel(Grace g)
    {
        Area = g.GetDisplayDescription();
        Name = g.GetDisplayName();
        Flag = (uint)g;
        Grace = g;
    }

    public override string ToString()
    {
        return Name;
    }

    public Grace Grace
    {
        get => _grace;
        set => SetField(ref _grace, value);
    }
    private Grace _grace;

    public string Area
    {
        get => _area;
        set => SetField(ref _area, value);
    }
    private string _area = null!;

    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }
    private string _name = null!;

    public uint Flag
    {
        get => _flag;
        set => SetField(ref _flag, value);
    }
    private uint _flag;
}
