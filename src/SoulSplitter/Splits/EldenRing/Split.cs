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
using SoulMemory.EldenRing;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splits.EldenRing;

internal class Split
{
    public Split(TimingType timingType, EldenRingSplitType eldenRingSplitType, object split)
    {
        TimingType = timingType;
        EldenRingSplitType = eldenRingSplitType;

        switch (EldenRingSplitType)
        {
            default:
                throw new ArgumentException($"unsupported split type {EldenRingSplitType}");

            case EldenRingSplitType.Boss:
                Boss = (Boss)split;
                Flag = (uint)Boss;
                break;

            case EldenRingSplitType.Grace:
                Grace = (Grace)split;
                Flag = (uint)Grace;
                break;

            case EldenRingSplitType.ItemPickup:
                ItemPickup = (ItemPickup)split;
                Flag = (uint)ItemPickup;
                break;

            case EldenRingSplitType.KnownFlag:
                KnownFlag = (KnownFlag)split;
                Flag = (uint)KnownFlag;
                break;

            case EldenRingSplitType.Flag:
                Flag = (uint)split;
                break;

            case EldenRingSplitType.Item:
                Item = (Item)split;
                break;

            case EldenRingSplitType.Position:
                Position = (Position)split;
                break;
        }
    }

    public readonly TimingType TimingType;
    public readonly EldenRingSplitType EldenRingSplitType;
    
    public readonly Boss Boss;
    public readonly Grace Grace;
    public readonly ItemPickup ItemPickup;
    public readonly KnownFlag KnownFlag;
    public readonly Item Item = null!;
    public readonly Position Position = null!;
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
