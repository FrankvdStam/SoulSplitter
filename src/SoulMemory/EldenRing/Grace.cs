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

namespace SoulMemory.EldenRing
{
    public enum Grace : uint
    {
        //Academy of Raya Lucaria

        [AnnotationAttribute(Name = "Raya Lucaria Grand Library", Description = "Academy of Raya Lucaria")]
        RayaLucariaGrandLibrary = 71400,

        [AnnotationAttribute(Name = "Debate Parlor", Description = "Academy of Raya Lucaria")]
        DebateParlor = 71401,

        [AnnotationAttribute(Name = "Church of the Cuckoo", Description = "Academy of Raya Lucaria")]
        ChurchOfTheCuckoo = 71402,

        [AnnotationAttribute(Name = "Schoolhouse Classroom", Description = "Academy of Raya Lucaria")]
        SchoolhouseClassroom = 71403,

        //Ainsel River

        [AnnotationAttribute(Name = "Dragonkin Soldier of Nokstella", Description = "Ainsel River")]
        DragonkinSoldierOfNokstella = 71210,

        [AnnotationAttribute(Name = "Ainsel River Well Depths", Description = "Ainsel River")]
        AinselRiverWellDepths = 71211,

        [AnnotationAttribute(Name = "Ainsel River Sluice Gate", Description = "Ainsel River")]
        AinselRiverSluiceGate = 71212,

        [AnnotationAttribute(Name = "Ainsel River Downstream", Description = "Ainsel River")]
        AinselRiverDownstream = 71213,

        [AnnotationAttribute(Name = "Astel, Naturalborn of the Void", Description = "Ainsel River")]
        AstelNaturalbornOfTheVoid = 71240,

        //Ainsel River Main

        [AnnotationAttribute(Name = "Ainsel River Main", Description = "Ainsel River Main")]
        AinselRiverMain = 71214,

        [AnnotationAttribute(Name = "Nokstella, Eternal City", Description = "Ainsel River Main")]
        NokstellaEternalCity = 71215,

        [AnnotationAttribute(Name = "Nokstella Waterfall Basin", Description = "Ainsel River Main")]
        NokstellaWaterfallBasin = 71219,

        //Altus Plateau

        [AnnotationAttribute(Name = "Sainted Hero's Grave", Description = "Altus Plateau")]
        SaintedHerosGrave = 73008,

        [AnnotationAttribute(Name = "Unsightly Catacombs", Description = "Altus Plateau")]
        UnsightlyCatacombs = 73012,

        [AnnotationAttribute(Name = "Perfumer's Grotto", Description = "Altus Plateau")]
        PerfumersGrotto = 73118,

        [AnnotationAttribute(Name = "Sage's Cave", Description = "Altus Plateau")]
        SagesCave = 73119,

        [AnnotationAttribute(Name = "Old Altus Tunnel", Description = "Altus Plateau")]
        OldAltusTunnel = 73204,

        [AnnotationAttribute(Name = "Altus Tunnel", Description = "Altus Plateau")]
        AltusTunnel = 73205,

        [AnnotationAttribute(Name = "Abandoned Coffin", Description = "Altus Plateau")]
        AbandonedCoffin = 76300,

        [AnnotationAttribute(Name = "Altus Plateau", Description = "Altus Plateau")]
        AltusPlateau = 76301,

        [AnnotationAttribute(Name = "Erdtree-Gazing Hill", Description = "Altus Plateau")]
        ErdtreeGazingHill = 76302,

        [AnnotationAttribute(Name = "Altus Highway Junction", Description = "Altus Plateau")]
        AltusHighwayJunction = 76303,

        [AnnotationAttribute(Name = "Forest-Spanning Greatbridge", Description = "Altus Plateau")]
        ForestSpanningGreatbridge = 76304,

        [AnnotationAttribute(Name = "Rampartside Path", Description = "Altus Plateau")]
        RampartsidePath = 76305,

        [AnnotationAttribute(Name = "Bower of Bounty", Description = "Altus Plateau")]
        BowerOfBounty = 76306,

        [AnnotationAttribute(Name = "Road of Iniquity Side Path", Description = "Altus Plateau")]
        RoadOfIniquitySidePath = 76307,

        [AnnotationAttribute(Name = "Windmill Village", Description = "Altus Plateau")]
        WindmillVillage = 76308,

        [AnnotationAttribute(Name = "Windmill Heights", Description = "Altus Plateau")]
        WindmillHeights = 76313,

        [AnnotationAttribute(Name = "Shaded Castle Ramparts", Description = "Altus Plateau")]
        ShadedCastleRamparts = 76320,

        [AnnotationAttribute(Name = "Shaded Castle Inner Gate", Description = "Altus Plateau")]
        ShadedCastleInnerGate = 76321,

        [AnnotationAttribute(Name = "Castellan's Hall", Description = "Altus Plateau")]
        CastellansHall = 76322,

        //Bellum Highway

        [AnnotationAttribute(Name = "East Raya Lucaria Gate", Description = "Bellum Highway")]
        EastRayaLucariaGate = 76207,

        [AnnotationAttribute(Name = "Bellum Church", Description = "Bellum Highway")]
        BellumChurch = 76208,

        [AnnotationAttribute(Name = "Frenzied Flame Village Outskirts", Description = "Bellum Highway")]
        FrenziedFlameVillageOutskirts = 76239,

        [AnnotationAttribute(Name = "Church of Inhibition", Description = "Bellum Highway")]
        ChurchOfInhibition = 76240,

        //Caelid

        [AnnotationAttribute(Name = "Minor Erdtree Catacombs", Description = "Caelid")]
        MinorErdtreeCatacombs = 73014,

        [AnnotationAttribute(Name = "Caelid Catacombs", Description = "Caelid")]
        CaelidCatacombs = 73015,

        [AnnotationAttribute(Name = "War-Dead Catacombs", Description = "Caelid")]
        WarDeadCatacombs = 73016,

        [AnnotationAttribute(Name = "Abandoned Cave", Description = "Caelid")]
        AbandonedCave = 73120,

        [AnnotationAttribute(Name = "Gaol Cave", Description = "Caelid")]
        GaolCave = 73121,

        [AnnotationAttribute(Name = "Gael Tunnel", Description = "Caelid")]
        GaelTunnel = 73207,

        [AnnotationAttribute(Name = "Rear Gael Tunnel Entrance", Description = "Caelid")]
        RearGaelTunnelEntrance = 73207,

        [AnnotationAttribute(Name = "Sellia Crystal Tunnel", Description = "Caelid")]
        SelliaCrystalTunnel = 73208,

        [AnnotationAttribute(Name = "Smoldering Church", Description = "Caelid")]
        SmolderingChurch = 76400,

        [AnnotationAttribute(Name = "Rotview Balcony", Description = "Caelid")]
        RotviewBalcony = 76401,

        [AnnotationAttribute(Name = "Fort Gael North", Description = "Caelid")]
        FortGaelNorth = 76402,

        [AnnotationAttribute(Name = "Caelem Ruins", Description = "Caelid")]
        CaelemRuins = 76403,

        [AnnotationAttribute(Name = "Cathedral of Dragon Communion", Description = "Caelid")]
        CathedralOfDragonCommunion = 76404,

        [AnnotationAttribute(Name = "Caelid Highway South", Description = "Caelid")]
        CaelidHighwaySouth = 76405,

        [AnnotationAttribute(Name = "Smoldering Wall", Description = "Caelid")]
        SmolderingWall = 76409,

        [AnnotationAttribute(Name = "Deep Siofra Well", Description = "Caelid")]
        DeepSiofraWell = 76410,

        [AnnotationAttribute(Name = "Southern Aeonia Swamp Bank", Description = "Caelid")]
        SouthernAeoniaSwampBank = 76411,

        [AnnotationAttribute(Name = "Sellia Backstreets", Description = "Caelid")]
        SelliaBackstreets = 76414,

