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

namespace SoulMemory.DarkSouls3
{
    [XmlType(Namespace = "DarkSouls3")]
    public enum Bonfire : uint
    {
        [AnnotationAttribute(Name = "Firelink Shrine", Description="Cemetery of Ash")]
        FirelinkShrine = 14000000,

        [AnnotationAttribute(Name = "Cemetery of Ash", Description="Cemetery of Ash")]
        CemeteryOfAsh = 14000001,

        [AnnotationAttribute(Name = "Iudex Gundyr", Description="Cemetery of Ash")]
        IudexGundyr = 14000002,

        [AnnotationAttribute(Name = "Untended Graves", Description="Cemetery of Ash")]
        UntendedGraves = 14000003,

        [AnnotationAttribute(Name = "Champion Gundyr", Description="Cemetery of Ash")]
        ChampionGundyr = 14000004,
        
        [AnnotationAttribute(Name = "High Wall of Lothric", Description="High Wall of Lothric")]
        HighWallOfLothric = 13000009,

        [AnnotationAttribute(Name = "Tower on the Wall", Description="High Wall of Lothric")]
        TowerOnTheWall = 13000005,

        [AnnotationAttribute(Name = "Vordt of the Boreal Valley", Description="High Wall of Lothric")]
        VordtOfTheBorealValley = 13000002,

        [AnnotationAttribute(Name = "Dancer of the Boreal Valley", Description="High Wall of Lothric")]
        DancerOfTheBorealValley = 13000004,

        [AnnotationAttribute(Name = "Oceiros, the Consumed King", Description="High Wall of Lothric")]
        OceirosTheConsumedKing = 13000001,

        [AnnotationAttribute(Name = "Foot of the High Wall", Description="Undead Settlement")]
        FootOfTheHighWall = 13100004,

        [AnnotationAttribute(Name = "Undead Settlement", Description="Undead Settlement")]
        UndeadSettlement = 13100000,

        [AnnotationAttribute(Name = "Cliff Underside", Description="Undead Settlement")]
        CliffUnderside = 13100002,

        [AnnotationAttribute(Name = "Dilapidated Bridge", Description="Undead Settlement")]
        DilapidatedBridge = 13100003,

        [AnnotationAttribute(Name = "Pit of Hollows", Description="Undead Settlement")]
        PitOfHollows = 13100001,

        [AnnotationAttribute(Name = "Road of Sacrifices", Description="Road of Sacrifices")]
        RoadOfSacrifices = 13300006,

        [AnnotationAttribute(Name = "Halfway Fortress", Description="Road of Sacrifices")]
        HalfwayFortress = 13300000,

        [AnnotationAttribute(Name = "Crucifixion Woods", Description="Road of Sacrifices")]
        CrucifixionWoods = 13300007,

        [AnnotationAttribute(Name = "Crystal Sage", Description="Road of Sacrifices")]
        CrystalSage = 13300002,

        [AnnotationAttribute(Name = "Farron Keep", Description="Road of Sacrifices")]
        FarronKeep = 13300003,

        [AnnotationAttribute(Name = "Keep Ruins", Description="Road of Sacrifices")]
        KeepRuins = 13300004,

        [AnnotationAttribute(Name = "Farron Keep Perimeter", Description="Road of Sacrifices")]
        FarronKeepPerimeter = 13300008,

        [AnnotationAttribute(Name = "Old Wolf of Farron", Description="Road of Sacrifices")]
        OldWolfOfFarron = 13300005,

        [AnnotationAttribute(Name = "Abyss Watchers", Description="Road of Sacrifices")]
        AbyssWatchers = 13300001,

        [AnnotationAttribute(Name = "Cathedral of the Deep", Description="Cathedral of the Deep")]
        CathedralOfTheDeep = 13500003,

        [AnnotationAttribute(Name = "Cleansing Chapel", Description="Cathedral of the Deep")]
        CleansingChapel = 13500000,

        [AnnotationAttribute(Name = "Rosaria's Bed Chamber", Description="Cathedral of the Deep")]
        RosariasBedChamber = 13500002,

        [AnnotationAttribute(Name = "Deacons of the Deep", Description="Cathedral of the Deep")]
        DeaconsOfTheDeep = 13500001,

        [AnnotationAttribute(Name = "Catacombs of Carthus", Description="Catacombs of Carthus")]
        CatacombsOfCarthus = 13800006,

        [AnnotationAttribute(Name = "High Lord Wolnir", Description="Catacombs of Carthus")]
        HighLordWolnir = 13800000,

        [AnnotationAttribute(Name = "Abandoned Tomb", Description="Catacombs of Carthus")]
        AbandonedTomb = 13800001,

        [AnnotationAttribute(Name = "Old King's Antechamber", Description="Catacombs of Carthus")]
        OldKingsAntechamber = 13800002,

        [AnnotationAttribute(Name = "Demon Ruins", Description="Catacombs of Carthus")]
        DemonRuins = 13800003,

        [AnnotationAttribute(Name = "Old Demon King", Description="Catacombs of Carthus")]
        OldDemonKing = 13800004,

        [AnnotationAttribute(Name = "Irithyll of the Boreal Valley", Description="Irithyll of the Boreal Valley")]
        IrithyllOfTheBorealValley = 13700007,

        [AnnotationAttribute(Name = "Central Irithyll", Description="Irithyll of the Boreal Valley")]
        CentralIrithyll = 13700004,

        [AnnotationAttribute(Name = "Church of Yorshka", Description="Irithyll of the Boreal Valley")]
        ChurchOfYorshka = 13700000,

        [AnnotationAttribute(Name = "Distant Manor", Description="Irithyll of the Boreal Valley")]
        DistantManor = 13700005,

