using System.ComponentModel.DataAnnotations;

namespace SoulMemory.EldenRing
{
    public enum Grace : uint
    {
        //Academy of Raya Lucaria

        [Display(Name = "Raya Lucaria Grand Library", Description = "Academy of Raya Lucaria")]
        RayaLucariaGrandLibrary = 71400,

        [Display(Name = "Debate Parlor", Description = "Academy of Raya Lucaria")]
        DebateParlor = 71401,

        [Display(Name = "Church of the Cuckoo", Description = "Academy of Raya Lucaria")]
        ChurchOfTheCuckoo = 71402,

        [Display(Name = "Schoolhouse Classroom", Description = "Academy of Raya Lucaria")]
        SchoolhouseClassroom = 71403,

        //Ainsel River

        [Display(Name = "Dragonkin Soldier of Nokstella", Description = "Ainsel River")]
        DragonkinSoldierOfNokstella = 71210,

        [Display(Name = "Ainsel River Well Depths", Description = "Ainsel River")]
        AinselRiverWellDepths = 71211,

        [Display(Name = "Ainsel River Sluice Gate", Description = "Ainsel River")]
        AinselRiverSluiceGate = 71212,

        [Display(Name = "Ainsel River Downstream", Description = "Ainsel River")]
        AinselRiverDownstream = 71213,

        [Display(Name = "Astel, Naturalborn of the Void", Description = "Ainsel River")]
        AstelNaturalbornOfTheVoid = 71240,

        //Ainsel River Main

        [Display(Name = "Ainsel River Main", Description = "Ainsel River Main")]
        AinselRiverMain = 71214,

        [Display(Name = "Nokstella, Eternal City", Description = "Ainsel River Main")]
        NokstellaEternalCity = 71215,

        [Display(Name = "Nokstella Waterfall Basin", Description = "Ainsel River Main")]
        NokstellaWaterfallBasin = 71219,

        //Altus Plateau

        [Display(Name = "Sainted Hero's Grave", Description = "Altus Plateau")]
        SaintedHerosGrave = 73008,

        [Display(Name = "Unsightly Catacombs", Description = "Altus Plateau")]
        UnsightlyCatacombs = 73012,

        [Display(Name = "Perfumer's Grotto", Description = "Altus Plateau")]
        PerfumersGrotto = 73118,

        [Display(Name = "Sage's Cave", Description = "Altus Plateau")]
        SagesCave = 73119,

        [Display(Name = "Old Altus Tunnel", Description = "Altus Plateau")]
        OldAltusTunnel = 73204,

        [Display(Name = "Altus Tunnel", Description = "Altus Plateau")]
        AltusTunnel = 73205,

        [Display(Name = "Abandoned Coffin", Description = "Altus Plateau")]
        AbandonedCoffin = 76300,

        [Display(Name = "Altus Plateau", Description = "Altus Plateau")]
        AltusPlateau = 76301,

        [Display(Name = "Erdtree-Gazing Hill", Description = "Altus Plateau")]
        ErdtreeGazingHill = 76302,

        [Display(Name = "Altus Highway Junction", Description = "Altus Plateau")]
        AltusHighwayJunction = 76303,

        [Display(Name = "Forest-Spanning Greatbridge", Description = "Altus Plateau")]
        ForestSpanningGreatbridge = 76304,

        [Display(Name = "Rampartside Path", Description = "Altus Plateau")]
        RampartsidePath = 76305,

        [Display(Name = "Bower of Bounty", Description = "Altus Plateau")]
        BowerOfBounty = 76306,

        [Display(Name = "Road of Iniquity Side Path", Description = "Altus Plateau")]
        RoadOfIniquitySidePath = 76307,

        [Display(Name = "Windmill Village", Description = "Altus Plateau")]
        WindmillVillage = 76308,

        [Display(Name = "Windmill Heights", Description = "Altus Plateau")]
        WindmillHeights = 76313,

        [Display(Name = "Shaded Castle Ramparts", Description = "Altus Plateau")]
        ShadedCastleRamparts = 76320,

        [Display(Name = "Shaded Castle Inner Gate", Description = "Altus Plateau")]
        ShadedCastleInnerGate = 76321,

        [Display(Name = "Castellan's Hall", Description = "Altus Plateau")]
        CastellansHall = 76322,

        //Bellum Highway

        [Display(Name = "East Raya Lucaria Gate", Description = "Bellum Highway")]
        EastRayaLucariaGate = 76207,

        [Display(Name = "Bellum Church", Description = "Bellum Highway")]
        BellumChurch = 76208,

        [Display(Name = "Frenzied Flame Village Outskirts", Description = "Bellum Highway")]
        FrenziedFlameVillageOutskirts = 76239,

        [Display(Name = "Church of Inhibition", Description = "Bellum Highway")]
        ChurchOfInhibition = 76240,

        //Caelid

        [Display(Name = "Minor Erdtree Catacombs", Description = "Caelid")]
        MinorErdtreeCatacombs = 73014,

        [Display(Name = "Caelid Catacombs", Description = "Caelid")]
        CaelidCatacombs = 73015,

        [Display(Name = "War-Dead Catacombs", Description = "Caelid")]
        WarDeadCatacombs = 73016,

        [Display(Name = "Abandoned Cave", Description = "Caelid")]
        AbandonedCave = 73120,

