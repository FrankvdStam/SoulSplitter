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

namespace SoulMemory.Games.EldenRing;

public enum Grace : uint
{
    //Academy of Raya Lucaria

    [Annotation(Name = "Raya Lucaria Grand Library", Description = "Academy of Raya Lucaria")]
    RayaLucariaGrandLibrary = 71400,

    [Annotation(Name = "Debate Parlor", Description = "Academy of Raya Lucaria")]
    DebateParlor = 71401,

    [Annotation(Name = "Church of the Cuckoo", Description = "Academy of Raya Lucaria")]
    ChurchOfTheCuckoo = 71402,

    [Annotation(Name = "Schoolhouse Classroom", Description = "Academy of Raya Lucaria")]
    SchoolhouseClassroom = 71403,

    //Ainsel River

    [Annotation(Name = "Dragonkin Soldier of Nokstella", Description = "Ainsel River")]
    DragonkinSoldierOfNokstella = 71210,

    [Annotation(Name = "Ainsel River Well Depths", Description = "Ainsel River")]
    AinselRiverWellDepths = 71211,

    [Annotation(Name = "Ainsel River Sluice Gate", Description = "Ainsel River")]
    AinselRiverSluiceGate = 71212,

    [Annotation(Name = "Ainsel River Downstream", Description = "Ainsel River")]
    AinselRiverDownstream = 71213,

    [Annotation(Name = "Astel, Naturalborn of the Void", Description = "Ainsel River")]
    AstelNaturalbornOfTheVoid = 71240,

    //Ainsel River Main

    [Annotation(Name = "Ainsel River Main", Description = "Ainsel River Main")]
    AinselRiverMain = 71214,

    [Annotation(Name = "Nokstella, Eternal City", Description = "Ainsel River Main")]
    NokstellaEternalCity = 71215,

    [Annotation(Name = "Nokstella Waterfall Basin", Description = "Ainsel River Main")]
    NokstellaWaterfallBasin = 71219,

    //Altus Plateau

    [Annotation(Name = "Sainted Hero's Grave", Description = "Altus Plateau")]
    SaintedHerosGrave = 73008,

    [Annotation(Name = "Unsightly Catacombs", Description = "Altus Plateau")]
    UnsightlyCatacombs = 73012,

    [Annotation(Name = "Perfumer's Grotto", Description = "Altus Plateau")]
    PerfumersGrotto = 73118,

    [Annotation(Name = "Sage's Cave", Description = "Altus Plateau")]
    SagesCave = 73119,

    [Annotation(Name = "Old Altus Tunnel", Description = "Altus Plateau")]
    OldAltusTunnel = 73204,

    [Annotation(Name = "Altus Tunnel", Description = "Altus Plateau")]
    AltusTunnel = 73205,

    [Annotation(Name = "Abandoned Coffin", Description = "Altus Plateau")]
    AbandonedCoffin = 76300,

    [Annotation(Name = "Altus Plateau", Description = "Altus Plateau")]
    AltusPlateau = 76301,

    [Annotation(Name = "Erdtree-Gazing Hill", Description = "Altus Plateau")]
    ErdtreeGazingHill = 76302,

    [Annotation(Name = "Altus Highway Junction", Description = "Altus Plateau")]
    AltusHighwayJunction = 76303,

    [Annotation(Name = "Forest-Spanning Greatbridge", Description = "Altus Plateau")]
    ForestSpanningGreatbridge = 76304,

    [Annotation(Name = "Rampartside Path", Description = "Altus Plateau")]
    RampartsidePath = 76305,

    [Annotation(Name = "Bower of Bounty", Description = "Altus Plateau")]
    BowerOfBounty = 76306,

    [Annotation(Name = "Road of Iniquity Side Path", Description = "Altus Plateau")]
    RoadOfIniquitySidePath = 76307,

    [Annotation(Name = "Windmill Village", Description = "Altus Plateau")]
    WindmillVillage = 76308,

    [Annotation(Name = "Windmill Heights", Description = "Altus Plateau")]
    WindmillHeights = 76313,

    [Annotation(Name = "Shaded Castle Ramparts", Description = "Altus Plateau")]
    ShadedCastleRamparts = 76320,

    [Annotation(Name = "Shaded Castle Inner Gate", Description = "Altus Plateau")]
    ShadedCastleInnerGate = 76321,

    [Annotation(Name = "Castellan's Hall", Description = "Altus Plateau")]
    CastellansHall = 76322,

    //Bellum Highway

    [Annotation(Name = "East Raya Lucaria Gate", Description = "Bellum Highway")]
    EastRayaLucariaGate = 76207,

    [Annotation(Name = "Bellum Church", Description = "Bellum Highway")]
    BellumChurch = 76208,

    [Annotation(Name = "Frenzied Flame Village Outskirts", Description = "Bellum Highway")]
    FrenziedFlameVillageOutskirts = 76239,

    [Annotation(Name = "Church of Inhibition", Description = "Bellum Highway")]
    ChurchOfInhibition = 76240,

    //Caelid

    [Annotation(Name = "Minor Erdtree Catacombs", Description = "Caelid")]
    MinorErdtreeCatacombs = 73014,

    [Annotation(Name = "Caelid Catacombs", Description = "Caelid")]
    CaelidCatacombs = 73015,

    [Annotation(Name = "War-Dead Catacombs", Description = "Caelid")]
    WarDeadCatacombs = 73016,

    [Annotation(Name = "Abandoned Cave", Description = "Caelid")]
    AbandonedCave = 73120,

    [Annotation(Name = "Gaol Cave", Description = "Caelid")]
    GaolCave = 73121,

    [Annotation(Name = "Gael Tunnel", Description = "Caelid")]
    GaelTunnel = 73207,

    [Annotation(Name = "Rear Gael Tunnel Entrance", Description = "Caelid")]
    RearGaelTunnelEntrance = 73207,

    [Annotation(Name = "Sellia Crystal Tunnel", Description = "Caelid")]
    SelliaCrystalTunnel = 73208,

    [Annotation(Name = "Smoldering Church", Description = "Caelid")]
    SmolderingChurch = 76400,

    [Annotation(Name = "Rotview Balcony", Description = "Caelid")]
    RotviewBalcony = 76401,

    [Annotation(Name = "Fort Gael North", Description = "Caelid")]
    FortGaelNorth = 76402,

    [Annotation(Name = "Caelem Ruins", Description = "Caelid")]
    CaelemRuins = 76403,

    [Annotation(Name = "Cathedral of Dragon Communion", Description = "Caelid")]
    CathedralOfDragonCommunion = 76404,

    [Annotation(Name = "Caelid Highway South", Description = "Caelid")]
    CaelidHighwaySouth = 76405,

    [Annotation(Name = "Smoldering Wall", Description = "Caelid")]
    SmolderingWall = 76409,

    [Annotation(Name = "Deep Siofra Well", Description = "Caelid")]
    DeepSiofraWell = 76410,

    [Annotation(Name = "Southern Aeonia Swamp Bank", Description = "Caelid")]
    SouthernAeoniaSwampBank = 76411,

    [Annotation(Name = "Sellia Backstreets", Description = "Caelid")]
    SelliaBackstreets = 76414,

