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
using SoulSplitter.Ui.ViewModels;
using SoulSplitter.UiOld.Generic;

namespace SoulSplitter.UiOld.EldenRing;

public class PositionViewModel : NotifyPropertyChanged
{
    
    public readonly Position Position = new();


    public byte Area
    {
        get => Position.Area;
        set => SetField(ref Position.Area, value);
    }

    public byte Block
    {
        get => Position.Block;
        set => SetField(ref Position.Block, value);
    }

    public byte Region
    {
        get => Position.Region;
        set => SetField(ref Position.Region, value);
    }

    public byte Size
    {
        get => Position.Size;
        set => SetField(ref Position.Size, value);
    }


    public float X
    {
        get => Position.X;
        set => SetField(ref Position.X, value);
    }

    public float Y
    {
        get => Position.Y;
        set => SetField(ref Position.Y, value);
    }

    public float Z
    {
        get => Position.Z;
        set => SetField(ref Position.Z, value);
    }

    
    public override string ToString()
    {
        return Position.ToString();
    }
}