        [Display(Name = "Gaol Cave", Description = "Caelid")]
        GaolCave = 73121,

        [Display(Name = "Gael Tunnel", Description = "Caelid")]
        GaelTunnel = 73207,

        [Display(Name = "Rear Gael Tunnel Entrance", Description = "Caelid")]
        RearGaelTunnelEntrance = 73207,

        [Display(Name = "Sellia Crystal Tunnel", Description = "Caelid")]
        SelliaCrystalTunnel = 73208,

        [Display(Name = "Smoldering Church", Description = "Caelid")]
        SmolderingChurch = 76400,

        [Display(Name = "Rotview Balcony", Description = "Caelid")]
        RotviewBalcony = 76401,

        [Display(Name = "Fort Gael North", Description = "Caelid")]
        FortGaelNorth = 76402,

        [Display(Name = "Caelem Ruins", Description = "Caelid")]
        CaelemRuins = 76403,

        [Display(Name = "Cathedral of Dragon Communion", Description = "Caelid")]
        CathedralOfDragonCommunion = 76404,

        [Display(Name = "Caelid Highway South", Description = "Caelid")]
        CaelidHighwaySouth = 76405,

        [Display(Name = "Smoldering Wall", Description = "Caelid")]
        SmolderingWall = 76409,

        [Display(Name = "Deep Siofra Well", Description = "Caelid")]
        DeepSiofraWell = 76410,

        [Display(Name = "Southern Aeonia Swamp Bank", Description = "Caelid")]
        SouthernAeoniaSwampBank = 76411,

        [Display(Name = "Sellia Backstreets", Description = "Caelid")]
        SelliaBackstreets = 76414,

        [Display(Name = "Chair-Crypt of Sellia", Description = "Caelid")]
        ChairCryptOfSellia = 76415,

        [Display(Name = "Sellia Under-Stair", Description = "Caelid")]
        SelliaUnderStair = 76416,

        [Display(Name = "Impassable Greatbridge", Description = "Caelid")]
        ImpassableGreatbridge = 76417,

        [Display(Name = "Church of the Plague", Description = "Caelid")]
        ChurchOfThePlague = 76418,

        [Display(Name = "Redmane Castle Plaza", Description = "Caelid")]
        RedmaneCastlePlaza = 76419,

        [Display(Name = "Chamber Outside the Plaza", Description = "Caelid")]
        ChamberOutsideThePlaza = 76420,

        [Display(Name = "Starscourge Radahn", Description = "Caelid")]
        StarscourgeRadahn = 76422,

        //Capital Outskirts

        [Display(Name = "Auriza Hero's Grave", Description = "Capital Outskirts")]
        AurizaHerosGrave = 73010,

        [Display(Name = "Auriza Side Tomb", Description = "Capital Outskirts")]
        AurizaSideTomb = 73013,

        [Display(Name = "Divine Tower of West Altus", Description = "Capital Outskirts")]
        DivineTowerOfWestAltus = 73430,

        [Display(Name = "Sealed Tunnel", Description = "Capital Outskirts")]
        SealedTunnel = 73431,

        [Display(Name = "Divine Tower of West Altus: Gate", Description = "Capital Outskirts")]
        DivineTowerOfWestAltusGate = 73432,

        [Display(Name = "Outer Wall Phantom Tree", Description = "Capital Outskirts")]
        OuterWallPhantomTree = 76309,

        [Display(Name = "Minor Erdtree Church", Description = "Capital Outskirts")]
        MinorErdtreeChurch = 76310,

        [Display(Name = "Hermit Merchant's Shack", Description = "Capital Outskirts")]
        HermitMerchantsShack = 76311,

        [Display(Name = "Outer Wall Battleground", Description = "Capital Outskirts")]
        OuterWallBattleground = 76312,

        [Display(Name = "Capital Rampart", Description = "Capital Outskirts")]
        CapitalRampart = 76314,

        //Consecrated Snowfield

        [Display(Name = "Consecrated Snowfield Catacombs", Description = "Consecrated Snowfield")]
        ConsecratedSnowfieldCatacombs = 73019,

        [Display(Name = "Cave of the Forlorn", Description = "Consecrated Snowfield")]
        CaveOfTheForlorn = 73112,

        [Display(Name = "Yelough Anix Tunnel", Description = "Consecrated Snowfield")]
        YeloughAnixTunnel = 73211,

        [Display(Name = "Consecrated Snowfield", Description = "Consecrated Snowfield")]
        ConsecratedSnowfield = 76550,

        [Display(Name = "Inner Consecrated Snowfield", Description = "Consecrated Snowfield")]
        InnerConsecratedSnowfield = 76551,

        [Display(Name = "Ordina, Liturgical Town", Description = "Consecrated Snowfield")]
        OrdinaLiturgicalTown = 76652,

        [Display(Name = "Apostate Derelict", Description = "Consecrated Snowfield")]
        ApostateDerelict = 76653,

        //Crumbling Farum Azula

        [Display(Name = "Maliketh, the Black Blade", Description = "Crumbling Farum Azula")]
        MalikethTheBlackBlade = 71300,

        [Display(Name = "Dragonlord Placidusax", Description = "Crumbling Farum Azula")]
        DragonlordPlacidusax = 71301,

        [Display(Name = "Dragon Temple Altar", Description = "Crumbling Farum Azula")]
        DragonTempleAltar = 71302,

