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

using SoulSplitter.UiOld.Generic;
using System;

namespace SoulSplitter.Splits.ArmoredCore6;

internal class Split
{
    public Split(TimingType timingType, SplitType splitType, object split)
    {
        TimingType = timingType;
        SplitType = splitType;

        Flag = SplitType switch
        {
            SplitType.Flag => ((FlagDescription)split).Flag,
            _ => throw new ArgumentException($"unsupported split type {SplitType}")
        };
    }

    public readonly TimingType TimingType;
    public readonly SplitType SplitType;
    public readonly uint Flag;

    /// <summary>
    /// Set to true when split conditions are met. Does not trigger a split until timing conditions are met
    /// </summary>
    public bool SplitConditionMet = false;

    /// <summary>
    /// True after this split object cause a split. No longer need to check split conditions
    /// </summary>
    public bool SplitTriggered = false;
}