        [AnnotationAttribute(Name = "Chair-Crypt of Sellia", Description = "Caelid")]
        ChairCryptOfSellia = 76415,

        [AnnotationAttribute(Name = "Sellia Under-Stair", Description = "Caelid")]
        SelliaUnderStair = 76416,

        [AnnotationAttribute(Name = "Impassable Greatbridge", Description = "Caelid")]
        ImpassableGreatbridge = 76417,

        [AnnotationAttribute(Name = "Church of the Plague", Description = "Caelid")]
        ChurchOfThePlague = 76418,

        [AnnotationAttribute(Name = "Redmane Castle Plaza", Description = "Caelid")]
        RedmaneCastlePlaza = 76419,

        [AnnotationAttribute(Name = "Chamber Outside the Plaza", Description = "Caelid")]
        ChamberOutsideThePlaza = 76420,

        [AnnotationAttribute(Name = "Starscourge Radahn", Description = "Caelid")]
        StarscourgeRadahn = 76422,

        //Capital Outskirts

        [AnnotationAttribute(Name = "Auriza Hero's Grave", Description = "Capital Outskirts")]
        AurizaHerosGrave = 73010,

        [AnnotationAttribute(Name = "Auriza Side Tomb", Description = "Capital Outskirts")]
        AurizaSideTomb = 73013,

        [AnnotationAttribute(Name = "Divine Tower of West Altus", Description = "Capital Outskirts")]
        DivineTowerOfWestAltus = 73430,

        [AnnotationAttribute(Name = "Sealed Tunnel", Description = "Capital Outskirts")]
        SealedTunnel = 73431,

        [AnnotationAttribute(Name = "Divine Tower of West Altus: Gate", Description = "Capital Outskirts")]
        DivineTowerOfWestAltusGate = 73432,

        [AnnotationAttribute(Name = "Outer Wall Phantom Tree", Description = "Capital Outskirts")]
        OuterWallPhantomTree = 76309,

        [AnnotationAttribute(Name = "Minor Erdtree Church", Description = "Capital Outskirts")]
        MinorErdtreeChurch = 76310,

        [AnnotationAttribute(Name = "Hermit Merchant's Shack", Description = "Capital Outskirts")]
        HermitMerchantsShack = 76311,

        [AnnotationAttribute(Name = "Outer Wall Battleground", Description = "Capital Outskirts")]
        OuterWallBattleground = 76312,

        [AnnotationAttribute(Name = "Capital Rampart", Description = "Capital Outskirts")]
        CapitalRampart = 76314,

        //Consecrated Snowfield

        [AnnotationAttribute(Name = "Consecrated Snowfield Catacombs", Description = "Consecrated Snowfield")]
        ConsecratedSnowfieldCatacombs = 73019,

        [AnnotationAttribute(Name = "Cave of the Forlorn", Description = "Consecrated Snowfield")]
        CaveOfTheForlorn = 73112,

        [AnnotationAttribute(Name = "Yelough Anix Tunnel", Description = "Consecrated Snowfield")]
        YeloughAnixTunnel = 73211,

        [AnnotationAttribute(Name = "Consecrated Snowfield", Description = "Consecrated Snowfield")]
        ConsecratedSnowfield = 76550,

        [AnnotationAttribute(Name = "Inner Consecrated Snowfield", Description = "Consecrated Snowfield")]
        InnerConsecratedSnowfield = 76551,

        [AnnotationAttribute(Name = "Ordina, Liturgical Town", Description = "Consecrated Snowfield")]
        OrdinaLiturgicalTown = 76652,

        [AnnotationAttribute(Name = "Apostate Derelict", Description = "Consecrated Snowfield")]
        ApostateDerelict = 76653,

        //Crumbling Farum Azula

        [AnnotationAttribute(Name = "Maliketh, the Black Blade", Description = "Crumbling Farum Azula")]
        MalikethTheBlackBlade = 71300,

        [AnnotationAttribute(Name = "Dragonlord Placidusax", Description = "Crumbling Farum Azula")]
        DragonlordPlacidusax = 71301,

        [AnnotationAttribute(Name = "Dragon Temple Altar", Description = "Crumbling Farum Azula")]
        DragonTempleAltar = 71302,

        [AnnotationAttribute(Name = "Crumbling Beast Grave", Description = "Crumbling Farum Azula")]
        CrumblingBeastGrave = 71303,

        [AnnotationAttribute(Name = "Crumbling Beast Grave Depths", Description = "Crumbling Farum Azula")]
        CrumblingBeastGraveDepths = 71304,

        [AnnotationAttribute(Name = "Tempest-Facing Balcony", Description = "Crumbling Farum Azula")]
        TempestFacingBalcony = 71305,

        [AnnotationAttribute(Name = "Dragon Temple", Description = "Crumbling Farum Azula")]
        DragonTemple = 71306,

        [AnnotationAttribute(Name = "Dragon Temple Transept", Description = "Crumbling Farum Azula")]
        DragonTempleTransept = 71307,

        [AnnotationAttribute(Name = "Dragon Temple Lift", Description = "Crumbling Farum Azula")]
        DragonTempleLift = 71308,

        [AnnotationAttribute(Name = "Dragon Temple Rooftop", Description = "Crumbling Farum Azula")]
        DragonTempleRooftop = 71309,

        [AnnotationAttribute(Name = "Beside the Great Bridge", Description = "Crumbling Farum Azula")]
        BesideTheGreatBridge = 71310,

        //Deeproot Depths

        [AnnotationAttribute(Name = "Prince of Death's Throne", Description = "Deeproot Depths")]
        PrinceOfDeathsThrone = 71230,

        [AnnotationAttribute(Name = "Root-Facing Cliffs", Description = "Deeproot Depths")]
        RootFacingCliffs = 71231,

        [AnnotationAttribute(Name = "Great Waterfall Crest", Description = "Deeproot Depths")]
        GreatWaterfallCrest = 71232,

        [AnnotationAttribute(Name = "Deeproot Depths", Description = "Deeproot Depths")]
        DeeprootDepths = 71233,

        [AnnotationAttribute(Name = "The Nameless Eternal City", Description = "Deeproot Depths")]
        TheNamelessEternalCity = 71234,

        [AnnotationAttribute(Name = "Across the Roots", Description = "Deeproot Depths")]
        AcrossTheRoots = 71235,

        //Elden Throne

        [AnnotationAttribute(Name = "Fractured Marika", Description = "Elden Throne")]
        FracturedMarika = 71900,

        //Elphael, Brace of the Haligtree

        [AnnotationAttribute(Name = "Malenia, Goddess of Rot", Description = "Elphael, Brace of the Haligtree")]
        MaleniaGoddessOfRot = 71500,

        [AnnotationAttribute(Name = "Prayer Room", Description = "Elphael, Brace of the Haligtree")]
        PrayerRoom = 71501,

        [AnnotationAttribute(Name = "Elphael Inner Wall", Description = "Elphael, Brace of the Haligtree")]
        ElphaelInnerWall = 71502,

        [AnnotationAttribute(Name = "Drainage Channel", Description = "Elphael, Brace of the Haligtree")]
        DrainageChannel = 71503,

        [AnnotationAttribute(Name = "Haligtree Roots", Description = "Elphael, Brace of the Haligtree")]
        HaligtreeRoots = 71504,

        //Flame Peak

        [AnnotationAttribute(Name = "Giant-Conquering Hero's Grave", Description = "Flame Peak")]
        GiantConqueringHerosGrave = 73017,

        [AnnotationAttribute(Name = "Giants' Mountaintop Catacombs", Description = "Flame Peak")]
        GiantsMountaintopCatacombs = 73018,

        [AnnotationAttribute(Name = "Giants' Gravepost", Description = "Flame Peak")]
        GiantsGravepost = 76506,

