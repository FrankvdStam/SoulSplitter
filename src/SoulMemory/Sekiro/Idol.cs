using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoulMemory.Sekiro
{
    [XmlType(Namespace = "Sekiro")]
    public enum Idol
    {
        [Display(Name = "Dilapidated Temple", Description = "Ashina Outskirts")]
        DilapidatedTemple = 11100000,

        [Display(Name = "Ashina Outskirts", Description = "Ashina Outskirts")]
        AshinaOutskirts = 11100006,

        [Display(Name = "Outskirts Wall - Gate Path", Description = "Ashina Outskirts")]
        OutskirtsWallGatePath = 11100001,

        [Display(Name = "Outskirts Wall - Stairway", Description = "Ashina Outskirts")]
        OutskirtsWallStairway = 11100002,

        [Display(Name = "Underbridge Valley", Description = "Ashina Outskirts")]
        UnderbridgeValley = 11100003,

        [Display(Name = "Ashina Castle Fortress", Description = "Ashina Outskirts")]
        AshinaCastleFortress = 11100004,

        [Display(Name = "Ashina Castle Gate", Description = "Ashina Outskirts")]
        AshinaCastleGate = 11100005,

        [Display(Name = "Flames of Hatred", Description = "Ashina Outskirts")]
        FlamesOfHatred = 11100007,

        [Display(Name = "Dragonspring - Hirata Estate", Description = "Hirata Estate")]
        DragonspringHirataEstate = 11000000,

        [Display(Name = "Estate Path", Description = "Hirata Estate")]
        EstatePath = 11000001,

        [Display(Name = "Bamboo Thicket Slope", Description = "Hirata Estate")]
        BambooThicketSlope = 11000002,

        [Display(Name = "Hirata Estate - Main Hall", Description = "Hirata Estate")]
        HirataEstateMainHall = 11000003,

        [Display(Name = "Hirata Audience Chamber", Description = "Hirata Estate")]
        HirataAudienceChamber = 11000005,

        [Display(Name = "Hirata Estate - Hidden Temple", Description = "Hirata Estate")]
        HirataEstateHiddenTemple = 11000004,

        [Display(Name = "Ashina Castle", Description = "Ashina Castle")]
        AshinaCastle = 11110000,

        [Display(Name = "Upper Tower - Antechamber", Description = "Ashina Castle")]
        UpperTowerAntechamber = 11110001,

        [Display(Name = "Upper Tower - Ashina Dojo", Description = "Ashina Castle")]
        UpperTowerAshinaDojo = 11110007,

        [Display(Name = "Castle Tower Lookout", Description = "Ashina Castle")]
        CastleTowerLookout = 11110002,

        [Display(Name = "Upper Tower - Kuro's Room", Description = "Ashina Castle")]
        UpperTowerKurosRoom = 11110003,

        [Display(Name = "Old Grave", Description = "Ashina Castle")]
        OldGrave = 11110006,

        [Display(Name = "Great Serpent Shrine", Description = "Ashina Castle")]
        GreatSerpentShrine = 11110004,

        [Display(Name = "Abandoned Dungeon Entrance", Description = "Ashina Castle")]
        AbandonedDungeonEntrance = 11110005,

        [Display(Name = "Ashina Reservoir", Description = "Ashina Castle")]
        AshinaReservoir = 11120001,

        [Display(Name = "Near Secret Passage", Description = "Ashina Castle")]
        NearSecretPassage = 11120000,

        [Display(Name = "Underground Waterway", Description = "Abandoned Dungeon")]
        UndergroundWaterway = 11300000,

        [Display(Name = "Bottomless Hole", Description = "Abandoned Dungeon")]
        BottomlessHole = 11300001,

        [Display(Name = "Senpou Temple, Mt. Kongo", Description = "Senpou Temple, Mt. Kongo")]
        SenpouTempleMtKongo = 12000000,

        [Display(Name = "Shugendo", Description = "Senpou Temple, Mt. Kongo")]
        Shugendo = 12000001,

        [Display(Name = "Temple Grounds", Description = "Senpou Temple, Mt. Kongo")]
        TempleGrounds = 12000002,

        [Display(Name = "Main Hall", Description = "Senpou Temple, Mt. Kongo")]
        MainHall = 12000003,

        [Display(Name = "Inner Sanctum", Description = "Senpou Temple, Mt. Kongo")]
        InnerSanctum = 12000004,

        [Display(Name = "Sunken Valley Cavern", Description = "Senpou Temple, Mt. Kongo")]
        SunkenValleyCavern = 12000005,

        [Display(Name = "Bell Demon's Temple", Description = "Senpou Temple, Mt. Kongo")]
        BellDemonsTemple = 12000006,

        [Display(Name = "Under-Shrine Valley", Description = "Sunken Valley")]
        UnderShrineValley = 11700007,

        [Display(Name = "Sunken Valley", Description = "Sunken Valley")]
        SunkenValley = 11700000,

        [Display(Name = "Gun Fort", Description = "Sunken Valley")]
        GunFort = 11700001,

        [Display(Name = "Riven Cave", Description = "Sunken Valley")]
        RivenCave = 11700002,

        [Display(Name = "Bodhisattva Valley", Description = "Sunken Valley")]
        BodhisattvaValley = 11700008,

        [Display(Name = "Guardian Ape's Watering Hole", Description = "Sunken Valley")]
        GuardianApesWateringHole = 11700003,

        [Display(Name = "Ashina Depths", Description = "Ashina Depths")]
        AshinaDepths = 11700005,

        [Display(Name = "Poison Pool", Description = "Ashina Depths")]
        PoisonPool = 11700004,

        [Display(Name = "Guardian Ape's Burrow", Description = "Ashina Depths")]
        GuardianApesBurrow = 11700006,

        [Display(Name = "Hidden Forest", Description = "Ashina Depths")]
        HiddenForest = 11500000,

        [Display(Name = "Mibu Village", Description = "Ashina Depths")]
        MibuVillage = 11500001,

        [Display(Name = "Water Mill", Description = "Ashina Depths")]
        WaterMill = 11500002,

        [Display(Name = "Wedding Cave Door", Description = "Ashina Depths")]
        WeddingCaveDoor = 11500003,

        [Display(Name = "Fountainhead Palace", Description = "Fountainhead Palace")]
        FountainheadPalace = 12500000,

        [Display(Name = "Vermilion Bridge", Description = "Fountainhead Palace")]
        VermilionBridge = 12500001,

        [Display(Name = "Mibu Manor", Description = "Fountainhead Palace")]
        MibuManor = 12500006,

        [Display(Name = "Flower Viewing Stage", Description = "Fountainhead Palace")]
        FlowerViewingStage = 12500002,

        [Display(Name = "Great Sakura", Description = "Fountainhead Palace")]
        GreatSakura = 12500003,

        [Display(Name = "Palace Grounds", Description = "Fountainhead Palace")]
        PalaceGrounds = 12500004,

        [Display(Name = "Feeding Grounds", Description = "Fountainhead Palace")]
        FeedingGrounds = 12500007,

        [Display(Name = "Near Pot Noble", Description = "Fountainhead Palace")]
        NearPotNoble = 12500008,

        [Display(Name = "Sanctuary", Description = "Fountainhead Palace")]
        Sanctuary = 12500005,
    }
}
