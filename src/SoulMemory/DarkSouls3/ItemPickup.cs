﻿// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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
    public enum ItemPickup : uint
    {
        [AnnotationAttribute(Name = "[Boss] Soul of Boreal Valley Vordt 50002000")]
        BossSoulOfBorealValleyVordt = 50002000,

        [AnnotationAttribute(Name = "[Boss] Soul of the Dancer 50002010")]
        BossSoulOfTheDancer = 50002010,

        [AnnotationAttribute(Name = "[Boss] Soul of Consumed Oceiros 50002020")]
        BossSoulOfConsumedOceiros = 50002020,

        [AnnotationAttribute(Name = "[Boss] Soul of Dragonslayer Armour 50002030")]
        BossSoulOfDragonslayerArmour = 50002030,

        [AnnotationAttribute(Name = "[Boss] Cinders of a Lord 50002040")]
        BossCindersOfaLord = 50002040,

        [AnnotationAttribute(Name = "[Boss] Soul of the Rotted Greatwood 50002060")]
        BossSoulOfTheRottedGreatwood = 50002060,

        [AnnotationAttribute(Name = "[Boss] Dragon Head Stone 50002070")]
        BossDragonHeadStone = 50002070,

        [AnnotationAttribute(Name = "[Boss] Soul of the Nameless King 50002080")]
        BossSoulOfTheNamelessKing = 50002080,

        [AnnotationAttribute(Name = "[Boss] Soul of a Crystal Sage 50002090")]
        BossSoulOfaCrystalSage = 50002090,

        [AnnotationAttribute(Name = "[Boss] Cinders of a Lord 50002100")]
        BossCindersOfaLord_ = 50002100,

        [AnnotationAttribute(Name = "[Boss] Small Doll 50002110")]
        BossSmallDoll = 50002110,

        [AnnotationAttribute(Name = "[Boss] Soul of the Deacons of the Deep 50002111")]
        BossSoulOfTheDeaconsOfTheDeep = 50002111,

        [AnnotationAttribute(Name = "[Boss] Soul of Pontiff Sulyvahn 50002120")]
        BossSoulOfPontiffSulyvahn = 50002120,

        [AnnotationAttribute(Name = "[Boss] Cinders of a Lord 50002130")]
        BossCindersOfaLord__ = 50002130,

        [AnnotationAttribute(Name = "[Boss] Soul of High Lord Wolnir 50002140")]
        BossSoulOfHighLordWolnir = 50002140,

        [AnnotationAttribute(Name = "[Boss] Soul of the Old Demon King 50002150")]
        BossSoulOfTheOldDemonKing = 50002150,

        [AnnotationAttribute(Name = "[Boss] Cinders of a Lord 50002170")]
        BossCindersOfaLord___ = 50002170,

        [AnnotationAttribute(Name = "[Boss] Coiled Sword 50002180")]
        BossCoiledSword = 50002180,

        [AnnotationAttribute(Name = "[Boss] Soul of Champion Gundyr 50002190")]
        BossSoulOfChampionGundyr = 50002190,

        [AnnotationAttribute(Name = "[Boss] Soul of the Lords 50002200")]
        BossSoulOfTheLords = 50002200,

        [AnnotationAttribute(Name = "[Boss] Soul of Sister Friede 50002300")]
        BossSoulOfSisterFriede = 50002300,

        [AnnotationAttribute(Name = "[Boss] Champion's Bones 50002310")]
        BossChampionsBones = 50002310,

        [AnnotationAttribute(Name = "[Boss] Valorheart 50002320")]
        BossValorheart = 50002320,

        [AnnotationAttribute(Name = "[Boss] Soul of the Demon Prince 50002330")]
        BossSoulOfTheDemonPrince = 50002330,

        [AnnotationAttribute(Name = "[Boss] Titanite Slab 50002340")]
        BossTitaniteSlab = 50002340,

        [AnnotationAttribute(Name = "[Boss] Filianore's Spear Ornament 50002341")]
        BossFilianoresSpearOrnament = 50002341,

        [AnnotationAttribute(Name = "[Boss] Soul of Darkeater Midir 50002350")]
        BossSoulOfDarkeaterMidir = 50002350,

        [AnnotationAttribute(Name = "[Boss] Spears of the Church 6830")]
        BossSpearsOfTheChurch = 6830,

        [AnnotationAttribute(Name = "[Boss] Soul of Slave Knight Gael 50002360")]
        BossSoulOfSlaveKnightGael = 50002360,

        [AnnotationAttribute(Name = "Coiled Sword 50002500")]
        CoiledSword = 50002500,

        [AnnotationAttribute(Name = "Rosaria's Fingers - Emblem 54004010")]
        RosariasFingersEmblem = 54004010,

        [AnnotationAttribute(Name = "Warrior of Sunlight - Emblem 6700")]
        WarriorOfSunlightEmblem = 6700,

        [AnnotationAttribute(Name = "[Covenant] Warrior of Sunlight Rank 2 - Sunlight Straight Sword 6702")]
        CovenantWarriorOfSunlightRank2SunlightStraightSword = 6702,

        [AnnotationAttribute(Name = "[Covenant] Warrior of Sunlight Rank 1 - Sunlight Shield 6701")]
        CovenantWarriorOfSunlightRank1SunlightShield = 6701,

        [AnnotationAttribute(Name = "Mound-makers - Emblem 6710")]
        MoundmakersEmblem = 6710,

        [AnnotationAttribute(Name = "[Covenant] Mound-makers Rank 2 - Warmth 6712")]
        CovenantMoundmakersRank2Warmth = 6712,

        [AnnotationAttribute(Name = "[Covenant] Mound-makers Rank 1 - Bloodlust 6711")]
        CovenantMoundmakersRank1Bloodlust = 6711,

        [AnnotationAttribute(Name = "Watchdogs of Farron - Emblem 6720")]
        WatchdogsOfFarronEmblem = 6720,

        [AnnotationAttribute(Name = "[Covenant] Watchdogs of Farron Rank 2 - Wolf Knight's Greatshield 6722")]
        CovenantWatchdogsOfFarronRank2WolfKnightsGreatshield = 6722,

        [AnnotationAttribute(Name = "[Covenant] Watchdogs of Farron Rank 1 - Old Wolf Curved Sword 6721")]
        CovenantWatchdogsOfFarronRank1OldWolfCurvedSword = 6721,

        [AnnotationAttribute(Name = "Aldrich Faithful - Emblem 6730")]
        AldrichFaithfulEmblem = 6730,

        [AnnotationAttribute(Name = "[Covenant] Aldrich Faithful Rank 2 - Archdeacon's Great Staff 6732")]
        CovenantAldrichFaithfulRank2ArchdeaconsGreatStaff = 6732,

        [AnnotationAttribute(Name = "[Covenant] Aldrich Faithful Rank 1 - Great Deep Soul 6731")]
        CovenantAldrichFaithfulRank1GreatDeepSoul = 6731,

        [AnnotationAttribute(Name = "Blue Sentinels - Emblem 6740")]
        BlueSentinelsEmblem = 6740,

        [AnnotationAttribute(Name = "Firebomb 6742")]
        Firebomb = 6742,

        [AnnotationAttribute(Name = "Kukri 6741")]
        Kukri = 6741,

        [AnnotationAttribute(Name = "Blade of the Darkmoon - Emblem 6750")]
        BladeOfTheDarkmoonEmblem = 6750,

        [AnnotationAttribute(Name = "Firebomb 6752")]
        Firebomb_ = 6752,

        [AnnotationAttribute(Name = "Firebomb 6751")]
        Firebomb__ = 6751,

        [AnnotationAttribute(Name = "Rosaria's Fingers - Emblem 6760")]
        RosariasFingersEmblem_ = 6760,

        [AnnotationAttribute(Name = "[Covenant] Rosaria's Fingers Rank 2 - Man-grub's Staff 6762")]
        CovenantRosariasFingersRank2MangrubsStaff = 6762,

        [AnnotationAttribute(Name = "[Covenant] Rosaria's Fingers Rank 1 - Obscuring Ring 6761")]
        CovenantRosariasFingersRank1ObscuringRing = 6761,

        [AnnotationAttribute(Name = "Way of Blue - Emblem 6770")]
        WayOfBlueEmblem = 6770,

        [AnnotationAttribute(Name = "Firebomb 6772")]
        Firebomb___ = 6772,

        [AnnotationAttribute(Name = "Firebomb 6771")]
        Firebomb____ = 6771,

        [AnnotationAttribute(Name = "Divine Spear Fragment 6832")]
        DivineSpearFragment = 6832,

        [AnnotationAttribute(Name = "Young Grass Dew 6831")]
        YoungGrassDew = 6831,

        [AnnotationAttribute(Name = "[Crow] Iron Bracelets 50004300")]
        CrowIronBracelets = 50004300,

        [AnnotationAttribute(Name = "[Crow] Ring of Sacrifice 50004301")]
        CrowRingOfSacrifice = 50004301,

        [AnnotationAttribute(Name = "[Crow] Porcine Shield 50004302")]
        CrowPorcineShield = 50004302,

        [AnnotationAttribute(Name = "[Crow] Lucatiel's Mask 50004303")]
        CrowLucatielsMask = 50004303,

        [AnnotationAttribute(Name = "[Crow] Very good! Carving 50004304")]
        CrowVerygoodCarving = 50004304,

        [AnnotationAttribute(Name = "[Crow] Thank you Carving 50004305")]
        CrowThankyouCarving = 50004305,

        [AnnotationAttribute(Name = "[Crow] I'm sorry Carving 50004306")]
        CrowImsorryCarving = 50004306,

        [AnnotationAttribute(Name = "[Crow] Sunlight Shield 50004307")]
        CrowSunlightShield = 50004307,

        [AnnotationAttribute(Name = "[Crow] Hollow Gem 50004308")]
        CrowHollowGem = 50004308,

        [AnnotationAttribute(Name = "[Crow] Titanite Scale 50004309")]
        CrowTitaniteScale = 50004309,

        [AnnotationAttribute(Name = "[Crow] Help me! Carving 50004310")]
        CrowHelpmeCarving = 50004310,

        [AnnotationAttribute(Name = "[Crow] Titanite Slab 50004311")]
        CrowTitaniteSlab = 50004311,

        [AnnotationAttribute(Name = "[Crow] Hello Carving 50004320")]
        CrowHelloCarving = 50004320,

        [AnnotationAttribute(Name = "[Crow] Armor of the Sun 50004321")]
        CrowArmorOfTheSun = 50004321,

        [AnnotationAttribute(Name = "[Crow] Large Titanite Shard 50004322")]
        CrowLargeTitaniteShard = 50004322,

        [AnnotationAttribute(Name = "[Crow] Titanite Chunk 50004323")]
        CrowTitaniteChunk = 50004323,

        [AnnotationAttribute(Name = "[Crow] Iron Helm 50004324")]
        CrowIronHelm = 50004324,

        [AnnotationAttribute(Name = "[Crow] Twinkling Titanite 50004325")]
        CrowTwinklingTitanite = 50004325,

        [AnnotationAttribute(Name = "[Crow] Iron Leggings 50004326")]
        CrowIronLeggings = 50004326,

        [AnnotationAttribute(Name = "[Crow] Lightning Gem 50004327")]
        CrowLightningGem = 50004327,

        [AnnotationAttribute(Name = "[Crow] Twinkling Titanite 50004328")]
        CrowTwinklingTitanite_ = 50004328,

        [AnnotationAttribute(Name = "[Crow] Blessed Gem 50004329")]
        CrowBlessedGem = 50004329,

        [AnnotationAttribute(Name = "[Crow] Titanite Scale 50004330")]
        CrowTitaniteScale_ = 50004330,

        [AnnotationAttribute(Name = "Titanite Slab 50004700")]
        TitaniteSlab = 50004700,

        [AnnotationAttribute(Name = "[Ludleth of Courland] Skull Ring 50006031")]
        LudlethOfCourlandSkullRing = 50006031,

        [AnnotationAttribute(Name = "[Yuria of Londor] Darkdrift 50006041")]
        YuriaOfLondorDarkdrift = 50006041,

        [AnnotationAttribute(Name = "[Yuria of Londor] Yuria's Ashes 50006043")]
        YuriaOfLondorYuriasAshes = 50006043,

        [AnnotationAttribute(Name = "[Company Captain Yorshka] Yorshka's Chime 50006060")]
        CompanyCaptainYorshkaYorshkasChime = 50006060,

        [AnnotationAttribute(Name = "[Hawkwood the Deserter] Heavy Gem 50006070")]
        HawkwoodTheDeserterHeavyGem = 50006070,

        [AnnotationAttribute(Name = "[Sirris of the Sunless Realms] Sunless Talisman 50006082")]
        SirrisOfTheSunlessRealmsSunlessTalisman = 50006082,

        [AnnotationAttribute(Name = "[Ringfinger Leonhard] Cracked Red Eye Orb 50006090")]
        RingfingerLeonhardCrackedRedEyeOrb = 50006090,

        [AnnotationAttribute(Name = "[Ringfinger Leonhard] Silver Mask 50006093")]
        RingfingerLeonhardSilverMask = 50006093,

        [AnnotationAttribute(Name = "[Ringfinger Leonhard] Lift Chamber Key 50006091")]
        RingfingerLeonhardLiftChamberKey = 50006091,

        [AnnotationAttribute(Name = "[Shrine Handmaid] Priestess Ring 50006110")]
        ShrineHandmaidPriestessRing = 50006110,

        [AnnotationAttribute(Name = "[Greirat of the Undead Settlement] Blue Tearstone Ring 50006120")]
        GreiratOfTheUndeadSettlementBlueTearstoneRing = 50006120,

        [AnnotationAttribute(Name = "[Greirat of the Undead Settlement] Greirat's Ashes 50006121")]
        GreiratOfTheUndeadSettlementGreiratsAshes = 50006121,

        [AnnotationAttribute(Name = "[Orbeck of Vinheim] Orbeck's Ashes 50006132")]
        OrbeckOfVinheimOrbecksAshes = 50006132,

        [AnnotationAttribute(Name = "[Cornyx of the Great Swamp] Pyromancy Flame 50006140")]
        CornyxOfTheGreatSwampPyromancyFlame = 50006140,

        [AnnotationAttribute(Name = "[Cornyx of the Great Swamp] Old Sage's Blindfold 50006141")]
        CornyxOfTheGreatSwampOldSagesBlindfold = 50006141,

        [AnnotationAttribute(Name = "[Cornyx of the Great Swamp] Cornyx's Ashes 50006142")]
        CornyxOfTheGreatSwampCornyxsAshes = 50006142,

        [AnnotationAttribute(Name = "[Karla] Karla's Pointed Hat 50006150")]
        KarlaKarlasPointedHat = 50006150,

        [AnnotationAttribute(Name = "[Karla] Karla's Ashes 50006151")]
        KarlaKarlasAshes = 50006151,

        [AnnotationAttribute(Name = "[Irina of Carim] Tower Key 50006160")]
        IrinaOfCarimTowerKey = 50006160,

        [AnnotationAttribute(Name = "[Irina of Carim] Irina's Ashes 50006164")]
        IrinaOfCarimIrinasAshes = 50006164,

        [AnnotationAttribute(Name = "[Eygon of Carim] Morne's Great Hammer 50006170")]
        EygonOfCarimMornesGreatHammer = 50006170,

        [AnnotationAttribute(Name = "[Anri of Astora #1] Anri's Straight Sword 50006030")]
        AnriOfAstora1AnrisStraightSword = 50006030,

        [AnnotationAttribute(Name = "[Anri of Astora #2] Ring of the Evil Eye 50006190")]
        AnriOfAstora2RingOfTheEvilEye = 50006190,

        [AnnotationAttribute(Name = "[Unbreakable Patches #1] Winged Spear 50006202")]
        UnbreakablePatches1WingedSpear = 50006202,

        [AnnotationAttribute(Name = "[Unbreakable Patches #1] Patches' Ashes 50006203")]
        UnbreakablePatches1PatchesAshes = 50006203,

        [AnnotationAttribute(Name = "[Unbreakable Patches #3] Pierce Shield 73501050")]
        UnbreakablePatches3PierceShield = 73501050,

        [AnnotationAttribute(Name = "[Unbreakable Patches #3] Catarina Helm 73501010")]
        UnbreakablePatches3CatarinaHelm = 73501010,

        [AnnotationAttribute(Name = "[Unbreakable Patches #3] Catarina Armor 73501020")]
        UnbreakablePatches3CatarinaArmor = 73501020,

        [AnnotationAttribute(Name = "[Unbreakable Patches #3] Catarina Gauntlets 73501030")]
        UnbreakablePatches3CatarinaGauntlets = 73501030,

        [AnnotationAttribute(Name = "[Unbreakable Patches #3] Catarina Leggings 73501040")]
        UnbreakablePatches3CatarinaLeggings = 73501040,

        [AnnotationAttribute(Name = "[Siegward of Catarina #1] Catarina Helm 50006217")]
        SiegwardOfCatarina1CatarinaHelm = 50006217,

        [AnnotationAttribute(Name = "[Siegward of Catarina #1] Storm Ruler 50006218")]
        SiegwardOfCatarina1StormRuler = 50006218,

        [AnnotationAttribute(Name = "[Siegward of Catarina #3] Titanite Slab 50006215")]
        SiegwardOfCatarina3TitaniteSlab = 50006215,

        [AnnotationAttribute(Name = "[High Priestess Emma] Small Lothric Banner 50006232")]
        HighPriestessEmmaSmallLothricBanner = 50006232,

        [AnnotationAttribute(Name = "[High Priestess Emma] Basin of Vows 50006230")]
        HighPriestessEmmaBasinOfVows = 50006230,

        [AnnotationAttribute(Name = "[Giant] Hawk Ring 50006251")]
        GiantHawkRing = 50006251,

        [AnnotationAttribute(Name = "[Horace the Hushed] Llewellyn Shield 50006260")]
        HoraceTheHushedLlewellynShield = 50006260,

        [AnnotationAttribute(Name = "[Londor Pilgrim] Chameleon 50006300")]
        LondorPilgrimChameleon = 50006300,

        [AnnotationAttribute(Name = "[Londor Pilgrim] Sword of Avowal 50006301")]
        LondorPilgrimSwordOfAvowal = 50006301,

        [AnnotationAttribute(Name = "[Drowsy Forlorn] Homeward Bone 50006311")]
        DrowsyForlornHomewardBone = 50006311,

        [AnnotationAttribute(Name = "[Sir Vilhelm] Contraption Key 50006520")]
        SirVilhelmContraptionKey = 50006520,

        [AnnotationAttribute(Name = "[Sir Vilhelm] Onyx Blade 50006521")]
        SirVilhelmOnyxBlade = 50006521,

        [AnnotationAttribute(Name = "[Forlorn Corvian Settler] Titanite Slab 50006540")]
        ForlornCorvianSettlerTitaniteSlab = 50006540,

        [AnnotationAttribute(Name = "[Sister Friede] Chillbite Ring 50006550")]
        SisterFriedeChillbiteRing = 50006550,

        [AnnotationAttribute(Name = "[Amnesiac Lapp #1] Champion's Bones 50006623")]
        AmnesiacLapp1ChampionsBones = 50006623,

        [AnnotationAttribute(Name = "[Amnesiac Lapp #2] Siegbräu 50006620")]
        AmnesiacLapp2Siegbräu = 50006620,

        [AnnotationAttribute(Name = "[Amnesiac Lapp #3] Siegbräu 50006622")]
        AmnesiacLapp3Siegbräu = 50006622,

        [AnnotationAttribute(Name = "[Amnesiac Lapp #6] Titanite Slab 50006621")]
        AmnesiacLapp6TitaniteSlab = 50006621,

        [AnnotationAttribute(Name = "[Shira, Knight of Filianore #1] Sacred Chime of Filianore 50006630")]
        ShiraKnightOfFilianore1SacredChimeOfFilianore = 50006630,

        [AnnotationAttribute(Name = "[Shira, Knight of Filianore #1] Titanite Slab 50006631")]
        ShiraKnightOfFilianore1TitaniteSlab = 50006631,

        [AnnotationAttribute(Name = "[Shira, Knight of Filianore #1] Crucifix of the Mad King 50006632")]
        ShiraKnightOfFilianore1CrucifixOfTheMadKing = 50006632,

        [AnnotationAttribute(Name = "[Stone-humped Hag] Old Woman's Ashes 50006660")]
        StonehumpedHagOldWomansAshes = 50006660,

        [AnnotationAttribute(Name = "[Black Hand Gotthard] Grand Archives Key 50006700")]
        BlackHandGotthardGrandArchivesKey = 50006700,

        [AnnotationAttribute(Name = "[Black Hand Kamui] Onikiri and Ubadachi 50006705")]
        BlackHandKamuiOnikiriandUbadachi = 50006705,

        [AnnotationAttribute(Name = "[Havel the Rock] Dragon Tooth 50006710")]
        HavelTheRockDragonTooth = 50006710,

        [AnnotationAttribute(Name = "[Sword Master] Uchigatana 50006720")]
        SwordMasterUchigatana = 50006720,

        [AnnotationAttribute(Name = "[Brigand] Spider Shield 50006730")]
        BrigandSpiderShield = 50006730,

        [AnnotationAttribute(Name = "[Drakeblood Knight] Drakeblood Greatsword 50006740")]
        DrakebloodKnightDrakebloodGreatsword = 50006740,

        [AnnotationAttribute(Name = "[Rapier Champion] Ricard's Rapier 50006750")]
        RapierChampionRicardsRapier = 50006750,

        [AnnotationAttribute(Name = "[Exile Watchdog] Exile Greatsword 50006760")]
        ExileWatchdogExileGreatsword = 50006760,

        [AnnotationAttribute(Name = "[Exile Watchdog] Great Club 50006770")]
        ExileWatchdogGreatClub = 50006770,

        [AnnotationAttribute(Name = "[Yellowfinger Heysel] Heysel Pick 50006780")]
        YellowfingerHeyselHeyselPick = 50006780,

        [AnnotationAttribute(Name = "[Londor Pale Shade] Manikin Claws 50006790")]
        LondorPaleShadeManikinClaws = 50006790,

        [AnnotationAttribute(Name = "[Lion Knight Albert] Golden Wing Crest Shield 50006800")]
        LionKnightAlbertGoldenWingCrestShield = 50006800,

        [AnnotationAttribute(Name = "[Daughter of Crystal Kriemhild] Sage's Crystal Staff 50006810")]
        DaughterOfCrystalKriemhildSagesCrystalStaff = 50006810,

        [AnnotationAttribute(Name = "[Court Sorcerer] Logan's Scroll 50006820")]
        CourtSorcererLogansScroll = 50006820,

        [AnnotationAttribute(Name = "[Drang Knight] Drang Twinspears 50006830")]
        DrangKnightDrangTwinspears = 50006830,

        [AnnotationAttribute(Name = "[Knight Slayer Tsorig #1] Knight Slayer's Ring 50006840")]
        KnightSlayerTsorig1KnightSlayersRing = 50006840,

        [AnnotationAttribute(Name = "[Knight Slayer Tsorig #2] Fume Ultra Greatsword 50006845")]
        KnightSlayerTsorig2FumeUltraGreatsword = 50006845,

        [AnnotationAttribute(Name = "[Creighton the Wanderer] Dragonslayer's Axe 50006850")]
        CreightonTheWandererDragonslayersAxe = 50006850,

        [AnnotationAttribute(Name = "[Alva, Seeker of the Spurned] Murakumo 50006860")]
        AlvaSeekerOfTheSpurnedMurakumo = 50006860,

        [AnnotationAttribute(Name = "[Longfinger Kirk] Barbed Straight Sword 50006870")]
        LongfingerKirkBarbedStraightSword = 50006870,

        [AnnotationAttribute(Name = "[Isabella the Mad] Butcher Knife 50006880")]
        IsabellaTheMadButcherKnife = 50006880,

        [AnnotationAttribute(Name = "[Livid Pyromancer Dunnel] Floating Chaos 50006920")]
        LividPyromancerDunnelFloatingChaos = 50006920,

        [AnnotationAttribute(Name = "[Shira, Knight of Filianore] Crucifix of the Mad King 50006939")]
        ShiraKnightOfFilianoreCrucifixOfTheMadKing = 50006939,

        [AnnotationAttribute(Name = "[Unk] White Birch Bow 50006940")]
        UnkWhiteBirchBow = 50006940,

        [AnnotationAttribute(Name = "[Desert Pyromancer Zoey] Flame Fan 50006950")]
        DesertPyromancerZoeyFlameFan = 50006950,

        [AnnotationAttribute(Name = "[Silver Knight Ledo] Ledo's Great Hammer 50006960")]
        SilverKnightLedoLedosGreatHammer = 50006960,

        [AnnotationAttribute(Name = "[Alva, Seeker of the Spurned] Wolf Ring+3 50006970")]
        AlvaSeekerOfTheSpurnedWolfRing3 = 50006970,

        [AnnotationAttribute(Name = "[Moaning Knight] Blindfold Mask 50006980")]
        MoaningKnightBlindfoldMask = 50006980,

        [AnnotationAttribute(Name = "[Untended Graves] Eyes of a Fire Keeper 50006020")]
        UntendedGravesEyesOfaFireKeeper = 50006020,

        [AnnotationAttribute(Name = "[Yuria of Londor] Morion Blade 50006040")]
        YuriaOfLondorMorionBlade = 50006040,

        [AnnotationAttribute(Name = "[Yuria of Londor] Billed Mask - Lord of Hollow reward 50006042")]
        YuriaOfLondorBilledMaskLordOfHollowreward = 50006042,

        [AnnotationAttribute(Name = "Kukri 50006063")]
        Kukri_ = 50006063,

        [AnnotationAttribute(Name = "[Archdragon Peak] Twinkling Dragon Torso Stone - Pray at Altar 50006071")]
        ArchdragonPeakTwinklingDragonTorsoStonePrayatAltar = 50006071,

        [AnnotationAttribute(Name = "[Hawkwood] Twinkling Dragon Head Stone 50006072")]
        HawkwoodTwinklingDragonHeadStone = 50006072,

        [AnnotationAttribute(Name = "[Hawkwood] Farron Ring 50006073")]
        HawkwoodFarronRing = 50006073,

        [AnnotationAttribute(Name = "[Hawkwood] Hawkwood's Shield 50006074")]
        HawkwoodHawkwoodsShield = 50006074,

        [AnnotationAttribute(Name = "[Sirris of the Sunless Realms] Blessed Mail Breaker 50006080")]
        SirrisOfTheSunlessRealmsBlessedMailBreaker = 50006080,

        [AnnotationAttribute(Name = "[Sirris of the Sunless Realms] Sunset Shield 50006081")]
        SirrisOfTheSunlessRealmsSunsetShield = 50006081,

        [AnnotationAttribute(Name = "[Sirris of the Sunless Realms] Sunset Helm 50006083")]
        SirrisOfTheSunlessRealmsSunsetHelm = 50006083,

        [AnnotationAttribute(Name = "[Ringfinger Leonhard] Black Eye Orb 50006092")]
        RingfingerLeonhardBlackEyeOrb = 50006092,

        [AnnotationAttribute(Name = "[Ringfinger Leonhard] Red Eye Orb 6780")]
        RingfingerLeonhardRedEyeOrb = 6780,

        [AnnotationAttribute(Name = "[Andre] Hawkwood's Swordgrass 50006100")]
        AndreHawkwoodsSwordgrass = 50006100,

        [AnnotationAttribute(Name = "[Orbeck of Vinheim] Young Dragon Ring 50006130")]
        OrbeckOfVinheimYoungDragonRing = 50006130,

        [AnnotationAttribute(Name = "[Orbeck of Vinheim] Slumbering Dragoncrest Ring 50006131")]
        OrbeckOfVinheimSlumberingDragoncrestRing = 50006131,

        [AnnotationAttribute(Name = "[Undead Settlement] Saint's Talisman 50006161")]
        UndeadSettlementSaintsTalisman = 50006161,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Deep Braille Divine Tome - Mimic drop 50006162")]
        CathedralOfTheDeepDeepBrailleDivineTomeMimicdrop = 50006162,

        [AnnotationAttribute(Name = "[Yuria of Londor] Londor Braille Divine Tome 50006163")]
        YuriaOfLondorLondorBrailleDivineTome = 50006163,

        [AnnotationAttribute(Name = "[Yoel of Londor] Dark Sigil 50006193")]
        YoelOfLondorDarkSigil = 50006193,

        [AnnotationAttribute(Name = "Rusted Coin 50006200")]
        RustedCoin = 50006200,

        [AnnotationAttribute(Name = "Rusted Gold Coin 50006201")]
        RustedGoldCoin = 50006201,

        [AnnotationAttribute(Name = "[Siegward of Catarina] Siegbräu 50006210")]
        SiegwardOfCatarinaSiegbräu = 50006210,

        [AnnotationAttribute(Name = "[Siegward of Catarina] Siegbräu 50006211")]
        SiegwardOfCatarinaSiegbräu_ = 50006211,

        [AnnotationAttribute(Name = "[Siegward of Catarina] Siegbräu 50006212")]
        SiegwardOfCatarinaSiegbräu__ = 50006212,

        [AnnotationAttribute(Name = "[Siegward of Catarina] Kukri 50006213")]
        SiegwardOfCatarinaKukri = 50006213,

        [AnnotationAttribute(Name = "[Siegward of Catarina] Emit Force 50006214")]
        SiegwardOfCatarinaEmitForce = 50006214,

        [AnnotationAttribute(Name = "[Siegward of Catarina] Storm Ruler 50006216")]
        SiegwardOfCatarinaStormRuler = 50006216,

        [AnnotationAttribute(Name = "[Giant] Young White Branch 50006250")]
        GiantYoungWhiteBranch = 50006250,

        [AnnotationAttribute(Name = "[Amnesiac Lapp] Lapp's Helm 50006624")]
        AmnesiacLappLappsHelm = 50006624,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Estus Shard 53000000")]
        HighWallOfLothricEstusShard = 53000000,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Green Blossom 53000010")]
        HighWallOfLothricGreenBlossom = 53000010,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Gold Pine Resin 53000020")]
        HighWallOfLothricGoldPineResin = 53000020,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Large Soul of a Deserted Corpse 53000030")]
        HighWallOfLothricLargeSoulOfaDesertedCorpse = 53000030,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Soul of a Deserted Corpse 53000040")]
        HighWallOfLothricSoulOfaDesertedCorpse = 53000040,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Longbow 53000060")]
        HighWallOfLothricLongbow = 53000060,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Firebomb 53000070")]
        HighWallOfLothricFirebomb = 53000070,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Throwing Knife 53000090")]
        HighWallOfLothricThrowingKnife = 53000090,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Soul of a Deserted Corpse 53000110")]
        HighWallOfLothricSoulOfaDesertedCorpse_ = 53000110,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Club 53000120")]
        HighWallOfLothricClub = 53000120,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Claymore 53000130")]
        HighWallOfLothricClaymore = 53000130,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Ember 53000140")]
        HighWallOfLothricEmber = 53000140,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Firebomb 53000150")]
        HighWallOfLothricFirebomb_ = 53000150,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Titanite Shard 53000160")]
        HighWallOfLothricTitaniteShard = 53000160,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Undead Hunter Charm 53000170")]
        HighWallOfLothricUndeadHunterCharm = 53000170,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Firebomb 53000180")]
        HighWallOfLothricFirebomb__ = 53000180,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Cell Key 53000210")]
        HighWallOfLothricCellKey = 53000210,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Ember 53000230")]
        HighWallOfLothricEmber_ = 53000230,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Soul of a Deserted Corpse 53000240")]
        HighWallOfLothricSoulOfaDesertedCorpse__ = 53000240,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Lucerne 53000250")]
        HighWallOfLothricLucerne = 53000250,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Mail Breaker 53000270")]
        HighWallOfLothricMailBreaker = 53000270,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Titanite Shard 53000280")]
        HighWallOfLothricTitaniteShard_ = 53000280,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Rapier 53000290")]
        HighWallOfLothricRapier = 53000290,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Titanite Shard 53000300")]
        HighWallOfLothricTitaniteShard__ = 53000300,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Large Soul of a Deserted Corpse 53000310")]
        HighWallOfLothricLargeSoulOfaDesertedCorpse_ = 53000310,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Black Firebomb 53000320")]
        HighWallOfLothricBlackFirebomb = 53000320,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Soul of a Deserted Corpse 53000340")]
        HighWallOfLothricSoulOfaDesertedCorpse___ = 53000340,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Ember 53000360")]
        HighWallOfLothricEmber__ = 53000360,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Large Soul of a Deserted Corpse 53000370")]
        HighWallOfLothricLargeSoulOfaDesertedCorpse__ = 53000370,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Binoculars 53000380")]
        HighWallOfLothricBinoculars = 53000380,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Ring of Sacrifice 53000390")]
        HighWallOfLothricRingOfSacrifice = 53000390,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Throwing Knife 53000400")]
        HighWallOfLothricThrowingKnife_ = 53000400,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Soul of a Deserted Corpse 53000410")]
        HighWallOfLothricSoulOfaDesertedCorpse____ = 53000410,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Green Blossom 53000420")]
        HighWallOfLothricGreenBlossom_ = 53000420,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Shadow Mask 53000430")]
        ConsumedKingsGardenShadowMask = 53000430,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Broadsword 53000440")]
        HighWallOfLothricBroadsword = 53000440,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Soul of a Deserted Corpse 53000450")]
        HighWallOfLothricSoulOfaDesertedCorpse_____ = 53000450,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Black Firebomb 53000470")]
        HighWallOfLothricBlackFirebomb_ = 53000470,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Claw 53000480")]
        ConsumedKingsGardenClaw = 53000480,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Large Titanite Shard 53000490")]
        ConsumedKingsGardenLargeTitaniteShard = 53000490,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Dragonscale Ring 53000500")]
        ConsumedKingsGardenDragonscaleRing = 53000500,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Human Pine Resin 53000510")]
        ConsumedKingsGardenHumanPineResin = 53000510,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Titanite Chunk 53000520")]
        ConsumedKingsGardenTitaniteChunk = 53000520,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Titanite Chunk 53000530")]
        ConsumedKingsGardenTitaniteChunk_ = 53000530,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Soul of a Weary Warrior 53000540")]
        ConsumedKingsGardenSoulOfaWearyWarrior = 53000540,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Dark Gem 53000550")]
        ConsumedKingsGardenDarkGem = 53000550,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Refined Gem 53000570")]
        ConsumedKingsGardenRefinedGem = 53000570,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Firebomb 53000580")]
        ConsumedKingsGardenFirebomb = 53000580,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Soul of a Deserted Corpse 53000610")]
        ConsumedKingsGardenSoulOfaDesertedCorpse = 53000610,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Human Pine Resin 53000620")]
        ConsumedKingsGardenHumanPineResin_ = 53000620,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Titanite Chunk 53000630")]
        ConsumedKingsGardenTitaniteChunk__ = 53000630,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Ring of Sacrifice 53000640")]
        ConsumedKingsGardenRingOfSacrifice = 53000640,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Estus Shard 53000650")]
        HighWallOfLothricEstusShard_ = 53000650,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Fleshbite Ring+1 53000700")]
        HighWallOfLothricFleshbiteRing1 = 53000700,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Wood Grain Ring+1 53000710")]
        HighWallOfLothricWoodGrainRing1 = 53000710,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Ring of the Evil Eye+2 53000720")]
        HighWallOfLothricRingOfTheEvilEye2 = 53000720,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Sage Ring+2 53000730")]
        ConsumedKingsGardenSageRing2 = 53000730,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Titanite Scale 53000800")]
        ConsumedKingsGardenTitaniteScale = 53000800,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Silver Eagle Kite Shield 53000820")]
        HighWallOfLothricSilverEagleKiteShield = 53000820,

        [AnnotationAttribute(Name = "[High Wall of Lothric] Astora Straight Sword 53000830")]
        HighWallOfLothricAstoraStraightSword = 53000830,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Titanite Scale 53000840")]
        ConsumedKingsGardenTitaniteScale_ = 53000840,

        [AnnotationAttribute(Name = "[Consumed King's Garden] Drakeblood Helm 53000950")]
        ConsumedKingsGardenDrakebloodHelm = 53000950,

        [AnnotationAttribute(Name = "[Lothric Castle] Sniper Crossbow 53010000")]
        LothricCastleSniperCrossbow = 53010000,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Scale 53010010")]
        LothricCastleTitaniteScale = 53010010,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Chunk 53010020")]
        LothricCastleTitaniteChunk = 53010020,

        [AnnotationAttribute(Name = "[Lothric Castle] Greatlance 53010030")]
        LothricCastleGreatlance = 53010030,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Chunk 53010040")]
        LothricCastleTitaniteChunk_ = 53010040,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Chunk 53010050")]
        LothricCastleTitaniteChunk__ = 53010050,

        [AnnotationAttribute(Name = "[Lothric Castle] Sacred Bloom Shield 53010060")]
        LothricCastleSacredBloomShield = 53010060,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Chunk 53010070")]
        LothricCastleTitaniteChunk___ = 53010070,

        [AnnotationAttribute(Name = "[Lothric Castle] Refined Gem 53010080")]
        LothricCastleRefinedGem = 53010080,

        [AnnotationAttribute(Name = "[Lothric Castle] Soul of a Crestfallen Knight 53010090")]
        LothricCastleSoulOfaCrestfallenKnight = 53010090,

        [AnnotationAttribute(Name = "[Lothric Castle] Undead Bone Shard 53010100")]
        LothricCastleUndeadBoneShard = 53010100,

        [AnnotationAttribute(Name = "[Lothric Castle] Lightning Urn 53010110")]
        LothricCastleLightningUrn = 53010110,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Chunk 53010120")]
        LothricCastleTitaniteChunk____ = 53010120,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Chunk 53010130")]
        LothricCastleTitaniteChunk_____ = 53010130,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Chunk 53010140")]
        LothricCastleTitaniteChunk______ = 53010140,

        [AnnotationAttribute(Name = "[Grand Archives] Caitha's Chime 53010150")]
        GrandArchivesCaithasChime = 53010150,

        [AnnotationAttribute(Name = "[Lothric Castle] Lightning Urn 53010160")]
        LothricCastleLightningUrn_ = 53010160,

        [AnnotationAttribute(Name = "[Lothric Castle] Ember 53010170")]
        LothricCastleEmber = 53010170,

        [AnnotationAttribute(Name = "[Lothric Castle] Raw Gem 53010180")]
        LothricCastleRawGem = 53010180,

        [AnnotationAttribute(Name = "[Lothric Castle] Black Firebomb 53010190")]
        LothricCastleBlackFirebomb = 53010190,

        [AnnotationAttribute(Name = "[Lothric Castle] Pale Pine Resin 53010200")]
        LothricCastlePalePineResin = 53010200,

        [AnnotationAttribute(Name = "[Lothric Castle] Large Soul of a Weary Warrior 53010210")]
        LothricCastleLargeSoulOfaWearyWarrior = 53010210,

        [AnnotationAttribute(Name = "[Lothric Castle] Sunlight Medal 53010220")]
        LothricCastleSunlightMedal = 53010220,

        [AnnotationAttribute(Name = "[Lothric Castle] Soul of a Crestfallen Knight 53010230")]
        LothricCastleSoulOfaCrestfallenKnight_ = 53010230,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Chunk 53010240")]
        LothricCastleTitaniteChunk_______ = 53010240,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Scale 53010250")]
        LothricCastleTitaniteScale_ = 53010250,

        [AnnotationAttribute(Name = "[Lothric Castle] Large Soul of a Nameless Soldier 53010260")]
        LothricCastleLargeSoulOfaNamelessSoldier = 53010260,

        [AnnotationAttribute(Name = "[Lothric Castle] Knight's Ring 53010270")]
        LothricCastleKnightsRing = 53010270,

        [AnnotationAttribute(Name = "[Lothric Castle] Ember 53010280")]
        LothricCastleEmber_ = 53010280,

        [AnnotationAttribute(Name = "[Lothric Castle] Large Soul of a Weary Warrior 53010290")]
        LothricCastleLargeSoulOfaWearyWarrior_ = 53010290,

        [AnnotationAttribute(Name = "[Lothric Castle] Ember 53010300")]
        LothricCastleEmber__ = 53010300,

        [AnnotationAttribute(Name = "[Lothric Castle] Twinkling Titanite 53010310")]
        LothricCastleTwinklingTitanite = 53010310,

        [AnnotationAttribute(Name = "[Lothric Castle] Large Soul of a Nameless Soldier 53010320")]
        LothricCastleLargeSoulOfaNamelessSoldier_ = 53010320,

        [AnnotationAttribute(Name = "[Lothric Castle] Ember 53010330")]
        LothricCastleEmber___ = 53010330,

        [AnnotationAttribute(Name = "[Lothric Castle] Winged Knight Helm 53010340")]
        LothricCastleWingedKnightHelm = 53010340,

        [AnnotationAttribute(Name = "[Lothric Castle] Rusted Coin 53010350")]
        LothricCastleRustedCoin = 53010350,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Slab 53010360")]
        LothricCastleTitaniteSlab = 53010360,

        [AnnotationAttribute(Name = "[Lothric Castle] Braille Divine Tome of Lothric 53010370")]
        LothricCastleBrailleDivineTomeOfLothric = 53010370,

        [AnnotationAttribute(Name = "[Lothric Castle] Red Tearstone Ring 53010380")]
        LothricCastleRedTearstoneRing = 53010380,

        [AnnotationAttribute(Name = "[Lothric Castle] Twinkling Titanite 53010400")]
        LothricCastleTwinklingTitanite_ = 53010400,

        [AnnotationAttribute(Name = "[Lothric Castle] Large Soul of a Nameless Soldier 53010420")]
        LothricCastleLargeSoulOfaNamelessSoldier__ = 53010420,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Scale 53010500")]
        LothricCastleTitaniteScale__ = 53010500,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Scale 53010520")]
        LothricCastleTitaniteScale___ = 53010520,

        [AnnotationAttribute(Name = "[Lothric Castle] Hood of Prayer 53010530")]
        LothricCastleHoodOfPrayer = 53010530,

        [AnnotationAttribute(Name = "[Lothric Castle] Spirit Tree Crest Shield 53010600")]
        LothricCastleSpiritTreeCrestShield = 53010600,

        [AnnotationAttribute(Name = "[Lothric Castle] Titanite Scale 53010610")]
        LothricCastleTitaniteScale____ = 53010610,

        [AnnotationAttribute(Name = "[Lothric Castle] Twinkling Titanite 53010620")]
        LothricCastleTwinklingTitanite__ = 53010620,

        [AnnotationAttribute(Name = "[Lothric Castle] Twinkling Titanite 53010640")]
        LothricCastleTwinklingTitanite___ = 53010640,

        [AnnotationAttribute(Name = "[Lothric Castle] Life Ring+2 53010700")]
        LothricCastleLifeRing2 = 53010700,

        [AnnotationAttribute(Name = "[Lothric Castle] Dark Stoneplate Ring+1 53010710")]
        LothricCastleDarkStoneplateRing1 = 53010710,

        [AnnotationAttribute(Name = "[Lothric Castle] Thunder Stoneplate Ring+2 53010720")]
        LothricCastleThunderStoneplateRing2 = 53010720,

        [AnnotationAttribute(Name = "[Undead Settlement] Flynn's Ring 53100000")]
        UndeadSettlementFlynnsRing = 53100000,

        [AnnotationAttribute(Name = "[Undead Settlement] Undead Bone Shard 53100010")]
        UndeadSettlementUndeadBoneShard = 53100010,

        [AnnotationAttribute(Name = "[Undead Settlement] Alluring Skull 53100020")]
        UndeadSettlementAlluringSkull = 53100020,

        [AnnotationAttribute(Name = "[Undead Settlement] Mortician's Ashes 53100030")]
        UndeadSettlementMorticiansAshes = 53100030,

        [AnnotationAttribute(Name = "[Undead Settlement] Homeward Bone 53100040")]
        UndeadSettlementHomewardBone = 53100040,

        [AnnotationAttribute(Name = "[Undead Settlement] Caduceus Round Shield 53100050")]
        UndeadSettlementCaduceusRoundShield = 53100050,

        [AnnotationAttribute(Name = "[Undead Settlement] Ember 53100060")]
        UndeadSettlementEmber = 53100060,

        [AnnotationAttribute(Name = "[Undead Settlement] Soul of an Unknown Traveler 53100070")]
        UndeadSettlementSoulOfanUnknownTraveler = 53100070,

        [AnnotationAttribute(Name = "[Undead Settlement] Repair Powder 53100080")]
        UndeadSettlementRepairPowder = 53100080,

        [AnnotationAttribute(Name = "[Undead Settlement] Homeward Bone 53100090")]
        UndeadSettlementHomewardBone_ = 53100090,

        [AnnotationAttribute(Name = "[Undead Settlement] Spotted Whip 53100100")]
        UndeadSettlementSpottedWhip = 53100100,

        [AnnotationAttribute(Name = "[Undead Settlement] Titanite Shard 53100110")]
        UndeadSettlementTitaniteShard = 53100110,

        [AnnotationAttribute(Name = "[Undead Settlement] Wargod Wooden Shield 53100120")]
        UndeadSettlementWargodWoodenShield = 53100120,

        [AnnotationAttribute(Name = "[Undead Settlement] Large Soul of a Deserted Corpse 53100130")]
        UndeadSettlementLargeSoulOfaDesertedCorpse = 53100130,

        [AnnotationAttribute(Name = "[Undead Settlement] Ember 53100140")]
        UndeadSettlementEmber_ = 53100140,

        [AnnotationAttribute(Name = "[Undead Settlement] Large Soul of a Deserted Corpse 53100150")]
        UndeadSettlementLargeSoulOfaDesertedCorpse_ = 53100150,

        [AnnotationAttribute(Name = "[Undead Settlement] Titanite Shard 53100160")]
        UndeadSettlementTitaniteShard_ = 53100160,

        [AnnotationAttribute(Name = "[Undead Settlement] Alluring Skull 53100170")]
        UndeadSettlementAlluringSkull_ = 53100170,

        [AnnotationAttribute(Name = "[Undead Settlement] Charcoal Pine Bundle 53100180")]
        UndeadSettlementCharcoalPineBundle = 53100180,

        [AnnotationAttribute(Name = "[Undead Settlement] Blue Wooden Shield 53100190")]
        UndeadSettlementBlueWoodenShield = 53100190,

        [AnnotationAttribute(Name = "[Undead Settlement] Soul of an Unknown Traveler 53100200")]
        UndeadSettlementSoulOfanUnknownTraveler_ = 53100200,

        [AnnotationAttribute(Name = "[Undead Settlement] Charcoal Pine Resin 53100210")]
        UndeadSettlementCharcoalPineResin = 53100210,

        [AnnotationAttribute(Name = "[Undead Settlement] Loincloth 53100220")]
        UndeadSettlementLoincloth = 53100220,

        [AnnotationAttribute(Name = "[Undead Settlement] Charcoal Pine Bundle 53100230")]
        UndeadSettlementCharcoalPineBundle_ = 53100230,

        [AnnotationAttribute(Name = "[Undead Settlement] Soul of an Unknown Traveler 53100240")]
        UndeadSettlementSoulOfanUnknownTraveler__ = 53100240,

        [AnnotationAttribute(Name = "[Undead Settlement] Titanite Shard 53100250")]
        UndeadSettlementTitaniteShard__ = 53100250,

        [AnnotationAttribute(Name = "[Undead Settlement] Red Hilted Halberd 53100260")]
        UndeadSettlementRedHiltedHalberd = 53100260,

        [AnnotationAttribute(Name = "[Undead Settlement] Rusted Coin 53100270")]
        UndeadSettlementRustedCoin = 53100270,

        [AnnotationAttribute(Name = "[Undead Settlement] Caestus 53100280")]
        UndeadSettlementCaestus = 53100280,

        [AnnotationAttribute(Name = "[Undead Settlement] Saint's Talisman 53100300")]
        UndeadSettlementSaintsTalisman_ = 53100300,

        [AnnotationAttribute(Name = "[Undead Settlement] Alluring Skull 53100310")]
        UndeadSettlementAlluringSkull__ = 53100310,

        [AnnotationAttribute(Name = "[Undead Settlement] Large Club 53100320")]
        UndeadSettlementLargeClub = 53100320,

        [AnnotationAttribute(Name = "[Undead Settlement] Titanite Shard 53100330")]
        UndeadSettlementTitaniteShard___ = 53100330,

        [AnnotationAttribute(Name = "[Undead Settlement] Titanite Shard 53100340")]
        UndeadSettlementTitaniteShard____ = 53100340,

        [AnnotationAttribute(Name = "[Undead Settlement] Fading Soul 53100350")]
        UndeadSettlementFadingSoul = 53100350,

        [AnnotationAttribute(Name = "[Undead Settlement] Titanite Shard 53100360")]
        UndeadSettlementTitaniteShard_____ = 53100360,

        [AnnotationAttribute(Name = "[Undead Settlement] Hand Axe 53100370")]
        UndeadSettlementHandAxe = 53100370,

        [AnnotationAttribute(Name = "[Undead Settlement] Soul of an Unknown Traveler 53100380")]
        UndeadSettlementSoulOfanUnknownTraveler___ = 53100380,

        [AnnotationAttribute(Name = "[Undead Settlement] Ember 53100390")]
        UndeadSettlementEmber__ = 53100390,

        [AnnotationAttribute(Name = "[Undead Settlement] Mirrah Vest 53100400")]
        UndeadSettlementMirrahVest = 53100400,

        [AnnotationAttribute(Name = "[Undead Settlement] Plank Shield 53100410")]
        UndeadSettlementPlankShield = 53100410,

        [AnnotationAttribute(Name = "[Undead Settlement] Red Bug Pellet 53100420")]
        UndeadSettlementRedBugPellet = 53100420,

        [AnnotationAttribute(Name = "[Undead Settlement] Chloranthy Ring 53100430")]
        UndeadSettlementChloranthyRing = 53100430,

        [AnnotationAttribute(Name = "[Undead Settlement] Fire Clutch Ring 53100440")]
        UndeadSettlementFireClutchRing = 53100440,

        [AnnotationAttribute(Name = "[Undead Settlement] Estus Shard 53100450")]
        UndeadSettlementEstusShard = 53100450,

        [AnnotationAttribute(Name = "[Undead Settlement] Firebomb 53100460")]
        UndeadSettlementFirebomb = 53100460,

        [AnnotationAttribute(Name = "[Undead Settlement] Whip 53100490")]
        UndeadSettlementWhip = 53100490,

        [AnnotationAttribute(Name = "[Undead Settlement] Great Scythe 53100500")]
        UndeadSettlementGreatScythe = 53100500,

        [AnnotationAttribute(Name = "[Undead Settlement] Homeward Bone 53100540")]
        UndeadSettlementHomewardBone__ = 53100540,

        [AnnotationAttribute(Name = "[Undead Settlement] Large Soul of a Deserted Corpse 53100550")]
        UndeadSettlementLargeSoulOfaDesertedCorpse__ = 53100550,

        [AnnotationAttribute(Name = "[Undead Settlement] Ember 53100570")]
        UndeadSettlementEmber___ = 53100570,

        [AnnotationAttribute(Name = "[Undead Settlement] Large Soul of a Deserted Corpse 53100610")]
        UndeadSettlementLargeSoulOfaDesertedCorpse___ = 53100610,

        [AnnotationAttribute(Name = "[Undead Settlement] Fading Soul 53100620")]
        UndeadSettlementFadingSoul_ = 53100620,

        [AnnotationAttribute(Name = "[Undead Settlement] Young White Branch 53100630")]
        UndeadSettlementYoungWhiteBranch = 53100630,

        [AnnotationAttribute(Name = "[Undead Settlement] Ember 53100640")]
        UndeadSettlementEmber____ = 53100640,

        [AnnotationAttribute(Name = "[Undead Settlement] Large Soul of a Deserted Corpse 53100650")]
        UndeadSettlementLargeSoulOfaDesertedCorpse____ = 53100650,

        [AnnotationAttribute(Name = "[Undead Settlement] Young White Branch 53100660")]
        UndeadSettlementYoungWhiteBranch_ = 53100660,

        [AnnotationAttribute(Name = "[Undead Settlement] Reinforced Club 53100670")]
        UndeadSettlementReinforcedClub = 53100670,

        [AnnotationAttribute(Name = "[Undead Settlement] Soul of a Nameless Soldier 53100680")]
        UndeadSettlementSoulOfaNamelessSoldier = 53100680,

        [AnnotationAttribute(Name = "[Undead Settlement] Loretta's Bone 53100700")]
        UndeadSettlementLorettasBone = 53100700,

        [AnnotationAttribute(Name = "[Undead Settlement] Northern Helm 53100710")]
        UndeadSettlementNorthernHelm = 53100710,

        [AnnotationAttribute(Name = "[Undead Settlement] Partizan 53100720")]
        UndeadSettlementPartizan = 53100720,

        [AnnotationAttribute(Name = "[Undead Settlement] Flame Stoneplate Ring 53100730")]
        UndeadSettlementFlameStoneplateRing = 53100730,

        [AnnotationAttribute(Name = "[Undead Settlement] Red and White Round Shield 53100740")]
        UndeadSettlementRedandWhiteRoundShield = 53100740,

        [AnnotationAttribute(Name = "[Undead Settlement] Small Leather Shield 53100750")]
        UndeadSettlementSmallLeatherShield = 53100750,

        [AnnotationAttribute(Name = "[Undead Settlement] Pale Tongue 53100760")]
        UndeadSettlementPaleTongue = 53100760,

        [AnnotationAttribute(Name = "[Undead Settlement] Large Soul of a Deserted Corpse 53100770")]
        UndeadSettlementLargeSoulOfaDesertedCorpse_____ = 53100770,

        [AnnotationAttribute(Name = "[Undead Settlement] Kukri 53100800")]
        UndeadSettlementKukri = 53100800,

        [AnnotationAttribute(Name = "[Undead Settlement] Life Ring+1 53100850")]
        UndeadSettlementLifeRing1 = 53100850,

        [AnnotationAttribute(Name = "[Undead Settlement] Poisonbite Ring+1 53100860")]
        UndeadSettlementPoisonbiteRing1 = 53100860,

        [AnnotationAttribute(Name = "[Undead Settlement] Covetous Silver Serpent Ring+2 53100870")]
        UndeadSettlementCovetousSilverSerpentRing2 = 53100870,

        [AnnotationAttribute(Name = "[Undead Settlement] Human Pine Resin 53100910")]
        UndeadSettlementHumanPineResin = 53100910,

        [AnnotationAttribute(Name = "[Undead Settlement] Homeward Bone 53100950")]
        UndeadSettlementHomewardBone___ = 53100950,

        [AnnotationAttribute(Name = "[Archdragon Peak] Lightning Clutch Ring 53200000")]
        ArchdragonPeakLightningClutchRing = 53200000,

        [AnnotationAttribute(Name = "[Archdragon Peak] Stalk Dung Pie 53200010")]
        ArchdragonPeakStalkDungPie = 53200010,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Chunk 53200020")]
        ArchdragonPeakTitaniteChunk = 53200020,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Scale 53200030")]
        ArchdragonPeakTitaniteScale = 53200030,

        [AnnotationAttribute(Name = "[Archdragon Peak] Soul of a Weary Warrior 53200040")]
        ArchdragonPeakSoulOfaWearyWarrior = 53200040,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Chunk 53200050")]
        ArchdragonPeakTitaniteChunk_ = 53200050,

        [AnnotationAttribute(Name = "[Archdragon Peak] Lightning Gem 53200060")]
        ArchdragonPeakLightningGem = 53200060,

        [AnnotationAttribute(Name = "[Archdragon Peak] Homeward Bone 53200070")]
        ArchdragonPeakHomewardBone = 53200070,

        [AnnotationAttribute(Name = "[Archdragon Peak] Soul of a Nameless Soldier 53200080")]
        ArchdragonPeakSoulOfaNamelessSoldier = 53200080,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Chunk 53200090")]
        ArchdragonPeakTitaniteChunk__ = 53200090,

        [AnnotationAttribute(Name = "[Archdragon Peak] Ember 53200100")]
        ArchdragonPeakEmber = 53200100,

        [AnnotationAttribute(Name = "[Archdragon Peak] Large Soul of a Weary Warrior 53200110")]
        ArchdragonPeakLargeSoulOfaWearyWarrior = 53200110,

        [AnnotationAttribute(Name = "[Archdragon Peak] Large Soul of a Nameless Soldier 53200120")]
        ArchdragonPeakLargeSoulOfaNamelessSoldier = 53200120,

        [AnnotationAttribute(Name = "[Archdragon Peak] Lightning Urn 53200130")]
        ArchdragonPeakLightningUrn = 53200130,

        [AnnotationAttribute(Name = "[Archdragon Peak] Lightning Bolt 53200140")]
        ArchdragonPeakLightningBolt = 53200140,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Chunk 53200150")]
        ArchdragonPeakTitaniteChunk___ = 53200150,

        [AnnotationAttribute(Name = "[Archdragon Peak] Dung Pie 53200160")]
        ArchdragonPeakDungPie = 53200160,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Scale 53200170")]
        ArchdragonPeakTitaniteScale_ = 53200170,

        [AnnotationAttribute(Name = "[Archdragon Peak] Soul of a Weary Warrior 53200180")]
        ArchdragonPeakSoulOfaWearyWarrior_ = 53200180,

        [AnnotationAttribute(Name = "[Archdragon Peak] Soul of a Crestfallen Knight 53200190")]
        ArchdragonPeakSoulOfaCrestfallenKnight = 53200190,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Chunk 53200200")]
        ArchdragonPeakTitaniteChunk____ = 53200200,

        [AnnotationAttribute(Name = "[Archdragon Peak] Ember 53200210")]
        ArchdragonPeakEmber_ = 53200210,

        [AnnotationAttribute(Name = "[Archdragon Peak] Thunder Stoneplate Ring 53200220")]
        ArchdragonPeakThunderStoneplateRing = 53200220,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Scale 53200230")]
        ArchdragonPeakTitaniteScale__ = 53200230,

        [AnnotationAttribute(Name = "[Archdragon Peak] Ember 53200240")]
        ArchdragonPeakEmber__ = 53200240,

        [AnnotationAttribute(Name = "[Archdragon Peak] Ancient Dragon Greatshield 53200260")]
        ArchdragonPeakAncientDragonGreatshield = 53200260,

        [AnnotationAttribute(Name = "[Archdragon Peak] Large Soul of a Crestfallen Knight 53200270")]
        ArchdragonPeakLargeSoulOfaCrestfallenKnight = 53200270,

        [AnnotationAttribute(Name = "[Archdragon Peak] Dragon Chaser's Ashes 53200280")]
        ArchdragonPeakDragonChasersAshes = 53200280,

        [AnnotationAttribute(Name = "[Archdragon Peak] Ember 53200290")]
        ArchdragonPeakEmber___ = 53200290,

        [AnnotationAttribute(Name = "[Archdragon Peak] Dragonslayer Spear 53200300")]
        ArchdragonPeakDragonslayerSpear = 53200300,

        [AnnotationAttribute(Name = "[Archdragon Peak] Dragonslayer Helm 53200310")]
        ArchdragonPeakDragonslayerHelm = 53200310,

        [AnnotationAttribute(Name = "[Archdragon Peak] Twinkling Titanite 53200330")]
        ArchdragonPeakTwinklingTitanite = 53200330,

        [AnnotationAttribute(Name = "[Archdragon Peak] Twinkling Titanite 53200340")]
        ArchdragonPeakTwinklingTitanite_ = 53200340,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Slab 53200350")]
        ArchdragonPeakTitaniteSlab = 53200350,

        [AnnotationAttribute(Name = "[Archdragon Peak] Great Magic Barrier 53200360")]
        ArchdragonPeakGreatMagicBarrier = 53200360,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Slab 53200370")]
        ArchdragonPeakTitaniteSlab_ = 53200370,

        [AnnotationAttribute(Name = "[Archdragon Peak] Ring of Steel Protection 53200380")]
        ArchdragonPeakRingOfSteelProtection = 53200380,

        [AnnotationAttribute(Name = "[Archdragon Peak] Havel's Ring+1 53200500")]
        ArchdragonPeakHavelsRing1 = 53200500,

        [AnnotationAttribute(Name = "[Archdragon Peak] Covetous Gold Serpent Ring+2 53200510")]
        ArchdragonPeakCovetousGoldSerpentRing2 = 53200510,

        [AnnotationAttribute(Name = "[Archdragon Peak] Titanite Scale 53200700")]
        ArchdragonPeakTitaniteScale___ = 53200700,

        [AnnotationAttribute(Name = "[Archdragon Peak] Twinkling Titanite 53200710")]
        ArchdragonPeakTwinklingTitanite__ = 53200710,

        [AnnotationAttribute(Name = "[Archdragon Peak] Twinkling Dragon Torso Stone 53200900")]
        ArchdragonPeakTwinklingDragonTorsoStone = 53200900,

        [AnnotationAttribute(Name = "[Archdragon Peak] Calamity Ring 53200910")]
        ArchdragonPeakCalamityRing = 53200910,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300000")]
        RoadOfSacrificesTitaniteShard = 53300000,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300010")]
        RoadOfSacrificesTitaniteShard_ = 53300010,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Green Blossom 53300020")]
        RoadOfSacrificesGreenBlossom = 53300020,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Estus Shard 53300030")]
        RoadOfSacrificesEstusShard = 53300030,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Ring of Sacrifice 53300040")]
        RoadOfSacrificesRingOfSacrifice = 53300040,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Soul of an Unknown Traveler 53300050")]
        RoadOfSacrificesSoulOfanUnknownTraveler = 53300050,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Fallen Knight Helm 53300060")]
        RoadOfSacrificesFallenKnightHelm = 53300060,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Heretic's Staff 53300070")]
        RoadOfSacrificesHereticsStaff = 53300070,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Large Soul of an Unknown Traveler 53300080")]
        RoadOfSacrificesLargeSoulOfanUnknownTraveler = 53300080,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Conjurator Hood 53300090")]
        RoadOfSacrificesConjuratorHood = 53300090,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Soul of an Unknown Traveler 53300100")]
        RoadOfSacrificesSoulOfanUnknownTraveler_ = 53300100,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Green Blossom 53300110")]
        RoadOfSacrificesGreenBlossom_ = 53300110,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Great Swamp Pyromancy Tome 53300120")]
        RoadOfSacrificesGreatSwampPyromancyTome = 53300120,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Homeward Bone 53300130")]
        RoadOfSacrificesHomewardBone = 53300130,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300140")]
        RoadOfSacrificesTitaniteShard__ = 53300140,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Purple Moss Clump 53300150")]
        RoadOfSacrificesPurpleMossClump = 53300150,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Purple Moss Clump 53300160")]
        RoadOfSacrificesPurpleMossClump_ = 53300160,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Greatsword 53300170")]
        RoadOfSacrificesGreatsword = 53300170,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Twin Dragon Greatshield 53300180")]
        RoadOfSacrificesTwinDragonGreatshield = 53300180,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Hollow Gem 53300190")]
        RoadOfSacrificesHollowGem = 53300190,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Fading Soul 53300210")]
        RoadOfSacrificesFadingSoul = 53300210,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Sorcerer Hood 53300220")]
        RoadOfSacrificesSorcererHood = 53300220,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Sage Ring 53300230")]
        RoadOfSacrificesSageRing = 53300230,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Purple Moss Clump 53300240")]
        RoadOfSacrificesPurpleMossClump__ = 53300240,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Undead Bone Shard 53300270")]
        RoadOfSacrificesUndeadBoneShard = 53300270,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Atonement 53300280")]
        RoadOfSacrificesAtonement = 53300280,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300290")]
        RoadOfSacrificesTitaniteShard___ = 53300290,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Iron Flesh 53300300")]
        RoadOfSacrificesIronFlesh = 53300300,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Grass Crest Shield 53300310")]
        RoadOfSacrificesGrassCrestShield = 53300310,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Stone Parma 53300320")]
        RoadOfSacrificesStoneParma = 53300320,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Rotten Pine Resin 53300340")]
        RoadOfSacrificesRottenPineResin = 53300340,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300350")]
        RoadOfSacrificesTitaniteShard____ = 53300350,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Rusted Gold Coin 53300360")]
        RoadOfSacrificesRustedGoldCoin = 53300360,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Nameless Knight Helm 53300370")]
        RoadOfSacrificesNamelessKnightHelm = 53300370,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Shriving Stone 53300380")]
        RoadOfSacrificesShrivingStone = 53300380,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Repair Powder 53300390")]
        RoadOfSacrificesRepairPowder = 53300390,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Golden Scroll 53300400")]
        RoadOfSacrificesGoldenScroll = 53300400,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Sage's Scroll 53300410")]
        RoadOfSacrificesSagesScroll = 53300410,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Dreamchaser's Ashes 53300420")]
        RoadOfSacrificesDreamchasersAshes = 53300420,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300430")]
        RoadOfSacrificesTitaniteShard_____ = 53300430,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Wolf's Blood Swordgrass 53300440")]
        RoadOfSacrificesWolfsBloodSwordgrass = 53300440,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Great Magic Weapon 53300450")]
        RoadOfSacrificesGreatMagicWeapon = 53300450,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Ember 53300460")]
        RoadOfSacrificesEmber = 53300460,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300470")]
        RoadOfSacrificesTitaniteShard______ = 53300470,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300480")]
        RoadOfSacrificesTitaniteShard_______ = 53300480,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300490")]
        RoadOfSacrificesTitaniteShard________ = 53300490,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Black Bug Pellet 53300500")]
        RoadOfSacrificesBlackBugPellet = 53300500,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Rotten Pine Resin 53300510")]
        RoadOfSacrificesRottenPineResin_ = 53300510,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Poison Gem 53300520")]
        RoadOfSacrificesPoisonGem = 53300520,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Ragged Mask 53300525")]
        RoadOfSacrificesRaggedMask = 53300525,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Estus Shard 53300530")]
        RoadOfSacrificesEstusShard_ = 53300530,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Homeward Bone 53300535")]
        RoadOfSacrificesHomewardBone_ = 53300535,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300540")]
        RoadOfSacrificesTitaniteShard_________ = 53300540,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Large Soul of a Nameless Soldier 53300545")]
        RoadOfSacrificesLargeSoulOfaNamelessSoldier = 53300545,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Prism Stone 53300550")]
        RoadOfSacrificesPrismStone = 53300550,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Large Soul of a Nameless Soldier 53300555")]
        RoadOfSacrificesLargeSoulOfaNamelessSoldier_ = 53300555,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Ember 53300560")]
        RoadOfSacrificesEmber_ = 53300560,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Sage's Coal 53300570")]
        RoadOfSacrificesSagesCoal = 53300570,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Lightning Spear 53300580")]
        RoadOfSacrificesLightningSpear = 53300580,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Blue Bug Pellet 53300590")]
        RoadOfSacrificesBlueBugPellet = 53300590,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Soul of an Unknown Traveler 53300600")]
        RoadOfSacrificesSoulOfanUnknownTraveler__ = 53300600,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Shriving Stone 53300610")]
        RoadOfSacrificesShrivingStone_ = 53300610,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Titanite Shard 53300620")]
        RoadOfSacrificesTitaniteShard__________ = 53300620,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Brigand Twindaggers 53300630")]
        RoadOfSacrificesBrigandTwindaggers = 53300630,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Braille Divine Tome of Carim 53300640")]
        RoadOfSacrificesBrailleDivineTomeOfCarim = 53300640,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Ember 53300650")]
        RoadOfSacrificesEmber__ = 53300650,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Gold Pine Bundle 53300680")]
        RoadOfSacrificesGoldPineBundle = 53300680,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Ember 53300690")]
        RoadOfSacrificesEmber___ = 53300690,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Soul of a Nameless Soldier 53300700")]
        RoadOfSacrificesSoulOfaNamelessSoldier = 53300700,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Large Soul of an Unknown Traveler 53300710")]
        RoadOfSacrificesLargeSoulOfanUnknownTraveler_ = 53300710,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Sellsword Twinblades 53300720")]
        RoadOfSacrificesSellswordTwinblades = 53300720,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Golden Falcon Shield 53300730")]
        RoadOfSacrificesGoldenFalconShield = 53300730,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Herald Helm 53300740")]
        RoadOfSacrificesHeraldHelm = 53300740,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Brigand Axe 53300750")]
        RoadOfSacrificesBrigandAxe = 53300750,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Brigand Hood 53300760")]
        RoadOfSacrificesBrigandHood = 53300760,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Morne's Ring 53300770")]
        RoadOfSacrificesMornesRing = 53300770,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Sellsword Helm 53300780")]
        RoadOfSacrificesSellswordHelm = 53300780,

        [AnnotationAttribute(Name = "[Road of Sacrifices] Farron Coal 53300790")]
        RoadOfSacrificesFarronCoal = 53300790,

        [AnnotationAttribute(Name = "[Farron Keep] Havel's Helm 53300800")]
        FarronKeepHavelsHelm = 53300800,

        [AnnotationAttribute(Name = "[Farron Keep] Greataxe 53300810")]
        FarronKeepGreataxe = 53300810,

        [AnnotationAttribute(Name = "[Farron Keep] Speckled Stoneplate Ring 53300820")]
        FarronKeepSpeckledStoneplateRing = 53300820,

        [AnnotationAttribute(Name = "[Farron Keep] Ember 53300830")]
        FarronKeepEmber = 53300830,

        [AnnotationAttribute(Name = "[Farron Keep] Dragon Crest Shield 53300840")]
        FarronKeepDragonCrestShield = 53300840,

        [AnnotationAttribute(Name = "[Farron Keep] Dark Stoneplate Ring+2 53300850")]
        FarronKeepDarkStoneplateRing2 = 53300850,

        [AnnotationAttribute(Name = "[Farron Keep] Chloranthy Ring+2 53300860")]
        FarronKeepChloranthyRing2 = 53300860,

        [AnnotationAttribute(Name = "[Farron Keep] Lingering Dragoncrest Ring+1 53300870")]
        FarronKeepLingeringDragoncrestRing1 = 53300870,

        [AnnotationAttribute(Name = "[Farron Keep] Magic Stoneplate Ring+1 53300880")]
        FarronKeepMagicStoneplateRing1 = 53300880,

        [AnnotationAttribute(Name = "[Farron Keep] Wolf Ring+1 53300890")]
        FarronKeepWolfRing1 = 53300890,

        [AnnotationAttribute(Name = "[Farron Keep] Antiquated Dress 53300940")]
        FarronKeepAntiquatedDress = 53300940,

        [AnnotationAttribute(Name = "[Farron Keep] Sunlight Talisman 53300950")]
        FarronKeepSunlightTalisman = 53300950,

        [AnnotationAttribute(Name = "[Farron Keep] Young White Branch 53300960")]
        FarronKeepYoungWhiteBranch = 53300960,

        [AnnotationAttribute(Name = "[Farron Keep] Young White Branch 53300970")]
        FarronKeepYoungWhiteBranch_ = 53300970,

        [AnnotationAttribute(Name = "[Farron Keep] Crown of Dusk 53300980")]
        FarronKeepCrownOfDusk = 53300980,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Chunk 53410000")]
        GrandArchivesTitaniteChunk = 53410000,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Chunk 53410010")]
        GrandArchivesTitaniteChunk_ = 53410010,

        [AnnotationAttribute(Name = "[Grand Archives] Soul of a Crestfallen Knight 53410020")]
        GrandArchivesSoulOfaCrestfallenKnight = 53410020,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Chunk 53410030")]
        GrandArchivesTitaniteChunk__ = 53410030,

        [AnnotationAttribute(Name = "[Grand Archives] Fleshbite Ring 53410040")]
        GrandArchivesFleshbiteRing = 53410040,

        [AnnotationAttribute(Name = "[Grand Archives] Soul of a Crestfallen Knight 53410060")]
        GrandArchivesSoulOfaCrestfallenKnight_ = 53410060,

        [AnnotationAttribute(Name = "[Grand Archives] Soul of a Nameless Soldier 53410070")]
        GrandArchivesSoulOfaNamelessSoldier = 53410070,

        [AnnotationAttribute(Name = "[Grand Archives] Crystal Chime 53410080")]
        GrandArchivesCrystalChime = 53410080,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Scale 53410090")]
        GrandArchivesTitaniteScale = 53410090,

        [AnnotationAttribute(Name = "[Grand Archives] Estus Shard 53410100")]
        GrandArchivesEstusShard = 53410100,

        [AnnotationAttribute(Name = "[Grand Archives] Homeward Bone 53410110")]
        GrandArchivesHomewardBone = 53410110,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Scale 53410120")]
        GrandArchivesTitaniteScale_ = 53410120,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Chunk 53410130")]
        GrandArchivesTitaniteChunk___ = 53410130,

        [AnnotationAttribute(Name = "[Grand Archives] Hollow Gem 53410140")]
        GrandArchivesHollowGem = 53410140,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Scale 53410150")]
        GrandArchivesTitaniteScale__ = 53410150,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Scale 53410160")]
        GrandArchivesTitaniteScale___ = 53410160,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Scale 53410180")]
        GrandArchivesTitaniteScale____ = 53410180,

        [AnnotationAttribute(Name = "[Grand Archives] Shriving Stone 53410200")]
        GrandArchivesShrivingStone = 53410200,

        [AnnotationAttribute(Name = "[Grand Archives] Large Soul of a Crestfallen Knight 53410210")]
        GrandArchivesLargeSoulOfaCrestfallenKnight = 53410210,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Chunk 53410220")]
        GrandArchivesTitaniteChunk____ = 53410220,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Scale 53410240")]
        GrandArchivesTitaniteScale_____ = 53410240,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Chunk 53410250")]
        GrandArchivesTitaniteChunk_____ = 53410250,

        [AnnotationAttribute(Name = "[Grand Archives] Soul of a Weary Warrior 53410260")]
        GrandArchivesSoulOfaWearyWarrior = 53410260,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Chunk 53410280")]
        GrandArchivesTitaniteChunk______ = 53410280,

        [AnnotationAttribute(Name = "[Grand Archives] Ember 53410290")]
        GrandArchivesEmber = 53410290,

        [AnnotationAttribute(Name = "[Grand Archives] Blessed Gem 53410300")]
        GrandArchivesBlessedGem = 53410300,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Chunk 53410320")]
        GrandArchivesTitaniteChunk_______ = 53410320,

        [AnnotationAttribute(Name = "[Grand Archives] Large Soul of a Crestfallen Knight 53410330")]
        GrandArchivesLargeSoulOfaCrestfallenKnight_ = 53410330,

        [AnnotationAttribute(Name = "[Grand Archives] Avelyn 53410350")]
        GrandArchivesAvelyn = 53410350,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Chunk 53410360")]
        GrandArchivesTitaniteChunk________ = 53410360,

        [AnnotationAttribute(Name = "[Grand Archives] Hunter's Ring 53410370")]
        GrandArchivesHuntersRing = 53410370,

        [AnnotationAttribute(Name = "[Grand Archives] Divine Pillars of Light 53410380")]
        GrandArchivesDivinePillarsOfLight = 53410380,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Chunk 53410410")]
        GrandArchivesTitaniteChunk_________ = 53410410,

        [AnnotationAttribute(Name = "[Grand Archives] Power Within 53410420")]
        GrandArchivesPowerWithin = 53410420,

        [AnnotationAttribute(Name = "[Grand Archives] Sage Ring+1 53410450")]
        GrandArchivesSageRing1 = 53410450,

        [AnnotationAttribute(Name = "[Grand Archives] Lingering Dragoncrest Ring+2 53410470")]
        GrandArchivesLingeringDragoncrestRing2 = 53410470,

        [AnnotationAttribute(Name = "[Grand Archives] Divine Blessing 53410500")]
        GrandArchivesDivineBlessing = 53410500,

        [AnnotationAttribute(Name = "[Grand Archives] Twinkling Titanite 53410510")]
        GrandArchivesTwinklingTitanite = 53410510,

        [AnnotationAttribute(Name = "[Grand Archives] Witch's Locks 53410520")]
        GrandArchivesWitchsLocks = 53410520,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Slab 53410530")]
        GrandArchivesTitaniteSlab = 53410530,

        [AnnotationAttribute(Name = "[Grand Archives] Titanite Scale 53410540")]
        GrandArchivesTitaniteScale______ = 53410540,

        [AnnotationAttribute(Name = "[Grand Archives] Soul Stream 53410600")]
        GrandArchivesSoulStream = 53410600,

        [AnnotationAttribute(Name = "[Grand Archives] Scholar Ring 53410610")]
        GrandArchivesScholarRing = 53410610,

        [AnnotationAttribute(Name = "[Grand Archives] Undead Bone Shard 53410620")]
        GrandArchivesUndeadBoneShard = 53410620,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Notched Whip 53500000")]
        CathedralOfTheDeepNotchedWhip = 53500000,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Titanite Shard 53500010")]
        CathedralOfTheDeepTitaniteShard = 53500010,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Astora Greatsword 53500020")]
        CathedralOfTheDeepAstoraGreatsword = 53500020,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Executioner's Greatsword 53500030")]
        CathedralOfTheDeepExecutionersGreatsword = 53500030,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Undead Bone Shard 53500040")]
        CathedralOfTheDeepUndeadBoneShard = 53500040,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Curse Ward Greatshield 53500050")]
        CathedralOfTheDeepCurseWardGreatshield = 53500050,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Titanite Shard 53500060")]
        CathedralOfTheDeepTitaniteShard_ = 53500060,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Large Soul of an Unknown Traveler 53500070")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler = 53500070,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Paladin's Ashes 53500080")]
        CathedralOfTheDeepPaladinsAshes = 53500080,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Arbalest 53500090")]
        CathedralOfTheDeepArbalest = 53500090,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Ember 53500110")]
        CathedralOfTheDeepEmber = 53500110,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Ember 53500130")]
        CathedralOfTheDeepEmber_ = 53500130,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Poisonbite Ring 53500140")]
        CathedralOfTheDeepPoisonbiteRing = 53500140,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Drang Armor 53500150")]
        CathedralOfTheDeepDrangArmor = 53500150,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Ember 53500160")]
        CathedralOfTheDeepEmber__ = 53500160,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Duel Charm 53500170")]
        CathedralOfTheDeepDuelCharm = 53500170,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Seek Guidance 53500180")]
        CathedralOfTheDeepSeekGuidance = 53500180,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Estus Shard 53500200")]
        CathedralOfTheDeepEstusShard = 53500200,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Maiden Hood 53500210")]
        CathedralOfTheDeepMaidenHood = 53500210,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Pale Tongue 53500220")]
        CathedralOfTheDeepPaleTongue = 53500220,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Fading Soul 53500230")]
        CathedralOfTheDeepFadingSoul = 53500230,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Blessed Gem 53500240")]
        CathedralOfTheDeepBlessedGem = 53500240,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Red Bug Pellet 53500260")]
        CathedralOfTheDeepRedBugPellet = 53500260,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Soul of a Nameless Soldier 53500270")]
        CathedralOfTheDeepSoulOfaNamelessSoldier = 53500270,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Duel Charm 53500280")]
        CathedralOfTheDeepDuelCharm_ = 53500280,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Large Soul of an Unknown Traveler 53500300")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler_ = 53500300,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Ember 53500310")]
        CathedralOfTheDeepEmber___ = 53500310,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Repair Powder 53500320")]
        CathedralOfTheDeepRepairPowder = 53500320,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Large Soul of an Unknown Traveler 53500330")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler__ = 53500330,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Large Soul of an Unknown Traveler 53500340")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler___ = 53500340,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Undead Hunter Charm 53500370")]
        CathedralOfTheDeepUndeadHunterCharm = 53500370,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Red Bug Pellet 53500380")]
        CathedralOfTheDeepRedBugPellet_ = 53500380,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Titanite Shard 53500390")]
        CathedralOfTheDeepTitaniteShard__ = 53500390,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Titanite Shard 53500400")]
        CathedralOfTheDeepTitaniteShard___ = 53500400,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Rusted Coin 53500420")]
        CathedralOfTheDeepRustedCoin = 53500420,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Drang Hammers 53500430")]
        CathedralOfTheDeepDrangHammers = 53500430,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Drang Shoes 53500450")]
        CathedralOfTheDeepDrangShoes = 53500450,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Large Soul of an Unknown Traveler 53500460")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler____ = 53500460,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Pale Tongue 53500470")]
        CathedralOfTheDeepPaleTongue_ = 53500470,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Drang Gauntlets 53500480")]
        CathedralOfTheDeepDrangGauntlets = 53500480,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Soul of a Nameless Soldier 53500490")]
        CathedralOfTheDeepSoulOfaNamelessSoldier_ = 53500490,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Helm of Thorns 53500500")]
        CathedralOfTheDeepHelmOfThorns = 53500500,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Exploding Bolt 53500540")]
        CathedralOfTheDeepExplodingBolt = 53500540,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Lloyd's Sword Ring 53500550")]
        CathedralOfTheDeepLloydsSwordRing = 53500550,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Soul of a Nameless Soldier 53500560")]
        CathedralOfTheDeepSoulOfaNamelessSoldier__ = 53500560,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Homeward Bone 53500620")]
        CathedralOfTheDeepHomewardBone = 53500620,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Deep Gem 53500630")]
        CathedralOfTheDeepDeepGem = 53500630,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Titanite Shard 53500680")]
        CathedralOfTheDeepTitaniteShard____ = 53500680,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Large Soul of an Unknown Traveler 53500690")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler_____ = 53500690,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Ring of the Evil Eye+1 53500800")]
        CathedralOfTheDeepRingOfTheEvilEye1 = 53500800,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Ring of Favor+2 53500810")]
        CathedralOfTheDeepRingOfFavor2 = 53500810,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Crest Shield 53500850")]
        CathedralOfTheDeepCrestShield = 53500850,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Young White Branch 53500860")]
        CathedralOfTheDeepYoungWhiteBranch = 53500860,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Young White Branch 53500870")]
        CathedralOfTheDeepYoungWhiteBranch_ = 53500870,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Saint-tree Bellvine 53500880")]
        CathedralOfTheDeepSainttreeBellvine = 53500880,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Saint Bident 53500890")]
        CathedralOfTheDeepSaintBident = 53500890,

        [AnnotationAttribute(Name = "[Cathedral of the Deep] Archdeacon White Crown 53500950")]
        CathedralOfTheDeepArchdeaconWhiteCrown = 53500950,

        [AnnotationAttribute(Name = "Large Soul of an Unknown Traveler 53600000")]
        LargeSoulOfanUnknownTraveler = 53600000,

        [AnnotationAttribute(Name = "Large Soul of an Unknown Traveler 53600010")]
        LargeSoulOfanUnknownTraveler_ = 53600010,

        [AnnotationAttribute(Name = "Large Soul of an Unknown Traveler 53600020")]
        LargeSoulOfanUnknownTraveler__ = 53600020,

        [AnnotationAttribute(Name = "Large Soul of an Unknown Traveler 53600030")]
        LargeSoulOfanUnknownTraveler___ = 53600030,

        [AnnotationAttribute(Name = "Large Soul of an Unknown Traveler 53600040")]
        LargeSoulOfanUnknownTraveler____ = 53600040,

        [AnnotationAttribute(Name = "Large Soul of an Unknown Traveler 53600050")]
        LargeSoulOfanUnknownTraveler_____ = 53600050,

        [AnnotationAttribute(Name = "Large Soul of an Unknown Traveler 53600060")]
        LargeSoulOfanUnknownTraveler______ = 53600060,

        [AnnotationAttribute(Name = "Large Soul of an Unknown Traveler 53600070")]
        LargeSoulOfanUnknownTraveler_______ = 53600070,

        [AnnotationAttribute(Name = "Large Soul of an Unknown Traveler 53600080")]
        LargeSoulOfanUnknownTraveler________ = 53600080,

        [AnnotationAttribute(Name = "Large Soul of an Unknown Traveler 53600090")]
        LargeSoulOfanUnknownTraveler_________ = 53600090,

        [AnnotationAttribute(Name = "[Irithyll] Creighton's Steel Mask 53700000")]
        IrithyllCreightonsSteelMask = 53700000,

        [AnnotationAttribute(Name = "[Irithyll] Homeward Bone 53700010")]
        IrithyllHomewardBone = 53700010,

        [AnnotationAttribute(Name = "[Irithyll] Large Soul of a Nameless Soldier 53700020")]
        IrithyllLargeSoulOfaNamelessSoldier = 53700020,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700030")]
        IrithyllLargeTitaniteShard = 53700030,

        [AnnotationAttribute(Name = "[Irithyll] Soul of a Weary Warrior 53700040")]
        IrithyllSoulOfaWearyWarrior = 53700040,

        [AnnotationAttribute(Name = "[Irithyll] Soul of a Weary Warrior 53700050")]
        IrithyllSoulOfaWearyWarrior_ = 53700050,

        [AnnotationAttribute(Name = "[Irithyll] Rime-blue Moss Clump 53700060")]
        IrithyllRimeblueMossClump = 53700060,

        [AnnotationAttribute(Name = "[Irithyll] Witchtree Branch 53700070")]
        IrithyllWitchtreeBranch = 53700070,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700080")]
        IrithyllLargeTitaniteShard_ = 53700080,

        [AnnotationAttribute(Name = "[Irithyll] Estus Shard 53700090")]
        IrithyllEstusShard = 53700090,

        [AnnotationAttribute(Name = "[Irithyll] Budding Green Blossom 53700100")]
        IrithyllBuddingGreenBlossom = 53700100,

        [AnnotationAttribute(Name = "[Irithyll] Rime-blue Moss Clump 53700110")]
        IrithyllRimeblueMossClump_ = 53700110,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700120")]
        IrithyllLargeTitaniteShard__ = 53700120,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700130")]
        IrithyllLargeTitaniteShard___ = 53700130,

        [AnnotationAttribute(Name = "[Irithyll] Ring of the Sun's First Born 53700140")]
        IrithyllRingOfTheSunsFirstBorn = 53700140,

        [AnnotationAttribute(Name = "[Irithyll] Large Soul of a Nameless Soldier 53700150")]
        IrithyllLargeSoulOfaNamelessSoldier_ = 53700150,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700160")]
        IrithyllLargeTitaniteShard____ = 53700160,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700170")]
        IrithyllLargeTitaniteShard_____ = 53700170,

        [AnnotationAttribute(Name = "[Irithyll] Soul of a Weary Warrior 53700180")]
        IrithyllSoulOfaWearyWarrior__ = 53700180,

        [AnnotationAttribute(Name = "[Irithyll] Magic Clutch Ring 53700190")]
        IrithyllMagicClutchRing = 53700190,

        [AnnotationAttribute(Name = "[Irithyll] Fading Soul 53700200")]
        IrithyllFadingSoul = 53700200,

        [AnnotationAttribute(Name = "[Irithyll] Fading Soul 53700210")]
        IrithyllFadingSoul_ = 53700210,

        [AnnotationAttribute(Name = "[Anor Londo] Painting Guardian's Curved Sword 53700220")]
        AnorLondoPaintingGuardiansCurvedSword = 53700220,

        [AnnotationAttribute(Name = "[Irithyll] Homeward Bone 53700230")]
        IrithyllHomewardBone_ = 53700230,

        [AnnotationAttribute(Name = "[Irithyll] Undead Bone Shard 53700240")]
        IrithyllUndeadBoneShard = 53700240,

        [AnnotationAttribute(Name = "[Irithyll] Kukri 53700250")]
        IrithyllKukri = 53700250,

        [AnnotationAttribute(Name = "[Irithyll] Rusted Gold Coin 53700260")]
        IrithyllRustedGoldCoin = 53700260,

        [AnnotationAttribute(Name = "[Irithyll] Brass Helm 53700270")]
        IrithyllBrassHelm = 53700270,

        [AnnotationAttribute(Name = "[Irithyll] Blue Bug Pellet 53700280")]
        IrithyllBlueBugPellet = 53700280,

        [AnnotationAttribute(Name = "[Irithyll] Shriving Stone 53700290")]
        IrithyllShrivingStone = 53700290,

        [AnnotationAttribute(Name = "[Irithyll] Human Dregs 53700300")]
        IrithyllHumanDregs = 53700300,

        [AnnotationAttribute(Name = "[Irithyll] Roster of Knights 6782")]
        IrithyllRosterOfKnights = 6782,

        [AnnotationAttribute(Name = "[Irithyll] Blood Gem 53700320")]
        IrithyllBloodGem = 53700320,

        [AnnotationAttribute(Name = "[Irithyll] Green Blossom 53700330")]
        IrithyllGreenBlossom = 53700330,

        [AnnotationAttribute(Name = "[Irithyll] Ring of Sacrifice 53700340")]
        IrithyllRingOfSacrifice = 53700340,

        [AnnotationAttribute(Name = "[Irithyll] Great Heal 53700350")]
        IrithyllGreatHeal = 53700350,

        [AnnotationAttribute(Name = "[Irithyll] Large Soul of a Nameless Soldier 53700360")]
        IrithyllLargeSoulOfaNamelessSoldier__ = 53700360,

        [AnnotationAttribute(Name = "[Irithyll] Green Blossom 53700370")]
        IrithyllGreenBlossom_ = 53700370,

        [AnnotationAttribute(Name = "[Irithyll] Dung Pie 53700380")]
        IrithyllDungPie = 53700380,

        [AnnotationAttribute(Name = "[Irithyll] Dung Pie 53700390")]
        IrithyllDungPie_ = 53700390,

        [AnnotationAttribute(Name = "[Irithyll] Excrement-covered Ashes 53700400")]
        IrithyllExcrementcoveredAshes = 53700400,

        [AnnotationAttribute(Name = "[Irithyll] Ember 53700410")]
        IrithyllEmber = 53700410,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700420")]
        IrithyllLargeTitaniteShard______ = 53700420,

        [AnnotationAttribute(Name = "[Irithyll] Large Soul of a Nameless Soldier 53700430")]
        IrithyllLargeSoulOfaNamelessSoldier___ = 53700430,

        [AnnotationAttribute(Name = "[Irithyll] Soul of a Weary Warrior 53700440")]
        IrithyllSoulOfaWearyWarrior___ = 53700440,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700450")]
        IrithyllLargeTitaniteShard_______ = 53700450,

        [AnnotationAttribute(Name = "[Irithyll] Blue Bug Pellet 53700460")]
        IrithyllBlueBugPellet_ = 53700460,

        [AnnotationAttribute(Name = "[Irithyll] Ember 53700470")]
        IrithyllEmber_ = 53700470,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700480")]
        IrithyllLargeTitaniteShard________ = 53700480,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700490")]
        IrithyllLargeTitaniteShard_________ = 53700490,

        [AnnotationAttribute(Name = "[Irithyll] Soul of a Weary Warrior 53700500")]
        IrithyllSoulOfaWearyWarrior____ = 53700500,

        [AnnotationAttribute(Name = "[Irithyll] Ember 53700510")]
        IrithyllEmber__ = 53700510,

        [AnnotationAttribute(Name = "[Irithyll] Ember 53700520")]
        IrithyllEmber___ = 53700520,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700530")]
        IrithyllLargeTitaniteShard__________ = 53700530,

        [AnnotationAttribute(Name = "[Irithyll] Dark Stoneplate Ring 53700540")]
        IrithyllDarkStoneplateRing = 53700540,

        [AnnotationAttribute(Name = "[Irithyll] Large Titanite Shard 53700550")]
        IrithyllLargeTitaniteShard___________ = 53700550,

        [AnnotationAttribute(Name = "[Irithyll] Green Blossom 53700560")]
        IrithyllGreenBlossom__ = 53700560,

        [AnnotationAttribute(Name = "[Irithyll] Deep Gem 53700600")]
        IrithyllDeepGem = 53700600,

        [AnnotationAttribute(Name = "[Irithyll] Titanite Scale 53700610")]
        IrithyllTitaniteScale = 53700610,

        [AnnotationAttribute(Name = "[Irithyll] Dragonslayer Greatbow 53700620")]
        IrithyllDragonslayerGreatbow = 53700620,

        [AnnotationAttribute(Name = "[Irithyll] Easterner's Ashes 53700630")]
        IrithyllEasternersAshes = 53700630,

        [AnnotationAttribute(Name = "[Anor Londo] Painting Guardian Hood 53700640")]
        AnorLondoPaintingGuardianHood = 53700640,

        [AnnotationAttribute(Name = "[Anor Londo] Soul of a Crestfallen Knight 53700660")]
        AnorLondoSoulOfaCrestfallenKnight = 53700660,

        [AnnotationAttribute(Name = "[Irithyll] Lightning Gem 53700670")]
        IrithyllLightningGem = 53700670,

        [AnnotationAttribute(Name = "[Anor Londo] Moonlight Arrow 53700690")]
        AnorLondoMoonlightArrow = 53700690,

        [AnnotationAttribute(Name = "[Irithyll] Proof of a Concord Kept 53700700")]
        IrithyllProofOfaConcordKept = 53700700,

        [AnnotationAttribute(Name = "[Irithyll] Large Soul of a Nameless Soldier 53700720")]
        IrithyllLargeSoulOfaNamelessSoldier____ = 53700720,

        [AnnotationAttribute(Name = "[Irithyll] Soul of a Weary Warrior 53700740")]
        IrithyllSoulOfaWearyWarrior_____ = 53700740,

        [AnnotationAttribute(Name = "[Irithyll] Proof of a Concord Kept 53700750")]
        IrithyllProofOfaConcordKept_ = 53700750,

        [AnnotationAttribute(Name = "[Irithyll] Rusted Gold Coin 53700760")]
        IrithyllRustedGoldCoin_ = 53700760,

        [AnnotationAttribute(Name = "[Irithyll] Large Soul of a Weary Warrior 53700770")]
        IrithyllLargeSoulOfaWearyWarrior = 53700770,

        [AnnotationAttribute(Name = "[Anor Londo] Giant's Coal 53700800")]
        AnorLondoGiantsCoal = 53700800,

        [AnnotationAttribute(Name = "[Irithyll] Chloranthy Ring+1 53700810")]
        IrithyllChloranthyRing1 = 53700810,

        [AnnotationAttribute(Name = "[Irithyll] Havel's Ring+2 53700820")]
        IrithyllHavelsRing2 = 53700820,

        [AnnotationAttribute(Name = "[Irithyll] Ring of Favor+1 53700830")]
        IrithyllRingOfFavor1 = 53700830,

        [AnnotationAttribute(Name = "[Irithyll] Sun Princess Ring 53700840")]
        IrithyllSunPrincessRing = 53700840,

        [AnnotationAttribute(Name = "[Irithyll] Covetous Gold Serpent Ring+1 53700850")]
        IrithyllCovetousGoldSerpentRing1 = 53700850,

        [AnnotationAttribute(Name = "[Irithyll] Wood Grain Ring+2 53700860")]
        IrithyllWoodGrainRing2 = 53700860,

        [AnnotationAttribute(Name = "[Irithyll] Divine Blessing 53700900")]
        IrithyllDivineBlessing = 53700900,

        [AnnotationAttribute(Name = "[Irithyll] Smough's Great Hammer 53700920")]
        IrithyllSmoughsGreatHammer = 53700920,

        [AnnotationAttribute(Name = "[Irithyll] Reversal Ring 53700940")]
        IrithyllReversalRing = 53700940,

        [AnnotationAttribute(Name = "[Irithyll] Yorshka's Spear 53700950")]
        IrithyllYorshkasSpear = 53700950,

        [AnnotationAttribute(Name = "[Irithyll] Leo Ring 53700960")]
        IrithyllLeoRing = 53700960,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Carthus Rouge 53800000")]
        CatacombsOfCarthusCarthusRouge = 53800000,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Sharp Gem 53800010")]
        CatacombsOfCarthusSharpGem = 53800010,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Soul of a Nameless Soldier 53800020")]
        CatacombsOfCarthusSoulOfaNamelessSoldier = 53800020,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Titanite Shard 53800030")]
        CatacombsOfCarthusTitaniteShard = 53800030,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Bloodred Moss Clump 53800040")]
        CatacombsOfCarthusBloodredMossClump = 53800040,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Carthus Milkring 53800050")]
        CatacombsOfCarthusCarthusMilkring = 53800050,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Ember 53800060")]
        CatacombsOfCarthusEmber = 53800060,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Carthus Rouge 53800070")]
        CatacombsOfCarthusCarthusRouge_ = 53800070,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Ember 53800080")]
        CatacombsOfCarthusEmber_ = 53800080,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Carthus Bloodring 53800090")]
        CatacombsOfCarthusCarthusBloodring = 53800090,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Titanite Shard 53800100")]
        CatacombsOfCarthusTitaniteShard_ = 53800100,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Titanite Shard 53800110")]
        CatacombsOfCarthusTitaniteShard__ = 53800110,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Ember 53800120")]
        CatacombsOfCarthusEmber__ = 53800120,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Carthus Pyromancy Tome 53800130")]
        CatacombsOfCarthusCarthusPyromancyTome = 53800130,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800140")]
        CatacombsOfCarthusLargeTitaniteShard = 53800140,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800150")]
        CatacombsOfCarthusLargeTitaniteShard_ = 53800150,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Yellow Bug Pellet 53800160")]
        CatacombsOfCarthusYellowBugPellet = 53800160,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Soul of a Nameless Soldier 53800170")]
        CatacombsOfCarthusLargeSoulOfaNamelessSoldier = 53800170,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Black Bug Pellet 53800180")]
        CatacombsOfCarthusBlackBugPellet = 53800180,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Grave Warden's Ashes 53800190")]
        CatacombsOfCarthusGraveWardensAshes = 53800190,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800200")]
        CatacombsOfCarthusLargeTitaniteShard__ = 53800200,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800210")]
        CatacombsOfCarthusLargeTitaniteShard___ = 53800210,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800220")]
        CatacombsOfCarthusLargeTitaniteShard____ = 53800220,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800230")]
        CatacombsOfCarthusLargeTitaniteShard_____ = 53800230,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800240")]
        CatacombsOfCarthusLargeTitaniteShard______ = 53800240,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800250")]
        CatacombsOfCarthusLargeTitaniteShard_______ = 53800250,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Yellow Bug Pellet 53800260")]
        CatacombsOfCarthusYellowBugPellet_ = 53800260,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800270")]
        CatacombsOfCarthusLargeTitaniteShard________ = 53800270,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800280")]
        CatacombsOfCarthusLargeTitaniteShard_________ = 53800280,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800290")]
        CatacombsOfCarthusLargeTitaniteShard__________ = 53800290,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Speckled Stoneplate Ring 53800300")]
        CatacombsOfCarthusSpeckledStoneplateRing = 53800300,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Homeward Bone 53800310")]
        CatacombsOfCarthusHomewardBone = 53800310,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Ember 53800330")]
        CatacombsOfCarthusEmber___ = 53800330,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Chaos Gem 53800340")]
        CatacombsOfCarthusChaosGem = 53800340,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Ember 53800350")]
        CatacombsOfCarthusEmber____ = 53800350,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Izalith Pyromancy Tome 53800360")]
        CatacombsOfCarthusIzalithPyromancyTome = 53800360,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Black Knight Sword 53800370")]
        CatacombsOfCarthusBlackKnightSword = 53800370,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Soul of a Nameless Soldier 53800380")]
        CatacombsOfCarthusLargeSoulOfaNamelessSoldier_ = 53800380,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Old Sage's Blindfold 53800390")]
        CatacombsOfCarthusOldSagesBlindfold = 53800390,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Ember 53800400")]
        CatacombsOfCarthusEmber_____ = 53800400,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Quelana Pyromancy Tome 53800410")]
        CatacombsOfCarthusQuelanaPyromancyTome = 53800410,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Izalith Staff 53800420")]
        CatacombsOfCarthusIzalithStaff = 53800420,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] White Hair Talisman 53800430")]
        CatacombsOfCarthusWhiteHairTalisman = 53800430,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Toxic Mist 53800440")]
        CatacombsOfCarthusToxicMist = 53800440,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Undead Bone Shard 53800450")]
        CatacombsOfCarthusUndeadBoneShard = 53800450,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Titanite Scale 53800460")]
        CatacombsOfCarthusTitaniteScale = 53800460,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Soul of a Nameless Soldier 53800470")]
        CatacombsOfCarthusSoulOfaNamelessSoldier_ = 53800470,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Grave Warden Pyromancy Tome 53800500")]
        CatacombsOfCarthusGraveWardenPyromancyTome = 53800500,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Shield of Want 53800520")]
        CatacombsOfCarthusShieldOfWant = 53800520,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Soul of a Crestfallen Knight 53800530")]
        CatacombsOfCarthusSoulOfaCrestfallenKnight = 53800530,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Ember 53800540")]
        CatacombsOfCarthusEmber______ = 53800540,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Sacred Flame 53800560")]
        CatacombsOfCarthusSacredFlame = 53800560,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Soul of an Unknown Traveler 53800570")]
        CatacombsOfCarthusLargeSoulOfanUnknownTraveler = 53800570,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Dragonrider Bow 53800580")]
        CatacombsOfCarthusDragonriderBow = 53800580,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Estus Shard 53800590")]
        CatacombsOfCarthusEstusShard = 53800590,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Ring of Steel Protection+2 53800600")]
        CatacombsOfCarthusRingOfSteelProtection2 = 53800600,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Thunder Stoneplate Ring+1 53800610")]
        CatacombsOfCarthusThunderStoneplateRing1 = 53800610,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Bloodbite Ring+1 53800620")]
        CatacombsOfCarthusBloodbiteRing1 = 53800620,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Flame Stoneplate Ring+2 53800630")]
        CatacombsOfCarthusFlameStoneplateRing2 = 53800630,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Large Titanite Shard 53800760")]
        CatacombsOfCarthusLargeTitaniteShard___________ = 53800760,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Undead Bone Shard 53800900")]
        CatacombsOfCarthusUndeadBoneShard_ = 53800900,

        [AnnotationAttribute(Name = "[Catacombs of Carthus] Dark Gem 53800910")]
        CatacombsOfCarthusDarkGem = 53800910,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Large Titanite Shard 53900000")]
        IrithyllDungeonLargeTitaniteShard = 53900000,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Fading Soul 53900010")]
        IrithyllDungeonFadingSoul = 53900010,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Large Soul of a Nameless Soldier 53900030")]
        IrithyllDungeonLargeSoulOfaNamelessSoldier = 53900030,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Jailbreaker's Key 53900040")]
        IrithyllDungeonJailbreakersKey = 53900040,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Pale Pine Resin 53900050")]
        IrithyllDungeonPalePineResin = 53900050,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Simple Gem 53900060")]
        IrithyllDungeonSimpleGem = 53900060,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Large Soul of a Nameless Soldier 53900070")]
        IrithyllDungeonLargeSoulOfaNamelessSoldier_ = 53900070,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Large Titanite Shard 53900080")]
        IrithyllDungeonLargeTitaniteShard_ = 53900080,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Homeward Bone 53900090")]
        IrithyllDungeonHomewardBone = 53900090,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Bellowing Dragoncrest Ring 53900100")]
        IrithyllDungeonBellowingDragoncrestRing = 53900100,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Soul of a Weary Warrior 53900110")]
        IrithyllDungeonSoulOfaWearyWarrior = 53900110,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Soul of a Crestfallen Knight 53900120")]
        IrithyllDungeonSoulOfaCrestfallenKnight = 53900120,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Alva Helm 53900130")]
        IrithyllDungeonAlvaHelm = 53900130,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Lightning Bolt 53900140")]
        IrithyllDungeonLightningBolt = 53900140,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Large Titanite Shard 53900150")]
        IrithyllDungeonLargeTitaniteShard__ = 53900150,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Profaned Flame 53900160")]
        IrithyllDungeonProfanedFlame = 53900160,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Large Titanite Shard 53900180")]
        IrithyllDungeonLargeTitaniteShard___ = 53900180,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Soul of a Weary Warrior 53900190")]
        IrithyllDungeonSoulOfaWearyWarrior_ = 53900190,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Dung Pie 53900200")]
        IrithyllDungeonDungPie = 53900200,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Purging Stone 53900210")]
        IrithyllDungeonPurgingStone = 53900210,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Ember 53900220")]
        IrithyllDungeonEmber = 53900220,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Ember 53900230")]
        IrithyllDungeonEmber_ = 53900230,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Profaned Coal 53900240")]
        IrithyllDungeonProfanedCoal = 53900240,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Large Titanite Shard 53900250")]
        IrithyllDungeonLargeTitaniteShard____ = 53900250,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Old Sorcerer Hat 53900260")]
        IrithyllDungeonOldSorcererHat = 53900260,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Large Soul of a Weary Warrior 53900270")]
        IrithyllDungeonLargeSoulOfaWearyWarrior = 53900270,

        [AnnotationAttribute(Name = "[Profaned Capital] Rusted Coin 53900280")]
        ProfanedCapitalRustedCoin = 53900280,

        [AnnotationAttribute(Name = "[Profaned Capital] Rusted Gold Coin 53900290")]
        ProfanedCapitalRustedGoldCoin = 53900290,

        [AnnotationAttribute(Name = "[Profaned Capital] Purging Stone 53900300")]
        ProfanedCapitalPurgingStone = 53900300,

        [AnnotationAttribute(Name = "[Profaned Capital] Cursebite Ring 53900310")]
        ProfanedCapitalCursebiteRing = 53900310,

        [AnnotationAttribute(Name = "[Profaned Capital] Poison Gem 53900320")]
        ProfanedCapitalPoisonGem = 53900320,

        [AnnotationAttribute(Name = "[Profaned Capital] Shriving Stone 53900330")]
        ProfanedCapitalShrivingStone = 53900330,

        [AnnotationAttribute(Name = "[Profaned Capital] Poison Arrow 53900340")]
        ProfanedCapitalPoisonArrow = 53900340,

        [AnnotationAttribute(Name = "[Profaned Capital] Rubbish 53900350")]
        ProfanedCapitalRubbish = 53900350,

        [AnnotationAttribute(Name = "[Profaned Capital] Onislayer Greatarrow 53900360")]
        ProfanedCapitalOnislayerGreatarrow = 53900360,

        [AnnotationAttribute(Name = "[Profaned Capital] Large Soul of a Weary Warrior 53900370")]
        ProfanedCapitalLargeSoulOfaWearyWarrior = 53900370,

        [AnnotationAttribute(Name = "[Profaned Capital] Rusted Coin 53900380")]
        ProfanedCapitalRustedCoin_ = 53900380,

        [AnnotationAttribute(Name = "[Profaned Capital] Rusted Coin 53900390")]
        ProfanedCapitalRustedCoin__ = 53900390,

        [AnnotationAttribute(Name = "[Profaned Capital] Covetous Gold Serpent Ring 53900400")]
        ProfanedCapitalCovetousGoldSerpentRing = 53900400,

        [AnnotationAttribute(Name = "[Profaned Capital] Blooming Purple Moss Clump 53900410")]
        ProfanedCapitalBloomingPurpleMossClump = 53900410,

        [AnnotationAttribute(Name = "[Profaned Capital] Wrath of the Gods 53900420")]
        ProfanedCapitalWrathOfTheGods = 53900420,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Lightning Blade 53900430")]
        IrithyllDungeonLightningBlade = 53900430,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Large Titanite Shard 53900440")]
        IrithyllDungeonLargeTitaniteShard_____ = 53900440,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Rusted Coin 53900450")]
        IrithyllDungeonRustedCoin = 53900450,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Dusk Crown Ring 53900460")]
        IrithyllDungeonDuskCrownRing = 53900460,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Pickaxe 53900470")]
        IrithyllDungeonPickaxe = 53900470,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Xanthous Ashes 53900480")]
        IrithyllDungeonXanthousAshes = 53900480,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Onislayer Greatbow 53900490")]
        IrithyllDungeonOnislayerGreatbow = 53900490,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Rusted Gold Coin 53900500")]
        IrithyllDungeonRustedGoldCoin = 53900500,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Large Titanite Shard 53900510")]
        IrithyllDungeonLargeTitaniteShard______ = 53900510,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Jailer's Key Ring 53900520")]
        IrithyllDungeonJailersKeyRing = 53900520,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Ember 53900590")]
        IrithyllDungeonEmber__ = 53900590,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Old Cell Key 53900610")]
        IrithyllDungeonOldCellKey = 53900610,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Flame Stoneplate Ring+1 53900710")]
        IrithyllDungeonFlameStoneplateRing1 = 53900710,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Covetous Silver Serpent Ring+1 53900720")]
        IrithyllDungeonCovetousSilverSerpentRing1 = 53900720,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Magic Stoneplate Ring+2 53900730")]
        IrithyllDungeonMagicStoneplateRing2 = 53900730,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Dragon Torso Stone 53900750")]
        IrithyllDungeonDragonTorsoStone = 53900750,

        [AnnotationAttribute(Name = "[Profaned Capital] Court Sorcerer Hood 53900800")]
        ProfanedCapitalCourtSorcererHood = 53900800,

        [AnnotationAttribute(Name = "[Profaned Capital] Storm Ruler 53900810")]
        ProfanedCapitalStormRuler = 53900810,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Prisoner Chief's Ashes 53900820")]
        IrithyllDungeonPrisonerChiefsAshes = 53900820,

        [AnnotationAttribute(Name = "[Irithyll Dungeon] Undead Bone Shard 53900900")]
        IrithyllDungeonUndeadBoneShard = 53900900,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Broken Straight Sword 54000010")]
        CemeteryOfAshBrokenStraightSword = 54000010,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Soul of a Deserted Corpse 54000020")]
        CemeteryOfAshSoulOfaDesertedCorpse = 54000020,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Firebomb 54000030")]
        CemeteryOfAshFirebomb = 54000030,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Titanite Shard 54000050")]
        CemeteryOfAshTitaniteShard = 54000050,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Homeward Bone 54000060")]
        CemeteryOfAshHomewardBone = 54000060,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Ember 54000070")]
        CemeteryOfAshEmber = 54000070,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Soul of a Deserted Corpse 54000080")]
        CemeteryOfAshSoulOfaDesertedCorpse_ = 54000080,

        [AnnotationAttribute(Name = "[Cemetery of Ash] East-West Shield 54000090")]
        CemeteryOfAshEastWestShield = 54000090,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Homeward Bone 54000100")]
        CemeteryOfAshHomewardBone_ = 54000100,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Soul of an Unknown Traveler 54000110")]
        CemeteryOfAshSoulOfanUnknownTraveler = 54000110,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Ember 54000120")]
        CemeteryOfAshEmber_ = 54000120,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Sneering Mask 54000140")]
        CemeteryOfAshSneeringMask = 54000140,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Homeward Bone 54000160")]
        CemeteryOfAshHomewardBone__ = 54000160,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Estus Ring 54000170")]
        CemeteryOfAshEstusRing = 54000170,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Estus Shard 54000180")]
        CemeteryOfAshEstusShard = 54000180,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Fire Keeper Soul 54000190")]
        CemeteryOfAshFireKeeperSoul = 54000190,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Shriving Stone 54000200")]
        CemeteryOfAshShrivingStone = 54000200,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Titanite Chunk 54000220")]
        CemeteryOfAshTitaniteChunk = 54000220,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Soul of a Crestfallen Knight 54000230")]
        CemeteryOfAshSoulOfaCrestfallenKnight = 54000230,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Titanite Chunk 54000240")]
        CemeteryOfAshTitaniteChunk_ = 54000240,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Ashen Estus Ring 54000250")]
        CemeteryOfAshAshenEstusRing = 54000250,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Black Knight Glaive 54000260")]
        CemeteryOfAshBlackKnightGlaive = 54000260,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Eyes of a Fire Keeper 54000280")]
        CemeteryOfAshEyesOfaFireKeeper = 54000280,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Soul of a Crestfallen Knight 54000290")]
        CemeteryOfAshSoulOfaCrestfallenKnight_ = 54000290,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Blacksmith Hammer 54000300")]
        CemeteryOfAshBlacksmithHammer = 54000300,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Chaos Blade 54000310")]
        CemeteryOfAshChaosBlade = 54000310,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Hollow's Ashes 54000320")]
        CemeteryOfAshHollowsAshes = 54000320,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Hornet Ring 54000330")]
        CemeteryOfAshHornetRing = 54000330,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Coiled Sword Fragment 54000340")]
        CemeteryOfAshCoiledSwordFragment = 54000340,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Fire Keeper Robe 54000350")]
        CemeteryOfAshFireKeeperRobe = 54000350,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Life Ring+3 54000400")]
        CemeteryOfAshLifeRing3 = 54000400,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Ring of Steel Protection+1 54000410")]
        CemeteryOfAshRingOfSteelProtection1 = 54000410,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Speckled Stoneplate Ring+1 54000420")]
        CemeteryOfAshSpeckledStoneplateRing1 = 54000420,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Wolf Ring+2 54000430")]
        CemeteryOfAshWolfRing2 = 54000430,

        [AnnotationAttribute(Name = "Ashen Estus Flask 6600")]
        AshenEstusFlask = 6600,

        [AnnotationAttribute(Name = "[Cemetery of Ash] Covetous Silver Serpent Ring 54000700")]
        CemeteryOfAshCovetousSilverSerpentRing = 54000700,

        [AnnotationAttribute(Name = "[Ariandel] Rime-blue Moss Clump 54500000")]
        AriandelRimeblueMossClump = 54500000,

        [AnnotationAttribute(Name = "[Ariandel] Poison Gem 54500010")]
        AriandelPoisonGem = 54500010,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of an Unknown Traveler 54500020")]
        AriandelLargeSoulOfanUnknownTraveler = 54500020,

        [AnnotationAttribute(Name = "[Ariandel] Follower Javelin 54500030")]
        AriandelFollowerJavelin = 54500030,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of an Unknown Traveler 54500040")]
        AriandelLargeSoulOfanUnknownTraveler_ = 54500040,

        [AnnotationAttribute(Name = "[Ariandel] Homeward Bone 54500050")]
        AriandelHomewardBone = 54500050,

        [AnnotationAttribute(Name = "[Ariandel] Blessed Gem 54500060")]
        AriandelBlessedGem = 54500060,

        [AnnotationAttribute(Name = "[Ariandel] Captain's Ashes 54500070")]
        AriandelCaptainsAshes = 54500070,

        [AnnotationAttribute(Name = "[Ariandel] Black Firebomb 54500080")]
        AriandelBlackFirebomb = 54500080,

        [AnnotationAttribute(Name = "[Ariandel] Shriving Stone 54500090")]
        AriandelShrivingStone = 54500090,

        [AnnotationAttribute(Name = "[Ariandel] Millwood Greatbow 54500100")]
        AriandelMillwoodGreatbow = 54500100,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of an Unknown Traveler 54500110")]
        AriandelLargeSoulOfanUnknownTraveler__ = 54500110,

        [AnnotationAttribute(Name = "[Ariandel] Rusted Coin 54500120")]
        AriandelRustedCoin = 54500120,

        [AnnotationAttribute(Name = "[Ariandel] Large Titanite Shard 54500130")]
        AriandelLargeTitaniteShard = 54500130,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of an Unknown Traveler 54500140")]
        AriandelLargeSoulOfanUnknownTraveler___ = 54500140,

        [AnnotationAttribute(Name = "[Ariandel] Crow Quills 54500150")]
        AriandelCrowQuills = 54500150,

        [AnnotationAttribute(Name = "[Ariandel] Simple Gem 54500160")]
        AriandelSimpleGem = 54500160,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of an Unknown Traveler 54500170")]
        AriandelLargeSoulOfanUnknownTraveler____ = 54500170,

        [AnnotationAttribute(Name = "[Ariandel] Slave Knight Hood 54500180")]
        AriandelSlaveKnightHood = 54500180,

        [AnnotationAttribute(Name = "[Ariandel] Ember 54500190")]
        AriandelEmber = 54500190,

        [AnnotationAttribute(Name = "[Ariandel] Dark Gem 54500200")]
        AriandelDarkGem = 54500200,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of an Unknown Traveler 54500220")]
        AriandelLargeSoulOfanUnknownTraveler_____ = 54500220,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of an Unknown Traveler 54500230")]
        AriandelLargeSoulOfanUnknownTraveler______ = 54500230,

        [AnnotationAttribute(Name = "[Ariandel] Rusted Gold Coin 54500240")]
        AriandelRustedGoldCoin = 54500240,

        [AnnotationAttribute(Name = "[Ariandel] Soul of a Crestfallen Knight 54500250")]
        AriandelSoulOfaCrestfallenKnight = 54500250,

        [AnnotationAttribute(Name = "[Ariandel] Way of White Corona 54500260")]
        AriandelWayOfWhiteCorona = 54500260,

        [AnnotationAttribute(Name = "[Ariandel] Rusted Coin 54500270")]
        AriandelRustedCoin_ = 54500270,

        [AnnotationAttribute(Name = "[Ariandel] Young White Branch 54500280")]
        AriandelYoungWhiteBranch = 54500280,

        [AnnotationAttribute(Name = "[Ariandel] Budding Green Blossom 54500290")]
        AriandelBuddingGreenBlossom = 54500290,

        [AnnotationAttribute(Name = "[Ariandel] Crow Talons 54500300")]
        AriandelCrowTalons = 54500300,

        [AnnotationAttribute(Name = "[Ariandel] Prism Stone 54500310")]
        AriandelPrismStone = 54500310,

        [AnnotationAttribute(Name = "[Ariandel] Titanite Chunk 54500320")]
        AriandelTitaniteChunk = 54500320,

        [AnnotationAttribute(Name = "[Ariandel] Titanite Chunk 54500330")]
        AriandelTitaniteChunk_ = 54500330,

        [AnnotationAttribute(Name = "[Ariandel] Follower Shield 54500340")]
        AriandelFollowerShield = 54500340,

        [AnnotationAttribute(Name = "[Ariandel] Large Titanite Shard 54500350")]
        AriandelLargeTitaniteShard_ = 54500350,

        [AnnotationAttribute(Name = "[Ariandel] Quakestone Hammer 54500360")]
        AriandelQuakestoneHammer = 54500360,

        [AnnotationAttribute(Name = "[Ariandel] Ember 54500370")]
        AriandelEmber_ = 54500370,

        [AnnotationAttribute(Name = "[Ariandel] Large Titanite Shard 54500380")]
        AriandelLargeTitaniteShard__ = 54500380,

        [AnnotationAttribute(Name = "[Ariandel] Soul of a Crestfallen Knight 54500390")]
        AriandelSoulOfaCrestfallenKnight_ = 54500390,

        [AnnotationAttribute(Name = "[Ariandel] Soul of a Crestfallen Knight 54500400")]
        AriandelSoulOfaCrestfallenKnight__ = 54500400,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of a Crestfallen Knight 54500410")]
        AriandelLargeSoulOfaCrestfallenKnight = 54500410,

        [AnnotationAttribute(Name = "[Ariandel] Earth Seeker 54500420")]
        AriandelEarthSeeker = 54500420,

        [AnnotationAttribute(Name = "[Ariandel] Follower Torch 54500430")]
        AriandelFollowerTorch = 54500430,

        [AnnotationAttribute(Name = "[Ariandel] Dung Pie 54500460")]
        AriandelDungPie = 54500460,

        [AnnotationAttribute(Name = "[Ariandel] Vilhelm's Helm 54500470")]
        AriandelVilhelmsHelm = 54500470,

        [AnnotationAttribute(Name = "[Ariandel] Blood Gem 54500480")]
        AriandelBloodGem = 54500480,

        [AnnotationAttribute(Name = "[Ariandel] Hollow Gem 54500490")]
        AriandelHollowGem = 54500490,

        [AnnotationAttribute(Name = "[Ariandel] Rime-blue Moss Clump 54500530")]
        AriandelRimeblueMossClump_ = 54500530,

        [AnnotationAttribute(Name = "[Ariandel] Follower Sabre 54500540")]
        AriandelFollowerSabre = 54500540,

        [AnnotationAttribute(Name = "[Ariandel] Ember 54500550")]
        AriandelEmber__ = 54500550,

        [AnnotationAttribute(Name = "[Ariandel] Snap Freeze 54500560")]
        AriandelSnapFreeze = 54500560,

        [AnnotationAttribute(Name = "[Ariandel] Pyromancer's Parting Flame 54500570")]
        AriandelPyromancersPartingFlame = 54500570,

        [AnnotationAttribute(Name = "[Ariandel] Rime-blue Moss Clump 54500600")]
        AriandelRimeblueMossClump__ = 54500600,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of an Unknown Traveler 54500610")]
        AriandelLargeSoulOfanUnknownTraveler_______ = 54500610,

        [AnnotationAttribute(Name = "[Ariandel] Ember 54500620")]
        AriandelEmber___ = 54500620,

        [AnnotationAttribute(Name = "[Ariandel] Frozen Weapon 54500630")]
        AriandelFrozenWeapon = 54500630,

        [AnnotationAttribute(Name = "[Ariandel] Titanite Slab 54500640")]
        AriandelTitaniteSlab = 54500640,

        [AnnotationAttribute(Name = "[Ariandel] Homeward Bone 54500650")]
        AriandelHomewardBone_ = 54500650,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of an Unknown Traveler 54500660")]
        AriandelLargeSoulOfanUnknownTraveler________ = 54500660,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of a Weary Warrior 54500670")]
        AriandelLargeSoulOfaWearyWarrior = 54500670,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of an Unknown Traveler 54500680")]
        AriandelLargeSoulOfanUnknownTraveler_________ = 54500680,

        [AnnotationAttribute(Name = "[Ariandel] Heavy Gem 54500690")]
        AriandelHeavyGem = 54500690,

        [AnnotationAttribute(Name = "[Ariandel] Large Soul of a Weary Warrior 54500800")]
        AriandelLargeSoulOfaWearyWarrior_ = 54500800,

        [AnnotationAttribute(Name = "[Ariandel] Millwood Battle Axe 54500810")]
        AriandelMillwoodBattleAxe = 54500810,

        [AnnotationAttribute(Name = "[Ariandel] Ethereal Oak Shield 54500820")]
        AriandelEtherealOakShield = 54500820,

        [AnnotationAttribute(Name = "[Ariandel] Soul of a Weary Warrior 54500830")]
        AriandelSoulOfaWearyWarrior = 54500830,

        [AnnotationAttribute(Name = "[Dreg Heap] Ember 55000000")]
        DregHeapEmber = 55000000,

        [AnnotationAttribute(Name = "[Dreg Heap] Soul of a Weary Warrior 55000010")]
        DregHeapSoulOfaWearyWarrior = 55000010,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Chunk 55000020")]
        DregHeapTitaniteChunk = 55000020,

        [AnnotationAttribute(Name = "[Dreg Heap] Aquamarine Dagger 55000030")]
        DregHeapAquamarineDagger = 55000030,

        [AnnotationAttribute(Name = "[Dreg Heap] Twinkling Titanite 55000040")]
        DregHeapTwinklingTitanite = 55000040,

        [AnnotationAttribute(Name = "[Dreg Heap] Murky Hand Scythe 55000050")]
        DregHeapMurkyHandScythe = 55000050,

        [AnnotationAttribute(Name = "[Dreg Heap] Divine Blessing 55000060")]
        DregHeapDivineBlessing = 55000060,

        [AnnotationAttribute(Name = "[Dreg Heap] Ring of Steel Protection+3 55000070")]
        DregHeapRingOfSteelProtection3 = 55000070,

        [AnnotationAttribute(Name = "[Dreg Heap] Soul of a Crestfallen Knight 55000080")]
        DregHeapSoulOfaCrestfallenKnight = 55000080,

        [AnnotationAttribute(Name = "[Dreg Heap] Rusted Coin 55000090")]
        DregHeapRustedCoin = 55000090,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Chunk 55000100")]
        DregHeapTitaniteChunk_ = 55000100,

        [AnnotationAttribute(Name = "[Dreg Heap] Murky Longstaff 55000110")]
        DregHeapMurkyLongstaff = 55000110,

        [AnnotationAttribute(Name = "[Dreg Heap] Ember 55000120")]
        DregHeapEmber_ = 55000120,

        [AnnotationAttribute(Name = "[Dreg Heap] Great Soul Dregs 55000130")]
        DregHeapGreatSoulDregs = 55000130,

        [AnnotationAttribute(Name = "[Dreg Heap] Covetous Silver Serpent Ring+3 55000140")]
        DregHeapCovetousSilverSerpentRing3 = 55000140,

        [AnnotationAttribute(Name = "[Dreg Heap] Fading Soul 55000150")]
        DregHeapFadingSoul = 55000150,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Chunk 55000160")]
        DregHeapTitaniteChunk__ = 55000160,

        [AnnotationAttribute(Name = "[Dreg Heap] Homeward Bone 55000170")]
        DregHeapHomewardBone = 55000170,

        [AnnotationAttribute(Name = "[Dreg Heap] Fading Soul 55000180")]
        DregHeapFadingSoul_ = 55000180,

        [AnnotationAttribute(Name = "[Dreg Heap] Lightning Urn 55000190")]
        DregHeapLightningUrn = 55000190,

        [AnnotationAttribute(Name = "[Dreg Heap] Projected Heal 55000200")]
        DregHeapProjectedHeal = 55000200,

        [AnnotationAttribute(Name = "[Dreg Heap] Large Soul of a Weary Warrior 55000210")]
        DregHeapLargeSoulOfaWearyWarrior = 55000210,

        [AnnotationAttribute(Name = "[Dreg Heap] Lothric War Banner 55000220")]
        DregHeapLothricWarBanner = 55000220,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Scale 55000230")]
        DregHeapTitaniteScale = 55000230,

        [AnnotationAttribute(Name = "[Dreg Heap] Fading Soul 55000240")]
        DregHeapFadingSoul__ = 55000240,

        [AnnotationAttribute(Name = "[Dreg Heap] Fading Soul 55000250")]
        DregHeapFadingSoul___ = 55000250,

        [AnnotationAttribute(Name = "[Dreg Heap] Fading Soul 55000260")]
        DregHeapFadingSoul____ = 55000260,

        [AnnotationAttribute(Name = "[Dreg Heap] Fading Soul 55000270")]
        DregHeapFadingSoul_____ = 55000270,

        [AnnotationAttribute(Name = "[Dreg Heap] Fading Soul 55000280")]
        DregHeapFadingSoul______ = 55000280,

        [AnnotationAttribute(Name = "[Dreg Heap] Fading Soul 55000290")]
        DregHeapFadingSoul_______ = 55000290,

        [AnnotationAttribute(Name = "[Dreg Heap] Black Firebomb 55000300")]
        DregHeapBlackFirebomb = 55000300,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Chunk 55000310")]
        DregHeapTitaniteChunk___ = 55000310,

        [AnnotationAttribute(Name = "[Dreg Heap] Twinkling Titanite 55000320")]
        DregHeapTwinklingTitanite_ = 55000320,

        [AnnotationAttribute(Name = "[Dreg Heap] Desert Pyromancer Garb 55000330")]
        DregHeapDesertPyromancerGarb = 55000330,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Chunk 55000340")]
        DregHeapTitaniteChunk____ = 55000340,

        [AnnotationAttribute(Name = "[Dreg Heap] Giant Door Shield 55000350")]
        DregHeapGiantDoorShield = 55000350,

        [AnnotationAttribute(Name = "[Dreg Heap] Ember 55000360")]
        DregHeapEmber__ = 55000360,

        [AnnotationAttribute(Name = "[Dreg Heap] Desert Pyromancer Hood 55000370")]
        DregHeapDesertPyromancerHood = 55000370,

        [AnnotationAttribute(Name = "[Dreg Heap] Desert Pyromancer Gloves 55000380")]
        DregHeapDesertPyromancerGloves = 55000380,

        [AnnotationAttribute(Name = "[Dreg Heap] Desert Pyromancer Skirt 55000390")]
        DregHeapDesertPyromancerSkirt = 55000390,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Scale 55000400")]
        DregHeapTitaniteScale_ = 55000400,

        [AnnotationAttribute(Name = "[Dreg Heap] Purple Moss Clump 55000410")]
        DregHeapPurpleMossClump = 55000410,

        [AnnotationAttribute(Name = "[Dreg Heap] Ring of Favor+3 55000420")]
        DregHeapRingOfFavor3 = 55000420,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Chunk 55000430")]
        DregHeapTitaniteChunk_____ = 55000430,

        [AnnotationAttribute(Name = "[Dreg Heap] Large Soul of a Weary Warrior 55000440")]
        DregHeapLargeSoulOfaWearyWarrior_ = 55000440,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Slab 55000450")]
        DregHeapTitaniteSlab = 55000450,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Chunk 55000460")]
        DregHeapTitaniteChunk______ = 55000460,

        [AnnotationAttribute(Name = "[Dreg Heap] Loincloth 55000470")]
        DregHeapLoincloth = 55000470,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Chunk 55000480")]
        DregHeapTitaniteChunk_______ = 55000480,

        [AnnotationAttribute(Name = "[Dreg Heap] Large Soul of a Weary Warrior 55000490")]
        DregHeapLargeSoulOfaWearyWarrior__ = 55000490,

        [AnnotationAttribute(Name = "[Dreg Heap] Harald Curved Greatsword 55000500")]
        DregHeapHaraldCurvedGreatsword = 55000500,

        [AnnotationAttribute(Name = "[Dreg Heap] Homeward Bone 55000510")]
        DregHeapHomewardBone_ = 55000510,

        [AnnotationAttribute(Name = "[Dreg Heap] Prism Stone 55000520")]
        DregHeapPrismStone = 55000520,

        [AnnotationAttribute(Name = "[Dreg Heap] Desert Pyromancer Hood 55000530")]
        DregHeapDesertPyromancerHood_ = 55000530,

        [AnnotationAttribute(Name = "[Dreg Heap] Twinkling Titanite 55000540")]
        DregHeapTwinklingTitanite__ = 55000540,

        [AnnotationAttribute(Name = "[Dreg Heap] Divine Blessing 55000550")]
        DregHeapDivineBlessing_ = 55000550,

        [AnnotationAttribute(Name = "[Dreg Heap] Ember 55000560")]
        DregHeapEmber___ = 55000560,

        [AnnotationAttribute(Name = "[Dreg Heap] Small Envoy Banner 55000600")]
        DregHeapSmallEnvoyBanner = 55000600,

        [AnnotationAttribute(Name = "[Dreg Heap] Titanite Scale 55100000")]
        DregHeapTitaniteScale__ = 55100000,

        [AnnotationAttribute(Name = "[Ringed City] Ruin Helm 55100010")]
        RingedCityRuinHelm = 55100010,

        [AnnotationAttribute(Name = "[Ringed City] Budding Green Blossom 55100020")]
        RingedCityBuddingGreenBlossom = 55100020,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Chunk 55100030")]
        RingedCityTitaniteChunk = 55100030,

        [AnnotationAttribute(Name = "[Ringed City] Ember 55100040")]
        RingedCityEmber = 55100040,

        [AnnotationAttribute(Name = "[Ringed City] Budding Green Blossom 55100050")]
        RingedCityBuddingGreenBlossom_ = 55100050,

        [AnnotationAttribute(Name = "[Ringed City] Hidden Blessing 55100060")]
        RingedCityHiddenBlessing = 55100060,

        [AnnotationAttribute(Name = "[Ringed City] Soul of a Crestfallen Knight 55100070")]
        RingedCitySoulOfaCrestfallenKnight = 55100070,

        [AnnotationAttribute(Name = "[Ringed City] Large Soul of a Weary Warrior 55100080")]
        RingedCityLargeSoulOfaWearyWarrior = 55100080,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100090")]
        RingedCityFadingSoul = 55100090,

        [AnnotationAttribute(Name = "[Ringed City] Soul of a Crestfallen Knight 55100100")]
        RingedCitySoulOfaCrestfallenKnight_ = 55100100,

        [AnnotationAttribute(Name = "[Ringed City] Ember 55100110")]
        RingedCityEmber_ = 55100110,

        [AnnotationAttribute(Name = "[Ringed City] Purging Stone 55100120")]
        RingedCityPurgingStone = 55100120,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100130")]
        RingedCityFadingSoul_ = 55100130,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100140")]
        RingedCityFadingSoul__ = 55100140,

        [AnnotationAttribute(Name = "[Ringed City] Hollow Gem 55100150")]
        RingedCityHollowGem = 55100150,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Chunk 55100160")]
        RingedCityTitaniteChunk_ = 55100160,

        [AnnotationAttribute(Name = "[Ringed City] Twinkling Titanite 55100170")]
        RingedCityTwinklingTitanite = 55100170,

        [AnnotationAttribute(Name = "[Ringed City] Shriving Stone 55100180")]
        RingedCityShrivingStone = 55100180,

        [AnnotationAttribute(Name = "[Ringed City] Shira's Crown 55100190")]
        RingedCityShirasCrown = 55100190,

        [AnnotationAttribute(Name = "[Ringed City] Mossfruit 55100200")]
        RingedCityMossfruit = 55100200,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100210")]
        RingedCityFadingSoul___ = 55100210,

        [AnnotationAttribute(Name = "[Ringed City] Large Soul of a Crestfallen Knight 55100220")]
        RingedCityLargeSoulOfaCrestfallenKnight = 55100220,

        [AnnotationAttribute(Name = "[Ringed City] Ringed Knight Spear 55100230")]
        RingedCityRingedKnightSpear = 55100230,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100240")]
        RingedCityFadingSoul____ = 55100240,

        [AnnotationAttribute(Name = "[Ringed City] Black Witch Hat 55100250")]
        RingedCityBlackWitchHat = 55100250,

        [AnnotationAttribute(Name = "[Ringed City] Dragonhead Shield 55100260")]
        RingedCityDragonheadShield = 55100260,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Chunk 55100270")]
        RingedCityTitaniteChunk__ = 55100270,

        [AnnotationAttribute(Name = "[Ringed City] Mossfruit 55100280")]
        RingedCityMossfruit_ = 55100280,

        [AnnotationAttribute(Name = "[Ringed City] Large Soul of a Crestfallen Knight 55100290")]
        RingedCityLargeSoulOfaCrestfallenKnight_ = 55100290,

        [AnnotationAttribute(Name = "[Ringed City] Covetous Gold Serpent Ring+3 55100300")]
        RingedCityCovetousGoldSerpentRing3 = 55100300,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100310")]
        RingedCityFadingSoul_____ = 55100310,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100320")]
        RingedCityFadingSoul______ = 55100320,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Chunk 55100330")]
        RingedCityTitaniteChunk___ = 55100330,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100340")]
        RingedCityFadingSoul_______ = 55100340,

        [AnnotationAttribute(Name = "[Ringed City] Dark Gem 55100350")]
        RingedCityDarkGem = 55100350,

        [AnnotationAttribute(Name = "[Ringed City] Prism Stone 55100360")]
        RingedCityPrismStone = 55100360,

        [AnnotationAttribute(Name = "[Ringed City] Ringed Knight Straight Sword 55100370")]
        RingedCityRingedKnightStraightSword = 55100370,

        [AnnotationAttribute(Name = "[Ringed City] Havel's Ring+3 55100380")]
        RingedCityHavelsRing3 = 55100380,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Chunk 55100390")]
        RingedCityTitaniteChunk____ = 55100390,

        [AnnotationAttribute(Name = "[Ringed City] Twinkling Titanite 55100400")]
        RingedCityTwinklingTitanite_ = 55100400,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100410")]
        RingedCityFadingSoul________ = 55100410,

        [AnnotationAttribute(Name = "[Ringed City] Soul of a Weary Warrior 55100420")]
        RingedCitySoulOfaWearyWarrior = 55100420,

        [AnnotationAttribute(Name = "[Ringed City] Preacher's Right Arm 55100430")]
        RingedCityPreachersRightArm = 55100430,

        [AnnotationAttribute(Name = "[Ringed City] Rubbish 55100440")]
        RingedCityRubbish = 55100440,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Chunk 55100450")]
        RingedCityTitaniteChunk_____ = 55100450,

        [AnnotationAttribute(Name = "[Ringed City] Black Witch Veil 55100460")]
        RingedCityBlackWitchVeil = 55100460,

        [AnnotationAttribute(Name = "[Ringed City] Church Guardian Shiv 6660")]
        RingedCityChurchGuardianShiv = 6660,

        [AnnotationAttribute(Name = "[Ringed City] Twinkling Titanite 55100480")]
        RingedCityTwinklingTitanite__ = 55100480,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100490")]
        RingedCityFadingSoul_________ = 55100490,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100500")]
        RingedCityFadingSoul__________ = 55100500,

        [AnnotationAttribute(Name = "[Ringed City] Soul of a Crestfallen Knight 55100510")]
        RingedCitySoulOfaCrestfallenKnight__ = 55100510,

        [AnnotationAttribute(Name = "[Ringed City] White Preacher Head 55100520")]
        RingedCityWhitePreacherHead = 55100520,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100530")]
        RingedCityFadingSoul___________ = 55100530,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Scale 55100540")]
        RingedCityTitaniteScale = 55100540,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Scale 55100550")]
        RingedCityTitaniteScale_ = 55100550,

        [AnnotationAttribute(Name = "[Ringed City] Dragonhead Greatshield 55100560")]
        RingedCityDragonheadGreatshield = 55100560,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Scale 55100570")]
        RingedCityTitaniteScale__ = 55100570,

        [AnnotationAttribute(Name = "[Ringed City] Rubbish 55100580")]
        RingedCityRubbish_ = 55100580,

        [AnnotationAttribute(Name = "[Ringed City] Large Soul of a Weary Warrior 55100590")]
        RingedCityLargeSoulOfaWearyWarrior_ = 55100590,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Scale 55100600")]
        RingedCityTitaniteScale___ = 55100600,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Scale 55100610")]
        RingedCityTitaniteScale____ = 55100610,

        [AnnotationAttribute(Name = "[Ringed City] Lightning Gem 55100620")]
        RingedCityLightningGem = 55100620,

        [AnnotationAttribute(Name = "[Ringed City] Blessed Gem 55100630")]
        RingedCityBlessedGem = 55100630,

        [AnnotationAttribute(Name = "[Ringed City] Simple Gem 55100640")]
        RingedCitySimpleGem = 55100640,

        [AnnotationAttribute(Name = "[Ringed City] Large Soul of a Weary Warrior 55100650")]
        RingedCityLargeSoulOfaWearyWarrior__ = 55100650,

        [AnnotationAttribute(Name = "[Ringed City] Lightning Arrow 55100660")]
        RingedCityLightningArrow = 55100660,

        [AnnotationAttribute(Name = "[Ringed City] Chloranthy Ring+3 55100670")]
        RingedCityChloranthyRing3 = 55100670,

        [AnnotationAttribute(Name = "[Ringed City] Ember 55100680")]
        RingedCityEmber__ = 55100680,

        [AnnotationAttribute(Name = "[Ringed City] Filianore's Spear Ornament 55100690")]
        RingedCityFilianoresSpearOrnament = 55100690,

        [AnnotationAttribute(Name = "[Ringed City] Antiquated Plain Garb 55100700")]
        RingedCityAntiquatedPlainGarb = 55100700,

        [AnnotationAttribute(Name = "[Ringed City] Soul of a Weary Warrior 55100710")]
        RingedCitySoulOfaWearyWarrior_ = 55100710,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100720")]
        RingedCityFadingSoul____________ = 55100720,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100730")]
        RingedCityFadingSoul_____________ = 55100730,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100740")]
        RingedCityFadingSoul______________ = 55100740,

        [AnnotationAttribute(Name = "[Ringed City] Twinkling Titanite 55100750")]
        RingedCityTwinklingTitanite___ = 55100750,

        [AnnotationAttribute(Name = "[Ringed City] Ritual Spear Fragment 6835")]
        RingedCityRitualSpearFragment = 6835,

        [AnnotationAttribute(Name = "[Ringed City] Budding Green Blossom 55100770")]
        RingedCityBuddingGreenBlossom__ = 55100770,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100780")]
        RingedCityFadingSoul_______________ = 55100780,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100790")]
        RingedCityFadingSoul________________ = 55100790,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Chunk 55100800")]
        RingedCityTitaniteChunk______ = 55100800,

        [AnnotationAttribute(Name = "[Ringed City] Large Soul of a Weary Warrior 55100810")]
        RingedCityLargeSoulOfaWearyWarrior___ = 55100810,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100820")]
        RingedCityFadingSoul_________________ = 55100820,

        [AnnotationAttribute(Name = "[Ringed City] Soul of a Weary Warrior 55100830")]
        RingedCitySoulOfaWearyWarrior__ = 55100830,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100840")]
        RingedCityFadingSoul__________________ = 55100840,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Scale 55100850")]
        RingedCityTitaniteScale_____ = 55100850,

        [AnnotationAttribute(Name = "[Ringed City] Soul of a Crestfallen Knight 55100860")]
        RingedCitySoulOfaCrestfallenKnight___ = 55100860,

        [AnnotationAttribute(Name = "[Ringed City] White Birch Bow 55100870")]
        RingedCityWhiteBirchBow = 55100870,

        [AnnotationAttribute(Name = "[Ringed City] Titanite Chunk 55100880")]
        RingedCityTitaniteChunk_______ = 55100880,

        [AnnotationAttribute(Name = "[Ringed City] Fading Soul 55100890")]
        RingedCityFadingSoul___________________ = 55100890,

        [AnnotationAttribute(Name = "[Ringed City] Young White Branch 55100900")]
        RingedCityYoungWhiteBranch = 55100900,

        [AnnotationAttribute(Name = "[Ringed City] Young White Branch 55100910")]
        RingedCityYoungWhiteBranch_ = 55100910,

        [AnnotationAttribute(Name = "[Ringed City] Young White Branch 55100920")]
        RingedCityYoungWhiteBranch__ = 55100920,

        [AnnotationAttribute(Name = "[Pus of Man #1] Titanite Shard 53000980")]
        PusOfMan1TitaniteShard = 53000980,

        [AnnotationAttribute(Name = "[Pus of Man #2] Titanite Shard 53000981")]
        PusOfMan2TitaniteShard = 53000981,

        [AnnotationAttribute(Name = "[Cathedral Knight - Oceiros] Magic Stoneplate Ring 53010955")]
        CathedralKnightOceirosMagicStoneplateRing = 53010955,

        [AnnotationAttribute(Name = "[Cathedral Evangelist #4] Dorhys' Gnawing 53700975")]
        CathedralEvangelist4DorhysGnawing = 53700975,

        [AnnotationAttribute(Name = "[Lothric Knight] Raw Gem 53010980")]
        LothricKnightRawGem = 53010980,

        [AnnotationAttribute(Name = "[Winged Knight #3 - Grand Archives] Titanite Slab 53410900")]
        WingedKnight3GrandArchivesTitaniteSlab = 53410900,

        [AnnotationAttribute(Name = "[Boreal Outrider Knight] Outrider Knight Helm 53410905")]
        BorealOutriderKnightOutriderKnightHelm = 53410905,

        [AnnotationAttribute(Name = "[Boreal Outrider Knight] Irithyll Straight Sword 53100980")]
        BorealOutriderKnightIrithyllStraightSword = 53100980,

        [AnnotationAttribute(Name = "[Boreal Outrider Knight] Irithyll Rapier 53010995")]
        BorealOutriderKnightIrithyllRapier = 53010995,

        [AnnotationAttribute(Name = "[Crystal Sage] Crystal Scroll 53410908")]
        CrystalSageCrystalScroll = 53410908,

        [AnnotationAttribute(Name = "[Silver Knight #1] 53700983")]
        SilverKnight1 = 53700983,

        [AnnotationAttribute(Name = "[Silver Knight #2] 53700984")]
        SilverKnight2 = 53700984,

        [AnnotationAttribute(Name = "[Silver Knight #3] 53700985")]
        SilverKnight3 = 53700985,

        [AnnotationAttribute(Name = "[Monstrosity of Sin #3] Eleonora 53900910")]
        MonstrosityOfSin3Eleonora = 53900910,

        [AnnotationAttribute(Name = "[Corpse-grub #2] Great Magic Shield 53900920")]
        Corpsegrub2GreatMagicShield = 53900920,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53500981")]
        MimicSymbolOfAvarice = 53500981,

        [AnnotationAttribute(Name = "[Mimic] Deep Braille Divine Tome 53500980")]
        MimicDeepBrailleDivineTome = 53500980,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53010951")]
        MimicSymbolOfAvarice_ = 53010951,

        [AnnotationAttribute(Name = "[Mimic] Sunlight Straight Sword 53010950")]
        MimicSunlightStraightSword = 53010950,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53010961")]
        MimicSymbolOfAvarice__ = 53010961,

        [AnnotationAttribute(Name = "[Mimic] Titanite Scale 53010960")]
        MimicTitaniteScale = 53010960,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53800945")]
        MimicSymbolOfAvarice___ = 53800945,

        [AnnotationAttribute(Name = "[Mimic] Black Blade 53800940")]
        MimicBlackBlade = 53800940,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53900941")]
        MimicSymbolOfAvarice____ = 53900941,

        [AnnotationAttribute(Name = "[Mimic] Dragonslayer Lightning Arrow 53900940")]
        MimicDragonslayerLightningArrow = 53900940,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53900951")]
        MimicSymbolOfAvarice_____ = 53900951,

        [AnnotationAttribute(Name = "[Mimic] Titanite Scale 53900950")]
        MimicTitaniteScale_ = 53900950,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53900961")]
        MimicSymbolOfAvarice______ = 53900961,

        [AnnotationAttribute(Name = "[Mimic] Rusted Gold Coin 53900960")]
        MimicRustedGoldCoin = 53900960,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53900971")]
        MimicSymbolOfAvarice_______ = 53900971,

        [AnnotationAttribute(Name = "[Mimic] Court Sorcerer's Staff 53900970")]
        MimicCourtSorcerersStaff = 53900970,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53900981")]
        MimicSymbolOfAvarice________ = 53900981,

        [AnnotationAttribute(Name = "[Mimic] Greatshield of Glory 53900980")]
        MimicGreatshieldOfGlory = 53900980,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53900996")]
        MimicSymbolOfAvarice_________ = 53900996,

        [AnnotationAttribute(Name = "[Mimic] Estus Shard 53900995")]
        MimicEstusShard = 53900995,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53900991")]
        MimicSymbolOfAvarice__________ = 53900991,

        [AnnotationAttribute(Name = "[Mimic] Dark Clutch Ring 53900990")]
        MimicDarkClutchRing = 53900990,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53700981")]
        MimicSymbolOfAvarice___________ = 53700981,

        [AnnotationAttribute(Name = "[Mimic] Golden Ritual Spear 53700980")]
        MimicGoldenRitualSpear = 53700980,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 53000961")]
        MimicSymbolOfAvarice____________ = 53000961,

        [AnnotationAttribute(Name = "[Mimic] Deep Battle Axe 53000960")]
        MimicDeepBattleAxe = 53000960,

        [AnnotationAttribute(Name = "[Mimic] Symbol of Avarice 55100985")]
        MimicSymbolOfAvarice_____________ = 55100985,

        [AnnotationAttribute(Name = "[Mimic] Ring of the Evil Eye +3 55100986")]
        MimicRingOfTheEvilEye3 = 55100986,

        [AnnotationAttribute(Name = "[Yellowfinger Heysel] Heysel Pick 53500960")]
        YellowfingerHeyselHeyselPick_ = 53500960,

        [AnnotationAttribute(Name = "Red Sign Soapstone 6781")]
        RedSignSoapstone = 6781,

        [AnnotationAttribute(Name = "[Carthus Sandworm] Lightning Stake 53800941")]
        CarthusSandwormLightningStake = 53800941,

        [AnnotationAttribute(Name = "[Jailer #2] Jailer's Key Ring 53900930")]
        Jailer2JailersKeyRing = 53900930,

        [AnnotationAttribute(Name = "[Sulyvahn's Beast #1] Pontiff's Right Eye 53700995")]
        SulyvahnsBeast1PontiffsRightEye = 53700995,

        [AnnotationAttribute(Name = "[Sulyvahn's Beast #2] Ring of Favor 53700990")]
        SulyvahnsBeast2RingOfFavor = 53700990,

        [AnnotationAttribute(Name = "[Great Crab - Road of Sacrifices] Great Swamp Ring 53300990")]
        GreatCrabRoadOfSacrificesGreatSwampRing = 53300990,

        [AnnotationAttribute(Name = "[Great Crab - Farron Keep] Lingering Dragoncrest Ring 53300991")]
        GreatCrabFarronKeepLingeringDragoncrestRing = 53300991,

        [AnnotationAttribute(Name = "[Giant Rat] Bloodbite Ring 53100228")]
        GiantRatBloodbiteRing = 53100228,

        [AnnotationAttribute(Name = "[Demon] Fire Gem 53100985")]
        DemonFireGem = 53100985,

        [AnnotationAttribute(Name = "[Elder Ghru #3] Pharis's Hat 53300995")]
        ElderGhru3PharissHat = 53300995,

        [AnnotationAttribute(Name = "[Elder Ghru #4] Black Bow of Pharis 53300996")]
        ElderGhru4BlackBowOfPharis = 53300996,

        [AnnotationAttribute(Name = "[Ancient Wyvern] Large Titanite Shard 53000985")]
        AncientWyvernLargeTitaniteShard = 53000985,

        [AnnotationAttribute(Name = "[Ancient Wyvern] Titanite Chunk 53010990")]
        AncientWyvernTitaniteChunk = 53010990,

        [AnnotationAttribute(Name = "[Ancient Wyvern] Titanite Chunk 53010991")]
        AncientWyvernTitaniteChunk_ = 53010991,

        [AnnotationAttribute(Name = "[Dragonslayer Armour] Iron Dragonslayer Helm 55100987")]
        DragonslayerArmourIronDragonslayerHelm = 55100987,

        [AnnotationAttribute(Name = "[Deacon #1 - Irithyll] Deep Ring 53500970")]
        Deacon1IrithyllDeepRing = 53500970,

        [AnnotationAttribute(Name = "Green Blossom 53400040")]
        GreenBlossom = 53400040,
    }
}
