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
using SoulMemory;

namespace SoulSplitterUIv2.Ui.ViewModels.MainViewModel;

/// <summary>
/// This part of MainViewModel contains all the bindable properties required for all the different split types
/// </summary>
public partial class MainViewModel
{
    /// <summary>
    /// If available, holds the current player position
    /// </summary>
    public Vector3f CurrentPosition
    {
        get => _currentPosition;
        set => SetField(ref _currentPosition, value);
    }
    private Vector3f _currentPosition = new Vector3f(1.1f, 2.2f, 3.3f);
    
    public PositionViewModel PositionViewModel
    {
        get => _positionViewModel;
        set => SetField(ref _positionViewModel, value);
    }
    private PositionViewModel _positionViewModel;
}
