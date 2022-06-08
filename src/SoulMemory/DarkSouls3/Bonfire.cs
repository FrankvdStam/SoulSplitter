using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls3
{
    public enum Bonfire : uint
    {
        [Display(Name = "Firelink Shrine", Description="Cemetery of Ash")]
        FirelinkShrine = 14000000,

        [Display(Name = "Cemetery of Ash", Description="Cemetery of Ash")]
        CemeteryOfAsh = 14000001,

        [Display(Name = "Iudex Gundyr", Description="Cemetery of Ash")]
        IudexGundyr = 14000002,

        [Display(Name = "Untended Graves", Description="Cemetery of Ash")]
        UntendedGraves = 14000003,

        [Display(Name = "Champion Gundyr", Description="Cemetery of Ash")]
        ChampionGundyr = 14000004,
        
        [Display(Name = "High Wall of Lothric", Description="High Wall of Lothric")]
        HighWallOfLothric = 13000009,

        [Display(Name = "Tower on the Wall", Description="High Wall of Lothric")]
        TowerOnTheWall = 13000005,

        [Display(Name = "Vordt of the Boreal Valley", Description="High Wall of Lothric")]
        VordtOfTheBorealValley = 13000002,

        [Display(Name = "Dancer of the Boreal Valley", Description="High Wall of Lothric")]
        DancerOfTheBorealValley = 13000004,

        [Display(Name = "Oceiros, the Consumed King", Description="High Wall of Lothric")]
        OceirosTheConsumedKing = 13000001,

        [Display(Name = "Foot of the High Wall", Description="Undead Settlement")]
        FootOfTheHighWall = 13100004,

        [Display(Name = "Undead Settlement", Description="Undead Settlement")]
        UndeadSettlement = 13100000,

        [Display(Name = "Cliff Underside", Description="Undead Settlement")]
        CliffUnderside = 13100002,

        [Display(Name = "Dilapidated Bridge", Description="Undead Settlement")]
        DilapidatedBridge = 13100003,

        [Display(Name = "Pit of Hollows", Description="Undead Settlement")]
        PitOfHollows = 13100001,

        [Display(Name = "Road of Sacrifices", Description="Road of Sacrifices")]
        RoadOfSacrifices = 13300006,

        [Display(Name = "Halfway Fortress", Description="Road of Sacrifices")]
        HalfwayFortress = 13300000,

        [Display(Name = "Crucifixion Woods", Description="Road of Sacrifices")]
        CrucifixionWoods = 13300007,

        [Display(Name = "Crystal Sage", Description="Road of Sacrifices")]
        CrystalSage = 13300002,

        [Display(Name = "Farron Keep", Description="Road of Sacrifices")]
        FarronKeep = 13300003,

        [Display(Name = "Keep Ruins", Description="Road of Sacrifices")]
        KeepRuins = 13300004,

        [Display(Name = "Farron Keep Perimeter", Description="Road of Sacrifices")]
        FarronKeepPerimeter = 13300008,

        [Display(Name = "Old Wolf of Farron", Description="Road of Sacrifices")]
        OldWolfOfFarron = 13300005,

        [Display(Name = "Abyss Watchers", Description="Road of Sacrifices")]
        AbyssWatchers = 13300001,

        [Display(Name = "Cathedral of the Deep", Description="Cathedral of the Deep")]
        CathedralOfTheDeep = 13500003,

        [Display(Name = "Cleansing Chapel", Description="Cathedral of the Deep")]
        CleansingChapel = 13500000,

        [Display(Name = "Rosaria's Bed Chamber", Description="Cathedral of the Deep")]
        RosariasBedChamber = 13500002,

        [Display(Name = "Deacons of the Deep", Description="Cathedral of the Deep")]
        DeaconsOfTheDeep = 13500001,

        [Display(Name = "Catacombs of Carthus", Description="Catacombs of Carthus")]
        CatacombsOfCarthus = 13800006,

        [Display(Name = "High Lord Wolnir", Description="Catacombs of Carthus")]
        HighLordWolnir = 13800000,

        [Display(Name = "Abandoned Tomb", Description="Catacombs of Carthus")]
        AbandonedTomb = 13800001,

        [Display(Name = "Old King's Antechamber", Description="Catacombs of Carthus")]
        OldKingsAntechamber = 13800002,

        [Display(Name = "Demon Ruins", Description="Catacombs of Carthus")]
        DemonRuins = 13800003,

        [Display(Name = "Old Demon King", Description="Catacombs of Carthus")]
        OldDemonKing = 13800004,

        [Display(Name = "Irithyll of the Boreal Valley", Description="Irithyll of the Boreal Valley")]
        IrithyllOfTheBorealValley = 13700007,

        [Display(Name = "Central Irithyll", Description="Irithyll of the Boreal Valley")]
        CentralIrithyll = 13700004,

        [Display(Name = "Church of Yorshka", Description="Irithyll of the Boreal Valley")]
        ChurchOfYorshka = 13700000,

        [Display(Name = "Distant Manor", Description="Irithyll of the Boreal Valley")]
        DistantManor = 13700005,

        [Display(Name = "Pontiff Sulyvahn", Description="Irithyll of the Boreal Valley")]
        PontiffSulyvahn = 13700001,

        [Display(Name = "Water Reserve", Description="Irithyll of the Boreal Valley")]
        WaterReserve = 13700006,

        [Display(Name = "Anor Londo", Description="Irithyll of the Boreal Valley")]
        AnorLondo = 13700003,

        [Display(Name = "Prison Tower", Description="Irithyll of the Boreal Valley")]
        PrisonTower = 13700008,

        [Display(Name = "Aldrich, Devourer of Gods", Description="Irithyll of the Boreal Valley")]
        AldrichDevourerOfGods = 13700002,

        [Display(Name = "Irithyll Dungeon", Description="Irithyll Dungeon")]
        IrithyllDungeon = 13900000,

        [Display(Name = "Profaned Capital", Description="Irithyll Dungeon")]
        ProfanedCapital = 13900002,

        [Display(Name = "Yhorm the Giant", Description="Irithyll Dungeon")]
        YhormTheGiant = 13900001,

        [Display(Name = "Lothric Castle", Description="Lothric Castle")]
        LothricCastle = 13010000,

        [Display(Name = "Dragon Barracks", Description="Lothric Castle")]
        DragonBarracks = 13010002,

        [Display(Name = "Dragonslayer Armour", Description="Lothric Castle")]
        DragonslayerArmour = 13010001,

        [Display(Name = "Grand Archives", Description="Lothric Castle")]
        GrandArchives = 13410001,

        [Display(Name = "Twin Princes", Description="Lothric Castle")]
        TwinPrinces = 13410000,

        [Display(Name = "Archdragon Peak", Description="Archdragon Peak")]
        ArchdragonPeak = 13200000,

        [Display(Name = "Dragon-Kin Mausoleum", Description="Archdragon Peak")]
        DragonKinMausoleum = 13200003,

        [Display(Name = "Great Belfry", Description="Archdragon Peak")]
        GreatBelfry = 13200002,

        [Display(Name = "Nameless King", Description="Archdragon Peak")]
        NamelessKing = 13200001,

        [Display(Name = "Flameless Shrine", Description="Kiln of the First Flame")]
        FlamelessShrine = 14100000,

        [Display(Name = "Kiln of the First Flame", Description="Kiln of the First Flame")]
        KilnOfTheFirstFlame = 14100001,
        
        [Display(Name = "Snowfield", Description="The Painted World of Ariandel")]
        Snowfield = 14500001,

        [Display(Name = "Rope Bridge Cave", Description="The Painted World of Ariandel")]
        RopeBridgeCave = 14500002,

        [Display(Name = "Corvian Settlement", Description="The Painted World of Ariandel")]
        CorvianSettlement = 14500003,

        [Display(Name = "Snowy Mountain Pass", Description="The Painted World of Ariandel")]
        SnowyMountainPass = 14500004,

        [Display(Name = "Ariandel Chapel", Description="The Painted World of Ariandel")]
        AriandelChapel = 14500005,

        [Display(Name = "Sister Friede", Description="The Painted World of Ariandel")]
        SisterFriede = 14500000,

        [Display(Name = "Depths of the Painting", Description="The Painted World of Ariandel")]
        DepthsOfThePainting = 14500007,

        [Display(Name = "Champion's Gravetender", Description="The Painted World of Ariandel")]
        ChampionsGravetender = 14500006,

        [Display(Name = "The Dreg Heap", Description="The Dreg Heap")]
        TheDregHeap = 15000001,

        [Display(Name = "Earthen Peak Ruins", Description="The Dreg Heap")]
        EarthenPeakRuins = 15000002,

        [Display(Name = "Within the Earthen Peak Ruins", Description="The Dreg Heap")]
        WithinTheEarthenPeakRuins = 15000003,

        [Display(Name = "The Demon Prince", Description="The Dreg Heap")]
        TheDemonPrince = 15000000,

        [Display(Name = "Mausoleum Lookout", Description="The Ringed City")]
        MausoleumLookout = 15100002,

        [Display(Name = "Ringed Inner Wall", Description="The Ringed City")]
        RingedInnerWall = 15100003,

        [Display(Name = "Ringed City Streets", Description="The Ringed City")]
        RingedCityStreets = 15100004,

        [Display(Name = "Shared Grave", Description="The Ringed City")]
        SharedGrave = 15100005,

        [Display(Name = "Church of Filianore", Description="The Ringed City")]
        ChurchOfFilianore = 15100000,

        [Display(Name = "Darkeater Midir", Description="The Ringed City")]
        DarkeaterMidir = 15100001,

        [Display(Name = "Filianore's Rest", Description="The Ringed City")]
        FilianoresRest = 15110001,

        [Display(Name = "Slave Knight Gael", Description="The Ringed City")]
        SlaveKnightGael = 15110000,
    }
}
