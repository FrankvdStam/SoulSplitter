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

namespace SoulMemory.Sekiro
{
    [XmlType(Namespace = "Sekiro")]
    public enum Idol
    {
        [Annotation(Name = "Dilapidated Temple", Description = "Ashina Outskirts")]
        DilapidatedTemple = 11100000,

        [Annotation(Name = "Ashina Outskirts", Description = "Ashina Outskirts")]
        AshinaOutskirts = 11100006,

        [Annotation(Name = "Outskirts Wall - Gate Path", Description = "Ashina Outskirts")]
        OutskirtsWallGatePath = 11100001,

        [Annotation(Name = "Outskirts Wall - Stairway", Description = "Ashina Outskirts")]
        OutskirtsWallStairway = 11100002,

        [Annotation(Name = "Underbridge Valley", Description = "Ashina Outskirts")]
        UnderbridgeValley = 11100003,

        [Annotation(Name = "Ashina Castle Fortress", Description = "Ashina Outskirts")]
        AshinaCastleFortress = 11100004,

        [Annotation(Name = "Ashina Castle Gate", Description = "Ashina Outskirts")]
        AshinaCastleGate = 11100005,

        [Annotation(Name = "Flames of Hatred", Description = "Ashina Outskirts")]
        FlamesOfHatred = 11100007,

        [Annotation(Name = "Dragonspring - Hirata Estate", Description = "Hirata Estate")]
        DragonspringHirataEstate = 11000000,

        [Annotation(Name = "Estate Path", Description = "Hirata Estate")]
        EstatePath = 11000001,

        [Annotation(Name = "Bamboo Thicket Slope", Description = "Hirata Estate")]
        BambooThicketSlope = 11000002,

        [Annotation(Name = "Hirata Estate - Main Hall", Description = "Hirata Estate")]
        HirataEstateMainHall = 11000003,

        [Annotation(Name = "Hirata Audience Chamber", Description = "Hirata Estate")]
        HirataAudienceChamber = 11000005,

        [Annotation(Name = "Hirata Estate - Hidden Temple", Description = "Hirata Estate")]
        HirataEstateHiddenTemple = 11000004,

        [Annotation(Name = "Ashina Castle", Description = "Ashina Castle")]
        AshinaCastle = 11110000,

        [Annotation(Name = "Upper Tower - Antechamber", Description = "Ashina Castle")]
        UpperTowerAntechamber = 11110001,

        [Annotation(Name = "Upper Tower - Ashina Dojo", Description = "Ashina Castle")]
        UpperTowerAshinaDojo = 11110007,

        [Annotation(Name = "Castle Tower Lookout", Description = "Ashina Castle")]
        CastleTowerLookout = 11110002,

        [Annotation(Name = "Upper Tower - Kuro's Room", Description = "Ashina Castle")]
        UpperTowerKurosRoom = 11110003,

        [Annotation(Name = "Old Grave", Description = "Ashina Castle")]
        OldGrave = 11110006,

        [Annotation(Name = "Great Serpent Shrine", Description = "Ashina Castle")]
        GreatSerpentShrine = 11110004,

        [Annotation(Name = "Abandoned Dungeon Entrance", Description = "Ashina Castle")]
        AbandonedDungeonEntrance = 11110005,

        [Annotation(Name = "Ashina Reservoir", Description = "Ashina Castle")]
        AshinaReservoir = 11120001,

        [Annotation(Name = "Near Secret Passage", Description = "Ashina Castle")]
        NearSecretPassage = 11120000,

        [Annotation(Name = "Underground Waterway", Description = "Abandoned Dungeon")]
        UndergroundWaterway = 11300000,

        [Annotation(Name = "Bottomless Hole", Description = "Abandoned Dungeon")]
        BottomlessHole = 11300001,

        [Annotation(Name = "Senpou Temple, Mt. Kongo", Description = "Senpou Temple, Mt. Kongo")]
        SenpouTempleMtKongo = 12000000,

        [Annotation(Name = "Shugendo", Description = "Senpou Temple, Mt. Kongo")]
        Shugendo = 12000001,

        [Annotation(Name = "Temple Grounds", Description = "Senpou Temple, Mt. Kongo")]
        TempleGrounds = 12000002,

        [Annotation(Name = "Main Hall", Description = "Senpou Temple, Mt. Kongo")]
        MainHall = 12000003,

        [Annotation(Name = "Inner Sanctum", Description = "Senpou Temple, Mt. Kongo")]
        InnerSanctum = 12000004,

        [Annotation(Name = "Sunken Valley Cavern", Description = "Senpou Temple, Mt. Kongo")]
        SunkenValleyCavern = 12000005,

        [Annotation(Name = "Bell Demon's Temple", Description = "Senpou Temple, Mt. Kongo")]
        BellDemonsTemple = 12000006,

        [Annotation(Name = "Under-Shrine Valley", Description = "Sunken Valley")]
        UnderShrineValley = 11700007,

        [Annotation(Name = "Sunken Valley", Description = "Sunken Valley")]
        SunkenValley = 11700000,

        [Annotation(Name = "Gun Fort", Description = "Sunken Valley")]
        GunFort = 11700001,

        [Annotation(Name = "Riven Cave", Description = "Sunken Valley")]
        RivenCave = 11700002,

        [Annotation(Name = "Bodhisattva Valley", Description = "Sunken Valley")]
        BodhisattvaValley = 11700008,

        [Annotation(Name = "Guardian Ape's Watering Hole", Description = "Sunken Valley")]
        GuardianApesWateringHole = 11700003,

        [Annotation(Name = "Ashina Depths", Description = "Ashina Depths")]
        AshinaDepths = 11700005,

        [Annotation(Name = "Poison Pool", Description = "Ashina Depths")]
        PoisonPool = 11700004,

        [Annotation(Name = "Guardian Ape's Burrow", Description = "Ashina Depths")]
        GuardianApesBurrow = 11700006,

        [Annotation(Name = "Hidden Forest", Description = "Ashina Depths")]
        HiddenForest = 11500000,

        [Annotation(Name = "Mibu Village", Description = "Ashina Depths")]
        MibuVillage = 11500001,

        [Annotation(Name = "Water Mill", Description = "Ashina Depths")]
        WaterMill = 11500002,

        [Annotation(Name = "Wedding Cave Door", Description = "Ashina Depths")]
        WeddingCaveDoor = 11500003,

        [Annotation(Name = "Fountainhead Palace", Description = "Fountainhead Palace")]
        FountainheadPalace = 12500000,

        [Annotation(Name = "Vermilion Bridge", Description = "Fountainhead Palace")]
        VermilionBridge = 12500001,

        [Annotation(Name = "Mibu Manor", Description = "Fountainhead Palace")]
        MibuManor = 12500006,

        [Annotation(Name = "Flower Viewing Stage", Description = "Fountainhead Palace")]
        FlowerViewingStage = 12500002,

        [Annotation(Name = "Great Sakura", Description = "Fountainhead Palace")]
        GreatSakura = 12500003,

        [Annotation(Name = "Palace Grounds", Description = "Fountainhead Palace")]
        PalaceGrounds = 12500004,

        [Annotation(Name = "Feeding Grounds", Description = "Fountainhead Palace")]
        FeedingGrounds = 12500007,

        [Annotation(Name = "Near Pot Noble", Description = "Fountainhead Palace")]
        NearPotNoble = 12500008,

        [Annotation(Name = "Sanctuary", Description = "Fountainhead Palace")]
        Sanctuary = 12500005,
    }
}