        [Display(Name = "Crumbling Beast Grave", Description = "Crumbling Farum Azula")]
        CrumblingBeastGrave = 71303,

        [Display(Name = "Crumbling Beast Grave Depths", Description = "Crumbling Farum Azula")]
        CrumblingBeastGraveDepths = 71304,

        [Display(Name = "Tempest-Facing Balcony", Description = "Crumbling Farum Azula")]
        TempestFacingBalcony = 71305,

        [Display(Name = "Dragon Temple", Description = "Crumbling Farum Azula")]
        DragonTemple = 71306,

        [Display(Name = "Dragon Temple Transept", Description = "Crumbling Farum Azula")]
        DragonTempleTransept = 71307,

        [Display(Name = "Dragon Temple Lift", Description = "Crumbling Farum Azula")]
        DragonTempleLift = 71308,

        [Display(Name = "Dragon Temple Rooftop", Description = "Crumbling Farum Azula")]
        DragonTempleRooftop = 71309,

        [Display(Name = "Beside the Great Bridge", Description = "Crumbling Farum Azula")]
        BesideTheGreatBridge = 71310,

        //Deeproot Depths

        [Display(Name = "Prince of Death's Throne", Description = "Deeproot Depths")]
        PrinceOfDeathsThrone = 71230,

        [Display(Name = "Root-Facing Cliffs", Description = "Deeproot Depths")]
        RootFacingCliffs = 71231,

        [Display(Name = "Great Waterfall Crest", Description = "Deeproot Depths")]
        GreatWaterfallCrest = 71232,

        [Display(Name = "Deeproot Depths", Description = "Deeproot Depths")]
        DeeprootDepths = 71233,

        [Display(Name = "The Nameless Eternal City", Description = "Deeproot Depths")]
        TheNamelessEternalCity = 71234,

        [Display(Name = "Across the Roots", Description = "Deeproot Depths")]
        AcrossTheRoots = 71235,

        //Elden Throne

        [Display(Name = "Fractured Marika", Description = "Elden Throne")]
        FracturedMarika = 71900,

        //Elphael, Brace of the Haligtree

        [Display(Name = "Malenia, Goddess of Rot", Description = "Elphael, Brace of the Haligtree")]
        MaleniaGoddessOfRot = 71500,

        [Display(Name = "Prayer Room", Description = "Elphael, Brace of the Haligtree")]
        PrayerRoom = 71501,

        [Display(Name = "Elphael Inner Wall", Description = "Elphael, Brace of the Haligtree")]
        ElphaelInnerWall = 71502,

        [Display(Name = "Drainage Channel", Description = "Elphael, Brace of the Haligtree")]
        DrainageChannel = 71503,

        [Display(Name = "Haligtree Roots", Description = "Elphael, Brace of the Haligtree")]
        HaligtreeRoots = 71504,

        //Flame Peak

        [Display(Name = "Giant-Conquering Hero's Grave", Description = "Flame Peak")]
        GiantConqueringHerosGrave = 73017,

        [Display(Name = "Giants' Mountaintop Catacombs", Description = "Flame Peak")]
        GiantsMountaintopCatacombs = 73018,

        [Display(Name = "Giants' Gravepost", Description = "Flame Peak")]
        GiantsGravepost = 76506,

        [Display(Name = "Church of Repose", Description = "Flame Peak")]
        ChurchOfRepose = 76507,

        [Display(Name = "Foot of the Forge", Description = "Flame Peak")]
        FootOfTheForge = 76508,

        [Display(Name = "Fire Giant", Description = "Flame Peak")]
        FireGiant = 76509,

        [Display(Name = "Forge of the Giants", Description = "Flame Peak")]
        ForgeOfTheGiants = 76510,

        //Forbidden Lands

        [Display(Name = "Hidden Path to the Haligtree", Description = "Forbidden Lands")]
        HiddenPathToTheHaligtree = 73020,

        [Display(Name = "Divine Tower of East Altus: Gate", Description = "Forbidden Lands")]
        DivineTowerOfEastAltusGate = 73450,

        [Display(Name = "Divine Tower of East Altus", Description = "Forbidden Lands")]
        DivineTowerOfEastAltus = 73451,

        [Display(Name = "Forbidden Lands", Description = "Forbidden Lands")]
        ForbiddenLands = 76500,

        [Display(Name = "Grand Lift of Rold", Description = "Forbidden Lands")]
        GrandLiftOfRold = 76502,

        //Greyoll's Dragonbarrow

        [Display(Name = "Dragonbarrow Cave", Description = "Greyoll's Dragonbarrow")]
        DragonbarrowCave = 73110,

        [Display(Name = "Sellia Hideaway", Description = "Greyoll's Dragonbarrow")]
        SelliaHideaway = 73111,

        [Display(Name = "Divine Tower of Caelid", Description = "Greyoll's Dragonbarrow")]
        DivineTowerOfCaelid = 73440,

        [Display(Name = "Divine Tower of Caelid: Center", Description = "Greyoll's Dragonbarrow")]
        DivineTowerOfCaelidCenter = 73441,

        [Display(Name = "Isolated Divine Tower", Description = "Greyoll's Dragonbarrow")]
        IsolatedDivineTower = 73460,

        [Display(Name = "Dragonbarrow West", Description = "Greyoll's Dragonbarrow")]
        DragonbarrowWest = 76450,