    [Annotation(Name = "Chair-Crypt of Sellia", Description = "Caelid")]
    ChairCryptOfSellia = 76415,

    [Annotation(Name = "Sellia Under-Stair", Description = "Caelid")]
    SelliaUnderStair = 76416,

    [Annotation(Name = "Impassable Greatbridge", Description = "Caelid")]
    ImpassableGreatbridge = 76417,

    [Annotation(Name = "Church of the Plague", Description = "Caelid")]
    ChurchOfThePlague = 76418,

    [Annotation(Name = "Redmane Castle Plaza", Description = "Caelid")]
    RedmaneCastlePlaza = 76419,

    [Annotation(Name = "Chamber Outside the Plaza", Description = "Caelid")]
    ChamberOutsideThePlaza = 76420,

    [Annotation(Name = "Starscourge Radahn", Description = "Caelid")]
    StarscourgeRadahn = 76422,

    //Capital Outskirts

    [Annotation(Name = "Auriza Hero's Grave", Description = "Capital Outskirts")]
    AurizaHerosGrave = 73010,

    [Annotation(Name = "Auriza Side Tomb", Description = "Capital Outskirts")]
    AurizaSideTomb = 73013,

    [Annotation(Name = "Divine Tower of West Altus", Description = "Capital Outskirts")]
    DivineTowerOfWestAltus = 73430,

    [Annotation(Name = "Sealed Tunnel", Description = "Capital Outskirts")]
    SealedTunnel = 73431,

    [Annotation(Name = "Divine Tower of West Altus: Gate", Description = "Capital Outskirts")]
    DivineTowerOfWestAltusGate = 73432,

    [Annotation(Name = "Outer Wall Phantom Tree", Description = "Capital Outskirts")]
    OuterWallPhantomTree = 76309,

    [Annotation(Name = "Minor Erdtree Church", Description = "Capital Outskirts")]
    MinorErdtreeChurch = 76310,

    [Annotation(Name = "Hermit Merchant's Shack", Description = "Capital Outskirts")]
    HermitMerchantsShack = 76311,

    [Annotation(Name = "Outer Wall Battleground", Description = "Capital Outskirts")]
    OuterWallBattleground = 76312,

    [Annotation(Name = "Capital Rampart", Description = "Capital Outskirts")]
    CapitalRampart = 76314,

    //Consecrated Snowfield

    [Annotation(Name = "Consecrated Snowfield Catacombs", Description = "Consecrated Snowfield")]
    ConsecratedSnowfieldCatacombs = 73019,

    [Annotation(Name = "Cave of the Forlorn", Description = "Consecrated Snowfield")]
    CaveOfTheForlorn = 73112,

    [Annotation(Name = "Yelough Anix Tunnel", Description = "Consecrated Snowfield")]
    YeloughAnixTunnel = 73211,

    [Annotation(Name = "Consecrated Snowfield", Description = "Consecrated Snowfield")]
    ConsecratedSnowfield = 76550,

    [Annotation(Name = "Inner Consecrated Snowfield", Description = "Consecrated Snowfield")]
    InnerConsecratedSnowfield = 76551,

    [Annotation(Name = "Ordina, Liturgical Town", Description = "Consecrated Snowfield")]
    OrdinaLiturgicalTown = 76652,

    [Annotation(Name = "Apostate Derelict", Description = "Consecrated Snowfield")]
    ApostateDerelict = 76653,

    //Crumbling Farum Azula

    [Annotation(Name = "Maliketh, the Black Blade", Description = "Crumbling Farum Azula")]
    MalikethTheBlackBlade = 71300,

    [Annotation(Name = "Dragonlord Placidusax", Description = "Crumbling Farum Azula")]
    DragonlordPlacidusax = 71301,

    [Annotation(Name = "Dragon Temple Altar", Description = "Crumbling Farum Azula")]
    DragonTempleAltar = 71302,

    [Annotation(Name = "Crumbling Beast Grave", Description = "Crumbling Farum Azula")]
    CrumblingBeastGrave = 71303,

    [Annotation(Name = "Crumbling Beast Grave Depths", Description = "Crumbling Farum Azula")]
    CrumblingBeastGraveDepths = 71304,

    [Annotation(Name = "Tempest-Facing Balcony", Description = "Crumbling Farum Azula")]
    TempestFacingBalcony = 71305,

    [Annotation(Name = "Dragon Temple", Description = "Crumbling Farum Azula")]
    DragonTemple = 71306,

    [Annotation(Name = "Dragon Temple Transept", Description = "Crumbling Farum Azula")]
    DragonTempleTransept = 71307,

    [Annotation(Name = "Dragon Temple Lift", Description = "Crumbling Farum Azula")]
    DragonTempleLift = 71308,

    [Annotation(Name = "Dragon Temple Rooftop", Description = "Crumbling Farum Azula")]
    DragonTempleRooftop = 71309,

    [Annotation(Name = "Beside the Great Bridge", Description = "Crumbling Farum Azula")]
    BesideTheGreatBridge = 71310,

    //Deeproot Depths

    [Annotation(Name = "Prince of Death's Throne", Description = "Deeproot Depths")]
    PrinceOfDeathsThrone = 71230,

    [Annotation(Name = "Root-Facing Cliffs", Description = "Deeproot Depths")]
    RootFacingCliffs = 71231,

    [Annotation(Name = "Great Waterfall Crest", Description = "Deeproot Depths")]
    GreatWaterfallCrest = 71232,

    [Annotation(Name = "Deeproot Depths", Description = "Deeproot Depths")]
    DeeprootDepths = 71233,

    [Annotation(Name = "The Nameless Eternal City", Description = "Deeproot Depths")]
    TheNamelessEternalCity = 71234,

    [Annotation(Name = "Across the Roots", Description = "Deeproot Depths")]
    AcrossTheRoots = 71235,

    //Elden Throne

    [Annotation(Name = "Fractured Marika", Description = "Elden Throne")]
    FracturedMarika = 71900,

    //Elphael, Brace of the Haligtree

    [Annotation(Name = "Malenia, Goddess of Rot", Description = "Elphael, Brace of the Haligtree")]
    MaleniaGoddessOfRot = 71500,

    [Annotation(Name = "Prayer Room", Description = "Elphael, Brace of the Haligtree")]
    PrayerRoom = 71501,

    [Annotation(Name = "Elphael Inner Wall", Description = "Elphael, Brace of the Haligtree")]
    ElphaelInnerWall = 71502,

    [Annotation(Name = "Drainage Channel", Description = "Elphael, Brace of the Haligtree")]
    DrainageChannel = 71503,

    [Annotation(Name = "Haligtree Roots", Description = "Elphael, Brace of the Haligtree")]
    HaligtreeRoots = 71504,

    //Flame Peak

    [Annotation(Name = "Giant-Conquering Hero's Grave", Description = "Flame Peak")]
    GiantConqueringHerosGrave = 73017,

    [Annotation(Name = "Giants' Mountaintop Catacombs", Description = "Flame Peak")]
    GiantsMountaintopCatacombs = 73018,

    [Annotation(Name = "Giants' Gravepost", Description = "Flame Peak")]
    GiantsGravepost = 76506,

    [Annotation(Name = "Church of Repose", Description = "Flame Peak")]
    ChurchOfRepose = 76507,

