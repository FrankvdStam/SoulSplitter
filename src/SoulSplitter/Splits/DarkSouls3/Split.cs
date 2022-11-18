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
using SoulMemory.DarkSouls3;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splits.DarkSouls3
{
    internal class Split
    {
        public Split(TimingType timingType, SplitType darkSouls3SplitType, object split)
        {
            TimingType = timingType;
            SplitType = darkSouls3SplitType;

            switch (SplitType)
            {
                default:
                    throw new Exception($"unsupported split type {SplitType}");

                case SplitType.Boss:
                    Boss = (Boss)split;
                    Flag = (uint)Boss;
                    break;

                case SplitType.Bonfire:
                    Bonfire = (Bonfire)split;
                    Flag = (uint)Bonfire;
                    break;

                case SplitType.ItemPickup:
                    ItemPickup = (ItemPickup)split;
                    Flag = (uint)ItemPickup;
                    break;

                case SplitType.Attribute:
                    Attribute = (Attribute)split;
                    break;

                case SplitType.Position:
                    Position = (VectorSize)split;
                    break;

                case SplitType.Flag:
                    Flag = (uint)split;
                    break;
            }
        }

        public readonly TimingType TimingType;
        public readonly SplitType SplitType;
        
        public readonly Boss Boss;
        public readonly Bonfire Bonfire;
        public readonly ItemPickup ItemPickup;
        public readonly Attribute Attribute;
        public readonly VectorSize Position;
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
}