        [Display(Name = "Isolated Merchant's Shack (Greyoll's Dragonbarrow)", Description = "Greyoll's Dragonbarrow")]
        IsolatedMerchantsShackGreyollsDragonbarrow = 76451,

        [Display(Name = "Dragonbarrow Fork", Description = "Greyoll's Dragonbarrow")]
        DragonbarrowFork = 76452,

        [Display(Name = "Fort Faroth", Description = "Greyoll's Dragonbarrow")]
        FortFaroth = 76453,

        [Display(Name = "Bestial Sanctum", Description = "Greyoll's Dragonbarrow")]
        BestialSanctum = 76454,

        [Display(Name = "Lenne's Rise", Description = "Greyoll's Dragonbarrow")]
        LennesRise = 76455,

        [Display(Name = "Farum Greatbridge", Description = "Greyoll's Dragonbarrow")]
        FarumGreatbridge = 76456,

        //Lake of Rot

        [Display(Name = "Lake of Rot Shoreside", Description = "Lake of Rot")]
        LakeOfRotShoreside = 71216,

        [Display(Name = "Grand Cloister", Description = "Lake of Rot")]
        GrandCloister = 71218,

        //Leyndell, Ashen Capital

        [Display(Name = "Elden Throne (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
        EldenThroneLeyndellAshenCapital = 71120,

        [Display(Name = "Erdtree Sanctuary (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
        ErdtreeSanctuaryLeyndellAshenCapital = 71121,

        [Display(Name = "East Capital Rampart (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
        EastCapitalRampartLeyndellAshenCapital = 71122,

        [Display(Name = "Leyndell, Capital of Ash", Description = "Leyndell, Ashen Capital")]
        LeyndellCapitalOfAsh = 71123,

        [Display(Name = "Queen's Bedchamber (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
        QueensBedchamberLeyndellAshenCapital = 71124,

        [Display(Name = "Divine Bridge (Leyndell, Ashen Capital)", Description = "Leyndell, Ashen Capital")]
        DivineBridgeLeyndellAshenCapital = 71125,

        //Leyndell, Royal Capital

        [Display(Name = "Elden Throne (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
        EldenThroneLeyndellRoyalCapital = 71100,

        [Display(Name = "Erdtree Sanctuary (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
        ErdtreeSanctuaryLeyndellRoyalCapital = 71101,

        [Display(Name = "East Capital Rampart (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
        EastCapitalRampartLeyndellRoyalCapital = 71102,

        [Display(Name = "Lower Capital Church", Description = "Leyndell, Royal Capital")]
        LowerCapitalChurch = 71103,

        [Display(Name = "Avenue Balcony", Description = "Leyndell, Royal Capital")]
        AvenueBalcony = 71104,

        [Display(Name = "West Capital Rampart", Description = "Leyndell, Royal Capital")]
        WestCapitalRampart = 71105,

        [Display(Name = "Queen's Bedchamber (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
        QueensBedchamberLeyndellRoyalCapital = 71107,

        [Display(Name = "Fortified Manor, First Floor", Description = "Leyndell, Royal Capital")]
        FortifiedManorFirstFloor = 71108,

        [Display(Name = "Divine Bridge (Leyndell, Royal Capital)", Description = "Leyndell, Royal Capital")]
        DivineBridgeLeyndellRoyalCapital = 71109,

        //Limgrave

        [Display(Name = "Stormfoot Catacombs", Description = "Limgrave")]
        StormfootCatacombs = 73002,

        [Display(Name = "Murkwater Catacombs", Description = "Limgrave")]
        MurkwaterCatacombs = 73004,

        [Display(Name = "Murkwater Cave", Description = "Limgrave")]
        MurkwaterCave = 73100,

        [Display(Name = "Groveside Cave", Description = "Limgrave")]
        GrovesideCave = 73103,

        [Display(Name = "Coastal Cave", Description = "Limgrave")]
        CoastalCave = 73115,

        [Display(Name = "Highroad Cave", Description = "Limgrave")]
        HighroadCave = 73117,

        [Display(Name = "Limgrave Tunnels", Description = "Limgrave")]
        LimgraveTunnels = 73201,

        [Display(Name = "Church of Elleh", Description = "Limgrave")]
        ChurchOfElleh = 76100,

        [Display(Name = "The First Step", Description = "Limgrave")]
        TheFirstStep = 76101,

        [Display(Name = "Artist's Shack (Limgrave)", Description = "Limgrave")]
        ArtistsShackLimgrave = 76103,

        [Display(Name = "Third Church of Marika", Description = "Limgrave")]
        ThirdChurchOfMarika = 76104,

        [Display(Name = "Fort Haight West", Description = "Limgrave")]
        FortHaightWest = 76105,

        [Display(Name = "Agheel Lake South", Description = "Limgrave")]
        AgheelLakeSouth = 76106,

        [Display(Name = "Agheel Lake North", Description = "Limgrave")]
        AgheelLakeNorth = 76108,

        [Display(Name = "Church of Dragon Communion", Description = "Limgrave")]
        ChurchOfDragonCommunion = 76110,

        [Display(Name = "Gatefront", Description = "Limgrave")]
        Gatefront = 76111,

        [Display(Name = "Seaside Ruins", Description = "Limgrave")]
        SeasideRuins = 76113,

        [Display(Name = "Mistwood Outskirts", Description = "Limgrave")]
        MistwoodOutskirts = 76114,

        [Display(Name = "Murkwater Coast", Description = "Limgrave")]
        MurkwaterCoast = 76116,

        [Display(Name = "Summonwater Village Outskirts", Description = "Limgrave")]
        SummonwaterVillageOutskirts = 76119,

        [Display(Name = "Waypoint Ruins Cellar", Description = "Limgrave")]
        WaypointRuinsCellar = 76120,

        //Liurnia of the Lakes

        [Display(Name = "Road's End Catacombs", Description = "Liurnia of the Lakes")]
        RoadsEndCatacombs = 73003,

        [Display(Name = "Black Knife Catacombs", Description = "Liurnia of the Lakes")]
        BlackKnifeCatacombs = 73005,

        [Display(Name = "Cliffbottom Catacombs", Description = "Liurnia of the Lakes")]
        CliffbottomCatacombs = 73006,

        [Display(Name = "Stillwater Cave", Description = "Liurnia of the Lakes")]
        StillwaterCave = 73104,

        [Display(Name = "Lakeside Crystal Cave", Description = "Liurnia of the Lakes")]
        LakesideCrystalCave = 73105,

        [Display(Name = "Academy Crystal Cave", Description = "Liurnia of the Lakes")]
        AcademyCrystalCave = 73106,

        [Display(Name = "Raya Lucaria Crystal Tunnel", Description = "Liurnia of the Lakes")]
        RayaLucariaCrystalTunnel = 73202,

        [Display(Name = "Study Hall Entrance", Description = "Liurnia of the Lakes")]
        StudyHallEntrance = 73420,

        [Display(Name = "Liurnia Tower Bridge", Description = "Liurnia of the Lakes")]
        LiurniaTowerBridge = 73421,

        [Display(Name = "Divine Tower of Liurnia", Description = "Liurnia of the Lakes")]
        DivineTowerOfLiurnia = 73422,

        [Display(Name = "Uld Palace Ruins", Description = "Liurnia of the Lakes")]
        UldPalaceRuins = 76200,

        [Display(Name = "Liurnia Lake Shore", Description = "Liurnia of the Lakes")]
        LiurniaLakeShore = 76201,

        [Display(Name = "Laskyar Ruins", Description = "Liurnia of the Lakes")]
        LaskyarRuins = 76202,

        [Display(Name = "Scenic Isle", Description = "Liurnia of the Lakes")]
        ScenicIsle = 76203,

        [Display(Name = "Academy Gate Town", Description = "Liurnia of the Lakes")]
        AcademyGateTown = 76204,

        [Display(Name = "South Raya Lucaria Gate", Description = "Liurnia of the Lakes")]
        SouthRayaLucariaGate = 76205,

        [Display(Name = "Main Academy Gate", Description = "Liurnia of the Lakes")]
        MainAcademyGate = 76206,

        [Display(Name = "Grand Lift of Dectus", Description = "Liurnia of the Lakes")]
        GrandLiftOfDectus = 76209,

        [Display(Name = "Foot of the Four Belfries", Description = "Liurnia of the Lakes")]
        FootOfTheFourBelfries = 76210,

        [Display(Name = "Sorcerer's Isle", Description = "Liurnia of the Lakes")]
        SorcerersIsle = 76211,

        [Display(Name = "Northern Liurnia Lake Shore", Description = "Liurnia of the Lakes")]
        NorthernLiurniaLakeShore = 76212,

        [Display(Name = "Road to the Manor", Description = "Liurnia of the Lakes")]
        RoadToTheManor = 76213,

        [Display(Name = "Main Caria Manor Gate", Description = "Liurnia of the Lakes")]
        MainCariaManorGate = 76214,

        [Display(Name = "Slumbering Wolf's Shack", Description = "Liurnia of the Lakes")]
        SlumberingWolfsShack = 76215,

        [Display(Name = "Boilprawn Shack", Description = "Liurnia of the Lakes")]
        BoilprawnShack = 76216,

        [Display(Name = "Artist's Shack (Liurnia of the Lakes)", Description = "Liurnia of the Lakes")]
        ArtistsShackLiurniaOfTheLakes = 76217,

        [Display(Name = "Revenger's Shack", Description = "Liurnia of the Lakes")]
        RevengersShack = 76218,

        [Display(Name = "Folly on the Lake", Description = "Liurnia of the Lakes")]
        FollyonTheLake = 76219,

        [Display(Name = "Village of the Albinaurics", Description = "Liurnia of the Lakes")]
        VillageOfTheAlbinaurics = 76220,

        [Display(Name = "Liurnia Highway North", Description = "Liurnia of the Lakes")]
        LiurniaHighwayNorth = 76221,

        [Display(Name = "Gate Town Bridge", Description = "Liurnia of the Lakes")]
        GateTownBridge = 76222,

        [Display(Name = "Eastern Liurnia Lake Shore", Description = "Liurnia of the Lakes")]
        EasternLiurniaLakeShore = 76223,

        [Display(Name = "Church of Vows", Description = "Liurnia of the Lakes")]
        ChurchOfVows = 76224,

        [Display(Name = "Ruined Labyrinth", Description = "Liurnia of the Lakes")]
        RuinedLabyrinth = 76225,

        [Display(Name = "Mausoleum Compound", Description = "Liurnia of the Lakes")]
        MausoleumCompound = 76226,

        [Display(Name = "The Four Belfries", Description = "Liurnia of the Lakes")]
        TheFourBelfries = 76227,

        //[Display(Name = "Ranni's Chamber", Description = "Liurnia of the Lakes")]
        //RannisChamber = 76228,

        [Display(Name = "Ravine-Veiled Village", Description = "Liurnia of the Lakes")]
        RavineVeiledVillage = 76229,

        [Display(Name = "Manor Upper Level", Description = "Liurnia of the Lakes")]
        ManorUpperLevel = 76230,

        [Display(Name = "Manor Lower Level", Description = "Liurnia of the Lakes")]
        ManorLowerLevel = 76231,

        [Display(Name = "Royal Moongazing Grounds", Description = "Liurnia of the Lakes")]
        RoyalMoongazingGrounds = 76232,

        [Display(Name = "Gate Town North", Description = "Liurnia of the Lakes")]
        GateTownNorth = 76233,

        [Display(Name = "Eastern Tableland", Description = "Liurnia of the Lakes")]
        EasternTableland = 76234,

        [Display(Name = "The Ravine", Description = "Liurnia of the Lakes")]
        TheRavine = 76235,

        [Display(Name = "Fallen Ruins of the Lake", Description = "Liurnia of the Lakes")]
        FallenRuinsOfTheLake = 76236,

        [Display(Name = "Converted Tower", Description = "Liurnia of the Lakes")]
        ConvertedTower = 76237,

        [Display(Name = "Behind Caria Manor", Description = "Liurnia of the Lakes")]
        BehindCariaManor = 76238,

        [Display(Name = "Temple Quarter", Description = "Liurnia of the Lakes")]
        TempleQuarter = 76241,

        [Display(Name = "East Gate Bridge Trestle", Description = "Liurnia of the Lakes")]
        EastGateBridgeTrestle = 76242,

        [Display(Name = "Crystalline Woods", Description = "Liurnia of the Lakes")]
        CrystallineWoods = 76243,

        [Display(Name = "Liurnia Highway South", Description = "Liurnia of the Lakes")]
        LiurniaHighwaySouth = 76244,

        [Display(Name = "Jarburg", Description = "Liurnia of the Lakes")]
        Jarburg = 76245,

        //[Display(Name = "Ranni's Chamber", Description = "Liurnia of the Lakes")]
        //RannisChamber = 76247,

        //Miquella's Haligtree

        [Display(Name = "Haligtree Promenade", Description = "Miquella's Haligtree")]
        HaligtreePromenade = 71505,

        [Display(Name = "Haligtree Canopy", Description = "Miquella's Haligtree")]
        HaligtreeCanopy = 71506,

        [Display(Name = "Haligtree Town", Description = "Miquella's Haligtree")]
        HaligtreeTown = 71507,

        [Display(Name = "Haligtree Town Plaza", Description = "Miquella's Haligtree")]
        HaligtreeTownPlaza = 71508,

        //Mohgwyn Palace

        [Display(Name = "Cocoon of the Empyrean", Description = "Mohgwyn Palace")]
        CocoonOfTheEmpyrean = 71250,

        [Display(Name = "Palace Approach Ledge-Road", Description = "Mohgwyn Palace")]
        PalaceApproachLedgeRoad = 71251,

        [Display(Name = "Dynasty Mausoleum Entrance", Description = "Mohgwyn Palace")]
        DynastyMausoleumEntrance = 71252,

        [Display(Name = "Dynasty Mausoleum Midpoint", Description = "Mohgwyn Palace")]
        DynastyMausoleumMidpoint = 71253,

        //Moonlight Altar

        [Display(Name = "Moonlight Altar", Description = "Moonlight Altar")]
        MoonlightAltar = 76250,

        [Display(Name = "Cathedral of Manus Celes", Description = "Moonlight Altar")]
        CathedralOfManusCeles = 76251,

        [Display(Name = "Altar South", Description = "Moonlight Altar")]
        AltarSouth = 76252,

        //Mountaintops of the Giants

        [Display(Name = "Spiritcaller's Cave", Description = "Mountaintops of the Giants")]
        SpiritcallersCave = 73122,

        [Display(Name = "Zamor Ruins", Description = "Mountaintops of the Giants")]
        ZamorRuins = 76501,

        [Display(Name = "Ancient Snow Valley Ruins", Description = "Mountaintops of the Giants")]
        AncientSnowValleyRuins = 76503,

        [Display(Name = "Freezing Lake", Description = "Mountaintops of the Giants")]
        FreezingLake = 76504,

        [Display(Name = "First Church of Marika", Description = "Mountaintops of the Giants")]
        FirstChurchOfMarika = 76505,

        [Display(Name = "Whiteridge Road", Description = "Mountaintops of the Giants")]
        WhiteridgeRoad = 76520,

        [Display(Name = "Snow Valley Ruins Overlook", Description = "Mountaintops of the Giants")]
        SnowValleyRuinsOverlook = 76521,

        [Display(Name = "Castle Sol Main Gate", Description = "Mountaintops of the Giants")]
        CastleSolMainGate = 76522,

        [Display(Name = "Church of the Eclipse", Description = "Mountaintops of the Giants")]
        ChurchOfTheEclipse = 76523,

        [Display(Name = "Castle Sol Rooftop", Description = "Mountaintops of the Giants")]
        CastleSolRooftop = 76524,

        //Mt. Gelmir

        [Display(Name = "Wyndham Catacombs", Description = "Mt. Gelmir")]
        WyndhamCatacombs = 73007,

        [Display(Name = "Gelmir Hero's Grave", Description = "Mt. Gelmir")]
        GelmirHerosGrave = 73009,

        [Display(Name = "Seethewater Cave", Description = "Mt. Gelmir")]
        SeethewaterCave = 73107,

        [Display(Name = "Volcano Cave", Description = "Mt. Gelmir")]
        VolcanoCave = 73109,

        [Display(Name = "Bridge of Iniquity", Description = "Mt. Gelmir")]
        BridgeOfIniquity = 76350,

        [Display(Name = "First Mt. Gelmir Campsite", Description = "Mt. Gelmir")]
        FirstMtGelmirCampsite = 76351,

        [Display(Name = "Ninth Mt. Gelmir Campsite", Description = "Mt. Gelmir")]
        NinthMtGelmirCampsite = 76352,

        [Display(Name = "Road of Iniquity", Description = "Mt. Gelmir")]
        RoadOfIniquity = 76353,

        [Display(Name = "Seethewater River", Description = "Mt. Gelmir")]
        SeethewaterRiver = 76354,

        [Display(Name = "Seethewater Terminus", Description = "Mt. Gelmir")]
        SeethewaterTerminus = 76355,

        [Display(Name = "Craftsman's Shack", Description = "Mt. Gelmir")]
        CraftsmansShack = 76356,

        [Display(Name = "Primeval Sorcerer Azur", Description = "Mt. Gelmir")]
        PrimevalSorcererAzur = 76357,

        //Nokron, Eternal City

        [Display(Name = "Great Waterfall Basin", Description = "Nokron, Eternal City")]
        GreatWaterfallBasin = 71220,

        [Display(Name = "Mimic Tear", Description = "Nokron, Eternal City")]
        MimicTear = 71221,

        [Display(Name = "Ancestral Woods", Description = "Nokron, Eternal City")]
        AncestralWoods = 71224,

        [Display(Name = "Aqueduct-Facing Cliffs", Description = "Nokron, Eternal City")]
        AqueductFacingCliffs = 71225,

        [Display(Name = "Night's Sacred Ground", Description = "Nokron, Eternal City")]
        NightsSacredGround = 71226,

        [Display(Name = "Nokron, Eternal City", Description = "Nokron, Eternal City")]
        NokronEternalCity = 71271,

        //Roundtable Hold

        [Display(Name = "Table of Lost Grace", Description = "Roundtable Hold")]
        TableOfLostGrace = 71190,

        //Ruin-Strewn Precipice

        [Display(Name = "Magma Wyrm", Description = "Ruin-Strewn Precipice")]
        MagmaWyrm = 73900,

        [Display(Name = "Ruin-Strewn Precipice", Description = "Ruin-Strewn Precipice")]
        RuinStrewnPrecipice = 73901,

        [Display(Name = "Ruin-Strewn Precipice Overlook", Description = "Ruin-Strewn Precipice")]
        RuinStrewnPrecipiceOverlook = 73902,

        //Siofra River

        [Display(Name = "Siofra River Bank", Description = "Siofra River")]
        SiofraRiverBank = 71222,

        [Display(Name = "Worshippers' Woods", Description = "Siofra River")]
        WorshippersWoods = 71223,

        [Display(Name = "Below the Well", Description = "Siofra River")]
        BelowTheWell = 71227,

        [Display(Name = "Siofra River Well Depths", Description = "Siofra River")]
        SiofraRiverWellDepths = 71270,

        //Stormhill

        [Display(Name = "Deathtouched Catacombs", Description = "Stormhill")]
        DeathtouchedCatacombs = 73011,

        [Display(Name = "Limgrave Tower Bridge", Description = "Stormhill")]
        LimgraveTowerBridge = 73410,

        [Display(Name = "Divine Tower of Limgrave", Description = "Stormhill")]
        DivineTowerOfLimgrave = 73412,

        [Display(Name = "Stormhill Shack", Description = "Stormhill")]
        StormhillShack = 76102,

        [Display(Name = "Saintsbridge", Description = "Stormhill")]
        Saintsbridge = 76117,

        [Display(Name = "Warmaster's Shack", Description = "Stormhill")]
        WarmastersShack = 76118,

        //Stormveil Castle

        [Display(Name = "Godrick the Grafted", Description = "Stormveil Castle")]
        GodrickTheGrafted = 71000,

        [Display(Name = "Margit, the Fell Omen", Description = "Stormveil Castle")]
        MargitTheFellOmen = 71001,

        [Display(Name = "Castleward Tunnel", Description = "Stormveil Castle")]
        CastlewardTunnel = 71002,

        [Display(Name = "Gateside Chamber", Description = "Stormveil Castle")]
        GatesideChamber = 71003,

        [Display(Name = "Stormveil Cliffside", Description = "Stormveil Castle")]
        StormveilCliffside = 71004,

        [Display(Name = "Rampart Tower", Description = "Stormveil Castle")]
        RampartTower = 71005,

        [Display(Name = "Liftside Chamber", Description = "Stormveil Castle")]
        LiftsideChamber = 71006,

        [Display(Name = "Secluded Cell", Description = "Stormveil Castle")]
        SecludedCell = 71007,

        [Display(Name = "Stormveil Main Gate", Description = "Stormveil Castle")]
        StormveilMainGate = 71008,

        //Stranded Graveyard

        [Display(Name = "Cave of Knowledge", Description = "Stranded Graveyard")]
        CaveOfKnowledge = 71800,

        [Display(Name = "Stranded Graveyard", Description = "Stranded Graveyard")]
        StrandedGraveyard = 71801,

        //Subterranean Shunning-Grounds

        [Display(Name = "Cathedral of the Forsaken", Description = "Subterranean Shunning-Grounds")]
        CathedralOfTheForsaken = 73500,

        [Display(Name = "Underground Roadside", Description = "Subterranean Shunning-Grounds")]
        UndergroundRoadside = 73501,

        [Display(Name = "Forsaken Depths", Description = "Subterranean Shunning-Grounds")]
        ForsakenDepths = 73502,

        [Display(Name = "Leyndell Catacombs", Description = "Subterranean Shunning-Grounds")]
        LeyndellCatacombs = 73503,

        [Display(Name = "Frenzied Flame Proscription", Description = "Subterranean Shunning-Grounds")]
        FrenziedFlameProscription = 73504,

        //Swamp of Aeonia

        [Display(Name = "Aeonia Swamp Shore", Description = "Swamp of Aeonia")]
        AeoniaSwampShore = 76406,

        [Display(Name = "Astray from Caelid Highway North", Description = "Swamp of Aeonia")]
        AstrayfromCaelidHighwayNorth = 76407,

        [Display(Name = "Heart of Aeonia", Description = "Swamp of Aeonia")]
        HeartOfAeonia = 76412,

        [Display(Name = "Inner Aeonia", Description = "Swamp of Aeonia")]
        InnerAeonia = 76413,

        //Volcano Manor

        [Display(Name = "Rykard, Lord of Blasphemy", Description = "Volcano Manor")]
        RykardLordOfBlasphemy = 71600,

        [Display(Name = "Temple of Eiglay", Description = "Volcano Manor")]
        TempleOfEiglay = 71601,

        [Display(Name = "Volcano Manor", Description = "Volcano Manor")]
        VolcanoManor = 71602,

        [Display(Name = "Prison Town Church", Description = "Volcano Manor")]
        PrisonTownChurch = 71603,

        [Display(Name = "Guest Hall", Description = "Volcano Manor")]
        GuestHall = 71604,

        [Display(Name = "Audience Pathway", Description = "Volcano Manor")]
        AudiencePathway = 71605,

        [Display(Name = "Abductor Virgin", Description = "Volcano Manor")]
        AbductorVirgin = 71606,

        [Display(Name = "Subterranean Inquisition Chamber", Description = "Volcano Manor")]
        SubterraneanInquisitionChamber = 71607,

        //Weeping Peninsula

        [Display(Name = "Tombsward Catacombs", Description = "Weeping Peninsula")]
        TombswardCatacombs = 73000,

        [Display(Name = "Impaler's Catacombs", Description = "Weeping Peninsula")]
        ImpalersCatacombs = 73001,

        [Display(Name = "Earthbore Cave", Description = "Weeping Peninsula")]
        EarthboreCave = 73101,

        [Display(Name = "Tombsward Cave", Description = "Weeping Peninsula")]
        TombswardCave = 73102,

        [Display(Name = "Morne Tunnel", Description = "Weeping Peninsula")]
        MorneTunnel = 73200,

        [Display(Name = "Church of Pilgrimage", Description = "Weeping Peninsula")]
        ChurchOfPilgrimage = 76150,

        [Display(Name = "Castle Morne Rampart", Description = "Weeping Peninsula")]
        CastleMorneRampart = 76151,

        [Display(Name = "Tombsward", Description = "Weeping Peninsula")]
        Tombsward = 76152,

        [Display(Name = "South of the Lookout Tower", Description = "Weeping Peninsula")]
        SouthOfTheLookoutTower = 76153,

        [Display(Name = "Ailing Village Outskirts", Description = "Weeping Peninsula")]
        AilingVillageOutskirts = 76154,

        [Display(Name = "Beside the Crater-Pocked Glade", Description = "Weeping Peninsula")]
        BesideTheCraterPockedGlade = 76155,

        [Display(Name = "Isolated Merchant's Shack (Weeping Peninsula)", Description = "Weeping Peninsula")]
        IsolatedMerchantsShackWeepingPeninsula = 76156,

        [Display(Name = "Bridge of Sacrifice", Description = "Weeping Peninsula")]
        BridgeOfSacrifice = 76157,

        [Display(Name = "Castle Morne Lift", Description = "Weeping Peninsula")]
        CastleMorneLift = 76158,

        [Display(Name = "Behind the Castle", Description = "Weeping Peninsula")]
        BehindTheCastle = 76159,

        [Display(Name = "Beside the Rampart Gaol", Description = "Weeping Peninsula")]
        BesideTheRampartGaol = 76160,

        [Display(Name = "Morne Moangrave", Description = "Weeping Peninsula")]
        MorneMoangrave = 76161,

        [Display(Name = "Fourth Church of Marika", Description = "Weeping Peninsula")]
        FourthChurchOfMarika = 76162,
    }
}