        [AnnotationAttribute(Name = "Pontiff Sulyvahn", Description="Irithyll of the Boreal Valley")]
        PontiffSulyvahn = 13700001,

        [AnnotationAttribute(Name = "Water Reserve", Description="Irithyll of the Boreal Valley")]
        WaterReserve = 13700006,

        [AnnotationAttribute(Name = "Anor Londo", Description="Irithyll of the Boreal Valley")]
        AnorLondo = 13700003,

        [AnnotationAttribute(Name = "Prison Tower", Description="Irithyll of the Boreal Valley")]
        PrisonTower = 13700008,

        [AnnotationAttribute(Name = "Aldrich, Devourer of Gods", Description="Irithyll of the Boreal Valley")]
        AldrichDevourerOfGods = 13700002,

        [AnnotationAttribute(Name = "Irithyll Dungeon", Description="Irithyll Dungeon")]
        IrithyllDungeon = 13900000,

        [AnnotationAttribute(Name = "Profaned Capital", Description="Irithyll Dungeon")]
        ProfanedCapital = 13900002,

        [AnnotationAttribute(Name = "Yhorm the Giant", Description="Irithyll Dungeon")]
        YhormTheGiant = 13900001,

        [AnnotationAttribute(Name = "Lothric Castle", Description="Lothric Castle")]
        LothricCastle = 13010000,

        [AnnotationAttribute(Name = "Dragon Barracks", Description="Lothric Castle")]
        DragonBarracks = 13010002,

        [AnnotationAttribute(Name = "Dragonslayer Armour", Description="Lothric Castle")]
        DragonslayerArmour = 13010001,

        [AnnotationAttribute(Name = "Grand Archives", Description="Lothric Castle")]
        GrandArchives = 13410001,

        [AnnotationAttribute(Name = "Twin Princes", Description="Lothric Castle")]
        TwinPrinces = 13410000,

        [AnnotationAttribute(Name = "Archdragon Peak", Description="Archdragon Peak")]
        ArchdragonPeak = 13200000,

        [AnnotationAttribute(Name = "Dragon-Kin Mausoleum", Description="Archdragon Peak")]
        DragonKinMausoleum = 13200003,

        [AnnotationAttribute(Name = "Great Belfry", Description="Archdragon Peak")]
        GreatBelfry = 13200002,

        [AnnotationAttribute(Name = "Nameless King", Description="Archdragon Peak")]
        NamelessKing = 13200001,

        [AnnotationAttribute(Name = "Flameless Shrine", Description="Kiln of the First Flame")]
        FlamelessShrine = 14100000,

        [AnnotationAttribute(Name = "Kiln of the First Flame", Description="Kiln of the First Flame")]
        KilnOfTheFirstFlame = 14100001,
        
        [AnnotationAttribute(Name = "Snowfield", Description="The Painted World of Ariandel")]
        Snowfield = 14500001,

        [AnnotationAttribute(Name = "Rope Bridge Cave", Description="The Painted World of Ariandel")]
        RopeBridgeCave = 14500002,

        [AnnotationAttribute(Name = "Corvian Settlement", Description="The Painted World of Ariandel")]
        CorvianSettlement = 14500003,

        [AnnotationAttribute(Name = "Snowy Mountain Pass", Description="The Painted World of Ariandel")]
        SnowyMountainPass = 14500004,

        [AnnotationAttribute(Name = "Ariandel Chapel", Description="The Painted World of Ariandel")]
        AriandelChapel = 14500005,

        [AnnotationAttribute(Name = "Sister Friede", Description="The Painted World of Ariandel")]
        SisterFriede = 14500000,

        [AnnotationAttribute(Name = "Depths of the Painting", Description="The Painted World of Ariandel")]
        DepthsOfThePainting = 14500007,

        [AnnotationAttribute(Name = "Champion's Gravetender", Description="The Painted World of Ariandel")]
        ChampionsGravetender = 14500006,

        [AnnotationAttribute(Name = "The Dreg Heap", Description="The Dreg Heap")]
        TheDregHeap = 15000001,

        [AnnotationAttribute(Name = "Earthen Peak Ruins", Description="The Dreg Heap")]
        EarthenPeakRuins = 15000002,

        [AnnotationAttribute(Name = "Within the Earthen Peak Ruins", Description="The Dreg Heap")]
        WithinTheEarthenPeakRuins = 15000003,

        [AnnotationAttribute(Name = "The Demon Prince", Description="The Dreg Heap")]
        TheDemonPrince = 15000000,

        [AnnotationAttribute(Name = "Mausoleum Lookout", Description="The Ringed City")]
        MausoleumLookout = 15100002,

        [AnnotationAttribute(Name = "Ringed Inner Wall", Description="The Ringed City")]
        RingedInnerWall = 15100003,

        [AnnotationAttribute(Name = "Ringed City Streets", Description="The Ringed City")]
        RingedCityStreets = 15100004,

        [AnnotationAttribute(Name = "Shared Grave", Description="The Ringed City")]
        SharedGrave = 15100005,

        [AnnotationAttribute(Name = "Church of Filianore", Description="The Ringed City")]
        ChurchOfFilianore = 15100000,

        [AnnotationAttribute(Name = "Darkeater Midir", Description="The Ringed City")]
        DarkeaterMidir = 15100001,

        [AnnotationAttribute(Name = "Filianore's Rest", Description="The Ringed City")]
        FilianoresRest = 15110001,

        [AnnotationAttribute(Name = "Slave Knight Gael", Description="The Ringed City")]
        SlaveKnightGael = 15110000,
    }
}
