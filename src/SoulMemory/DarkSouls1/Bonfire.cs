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
        [AnnotationAttribute(Name = "Undead Asylum - Courtyard", Description = "Undead Asylum")]
        UndeadAsylumCourtyard = 1811960,

        [AnnotationAttribute(Name = "Undead Asylum - Interior", Description = "Undead Asylum")]
        UndeadAsylumInterior = 1811961,

        [AnnotationAttribute(Name = "Firelink Shrine", Description = "Firelink Shrine")]
        FirelinkShrine = 1021960,

        [AnnotationAttribute(Name = "Firelink Altar - Lordvessel", Description = "Firelink Altar")]
        FirelinkAltarLordvessel = 1801960,

        [AnnotationAttribute(Name = "Undead Burg", Description = "Undead Burg")]
        UndeadBurg = 1011962,

        [AnnotationAttribute(Name = "Undead Burg - Sunlight Altar", Description = "Undead Burg")]
        UndeadBurgSunlightAltar = 1011961,

        [AnnotationAttribute(Name = "Undead Parish", Description = "Undead Parish")]
        UndeadParishAndre = 1011964,

        [AnnotationAttribute(Name = "Darkroot Garden", Description = "Darkroot Garden")]
        DarkrootGarden = 1201961,

        [AnnotationAttribute(Name = "Darkroot Basin", Description = "Darkroot Basin")]
        DarkrootBasin = 1601961,

        [AnnotationAttribute(Name = "Depths", Description = "Depths")]
        Depths = 1001960,

        [AnnotationAttribute(Name = "Blighttown Catwalk", Description = "Blighttown")]
        BlighttownCatwalk = 1401962,

        [AnnotationAttribute(Name = "Blighttown Swamp", Description = "Blighttown")]
        BlighttownSwamp = 1401961,

        [AnnotationAttribute(Name = "Quelaag's Domain - DaughterOfChaos", Description = "Quelaag's Domain")]
        DaughterOfChaos = 1401960,

        [AnnotationAttribute(Name = "The Great Hollow", Description = "The Great Hollow")]
        TheGreatHollow = 1321962,

        [AnnotationAttribute(Name = "Ash Lake", Description = "Ash Lake")]
        AshLake = 1321961,

        [AnnotationAttribute(Name = "Ash Lake - Stone Dragon", Description = "Ash Lake")]
        AshLakeDragon = 1321960,

        [AnnotationAttribute(Name = "Demon Ruins - Entrance", Description = "Demon Ruins")]
        DemonRuinsEntrance = 1411961,

        [AnnotationAttribute(Name = "Demon Ruins - Staircase", Description = "Demon Ruins")]
        DemonRuinsStaircase = 1411962,

        [AnnotationAttribute(Name = "Demon Ruins - Catacombs", Description = "Demon Ruins")]
        DemonRuinsCatacombs = 1411963,

        [AnnotationAttribute(Name = "Lost Izalith - Lava Pits", Description = "Lost Izalith")]
        LostIzalithLavaPits = 1411964,

        [AnnotationAttribute(Name = "Lost Izalith - 2 (illusory wall)", Description = "Lost Izalith")]
        LostIzalith2 = 1411960,

        [AnnotationAttribute(Name = "Lost Izalith Heart of Chaos", Description = "Lost Izalith")]
        LostIzalithHeartOfChaos = 1411950,

        [AnnotationAttribute(Name = "Sen's Fortress", Description = "Sen's Fortress")]
        SensFortress = 1501961,

        [AnnotationAttribute(Name = "Anor Londo", Description = "Anor Londo")]
        AnorLondo = 1511960,

        [AnnotationAttribute(Name = "Anor Londo Darkmoon Tomb", Description = "Anor Londo")]
        AnorLondoDarkmoonTomb = 1511962,

        [AnnotationAttribute(Name = "Anor Londo Residence", Description = "Anor Londo")]
        AnorLondoResidence = 1511961,

        [AnnotationAttribute(Name = "Anor Londo Chamber of the Princess", Description = "Anor Londo")]
        AnorLondoChamberOfThePrincess = 1511950,

        [AnnotationAttribute(Name = "Painted World of Ariamis", Description = "Painted World of Ariamis")]
        PaintedWorldOfAriamis = 1101960,

        [AnnotationAttribute(Name = "The Duke's Archives 1 (entrance)", Description = "The Duke's Archives")]
        DukesArchives1 = 1701962,

        [AnnotationAttribute(Name = "The Duke's Archives 2 (prison cell)", Description = "The Duke's Archives")]
        DukesArchives2 = 1701961,

        [AnnotationAttribute(Name = "The Duke's Archives 3 (balcony)", Description = "The Duke's Archives")]
        DukesArchives3 = 1701960,

        [AnnotationAttribute(Name = "Crystal Cave", Description = "Crystal Cave")]
        CrystalCave = 1701950,

        [AnnotationAttribute(Name = "Catacombs 1 (necromancer)", Description = "Catacombs")]
        Catacombs1 = 1301960,

        [AnnotationAttribute(Name = "Catacombs 2 (illusory wall)", Description = "Catacombs")]
        Catacombs2 = 1301961,

        [AnnotationAttribute(Name = "Tomb of the Giants - 1 (patches)", Description = "Tomb of the Giants")]
        TombOfTheGiantsPatches = 1311961,

        [AnnotationAttribute(Name = "Tomb of the Giants - 2", Description = "Tomb of the Giants")]
        TombOfTheGiants2 = 1311960,

        [AnnotationAttribute(Name = "Tomb of the Giants - Altar of the Gravelord", Description = "Tomb of the Giants")]
        TombOfTheGiantsAltarOfTheGravelord = 1311950,

        [AnnotationAttribute(Name = "The Abyss", Description = "The Abyss")]
        TheAbyss = 1601950,

        [AnnotationAttribute(Name = "Oolacile - Sanctuary Garden", Description = "Oolacile")]
        OolacileSanctuaryGarden = 1211963,

        [AnnotationAttribute(Name = "Oolacile - Sanctuary", Description = "Oolacile")]
        OolacileSanctuary = 1211961,

        [AnnotationAttribute(Name = "Oolacile - Township", Description = "Oolacile")]
        OolacileTownship = 1211962,

        [AnnotationAttribute(Name = "Oolacile - Township Dungeon", Description = "Oolacile")]
        OolacileTownshipDungeon = 1211964,

        [AnnotationAttribute(Name = "Chasm of the Abyss", Description = "Chasm of the Abyss")]
        ChasmOfTheAbyss = 1211950,
    }

    [XmlType(Namespace = "SoulMemory.DarkSouls1")]
    public enum BonfireState
    {
        [AnnotationAttribute(Name = "Not discovered")]
        Unknown = -1,

        [AnnotationAttribute(Name = "Discovered")]
        Discovered = 0,

        [AnnotationAttribute(Name = "Unlocked")]
        Unlocked = 10,

        [AnnotationAttribute(Name = "Kindled 1")]
        Kindled1 = 20,

        [AnnotationAttribute(Name = "Kindled 2")]
        Kindled2 = 30,

        [AnnotationAttribute(Name = "Kindled 3")]
        Kindled3 = 40,
    }
}