        [AnnotationAttribute(Name = "Church of Repose", Description = "Flame Peak")]
        ChurchOfRepose = 76507,

        [AnnotationAttribute(Name = "Foot of the Forge", Description = "Flame Peak")]
        FootOfTheForge = 76508,

        [AnnotationAttribute(Name = "Fire Giant", Description = "Flame Peak")]
        FireGiant = 76509,

        [AnnotationAttribute(Name = "Forge of the Giants", Description = "Flame Peak")]
        ForgeOfTheGiants = 76510,

        //Forbidden Lands

        [AnnotationAttribute(Name = "Hidden Path to the Haligtree", Description = "Forbidden Lands")]
        HiddenPathToTheHaligtree = 73020,

        [AnnotationAttribute(Name = "Divine Tower of East Altus: Gate", Description = "Forbidden Lands")]
        DivineTowerOfEastAltusGate = 73450,

        [AnnotationAttribute(Name = "Divine Tower of East Altus", Description = "Forbidden Lands")]
        DivineTowerOfEastAltus = 73451,

        [AnnotationAttribute(Name = "Forbidden Lands", Description = "Forbidden Lands")]
        ForbiddenLands = 76500,

        [AnnotationAttribute(Name = "Grand Lift of Rold", Description = "Forbidden Lands")]
        GrandLiftOfRold = 76502,

        //Greyoll's Dragonbarrow

        [AnnotationAttribute(Name = "Dragonbarrow Cave", Description = "Greyoll's Dragonbarrow")]
        DragonbarrowCave = 73110,

        [AnnotationAttribute(Name = "Sellia Hideaway", Description = "Greyoll's Dragonbarrow")]
        SelliaHideaway = 73111,

        [AnnotationAttribute(Name = "Divine Tower of Caelid", Description = "Greyoll's Dragonbarrow")]
        DivineTowerOfCaelid = 73440,

        [AnnotationAttribute(Name = "Divine Tower of Caelid: Center", Description = "Greyoll's Dragonbarrow")]
        DivineTowerOfCaelidCenter = 73441,

        [AnnotationAttribute(Name = "Isolated Divine Tower", Description = "Greyoll's Dragonbarrow")]
        IsolatedDivineTower = 73460,

        [AnnotationAttribute(Name = "Dragonbarrow West", Description = "Greyoll's Dragonbarrow")]
        DragonbarrowWest = 76450,

        [AnnotationAttribute(Name = "Isolated Merchant's Shack (Greyoll's Dragonbarrow)", Description = "Greyoll's Dragonbarrow")]
        IsolatedMerchantsShackGreyollsDragonbarrow = 76451,

        [AnnotationAttribute(Name = "Dragonbarrow Fork", Description = "Greyoll's Dragonbarrow")]
        DragonbarrowFork = 76452,

        [AnnotationAttribute(Name = "Fort Faroth", Description = "Greyoll's Dragonbarrow")]
        FortFaroth = 76453,

        [AnnotationAttribute(Name = "Bestial Sanctum", Description = "Greyoll's Dragonbarrow")]
        BestialSanctum = 76454,

        [AnnotationAttribute(Name = "Lenne's Rise", Description = "Greyoll's Dragonbarrow")]
        LennesRise = 76455,

        [AnnotationAttribute(Name = "Farum Greatbridge", Description = "Greyoll's Dragonbarrow")]
        FarumGreatbridge = 76456,

        //Lake of Rot

        [AnnotationAttribute(Name = "Lake of Rot Shoreside", Description = "Lake of Rot")]
        LakeOfRotShoreside = 71216,

        [AnnotationAttribute(Name = "Grand Cloister", Description = "Lake of Rot")]
        GrandCloister = 71218,

        //Leyndell, Ashen Capital

