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
using SoulMemory.DarkSouls2;

namespace cli
{
    internal class EventFlagDiscovery
    {
        private DarkSouls2 _darkSouls2;
        public EventFlagDiscovery(DarkSouls2 darkSouls2)
        {
            _darkSouls2 = darkSouls2;
           
            foreach (var f in _flags)
            {
                var val = _darkSouls2.ReadEventFlag(f);
                if (val)
                {
                    Console.WriteLine($"event flag {f} enabled during init");
                }
                _dictionary[f] = val;
            }
        }

        public void Update()
        {
            foreach (var f in _flags)
            {
                var previous = _dictionary[f];
                var current = _darkSouls2.ReadEventFlag(f);
                _dictionary[f] = current;

                if (previous != current)
                {
                    Console.WriteLine($"flag {f} went from {previous} to {current}");
                }
            }
        }



        private Dictionary<uint, bool> _dictionary = new Dictionary<uint, bool>();

        private List<uint> _flags = new List<uint>()
        {
            110020080,
            110020084,
            110000081,
            100971,

            110020085,
            110020085,
            110000086,
            100968,



            //110000081, //giant
            //110000086, //persuer
            //
            //116000081, //sentinels
            //
            //131000081, //dragonrider
            //125000081, //rotten




            //101071, // Aava, the King's Pet
            //101053, // Afflicted Graverobber, Ancient Soldier Varg, and Cerah the Old Explorer
            //101080, // Aldia, Scholar of the First Sin
            //100977, // Ancient Dragon
            //101001, // Belfry Gargoyles
            //101070, // Burnt Ivory King
            //100955, // Covetous Demon
            //100979, // Darklurker
            //100950, // Demon of Song
            //100959, // Dragonrider
            //100980, // Dragonriderx2
            //101050, // Elana, the Squalid Queen
            //100953, // Executioner's Chariot
            //100961, // Flexile Sentry
            //101061, // Fume Knight
            //100972, // Giant Lord
            //100970, // Guardian Dragon
            //100958, // Looking Glass Knight
            //100963, // Lost Sinner
            //101072, // Lud, the King's Pet & Zallen, the King's Pet
            //100956, // Mytha, the Baneful Queen
            //100973, // Nashandra
            //100960, // Old Dragonslayer
            //100952, // Old Iron King
            //101000, // Prowling Magus and Congregation
            //100967, // Royal Rat Authority
            //100965, // Royal Rat Vanguard
            //100962, // Ruin Sentinels
            //100957, // Scorpioness Najka
            //101051, // Sinh, the Slumbering Dragon
            //101062, // Sir Alonne
            //100954, // Skeleton Lords
            //100964, // Smelter Demon (Red)
            //101063, // Smelter Demon (Blue)
            //100951, // The Duke's Dear Freja
            //100971, // The Last Giant
            //100968, // The Pursuer
            //100966, // The Rotten
            //100974, // Throne Watcher and Defender
            //100975, // Velstadt, the Royal Aegis
            //100978, // Vendrick

        };
    }
}
