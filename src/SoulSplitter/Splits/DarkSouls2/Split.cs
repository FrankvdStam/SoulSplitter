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
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splits.DarkSouls2
{
    internal class Split
    {
        public Split(TimingType timingType, DarkSouls2SplitType darkSouls2SplitType, object split)
        {
            TimingType = timingType;
            SplitType = darkSouls2SplitType;

            switch (SplitType)
            {
                default:
                    throw new ArgumentException($"unsupported split type {SplitType}");

                case DarkSouls2SplitType.Position:
                    Position = (Vector3f)split;
                    break;

                case DarkSouls2SplitType.BossKill:
                    BossKill = (BossKill)split;
                    break;

                case DarkSouls2SplitType.Attribute:
                    Attribute = (Attribute)split;
                    break;

                case DarkSouls2SplitType.Flag:
                    Flag = (uint)split;
                    break;
            }
        }

        public readonly TimingType TimingType;
        public readonly DarkSouls2SplitType SplitType;
        
        public readonly uint Flag;
        public readonly Vector3f Position;
        public readonly BossKill BossKill;
        public readonly Attribute Attribute;

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
