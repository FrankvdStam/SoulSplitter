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

using System.ComponentModel.DataAnnotations;

namespace SoulMemory.EldenRing
{
    public enum ItemPickup : uint
    {
        [Display(Name = "Flask of Crimson Tears 60000")]
        FlaskOfCrimsonTears = 60000,

        [Display(Name = "Roped Fire Pot 500010")]
        RopedFirePot = 500010,

        [Display(Name = "Small Golden Effigy 60230")]
        SmallGoldenEffigy = 60230,

        [Display(Name = "Flask of Wondrous Physick 6700")]
        FlaskOfWondrousPhysick = 6700,

        [Display(Name = "Baldachin's Blessing 0")]
        BaldachinsBlessing = 0,

        [Display(Name = "Mending Rune of Perfect Order 9500")]
        MendingRuneOfPerfectOrder = 9500,

        [Display(Name = "Mending Rune of the Death-Prince 9502")]
        MendingRuneOfTheDeathPrince = 9502,

        [Display(Name = "Mending Rune of the Fell Curse 9504")]
        MendingRuneOfTheFellCurse = 9504,

        [Display(Name = "[Stormveil - Margit] Talisman Pouch 60510")]
        StormveilMargitTalismanPouch = 60510,

        [Display(Name = "[Stormveil - Godrick] Godrick's Great Rune 171")]
        StormveilGodrickGodricksGreatRune = 171,

        [Display(Name = "[Stormveil - Godrick] Remembrance of the Grafted 510010")]
        StormveilGodrickRemembranceOfTheGrafted = 510010,

        [Display(Name = "[Chapel of Anticipation - Grafed Scion] Ornamental Straight Sword 510030")]
        ChapelOfAnticipationGrafedScionOrnamentalStraightSword = 510030,

        [Display(Name = "[Leyndell - Morgott] Remembrance of the Omen King 510040")]
        LeyndellMorgottRemembranceOfTheOmenKing = 510040,

        [Display(Name = "[Leyndell - Morgott] Morgott's Great Rune 173")]
        LeyndellMorgottMorgottsGreatRune = 173,

        [Display(Name = "[Enia - 2 Great Runes] Talisman Pouch 60520")]
        Enia2GreatRunesTalismanPouch = 60520,

        [Display(Name = "[Ashen Leyndell - Gideon] Scepter of the All-Knowing 510060")]
        AshenLeyndellGideonScepterOfTheAllKnowing = 510060,

        [Display(Name = "[Ashen Leyndell - Hoarah Loux] Remembrance of Hoarah Loux 510070")]
        AshenLeyndellHoarahLouxRemembranceOfHoarahLoux = 510070,

        [Display(Name = "[Lake or Rot - Astel] Remembrance of the Naturalborn 510080")]
        LakeorRotAstelRemembranceOfTheNaturalborn = 510080,

        [Display(Name = "[Ainsel - Dragonkin Soldier] Frozen Lightning Spear 510090")]
        AinselDragonkinSoldierFrozenLightningSpear = 510090,

        [Display(Name = "[Siofra - Valiant Gargoyle] Gargoyle's Greatsword 510100")]
        SiofraValiantGargoyleGargoylesGreatsword = 510100,

        [Display(Name = "[Deeproot Depths - Fortissax] Remembrance of the Lichdragon 510110")]
        DeeprootDepthsFortissaxRemembranceOfTheLichdragon = 510110,

        [Display(Name = "[Mohgwyn Palace - Mohg] Remembrance of the Blood Lord 510120")]
        MohgwynPalaceMohgRemembranceOfTheBloodLord = 510120,

        [Display(Name = "[Mohgwyn Palace - Mohg] Mohg's Great Rune 175")]
        MohgwynPalaceMohgMohgsGreatRune = 175,

        [Display(Name = "[Farum Azula - Godskin Duo] Smithing-Stone Miner's Bell Bearing [4] 510140")]
        FarumAzulaGodskinDuoSmithingStoneMinersBellBearing4 = 510140,

        [Display(Name = "[Farum Azula - Dragonlord Placidusax] Remembrance of the Dragonlord 510150")]
        FarumAzulaDragonlordPlacidusaxRemembranceOfTheDragonlord = 510150,

        [Display(Name = "[Farum Azula - Maliketh] Remembrance of the Black Blade 510160")]
        FarumAzulaMalikethRemembranceOfTheBlackBlade = 510160,

        [Display(Name = "[Raya Lucaria - Red Wolf of Radagon] Memory Stone 60440")]
        RayaLucariaRedWolfOfRadagonMemoryStone = 60440,

        [Display(Name = "[Raya Lucaria - Rennala] Remembrance of the Full Moon Queen 197")]
        RayaLucariaRennalaRemembranceOfTheFullMoonQueen = 197,

        [Display(Name = "[Raya Lucaria - Rennala] None 177")]
        RayaLucariaRennalaNone = 177,

        [Display(Name = "[Haligtree - Loretta] Loretta's Mastery 510190")]
        HaligtreeLorettaLorettasMastery = 510190,

        [Display(Name = "[Haligtree - Malenia] Remembrance of the Rot Goddess 510200")]
        HaligtreeMaleniaRemembranceOfTheRotGoddess = 510200,

        [Display(Name = "[Haligtree - Malenia] Malenia's Great Rune 176")]
        HaligtreeMaleniaMaleniasGreatRune = 176,

        [Display(Name = "[Volcano Manor - Godskin Noble] Godskin Stitcher 510210")]
        VolcanoManorGodskinNobleGodskinStitcher = 510210,

        [Display(Name = "[Mt. Gelmir - Rykard] Remembrance of the Blasphemous 510220")]
        MtGelmirRykardRemembranceOfTheBlasphemous = 510220,

        [Display(Name = "[Mt. Gelmir - Rykard] Rykard's Great Rune 174")]
        MtGelmirRykardRykardsGreatRune = 174,

        [Display(Name = "[Erdtree - Elden Beast] Elden Remembrance 510230")]
        ErdtreeEldenBeastEldenRemembrance = 510230,

        [Display(Name = "[Mohgwyn Palace - Mohg] Bloodflame Talons 510250")]
        MohgwynPalaceMohgBloodflameTalons = 510250,

        [Display(Name = "[Ruin-Strewn Precipice - Magma Wyrm Makar] Magma Wyrm's Scalesword 510260")]
        RuinStrewnPrecipiceMagmaWyrmMakarMagmaWyrmsScalesword = 510260,

        [Display(Name = "[Fringefolk Hero's Grave - Ulcerated Tree Spirit] Golden Seed 510280")]
        FringefolkHerosGraveUlceratedTreeSpiritGoldenSeed = 510280,

        [Display(Name = "[Volcano Manor - Abducator Virgins] Inquisitor's Girandole 510290")]
        VolcanoManorAbducatorVirginsInquisitorsGirandole = 510290,

        [Display(Name = "[Caelid - Radahn] Remembrance of the Starscourge 510300")]
        CaelidRadahnRemembranceOfTheStarscourge = 510300,

        [Display(Name = "[Caelid - Radahn] Radahn's Great Rune 172")]
        CaelidRadahnRadahnsGreatRune = 172,

        [Display(Name = "[Mountaintops - Fire Giant] Remembrance of the Fire Giant 510310")]
        MountaintopsFireGiantRemembranceOfTheFireGiant = 510310,

        [Display(Name = "[Siofra - Ancestor Spirit] Ancestral Follower Ashes 510320")]
        SiofraAncestorSpiritAncestralFollowerAshes = 510320,

        [Display(Name = "[Nokron - Regal Ancestor Spirit] Remembrance of the Regal Ancestor 510330")]
        NokronRegalAncestorSpiritRemembranceOfTheRegalAncestor = 510330,

        [Display(Name = "[Nokron - Mimic Tear] Larval Tear 510340")]
        NokronMimicTearLarvalTear = 510340,

        [Display(Name = "[Deeproot Depths - Fia's Champions] Fia's Mist 510350")]
        DeeprootDepthsFiasChampionsFiasMist = 510350,

        [Display(Name = "[Mountaintops - Sanguine Noble] Sanguine Noble Hood 510730")]
        MountaintopsSanguineNobleSanguineNobleHood = 510730,

        [Display(Name = "[Capital Outskirts - Fell Twins] Omenkiller Rollo 510740")]
        CapitalOutskirtsFellTwinsOmenkillerRollo = 510740,

        [Display(Name = "[Weeping Penisula - Leonine Misbegotten] Blade Greatsword 510800")]
        WeepingPenisulaLeonineMisbegottenBladeGreatsword = 510800,

        [Display(Name = "[Caria Manor - Loretta] Loretta's Greatbow 510810")]
        CariaManorLorettaLorettasGreatbow = 510810,

        [Display(Name = "[Shaded Castle - Elemer of the Briar] Marais Executioner's Sword 510820")]
        ShadedCastleElemerOfTheBriarMaraisExecutionersSword = 510820,

        [Display(Name = "[Redmane Castle - Misbegotten Warrior/Crucible Knight] Ruins Greatsword 510830")]
        RedmaneCastleMisbegottenWarriorCrucibleKnightRuinsGreatsword = 510830,

        [Display(Name = "[Castle Sol - Commander Niall] Veteran's Prosthesis 510840")]
        CastleSolCommanderNiallVeteransProsthesis = 510840,

        [Display(Name = "[Tombsward Catacombs - Cemetery Shade] Lhutel the Headless 520000")]
        TombswardCatacombsCemeteryShadeLhutelTheHeadless = 520000,

        [Display(Name = "[Impaler's Catacombs - Erdtree Burial Watchdog] Demi-Human Ashes 520010")]
        ImpalersCatacombsErdtreeBurialWatchdogDemiHumanAshes = 520010,

        [Display(Name = "[Stormfoot Catacombs - Erdtree Burial Watchdog] Noble Sorcerer Ashes 520020")]
        StormfootCatacombsErdtreeBurialWatchdogNobleSorcererAshes = 520020,

        [Display(Name = "[Deathtouched Catacombs - Black Knife Assassin] Assassin's Crimson Dagger 520030")]
        DeathtouchedCatacombsBlackKnifeAssassinAssassinsCrimsonDagger = 520030,

        [Display(Name = "[Murkwater Catacombs - Grave Warden Duelist] Battle Hammer 520040")]
        MurkwaterCatacombsGraveWardenDuelistBattleHammer = 520040,

        [Display(Name = "[Black Knife Catacombs - Cemetery Shade] Twinsage Sorcerer Ashes 520050")]
        BlackKnifeCatacombsCemeteryShadeTwinsageSorcererAshes = 520050,

        [Display(Name = "[Road's End Catacombs - Spirit-caller Snail] Glintstone Sorcerer Ashes 520060")]
        RoadsEndCatacombsSpiritcallerSnailGlintstoneSorcererAshes = 520060,

        [Display(Name = "[Cliffbottom Catacombs - Erdtree Burial Watchdog] Kaiden Sellsword Ashes 520070")]
        CliffbottomCatacombsErdtreeBurialWatchdogKaidenSellswordAshes = 520070,

        [Display(Name = "[Sainted Hero's Grave - Leyndell] Ancient Dragon Knight Kristoff 520080")]
        SaintedHerosGraveLeyndellAncientDragonKnightKristoff = 520080,

        [Display(Name = "[Gelmir's Heo's Grave - Mt. Gelmir] Bloodhound Knight Floh 520090")]
        GelmirsHeosGraveMtGelmirBloodhoundKnightFloh = 520090,

        [Display(Name = "[Auriza Hero's Grave - Crucible Knigh Ordovis] Ordovis's Greatsword 520100")]
        AurizaHerosGraveCrucibleKnighOrdovisOrdovissGreatsword = 520100,

        [Display(Name = "[Unslightly Catacombs - Perfumer Tricia] Perfumer Tricia 520110")]
        UnslightlyCatacombsPerfumerTriciaPerfumerTricia = 520110,

        [Display(Name = "[Wyndham Catacombs - Erdtree Burial Watchdog] Glovewort Picker's Bell Bearing [1] 520120")]
        WyndhamCatacombsErdtreeBurialWatchdogGlovewortPickersBellBearing1 = 520120,

        [Display(Name = "[Auriza Side Tomb - Grave Warden Duelist] Soldjars of Fortune Ashes 520130")]
        AurizaSideTombGraveWardenDuelistSoldjarsOfFortuneAshes = 520130,

        [Display(Name = "[Minor Erdtree Catacombs - Erdtree Burial Watchdog] Mad Pumpkin Head Ashes 520140")]
        MinorErdtreeCatacombsErdtreeBurialWatchdogMadPumpkinHeadAshes = 520140,

        [Display(Name = "[Caelid Catacombs - Cemetery Shade] Kindred of Rot Ashes 520150")]
        CaelidCatacombsCemeteryShadeKindredOfRotAshes = 520150,

        [Display(Name = "[War-Dead Catacombs - Putrid Tree Spirit] Redmane Knight Ogha 520160")]
        WarDeadCatacombsPutridTreeSpiritRedmaneKnightOgha = 520160,

        [Display(Name = "[Giant-Conquering Hero's Grave - Ancient Hero of Zamor] Zamor Curved Sword 520170")]
        GiantConqueringHerosGraveAncientHeroOfZamorZamorCurvedSword = 520170,

        [Display(Name = "[Giants' Mountaintop Catacombs - Ulcerated Tree Spirit] Golden Seed 520180")]
        GiantsMountaintopCatacombsUlceratedTreeSpiritGoldenSeed = 520180,

        [Display(Name = "[Consecrated Snowfiled Catacombs - Putrid Grave Warden Duelist] Great Grave Glovewort 520190")]
        ConsecratedSnowfiledCatacombsPutridGraveWardenDuelistGreatGraveGlovewort = 520190,

        [Display(Name = "[Hidden Path ot the Haligtree - Stray Mimic Tear] Blackflame Monk Amon 520200")]
        HiddenPathotTheHaligtreeStrayMimicTearBlackflameMonkAmon = 520200,

        [Display(Name = "[Black Knife Catacombs - Black Knife Assassin] Assassin's Cerulean Dagger 520210")]
        BlackKnifeCatacombsBlackKnifeAssassinAssassinsCeruleanDagger = 520210,

        [Display(Name = "[Leyndell Catacombs - Esgar, Priest of Blood] Lord of Blood's Exultation 520220")]
        LeyndellCatacombsEsgarPriestOfBloodLordOfBloodsExultation = 520220,

        [Display(Name = "[Tombsward Cave - Miranda the Blighted Bloom] Viridian Amber Medallion 520300")]
        TombswardCaveMirandaTheBlightedBloomViridianAmberMedallion = 520300,

        [Display(Name = "[Earthbore Cave - Runebear] Spelldrake Talisman 520310")]
        EarthboreCaveRunebearSpelldrakeTalisman = 520310,

        [Display(Name = "[Groveside Cave - Beastman of Farum Azula] Flamedrake Talisman 520330")]
        GrovesideCaveBeastmanOfFarumAzulaFlamedrakeTalisman = 520330,

        [Display(Name = "[Coastal Cave - Demi-Human Chief] Sewing Needle 520340")]
        CoastalCaveDemiHumanChiefSewingNeedle = 520340,

        [Display(Name = "[Coastal Cave - Demi-Human Chief] Tailoring Tools 60140")]
        CoastalCaveDemiHumanChiefTailoringTools = 60140,

        [Display(Name = "[Highroad Cave - Guardian Golem] Blue Dancer Charm 520350")]
        HighroadCaveGuardianGolemBlueDancerCharm = 520350,

        [Display(Name = "[Stillwater Cave - Cleanrot Knight] Winged Sword Insignia 520360")]
        StillwaterCaveCleanrotKnightWingedSwordInsignia = 520360,

        [Display(Name = "[Lakeside Crystal Cave - Bloodhound Knight] Cerulean Amber Medallion 520370")]
        LakesideCrystalCaveBloodhoundKnightCeruleanAmberMedallion = 520370,

        [Display(Name = "[Academy Crystal Cave - Crystalians] Crystal Release 520380")]
        AcademyCrystalCaveCrystaliansCrystalRelease = 520380,

        [Display(Name = "[Seethewater Cave - Kindred of Rot] Kindred of Rot's Exultation 520390")]
        SeethewaterCaveKindredOfRotKindredOfRotsExultation = 520390,

        [Display(Name = "[Volcano Cave - Demi-human Queen Margot] Jar Cannon 520400")]
        VolcanoCaveDemihumanQueenMargotJarCannon = 520400,

        [Display(Name = "[Omenkiller - Perfumer's Grotto] Great Omenkiller Cleaver 520410")]
        OmenkillerPerfumersGrottoGreatOmenkillerCleaver = 520410,

        [Display(Name = "[Sage's Cave - Black Knife Assassin] Concealing Veil 520420")]
        SagesCaveBlackKnifeAssassinConcealingVeil = 520420,

        [Display(Name = "[Goal Cave - Frenzied Duelist] Putrid Corpse Ashes 520430")]
        GoalCaveFrenziedDuelistPutridCorpseAshes = 520430,

        [Display(Name = "[Dragonbarrow Cave - Beastman of Farum Azula] Flamedrake Talisman +2 520440")]
        DragonbarrowCaveBeastmanOfFarumAzulaFlamedrakeTalisman2 = 520440,

        [Display(Name = "[Abandoned Cave - Cleanrot Knight Duo] Gold Scarab 520450")]
        AbandonedCaveCleanrotKnightDuoGoldScarab = 520450,

        [Display(Name = "[Sellia Hideaway - Putrid Crystalians] Crystal Torrent 520460")]
        SelliaHideawayPutridCrystaliansCrystalTorrent = 520460,

        [Display(Name = "[Cave of the Forlorn - Misbegotten Crusader] Golden Order Greatsword 520470")]
        CaveOfTheForlornMisbegottenCrusaderGoldenOrderGreatsword = 520470,

        [Display(Name = "[Spiritcaller's Cave - Godskin Apostle/Noble] Godskin Swaddling Cloth 520480")]
        SpiritcallersCaveGodskinApostleNobleGodskinSwaddlingCloth = 520480,

        [Display(Name = "[Sage's Cave - Necromancer Garris] Family Heads 520490")]
        SagesCaveNecromancerGarrisFamilyHeads = 520490,

        [Display(Name = "[Morne Tunnel - Scaly Misbegotten] Rusted Anchor 520600")]
        MorneTunnelScalyMisbegottenRustedAnchor = 520600,

        [Display(Name = "[Limgrave Tunnels - Stonedigger Troll] Roar Medallion 520610")]
        LimgraveTunnelsStonediggerTrollRoarMedallion = 520610,

        [Display(Name = "[Raya Lucaria Crystal Tunnel - Crystalian] Smithing-Stone Miner's Bell Bearing [1] 520620")]
        RayaLucariaCrystalTunnelCrystalianSmithingStoneMinersBellBearing1 = 520620,

        [Display(Name = "[Old Altus Tunnel - Stonedigger Troll] Great Club 520630")]
        OldAltusTunnelStonediggerTrollGreatClub = 520630,

        [Display(Name = "[Sealed Tunnel - Onyx Lord] Onyx Lord's Greatsword 520640")]
        SealedTunnelOnyxLordOnyxLordsGreatsword = 520640,

        [Display(Name = "[Altus Tunnel - Crystalians] Somberstone Miner's Bell Bearing [2] 520650")]
        AltusTunnelCrystaliansSomberstoneMinersBellBearing2 = 520650,

        [Display(Name = "[Gael Tunnel - Magma Wyrm] Dragon Heart 520660")]
        GaelTunnelMagmaWyrmDragonHeart = 520660,

        [Display(Name = "[Sellia Crystal Tunnel - Fallingstar Beast] Somber Smithing Stone [6] 520670")]
        SelliaCrystalTunnelFallingstarBeastSomberSmithingStone6 = 520670,

        [Display(Name = "[Yelough Anix Tunnel - Astel] Meteorite of Astel 520680")]
        YeloughAnixTunnelAstelMeteoriteOfAstel = 520680,

        [Display(Name = "[Limgrave - Field - Tree Sentinel] Golden Halberd 530100")]
        LimgraveFieldTreeSentinelGoldenHalberd = 530100,

        [Display(Name = "[Limgrave - Field - Flying Dragon Agheel] Dragon Heart 530110")]
        LimgraveFieldFlyingDragonAgheelDragonHeart = 530110,

        [Display(Name = "[Limgrave - Evergaol - Crucible Knight] Aspects of the Crucible: Tail 530120")]
        LimgraveEvergaolCrucibleKnightAspectsOfTheCrucibleTail = 530120,

        [Display(Name = "[Limgrave - Evergaol - Bloodhound Knight Darriwil] Bloodhound's Fang 530130")]
        LimgraveEvergaolBloodhoundKnightDarriwilBloodhoundsFang = 530130,

        [Display(Name = "[Limgrave - Field - Tibia Mariner] Deathroot 530170")]
        LimgraveFieldTibiaMarinerDeathroot = 530170,

        [Display(Name = "[Weeping Penisula - Field - Erdtree Avatar] Crimsonburst Crystal Tear 65090")]
        WeepingPenisulaFieldErdtreeAvatarCrimsonburstCrystalTear = 65090,

        [Display(Name = "[Weeping Penisula - Field - Erdtree Avatar] Opaline Bubbletear 65080")]
        WeepingPenisulaFieldErdtreeAvatarOpalineBubbletear = 65080,

        [Display(Name = "[Liurnia - Field - Erdtree Avatar] Magic-Shrouding Cracked Tear 65290")]
        LiurniaFieldErdtreeAvatarMagicShroudingCrackedTear = 65290,

        [Display(Name = "[Liurnia - Field - Erdtree Avatar] Lightning-Shrouding Cracked Tear 65300")]
        LiurniaFieldErdtreeAvatarLightningShroudingCrackedTear = 65300,

        [Display(Name = "[Liurnia - Field - Erdtree Avatar] Holy-Shrouding Cracked Tear 65310")]
        LiurniaFieldErdtreeAvatarHolyShroudingCrackedTear = 65310,

        [Display(Name = "[Liurnia - Field - Erdtree Avatar] Cerulean Crystal Tear 65040")]
        LiurniaFieldErdtreeAvatarCeruleanCrystalTear = 65040,

        [Display(Name = "[Liurnia - Field - Erdtree Avatar] Ruptured Crystal Tear 65160")]
        LiurniaFieldErdtreeAvatarRupturedCrystalTear = 65160,

        [Display(Name = "[Liurnia - Field - Glintstone Dragon Smarag] Dragon Heart 530210")]
        LiurniaFieldGlintstoneDragonSmaragDragonHeart = 530210,

        [Display(Name = "[Liurnia - Field - Omenkiller] Crucible Knot Talisman 530225")]
        LiurniaFieldOmenkillerCrucibleKnotTalisman = 530225,

        [Display(Name = "[Liurnia - Field - Tibia Mariner] Deathroot 530240")]
        LiurniaFieldTibiaMarinerDeathroot = 530240,

        [Display(Name = "[Liurnia - Evergaol - Adan, Thief of Fire] Flame of the Fell God 530245")]
        LiurniaEvergaolAdanThiefOfFireFlameOfTheFellGod = 530245,

        [Display(Name = "[Liurnia - Evergaol - Bols, Carian Knight] Greatblade Phalanx 530250")]
        LiurniaEvergaolBolsCarianKnightGreatbladePhalanx = 530250,

        [Display(Name = "[Liurnia - Evergaol - Onyx Lord] Meteorite 530255")]
        LiurniaEvergaolOnyxLordMeteorite = 530255,

        [Display(Name = "[Liurnia - Field - Glintstone Dragon Adula] Dragon Heart 530260")]
        LiurniaFieldGlintstoneDragonAdulaDragonHeart = 530260,

        [Display(Name = "[Liurnia - Evergaol - Alecto, Black Knife Ringleader] Black Knife Tiche 530265")]
        LiurniaEvergaolAlectoBlackKnifeRingleaderBlackKnifeTiche = 530265,

        [Display(Name = "[Altus Plateau - Field - Ancient Dragon Lansseax] Lansseax's Glaive 530300")]
        AltusPlateauFieldAncientDragonLansseaxLansseaxsGlaive = 530300,

        [Display(Name = "[Altus Plateau - Field - Fallingstar Beast] Somber Smithing Stone [5] 530310")]
        AltusPlateauFieldFallingstarBeastSomberSmithingStone5 = 530310,

        [Display(Name = "[Capital Outskirts - Field - Draconic Tree Sentinel] Dragon Greatclaw 530315")]
        CapitalOutskirtsFieldDraconicTreeSentinelDragonGreatclaw = 530315,

        [Display(Name = "[Altus Plateau - Field - Wormface] Speckled Hardtear 65060")]
        AltusPlateauFieldWormfaceSpeckledHardtear = 65060,

        [Display(Name = "[Altus Plateau - Field - Wormface] Crimsonspill Crystal Tear 65000")]
        AltusPlateauFieldWormfaceCrimsonspillCrystalTear = 65000,

        [Display(Name = "[Altus Plateau - Field - Godskin Apostle] Godskin Peeler 530325")]
        AltusPlateauFieldGodskinApostleGodskinPeeler = 530325,

        [Display(Name = "[Capital Outskirts - Field - Tree Sentinel Duo] Erdtree Greatshield 530335")]
        CapitalOutskirtsFieldTreeSentinelDuoErdtreeGreatshield = 530335,

        [Display(Name = "[Altus Plateau - Field - Black Knife Assassin] Black Knife 530350")]
        AltusPlateauFieldBlackKnifeAssassinBlackKnife = 530350,

        [Display(Name = "[Mt. Gelmir - Field - Full-grown Fallingstar Beast] Somber Smithing Stone [6] 530375")]
        MtGelmirFieldFullgrownFallingstarBeastSomberSmithingStone6 = 530375,

        [Display(Name = "[Mt. Gelmir - Field - Ulcerated Tree Spirit] Leaden Hardtear 65180")]
        MtGelmirFieldUlceratedTreeSpiritLeadenHardtear = 65180,

        [Display(Name = "[Mt. Gelmir - Field - Ulcerated Tree Spirit] Cerulean Hidden Tear 65250")]
        MtGelmirFieldUlceratedTreeSpiritCeruleanHiddenTear = 65250,

        [Display(Name = "[Altus Plateau - Field - Tibia Mariner] Deathroot 530385")]
        AltusPlateauFieldTibiaMarinerDeathroot = 530385,

        [Display(Name = "[Mt. Gelmir - Field - Magma Wyrm] Dragon Heart 530390")]
        MtGelmirFieldMagmaWyrmDragonHeart = 530390,

        [Display(Name = "[Mt. Gelmir - Field - Demi-Human Queen Maggie] Memory Stone 60450")]
        MtGelmirFieldDemiHumanQueenMaggieMemoryStone = 60450,

        [Display(Name = "[Mt. Gelmir - Field - Magma Wyrm] Dragon Heart 530400")]
        MtGelmirFieldMagmaWyrmDragonHeart_ = 530400,

        [Display(Name = "[Caelid - Field - Commander O'Neil] Commander's Standard 530405")]
        CaelidFieldCommanderONeilCommandersStandard = 530405,

        [Display(Name = "[Caelid - Field - Erdtree Avatar] Greenburst Crystal Tear 65100")]
        CaelidFieldErdtreeAvatarGreenburstCrystalTear = 65100,

        [Display(Name = "[Caelid - Field - Erdtree Avatar] Flame-Shrouding Cracked Tear 65280")]
        CaelidFieldErdtreeAvatarFlameShroudingCrackedTear = 65280,

        [Display(Name = "[Caelid - Field - Putrid Avatar] Opaline Hardtear 65110")]
        CaelidFieldPutridAvatarOpalineHardtear = 65110,

        [Display(Name = "[Caelid - Field - Putrid Avatar] Stonebarb Cracked Tear 65260")]
        CaelidFieldPutridAvatarStonebarbCrackedTear = 65260,

        [Display(Name = "[Caelid - Field - Flying Dragon Greyll] Dragon Heart 530420")]
        CaelidFieldFlyingDragonGreyllDragonHeart = 530420,

        [Display(Name = "[Caelid - Field - Blade Blade Kindred] Gargoyle's Blackblade 530425")]
        CaelidFieldBladeBladeKindredGargoylesBlackblade = 530425,

        [Display(Name = "[Forbidden Lands - Field - Black Blade Kindred] Gargoyle's Black Blades 530505")]
        ForbiddenLandsFieldBlackBladeKindredGargoylesBlackBlades = 530505,

        [Display(Name = "[Mountaintops of the Giants - Field - Borealis, the Freezing Fog] Dragon Heart 530510")]
        MountaintopsOfTheGiantsFieldBorealisTheFreezingFogDragonHeart = 530510,

        [Display(Name = "[Mountaintops of the Giants - Evergaol - Roundtable Knight Vyke] Vyke's Dragonbolt 530515")]
        MountaintopsOfTheGiantsEvergaolRoundtableKnightVykeVykesDragonbolt = 530515,

        [Display(Name = "[Mountaintops of the Giants - Field - Erdtree Avatar] Cerulean Crystal Tear 65050")]
        MountaintopsOfTheGiantsFieldErdtreeAvatarCeruleanCrystalTear = 65050,

        [Display(Name = "[Mountaintops of the Giants - Field - Erdtree Avatar] Crimson Bubbletear 65070")]
        MountaintopsOfTheGiantsFieldErdtreeAvatarCrimsonBubbletear = 65070,

        [Display(Name = "[Mountaintops of the Giants - Field - Death Rite Bird] Death Ritual Spear 530530")]
        MountaintopsOfTheGiantsFieldDeathRiteBirdDeathRitualSpear = 530530,

        [Display(Name = "[Mountaintops of the Giants - Field - Great Wyrm Theodorix] Dragon Heart 530550")]
        MountaintopsOfTheGiantsFieldGreatWyrmTheodorixDragonHeart = 530550,

        [Display(Name = "[Consecrated Snowfield - Field - Putrid Avatar] Thorny Cracked Tear 65130")]
        ConsecratedSnowfieldFieldPutridAvatarThornyCrackedTear = 65130,

        [Display(Name = "[Consecrated Snowfield - Field - Putrid Avatar] Ruptured Crystal Tear 65170")]
        ConsecratedSnowfieldFieldPutridAvatarRupturedCrystalTear = 65170,

        [Display(Name = "[Lake of Rot - Dragonkin Soldier] Dragonscale Blade 530600")]
        LakeOfRotDragonkinSoldierDragonscaleBlade = 530600,

        [Display(Name = "[Siofra River - Dragonkin Soldier] Dragon Halberd 530620")]
        SiofraRiverDragonkinSoldierDragonHalberd = 530620,

        [Display(Name = "[Teardrop Scarab - Stormhill] Ash of War: Storm Wall 540100")]
        TeardropScarabStormhillAshOfWarStormWall = 540100,

        [Display(Name = "[Teardrop Scarab - Stormhill] Ash of War: Wild Strikes 540104")]
        TeardropScarabStormhillAshOfWarWildStrikes = 540104,

        [Display(Name = "[Teardrop Scarab - Agheel Lake] Ash of War: Determination 540108")]
        TeardropScarabAgheelLakeAshOfWarDetermination = 540108,

        [Display(Name = "[Teardrop Scarab - Agheel Lake] Ash of War: Unsheathe 540112")]
        TeardropScarabAgheelLakeAshOfWarUnsheathe = 540112,

        [Display(Name = "[Teardrop Scarab - Mistwood] Ash of War: Ground Slam 540116")]
        TeardropScarabMistwoodAshOfWarGroundSlam = 540116,

        [Display(Name = "[Teardrop Scarab - Third Chuch of Marika] Ash of War: Sacred Blade 540118")]
        TeardropScarabThirdChuchOfMarikaAshOfWarSacredBlade = 540118,

        [Display(Name = "[Teardrop Scarab - Limgrave Coast] Ash of War: Stamp (Sweep) 540120")]
        TeardropScarabLimgraveCoastAshOfWarStampSweep = 540120,

        [Display(Name = "[Teardrop Scarab - Weeping Peninsula] Divine Fortification 540132")]
        TeardropScarabWeepingPeninsulaDivineFortification = 540132,

        [Display(Name = "[Teardrop Scarab - Weeping Peninsula] Lightning Strike 540136")]
        TeardropScarabWeepingPeninsulaLightningStrike = 540136,

        [Display(Name = "[Teardrop Scarab - Weeping Peninsula] Poison Mist 540138")]
        TeardropScarabWeepingPeninsulaPoisonMist = 540138,

        [Display(Name = "[Teardrop Scarab - Weeping Peninsula] Ash of War: Mighty Shot 540140")]
        TeardropScarabWeepingPeninsulaAshOfWarMightyShot = 540140,

        [Display(Name = "[Teardrop Scarab - Limgrave] Somber Smithing Stone [1] 540142")]
        TeardropScarabLimgraveSomberSmithingStone1 = 540142,

        [Display(Name = "[Teardrop Scarab - Limgrave] Somber Smithing Stone [1] 540144")]
        TeardropScarabLimgraveSomberSmithingStone1_ = 540144,

        [Display(Name = "[Teardrop Scarab - Limgrave] Somber Smithing Stone [1] 540146")]
        TeardropScarabLimgraveSomberSmithingStone1__ = 540146,

        [Display(Name = "[Teardrop Scarab - Stormveil Castle] Ash of War: Storm Assault 540170")]
        TeardropScarabStormveilCastleAshOfWarStormAssault = 540170,

        [Display(Name = "[Teardrop Scarab - Stormveil Castle] Ash of War: Stormcaller 540172")]
        TeardropScarabStormveilCastleAshOfWarStormcaller = 540172,

        [Display(Name = "[Teardrop Scarab - Stormveil Castle] Rancorcall 540174")]
        TeardropScarabStormveilCastleRancorcall = 540174,

        [Display(Name = "[Teardrop Scarab - Three Sisters] Ash of War: Chilling Mist 540200")]
        TeardropScarabThreeSistersAshOfWarChillingMist = 540200,

        [Display(Name = "[Teardrop Scarab - Liurnia] Ash of War: Charge Forth 540202")]
        TeardropScarabLiurniaAshOfWarChargeForth = 540202,

        [Display(Name = "[Teardrop Scarab - Liurnia] Ash of War: Hoarfrost Stomp 540204")]
        TeardropScarabLiurniaAshOfWarHoarfrostStomp = 540204,

        [Display(Name = "[Teardrop Scarab - Liurnia] Ash of War: Thops's Barrier 540206")]
        TeardropScarabLiurniaAshOfWarThopssBarrier = 540206,

        [Display(Name = "[Teardrop Scarab - Liurnia] Ash of War: Vow of the Indomitable 540208")]
        TeardropScarabLiurniaAshOfWarVowOfTheIndomitable = 540208,

        [Display(Name = "[Teardrop Scarab - Liurnia] Ash of War: Shield Bash 540210")]
        TeardropScarabLiurniaAshOfWarShieldBash = 540210,

        [Display(Name = "[Teardrop Scarab - Liurnia] Bloodflame Blade 540218")]
        TeardropScarabLiurniaBloodflameBlade = 540218,

        [Display(Name = "[Teardrop Scarab - Caria Manor] Carian Piercer 540220")]
        TeardropScarabCariaManorCarianPiercer = 540220,

        [Display(Name = "[Teardrop Scarab - Liurnia] Ash of War: Barbaric Roar 540224")]
        TeardropScarabLiurniaAshOfWarBarbaricRoar = 540224,

        [Display(Name = "[Teardrop Scarab - Liurnia] Frenzied Burst 540236")]
        TeardropScarabLiurniaFrenziedBurst = 540236,

        [Display(Name = "[Teardrop Scarab - Liurnia] Ash of War: Sword Dance 540238")]
        TeardropScarabLiurniaAshOfWarSwordDance = 540238,

        [Display(Name = "[Teardrop Scarab - Caria Manor] Frozen Armament 540250")]
        TeardropScarabCariaManorFrozenArmament = 540250,

        [Display(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [2] 540252")]
        TeardropScarabLiurniaSomberSmithingStone2 = 540252,

        [Display(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [2] 540254")]
        TeardropScarabLiurniaSomberSmithingStone2_ = 540254,

        [Display(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [3] 540256")]
        TeardropScarabLiurniaSomberSmithingStone3 = 540256,

        [Display(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [3] 540258")]
        TeardropScarabLiurniaSomberSmithingStone3_ = 540258,

        [Display(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [2] 540260")]
        TeardropScarabLiurniaSomberSmithingStone2__ = 540260,

        [Display(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [2] 540262")]
        TeardropScarabLiurniaSomberSmithingStone2___ = 540262,

        [Display(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [2] 540264")]
        TeardropScarabLiurniaSomberSmithingStone2____ = 540264,

        [Display(Name = "[Teardrop Scarab - Raya Lucaria Academy] Ash of War: Spectral Lance 540272")]
        TeardropScarabRayaLucariaAcademyAshOfWarSpectralLance = 540272,

        [Display(Name = "[Teardrop Scarab - Raya Lucaria Academy] Somber Smithing Stone [4] 540290")]
        TeardropScarabRayaLucariaAcademySomberSmithingStone4 = 540290,

        [Display(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Sacred Order 540300")]
        TeardropScarabAltusPlateauAshOfWarSacredOrder = 540300,

        [Display(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Shield Crash 540302")]
        TeardropScarabAltusPlateauAshOfWarShieldCrash = 540302,

        [Display(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Earthshaker 540304")]
        TeardropScarabAltusPlateauAshOfWarEarthshaker = 540304,

        [Display(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Blood Blade 540306")]
        TeardropScarabAltusPlateauAshOfWarBloodBlade = 540306,

        [Display(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Golden Slam 540308")]
        TeardropScarabAltusPlateauAshOfWarGoldenSlam = 540308,

        [Display(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Lightning Ram 540310")]
        TeardropScarabAltusPlateauAshOfWarLightningRam = 540310,

        [Display(Name = "[Teardrop Scarab - Altus Plateau] Protection of the Erdtree 540312")]
        TeardropScarabAltusPlateauProtectionOfTheErdtree = 540312,

        [Display(Name = "[Teardrop Scarab - Capital Outskirts] Ash of War: Prayerful Strike 540314")]
        TeardropScarabCapitalOutskirtsAshOfWarPrayerfulStrike = 540314,

        [Display(Name = "[Teardrop Scarab - Capital Outskirts] Ash of War: Golden Parry 540316")]
        TeardropScarabCapitalOutskirtsAshOfWarGoldenParry = 540316,

        [Display(Name = "[Teardrop Scarab - Capital Outskirts] Ash of War: Lightning Slash 540318")]
        TeardropScarabCapitalOutskirtsAshOfWarLightningSlash = 540318,

        [Display(Name = "[Teardrop Scarab - Capital Outskirts] Somber Smithing Stone [5] 540320")]
        TeardropScarabCapitalOutskirtsSomberSmithingStone5 = 540320,

        [Display(Name = "[Teardrop Scarab - Mt. Gelmir] Ash of War: Barrage 540332")]
        TeardropScarabMtGelmirAshOfWarBarrage = 540332,

        [Display(Name = "[Teardrop Scarab - Mt. Gelmir] Ash of War: Through and Through 540334")]
        TeardropScarabMtGelmirAshOfWarThroughandThrough = 540334,

        [Display(Name = "[Teardrop Scarab - Leyndell] Barrier of Gold 540370")]
        TeardropScarabLeyndellBarrierOfGold = 540370,

        [Display(Name = "[Teardrop Scarab - Leyndell] Ash of War: Thunderbolt 540372")]
        TeardropScarabLeyndellAshOfWarThunderbolt = 540372,

        [Display(Name = "[Teardrop Scarab - Caelid] Whirl, O Flame! 540400")]
        TeardropScarabCaelidWhirlOFlame = 540400,

        [Display(Name = "[Teardrop Scarab - Caelid] Ash of War: Lifesteal Fist 540402")]
        TeardropScarabCaelidAshOfWarLifestealFist = 540402,

        [Display(Name = "[Teardrop Scarab - Caelid] Ash of War: Sacred Ring of Light 540404")]
        TeardropScarabCaelidAshOfWarSacredRingOfLight = 540404,

        [Display(Name = "[Teardrop Scarab - Caelid] Ash of War: Poisonous Mist 540406")]
        TeardropScarabCaelidAshOfWarPoisonousMist = 540406,

        [Display(Name = "[Teardrop Scarab - Redmane Castle] Ash of War: Flaming Strike 540408")]
        TeardropScarabRedmaneCastleAshOfWarFlamingStrike = 540408,

        [Display(Name = "[Teardrop Scarab - Caelid] Ash of War: Flame of the Redmanes 540410")]
        TeardropScarabCaelidAshOfWarFlameOfTheRedmanes = 540410,

        [Display(Name = "[Teardrop Scarab - Dragonbarrow] Ash of War: Sky Shot 540412")]
        TeardropScarabDragonbarrowAshOfWarSkyShot = 540412,

        [Display(Name = "[Teardrop Scarab - Dragonbarrow] Ash of War: Cragblade 540414")]
        TeardropScarabDragonbarrowAshOfWarCragblade = 540414,

        [Display(Name = "[Teardrop Scarab - Caelid] Poison Armament 540416")]
        TeardropScarabCaelidPoisonArmament = 540416,

        [Display(Name = "[Teardrop Scarab - Caelid] Ash of War: Double Slash 540418")]
        TeardropScarabCaelidAshOfWarDoubleSlash = 540418,

        [Display(Name = "[Teardrop Scarab - Caelid] Bestial Constitution 540420")]
        TeardropScarabCaelidBestialConstitution = 540420,

        [Display(Name = "[Teardrop Scarab - Caelid] Somber Smithing Stone [4] 540422")]
        TeardropScarabCaelidSomberSmithingStone4 = 540422,

        [Display(Name = "[Teardrop Scarab - Caelid] Somber Smithing Stone [4] 540424")]
        TeardropScarabCaelidSomberSmithingStone4_ = 540424,

        [Display(Name = "[Teardrop Scarab - Caelid] Somber Smithing Stone [8] 540426")]
        TeardropScarabCaelidSomberSmithingStone8 = 540426,

        [Display(Name = "[Teardrop Scarab - Caelid] Somber Smithing Stone [9] 540428")]
        TeardropScarabCaelidSomberSmithingStone9 = 540428,

        [Display(Name = "Smithing Stone [1] 540500")]
        SmithingStone1 = 540500,

        [Display(Name = "Smithing Stone [1] 540502")]
        SmithingStone1_ = 540502,

        [Display(Name = "Smithing Stone [1] 540504")]
        SmithingStone1__ = 540504,

        [Display(Name = "Smithing Stone [1] 540506")]
        SmithingStone1___ = 540506,

        [Display(Name = "Smithing Stone [1] 540508")]
        SmithingStone1____ = 540508,

        [Display(Name = "[Teardrop Scarab - Mountaintops of the Giants] Ash of War: Seppuku 540510")]
        TeardropScarabMountaintopsOfTheGiantsAshOfWarSeppuku = 540510,

        [Display(Name = "[Teardrop Scarab - Mountaintops of the Giants] Ash of War: Troll's Roar 540512")]
        TeardropScarabMountaintopsOfTheGiantsAshOfWarTrollsRoar = 540512,

        [Display(Name = "[Teardrop Scarab - Giant-Conquering Hero's Grave] Flame, Protect Me 540514")]
        TeardropScarabGiantConqueringHerosGraveFlameProtectMe = 540514,

        [Display(Name = "[Teardrop Scarab - Forbidden Lands] Ash of War: Prelate's Charge 540516")]
        TeardropScarabForbiddenLandsAshOfWarPrelatesCharge = 540516,

        [Display(Name = "Smithing Stone [1] 540520")]
        SmithingStone1_____ = 540520,

        [Display(Name = "Smithing Stone [1] 540522")]
        SmithingStone1______ = 540522,

        [Display(Name = "[Teardrop Scarab - Consecrated Snowfield] Ash of War: White Shadow's Lure 540524")]
        TeardropScarabConsecratedSnowfieldAshOfWarWhiteShadowsLure = 540524,

        [Display(Name = "Smithing Stone [1] 540526")]
        SmithingStone1_______ = 540526,

        [Display(Name = "Smithing Stone [1] 540528")]
        SmithingStone1________ = 540528,

        [Display(Name = "Golden Rune [1] 540570")]
        GoldenRune1 = 540570,

        [Display(Name = "Golden Rune [1] 540572")]
        GoldenRune1_ = 540572,

        [Display(Name = "Golden Rune [1] 540574")]
        GoldenRune1__ = 540574,

        [Display(Name = "Golden Rune [1] 540576")]
        GoldenRune1___ = 540576,

        [Display(Name = "[Teardrop Scarab - Siofra River] Somber Smithing Stone [5] 540590")]
        TeardropScarabSiofraRiverSomberSmithingStone5 = 540590,

        [Display(Name = "[Teardrop Scarab - Siofra River] Somber Smithing Stone [5] 540592")]
        TeardropScarabSiofraRiverSomberSmithingStone5_ = 540592,

        [Display(Name = "[Teardrop Scarab - Siofra River] Somber Smithing Stone [6] 540600")]
        TeardropScarabSiofraRiverSomberSmithingStone6 = 540600,

        [Display(Name = "[Teardrop Scarab - Siofra River] Somber Smithing Stone [6] 540602")]
        TeardropScarabSiofraRiverSomberSmithingStone6_ = 540602,

        [Display(Name = "[Teardrop Scarab - Siofra River] Great Oracular Bubble 540610")]
        TeardropScarabSiofraRiverGreatOracularBubble = 540610,

        [Display(Name = "Golden Rune [1] 540612")]
        GoldenRune1____ = 540612,

        [Display(Name = "Golden Rune [1] 540614")]
        GoldenRune1_____ = 540614,

        [Display(Name = "Golden Rune [1] 540616")]
        GoldenRune1______ = 540616,

        [Display(Name = "Golden Rune [1] 540618")]
        GoldenRune1_______ = 540618,

        [Display(Name = "[Teardrop Scarab - Siofra River] Ash of War: Square Off 540630")]
        TeardropScarabSiofraRiverAshOfWarSquareOff = 540630,

        [Display(Name = "Golden Rune [1] 540632")]
        GoldenRune1________ = 540632,

        [Display(Name = "Golden Rune [1] 540634")]
        GoldenRune1_________ = 540634,

        [Display(Name = "Golden Rune [1] 540636")]
        GoldenRune1__________ = 540636,

        [Display(Name = "Golden Rune [1] 540638")]
        GoldenRune1___________ = 540638,

        [Display(Name = "Golden Rune [1] 540640")]
        GoldenRune1____________ = 540640,

        [Display(Name = "[Teardrop Scarab - Nokron] Somber Smithing Stone [5] 540642")]
        TeardropScarabNokronSomberSmithingStone5 = 540642,

        [Display(Name = "Golden Rune [1] 540644")]
        GoldenRune1_____________ = 540644,

        [Display(Name = "[Teardrop Scarab - Nokron] Ash of War: Enchanted Shot 540646")]
        TeardropScarabNokronAshOfWarEnchantedShot = 540646,

        [Display(Name = "[Teardrop Scarab - Nokron] Order Healing 540648")]
        TeardropScarabNokronOrderHealing = 540648,

        [Display(Name = "Golden Rune [1] 540650")]
        GoldenRune1______________ = 540650,

        [Display(Name = "[Teardrop Scarab - Siofra River] Oracle Bubbles 540652")]
        TeardropScarabSiofraRiverOracleBubbles = 540652,

        [Display(Name = "[Teardrop Scarab - Deeproot Depths] Ash of War: Golden Land 540660")]
        TeardropScarabDeeprootDepthsAshOfWarGoldenLand = 540660,

        [Display(Name = "Golden Rune [1] 540662")]
        GoldenRune1_______________ = 540662,

        [Display(Name = "Golden Rune [1] 540664")]
        GoldenRune1________________ = 540664,

        [Display(Name = "Golden Rune [1] 540666")]
        GoldenRune1_________________ = 540666,

        [Display(Name = "Somber Smithing Stone [6] 540668")]
        SomberSmithingStone6 = 540668,

        [Display(Name = "Somber Smithing Stone [6] 540670")]
        SomberSmithingStone6_ = 540670,

        [Display(Name = "Golden Rune [1] 540680")]
        GoldenRune1__________________ = 540680,

        [Display(Name = "Golden Rune [1] 540682")]
        GoldenRune1___________________ = 540682,

        [Display(Name = "Golden Rune [1] 540684")]
        GoldenRune1____________________ = 540684,

        [Display(Name = "[Teardrop Scarab - Mohgwyn Dynasty] Ash of War: Blood Tax 540686")]
        TeardropScarabMohgwynDynastyAshOfWarBloodTax = 540686,

        [Display(Name = "[Teardrop Scarab - Crumbling Farum Azula] Golden Lightning Fortification 540772")]
        TeardropScarabCrumblingFarumAzulaGoldenLightningFortification = 540772,

        [Display(Name = "[Info Item] About Sites of Grace 550000")]
        InfoItemAboutSitesOfGrace = 550000,

        [Display(Name = "[Info Item] About Sorceries and Incantations 550010")]
        InfoItemAboutSorceriesandIncantations = 550010,

        [Display(Name = "[Info Item] About Bows 550020")]
        InfoItemAboutBows = 550020,

        [Display(Name = "[Info Item] About Crouching 550030")]
        InfoItemAboutCrouching = 550030,

        [Display(Name = "[Info Item] About Stance-Breaking 550040")]
        InfoItemAboutStanceBreaking = 550040,

        [Display(Name = "[Info Item] About Stakes of Marika 550050")]
        InfoItemAboutStakesOfMarika = 550050,

        [Display(Name = "[Info Item] About Guard Counters 550060")]
        InfoItemAboutGuardCounters = 550060,

        [Display(Name = "[Info Item] About the Map 550070")]
        InfoItemAboutTheMap = 550070,

        [Display(Name = "[Info Item] About Guidance of Grace 550080")]
        InfoItemAboutGuidanceOfGrace = 550080,

        [Display(Name = "[Info Item] About Horseback Riding 550090")]
        InfoItemAboutHorsebackRiding = 550090,

        [Display(Name = "[Info Item] About Death 550100")]
        InfoItemAboutDeath = 550100,

        [Display(Name = "[Info Item] About Summoning Spirits 550110")]
        InfoItemAboutSummoningSpirits = 550110,

        [Display(Name = "[Info Item] About Guarding 550120")]
        InfoItemAboutGuarding = 550120,

        [Display(Name = "[Info Item] About Item Crafting 550130")]
        InfoItemAboutItemCrafting = 550130,

        [Display(Name = "[Info Item] About Flask of Wondrous Physick 550150")]
        InfoItemAboutFlaskOfWondrousPhysick = 550150,

        [Display(Name = "[Info Item] About Adding Skills 550160")]
        InfoItemAboutAddingSkills = 550160,

        [Display(Name = "[Info Item] About Birdseye Telescopes 550170")]
        InfoItemAboutBirdseyeTelescopes = 550170,

        [Display(Name = "[Info Item] About Spiritspring Jumping 550180")]
        InfoItemAboutSpiritspringJumping = 550180,

        [Display(Name = "[Info Item] About Vanquishing Enemy Groups 550190")]
        InfoItemAboutVanquishingEnemyGroups = 550190,

        [Display(Name = "[Info Item] About Teardrop Scarabs 550200")]
        InfoItemAboutTeardropScarabs = 550200,

        [Display(Name = "[Info Item] About Summoning Other Players 550210")]
        InfoItemAboutSummoningOtherPlayers = 550210,

        [Display(Name = "[Info Item] About Cooperative Multiplayer 550220")]
        InfoItemAboutCooperativeMultiplayer = 550220,

        [Display(Name = "[Info Item] About Competitive Multiplayer 550230")]
        InfoItemAboutCompetitiveMultiplayer = 550230,

        [Display(Name = "[Info Item] About Invasion Multiplayer 550240")]
        InfoItemAboutInvasionMultiplayer = 550240,

        [Display(Name = "[Info Item] About Hunter Multiplayer 550250")]
        InfoItemAboutHunterMultiplayer = 550250,

        [Display(Name = "[Info Item] About Summoning Pools 550260")]
        InfoItemAboutSummoningPools = 550260,

        [Display(Name = "[Info Item] About Monument Icon 550270")]
        InfoItemAboutMonumentIcon = 550270,

        [Display(Name = "[Info Item] About Requesting Help from Hunters 550280")]
        InfoItemAboutRequestingHelpfromHunters = 550280,

        [Display(Name = "[Info Item] About Skills 550290")]
        InfoItemAboutSkills = 550290,

        [Display(Name = "[Limgrave - Artist's Shack] \"Homing Instinct\" Painting 580000")]
        LimgraveArtistsShackHomingInstinctPainting = 580000,

        [Display(Name = "[Liurnia - Artist's Shack] \"Resurrection\" Painting 580010")]
        LiurniaArtistsShackResurrectionPainting = 580010,

        [Display(Name = "[Altus Plateau - Shaded Castle] \"Champion's Song\" Painting 580020")]
        AltusPlateauShadedCastleChampionsSongPainting = 580020,

        [Display(Name = "[Consecrated Snowfield - Castle Sol] \"Sorcerer\" Painting 580030")]
        ConsecratedSnowfieldCastleSolSorcererPainting = 580030,

        [Display(Name = "[Stormveil Castle] \"Prophecy\" Painting 580040")]
        StormveilCastleProphecyPainting = 580040,

        [Display(Name = "[Leyndell - Fortifed Manor] \"Flightless Bird\" Painting 580050")]
        LeyndellFortifedManorFlightlessBirdPainting = 580050,

        [Display(Name = "[Caelid - Sellia] \"Redmane\" Painting 580060")]
        CaelidSelliaRedmanePainting = 580060,

        [Display(Name = "[Reward - \"Homing Instinct\" Painting] Incantation Scarab 580300")]
        RewardHomingInstinctPaintingIncantationScarab = 580300,

        [Display(Name = "[Reward - \"Resurrection\" Painting] Juvenile Scholar Cap 580310")]
        RewardResurrectionPaintingJuvenileScholarCap = 580310,

        [Display(Name = "[Reward - \"Champion's Song\" Painting] Harp Bow 580320")]
        RewardChampionsSongPaintingHarpBow = 580320,

        [Display(Name = "[Reward - \"Sorcerer\" Painting] Greathood 580330")]
        RewardSorcererPaintingGreathood = 580330,

        [Display(Name = "[Reward - \"Prophecy\" Painting] Warhawk Ashes 580340")]
        RewardProphecyPaintingWarhawkAshes = 580340,

        [Display(Name = "[Reward - \"Flightless Bird\" Painting] Fire's Deadly Sin 580350")]
        RewardFlightlessBirdPaintingFiresDeadlySin = 580350,

        [Display(Name = "[Reward - \"Redmane\" Painting] Ash of War: Rain of Arrows 580360")]
        RewardRedmanePaintingAshOfWarRainOfArrows = 580360,

        [Display(Name = "[Melina - Third Grace Found] Spectral Steed Whistle 60100")]
        MelinaThirdGraceFoundSpectralSteedWhistle = 60100,

        [Display(Name = "[Melina - Morgott Killed] Rold Medallion 400001")]
        MelinaMorgottKilledRoldMedallion = 400001,

        [Display(Name = "[Unknown] 400010")]
        Unknown = 400010,

        [Display(Name = "[Unknown] Neutralizing Boluses 400020")]
        UnknownNeutralizingBoluses = 400020,

        [Display(Name = "[Unknown] 400021")]
        Unknown_ = 400021,

        [Display(Name = "[White-Faced Varre - ?] Festering Bloody Finger 400030")]
        WhiteFacedVarreFesteringBloodyFinger = 400030,

        [Display(Name = "[White-Faced Varre - Maiden Kill] Lord of Blood's Favor 400031")]
        WhiteFacedVarreMaidenKillLordOfBloodsFavor = 400031,

        [Display(Name = "[White-Faced Varre - 3 Invasions] Pureblood Knight's Medal 400032")]
        WhiteFacedVarre3InvasionsPurebloodKnightsMedal = 400032,

        [Display(Name = "[White-Faced Varre - Maiden Kill] Lord of Blood's Favor 400033")]
        WhiteFacedVarreMaidenKillLordOfBloodsFavor_ = 400033,

        [Display(Name = "[White-Faced Varre - Returned Oath-Cloth] Bloody Finger 60270")]
        WhiteFacedVarreReturnedOathClothBloodyFinger = 60270,

        [Display(Name = "[White-Faced Varre] 400035")]
        WhiteFacedVarre = 400035,

        [Display(Name = "[White-Faced Varre - Invasion] Varre's Bouquet 400037")]
        WhiteFacedVarreInvasionVarresBouquet = 400037,

        [Display(Name = "[White-Faced Varre - Invasion] Festering Bloody Finger 400036")]
        WhiteFacedVarreInvasionFesteringBloodyFinger = 400036,

        [Display(Name = "[Unknown] 400040")]
        Unknown__ = 400040,

        [Display(Name = "[Unknown] Perfume Bottle 400041")]
        UnknownPerfumeBottle = 400041,

        [Display(Name = "[Unknown] Glowstone 400042")]
        UnknownGlowstone = 400042,

        [Display(Name = "[Gatekeeper Gostoc - First Meeting] Grace Mimic 400050")]
        GatekeeperGostocFirstMeetingGraceMimic = 400050,

        [Display(Name = "[Gatekeeper Gostoc - Gostoc Killed] Gostoc's Bell Bearing 400051")]
        GatekeeperGostocGostocKilledGostocsBellBearing = 400051,

        [Display(Name = "[Edgar] Sacrificial Twig 400060")]
        EdgarSacrificialTwig = 400060,

        [Display(Name = "[Edgar] Shabriri Grape 400061")]
        EdgarShabririGrape = 400061,

        [Display(Name = "[Tanith] Tonic of Forgetfulness 400070")]
        TanithTonicOfForgetfulness = 400070,

        [Display(Name = "[Tanith] Consort's Mask 400071")]
        TanithConsortsMask = 400071,

        [Display(Name = "[Tanith] Drawing-Room Key 400072")]
        TanithDrawingRoomKey = 400072,

        [Display(Name = "[Tanith] Letter from Volcano Manor 400073")]
        TanithLetterfromVolcanoManor = 400073,

        [Display(Name = "[Tanith] Letter from Volcano Manor 400074")]
        TanithLetterfromVolcanoManor_ = 400074,

        [Display(Name = "[Tanith] Red Letter 400075")]
        TanithRedLetter = 400075,

        [Display(Name = "[Tanith] Magma Shot 400076")]
        TanithMagmaShot = 400076,

        [Display(Name = "[Tanith] Serpentbone Blade 400077")]
        TanithSerpentboneBlade = 400077,

        [Display(Name = "[Tanith] Taker's Cameo 400078")]
        TanithTakersCameo = 400078,

        [Display(Name = "[Tanith] Aspects of the Crucible: Breath 400079")]
        TanithAspectsOfTheCrucibleBreath = 400079,

        [Display(Name = "[Irina] Irina's Letter 400080")]
        IrinaIrinasLetter = 400080,

        [Display(Name = "[Rya] Rya's Necklace 400081")]
        RyaRyasNecklace = 400081,

        [Display(Name = "[Hyetta] Frenzied Flame Seal 400089")]
        HyettaFrenziedFlameSeal = 400089,

        [Display(Name = "[Rya] Volcano Manor Invitation 400090")]
        RyaVolcanoManorInvitation = 400090,

        [Display(Name = "[Rya] Zorayas's Letter 400091")]
        RyaZorayassLetter = 400091,

        [Display(Name = "[Sorceress Sellen] Sellen's Primal Glintstone 400100")]
        SorceressSellenSellensPrimalGlintstone = 400100,

        [Display(Name = "[Sorceress Sellen] Glintstone Kris 400101")]
        SorceressSellenGlintstoneKris = 400101,

        [Display(Name = "[Sorceress Sellen] Sellian Sealbreaker 400102")]
        SorceressSellenSellianSealbreaker = 400102,

        [Display(Name = "[Sorceress Sellen] Starlight Shards 400103")]
        SorceressSellenStarlightShards = 400103,

        [Display(Name = "[Sorceress Sellen] Comet Azur 400104")]
        SorceressSellenCometAzur = 400104,

        [Display(Name = "[Sorceress Sellen] Stars of Ruin 400105")]
        SorceressSellenStarsOfRuin = 400105,

        [Display(Name = "[Sorceress Sellen] Sellen's Bell Bearing 400106")]
        SorceressSellenSellensBellBearing = 400106,

        [Display(Name = "[Sorceress Sellen] Witch's Glintstone Crown 400107")]
        SorceressSellenWitchsGlintstoneCrown = 400107,

        [Display(Name = "[Finger Reader Enia - Godfrey] Talisman Pouch 60500")]
        FingerReaderEniaGodfreyTalismanPouch = 60500,

        [Display(Name = "[Unknown] Glowstone 400120")]
        UnknownGlowstone_ = 400120,

        [Display(Name = "[Unknown] Glowstone 400121")]
        UnknownGlowstone__ = 400121,

        [Display(Name = "[Albus] Haligtree Secret Medallion (Right) 400130")]
        AlbusHaligtreeSecretMedallionRight = 400130,

        [Display(Name = "[Seluvis] Seluvis's Potion 400140")]
        SeluvisSeluvissPotion = 400140,

        [Display(Name = "[Seluvis] Magic Scorpion Charm 400141")]
        SeluvisMagicScorpionCharm = 400141,

        [Display(Name = "[Seluvis] 400142")]
        Seluvis = 400142,

        [Display(Name = "[Seluvis] Seluvis's Introduction 400143")]
        SeluvisSeluvissIntroduction = 400143,

        [Display(Name = "[Seluvis] Glowstone 400144")]
        SeluvisGlowstone = 400144,

        [Display(Name = "[Seluvis] Amber Draught 400145")]
        SeluvisAmberDraught = 400145,

        [Display(Name = "[Seluvis] 400146")]
        Seluvis_ = 400146,

        [Display(Name = "[Seluvis] Seluvis's Bell Bearing 400148")]
        SeluvisSeluvissBellBearing = 400148,

        [Display(Name = "[Pidia, Carian Servant] Pidia's Bell Bearing 400149")]
        PidiaCarianServantPidiasBellBearing = 400149,

        [Display(Name = "[Blaidd is the Half-Wolf] Somber Smithing Stone [2] 400150")]
        BlaiddisTheHalfWolfSomberSmithingStone2 = 400150,

        [Display(Name = "[Blaidd is the Half-Wolf] Royal Greatsword 400158")]
        BlaiddisTheHalfWolfRoyalGreatsword = 400158,

        [Display(Name = "[Blaidd is the Half-Wolf] Discarded Palace Key 400159")]
        BlaiddisTheHalfWolfDiscardedPalaceKey = 400159,

        [Display(Name = "[Unknown] White Cipher Ring 60280")]
        UnknownWhiteCipherRing = 60280,

        [Display(Name = "[Unknown] Smithing Stone [5] 400161")]
        UnknownSmithingStone5 = 400161,

        [Display(Name = "[Eleonora, Violet Bloody Finger] Purifying Crystal Tear 65270")]
        EleonoraVioletBloodyFingerPurifyingCrystalTear = 65270,

        [Display(Name = "[Eleonora, Violet Bloody Finger] Eleonora's Poleblade 400162")]
        EleonoraVioletBloodyFingerEleonorasPoleblade = 400162,

        [Display(Name = "[Bloody Finger Hunter Yura] Nagakiba +0 - Piercing Fang 400163")]
        BloodyFingerHunterYuraNagakiba0PiercingFang = 400163,

        [Display(Name = "[Bloody Finger Hunter Yura] Iron Kasa 400164")]
        BloodyFingerHunterYuraIronKasa = 400164,

        [Display(Name = "[Iron Fist Alexander] Exalted Flesh 400170")]
        IronFistAlexanderExaltedFlesh = 400170,

        [Display(Name = "[Iron Fist Alexander] Exalted Flesh 400171")]
        IronFistAlexanderExaltedFlesh_ = 400171,

        [Display(Name = "[Iron Fist Alexander] Jar 400172")]
        IronFistAlexanderJar = 400172,

        [Display(Name = "[Iron Fist Alexander] Warrior Jar Shard 400173")]
        IronFistAlexanderWarriorJarShard = 400173,

        [Display(Name = "[Iron Fist Alexander] Shard of Alexander 400174")]
        IronFistAlexanderShardOfAlexander = 400174,

        [Display(Name = "[Unknown] 400179")]
        Unknown___ = 400179,

        [Display(Name = "[Patches] Letter to Patches 400180")]
        PatchesLettertoPatches = 400180,

        [Display(Name = "[Patches] Dancer's Castanets 400181")]
        PatchesDancersCastanets = 400181,

        [Display(Name = "[Patches] Magma Whip Candlestick 400182")]
        PatchesMagmaWhipCandlestick = 400182,

        [Display(Name = "[Patches] Golden Rune [1] 400183")]
        PatchesGoldenRune1 = 400183,

        [Display(Name = "[Patches] Spear+7 400184")]
        PatchesSpear7 = 400184,

        [Display(Name = "[Roderika] Spirit Jellyfish Ashes 400190")]
        RoderikaSpiritJellyfishAshes = 400190,

        [Display(Name = "[Roderika] Golden Seed 400191")]
        RoderikaGoldenSeed = 400191,

        [Display(Name = "[Chest - Gatefront Ruins] Whetstone Knife 400210")]
        ChestGatefrontRuinsWhetstoneKnife = 400210,

        [Display(Name = "[Kenneth Haight] Erdsteel Dagger 400221")]
        KennethHaightErdsteelDagger = 400221,

        [Display(Name = "[Gurranq - 4th Deathroot] Ash of War: Beast's Roar 400235")]
        Gurranq4thDeathrootAshOfWarBeastsRoar = 400235,

        [Display(Name = "[Gurranq - 3rd Deathroot] Bestial Vitality 400236")]
        Gurranq3rdDeathrootBestialVitality = 400236,

        [Display(Name = "[Gurranq - 2nd Deathroot] Bestial Sling 400237")]
        Gurranq2ndDeathrootBestialSling = 400237,

        [Display(Name = "[Gurranq - 1st Deathroot] Clawmark Seal 400238")]
        Gurranq1stDeathrootClawmarkSeal = 400238,

        [Display(Name = "[Gurranq - 1st Deathroot] Beast Eye 400239")]
        Gurranq1stDeathrootBeastEye = 400239,

        [Display(Name = "[Gurranq - 9th Deathroot] Dragon Smithing Stone 400230")]
        Gurranq9thDeathrootDragonSmithingStone = 400230,

        [Display(Name = "[Gurranq - 8th Deathroot] Gurranq's Beast Claw 400231")]
        Gurranq8thDeathrootGurranqsBeastClaw = 400231,

        [Display(Name = "[Gurranq - 7th Deathroot] Beastclaw Greathammer 400232")]
        Gurranq7thDeathrootBeastclawGreathammer = 400232,

        [Display(Name = "[Gurranq - 6th Deathroot] Stone of Gurranq 400233")]
        Gurranq6thDeathrootStoneOfGurranq = 400233,

        [Display(Name = "[Gurranq - 5th Deathroot] Beast Claw 400234")]
        Gurranq5thDeathrootBeastClaw = 400234,

        [Display(Name = "[War Counselor Iji] Iji's Bell Bearing 400240")]
        WarCounselorIjiIjisBellBearing = 400240,

        [Display(Name = "[War Counselor Iji] Iji's Mirrorhelm 400241")]
        WarCounselorIjiIjisMirrorhelm = 400241,

        [Display(Name = "[Unknown] Glowstone 400260")]
        UnknownGlowstone___ = 400260,

        [Display(Name = "[Unknown] Mushroom 400271")]
        UnknownMushroom = 400271,

        [Display(Name = "[Castle Sol] Haligtree Secret Medallion (Left) 400280")]
        CastleSolHaligtreeSecretMedallionLeft = 400280,

        [Display(Name = "[Unknown] 400281")]
        Unknown____ = 400281,

        [Display(Name = "[Gideon Ofnir - Secret Medallion] Black Flame's Protection 400282")]
        GideonOfnirSecretMedallionBlackFlamesProtection = 400282,

        [Display(Name = "[Gideon Ofnir - Haligtree] Lord's Divine Fortification 400283")]
        GideonOfnirHaligtreeLordsDivineFortification = 400283,

        [Display(Name = "[Gideon Ofnir - Mohgwyn Dynasty Mausoleum] Fevor's Cookbook [3] 68210")]
        GideonOfnirMohgwynDynastyMausoleumFevorsCookbook3 = 68210,

        [Display(Name = "[Gideon Ofnir - Mohg Killed] Law of Causality 400285")]
        GideonOfnirMohgKilledLawOfCausality = 400285,

        [Display(Name = "[Gideon Ofnir - Boss Drop] All-Knowing Gauntlets 400284")]
        GideonOfnirBossDropAllKnowingGauntlets = 400284,

        [Display(Name = "[Knight Bernahl] Letter to Bernahl 400290")]
        KnightBernahlLettertoBernahl = 400290,

        [Display(Name = "[Knight Bernahl] Gelmir's Fury 400291")]
        KnightBernahlGelmirsFury = 400291,

        [Display(Name = "[Knight Bernahl] Blasphemous Claw 400292")]
        KnightBernahlBlasphemousClaw = 400292,

        [Display(Name = "[Knight Bernahl] Devourer's Scepter 400293")]
        KnightBernahlDevourersScepter = 400293,

        [Display(Name = "[Knight Bernahl] Beast Champion Helm 400294")]
        KnightBernahlBeastChampionHelm = 400294,

        [Display(Name = "[Knight Bernahl] Gelmir's Fury 400295")]
        KnightBernahlGelmirsFury_ = 400295,

        [Display(Name = "[Big Boggart] Rya's Necklace 400300")]
        BigBoggartRyasNecklace = 400300,

        [Display(Name = "[Big Boggart] Iron Ball +0 - Braggart's Roar 400309")]
        BigBoggartIronBall0BraggartsRoar = 400309,

        [Display(Name = "[Big Boggart] Seedbed Curse 400308")]
        BigBoggartSeedbedCurse = 400308,

        [Display(Name = "[Gowry] Unalloyed Gold Needle 400310")]
        GowryUnalloyedGoldNeedle = 400310,

        [Display(Name = "[Gowry] Sellia's Secret 400311")]
        GowrySelliasSecret = 400311,

        [Display(Name = "[Gowry] Flock's Canvas Talisman 400312")]
        GowryFlocksCanvasTalisman = 400312,

        [Display(Name = "[Millicent] Prosthesis-Wearer Heirloom 400320")]
        MillicentProsthesisWearerHeirloom = 400320,

        [Display(Name = "[Millicent] Unalloyed Gold Needle 400321")]
        MillicentUnalloyedGoldNeedle = 400321,

        [Display(Name = "[Millicent] Millicent's Prosthesis 400323")]
        MillicentMillicentsProsthesis = 400323,

        [Display(Name = "[Millicent] Miquella's Needle 400324")]
        MillicentMiquellasNeedle = 400324,

        [Display(Name = "[Millicent] Somber Ancient Dragon Smithing Stone 400325")]
        MillicentSomberAncientDragonSmithingStone = 400325,

        [Display(Name = "[Fia] Weathered Dagger 400331")]
        FiaWeatheredDagger = 400331,

        [Display(Name = "[Fia] Sacrificial Twig 400332")]
        FiaSacrificialTwig = 400332,

        [Display(Name = "[Fia] Radiant Baldachin's Blessing 400333")]
        FiaRadiantBaldachinsBlessing = 400333,

        [Display(Name = "[Fia] Knifeprint Clue 400334")]
        FiaKnifeprintClue = 400334,

        [Display(Name = "[D, Hunter of the Dead] D's Bell Bearing 400349")]
        DHunterOfTheDeadDsBellBearing = 400349,

        [Display(Name = "[Prince of Death's Throne] Inseparable Sword 400348")]
        PrinceOfDeathsThroneInseparableSword = 400348,

        [Display(Name = "[Sorcerer Rogier] Rogier's Rapier +8 - Glintblade Phalanx 400358")]
        SorcererRogierRogiersRapier8GlintbladePhalanx = 400358,

        [Display(Name = "[Sorcerer Rogier] Black Knifeprint 400357")]
        SorcererRogierBlackKnifeprint = 400357,

        [Display(Name = "[Sorcerer Rogier] Rogier's Letter 400356")]
        SorcererRogierRogiersLetter = 400356,

        [Display(Name = "[Sorcerer Rogier] Rogier's Bell Bearing 400359")]
        SorcererRogierRogiersBellBearing = 400359,

        [Display(Name = "[Thops] Thops's Bell Bearing 400360")]
        ThopsThopssBellBearing = 400360,

        [Display(Name = "[Thops] Academy Glintstone Staff 400361")]
        ThopsAcademyGlintstoneStaff = 400361,

        [Display(Name = "[Thops] Thops's Barrier 400362")]
        ThopsThopssBarrier = 400362,

        [Display(Name = "[Brother Corhyn] Corhyn's Bell Bearing 400370")]
        BrotherCorhynCorhynsBellBearing = 400370,

        [Display(Name = "[Dung Eater] Sewer-Gaol Key 400380")]
        DungEaterSewerGaolKey = 400380,

        [Display(Name = "[Dung Eater] Omen Helm 400382")]
        DungEaterOmenHelm = 400382,

        [Display(Name = "[Ranni the Witch] Spirit Calling Bell 60110")]
        RanniTheWitchSpiritCallingBell = 60110,

        [Display(Name = "[Ranni the Witch] Lone Wolf Ashes 400390")]
        RanniTheWitchLoneWolfAshes = 400390,

        [Display(Name = "[Ranni the Witch] Carian Inverted Statue 400391")]
        RanniTheWitchCarianInvertedStatue = 400391,

        [Display(Name = "[Ranni the Witch] Dark Moon Greatsword 400393")]
        RanniTheWitchDarkMoonGreatsword = 400393,

        [Display(Name = "[Ranni the Witch] Miniature Ranni 400394")]
        RanniTheWitchMiniatureRanni = 400394,

        [Display(Name = "[Ranni the Witch] Fingerslayer Blade 400395")]
        RanniTheWitchFingerslayerBlade = 400395,

        [Display(Name = "[Witch-Hunter Jerren] Ancient Dragon Smithing Stone 400400")]
        WitchHunterJerrenAncientDragonSmithingStone = 400400,

        [Display(Name = "[Witch-Hunter Jerren] Eccentric's Hood 400401")]
        WitchHunterJerrenEccentricsHood = 400401,

        [Display(Name = "[Latenna] Latenna the Albinauric 400410")]
        LatennaLatennaTheAlbinauric = 400410,

        [Display(Name = "[Latenna] Somber Ancient Dragon Smithing Stone 400411")]
        LatennaSomberAncientDragonSmithingStone = 400411,

        [Display(Name = "[Latenna] Blue Silver Mail Hood 400412")]
        LatennaBlueSilverMailHood = 400412,

        [Display(Name = "[Nepheli Loux] Arsenal Charm 400420")]
        NepheliLouxArsenalCharm = 400420,

        [Display(Name = "[Nepheli Loux] Ancient Dragon Smithing Stone 400422")]
        NepheliLouxAncientDragonSmithingStone = 400422,

        [Display(Name = "[Master Lusat] Stars of Ruin 400430")]
        MasterLusatStarsOfRuin = 400430,

        [Display(Name = "[Master Azur] Comet Azur 400440")]
        MasterAzurCometAzur = 400440,

        [Display(Name = "[Juno Hoslow] Hoslow's Petal Whip 400451")]
        JunoHoslowHoslowsPetalWhip = 400451,

        [Display(Name = "[Juno Hoslow] Companion Jar 400452")]
        JunoHoslowCompanionJar = 400452,

        [Display(Name = "[Jar Bairn] Companion Jar 400460")]
        JarBairnCompanionJar = 400460,

        [Display(Name = "[The Great-Jar] Great-Jar's Arsenal 400470")]
        TheGreatJarGreatJarsArsenal = 400470,

        [Display(Name = "[Millicent - Killed Sisters] Rotten Winged Sword Insignia 400480")]
        MillicentKilledSistersRottenWingedSwordInsignia = 400480,

        [Display(Name = "[Ensha of the Royal Remains] Royal Remains Helm 400490")]
        EnshaOfTheRoyalRemainsRoyalRemainsHelm = 400490,

        [Display(Name = "[Goldmask] Goldmask's Rags 400500")]
        GoldmaskGoldmasksRags = 400500,

        [Display(Name = "[Merchant Kale] Kale's Bell Bearing 400049")]
        MerchantKaleKalesBellBearing = 400049,

        [Display(Name = "[Corpse - Edgar] Banished Knight's Halberd +8 - Spinning Strikes 400069")]
        CorpseEdgarBanishedKnightsHalberd8SpinningStrikes = 400069,

        [Display(Name = "[Corpse - Unknown] Glowstone 400108")]
        CorpseUnknownGlowstone = 400108,

        [Display(Name = "[Corpse - Unknown] Glowstone 400109")]
        CorpseUnknownGlowstone_ = 400109,

        [Display(Name = "[Corpse - Iron Fist Alexander] Warrior Jar Shard 400175")]
        CorpseIronFistAlexanderWarriorJarShard = 400175,

        [Display(Name = "[Corpse - Patches] Patches' Bell Bearing 400189")]
        CorpsePatchesPatchesBellBearing = 400189,

        [Display(Name = "[Corpse - Unknown] Glowstone 400209")]
        CorpseUnknownGlowstone__ = 400209,

        [Display(Name = "[Corpse - Unknown] Golden Seed 400220")]
        CorpseUnknownGoldenSeed = 400220,

        [Display(Name = "[Corpse - Knight Bernahl] Bernahl's Bell Bearing 400299")]
        CorpseKnightBernahlBernahlsBellBearing = 400299,

        [Display(Name = "[Corpse - Fia] Fia's Hood 400339")]
        CorpseFiaFiasHood = 400339,

        [Display(Name = "[Corpse - Dung Eater] Sword of Milos 400381")]
        CorpseDungEaterSwordOfMilos = 400381,

        [Display(Name = "[Corpse - Nepheli Loux] Stormhawk Axe 400421")]
        CorpseNepheliLouxStormhawkAxe = 400421,

        [Display(Name = "[Corpse - Master Lusat] Lusat's Glintstone Crown 400431")]
        CorpseMasterLusatLusatsGlintstoneCrown = 400431,

        [Display(Name = "[Corpse - Master Azur] Azur's Glintstone Crown 400441")]
        CorpseMasterAzurAzursGlintstoneCrown = 400441,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [1] 400901")]
        CorpseMerchantNomadicMerchantsBellBearing1 = 400901,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [2] 400902")]
        CorpseMerchantNomadicMerchantsBellBearing2 = 400902,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [3] 400903")]
        CorpseMerchantNomadicMerchantsBellBearing3 = 400903,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [4] 400904")]
        CorpseMerchantNomadicMerchantsBellBearing4 = 400904,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [5] 400905")]
        CorpseMerchantNomadicMerchantsBellBearing5 = 400905,

        [Display(Name = "[Corpse - Merchant] Isolated Merchant's Bell Bearing [1] 400906")]
        CorpseMerchantIsolatedMerchantsBellBearing1 = 400906,

        [Display(Name = "[Corpse - Merchant] Isolated Merchant's Bell Bearing [2] 400907")]
        CorpseMerchantIsolatedMerchantsBellBearing2 = 400907,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [6] 400908")]
        CorpseMerchantNomadicMerchantsBellBearing6 = 400908,

        [Display(Name = "[Corpse - Merchant] Hermit Merchant's Bell Bearing [1] 400909")]
        CorpseMerchantHermitMerchantsBellBearing1 = 400909,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [7] 400910")]
        CorpseMerchantNomadicMerchantsBellBearing7 = 400910,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [8] 400911")]
        CorpseMerchantNomadicMerchantsBellBearing8 = 400911,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [9] 400912")]
        CorpseMerchantNomadicMerchantsBellBearing9 = 400912,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [10] 400913")]
        CorpseMerchantNomadicMerchantsBellBearing10 = 400913,

        [Display(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [11] 400914")]
        CorpseMerchantNomadicMerchantsBellBearing11 = 400914,

        [Display(Name = "[Corpse - Merchant] Isolated Merchant's Bell Bearing [3] 400915")]
        CorpseMerchantIsolatedMerchantsBellBearing3 = 400915,

        [Display(Name = "[Corpse - Merchant] Hermit Merchant's Bell Bearing [2] 400916")]
        CorpseMerchantHermitMerchantsBellBearing2 = 400916,

        [Display(Name = "[Corpse - Merchant] Abandoned Merchant's Bell Bearing 400917")]
        CorpseMerchantAbandonedMerchantsBellBearing = 400917,

        [Display(Name = "[Corpse - Merchant] Hermit Merchant's Bell Bearing [3] 400918")]
        CorpseMerchantHermitMerchantsBellBearing3 = 400918,

        [Display(Name = "[Corpse - Merchant] Imprisoned Merchant's Bell Bearing 400919")]
        CorpseMerchantImprisonedMerchantsBellBearing = 400919,

        [Display(Name = "[LD - Stormveil] Furlcalling Finger Remedy 10007030")]
        LDStormveilFurlcallingFingerRemedy = 10007030,

        [Display(Name = "[LD - Stormveil] Fire Grease 10007040")]
        LDStormveilFireGrease = 10007040,

        [Display(Name = "[LD - Stormveil] Gold-Pickled Fowl Foot 10007050")]
        LDStormveilGoldPickledFowlFoot = 10007050,

        [Display(Name = "[LD - Stormveil] Festering Bloody Finger 10007060")]
        LDStormveilFesteringBloodyFinger = 10007060,

        [Display(Name = "[LD - Stormveil] Arrow 10007080")]
        LDStormveilArrow = 10007080,

        [Display(Name = "[LD - Stormveil] Manor Towershield 10007090")]
        LDStormveilManorTowershield = 10007090,

        [Display(Name = "[LD - Stormveil] Marred Leather Shield 10007100")]
        LDStormveilMarredLeatherShield = 10007100,

        [Display(Name = "[LD - Stormveil] Golden Rune [1] 10007110")]
        LDStormveilGoldenRune1 = 10007110,

        [Display(Name = "[LD - Stormveil] Bolt 10007120")]
        LDStormveilBolt = 10007120,

        [Display(Name = "[LD - Stormveil] Smithing Stone [3] 10007130")]
        LDStormveilSmithingStone3 = 10007130,

        [Display(Name = "[LD - Stormveil] Ruin Fragment 10007140")]
        LDStormveilRuinFragment = 10007140,

        [Display(Name = "[LD - Stormveil] Smithing Stone [2] 10007150")]
        LDStormveilSmithingStone2 = 10007150,

        [Display(Name = "[LD - Stormveil] Silver-Pickled Fowl Foot 10007160")]
        LDStormveilSilverPickledFowlFoot = 10007160,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007170")]
        LDStormveilGoldenRune2 = 10007170,

        [Display(Name = "[LD - Stormveil] Hookclaws 10007180")]
        LDStormveilHookclaws = 10007180,

        [Display(Name = "[LD - Stormveil] Throwing Dagger 10007190")]
        LDStormveilThrowingDagger = 10007190,

        [Display(Name = "[LD - Stormveil] St. Trina's Arrow 10007200")]
        LDStormveilStTrinasArrow = 10007200,

        [Display(Name = "[LD - Stormveil] Smoldering Butterfly 10007210")]
        LDStormveilSmolderingButterfly = 10007210,

        [Display(Name = "[LD - Stormveil] Fire Grease 10007220")]
        LDStormveilFireGrease_ = 10007220,

        [Display(Name = "[LD - Stormveil] Claw Talisman 10007230")]
        LDStormveilClawTalisman = 10007230,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007240")]
        LDStormveilGoldenRune2_ = 10007240,

        [Display(Name = "[LD - Stormveil] Arteria Leaf 10007250")]
        LDStormveilArteriaLeaf = 10007250,

        [Display(Name = "[LD - Stormveil] Throwing Dagger 10007260")]
        LDStormveilThrowingDagger_ = 10007260,

        [Display(Name = "[LD - Stormveil] Mushroom 10007270")]
        LDStormveilMushroom = 10007270,

        [Display(Name = "[LD - Stormveil] Drawstring Fire Grease 10007280")]
        LDStormveilDrawstringFireGrease = 10007280,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007290")]
        LDStormveilGoldenRune2__ = 10007290,

        [Display(Name = "[LD - Stormveil] Somber Smithing Stone [2] 10007300")]
        LDStormveilSomberSmithingStone2 = 10007300,

        [Display(Name = "[LD - Stormveil] Smithing Stone [2] 10007310")]
        LDStormveilSmithingStone2_ = 10007310,

        [Display(Name = "[LD - Stormveil] Marred Wooden Shield 10007320")]
        LDStormveilMarredWoodenShield = 10007320,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007330")]
        LDStormveilGoldenRune2___ = 10007330,

        [Display(Name = "[LD - Stormveil] Highland Axe 10007340")]
        LDStormveilHighlandAxe = 10007340,

        [Display(Name = "[LD - Stormveil] Kukri 10007350")]
        LDStormveilKukri = 10007350,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007360")]
        LDStormveilGoldenRune2____ = 10007360,

        [Display(Name = "[LD - Stormveil] Stonesword Key 10007370")]
        LDStormveilStoneswordKey = 10007370,

        [Display(Name = "[LD - Stormveil] Exalted Flesh 10007380")]
        LDStormveilExaltedFlesh = 10007380,

        [Display(Name = "[LD - Stormveil] Lump of Flesh 10007390")]
        LDStormveilLumpOfFlesh = 10007390,

        [Display(Name = "[LD - Stormveil] Golden Rune [1] 10007400")]
        LDStormveilGoldenRune1_ = 10007400,

        [Display(Name = "[LD - Stormveil] Smithing Stone [2] 10007410")]
        LDStormveilSmithingStone2__ = 10007410,

        [Display(Name = "[LD - Stormveil] Iron Whetblade 65610")]
        LDStormveilIronWhetblade = 65610,

        [Display(Name = "[LD - Stormveil] Arrow 10007430")]
        LDStormveilArrow_ = 10007430,

        [Display(Name = "[LD - Stormveil] Fireproof Dried Liver 10007440")]
        LDStormveilFireproofDriedLiver = 10007440,

        [Display(Name = "[LD - Stormveil] Chrysalids' Memento 10007450")]
        LDStormveilChrysalidsMemento = 10007450,

        [Display(Name = "[LD - Stormveil] Crimson Hood 10007452")]
        LDStormveilCrimsonHood = 10007452,

        [Display(Name = "[LD - Stormveil] Stanching Boluses 10007460")]
        LDStormveilStanchingBoluses = 10007460,

        [Display(Name = "[LD - Stormveil] Stonesword Key 10007470")]
        LDStormveilStoneswordKey_ = 10007470,

        [Display(Name = "[LD - Stormveil] Nomadic Warrior's Cookbook [10] 67030")]
        LDStormveilNomadicWarriorsCookbook10 = 67030,

        [Display(Name = "[LD - Stormveil] Rusty Key 10007500")]
        LDStormveilRustyKey = 10007500,

        [Display(Name = "[LD - Stormveil] Smithing Stone [1] 10007510")]
        LDStormveilSmithingStone1 = 10007510,

        [Display(Name = "[LD - Stormveil] Golden Rune [1] 10007520")]
        LDStormveilGoldenRune1__ = 10007520,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007530")]
        LDStormveilGoldenRune2_____ = 10007530,

        [Display(Name = "[LD - Stormveil] Ballista Bolt 10007540")]
        LDStormveilBallistaBolt = 10007540,

        [Display(Name = "[LD - Stormveil] Arbalest 10007550")]
        LDStormveilArbalest = 10007550,

        [Display(Name = "[LD - Stormveil] Commoner's Simple Garb 10007560")]
        LDStormveilCommonersSimpleGarb = 10007560,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007570")]
        LDStormveilGoldenRune2______ = 10007570,

        [Display(Name = "[LD - Stormveil] Golden Rune [5] 10007580")]
        LDStormveilGoldenRune5 = 10007580,

        [Display(Name = "[LD - Stormveil] Smithing Stone [2] 10007590")]
        LDStormveilSmithingStone2___ = 10007590,

        [Display(Name = "[LD - Stormveil] Golden Rune [4] 10007600")]
        LDStormveilGoldenRune4 = 10007600,

        [Display(Name = "[LD - Stormveil] Fire Arrow 10007610")]
        LDStormveilFireArrow = 10007610,

        [Display(Name = "[LD - Stormveil] Pike 10007620")]
        LDStormveilPike = 10007620,

        [Display(Name = "[LD - Stormveil] Furlcalling Finger Remedy 10007630")]
        LDStormveilFurlcallingFingerRemedy_ = 10007630,

        [Display(Name = "[LD - Stormveil] Smithing Stone [1] 10007640")]
        LDStormveilSmithingStone1_ = 10007640,

        [Display(Name = "[LD - Stormveil] Smoldering Butterfly 10007650")]
        LDStormveilSmolderingButterfly_ = 10007650,

        [Display(Name = "[LD - Stormveil] Golden Rune [4] 10007660")]
        LDStormveilGoldenRune4_ = 10007660,

        [Display(Name = "[LD - Stormveil] Golden Rune [1] 10007670")]
        LDStormveilGoldenRune1___ = 10007670,

        [Display(Name = "[LD - Stormveil] Mushroom 10007680")]
        LDStormveilMushroom_ = 10007680,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007690")]
        LDStormveilGoldenRune2_______ = 10007690,

        [Display(Name = "[LD - Stormveil] Magic Grease 10007700")]
        LDStormveilMagicGrease = 10007700,

        [Display(Name = "[LD - Stormveil] Smithing Stone [2] 10007710")]
        LDStormveilSmithingStone2____ = 10007710,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007720")]
        LDStormveilGoldenRune2________ = 10007720,

        [Display(Name = "[LD - Stormveil] Golden Seed 10007730")]
        LDStormveilGoldenSeed = 10007730,

        [Display(Name = "[LD - Stormveil] Smithing Stone [2] 10007740")]
        LDStormveilSmithingStone2_____ = 10007740,

        [Display(Name = "[LD - Stormveil] Smithing Stone [1] 10007750")]
        LDStormveilSmithingStone1__ = 10007750,

        [Display(Name = "[LD - Stormveil] Golden Rune [5] 10007760")]
        LDStormveilGoldenRune5_ = 10007760,

        [Display(Name = "[LD - Stormveil] Cracked Pot 66010")]
        LDStormveilCrackedPot = 66010,

        [Display(Name = "[LD - Stormveil] Cracked Pot 66020")]
        LDStormveilCrackedPot_ = 66020,

        [Display(Name = "[LD - Stormveil] Smithing Stone [1] 10007780")]
        LDStormveilSmithingStone1___ = 10007780,

        [Display(Name = "[LD - Stormveil] Kukri 10007790")]
        LDStormveilKukri_ = 10007790,

        [Display(Name = "[LD - Stormveil] Smithing Stone [2] 10007800")]
        LDStormveilSmithingStone2______ = 10007800,

        [Display(Name = "[LD - Stormveil] Lump of Flesh 10007810")]
        LDStormveilLumpOfFlesh_ = 10007810,

        [Display(Name = "[LD - Stormveil] Smithing Stone [1] 10007820")]
        LDStormveilSmithingStone1____ = 10007820,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007830")]
        LDStormveilGoldenRune2_________ = 10007830,

        [Display(Name = "[LD - Stormveil] Smithing Stone [3] 10007840")]
        LDStormveilSmithingStone3_ = 10007840,

        [Display(Name = "[LD - Stormveil] Shabriri Grape 10007850")]
        LDStormveilShabririGrape = 10007850,

        [Display(Name = "[LD - Stormveil] Rainbow Stone 10007860")]
        LDStormveilRainbowStone = 10007860,

        [Display(Name = "[LD - Stormveil] Smithing Stone [2] 10007870")]
        LDStormveilSmithingStone2_______ = 10007870,

        [Display(Name = "[LD - Stormveil] Arteria Leaf 10007880")]
        LDStormveilArteriaLeaf_ = 10007880,

        [Display(Name = "[LD - Stormveil] Golden Rune [2] 10007890")]
        LDStormveilGoldenRune2__________ = 10007890,

        [Display(Name = "[LD - Stormveil] Poisonbloom 10007900")]
        LDStormveilPoisonbloom = 10007900,

        [Display(Name = "[LD - Stormveil] Smoldering Butterfly 10007910")]
        LDStormveilSmolderingButterfly__ = 10007910,

        [Display(Name = "[LD - Stormveil] Stonesword Key 10007920")]
        LDStormveilStoneswordKey__ = 10007920,

        [Display(Name = "[LD - Stormveil] Throwing Dagger 10007930")]
        LDStormveilThrowingDagger__ = 10007930,

        [Display(Name = "[LD - Stormveil] Prince of Death's Pustule 10007940")]
        LDStormveilPrinceOfDeathsPustule = 10007940,

        [Display(Name = "[LD - Stormveil] Kukri 10007950")]
        LDStormveilKukri__ = 10007950,

        [Display(Name = "[LD - Stormveil] Pickled Turtle Neck 10007960")]
        LDStormveilPickledTurtleNeck = 10007960,

        [Display(Name = "[LD - Stormveil] Godslayer's Seal 10007965")]
        LDStormveilGodslayersSeal = 10007965,

        [Display(Name = "[LD - Stormveil] Mimic's Veil 10007970")]
        LDStormveilMimicsVeil = 10007970,

        [Display(Name = "[LD - Stormveil] Curved Sword Talisman 10007975")]
        LDStormveilCurvedSwordTalisman = 10007975,

        [Display(Name = "[LD - Stormveil] Somber Smithing Stone [2] 10007980")]
        LDStormveilSomberSmithingStone2_ = 10007980,

        [Display(Name = "[LD - Stormveil] Godskin Prayerbook 10007990")]
        LDStormveilGodskinPrayerbook = 10007990,

        [Display(Name = "[LD - Stormveil] Somber Smithing Stone [1] 10007085")]
        LDStormveilSomberSmithingStone1 = 10007085,

        [Display(Name = "[LD - Stormveil] Golden Seed 10007195")]
        LDStormveilGoldenSeed_ = 10007195,

        [Display(Name = "[LD - Stormveil] [Incantation] Aspects of the Crucible: Horns 10007295")]
        LDStormveilIncantationAspectsOfTheCrucibleHorns = 10007295,

        [Display(Name = "[LD - Stormveil] Wooden Greatshield 10007005")]
        LDStormveilWoodenGreatshield = 10007005,

        [Display(Name = "[LD - Stormveil] Hawk Crest Wooden Shield 10007015")]
        LDStormveilHawkCrestWoodenShield = 10007015,

        [Display(Name = "[LD - Stormveil] Misericorde 10007025")]
        LDStormveilMisericorde = 10007025,

        [Display(Name = "[LD - Stormveil] Brick Hammer 10007035")]
        LDStormveilBrickHammer = 10007035,

        [Display(Name = "[LD - Chapel of Anticipation] Tarnished's Wizened Finger 60210")]
        LDChapelOfAnticipationTarnishedsWizenedFinger = 60210,

        [Display(Name = "[LD - Chapel of Anticipation] The Stormhawk King 10017010")]
        LDChapelOfAnticipationTheStormhawkKing = 10017010,

        [Display(Name = "[LD - Chapel of Anticipation] Stormhawk Deenh 10017900")]
        LDChapelOfAnticipationStormhawkDeenh = 10017900,

        [Display(Name = "[LD - Leyndell] Magic Grease 11007000")]
        LDLeyndellMagicGrease = 11007000,

        [Display(Name = "[LD - Leyndell] Furlcalling Finger Remedy 11007010")]
        LDLeyndellFurlcallingFingerRemedy = 11007010,

        [Display(Name = "[LD - Leyndell] Hefty Beast Bone 11007020")]
        LDLeyndellHeftyBeastBone = 11007020,

        [Display(Name = "[LD - Leyndell] Smithing Stone [4] 11007030")]
        LDLeyndellSmithingStone4 = 11007030,

        [Display(Name = "[LD - Leyndell] Golden Rune [7] 11007040")]
        LDLeyndellGoldenRune7 = 11007040,

        [Display(Name = "[LD - Leyndell] Cave Moss 11007050")]
        LDLeyndellCaveMoss = 11007050,

        [Display(Name = "[LD - Leyndell] Preserving Boluses 11007060")]
        LDLeyndellPreservingBoluses = 11007060,

        [Display(Name = "[LD - Leyndell] String 11007070")]
        LDLeyndellString = 11007070,

        [Display(Name = "[LD - Leyndell] Upper-Class Robe 11007080")]
        LDLeyndellUpperClassRobe = 11007080,

        [Display(Name = "[LD - Leyndell] Miranda Powder 11007090")]
        LDLeyndellMirandaPowder = 11007090,

        [Display(Name = "[LD - Leyndell] Smithing Stone [6] 11007100")]
        LDLeyndellSmithingStone6 = 11007100,

        [Display(Name = "[LD - Leyndell] Warming Stone 11007110")]
        LDLeyndellWarmingStone = 11007110,

        [Display(Name = "[LD - Leyndell] Golden Rune [10] 11007120")]
        LDLeyndellGoldenRune10 = 11007120,

        [Display(Name = "[LD - Leyndell] Perfume Bottle 66710")]
        LDLeyndellPerfumeBottle = 66710,

        [Display(Name = "[LD - Leyndell] Fan Daggers 11007140")]
        LDLeyndellFanDaggers = 11007140,

        [Display(Name = "[LD - Leyndell] Marika's Golden Siigl 11007150")]
        LDLeyndellMarikasGoldenSiigl = 11007150,

        [Display(Name = "[LD - Leyndell] Holy Grease 11007160")]
        LDLeyndellHolyGrease = 11007160,

        [Display(Name = "[LD - Leyndell] Golden Rune [8] 11007170")]
        LDLeyndellGoldenRune8 = 11007170,

        [Display(Name = "[LD - Leyndell] Old Fang 11007180")]
        LDLeyndellOldFang = 11007180,

        [Display(Name = "[LD - Leyndell] Smithing Stone [4] 11007190")]
        LDLeyndellSmithingStone4_ = 11007190,

        [Display(Name = "[LD - Leyndell] Golden Rune [8] 11007200")]
        LDLeyndellGoldenRune8_ = 11007200,

        [Display(Name = "[LD - Leyndell] Somber Smithing Stone [5] 11007210")]
        LDLeyndellSomberSmithingStone5 = 11007210,

        [Display(Name = "[LD - Leyndell] Golden Rune [8] 11007220")]
        LDLeyndellGoldenRune8__ = 11007220,

        [Display(Name = "[LD - Leyndell] Lordsworn's Bolt 11007230")]
        LDLeyndellLordswornsBolt = 11007230,

        [Display(Name = "[LD - Leyndell] Tarnished Golden Sunflower 11007240")]
        LDLeyndellTarnishedGoldenSunflower = 11007240,

        [Display(Name = "[LD - Leyndell] Stonesword Key 11007250")]
        LDLeyndellStoneswordKey = 11007250,

        [Display(Name = "[LD - Leyndell] Golden Rune [10] 11007260")]
        LDLeyndellGoldenRune10_ = 11007260,

        [Display(Name = "[LD - Leyndell] Golden Rune [8] 11007270")]
        LDLeyndellGoldenRune8___ = 11007270,

        [Display(Name = "[LD - Leyndell] Golden Rune [9] 11007280")]
        LDLeyndellGoldenRune9 = 11007280,

        [Display(Name = "[LD - Leyndell] Smithing Stone [6] 11007290")]
        LDLeyndellSmithingStone6_ = 11007290,

        [Display(Name = "[LD - Leyndell] Golden Rune [9] 11007300")]
        LDLeyndellGoldenRune9_ = 11007300,

        [Display(Name = "[LD - Leyndell] Arteria Leaf 11007310")]
        LDLeyndellArteriaLeaf = 11007310,

        [Display(Name = "[LD - Leyndell] Imp Head (Corpse) 11007320")]
        LDLeyndellImpHeadCorpse = 11007320,

        [Display(Name = "[LD - Leyndell] Golden Rune [9] 11007330")]
        LDLeyndellGoldenRune9__ = 11007330,

        [Display(Name = "[LD - Leyndell] Seedbed Curse 11007340")]
        LDLeyndellSeedbedCurse = 11007340,

        [Display(Name = "[LD - Leyndell] Smithing Stone [6] 11007350")]
        LDLeyndellSmithingStone6__ = 11007350,

        [Display(Name = "[LD - Leyndell] Golden Rune [9] 11007360")]
        LDLeyndellGoldenRune9___ = 11007360,

        [Display(Name = "[LD - Leyndell] Smithing Stone [5] 11007370")]
        LDLeyndellSmithingStone5 = 11007370,

        [Display(Name = "[LD - Leyndell] Stonesword Key 11007380")]
        LDLeyndellStoneswordKey_ = 11007380,

        [Display(Name = "[LD - Leyndell] Golden Rune [12] 11007390")]
        LDLeyndellGoldenRune12 = 11007390,

        [Display(Name = "[LD - Leyndell] Beast Blood 11007400")]
        LDLeyndellBeastBlood = 11007400,

        [Display(Name = "[LD - Leyndell] Nascent Butterfly 11007410")]
        LDLeyndellNascentButterfly = 11007410,

        [Display(Name = "[LD - Leyndell] Exalted Flesh 11007420")]
        LDLeyndellExaltedFlesh = 11007420,

        [Display(Name = "[LD - Leyndell] Soporific Grease 11007430")]
        LDLeyndellSoporificGrease = 11007430,

        [Display(Name = "[LD - Leyndell] Somber Smithing Stone [6] 11007440")]
        LDLeyndellSomberSmithingStone6 = 11007440,

        [Display(Name = "[LD - Leyndell] Golden Rune [9] 11007450")]
        LDLeyndellGoldenRune9____ = 11007450,

        [Display(Name = "[LD - Leyndell] Lightningproof Dried Liver 11007460")]
        LDLeyndellLightningproofDriedLiver = 11007460,

        [Display(Name = "[LD - Leyndell] Perfume Bottle 66720")]
        LDLeyndellPerfumeBottle_ = 66720,

        [Display(Name = "[LD - Leyndell] Gravel Stone 11007480")]
        LDLeyndellGravelStone = 11007480,

        [Display(Name = "[LD - Leyndell] Stonesword Key 11007490")]
        LDLeyndellStoneswordKey__ = 11007490,

        [Display(Name = "[LD - Leyndell] Golden Rune [9] 11007500")]
        LDLeyndellGoldenRune9_____ = 11007500,

        [Display(Name = "[LD - Leyndell] Smithing Stone [4] 11007510")]
        LDLeyndellSmithingStone4__ = 11007510,

        [Display(Name = "[LD - Leyndell] Golden Arrow 11007520")]
        LDLeyndellGoldenArrow = 11007520,

        [Display(Name = "[LD - Leyndell] Smithing Stone [6] 11007530")]
        LDLeyndellSmithingStone6___ = 11007530,

        [Display(Name = "[LD - Leyndell] Clarifying Boluses 11007540")]
        LDLeyndellClarifyingBoluses = 11007540,

        [Display(Name = "[LD - Leyndell] Golden Rune [8] 11007550")]
        LDLeyndellGoldenRune8____ = 11007550,

        [Display(Name = "[LD - Leyndell] Cracked Pot 66130")]
        LDLeyndellCrackedPot = 66130,

        [Display(Name = "[LD - Leyndell] Lost Ashes of War 11007570")]
        LDLeyndellLostAshesOfWar = 11007570,

        [Display(Name = "[LD - Leyndell] Rune Arc 11007580")]
        LDLeyndellRuneArc = 11007580,

        [Display(Name = "[LD - Leyndell] Erdsteel Dagger 11007590")]
        LDLeyndellErdsteelDagger = 11007590,

        [Display(Name = "[LD - Leyndell] Poisonbone Dart 11007600")]
        LDLeyndellPoisonboneDart = 11007600,

        [Display(Name = "[LD - Leyndell] Somber Smithing Stone [6] 11007610")]
        LDLeyndellSomberSmithingStone6_ = 11007610,

        [Display(Name = "[LD - Leyndell] Albinauric Bloodclot 11007620")]
        LDLeyndellAlbinauricBloodclot = 11007620,

        [Display(Name = "[LD - Leyndell] Smithing Stone [5] 11007630")]
        LDLeyndellSmithingStone5_ = 11007630,

        [Display(Name = "[LD - Leyndell] Pickled Turtle Neck 11007640")]
        LDLeyndellPickledTurtleNeck = 11007640,

        [Display(Name = "[LD - Leyndell] Smithing Stone [6] 11007650")]
        LDLeyndellSmithingStone6____ = 11007650,

        [Display(Name = "[LD - Leyndell] Golden Rune [9] 11007660")]
        LDLeyndellGoldenRune9______ = 11007660,

        [Display(Name = "[LD - Leyndell] Black Bow 11007670")]
        LDLeyndellBlackBow = 11007670,

        [Display(Name = "[LD - Leyndell] Dragonwound Grease 11007680")]
        LDLeyndellDragonwoundGrease = 11007680,

        [Display(Name = "[LD - Leyndell] Two Fingers' Prayerbook 11007690")]
        LDLeyndellTwoFingersPrayerbook = 11007690,

        [Display(Name = "[LD - Leyndell] Smithing Stone [5] 11007700")]
        LDLeyndellSmithingStone5__ = 11007700,

        [Display(Name = "[LD - Leyndell] Golden Rune [9] 11007710")]
        LDLeyndellGoldenRune9_______ = 11007710,

        [Display(Name = "[LD - Leyndell] Smithing Stone [6] 11007720")]
        LDLeyndellSmithingStone6_____ = 11007720,

        [Display(Name = "[LD - Leyndell] Holyproof Dried Liver 11007730")]
        LDLeyndellHolyproofDriedLiver = 11007730,

        [Display(Name = "[LD - Leyndell] Furlcalling Finger Remedy 11007740")]
        LDLeyndellFurlcallingFingerRemedy_ = 11007740,

        [Display(Name = "[LD - Leyndell] Gravel Stone 11007750")]
        LDLeyndellGravelStone_ = 11007750,

        [Display(Name = "[LD - Leyndell] Smithing Stone [5] 11007760")]
        LDLeyndellSmithingStone5___ = 11007760,

        [Display(Name = "[LD - Leyndell] Old Fang 11007770")]
        LDLeyndellOldFang_ = 11007770,

        [Display(Name = "[LD - Leyndell] Smithing Stone [6] 11007780")]
        LDLeyndellSmithingStone6______ = 11007780,

        [Display(Name = "[LD - Leyndell] Nascent Butterfly 11007790")]
        LDLeyndellNascentButterfly_ = 11007790,

        [Display(Name = "[LD - Leyndell] Stonesword Key 11007800")]
        LDLeyndellStoneswordKey___ = 11007800,

        [Display(Name = "[LD - Leyndell] Fan Daggers 11007810")]
        LDLeyndellFanDaggers_ = 11007810,

        [Display(Name = "[LD - Leyndell] Smithing Stone [6] 11007820")]
        LDLeyndellSmithingStone6_______ = 11007820,

        [Display(Name = "[LD - Leyndell] Golden Rune [9] 11007830")]
        LDLeyndellGoldenRune9________ = 11007830,

        [Display(Name = "[LD - Leyndell] Gravel Stone 11007840")]
        LDLeyndellGravelStone__ = 11007840,

        [Display(Name = "[LD - Leyndell] Seedbed Curse 11007850")]
        LDLeyndellSeedbedCurse_ = 11007850,

        [Display(Name = "[LD - Leyndell] Smithing Stone [5] 11007860")]
        LDLeyndellSmithingStone5____ = 11007860,

        [Display(Name = "[LD - Leyndell] Furlcalling Finger Remedy 11007870")]
        LDLeyndellFurlcallingFingerRemedy__ = 11007870,

        [Display(Name = "[LD - Leyndell] Star Fist 11007880")]
        LDLeyndellStarFist = 11007880,

        [Display(Name = "[LD - Leyndell] Holy Grease 11007890")]
        LDLeyndellHolyGrease_ = 11007890,

        [Display(Name = "[LD - Leyndell] Smithing Stone [6] 11007900")]
        LDLeyndellSmithingStone6________ = 11007900,

        [Display(Name = "[LD - Leyndell] Golden Order Principia 11007910")]
        LDLeyndellGoldenOrderPrincipia = 11007910,

        [Display(Name = "[LD - Leyndell] Somber Smithing Stone [5] 11007920")]
        LDLeyndellSomberSmithingStone5_ = 11007920,

        [Display(Name = "[LD - Leyndell] Holy Grease 11007930")]
        LDLeyndellHolyGrease__ = 11007930,

        [Display(Name = "[LD - Leyndell] Holy Grease 11007940")]
        LDLeyndellHolyGrease___ = 11007940,

        [Display(Name = "[LD - Leyndell] Rune Arc 11007950")]
        LDLeyndellRuneArc_ = 11007950,

        [Display(Name = "[LD - Leyndell] Erdtree Seal 11007960")]
        LDLeyndellErdtreeSeal = 11007960,

        [Display(Name = "[LD - Leyndell] Coded Sword 11007970")]
        LDLeyndellCodedSword = 11007970,

        [Display(Name = "[LD - Leyndell] Stonesword Key 11007980")]
        LDLeyndellStoneswordKey____ = 11007980,

        [Display(Name = "[LD - Leyndell] Raging Wolf Helm 11007985")]
        LDLeyndellRagingWolfHelm = 11007985,

        [Display(Name = "[LD - Leyndell] Golden Seed 11007990")]
        LDLeyndellGoldenSeed = 11007990,

        [Display(Name = "[LD - Leyndell] [Incantation] Blessing of the Erdtree 11007991")]
        LDLeyndellIncantationBlessingOfTheErdtree = 11007991,

        [Display(Name = "[LD - Leyndell] Sanctified Whetblade 65660")]
        LDLeyndellSanctifiedWhetblade = 65660,

        [Display(Name = "[LD - Leyndell] Blessed Dew Talisman 11007994")]
        LDLeyndellBlessedDewTalisman = 11007994,

        [Display(Name = "[LD - Leyndell] Ritual Shield Talisman 11007996")]
        LDLeyndellRitualShieldTalisman = 11007996,

        [Display(Name = "[LD - Leyndell] Bolt of Gransax 11007997")]
        LDLeyndellBoltOfGransax = 11007997,

        [Display(Name = "[LD - Leyndell] Gargoyle's Halberd 11007987")]
        LDLeyndellGargoylesHalberd = 11007987,

        [Display(Name = "[LD - Leyndell] Golden Seed 11007993")]
        LDLeyndellGoldenSeed_ = 11007993,

        [Display(Name = "[LD - Leyndell] Somber Smithing Stone [7] 11007995")]
        LDLeyndellSomberSmithingStone7 = 11007995,

        [Display(Name = "[LD - Leyndell] Lord's Rune 11007998")]
        LDLeyndellLordsRune = 11007998,

        [Display(Name = "[LD - Leyndell] Alberich's Pointed Hat 11007005")]
        LDLeyndellAlberichsPointedHat = 11007005,

        [Display(Name = "[LD - Leyndell] Erdtree Bow 11007015")]
        LDLeyndellErdtreeBow = 11007015,

        [Display(Name = "[LD - Leyndell] Celestial Dew 11007025")]
        LDLeyndellCelestialDew = 11007025,

        [Display(Name = "[LD - Leyndell] Deathbed Dress 11007035")]
        LDLeyndellDeathbedDress = 11007035,

        [Display(Name = "[LD - Leyndell] Lionel's Helm 11007045")]
        LDLeyndellLionelsHelm = 11007045,

        [Display(Name = "[LD - Leyndell] Hammer 11007055")]
        LDLeyndellHammer = 11007055,

        [Display(Name = "[LD - Leyndell] Rune Arc 11007065")]
        LDLeyndellRuneArc__ = 11007065,

        [Display(Name = "[LD - Leyndell] Hero's Rune [1] 11007075")]
        LDLeyndellHerosRune1 = 11007075,

        [Display(Name = "[LD - Leyndell] Golden Rune [12] 11007085")]
        LDLeyndellGoldenRune12_ = 11007085,

        [Display(Name = "[LD - Leyndell] Guilty Hood 11007095")]
        LDLeyndellGuiltyHood = 11007095,

        [Display(Name = "[LD - Leyndell] Stormhawk Axe 11007105")]
        LDLeyndellStormhawkAxe = 11007105,

        [Display(Name = "[LD - Leyndell] Cane Sword 11007115")]
        LDLeyndellCaneSword = 11007115,

        [Display(Name = "[LD - Leyndell] Black-Key Bolt 11007125")]
        LDLeyndellBlackKeyBolt = 11007125,

        [Display(Name = "[LD - Leyndell] Gravel Stone 11007135")]
        LDLeyndellGravelStone___ = 11007135,

        [Display(Name = "[LD - Leyndell] Somber Smithing Stone [6] 11007145")]
        LDLeyndellSomberSmithingStone6__ = 11007145,

        [Display(Name = "[LD - Leyndell] Hero's Rune [5] 11007155")]
        LDLeyndellHerosRune5 = 11007155,

        [Display(Name = "[LD - Leyndell] Golden Rune [11] 11007165")]
        LDLeyndellGoldenRune11 = 11007165,

        [Display(Name = "[LD - Leyndell] Hero's Rune [2] 11007175")]
        LDLeyndellHerosRune2 = 11007175,

        [Display(Name = "[LD - Leyndell] Somber Smithing Stone [6] 11007185")]
        LDLeyndellSomberSmithingStone6___ = 11007185,

        [Display(Name = "[LD - Leyndell] Somber Smithing Stone [6] 11007195")]
        LDLeyndellSomberSmithingStone6____ = 11007195,

        [Display(Name = "[LD - Leyndell] Golden Rune [13] 11007205")]
        LDLeyndellGoldenRune13 = 11007205,

        [Display(Name = "[LD - Leyndell] Golden Rune [10] 11007215")]
        LDLeyndellGoldenRune10__ = 11007215,

        [Display(Name = "[LD - Leyndell] Golden Rune [12] 11007225")]
        LDLeyndellGoldenRune12__ = 11007225,

        [Display(Name = "[LD - Leyndell] Lightningproof Dried Liver 11007235")]
        LDLeyndellLightningproofDriedLiver_ = 11007235,

        [Display(Name = "[LD - Leyndell] Golden Rune [11] 11007245")]
        LDLeyndellGoldenRune11_ = 11007245,

        [Display(Name = "[LD - Ashen Leyndell] Erdtree Heal 11057000")]
        LDAshenLeyndellErdtreeHeal = 11057000,

        [Display(Name = "[LD - Ashen Leyndell] Somber Ancient Dragon Smithing Stone 11057010")]
        LDAshenLeyndellSomberAncientDragonSmithingStone = 11057010,

        [Display(Name = "[LD - Ashen Leyndell] Tarnished Golden Sunflower 11057020")]
        LDAshenLeyndellTarnishedGoldenSunflower = 11057020,

        [Display(Name = "[LD - Ashen Leyndell] Rune Arc 11057030")]
        LDAshenLeyndellRuneArc = 11057030,

        [Display(Name = "[LD - Ashen Leyndell] Golden Sunflower 11057040")]
        LDAshenLeyndellGoldenSunflower = 11057040,

        [Display(Name = "[LD - Ashen Leyndell] Hero's Rune [4] 11057050")]
        LDAshenLeyndellHerosRune4 = 11057050,

        [Display(Name = "[LD - Ashen Leyndell] Erdtree's Favor +2 11057100")]
        LDAshenLeyndellErdtreesFavor2 = 11057100,

        [Display(Name = "[LD - Roundtable Hold] Cipher Pata 11107000")]
        LDRoundtableHoldCipherPata = 11107000,

        [Display(Name = "[LD - Roundtable Hold] Assassin's Prayerbook 11107700")]
        LDRoundtableHoldAssassinsPrayerbook = 11107700,

        [Display(Name = "[LD - Roundtable Hold] Crepus's Black-Key Crossbow 11107710")]
        LDRoundtableHoldCrepussBlackKeyCrossbow = 11107710,

        [Display(Name = "[LD - Roundtable Hold] Taunter's Tongue 60300")]
        LDRoundtableHoldTauntersTongue = 60300,

        [Display(Name = "[LD - Roundtable Hold] Clinging Bone 11107900")]
        LDRoundtableHoldClingingBone = 11107900,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Map: Ainsel 62060")]
        LDAinselLakeOfRotMapAinsel = 62060,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Map: Lake of Rot 62061")]
        LDAinselLakeOfRotMapLakeOfRot = 62061,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Nomadic Warrior's Cookbook [22] 67890")]
        LDAinselLakeOfRotNomadicWarriorsCookbook22 = 67890,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [8] 12017030")]
        LDAinselLakeOfRotSomberSmithingStone8 = 12017030,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [1] 12017040")]
        LDAinselLakeOfRotGoldenRune1 = 12017040,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [2] 12017050")]
        LDAinselLakeOfRotGoldenRune2 = 12017050,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [1] 12017060")]
        LDAinselLakeOfRotSmithingStone1 = 12017060,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Magic Grease 12017070")]
        LDAinselLakeOfRotMagicGrease = 12017070,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [3] 12017080")]
        LDAinselLakeOfRotGoldenRune3 = 12017080,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [9] 12017090")]
        LDAinselLakeOfRotSomberSmithingStone9 = 12017090,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Seed 12017100")]
        LDAinselLakeOfRotGoldenSeed = 12017100,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Rot Grease 12017110")]
        LDAinselLakeOfRotRotGrease = 12017110,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Black-Key Bolt 12017120")]
        LDAinselLakeOfRotBlackKeyBolt = 12017120,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Warming Stone 12017130")]
        LDAinselLakeOfRotWarmingStone = 12017130,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Lightningproof Dried Liver 12017140")]
        LDAinselLakeOfRotLightningproofDriedLiver = 12017140,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [3] 12017150")]
        LDAinselLakeOfRotSmithingStone3 = 12017150,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Shattershard Arrow (Fletched) 12017160")]
        LDAinselLakeOfRotShattershardArrowFletched = 12017160,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Grace Mimic 12017170")]
        LDAinselLakeOfRotGraceMimic = 12017170,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Immunizing Horn Charm 12017180")]
        LDAinselLakeOfRotImmunizingHornCharm = 12017180,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [3] 12017190")]
        LDAinselLakeOfRotSmithingStone3_ = 12017190,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [1] 12017200")]
        LDAinselLakeOfRotGoldenRune1_ = 12017200,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [3] 12017210")]
        LDAinselLakeOfRotSmithingStone3__ = 12017210,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Throwing Dagger 12017220")]
        LDAinselLakeOfRotThrowingDagger = 12017220,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [3] 12017230")]
        LDAinselLakeOfRotSmithingStone3___ = 12017230,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [2] 12017240")]
        LDAinselLakeOfRotGoldenRune2_ = 12017240,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Shield Grease 12017250")]
        LDAinselLakeOfRotShieldGrease = 12017250,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [3] 12017260")]
        LDAinselLakeOfRotSmithingStone3____ = 12017260,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [4] 12017270")]
        LDAinselLakeOfRotSmithingStone4 = 12017270,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [2] 12017280")]
        LDAinselLakeOfRotSmithingStone2 = 12017280,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Formic Rock 12017290")]
        LDAinselLakeOfRotFormicRock = 12017290,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Crystal Dart 12017300")]
        LDAinselLakeOfRotCrystalDart = 12017300,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Soap 12017310")]
        LDAinselLakeOfRotSoap = 12017310,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [3] 12017320")]
        LDAinselLakeOfRotSomberSmithingStone3 = 12017320,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Melted Mushroom 12017330")]
        LDAinselLakeOfRotMeltedMushroom = 12017330,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [3] 12017340")]
        LDAinselLakeOfRotGoldenRune3_ = 12017340,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Celestial Dew 12017350")]
        LDAinselLakeOfRotCelestialDew = 12017350,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [3] 12017360")]
        LDAinselLakeOfRotGoldenRune3__ = 12017360,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Aeonian Butterfly 12017370")]
        LDAinselLakeOfRotAeonianButterfly = 12017370,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017380")]
        LDAinselLakeOfRotSomberSmithingStone7 = 12017380,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Silver Firefly 12017390")]
        LDAinselLakeOfRotSilverFirefly = 12017390,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [3] 12017400")]
        LDAinselLakeOfRotGoldenRune3___ = 12017400,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Magic Grease 12017410")]
        LDAinselLakeOfRotMagicGrease_ = 12017410,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [3] 12017420")]
        LDAinselLakeOfRotGoldenRune3____ = 12017420,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Furlcalling Finger Remedy 12017430")]
        LDAinselLakeOfRotFurlcallingFingerRemedy = 12017430,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [1] 12017440")]
        LDAinselLakeOfRotSmithingStone1_ = 12017440,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [9] 12017450")]
        LDAinselLakeOfRotGoldenRune9 = 12017450,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Mushroom Crown 12017460")]
        LDAinselLakeOfRotMushroomCrown = 12017460,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Preserving Boluses 12017470")]
        LDAinselLakeOfRotPreservingBoluses = 12017470,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [7] 12017480")]
        LDAinselLakeOfRotGoldenRune7 = 12017480,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017490")]
        LDAinselLakeOfRotGoldenRune10 = 12017490,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [7] 12017500")]
        LDAinselLakeOfRotGoldenRune7_ = 12017500,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Human Bone Shard 12017510")]
        LDAinselLakeOfRotHumanBoneShard = 12017510,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [6] 12017520")]
        LDAinselLakeOfRotSomberSmithingStone6 = 12017520,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [4] 12017530")]
        LDAinselLakeOfRotSmithingStone4_ = 12017530,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Stimulating Boluses 12017540")]
        LDAinselLakeOfRotStimulatingBoluses = 12017540,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Shield Grease 12017550")]
        LDAinselLakeOfRotShieldGrease_ = 12017550,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017560")]
        LDAinselLakeOfRotGoldenRune10_ = 12017560,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Wing of Astel 12017570")]
        LDAinselLakeOfRotWingOfAstel = 12017570,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Stonesword Key 12017580")]
        LDAinselLakeOfRotStoneswordKey = 12017580,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [7] 12017590")]
        LDAinselLakeOfRotGoldenRune7__ = 12017590,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017600")]
        LDAinselLakeOfRotGoldenRune10__ = 12017600,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Fan Daggers 12017610")]
        LDAinselLakeOfRotFanDaggers = 12017610,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [6] 12017620")]
        LDAinselLakeOfRotSmithingStone6 = 12017620,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Archer Ashes 12017630")]
        LDAinselLakeOfRotArcherAshes = 12017630,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017640")]
        LDAinselLakeOfRotGoldenRune10___ = 12017640,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017650")]
        LDAinselLakeOfRotGoldenRune10____ = 12017650,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017660")]
        LDAinselLakeOfRotGoldenRune10_____ = 12017660,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [6] 12017670")]
        LDAinselLakeOfRotSmithingStone6_ = 12017670,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017680")]
        LDAinselLakeOfRotGoldenRune10______ = 12017680,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Great Ghost Glovewort 12017690")]
        LDAinselLakeOfRotGreatGhostGlovewort = 12017690,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017700")]
        LDAinselLakeOfRotSomberSmithingStone7_ = 12017700,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Clayman Ashes 12017710")]
        LDAinselLakeOfRotClaymanAshes = 12017710,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Stonesword Key 12017720")]
        LDAinselLakeOfRotStoneswordKey_ = 12017720,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Magic Grease 12017730")]
        LDAinselLakeOfRotMagicGrease__ = 12017730,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Drawstring Holy Grease 12017740")]
        LDAinselLakeOfRotDrawstringHolyGrease = 12017740,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Silver Tear Husk 12017750")]
        LDAinselLakeOfRotSilverTearHusk = 12017750,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [6] 12017760")]
        LDAinselLakeOfRotSmithingStone6__ = 12017760,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Celestial Dew 12017770")]
        LDAinselLakeOfRotCelestialDew_ = 12017770,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017780")]
        LDAinselLakeOfRotSomberSmithingStone7__ = 12017780,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Celestial Dew 12017790")]
        LDAinselLakeOfRotCelestialDew__ = 12017790,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [4] 12017800")]
        LDAinselLakeOfRotSmithingStone4__ = 12017800,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [5] 12017810")]
        LDAinselLakeOfRotSmithingStone5 = 12017810,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017820")]
        LDAinselLakeOfRotGoldenRune10_______ = 12017820,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [5] 12017830")]
        LDAinselLakeOfRotSmithingStone5_ = 12017830,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Fan Daggers 12017840")]
        LDAinselLakeOfRotFanDaggers_ = 12017840,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017850")]
        LDAinselLakeOfRotGoldenRune10________ = 12017850,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [7] 12017860")]
        LDAinselLakeOfRotSmithingStone7 = 12017860,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [6] 12017870")]
        LDAinselLakeOfRotSmithingStone6___ = 12017870,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [8] 12017880")]
        LDAinselLakeOfRotSomberSmithingStone8_ = 12017880,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017890")]
        LDAinselLakeOfRotSomberSmithingStone7___ = 12017890,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Wing of Astel 12017900")]
        LDAinselLakeOfRotWingOfAstel_ = 12017900,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Great Ghost Glovewort 12017910")]
        LDAinselLakeOfRotGreatGhostGlovewort_ = 12017910,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Scorpion's Stinger 12017920")]
        LDAinselLakeOfRotScorpionsStinger = 12017920,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Fire Longsword 12017930")]
        LDAinselLakeOfRotFireLongsword = 12017930,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017940")]
        LDAinselLakeOfRotSomberSmithingStone7____ = 12017940,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Ghost Glovewort [9] 12017950")]
        LDAinselLakeOfRotGhostGlovewort9 = 12017950,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Moon of Nokstella 12017960")]
        LDAinselLakeOfRotMoonOfNokstella = 12017960,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Ant's Skull Plate 12017970")]
        LDAinselLakeOfRotAntsSkullPlate = 12017970,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Ghost-Glovewort Picker's Bell Bearing [2] 12017980")]
        LDAinselLakeOfRotGhostGlovewortPickersBellBearing2 = 12017980,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Nightmaiden & Swordstress Puppets 12017990")]
        LDAinselLakeOfRotNightmaidenSwordstressPuppets = 12017990,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017995")]
        LDAinselLakeOfRotSomberSmithingStone7_____ = 12017995,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Seed 12017997")]
        LDAinselLakeOfRotGoldenSeed_ = 12017997,

        [Display(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017105")]
        LDAinselLakeOfRotGoldenRune10_________ = 12017105,

        [Display(Name = "[LD - Nokron / Siofra] Mottled Necklace 12027000")]
        LDNokronSiofraMottledNecklace = 12027000,

        [Display(Name = "[LD - Nokron / Siofra] Black Whetblade 65720")]
        LDNokronSiofraBlackWhetblade = 65720,

        [Display(Name = "[LD - Nokron / Siofra] Missionary's Cookbook [5] 67630")]
        LDNokronSiofraMissionarysCookbook5 = 67630,

        [Display(Name = "[LD - Nokron / Siofra] Arteria Leaf 12027030")]
        LDNokronSiofraArteriaLeaf = 12027030,

        [Display(Name = "[LD - Nokron / Siofra] Golden Seed 12027040")]
        LDNokronSiofraGoldenSeed = 12027040,

        [Display(Name = "[LD - Nokron / Siofra] Marika's Scarseal 12027050")]
        LDNokronSiofraMarikasScarseal = 12027050,

        [Display(Name = "[LD - Nokron / Siofra] Map: Siofra River 62063")]
        LDNokronSiofraMapSiofraRiver = 62063,

        [Display(Name = "[LD - Nokron / Siofra] Lightning Bastard Sword 12027070")]
        LDNokronSiofraLightningBastardSword = 12027070,

        [Display(Name = "[LD - Nokron / Siofra] Fingerslayer Blade 12027080")]
        LDNokronSiofraFingerslayerBlade = 12027080,

        [Display(Name = "[LD - Nokron / Siofra] Ancestral Infant's Head 12027090")]
        LDNokronSiofraAncestralInfantsHead = 12027090,

        [Display(Name = "[LD - Nokron / Siofra] Crab Eggs 12027100")]
        LDNokronSiofraCrabEggs = 12027100,

        [Display(Name = "[LD - Nokron / Siofra] Beast Liver 12027110")]
        LDNokronSiofraBeastLiver = 12027110,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [3] 12027120")]
        LDNokronSiofraGoldenRune3 = 12027120,

        [Display(Name = "[LD - Nokron / Siofra] Armorer's Cookbook [6] 67300")]
        LDNokronSiofraArmorersCookbook6 = 67300,

        [Display(Name = "[LD - Nokron / Siofra] Inverted Hawk Heater Shield 12027140")]
        LDNokronSiofraInvertedHawkHeaterShield = 12027140,

        [Display(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [2] 12027150")]
        LDNokronSiofraSomberSmithingStone2 = 12027150,

        [Display(Name = "[LD - Nokron / Siofra] Old Fang 12027160")]
        LDNokronSiofraOldFang = 12027160,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [2] 12027170")]
        LDNokronSiofraGoldenRune2 = 12027170,

        [Display(Name = "[LD - Nokron / Siofra] Shield Grease 12027180")]
        LDNokronSiofraShieldGrease = 12027180,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [3] 12027190")]
        LDNokronSiofraGoldenRune3_ = 12027190,

        [Display(Name = "[LD - Nokron / Siofra] Dappled Cured Meat 12027200")]
        LDNokronSiofraDappledCuredMeat = 12027200,

        [Display(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [2] 12027210")]
        LDNokronSiofraSomberSmithingStone2_ = 12027210,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [3] 12027220")]
        LDNokronSiofraSmithingStone3 = 12027220,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [2] 12027230")]
        LDNokronSiofraSmithingStone2 = 12027230,

        [Display(Name = "[LD - Nokron / Siofra] Dwelling Arrow 12027240")]
        LDNokronSiofraDwellingArrow = 12027240,

        [Display(Name = "[LD - Nokron / Siofra] Gold-Pickled Fowl Foot 12027250")]
        LDNokronSiofraGoldPickledFowlFoot = 12027250,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027260")]
        LDNokronSiofraGoldenRune4 = 12027260,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027270")]
        LDNokronSiofraGoldenRune4_ = 12027270,

        [Display(Name = "[LD - Nokron / Siofra] Furlcalling Finger Remedy 12027280")]
        LDNokronSiofraFurlcallingFingerRemedy = 12027280,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027290")]
        LDNokronSiofraGoldenRune4__ = 12027290,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [4] 12027300")]
        LDNokronSiofraSmithingStone4 = 12027300,

        [Display(Name = "[LD - Nokron / Siofra] Hefty Beast Bone 12027310")]
        LDNokronSiofraHeftyBeastBone = 12027310,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [6] 12027320")]
        LDNokronSiofraGoldenRune6 = 12027320,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [3] 12027330")]
        LDNokronSiofraGoldenRune3__ = 12027330,

        [Display(Name = "[LD - Nokron / Siofra] Sliver of Meat 12027340")]
        LDNokronSiofraSliverOfMeat = 12027340,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [3] 12027350")]
        LDNokronSiofraSmithingStone3_ = 12027350,

        [Display(Name = "[LD - Nokron / Siofra] Gold-Pickled Fowl Foot 12027360")]
        LDNokronSiofraGoldPickledFowlFoot_ = 12027360,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027370")]
        LDNokronSiofraGoldenRune4___ = 12027370,

        [Display(Name = "[LD - Nokron / Siofra] Dwelling Arrow 12027380")]
        LDNokronSiofraDwellingArrow_ = 12027380,

        [Display(Name = "[LD - Nokron / Siofra] Stonesword Key 12027390")]
        LDNokronSiofraStoneswordKey = 12027390,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027400")]
        LDNokronSiofraGoldenRune4____ = 12027400,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [2] 12027410")]
        LDNokronSiofraSmithingStone2_ = 12027410,

        [Display(Name = "[LD - Nokron / Siofra] Horn Bow 12027420")]
        LDNokronSiofraHornBow = 12027420,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027430")]
        LDNokronSiofraGoldenRune4_____ = 12027430,

        [Display(Name = "[LD - Nokron / Siofra] Sliver of Meat 12027440")]
        LDNokronSiofraSliverOfMeat_ = 12027440,

        [Display(Name = "[LD - Nokron / Siofra] Stonesword Key 12027450")]
        LDNokronSiofraStoneswordKey_ = 12027450,

        [Display(Name = "[LD - Nokron / Siofra] Rune Arc 12027460")]
        LDNokronSiofraRuneArc = 12027460,

        [Display(Name = "[LD - Nokron / Siofra] Clarifying Horn Charm 12027470")]
        LDNokronSiofraClarifyingHornCharm = 12027470,

        [Display(Name = "[LD - Nokron / Siofra] Lump of Flesh 12027480")]
        LDNokronSiofraLumpOfFlesh = 12027480,

        [Display(Name = "[LD - Nokron / Siofra] Clarifying Horn Charm +1 12027490")]
        LDNokronSiofraClarifyingHornCharm1 = 12027490,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027500")]
        LDNokronSiofraGoldenRune4______ = 12027500,

        [Display(Name = "[LD - Nokron / Siofra] Dwelling Arrow 12027510")]
        LDNokronSiofraDwellingArrow__ = 12027510,

        [Display(Name = "[LD - Nokron / Siofra] Nascent Butterfly 12027520")]
        LDNokronSiofraNascentButterfly = 12027520,

        [Display(Name = "[LD - Nokron / Siofra] Gold-Tinged Excrement 12027530")]
        LDNokronSiofraGoldTingedExcrement = 12027530,

        [Display(Name = "[LD - Nokron / Siofra] Fireproof Dried Liver 12027540")]
        LDNokronSiofraFireproofDriedLiver = 12027540,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027550")]
        LDNokronSiofraGoldenRune4_______ = 12027550,

        [Display(Name = "[LD - Nokron / Siofra] Shining Horned Headband 12027560")]
        LDNokronSiofraShiningHornedHeadband = 12027560,

        [Display(Name = "[LD - Nokron / Siofra] Old Fang 12027570")]
        LDNokronSiofraOldFang_ = 12027570,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [5] 12027580")]
        LDNokronSiofraGoldenRune5 = 12027580,

        [Display(Name = "[LD - Nokron / Siofra] Kukri 12027590")]
        LDNokronSiofraKukri = 12027590,

        [Display(Name = "[LD - Nokron / Siofra] Hefty Beast Bone 12027600")]
        LDNokronSiofraHeftyBeastBone_ = 12027600,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12027610")]
        LDNokronSiofraSmithingStone5 = 12027610,

        [Display(Name = "[LD - Nokron / Siofra] Mottled Necklace +1 12027620")]
        LDNokronSiofraMottledNecklace1 = 12027620,

        [Display(Name = "[LD - Nokron / Siofra] Old Fang 12027630")]
        LDNokronSiofraOldFang__ = 12027630,

        [Display(Name = "[LD - Nokron / Siofra] Hefty Beast Bone 12027640")]
        LDNokronSiofraHeftyBeastBone__ = 12027640,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [4] 12027650")]
        LDNokronSiofraSmithingStone4_ = 12027650,

        [Display(Name = "[LD - Nokron / Siofra] Beast Blood 12027660")]
        LDNokronSiofraBeastBlood = 12027660,

        [Display(Name = "[LD - Nokron / Siofra] Beast Blood 12027670")]
        LDNokronSiofraBeastBlood_ = 12027670,

        [Display(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [5] 12027680")]
        LDNokronSiofraSomberSmithingStone5 = 12027680,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [12] 12027690")]
        LDNokronSiofraGoldenRune12 = 12027690,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12027700")]
        LDNokronSiofraGoldenRune1 = 12027700,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12027710")]
        LDNokronSiofraSmithingStone5_ = 12027710,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [2] 12027720")]
        LDNokronSiofraSmithingStone2__ = 12027720,

        [Display(Name = "[LD - Nokron / Siofra] Celestial Dew 12027730")]
        LDNokronSiofraCelestialDew = 12027730,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12027740")]
        LDNokronSiofraSmithingStone5__ = 12027740,

        [Display(Name = "[LD - Nokron / Siofra] Stonesword Key 12027750")]
        LDNokronSiofraStoneswordKey__ = 12027750,

        [Display(Name = "[LD - Nokron / Siofra] Silver Tear Husk 12027760")]
        LDNokronSiofraSilverTearHusk = 12027760,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12027770")]
        LDNokronSiofraGoldenRune1_ = 12027770,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [13] 12027780")]
        LDNokronSiofraGoldenRune13 = 12027780,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12027790")]
        LDNokronSiofraGoldenRune7 = 12027790,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12027800")]
        LDNokronSiofraSmithingStone5___ = 12027800,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [6] 12027810")]
        LDNokronSiofraGoldenRune6_ = 12027810,

        [Display(Name = "[LD - Nokron / Siofra] Rune Arc 12027820")]
        LDNokronSiofraRuneArc_ = 12027820,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [4] 12027830")]
        LDNokronSiofraSmithingStone4__ = 12027830,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12027840")]
        LDNokronSiofraGoldenRune1__ = 12027840,

        [Display(Name = "[LD - Nokron / Siofra] Voidbane Talisman 12027850")]
        LDNokronSiofraVoidbaneTalisman = 12027850,

        [Display(Name = "[LD - Nokron / Siofra] Rune Arc 12027860")]
        LDNokronSiofraRuneArc__ = 12027860,

        [Display(Name = "[LD - Nokron / Siofra] Celestial Dew 12027870")]
        LDNokronSiofraCelestialDew_ = 12027870,

        [Display(Name = "[LD - Nokron / Siofra] Mimic Tear Ashes 12027880")]
        LDNokronSiofraMimicTearAshes = 12027880,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12027890")]
        LDNokronSiofraGoldenRune7_ = 12027890,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [3] 12027900")]
        LDNokronSiofraSmithingStone3__ = 12027900,

        [Display(Name = "[LD - Nokron / Siofra] Nox Flowing Hammer 12027910")]
        LDNokronSiofraNoxFlowingHammer = 12027910,

        [Display(Name = "[LD - Nokron / Siofra] Celestial Dew 12027920")]
        LDNokronSiofraCelestialDew__ = 12027920,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12027930")]
        LDNokronSiofraGoldenRune7__ = 12027930,

        [Display(Name = "[LD - Nokron / Siofra] Soft Cotton 12027940")]
        LDNokronSiofraSoftCotton = 12027940,

        [Display(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [5] 12027950")]
        LDNokronSiofraSomberSmithingStone5_ = 12027950,

        [Display(Name = "[LD - Nokron / Siofra] Dragonwound Grease 12027960")]
        LDNokronSiofraDragonwoundGrease = 12027960,

        [Display(Name = "[LD - Nokron / Siofra] Slumbering Egg 12027970")]
        LDNokronSiofraSlumberingEgg = 12027970,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12027980")]
        LDNokronSiofraGoldenRune7___ = 12027980,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12027990")]
        LDNokronSiofraGoldenRune7____ = 12027990,

        [Display(Name = "[LD - Nokron / Siofra] Crucible Hornshield 12027435")]
        LDNokronSiofraCrucibleHornshield = 12027435,

        [Display(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [6] 12027445")]
        LDNokronSiofraSomberSmithingStone6 = 12027445,

        [Display(Name = "[LD - Deeproot Depths] Map: Deeproot Depths 62064")]
        LDDeeprootDepthsMapDeeprootDepths = 62064,

        [Display(Name = "[LD - Deeproot Depths] Stonesword Key 12037010")]
        LDDeeprootDepthsStoneswordKey = 12037010,

        [Display(Name = "[LD - Deeproot Depths] Formic Rock 12037020")]
        LDDeeprootDepthsFormicRock = 12037020,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [5] 12037030")]
        LDDeeprootDepthsGoldenRune5 = 12037030,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037040")]
        LDDeeprootDepthsGoldenRune8 = 12037040,

        [Display(Name = "[LD - Deeproot Depths] Golden Arrow 12037050")]
        LDDeeprootDepthsGoldenArrow = 12037050,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [6] 12037060")]
        LDDeeprootDepthsSmithingStone6 = 12037060,

        [Display(Name = "[LD - Deeproot Depths] Holy Grease 12037070")]
        LDDeeprootDepthsHolyGrease = 12037070,

        [Display(Name = "[LD - Deeproot Depths] [Incantation] Elden Stars 12037080")]
        LDDeeprootDepthsIncantationEldenStars = 12037080,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [4] 12037090")]
        LDDeeprootDepthsSmithingStone4 = 12037090,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [5] 12037100")]
        LDDeeprootDepthsGoldenRune5_ = 12037100,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [6] 12037110")]
        LDDeeprootDepthsGoldenRune6 = 12037110,

        [Display(Name = "[LD - Deeproot Depths] Warming Stone 12037120")]
        LDDeeprootDepthsWarmingStone = 12037120,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [4] 12037130")]
        LDDeeprootDepthsSmithingStone4_ = 12037130,

        [Display(Name = "[LD - Deeproot Depths] Ash of War: Vacuum Slice 12037140")]
        LDDeeprootDepthsAshOfWarVacuumSlice = 12037140,

        [Display(Name = "[LD - Deeproot Depths] Dragonwound Grease 12037150")]
        LDDeeprootDepthsDragonwoundGrease = 12037150,

        [Display(Name = "[LD - Deeproot Depths] Hefty Beast Bone 12037160")]
        LDDeeprootDepthsHeftyBeastBone = 12037160,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037170")]
        LDDeeprootDepthsGoldenRune1 = 12037170,

        [Display(Name = "[LD - Deeproot Depths] Prince of Death's Staff 12037180")]
        LDDeeprootDepthsPrinceOfDeathsStaff = 12037180,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [6] 12037190")]
        LDDeeprootDepthsSmithingStone6_ = 12037190,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [5] 12037200")]
        LDDeeprootDepthsGoldenRune5__ = 12037200,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037210")]
        LDDeeprootDepthsGoldenRune8_ = 12037210,

        [Display(Name = "[LD - Deeproot Depths] Nascent Butterfly 12037220")]
        LDDeeprootDepthsNascentButterfly = 12037220,

        [Display(Name = "[LD - Deeproot Depths] Somber Smithing Stone [7] 12037230")]
        LDDeeprootDepthsSomberSmithingStone7 = 12037230,

        [Display(Name = "[LD - Deeproot Depths] Somber Smithing Stone [7] 12037240")]
        LDDeeprootDepthsSomberSmithingStone7_ = 12037240,

        [Display(Name = "[LD - Deeproot Depths] Somber Smithing Stone [7] 12037250")]
        LDDeeprootDepthsSomberSmithingStone7__ = 12037250,

        [Display(Name = "[LD - Deeproot Depths] Fan Daggers 12037260")]
        LDDeeprootDepthsFanDaggers = 12037260,

        [Display(Name = "[LD - Deeproot Depths] Somber Smithing Stone [6] 12037270")]
        LDDeeprootDepthsSomberSmithingStone6 = 12037270,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037280")]
        LDDeeprootDepthsGoldenRune8__ = 12037280,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037290")]
        LDDeeprootDepthsGoldenRune8___ = 12037290,

        [Display(Name = "[LD - Deeproot Depths] Crucible Tree Helm 12037300")]
        LDDeeprootDepthsCrucibleTreeHelm = 12037300,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [6] 12037310")]
        LDDeeprootDepthsSmithingStone6__ = 12037310,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037320")]
        LDDeeprootDepthsGoldenRune8____ = 12037320,

        [Display(Name = "[LD - Deeproot Depths] Somber Smithing Stone [7] 12037330")]
        LDDeeprootDepthsSomberSmithingStone7___ = 12037330,

        [Display(Name = "[LD - Deeproot Depths] Arteria Leaf 12037340")]
        LDDeeprootDepthsArteriaLeaf = 12037340,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [7] 12037350")]
        LDDeeprootDepthsSmithingStone7 = 12037350,

        [Display(Name = "[LD - Deeproot Depths] Lightning Greatbolt 12037360")]
        LDDeeprootDepthsLightningGreatbolt = 12037360,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037370")]
        LDDeeprootDepthsGoldenRune8_____ = 12037370,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [6] 12037380")]
        LDDeeprootDepthsSmithingStone6___ = 12037380,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037390")]
        LDDeeprootDepthsGoldenRune8______ = 12037390,

        [Display(Name = "[LD - Deeproot Depths] Clarifying Boluses 12037400")]
        LDDeeprootDepthsClarifyingBoluses = 12037400,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [4] 12037410")]
        LDDeeprootDepthsSmithingStone4__ = 12037410,

        [Display(Name = "[LD - Deeproot Depths] Human Bone Shard 12037420")]
        LDDeeprootDepthsHumanBoneShard = 12037420,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037430")]
        LDDeeprootDepthsGoldenRune8_______ = 12037430,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [9] 12037440")]
        LDDeeprootDepthsGoldenRune9 = 12037440,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [4] 12037450")]
        LDDeeprootDepthsSmithingStone4___ = 12037450,

        [Display(Name = "[LD - Deeproot Depths] Nascent Butterfly 12037460")]
        LDDeeprootDepthsNascentButterfly_ = 12037460,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037470")]
        LDDeeprootDepthsGoldenRune8________ = 12037470,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [5] 12037480")]
        LDDeeprootDepthsSmithingStone5 = 12037480,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [5] 12037490")]
        LDDeeprootDepthsSmithingStone5_ = 12037490,

        [Display(Name = "[LD - Deeproot Depths] Smithing Stone [6] 12037500")]
        LDDeeprootDepthsSmithingStone6____ = 12037500,

        [Display(Name = "[LD - Deeproot Depths] Rune Arc 12037510")]
        LDDeeprootDepthsRuneArc = 12037510,

        [Display(Name = "[LD - Deeproot Depths] Mausoleum Soldier Ashes 12037520")]
        LDDeeprootDepthsMausoleumSoldierAshes = 12037520,

        [Display(Name = "[LD - Deeproot Depths] Somber Smithing Stone [7] 12037530")]
        LDDeeprootDepthsSomberSmithingStone7____ = 12037530,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037540")]
        LDDeeprootDepthsGoldenRune8_________ = 12037540,

        [Display(Name = "[LD - Deeproot Depths] Somber Smithing Stone [6] 12037550")]
        LDDeeprootDepthsSomberSmithingStone6_ = 12037550,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037560")]
        LDDeeprootDepthsGoldenRune1_ = 12037560,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037570")]
        LDDeeprootDepthsGoldenRune1__ = 12037570,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037580")]
        LDDeeprootDepthsGoldenRune1___ = 12037580,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037590")]
        LDDeeprootDepthsGoldenRune1____ = 12037590,

        [Display(Name = "[LD - Deeproot Depths] Lightning Bastard Sword 12037900")]
        LDDeeprootDepthsLightningBastardSword = 12037900,

        [Display(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037910")]
        LDDeeprootDepthsGoldenRune1_____ = 12037910,

        [Display(Name = "[LD - Deeproot Depths] Siluria's Tree 12037950")]
        LDDeeprootDepthsSiluriasTree = 12037950,

        [Display(Name = "[LD - Deeproot Depths] Staff of the Avatar 12037960")]
        LDDeeprootDepthsStaffOfTheAvatar = 12037960,

        [Display(Name = "[LD - Deeproot Depths] Numen's Rune 12037800")]
        LDDeeprootDepthsNumensRune = 12037800,

        [Display(Name = "[LD - Deeproot Depths] Numen's Rune 12037810")]
        LDDeeprootDepthsNumensRune_ = 12037810,

        [Display(Name = "[LD - Deeproot Depths] Numen's Rune 12037820")]
        LDDeeprootDepthsNumensRune__ = 12037820,

        [Display(Name = "[LD - Deeproot Depths] Numen's Rune 12037830")]
        LDDeeprootDepthsNumensRune___ = 12037830,

        [Display(Name = "[LD - Deeproot Depths] Numen's Rune 12037840")]
        LDDeeprootDepthsNumensRune____ = 12037840,

        [Display(Name = "[LD - Deeproot Depths] Numen's Rune 12037850")]
        LDDeeprootDepthsNumensRune_____ = 12037850,

        [Display(Name = "[LD - Mohgwyn] Map: Mohgwyn Palace 62062")]
        LDMohgwynMapMohgwynPalace = 62062,

        [Display(Name = "[LD - Mohgwyn] Golden Seed 12057010")]
        LDMohgwynGoldenSeed = 12057010,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [11] 12057020")]
        LDMohgwynGoldenRune11 = 12057020,

        [Display(Name = "[LD - Mohgwyn] Smithing Stone [6] 12057030")]
        LDMohgwynSmithingStone6 = 12057030,

        [Display(Name = "[LD - Mohgwyn] Bloodrose 12057040")]
        LDMohgwynBloodrose = 12057040,

        [Display(Name = "[LD - Mohgwyn] Nomadic Warrior's Cookbook [24] 67910")]
        LDMohgwynNomadicWarriorsCookbook24 = 67910,

        [Display(Name = "[LD - Mohgwyn] Hero's Rune [4] 12057060")]
        LDMohgwynHerosRune4 = 12057060,

        [Display(Name = "[LD - Mohgwyn] Smithing Stone [8] 12057070")]
        LDMohgwynSmithingStone8 = 12057070,

        [Display(Name = "[LD - Mohgwyn] Hero's Rune [3] 12057080")]
        LDMohgwynHerosRune3 = 12057080,

        [Display(Name = "[LD - Mohgwyn] Blood-Tainted Excrement 12057090")]
        LDMohgwynBloodTaintedExcrement = 12057090,

        [Display(Name = "[LD - Mohgwyn] Somber Smithing Stone [9] 12057100")]
        LDMohgwynSomberSmithingStone9 = 12057100,

        [Display(Name = "[LD - Mohgwyn] [Incantation] Swarm of Flies 12057110")]
        LDMohgwynIncantationSwarmOfFlies = 12057110,

        [Display(Name = "[LD - Mohgwyn] Drawstring Blood Grease 12057120")]
        LDMohgwynDrawstringBloodGrease = 12057120,

        [Display(Name = "[LD - Mohgwyn] Blood-Tainted Excrement 12057130")]
        LDMohgwynBloodTaintedExcrement_ = 12057130,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [12] 12057140")]
        LDMohgwynGoldenRune12 = 12057140,

        [Display(Name = "[LD - Mohgwyn] Smithing Stone [7] 12057150")]
        LDMohgwynSmithingStone7 = 12057150,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [12] 12057160")]
        LDMohgwynGoldenRune12_ = 12057160,

        [Display(Name = "[LD - Mohgwyn] Sacramental Bud 12057170")]
        LDMohgwynSacramentalBud = 12057170,

        [Display(Name = "[LD - Mohgwyn] Nascent Butterfly 12057180")]
        LDMohgwynNascentButterfly = 12057180,

        [Display(Name = "[LD - Mohgwyn] Rune Arc 12057190")]
        LDMohgwynRuneArc = 12057190,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057200")]
        LDMohgwynGoldenRune1 = 12057200,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [13] 12057210")]
        LDMohgwynGoldenRune13 = 12057210,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057220")]
        LDMohgwynGoldenRune1_ = 12057220,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057230")]
        LDMohgwynGoldenRune1__ = 12057230,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057240")]
        LDMohgwynGoldenRune1___ = 12057240,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057250")]
        LDMohgwynGoldenRune1____ = 12057250,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057260")]
        LDMohgwynGoldenRune1_____ = 12057260,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057270")]
        LDMohgwynGoldenRune1______ = 12057270,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057280")]
        LDMohgwynGoldenRune1_______ = 12057280,

        [Display(Name = "[LD - Mohgwyn] Bloodrose 12057290")]
        LDMohgwynBloodrose_ = 12057290,

        [Display(Name = "[LD - Mohgwyn] Holy Grease 12057300")]
        LDMohgwynHolyGrease = 12057300,

        [Display(Name = "[LD - Mohgwyn] Stonesword Key 12057310")]
        LDMohgwynStoneswordKey = 12057310,

        [Display(Name = "[LD - Mohgwyn] Smithing Stone [6] 12057320")]
        LDMohgwynSmithingStone6_ = 12057320,

        [Display(Name = "[LD - Mohgwyn] Arteria Leaf 12057330")]
        LDMohgwynArteriaLeaf = 12057330,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [13] 12057340")]
        LDMohgwynGoldenRune13_ = 12057340,

        [Display(Name = "[LD - Mohgwyn] Clarifying Boluses 12057350")]
        LDMohgwynClarifyingBoluses = 12057350,

        [Display(Name = "[LD - Mohgwyn] Rot Grease 12057360")]
        LDMohgwynRotGrease = 12057360,

        [Display(Name = "[LD - Mohgwyn] Haligdrake Talisman +2 12057370")]
        LDMohgwynHaligdrakeTalisman2 = 12057370,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057380")]
        LDMohgwynGoldenRune1________ = 12057380,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057390")]
        LDMohgwynGoldenRune1_________ = 12057390,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057400")]
        LDMohgwynGoldenRune1__________ = 12057400,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057410")]
        LDMohgwynGoldenRune1___________ = 12057410,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057420")]
        LDMohgwynGoldenRune1____________ = 12057420,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057430")]
        LDMohgwynGoldenRune1_____________ = 12057430,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057440")]
        LDMohgwynGoldenRune1______________ = 12057440,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057450")]
        LDMohgwynGoldenRune1_______________ = 12057450,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057460")]
        LDMohgwynGoldenRune1________________ = 12057460,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057470")]
        LDMohgwynGoldenRune1_________________ = 12057470,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057480")]
        LDMohgwynGoldenRune1__________________ = 12057480,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057490")]
        LDMohgwynGoldenRune1___________________ = 12057490,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057500")]
        LDMohgwynGoldenRune1____________________ = 12057500,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057510")]
        LDMohgwynGoldenRune1_____________________ = 12057510,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057520")]
        LDMohgwynGoldenRune1______________________ = 12057520,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057530")]
        LDMohgwynGoldenRune1_______________________ = 12057530,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057540")]
        LDMohgwynGoldenRune1________________________ = 12057540,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057550")]
        LDMohgwynGoldenRune1_________________________ = 12057550,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057560")]
        LDMohgwynGoldenRune1__________________________ = 12057560,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057570")]
        LDMohgwynGoldenRune1___________________________ = 12057570,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057580")]
        LDMohgwynGoldenRune1____________________________ = 12057580,

        [Display(Name = "[LD - Mohgwyn] Smithing Stone [7] 12057590")]
        LDMohgwynSmithingStone7_ = 12057590,

        [Display(Name = "[LD - Mohgwyn] Stanching Boluses 12057600")]
        LDMohgwynStanchingBoluses = 12057600,

        [Display(Name = "[LD - Mohgwyn] Stonesword Key 12057610")]
        LDMohgwynStoneswordKey_ = 12057610,

        [Display(Name = "[LD - Mohgwyn] Bloodrose 12057620")]
        LDMohgwynBloodrose__ = 12057620,

        [Display(Name = "[LD - Mohgwyn] Fire Longsword 12057630")]
        LDMohgwynFireLongsword = 12057630,

        [Display(Name = "[LD - Mohgwyn] Smithing Stone [8] 12057640")]
        LDMohgwynSmithingStone8_ = 12057640,

        [Display(Name = "[LD - Mohgwyn] Numen's Rune 12057650")]
        LDMohgwynNumensRune = 12057650,

        [Display(Name = "[LD - Mohgwyn] 12057660")]
        LDMohgwyn = 12057660,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [13] 12057670")]
        LDMohgwynGoldenRune13__ = 12057670,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [11] 12057680")]
        LDMohgwynGoldenRune11_ = 12057680,

        [Display(Name = "[LD - Mohgwyn] Lord's Rune 12057690")]
        LDMohgwynLordsRune = 12057690,

        [Display(Name = "[LD - Mohgwyn] Smithing Stone [6] 12057700")]
        LDMohgwynSmithingStone6__ = 12057700,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057710")]
        LDMohgwynGoldenRune1_____________________________ = 12057710,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057720")]
        LDMohgwynGoldenRune1______________________________ = 12057720,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057730")]
        LDMohgwynGoldenRune1_______________________________ = 12057730,

        [Display(Name = "[LD - Mohgwyn] Golden Rune [1] 12057740")]
        LDMohgwynGoldenRune1________________________________ = 12057740,

        [Display(Name = "[LD - Mohgwyn] Somber Ancient Dragon Smithing Stone 12057900")]
        LDMohgwynSomberAncientDragonSmithingStone = 12057900,

        [Display(Name = "[LD - Mohgwyn] White Mask 12057950")]
        LDMohgwynWhiteMask = 12057950,

        [Display(Name = "[LD - Nokron / Siofra] Furlcalling Finger Remedy 12077000")]
        LDNokronSiofraFurlcallingFingerRemedy_ = 12077000,

        [Display(Name = "[LD - Nokron / Siofra] Silver Firefly 12077010")]
        LDNokronSiofraSilverFirefly = 12077010,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [3] 12077020")]
        LDNokronSiofraGoldenRune3___ = 12077020,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [2] 12077030")]
        LDNokronSiofraGoldenRune2_ = 12077030,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [4] 12077040")]
        LDNokronSiofraSmithingStone4___ = 12077040,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [2] 12077050")]
        LDNokronSiofraSmithingStone2___ = 12077050,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [2] 12077060")]
        LDNokronSiofraGoldenRune2__ = 12077060,

        [Display(Name = "[LD - Nokron / Siofra] Immunizing Cured Meat 12077070")]
        LDNokronSiofraImmunizingCuredMeat = 12077070,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [2] 12077080")]
        LDNokronSiofraGoldenRune2___ = 12077080,

        [Display(Name = "[LD - Nokron / Siofra] Rainbow Stone 12077090")]
        LDNokronSiofraRainbowStone = 12077090,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12077100")]
        LDNokronSiofraGoldenRune4________ = 12077100,

        [Display(Name = "[LD - Nokron / Siofra] Budding Horn 12077110")]
        LDNokronSiofraBuddingHorn = 12077110,

        [Display(Name = "[LD - Nokron / Siofra] Throwing Dagger 12077120")]
        LDNokronSiofraThrowingDagger = 12077120,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [3] 12077130")]
        LDNokronSiofraSmithingStone3___ = 12077130,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12077140")]
        LDNokronSiofraGoldenRune4_________ = 12077140,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [4] 12077150")]
        LDNokronSiofraSmithingStone4____ = 12077150,

        [Display(Name = "[LD - Nokron / Siofra] Soap 12077160")]
        LDNokronSiofraSoap = 12077160,

        [Display(Name = "[LD - Nokron / Siofra] Preserving Boluses 12077170")]
        LDNokronSiofraPreservingBoluses = 12077170,

        [Display(Name = "[LD - Nokron / Siofra] Silver-Pickled Fowl Foot 12077180")]
        LDNokronSiofraSilverPickledFowlFoot = 12077180,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077190")]
        LDNokronSiofraGoldenRune1___ = 12077190,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077200")]
        LDNokronSiofraGoldenRune1____ = 12077200,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077210")]
        LDNokronSiofraGoldenRune1_____ = 12077210,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077220")]
        LDNokronSiofraGoldenRune1______ = 12077220,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077230")]
        LDNokronSiofraGoldenRune1_______ = 12077230,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077240")]
        LDNokronSiofraGoldenRune1________ = 12077240,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077250")]
        LDNokronSiofraGoldenRune1_________ = 12077250,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077260")]
        LDNokronSiofraGoldenRune1__________ = 12077260,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077270")]
        LDNokronSiofraGoldenRune1___________ = 12077270,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077280")]
        LDNokronSiofraGoldenRune1____________ = 12077280,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077290")]
        LDNokronSiofraGoldenRune1_____________ = 12077290,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [5] 12077300")]
        LDNokronSiofraGoldenRune5_ = 12077300,

        [Display(Name = "[LD - Nokron / Siofra] Soporific Grease 12077310")]
        LDNokronSiofraSoporificGrease = 12077310,

        [Display(Name = "[LD - Nokron / Siofra] Burred Bolt 12077320")]
        LDNokronSiofraBurredBolt = 12077320,

        [Display(Name = "[LD - Nokron / Siofra] Nascent Butterfly 12077330")]
        LDNokronSiofraNascentButterfly_ = 12077330,

        [Display(Name = "[LD - Nokron / Siofra] Rune Arc 12077340")]
        LDNokronSiofraRuneArc___ = 12077340,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [6] 12077350")]
        LDNokronSiofraGoldenRune6__ = 12077350,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12077360")]
        LDNokronSiofraSmithingStone5____ = 12077360,

        [Display(Name = "[LD - Nokron / Siofra] Furlcalling Finger Remedy 12077370")]
        LDNokronSiofraFurlcallingFingerRemedy__ = 12077370,

        [Display(Name = "[LD - Nokron / Siofra] Clarifying White Cured Meat 12077380")]
        LDNokronSiofraClarifyingWhiteCuredMeat = 12077380,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [6] 12077390")]
        LDNokronSiofraGoldenRune6___ = 12077390,

        [Display(Name = "[LD - Nokron / Siofra] Ghost-Glovewort Picker's Bell Bearing [1] 12077400")]
        LDNokronSiofraGhostGlovewortPickersBellBearing1 = 12077400,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [3] 12077410")]
        LDNokronSiofraSmithingStone3____ = 12077410,

        [Display(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [4] 12077420")]
        LDNokronSiofraSomberSmithingStone4 = 12077420,

        [Display(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12077430")]
        LDNokronSiofraSmithingStone5_____ = 12077430,

        [Display(Name = "[LD - Nokron / Siofra] Greatshield Soldier Ashes 12077440")]
        LDNokronSiofraGreatshieldSoldierAshes = 12077440,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12077450")]
        LDNokronSiofraGoldenRune7_____ = 12077450,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12077460")]
        LDNokronSiofraGoldenRune7______ = 12077460,

        [Display(Name = "[LD - Nokron / Siofra] Rune Arc 12077470")]
        LDNokronSiofraRuneArc____ = 12077470,

        [Display(Name = "[LD - Nokron / Siofra] Larval Tear 12077480")]
        LDNokronSiofraLarvalTear = 12077480,

        [Display(Name = "[LD - Nokron / Siofra] Larval Tear 12077490")]
        LDNokronSiofraLarvalTear_ = 12077490,

        [Display(Name = "[LD - Nokron / Siofra] Ghostflame Torch 12077500")]
        LDNokronSiofraGhostflameTorch = 12077500,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077510")]
        LDNokronSiofraGoldenRune1______________ = 12077510,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077520")]
        LDNokronSiofraGoldenRune1_______________ = 12077520,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077530")]
        LDNokronSiofraGoldenRune1________________ = 12077530,

        [Display(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077540")]
        LDNokronSiofraGoldenRune1_________________ = 12077540,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007000")]
        LDCrumblingFarumAzulaSmithingStone8 = 13007000,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [9] 13007010")]
        LDCrumblingFarumAzulaGoldenRune9 = 13007010,

        [Display(Name = "[LD - Crumbling Farum Azula] Old Fang 13007020")]
        LDCrumblingFarumAzulaOldFang = 13007020,

        [Display(Name = "[LD - Crumbling Farum Azula] Lightningproof Dried Liver 13007030")]
        LDCrumblingFarumAzulaLightningproofDriedLiver = 13007030,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [6] 13007040")]
        LDCrumblingFarumAzulaSmithingStone6 = 13007040,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007050")]
        LDCrumblingFarumAzulaSmithingStone8_ = 13007050,

        [Display(Name = "[LD - Crumbling Farum Azula] Dragonwound Grease 13007060")]
        LDCrumblingFarumAzulaDragonwoundGrease = 13007060,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007070")]
        LDCrumblingFarumAzulaSmithingStone8__ = 13007070,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007080")]
        LDCrumblingFarumAzulaSmithingStone8___ = 13007080,

        [Display(Name = "[LD - Crumbling Farum Azula] Lightning Greatbolt 13007090")]
        LDCrumblingFarumAzulaLightningGreatbolt = 13007090,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007100")]
        LDCrumblingFarumAzula = 13007100,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007110")]
        LDCrumblingFarumAzulaGoldenRune12 = 13007110,

        [Display(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Prayerbook 13007120")]
        LDCrumblingFarumAzulaAncientDragonPrayerbook = 13007120,

        [Display(Name = "[LD - Crumbling Farum Azula] Hero's Rune [2] 13007130")]
        LDCrumblingFarumAzulaHerosRune2 = 13007130,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [6] 13007140")]
        LDCrumblingFarumAzulaSmithingStone6_ = 13007140,

        [Display(Name = "[LD - Crumbling Farum Azula] Somberstone Miner's Bell Bearing [4] 13007150")]
        LDCrumblingFarumAzulaSomberstoneMinersBellBearing4 = 13007150,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007160")]
        LDCrumblingFarumAzula_ = 13007160,

        [Display(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [9] 13007170")]
        LDCrumblingFarumAzulaSomberSmithingStone9 = 13007170,

        [Display(Name = "[LD - Crumbling Farum Azula] Fulgurbloom 13007180")]
        LDCrumblingFarumAzulaFulgurbloom = 13007180,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007190")]
        LDCrumblingFarumAzulaSmithingStone8____ = 13007190,

        [Display(Name = "[LD - Crumbling Farum Azula] Rejuvenating Boluses 13007200")]
        LDCrumblingFarumAzulaRejuvenatingBoluses = 13007200,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007210")]
        LDCrumblingFarumAzula__ = 13007210,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007220")]
        LDCrumblingFarumAzulaSmithingStone8_____ = 13007220,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007230")]
        LDCrumblingFarumAzula___ = 13007230,

        [Display(Name = "[LD - Crumbling Farum Azula] Gravel Stone 13007240")]
        LDCrumblingFarumAzulaGravelStone = 13007240,

        [Display(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [7] 13007250")]
        LDCrumblingFarumAzulaSomberSmithingStone7 = 13007250,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [9] 13007260")]
        LDCrumblingFarumAzulaGoldenRune9_ = 13007260,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Arrow 13007270")]
        LDCrumblingFarumAzulaGoldenArrow = 13007270,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007280")]
        LDCrumblingFarumAzula____ = 13007280,

        [Display(Name = "[LD - Crumbling Farum Azula] Gravel Stone 13007290")]
        LDCrumblingFarumAzulaGravelStone_ = 13007290,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [10] 13007300")]
        LDCrumblingFarumAzulaGoldenRune10 = 13007300,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007310")]
        LDCrumblingFarumAzulaGoldenRune12_ = 13007310,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [6] 13007320")]
        LDCrumblingFarumAzulaSmithingStone6__ = 13007320,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [11] 13007330")]
        LDCrumblingFarumAzulaGoldenRune11 = 13007330,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007340")]
        LDCrumblingFarumAzula_____ = 13007340,

        [Display(Name = "[LD - Crumbling Farum Azula] Stonesword Key 13007350")]
        LDCrumblingFarumAzulaStoneswordKey = 13007350,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007360")]
        LDCrumblingFarumAzulaGoldenRune12__ = 13007360,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007370")]
        LDCrumblingFarumAzula______ = 13007370,

        [Display(Name = "[LD - Crumbling Farum Azula] Rune Arc 13007380")]
        LDCrumblingFarumAzulaRuneArc = 13007380,

        [Display(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [9] 13007390")]
        LDCrumblingFarumAzulaSomberSmithingStone9_ = 13007390,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007400")]
        LDCrumblingFarumAzula_______ = 13007400,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007410")]
        LDCrumblingFarumAzula________ = 13007410,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [11] 13007420")]
        LDCrumblingFarumAzulaGoldenRune11_ = 13007420,

        [Display(Name = "[LD - Crumbling Farum Azula] Godskin Ward 13007430")]
        LDCrumblingFarumAzulaGodskinWard = 13007430,

        [Display(Name = "[LD - Crumbling Farum Azula] Hero's Rune [5] 13007440")]
        LDCrumblingFarumAzulaHerosRune5 = 13007440,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [7] 13007450")]
        LDCrumblingFarumAzulaSmithingStone7 = 13007450,

        [Display(Name = "[LD - Crumbling Farum Azula] Lightning Grease 13007460")]
        LDCrumblingFarumAzulaLightningGrease = 13007460,

        [Display(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [9] 13007470")]
        LDCrumblingFarumAzulaSomberSmithingStone9__ = 13007470,

        [Display(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Smithing Stone 13007480")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone = 13007480,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007490")]
        LDCrumblingFarumAzulaGoldenRune12___ = 13007490,

        [Display(Name = "[LD - Crumbling Farum Azula] Dragoncrest Shield Talisman +2 13007500")]
        LDCrumblingFarumAzulaDragoncrestShieldTalisman2 = 13007500,

        [Display(Name = "[LD - Crumbling Farum Azula] Dappled Cured Meat 13007510")]
        LDCrumblingFarumAzulaDappledCuredMeat = 13007510,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007520")]
        LDCrumblingFarumAzulaSmithingStone8______ = 13007520,

        [Display(Name = "[LD - Crumbling Farum Azula] Lord's Rune 13007530")]
        LDCrumblingFarumAzulaLordsRune = 13007530,

        [Display(Name = "[LD - Crumbling Farum Azula] Nascent Butterfly 13007540")]
        LDCrumblingFarumAzulaNascentButterfly = 13007540,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007550")]
        LDCrumblingFarumAzulaGoldenRune12____ = 13007550,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007560")]
        LDCrumblingFarumAzulaSmithingStone8_______ = 13007560,

        [Display(Name = "[LD - Crumbling Farum Azula] Rune Arc 13007570")]
        LDCrumblingFarumAzulaRuneArc_ = 13007570,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [7] 13007580")]
        LDCrumblingFarumAzulaSmithingStone7_ = 13007580,

        [Display(Name = "[LD - Crumbling Farum Azula] Dragonwound Grease 13007590")]
        LDCrumblingFarumAzulaDragonwoundGrease_ = 13007590,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007600")]
        LDCrumblingFarumAzulaSmithingStone8________ = 13007600,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007610")]
        LDCrumblingFarumAzula_________ = 13007610,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007620")]
        LDCrumblingFarumAzulaGoldenRune12_____ = 13007620,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007630")]
        LDCrumblingFarumAzula__________ = 13007630,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [7] 13007640")]
        LDCrumblingFarumAzulaSmithingStone7__ = 13007640,

        [Display(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Apostle's Cookbook [4] 68020")]
        LDCrumblingFarumAzulaAncientDragonApostlesCookbook4 = 68020,

        [Display(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [8] 13007660")]
        LDCrumblingFarumAzulaSomberSmithingStone8 = 13007660,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [6] 13007670")]
        LDCrumblingFarumAzulaSmithingStone6___ = 13007670,

        [Display(Name = "[LD - Crumbling Farum Azula] Arteria Leaf 13007680")]
        LDCrumblingFarumAzulaArteriaLeaf = 13007680,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007690")]
        LDCrumblingFarumAzula___________ = 13007690,

        [Display(Name = "[LD - Crumbling Farum Azula] Lightning Greatbolt 13007700")]
        LDCrumblingFarumAzulaLightningGreatbolt_ = 13007700,

        [Display(Name = "[LD - Crumbling Farum Azula] Fulgurbloom 13007710")]
        LDCrumblingFarumAzulaFulgurbloom_ = 13007710,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007720")]
        LDCrumblingFarumAzulaGoldenRune12______ = 13007720,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [7] 13007730")]
        LDCrumblingFarumAzulaSmithingStone7___ = 13007730,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007740")]
        LDCrumblingFarumAzulaGoldenRune12_______ = 13007740,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007750")]
        LDCrumblingFarumAzula____________ = 13007750,

        [Display(Name = "[LD - Crumbling Farum Azula] Boltdrake Talisman +2 13007760")]
        LDCrumblingFarumAzulaBoltdrakeTalisman2 = 13007760,

        [Display(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [7] 13007770")]
        LDCrumblingFarumAzulaSomberSmithingStone7_ = 13007770,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007780")]
        LDCrumblingFarumAzula_____________ = 13007780,

        [Display(Name = "[LD - Crumbling Farum Azula] Somberstone Miner's Bell Bearing [5] 13007790")]
        LDCrumblingFarumAzulaSomberstoneMinersBellBearing5 = 13007790,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007800")]
        LDCrumblingFarumAzulaGoldenRune12________ = 13007800,

        [Display(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [7] 13007810")]
        LDCrumblingFarumAzulaSomberSmithingStone7__ = 13007810,

        [Display(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [8] 13007820")]
        LDCrumblingFarumAzulaSomberSmithingStone8_ = 13007820,

        [Display(Name = "[LD - Crumbling Farum Azula] Pearldrake Talisman 13007830")]
        LDCrumblingFarumAzulaPearldrakeTalisman = 13007830,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007840")]
        LDCrumblingFarumAzula______________ = 13007840,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [7] 13007850")]
        LDCrumblingFarumAzulaSmithingStone7____ = 13007850,

        [Display(Name = "[LD - Crumbling Farum Azula] Gravel Stone 13007860")]
        LDCrumblingFarumAzulaGravelStone__ = 13007860,

        [Display(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [9] 13007870")]
        LDCrumblingFarumAzulaSomberSmithingStone9___ = 13007870,

        [Display(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007880")]
        LDCrumblingFarumAzulaSmithingStone8_________ = 13007880,

        [Display(Name = "[LD - Crumbling Farum Azula] Azula Beastman Ashes 13007890")]
        LDCrumblingFarumAzulaAzulaBeastmanAshes = 13007890,

        [Display(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Smithing Stone 13007900")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone_ = 13007900,

        [Display(Name = "[LD - Crumbling Farum Azula] Glovewort Picker's Bell Bearing [3] 13007910")]
        LDCrumblingFarumAzulaGlovewortPickersBellBearing3 = 13007910,

        [Display(Name = "[LD - Crumbling Farum Azula] Drake Knight Helm 13007920")]
        LDCrumblingFarumAzulaDrakeKnightHelm = 13007920,

        [Display(Name = "[LD - Crumbling Farum Azula] 13007930")]
        LDCrumblingFarumAzula_______________ = 13007930,

        [Display(Name = "[LD - Crumbling Farum Azula] Dragon Towershield 13007940")]
        LDCrumblingFarumAzulaDragonTowershield = 13007940,

        [Display(Name = "[LD - Crumbling Farum Azula] Old Lord's Talisman 13007950")]
        LDCrumblingFarumAzulaOldLordsTalisman = 13007950,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Seed 13007980")]
        LDCrumblingFarumAzulaGoldenSeed = 13007980,

        [Display(Name = "[LD - Crumbling Farum Azula] Golden Seed 13007990")]
        LDCrumblingFarumAzulaGoldenSeed_ = 13007990,

        [Display(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Smithing Stone 13007991")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone__ = 13007991,

        [Display(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Smithing Stone 13007993")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone___ = 13007993,

        [Display(Name = "[LD - Crumbling Farum Azula] Malformed Dragon Helm 13007995")]
        LDCrumblingFarumAzulaMalformedDragonHelm = 13007995,

        [Display(Name = "[LD - Crumbling Farum Azula] Somber Ancient Dragon Smithing Stone 13007005")]
        LDCrumblingFarumAzulaSomberAncientDragonSmithingStone = 13007005,

        [Display(Name = "[LD - Crumbling Farum Azula] Dragonwound Grease 13007015")]
        LDCrumblingFarumAzulaDragonwoundGrease__ = 13007015,

        [Display(Name = "[LD - Crumbling Farum Azula] Great Grave Glovewort 13007025")]
        LDCrumblingFarumAzulaGreatGraveGlovewort = 13007025,

        [Display(Name = "[LD - Crumbling Farum Azula] Great Grave Glovewort 13007035")]
        LDCrumblingFarumAzulaGreatGraveGlovewort_ = 13007035,

        [Display(Name = "[LD - Academy of Raya Lucaria] Magic Grease 14007000")]
        LDAcademyOfRayaLucariaMagicGrease = 14007000,

        [Display(Name = "[LD - Academy of Raya Lucaria] Rune Arc 14007020")]
        LDAcademyOfRayaLucariaRuneArc = 14007020,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [2] 14007030")]
        LDAcademyOfRayaLucariaGoldenRune2 = 14007030,

        [Display(Name = "[LD - Academy of Raya Lucaria] Somber Smithing Stone [3] 14007040")]
        LDAcademyOfRayaLucariaSomberSmithingStone3 = 14007040,

        [Display(Name = "[LD - Academy of Raya Lucaria] Grace Mimic 14007070")]
        LDAcademyOfRayaLucariaGraceMimic = 14007070,

        [Display(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [4] 14007090")]
        LDAcademyOfRayaLucariaSmithingStone4 = 14007090,

        [Display(Name = "[LD - Academy of Raya Lucaria] Spellproof Dried Liver 14007120")]
        LDAcademyOfRayaLucariaSpellproofDriedLiver = 14007120,

        [Display(Name = "[LD - Academy of Raya Lucaria] Marionette Soldier Ashes 14007150")]
        LDAcademyOfRayaLucariaMarionetteSoldierAshes = 14007150,

        [Display(Name = "[LD - Academy of Raya Lucaria] Silver-Pickled Fowl Foot 14007160")]
        LDAcademyOfRayaLucariaSilverPickledFowlFoot = 14007160,

        [Display(Name = "[LD - Academy of Raya Lucaria] Magic Grease 14007190")]
        LDAcademyOfRayaLucariaMagicGrease_ = 14007190,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007200")]
        LDAcademyOfRayaLucariaGoldenRune4 = 14007200,

        [Display(Name = "[LD - Academy of Raya Lucaria] Mushroom 14007220")]
        LDAcademyOfRayaLucariaMushroom = 14007220,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007250")]
        LDAcademyOfRayaLucariaGoldenRune4_ = 14007250,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [3] 14007280")]
        LDAcademyOfRayaLucariaGoldenRune3 = 14007280,

        [Display(Name = "[LD - Academy of Raya Lucaria] Avionette Soldier Ashes 14007290")]
        LDAcademyOfRayaLucariaAvionetteSoldierAshes = 14007290,

        [Display(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [5] 14007300")]
        LDAcademyOfRayaLucariaSmithingStone5 = 14007300,

        [Display(Name = "[LD - Academy of Raya Lucaria] Longtail Cat Talisman 14007320")]
        LDAcademyOfRayaLucariaLongtailCatTalisman = 14007320,

        [Display(Name = "[LD - Academy of Raya Lucaria] Crystal Dart 14007330")]
        LDAcademyOfRayaLucariaCrystalDart = 14007330,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007350")]
        LDAcademyOfRayaLucariaGoldenRune4__ = 14007350,

        [Display(Name = "[LD - Academy of Raya Lucaria] Conspectus Scroll 14007360")]
        LDAcademyOfRayaLucariaConspectusScroll = 14007360,

        [Display(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [4] 14007370")]
        LDAcademyOfRayaLucariaSmithingStone4_ = 14007370,

        [Display(Name = "[LD - Academy of Raya Lucaria] Stonesword Key 14007380")]
        LDAcademyOfRayaLucariaStoneswordKey = 14007380,

        [Display(Name = "[LD - Academy of Raya Lucaria] Furlcalling Finger Remedy 14007390")]
        LDAcademyOfRayaLucariaFurlcallingFingerRemedy = 14007390,

        [Display(Name = "[LD - Academy of Raya Lucaria] Living Jar Shard 14007410")]
        LDAcademyOfRayaLucariaLivingJarShard = 14007410,

        [Display(Name = "[LD - Academy of Raya Lucaria] Stonesword Key 14007420")]
        LDAcademyOfRayaLucariaStoneswordKey_ = 14007420,

        [Display(Name = "[LD - Academy of Raya Lucaria] Glintstone Firefly 14007430")]
        LDAcademyOfRayaLucariaGlintstoneFirefly = 14007430,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [2] 14007440")]
        LDAcademyOfRayaLucariaGoldenRune2_ = 14007440,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007450")]
        LDAcademyOfRayaLucariaGoldenRune4___ = 14007450,

        [Display(Name = "[LD - Academy of Raya Lucaria] Crystal Bud 14007460")]
        LDAcademyOfRayaLucariaCrystalBud = 14007460,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007470")]
        LDAcademyOfRayaLucariaGoldenRune4____ = 14007470,

        [Display(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [5] 14007480")]
        LDAcademyOfRayaLucariaSmithingStone5_ = 14007480,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [2] 14007490")]
        LDAcademyOfRayaLucariaGoldenRune2__ = 14007490,

        [Display(Name = "[LD - Academy of Raya Lucaria] Glintstone Whetblade 65680")]
        LDAcademyOfRayaLucariaGlintstoneWhetblade = 65680,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [3] 14007510")]
        LDAcademyOfRayaLucariaGoldenRune3_ = 14007510,

        [Display(Name = "[LD - Academy of Raya Lucaria] Crystal Dart 14007520")]
        LDAcademyOfRayaLucariaCrystalDart_ = 14007520,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007530")]
        LDAcademyOfRayaLucariaGoldenRune4_____ = 14007530,

        [Display(Name = "[LD - Academy of Raya Lucaria] Furlcalling Finger Remedy 14007540")]
        LDAcademyOfRayaLucariaFurlcallingFingerRemedy_ = 14007540,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [7] 14007560")]
        LDAcademyOfRayaLucariaGoldenRune7 = 14007560,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007600")]
        LDAcademyOfRayaLucariaGoldenRune4______ = 14007600,

        [Display(Name = "[LD - Academy of Raya Lucaria] Crystal Dart 14007620")]
        LDAcademyOfRayaLucariaCrystalDart__ = 14007620,

        [Display(Name = "[LD - Academy of Raya Lucaria] Imbued Sword Key 14007630")]
        LDAcademyOfRayaLucariaImbuedSwordKey = 14007630,

        [Display(Name = "[LD - Academy of Raya Lucaria] Meteor Bolt 14007660")]
        LDAcademyOfRayaLucariaMeteorBolt = 14007660,

        [Display(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [4] 14007670")]
        LDAcademyOfRayaLucariaSmithingStone4__ = 14007670,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007710")]
        LDAcademyOfRayaLucariaGoldenRune4_______ = 14007710,

        [Display(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [3] 14007720")]
        LDAcademyOfRayaLucariaSmithingStone3 = 14007720,

        [Display(Name = "[LD - Academy of Raya Lucaria] Magic Grease 14007740")]
        LDAcademyOfRayaLucariaMagicGrease__ = 14007740,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Rune [3] 14007750")]
        LDAcademyOfRayaLucariaGoldenRune3__ = 14007750,

        [Display(Name = "[LD - Academy of Raya Lucaria] Somber Smithing Stone [4] 14007760")]
        LDAcademyOfRayaLucariaSomberSmithingStone4 = 14007760,

        [Display(Name = "[LD - Academy of Raya Lucaria] [Sorcery] Shattering Crystal 14007770")]
        LDAcademyOfRayaLucariaSorceryShatteringCrystal = 14007770,

        [Display(Name = "[LD - Academy of Raya Lucaria] Cracked Pot 66120")]
        LDAcademyOfRayaLucariaCrackedPot = 66120,

        [Display(Name = "[LD - Academy of Raya Lucaria] Azur's Glintstone Staff 14007840")]
        LDAcademyOfRayaLucariaAzursGlintstoneStaff = 14007840,

        [Display(Name = "[LD - Academy of Raya Lucaria] Carian Knight Helm 14007850")]
        LDAcademyOfRayaLucariaCarianKnightHelm = 14007850,

        [Display(Name = "[LD - Academy of Raya Lucaria] Somber Smithing Stone [3] 14007860")]
        LDAcademyOfRayaLucariaSomberSmithingStone3_ = 14007860,

        [Display(Name = "[LD - Academy of Raya Lucaria] Lost Ashes of War 14007870")]
        LDAcademyOfRayaLucariaLostAshesOfWar = 14007870,

        [Display(Name = "[LD - Academy of Raya Lucaria] [Sorcery] Comet 14007880")]
        LDAcademyOfRayaLucariaSorceryComet = 14007880,

        [Display(Name = "[LD - Academy of Raya Lucaria] Graven-School Talisman 14007890")]
        LDAcademyOfRayaLucariaGravenSchoolTalisman = 14007890,

        [Display(Name = "[LD - Academy of Raya Lucaria] Ritual Pot 66410")]
        LDAcademyOfRayaLucariaRitualPot = 66410,

        [Display(Name = "[LD - Academy of Raya Lucaria] Glintstone Scarab 14007910")]
        LDAcademyOfRayaLucariaGlintstoneScarab = 14007910,

        [Display(Name = "[LD - Academy of Raya Lucaria] Terra Magicus 14007920")]
        LDAcademyOfRayaLucariaTerraMagicus = 14007920,

        [Display(Name = "[LD - Academy of Raya Lucaria] Radagon Icon 14007940")]
        LDAcademyOfRayaLucariaRadagonIcon = 14007940,

        [Display(Name = "[LD - Academy of Raya Lucaria] Glintstone Craftsman's Cookbook [5] 67420")]
        LDAcademyOfRayaLucariaGlintstoneCraftsmansCookbook5 = 67420,

        [Display(Name = "[LD - Academy of Raya Lucaria] Dark Moon Ring 114")]
        LDAcademyOfRayaLucariaDarkMoonRing = 114,

        [Display(Name = "[LD - Academy of Raya Lucaria] Full Moon Crossbow 14007970")]
        LDAcademyOfRayaLucariaFullMoonCrossbow = 14007970,

        [Display(Name = "[LD - Academy of Raya Lucaria] Carian Knight's Shield 14007980")]
        LDAcademyOfRayaLucariaCarianKnightsShield = 14007980,

        [Display(Name = "[LD - Academy of Raya Lucaria] Golden Seed 14007990")]
        LDAcademyOfRayaLucariaGoldenSeed = 14007990,

        [Display(Name = "[LD - Academy of Raya Lucaria] Twinsage Glintstone Crown 14007005")]
        LDAcademyOfRayaLucariaTwinsageGlintstoneCrown = 14007005,

        [Display(Name = "[LD - Academy of Raya Lucaria] Olivinus Glintstone Crown 14007015")]
        LDAcademyOfRayaLucariaOlivinusGlintstoneCrown = 14007015,

        [Display(Name = "[LD - Academy of Raya Lucaria] Lazuli Glintstone Crown 14007025")]
        LDAcademyOfRayaLucariaLazuliGlintstoneCrown = 14007025,

        [Display(Name = "[LD - Academy of Raya Lucaria] Karolos Glintstone Crown 14007035")]
        LDAcademyOfRayaLucariaKarolosGlintstoneCrown = 14007035,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Stonesword Key 15007000")]
        LDElphaelMiquellasHaligtreeStoneswordKey = 15007000,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Sacramental Bud 15007010")]
        LDElphaelMiquellasHaligtreeSacramentalBud = 15007010,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007020")]
        LDElphaelMiquellasHaligtreeGoldenRune10 = 15007020,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Stonesword Key 15007030")]
        LDElphaelMiquellasHaligtreeStoneswordKey_ = 15007030,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Fire Grease 15007040")]
        LDElphaelMiquellasHaligtreeFireGrease = 15007040,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Aeonian Butterfly 15007050")]
        LDElphaelMiquellasHaligtreeAeonianButterfly = 15007050,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Preserving Boluses 15007060")]
        LDElphaelMiquellasHaligtreePreservingBoluses = 15007060,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007070")]
        LDElphaelMiquellasHaligtreeGoldenRune10_ = 15007070,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Envoy Crown 15007080")]
        LDElphaelMiquellasHaligtreeEnvoyCrown = 15007080,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Dappled Cured Meat 15007090")]
        LDElphaelMiquellasHaligtreeDappledCuredMeat = 15007090,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007100")]
        LDElphaelMiquellasHaligtreeSmithingStone8 = 15007100,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Prattling Pate \"My beloved\" 15007110")]
        LDElphaelMiquellasHaligtreePrattlingPateMybeloved = 15007110,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Warming Stone 15007120")]
        LDElphaelMiquellasHaligtreeWarmingStone = 15007120,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Flaming Bolt 15007130")]
        LDElphaelMiquellasHaligtreeFlamingBolt = 15007130,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Numen's Rune 15007140")]
        LDElphaelMiquellasHaligtreeNumensRune = 15007140,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [13] 15007150")]
        LDElphaelMiquellasHaligtreeGoldenRune13 = 15007150,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Lost Ashes of War 15007160")]
        LDElphaelMiquellasHaligtreeLostAshesOfWar = 15007160,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Oracle Envoy Ashes 15007170")]
        LDElphaelMiquellasHaligtreeOracleEnvoyAshes = 15007170,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007180")]
        LDElphaelMiquellasHaligtreeGoldenRune1 = 15007180,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007190")]
        LDElphaelMiquellasHaligtreeGoldenRune1_ = 15007190,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007200")]
        LDElphaelMiquellasHaligtreeGoldenRune10__ = 15007200,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Rot Grease 15007210")]
        LDElphaelMiquellasHaligtreeRotGrease = 15007210,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Pearldrake Talisman +2 15007220")]
        LDElphaelMiquellasHaligtreePearldrakeTalisman2 = 15007220,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007230")]
        LDElphaelMiquellasHaligtreeSmithingStone8_ = 15007230,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [13] 15007240")]
        LDElphaelMiquellasHaligtreeGoldenRune13_ = 15007240,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Hefty Beast Bone 15007250")]
        LDElphaelMiquellasHaligtreeHeftyBeastBone = 15007250,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Fire Grease 15007260")]
        LDElphaelMiquellasHaligtreeFireGrease_ = 15007260,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Ancient Dragon Smithing Stone 15007270")]
        LDElphaelMiquellasHaligtreeAncientDragonSmithingStone = 15007270,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Somber Smithing Stone [8] 15007280")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone8 = 15007280,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [12] 15007290")]
        LDElphaelMiquellasHaligtreeGoldenRune12 = 15007290,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Aeonian Butterfly 15007300")]
        LDElphaelMiquellasHaligtreeAeonianButterfly_ = 15007300,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [6] 15007310")]
        LDElphaelMiquellasHaligtreeSmithingStone6 = 15007310,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Somber Smithing Stone [9] 15007320")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9 = 15007320,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007330")]
        LDElphaelMiquellasHaligtreeGoldenRune10___ = 15007330,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [12] 15007340")]
        LDElphaelMiquellasHaligtreeGoldenRune12_ = 15007340,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Viridian Amber Medallion +2 15007350")]
        LDElphaelMiquellasHaligtreeViridianAmberMedallion2 = 15007350,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [6] 15007360")]
        LDElphaelMiquellasHaligtreeSmithingStone6_ = 15007360,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Sacramental Bud 15007370")]
        LDElphaelMiquellasHaligtreeSacramentalBud_ = 15007370,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [7] 15007380")]
        LDElphaelMiquellasHaligtreeSmithingStone7 = 15007380,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Hero's Rune [4] 15007390")]
        LDElphaelMiquellasHaligtreeHerosRune4 = 15007390,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007400")]
        LDElphaelMiquellasHaligtreeSmithingStone8__ = 15007400,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007410")]
        LDElphaelMiquellasHaligtreeGoldenRune1__ = 15007410,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007420")]
        LDElphaelMiquellasHaligtreeGoldenRune1___ = 15007420,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007430")]
        LDElphaelMiquellasHaligtreeGoldenRune1____ = 15007430,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007440")]
        LDElphaelMiquellasHaligtreeGoldenRune1_____ = 15007440,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Somber Smithing Stone [9] 15007450")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9_ = 15007450,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Ancient Dragon Smithing Stone 15007460")]
        LDElphaelMiquellasHaligtreeAncientDragonSmithingStone_ = 15007460,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007470")]
        LDElphaelMiquellasHaligtreeGoldenRune1______ = 15007470,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007480")]
        LDElphaelMiquellasHaligtreeGoldenRune1_______ = 15007480,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007490")]
        LDElphaelMiquellasHaligtreeGoldenRune1________ = 15007490,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Holy Grease 15007500")]
        LDElphaelMiquellasHaligtreeHolyGrease = 15007500,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [12] 15007510")]
        LDElphaelMiquellasHaligtreeGoldenRune12__ = 15007510,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007520")]
        LDElphaelMiquellasHaligtreeSmithingStone8___ = 15007520,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Miquellan Knight's Sword 15007530")]
        LDElphaelMiquellasHaligtreeMiquellanKnightsSword = 15007530,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Lightning Greatbolt 15007540")]
        LDElphaelMiquellasHaligtreeLightningGreatbolt = 15007540,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [7] 15007550")]
        LDElphaelMiquellasHaligtreeSmithingStone7_ = 15007550,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] [Incantation] Triple Rings of Light 15007560")]
        LDElphaelMiquellasHaligtreeIncantationTripleRingsOfLight = 15007560,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Immunizing White Cured Meat 15007570")]
        LDElphaelMiquellasHaligtreeImmunizingWhiteCuredMeat = 15007570,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Cleanrot Knight Finlay 15007580")]
        LDElphaelMiquellasHaligtreeCleanrotKnightFinlay = 15007580,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Somber Ancient Dragon Smithing Stone 15007590")]
        LDElphaelMiquellasHaligtreeSomberAncientDragonSmithingStone = 15007590,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Numen's Rune 15007600")]
        LDElphaelMiquellasHaligtreeNumensRune_ = 15007600,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Somber Ancient Dragon Smithing Stone 15007610")]
        LDElphaelMiquellasHaligtreeSomberAncientDragonSmithingStone_ = 15007610,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Somber Smithing Stone [9] 15007620")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9__ = 15007620,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007630")]
        LDElphaelMiquellasHaligtreeGoldenRune10____ = 15007630,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [7] 15007640")]
        LDElphaelMiquellasHaligtreeSmithingStone7__ = 15007640,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Old Fang 15007650")]
        LDElphaelMiquellasHaligtreeOldFang = 15007650,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Warming Stone 15007660")]
        LDElphaelMiquellasHaligtreeWarmingStone_ = 15007660,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Spiritflame Arrow 15007670")]
        LDElphaelMiquellasHaligtreeSpiritflameArrow = 15007670,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007680")]
        LDElphaelMiquellasHaligtreeSmithingStone8____ = 15007680,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Haligtree Soldier Ashes 15007690")]
        LDElphaelMiquellasHaligtreeHaligtreeSoldierAshes = 15007690,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [11] 15007700")]
        LDElphaelMiquellasHaligtreeGoldenRune11 = 15007700,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Arteria Leaf 15007710")]
        LDElphaelMiquellasHaligtreeArteriaLeaf = 15007710,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Sacramental Bud 15007720")]
        LDElphaelMiquellasHaligtreeSacramentalBud__ = 15007720,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007730")]
        LDElphaelMiquellasHaligtreeSmithingStone8_____ = 15007730,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Lord's Rune 15007740")]
        LDElphaelMiquellasHaligtreeLordsRune = 15007740,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Seedbed Curse 15007750")]
        LDElphaelMiquellasHaligtreeSeedbedCurse = 15007750,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Somber Smithing Stone [9] 15007760")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9___ = 15007760,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Pickled Turtle Neck 15007770")]
        LDElphaelMiquellasHaligtreePickledTurtleNeck = 15007770,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Beast Blood 15007780")]
        LDElphaelMiquellasHaligtreeBeastBlood = 15007780,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Aeonian Butterfly 15007790")]
        LDElphaelMiquellasHaligtreeAeonianButterfly__ = 15007790,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Marika's Soreseal 15007800")]
        LDElphaelMiquellasHaligtreeMarikasSoreseal = 15007800,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [12] 15007810")]
        LDElphaelMiquellasHaligtreeGoldenRune12___ = 15007810,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Haligtree Knight Helm 15007820")]
        LDElphaelMiquellasHaligtreeHaligtreeKnightHelm = 15007820,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [6] 15007830")]
        LDElphaelMiquellasHaligtreeSmithingStone6__ = 15007830,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Seedbed Curse 15007840")]
        LDElphaelMiquellasHaligtreeSeedbedCurse_ = 15007840,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007850")]
        LDElphaelMiquellasHaligtreeGoldenRune1_________ = 15007850,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Rotten Crystal Sword 15007860")]
        LDElphaelMiquellasHaligtreeRottenCrystalSword = 15007860,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Hero's Rune [5] 15007870")]
        LDElphaelMiquellasHaligtreeHerosRune5 = 15007870,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Rot Grease 15007880")]
        LDElphaelMiquellasHaligtreeRotGrease_ = 15007880,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Great Grave Glovewort 15007890")]
        LDElphaelMiquellasHaligtreeGreatGraveGlovewort = 15007890,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007900")]
        LDElphaelMiquellasHaligtreeGoldenRune10_____ = 15007900,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Ghost-Glovewort Picker's Bell Bearing [3] 15007910")]
        LDElphaelMiquellasHaligtreeGhostGlovewortPickersBellBearing3 = 15007910,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Nascent Butterfly 15007920")]
        LDElphaelMiquellasHaligtreeNascentButterfly = 15007920,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Dragoncrest Greatshield Talisman 15007930")]
        LDElphaelMiquellasHaligtreeDragoncrestGreatshieldTalisman = 15007930,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Aeonian Butterfly 15007940")]
        LDElphaelMiquellasHaligtreeAeonianButterfly___ = 15007940,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Arteria Leaf 15007950")]
        LDElphaelMiquellasHaligtreeArteriaLeaf_ = 15007950,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Hero's Rune [5] 15007960")]
        LDElphaelMiquellasHaligtreeHerosRune5_ = 15007960,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Numen's Rune 15007970")]
        LDElphaelMiquellasHaligtreeNumensRune__ = 15007970,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Traveler's Clothes 15007980")]
        LDElphaelMiquellasHaligtreeTravelersClothes = 15007980,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Miquella's Needle 15007990")]
        LDElphaelMiquellasHaligtreeMiquellasNeedle = 15007990,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Golden Seed 15001200")]
        LDElphaelMiquellasHaligtreeGoldenSeed = 15001200,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] 15001210")]
        LDElphaelMiquellasHaligtree = 15001210,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] 15001250")]
        LDElphaelMiquellasHaligtree_ = 15001250,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] 15001260")]
        LDElphaelMiquellasHaligtree__ = 15001260,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Lord's Rune 15001270")]
        LDElphaelMiquellasHaligtreeLordsRune_ = 15001270,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] Rotten Staff 15001280")]
        LDElphaelMiquellasHaligtreeRottenStaff = 15001280,

        [Display(Name = "[LD - Elphael / Miquella's Haligtree] 15001290")]
        LDElphaelMiquellasHaligtree___ = 15001290,

        [Display(Name = "[LD - Volcano Manor] Smithing Stone [6] 16007000")]
        LDVolcanoManorSmithingStone6 = 16007000,

        [Display(Name = "[LD - Volcano Manor] Depraved Perfumer Carmaan 16007010")]
        LDVolcanoManorDepravedPerfumerCarmaan = 16007010,

        [Display(Name = "[LD - Volcano Manor] Ash of War: Royal Knight's Resolve 16007020")]
        LDVolcanoManorAshOfWarRoyalKnightsResolve = 16007020,

        [Display(Name = "[LD - Volcano Manor] Budding Horn 16007030")]
        LDVolcanoManorBuddingHorn = 16007030,

        [Display(Name = "[LD - Volcano Manor] Fireproof Dried Liver 16007040")]
        LDVolcanoManorFireproofDriedLiver = 16007040,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [9] 16007050")]
        LDVolcanoManorGoldenRune9 = 16007050,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [5] 16007060")]
        LDVolcanoManorGoldenRune5 = 16007060,

        [Display(Name = "[LD - Volcano Manor] Stonesword Key 16007070")]
        LDVolcanoManorStoneswordKey = 16007070,

        [Display(Name = "[LD - Volcano Manor] Furlcalling Finger Remedy 16007080")]
        LDVolcanoManorFurlcallingFingerRemedy = 16007080,

        [Display(Name = "[LD - Volcano Manor] Nomadic Warrior's Cookbook [21] 67120")]
        LDVolcanoManorNomadicWarriorsCookbook21 = 67120,

        [Display(Name = "[LD - Volcano Manor] Somber Smithing Stone [7] 16007100")]
        LDVolcanoManorSomberSmithingStone7 = 16007100,

        [Display(Name = "[LD - Volcano Manor] Perfume Bottle 66700")]
        LDVolcanoManorPerfumeBottle = 66700,

        [Display(Name = "[LD - Volcano Manor] Smithing Stone [6] 16007120")]
        LDVolcanoManorSmithingStone6_ = 16007120,

        [Display(Name = "[LD - Volcano Manor] Erdtree Seal 16007130")]
        LDVolcanoManorErdtreeSeal = 16007130,

        [Display(Name = "[LD - Volcano Manor] Drawstring Fire Grease 16007140")]
        LDVolcanoManorDrawstringFireGrease = 16007140,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [6] 16007150")]
        LDVolcanoManorGoldenRune6 = 16007150,

        [Display(Name = "[LD - Volcano Manor] Fire Arrow 16007160")]
        LDVolcanoManorFireArrow = 16007160,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [9] 16007170")]
        LDVolcanoManorGoldenRune9_ = 16007170,

        [Display(Name = "[LD - Volcano Manor] Explosive Greatbolt 16007190")]
        LDVolcanoManorExplosiveGreatbolt = 16007190,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [9] 16007200")]
        LDVolcanoManorGoldenRune9__ = 16007200,

        [Display(Name = "[LD - Volcano Manor] Somber Smithing Stone [6] 16007210")]
        LDVolcanoManorSomberSmithingStone6 = 16007210,

        [Display(Name = "[LD - Volcano Manor] Fireproof Dried Liver 16007220")]
        LDVolcanoManorFireproofDriedLiver_ = 16007220,

        [Display(Name = "[LD - Volcano Manor] Albinauric Bloodclot 16007230")]
        LDVolcanoManorAlbinauricBloodclot = 16007230,

        [Display(Name = "[LD - Volcano Manor] Smithing Stone [4] 16007240")]
        LDVolcanoManorSmithingStone4 = 16007240,

        [Display(Name = "[LD - Volcano Manor] Smithing Stone [6] 16007250")]
        LDVolcanoManorSmithingStone6__ = 16007250,

        [Display(Name = "[LD - Volcano Manor] Smoldering Butterfly 16007270")]
        LDVolcanoManorSmolderingButterfly = 16007270,

        [Display(Name = "[LD - Volcano Manor] Smithing Stone [7] 16007280")]
        LDVolcanoManorSmithingStone7 = 16007280,

        [Display(Name = "[LD - Volcano Manor] Somber Smithing Stone [5] 16007290")]
        LDVolcanoManorSomberSmithingStone5 = 16007290,

        [Display(Name = "[LD - Volcano Manor] Smoldering Butterfly 16007310")]
        LDVolcanoManorSmolderingButterfly_ = 16007310,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [9] 16007320")]
        LDVolcanoManorGoldenRune9___ = 16007320,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [10] 16007330")]
        LDVolcanoManorGoldenRune10 = 16007330,

        [Display(Name = "[LD - Volcano Manor] Smithing Stone [6] 16007350")]
        LDVolcanoManorSmithingStone6___ = 16007350,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [9] 16007360")]
        LDVolcanoManorGoldenRune9____ = 16007360,

        [Display(Name = "[LD - Volcano Manor] Smithing Stone [5] 16007380")]
        LDVolcanoManorSmithingStone5 = 16007380,

        [Display(Name = "[LD - Volcano Manor] Smoldering Butterfly 16007390")]
        LDVolcanoManorSmolderingButterfly__ = 16007390,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [12] 16007400")]
        LDVolcanoManorGoldenRune12 = 16007400,

        [Display(Name = "[LD - Volcano Manor] Furlcalling Finger Remedy 16007410")]
        LDVolcanoManorFurlcallingFingerRemedy_ = 16007410,

        [Display(Name = "[LD - Volcano Manor] Beast Blood 16007420")]
        LDVolcanoManorBeastBlood = 16007420,

        [Display(Name = "[LD - Volcano Manor] Albinauric Staff 16007430")]
        LDVolcanoManorAlbinauricStaff = 16007430,

        [Display(Name = "[LD - Volcano Manor] Drawstring Fire Grease 16007440")]
        LDVolcanoManorDrawstringFireGrease_ = 16007440,

        [Display(Name = "[LD - Volcano Manor] Missionary's Cookbook [6] 67130")]
        LDVolcanoManorMissionarysCookbook6 = 67130,

        [Display(Name = "[LD - Volcano Manor] Crimson Tear Scarab 16007480")]
        LDVolcanoManorCrimsonTearScarab = 16007480,

        [Display(Name = "[LD - Volcano Manor] Stonesword Key 16007490")]
        LDVolcanoManorStoneswordKey_ = 16007490,

        [Display(Name = "[LD - Volcano Manor] Rune Arc 16007500")]
        LDVolcanoManorRuneArc = 16007500,

        [Display(Name = "[LD - Volcano Manor] Commoner's Headband 16007510")]
        LDVolcanoManorCommonersHeadband = 16007510,

        [Display(Name = "[LD - Volcano Manor] Man-Serpent Ashes 16007520")]
        LDVolcanoManorManSerpentAshes = 16007520,

        [Display(Name = "[LD - Volcano Manor] Somber Smithing Stone [6] 16007530")]
        LDVolcanoManorSomberSmithingStone6_ = 16007530,

        [Display(Name = "[LD - Volcano Manor] Crimson Amber Medallion +1 16007540")]
        LDVolcanoManorCrimsonAmberMedallion1 = 16007540,

        [Display(Name = "[LD - Volcano Manor] Smithing Stone [6] 16007550")]
        LDVolcanoManorSmithingStone6____ = 16007550,

        [Display(Name = "[LD - Volcano Manor] Smithing Stone [4] 16007560")]
        LDVolcanoManorSmithingStone4_ = 16007560,

        [Display(Name = "[LD - Volcano Manor] Smoldering Shield 16007610")]
        LDVolcanoManorSmolderingShield = 16007610,

        [Display(Name = "[LD - Volcano Manor] Dagger Talisman 16007620")]
        LDVolcanoManorDaggerTalisman = 16007620,

        [Display(Name = "[LD - Volcano Manor] Serpent-Hunter 16007690")]
        LDVolcanoManorSerpentHunter = 16007690,

        [Display(Name = "[LD - Volcano Manor] Seedbed Curse 16007700")]
        LDVolcanoManorSeedbedCurse = 16007700,

        [Display(Name = "[LD - Volcano Manor] Serpent's Amnion 16007710")]
        LDVolcanoManorSerpentsAmnion = 16007710,

        [Display(Name = "[LD - Volcano Manor] Recusant Finger 60260")]
        LDVolcanoManorRecusantFinger = 60260,

        [Display(Name = "[LD - Volcano Manor] Eye Surcoat 16007730")]
        LDVolcanoManorEyeSurcoat = 16007730,

        [Display(Name = "[LD - Volcano Manor] Ghiza's Wheel 16007940")]
        LDVolcanoManorGhizasWheel = 16007940,

        [Display(Name = "[LD - Volcano Manor] [Incantation] Aspects of the Crucible: Breath 16007950")]
        LDVolcanoManorIncantationAspectsOfTheCrucibleBreath = 16007950,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [1] 16007991")]
        LDVolcanoManorGoldenRune1 = 16007991,

        [Display(Name = "[LD - Volcano Manor] Golden Rune [1] 16007992")]
        LDVolcanoManorGoldenRune1_ = 16007992,

        [Display(Name = "[LD - Volcano Manor] Dragon Heart 16007999")]
        LDVolcanoManorDragonHeart = 16007999,

        [Display(Name = "[LD - Stranded Graveyard] Poisonbone Dart 18007000")]
        LDStrandedGraveyardPoisonboneDart = 18007000,

        [Display(Name = "[LD - Stranded Graveyard] Stonesword Key 18007010")]
        LDStrandedGraveyardStoneswordKey = 18007010,

        [Display(Name = "[LD - Stranded Graveyard] Golden Rune [5] 18007020")]
        LDStrandedGraveyardGoldenRune5 = 18007020,

        [Display(Name = "[LD - Stranded Graveyard] Dragonwound Grease 18007030")]
        LDStrandedGraveyardDragonwoundGrease = 18007030,

        [Display(Name = "[LD - Stranded Graveyard] Lightning Grease 18007040")]
        LDStrandedGraveyardLightningGrease = 18007040,

        [Display(Name = "[LD - Stranded Graveyard] Erdtree's Favor 18007050")]
        LDStrandedGraveyardErdtreesFavor = 18007050,

        [Display(Name = "[LD - Stranded Graveyard] Grave Glovewort [1] 18007060")]
        LDStrandedGraveyardGraveGlovewort1 = 18007060,

        [Display(Name = "[LD - Stranded Graveyard] Haligdrake Talisman 18007070")]
        LDStrandedGraveyardHaligdrakeTalisman = 18007070,

        [Display(Name = "[LD - Stranded Graveyard] Tarnished's Furled Finger 60220")]
        LDStrandedGraveyardTarnishedsFurledFinger = 60220,

        [Display(Name = "[LD - Stranded Graveyard] Finger Severer 60310")]
        LDStrandedGraveyardFingerSeverer = 60310,

        [Display(Name = "[LD - Stranded Graveyard] Erdtree Greatbow 18007900")]
        LDStrandedGraveyardErdtreeGreatbow = 18007900,

        [Display(Name = "[Weeping Peninsula - Tombsward Catacombs] Human Bone Shard 30007010")]
        WeepingPeninsulaTombswardCatacombsHumanBoneShard = 30007010,

        [Display(Name = "[Weeping Peninsula - Tombsward Catacombs] Golden Rune [2] 30007020")]
        WeepingPeninsulaTombswardCatacombsGoldenRune2 = 30007020,

        [Display(Name = "[Weeping Peninsula - Tombsward Catacombs] Nomadic Warrior's Cookbook [9] 67430")]
        WeepingPeninsulaTombswardCatacombsNomadicWarriorsCookbook9 = 67430,

        [Display(Name = "[Weeping Peninsula - Tombsward Catacombs] Prattling Pate \"Thank you\" 30007040")]
        WeepingPeninsulaTombswardCatacombsPrattlingPateThankyou = 30007040,

        [Display(Name = "[Weeping Peninsula - Impaler's Catacombs] Root Resin 30017010")]
        WeepingPeninsulaImpalersCatacombsRootResin = 30017010,

        [Display(Name = "[Weeping Peninsula - Impaler's Catacombs] Prattling Pate \"Please help\" 30017020")]
        WeepingPeninsulaImpalersCatacombsPrattlingPatePleasehelp = 30017020,

        [Display(Name = "[Limgrave - Stormfoot Catacombs] Root Resin 30027000")]
        LimgraveStormfootCatacombsRootResin = 30027000,

        [Display(Name = "[Limgrave - Stormfoot Catacombs] Smoldering Butterfly 30027010")]
        LimgraveStormfootCatacombsSmolderingButterfly = 30027010,

        [Display(Name = "[Limgrave - Stormfoot Catacombs] Wandering Noble Ashes 30027020")]
        LimgraveStormfootCatacombsWanderingNobleAshes = 30027020,

        [Display(Name = "[Limgrave - Stormfoot Catacombs] Prattling Pate \"Hello\" 30027030")]
        LimgraveStormfootCatacombsPrattlingPateHello = 30027030,

        [Display(Name = "[Liurnia - Road's End Catacombs] Root Resin 30037000")]
        LiurniaRoadsEndCatacombsRootResin = 30037000,

        [Display(Name = "[Liurnia - Road's End Catacombs] Raya Lucaria Soldier Ashes 30037010")]
        LiurniaRoadsEndCatacombsRayaLucariaSoldierAshes = 30037010,

        [Display(Name = "[Liurnia - Road's End Catacombs] Human Bone Shard 30037020")]
        LiurniaRoadsEndCatacombsHumanBoneShard = 30037020,

        [Display(Name = "[Liurnia - Road's End Catacombs] Rune Arc 30037030")]
        LiurniaRoadsEndCatacombsRuneArc = 30037030,

        [Display(Name = "[Liurnia - Road's End Catacombs] Watchdog's Staff 30037040")]
        LiurniaRoadsEndCatacombsWatchdogsStaff = 30037040,

        [Display(Name = "[Limgrave - Murkwater Catacombs] Root Resin 30047000")]
        LimgraveMurkwaterCatacombsRootResin = 30047000,

        [Display(Name = "[Liurnia - Black Knife Catacombs] Rosus' Axe 30057000")]
        LiurniaBlackKnifeCatacombsRosusAxe = 30057000,

        [Display(Name = "[Liurnia - Black Knife Catacombs] Rune Arc 30057010")]
        LiurniaBlackKnifeCatacombsRuneArc = 30057010,

        [Display(Name = "[Liurnia - Black Knife Catacombs] Deathroot 30057030")]
        LiurniaBlackKnifeCatacombsDeathroot = 30057030,

        [Display(Name = "[Liurnia - Black Knife Catacombs] Spellproof Dried Liver 30057040")]
        LiurniaBlackKnifeCatacombsSpellproofDriedLiver = 30057040,

        [Display(Name = "[Liurnia - Cliffbottom Catacombs] Root Resin 30067000")]
        LiurniaCliffbottomCatacombsRootResin = 30067000,

        [Display(Name = "[Liurnia - Cliffbottom Catacombs] Nox Mirrorhelm 30067010")]
        LiurniaCliffbottomCatacombsNoxMirrorhelm = 30067010,

        [Display(Name = "[Liurnia - Cliffbottom Catacombs] Golden Rune [3] 30067020")]
        LiurniaCliffbottomCatacombsGoldenRune3 = 30067020,

        [Display(Name = "[Liurnia - Cliffbottom Catacombs] Page Ashes 30067030")]
        LiurniaCliffbottomCatacombsPageAshes = 30067030,

        [Display(Name = "[Liurnia - Cliffbottom Catacombs] Rune Arc 30067040")]
        LiurniaCliffbottomCatacombsRuneArc = 30067040,

        [Display(Name = "[Liurnia - Cliffbottom Catacombs] Old Fang 30067050")]
        LiurniaCliffbottomCatacombsOldFang = 30067050,

        [Display(Name = "[Liurnia - Cliffbottom Catacombs] Hefty Beast Bone 30067060")]
        LiurniaCliffbottomCatacombsHeftyBeastBone = 30067060,

        [Display(Name = "[Liurnia - Cliffbottom Catacombs] Scythe 30067070")]
        LiurniaCliffbottomCatacombsScythe = 30067070,

        [Display(Name = "[Liurnia - Cliffbottom Catacombs] Prattling Pate \"Wonderful\" 30067080")]
        LiurniaCliffbottomCatacombsPrattlingPateWonderful = 30067080,

        [Display(Name = "[Mt. Gelmir - Wyndham Catacombs] Ancient Dragon Apostle's Cookbook [1] 68000")]
        MtGelmirWyndhamCatacombsAncientDragonApostlesCookbook1 = 68000,

        [Display(Name = "[Mt. Gelmir - Wyndham Catacombs] Golden Rune [5] 30077010")]
        MtGelmirWyndhamCatacombsGoldenRune5 = 30077010,

        [Display(Name = "[Mt. Gelmir - Wyndham Catacombs] Magic Grease 30077020")]
        MtGelmirWyndhamCatacombsMagicGrease = 30077020,

        [Display(Name = "[Mt. Gelmir - Wyndham Catacombs] Lightning Scorpion Charm 30077600")]
        MtGelmirWyndhamCatacombsLightningScorpionCharm = 30077600,

        [Display(Name = "[Mt. Gelmir - Wyndham Catacombs] Golden Rune [1] 30077900")]
        MtGelmirWyndhamCatacombsGoldenRune1 = 30077900,

        [Display(Name = "[Altus Plateau - Sainted Hero's Grave] Crimson Seed Talisman 30087010")]
        AltusPlateauSaintedHerosGraveCrimsonSeedTalisman = 30087010,

        [Display(Name = "[Altus Plateau - Sainted Hero's Grave] Leyndell Soldier Ashes 30087020")]
        AltusPlateauSaintedHerosGraveLeyndellSoldierAshes = 30087020,

        [Display(Name = "[Altus Plateau - Sainted Hero's Grave] Dragoncrest Shield Talisman +1 30087030")]
        AltusPlateauSaintedHerosGraveDragoncrestShieldTalisman1 = 30087030,

        [Display(Name = "[Altus Plateau - Sainted Hero's Grave] Root Resin 30087040")]
        AltusPlateauSaintedHerosGraveRootResin = 30087040,

        [Display(Name = "[Altus Plateau - Sainted Hero's Grave] Prattling Pate \"Let's get to it\" 30087050")]
        AltusPlateauSaintedHerosGravePrattlingPateLetsgettoit = 30087050,

        [Display(Name = "[Altus Plateau - Sainted Hero's Grave] Human Bone Shard 30087060")]
        AltusPlateauSaintedHerosGraveHumanBoneShard = 30087060,

        [Display(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Deathroot 30097000")]
        MtGelmirGelmirHerosGraveDeathroot = 30097000,

        [Display(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Ringed Finger 30097010")]
        MtGelmirGelmirHerosGraveRingedFinger = 30097010,

        [Display(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Golden Rune [6] 30097020")]
        MtGelmirGelmirHerosGraveGoldenRune6 = 30097020,

        [Display(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Smoldering Butterfly 30097030")]
        MtGelmirGelmirHerosGraveSmolderingButterfly = 30097030,

        [Display(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Stonesword Key 30097040")]
        MtGelmirGelmirHerosGraveStoneswordKey = 30097040,

        [Display(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Gelmir Knight Helm 30097050")]
        MtGelmirGelmirHerosGraveGelmirKnightHelm = 30097050,

        [Display(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Root Resin 30097060")]
        MtGelmirGelmirHerosGraveRootResin = 30097060,

        [Display(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Beast Blood 30097070")]
        MtGelmirGelmirHerosGraveBeastBlood = 30097070,

        [Display(Name = "[Capital Outskirts - Auriza Hero's Grave] Holy Grease 30107010")]
        CapitalOutskirtsAurizaHerosGraveHolyGrease = 30107010,

        [Display(Name = "[Capital Outskirts - Auriza Hero's Grave] Fan Daggers 30107020")]
        CapitalOutskirtsAurizaHerosGraveFanDaggers = 30107020,

        [Display(Name = "[Capital Outskirts - Auriza Hero's Grave] Golden Rune [7] 30107030")]
        CapitalOutskirtsAurizaHerosGraveGoldenRune7 = 30107030,

        [Display(Name = "[Capital Outskirts - Auriza Hero's Grave] Crucible Feather Talisman 30107040")]
        CapitalOutskirtsAurizaHerosGraveCrucibleFeatherTalisman = 30107040,

        [Display(Name = "[Capital Outskirts - Auriza Hero's Grave] Golden Epitaph 30107050")]
        CapitalOutskirtsAurizaHerosGraveGoldenEpitaph = 30107050,

        [Display(Name = "[Capital Outskirts - Auriza Hero's Grave] Great Dragonfly Head 30107060")]
        CapitalOutskirtsAurizaHerosGraveGreatDragonflyHead = 30107060,

        [Display(Name = "[Capital Outskirts - Auriza Hero's Grave] Stonesword Key 30107070")]
        CapitalOutskirtsAurizaHerosGraveStoneswordKey = 30107070,

        [Display(Name = "[Capital Outskirts - Auriza Hero's Grave] Vulgar Militia Ashes 30107080")]
        CapitalOutskirtsAurizaHerosGraveVulgarMilitiaAshes = 30107080,

        [Display(Name = "[Capital Outskirts - Auriza Hero's Grave] Ash of War: Holy Ground 30107100")]
        CapitalOutskirtsAurizaHerosGraveAshOfWarHolyGround = 30107100,

        [Display(Name = "[Stormhill - Deathtouched Catacombs] Deathroot 30117000")]
        StormhillDeathtouchedCatacombsDeathroot = 30117000,

        [Display(Name = "[Stormhill - Deathtouched Catacombs] Bloodrose 30117010")]
        StormhillDeathtouchedCatacombsBloodrose = 30117010,

        [Display(Name = "[Stormhill - Deathtouched Catacombs] Uchigatana 30117020")]
        StormhillDeathtouchedCatacombsUchigatana = 30117020,

        [Display(Name = "[Altus Plateau - Unsightly Catacombs] Holy Grease 30127000")]
        AltusPlateauUnsightlyCatacombsHolyGrease = 30127000,

        [Display(Name = "[Altus Plateau - Unsightly Catacombs] Winged Misbegotten Ashes 30127010")]
        AltusPlateauUnsightlyCatacombsWingedMisbegottenAshes = 30127010,

        [Display(Name = "[Altus Plateau - Unsightly Catacombs] Rune Arc 30127020")]
        AltusPlateauUnsightlyCatacombsRuneArc = 30127020,

        [Display(Name = "[Altus Plateau - Unsightly Catacombs] Prattling Pate \"Apologies\" 30127030")]
        AltusPlateauUnsightlyCatacombsPrattlingPateApologies = 30127030,

        [Display(Name = "[Altus Plateau - Unsightly Catacombs] Golden Rune [1] 30127900")]
        AltusPlateauUnsightlyCatacombsGoldenRune1 = 30127900,

        [Display(Name = "[Capital Outskirts - Auriza Side Tomb] Perfumer's Cookbook [3] 67860")]
        CapitalOutskirtsAurizaSideTombPerfumersCookbook3 = 67860,

        [Display(Name = "[Capital Outskirts - Auriza Side Tomb] Golden Rune [7] 30137020")]
        CapitalOutskirtsAurizaSideTombGoldenRune7 = 30137020,

        [Display(Name = "[Capital Outskirts - Auriza Side Tomb] Smithing Stone [5] 30137030")]
        CapitalOutskirtsAurizaSideTombSmithingStone5 = 30137030,

        [Display(Name = "[Capital Outskirts - Auriza Side Tomb] Root Resin 30137040")]
        CapitalOutskirtsAurizaSideTombRootResin = 30137040,

        [Display(Name = "[Capital Outskirts - Auriza Side Tomb] Cracked Pot 66140")]
        CapitalOutskirtsAurizaSideTombCrackedPot = 66140,

        [Display(Name = "[Capital Outskirts - Auriza Side Tomb] Cracked Pot 66150")]
        CapitalOutskirtsAurizaSideTombCrackedPot_ = 66150,

        [Display(Name = "[Capital Outskirts - Auriza Side Tomb] Cracked Pot 66160")]
        CapitalOutskirtsAurizaSideTombCrackedPot__ = 66160,

        [Display(Name = "[Capital Outskirts - Auriza Side Tomb] Cracked Pot 66170")]
        CapitalOutskirtsAurizaSideTombCrackedPot___ = 66170,

        [Display(Name = "[Capital Outskirts - Auriza Side Tomb] Ritual Pot 66470")]
        CapitalOutskirtsAurizaSideTombRitualPot = 66470,

        [Display(Name = "[Capital Outskirts - Auriza Side Tomb] Ritual Pot 66480")]
        CapitalOutskirtsAurizaSideTombRitualPot_ = 66480,

        [Display(Name = "[Caelid - Minor Erdtree Catacombs] Imp Head (Wolf) 30147000")]
        CaelidMinorErdtreeCatacombsImpHeadWolf = 30147000,

        [Display(Name = "[Caelid - Minor Erdtree Catacombs] Grave Violet 30147010")]
        CaelidMinorErdtreeCatacombsGraveViolet = 30147010,

        [Display(Name = "[Caelid - Minor Erdtree Catacombs] Sacramental Bud 30147020")]
        CaelidMinorErdtreeCatacombsSacramentalBud = 30147020,

        [Display(Name = "[Caelid - Minor Erdtree Catacombs] Aeonian Butterfly 30147030")]
        CaelidMinorErdtreeCatacombsAeonianButterfly = 30147030,

        [Display(Name = "[Caelid - Minor Erdtree Catacombs] Golden Rune [4] 30147040")]
        CaelidMinorErdtreeCatacombsGoldenRune4 = 30147040,

        [Display(Name = "[Caelid - Minor Erdtree Catacombs] Golden Rune [1] 30147900")]
        CaelidMinorErdtreeCatacombsGoldenRune1 = 30147900,

        [Display(Name = "[Caelid - Caelid Catacombs] Miranda Sprout Ashes 30157000")]
        CaelidCaelidCatacombsMirandaSproutAshes = 30157000,

        [Display(Name = "[Caelid - War-Dead Catacombs] Golden Rune [6] 30167000")]
        CaelidWarDeadCatacombsGoldenRune6 = 30167000,

        [Display(Name = "[Caelid - War-Dead Catacombs] Magic Grease 30167010")]
        CaelidWarDeadCatacombsMagicGrease = 30167010,

        [Display(Name = "[Caelid - War-Dead Catacombs] Radahn Soldier Ashes 30167020")]
        CaelidWarDeadCatacombsRadahnSoldierAshes = 30167020,

        [Display(Name = "[Caelid - War-Dead Catacombs] Silver-Pickled Fowl Foot 30167030")]
        CaelidWarDeadCatacombsSilverPickledFowlFoot = 30167030,

        [Display(Name = "[Caelid - War-Dead Catacombs] [Sorcery] Collapsing Stars 30167040")]
        CaelidWarDeadCatacombsSorceryCollapsingStars = 30167040,

        [Display(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Cranial Vessel Candlestand 30177000")]
        FlamePeakGiantConqueringHerosGraveCranialVesselCandlestand = 30177000,

        [Display(Name = "[Flame Peak - Giant-Conquering Hero's Grave] [Incantation] Flame 30177010")]
        FlamePeakGiantConqueringHerosGraveIncantationFlame = 30177010,

        [Display(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Lightning Bastard Sword 30177020")]
        FlamePeakGiantConqueringHerosGraveLightningBastardSword = 30177020,

        [Display(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Giant's Seal 30177030")]
        FlamePeakGiantConqueringHerosGraveGiantsSeal = 30177030,

        [Display(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Freezing Grease 30177040")]
        FlamePeakGiantConqueringHerosGraveFreezingGrease = 30177040,

        [Display(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Golden Rune [11] 30177050")]
        FlamePeakGiantConqueringHerosGraveGoldenRune11 = 30177050,

        [Display(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Golden Rune [1] 30177060")]
        FlamePeakGiantConqueringHerosGraveGoldenRune1 = 30177060,

        [Display(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Golden Rune [10] 30187000")]
        FlamePeakGiantsMountaintopCatacombsGoldenRune10 = 30187000,

        [Display(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Stimulating Boluses 30187010")]
        FlamePeakGiantsMountaintopCatacombsStimulatingBoluses = 30187010,

        [Display(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Nascent Butterfly 30187020")]
        FlamePeakGiantsMountaintopCatacombsNascentButterfly = 30187020,

        [Display(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Root Resin 30187030")]
        FlamePeakGiantsMountaintopCatacombsRootResin = 30187030,

        [Display(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Ritual Pot 66400")]
        FlamePeakGiantsMountaintopCatacombsRitualPot = 66400,

        [Display(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Fire Monk Ashes 30187070")]
        FlamePeakGiantsMountaintopCatacombsFireMonkAshes = 30187070,

        [Display(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Deathroot 30187900")]
        FlamePeakGiantsMountaintopCatacombsDeathroot = 30187900,

        [Display(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Golden Rune [12] 30197000")]
        FlamePeakConsecratedSnowfieldCatacombsGoldenRune12 = 30197000,

        [Display(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Rejuvenating Boluses 30197010")]
        FlamePeakConsecratedSnowfieldCatacombsRejuvenatingBoluses = 30197010,

        [Display(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Root Resin 30197020")]
        FlamePeakConsecratedSnowfieldCatacombsRootResin = 30197020,

        [Display(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Human Bone Shard 30197030")]
        FlamePeakConsecratedSnowfieldCatacombsHumanBoneShard = 30197030,

        [Display(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Imp Head (Elder) 30197040")]
        FlamePeakConsecratedSnowfieldCatacombsImpHeadElder = 30197040,

        [Display(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Golden Rune [1] 30197900")]
        FlamePeakConsecratedSnowfieldCatacombsGoldenRune1 = 30197900,

        [Display(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Warming Stone 30207000")]
        ForbiddenLandsHiddenPathtoTheHaligtreeWarmingStone = 30207000,

        [Display(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Sacramental Bud 30207010")]
        ForbiddenLandsHiddenPathtoTheHaligtreeSacramentalBud = 30207010,

        [Display(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Hero's Rune [1] 30207020")]
        ForbiddenLandsHiddenPathtoTheHaligtreeHerosRune1 = 30207020,

        [Display(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Old Fang 30207030")]
        ForbiddenLandsHiddenPathtoTheHaligtreeOldFang = 30207030,

        [Display(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Root Resin 30207040")]
        ForbiddenLandsHiddenPathtoTheHaligtreeRootResin = 30207040,

        [Display(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Freezing Grease 30207050")]
        ForbiddenLandsHiddenPathtoTheHaligtreeFreezingGrease = 30207050,

        [Display(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Spelldrake Talisman +2 30207060")]
        ForbiddenLandsHiddenPathtoTheHaligtreeSpelldrakeTalisman2 = 30207060,

        [Display(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Silver Scarab 30207900")]
        ForbiddenLandsHiddenPathtoTheHaligtreeSilverScarab = 30207900,

        [Display(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Deathroot 30207910")]
        ForbiddenLandsHiddenPathtoTheHaligtreeDeathroot = 30207910,

        [Display(Name = "[Limgrave - Murkwater Cave] Mushroom 31007000")]
        LimgraveMurkwaterCaveMushroom = 31007000,

        [Display(Name = "[Limgrave - Murkwater Cave] Cloth Garb 31007010")]
        LimgraveMurkwaterCaveClothGarb = 31007010,

        [Display(Name = "[Weeping Peninsula - Earthbore Cave] Golden Rune [1] 31017000")]
        WeepingPeninsulaEarthboreCaveGoldenRune1 = 31017000,

        [Display(Name = "[Weeping Peninsula - Earthbore Cave] Glowstone 31017010")]
        WeepingPeninsulaEarthboreCaveGlowstone = 31017010,

        [Display(Name = "[Weeping Peninsula - Earthbore Cave] Kukri 31017020")]
        WeepingPeninsulaEarthboreCaveKukri = 31017020,

        [Display(Name = "[Weeping Peninsula - Earthbore Cave] Smoldering Butterfly 31017030")]
        WeepingPeninsulaEarthboreCaveSmolderingButterfly = 31017030,

        [Display(Name = "[Weeping Peninsula - Earthbore Cave] Trina's Lily 31017040")]
        WeepingPeninsulaEarthboreCaveTrinasLily = 31017040,

        [Display(Name = "[Weeping Peninsula - Earthbore Cave] Pickled Turtle Neck 31017060")]
        WeepingPeninsulaEarthboreCavePickledTurtleNeck = 31017060,

        [Display(Name = "[Weeping Peninsula - Tombsward Cave] Golden Rune [2] 31027000")]
        WeepingPeninsulaTombswardCaveGoldenRune2 = 31027000,

        [Display(Name = "[Weeping Peninsula - Tombsward Cave] Furlcalling Finger Remedy 31027010")]
        WeepingPeninsulaTombswardCaveFurlcallingFingerRemedy = 31027010,

        [Display(Name = "[Weeping Peninsula - Tombsward Cave] Poisonbone Dart 31027020")]
        WeepingPeninsulaTombswardCavePoisonboneDart = 31027020,

        [Display(Name = "[Weeping Peninsula - Tombsward Cave] Arteria Leaf 31027030")]
        WeepingPeninsulaTombswardCaveArteriaLeaf = 31027030,

        [Display(Name = "[Weeping Peninsula - Tombsward Cave] Nomadic Warrior's Cookbook [8] 67880")]
        WeepingPeninsulaTombswardCaveNomadicWarriorsCookbook8 = 67880,

        [Display(Name = "[Weeping Peninsula - Tombsward Cave] Immunizing White Cured Meat 31027050")]
        WeepingPeninsulaTombswardCaveImmunizingWhiteCuredMeat = 31027050,

        [Display(Name = "[Limgrave - Groveside Cave] Golden Rune [1] 31037000")]
        LimgraveGrovesideCaveGoldenRune1 = 31037000,

        [Display(Name = "[Limgrave - Groveside Cave] Glowstone 31037010")]
        LimgraveGrovesideCaveGlowstone = 31037010,

        [Display(Name = "[Limgrave - Groveside Cave] Cracked Pot 66000")]
        LimgraveGrovesideCaveCrackedPot = 66000,

        [Display(Name = "[Liurnia - Stillwater Cave] Golden Rune [3] 31047000")]
        LiurniaStillwaterCaveGoldenRune3 = 31047000,

        [Display(Name = "[Liurnia - Stillwater Cave] Golden Rune [4] 31047010")]
        LiurniaStillwaterCaveGoldenRune4 = 31047010,

        [Display(Name = "[Liurnia - Stillwater Cave] Serpent Arrow 31047020")]
        LiurniaStillwaterCaveSerpentArrow = 31047020,

        [Display(Name = "[Liurnia - Stillwater Cave] Golden Rune [5] 31047030")]
        LiurniaStillwaterCaveGoldenRune5 = 31047030,

        [Display(Name = "[Liurnia - Stillwater Cave] Glowstone 31047040")]
        LiurniaStillwaterCaveGlowstone = 31047040,

        [Display(Name = "[Liurnia - Stillwater Cave] Poison Grease 31047050")]
        LiurniaStillwaterCavePoisonGrease = 31047050,

        [Display(Name = "[Liurnia - Stillwater Cave] Sage Hood 31047060")]
        LiurniaStillwaterCaveSageHood = 31047060,

        [Display(Name = "[Liurnia - Lakeside Crystal Cave] Hefty Beast Bone 31057000")]
        LiurniaLakesideCrystalCaveHeftyBeastBone = 31057000,

        [Display(Name = "[Liurnia - Lakeside Crystal Cave] Throwing Dagger 31057010")]
        LiurniaLakesideCrystalCaveThrowingDagger = 31057010,

        [Display(Name = "[Liurnia - Lakeside Crystal Cave] Golden Rune [5] 31057020")]
        LiurniaLakesideCrystalCaveGoldenRune5 = 31057020,

        [Display(Name = "[Liurnia - Lakeside Crystal Cave] Soft Cotton 31057030")]
        LiurniaLakesideCrystalCaveSoftCotton = 31057030,

        [Display(Name = "[Liurnia - Lakeside Crystal Cave] Smithing Stone [4] 31057040")]
        LiurniaLakesideCrystalCaveSmithingStone4 = 31057040,

        [Display(Name = "[Liurnia - Lakeside Crystal Cave] Smithing Stone [2] 31057050")]
        LiurniaLakesideCrystalCaveSmithingStone2 = 31057050,

        [Display(Name = "[Liurnia - Lakeside Crystal Cave] Lump of Flesh 31057060")]
        LiurniaLakesideCrystalCaveLumpOfFlesh = 31057060,

        [Display(Name = "[Liurnia - Lakeside Crystal Cave] Arteria Leaf 31057070")]
        LiurniaLakesideCrystalCaveArteriaLeaf = 31057070,

        [Display(Name = "[Liurnia - Lakeside Crystal Cave] Spear Talisman 31057100")]
        LiurniaLakesideCrystalCaveSpearTalisman = 31057100,

        [Display(Name = "[Liurnia - Academy Crystal Cave] Cuckoo Glintstone 31067000")]
        LiurniaAcademyCrystalCaveCuckooGlintstone = 31067000,

        [Display(Name = "[Liurnia - Academy Crystal Cave] Stonesword Key 31067010")]
        LiurniaAcademyCrystalCaveStoneswordKey = 31067010,

        [Display(Name = "[Liurnia - Academy Crystal Cave] Rune Arc 31067100")]
        LiurniaAcademyCrystalCaveRuneArc = 31067100,

        [Display(Name = "[Liurnia - Academy Crystal Cave] Crystal Staff 31067030")]
        LiurniaAcademyCrystalCaveCrystalStaff = 31067030,

        [Display(Name = "[Mt. Gelmir - Seethewater Cave] Poison Grease 31077000")]
        MtGelmirSeethewaterCavePoisonGrease = 31077000,

        [Display(Name = "[Mt. Gelmir - Seethewater Cave] Lump of Flesh 31077010")]
        MtGelmirSeethewaterCaveLumpOfFlesh = 31077010,

        [Display(Name = "[Mt. Gelmir - Seethewater Cave] Preserving Boluses 31077020")]
        MtGelmirSeethewaterCavePreservingBoluses = 31077020,

        [Display(Name = "[Mt. Gelmir - Seethewater Cave] Mushroom Head 31077030")]
        MtGelmirSeethewaterCaveMushroomHead = 31077030,

        [Display(Name = "[Mt. Gelmir - Seethewater Cave] Poisonbone Dart 31077040")]
        MtGelmirSeethewaterCavePoisonboneDart = 31077040,

        [Display(Name = "[Mt. Gelmir - Seethewater Cave] Golden Rune [6] 31077050")]
        MtGelmirSeethewaterCaveGoldenRune6 = 31077050,

        [Display(Name = "[Mt. Gelmir - Seethewater Cave] Golden Rune [7] 31077060")]
        MtGelmirSeethewaterCaveGoldenRune7 = 31077060,

        [Display(Name = "[Mt. Gelmir - Seethewater Cave] Immunizing Cured Meat 31077070")]
        MtGelmirSeethewaterCaveImmunizingCuredMeat = 31077070,

        [Display(Name = "[Mt. Gelmir - Volcano Cave] Golden Rune [6] 31097000")]
        MtGelmirVolcanoCaveGoldenRune6 = 31097000,

        [Display(Name = "[Mt. Gelmir - Volcano Cave] Sliver of Meat 31097010")]
        MtGelmirVolcanoCaveSliverOfMeat = 31097010,

        [Display(Name = "[Mt. Gelmir - Volcano Cave] Arteria Leaf 31097020")]
        MtGelmirVolcanoCaveArteriaLeaf = 31097020,

        [Display(Name = "[Mt. Gelmir - Volcano Cave] Lump of Flesh 31097030")]
        MtGelmirVolcanoCaveLumpOfFlesh = 31097030,

        [Display(Name = "[Mt. Gelmir - Volcano Cave] Coil Shield 31097040")]
        MtGelmirVolcanoCaveCoilShield = 31097040,

        [Display(Name = "[Altus Plateau - Perfumer's Grotto] Perfume Bottle 66780")]
        AltusPlateauPerfumersGrottoPerfumeBottle = 66780,

        [Display(Name = "[Altus Plateau - Perfumer's Grotto] Living Jar Shard 31187020")]
        AltusPlateauPerfumersGrottoLivingJarShard = 31187020,

        [Display(Name = "[Altus Plateau - Perfumer's Grotto] Living Jar Shard 31187030")]
        AltusPlateauPerfumersGrottoLivingJarShard_ = 31187030,

        [Display(Name = "[Altus Plateau - Perfumer's Grotto] Arteria Leaf 31187040")]
        AltusPlateauPerfumersGrottoArteriaLeaf = 31187040,

        [Display(Name = "[Altus Plateau - Perfumer's Grotto] Golden Rune [5] 31187050")]
        AltusPlateauPerfumersGrottoGoldenRune5 = 31187050,

        [Display(Name = "[Altus Plateau - Perfumer's Grotto] Miranda Powder 31187060")]
        AltusPlateauPerfumersGrottoMirandaPowder = 31187060,

        [Display(Name = "[Altus Plateau - Perfumer's Grotto] Warming Stone 31187070")]
        AltusPlateauPerfumersGrottoWarmingStone = 31187070,

        [Display(Name = "[Altus Plateau - Perfumer's Grotto] Golden Rune [5] 31187080")]
        AltusPlateauPerfumersGrottoGoldenRune5_ = 31187080,

        [Display(Name = "[Altus Plateau - Sage's Cave] Rejuvenating Boluses 31197000")]
        AltusPlateauSagesCaveRejuvenatingBoluses = 31197000,

        [Display(Name = "[Altus Plateau - Sage's Cave] Lost Ashes of War 31197010")]
        AltusPlateauSagesCaveLostAshesOfWar = 31197010,

        [Display(Name = "[Altus Plateau - Sage's Cave] Candletree Wooden Shield 31197030")]
        AltusPlateauSagesCaveCandletreeWoodenShield = 31197030,

        [Display(Name = "[Altus Plateau - Sage's Cave] Silver-Pickled Fowl Foot 31197040")]
        AltusPlateauSagesCaveSilverPickledFowlFoot = 31197040,

        [Display(Name = "[Altus Plateau - Sage's Cave] Black Hood 31197050")]
        AltusPlateauSagesCaveBlackHood = 31197050,

        [Display(Name = "[Altus Plateau - Sage's Cave] Nascent Butterfly 31197060")]
        AltusPlateauSagesCaveNascentButterfly = 31197060,

        [Display(Name = "[Altus Plateau - Sage's Cave] Stonesword Key 31197080")]
        AltusPlateauSagesCaveStoneswordKey = 31197080,

        [Display(Name = "[Altus Plateau - Sage's Cave] Dragonwound Grease 31197090")]
        AltusPlateauSagesCaveDragonwoundGrease = 31197090,

        [Display(Name = "[Altus Plateau - Sage's Cave] Raptor Talons 31197100")]
        AltusPlateauSagesCaveRaptorTalons = 31197100,

        [Display(Name = "[Altus Plateau - Sage's Cave] Golden Great Arrow 31197110")]
        AltusPlateauSagesCaveGoldenGreatArrow = 31197110,

        [Display(Name = "[Altus Plateau - Sage's Cave] Raptor's Black Feathers 31197120")]
        AltusPlateauSagesCaveRaptorsBlackFeathers = 31197120,

        [Display(Name = "[Altus Plateau - Sage's Cave] Skeletal Mask 31197130")]
        AltusPlateauSagesCaveSkeletalMask = 31197130,

        [Display(Name = "[Altus Plateau - Sage's Cave] Golden Rune [5] 31197200")]
        AltusPlateauSagesCaveGoldenRune5 = 31197200,

        [Display(Name = "[Altus Plateau - Sage's Cave] Golden Rune [5] 31197210")]
        AltusPlateauSagesCaveGoldenRune5_ = 31197210,

        [Display(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Cave] Warming Stone 31107000")]
        GreyollsDragonbarrowDragonbarrowCaveWarmingStone = 31107000,

        [Display(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Cave] Golden Rune [12] 31107010")]
        GreyollsDragonbarrowDragonbarrowCaveGoldenRune12 = 31107010,

        [Display(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Cave] Bull-Goat's Talisman 31107050")]
        GreyollsDragonbarrowDragonbarrowCaveBullGoatsTalisman = 31107050,

        [Display(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Cave] Golden Rune [8] 31107110")]
        GreyollsDragonbarrowDragonbarrowCaveGoldenRune8 = 31107110,

        [Display(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Cave] Beast Blood 31107120")]
        GreyollsDragonbarrowDragonbarrowCaveBeastBlood = 31107120,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Golden Rune [3] 31117000")]
        GreyollsDragonbarrowSelliaHideawayGoldenRune3 = 31117000,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Lost Ashes of War 31117010")]
        GreyollsDragonbarrowSelliaHideawayLostAshesOfWar = 31117010,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Golden Rune [5] 31117020")]
        GreyollsDragonbarrowSelliaHideawayGoldenRune5 = 31117020,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Stimulating Boluses 31117030")]
        GreyollsDragonbarrowSelliaHideawayStimulatingBoluses = 31117030,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Somber Smithing Stone [4] 31117040")]
        GreyollsDragonbarrowSelliaHideawaySomberSmithingStone4 = 31117040,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Preserving Boluses 31117080")]
        GreyollsDragonbarrowSelliaHideawayPreservingBoluses = 31117080,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Crystal Dart 31117090")]
        GreyollsDragonbarrowSelliaHideawayCrystalDart = 31117090,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Golden Rune [5] 31117100")]
        GreyollsDragonbarrowSelliaHideawayGoldenRune5_ = 31117100,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Glowstone 31117110")]
        GreyollsDragonbarrowSelliaHideawayGlowstone = 31117110,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Crystal Spear 31117200")]
        GreyollsDragonbarrowSelliaHideawayCrystalSpear = 31117200,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Crystalian Ashes 31117220")]
        GreyollsDragonbarrowSelliaHideawayCrystalianAshes = 31117220,

        [Display(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Smithing Stone [1] 31117300")]
        GreyollsDragonbarrowSelliaHideawaySmithingStone1 = 31117300,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Golden Rune [7] 31127000")]
        ConsecratedSnowfieldCaveOfTheForlornGoldenRune7 = 31127000,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Freezing Grease 31127010")]
        ConsecratedSnowfieldCaveOfTheForlornFreezingGrease = 31127010,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Hero's Rune [2] 31127020")]
        ConsecratedSnowfieldCaveOfTheForlornHerosRune2 = 31127020,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Rune Arc 31127030")]
        ConsecratedSnowfieldCaveOfTheForlornRuneArc = 31127030,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Miquella's Lily 31127040")]
        ConsecratedSnowfieldCaveOfTheForlornMiquellasLily = 31127040,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Nascent Butterfly 31127050")]
        ConsecratedSnowfieldCaveOfTheForlornNascentButterfly = 31127050,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Thawfrost Boluses 31127060")]
        ConsecratedSnowfieldCaveOfTheForlornThawfrostBoluses = 31127060,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Crystal Dart 31127070")]
        ConsecratedSnowfieldCaveOfTheForlornCrystalDart = 31127070,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Thawfrost Boluses 31127080")]
        ConsecratedSnowfieldCaveOfTheForlornThawfrostBoluses_ = 31127080,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Freezing Grease 31127090")]
        ConsecratedSnowfieldCaveOfTheForlornFreezingGrease_ = 31127090,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Freezing Grease 31127100")]
        ConsecratedSnowfieldCaveOfTheForlornFreezingGrease__ = 31127100,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Golden Rune [10] 31127110")]
        ConsecratedSnowfieldCaveOfTheForlornGoldenRune10 = 31127110,

        [Display(Name = "[Consecrated Snowfield - Cave of the Forlorn] Spiritflame Arrow 31127120")]
        ConsecratedSnowfieldCaveOfTheForlornSpiritflameArrow = 31127120,

        [Display(Name = "[Limgrave - Coastal Cave] Land Octopus Ovary 31157010")]
        LimgraveCoastalCaveLandOctopusOvary = 31157010,

        [Display(Name = "[Limgrave - Coastal Cave] Smoldering Butterfly 31157020")]
        LimgraveCoastalCaveSmolderingButterfly = 31157020,

        [Display(Name = "[Limgrave - Highroad Cave] Golden Rune [1] 31177010")]
        LimgraveHighroadCaveGoldenRune1 = 31177010,

        [Display(Name = "[Limgrave - Highroad Cave] Arteria Leaf 31177020")]
        LimgraveHighroadCaveArteriaLeaf = 31177020,

        [Display(Name = "[Limgrave - Highroad Cave] Smithing Stone [1] 31177030")]
        LimgraveHighroadCaveSmithingStone1 = 31177030,

        [Display(Name = "[Limgrave - Highroad Cave] Smithing Stone [2] 31177040")]
        LimgraveHighroadCaveSmithingStone2 = 31177040,

        [Display(Name = "[Limgrave - Highroad Cave] Golden Rune [4] 31177050")]
        LimgraveHighroadCaveGoldenRune4 = 31177050,

        [Display(Name = "[Limgrave - Highroad Cave] Fire Grease 31177060")]
        LimgraveHighroadCaveFireGrease = 31177060,

        [Display(Name = "[Limgrave - Highroad Cave] Furlcalling Finger Remedy 31177070")]
        LimgraveHighroadCaveFurlcallingFingerRemedy = 31177070,

        [Display(Name = "[Limgrave - Highroad Cave] Shamshir 31177080")]
        LimgraveHighroadCaveShamshir = 31177080,

        [Display(Name = "[Caelid - Abandoned Cave] Dragonwound Grease 31207000")]
        CaelidAbandonedCaveDragonwoundGrease = 31207000,

        [Display(Name = "[Caelid - Abandoned Cave] Venomous Fang 31207010")]
        CaelidAbandonedCaveVenomousFang = 31207010,

        [Display(Name = "[Caelid - Abandoned Cave] Serpent Bow 31207020")]
        CaelidAbandonedCaveSerpentBow = 31207020,

        [Display(Name = "[Caelid - Abandoned Cave] Fire Grease 31207030")]
        CaelidAbandonedCaveFireGrease = 31207030,

        [Display(Name = "[Caelid - Gaol Cave] Golden Rune [2] 31217000")]
        CaelidGaolCaveGoldenRune2 = 31217000,

        [Display(Name = "[Caelid - Gaol Cave] Golden Rune [2] 31217030")]
        CaelidGaolCaveGoldenRune2_ = 31217030,

        [Display(Name = "[Caelid - Gaol Cave] Old Fang 31217040")]
        CaelidGaolCaveOldFang = 31217040,

        [Display(Name = "[Caelid - Gaol Cave] Golden Rune [2] 31217070")]
        CaelidGaolCaveGoldenRune2__ = 31217070,

        [Display(Name = "[Caelid - Gaol Cave] Golden Rune [4] 31217080")]
        CaelidGaolCaveGoldenRune4 = 31217080,

        [Display(Name = "[Caelid - Gaol Cave] Stonesword Key 31217090")]
        CaelidGaolCaveStoneswordKey = 31217090,

        [Display(Name = "[Caelid - Gaol Cave] Wakizashi 31217100")]
        CaelidGaolCaveWakizashi = 31217100,

        [Display(Name = "[Caelid - Gaol Cave] Golden Rune [4] 31217110")]
        CaelidGaolCaveGoldenRune4_ = 31217110,

        [Display(Name = "[Caelid - Gaol Cave] Turtle Neck Meat 31217120")]
        CaelidGaolCaveTurtleNeckMeat = 31217120,

        [Display(Name = "[Caelid - Gaol Cave] Golden Rune [5] 31217140")]
        CaelidGaolCaveGoldenRune5 = 31217140,

        [Display(Name = "[Caelid - Gaol Cave] Rainbow Stone 31217150")]
        CaelidGaolCaveRainbowStone = 31217150,

        [Display(Name = "[Caelid - Gaol Cave] Golden Rune [4] 31217160")]
        CaelidGaolCaveGoldenRune4__ = 31217160,

        [Display(Name = "[Caelid - Gaol Cave] Glowstone 31217190")]
        CaelidGaolCaveGlowstone = 31217190,

        [Display(Name = "[Caelid - Gaol Cave] Somber Smithing Stone [5] 31217200")]
        CaelidGaolCaveSomberSmithingStone5 = 31217200,

        [Display(Name = "[Caelid - Gaol Cave] Pillory Shield 31217210")]
        CaelidGaolCavePilloryShield = 31217210,

        [Display(Name = "[Caelid - Gaol Cave] Regalia of Eochaid 31217350")]
        CaelidGaolCaveRegaliaOfEochaid = 31217350,

        [Display(Name = "[Caelid - Gaol Cave] Rune Arc 31217400")]
        CaelidGaolCaveRuneArc = 31217400,

        [Display(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] White Reed Armor 31227000")]
        MountaintopsOfTheGiantsSpiritcallersCaveWhiteReedArmor = 31227000,

        [Display(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Golden Rune [6] 31227010")]
        MountaintopsOfTheGiantsSpiritcallersCaveGoldenRune6 = 31227010,

        [Display(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Golden Rune [12] 31227020")]
        MountaintopsOfTheGiantsSpiritcallersCaveGoldenRune12 = 31227020,

        [Display(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Freezing Grease 31227030")]
        MountaintopsOfTheGiantsSpiritcallersCaveFreezingGrease = 31227030,

        [Display(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Golden Rune [10] 31227040")]
        MountaintopsOfTheGiantsSpiritcallersCaveGoldenRune10 = 31227040,

        [Display(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Hero's Rune [1] 31227050")]
        MountaintopsOfTheGiantsSpiritcallersCaveHerosRune1 = 31227050,

        [Display(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Rune Arc 31227060")]
        MountaintopsOfTheGiantsSpiritcallersCaveRuneArc = 31227060,

        [Display(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Invigorating White Cured Meat 31227070")]
        MountaintopsOfTheGiantsSpiritcallersCaveInvigoratingWhiteCuredMeat = 31227070,

        [Display(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Arteria Leaf 31227080")]
        MountaintopsOfTheGiantsSpiritcallersCaveArteriaLeaf = 31227080,

        [Display(Name = "[Weeping Peninsula - Morne Tunnel] Golden Rune [2] 32007000")]
        WeepingPeninsulaMorneTunnelGoldenRune2 = 32007000,

        [Display(Name = "[Weeping Peninsula - Morne Tunnel] Golden Rune [4] 32007010")]
        WeepingPeninsulaMorneTunnelGoldenRune4 = 32007010,

        [Display(Name = "[Weeping Peninsula - Morne Tunnel] Large Glintstone Scrap 32007020")]
        WeepingPeninsulaMorneTunnelLargeGlintstoneScrap = 32007020,

        [Display(Name = "[Weeping Peninsula - Morne Tunnel] Stanching Boluses 32007030")]
        WeepingPeninsulaMorneTunnelStanchingBoluses = 32007030,

        [Display(Name = "[Weeping Peninsula - Morne Tunnel] Soft Cotton 32007060")]
        WeepingPeninsulaMorneTunnelSoftCotton = 32007060,

        [Display(Name = "[Weeping Peninsula - Morne Tunnel] Arteria Leaf 32007070")]
        WeepingPeninsulaMorneTunnelArteriaLeaf = 32007070,

        [Display(Name = "[Weeping Peninsula - Morne Tunnel] Exalted Flesh 32007900")]
        WeepingPeninsulaMorneTunnelExaltedFlesh = 32007900,

        [Display(Name = "[Limgrave - Limgrave Tunnels] Smithing Stone [1] 32017000")]
        LimgraveLimgraveTunnelsSmithingStone1 = 32017000,

        [Display(Name = "[Limgrave - Limgrave Tunnels] Golden Rune [4] 32017010")]
        LimgraveLimgraveTunnelsGoldenRune4 = 32017010,

        [Display(Name = "[Limgrave - Limgrave Tunnels] Large Glintstone Scrap 32017020")]
        LimgraveLimgraveTunnelsLargeGlintstoneScrap = 32017020,

        [Display(Name = "[Limgrave - Limgrave Tunnels] Golden Rune [1] 32017030")]
        LimgraveLimgraveTunnelsGoldenRune1 = 32017030,

        [Display(Name = "[Limgrave - Limgrave Tunnels] Glintstone Scrap 32017040")]
        LimgraveLimgraveTunnelsGlintstoneScrap = 32017040,

        [Display(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Somber Smithing Stone [2] 32027000")]
        LiurniaRayaLucariaCrystalTunnelSomberSmithingStone2 = 32027000,

        [Display(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Somber Smithing Stone [3] 32027010")]
        LiurniaRayaLucariaCrystalTunnelSomberSmithingStone3 = 32027010,

        [Display(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Golden Rune [3] 32027020")]
        LiurniaRayaLucariaCrystalTunnelGoldenRune3 = 32027020,

        [Display(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Smithing Stone [3] 32027030")]
        LiurniaRayaLucariaCrystalTunnelSmithingStone3 = 32027030,

        [Display(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Somber Smithing Stone [3] 32027040")]
        LiurniaRayaLucariaCrystalTunnelSomberSmithingStone3_ = 32027040,

        [Display(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Smithing Stone [1] 32027060")]
        LiurniaRayaLucariaCrystalTunnelSmithingStone1 = 32027060,

        [Display(Name = "[Liurnia - Raya Lucaria Crystal Tunnel [Sorcery] Shatter Earth 32027070")]
        LiurniaRayaLucariaCrystalTunnelSorceryShatterEarth = 32027070,

        [Display(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Crystal Knife 32027900")]
        LiurniaRayaLucariaCrystalTunnelCrystalKnife = 32027900,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel] Golden Rune [6] 32047000")]
        AltusPlateauOldAltusTunnelGoldenRune6 = 32047000,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel] Stanching Boluses 32047010")]
        AltusPlateauOldAltusTunnelStanchingBoluses = 32047010,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel] Somber Smithing Stone [4] 32047020")]
        AltusPlateauOldAltusTunnelSomberSmithingStone4 = 32047020,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel] Explosive Stone Clump 32047030")]
        AltusPlateauOldAltusTunnelExplosiveStoneClump = 32047030,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel] Boltdrake Talisman +1 32047040")]
        AltusPlateauOldAltusTunnelBoltdrakeTalisman1 = 32047040,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel] Troll's Hammer 32047050")]
        AltusPlateauOldAltusTunnelTrollsHammer = 32047050,

        [Display(Name = "[Altus Plateau - Altus Tunnel] Crystal Dart 32057000")]
        AltusPlateauAltusTunnelCrystalDart = 32057000,

        [Display(Name = "[Altus Plateau - Altus Tunnel] Arteria Leaf 32057010")]
        AltusPlateauAltusTunnelArteriaLeaf = 32057010,

        [Display(Name = "[Altus Plateau - Altus Tunnel] Golden Rune [7] 32057020")]
        AltusPlateauAltusTunnelGoldenRune7 = 32057020,

        [Display(Name = "[Altus Plateau - Altus Tunnel] Arsenal Charm +1 32057030")]
        AltusPlateauAltusTunnelArsenalCharm1 = 32057030,

        [Display(Name = "[Altus Plateau - Altus Tunnel] Glintstone Scrap 32057040")]
        AltusPlateauAltusTunnelGlintstoneScrap = 32057040,

        [Display(Name = "[Altus Plateau - Altus Tunnel] 32057900")]
        AltusPlateauAltusTunnel = 32057900,

        [Display(Name = "[Altus Plateau - Altus Tunnel] Rune Arc 32057910")]
        AltusPlateauAltusTunnelRuneArc = 32057910,

        [Display(Name = "[Caelid - Gael Tunnel] Somber Smithing Stone [2] 32077000")]
        CaelidGaelTunnelSomberSmithingStone2 = 32077000,

        [Display(Name = "[Caelid - Gael Tunnel] Golden Rune [5] 32077010")]
        CaelidGaelTunnelGoldenRune5 = 32077010,

        [Display(Name = "[Caelid - Gael Tunnel] Cross-Naginata 32077020")]
        CaelidGaelTunnelCrossNaginata = 32077020,

        [Display(Name = "[Caelid - Gael Tunnel] Dragonbane Talisman 32077030")]
        CaelidGaelTunnelDragonbaneTalisman = 32077030,

        [Display(Name = "[Caelid - Gael Tunnel] Large Glintstone Scrap 32077060")]
        CaelidGaelTunnelLargeGlintstoneScrap = 32077060,

        [Display(Name = "[Caelid - Gael Tunnel] Grace Mimic 32077070")]
        CaelidGaelTunnelGraceMimic = 32077070,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] Rot Grease 32087000")]
        CaelidSelliaCrystalTunnelRotGrease = 32087000,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] Golden Rune [5] 32087020")]
        CaelidSelliaCrystalTunnelGoldenRune5 = 32087020,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] Glintstone Scrap 32087030")]
        CaelidSelliaCrystalTunnelGlintstoneScrap = 32087030,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] Rune Arc 32087050")]
        CaelidSelliaCrystalTunnelRuneArc = 32087050,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] Cuckoo Glintstone 32087060")]
        CaelidSelliaCrystalTunnelCuckooGlintstone = 32087060,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] Somber Smithing Stone [4] 32087070")]
        CaelidSelliaCrystalTunnelSomberSmithingStone4 = 32087070,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] Golden Rune [4] 32087100")]
        CaelidSelliaCrystalTunnelGoldenRune4 = 32087100,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] Dragonwound Grease 32087110")]
        CaelidSelliaCrystalTunnelDragonwoundGrease = 32087110,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] Faithful's Canvas Talisman 32087120")]
        CaelidSelliaCrystalTunnelFaithfulsCanvasTalisman = 32087120,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] Gravity Stone Fan 32087900")]
        CaelidSelliaCrystalTunnelGravityStoneFan = 32087900,

        [Display(Name = "[Caelid - Sellia Crystal Tunnel] [Sorcery] Rock Blaster 32087910")]
        CaelidSelliaCrystalTunnelSorceryRockBlaster = 32087910,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Freezing Grease 32117000")]
        ConsecratedSnowfieldYeloughAnixTunnelFreezingGrease = 32117000,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Golden Rune [10] 32117020")]
        ConsecratedSnowfieldYeloughAnixTunnelGoldenRune10 = 32117020,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Ancient Dragon Smithing Stone 32117030")]
        ConsecratedSnowfieldYeloughAnixTunnelAncientDragonSmithingStone = 32117030,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Rune Arc 32117040")]
        ConsecratedSnowfieldYeloughAnixTunnelRuneArc = 32117040,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Explosive Stone Clump 32117060")]
        ConsecratedSnowfieldYeloughAnixTunnelExplosiveStoneClump = 32117060,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Hero's Rune [5] 32117080")]
        ConsecratedSnowfieldYeloughAnixTunnelHerosRune5 = 32117080,

        [Display(Name = "[Stormhill - Divine Tower of Limgrave] Warming Stone 34107000")]
        StormhillDivineTowerOfLimgraveWarmingStone = 34107000,

        [Display(Name = "[Stormhill - Divine Tower of Limgrave] Soft Cotton 34107010")]
        StormhillDivineTowerOfLimgraveSoftCotton = 34107010,

        [Display(Name = "[Stormhill - Divine Tower of Limgrave] Stormhawk Feather 34107070")]
        StormhillDivineTowerOfLimgraveStormhawkFeather = 34107070,

        [Display(Name = "[Stormhill - Divine Tower of Limgrave] Silver-Pickled Fowl Foot 34107080")]
        StormhillDivineTowerOfLimgraveSilverPickledFowlFoot = 34107080,

        [Display(Name = "[Stormhill - Divine Tower of Limgrave] Golden Rune [2] 34107090")]
        StormhillDivineTowerOfLimgraveGoldenRune2 = 34107090,

        [Display(Name = "[Stormhill - Divine Tower of Limgrave] Boltdrake Talisman 34107100")]
        StormhillDivineTowerOfLimgraveBoltdrakeTalisman = 34107100,

        [Display(Name = "[Stormhill - Divine Tower of Limgrave] Ash-of-War Scarab 34107110")]
        StormhillDivineTowerOfLimgraveAshofWarScarab = 34107110,

        [Display(Name = "[Stormhill - Divine Tower of Limgrave] Godrick's Great Rune 191")]
        StormhillDivineTowerOfLimgraveGodricksGreatRune = 191,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Golden Rune [3] 34117010")]
        LiurniaDivineTowerOfLiurniaGoldenRune3 = 34117010,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Golden Rune [4] 34117060")]
        LiurniaDivineTowerOfLiurniaGoldenRune4 = 34117060,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Cerulean Seed Talisman 34117080")]
        LiurniaDivineTowerOfLiurniaCeruleanSeedTalisman = 34117080,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Mask of Confidence 34117100")]
        LiurniaDivineTowerOfLiurniaMaskOfConfidence = 34117100,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Holyproof Dried Liver 34117110")]
        LiurniaDivineTowerOfLiurniaHolyproofDriedLiver = 34117110,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Glintstone Firefly 34117120")]
        LiurniaDivineTowerOfLiurniaGlintstoneFirefly = 34117120,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Carian Glintstone Staff 34117200")]
        LiurniaDivineTowerOfLiurniaCarianGlintstoneStaff = 34117200,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Godskin Apostle Hood 34117400")]
        LiurniaDivineTowerOfLiurniaGodskinApostleHood = 34117400,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Godskin Apostle Robe 34117401")]
        LiurniaDivineTowerOfLiurniaGodskinApostleRobe = 34117401,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Godskin Apostle Bracelets 34117402")]
        LiurniaDivineTowerOfLiurniaGodskinApostleBracelets = 34117402,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Godskin Apostle Trousers 34117403")]
        LiurniaDivineTowerOfLiurniaGodskinApostleTrousers = 34117403,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] Cursemark of Death 34117500")]
        LiurniaDivineTowerOfLiurniaCursemarkOfDeath = 34117500,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] [Sorcery] Magic Downpour 34117700")]
        LiurniaDivineTowerOfLiurniaSorceryMagicDownpour = 34117700,

        [Display(Name = "[Liurnia - Divine Tower of Liurnia] [Sorcery] Lucidity 34117710")]
        LiurniaDivineTowerOfLiurniaSorceryLucidity = 34117710,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Golden Rune [5] 34127010")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune5 = 34127010,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Golden Rune [5] 34127020")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune5_ = 34127020,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] 34127030")]
        CapitalOutskirtsDivineTowerOfWestAltus = 34127030,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Hefty Beast Bone 34127040")]
        CapitalOutskirtsDivineTowerOfWestAltusHeftyBeastBone = 34127040,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Gold-Pickled Fowl Foot 34127050")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldPickledFowlFoot = 34127050,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Stonesword Key 34127060")]
        CapitalOutskirtsDivineTowerOfWestAltusStoneswordKey = 34127060,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Rune Arc 34127070")]
        CapitalOutskirtsDivineTowerOfWestAltusRuneArc = 34127070,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Golden Rune [1] 34127080")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune1 = 34127080,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Furlcalling Finger Remedy 34127090")]
        CapitalOutskirtsDivineTowerOfWestAltusFurlcallingFingerRemedy = 34127090,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Old Fang 34127100")]
        CapitalOutskirtsDivineTowerOfWestAltusOldFang = 34127100,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Grace Mimic 34127110")]
        CapitalOutskirtsDivineTowerOfWestAltusGraceMimic = 34127110,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Large Glintstone Scrap 34127120")]
        CapitalOutskirtsDivineTowerOfWestAltusLargeGlintstoneScrap = 34127120,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Smithing Stone [6] 34127130")]
        CapitalOutskirtsDivineTowerOfWestAltusSmithingStone6 = 34127130,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] 34127140")]
        CapitalOutskirtsDivineTowerOfWestAltus_ = 34127140,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Lightning Grease 34127150")]
        CapitalOutskirtsDivineTowerOfWestAltusLightningGrease = 34127150,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Golden Rune [9] 34127160")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune9 = 34127160,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Rykard's Great Rune 194")]
        CapitalOutskirtsDivineTowerOfWestAltusRykardsGreatRune = 194,

        [Display(Name = "[Capital Outskirts - Divine Tower of West Altus] Smithing-Stone Miner's Bell Bearing [2] 34127900")]
        CapitalOutskirtsDivineTowerOfWestAltusSmithingStoneMinersBellBearing2 = 34127900,

        [Display(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid] Stonesword Key 34137000")]
        GreyollsDragonbarrowDivineTowerOfCaelidStoneswordKey = 34137000,

        [Display(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid] Rune Arc 34137010")]
        GreyollsDragonbarrowDivineTowerOfCaelidRuneArc = 34137010,

        [Display(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid] Golden Rune [12] 34137020")]
        GreyollsDragonbarrowDivineTowerOfCaelidGoldenRune12 = 34137020,

        [Display(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid] Radahn's Great Rune 192")]
        GreyollsDragonbarrowDivineTowerOfCaelidRadahnsGreatRune = 192,

        [Display(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid] Godslayer's Greatsword 34137900")]
        GreyollsDragonbarrowDivineTowerOfCaelidGodslayersGreatsword = 34137900,

        [Display(Name = "[Forbidden Lands - Divine Tower of East Altus] Invigorating White Cured Meat 34147000")]
        ForbiddenLandsDivineTowerOfEastAltusInvigoratingWhiteCuredMeat = 34147000,

        [Display(Name = "[Forbidden Lands - Divine Tower of East Altus] Official's Attire 34147010")]
        ForbiddenLandsDivineTowerOfEastAltusOfficialsAttire = 34147010,

        [Display(Name = "[Forbidden Lands - Divine Tower of East Altus] Flamedrake Talisman +1 34147020")]
        ForbiddenLandsDivineTowerOfEastAltusFlamedrakeTalisman1 = 34147020,

        [Display(Name = "[Forbidden Lands - Divine Tower of East Altus] Morgott's Great Rune 193")]
        ForbiddenLandsDivineTowerOfEastAltusMorgottsGreatRune = 193,

        [Display(Name = "[Forbidden Lands - Divine Tower of East Altus] Mohg's Great Rune 195")]
        ForbiddenLandsDivineTowerOfEastAltusMohgsGreatRune = 195,

        [Display(Name = "[Forbidden Lands - Divine Tower of East Altus] Somber Smithing Stone [6] 34147720")]
        ForbiddenLandsDivineTowerOfEastAltusSomberSmithingStone6 = 34147720,

        [Display(Name = "[Forbidden Lands - Divine Tower of East Altus] Golden Rune [9] 34147800")]
        ForbiddenLandsDivineTowerOfEastAltusGoldenRune9 = 34147800,

        [Display(Name = "[Forbidden Lands - Divine Tower of East Altus] Blade of Calling 34147810")]
        ForbiddenLandsDivineTowerOfEastAltusBladeOfCalling = 34147810,

        [Display(Name = "[Greyoll's Dragonbarrow - Isolated Divine Tower] Malenia's Great Rune 196")]
        GreyollsDragonbarrowIsolatedDivineTowerMaleniasGreatRune = 196,

        [Display(Name = "[Subterranean Shunning-Grounds] Poisonbone Dart 35007000")]
        SubterraneanShunningGroundsPoisonboneDart = 35007000,

        [Display(Name = "[Subterranean Shunning-Grounds] Glass Shard 35007010")]
        SubterraneanShunningGroundsGlassShard = 35007010,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [1] 35007020")]
        SubterraneanShunningGroundsGoldenRune1 = 35007020,

        [Display(Name = "[Subterranean Shunning-Grounds] Crimson Amber Medallion +2 35007030")]
        SubterraneanShunningGroundsCrimsonAmberMedallion2 = 35007030,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [11] 35007040")]
        SubterraneanShunningGroundsGoldenRune11 = 35007040,

        [Display(Name = "[Subterranean Shunning-Grounds] Bloodsoaked Manchettes 35007050")]
        SubterraneanShunningGroundsBloodsoakedManchettes = 35007050,

        [Display(Name = "[Subterranean Shunning-Grounds] Eye of Yelough 35007060")]
        SubterraneanShunningGroundsEyeOfYelough = 35007060,

        [Display(Name = "[Subterranean Shunning-Grounds] Note: Miquella's Needle 69740")]
        SubterraneanShunningGroundsNoteMiquellasNeedle = 69740,

        [Display(Name = "[Subterranean Shunning-Grounds] Preserving Boluses 35007080")]
        SubterraneanShunningGroundsPreservingBoluses = 35007080,

        [Display(Name = "[Subterranean Shunning-Grounds] Furlcalling Finger Remedy 35007090")]
        SubterraneanShunningGroundsFurlcallingFingerRemedy = 35007090,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [1] 35007100")]
        SubterraneanShunningGroundsGoldenRune1_ = 35007100,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [11] 35007110")]
        SubterraneanShunningGroundsGoldenRune11_ = 35007110,

        [Display(Name = "[Subterranean Shunning-Grounds] Rune Arc 35007120")]
        SubterraneanShunningGroundsRuneArc = 35007120,

        [Display(Name = "[Subterranean Shunning-Grounds] Lost Ashes of War 35007130")]
        SubterraneanShunningGroundsLostAshesOfWar = 35007130,

        [Display(Name = "[Subterranean Shunning-Grounds] Glass Shard 35007150")]
        SubterraneanShunningGroundsGlassShard_ = 35007150,

        [Display(Name = "[Subterranean Shunning-Grounds] Stonesword Key 35007160")]
        SubterraneanShunningGroundsStoneswordKey = 35007160,

        [Display(Name = "[Subterranean Shunning-Grounds] Rainbow Stone Arrow (Fletched) 35007170")]
        SubterraneanShunningGroundsRainbowStoneArrowFletched = 35007170,

        [Display(Name = "[Subterranean Shunning-Grounds] Grave Violet 35007180")]
        SubterraneanShunningGroundsGraveViolet = 35007180,

        [Display(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007190")]
        SubterraneanShunningGroundsSmithingStone7 = 35007190,

        [Display(Name = "[Subterranean Shunning-Grounds] Fireproof Dried Liver 35007200")]
        SubterraneanShunningGroundsFireproofDriedLiver = 35007200,

        [Display(Name = "[Subterranean Shunning-Grounds] Somber Smithing Stone [8] 35007210")]
        SubterraneanShunningGroundsSomberSmithingStone8 = 35007210,

        [Display(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007220")]
        SubterraneanShunningGroundsSmithingStone7_ = 35007220,

        [Display(Name = "[Subterranean Shunning-Grounds] Grace Mimic 35007240")]
        SubterraneanShunningGroundsGraceMimic = 35007240,

        [Display(Name = "[Subterranean Shunning-Grounds] String 35007250")]
        SubterraneanShunningGroundsString = 35007250,

        [Display(Name = "[Subterranean Shunning-Grounds] Fire Grease 35007260")]
        SubterraneanShunningGroundsFireGrease = 35007260,

        [Display(Name = "[Subterranean Shunning-Grounds] Nomad Ashes 35007270")]
        SubterraneanShunningGroundsNomadAshes = 35007270,

        [Display(Name = "[Subterranean Shunning-Grounds] Preserving Boluses 35007280")]
        SubterraneanShunningGroundsPreservingBoluses_ = 35007280,

        [Display(Name = "[Subterranean Shunning-Grounds] Glass Shard 35007300")]
        SubterraneanShunningGroundsGlassShard__ = 35007300,

        [Display(Name = "[Subterranean Shunning-Grounds] Mohg's Shackle 35007310")]
        SubterraneanShunningGroundsMohgsShackle = 35007310,

        [Display(Name = "[Subterranean Shunning-Grounds] Dappled White Cured Meat 35007320")]
        SubterraneanShunningGroundsDappledWhiteCuredMeat = 35007320,

        [Display(Name = "[Subterranean Shunning-Grounds] Glass Shard 35007330")]
        SubterraneanShunningGroundsGlassShard___ = 35007330,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Centipede 35007340")]
        SubterraneanShunningGroundsGoldenCentipede = 35007340,

        [Display(Name = "[Subterranean Shunning-Grounds] Poisoned Stone 35007350")]
        SubterraneanShunningGroundsPoisonedStone = 35007350,

        [Display(Name = "[Subterranean Shunning-Grounds] Freezing Grease 35007370")]
        SubterraneanShunningGroundsFreezingGrease = 35007370,

        [Display(Name = "[Subterranean Shunning-Grounds] Serpent Arrow 35007380")]
        SubterraneanShunningGroundsSerpentArrow = 35007380,

        [Display(Name = "[Subterranean Shunning-Grounds] Fire Grease 35007390")]
        SubterraneanShunningGroundsFireGrease_ = 35007390,

        [Display(Name = "[Subterranean Shunning-Grounds] Somber Smithing Stone [6] 35007400")]
        SubterraneanShunningGroundsSomberSmithingStone6 = 35007400,

        [Display(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007410")]
        SubterraneanShunningGroundsSmithingStone7__ = 35007410,

        [Display(Name = "[Subterranean Shunning-Grounds] [Incantation] Shadow Bait 35007420")]
        SubterraneanShunningGroundsIncantationShadowBait = 35007420,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [10] 35007430")]
        SubterraneanShunningGroundsGoldenRune10 = 35007430,

        [Display(Name = "[Subterranean Shunning-Grounds] Somber Smithing Stone [7] 35007450")]
        SubterraneanShunningGroundsSomberSmithingStone7 = 35007450,

        [Display(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007460")]
        SubterraneanShunningGroundsSmithingStone7___ = 35007460,

        [Display(Name = "[Subterranean Shunning-Grounds] Glass Shard 35007470")]
        SubterraneanShunningGroundsGlassShard____ = 35007470,

        [Display(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007480")]
        SubterraneanShunningGroundsSmithingStone7____ = 35007480,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [9] 35007500")]
        SubterraneanShunningGroundsGoldenRune9 = 35007500,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [11] 35007510")]
        SubterraneanShunningGroundsGoldenRune11__ = 35007510,

        [Display(Name = "[Subterranean Shunning-Grounds] Warming Stone 35007530")]
        SubterraneanShunningGroundsWarmingStone = 35007530,

        [Display(Name = "[Subterranean Shunning-Grounds] Smithing Stone [8] 35007540")]
        SubterraneanShunningGroundsSmithingStone8 = 35007540,

        [Display(Name = "[Subterranean Shunning-Grounds] Eye of Yelough 35007550")]
        SubterraneanShunningGroundsEyeOfYelough_ = 35007550,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [8] 35007560")]
        SubterraneanShunningGroundsGoldenRune8 = 35007560,

        [Display(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007570")]
        SubterraneanShunningGroundsSmithingStone7_____ = 35007570,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [1] 35007580")]
        SubterraneanShunningGroundsGoldenRune1__ = 35007580,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [11] 35007590")]
        SubterraneanShunningGroundsGoldenRune11___ = 35007590,

        [Display(Name = "[Subterranean Shunning-Grounds] Smithing Stone [5] 35007600")]
        SubterraneanShunningGroundsSmithingStone5 = 35007600,

        [Display(Name = "[Subterranean Shunning-Grounds] Ritual Pot 66490")]
        SubterraneanShunningGroundsRitualPot = 66490,

        [Display(Name = "[Subterranean Shunning-Grounds] Smithing Stone [6] 35007630")]
        SubterraneanShunningGroundsSmithingStone6 = 35007630,

        [Display(Name = "[Subterranean Shunning-Grounds] Grace Mimic 35007650")]
        SubterraneanShunningGroundsGraceMimic_ = 35007650,

        [Display(Name = "[Subterranean Shunning-Grounds] Golden Rune [11] 35007660")]
        SubterraneanShunningGroundsGoldenRune11____ = 35007660,

        [Display(Name = "[Subterranean Shunning-Grounds] Hefty Beast Bone 35007670")]
        SubterraneanShunningGroundsHeftyBeastBone = 35007670,

        [Display(Name = "[Subterranean Shunning-Grounds] [Incantation] Inescapable Frenzy 35007680")]
        SubterraneanShunningGroundsIncantationInescapableFrenzy = 35007680,

        [Display(Name = "[Subterranean Shunning-Grounds] Erdtree's Favor +1 35007700")]
        SubterraneanShunningGroundsErdtreesFavor1 = 35007700,

        [Display(Name = "[Subterranean Shunning-Grounds] Nomadic Merchant's Chapeau 35007710")]
        SubterraneanShunningGroundsNomadicMerchantsChapeau = 35007710,

        [Display(Name = "[Subterranean Shunning-Grounds] Fingerprint Stone Shield 35007720")]
        SubterraneanShunningGroundsFingerprintStoneShield = 35007720,

        [Display(Name = "[Subterranean Shunning-Grounds] Warming Stone 35007730")]
        SubterraneanShunningGroundsWarmingStone_ = 35007730,

        [Display(Name = "[Subterranean Shunning-Grounds] Poisoned Stone 35007740")]
        SubterraneanShunningGroundsPoisonedStone_ = 35007740,

        [Display(Name = "[Subterranean Shunning-Grounds] Smithing Stone [1] 35007750")]
        SubterraneanShunningGroundsSmithingStone1 = 35007750,

        [Display(Name = "[Subterranean Shunning-Grounds] Fire Longsword 35007770")]
        SubterraneanShunningGroundsFireLongsword = 35007770,

        [Display(Name = "[Subterranean Shunning-Grounds] Rune Arc 35007780")]
        SubterraneanShunningGroundsRuneArc_ = 35007780,

        [Display(Name = "[Subterranean Shunning-Grounds] Frenzied's Cookbook [2] 68410")]
        SubterraneanShunningGroundsFrenziedsCookbook2 = 68410,

        [Display(Name = "[Subterranean Shunning-Grounds] Ghost Glovewort [6] 35007900")]
        SubterraneanShunningGroundsGhostGlovewort6 = 35007900,

        [Display(Name = "[Subterranean Shunning-Grounds] Root Resin 35007910")]
        SubterraneanShunningGroundsRootResin = 35007910,

        [Display(Name = "[Subterranean Shunning-Grounds] Mushroom 35007920")]
        SubterraneanShunningGroundsMushroom = 35007920,

        [Display(Name = "[Subterranean Shunning-Grounds] Sacramental Bud 35007930")]
        SubterraneanShunningGroundsSacramentalBud = 35007930,

        [Display(Name = "[Subterranean Shunning-Grounds] Crucible Scale Talisman 35007940")]
        SubterraneanShunningGroundsCrucibleScaleTalisman = 35007940,

        [Display(Name = "[Subterranean Shunning-Grounds] Haligdrake Talisman +1 35007950")]
        SubterraneanShunningGroundsHaligdrakeTalisman1 = 35007950,

        [Display(Name = "[Subterranean Shunning-Grounds] Rune Arc 35007960")]
        SubterraneanShunningGroundsRuneArc__ = 35007960,

        [Display(Name = "[Subterranean Shunning-Grounds] Somber Smithing Stone [6] 35007970")]
        SubterraneanShunningGroundsSomberSmithingStone6_ = 35007970,

        [Display(Name = "[Subterranean Shunning-Grounds] Somber Smithing Stone [7] 35007980")]
        SubterraneanShunningGroundsSomberSmithingStone7_ = 35007980,

        [Display(Name = "[Ruin-Strewn Precipice] Golden Rune [1] 39207000")]
        RuinStrewnPrecipiceGoldenRune1 = 39207000,

        [Display(Name = "[Ruin-Strewn Precipice] Smithing Stone [5] 39207010")]
        RuinStrewnPrecipiceSmithingStone5 = 39207010,

        [Display(Name = "[Ruin-Strewn Precipice] Rune Arc 39207020")]
        RuinStrewnPrecipiceRuneArc = 39207020,

        [Display(Name = "[Ruin-Strewn Precipice] Somber Smithing Stone [3] 39207030")]
        RuinStrewnPrecipiceSomberSmithingStone3 = 39207030,

        [Display(Name = "[Ruin-Strewn Precipice] Serpent-God's Curved Sword 39207040")]
        RuinStrewnPrecipiceSerpentGodsCurvedSword = 39207040,

        [Display(Name = "[Ruin-Strewn Precipice] Smithing Stone [4] 39207050")]
        RuinStrewnPrecipiceSmithingStone4 = 39207050,

        [Display(Name = "[Ruin-Strewn Precipice] Golden Rune [4] 39207060")]
        RuinStrewnPrecipiceGoldenRune4 = 39207060,

        [Display(Name = "[Ruin-Strewn Precipice] Golden Rune [5] 39207070")]
        RuinStrewnPrecipiceGoldenRune5 = 39207070,

        [Display(Name = "[Ruin-Strewn Precipice] Rune Arc 39207080")]
        RuinStrewnPrecipiceRuneArc_ = 39207080,

        [Display(Name = "[Ruin-Strewn Precipice] Soft Cotton 39207090")]
        RuinStrewnPrecipiceSoftCotton = 39207090,

        [Display(Name = "[Ruin-Strewn Precipice] Golden Rune [5] 39207100")]
        RuinStrewnPrecipiceGoldenRune5_ = 39207100,

        [Display(Name = "[Ruin-Strewn Precipice] Golden Rune [5] 39207110")]
        RuinStrewnPrecipiceGoldenRune5__ = 39207110,

        [Display(Name = "[Ruin-Strewn Precipice] Lost Ashes of War 39207120")]
        RuinStrewnPrecipiceLostAshesOfWar = 39207120,

        [Display(Name = "[Ruin-Strewn Precipice] Smithing Stone [3] 39207130")]
        RuinStrewnPrecipiceSmithingStone3 = 39207130,

        [Display(Name = "[Ruin-Strewn Precipice] Smithing Stone [3] 39207140")]
        RuinStrewnPrecipiceSmithingStone3_ = 39207140,

        [Display(Name = "[Ruin-Strewn Precipice] Smithing Stone [3] 39207150")]
        RuinStrewnPrecipiceSmithingStone3__ = 39207150,

        [Display(Name = "[Ruin-Strewn Precipice] Lightning Grease 39207160")]
        RuinStrewnPrecipiceLightningGrease = 39207160,

        [Display(Name = "[Ruin-Strewn Precipice] Sacred Tear 39207170")]
        RuinStrewnPrecipiceSacredTear = 39207170,

        [Display(Name = "[Ruin-Strewn Precipice] Smithing Stone [1] 39207200")]
        RuinStrewnPrecipiceSmithingStone1 = 39207200,

        [Display(Name = "[Ruin-Strewn Precipice] Bull-Goat Helm 39207500")]
        RuinStrewnPrecipiceBullGoatHelm = 39207500,

        [Display(Name = "Golden Rune [1] 99017000")]
        GoldenRune1_____________________ = 99017000,

        [Display(Name = "Cracked Pot 99997020")]
        CrackedPot = 99997020,

        [Display(Name = "Perfume Bottle 99997030")]
        PerfumeBottle = 99997030,

        [Display(Name = "Veteran's Helm 59930000")]
        VeteransHelm = 59930000,

        [Display(Name = "Soft Cotton 59931000")]
        SoftCotton = 59931000,

        [Display(Name = "[Limgrave - Mistwood] Spiked Cracked Tear 65140")]
        LimgraveMistwoodSpikedCrackedTear = 65140,

        [Display(Name = "[Limgrave - Mistwood] Greenspill Crystal Tear 65010")]
        LimgraveMistwoodGreenspillCrystalTear = 65010,

        [Display(Name = "[Limgrave - Third Church of Marika] Flask of Wondrous Physick 60020")]
        LimgraveThirdChurchOfMarikaFlaskOfWondrousPhysick = 60020,

        [Display(Name = "[Limgrave - Third Church of Marika] Crimson Crystal Tear 65020")]
        LimgraveThirdChurchOfMarikaCrimsonCrystalTear = 65020,

        [Display(Name = "[Limgrave - Third Church of Marika] Sacred Tear 1046387100")]
        LimgraveThirdChurchOfMarikaSacredTear = 1046387100,

        [Display(Name = "[Weeping Peninsula - Fourth Church of Marika] Sacred Tear 1041337200")]
        WeepingPeninsulaFourthChurchOfMarikaSacredTear = 1041337200,

        [Display(Name = "[Limgrave - Seaside Ruins] Sacred Tear 1043357100")]
        LimgraveSeasideRuinsSacredTear = 1043357100,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] Sacred Tear 1044337100")]
        WeepingPeninsulaAilingVillageOutskirtsSacredTear = 1044337100,

        [Display(Name = "[Stormhill - Stormhill Shack] Golden Seed 1041387100")]
        StormhillStormhillShackGoldenSeed = 1041387100,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Golden Seed 1044327020")]
        WeepingPeninsulaCastleMorneApproachGoldenSeed = 1044327020,

        [Display(Name = "[Limgrave - Fort Haight] Golden Seed 1046367100")]
        LimgraveFortHaightGoldenSeed = 1046367100,

        [Display(Name = "[Limgrave - Agheel Lake North] Ash of War: Repeating Thrust 1043377400")]
        LimgraveAgheelLakeNorthAshOfWarRepeatingThrust = 1043377400,

        [Display(Name = "[Stormhill - Warmaster's Shack] Blue-Feathered Branchsword 1042387400")]
        StormhillWarmastersShackBlueFeatheredBranchsword = 1042387400,

        [Display(Name = "[Stormhill - Warmaster's Shack] Bone Peddler's Bell Bearing 1042387410")]
        StormhillWarmastersShackBonePeddlersBellBearing = 1042387410,

        [Display(Name = "[Stormhill - Forested West Cliffside] Smithing Stone [1] 1040387000")]
        StormhillForestedWestCliffsideSmithingStone1 = 1040387000,

        [Display(Name = "[Stormhill - Forested West Cliffside] Nomadic Warrior's Cookbook [7] 67050")]
        StormhillForestedWestCliffsideNomadicWarriorsCookbook7 = 67050,

        [Display(Name = "[Limgrave - Church of Dragon Communion] Great Dragonfly Head 1041357000")]
        LimgraveChurchOfDragonCommunionGreatDragonflyHead = 1041357000,

        [Display(Name = "[Limgrave - Church of Dragon Communion] Smithing Stone [2] 1041357010")]
        LimgraveChurchOfDragonCommunionSmithingStone2 = 1041357010,

        [Display(Name = "[Limgrave - Church of Dragon Communion] Exalted Flesh 1041357020")]
        LimgraveChurchOfDragonCommunionExaltedFlesh = 1041357020,

        [Display(Name = "[Limgrave - Coastal Cave Entrance] Land Octopus Ovary 1041367000")]
        LimgraveCoastalCaveEntranceLandOctopusOvary = 1041367000,

        [Display(Name = "[Limgrave - Stormfoot Catacombs Entrance] Strip of White Flesh 1041377000")]
        LimgraveStormfootCatacombsEntranceStripOfWhiteFlesh = 1041377000,

        [Display(Name = "[Limgrave - Stormfoot Catacombs Entrance] Starlight Shards 1041377020")]
        LimgraveStormfootCatacombsEntranceStarlightShards = 1041377020,

        [Display(Name = "[Stormhill - Stormhill Shack] Magic Grease 1041387010")]
        StormhillStormhillShackMagicGrease = 1041387010,

        [Display(Name = "[Stormhill - Stormhill Shack] Smithing Stone [1] 1041387030")]
        StormhillStormhillShackSmithingStone1 = 1041387030,

        [Display(Name = "[Stormhill - Stormhill Shack] Stonesword Key 1041387040")]
        StormhillStormhillShackStoneswordKey = 1041387040,

        [Display(Name = "[Stormhill - Stormhill Shack] Godrick Soldier Ashes 1041387050")]
        StormhillStormhillShackGodrickSoldierAshes = 1041387050,

        [Display(Name = "[Stormhill - Stormhill Shack] Bloodrose 1041387200")]
        StormhillStormhillShackBloodrose = 1041387200,

        [Display(Name = "[Stormhill - North of Stormhill Shack] Lump of Flesh 1041397000")]
        StormhillNorthOfStormhillShackLumpOfFlesh = 1041397000,

        [Display(Name = "[Stormhill - Northwest Cliffside] Duelist's Furled Finger 60240")]
        StormhillNorthwestCliffsideDuelistsFurledFinger = 60240,

        [Display(Name = "[Stormhill - Northwest Cliffside] Small Red Effigy 60250")]
        StormhillNorthwestCliffsideSmallRedEffigy = 60250,

        [Display(Name = "[Limgrave - South of Stranded Graveyard] Gold-Pickled Fowl Foot 1042357010")]
        LimgraveSouthOfStrandedGraveyardGoldPickledFowlFoot = 1042357010,

        [Display(Name = "[Limgrave - South of Stranded Graveyard] Lump of Flesh 1042357000")]
        LimgraveSouthOfStrandedGraveyardLumpOfFlesh = 1042357000,

        [Display(Name = "[Limgrave - Church of Elleh] Silver-Pickled Fowl Foot 1042367010")]
        LimgraveChurchOfEllehSilverPickledFowlFoot = 1042367010,

        [Display(Name = "[Limgrave - Church of Elleh] Golden Rune [2] 1042367030")]
        LimgraveChurchOfEllehGoldenRune2 = 1042367030,

        [Display(Name = "[Limgrave - Church of Elleh] Golden Rune [1] 1042367040")]
        LimgraveChurchOfEllehGoldenRune1 = 1042367040,

        [Display(Name = "[Limgrave - Church of Elleh] Smithing Stone [1] 1042367050")]
        LimgraveChurchOfEllehSmithingStone1 = 1042367050,

        [Display(Name = "[Limgrave - Church of Elleh] Smithing Stone [1] 1042367060")]
        LimgraveChurchOfEllehSmithingStone1_ = 1042367060,

        [Display(Name = "[Limgrave - Gatefront] Ruin Fragment 1042377000")]
        LimgraveGatefrontRuinFragment = 1042377000,

        [Display(Name = "[Troll Carriage - Gatefront Ruins] Flail 1042377060")]
        TrollCarriageGatefrontRuinsFlail = 1042377060,

        [Display(Name = "[Troll Carriage - Gatefront Ruins] Lordsworn's Greatsword 1042377070")]
        TrollCarriageGatefrontRuinsLordswornsGreatsword = 1042377070,

        [Display(Name = "[Limgrave - Gatefront] Whetstone Knife 60130")]
        LimgraveGatefrontWhetstoneKnife = 60130,

        [Display(Name = "[Limgrave - Gatefront] Ash of War: Storm Stomp 1042377110")]
        LimgraveGatefrontAshOfWarStormStomp = 1042377110,

        [Display(Name = "[Limgrave - Gatefront] Kukri 1042377010")]
        LimgraveGatefrontKukri = 1042377010,

        [Display(Name = "[Limgrave - Gatefront] Arrow's Reach Talisman 1042377300")]
        LimgraveGatefrontArrowsReachTalisman = 1042377300,

        [Display(Name = "[Limgrave - Gatefront] Assassin's Crimson Dagger 1042377100")]
        LimgraveGatefrontAssassinsCrimsonDagger = 1042377100,

        [Display(Name = "[Stormhill - Warmaster's Shack] Beast Liver 1042387000")]
        StormhillWarmastersShackBeastLiver = 1042387000,

        [Display(Name = "[Stormhill - Warmaster's Shack] Golden Rune [1] 1042387010")]
        StormhillWarmastersShackGoldenRune1 = 1042387010,

        [Display(Name = "[Stormhill - Warmaster's Shack] Fire Arrow 1042387020")]
        StormhillWarmastersShackFireArrow = 1042387020,

        [Display(Name = "[Stormhill - Warmaster's Shack] Golden Rune [5] 1042387030")]
        StormhillWarmastersShackGoldenRune5 = 1042387030,

        [Display(Name = "[Stormhill - Warmaster's Shack] Golden Rune [1] 1042387040")]
        StormhillWarmastersShackGoldenRune1_ = 1042387040,

        [Display(Name = "[Stormhill - Warmaster's Shack] Golden Rune [3] 1042387050")]
        StormhillWarmastersShackGoldenRune3 = 1042387050,

        [Display(Name = "[Stormhill - Warmaster's Shack] Golden Rune [2] 1042387070")]
        StormhillWarmastersShackGoldenRune2 = 1042387070,

        [Display(Name = "[Stormhill - Warmaster's Shack] Golden Rune [1] 1042387080")]
        StormhillWarmastersShackGoldenRune1__ = 1042387080,

        [Display(Name = "[Stormhill - Warmaster's Shack] Golden Rune [2] 1042387090")]
        StormhillWarmastersShackGoldenRune2_ = 1042387090,

        [Display(Name = "[Stormhill - Warmaster's Shack] Golden Rune [1] 1042387100")]
        StormhillWarmastersShackGoldenRune1___ = 1042387100,

        [Display(Name = "[Stormhill - Warmaster's Shack] Golden Rune [1] 1042387110")]
        StormhillWarmastersShackGoldenRune1____ = 1042387110,

        [Display(Name = "[Stormhill - Warmaster's Shack] Golden Rune [2] 1042387120")]
        StormhillWarmastersShackGoldenRune2__ = 1042387120,

        [Display(Name = "[Stormhill - Warmaster's Shack] Lump of Flesh 1042387140")]
        StormhillWarmastersShackLumpOfFlesh = 1042387140,

        [Display(Name = "[Stormhill - Warmaster's Shack] Smithing Stone [1] 1042387600")]
        StormhillWarmastersShackSmithingStone1 = 1042387600,

        [Display(Name = "[Stormhill - Warmaster's Shack] Smoldering Butterfly 1042387200")]
        StormhillWarmastersShackSmolderingButterfly = 1042387200,

        [Display(Name = "[Stormhill - North of Warmaster's Shack] Strength-knot Crystal Tear 65210")]
        StormhillNorthOfWarmastersShackStrengthknotCrystalTear = 65210,

        [Display(Name = "[Stormhill - North of Warmaster's Shack] Lance 1042397010")]
        StormhillNorthOfWarmastersShackLance = 1042397010,

        [Display(Name = "[Stormhill - North of Warmaster's Shack] Beast Crest Heater Shield 1042397900")]
        StormhillNorthOfWarmastersShackBeastCrestHeaterShield = 1042397900,

        [Display(Name = "[Stormhill - North of Warmaster's Shack] Scaled Helm 1042397500")]
        StormhillNorthOfWarmastersShackScaledHelm = 1042397500,

        [Display(Name = "[Stormhill - North of Warmaster's Shack] Hammer Talisman 1042397700")]
        StormhillNorthOfWarmastersShackHammerTalisman = 1042397700,

        [Display(Name = "[Limgrave - Seaside Ruins] Crab Eggs 1043357000")]
        LimgraveSeasideRuinsCrabEggs = 1043357000,

        [Display(Name = "[Limgrave - Seaside Ruins] Golden Rune [1] 1043357010")]
        LimgraveSeasideRuinsGoldenRune1 = 1043357010,

        [Display(Name = "[Limgrave - Seaside Ruins] Slumbering Egg 1043357030")]
        LimgraveSeasideRuinsSlumberingEgg = 1043357030,

        [Display(Name = "[Limgrave - Dragon-Burnt Ruins] Stonesword Key 1043367010")]
        LimgraveDragonBurntRuinsStoneswordKey = 1043367010,

        [Display(Name = "[Limgrave - Dragon-Burnt Ruins] Golden Rune [2] 1043367020")]
        LimgraveDragonBurntRuinsGoldenRune2 = 1043367020,

        [Display(Name = "[Limgrave - Dragon-Burnt Ruins] Crab Eggs 1043367040")]
        LimgraveDragonBurntRuinsCrabEggs = 1043367040,

        [Display(Name = "[Limgrave - Dragon-Burnt Ruins] Twinblade 1043367110")]
        LimgraveDragonBurntRuinsTwinblade = 1043367110,

        [Display(Name = "[Limgrave - Dragon-Burnt Ruins] Arteria Leaf 1043367070")]
        LimgraveDragonBurntRuinsArteriaLeaf = 1043367070,

        [Display(Name = "[Limgrave - Agheel Lake North] Smithing Stone [1] 1043377000")]
        LimgraveAgheelLakeNorthSmithingStone1 = 1043377000,

        [Display(Name = "[Limgrave - Agheel Lake North] Fire Grease 1043377010")]
        LimgraveAgheelLakeNorthFireGrease = 1043377010,

        [Display(Name = "[Limgrave - Agheel Lake North] Arteria Leaf 1043377020")]
        LimgraveAgheelLakeNorthArteriaLeaf = 1043377020,

        [Display(Name = "[Limgrave - Gatefront] Map: Limgrave, West 62010")]
        LimgraveGatefrontMapLimgraveWest = 62010,

        [Display(Name = "[Limgrave - Gatefront] Reduvia 1042377700")]
        LimgraveGatefrontReduvia = 1042377700,

        [Display(Name = "[Limgrave - Murkwater Coast] Armorer's Cookbook [1] 67200")]
        LimgraveMurkwaterCoastArmorersCookbook1 = 67200,

        [Display(Name = "[Limgrave - Murkwater Coast] Smithing Stone [1] 1043387010")]
        LimgraveMurkwaterCoastSmithingStone1 = 1043387010,

        [Display(Name = "[Limgrave - Murkwater Coast] Golden Rune [2] 1043387020")]
        LimgraveMurkwaterCoastGoldenRune2 = 1043387020,

        [Display(Name = "[Stormhill - Saintsbridge] Exalted Flesh 1043397010")]
        StormhillSaintsbridgeExaltedFlesh = 1043397010,

        [Display(Name = "[Stormhill - Saintsbridge] Smithing Stone [1] 1043397020")]
        StormhillSaintsbridgeSmithingStone1 = 1043397020,

        [Display(Name = "[Stormhill - Saintsbridge] Golden Rune [3] 1043397200")]
        StormhillSaintsbridgeGoldenRune3 = 1043397200,

        [Display(Name = "[Stormhill - Saintsbridge] Turtle Neck Meat 1043397030")]
        StormhillSaintsbridgeTurtleNeckMeat = 1043397030,

        [Display(Name = "[Stormhill - Northeast Cliffside] Soporific Grease 1043407000")]
        StormhillNortheastCliffsideSoporificGrease = 1043407000,

        [Display(Name = "[Stormhill - Northeast Cliffside] Lance Talisman 1043407010")]
        StormhillNortheastCliffsideLanceTalisman = 1043407010,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Map: Weeping Peninsula 62011")]
        WeepingPeninsulaCastleMorneApproachMapWeepingPeninsula = 62011,

        [Display(Name = "[Weeping Peninsula - Bridge of Sacrifice] Stonesword Key 1044347000")]
        WeepingPeninsulaBridgeOfSacrificeStoneswordKey = 1044347000,

        [Display(Name = "[Weeping Peninsula - Bridge of Sacrifice] Smithing Stone [1] 1044347010")]
        WeepingPeninsulaBridgeOfSacrificeSmithingStone1 = 1044347010,

        [Display(Name = "[Weeping Peninsula - Bridge of Sacrifice] Ruin Fragment 1044347050")]
        WeepingPeninsulaBridgeOfSacrificeRuinFragment = 1044347050,

        [Display(Name = "[Weeping Peninsula - Bridge of Sacrifice] Large Club 1044347080")]
        WeepingPeninsulaBridgeOfSacrificeLargeClub = 1044347080,

        [Display(Name = "[Limgrave - Agheel Lake South] Golden Rune [2] 1044357000")]
        LimgraveAgheelLakeSouthGoldenRune2 = 1044357000,

        [Display(Name = "[Limgrave - Agheel Lake South] Royal House Scroll 1044357010")]
        LimgraveAgheelLakeSouthRoyalHouseScroll = 1044357010,

        [Display(Name = "[Limgrave - Agheel Lake South] Golden Rune [1] 1044357020")]
        LimgraveAgheelLakeSouthGoldenRune1 = 1044357020,

        [Display(Name = "[Limgrave - Agheel Lake South] Sliver of Meat 1044357030")]
        LimgraveAgheelLakeSouthSliverOfMeat = 1044357030,

        [Display(Name = "Flame Sling 1044357050")]
        FlameSling = 1044357050,

        [Display(Name = "[Limgrave - Agheel Lake South] Crab Eggs 1044357040")]
        LimgraveAgheelLakeSouthCrabEggs = 1044357040,

        [Display(Name = "[Limgrave - Agheel Lake South] Golden Rune [1] 1044357060")]
        LimgraveAgheelLakeSouthGoldenRune1_ = 1044357060,

        [Display(Name = "[Limgrave - Agheel Lake South] Starlight Shards 1044357070")]
        LimgraveAgheelLakeSouthStarlightShards = 1044357070,

        [Display(Name = "[Limgrave - Agheel Lake South] Larval Tear 1044357100")]
        LimgraveAgheelLakeSouthLarvalTear = 1044357100,

        [Display(Name = "[Limgrave - Agheel Lake South] Great epee 1044357900")]
        LimgraveAgheelLakeSouthGreatepee = 1044357900,

        [Display(Name = "[Limgrave - Waypoint Ruins] Glowstone 1044367000")]
        LimgraveWaypointRuinsGlowstone = 1044367000,

        [Display(Name = "[Limgrave - Waypoint Ruins] Golden Rune [1] 1044367010")]
        LimgraveWaypointRuinsGoldenRune1 = 1044367010,

        [Display(Name = "[Limgrave - Waypoint Ruins] Immunizing Cured Meat 1044367020")]
        LimgraveWaypointRuinsImmunizingCuredMeat = 1044367020,

        [Display(Name = "[Limgrave - Waypoint Ruins] Trina's Lily 1044367100")]
        LimgraveWaypointRuinsTrinasLily = 1044367100,

        [Display(Name = "[Limgrave - Waypoint Ruins] Smoldering Butterfly 1044367030")]
        LimgraveWaypointRuinsSmolderingButterfly = 1044367030,

        [Display(Name = "[Limgrave - Waypoint Ruins] Somber Smithing Stone [1] 1044367040")]
        LimgraveWaypointRuinsSomberSmithingStone1 = 1044367040,

        [Display(Name = "[Troll Carriage - Waypoint Ruins] Greataxe 1044367200")]
        TrollCarriageWaypointRuinsGreataxe = 1044367200,

        [Display(Name = "[Limgrave - Waypoint Ruins] Golden Rune [1] 1044367300")]
        LimgraveWaypointRuinsGoldenRune1_ = 1044367300,

        [Display(Name = "[Limgrave - Waypoint Ruins] Golden Rune [1] 1044367310")]
        LimgraveWaypointRuinsGoldenRune1__ = 1044367310,

        [Display(Name = "[Limgrave - Waypoint Ruins] Golden Rune [2] 1044367320")]
        LimgraveWaypointRuinsGoldenRune2 = 1044367320,

        [Display(Name = "[Limgrave - Waypoint Ruins] Golden Rune [1] 1044367330")]
        LimgraveWaypointRuinsGoldenRune1___ = 1044367330,

        [Display(Name = "[Limgrave - Waypoint Ruins] Golden Rune [3] 1044367340")]
        LimgraveWaypointRuinsGoldenRune3 = 1044367340,

        [Display(Name = "[Limgrave - Mistwood Outskirts] Golden Rune [1] 1044377010")]
        LimgraveMistwoodOutskirtsGoldenRune1 = 1044377010,

        [Display(Name = "[Limgrave - Mistwood Outskirts] Gold-Pickled Fowl Foot 1044377200")]
        LimgraveMistwoodOutskirtsGoldPickledFowlFoot = 1044377200,

        [Display(Name = "[Limgrave - Mistwood Outskirts] Sacrificial Twig 1044377020")]
        LimgraveMistwoodOutskirtsSacrificialTwig = 1044377020,

        [Display(Name = "[Limgrave - Artist's Shack] Smithing Stone [1] 1044387010")]
        LimgraveArtistsShackSmithingStone1 = 1044387010,

        [Display(Name = "[Limgrave - Artist's Shack] Poisonbloom 1044387040")]
        LimgraveArtistsShackPoisonbloom = 1044387040,

        [Display(Name = "[Limgrave - Artist's Shack] Golden Rune [1] 1044387100")]
        LimgraveArtistsShackGoldenRune1 = 1044387100,

        [Display(Name = "[Leyndell - Minor Erdtree] 1045337400")]
        LeyndellMinorErdtree = 1045337400,

        [Display(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [1] 1045357000")]
        LimgraveSouthwestOfFortHaightGoldenRune1 = 1045357000,

        [Display(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [1] 1045357020")]
        LimgraveSouthwestOfFortHaightGoldenRune1_ = 1045357020,

        [Display(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [4] 1045357030")]
        LimgraveSouthwestOfFortHaightGoldenRune4 = 1045357030,

        [Display(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [3] 1045357040")]
        LimgraveSouthwestOfFortHaightGoldenRune3 = 1045357040,

        [Display(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [2] 1045357050")]
        LimgraveSouthwestOfFortHaightGoldenRune2 = 1045357050,

        [Display(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [1] 1045357060")]
        LimgraveSouthwestOfFortHaightGoldenRune1__ = 1045357060,

        [Display(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [2] 1045357070")]
        LimgraveSouthwestOfFortHaightGoldenRune2_ = 1045357070,

        [Display(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [1] 1045357080")]
        LimgraveSouthwestOfFortHaightGoldenRune1___ = 1045357080,

        [Display(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [1] 1045357090")]
        LimgraveSouthwestOfFortHaightGoldenRune1____ = 1045357090,

        [Display(Name = "[Limgrave - Mistwood] Golden Rune [2] 1045377000")]
        LimgraveMistwoodGoldenRune2 = 1045377000,

        [Display(Name = "[Limgrave - Mistwood] Smithing Stone [2] 1045377010")]
        LimgraveMistwoodSmithingStone2 = 1045377010,

        [Display(Name = "[Limgrave - Mistwood] Map: Limgrave, East 62012")]
        LimgraveMistwoodMapLimgraveEast = 62012,

        [Display(Name = "[Limgrave - Mistwood] Nomadic Warrior's Cookbook [4] 67800")]
        LimgraveMistwoodNomadicWarriorsCookbook4 = 67800,

        [Display(Name = "[Limgrave - Mistwood] Axe Talisman 1045377100")]
        LimgraveMistwoodAxeTalisman = 1045377100,

        [Display(Name = "[Limgrave - Mistwood] Golden Rune [1] 1045377050")]
        LimgraveMistwoodGoldenRune1 = 1045377050,

        [Display(Name = "[Limgrave - Mistwood] Thin Beast Bones 1045377060")]
        LimgraveMistwoodThinBeastBones = 1045377060,

        [Display(Name = "[Limgrave - Mistwood] Gold-Tinged Excrement 1045377070")]
        LimgraveMistwoodGoldTingedExcrement = 1045377070,

        [Display(Name = "[Limgrave - Mistwood] Throwing Dagger 1045377080")]
        LimgraveMistwoodThrowingDagger = 1045377080,

        [Display(Name = "[Limgrave - Mistwood] Golden Rune [5] 1045377090")]
        LimgraveMistwoodGoldenRune5 = 1045377090,

        [Display(Name = "[Limgrave - South of Summonwater Village] Magic Grease 1045387000")]
        LimgraveSouthOfSummonwaterVillageMagicGrease = 1045387000,

        [Display(Name = "[Limgrave - South of Summonwater Village] Fevor's Cookbook [1] 68200")]
        LimgraveSouthOfSummonwaterVillageFevorsCookbook1 = 68200,

        [Display(Name = "[Limgrave - South of Summonwater Village] Golden Rune [1] 1045387020")]
        LimgraveSouthOfSummonwaterVillageGoldenRune1 = 1045387020,

        [Display(Name = "[Limgrave - South of Summonwater Village] Golden Rune [1] 1045387030")]
        LimgraveSouthOfSummonwaterVillageGoldenRune1_ = 1045387030,

        [Display(Name = "[Limgrave - South of Summonwater Village] Golden Rune [1] 1045387040")]
        LimgraveSouthOfSummonwaterVillageGoldenRune1__ = 1045387040,

        [Display(Name = "[Limgrave - South of Summonwater Village] Golden Rune [2] 1045387050")]
        LimgraveSouthOfSummonwaterVillageGoldenRune2 = 1045387050,

        [Display(Name = "[Limgrave - South of Summonwater Village] Golden Rune [4] 1045387060")]
        LimgraveSouthOfSummonwaterVillageGoldenRune4 = 1045387060,

        [Display(Name = "[Limgrave - South of Summonwater Village] Golden Rune [4] 1045387070")]
        LimgraveSouthOfSummonwaterVillageGoldenRune4_ = 1045387070,

        [Display(Name = "[Limgrave - South of Summonwater Village] Golden Rune [6] 1045387080")]
        LimgraveSouthOfSummonwaterVillageGoldenRune6 = 1045387080,

        [Display(Name = "[Limgrave - Summonwater Village] Golden Rune [4] 1045397000")]
        LimgraveSummonwaterVillageGoldenRune4 = 1045397000,

        [Display(Name = "[Limgrave - Summonwater Village] Mushroom 1045397020")]
        LimgraveSummonwaterVillageMushroom = 1045397020,

        [Display(Name = "[Limgrave - Summonwater Village] Smithing Stone [1] 1045397140")]
        LimgraveSummonwaterVillageSmithingStone1 = 1045397140,

        [Display(Name = "[Limgrave - Summonwater Village] Green Turtle Talisman 1045397120")]
        LimgraveSummonwaterVillageGreenTurtleTalisman = 1045397120,

        [Display(Name = "[Limgrave - Summonwater Village] Smithing Stone [2] 1045397040")]
        LimgraveSummonwaterVillageSmithingStone2 = 1045397040,

        [Display(Name = "[Limgrave - Summonwater Village] Golden Rune [1] 1045397050")]
        LimgraveSummonwaterVillageGoldenRune1 = 1045397050,

        [Display(Name = "[Limgrave - Summonwater Village] Golden Rune [1] 1045397060")]
        LimgraveSummonwaterVillageGoldenRune1_ = 1045397060,

        [Display(Name = "[Limgrave - Summonwater Village] Golden Rune [1] 1045397070")]
        LimgraveSummonwaterVillageGoldenRune1__ = 1045397070,

        [Display(Name = "[Limgrave - Summonwater Village] Golden Rune [1] 1045397080")]
        LimgraveSummonwaterVillageGoldenRune1___ = 1045397080,

        [Display(Name = "[Limgrave - Summonwater Village] Golden Rune [5] 1045397090")]
        LimgraveSummonwaterVillageGoldenRune5 = 1045397090,

        [Display(Name = "[Limgrave - Summonwater Village] Golden Rune [2] 1045397100")]
        LimgraveSummonwaterVillageGoldenRune2 = 1045397100,

        [Display(Name = "[Limgrave - Summonwater Village] Golden Rune [1] 1045397110")]
        LimgraveSummonwaterVillageGoldenRune1____ = 1045397110,

        [Display(Name = "[Limgrave - Fort Haight] Smithing Stone [1] 1046367000")]
        LimgraveFortHaightSmithingStone1 = 1046367000,

        [Display(Name = "[Limgrave - Fort Haight] Bloodrose 1046367010")]
        LimgraveFortHaightBloodrose = 1046367010,

        [Display(Name = "[Limgrave - Fort Haight] Nomadic Warrior's Cookbook [6] 67020")]
        LimgraveFortHaightNomadicWarriorsCookbook6 = 67020,

        [Display(Name = "[Limgrave - Fort Haight] Bloodrose 1046367030")]
        LimgraveFortHaightBloodrose_ = 1046367030,

        [Display(Name = "[Limgrave - Fort Haight] Dectus Medallion (Left) 1046367500")]
        LimgraveFortHaightDectusMedallionLeft = 1046367500,

        [Display(Name = "[Limgrave - Fort Haight] Ash of War: Bloody Slash 1046367700")]
        LimgraveFortHaightAshOfWarBloodySlash = 1046367700,

        [Display(Name = "[Limgrave - East of Siofra River Well] Strip of White Flesh 1046377000")]
        LimgraveEastOfSiofraRiverWellStripOfWhiteFlesh = 1046377000,

        [Display(Name = "[Limgrave - Third Church of Marika] Neutralizing Boluses 1046387010")]
        LimgraveThirdChurchOfMarikaNeutralizingBoluses = 1046387010,

        [Display(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [1] 1041327000")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1 = 1041327000,

        [Display(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [1] 1041327010")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1_ = 1041327010,

        [Display(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [2] 1041327020")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune2 = 1041327020,

        [Display(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [1] 1041327030")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1__ = 1041327030,

        [Display(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [1] 1041327040")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1___ = 1041327040,

        [Display(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [3] 1041327050")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune3 = 1041327050,

        [Display(Name = "[Weeping Peninsula - Fourth Church of Marika] Golden Rune [1] 1041337000")]
        WeepingPeninsulaFourthChurchOfMarikaGoldenRune1 = 1041337000,

        [Display(Name = "[Weeping Peninsula - Fourth Church of Marika] Golden Rune [5] 1041337010")]
        WeepingPeninsulaFourthChurchOfMarikaGoldenRune5 = 1041337010,

        [Display(Name = "[Weeping Peninsula - Fourth Church of Marika] Great Dragonfly Head 1041337030")]
        WeepingPeninsulaFourthChurchOfMarikaGreatDragonflyHead = 1041337030,

        [Display(Name = "[Weeping Peninsula - Fourth Church of Marika] Ambush Shard 1041337100")]
        WeepingPeninsulaFourthChurchOfMarikaAmbushShard = 1041337100,

        [Display(Name = "[Weeping Peninsula - Tower of Return] Great Dragonfly Head 1042327000")]
        WeepingPeninsulaTowerOfReturnGreatDragonflyHead = 1042327000,

        [Display(Name = "[Weeping Peninsula - Tower of Return] Mushroom 1042327020")]
        WeepingPeninsulaTowerOfReturnMushroom = 1042327020,

        [Display(Name = "[Weeping Peninsula - Tower of Return] Composite Bow 1042327100")]
        WeepingPeninsulaTowerOfReturnCompositeBow = 1042327100,

        [Display(Name = "[Weeping Peninsula - Tombsward] Eclipse Crest Heater Shield 1042337000")]
        WeepingPeninsulaTombswardEclipseCrestHeaterShield = 1042337000,

        [Display(Name = "[Weeping Peninsula - Tombsward] Radagon's Scarseal 1042337100")]
        WeepingPeninsulaTombswardRadagonsScarseal = 1042337100,

        [Display(Name = "[Weeping Peninsula - Tombsward Ruins] Blood Grease 1042347000")]
        WeepingPeninsulaTombswardRuinsBloodGrease = 1042347000,

        [Display(Name = "[Limgrave - South of Stranded Graveyard] Sliver of Meat 1042357020")]
        LimgraveSouthOfStrandedGraveyardSliverOfMeat = 1042357020,

        [Display(Name = "[Limgrave - South of Stranded Graveyard] Bewitching Branch 1042357030")]
        LimgraveSouthOfStrandedGraveyardBewitchingBranch = 1042357030,

        [Display(Name = "[Weeping Peninsula - Tombsward Ruins] Beast Liver 1042347010")]
        WeepingPeninsulaTombswardRuinsBeastLiver = 1042347010,

        [Display(Name = "[Weeping Peninsula - Tombsward Ruins] Winged Scythe 1042347100")]
        WeepingPeninsulaTombswardRuinsWingedScythe = 1042347100,

        [Display(Name = "[Weeping Peninsula - Tombsward Ruins] Golden Rune [2] 1042347020")]
        WeepingPeninsulaTombswardRuinsGoldenRune2 = 1042347020,

        [Display(Name = "[Weeping Peninsula - Tombsward Ruins] Gilded Iron Shield 1042347030")]
        WeepingPeninsulaTombswardRuinsGildedIronShield = 1042347030,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Yellow Ember 1043327000")]
        WeepingPeninsulaCastleMorneApproachYellowEmber = 1043327000,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Sliver of Meat 1043327010")]
        WeepingPeninsulaCastleMorneApproachSliverOfMeat = 1043327010,

        [Display(Name = "[Weeping Peninsula - Minor Erdtree] Golden Rune [2] 1043337000")]
        WeepingPeninsulaMinorErdtreeGoldenRune2 = 1043337000,

        [Display(Name = "[Weeping Peninsula - Minor Erdtree] Golden Rune [2] 1043337010")]
        WeepingPeninsulaMinorErdtreeGoldenRune2_ = 1043337010,

        [Display(Name = "[Weeping Peninsula - Church of Pilgrimage] Arteria Leaf 1043347000")]
        WeepingPeninsulaChurchOfPilgrimageArteriaLeaf = 1043347000,

        [Display(Name = "[Weeping Peninsula - Church of Pilgrimage] Shield of the Guilty 1043347100")]
        WeepingPeninsulaChurchOfPilgrimageShieldOfTheGuilty = 1043347100,

        [Display(Name = "[Weeping Peninsula - Church of Pilgrimage] Faith-knot Crystal Tear 65240")]
        WeepingPeninsulaChurchOfPilgrimageFaithknotCrystalTear = 65240,

        [Display(Name = "[Weeping Peninsula - Church of Pilgrimage] Gold-Tinged Excrement 1043347040")]
        WeepingPeninsulaChurchOfPilgrimageGoldTingedExcrement = 1043347040,

        [Display(Name = "[Weeping Peninsula - Church of Pilgrimage] String 1043347050")]
        WeepingPeninsulaChurchOfPilgrimageString = 1043347050,

        [Display(Name = "[Weeping Peninsula - Church of Pilgrimage] Demi-Human Queen's Staff 1043347400")]
        WeepingPeninsulaChurchOfPilgrimageDemiHumanQueensStaff = 1043347400,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Golden Rune [4] 1044317010")]
        WeepingPeninsulaCastleMorneApproachGoldenRune4 = 1044317010,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Arteria Leaf 1044317020")]
        WeepingPeninsulaCastleMorneApproachArteriaLeaf = 1044317020,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Somber Smithing Stone [2] 1044317030")]
        WeepingPeninsulaCastleMorneApproachSomberSmithingStone2 = 1044317030,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Smithing Stone [1] 1044327010")]
        WeepingPeninsulaCastleMorneApproachSmithingStone1 = 1044327010,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Warming Stone 1044327030")]
        WeepingPeninsulaCastleMorneApproachWarmingStone = 1044327030,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Great Turtle Shell 1044327040")]
        WeepingPeninsulaCastleMorneApproachGreatTurtleShell = 1044327040,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Sacrificial Axe 1044327400")]
        WeepingPeninsulaCastleMorneApproachSacrificialAxe = 1044327400,

        [Display(Name = "[Weeping Peninsula - Castle Morne Approach] Ash of War: Barricade Shield 1044327410")]
        WeepingPeninsulaCastleMorneApproachAshOfWarBarricadeShield = 1044327410,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] Crest Wooden Shield 1044337000")]
        WeepingPeninsulaAilingVillageOutskirtsCrestWoodenShield = 1044337000,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] Rainbow Stone 1044337020")]
        WeepingPeninsulaAilingVillageOutskirtsRainbowStone = 1044337020,

        [Display(Name = "[Weeping Peninsula - Bridge of Sacrifice] Hand Ballista 1044347100")]
        WeepingPeninsulaBridgeOfSacrificeHandBallista = 1044347100,

        [Display(Name = "[Weeping Peninsula - Bridge of Sacrifice] Rainbow Stone 1044347040")]
        WeepingPeninsulaBridgeOfSacrificeRainbowStone = 1044347040,

        [Display(Name = "[Weeping Peninsula - Bridge of Sacrifice] Golden Rune [1] 1044347060")]
        WeepingPeninsulaBridgeOfSacrificeGoldenRune1 = 1044347060,

        [Display(Name = "[Weeping Peninsula - Bridge of Sacrifice] Golden Rune [1] 1044347070")]
        WeepingPeninsulaBridgeOfSacrificeGoldenRune1_ = 1044347070,

        [Display(Name = "[Leyndell - Minor Erdtree] Starlight Shards 1045337000")]
        LeyndellMinorErdtreeStarlightShards = 1045337000,

        [Display(Name = "[Leyndell - Minor Erdtree] Memory Stone 60400")]
        LeyndellMinorErdtreeMemoryStone = 60400,

        [Display(Name = "[Weeping Peninsula - Impaler's Catacombs Entrance] Stonesword Key 1045347000")]
        WeepingPeninsulaImpalersCatacombsEntranceStoneswordKey = 1045347000,

        [Display(Name = "[Weeping Peninsula - Tombsward] Golden Rune [1] 1042337200")]
        WeepingPeninsulaTombswardGoldenRune1 = 1042337200,

        [Display(Name = "[Weeping Peninsula - Morne Moangrave] Somber Smithing Stone [1] 1043307000")]
        WeepingPeninsulaMorneMoangraveSomberSmithingStone1 = 1043307000,

        [Display(Name = "[Weeping Peninsula - Morne Moangrave] Fire Arrow 1043307010")]
        WeepingPeninsulaMorneMoangraveFireArrow = 1043307010,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Fire Grease 1043317000")]
        WeepingPeninsulaCastleMorneFireGrease = 1043317000,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317010")]
        WeepingPeninsulaCastleMorne = 1043317010,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Smithing Stone [2] 1043317020")]
        WeepingPeninsulaCastleMorneSmithingStone2 = 1043317020,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317030")]
        WeepingPeninsulaCastleMorne_ = 1043317030,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317040")]
        WeepingPeninsulaCastleMorne__ = 1043317040,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317050")]
        WeepingPeninsulaCastleMorne___ = 1043317050,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317060")]
        WeepingPeninsulaCastleMorne____ = 1043317060,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317070")]
        WeepingPeninsulaCastleMorne_____ = 1043317070,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Golden Rune [2] 1043317080")]
        WeepingPeninsulaCastleMorneGoldenRune2 = 1043317080,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Smithing Stone [2] 1043317090")]
        WeepingPeninsulaCastleMorneSmithingStone2_ = 1043317090,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317100")]
        WeepingPeninsulaCastleMorne______ = 1043317100,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Golden Rune [2] 1043317110")]
        WeepingPeninsulaCastleMorneGoldenRune2_ = 1043317110,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317120")]
        WeepingPeninsulaCastleMorne_______ = 1043317120,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317130")]
        WeepingPeninsulaCastleMorne________ = 1043317130,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Pickled Turtle Neck 1043317140")]
        WeepingPeninsulaCastleMornePickledTurtleNeck = 1043317140,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317150")]
        WeepingPeninsulaCastleMorne_________ = 1043317150,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317160")]
        WeepingPeninsulaCastleMorne__________ = 1043317160,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Stonesword Key 1043317170")]
        WeepingPeninsulaCastleMorneStoneswordKey = 1043317170,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317180")]
        WeepingPeninsulaCastleMorne___________ = 1043317180,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317190")]
        WeepingPeninsulaCastleMorne____________ = 1043317190,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317200")]
        WeepingPeninsulaCastleMorne_____________ = 1043317200,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317210")]
        WeepingPeninsulaCastleMorne______________ = 1043317210,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Tarnished Golden Sunflower 1043317220")]
        WeepingPeninsulaCastleMorneTarnishedGoldenSunflower = 1043317220,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317230")]
        WeepingPeninsulaCastleMorne_______________ = 1043317230,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Smithing Stone [2] 1043317240")]
        WeepingPeninsulaCastleMorneSmithingStone2__ = 1043317240,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317250")]
        WeepingPeninsulaCastleMorne________________ = 1043317250,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317260")]
        WeepingPeninsulaCastleMorne_________________ = 1043317260,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317270")]
        WeepingPeninsulaCastleMorne__________________ = 1043317270,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Throwing Dagger 1043317280")]
        WeepingPeninsulaCastleMorneThrowingDagger = 1043317280,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317290")]
        WeepingPeninsulaCastleMorne___________________ = 1043317290,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317300")]
        WeepingPeninsulaCastleMorne____________________ = 1043317300,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317310")]
        WeepingPeninsulaCastleMorne_____________________ = 1043317310,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Furlcalling Finger Remedy 1043317320")]
        WeepingPeninsulaCastleMorneFurlcallingFingerRemedy = 1043317320,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Steel-Wire Torch 1043317330")]
        WeepingPeninsulaCastleMorneSteelWireTorch = 1043317330,

        [Display(Name = "[Weeping Peninsula - Castle Morne] 1043317340")]
        WeepingPeninsulaCastleMorne______________________ = 1043317340,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Smithing Stone [1] 1043317350")]
        WeepingPeninsulaCastleMorneSmithingStone1 = 1043317350,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Ballista Bolt 1043317360")]
        WeepingPeninsulaCastleMorneBallistaBolt = 1043317360,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Whip 1043317370")]
        WeepingPeninsulaCastleMorneWhip = 1043317370,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Golden Rune [1] 1043317400")]
        WeepingPeninsulaCastleMorneGoldenRune1 = 1043317400,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Smithing Stone [1] 1043317500")]
        WeepingPeninsulaCastleMorneSmithingStone1_ = 1043317500,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Twinblade Talisman 1043317900")]
        WeepingPeninsulaCastleMorneTwinbladeTalisman = 1043317900,

        [Display(Name = "[Weeping Peninsula - Castle Morne] Claymore 1043317910")]
        WeepingPeninsulaCastleMorneClaymore = 1043317910,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] Strip of White Flesh 1044337030")]
        WeepingPeninsulaAilingVillageOutskirtsStripOfWhiteFlesh = 1044337030,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] 1044337040")]
        WeepingPeninsulaAilingVillageOutskirts = 1044337040,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] Golden Rune [2] 1044337050")]
        WeepingPeninsulaAilingVillageOutskirtsGoldenRune2 = 1044337050,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] 1044337060")]
        WeepingPeninsulaAilingVillageOutskirts_ = 1044337060,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] Golden Rune [2] 1044337070")]
        WeepingPeninsulaAilingVillageOutskirtsGoldenRune2_ = 1044337070,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] The Flame of Frenzy 1044337080")]
        WeepingPeninsulaAilingVillageOutskirtsTheFlameOfFrenzy = 1044337080,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] Smithing Stone [2] 1044337200")]
        WeepingPeninsulaAilingVillageOutskirtsSmithingStone2 = 1044337200,

        [Display(Name = "[Weeping Peninsula - Ailing Village Outskirts] Morning Star 1044337210")]
        WeepingPeninsulaAilingVillageOutskirtsMorningStar = 1044337210,

        [Display(Name = "[Limgrave - Rear Gael Tunnel Entrance] Golden Rune [1] 1046397000")]
        LimgraveRearGaelTunnelEntranceGoldenRune1 = 1046397000,

        [Display(Name = "[Limgrave - Rear Gael Tunnel Entrance] Golden Rune [2] 1046397010")]
        LimgraveRearGaelTunnelEntranceGoldenRune2 = 1046397010,

        [Display(Name = "[Limgrave - Rear Gael Tunnel Entrance] Golden Rune [3] 1046397020")]
        LimgraveRearGaelTunnelEntranceGoldenRune3 = 1046397020,

        [Display(Name = "[Caelid - Smoldering Church] Nascent Butterfly 1046407000")]
        CaelidSmolderingChurchNascentButterfly = 1046407000,

        [Display(Name = "[Caelid - Smoldering Church] Rune Arc 1046407010")]
        CaelidSmolderingChurchRuneArc = 1046407010,

        [Display(Name = "[Caelid - Smoldering Church] Golden Rune [3] 1046407020")]
        CaelidSmolderingChurchGoldenRune3 = 1046407020,

        [Display(Name = "[Caelid - Smoldering Church] Missionary's Cookbook [3] 67650")]
        CaelidSmolderingChurchMissionarysCookbook3 = 67650,

        [Display(Name = "[Caelid - Smoldering Church] Preserving Boluses 1046407040")]
        CaelidSmolderingChurchPreservingBoluses = 1046407040,

        [Display(Name = "[Caelid - Smoldering Church] Nomadic Warrior's Cookbook [14] 67870")]
        CaelidSmolderingChurchNomadicWarriorsCookbook14 = 67870,

        [Display(Name = "[Caelid - Smoldering Church] Drawstring Lightning Grease 1046407060")]
        CaelidSmolderingChurchDrawstringLightningGrease = 1046407060,

        [Display(Name = "[Caelid - Smoldering Church] Sacred Scorpion Charm 1046407700")]
        CaelidSmolderingChurchSacredScorpionCharm = 1046407700,

        [Display(Name = "[Caelid - West of Caelid Highway South] Golden Rune [1] 1047377000")]
        CaelidWestOfCaelidHighwaySouthGoldenRune1 = 1047377000,

        [Display(Name = "[Caelid - West of Caelid Highway South] Golden Rune [5] 1047377010")]
        CaelidWestOfCaelidHighwaySouthGoldenRune5 = 1047377010,

        [Display(Name = "[Caelid - West of Caelid Highway South] Golden Rune [1] 1047377020")]
        CaelidWestOfCaelidHighwaySouthGoldenRune1_ = 1047377020,

        [Display(Name = "[Caelid - West of Caelid Highway South] Golden Rune [2] 1047377030")]
        CaelidWestOfCaelidHighwaySouthGoldenRune2 = 1047377030,

        [Display(Name = "[Caelid - West of Caelid Highway South] Poisonbloom 1047377040")]
        CaelidWestOfCaelidHighwaySouthPoisonbloom = 1047377040,

        [Display(Name = "[Caelid - West of Caelid Highway South] Starlight Shards 1047377050")]
        CaelidWestOfCaelidHighwaySouthStarlightShards = 1047377050,

        [Display(Name = "[Caelid - West of Caelid Highway South] Larval Tear 1047377100")]
        CaelidWestOfCaelidHighwaySouthLarvalTear = 1047377100,

        [Display(Name = "[Caelid - Fort Gael] Somber Smithing Stone [4] 1047387010")]
        CaelidFortGaelSomberSmithingStone4 = 1047387010,

        [Display(Name = "[Caelid - Fort Gael] Great Dragonfly Head 1047387030")]
        CaelidFortGaelGreatDragonflyHead = 1047387030,

        [Display(Name = "[Caelid - Fort Gael] Rot Grease 1047387040")]
        CaelidFortGaelRotGrease = 1047387040,

        [Display(Name = "[Caelid - Fort Gael] Rune Arc 1047387070")]
        CaelidFortGaelRuneArc = 1047387070,

        [Display(Name = "[Caelid - Fort Gael] Warming Stone 1047387080")]
        CaelidFortGaelWarmingStone = 1047387080,

        [Display(Name = "[Caelid - Fort Gael] Smoldering Butterfly 1047387100")]
        CaelidFortGaelSmolderingButterfly = 1047387100,

        [Display(Name = "[Caelid - Fort Gael] Mushroom 1047387110")]
        CaelidFortGaelMushroom = 1047387110,

        [Display(Name = "[Caelid - Fort Gael] Flame, Grant Me Strength 1047387120")]
        CaelidFortGaelFlameGrantMeStrength = 1047387120,

        [Display(Name = "[Caelid - Fort Gael] Explosive Greatbolt 1047387130")]
        CaelidFortGaelExplosiveGreatbolt = 1047387130,

        [Display(Name = "[Caelid - Fort Gael] Ash of War: Lion's Claw 1047387700")]
        CaelidFortGaelAshOfWarLionsClaw = 1047387700,

        [Display(Name = "[Caelid - Fort Gael] Starscourge Heirloom 1047387900")]
        CaelidFortGaelStarscourgeHeirloom = 1047387900,

        [Display(Name = "[Caelid - Fort Gael] Meteoric Ore Blade 1047387910")]
        CaelidFortGaelMeteoricOreBlade = 1047387910,

        [Display(Name = "[Caelid - Fort Gael] Katar 1047387920")]
        CaelidFortGaelKatar = 1047387920,

        [Display(Name = "[Caelid - Fort Gael North] Smithing Stone [5] 1047397000")]
        CaelidFortGaelNorthSmithingStone5 = 1047397000,

        [Display(Name = "[Caelid - Fort Gael North] Golden Rune [9] 1047397040")]
        CaelidFortGaelNorthGoldenRune9 = 1047397040,

        [Display(Name = "[Caelid - Fort Gael North] Slumbering Egg 1047397080")]
        CaelidFortGaelNorthSlumberingEgg = 1047397080,

        [Display(Name = "[Caelid - Caelem Ruins] Golden Rune [5] 1047407000")]
        CaelidCaelemRuinsGoldenRune5 = 1047407000,

        [Display(Name = "[Caelid - Caelem Ruins] Cracked Pot 66190")]
        CaelidCaelemRuinsCrackedPot = 66190,

        [Display(Name = "[Caelid - Caelem Ruins] Smithing Stone [4] 1047407020")]
        CaelidCaelemRuinsSmithingStone4 = 1047407020,

        [Display(Name = "[Caelid - Caelem Ruins] Somber Smithing Stone [4] 1047407030")]
        CaelidCaelemRuinsSomberSmithingStone4 = 1047407030,

        [Display(Name = "[Caelid - Caelem Ruins] Explosive Bolt 1047407040")]
        CaelidCaelemRuinsExplosiveBolt = 1047407040,

        [Display(Name = "[Caelid - Caelem Ruins] Drawstring Fire Grease 1047407070")]
        CaelidCaelemRuinsDrawstringFireGrease = 1047407070,

        [Display(Name = "[Caelid - Caelem Ruins] Smoldering Butterfly 1047407080")]
        CaelidCaelemRuinsSmolderingButterfly = 1047407080,

        [Display(Name = "[Caelid - Caelem Ruins] Rune Arc 1047407900")]
        CaelidCaelemRuinsRuneArc = 1047407900,

        [Display(Name = "[Caelid - Caelem Ruins] Sword of St. Trina 1047407910")]
        CaelidCaelemRuinsSwordOfStTrina = 1047407910,

        [Display(Name = "[Caelid - Caelem Ruins] Greatsword 1047407920")]
        CaelidCaelemRuinsGreatsword = 1047407920,

        [Display(Name = "[Caelid - Cathedral of Dragon Communion] Ancient Dragon Apostle's Cookbook [3] 68030")]
        CaelidCathedralOfDragonCommunionAncientDragonApostlesCookbook3 = 68030,

        [Display(Name = "[Caelid - Caelid Highway South] Crab Eggs 1048377000")]
        CaelidCaelidHighwaySouthCrabEggs = 1048377000,

        [Display(Name = "[Caelid - Caelid Highway South] Golden Rune [3] 1048377020")]
        CaelidCaelidHighwaySouthGoldenRune3 = 1048377020,

        [Display(Name = "[Caelid - Caelid Highway South] Golden Rune [4] 1048377030")]
        CaelidCaelidHighwaySouthGoldenRune4 = 1048377030,

        [Display(Name = "[Caelid - West Aeonia Swamp] Golden Rune [4] 1048387000")]
        CaelidWestAeoniaSwampGoldenRune4 = 1048387000,

        [Display(Name = "[Caelid - West Aeonia Swamp] Perfume Bottle 66790")]
        CaelidWestAeoniaSwampPerfumeBottle = 66790,

        [Display(Name = "[Caelid - West Aeonia Swamp] Traveler's Hat 1048387010")]
        CaelidWestAeoniaSwampTravelersHat = 1048387010,

        [Display(Name = "[Caelid - West Aeonia Swamp] Golden Rune [5] 1048387020")]
        CaelidWestAeoniaSwampGoldenRune5 = 1048387020,

        [Display(Name = "[Caelid - West Aeonia Swamp] Sacramental Bud 1048387500")]
        CaelidWestAeoniaSwampSacramentalBud = 1048387500,

        [Display(Name = "[Caelid - Smoldering Wall] Sacramental Bud 1048397000")]
        CaelidSmolderingWallSacramentalBud = 1048397000,

        [Display(Name = "[Caelid - Smoldering Wall] Somber Smithing Stone [5] 1048397010")]
        CaelidSmolderingWallSomberSmithingStone5 = 1048397010,

        [Display(Name = "[Caelid - Smoldering Wall] Great Dragonfly Head 1048397040")]
        CaelidSmolderingWallGreatDragonflyHead = 1048397040,

        [Display(Name = "[Caelid - Smoldering Wall] Stonesword Key 1048397050")]
        CaelidSmolderingWallStoneswordKey = 1048397050,

        [Display(Name = "[Caelid - Smoldering Wall] Rock Sling 1048397900")]
        CaelidSmolderingWallRockSling = 1048397900,

        [Display(Name = "[Caelid - Deep Siofra Well] Golden Rune [1] 1048407010")]
        CaelidDeepSiofraWellGoldenRune1 = 1048407010,

        [Display(Name = "[Caelid - Deep Siofra Well] Golden Rune [6] 1048407020")]
        CaelidDeepSiofraWellGoldenRune6 = 1048407020,

        [Display(Name = "[Caelid - Deep Siofra Well] Golden Rune [2] 1048407030")]
        CaelidDeepSiofraWellGoldenRune2 = 1048407030,

        [Display(Name = "[Caelid - Deep Siofra Well] Sacramental Bud 1048407040")]
        CaelidDeepSiofraWellSacramentalBud = 1048407040,

        [Display(Name = "[Caelid - Deep Siofra Well] Hefty Beast Bone 1048407050")]
        CaelidDeepSiofraWellHeftyBeastBone = 1048407050,

        [Display(Name = "[Caelid - Deep Siofra Well] Spiked Palisade Shield 1048407060")]
        CaelidDeepSiofraWellSpikedPalisadeShield = 1048407060,

        [Display(Name = "[Caelid - Deep Siofra Well] Visage Shield 1048407900")]
        CaelidDeepSiofraWellVisageShield = 1048407900,

        [Display(Name = "[Greyoll's Dragonbarrow - Isolated Merchant's Shack] Gravity Stone Peddler's Bell Bearing 1048417800")]
        GreyollsDragonbarrowIsolatedMerchantsShackGravityStonePeddlersBellBearing = 1048417800,

        [Display(Name = "[Caelid - Southwest of Caelid Highway South] Smoldering Butterfly 1049367000")]
        CaelidSouthwestOfCaelidHighwaySouthSmolderingButterfly = 1049367000,

        [Display(Name = "[Caelid - Southwest of Caelid Highway South] Fan Daggers 1049367010")]
        CaelidSouthwestOfCaelidHighwaySouthFanDaggers = 1049367010,

        [Display(Name = "[Caelid - Southern Aeonia Swamp Bank] Windy Crystal Tear 65150")]
        CaelidSouthernAeoniaSwampBankWindyCrystalTear = 65150,

        [Display(Name = "[Caelid - Southern Aeonia Swamp Bank] Beast Blood 1049377010")]
        CaelidSouthernAeoniaSwampBankBeastBlood = 1049377010,

        [Display(Name = "[Caelid - Southern Aeonia Swamp Bank] Golden Seed 1049377020")]
        CaelidSouthernAeoniaSwampBankGoldenSeed = 1049377020,

        [Display(Name = "[Caelid - Southern Aeonia Swamp Bank] Beast Blood 1049377050")]
        CaelidSouthernAeoniaSwampBankBeastBlood_ = 1049377050,

        [Display(Name = "[Caelid - Southern Aeonia Swamp Bank] Golden Rune [2] 1049377070")]
        CaelidSouthernAeoniaSwampBankGoldenRune2 = 1049377070,

        [Display(Name = "[Caelid - Southern Aeonia Swamp Bank] Ash of War: Poison Moth Flight 1049377100")]
        CaelidSouthernAeoniaSwampBankAshOfWarPoisonMothFlight = 1049377100,

        [Display(Name = "[Caelid - Southern Aeonia Swamp Bank] Death's Poker 1049377110")]
        CaelidSouthernAeoniaSwampBankDeathsPoker = 1049377110,

        [Display(Name = "[Caelid - Southern Aeonia Swamp Bank] Somber Smithing Stone [4] 1049377700")]
        CaelidSouthernAeoniaSwampBankSomberSmithingStone4 = 1049377700,

        [Display(Name = "[Caelid - East Aeonia Swamp] Eternal Darkness 1049387800")]
        CaelidEastAeoniaSwampEternalDarkness = 1049387800,

        [Display(Name = "[Caelid - East Aeonia Swamp] Somber Smithing Stone [4] 1049387010")]
        CaelidEastAeoniaSwampSomberSmithingStone4 = 1049387010,

        [Display(Name = "[Caelid - East Aeonia Swamp] Aeonian Butterfly 1049387020")]
        CaelidEastAeoniaSwampAeonianButterfly = 1049387020,

        [Display(Name = "[Caelid - East Aeonia Swamp] Smithing Stone [4] 1049387030")]
        CaelidEastAeoniaSwampSmithingStone4 = 1049387030,

        [Display(Name = "[Caelid - East Aeonia Swamp] Black-Key Bolt 1049387040")]
        CaelidEastAeoniaSwampBlackKeyBolt = 1049387040,

        [Display(Name = "[Caelid - East Aeonia Swamp] Sacramental Bud 1049387060")]
        CaelidEastAeoniaSwampSacramentalBud = 1049387060,

        [Display(Name = "[Caelid - East Aeonia Swamp] Rune Arc 1049387070")]
        CaelidEastAeoniaSwampRuneArc = 1049387070,

        [Display(Name = "[Caelid - East Aeonia Swamp] Golden Rune [4] 1049387080")]
        CaelidEastAeoniaSwampGoldenRune4 = 1049387080,

        [Display(Name = "[Caelid - East Aeonia Swamp] Golden Rune [5] 1049387110")]
        CaelidEastAeoniaSwampGoldenRune5 = 1049387110,

        [Display(Name = "[Caelid - East Aeonia Swamp] Glass Shard 1049387120")]
        CaelidEastAeoniaSwampGlassShard = 1049387120,

        [Display(Name = "[Caelid - West Sellia] Stonesword Key 1049397000")]
        CaelidWestSelliaStoneswordKey = 1049397000,

        [Display(Name = "[Caelid - West Sellia] Poisonbloom 1049397010")]
        CaelidWestSelliaPoisonbloom = 1049397010,

        [Display(Name = "[Caelid - West Sellia] Rune Arc 1049397020")]
        CaelidWestSelliaRuneArc = 1049397020,

        [Display(Name = "[Caelid - West Sellia] Staff of Loss 1049397030")]
        CaelidWestSelliaStaffOfLoss = 1049397030,

        [Display(Name = "[Caelid - West Sellia] Rotten Stray Ashes 1049397040")]
        CaelidWestSelliaRottenStrayAshes = 1049397040,

        [Display(Name = "[Caelid - West Sellia] Nox Flowing Sword 1049397800")]
        CaelidWestSelliaNoxFlowingSword = 1049397800,

        [Display(Name = "[Caelid - West Sellia] Battlemage Hugues 1049397850")]
        CaelidWestSelliaBattlemageHugues = 1049397850,

        [Display(Name = "[Caelid - West Sellia] Lusat's Glintstone Staff 1049397900")]
        CaelidWestSelliaLusatsGlintstoneStaff = 1049397900,

        [Display(Name = "[Caelid - West Sellia] Spelldrake Talisman +1 1049397910")]
        CaelidWestSelliaSpelldrakeTalisman1 = 1049397910,

        [Display(Name = "[Greyoll's Dragonbarrow - Deep Siofra Well] Map: Dragonbarrow 62041")]
        GreyollsDragonbarrowDeepSiofraWellMapDragonbarrow = 62041,

        [Display(Name = "[Caelid - Southern Aeonia Swamp Bank] Map: Caelid 62040")]
        CaelidSouthernAeoniaSwampBankMapCaelid = 62040,

        [Display(Name = "[Greyoll's Dragonbarrow - Deep Siofra Well] Golden Rune [5] 1049407000")]
        GreyollsDragonbarrowDeepSiofraWellGoldenRune5 = 1049407000,

        [Display(Name = "[Greyoll's Dragonbarrow - Deep Siofra Well] Gravel Stone 1049407010")]
        GreyollsDragonbarrowDeepSiofraWellGravelStone = 1049407010,

        [Display(Name = "[Greyoll's Dragonbarrow - Deep Siofra Well] Sliver of Meat 1049407020")]
        GreyollsDragonbarrowDeepSiofraWellSliverOfMeat = 1049407020,

        [Display(Name = "[Greyoll's Dragonbarrow - Deep Siofra Well] Smithing Stone [5] 1049407040")]
        GreyollsDragonbarrowDeepSiofraWellSmithingStone5 = 1049407040,

        [Display(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid Entrance] Arteria Leaf 1049417040")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceArteriaLeaf = 1049417040,

        [Display(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid Entrance] Dragonwound Grease 1049417070")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceDragonwoundGrease = 1049417070,

        [Display(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid Entrance] Rune Arc 1049417080")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceRuneArc = 1049417080,

        [Display(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid Entrance] Somber Smithing Stone [9] 1049417090")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceSomberSmithingStone9 = 1049417090,

        [Display(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid Entrance] Numen's Rune 1049417100")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceNumensRune = 1049417100,

        [Display(Name = "[Caelid - East Sellia] Night Comet 1050397900")]
        CaelidEastSelliaNightComet = 1050397900,

        [Display(Name = "[Caelid - East Sellia] Imbued Sword Key 1050397910")]
        CaelidEastSelliaImbuedSwordKey = 1050397910,

        [Display(Name = "[Caelid - Impassable Greatbridge] Mushroom 1050367000")]
        CaelidImpassableGreatbridgeMushroom = 1050367000,

        [Display(Name = "[Caelid - Impassable Greatbridge] Arrow's Sting Talisman 1050367900")]
        CaelidImpassableGreatbridgeArrowsStingTalisman = 1050367900,

        [Display(Name = "[Caelid - Gowry's Shack] Golden Rune [5] 1050387000")]
        CaelidGowrysShackGoldenRune5 = 1050387000,

        [Display(Name = "[Caelid - Gowry's Shack] Drawstring Poison Grease 1050387010")]
        CaelidGowrysShackDrawstringPoisonGrease = 1050387010,

        [Display(Name = "[Caelid - Gowry's Shack] Sacred Tear 1050387020")]
        CaelidGowrysShackSacredTear = 1050387020,

        [Display(Name = "[Caelid - East Sellia] Poison Grease 1050397000")]
        CaelidEastSelliaPoisonGrease = 1050397000,

        [Display(Name = "[Caelid - East Sellia] Toxic Mushroom 1050397010")]
        CaelidEastSelliaToxicMushroom = 1050397010,

        [Display(Name = "[Caelid - East Sellia] Smithing Stone [7] 1050397020")]
        CaelidEastSelliaSmithingStone7 = 1050397020,

        [Display(Name = "[Caelid - East Sellia] Smithing Stone [7] 1050397030")]
        CaelidEastSelliaSmithingStone7_ = 1050397030,

        [Display(Name = "[Caelid - East Sellia] Stonesword Key 1050397040")]
        CaelidEastSelliaStoneswordKey = 1050397040,

        [Display(Name = "[Caelid - East Sellia] Smithing Stone [8] 1050397050")]
        CaelidEastSelliaSmithingStone8 = 1050397050,

        [Display(Name = "[Caelid - East Sellia] Starlight Shards 1050397060")]
        CaelidEastSelliaStarlightShards = 1050397060,

        [Display(Name = "[Caelid - East Sellia] Cerulean Tear Scarab 1050397070")]
        CaelidEastSelliaCeruleanTearScarab = 1050397070,

        [Display(Name = "[Caelid - East Sellia] Beast Blood 1050397090")]
        CaelidEastSelliaBeastBlood = 1050397090,

        [Display(Name = "[Caelid - East Sellia] Golden Seed 1050397100")]
        CaelidEastSelliaGoldenSeed = 1050397100,

        [Display(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Fork] Dragon Heart 1050407800")]
        GreyollsDragonbarrowDragonbarrowForkDragonHeart = 1050407800,

        [Display(Name = "[Caelid - Redmane Castle South Cliffside] Smoldering Butterfly 1051357000")]
        CaelidRedmaneCastleSouthCliffsideSmolderingButterfly = 1051357000,

        [Display(Name = "[Caelid - Redmane Castle] Golden Rune [6] 1051367000")]
        CaelidRedmaneCastleGoldenRune6 = 1051367000,

        [Display(Name = "[Caelid - Redmane Castle] Armorer's Cookbook [4] 67260")]
        CaelidRedmaneCastleArmorersCookbook4 = 67260,

        [Display(Name = "[Caelid - Redmane Castle] Smithing Stone [6] 1051367020")]
        CaelidRedmaneCastleSmithingStone6 = 1051367020,

        [Display(Name = "[Caelid - Redmane Castle] Smithing Stone [3] 1051367030")]
        CaelidRedmaneCastleSmithingStone3 = 1051367030,

        [Display(Name = "[Caelid - Redmane Castle] Smithing Stone [4] 1051367040")]
        CaelidRedmaneCastleSmithingStone4 = 1051367040,

        [Display(Name = "[Caelid - Redmane Castle] Smithing Stone [3] 1051367050")]
        CaelidRedmaneCastleSmithingStone3_ = 1051367050,

        [Display(Name = "[Caelid - Redmane Castle] Smithing Stone [5] 1051367060")]
        CaelidRedmaneCastleSmithingStone5 = 1051367060,

        [Display(Name = "[Caelid - Redmane Castle] Red-Hot Whetblade 65640")]
        CaelidRedmaneCastleRedHotWhetblade = 65640,

        [Display(Name = "[Caelid - Redmane Castle] Smithing Stone [5] 1051367080")]
        CaelidRedmaneCastleSmithingStone5_ = 1051367080,

        [Display(Name = "[Caelid - Redmane Castle] Smithing Stone [4] 1051367090")]
        CaelidRedmaneCastleSmithingStone4_ = 1051367090,

        [Display(Name = "[Caelid - Redmane Castle] Smithing Stone [6] 1051367100")]
        CaelidRedmaneCastleSmithingStone6_ = 1051367100,

        [Display(Name = "[Caelid - Redmane Castle] Somber Smithing Stone [5] 1051367110")]
        CaelidRedmaneCastleSomberSmithingStone5 = 1051367110,

        [Display(Name = "[Caelid - Redmane Castle] Armorer's Cookbook [5] 67310")]
        CaelidRedmaneCastleArmorersCookbook5 = 67310,

        [Display(Name = "[Caelid - Redmane Castle] Flamberge 1051367130")]
        CaelidRedmaneCastleFlamberge = 1051367130,

        [Display(Name = "[Caelid - Redmane Castle] Somber Smithing Stone [4] 1051367700")]
        CaelidRedmaneCastleSomberSmithingStone4 = 1051367700,

        [Display(Name = "[Caelid - Redmane Castle] Somber Smithing Stone [4] 1051367800")]
        CaelidRedmaneCastleSomberSmithingStone4_ = 1051367800,

        [Display(Name = "[Caelid - Redmane Castle] Smithing Stone [6] 1051367910")]
        CaelidRedmaneCastleSmithingStone6__ = 1051367910,

        [Display(Name = "[Caelid - West Radahn Arena] Radahn's Spear 1051387000")]
        CaelidWestRadahnArenaRadahnsSpear = 1051387000,

        [Display(Name = "[Caelid - West Radahn Arena] Radahn's Spear 1051387010")]
        CaelidWestRadahnArenaRadahnsSpear_ = 1051387010,

        [Display(Name = "[Caelid - West Radahn Arena] Radahn's Spear 1051387020")]
        CaelidWestRadahnArenaRadahnsSpear__ = 1051387020,

        [Display(Name = "[Greyoll's Dragonbarrow - Fort Faroth] Golden Rune [12] 1051397040")]
        GreyollsDragonbarrowFortFarothGoldenRune12 = 1051397040,

        [Display(Name = "[Greyoll's Dragonbarrow - Fort Faroth] Neutralizing Boluses 1051397050")]
        GreyollsDragonbarrowFortFarothNeutralizingBoluses = 1051397050,

        [Display(Name = "[Greyoll's Dragonbarrow - Fort Faroth] Radagon's Soreseal 1051397060")]
        GreyollsDragonbarrowFortFarothRadagonsSoreseal = 1051397060,

        [Display(Name = "[Greyoll's Dragonbarrow - Fort Faroth] Dectus Medallion (Right) 1051397900")]
        GreyollsDragonbarrowFortFarothDectusMedallionRight = 1051397900,

        [Display(Name = "[Greyoll's Dragonbarrow - Minor Erdtree] Rune Arc 1051407040")]
        GreyollsDragonbarrowMinorErdtreeRuneArc = 1051407040,

        [Display(Name = "[Greyoll's Dragonbarrow - Bestial Sanctum] Soft Cotton 1051417000")]
        GreyollsDragonbarrowBestialSanctumSoftCotton = 1051417000,

        [Display(Name = "[Greyoll's Dragonbarrow - Bestial Sanctum] Cinquedea 1051417010")]
        GreyollsDragonbarrowBestialSanctumCinquedea = 1051417010,

        [Display(Name = "[Greyoll's Dragonbarrow - Bestial Sanctum] Golden Seed 1051437020")]
        GreyollsDragonbarrowBestialSanctumGoldenSeed = 1051437020,

        [Display(Name = "[Greyoll's Dragonbarrow - Bestial Sanctum] Dragoncrest Shield Talisman 1051417030")]
        GreyollsDragonbarrowBestialSanctumDragoncrestShieldTalisman = 1051417030,

        [Display(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Golden Rune [8] 1052417000")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune8 = 1052417000,

        [Display(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Golden Rune [6] 1052417010")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune6 = 1052417010,

        [Display(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Golden Rune [3] 1052417020")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune3 = 1052417020,

        [Display(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Golden Rune [1] 1052417030")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune1 = 1052417030,

        [Display(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Ash of War: Bloodhound's Step 1052417100")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeAshOfWarBloodhoundsStep = 1052417100,

        [Display(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Memory Stone 60460")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeMemoryStone = 60460,

        [Display(Name = "[Greyoll's Dragonbarrow - Northeast Cliffside] Starlight Shards 1052437000")]
        GreyollsDragonbarrowNortheastCliffsideStarlightShards = 1052437000,

        [Display(Name = "[Liurnia of the Lakes - Main Academy Gate] Golden Seed 1035467100")]
        LiurniaOfTheLakesMainAcademyGateGoldenSeed = 1035467100,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Southwest] Golden Seed 1036447300")]
        LiurniaOfTheLakesGateTownSouthwestGoldenSeed = 1036447300,

        [Display(Name = "[Liurnia of the Lakes - Church of Irith] Sacred Tear 1039397000")]
        LiurniaOfTheLakesChurchOfIrithSacredTear = 1039397000,

        [Display(Name = "[Liurnia of the Lakes - Southeast Ravine] Sacred Tear 1036497000")]
        LiurniaOfTheLakesSoutheastRavineSacredTear = 1036497000,

        [Display(Name = "[Bellum Highway - Church of Inhibition] Sacred Tear 1037497100")]
        BellumHighwayChurchOfInhibitionSacredTear = 1037497100,

        [Display(Name = "[Liurnia of the Lakes - West of Scenic Isle] Dexterity-knot Crystal Tear 65220")]
        LiurniaOfTheLakesWestOfScenicIsleDexterityknotCrystalTear = 65220,

        [Display(Name = "[Liurnia of the Lakes - South of Caria Manor] Intelligence-knot Crystal Tear 65230")]
        LiurniaOfTheLakesSouthOfCariaManorIntelligenceknotCrystalTear = 65230,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Northwest] Ancient Death Rancor 1036457400")]
        LiurniaOfTheLakesGateTownNorthwestAncientDeathRancor = 1036457400,

        [Display(Name = "[Bellum Highway - East Raya Lucaria Gate] Ash of War: Giant Hunt 1036487400")]
        BellumHighwayEastRayaLucariaGateAshOfWarGiantHunt = 1036487400,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Red-Feathered Branchsword 1037427400")]
        LiurniaOfTheLakesLaskyarRuinsRedFeatheredBranchsword = 1037427400,

        [Display(Name = "[Liurnia of the Lakes - Church of Vows] Meat Peddler's Bell Bearing 1037467400")]
        LiurniaOfTheLakesChurchOfVowsMeatPeddlersBellBearing = 1037467400,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Ash of War: Ice Spear 1039437400")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthAshOfWarIceSpear = 1039437400,

        [Display(Name = "[Liurnia of the Lakes - North of Gate Town Bridge] Dragon Cult Prayerbook 1038447100")]
        LiurniaOfTheLakesNorthOfGateTownBridgeDragonCultPrayerbook = 1038447100,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427200")]
        MoonlightAltarCathedralOfManusCelesStarlightShards = 1035427200,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Starlight Shards 1039437100")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthStarlightShards = 1039437100,

        [Display(Name = "[Liurnia of the Lakes - Behind Caria Manor] Golden Rune [3] 1036507010")]
        LiurniaOfTheLakesBehindCariaManorGoldenRune3 = 1036507010,

        [Display(Name = "[Liurnia of the Lakes - Behind Caria Manor] Thawfrost Boluses 1036507020")]
        LiurniaOfTheLakesBehindCariaManorThawfrostBoluses = 1036507020,

        [Display(Name = "[Liurnia of the Lakes - Behind Caria Manor] Albinauric Ashes 1036507030")]
        LiurniaOfTheLakesBehindCariaManorAlbinauricAshes = 1036507030,

        [Display(Name = "[Liurnia of the Lakes - Lake-Facing Cliffs] Academy Scroll 1039407000")]
        LiurniaOfTheLakesLakeFacingCliffsAcademyScroll = 1039407000,

        [Display(Name = "[Liurnia of the Lakes - West of Church of Irith] Warming Stone 1038397000")]
        LiurniaOfTheLakesWestOfChurchOfIrithWarmingStone = 1038397000,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Lake Shore] Smoldering Butterfly 1038407000")]
        LiurniaOfTheLakesLiurniaLakeShoreSmolderingButterfly = 1038407000,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Lake Shore] Glintstone Craftsman's Cookbook [1] 67410")]
        LiurniaOfTheLakesLiurniaLakeShoreGlintstoneCraftsmansCookbook1 = 67410,

        [Display(Name = "[Liurnia of the Lakes - Purified Ruins] Golden Rune [3] 1039417000")]
        LiurniaOfTheLakesPurifiedRuinsGoldenRune3 = 1039417000,

        [Display(Name = "[Liurnia of the Lakes - Purified Ruins] Cuckoo Glintstone 1039417010")]
        LiurniaOfTheLakesPurifiedRuinsCuckooGlintstone = 1039417010,

        [Display(Name = "[Liurnia of the Lakes - Purified Ruins] Somber Smithing Stone [2] 1039417020")]
        LiurniaOfTheLakesPurifiedRuinsSomberSmithingStone2 = 1039417020,

        [Display(Name = "[Liurnia of the Lakes - Purified Ruins] Stormhawk Feather 1039417030")]
        LiurniaOfTheLakesPurifiedRuinsStormhawkFeather = 1039417030,

        [Display(Name = "[Liurnia of the Lakes - Purified Ruins] Two Fingers Heirloom 1039417100")]
        LiurniaOfTheLakesPurifiedRuinsTwoFingersHeirloom = 1039417100,

        [Display(Name = "[Liurnia of the Lakes - Purified Ruins] Shabriri Grape 1039417200")]
        LiurniaOfTheLakesPurifiedRuinsShabririGrape = 1039417200,

        [Display(Name = "[Liurnia of the Lakes - Purified Ruins] Golden Rune [6] 1039417300")]
        LiurniaOfTheLakesPurifiedRuinsGoldenRune6 = 1039417300,

        [Display(Name = "[Liurnia of the Lakes - Purified Ruins] Golden Rune [6] 1039417310")]
        LiurniaOfTheLakesPurifiedRuinsGoldenRune6_ = 1039417310,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway North] Mushroom 1039427000")]
        LiurniaOfTheLakesLiurniaHighwayNorthMushroom = 1039427000,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway North] Crystal Dart 1039427010")]
        LiurniaOfTheLakesLiurniaHighwayNorthCrystalDart = 1039427010,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway North] Golden Rune [6] 1039427020")]
        LiurniaOfTheLakesLiurniaHighwayNorthGoldenRune6 = 1039427020,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway North] Golden Rune [3] 1039427030")]
        LiurniaOfTheLakesLiurniaHighwayNorthGoldenRune3 = 1039427030,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway North] Beast Blood 1039427040")]
        LiurniaOfTheLakesLiurniaHighwayNorthBeastBlood = 1039427040,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway North] Lucerne 1039427050")]
        LiurniaOfTheLakesLiurniaHighwayNorthLucerne = 1039427050,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Golden Rune [3] 1037427000")]
        LiurniaOfTheLakesLaskyarRuinsGoldenRune3 = 1037427000,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Glass Shard 1037427030")]
        LiurniaOfTheLakesLaskyarRuinsGlassShard = 1037427030,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Ritual Pot 66420")]
        LiurniaOfTheLakesLaskyarRuinsRitualPot = 66420,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Wraith Calling Bell 1037427900")]
        LiurniaOfTheLakesLaskyarRuinsWraithCallingBell = 1037427900,

        [Display(Name = "[Liurnia of the Lakes - South of Mausoleum Compound] Grave Violet 1037477000")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundGraveViolet = 1037477000,

        [Display(Name = "[Liurnia of the Lakes - South of Mausoleum Compound] Arteria Leaf 1037477010")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundArteriaLeaf = 1037477010,

        [Display(Name = "[Liurnia of the Lakes - South of Mausoleum Compound] Stalwart Horn Charm 1037477020")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundStalwartHornCharm = 1037477020,

        [Display(Name = "[Liurnia of the Lakes - South of Mausoleum Compound] Spiralhorn Shield 1037477030")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundSpiralhornShield = 1037477030,

        [Display(Name = "[Liurnia of the Lakes - Slumbering Wolf's Shack] Fire Monks' Prayerbook 1036417000")]
        LiurniaOfTheLakesSlumberingWolfsShackFireMonksPrayerbook = 1036417000,

        [Display(Name = "[Liurnia of the Lakes - Slumbering Wolf's Shack] Dappled Cured Meat 1036417010")]
        LiurniaOfTheLakesSlumberingWolfsShackDappledCuredMeat = 1036417010,

        [Display(Name = "[Liurnia of the Lakes - Slumbering Wolf's Shack] Rune Arc 1036417020")]
        LiurniaOfTheLakesSlumberingWolfsShackRuneArc = 1036417020,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Southwest] Crystal Bud 1036447000")]
        LiurniaOfTheLakesGateTownSouthwestCrystalBud = 1036447000,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Southwest] Arteria Leaf 1036447010")]
        LiurniaOfTheLakesGateTownSouthwestArteriaLeaf = 1036447010,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Southwest] Smithing Stone [2] 1036447040")]
        LiurniaOfTheLakesGateTownSouthwestSmithingStone2 = 1036447040,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Southwest] Shattershard Arrow (Fletched) 1036447050")]
        LiurniaOfTheLakesGateTownSouthwestShattershardArrowFletched = 1036447050,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Southwest] Glintstone Firefly 1036447060")]
        LiurniaOfTheLakesGateTownSouthwestGlintstoneFirefly = 1036447060,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Southwest] Glintstone Craftsman's Cookbook [4] 67400")]
        LiurniaOfTheLakesGateTownSouthwestGlintstoneCraftsmansCookbook4 = 67400,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Northwest] Crystal Cave Moss 1036457020")]
        LiurniaOfTheLakesGateTownNorthwestCrystalCaveMoss = 1036457020,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Northwest] Stonesword Key 1036457110")]
        LiurniaOfTheLakesGateTownNorthwestStoneswordKey = 1036457110,

        [Display(Name = "[Liurnia of the Lakes - South Rose Church] Somber Smithing Stone [1] 1035437010")]
        LiurniaOfTheLakesSouthRoseChurchSomberSmithingStone1 = 1035437010,

        [Display(Name = "[Liurnia of the Lakes - South Rose Church] Larval Tear 1035437100")]
        LiurniaOfTheLakesSouthRoseChurchLarvalTear = 1035437100,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Smithing Stone [3] 1035447000")]
        LiurniaOfTheLakesNorthRoseChurchSmithingStone3 = 1035447000,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [1] 1035447010")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune1 = 1035447010,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [4] 1035447020")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune4 = 1035447020,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [3] 1035447030")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune3 = 1035447030,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [2] 1035447040")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune2 = 1035447040,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [4] 1035447050")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune4_ = 1035447050,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [2] 1035447060")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune2_ = 1035447060,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [1] 1035447070")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune1_ = 1035447070,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [5] 1035447080")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune5 = 1035447080,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [2] 1035447090")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune2__ = 1035447090,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [3] 1035447100")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune3_ = 1035447100,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Smithing Stone [2] 1035447110")]
        LiurniaOfTheLakesNorthRoseChurchSmithingStone2 = 1035447110,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Blue-White Wooden Shield 1035447120")]
        LiurniaOfTheLakesNorthRoseChurchBlueWhiteWoodenShield = 1035447120,

        [Display(Name = "[Liurnia of the Lakes - North Rose Church] Nomadic Warrior's Cookbook [12] 67060")]
        LiurniaOfTheLakesNorthRoseChurchNomadicWarriorsCookbook12 = 67060,

        [Display(Name = "[Liurnia of the Lakes - South Raya Lucaria Gate] Celestial Dew 1035457000")]
        LiurniaOfTheLakesSouthRayaLucariaGateCelestialDew = 1035457000,

        [Display(Name = "[Liurnia of the Lakes - South Raya Lucaria Gate] Strip of White Flesh 1035457030")]
        LiurniaOfTheLakesSouthRayaLucariaGateStripOfWhiteFlesh = 1035457030,

        [Display(Name = "[Liurnia of the Lakes - Main Academy Gate] Stonesword Key 1035467020")]
        LiurniaOfTheLakesMainAcademyGateStoneswordKey = 1035467020,

        [Display(Name = "[Liurnia of the Lakes - Main Academy Gate] Ash of War: Raptor of the Mists 1035467700")]
        LiurniaOfTheLakesMainAcademyGateAshOfWarRaptorOfTheMists = 1035467700,

        [Display(Name = "[Liurnia of the Lakes - Testu's Rise] Golden Rune [1] 1035477000")]
        LiurniaOfTheLakesTestusRiseGoldenRune1 = 1035477000,

        [Display(Name = "[Liurnia of the Lakes - Temple Quarter] Rimed Crystal Bud 1034447000")]
        LiurniaOfTheLakesTempleQuarterRimedCrystalBud = 1034447000,

        [Display(Name = "[Liurnia of the Lakes - Temple Quarter] Smithing Stone [2] 1034447010")]
        LiurniaOfTheLakesTempleQuarterSmithingStone2 = 1034447010,

        [Display(Name = "[Liurnia of the Lakes - Temple Quarter] Icerind Hatchet 1034447900")]
        LiurniaOfTheLakesTempleQuarterIcerindHatchet = 1034447900,

        [Display(Name = "[Liurnia of the Lakes - Church of Vows] Gold Sewing Needle 1037467000")]
        LiurniaOfTheLakesChurchOfVowsGoldSewingNeedle = 1037467000,

        [Display(Name = "[Liurnia of the Lakes - Church of Vows] Golden Tailoring Tools 60150")]
        LiurniaOfTheLakesChurchOfVowsGoldenTailoringTools = 60150,

        [Display(Name = "[Liurnia of the Lakes - Church of Vows] Stormhawk Feather 1037467010")]
        LiurniaOfTheLakesChurchOfVowsStormhawkFeather = 1037467010,

        [Display(Name = "[Liurnia of the Lakes - Highway Lookout Tower] Smithing Stone [2] 1038427000")]
        LiurniaOfTheLakesHighwayLookoutTowerSmithingStone2 = 1038427000,

        [Display(Name = "[Liurnia of the Lakes - Highway Lookout Tower] Golden Rune [4] 1038427010")]
        LiurniaOfTheLakesHighwayLookoutTowerGoldenRune4 = 1038427010,

        [Display(Name = "[Liurnia of the Lakes - Highway Lookout Tower] Carian Glintblade Staff 1038427020")]
        LiurniaOfTheLakesHighwayLookoutTowerCarianGlintbladeStaff = 1038427020,

        [Display(Name = "[Liurnia of the Lakes - Highway Lookout Tower] Glintstone Craftsman's Cookbook [3] 67480")]
        LiurniaOfTheLakesHighwayLookoutTowerGlintstoneCraftsmansCookbook3 = 67480,

        [Display(Name = "[Liurnia of the Lakes - Testu's Rise] Smithing Stone [2] 1035477010")]
        LiurniaOfTheLakesTestusRiseSmithingStone2 = 1035477010,

        [Display(Name = "[Liurnia of the Lakes - Testu's Rise] Memory Stone 60420")]
        LiurniaOfTheLakesTestusRiseMemoryStone = 60420,

        [Display(Name = "[Bellum Highway - Converted Fringe Tower] Crystal Dart 1039487000")]
        BellumHighwayConvertedFringeTowerCrystalDart = 1039487000,

        [Display(Name = "[Bellum Highway - Converted Fringe Tower] Cannon of Haima 1039487100")]
        BellumHighwayConvertedFringeTowerCannonOfHaima = 1039487100,

        [Display(Name = "[Moonlight Altar] Ranni's Dark Moon 1033407100")]
        MoonlightAltarRannisDarkMoon = 1033407100,

        [Display(Name = "[Liurnia of the Lakes - Foot of the Four Belfries] Strip of White Flesh 1033467000")]
        LiurniaOfTheLakesFootOfTheFourBelfriesStripOfWhiteFlesh = 1033467000,

        [Display(Name = "[Liurnia of the Lakes - Foot of the Four Belfries] Blood Grease 1033467030")]
        LiurniaOfTheLakesFootOfTheFourBelfriesBloodGrease = 1033467030,

        [Display(Name = "[Liurnia of the Lakes - Foot of the Four Belfries] Jellyfish Shield 1033467040")]
        LiurniaOfTheLakesFootOfTheFourBelfriesJellyfishShield = 1033467040,

        [Display(Name = "[Liurnia of the Lakes - The Four Belfries] Imbued Sword Key 1033477020")]
        LiurniaOfTheLakesTheFourBelfriesImbuedSwordKey = 1033477020,

        [Display(Name = "[Liurnia of the Lakes - The Four Belfries] Albinauric Bloodclot 1033477900")]
        LiurniaOfTheLakesTheFourBelfriesAlbinauricBloodclot = 1033477900,

        [Display(Name = "[Liurnia of the Lakes - The Four Belfries] Cuckoo Glintstone 1033477910")]
        LiurniaOfTheLakesTheFourBelfriesCuckooGlintstone = 1033477910,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [3] 1034507010")]
        LiurniaOfTheLakesRannisRiseGoldenRune3 = 1034507010,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [4] 1034507020")]
        LiurniaOfTheLakesRannisRiseGoldenRune4 = 1034507020,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [5] 1034507030")]
        LiurniaOfTheLakesRannisRiseGoldenRune5 = 1034507030,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [1] 1034507040")]
        LiurniaOfTheLakesRannisRiseGoldenRune1 = 1034507040,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [3] 1034507050")]
        LiurniaOfTheLakesRannisRiseGoldenRune3_ = 1034507050,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [3] 1034507060")]
        LiurniaOfTheLakesRannisRiseGoldenRune3__ = 1034507060,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [2] 1034507070")]
        LiurniaOfTheLakesRannisRiseGoldenRune2 = 1034507070,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [3] 1034507080")]
        LiurniaOfTheLakesRannisRiseGoldenRune3___ = 1034507080,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] Black Wolf Mask 1034507090")]
        LiurniaOfTheLakesRannisRiseBlackWolfMask = 1034507090,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] Memory Stone 60430")]
        LiurniaOfTheLakesRannisRiseMemoryStone = 60430,

        [Display(Name = "[Liurnia of the Lakes - Ranni's Rise] 1034507200")]
        LiurniaOfTheLakesRannisRise = 1034507200,

        [Display(Name = "[Liurnia of the Lakes - Renna's Rise] Snow Witch Skirt 1034517900")]
        LiurniaOfTheLakesRennasRiseSnowWitchSkirt = 1034517900,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Throwing Dagger 1034477000")]
        LiurniaOfTheLakesSorcerersIsleWestThrowingDagger = 1034477000,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [2] 1034477500")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune2 = 1034477500,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [1] 1034477110")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune1 = 1034477110,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [3] 1034477120")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3 = 1034477120,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [3] 1034477130")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3_ = 1034477130,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [1] 1034477140")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune1_ = 1034477140,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [5] 1034477150")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune5 = 1034477150,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [3] 1034477160")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3__ = 1034477160,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [2] 1034477170")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune2_ = 1034477170,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [3] 1034477180")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3___ = 1034477180,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [3] 1034477190")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3____ = 1034477190,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [4] 1034477200")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune4 = 1034477200,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [2] 1034477210")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune2__ = 1034477210,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [4] 1034477220")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune4_ = 1034477220,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [6] 1034477300")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune6 = 1034477300,

        [Display(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [6] 1034477310")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune6_ = 1034477310,

        [Display(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Golden Rune [6] 1034487300")]
        LiurniaOfTheLakesKingsrealmRuinsGoldenRune6 = 1034487300,

        [Display(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Golden Rune [6] 1034487310")]
        LiurniaOfTheLakesKingsrealmRuinsGoldenRune6_ = 1034487310,

        [Display(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Rimed Crystal Bud 1034487000")]
        LiurniaOfTheLakesKingsrealmRuinsRimedCrystalBud = 1034487000,

        [Display(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Glintstone Firefly 1034487010")]
        LiurniaOfTheLakesKingsrealmRuinsGlintstoneFirefly = 1034487010,

        [Display(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Frozen Needle 1034487100")]
        LiurniaOfTheLakesKingsrealmRuinsFrozenNeedle = 1034487100,

        [Display(Name = "[Liurnia of the Lakes - Artist's Shack] Smoldering Butterfly 1038457000")]
        LiurniaOfTheLakesArtistsShackSmolderingButterfly = 1038457000,

        [Display(Name = "[Liurnia of the Lakes - Artist's Shack] Flame, Cleanse Me 1038457010")]
        LiurniaOfTheLakesArtistsShackFlameCleanseMe = 1038457010,

        [Display(Name = "[Liurnia of the Lakes - Artist's Shack] Smithing Stone [4] 1038457020")]
        LiurniaOfTheLakesArtistsShackSmithingStone4 = 1038457020,

        [Display(Name = "[Bellum Highway - Frenzied Flame Village] Frenzied's Cookbook [1] 68400")]
        BellumHighwayFrenziedFlameVillageFrenziedsCookbook1 = 68400,

        [Display(Name = "[Bellum Highway - Frenzied Flame Village] Eye of Yelough 1038487020")]
        BellumHighwayFrenziedFlameVillageEyeOfYelough = 1038487020,

        [Display(Name = "[Bellum Highway - Frenzied Flame Village] Stonesword Key 1038487030")]
        BellumHighwayFrenziedFlameVillageStoneswordKey = 1038487030,

        [Display(Name = "[Bellum Highway - Frenzied Flame Village] Note: The Lord of Frenzied Flame 69760")]
        BellumHighwayFrenziedFlameVillageNoteTheLordOfFrenziedFlame = 69760,

        [Display(Name = "[Bellum Highway - Frenzied Flame Village] Shabriri's Woe 1038487100")]
        BellumHighwayFrenziedFlameVillageShabririsWoe = 1038487100,

        [Display(Name = "[Bellum Highway - Frenzied Flame Village] Eye of Yelough 1038487120")]
        BellumHighwayFrenziedFlameVillageEyeOfYelough_ = 1038487120,

        [Display(Name = "[Bellum Highway - Frenzied Flame Village] Frenzyflame Stone 1038487130")]
        BellumHighwayFrenziedFlameVillageFrenzyflameStone = 1038487130,

        [Display(Name = "[Liurnia of the Lakes - Ravine-Veiled Village] Smithing Stone [5] 1038507000")]
        LiurniaOfTheLakesRavineVeiledVillageSmithingStone5 = 1038507000,

        [Display(Name = "[Liurnia of the Lakes - Ravine-Veiled Village] Dragonwound Grease 1038507010")]
        LiurniaOfTheLakesRavineVeiledVillageDragonwoundGrease = 1038507010,

        [Display(Name = "[Bellum Highway - Church of Inhibition] Cuckoo Glintstone 1037497000")]
        BellumHighwayChurchOfInhibitionCuckooGlintstone = 1037497000,

        [Display(Name = "[Bellum Highway - Church of Inhibition] Rune Arc 1037497010")]
        BellumHighwayChurchOfInhibitionRuneArc = 1037497010,

        [Display(Name = "[Bellum Highway - Church of Inhibition] Finger Maiden Fillet 1037497030")]
        BellumHighwayChurchOfInhibitionFingerMaidenFillet = 1037497030,

        [Display(Name = "[Bellum Highway - Church of Inhibition] Great Mace 1037497200")]
        BellumHighwayChurchOfInhibitionGreatMace = 1037497200,

        [Display(Name = "[Bellum Highway - Church of Inhibition] Fingerprint Grape 1037497300")]
        BellumHighwayChurchOfInhibitionFingerprintGrape = 1037497300,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [2] 1039437010")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune2 = 1039437010,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [6] 1039437020")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune6 = 1039437020,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [1] 1039437030")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune1 = 1039437030,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [3] 1039437040")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune3 = 1039437040,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [2] 1039437050")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune2_ = 1039437050,

        [Display(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [3] 1039437060")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune3_ = 1039437060,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Bridge] Strip of White Flesh 1038437000")]
        LiurniaOfTheLakesGateTownBridgeStripOfWhiteFlesh = 1038437000,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Bridge] Sliver of Meat 1038437010")]
        LiurniaOfTheLakesGateTownBridgeSliverOfMeat = 1038437010,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Bridge] Silver-Pickled Fowl Foot 1038437020")]
        LiurniaOfTheLakesGateTownBridgeSilverPickledFowlFoot = 1038437020,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Bridge] Golden Rune [6] 1038437100")]
        LiurniaOfTheLakesGateTownBridgeGoldenRune6 = 1038437100,

        [Display(Name = "[Liurnia of the Lakes - South of Scenic Isle] Ballista Bolt 1037417010")]
        LiurniaOfTheLakesSouthOfScenicIsleBallistaBolt = 1037417010,

        [Display(Name = "[Liurnia of the Lakes - North of Scenic Isle] Golden Rune [3] 1037437000")]
        LiurniaOfTheLakesNorthOfScenicIsleGoldenRune3 = 1037437000,

        [Display(Name = "[Liurnia of the Lakes - North of Scenic Isle] Smithing Stone [3] 1037437010")]
        LiurniaOfTheLakesNorthOfScenicIsleSmithingStone3 = 1037437010,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Southeast] Golden Rune [4] 1037447000")]
        LiurniaOfTheLakesGateTownSoutheastGoldenRune4 = 1037447000,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Southeast] Magic Grease 1037447010")]
        LiurniaOfTheLakesGateTownSoutheastMagicGrease = 1037447010,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Northeast] Smithing Stone [3] 1037457100")]
        LiurniaOfTheLakesGateTownNortheastSmithingStone3 = 1037457100,

        [Display(Name = "[Liurnia of the Lakes - Boilprawn Shack] Smithing Stone [2] 1036437000")]
        LiurniaOfTheLakesBoilprawnShackSmithingStone2 = 1036437000,

        [Display(Name = "[Liurnia of the Lakes - Boilprawn Shack] Confessor Hood 1036437010")]
        LiurniaOfTheLakesBoilprawnShackConfessorHood = 1036437010,

        [Display(Name = "[Liurnia of the Lakes - Boilprawn Shack] Tarnished Golden Sunflower 1036437020")]
        LiurniaOfTheLakesBoilprawnShackTarnishedGoldenSunflower = 1036437020,

        [Display(Name = "[Liurnia of the Lakes - Boilprawn Shack] Rainbow Stone 1036437030")]
        LiurniaOfTheLakesBoilprawnShackRainbowStone = 1036437030,

        [Display(Name = "[Liurnia of the Lakes - Jarburg] Smithing Stone [3] 1039447000")]
        LiurniaOfTheLakesJarburgSmithingStone3 = 1039447000,

        [Display(Name = "[Liurnia of the Lakes - Jarburg] Great Dragonfly Head 1039447010")]
        LiurniaOfTheLakesJarburgGreatDragonflyHead = 1039447010,

        [Display(Name = "[Liurnia of the Lakes - Jarburg] Trina's Lily 1039447020")]
        LiurniaOfTheLakesJarburgTrinasLily = 1039447020,

        [Display(Name = "[Liurnia of the Lakes - Jarburg] Smithing Stone [3] 1039447030")]
        LiurniaOfTheLakesJarburgSmithingStone3_ = 1039447030,

        [Display(Name = "[Liurnia of the Lakes - Jarburg] Living Jar Shard 1039447040")]
        LiurniaOfTheLakesJarburgLivingJarShard = 1039447040,

        [Display(Name = "[Liurnia of the Lakes - Jarburg] Cracked Pot 66080")]
        LiurniaOfTheLakesJarburgCrackedPot = 66080,

        [Display(Name = "[Liurnia of the Lakes - Jarburg] Cracked Pot 66090")]
        LiurniaOfTheLakesJarburgCrackedPot_ = 66090,

        [Display(Name = "[Liurnia of the Lakes - Jarburg] Cracked Pot 66100")]
        LiurniaOfTheLakesJarburgCrackedPot__ = 66100,

        [Display(Name = "[Liurnia of the Lakes - Jarburg] Ritual Pot 66430")]
        LiurniaOfTheLakesJarburgRitualPot = 66430,

        [Display(Name = "[Liurnia of the Lakes - Jarburg] Ritual Pot 66440")]
        LiurniaOfTheLakesJarburgRitualPot_ = 66440,

        [Display(Name = "[Liurnia of the Lakes - Crystalline Woods] Smithing Stone [3] 1034467100")]
        LiurniaOfTheLakesCrystallineWoodsSmithingStone3 = 1034467100,

        [Display(Name = "[Liurnia of the Lakes - Meeting Place] Dragonwound Grease 1034457010")]
        LiurniaOfTheLakesMeetingPlaceDragonwoundGrease = 1034457010,

        [Display(Name = "[Liurnia of the Lakes - Meeting Place] Kukri 1034457020")]
        LiurniaOfTheLakesMeetingPlaceKukri = 1034457020,

        [Display(Name = "[Liurnia of the Lakes - Meeting Place] Academy Glintstone Key 1034457100")]
        LiurniaOfTheLakesMeetingPlaceAcademyGlintstoneKey = 1034457100,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Smithing Stone [3] 1037427010")]
        LiurniaOfTheLakesLaskyarRuinsSmithingStone3 = 1037427010,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Nomadic Warrior's Cookbook [11] 67220")]
        LiurniaOfTheLakesLaskyarRuinsNomadicWarriorsCookbook11 = 67220,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Smithing Stone [2] 1035427010")]
        MoonlightAltarCathedralOfManusCelesSmithingStone2 = 1035427010,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Rune Arc 1035427030")]
        MoonlightAltarCathedralOfManusCelesRuneArc = 1035427030,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Ivory Sickle 1035427040")]
        MoonlightAltarCathedralOfManusCelesIvorySickle = 1035427040,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427100")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_ = 1035427100,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427110")]
        MoonlightAltarCathedralOfManusCelesStarlightShards__ = 1035427110,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427120")]
        MoonlightAltarCathedralOfManusCelesStarlightShards___ = 1035427120,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427130")]
        MoonlightAltarCathedralOfManusCelesStarlightShards____ = 1035427130,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427140")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_____ = 1035427140,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427150")]
        MoonlightAltarCathedralOfManusCelesStarlightShards______ = 1035427150,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427160")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_______ = 1035427160,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427170")]
        MoonlightAltarCathedralOfManusCelesStarlightShards________ = 1035427170,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427180")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_________ = 1035427180,

        [Display(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427190")]
        MoonlightAltarCathedralOfManusCelesStarlightShards__________ = 1035427190,

        [Display(Name = "[Liurnia of the Lakes - South Raya Lucaria Gate] Meeting Place Map 1035457100")]
        LiurniaOfTheLakesSouthRayaLucariaGateMeetingPlaceMap = 1035457100,

        [Display(Name = "[Liurnia of the Lakes - South of Caria Manor] Somber Smithing Stone [4] 1035497020")]
        LiurniaOfTheLakesSouthOfCariaManorSomberSmithingStone4 = 1035497020,

        [Display(Name = "[Liurnia of the Lakes - North of Sorcerer's Isle] Old Fang 1035487010")]
        LiurniaOfTheLakesNorthOfSorcerersIsleOldFang = 1035487010,

        [Display(Name = "[Liurnia of the Lakes - North of Sorcerer's Isle] Soporific Grease 1035487020")]
        LiurniaOfTheLakesNorthOfSorcerersIsleSoporificGrease = 1035487020,

        [Display(Name = "[Liurnia of the Lakes - North of Sorcerer's Isle] Lump of Flesh 1035487030")]
        LiurniaOfTheLakesNorthOfSorcerersIsleLumpOfFlesh = 1035487030,

        [Display(Name = "[Liurnia of the Lakes - North of Sorcerer's Isle] Golden Rune [6] 1035487100")]
        LiurniaOfTheLakesNorthOfSorcerersIsleGoldenRune6 = 1035487100,

        [Display(Name = "[Bellum Highway - East Raya Lucaria Gate] Sanctuary Stone 1036487000")]
        BellumHighwayEastRayaLucariaGateSanctuaryStone = 1036487000,

        [Display(Name = "[Bellum Highway - East Raya Lucaria Gate] Golden Rune [1] 1036487100")]
        BellumHighwayEastRayaLucariaGateGoldenRune1 = 1036487100,

        [Display(Name = "[Liurnia of the Lakes - Mausoleum Compound] Slumbering Egg 1037487000")]
        LiurniaOfTheLakesMausoleumCompoundSlumberingEgg = 1037487000,

        [Display(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [3] 1037487010")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3 = 1037487010,

        [Display(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [3] 1037487020")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3_ = 1037487020,

        [Display(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [1] 1037487030")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune1 = 1037487030,

        [Display(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [7] 1037487040")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune7 = 1037487040,

        [Display(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [3] 1037487050")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3__ = 1037487050,

        [Display(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [2] 1037487060")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune2 = 1037487060,

        [Display(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [4] 1037487070")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune4 = 1037487070,

        [Display(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [3] 1037487080")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3___ = 1037487080,

        [Display(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [1] 1037487100")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune1_ = 1037487100,

        [Display(Name = "[Liurnia of the Lakes - The Four Belfries] Somber Smithing Stone [3] 1033477000")]
        LiurniaOfTheLakesTheFourBelfriesSomberSmithingStone3 = 1033477000,

        [Display(Name = "[Liurnia of the Lakes - The Four Belfries] Smithing Stone [4] 1033477010")]
        LiurniaOfTheLakesTheFourBelfriesSmithingStone4 = 1033477010,

        [Display(Name = "[Liurnia of the Lakes - The Four Belfries] Rune Arc 1033477030")]
        LiurniaOfTheLakesTheFourBelfriesRuneArc = 1033477030,

        [Display(Name = "[Liurnia of the Lakes - The Four Belfries] Carian Knight's Sword 1033477200")]
        LiurniaOfTheLakesTheFourBelfriesCarianKnightsSword = 1033477200,

        [Display(Name = "[Liurnia of the Lakes - Ruined Labyrinth] Frenzyflame Stone 1038477010")]
        LiurniaOfTheLakesRuinedLabyrinthFrenzyflameStone = 1038477010,

        [Display(Name = "[Liurnia of the Lakes - Ruined Labyrinth] Stonesword Key 1038477030")]
        LiurniaOfTheLakesRuinedLabyrinthStoneswordKey = 1038477030,

        [Display(Name = "[Liurnia of the Lakes - Ruined Labyrinth] Golden Rune [1] 1038477100")]
        LiurniaOfTheLakesRuinedLabyrinthGoldenRune1 = 1038477100,

        [Display(Name = "[Liurnia of the Lakes - North of Gate Town Bridge] Smithing Stone [3] 1038447030")]
        LiurniaOfTheLakesNorthOfGateTownBridgeSmithingStone3 = 1038447030,

        [Display(Name = "[Liurnia of the Lakes - North of Gate Town Bridge] Land Squirt Ashes 1038447040")]
        LiurniaOfTheLakesNorthOfGateTownBridgeLandSquirtAshes = 1038447040,

        [Display(Name = "[Liurnia - Liurnia Highway South Endpoint] Treespear 1040407000")]
        LiurniaLiurniaHighwaySouthEndpointTreespear = 1040407000,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Glintstone Craftsman's Cookbook [2] 67450")]
        LiurniaOfTheLakesLaskyarRuinsGlintstoneCraftsmansCookbook2 = 67450,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Sacrificial Twig 1038417010")]
        LiurniaOfTheLakesLaskyarRuinsSacrificialTwig = 1038417010,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Gravitas 1038417100")]
        LiurniaOfTheLakesLaskyarRuinsGravitas = 1038417100,

        [Display(Name = "[Liurnia of the Lakes - Cuckoo's Evergaol] Dragonscale Blade 1033457100")]
        LiurniaOfTheLakesCuckoosEvergaolDragonscaleBlade = 1033457100,

        [Display(Name = "[Liurnia of the Lakes - Bellum Highway] Somber Smithing Stone [3] 1036477000")]
        LiurniaOfTheLakesBellumHighwaySomberSmithingStone3 = 1036477000,

        [Display(Name = "[Liurnia of the Lakes - Bellum Highway] Golden Rune [1] 1036477100")]
        LiurniaOfTheLakesBellumHighwayGoldenRune1 = 1036477100,

        [Display(Name = "[Moonlight Altar - Moonfolk Ruins] Albinauric Bloodclot 1034427020")]
        MoonlightAltarMoonfolkRuinsAlbinauricBloodclot = 1034427020,

        [Display(Name = "[Moonlight Altar - Moonfolk Ruins] Smithing Stone [2] 1034427030")]
        MoonlightAltarMoonfolkRuinsSmithingStone2 = 1034427030,

        [Display(Name = "[Moonlight Altar - Moonfolk Ruins] Crystal Sword 1034427050")]
        MoonlightAltarMoonfolkRuinsCrystalSword = 1034427050,

        [Display(Name = "[Moonlight Altar - Moonfolk Ruins] Larval Tear 1034427060")]
        MoonlightAltarMoonfolkRuinsLarvalTear = 1034427060,

        [Display(Name = "[Liurnia of the Lakes - Converted Tower] Magic Grease 1034437000")]
        LiurniaOfTheLakesConvertedTowerMagicGrease = 1034437000,

        [Display(Name = "[Liurnia of the Lakes - Converted Tower] Memory Stone 60410")]
        LiurniaOfTheLakesConvertedTowerMemoryStone = 60410,

        [Display(Name = "[Liurnia of the Lakes - Converted Tower] Golden Rune [6] 1034437200")]
        LiurniaOfTheLakesConvertedTowerGoldenRune6 = 1034437200,

        [Display(Name = "[Liurnia of the Lakes - Converted Tower] Cuckoo Glintstone 1034437300")]
        LiurniaOfTheLakesConvertedTowerCuckooGlintstone = 1034437300,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Rune Arc 1035507000")]
        LiurniaOfTheLakesCariaManorRuneArc = 1035507000,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Golden Rune [4] 1035507010")]
        LiurniaOfTheLakesCariaManorGoldenRune4 = 1035507010,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Stonesword Key 1035507020")]
        LiurniaOfTheLakesCariaManorStoneswordKey = 1035507020,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Slumbering Egg 1035507030")]
        LiurniaOfTheLakesCariaManorSlumberingEgg = 1035507030,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Glintstone Craftsman's Cookbook [6] 67460")]
        LiurniaOfTheLakesCariaManorGlintstoneCraftsmansCookbook6 = 67460,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Somber Smithing Stone [3] 1035507050")]
        LiurniaOfTheLakesCariaManorSomberSmithingStone3 = 1035507050,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Golden Rune [3] 1035507060")]
        LiurniaOfTheLakesCariaManorGoldenRune3 = 1035507060,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Crystal Dart 1035507070")]
        LiurniaOfTheLakesCariaManorCrystalDart = 1035507070,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Smithing Stone [4] 1035507080")]
        LiurniaOfTheLakesCariaManorSmithingStone4 = 1035507080,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Ash of War: Carian Grandeur 1035507090")]
        LiurniaOfTheLakesCariaManorAshOfWarCarianGrandeur = 1035507090,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Somber Smithing Stone [3] 1035507100")]
        LiurniaOfTheLakesCariaManorSomberSmithingStone3_ = 1035507100,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Spellproof Dried Liver 1035507110")]
        LiurniaOfTheLakesCariaManorSpellproofDriedLiver = 1035507110,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507120")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud = 1035507120,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Smithing Stone [2] 1035507130")]
        LiurniaOfTheLakesCariaManorSmithingStone2 = 1035507130,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Smithing Stone [4] 1035507140")]
        LiurniaOfTheLakesCariaManorSmithingStone4_ = 1035507140,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Urumi 1035507150")]
        LiurniaOfTheLakesCariaManorUrumi = 1035507150,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Smithing Stone [3] 1035507160")]
        LiurniaOfTheLakesCariaManorSmithingStone3 = 1035507160,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Golden Rune [4] 1035507170")]
        LiurniaOfTheLakesCariaManorGoldenRune4_ = 1035507170,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Old Fang 1035507180")]
        LiurniaOfTheLakesCariaManorOldFang = 1035507180,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Glintstone Firefly 1035507190")]
        LiurniaOfTheLakesCariaManorGlintstoneFirefly = 1035507190,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Ice Crest Shield 1035507200")]
        LiurniaOfTheLakesCariaManorIceCrestShield = 1035507200,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Magic Grease 1035507220")]
        LiurniaOfTheLakesCariaManorMagicGrease = 1035507220,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507230")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud_ = 1035507230,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507240")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud__ = 1035507240,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507250")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud___ = 1035507250,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507260")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud____ = 1035507260,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507270")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud_____ = 1035507270,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507280")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud______ = 1035507280,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Golden Seed 1035507300")]
        LiurniaOfTheLakesCariaManorGoldenSeed = 1035507300,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Cracked Pot 66110")]
        LiurniaOfTheLakesCariaManorCrackedPot = 66110,

        [Display(Name = "[Liurnia of the Lakes - Caria Manor] Sword of Night and Flame 1035507900")]
        LiurniaOfTheLakesCariaManorSwordOfNightandFlame = 1035507900,

        [Display(Name = "[Bellum Highway - Church of Inhibition] Rune Arc 1037497020")]
        BellumHighwayChurchOfInhibitionRuneArc_ = 1037497020,

        [Display(Name = "[Liurnia of the Lakes - Eastern Tableland] Immunizing White Cured Meat 1038467000")]
        LiurniaOfTheLakesEasternTablelandImmunizingWhiteCuredMeat = 1038467000,

        [Display(Name = "[Liurnia of the Lakes - Eastern Tableland] Golden Rune [1] 1038467400")]
        LiurniaOfTheLakesEasternTablelandGoldenRune1 = 1038467400,

        [Display(Name = "[Bellum Highway - Frenzy-Flaming Tower] Yellow Ember 1038497000")]
        BellumHighwayFrenzyFlamingTowerYellowEmber = 1038497000,

        [Display(Name = "[Bellum Highway - Frenzy-Flaming Tower] Smithing Stone [2] 1038497010")]
        BellumHighwayFrenzyFlamingTowerSmithingStone2 = 1038497010,

        [Display(Name = "[Bellum Highway - Frenzy-Flaming Tower] Burred Bolt 1038497030")]
        BellumHighwayFrenzyFlamingTowerBurredBolt = 1038497030,

        [Display(Name = "[Bellum Highway - Frenzy-Flaming Tower] Golden Rune [3] 1038497040")]
        BellumHighwayFrenzyFlamingTowerGoldenRune3 = 1038497040,

        [Display(Name = "[Bellum Highway - Frenzy-Flaming Tower] Howl of Shabriri 1038497900")]
        BellumHighwayFrenzyFlamingTowerHowlOfShabriri = 1038497900,

        [Display(Name = "[Moonlight Altar] Smithing Stone [7] 1033417000")]
        MoonlightAltarSmithingStone7 = 1033417000,

        [Display(Name = "[Moonlight Altar] Smithing Stone [8] 1033417010")]
        MoonlightAltarSmithingStone8 = 1033417010,

        [Display(Name = "[Moonlight Altar] Smithing Stone [7] 1033417020")]
        MoonlightAltarSmithingStone7_ = 1033417020,

        [Display(Name = "[Moonlight Altar] Dragon Heart 1033417400")]
        MoonlightAltarDragonHeart = 1033417400,

        [Display(Name = "[Moonlight Altar] Dragon Heart 1033417410")]
        MoonlightAltarDragonHeart_ = 1033417410,

        [Display(Name = "[Liurnia of the Lakes - Revenger's Shack] Raw Meat Dumpling 1033447000")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling = 1033447000,

        [Display(Name = "[Liurnia of the Lakes - Revenger's Shack] Raw Meat Dumpling 1033447010")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling_ = 1033447010,

        [Display(Name = "[Liurnia of the Lakes - Revenger's Shack] Raw Meat Dumpling 1033447020")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling__ = 1033447020,

        [Display(Name = "[Liurnia of the Lakes - Revenger's Shack] Raw Meat Dumpling 1033447030")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling___ = 1033447030,

        [Display(Name = "[Liurnia of the Lakes - Revenger's Shack] Raw Meat Dumpling 1033447040")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling____ = 1033447040,

        [Display(Name = "[Moonlight Altar - Deep Ainsel Well] Gravel Stone 1034417000")]
        MoonlightAltarDeepAinselWellGravelStone = 1034417000,

        [Display(Name = "[Moonlight Altar - Moonfolk Ruins] Golden Rune [9] 1034427000")]
        MoonlightAltarMoonfolkRuinsGoldenRune9 = 1034427000,

        [Display(Name = "[Moonlight Altar - Moonfolk Ruins] Magic Grease 1034427010")]
        MoonlightAltarMoonfolkRuinsMagicGrease = 1034427010,

        [Display(Name = "[Moonlight Altar - Moonfolk Ruins] Rune Arc 1034427040")]
        MoonlightAltarMoonfolkRuinsRuneArc = 1034427040,

        [Display(Name = "[Moonlight Altar - Moonfolk Ruins] Somber Smithing Stone [8] 1034427100")]
        MoonlightAltarMoonfolkRuinsSomberSmithingStone8 = 1034427100,

        [Display(Name = "[Moonlight Altar - Moonfolk Ruins] Dragon Heart 1034427400")]
        MoonlightAltarMoonfolkRuinsDragonHeart = 1034427400,

        [Display(Name = "[Moonlight Altar - Lunar Estate Ruins] Golden Rune [10] 1035417000")]
        MoonlightAltarLunarEstateRuinsGoldenRune10 = 1035417000,

        [Display(Name = "[Moonlight Altar - Lunar Estate Ruins] Glintstone Firefly 1035417010")]
        MoonlightAltarLunarEstateRuinsGlintstoneFirefly = 1035417010,

        [Display(Name = "[Moonlight Altar - Lunar Estate Ruins] Cerulean Amber Medallion +2 1035417100")]
        MoonlightAltarLunarEstateRuinsCeruleanAmberMedallion2 = 1035417100,

        [Display(Name = "[Moonlight Altar - Lunar Estate Ruins] Smithing Stone [8] 1035417110")]
        MoonlightAltarLunarEstateRuinsSmithingStone8 = 1035417110,

        [Display(Name = "[Liurnia of the Lakes - Laskyar Ruins] Map: Liurnia, East 62020")]
        LiurniaOfTheLakesLaskyarRuinsMapLiurniaEast = 62020,

        [Display(Name = "[Liurnia of the Lakes - Gate Town Southeast] Map: Liurnia, North 62021")]
        LiurniaOfTheLakesGateTownSoutheastMapLiurniaNorth = 62021,

        [Display(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Map: Liurnia, West 62022")]
        LiurniaOfTheLakesKingsrealmRuinsMapLiurniaWest = 62022,

        [Display(Name = "[Mt. Gelmir - Before Hermit Shack] Golden Rune [2] 1035527010")]
        MtGelmirBeforeHermitShackGoldenRune2 = 1035527010,

        [Display(Name = "[Mt. Gelmir - Before Hermit Shack] Golden Rune [4] 1035527020")]
        MtGelmirBeforeHermitShackGoldenRune4 = 1035527020,

        [Display(Name = "[Mt. Gelmir - Before Hermit Shack] Golden Rune [2] 1035527030")]
        MtGelmirBeforeHermitShackGoldenRune2_ = 1035527030,

        [Display(Name = "[Mt. Gelmir - Before Hermit Shack] Golden Rune [6] 1035527040")]
        MtGelmirBeforeHermitShackGoldenRune6 = 1035527040,

        [Display(Name = "[Mt. Gelmir - Seethewater Terminus] Smoldering Butterfly 1035537000")]
        MtGelmirSeethewaterTerminusSmolderingButterfly = 1035537000,

        [Display(Name = "[Mt. Gelmir - Seethewater Terminus] Golden Rune [3] 1035537010")]
        MtGelmirSeethewaterTerminusGoldenRune3 = 1035537010,

        [Display(Name = "[Mt. Gelmir - Seethewater Terminus] Mushroom 1035537020")]
        MtGelmirSeethewaterTerminusMushroom = 1035537020,

        [Display(Name = "[Mt. Gelmir - Seethewater Terminus] Smoldering Butterfly 1035537030")]
        MtGelmirSeethewaterTerminusSmolderingButterfly_ = 1035537030,

        [Display(Name = "[Mt. Gelmir - Seethewater Terminus] Smoldering Butterfly 1035537040")]
        MtGelmirSeethewaterTerminusSmolderingButterfly__ = 1035537040,

        [Display(Name = "[Mt. Gelmir - Seethewater Terminus] Golden Rune [5] 1035537050")]
        MtGelmirSeethewaterTerminusGoldenRune5 = 1035537050,

        [Display(Name = "[Mt. Gelmir - Fort Laiedd] Dragonwound Grease 1035547000")]
        MtGelmirFortLaieddDragonwoundGrease = 1035547000,

        [Display(Name = "[Mt. Gelmir - Fort Laiedd] Golden Rune [3] 1035547010")]
        MtGelmirFortLaieddGoldenRune3 = 1035547010,

        [Display(Name = "[Mt. Gelmir - Fort Laiedd] Stonesword Key 1035547020")]
        MtGelmirFortLaieddStoneswordKey = 1035547020,

        [Display(Name = "[Mt. Gelmir - Fort Laiedd] Armorer's Cookbook [7] 67250")]
        MtGelmirFortLaieddArmorersCookbook7 = 67250,

        [Display(Name = "[Mt. Gelmir - Fort Laiedd] Fire Scorpion Charm 1035547050")]
        MtGelmirFortLaieddFireScorpionCharm = 1035547050,

        [Display(Name = "[Mt. Gelmir - Fort Laiedd] Golden Rune [8] 1035547060")]
        MtGelmirFortLaieddGoldenRune8 = 1035547060,

        [Display(Name = "[Mt. Gelmir - Fort Laiedd] Slumbering Egg 1035547070")]
        MtGelmirFortLaieddSlumberingEgg = 1035547070,

        [Display(Name = "[Altus Plateau - Perfumer's Ruins] Golden Rune [5] 1036517000")]
        AltusPlateauPerfumersRuinsGoldenRune5 = 1036517000,

        [Display(Name = "[Altus Plateau - Perfumer's Ruins] Perfumer's Cookbook [1] 67840")]
        AltusPlateauPerfumersRuinsPerfumersCookbook1 = 67840,

        [Display(Name = "[Altus Plateau - Perfumer's Ruins] Perfume Bottle 66730")]
        AltusPlateauPerfumersRuinsPerfumeBottle = 66730,

        [Display(Name = "[Mt. Gelmir - Craftsman's Shack] Smithing Stone [6] 1036527000")]
        MtGelmirCraftsmansShackSmithingStone6 = 1036527000,

        [Display(Name = "[Mt. Gelmir - Craftsman's Shack] Perfumer's Talisman 1036527010")]
        MtGelmirCraftsmansShackPerfumersTalisman = 1036527010,

        [Display(Name = "[Mt. Gelmir - Craftsman's Shack] Budding Cave Moss 1036527020")]
        MtGelmirCraftsmansShackBuddingCaveMoss = 1036527020,

        [Display(Name = "[Mt. Gelmir - Craftsman's Shack] Nascent Butterfly 1036527030")]
        MtGelmirCraftsmansShackNascentButterfly = 1036527030,

        [Display(Name = "[Mt. Gelmir - Craftsman's Shack] Gravel Stone 1036527040")]
        MtGelmirCraftsmansShackGravelStone = 1036527040,

        [Display(Name = "[Mt. Gelmir - Craftsman's Shack] Roiling Magma 1036527050")]
        MtGelmirCraftsmansShackRoilingMagma = 1036527050,

        [Display(Name = "[Mt. Gelmir - Craftsman's Shack] Pulley Crossbow 1036527060")]
        MtGelmirCraftsmansShackPulleyCrossbow = 1036527060,

        [Display(Name = "[Mt. Gelmir - Craftsman's Shack] Perfume Bottle 66740")]
        MtGelmirCraftsmansShackPerfumeBottle = 66740,

        [Display(Name = "[Mt. Gelmir - Outside Volcano Manor] Golden Rune [6] 1036537000")]
        MtGelmirOutsideVolcanoManorGoldenRune6 = 1036537000,

        [Display(Name = "[Mt. Gelmir - Volcano Manor Entrance] Golden Rune [3] 1036547000")]
        MtGelmirVolcanoManorEntranceGoldenRune3 = 1036547000,

        [Display(Name = "[Mt. Gelmir - Volcano Manor Entrance] Smoldering Butterfly 1036547010")]
        MtGelmirVolcanoManorEntranceSmolderingButterfly = 1036547010,

        [Display(Name = "[Mt. Gelmir - Volcano Manor Entrance] Golden Rune [7] 1036547020")]
        MtGelmirVolcanoManorEntranceGoldenRune7 = 1036547020,

        [Display(Name = "[Mt. Gelmir - Volcano Manor Entrance] Smoldering Butterfly 1036547030")]
        MtGelmirVolcanoManorEntranceSmolderingButterfly_ = 1036547030,

        [Display(Name = "[Mt. Gelmir - Volcano Manor Entrance] Starlight Shards 1036547040")]
        MtGelmirVolcanoManorEntranceStarlightShards = 1036547040,

        [Display(Name = "[Mt. Gelmir - Volcano Manor Entrance] Fireproof Dried Liver 1036547050")]
        MtGelmirVolcanoManorEntranceFireproofDriedLiver = 1036547050,

        [Display(Name = "[Mt. Gelmir - Volcano Manor Entrance] Larval Tear 1036547100")]
        MtGelmirVolcanoManorEntranceLarvalTear = 1036547100,

        [Display(Name = "[Altus Plateau - Abandoned Coffin] Smithing Stone [5] 1037517000")]
        AltusPlateauAbandonedCoffinSmithingStone5 = 1037517000,

        [Display(Name = "[Altus Plateau - Abandoned Coffin] Fulgurbloom 1037517010")]
        AltusPlateauAbandonedCoffinFulgurbloom = 1037517010,

        [Display(Name = "[Altus Plateau - Abandoned Coffin] Ruler's Mask 1037517020")]
        AltusPlateauAbandonedCoffinRulersMask = 1037517020,

        [Display(Name = "[Mt. Gelmir - Seethewater River] Arrow 1037527020")]
        MtGelmirSeethewaterRiverArrow = 1037527020,

        [Display(Name = "[Mt. Gelmir - Seethewater River] Sacramental Bud 1037527030")]
        MtGelmirSeethewaterRiverSacramentalBud = 1037527030,

        [Display(Name = "[Mt. Gelmir - Seethewater River] String 1037527040")]
        MtGelmirSeethewaterRiverString = 1037527040,

        [Display(Name = "[Mt. Gelmir - Seethewater River] Gold-Tinged Excrement 1037527050")]
        MtGelmirSeethewaterRiverGoldTingedExcrement = 1037527050,

        [Display(Name = "[Mt. Gelmir - Seethewater River] Gold Firefly 1037527060")]
        MtGelmirSeethewaterRiverGoldFirefly = 1037527060,

        [Display(Name = "[Mt. Gelmir - Seethewater River] Prattling Pate \"You're beautiful\" 1037527070")]
        MtGelmirSeethewaterRiverPrattlingPateYourebeautiful = 1037527070,

        [Display(Name = "[Mt. Gelmir - Seethewater River] Starlight Shards 1037527080")]
        MtGelmirSeethewaterRiverStarlightShards = 1037527080,

        [Display(Name = "[Mt. Gelmir - Seethewater River] Hierodas Glintstone Crown 1037527090")]
        MtGelmirSeethewaterRiverHierodasGlintstoneCrown = 1037527090,

        [Display(Name = "[Mt. Gelmir - Seethewater River] Errant Sorcerer Manchettes 1037527100")]
        MtGelmirSeethewaterRiverErrantSorcererManchettes = 1037527100,

        [Display(Name = "[Mt. Gelmir - Primeval Sorcerer Azur] Mushroom 1037537000")]
        MtGelmirPrimevalSorcererAzurMushroom = 1037537000,

        [Display(Name = "[Mt. Gelmir - Primeval Sorcerer Azur] Golden Rune [6] 1037537010")]
        MtGelmirPrimevalSorcererAzurGoldenRune6 = 1037537010,

        [Display(Name = "[Mt. Gelmir - Primeval Sorcerer Azur] Smithing Stone [5] 1037537020")]
        MtGelmirPrimevalSorcererAzurSmithingStone5 = 1037537020,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Beast Blood 1037547000")]
        MtGelmirMinorErdtreeBeastBlood = 1037547000,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Stonesword Key 1037547010")]
        MtGelmirMinorErdtreeStoneswordKey = 1037547010,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Soporific Grease 1037547020")]
        MtGelmirMinorErdtreeSoporificGrease = 1037547020,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Herba 1037547030")]
        MtGelmirMinorErdtreeHerba = 1037547030,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Eye of Yelough 1037547040")]
        MtGelmirMinorErdtreeEyeOfYelough = 1037547040,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Golden Arrow 1037547050")]
        MtGelmirMinorErdtreeGoldenArrow = 1037547050,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Glass Shard 1037547060")]
        MtGelmirMinorErdtreeGlassShard = 1037547060,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Nascent Butterfly 1037547070")]
        MtGelmirMinorErdtreeNascentButterfly = 1037547070,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Rejuvenating Boluses 1037547080")]
        MtGelmirMinorErdtreeRejuvenatingBoluses = 1037547080,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Hefty Beast Bone 1037547090")]
        MtGelmirMinorErdtreeHeftyBeastBone = 1037547090,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Golden Rune [6] 1037547100")]
        MtGelmirMinorErdtreeGoldenRune6 = 1037547100,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Great Arrow 1037547110")]
        MtGelmirMinorErdtreeGreatArrow = 1037547110,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Fan Daggers 1037547120")]
        MtGelmirMinorErdtreeFanDaggers = 1037547120,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Drawstring Fire Grease 1037547130")]
        MtGelmirMinorErdtreeDrawstringFireGrease = 1037547130,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Golden Rune [4] 1037547140")]
        MtGelmirMinorErdtreeGoldenRune4 = 1037547140,

        [Display(Name = "[Mt. Gelmir - Minor Erdtree] Scavenger's Curved Sword 1037547150")]
        MtGelmirMinorErdtreeScavengersCurvedSword = 1037547150,

        [Display(Name = "[Mt. Gelmir - Volcano Cave Entrance] Poison Grease 1037557000")]
        MtGelmirVolcanoCaveEntrancePoisonGrease = 1037557000,

        [Display(Name = "[Altus Plateau - Lux Ruins] Nascent Butterfly 1038517000")]
        AltusPlateauLuxRuinsNascentButterfly = 1038517000,

        [Display(Name = "[Altus Plateau - Lux Ruins] String 1038517010")]
        AltusPlateauLuxRuinsString = 1038517010,

        [Display(Name = "[Altus Plateau - Lux Ruins] Lightningproof Dried Liver 1038517020")]
        AltusPlateauLuxRuinsLightningproofDriedLiver = 1038517020,

        [Display(Name = "[Altus Plateau - Lux Ruins] Greatshield Talisman 1038517030")]
        AltusPlateauLuxRuinsGreatshieldTalisman = 1038517030,

        [Display(Name = "[Altus Plateau - Lux Ruins] Lightningproof Dried Liver 1038517040")]
        AltusPlateauLuxRuinsLightningproofDriedLiver_ = 1038517040,

        [Display(Name = "[Altus Plateau - Lux Ruins] Ritual Sword Talisman 1038517050")]
        AltusPlateauLuxRuinsRitualSwordTalisman = 1038517050,

        [Display(Name = "[Altus Plateau - Lux Ruins] Lightning Grease 1038517060")]
        AltusPlateauLuxRuinsLightningGrease = 1038517060,

        [Display(Name = "[Altus Plateau - Lux Ruins] String 1038517070")]
        AltusPlateauLuxRuinsString_ = 1038517070,

        [Display(Name = "[Altus Plateau - Lux Ruins] Golden Rune [3] 1038517080")]
        AltusPlateauLuxRuinsGoldenRune3 = 1038517080,

        [Display(Name = "[Altus Plateau - Lux Ruins] Troll's Golden Sword 1038517090")]
        AltusPlateauLuxRuinsTrollsGoldenSword = 1038517090,

        [Display(Name = "[Altus Plateau - Wyndham Ruins] Pearldrake Talisman +1 1038527000")]
        AltusPlateauWyndhamRuinsPearldrakeTalisman1 = 1038527000,

        [Display(Name = "[Altus Plateau - Wyndham Ruins] Smithing Stone [5] 1038527010")]
        AltusPlateauWyndhamRuinsSmithingStone5 = 1038527010,

        [Display(Name = "[Altus Plateau - Wyndham Ruins] Golden Rune [3] 1038527020")]
        AltusPlateauWyndhamRuinsGoldenRune3 = 1038527020,

        [Display(Name = "[Altus Plateau - Wyndham Ruins] Golden Rune [7] 1038527030")]
        AltusPlateauWyndhamRuinsGoldenRune7 = 1038527030,

        [Display(Name = "[Altus Plateau - Wyndham Ruins] Dappled White Cured Meat 1038527040")]
        AltusPlateauWyndhamRuinsDappledWhiteCuredMeat = 1038527040,

        [Display(Name = "[Altus Plateau - Wyndham Ruins] Stormhawk Feather 1038527050")]
        AltusPlateauWyndhamRuinsStormhawkFeather = 1038527050,

        [Display(Name = "[Altus Plateau - Wyndham Ruins] Golden Rune [4] 1038527060")]
        AltusPlateauWyndhamRuinsGoldenRune4 = 1038527060,

        [Display(Name = "[Altus Plateau - Wyndham Ruins] Human Bone Shard 1038527070")]
        AltusPlateauWyndhamRuinsHumanBoneShard = 1038527070,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Golden Rune [2] 1038537000")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune2 = 1038537000,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Golden Rune [3] 1038537010")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune3 = 1038537010,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Golden Rune [4] 1038537020")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune4 = 1038537020,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Golden Rune [7] 1038537030")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune7 = 1038537030,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Golden Rune [3] 1038537040")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune3_ = 1038537040,

        [Display(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Somber Smithing Stone [6] 1038537050")]
        AltusPlateauOldAltusTunnelEntranceSomberSmithingStone6 = 1038537050,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Bloodrose 1038547000")]
        AltusPlateauWestOfShadedCastleBloodrose = 1038547000,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Explosive Greatbolt 1038547010")]
        AltusPlateauWestOfShadedCastleExplosiveGreatbolt = 1038547010,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Golden Rune [8] 1038547020")]
        AltusPlateauWestOfShadedCastleGoldenRune8 = 1038547020,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Fire Arrow 1038547030")]
        AltusPlateauWestOfShadedCastleFireArrow = 1038547030,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Golden Vow 1038547050")]
        AltusPlateauWestOfShadedCastleGoldenVow = 1038547050,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Arteria Leaf 1038547060")]
        AltusPlateauWestOfShadedCastleArteriaLeaf = 1038547060,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Throwing Dagger 1038547070")]
        AltusPlateauWestOfShadedCastleThrowingDagger = 1038547070,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Beast Blood 1038547080")]
        AltusPlateauWestOfShadedCastleBeastBlood = 1038547080,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Smithing Stone [5] 1038547090")]
        AltusPlateauWestOfShadedCastleSmithingStone5 = 1038547090,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Antspur Rapier 1038547100")]
        AltusPlateauWestOfShadedCastleAntspurRapier = 1038547100,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Pulley Bow 1038547110")]
        AltusPlateauWestOfShadedCastlePulleyBow = 1038547110,

        [Display(Name = "[Altus Plateau - West of Shaded Castle] Sacred Butchering Knife 1038547700")]
        AltusPlateauWestOfShadedCastleSacredButcheringKnife = 1038547700,

        [Display(Name = "[Altus Plateau - Golden Lineage Evergaol] Hefty Beast Bone 1039507000")]
        AltusPlateauGoldenLineageEvergaolHeftyBeastBone = 1039507000,

        [Display(Name = "[Altus Plateau - Golden Lineage Evergaol] Stonesword Key 1039507010")]
        AltusPlateauGoldenLineageEvergaolStoneswordKey = 1039507010,

        [Display(Name = "[Altus Plateau - Golden Lineage Evergaol] Golden Rune [4] 1039507020")]
        AltusPlateauGoldenLineageEvergaolGoldenRune4 = 1039507020,

        [Display(Name = "[Altus Plateau - Golden Lineage Evergaol] Godfrey Icon 1039507100")]
        AltusPlateauGoldenLineageEvergaolGodfreyIcon = 1039507100,

        [Display(Name = "[Altus Plateau - Altus Highway Junction] Perfume Bottle 66760")]
        AltusPlateauAltusHighwayJunctionPerfumeBottle = 66760,

        [Display(Name = "[Altus Plateau - Altus Highway Junction] Fan Daggers 1039517010")]
        AltusPlateauAltusHighwayJunctionFanDaggers = 1039517010,

        [Display(Name = "[Altus Plateau - Altus Highway Junction] Sacrificial Twig 1039517020")]
        AltusPlateauAltusHighwayJunctionSacrificialTwig = 1039517020,

        [Display(Name = "[Altus Plateau - Altus Highway Junction] Warming Stone 1039517030")]
        AltusPlateauAltusHighwayJunctionWarmingStone = 1039517030,

        [Display(Name = "[Altus Plateau - Altus Highway Junction] Turtle Neck Meat 1039517040")]
        AltusPlateauAltusHighwayJunctionTurtleNeckMeat = 1039517040,

        [Display(Name = "[Altus Plateau - Altus Highway Junction] Ash of War: Shared Order 1039517200")]
        AltusPlateauAltusHighwayJunctionAshOfWarSharedOrder = 1039517200,

        [Display(Name = "[Altus Plateau - Second Church of Marika] Human Bone Shard 1039527000")]
        AltusPlateauSecondChurchOfMarikaHumanBoneShard = 1039527000,

        [Display(Name = "[Altus Plateau - Second Church of Marika] Magic Grease 1039527020")]
        AltusPlateauSecondChurchOfMarikaMagicGrease = 1039527020,

        [Display(Name = "[Altus Plateau - Second Church of Marika] Eleonora's Poleblade 1039527700")]
        AltusPlateauSecondChurchOfMarikaEleonorasPoleblade = 1039527700,

        [Display(Name = "[Altus Plateau - Mirage Rise] Golden Rune [4] 1039537000")]
        AltusPlateauMirageRiseGoldenRune4 = 1039537000,

        [Display(Name = "[Altus Plateau - Mirage Rise] Blood Grease 1039537010")]
        AltusPlateauMirageRiseBloodGrease = 1039537010,

        [Display(Name = "[Altus Plateau - Mirage Rise] Golden Rune [3] 1039537020")]
        AltusPlateauMirageRiseGoldenRune3 = 1039537020,

        [Display(Name = "[Altus Plateau - Mirage Rise] Miquella's Lily 1039537030")]
        AltusPlateauMirageRiseMiquellasLily = 1039537030,

        [Display(Name = "[Altus Plateau - Mirage Rise] Nascent Butterfly 1039537040")]
        AltusPlateauMirageRiseNascentButterfly = 1039537040,

        [Display(Name = "[Altus Plateau - Mirage Rise] Unseen Blade 1039537050")]
        AltusPlateauMirageRiseUnseenBlade = 1039537050,

        [Display(Name = "[Altus Plateau - Mirage Rise] Slumbering Egg 1039537060")]
        AltusPlateauMirageRiseSlumberingEgg = 1039537060,

        [Display(Name = "[Altus Plateau - Mirage Rise] Golden Rune [3] 1039537070")]
        AltusPlateauMirageRiseGoldenRune3_ = 1039537070,

        [Display(Name = "[Altus Plateau - Mirage Rise] Mirage Riddle 1039537080")]
        AltusPlateauMirageRiseMirageRiddle = 1039537080,

        [Display(Name = "[Altus Plateau - Mirage Rise] Crepus's Vial 1039537700")]
        AltusPlateauMirageRiseCrepussVial = 1039537700,

        [Display(Name = "[Altus Plateau - Shaded Castle] Rot Grease 1039570000")]
        AltusPlateauShadedCastleRotGrease = 1039570000,

        [Display(Name = "[Altus Plateau - Shaded Castle] Golden Rune [3] 1039547010")]
        AltusPlateauShadedCastleGoldenRune3 = 1039547010,

        [Display(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [5] 1039547020")]
        AltusPlateauShadedCastleSmithingStone5 = 1039547020,

        [Display(Name = "[Altus Plateau - Shaded Castle] Poisonbloom 1039547030")]
        AltusPlateauShadedCastlePoisonbloom = 1039547030,

        [Display(Name = "[Altus Plateau - Shaded Castle] Perfume Bottle 66770")]
        AltusPlateauShadedCastlePerfumeBottle = 66770,

        [Display(Name = "[Altus Plateau - Shaded Castle] Poisonbone Dart 1039547050")]
        AltusPlateauShadedCastlePoisonboneDart = 1039547050,

        [Display(Name = "[Altus Plateau - Shaded Castle] Golden Rune [6] 1039547060")]
        AltusPlateauShadedCastleGoldenRune6 = 1039547060,

        [Display(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [4] 1039547070")]
        AltusPlateauShadedCastleSmithingStone4 = 1039547070,

        [Display(Name = "[Altus Plateau - Shaded Castle] Somber Smithing Stone [5] 1039547080")]
        AltusPlateauShadedCastleSomberSmithingStone5 = 1039547080,

        [Display(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [5] 1039547090")]
        AltusPlateauShadedCastleSmithingStone5_ = 1039547090,

        [Display(Name = "[Altus Plateau - Shaded Castle] Drawstring Fire Grease 1039547100")]
        AltusPlateauShadedCastleDrawstringFireGrease = 1039547100,

        [Display(Name = "[Altus Plateau - Shaded Castle] Golden Rune [6] 1039547110")]
        AltusPlateauShadedCastleGoldenRune6_ = 1039547110,

        [Display(Name = "[Altus Plateau - Shaded Castle] Beast Blood 1039547120")]
        AltusPlateauShadedCastleBeastBlood = 1039547120,

        [Display(Name = "[Altus Plateau - Shaded Castle] Neutralizing Boluses 1039547130")]
        AltusPlateauShadedCastleNeutralizingBoluses = 1039547130,

        [Display(Name = "[Altus Plateau - Shaded Castle] Glass Shard 1039547140")]
        AltusPlateauShadedCastleGlassShard = 1039547140,

        [Display(Name = "[Altus Plateau - Shaded Castle] Stonesword Key 1039547150")]
        AltusPlateauShadedCastleStoneswordKey = 1039547150,

        [Display(Name = "[Altus Plateau - Shaded Castle] Golden Rune [6] 1039547160")]
        AltusPlateauShadedCastleGoldenRune6__ = 1039547160,

        [Display(Name = "[Altus Plateau - Shaded Castle] Poison Grease 1039547170")]
        AltusPlateauShadedCastlePoisonGrease = 1039547170,

        [Display(Name = "[Altus Plateau - Shaded Castle] Hefty Beast Bone 1039547180")]
        AltusPlateauShadedCastleHeftyBeastBone = 1039547180,

        [Display(Name = "[Altus Plateau - Shaded Castle] Perfumer's Cookbook [2] 67850")]
        AltusPlateauShadedCastlePerfumersCookbook2 = 67850,

        [Display(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [5] 1039547200")]
        AltusPlateauShadedCastleSmithingStone5__ = 1039547200,

        [Display(Name = "[Altus Plateau - Shaded Castle] Gold Firefly 1039547210")]
        AltusPlateauShadedCastleGoldFirefly = 1039547210,

        [Display(Name = "[Altus Plateau - Shaded Castle] Glass Shard 1039547220")]
        AltusPlateauShadedCastleGlassShard_ = 1039547220,

        [Display(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [5] 1039547230")]
        AltusPlateauShadedCastleSmithingStone5___ = 1039547230,

        [Display(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [5] 1039547240")]
        AltusPlateauShadedCastleSmithingStone5____ = 1039547240,

        [Display(Name = "[Altus Plateau - Shaded Castle] Golden Rune [4] 1039547250")]
        AltusPlateauShadedCastleGoldenRune4 = 1039547250,

        [Display(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [4] 1039547260")]
        AltusPlateauShadedCastleSmithingStone4_ = 1039547260,

        [Display(Name = "[Altus Plateau - Shaded Castle] Valkyrie's Prosthesis 1039547300")]
        AltusPlateauShadedCastleValkyriesProsthesis = 1039547300,

        [Display(Name = "[Altus Plateau - Shaded Castle] Starlight Shards 1039547350")]
        AltusPlateauShadedCastleStarlightShards = 1039547350,

        [Display(Name = "[Altus Plateau - Southwest of Tree Sentinel Duo] Gravity Stone Fan 1040507000")]
        AltusPlateauSouthwestOfTreeSentinelDuoGravityStoneFan = 1040507000,

        [Display(Name = "[Altus Plateau - Stormcaller Church] Celestial Dew 1040517000")]
        AltusPlateauStormcallerChurchCelestialDew = 1040517000,

        [Display(Name = "[Altus Plateau - Stormcaller Church] Old Fang 1040517010")]
        AltusPlateauStormcallerChurchOldFang = 1040517010,

        [Display(Name = "[Altus Plateau - Stormcaller Church] Dragonbolt Blessing 1040517020")]
        AltusPlateauStormcallerChurchDragonboltBlessing = 1040517020,

        [Display(Name = "[Altus Plateau - Stormcaller Church] Beast Blood 1040517030")]
        AltusPlateauStormcallerChurchBeastBlood = 1040517030,

        [Display(Name = "[Altus Plateau - Stormcaller Church] Lightning Greatbolt 1040517040")]
        AltusPlateauStormcallerChurchLightningGreatbolt = 1040517040,

        [Display(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Amber Starlight 1040527000")]
        AltusPlateauForestSpanningGreatbridgeAmberStarlight = 1040527000,

        [Display(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Golden Rune [6] 1040527010")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune6 = 1040527010,

        [Display(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Golden Rune [6] 1040527020")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune6_ = 1040527020,

        [Display(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Golden Rune [4] 1040527030")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune4 = 1040527030,

        [Display(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Golden Rune [3] 1040527040")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune3 = 1040527040,

        [Display(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Golden Rune [4] 1040527050")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune4_ = 1040527050,

        [Display(Name = "[Altus Plateau - Writheblood Ruins] Golden Rune [5] 1040537000")]
        AltusPlateauWrithebloodRuinsGoldenRune5 = 1040537000,

        [Display(Name = "[Altus Plateau - Writheblood Ruins] Bloody Helice 1040537010")]
        AltusPlateauWrithebloodRuinsBloodyHelice = 1040537010,

        [Display(Name = "[Altus Plateau - Writheblood Ruins] Nascent Butterfly 1040537020")]
        AltusPlateauWrithebloodRuinsNascentButterfly = 1040537020,

        [Display(Name = "[Altus Plateau - Writheblood Ruins] Fulgurbloom 1040537030")]
        AltusPlateauWrithebloodRuinsFulgurbloom = 1040537030,

        [Display(Name = "[Altus Plateau - Writheblood Ruins] Golden Arrow 1040537040")]
        AltusPlateauWrithebloodRuinsGoldenArrow = 1040537040,

        [Display(Name = "[Altus Plateau - Writheblood Ruins] Lump of Flesh 1040537050")]
        AltusPlateauWrithebloodRuinsLumpOfFlesh = 1040537050,

        [Display(Name = "[Altus Plateau - Writheblood Ruins] Hefty Beast Bone 1040537060")]
        AltusPlateauWrithebloodRuinsHeftyBeastBone = 1040537060,

        [Display(Name = "[Altus Plateau - Road of Iniquity Side Path] Great Stars 1040547000")]
        AltusPlateauRoadOfIniquitySidePathGreatStars = 1040547000,

        [Display(Name = "[Altus Plateau - Road of Iniquity Side Path] Gravel Stone 1040547010")]
        AltusPlateauRoadOfIniquitySidePathGravelStone = 1040547010,

        [Display(Name = "[Altus Plateau - Road of Iniquity Side Path] Stimulating Boluses 1040547030")]
        AltusPlateauRoadOfIniquitySidePathStimulatingBoluses = 1040547030,

        [Display(Name = "[Altus Plateau - Road of Iniquity Side Path] Dragonwound Grease 1040547050")]
        AltusPlateauRoadOfIniquitySidePathDragonwoundGrease = 1040547050,

        [Display(Name = "[Altus Plateau - Road of Iniquity Side Path] Radiant Gold Mask 1040547090")]
        AltusPlateauRoadOfIniquitySidePathRadiantGoldMask = 1040547090,

        [Display(Name = "[Altus Plateau - West Windmill Pasture] Giant Rat Ashes 1040557000")]
        AltusPlateauWestWindmillPastureGiantRatAshes = 1040557000,

        [Display(Name = "[Altus Plateau - Tree Sentinel Duo] Golden Rune [3] 1041517000")]
        AltusPlateauTreeSentinelDuoGoldenRune3 = 1041517000,

        [Display(Name = "[Altus Plateau - Tree Sentinel Duo] Golden Rune [6] 1041517010")]
        AltusPlateauTreeSentinelDuoGoldenRune6 = 1041517010,

        [Display(Name = "[Altus Plateau - Tree Sentinel Duo] Silver-Pickled Fowl Foot 1041517020")]
        AltusPlateauTreeSentinelDuoSilverPickledFowlFoot = 1041517020,

        [Display(Name = "[Altus Plateau - Tree Sentinel Duo] Gravity Stone Chunk 1041517030")]
        AltusPlateauTreeSentinelDuoGravityStoneChunk = 1041517030,

        [Display(Name = "[Altus Plateau - Rampartside Path] Golden Rune [8] 1041527000")]
        AltusPlateauRampartsidePathGoldenRune8 = 1041527000,

        [Display(Name = "[Altus Plateau - Rampartside Path] Golden Rune [6] 1041527010")]
        AltusPlateauRampartsidePathGoldenRune6 = 1041527010,

        [Display(Name = "[Altus Plateau - Rampartside Path] Golden Rune [4] 1041527020")]
        AltusPlateauRampartsidePathGoldenRune4 = 1041527020,

        [Display(Name = "[Altus Plateau - Rampartside Path] Golden Rune [3] 1041527030")]
        AltusPlateauRampartsidePathGoldenRune3 = 1041527030,

        [Display(Name = "[Altus Plateau - Rampartside Path] Golden Rune [1] 1041527040")]
        AltusPlateauRampartsidePathGoldenRune1 = 1041527040,

        [Display(Name = "[Altus Plateau - Rampartside Path] Lump of Flesh 1041527070")]
        AltusPlateauRampartsidePathLumpOfFlesh = 1041527070,

        [Display(Name = "[Altus Plateau - Rampartside Path] Land Octopus Ovary 1041527080")]
        AltusPlateauRampartsidePathLandOctopusOvary = 1041527080,

        [Display(Name = "[Altus Plateau - Rampartside Path] Stonesword Key 1041527090")]
        AltusPlateauRampartsidePathStoneswordKey = 1041527090,

        [Display(Name = "[Altus Plateau - Woodfolk Ruins] Poisonbone Dart 1041537010")]
        AltusPlateauWoodfolkRuinsPoisonboneDart = 1041537010,

        [Display(Name = "[Altus Plateau - Woodfolk Ruins] Wrath of Gold 1041537020")]
        AltusPlateauWoodfolkRuinsWrathOfGold = 1041537020,

        [Display(Name = "[Altus Plateau - Woodfolk Ruins] Invigorating White Cured Meat 1041537030")]
        AltusPlateauWoodfolkRuinsInvigoratingWhiteCuredMeat = 1041537030,

        [Display(Name = "[Altus Plateau - Woodfolk Ruins] Beast Blood 1041537040")]
        AltusPlateauWoodfolkRuinsBeastBlood = 1041537040,

        [Display(Name = "[Altus Plateau - Woodfolk Ruins] Nomadic Warrior's Cookbook [19] 67070")]
        AltusPlateauWoodfolkRuinsNomadicWarriorsCookbook19 = 67070,

        [Display(Name = "[Altus Plateau - Woodfolk Ruins] Gravel Stone 1041537060")]
        AltusPlateauWoodfolkRuinsGravelStone = 1041537060,

        [Display(Name = "[Altus Plateau - Woodfolk Ruins] Soft Cotton 1041537070")]
        AltusPlateauWoodfolkRuinsSoftCotton = 1041537070,

        [Display(Name = "[Altus Plateau - Woodfolk Ruins] Icon Shield 1041537080")]
        AltusPlateauWoodfolkRuinsIconShield = 1041537080,

        [Display(Name = "[Altus Plateau - West Windmill Village] Poison Grease 1041547000")]
        AltusPlateauWestWindmillVillagePoisonGrease = 1041547000,

        [Display(Name = "[Altus Plateau - East Windmill Pasture] Twinned Knight Swords 1041557000")]
        AltusPlateauEastWindmillPastureTwinnedKnightSwords = 1041557000,

        [Display(Name = "[Altus Plateau - East Windmill Pasture] Raw Meat Dumpling 1041557010")]
        AltusPlateauEastWindmillPastureRawMeatDumpling = 1041557010,

        [Display(Name = "[Altus Plateau - East Windmill Pasture] Navy Hood 1041557020")]
        AltusPlateauEastWindmillPastureNavyHood = 1041557020,

        [Display(Name = "[Leyndell - South of Outer Wall Phantom Tree] Giant-Crusher 1042507000")]
        LeyndellSouthOfOuterWallPhantomTreeGiantCrusher = 1042507000,

        [Display(Name = "[Leyndell - South of Outer Wall Phantom Tree] Golden Seed 1042507020")]
        LeyndellSouthOfOuterWallPhantomTreeGoldenSeed = 1042507020,

        [Display(Name = "[Leyndell - Outer Wall Phantom Tree] Holy Grease 1042517000")]
        LeyndellOuterWallPhantomTreeHolyGrease = 1042517000,

        [Display(Name = "[Leyndell - Outer Wall Phantom Tree] Gargoyle's Great Axe 1042517900")]
        LeyndellOuterWallPhantomTreeGargoylesGreatAxe = 1042517900,

        [Display(Name = "[Leyndell - Southwest Outer Wall Battleground] Old Fang 1042527000")]
        LeyndellSouthwestOuterWallBattlegroundOldFang = 1042527000,

        [Display(Name = "[Leyndell - Southwest Outer Wall Battleground] Golden Rune [4] 1042527010")]
        LeyndellSouthwestOuterWallBattlegroundGoldenRune4 = 1042527010,

        [Display(Name = "[Leyndell - Southwest Outer Wall Battleground] Rainbow Stone 1042527020")]
        LeyndellSouthwestOuterWallBattlegroundRainbowStone = 1042527020,

        [Display(Name = "[Leyndell - Southwest Outer Wall Battleground] Golden Rune [10] 1042527030")]
        LeyndellSouthwestOuterWallBattlegroundGoldenRune10 = 1042527030,

        [Display(Name = "[Leyndell - Southwest Outer Wall Battleground] Arteria Leaf 1042527040")]
        LeyndellSouthwestOuterWallBattlegroundArteriaLeaf = 1042527040,

        [Display(Name = "[Leyndell - Northwest Outer Wall Battleground] Lightning Greatbolt 1042537000")]
        LeyndellNorthwestOuterWallBattlegroundLightningGreatbolt = 1042537000,

        [Display(Name = "[Leyndell - Northwest Outer Wall Battleground] Somber Smithing Stone [5] 1042537010")]
        LeyndellNorthwestOuterWallBattlegroundSomberSmithingStone5 = 1042537010,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Four-Toed Fowl Foot 1042547000")]
        AltusPlateauHighwayLookoutTowerFourToedFowlFoot = 1042547000,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Golden Rune [5] 1042547010")]
        AltusPlateauHighwayLookoutTowerGoldenRune5 = 1042547010,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Holyproof Dried Liver 1042547020")]
        AltusPlateauHighwayLookoutTowerHolyproofDriedLiver = 1042547020,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Stormhawk Feather 1042547030")]
        AltusPlateauHighwayLookoutTowerStormhawkFeather = 1042547030,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Hefty Beast Bone 1042547040")]
        AltusPlateauHighwayLookoutTowerHeftyBeastBone = 1042547040,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Golden Arrow 1042547050")]
        AltusPlateauHighwayLookoutTowerGoldenArrow = 1042547050,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Greatbow 1042547060")]
        AltusPlateauHighwayLookoutTowerGreatbow = 1042547060,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Gold Firefly 1042547070")]
        AltusPlateauHighwayLookoutTowerGoldFirefly = 1042547070,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Lightning Grease 1042547080")]
        AltusPlateauHighwayLookoutTowerLightningGrease = 1042547080,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Exalted Flesh 1042547090")]
        AltusPlateauHighwayLookoutTowerExaltedFlesh = 1042547090,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Rune Arc 1042547100")]
        AltusPlateauHighwayLookoutTowerRuneArc = 1042547100,

        [Display(Name = "[Altus Plateau - Windmill Heights] Celebrant's Skull 1042557000")]
        AltusPlateauWindmillHeightsCelebrantsSkull = 1042557000,

        [Display(Name = "[Leyndell - Minor Erdtree Church] Golden Order Seal 1043507000")]
        LeyndellMinorErdtreeChurchGoldenOrderSeal = 1043507000,

        [Display(Name = "[Leyndell - Minor Erdtree Church] Smoldering Butterfly 1043507010")]
        LeyndellMinorErdtreeChurchSmolderingButterfly = 1043507010,

        [Display(Name = "[Leyndell - Minor Erdtree Church] Missionary's Cookbook [4] 67640")]
        LeyndellMinorErdtreeChurchMissionarysCookbook4 = 67640,

        [Display(Name = "[Leyndell - Southeast Outer Wall Battleground] Lost Ashes of War 1043527000")]
        LeyndellSoutheastOuterWallBattlegroundLostAshesOfWar = 1043527000,

        [Display(Name = "[Leyndell - Southeast Outer Wall Battleground] Golden Rune [5] 1043527030")]
        LeyndellSoutheastOuterWallBattlegroundGoldenRune5 = 1043527030,

        [Display(Name = "[Leyndell - Southeast Outer Wall Battleground] Viridian Amber Medallion +1 1043527500")]
        LeyndellSoutheastOuterWallBattlegroundViridianAmberMedallion1 = 1043527500,

        [Display(Name = "[Leyndell - Northeast Outer Wall Battleground] Golden Rune [9] 1043537000")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune9 = 1043537000,

        [Display(Name = "[Leyndell - Northeast Outer Wall Battleground] Golden Rune [10] 1043537010")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune10 = 1043537010,

        [Display(Name = "[Leyndell - Northeast Outer Wall Battleground] Larval Tear 1043537100")]
        LeyndellNortheastOuterWallBattlegroundLarvalTear = 1043537100,

        [Display(Name = "[Leyndell - Northeast Outer Wall Battleground] Grace Mimic 1043537020")]
        LeyndellNortheastOuterWallBattlegroundGraceMimic = 1043537020,

        [Display(Name = "[Leyndell - Northeast Outer Wall Battleground] Drawstring Holy Grease 1043537030")]
        LeyndellNortheastOuterWallBattlegroundDrawstringHolyGrease = 1043537030,

        [Display(Name = "[Leyndell - Northeast Outer Wall Battleground] Smithing Stone [5] 1043537040")]
        LeyndellNortheastOuterWallBattlegroundSmithingStone5 = 1043537040,

        [Display(Name = "[Leyndell - Northeast Outer Wall Battleground] Golden Rune [5] 1043537050")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune5 = 1043537050,

        [Display(Name = "[Leyndell - Northeast Outer Wall Battleground] Golden Rune [7] 1043537060")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune7 = 1043537060,

        [Display(Name = "[Leyndell - Northeast Outer Wall Battleground] Mushroom 1043537070")]
        LeyndellNortheastOuterWallBattlegroundMushroom = 1043537070,

        [Display(Name = "[Leyndell - Northeast Outer Wall Battleground] Medicine Peddler's Bell Bearing 1043537400")]
        LeyndellNortheastOuterWallBattlegroundMedicinePeddlersBellBearing = 1043537400,

        [Display(Name = "[Leyndell - South of Minor Erdtree] Great Arrow 1044527000")]
        LeyndellSouthOfMinorErdtreeGreatArrow = 1044527000,

        [Display(Name = "[Leyndell - South of Minor Erdtree] Golden Rune [6] 1044527010")]
        LeyndellSouthOfMinorErdtreeGoldenRune6 = 1044527010,

        [Display(Name = "[Leyndell - South of Minor Erdtree] Golden Rune [2] 1044527020")]
        LeyndellSouthOfMinorErdtreeGoldenRune2 = 1044527020,

        [Display(Name = "[Leyndell - Minor Erdtree] Golden Rune [4] 1044537010")]
        LeyndellMinorErdtreeGoldenRune4 = 1044537010,

        [Display(Name = "[Leyndell - Capital Rampart] Gravity Stone Fan 1045527000")]
        LeyndellCapitalRampartGravityStoneFan = 1045527000,

        [Display(Name = "[Leyndell - Capital Rampart] Gravel Stone 1045527010")]
        LeyndellCapitalRampartGravelStone = 1045527010,

        [Display(Name = "[Leyndell - Capital Rampart] Smithing Stone [6] 1045527020")]
        LeyndellCapitalRampartSmithingStone6 = 1045527020,

        [Display(Name = "[Leyndell - Capital Rampart] Smithing Stone [5] 1045527030")]
        LeyndellCapitalRampartSmithingStone5 = 1045527030,

        [Display(Name = "[Leyndell - Minor Erdtree] Crimson Crystal Tear 65030")]
        LeyndellMinorErdtreeCrimsonCrystalTear = 65030,

        [Display(Name = "[Leyndell - Minor Erdtree] Twiggy Cracked Tear 65190")]
        LeyndellMinorErdtreeTwiggyCrackedTear = 65190,

        [Display(Name = "[Leyndell - Minor Erdtree] Winged Crystal Tear 65120")]
        LeyndellMinorErdtreeWingedCrystalTear = 65120,

        [Display(Name = "[Leyndell - Minor Erdtree] Twinbird Kite Shield 1044537300")]
        LeyndellMinorErdtreeTwinbirdKiteShield = 1044537300,

        [Display(Name = "[Altus Plateau - Lux Ruins] Golden Seed 1038517400")]
        AltusPlateauLuxRuinsGoldenSeed = 1038517400,

        [Display(Name = "[Altus Plateau - Altus Highway Junction] Golden Seed 1039517400")]
        AltusPlateauAltusHighwayJunctionGoldenSeed = 1039517400,

        [Display(Name = "[Altus Plateau - Second Church of Marika] Sacred Tear 1039527400")]
        AltusPlateauSecondChurchOfMarikaSacredTear = 1039527400,

        [Display(Name = "[Altus Plateau - West Windmill Village] Golden Seed 1041547400")]
        AltusPlateauWestWindmillVillageGoldenSeed = 1041547400,

        [Display(Name = "[Altus Plateau - Stormcaller Church] Sacred Tear 1040517400")]
        AltusPlateauStormcallerChurchSacredTear = 1040517400,

        [Display(Name = "[Leyndell - Outer Wall Phantom Tree] Golden Seed 1042517400")]
        LeyndellOuterWallPhantomTreeGoldenSeed = 1042517400,

        [Display(Name = "[Leyndell - Outer Wall Phantom Tree] Golden Seed 1042517410")]
        LeyndellOuterWallPhantomTreeGoldenSeed_ = 1042517410,

        [Display(Name = "[Altus Plateau - Highway Lookout Tower] Golden Seed 1042547400")]
        AltusPlateauHighwayLookoutTowerGoldenSeed = 1042547400,

        [Display(Name = "[Leyndell - Southeast Outer Wall Battleground] Golden Seed 1043527400")]
        LeyndellSoutheastOuterWallBattlegroundGoldenSeed = 1043527400,

        [Display(Name = "[Leyndell - Southeast Outer Wall Battleground] Golden Seed 1043527410")]
        LeyndellSoutheastOuterWallBattlegroundGoldenSeed_ = 1043527410,

        [Display(Name = "[Mt. Gelmir - Volcano Manor Entrance] Golden Seed 1036547400")]
        MtGelmirVolcanoManorEntranceGoldenSeed = 1036547400,

        [Display(Name = "[Mt. Gelmir - Primeval Sorcerer Azur] Golden Seed 1037537400")]
        MtGelmirPrimevalSorcererAzurGoldenSeed = 1037537400,

        [Display(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Map: Altus Plateau 62030")]
        AltusPlateauForestSpanningGreatbridgeMapAltusPlateau = 62030,

        [Display(Name = "[Leyndell - Outer Wall Phantom Tree] Map: Leyndell, Royal Capital 62031")]
        LeyndellOuterWallPhantomTreeMapLeyndellRoyalCapital = 62031,

        [Display(Name = "[Mt. Gelmir - Volcano Manor Entrance] Map: Mt. Gelmir 62032")]
        MtGelmirVolcanoManorEntranceMapMtGelmir = 62032,

        [Display(Name = "[Liurnia of the Lake - Northeast Ravine] Neutralizing Boluses 1037507000")]
        LiurniaOfTheLakeNortheastRavineNeutralizingBoluses = 1037507000,

        [Display(Name = "[Liurnia of the Lake - Northeast Ravine] Golden Seed 1037507100")]
        LiurniaOfTheLakeNortheastRavineGoldenSeed = 1037507100,

        [Display(Name = "[Leyndell - Divine Tower of East Altus Entrance] Drawstring Fire Grease 1047517000")]
        LeyndellDivineTowerOfEastAltusEntranceDrawstringFireGrease = 1047517000,

        [Display(Name = "[Leyndell - Divine Tower of East Altus Entrance] Golden Rune [7] 1047517010")]
        LeyndellDivineTowerOfEastAltusEntranceGoldenRune7 = 1047517010,

        [Display(Name = "[Leyndell - Divine Tower of East Altus Entrance] Dragonwound Grease 1047517300")]
        LeyndellDivineTowerOfEastAltusEntranceDragonwoundGrease = 1047517300,

        [Display(Name = "[Greyoll's Dragonbarrow - Isolated Merchant's Shack] Somber Smithing Stone [7] 1048517000")]
        GreyollsDragonbarrowIsolatedMerchantsShackSomberSmithingStone7 = 1048517000,

        [Display(Name = "[Greyoll's Dragonbarrow - Isolated Merchant's Shack] Ash of War: Phantom Slash 1048517700")]
        GreyollsDragonbarrowIsolatedMerchantsShackAshOfWarPhantomSlash = 1048517700,

        [Display(Name = "[Mountaintops of the Giants - Before Grand Lift of Rold] Freezing Grease 1049527000")]
        MountaintopsOfTheGiantsBeforeGrandLiftOfRoldFreezingGrease = 1049527000,

        [Display(Name = "[Mountaintops of the Giants - Before Grand Lift of Rold] Golden Seed 1049527800")]
        MountaintopsOfTheGiantsBeforeGrandLiftOfRoldGoldenSeed = 1049527800,

        [Display(Name = "[Mountaintops of the Giants - West Zamor Ruins] Sliver of Meat 1049537000")]
        MountaintopsOfTheGiantsWestZamorRuinsSliverOfMeat = 1049537000,

        [Display(Name = "[Mountaintops of the Giants - West Zamor Ruins] Invigorating Cured Meat 1049537010")]
        MountaintopsOfTheGiantsWestZamorRuinsInvigoratingCuredMeat = 1049537010,

        [Display(Name = "[Mountaintops of the Giants - West Zamor Ruins] Golden Rune [10] 1049537020")]
        MountaintopsOfTheGiantsWestZamorRuinsGoldenRune10 = 1049537020,

        [Display(Name = "[Mountaintops of the Giants - West Zamor Ruins] Zamor Ice Storm 1049537030")]
        MountaintopsOfTheGiantsWestZamorRuinsZamorIceStorm = 1049537030,

        [Display(Name = "[Mountaintops of the Giants - West Zamor Ruins] Beast Blood 1049537300")]
        MountaintopsOfTheGiantsWestZamorRuinsBeastBlood = 1049537300,

        [Display(Name = "[Mountaintops of the Giants - West Zamor Ruins] Map: Mountaintops of the Giants, West 62050")]
        MountaintopsOfTheGiantsWestZamorRuinsMapMountaintopsOfTheGiantsWest = 62050,

        [Display(Name = "[Mountaintops of the Giants - West Zamor Ruins] Smithing-Stone Miner's Bell Bearing [3] 1049537900")]
        MountaintopsOfTheGiantsWestZamorRuinsSmithingStoneMinersBellBearing3 = 1049537900,

        [Display(Name = "[Mountaintops of the Giants - East Zamor Ruins] Somber Smithing Stone [7] 1050537000")]
        MountaintopsOfTheGiantsEastZamorRuinsSomberSmithingStone7 = 1050537000,

        [Display(Name = "[Mountaintops of the Giants - East Zamor Ruins] Smoldering Butterfly 1050537300")]
        MountaintopsOfTheGiantsEastZamorRuinsSmolderingButterfly = 1050537300,

        [Display(Name = "[Mountaintops of the Giants - East Zamor Ruins] Somber Smithing Stone [7] 1050537700")]
        MountaintopsOfTheGiantsEastZamorRuinsSomberSmithingStone7_ = 1050537700,

        [Display(Name = "[Mountaintops of the Giants - North of Zamor Ruins] Lost Ashes of War 1050547000")]
        MountaintopsOfTheGiantsNorthOfZamorRuinsLostAshesOfWar = 1050547000,

        [Display(Name = "[Mountaintops of the Giants - North of Zamor Ruins] Arteria Leaf 1050547800")]
        MountaintopsOfTheGiantsNorthOfZamorRuinsArteriaLeaf = 1050547800,

        [Display(Name = "[Mountaintops of the Giants - North of Zamor Ruins] Briars of Punishment 1050547810")]
        MountaintopsOfTheGiantsNorthOfZamorRuinsBriarsOfPunishment = 1050547810,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Golden Rune [7] 1051557300")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsGoldenRune7 = 1051557300,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Drawstring Holy Grease 1051557310")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsDrawstringHolyGrease = 1051557310,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Rainbow Stone 1051557320")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsRainbowStone = 1051557320,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Golden Rune [13] 1051557330")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsGoldenRune13 = 1051557330,

        [Display(Name = "[Mountaintops of the Giants - Shack of the Lofty] Tarnished Golden Sunflower 1050567300")]
        MountaintopsOfTheGiantsShackOfTheLoftyTarnishedGoldenSunflower = 1050567300,

        [Display(Name = "[Mountaintops of the Giants - Shack of the Lofty] Warming Stone 1050567500")]
        MountaintopsOfTheGiantsShackOfTheLoftyWarmingStone = 1050567500,

        [Display(Name = "[Mountaintops of the Giants - Shack of the Lofty] Invigorating White Cured Meat 1050567510")]
        MountaintopsOfTheGiantsShackOfTheLoftyInvigoratingWhiteCuredMeat = 1050567510,

        [Display(Name = "[Mountaintops of the Giants - Shack of the Lofty] Smithing Stone [7] 1050567520")]
        MountaintopsOfTheGiantsShackOfTheLoftySmithingStone7 = 1050567520,

        [Display(Name = "[Mountaintops of the Giants - Shack of the Lofty] Ancient Dragon Smithing Stone 1050567600")]
        MountaintopsOfTheGiantsShackOfTheLoftyAncientDragonSmithingStone = 1050567600,

        [Display(Name = "[Mountaintops of the Giants - Shack of the Lofty] Traveling Maiden Hood 1050567620")]
        MountaintopsOfTheGiantsShackOfTheLoftyTravelingMaidenHood = 1050567620,

        [Display(Name = "[Mountaintops of the Giants - Shack of the Lofty] Hoslow's Petal Whip 1050567700")]
        MountaintopsOfTheGiantsShackOfTheLoftyHoslowsPetalWhip = 1050567700,

        [Display(Name = "[Mountaintops of the Giants - Shack of the Lofty] Smithing Stone [8] 1050567800")]
        MountaintopsOfTheGiantsShackOfTheLoftySmithingStone8 = 1050567800,

        [Display(Name = "[Mountaintops of the Giants - Shack of the Lofty] Graven-Mass Talisman 1050567820")]
        MountaintopsOfTheGiantsShackOfTheLoftyGravenMassTalisman = 1050567820,

        [Display(Name = "[Mountaintops of the Giants - Before Freezing Lake] Stimulating Boluses 1052577000")]
        MountaintopsOfTheGiantsBeforeFreezingLakeStimulatingBoluses = 1052577000,

        [Display(Name = "[Mountaintops of the Giants - Before Freezing Lake] Thawfrost Boluses 1052577300")]
        MountaintopsOfTheGiantsBeforeFreezingLakeThawfrostBoluses = 1052577300,

        [Display(Name = "[Mountaintops of the Giants - Before Freezing Lake] Old Fang 1052577310")]
        MountaintopsOfTheGiantsBeforeFreezingLakeOldFang = 1052577310,

        [Display(Name = "[Mountaintops of the Giants - Before Freezing Lake] Golden Seed 1052577800")]
        MountaintopsOfTheGiantsBeforeFreezingLakeGoldenSeed = 1052577800,

        [Display(Name = "[Mountaintops of the Giants - Before Freezing Lake] Smithing Stone [7] 1052577810")]
        MountaintopsOfTheGiantsBeforeFreezingLakeSmithingStone7 = 1052577810,

        [Display(Name = "[Mountaintops of the Giants - Northwest Freezing Lake] Golden Rune [11] 1053577300")]
        MountaintopsOfTheGiantsNorthwestFreezingLakeGoldenRune11 = 1053577300,

        [Display(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Somber Smithing Stone [8] 1053567300")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeSomberSmithingStone8 = 1053567300,

        [Display(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [10] 1053567310")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune10 = 1053567310,

        [Display(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [12] 1053567700")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune12 = 1053567700,

        [Display(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [12] 1053567710")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune12_ = 1053567710,

        [Display(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [12] 1053567720")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune12__ = 1053567720,

        [Display(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [7] 1053567800")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune7 = 1053567800,

        [Display(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [7] 1053567810")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune7_ = 1053567810,

        [Display(Name = "[Mountaintops of the Giants - Before Freezing Lake] Founding Rain of Stars 1052577900")]
        MountaintopsOfTheGiantsBeforeFreezingLakeFoundingRainOfStars = 1052577900,

        [Display(Name = "[Mountaintops of the Giants - First Church of Marika] Smithing Stone [7] 1054557000")]
        MountaintopsOfTheGiantsFirstChurchOfMarikaSmithingStone7 = 1054557000,

        [Display(Name = "[Mountaintops of the Giants - First Church of Marika] Somberstone Miner's Bell Bearing [3] 1054557310")]
        MountaintopsOfTheGiantsFirstChurchOfMarikaSomberstoneMinersBellBearing3 = 1054557310,

        [Display(Name = "[Mountaintops of the Giants - First Church of Marika] Sacred Tear 1054557800")]
        MountaintopsOfTheGiantsFirstChurchOfMarikaSacredTear = 1054557800,

        [Display(Name = "[Mountaintops of the Giants - Whiteridge Road] Explosive Greatbolt 1052567300")]
        MountaintopsOfTheGiantsWhiteridgeRoadExplosiveGreatbolt = 1052567300,

        [Display(Name = "[Mountaintops of the Giants - Whiteridge Road] Rune Arc 1052567310")]
        MountaintopsOfTheGiantsWhiteridgeRoadRuneArc = 1052567310,

        [Display(Name = "[Mountaintops of the Giants - Giants' Gravepost] Ancient Dragon Smithing Stone 1051537000")]
        MountaintopsOfTheGiantsGiantsGravepostAncientDragonSmithingStone = 1051537000,

        [Display(Name = "[Mountaintops of the Giants - Giants' Gravepost] Smithing Stone [7] 1051537010")]
        MountaintopsOfTheGiantsGiantsGravepostSmithingStone7 = 1051537010,

        [Display(Name = "[Mountaintops of the Giants - Giants' Gravepost] Drawstring Holy Grease 1051537300")]
        MountaintopsOfTheGiantsGiantsGravepostDrawstringHolyGrease = 1051537300,

        [Display(Name = "[Mountaintops of the Giants - Giants' Gravepost] Rivers of Blood 1051537500")]
        MountaintopsOfTheGiantsGiantsGravepostRiversOfBlood = 1051537500,

        [Display(Name = "[Mountaintops of the Giants - Giants' Gravepost] Ash of War: Troll's Roar 1051537600")]
        MountaintopsOfTheGiantsGiantsGravepostAshOfWarTrollsRoar = 1051537600,

        [Display(Name = "[Mountaintops of the Giants - Giants' Gravepost] Somber Smithing Stone [8] 1051537700")]
        MountaintopsOfTheGiantsGiantsGravepostSomberSmithingStone8 = 1051537700,

        [Display(Name = "[Mountaintops of the Giants - Giants' Gravepost] Sacred Tear 1051537800")]
        MountaintopsOfTheGiantsGiantsGravepostSacredTear = 1051537800,

        [Display(Name = "[Mountaintops of the Giants - Giants' Gravepost] Warming Stone 1051537810")]
        MountaintopsOfTheGiantsGiantsGravepostWarmingStone = 1051537810,

        [Display(Name = "[Mountaintops of the Giants - Giants' Gravepost] Invigorating White Cured Meat 1051547000")]
        MountaintopsOfTheGiantsGiantsGravepostInvigoratingWhiteCuredMeat = 1051547000,

        [Display(Name = "[Mountaintops of the Giants - Giants' Gravepost] Fan Daggers 1051547800")]
        MountaintopsOfTheGiantsGiantsGravepostFanDaggers = 1051547800,

        [Display(Name = "[Mountaintops of the Giants - Northwest Fire Giant Arena] Golden Rune [10] 1052537000")]
        MountaintopsOfTheGiantsNorthwestFireGiantArenaGoldenRune10 = 1052537000,

        [Display(Name = "[Mountaintops of the Giants - Northwest Fire Giant Arena] Golden Seed 1052537800")]
        MountaintopsOfTheGiantsNorthwestFireGiantArenaGoldenSeed = 1052537800,

        [Display(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Grace Mimic 1052547000")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostGraceMimic = 1052547000,

        [Display(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Golden Rune [10] 1052547010")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostGoldenRune10 = 1052547010,

        [Display(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Golden Rune [10] 1052547020")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostGoldenRune10_ = 1052547020,

        [Display(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Map: Mountaintops of the Giants, East 62051")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostMapMountaintopsOfTheGiantsEast = 62051,

        [Display(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Starlight Shards 1052547800")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostStarlightShards = 1052547800,

        [Display(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Crimsonwhorl Bubbletear 65200")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostCrimsonwhorlBubbletear = 65200,

        [Display(Name = "[Mountaintops of the Giants - Guardians' Garrison] Smoldering Butterfly 1052557000")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmolderingButterfly = 1052557000,

        [Display(Name = "[Mountaintops of the Giants - Guardians' Garrison] Smithing Stone [7] 1052557010")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmithingStone7 = 1052557010,

        [Display(Name = "[Mountaintops of the Giants - Guardians' Garrison] Golden Rune [10] 1052557020")]
        MountaintopsOfTheGiantsGuardiansGarrisonGoldenRune10 = 1052557020,

        [Display(Name = "[Mountaintops of the Giants - Guardians' Garrison] Smoldering Butterfly 1052557030")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmolderingButterfly_ = 1052557030,

        [Display(Name = "[Mountaintops of the Giants - Guardians' Garrison] Smithing Stone [7] 1052557040")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmithingStone7_ = 1052557040,

        [Display(Name = "[Mountaintops of the Giants - Guardians' Garrison] Golden Rune [8] 1052557300")]
        MountaintopsOfTheGiantsGuardiansGarrisonGoldenRune8 = 1052557300,

        [Display(Name = "[Mountaintops of the Giants - Guardians' Garrison] Stonesword Key 1052557310")]
        MountaintopsOfTheGiantsGuardiansGarrisonStoneswordKey = 1052557310,

        [Display(Name = "[Mountaintops of the Giants - Guardians' Garrison] One-Eyed Shield 1052557700")]
        MountaintopsOfTheGiantsGuardiansGarrisonOneEyedShield = 1052557700,

        [Display(Name = "[Mountaintops of the Giants - Guardians' Garrison] Gravel Stone 1052557800")]
        MountaintopsOfTheGiantsGuardiansGarrisonGravelStone = 1052557800,

        [Display(Name = "[Mountaintops of the Giants - Guardians' Garrison] Giant's Prayerbook 1052557900")]
        MountaintopsOfTheGiantsGuardiansGarrisonGiantsPrayerbook = 1052557900,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Somber Smithing Stone [9] 1051567020")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsSomberSmithingStone9 = 1051567020,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Freezing Grease 1051567030")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsFreezingGrease = 1051567030,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Formic Rock 1051567300")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsFormicRock = 1051567300,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Soft Cotton 1051567310")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsSoftCotton = 1051567310,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Golden Rune [10] 1051567320")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsGoldenRune10 = 1051567320,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Somber Smithing Stone [8] 1051567700")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsSomberSmithingStone8 = 1051567700,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Miquella's Lily 1051567800")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsMiquellasLily = 1051567800,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Miquella's Lily 1051567810")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsMiquellasLily_ = 1051567810,

        [Display(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Primal Glintstone Blade 1051567900")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsPrimalGlintstoneBlade = 1051567900,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Freezing Grease 1051577000")]
        MountaintopsOfTheGiantsSouthCastleSolFreezingGrease = 1051577000,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [10] 1051577010")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10 = 1051577010,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Smithing Stone [5] 1051577020")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone5 = 1051577020,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Fan Daggers 1051577030")]
        MountaintopsOfTheGiantsSouthCastleSolFanDaggers = 1051577030,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [10] 1051577040")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10_ = 1051577040,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [10] 1051577050")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10__ = 1051577050,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Nascent Butterfly 1051577060")]
        MountaintopsOfTheGiantsSouthCastleSolNascentButterfly = 1051577060,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Cerulean Amber Medallion +1 1051577070")]
        MountaintopsOfTheGiantsSouthCastleSolCeruleanAmberMedallion1 = 1051577070,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Smithing Stone [7] 1051577080")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone7 = 1051577080,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Smithing Stone [5] 1051577090")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone5_ = 1051577090,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Smithing Stone [6] 1051577100")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone6 = 1051577100,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Somber Smithing Stone [8] 1051577110")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone8 = 1051577110,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [10] 1051577120")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10___ = 1051577120,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Human Bone Shard 1051577130")]
        MountaintopsOfTheGiantsSouthCastleSolHumanBoneShard = 1051577130,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [11] 1051577140")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune11 = 1051577140,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Thawfrost Boluses 1051577150")]
        MountaintopsOfTheGiantsSouthCastleSolThawfrostBoluses = 1051577150,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Furlcalling Finger Remedy 1051577160")]
        MountaintopsOfTheGiantsSouthCastleSolFurlcallingFingerRemedy = 1051577160,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Smithing Stone [6] 1051577170")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone6_ = 1051577170,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Thawfrost Boluses 1051577180")]
        MountaintopsOfTheGiantsSouthCastleSolThawfrostBoluses_ = 1051577180,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Somber Smithing Stone [8] 1051577190")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone8_ = 1051577190,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [9] 1051577200")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune9 = 1051577200,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Rune Arc 1051577210")]
        MountaintopsOfTheGiantsSouthCastleSolRuneArc = 1051577210,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Stormhawk Axe 1051577220")]
        MountaintopsOfTheGiantsSouthCastleSolStormhawkAxe = 1051577220,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [10] 1051577230")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10____ = 1051577230,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Stonesword Key 1051577300")]
        MountaintopsOfTheGiantsSouthCastleSolStoneswordKey = 1051577300,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Eclipse Shotel 1051577600")]
        MountaintopsOfTheGiantsSouthCastleSolEclipseShotel = 1051577600,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Helphen's Steeple 1051577720")]
        MountaintopsOfTheGiantsSouthCastleSolHelphensSteeple = 1051577720,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Somber Smithing Stone [7] 1051577800")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone7 = 1051577800,

        [Display(Name = "[Mountaintops of the Giants - South Castle Sol] Somber Smithing Stone [7] 1051577810")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone7_ = 1051577810,

        [Display(Name = "[Mountaintops of the Giants - Northwest of Freezing Lake] Golden Rune [4] 1052587800")]
        MountaintopsOfTheGiantsNorthwestOfFreezingLakeGoldenRune4 = 1052587800,

        [Display(Name = "[Mountaintops of the Giants - Northwest of Freezing Lake] Golden Rune [5] 1052587810")]
        MountaintopsOfTheGiantsNorthwestOfFreezingLakeGoldenRune5 = 1052587810,

        [Display(Name = "[Mountaintops of the Giants - Northwest of Freezing Lake] Golden Rune [10] 1052587820")]
        MountaintopsOfTheGiantsNorthwestOfFreezingLakeGoldenRune10 = 1052587820,

        [Display(Name = "[Mountaintops of the Giants - North Castle Sol] Haligtree Secret Medallion (Left) 1051587800")]
        MountaintopsOfTheGiantsNorthCastleSolHaligtreeSecretMedallionLeft = 1051587800,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Smithing Stone [7] 1047557000")]
        ConsecratedSnowfieldYeloughAnixRuinsSmithingStone7 = 1047557000,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Rimed Rowa 1047557010")]
        ConsecratedSnowfieldYeloughAnixRuinsRimedRowa = 1047557010,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Golden Rune [13] 1047557020")]
        ConsecratedSnowfieldYeloughAnixRuinsGoldenRune13 = 1047557020,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Stonesword Key 1047557030")]
        ConsecratedSnowfieldYeloughAnixRuinsStoneswordKey = 1047557030,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Golden Rune [7] 1047557040")]
        ConsecratedSnowfieldYeloughAnixRuinsGoldenRune7 = 1047557040,

        [Display(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Unendurable Frenzy 1047557900")]
        ConsecratedSnowfieldYeloughAnixRuinsUnendurableFrenzy = 1047557900,

        [Display(Name = "[Consecrated Snowfield - North of Yelough Anix Ruins] Hero's Rune [2] 1047567300")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsHerosRune2 = 1047567300,

        [Display(Name = "[Consecrated Snowfield - North of Yelough Anix Ruins] Smithing Stone [8] 1047567310")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsSmithingStone8 = 1047567310,

        [Display(Name = "[Consecrated Snowfield - North of Yelough Anix Ruins] Thawfrost Boluses 1047567320")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsThawfrostBoluses = 1047567320,

        [Display(Name = "[Consecrated Snowfield - North of Yelough Anix Ruins] Crystal Dart 1047567330")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsCrystalDart = 1047567330,

        [Display(Name = "[Consecrated Snowfield - North of Yelough Anix Ruins] Sanguine Noble Hood 1047567700")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsSanguineNobleHood = 1047567700,

        [Display(Name = "[Consecrated Snowfield - Far West Cliffside] Golden Rune [1] 1046577300")]
        ConsecratedSnowfieldFarWestCliffsideGoldenRune1 = 1046577300,

        [Display(Name = "[Consecrated Snowfield - Far West Cliffside] Smithing Stone [7] 1046577800")]
        ConsecratedSnowfieldFarWestCliffsideSmithingStone7 = 1046577800,

        [Display(Name = "[Consecrated Snowfield - South of Ordina] Stonesword Key 1048567300")]
        ConsecratedSnowfieldSouthOfOrdinaStoneswordKey = 1048567300,

        [Display(Name = "[Consecrated Snowfield - South of Ordina] Map: Consecrated Snowfield 62052")]
        ConsecratedSnowfieldSouthOfOrdinaMapConsecratedSnowfield = 62052,

        [Display(Name = "[Consecrated Snowfield - South of Ordina] Somber Ancient Dragon Smithing Stone 1048567800")]
        ConsecratedSnowfieldSouthOfOrdinaSomberAncientDragonSmithingStone = 1048567800,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Rune Arc 1048577000")]
        ConsecratedSnowfieldOrdinaLiturgicalTownRuneArc = 1048577000,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Golden Rune [13] 1048577010")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune13 = 1048577010,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Hefty Beast Bone 1048577020")]
        ConsecratedSnowfieldOrdinaLiturgicalTownHeftyBeastBone = 1048577020,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Golden Rune [13] 1048577030")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune13_ = 1048577030,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Freezing Grease 1048577040")]
        ConsecratedSnowfieldOrdinaLiturgicalTownFreezingGrease = 1048577040,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Cuckoo Glintstone 1048577050")]
        ConsecratedSnowfieldOrdinaLiturgicalTownCuckooGlintstone = 1048577050,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Crystal Dart 1048577060")]
        ConsecratedSnowfieldOrdinaLiturgicalTownCrystalDart = 1048577060,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Old Fang 1048577070")]
        ConsecratedSnowfieldOrdinaLiturgicalTownOldFang = 1048577070,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Slumbering Egg 1048577080")]
        ConsecratedSnowfieldOrdinaLiturgicalTownSlumberingEgg = 1048577080,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Golden Rune [12] 1048577090")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune12 = 1048577090,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Invigorating Cured Meat 1048577300")]
        ConsecratedSnowfieldOrdinaLiturgicalTownInvigoratingCuredMeat = 1048577300,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Golden Rune [10] 1048577310")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune10 = 1048577310,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Explosive Ghostflame 1048577700")]
        ConsecratedSnowfieldOrdinaLiturgicalTownExplosiveGhostflame = 1048577700,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Golden Seed 1048577800")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenSeed = 1048577800,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Black Knife Hood 1048577810")]
        ConsecratedSnowfieldOrdinaLiturgicalTownBlackKnifeHood = 1048577810,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Ghost Glovewort [9] 1048577900")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9 = 1048577900,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Ghost Glovewort [9] 1048577910")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9_ = 1048577910,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Ghost Glovewort [9] 1048577920")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9__ = 1048577920,

        [Display(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Ghost Glovewort [9] 1048577930")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9___ = 1048577930,

        [Display(Name = "[Consecrated Snowfield - East of Apostate Derelict] Golden Rune [13] 1048587300")]
        ConsecratedSnowfieldEastOfApostateDerelictGoldenRune13 = 1048587300,

        [Display(Name = "[Consecrated Snowfield - Hidden Path to the Haligtree] Golden Rune [13] 1049547300")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeGoldenRune13 = 1049547300,

        [Display(Name = "[Consecrated Snowfield - Hidden Path to the Haligtree] Golden Rune [11] 1049547310")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeGoldenRune11 = 1049547310,

        [Display(Name = "[Consecrated Snowfield - Hidden Path to the Haligtree] Somber Smithing Stone [8] 1049547700")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeSomberSmithingStone8 = 1049547700,

        [Display(Name = "[Consecrated Snowfield - Hidden Path to the Haligtree] Nomadic Warrior's Cookbook [23] 67090")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeNomadicWarriorsCookbook23 = 67090,

        [Display(Name = "[Consecrated Snowfield - Hidden Path to the Haligtree] St. Trina's Torch 1049547900")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeStTrinasTorch = 1049547900,

        [Display(Name = "[Consecrated Snowfield - Southwest Foggy Area] Golden Rune [1] 1048547800")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune1 = 1048547800,

        [Display(Name = "[Consecrated Snowfield - Southwest Foggy Area] Golden Rune [3] 1048547810")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune3 = 1048547810,

        [Display(Name = "[Consecrated Snowfield - Southwest Foggy Area] Golden Rune [6] 1048547820")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune6 = 1048547820,

        [Display(Name = "[Consecrated Snowfield - Southwest Foggy Area] Golden Rune [9] 1048547830")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune9 = 1048547830,

        [Display(Name = "[Consecrated Snowfield - Southwest Foggy Area] Golden Rune [11] 1048547840")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune11 = 1048547840,

        [Display(Name = "[Consecrated Snowfield - Northwest Foggy Area] Golden Rune [13] 1048557300")]
        ConsecratedSnowfieldNorthwestFoggyAreaGoldenRune13 = 1048557300,

        [Display(Name = "[Consecrated Snowfield - Northwest Foggy Area] Stalwart Horn Charm +1 1048557600")]
        ConsecratedSnowfieldNorthwestFoggyAreaStalwartHornCharm1 = 1048557600,

        [Display(Name = "[Consecrated Snowfield - Northwest Foggy Area] Ancient Dragon Smithing Stone 1048557700")]
        ConsecratedSnowfieldNorthwestFoggyAreaAncientDragonSmithingStone = 1048557700,

        [Display(Name = "[Consecrated Snowfield - Northwest Foggy Area] Night's Cavalry Helm 1048557710")]
        ConsecratedSnowfieldNorthwestFoggyAreaNightsCavalryHelm = 1048557710,

        [Display(Name = "[Consecrated Snowfield - Northwest Foggy Area] Flowing Curved Sword 1048557900")]
        ConsecratedSnowfieldNorthwestFoggyAreaFlowingCurvedSword = 1048557900,

        [Display(Name = "[Consecrated Snowfield - Northeast Foggy Area] Somber Smithing Stone [9] 1049557300")]
        ConsecratedSnowfieldNortheastFoggyAreaSomberSmithingStone9 = 1049557300,

        [Display(Name = "[Consecrated Snowfield - Northeast Foggy Area] Old Fang 1049557310")]
        ConsecratedSnowfieldNortheastFoggyAreaOldFang = 1049557310,

        [Display(Name = "[Consecrated Snowfield - Northeast Foggy Area] Fire Blossom 1049557320")]
        ConsecratedSnowfieldNortheastFoggyAreaFireBlossom = 1049557320,

        [Display(Name = "[Consecrated Snowfield - Northeast Foggy Area] Miquella's Lily 1049557330")]
        ConsecratedSnowfieldNortheastFoggyAreaMiquellasLily = 1049557330,

        [Display(Name = "[Consecrated Snowfield - Northeast Foggy Area] Larval Tear 1049557700")]
        ConsecratedSnowfieldNortheastFoggyAreaLarvalTear = 1049557700,

        [Display(Name = "[Consecrated Snowfield - Northeast Foggy Area] Golden Seed 1049557800")]
        ConsecratedSnowfieldNortheastFoggyAreaGoldenSeed = 1049557800,

        [Display(Name = "[Consecrated Snowfield - Northeast Foggy Area] Golden Rune [11] 1049557810")]
        ConsecratedSnowfieldNortheastFoggyAreaGoldenRune11 = 1049557810,

        [Display(Name = "[Consecrated Snowfield - Southeast of Ordina] Albinauric Bloodclot 1049567300")]
        ConsecratedSnowfieldSoutheastOfOrdinaAlbinauricBloodclot = 1049567300,

        [Display(Name = "[Consecrated Snowfield - Southeast of Ordina] Old Fang 1049567310")]
        ConsecratedSnowfieldSoutheastOfOrdinaOldFang = 1049567310,

        [Display(Name = "[Consecrated Snowfield - Southeast of Ordina] Strip of White Flesh 1049567320")]
        ConsecratedSnowfieldSoutheastOfOrdinaStripOfWhiteFlesh = 1049567320,

        [Display(Name = "[Consecrated Snowfield - Southeast of Ordina] Dragonwound Grease 1049567330")]
        ConsecratedSnowfieldSoutheastOfOrdinaDragonwoundGrease = 1049567330,

        [Display(Name = "[Consecrated Snowfield - Southeast of Ordina] Nascent Butterfly 1049567340")]
        ConsecratedSnowfieldSoutheastOfOrdinaNascentButterfly = 1049567340,

        [Display(Name = "[Consecrated Snowfield - Southeast of Ordina] Smithing Stone [8] 1049567350")]
        ConsecratedSnowfieldSoutheastOfOrdinaSmithingStone8 = 1049567350,

        [Display(Name = "[Consecrated Snowfield - Southeast of Ordina] Glintstone Craftsman's Cookbook [8] 67440")]
        ConsecratedSnowfieldSoutheastOfOrdinaGlintstoneCraftsmansCookbook8 = 67440,

        [Display(Name = "[Consecrated Snowfield - East of Ordina] Somber Smithing Stone [7] 1049577700")]
        ConsecratedSnowfieldEastOfOrdinaSomberSmithingStone7 = 1049577700,

        [Display(Name = "[Consecrated Snowfield - East of Ordina] Somber Smithing Stone [8] 1049577710")]
        ConsecratedSnowfieldEastOfOrdinaSomberSmithingStone8 = 1049577710,

        [Display(Name = "[Consecrated Snowfield - East of Ordina] Somber Smithing Stone [9] 1049577720")]
        ConsecratedSnowfieldEastOfOrdinaSomberSmithingStone9 = 1049577720,

        [Display(Name = "[Mountaintops of the Giants - West of Castle Sol] Warming Stone 1050577300")]
        MountaintopsOfTheGiantsWestOfCastleSolWarmingStone = 1050577300,

        [Display(Name = "[Mountaintops of the Giants - West of Castle Sol] Starlight Shards 1050577800")]
        MountaintopsOfTheGiantsWestOfCastleSolStarlightShards = 1050577800,

        [Display(Name = "[Consecrated Snowfield - West of Ordina] Golden Rune [7] 1047577300")]
        ConsecratedSnowfieldWestOfOrdinaGoldenRune7 = 1047577300,

        [Display(Name = "[Consecrated Snowfield - West of Ordina] Golden Rune [12] 1047577310")]
        ConsecratedSnowfieldWestOfOrdinaGoldenRune12 = 1047577310,

        [Display(Name = "[Consecrated Snowfield - Apostate Derelict] Somber Smithing Stone [9] 1047587000")]
        ConsecratedSnowfieldApostateDerelictSomberSmithingStone9 = 1047587000,

        [Display(Name = "[Consecrated Snowfield - Apostate Derelict] Silver Mirrorshield 1047587800")]
        ConsecratedSnowfieldApostateDerelictSilverMirrorshield = 1047587800,

        [Display(Name = "[Consecrated Snowfield - Consecrated Snowfield Catacombs Entrance] Hefty Beast Bone 1050557300")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceHeftyBeastBone = 1050557300,

        [Display(Name = "[Consecrated Snowfield - Consecrated Snowfield Catacombs Entrance] Golden Rune [9] 1050557310")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceGoldenRune9 = 1050557310,

        [Display(Name = "[Consecrated Snowfield - Consecrated Snowfield Catacombs Entrance] Lump of Flesh 1050557320")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceLumpOfFlesh = 1050557320,

        [Display(Name = "[Consecrated Snowfield - Consecrated Snowfield Catacombs Entrance] Somber Smithing Stone [8] 1050557800")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceSomberSmithingStone8 = 1050557800,

        [Display(Name = "[Consecrated Snowfield - Consecrated Snowfield Catacombs Entrance] Rune Arc 1050557900")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceRuneArc = 1050557900,


    }
}