    [Annotation(Name = "Foot of the Forge", Description = "Flame Peak")]
    FootOfTheForge = 76508,

    [Annotation(Name = "Fire Giant", Description = "Flame Peak")]
    FireGiant = 76509,

    [Annotation(Name = "Forge of the Giants", Description = "Flame Peak")]
    ForgeOfTheGiants = 76510,

    //Forbidden Lands

    [Annotation(Name = "Hidden Path to the Haligtree", Description = "Forbidden Lands")]
    HiddenPathToTheHaligtree = 73020,

    [Annotation(Name = "Divine Tower of East Altus: Gate", Description = "Forbidden Lands")]
    DivineTowerOfEastAltusGate = 73450,

    [Annotation(Name = "Divine Tower of East Altus", Description = "Forbidden Lands")]
    DivineTowerOfEastAltus = 73451,

    [Annotation(Name = "Forbidden Lands", Description = "Forbidden Lands")]
    ForbiddenLands = 76500,

    [Annotation(Name = "Grand Lift of Rold", Description = "Forbidden Lands")]
    GrandLiftOfRold = 76502,

    //Greyoll's Dragonbarrow

    [Annotation(Name = "Dragonbarrow Cave", Description = "Greyoll's Dragonbarrow")]
    DragonbarrowCave = 73110,

    [Annotation(Name = "Sellia Hideaway", Description = "Greyoll's Dragonbarrow")]
    SelliaHideaway = 73111,

    [Annotation(Name = "Divine Tower of Caelid", Description = "Greyoll's Dragonbarrow")]
    DivineTowerOfCaelid = 73440,

    [Annotation(Name = "Divine Tower of Caelid: Center", Description = "Greyoll's Dragonbarrow")]
    DivineTowerOfCaelidCenter = 73441,

    [Annotation(Name = "Isolated Divine Tower", Description = "Greyoll's Dragonbarrow")]
    IsolatedDivineTower = 73460,

    [Annotation(Name = "Dragonbarrow West", Description = "Greyoll's Dragonbarrow")]
    DragonbarrowWest = 76450,

    [Annotation(Name = "Isolated Merchant's Shack (Greyoll's Dragonbarrow)", Description = "Greyoll's Dragonbarrow")]
    IsolatedMerchantsShackGreyollsDragonbarrow = 76451,

    [Annotation(Name = "Dragonbarrow Fork", Description = "Greyoll's Dragonbarrow")]
    DragonbarrowFork = 76452,

    [Annotation(Name = "Fort Faroth", Description = "Greyoll's Dragonbarrow")]
    FortFaroth = 76453,

    [Annotation(Name = "Bestial Sanctum", Description = "Greyoll's Dragonbarrow")]
    BestialSanctum = 76454,

    [Annotation(Name = "Lenne's Rise", Description = "Greyoll's Dragonbarrow")]
    LennesRise = 76455,

    [Annotation(Name = "Farum Greatbridge", Description = "Greyoll's Dragonbarrow")]
    FarumGreatbridge = 76456,

    //Lake of Rot

    [Annotation(Name = "Lake of Rot Shoreside", Description = "Lake of Rot")]
    LakeOfRotShoreside = 71216,

    [Annotation(Name = "Grand Cloister", Description = "Lake of Rot")]
    GrandCloister = 71218,

    //Leyndell, Ashen Capital

