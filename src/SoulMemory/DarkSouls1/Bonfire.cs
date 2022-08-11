using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoulMemory.DarkSouls1
{
    [XmlType(Namespace = "SoulMemory.DarkSouls1")]
    public enum Bonfire
    {
        [Display(Name = "Undead Asylum - Courtyard", Description = "Undead Asylum")]
        UndeadAsylumCourtyard = 1811960,

        [Display(Name = "Undead Asylum - Interior", Description = "Undead Asylum")]
        UndeadAsylumInterior = 1811961,

        [Display(Name = "Firelink Shrine", Description = "Firelink Shrine")]
        FirelinkShrine = 1021960,

        [Display(Name = "Firelink Altar - Lordvessel", Description = "Firelink Altar")]
        FirelinkAltarLordvessel = 1801960,

        [Display(Name = "Undead Burg", Description = "Undead Burg")]
        UndeadBurg = 1011962,

        [Display(Name = "Undead Burg - Sunlight Altar", Description = "Undead Burg")]
        UndeadBurgSunlightAltar = 1011961,

        [Display(Name = "Undead Parish", Description = "Undead Parish")]
        UndeadParishAndre = 1011964,

        [Display(Name = "Darkroot Garden", Description = "Darkroot Garden")]
        DarkrootGarden = 1201961,

        [Display(Name = "Darkroot Basin", Description = "Darkroot Basin")]
        DarkrootBasin = 1601961,

        [Display(Name = "Depths", Description = "Depths")]
        Depths = 1001960,

        [Display(Name = "Blighttown Catwalk", Description = "Blighttown")]
        BlighttownCatwalk = 1401962,

        [Display(Name = "Blighttown Swap", Description = "Blighttown")]
        BlighttownSwamp = 1401961,

        [Display(Name = "Quelaag's Domain - DaughterOfChaos", Description = "Quelaag's Domain")]
        DaughterOfChaos = 1401960,

        [Display(Name = "The Great Hollow", Description = "The Great Hollow")]
        TheGreatHollow = 1321962,

        [Display(Name = "Ash Lake", Description = "Ash Lake")]
        AshLake = 1321961,

        [Display(Name = "Ash Lake - Stone Dragon", Description = "Ash Lake")]
        AshLakeDragon = 1321960,

        [Display(Name = "Demon Ruins - Entrance", Description = "Demon Ruins")]
        DemonRuinsEntrance = 1411961,

        [Display(Name = "Demon Ruins - Staircase", Description = "Demon Ruins")]
        DemonRuinsStaircase = 1411962,

        [Display(Name = "Demon Ruins - Catacombs", Description = "Demon Ruins")]
        DemonRuinsCatacombs = 1411963,

        [Display(Name = "Lost Izalith - Lava Pits", Description = "Lost Izalith")]
        LostIzalithLavaPits = 1411964,

        [Display(Name = "Lost Izalith - 2 (illusory wall)", Description = "Lost Izalith")]
        LostIzalith2 = 1411960,

        [Display(Name = "Lost Izalith Heart of Chaos", Description = "Lost Izalith")]
        LostIzalithHeartOfChaos = 1411950,

        [Display(Name = "Sen's Fortress", Description = "Sen's Fortress")]
        SensFortress = 1501961,

        [Display(Name = "Anor Londo", Description = "Anor Londo")]
        AnorLondo = 1511960,

        [Display(Name = "Anor Londo Darkmoon Tomb", Description = "Anor Londo")]
        AnorLondoDarkmoonTomb = 1511962,

        [Display(Name = "Anor Londo Residence", Description = "Anor Londo")]
        AnorLondoResidence = 1511961,

        [Display(Name = "Anor Londo Chamber of the Princess", Description = "Anor Londo")]
        AnorLondoChamberOfThePrincess = 1511950,

        [Display(Name = "Painted World of Ariamis", Description = "Painted World of Ariamis")]
        PaintedWorldOfAriamis = 1101960,

        [Display(Name = "The Duke's Archives 1 (entrance)", Description = "The Duke's Archives")]
        DukesArchives1 = 1701962,

        [Display(Name = "The Duke's Archives 2 (prison cell)", Description = "The Duke's Archives")]
        DukesArchives2 = 1701961,

        [Display(Name = "The Duke's Archives 3 (balcony)", Description = "The Duke's Archives")]
        DukesArchives3 = 1701960,

        [Display(Name = "Crystal Cave", Description = "Crystal Cave")]
        CrystalCave = 1701950,

        [Display(Name = "Catacombs 1 (necromancer)", Description = "Catacombs")]
        Catacombs1 = 1301960,

        [Display(Name = "Catacombs 2 (illusory wall)", Description = "Catacombs")]
        Catacombs2 = 1301961,

        [Display(Name = "Tomb of the Giants - 1 (patches)", Description = "Tomb of the Giants")]
        TombOfTheGiantsPatches = 1311961,

        [Display(Name = "Tomb of the Giants - 2", Description = "Tomb of the Giants")]
        TombOfTheGiants2 = 1311960,

        [Display(Name = "Tomb of the Giants - Altar of the Gravelord", Description = "Tomb of the Giants")]
        TombOfTheGiantsAltarOfTheGravelord = 1311950,

        [Display(Name = "The Abyss", Description = "The Abyss")]
        TheAbyss = 1601950,

        [Display(Name = "Oolacile - Sanctuary Garden", Description = "Oolacile")]
        OolacileSanctuaryGarden = 1211963,

        [Display(Name = "Oolacile - Sanctuary", Description = "Oolacile")]
        OolacileSanctuary = 1211961,

        [Display(Name = "Oolacile - Township", Description = "Oolacile")]
        OolacileTownship = 1211962,

        [Display(Name = "Oolacile - Township Dungeon", Description = "Oolacile")]
        OolacileTownshipDungeon = 1211964,

        [Display(Name = "Chasm of the Abyss", Description = "Chasm of the Abyss")]
        ChasmOfTheAbyss = 1211950,
    }

    [XmlType(Namespace = "SoulMemory.DarkSouls1")]
    public enum BonfireState
    {
        [Display(Name = "Not discovered")]
        Unknown = -1,

        [Display(Name = "Discovered")]
        Discovered = 0,

        [Display(Name = "Unlocked")]
        Unlocked = 10,

        [Display(Name = "Kindled 1")]
        Kindled1 = 20,

        [Display(Name = "Kindled 2")]
        Kindled2 = 30,

        [Display(Name = "Kindled 3")]
        Kindled3 = 40,
    }
}