        [AnnotationAttribute(Name = "Elden Throne (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
        EldenThroneLeyndellAshenCapital = 71120,

        [AnnotationAttribute(Name = "Erdtree Sanctuary (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
        ErdtreeSanctuaryLeyndellAshenCapital = 71121,

        [AnnotationAttribute(Name = "East Capital Rampart (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
        EastCapitalRampartLeyndellAshenCapital = 71122,

        [AnnotationAttribute(Name = "Leyndell, Capital of Ash", Description = "Leyndell, Ashen Capital")]
        LeyndellCapitalOfAsh = 71123,

        [AnnotationAttribute(Name = "Queen's Bedchamber (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
        QueensBedchamberLeyndellAshenCapital = 71124,

        [AnnotationAttribute(Name = "Divine Bridge (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
        DivineBridgeLeyndellAshenCapital = 71125,

        //Leyndell, Royal Capital

        [AnnotationAttribute(Name = "Elden Throne (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
        EldenThroneLeyndellRoyalCapital = 71100,

        [AnnotationAttribute(Name = "Erdtree Sanctuary (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
        ErdtreeSanctuaryLeyndellRoyalCapital = 71101,

        [AnnotationAttribute(Name = "East Capital Rampart (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
        EastCapitalRampartLeyndellRoyalCapital = 71102,

        [AnnotationAttribute(Name = "Lower Capital Church", Description = "Leyndell, Royal Capital")]
        LowerCapitalChurch = 71103,

        [AnnotationAttribute(Name = "Avenue Balcony", Description = "Leyndell, Royal Capital")]
        AvenueBalcony = 71104,

        [AnnotationAttribute(Name = "West Capital Rampart", Description = "Leyndell, Royal Capital")]
        WestCapitalRampart = 71105,

        [AnnotationAttribute(Name = "Queen's Bedchamber (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
        QueensBedchamberLeyndellRoyalCapital = 71107,

        [AnnotationAttribute(Name = "Fortified Manor, First Floor", Description = "Leyndell, Royal Capital")]
        FortifiedManorFirstFloor = 71108,

        [AnnotationAttribute(Name = "Divine Bridge (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
        DivineBridgeLeyndellRoyalCapital = 71109,

        //Limgrave

        [AnnotationAttribute(Name = "Stormfoot Catacombs", Description = "Limgrave")]
        StormfootCatacombs = 73002,

        [AnnotationAttribute(Name = "Murkwater Catacombs", Description = "Limgrave")]
        MurkwaterCatacombs = 73004,

        [AnnotationAttribute(Name = "Murkwater Cave", Description = "Limgrave")]
        MurkwaterCave = 73100,

        [AnnotationAttribute(Name = "Groveside Cave", Description = "Limgrave")]
        GrovesideCave = 73103,

        [AnnotationAttribute(Name = "Coastal Cave", Description = "Limgrave")]
        CoastalCave = 73115,

        [AnnotationAttribute(Name = "Highroad Cave", Description = "Limgrave")]
        HighroadCave = 73117,

        [AnnotationAttribute(Name = "Limgrave Tunnels", Description = "Limgrave")]
        LimgraveTunnels = 73201,

        [AnnotationAttribute(Name = "Church of Elleh", Description = "Limgrave")]
        ChurchOfElleh = 76100,

        [AnnotationAttribute(Name = "The First Step", Description = "Limgrave")]
        TheFirstStep = 76101,

        [AnnotationAttribute(Name = "Artist's Shack (Limgrave)", Description = "Limgrave")]
        ArtistsShackLimgrave = 76103,

        [AnnotationAttribute(Name = "Third Church of Marika", Description = "Limgrave")]
        ThirdChurchOfMarika = 76104,

        [AnnotationAttribute(Name = "Fort Haight West", Description = "Limgrave")]
        FortHaightWest = 76105,

        [AnnotationAttribute(Name = "Agheel Lake South", Description = "Limgrave")]
        AgheelLakeSouth = 76106,

        [AnnotationAttribute(Name = "Agheel Lake North", Description = "Limgrave")]
        AgheelLakeNorth = 76108,

        [AnnotationAttribute(Name = "Church of Dragon Communion", Description = "Limgrave")]
        ChurchOfDragonCommunion = 76110,

        [AnnotationAttribute(Name = "Gatefront", Description = "Limgrave")]
        Gatefront = 76111,

        [AnnotationAttribute(Name = "Seaside Ruins", Description = "Limgrave")]
        SeasideRuins = 76113,

        [AnnotationAttribute(Name = "Mistwood Outskirts", Description = "Limgrave")]
        MistwoodOutskirts = 76114,

        [AnnotationAttribute(Name = "Murkwater Coast", Description = "Limgrave")]
        MurkwaterCoast = 76116,

        [AnnotationAttribute(Name = "Summonwater Village Outskirts", Description = "Limgrave")]
        SummonwaterVillageOutskirts = 76119,

        [AnnotationAttribute(Name = "Waypoint Ruins Cellar", Description = "Limgrave")]
        WaypointRuinsCellar = 76120,

        //Liurnia of the Lakes

        [AnnotationAttribute(Name = "Road's End Catacombs", Description = "Liurnia of the Lakes")]
        RoadsEndCatacombs = 73003,

        [AnnotationAttribute(Name = "Black Knife Catacombs", Description = "Liurnia of the Lakes")]
        BlackKnifeCatacombs = 73005,

        [AnnotationAttribute(Name = "Cliffbottom Catacombs", Description = "Liurnia of the Lakes")]
        CliffbottomCatacombs = 73006,

        [AnnotationAttribute(Name = "Stillwater Cave", Description = "Liurnia of the Lakes")]
        StillwaterCave = 73104,

        [AnnotationAttribute(Name = "Lakeside Crystal Cave", Description = "Liurnia of the Lakes")]
        LakesideCrystalCave = 73105,

        [AnnotationAttribute(Name = "Academy Crystal Cave", Description = "Liurnia of the Lakes")]
        AcademyCrystalCave = 73106,

        [AnnotationAttribute(Name = "Raya Lucaria Crystal Tunnel", Description = "Liurnia of the Lakes")]
        RayaLucariaCrystalTunnel = 73202,

        [AnnotationAttribute(Name = "Study Hall Entrance", Description = "Liurnia of the Lakes")]
        StudyHallEntrance = 73420,

        [AnnotationAttribute(Name = "Liurnia Tower Bridge", Description = "Liurnia of the Lakes")]
        LiurniaTowerBridge = 73421,

        [AnnotationAttribute(Name = "Divine Tower of Liurnia", Description = "Liurnia of the Lakes")]
        DivineTowerOfLiurnia = 73422,

        [AnnotationAttribute(Name = "Lake-Facing Cliffs", Description = "Liurnia of the Lakes")]
        LakeFacingCliffs = 76200,

        [AnnotationAttribute(Name = "Liurnia Lake Shore", Description = "Liurnia of the Lakes")]
        LiurniaLakeShore = 76201,

        [AnnotationAttribute(Name = "Laskyar Ruins", Description = "Liurnia of the Lakes")]
        LaskyarRuins = 76202,

        [AnnotationAttribute(Name = "Scenic Isle", Description = "Liurnia of the Lakes")]
        ScenicIsle = 76203,

        [AnnotationAttribute(Name = "Academy Gate Town", Description = "Liurnia of the Lakes")]
        AcademyGateTown = 76204,

        [AnnotationAttribute(Name = "South Raya Lucaria Gate", Description = "Liurnia of the Lakes")]
        SouthRayaLucariaGate = 76205,

        [AnnotationAttribute(Name = "Main Academy Gate", Description = "Liurnia of the Lakes")]
        MainAcademyGate = 76206,

        [AnnotationAttribute(Name = "Grand Lift of Dectus", Description = "Liurnia of the Lakes")]
        GrandLiftOfDectus = 76209,

        [AnnotationAttribute(Name = "Foot of the Four Belfries", Description = "Liurnia of the Lakes")]
        FootOfTheFourBelfries = 76210,

        [AnnotationAttribute(Name = "Sorcerer's Isle", Description = "Liurnia of the Lakes")]
        SorcerersIsle = 76211,

        [AnnotationAttribute(Name = "Northern Liurnia Lake Shore", Description = "Liurnia of the Lakes")]
        NorthernLiurniaLakeShore = 76212,

        [AnnotationAttribute(Name = "Road to the Manor", Description = "Liurnia of the Lakes")]
        RoadToTheManor = 76213,

        [AnnotationAttribute(Name = "Main Caria Manor Gate", Description = "Liurnia of the Lakes")]
        MainCariaManorGate = 76214,

        [AnnotationAttribute(Name = "Slumbering Wolf's Shack", Description = "Liurnia of the Lakes")]
        SlumberingWolfsShack = 76215,

        [AnnotationAttribute(Name = "Boilprawn Shack", Description = "Liurnia of the Lakes")]
        BoilprawnShack = 76216,

        [AnnotationAttribute(Name = "Artist's Shack (Liurnia of the Lakes)", Description = "Liurnia of the Lakes")]
        ArtistsShackLiurniaOfTheLakes = 76217,

        [AnnotationAttribute(Name = "Revenger's Shack", Description = "Liurnia of the Lakes")]
        RevengersShack = 76218,

        [AnnotationAttribute(Name = "Folly on the Lake", Description = "Liurnia of the Lakes")]
        FollyonTheLake = 76219,

        [AnnotationAttribute(Name = "Village of the Albinaurics", Description = "Liurnia of the Lakes")]
        VillageOfTheAlbinaurics = 76220,

        [AnnotationAttribute(Name = "Liurnia Highway North", Description = "Liurnia of the Lakes")]
        LiurniaHighwayNorth = 76221,

        [AnnotationAttribute(Name = "Gate Town Bridge", Description = "Liurnia of the Lakes")]
        GateTownBridge = 76222,

        [AnnotationAttribute(Name = "Eastern Liurnia Lake Shore", Description = "Liurnia of the Lakes")]
        EasternLiurniaLakeShore = 76223,

        [AnnotationAttribute(Name = "Church of Vows", Description = "Liurnia of the Lakes")]
        ChurchOfVows = 76224,

        [AnnotationAttribute(Name = "Ruined Labyrinth", Description = "Liurnia of the Lakes")]
        RuinedLabyrinth = 76225,

        [AnnotationAttribute(Name = "Mausoleum Compound", Description = "Liurnia of the Lakes")]
        MausoleumCompound = 76226,

        [AnnotationAttribute(Name = "The Four Belfries", Description = "Liurnia of the Lakes")]
        TheFourBelfries = 76227,

        [AnnotationAttribute(Name = "Ranni's Rise", Description = "Liurnia of the Lakes")]
        RannisRise = 76228,

        [AnnotationAttribute(Name = "Ravine-Veiled Village", Description = "Liurnia of the Lakes")]
        RavineVeiledVillage = 76229,

        [AnnotationAttribute(Name = "Manor Upper Level", Description = "Liurnia of the Lakes")]
        ManorUpperLevel = 76230,

        [AnnotationAttribute(Name = "Manor Lower Level", Description = "Liurnia of the Lakes")]
        ManorLowerLevel = 76231,

        [AnnotationAttribute(Name = "Royal Moongazing Grounds", Description = "Liurnia of the Lakes")]
        RoyalMoongazingGrounds = 76232,

        [AnnotationAttribute(Name = "Gate Town North", Description = "Liurnia of the Lakes")]
        GateTownNorth = 76233,

        [AnnotationAttribute(Name = "Eastern Tableland", Description = "Liurnia of the Lakes")]
        EasternTableland = 76234,

        [AnnotationAttribute(Name = "The Ravine", Description = "Liurnia of the Lakes")]
        TheRavine = 76235,

        [AnnotationAttribute(Name = "Fallen Ruins of the Lake", Description = "Liurnia of the Lakes")]
        FallenRuinsOfTheLake = 76236,

        [AnnotationAttribute(Name = "Converted Tower", Description = "Liurnia of the Lakes")]
        ConvertedTower = 76237,

        [AnnotationAttribute(Name = "Behind Caria Manor", Description = "Liurnia of the Lakes")]
        BehindCariaManor = 76238,

        [AnnotationAttribute(Name = "Temple Quarter", Description = "Liurnia of the Lakes")]
        TempleQuarter = 76241,

        [AnnotationAttribute(Name = "East Gate Bridge Trestle", Description = "Liurnia of the Lakes")]
        EastGateBridgeTrestle = 76242,

        [AnnotationAttribute(Name = "Crystalline Woods", Description = "Liurnia of the Lakes")]
        CrystallineWoods = 76243,

        [AnnotationAttribute(Name = "Liurnia Highway South", Description = "Liurnia of the Lakes")]
        LiurniaHighwaySouth = 76244,

        [AnnotationAttribute(Name = "Jarburg", Description = "Liurnia of the Lakes")]
        Jarburg = 76245,

        [AnnotationAttribute(Name = "Ranni's Chamber", Description = "Liurnia of the Lakes")]
        RannisChamber = 76247,

        //Miquella's Haligtree

        [AnnotationAttribute(Name = "Haligtree Promenade", Description = "Miquella's Haligtree")]
        HaligtreePromenade = 71505,

        [AnnotationAttribute(Name = "Haligtree Canopy", Description = "Miquella's Haligtree")]
        HaligtreeCanopy = 71506,

        [AnnotationAttribute(Name = "Haligtree Town", Description = "Miquella's Haligtree")]
        HaligtreeTown = 71507,

        [AnnotationAttribute(Name = "Haligtree Town Plaza", Description = "Miquella's Haligtree")]
        HaligtreeTownPlaza = 71508,

        //Mohgwyn Palace

        [AnnotationAttribute(Name = "Cocoon of the Empyrean", Description = "Mohgwyn Palace")]
        CocoonOfTheEmpyrean = 71250,

        [AnnotationAttribute(Name = "Palace Approach Ledge-Road", Description = "Mohgwyn Palace")]
        PalaceApproachLedgeRoad = 71251,

        [AnnotationAttribute(Name = "Dynasty Mausoleum Entrance", Description = "Mohgwyn Palace")]
        DynastyMausoleumEntrance = 71252,

        [AnnotationAttribute(Name = "Dynasty Mausoleum Midpoint", Description = "Mohgwyn Palace")]
        DynastyMausoleumMidpoint = 71253,

        //Moonlight Altar

        [AnnotationAttribute(Name = "Moonlight Altar", Description = "Moonlight Altar")]
        MoonlightAltar = 76250,

        [AnnotationAttribute(Name = "Cathedral of Manus Celes", Description = "Moonlight Altar")]
        CathedralOfManusCeles = 76251,

        [AnnotationAttribute(Name = "Altar South", Description = "Moonlight Altar")]
        AltarSouth = 76252,

        //Mountaintops of the Giants

        [AnnotationAttribute(Name = "Spiritcaller's Cave", Description = "Mountaintops of the Giants")]
        SpiritcallersCave = 73122,

        [AnnotationAttribute(Name = "Zamor Ruins", Description = "Mountaintops of the Giants")]
        ZamorRuins = 76501,

        [AnnotationAttribute(Name = "Ancient Snow Valley Ruins", Description = "Mountaintops of the Giants")]
        AncientSnowValleyRuins = 76503,

        [AnnotationAttribute(Name = "Freezing Lake", Description = "Mountaintops of the Giants")]
        FreezingLake = 76504,

        [AnnotationAttribute(Name = "First Church of Marika", Description = "Mountaintops of the Giants")]
        FirstChurchOfMarika = 76505,

        [AnnotationAttribute(Name = "Whiteridge Road", Description = "Mountaintops of the Giants")]
        WhiteridgeRoad = 76520,

        [AnnotationAttribute(Name = "Snow Valley Ruins Overlook", Description = "Mountaintops of the Giants")]
        SnowValleyRuinsOverlook = 76521,

        [AnnotationAttribute(Name = "Castle Sol Main Gate", Description = "Mountaintops of the Giants")]
        CastleSolMainGate = 76522,

        [AnnotationAttribute(Name = "Church of the Eclipse", Description = "Mountaintops of the Giants")]
        ChurchOfTheEclipse = 76523,

        [AnnotationAttribute(Name = "Castle Sol Rooftop", Description = "Mountaintops of the Giants")]
        CastleSolRooftop = 76524,

        //Mt. Gelmir

        [AnnotationAttribute(Name = "Wyndham Catacombs", Description = "Mt. Gelmir")]
        WyndhamCatacombs = 73007,

        [AnnotationAttribute(Name = "Gelmir Hero's Grave", Description = "Mt. Gelmir")]
        GelmirHerosGrave = 73009,

        [AnnotationAttribute(Name = "Seethewater Cave", Description = "Mt. Gelmir")]
        SeethewaterCave = 73107,

        [AnnotationAttribute(Name = "Volcano Cave", Description = "Mt. Gelmir")]
        VolcanoCave = 73109,

        [AnnotationAttribute(Name = "Bridge of Iniquity", Description = "Mt. Gelmir")]
        BridgeOfIniquity = 76350,

        [AnnotationAttribute(Name = "First Mt. Gelmir Campsite", Description = "Mt. Gelmir")]
        FirstMtGelmirCampsite = 76351,

        [AnnotationAttribute(Name = "Ninth Mt. Gelmir Campsite", Description = "Mt. Gelmir")]
        NinthMtGelmirCampsite = 76352,

        [AnnotationAttribute(Name = "Road of Iniquity", Description = "Mt. Gelmir")]
        RoadOfIniquity = 76353,

        [AnnotationAttribute(Name = "Seethewater River", Description = "Mt. Gelmir")]
        SeethewaterRiver = 76354,

        [AnnotationAttribute(Name = "Seethewater Terminus", Description = "Mt. Gelmir")]
        SeethewaterTerminus = 76355,

        [AnnotationAttribute(Name = "Craftsman's Shack", Description = "Mt. Gelmir")]
        CraftsmansShack = 76356,

        [AnnotationAttribute(Name = "Primeval Sorcerer Azur", Description = "Mt. Gelmir")]
        PrimevalSorcererAzur = 76357,

        //Nokron, Eternal City

        [AnnotationAttribute(Name = "Great Waterfall Basin", Description = "Nokron, Eternal City")]
        GreatWaterfallBasin = 71220,

        [AnnotationAttribute(Name = "Mimic Tear", Description = "Nokron, Eternal City")]
        MimicTear = 71221,

        [AnnotationAttribute(Name = "Ancestral Woods", Description = "Nokron, Eternal City")]
        AncestralWoods = 71224,

        [AnnotationAttribute(Name = "Aqueduct-Facing Cliffs", Description = "Nokron, Eternal City")]
        AqueductFacingCliffs = 71225,

        [AnnotationAttribute(Name = "Night's Sacred Ground", Description = "Nokron, Eternal City")]
        NightsSacredGround = 71226,

        [AnnotationAttribute(Name = "Nokron, Eternal City", Description = "Nokron, Eternal City")]
        NokronEternalCity = 71271,

        //Roundtable Hold

        [AnnotationAttribute(Name = "Table of Lost Grace", Description = "Roundtable Hold")]
        TableOfLostGrace = 71190,

        //Ruin-Strewn Precipice

        [AnnotationAttribute(Name = "Magma Wyrm", Description = "Ruin-Strewn Precipice")]
        MagmaWyrm = 73900,

        [AnnotationAttribute(Name = "Ruin-Strewn Precipice", Description = "Ruin-Strewn Precipice")]
        RuinStrewnPrecipice = 73901,

        [AnnotationAttribute(Name = "Ruin-Strewn Precipice Overlook", Description = "Ruin-Strewn Precipice")]
        RuinStrewnPrecipiceOverlook = 73902,

        //Siofra River

        [AnnotationAttribute(Name = "Siofra River Bank", Description = "Siofra River")]
        SiofraRiverBank = 71222,

        [AnnotationAttribute(Name = "Worshippers' Woods", Description = "Siofra River")]
        WorshippersWoods = 71223,

        [AnnotationAttribute(Name = "Below the Well", Description = "Siofra River")]
        BelowTheWell = 71227,

        [AnnotationAttribute(Name = "Siofra River Well Depths", Description = "Siofra River")]
        SiofraRiverWellDepths = 71270,

        //Stormhill

        [AnnotationAttribute(Name = "Deathtouched Catacombs", Description = "Stormhill")]
        DeathtouchedCatacombs = 73011,

        [AnnotationAttribute(Name = "Limgrave Tower Bridge", Description = "Stormhill")]
        LimgraveTowerBridge = 73410,

        [AnnotationAttribute(Name = "Divine Tower of Limgrave", Description = "Stormhill")]
        DivineTowerOfLimgrave = 73412,

        [AnnotationAttribute(Name = "Stormhill Shack", Description = "Stormhill")]
        StormhillShack = 76102,

        [AnnotationAttribute(Name = "Saintsbridge", Description = "Stormhill")]
        Saintsbridge = 76117,

        [AnnotationAttribute(Name = "Warmaster's Shack", Description = "Stormhill")]
        WarmastersShack = 76118,

        //Stormveil Castle

        [AnnotationAttribute(Name = "Godrick the Grafted", Description = "Stormveil Castle")]
        GodrickTheGrafted = 71000,

        [AnnotationAttribute(Name = "Margit, the Fell Omen", Description = "Stormveil Castle")]
        MargitTheFellOmen = 71001,

        [AnnotationAttribute(Name = "Castleward Tunnel", Description = "Stormveil Castle")]
        CastlewardTunnel = 71002,

        [AnnotationAttribute(Name = "Gateside Chamber", Description = "Stormveil Castle")]
        GatesideChamber = 71003,

        [AnnotationAttribute(Name = "Stormveil Cliffside", Description = "Stormveil Castle")]
        StormveilCliffside = 71004,

        [AnnotationAttribute(Name = "Rampart Tower", Description = "Stormveil Castle")]
        RampartTower = 71005,

        [AnnotationAttribute(Name = "Liftside Chamber", Description = "Stormveil Castle")]
        LiftsideChamber = 71006,

        [AnnotationAttribute(Name = "Secluded Cell", Description = "Stormveil Castle")]
        SecludedCell = 71007,

        [AnnotationAttribute(Name = "Stormveil Main Gate", Description = "Stormveil Castle")]
        StormveilMainGate = 71008,

        //Stranded Graveyard

        [AnnotationAttribute(Name = "Cave of Knowledge", Description = "Stranded Graveyard")]
        CaveOfKnowledge = 71800,

        [AnnotationAttribute(Name = "Stranded Graveyard", Description = "Stranded Graveyard")]
        StrandedGraveyard = 71801,

        //Subterranean Shunning-Grounds

        [AnnotationAttribute(Name = "Cathedral of the Forsaken", Description = "Subterranean Shunning-Grounds")]
        CathedralOfTheForsaken = 73500,

        [AnnotationAttribute(Name = "Underground Roadside", Description = "Subterranean Shunning-Grounds")]
        UndergroundRoadside = 73501,

        [AnnotationAttribute(Name = "Forsaken Depths", Description = "Subterranean Shunning-Grounds")]
        ForsakenDepths = 73502,

        [AnnotationAttribute(Name = "Leyndell Catacombs", Description = "Subterranean Shunning-Grounds")]
        LeyndellCatacombs = 73503,

        [AnnotationAttribute(Name = "Frenzied Flame Proscription", Description = "Subterranean Shunning-Grounds")]
        FrenziedFlameProscription = 73504,

        //Swamp of Aeonia

        [AnnotationAttribute(Name = "Aeonia Swamp Shore", Description = "Swamp of Aeonia")]
        AeoniaSwampShore = 76406,

        [AnnotationAttribute(Name = "Astray from Caelid Highway North", Description = "Swamp of Aeonia")]
        AstrayfromCaelidHighwayNorth = 76407,

        [AnnotationAttribute(Name = "Heart of Aeonia", Description = "Swamp of Aeonia")]
        HeartOfAeonia = 76412,

        [AnnotationAttribute(Name = "Inner Aeonia", Description = "Swamp of Aeonia")]
        InnerAeonia = 76413,

        //Volcano Manor

        [AnnotationAttribute(Name = "Rykard, Lord of Blasphemy", Description = "Volcano Manor")]
        RykardLordOfBlasphemy = 71600,

        [AnnotationAttribute(Name = "Temple of Eiglay", Description = "Volcano Manor")]
        TempleOfEiglay = 71601,

        [AnnotationAttribute(Name = "Volcano Manor", Description = "Volcano Manor")]
        VolcanoManor = 71602,

        [AnnotationAttribute(Name = "Prison Town Church", Description = "Volcano Manor")]
        PrisonTownChurch = 71603,

        [AnnotationAttribute(Name = "Guest Hall", Description = "Volcano Manor")]
        GuestHall = 71604,

        [AnnotationAttribute(Name = "Audience Pathway", Description = "Volcano Manor")]
        AudiencePathway = 71605,

        [AnnotationAttribute(Name = "Abductor Virgin", Description = "Volcano Manor")]
        AbductorVirgin = 71606,

        [AnnotationAttribute(Name = "Subterranean Inquisition Chamber", Description = "Volcano Manor")]
        SubterraneanInquisitionChamber = 71607,

        //Weeping Peninsula

        [AnnotationAttribute(Name = "Tombsward Catacombs", Description = "Weeping Peninsula")]
        TombswardCatacombs = 73000,

        [AnnotationAttribute(Name = "Impaler's Catacombs", Description = "Weeping Peninsula")]
        ImpalersCatacombs = 73001,

        [AnnotationAttribute(Name = "Earthbore Cave", Description = "Weeping Peninsula")]
        EarthboreCave = 73101,

        [AnnotationAttribute(Name = "Tombsward Cave", Description = "Weeping Peninsula")]
        TombswardCave = 73102,

        [AnnotationAttribute(Name = "Morne Tunnel", Description = "Weeping Peninsula")]
        MorneTunnel = 73200,

        [AnnotationAttribute(Name = "Church of Pilgrimage", Description = "Weeping Peninsula")]
        ChurchOfPilgrimage = 76150,

        [AnnotationAttribute(Name = "Castle Morne Rampart", Description = "Weeping Peninsula")]
        CastleMorneRampart = 76151,

        [AnnotationAttribute(Name = "Tombsward", Description = "Weeping Peninsula")]
        Tombsward = 76152,

        [AnnotationAttribute(Name = "South of the Lookout Tower", Description = "Weeping Peninsula")]
        SouthOfTheLookoutTower = 76153,

        [AnnotationAttribute(Name = "Ailing Village Outskirts", Description = "Weeping Peninsula")]
        AilingVillageOutskirts = 76154,

        [AnnotationAttribute(Name = "Beside the Crater-Pocked Glade", Description = "Weeping Peninsula")]
        BesideTheCraterPockedGlade = 76155,

        [AnnotationAttribute(Name = "Isolated Merchant's Shack (Weeping Peninsula)", Description = "Weeping Peninsula")]
        IsolatedMerchantsShackWeepingPeninsula = 76156,

        [AnnotationAttribute(Name = "Bridge of Sacrifice", Description = "Weeping Peninsula")]
        BridgeOfSacrifice = 76157,

        [AnnotationAttribute(Name = "Castle Morne Lift", Description = "Weeping Peninsula")]
        CastleMorneLift = 76158,

        [AnnotationAttribute(Name = "Behind the Castle", Description = "Weeping Peninsula")]
        BehindTheCastle = 76159,

        [AnnotationAttribute(Name = "Beside the Rampart Gaol", Description = "Weeping Peninsula")]
        BesideTheRampartGaol = 76160,

        [AnnotationAttribute(Name = "Morne Moangrave", Description = "Weeping Peninsula")]
        MorneMoangrave = 76161,

        [AnnotationAttribute(Name = "Fourth Church of Marika", Description = "Weeping Peninsula")]
        FourthChurchOfMarika = 76162,

        // The Realm of Shadow
        [AnnotationAttribute(Name = "Theatre of the Divine Beast", Description = "Belurat, Tower Settlement")]
        TheatreoftheDivineBeast = 72000,

        [AnnotationAttribute(Name = "Belurat, Tower Settlement", Description = "Belurat, Tower Settlement")]
        BeluratTowerSettlement = 72001,

        [AnnotationAttribute(Name = "Small Private Altar", Description = "Belurat, Tower Settlement")]
        SmallPrivateAltar = 72002,

        [AnnotationAttribute(Name = "Stagefront", Description = "Belurat, Tower Settlement")]
        Stagefront = 72003,

        [AnnotationAttribute(Name = "Gate of Divinity", Description = "Enir-Ilim")]
        GateofDivinity = 72010,

        [AnnotationAttribute(Name = "Enir-Ilim: Outer Wall", Description = "Enir-Ilim")]
        EnirIlimOuterWall = 72012,

        [AnnotationAttribute(Name = "First Rise", Description = "Enir-Ilim")]
        FirstRise = 72013,

        [AnnotationAttribute(Name = "Spiral Rise", Description = "Enir-Ilim")]
        SpiralRise = 72014,

        [AnnotationAttribute(Name = "Cleansing Chamber Anteroom", Description = "Enir-Ilim")]
        CleansingChamberAnteroom = 72015,

        [AnnotationAttribute(Name = "Divine Gate Front Staircase", Description = "Enir-Ilim")]
        DivineGateFrontStaircase = 72016,

        [AnnotationAttribute(Name = "Main Gate Plaza", Description = "Shadow Keep")]
        MainGatePlaza = 72101,

        [AnnotationAttribute(Name = "Shadow Keep Main Gate", Description = "Shadow Keep")]
        ShadowKeepMainGate = 72102,

        [AnnotationAttribute(Name = "Church District Entrance", Description = "Shadow Keep, Church District")]
        ChurchDistrictEntrance = 72106,

        [AnnotationAttribute(Name = "Sunken Chapel", Description = "Shadow Keep, Church District")]
        SunkenChapel = 72107,

        [AnnotationAttribute(Name = "Tree,Worship Passage", Description = "Shadow Keep, Church District")]
        TreeWorshipPassage = 72108,

        [AnnotationAttribute(Name = "Tree,Worship Sanctum", Description = "Shadow Keep, Church District")]
        TreeWorshipSanctum = 72109,

        [AnnotationAttribute(Name = "Messmer's Dark Chamber", Description = "Specimen Storehouse")]
        MessmersDarkChamber = 72110,

        [AnnotationAttribute(Name = "Storehouse, First Floor", Description = "Specimen Storehouse")]
        StorehouseFirstFloor = 72111,

        [AnnotationAttribute(Name = "Storehouse, Fourth Floor", Description = "Specimen Storehouse")]
        StorehouseFourthFloor = 72112,

        [AnnotationAttribute(Name = "Storehouse, Seventh Floor", Description = "Specimen Storehouse")]
        StorehouseSeventhFloor = 72113,

        [AnnotationAttribute(Name = "Dark Chamber Entrance", Description = "Specimen Storehouse")]
        DarkChamberEntrance = 72114,

        [AnnotationAttribute(Name = "Storehouse, Back Section", Description = "Specimen Storehouse")]
        StorehouseBackSection = 72116,

        [AnnotationAttribute(Name = "Storehouse, Loft", Description = "Specimen Storehouse")]
        StorehouseLoft = 72117,

        [AnnotationAttribute(Name = "West Rampart", Description = "Specimen Storehouse")]
        WestRampart = 72120,

        [AnnotationAttribute(Name = "Garden of Deep Purple", Description = "Stone Coffin Fissure")]
        GardenofDeepPurple = 72200,

        [AnnotationAttribute(Name = "Stone Coffin Fissure", Description = "Stone Coffin Fissure")]
        StoneCoffinFissure = 72201,

        [AnnotationAttribute(Name = "Fissure Cross", Description = "Stone Coffin Fissure")]
        FissureCross = 72202,

        [AnnotationAttribute(Name = "Fissure Waypoint", Description = "Stone Coffin Fissure")]
        FissureWaypoint = 72203,

        [AnnotationAttribute(Name = "Fissure Depths", Description = "Stone Coffin Fissure")]
        FissureDepths = 72204,

        [AnnotationAttribute(Name = "Finger Birthing Grounds", Description = "Scadu Altus")]
        FingerBirthingGrounds = 72500,

        [AnnotationAttribute(Name = "Discussion Chamber", Description = "Midra's Manse")]
        DiscussionChamber = 72800,

        [AnnotationAttribute(Name = "Manse Hall", Description = "Midra's Manse")]
        ManseHall = 72801,

        [AnnotationAttribute(Name = "Midra's Library", Description = "Midra's Manse")]
        MidrasLibrary = 72802,

        [AnnotationAttribute(Name = "Second Floor Chamber", Description = "Midra's Manse")]
        SecondFloorChamber = 72803,

        [AnnotationAttribute(Name = "Fog Rift Catacombs", Description = "Gravesite Plain")]
        FogRiftCatacombs = 74000,

        [AnnotationAttribute(Name = "Ruined Forge Lava Intake", Description = "Gravesite Plain")]
        RuinedForgeLavaIntake = 74200,

        [AnnotationAttribute(Name = "Rivermouth Cave", Description = "Gravesite Plain")]
        RivermouthCave = 74300,

        [AnnotationAttribute(Name = "Dragon's Pit", Description = "Gravesite Plain")]
        DragonsPit = 74301,

        [AnnotationAttribute(Name = "Dragon's Pit Terminus", Description = "Gravesite Plain")]
        DragonsPitTerminus = 74351,

        [AnnotationAttribute(Name = "Cliffroad Terminus", Description = "Gravesite Plain")]
        CliffroadTerminus = 76804,

        [AnnotationAttribute(Name = "Main Gate Cross", Description = "Gravesite Plain")]
        MainGateCross = 76803,

        [AnnotationAttribute(Name = "Gravesite Plain", Description = "Gravesite Plain")]
        GravesitePlain = 76800,

        [AnnotationAttribute(Name = "Three,Path Cross", Description = "Gravesite Plain")]
        ThreePathCross = 76802,

        [AnnotationAttribute(Name = "Greatbridge, North", Description = "Gravesite Plain")]
        GreatbridgeNorth = 76805,

        [AnnotationAttribute(Name = "Scorched Ruins", Description = "Gravesite Plain")]
        ScorchedRuins = 76801,

        [AnnotationAttribute(Name = "Ellac River Cave", Description = "Gravesite Plain")]
        EllacRiverCave = 76812,

        [AnnotationAttribute(Name = "Castle Front", Description = "Gravesite Plain")]
        CastleFront = 76813,

        [AnnotationAttribute(Name = "Pillar Path Waypoint", Description = "Gravesite Plain")]
        PillarPathWaypoint = 76811,

        [AnnotationAttribute(Name = "Pillar Path Cross", Description = "Gravesite Plain")]
        PillarPathCross = 76810,

        [AnnotationAttribute(Name = "Belurat Gaol", Description = "Gravesite Plain")]
        BeluratGaol = 74100,

        [AnnotationAttribute(Name = "Ellac River Downstream", Description = "Gravesite Plain")]
        EllacRiverDownstream = 76830,

        [AnnotationAttribute(Name = "Charo's Hidden Grave", Description = "Charo's Hidden Grave")]
        CharosHiddenGrave = 76841,

        [AnnotationAttribute(Name = "Lamenter's Gaol", Description = "Charo's Hidden Grave")]
        LamentersGaol = 74102,

        [AnnotationAttribute(Name = "Castle Ensis Checkpoint", Description = "Castle Ensis")]
        CastleEnsisCheckpoint = 76821,

        [AnnotationAttribute(Name = "Ensis Moongazing Grounds", Description = "Castle Ensis")]
        EnsisMoongazingGrounds = 76823,

        [AnnotationAttribute(Name = "Castle,Lord's Chamber", Description = "Castle Ensis")]
        CastleLordsChamber = 76822,

        [AnnotationAttribute(Name = "Cerulean Coast West", Description = "Cerulean Coast")]
        CeruleanCoastWest = 76832,

        [AnnotationAttribute(Name = "The Fissure", Description = "Cerulean Coast")]
        TheFissure = 76833,

        [AnnotationAttribute(Name = "Cerulean Coast Cross", Description = "Cerulean Coast")]
        CeruleanCoastCross = 76835,

        [AnnotationAttribute(Name = "Cerulean Coast", Description = "Cerulean Coast")]
        CeruleanCoast = 76831,

        [AnnotationAttribute(Name = "Finger Ruins of Rhia", Description = "Cerulean Coast")]
        FingerRuinsofRhia = 76834,

        [AnnotationAttribute(Name = "Grand Altar of Dragon Communion", Description = "Foot of the Jagged Peak")]
        GrandAltarofDragonCommunion = 76840,

        [AnnotationAttribute(Name = "Divided Falls", Description = "Abyssal Woods")]
        DividedFalls = 76861,

        [AnnotationAttribute(Name = "Abyssal Woods", Description = "Abyssal Woods")]
        AbyssalWoods = 76860,

        [AnnotationAttribute(Name = "Forsaken Graveyard", Description = "Abyssal Woods")]
        ForsakenGraveyard = 76862,

        [AnnotationAttribute(Name = "Church Ruins", Description = "Abyssal Woods")]
        ChurchRuins = 76864,

        [AnnotationAttribute(Name = "Woodland Trail", Description = "Abyssal Woods")]
        WoodlandTrail = 76863,

        [AnnotationAttribute(Name = "Foot of the Jagged Peak", Description = "Foot of the Jagged Peak")]
        FootoftheJaggedPeak = 76850,

        [AnnotationAttribute(Name = "Jagged Peak Mountainside", Description = "Jagged Peak")]
        JaggedPeakMountainside = 76851,

        [AnnotationAttribute(Name = "Jagged Peak Summit", Description = "Jagged Peak")]
        JaggedPeakSummit = 76852,

        [AnnotationAttribute(Name = "Rest of the Dread Dragon", Description = "Jagged Peak")]
        RestoftheDreadDragon = 76853,

        [AnnotationAttribute(Name = "Ancient Ruins, Grand Stairway", Description = "Ancient Ruins of Rauh")]
        AncientRuinsGrandStairway = 76944,

        [AnnotationAttribute(Name = "Church of the Bud", Description = "Ancient Ruins of Rauh")]
        ChurchoftheBud = 76945,

        [AnnotationAttribute(Name = "Church of the Bud, Main Entrance", Description = "Ancient Ruins of Rauh")]
        ChurchoftheBudMainEntrance = 76943,

        [AnnotationAttribute(Name = "Rauh Ancient Ruins, West", Description = "Ancient Ruins of Rauh")]
        RauhAncientRuinsWest = 76942,

        [AnnotationAttribute(Name = "Rauh Ancient Ruins, East", Description = "Ancient Ruins of Rauh")]
        RauhAncientRuinsEast = 76941,

        [AnnotationAttribute(Name = "Viaduct Minor Tower", Description = "Ancient Ruins of Rauh")]
        ViaductMinorTower = 76940,

        [AnnotationAttribute(Name = "Temple Town Ruins", Description = "Rauh Base")]
        TempleTownRuins = 76913,

        [AnnotationAttribute(Name = "Ravine North", Description = "Rauh Base")]
        RavineNorth = 76914,

        [AnnotationAttribute(Name = "Scorpion River Catacombs", Description = "Rauh Base")]
        ScorpionRiverCatacombs = 74001,

        [AnnotationAttribute(Name = "Taylew's Ruined Forge", Description = "Rauh Base")]
        TaylewsRuinedForge = 74203,

        [AnnotationAttribute(Name = "Ancient Ruins Base", Description = "Rauh Base")]
        AncientRuinsBase = 76912,

        [AnnotationAttribute(Name = "Darklight Catacombs", Description = "Scadu Altus")]
        DarklightCatacombs = 74002,

        [AnnotationAttribute(Name = "Bonny Gaol", Description = "Scadu Altus")]
        BonnyGaol = 74101,

        [AnnotationAttribute(Name = "Highroad Cross", Description = "Scadu Altus")]
        HighroadCross = 76900,

        [AnnotationAttribute(Name = "Scadu Altus, West", Description = "Scadu Altus")]
        ScaduAltusWest = 76907,

        [AnnotationAttribute(Name = "Moorth Highway, South", Description = "Scadu Altus")]
        MoorthHighwaySouth = 76908,

        [AnnotationAttribute(Name = "Fort of Reprimand", Description = "Scadu Altus")]
        FortofReprimand = 76909,

        [AnnotationAttribute(Name = "Behind the Fort of Reprimand", Description = "Scadu Altus")]
        BehindtheFortofReprimand = 76910,

        [AnnotationAttribute(Name = "Moorth Ruins", Description = "Scadu Altus")]
        MoorthRuins = 76902,

        [AnnotationAttribute(Name = "Bonny Village", Description = "Scadu Altus")]
        BonnyVillage = 76903,

        [AnnotationAttribute(Name = "Castle Watering Hole", Description = "Scadu Altus")]
        CastleWateringHole = 76916,

        [AnnotationAttribute(Name = "Ruined Forge of Starfall Past", Description = "Scadu Altus")]
        RuinedForgeofStarfallPast = 74202,

        [AnnotationAttribute(Name = "Scaduview Cross", Description = "Scadu Altus")]
        ScaduviewCross = 76911,

        [AnnotationAttribute(Name = "Recluses' River Downstream", Description = "Scadu Altus")]
        ReclusesRiverDownstream = 76918,

        [AnnotationAttribute(Name = "Recluses' River Upstream", Description = "Scadu Altus")]
        ReclusesRiverUpstream = 76917,

        [AnnotationAttribute(Name = "Bridge Leading to the Village", Description = "Scadu Altus")]
        BridgeLeadingtotheVillage = 76904,

        [AnnotationAttribute(Name = "Cathedral of Manus Metyr", Description = "Scadu Altus")]
        CathedralofManusMetyr = 76906,

        [AnnotationAttribute(Name = "Church District Highroad", Description = "Scadu Altus")]
        ChurchDistrictHighroad = 76905,

        [AnnotationAttribute(Name = "Scaduview", Description = "Scaduview")]
        Scaduview = 76930,

        [AnnotationAttribute(Name = "Shadow Keep, Back Gate", Description = "Scaduview")]
        ShadowKeepBackGate = 76931,

        [AnnotationAttribute(Name = "Fingerstone Hill", Description = "Scaduview")]
        FingerstoneHill = 76936,

        [AnnotationAttribute(Name = "Hinterland Bridge", Description = "Scaduview")]
        HinterlandBridge = 76937,

        [AnnotationAttribute(Name = "Hinterland", Description = "Scaduview")]
        Hinterland = 76935,

        [AnnotationAttribute(Name = "Scadutree Base", Description = "Scaduview")]
        ScadutreeBase = 76960,
    }
}
