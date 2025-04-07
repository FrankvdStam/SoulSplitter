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

public class SplitViewModel
{
    public SplitViewModel(){}

    public SplitViewModel(Game game, int newGamePlusLevel, TimingType timingType, SplitType splitType, object split, string description)
    {
        Game = game;
        NewGamePlusLevel = newGamePlusLevel;
        TimingType = timingType;
        SplitType = splitType;
        Split = split;
        Description = description;
    }

    public string Description { get; set; } = null!;
    public Game Game { get; set; }
    public int NewGamePlusLevel { get; set; }
    public TimingType TimingType { get; set; }
    public SplitType SplitType { get; set; }
    public object Split{ get; set; } = null!;


    public bool SplitTriggered;
    public bool SplitConditionMet;
}
