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
    public enum Boss : uint
    {
        [AnnotationAttribute(Name = "Godrick the Grafted - Stormveil Castle", Description = "Stormveil Castle")]
        GodrickTheGraftedStormveilCastle = 10000800,

        [AnnotationAttribute(Name = "Margit, the Fell Omen - Stormveil Castle", Description = "Stormveil Castle")]
        MargitTheFellOmenStormveilCastle = 10000850,

        [AnnotationAttribute(Name = "Grafted Scion - Chapel of Anticipation", Description = "Limgrave")]
        GraftedScionChapelOfAnticipation = 10010800,

        [AnnotationAttribute(Name = "Morgott, the Omen King - Leyndell", Description = "Leyndell")]
        MorgottTheOmenKingLeyndell = 11000800,

        [AnnotationAttribute(Name = "Godfrey, First Elden Lord - Leyndell", Description = "Leyndell")]
        GodfreyFirstEldenLordLeyndell = 11000850,

        [AnnotationAttribute(Name = "Hoarah Loux - Leyndell", Description = "Leyndell")]
        HoarahLouxLeyndell = 11050800,

        [AnnotationAttribute(Name = "Sir Gideon Ofnir, the All-Knowing - Leyndell", Description = "Leyndell")]
        SirGideonOfnirTheAllKnowingLeyndell = 11050850,

        [AnnotationAttribute(Name = "Dragonkin Soldier of Nokstella - Ainsel River", Description = "Ainsel River")]
        DragonkinSoldierOfNokstellaAinselRiver = 12010800,

        [AnnotationAttribute(Name = "Dragonkin Soldier - Lake of Rot", Description = "Lake of Rot")]
        DragonkinSoldierLakeOfRot = 12010850,

        [AnnotationAttribute(Name = "Valiant Gargoyles - Siofra River", Description = "Siofra River")]
        ValiantGargoylesSiofraRiver = 12020800,

        [AnnotationAttribute(Name = "Dragonkin Soldier - Siofra River", Description = "Siofra River")]
        DragonkinSoldierSiofraRiver = 12020830,

        [AnnotationAttribute(Name = "Mimic Tear - Siofra River", Description = "Siofra River")]
        MimicTearSiofraRiver = 12020850,

        [AnnotationAttribute(Name = "Crucible Knight Sirulia - Deeproot Depths", Description = "Deeproot Depths")]
        CrucibleKnightSiruliaDeeprootDepths = 12030390,

        [AnnotationAttribute(Name = "Fia's Champion - Deeproot Depths", Description = "Deeproot Depths")]
        FiasChampionDeeprootDepths = 12030800,

        [AnnotationAttribute(Name = "Lichdragon Fortissax - Deeproot Depths", Description = "Deeproot Depths")]
        LichdragonFortissaxDeeprootDepths = 12030850,

        [AnnotationAttribute(Name = "Astel, Naturalborn of the Void - Lake of Rot", Description = "Lake of Rot")]
        AstelNaturalbornOfTheVoidLakeOfRot = 12040800,

        [AnnotationAttribute(Name = "Mohg, Lord of Blood - Mohgwyn Palace", Description = "Mohgwyn Palace")]
        MohgLordOfBloodMohgwynPalace = 12050800,

        [AnnotationAttribute(Name = "Ancestor Spirit - Siofra River", Description = "Siofra River")]
        AncestorSpiritSiofraRiver = 12080800,

        [AnnotationAttribute(Name = "Regal Ancestor Spirit - Nokron, Eternal City", Description = "Nokron, Eternal City")]
        RegalAncestorSpiritNokronEternalCity = 12090800,

        [AnnotationAttribute(Name = "Maliketh, The Black Blade - Crumbling Farum Azula", Description = "Crumbling Farum Azula")]
        MalikethTheBlackBladeCrumblingFarumAzula = 13000800,

        [AnnotationAttribute(Name = "Dragonlord Placidusax - Crumbling Farum Azula", Description = "Crumbling Farum Azula")]
        DragonlordPlacidusaxCrumblingFarumAzula = 13000830,

        [AnnotationAttribute(Name = "Godskin Duo - Crumbling Farum Azula", Description = "Crumbling Farum Azula")]
        GodskinDuoCrumblingFarumAzula = 13000850,

        [AnnotationAttribute(Name = "Rennala, Queen of the Full Moon - Academy of Raya Lucaria", Description = "Academy of Raya Lucaria")]
        RennalaQueenOfTheFullMoonAcademyOfRayaLucaria = 14000800,

        [AnnotationAttribute(Name = "Red Wolf of Radagon - Academy of Raya Lucaria", Description = "Academy of Raya Lucaria")]
        RedWolfOfRadagonAcademyOfRayaLucaria = 14000850,

        [AnnotationAttribute(Name = "Malenia, Blade of Miquella - Miquella's Haligtree", Description = "Miquella's Haligtree")]
        MaleniaBladeOfMiquellaMiquellasHaligtree = 15000800,

        [AnnotationAttribute(Name = "Loretta, Knight of the Haligtree - Miquella's Haligtree", Description = "Miquella's Haligtree")]
        LorettaKnightOfTheHaligtreeMiquellasHaligtree = 15000850,

        [AnnotationAttribute(Name = "Rykard, Lord of Blasphemy - Volcano Manor", Description = "Volcano Manor")]
        RykardLordOfBlasphemyVolcanoManor = 16000800,

        [AnnotationAttribute(Name = "Godskin Noble - Volcano Manor", Description = "Volcano Manor")]
        GodskinNobleVolcanoManor = 16000850,

        [AnnotationAttribute(Name = "Abductor Virgins - Volcano Manor", Description = "Volcano Manor")]
        AbductorVirginsVolcanoManor = 16000860,

        [AnnotationAttribute(Name = "Ulcerated Tree Spirit - Stranded Graveyard", Description = "Stranded Graveyard")]
        UlceratedTreeSpiritStrandedGraveyard = 18000800,

        [AnnotationAttribute(Name = "Soldier of Godrick - Stranded Graveyard", Description = "Stranded Graveyard")]
        SoldierOfGodrickStrandedGraveyard = 18000850,

        [AnnotationAttribute(Name = "Elden Beast - Elden Throne", Description = "Leyndell")]
        EldenBeastEldenThrone = 19000800,

        [AnnotationAttribute(Name = "Mohg, The Omen - Subterranean Shunning-Grounds (Leyndell)", Description = "Subterranean Shunning-Grounds")]
        MohgTheOmenSubterraneanShunningGroundsLeyndell = 35000800,

        [AnnotationAttribute(Name = "Esgar, Priest of Blood - Subterranean Shunning-Grounds (Leyndell)", Description = "Subterranean Shunning-Grounds")]
        EsgarPriestOfBloodSubterraneanShunningGroundsLeyndell = 35000850,

        [AnnotationAttribute(Name = "Magma Wyrm Makar - Ruin-Strewn Precipice (Liurnia)", Description = "Liurnia of the Lakes")]
        MagmaWyrmMakarRuinStrewnPrecipiceLiurnia = 39200800,

        [AnnotationAttribute(Name = "Cemetery Shade - Tombsward Catacombs (Limgrave)", Description = "Limgrave")]
        CemeteryShadeTombswardCatacombsLimgrave = 30000800,

        [AnnotationAttribute(Name = "Erdtree Burial Watchdog - Impaler's Catacombs (Weeping Penisula)", Description = "Weeping Peninsula")]
        ErdtreeBurialWatchdogImpalersCatacombsWeepingPenisula = 30010800,

        [AnnotationAttribute(Name = "Erdtree Burial Watchdog - Stormfoot Catacombs (Limgrave)", Description = "Limgrave")]
        ErdtreeBurialWatchdogStormfootCatacombsLimgrave = 30020800,

        [AnnotationAttribute(Name = "Black Knife Assassin - Deathtouched Catacombs (Limgrave)", Description = "Limgrave")]
        BlackKnifeAssassinDeathtouchedCatacombsLimgrave = 30110800,

        [AnnotationAttribute(Name = "Grave Warden Duelist - Murkwater Catacombs (Limgrave)", Description = "Limgrave")]
        GraveWardenDuelistMurkwaterCatacombsLimgrave = 30040800,

        [AnnotationAttribute(Name = "Cemetery Shade - Black Knife Catacombs (Liurnia)", Description = "Liurnia of the Lakes")]
        CemeteryShadeBlackKnifeCatacombsLiurnia = 30050800,

        [AnnotationAttribute(Name = "Black Knife Assassin - Black Knife Catacombs (Liurnia)", Description = "Liurnia of the Lakes")]
        BlackKnifeAssassinBlackKnifeCatacombsLiurnia = 30050850,

        [AnnotationAttribute(Name = "Spirit-Caller Snail - Road's End Catacombs (Liurnia)", Description = "Liurnia of the Lakes")]
        SpiritCallerSnailRoadsEndCatacombsLiurnia = 30030800,

        [AnnotationAttribute(Name = "Erdtree Burial Watchdog - Cliffbottom Catacombs (Liurnia)", Description = "Liurnia of the Lakes")]
        ErdtreeBurialWatchdogCliffbottomCatacombsLiurnia = 30060800,

        [AnnotationAttribute(Name = "Ancient Hero of Zamor - Sainted Hero's Grave (Altus Plateau)", Description = "Altus Plateau")]
        AncientHeroOfZamorSaintedHerosGraveAltusPlateau = 30080800,

        [AnnotationAttribute(Name = "Red Wolf of the Champion - Gelmir Hero's Grave (Mt. Gelmir)", Description = "Mt. Gelmir")]
        RedWolfOfTheChampionGelmirHerosGraveMtGelmir = 30090800,

        [AnnotationAttribute(Name = "Crucible Knight Ordovis - Auriza Hero's Grave (Altus Plateau)", Description = "Altus Plateau")]
        CrucibleKnightOrdovisAurizaHerosGraveAltusPlateau = 30100800,

        [AnnotationAttribute(Name = "Crucible Knight (Tree Spear) - Auriza Hero's Grave (Altus Plateau)", Description = "Altus Plateau")]
        CrucibleKnightTreeSpearAurizaHerosGraveAltusPlateau = 30100800,

        [AnnotationAttribute(Name = "Misbegotten Warrior - Unsightly Catacombs (Mt. Gelmir)", Description = "Mt. Gelmir")]
        MisbegottenWarriorUnsightlyCatacombsMtGelmir = 30120800,

        [AnnotationAttribute(Name = "Perfumer Tricia - Unsightly Catacombs (Mt. Gelmir)", Description = "Mt. Gelmir")]
        PerfumerTriciaUnsightlyCatacombsMtGelmir = 30120800,

        [AnnotationAttribute(Name = "Erdtree Burial Watchdog - Wyndham Catacombs (Altus Plateau)", Description = "Altus Plateau")]
        ErdtreeBurialWatchdogWyndhamCatacombsAltusPlateau = 30070800,

        [AnnotationAttribute(Name = "Grave Warden Duelist - Auriza Side Tomb (Altus Plateau)", Description = "Altus Plateau")]
        GraveWardenDuelistAurizaSideTombAltusPlateau = 30130800,

        [AnnotationAttribute(Name = "Erdtree Burial Watchdog - Minor Erdtree Catacombs (Caelid)", Description = "Caelid")]
        ErdtreeBurialWatchdogMinorErdtreeCatacombsCaelid = 30140800,

        [AnnotationAttribute(Name = "Cemetery Shade - Caelid Catacombs (Caelid)", Description = "Caelid")]
        CemeteryShadeCaelidCatacombsCaelid = 30150800,

        [AnnotationAttribute(Name = "Putrid Tree Spirit - War-Dead Catacombs (Caelid)", Description = "Caelid")]
        PutridTreeSpiritWarDeadCatacombsCaelid = 30160800,

        [AnnotationAttribute(Name = "Ancient Hero of Zamor - Giant-Conquering Hero's Grave (Mountaintops)", Description = "Mountaintops of the Giants")]
        AncientHeroOfZamorGiantConqueringHerosGraveMountaintops = 30170800,

        [AnnotationAttribute(Name = "Ulcerated Tree Sprit - Giants' Mountaintop Catacombs (Mountaintops)", Description = "Mountaintops of the Giants")]
        UlceratedTreeSpritGiantsMountaintopCatacombsMountaintops = 30180800,

        [AnnotationAttribute(Name = "Putrid Grave Warden Duelist - Consecrated Snowfield Catacombs (Snowfield)", Description = "Consecrated Snowfield")]
        PutridGraveWardenDuelistConsecratedSnowfieldCatacombsSnowfield = 30190800,

        [AnnotationAttribute(Name = "Stray Mimic Tear - Hidden Path to the Haligtree", Description = "Forbidden Lands")]
        StrayMimicTearHiddenPathToTheHaligtree = 30202800,

        [AnnotationAttribute(Name = "Patches - Murkwater Cave (Limgrave)", Description = "Limgrave")]
        PatchesMurkwaterCaveLimgrave = 31000800,

        [AnnotationAttribute(Name = "Runebear - Earthbore Cave (Weeping Penisula)", Description = "Weeping Peninsula")]
        RunebearEarthboreCaveWeepingPenisula = 31010800,

        [AnnotationAttribute(Name = "Miranda the Blighted Bloom - Tombsward Cave (Limgrave)", Description = "Limgrave")]
        MirandaTheBlightedBloomTombswardCaveLimgrave = 31020800,

        [AnnotationAttribute(Name = "Beastman of Farum Azula - Groveside Cave (Limgrave)", Description = "Limgrave")]
        BeastmanOfFarumAzulaGrovesideCaveLimgrave = 31030800,

        [AnnotationAttribute(Name = "Demi-Human Chief - Coastal Cave (Limgrave)", Description = "Limgrave")]
        DemiHumanChiefCoastalCaveLimgrave = 31150800,

        [AnnotationAttribute(Name = "Guardian Golem - Highroad Cave (Limgrave)", Description = "Limgrave")]
        GuardianGolemHighroadCaveLimgrave = 31170800,

        [AnnotationAttribute(Name = "Cleanrot Knight - Stillwater Cave (Liurnia)", Description = "Liurnia of the Lakes")]
        CleanrotKnightStillwaterCaveLiurnia = 31040800,

        [AnnotationAttribute(Name = "Bloodhound Knight - Lakeside Crystal Cave (Liurnia)", Description = "Liurnia of the Lakes")]
        BloodhoundKnightLakesideCrystalCaveLiurnia = 31050800,

        [AnnotationAttribute(Name = "Crystalians - Academy Crystal Cave (Liurnia)", Description = "Liurnia of the Lakes")]
        CrystaliansAcademyCrystalCaveLiurnia = 31060800,

        [AnnotationAttribute(Name = "Kindred of Rot - Seethewater Cave (Mt. Gelmir)", Description = "Mt. Gelmir")]
        KindredOfRotSeethewaterCaveMtGelmir = 31070800,

        [AnnotationAttribute(Name = "Demi-Human Queen Margot - Volcano Cave (Mt. Gelmir)", Description = "Mt. Gelmir")]
        DemiHumanQueenMargotVolcanoCaveMtGelmir = 31090800,

        [AnnotationAttribute(Name = "Miranda the Blighted Bloom - Perfumer's Grotto (Altus Plateau)", Description = "Altus Plateau")]
        MirandaTheBlightedBloomPerfumersGrottoAltusPlateau = 31180800,

        [AnnotationAttribute(Name = "Black Knife Assassin - Sage's Cave (Altus Plateau)", Description = "Altus Plateau")]
        BlackKnifeAssassinSagesCaveAltusPlateau = 31190800,

        [AnnotationAttribute(Name = "Necromancer Garris - Sage's Cave (Altus Plateau)", Description = "Altus Plateau")]
        NecromancerGarrisSagesCaveAltusPlateau = 31190850,

        [AnnotationAttribute(Name = "Frenzied Duelist - Gaol Cave (Caelid)", Description = "Caelid")]
        FrenziedDuelistGaolCaveCaelid = 31210800,

        [AnnotationAttribute(Name = "Beastman of Farum Azula - Dragonbarrow Cave (Dragonbarrow)", Description = "Greyoll's Dragonbarrow")]
        BeastmanOfFarumAzulaDragonbarrowCaveDragonbarrow = 31100800,

        [AnnotationAttribute(Name = "Cleanrot Knight - Abandoned Cave (Caelid)", Description = "Caelid")]
        CleanrotKnightAbandonedCaveCaelid = 31200800,

        [AnnotationAttribute(Name = "Putrid Crystalians - Sellia Hideaway (Caelid)", Description = "Caelid")]
        PutridCrystaliansSelliaHideawayCaelid = 31110800,

        [AnnotationAttribute(Name = "Misbegotten Crusader - Cave of the Forlorn (Mountaintops)", Description = "Mountaintops of the Giants")]
        MisbegottenCrusaderCaveOfTheForlornMountaintops = 31120800,

        [AnnotationAttribute(Name = "Spirit-Caller Snail - Spiritcaller's Cave (Mountaintops)", Description = "Mountaintops of the Giants")]
        SpiritCallerSnailSpiritcallersCaveMountaintops = 31220800,

        [AnnotationAttribute(Name = "Scaly Misbegotten - Morne Tunnel (Weeping Penisula)", Description = "Weeping Peninsula")]
        ScalyMisbegottenMorneTunnelWeepingPenisula = 32000800,

        [AnnotationAttribute(Name = "Stonedigger Troll - Limgrave Tunnels (Limgrave)", Description = "Limgrave")]
        StonediggerTrollLimgraveTunnelsLimgrave = 32010800,

        [AnnotationAttribute(Name = "Crystalian (Ringblade) - Raya Lucaria Crystal Tunnel (Liurnia)", Description = "Liurnia of the Lakes")]
        CrystalianRingbladeRayaLucariaCrystalTunnelLiurnia = 32020800,

        [AnnotationAttribute(Name = "Stonedigger Troll - Old Altus Tunnel (Altus Plateau)", Description = "Altus Plateau")]
        StonediggerTrollOldAltusTunnelAltusPlateau = 32040800,

        [AnnotationAttribute(Name = "Onyx Lord - Divine Tower of West Altus (Altus Plateau)", Description = "Altus Plateau")]
        OnyxLordDivineTowerOfWestAltusAltusPlateau = 34120800,

        [AnnotationAttribute(Name = "Crystalian (Ringblade) - Altus Tunnel (Altus Plateau)", Description = "Altus Plateau")]
        CrystalianRingbladeAltusTunnelAltusPlateau = 32050800,

        [AnnotationAttribute(Name = "Crystalian (Spear) - Altus Tunnel (Altus Plateau)", Description = "Altus Plateau")]
        CrystalianSpearAltusTunnelAltusPlateau = 32050800,

        [AnnotationAttribute(Name = "Magma Wyrm - Gael Tunnel (Caelid)", Description = "Caelid")]
        MagmaWyrmGaelTunnelCaelid = 32070800,

        [AnnotationAttribute(Name = "Fallingstar Beast - Sellia Crystal Tunnel (Caelid)", Description = "Caelid")]
        FallingstarBeastSelliaCrystalTunnelCaelid = 32080800,

        [AnnotationAttribute(Name = "Astel, Stars of Darkness - Yelough Anix Tunnel (Snowfield)", Description = "Consecrated Snowfield")]
        AstelStarsOfDarknessYeloughAnixTunnelSnowfield = 32110800,

        [AnnotationAttribute(Name = "Godskin Apostle - Divine Tower of Caelid (Caelid)", Description = "Caelid")]
        GodskinApostleDivineTowerOfCaelidCaelid = 34130800,

        [AnnotationAttribute(Name = "Fell Twins - Divine Tower of East Altus (Capital Outskirts)", Description = "Capital Outskirts")]
        FellTwinsDivineTowerOfEastAltusCapitalOutskirts = 34140850,

        [AnnotationAttribute(Name = "Mad Pumpkin Head - Waypoint Ruins (Limgrave)", Description = "Limgrave")]
        MadPumpkinHeadWaypointRuinsLimgrave = 1044360800,

        [AnnotationAttribute(Name = "Night's Cavalry - Agheel Lake North (Limgrave)", Description = "Limgrave")]
        NightsCavalryAgheelLakeNorthLimgrave = 1043370800,

        [AnnotationAttribute(Name = "Death Rite Bird - Stormgate (Limgrave)", Description = "Limgrave")]
        DeathRiteBirdStormgateLimgrave = 1042380800,

        [AnnotationAttribute(Name = "Ball-Bearing Hunter - Warmaster's Shack (Limgrave)", Description = "Limgrave")]
        BallBearingHunterWarmastersShackLimgrave = 1042380850,

        [AnnotationAttribute(Name = "Ancient Hero of Zamor - Weeping Evergaol (Weeping Penisula)", Description = "Weeping Peninsula")]
        AncientHeroOfZamorWeepingEvergaolWeepingPenisula = 1042330800,

        [AnnotationAttribute(Name = "Bloodhound Knight Darriwill - Forlorn Hound Evergaol (Limgrave)", Description = "Limgrave")]
        BloodhoundKnightDarriwillForlornHoundEvergaolLimgrave = 1044350800,

        [AnnotationAttribute(Name = "Crucible Knight - Stormhill Evergaol (Limgrave)", Description = "Limgrave")]
        CrucibleKnightStormhillEvergaolLimgrave = 1042370800,

        [AnnotationAttribute(Name = "Erdtree Avatar - Minor Erdtree (Weeping Penisula)", Description = "Weeping Peninsula")]
        ErdtreeAvatarMinorErdtreeWeepingPenisula = 1043330800,

        [AnnotationAttribute(Name = "Night's Cavalry - Castle Morne Approach (Weeping Penisula)", Description = "Weeping Peninsula")]
        NightsCavalryCastleMorneApproachWeepingPenisula = 1044320850,

        [AnnotationAttribute(Name = "Death Rite Bird - Castle Morne Approach (Weeping Penisula)", Description = "Weeping Peninsula")]
        DeathRiteBirdCastleMorneApproachWeepingPenisula = 1044320800,

        [AnnotationAttribute(Name = "Leonine Misbegotten - Castle Morne (Weeping Penisula)", Description = "Weeping Peninsula")]
        LeonineMisbegottenCastleMorneWeepingPenisula = 1043300800,

        [AnnotationAttribute(Name = "Tree Sentinel - Church of Elleh (Limgrave)", Description = "Limgrave")]
        TreeSentinelChurchOfEllehLimgrave = 1042360800,

        [AnnotationAttribute(Name = "Flying Dragon Agheel - Dragon-Burnt Ruins (Limgrave)", Description = "Limgrave")]
        FlyingDragonAgheelDragonBurntRuinsLimgrave = 1043360800,

        [AnnotationAttribute(Name = "Tibia Mariner - Summonwater Village (Limgrave)", Description = "Limgrave")]
        TibiaMarinerSummonwaterVillageLimgrave = 1045390800,

        [AnnotationAttribute(Name = "Royal Revenant - Kingsrealm Ruins (Liurnia)", Description = "Liurnia of the Lakes")]
        RoyalRevenantKingsrealmRuinsLiurnia = 1034480800,

        [AnnotationAttribute(Name = "Adan, Thief of Fire - Malefactor's Evergaol (Liurnia)", Description = "Liurnia of the Lakes")]
        AdanThiefOfFireMalefactorsEvergaolLiurnia = 1038410800,

        [AnnotationAttribute(Name = "Bols, Carian Knight - Cuckoo's Evergaol (Liurnia)", Description = "Liurnia of the Lakes")]
        BolsCarianKnightCuckoosEvergaolLiurnia = 1033450800,

        [AnnotationAttribute(Name = "Onyx Lord - Royal Grave Evergaol (Liurnia)", Description = "Liurnia of the Lakes")]
        OnyxLordRoyalGraveEvergaolLiurnia = 1036500800,

        [AnnotationAttribute(Name = "Alecto, Black Knife Ringleader - Moonlight Altar (Liurnia)", Description = "Liurnia of the Lakes")]
        AlectoBlackKnifeRingleaderMoonlightAltarLiurnia = 1033420800,

        [AnnotationAttribute(Name = "Erdtree Avatar - Revenger's Shack (Liurnia)", Description = "Liurnia of the Lakes")]
        ErdtreeAvatarRevengersShackLiurnia = 1033430800,

        [AnnotationAttribute(Name = "Erdtree Avatar - Minor Erdtree (Liurnia)", Description = "Liurnia of the Lakes")]
        ErdtreeAvatarMinorErdtreeLiurnia = 1038480800,

        [AnnotationAttribute(Name = "Royal Knight Loretta - Carian Manor (Liurnia)", Description = "Liurnia of the Lakes")]
        RoyalKnightLorettaCarianManorLiurnia = 1035500800,

        [AnnotationAttribute(Name = "Ball-Bearing Hunter - Church of Vows (Liurnia)", Description = "Liurnia of the Lakes")]
        BallBearingHunterChurchOfVowsLiurnia = 1037460800,

        [AnnotationAttribute(Name = "Night's Cavalry - Liurnia Highway Far North (Liurnia)", Description = "Liurnia of the Lakes")]
        NightsCavalryLiurniaHighwayFarNorthLiurnia = 1039430800,

        [AnnotationAttribute(Name = "Night's Cavalry - East Raya Lucaria Gate (Liurnia)", Description = "Liurnia of the Lakes")]
        NightsCavalryEastRayaLucariaGateLiurnia = 1036480800,

        [AnnotationAttribute(Name = "Deathbird - Laskyar Ruins (Liurnia)", Description = "Liurnia of the Lakes")]
        DeathRiteBirdLaskyarRuinsLiurnia = 1037420800,

        [AnnotationAttribute(Name = "Death Rite Bird - Gate Town Northwest (Liurnia)", Description = "Liurnia of the Lakes")]
        DeathRiteBirdGateTownNorthwestLiurnia = 1036450800,

        [AnnotationAttribute(Name = "Glintstone Dragon Smarag - Meeting Place (Liurnia)", Description = "Liurnia of the Lakes")]
        GlintstoneDragonSmaragMeetingPlaceLiurnia = 1034450800,

        //[Display(Name = "Glintstone Dragon Adula - Ranni's Rise (Liurnia)", Description = "Liurnia of the Lakes")]
        //GlintstoneDragonAdulaRannisRiseLiurnia = 1034500800,

        [AnnotationAttribute(Name = "Glintstone Dragon Adula - Moonfolk Ruins (Liurnia)", Description = "Liurnia of the Lakes")]
        GlintstoneDragonAdulaMoonfolkRuinsLiurnia = 1034420800,

        [AnnotationAttribute(Name = "Omenkiller - Village of the Albinaurics (Liurnia)", Description = "Liurnia of the Lakes")]
        OmenkillerVillageOfTheAlbinauricsLiurnia = 1035420800,

        [AnnotationAttribute(Name = "Tibia Mariner - Jarburg (Liurnia)", Description = "Liurnia of the Lakes")]
        TibiaMarinerJarburgLiurnia = 1039440800,

        [AnnotationAttribute(Name = "Ancient Dragon Lansseax - Abandoned Coffin (Altus Plateau)", Description = "Altus Plateau")]
        AncientDragonLansseaxAbandonedCoffinAltusPlateau = 1037510800,

        [AnnotationAttribute(Name = "Ancient Dragon Lansseax - Rampartside Path (Altus Plateau)", Description = "Altus Plateau")]
        AncientDragonLansseaxRampartsidePathAltusPlateau = 1041520800,

        [AnnotationAttribute(Name = "Demi-Human Queen - Lux Ruins (Altus Plateau)", Description = "Altus Plateau")]
        DemiHumanQueenLuxRuinsAltusPlateau = 1038510800,

        [AnnotationAttribute(Name = "Fallingstar Beast - South of Tree Sentinel Duo (Altus Plateau)", Description = "Altus Plateau")]
        FallingstarBeastSouthOfTreeSentinelDuoAltusPlateau = 1041500800,

        [AnnotationAttribute(Name = "Sanguine Noble - Writheblood Ruins (Altus Plateau)", Description = "Altus Plateau")]
        SanguineNobleWrithebloodRuinsAltusPlateau = 1040530800,

        [AnnotationAttribute(Name = "Tree Sentinel - Tree Sentinel Duo (Altus Plateau)", Description = "Altus Plateau")]
        TreeSentinelTreeSentinelDuoAltusPlateau = 1041510800,

        [AnnotationAttribute(Name = "Godskin Apostle - Windmill Heights (Altus Plateau)", Description = "Altus Plateau")]
        GodskinApostleWindmillHeightsAltusPlateau = 1042550800,

        [AnnotationAttribute(Name = "Black Knife Assassin - Sainted Hero's Grave Entrance (Altus Plateau)", Description = "Altus Plateau")]
        BlackKnifeAssassinSaintedHerosGraveEntranceAltusPlateau = 1040520800,

        [AnnotationAttribute(Name = "Draconic Tree Sentinel - Capital Rampart (Capital Outskirts)", Description = "Capital Outskirts")]
        DraconicTreeSentinelCapitalRampartCapitalOutskirts = 1045520800,

        [AnnotationAttribute(Name = "Godefroy the Grafted - Golden Lineage Evergaol (Altus Plateau)", Description = "Altus Plateau")]
        GodefroyTheGraftedGoldenLineageEvergaolAltusPlateau = 1039500800,

        [AnnotationAttribute(Name = "Wormface - Woodfolk Ruins (Altus Plateau)", Description = "Altus Plateau")]
        WormfaceWoodfolkRuinsAltusPlateau = 1041530800,

        [AnnotationAttribute(Name = "Night's Cavalry - Altus Highway Junction (Altus Plateau)", Description = "Altus Plateau")]
        NightsCavalryAltusHighwayJunctionAltusPlateau = 1043530800,

        [AnnotationAttribute(Name = "Death Rite Bird - Minor Erdtree (Capital Outskirts)", Description = "Capital Outskirts")]
        DeathRiteBirdMinorErdtreeCapitalOutskirts = 1043530800,

        [AnnotationAttribute(Name = "Ball-Bearing Hunter - Hermit Merchant's Shack (Capital Outskirts)", Description = "Capital Outskirts")]
        BallBearingHunterHermitMerchantsShackCapitalOutskirts = 1043530800,

        [AnnotationAttribute(Name = "Demi-Human Queen - Primeval Sorcerer Azur (Mt. Gelmir)", Description = "Mt. Gelmir")]
        DemiHumanQueenPrimevalSorcererAzurMtGelmir = 1037530800,

        [AnnotationAttribute(Name = "Magma Wyrm - Seethewater Terminus (Mt. Gelmir)", Description = "Mt. Gelmir")]
        MagmaWyrmSeethewaterTerminusMtGelmir = 1035530800,

        [AnnotationAttribute(Name = "Full-Grown Fallingstar Beast - Crater (Mt. Gelmir)", Description = "Mt. Gelmir")]
        FullGrownFallingstarBeastCraterMtGelmir = 1036540800,

        [AnnotationAttribute(Name = "Elemer of the Briar - Shaded Castle (Altus Plateau)", Description = "Altus Plateau")]
        ElemerOfTheBriarShadedCastleAltusPlateau = 1039540800,

        [AnnotationAttribute(Name = "Ulcerated Tree Spirit - Minor Erdtree (Mt. Gelmir)", Description = "Mt. Gelmir")]
        UlceratedTreeSpiritMinorErdtreeMtGelmir = 1037540810,

        [AnnotationAttribute(Name = "Tibia Mariner - Wyndham Ruins (Altus Plateau)", Description = "Altus Plateau")]
        TibiaMarinerWyndhamRuinsAltusPlateau = 1038520800,

        [AnnotationAttribute(Name = "Putrid Avatar - Minor Erdtree (Caelid)", Description = "Caelid")]
        PutridAvatarMinorErdtreeCaelid = 1047400800,

        [AnnotationAttribute(Name = "Decaying Ekzykes - Caelid Highway South (Caelid)", Description = "Caelid")]
        DecayingEkzykesCaelidHighwaySouthCaelid = 1048370800,

        [AnnotationAttribute(Name = "Monstrous Dog - Southwest of Caelid Highway South (Caelid)", Description = "Caelid")]
        MonstrousDogSouthwestOfCaelidHighwaySouthCaelid = 1048400800,

        [AnnotationAttribute(Name = "Night's Cavalry - Southern Aeonia Swamp Bank (Caelid)", Description = "Caelid")]
        NightsCavalrySouthernAeoniaSwampBankCaelid = 1049370800,

        [AnnotationAttribute(Name = "Death Rite Bird - Southern Aeonia Swamp Bank (Caelid)", Description = "Caelid")]
        DeathRiteBirdSouthernAeoniaSwampBankCaelid = 1049370850,

        [AnnotationAttribute(Name = "Commander O'Neil - East Aeonia Swamp (Caelid)", Description = "Caelid")]
        CommanderONeilEastAeoniaSwampCaelid = 1049380800,

        [AnnotationAttribute(Name = "Crucible Knight - Redmane Castle (Caelid)", Description = "Caelid")]
        CrucibleKnightRedmaneCastleCaelid = 1051360800,

        [AnnotationAttribute(Name = "Starscourge Radahn - Battlefield (Caelid)", Description = "Caelid")]
        StarscourgeRadahnBattlefieldCaelid = 1252380800,

        [AnnotationAttribute(Name = "Nox Priest - West Sellia (Caelid)", Description = "Caelid")]
        NoxPriestWestSelliaCaelid = 1049390800,

        [AnnotationAttribute(Name = "Bell-Bearing Hunter - Isolated Merchant's Shack (Dragonbarrow)", Description = "Greyoll's Dragonbarrow")]
        BallBearingHunterIsolatedMerchantsShackDragonbarrow = 1048410800,

        [AnnotationAttribute(Name = "Battlemage Hugues - Sellia Crystal Tunnel Entrance (Caelid)", Description = "Caelid")]
        BattlemageHuguesSelliaCrystalTunnelEntranceCaelid = 1049390850,

        [AnnotationAttribute(Name = "Putrid Avatar - Dragonbarrow Fork (Caelid)", Description = "Caelid")]
        PutridAvatarDragonbarrowForkCaelid = 1051400800,

        [AnnotationAttribute(Name = "Flying Dragon Greyll - Dragonbarrow (Caelid)", Description = "Caelid")]
        FlyingDragonGreyllDragonbarrowCaelid = 1052410800,

        [AnnotationAttribute(Name = "Night's Cavalry - Dragonbarrow (Caelid)", Description = "Caelid")]
        NightsCavalryDragonbarrowCaelid = 1052410850,

        [AnnotationAttribute(Name = "Black Blade Kindred - Bestial Sanctum (Caelid)", Description = "Caelid")]
        BlackBladeKindredBestialSanctumCaelid = 1051430800,

        [AnnotationAttribute(Name = "Night's Cavalry - Forbidden Lands (Mountaintops)", Description = "Mountaintops of the Giants")]
        NightsCavalryForbiddenLandsMountaintops = 1048510800,

        [AnnotationAttribute(Name = "Black Blade Kindred - Before Grand Lift of Rold (Mountaintops)", Description = "Mountaintops of the Giants")]
        BlackBladeKindredBeforeGrandLiftOfRoldMountaintops = 1049520800,

        [AnnotationAttribute(Name = "Borealis the Freezing Fog - Freezing Fields (Mountaintops)", Description = "Mountaintops of the Giants")]
        BorealisTheFreezingFogFreezingFieldsMountaintops = 1254560800,

        [AnnotationAttribute(Name = "Roundtable Knight Vyke - Lord Contender's Evergaol (Mountaintops)", Description = "Mountaintops of the Giants")]
        RoundtableKnightVykeLordContendersEvergaolMountaintops = 1053560800,

        [AnnotationAttribute(Name = "Fire Giant - Giant's Forge (Mountaintops)", Description = "Mountaintops of the Giants")]
        FireGiantGiantsForgeMountaintops = 1052520800,

        [AnnotationAttribute(Name = "Erdtree Avatar - Minor Erdtree (Mountaintops)", Description = "Mountaintops of the Giants")]
        ErdtreeAvatarMinorErdtreeMountaintops = 1052560800,

        [AnnotationAttribute(Name = "Death Rite Bird - West of Castle So (Mountaintops)", Description = "Mountaintops of the Giants")]
        DeathRiteBirdWestOfCastleSoMountaintops = 1050570800,

        [AnnotationAttribute(Name = "Putrid Avatar - Minor Erdtree (Snowfield)", Description = "Consecrated Snowfield")]
        PutridAvatarMinorErdtreeSnowfield = 1050570850,

        [AnnotationAttribute(Name = "Commander Niall - Castle Soul (Mountaintops)", Description = "Mountaintops of the Giants")]
        CommanderNiallCastleSoulMountaintops = 1051570800,

        [AnnotationAttribute(Name = "Great Wyrm Theodorix - Albinauric Rise (Mountaintops)", Description = "Mountaintops of the Giants")]
        GreatWyrmTheodorixAlbinauricRiseMountaintops = 1050560800,

        [AnnotationAttribute(Name = "Night's Cavalry - Sourthwest (Mountaintops)", Description = "Mountaintops of the Giants")]
        NightsCavalrySourthwestMountaintops = 1248550800,

        [AnnotationAttribute(Name = "Death Rite Bird - Ordina, Liturgical Town (Snowfield)", Description = "Consecrated Snowfield")]
        DeathRiteBirdOrdinaLiturgicalTownSnowfield = 1048570800,

        [AnnotationAttribute(Name = "Pumpkinhead Duo - Caelem Ruins (Caelid)", Description = "Caelid")]
        PumpkinheadDuoCaelemRuinsCaelid = 1048400800,

        [AnnotationAttribute(Name = "Night's Cavalry - Altus Highway (Altus Plateau)", Description = "Altus Plateau")]
        NightsCavalryAltusHighwayAltusPlateau = 1039510800,
    }
}
