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

using System.Xml.Serialization;

namespace SoulMemory.DarkSouls1
{
    [XmlType(Namespace = "SoulMemory.DarkSouls1")]
    public enum Bonfire
    {
        [Annotation(Name = "Undead Asylum - Courtyard", Description = "Undead Asylum")]
        UndeadAsylumCourtyard = 1811960,

        [Annotation(Name = "Undead Asylum - Interior", Description = "Undead Asylum")]
        UndeadAsylumInterior = 1811961,

        [Annotation(Name = "Firelink Shrine", Description = "Firelink Shrine")]
        FirelinkShrine = 1021960,

        [Annotation(Name = "Firelink Altar - Lordvessel", Description = "Firelink Altar")]
        FirelinkAltarLordvessel = 1801960,

        [Annotation(Name = "Undead Burg", Description = "Undead Burg")]
        UndeadBurg = 1011962,

        [Annotation(Name = "Undead Burg - Sunlight Altar", Description = "Undead Burg")]
        UndeadBurgSunlightAltar = 1011961,

        [Annotation(Name = "Undead Parish", Description = "Undead Parish")]
        UndeadParishAndre = 1011964,

        [Annotation(Name = "Darkroot Garden", Description = "Darkroot Garden")]
        DarkrootGarden = 1201961,

        [Annotation(Name = "Darkroot Basin", Description = "Darkroot Basin")]
        DarkrootBasin = 1601961,

        [Annotation(Name = "Depths", Description = "Depths")]
        Depths = 1001960,

        [Annotation(Name = "Blighttown Catwalk", Description = "Blighttown")]
        BlighttownCatwalk = 1401962,

        [Annotation(Name = "Blighttown Swamp", Description = "Blighttown")]
        BlighttownSwamp = 1401961,

        [Annotation(Name = "Quelaag's Domain - DaughterOfChaos", Description = "Quelaag's Domain")]
        DaughterOfChaos = 1401960,

        [Annotation(Name = "The Great Hollow", Description = "The Great Hollow")]
        TheGreatHollow = 1321962,

        [Annotation(Name = "Ash Lake", Description = "Ash Lake")]
        AshLake = 1321961,

        [Annotation(Name = "Ash Lake - Stone Dragon", Description = "Ash Lake")]
        AshLakeDragon = 1321960,

        [Annotation(Name = "Demon Ruins - Entrance", Description = "Demon Ruins")]
        DemonRuinsEntrance = 1411961,

        [Annotation(Name = "Demon Ruins - Staircase", Description = "Demon Ruins")]
        DemonRuinsStaircase = 1411962,

        [Annotation(Name = "Demon Ruins - Catacombs", Description = "Demon Ruins")]
        DemonRuinsCatacombs = 1411963,

        [Annotation(Name = "Lost Izalith - Lava Pits", Description = "Lost Izalith")]
        LostIzalithLavaPits = 1411964,

        [Annotation(Name = "Lost Izalith - 2 (illusory wall)", Description = "Lost Izalith")]
        LostIzalith2 = 1411960,

        [Annotation(Name = "Lost Izalith Heart of Chaos", Description = "Lost Izalith")]
        LostIzalithHeartOfChaos = 1411950,

        [Annotation(Name = "Sen's Fortress", Description = "Sen's Fortress")]
        SensFortress = 1501961,

        [Annotation(Name = "Anor Londo", Description = "Anor Londo")]
        AnorLondo = 1511960,

        [Annotation(Name = "Anor Londo Darkmoon Tomb", Description = "Anor Londo")]
        AnorLondoDarkmoonTomb = 1511962,

        [Annotation(Name = "Anor Londo Residence", Description = "Anor Londo")]
        AnorLondoResidence = 1511961,

        [Annotation(Name = "Anor Londo Chamber of the Princess", Description = "Anor Londo")]
        AnorLondoChamberOfThePrincess = 1511950,

        [Annotation(Name = "Painted World of Ariamis", Description = "Painted World of Ariamis")]
        PaintedWorldOfAriamis = 1101960,

        [Annotation(Name = "The Duke's Archives 1 (entrance)", Description = "The Duke's Archives")]
        DukesArchives1 = 1701962,

        [Annotation(Name = "The Duke's Archives 2 (prison cell)", Description = "The Duke's Archives")]
        DukesArchives2 = 1701961,

        [Annotation(Name = "The Duke's Archives 3 (balcony)", Description = "The Duke's Archives")]
        DukesArchives3 = 1701960,

        [Annotation(Name = "Crystal Cave", Description = "Crystal Cave")]
        CrystalCave = 1701950,

        [Annotation(Name = "Catacombs 1 (necromancer)", Description = "Catacombs")]
        Catacombs1 = 1301960,

        [Annotation(Name = "Catacombs 2 (illusory wall)", Description = "Catacombs")]
        Catacombs2 = 1301961,

        [Annotation(Name = "Tomb of the Giants - 1 (patches)", Description = "Tomb of the Giants")]
        TombOfTheGiantsPatches = 1311961,

        [Annotation(Name = "Tomb of the Giants - 2", Description = "Tomb of the Giants")]
        TombOfTheGiants2 = 1311960,

        [Annotation(Name = "Tomb of the Giants - Altar of the Gravelord", Description = "Tomb of the Giants")]
        TombOfTheGiantsAltarOfTheGravelord = 1311950,

        [Annotation(Name = "The Abyss", Description = "The Abyss")]
        TheAbyss = 1601950,

        [Annotation(Name = "Oolacile - Sanctuary Garden", Description = "Oolacile")]
        OolacileSanctuaryGarden = 1211963,

        [Annotation(Name = "Oolacile - Sanctuary", Description = "Oolacile")]
        OolacileSanctuary = 1211961,

        [Annotation(Name = "Oolacile - Township", Description = "Oolacile")]
        OolacileTownship = 1211962,

        [Annotation(Name = "Oolacile - Township Dungeon", Description = "Oolacile")]
        OolacileTownshipDungeon = 1211964,

        [Annotation(Name = "Chasm of the Abyss", Description = "Chasm of the Abyss")]
        ChasmOfTheAbyss = 1211950,
    }

    [XmlType(Namespace = "SoulMemory.DarkSouls1")]
    public enum BonfireState
    {
        [Annotation(Name = "Not discovered")]
        Unknown = -1,

        [Annotation(Name = "Discovered")]
        Discovered = 0,

        [Annotation(Name = "Unlocked")]
        Unlocked = 10,

        [Annotation(Name = "Kindled 1")]
        Kindled1 = 20,

        [Annotation(Name = "Kindled 2")]
        Kindled2 = 30,

        [Annotation(Name = "Kindled 3")]
        Kindled3 = 40,
    }
}