    [Annotation(Name = "Elden Throne (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
    EldenThroneLeyndellAshenCapital = 71120,

    [Annotation(Name = "Erdtree Sanctuary (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
    ErdtreeSanctuaryLeyndellAshenCapital = 71121,

    [Annotation(Name = "East Capital Rampart (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
    EastCapitalRampartLeyndellAshenCapital = 71122,

    [Annotation(Name = "Leyndell, Capital of Ash", Description = "Leyndell, Ashen Capital")]
    LeyndellCapitalOfAsh = 71123,

    [Annotation(Name = "Queen's Bedchamber (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
    QueensBedchamberLeyndellAshenCapital = 71124,

    [Annotation(Name = "Divine Bridge (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
    DivineBridgeLeyndellAshenCapital = 71125,

    //Leyndell, Royal Capital

    [Annotation(Name = "Elden Throne (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
    EldenThroneLeyndellRoyalCapital = 71100,

    [Annotation(Name = "Erdtree Sanctuary (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
    ErdtreeSanctuaryLeyndellRoyalCapital = 71101,

    [Annotation(Name = "East Capital Rampart (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
    EastCapitalRampartLeyndellRoyalCapital = 71102,

    [Annotation(Name = "Lower Capital Church", Description = "Leyndell, Royal Capital")]
    LowerCapitalChurch = 71103,

    [Annotation(Name = "Avenue Balcony", Description = "Leyndell, Royal Capital")]
    AvenueBalcony = 71104,

    [Annotation(Name = "West Capital Rampart", Description = "Leyndell, Royal Capital")]
    WestCapitalRampart = 71105,

    [Annotation(Name = "Queen's Bedchamber (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
    QueensBedchamberLeyndellRoyalCapital = 71107,

    [Annotation(Name = "Fortified Manor, First Floor", Description = "Leyndell, Royal Capital")]
    FortifiedManorFirstFloor = 71108,

    [Annotation(Name = "Divine Bridge (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
    DivineBridgeLeyndellRoyalCapital = 71109,

    //Limgrave

    [Annotation(Name = "Stormfoot Catacombs", Description = "Limgrave")]
    StormfootCatacombs = 73002,

    [Annotation(Name = "Murkwater Catacombs", Description = "Limgrave")]
    MurkwaterCatacombs = 73004,

    [Annotation(Name = "Murkwater Cave", Description = "Limgrave")]
    MurkwaterCave = 73100,

    [Annotation(Name = "Groveside Cave", Description = "Limgrave")]
    GrovesideCave = 73103,

    [Annotation(Name = "Coastal Cave", Description = "Limgrave")]
    CoastalCave = 73115,

    [Annotation(Name = "Highroad Cave", Description = "Limgrave")]
    HighroadCave = 73117,

    [Annotation(Name = "Limgrave Tunnels", Description = "Limgrave")]
    LimgraveTunnels = 73201,

    [Annotation(Name = "Church of Elleh", Description = "Limgrave")]
    ChurchOfElleh = 76100,

    [Annotation(Name = "The First Step", Description = "Limgrave")]
    TheFirstStep = 76101,

    [Annotation(Name = "Artist's Shack (Limgrave)", Description = "Limgrave")]
    ArtistsShackLimgrave = 76103,

    [Annotation(Name = "Third Church of Marika", Description = "Limgrave")]
    ThirdChurchOfMarika = 76104,

    [Annotation(Name = "Fort Haight West", Description = "Limgrave")]
    FortHaightWest = 76105,

    [Annotation(Name = "Agheel Lake South", Description = "Limgrave")]
    AgheelLakeSouth = 76106,

    [Annotation(Name = "Agheel Lake North", Description = "Limgrave")]
    AgheelLakeNorth = 76108,

    [Annotation(Name = "Church of Dragon Communion", Description = "Limgrave")]
    ChurchOfDragonCommunion = 76110,

    [Annotation(Name = "Gatefront", Description = "Limgrave")]
    Gatefront = 76111,

    [Annotation(Name = "Seaside Ruins", Description = "Limgrave")]
    SeasideRuins = 76113,

    [Annotation(Name = "Mistwood Outskirts", Description = "Limgrave")]
    MistwoodOutskirts = 76114,

    [Annotation(Name = "Murkwater Coast", Description = "Limgrave")]
    MurkwaterCoast = 76116,

    [Annotation(Name = "Summonwater Village Outskirts", Description = "Limgrave")]
    SummonwaterVillageOutskirts = 76119,

    [Annotation(Name = "Waypoint Ruins Cellar", Description = "Limgrave")]
    WaypointRuinsCellar = 76120,

    //Liurnia of the Lakes

    [Annotation(Name = "Road's End Catacombs", Description = "Liurnia of the Lakes")]
    RoadsEndCatacombs = 73003,

    [Annotation(Name = "Black Knife Catacombs", Description = "Liurnia of the Lakes")]
    BlackKnifeCatacombs = 73005,

    [Annotation(Name = "Cliffbottom Catacombs", Description = "Liurnia of the Lakes")]
    CliffbottomCatacombs = 73006,

    [Annotation(Name = "Stillwater Cave", Description = "Liurnia of the Lakes")]
    StillwaterCave = 73104,

    [Annotation(Name = "Lakeside Crystal Cave", Description = "Liurnia of the Lakes")]
    LakesideCrystalCave = 73105,

    [Annotation(Name = "Academy Crystal Cave", Description = "Liurnia of the Lakes")]
    AcademyCrystalCave = 73106,

    [Annotation(Name = "Raya Lucaria Crystal Tunnel", Description = "Liurnia of the Lakes")]
    RayaLucariaCrystalTunnel = 73202,

    [Annotation(Name = "Study Hall Entrance", Description = "Liurnia of the Lakes")]
    StudyHallEntrance = 73420,

    [Annotation(Name = "Liurnia Tower Bridge", Description = "Liurnia of the Lakes")]
    LiurniaTowerBridge = 73421,

    [Annotation(Name = "Divine Tower of Liurnia", Description = "Liurnia of the Lakes")]
    DivineTowerOfLiurnia = 73422,

    [Annotation(Name = "Lake-Facing Cliffs", Description = "Liurnia of the Lakes")]
    LakeFacingCliffs = 76200,

    [Annotation(Name = "Liurnia Lake Shore", Description = "Liurnia of the Lakes")]
    LiurniaLakeShore = 76201,

    [Annotation(Name = "Laskyar Ruins", Description = "Liurnia of the Lakes")]
    LaskyarRuins = 76202,

    [Annotation(Name = "Scenic Isle", Description = "Liurnia of the Lakes")]
    ScenicIsle = 76203,

    [Annotation(Name = "Academy Gate Town", Description = "Liurnia of the Lakes")]
    AcademyGateTown = 76204,

    [Annotation(Name = "South Raya Lucaria Gate", Description = "Liurnia of the Lakes")]
    SouthRayaLucariaGate = 76205,

    [Annotation(Name = "Main Academy Gate", Description = "Liurnia of the Lakes")]
    MainAcademyGate = 76206,

    [Annotation(Name = "Grand Lift of Dectus", Description = "Liurnia of the Lakes")]
    GrandLiftOfDectus = 76209,

    [Annotation(Name = "Foot of the Four Belfries", Description = "Liurnia of the Lakes")]
    FootOfTheFourBelfries = 76210,

    [Annotation(Name = "Sorcerer's Isle", Description = "Liurnia of the Lakes")]
    SorcerersIsle = 76211,

    [Annotation(Name = "Northern Liurnia Lake Shore", Description = "Liurnia of the Lakes")]
    NorthernLiurniaLakeShore = 76212,

    [Annotation(Name = "Road to the Manor", Description = "Liurnia of the Lakes")]
    RoadToTheManor = 76213,

    [Annotation(Name = "Main Caria Manor Gate", Description = "Liurnia of the Lakes")]
    MainCariaManorGate = 76214,

    [Annotation(Name = "Slumbering Wolf's Shack", Description = "Liurnia of the Lakes")]
    SlumberingWolfsShack = 76215,

    [Annotation(Name = "Boilprawn Shack", Description = "Liurnia of the Lakes")]
    BoilprawnShack = 76216,

    [Annotation(Name = "Artist's Shack (Liurnia of the Lakes)", Description = "Liurnia of the Lakes")]
    ArtistsShackLiurniaOfTheLakes = 76217,

    [Annotation(Name = "Revenger's Shack", Description = "Liurnia of the Lakes")]
    RevengersShack = 76218,

    [Annotation(Name = "Folly on the Lake", Description = "Liurnia of the Lakes")]
    FollyonTheLake = 76219,

    [Annotation(Name = "Village of the Albinaurics", Description = "Liurnia of the Lakes")]
    VillageOfTheAlbinaurics = 76220,

    [Annotation(Name = "Liurnia Highway North", Description = "Liurnia of the Lakes")]
    LiurniaHighwayNorth = 76221,

    [Annotation(Name = "Gate Town Bridge", Description = "Liurnia of the Lakes")]
    GateTownBridge = 76222,

    [Annotation(Name = "Eastern Liurnia Lake Shore", Description = "Liurnia of the Lakes")]
    EasternLiurniaLakeShore = 76223,

    [Annotation(Name = "Church of Vows", Description = "Liurnia of the Lakes")]
    ChurchOfVows = 76224,

    [Annotation(Name = "Ruined Labyrinth", Description = "Liurnia of the Lakes")]
    RuinedLabyrinth = 76225,

    [Annotation(Name = "Mausoleum Compound", Description = "Liurnia of the Lakes")]
    MausoleumCompound = 76226,

    [Annotation(Name = "The Four Belfries", Description = "Liurnia of the Lakes")]
    TheFourBelfries = 76227,

    [Annotation(Name = "Ranni's Rise", Description = "Liurnia of the Lakes")]
    RannisRise = 76228,

    [Annotation(Name = "Ravine-Veiled Village", Description = "Liurnia of the Lakes")]
    RavineVeiledVillage = 76229,

    [Annotation(Name = "Manor Upper Level", Description = "Liurnia of the Lakes")]
    ManorUpperLevel = 76230,

    [Annotation(Name = "Manor Lower Level", Description = "Liurnia of the Lakes")]
    ManorLowerLevel = 76231,

    [Annotation(Name = "Royal Moongazing Grounds", Description = "Liurnia of the Lakes")]
    RoyalMoongazingGrounds = 76232,

    [Annotation(Name = "Gate Town North", Description = "Liurnia of the Lakes")]
    GateTownNorth = 76233,

    [Annotation(Name = "Eastern Tableland", Description = "Liurnia of the Lakes")]
    EasternTableland = 76234,

    [Annotation(Name = "The Ravine", Description = "Liurnia of the Lakes")]
    TheRavine = 76235,

    [Annotation(Name = "Fallen Ruins of the Lake", Description = "Liurnia of the Lakes")]
    FallenRuinsOfTheLake = 76236,

    [Annotation(Name = "Converted Tower", Description = "Liurnia of the Lakes")]
    ConvertedTower = 76237,

    [Annotation(Name = "Behind Caria Manor", Description = "Liurnia of the Lakes")]
    BehindCariaManor = 76238,

    [Annotation(Name = "Temple Quarter", Description = "Liurnia of the Lakes")]
    TempleQuarter = 76241,

    [Annotation(Name = "East Gate Bridge Trestle", Description = "Liurnia of the Lakes")]
    EastGateBridgeTrestle = 76242,

    [Annotation(Name = "Crystalline Woods", Description = "Liurnia of the Lakes")]
    CrystallineWoods = 76243,

    [Annotation(Name = "Liurnia Highway South", Description = "Liurnia of the Lakes")]
    LiurniaHighwaySouth = 76244,

    [Annotation(Name = "Jarburg", Description = "Liurnia of the Lakes")]
    Jarburg = 76245,

    [Annotation(Name = "Ranni's Chamber", Description = "Liurnia of the Lakes")]
    RannisChamber = 76247,

    //Miquella's Haligtree

    [Annotation(Name = "Haligtree Promenade", Description = "Miquella's Haligtree")]
    HaligtreePromenade = 71505,

    [Annotation(Name = "Haligtree Canopy", Description = "Miquella's Haligtree")]
    HaligtreeCanopy = 71506,

    [Annotation(Name = "Haligtree Town", Description = "Miquella's Haligtree")]
    HaligtreeTown = 71507,

    [Annotation(Name = "Haligtree Town Plaza", Description = "Miquella's Haligtree")]
    HaligtreeTownPlaza = 71508,

    //Mohgwyn Palace

    [Annotation(Name = "Cocoon of the Empyrean", Description = "Mohgwyn Palace")]
    CocoonOfTheEmpyrean = 71250,

    [Annotation(Name = "Palace Approach Ledge-Road", Description = "Mohgwyn Palace")]
    PalaceApproachLedgeRoad = 71251,

    [Annotation(Name = "Dynasty Mausoleum Entrance", Description = "Mohgwyn Palace")]
    DynastyMausoleumEntrance = 71252,

    [Annotation(Name = "Dynasty Mausoleum Midpoint", Description = "Mohgwyn Palace")]
    DynastyMausoleumMidpoint = 71253,

    //Moonlight Altar

    [Annotation(Name = "Moonlight Altar", Description = "Moonlight Altar")]
    MoonlightAltar = 76250,

    [Annotation(Name = "Cathedral of Manus Celes", Description = "Moonlight Altar")]
    CathedralOfManusCeles = 76251,

    [Annotation(Name = "Altar South", Description = "Moonlight Altar")]
    AltarSouth = 76252,

    //Mountaintops of the Giants

    [Annotation(Name = "Spiritcaller's Cave", Description = "Mountaintops of the Giants")]
    SpiritcallersCave = 73122,

    [Annotation(Name = "Zamor Ruins", Description = "Mountaintops of the Giants")]
    ZamorRuins = 76501,

    [Annotation(Name = "Ancient Snow Valley Ruins", Description = "Mountaintops of the Giants")]
    AncientSnowValleyRuins = 76503,

    [Annotation(Name = "Freezing Lake", Description = "Mountaintops of the Giants")]
    FreezingLake = 76504,

    [Annotation(Name = "First Church of Marika", Description = "Mountaintops of the Giants")]
    FirstChurchOfMarika = 76505,

    [Annotation(Name = "Whiteridge Road", Description = "Mountaintops of the Giants")]
    WhiteridgeRoad = 76520,

    [Annotation(Name = "Snow Valley Ruins Overlook", Description = "Mountaintops of the Giants")]
    SnowValleyRuinsOverlook = 76521,

    [Annotation(Name = "Castle Sol Main Gate", Description = "Mountaintops of the Giants")]
    CastleSolMainGate = 76522,

    [Annotation(Name = "Church of the Eclipse", Description = "Mountaintops of the Giants")]
    ChurchOfTheEclipse = 76523,

    [Annotation(Name = "Castle Sol Rooftop", Description = "Mountaintops of the Giants")]
    CastleSolRooftop = 76524,

    //Mt. Gelmir

    [Annotation(Name = "Wyndham Catacombs", Description = "Mt. Gelmir")]
    WyndhamCatacombs = 73007,

    [Annotation(Name = "Gelmir Hero's Grave", Description = "Mt. Gelmir")]
    GelmirHerosGrave = 73009,

    [Annotation(Name = "Seethewater Cave", Description = "Mt. Gelmir")]
    SeethewaterCave = 73107,

    [Annotation(Name = "Volcano Cave", Description = "Mt. Gelmir")]
    VolcanoCave = 73109,

    [Annotation(Name = "Bridge of Iniquity", Description = "Mt. Gelmir")]
    BridgeOfIniquity = 76350,

    [Annotation(Name = "First Mt. Gelmir Campsite", Description = "Mt. Gelmir")]
    FirstMtGelmirCampsite = 76351,

    [Annotation(Name = "Ninth Mt. Gelmir Campsite", Description = "Mt. Gelmir")]
    NinthMtGelmirCampsite = 76352,

    [Annotation(Name = "Road of Iniquity", Description = "Mt. Gelmir")]
    RoadOfIniquity = 76353,

    [Annotation(Name = "Seethewater River", Description = "Mt. Gelmir")]
    SeethewaterRiver = 76354,

    [Annotation(Name = "Seethewater Terminus", Description = "Mt. Gelmir")]
    SeethewaterTerminus = 76355,

    [Annotation(Name = "Craftsman's Shack", Description = "Mt. Gelmir")]
    CraftsmansShack = 76356,

    [Annotation(Name = "Primeval Sorcerer Azur", Description = "Mt. Gelmir")]
    PrimevalSorcererAzur = 76357,

    //Nokron, Eternal City

    [Annotation(Name = "Great Waterfall Basin", Description = "Nokron, Eternal City")]
    GreatWaterfallBasin = 71220,

    [Annotation(Name = "Mimic Tear", Description = "Nokron, Eternal City")]
    MimicTear = 71221,

    [Annotation(Name = "Ancestral Woods", Description = "Nokron, Eternal City")]
    AncestralWoods = 71224,

    [Annotation(Name = "Aqueduct-Facing Cliffs", Description = "Nokron, Eternal City")]
    AqueductFacingCliffs = 71225,

    [Annotation(Name = "Night's Sacred Ground", Description = "Nokron, Eternal City")]
    NightsSacredGround = 71226,

    [Annotation(Name = "Nokron, Eternal City", Description = "Nokron, Eternal City")]
    NokronEternalCity = 71271,

    //Roundtable Hold

    [Annotation(Name = "Table of Lost Grace", Description = "Roundtable Hold")]
    TableOfLostGrace = 71190,

    //Ruin-Strewn Precipice

    [Annotation(Name = "Magma Wyrm", Description = "Ruin-Strewn Precipice")]
    MagmaWyrm = 73900,

    [Annotation(Name = "Ruin-Strewn Precipice", Description = "Ruin-Strewn Precipice")]
    RuinStrewnPrecipice = 73901,

    [Annotation(Name = "Ruin-Strewn Precipice Overlook", Description = "Ruin-Strewn Precipice")]
    RuinStrewnPrecipiceOverlook = 73902,

    //Siofra River

    [Annotation(Name = "Siofra River Bank", Description = "Siofra River")]
    SiofraRiverBank = 71222,

    [Annotation(Name = "Worshippers' Woods", Description = "Siofra River")]
    WorshippersWoods = 71223,

    [Annotation(Name = "Below the Well", Description = "Siofra River")]
    BelowTheWell = 71227,

    [Annotation(Name = "Siofra River Well Depths", Description = "Siofra River")]
    SiofraRiverWellDepths = 71270,

    //Stormhill

    [Annotation(Name = "Deathtouched Catacombs", Description = "Stormhill")]
    DeathtouchedCatacombs = 73011,

    [Annotation(Name = "Limgrave Tower Bridge", Description = "Stormhill")]
    LimgraveTowerBridge = 73410,

    [Annotation(Name = "Divine Tower of Limgrave", Description = "Stormhill")]
    DivineTowerOfLimgrave = 73412,

    [Annotation(Name = "Stormhill Shack", Description = "Stormhill")]
    StormhillShack = 76102,

    [Annotation(Name = "Saintsbridge", Description = "Stormhill")]
    Saintsbridge = 76117,

    [Annotation(Name = "Warmaster's Shack", Description = "Stormhill")]
    WarmastersShack = 76118,

    //Stormveil Castle

    [Annotation(Name = "Godrick the Grafted", Description = "Stormveil Castle")]
    GodrickTheGrafted = 71000,

    [Annotation(Name = "Margit, the Fell Omen", Description = "Stormveil Castle")]
    MargitTheFellOmen = 71001,

    [Annotation(Name = "Castleward Tunnel", Description = "Stormveil Castle")]
    CastlewardTunnel = 71002,

    [Annotation(Name = "Gateside Chamber", Description = "Stormveil Castle")]
    GatesideChamber = 71003,

    [Annotation(Name = "Stormveil Cliffside", Description = "Stormveil Castle")]
    StormveilCliffside = 71004,

    [Annotation(Name = "Rampart Tower", Description = "Stormveil Castle")]
    RampartTower = 71005,

    [Annotation(Name = "Liftside Chamber", Description = "Stormveil Castle")]
    LiftsideChamber = 71006,

    [Annotation(Name = "Secluded Cell", Description = "Stormveil Castle")]
    SecludedCell = 71007,

    [Annotation(Name = "Stormveil Main Gate", Description = "Stormveil Castle")]
    StormveilMainGate = 71008,

    //Stranded Graveyard

    [Annotation(Name = "Cave of Knowledge", Description = "Stranded Graveyard")]
    CaveOfKnowledge = 71800,

    [Annotation(Name = "Stranded Graveyard", Description = "Stranded Graveyard")]
    StrandedGraveyard = 71801,

    //Subterranean Shunning-Grounds

    [Annotation(Name = "Cathedral of the Forsaken", Description = "Subterranean Shunning-Grounds")]
    CathedralOfTheForsaken = 73500,

    [Annotation(Name = "Underground Roadside", Description = "Subterranean Shunning-Grounds")]
    UndergroundRoadside = 73501,

    [Annotation(Name = "Forsaken Depths", Description = "Subterranean Shunning-Grounds")]
    ForsakenDepths = 73502,

    [Annotation(Name = "Leyndell Catacombs", Description = "Subterranean Shunning-Grounds")]
    LeyndellCatacombs = 73503,

    [Annotation(Name = "Frenzied Flame Proscription", Description = "Subterranean Shunning-Grounds")]
    FrenziedFlameProscription = 73504,

    //Swamp of Aeonia

    [Annotation(Name = "Aeonia Swamp Shore", Description = "Swamp of Aeonia")]
    AeoniaSwampShore = 76406,

    [Annotation(Name = "Astray from Caelid Highway North", Description = "Swamp of Aeonia")]
    AstrayfromCaelidHighwayNorth = 76407,

    [Annotation(Name = "Heart of Aeonia", Description = "Swamp of Aeonia")]
    HeartOfAeonia = 76412,

    [Annotation(Name = "Inner Aeonia", Description = "Swamp of Aeonia")]
    InnerAeonia = 76413,

    //Volcano Manor

    [Annotation(Name = "Rykard, Lord of Blasphemy", Description = "Volcano Manor")]
    RykardLordOfBlasphemy = 71600,

    [Annotation(Name = "Temple of Eiglay", Description = "Volcano Manor")]
    TempleOfEiglay = 71601,

    [Annotation(Name = "Volcano Manor", Description = "Volcano Manor")]
    VolcanoManor = 71602,

    [Annotation(Name = "Prison Town Church", Description = "Volcano Manor")]
    PrisonTownChurch = 71603,

    [Annotation(Name = "Guest Hall", Description = "Volcano Manor")]
    GuestHall = 71604,

    [Annotation(Name = "Audience Pathway", Description = "Volcano Manor")]
    AudiencePathway = 71605,

    [Annotation(Name = "Abductor Virgin", Description = "Volcano Manor")]
    AbductorVirgin = 71606,

    [Annotation(Name = "Subterranean Inquisition Chamber", Description = "Volcano Manor")]
    SubterraneanInquisitionChamber = 71607,

    //Weeping Peninsula

    [Annotation(Name = "Tombsward Catacombs", Description = "Weeping Peninsula")]
    TombswardCatacombs = 73000,

    [Annotation(Name = "Impaler's Catacombs", Description = "Weeping Peninsula")]
    ImpalersCatacombs = 73001,

    [Annotation(Name = "Earthbore Cave", Description = "Weeping Peninsula")]
    EarthboreCave = 73101,

    [Annotation(Name = "Tombsward Cave", Description = "Weeping Peninsula")]
    TombswardCave = 73102,

    [Annotation(Name = "Morne Tunnel", Description = "Weeping Peninsula")]
    MorneTunnel = 73200,

    [Annotation(Name = "Church of Pilgrimage", Description = "Weeping Peninsula")]
    ChurchOfPilgrimage = 76150,

    [Annotation(Name = "Castle Morne Rampart", Description = "Weeping Peninsula")]
    CastleMorneRampart = 76151,

    [Annotation(Name = "Tombsward", Description = "Weeping Peninsula")]
    Tombsward = 76152,

    [Annotation(Name = "South of the Lookout Tower", Description = "Weeping Peninsula")]
    SouthOfTheLookoutTower = 76153,

    [Annotation(Name = "Ailing Village Outskirts", Description = "Weeping Peninsula")]
    AilingVillageOutskirts = 76154,

    [Annotation(Name = "Beside the Crater-Pocked Glade", Description = "Weeping Peninsula")]
    BesideTheCraterPockedGlade = 76155,

    [Annotation(Name = "Isolated Merchant's Shack (Weeping Peninsula)", Description = "Weeping Peninsula")]
    IsolatedMerchantsShackWeepingPeninsula = 76156,

    [Annotation(Name = "Bridge of Sacrifice", Description = "Weeping Peninsula")]
    BridgeOfSacrifice = 76157,

    [Annotation(Name = "Castle Morne Lift", Description = "Weeping Peninsula")]
    CastleMorneLift = 76158,

    [Annotation(Name = "Behind the Castle", Description = "Weeping Peninsula")]
    BehindTheCastle = 76159,

    [Annotation(Name = "Beside the Rampart Gaol", Description = "Weeping Peninsula")]
    BesideTheRampartGaol = 76160,

    [Annotation(Name = "Morne Moangrave", Description = "Weeping Peninsula")]
    MorneMoangrave = 76161,

    [Annotation(Name = "Fourth Church of Marika", Description = "Weeping Peninsula")]
    FourthChurchOfMarika = 76162,

    // The Realm of Shadow
    [Annotation(Name = "Theatre of the Divine Beast", Description = "Belurat, Tower Settlement")]
    TheatreoftheDivineBeast = 72000,

    [Annotation(Name = "Belurat, Tower Settlement", Description = "Belurat, Tower Settlement")]
    BeluratTowerSettlement = 72001,

    [Annotation(Name = "Small Private Altar", Description = "Belurat, Tower Settlement")]
    SmallPrivateAltar = 72002,

    [Annotation(Name = "Stagefront", Description = "Belurat, Tower Settlement")]
    Stagefront = 72003,

    [Annotation(Name = "Gate of Divinity", Description = "Enir-Ilim")]
    GateofDivinity = 72010,

    [Annotation(Name = "Enir-Ilim: Outer Wall", Description = "Enir-Ilim")]
    EnirIlimOuterWall = 72012,

    [Annotation(Name = "First Rise", Description = "Enir-Ilim")]
    FirstRise = 72013,

    [Annotation(Name = "Spiral Rise", Description = "Enir-Ilim")]
    SpiralRise = 72014,

    [Annotation(Name = "Cleansing Chamber Anteroom", Description = "Enir-Ilim")]
    CleansingChamberAnteroom = 72015,

    [Annotation(Name = "Divine Gate Front Staircase", Description = "Enir-Ilim")]
    DivineGateFrontStaircase = 72016,

    [Annotation(Name = "Main Gate Plaza", Description = "Shadow Keep")]
    MainGatePlaza = 72101,

    [Annotation(Name = "Shadow Keep Main Gate", Description = "Shadow Keep")]
    ShadowKeepMainGate = 72102,

    [Annotation(Name = "Church District Entrance", Description = "Shadow Keep, Church District")]
    ChurchDistrictEntrance = 72106,

    [Annotation(Name = "Sunken Chapel", Description = "Shadow Keep, Church District")]
    SunkenChapel = 72107,

    [Annotation(Name = "Tree,Worship Passage", Description = "Shadow Keep, Church District")]
    TreeWorshipPassage = 72108,

    [Annotation(Name = "Tree,Worship Sanctum", Description = "Shadow Keep, Church District")]
    TreeWorshipSanctum = 72109,

    [Annotation(Name = "Messmer's Dark Chamber", Description = "Specimen Storehouse")]
    MessmersDarkChamber = 72110,

    [Annotation(Name = "Storehouse, First Floor", Description = "Specimen Storehouse")]
    StorehouseFirstFloor = 72111,

    [Annotation(Name = "Storehouse, Fourth Floor", Description = "Specimen Storehouse")]
    StorehouseFourthFloor = 72112,

    [Annotation(Name = "Storehouse, Seventh Floor", Description = "Specimen Storehouse")]
    StorehouseSeventhFloor = 72113,

    [Annotation(Name = "Dark Chamber Entrance", Description = "Specimen Storehouse")]
    DarkChamberEntrance = 72114,

    [Annotation(Name = "Storehouse, Back Section", Description = "Specimen Storehouse")]
    StorehouseBackSection = 72116,

    [Annotation(Name = "Storehouse, Loft", Description = "Specimen Storehouse")]
    StorehouseLoft = 72117,

    [Annotation(Name = "West Rampart", Description = "Specimen Storehouse")]
    WestRampart = 72120,

    [Annotation(Name = "Garden of Deep Purple", Description = "Stone Coffin Fissure")]
    GardenofDeepPurple = 72200,

    [Annotation(Name = "Stone Coffin Fissure", Description = "Stone Coffin Fissure")]
    StoneCoffinFissure = 72201,

    [Annotation(Name = "Fissure Cross", Description = "Stone Coffin Fissure")]
    FissureCross = 72202,

    [Annotation(Name = "Fissure Waypoint", Description = "Stone Coffin Fissure")]
    FissureWaypoint = 72203,

    [Annotation(Name = "Fissure Depths", Description = "Stone Coffin Fissure")]
    FissureDepths = 72204,

    [Annotation(Name = "Finger Birthing Grounds", Description = "Scadu Altus")]
    FingerBirthingGrounds = 72500,

    [Annotation(Name = "Discussion Chamber", Description = "Midra's Manse")]
    DiscussionChamber = 72800,

    [Annotation(Name = "Manse Hall", Description = "Midra's Manse")]
    ManseHall = 72801,

    [Annotation(Name = "Midra's Library", Description = "Midra's Manse")]
    MidrasLibrary = 72802,

    [Annotation(Name = "Second Floor Chamber", Description = "Midra's Manse")]
    SecondFloorChamber = 72803,

    [Annotation(Name = "Fog Rift Catacombs", Description = "Gravesite Plain")]
    FogRiftCatacombs = 74000,

    [Annotation(Name = "Ruined Forge Lava Intake", Description = "Gravesite Plain")]
    RuinedForgeLavaIntake = 74200,

    [Annotation(Name = "Rivermouth Cave", Description = "Gravesite Plain")]
    RivermouthCave = 74300,

    [Annotation(Name = "Dragon's Pit", Description = "Gravesite Plain")]
    DragonsPit = 74301,

    [Annotation(Name = "Dragon's Pit Terminus", Description = "Gravesite Plain")]
    DragonsPitTerminus = 74351,

    [Annotation(Name = "Cliffroad Terminus", Description = "Gravesite Plain")]
    CliffroadTerminus = 76804,

    [Annotation(Name = "Main Gate Cross", Description = "Gravesite Plain")]
    MainGateCross = 76803,

    [Annotation(Name = "Gravesite Plain", Description = "Gravesite Plain")]
    GravesitePlain = 76800,

    [Annotation(Name = "Three,Path Cross", Description = "Gravesite Plain")]
    ThreePathCross = 76802,

    [Annotation(Name = "Greatbridge, North", Description = "Gravesite Plain")]
    GreatbridgeNorth = 76805,

    [Annotation(Name = "Scorched Ruins", Description = "Gravesite Plain")]
    ScorchedRuins = 76801,

    [Annotation(Name = "Ellac River Cave", Description = "Gravesite Plain")]
    EllacRiverCave = 76812,

    [Annotation(Name = "Castle Front", Description = "Gravesite Plain")]
    CastleFront = 76813,

    [Annotation(Name = "Pillar Path Waypoint", Description = "Gravesite Plain")]
    PillarPathWaypoint = 76811,

    [Annotation(Name = "Pillar Path Cross", Description = "Gravesite Plain")]
    PillarPathCross = 76810,

    [Annotation(Name = "Belurat Gaol", Description = "Gravesite Plain")]
    BeluratGaol = 74100,

    [Annotation(Name = "Ellac River Downstream", Description = "Gravesite Plain")]
    EllacRiverDownstream = 76830,

    [Annotation(Name = "Charo's Hidden Grave", Description = "Charo's Hidden Grave")]
    CharosHiddenGrave = 76841,

    [Annotation(Name = "Lamenter's Gaol", Description = "Charo's Hidden Grave")]
    LamentersGaol = 74102,

    [Annotation(Name = "Castle Ensis Checkpoint", Description = "Castle Ensis")]
    CastleEnsisCheckpoint = 76821,

    [Annotation(Name = "Ensis Moongazing Grounds", Description = "Castle Ensis")]
    EnsisMoongazingGrounds = 76823,

    [Annotation(Name = "Castle,Lord's Chamber", Description = "Castle Ensis")]
    CastleLordsChamber = 76822,

    [Annotation(Name = "Cerulean Coast West", Description = "Cerulean Coast")]
    CeruleanCoastWest = 76832,

    [Annotation(Name = "The Fissure", Description = "Cerulean Coast")]
    TheFissure = 76833,

    [Annotation(Name = "Cerulean Coast Cross", Description = "Cerulean Coast")]
    CeruleanCoastCross = 76835,

    [Annotation(Name = "Cerulean Coast", Description = "Cerulean Coast")]
    CeruleanCoast = 76831,

    [Annotation(Name = "Finger Ruins of Rhia", Description = "Cerulean Coast")]
    FingerRuinsofRhia = 76834,

    [Annotation(Name = "Grand Altar of Dragon Communion", Description = "Foot of the Jagged Peak")]
    GrandAltarofDragonCommunion = 76840,

    [Annotation(Name = "Divided Falls", Description = "Abyssal Woods")]
    DividedFalls = 76861,

    [Annotation(Name = "Abyssal Woods", Description = "Abyssal Woods")]
    AbyssalWoods = 76860,

    [Annotation(Name = "Forsaken Graveyard", Description = "Abyssal Woods")]
    ForsakenGraveyard = 76862,

    [Annotation(Name = "Church Ruins", Description = "Abyssal Woods")]
    ChurchRuins = 76864,

    [Annotation(Name = "Woodland Trail", Description = "Abyssal Woods")]
    WoodlandTrail = 76863,

    [Annotation(Name = "Foot of the Jagged Peak", Description = "Foot of the Jagged Peak")]
    FootoftheJaggedPeak = 76850,

    [Annotation(Name = "Jagged Peak Mountainside", Description = "Jagged Peak")]
    JaggedPeakMountainside = 76851,

    [Annotation(Name = "Jagged Peak Summit", Description = "Jagged Peak")]
    JaggedPeakSummit = 76852,

    [Annotation(Name = "Rest of the Dread Dragon", Description = "Jagged Peak")]
    RestoftheDreadDragon = 76853,

    [Annotation(Name = "Ancient Ruins, Grand Stairway", Description = "Ancient Ruins of Rauh")]
    AncientRuinsGrandStairway = 76944,

    [Annotation(Name = "Church of the Bud", Description = "Ancient Ruins of Rauh")]
    ChurchoftheBud = 76945,

    [Annotation(Name = "Church of the Bud, Main Entrance", Description = "Ancient Ruins of Rauh")]
    ChurchoftheBudMainEntrance = 76943,

    [Annotation(Name = "Rauh Ancient Ruins, West", Description = "Ancient Ruins of Rauh")]
    RauhAncientRuinsWest = 76942,

    [Annotation(Name = "Rauh Ancient Ruins, East", Description = "Ancient Ruins of Rauh")]
    RauhAncientRuinsEast = 76941,

    [Annotation(Name = "Viaduct Minor Tower", Description = "Ancient Ruins of Rauh")]
    ViaductMinorTower = 76940,

    [Annotation(Name = "Temple Town Ruins", Description = "Rauh Base")]
    TempleTownRuins = 76913,

    [Annotation(Name = "Ravine North", Description = "Rauh Base")]
    RavineNorth = 76914,

    [Annotation(Name = "Scorpion River Catacombs", Description = "Rauh Base")]
    ScorpionRiverCatacombs = 74001,

    [Annotation(Name = "Taylew's Ruined Forge", Description = "Rauh Base")]
    TaylewsRuinedForge = 74203,

    [Annotation(Name = "Ancient Ruins Base", Description = "Rauh Base")]
    AncientRuinsBase = 76912,

    [Annotation(Name = "Darklight Catacombs", Description = "Scadu Altus")]
    DarklightCatacombs = 74002,

    [Annotation(Name = "Bonny Gaol", Description = "Scadu Altus")]
    BonnyGaol = 74101,

    [Annotation(Name = "Highroad Cross", Description = "Scadu Altus")]
    HighroadCross = 76900,

    [Annotation(Name = "Scadu Altus, West", Description = "Scadu Altus")]
    ScaduAltusWest = 76907,

    [Annotation(Name = "Moorth Highway, South", Description = "Scadu Altus")]
    MoorthHighwaySouth = 76908,

    [Annotation(Name = "Fort of Reprimand", Description = "Scadu Altus")]
    FortofReprimand = 76909,

    [Annotation(Name = "Behind the Fort of Reprimand", Description = "Scadu Altus")]
    BehindtheFortofReprimand = 76910,

    [Annotation(Name = "Moorth Ruins", Description = "Scadu Altus")]
    MoorthRuins = 76902,

    [Annotation(Name = "Bonny Village", Description = "Scadu Altus")]
    BonnyVillage = 76903,

    [Annotation(Name = "Castle Watering Hole", Description = "Scadu Altus")]
    CastleWateringHole = 76916,

    [Annotation(Name = "Ruined Forge of Starfall Past", Description = "Scadu Altus")]
    RuinedForgeofStarfallPast = 74202,

    [Annotation(Name = "Scaduview Cross", Description = "Scadu Altus")]
    ScaduviewCross = 76911,

    [Annotation(Name = "Recluses' River Downstream", Description = "Scadu Altus")]
    ReclusesRiverDownstream = 76918,

    [Annotation(Name = "Recluses' River Upstream", Description = "Scadu Altus")]
    ReclusesRiverUpstream = 76917,

    [Annotation(Name = "Bridge Leading to the Village", Description = "Scadu Altus")]
    BridgeLeadingtotheVillage = 76904,

    [Annotation(Name = "Cathedral of Manus Metyr", Description = "Scadu Altus")]
    CathedralofManusMetyr = 76906,

    [Annotation(Name = "Church District Highroad", Description = "Scadu Altus")]
    ChurchDistrictHighroad = 76905,

    [Annotation(Name = "Scaduview", Description = "Scaduview")]
    Scaduview = 76930,

    [Annotation(Name = "Shadow Keep, Back Gate", Description = "Scaduview")]
    ShadowKeepBackGate = 76931,

    [Annotation(Name = "Fingerstone Hill", Description = "Scaduview")]
    FingerstoneHill = 76936,

    [Annotation(Name = "Hinterland Bridge", Description = "Scaduview")]
    HinterlandBridge = 76937,

    [Annotation(Name = "Hinterland", Description = "Scaduview")]
    Hinterland = 76935,

    [Annotation(Name = "Scadutree Base", Description = "Scaduview")]
    ScadutreeBase = 76960
}
