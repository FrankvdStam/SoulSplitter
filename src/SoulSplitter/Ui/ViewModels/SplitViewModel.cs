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

using SoulMemory.Enums; 

namespace SoulSplitter.Ui.ViewModels;

public class SplitViewModel : NotifyPropertyChanged
{
    public SplitViewModel(){}

    public SplitViewModel(Game game, TimingType timingType, SplitType splitType, object split, string description)
    {
        Game = game;
        TimingType = timingType;
        SplitType = splitType;
        Split = split;
        Description = description;
    }

    public string Description
    { 
        get => _description;
        set => SetField(ref _description, value);
    }
    private string _description = null!;

    public Game Game
    {
        get => _game;
        set => SetField(ref _game, value);
    }
    private Game _game;
    
    public TimingType TimingType
    {
        get => _timingType;
        set => SetField(ref _timingType, value);
    }
    private TimingType _timingType;

    public SplitType SplitType
    {
        get => _splitType;
        set => SetField(ref _splitType, value);
    }
    private SplitType _splitType;

    public object Split
    {
        get => _split;
        set => SetField(ref _split, value);
    }
    private object _split = null!;

    public bool SplitConditionMet;
}
