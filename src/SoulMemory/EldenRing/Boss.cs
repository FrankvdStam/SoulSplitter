using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.EldenRing
{
    public enum Boss : uint
    {
        [Display(Name = "Godrick the Grafted - Stormveil Castle", Description = "Stormveil Castle")]
        GodrickTheGraftedStormveilCastle = 10000800,

        [Display(Name = "Margit, the Fell Omen - Stormveil Castle", Description = "Stormveil Castle")]
        MargitTheFellOmenStormveilCastle = 10000850,

        [Display(Name = "Grafted Scion - Chapel of Anticipation", Description = "Limgrave")]
        GraftedScionChapelOfAnticipation = 10010800,

        [Display(Name = "Morgott, the Omen King - Leyndell", Description = "Leyndell")]
        MorgottTheOmenKingLeyndell = 11000800,

        [Display(Name = "Godfrey, First Elden Lord - Leyndell", Description = "Leyndell")]
        GodfreyFirstEldenLordLeyndell = 11000850,

        [Display(Name = "Hoarah Loux - Leyndell", Description = "Leyndell")]
        HoarahLouxLeyndell = 11050800,

        [Display(Name = "Sir Gideon Ofnir, the All-Knowing - Leyndell", Description = "Leyndell")]
        SirGideonOfnirTheAllKnowingLeyndell = 11050850,

        [Display(Name = "Dragonkin Soldier of Nokstella - Ainsel River", Description = "Ainsel River")]
        DragonkinSoldierOfNokstellaAinselRiver = 12010800,

        [Display(Name = "Dragonkin Soldier - Lake of Rot", Description = "Lake of Rot")]
        DragonkinSoldierLakeOfRot = 12010850,

        [Display(Name = "Valiant Gargoyles - Siofra River", Description = "Siofra River")]
        ValiantGargoylesSiofraRiver = 12020800,

        [Display(Name = "Dragonkin Soldier - Siofra River", Description = "Siofra River")]
        DragonkinSoldierSiofraRiver = 12020830,

        [Display(Name = "Mimic Tear - Siofra River", Description = "Siofra River")]
        MimicTearSiofraRiver = 12020850,

        [Display(Name = "Crucible Knight Sirulia - Deeproot Depths", Description = "Deeproot Depths")]
        CrucibleKnightSiruliaDeeprootDepths = 12020390,

        [Display(Name = "Fia's Champion - Deeproot Depths", Description = "Deeproot Depths")]
        FiasChampionDeeprootDepths = 12030800,

        [Display(Name = "Lichdragon Fortissax - Deeproot Depths", Description = "Deeproot Depths")]
        LichdragonFortissaxDeeprootDepths = 12030850,

        [Display(Name = "Astel, Naturalborn of the Void - Lake of Rot", Description = "Lake of Rot")]
        AstelNaturalbornOfTheVoidLakeOfRot = 12040800,

        [Display(Name = "Mohg, Lord of Blood - Mohgwyn Palace", Description = "Mohgwyn Palace")]
        MohgLordOfBloodMohgwynPalace = 12050800,

        [Display(Name = "Ancestor Spirit - Siofra River", Description = "Siofra River")]
        AncestorSpiritSiofraRiver = 12080800,

        [Display(Name = "Regal Ancestor Spirit - Nokron, Eternal City", Description = "Nokron, Eternal City")]
        RegalAncestorSpiritNokronEternalCity = 12090800,

        [Display(Name = "Maliketh, The Black Blade - Crumbling Farum Azula", Description = "Crumbling Farum Azula")]
        MalikethTheBlackBladeCrumblingFarumAzula = 13000800,

        [Display(Name = "Dragonlord Placidusax - Crumbling Farum Azula", Description = "Crumbling Farum Azula")]
        DragonlordPlacidusaxCrumblingFarumAzula = 13000830,

        [Display(Name = "Godskin Duo - Crumbling Farum Azula", Description = "Crumbling Farum Azula")]
        GodskinDuoCrumblingFarumAzula = 13000850,

        [Display(Name = "Rennala, Queen of the Full Moon - Academy of Raya Lucaria", Description = "Academy of Raya Lucaria")]
        RennalaQueenOfTheFullMoonAcademyOfRayaLucaria = 14000800,

        [Display(Name = "Red Wolf of Radagon - Academy of Raya Lucaria", Description = "Academy of Raya Lucaria")]
        RedWolfOfRadagonAcademyOfRayaLucaria = 14000850,

        [Display(Name = "Malenia, Blade of Miquella - Miquella's Haligtree", Description = "Miquella's Haligtree")]
        MaleniaBladeOfMiquellaMiquellasHaligtree = 15000800,

        [Display(Name = "Loretta, Knight of the Haligtree - Miquella's Haligtree", Description = "Miquella's Haligtree")]
        LorettaKnightOfTheHaligtreeMiquellasHaligtree = 15000850,

        [Display(Name = "Rykard, Lord of Blasphemy - Volcano Manor", Description = "Volcano Manor")]
        RykardLordOfBlasphemyVolcanoManor = 16000800,

        [Display(Name = "Godskin Noble - Volcano Manor", Description = "Volcano Manor")]
        GodskinNobleVolcanoManor = 16000850,

        [Display(Name = "Abductor Virgins - Volcano Manor", Description = "Volcano Manor")]
        AbductorVirginsVolcanoManor = 16000860,

        [Display(Name = "Ulcerated Tree Spirit - Stranded Graveyard", Description = "Stranded Graveyard")]
        UlceratedTreeSpiritStrandedGraveyard = 18000800,

        [Display(Name = "Soldier of Godrick - Stranded Graveyard", Description = "Stranded Graveyard")]
        SoldierOfGodrickStrandedGraveyard = 18000850,

        [Display(Name = "Elden Beast - Elden Throne", Description = "Leyndell")]
        EldenBeastEldenThrone = 19000800,

        [Display(Name = "Mohg, The Omen - Subterranean Shunning-Grounds (Leyndell)", Description = "Subterranean Shunning-Grounds")]
        MohgTheOmenSubterraneanShunningGroundsLeyndell = 35000800,

        [Display(Name = "Esgar, Priest of Blood - Subterranean Shunning-Grounds (Leyndell)", Description = "Subterranean Shunning-Grounds")]
        EsgarPriestOfBloodSubterraneanShunningGroundsLeyndell = 35000850,

        [Display(Name = "Magma Wyrm Makar - Ruin-Strewn Precipice (Liurnia)", Description = "Liurnia of the Lakes")]
        MagmaWyrmMakarRuinStrewnPrecipiceLiurnia = 39200800,

        [Display(Name = "Cemetery Shade - Tombsward Catacombs (Limgrave)", Description = "Limgrave")]
        CemeteryShadeTombswardCatacombsLimgrave = 30000800,

        [Display(Name = "Erdtree Burial Watchdog - Impaler's Catacombs (Weeping Penisula)", Description = "Weeping Peninsula")]
        ErdtreeBurialWatchdogImpalersCatacombsWeepingPenisula = 30010800,

        [Display(Name = "Erdtree Burial Watchdog - Stormfoot Catacombs (Limgrave)", Description = "Limgrave")]
        ErdtreeBurialWatchdogStormfootCatacombsLimgrave = 30020800,

        [Display(Name = "Black Knife Assassin - Deathtouched Catacombs (Limgrave)", Description = "Limgrave")]
        BlackKnifeAssassinDeathtouchedCatacombsLimgrave = 30110800,

        [Display(Name = "Grave Warden Duelist - Murkwater Catacombs (Limgrave)", Description = "Limgrave")]
        GraveWardenDuelistMurkwaterCatacombsLimgrave = 30040800,

        [Display(Name = "Cemetery Shade - Black Knife Catacombs (Liurnia)", Description = "Liurnia of the Lakes")]
        CemeteryShadeBlackKnifeCatacombsLiurnia = 30050800,

        [Display(Name = "Black Knife Assassin - Black Knife Catacombs (Liurnia)", Description = "Liurnia of the Lakes")]
        BlackKnifeAssassinBlackKnifeCatacombsLiurnia = 30050850,

        [Display(Name = "Spirit-Caller Snail - Road's End Catacombs (Liurnia)", Description = "Liurnia of the Lakes")]
        SpiritCallerSnailRoadsEndCatacombsLiurnia = 30030800,

        [Display(Name = "Erdtree Burial Watchdog - Cliffbottom Catacombs (Liurnia)", Description = "Liurnia of the Lakes")]
        ErdtreeBurialWatchdogCliffbottomCatacombsLiurnia = 30060800,

        [Display(Name = "Ancient Hero of Zamor - Sainted Hero's Grave (Altus Plateau)", Description = "Altus Plateau")]
        AncientHeroOfZamorSaintedHerosGraveAltusPlateau = 30080800,

        [Display(Name = "Red Wolf of the Champion - Gelmir Hero's Grave (Mt. Gelmir)", Description = "Mt. Gelmir")]
        RedWolfOfTheChampionGelmirHerosGraveMtGelmir = 30090800,

        [Display(Name = "Crucible Knight Ordovis - Auriza Hero's Grave (Altus Plateau)", Description = "Altus Plateau")]
        CrucibleKnightOrdovisAurizaHerosGraveAltusPlateau = 30100800,

        [Display(Name = "Crucible Knight (Tree Spear) - Auriza Hero's Grave (Altus Plateau)", Description = "Altus Plateau")]
        CrucibleKnightTreeSpearAurizaHerosGraveAltusPlateau = 30100800,

        [Display(Name = "Misbegotten Warrior - Unsightly Catacombs (Mt. Gelmir)", Description = "Mt. Gelmir")]
        MisbegottenWarriorUnsightlyCatacombsMtGelmir = 30120800,

        [Display(Name = "Perfumer Tricia - Unsightly Catacombs (Mt. Gelmir)", Description = "Mt. Gelmir")]
        PerfumerTriciaUnsightlyCatacombsMtGelmir = 30120800,

        [Display(Name = "Erdtree Burial Watchdog - Wyndham Catacombs (Altus Plateau)", Description = "Altus Plateau")]
        ErdtreeBurialWatchdogWyndhamCatacombsAltusPlateau = 30070800,

        [Display(Name = "Grave Warden Duelist - Auriza Side Tomb (Altus Plateau)", Description = "Altus Plateau")]
        GraveWardenDuelistAurizaSideTombAltusPlateau = 30130800,

        [Display(Name = "Erdtree Burial Watchdog - Minor Erdtree Catacombs (Caelid)", Description = "Caelid")]
        ErdtreeBurialWatchdogMinorErdtreeCatacombsCaelid = 30140800,

        [Display(Name = "Cemetery Shade - Caelid Catacombs (Caelid)", Description = "Caelid")]
        CemeteryShadeCaelidCatacombsCaelid = 30150800,

        [Display(Name = "Putrid Tree Spirit - War-Dead Catacombs (Caelid)", Description = "Caelid")]
        PutridTreeSpiritWarDeadCatacombsCaelid = 30160800,

        [Display(Name = "Ancient Hero of Zamor - Giant-Conquering Hero's Grave (Mountaintops)", Description = "Mountaintops of the Giants")]
        AncientHeroOfZamorGiantConqueringHerosGraveMountaintops = 30170800,

        [Display(Name = "Ulcerated Tree Sprit - Giants' Mountaintop Catacombs (Mountaintops)", Description = "Mountaintops of the Giants")]
        UlceratedTreeSpritGiantsMountaintopCatacombsMountaintops = 30180800,

        [Display(Name = "Putrid Grave Warden Duelist - Consecrated Snowfield Catacombs (Snowfield)", Description = "Consecrated Snowfield")]
        PutridGraveWardenDuelistConsecratedSnowfieldCatacombsSnowfield = 30190800,

        [Display(Name = "Stray Mimic Tear - Hidden Path to the Haligtree", Description = "Forbidden Lands")]
        StrayMimicTearHiddenPathToTheHaligtree = 30200810,

        [Display(Name = "Patches - Murkwater Cave (Limgrave)", Description = "Limgrave")]
        PatchesMurkwaterCaveLimgrave = 31000800,

        [Display(Name = "Runebear - Earthbore Cave (Weeping Penisula)", Description = "Weeping Peninsula")]
        RunebearEarthboreCaveWeepingPenisula = 31010800,

        [Display(Name = "Miranda the Blighted Bloom - Tombsward Cave (Limgrave)", Description = "Limgrave")]
        MirandaTheBlightedBloomTombswardCaveLimgrave = 31020800,

        [Display(Name = "Beastman of Farum Azula - Groveside Cave (Limgrave)", Description = "Limgrave")]
        BeastmanOfFarumAzulaGrovesideCaveLimgrave = 31030800,

        [Display(Name = "Demi-Human Chief - Coastal Cave (Limgrave)", Description = "Limgrave")]
        DemiHumanChiefCoastalCaveLimgrave = 31150800,

        [Display(Name = "Guardian Golem - Highroad Cave (Limgrave)", Description = "Limgrave")]
        GuardianGolemHighroadCaveLimgrave = 31170800,

        [Display(Name = "Cleanrot Knight - Stillwater Cave (Liurnia)", Description = "Liurnia of the Lakes")]
        CleanrotKnightStillwaterCaveLiurnia = 31040800,

        [Display(Name = "Bloodhound Knight - Lakeside Crystal Cave (Liurnia)", Description = "Liurnia of the Lakes")]
        BloodhoundKnightLakesideCrystalCaveLiurnia = 31050800,

        [Display(Name = "Crystalians - Academy Crystal Cave (Liurnia)", Description = "Liurnia of the Lakes")]
        CrystaliansAcademyCrystalCaveLiurnia = 31060800,

        [Display(Name = "Kindred of Rot - Seethewater Cave (Mt. Gelmir)", Description = "Mt. Gelmir")]
        KindredOfRotSeethewaterCaveMtGelmir = 31070800,

        [Display(Name = "Demi-Human Queen Margot - Volcano Cave (Mt. Gelmir)", Description = "Mt. Gelmir")]
        DemiHumanQueenMargotVolcanoCaveMtGelmir = 31090800,

        [Display(Name = "Miranda the Blighted Bloom - Perfumer's Grotto (Altus Plateau)", Description = "Altus Plateau")]
        MirandaTheBlightedBloomPerfumersGrottoAltusPlateau = 31180800,

        [Display(Name = "Black Knife Assassin - Sage's Cave (Altus Plateau)", Description = "Altus Plateau")]
        BlackKnifeAssassinSagesCaveAltusPlateau = 31190800,

        [Display(Name = "Necromancer Garris - Sage's Cave (Altus Plateau)", Description = "Altus Plateau")]
        NecromancerGarrisSagesCaveAltusPlateau = 31190850,

        [Display(Name = "Frenzied Duelist - Gaol Cave (Caelid)", Description = "Caelid")]
        FrenziedDuelistGaolCaveCaelid = 31210800,

        [Display(Name = "Beastman of Farum Azula - Dragonbarrow Cave (Dragonbarrow)", Description = "Greyoll's Dragonbarrow")]
        BeastmanOfFarumAzulaDragonbarrowCaveDragonbarrow = 31100800,

        [Display(Name = "Cleanrot Knight - Abandoned Cave (Caelid)", Description = "Caelid")]
        CleanrotKnightAbandonedCaveCaelid = 31200800,

        [Display(Name = "Putrid Crystalians - Sellia Hideaway (Caelid)", Description = "Caelid")]
        PutridCrystaliansSelliaHideawayCaelid = 31110800,

        [Display(Name = "Misbegotten Crusader - Cave of the Forlorn (Mountaintops)", Description = "Mountaintops of the Giants")]
        MisbegottenCrusaderCaveOfTheForlornMountaintops = 31120800,

        [Display(Name = "Spirit-Caller Snail - Spiritcaller's Cave (Mountaintops)", Description = "Mountaintops of the Giants")]
        SpiritCallerSnailSpiritcallersCaveMountaintops = 31220800,

        [Display(Name = "Scaly Misbegotten - Morne Tunnel (Weeping Penisula)", Description = "Weeping Peninsula")]
        ScalyMisbegottenMorneTunnelWeepingPenisula = 32000800,

        [Display(Name = "Stonedigger Troll - Limgrave Tunnels (Limgrave)", Description = "Limgrave")]
        StonediggerTrollLimgraveTunnelsLimgrave = 32010800,

        [Display(Name = "Crystalian (Ringblade) - Raya Lucaria Crystal Tunnel (Liurnia)", Description = "Liurnia of the Lakes")]
        CrystalianRingbladeRayaLucariaCrystalTunnelLiurnia = 32020800,

        [Display(Name = "Stonedigger Troll - Old Altus Tunnel (Altus Plateau)", Description = "Altus Plateau")]
        StonediggerTrollOldAltusTunnelAltusPlateau = 32040800,

        [Display(Name = "Onyx Lord - Divine Tower of West Altus (Altus Plateau)", Description = "Altus Plateau")]
        OnyxLordDivineTowerOfWestAltusAltusPlateau = 34120800,

        [Display(Name = "Crystalian (Ringblade) - Altus Tunnel (Altus Plateau)", Description = "Altus Plateau")]
        CrystalianRingbladeAltusTunnelAltusPlateau = 32050800,

        [Display(Name = "Crystalian (Spear) - Altus Tunnel (Altus Plateau)", Description = "Altus Plateau")]
        CrystalianSpearAltusTunnelAltusPlateau = 32050800,

        [Display(Name = "Magma Wyrm - Gael Tunnel (Caelid)", Description = "Caelid")]
        MagmaWyrmGaelTunnelCaelid = 32070800,

        [Display(Name = "Fallingstar Beast - Sellia Crystal Tunnel (Caelid)", Description = "Caelid")]
        FallingstarBeastSelliaCrystalTunnelCaelid = 32080800,

        [Display(Name = "Astel, Stars of Darkness - Yelough Anix Tunnel (Snowfield)", Description = "Consecrated Snowfield")]
        AstelStarsOfDarknessYeloughAnixTunnelSnowfield = 32110800,

        [Display(Name = "Godskin Apostle - Divine Tower of Caelid (Caelid)", Description = "Caelid")]
        GodskinApostleDivineTowerOfCaelidCaelid = 34130800,

        [Display(Name = "Fell Twins - Divine Tower of East Altus (Capital Outskirts)", Description = "Capital Outskirts")]
        FellTwinsDivineTowerOfEastAltusCapitalOutskirts = 34140850,

        [Display(Name = "Mad Pumpkin Head - Waypoint Ruins (Limgrave)", Description = "Limgrave")]
        MadPumpkinHeadWaypointRuinsLimgrave = 1044360800,

        [Display(Name = "Night's Cavalry - Agheel Lake North (Limgrave)", Description = "Limgrave")]
        NightsCavalryAgheelLakeNorthLimgrave = 1043370800,

        [Display(Name = "Death Rite Bird - Stormgate (Limgrave)", Description = "Limgrave")]
        DeathRiteBirdStormgateLimgrave = 1042380800,

        [Display(Name = "Ball-Bearing Hunter - Warmaster's Shack (Limgrave)", Description = "Limgrave")]
        BallBearingHunterWarmastersShackLimgrave = 1042380850,

        [Display(Name = "Ancient Hero of Zamor - Weeping Evergaol (Weeping Penisula)", Description = "Weeping Peninsula")]
        AncientHeroOfZamorWeepingEvergaolWeepingPenisula = 1042330800,

        [Display(Name = "Bloodhound Knight Darriwill - Forlorn Hound Evergaol (Limgrave)", Description = "Limgrave")]
        BloodhoundKnightDarriwillForlornHoundEvergaolLimgrave = 1044350800,

        [Display(Name = "Crucible Knight - Stormhill Evergaol (Limgrave)", Description = "Limgrave")]
        CrucibleKnightStormhillEvergaolLimgrave = 1042370800,

        [Display(Name = "Erdtree Avatar - Minor Erdtree (Weeping Penisula)", Description = "Weeping Peninsula")]
        ErdtreeAvatarMinorErdtreeWeepingPenisula = 1043330800,

        [Display(Name = "Night's Cavalry - Castle Morne Approach (Weeping Penisula)", Description = "Weeping Peninsula")]
        NightsCavalryCastleMorneApproachWeepingPenisula = 1044320850,

        [Display(Name = "Death Rite Bird - Castle Morne Approach (Weeping Penisula)", Description = "Weeping Peninsula")]
        DeathRiteBirdCastleMorneApproachWeepingPenisula = 1044320800,

        [Display(Name = "Leonine Misbegotten - Castle Morne (Weeping Penisula)", Description = "Weeping Peninsula")]
        LeonineMisbegottenCastleMorneWeepingPenisula = 1043300800,

        [Display(Name = "Tree Sentinel - Church of Elleh (Limgrave)", Description = "Limgrave")]
        TreeSentinelChurchOfEllehLimgrave = 1042360800,

        [Display(Name = "Flying Dragon Agheel - Dragon-Burnt Ruins (Limgrave)", Description = "Limgrave")]
        FlyingDragonAgheelDragonBurntRuinsLimgrave = 1043360800,

        [Display(Name = "Tibia Mariner - Summonwater Village (Limgrave)", Description = "Limgrave")]
        TibiaMarinerSummonwaterVillageLimgrave = 1045390800,

        [Display(Name = "Royal Revenant - Kingsrealm Ruins (Liurnia)", Description = "Liurnia of the Lakes")]
        RoyalRevenantKingsrealmRuinsLiurnia = 1034480800,

        [Display(Name = "Adan, Thief of Fire - Malefactor's Evergaol (Liurnia)", Description = "Liurnia of the Lakes")]
        AdanThiefOfFireMalefactorsEvergaolLiurnia = 1038410800,

        [Display(Name = "Bols, Carian Knight - Cuckoo's Evergaol (Liurnia)", Description = "Liurnia of the Lakes")]
        BolsCarianKnightCuckoosEvergaolLiurnia = 1033450800,

        [Display(Name = "Onyx Lord - Royal Grave Evergaol (Liurnia)", Description = "Liurnia of the Lakes")]
        OnyxLordRoyalGraveEvergaolLiurnia = 1036500800,

        [Display(Name = "Alecto, Black Knife Ringleader - Moonlight Altar (Liurnia)", Description = "Liurnia of the Lakes")]
        AlectoBlackKnifeRingleaderMoonlightAltarLiurnia = 1033420800,

        [Display(Name = "Erdtree Avatar - Revenger's Shack (Liurnia)", Description = "Liurnia of the Lakes")]
        ErdtreeAvatarRevengersShackLiurnia = 1033430800,

        [Display(Name = "Erdtree Avatar - Minor Erdtree (Liurnia)", Description = "Liurnia of the Lakes")]
        ErdtreeAvatarMinorErdtreeLiurnia = 1038480800,

        [Display(Name = "Royal Knight Loretta - Carian Manor (Liurnia)", Description = "Liurnia of the Lakes")]
        RoyalKnightLorettaCarianManorLiurnia = 1035500800,

        [Display(Name = "Ball-Bearing Hunter - Church of Vows (Liurnia)", Description = "Liurnia of the Lakes")]
        BallBearingHunterChurchOfVowsLiurnia = 1037460800,

        [Display(Name = "Night's Cavalry - Liurnia Highway Far North (Liurnia)", Description = "Liurnia of the Lakes")]
        NightsCavalryLiurniaHighwayFarNorthLiurnia = 1039430340,

        [Display(Name = "Night's Cavalry - East Raya Lucaria Gate (Liurnia)", Description = "Liurnia of the Lakes")]
        NightsCavalryEastRayaLucariaGateLiurnia = 1036480340,

        [Display(Name = "Death Rite Bird - Laskyar Ruins (Liurnia)", Description = "Liurnia of the Lakes")]
        DeathRiteBirdLaskyarRuinsLiurnia = 1037420340,

        [Display(Name = "Death Rite Bird - Gate Town Northwest (Liurnia)", Description = "Liurnia of the Lakes")]
        DeathRiteBirdGateTownNorthwestLiurnia = 1036450340,

        [Display(Name = "Glintstone Dragon Smarag - Meeting Place (Liurnia)", Description = "Liurnia of the Lakes")]
        GlintstoneDragonSmaragMeetingPlaceLiurnia = 1034450800,

        [Display(Name = "Glintstone Dragon Adula - Ranni's Rise (Liurnia)", Description = "Liurnia of the Lakes")]
        GlintstoneDragonAdulaRannisRiseLiurnia = 1034500800,

        [Display(Name = "Glintstone Dragon Adula - Moonfolk Ruins (Liurnia)", Description = "Liurnia of the Lakes")]
        GlintstoneDragonAdulaMoonfolkRuinsLiurnia = 1034420800,

        [Display(Name = "Omenkiller - Village of the Albinaurics (Liurnia)", Description = "Liurnia of the Lakes")]
        OmenkillerVillageOfTheAlbinauricsLiurnia = 1035420800,

        [Display(Name = "Tibia Mariner - Jarburg (Liurnia)", Description = "Liurnia of the Lakes")]
        TibiaMarinerJarburgLiurnia = 1039440800,

        [Display(Name = "Ancient Dragon Lansseax - Abandoned Coffin (Altus Plateau)", Description = "Altus Plateau")]
        AncientDragonLansseaxAbandonedCoffinAltusPlateau = 1037510800,

        [Display(Name = "Ancient Dragon Lansseax - Rampartside Path (Altus Plateau)", Description = "Altus Plateau")]
        AncientDragonLansseaxRampartsidePathAltusPlateau = 1041520800,

        [Display(Name = "Demi-Human Queen - Lux Ruins (Altus Plateau)", Description = "Altus Plateau")]
        DemiHumanQueenLuxRuinsAltusPlateau = 1038510800,

        [Display(Name = "Fallingstar Beast - South of Tree Sentinel Duo (Altus Plateau)", Description = "Altus Plateau")]
        FallingstarBeastSouthOfTreeSentinelDuoAltusPlateau = 1041500800,

        [Display(Name = "Sanguine Noble - Writheblood Ruins (Altus Plateau)", Description = "Altus Plateau")]
        SanguineNobleWrithebloodRuinsAltusPlateau = 1040530800,

        [Display(Name = "Tree Sentinel - Tree Sentinel Duo (Altus Plateau)", Description = "Altus Plateau")]
        TreeSentinelTreeSentinelDuoAltusPlateau = 1041510800,

        [Display(Name = "Godskin Apostle - Windmill Heights (Altus Plateau)", Description = "Altus Plateau")]
        GodskinApostleWindmillHeightsAltusPlateau = 1042550800,

        [Display(Name = "Black Knife Assassin - Sainted Hero's Grave Entrance (Altus Plateau)", Description = "Altus Plateau")]
        BlackKnifeAssassinSaintedHerosGraveEntranceAltusPlateau = 1040520800,

        [Display(Name = "Draconic Tree Sentinel - Capital Rampart (Capital Outskirts)", Description = "Capital Outskirts")]
        DraconicTreeSentinelCapitalRampartCapitalOutskirts = 1045520800,

        [Display(Name = "Godefroy the Grafted - Golden Lineage Evergaol (Altus Plateau)", Description = "Altus Plateau")]
        GodefroyTheGraftedGoldenLineageEvergaolAltusPlateau = 1039500800,

        [Display(Name = "Wormface - Woodfolk Ruins (Altus Plateau)", Description = "Altus Plateau")]
        WormfaceWoodfolkRuinsAltusPlateau = 1041530800,

        [Display(Name = "Night's Cavalry - Altus Highway Junction (Altus Plateau)", Description = "Altus Plateau")]
        NightsCavalryAltusHighwayJunctionAltusPlateau = 1043530800,

        [Display(Name = "Death Rite Bird - Minor Erdtree (Capital Outskirts)", Description = "Capital Outskirts")]
        DeathRiteBirdMinorErdtreeCapitalOutskirts = 1043530800,

        [Display(Name = "Ball-Bearing Hunter - Hermit Merchant's Shack (Capital Outskirts)", Description = "Capital Outskirts")]
        BallBearingHunterHermitMerchantsShackCapitalOutskirts = 1043530800,

        [Display(Name = "Demi-Human Queen - Primeval Sorcerer Azur (Mt. Gelmir)", Description = "Mt. Gelmir")]
        DemiHumanQueenPrimevalSorcererAzurMtGelmir = 1037530800,

        [Display(Name = "Magma Wyrm - Seethewater Terminus (Mt. Gelmir)", Description = "Mt. Gelmir")]
        MagmaWyrmSeethewaterTerminusMtGelmir = 1035530800,

        [Display(Name = "Full-Grown Fallingstar Beast - Crater (Mt. Gelmir)", Description = "Mt. Gelmir")]
        FullGrownFallingstarBeastCraterMtGelmir = 1036540800,

        [Display(Name = "Elemer of the Briar - Shaded Castle (Altus Plateau)", Description = "Altus Plateau")]
        ElemerOfTheBriarShadedCastleAltusPlateau = 1039540800,

        [Display(Name = "Ulcerated Tree Spirit - Minor Erdtree (Mt. Gelmir)", Description = "Mt. Gelmir")]
        UlceratedTreeSpiritMinorErdtreeMtGelmir = 1037540810,

        [Display(Name = "Tibia Mariner - Wyndham Ruins (Altus Plateau)", Description = "Altus Plateau")]
        TibiaMarinerWyndhamRuinsAltusPlateau = 1038520800,

        [Display(Name = "Putrid Avatar - Minor Erdtree (Caelid)", Description = "Caelid")]
        PutridAvatarMinorErdtreeCaelid = 1047400800,

        [Display(Name = "Decaying Ekzykes - Caelid Highway South (Caelid)", Description = "Caelid")]
        DecayingEkzykesCaelidHighwaySouthCaelid = 1048370800,

        [Display(Name = "Monstrous Dog - Southwest of Caelid Highway South (Caelid)", Description = "Caelid")]
        MonstrousDogSouthwestOfCaelidHighwaySouthCaelid = 1048400800,

        [Display(Name = "Night's Cavalry - Southern Aeonia Swamp Bank (Caelid)", Description = "Caelid")]
        NightsCavalrySouthernAeoniaSwampBankCaelid = 1049370800,

        [Display(Name = "Death Rite Bird - Southern Aeonia Swamp Bank (Caelid)", Description = "Caelid")]
        DeathRiteBirdSouthernAeoniaSwampBankCaelid = 1049370850,

        [Display(Name = "Commander O'Neil - East Aeonia Swamp (Caelid)", Description = "Caelid")]
        CommanderONeilEastAeoniaSwampCaelid = 1049380800,

        [Display(Name = "Crucible Knight - Redmane Castle (Caelid)", Description = "Caelid")]
        CrucibleKnightRedmaneCastleCaelid = 1051360800,

        [Display(Name = "Starscourge Radahn - Battlefield (Caelid)", Description = "Caelid")]
        StarscourgeRadahnBattlefieldCaelid = 1252380800,

        [Display(Name = "Nox Priest - West Sellia (Caelid)", Description = "Caelid")]
        NoxPriestWestSelliaCaelid = 1049390800,

        [Display(Name = "Bell-Bearing Hunter - Isolated Merchant's Shack (Dragonbarrow)", Description = "Greyoll's Dragonbarrow")]
        BallBearingHunterIsolatedMerchantsShackDragonbarrow = 1048410800,

        [Display(Name = "Battlemage Hugues - Sellia Crystal Tunnel Entrance (Caelid)", Description = "Caelid")]
        BattlemageHuguesSelliaCrystalTunnelEntranceCaelid = 1049390850,

        [Display(Name = "Putrid Avatar - Dragonbarrow Fork (Caelid)", Description = "Caelid")]
        PutridAvatarDragonbarrowForkCaelid = 1051400800,

        [Display(Name = "Flying Dragon Greyll - Dragonbarrow (Caelid)", Description = "Caelid")]
        FlyingDragonGreyllDragonbarrowCaelid = 1052410800,

        [Display(Name = "Night's Cavalry - Dragonbarrow (Caelid)", Description = "Caelid")]
        NightsCavalryDragonbarrowCaelid = 1052410850,

        [Display(Name = "Black Blade Kindred - Bestial Sanctum (Caelid)", Description = "Caelid")]
        BlackBladeKindredBestialSanctumCaelid = 1051430800,

        [Display(Name = "Night's Cavalry - Forbidden Lands (Mountaintops)", Description = "Mountaintops of the Giants")]
        NightsCavalryForbiddenLandsMountaintops = 1048510800,

        [Display(Name = "Black Blade Kindred - Before Grand Lift of Rold (Mountaintops)", Description = "Mountaintops of the Giants")]
        BlackBladeKindredBeforeGrandLiftOfRoldMountaintops = 1049520800,

        [Display(Name = "Borealis the Freezing Fog - Freezing Fields (Mountaintops)", Description = "Mountaintops of the Giants")]
        BorealisTheFreezingFogFreezingFieldsMountaintops = 1054560800,

        [Display(Name = "Roundtable Knight Vyke - Lord Contender's Evergaol (Mountaintops)", Description = "Mountaintops of the Giants")]
        RoundtableKnightVykeLordContendersEvergaolMountaintops = 1053560800,

        [Display(Name = "Fire Giant - Giant's Forge (Mountaintops)", Description = "Mountaintops of the Giants")]
        FireGiantGiantsForgeMountaintops = 1052520800,

        [Display(Name = "Erdtree Avatar - Minor Erdtree (Mountaintops)", Description = "Mountaintops of the Giants")]
        ErdtreeAvatarMinorErdtreeMountaintops = 1052560800,

        [Display(Name = "Death Rite Bird - West of Castle So (Mountaintops)", Description = "Mountaintops of the Giants")]
        DeathRiteBirdWestOfCastleSoMountaintops = 1050570800,

        [Display(Name = "Putrid Avatar - Minor Erdtree (Snowfield)", Description = "Consecrated Snowfield")]
        PutridAvatarMinorErdtreeSnowfield = 1050570850,

        [Display(Name = "Commander Niall - Castle Soul (Mountaintops)", Description = "Mountaintops of the Giants")]
        CommanderNiallCastleSoulMountaintops = 1051570800,

        [Display(Name = "Great Wyrm Theodorix - Albinauric Rise (Mountaintops)", Description = "Mountaintops of the Giants")]
        GreatWyrmTheodorixAlbinauricRiseMountaintops = 1050560800,

        [Display(Name = "Night's Cavalry - Sourthwest (Mountaintops)", Description = "Mountaintops of the Giants")]
        NightsCavalrySourthwestMountaintops = 1248550800,

        [Display(Name = "Death Rite Bird - Ordina, Liturgical Town (Snowfield)", Description = "Consecrated Snowfield")]
        DeathRiteBirdOrdinaLiturgicalTownSnowfield = 1048570800,
    }
}
