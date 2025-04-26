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
using System.Collections.Generic;
using System.Linq;

namespace SoulMemory.Enums
{
    public class SplitConfiguration
    {
        /// <summary>
        /// Returns a list of supported timing types for the given game.
        /// </summary>
        public static IEnumerable<TimingType> GetSupportedTimingTypes(Game game)
        {
            return GameTimingTypeLookup[game];
        }

        /// <summary>
        /// Returns a list of supported split types for the given game.
        /// </summary>
        public static IEnumerable<SplitType> GetSupportedSplitTypes(Game game)
        {
            return EventFlagEnumTypeLookupTable[game].Select(i => i.Item1);
        }

        /// <summary>
        /// Returns the accompanying type for this game + split type combination
        /// </summary>
        public static Type? GetSplitType(Game game, SplitType splitType)
        {
            return EventFlagEnumTypeLookupTable[game].FirstOrDefault(i => i.Item1 == splitType).Item2;
        }


        /// <summary>
        /// Lookup table for the timing types supported by each game.
        /// </summary>
        private static readonly Dictionary<Game, List<TimingType>> GameTimingTypeLookup = new Dictionary<Game, List<TimingType>>()
        {
            { Game.DarkSouls1,   new List<TimingType> { TimingType.Immediate, TimingType.OnLoading, TimingType.OnWarp } },
            { Game.DarkSouls2,   new List<TimingType> { TimingType.Immediate, TimingType.OnLoading } },
            { Game.DarkSouls3,   new List<TimingType> { TimingType.Immediate, TimingType.OnLoading, TimingType.OnBlackscreen } },
            { Game.Sekiro,       new List<TimingType> { TimingType.Immediate, TimingType.OnLoading, TimingType.OnBlackscreen } },
            { Game.EldenRing,    new List<TimingType> { TimingType.Immediate, TimingType.OnLoading, TimingType.OnBlackscreen } },
            { Game.ArmoredCore6, new List<TimingType> { TimingType.Immediate, TimingType.OnLoading } },
            { Game.Bloodborne,   new List<TimingType> { TimingType.Immediate, TimingType.OnLoading } },
        };

        /// <summary>
        /// Lookup table for the splitype + type of eventflag or other, relating to the game/splittype combination
        /// </summary>
        private static readonly Dictionary<Game, List<(SplitType, Type?)>> EventFlagEnumTypeLookupTable = new()
        {
            {
                Game.DarkSouls1, [
                    (SplitType.Manual, null),
                    (SplitType.Boss, typeof(Games.DarkSouls1.Boss)),
                    (SplitType.Position, null),
                    (SplitType.Attribute, typeof(Games.DarkSouls1.Attribute)),
                    (SplitType.DarkSouls1Bonfire, null),
                    (SplitType.DarkSouls1Item, null),
                    (SplitType.KnownFlag, typeof(Games.DarkSouls1.Boss)),
                    (SplitType.Flag, null)
                ]
            },
            {
                Game.DarkSouls2, [
                    (SplitType.Manual, null),
                    (SplitType.Boss, typeof(Games.DarkSouls2.Boss)),
                    (SplitType.Position, null),
                    (SplitType.Attribute, typeof(Games.DarkSouls2.Attribute)),
                    (SplitType.Flag, null),
                ]
            },
            {
                Game.DarkSouls3, [
                    (SplitType.Manual, null),
                    (SplitType.Boss, typeof(Games.DarkSouls3.Boss)),
                    (SplitType.Bonfire, typeof(Games.DarkSouls3.Bonfire)),
                    (SplitType.ItemPickup, typeof(Games.DarkSouls3.ItemPickup)),
                    (SplitType.Attribute, typeof(Games.DarkSouls3.Attribute)),
                    (SplitType.Position, null),
                    (SplitType.Flag, null),
                ]
            },
            {
                Game.Sekiro, [
                    (SplitType.Manual, null),
                    (SplitType.Boss, typeof(Games.Sekiro.Boss)),
                    (SplitType.Bonfire, typeof(Games.Sekiro.Idol)),
                    (SplitType.Attribute, typeof(Games.Sekiro.Attribute)),
                    (SplitType.Position, null),
                    (SplitType.Flag, null),
                ]
            },
            {
                Game.EldenRing, [
                    (SplitType.Manual, null),
                    (SplitType.Boss, typeof(Games.EldenRing.Boss)),
                    (SplitType.Bonfire, typeof(Games.EldenRing.Grace)),
                    (SplitType.ItemPickup, typeof(Games.EldenRing.ItemPickup)),
                    (SplitType.KnownFlag, typeof(Games.EldenRing.KnownFlag)),
                    (SplitType.EldenRingPosition, null),
                    (SplitType.Flag, null),
                ]
            },
            {
                Game.ArmoredCore6, [
                    (SplitType.Manual, null),
                    (SplitType.Flag, null),
                ]
            },
            {
                Game.Bloodborne, [
                    (SplitType.Manual, null),
                    (SplitType.Flag, null),
                    (SplitType.Position, null),
                ]
            }
        };
    }
}
