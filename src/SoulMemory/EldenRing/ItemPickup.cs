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
    public enum ItemPickup : uint
    {
        [Annotation(Name = "Flask of Crimson Tears 60000")]
        FlaskOfCrimsonTears = 60000,

        [Annotation(Name = "Roped Fire Pot 500010")]
        RopedFirePot = 500010,

        [Annotation(Name = "Small Golden Effigy 60230")]
        SmallGoldenEffigy = 60230,

        [Annotation(Name = "Flask of Wondrous Physick 6700")]
        FlaskOfWondrousPhysick = 6700,

        [Annotation(Name = "Baldachin's Blessing 0")]
        BaldachinsBlessing = 0,

        [Annotation(Name = "Mending Rune of Perfect Order 9500")]
        MendingRuneOfPerfectOrder = 9500,

        [Annotation(Name = "Mending Rune of the Death-Prince 9502")]
        MendingRuneOfTheDeathPrince = 9502,

        [Annotation(Name = "Mending Rune of the Fell Curse 9504")]
        MendingRuneOfTheFellCurse = 9504,

        [Annotation(Name = "[Stormveil - Margit] Talisman Pouch 60510")]
        StormveilMargitTalismanPouch = 60510,

        [Annotation(Name = "[Stormveil - Godrick] Godrick's Great Rune 171")]
        StormveilGodrickGodricksGreatRune = 171,

        [Annotation(Name = "[Stormveil - Godrick] Remembrance of the Grafted 510010")]
        StormveilGodrickRemembranceOfTheGrafted = 510010,

        [Annotation(Name = "[Chapel of Anticipation - Grafed Scion] Ornamental Straight Sword 510030")]
        ChapelOfAnticipationGrafedScionOrnamentalStraightSword = 510030,

        [Annotation(Name = "[Leyndell - Morgott] Remembrance of the Omen King 510040")]
        LeyndellMorgottRemembranceOfTheOmenKing = 510040,

        [Annotation(Name = "[Leyndell - Morgott] Morgott's Great Rune 173")]
        LeyndellMorgottMorgottsGreatRune = 173,

        [Annotation(Name = "[Enia - 2 Great Runes] Talisman Pouch 60520")]
        Enia2GreatRunesTalismanPouch = 60520,

        [Annotation(Name = "[Ashen Leyndell - Gideon] Scepter of the All-Knowing 510060")]
        AshenLeyndellGideonScepterOfTheAllKnowing = 510060,

        [Annotation(Name = "[Ashen Leyndell - Hoarah Loux] Remembrance of Hoarah Loux 510070")]
        AshenLeyndellHoarahLouxRemembranceOfHoarahLoux = 510070,

        [Annotation(Name = "[Lake or Rot - Astel] Remembrance of the Naturalborn 510080")]
        LakeorRotAstelRemembranceOfTheNaturalborn = 510080,

        [Annotation(Name = "[Ainsel - Dragonkin Soldier] Frozen Lightning Spear 510090")]
        AinselDragonkinSoldierFrozenLightningSpear = 510090,

        [Annotation(Name = "[Siofra - Valiant Gargoyle] Gargoyle's Greatsword 510100")]
        SiofraValiantGargoyleGargoylesGreatsword = 510100,

        [Annotation(Name = "[Deeproot Depths - Fortissax] Remembrance of the Lichdragon 510110")]
        DeeprootDepthsFortissaxRemembranceOfTheLichdragon = 510110,

        [Annotation(Name = "[Mohgwyn Palace - Mohg] Remembrance of the Blood Lord 510120")]
        MohgwynPalaceMohgRemembranceOfTheBloodLord = 510120,

        [Annotation(Name = "[Mohgwyn Palace - Mohg] Mohg's Great Rune 175")]
        MohgwynPalaceMohgMohgsGreatRune = 175,

        [Annotation(Name = "[Farum Azula - Godskin Duo] Smithing-Stone Miner's Bell Bearing [4] 510140")]
        FarumAzulaGodskinDuoSmithingStoneMinersBellBearing4 = 510140,

        [Annotation(Name = "[Farum Azula - Dragonlord Placidusax] Remembrance of the Dragonlord 510150")]
        FarumAzulaDragonlordPlacidusaxRemembranceOfTheDragonlord = 510150,

        [Annotation(Name = "[Farum Azula - Maliketh] Remembrance of the Black Blade 510160")]
        FarumAzulaMalikethRemembranceOfTheBlackBlade = 510160,

        [Annotation(Name = "[Raya Lucaria - Red Wolf of Radagon] Memory Stone 60440")]
        RayaLucariaRedWolfOfRadagonMemoryStone = 60440,

        [Annotation(Name = "[Raya Lucaria - Rennala] Remembrance of the Full Moon Queen 197")]
        RayaLucariaRennalaRemembranceOfTheFullMoonQueen = 197,

        [Annotation(Name = "[Raya Lucaria - Rennala] None 177")]
        RayaLucariaRennalaNone = 177,

        [Annotation(Name = "[Haligtree - Loretta] Loretta's Mastery 510190")]
        HaligtreeLorettaLorettasMastery = 510190,

        [Annotation(Name = "[Haligtree - Malenia] Remembrance of the Rot Goddess 510200")]
        HaligtreeMaleniaRemembranceOfTheRotGoddess = 510200,

        [Annotation(Name = "[Haligtree - Malenia] Malenia's Great Rune 176")]
        HaligtreeMaleniaMaleniasGreatRune = 176,

        [Annotation(Name = "[Volcano Manor - Godskin Noble] Godskin Stitcher 510210")]
        VolcanoManorGodskinNobleGodskinStitcher = 510210,

        [Annotation(Name = "[Mt. Gelmir - Rykard] Remembrance of the Blasphemous 510220")]
        MtGelmirRykardRemembranceOfTheBlasphemous = 510220,

        [Annotation(Name = "[Mt. Gelmir - Rykard] Rykard's Great Rune 174")]
        MtGelmirRykardRykardsGreatRune = 174,

        [Annotation(Name = "[Erdtree - Elden Beast] Elden Remembrance 510230")]
        ErdtreeEldenBeastEldenRemembrance = 510230,

        [Annotation(Name = "[Mohgwyn Palace - Mohg] Bloodflame Talons 510250")]
        MohgwynPalaceMohgBloodflameTalons = 510250,

        [Annotation(Name = "[Ruin-Strewn Precipice - Magma Wyrm Makar] Magma Wyrm's Scalesword 510260")]
        RuinStrewnPrecipiceMagmaWyrmMakarMagmaWyrmsScalesword = 510260,

        [Annotation(Name = "[Fringefolk Hero's Grave - Ulcerated Tree Spirit] Golden Seed 510280")]
        FringefolkHerosGraveUlceratedTreeSpiritGoldenSeed = 510280,

        [Annotation(Name = "[Volcano Manor - Abducator Virgins] Inquisitor's Girandole 510290")]
        VolcanoManorAbducatorVirginsInquisitorsGirandole = 510290,

        [Annotation(Name = "[Caelid - Radahn] Remembrance of the Starscourge 510300")]
        CaelidRadahnRemembranceOfTheStarscourge = 510300,

        [Annotation(Name = "[Caelid - Radahn] Radahn's Great Rune 172")]
        CaelidRadahnRadahnsGreatRune = 172,

        [Annotation(Name = "[Mountaintops - Fire Giant] Remembrance of the Fire Giant 510310")]
        MountaintopsFireGiantRemembranceOfTheFireGiant = 510310,

        [Annotation(Name = "[Siofra - Ancestor Spirit] Ancestral Follower Ashes 510320")]
        SiofraAncestorSpiritAncestralFollowerAshes = 510320,

        [Annotation(Name = "[Nokron - Regal Ancestor Spirit] Remembrance of the Regal Ancestor 510330")]
        NokronRegalAncestorSpiritRemembranceOfTheRegalAncestor = 510330,

        [Annotation(Name = "[Nokron - Mimic Tear] Larval Tear 510340")]
        NokronMimicTearLarvalTear = 510340,

        [Annotation(Name = "[Deeproot Depths - Fia's Champions] Fia's Mist 510350")]
        DeeprootDepthsFiasChampionsFiasMist = 510350,

        [Annotation(Name = "[Mountaintops - Sanguine Noble] Sanguine Noble Hood 510730")]
        MountaintopsSanguineNobleSanguineNobleHood = 510730,

        [Annotation(Name = "[Capital Outskirts - Fell Twins] Omenkiller Rollo 510740")]
        CapitalOutskirtsFellTwinsOmenkillerRollo = 510740,

        [Annotation(Name = "[Weeping Penisula - Leonine Misbegotten] Blade Greatsword 510800")]
        WeepingPenisulaLeonineMisbegottenBladeGreatsword = 510800,

        [Annotation(Name = "[Caria Manor - Loretta] Loretta's Greatbow 510810")]
        CariaManorLorettaLorettasGreatbow = 510810,

        [Annotation(Name = "[Shaded Castle - Elemer of the Briar] Marais Executioner's Sword 510820")]
        ShadedCastleElemerOfTheBriarMaraisExecutionersSword = 510820,

        [Annotation(Name = "[Redmane Castle - Misbegotten Warrior/Crucible Knight] Ruins Greatsword 510830")]
        RedmaneCastleMisbegottenWarriorCrucibleKnightRuinsGreatsword = 510830,

        [Annotation(Name = "[Castle Sol - Commander Niall] Veteran's Prosthesis 510840")]
        CastleSolCommanderNiallVeteransProsthesis = 510840,

        [Annotation(Name = "[Tombsward Catacombs - Cemetery Shade] Lhutel the Headless 520000")]
        TombswardCatacombsCemeteryShadeLhutelTheHeadless = 520000,

        [Annotation(Name = "[Impaler's Catacombs - Erdtree Burial Watchdog] Demi-Human Ashes 520010")]
        ImpalersCatacombsErdtreeBurialWatchdogDemiHumanAshes = 520010,

        [Annotation(Name = "[Stormfoot Catacombs - Erdtree Burial Watchdog] Noble Sorcerer Ashes 520020")]
        StormfootCatacombsErdtreeBurialWatchdogNobleSorcererAshes = 520020,

        [Annotation(Name = "[Deathtouched Catacombs - Black Knife Assassin] Assassin's Crimson Dagger 520030")]
        DeathtouchedCatacombsBlackKnifeAssassinAssassinsCrimsonDagger = 520030,

        [Annotation(Name = "[Murkwater Catacombs - Grave Warden Duelist] Battle Hammer 520040")]
        MurkwaterCatacombsGraveWardenDuelistBattleHammer = 520040,

        [Annotation(Name = "[Black Knife Catacombs - Cemetery Shade] Twinsage Sorcerer Ashes 520050")]
        BlackKnifeCatacombsCemeteryShadeTwinsageSorcererAshes = 520050,

        [Annotation(Name = "[Road's End Catacombs - Spirit-caller Snail] Glintstone Sorcerer Ashes 520060")]
        RoadsEndCatacombsSpiritcallerSnailGlintstoneSorcererAshes = 520060,

        [Annotation(Name = "[Cliffbottom Catacombs - Erdtree Burial Watchdog] Kaiden Sellsword Ashes 520070")]
        CliffbottomCatacombsErdtreeBurialWatchdogKaidenSellswordAshes = 520070,

        [Annotation(Name = "[Sainted Hero's Grave - Leyndell] Ancient Dragon Knight Kristoff 520080")]
        SaintedHerosGraveLeyndellAncientDragonKnightKristoff = 520080,

        [Annotation(Name = "[Gelmir's Heo's Grave - Mt. Gelmir] Bloodhound Knight Floh 520090")]
        GelmirsHeosGraveMtGelmirBloodhoundKnightFloh = 520090,

        [Annotation(Name = "[Auriza Hero's Grave - Crucible Knigh Ordovis] Ordovis's Greatsword 520100")]
        AurizaHerosGraveCrucibleKnighOrdovisOrdovissGreatsword = 520100,

        [Annotation(Name = "[Unslightly Catacombs - Perfumer Tricia] Perfumer Tricia 520110")]
        UnslightlyCatacombsPerfumerTriciaPerfumerTricia = 520110,

        [Annotation(Name = "[Wyndham Catacombs - Erdtree Burial Watchdog] Glovewort Picker's Bell Bearing [1] 520120")]
        WyndhamCatacombsErdtreeBurialWatchdogGlovewortPickersBellBearing1 = 520120,

        [Annotation(Name = "[Auriza Side Tomb - Grave Warden Duelist] Soldjars of Fortune Ashes 520130")]
        AurizaSideTombGraveWardenDuelistSoldjarsOfFortuneAshes = 520130,

        [Annotation(Name = "[Minor Erdtree Catacombs - Erdtree Burial Watchdog] Mad Pumpkin Head Ashes 520140")]
        MinorErdtreeCatacombsErdtreeBurialWatchdogMadPumpkinHeadAshes = 520140,

        [Annotation(Name = "[Caelid Catacombs - Cemetery Shade] Kindred of Rot Ashes 520150")]
        CaelidCatacombsCemeteryShadeKindredOfRotAshes = 520150,

        [Annotation(Name = "[War-Dead Catacombs - Putrid Tree Spirit] Redmane Knight Ogha 520160")]
        WarDeadCatacombsPutridTreeSpiritRedmaneKnightOgha = 520160,

        [Annotation(Name = "[Giant-Conquering Hero's Grave - Ancient Hero of Zamor] Zamor Curved Sword 520170")]
        GiantConqueringHerosGraveAncientHeroOfZamorZamorCurvedSword = 520170,

        [Annotation(Name = "[Giants' Mountaintop Catacombs - Ulcerated Tree Spirit] Golden Seed 520180")]
        GiantsMountaintopCatacombsUlceratedTreeSpiritGoldenSeed = 520180,

        [Annotation(Name = "[Consecrated Snowfiled Catacombs - Putrid Grave Warden Duelist] Great Grave Glovewort 520190")]
        ConsecratedSnowfiledCatacombsPutridGraveWardenDuelistGreatGraveGlovewort = 520190,

        [Annotation(Name = "[Hidden Path ot the Haligtree - Stray Mimic Tear] Blackflame Monk Amon 520200")]
        HiddenPathotTheHaligtreeStrayMimicTearBlackflameMonkAmon = 520200,

        [Annotation(Name = "[Black Knife Catacombs - Black Knife Assassin] Assassin's Cerulean Dagger 520210")]
        BlackKnifeCatacombsBlackKnifeAssassinAssassinsCeruleanDagger = 520210,

        [Annotation(Name = "[Leyndell Catacombs - Esgar, Priest of Blood] Lord of Blood's Exultation 520220")]
        LeyndellCatacombsEsgarPriestOfBloodLordOfBloodsExultation = 520220,

        [Annotation(Name = "[Tombsward Cave - Miranda the Blighted Bloom] Viridian Amber Medallion 520300")]
        TombswardCaveMirandaTheBlightedBloomViridianAmberMedallion = 520300,

        [Annotation(Name = "[Earthbore Cave - Runebear] Spelldrake Talisman 520310")]
        EarthboreCaveRunebearSpelldrakeTalisman = 520310,

        [Annotation(Name = "[Groveside Cave - Beastman of Farum Azula] Flamedrake Talisman 520330")]
        GrovesideCaveBeastmanOfFarumAzulaFlamedrakeTalisman = 520330,

        [Annotation(Name = "[Coastal Cave - Demi-Human Chief] Sewing Needle 520340")]
        CoastalCaveDemiHumanChiefSewingNeedle = 520340,

        [Annotation(Name = "[Coastal Cave - Demi-Human Chief] Tailoring Tools 60140")]
        CoastalCaveDemiHumanChiefTailoringTools = 60140,

        [Annotation(Name = "[Highroad Cave - Guardian Golem] Blue Dancer Charm 520350")]
        HighroadCaveGuardianGolemBlueDancerCharm = 520350,

        [Annotation(Name = "[Stillwater Cave - Cleanrot Knight] Winged Sword Insignia 520360")]
        StillwaterCaveCleanrotKnightWingedSwordInsignia = 520360,

        [Annotation(Name = "[Lakeside Crystal Cave - Bloodhound Knight] Cerulean Amber Medallion 520370")]
        LakesideCrystalCaveBloodhoundKnightCeruleanAmberMedallion = 520370,

        [Annotation(Name = "[Academy Crystal Cave - Crystalians] Crystal Release 520380")]
        AcademyCrystalCaveCrystaliansCrystalRelease = 520380,

        [Annotation(Name = "[Seethewater Cave - Kindred of Rot] Kindred of Rot's Exultation 520390")]
        SeethewaterCaveKindredOfRotKindredOfRotsExultation = 520390,

        [Annotation(Name = "[Volcano Cave - Demi-human Queen Margot] Jar Cannon 520400")]
        VolcanoCaveDemihumanQueenMargotJarCannon = 520400,

        [Annotation(Name = "[Omenkiller - Perfumer's Grotto] Great Omenkiller Cleaver 520410")]
        OmenkillerPerfumersGrottoGreatOmenkillerCleaver = 520410,

        [Annotation(Name = "[Sage's Cave - Black Knife Assassin] Concealing Veil 520420")]
        SagesCaveBlackKnifeAssassinConcealingVeil = 520420,

        [Annotation(Name = "[Goal Cave - Frenzied Duelist] Putrid Corpse Ashes 520430")]
        GoalCaveFrenziedDuelistPutridCorpseAshes = 520430,

        [Annotation(Name = "[Dragonbarrow Cave - Beastman of Farum Azula] Flamedrake Talisman +2 520440")]
        DragonbarrowCaveBeastmanOfFarumAzulaFlamedrakeTalisman2 = 520440,

        [Annotation(Name = "[Abandoned Cave - Cleanrot Knight Duo] Gold Scarab 520450")]
        AbandonedCaveCleanrotKnightDuoGoldScarab = 520450,

        [Annotation(Name = "[Sellia Hideaway - Putrid Crystalians] Crystal Torrent 520460")]
        SelliaHideawayPutridCrystaliansCrystalTorrent = 520460,

        [Annotation(Name = "[Cave of the Forlorn - Misbegotten Crusader] Golden Order Greatsword 520470")]
        CaveOfTheForlornMisbegottenCrusaderGoldenOrderGreatsword = 520470,

        [Annotation(Name = "[Spiritcaller's Cave - Godskin Apostle/Noble] Godskin Swaddling Cloth 520480")]
        SpiritcallersCaveGodskinApostleNobleGodskinSwaddlingCloth = 520480,

        [Annotation(Name = "[Sage's Cave - Necromancer Garris] Family Heads 520490")]
        SagesCaveNecromancerGarrisFamilyHeads = 520490,

        [Annotation(Name = "[Morne Tunnel - Scaly Misbegotten] Rusted Anchor 520600")]
        MorneTunnelScalyMisbegottenRustedAnchor = 520600,

        [Annotation(Name = "[Limgrave Tunnels - Stonedigger Troll] Roar Medallion 520610")]
        LimgraveTunnelsStonediggerTrollRoarMedallion = 520610,

        [Annotation(Name = "[Raya Lucaria Crystal Tunnel - Crystalian] Smithing-Stone Miner's Bell Bearing [1] 520620")]
        RayaLucariaCrystalTunnelCrystalianSmithingStoneMinersBellBearing1 = 520620,

        [Annotation(Name = "[Old Altus Tunnel - Stonedigger Troll] Great Club 520630")]
        OldAltusTunnelStonediggerTrollGreatClub = 520630,

        [Annotation(Name = "[Sealed Tunnel - Onyx Lord] Onyx Lord's Greatsword 520640")]
        SealedTunnelOnyxLordOnyxLordsGreatsword = 520640,

        [Annotation(Name = "[Altus Tunnel - Crystalians] Somberstone Miner's Bell Bearing [2] 520650")]
        AltusTunnelCrystaliansSomberstoneMinersBellBearing2 = 520650,

        [Annotation(Name = "[Gael Tunnel - Magma Wyrm] Dragon Heart 520660")]
        GaelTunnelMagmaWyrmDragonHeart = 520660,

        [Annotation(Name = "[Sellia Crystal Tunnel - Fallingstar Beast] Somber Smithing Stone [6] 520670")]
        SelliaCrystalTunnelFallingstarBeastSomberSmithingStone6 = 520670,

        [Annotation(Name = "[Yelough Anix Tunnel - Astel] Meteorite of Astel 520680")]
        YeloughAnixTunnelAstelMeteoriteOfAstel = 520680,

        [Annotation(Name = "[Limgrave - Field - Tree Sentinel] Golden Halberd 530100")]
        LimgraveFieldTreeSentinelGoldenHalberd = 530100,

        [Annotation(Name = "[Limgrave - Field - Flying Dragon Agheel] Dragon Heart 530110")]
        LimgraveFieldFlyingDragonAgheelDragonHeart = 530110,

        [Annotation(Name = "[Limgrave - Evergaol - Crucible Knight] Aspects of the Crucible: Tail 530120")]
        LimgraveEvergaolCrucibleKnightAspectsOfTheCrucibleTail = 530120,

        [Annotation(Name = "[Limgrave - Evergaol - Bloodhound Knight Darriwil] Bloodhound's Fang 530130")]
        LimgraveEvergaolBloodhoundKnightDarriwilBloodhoundsFang = 530130,

        [Annotation(Name = "[Limgrave - Field - Tibia Mariner] Deathroot 530170")]
        LimgraveFieldTibiaMarinerDeathroot = 530170,

        [Annotation(Name = "[Weeping Penisula - Field - Erdtree Avatar] Crimsonburst Crystal Tear 65090")]
        WeepingPenisulaFieldErdtreeAvatarCrimsonburstCrystalTear = 65090,

        [Annotation(Name = "[Weeping Penisula - Field - Erdtree Avatar] Opaline Bubbletear 65080")]
        WeepingPenisulaFieldErdtreeAvatarOpalineBubbletear = 65080,

        [Annotation(Name = "[Liurnia - Field - Erdtree Avatar] Magic-Shrouding Cracked Tear 65290")]
        LiurniaFieldErdtreeAvatarMagicShroudingCrackedTear = 65290,

        [Annotation(Name = "[Liurnia - Field - Erdtree Avatar] Lightning-Shrouding Cracked Tear 65300")]
        LiurniaFieldErdtreeAvatarLightningShroudingCrackedTear = 65300,

        [Annotation(Name = "[Liurnia - Field - Erdtree Avatar] Holy-Shrouding Cracked Tear 65310")]
        LiurniaFieldErdtreeAvatarHolyShroudingCrackedTear = 65310,

        [Annotation(Name = "[Liurnia - Field - Erdtree Avatar] Cerulean Crystal Tear 65040")]
        LiurniaFieldErdtreeAvatarCeruleanCrystalTear = 65040,

        [Annotation(Name = "[Liurnia - Field - Erdtree Avatar] Ruptured Crystal Tear 65160")]
        LiurniaFieldErdtreeAvatarRupturedCrystalTear = 65160,

        [Annotation(Name = "[Liurnia - Field - Glintstone Dragon Smarag] Dragon Heart 530210")]
        LiurniaFieldGlintstoneDragonSmaragDragonHeart = 530210,

        [Annotation(Name = "[Liurnia - Field - Omenkiller] Crucible Knot Talisman 530225")]
        LiurniaFieldOmenkillerCrucibleKnotTalisman = 530225,

        [Annotation(Name = "[Liurnia - Field - Tibia Mariner] Deathroot 530240")]
        LiurniaFieldTibiaMarinerDeathroot = 530240,

        [Annotation(Name = "[Liurnia - Evergaol - Adan, Thief of Fire] Flame of the Fell God 530245")]
        LiurniaEvergaolAdanThiefOfFireFlameOfTheFellGod = 530245,

        [Annotation(Name = "[Liurnia - Evergaol - Bols, Carian Knight] Greatblade Phalanx 530250")]
        LiurniaEvergaolBolsCarianKnightGreatbladePhalanx = 530250,

        [Annotation(Name = "[Liurnia - Evergaol - Onyx Lord] Meteorite 530255")]
        LiurniaEvergaolOnyxLordMeteorite = 530255,

        [Annotation(Name = "[Liurnia - Field - Glintstone Dragon Adula] Dragon Heart 530260")]
        LiurniaFieldGlintstoneDragonAdulaDragonHeart = 530260,

        [Annotation(Name = "[Liurnia - Evergaol - Alecto, Black Knife Ringleader] Black Knife Tiche 530265")]
        LiurniaEvergaolAlectoBlackKnifeRingleaderBlackKnifeTiche = 530265,

        [Annotation(Name = "[Altus Plateau - Field - Ancient Dragon Lansseax] Lansseax's Glaive 530300")]
        AltusPlateauFieldAncientDragonLansseaxLansseaxsGlaive = 530300,

        [Annotation(Name = "[Altus Plateau - Field - Fallingstar Beast] Somber Smithing Stone [5] 530310")]
        AltusPlateauFieldFallingstarBeastSomberSmithingStone5 = 530310,

        [Annotation(Name = "[Capital Outskirts - Field - Draconic Tree Sentinel] Dragon Greatclaw 530315")]
        CapitalOutskirtsFieldDraconicTreeSentinelDragonGreatclaw = 530315,

        [Annotation(Name = "[Altus Plateau - Field - Wormface] Speckled Hardtear 65060")]
        AltusPlateauFieldWormfaceSpeckledHardtear = 65060,

        [Annotation(Name = "[Altus Plateau - Field - Wormface] Crimsonspill Crystal Tear 65000")]
        AltusPlateauFieldWormfaceCrimsonspillCrystalTear = 65000,

        [Annotation(Name = "[Altus Plateau - Field - Godskin Apostle] Godskin Peeler 530325")]
        AltusPlateauFieldGodskinApostleGodskinPeeler = 530325,

        [Annotation(Name = "[Capital Outskirts - Field - Tree Sentinel Duo] Erdtree Greatshield 530335")]
        CapitalOutskirtsFieldTreeSentinelDuoErdtreeGreatshield = 530335,

        [Annotation(Name = "[Altus Plateau - Field - Black Knife Assassin] Black Knife 530350")]
        AltusPlateauFieldBlackKnifeAssassinBlackKnife = 530350,

        [Annotation(Name = "[Mt. Gelmir - Field - Full-grown Fallingstar Beast] Somber Smithing Stone [6] 530375")]
        MtGelmirFieldFullgrownFallingstarBeastSomberSmithingStone6 = 530375,

        [Annotation(Name = "[Mt. Gelmir - Field - Ulcerated Tree Spirit] Leaden Hardtear 65180")]
        MtGelmirFieldUlceratedTreeSpiritLeadenHardtear = 65180,

        [Annotation(Name = "[Mt. Gelmir - Field - Ulcerated Tree Spirit] Cerulean Hidden Tear 65250")]
        MtGelmirFieldUlceratedTreeSpiritCeruleanHiddenTear = 65250,

        [Annotation(Name = "[Altus Plateau - Field - Tibia Mariner] Deathroot 530385")]
        AltusPlateauFieldTibiaMarinerDeathroot = 530385,

        [Annotation(Name = "[Mt. Gelmir - Field - Magma Wyrm] Dragon Heart 530390")]
        MtGelmirFieldMagmaWyrmDragonHeart = 530390,

        [Annotation(Name = "[Mt. Gelmir - Field - Demi-Human Queen Maggie] Memory Stone 60450")]
        MtGelmirFieldDemiHumanQueenMaggieMemoryStone = 60450,

        [Annotation(Name = "[Mt. Gelmir - Field - Magma Wyrm] Dragon Heart 530400")]
        MtGelmirFieldMagmaWyrmDragonHeart_ = 530400,

        [Annotation(Name = "[Caelid - Field - Commander O'Neil] Commander's Standard 530405")]
        CaelidFieldCommanderONeilCommandersStandard = 530405,

        [Annotation(Name = "[Caelid - Field - Erdtree Avatar] Greenburst Crystal Tear 65100")]
        CaelidFieldErdtreeAvatarGreenburstCrystalTear = 65100,

        [Annotation(Name = "[Caelid - Field - Erdtree Avatar] Flame-Shrouding Cracked Tear 65280")]
        CaelidFieldErdtreeAvatarFlameShroudingCrackedTear = 65280,

        [Annotation(Name = "[Caelid - Field - Putrid Avatar] Opaline Hardtear 65110")]
        CaelidFieldPutridAvatarOpalineHardtear = 65110,

        [Annotation(Name = "[Caelid - Field - Putrid Avatar] Stonebarb Cracked Tear 65260")]
        CaelidFieldPutridAvatarStonebarbCrackedTear = 65260,

        [Annotation(Name = "[Caelid - Field - Flying Dragon Greyll] Dragon Heart 530420")]
        CaelidFieldFlyingDragonGreyllDragonHeart = 530420,

        [Annotation(Name = "[Caelid - Field - Blade Blade Kindred] Gargoyle's Blackblade 530425")]
        CaelidFieldBladeBladeKindredGargoylesBlackblade = 530425,

        [Annotation(Name = "[Forbidden Lands - Field - Black Blade Kindred] Gargoyle's Black Blades 530505")]
        ForbiddenLandsFieldBlackBladeKindredGargoylesBlackBlades = 530505,

        [Annotation(Name = "[Mountaintops of the Giants - Field - Borealis, the Freezing Fog] Dragon Heart 530510")]
        MountaintopsOfTheGiantsFieldBorealisTheFreezingFogDragonHeart = 530510,

        [Annotation(Name = "[Mountaintops of the Giants - Evergaol - Roundtable Knight Vyke] Vyke's Dragonbolt 530515")]
        MountaintopsOfTheGiantsEvergaolRoundtableKnightVykeVykesDragonbolt = 530515,

        [Annotation(Name = "[Mountaintops of the Giants - Field - Erdtree Avatar] Cerulean Crystal Tear 65050")]
        MountaintopsOfTheGiantsFieldErdtreeAvatarCeruleanCrystalTear = 65050,

        [Annotation(Name = "[Mountaintops of the Giants - Field - Erdtree Avatar] Crimson Bubbletear 65070")]
        MountaintopsOfTheGiantsFieldErdtreeAvatarCrimsonBubbletear = 65070,

        [Annotation(Name = "[Mountaintops of the Giants - Field - Death Rite Bird] Death Ritual Spear 530530")]
        MountaintopsOfTheGiantsFieldDeathRiteBirdDeathRitualSpear = 530530,

        [Annotation(Name = "[Mountaintops of the Giants - Field - Great Wyrm Theodorix] Dragon Heart 530550")]
        MountaintopsOfTheGiantsFieldGreatWyrmTheodorixDragonHeart = 530550,

        [Annotation(Name = "[Consecrated Snowfield - Field - Putrid Avatar] Thorny Cracked Tear 65130")]
        ConsecratedSnowfieldFieldPutridAvatarThornyCrackedTear = 65130,

        [Annotation(Name = "[Consecrated Snowfield - Field - Putrid Avatar] Ruptured Crystal Tear 65170")]
        ConsecratedSnowfieldFieldPutridAvatarRupturedCrystalTear = 65170,

        [Annotation(Name = "[Lake of Rot - Dragonkin Soldier] Dragonscale Blade 530600")]
        LakeOfRotDragonkinSoldierDragonscaleBlade = 530600,

        [Annotation(Name = "[Siofra River - Dragonkin Soldier] Dragon Halberd 530620")]
        SiofraRiverDragonkinSoldierDragonHalberd = 530620,

        [Annotation(Name = "[Teardrop Scarab - Stormhill] Ash of War: Storm Wall 540100")]
        TeardropScarabStormhillAshOfWarStormWall = 540100,

        [Annotation(Name = "[Teardrop Scarab - Stormhill] Ash of War: Wild Strikes 540104")]
        TeardropScarabStormhillAshOfWarWildStrikes = 540104,

        [Annotation(Name = "[Teardrop Scarab - Agheel Lake] Ash of War: Determination 540108")]
        TeardropScarabAgheelLakeAshOfWarDetermination = 540108,

        [Annotation(Name = "[Teardrop Scarab - Agheel Lake] Ash of War: Unsheathe 540112")]
        TeardropScarabAgheelLakeAshOfWarUnsheathe = 540112,

        [Annotation(Name = "[Teardrop Scarab - Mistwood] Ash of War: Ground Slam 540116")]
        TeardropScarabMistwoodAshOfWarGroundSlam = 540116,

        [Annotation(Name = "[Teardrop Scarab - Third Chuch of Marika] Ash of War: Sacred Blade 540118")]
        TeardropScarabThirdChuchOfMarikaAshOfWarSacredBlade = 540118,

        [Annotation(Name = "[Teardrop Scarab - Limgrave Coast] Ash of War: Stamp (Sweep) 540120")]
        TeardropScarabLimgraveCoastAshOfWarStampSweep = 540120,

        [Annotation(Name = "[Teardrop Scarab - Weeping Peninsula] Divine Fortification 540132")]
        TeardropScarabWeepingPeninsulaDivineFortification = 540132,

        [Annotation(Name = "[Teardrop Scarab - Weeping Peninsula] Lightning Strike 540136")]
        TeardropScarabWeepingPeninsulaLightningStrike = 540136,

        [Annotation(Name = "[Teardrop Scarab - Weeping Peninsula] Poison Mist 540138")]
        TeardropScarabWeepingPeninsulaPoisonMist = 540138,

        [Annotation(Name = "[Teardrop Scarab - Weeping Peninsula] Ash of War: Mighty Shot 540140")]
        TeardropScarabWeepingPeninsulaAshOfWarMightyShot = 540140,

        [Annotation(Name = "[Teardrop Scarab - Limgrave] Somber Smithing Stone [1] 540142")]
        TeardropScarabLimgraveSomberSmithingStone1 = 540142,

        [Annotation(Name = "[Teardrop Scarab - Limgrave] Somber Smithing Stone [1] 540144")]
        TeardropScarabLimgraveSomberSmithingStone1_ = 540144,

        [Annotation(Name = "[Teardrop Scarab - Limgrave] Somber Smithing Stone [1] 540146")]
        TeardropScarabLimgraveSomberSmithingStone1__ = 540146,

        [Annotation(Name = "[Teardrop Scarab - Stormveil Castle] Ash of War: Storm Assault 540170")]
        TeardropScarabStormveilCastleAshOfWarStormAssault = 540170,

        [Annotation(Name = "[Teardrop Scarab - Stormveil Castle] Ash of War: Stormcaller 540172")]
        TeardropScarabStormveilCastleAshOfWarStormcaller = 540172,

        [Annotation(Name = "[Teardrop Scarab - Stormveil Castle] Rancorcall 540174")]
        TeardropScarabStormveilCastleRancorcall = 540174,

        [Annotation(Name = "[Teardrop Scarab - Three Sisters] Ash of War: Chilling Mist 540200")]
        TeardropScarabThreeSistersAshOfWarChillingMist = 540200,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Ash of War: Charge Forth 540202")]
        TeardropScarabLiurniaAshOfWarChargeForth = 540202,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Ash of War: Hoarfrost Stomp 540204")]
        TeardropScarabLiurniaAshOfWarHoarfrostStomp = 540204,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Ash of War: Thops's Barrier 540206")]
        TeardropScarabLiurniaAshOfWarThopssBarrier = 540206,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Ash of War: Vow of the Indomitable 540208")]
        TeardropScarabLiurniaAshOfWarVowOfTheIndomitable = 540208,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Ash of War: Shield Bash 540210")]
        TeardropScarabLiurniaAshOfWarShieldBash = 540210,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Bloodflame Blade 540218")]
        TeardropScarabLiurniaBloodflameBlade = 540218,

        [Annotation(Name = "[Teardrop Scarab - Caria Manor] Carian Piercer 540220")]
        TeardropScarabCariaManorCarianPiercer = 540220,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Ash of War: Barbaric Roar 540224")]
        TeardropScarabLiurniaAshOfWarBarbaricRoar = 540224,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Frenzied Burst 540236")]
        TeardropScarabLiurniaFrenziedBurst = 540236,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Ash of War: Sword Dance 540238")]
        TeardropScarabLiurniaAshOfWarSwordDance = 540238,

        [Annotation(Name = "[Teardrop Scarab - Caria Manor] Frozen Armament 540250")]
        TeardropScarabCariaManorFrozenArmament = 540250,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [2] 540252")]
        TeardropScarabLiurniaSomberSmithingStone2 = 540252,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [2] 540254")]
        TeardropScarabLiurniaSomberSmithingStone2_ = 540254,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [3] 540256")]
        TeardropScarabLiurniaSomberSmithingStone3 = 540256,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [3] 540258")]
        TeardropScarabLiurniaSomberSmithingStone3_ = 540258,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [2] 540260")]
        TeardropScarabLiurniaSomberSmithingStone2__ = 540260,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [2] 540262")]
        TeardropScarabLiurniaSomberSmithingStone2___ = 540262,

        [Annotation(Name = "[Teardrop Scarab - Liurnia] Somber Smithing Stone [2] 540264")]
        TeardropScarabLiurniaSomberSmithingStone2____ = 540264,

        [Annotation(Name = "[Teardrop Scarab - Raya Lucaria Academy] Ash of War: Spectral Lance 540272")]
        TeardropScarabRayaLucariaAcademyAshOfWarSpectralLance = 540272,

        [Annotation(Name = "[Teardrop Scarab - Raya Lucaria Academy] Somber Smithing Stone [4] 540290")]
        TeardropScarabRayaLucariaAcademySomberSmithingStone4 = 540290,

        [Annotation(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Sacred Order 540300")]
        TeardropScarabAltusPlateauAshOfWarSacredOrder = 540300,

        [Annotation(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Shield Crash 540302")]
        TeardropScarabAltusPlateauAshOfWarShieldCrash = 540302,

        [Annotation(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Earthshaker 540304")]
        TeardropScarabAltusPlateauAshOfWarEarthshaker = 540304,

        [Annotation(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Blood Blade 540306")]
        TeardropScarabAltusPlateauAshOfWarBloodBlade = 540306,

        [Annotation(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Golden Slam 540308")]
        TeardropScarabAltusPlateauAshOfWarGoldenSlam = 540308,

        [Annotation(Name = "[Teardrop Scarab - Altus Plateau] Ash of War: Lightning Ram 540310")]
        TeardropScarabAltusPlateauAshOfWarLightningRam = 540310,

        [Annotation(Name = "[Teardrop Scarab - Altus Plateau] Protection of the Erdtree 540312")]
        TeardropScarabAltusPlateauProtectionOfTheErdtree = 540312,

        [Annotation(Name = "[Teardrop Scarab - Capital Outskirts] Ash of War: Prayerful Strike 540314")]
        TeardropScarabCapitalOutskirtsAshOfWarPrayerfulStrike = 540314,

        [Annotation(Name = "[Teardrop Scarab - Capital Outskirts] Ash of War: Golden Parry 540316")]
        TeardropScarabCapitalOutskirtsAshOfWarGoldenParry = 540316,

        [Annotation(Name = "[Teardrop Scarab - Capital Outskirts] Ash of War: Lightning Slash 540318")]
        TeardropScarabCapitalOutskirtsAshOfWarLightningSlash = 540318,

        [Annotation(Name = "[Teardrop Scarab - Capital Outskirts] Somber Smithing Stone [5] 540320")]
        TeardropScarabCapitalOutskirtsSomberSmithingStone5 = 540320,

        [Annotation(Name = "[Teardrop Scarab - Mt. Gelmir] Ash of War: Barrage 540332")]
        TeardropScarabMtGelmirAshOfWarBarrage = 540332,

        [Annotation(Name = "[Teardrop Scarab - Mt. Gelmir] Ash of War: Through and Through 540334")]
        TeardropScarabMtGelmirAshOfWarThroughandThrough = 540334,

        [Annotation(Name = "[Teardrop Scarab - Leyndell] Barrier of Gold 540370")]
        TeardropScarabLeyndellBarrierOfGold = 540370,

        [Annotation(Name = "[Teardrop Scarab - Leyndell] Ash of War: Thunderbolt 540372")]
        TeardropScarabLeyndellAshOfWarThunderbolt = 540372,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Whirl, O Flame! 540400")]
        TeardropScarabCaelidWhirlOFlame = 540400,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Ash of War: Lifesteal Fist 540402")]
        TeardropScarabCaelidAshOfWarLifestealFist = 540402,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Ash of War: Sacred Ring of Light 540404")]
        TeardropScarabCaelidAshOfWarSacredRingOfLight = 540404,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Ash of War: Poisonous Mist 540406")]
        TeardropScarabCaelidAshOfWarPoisonousMist = 540406,

        [Annotation(Name = "[Teardrop Scarab - Redmane Castle] Ash of War: Flaming Strike 540408")]
        TeardropScarabRedmaneCastleAshOfWarFlamingStrike = 540408,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Ash of War: Flame of the Redmanes 540410")]
        TeardropScarabCaelidAshOfWarFlameOfTheRedmanes = 540410,

        [Annotation(Name = "[Teardrop Scarab - Dragonbarrow] Ash of War: Sky Shot 540412")]
        TeardropScarabDragonbarrowAshOfWarSkyShot = 540412,

        [Annotation(Name = "[Teardrop Scarab - Dragonbarrow] Ash of War: Cragblade 540414")]
        TeardropScarabDragonbarrowAshOfWarCragblade = 540414,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Poison Armament 540416")]
        TeardropScarabCaelidPoisonArmament = 540416,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Ash of War: Double Slash 540418")]
        TeardropScarabCaelidAshOfWarDoubleSlash = 540418,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Bestial Constitution 540420")]
        TeardropScarabCaelidBestialConstitution = 540420,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Somber Smithing Stone [4] 540422")]
        TeardropScarabCaelidSomberSmithingStone4 = 540422,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Somber Smithing Stone [4] 540424")]
        TeardropScarabCaelidSomberSmithingStone4_ = 540424,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Somber Smithing Stone [8] 540426")]
        TeardropScarabCaelidSomberSmithingStone8 = 540426,

        [Annotation(Name = "[Teardrop Scarab - Caelid] Somber Smithing Stone [9] 540428")]
        TeardropScarabCaelidSomberSmithingStone9 = 540428,

        [Annotation(Name = "Smithing Stone [1] 540500")]
        SmithingStone1 = 540500,

        [Annotation(Name = "Smithing Stone [1] 540502")]
        SmithingStone1_ = 540502,

        [Annotation(Name = "Smithing Stone [1] 540504")]
        SmithingStone1__ = 540504,

        [Annotation(Name = "Smithing Stone [1] 540506")]
        SmithingStone1___ = 540506,

        [Annotation(Name = "Smithing Stone [1] 540508")]
        SmithingStone1____ = 540508,

        [Annotation(Name = "[Teardrop Scarab - Mountaintops of the Giants] Ash of War: Seppuku 540510")]
        TeardropScarabMountaintopsOfTheGiantsAshOfWarSeppuku = 540510,

        [Annotation(Name = "[Teardrop Scarab - Mountaintops of the Giants] Ash of War: Troll's Roar 540512")]
        TeardropScarabMountaintopsOfTheGiantsAshOfWarTrollsRoar = 540512,

        [Annotation(Name = "[Teardrop Scarab - Giant-Conquering Hero's Grave] Flame, Protect Me 540514")]
        TeardropScarabGiantConqueringHerosGraveFlameProtectMe = 540514,

        [Annotation(Name = "[Teardrop Scarab - Forbidden Lands] Ash of War: Prelate's Charge 540516")]
        TeardropScarabForbiddenLandsAshOfWarPrelatesCharge = 540516,

        [Annotation(Name = "Smithing Stone [1] 540520")]
        SmithingStone1_____ = 540520,

        [Annotation(Name = "Smithing Stone [1] 540522")]
        SmithingStone1______ = 540522,

        [Annotation(Name = "[Teardrop Scarab - Consecrated Snowfield] Ash of War: White Shadow's Lure 540524")]
        TeardropScarabConsecratedSnowfieldAshOfWarWhiteShadowsLure = 540524,

        [Annotation(Name = "Smithing Stone [1] 540526")]
        SmithingStone1_______ = 540526,

        [Annotation(Name = "Smithing Stone [1] 540528")]
        SmithingStone1________ = 540528,

        [Annotation(Name = "Golden Rune [1] 540570")]
        GoldenRune1 = 540570,

        [Annotation(Name = "Golden Rune [1] 540572")]
        GoldenRune1_ = 540572,

        [Annotation(Name = "Golden Rune [1] 540574")]
        GoldenRune1__ = 540574,

        [Annotation(Name = "Golden Rune [1] 540576")]
        GoldenRune1___ = 540576,

        [Annotation(Name = "[Teardrop Scarab - Siofra River] Somber Smithing Stone [5] 540590")]
        TeardropScarabSiofraRiverSomberSmithingStone5 = 540590,

        [Annotation(Name = "[Teardrop Scarab - Siofra River] Somber Smithing Stone [5] 540592")]
        TeardropScarabSiofraRiverSomberSmithingStone5_ = 540592,

        [Annotation(Name = "[Teardrop Scarab - Siofra River] Somber Smithing Stone [6] 540600")]
        TeardropScarabSiofraRiverSomberSmithingStone6 = 540600,

        [Annotation(Name = "[Teardrop Scarab - Siofra River] Somber Smithing Stone [6] 540602")]
        TeardropScarabSiofraRiverSomberSmithingStone6_ = 540602,

        [Annotation(Name = "[Teardrop Scarab - Siofra River] Great Oracular Bubble 540610")]
        TeardropScarabSiofraRiverGreatOracularBubble = 540610,

        [Annotation(Name = "Golden Rune [1] 540612")]
        GoldenRune1____ = 540612,

        [Annotation(Name = "Golden Rune [1] 540614")]
        GoldenRune1_____ = 540614,

        [Annotation(Name = "Golden Rune [1] 540616")]
        GoldenRune1______ = 540616,

        [Annotation(Name = "Golden Rune [1] 540618")]
        GoldenRune1_______ = 540618,

        [Annotation(Name = "[Teardrop Scarab - Siofra River] Ash of War: Square Off 540630")]
        TeardropScarabSiofraRiverAshOfWarSquareOff = 540630,

        [Annotation(Name = "Golden Rune [1] 540632")]
        GoldenRune1________ = 540632,

        [Annotation(Name = "Golden Rune [1] 540634")]
        GoldenRune1_________ = 540634,

        [Annotation(Name = "Golden Rune [1] 540636")]
        GoldenRune1__________ = 540636,

        [Annotation(Name = "Golden Rune [1] 540638")]
        GoldenRune1___________ = 540638,

        [Annotation(Name = "Golden Rune [1] 540640")]
        GoldenRune1____________ = 540640,

        [Annotation(Name = "[Teardrop Scarab - Nokron] Somber Smithing Stone [5] 540642")]
        TeardropScarabNokronSomberSmithingStone5 = 540642,

        [Annotation(Name = "Golden Rune [1] 540644")]
        GoldenRune1_____________ = 540644,

        [Annotation(Name = "[Teardrop Scarab - Nokron] Ash of War: Enchanted Shot 540646")]
        TeardropScarabNokronAshOfWarEnchantedShot = 540646,

        [Annotation(Name = "[Teardrop Scarab - Nokron] Order Healing 540648")]
        TeardropScarabNokronOrderHealing = 540648,

        [Annotation(Name = "Golden Rune [1] 540650")]
        GoldenRune1______________ = 540650,

        [Annotation(Name = "[Teardrop Scarab - Siofra River] Oracle Bubbles 540652")]
        TeardropScarabSiofraRiverOracleBubbles = 540652,

        [Annotation(Name = "[Teardrop Scarab - Deeproot Depths] Ash of War: Golden Land 540660")]
        TeardropScarabDeeprootDepthsAshOfWarGoldenLand = 540660,

        [Annotation(Name = "Golden Rune [1] 540662")]
        GoldenRune1_______________ = 540662,

        [Annotation(Name = "Golden Rune [1] 540664")]
        GoldenRune1________________ = 540664,

        [Annotation(Name = "Golden Rune [1] 540666")]
        GoldenRune1_________________ = 540666,

        [Annotation(Name = "Somber Smithing Stone [6] 540668")]
        SomberSmithingStone6 = 540668,

        [Annotation(Name = "Somber Smithing Stone [6] 540670")]
        SomberSmithingStone6_ = 540670,

        [Annotation(Name = "Golden Rune [1] 540680")]
        GoldenRune1__________________ = 540680,

        [Annotation(Name = "Golden Rune [1] 540682")]
        GoldenRune1___________________ = 540682,

        [Annotation(Name = "Golden Rune [1] 540684")]
        GoldenRune1____________________ = 540684,

        [Annotation(Name = "[Teardrop Scarab - Mohgwyn Dynasty] Ash of War: Blood Tax 540686")]
        TeardropScarabMohgwynDynastyAshOfWarBloodTax = 540686,

        [Annotation(Name = "[Teardrop Scarab - Crumbling Farum Azula] Golden Lightning Fortification 540772")]
        TeardropScarabCrumblingFarumAzulaGoldenLightningFortification = 540772,

        [Annotation(Name = "[Info Item] About Sites of Grace 550000")]
        InfoItemAboutSitesOfGrace = 550000,

        [Annotation(Name = "[Info Item] About Sorceries and Incantations 550010")]
        InfoItemAboutSorceriesandIncantations = 550010,

        [Annotation(Name = "[Info Item] About Bows 550020")]
        InfoItemAboutBows = 550020,

        [Annotation(Name = "[Info Item] About Crouching 550030")]
        InfoItemAboutCrouching = 550030,

        [Annotation(Name = "[Info Item] About Stance-Breaking 550040")]
        InfoItemAboutStanceBreaking = 550040,

        [Annotation(Name = "[Info Item] About Stakes of Marika 550050")]
        InfoItemAboutStakesOfMarika = 550050,

        [Annotation(Name = "[Info Item] About Guard Counters 550060")]
        InfoItemAboutGuardCounters = 550060,

        [Annotation(Name = "[Info Item] About the Map 550070")]
        InfoItemAboutTheMap = 550070,

        [Annotation(Name = "[Info Item] About Guidance of Grace 550080")]
        InfoItemAboutGuidanceOfGrace = 550080,

        [Annotation(Name = "[Info Item] About Horseback Riding 550090")]
        InfoItemAboutHorsebackRiding = 550090,

        [Annotation(Name = "[Info Item] About Death 550100")]
        InfoItemAboutDeath = 550100,

        [Annotation(Name = "[Info Item] About Summoning Spirits 550110")]
        InfoItemAboutSummoningSpirits = 550110,

        [Annotation(Name = "[Info Item] About Guarding 550120")]
        InfoItemAboutGuarding = 550120,

        [Annotation(Name = "[Info Item] About Item Crafting 550130")]
        InfoItemAboutItemCrafting = 550130,

        [Annotation(Name = "[Info Item] About Flask of Wondrous Physick 550150")]
        InfoItemAboutFlaskOfWondrousPhysick = 550150,

        [Annotation(Name = "[Info Item] About Adding Skills 550160")]
        InfoItemAboutAddingSkills = 550160,

        [Annotation(Name = "[Info Item] About Birdseye Telescopes 550170")]
        InfoItemAboutBirdseyeTelescopes = 550170,

        [Annotation(Name = "[Info Item] About Spiritspring Jumping 550180")]
        InfoItemAboutSpiritspringJumping = 550180,

        [Annotation(Name = "[Info Item] About Vanquishing Enemy Groups 550190")]
        InfoItemAboutVanquishingEnemyGroups = 550190,

        [Annotation(Name = "[Info Item] About Teardrop Scarabs 550200")]
        InfoItemAboutTeardropScarabs = 550200,

        [Annotation(Name = "[Info Item] About Summoning Other Players 550210")]
        InfoItemAboutSummoningOtherPlayers = 550210,

        [Annotation(Name = "[Info Item] About Cooperative Multiplayer 550220")]
        InfoItemAboutCooperativeMultiplayer = 550220,

        [Annotation(Name = "[Info Item] About Competitive Multiplayer 550230")]
        InfoItemAboutCompetitiveMultiplayer = 550230,

        [Annotation(Name = "[Info Item] About Invasion Multiplayer 550240")]
        InfoItemAboutInvasionMultiplayer = 550240,

        [Annotation(Name = "[Info Item] About Hunter Multiplayer 550250")]
        InfoItemAboutHunterMultiplayer = 550250,

        [Annotation(Name = "[Info Item] About Summoning Pools 550260")]
        InfoItemAboutSummoningPools = 550260,

        [Annotation(Name = "[Info Item] About Monument Icon 550270")]
        InfoItemAboutMonumentIcon = 550270,

        [Annotation(Name = "[Info Item] About Requesting Help from Hunters 550280")]
        InfoItemAboutRequestingHelpfromHunters = 550280,

        [Annotation(Name = "[Info Item] About Skills 550290")]
        InfoItemAboutSkills = 550290,

        [Annotation(Name = "[Limgrave - Artist's Shack] \"Homing Instinct\" Painting 580000")]
        LimgraveArtistsShackHomingInstinctPainting = 580000,

        [Annotation(Name = "[Liurnia - Artist's Shack] \"Resurrection\" Painting 580010")]
        LiurniaArtistsShackResurrectionPainting = 580010,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] \"Champion's Song\" Painting 580020")]
        AltusPlateauShadedCastleChampionsSongPainting = 580020,

        [Annotation(Name = "[Consecrated Snowfield - Castle Sol] \"Sorcerer\" Painting 580030")]
        ConsecratedSnowfieldCastleSolSorcererPainting = 580030,

        [Annotation(Name = "[Stormveil Castle] \"Prophecy\" Painting 580040")]
        StormveilCastleProphecyPainting = 580040,

        [Annotation(Name = "[Leyndell - Fortifed Manor] \"Flightless Bird\" Painting 580050")]
        LeyndellFortifedManorFlightlessBirdPainting = 580050,

        [Annotation(Name = "[Caelid - Sellia] \"Redmane\" Painting 580060")]
        CaelidSelliaRedmanePainting = 580060,

        [Annotation(Name = "[Reward - \"Homing Instinct\" Painting] Incantation Scarab 580300")]
        RewardHomingInstinctPaintingIncantationScarab = 580300,

        [Annotation(Name = "[Reward - \"Resurrection\" Painting] Juvenile Scholar Cap 580310")]
        RewardResurrectionPaintingJuvenileScholarCap = 580310,

        [Annotation(Name = "[Reward - \"Champion's Song\" Painting] Harp Bow 580320")]
        RewardChampionsSongPaintingHarpBow = 580320,

        [Annotation(Name = "[Reward - \"Sorcerer\" Painting] Greathood 580330")]
        RewardSorcererPaintingGreathood = 580330,

        [Annotation(Name = "[Reward - \"Prophecy\" Painting] Warhawk Ashes 580340")]
        RewardProphecyPaintingWarhawkAshes = 580340,

        [Annotation(Name = "[Reward - \"Flightless Bird\" Painting] Fire's Deadly Sin 580350")]
        RewardFlightlessBirdPaintingFiresDeadlySin = 580350,

        [Annotation(Name = "[Reward - \"Redmane\" Painting] Ash of War: Rain of Arrows 580360")]
        RewardRedmanePaintingAshOfWarRainOfArrows = 580360,

        [Annotation(Name = "[Melina - Third Grace Found] Spectral Steed Whistle 60100")]
        MelinaThirdGraceFoundSpectralSteedWhistle = 60100,

        [Annotation(Name = "[Melina - Morgott Killed] Rold Medallion 400001")]
        MelinaMorgottKilledRoldMedallion = 400001,

        [Annotation(Name = "[Unknown] 400010")]
        Unknown = 400010,

        [Annotation(Name = "[Unknown] Neutralizing Boluses 400020")]
        UnknownNeutralizingBoluses = 400020,

        [Annotation(Name = "[Unknown] 400021")]
        Unknown_ = 400021,

        [Annotation(Name = "[White-Faced Varre - ?] Festering Bloody Finger 400030")]
        WhiteFacedVarreFesteringBloodyFinger = 400030,

        [Annotation(Name = "[White-Faced Varre - Maiden Kill] Lord of Blood's Favor 400031")]
        WhiteFacedVarreMaidenKillLordOfBloodsFavor = 400031,

        [Annotation(Name = "[White-Faced Varre - 3 Invasions] Pureblood Knight's Medal 400032")]
        WhiteFacedVarre3InvasionsPurebloodKnightsMedal = 400032,

        [Annotation(Name = "[White-Faced Varre - Maiden Kill] Lord of Blood's Favor 400033")]
        WhiteFacedVarreMaidenKillLordOfBloodsFavor_ = 400033,

        [Annotation(Name = "[White-Faced Varre - Returned Oath-Cloth] Bloody Finger 60270")]
        WhiteFacedVarreReturnedOathClothBloodyFinger = 60270,

        [Annotation(Name = "[White-Faced Varre] 400035")]
        WhiteFacedVarre = 400035,

        [Annotation(Name = "[White-Faced Varre - Invasion] Varre's Bouquet 400037")]
        WhiteFacedVarreInvasionVarresBouquet = 400037,

        [Annotation(Name = "[White-Faced Varre - Invasion] Festering Bloody Finger 400036")]
        WhiteFacedVarreInvasionFesteringBloodyFinger = 400036,

        [Annotation(Name = "[Unknown] 400040")]
        Unknown__ = 400040,

        [Annotation(Name = "[Unknown] Perfume Bottle 400041")]
        UnknownPerfumeBottle = 400041,

        [Annotation(Name = "[Unknown] Glowstone 400042")]
        UnknownGlowstone = 400042,

        [Annotation(Name = "[Gatekeeper Gostoc - First Meeting] Grace Mimic 400050")]
        GatekeeperGostocFirstMeetingGraceMimic = 400050,

        [Annotation(Name = "[Gatekeeper Gostoc - Gostoc Killed] Gostoc's Bell Bearing 400051")]
        GatekeeperGostocGostocKilledGostocsBellBearing = 400051,

        [Annotation(Name = "[Edgar] Sacrificial Twig 400060")]
        EdgarSacrificialTwig = 400060,

        [Annotation(Name = "[Edgar] Shabriri Grape 400061")]
        EdgarShabririGrape = 400061,

        [Annotation(Name = "[Tanith] Tonic of Forgetfulness 400070")]
        TanithTonicOfForgetfulness = 400070,

        [Annotation(Name = "[Tanith] Consort's Mask 400071")]
        TanithConsortsMask = 400071,

        [Annotation(Name = "[Tanith] Drawing-Room Key 400072")]
        TanithDrawingRoomKey = 400072,

        [Annotation(Name = "[Tanith] Letter from Volcano Manor 400073")]
        TanithLetterfromVolcanoManor = 400073,

        [Annotation(Name = "[Tanith] Letter from Volcano Manor 400074")]
        TanithLetterfromVolcanoManor_ = 400074,

        [Annotation(Name = "[Tanith] Red Letter 400075")]
        TanithRedLetter = 400075,

        [Annotation(Name = "[Tanith] Magma Shot 400076")]
        TanithMagmaShot = 400076,

        [Annotation(Name = "[Tanith] Serpentbone Blade 400077")]
        TanithSerpentboneBlade = 400077,

        [Annotation(Name = "[Tanith] Taker's Cameo 400078")]
        TanithTakersCameo = 400078,

        [Annotation(Name = "[Tanith] Aspects of the Crucible: Breath 400079")]
        TanithAspectsOfTheCrucibleBreath = 400079,

        [Annotation(Name = "[Irina] Irina's Letter 400080")]
        IrinaIrinasLetter = 400080,

        [Annotation(Name = "[Rya] Rya's Necklace 400081")]
        RyaRyasNecklace = 400081,

        [Annotation(Name = "[Hyetta] Frenzied Flame Seal 400089")]
        HyettaFrenziedFlameSeal = 400089,

        [Annotation(Name = "[Rya] Volcano Manor Invitation 400090")]
        RyaVolcanoManorInvitation = 400090,

        [Annotation(Name = "[Rya] Zorayas's Letter 400091")]
        RyaZorayassLetter = 400091,

        [Annotation(Name = "[Sorceress Sellen] Sellen's Primal Glintstone 400100")]
        SorceressSellenSellensPrimalGlintstone = 400100,

        [Annotation(Name = "[Sorceress Sellen] Glintstone Kris 400101")]
        SorceressSellenGlintstoneKris = 400101,

        [Annotation(Name = "[Sorceress Sellen] Sellian Sealbreaker 400102")]
        SorceressSellenSellianSealbreaker = 400102,

        [Annotation(Name = "[Sorceress Sellen] Starlight Shards 400103")]
        SorceressSellenStarlightShards = 400103,

        [Annotation(Name = "[Sorceress Sellen] Comet Azur 400104")]
        SorceressSellenCometAzur = 400104,

        [Annotation(Name = "[Sorceress Sellen] Stars of Ruin 400105")]
        SorceressSellenStarsOfRuin = 400105,

        [Annotation(Name = "[Sorceress Sellen] Sellen's Bell Bearing 400106")]
        SorceressSellenSellensBellBearing = 400106,

        [Annotation(Name = "[Sorceress Sellen] Witch's Glintstone Crown 400107")]
        SorceressSellenWitchsGlintstoneCrown = 400107,

        [Annotation(Name = "[Finger Reader Enia - Godfrey] Talisman Pouch 60500")]
        FingerReaderEniaGodfreyTalismanPouch = 60500,

        [Annotation(Name = "[Unknown] Glowstone 400120")]
        UnknownGlowstone_ = 400120,

        [Annotation(Name = "[Unknown] Glowstone 400121")]
        UnknownGlowstone__ = 400121,

        [Annotation(Name = "[Albus] Haligtree Secret Medallion (Right) 400130")]
        AlbusHaligtreeSecretMedallionRight = 400130,

        [Annotation(Name = "[Seluvis] Seluvis's Potion 400140")]
        SeluvisSeluvissPotion = 400140,

        [Annotation(Name = "[Seluvis] Magic Scorpion Charm 400141")]
        SeluvisMagicScorpionCharm = 400141,

        [Annotation(Name = "[Seluvis] 400142")]
        Seluvis = 400142,

        [Annotation(Name = "[Seluvis] Seluvis's Introduction 400143")]
        SeluvisSeluvissIntroduction = 400143,

        [Annotation(Name = "[Seluvis] Glowstone 400144")]
        SeluvisGlowstone = 400144,

        [Annotation(Name = "[Seluvis] Amber Draught 400145")]
        SeluvisAmberDraught = 400145,

        [Annotation(Name = "[Seluvis] 400146")]
        Seluvis_ = 400146,

        [Annotation(Name = "[Seluvis] Seluvis's Bell Bearing 400148")]
        SeluvisSeluvissBellBearing = 400148,

        [Annotation(Name = "[Pidia, Carian Servant] Pidia's Bell Bearing 400149")]
        PidiaCarianServantPidiasBellBearing = 400149,

        [Annotation(Name = "[Blaidd is the Half-Wolf] Somber Smithing Stone [2] 400150")]
        BlaiddisTheHalfWolfSomberSmithingStone2 = 400150,

        [Annotation(Name = "[Blaidd is the Half-Wolf] Royal Greatsword 400158")]
        BlaiddisTheHalfWolfRoyalGreatsword = 400158,

        [Annotation(Name = "[Blaidd is the Half-Wolf] Discarded Palace Key 400159")]
        BlaiddisTheHalfWolfDiscardedPalaceKey = 400159,

        [Annotation(Name = "[Unknown] White Cipher Ring 60280")]
        UnknownWhiteCipherRing = 60280,

        [Annotation(Name = "[Unknown] Smithing Stone [5] 400161")]
        UnknownSmithingStone5 = 400161,

        [Annotation(Name = "[Eleonora, Violet Bloody Finger] Purifying Crystal Tear 65270")]
        EleonoraVioletBloodyFingerPurifyingCrystalTear = 65270,

        [Annotation(Name = "[Eleonora, Violet Bloody Finger] Eleonora's Poleblade 400162")]
        EleonoraVioletBloodyFingerEleonorasPoleblade = 400162,

        [Annotation(Name = "[Bloody Finger Hunter Yura] Nagakiba +0 - Piercing Fang 400163")]
        BloodyFingerHunterYuraNagakiba0PiercingFang = 400163,

        [Annotation(Name = "[Bloody Finger Hunter Yura] Iron Kasa 400164")]
        BloodyFingerHunterYuraIronKasa = 400164,

        [Annotation(Name = "[Iron Fist Alexander] Exalted Flesh 400170")]
        IronFistAlexanderExaltedFlesh = 400170,

        [Annotation(Name = "[Iron Fist Alexander] Exalted Flesh 400171")]
        IronFistAlexanderExaltedFlesh_ = 400171,

        [Annotation(Name = "[Iron Fist Alexander] Jar 400172")]
        IronFistAlexanderJar = 400172,

        [Annotation(Name = "[Iron Fist Alexander] Warrior Jar Shard 400173")]
        IronFistAlexanderWarriorJarShard = 400173,

        [Annotation(Name = "[Iron Fist Alexander] Shard of Alexander 400174")]
        IronFistAlexanderShardOfAlexander = 400174,

        [Annotation(Name = "[Unknown] 400179")]
        Unknown___ = 400179,

        [Annotation(Name = "[Patches] Letter to Patches 400180")]
        PatchesLettertoPatches = 400180,

        [Annotation(Name = "[Patches] Dancer's Castanets 400181")]
        PatchesDancersCastanets = 400181,

        [Annotation(Name = "[Patches] Magma Whip Candlestick 400182")]
        PatchesMagmaWhipCandlestick = 400182,

        [Annotation(Name = "[Patches] Golden Rune [1] 400183")]
        PatchesGoldenRune1 = 400183,

        [Annotation(Name = "[Patches] Spear+7 400184")]
        PatchesSpear7 = 400184,

        [Annotation(Name = "[Roderika] Spirit Jellyfish Ashes 400190")]
        RoderikaSpiritJellyfishAshes = 400190,

        [Annotation(Name = "[Roderika] Golden Seed 400191")]
        RoderikaGoldenSeed = 400191,

        [Annotation(Name = "[Chest - Gatefront Ruins] Whetstone Knife 400210")]
        ChestGatefrontRuinsWhetstoneKnife = 400210,

        [Annotation(Name = "[Kenneth Haight] Erdsteel Dagger 400221")]
        KennethHaightErdsteelDagger = 400221,

        [Annotation(Name = "[Gurranq - 4th Deathroot] Ash of War: Beast's Roar 400235")]
        Gurranq4thDeathrootAshOfWarBeastsRoar = 400235,

        [Annotation(Name = "[Gurranq - 3rd Deathroot] Bestial Vitality 400236")]
        Gurranq3rdDeathrootBestialVitality = 400236,

        [Annotation(Name = "[Gurranq - 2nd Deathroot] Bestial Sling 400237")]
        Gurranq2ndDeathrootBestialSling = 400237,

        [Annotation(Name = "[Gurranq - 1st Deathroot] Clawmark Seal 400238")]
        Gurranq1stDeathrootClawmarkSeal = 400238,

        [Annotation(Name = "[Gurranq - 1st Deathroot] Beast Eye 400239")]
        Gurranq1stDeathrootBeastEye = 400239,

        [Annotation(Name = "[Gurranq - 9th Deathroot] Dragon Smithing Stone 400230")]
        Gurranq9thDeathrootDragonSmithingStone = 400230,

        [Annotation(Name = "[Gurranq - 8th Deathroot] Gurranq's Beast Claw 400231")]
        Gurranq8thDeathrootGurranqsBeastClaw = 400231,

        [Annotation(Name = "[Gurranq - 7th Deathroot] Beastclaw Greathammer 400232")]
        Gurranq7thDeathrootBeastclawGreathammer = 400232,

        [Annotation(Name = "[Gurranq - 6th Deathroot] Stone of Gurranq 400233")]
        Gurranq6thDeathrootStoneOfGurranq = 400233,

        [Annotation(Name = "[Gurranq - 5th Deathroot] Beast Claw 400234")]
        Gurranq5thDeathrootBeastClaw = 400234,

        [Annotation(Name = "[War Counselor Iji] Iji's Bell Bearing 400240")]
        WarCounselorIjiIjisBellBearing = 400240,

        [Annotation(Name = "[War Counselor Iji] Iji's Mirrorhelm 400241")]
        WarCounselorIjiIjisMirrorhelm = 400241,

        [Annotation(Name = "[Unknown] Glowstone 400260")]
        UnknownGlowstone___ = 400260,

        [Annotation(Name = "[Unknown] Mushroom 400271")]
        UnknownMushroom = 400271,

        //duplicate of 1051587800
        //[Annotation(Name = "[Castle Sol] Haligtree Secret Medallion (Left) 400280")]
        //CastleSolHaligtreeSecretMedallionLeft = 400280,

        [Annotation(Name = "[Unknown] 400281")]
        Unknown____ = 400281,

        [Annotation(Name = "[Gideon Ofnir - Secret Medallion] Black Flame's Protection 400282")]
        GideonOfnirSecretMedallionBlackFlamesProtection = 400282,

        [Annotation(Name = "[Gideon Ofnir - Haligtree] Lord's Divine Fortification 400283")]
        GideonOfnirHaligtreeLordsDivineFortification = 400283,

        [Annotation(Name = "[Gideon Ofnir - Mohgwyn Dynasty Mausoleum] Fevor's Cookbook [3] 68210")]
        GideonOfnirMohgwynDynastyMausoleumFevorsCookbook3 = 68210,

        [Annotation(Name = "[Gideon Ofnir - Mohg Killed] Law of Causality 400285")]
        GideonOfnirMohgKilledLawOfCausality = 400285,

        [Annotation(Name = "[Gideon Ofnir - Boss Drop] All-Knowing Gauntlets 400284")]
        GideonOfnirBossDropAllKnowingGauntlets = 400284,

        [Annotation(Name = "[Knight Bernahl] Letter to Bernahl 400290")]
        KnightBernahlLettertoBernahl = 400290,

        [Annotation(Name = "[Knight Bernahl] Gelmir's Fury 400291")]
        KnightBernahlGelmirsFury = 400291,

        [Annotation(Name = "[Knight Bernahl] Blasphemous Claw 400292")]
        KnightBernahlBlasphemousClaw = 400292,

        [Annotation(Name = "[Knight Bernahl] Devourer's Scepter 400293")]
        KnightBernahlDevourersScepter = 400293,

        [Annotation(Name = "[Knight Bernahl] Beast Champion Helm 400294")]
        KnightBernahlBeastChampionHelm = 400294,

        [Annotation(Name = "[Knight Bernahl] Gelmir's Fury 400295")]
        KnightBernahlGelmirsFury_ = 400295,

        [Annotation(Name = "[Big Boggart] Rya's Necklace 400300")]
        BigBoggartRyasNecklace = 400300,

        [Annotation(Name = "[Big Boggart] Iron Ball +0 - Braggart's Roar 400309")]
        BigBoggartIronBall0BraggartsRoar = 400309,

        [Annotation(Name = "[Big Boggart] Seedbed Curse 400308")]
        BigBoggartSeedbedCurse = 400308,

        [Annotation(Name = "[Gowry] Unalloyed Gold Needle 400310")]
        GowryUnalloyedGoldNeedle = 400310,

        [Annotation(Name = "[Gowry] Sellia's Secret 400311")]
        GowrySelliasSecret = 400311,

        [Annotation(Name = "[Gowry] Flock's Canvas Talisman 400312")]
        GowryFlocksCanvasTalisman = 400312,

        [Annotation(Name = "[Millicent] Prosthesis-Wearer Heirloom 400320")]
        MillicentProsthesisWearerHeirloom = 400320,

        [Annotation(Name = "[Millicent] Unalloyed Gold Needle 400321")]
        MillicentUnalloyedGoldNeedle = 400321,

        [Annotation(Name = "[Millicent] Millicent's Prosthesis 400323")]
        MillicentMillicentsProsthesis = 400323,

        [Annotation(Name = "[Millicent] Miquella's Needle 400324")]
        MillicentMiquellasNeedle = 400324,

        [Annotation(Name = "[Millicent] Somber Ancient Dragon Smithing Stone 400325")]
        MillicentSomberAncientDragonSmithingStone = 400325,

        [Annotation(Name = "[Fia] Weathered Dagger 400331")]
        FiaWeatheredDagger = 400331,

        [Annotation(Name = "[Fia] Sacrificial Twig 400332")]
        FiaSacrificialTwig = 400332,

        [Annotation(Name = "[Fia] Radiant Baldachin's Blessing 400333")]
        FiaRadiantBaldachinsBlessing = 400333,

        [Annotation(Name = "[Fia] Knifeprint Clue 400334")]
        FiaKnifeprintClue = 400334,

        [Annotation(Name = "[D, Hunter of the Dead] D's Bell Bearing 400349")]
        DHunterOfTheDeadDsBellBearing = 400349,

        [Annotation(Name = "[Prince of Death's Throne] Inseparable Sword 400348")]
        PrinceOfDeathsThroneInseparableSword = 400348,

        [Annotation(Name = "[Sorcerer Rogier] Rogier's Rapier +8 - Glintblade Phalanx 400358")]
        SorcererRogierRogiersRapier8GlintbladePhalanx = 400358,

        [Annotation(Name = "[Sorcerer Rogier] Black Knifeprint 400357")]
        SorcererRogierBlackKnifeprint = 400357,

        [Annotation(Name = "[Sorcerer Rogier] Rogier's Letter 400356")]
        SorcererRogierRogiersLetter = 400356,

        [Annotation(Name = "[Sorcerer Rogier] Rogier's Bell Bearing 400359")]
        SorcererRogierRogiersBellBearing = 400359,

        [Annotation(Name = "[Thops] Thops's Bell Bearing 400360")]
        ThopsThopssBellBearing = 400360,

        [Annotation(Name = "[Thops] Academy Glintstone Staff 400361")]
        ThopsAcademyGlintstoneStaff = 400361,

        [Annotation(Name = "[Thops] Thops's Barrier 400362")]
        ThopsThopssBarrier = 400362,

        [Annotation(Name = "[Brother Corhyn] Corhyn's Bell Bearing 400370")]
        BrotherCorhynCorhynsBellBearing = 400370,

        [Annotation(Name = "[Dung Eater] Sewer-Gaol Key 400380")]
        DungEaterSewerGaolKey = 400380,

        [Annotation(Name = "[Dung Eater] Omen Helm 400382")]
        DungEaterOmenHelm = 400382,

        [Annotation(Name = "[Ranni the Witch] Spirit Calling Bell 60110")]
        RanniTheWitchSpiritCallingBell = 60110,

        [Annotation(Name = "[Ranni the Witch] Lone Wolf Ashes 400390")]
        RanniTheWitchLoneWolfAshes = 400390,

        [Annotation(Name = "[Ranni the Witch] Carian Inverted Statue 400391")]
        RanniTheWitchCarianInvertedStatue = 400391,

        [Annotation(Name = "[Ranni the Witch] Dark Moon Greatsword 400393")]
        RanniTheWitchDarkMoonGreatsword = 400393,

        [Annotation(Name = "[Ranni the Witch] Miniature Ranni 400394")]
        RanniTheWitchMiniatureRanni = 400394,

        [Annotation(Name = "[Ranni the Witch] Fingerslayer Blade 400395")]
        RanniTheWitchFingerslayerBlade = 400395,

        [Annotation(Name = "[Witch-Hunter Jerren] Ancient Dragon Smithing Stone 400400")]
        WitchHunterJerrenAncientDragonSmithingStone = 400400,

        [Annotation(Name = "[Witch-Hunter Jerren] Eccentric's Hood 400401")]
        WitchHunterJerrenEccentricsHood = 400401,

        [Annotation(Name = "[Latenna] Latenna the Albinauric 400410")]
        LatennaLatennaTheAlbinauric = 400410,

        [Annotation(Name = "[Latenna] Somber Ancient Dragon Smithing Stone 400411")]
        LatennaSomberAncientDragonSmithingStone = 400411,

        [Annotation(Name = "[Latenna] Blue Silver Mail Hood 400412")]
        LatennaBlueSilverMailHood = 400412,

        [Annotation(Name = "[Nepheli Loux] Arsenal Charm 400420")]
        NepheliLouxArsenalCharm = 400420,

        [Annotation(Name = "[Nepheli Loux] Ancient Dragon Smithing Stone 400422")]
        NepheliLouxAncientDragonSmithingStone = 400422,

        [Annotation(Name = "[Master Lusat] Stars of Ruin 400430")]
        MasterLusatStarsOfRuin = 400430,

        [Annotation(Name = "[Master Azur] Comet Azur 400440")]
        MasterAzurCometAzur = 400440,

        [Annotation(Name = "[Juno Hoslow] Hoslow's Petal Whip 400451")]
        JunoHoslowHoslowsPetalWhip = 400451,

        [Annotation(Name = "[Juno Hoslow] Companion Jar 400452")]
        JunoHoslowCompanionJar = 400452,

        [Annotation(Name = "[Jar Bairn] Companion Jar 400460")]
        JarBairnCompanionJar = 400460,

        [Annotation(Name = "[The Great-Jar] Great-Jar's Arsenal 400470")]
        TheGreatJarGreatJarsArsenal = 400470,

        [Annotation(Name = "[Millicent - Killed Sisters] Rotten Winged Sword Insignia 400480")]
        MillicentKilledSistersRottenWingedSwordInsignia = 400480,

        [Annotation(Name = "[Ensha of the Royal Remains] Royal Remains Helm 400490")]
        EnshaOfTheRoyalRemainsRoyalRemainsHelm = 400490,

        [Annotation(Name = "[Goldmask] Goldmask's Rags 400500")]
        GoldmaskGoldmasksRags = 400500,

        [Annotation(Name = "[Magnus the Beast Claw - Writheblood Ruins] Great Stars 400510")]
        MagnustheBeastClawWrithebloodRuinsGreatStars = 400510,

        [Annotation(Name = "[Merchant Kale] Kale's Bell Bearing 400049")]
        MerchantKaleKalesBellBearing = 400049,

        [Annotation(Name = "[Corpse - Edgar] Banished Knight's Halberd +8 - Spinning Strikes 400069")]
        CorpseEdgarBanishedKnightsHalberd8SpinningStrikes = 400069,

        [Annotation(Name = "[Corpse - Unknown] Glowstone 400108")]
        CorpseUnknownGlowstone = 400108,

        [Annotation(Name = "[Corpse - Unknown] Glowstone 400109")]
        CorpseUnknownGlowstone_ = 400109,

        [Annotation(Name = "[Corpse - Iron Fist Alexander] Warrior Jar Shard 400175")]
        CorpseIronFistAlexanderWarriorJarShard = 400175,

        [Annotation(Name = "[Corpse - Patches] Patches' Bell Bearing 400189")]
        CorpsePatchesPatchesBellBearing = 400189,

        [Annotation(Name = "[Corpse - Unknown] Glowstone 400209")]
        CorpseUnknownGlowstone__ = 400209,

        [Annotation(Name = "[Corpse - Unknown] Golden Seed 400220")]
        CorpseUnknownGoldenSeed = 400220,

        [Annotation(Name = "[Corpse - Knight Bernahl] Bernahl's Bell Bearing 400299")]
        CorpseKnightBernahlBernahlsBellBearing = 400299,

        [Annotation(Name = "[Corpse - Fia] Fia's Hood 400339")]
        CorpseFiaFiasHood = 400339,

        [Annotation(Name = "[Corpse - Dung Eater] Sword of Milos 400381")]
        CorpseDungEaterSwordOfMilos = 400381,

        [Annotation(Name = "[Corpse - Nepheli Loux] Stormhawk Axe 400421")]
        CorpseNepheliLouxStormhawkAxe = 400421,

        [Annotation(Name = "[Corpse - Master Lusat] Lusat's Glintstone Crown 400431")]
        CorpseMasterLusatLusatsGlintstoneCrown = 400431,

        [Annotation(Name = "[Corpse - Master Azur] Azur's Glintstone Crown 400441")]
        CorpseMasterAzurAzursGlintstoneCrown = 400441,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [1] 400901")]
        CorpseMerchantNomadicMerchantsBellBearing1 = 400901,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [2] 400902")]
        CorpseMerchantNomadicMerchantsBellBearing2 = 400902,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [3] 400903")]
        CorpseMerchantNomadicMerchantsBellBearing3 = 400903,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [4] 400904")]
        CorpseMerchantNomadicMerchantsBellBearing4 = 400904,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [5] 400905")]
        CorpseMerchantNomadicMerchantsBellBearing5 = 400905,

        [Annotation(Name = "[Corpse - Merchant] Isolated Merchant's Bell Bearing [1] 400906")]
        CorpseMerchantIsolatedMerchantsBellBearing1 = 400906,

        [Annotation(Name = "[Corpse - Merchant] Isolated Merchant's Bell Bearing [2] 400907")]
        CorpseMerchantIsolatedMerchantsBellBearing2 = 400907,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [6] 400908")]
        CorpseMerchantNomadicMerchantsBellBearing6 = 400908,

        [Annotation(Name = "[Corpse - Merchant] Hermit Merchant's Bell Bearing [1] 400909")]
        CorpseMerchantHermitMerchantsBellBearing1 = 400909,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [7] 400910")]
        CorpseMerchantNomadicMerchantsBellBearing7 = 400910,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [8] 400911")]
        CorpseMerchantNomadicMerchantsBellBearing8 = 400911,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [9] 400912")]
        CorpseMerchantNomadicMerchantsBellBearing9 = 400912,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [10] 400913")]
        CorpseMerchantNomadicMerchantsBellBearing10 = 400913,

        [Annotation(Name = "[Corpse - Merchant] Nomadic Merchant's Bell Bearing [11] 400914")]
        CorpseMerchantNomadicMerchantsBellBearing11 = 400914,

        [Annotation(Name = "[Corpse - Merchant] Isolated Merchant's Bell Bearing [3] 400915")]
        CorpseMerchantIsolatedMerchantsBellBearing3 = 400915,

        [Annotation(Name = "[Corpse - Merchant] Hermit Merchant's Bell Bearing [2] 400916")]
        CorpseMerchantHermitMerchantsBellBearing2 = 400916,

        [Annotation(Name = "[Corpse - Merchant] Abandoned Merchant's Bell Bearing 400917")]
        CorpseMerchantAbandonedMerchantsBellBearing = 400917,

        [Annotation(Name = "[Corpse - Merchant] Hermit Merchant's Bell Bearing [3] 400918")]
        CorpseMerchantHermitMerchantsBellBearing3 = 400918,

        [Annotation(Name = "[Corpse - Merchant] Imprisoned Merchant's Bell Bearing 400919")]
        CorpseMerchantImprisonedMerchantsBellBearing = 400919,

        [Annotation(Name = "[LD - Stormveil] Furlcalling Finger Remedy 10007030")]
        LDStormveilFurlcallingFingerRemedy = 10007030,

        [Annotation(Name = "[LD - Stormveil] Fire Grease 10007040")]
        LDStormveilFireGrease = 10007040,

        [Annotation(Name = "[LD - Stormveil] Gold-Pickled Fowl Foot 10007050")]
        LDStormveilGoldPickledFowlFoot = 10007050,

        [Annotation(Name = "[LD - Stormveil] Festering Bloody Finger 10007060")]
        LDStormveilFesteringBloodyFinger = 10007060,

        [Annotation(Name = "[LD - Stormveil] Arrow 10007080")]
        LDStormveilArrow = 10007080,

        [Annotation(Name = "[LD - Stormveil] Manor Towershield 10007090")]
        LDStormveilManorTowershield = 10007090,

        [Annotation(Name = "[LD - Stormveil] Marred Leather Shield 10007100")]
        LDStormveilMarredLeatherShield = 10007100,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [1] 10007110")]
        LDStormveilGoldenRune1 = 10007110,

        [Annotation(Name = "[LD - Stormveil] Bolt 10007120")]
        LDStormveilBolt = 10007120,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [3] 10007130")]
        LDStormveilSmithingStone3 = 10007130,

        [Annotation(Name = "[LD - Stormveil] Ruin Fragment 10007140")]
        LDStormveilRuinFragment = 10007140,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [2] 10007150")]
        LDStormveilSmithingStone2 = 10007150,

        [Annotation(Name = "[LD - Stormveil] Silver-Pickled Fowl Foot 10007160")]
        LDStormveilSilverPickledFowlFoot = 10007160,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007170")]
        LDStormveilGoldenRune2 = 10007170,

        [Annotation(Name = "[LD - Stormveil] Hookclaws 10007180")]
        LDStormveilHookclaws = 10007180,

        [Annotation(Name = "[LD - Stormveil] Throwing Dagger 10007190")]
        LDStormveilThrowingDagger = 10007190,

        [Annotation(Name = "[LD - Stormveil] St. Trina's Arrow 10007200")]
        LDStormveilStTrinasArrow = 10007200,

        [Annotation(Name = "[LD - Stormveil] Smoldering Butterfly 10007210")]
        LDStormveilSmolderingButterfly = 10007210,

        [Annotation(Name = "[LD - Stormveil] Fire Grease 10007220")]
        LDStormveilFireGrease_ = 10007220,

        [Annotation(Name = "[LD - Stormveil] Claw Talisman 10007230")]
        LDStormveilClawTalisman = 10007230,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007240")]
        LDStormveilGoldenRune2_ = 10007240,

        [Annotation(Name = "[LD - Stormveil] Arteria Leaf 10007250")]
        LDStormveilArteriaLeaf = 10007250,

        [Annotation(Name = "[LD - Stormveil] Throwing Dagger 10007260")]
        LDStormveilThrowingDagger_ = 10007260,

        [Annotation(Name = "[LD - Stormveil] Mushroom 10007270")]
        LDStormveilMushroom = 10007270,

        [Annotation(Name = "[LD - Stormveil] Drawstring Fire Grease 10007280")]
        LDStormveilDrawstringFireGrease = 10007280,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007290")]
        LDStormveilGoldenRune2__ = 10007290,

        [Annotation(Name = "[LD - Stormveil] Somber Smithing Stone [2] 10007300")]
        LDStormveilSomberSmithingStone2 = 10007300,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [2] 10007310")]
        LDStormveilSmithingStone2_ = 10007310,

        [Annotation(Name = "[LD - Stormveil] Marred Wooden Shield 10007320")]
        LDStormveilMarredWoodenShield = 10007320,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007330")]
        LDStormveilGoldenRune2___ = 10007330,

        [Annotation(Name = "[LD - Stormveil] Highland Axe 10007340")]
        LDStormveilHighlandAxe = 10007340,

        [Annotation(Name = "[LD - Stormveil] Kukri 10007350")]
        LDStormveilKukri = 10007350,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007360")]
        LDStormveilGoldenRune2____ = 10007360,

        [Annotation(Name = "[LD - Stormveil] Stonesword Key 10007370")]
        LDStormveilStoneswordKey = 10007370,

        [Annotation(Name = "[LD - Stormveil] Exalted Flesh 10007380")]
        LDStormveilExaltedFlesh = 10007380,

        [Annotation(Name = "[LD - Stormveil] Lump of Flesh 10007390")]
        LDStormveilLumpOfFlesh = 10007390,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [1] 10007400")]
        LDStormveilGoldenRune1_ = 10007400,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [2] 10007410")]
        LDStormveilSmithingStone2__ = 10007410,

        [Annotation(Name = "[LD - Stormveil] Iron Whetblade 65610")]
        LDStormveilIronWhetblade = 65610,

        [Annotation(Name = "[LD - Stormveil] Arrow 10007430")]
        LDStormveilArrow_ = 10007430,

        [Annotation(Name = "[LD - Stormveil] Fireproof Dried Liver 10007440")]
        LDStormveilFireproofDriedLiver = 10007440,

        [Annotation(Name = "[LD - Stormveil] Chrysalids' Memento 10007450")]
        LDStormveilChrysalidsMemento = 10007450,

        [Annotation(Name = "[LD - Stormveil] Crimson Hood 10007452")]
        LDStormveilCrimsonHood = 10007452,

        [Annotation(Name = "[LD - Stormveil] Stanching Boluses 10007460")]
        LDStormveilStanchingBoluses = 10007460,

        [Annotation(Name = "[LD - Stormveil] Stonesword Key 10007470")]
        LDStormveilStoneswordKey_ = 10007470,

        [Annotation(Name = "[LD - Stormveil] Nomadic Warrior's Cookbook [10] 67030")]
        LDStormveilNomadicWarriorsCookbook10 = 67030,

        [Annotation(Name = "[LD - Stormveil] Rusty Key 10007500")]
        LDStormveilRustyKey = 10007500,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [1] 10007510")]
        LDStormveilSmithingStone1 = 10007510,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [1] 10007520")]
        LDStormveilGoldenRune1__ = 10007520,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007530")]
        LDStormveilGoldenRune2_____ = 10007530,

        [Annotation(Name = "[LD - Stormveil] Ballista Bolt 10007540")]
        LDStormveilBallistaBolt = 10007540,

        [Annotation(Name = "[LD - Stormveil] Arbalest 10007550")]
        LDStormveilArbalest = 10007550,

        [Annotation(Name = "[LD - Stormveil] Commoner's Simple Garb 10007560")]
        LDStormveilCommonersSimpleGarb = 10007560,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007570")]
        LDStormveilGoldenRune2______ = 10007570,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [5] 10007580")]
        LDStormveilGoldenRune5 = 10007580,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [2] 10007590")]
        LDStormveilSmithingStone2___ = 10007590,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [4] 10007600")]
        LDStormveilGoldenRune4 = 10007600,

        [Annotation(Name = "[LD - Stormveil] Fire Arrow 10007610")]
        LDStormveilFireArrow = 10007610,

        [Annotation(Name = "[LD - Stormveil] Pike 10007620")]
        LDStormveilPike = 10007620,

        [Annotation(Name = "[LD - Stormveil] Furlcalling Finger Remedy 10007630")]
        LDStormveilFurlcallingFingerRemedy_ = 10007630,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [1] 10007640")]
        LDStormveilSmithingStone1_ = 10007640,

        [Annotation(Name = "[LD - Stormveil] Smoldering Butterfly 10007650")]
        LDStormveilSmolderingButterfly_ = 10007650,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [4] 10007660")]
        LDStormveilGoldenRune4_ = 10007660,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [1] 10007670")]
        LDStormveilGoldenRune1___ = 10007670,

        [Annotation(Name = "[LD - Stormveil] Mushroom 10007680")]
        LDStormveilMushroom_ = 10007680,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007690")]
        LDStormveilGoldenRune2_______ = 10007690,

        [Annotation(Name = "[LD - Stormveil] Magic Grease 10007700")]
        LDStormveilMagicGrease = 10007700,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [2] 10007710")]
        LDStormveilSmithingStone2____ = 10007710,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007720")]
        LDStormveilGoldenRune2________ = 10007720,

        [Annotation(Name = "[LD - Stormveil] Golden Seed 10007730")]
        LDStormveilGoldenSeed = 10007730,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [2] 10007740")]
        LDStormveilSmithingStone2_____ = 10007740,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [1] 10007750")]
        LDStormveilSmithingStone1__ = 10007750,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [5] 10007760")]
        LDStormveilGoldenRune5_ = 10007760,

        [Annotation(Name = "[LD - Stormveil] Cracked Pot 66010")]
        LDStormveilCrackedPot = 66010,

        [Annotation(Name = "[LD - Stormveil] Cracked Pot 66020")]
        LDStormveilCrackedPot_ = 66020,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [1] 10007780")]
        LDStormveilSmithingStone1___ = 10007780,

        [Annotation(Name = "[LD - Stormveil] Kukri 10007790")]
        LDStormveilKukri_ = 10007790,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [2] 10007800")]
        LDStormveilSmithingStone2______ = 10007800,

        [Annotation(Name = "[LD - Stormveil] Lump of Flesh 10007810")]
        LDStormveilLumpOfFlesh_ = 10007810,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [1] 10007820")]
        LDStormveilSmithingStone1____ = 10007820,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007830")]
        LDStormveilGoldenRune2_________ = 10007830,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [3] 10007840")]
        LDStormveilSmithingStone3_ = 10007840,

        [Annotation(Name = "[LD - Stormveil] Shabriri Grape 10007850")]
        LDStormveilShabririGrape = 10007850,

        [Annotation(Name = "[LD - Stormveil] Rainbow Stone 10007860")]
        LDStormveilRainbowStone = 10007860,

        [Annotation(Name = "[LD - Stormveil] Smithing Stone [2] 10007870")]
        LDStormveilSmithingStone2_______ = 10007870,

        [Annotation(Name = "[LD - Stormveil] Arteria Leaf 10007880")]
        LDStormveilArteriaLeaf_ = 10007880,

        [Annotation(Name = "[LD - Stormveil] Golden Rune [2] 10007890")]
        LDStormveilGoldenRune2__________ = 10007890,

        [Annotation(Name = "[LD - Stormveil] Poisonbloom 10007900")]
        LDStormveilPoisonbloom = 10007900,

        [Annotation(Name = "[LD - Stormveil] Smoldering Butterfly 10007910")]
        LDStormveilSmolderingButterfly__ = 10007910,

        [Annotation(Name = "[LD - Stormveil] Stonesword Key 10007920")]
        LDStormveilStoneswordKey__ = 10007920,

        [Annotation(Name = "[LD - Stormveil] Throwing Dagger 10007930")]
        LDStormveilThrowingDagger__ = 10007930,

        [Annotation(Name = "[LD - Stormveil] Prince of Death's Pustule 10007940")]
        LDStormveilPrinceOfDeathsPustule = 10007940,

        [Annotation(Name = "[LD - Stormveil] Kukri 10007950")]
        LDStormveilKukri__ = 10007950,

        [Annotation(Name = "[LD - Stormveil] Pickled Turtle Neck 10007960")]
        LDStormveilPickledTurtleNeck = 10007960,

        [Annotation(Name = "[LD - Stormveil] Godslayer's Seal 10007965")]
        LDStormveilGodslayersSeal = 10007965,

        [Annotation(Name = "[LD - Stormveil] Mimic's Veil 10007970")]
        LDStormveilMimicsVeil = 10007970,

        [Annotation(Name = "[LD - Stormveil] Curved Sword Talisman 10007975")]
        LDStormveilCurvedSwordTalisman = 10007975,

        [Annotation(Name = "[LD - Stormveil] Somber Smithing Stone [2] 10007980")]
        LDStormveilSomberSmithingStone2_ = 10007980,

        [Annotation(Name = "[LD - Stormveil] Godskin Prayerbook 10007990")]
        LDStormveilGodskinPrayerbook = 10007990,

        [Annotation(Name = "[LD - Stormveil] Somber Smithing Stone [1] 10007085")]
        LDStormveilSomberSmithingStone1 = 10007085,

        [Annotation(Name = "[LD - Stormveil] Golden Seed 10007195")]
        LDStormveilGoldenSeed_ = 10007195,

        [Annotation(Name = "[LD - Stormveil] [Incantation] Aspects of the Crucible: Horns 10007295")]
        LDStormveilIncantationAspectsOfTheCrucibleHorns = 10007295,

        [Annotation(Name = "[LD - Stormveil] Wooden Greatshield 10007005")]
        LDStormveilWoodenGreatshield = 10007005,

        [Annotation(Name = "[LD - Stormveil] Hawk Crest Wooden Shield 10007015")]
        LDStormveilHawkCrestWoodenShield = 10007015,

        [Annotation(Name = "[LD - Stormveil] Misericorde 10007025")]
        LDStormveilMisericorde = 10007025,

        [Annotation(Name = "[LD - Stormveil] Brick Hammer 10007035")]
        LDStormveilBrickHammer = 10007035,

        [Annotation(Name = "[LD - Chapel of Anticipation] Tarnished's Wizened Finger 60210")]
        LDChapelOfAnticipationTarnishedsWizenedFinger = 60210,

        [Annotation(Name = "[LD - Chapel of Anticipation] The Stormhawk King 10017010")]
        LDChapelOfAnticipationTheStormhawkKing = 10017010,

        [Annotation(Name = "[LD - Chapel of Anticipation] Stormhawk Deenh 10017900")]
        LDChapelOfAnticipationStormhawkDeenh = 10017900,

        [Annotation(Name = "[LD - Leyndell] Magic Grease 11007000")]
        LDLeyndellMagicGrease = 11007000,

        [Annotation(Name = "[LD - Leyndell] Furlcalling Finger Remedy 11007010")]
        LDLeyndellFurlcallingFingerRemedy = 11007010,

        [Annotation(Name = "[LD - Leyndell] Hefty Beast Bone 11007020")]
        LDLeyndellHeftyBeastBone = 11007020,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [4] 11007030")]
        LDLeyndellSmithingStone4 = 11007030,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [7] 11007040")]
        LDLeyndellGoldenRune7 = 11007040,

        [Annotation(Name = "[LD - Leyndell] Cave Moss 11007050")]
        LDLeyndellCaveMoss = 11007050,

        [Annotation(Name = "[LD - Leyndell] Preserving Boluses 11007060")]
        LDLeyndellPreservingBoluses = 11007060,

        [Annotation(Name = "[LD - Leyndell] String 11007070")]
        LDLeyndellString = 11007070,

        [Annotation(Name = "[LD - Leyndell] Upper-Class Robe 11007080")]
        LDLeyndellUpperClassRobe = 11007080,

        [Annotation(Name = "[LD - Leyndell] Miranda Powder 11007090")]
        LDLeyndellMirandaPowder = 11007090,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [6] 11007100")]
        LDLeyndellSmithingStone6 = 11007100,

        [Annotation(Name = "[LD - Leyndell] Warming Stone 11007110")]
        LDLeyndellWarmingStone = 11007110,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [10] 11007120")]
        LDLeyndellGoldenRune10 = 11007120,

        [Annotation(Name = "[LD - Leyndell] Perfume Bottle 66710")]
        LDLeyndellPerfumeBottle = 66710,

        [Annotation(Name = "[LD - Leyndell] Fan Daggers 11007140")]
        LDLeyndellFanDaggers = 11007140,

        [Annotation(Name = "[LD - Leyndell] Marika's Golden Siigl 11007150")]
        LDLeyndellMarikasGoldenSiigl = 11007150,

        [Annotation(Name = "[LD - Leyndell] Holy Grease 11007160")]
        LDLeyndellHolyGrease = 11007160,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [8] 11007170")]
        LDLeyndellGoldenRune8 = 11007170,

        [Annotation(Name = "[LD - Leyndell] Old Fang 11007180")]
        LDLeyndellOldFang = 11007180,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [4] 11007190")]
        LDLeyndellSmithingStone4_ = 11007190,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [8] 11007200")]
        LDLeyndellGoldenRune8_ = 11007200,

        [Annotation(Name = "[LD - Leyndell] Somber Smithing Stone [5] 11007210")]
        LDLeyndellSomberSmithingStone5 = 11007210,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [8] 11007220")]
        LDLeyndellGoldenRune8__ = 11007220,

        [Annotation(Name = "[LD - Leyndell] Lordsworn's Bolt 11007230")]
        LDLeyndellLordswornsBolt = 11007230,

        [Annotation(Name = "[LD - Leyndell] Tarnished Golden Sunflower 11007240")]
        LDLeyndellTarnishedGoldenSunflower = 11007240,

        [Annotation(Name = "[LD - Leyndell] Stonesword Key 11007250")]
        LDLeyndellStoneswordKey = 11007250,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [10] 11007260")]
        LDLeyndellGoldenRune10_ = 11007260,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [8] 11007270")]
        LDLeyndellGoldenRune8___ = 11007270,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [9] 11007280")]
        LDLeyndellGoldenRune9 = 11007280,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [6] 11007290")]
        LDLeyndellSmithingStone6_ = 11007290,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [9] 11007300")]
        LDLeyndellGoldenRune9_ = 11007300,

        [Annotation(Name = "[LD - Leyndell] Arteria Leaf 11007310")]
        LDLeyndellArteriaLeaf = 11007310,

        [Annotation(Name = "[LD - Leyndell] Imp Head (Corpse) 11007320")]
        LDLeyndellImpHeadCorpse = 11007320,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [9] 11007330")]
        LDLeyndellGoldenRune9__ = 11007330,

        [Annotation(Name = "[LD - Leyndell] Seedbed Curse 11007340")]
        LDLeyndellSeedbedCurse = 11007340,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [6] 11007350")]
        LDLeyndellSmithingStone6__ = 11007350,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [9] 11007360")]
        LDLeyndellGoldenRune9___ = 11007360,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [5] 11007370")]
        LDLeyndellSmithingStone5 = 11007370,

        [Annotation(Name = "[LD - Leyndell] Stonesword Key 11007380")]
        LDLeyndellStoneswordKey_ = 11007380,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [12] 11007390")]
        LDLeyndellGoldenRune12 = 11007390,

        [Annotation(Name = "[LD - Leyndell] Beast Blood 11007400")]
        LDLeyndellBeastBlood = 11007400,

        [Annotation(Name = "[LD - Leyndell] Nascent Butterfly 11007410")]
        LDLeyndellNascentButterfly = 11007410,

        [Annotation(Name = "[LD - Leyndell] Exalted Flesh 11007420")]
        LDLeyndellExaltedFlesh = 11007420,

        [Annotation(Name = "[LD - Leyndell] Soporific Grease 11007430")]
        LDLeyndellSoporificGrease = 11007430,

        [Annotation(Name = "[LD - Leyndell] Somber Smithing Stone [6] 11007440")]
        LDLeyndellSomberSmithingStone6 = 11007440,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [9] 11007450")]
        LDLeyndellGoldenRune9____ = 11007450,

        [Annotation(Name = "[LD - Leyndell] Lightningproof Dried Liver 11007460")]
        LDLeyndellLightningproofDriedLiver = 11007460,

        [Annotation(Name = "[LD - Leyndell] Perfume Bottle 66720")]
        LDLeyndellPerfumeBottle_ = 66720,

        [Annotation(Name = "[LD - Leyndell] Gravel Stone 11007480")]
        LDLeyndellGravelStone = 11007480,

        [Annotation(Name = "[LD - Leyndell] Stonesword Key 11007490")]
        LDLeyndellStoneswordKey__ = 11007490,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [9] 11007500")]
        LDLeyndellGoldenRune9_____ = 11007500,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [4] 11007510")]
        LDLeyndellSmithingStone4__ = 11007510,

        [Annotation(Name = "[LD - Leyndell] Golden Arrow 11007520")]
        LDLeyndellGoldenArrow = 11007520,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [6] 11007530")]
        LDLeyndellSmithingStone6___ = 11007530,

        [Annotation(Name = "[LD - Leyndell] Clarifying Boluses 11007540")]
        LDLeyndellClarifyingBoluses = 11007540,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [8] 11007550")]
        LDLeyndellGoldenRune8____ = 11007550,

        [Annotation(Name = "[LD - Leyndell] Cracked Pot 66130")]
        LDLeyndellCrackedPot = 66130,

        [Annotation(Name = "[LD - Leyndell] Lost Ashes of War 11007570")]
        LDLeyndellLostAshesOfWar = 11007570,

        [Annotation(Name = "[LD - Leyndell] Rune Arc 11007580")]
        LDLeyndellRuneArc = 11007580,

        [Annotation(Name = "[LD - Leyndell] Erdsteel Dagger 11007590")]
        LDLeyndellErdsteelDagger = 11007590,

        [Annotation(Name = "[LD - Leyndell] Poisonbone Dart 11007600")]
        LDLeyndellPoisonboneDart = 11007600,

        [Annotation(Name = "[LD - Leyndell] Somber Smithing Stone [6] 11007610")]
        LDLeyndellSomberSmithingStone6_ = 11007610,

        [Annotation(Name = "[LD - Leyndell] Albinauric Bloodclot 11007620")]
        LDLeyndellAlbinauricBloodclot = 11007620,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [5] 11007630")]
        LDLeyndellSmithingStone5_ = 11007630,

        [Annotation(Name = "[LD - Leyndell] Pickled Turtle Neck 11007640")]
        LDLeyndellPickledTurtleNeck = 11007640,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [6] 11007650")]
        LDLeyndellSmithingStone6____ = 11007650,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [9] 11007660")]
        LDLeyndellGoldenRune9______ = 11007660,

        [Annotation(Name = "[LD - Leyndell] Black Bow 11007670")]
        LDLeyndellBlackBow = 11007670,

        [Annotation(Name = "[LD - Leyndell] Dragonwound Grease 11007680")]
        LDLeyndellDragonwoundGrease = 11007680,

        [Annotation(Name = "[LD - Leyndell] Two Fingers' Prayerbook 11007690")]
        LDLeyndellTwoFingersPrayerbook = 11007690,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [5] 11007700")]
        LDLeyndellSmithingStone5__ = 11007700,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [9] 11007710")]
        LDLeyndellGoldenRune9_______ = 11007710,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [6] 11007720")]
        LDLeyndellSmithingStone6_____ = 11007720,

        [Annotation(Name = "[LD - Leyndell] Holyproof Dried Liver 11007730")]
        LDLeyndellHolyproofDriedLiver = 11007730,

        [Annotation(Name = "[LD - Leyndell] Furlcalling Finger Remedy 11007740")]
        LDLeyndellFurlcallingFingerRemedy_ = 11007740,

        [Annotation(Name = "[LD - Leyndell] Gravel Stone 11007750")]
        LDLeyndellGravelStone_ = 11007750,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [5] 11007760")]
        LDLeyndellSmithingStone5___ = 11007760,

        [Annotation(Name = "[LD - Leyndell] Old Fang 11007770")]
        LDLeyndellOldFang_ = 11007770,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [6] 11007780")]
        LDLeyndellSmithingStone6______ = 11007780,

        [Annotation(Name = "[LD - Leyndell] Nascent Butterfly 11007790")]
        LDLeyndellNascentButterfly_ = 11007790,

        [Annotation(Name = "[LD - Leyndell] Stonesword Key 11007800")]
        LDLeyndellStoneswordKey___ = 11007800,

        [Annotation(Name = "[LD - Leyndell] Fan Daggers 11007810")]
        LDLeyndellFanDaggers_ = 11007810,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [6] 11007820")]
        LDLeyndellSmithingStone6_______ = 11007820,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [9] 11007830")]
        LDLeyndellGoldenRune9________ = 11007830,

        [Annotation(Name = "[LD - Leyndell] Gravel Stone 11007840")]
        LDLeyndellGravelStone__ = 11007840,

        [Annotation(Name = "[LD - Leyndell] Seedbed Curse 11007850")]
        LDLeyndellSeedbedCurse_ = 11007850,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [5] 11007860")]
        LDLeyndellSmithingStone5____ = 11007860,

        [Annotation(Name = "[LD - Leyndell] Furlcalling Finger Remedy 11007870")]
        LDLeyndellFurlcallingFingerRemedy__ = 11007870,

        [Annotation(Name = "[LD - Leyndell] Star Fist 11007880")]
        LDLeyndellStarFist = 11007880,

        [Annotation(Name = "[LD - Leyndell] Holy Grease 11007890")]
        LDLeyndellHolyGrease_ = 11007890,

        [Annotation(Name = "[LD - Leyndell] Smithing Stone [6] 11007900")]
        LDLeyndellSmithingStone6________ = 11007900,

        [Annotation(Name = "[LD - Leyndell] Golden Order Principia 11007910")]
        LDLeyndellGoldenOrderPrincipia = 11007910,

        [Annotation(Name = "[LD - Leyndell] Somber Smithing Stone [5] 11007920")]
        LDLeyndellSomberSmithingStone5_ = 11007920,

        [Annotation(Name = "[LD - Leyndell] Holy Grease 11007930")]
        LDLeyndellHolyGrease__ = 11007930,

        [Annotation(Name = "[LD - Leyndell] Holy Grease 11007940")]
        LDLeyndellHolyGrease___ = 11007940,

        [Annotation(Name = "[LD - Leyndell] Rune Arc 11007950")]
        LDLeyndellRuneArc_ = 11007950,

        [Annotation(Name = "[LD - Leyndell] Erdtree Seal 11007960")]
        LDLeyndellErdtreeSeal = 11007960,

        [Annotation(Name = "[LD - Leyndell] Coded Sword 11007970")]
        LDLeyndellCodedSword = 11007970,

        [Annotation(Name = "[LD - Leyndell] Stonesword Key 11007980")]
        LDLeyndellStoneswordKey____ = 11007980,

        [Annotation(Name = "[LD - Leyndell] Raging Wolf Helm 11007985")]
        LDLeyndellRagingWolfHelm = 11007985,

        [Annotation(Name = "[LD - Leyndell] Golden Seed 11007990")]
        LDLeyndellGoldenSeed = 11007990,

        [Annotation(Name = "[LD - Leyndell] [Incantation] Blessing of the Erdtree 11007991")]
        LDLeyndellIncantationBlessingOfTheErdtree = 11007991,

        [Annotation(Name = "[LD - Leyndell] Sanctified Whetblade 65660")]
        LDLeyndellSanctifiedWhetblade = 65660,

        [Annotation(Name = "[LD - Leyndell] Blessed Dew Talisman 11007994")]
        LDLeyndellBlessedDewTalisman = 11007994,

        [Annotation(Name = "[LD - Leyndell] Ritual Shield Talisman 11007996")]
        LDLeyndellRitualShieldTalisman = 11007996,

        [Annotation(Name = "[LD - Leyndell] Bolt of Gransax 11007997")]
        LDLeyndellBoltOfGransax = 11007997,

        [Annotation(Name = "[LD - Leyndell] Gargoyle's Halberd 11007987")]
        LDLeyndellGargoylesHalberd = 11007987,

        [Annotation(Name = "[LD - Leyndell] Golden Seed 11007993")]
        LDLeyndellGoldenSeed_ = 11007993,

        [Annotation(Name = "[LD - Leyndell] Somber Smithing Stone [7] 11007995")]
        LDLeyndellSomberSmithingStone7 = 11007995,

        [Annotation(Name = "[LD - Leyndell] Lord's Rune 11007998")]
        LDLeyndellLordsRune = 11007998,

        [Annotation(Name = "[LD - Leyndell] Alberich's Pointed Hat 11007005")]
        LDLeyndellAlberichsPointedHat = 11007005,

        [Annotation(Name = "[LD - Leyndell] Erdtree Bow 11007015")]
        LDLeyndellErdtreeBow = 11007015,

        [Annotation(Name = "[LD - Leyndell] Celestial Dew 11007025")]
        LDLeyndellCelestialDew = 11007025,

        [Annotation(Name = "[LD - Leyndell] Deathbed Dress 11007035")]
        LDLeyndellDeathbedDress = 11007035,

        [Annotation(Name = "[LD - Leyndell] Lionel's Helm 11007045")]
        LDLeyndellLionelsHelm = 11007045,

        [Annotation(Name = "[LD - Leyndell] Hammer 11007055")]
        LDLeyndellHammer = 11007055,

        [Annotation(Name = "[LD - Leyndell] Rune Arc 11007065")]
        LDLeyndellRuneArc__ = 11007065,

        [Annotation(Name = "[LD - Leyndell] Hero's Rune [1] 11007075")]
        LDLeyndellHerosRune1 = 11007075,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [12] 11007085")]
        LDLeyndellGoldenRune12_ = 11007085,

        [Annotation(Name = "[LD - Leyndell] Guilty Hood 11007095")]
        LDLeyndellGuiltyHood = 11007095,

        [Annotation(Name = "[LD - Leyndell] Stormhawk Axe 11007105")]
        LDLeyndellStormhawkAxe = 11007105,

        [Annotation(Name = "[LD - Leyndell] Cane Sword 11007115")]
        LDLeyndellCaneSword = 11007115,

        [Annotation(Name = "[LD - Leyndell] Black-Key Bolt 11007125")]
        LDLeyndellBlackKeyBolt = 11007125,

        [Annotation(Name = "[LD - Leyndell] Gravel Stone 11007135")]
        LDLeyndellGravelStone___ = 11007135,

        [Annotation(Name = "[LD - Leyndell] Somber Smithing Stone [6] 11007145")]
        LDLeyndellSomberSmithingStone6__ = 11007145,

        [Annotation(Name = "[LD - Leyndell] Hero's Rune [5] 11007155")]
        LDLeyndellHerosRune5 = 11007155,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [11] 11007165")]
        LDLeyndellGoldenRune11 = 11007165,

        [Annotation(Name = "[LD - Leyndell] Hero's Rune [2] 11007175")]
        LDLeyndellHerosRune2 = 11007175,

        [Annotation(Name = "[LD - Leyndell] Somber Smithing Stone [6] 11007185")]
        LDLeyndellSomberSmithingStone6___ = 11007185,

        [Annotation(Name = "[LD - Leyndell] Somber Smithing Stone [6] 11007195")]
        LDLeyndellSomberSmithingStone6____ = 11007195,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [13] 11007205")]
        LDLeyndellGoldenRune13 = 11007205,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [10] 11007215")]
        LDLeyndellGoldenRune10__ = 11007215,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [12] 11007225")]
        LDLeyndellGoldenRune12__ = 11007225,

        [Annotation(Name = "[LD - Leyndell] Lightningproof Dried Liver 11007235")]
        LDLeyndellLightningproofDriedLiver_ = 11007235,

        [Annotation(Name = "[LD - Leyndell] Golden Rune [11] 11007245")]
        LDLeyndellGoldenRune11_ = 11007245,

        [Annotation(Name = "[LD - Ashen Leyndell] Erdtree Heal 11057000")]
        LDAshenLeyndellErdtreeHeal = 11057000,

        [Annotation(Name = "[LD - Ashen Leyndell] Somber Ancient Dragon Smithing Stone 11057010")]
        LDAshenLeyndellSomberAncientDragonSmithingStone = 11057010,

        [Annotation(Name = "[LD - Ashen Leyndell] Tarnished Golden Sunflower 11057020")]
        LDAshenLeyndellTarnishedGoldenSunflower = 11057020,

        [Annotation(Name = "[LD - Ashen Leyndell] Rune Arc 11057030")]
        LDAshenLeyndellRuneArc = 11057030,

        [Annotation(Name = "[LD - Ashen Leyndell] Golden Sunflower 11057040")]
        LDAshenLeyndellGoldenSunflower = 11057040,

        [Annotation(Name = "[LD - Ashen Leyndell] Hero's Rune [4] 11057050")]
        LDAshenLeyndellHerosRune4 = 11057050,

        [Annotation(Name = "[LD - Ashen Leyndell] Erdtree's Favor +2 11057100")]
        LDAshenLeyndellErdtreesFavor2 = 11057100,

        [Annotation(Name = "[LD - Roundtable Hold] Cipher Pata 11107000")]
        LDRoundtableHoldCipherPata = 11107000,

        [Annotation(Name = "[LD - Roundtable Hold] Assassin's Prayerbook 11107700")]
        LDRoundtableHoldAssassinsPrayerbook = 11107700,

        [Annotation(Name = "[LD - Roundtable Hold] Crepus's Black-Key Crossbow 11107710")]
        LDRoundtableHoldCrepussBlackKeyCrossbow = 11107710,

        [Annotation(Name = "[LD - Roundtable Hold] Taunter's Tongue 60300")]
        LDRoundtableHoldTauntersTongue = 60300,

        [Annotation(Name = "[LD - Roundtable Hold] Clinging Bone 11107900")]
        LDRoundtableHoldClingingBone = 11107900,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Map: Ainsel 62060")]
        LDAinselLakeOfRotMapAinsel = 62060,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Map: Lake of Rot 62061")]
        LDAinselLakeOfRotMapLakeOfRot = 62061,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Nomadic Warrior's Cookbook [22] 67890")]
        LDAinselLakeOfRotNomadicWarriorsCookbook22 = 67890,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [8] 12017030")]
        LDAinselLakeOfRotSomberSmithingStone8 = 12017030,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [1] 12017040")]
        LDAinselLakeOfRotGoldenRune1 = 12017040,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [2] 12017050")]
        LDAinselLakeOfRotGoldenRune2 = 12017050,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [1] 12017060")]
        LDAinselLakeOfRotSmithingStone1 = 12017060,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Magic Grease 12017070")]
        LDAinselLakeOfRotMagicGrease = 12017070,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [3] 12017080")]
        LDAinselLakeOfRotGoldenRune3 = 12017080,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [9] 12017090")]
        LDAinselLakeOfRotSomberSmithingStone9 = 12017090,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Seed 12017100")]
        LDAinselLakeOfRotGoldenSeed = 12017100,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Rot Grease 12017110")]
        LDAinselLakeOfRotRotGrease = 12017110,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Black-Key Bolt 12017120")]
        LDAinselLakeOfRotBlackKeyBolt = 12017120,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Warming Stone 12017130")]
        LDAinselLakeOfRotWarmingStone = 12017130,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Lightningproof Dried Liver 12017140")]
        LDAinselLakeOfRotLightningproofDriedLiver = 12017140,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [3] 12017150")]
        LDAinselLakeOfRotSmithingStone3 = 12017150,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Shattershard Arrow (Fletched) 12017160")]
        LDAinselLakeOfRotShattershardArrowFletched = 12017160,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Grace Mimic 12017170")]
        LDAinselLakeOfRotGraceMimic = 12017170,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Immunizing Horn Charm 12017180")]
        LDAinselLakeOfRotImmunizingHornCharm = 12017180,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [3] 12017190")]
        LDAinselLakeOfRotSmithingStone3_ = 12017190,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [1] 12017200")]
        LDAinselLakeOfRotGoldenRune1_ = 12017200,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [3] 12017210")]
        LDAinselLakeOfRotSmithingStone3__ = 12017210,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Throwing Dagger 12017220")]
        LDAinselLakeOfRotThrowingDagger = 12017220,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [3] 12017230")]
        LDAinselLakeOfRotSmithingStone3___ = 12017230,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [2] 12017240")]
        LDAinselLakeOfRotGoldenRune2_ = 12017240,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Shield Grease 12017250")]
        LDAinselLakeOfRotShieldGrease = 12017250,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [3] 12017260")]
        LDAinselLakeOfRotSmithingStone3____ = 12017260,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [4] 12017270")]
        LDAinselLakeOfRotSmithingStone4 = 12017270,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [2] 12017280")]
        LDAinselLakeOfRotSmithingStone2 = 12017280,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Formic Rock 12017290")]
        LDAinselLakeOfRotFormicRock = 12017290,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Crystal Dart 12017300")]
        LDAinselLakeOfRotCrystalDart = 12017300,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Soap 12017310")]
        LDAinselLakeOfRotSoap = 12017310,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [3] 12017320")]
        LDAinselLakeOfRotSomberSmithingStone3 = 12017320,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Melted Mushroom 12017330")]
        LDAinselLakeOfRotMeltedMushroom = 12017330,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [3] 12017340")]
        LDAinselLakeOfRotGoldenRune3_ = 12017340,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Celestial Dew 12017350")]
        LDAinselLakeOfRotCelestialDew = 12017350,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [3] 12017360")]
        LDAinselLakeOfRotGoldenRune3__ = 12017360,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Aeonian Butterfly 12017370")]
        LDAinselLakeOfRotAeonianButterfly = 12017370,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017380")]
        LDAinselLakeOfRotSomberSmithingStone7 = 12017380,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Silver Firefly 12017390")]
        LDAinselLakeOfRotSilverFirefly = 12017390,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [3] 12017400")]
        LDAinselLakeOfRotGoldenRune3___ = 12017400,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Magic Grease 12017410")]
        LDAinselLakeOfRotMagicGrease_ = 12017410,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [3] 12017420")]
        LDAinselLakeOfRotGoldenRune3____ = 12017420,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Furlcalling Finger Remedy 12017430")]
        LDAinselLakeOfRotFurlcallingFingerRemedy = 12017430,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [1] 12017440")]
        LDAinselLakeOfRotSmithingStone1_ = 12017440,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [9] 12017450")]
        LDAinselLakeOfRotGoldenRune9 = 12017450,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Mushroom Crown 12017460")]
        LDAinselLakeOfRotMushroomCrown = 12017460,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Preserving Boluses 12017470")]
        LDAinselLakeOfRotPreservingBoluses = 12017470,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [7] 12017480")]
        LDAinselLakeOfRotGoldenRune7 = 12017480,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017490")]
        LDAinselLakeOfRotGoldenRune10 = 12017490,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [7] 12017500")]
        LDAinselLakeOfRotGoldenRune7_ = 12017500,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Human Bone Shard 12017510")]
        LDAinselLakeOfRotHumanBoneShard = 12017510,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [6] 12017520")]
        LDAinselLakeOfRotSomberSmithingStone6 = 12017520,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [4] 12017530")]
        LDAinselLakeOfRotSmithingStone4_ = 12017530,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Stimulating Boluses 12017540")]
        LDAinselLakeOfRotStimulatingBoluses = 12017540,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Shield Grease 12017550")]
        LDAinselLakeOfRotShieldGrease_ = 12017550,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017560")]
        LDAinselLakeOfRotGoldenRune10_ = 12017560,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Wing of Astel 12017570")]
        LDAinselLakeOfRotWingOfAstel = 12017570,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Stonesword Key 12017580")]
        LDAinselLakeOfRotStoneswordKey = 12017580,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [7] 12017590")]
        LDAinselLakeOfRotGoldenRune7__ = 12017590,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017600")]
        LDAinselLakeOfRotGoldenRune10__ = 12017600,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Fan Daggers 12017610")]
        LDAinselLakeOfRotFanDaggers = 12017610,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [6] 12017620")]
        LDAinselLakeOfRotSmithingStone6 = 12017620,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Archer Ashes 12017630")]
        LDAinselLakeOfRotArcherAshes = 12017630,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017640")]
        LDAinselLakeOfRotGoldenRune10___ = 12017640,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017650")]
        LDAinselLakeOfRotGoldenRune10____ = 12017650,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017660")]
        LDAinselLakeOfRotGoldenRune10_____ = 12017660,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [6] 12017670")]
        LDAinselLakeOfRotSmithingStone6_ = 12017670,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017680")]
        LDAinselLakeOfRotGoldenRune10______ = 12017680,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Great Ghost Glovewort 12017690")]
        LDAinselLakeOfRotGreatGhostGlovewort = 12017690,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017700")]
        LDAinselLakeOfRotSomberSmithingStone7_ = 12017700,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Clayman Ashes 12017710")]
        LDAinselLakeOfRotClaymanAshes = 12017710,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Stonesword Key 12017720")]
        LDAinselLakeOfRotStoneswordKey_ = 12017720,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Magic Grease 12017730")]
        LDAinselLakeOfRotMagicGrease__ = 12017730,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Drawstring Holy Grease 12017740")]
        LDAinselLakeOfRotDrawstringHolyGrease = 12017740,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Silver Tear Husk 12017750")]
        LDAinselLakeOfRotSilverTearHusk = 12017750,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [6] 12017760")]
        LDAinselLakeOfRotSmithingStone6__ = 12017760,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Celestial Dew 12017770")]
        LDAinselLakeOfRotCelestialDew_ = 12017770,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017780")]
        LDAinselLakeOfRotSomberSmithingStone7__ = 12017780,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Celestial Dew 12017790")]
        LDAinselLakeOfRotCelestialDew__ = 12017790,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [4] 12017800")]
        LDAinselLakeOfRotSmithingStone4__ = 12017800,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [5] 12017810")]
        LDAinselLakeOfRotSmithingStone5 = 12017810,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017820")]
        LDAinselLakeOfRotGoldenRune10_______ = 12017820,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [5] 12017830")]
        LDAinselLakeOfRotSmithingStone5_ = 12017830,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Fan Daggers 12017840")]
        LDAinselLakeOfRotFanDaggers_ = 12017840,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017850")]
        LDAinselLakeOfRotGoldenRune10________ = 12017850,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [7] 12017860")]
        LDAinselLakeOfRotSmithingStone7 = 12017860,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Smithing Stone [6] 12017870")]
        LDAinselLakeOfRotSmithingStone6___ = 12017870,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [8] 12017880")]
        LDAinselLakeOfRotSomberSmithingStone8_ = 12017880,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017890")]
        LDAinselLakeOfRotSomberSmithingStone7___ = 12017890,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Wing of Astel 12017900")]
        LDAinselLakeOfRotWingOfAstel_ = 12017900,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Great Ghost Glovewort 12017910")]
        LDAinselLakeOfRotGreatGhostGlovewort_ = 12017910,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Scorpion's Stinger 12017920")]
        LDAinselLakeOfRotScorpionsStinger = 12017920,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Fire Longsword 12017930")]
        LDAinselLakeOfRotFireLongsword = 12017930,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017940")]
        LDAinselLakeOfRotSomberSmithingStone7____ = 12017940,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Ghost Glovewort [9] 12017950")]
        LDAinselLakeOfRotGhostGlovewort9 = 12017950,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Moon of Nokstella 12017960")]
        LDAinselLakeOfRotMoonOfNokstella = 12017960,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Ant's Skull Plate 12017970")]
        LDAinselLakeOfRotAntsSkullPlate = 12017970,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Ghost-Glovewort Picker's Bell Bearing [2] 12017980")]
        LDAinselLakeOfRotGhostGlovewortPickersBellBearing2 = 12017980,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Nightmaiden & Swordstress Puppets 12017990")]
        LDAinselLakeOfRotNightmaidenSwordstressPuppets = 12017990,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Somber Smithing Stone [7] 12017995")]
        LDAinselLakeOfRotSomberSmithingStone7_____ = 12017995,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Seed 12017997")]
        LDAinselLakeOfRotGoldenSeed_ = 12017997,

        [Annotation(Name = "[LD - Ainsel/Lake of Rot] Golden Rune [10] 12017105")]
        LDAinselLakeOfRotGoldenRune10_________ = 12017105,

        [Annotation(Name = "[LD - Nokron / Siofra] Mottled Necklace 12027000")]
        LDNokronSiofraMottledNecklace = 12027000,

        [Annotation(Name = "[LD - Nokron / Siofra] Black Whetblade 65720")]
        LDNokronSiofraBlackWhetblade = 65720,

        [Annotation(Name = "[LD - Nokron / Siofra] Missionary's Cookbook [5] 67630")]
        LDNokronSiofraMissionarysCookbook5 = 67630,

        [Annotation(Name = "[LD - Nokron / Siofra] Arteria Leaf 12027030")]
        LDNokronSiofraArteriaLeaf = 12027030,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Seed 12027040")]
        LDNokronSiofraGoldenSeed = 12027040,

        [Annotation(Name = "[LD - Nokron / Siofra] Marika's Scarseal 12027050")]
        LDNokronSiofraMarikasScarseal = 12027050,

        [Annotation(Name = "[LD - Nokron / Siofra] Map: Siofra River 62063")]
        LDNokronSiofraMapSiofraRiver = 62063,

        [Annotation(Name = "[LD - Nokron / Siofra] Lightning Bastard Sword 12027070")]
        LDNokronSiofraLightningBastardSword = 12027070,

        [Annotation(Name = "[LD - Nokron / Siofra] Fingerslayer Blade 12027080")]
        LDNokronSiofraFingerslayerBlade = 12027080,

        [Annotation(Name = "[LD - Nokron / Siofra] Ancestral Infant's Head 12027090")]
        LDNokronSiofraAncestralInfantsHead = 12027090,

        [Annotation(Name = "[LD - Nokron / Siofra] Crab Eggs 12027100")]
        LDNokronSiofraCrabEggs = 12027100,

        [Annotation(Name = "[LD - Nokron / Siofra] Beast Liver 12027110")]
        LDNokronSiofraBeastLiver = 12027110,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [3] 12027120")]
        LDNokronSiofraGoldenRune3 = 12027120,

        [Annotation(Name = "[LD - Nokron / Siofra] Armorer's Cookbook [6] 67300")]
        LDNokronSiofraArmorersCookbook6 = 67300,

        [Annotation(Name = "[LD - Nokron / Siofra] Inverted Hawk Heater Shield 12027140")]
        LDNokronSiofraInvertedHawkHeaterShield = 12027140,

        [Annotation(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [2] 12027150")]
        LDNokronSiofraSomberSmithingStone2 = 12027150,

        [Annotation(Name = "[LD - Nokron / Siofra] Old Fang 12027160")]
        LDNokronSiofraOldFang = 12027160,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [2] 12027170")]
        LDNokronSiofraGoldenRune2 = 12027170,

        [Annotation(Name = "[LD - Nokron / Siofra] Shield Grease 12027180")]
        LDNokronSiofraShieldGrease = 12027180,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [3] 12027190")]
        LDNokronSiofraGoldenRune3_ = 12027190,

        [Annotation(Name = "[LD - Nokron / Siofra] Dappled Cured Meat 12027200")]
        LDNokronSiofraDappledCuredMeat = 12027200,

        [Annotation(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [2] 12027210")]
        LDNokronSiofraSomberSmithingStone2_ = 12027210,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [3] 12027220")]
        LDNokronSiofraSmithingStone3 = 12027220,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [2] 12027230")]
        LDNokronSiofraSmithingStone2 = 12027230,

        [Annotation(Name = "[LD - Nokron / Siofra] Dwelling Arrow 12027240")]
        LDNokronSiofraDwellingArrow = 12027240,

        [Annotation(Name = "[LD - Nokron / Siofra] Gold-Pickled Fowl Foot 12027250")]
        LDNokronSiofraGoldPickledFowlFoot = 12027250,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027260")]
        LDNokronSiofraGoldenRune4 = 12027260,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027270")]
        LDNokronSiofraGoldenRune4_ = 12027270,

        [Annotation(Name = "[LD - Nokron / Siofra] Furlcalling Finger Remedy 12027280")]
        LDNokronSiofraFurlcallingFingerRemedy = 12027280,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027290")]
        LDNokronSiofraGoldenRune4__ = 12027290,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [4] 12027300")]
        LDNokronSiofraSmithingStone4 = 12027300,

        [Annotation(Name = "[LD - Nokron / Siofra] Hefty Beast Bone 12027310")]
        LDNokronSiofraHeftyBeastBone = 12027310,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [6] 12027320")]
        LDNokronSiofraGoldenRune6 = 12027320,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [3] 12027330")]
        LDNokronSiofraGoldenRune3__ = 12027330,

        [Annotation(Name = "[LD - Nokron / Siofra] Sliver of Meat 12027340")]
        LDNokronSiofraSliverOfMeat = 12027340,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [3] 12027350")]
        LDNokronSiofraSmithingStone3_ = 12027350,

        [Annotation(Name = "[LD - Nokron / Siofra] Gold-Pickled Fowl Foot 12027360")]
        LDNokronSiofraGoldPickledFowlFoot_ = 12027360,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027370")]
        LDNokronSiofraGoldenRune4___ = 12027370,

        [Annotation(Name = "[LD - Nokron / Siofra] Dwelling Arrow 12027380")]
        LDNokronSiofraDwellingArrow_ = 12027380,

        [Annotation(Name = "[LD - Nokron / Siofra] Stonesword Key 12027390")]
        LDNokronSiofraStoneswordKey = 12027390,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027400")]
        LDNokronSiofraGoldenRune4____ = 12027400,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [2] 12027410")]
        LDNokronSiofraSmithingStone2_ = 12027410,

        [Annotation(Name = "[LD - Nokron / Siofra] Horn Bow 12027420")]
        LDNokronSiofraHornBow = 12027420,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027430")]
        LDNokronSiofraGoldenRune4_____ = 12027430,

        [Annotation(Name = "[LD - Nokron / Siofra] Sliver of Meat 12027440")]
        LDNokronSiofraSliverOfMeat_ = 12027440,

        [Annotation(Name = "[LD - Nokron / Siofra] Stonesword Key 12027450")]
        LDNokronSiofraStoneswordKey_ = 12027450,

        [Annotation(Name = "[LD - Nokron / Siofra] Rune Arc 12027460")]
        LDNokronSiofraRuneArc = 12027460,

        [Annotation(Name = "[LD - Nokron / Siofra] Clarifying Horn Charm 12027470")]
        LDNokronSiofraClarifyingHornCharm = 12027470,

        [Annotation(Name = "[LD - Nokron / Siofra] Lump of Flesh 12027480")]
        LDNokronSiofraLumpOfFlesh = 12027480,

        [Annotation(Name = "[LD - Nokron / Siofra] Clarifying Horn Charm +1 12027490")]
        LDNokronSiofraClarifyingHornCharm1 = 12027490,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027500")]
        LDNokronSiofraGoldenRune4______ = 12027500,

        [Annotation(Name = "[LD - Nokron / Siofra] Dwelling Arrow 12027510")]
        LDNokronSiofraDwellingArrow__ = 12027510,

        [Annotation(Name = "[LD - Nokron / Siofra] Nascent Butterfly 12027520")]
        LDNokronSiofraNascentButterfly = 12027520,

        [Annotation(Name = "[LD - Nokron / Siofra] Gold-Tinged Excrement 12027530")]
        LDNokronSiofraGoldTingedExcrement = 12027530,

        [Annotation(Name = "[LD - Nokron / Siofra] Fireproof Dried Liver 12027540")]
        LDNokronSiofraFireproofDriedLiver = 12027540,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12027550")]
        LDNokronSiofraGoldenRune4_______ = 12027550,

        [Annotation(Name = "[LD - Nokron / Siofra] Shining Horned Headband 12027560")]
        LDNokronSiofraShiningHornedHeadband = 12027560,

        [Annotation(Name = "[LD - Nokron / Siofra] Old Fang 12027570")]
        LDNokronSiofraOldFang_ = 12027570,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [5] 12027580")]
        LDNokronSiofraGoldenRune5 = 12027580,

        [Annotation(Name = "[LD - Nokron / Siofra] Kukri 12027590")]
        LDNokronSiofraKukri = 12027590,

        [Annotation(Name = "[LD - Nokron / Siofra] Hefty Beast Bone 12027600")]
        LDNokronSiofraHeftyBeastBone_ = 12027600,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12027610")]
        LDNokronSiofraSmithingStone5 = 12027610,

        [Annotation(Name = "[LD - Nokron / Siofra] Mottled Necklace +1 12027620")]
        LDNokronSiofraMottledNecklace1 = 12027620,

        [Annotation(Name = "[LD - Nokron / Siofra] Old Fang 12027630")]
        LDNokronSiofraOldFang__ = 12027630,

        [Annotation(Name = "[LD - Nokron / Siofra] Hefty Beast Bone 12027640")]
        LDNokronSiofraHeftyBeastBone__ = 12027640,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [4] 12027650")]
        LDNokronSiofraSmithingStone4_ = 12027650,

        [Annotation(Name = "[LD - Nokron / Siofra] Beast Blood 12027660")]
        LDNokronSiofraBeastBlood = 12027660,

        [Annotation(Name = "[LD - Nokron / Siofra] Beast Blood 12027670")]
        LDNokronSiofraBeastBlood_ = 12027670,

        [Annotation(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [5] 12027680")]
        LDNokronSiofraSomberSmithingStone5 = 12027680,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [12] 12027690")]
        LDNokronSiofraGoldenRune12 = 12027690,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12027700")]
        LDNokronSiofraGoldenRune1 = 12027700,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12027710")]
        LDNokronSiofraSmithingStone5_ = 12027710,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [2] 12027720")]
        LDNokronSiofraSmithingStone2__ = 12027720,

        [Annotation(Name = "[LD - Nokron / Siofra] Celestial Dew 12027730")]
        LDNokronSiofraCelestialDew = 12027730,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12027740")]
        LDNokronSiofraSmithingStone5__ = 12027740,

        [Annotation(Name = "[LD - Nokron / Siofra] Stonesword Key 12027750")]
        LDNokronSiofraStoneswordKey__ = 12027750,

        [Annotation(Name = "[LD - Nokron / Siofra] Silver Tear Husk 12027760")]
        LDNokronSiofraSilverTearHusk = 12027760,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12027770")]
        LDNokronSiofraGoldenRune1_ = 12027770,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [13] 12027780")]
        LDNokronSiofraGoldenRune13 = 12027780,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12027790")]
        LDNokronSiofraGoldenRune7 = 12027790,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12027800")]
        LDNokronSiofraSmithingStone5___ = 12027800,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [6] 12027810")]
        LDNokronSiofraGoldenRune6_ = 12027810,

        [Annotation(Name = "[LD - Nokron / Siofra] Rune Arc 12027820")]
        LDNokronSiofraRuneArc_ = 12027820,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [4] 12027830")]
        LDNokronSiofraSmithingStone4__ = 12027830,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12027840")]
        LDNokronSiofraGoldenRune1__ = 12027840,

        [Annotation(Name = "[LD - Nokron / Siofra] Voidbane Talisman 12027850")]
        LDNokronSiofraVoidbaneTalisman = 12027850,

        [Annotation(Name = "[LD - Nokron / Siofra] Rune Arc 12027860")]
        LDNokronSiofraRuneArc__ = 12027860,

        [Annotation(Name = "[LD - Nokron / Siofra] Celestial Dew 12027870")]
        LDNokronSiofraCelestialDew_ = 12027870,

        [Annotation(Name = "[LD - Nokron / Siofra] Mimic Tear Ashes 12027880")]
        LDNokronSiofraMimicTearAshes = 12027880,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12027890")]
        LDNokronSiofraGoldenRune7_ = 12027890,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [3] 12027900")]
        LDNokronSiofraSmithingStone3__ = 12027900,

        [Annotation(Name = "[LD - Nokron / Siofra] Nox Flowing Hammer 12027910")]
        LDNokronSiofraNoxFlowingHammer = 12027910,

        [Annotation(Name = "[LD - Nokron / Siofra] Celestial Dew 12027920")]
        LDNokronSiofraCelestialDew__ = 12027920,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12027930")]
        LDNokronSiofraGoldenRune7__ = 12027930,

        [Annotation(Name = "[LD - Nokron / Siofra] Soft Cotton 12027940")]
        LDNokronSiofraSoftCotton = 12027940,

        [Annotation(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [5] 12027950")]
        LDNokronSiofraSomberSmithingStone5_ = 12027950,

        [Annotation(Name = "[LD - Nokron / Siofra] Dragonwound Grease 12027960")]
        LDNokronSiofraDragonwoundGrease = 12027960,

        [Annotation(Name = "[LD - Nokron / Siofra] Slumbering Egg 12027970")]
        LDNokronSiofraSlumberingEgg = 12027970,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12027980")]
        LDNokronSiofraGoldenRune7___ = 12027980,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12027990")]
        LDNokronSiofraGoldenRune7____ = 12027990,

        [Annotation(Name = "[LD - Nokron / Siofra] Crucible Hornshield 12027435")]
        LDNokronSiofraCrucibleHornshield = 12027435,

        [Annotation(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [6] 12027445")]
        LDNokronSiofraSomberSmithingStone6 = 12027445,

        [Annotation(Name = "[LD - Deeproot Depths] Map: Deeproot Depths 62064")]
        LDDeeprootDepthsMapDeeprootDepths = 62064,

        [Annotation(Name = "[LD - Deeproot Depths] Stonesword Key 12037010")]
        LDDeeprootDepthsStoneswordKey = 12037010,

        [Annotation(Name = "[LD - Deeproot Depths] Formic Rock 12037020")]
        LDDeeprootDepthsFormicRock = 12037020,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [5] 12037030")]
        LDDeeprootDepthsGoldenRune5 = 12037030,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037040")]
        LDDeeprootDepthsGoldenRune8 = 12037040,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Arrow 12037050")]
        LDDeeprootDepthsGoldenArrow = 12037050,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [6] 12037060")]
        LDDeeprootDepthsSmithingStone6 = 12037060,

        [Annotation(Name = "[LD - Deeproot Depths] Holy Grease 12037070")]
        LDDeeprootDepthsHolyGrease = 12037070,

        [Annotation(Name = "[LD - Deeproot Depths] [Incantation] Elden Stars 12037080")]
        LDDeeprootDepthsIncantationEldenStars = 12037080,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [4] 12037090")]
        LDDeeprootDepthsSmithingStone4 = 12037090,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [5] 12037100")]
        LDDeeprootDepthsGoldenRune5_ = 12037100,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [6] 12037110")]
        LDDeeprootDepthsGoldenRune6 = 12037110,

        [Annotation(Name = "[LD - Deeproot Depths] Warming Stone 12037120")]
        LDDeeprootDepthsWarmingStone = 12037120,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [4] 12037130")]
        LDDeeprootDepthsSmithingStone4_ = 12037130,

        [Annotation(Name = "[LD - Deeproot Depths] Ash of War: Vacuum Slice 12037140")]
        LDDeeprootDepthsAshOfWarVacuumSlice = 12037140,

        [Annotation(Name = "[LD - Deeproot Depths] Dragonwound Grease 12037150")]
        LDDeeprootDepthsDragonwoundGrease = 12037150,

        [Annotation(Name = "[LD - Deeproot Depths] Hefty Beast Bone 12037160")]
        LDDeeprootDepthsHeftyBeastBone = 12037160,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037170")]
        LDDeeprootDepthsGoldenRune1 = 12037170,

        [Annotation(Name = "[LD - Deeproot Depths] Prince of Death's Staff 12037180")]
        LDDeeprootDepthsPrinceOfDeathsStaff = 12037180,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [6] 12037190")]
        LDDeeprootDepthsSmithingStone6_ = 12037190,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [5] 12037200")]
        LDDeeprootDepthsGoldenRune5__ = 12037200,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037210")]
        LDDeeprootDepthsGoldenRune8_ = 12037210,

        [Annotation(Name = "[LD - Deeproot Depths] Nascent Butterfly 12037220")]
        LDDeeprootDepthsNascentButterfly = 12037220,

        [Annotation(Name = "[LD - Deeproot Depths] Somber Smithing Stone [7] 12037230")]
        LDDeeprootDepthsSomberSmithingStone7 = 12037230,

        [Annotation(Name = "[LD - Deeproot Depths] Somber Smithing Stone [7] 12037240")]
        LDDeeprootDepthsSomberSmithingStone7_ = 12037240,

        [Annotation(Name = "[LD - Deeproot Depths] Somber Smithing Stone [7] 12037250")]
        LDDeeprootDepthsSomberSmithingStone7__ = 12037250,

        [Annotation(Name = "[LD - Deeproot Depths] Fan Daggers 12037260")]
        LDDeeprootDepthsFanDaggers = 12037260,

        [Annotation(Name = "[LD - Deeproot Depths] Somber Smithing Stone [6] 12037270")]
        LDDeeprootDepthsSomberSmithingStone6 = 12037270,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037280")]
        LDDeeprootDepthsGoldenRune8__ = 12037280,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037290")]
        LDDeeprootDepthsGoldenRune8___ = 12037290,

        [Annotation(Name = "[LD - Deeproot Depths] Crucible Tree Helm 12037300")]
        LDDeeprootDepthsCrucibleTreeHelm = 12037300,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [6] 12037310")]
        LDDeeprootDepthsSmithingStone6__ = 12037310,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037320")]
        LDDeeprootDepthsGoldenRune8____ = 12037320,

        [Annotation(Name = "[LD - Deeproot Depths] Somber Smithing Stone [7] 12037330")]
        LDDeeprootDepthsSomberSmithingStone7___ = 12037330,

        [Annotation(Name = "[LD - Deeproot Depths] Arteria Leaf 12037340")]
        LDDeeprootDepthsArteriaLeaf = 12037340,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [7] 12037350")]
        LDDeeprootDepthsSmithingStone7 = 12037350,

        [Annotation(Name = "[LD - Deeproot Depths] Lightning Greatbolt 12037360")]
        LDDeeprootDepthsLightningGreatbolt = 12037360,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037370")]
        LDDeeprootDepthsGoldenRune8_____ = 12037370,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [6] 12037380")]
        LDDeeprootDepthsSmithingStone6___ = 12037380,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037390")]
        LDDeeprootDepthsGoldenRune8______ = 12037390,

        [Annotation(Name = "[LD - Deeproot Depths] Clarifying Boluses 12037400")]
        LDDeeprootDepthsClarifyingBoluses = 12037400,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [4] 12037410")]
        LDDeeprootDepthsSmithingStone4__ = 12037410,

        [Annotation(Name = "[LD - Deeproot Depths] Human Bone Shard 12037420")]
        LDDeeprootDepthsHumanBoneShard = 12037420,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037430")]
        LDDeeprootDepthsGoldenRune8_______ = 12037430,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [9] 12037440")]
        LDDeeprootDepthsGoldenRune9 = 12037440,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [4] 12037450")]
        LDDeeprootDepthsSmithingStone4___ = 12037450,

        [Annotation(Name = "[LD - Deeproot Depths] Nascent Butterfly 12037460")]
        LDDeeprootDepthsNascentButterfly_ = 12037460,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037470")]
        LDDeeprootDepthsGoldenRune8________ = 12037470,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [5] 12037480")]
        LDDeeprootDepthsSmithingStone5 = 12037480,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [5] 12037490")]
        LDDeeprootDepthsSmithingStone5_ = 12037490,

        [Annotation(Name = "[LD - Deeproot Depths] Smithing Stone [6] 12037500")]
        LDDeeprootDepthsSmithingStone6____ = 12037500,

        [Annotation(Name = "[LD - Deeproot Depths] Rune Arc 12037510")]
        LDDeeprootDepthsRuneArc = 12037510,

        [Annotation(Name = "[LD - Deeproot Depths] Mausoleum Soldier Ashes 12037520")]
        LDDeeprootDepthsMausoleumSoldierAshes = 12037520,

        [Annotation(Name = "[LD - Deeproot Depths] Somber Smithing Stone [7] 12037530")]
        LDDeeprootDepthsSomberSmithingStone7____ = 12037530,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [8] 12037540")]
        LDDeeprootDepthsGoldenRune8_________ = 12037540,

        [Annotation(Name = "[LD - Deeproot Depths] Somber Smithing Stone [6] 12037550")]
        LDDeeprootDepthsSomberSmithingStone6_ = 12037550,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037560")]
        LDDeeprootDepthsGoldenRune1_ = 12037560,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037570")]
        LDDeeprootDepthsGoldenRune1__ = 12037570,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037580")]
        LDDeeprootDepthsGoldenRune1___ = 12037580,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037590")]
        LDDeeprootDepthsGoldenRune1____ = 12037590,

        [Annotation(Name = "[LD - Deeproot Depths] Lightning Bastard Sword 12037900")]
        LDDeeprootDepthsLightningBastardSword = 12037900,

        [Annotation(Name = "[LD - Deeproot Depths] Golden Rune [1] 12037910")]
        LDDeeprootDepthsGoldenRune1_____ = 12037910,

        [Annotation(Name = "[LD - Deeproot Depths] Siluria's Tree 12037950")]
        LDDeeprootDepthsSiluriasTree = 12037950,

        [Annotation(Name = "[LD - Deeproot Depths] Staff of the Avatar 12037960")]
        LDDeeprootDepthsStaffOfTheAvatar = 12037960,

        [Annotation(Name = "[LD - Deeproot Depths] Numen's Rune 12037800")]
        LDDeeprootDepthsNumensRune = 12037800,

        [Annotation(Name = "[LD - Deeproot Depths] Numen's Rune 12037810")]
        LDDeeprootDepthsNumensRune_ = 12037810,

        [Annotation(Name = "[LD - Deeproot Depths] Numen's Rune 12037820")]
        LDDeeprootDepthsNumensRune__ = 12037820,

        [Annotation(Name = "[LD - Deeproot Depths] Numen's Rune 12037830")]
        LDDeeprootDepthsNumensRune___ = 12037830,

        [Annotation(Name = "[LD - Deeproot Depths] Numen's Rune 12037840")]
        LDDeeprootDepthsNumensRune____ = 12037840,

        [Annotation(Name = "[LD - Deeproot Depths] Numen's Rune 12037850")]
        LDDeeprootDepthsNumensRune_____ = 12037850,

        [Annotation(Name = "[LD - Mohgwyn] Map: Mohgwyn Palace 62062")]
        LDMohgwynMapMohgwynPalace = 62062,

        [Annotation(Name = "[LD - Mohgwyn] Golden Seed 12057010")]
        LDMohgwynGoldenSeed = 12057010,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [11] 12057020")]
        LDMohgwynGoldenRune11 = 12057020,

        [Annotation(Name = "[LD - Mohgwyn] Smithing Stone [6] 12057030")]
        LDMohgwynSmithingStone6 = 12057030,

        [Annotation(Name = "[LD - Mohgwyn] Bloodrose 12057040")]
        LDMohgwynBloodrose = 12057040,

        [Annotation(Name = "[LD - Mohgwyn] Nomadic Warrior's Cookbook [24] 67910")]
        LDMohgwynNomadicWarriorsCookbook24 = 67910,

        [Annotation(Name = "[LD - Mohgwyn] Hero's Rune [4] 12057060")]
        LDMohgwynHerosRune4 = 12057060,

        [Annotation(Name = "[LD - Mohgwyn] Smithing Stone [8] 12057070")]
        LDMohgwynSmithingStone8 = 12057070,

        [Annotation(Name = "[LD - Mohgwyn] Hero's Rune [3] 12057080")]
        LDMohgwynHerosRune3 = 12057080,

        [Annotation(Name = "[LD - Mohgwyn] Blood-Tainted Excrement 12057090")]
        LDMohgwynBloodTaintedExcrement = 12057090,

        [Annotation(Name = "[LD - Mohgwyn] Somber Smithing Stone [9] 12057100")]
        LDMohgwynSomberSmithingStone9 = 12057100,

        [Annotation(Name = "[LD - Mohgwyn] [Incantation] Swarm of Flies 12057110")]
        LDMohgwynIncantationSwarmOfFlies = 12057110,

        [Annotation(Name = "[LD - Mohgwyn] Drawstring Blood Grease 12057120")]
        LDMohgwynDrawstringBloodGrease = 12057120,

        [Annotation(Name = "[LD - Mohgwyn] Blood-Tainted Excrement 12057130")]
        LDMohgwynBloodTaintedExcrement_ = 12057130,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [12] 12057140")]
        LDMohgwynGoldenRune12 = 12057140,

        [Annotation(Name = "[LD - Mohgwyn] Smithing Stone [7] 12057150")]
        LDMohgwynSmithingStone7 = 12057150,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [12] 12057160")]
        LDMohgwynGoldenRune12_ = 12057160,

        [Annotation(Name = "[LD - Mohgwyn] Sacramental Bud 12057170")]
        LDMohgwynSacramentalBud = 12057170,

        [Annotation(Name = "[LD - Mohgwyn] Nascent Butterfly 12057180")]
        LDMohgwynNascentButterfly = 12057180,

        [Annotation(Name = "[LD - Mohgwyn] Rune Arc 12057190")]
        LDMohgwynRuneArc = 12057190,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057200")]
        LDMohgwynGoldenRune1 = 12057200,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [13] 12057210")]
        LDMohgwynGoldenRune13 = 12057210,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057220")]
        LDMohgwynGoldenRune1_ = 12057220,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057230")]
        LDMohgwynGoldenRune1__ = 12057230,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057240")]
        LDMohgwynGoldenRune1___ = 12057240,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057250")]
        LDMohgwynGoldenRune1____ = 12057250,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057260")]
        LDMohgwynGoldenRune1_____ = 12057260,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057270")]
        LDMohgwynGoldenRune1______ = 12057270,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057280")]
        LDMohgwynGoldenRune1_______ = 12057280,

        [Annotation(Name = "[LD - Mohgwyn] Bloodrose 12057290")]
        LDMohgwynBloodrose_ = 12057290,

        [Annotation(Name = "[LD - Mohgwyn] Holy Grease 12057300")]
        LDMohgwynHolyGrease = 12057300,

        [Annotation(Name = "[LD - Mohgwyn] Stonesword Key 12057310")]
        LDMohgwynStoneswordKey = 12057310,

        [Annotation(Name = "[LD - Mohgwyn] Smithing Stone [6] 12057320")]
        LDMohgwynSmithingStone6_ = 12057320,

        [Annotation(Name = "[LD - Mohgwyn] Arteria Leaf 12057330")]
        LDMohgwynArteriaLeaf = 12057330,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [13] 12057340")]
        LDMohgwynGoldenRune13_ = 12057340,

        [Annotation(Name = "[LD - Mohgwyn] Clarifying Boluses 12057350")]
        LDMohgwynClarifyingBoluses = 12057350,

        [Annotation(Name = "[LD - Mohgwyn] Rot Grease 12057360")]
        LDMohgwynRotGrease = 12057360,

        [Annotation(Name = "[LD - Mohgwyn] Haligdrake Talisman +2 12057370")]
        LDMohgwynHaligdrakeTalisman2 = 12057370,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057380")]
        LDMohgwynGoldenRune1________ = 12057380,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057390")]
        LDMohgwynGoldenRune1_________ = 12057390,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057400")]
        LDMohgwynGoldenRune1__________ = 12057400,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057410")]
        LDMohgwynGoldenRune1___________ = 12057410,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057420")]
        LDMohgwynGoldenRune1____________ = 12057420,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057430")]
        LDMohgwynGoldenRune1_____________ = 12057430,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057440")]
        LDMohgwynGoldenRune1______________ = 12057440,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057450")]
        LDMohgwynGoldenRune1_______________ = 12057450,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057460")]
        LDMohgwynGoldenRune1________________ = 12057460,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057470")]
        LDMohgwynGoldenRune1_________________ = 12057470,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057480")]
        LDMohgwynGoldenRune1__________________ = 12057480,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057490")]
        LDMohgwynGoldenRune1___________________ = 12057490,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057500")]
        LDMohgwynGoldenRune1____________________ = 12057500,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057510")]
        LDMohgwynGoldenRune1_____________________ = 12057510,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057520")]
        LDMohgwynGoldenRune1______________________ = 12057520,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057530")]
        LDMohgwynGoldenRune1_______________________ = 12057530,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057540")]
        LDMohgwynGoldenRune1________________________ = 12057540,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057550")]
        LDMohgwynGoldenRune1_________________________ = 12057550,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057560")]
        LDMohgwynGoldenRune1__________________________ = 12057560,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057570")]
        LDMohgwynGoldenRune1___________________________ = 12057570,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057580")]
        LDMohgwynGoldenRune1____________________________ = 12057580,

        [Annotation(Name = "[LD - Mohgwyn] Smithing Stone [7] 12057590")]
        LDMohgwynSmithingStone7_ = 12057590,

        [Annotation(Name = "[LD - Mohgwyn] Stanching Boluses 12057600")]
        LDMohgwynStanchingBoluses = 12057600,

        [Annotation(Name = "[LD - Mohgwyn] Stonesword Key 12057610")]
        LDMohgwynStoneswordKey_ = 12057610,

        [Annotation(Name = "[LD - Mohgwyn] Bloodrose 12057620")]
        LDMohgwynBloodrose__ = 12057620,

        [Annotation(Name = "[LD - Mohgwyn] Fire Longsword 12057630")]
        LDMohgwynFireLongsword = 12057630,

        [Annotation(Name = "[LD - Mohgwyn] Smithing Stone [8] 12057640")]
        LDMohgwynSmithingStone8_ = 12057640,

        [Annotation(Name = "[LD - Mohgwyn] Numen's Rune 12057650")]
        LDMohgwynNumensRune = 12057650,

        [Annotation(Name = "[LD - Mohgwyn] 12057660")]
        LDMohgwyn = 12057660,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [13] 12057670")]
        LDMohgwynGoldenRune13__ = 12057670,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [11] 12057680")]
        LDMohgwynGoldenRune11_ = 12057680,

        [Annotation(Name = "[LD - Mohgwyn] Lord's Rune 12057690")]
        LDMohgwynLordsRune = 12057690,

        [Annotation(Name = "[LD - Mohgwyn] Smithing Stone [6] 12057700")]
        LDMohgwynSmithingStone6__ = 12057700,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057710")]
        LDMohgwynGoldenRune1_____________________________ = 12057710,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057720")]
        LDMohgwynGoldenRune1______________________________ = 12057720,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057730")]
        LDMohgwynGoldenRune1_______________________________ = 12057730,

        [Annotation(Name = "[LD - Mohgwyn] Golden Rune [1] 12057740")]
        LDMohgwynGoldenRune1________________________________ = 12057740,

        [Annotation(Name = "[LD - Mohgwyn] Somber Ancient Dragon Smithing Stone 12057900")]
        LDMohgwynSomberAncientDragonSmithingStone = 12057900,

        [Annotation(Name = "[LD - Mohgwyn] White Mask 12057950")]
        LDMohgwynWhiteMask = 12057950,

        [Annotation(Name = "[LD - Nokron / Siofra] Furlcalling Finger Remedy 12077000")]
        LDNokronSiofraFurlcallingFingerRemedy_ = 12077000,

        [Annotation(Name = "[LD - Nokron / Siofra] Silver Firefly 12077010")]
        LDNokronSiofraSilverFirefly = 12077010,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [3] 12077020")]
        LDNokronSiofraGoldenRune3___ = 12077020,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [2] 12077030")]
        LDNokronSiofraGoldenRune2_ = 12077030,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [4] 12077040")]
        LDNokronSiofraSmithingStone4___ = 12077040,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [2] 12077050")]
        LDNokronSiofraSmithingStone2___ = 12077050,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [2] 12077060")]
        LDNokronSiofraGoldenRune2__ = 12077060,

        [Annotation(Name = "[LD - Nokron / Siofra] Immunizing Cured Meat 12077070")]
        LDNokronSiofraImmunizingCuredMeat = 12077070,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [2] 12077080")]
        LDNokronSiofraGoldenRune2___ = 12077080,

        [Annotation(Name = "[LD - Nokron / Siofra] Rainbow Stone 12077090")]
        LDNokronSiofraRainbowStone = 12077090,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12077100")]
        LDNokronSiofraGoldenRune4________ = 12077100,

        [Annotation(Name = "[LD - Nokron / Siofra] Budding Horn 12077110")]
        LDNokronSiofraBuddingHorn = 12077110,

        [Annotation(Name = "[LD - Nokron / Siofra] Throwing Dagger 12077120")]
        LDNokronSiofraThrowingDagger = 12077120,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [3] 12077130")]
        LDNokronSiofraSmithingStone3___ = 12077130,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [4] 12077140")]
        LDNokronSiofraGoldenRune4_________ = 12077140,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [4] 12077150")]
        LDNokronSiofraSmithingStone4____ = 12077150,

        [Annotation(Name = "[LD - Nokron / Siofra] Soap 12077160")]
        LDNokronSiofraSoap = 12077160,

        [Annotation(Name = "[LD - Nokron / Siofra] Preserving Boluses 12077170")]
        LDNokronSiofraPreservingBoluses = 12077170,

        [Annotation(Name = "[LD - Nokron / Siofra] Silver-Pickled Fowl Foot 12077180")]
        LDNokronSiofraSilverPickledFowlFoot = 12077180,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077190")]
        LDNokronSiofraGoldenRune1___ = 12077190,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077200")]
        LDNokronSiofraGoldenRune1____ = 12077200,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077210")]
        LDNokronSiofraGoldenRune1_____ = 12077210,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077220")]
        LDNokronSiofraGoldenRune1______ = 12077220,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077230")]
        LDNokronSiofraGoldenRune1_______ = 12077230,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077240")]
        LDNokronSiofraGoldenRune1________ = 12077240,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077250")]
        LDNokronSiofraGoldenRune1_________ = 12077250,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077260")]
        LDNokronSiofraGoldenRune1__________ = 12077260,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077270")]
        LDNokronSiofraGoldenRune1___________ = 12077270,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077280")]
        LDNokronSiofraGoldenRune1____________ = 12077280,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077290")]
        LDNokronSiofraGoldenRune1_____________ = 12077290,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [5] 12077300")]
        LDNokronSiofraGoldenRune5_ = 12077300,

        [Annotation(Name = "[LD - Nokron / Siofra] Soporific Grease 12077310")]
        LDNokronSiofraSoporificGrease = 12077310,

        [Annotation(Name = "[LD - Nokron / Siofra] Burred Bolt 12077320")]
        LDNokronSiofraBurredBolt = 12077320,

        [Annotation(Name = "[LD - Nokron / Siofra] Nascent Butterfly 12077330")]
        LDNokronSiofraNascentButterfly_ = 12077330,

        [Annotation(Name = "[LD - Nokron / Siofra] Rune Arc 12077340")]
        LDNokronSiofraRuneArc___ = 12077340,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [6] 12077350")]
        LDNokronSiofraGoldenRune6__ = 12077350,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12077360")]
        LDNokronSiofraSmithingStone5____ = 12077360,

        [Annotation(Name = "[LD - Nokron / Siofra] Furlcalling Finger Remedy 12077370")]
        LDNokronSiofraFurlcallingFingerRemedy__ = 12077370,

        [Annotation(Name = "[LD - Nokron / Siofra] Clarifying White Cured Meat 12077380")]
        LDNokronSiofraClarifyingWhiteCuredMeat = 12077380,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [6] 12077390")]
        LDNokronSiofraGoldenRune6___ = 12077390,

        [Annotation(Name = "[LD - Nokron / Siofra] Ghost-Glovewort Picker's Bell Bearing [1] 12077400")]
        LDNokronSiofraGhostGlovewortPickersBellBearing1 = 12077400,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [3] 12077410")]
        LDNokronSiofraSmithingStone3____ = 12077410,

        [Annotation(Name = "[LD - Nokron / Siofra] Somber Smithing Stone [4] 12077420")]
        LDNokronSiofraSomberSmithingStone4 = 12077420,

        [Annotation(Name = "[LD - Nokron / Siofra] Smithing Stone [5] 12077430")]
        LDNokronSiofraSmithingStone5_____ = 12077430,

        [Annotation(Name = "[LD - Nokron / Siofra] Greatshield Soldier Ashes 12077440")]
        LDNokronSiofraGreatshieldSoldierAshes = 12077440,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12077450")]
        LDNokronSiofraGoldenRune7_____ = 12077450,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [7] 12077460")]
        LDNokronSiofraGoldenRune7______ = 12077460,

        [Annotation(Name = "[LD - Nokron / Siofra] Rune Arc 12077470")]
        LDNokronSiofraRuneArc____ = 12077470,

        [Annotation(Name = "[LD - Nokron / Siofra] Larval Tear 12077480")]
        LDNokronSiofraLarvalTear = 12077480,

        [Annotation(Name = "[LD - Nokron / Siofra] Larval Tear 12077490")]
        LDNokronSiofraLarvalTear_ = 12077490,

        [Annotation(Name = "[LD - Nokron / Siofra] Ghostflame Torch 12077500")]
        LDNokronSiofraGhostflameTorch = 12077500,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077510")]
        LDNokronSiofraGoldenRune1______________ = 12077510,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077520")]
        LDNokronSiofraGoldenRune1_______________ = 12077520,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077530")]
        LDNokronSiofraGoldenRune1________________ = 12077530,

        [Annotation(Name = "[LD - Nokron / Siofra] Golden Rune [1] 12077540")]
        LDNokronSiofraGoldenRune1_________________ = 12077540,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007000")]
        LDCrumblingFarumAzulaSmithingStone8 = 13007000,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [9] 13007010")]
        LDCrumblingFarumAzulaGoldenRune9 = 13007010,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Old Fang 13007020")]
        LDCrumblingFarumAzulaOldFang = 13007020,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Lightningproof Dried Liver 13007030")]
        LDCrumblingFarumAzulaLightningproofDriedLiver = 13007030,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [6] 13007040")]
        LDCrumblingFarumAzulaSmithingStone6 = 13007040,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007050")]
        LDCrumblingFarumAzulaSmithingStone8_ = 13007050,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Dragonwound Grease 13007060")]
        LDCrumblingFarumAzulaDragonwoundGrease = 13007060,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007070")]
        LDCrumblingFarumAzulaSmithingStone8__ = 13007070,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007080")]
        LDCrumblingFarumAzulaSmithingStone8___ = 13007080,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Lightning Greatbolt 13007090")]
        LDCrumblingFarumAzulaLightningGreatbolt = 13007090,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007100")]
        LDCrumblingFarumAzula = 13007100,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007110")]
        LDCrumblingFarumAzulaGoldenRune12 = 13007110,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Prayerbook 13007120")]
        LDCrumblingFarumAzulaAncientDragonPrayerbook = 13007120,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Hero's Rune [2] 13007130")]
        LDCrumblingFarumAzulaHerosRune2 = 13007130,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [6] 13007140")]
        LDCrumblingFarumAzulaSmithingStone6_ = 13007140,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somberstone Miner's Bell Bearing [4] 13007150")]
        LDCrumblingFarumAzulaSomberstoneMinersBellBearing4 = 13007150,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007160")]
        LDCrumblingFarumAzula_ = 13007160,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [9] 13007170")]
        LDCrumblingFarumAzulaSomberSmithingStone9 = 13007170,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Fulgurbloom 13007180")]
        LDCrumblingFarumAzulaFulgurbloom = 13007180,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007190")]
        LDCrumblingFarumAzulaSmithingStone8____ = 13007190,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Rejuvenating Boluses 13007200")]
        LDCrumblingFarumAzulaRejuvenatingBoluses = 13007200,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007210")]
        LDCrumblingFarumAzula__ = 13007210,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007220")]
        LDCrumblingFarumAzulaSmithingStone8_____ = 13007220,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007230")]
        LDCrumblingFarumAzula___ = 13007230,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Gravel Stone 13007240")]
        LDCrumblingFarumAzulaGravelStone = 13007240,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [7] 13007250")]
        LDCrumblingFarumAzulaSomberSmithingStone7 = 13007250,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [9] 13007260")]
        LDCrumblingFarumAzulaGoldenRune9_ = 13007260,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Arrow 13007270")]
        LDCrumblingFarumAzulaGoldenArrow = 13007270,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007280")]
        LDCrumblingFarumAzula____ = 13007280,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Gravel Stone 13007290")]
        LDCrumblingFarumAzulaGravelStone_ = 13007290,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [10] 13007300")]
        LDCrumblingFarumAzulaGoldenRune10 = 13007300,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007310")]
        LDCrumblingFarumAzulaGoldenRune12_ = 13007310,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [6] 13007320")]
        LDCrumblingFarumAzulaSmithingStone6__ = 13007320,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [11] 13007330")]
        LDCrumblingFarumAzulaGoldenRune11 = 13007330,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007340")]
        LDCrumblingFarumAzula_____ = 13007340,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Stonesword Key 13007350")]
        LDCrumblingFarumAzulaStoneswordKey = 13007350,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007360")]
        LDCrumblingFarumAzulaGoldenRune12__ = 13007360,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007370")]
        LDCrumblingFarumAzula______ = 13007370,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Rune Arc 13007380")]
        LDCrumblingFarumAzulaRuneArc = 13007380,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [9] 13007390")]
        LDCrumblingFarumAzulaSomberSmithingStone9_ = 13007390,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007400")]
        LDCrumblingFarumAzula_______ = 13007400,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007410")]
        LDCrumblingFarumAzula________ = 13007410,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [11] 13007420")]
        LDCrumblingFarumAzulaGoldenRune11_ = 13007420,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Godskin Ward 13007430")]
        LDCrumblingFarumAzulaGodskinWard = 13007430,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Hero's Rune [5] 13007440")]
        LDCrumblingFarumAzulaHerosRune5 = 13007440,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [7] 13007450")]
        LDCrumblingFarumAzulaSmithingStone7 = 13007450,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Lightning Grease 13007460")]
        LDCrumblingFarumAzulaLightningGrease = 13007460,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [9] 13007470")]
        LDCrumblingFarumAzulaSomberSmithingStone9__ = 13007470,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Smithing Stone 13007480")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone = 13007480,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007490")]
        LDCrumblingFarumAzulaGoldenRune12___ = 13007490,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Dragoncrest Shield Talisman +2 13007500")]
        LDCrumblingFarumAzulaDragoncrestShieldTalisman2 = 13007500,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Dappled Cured Meat 13007510")]
        LDCrumblingFarumAzulaDappledCuredMeat = 13007510,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007520")]
        LDCrumblingFarumAzulaSmithingStone8______ = 13007520,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Lord's Rune 13007530")]
        LDCrumblingFarumAzulaLordsRune = 13007530,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Nascent Butterfly 13007540")]
        LDCrumblingFarumAzulaNascentButterfly = 13007540,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007550")]
        LDCrumblingFarumAzulaGoldenRune12____ = 13007550,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007560")]
        LDCrumblingFarumAzulaSmithingStone8_______ = 13007560,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Rune Arc 13007570")]
        LDCrumblingFarumAzulaRuneArc_ = 13007570,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [7] 13007580")]
        LDCrumblingFarumAzulaSmithingStone7_ = 13007580,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Dragonwound Grease 13007590")]
        LDCrumblingFarumAzulaDragonwoundGrease_ = 13007590,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007600")]
        LDCrumblingFarumAzulaSmithingStone8________ = 13007600,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007610")]
        LDCrumblingFarumAzula_________ = 13007610,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007620")]
        LDCrumblingFarumAzulaGoldenRune12_____ = 13007620,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007630")]
        LDCrumblingFarumAzula__________ = 13007630,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [7] 13007640")]
        LDCrumblingFarumAzulaSmithingStone7__ = 13007640,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Apostle's Cookbook [4] 68020")]
        LDCrumblingFarumAzulaAncientDragonApostlesCookbook4 = 68020,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [8] 13007660")]
        LDCrumblingFarumAzulaSomberSmithingStone8 = 13007660,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [6] 13007670")]
        LDCrumblingFarumAzulaSmithingStone6___ = 13007670,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Arteria Leaf 13007680")]
        LDCrumblingFarumAzulaArteriaLeaf = 13007680,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007690")]
        LDCrumblingFarumAzula___________ = 13007690,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Lightning Greatbolt 13007700")]
        LDCrumblingFarumAzulaLightningGreatbolt_ = 13007700,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Fulgurbloom 13007710")]
        LDCrumblingFarumAzulaFulgurbloom_ = 13007710,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007720")]
        LDCrumblingFarumAzulaGoldenRune12______ = 13007720,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [7] 13007730")]
        LDCrumblingFarumAzulaSmithingStone7___ = 13007730,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007740")]
        LDCrumblingFarumAzulaGoldenRune12_______ = 13007740,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007750")]
        LDCrumblingFarumAzula____________ = 13007750,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Boltdrake Talisman +2 13007760")]
        LDCrumblingFarumAzulaBoltdrakeTalisman2 = 13007760,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [7] 13007770")]
        LDCrumblingFarumAzulaSomberSmithingStone7_ = 13007770,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007780")]
        LDCrumblingFarumAzula_____________ = 13007780,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somberstone Miner's Bell Bearing [5] 13007790")]
        LDCrumblingFarumAzulaSomberstoneMinersBellBearing5 = 13007790,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Rune [12] 13007800")]
        LDCrumblingFarumAzulaGoldenRune12________ = 13007800,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [7] 13007810")]
        LDCrumblingFarumAzulaSomberSmithingStone7__ = 13007810,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [8] 13007820")]
        LDCrumblingFarumAzulaSomberSmithingStone8_ = 13007820,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Pearldrake Talisman 13007830")]
        LDCrumblingFarumAzulaPearldrakeTalisman = 13007830,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007840")]
        LDCrumblingFarumAzula______________ = 13007840,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [7] 13007850")]
        LDCrumblingFarumAzulaSmithingStone7____ = 13007850,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Gravel Stone 13007860")]
        LDCrumblingFarumAzulaGravelStone__ = 13007860,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somber Smithing Stone [9] 13007870")]
        LDCrumblingFarumAzulaSomberSmithingStone9___ = 13007870,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Smithing Stone [8] 13007880")]
        LDCrumblingFarumAzulaSmithingStone8_________ = 13007880,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Azula Beastman Ashes 13007890")]
        LDCrumblingFarumAzulaAzulaBeastmanAshes = 13007890,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Smithing Stone 13007900")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone_ = 13007900,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Glovewort Picker's Bell Bearing [3] 13007910")]
        LDCrumblingFarumAzulaGlovewortPickersBellBearing3 = 13007910,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Drake Knight Helm 13007920")]
        LDCrumblingFarumAzulaDrakeKnightHelm = 13007920,

        [Annotation(Name = "[LD - Crumbling Farum Azula] 13007930")]
        LDCrumblingFarumAzula_______________ = 13007930,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Dragon Towershield 13007940")]
        LDCrumblingFarumAzulaDragonTowershield = 13007940,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Old Lord's Talisman 13007950")]
        LDCrumblingFarumAzulaOldLordsTalisman = 13007950,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Seed 13007980")]
        LDCrumblingFarumAzulaGoldenSeed = 13007980,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Golden Seed 13007990")]
        LDCrumblingFarumAzulaGoldenSeed_ = 13007990,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Smithing Stone 13007991")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone__ = 13007991,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Ancient Dragon Smithing Stone 13007993")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone___ = 13007993,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Malformed Dragon Helm 13007995")]
        LDCrumblingFarumAzulaMalformedDragonHelm = 13007995,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Somber Ancient Dragon Smithing Stone 13007005")]
        LDCrumblingFarumAzulaSomberAncientDragonSmithingStone = 13007005,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Dragonwound Grease 13007015")]
        LDCrumblingFarumAzulaDragonwoundGrease__ = 13007015,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Great Grave Glovewort 13007025")]
        LDCrumblingFarumAzulaGreatGraveGlovewort = 13007025,

        [Annotation(Name = "[LD - Crumbling Farum Azula] Great Grave Glovewort 13007035")]
        LDCrumblingFarumAzulaGreatGraveGlovewort_ = 13007035,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Magic Grease 14007000")]
        LDAcademyOfRayaLucariaMagicGrease = 14007000,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Rune Arc 14007020")]
        LDAcademyOfRayaLucariaRuneArc = 14007020,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [2] 14007030")]
        LDAcademyOfRayaLucariaGoldenRune2 = 14007030,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Somber Smithing Stone [3] 14007040")]
        LDAcademyOfRayaLucariaSomberSmithingStone3 = 14007040,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Grace Mimic 14007070")]
        LDAcademyOfRayaLucariaGraceMimic = 14007070,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [4] 14007090")]
        LDAcademyOfRayaLucariaSmithingStone4 = 14007090,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Spellproof Dried Liver 14007120")]
        LDAcademyOfRayaLucariaSpellproofDriedLiver = 14007120,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Marionette Soldier Ashes 14007150")]
        LDAcademyOfRayaLucariaMarionetteSoldierAshes = 14007150,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Silver-Pickled Fowl Foot 14007160")]
        LDAcademyOfRayaLucariaSilverPickledFowlFoot = 14007160,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Magic Grease 14007190")]
        LDAcademyOfRayaLucariaMagicGrease_ = 14007190,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007200")]
        LDAcademyOfRayaLucariaGoldenRune4 = 14007200,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Mushroom 14007220")]
        LDAcademyOfRayaLucariaMushroom = 14007220,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007250")]
        LDAcademyOfRayaLucariaGoldenRune4_ = 14007250,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [3] 14007280")]
        LDAcademyOfRayaLucariaGoldenRune3 = 14007280,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Avionette Soldier Ashes 14007290")]
        LDAcademyOfRayaLucariaAvionetteSoldierAshes = 14007290,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [5] 14007300")]
        LDAcademyOfRayaLucariaSmithingStone5 = 14007300,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Longtail Cat Talisman 14007320")]
        LDAcademyOfRayaLucariaLongtailCatTalisman = 14007320,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Crystal Dart 14007330")]
        LDAcademyOfRayaLucariaCrystalDart = 14007330,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007350")]
        LDAcademyOfRayaLucariaGoldenRune4__ = 14007350,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Conspectus Scroll 14007360")]
        LDAcademyOfRayaLucariaConspectusScroll = 14007360,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [4] 14007370")]
        LDAcademyOfRayaLucariaSmithingStone4_ = 14007370,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Stonesword Key 14007380")]
        LDAcademyOfRayaLucariaStoneswordKey = 14007380,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Furlcalling Finger Remedy 14007390")]
        LDAcademyOfRayaLucariaFurlcallingFingerRemedy = 14007390,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Living Jar Shard 14007410")]
        LDAcademyOfRayaLucariaLivingJarShard = 14007410,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Stonesword Key 14007420")]
        LDAcademyOfRayaLucariaStoneswordKey_ = 14007420,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Glintstone Firefly 14007430")]
        LDAcademyOfRayaLucariaGlintstoneFirefly = 14007430,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [2] 14007440")]
        LDAcademyOfRayaLucariaGoldenRune2_ = 14007440,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007450")]
        LDAcademyOfRayaLucariaGoldenRune4___ = 14007450,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Crystal Bud 14007460")]
        LDAcademyOfRayaLucariaCrystalBud = 14007460,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007470")]
        LDAcademyOfRayaLucariaGoldenRune4____ = 14007470,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [5] 14007480")]
        LDAcademyOfRayaLucariaSmithingStone5_ = 14007480,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [2] 14007490")]
        LDAcademyOfRayaLucariaGoldenRune2__ = 14007490,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Glintstone Whetblade 65680")]
        LDAcademyOfRayaLucariaGlintstoneWhetblade = 65680,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [3] 14007510")]
        LDAcademyOfRayaLucariaGoldenRune3_ = 14007510,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Crystal Dart 14007520")]
        LDAcademyOfRayaLucariaCrystalDart_ = 14007520,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007530")]
        LDAcademyOfRayaLucariaGoldenRune4_____ = 14007530,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Furlcalling Finger Remedy 14007540")]
        LDAcademyOfRayaLucariaFurlcallingFingerRemedy_ = 14007540,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [7] 14007560")]
        LDAcademyOfRayaLucariaGoldenRune7 = 14007560,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007600")]
        LDAcademyOfRayaLucariaGoldenRune4______ = 14007600,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Crystal Dart 14007620")]
        LDAcademyOfRayaLucariaCrystalDart__ = 14007620,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Imbued Sword Key 14007630")]
        LDAcademyOfRayaLucariaImbuedSwordKey = 14007630,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Meteor Bolt 14007660")]
        LDAcademyOfRayaLucariaMeteorBolt = 14007660,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [4] 14007670")]
        LDAcademyOfRayaLucariaSmithingStone4__ = 14007670,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [4] 14007710")]
        LDAcademyOfRayaLucariaGoldenRune4_______ = 14007710,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Smithing Stone [3] 14007720")]
        LDAcademyOfRayaLucariaSmithingStone3 = 14007720,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Magic Grease 14007740")]
        LDAcademyOfRayaLucariaMagicGrease__ = 14007740,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Rune [3] 14007750")]
        LDAcademyOfRayaLucariaGoldenRune3__ = 14007750,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Somber Smithing Stone [4] 14007760")]
        LDAcademyOfRayaLucariaSomberSmithingStone4 = 14007760,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] [Sorcery] Shattering Crystal 14007770")]
        LDAcademyOfRayaLucariaSorceryShatteringCrystal = 14007770,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Cracked Pot 66120")]
        LDAcademyOfRayaLucariaCrackedPot = 66120,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Azur's Glintstone Staff 14007840")]
        LDAcademyOfRayaLucariaAzursGlintstoneStaff = 14007840,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Carian Knight Helm 14007850")]
        LDAcademyOfRayaLucariaCarianKnightHelm = 14007850,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Somber Smithing Stone [3] 14007860")]
        LDAcademyOfRayaLucariaSomberSmithingStone3_ = 14007860,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Lost Ashes of War 14007870")]
        LDAcademyOfRayaLucariaLostAshesOfWar = 14007870,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] [Sorcery] Comet 14007880")]
        LDAcademyOfRayaLucariaSorceryComet = 14007880,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Graven-School Talisman 14007890")]
        LDAcademyOfRayaLucariaGravenSchoolTalisman = 14007890,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Ritual Pot 66410")]
        LDAcademyOfRayaLucariaRitualPot = 66410,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Glintstone Scarab 14007910")]
        LDAcademyOfRayaLucariaGlintstoneScarab = 14007910,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Terra Magicus 14007920")]
        LDAcademyOfRayaLucariaTerraMagicus = 14007920,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Radagon Icon 14007940")]
        LDAcademyOfRayaLucariaRadagonIcon = 14007940,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Glintstone Craftsman's Cookbook [5] 67420")]
        LDAcademyOfRayaLucariaGlintstoneCraftsmansCookbook5 = 67420,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Dark Moon Ring 114")]
        LDAcademyOfRayaLucariaDarkMoonRing = 114,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Full Moon Crossbow 14007970")]
        LDAcademyOfRayaLucariaFullMoonCrossbow = 14007970,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Carian Knight's Shield 14007980")]
        LDAcademyOfRayaLucariaCarianKnightsShield = 14007980,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Golden Seed 14007990")]
        LDAcademyOfRayaLucariaGoldenSeed = 14007990,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Twinsage Glintstone Crown 14007005")]
        LDAcademyOfRayaLucariaTwinsageGlintstoneCrown = 14007005,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Olivinus Glintstone Crown 14007015")]
        LDAcademyOfRayaLucariaOlivinusGlintstoneCrown = 14007015,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Lazuli Glintstone Crown 14007025")]
        LDAcademyOfRayaLucariaLazuliGlintstoneCrown = 14007025,

        [Annotation(Name = "[LD - Academy of Raya Lucaria] Karolos Glintstone Crown 14007035")]
        LDAcademyOfRayaLucariaKarolosGlintstoneCrown = 14007035,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Stonesword Key 15007000")]
        LDElphaelMiquellasHaligtreeStoneswordKey = 15007000,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Sacramental Bud 15007010")]
        LDElphaelMiquellasHaligtreeSacramentalBud = 15007010,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007020")]
        LDElphaelMiquellasHaligtreeGoldenRune10 = 15007020,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Stonesword Key 15007030")]
        LDElphaelMiquellasHaligtreeStoneswordKey_ = 15007030,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Fire Grease 15007040")]
        LDElphaelMiquellasHaligtreeFireGrease = 15007040,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Aeonian Butterfly 15007050")]
        LDElphaelMiquellasHaligtreeAeonianButterfly = 15007050,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Preserving Boluses 15007060")]
        LDElphaelMiquellasHaligtreePreservingBoluses = 15007060,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007070")]
        LDElphaelMiquellasHaligtreeGoldenRune10_ = 15007070,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Envoy Crown 15007080")]
        LDElphaelMiquellasHaligtreeEnvoyCrown = 15007080,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Dappled Cured Meat 15007090")]
        LDElphaelMiquellasHaligtreeDappledCuredMeat = 15007090,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007100")]
        LDElphaelMiquellasHaligtreeSmithingStone8 = 15007100,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Prattling Pate \"My beloved\" 15007110")]
        LDElphaelMiquellasHaligtreePrattlingPateMybeloved = 15007110,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Warming Stone 15007120")]
        LDElphaelMiquellasHaligtreeWarmingStone = 15007120,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Flaming Bolt 15007130")]
        LDElphaelMiquellasHaligtreeFlamingBolt = 15007130,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Numen's Rune 15007140")]
        LDElphaelMiquellasHaligtreeNumensRune = 15007140,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [13] 15007150")]
        LDElphaelMiquellasHaligtreeGoldenRune13 = 15007150,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Lost Ashes of War 15007160")]
        LDElphaelMiquellasHaligtreeLostAshesOfWar = 15007160,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Oracle Envoy Ashes 15007170")]
        LDElphaelMiquellasHaligtreeOracleEnvoyAshes = 15007170,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007180")]
        LDElphaelMiquellasHaligtreeGoldenRune1 = 15007180,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007190")]
        LDElphaelMiquellasHaligtreeGoldenRune1_ = 15007190,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007200")]
        LDElphaelMiquellasHaligtreeGoldenRune10__ = 15007200,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Rot Grease 15007210")]
        LDElphaelMiquellasHaligtreeRotGrease = 15007210,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Pearldrake Talisman +2 15007220")]
        LDElphaelMiquellasHaligtreePearldrakeTalisman2 = 15007220,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007230")]
        LDElphaelMiquellasHaligtreeSmithingStone8_ = 15007230,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [13] 15007240")]
        LDElphaelMiquellasHaligtreeGoldenRune13_ = 15007240,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Hefty Beast Bone 15007250")]
        LDElphaelMiquellasHaligtreeHeftyBeastBone = 15007250,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Fire Grease 15007260")]
        LDElphaelMiquellasHaligtreeFireGrease_ = 15007260,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Ancient Dragon Smithing Stone 15007270")]
        LDElphaelMiquellasHaligtreeAncientDragonSmithingStone = 15007270,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Somber Smithing Stone [8] 15007280")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone8 = 15007280,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [12] 15007290")]
        LDElphaelMiquellasHaligtreeGoldenRune12 = 15007290,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Aeonian Butterfly 15007300")]
        LDElphaelMiquellasHaligtreeAeonianButterfly_ = 15007300,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [6] 15007310")]
        LDElphaelMiquellasHaligtreeSmithingStone6 = 15007310,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Somber Smithing Stone [9] 15007320")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9 = 15007320,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007330")]
        LDElphaelMiquellasHaligtreeGoldenRune10___ = 15007330,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [12] 15007340")]
        LDElphaelMiquellasHaligtreeGoldenRune12_ = 15007340,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Viridian Amber Medallion +2 15007350")]
        LDElphaelMiquellasHaligtreeViridianAmberMedallion2 = 15007350,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [6] 15007360")]
        LDElphaelMiquellasHaligtreeSmithingStone6_ = 15007360,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Sacramental Bud 15007370")]
        LDElphaelMiquellasHaligtreeSacramentalBud_ = 15007370,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [7] 15007380")]
        LDElphaelMiquellasHaligtreeSmithingStone7 = 15007380,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Hero's Rune [4] 15007390")]
        LDElphaelMiquellasHaligtreeHerosRune4 = 15007390,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007400")]
        LDElphaelMiquellasHaligtreeSmithingStone8__ = 15007400,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007410")]
        LDElphaelMiquellasHaligtreeGoldenRune1__ = 15007410,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007420")]
        LDElphaelMiquellasHaligtreeGoldenRune1___ = 15007420,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007430")]
        LDElphaelMiquellasHaligtreeGoldenRune1____ = 15007430,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007440")]
        LDElphaelMiquellasHaligtreeGoldenRune1_____ = 15007440,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Somber Smithing Stone [9] 15007450")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9_ = 15007450,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Ancient Dragon Smithing Stone 15007460")]
        LDElphaelMiquellasHaligtreeAncientDragonSmithingStone_ = 15007460,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007470")]
        LDElphaelMiquellasHaligtreeGoldenRune1______ = 15007470,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007480")]
        LDElphaelMiquellasHaligtreeGoldenRune1_______ = 15007480,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007490")]
        LDElphaelMiquellasHaligtreeGoldenRune1________ = 15007490,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Holy Grease 15007500")]
        LDElphaelMiquellasHaligtreeHolyGrease = 15007500,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [12] 15007510")]
        LDElphaelMiquellasHaligtreeGoldenRune12__ = 15007510,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007520")]
        LDElphaelMiquellasHaligtreeSmithingStone8___ = 15007520,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Miquellan Knight's Sword 15007530")]
        LDElphaelMiquellasHaligtreeMiquellanKnightsSword = 15007530,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Lightning Greatbolt 15007540")]
        LDElphaelMiquellasHaligtreeLightningGreatbolt = 15007540,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [7] 15007550")]
        LDElphaelMiquellasHaligtreeSmithingStone7_ = 15007550,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] [Incantation] Triple Rings of Light 15007560")]
        LDElphaelMiquellasHaligtreeIncantationTripleRingsOfLight = 15007560,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Immunizing White Cured Meat 15007570")]
        LDElphaelMiquellasHaligtreeImmunizingWhiteCuredMeat = 15007570,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Cleanrot Knight Finlay 15007580")]
        LDElphaelMiquellasHaligtreeCleanrotKnightFinlay = 15007580,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Somber Ancient Dragon Smithing Stone 15007590")]
        LDElphaelMiquellasHaligtreeSomberAncientDragonSmithingStone = 15007590,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Numen's Rune 15007600")]
        LDElphaelMiquellasHaligtreeNumensRune_ = 15007600,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Somber Ancient Dragon Smithing Stone 15007610")]
        LDElphaelMiquellasHaligtreeSomberAncientDragonSmithingStone_ = 15007610,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Somber Smithing Stone [9] 15007620")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9__ = 15007620,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007630")]
        LDElphaelMiquellasHaligtreeGoldenRune10____ = 15007630,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [7] 15007640")]
        LDElphaelMiquellasHaligtreeSmithingStone7__ = 15007640,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Old Fang 15007650")]
        LDElphaelMiquellasHaligtreeOldFang = 15007650,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Warming Stone 15007660")]
        LDElphaelMiquellasHaligtreeWarmingStone_ = 15007660,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Spiritflame Arrow 15007670")]
        LDElphaelMiquellasHaligtreeSpiritflameArrow = 15007670,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007680")]
        LDElphaelMiquellasHaligtreeSmithingStone8____ = 15007680,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Haligtree Soldier Ashes 15007690")]
        LDElphaelMiquellasHaligtreeHaligtreeSoldierAshes = 15007690,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [11] 15007700")]
        LDElphaelMiquellasHaligtreeGoldenRune11 = 15007700,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Arteria Leaf 15007710")]
        LDElphaelMiquellasHaligtreeArteriaLeaf = 15007710,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Sacramental Bud 15007720")]
        LDElphaelMiquellasHaligtreeSacramentalBud__ = 15007720,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [8] 15007730")]
        LDElphaelMiquellasHaligtreeSmithingStone8_____ = 15007730,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Lord's Rune 15007740")]
        LDElphaelMiquellasHaligtreeLordsRune = 15007740,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Seedbed Curse 15007750")]
        LDElphaelMiquellasHaligtreeSeedbedCurse = 15007750,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Somber Smithing Stone [9] 15007760")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9___ = 15007760,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Pickled Turtle Neck 15007770")]
        LDElphaelMiquellasHaligtreePickledTurtleNeck = 15007770,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Beast Blood 15007780")]
        LDElphaelMiquellasHaligtreeBeastBlood = 15007780,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Aeonian Butterfly 15007790")]
        LDElphaelMiquellasHaligtreeAeonianButterfly__ = 15007790,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Marika's Soreseal 15007800")]
        LDElphaelMiquellasHaligtreeMarikasSoreseal = 15007800,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [12] 15007810")]
        LDElphaelMiquellasHaligtreeGoldenRune12___ = 15007810,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Haligtree Knight Helm 15007820")]
        LDElphaelMiquellasHaligtreeHaligtreeKnightHelm = 15007820,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Smithing Stone [6] 15007830")]
        LDElphaelMiquellasHaligtreeSmithingStone6__ = 15007830,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Seedbed Curse 15007840")]
        LDElphaelMiquellasHaligtreeSeedbedCurse_ = 15007840,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [1] 15007850")]
        LDElphaelMiquellasHaligtreeGoldenRune1_________ = 15007850,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Rotten Crystal Sword 15007860")]
        LDElphaelMiquellasHaligtreeRottenCrystalSword = 15007860,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Hero's Rune [5] 15007870")]
        LDElphaelMiquellasHaligtreeHerosRune5 = 15007870,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Rot Grease 15007880")]
        LDElphaelMiquellasHaligtreeRotGrease_ = 15007880,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Great Grave Glovewort 15007890")]
        LDElphaelMiquellasHaligtreeGreatGraveGlovewort = 15007890,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Rune [10] 15007900")]
        LDElphaelMiquellasHaligtreeGoldenRune10_____ = 15007900,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Ghost-Glovewort Picker's Bell Bearing [3] 15007910")]
        LDElphaelMiquellasHaligtreeGhostGlovewortPickersBellBearing3 = 15007910,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Nascent Butterfly 15007920")]
        LDElphaelMiquellasHaligtreeNascentButterfly = 15007920,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Dragoncrest Greatshield Talisman 15007930")]
        LDElphaelMiquellasHaligtreeDragoncrestGreatshieldTalisman = 15007930,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Aeonian Butterfly 15007940")]
        LDElphaelMiquellasHaligtreeAeonianButterfly___ = 15007940,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Arteria Leaf 15007950")]
        LDElphaelMiquellasHaligtreeArteriaLeaf_ = 15007950,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Hero's Rune [5] 15007960")]
        LDElphaelMiquellasHaligtreeHerosRune5_ = 15007960,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Numen's Rune 15007970")]
        LDElphaelMiquellasHaligtreeNumensRune__ = 15007970,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Traveler's Clothes 15007980")]
        LDElphaelMiquellasHaligtreeTravelersClothes = 15007980,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Miquella's Needle 15007990")]
        LDElphaelMiquellasHaligtreeMiquellasNeedle = 15007990,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Golden Seed 15001200")]
        LDElphaelMiquellasHaligtreeGoldenSeed = 15001200,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] 15001210")]
        LDElphaelMiquellasHaligtree = 15001210,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] 15001250")]
        LDElphaelMiquellasHaligtree_ = 15001250,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] 15001260")]
        LDElphaelMiquellasHaligtree__ = 15001260,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Lord's Rune 15001270")]
        LDElphaelMiquellasHaligtreeLordsRune_ = 15001270,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] Rotten Staff 15001280")]
        LDElphaelMiquellasHaligtreeRottenStaff = 15001280,

        [Annotation(Name = "[LD - Elphael / Miquella's Haligtree] 15001290")]
        LDElphaelMiquellasHaligtree___ = 15001290,

        [Annotation(Name = "[LD - Volcano Manor] Smithing Stone [6] 16007000")]
        LDVolcanoManorSmithingStone6 = 16007000,

        [Annotation(Name = "[LD - Volcano Manor] Depraved Perfumer Carmaan 16007010")]
        LDVolcanoManorDepravedPerfumerCarmaan = 16007010,

        [Annotation(Name = "[LD - Volcano Manor] Ash of War: Royal Knight's Resolve 16007020")]
        LDVolcanoManorAshOfWarRoyalKnightsResolve = 16007020,

        [Annotation(Name = "[LD - Volcano Manor] Budding Horn 16007030")]
        LDVolcanoManorBuddingHorn = 16007030,

        [Annotation(Name = "[LD - Volcano Manor] Fireproof Dried Liver 16007040")]
        LDVolcanoManorFireproofDriedLiver = 16007040,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [9] 16007050")]
        LDVolcanoManorGoldenRune9 = 16007050,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [5] 16007060")]
        LDVolcanoManorGoldenRune5 = 16007060,

        [Annotation(Name = "[LD - Volcano Manor] Stonesword Key 16007070")]
        LDVolcanoManorStoneswordKey = 16007070,

        [Annotation(Name = "[LD - Volcano Manor] Furlcalling Finger Remedy 16007080")]
        LDVolcanoManorFurlcallingFingerRemedy = 16007080,

        [Annotation(Name = "[LD - Volcano Manor] Nomadic Warrior's Cookbook [21] 67120")]
        LDVolcanoManorNomadicWarriorsCookbook21 = 67120,

        [Annotation(Name = "[LD - Volcano Manor] Somber Smithing Stone [7] 16007100")]
        LDVolcanoManorSomberSmithingStone7 = 16007100,

        [Annotation(Name = "[LD - Volcano Manor] Perfume Bottle 66700")]
        LDVolcanoManorPerfumeBottle = 66700,

        [Annotation(Name = "[LD - Volcano Manor] Smithing Stone [6] 16007120")]
        LDVolcanoManorSmithingStone6_ = 16007120,

        [Annotation(Name = "[LD - Volcano Manor] Erdtree Seal 16007130")]
        LDVolcanoManorErdtreeSeal = 16007130,

        [Annotation(Name = "[LD - Volcano Manor] Drawstring Fire Grease 16007140")]
        LDVolcanoManorDrawstringFireGrease = 16007140,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [6] 16007150")]
        LDVolcanoManorGoldenRune6 = 16007150,

        [Annotation(Name = "[LD - Volcano Manor] Fire Arrow 16007160")]
        LDVolcanoManorFireArrow = 16007160,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [9] 16007170")]
        LDVolcanoManorGoldenRune9_ = 16007170,

        [Annotation(Name = "[LD - Volcano Manor] Explosive Greatbolt 16007190")]
        LDVolcanoManorExplosiveGreatbolt = 16007190,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [9] 16007200")]
        LDVolcanoManorGoldenRune9__ = 16007200,

        [Annotation(Name = "[LD - Volcano Manor] Somber Smithing Stone [6] 16007210")]
        LDVolcanoManorSomberSmithingStone6 = 16007210,

        [Annotation(Name = "[LD - Volcano Manor] Fireproof Dried Liver 16007220")]
        LDVolcanoManorFireproofDriedLiver_ = 16007220,

        [Annotation(Name = "[LD - Volcano Manor] Albinauric Bloodclot 16007230")]
        LDVolcanoManorAlbinauricBloodclot = 16007230,

        [Annotation(Name = "[LD - Volcano Manor] Smithing Stone [4] 16007240")]
        LDVolcanoManorSmithingStone4 = 16007240,

        [Annotation(Name = "[LD - Volcano Manor] Smithing Stone [6] 16007250")]
        LDVolcanoManorSmithingStone6__ = 16007250,

        [Annotation(Name = "[LD - Volcano Manor] Smoldering Butterfly 16007270")]
        LDVolcanoManorSmolderingButterfly = 16007270,

        [Annotation(Name = "[LD - Volcano Manor] Smithing Stone [7] 16007280")]
        LDVolcanoManorSmithingStone7 = 16007280,

        [Annotation(Name = "[LD - Volcano Manor] Somber Smithing Stone [5] 16007290")]
        LDVolcanoManorSomberSmithingStone5 = 16007290,

        [Annotation(Name = "[LD - Volcano Manor] Smoldering Butterfly 16007310")]
        LDVolcanoManorSmolderingButterfly_ = 16007310,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [9] 16007320")]
        LDVolcanoManorGoldenRune9___ = 16007320,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [10] 16007330")]
        LDVolcanoManorGoldenRune10 = 16007330,

        [Annotation(Name = "[LD - Volcano Manor] Smithing Stone [6] 16007350")]
        LDVolcanoManorSmithingStone6___ = 16007350,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [9] 16007360")]
        LDVolcanoManorGoldenRune9____ = 16007360,

        [Annotation(Name = "[LD - Volcano Manor] Smithing Stone [5] 16007380")]
        LDVolcanoManorSmithingStone5 = 16007380,

        [Annotation(Name = "[LD - Volcano Manor] Smoldering Butterfly 16007390")]
        LDVolcanoManorSmolderingButterfly__ = 16007390,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [12] 16007400")]
        LDVolcanoManorGoldenRune12 = 16007400,

        [Annotation(Name = "[LD - Volcano Manor] Furlcalling Finger Remedy 16007410")]
        LDVolcanoManorFurlcallingFingerRemedy_ = 16007410,

        [Annotation(Name = "[LD - Volcano Manor] Beast Blood 16007420")]
        LDVolcanoManorBeastBlood = 16007420,

        [Annotation(Name = "[LD - Volcano Manor] Albinauric Staff 16007430")]
        LDVolcanoManorAlbinauricStaff = 16007430,

        [Annotation(Name = "[LD - Volcano Manor] Drawstring Fire Grease 16007440")]
        LDVolcanoManorDrawstringFireGrease_ = 16007440,

        [Annotation(Name = "[LD - Volcano Manor] Missionary's Cookbook [6] 67130")]
        LDVolcanoManorMissionarysCookbook6 = 67130,

        [Annotation(Name = "[LD - Volcano Manor] Crimson Tear Scarab 16007480")]
        LDVolcanoManorCrimsonTearScarab = 16007480,

        [Annotation(Name = "[LD - Volcano Manor] Stonesword Key 16007490")]
        LDVolcanoManorStoneswordKey_ = 16007490,

        [Annotation(Name = "[LD - Volcano Manor] Rune Arc 16007500")]
        LDVolcanoManorRuneArc = 16007500,

        [Annotation(Name = "[LD - Volcano Manor] Commoner's Headband 16007510")]
        LDVolcanoManorCommonersHeadband = 16007510,

        [Annotation(Name = "[LD - Volcano Manor] Man-Serpent Ashes 16007520")]
        LDVolcanoManorManSerpentAshes = 16007520,

        [Annotation(Name = "[LD - Volcano Manor] Somber Smithing Stone [6] 16007530")]
        LDVolcanoManorSomberSmithingStone6_ = 16007530,

        [Annotation(Name = "[LD - Volcano Manor] Crimson Amber Medallion +1 16007540")]
        LDVolcanoManorCrimsonAmberMedallion1 = 16007540,

        [Annotation(Name = "[LD - Volcano Manor] Smithing Stone [6] 16007550")]
        LDVolcanoManorSmithingStone6____ = 16007550,

        [Annotation(Name = "[LD - Volcano Manor] Smithing Stone [4] 16007560")]
        LDVolcanoManorSmithingStone4_ = 16007560,

        [Annotation(Name = "[LD - Volcano Manor] Smoldering Shield 16007610")]
        LDVolcanoManorSmolderingShield = 16007610,

        [Annotation(Name = "[LD - Volcano Manor] Dagger Talisman 16007620")]
        LDVolcanoManorDaggerTalisman = 16007620,

        [Annotation(Name = "[LD - Volcano Manor] Serpent-Hunter 16007690")]
        LDVolcanoManorSerpentHunter = 16007690,

        [Annotation(Name = "[LD - Volcano Manor] Seedbed Curse 16007700")]
        LDVolcanoManorSeedbedCurse = 16007700,

        [Annotation(Name = "[LD - Volcano Manor] Serpent's Amnion 16007710")]
        LDVolcanoManorSerpentsAmnion = 16007710,

        [Annotation(Name = "[LD - Volcano Manor] Recusant Finger 60260")]
        LDVolcanoManorRecusantFinger = 60260,

        [Annotation(Name = "[LD - Volcano Manor] Eye Surcoat 16007730")]
        LDVolcanoManorEyeSurcoat = 16007730,

        [Annotation(Name = "[LD - Volcano Manor] Ghiza's Wheel 16007940")]
        LDVolcanoManorGhizasWheel = 16007940,

        [Annotation(Name = "[LD - Volcano Manor] [Incantation] Aspects of the Crucible: Breath 16007950")]
        LDVolcanoManorIncantationAspectsOfTheCrucibleBreath = 16007950,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [1] 16007991")]
        LDVolcanoManorGoldenRune1 = 16007991,

        [Annotation(Name = "[LD - Volcano Manor] Golden Rune [1] 16007992")]
        LDVolcanoManorGoldenRune1_ = 16007992,

        [Annotation(Name = "[LD - Volcano Manor] Dragon Heart 16007999")]
        LDVolcanoManorDragonHeart = 16007999,

        [Annotation(Name = "[LD - Stranded Graveyard] Poisonbone Dart 18007000")]
        LDStrandedGraveyardPoisonboneDart = 18007000,

        [Annotation(Name = "[LD - Stranded Graveyard] Stonesword Key 18007010")]
        LDStrandedGraveyardStoneswordKey = 18007010,

        [Annotation(Name = "[LD - Stranded Graveyard] Golden Rune [5] 18007020")]
        LDStrandedGraveyardGoldenRune5 = 18007020,

        [Annotation(Name = "[LD - Stranded Graveyard] Dragonwound Grease 18007030")]
        LDStrandedGraveyardDragonwoundGrease = 18007030,

        [Annotation(Name = "[LD - Stranded Graveyard] Lightning Grease 18007040")]
        LDStrandedGraveyardLightningGrease = 18007040,

        [Annotation(Name = "[LD - Stranded Graveyard] Erdtree's Favor 18007050")]
        LDStrandedGraveyardErdtreesFavor = 18007050,

        [Annotation(Name = "[LD - Stranded Graveyard] Grave Glovewort [1] 18007060")]
        LDStrandedGraveyardGraveGlovewort1 = 18007060,

        [Annotation(Name = "[LD - Stranded Graveyard] Haligdrake Talisman 18007070")]
        LDStrandedGraveyardHaligdrakeTalisman = 18007070,

        [Annotation(Name = "[LD - Stranded Graveyard] Tarnished's Furled Finger 60220")]
        LDStrandedGraveyardTarnishedsFurledFinger = 60220,

        [Annotation(Name = "[LD - Stranded Graveyard] Finger Severer 60310")]
        LDStrandedGraveyardFingerSeverer = 60310,

        [Annotation(Name = "[LD - Stranded Graveyard] Erdtree Greatbow 18007900")]
        LDStrandedGraveyardErdtreeGreatbow = 18007900,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Catacombs] Human Bone Shard 30007010")]
        WeepingPeninsulaTombswardCatacombsHumanBoneShard = 30007010,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Catacombs] Golden Rune [2] 30007020")]
        WeepingPeninsulaTombswardCatacombsGoldenRune2 = 30007020,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Catacombs] Nomadic Warrior's Cookbook [9] 67430")]
        WeepingPeninsulaTombswardCatacombsNomadicWarriorsCookbook9 = 67430,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Catacombs] Prattling Pate \"Thank you\" 30007040")]
        WeepingPeninsulaTombswardCatacombsPrattlingPateThankyou = 30007040,

        [Annotation(Name = "[Weeping Peninsula - Impaler's Catacombs] Root Resin 30017010")]
        WeepingPeninsulaImpalersCatacombsRootResin = 30017010,

        [Annotation(Name = "[Weeping Peninsula - Impaler's Catacombs] Prattling Pate \"Please help\" 30017020")]
        WeepingPeninsulaImpalersCatacombsPrattlingPatePleasehelp = 30017020,

        [Annotation(Name = "[Limgrave - Stormfoot Catacombs] Root Resin 30027000")]
        LimgraveStormfootCatacombsRootResin = 30027000,

        [Annotation(Name = "[Limgrave - Stormfoot Catacombs] Smoldering Butterfly 30027010")]
        LimgraveStormfootCatacombsSmolderingButterfly = 30027010,

        [Annotation(Name = "[Limgrave - Stormfoot Catacombs] Wandering Noble Ashes 30027020")]
        LimgraveStormfootCatacombsWanderingNobleAshes = 30027020,

        [Annotation(Name = "[Limgrave - Stormfoot Catacombs] Prattling Pate \"Hello\" 30027030")]
        LimgraveStormfootCatacombsPrattlingPateHello = 30027030,

        [Annotation(Name = "[Liurnia - Road's End Catacombs] Root Resin 30037000")]
        LiurniaRoadsEndCatacombsRootResin = 30037000,

        [Annotation(Name = "[Liurnia - Road's End Catacombs] Raya Lucaria Soldier Ashes 30037010")]
        LiurniaRoadsEndCatacombsRayaLucariaSoldierAshes = 30037010,

        [Annotation(Name = "[Liurnia - Road's End Catacombs] Human Bone Shard 30037020")]
        LiurniaRoadsEndCatacombsHumanBoneShard = 30037020,

        [Annotation(Name = "[Liurnia - Road's End Catacombs] Rune Arc 30037030")]
        LiurniaRoadsEndCatacombsRuneArc = 30037030,

        [Annotation(Name = "[Liurnia - Road's End Catacombs] Watchdog's Staff 30037040")]
        LiurniaRoadsEndCatacombsWatchdogsStaff = 30037040,

        [Annotation(Name = "[Limgrave - Murkwater Catacombs] Root Resin 30047000")]
        LimgraveMurkwaterCatacombsRootResin = 30047000,

        [Annotation(Name = "[Liurnia - Black Knife Catacombs] Rosus' Axe 30057000")]
        LiurniaBlackKnifeCatacombsRosusAxe = 30057000,

        [Annotation(Name = "[Liurnia - Black Knife Catacombs] Rune Arc 30057010")]
        LiurniaBlackKnifeCatacombsRuneArc = 30057010,

        [Annotation(Name = "[Liurnia - Black Knife Catacombs] Deathroot 30057030")]
        LiurniaBlackKnifeCatacombsDeathroot = 30057030,

        [Annotation(Name = "[Liurnia - Black Knife Catacombs] Spellproof Dried Liver 30057040")]
        LiurniaBlackKnifeCatacombsSpellproofDriedLiver = 30057040,

        [Annotation(Name = "[Liurnia - Cliffbottom Catacombs] Root Resin 30067000")]
        LiurniaCliffbottomCatacombsRootResin = 30067000,

        [Annotation(Name = "[Liurnia - Cliffbottom Catacombs] Nox Mirrorhelm 30067010")]
        LiurniaCliffbottomCatacombsNoxMirrorhelm = 30067010,

        [Annotation(Name = "[Liurnia - Cliffbottom Catacombs] Golden Rune [3] 30067020")]
        LiurniaCliffbottomCatacombsGoldenRune3 = 30067020,

        [Annotation(Name = "[Liurnia - Cliffbottom Catacombs] Page Ashes 30067030")]
        LiurniaCliffbottomCatacombsPageAshes = 30067030,

        [Annotation(Name = "[Liurnia - Cliffbottom Catacombs] Rune Arc 30067040")]
        LiurniaCliffbottomCatacombsRuneArc = 30067040,

        [Annotation(Name = "[Liurnia - Cliffbottom Catacombs] Old Fang 30067050")]
        LiurniaCliffbottomCatacombsOldFang = 30067050,

        [Annotation(Name = "[Liurnia - Cliffbottom Catacombs] Hefty Beast Bone 30067060")]
        LiurniaCliffbottomCatacombsHeftyBeastBone = 30067060,

        [Annotation(Name = "[Liurnia - Cliffbottom Catacombs] Scythe 30067070")]
        LiurniaCliffbottomCatacombsScythe = 30067070,

        [Annotation(Name = "[Liurnia - Cliffbottom Catacombs] Prattling Pate \"Wonderful\" 30067080")]
        LiurniaCliffbottomCatacombsPrattlingPateWonderful = 30067080,

        [Annotation(Name = "[Mt. Gelmir - Wyndham Catacombs] Ancient Dragon Apostle's Cookbook [1] 68000")]
        MtGelmirWyndhamCatacombsAncientDragonApostlesCookbook1 = 68000,

        [Annotation(Name = "[Mt. Gelmir - Wyndham Catacombs] Golden Rune [5] 30077010")]
        MtGelmirWyndhamCatacombsGoldenRune5 = 30077010,

        [Annotation(Name = "[Mt. Gelmir - Wyndham Catacombs] Magic Grease 30077020")]
        MtGelmirWyndhamCatacombsMagicGrease = 30077020,

        [Annotation(Name = "[Mt. Gelmir - Wyndham Catacombs] Lightning Scorpion Charm 30077600")]
        MtGelmirWyndhamCatacombsLightningScorpionCharm = 30077600,

        [Annotation(Name = "[Mt. Gelmir - Wyndham Catacombs] Golden Rune [1] 30077900")]
        MtGelmirWyndhamCatacombsGoldenRune1 = 30077900,

        [Annotation(Name = "[Altus Plateau - Sainted Hero's Grave] Crimson Seed Talisman 30087010")]
        AltusPlateauSaintedHerosGraveCrimsonSeedTalisman = 30087010,

        [Annotation(Name = "[Altus Plateau - Sainted Hero's Grave] Leyndell Soldier Ashes 30087020")]
        AltusPlateauSaintedHerosGraveLeyndellSoldierAshes = 30087020,

        [Annotation(Name = "[Altus Plateau - Sainted Hero's Grave] Dragoncrest Shield Talisman +1 30087030")]
        AltusPlateauSaintedHerosGraveDragoncrestShieldTalisman1 = 30087030,

        [Annotation(Name = "[Altus Plateau - Sainted Hero's Grave] Root Resin 30087040")]
        AltusPlateauSaintedHerosGraveRootResin = 30087040,

        [Annotation(Name = "[Altus Plateau - Sainted Hero's Grave] Prattling Pate \"Let's get to it\" 30087050")]
        AltusPlateauSaintedHerosGravePrattlingPateLetsgettoit = 30087050,

        [Annotation(Name = "[Altus Plateau - Sainted Hero's Grave] Human Bone Shard 30087060")]
        AltusPlateauSaintedHerosGraveHumanBoneShard = 30087060,

        [Annotation(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Deathroot 30097000")]
        MtGelmirGelmirHerosGraveDeathroot = 30097000,

        [Annotation(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Ringed Finger 30097010")]
        MtGelmirGelmirHerosGraveRingedFinger = 30097010,

        [Annotation(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Golden Rune [6] 30097020")]
        MtGelmirGelmirHerosGraveGoldenRune6 = 30097020,

        [Annotation(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Smoldering Butterfly 30097030")]
        MtGelmirGelmirHerosGraveSmolderingButterfly = 30097030,

        [Annotation(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Stonesword Key 30097040")]
        MtGelmirGelmirHerosGraveStoneswordKey = 30097040,

        [Annotation(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Gelmir Knight Helm 30097050")]
        MtGelmirGelmirHerosGraveGelmirKnightHelm = 30097050,

        [Annotation(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Root Resin 30097060")]
        MtGelmirGelmirHerosGraveRootResin = 30097060,

        [Annotation(Name = "[Mt. Gelmir - Gelmir Hero's Grave] Beast Blood 30097070")]
        MtGelmirGelmirHerosGraveBeastBlood = 30097070,

        [Annotation(Name = "[Capital Outskirts - Auriza Hero's Grave] Holy Grease 30107010")]
        CapitalOutskirtsAurizaHerosGraveHolyGrease = 30107010,

        [Annotation(Name = "[Capital Outskirts - Auriza Hero's Grave] Fan Daggers 30107020")]
        CapitalOutskirtsAurizaHerosGraveFanDaggers = 30107020,

        [Annotation(Name = "[Capital Outskirts - Auriza Hero's Grave] Golden Rune [7] 30107030")]
        CapitalOutskirtsAurizaHerosGraveGoldenRune7 = 30107030,

        [Annotation(Name = "[Capital Outskirts - Auriza Hero's Grave] Crucible Feather Talisman 30107040")]
        CapitalOutskirtsAurizaHerosGraveCrucibleFeatherTalisman = 30107040,

        [Annotation(Name = "[Capital Outskirts - Auriza Hero's Grave] Golden Epitaph 30107050")]
        CapitalOutskirtsAurizaHerosGraveGoldenEpitaph = 30107050,

        [Annotation(Name = "[Capital Outskirts - Auriza Hero's Grave] Great Dragonfly Head 30107060")]
        CapitalOutskirtsAurizaHerosGraveGreatDragonflyHead = 30107060,

        [Annotation(Name = "[Capital Outskirts - Auriza Hero's Grave] Stonesword Key 30107070")]
        CapitalOutskirtsAurizaHerosGraveStoneswordKey = 30107070,

        [Annotation(Name = "[Capital Outskirts - Auriza Hero's Grave] Vulgar Militia Ashes 30107080")]
        CapitalOutskirtsAurizaHerosGraveVulgarMilitiaAshes = 30107080,

        [Annotation(Name = "[Capital Outskirts - Auriza Hero's Grave] Ash of War: Holy Ground 30107100")]
        CapitalOutskirtsAurizaHerosGraveAshOfWarHolyGround = 30107100,

        [Annotation(Name = "[Stormhill - Deathtouched Catacombs] Deathroot 30117000")]
        StormhillDeathtouchedCatacombsDeathroot = 30117000,

        [Annotation(Name = "[Stormhill - Deathtouched Catacombs] Bloodrose 30117010")]
        StormhillDeathtouchedCatacombsBloodrose = 30117010,

        [Annotation(Name = "[Stormhill - Deathtouched Catacombs] Uchigatana 30117020")]
        StormhillDeathtouchedCatacombsUchigatana = 30117020,

        [Annotation(Name = "[Altus Plateau - Unsightly Catacombs] Holy Grease 30127000")]
        AltusPlateauUnsightlyCatacombsHolyGrease = 30127000,

        [Annotation(Name = "[Altus Plateau - Unsightly Catacombs] Winged Misbegotten Ashes 30127010")]
        AltusPlateauUnsightlyCatacombsWingedMisbegottenAshes = 30127010,

        [Annotation(Name = "[Altus Plateau - Unsightly Catacombs] Rune Arc 30127020")]
        AltusPlateauUnsightlyCatacombsRuneArc = 30127020,

        [Annotation(Name = "[Altus Plateau - Unsightly Catacombs] Prattling Pate \"Apologies\" 30127030")]
        AltusPlateauUnsightlyCatacombsPrattlingPateApologies = 30127030,

        [Annotation(Name = "[Altus Plateau - Unsightly Catacombs] Golden Rune [1] 30127900")]
        AltusPlateauUnsightlyCatacombsGoldenRune1 = 30127900,

        [Annotation(Name = "[Capital Outskirts - Auriza Side Tomb] Perfumer's Cookbook [3] 67860")]
        CapitalOutskirtsAurizaSideTombPerfumersCookbook3 = 67860,

        [Annotation(Name = "[Capital Outskirts - Auriza Side Tomb] Golden Rune [7] 30137020")]
        CapitalOutskirtsAurizaSideTombGoldenRune7 = 30137020,

        [Annotation(Name = "[Capital Outskirts - Auriza Side Tomb] Smithing Stone [5] 30137030")]
        CapitalOutskirtsAurizaSideTombSmithingStone5 = 30137030,

        [Annotation(Name = "[Capital Outskirts - Auriza Side Tomb] Root Resin 30137040")]
        CapitalOutskirtsAurizaSideTombRootResin = 30137040,

        [Annotation(Name = "[Capital Outskirts - Auriza Side Tomb] Cracked Pot 66140")]
        CapitalOutskirtsAurizaSideTombCrackedPot = 66140,

        [Annotation(Name = "[Capital Outskirts - Auriza Side Tomb] Cracked Pot 66150")]
        CapitalOutskirtsAurizaSideTombCrackedPot_ = 66150,

        [Annotation(Name = "[Capital Outskirts - Auriza Side Tomb] Cracked Pot 66160")]
        CapitalOutskirtsAurizaSideTombCrackedPot__ = 66160,

        [Annotation(Name = "[Capital Outskirts - Auriza Side Tomb] Cracked Pot 66170")]
        CapitalOutskirtsAurizaSideTombCrackedPot___ = 66170,

        [Annotation(Name = "[Capital Outskirts - Auriza Side Tomb] Ritual Pot 66470")]
        CapitalOutskirtsAurizaSideTombRitualPot = 66470,

        [Annotation(Name = "[Capital Outskirts - Auriza Side Tomb] Ritual Pot 66480")]
        CapitalOutskirtsAurizaSideTombRitualPot_ = 66480,

        [Annotation(Name = "[Caelid - Minor Erdtree Catacombs] Imp Head (Wolf) 30147000")]
        CaelidMinorErdtreeCatacombsImpHeadWolf = 30147000,

        [Annotation(Name = "[Caelid - Minor Erdtree Catacombs] Grave Violet 30147010")]
        CaelidMinorErdtreeCatacombsGraveViolet = 30147010,

        [Annotation(Name = "[Caelid - Minor Erdtree Catacombs] Sacramental Bud 30147020")]
        CaelidMinorErdtreeCatacombsSacramentalBud = 30147020,

        [Annotation(Name = "[Caelid - Minor Erdtree Catacombs] Aeonian Butterfly 30147030")]
        CaelidMinorErdtreeCatacombsAeonianButterfly = 30147030,

        [Annotation(Name = "[Caelid - Minor Erdtree Catacombs] Golden Rune [4] 30147040")]
        CaelidMinorErdtreeCatacombsGoldenRune4 = 30147040,

        [Annotation(Name = "[Caelid - Minor Erdtree Catacombs] Golden Rune [1] 30147900")]
        CaelidMinorErdtreeCatacombsGoldenRune1 = 30147900,

        [Annotation(Name = "[Caelid - Caelid Catacombs] Miranda Sprout Ashes 30157000")]
        CaelidCaelidCatacombsMirandaSproutAshes = 30157000,

        [Annotation(Name = "[Caelid - War-Dead Catacombs] Golden Rune [6] 30167000")]
        CaelidWarDeadCatacombsGoldenRune6 = 30167000,

        [Annotation(Name = "[Caelid - War-Dead Catacombs] Magic Grease 30167010")]
        CaelidWarDeadCatacombsMagicGrease = 30167010,

        [Annotation(Name = "[Caelid - War-Dead Catacombs] Radahn Soldier Ashes 30167020")]
        CaelidWarDeadCatacombsRadahnSoldierAshes = 30167020,

        [Annotation(Name = "[Caelid - War-Dead Catacombs] Silver-Pickled Fowl Foot 30167030")]
        CaelidWarDeadCatacombsSilverPickledFowlFoot = 30167030,

        [Annotation(Name = "[Caelid - War-Dead Catacombs] [Sorcery] Collapsing Stars 30167040")]
        CaelidWarDeadCatacombsSorceryCollapsingStars = 30167040,

        [Annotation(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Cranial Vessel Candlestand 30177000")]
        FlamePeakGiantConqueringHerosGraveCranialVesselCandlestand = 30177000,

        [Annotation(Name = "[Flame Peak - Giant-Conquering Hero's Grave] [Incantation] Flame 30177010")]
        FlamePeakGiantConqueringHerosGraveIncantationFlame = 30177010,

        [Annotation(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Lightning Bastard Sword 30177020")]
        FlamePeakGiantConqueringHerosGraveLightningBastardSword = 30177020,

        [Annotation(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Giant's Seal 30177030")]
        FlamePeakGiantConqueringHerosGraveGiantsSeal = 30177030,

        [Annotation(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Freezing Grease 30177040")]
        FlamePeakGiantConqueringHerosGraveFreezingGrease = 30177040,

        [Annotation(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Golden Rune [11] 30177050")]
        FlamePeakGiantConqueringHerosGraveGoldenRune11 = 30177050,

        [Annotation(Name = "[Flame Peak - Giant-Conquering Hero's Grave] Golden Rune [1] 30177060")]
        FlamePeakGiantConqueringHerosGraveGoldenRune1 = 30177060,

        [Annotation(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Golden Rune [10] 30187000")]
        FlamePeakGiantsMountaintopCatacombsGoldenRune10 = 30187000,

        [Annotation(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Stimulating Boluses 30187010")]
        FlamePeakGiantsMountaintopCatacombsStimulatingBoluses = 30187010,

        [Annotation(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Nascent Butterfly 30187020")]
        FlamePeakGiantsMountaintopCatacombsNascentButterfly = 30187020,

        [Annotation(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Root Resin 30187030")]
        FlamePeakGiantsMountaintopCatacombsRootResin = 30187030,

        [Annotation(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Ritual Pot 66400")]
        FlamePeakGiantsMountaintopCatacombsRitualPot = 66400,

        [Annotation(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Fire Monk Ashes 30187070")]
        FlamePeakGiantsMountaintopCatacombsFireMonkAshes = 30187070,

        [Annotation(Name = "[Flame Peak - Giants' Mountaintop Catacombs] Deathroot 30187900")]
        FlamePeakGiantsMountaintopCatacombsDeathroot = 30187900,

        [Annotation(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Golden Rune [12] 30197000")]
        FlamePeakConsecratedSnowfieldCatacombsGoldenRune12 = 30197000,

        [Annotation(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Rejuvenating Boluses 30197010")]
        FlamePeakConsecratedSnowfieldCatacombsRejuvenatingBoluses = 30197010,

        [Annotation(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Root Resin 30197020")]
        FlamePeakConsecratedSnowfieldCatacombsRootResin = 30197020,

        [Annotation(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Human Bone Shard 30197030")]
        FlamePeakConsecratedSnowfieldCatacombsHumanBoneShard = 30197030,

        [Annotation(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Imp Head (Elder) 30197040")]
        FlamePeakConsecratedSnowfieldCatacombsImpHeadElder = 30197040,

        [Annotation(Name = "[Flame Peak - Consecrated Snowfield Catacombs] Golden Rune [1] 30197900")]
        FlamePeakConsecratedSnowfieldCatacombsGoldenRune1 = 30197900,

        [Annotation(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Warming Stone 30207000")]
        ForbiddenLandsHiddenPathtoTheHaligtreeWarmingStone = 30207000,

        [Annotation(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Sacramental Bud 30207010")]
        ForbiddenLandsHiddenPathtoTheHaligtreeSacramentalBud = 30207010,

        [Annotation(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Hero's Rune [1] 30207020")]
        ForbiddenLandsHiddenPathtoTheHaligtreeHerosRune1 = 30207020,

        [Annotation(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Old Fang 30207030")]
        ForbiddenLandsHiddenPathtoTheHaligtreeOldFang = 30207030,

        [Annotation(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Root Resin 30207040")]
        ForbiddenLandsHiddenPathtoTheHaligtreeRootResin = 30207040,

        [Annotation(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Freezing Grease 30207050")]
        ForbiddenLandsHiddenPathtoTheHaligtreeFreezingGrease = 30207050,

        [Annotation(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Spelldrake Talisman +2 30207060")]
        ForbiddenLandsHiddenPathtoTheHaligtreeSpelldrakeTalisman2 = 30207060,

        [Annotation(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Silver Scarab 30207900")]
        ForbiddenLandsHiddenPathtoTheHaligtreeSilverScarab = 30207900,

        [Annotation(Name = "[Forbidden Lands - Hidden Path to the Haligtree] Deathroot 30207910")]
        ForbiddenLandsHiddenPathtoTheHaligtreeDeathroot = 30207910,

        [Annotation(Name = "[Limgrave - Murkwater Cave] Mushroom 31007000")]
        LimgraveMurkwaterCaveMushroom = 31007000,

        [Annotation(Name = "[Limgrave - Murkwater Cave] Cloth Garb 31007010")]
        LimgraveMurkwaterCaveClothGarb = 31007010,

        [Annotation(Name = "[Weeping Peninsula - Earthbore Cave] Golden Rune [1] 31017000")]
        WeepingPeninsulaEarthboreCaveGoldenRune1 = 31017000,

        [Annotation(Name = "[Weeping Peninsula - Earthbore Cave] Glowstone 31017010")]
        WeepingPeninsulaEarthboreCaveGlowstone = 31017010,

        [Annotation(Name = "[Weeping Peninsula - Earthbore Cave] Kukri 31017020")]
        WeepingPeninsulaEarthboreCaveKukri = 31017020,

        [Annotation(Name = "[Weeping Peninsula - Earthbore Cave] Smoldering Butterfly 31017030")]
        WeepingPeninsulaEarthboreCaveSmolderingButterfly = 31017030,

        [Annotation(Name = "[Weeping Peninsula - Earthbore Cave] Trina's Lily 31017040")]
        WeepingPeninsulaEarthboreCaveTrinasLily = 31017040,

        [Annotation(Name = "[Weeping Peninsula - Earthbore Cave] Pickled Turtle Neck 31017060")]
        WeepingPeninsulaEarthboreCavePickledTurtleNeck = 31017060,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Cave] Golden Rune [2] 31027000")]
        WeepingPeninsulaTombswardCaveGoldenRune2 = 31027000,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Cave] Furlcalling Finger Remedy 31027010")]
        WeepingPeninsulaTombswardCaveFurlcallingFingerRemedy = 31027010,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Cave] Poisonbone Dart 31027020")]
        WeepingPeninsulaTombswardCavePoisonboneDart = 31027020,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Cave] Arteria Leaf 31027030")]
        WeepingPeninsulaTombswardCaveArteriaLeaf = 31027030,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Cave] Nomadic Warrior's Cookbook [8] 67880")]
        WeepingPeninsulaTombswardCaveNomadicWarriorsCookbook8 = 67880,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Cave] Immunizing White Cured Meat 31027050")]
        WeepingPeninsulaTombswardCaveImmunizingWhiteCuredMeat = 31027050,

        [Annotation(Name = "[Limgrave - Groveside Cave] Golden Rune [1] 31037000")]
        LimgraveGrovesideCaveGoldenRune1 = 31037000,

        [Annotation(Name = "[Limgrave - Groveside Cave] Glowstone 31037010")]
        LimgraveGrovesideCaveGlowstone = 31037010,

        [Annotation(Name = "[Limgrave - Groveside Cave] Cracked Pot 66000")]
        LimgraveGrovesideCaveCrackedPot = 66000,

        [Annotation(Name = "[Liurnia - Stillwater Cave] Golden Rune [3] 31047000")]
        LiurniaStillwaterCaveGoldenRune3 = 31047000,

        [Annotation(Name = "[Liurnia - Stillwater Cave] Golden Rune [4] 31047010")]
        LiurniaStillwaterCaveGoldenRune4 = 31047010,

        [Annotation(Name = "[Liurnia - Stillwater Cave] Serpent Arrow 31047020")]
        LiurniaStillwaterCaveSerpentArrow = 31047020,

        [Annotation(Name = "[Liurnia - Stillwater Cave] Golden Rune [5] 31047030")]
        LiurniaStillwaterCaveGoldenRune5 = 31047030,

        [Annotation(Name = "[Liurnia - Stillwater Cave] Glowstone 31047040")]
        LiurniaStillwaterCaveGlowstone = 31047040,

        [Annotation(Name = "[Liurnia - Stillwater Cave] Poison Grease 31047050")]
        LiurniaStillwaterCavePoisonGrease = 31047050,

        [Annotation(Name = "[Liurnia - Stillwater Cave] Sage Hood 31047060")]
        LiurniaStillwaterCaveSageHood = 31047060,

        [Annotation(Name = "[Liurnia - Lakeside Crystal Cave] Hefty Beast Bone 31057000")]
        LiurniaLakesideCrystalCaveHeftyBeastBone = 31057000,

        [Annotation(Name = "[Liurnia - Lakeside Crystal Cave] Throwing Dagger 31057010")]
        LiurniaLakesideCrystalCaveThrowingDagger = 31057010,

        [Annotation(Name = "[Liurnia - Lakeside Crystal Cave] Golden Rune [5] 31057020")]
        LiurniaLakesideCrystalCaveGoldenRune5 = 31057020,

        [Annotation(Name = "[Liurnia - Lakeside Crystal Cave] Soft Cotton 31057030")]
        LiurniaLakesideCrystalCaveSoftCotton = 31057030,

        [Annotation(Name = "[Liurnia - Lakeside Crystal Cave] Smithing Stone [4] 31057040")]
        LiurniaLakesideCrystalCaveSmithingStone4 = 31057040,

        [Annotation(Name = "[Liurnia - Lakeside Crystal Cave] Smithing Stone [2] 31057050")]
        LiurniaLakesideCrystalCaveSmithingStone2 = 31057050,

        [Annotation(Name = "[Liurnia - Lakeside Crystal Cave] Lump of Flesh 31057060")]
        LiurniaLakesideCrystalCaveLumpOfFlesh = 31057060,

        [Annotation(Name = "[Liurnia - Lakeside Crystal Cave] Arteria Leaf 31057070")]
        LiurniaLakesideCrystalCaveArteriaLeaf = 31057070,

        [Annotation(Name = "[Liurnia - Lakeside Crystal Cave] Spear Talisman 31057100")]
        LiurniaLakesideCrystalCaveSpearTalisman = 31057100,

        [Annotation(Name = "[Liurnia - Academy Crystal Cave] Cuckoo Glintstone 31067000")]
        LiurniaAcademyCrystalCaveCuckooGlintstone = 31067000,

        [Annotation(Name = "[Liurnia - Academy Crystal Cave] Stonesword Key 31067010")]
        LiurniaAcademyCrystalCaveStoneswordKey = 31067010,

        [Annotation(Name = "[Liurnia - Academy Crystal Cave] Rune Arc 31067100")]
        LiurniaAcademyCrystalCaveRuneArc = 31067100,

        [Annotation(Name = "[Liurnia - Academy Crystal Cave] Crystal Staff 31067030")]
        LiurniaAcademyCrystalCaveCrystalStaff = 31067030,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Cave] Poison Grease 31077000")]
        MtGelmirSeethewaterCavePoisonGrease = 31077000,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Cave] Lump of Flesh 31077010")]
        MtGelmirSeethewaterCaveLumpOfFlesh = 31077010,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Cave] Preserving Boluses 31077020")]
        MtGelmirSeethewaterCavePreservingBoluses = 31077020,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Cave] Mushroom Head 31077030")]
        MtGelmirSeethewaterCaveMushroomHead = 31077030,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Cave] Poisonbone Dart 31077040")]
        MtGelmirSeethewaterCavePoisonboneDart = 31077040,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Cave] Golden Rune [6] 31077050")]
        MtGelmirSeethewaterCaveGoldenRune6 = 31077050,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Cave] Golden Rune [7] 31077060")]
        MtGelmirSeethewaterCaveGoldenRune7 = 31077060,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Cave] Immunizing Cured Meat 31077070")]
        MtGelmirSeethewaterCaveImmunizingCuredMeat = 31077070,

        [Annotation(Name = "[Mt. Gelmir - Volcano Cave] Golden Rune [6] 31097000")]
        MtGelmirVolcanoCaveGoldenRune6 = 31097000,

        [Annotation(Name = "[Mt. Gelmir - Volcano Cave] Sliver of Meat 31097010")]
        MtGelmirVolcanoCaveSliverOfMeat = 31097010,

        [Annotation(Name = "[Mt. Gelmir - Volcano Cave] Arteria Leaf 31097020")]
        MtGelmirVolcanoCaveArteriaLeaf = 31097020,

        [Annotation(Name = "[Mt. Gelmir - Volcano Cave] Lump of Flesh 31097030")]
        MtGelmirVolcanoCaveLumpOfFlesh = 31097030,

        [Annotation(Name = "[Mt. Gelmir - Volcano Cave] Coil Shield 31097040")]
        MtGelmirVolcanoCaveCoilShield = 31097040,

        [Annotation(Name = "[Altus Plateau - Perfumer's Grotto] Perfume Bottle 66780")]
        AltusPlateauPerfumersGrottoPerfumeBottle = 66780,

        [Annotation(Name = "[Altus Plateau - Perfumer's Grotto] Living Jar Shard 31187020")]
        AltusPlateauPerfumersGrottoLivingJarShard = 31187020,

        [Annotation(Name = "[Altus Plateau - Perfumer's Grotto] Living Jar Shard 31187030")]
        AltusPlateauPerfumersGrottoLivingJarShard_ = 31187030,

        [Annotation(Name = "[Altus Plateau - Perfumer's Grotto] Arteria Leaf 31187040")]
        AltusPlateauPerfumersGrottoArteriaLeaf = 31187040,

        [Annotation(Name = "[Altus Plateau - Perfumer's Grotto] Golden Rune [5] 31187050")]
        AltusPlateauPerfumersGrottoGoldenRune5 = 31187050,

        [Annotation(Name = "[Altus Plateau - Perfumer's Grotto] Miranda Powder 31187060")]
        AltusPlateauPerfumersGrottoMirandaPowder = 31187060,

        [Annotation(Name = "[Altus Plateau - Perfumer's Grotto] Warming Stone 31187070")]
        AltusPlateauPerfumersGrottoWarmingStone = 31187070,

        [Annotation(Name = "[Altus Plateau - Perfumer's Grotto] Golden Rune [5] 31187080")]
        AltusPlateauPerfumersGrottoGoldenRune5_ = 31187080,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Rejuvenating Boluses 31197000")]
        AltusPlateauSagesCaveRejuvenatingBoluses = 31197000,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Lost Ashes of War 31197010")]
        AltusPlateauSagesCaveLostAshesOfWar = 31197010,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Candletree Wooden Shield 31197030")]
        AltusPlateauSagesCaveCandletreeWoodenShield = 31197030,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Silver-Pickled Fowl Foot 31197040")]
        AltusPlateauSagesCaveSilverPickledFowlFoot = 31197040,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Black Hood 31197050")]
        AltusPlateauSagesCaveBlackHood = 31197050,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Nascent Butterfly 31197060")]
        AltusPlateauSagesCaveNascentButterfly = 31197060,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Stonesword Key 31197080")]
        AltusPlateauSagesCaveStoneswordKey = 31197080,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Dragonwound Grease 31197090")]
        AltusPlateauSagesCaveDragonwoundGrease = 31197090,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Raptor Talons 31197100")]
        AltusPlateauSagesCaveRaptorTalons = 31197100,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Golden Great Arrow 31197110")]
        AltusPlateauSagesCaveGoldenGreatArrow = 31197110,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Raptor's Black Feathers 31197120")]
        AltusPlateauSagesCaveRaptorsBlackFeathers = 31197120,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Skeletal Mask 31197130")]
        AltusPlateauSagesCaveSkeletalMask = 31197130,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Golden Rune [5] 31197200")]
        AltusPlateauSagesCaveGoldenRune5 = 31197200,

        [Annotation(Name = "[Altus Plateau - Sage's Cave] Golden Rune [5] 31197210")]
        AltusPlateauSagesCaveGoldenRune5_ = 31197210,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Cave] Warming Stone 31107000")]
        GreyollsDragonbarrowDragonbarrowCaveWarmingStone = 31107000,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Cave] Golden Rune [12] 31107010")]
        GreyollsDragonbarrowDragonbarrowCaveGoldenRune12 = 31107010,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Cave] Bull-Goat's Talisman 31107050")]
        GreyollsDragonbarrowDragonbarrowCaveBullGoatsTalisman = 31107050,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Cave] Golden Rune [8] 31107110")]
        GreyollsDragonbarrowDragonbarrowCaveGoldenRune8 = 31107110,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Cave] Beast Blood 31107120")]
        GreyollsDragonbarrowDragonbarrowCaveBeastBlood = 31107120,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Golden Rune [3] 31117000")]
        GreyollsDragonbarrowSelliaHideawayGoldenRune3 = 31117000,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Lost Ashes of War 31117010")]
        GreyollsDragonbarrowSelliaHideawayLostAshesOfWar = 31117010,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Golden Rune [5] 31117020")]
        GreyollsDragonbarrowSelliaHideawayGoldenRune5 = 31117020,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Stimulating Boluses 31117030")]
        GreyollsDragonbarrowSelliaHideawayStimulatingBoluses = 31117030,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Somber Smithing Stone [4] 31117040")]
        GreyollsDragonbarrowSelliaHideawaySomberSmithingStone4 = 31117040,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Preserving Boluses 31117080")]
        GreyollsDragonbarrowSelliaHideawayPreservingBoluses = 31117080,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Crystal Dart 31117090")]
        GreyollsDragonbarrowSelliaHideawayCrystalDart = 31117090,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Golden Rune [5] 31117100")]
        GreyollsDragonbarrowSelliaHideawayGoldenRune5_ = 31117100,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Glowstone 31117110")]
        GreyollsDragonbarrowSelliaHideawayGlowstone = 31117110,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Crystal Spear 31117200")]
        GreyollsDragonbarrowSelliaHideawayCrystalSpear = 31117200,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Crystalian Ashes 31117220")]
        GreyollsDragonbarrowSelliaHideawayCrystalianAshes = 31117220,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Sellia Hideaway] Smithing Stone [1] 31117300")]
        GreyollsDragonbarrowSelliaHideawaySmithingStone1 = 31117300,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Golden Rune [7] 31127000")]
        ConsecratedSnowfieldCaveOfTheForlornGoldenRune7 = 31127000,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Freezing Grease 31127010")]
        ConsecratedSnowfieldCaveOfTheForlornFreezingGrease = 31127010,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Hero's Rune [2] 31127020")]
        ConsecratedSnowfieldCaveOfTheForlornHerosRune2 = 31127020,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Rune Arc 31127030")]
        ConsecratedSnowfieldCaveOfTheForlornRuneArc = 31127030,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Miquella's Lily 31127040")]
        ConsecratedSnowfieldCaveOfTheForlornMiquellasLily = 31127040,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Nascent Butterfly 31127050")]
        ConsecratedSnowfieldCaveOfTheForlornNascentButterfly = 31127050,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Thawfrost Boluses 31127060")]
        ConsecratedSnowfieldCaveOfTheForlornThawfrostBoluses = 31127060,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Crystal Dart 31127070")]
        ConsecratedSnowfieldCaveOfTheForlornCrystalDart = 31127070,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Thawfrost Boluses 31127080")]
        ConsecratedSnowfieldCaveOfTheForlornThawfrostBoluses_ = 31127080,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Freezing Grease 31127090")]
        ConsecratedSnowfieldCaveOfTheForlornFreezingGrease_ = 31127090,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Freezing Grease 31127100")]
        ConsecratedSnowfieldCaveOfTheForlornFreezingGrease__ = 31127100,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Golden Rune [10] 31127110")]
        ConsecratedSnowfieldCaveOfTheForlornGoldenRune10 = 31127110,

        [Annotation(Name = "[Consecrated Snowfield - Cave of the Forlorn] Spiritflame Arrow 31127120")]
        ConsecratedSnowfieldCaveOfTheForlornSpiritflameArrow = 31127120,

        [Annotation(Name = "[Limgrave - Coastal Cave] Land Octopus Ovary 31157010")]
        LimgraveCoastalCaveLandOctopusOvary = 31157010,

        [Annotation(Name = "[Limgrave - Coastal Cave] Smoldering Butterfly 31157020")]
        LimgraveCoastalCaveSmolderingButterfly = 31157020,

        [Annotation(Name = "[Limgrave - Highroad Cave] Golden Rune [1] 31177010")]
        LimgraveHighroadCaveGoldenRune1 = 31177010,

        [Annotation(Name = "[Limgrave - Highroad Cave] Arteria Leaf 31177020")]
        LimgraveHighroadCaveArteriaLeaf = 31177020,

        [Annotation(Name = "[Limgrave - Highroad Cave] Smithing Stone [1] 31177030")]
        LimgraveHighroadCaveSmithingStone1 = 31177030,

        [Annotation(Name = "[Limgrave - Highroad Cave] Smithing Stone [2] 31177040")]
        LimgraveHighroadCaveSmithingStone2 = 31177040,

        [Annotation(Name = "[Limgrave - Highroad Cave] Golden Rune [4] 31177050")]
        LimgraveHighroadCaveGoldenRune4 = 31177050,

        [Annotation(Name = "[Limgrave - Highroad Cave] Fire Grease 31177060")]
        LimgraveHighroadCaveFireGrease = 31177060,

        [Annotation(Name = "[Limgrave - Highroad Cave] Furlcalling Finger Remedy 31177070")]
        LimgraveHighroadCaveFurlcallingFingerRemedy = 31177070,

        [Annotation(Name = "[Limgrave - Highroad Cave] Shamshir 31177080")]
        LimgraveHighroadCaveShamshir = 31177080,

        [Annotation(Name = "[Caelid - Abandoned Cave] Dragonwound Grease 31207000")]
        CaelidAbandonedCaveDragonwoundGrease = 31207000,

        [Annotation(Name = "[Caelid - Abandoned Cave] Venomous Fang 31207010")]
        CaelidAbandonedCaveVenomousFang = 31207010,

        [Annotation(Name = "[Caelid - Abandoned Cave] Serpent Bow 31207020")]
        CaelidAbandonedCaveSerpentBow = 31207020,

        [Annotation(Name = "[Caelid - Abandoned Cave] Fire Grease 31207030")]
        CaelidAbandonedCaveFireGrease = 31207030,

        [Annotation(Name = "[Caelid - Gaol Cave] Golden Rune [2] 31217000")]
        CaelidGaolCaveGoldenRune2 = 31217000,

        [Annotation(Name = "[Caelid - Gaol Cave] Golden Rune [2] 31217030")]
        CaelidGaolCaveGoldenRune2_ = 31217030,

        [Annotation(Name = "[Caelid - Gaol Cave] Old Fang 31217040")]
        CaelidGaolCaveOldFang = 31217040,

        [Annotation(Name = "[Caelid - Gaol Cave] Golden Rune [2] 31217070")]
        CaelidGaolCaveGoldenRune2__ = 31217070,

        [Annotation(Name = "[Caelid - Gaol Cave] Golden Rune [4] 31217080")]
        CaelidGaolCaveGoldenRune4 = 31217080,

        [Annotation(Name = "[Caelid - Gaol Cave] Stonesword Key 31217090")]
        CaelidGaolCaveStoneswordKey = 31217090,

        [Annotation(Name = "[Caelid - Gaol Cave] Wakizashi 31217100")]
        CaelidGaolCaveWakizashi = 31217100,

        [Annotation(Name = "[Caelid - Gaol Cave] Golden Rune [4] 31217110")]
        CaelidGaolCaveGoldenRune4_ = 31217110,

        [Annotation(Name = "[Caelid - Gaol Cave] Turtle Neck Meat 31217120")]
        CaelidGaolCaveTurtleNeckMeat = 31217120,

        [Annotation(Name = "[Caelid - Gaol Cave] Golden Rune [5] 31217140")]
        CaelidGaolCaveGoldenRune5 = 31217140,

        [Annotation(Name = "[Caelid - Gaol Cave] Rainbow Stone 31217150")]
        CaelidGaolCaveRainbowStone = 31217150,

        [Annotation(Name = "[Caelid - Gaol Cave] Golden Rune [4] 31217160")]
        CaelidGaolCaveGoldenRune4__ = 31217160,

        [Annotation(Name = "[Caelid - Gaol Cave] Glowstone 31217190")]
        CaelidGaolCaveGlowstone = 31217190,

        [Annotation(Name = "[Caelid - Gaol Cave] Somber Smithing Stone [5] 31217200")]
        CaelidGaolCaveSomberSmithingStone5 = 31217200,

        [Annotation(Name = "[Caelid - Gaol Cave] Pillory Shield 31217210")]
        CaelidGaolCavePilloryShield = 31217210,

        [Annotation(Name = "[Caelid - Gaol Cave] Regalia of Eochaid 31217350")]
        CaelidGaolCaveRegaliaOfEochaid = 31217350,

        [Annotation(Name = "[Caelid - Gaol Cave] Rune Arc 31217400")]
        CaelidGaolCaveRuneArc = 31217400,

        [Annotation(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] White Reed Armor 31227000")]
        MountaintopsOfTheGiantsSpiritcallersCaveWhiteReedArmor = 31227000,

        [Annotation(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Golden Rune [6] 31227010")]
        MountaintopsOfTheGiantsSpiritcallersCaveGoldenRune6 = 31227010,

        [Annotation(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Golden Rune [12] 31227020")]
        MountaintopsOfTheGiantsSpiritcallersCaveGoldenRune12 = 31227020,

        [Annotation(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Freezing Grease 31227030")]
        MountaintopsOfTheGiantsSpiritcallersCaveFreezingGrease = 31227030,

        [Annotation(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Golden Rune [10] 31227040")]
        MountaintopsOfTheGiantsSpiritcallersCaveGoldenRune10 = 31227040,

        [Annotation(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Hero's Rune [1] 31227050")]
        MountaintopsOfTheGiantsSpiritcallersCaveHerosRune1 = 31227050,

        [Annotation(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Rune Arc 31227060")]
        MountaintopsOfTheGiantsSpiritcallersCaveRuneArc = 31227060,

        [Annotation(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Invigorating White Cured Meat 31227070")]
        MountaintopsOfTheGiantsSpiritcallersCaveInvigoratingWhiteCuredMeat = 31227070,

        [Annotation(Name = "[Mountaintops of the Giants - Spiritcaller's Cave] Arteria Leaf 31227080")]
        MountaintopsOfTheGiantsSpiritcallersCaveArteriaLeaf = 31227080,

        [Annotation(Name = "[Weeping Peninsula - Morne Tunnel] Golden Rune [2] 32007000")]
        WeepingPeninsulaMorneTunnelGoldenRune2 = 32007000,

        [Annotation(Name = "[Weeping Peninsula - Morne Tunnel] Golden Rune [4] 32007010")]
        WeepingPeninsulaMorneTunnelGoldenRune4 = 32007010,

        [Annotation(Name = "[Weeping Peninsula - Morne Tunnel] Large Glintstone Scrap 32007020")]
        WeepingPeninsulaMorneTunnelLargeGlintstoneScrap = 32007020,

        [Annotation(Name = "[Weeping Peninsula - Morne Tunnel] Stanching Boluses 32007030")]
        WeepingPeninsulaMorneTunnelStanchingBoluses = 32007030,

        [Annotation(Name = "[Weeping Peninsula - Morne Tunnel] Soft Cotton 32007060")]
        WeepingPeninsulaMorneTunnelSoftCotton = 32007060,

        [Annotation(Name = "[Weeping Peninsula - Morne Tunnel] Arteria Leaf 32007070")]
        WeepingPeninsulaMorneTunnelArteriaLeaf = 32007070,

        [Annotation(Name = "[Weeping Peninsula - Morne Tunnel] Exalted Flesh 32007900")]
        WeepingPeninsulaMorneTunnelExaltedFlesh = 32007900,

        [Annotation(Name = "[Limgrave - Limgrave Tunnels] Smithing Stone [1] 32017000")]
        LimgraveLimgraveTunnelsSmithingStone1 = 32017000,

        [Annotation(Name = "[Limgrave - Limgrave Tunnels] Golden Rune [4] 32017010")]
        LimgraveLimgraveTunnelsGoldenRune4 = 32017010,

        [Annotation(Name = "[Limgrave - Limgrave Tunnels] Large Glintstone Scrap 32017020")]
        LimgraveLimgraveTunnelsLargeGlintstoneScrap = 32017020,

        [Annotation(Name = "[Limgrave - Limgrave Tunnels] Golden Rune [1] 32017030")]
        LimgraveLimgraveTunnelsGoldenRune1 = 32017030,

        [Annotation(Name = "[Limgrave - Limgrave Tunnels] Glintstone Scrap 32017040")]
        LimgraveLimgraveTunnelsGlintstoneScrap = 32017040,

        [Annotation(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Somber Smithing Stone [2] 32027000")]
        LiurniaRayaLucariaCrystalTunnelSomberSmithingStone2 = 32027000,

        [Annotation(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Somber Smithing Stone [3] 32027010")]
        LiurniaRayaLucariaCrystalTunnelSomberSmithingStone3 = 32027010,

        [Annotation(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Golden Rune [3] 32027020")]
        LiurniaRayaLucariaCrystalTunnelGoldenRune3 = 32027020,

        [Annotation(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Smithing Stone [3] 32027030")]
        LiurniaRayaLucariaCrystalTunnelSmithingStone3 = 32027030,

        [Annotation(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Somber Smithing Stone [3] 32027040")]
        LiurniaRayaLucariaCrystalTunnelSomberSmithingStone3_ = 32027040,

        [Annotation(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Smithing Stone [1] 32027060")]
        LiurniaRayaLucariaCrystalTunnelSmithingStone1 = 32027060,

        [Annotation(Name = "[Liurnia - Raya Lucaria Crystal Tunnel [Sorcery] Shatter Earth 32027070")]
        LiurniaRayaLucariaCrystalTunnelSorceryShatterEarth = 32027070,

        [Annotation(Name = "[Liurnia - Raya Lucaria Crystal Tunnel Crystal Knife 32027900")]
        LiurniaRayaLucariaCrystalTunnelCrystalKnife = 32027900,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel] Golden Rune [6] 32047000")]
        AltusPlateauOldAltusTunnelGoldenRune6 = 32047000,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel] Stanching Boluses 32047010")]
        AltusPlateauOldAltusTunnelStanchingBoluses = 32047010,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel] Somber Smithing Stone [4] 32047020")]
        AltusPlateauOldAltusTunnelSomberSmithingStone4 = 32047020,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel] Explosive Stone Clump 32047030")]
        AltusPlateauOldAltusTunnelExplosiveStoneClump = 32047030,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel] Boltdrake Talisman +1 32047040")]
        AltusPlateauOldAltusTunnelBoltdrakeTalisman1 = 32047040,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel] Troll's Hammer 32047050")]
        AltusPlateauOldAltusTunnelTrollsHammer = 32047050,

        [Annotation(Name = "[Altus Plateau - Altus Tunnel] Crystal Dart 32057000")]
        AltusPlateauAltusTunnelCrystalDart = 32057000,

        [Annotation(Name = "[Altus Plateau - Altus Tunnel] Arteria Leaf 32057010")]
        AltusPlateauAltusTunnelArteriaLeaf = 32057010,

        [Annotation(Name = "[Altus Plateau - Altus Tunnel] Golden Rune [7] 32057020")]
        AltusPlateauAltusTunnelGoldenRune7 = 32057020,

        [Annotation(Name = "[Altus Plateau - Altus Tunnel] Arsenal Charm +1 32057030")]
        AltusPlateauAltusTunnelArsenalCharm1 = 32057030,

        [Annotation(Name = "[Altus Plateau - Altus Tunnel] Glintstone Scrap 32057040")]
        AltusPlateauAltusTunnelGlintstoneScrap = 32057040,

        [Annotation(Name = "[Altus Plateau - Altus Tunnel] 32057900")]
        AltusPlateauAltusTunnel = 32057900,

        [Annotation(Name = "[Altus Plateau - Altus Tunnel] Rune Arc 32057910")]
        AltusPlateauAltusTunnelRuneArc = 32057910,

        [Annotation(Name = "[Caelid - Gael Tunnel] Somber Smithing Stone [2] 32077000")]
        CaelidGaelTunnelSomberSmithingStone2 = 32077000,

        [Annotation(Name = "[Caelid - Gael Tunnel] Golden Rune [5] 32077010")]
        CaelidGaelTunnelGoldenRune5 = 32077010,

        [Annotation(Name = "[Caelid - Gael Tunnel] Cross-Naginata 32077020")]
        CaelidGaelTunnelCrossNaginata = 32077020,

        [Annotation(Name = "[Caelid - Gael Tunnel] Dragonbane Talisman 32077030")]
        CaelidGaelTunnelDragonbaneTalisman = 32077030,

        [Annotation(Name = "[Caelid - Gael Tunnel] Large Glintstone Scrap 32077060")]
        CaelidGaelTunnelLargeGlintstoneScrap = 32077060,

        [Annotation(Name = "[Caelid - Gael Tunnel] Grace Mimic 32077070")]
        CaelidGaelTunnelGraceMimic = 32077070,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] Rot Grease 32087000")]
        CaelidSelliaCrystalTunnelRotGrease = 32087000,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] Golden Rune [5] 32087020")]
        CaelidSelliaCrystalTunnelGoldenRune5 = 32087020,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] Glintstone Scrap 32087030")]
        CaelidSelliaCrystalTunnelGlintstoneScrap = 32087030,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] Rune Arc 32087050")]
        CaelidSelliaCrystalTunnelRuneArc = 32087050,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] Cuckoo Glintstone 32087060")]
        CaelidSelliaCrystalTunnelCuckooGlintstone = 32087060,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] Somber Smithing Stone [4] 32087070")]
        CaelidSelliaCrystalTunnelSomberSmithingStone4 = 32087070,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] Golden Rune [4] 32087100")]
        CaelidSelliaCrystalTunnelGoldenRune4 = 32087100,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] Dragonwound Grease 32087110")]
        CaelidSelliaCrystalTunnelDragonwoundGrease = 32087110,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] Faithful's Canvas Talisman 32087120")]
        CaelidSelliaCrystalTunnelFaithfulsCanvasTalisman = 32087120,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] Gravity Stone Fan 32087900")]
        CaelidSelliaCrystalTunnelGravityStoneFan = 32087900,

        [Annotation(Name = "[Caelid - Sellia Crystal Tunnel] [Sorcery] Rock Blaster 32087910")]
        CaelidSelliaCrystalTunnelSorceryRockBlaster = 32087910,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Freezing Grease 32117000")]
        ConsecratedSnowfieldYeloughAnixTunnelFreezingGrease = 32117000,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Golden Rune [10] 32117020")]
        ConsecratedSnowfieldYeloughAnixTunnelGoldenRune10 = 32117020,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Ancient Dragon Smithing Stone 32117030")]
        ConsecratedSnowfieldYeloughAnixTunnelAncientDragonSmithingStone = 32117030,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Rune Arc 32117040")]
        ConsecratedSnowfieldYeloughAnixTunnelRuneArc = 32117040,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Explosive Stone Clump 32117060")]
        ConsecratedSnowfieldYeloughAnixTunnelExplosiveStoneClump = 32117060,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Tunnel] Hero's Rune [5] 32117080")]
        ConsecratedSnowfieldYeloughAnixTunnelHerosRune5 = 32117080,

        [Annotation(Name = "[Stormhill - Divine Tower of Limgrave] Warming Stone 34107000")]
        StormhillDivineTowerOfLimgraveWarmingStone = 34107000,

        [Annotation(Name = "[Stormhill - Divine Tower of Limgrave] Soft Cotton 34107010")]
        StormhillDivineTowerOfLimgraveSoftCotton = 34107010,

        [Annotation(Name = "[Stormhill - Divine Tower of Limgrave] Stormhawk Feather 34107070")]
        StormhillDivineTowerOfLimgraveStormhawkFeather = 34107070,

        [Annotation(Name = "[Stormhill - Divine Tower of Limgrave] Silver-Pickled Fowl Foot 34107080")]
        StormhillDivineTowerOfLimgraveSilverPickledFowlFoot = 34107080,

        [Annotation(Name = "[Stormhill - Divine Tower of Limgrave] Golden Rune [2] 34107090")]
        StormhillDivineTowerOfLimgraveGoldenRune2 = 34107090,

        [Annotation(Name = "[Stormhill - Divine Tower of Limgrave] Boltdrake Talisman 34107100")]
        StormhillDivineTowerOfLimgraveBoltdrakeTalisman = 34107100,

        [Annotation(Name = "[Stormhill - Divine Tower of Limgrave] Ash-of-War Scarab 34107110")]
        StormhillDivineTowerOfLimgraveAshofWarScarab = 34107110,

        [Annotation(Name = "[Stormhill - Divine Tower of Limgrave] Godrick's Great Rune 191")]
        StormhillDivineTowerOfLimgraveGodricksGreatRune = 191,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Golden Rune [3] 34117010")]
        LiurniaDivineTowerOfLiurniaGoldenRune3 = 34117010,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Golden Rune [4] 34117060")]
        LiurniaDivineTowerOfLiurniaGoldenRune4 = 34117060,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Cerulean Seed Talisman 34117080")]
        LiurniaDivineTowerOfLiurniaCeruleanSeedTalisman = 34117080,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Mask of Confidence 34117100")]
        LiurniaDivineTowerOfLiurniaMaskOfConfidence = 34117100,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Holyproof Dried Liver 34117110")]
        LiurniaDivineTowerOfLiurniaHolyproofDriedLiver = 34117110,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Glintstone Firefly 34117120")]
        LiurniaDivineTowerOfLiurniaGlintstoneFirefly = 34117120,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Carian Glintstone Staff 34117200")]
        LiurniaDivineTowerOfLiurniaCarianGlintstoneStaff = 34117200,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Godskin Apostle Hood 34117400")]
        LiurniaDivineTowerOfLiurniaGodskinApostleHood = 34117400,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Godskin Apostle Robe 34117401")]
        LiurniaDivineTowerOfLiurniaGodskinApostleRobe = 34117401,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Godskin Apostle Bracelets 34117402")]
        LiurniaDivineTowerOfLiurniaGodskinApostleBracelets = 34117402,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Godskin Apostle Trousers 34117403")]
        LiurniaDivineTowerOfLiurniaGodskinApostleTrousers = 34117403,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] Cursemark of Death 34117500")]
        LiurniaDivineTowerOfLiurniaCursemarkOfDeath = 34117500,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] [Sorcery] Magic Downpour 34117700")]
        LiurniaDivineTowerOfLiurniaSorceryMagicDownpour = 34117700,

        [Annotation(Name = "[Liurnia - Divine Tower of Liurnia] [Sorcery] Lucidity 34117710")]
        LiurniaDivineTowerOfLiurniaSorceryLucidity = 34117710,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Golden Rune [5] 34127010")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune5 = 34127010,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Golden Rune [5] 34127020")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune5_ = 34127020,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] 34127030")]
        CapitalOutskirtsDivineTowerOfWestAltus = 34127030,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Hefty Beast Bone 34127040")]
        CapitalOutskirtsDivineTowerOfWestAltusHeftyBeastBone = 34127040,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Gold-Pickled Fowl Foot 34127050")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldPickledFowlFoot = 34127050,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Stonesword Key 34127060")]
        CapitalOutskirtsDivineTowerOfWestAltusStoneswordKey = 34127060,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Rune Arc 34127070")]
        CapitalOutskirtsDivineTowerOfWestAltusRuneArc = 34127070,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Golden Rune [1] 34127080")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune1 = 34127080,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Furlcalling Finger Remedy 34127090")]
        CapitalOutskirtsDivineTowerOfWestAltusFurlcallingFingerRemedy = 34127090,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Old Fang 34127100")]
        CapitalOutskirtsDivineTowerOfWestAltusOldFang = 34127100,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Grace Mimic 34127110")]
        CapitalOutskirtsDivineTowerOfWestAltusGraceMimic = 34127110,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Large Glintstone Scrap 34127120")]
        CapitalOutskirtsDivineTowerOfWestAltusLargeGlintstoneScrap = 34127120,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Smithing Stone [6] 34127130")]
        CapitalOutskirtsDivineTowerOfWestAltusSmithingStone6 = 34127130,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] 34127140")]
        CapitalOutskirtsDivineTowerOfWestAltus_ = 34127140,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Lightning Grease 34127150")]
        CapitalOutskirtsDivineTowerOfWestAltusLightningGrease = 34127150,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Golden Rune [9] 34127160")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune9 = 34127160,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Rykard's Great Rune 194")]
        CapitalOutskirtsDivineTowerOfWestAltusRykardsGreatRune = 194,

        [Annotation(Name = "[Capital Outskirts - Divine Tower of West Altus] Smithing-Stone Miner's Bell Bearing [2] 34127900")]
        CapitalOutskirtsDivineTowerOfWestAltusSmithingStoneMinersBellBearing2 = 34127900,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid] Stonesword Key 34137000")]
        GreyollsDragonbarrowDivineTowerOfCaelidStoneswordKey = 34137000,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid] Rune Arc 34137010")]
        GreyollsDragonbarrowDivineTowerOfCaelidRuneArc = 34137010,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid] Golden Rune [12] 34137020")]
        GreyollsDragonbarrowDivineTowerOfCaelidGoldenRune12 = 34137020,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid] Radahn's Great Rune 192")]
        GreyollsDragonbarrowDivineTowerOfCaelidRadahnsGreatRune = 192,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid] Godslayer's Greatsword 34137900")]
        GreyollsDragonbarrowDivineTowerOfCaelidGodslayersGreatsword = 34137900,

        [Annotation(Name = "[Forbidden Lands - Divine Tower of East Altus] Invigorating White Cured Meat 34147000")]
        ForbiddenLandsDivineTowerOfEastAltusInvigoratingWhiteCuredMeat = 34147000,

        [Annotation(Name = "[Forbidden Lands - Divine Tower of East Altus] Official's Attire 34147010")]
        ForbiddenLandsDivineTowerOfEastAltusOfficialsAttire = 34147010,

        [Annotation(Name = "[Forbidden Lands - Divine Tower of East Altus] Flamedrake Talisman +1 34147020")]
        ForbiddenLandsDivineTowerOfEastAltusFlamedrakeTalisman1 = 34147020,

        [Annotation(Name = "[Forbidden Lands - Divine Tower of East Altus] Morgott's Great Rune 193")]
        ForbiddenLandsDivineTowerOfEastAltusMorgottsGreatRune = 193,

        [Annotation(Name = "[Forbidden Lands - Divine Tower of East Altus] Mohg's Great Rune 195")]
        ForbiddenLandsDivineTowerOfEastAltusMohgsGreatRune = 195,

        [Annotation(Name = "[Forbidden Lands - Divine Tower of East Altus] Somber Smithing Stone [6] 34147720")]
        ForbiddenLandsDivineTowerOfEastAltusSomberSmithingStone6 = 34147720,

        [Annotation(Name = "[Forbidden Lands - Divine Tower of East Altus] Golden Rune [9] 34147800")]
        ForbiddenLandsDivineTowerOfEastAltusGoldenRune9 = 34147800,

        [Annotation(Name = "[Forbidden Lands - Divine Tower of East Altus] Blade of Calling 34147810")]
        ForbiddenLandsDivineTowerOfEastAltusBladeOfCalling = 34147810,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Isolated Divine Tower] Malenia's Great Rune 196")]
        GreyollsDragonbarrowIsolatedDivineTowerMaleniasGreatRune = 196,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Poisonbone Dart 35007000")]
        SubterraneanShunningGroundsPoisonboneDart = 35007000,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Glass Shard 35007010")]
        SubterraneanShunningGroundsGlassShard = 35007010,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [1] 35007020")]
        SubterraneanShunningGroundsGoldenRune1 = 35007020,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Crimson Amber Medallion +2 35007030")]
        SubterraneanShunningGroundsCrimsonAmberMedallion2 = 35007030,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [11] 35007040")]
        SubterraneanShunningGroundsGoldenRune11 = 35007040,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Bloodsoaked Manchettes 35007050")]
        SubterraneanShunningGroundsBloodsoakedManchettes = 35007050,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Eye of Yelough 35007060")]
        SubterraneanShunningGroundsEyeOfYelough = 35007060,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Note: Miquella's Needle 69740")]
        SubterraneanShunningGroundsNoteMiquellasNeedle = 69740,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Preserving Boluses 35007080")]
        SubterraneanShunningGroundsPreservingBoluses = 35007080,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Furlcalling Finger Remedy 35007090")]
        SubterraneanShunningGroundsFurlcallingFingerRemedy = 35007090,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [1] 35007100")]
        SubterraneanShunningGroundsGoldenRune1_ = 35007100,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [11] 35007110")]
        SubterraneanShunningGroundsGoldenRune11_ = 35007110,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Rune Arc 35007120")]
        SubterraneanShunningGroundsRuneArc = 35007120,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Lost Ashes of War 35007130")]
        SubterraneanShunningGroundsLostAshesOfWar = 35007130,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Glass Shard 35007150")]
        SubterraneanShunningGroundsGlassShard_ = 35007150,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Stonesword Key 35007160")]
        SubterraneanShunningGroundsStoneswordKey = 35007160,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Rainbow Stone Arrow (Fletched) 35007170")]
        SubterraneanShunningGroundsRainbowStoneArrowFletched = 35007170,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Grave Violet 35007180")]
        SubterraneanShunningGroundsGraveViolet = 35007180,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007190")]
        SubterraneanShunningGroundsSmithingStone7 = 35007190,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Fireproof Dried Liver 35007200")]
        SubterraneanShunningGroundsFireproofDriedLiver = 35007200,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Somber Smithing Stone [8] 35007210")]
        SubterraneanShunningGroundsSomberSmithingStone8 = 35007210,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007220")]
        SubterraneanShunningGroundsSmithingStone7_ = 35007220,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Grace Mimic 35007240")]
        SubterraneanShunningGroundsGraceMimic = 35007240,

        [Annotation(Name = "[Subterranean Shunning-Grounds] String 35007250")]
        SubterraneanShunningGroundsString = 35007250,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Fire Grease 35007260")]
        SubterraneanShunningGroundsFireGrease = 35007260,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Nomad Ashes 35007270")]
        SubterraneanShunningGroundsNomadAshes = 35007270,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Preserving Boluses 35007280")]
        SubterraneanShunningGroundsPreservingBoluses_ = 35007280,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Glass Shard 35007300")]
        SubterraneanShunningGroundsGlassShard__ = 35007300,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Mohg's Shackle 35007310")]
        SubterraneanShunningGroundsMohgsShackle = 35007310,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Dappled White Cured Meat 35007320")]
        SubterraneanShunningGroundsDappledWhiteCuredMeat = 35007320,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Glass Shard 35007330")]
        SubterraneanShunningGroundsGlassShard___ = 35007330,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Centipede 35007340")]
        SubterraneanShunningGroundsGoldenCentipede = 35007340,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Poisoned Stone 35007350")]
        SubterraneanShunningGroundsPoisonedStone = 35007350,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Freezing Grease 35007370")]
        SubterraneanShunningGroundsFreezingGrease = 35007370,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Serpent Arrow 35007380")]
        SubterraneanShunningGroundsSerpentArrow = 35007380,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Fire Grease 35007390")]
        SubterraneanShunningGroundsFireGrease_ = 35007390,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Somber Smithing Stone [6] 35007400")]
        SubterraneanShunningGroundsSomberSmithingStone6 = 35007400,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007410")]
        SubterraneanShunningGroundsSmithingStone7__ = 35007410,

        [Annotation(Name = "[Subterranean Shunning-Grounds] [Incantation] Shadow Bait 35007420")]
        SubterraneanShunningGroundsIncantationShadowBait = 35007420,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [10] 35007430")]
        SubterraneanShunningGroundsGoldenRune10 = 35007430,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Somber Smithing Stone [7] 35007450")]
        SubterraneanShunningGroundsSomberSmithingStone7 = 35007450,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007460")]
        SubterraneanShunningGroundsSmithingStone7___ = 35007460,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Glass Shard 35007470")]
        SubterraneanShunningGroundsGlassShard____ = 35007470,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007480")]
        SubterraneanShunningGroundsSmithingStone7____ = 35007480,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [9] 35007500")]
        SubterraneanShunningGroundsGoldenRune9 = 35007500,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [11] 35007510")]
        SubterraneanShunningGroundsGoldenRune11__ = 35007510,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Warming Stone 35007530")]
        SubterraneanShunningGroundsWarmingStone = 35007530,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Smithing Stone [8] 35007540")]
        SubterraneanShunningGroundsSmithingStone8 = 35007540,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Eye of Yelough 35007550")]
        SubterraneanShunningGroundsEyeOfYelough_ = 35007550,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [8] 35007560")]
        SubterraneanShunningGroundsGoldenRune8 = 35007560,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Smithing Stone [7] 35007570")]
        SubterraneanShunningGroundsSmithingStone7_____ = 35007570,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [1] 35007580")]
        SubterraneanShunningGroundsGoldenRune1__ = 35007580,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [11] 35007590")]
        SubterraneanShunningGroundsGoldenRune11___ = 35007590,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Smithing Stone [5] 35007600")]
        SubterraneanShunningGroundsSmithingStone5 = 35007600,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Ritual Pot 66490")]
        SubterraneanShunningGroundsRitualPot = 66490,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Smithing Stone [6] 35007630")]
        SubterraneanShunningGroundsSmithingStone6 = 35007630,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Grace Mimic 35007650")]
        SubterraneanShunningGroundsGraceMimic_ = 35007650,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Golden Rune [11] 35007660")]
        SubterraneanShunningGroundsGoldenRune11____ = 35007660,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Hefty Beast Bone 35007670")]
        SubterraneanShunningGroundsHeftyBeastBone = 35007670,

        [Annotation(Name = "[Subterranean Shunning-Grounds] [Incantation] Inescapable Frenzy 35007680")]
        SubterraneanShunningGroundsIncantationInescapableFrenzy = 35007680,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Erdtree's Favor +1 35007700")]
        SubterraneanShunningGroundsErdtreesFavor1 = 35007700,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Nomadic Merchant's Chapeau 35007710")]
        SubterraneanShunningGroundsNomadicMerchantsChapeau = 35007710,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Fingerprint Stone Shield 35007720")]
        SubterraneanShunningGroundsFingerprintStoneShield = 35007720,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Warming Stone 35007730")]
        SubterraneanShunningGroundsWarmingStone_ = 35007730,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Poisoned Stone 35007740")]
        SubterraneanShunningGroundsPoisonedStone_ = 35007740,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Smithing Stone [1] 35007750")]
        SubterraneanShunningGroundsSmithingStone1 = 35007750,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Fire Longsword 35007770")]
        SubterraneanShunningGroundsFireLongsword = 35007770,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Rune Arc 35007780")]
        SubterraneanShunningGroundsRuneArc_ = 35007780,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Frenzied's Cookbook [2] 68410")]
        SubterraneanShunningGroundsFrenziedsCookbook2 = 68410,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Ghost Glovewort [6] 35007900")]
        SubterraneanShunningGroundsGhostGlovewort6 = 35007900,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Root Resin 35007910")]
        SubterraneanShunningGroundsRootResin = 35007910,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Mushroom 35007920")]
        SubterraneanShunningGroundsMushroom = 35007920,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Sacramental Bud 35007930")]
        SubterraneanShunningGroundsSacramentalBud = 35007930,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Crucible Scale Talisman 35007940")]
        SubterraneanShunningGroundsCrucibleScaleTalisman = 35007940,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Haligdrake Talisman +1 35007950")]
        SubterraneanShunningGroundsHaligdrakeTalisman1 = 35007950,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Rune Arc 35007960")]
        SubterraneanShunningGroundsRuneArc__ = 35007960,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Somber Smithing Stone [6] 35007970")]
        SubterraneanShunningGroundsSomberSmithingStone6_ = 35007970,

        [Annotation(Name = "[Subterranean Shunning-Grounds] Somber Smithing Stone [7] 35007980")]
        SubterraneanShunningGroundsSomberSmithingStone7_ = 35007980,

        [Annotation(Name = "[Ruin-Strewn Precipice] Golden Rune [1] 39207000")]
        RuinStrewnPrecipiceGoldenRune1 = 39207000,

        [Annotation(Name = "[Ruin-Strewn Precipice] Smithing Stone [5] 39207010")]
        RuinStrewnPrecipiceSmithingStone5 = 39207010,

        [Annotation(Name = "[Ruin-Strewn Precipice] Rune Arc 39207020")]
        RuinStrewnPrecipiceRuneArc = 39207020,

        [Annotation(Name = "[Ruin-Strewn Precipice] Somber Smithing Stone [3] 39207030")]
        RuinStrewnPrecipiceSomberSmithingStone3 = 39207030,

        [Annotation(Name = "[Ruin-Strewn Precipice] Serpent-God's Curved Sword 39207040")]
        RuinStrewnPrecipiceSerpentGodsCurvedSword = 39207040,

        [Annotation(Name = "[Ruin-Strewn Precipice] Smithing Stone [4] 39207050")]
        RuinStrewnPrecipiceSmithingStone4 = 39207050,

        [Annotation(Name = "[Ruin-Strewn Precipice] Golden Rune [4] 39207060")]
        RuinStrewnPrecipiceGoldenRune4 = 39207060,

        [Annotation(Name = "[Ruin-Strewn Precipice] Golden Rune [5] 39207070")]
        RuinStrewnPrecipiceGoldenRune5 = 39207070,

        [Annotation(Name = "[Ruin-Strewn Precipice] Rune Arc 39207080")]
        RuinStrewnPrecipiceRuneArc_ = 39207080,

        [Annotation(Name = "[Ruin-Strewn Precipice] Soft Cotton 39207090")]
        RuinStrewnPrecipiceSoftCotton = 39207090,

        [Annotation(Name = "[Ruin-Strewn Precipice] Golden Rune [5] 39207100")]
        RuinStrewnPrecipiceGoldenRune5_ = 39207100,

        [Annotation(Name = "[Ruin-Strewn Precipice] Golden Rune [5] 39207110")]
        RuinStrewnPrecipiceGoldenRune5__ = 39207110,

        [Annotation(Name = "[Ruin-Strewn Precipice] Lost Ashes of War 39207120")]
        RuinStrewnPrecipiceLostAshesOfWar = 39207120,

        [Annotation(Name = "[Ruin-Strewn Precipice] Smithing Stone [3] 39207130")]
        RuinStrewnPrecipiceSmithingStone3 = 39207130,

        [Annotation(Name = "[Ruin-Strewn Precipice] Smithing Stone [3] 39207140")]
        RuinStrewnPrecipiceSmithingStone3_ = 39207140,

        [Annotation(Name = "[Ruin-Strewn Precipice] Smithing Stone [3] 39207150")]
        RuinStrewnPrecipiceSmithingStone3__ = 39207150,

        [Annotation(Name = "[Ruin-Strewn Precipice] Lightning Grease 39207160")]
        RuinStrewnPrecipiceLightningGrease = 39207160,

        [Annotation(Name = "[Ruin-Strewn Precipice] Sacred Tear 39207170")]
        RuinStrewnPrecipiceSacredTear = 39207170,

        [Annotation(Name = "[Ruin-Strewn Precipice] Smithing Stone [1] 39207200")]
        RuinStrewnPrecipiceSmithingStone1 = 39207200,

        [Annotation(Name = "[Ruin-Strewn Precipice] Bull-Goat Helm 39207500")]
        RuinStrewnPrecipiceBullGoatHelm = 39207500,

        [Annotation(Name = "Golden Rune [1] 99017000")]
        GoldenRune1_____________________ = 99017000,

        [Annotation(Name = "Cracked Pot 99997020")]
        CrackedPot = 99997020,

        [Annotation(Name = "Perfume Bottle 99997030")]
        PerfumeBottle = 99997030,

        [Annotation(Name = "Veteran's Helm 59930000")]
        VeteransHelm = 59930000,

        [Annotation(Name = "Soft Cotton 59931000")]
        SoftCotton = 59931000,

        [Annotation(Name = "[Limgrave - Mistwood] Spiked Cracked Tear 65140")]
        LimgraveMistwoodSpikedCrackedTear = 65140,

        [Annotation(Name = "[Limgrave - Mistwood] Greenspill Crystal Tear 65010")]
        LimgraveMistwoodGreenspillCrystalTear = 65010,

        [Annotation(Name = "[Limgrave - Third Church of Marika] Flask of Wondrous Physick 60020")]
        LimgraveThirdChurchOfMarikaFlaskOfWondrousPhysick = 60020,

        [Annotation(Name = "[Limgrave - Third Church of Marika] Crimson Crystal Tear 65020")]
        LimgraveThirdChurchOfMarikaCrimsonCrystalTear = 65020,

        [Annotation(Name = "[Limgrave - Third Church of Marika] Sacred Tear 1046387100")]
        LimgraveThirdChurchOfMarikaSacredTear = 1046387100,

        [Annotation(Name = "[Weeping Peninsula - Fourth Church of Marika] Sacred Tear 1041337200")]
        WeepingPeninsulaFourthChurchOfMarikaSacredTear = 1041337200,

        [Annotation(Name = "[Limgrave - Seaside Ruins] Sacred Tear 1043357100")]
        LimgraveSeasideRuinsSacredTear = 1043357100,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] Sacred Tear 1044337100")]
        WeepingPeninsulaAilingVillageOutskirtsSacredTear = 1044337100,

        [Annotation(Name = "[Stormhill - Stormhill Shack] Golden Seed 1041387100")]
        StormhillStormhillShackGoldenSeed = 1041387100,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Golden Seed 1044327020")]
        WeepingPeninsulaCastleMorneApproachGoldenSeed = 1044327020,

        [Annotation(Name = "[Limgrave - Fort Haight] Golden Seed 1046367100")]
        LimgraveFortHaightGoldenSeed = 1046367100,

        [Annotation(Name = "[Limgrave - Agheel Lake North] Ash of War: Repeating Thrust 1043377400")]
        LimgraveAgheelLakeNorthAshOfWarRepeatingThrust = 1043377400,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Blue-Feathered Branchsword 1042387400")]
        StormhillWarmastersShackBlueFeatheredBranchsword = 1042387400,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Bone Peddler's Bell Bearing 1042387410")]
        StormhillWarmastersShackBonePeddlersBellBearing = 1042387410,

        [Annotation(Name = "[Stormhill - Forested West Cliffside] Smithing Stone [1] 1040387000")]
        StormhillForestedWestCliffsideSmithingStone1 = 1040387000,

        [Annotation(Name = "[Stormhill - Forested West Cliffside] Nomadic Warrior's Cookbook [7] 67050")]
        StormhillForestedWestCliffsideNomadicWarriorsCookbook7 = 67050,

        [Annotation(Name = "[Limgrave - Church of Dragon Communion] Great Dragonfly Head 1041357000")]
        LimgraveChurchOfDragonCommunionGreatDragonflyHead = 1041357000,

        [Annotation(Name = "[Limgrave - Church of Dragon Communion] Smithing Stone [2] 1041357010")]
        LimgraveChurchOfDragonCommunionSmithingStone2 = 1041357010,

        [Annotation(Name = "[Limgrave - Church of Dragon Communion] Exalted Flesh 1041357020")]
        LimgraveChurchOfDragonCommunionExaltedFlesh = 1041357020,

        [Annotation(Name = "[Limgrave - Coastal Cave Entrance] Land Octopus Ovary 1041367000")]
        LimgraveCoastalCaveEntranceLandOctopusOvary = 1041367000,

        [Annotation(Name = "[Limgrave - Stormfoot Catacombs Entrance] Strip of White Flesh 1041377000")]
        LimgraveStormfootCatacombsEntranceStripOfWhiteFlesh = 1041377000,

        [Annotation(Name = "[Limgrave - Stormfoot Catacombs Entrance] Starlight Shards 1041377020")]
        LimgraveStormfootCatacombsEntranceStarlightShards = 1041377020,

        [Annotation(Name = "[Stormhill - Stormhill Shack] Magic Grease 1041387010")]
        StormhillStormhillShackMagicGrease = 1041387010,

        [Annotation(Name = "[Stormhill - Stormhill Shack] Smithing Stone [1] 1041387030")]
        StormhillStormhillShackSmithingStone1 = 1041387030,

        [Annotation(Name = "[Stormhill - Stormhill Shack] Stonesword Key 1041387040")]
        StormhillStormhillShackStoneswordKey = 1041387040,

        [Annotation(Name = "[Stormhill - Stormhill Shack] Godrick Soldier Ashes 1041387050")]
        StormhillStormhillShackGodrickSoldierAshes = 1041387050,

        [Annotation(Name = "[Stormhill - Stormhill Shack] Bloodrose 1041387200")]
        StormhillStormhillShackBloodrose = 1041387200,

        [Annotation(Name = "[Stormhill - North of Stormhill Shack] Lump of Flesh 1041397000")]
        StormhillNorthOfStormhillShackLumpOfFlesh = 1041397000,

        [Annotation(Name = "[Stormhill - Northwest Cliffside] Duelist's Furled Finger 60240")]
        StormhillNorthwestCliffsideDuelistsFurledFinger = 60240,

        [Annotation(Name = "[Stormhill - Northwest Cliffside] Small Red Effigy 60250")]
        StormhillNorthwestCliffsideSmallRedEffigy = 60250,

        [Annotation(Name = "[Limgrave - South of Stranded Graveyard] Gold-Pickled Fowl Foot 1042357010")]
        LimgraveSouthOfStrandedGraveyardGoldPickledFowlFoot = 1042357010,

        [Annotation(Name = "[Limgrave - South of Stranded Graveyard] Lump of Flesh 1042357000")]
        LimgraveSouthOfStrandedGraveyardLumpOfFlesh = 1042357000,

        [Annotation(Name = "[Limgrave - Church of Elleh] Silver-Pickled Fowl Foot 1042367010")]
        LimgraveChurchOfEllehSilverPickledFowlFoot = 1042367010,

        [Annotation(Name = "[Limgrave - Church of Elleh] Golden Rune [2] 1042367030")]
        LimgraveChurchOfEllehGoldenRune2 = 1042367030,

        [Annotation(Name = "[Limgrave - Church of Elleh] Golden Rune [1] 1042367040")]
        LimgraveChurchOfEllehGoldenRune1 = 1042367040,

        [Annotation(Name = "[Limgrave - Church of Elleh] Smithing Stone [1] 1042367050")]
        LimgraveChurchOfEllehSmithingStone1 = 1042367050,

        [Annotation(Name = "[Limgrave - Church of Elleh] Smithing Stone [1] 1042367060")]
        LimgraveChurchOfEllehSmithingStone1_ = 1042367060,

        [Annotation(Name = "[Limgrave - Gatefront] Ruin Fragment 1042377000")]
        LimgraveGatefrontRuinFragment = 1042377000,

        [Annotation(Name = "[Troll Carriage - Gatefront Ruins] Flail 1042377060")]
        TrollCarriageGatefrontRuinsFlail = 1042377060,

        [Annotation(Name = "[Troll Carriage - Gatefront Ruins] Lordsworn's Greatsword 1042377070")]
        TrollCarriageGatefrontRuinsLordswornsGreatsword = 1042377070,

        [Annotation(Name = "[Limgrave - Gatefront] Whetstone Knife 60130")]
        LimgraveGatefrontWhetstoneKnife = 60130,

        [Annotation(Name = "[Limgrave - Gatefront] Ash of War: Storm Stomp 1042377110")]
        LimgraveGatefrontAshOfWarStormStomp = 1042377110,

        [Annotation(Name = "[Limgrave - Gatefront] Kukri 1042377010")]
        LimgraveGatefrontKukri = 1042377010,

        [Annotation(Name = "[Limgrave - Gatefront] Arrow's Reach Talisman 1042377300")]
        LimgraveGatefrontArrowsReachTalisman = 1042377300,

        [Annotation(Name = "[Limgrave - Gatefront] Assassin's Crimson Dagger 1042377100")]
        LimgraveGatefrontAssassinsCrimsonDagger = 1042377100,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Beast Liver 1042387000")]
        StormhillWarmastersShackBeastLiver = 1042387000,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Golden Rune [1] 1042387010")]
        StormhillWarmastersShackGoldenRune1 = 1042387010,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Fire Arrow 1042387020")]
        StormhillWarmastersShackFireArrow = 1042387020,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Golden Rune [5] 1042387030")]
        StormhillWarmastersShackGoldenRune5 = 1042387030,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Golden Rune [1] 1042387040")]
        StormhillWarmastersShackGoldenRune1_ = 1042387040,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Golden Rune [3] 1042387050")]
        StormhillWarmastersShackGoldenRune3 = 1042387050,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Golden Rune [2] 1042387070")]
        StormhillWarmastersShackGoldenRune2 = 1042387070,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Golden Rune [1] 1042387080")]
        StormhillWarmastersShackGoldenRune1__ = 1042387080,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Golden Rune [2] 1042387090")]
        StormhillWarmastersShackGoldenRune2_ = 1042387090,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Golden Rune [1] 1042387100")]
        StormhillWarmastersShackGoldenRune1___ = 1042387100,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Golden Rune [1] 1042387110")]
        StormhillWarmastersShackGoldenRune1____ = 1042387110,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Golden Rune [2] 1042387120")]
        StormhillWarmastersShackGoldenRune2__ = 1042387120,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Lump of Flesh 1042387140")]
        StormhillWarmastersShackLumpOfFlesh = 1042387140,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Smithing Stone [1] 1042387600")]
        StormhillWarmastersShackSmithingStone1 = 1042387600,

        [Annotation(Name = "[Stormhill - Warmaster's Shack] Smoldering Butterfly 1042387200")]
        StormhillWarmastersShackSmolderingButterfly = 1042387200,

        [Annotation(Name = "[Stormhill - North of Warmaster's Shack] Strength-knot Crystal Tear 65210")]
        StormhillNorthOfWarmastersShackStrengthknotCrystalTear = 65210,

        [Annotation(Name = "[Stormhill - North of Warmaster's Shack] Lance 1042397010")]
        StormhillNorthOfWarmastersShackLance = 1042397010,

        [Annotation(Name = "[Stormhill - North of Warmaster's Shack] Beast Crest Heater Shield 1042397900")]
        StormhillNorthOfWarmastersShackBeastCrestHeaterShield = 1042397900,

        [Annotation(Name = "[Stormhill - North of Warmaster's Shack] Scaled Helm 1042397500")]
        StormhillNorthOfWarmastersShackScaledHelm = 1042397500,

        [Annotation(Name = "[Stormhill - North of Warmaster's Shack] Hammer Talisman 1042397700")]
        StormhillNorthOfWarmastersShackHammerTalisman = 1042397700,

        [Annotation(Name = "[Limgrave - Seaside Ruins] Crab Eggs 1043357000")]
        LimgraveSeasideRuinsCrabEggs = 1043357000,

        [Annotation(Name = "[Limgrave - Seaside Ruins] Golden Rune [1] 1043357010")]
        LimgraveSeasideRuinsGoldenRune1 = 1043357010,

        [Annotation(Name = "[Limgrave - Seaside Ruins] Slumbering Egg 1043357030")]
        LimgraveSeasideRuinsSlumberingEgg = 1043357030,

        [Annotation(Name = "[Limgrave - Dragon-Burnt Ruins] Stonesword Key 1043367010")]
        LimgraveDragonBurntRuinsStoneswordKey = 1043367010,

        [Annotation(Name = "[Limgrave - Dragon-Burnt Ruins] Golden Rune [2] 1043367020")]
        LimgraveDragonBurntRuinsGoldenRune2 = 1043367020,

        [Annotation(Name = "[Limgrave - Dragon-Burnt Ruins] Crab Eggs 1043367040")]
        LimgraveDragonBurntRuinsCrabEggs = 1043367040,

        [Annotation(Name = "[Limgrave - Dragon-Burnt Ruins] Twinblade 1043367110")]
        LimgraveDragonBurntRuinsTwinblade = 1043367110,

        [Annotation(Name = "[Limgrave - Dragon-Burnt Ruins] Arteria Leaf 1043367070")]
        LimgraveDragonBurntRuinsArteriaLeaf = 1043367070,

        [Annotation(Name = "[Limgrave - Agheel Lake North] Smithing Stone [1] 1043377000")]
        LimgraveAgheelLakeNorthSmithingStone1 = 1043377000,

        [Annotation(Name = "[Limgrave - Agheel Lake North] Fire Grease 1043377010")]
        LimgraveAgheelLakeNorthFireGrease = 1043377010,

        [Annotation(Name = "[Limgrave - Agheel Lake North] Arteria Leaf 1043377020")]
        LimgraveAgheelLakeNorthArteriaLeaf = 1043377020,

        [Annotation(Name = "[Limgrave - Gatefront] Map: Limgrave, West 62010")]
        LimgraveGatefrontMapLimgraveWest = 62010,

        [Annotation(Name = "[Limgrave - Gatefront] Reduvia 1042377700")]
        LimgraveGatefrontReduvia = 1042377700,

        [Annotation(Name = "[Limgrave - Murkwater Coast] Armorer's Cookbook [1] 67200")]
        LimgraveMurkwaterCoastArmorersCookbook1 = 67200,

        [Annotation(Name = "[Limgrave - Murkwater Coast] Smithing Stone [1] 1043387010")]
        LimgraveMurkwaterCoastSmithingStone1 = 1043387010,

        [Annotation(Name = "[Limgrave - Murkwater Coast] Golden Rune [2] 1043387020")]
        LimgraveMurkwaterCoastGoldenRune2 = 1043387020,

        [Annotation(Name = "[Stormhill - Saintsbridge] Exalted Flesh 1043397010")]
        StormhillSaintsbridgeExaltedFlesh = 1043397010,

        [Annotation(Name = "[Stormhill - Saintsbridge] Smithing Stone [1] 1043397020")]
        StormhillSaintsbridgeSmithingStone1 = 1043397020,

        [Annotation(Name = "[Stormhill - Saintsbridge] Golden Rune [3] 1043397200")]
        StormhillSaintsbridgeGoldenRune3 = 1043397200,

        [Annotation(Name = "[Stormhill - Saintsbridge] Turtle Neck Meat 1043397030")]
        StormhillSaintsbridgeTurtleNeckMeat = 1043397030,

        [Annotation(Name = "[Stormhill - Godrick Knight] Golden Vow 1043397500")]
        StormhillGodrickKnightGoldenVow = 1043397500,

        [Annotation(Name = "[Stormhill - Northeast Cliffside] Soporific Grease 1043407000")]
        StormhillNortheastCliffsideSoporificGrease = 1043407000,

        [Annotation(Name = "[Stormhill - Northeast Cliffside] Lance Talisman 1043407010")]
        StormhillNortheastCliffsideLanceTalisman = 1043407010,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Map: Weeping Peninsula 62011")]
        WeepingPeninsulaCastleMorneApproachMapWeepingPeninsula = 62011,

        [Annotation(Name = "[Weeping Peninsula - Bridge of Sacrifice] Stonesword Key 1044347000")]
        WeepingPeninsulaBridgeOfSacrificeStoneswordKey = 1044347000,

        [Annotation(Name = "[Weeping Peninsula - Bridge of Sacrifice] Smithing Stone [1] 1044347010")]
        WeepingPeninsulaBridgeOfSacrificeSmithingStone1 = 1044347010,

        [Annotation(Name = "[Weeping Peninsula - Bridge of Sacrifice] Ruin Fragment 1044347050")]
        WeepingPeninsulaBridgeOfSacrificeRuinFragment = 1044347050,

        [Annotation(Name = "[Weeping Peninsula - Bridge of Sacrifice] Large Club 1044347080")]
        WeepingPeninsulaBridgeOfSacrificeLargeClub = 1044347080,

        [Annotation(Name = "[Limgrave - Agheel Lake South] Golden Rune [2] 1044357000")]
        LimgraveAgheelLakeSouthGoldenRune2 = 1044357000,

        [Annotation(Name = "[Limgrave - Agheel Lake South] Royal House Scroll 1044357010")]
        LimgraveAgheelLakeSouthRoyalHouseScroll = 1044357010,

        [Annotation(Name = "[Limgrave - Agheel Lake South] Golden Rune [1] 1044357020")]
        LimgraveAgheelLakeSouthGoldenRune1 = 1044357020,

        [Annotation(Name = "[Limgrave - Agheel Lake South] Sliver of Meat 1044357030")]
        LimgraveAgheelLakeSouthSliverOfMeat = 1044357030,

        [Annotation(Name = "Flame Sling 1044357050")]
        FlameSling = 1044357050,

        [Annotation(Name = "[Limgrave - Agheel Lake South] Crab Eggs 1044357040")]
        LimgraveAgheelLakeSouthCrabEggs = 1044357040,

        [Annotation(Name = "[Limgrave - Agheel Lake South] Golden Rune [1] 1044357060")]
        LimgraveAgheelLakeSouthGoldenRune1_ = 1044357060,

        [Annotation(Name = "[Limgrave - Agheel Lake South] Starlight Shards 1044357070")]
        LimgraveAgheelLakeSouthStarlightShards = 1044357070,

        [Annotation(Name = "[Limgrave - Agheel Lake South] Larval Tear 1044357100")]
        LimgraveAgheelLakeSouthLarvalTear = 1044357100,

        [Annotation(Name = "[Limgrave - Agheel Lake South] Great epee 1044357900")]
        LimgraveAgheelLakeSouthGreatepee = 1044357900,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Glowstone 1044367000")]
        LimgraveWaypointRuinsGlowstone = 1044367000,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Golden Rune [1] 1044367010")]
        LimgraveWaypointRuinsGoldenRune1 = 1044367010,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Immunizing Cured Meat 1044367020")]
        LimgraveWaypointRuinsImmunizingCuredMeat = 1044367020,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Trina's Lily 1044367100")]
        LimgraveWaypointRuinsTrinasLily = 1044367100,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Smoldering Butterfly 1044367030")]
        LimgraveWaypointRuinsSmolderingButterfly = 1044367030,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Somber Smithing Stone [1] 1044367040")]
        LimgraveWaypointRuinsSomberSmithingStone1 = 1044367040,

        [Annotation(Name = "[Troll Carriage - Waypoint Ruins] Greataxe 1044367200")]
        TrollCarriageWaypointRuinsGreataxe = 1044367200,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Golden Rune [1] 1044367300")]
        LimgraveWaypointRuinsGoldenRune1_ = 1044367300,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Golden Rune [1] 1044367310")]
        LimgraveWaypointRuinsGoldenRune1__ = 1044367310,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Golden Rune [2] 1044367320")]
        LimgraveWaypointRuinsGoldenRune2 = 1044367320,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Golden Rune [1] 1044367330")]
        LimgraveWaypointRuinsGoldenRune1___ = 1044367330,

        [Annotation(Name = "[Limgrave - Waypoint Ruins] Golden Rune [3] 1044367340")]
        LimgraveWaypointRuinsGoldenRune3 = 1044367340,

        [Annotation(Name = "[Limgrave - Mistwood Outskirts] Golden Rune [1] 1044377010")]
        LimgraveMistwoodOutskirtsGoldenRune1 = 1044377010,

        [Annotation(Name = "[Limgrave - Mistwood Outskirts] Gold-Pickled Fowl Foot 1044377200")]
        LimgraveMistwoodOutskirtsGoldPickledFowlFoot = 1044377200,

        [Annotation(Name = "[Limgrave - Mistwood Outskirts] Sacrificial Twig 1044377020")]
        LimgraveMistwoodOutskirtsSacrificialTwig = 1044377020,

        [Annotation(Name = "[Limgrave - Artist's Shack] Smithing Stone [1] 1044387010")]
        LimgraveArtistsShackSmithingStone1 = 1044387010,

        [Annotation(Name = "[Limgrave - Artist's Shack] Poisonbloom 1044387040")]
        LimgraveArtistsShackPoisonbloom = 1044387040,

        [Annotation(Name = "[Limgrave - Artist's Shack] Golden Rune [1] 1044387100")]
        LimgraveArtistsShackGoldenRune1 = 1044387100,

        [Annotation(Name = "[Leyndell - Minor Erdtree] 1045337400")]
        LeyndellMinorErdtree = 1045337400,

        [Annotation(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [1] 1045357000")]
        LimgraveSouthwestOfFortHaightGoldenRune1 = 1045357000,

        [Annotation(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [1] 1045357020")]
        LimgraveSouthwestOfFortHaightGoldenRune1_ = 1045357020,

        [Annotation(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [4] 1045357030")]
        LimgraveSouthwestOfFortHaightGoldenRune4 = 1045357030,

        [Annotation(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [3] 1045357040")]
        LimgraveSouthwestOfFortHaightGoldenRune3 = 1045357040,

        [Annotation(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [2] 1045357050")]
        LimgraveSouthwestOfFortHaightGoldenRune2 = 1045357050,

        [Annotation(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [1] 1045357060")]
        LimgraveSouthwestOfFortHaightGoldenRune1__ = 1045357060,

        [Annotation(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [2] 1045357070")]
        LimgraveSouthwestOfFortHaightGoldenRune2_ = 1045357070,

        [Annotation(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [1] 1045357080")]
        LimgraveSouthwestOfFortHaightGoldenRune1___ = 1045357080,

        [Annotation(Name = "[Limgrave - Southwest of Fort Haight] Golden Rune [1] 1045357090")]
        LimgraveSouthwestOfFortHaightGoldenRune1____ = 1045357090,

        [Annotation(Name = "[Limgrave - Mistwood] Golden Rune [2] 1045377000")]
        LimgraveMistwoodGoldenRune2 = 1045377000,

        [Annotation(Name = "[Limgrave - Mistwood] Smithing Stone [2] 1045377010")]
        LimgraveMistwoodSmithingStone2 = 1045377010,

        [Annotation(Name = "[Limgrave - Mistwood] Map: Limgrave, East 62012")]
        LimgraveMistwoodMapLimgraveEast = 62012,

        [Annotation(Name = "[Limgrave - Mistwood] Nomadic Warrior's Cookbook [4] 67800")]
        LimgraveMistwoodNomadicWarriorsCookbook4 = 67800,

        [Annotation(Name = "[Limgrave - Mistwood] Axe Talisman 1045377100")]
        LimgraveMistwoodAxeTalisman = 1045377100,

        [Annotation(Name = "[Limgrave - Mistwood] Golden Rune [1] 1045377050")]
        LimgraveMistwoodGoldenRune1 = 1045377050,

        [Annotation(Name = "[Limgrave - Mistwood] Thin Beast Bones 1045377060")]
        LimgraveMistwoodThinBeastBones = 1045377060,

        [Annotation(Name = "[Limgrave - Mistwood] Gold-Tinged Excrement 1045377070")]
        LimgraveMistwoodGoldTingedExcrement = 1045377070,

        [Annotation(Name = "[Limgrave - Mistwood] Throwing Dagger 1045377080")]
        LimgraveMistwoodThrowingDagger = 1045377080,

        [Annotation(Name = "[Limgrave - Mistwood] Golden Rune [5] 1045377090")]
        LimgraveMistwoodGoldenRune5 = 1045377090,

        [Annotation(Name = "[Limgrave - South of Summonwater Village] Magic Grease 1045387000")]
        LimgraveSouthOfSummonwaterVillageMagicGrease = 1045387000,

        [Annotation(Name = "[Limgrave - South of Summonwater Village] Fevor's Cookbook [1] 68200")]
        LimgraveSouthOfSummonwaterVillageFevorsCookbook1 = 68200,

        [Annotation(Name = "[Limgrave - South of Summonwater Village] Golden Rune [1] 1045387020")]
        LimgraveSouthOfSummonwaterVillageGoldenRune1 = 1045387020,

        [Annotation(Name = "[Limgrave - South of Summonwater Village] Golden Rune [1] 1045387030")]
        LimgraveSouthOfSummonwaterVillageGoldenRune1_ = 1045387030,

        [Annotation(Name = "[Limgrave - South of Summonwater Village] Golden Rune [1] 1045387040")]
        LimgraveSouthOfSummonwaterVillageGoldenRune1__ = 1045387040,

        [Annotation(Name = "[Limgrave - South of Summonwater Village] Golden Rune [2] 1045387050")]
        LimgraveSouthOfSummonwaterVillageGoldenRune2 = 1045387050,

        [Annotation(Name = "[Limgrave - South of Summonwater Village] Golden Rune [4] 1045387060")]
        LimgraveSouthOfSummonwaterVillageGoldenRune4 = 1045387060,

        [Annotation(Name = "[Limgrave - South of Summonwater Village] Golden Rune [4] 1045387070")]
        LimgraveSouthOfSummonwaterVillageGoldenRune4_ = 1045387070,

        [Annotation(Name = "[Limgrave - South of Summonwater Village] Golden Rune [6] 1045387080")]
        LimgraveSouthOfSummonwaterVillageGoldenRune6 = 1045387080,

        [Annotation(Name = "[Limgrave - Summonwater Village] Golden Rune [4] 1045397000")]
        LimgraveSummonwaterVillageGoldenRune4 = 1045397000,

        [Annotation(Name = "[Limgrave - Summonwater Village] Mushroom 1045397020")]
        LimgraveSummonwaterVillageMushroom = 1045397020,

        [Annotation(Name = "[Limgrave - Summonwater Village] Smithing Stone [1] 1045397140")]
        LimgraveSummonwaterVillageSmithingStone1 = 1045397140,

        [Annotation(Name = "[Limgrave - Summonwater Village] Green Turtle Talisman 1045397120")]
        LimgraveSummonwaterVillageGreenTurtleTalisman = 1045397120,

        [Annotation(Name = "[Limgrave - Summonwater Village] Smithing Stone [2] 1045397040")]
        LimgraveSummonwaterVillageSmithingStone2 = 1045397040,

        [Annotation(Name = "[Limgrave - Summonwater Village] Golden Rune [1] 1045397050")]
        LimgraveSummonwaterVillageGoldenRune1 = 1045397050,

        [Annotation(Name = "[Limgrave - Summonwater Village] Golden Rune [1] 1045397060")]
        LimgraveSummonwaterVillageGoldenRune1_ = 1045397060,

        [Annotation(Name = "[Limgrave - Summonwater Village] Golden Rune [1] 1045397070")]
        LimgraveSummonwaterVillageGoldenRune1__ = 1045397070,

        [Annotation(Name = "[Limgrave - Summonwater Village] Golden Rune [1] 1045397080")]
        LimgraveSummonwaterVillageGoldenRune1___ = 1045397080,

        [Annotation(Name = "[Limgrave - Summonwater Village] Golden Rune [5] 1045397090")]
        LimgraveSummonwaterVillageGoldenRune5 = 1045397090,

        [Annotation(Name = "[Limgrave - Summonwater Village] Golden Rune [2] 1045397100")]
        LimgraveSummonwaterVillageGoldenRune2 = 1045397100,

        [Annotation(Name = "[Limgrave - Summonwater Village] Golden Rune [1] 1045397110")]
        LimgraveSummonwaterVillageGoldenRune1____ = 1045397110,

        [Annotation(Name = "[Limgrave - Fort Haight] Smithing Stone [1] 1046367000")]
        LimgraveFortHaightSmithingStone1 = 1046367000,

        [Annotation(Name = "[Limgrave - Fort Haight] Bloodrose 1046367010")]
        LimgraveFortHaightBloodrose = 1046367010,

        [Annotation(Name = "[Limgrave - Fort Haight] Nomadic Warrior's Cookbook [6] 67020")]
        LimgraveFortHaightNomadicWarriorsCookbook6 = 67020,

        [Annotation(Name = "[Limgrave - Fort Haight] Bloodrose 1046367030")]
        LimgraveFortHaightBloodrose_ = 1046367030,

        [Annotation(Name = "[Limgrave - Fort Haight] Dectus Medallion (Left) 1046367500")]
        LimgraveFortHaightDectusMedallionLeft = 1046367500,

        [Annotation(Name = "[Limgrave - Fort Haight] Ash of War: Bloody Slash 1046367700")]
        LimgraveFortHaightAshOfWarBloodySlash = 1046367700,

        [Annotation(Name = "[Limgrave - East of Siofra River Well] Strip of White Flesh 1046377000")]
        LimgraveEastOfSiofraRiverWellStripOfWhiteFlesh = 1046377000,

        [Annotation(Name = "[Limgrave - Third Church of Marika] Neutralizing Boluses 1046387010")]
        LimgraveThirdChurchOfMarikaNeutralizingBoluses = 1046387010,

        [Annotation(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [1] 1041327000")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1 = 1041327000,

        [Annotation(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [1] 1041327010")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1_ = 1041327010,

        [Annotation(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [2] 1041327020")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune2 = 1041327020,

        [Annotation(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [1] 1041327030")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1__ = 1041327030,

        [Annotation(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [1] 1041327040")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1___ = 1041327040,

        [Annotation(Name = "[Weeping Peninsula - Isolated Merchant's Shack] Golden Rune [3] 1041327050")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune3 = 1041327050,

        [Annotation(Name = "[Weeping Peninsula - Fourth Church of Marika] Golden Rune [1] 1041337000")]
        WeepingPeninsulaFourthChurchOfMarikaGoldenRune1 = 1041337000,

        [Annotation(Name = "[Weeping Peninsula - Fourth Church of Marika] Golden Rune [5] 1041337010")]
        WeepingPeninsulaFourthChurchOfMarikaGoldenRune5 = 1041337010,

        [Annotation(Name = "[Weeping Peninsula - Fourth Church of Marika] Great Dragonfly Head 1041337030")]
        WeepingPeninsulaFourthChurchOfMarikaGreatDragonflyHead = 1041337030,

        [Annotation(Name = "[Weeping Peninsula - Fourth Church of Marika] Ambush Shard 1041337100")]
        WeepingPeninsulaFourthChurchOfMarikaAmbushShard = 1041337100,

        [Annotation(Name = "[Weeping Peninsula - Tower of Return] Great Dragonfly Head 1042327000")]
        WeepingPeninsulaTowerOfReturnGreatDragonflyHead = 1042327000,

        [Annotation(Name = "[Weeping Peninsula - Tower of Return] Mushroom 1042327020")]
        WeepingPeninsulaTowerOfReturnMushroom = 1042327020,

        [Annotation(Name = "[Weeping Peninsula - Tower of Return] Composite Bow 1042327100")]
        WeepingPeninsulaTowerOfReturnCompositeBow = 1042327100,

        [Annotation(Name = "[Weeping Peninsula - Tombsward] Eclipse Crest Heater Shield 1042337000")]
        WeepingPeninsulaTombswardEclipseCrestHeaterShield = 1042337000,

        [Annotation(Name = "[Weeping Peninsula - Tombsward] Radagon's Scarseal 1042337100")]
        WeepingPeninsulaTombswardRadagonsScarseal = 1042337100,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Ruins] Blood Grease 1042347000")]
        WeepingPeninsulaTombswardRuinsBloodGrease = 1042347000,

        [Annotation(Name = "[Limgrave - South of Stranded Graveyard] Sliver of Meat 1042357020")]
        LimgraveSouthOfStrandedGraveyardSliverOfMeat = 1042357020,

        [Annotation(Name = "[Limgrave - South of Stranded Graveyard] Bewitching Branch 1042357030")]
        LimgraveSouthOfStrandedGraveyardBewitchingBranch = 1042357030,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Ruins] Beast Liver 1042347010")]
        WeepingPeninsulaTombswardRuinsBeastLiver = 1042347010,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Ruins] Winged Scythe 1042347100")]
        WeepingPeninsulaTombswardRuinsWingedScythe = 1042347100,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Ruins] Golden Rune [2] 1042347020")]
        WeepingPeninsulaTombswardRuinsGoldenRune2 = 1042347020,

        [Annotation(Name = "[Weeping Peninsula - Tombsward Ruins] Gilded Iron Shield 1042347030")]
        WeepingPeninsulaTombswardRuinsGildedIronShield = 1042347030,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Yellow Ember 1043327000")]
        WeepingPeninsulaCastleMorneApproachYellowEmber = 1043327000,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Sliver of Meat 1043327010")]
        WeepingPeninsulaCastleMorneApproachSliverOfMeat = 1043327010,

        [Annotation(Name = "[Weeping Peninsula - Minor Erdtree] Golden Rune [2] 1043337000")]
        WeepingPeninsulaMinorErdtreeGoldenRune2 = 1043337000,

        [Annotation(Name = "[Weeping Peninsula - Minor Erdtree] Golden Rune [2] 1043337010")]
        WeepingPeninsulaMinorErdtreeGoldenRune2_ = 1043337010,

        [Annotation(Name = "[Weeping Peninsula - Church of Pilgrimage] Arteria Leaf 1043347000")]
        WeepingPeninsulaChurchOfPilgrimageArteriaLeaf = 1043347000,

        [Annotation(Name = "[Weeping Peninsula - Church of Pilgrimage] Shield of the Guilty 1043347100")]
        WeepingPeninsulaChurchOfPilgrimageShieldOfTheGuilty = 1043347100,

        [Annotation(Name = "[Weeping Peninsula - Church of Pilgrimage] Faith-knot Crystal Tear 65240")]
        WeepingPeninsulaChurchOfPilgrimageFaithknotCrystalTear = 65240,

        [Annotation(Name = "[Weeping Peninsula - Church of Pilgrimage] Gold-Tinged Excrement 1043347040")]
        WeepingPeninsulaChurchOfPilgrimageGoldTingedExcrement = 1043347040,

        [Annotation(Name = "[Weeping Peninsula - Church of Pilgrimage] String 1043347050")]
        WeepingPeninsulaChurchOfPilgrimageString = 1043347050,

        [Annotation(Name = "[Weeping Peninsula - Church of Pilgrimage] Demi-Human Queen's Staff 1043347400")]
        WeepingPeninsulaChurchOfPilgrimageDemiHumanQueensStaff = 1043347400,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Golden Rune [4] 1044317010")]
        WeepingPeninsulaCastleMorneApproachGoldenRune4 = 1044317010,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Arteria Leaf 1044317020")]
        WeepingPeninsulaCastleMorneApproachArteriaLeaf = 1044317020,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Somber Smithing Stone [2] 1044317030")]
        WeepingPeninsulaCastleMorneApproachSomberSmithingStone2 = 1044317030,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Smithing Stone [1] 1044327010")]
        WeepingPeninsulaCastleMorneApproachSmithingStone1 = 1044327010,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Warming Stone 1044327030")]
        WeepingPeninsulaCastleMorneApproachWarmingStone = 1044327030,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Great Turtle Shell 1044327040")]
        WeepingPeninsulaCastleMorneApproachGreatTurtleShell = 1044327040,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Sacrificial Axe 1044327400")]
        WeepingPeninsulaCastleMorneApproachSacrificialAxe = 1044327400,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne Approach] Ash of War: Barricade Shield 1044327410")]
        WeepingPeninsulaCastleMorneApproachAshOfWarBarricadeShield = 1044327410,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] Crest Wooden Shield 1044337000")]
        WeepingPeninsulaAilingVillageOutskirtsCrestWoodenShield = 1044337000,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] Rainbow Stone 1044337020")]
        WeepingPeninsulaAilingVillageOutskirtsRainbowStone = 1044337020,

        [Annotation(Name = "[Weeping Peninsula - Bridge of Sacrifice] Hand Ballista 1044347100")]
        WeepingPeninsulaBridgeOfSacrificeHandBallista = 1044347100,

        [Annotation(Name = "[Weeping Peninsula - Bridge of Sacrifice] Rainbow Stone 1044347040")]
        WeepingPeninsulaBridgeOfSacrificeRainbowStone = 1044347040,

        [Annotation(Name = "[Weeping Peninsula - Bridge of Sacrifice] Golden Rune [1] 1044347060")]
        WeepingPeninsulaBridgeOfSacrificeGoldenRune1 = 1044347060,

        [Annotation(Name = "[Weeping Peninsula - Bridge of Sacrifice] Golden Rune [1] 1044347070")]
        WeepingPeninsulaBridgeOfSacrificeGoldenRune1_ = 1044347070,

        [Annotation(Name = "[Leyndell - Minor Erdtree] Starlight Shards 1045337000")]
        LeyndellMinorErdtreeStarlightShards = 1045337000,

        [Annotation(Name = "[Leyndell - Minor Erdtree] Memory Stone 60400")]
        LeyndellMinorErdtreeMemoryStone = 60400,

        [Annotation(Name = "[Weeping Peninsula - Impaler's Catacombs Entrance] Stonesword Key 1045347000")]
        WeepingPeninsulaImpalersCatacombsEntranceStoneswordKey = 1045347000,

        [Annotation(Name = "[Weeping Peninsula - Tombsward] Golden Rune [1] 1042337200")]
        WeepingPeninsulaTombswardGoldenRune1 = 1042337200,

        [Annotation(Name = "[Weeping Peninsula - Morne Moangrave] Somber Smithing Stone [1] 1043307000")]
        WeepingPeninsulaMorneMoangraveSomberSmithingStone1 = 1043307000,

        [Annotation(Name = "[Weeping Peninsula - Morne Moangrave] Fire Arrow 1043307010")]
        WeepingPeninsulaMorneMoangraveFireArrow = 1043307010,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Fire Grease 1043317000")]
        WeepingPeninsulaCastleMorneFireGrease = 1043317000,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317010")]
        WeepingPeninsulaCastleMorne = 1043317010,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Smithing Stone [2] 1043317020")]
        WeepingPeninsulaCastleMorneSmithingStone2 = 1043317020,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317030")]
        WeepingPeninsulaCastleMorne_ = 1043317030,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317040")]
        WeepingPeninsulaCastleMorne__ = 1043317040,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317050")]
        WeepingPeninsulaCastleMorne___ = 1043317050,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317060")]
        WeepingPeninsulaCastleMorne____ = 1043317060,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317070")]
        WeepingPeninsulaCastleMorne_____ = 1043317070,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Golden Rune [2] 1043317080")]
        WeepingPeninsulaCastleMorneGoldenRune2 = 1043317080,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Smithing Stone [2] 1043317090")]
        WeepingPeninsulaCastleMorneSmithingStone2_ = 1043317090,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317100")]
        WeepingPeninsulaCastleMorne______ = 1043317100,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Golden Rune [2] 1043317110")]
        WeepingPeninsulaCastleMorneGoldenRune2_ = 1043317110,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317120")]
        WeepingPeninsulaCastleMorne_______ = 1043317120,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317130")]
        WeepingPeninsulaCastleMorne________ = 1043317130,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Pickled Turtle Neck 1043317140")]
        WeepingPeninsulaCastleMornePickledTurtleNeck = 1043317140,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317150")]
        WeepingPeninsulaCastleMorne_________ = 1043317150,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317160")]
        WeepingPeninsulaCastleMorne__________ = 1043317160,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Stonesword Key 1043317170")]
        WeepingPeninsulaCastleMorneStoneswordKey = 1043317170,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317180")]
        WeepingPeninsulaCastleMorne___________ = 1043317180,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317190")]
        WeepingPeninsulaCastleMorne____________ = 1043317190,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317200")]
        WeepingPeninsulaCastleMorne_____________ = 1043317200,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317210")]
        WeepingPeninsulaCastleMorne______________ = 1043317210,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Tarnished Golden Sunflower 1043317220")]
        WeepingPeninsulaCastleMorneTarnishedGoldenSunflower = 1043317220,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317230")]
        WeepingPeninsulaCastleMorne_______________ = 1043317230,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Smithing Stone [2] 1043317240")]
        WeepingPeninsulaCastleMorneSmithingStone2__ = 1043317240,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317250")]
        WeepingPeninsulaCastleMorne________________ = 1043317250,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317260")]
        WeepingPeninsulaCastleMorne_________________ = 1043317260,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317270")]
        WeepingPeninsulaCastleMorne__________________ = 1043317270,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Throwing Dagger 1043317280")]
        WeepingPeninsulaCastleMorneThrowingDagger = 1043317280,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317290")]
        WeepingPeninsulaCastleMorne___________________ = 1043317290,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317300")]
        WeepingPeninsulaCastleMorne____________________ = 1043317300,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317310")]
        WeepingPeninsulaCastleMorne_____________________ = 1043317310,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Furlcalling Finger Remedy 1043317320")]
        WeepingPeninsulaCastleMorneFurlcallingFingerRemedy = 1043317320,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Steel-Wire Torch 1043317330")]
        WeepingPeninsulaCastleMorneSteelWireTorch = 1043317330,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] 1043317340")]
        WeepingPeninsulaCastleMorne______________________ = 1043317340,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Smithing Stone [1] 1043317350")]
        WeepingPeninsulaCastleMorneSmithingStone1 = 1043317350,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Ballista Bolt 1043317360")]
        WeepingPeninsulaCastleMorneBallistaBolt = 1043317360,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Whip 1043317370")]
        WeepingPeninsulaCastleMorneWhip = 1043317370,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Golden Rune [1] 1043317400")]
        WeepingPeninsulaCastleMorneGoldenRune1 = 1043317400,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Smithing Stone [1] 1043317500")]
        WeepingPeninsulaCastleMorneSmithingStone1_ = 1043317500,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Twinblade Talisman 1043317900")]
        WeepingPeninsulaCastleMorneTwinbladeTalisman = 1043317900,

        [Annotation(Name = "[Weeping Peninsula - Castle Morne] Claymore 1043317910")]
        WeepingPeninsulaCastleMorneClaymore = 1043317910,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] Strip of White Flesh 1044337030")]
        WeepingPeninsulaAilingVillageOutskirtsStripOfWhiteFlesh = 1044337030,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] 1044337040")]
        WeepingPeninsulaAilingVillageOutskirts = 1044337040,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] Golden Rune [2] 1044337050")]
        WeepingPeninsulaAilingVillageOutskirtsGoldenRune2 = 1044337050,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] 1044337060")]
        WeepingPeninsulaAilingVillageOutskirts_ = 1044337060,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] Golden Rune [2] 1044337070")]
        WeepingPeninsulaAilingVillageOutskirtsGoldenRune2_ = 1044337070,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] The Flame of Frenzy 1044337080")]
        WeepingPeninsulaAilingVillageOutskirtsTheFlameOfFrenzy = 1044337080,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] Smithing Stone [2] 1044337200")]
        WeepingPeninsulaAilingVillageOutskirtsSmithingStone2 = 1044337200,

        [Annotation(Name = "[Weeping Peninsula - Ailing Village Outskirts] Morning Star 1044337210")]
        WeepingPeninsulaAilingVillageOutskirtsMorningStar = 1044337210,

        [Annotation(Name = "[Limgrave - Rear Gael Tunnel Entrance] Golden Rune [1] 1046397000")]
        LimgraveRearGaelTunnelEntranceGoldenRune1 = 1046397000,

        [Annotation(Name = "[Limgrave - Rear Gael Tunnel Entrance] Golden Rune [2] 1046397010")]
        LimgraveRearGaelTunnelEntranceGoldenRune2 = 1046397010,

        [Annotation(Name = "[Limgrave - Rear Gael Tunnel Entrance] Golden Rune [3] 1046397020")]
        LimgraveRearGaelTunnelEntranceGoldenRune3 = 1046397020,

        [Annotation(Name = "[Caelid - Smoldering Church] Nascent Butterfly 1046407000")]
        CaelidSmolderingChurchNascentButterfly = 1046407000,

        [Annotation(Name = "[Caelid - Smoldering Church] Rune Arc 1046407010")]
        CaelidSmolderingChurchRuneArc = 1046407010,

        [Annotation(Name = "[Caelid - Smoldering Church] Golden Rune [3] 1046407020")]
        CaelidSmolderingChurchGoldenRune3 = 1046407020,

        [Annotation(Name = "[Caelid - Smoldering Church] Missionary's Cookbook [3] 67650")]
        CaelidSmolderingChurchMissionarysCookbook3 = 67650,

        [Annotation(Name = "[Caelid - Smoldering Church] Preserving Boluses 1046407040")]
        CaelidSmolderingChurchPreservingBoluses = 1046407040,

        [Annotation(Name = "[Caelid - Smoldering Church] Nomadic Warrior's Cookbook [14] 67870")]
        CaelidSmolderingChurchNomadicWarriorsCookbook14 = 67870,

        [Annotation(Name = "[Caelid - Smoldering Church] Drawstring Lightning Grease 1046407060")]
        CaelidSmolderingChurchDrawstringLightningGrease = 1046407060,

        [Annotation(Name = "[Caelid - Smoldering Church] Sacred Scorpion Charm 1046407700")]
        CaelidSmolderingChurchSacredScorpionCharm = 1046407700,

        [Annotation(Name = "[Caelid - West of Caelid Highway South] Golden Rune [1] 1047377000")]
        CaelidWestOfCaelidHighwaySouthGoldenRune1 = 1047377000,

        [Annotation(Name = "[Caelid - West of Caelid Highway South] Golden Rune [5] 1047377010")]
        CaelidWestOfCaelidHighwaySouthGoldenRune5 = 1047377010,

        [Annotation(Name = "[Caelid - West of Caelid Highway South] Golden Rune [1] 1047377020")]
        CaelidWestOfCaelidHighwaySouthGoldenRune1_ = 1047377020,

        [Annotation(Name = "[Caelid - West of Caelid Highway South] Golden Rune [2] 1047377030")]
        CaelidWestOfCaelidHighwaySouthGoldenRune2 = 1047377030,

        [Annotation(Name = "[Caelid - West of Caelid Highway South] Poisonbloom 1047377040")]
        CaelidWestOfCaelidHighwaySouthPoisonbloom = 1047377040,

        [Annotation(Name = "[Caelid - West of Caelid Highway South] Starlight Shards 1047377050")]
        CaelidWestOfCaelidHighwaySouthStarlightShards = 1047377050,

        [Annotation(Name = "[Caelid - West of Caelid Highway South] Larval Tear 1047377100")]
        CaelidWestOfCaelidHighwaySouthLarvalTear = 1047377100,

        [Annotation(Name = "[Caelid - Fort Gael] Somber Smithing Stone [4] 1047387010")]
        CaelidFortGaelSomberSmithingStone4 = 1047387010,

        [Annotation(Name = "[Caelid - Fort Gael] Great Dragonfly Head 1047387030")]
        CaelidFortGaelGreatDragonflyHead = 1047387030,

        [Annotation(Name = "[Caelid - Fort Gael] Rot Grease 1047387040")]
        CaelidFortGaelRotGrease = 1047387040,

        [Annotation(Name = "[Caelid - Fort Gael] Rune Arc 1047387070")]
        CaelidFortGaelRuneArc = 1047387070,

        [Annotation(Name = "[Caelid - Fort Gael] Warming Stone 1047387080")]
        CaelidFortGaelWarmingStone = 1047387080,

        [Annotation(Name = "[Caelid - Fort Gael] Smoldering Butterfly 1047387100")]
        CaelidFortGaelSmolderingButterfly = 1047387100,

        [Annotation(Name = "[Caelid - Fort Gael] Mushroom 1047387110")]
        CaelidFortGaelMushroom = 1047387110,

        [Annotation(Name = "[Caelid - Fort Gael] Flame, Grant Me Strength 1047387120")]
        CaelidFortGaelFlameGrantMeStrength = 1047387120,

        [Annotation(Name = "[Caelid - Fort Gael] Explosive Greatbolt 1047387130")]
        CaelidFortGaelExplosiveGreatbolt = 1047387130,

        [Annotation(Name = "[Caelid - Fort Gael] Ash of War: Lion's Claw 1047387700")]
        CaelidFortGaelAshOfWarLionsClaw = 1047387700,

        [Annotation(Name = "[Caelid - Fort Gael] Starscourge Heirloom 1047387900")]
        CaelidFortGaelStarscourgeHeirloom = 1047387900,

        [Annotation(Name = "[Caelid - Fort Gael] Meteoric Ore Blade 1047387910")]
        CaelidFortGaelMeteoricOreBlade = 1047387910,

        [Annotation(Name = "[Caelid - Fort Gael] Katar 1047387920")]
        CaelidFortGaelKatar = 1047387920,

        [Annotation(Name = "[Caelid - Fort Gael North] Smithing Stone [5] 1047397000")]
        CaelidFortGaelNorthSmithingStone5 = 1047397000,

        [Annotation(Name = "[Caelid - Fort Gael North] Golden Rune [9] 1047397040")]
        CaelidFortGaelNorthGoldenRune9 = 1047397040,

        [Annotation(Name = "[Caelid - Fort Gael North] Slumbering Egg 1047397080")]
        CaelidFortGaelNorthSlumberingEgg = 1047397080,

        [Annotation(Name = "[Caelid - Caelem Ruins] Golden Rune [5] 1047407000")]
        CaelidCaelemRuinsGoldenRune5 = 1047407000,

        [Annotation(Name = "[Caelid - Caelem Ruins] Cracked Pot 66190")]
        CaelidCaelemRuinsCrackedPot = 66190,

        [Annotation(Name = "[Caelid - Caelem Ruins] Smithing Stone [4] 1047407020")]
        CaelidCaelemRuinsSmithingStone4 = 1047407020,

        [Annotation(Name = "[Caelid - Caelem Ruins] Somber Smithing Stone [4] 1047407030")]
        CaelidCaelemRuinsSomberSmithingStone4 = 1047407030,

        [Annotation(Name = "[Caelid - Caelem Ruins] Explosive Bolt 1047407040")]
        CaelidCaelemRuinsExplosiveBolt = 1047407040,

        [Annotation(Name = "[Caelid - Caelem Ruins] Drawstring Fire Grease 1047407070")]
        CaelidCaelemRuinsDrawstringFireGrease = 1047407070,

        [Annotation(Name = "[Caelid - Caelem Ruins] Smoldering Butterfly 1047407080")]
        CaelidCaelemRuinsSmolderingButterfly = 1047407080,

        [Annotation(Name = "[Caelid - Caelem Ruins] Rune Arc 1047407900")]
        CaelidCaelemRuinsRuneArc = 1047407900,

        [Annotation(Name = "[Caelid - Caelem Ruins] Sword of St. Trina 1047407910")]
        CaelidCaelemRuinsSwordOfStTrina = 1047407910,

        [Annotation(Name = "[Caelid - Caelem Ruins] Greatsword 1047407920")]
        CaelidCaelemRuinsGreatsword = 1047407920,

        [Annotation(Name = "[Caelid - Cathedral of Dragon Communion] Ancient Dragon Apostle's Cookbook [3] 68030")]
        CaelidCathedralOfDragonCommunionAncientDragonApostlesCookbook3 = 68030,

        [Annotation(Name = "[Caelid - Caelid Highway South] Crab Eggs 1048377000")]
        CaelidCaelidHighwaySouthCrabEggs = 1048377000,

        [Annotation(Name = "[Caelid - Caelid Highway South] Golden Rune [3] 1048377020")]
        CaelidCaelidHighwaySouthGoldenRune3 = 1048377020,

        [Annotation(Name = "[Caelid - Caelid Highway South] Golden Rune [4] 1048377030")]
        CaelidCaelidHighwaySouthGoldenRune4 = 1048377030,

        [Annotation(Name = "[Caelid - West Aeonia Swamp] Golden Rune [4] 1048387000")]
        CaelidWestAeoniaSwampGoldenRune4 = 1048387000,

        [Annotation(Name = "[Caelid - West Aeonia Swamp] Perfume Bottle 66790")]
        CaelidWestAeoniaSwampPerfumeBottle = 66790,

        [Annotation(Name = "[Caelid - West Aeonia Swamp] Traveler's Hat 1048387010")]
        CaelidWestAeoniaSwampTravelersHat = 1048387010,

        [Annotation(Name = "[Caelid - West Aeonia Swamp] Golden Rune [5] 1048387020")]
        CaelidWestAeoniaSwampGoldenRune5 = 1048387020,

        [Annotation(Name = "[Caelid - West Aeonia Swamp] Sacramental Bud 1048387500")]
        CaelidWestAeoniaSwampSacramentalBud = 1048387500,

        [Annotation(Name = "[Caelid - Smoldering Wall] Sacramental Bud 1048397000")]
        CaelidSmolderingWallSacramentalBud = 1048397000,

        [Annotation(Name = "[Caelid - Smoldering Wall] Somber Smithing Stone [5] 1048397010")]
        CaelidSmolderingWallSomberSmithingStone5 = 1048397010,

        [Annotation(Name = "[Caelid - Smoldering Wall] Great Dragonfly Head 1048397040")]
        CaelidSmolderingWallGreatDragonflyHead = 1048397040,

        [Annotation(Name = "[Caelid - Smoldering Wall] Stonesword Key 1048397050")]
        CaelidSmolderingWallStoneswordKey = 1048397050,

        [Annotation(Name = "[Caelid - Smoldering Wall] Rock Sling 1048397900")]
        CaelidSmolderingWallRockSling = 1048397900,

        [Annotation(Name = "[Caelid - Deep Siofra Well] Golden Rune [1] 1048407010")]
        CaelidDeepSiofraWellGoldenRune1 = 1048407010,

        [Annotation(Name = "[Caelid - Deep Siofra Well] Golden Rune [6] 1048407020")]
        CaelidDeepSiofraWellGoldenRune6 = 1048407020,

        [Annotation(Name = "[Caelid - Deep Siofra Well] Golden Rune [2] 1048407030")]
        CaelidDeepSiofraWellGoldenRune2 = 1048407030,

        [Annotation(Name = "[Caelid - Deep Siofra Well] Sacramental Bud 1048407040")]
        CaelidDeepSiofraWellSacramentalBud = 1048407040,

        [Annotation(Name = "[Caelid - Deep Siofra Well] Hefty Beast Bone 1048407050")]
        CaelidDeepSiofraWellHeftyBeastBone = 1048407050,

        [Annotation(Name = "[Caelid - Deep Siofra Well] Spiked Palisade Shield 1048407060")]
        CaelidDeepSiofraWellSpikedPalisadeShield = 1048407060,

        [Annotation(Name = "[Caelid - Deep Siofra Well] Visage Shield 1048407900")]
        CaelidDeepSiofraWellVisageShield = 1048407900,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Isolated Merchant's Shack] Gravity Stone Peddler's Bell Bearing 1048417800")]
        GreyollsDragonbarrowIsolatedMerchantsShackGravityStonePeddlersBellBearing = 1048417800,

        [Annotation(Name = "[Caelid - Southwest of Caelid Highway South] Smoldering Butterfly 1049367000")]
        CaelidSouthwestOfCaelidHighwaySouthSmolderingButterfly = 1049367000,

        [Annotation(Name = "[Caelid - Southwest of Caelid Highway South] Fan Daggers 1049367010")]
        CaelidSouthwestOfCaelidHighwaySouthFanDaggers = 1049367010,

        [Annotation(Name = "[Caelid - Southern Aeonia Swamp Bank] Windy Crystal Tear 65150")]
        CaelidSouthernAeoniaSwampBankWindyCrystalTear = 65150,

        [Annotation(Name = "[Caelid - Southern Aeonia Swamp Bank] Beast Blood 1049377010")]
        CaelidSouthernAeoniaSwampBankBeastBlood = 1049377010,

        [Annotation(Name = "[Caelid - Southern Aeonia Swamp Bank] Golden Seed 1049377020")]
        CaelidSouthernAeoniaSwampBankGoldenSeed = 1049377020,

        [Annotation(Name = "[Caelid - Southern Aeonia Swamp Bank] Beast Blood 1049377050")]
        CaelidSouthernAeoniaSwampBankBeastBlood_ = 1049377050,

        [Annotation(Name = "[Caelid - Southern Aeonia Swamp Bank] Golden Rune [2] 1049377070")]
        CaelidSouthernAeoniaSwampBankGoldenRune2 = 1049377070,

        [Annotation(Name = "[Caelid - Southern Aeonia Swamp Bank] Ash of War: Poison Moth Flight 1049377100")]
        CaelidSouthernAeoniaSwampBankAshOfWarPoisonMothFlight = 1049377100,

        [Annotation(Name = "[Caelid - Southern Aeonia Swamp Bank] Death's Poker 1049377110")]
        CaelidSouthernAeoniaSwampBankDeathsPoker = 1049377110,

        [Annotation(Name = "[Caelid - Southern Aeonia Swamp Bank] Somber Smithing Stone [4] 1049377700")]
        CaelidSouthernAeoniaSwampBankSomberSmithingStone4 = 1049377700,

        [Annotation(Name = "[Caelid - East Aeonia Swamp] Eternal Darkness 1049387800")]
        CaelidEastAeoniaSwampEternalDarkness = 1049387800,

        [Annotation(Name = "[Caelid - East Aeonia Swamp] Somber Smithing Stone [4] 1049387010")]
        CaelidEastAeoniaSwampSomberSmithingStone4 = 1049387010,

        [Annotation(Name = "[Caelid - East Aeonia Swamp] Aeonian Butterfly 1049387020")]
        CaelidEastAeoniaSwampAeonianButterfly = 1049387020,

        [Annotation(Name = "[Caelid - East Aeonia Swamp] Smithing Stone [4] 1049387030")]
        CaelidEastAeoniaSwampSmithingStone4 = 1049387030,

        [Annotation(Name = "[Caelid - East Aeonia Swamp] Black-Key Bolt 1049387040")]
        CaelidEastAeoniaSwampBlackKeyBolt = 1049387040,

        [Annotation(Name = "[Caelid - East Aeonia Swamp] Sacramental Bud 1049387060")]
        CaelidEastAeoniaSwampSacramentalBud = 1049387060,

        [Annotation(Name = "[Caelid - East Aeonia Swamp] Rune Arc 1049387070")]
        CaelidEastAeoniaSwampRuneArc = 1049387070,

        [Annotation(Name = "[Caelid - East Aeonia Swamp] Golden Rune [4] 1049387080")]
        CaelidEastAeoniaSwampGoldenRune4 = 1049387080,

        [Annotation(Name = "[Caelid - East Aeonia Swamp] Golden Rune [5] 1049387110")]
        CaelidEastAeoniaSwampGoldenRune5 = 1049387110,

        [Annotation(Name = "[Caelid - East Aeonia Swamp] Glass Shard 1049387120")]
        CaelidEastAeoniaSwampGlassShard = 1049387120,

        [Annotation(Name = "[Caelid - West Sellia] Stonesword Key 1049397000")]
        CaelidWestSelliaStoneswordKey = 1049397000,

        [Annotation(Name = "[Caelid - West Sellia] Poisonbloom 1049397010")]
        CaelidWestSelliaPoisonbloom = 1049397010,

        [Annotation(Name = "[Caelid - West Sellia] Rune Arc 1049397020")]
        CaelidWestSelliaRuneArc = 1049397020,

        [Annotation(Name = "[Caelid - West Sellia] Staff of Loss 1049397030")]
        CaelidWestSelliaStaffOfLoss = 1049397030,

        [Annotation(Name = "[Caelid - West Sellia] Rotten Stray Ashes 1049397040")]
        CaelidWestSelliaRottenStrayAshes = 1049397040,

        [Annotation(Name = "[Caelid - West Sellia] Nox Flowing Sword 1049397800")]
        CaelidWestSelliaNoxFlowingSword = 1049397800,

        [Annotation(Name = "[Caelid - West Sellia] Battlemage Hugues 1049397850")]
        CaelidWestSelliaBattlemageHugues = 1049397850,

        [Annotation(Name = "[Caelid - West Sellia] Lusat's Glintstone Staff 1049397900")]
        CaelidWestSelliaLusatsGlintstoneStaff = 1049397900,

        [Annotation(Name = "[Caelid - West Sellia] Spelldrake Talisman +1 1049397910")]
        CaelidWestSelliaSpelldrakeTalisman1 = 1049397910,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Deep Siofra Well] Map: Dragonbarrow 62041")]
        GreyollsDragonbarrowDeepSiofraWellMapDragonbarrow = 62041,

        [Annotation(Name = "[Caelid - Southern Aeonia Swamp Bank] Map: Caelid 62040")]
        CaelidSouthernAeoniaSwampBankMapCaelid = 62040,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Deep Siofra Well] Golden Rune [5] 1049407000")]
        GreyollsDragonbarrowDeepSiofraWellGoldenRune5 = 1049407000,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Deep Siofra Well] Gravel Stone 1049407010")]
        GreyollsDragonbarrowDeepSiofraWellGravelStone = 1049407010,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Deep Siofra Well] Sliver of Meat 1049407020")]
        GreyollsDragonbarrowDeepSiofraWellSliverOfMeat = 1049407020,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Deep Siofra Well] Smithing Stone [5] 1049407040")]
        GreyollsDragonbarrowDeepSiofraWellSmithingStone5 = 1049407040,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid Entrance] Arteria Leaf 1049417040")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceArteriaLeaf = 1049417040,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid Entrance] Dragonwound Grease 1049417070")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceDragonwoundGrease = 1049417070,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid Entrance] Rune Arc 1049417080")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceRuneArc = 1049417080,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid Entrance] Somber Smithing Stone [9] 1049417090")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceSomberSmithingStone9 = 1049417090,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Divine Tower of Caelid Entrance] Numen's Rune 1049417100")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceNumensRune = 1049417100,

        [Annotation(Name = "[Caelid - East Sellia] Night Comet 1050397900")]
        CaelidEastSelliaNightComet = 1050397900,

        [Annotation(Name = "[Caelid - East Sellia] Imbued Sword Key 1050397910")]
        CaelidEastSelliaImbuedSwordKey = 1050397910,

        [Annotation(Name = "[Caelid - Impassable Greatbridge] Mushroom 1050367000")]
        CaelidImpassableGreatbridgeMushroom = 1050367000,

        [Annotation(Name = "[Caelid - Impassable Greatbridge] Arrow's Sting Talisman 1050367900")]
        CaelidImpassableGreatbridgeArrowsStingTalisman = 1050367900,

        [Annotation(Name = "[Caelid - Gowry's Shack] Golden Rune [5] 1050387000")]
        CaelidGowrysShackGoldenRune5 = 1050387000,

        [Annotation(Name = "[Caelid - Gowry's Shack] Drawstring Poison Grease 1050387010")]
        CaelidGowrysShackDrawstringPoisonGrease = 1050387010,

        [Annotation(Name = "[Caelid - Gowry's Shack] Sacred Tear 1050387020")]
        CaelidGowrysShackSacredTear = 1050387020,

        [Annotation(Name = "[Caelid - East Sellia] Poison Grease 1050397000")]
        CaelidEastSelliaPoisonGrease = 1050397000,

        [Annotation(Name = "[Caelid - East Sellia] Toxic Mushroom 1050397010")]
        CaelidEastSelliaToxicMushroom = 1050397010,

        [Annotation(Name = "[Caelid - East Sellia] Smithing Stone [7] 1050397020")]
        CaelidEastSelliaSmithingStone7 = 1050397020,

        [Annotation(Name = "[Caelid - East Sellia] Smithing Stone [7] 1050397030")]
        CaelidEastSelliaSmithingStone7_ = 1050397030,

        [Annotation(Name = "[Caelid - East Sellia] Stonesword Key 1050397040")]
        CaelidEastSelliaStoneswordKey = 1050397040,

        [Annotation(Name = "[Caelid - East Sellia] Smithing Stone [8] 1050397050")]
        CaelidEastSelliaSmithingStone8 = 1050397050,

        [Annotation(Name = "[Caelid - East Sellia] Starlight Shards 1050397060")]
        CaelidEastSelliaStarlightShards = 1050397060,

        [Annotation(Name = "[Caelid - East Sellia] Cerulean Tear Scarab 1050397070")]
        CaelidEastSelliaCeruleanTearScarab = 1050397070,

        [Annotation(Name = "[Caelid - East Sellia] Beast Blood 1050397090")]
        CaelidEastSelliaBeastBlood = 1050397090,

        [Annotation(Name = "[Caelid - East Sellia] Golden Seed 1050397100")]
        CaelidEastSelliaGoldenSeed = 1050397100,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Dragonbarrow Fork] Dragon Heart 1050407800")]
        GreyollsDragonbarrowDragonbarrowForkDragonHeart = 1050407800,

        [Annotation(Name = "[Caelid - Redmane Castle South Cliffside] Smoldering Butterfly 1051357000")]
        CaelidRedmaneCastleSouthCliffsideSmolderingButterfly = 1051357000,

        [Annotation(Name = "[Caelid - Redmane Castle] Golden Rune [6] 1051367000")]
        CaelidRedmaneCastleGoldenRune6 = 1051367000,

        [Annotation(Name = "[Caelid - Redmane Castle] Armorer's Cookbook [4] 67260")]
        CaelidRedmaneCastleArmorersCookbook4 = 67260,

        [Annotation(Name = "[Caelid - Redmane Castle] Smithing Stone [6] 1051367020")]
        CaelidRedmaneCastleSmithingStone6 = 1051367020,

        [Annotation(Name = "[Caelid - Redmane Castle] Smithing Stone [3] 1051367030")]
        CaelidRedmaneCastleSmithingStone3 = 1051367030,

        [Annotation(Name = "[Caelid - Redmane Castle] Smithing Stone [4] 1051367040")]
        CaelidRedmaneCastleSmithingStone4 = 1051367040,

        [Annotation(Name = "[Caelid - Redmane Castle] Smithing Stone [3] 1051367050")]
        CaelidRedmaneCastleSmithingStone3_ = 1051367050,

        [Annotation(Name = "[Caelid - Redmane Castle] Smithing Stone [5] 1051367060")]
        CaelidRedmaneCastleSmithingStone5 = 1051367060,

        [Annotation(Name = "[Caelid - Redmane Castle] Red-Hot Whetblade 65640")]
        CaelidRedmaneCastleRedHotWhetblade = 65640,

        [Annotation(Name = "[Caelid - Redmane Castle] Smithing Stone [5] 1051367080")]
        CaelidRedmaneCastleSmithingStone5_ = 1051367080,

        [Annotation(Name = "[Caelid - Redmane Castle] Smithing Stone [4] 1051367090")]
        CaelidRedmaneCastleSmithingStone4_ = 1051367090,

        [Annotation(Name = "[Caelid - Redmane Castle] Smithing Stone [6] 1051367100")]
        CaelidRedmaneCastleSmithingStone6_ = 1051367100,

        [Annotation(Name = "[Caelid - Redmane Castle] Somber Smithing Stone [5] 1051367110")]
        CaelidRedmaneCastleSomberSmithingStone5 = 1051367110,

        [Annotation(Name = "[Caelid - Redmane Castle] Armorer's Cookbook [5] 67310")]
        CaelidRedmaneCastleArmorersCookbook5 = 67310,

        [Annotation(Name = "[Caelid - Redmane Castle] Flamberge 1051367130")]
        CaelidRedmaneCastleFlamberge = 1051367130,

        [Annotation(Name = "[Caelid - Redmane Castle] Somber Smithing Stone [4] 1051367700")]
        CaelidRedmaneCastleSomberSmithingStone4 = 1051367700,

        [Annotation(Name = "[Caelid - Redmane Castle] Somber Smithing Stone [4] 1051367800")]
        CaelidRedmaneCastleSomberSmithingStone4_ = 1051367800,

        [Annotation(Name = "[Caelid - Redmane Castle] Smithing Stone [6] 1051367910")]
        CaelidRedmaneCastleSmithingStone6__ = 1051367910,

        [Annotation(Name = "[Caelid - West Radahn Arena] Radahn's Spear 1051387000")]
        CaelidWestRadahnArenaRadahnsSpear = 1051387000,

        [Annotation(Name = "[Caelid - West Radahn Arena] Radahn's Spear 1051387010")]
        CaelidWestRadahnArenaRadahnsSpear_ = 1051387010,

        [Annotation(Name = "[Caelid - West Radahn Arena] Radahn's Spear 1051387020")]
        CaelidWestRadahnArenaRadahnsSpear__ = 1051387020,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Fort Faroth] Golden Rune [12] 1051397040")]
        GreyollsDragonbarrowFortFarothGoldenRune12 = 1051397040,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Fort Faroth] Neutralizing Boluses 1051397050")]
        GreyollsDragonbarrowFortFarothNeutralizingBoluses = 1051397050,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Fort Faroth] Radagon's Soreseal 1051397060")]
        GreyollsDragonbarrowFortFarothRadagonsSoreseal = 1051397060,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Fort Faroth] Dectus Medallion (Right) 1051397900")]
        GreyollsDragonbarrowFortFarothDectusMedallionRight = 1051397900,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Minor Erdtree] Rune Arc 1051407040")]
        GreyollsDragonbarrowMinorErdtreeRuneArc = 1051407040,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Bestial Sanctum] Soft Cotton 1051417000")]
        GreyollsDragonbarrowBestialSanctumSoftCotton = 1051417000,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Bestial Sanctum] Cinquedea 1051417010")]
        GreyollsDragonbarrowBestialSanctumCinquedea = 1051417010,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Bestial Sanctum] Golden Seed 1051437020")]
        GreyollsDragonbarrowBestialSanctumGoldenSeed = 1051437020,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Bestial Sanctum] Dragoncrest Shield Talisman 1051417030")]
        GreyollsDragonbarrowBestialSanctumDragoncrestShieldTalisman = 1051417030,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Golden Rune [8] 1052417000")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune8 = 1052417000,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Golden Rune [6] 1052417010")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune6 = 1052417010,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Golden Rune [3] 1052417020")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune3 = 1052417020,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Golden Rune [1] 1052417030")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune1 = 1052417030,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Ash of War: Bloodhound's Step 1052417100")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeAshOfWarBloodhoundsStep = 1052417100,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Southeast Farum Greatbridge] Memory Stone 60460")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeMemoryStone = 60460,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Northeast Cliffside] Starlight Shards 1052437000")]
        GreyollsDragonbarrowNortheastCliffsideStarlightShards = 1052437000,

        [Annotation(Name = "[Liurnia of the Lakes - Main Academy Gate] Golden Seed 1035467100")]
        LiurniaOfTheLakesMainAcademyGateGoldenSeed = 1035467100,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Southwest] Golden Seed 1036447300")]
        LiurniaOfTheLakesGateTownSouthwestGoldenSeed = 1036447300,

        [Annotation(Name = "[Liurnia of the Lakes - Church of Irith] Sacred Tear 1039397000")]
        LiurniaOfTheLakesChurchOfIrithSacredTear = 1039397000,

        [Annotation(Name = "[Liurnia of the Lakes - Southeast Ravine] Sacred Tear 1036497000")]
        LiurniaOfTheLakesSoutheastRavineSacredTear = 1036497000,

        [Annotation(Name = "[Bellum Highway - Church of Inhibition] Sacred Tear 1037497100")]
        BellumHighwayChurchOfInhibitionSacredTear = 1037497100,

        [Annotation(Name = "[Liurnia of the Lakes - West of Scenic Isle] Dexterity-knot Crystal Tear 65220")]
        LiurniaOfTheLakesWestOfScenicIsleDexterityknotCrystalTear = 65220,

        [Annotation(Name = "[Liurnia of the Lakes - South of Caria Manor] Intelligence-knot Crystal Tear 65230")]
        LiurniaOfTheLakesSouthOfCariaManorIntelligenceknotCrystalTear = 65230,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Northwest] Ancient Death Rancor 1036457400")]
        LiurniaOfTheLakesGateTownNorthwestAncientDeathRancor = 1036457400,

        [Annotation(Name = "[Bellum Highway - East Raya Lucaria Gate] Ash of War: Giant Hunt 1036487400")]
        BellumHighwayEastRayaLucariaGateAshOfWarGiantHunt = 1036487400,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Red-Feathered Branchsword 1037427400")]
        LiurniaOfTheLakesLaskyarRuinsRedFeatheredBranchsword = 1037427400,

        [Annotation(Name = "[Liurnia of the Lakes - Church of Vows] Meat Peddler's Bell Bearing 1037467400")]
        LiurniaOfTheLakesChurchOfVowsMeatPeddlersBellBearing = 1037467400,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Ash of War: Ice Spear 1039437400")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthAshOfWarIceSpear = 1039437400,

        [Annotation(Name = "[Liurnia of the Lakes - North of Gate Town Bridge] Dragon Cult Prayerbook 1038447100")]
        LiurniaOfTheLakesNorthOfGateTownBridgeDragonCultPrayerbook = 1038447100,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427200")]
        MoonlightAltarCathedralOfManusCelesStarlightShards = 1035427200,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Starlight Shards 1039437100")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthStarlightShards = 1039437100,

        [Annotation(Name = "[Liurnia of the Lakes - Behind Caria Manor] Golden Rune [3] 1036507010")]
        LiurniaOfTheLakesBehindCariaManorGoldenRune3 = 1036507010,

        [Annotation(Name = "[Liurnia of the Lakes - Behind Caria Manor] Thawfrost Boluses 1036507020")]
        LiurniaOfTheLakesBehindCariaManorThawfrostBoluses = 1036507020,

        [Annotation(Name = "[Liurnia of the Lakes - Behind Caria Manor] Albinauric Ashes 1036507030")]
        LiurniaOfTheLakesBehindCariaManorAlbinauricAshes = 1036507030,

        [Annotation(Name = "[Liurnia of the Lakes - Lake-Facing Cliffs] Academy Scroll 1039407000")]
        LiurniaOfTheLakesLakeFacingCliffsAcademyScroll = 1039407000,

        [Annotation(Name = "[Liurnia of the Lakes - West of Church of Irith] Warming Stone 1038397000")]
        LiurniaOfTheLakesWestOfChurchOfIrithWarmingStone = 1038397000,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Lake Shore] Smoldering Butterfly 1038407000")]
        LiurniaOfTheLakesLiurniaLakeShoreSmolderingButterfly = 1038407000,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Lake Shore] Glintstone Craftsman's Cookbook [1] 67410")]
        LiurniaOfTheLakesLiurniaLakeShoreGlintstoneCraftsmansCookbook1 = 67410,

        [Annotation(Name = "[Liurnia of the Lakes - Purified Ruins] Golden Rune [3] 1039417000")]
        LiurniaOfTheLakesPurifiedRuinsGoldenRune3 = 1039417000,

        [Annotation(Name = "[Liurnia of the Lakes - Purified Ruins] Cuckoo Glintstone 1039417010")]
        LiurniaOfTheLakesPurifiedRuinsCuckooGlintstone = 1039417010,

        [Annotation(Name = "[Liurnia of the Lakes - Purified Ruins] Somber Smithing Stone [2] 1039417020")]
        LiurniaOfTheLakesPurifiedRuinsSomberSmithingStone2 = 1039417020,

        [Annotation(Name = "[Liurnia of the Lakes - Purified Ruins] Stormhawk Feather 1039417030")]
        LiurniaOfTheLakesPurifiedRuinsStormhawkFeather = 1039417030,

        [Annotation(Name = "[Liurnia of the Lakes - Purified Ruins] Two Fingers Heirloom 1039417100")]
        LiurniaOfTheLakesPurifiedRuinsTwoFingersHeirloom = 1039417100,

        [Annotation(Name = "[Liurnia of the Lakes - Purified Ruins] Shabriri Grape 1039417200")]
        LiurniaOfTheLakesPurifiedRuinsShabririGrape = 1039417200,

        [Annotation(Name = "[Liurnia of the Lakes - Purified Ruins] Golden Rune [6] 1039417300")]
        LiurniaOfTheLakesPurifiedRuinsGoldenRune6 = 1039417300,

        [Annotation(Name = "[Liurnia of the Lakes - Purified Ruins] Golden Rune [6] 1039417310")]
        LiurniaOfTheLakesPurifiedRuinsGoldenRune6_ = 1039417310,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway North] Mushroom 1039427000")]
        LiurniaOfTheLakesLiurniaHighwayNorthMushroom = 1039427000,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway North] Crystal Dart 1039427010")]
        LiurniaOfTheLakesLiurniaHighwayNorthCrystalDart = 1039427010,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway North] Golden Rune [6] 1039427020")]
        LiurniaOfTheLakesLiurniaHighwayNorthGoldenRune6 = 1039427020,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway North] Golden Rune [3] 1039427030")]
        LiurniaOfTheLakesLiurniaHighwayNorthGoldenRune3 = 1039427030,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway North] Beast Blood 1039427040")]
        LiurniaOfTheLakesLiurniaHighwayNorthBeastBlood = 1039427040,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway North] Lucerne 1039427050")]
        LiurniaOfTheLakesLiurniaHighwayNorthLucerne = 1039427050,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Golden Rune [3] 1037427000")]
        LiurniaOfTheLakesLaskyarRuinsGoldenRune3 = 1037427000,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Glass Shard 1037427030")]
        LiurniaOfTheLakesLaskyarRuinsGlassShard = 1037427030,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Ritual Pot 66420")]
        LiurniaOfTheLakesLaskyarRuinsRitualPot = 66420,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Wraith Calling Bell 1037427900")]
        LiurniaOfTheLakesLaskyarRuinsWraithCallingBell = 1037427900,

        [Annotation(Name = "[Liurnia of the Lakes - South of Mausoleum Compound] Grave Violet 1037477000")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundGraveViolet = 1037477000,

        [Annotation(Name = "[Liurnia of the Lakes - South of Mausoleum Compound] Arteria Leaf 1037477010")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundArteriaLeaf = 1037477010,

        [Annotation(Name = "[Liurnia of the Lakes - South of Mausoleum Compound] Stalwart Horn Charm 1037477020")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundStalwartHornCharm = 1037477020,

        [Annotation(Name = "[Liurnia of the Lakes - South of Mausoleum Compound] Spiralhorn Shield 1037477030")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundSpiralhornShield = 1037477030,

        [Annotation(Name = "[Liurnia of the Lakes - Slumbering Wolf's Shack] Fire Monks' Prayerbook 1036417000")]
        LiurniaOfTheLakesSlumberingWolfsShackFireMonksPrayerbook = 1036417000,

        [Annotation(Name = "[Liurnia of the Lakes - Slumbering Wolf's Shack] Dappled Cured Meat 1036417010")]
        LiurniaOfTheLakesSlumberingWolfsShackDappledCuredMeat = 1036417010,

        [Annotation(Name = "[Liurnia of the Lakes - Slumbering Wolf's Shack] Rune Arc 1036417020")]
        LiurniaOfTheLakesSlumberingWolfsShackRuneArc = 1036417020,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Southwest] Crystal Bud 1036447000")]
        LiurniaOfTheLakesGateTownSouthwestCrystalBud = 1036447000,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Southwest] Arteria Leaf 1036447010")]
        LiurniaOfTheLakesGateTownSouthwestArteriaLeaf = 1036447010,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Southwest] Smithing Stone [2] 1036447040")]
        LiurniaOfTheLakesGateTownSouthwestSmithingStone2 = 1036447040,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Southwest] Shattershard Arrow (Fletched) 1036447050")]
        LiurniaOfTheLakesGateTownSouthwestShattershardArrowFletched = 1036447050,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Southwest] Glintstone Firefly 1036447060")]
        LiurniaOfTheLakesGateTownSouthwestGlintstoneFirefly = 1036447060,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Southwest] Glintstone Craftsman's Cookbook [4] 67400")]
        LiurniaOfTheLakesGateTownSouthwestGlintstoneCraftsmansCookbook4 = 67400,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Northwest] Crystal Cave Moss 1036457020")]
        LiurniaOfTheLakesGateTownNorthwestCrystalCaveMoss = 1036457020,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Northwest] Stonesword Key 1036457110")]
        LiurniaOfTheLakesGateTownNorthwestStoneswordKey = 1036457110,

        [Annotation(Name = "[Liurnia of the Lakes - South Rose Church] Somber Smithing Stone [1] 1035437010")]
        LiurniaOfTheLakesSouthRoseChurchSomberSmithingStone1 = 1035437010,

        [Annotation(Name = "[Liurnia of the Lakes - South Rose Church] Larval Tear 1035437100")]
        LiurniaOfTheLakesSouthRoseChurchLarvalTear = 1035437100,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Smithing Stone [3] 1035447000")]
        LiurniaOfTheLakesNorthRoseChurchSmithingStone3 = 1035447000,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [1] 1035447010")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune1 = 1035447010,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [4] 1035447020")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune4 = 1035447020,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [3] 1035447030")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune3 = 1035447030,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [2] 1035447040")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune2 = 1035447040,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [4] 1035447050")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune4_ = 1035447050,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [2] 1035447060")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune2_ = 1035447060,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [1] 1035447070")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune1_ = 1035447070,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [5] 1035447080")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune5 = 1035447080,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [2] 1035447090")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune2__ = 1035447090,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Golden Rune [3] 1035447100")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune3_ = 1035447100,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Smithing Stone [2] 1035447110")]
        LiurniaOfTheLakesNorthRoseChurchSmithingStone2 = 1035447110,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Blue-White Wooden Shield 1035447120")]
        LiurniaOfTheLakesNorthRoseChurchBlueWhiteWoodenShield = 1035447120,

        [Annotation(Name = "[Liurnia of the Lakes - North Rose Church] Nomadic Warrior's Cookbook [12] 67060")]
        LiurniaOfTheLakesNorthRoseChurchNomadicWarriorsCookbook12 = 67060,

        [Annotation(Name = "[Liurnia of the Lakes - South Raya Lucaria Gate] Celestial Dew 1035457000")]
        LiurniaOfTheLakesSouthRayaLucariaGateCelestialDew = 1035457000,

        [Annotation(Name = "[Liurnia of the Lakes - South Raya Lucaria Gate] Strip of White Flesh 1035457030")]
        LiurniaOfTheLakesSouthRayaLucariaGateStripOfWhiteFlesh = 1035457030,

        [Annotation(Name = "[Liurnia of the Lakes - Main Academy Gate] Stonesword Key 1035467020")]
        LiurniaOfTheLakesMainAcademyGateStoneswordKey = 1035467020,

        [Annotation(Name = "[Liurnia of the Lakes - Main Academy Gate] Ash of War: Raptor of the Mists 1035467700")]
        LiurniaOfTheLakesMainAcademyGateAshOfWarRaptorOfTheMists = 1035467700,

        [Annotation(Name = "[Liurnia of the Lakes - Testu's Rise] Golden Rune [1] 1035477000")]
        LiurniaOfTheLakesTestusRiseGoldenRune1 = 1035477000,

        [Annotation(Name = "[Liurnia of the Lakes - Temple Quarter] Rimed Crystal Bud 1034447000")]
        LiurniaOfTheLakesTempleQuarterRimedCrystalBud = 1034447000,

        [Annotation(Name = "[Liurnia of the Lakes - Temple Quarter] Smithing Stone [2] 1034447010")]
        LiurniaOfTheLakesTempleQuarterSmithingStone2 = 1034447010,

        [Annotation(Name = "[Liurnia of the Lakes - Temple Quarter] Icerind Hatchet 1034447900")]
        LiurniaOfTheLakesTempleQuarterIcerindHatchet = 1034447900,

        [Annotation(Name = "[Liurnia of the Lakes - Church of Vows] Gold Sewing Needle 1037467000")]
        LiurniaOfTheLakesChurchOfVowsGoldSewingNeedle = 1037467000,

        [Annotation(Name = "[Liurnia of the Lakes - Church of Vows] Golden Tailoring Tools 60150")]
        LiurniaOfTheLakesChurchOfVowsGoldenTailoringTools = 60150,

        [Annotation(Name = "[Liurnia of the Lakes - Church of Vows] Stormhawk Feather 1037467010")]
        LiurniaOfTheLakesChurchOfVowsStormhawkFeather = 1037467010,

        [Annotation(Name = "[Liurnia of the Lakes - Highway Lookout Tower] Smithing Stone [2] 1038427000")]
        LiurniaOfTheLakesHighwayLookoutTowerSmithingStone2 = 1038427000,

        [Annotation(Name = "[Liurnia of the Lakes - Highway Lookout Tower] Golden Rune [4] 1038427010")]
        LiurniaOfTheLakesHighwayLookoutTowerGoldenRune4 = 1038427010,

        [Annotation(Name = "[Liurnia of the Lakes - Highway Lookout Tower] Carian Glintblade Staff 1038427020")]
        LiurniaOfTheLakesHighwayLookoutTowerCarianGlintbladeStaff = 1038427020,

        [Annotation(Name = "[Liurnia of the Lakes - Highway Lookout Tower] Glintstone Craftsman's Cookbook [3] 67480")]
        LiurniaOfTheLakesHighwayLookoutTowerGlintstoneCraftsmansCookbook3 = 67480,

        [Annotation(Name = "[Liurnia of the Lakes - Testu's Rise] Smithing Stone [2] 1035477010")]
        LiurniaOfTheLakesTestusRiseSmithingStone2 = 1035477010,

        [Annotation(Name = "[Liurnia of the Lakes - Testu's Rise] Memory Stone 60420")]
        LiurniaOfTheLakesTestusRiseMemoryStone = 60420,

        [Annotation(Name = "[Bellum Highway - Converted Fringe Tower] Crystal Dart 1039487000")]
        BellumHighwayConvertedFringeTowerCrystalDart = 1039487000,

        [Annotation(Name = "[Bellum Highway - Converted Fringe Tower] Cannon of Haima 1039487100")]
        BellumHighwayConvertedFringeTowerCannonOfHaima = 1039487100,

        [Annotation(Name = "[Moonlight Altar] Ranni's Dark Moon 1033407100")]
        MoonlightAltarRannisDarkMoon = 1033407100,

        [Annotation(Name = "[Liurnia of the Lakes - Foot of the Four Belfries] Strip of White Flesh 1033467000")]
        LiurniaOfTheLakesFootOfTheFourBelfriesStripOfWhiteFlesh = 1033467000,

        [Annotation(Name = "[Liurnia of the Lakes - Foot of the Four Belfries] Blood Grease 1033467030")]
        LiurniaOfTheLakesFootOfTheFourBelfriesBloodGrease = 1033467030,

        [Annotation(Name = "[Liurnia of the Lakes - Foot of the Four Belfries] Jellyfish Shield 1033467040")]
        LiurniaOfTheLakesFootOfTheFourBelfriesJellyfishShield = 1033467040,

        [Annotation(Name = "[Liurnia of the Lakes - The Four Belfries] Imbued Sword Key 1033477020")]
        LiurniaOfTheLakesTheFourBelfriesImbuedSwordKey = 1033477020,

        [Annotation(Name = "[Liurnia of the Lakes - The Four Belfries] Albinauric Bloodclot 1033477900")]
        LiurniaOfTheLakesTheFourBelfriesAlbinauricBloodclot = 1033477900,

        [Annotation(Name = "[Liurnia of the Lakes - The Four Belfries] Cuckoo Glintstone 1033477910")]
        LiurniaOfTheLakesTheFourBelfriesCuckooGlintstone = 1033477910,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [3] 1034507010")]
        LiurniaOfTheLakesRannisRiseGoldenRune3 = 1034507010,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [4] 1034507020")]
        LiurniaOfTheLakesRannisRiseGoldenRune4 = 1034507020,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [5] 1034507030")]
        LiurniaOfTheLakesRannisRiseGoldenRune5 = 1034507030,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [1] 1034507040")]
        LiurniaOfTheLakesRannisRiseGoldenRune1 = 1034507040,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [3] 1034507050")]
        LiurniaOfTheLakesRannisRiseGoldenRune3_ = 1034507050,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [3] 1034507060")]
        LiurniaOfTheLakesRannisRiseGoldenRune3__ = 1034507060,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [2] 1034507070")]
        LiurniaOfTheLakesRannisRiseGoldenRune2 = 1034507070,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] Golden Rune [3] 1034507080")]
        LiurniaOfTheLakesRannisRiseGoldenRune3___ = 1034507080,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] Black Wolf Mask 1034507090")]
        LiurniaOfTheLakesRannisRiseBlackWolfMask = 1034507090,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] Memory Stone 60430")]
        LiurniaOfTheLakesRannisRiseMemoryStone = 60430,

        [Annotation(Name = "[Liurnia of the Lakes - Ranni's Rise] 1034507200")]
        LiurniaOfTheLakesRannisRise = 1034507200,

        [Annotation(Name = "[Liurnia of the Lakes - Renna's Rise] Snow Witch Skirt 1034517900")]
        LiurniaOfTheLakesRennasRiseSnowWitchSkirt = 1034517900,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Throwing Dagger 1034477000")]
        LiurniaOfTheLakesSorcerersIsleWestThrowingDagger = 1034477000,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [2] 1034477500")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune2 = 1034477500,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [1] 1034477110")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune1 = 1034477110,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [3] 1034477120")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3 = 1034477120,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [3] 1034477130")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3_ = 1034477130,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [1] 1034477140")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune1_ = 1034477140,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [5] 1034477150")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune5 = 1034477150,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [3] 1034477160")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3__ = 1034477160,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [2] 1034477170")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune2_ = 1034477170,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [3] 1034477180")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3___ = 1034477180,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [3] 1034477190")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3____ = 1034477190,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [4] 1034477200")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune4 = 1034477200,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [2] 1034477210")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune2__ = 1034477210,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [4] 1034477220")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune4_ = 1034477220,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [6] 1034477300")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune6 = 1034477300,

        [Annotation(Name = "[Liurnia of the Lakes - Sorcerer's Isle West] Golden Rune [6] 1034477310")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune6_ = 1034477310,

        [Annotation(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Golden Rune [6] 1034487300")]
        LiurniaOfTheLakesKingsrealmRuinsGoldenRune6 = 1034487300,

        [Annotation(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Golden Rune [6] 1034487310")]
        LiurniaOfTheLakesKingsrealmRuinsGoldenRune6_ = 1034487310,

        [Annotation(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Rimed Crystal Bud 1034487000")]
        LiurniaOfTheLakesKingsrealmRuinsRimedCrystalBud = 1034487000,

        [Annotation(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Glintstone Firefly 1034487010")]
        LiurniaOfTheLakesKingsrealmRuinsGlintstoneFirefly = 1034487010,

        [Annotation(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Frozen Needle 1034487100")]
        LiurniaOfTheLakesKingsrealmRuinsFrozenNeedle = 1034487100,

        [Annotation(Name = "[Liurnia of the Lakes - Artist's Shack] Smoldering Butterfly 1038457000")]
        LiurniaOfTheLakesArtistsShackSmolderingButterfly = 1038457000,

        [Annotation(Name = "[Liurnia of the Lakes - Artist's Shack] Flame, Cleanse Me 1038457010")]
        LiurniaOfTheLakesArtistsShackFlameCleanseMe = 1038457010,

        [Annotation(Name = "[Liurnia of the Lakes - Artist's Shack] Smithing Stone [4] 1038457020")]
        LiurniaOfTheLakesArtistsShackSmithingStone4 = 1038457020,

        [Annotation(Name = "[Bellum Highway - Frenzied Flame Village] Frenzied's Cookbook [1] 68400")]
        BellumHighwayFrenziedFlameVillageFrenziedsCookbook1 = 68400,

        [Annotation(Name = "[Bellum Highway - Frenzied Flame Village] Eye of Yelough 1038487020")]
        BellumHighwayFrenziedFlameVillageEyeOfYelough = 1038487020,

        [Annotation(Name = "[Bellum Highway - Frenzied Flame Village] Stonesword Key 1038487030")]
        BellumHighwayFrenziedFlameVillageStoneswordKey = 1038487030,

        [Annotation(Name = "[Bellum Highway - Frenzied Flame Village] Note: The Lord of Frenzied Flame 69760")]
        BellumHighwayFrenziedFlameVillageNoteTheLordOfFrenziedFlame = 69760,

        [Annotation(Name = "[Bellum Highway - Frenzied Flame Village] Shabriri's Woe 1038487100")]
        BellumHighwayFrenziedFlameVillageShabririsWoe = 1038487100,

        [Annotation(Name = "[Bellum Highway - Frenzied Flame Village] Eye of Yelough 1038487120")]
        BellumHighwayFrenziedFlameVillageEyeOfYelough_ = 1038487120,

        [Annotation(Name = "[Bellum Highway - Frenzied Flame Village] Frenzyflame Stone 1038487130")]
        BellumHighwayFrenziedFlameVillageFrenzyflameStone = 1038487130,

        [Annotation(Name = "[Liurnia of the Lakes - Ravine-Veiled Village] Smithing Stone [5] 1038507000")]
        LiurniaOfTheLakesRavineVeiledVillageSmithingStone5 = 1038507000,

        [Annotation(Name = "[Liurnia of the Lakes - Ravine-Veiled Village] Dragonwound Grease 1038507010")]
        LiurniaOfTheLakesRavineVeiledVillageDragonwoundGrease = 1038507010,

        [Annotation(Name = "[Bellum Highway - Church of Inhibition] Cuckoo Glintstone 1037497000")]
        BellumHighwayChurchOfInhibitionCuckooGlintstone = 1037497000,

        [Annotation(Name = "[Bellum Highway - Church of Inhibition] Rune Arc 1037497010")]
        BellumHighwayChurchOfInhibitionRuneArc = 1037497010,

        [Annotation(Name = "[Bellum Highway - Church of Inhibition] Finger Maiden Fillet 1037497030")]
        BellumHighwayChurchOfInhibitionFingerMaidenFillet = 1037497030,

        [Annotation(Name = "[Bellum Highway - Church of Inhibition] Great Mace 1037497200")]
        BellumHighwayChurchOfInhibitionGreatMace = 1037497200,

        [Annotation(Name = "[Bellum Highway - Church of Inhibition] Fingerprint Grape 1037497300")]
        BellumHighwayChurchOfInhibitionFingerprintGrape = 1037497300,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [2] 1039437010")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune2 = 1039437010,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [6] 1039437020")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune6 = 1039437020,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [1] 1039437030")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune1 = 1039437030,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [3] 1039437040")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune3 = 1039437040,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [2] 1039437050")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune2_ = 1039437050,

        [Annotation(Name = "[Liurnia of the Lakes - Liurnia Highway Far North] Golden Rune [3] 1039437060")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune3_ = 1039437060,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Bridge] Strip of White Flesh 1038437000")]
        LiurniaOfTheLakesGateTownBridgeStripOfWhiteFlesh = 1038437000,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Bridge] Sliver of Meat 1038437010")]
        LiurniaOfTheLakesGateTownBridgeSliverOfMeat = 1038437010,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Bridge] Silver-Pickled Fowl Foot 1038437020")]
        LiurniaOfTheLakesGateTownBridgeSilverPickledFowlFoot = 1038437020,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Bridge] Golden Rune [6] 1038437100")]
        LiurniaOfTheLakesGateTownBridgeGoldenRune6 = 1038437100,

        [Annotation(Name = "[Liurnia of the Lakes - South of Scenic Isle] Ballista Bolt 1037417010")]
        LiurniaOfTheLakesSouthOfScenicIsleBallistaBolt = 1037417010,

        [Annotation(Name = "[Liurnia of the Lakes - North of Scenic Isle] Golden Rune [3] 1037437000")]
        LiurniaOfTheLakesNorthOfScenicIsleGoldenRune3 = 1037437000,

        [Annotation(Name = "[Liurnia of the Lakes - North of Scenic Isle] Smithing Stone [3] 1037437010")]
        LiurniaOfTheLakesNorthOfScenicIsleSmithingStone3 = 1037437010,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Southeast] Golden Rune [4] 1037447000")]
        LiurniaOfTheLakesGateTownSoutheastGoldenRune4 = 1037447000,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Southeast] Magic Grease 1037447010")]
        LiurniaOfTheLakesGateTownSoutheastMagicGrease = 1037447010,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Northeast] Smithing Stone [3] 1037457100")]
        LiurniaOfTheLakesGateTownNortheastSmithingStone3 = 1037457100,

        [Annotation(Name = "[Liurnia of the Lakes - Boilprawn Shack] Smithing Stone [2] 1036437000")]
        LiurniaOfTheLakesBoilprawnShackSmithingStone2 = 1036437000,

        [Annotation(Name = "[Liurnia of the Lakes - Boilprawn Shack] Confessor Hood 1036437010")]
        LiurniaOfTheLakesBoilprawnShackConfessorHood = 1036437010,

        [Annotation(Name = "[Liurnia of the Lakes - Boilprawn Shack] Tarnished Golden Sunflower 1036437020")]
        LiurniaOfTheLakesBoilprawnShackTarnishedGoldenSunflower = 1036437020,

        [Annotation(Name = "[Liurnia of the Lakes - Boilprawn Shack] Rainbow Stone 1036437030")]
        LiurniaOfTheLakesBoilprawnShackRainbowStone = 1036437030,

        [Annotation(Name = "[Liurnia of the Lakes - Jarburg] Smithing Stone [3] 1039447000")]
        LiurniaOfTheLakesJarburgSmithingStone3 = 1039447000,

        [Annotation(Name = "[Liurnia of the Lakes - Jarburg] Great Dragonfly Head 1039447010")]
        LiurniaOfTheLakesJarburgGreatDragonflyHead = 1039447010,

        [Annotation(Name = "[Liurnia of the Lakes - Jarburg] Trina's Lily 1039447020")]
        LiurniaOfTheLakesJarburgTrinasLily = 1039447020,

        [Annotation(Name = "[Liurnia of the Lakes - Jarburg] Smithing Stone [3] 1039447030")]
        LiurniaOfTheLakesJarburgSmithingStone3_ = 1039447030,

        [Annotation(Name = "[Liurnia of the Lakes - Jarburg] Living Jar Shard 1039447040")]
        LiurniaOfTheLakesJarburgLivingJarShard = 1039447040,

        [Annotation(Name = "[Liurnia of the Lakes - Jarburg] Cracked Pot 66080")]
        LiurniaOfTheLakesJarburgCrackedPot = 66080,

        [Annotation(Name = "[Liurnia of the Lakes - Jarburg] Cracked Pot 66090")]
        LiurniaOfTheLakesJarburgCrackedPot_ = 66090,

        [Annotation(Name = "[Liurnia of the Lakes - Jarburg] Cracked Pot 66100")]
        LiurniaOfTheLakesJarburgCrackedPot__ = 66100,

        [Annotation(Name = "[Liurnia of the Lakes - Jarburg] Ritual Pot 66430")]
        LiurniaOfTheLakesJarburgRitualPot = 66430,

        [Annotation(Name = "[Liurnia of the Lakes - Jarburg] Ritual Pot 66440")]
        LiurniaOfTheLakesJarburgRitualPot_ = 66440,

        [Annotation(Name = "[Liurnia of the Lakes - Crystalline Woods] Smithing Stone [3] 1034467100")]
        LiurniaOfTheLakesCrystallineWoodsSmithingStone3 = 1034467100,

        [Annotation(Name = "[Liurnia of the Lakes - Meeting Place] Dragonwound Grease 1034457010")]
        LiurniaOfTheLakesMeetingPlaceDragonwoundGrease = 1034457010,

        [Annotation(Name = "[Liurnia of the Lakes - Meeting Place] Kukri 1034457020")]
        LiurniaOfTheLakesMeetingPlaceKukri = 1034457020,

        [Annotation(Name = "[Liurnia of the Lakes - Meeting Place] Academy Glintstone Key 1034457100")]
        LiurniaOfTheLakesMeetingPlaceAcademyGlintstoneKey = 1034457100,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Smithing Stone [3] 1037427010")]
        LiurniaOfTheLakesLaskyarRuinsSmithingStone3 = 1037427010,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Nomadic Warrior's Cookbook [11] 67220")]
        LiurniaOfTheLakesLaskyarRuinsNomadicWarriorsCookbook11 = 67220,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Smithing Stone [2] 1035427010")]
        MoonlightAltarCathedralOfManusCelesSmithingStone2 = 1035427010,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Rune Arc 1035427030")]
        MoonlightAltarCathedralOfManusCelesRuneArc = 1035427030,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Ivory Sickle 1035427040")]
        MoonlightAltarCathedralOfManusCelesIvorySickle = 1035427040,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427100")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_ = 1035427100,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427110")]
        MoonlightAltarCathedralOfManusCelesStarlightShards__ = 1035427110,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427120")]
        MoonlightAltarCathedralOfManusCelesStarlightShards___ = 1035427120,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427130")]
        MoonlightAltarCathedralOfManusCelesStarlightShards____ = 1035427130,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427140")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_____ = 1035427140,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427150")]
        MoonlightAltarCathedralOfManusCelesStarlightShards______ = 1035427150,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427160")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_______ = 1035427160,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427170")]
        MoonlightAltarCathedralOfManusCelesStarlightShards________ = 1035427170,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427180")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_________ = 1035427180,

        [Annotation(Name = "[Moonlight Altar - Cathedral of Manus Celes] Starlight Shards 1035427190")]
        MoonlightAltarCathedralOfManusCelesStarlightShards__________ = 1035427190,

        [Annotation(Name = "[Liurnia of the Lakes - South Raya Lucaria Gate] Meeting Place Map 1035457100")]
        LiurniaOfTheLakesSouthRayaLucariaGateMeetingPlaceMap = 1035457100,

        [Annotation(Name = "[Liurnia of the Lakes - South of Caria Manor] Somber Smithing Stone [4] 1035497020")]
        LiurniaOfTheLakesSouthOfCariaManorSomberSmithingStone4 = 1035497020,

        [Annotation(Name = "[Liurnia of the Lakes - North of Sorcerer's Isle] Old Fang 1035487010")]
        LiurniaOfTheLakesNorthOfSorcerersIsleOldFang = 1035487010,

        [Annotation(Name = "[Liurnia of the Lakes - North of Sorcerer's Isle] Soporific Grease 1035487020")]
        LiurniaOfTheLakesNorthOfSorcerersIsleSoporificGrease = 1035487020,

        [Annotation(Name = "[Liurnia of the Lakes - North of Sorcerer's Isle] Lump of Flesh 1035487030")]
        LiurniaOfTheLakesNorthOfSorcerersIsleLumpOfFlesh = 1035487030,

        [Annotation(Name = "[Liurnia of the Lakes - North of Sorcerer's Isle] Golden Rune [6] 1035487100")]
        LiurniaOfTheLakesNorthOfSorcerersIsleGoldenRune6 = 1035487100,

        [Annotation(Name = "[Bellum Highway - East Raya Lucaria Gate] Sanctuary Stone 1036487000")]
        BellumHighwayEastRayaLucariaGateSanctuaryStone = 1036487000,

        [Annotation(Name = "[Bellum Highway - East Raya Lucaria Gate] Golden Rune [1] 1036487100")]
        BellumHighwayEastRayaLucariaGateGoldenRune1 = 1036487100,

        [Annotation(Name = "[Liurnia of the Lakes - Mausoleum Compound] Slumbering Egg 1037487000")]
        LiurniaOfTheLakesMausoleumCompoundSlumberingEgg = 1037487000,

        [Annotation(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [3] 1037487010")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3 = 1037487010,

        [Annotation(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [3] 1037487020")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3_ = 1037487020,

        [Annotation(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [1] 1037487030")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune1 = 1037487030,

        [Annotation(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [7] 1037487040")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune7 = 1037487040,

        [Annotation(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [3] 1037487050")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3__ = 1037487050,

        [Annotation(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [2] 1037487060")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune2 = 1037487060,

        [Annotation(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [4] 1037487070")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune4 = 1037487070,

        [Annotation(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [3] 1037487080")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3___ = 1037487080,

        [Annotation(Name = "[Liurnia of the Lakes - Mausoleum Compound] Golden Rune [1] 1037487100")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune1_ = 1037487100,

        [Annotation(Name = "[Liurnia of the Lakes - The Four Belfries] Somber Smithing Stone [3] 1033477000")]
        LiurniaOfTheLakesTheFourBelfriesSomberSmithingStone3 = 1033477000,

        [Annotation(Name = "[Liurnia of the Lakes - The Four Belfries] Smithing Stone [4] 1033477010")]
        LiurniaOfTheLakesTheFourBelfriesSmithingStone4 = 1033477010,

        [Annotation(Name = "[Liurnia of the Lakes - The Four Belfries] Rune Arc 1033477030")]
        LiurniaOfTheLakesTheFourBelfriesRuneArc = 1033477030,

        [Annotation(Name = "[Liurnia of the Lakes - The Four Belfries] Carian Knight's Sword 1033477200")]
        LiurniaOfTheLakesTheFourBelfriesCarianKnightsSword = 1033477200,

        [Annotation(Name = "[Liurnia of the Lakes - Ruined Labyrinth] Frenzyflame Stone 1038477010")]
        LiurniaOfTheLakesRuinedLabyrinthFrenzyflameStone = 1038477010,

        [Annotation(Name = "[Liurnia of the Lakes - Ruined Labyrinth] Stonesword Key 1038477030")]
        LiurniaOfTheLakesRuinedLabyrinthStoneswordKey = 1038477030,

        [Annotation(Name = "[Liurnia of the Lakes - Ruined Labyrinth] Golden Rune [1] 1038477100")]
        LiurniaOfTheLakesRuinedLabyrinthGoldenRune1 = 1038477100,

        [Annotation(Name = "[Liurnia of the Lakes - North of Gate Town Bridge] Smithing Stone [3] 1038447030")]
        LiurniaOfTheLakesNorthOfGateTownBridgeSmithingStone3 = 1038447030,

        [Annotation(Name = "[Liurnia of the Lakes - North of Gate Town Bridge] Land Squirt Ashes 1038447040")]
        LiurniaOfTheLakesNorthOfGateTownBridgeLandSquirtAshes = 1038447040,

        [Annotation(Name = "[Liurnia - Liurnia Highway South Endpoint] Treespear 1040407000")]
        LiurniaLiurniaHighwaySouthEndpointTreespear = 1040407000,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Glintstone Craftsman's Cookbook [2] 67450")]
        LiurniaOfTheLakesLaskyarRuinsGlintstoneCraftsmansCookbook2 = 67450,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Sacrificial Twig 1038417010")]
        LiurniaOfTheLakesLaskyarRuinsSacrificialTwig = 1038417010,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Gravitas 1038417100")]
        LiurniaOfTheLakesLaskyarRuinsGravitas = 1038417100,

        [Annotation(Name = "[Liurnia of the Lakes - Cuckoo's Evergaol] Dragonscale Blade 1033457100")]
        LiurniaOfTheLakesCuckoosEvergaolDragonscaleBlade = 1033457100,

        [Annotation(Name = "[Liurnia of the Lakes - Bellum Highway] Somber Smithing Stone [3] 1036477000")]
        LiurniaOfTheLakesBellumHighwaySomberSmithingStone3 = 1036477000,

        [Annotation(Name = "[Liurnia of the Lakes - Bellum Highway] Golden Rune [1] 1036477100")]
        LiurniaOfTheLakesBellumHighwayGoldenRune1 = 1036477100,

        [Annotation(Name = "[Moonlight Altar - Moonfolk Ruins] Albinauric Bloodclot 1034427020")]
        MoonlightAltarMoonfolkRuinsAlbinauricBloodclot = 1034427020,

        [Annotation(Name = "[Moonlight Altar - Moonfolk Ruins] Smithing Stone [2] 1034427030")]
        MoonlightAltarMoonfolkRuinsSmithingStone2 = 1034427030,

        [Annotation(Name = "[Moonlight Altar - Moonfolk Ruins] Crystal Sword 1034427050")]
        MoonlightAltarMoonfolkRuinsCrystalSword = 1034427050,

        [Annotation(Name = "[Moonlight Altar - Moonfolk Ruins] Larval Tear 1034427060")]
        MoonlightAltarMoonfolkRuinsLarvalTear = 1034427060,

        [Annotation(Name = "[Liurnia of the Lakes - Converted Tower] Magic Grease 1034437000")]
        LiurniaOfTheLakesConvertedTowerMagicGrease = 1034437000,

        [Annotation(Name = "[Liurnia of the Lakes - Converted Tower] Memory Stone 60410")]
        LiurniaOfTheLakesConvertedTowerMemoryStone = 60410,

        [Annotation(Name = "[Liurnia of the Lakes - Converted Tower] Golden Rune [6] 1034437200")]
        LiurniaOfTheLakesConvertedTowerGoldenRune6 = 1034437200,

        [Annotation(Name = "[Liurnia of the Lakes - Converted Tower] Cuckoo Glintstone 1034437300")]
        LiurniaOfTheLakesConvertedTowerCuckooGlintstone = 1034437300,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Rune Arc 1035507000")]
        LiurniaOfTheLakesCariaManorRuneArc = 1035507000,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Golden Rune [4] 1035507010")]
        LiurniaOfTheLakesCariaManorGoldenRune4 = 1035507010,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Stonesword Key 1035507020")]
        LiurniaOfTheLakesCariaManorStoneswordKey = 1035507020,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Slumbering Egg 1035507030")]
        LiurniaOfTheLakesCariaManorSlumberingEgg = 1035507030,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Glintstone Craftsman's Cookbook [6] 67460")]
        LiurniaOfTheLakesCariaManorGlintstoneCraftsmansCookbook6 = 67460,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Somber Smithing Stone [3] 1035507050")]
        LiurniaOfTheLakesCariaManorSomberSmithingStone3 = 1035507050,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Golden Rune [3] 1035507060")]
        LiurniaOfTheLakesCariaManorGoldenRune3 = 1035507060,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Crystal Dart 1035507070")]
        LiurniaOfTheLakesCariaManorCrystalDart = 1035507070,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Smithing Stone [4] 1035507080")]
        LiurniaOfTheLakesCariaManorSmithingStone4 = 1035507080,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Ash of War: Carian Grandeur 1035507090")]
        LiurniaOfTheLakesCariaManorAshOfWarCarianGrandeur = 1035507090,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Somber Smithing Stone [3] 1035507100")]
        LiurniaOfTheLakesCariaManorSomberSmithingStone3_ = 1035507100,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Spellproof Dried Liver 1035507110")]
        LiurniaOfTheLakesCariaManorSpellproofDriedLiver = 1035507110,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507120")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud = 1035507120,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Smithing Stone [2] 1035507130")]
        LiurniaOfTheLakesCariaManorSmithingStone2 = 1035507130,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Smithing Stone [4] 1035507140")]
        LiurniaOfTheLakesCariaManorSmithingStone4_ = 1035507140,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Urumi 1035507150")]
        LiurniaOfTheLakesCariaManorUrumi = 1035507150,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Smithing Stone [3] 1035507160")]
        LiurniaOfTheLakesCariaManorSmithingStone3 = 1035507160,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Golden Rune [4] 1035507170")]
        LiurniaOfTheLakesCariaManorGoldenRune4_ = 1035507170,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Old Fang 1035507180")]
        LiurniaOfTheLakesCariaManorOldFang = 1035507180,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Glintstone Firefly 1035507190")]
        LiurniaOfTheLakesCariaManorGlintstoneFirefly = 1035507190,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Ice Crest Shield 1035507200")]
        LiurniaOfTheLakesCariaManorIceCrestShield = 1035507200,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Magic Grease 1035507220")]
        LiurniaOfTheLakesCariaManorMagicGrease = 1035507220,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507230")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud_ = 1035507230,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507240")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud__ = 1035507240,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507250")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud___ = 1035507250,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507260")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud____ = 1035507260,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507270")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud_____ = 1035507270,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Rimed Crystal Bud 1035507280")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud______ = 1035507280,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Golden Seed 1035507300")]
        LiurniaOfTheLakesCariaManorGoldenSeed = 1035507300,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Cracked Pot 66110")]
        LiurniaOfTheLakesCariaManorCrackedPot = 66110,

        [Annotation(Name = "[Liurnia of the Lakes - Caria Manor] Sword of Night and Flame 1035507900")]
        LiurniaOfTheLakesCariaManorSwordOfNightandFlame = 1035507900,

        [Annotation(Name = "[Bellum Highway - Church of Inhibition] Rune Arc 1037497020")]
        BellumHighwayChurchOfInhibitionRuneArc_ = 1037497020,

        [Annotation(Name = "[Liurnia of the Lakes - Eastern Tableland] Immunizing White Cured Meat 1038467000")]
        LiurniaOfTheLakesEasternTablelandImmunizingWhiteCuredMeat = 1038467000,

        [Annotation(Name = "[Liurnia of the Lakes - Eastern Tableland] Golden Rune [1] 1038467400")]
        LiurniaOfTheLakesEasternTablelandGoldenRune1 = 1038467400,

        [Annotation(Name = "[Bellum Highway - Frenzy-Flaming Tower] Yellow Ember 1038497000")]
        BellumHighwayFrenzyFlamingTowerYellowEmber = 1038497000,

        [Annotation(Name = "[Bellum Highway - Frenzy-Flaming Tower] Smithing Stone [2] 1038497010")]
        BellumHighwayFrenzyFlamingTowerSmithingStone2 = 1038497010,

        [Annotation(Name = "[Bellum Highway - Frenzy-Flaming Tower] Burred Bolt 1038497030")]
        BellumHighwayFrenzyFlamingTowerBurredBolt = 1038497030,

        [Annotation(Name = "[Bellum Highway - Frenzy-Flaming Tower] Golden Rune [3] 1038497040")]
        BellumHighwayFrenzyFlamingTowerGoldenRune3 = 1038497040,

        [Annotation(Name = "[Bellum Highway - Frenzy-Flaming Tower] Howl of Shabriri 1038497900")]
        BellumHighwayFrenzyFlamingTowerHowlOfShabriri = 1038497900,

        [Annotation(Name = "[Moonlight Altar] Smithing Stone [7] 1033417000")]
        MoonlightAltarSmithingStone7 = 1033417000,

        [Annotation(Name = "[Moonlight Altar] Smithing Stone [8] 1033417010")]
        MoonlightAltarSmithingStone8 = 1033417010,

        [Annotation(Name = "[Moonlight Altar] Smithing Stone [7] 1033417020")]
        MoonlightAltarSmithingStone7_ = 1033417020,

        [Annotation(Name = "[Moonlight Altar] Dragon Heart 1033417400")]
        MoonlightAltarDragonHeart = 1033417400,

        [Annotation(Name = "[Moonlight Altar] Dragon Heart 1033417410")]
        MoonlightAltarDragonHeart_ = 1033417410,

        [Annotation(Name = "[Liurnia of the Lakes - Revenger's Shack] Raw Meat Dumpling 1033447000")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling = 1033447000,

        [Annotation(Name = "[Liurnia of the Lakes - Revenger's Shack] Raw Meat Dumpling 1033447010")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling_ = 1033447010,

        [Annotation(Name = "[Liurnia of the Lakes - Revenger's Shack] Raw Meat Dumpling 1033447020")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling__ = 1033447020,

        [Annotation(Name = "[Liurnia of the Lakes - Revenger's Shack] Raw Meat Dumpling 1033447030")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling___ = 1033447030,

        [Annotation(Name = "[Liurnia of the Lakes - Revenger's Shack] Raw Meat Dumpling 1033447040")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling____ = 1033447040,

        [Annotation(Name = "[Moonlight Altar - Deep Ainsel Well] Gravel Stone 1034417000")]
        MoonlightAltarDeepAinselWellGravelStone = 1034417000,

        [Annotation(Name = "[Moonlight Altar - Moonfolk Ruins] Golden Rune [9] 1034427000")]
        MoonlightAltarMoonfolkRuinsGoldenRune9 = 1034427000,

        [Annotation(Name = "[Moonlight Altar - Moonfolk Ruins] Magic Grease 1034427010")]
        MoonlightAltarMoonfolkRuinsMagicGrease = 1034427010,

        [Annotation(Name = "[Moonlight Altar - Moonfolk Ruins] Rune Arc 1034427040")]
        MoonlightAltarMoonfolkRuinsRuneArc = 1034427040,

        [Annotation(Name = "[Moonlight Altar - Moonfolk Ruins] Somber Smithing Stone [8] 1034427100")]
        MoonlightAltarMoonfolkRuinsSomberSmithingStone8 = 1034427100,

        [Annotation(Name = "[Moonlight Altar - Moonfolk Ruins] Dragon Heart 1034427400")]
        MoonlightAltarMoonfolkRuinsDragonHeart = 1034427400,

        [Annotation(Name = "[Moonlight Altar - Lunar Estate Ruins] Golden Rune [10] 1035417000")]
        MoonlightAltarLunarEstateRuinsGoldenRune10 = 1035417000,

        [Annotation(Name = "[Moonlight Altar - Lunar Estate Ruins] Glintstone Firefly 1035417010")]
        MoonlightAltarLunarEstateRuinsGlintstoneFirefly = 1035417010,

        [Annotation(Name = "[Moonlight Altar - Lunar Estate Ruins] Cerulean Amber Medallion +2 1035417100")]
        MoonlightAltarLunarEstateRuinsCeruleanAmberMedallion2 = 1035417100,

        [Annotation(Name = "[Moonlight Altar - Lunar Estate Ruins] Smithing Stone [8] 1035417110")]
        MoonlightAltarLunarEstateRuinsSmithingStone8 = 1035417110,

        [Annotation(Name = "[Liurnia of the Lakes - Laskyar Ruins] Map: Liurnia, East 62020")]
        LiurniaOfTheLakesLaskyarRuinsMapLiurniaEast = 62020,

        [Annotation(Name = "[Liurnia of the Lakes - Gate Town Southeast] Map: Liurnia, North 62021")]
        LiurniaOfTheLakesGateTownSoutheastMapLiurniaNorth = 62021,

        [Annotation(Name = "[Liurnia of the Lakes - Kingsrealm Ruins] Map: Liurnia, West 62022")]
        LiurniaOfTheLakesKingsrealmRuinsMapLiurniaWest = 62022,

        [Annotation(Name = "[Mt. Gelmir - Before Hermit Shack] Golden Rune [2] 1035527010")]
        MtGelmirBeforeHermitShackGoldenRune2 = 1035527010,

        [Annotation(Name = "[Mt. Gelmir - Before Hermit Shack] Golden Rune [4] 1035527020")]
        MtGelmirBeforeHermitShackGoldenRune4 = 1035527020,

        [Annotation(Name = "[Mt. Gelmir - Before Hermit Shack] Golden Rune [2] 1035527030")]
        MtGelmirBeforeHermitShackGoldenRune2_ = 1035527030,

        [Annotation(Name = "[Mt. Gelmir - Before Hermit Shack] Golden Rune [6] 1035527040")]
        MtGelmirBeforeHermitShackGoldenRune6 = 1035527040,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Terminus] Smoldering Butterfly 1035537000")]
        MtGelmirSeethewaterTerminusSmolderingButterfly = 1035537000,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Terminus] Golden Rune [3] 1035537010")]
        MtGelmirSeethewaterTerminusGoldenRune3 = 1035537010,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Terminus] Mushroom 1035537020")]
        MtGelmirSeethewaterTerminusMushroom = 1035537020,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Terminus] Smoldering Butterfly 1035537030")]
        MtGelmirSeethewaterTerminusSmolderingButterfly_ = 1035537030,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Terminus] Smoldering Butterfly 1035537040")]
        MtGelmirSeethewaterTerminusSmolderingButterfly__ = 1035537040,

        [Annotation(Name = "[Mt. Gelmir - Seethewater Terminus] Golden Rune [5] 1035537050")]
        MtGelmirSeethewaterTerminusGoldenRune5 = 1035537050,

        [Annotation(Name = "[Mt. Gelmir - Fort Laiedd] Dragonwound Grease 1035547000")]
        MtGelmirFortLaieddDragonwoundGrease = 1035547000,

        [Annotation(Name = "[Mt. Gelmir - Fort Laiedd] Golden Rune [3] 1035547010")]
        MtGelmirFortLaieddGoldenRune3 = 1035547010,

        [Annotation(Name = "[Mt. Gelmir - Fort Laiedd] Stonesword Key 1035547020")]
        MtGelmirFortLaieddStoneswordKey = 1035547020,

        [Annotation(Name = "[Mt. Gelmir - Fort Laiedd] Armorer's Cookbook [7] 67250")]
        MtGelmirFortLaieddArmorersCookbook7 = 67250,

        [Annotation(Name = "[Mt. Gelmir - Fort Laiedd] Fire Scorpion Charm 1035547050")]
        MtGelmirFortLaieddFireScorpionCharm = 1035547050,

        [Annotation(Name = "[Mt. Gelmir - Fort Laiedd] Golden Rune [8] 1035547060")]
        MtGelmirFortLaieddGoldenRune8 = 1035547060,

        [Annotation(Name = "[Mt. Gelmir - Fort Laiedd] Slumbering Egg 1035547070")]
        MtGelmirFortLaieddSlumberingEgg = 1035547070,

        [Annotation(Name = "[Altus Plateau - Perfumer's Ruins] Golden Rune [5] 1036517000")]
        AltusPlateauPerfumersRuinsGoldenRune5 = 1036517000,

        [Annotation(Name = "[Altus Plateau - Perfumer's Ruins] Perfumer's Cookbook [1] 67840")]
        AltusPlateauPerfumersRuinsPerfumersCookbook1 = 67840,

        [Annotation(Name = "[Altus Plateau - Perfumer's Ruins] Perfume Bottle 66730")]
        AltusPlateauPerfumersRuinsPerfumeBottle = 66730,

        [Annotation(Name = "[Mt. Gelmir - Craftsman's Shack] Smithing Stone [6] 1036527000")]
        MtGelmirCraftsmansShackSmithingStone6 = 1036527000,

        [Annotation(Name = "[Mt. Gelmir - Craftsman's Shack] Perfumer's Talisman 1036527010")]
        MtGelmirCraftsmansShackPerfumersTalisman = 1036527010,

        [Annotation(Name = "[Mt. Gelmir - Craftsman's Shack] Budding Cave Moss 1036527020")]
        MtGelmirCraftsmansShackBuddingCaveMoss = 1036527020,

        [Annotation(Name = "[Mt. Gelmir - Craftsman's Shack] Nascent Butterfly 1036527030")]
        MtGelmirCraftsmansShackNascentButterfly = 1036527030,

        [Annotation(Name = "[Mt. Gelmir - Craftsman's Shack] Gravel Stone 1036527040")]
        MtGelmirCraftsmansShackGravelStone = 1036527040,

        [Annotation(Name = "[Mt. Gelmir - Craftsman's Shack] Roiling Magma 1036527050")]
        MtGelmirCraftsmansShackRoilingMagma = 1036527050,

        [Annotation(Name = "[Mt. Gelmir - Craftsman's Shack] Pulley Crossbow 1036527060")]
        MtGelmirCraftsmansShackPulleyCrossbow = 1036527060,

        [Annotation(Name = "[Mt. Gelmir - Craftsman's Shack] Perfume Bottle 66740")]
        MtGelmirCraftsmansShackPerfumeBottle = 66740,

        [Annotation(Name = "[Mt. Gelmir - Outside Volcano Manor] Golden Rune [6] 1036537000")]
        MtGelmirOutsideVolcanoManorGoldenRune6 = 1036537000,

        [Annotation(Name = "[Mt. Gelmir - Volcano Manor Entrance] Golden Rune [3] 1036547000")]
        MtGelmirVolcanoManorEntranceGoldenRune3 = 1036547000,

        [Annotation(Name = "[Mt. Gelmir - Volcano Manor Entrance] Smoldering Butterfly 1036547010")]
        MtGelmirVolcanoManorEntranceSmolderingButterfly = 1036547010,

        [Annotation(Name = "[Mt. Gelmir - Volcano Manor Entrance] Golden Rune [7] 1036547020")]
        MtGelmirVolcanoManorEntranceGoldenRune7 = 1036547020,

        [Annotation(Name = "[Mt. Gelmir - Volcano Manor Entrance] Smoldering Butterfly 1036547030")]
        MtGelmirVolcanoManorEntranceSmolderingButterfly_ = 1036547030,

        [Annotation(Name = "[Mt. Gelmir - Volcano Manor Entrance] Starlight Shards 1036547040")]
        MtGelmirVolcanoManorEntranceStarlightShards = 1036547040,

        [Annotation(Name = "[Mt. Gelmir - Volcano Manor Entrance] Fireproof Dried Liver 1036547050")]
        MtGelmirVolcanoManorEntranceFireproofDriedLiver = 1036547050,

        [Annotation(Name = "[Mt. Gelmir - Volcano Manor Entrance] Larval Tear 1036547100")]
        MtGelmirVolcanoManorEntranceLarvalTear = 1036547100,

        [Annotation(Name = "[Altus Plateau - Abandoned Coffin] Smithing Stone [5] 1037517000")]
        AltusPlateauAbandonedCoffinSmithingStone5 = 1037517000,

        [Annotation(Name = "[Altus Plateau - Abandoned Coffin] Fulgurbloom 1037517010")]
        AltusPlateauAbandonedCoffinFulgurbloom = 1037517010,

        [Annotation(Name = "[Altus Plateau - Abandoned Coffin] Ruler's Mask 1037517020")]
        AltusPlateauAbandonedCoffinRulersMask = 1037517020,

        [Annotation(Name = "[Mt. Gelmir - Seethewater River] Arrow 1037527020")]
        MtGelmirSeethewaterRiverArrow = 1037527020,

        [Annotation(Name = "[Mt. Gelmir - Seethewater River] Sacramental Bud 1037527030")]
        MtGelmirSeethewaterRiverSacramentalBud = 1037527030,

        [Annotation(Name = "[Mt. Gelmir - Seethewater River] String 1037527040")]
        MtGelmirSeethewaterRiverString = 1037527040,

        [Annotation(Name = "[Mt. Gelmir - Seethewater River] Gold-Tinged Excrement 1037527050")]
        MtGelmirSeethewaterRiverGoldTingedExcrement = 1037527050,

        [Annotation(Name = "[Mt. Gelmir - Seethewater River] Gold Firefly 1037527060")]
        MtGelmirSeethewaterRiverGoldFirefly = 1037527060,

        [Annotation(Name = "[Mt. Gelmir - Seethewater River] Prattling Pate \"You're beautiful\" 1037527070")]
        MtGelmirSeethewaterRiverPrattlingPateYourebeautiful = 1037527070,

        [Annotation(Name = "[Mt. Gelmir - Seethewater River] Starlight Shards 1037527080")]
        MtGelmirSeethewaterRiverStarlightShards = 1037527080,

        [Annotation(Name = "[Mt. Gelmir - Seethewater River] Hierodas Glintstone Crown 1037527090")]
        MtGelmirSeethewaterRiverHierodasGlintstoneCrown = 1037527090,

        [Annotation(Name = "[Mt. Gelmir - Seethewater River] Errant Sorcerer Manchettes 1037527100")]
        MtGelmirSeethewaterRiverErrantSorcererManchettes = 1037527100,

        [Annotation(Name = "[Mt. Gelmir - Primeval Sorcerer Azur] Mushroom 1037537000")]
        MtGelmirPrimevalSorcererAzurMushroom = 1037537000,

        [Annotation(Name = "[Mt. Gelmir - Primeval Sorcerer Azur] Golden Rune [6] 1037537010")]
        MtGelmirPrimevalSorcererAzurGoldenRune6 = 1037537010,

        [Annotation(Name = "[Mt. Gelmir - Primeval Sorcerer Azur] Smithing Stone [5] 1037537020")]
        MtGelmirPrimevalSorcererAzurSmithingStone5 = 1037537020,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Beast Blood 1037547000")]
        MtGelmirMinorErdtreeBeastBlood = 1037547000,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Stonesword Key 1037547010")]
        MtGelmirMinorErdtreeStoneswordKey = 1037547010,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Soporific Grease 1037547020")]
        MtGelmirMinorErdtreeSoporificGrease = 1037547020,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Herba 1037547030")]
        MtGelmirMinorErdtreeHerba = 1037547030,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Eye of Yelough 1037547040")]
        MtGelmirMinorErdtreeEyeOfYelough = 1037547040,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Golden Arrow 1037547050")]
        MtGelmirMinorErdtreeGoldenArrow = 1037547050,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Glass Shard 1037547060")]
        MtGelmirMinorErdtreeGlassShard = 1037547060,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Nascent Butterfly 1037547070")]
        MtGelmirMinorErdtreeNascentButterfly = 1037547070,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Rejuvenating Boluses 1037547080")]
        MtGelmirMinorErdtreeRejuvenatingBoluses = 1037547080,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Hefty Beast Bone 1037547090")]
        MtGelmirMinorErdtreeHeftyBeastBone = 1037547090,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Golden Rune [6] 1037547100")]
        MtGelmirMinorErdtreeGoldenRune6 = 1037547100,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Great Arrow 1037547110")]
        MtGelmirMinorErdtreeGreatArrow = 1037547110,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Fan Daggers 1037547120")]
        MtGelmirMinorErdtreeFanDaggers = 1037547120,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Drawstring Fire Grease 1037547130")]
        MtGelmirMinorErdtreeDrawstringFireGrease = 1037547130,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Golden Rune [4] 1037547140")]
        MtGelmirMinorErdtreeGoldenRune4 = 1037547140,

        [Annotation(Name = "[Mt. Gelmir - Minor Erdtree] Scavenger's Curved Sword 1037547150")]
        MtGelmirMinorErdtreeScavengersCurvedSword = 1037547150,

        [Annotation(Name = "[Mt. Gelmir - Volcano Cave Entrance] Poison Grease 1037557000")]
        MtGelmirVolcanoCaveEntrancePoisonGrease = 1037557000,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] Nascent Butterfly 1038517000")]
        AltusPlateauLuxRuinsNascentButterfly = 1038517000,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] String 1038517010")]
        AltusPlateauLuxRuinsString = 1038517010,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] Lightningproof Dried Liver 1038517020")]
        AltusPlateauLuxRuinsLightningproofDriedLiver = 1038517020,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] Greatshield Talisman 1038517030")]
        AltusPlateauLuxRuinsGreatshieldTalisman = 1038517030,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] Lightningproof Dried Liver 1038517040")]
        AltusPlateauLuxRuinsLightningproofDriedLiver_ = 1038517040,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] Ritual Sword Talisman 1038517050")]
        AltusPlateauLuxRuinsRitualSwordTalisman = 1038517050,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] Lightning Grease 1038517060")]
        AltusPlateauLuxRuinsLightningGrease = 1038517060,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] String 1038517070")]
        AltusPlateauLuxRuinsString_ = 1038517070,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] Golden Rune [3] 1038517080")]
        AltusPlateauLuxRuinsGoldenRune3 = 1038517080,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] Troll's Golden Sword 1038517090")]
        AltusPlateauLuxRuinsTrollsGoldenSword = 1038517090,

        [Annotation(Name = "[Altus Plateau - Wyndham Ruins] Pearldrake Talisman +1 1038527000")]
        AltusPlateauWyndhamRuinsPearldrakeTalisman1 = 1038527000,

        [Annotation(Name = "[Altus Plateau - Wyndham Ruins] Smithing Stone [5] 1038527010")]
        AltusPlateauWyndhamRuinsSmithingStone5 = 1038527010,

        [Annotation(Name = "[Altus Plateau - Wyndham Ruins] Golden Rune [3] 1038527020")]
        AltusPlateauWyndhamRuinsGoldenRune3 = 1038527020,

        [Annotation(Name = "[Altus Plateau - Wyndham Ruins] Golden Rune [7] 1038527030")]
        AltusPlateauWyndhamRuinsGoldenRune7 = 1038527030,

        [Annotation(Name = "[Altus Plateau - Wyndham Ruins] Dappled White Cured Meat 1038527040")]
        AltusPlateauWyndhamRuinsDappledWhiteCuredMeat = 1038527040,

        [Annotation(Name = "[Altus Plateau - Wyndham Ruins] Stormhawk Feather 1038527050")]
        AltusPlateauWyndhamRuinsStormhawkFeather = 1038527050,

        [Annotation(Name = "[Altus Plateau - Wyndham Ruins] Golden Rune [4] 1038527060")]
        AltusPlateauWyndhamRuinsGoldenRune4 = 1038527060,

        [Annotation(Name = "[Altus Plateau - Wyndham Ruins] Human Bone Shard 1038527070")]
        AltusPlateauWyndhamRuinsHumanBoneShard = 1038527070,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Golden Rune [2] 1038537000")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune2 = 1038537000,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Golden Rune [3] 1038537010")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune3 = 1038537010,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Golden Rune [4] 1038537020")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune4 = 1038537020,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Golden Rune [7] 1038537030")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune7 = 1038537030,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Golden Rune [3] 1038537040")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune3_ = 1038537040,

        [Annotation(Name = "[Altus Plateau - Old Altus Tunnel Entrance] Somber Smithing Stone [6] 1038537050")]
        AltusPlateauOldAltusTunnelEntranceSomberSmithingStone6 = 1038537050,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Bloodrose 1038547000")]
        AltusPlateauWestOfShadedCastleBloodrose = 1038547000,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Explosive Greatbolt 1038547010")]
        AltusPlateauWestOfShadedCastleExplosiveGreatbolt = 1038547010,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Golden Rune [8] 1038547020")]
        AltusPlateauWestOfShadedCastleGoldenRune8 = 1038547020,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Fire Arrow 1038547030")]
        AltusPlateauWestOfShadedCastleFireArrow = 1038547030,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Golden Vow 1038547050")]
        AltusPlateauWestOfShadedCastleGoldenVow = 1038547050,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Arteria Leaf 1038547060")]
        AltusPlateauWestOfShadedCastleArteriaLeaf = 1038547060,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Throwing Dagger 1038547070")]
        AltusPlateauWestOfShadedCastleThrowingDagger = 1038547070,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Beast Blood 1038547080")]
        AltusPlateauWestOfShadedCastleBeastBlood = 1038547080,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Smithing Stone [5] 1038547090")]
        AltusPlateauWestOfShadedCastleSmithingStone5 = 1038547090,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Antspur Rapier 1038547100")]
        AltusPlateauWestOfShadedCastleAntspurRapier = 1038547100,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Pulley Bow 1038547110")]
        AltusPlateauWestOfShadedCastlePulleyBow = 1038547110,

        [Annotation(Name = "[Altus Plateau - West of Shaded Castle] Sacred Butchering Knife 1038547700")]
        AltusPlateauWestOfShadedCastleSacredButcheringKnife = 1038547700,

        [Annotation(Name = "[Altus Plateau - Golden Lineage Evergaol] Hefty Beast Bone 1039507000")]
        AltusPlateauGoldenLineageEvergaolHeftyBeastBone = 1039507000,

        [Annotation(Name = "[Altus Plateau - Golden Lineage Evergaol] Stonesword Key 1039507010")]
        AltusPlateauGoldenLineageEvergaolStoneswordKey = 1039507010,

        [Annotation(Name = "[Altus Plateau - Golden Lineage Evergaol] Golden Rune [4] 1039507020")]
        AltusPlateauGoldenLineageEvergaolGoldenRune4 = 1039507020,

        [Annotation(Name = "[Altus Plateau - Golden Lineage Evergaol] Godfrey Icon 1039507100")]
        AltusPlateauGoldenLineageEvergaolGodfreyIcon = 1039507100,

        [Annotation(Name = "[Altus Plateau - Altus Highway Junction] Perfume Bottle 66760")]
        AltusPlateauAltusHighwayJunctionPerfumeBottle = 66760,

        [Annotation(Name = "[Altus Plateau - Altus Highway Junction] Fan Daggers 1039517010")]
        AltusPlateauAltusHighwayJunctionFanDaggers = 1039517010,

        [Annotation(Name = "[Altus Plateau - Altus Highway Junction] Sacrificial Twig 1039517020")]
        AltusPlateauAltusHighwayJunctionSacrificialTwig = 1039517020,

        [Annotation(Name = "[Altus Plateau - Altus Highway Junction] Warming Stone 1039517030")]
        AltusPlateauAltusHighwayJunctionWarmingStone = 1039517030,

        [Annotation(Name = "[Altus Plateau - Altus Highway Junction] Turtle Neck Meat 1039517040")]
        AltusPlateauAltusHighwayJunctionTurtleNeckMeat = 1039517040,

        [Annotation(Name = "[Altus Plateau - Altus Highway Junction] Ash of War: Shared Order 1039517200")]
        AltusPlateauAltusHighwayJunctionAshOfWarSharedOrder = 1039517200,

        [Annotation(Name = "[Altus Plateau - Second Church of Marika] Human Bone Shard 1039527000")]
        AltusPlateauSecondChurchOfMarikaHumanBoneShard = 1039527000,

        [Annotation(Name = "[Altus Plateau - Second Church of Marika] Magic Grease 1039527020")]
        AltusPlateauSecondChurchOfMarikaMagicGrease = 1039527020,

        [Annotation(Name = "[Altus Plateau - Second Church of Marika] Eleonora's Poleblade 1039527700")]
        AltusPlateauSecondChurchOfMarikaEleonorasPoleblade = 1039527700,

        [Annotation(Name = "[Altus Plateau - Mirage Rise] Golden Rune [4] 1039537000")]
        AltusPlateauMirageRiseGoldenRune4 = 1039537000,

        [Annotation(Name = "[Altus Plateau - Mirage Rise] Blood Grease 1039537010")]
        AltusPlateauMirageRiseBloodGrease = 1039537010,

        [Annotation(Name = "[Altus Plateau - Mirage Rise] Golden Rune [3] 1039537020")]
        AltusPlateauMirageRiseGoldenRune3 = 1039537020,

        [Annotation(Name = "[Altus Plateau - Mirage Rise] Miquella's Lily 1039537030")]
        AltusPlateauMirageRiseMiquellasLily = 1039537030,

        [Annotation(Name = "[Altus Plateau - Mirage Rise] Nascent Butterfly 1039537040")]
        AltusPlateauMirageRiseNascentButterfly = 1039537040,

        [Annotation(Name = "[Altus Plateau - Mirage Rise] Unseen Blade 1039537050")]
        AltusPlateauMirageRiseUnseenBlade = 1039537050,

        [Annotation(Name = "[Altus Plateau - Mirage Rise] Slumbering Egg 1039537060")]
        AltusPlateauMirageRiseSlumberingEgg = 1039537060,

        [Annotation(Name = "[Altus Plateau - Mirage Rise] Golden Rune [3] 1039537070")]
        AltusPlateauMirageRiseGoldenRune3_ = 1039537070,

        [Annotation(Name = "[Altus Plateau - Mirage Rise] Mirage Riddle 1039537080")]
        AltusPlateauMirageRiseMirageRiddle = 1039537080,

        [Annotation(Name = "[Altus Plateau - Mirage Rise] Crepus's Vial 1039537700")]
        AltusPlateauMirageRiseCrepussVial = 1039537700,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Rot Grease 1039570000")]
        AltusPlateauShadedCastleRotGrease = 1039570000,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Golden Rune [3] 1039547010")]
        AltusPlateauShadedCastleGoldenRune3 = 1039547010,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [5] 1039547020")]
        AltusPlateauShadedCastleSmithingStone5 = 1039547020,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Poisonbloom 1039547030")]
        AltusPlateauShadedCastlePoisonbloom = 1039547030,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Perfume Bottle 66770")]
        AltusPlateauShadedCastlePerfumeBottle = 66770,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Poisonbone Dart 1039547050")]
        AltusPlateauShadedCastlePoisonboneDart = 1039547050,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Golden Rune [6] 1039547060")]
        AltusPlateauShadedCastleGoldenRune6 = 1039547060,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [4] 1039547070")]
        AltusPlateauShadedCastleSmithingStone4 = 1039547070,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Somber Smithing Stone [5] 1039547080")]
        AltusPlateauShadedCastleSomberSmithingStone5 = 1039547080,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [5] 1039547090")]
        AltusPlateauShadedCastleSmithingStone5_ = 1039547090,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Drawstring Fire Grease 1039547100")]
        AltusPlateauShadedCastleDrawstringFireGrease = 1039547100,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Golden Rune [6] 1039547110")]
        AltusPlateauShadedCastleGoldenRune6_ = 1039547110,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Beast Blood 1039547120")]
        AltusPlateauShadedCastleBeastBlood = 1039547120,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Neutralizing Boluses 1039547130")]
        AltusPlateauShadedCastleNeutralizingBoluses = 1039547130,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Glass Shard 1039547140")]
        AltusPlateauShadedCastleGlassShard = 1039547140,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Stonesword Key 1039547150")]
        AltusPlateauShadedCastleStoneswordKey = 1039547150,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Golden Rune [6] 1039547160")]
        AltusPlateauShadedCastleGoldenRune6__ = 1039547160,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Poison Grease 1039547170")]
        AltusPlateauShadedCastlePoisonGrease = 1039547170,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Hefty Beast Bone 1039547180")]
        AltusPlateauShadedCastleHeftyBeastBone = 1039547180,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Perfumer's Cookbook [2] 67850")]
        AltusPlateauShadedCastlePerfumersCookbook2 = 67850,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [5] 1039547200")]
        AltusPlateauShadedCastleSmithingStone5__ = 1039547200,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Gold Firefly 1039547210")]
        AltusPlateauShadedCastleGoldFirefly = 1039547210,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Glass Shard 1039547220")]
        AltusPlateauShadedCastleGlassShard_ = 1039547220,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [5] 1039547230")]
        AltusPlateauShadedCastleSmithingStone5___ = 1039547230,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [5] 1039547240")]
        AltusPlateauShadedCastleSmithingStone5____ = 1039547240,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Golden Rune [4] 1039547250")]
        AltusPlateauShadedCastleGoldenRune4 = 1039547250,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Smithing Stone [4] 1039547260")]
        AltusPlateauShadedCastleSmithingStone4_ = 1039547260,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Valkyrie's Prosthesis 1039547300")]
        AltusPlateauShadedCastleValkyriesProsthesis = 1039547300,

        [Annotation(Name = "[Altus Plateau - Shaded Castle] Starlight Shards 1039547350")]
        AltusPlateauShadedCastleStarlightShards = 1039547350,

        [Annotation(Name = "[Altus Plateau - Southwest of Tree Sentinel Duo] Gravity Stone Fan 1040507000")]
        AltusPlateauSouthwestOfTreeSentinelDuoGravityStoneFan = 1040507000,

        [Annotation(Name = "[Altus Plateau - Stormcaller Church] Celestial Dew 1040517000")]
        AltusPlateauStormcallerChurchCelestialDew = 1040517000,

        [Annotation(Name = "[Altus Plateau - Stormcaller Church] Old Fang 1040517010")]
        AltusPlateauStormcallerChurchOldFang = 1040517010,

        [Annotation(Name = "[Altus Plateau - Stormcaller Church] Dragonbolt Blessing 1040517020")]
        AltusPlateauStormcallerChurchDragonboltBlessing = 1040517020,

        [Annotation(Name = "[Altus Plateau - Stormcaller Church] Beast Blood 1040517030")]
        AltusPlateauStormcallerChurchBeastBlood = 1040517030,

        [Annotation(Name = "[Altus Plateau - Stormcaller Church] Lightning Greatbolt 1040517040")]
        AltusPlateauStormcallerChurchLightningGreatbolt = 1040517040,

        [Annotation(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Amber Starlight 1040527000")]
        AltusPlateauForestSpanningGreatbridgeAmberStarlight = 1040527000,

        [Annotation(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Golden Rune [6] 1040527010")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune6 = 1040527010,

        [Annotation(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Golden Rune [6] 1040527020")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune6_ = 1040527020,

        [Annotation(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Golden Rune [4] 1040527030")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune4 = 1040527030,

        [Annotation(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Golden Rune [3] 1040527040")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune3 = 1040527040,

        [Annotation(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Golden Rune [4] 1040527050")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune4_ = 1040527050,

        [Annotation(Name = "[Altus Plateau - Writheblood Ruins] Golden Rune [5] 1040537000")]
        AltusPlateauWrithebloodRuinsGoldenRune5 = 1040537000,

        [Annotation(Name = "[Altus Plateau - Writheblood Ruins] Bloody Helice 1040537010")]
        AltusPlateauWrithebloodRuinsBloodyHelice = 1040537010,

        [Annotation(Name = "[Altus Plateau - Writheblood Ruins] Nascent Butterfly 1040537020")]
        AltusPlateauWrithebloodRuinsNascentButterfly = 1040537020,

        [Annotation(Name = "[Altus Plateau - Writheblood Ruins] Fulgurbloom 1040537030")]
        AltusPlateauWrithebloodRuinsFulgurbloom = 1040537030,

        [Annotation(Name = "[Altus Plateau - Writheblood Ruins] Golden Arrow 1040537040")]
        AltusPlateauWrithebloodRuinsGoldenArrow = 1040537040,

        [Annotation(Name = "[Altus Plateau - Writheblood Ruins] Lump of Flesh 1040537050")]
        AltusPlateauWrithebloodRuinsLumpOfFlesh = 1040537050,

        [Annotation(Name = "[Altus Plateau - Writheblood Ruins] Hefty Beast Bone 1040537060")]
        AltusPlateauWrithebloodRuinsHeftyBeastBone = 1040537060,

        [Annotation(Name = "[Altus Plateau - Road of Iniquity Side Path] Great Stars 1040547000")]
        AltusPlateauRoadOfIniquitySidePathGreatStars = 1040547000,

        [Annotation(Name = "[Altus Plateau - Road of Iniquity Side Path] Gravel Stone 1040547010")]
        AltusPlateauRoadOfIniquitySidePathGravelStone = 1040547010,

        [Annotation(Name = "[Altus Plateau - Road of Iniquity Side Path] Stimulating Boluses 1040547030")]
        AltusPlateauRoadOfIniquitySidePathStimulatingBoluses = 1040547030,

        [Annotation(Name = "[Altus Plateau - Road of Iniquity Side Path] Dragonwound Grease 1040547050")]
        AltusPlateauRoadOfIniquitySidePathDragonwoundGrease = 1040547050,

        [Annotation(Name = "[Altus Plateau - Road of Iniquity Side Path] Radiant Gold Mask 1040547090")]
        AltusPlateauRoadOfIniquitySidePathRadiantGoldMask = 1040547090,

        [Annotation(Name = "[Altus Plateau - West Windmill Pasture] Giant Rat Ashes 1040557000")]
        AltusPlateauWestWindmillPastureGiantRatAshes = 1040557000,

        [Annotation(Name = "[Altus Plateau - Tree Sentinel Duo] Golden Rune [3] 1041517000")]
        AltusPlateauTreeSentinelDuoGoldenRune3 = 1041517000,

        [Annotation(Name = "[Altus Plateau - Tree Sentinel Duo] Golden Rune [6] 1041517010")]
        AltusPlateauTreeSentinelDuoGoldenRune6 = 1041517010,

        [Annotation(Name = "[Altus Plateau - Tree Sentinel Duo] Silver-Pickled Fowl Foot 1041517020")]
        AltusPlateauTreeSentinelDuoSilverPickledFowlFoot = 1041517020,

        [Annotation(Name = "[Altus Plateau - Tree Sentinel Duo] Gravity Stone Chunk 1041517030")]
        AltusPlateauTreeSentinelDuoGravityStoneChunk = 1041517030,

        [Annotation(Name = "[Altus Plateau - Rampartside Path] Golden Rune [8] 1041527000")]
        AltusPlateauRampartsidePathGoldenRune8 = 1041527000,

        [Annotation(Name = "[Altus Plateau - Rampartside Path] Golden Rune [6] 1041527010")]
        AltusPlateauRampartsidePathGoldenRune6 = 1041527010,

        [Annotation(Name = "[Altus Plateau - Rampartside Path] Golden Rune [4] 1041527020")]
        AltusPlateauRampartsidePathGoldenRune4 = 1041527020,

        [Annotation(Name = "[Altus Plateau - Rampartside Path] Golden Rune [3] 1041527030")]
        AltusPlateauRampartsidePathGoldenRune3 = 1041527030,

        [Annotation(Name = "[Altus Plateau - Rampartside Path] Golden Rune [1] 1041527040")]
        AltusPlateauRampartsidePathGoldenRune1 = 1041527040,

        [Annotation(Name = "[Altus Plateau - Rampartside Path] Lump of Flesh 1041527070")]
        AltusPlateauRampartsidePathLumpOfFlesh = 1041527070,

        [Annotation(Name = "[Altus Plateau - Rampartside Path] Land Octopus Ovary 1041527080")]
        AltusPlateauRampartsidePathLandOctopusOvary = 1041527080,

        [Annotation(Name = "[Altus Plateau - Rampartside Path] Stonesword Key 1041527090")]
        AltusPlateauRampartsidePathStoneswordKey = 1041527090,

        [Annotation(Name = "[Altus Plateau - Woodfolk Ruins] Poisonbone Dart 1041537010")]
        AltusPlateauWoodfolkRuinsPoisonboneDart = 1041537010,

        [Annotation(Name = "[Altus Plateau - Woodfolk Ruins] Wrath of Gold 1041537020")]
        AltusPlateauWoodfolkRuinsWrathOfGold = 1041537020,

        [Annotation(Name = "[Altus Plateau - Woodfolk Ruins] Invigorating White Cured Meat 1041537030")]
        AltusPlateauWoodfolkRuinsInvigoratingWhiteCuredMeat = 1041537030,

        [Annotation(Name = "[Altus Plateau - Woodfolk Ruins] Beast Blood 1041537040")]
        AltusPlateauWoodfolkRuinsBeastBlood = 1041537040,

        [Annotation(Name = "[Altus Plateau - Woodfolk Ruins] Nomadic Warrior's Cookbook [19] 67070")]
        AltusPlateauWoodfolkRuinsNomadicWarriorsCookbook19 = 67070,

        [Annotation(Name = "[Altus Plateau - Woodfolk Ruins] Gravel Stone 1041537060")]
        AltusPlateauWoodfolkRuinsGravelStone = 1041537060,

        [Annotation(Name = "[Altus Plateau - Woodfolk Ruins] Soft Cotton 1041537070")]
        AltusPlateauWoodfolkRuinsSoftCotton = 1041537070,

        [Annotation(Name = "[Altus Plateau - Woodfolk Ruins] Icon Shield 1041537080")]
        AltusPlateauWoodfolkRuinsIconShield = 1041537080,

        [Annotation(Name = "[Altus Plateau - West Windmill Village] Poison Grease 1041547000")]
        AltusPlateauWestWindmillVillagePoisonGrease = 1041547000,

        [Annotation(Name = "[Altus Plateau - East Windmill Pasture] Twinned Knight Swords 1041557000")]
        AltusPlateauEastWindmillPastureTwinnedKnightSwords = 1041557000,

        [Annotation(Name = "[Altus Plateau - East Windmill Pasture] Raw Meat Dumpling 1041557010")]
        AltusPlateauEastWindmillPastureRawMeatDumpling = 1041557010,

        [Annotation(Name = "[Altus Plateau - East Windmill Pasture] Navy Hood 1041557020")]
        AltusPlateauEastWindmillPastureNavyHood = 1041557020,

        [Annotation(Name = "[Leyndell - South of Outer Wall Phantom Tree] Giant-Crusher 1042507000")]
        LeyndellSouthOfOuterWallPhantomTreeGiantCrusher = 1042507000,

        [Annotation(Name = "[Leyndell - South of Outer Wall Phantom Tree] Golden Seed 1042507020")]
        LeyndellSouthOfOuterWallPhantomTreeGoldenSeed = 1042507020,

        [Annotation(Name = "[Leyndell - Outer Wall Phantom Tree] Holy Grease 1042517000")]
        LeyndellOuterWallPhantomTreeHolyGrease = 1042517000,

        [Annotation(Name = "[Leyndell - Outer Wall Phantom Tree] Gargoyle's Great Axe 1042517900")]
        LeyndellOuterWallPhantomTreeGargoylesGreatAxe = 1042517900,

        [Annotation(Name = "[Leyndell - Southwest Outer Wall Battleground] Old Fang 1042527000")]
        LeyndellSouthwestOuterWallBattlegroundOldFang = 1042527000,

        [Annotation(Name = "[Leyndell - Southwest Outer Wall Battleground] Golden Rune [4] 1042527010")]
        LeyndellSouthwestOuterWallBattlegroundGoldenRune4 = 1042527010,

        [Annotation(Name = "[Leyndell - Southwest Outer Wall Battleground] Rainbow Stone 1042527020")]
        LeyndellSouthwestOuterWallBattlegroundRainbowStone = 1042527020,

        [Annotation(Name = "[Leyndell - Southwest Outer Wall Battleground] Golden Rune [10] 1042527030")]
        LeyndellSouthwestOuterWallBattlegroundGoldenRune10 = 1042527030,

        [Annotation(Name = "[Leyndell - Southwest Outer Wall Battleground] Arteria Leaf 1042527040")]
        LeyndellSouthwestOuterWallBattlegroundArteriaLeaf = 1042527040,

        [Annotation(Name = "[Leyndell - Northwest Outer Wall Battleground] Lightning Greatbolt 1042537000")]
        LeyndellNorthwestOuterWallBattlegroundLightningGreatbolt = 1042537000,

        [Annotation(Name = "[Leyndell - Northwest Outer Wall Battleground] Somber Smithing Stone [5] 1042537010")]
        LeyndellNorthwestOuterWallBattlegroundSomberSmithingStone5 = 1042537010,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Four-Toed Fowl Foot 1042547000")]
        AltusPlateauHighwayLookoutTowerFourToedFowlFoot = 1042547000,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Golden Rune [5] 1042547010")]
        AltusPlateauHighwayLookoutTowerGoldenRune5 = 1042547010,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Holyproof Dried Liver 1042547020")]
        AltusPlateauHighwayLookoutTowerHolyproofDriedLiver = 1042547020,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Stormhawk Feather 1042547030")]
        AltusPlateauHighwayLookoutTowerStormhawkFeather = 1042547030,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Hefty Beast Bone 1042547040")]
        AltusPlateauHighwayLookoutTowerHeftyBeastBone = 1042547040,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Golden Arrow 1042547050")]
        AltusPlateauHighwayLookoutTowerGoldenArrow = 1042547050,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Greatbow 1042547060")]
        AltusPlateauHighwayLookoutTowerGreatbow = 1042547060,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Gold Firefly 1042547070")]
        AltusPlateauHighwayLookoutTowerGoldFirefly = 1042547070,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Lightning Grease 1042547080")]
        AltusPlateauHighwayLookoutTowerLightningGrease = 1042547080,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Exalted Flesh 1042547090")]
        AltusPlateauHighwayLookoutTowerExaltedFlesh = 1042547090,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Rune Arc 1042547100")]
        AltusPlateauHighwayLookoutTowerRuneArc = 1042547100,

        [Annotation(Name = "[Altus Plateau - Windmill Heights] Celebrant's Skull 1042557000")]
        AltusPlateauWindmillHeightsCelebrantsSkull = 1042557000,

        [Annotation(Name = "[Leyndell - Minor Erdtree Church] Golden Order Seal 1043507000")]
        LeyndellMinorErdtreeChurchGoldenOrderSeal = 1043507000,

        [Annotation(Name = "[Leyndell - Minor Erdtree Church] Smoldering Butterfly 1043507010")]
        LeyndellMinorErdtreeChurchSmolderingButterfly = 1043507010,

        [Annotation(Name = "[Leyndell - Minor Erdtree Church] Missionary's Cookbook [4] 67640")]
        LeyndellMinorErdtreeChurchMissionarysCookbook4 = 67640,

        [Annotation(Name = "[Leyndell - Southeast Outer Wall Battleground] Lost Ashes of War 1043527000")]
        LeyndellSoutheastOuterWallBattlegroundLostAshesOfWar = 1043527000,

        [Annotation(Name = "[Leyndell - Southeast Outer Wall Battleground] Golden Rune [5] 1043527030")]
        LeyndellSoutheastOuterWallBattlegroundGoldenRune5 = 1043527030,

        [Annotation(Name = "[Leyndell - Southeast Outer Wall Battleground] Viridian Amber Medallion +1 1043527500")]
        LeyndellSoutheastOuterWallBattlegroundViridianAmberMedallion1 = 1043527500,

        [Annotation(Name = "[Leyndell - Northeast Outer Wall Battleground] Golden Rune [9] 1043537000")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune9 = 1043537000,

        [Annotation(Name = "[Leyndell - Northeast Outer Wall Battleground] Golden Rune [10] 1043537010")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune10 = 1043537010,

        [Annotation(Name = "[Leyndell - Northeast Outer Wall Battleground] Larval Tear 1043537100")]
        LeyndellNortheastOuterWallBattlegroundLarvalTear = 1043537100,

        [Annotation(Name = "[Leyndell - Northeast Outer Wall Battleground] Grace Mimic 1043537020")]
        LeyndellNortheastOuterWallBattlegroundGraceMimic = 1043537020,

        [Annotation(Name = "[Leyndell - Northeast Outer Wall Battleground] Drawstring Holy Grease 1043537030")]
        LeyndellNortheastOuterWallBattlegroundDrawstringHolyGrease = 1043537030,

        [Annotation(Name = "[Leyndell - Northeast Outer Wall Battleground] Smithing Stone [5] 1043537040")]
        LeyndellNortheastOuterWallBattlegroundSmithingStone5 = 1043537040,

        [Annotation(Name = "[Leyndell - Northeast Outer Wall Battleground] Golden Rune [5] 1043537050")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune5 = 1043537050,

        [Annotation(Name = "[Leyndell - Northeast Outer Wall Battleground] Golden Rune [7] 1043537060")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune7 = 1043537060,

        [Annotation(Name = "[Leyndell - Northeast Outer Wall Battleground] Mushroom 1043537070")]
        LeyndellNortheastOuterWallBattlegroundMushroom = 1043537070,

        [Annotation(Name = "[Leyndell - Northeast Outer Wall Battleground] Medicine Peddler's Bell Bearing 1043537400")]
        LeyndellNortheastOuterWallBattlegroundMedicinePeddlersBellBearing = 1043537400,

        [Annotation(Name = "[Leyndell - South of Minor Erdtree] Great Arrow 1044527000")]
        LeyndellSouthOfMinorErdtreeGreatArrow = 1044527000,

        [Annotation(Name = "[Leyndell - South of Minor Erdtree] Golden Rune [6] 1044527010")]
        LeyndellSouthOfMinorErdtreeGoldenRune6 = 1044527010,

        [Annotation(Name = "[Leyndell - South of Minor Erdtree] Golden Rune [2] 1044527020")]
        LeyndellSouthOfMinorErdtreeGoldenRune2 = 1044527020,

        [Annotation(Name = "[Leyndell - Minor Erdtree] Golden Rune [4] 1044537010")]
        LeyndellMinorErdtreeGoldenRune4 = 1044537010,

        [Annotation(Name = "[Leyndell - Capital Rampart] Gravity Stone Fan 1045527000")]
        LeyndellCapitalRampartGravityStoneFan = 1045527000,

        [Annotation(Name = "[Leyndell - Capital Rampart] Gravel Stone 1045527010")]
        LeyndellCapitalRampartGravelStone = 1045527010,

        [Annotation(Name = "[Leyndell - Capital Rampart] Smithing Stone [6] 1045527020")]
        LeyndellCapitalRampartSmithingStone6 = 1045527020,

        [Annotation(Name = "[Leyndell - Capital Rampart] Smithing Stone [5] 1045527030")]
        LeyndellCapitalRampartSmithingStone5 = 1045527030,

        [Annotation(Name = "[Leyndell - Minor Erdtree] Crimson Crystal Tear 65030")]
        LeyndellMinorErdtreeCrimsonCrystalTear = 65030,

        [Annotation(Name = "[Leyndell - Minor Erdtree] Twiggy Cracked Tear 65190")]
        LeyndellMinorErdtreeTwiggyCrackedTear = 65190,

        [Annotation(Name = "[Leyndell - Minor Erdtree] Winged Crystal Tear 65120")]
        LeyndellMinorErdtreeWingedCrystalTear = 65120,

        [Annotation(Name = "[Leyndell - Minor Erdtree] Twinbird Kite Shield 1044537300")]
        LeyndellMinorErdtreeTwinbirdKiteShield = 1044537300,

        [Annotation(Name = "[Altus Plateau - Lux Ruins] Golden Seed 1038517400")]
        AltusPlateauLuxRuinsGoldenSeed = 1038517400,

        [Annotation(Name = "[Altus Plateau - Altus Highway Junction] Golden Seed 1039517400")]
        AltusPlateauAltusHighwayJunctionGoldenSeed = 1039517400,

        [Annotation(Name = "[Altus Plateau - Second Church of Marika] Sacred Tear 1039527400")]
        AltusPlateauSecondChurchOfMarikaSacredTear = 1039527400,

        [Annotation(Name = "[Altus Plateau - West Windmill Village] Golden Seed 1041547400")]
        AltusPlateauWestWindmillVillageGoldenSeed = 1041547400,

        [Annotation(Name = "[Altus Plateau - Stormcaller Church] Sacred Tear 1040517400")]
        AltusPlateauStormcallerChurchSacredTear = 1040517400,

        [Annotation(Name = "[Leyndell - Outer Wall Phantom Tree] Golden Seed 1042517400")]
        LeyndellOuterWallPhantomTreeGoldenSeed = 1042517400,

        [Annotation(Name = "[Leyndell - Outer Wall Phantom Tree] Golden Seed 1042517410")]
        LeyndellOuterWallPhantomTreeGoldenSeed_ = 1042517410,

        [Annotation(Name = "[Altus Plateau - Highway Lookout Tower] Golden Seed 1042547400")]
        AltusPlateauHighwayLookoutTowerGoldenSeed = 1042547400,

        [Annotation(Name = "[Leyndell - Southeast Outer Wall Battleground] Golden Seed 1043527400")]
        LeyndellSoutheastOuterWallBattlegroundGoldenSeed = 1043527400,

        [Annotation(Name = "[Leyndell - Southeast Outer Wall Battleground] Golden Seed 1043527410")]
        LeyndellSoutheastOuterWallBattlegroundGoldenSeed_ = 1043527410,

        [Annotation(Name = "[Mt. Gelmir - Volcano Manor Entrance] Golden Seed 1036547400")]
        MtGelmirVolcanoManorEntranceGoldenSeed = 1036547400,

        [Annotation(Name = "[Mt. Gelmir - Primeval Sorcerer Azur] Golden Seed 1037537400")]
        MtGelmirPrimevalSorcererAzurGoldenSeed = 1037537400,

        [Annotation(Name = "[Altus Plateau - Forest-Spanning Greatbridge] Map: Altus Plateau 62030")]
        AltusPlateauForestSpanningGreatbridgeMapAltusPlateau = 62030,

        [Annotation(Name = "[Leyndell - Outer Wall Phantom Tree] Map: Leyndell, Royal Capital 62031")]
        LeyndellOuterWallPhantomTreeMapLeyndellRoyalCapital = 62031,

        [Annotation(Name = "[Mt. Gelmir - Volcano Manor Entrance] Map: Mt. Gelmir 62032")]
        MtGelmirVolcanoManorEntranceMapMtGelmir = 62032,

        [Annotation(Name = "[Liurnia of the Lake - Northeast Ravine] Neutralizing Boluses 1037507000")]
        LiurniaOfTheLakeNortheastRavineNeutralizingBoluses = 1037507000,

        [Annotation(Name = "[Liurnia of the Lake - Northeast Ravine] Golden Seed 1037507100")]
        LiurniaOfTheLakeNortheastRavineGoldenSeed = 1037507100,

        [Annotation(Name = "[Leyndell - Divine Tower of East Altus Entrance] Drawstring Fire Grease 1047517000")]
        LeyndellDivineTowerOfEastAltusEntranceDrawstringFireGrease = 1047517000,

        [Annotation(Name = "[Leyndell - Divine Tower of East Altus Entrance] Golden Rune [7] 1047517010")]
        LeyndellDivineTowerOfEastAltusEntranceGoldenRune7 = 1047517010,

        [Annotation(Name = "[Leyndell - Divine Tower of East Altus Entrance] Dragonwound Grease 1047517300")]
        LeyndellDivineTowerOfEastAltusEntranceDragonwoundGrease = 1047517300,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Isolated Merchant's Shack] Somber Smithing Stone [7] 1048517000")]
        GreyollsDragonbarrowIsolatedMerchantsShackSomberSmithingStone7 = 1048517000,

        [Annotation(Name = "[Greyoll's Dragonbarrow - Isolated Merchant's Shack] Ash of War: Phantom Slash 1048517700")]
        GreyollsDragonbarrowIsolatedMerchantsShackAshOfWarPhantomSlash = 1048517700,

        [Annotation(Name = "[Mountaintops of the Giants - Before Grand Lift of Rold] Freezing Grease 1049527000")]
        MountaintopsOfTheGiantsBeforeGrandLiftOfRoldFreezingGrease = 1049527000,

        [Annotation(Name = "[Mountaintops of the Giants - Before Grand Lift of Rold] Golden Seed 1049527800")]
        MountaintopsOfTheGiantsBeforeGrandLiftOfRoldGoldenSeed = 1049527800,

        [Annotation(Name = "[Mountaintops of the Giants - West Zamor Ruins] Sliver of Meat 1049537000")]
        MountaintopsOfTheGiantsWestZamorRuinsSliverOfMeat = 1049537000,

        [Annotation(Name = "[Mountaintops of the Giants - West Zamor Ruins] Invigorating Cured Meat 1049537010")]
        MountaintopsOfTheGiantsWestZamorRuinsInvigoratingCuredMeat = 1049537010,

        [Annotation(Name = "[Mountaintops of the Giants - West Zamor Ruins] Golden Rune [10] 1049537020")]
        MountaintopsOfTheGiantsWestZamorRuinsGoldenRune10 = 1049537020,

        [Annotation(Name = "[Mountaintops of the Giants - West Zamor Ruins] Zamor Ice Storm 1049537030")]
        MountaintopsOfTheGiantsWestZamorRuinsZamorIceStorm = 1049537030,

        [Annotation(Name = "[Mountaintops of the Giants - West Zamor Ruins] Beast Blood 1049537300")]
        MountaintopsOfTheGiantsWestZamorRuinsBeastBlood = 1049537300,

        [Annotation(Name = "[Mountaintops of the Giants - West Zamor Ruins] Map: Mountaintops of the Giants, West 62050")]
        MountaintopsOfTheGiantsWestZamorRuinsMapMountaintopsOfTheGiantsWest = 62050,

        [Annotation(Name = "[Mountaintops of the Giants - West Zamor Ruins] Smithing-Stone Miner's Bell Bearing [3] 1049537900")]
        MountaintopsOfTheGiantsWestZamorRuinsSmithingStoneMinersBellBearing3 = 1049537900,

        [Annotation(Name = "[Mountaintops of the Giants - East Zamor Ruins] Somber Smithing Stone [7] 1050537000")]
        MountaintopsOfTheGiantsEastZamorRuinsSomberSmithingStone7 = 1050537000,

        [Annotation(Name = "[Mountaintops of the Giants - East Zamor Ruins] Smoldering Butterfly 1050537300")]
        MountaintopsOfTheGiantsEastZamorRuinsSmolderingButterfly = 1050537300,

        [Annotation(Name = "[Mountaintops of the Giants - East Zamor Ruins] Somber Smithing Stone [7] 1050537700")]
        MountaintopsOfTheGiantsEastZamorRuinsSomberSmithingStone7_ = 1050537700,

        [Annotation(Name = "[Mountaintops of the Giants - North of Zamor Ruins] Lost Ashes of War 1050547000")]
        MountaintopsOfTheGiantsNorthOfZamorRuinsLostAshesOfWar = 1050547000,

        [Annotation(Name = "[Mountaintops of the Giants - North of Zamor Ruins] Arteria Leaf 1050547800")]
        MountaintopsOfTheGiantsNorthOfZamorRuinsArteriaLeaf = 1050547800,

        [Annotation(Name = "[Mountaintops of the Giants - North of Zamor Ruins] Briars of Punishment 1050547810")]
        MountaintopsOfTheGiantsNorthOfZamorRuinsBriarsOfPunishment = 1050547810,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Golden Rune [7] 1051557300")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsGoldenRune7 = 1051557300,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Drawstring Holy Grease 1051557310")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsDrawstringHolyGrease = 1051557310,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Rainbow Stone 1051557320")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsRainbowStone = 1051557320,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Golden Rune [13] 1051557330")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsGoldenRune13 = 1051557330,

        [Annotation(Name = "[Mountaintops of the Giants - Shack of the Lofty] Tarnished Golden Sunflower 1050567300")]
        MountaintopsOfTheGiantsShackOfTheLoftyTarnishedGoldenSunflower = 1050567300,

        [Annotation(Name = "[Mountaintops of the Giants - Shack of the Lofty] Warming Stone 1050567500")]
        MountaintopsOfTheGiantsShackOfTheLoftyWarmingStone = 1050567500,

        [Annotation(Name = "[Mountaintops of the Giants - Shack of the Lofty] Invigorating White Cured Meat 1050567510")]
        MountaintopsOfTheGiantsShackOfTheLoftyInvigoratingWhiteCuredMeat = 1050567510,

        [Annotation(Name = "[Mountaintops of the Giants - Shack of the Lofty] Smithing Stone [7] 1050567520")]
        MountaintopsOfTheGiantsShackOfTheLoftySmithingStone7 = 1050567520,

        [Annotation(Name = "[Mountaintops of the Giants - Shack of the Lofty] Ancient Dragon Smithing Stone 1050567600")]
        MountaintopsOfTheGiantsShackOfTheLoftyAncientDragonSmithingStone = 1050567600,

        [Annotation(Name = "[Mountaintops of the Giants - Shack of the Lofty] Traveling Maiden Hood 1050567620")]
        MountaintopsOfTheGiantsShackOfTheLoftyTravelingMaidenHood = 1050567620,

        [Annotation(Name = "[Mountaintops of the Giants - Shack of the Lofty] Hoslow's Petal Whip 1050567700")]
        MountaintopsOfTheGiantsShackOfTheLoftyHoslowsPetalWhip = 1050567700,

        [Annotation(Name = "[Mountaintops of the Giants - Shack of the Lofty] Smithing Stone [8] 1050567800")]
        MountaintopsOfTheGiantsShackOfTheLoftySmithingStone8 = 1050567800,

        [Annotation(Name = "[Mountaintops of the Giants - Shack of the Lofty] Graven-Mass Talisman 1050567820")]
        MountaintopsOfTheGiantsShackOfTheLoftyGravenMassTalisman = 1050567820,

        [Annotation(Name = "[Mountaintops of the Giants - Before Freezing Lake] Stimulating Boluses 1052577000")]
        MountaintopsOfTheGiantsBeforeFreezingLakeStimulatingBoluses = 1052577000,

        [Annotation(Name = "[Mountaintops of the Giants - Before Freezing Lake] Thawfrost Boluses 1052577300")]
        MountaintopsOfTheGiantsBeforeFreezingLakeThawfrostBoluses = 1052577300,

        [Annotation(Name = "[Mountaintops of the Giants - Before Freezing Lake] Old Fang 1052577310")]
        MountaintopsOfTheGiantsBeforeFreezingLakeOldFang = 1052577310,

        [Annotation(Name = "[Mountaintops of the Giants - Before Freezing Lake] Golden Seed 1052577800")]
        MountaintopsOfTheGiantsBeforeFreezingLakeGoldenSeed = 1052577800,

        [Annotation(Name = "[Mountaintops of the Giants - Before Freezing Lake] Smithing Stone [7] 1052577810")]
        MountaintopsOfTheGiantsBeforeFreezingLakeSmithingStone7 = 1052577810,

        [Annotation(Name = "[Mountaintops of the Giants - Northwest Freezing Lake] Golden Rune [11] 1053577300")]
        MountaintopsOfTheGiantsNorthwestFreezingLakeGoldenRune11 = 1053577300,

        [Annotation(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Somber Smithing Stone [8] 1053567300")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeSomberSmithingStone8 = 1053567300,

        [Annotation(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [10] 1053567310")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune10 = 1053567310,

        [Annotation(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [12] 1053567700")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune12 = 1053567700,

        [Annotation(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [12] 1053567710")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune12_ = 1053567710,

        [Annotation(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [12] 1053567720")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune12__ = 1053567720,

        [Annotation(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [7] 1053567800")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune7 = 1053567800,

        [Annotation(Name = "[Mountaintops of the Giants - Southwest Freezing Lake] Golden Rune [7] 1053567810")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune7_ = 1053567810,

        [Annotation(Name = "[Mountaintops of the Giants - Before Freezing Lake] Founding Rain of Stars 1052577900")]
        MountaintopsOfTheGiantsBeforeFreezingLakeFoundingRainOfStars = 1052577900,

        [Annotation(Name = "[Mountaintops of the Giants - First Church of Marika] Smithing Stone [7] 1054557000")]
        MountaintopsOfTheGiantsFirstChurchOfMarikaSmithingStone7 = 1054557000,

        [Annotation(Name = "[Mountaintops of the Giants - First Church of Marika] Somberstone Miner's Bell Bearing [3] 1054557310")]
        MountaintopsOfTheGiantsFirstChurchOfMarikaSomberstoneMinersBellBearing3 = 1054557310,

        [Annotation(Name = "[Mountaintops of the Giants - First Church of Marika] Sacred Tear 1054557800")]
        MountaintopsOfTheGiantsFirstChurchOfMarikaSacredTear = 1054557800,

        [Annotation(Name = "[Mountaintops of the Giants - Whiteridge Road] Explosive Greatbolt 1052567300")]
        MountaintopsOfTheGiantsWhiteridgeRoadExplosiveGreatbolt = 1052567300,

        [Annotation(Name = "[Mountaintops of the Giants - Whiteridge Road] Rune Arc 1052567310")]
        MountaintopsOfTheGiantsWhiteridgeRoadRuneArc = 1052567310,

        [Annotation(Name = "[Mountaintops of the Giants - Giants' Gravepost] Ancient Dragon Smithing Stone 1051537000")]
        MountaintopsOfTheGiantsGiantsGravepostAncientDragonSmithingStone = 1051537000,

        [Annotation(Name = "[Mountaintops of the Giants - Giants' Gravepost] Smithing Stone [7] 1051537010")]
        MountaintopsOfTheGiantsGiantsGravepostSmithingStone7 = 1051537010,

        [Annotation(Name = "[Mountaintops of the Giants - Giants' Gravepost] Drawstring Holy Grease 1051537300")]
        MountaintopsOfTheGiantsGiantsGravepostDrawstringHolyGrease = 1051537300,

        [Annotation(Name = "[Mountaintops of the Giants - Giants' Gravepost] Rivers of Blood 1051537500")]
        MountaintopsOfTheGiantsGiantsGravepostRiversOfBlood = 1051537500,

        [Annotation(Name = "[Mountaintops of the Giants - Giants' Gravepost] Ash of War: Troll's Roar 1051537600")]
        MountaintopsOfTheGiantsGiantsGravepostAshOfWarTrollsRoar = 1051537600,

        [Annotation(Name = "[Mountaintops of the Giants - Giants' Gravepost] Somber Smithing Stone [8] 1051537700")]
        MountaintopsOfTheGiantsGiantsGravepostSomberSmithingStone8 = 1051537700,

        [Annotation(Name = "[Mountaintops of the Giants - Giants' Gravepost] Sacred Tear 1051537800")]
        MountaintopsOfTheGiantsGiantsGravepostSacredTear = 1051537800,

        [Annotation(Name = "[Mountaintops of the Giants - Giants' Gravepost] Warming Stone 1051537810")]
        MountaintopsOfTheGiantsGiantsGravepostWarmingStone = 1051537810,

        [Annotation(Name = "[Mountaintops of the Giants - Giants' Gravepost] Invigorating White Cured Meat 1051547000")]
        MountaintopsOfTheGiantsGiantsGravepostInvigoratingWhiteCuredMeat = 1051547000,

        [Annotation(Name = "[Mountaintops of the Giants - Giants' Gravepost] Fan Daggers 1051547800")]
        MountaintopsOfTheGiantsGiantsGravepostFanDaggers = 1051547800,

        [Annotation(Name = "[Mountaintops of the Giants - Northwest Fire Giant Arena] Golden Rune [10] 1052537000")]
        MountaintopsOfTheGiantsNorthwestFireGiantArenaGoldenRune10 = 1052537000,

        [Annotation(Name = "[Mountaintops of the Giants - Northwest Fire Giant Arena] Golden Seed 1052537800")]
        MountaintopsOfTheGiantsNorthwestFireGiantArenaGoldenSeed = 1052537800,

        [Annotation(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Grace Mimic 1052547000")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostGraceMimic = 1052547000,

        [Annotation(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Golden Rune [10] 1052547010")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostGoldenRune10 = 1052547010,

        [Annotation(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Golden Rune [10] 1052547020")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostGoldenRune10_ = 1052547020,

        [Annotation(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Map: Mountaintops of the Giants, East 62051")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostMapMountaintopsOfTheGiantsEast = 62051,

        [Annotation(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Starlight Shards 1052547800")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostStarlightShards = 1052547800,

        [Annotation(Name = "[Mountaintops of the Giants - Northeast Giants' Gravepost] Crimsonwhorl Bubbletear 65200")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostCrimsonwhorlBubbletear = 65200,

        [Annotation(Name = "[Mountaintops of the Giants - Guardians' Garrison] Smoldering Butterfly 1052557000")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmolderingButterfly = 1052557000,

        [Annotation(Name = "[Mountaintops of the Giants - Guardians' Garrison] Smithing Stone [7] 1052557010")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmithingStone7 = 1052557010,

        [Annotation(Name = "[Mountaintops of the Giants - Guardians' Garrison] Golden Rune [10] 1052557020")]
        MountaintopsOfTheGiantsGuardiansGarrisonGoldenRune10 = 1052557020,

        [Annotation(Name = "[Mountaintops of the Giants - Guardians' Garrison] Smoldering Butterfly 1052557030")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmolderingButterfly_ = 1052557030,

        [Annotation(Name = "[Mountaintops of the Giants - Guardians' Garrison] Smithing Stone [7] 1052557040")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmithingStone7_ = 1052557040,

        [Annotation(Name = "[Mountaintops of the Giants - Guardians' Garrison] Golden Rune [8] 1052557300")]
        MountaintopsOfTheGiantsGuardiansGarrisonGoldenRune8 = 1052557300,

        [Annotation(Name = "[Mountaintops of the Giants - Guardians' Garrison] Stonesword Key 1052557310")]
        MountaintopsOfTheGiantsGuardiansGarrisonStoneswordKey = 1052557310,

        [Annotation(Name = "[Mountaintops of the Giants - Guardians' Garrison] One-Eyed Shield 1052557700")]
        MountaintopsOfTheGiantsGuardiansGarrisonOneEyedShield = 1052557700,

        [Annotation(Name = "[Mountaintops of the Giants - Guardians' Garrison] Gravel Stone 1052557800")]
        MountaintopsOfTheGiantsGuardiansGarrisonGravelStone = 1052557800,

        [Annotation(Name = "[Mountaintops of the Giants - Guardians' Garrison] Giant's Prayerbook 1052557900")]
        MountaintopsOfTheGiantsGuardiansGarrisonGiantsPrayerbook = 1052557900,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Somber Smithing Stone [9] 1051567020")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsSomberSmithingStone9 = 1051567020,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Freezing Grease 1051567030")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsFreezingGrease = 1051567030,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Formic Rock 1051567300")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsFormicRock = 1051567300,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Soft Cotton 1051567310")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsSoftCotton = 1051567310,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Golden Rune [10] 1051567320")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsGoldenRune10 = 1051567320,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Somber Smithing Stone [8] 1051567700")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsSomberSmithingStone8 = 1051567700,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Miquella's Lily 1051567800")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsMiquellasLily = 1051567800,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Miquella's Lily 1051567810")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsMiquellasLily_ = 1051567810,

        [Annotation(Name = "[Mountaintops of the Giants - Ancient Snow Valley Ruins] Primal Glintstone Blade 1051567900")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsPrimalGlintstoneBlade = 1051567900,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Freezing Grease 1051577000")]
        MountaintopsOfTheGiantsSouthCastleSolFreezingGrease = 1051577000,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [10] 1051577010")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10 = 1051577010,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Smithing Stone [5] 1051577020")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone5 = 1051577020,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Fan Daggers 1051577030")]
        MountaintopsOfTheGiantsSouthCastleSolFanDaggers = 1051577030,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [10] 1051577040")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10_ = 1051577040,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [10] 1051577050")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10__ = 1051577050,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Nascent Butterfly 1051577060")]
        MountaintopsOfTheGiantsSouthCastleSolNascentButterfly = 1051577060,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Cerulean Amber Medallion +1 1051577070")]
        MountaintopsOfTheGiantsSouthCastleSolCeruleanAmberMedallion1 = 1051577070,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Smithing Stone [7] 1051577080")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone7 = 1051577080,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Smithing Stone [5] 1051577090")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone5_ = 1051577090,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Smithing Stone [6] 1051577100")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone6 = 1051577100,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Somber Smithing Stone [8] 1051577110")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone8 = 1051577110,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [10] 1051577120")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10___ = 1051577120,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Human Bone Shard 1051577130")]
        MountaintopsOfTheGiantsSouthCastleSolHumanBoneShard = 1051577130,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [11] 1051577140")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune11 = 1051577140,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Thawfrost Boluses 1051577150")]
        MountaintopsOfTheGiantsSouthCastleSolThawfrostBoluses = 1051577150,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Furlcalling Finger Remedy 1051577160")]
        MountaintopsOfTheGiantsSouthCastleSolFurlcallingFingerRemedy = 1051577160,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Smithing Stone [6] 1051577170")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone6_ = 1051577170,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Thawfrost Boluses 1051577180")]
        MountaintopsOfTheGiantsSouthCastleSolThawfrostBoluses_ = 1051577180,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Somber Smithing Stone [8] 1051577190")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone8_ = 1051577190,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [9] 1051577200")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune9 = 1051577200,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Rune Arc 1051577210")]
        MountaintopsOfTheGiantsSouthCastleSolRuneArc = 1051577210,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Stormhawk Axe 1051577220")]
        MountaintopsOfTheGiantsSouthCastleSolStormhawkAxe = 1051577220,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Golden Rune [10] 1051577230")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10____ = 1051577230,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Stonesword Key 1051577300")]
        MountaintopsOfTheGiantsSouthCastleSolStoneswordKey = 1051577300,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Eclipse Shotel 1051577600")]
        MountaintopsOfTheGiantsSouthCastleSolEclipseShotel = 1051577600,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Helphen's Steeple 1051577720")]
        MountaintopsOfTheGiantsSouthCastleSolHelphensSteeple = 1051577720,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Somber Smithing Stone [7] 1051577800")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone7 = 1051577800,

        [Annotation(Name = "[Mountaintops of the Giants - South Castle Sol] Somber Smithing Stone [7] 1051577810")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone7_ = 1051577810,

        [Annotation(Name = "[Mountaintops of the Giants - Northwest of Freezing Lake] Golden Rune [4] 1052587800")]
        MountaintopsOfTheGiantsNorthwestOfFreezingLakeGoldenRune4 = 1052587800,

        [Annotation(Name = "[Mountaintops of the Giants - Northwest of Freezing Lake] Golden Rune [5] 1052587810")]
        MountaintopsOfTheGiantsNorthwestOfFreezingLakeGoldenRune5 = 1052587810,

        [Annotation(Name = "[Mountaintops of the Giants - Northwest of Freezing Lake] Golden Rune [10] 1052587820")]
        MountaintopsOfTheGiantsNorthwestOfFreezingLakeGoldenRune10 = 1052587820,

        [Annotation(Name = "[Mountaintops of the Giants - North Castle Sol] Haligtree Secret Medallion (Left) 1051587800")]
        MountaintopsOfTheGiantsNorthCastleSolHaligtreeSecretMedallionLeft = 1051587800,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Smithing Stone [7] 1047557000")]
        ConsecratedSnowfieldYeloughAnixRuinsSmithingStone7 = 1047557000,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Rimed Rowa 1047557010")]
        ConsecratedSnowfieldYeloughAnixRuinsRimedRowa = 1047557010,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Golden Rune [13] 1047557020")]
        ConsecratedSnowfieldYeloughAnixRuinsGoldenRune13 = 1047557020,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Stonesword Key 1047557030")]
        ConsecratedSnowfieldYeloughAnixRuinsStoneswordKey = 1047557030,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Golden Rune [7] 1047557040")]
        ConsecratedSnowfieldYeloughAnixRuinsGoldenRune7 = 1047557040,

        [Annotation(Name = "[Consecrated Snowfield - Yelough Anix Ruins] Unendurable Frenzy 1047557900")]
        ConsecratedSnowfieldYeloughAnixRuinsUnendurableFrenzy = 1047557900,

        [Annotation(Name = "[Consecrated Snowfield - North of Yelough Anix Ruins] Hero's Rune [2] 1047567300")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsHerosRune2 = 1047567300,

        [Annotation(Name = "[Consecrated Snowfield - North of Yelough Anix Ruins] Smithing Stone [8] 1047567310")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsSmithingStone8 = 1047567310,

        [Annotation(Name = "[Consecrated Snowfield - North of Yelough Anix Ruins] Thawfrost Boluses 1047567320")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsThawfrostBoluses = 1047567320,

        [Annotation(Name = "[Consecrated Snowfield - North of Yelough Anix Ruins] Crystal Dart 1047567330")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsCrystalDart = 1047567330,

        [Annotation(Name = "[Consecrated Snowfield - North of Yelough Anix Ruins] Sanguine Noble Hood 1047567700")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsSanguineNobleHood = 1047567700,

        [Annotation(Name = "[Consecrated Snowfield - Far West Cliffside] Golden Rune [1] 1046577300")]
        ConsecratedSnowfieldFarWestCliffsideGoldenRune1 = 1046577300,

        [Annotation(Name = "[Consecrated Snowfield - Far West Cliffside] Smithing Stone [7] 1046577800")]
        ConsecratedSnowfieldFarWestCliffsideSmithingStone7 = 1046577800,

        [Annotation(Name = "[Consecrated Snowfield - South of Ordina] Stonesword Key 1048567300")]
        ConsecratedSnowfieldSouthOfOrdinaStoneswordKey = 1048567300,

        [Annotation(Name = "[Consecrated Snowfield - South of Ordina] Map: Consecrated Snowfield 62052")]
        ConsecratedSnowfieldSouthOfOrdinaMapConsecratedSnowfield = 62052,

        [Annotation(Name = "[Consecrated Snowfield - South of Ordina] Somber Ancient Dragon Smithing Stone 1048567800")]
        ConsecratedSnowfieldSouthOfOrdinaSomberAncientDragonSmithingStone = 1048567800,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Rune Arc 1048577000")]
        ConsecratedSnowfieldOrdinaLiturgicalTownRuneArc = 1048577000,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Golden Rune [13] 1048577010")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune13 = 1048577010,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Hefty Beast Bone 1048577020")]
        ConsecratedSnowfieldOrdinaLiturgicalTownHeftyBeastBone = 1048577020,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Golden Rune [13] 1048577030")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune13_ = 1048577030,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Freezing Grease 1048577040")]
        ConsecratedSnowfieldOrdinaLiturgicalTownFreezingGrease = 1048577040,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Cuckoo Glintstone 1048577050")]
        ConsecratedSnowfieldOrdinaLiturgicalTownCuckooGlintstone = 1048577050,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Crystal Dart 1048577060")]
        ConsecratedSnowfieldOrdinaLiturgicalTownCrystalDart = 1048577060,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Old Fang 1048577070")]
        ConsecratedSnowfieldOrdinaLiturgicalTownOldFang = 1048577070,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Slumbering Egg 1048577080")]
        ConsecratedSnowfieldOrdinaLiturgicalTownSlumberingEgg = 1048577080,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Golden Rune [12] 1048577090")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune12 = 1048577090,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Invigorating Cured Meat 1048577300")]
        ConsecratedSnowfieldOrdinaLiturgicalTownInvigoratingCuredMeat = 1048577300,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Golden Rune [10] 1048577310")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune10 = 1048577310,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Explosive Ghostflame 1048577700")]
        ConsecratedSnowfieldOrdinaLiturgicalTownExplosiveGhostflame = 1048577700,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Golden Seed 1048577800")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenSeed = 1048577800,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Black Knife Hood 1048577810")]
        ConsecratedSnowfieldOrdinaLiturgicalTownBlackKnifeHood = 1048577810,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Ghost Glovewort [9] 1048577900")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9 = 1048577900,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Ghost Glovewort [9] 1048577910")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9_ = 1048577910,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Ghost Glovewort [9] 1048577920")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9__ = 1048577920,

        [Annotation(Name = "[Consecrated Snowfield - Ordina, Liturgical Town] Ghost Glovewort [9] 1048577930")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9___ = 1048577930,

        [Annotation(Name = "[Consecrated Snowfield - East of Apostate Derelict] Golden Rune [13] 1048587300")]
        ConsecratedSnowfieldEastOfApostateDerelictGoldenRune13 = 1048587300,

        [Annotation(Name = "[Consecrated Snowfield - Hidden Path to the Haligtree] Golden Rune [13] 1049547300")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeGoldenRune13 = 1049547300,

        [Annotation(Name = "[Consecrated Snowfield - Hidden Path to the Haligtree] Golden Rune [11] 1049547310")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeGoldenRune11 = 1049547310,

        [Annotation(Name = "[Consecrated Snowfield - Hidden Path to the Haligtree] Somber Smithing Stone [8] 1049547700")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeSomberSmithingStone8 = 1049547700,

        [Annotation(Name = "[Consecrated Snowfield - Hidden Path to the Haligtree] Nomadic Warrior's Cookbook [23] 67090")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeNomadicWarriorsCookbook23 = 67090,

        [Annotation(Name = "[Consecrated Snowfield - Hidden Path to the Haligtree] St. Trina's Torch 1049547900")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeStTrinasTorch = 1049547900,

        [Annotation(Name = "[Consecrated Snowfield - Southwest Foggy Area] Golden Rune [1] 1048547800")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune1 = 1048547800,

        [Annotation(Name = "[Consecrated Snowfield - Southwest Foggy Area] Golden Rune [3] 1048547810")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune3 = 1048547810,

        [Annotation(Name = "[Consecrated Snowfield - Southwest Foggy Area] Golden Rune [6] 1048547820")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune6 = 1048547820,

        [Annotation(Name = "[Consecrated Snowfield - Southwest Foggy Area] Golden Rune [9] 1048547830")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune9 = 1048547830,

        [Annotation(Name = "[Consecrated Snowfield - Southwest Foggy Area] Golden Rune [11] 1048547840")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune11 = 1048547840,

        [Annotation(Name = "[Consecrated Snowfield - Northwest Foggy Area] Golden Rune [13] 1048557300")]
        ConsecratedSnowfieldNorthwestFoggyAreaGoldenRune13 = 1048557300,

        [Annotation(Name = "[Consecrated Snowfield - Northwest Foggy Area] Stalwart Horn Charm +1 1048557600")]
        ConsecratedSnowfieldNorthwestFoggyAreaStalwartHornCharm1 = 1048557600,

        [Annotation(Name = "[Consecrated Snowfield - Northwest Foggy Area] Ancient Dragon Smithing Stone 1048557700")]
        ConsecratedSnowfieldNorthwestFoggyAreaAncientDragonSmithingStone = 1048557700,

        [Annotation(Name = "[Consecrated Snowfield - Northwest Foggy Area] Night's Cavalry Helm 1048557710")]
        ConsecratedSnowfieldNorthwestFoggyAreaNightsCavalryHelm = 1048557710,

        [Annotation(Name = "[Consecrated Snowfield - Northwest Foggy Area] Flowing Curved Sword 1048557900")]
        ConsecratedSnowfieldNorthwestFoggyAreaFlowingCurvedSword = 1048557900,

        [Annotation(Name = "[Consecrated Snowfield - Northeast Foggy Area] Somber Smithing Stone [9] 1049557300")]
        ConsecratedSnowfieldNortheastFoggyAreaSomberSmithingStone9 = 1049557300,

        [Annotation(Name = "[Consecrated Snowfield - Northeast Foggy Area] Old Fang 1049557310")]
        ConsecratedSnowfieldNortheastFoggyAreaOldFang = 1049557310,

        [Annotation(Name = "[Consecrated Snowfield - Northeast Foggy Area] Fire Blossom 1049557320")]
        ConsecratedSnowfieldNortheastFoggyAreaFireBlossom = 1049557320,

        [Annotation(Name = "[Consecrated Snowfield - Northeast Foggy Area] Miquella's Lily 1049557330")]
        ConsecratedSnowfieldNortheastFoggyAreaMiquellasLily = 1049557330,

        [Annotation(Name = "[Consecrated Snowfield - Northeast Foggy Area] Larval Tear 1049557700")]
        ConsecratedSnowfieldNortheastFoggyAreaLarvalTear = 1049557700,

        [Annotation(Name = "[Consecrated Snowfield - Northeast Foggy Area] Golden Seed 1049557800")]
        ConsecratedSnowfieldNortheastFoggyAreaGoldenSeed = 1049557800,

        [Annotation(Name = "[Consecrated Snowfield - Northeast Foggy Area] Golden Rune [11] 1049557810")]
        ConsecratedSnowfieldNortheastFoggyAreaGoldenRune11 = 1049557810,

        [Annotation(Name = "[Consecrated Snowfield - Southeast of Ordina] Albinauric Bloodclot 1049567300")]
        ConsecratedSnowfieldSoutheastOfOrdinaAlbinauricBloodclot = 1049567300,

        [Annotation(Name = "[Consecrated Snowfield - Southeast of Ordina] Old Fang 1049567310")]
        ConsecratedSnowfieldSoutheastOfOrdinaOldFang = 1049567310,

        [Annotation(Name = "[Consecrated Snowfield - Southeast of Ordina] Strip of White Flesh 1049567320")]
        ConsecratedSnowfieldSoutheastOfOrdinaStripOfWhiteFlesh = 1049567320,

        [Annotation(Name = "[Consecrated Snowfield - Southeast of Ordina] Dragonwound Grease 1049567330")]
        ConsecratedSnowfieldSoutheastOfOrdinaDragonwoundGrease = 1049567330,

        [Annotation(Name = "[Consecrated Snowfield - Southeast of Ordina] Nascent Butterfly 1049567340")]
        ConsecratedSnowfieldSoutheastOfOrdinaNascentButterfly = 1049567340,

        [Annotation(Name = "[Consecrated Snowfield - Southeast of Ordina] Smithing Stone [8] 1049567350")]
        ConsecratedSnowfieldSoutheastOfOrdinaSmithingStone8 = 1049567350,

        [Annotation(Name = "[Consecrated Snowfield - Southeast of Ordina] Glintstone Craftsman's Cookbook [8] 67440")]
        ConsecratedSnowfieldSoutheastOfOrdinaGlintstoneCraftsmansCookbook8 = 67440,

        [Annotation(Name = "[Consecrated Snowfield - East of Ordina] Somber Smithing Stone [7] 1049577700")]
        ConsecratedSnowfieldEastOfOrdinaSomberSmithingStone7 = 1049577700,

        [Annotation(Name = "[Consecrated Snowfield - East of Ordina] Somber Smithing Stone [8] 1049577710")]
        ConsecratedSnowfieldEastOfOrdinaSomberSmithingStone8 = 1049577710,

        [Annotation(Name = "[Consecrated Snowfield - East of Ordina] Somber Smithing Stone [9] 1049577720")]
        ConsecratedSnowfieldEastOfOrdinaSomberSmithingStone9 = 1049577720,

        [Annotation(Name = "[Mountaintops of the Giants - West of Castle Sol] Warming Stone 1050577300")]
        MountaintopsOfTheGiantsWestOfCastleSolWarmingStone = 1050577300,

        [Annotation(Name = "[Mountaintops of the Giants - West of Castle Sol] Starlight Shards 1050577800")]
        MountaintopsOfTheGiantsWestOfCastleSolStarlightShards = 1050577800,

        [Annotation(Name = "[Consecrated Snowfield - West of Ordina] Golden Rune [7] 1047577300")]
        ConsecratedSnowfieldWestOfOrdinaGoldenRune7 = 1047577300,

        [Annotation(Name = "[Consecrated Snowfield - West of Ordina] Golden Rune [12] 1047577310")]
        ConsecratedSnowfieldWestOfOrdinaGoldenRune12 = 1047577310,

        [Annotation(Name = "[Consecrated Snowfield - Apostate Derelict] Somber Smithing Stone [9] 1047587000")]
        ConsecratedSnowfieldApostateDerelictSomberSmithingStone9 = 1047587000,

        [Annotation(Name = "[Consecrated Snowfield - Apostate Derelict] Silver Mirrorshield 1047587800")]
        ConsecratedSnowfieldApostateDerelictSilverMirrorshield = 1047587800,

        [Annotation(Name = "[Consecrated Snowfield - Consecrated Snowfield Catacombs Entrance] Hefty Beast Bone 1050557300")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceHeftyBeastBone = 1050557300,

        [Annotation(Name = "[Consecrated Snowfield - Consecrated Snowfield Catacombs Entrance] Golden Rune [9] 1050557310")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceGoldenRune9 = 1050557310,

        [Annotation(Name = "[Consecrated Snowfield - Consecrated Snowfield Catacombs Entrance] Lump of Flesh 1050557320")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceLumpOfFlesh = 1050557320,

        [Annotation(Name = "[Consecrated Snowfield - Consecrated Snowfield Catacombs Entrance] Somber Smithing Stone [8] 1050557800")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceSomberSmithingStone8 = 1050557800,

        [Annotation(Name = "[Consecrated Snowfield - Consecrated Snowfield Catacombs Entrance] Rune Arc 1050557900")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceRuneArc = 1050557900,

        // DLC Items
        [Annotation(Name = "[Shadow Keep] Main-gauche 21007020")]
        ShadowKeepMaingauche = 21007020,

        [Annotation(Name = "[Stone Coffin Fissure] Velvet Sword of St. Trina 22007150")]
        StoneCoffinFissureVelvetSwordofStTrina = 22007150,

        [Annotation(Name = "[Gravesite Plain - Demi-Human Queen Marigga] Star-Lined Sword 530845")]
        GravesitePlainDemiHumanQueenMariggaStarLinedSword = 530845,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Carian Sorcery Sword 2047447820")]
        GravesitePlainWestCastleEnsisCarianSorcerySword = 2047447820,

        [Annotation(Name = "[Rauh Base - Ravine North] Stone-Sheathed Sword 2045477900")]
        RauhBaseRavineNorthStoneSheathedSword = 2045477900,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light 2045477500")]
        RauhBaseRavineNorthSwordofLight = 2045477500,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light +1 2045477510")]
        RauhBaseRavineNorthSwordofLight1 = 2045477510,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light +2 2045477520")]
        RauhBaseRavineNorthSwordofLight2 = 2045477520,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light +3 2045477530")]
        RauhBaseRavineNorthSwordofLight3 = 2045477530,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light +4 2045477540")]
        RauhBaseRavineNorthSwordofLight4 = 2045477540,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light +5 2045477550")]
        RauhBaseRavineNorthSwordofLight5 = 2045477550,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light +6 2045477560")]
        RauhBaseRavineNorthSwordofLight6 = 2045477560,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light +7 2045477570")]
        RauhBaseRavineNorthSwordofLight7 = 2045477570,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light +8 2045477580")]
        RauhBaseRavineNorthSwordofLight8 = 2045477580,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light +9 2045477590")]
        RauhBaseRavineNorthSwordofLight9 = 2045477590,

        [Annotation(Name = "[Rauh Base - Ravine North] Sword of Light +10 2045477600")]
        RauhBaseRavineNorthSwordofLight10 = 2045477600,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness 2045477700")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness = 2045477700,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness +1 2045477710")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness1 = 2045477710,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness +2 2045477720")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness2 = 2045477720,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness +3 2045477730")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness3 = 2045477730,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness +4 2045477740")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness4 = 2045477740,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness +5 2045477750")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness5 = 2045477750,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness +6 2045477760")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness6 = 2045477760,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness +7 2045477770")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness7 = 2045477770,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness +8 2045477780")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness8 = 2045477780,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness +9 2045477790")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness9 = 2045477790,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Sword of Darkness +10 2045477800")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness10 = 2045477800,

        [Annotation(Name = "[Gravesite Plain - Blackgaol Knight] Greatsword of Solitude, Solitude Set 530820")]
        GravesitePlainBlackgaolKnightGreatswordofSolitude = 530820,

        [Annotation(Name = "[Ruined Forge of Starfall Past] Ancient Meteoric Ore Greatsword 42027000")]
        RuinedForgeofStarfallPastAncientMeteoricOreGreatsword = 42027000,

        [Annotation(Name = "[Gravesite Plain - Moonrithyll, Carian Knight] Moonrithyll's Knight Sword 530865")]
        GravesitePlainMoonrithyllCarianKnightMoonrithyllsKnightSword = 530865,

        [Annotation(Name = "[Shadow Keep] Queelign's Greatsword 400692")]
        ShadowKeepQueelignsGreatsword = 400692,

        [Annotation(Name = "[Cerulean Coast - Ravine South] Spirit Sword 2047397000")]
        CeruleanCoastRavineSouthSpiritSword = 2047397000,

        [Annotation(Name = "[Enir-Ilim - Hornsent] Falx, Hornsent Set 400614")]
        EnirIlimHornsentFalx = 400614,

        [Annotation(Name = "[Belurat - Horned Warrior] Horned Warrior's Sword 20007993")]
        BeluratHornedWarriorHornedWarriorsSword = 20007993,

        [Annotation(Name = "[Enir-Ilim, or earlier places] Freyja's Greatsword, Freyja's Set 400602")]
        EnirIlimFreyjasGreatsword = 400602,

        [Annotation(Name = "[Enir-Ilim - Horned Warrior] Horned Warrior's Greatsword 20017991")]
        EnirIlimHornedWarriorHornedWarriorsGreatsword = 20017991,

        [Annotation(Name = "[Scadu Altus - Cathedral of Manus Metyr] Sword of Night 400671")]
        ScaduAltusCathedralofManusMetyrSwordofNight = 400671,

        [Annotation(Name = "[Belurat] Euporia 20007330")]
        BeluratEuporia = 20007330,

        [Annotation(Name = "[Scadu Altus - Black Knight] Black Steel Twinblade 2048467710")]
        ScaduAltusBlackKnightBlackSteelTwinblade = 2048467710,

        [Annotation(Name = "[Finger Ruins of Rhia - Climb to Finger-Weaver's Hovel] Flowerstone Gavel 400704")]
        FingerRuinsofRhiaClimbtoFingerWeaversHovelFlowerstoneGavel = 400704,

        [Annotation(Name = "[Taylew's Ruined Forge] Smithscript Greathammer 42037160")]
        TaylewsRuinedForgeSmithscriptGreathammer = 42037160,

        [Annotation(Name = "[Ruined Forge Lava Intake] Anvil Hammer 42007000")]
        RuinedForgeLavaIntakeAnvilHammer = 42007000,

        [Annotation(Name = "[Gravesite Plain - Black Knight] Black Steel Greathammer 2048417980")]
        GravesitePlainBlackKnightBlackSteelGreathammer = 2048417980,

        [Annotation(Name = "[Gravesite Plain - Bloodfiend] Bloodfiend's Arm 2045417950")]
        GravesitePlainBloodfiendBloodfiendsArm = 2045417950,

        [Annotation(Name = "[Gravesite Plain - North Fog Rift Fort] Serpent Flail 2047457900")]
        GravesitePlainNorthFogRiftFortSerpentFlail = 2047457900,

        [Annotation(Name = "[Taylew's Ruined Forge] Smithscript Axe 42037100")]
        TaylewsRuinedForgeSmithscriptAxe = 42037100,

        [Annotation(Name = "[Fog Rift Catacombs - Death Knight] Death Knight's Twin Axes, Crimson Amber Medallion +3 520700")]
        FogRiftCatacombsDeathKnightDeathKnightsTwinAxes = 520700,

        [Annotation(Name = "[Scorpion River Catacombs - Death Knight] Death Knight's Longhaft Axe 520710")]
        ScorpionRiverCatacombsDeathKnightDeathKnightsLonghaftAxe = 520710,

        [Annotation(Name = "[Scadu Altus - Main Bonny Village] Bonny Butchering Knife 2050447050")]
        ScaduAltusMainBonnyVillageBonnyButcheringKnife = 2050447050,

        [Annotation(Name = "[Ruined Forge of Starfall Past] Smithscript Spear 42027050")]
        RuinedForgeofStarfallPastSmithscriptSpear = 42027050,

        [Annotation(Name = "[Gravesite Plain - East of Ensis Castle Front] Swift Spear 2047437030")]
        GravesitePlainEastofEnsisCastleFrontSwiftSpear = 2047437030,

        [Annotation(Name = "[Ancient Ruins Base - Bloodfiend] Bloodfiend's Sacred Spear 2047477950")]
        AncientRuinsBaseBloodfiendBloodfiendsSacredSpear = 2047477950,

        [Annotation(Name = "[Abyssal Woods - Jori, Elder Inquisitor] Barbed Staff-Spear 510610")]
        AbyssalWoodsJoriElderInquisitorBarbedStaffSpear = 510610,

        [Annotation(Name = "[Gravesite Plain - South of Church of Consolation] Spirit Glaive 2048407010")]
        GravesitePlainSouthofChurchofConsolationSpiritGlaive = 2048407010,

        [Annotation(Name = "[Scadu Altus - Bridge Leading to the Village] Tooth Whip 2051447000")]
        ScaduAltusBridgeLeadingtotheVillageToothWhip = 2051447000,

        [Annotation(Name = "[Enir-Ilim] Thiollier's Hidden Needle, Thiollier's Set 400634")]
        EnirIlimThiolliersHiddenNeedle = 400634,

        [Annotation(Name = "[Gravesite Plain - Church of Benediction] Pata 2046407000")]
        GravesitePlainChurchofBenedictionPata = 2046407000,

        [Annotation(Name = "[Belurat] Poisoned Hand 20007300")]
        BeluratPoisonedHand = 20007300,

        [Annotation(Name = "[Abyssal Woods - Madding Hand] Madding Hand 2052427500")]
        AbyssalWoodsMaddingHandMaddingHand = 2052427500,

        [Annotation(Name = "[Bonny Gaol] Shield of Night 41017220")]
        BonnyGaolShieldofNight = 41017220,

        [Annotation(Name = "[Scadu Altus - Swordhand of Night Anna] Claws of Night 400672")]
        ScaduAltusSwordhandofNightAnnaClawsofNight = 400672,

        [Annotation(Name = "[Rauh Base - Crucible Knight Devonia] Devonia's Hammer 2045477400")]
        RauhBaseCrucibleKnightDevoniaDevoniasHammer = 2045477400,

        [Annotation(Name = "[Midra's Manse] Nanaya's Torch 28007100")]
        MidrasManseNanayasTorch = 28007100,

        [Annotation(Name = "[Lamenter's Gaol] Lamenting Visage 41027130")]
        LamentersGaolLamentingVisage = 41027130,

        [Annotation(Name = "[Taylew's Ruined Forge] Smithscript Shield 42037120")]
        TaylewsRuinedForgeSmithscriptShield = 42037120,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Wolf Crest Shield 2047447830")]
        GravesitePlainWestCastleEnsisWolfCrestShield = 2047447830,

        [Annotation(Name = "[Gravesite Plain - South of Dragon Lake] Serpent Crest Shield 580400")]
        GravesitePlainSouthofDragonLakeSerpentCrestShield = 580400,

        [Annotation(Name = "[Gravesite Plain - Redmane Freyja] Golden Lion Shield 400600")]
        GravesitePlainRedmaneFreyjaGoldenLionShield = 400600,

        [Annotation(Name = "[Gravesite Plain - Black Knight Garrew] Black Steel Greatshield 530955")]
        GravesitePlainBlackKnightGarrewBlackSteelGreatshield = 530955,

        [Annotation(Name = "[Gravesite Plain - Belurat Main Gate Cross] Verdigris Greatshield, Verdigris Set 400645")]
        GravesitePlainBeluratMainGateCrossVerdigrisGreatshield = 400645,

        [Annotation(Name = "[Scadu Altus - Count Ymir, Mother of Fingers] Maternal Staff, High Priest Set, Ymir's Bell Bearing 400664")]
        ScaduAltusCountYmirMotherofFingersMaternalStaff = 400664,

        [Annotation(Name = "[Scadu Altus - Bonny Village North Tree and Overlook] Dryleaf Seal 2050457020")]
        ScaduAltusBonnyVillageNorthTreeandOverlookDryleafSeal = 2050457020,

        [Annotation(Name = "[Shadow Keep] Fire Knight's Seal 21007650")]
        ShadowKeepFireKnightsSeal = 21007650,

        [Annotation(Name = "[Belurat] Bone Bow 20007600")]
        BeluratBoneBow = 20007600,

        [Annotation(Name = "[Specimen Storehouse - Needle Knight Leda] Ansbach's Longbow 400595")]
        SpecimenStorehouseNeedleKnightLedaAnsbachsLongbow = 400595,

        [Annotation(Name = "[Specimen Storehouse - Sir Ansbach] Ansbach's Longbow 400623")]
        SpecimenStorehouseSirAnsbachAnsbachsLongbow = 400623,

        [Annotation(Name = "[Foot of the Jagged Peak - Foot of the Jagged Peak] Igon's Greatbow with Ash of War: Igon's Drake Hunt, Igon's Set, Igon's Bell Bearing 400712")]
        FootoftheJaggedPeakFootoftheJaggedPeakIgonsGreatbowwithAshofWarIgonsDrakeHunt = 400712,

        [Annotation(Name = "[Foot of the Jagged Peak - Foot of the Jagged Peak] Igon's Greatbow, Igon's Set, Igon's Bell Bearing 400714")]
        FootoftheJaggedPeakFootoftheJaggedPeakIgonsGreatbow = 400714,

        [Annotation(Name = "[Gravesite Plain - Igon] Igon's Greatbow, Igon's Set, Igon's Bell Bearing 400711")]
        GravesitePlainIgonIgonsGreatbow = 400711,

        [Annotation(Name = "[Gravesite Plain - Southeast Poison Swamp] Repeating Crossbow 2049437000")]
        GravesitePlainSoutheastPoisonSwampRepeatingCrossbow = 2049437000,

        [Annotation(Name = "[Gravesite Plain - East of Ensis Castle Front] Spread Crossbow 2047437010")]
        GravesitePlainEastofEnsisCastleFrontSpreadCrossbow = 2047437010,

        [Annotation(Name = "[Scadu Altus - Road to Manus Metyr] Rabbath's Cannon 2051467900")]
        ScaduAltusRoadtoManusMetyrRabbathsCannon = 2051467900,

        [Annotation(Name = "[Scadu Altus - Moorth Ruins] Dryleaf Arts with Ash of War: Palm Blast, Dane's Hat 400730")]
        ScaduAltusMoorthRuinsDryleafArtswithAshofWarPalmBlast = 400730,

        [Annotation(Name = "[Enir-Ilim] Dane's Footwork 400732")]
        EnirIlimDanesFootwork = 400732,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Firespark Perfume Bottle 2047447840")]
        GravesitePlainWestCastleEnsisFiresparkPerfumeBottle = 2047447840,

        [Annotation(Name = "[Lamenter's Gaol] Chilling Perfume Bottle 41027100")]
        LamentersGaolChillingPerfumeBottle = 41027100,

        [Annotation(Name = "[Abyssal Woods - Abandoned Church] Frenzyflame Perfume Bottle 2053417000")]
        AbyssalWoodsAbandonedChurchFrenzyflamePerfumeBottle = 2053417000,

        [Annotation(Name = "[Gravesite Plain - South of Church of Consolation] Lightning Perfume Bottle 2048407000")]
        GravesitePlainSouthofChurchofConsolationLightningPerfumeBottle = 2048407000,

        [Annotation(Name = "[Specimen Storehouse] Dueling Shield with Ash of War: Shield Strike 21017150")]
        SpecimenStorehouseDuelingShieldwithAshofWarShieldStrike = 21017150,

        [Annotation(Name = "[Specimen Storehouse] Carian Thrusting Shield 21017620")]
        SpecimenStorehouseCarianThrustingShield = 21017620,

        [Annotation(Name = "[Ruined Forge Lava Intake] Smithscript Dagger 42007150")]
        RuinedForgeLavaIntakeSmithscriptDagger = 42007150,

        [Annotation(Name = "[Gravesite Plain - North of Scorched Ruins] Backhand Blade with Ash of War: Blind Spot 2047427700")]
        GravesitePlainNorthofScorchedRuinsBackhandBladewithAshofWarBlindSpot = 2047427700,

        [Annotation(Name = "[Ruined Forge of Starfall Past] Smithscript Cirque 42027060")]
        RuinedForgeofStarfallPastSmithscriptCirque = 42027060,

        [Annotation(Name = "[Dragon's Pit - Ancient Dragon-Man] Dragon-Hunter's Great Katana 520810")]
        DragonsPitAncientDragonManDragonHuntersGreatKatana = 520810,

        [Annotation(Name = "[Scadu Altus - Rakshasa] Rakshasa's Great Katana, Rakshasa Set 530830")]
        ScaduAltusRakshasaRakshasasGreatKatana = 530830,

        [Annotation(Name = "[Gravesite Plain - Dragon Lake] Great Katana with Ash of War: Overhead Stance 2045447010")]
        GravesitePlainDragonLakeGreatKatanawithAshofWarOverheadStance = 2045447010,

        [Annotation(Name = "[Dragon's Pit - Ancient Dragon-Man] Dragon-Hunter's Great Katana 520810")]
        DragonsPitAncientDragonManDragonHuntersGreatKatana_ = 520810,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Milady 2047447800")]
        GravesitePlainWestCastleEnsisMilady = 2047447800,

        [Annotation(Name = "[Enir-Ilim - Needle Knight Leda] Leda's Sword 510420")]
        EnirIlimNeedleKnightLedaLedasSword = 510420,

        [Annotation(Name = "[Gravesite Plain - Logur, the Beast Claw] Beast Claw (Weapon 68500000) with Ash of War: Savage Claws 2047407980")]
        GravesitePlainLogurtheBeastClawBeastClawWeapon68500000withAshofWarSavageClaws = 2047407980,

        [Annotation(Name = "[Rauh Base - Red Bear] Red Bear's Claw, Iron Rivet Set 530900")]
        RauhBaseRedBearRedBearsClaw = 530900,

        [Annotation(Name = "[Scadu Altus - Main Bonny Village] Dryleaf Set 2050447720")]
        ScaduAltusMainBonnyVillageDryleafSet = 2050447720,

        [Annotation(Name = "[Scaduview - Albinauric Archer] Gaius's Greaves 2049490900")]
        ScaduviewAlbinauricArcherGaiussGreaves = 2049490900,

        [Annotation(Name = "[Gravesite Plain - Church of Benediction] Oathseeker Knight Helm 2046407001")]
        GravesitePlainChurchofBenedictionOathseekerKnightHelm = 2046407001,

        [Annotation(Name = "[Enir-Ilim] Leda's Armor 400598")]
        EnirIlimLedasArmor = 400598,

        [Annotation(Name = "[Gravesite Plain - Church of Benediction] Oathseeker Knight Gauntlets 2046407003")]
        GravesitePlainChurchofBenedictionOathseekerKnightGauntlets = 2046407003,

        [Annotation(Name = "[Gravesite Plain - Church of Benediction] Oathseeker Knight Greaves 2046407004")]
        GravesitePlainChurchofBenedictionOathseekerKnightGreaves = 2046407004,

        [Annotation(Name = "[Gravesite Plain - Church of Benediction] Oathseeker Knight Armor 2046407002")]
        GravesitePlainChurchofBenedictionOathseekerKnightArmor = 2046407002,

        [Annotation(Name = "[Scadu Altus - Ralva the Great Red Bear] Pelt of Ralva 530930")]
        ScaduAltusRalvatheGreatRedBearPeltofRalva = 530930,

        [Annotation(Name = "[Cerulean Coast - Dancer of Ranah] Dancer's Set, Dancing Blade of Ranah 530810")]
        CeruleanCoastDancerofRanahDancersSet = 530810,

        [Annotation(Name = "[Bonny Gaol] Night Set 41017300")]
        BonnyGaolNightSet = 41017300,

        [Annotation(Name = "[Specimen Storehouse - Sir Ansbach] Ansbach's Set 400622")]
        SpecimenStorehouseSirAnsbachAnsbachsSet = 400622,

        [Annotation(Name = "[Enir-Ilim] Ansbach's Set, Furious Blade of Ansbach, Obsidian Lamina 400624")]
        EnirIlimAnsbachsSet = 400624,

        [Annotation(Name = "[Specimen Storehouse] Ansbach's Set, Ansbach's Longbow, Letter for Freyja 400625")]
        SpecimenStorehouseAnsbachsSet = 400625,

        [Annotation(Name = "[Shadow Keep - Fire Knight] Death Mask Helm 21007995")]
        ShadowKeepFireKnightDeathMaskHelm = 21007995,

        [Annotation(Name = "[Specimen Storehouse - Fire Knight] Winged Serpent Helm, Ash of War: Flame Spear 21017991")]
        SpecimenStorehouseFireKnightWingedSerpentHelm = 21017991,

        [Annotation(Name = "[Shadow Keep - Fire Knight] Salza's Hood, Rain of Fire 21027991")]
        ShadowKeepFireKnightSalzasHood = 21027991,

        [Annotation(Name = "[Rauh Base - Northwest Great Red Bear Area] Highland Warrior Set 2044477010")]
        RauhBaseNorthwestGreatRedBearAreaHighlandWarriorSet = 2044477010,

        [Annotation(Name = "[Scadu Altus - Moorth Highway Camp] Highland Warrior Set 2049457200")]
        ScaduAltusMoorthHighwayCampHighlandWarriorSet = 2049457200,

        [Annotation(Name = "[Darklight Catacombs] Death Knight Set 40027130")]
        DarklightCatacombsDeathKnightSet = 40027130,

        [Annotation(Name = "[Enir-Ilim] Gravebird Helm 20017500")]
        EnirIlimGravebirdHelm = 20017500,

        [Annotation(Name = "[Rauh Base - Rot Area] Gravebird's Blackquill Armor 2045467070")]
        RauhBaseRotAreaGravebirdsBlackquillArmor = 2045467070,

        [Annotation(Name = "[Gravesite Plain - Pillar Path Waypoint] Gravebird Bracelets 2048427020")]
        GravesitePlainPillarPathWaypointGravebirdBracelets = 2048427020,

        [Annotation(Name = "[Scadu Altus - Poison Swamp] Gravebird Anklets 2049467010")]
        ScaduAltusPoisonSwampGravebirdAnklets = 2049467010,

        [Annotation(Name = "[Gravesite Plain - Dragon Lake] Gravebird Armor 2045447020")]
        GravesitePlainDragonLakeGravebirdArmor = 2045447020,

        [Annotation(Name = "[Enir-Ilim] Circlet of Light 20017981")]
        EnirIlimCircletofLight = 20017981,

        [Annotation(Name = "[Belurat] Divine Beast Head 20007810")]
        BeluratDivineBeastHead = 20007810,

        [Annotation(Name = "[Stone Coffin Fissure] St. Trina's Blossom 400740")]
        StoneCoffinFissureStTrinasBlossom = 400740,

        [Annotation(Name = "[Belurat Gaol] Greatjar 41007250")]
        BeluratGaolGreatjar = 41007250,

        [Annotation(Name = "[Scorpion River Catacombs] Imp Head (Lion) 40017070")]
        ScorpionRiverCatacombsImpHeadLion = 40017070,

        [Annotation(Name = "[Scorpion River Catacombs - Death Knight] Cerulean Amber Medallion +3 520711")]
        ScorpionRiverCatacombsDeathKnightCeruleanAmberMedallion3 = 520711,

        [Annotation(Name = "[Darklight Catacombs] Viridian Amber Medallion +3 40027020")]
        DarklightCatacombsViridianAmberMedallion3 = 40027020,

        [Annotation(Name = "[Rauh Base - Temple Town Ruins] Two-Headed Turtle Talisman 2046457000")]
        RauhBaseTempleTownRuinsTwoHeadedTurtleTalisman = 2046457000,

        [Annotation(Name = "[Bonny Gaol] Stalwart Horn Charm +2 41017020")]
        BonnyGaolStalwartHornCharm2 = 41017020,

        [Annotation(Name = "[Belurat - Ulcerated Tree Spirit] Immunizing Horn Charm +2 20007991")]
        BeluratUlceratedTreeSpiritImmunizingHornCharm2 = 20007991,

        [Annotation(Name = "[Lamenter's Gaol] Clarifying Horn Charm +2 41027210")]
        LamentersGaolClarifyingHornCharm2 = 41027210,

        [Annotation(Name = "[Rauh Base - Rot Area] Mottled Necklace +2 2045467900")]
        RauhBaseRotAreaMottledNecklace2 = 2045467900,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Spelldrake Talisman +3 2047447190")]
        GravesitePlainWestCastleEnsisSpelldrakeTalisman3 = 2047447190,

        [Annotation(Name = "[Gravesite Plain - Southeast Poison Swamp] Flamedrake Talisman +3 2049437270")]
        GravesitePlainSoutheastPoisonSwampFlamedrakeTalisman3 = 2049437270,

        [Annotation(Name = "[Specimen Storehouse] Boltdrake Talisman +3 21017100")]
        SpecimenStorehouseBoltdrakeTalisman3 = 21017100,

        [Annotation(Name = "[Scadu Altus - Church District Highroad] Golden Braid 2051477510")]
        ScaduAltusChurchDistrictHighroadGoldenBraid = 2051477510,

        [Annotation(Name = "[Specimen Storehouse] Pearldrake Talisman +3 21017120")]
        SpecimenStorehousePearldrakeTalisman3 = 21017120,

        [Annotation(Name = "[Finger Ruins of Rhia - Northwest] Crimson Seed Talisman +1 2050407000")]
        FingerRuinsofRhiaNorthwestCrimsonSeedTalisman1 = 2050407000,

        [Annotation(Name = "[Finger Ruins of Dheo - West] Cerulean Seed Talisman +1 2053467600")]
        FingerRuinsofDheoWestCeruleanSeedTalisman1 = 2053467600,

        [Annotation(Name = "[Gravesite Plain - Church of Benediction] Blessed Blue Dew Talisman 2046407700")]
        GravesitePlainChurchofBenedictionBlessedBlueDewTalisman = 2046407700,

        [Annotation(Name = "[Rauh Base - Northeast Great Red Bear Area] Fine Crucible Feather Talisman 2045487000")]
        RauhBaseNortheastGreatRedBearAreaFineCrucibleFeatherTalisman = 2045487000,

        [Annotation(Name = "[Gravesite Plain - Cliffroad Terminus] Outer God Heirloom 2045417800")]
        GravesitePlainCliffroadTerminusOuterGodHeirloom = 2045417800,

        [Annotation(Name = "[Scadu Altus - Moorth Ruins] Shattered Stone Talisman 2049447090")]
        ScaduAltusMoorthRuinsShatteredStoneTalisman = 2049447090,

        [Annotation(Name = "[Rauh Base - Temple Town Ruins] Two-Handed Sword Talisman 2046457910")]
        RauhBaseTempleTownRuinsTwoHandedSwordTalisman = 2046457910,

        [Annotation(Name = "[Belurat - Fire Knight Queelign] Crusade Insignia 400694")]
        BeluratFireKnightQueelignCrusadeInsignia = 400694,

        [Annotation(Name = "[Finger Ruins of Rhia - Winter-Lantern] Aged One's Exultation 2051417700")]
        FingerRuinsofRhiaWinterLanternAgedOnesExultation = 2051417700,

        [Annotation(Name = "[Gravesite Plain - North Fog Rift Fort] Arrow's Soaring Sting Talisman 2047457910")]
        GravesitePlainNorthFogRiftFortArrowsSoaringStingTalisman = 2047457910,

        [Annotation(Name = "[Rauh Base - Bloodfiend Cave] Pearl Shield Talisman 2047477900")]
        RauhBaseBloodfiendCavePearlShieldTalisman = 2047477900,

        [Annotation(Name = "[Belurat] Dried Bouquet 20007630")]
        BeluratDriedBouquet = 20007630,

        [Annotation(Name = "[Ruined Forge of Starfall Past] Smithing Talisman 42027030")]
        RuinedForgeofStarfallPastSmithingTalisman = 42027030,

        [Annotation(Name = "[Gravesite Plain - Greatbridge North] Ailment Talisman 2046447030")]
        GravesitePlainGreatbridgeNorthAilmentTalisman = 2046447030,

        [Annotation(Name = "[Scadu Altus - Needle Knight Leda] Retaliatory Crossed-Tree 400592")]
        ScaduAltusNeedleKnightLedaRetaliatoryCrossedTree = 400592,

        [Annotation(Name = "[Scadu Altus - Needle Knight Leda] Lacerating Crossed-Tree 400590")]
        ScaduAltusNeedleKnightLedaLaceratingCrossedTree = 400590,

        [Annotation(Name = "[Scaduview - Scadutree Chalice] Sharpshot Talisman 2049497510")]
        ScaduviewScadutreeChaliceSharpshotTalisman = 2049497510,

        [Annotation(Name = "[Stone Coffin Fissure - Thiollier] St. Trina's Smile 400632")]
        StoneCoffinFissureThiollierStTrinasSmile = 400632,

        [Annotation(Name = "[Gravesite Plain - Elder's Hovel] Talisman of the Dread 2049427000")]
        GravesitePlainEldersHovelTalismanoftheDread = 2049427000,

        [Annotation(Name = "[Scadu Altus - Count Ymir, High Priest] Beloved Stardust, Ruins Map (2nd) 400661")]
        ScaduAltusCountYmirHighPriestBelovedStardust = 400661,

        [Annotation(Name = "[Shadow Keep] Talisman of Lord's Bestowal 21007070")]
        ShadowKeepTalismanofLordsBestowal = 21007070,

        [Annotation(Name = "[Rauh Base - Fire Spritestone Cave] Verdigris Discus 2046477720")]
        RauhBaseFireSpritestoneCaveVerdigrisDiscus = 2046477720,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Rellana's Cameo 2047447700")]
        GravesitePlainWestCastleEnsisRellanasCameo = 2047447700,

        [Annotation(Name = "[Gravesite Plain - Scorched Ruins] Blade of Mercy 2047417800")]
        GravesitePlainScorchedRuinsBladeofMercy = 2047417800,

        [Annotation(Name = "[Ancient Ruins of Rauh - South Church of the Bud] Talisman of All Crucibles 2044457900")]
        AncientRuinsofRauhSouthChurchoftheBudTalismanofAllCrucibles = 2044457900,

        [Annotation(Name = "[Rauh Base - Fire Spritestone Cave] Ash of War: Dryleaf Whirlwind 2046477150")]
        RauhBaseFireSpritestoneCaveAshofWarDryleafWhirlwind = 2046477150,

        [Annotation(Name = "[Gravesite Plain - Black Knight Edredd] Ash of War: Aspects of the Crucible: Wings 530965")]
        GravesitePlainBlackKnightEdreddAshofWarAspectsoftheCrucibleWings = 530965,

        [Annotation(Name = "[Gravesite Plain - Scarab] Ash of War: Piercing Throw 540902")]
        GravesitePlainScarabAshofWarPiercingThrow = 540902,

        [Annotation(Name = "[Scadu Altus - Scarab] Ash of War: Scattershot Throw 540910")]
        ScaduAltusScarabAshofWarScattershotThrow = 540910,

        [Annotation(Name = "[Shadow Keep - West Rampart] Ash of War: Wall of Sparks 21027020")]
        ShadowKeepWestRampartAshofWarWallofSparks = 21027020,

        [Annotation(Name = "[Scadu Altus - Scarab] Ash of War: Rolling Sparks 540904")]
        ScaduAltusScarabAshofWarRollingSparks = 540904,

        [Annotation(Name = "[Scadu Altus - Scarab] Ash of War: Raging Beast 540906")]
        ScaduAltusScarabAshofWarRagingBeast = 540906,

        [Annotation(Name = "[Shadow Keep - Needle Knight Leda] Ash of War: Swift Slash 400594")]
        ShadowKeepNeedleKnightLedaAshofWarSwiftSlash = 400594,

        [Annotation(Name = "[Gravesite Plain - East Castle Ensis] Ash of War: Wing Stance 2048447810")]
        GravesitePlainEastCastleEnsisAshofWarWingStance = 2048447810,

        [Annotation(Name = "[Fog Rift Catacombs] Ash of War: Blinkbolt 40007900")]
        FogRiftCatacombsAshofWarBlinkbolt = 40007900,

        [Annotation(Name = "[Belurat - Fire Knight Queelign] Ash of War: Flame Skewer, Prayer Room Key 400696")]
        BeluratFireKnightQueelignAshofWarFlameSkewer = 400696,

        [Annotation(Name = "[Gravesite Plain - South of Dragon Lake] Ash of War: Savage Lion's Claw 2045437700")]
        GravesitePlainSouthofDragonLakeAshofWarSavageLionsClaw = 2045437700,

        [Annotation(Name = "[Scadu Altus - Scarab] Ash of War: Carian Sovereignty 540900")]
        ScaduAltusScarabAshofWarCarianSovereignty = 540900,

        [Annotation(Name = "[Belurat] Ash of War: Shriek of Sorrow 20007410")]
        BeluratAshofWarShriekofSorrow = 20007410,

        [Annotation(Name = "[Cerulean Coast - Death Rite Bird] Ash of War: Ghostflame Call 530855")]
        CeruleanCoastDeathRiteBirdAshofWarGhostflameCall = 530855,

        [Annotation(Name = "[Rauh Base - Scarab] Ash of War: The Poison Flower Blooms Twice 540916")]
        RauhBaseScarabAshofWarThePoisonFlowerBloomsTwice = 540916,

        [Annotation(Name = "[Jagged Peak - Between Jagged Peak Mountainside and Summit] Rock Heart 580420")]
        JaggedPeakBetweenJaggedPeakMountainsideandSummitRockHeart = 580420,

        [Annotation(Name = "[Lamenter's Gaol - Lamenter] Lamenter's Mask 520770")]
        LamentersGaolLamenterLamentersMask = 520770,

        [Annotation(Name = "[Shadow Keep] Iris of Grace 21007800")]
        ShadowKeepIrisofGrace = 21007800,

        [Annotation(Name = "[Shadow Keep - West Rampart] Iris of Grace 21027040")]
        ShadowKeepWestRampartIrisofGrace = 21027040,

        [Annotation(Name = "[Shadow Keep - Ulcerated Tree Spirit] Iris of Occultation 21007993")]
        ShadowKeepUlceratedTreeSpiritIrisofOccultation = 21007993,

        [Annotation(Name = "[Gravesite Plain - Omenkiller] Iris of Occultation 2049437940")]
        GravesitePlainOmenkillerIrisofOccultation = 2049437940,

        [Annotation(Name = "[Gravesite Plain - Thiollier] Thiollier's Concoction 400630")]
        GravesitePlainThiollierThiolliersConcoction = 400630,

        [Annotation(Name = "[Lamenter's Gaol] Prattling Pate \"Lamentation\" 41027010")]
        LamentersGaolPrattlingPateLamentation = 41027010,

        [Annotation(Name = "[Scaduview - Commander Gaius] Remembrance of the Wild Boar Rider 510640")]
        ScaduviewCommanderGaiusRemembranceoftheWildBoarRider = 510640,

        [Annotation(Name = "[Scaduview - Scadutree Avatar] Remembrance of the Shadow Sunflower, Miquella's Great Rune 510620")]
        ScaduviewScadutreeAvatarRemembranceoftheShadowSunflower = 510620,

        [Annotation(Name = "[Gravesite Plain - Rellana, Twin Moon Knight] Remembrance of the Twin Moon Knight 510900")]
        GravesitePlainRellanaTwinMoonKnightRemembranceoftheTwinMoonKnight = 510900,

        [Annotation(Name = "[Ancient Ruins of Rauh - Romina, Saint of the Bud] Remembrance of the Saint of the Bud 510600")]
        AncientRuinsofRauhRominaSaintoftheBudRemembranceoftheSaintoftheBud = 510600,

        [Annotation(Name = "[Belurat - Divine Beast Dancing Lion] Remembrance of the Dancing Lion 510400")]
        BeluratDivineBeastDancingLionRemembranceoftheDancingLion = 510400,

        [Annotation(Name = "[Enir-Ilim - Radahn, Consort of Miquella] Remembrance of a God and a Lord 510430")]
        EnirIlimRadahnConsortofMiquellaRemembranceofaGodandaLord = 510430,

        [Annotation(Name = "[Midra's Manse - Midra, Lord of Frenzied Flame] Remembrance of the Lord of Frenzied Flame 510560")]
        MidrasManseMidraLordofFrenziedFlameRemembranceoftheLordofFrenziedFlame = 510560,

        [Annotation(Name = "[Finger Birthing Grounds - Metyr, Mother of Fingers] Remembrance of the Mother of Fingers 510550")]
        FingerBirthingGroundsMetyrMotherofFingersRemembranceoftheMotherofFingers = 510550,

        [Annotation(Name = "[Stone Coffin Fissure - Putrescent Knight] Remembrance of Putrescence 510480")]
        StoneCoffinFissurePutrescentKnightRemembranceofPutrescence = 510480,

        [Annotation(Name = "[Ancient Ruins of Rauh - East Ruins North Pit and Tunnels] Bondstone 2046487010")]
        AncientRuinsofRauhEastRuinsNorthPitandTunnelsBondstone = 2046487010,

        [Annotation(Name = "[Rauh Base - Fire Spritestone Cave] Fire Spritestone 2046477060")]
        RauhBaseFireSpritestoneCaveFireSpritestone = 2046477060,

        [Annotation(Name = "[Gravesite Plain - Ulcerated Tree Spirit] Horned Bairn 2047437980")]
        GravesitePlainUlceratedTreeSpiritHornedBairn = 2047437980,

        [Annotation(Name = "[Cerulean Coast - Southern Nameless Mausoleum] Perfumed Oil of Ranah 2046387070")]
        CeruleanCoastSouthernNamelessMausoleumPerfumedOilofRanah = 2046387070,

        [Annotation(Name = "[Lamenter's Gaol] Call of Tibia 41027110")]
        LamentersGaolCallofTibia = 41027110,

        [Annotation(Name = "[Cerulean Coast - Cerulean Coast] Call of Tibia 2048397030")]
        CeruleanCoastCeruleanCoastCallofTibia = 2048397030,

        [Annotation(Name = "[Midra's Manse] Surging Frenzied Flame 3x 28007050")]
        MidrasManseSurgingFrenziedFlame3x = 28007050,

        [Annotation(Name = "[Shadow Keep] Golden Vow (Goods 2003170) 21007040")]
        ShadowKeepGoldenVowGoods2003170 = 21007040,

        [Annotation(Name = "[Shadow Keep] Golden Vow (Goods 2003170) 3x 21007090")]
        ShadowKeepGoldenVowGoods20031703x = 21007090,

        [Annotation(Name = "[Scadu Altus - Furnace Golem Area] Golden Vow (Goods 2003170) 2x 2048467010")]
        ScaduAltusFurnaceGolemAreaGoldenVowGoods20031702x = 2048467010,

        [Annotation(Name = "[Specimen Storehouse] Fire Coil 21017040")]
        SpecimenStorehouseFireCoil = 21017040,

        [Annotation(Name = "[Specimen Storehouse] Fire Coil 2x 21017410")]
        SpecimenStorehouseFireCoil2x = 21017410,

        [Annotation(Name = "[Specimen Storehouse] Fire Coil 3x 21017630")]
        SpecimenStorehouseFireCoil3x = 21017630,

        [Annotation(Name = "[Gravesite Plain - Church of Consolation] Fire Coil 2x 2048417000")]
        GravesitePlainChurchofConsolationFireCoil2x = 2048417000,

        [Annotation(Name = "[Scadu Altus - Cathedral of Manus Metyr] Glinting Nail 2x 2051457000")]
        ScaduAltusCathedralofManusMetyrGlintingNail2x = 2051457000,

        [Annotation(Name = "[Enir-Ilim] Sunwarmth Stone 2x 20017480")]
        EnirIlimSunwarmthStone2x = 20017480,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Glintblade Trio 2047447090")]
        GravesitePlainWestCastleEnsisGlintbladeTrio = 2047447090,

        [Annotation(Name = "[Scaduview - Fallingstar Beast] Gravitational Missile 530960")]
        ScaduviewFallingstarBeastGravitationalMissile = 530960,

        [Annotation(Name = "[Shadow Keep - Ulcerated Tree Spirit] Mantle of Thorns 21007991")]
        ShadowKeepUlceratedTreeSpiritMantleofThorns = 21007991,

        [Annotation(Name = "[Specimen Storehouse] Impenetrable Thorns 21017510")]
        SpecimenStorehouseImpenetrableThorns = 21017510,

        [Annotation(Name = "[Cerulean Coast - Cerulean Coast] Rings of Spectral Light 2048397050")]
        CeruleanCoastCeruleanCoastRingsofSpectralLight = 2048397050,

        [Annotation(Name = "[Stone Coffin Fissure] Mass of Putrescence 22007210")]
        StoneCoffinFissureMassofPutrescence = 22007210,

        [Annotation(Name = "[Scadu Altus - Moorth Highway Camp] Heal from Afar 2049457500")]
        ScaduAltusMoorthHighwayCampHealfromAfar = 2049457500,

        [Annotation(Name = "[Shadow Keep - Golden Hippopotamus] Aspects of the Crucible: Thorns, Scadutree Fragment 2x 510440")]
        ShadowKeepGoldenHippopotamusAspectsoftheCrucibleThorns = 510440,

        [Annotation(Name = "[Rauh Base - Ravine North] Aspects of the Crucible: Bloom 2045477040")]
        RauhBaseRavineNorthAspectsoftheCrucibleBloom = 2045477040,

        [Annotation(Name = "[Scadu Altus - Church District Highroad] Minor Erdtree 2051477500")]
        ScaduAltusChurchDistrictHighroadMinorErdtree = 2051477500,

        [Annotation(Name = "[Specimen Storehouse] Wrath from Afar 21017780")]
        SpecimenStorehouseWrathfromAfar = 21017780,

        [Annotation(Name = "[Stone Coffin Fissure - Leonine Misbegotten] Multilayered Ring of Light 22007900")]
        StoneCoffinFissureLeonineMisbegottenMultilayeredRingofLight = 22007900,

        [Annotation(Name = "[Rauh Base - Rugalea the Great Red Bear] Roar of Rugalea 530905")]
        RauhBaseRugaleatheGreatRedBearRoarofRugalea = 530905,

        [Annotation(Name = "[Scorpion River Catacombs] Knight's Lightning Spear 40017080")]
        ScorpionRiverCatacombsKnightsLightningSpear = 40017080,

        [Annotation(Name = "[Finger Ruins of Rhia - Dragon Communion Priestess] Dragonbolt of Florissax 400702")]
        FingerRuinsofRhiaDragonCommunionPriestessDragonboltofFlorissax = 400702,

        [Annotation(Name = "[Fog Rift Catacombs] Electrocharge 40007090")]
        FogRiftCatacombsElectrocharge = 40007090,

        [Annotation(Name = "[Rauh Base - Scorpion River Catacombs Entrance] Pest-Thread Spears 2044467040")]
        RauhBaseScorpionRiverCatacombsEntrancePestThreadSpears = 2044467040,

        [Annotation(Name = "[Scadu Altus - Bonny Village North Tree and Overlook] Cherishing Fingers 400666")]
        ScaduAltusBonnyVillageNorthTreeandOverlookCherishingFingers = 400666,

        [Annotation(Name = "[Belurat - Hornsent Grandam] Watchful Spirit 400721")]
        BeluratHornsentGrandamWatchfulSpirit = 400721,

        [Annotation(Name = "[Scadu Altus - Moorth Ruins] Golden Arcs 2049447900")]
        ScaduAltusMoorthRuinsGoldenArcs = 2049447900,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Giant Golden Arc 2050467910")]
        ScaduAltusCastleWateringHoleSoutheastGiantGoldenArc = 2050467910,

        [Annotation(Name = "[Rauh Base - Temple Town Ruins] Spiraltree Seal 580410")]
        RauhBaseTempleTownRuinsSpiraltreeSeal_ = 580410,

        [Annotation(Name = "[Enir-Ilim] Spira 20017230")]
        EnirIlimSpira = 20017230,

        [Annotation(Name = "[Rauh Base - Divine Beast Dancing Lion] Divine Beast Tornado 530940")]
        RauhBaseDivineBeastDancingLionDivineBeastTornado = 530940,

        [Annotation(Name = "[Rauh Base - Scorpion River Catacombs Entrance] Divine Bird Feathers 2044467110")]
        RauhBaseScorpionRiverCatacombsEntranceDivineBirdFeathers = 2044467110,

        [Annotation(Name = "[Specimen Storehouse] Fire Serpent 21017650")]
        SpecimenStorehouseFireSerpent = 21017650,

        [Annotation(Name = "[Gravesite Plain - Igon] Igon's Furled Finger 400710")]
        GravesitePlainIgonIgonsFurledFinger = 400710,

        [Annotation(Name = "[Belurat] Well Depths Key 20007510")]
        BeluratWellDepthsKey = 20007510,

        [Annotation(Name = "[Lamenter's Gaol] Gaol Upper Level Key 41027000")]
        LamentersGaolGaolUpperLevelKey = 41027000,

        [Annotation(Name = "[Lamenter's Gaol] Gaol Lower Level Key 41027320")]
        LamentersGaolGaolLowerLevelKey = 41027320,

        [Annotation(Name = "[Gravesite Plain - Hornsent] Cross Map 400610")]
        GravesitePlainHornsentCrossMap = 400610,

        [Annotation(Name = "[Gravesite Plain - Hornsent] New Cross Map 400611")]
        GravesitePlainHornsentNewCrossMap = 400611,

        [Annotation(Name = "[Scadu Altus - Count Ymir, High Priest] Hole-Laden Necklace, Ruins Map 400660")]
        ScaduAltusCountYmirHighPriestHoleLadenNecklace = 400660,

        [Annotation(Name = "[Jagged Peak - Bayle the Dread] Heart of Bayle 510630")]
        JaggedPeakBayletheDreadHeartofBayle = 510630,

        [Annotation(Name = "[Belurat] Storeroom Key 20007480")]
        BeluratStoreroomKey = 20007480,

        [Annotation(Name = "[Specimen Storehouse] Secret Rite Scroll 21017340")]
        SpecimenStorehouseSecretRiteScroll = 21017340,

        [Annotation(Name = "[Specimen Storehouse - Sir Ansbach] Letter for Freyja 400620")]
        SpecimenStorehouseSirAnsbachLetterforFreyja = 400620,

        [Annotation(Name = "[Scadu Altus - Count Ymir, High Priest] Ruins Map (3rd) 400662")]
        ScaduAltusCountYmirHighPriestRuinsMap3rd = 400662,

        [Annotation(Name = "[Gravesite Plain - Moore] Black Syrup 400642")]
        GravesitePlainMooreBlackSyrup = 400642,

        [Annotation(Name = "[Specimen Storehouse - Base Serpent Messmer] Messmer's Kindling, Remembrance of the Impaler 510460")]
        SpecimenStorehouseBaseSerpentMessmerMessmersKindling = 510460,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Northwest Entrance] Furnace Keeper's Note 2049477000")]
        ScaduAltusCastleWateringHoleNorthwestEntranceFurnaceKeepersNote = 2049477000,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Castle Cross Message 2047447710")]
        GravesitePlainWestCastleEnsisCastleCrossMessage = 2047447710,

        [Annotation(Name = "[Rauh Base - Fire Spritestone Cave] Ancient Ruins Cross Message 2047477000")]
        RauhBaseFireSpritestoneCaveAncientRuinsCrossMessage = 2047477000,

        [Annotation(Name = "[Scadu Altus - Highroad Cross] Monk's Missive 2048457510")]
        ScaduAltusHighroadCrossMonksMissive = 2048457510,

        [Annotation(Name = "[Specimen Storehouse] Storehouse Cross Message 21017180")]
        SpecimenStorehouseStorehouseCrossMessage = 21017180,

        [Annotation(Name = "[Midra's Manse] Torn Diary Page 28007010")]
        MidrasManseTornDiaryPage = 28007010,

        [Annotation(Name = "[Scadu Altus - Moorth Ruins] Message from Leda 580600")]
        ScaduAltusMoorthRuinsMessagefromLeda = 580600,

        [Annotation(Name = "[Belurat] Tower of Shadow Message 20007830")]
        BeluratTowerofShadowMessage = 20007830,

        [Annotation(Name = "[Gravesite Plain - Church of Benediction] \"Incursion\" Painting 580100")]
        GravesitePlainChurchofBenedictionIncursionPainting = 580100,

        [Annotation(Name = "[Gravesite Plain - North of Scorched Ruins] \"The Sacred Tower\" Painting 580110")]
        GravesitePlainNorthofScorchedRuinsTheSacredTowerPainting = 580110,

        [Annotation(Name = "[Shadow Keep] \"Domain of Dragons\" Painting 580120")]
        ShadowKeepDomainofDragonsPainting = 580120,

        [Annotation(Name = "[Gravesite Plain - Scorched Ruins] Map: Gravesite Plain 62080")]
        GravesitePlainScorchedRuinsMapGravesitePlain = 62080,

        [Annotation(Name = "[Scadu Altus - Highroad Cross] Map: Scadu Altus 62081")]
        ScaduAltusHighroadCrossMapScaduAltus = 62081,

        [Annotation(Name = "[Cerulean Coast - Cerulean Coast Cross] Map: Southern Shore 62082")]
        CeruleanCoastCeruleanCoastCrossMapSouthernShore = 62082,

        [Annotation(Name = "[Rauh Base - Temple Town Ruins] Map: Rauh Ruins 62083")]
        RauhBaseTempleTownRuinsMapRauhRuins = 62083,

        [Annotation(Name = "[Abyssal Woods - Big Tree West of Church] Map: Abyss 62084")]
        AbyssalWoodsBigTreeWestofChurchMapAbyss = 62084,

        [Annotation(Name = "[Gravesite Plain - Belurat Main Gate Cross] Moore's Bell Bearing 400644")]
        GravesitePlainBeluratMainGateCrossMooresBellBearing = 400644,

        [Annotation(Name = "[Gravesite Plain - Scorched Ruins] Herbalist's Bell Bearing 2047407710")]
        GravesitePlainScorchedRuinsHerbalistsBellBearing = 2047407710,

        [Annotation(Name = "[Gravesite Plain - Greatbridge North] Mushroom-Seller's Bell Bearing [1] 2046447710")]
        GravesitePlainGreatbridgeNorthMushroomSellersBellBearing1 = 2046447710,

        [Annotation(Name = "[Gravesite Plain - Scorched Ruins] Mushroom-Seller's Bell Bearing [2] 2047417110")]
        GravesitePlainScorchedRuinsMushroomSellersBellBearing2 = 2047417110,

        [Annotation(Name = "[Scadu Altus - Road to Manus Metyr] Greasemonger's Bell Bearing 2051467500")]
        ScaduAltusRoadtoManusMetyrGreasemongersBellBearing = 2051467500,

        [Annotation(Name = "[Scadu Altus - Main Bonny Village] Moldmonger's Bell Bearing 2050447730")]
        ScaduAltusMainBonnyVillageMoldmongersBellBearing = 2050447730,

        [Annotation(Name = "[Scadu Altus - Road to Manus Metyr] Spellmachinist's Bell Bearing 2051467020")]
        ScaduAltusRoadtoManusMetyrSpellmachinistsBellBearing = 2051467020,

        [Annotation(Name = "[Gravesite Plain - Cliffroad Terminus] String-Seller's Bell Bearing 2045417710")]
        GravesitePlainCliffroadTerminusStringSellersBellBearing = 2045417710,

        [Annotation(Name = "[Scadu Altus - Bonny Village North] O Mother 2050457510")]
        ScaduAltusBonnyVillageNorthOMother = 2050457510,

        [Annotation(Name = "[Scadu Altus - Kindred of Rot] Forager Brood Cookbook [6] 68510")]
        ScaduAltusKindredofRotForagerBroodCookbook6 = 68510,

        [Annotation(Name = "[Gravesite Plain - Kindred of Rot] Forager Brood Cookbook [1] 68520")]
        GravesitePlainKindredofRotForagerBroodCookbook1 = 68520,

        [Annotation(Name = "[Gravesite Plain - Kindred of Rot] Forager Brood Cookbook [2] 68530")]
        GravesitePlainKindredofRotForagerBroodCookbook2 = 68530,

        [Annotation(Name = "[Gravesite Plain - Kindred of Rot] Forager Brood Cookbook [3] 68540")]
        GravesitePlainKindredofRotForagerBroodCookbook3 = 68540,

        [Annotation(Name = "[Scadu Altus - Kindred of Rot] Forager Brood Cookbook [4] 68550")]
        ScaduAltusKindredofRotForagerBroodCookbook4 = 68550,

        [Annotation(Name = "[Scadu Altus - Kindred of Rot] Forager Brood Cookbook [5] 68560")]
        ScaduAltusKindredofRotForagerBroodCookbook5 = 68560,

        [Annotation(Name = "[Jagged Peak - Jagged Peak Mountainside] Igon's Cookbook [2] 68570")]
        JaggedPeakJaggedPeakMountainsideIgonsCookbook2 = 68570,

        [Annotation(Name = "[Scadu Altus - Road to Manus Metyr] Finger-Weaver's Cookbook [2] 68580")]
        ScaduAltusRoadtoManusMetyrFingerWeaversCookbook2 = 68580,

        [Annotation(Name = "[Gravesite Plain - Scorched Ruins] Greater Potentate's Cookbook [1] 68590")]
        GravesitePlainScorchedRuinsGreaterPotentatesCookbook1 = 68590,

        [Annotation(Name = "[Scadu Altus - Cathedral of Manus Metyr] Greater Potentate's Cookbook [4] 68600")]
        ScaduAltusCathedralofManusMetyrGreaterPotentatesCookbook4 = 68600,

        [Annotation(Name = "[Gravesite Plain - Church of Benediction] Greater Potentate's Cookbook [5] 68610")]
        GravesitePlainChurchofBenedictionGreaterPotentatesCookbook5 = 68610,

        [Annotation(Name = "[Gravesite Plain - North of Scorched Ruins] Greater Potentate's Cookbook [12] 68620")]
        GravesitePlainNorthofScorchedRuinsGreaterPotentatesCookbook12 = 68620,

        [Annotation(Name = "[Gravesite Plain - Southeast Poison Swamp] Greater Potentate's Cookbook [7] 68630")]
        GravesitePlainSoutheastPoisonSwampGreaterPotentatesCookbook7 = 68630,

        [Annotation(Name = "[Rauh Base - Scorpion River Catacombs Entrance] Greater Potentate's Cookbook [9] 68640")]
        RauhBaseScorpionRiverCatacombsEntranceGreaterPotentatesCookbook9 = 68640,

        [Annotation(Name = "[Gravesite Plain - Greatbridge North] Greater Potentate's Cookbook [10] 68650")]
        GravesitePlainGreatbridgeNorthGreaterPotentatesCookbook10 = 68650,

        [Annotation(Name = "[Belurat Gaol] Greater Potentate's Cookbook [11] 68660")]
        BeluratGaolGreaterPotentatesCookbook11 = 68660,

        [Annotation(Name = "[Finger Ruins of Rhia - Far Northwest] Mad Craftsman's Cookbook [2] 68670")]
        FingerRuinsofRhiaFarNorthwestMadCraftsmansCookbook2 = 68670,

        [Annotation(Name = "[Rauh Base - West Scorpion River] Greater Potentate's Cookbook [8] 68680")]
        RauhBaseWestScorpionRiverGreaterPotentatesCookbook8 = 68680,

        [Annotation(Name = "[Gravesite Plain - North Fog Rift Fort] Greater Potentate's Cookbook [3] 68690")]
        GravesitePlainNorthFogRiftFortGreaterPotentatesCookbook3 = 68690,

        [Annotation(Name = "[Ruined Forge Lava Intake] Greater Potentate's Cookbook [13] 68700")]
        RuinedForgeLavaIntakeGreaterPotentatesCookbook13 = 68700,

        [Annotation(Name = "[Cerulean Coast - Ravine South] Greater Potentate's Cookbook [14] 68710")]
        CeruleanCoastRavineSouthGreaterPotentatesCookbook14 = 68710,

        [Annotation(Name = "[Finger Ruins of Rhia - Far Northeast] Greater Potentate's Cookbook [6] 68720")]
        FingerRuinsofRhiaFarNortheastGreaterPotentatesCookbook6 = 68720,

        [Annotation(Name = "[Gravesite Plain - Ellac Greatbridge] Greater Potentate's Cookbook [2] 68730")]
        GravesitePlainEllacGreatbridgeGreaterPotentatesCookbook2 = 68730,

        [Annotation(Name = "[Fog Rift Catacombs] Ancient Dragon Knight's Cookbook [1] 68740")]
        FogRiftCatacombsAncientDragonKnightsCookbook1 = 68740,

        [Annotation(Name = "[Gravesite Plain - Pillar Path Waypoint] Mad Craftsman's Cookbook [1] 68750")]
        GravesitePlainPillarPathWaypointMadCraftsmansCookbook1 = 68750,

        [Annotation(Name = "[Cerulean Coast - Cerulean Coast Cross] St. Trina Disciple's Cookbook [1] 68760")]
        CeruleanCoastCeruleanCoastCrossStTrinaDisciplesCookbook1 = 68760,

        [Annotation(Name = "[Scadu Altus - Moorth Ruins] Fire Knight's Cookbook [1] 68770")]
        ScaduAltusMoorthRuinsFireKnightsCookbook1 = 68770,

        [Annotation(Name = "[Scorpion River Catacombs] Ancient Dragon Knight's Cookbook [2] 68780")]
        ScorpionRiverCatacombsAncientDragonKnightsCookbook2 = 68780,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Loyal Knight's Cookbook 68790")]
        GravesitePlainWestCastleEnsisLoyalKnightsCookbook = 68790,

        [Annotation(Name = "[Shadow Keep] Battlefield Priest's Cookbook [1] 68800")]
        ShadowKeepBattlefieldPriestsCookbook1 = 68800,

        [Annotation(Name = "[Finger Ruins of Rhia - Climb to Finger-Weaver's Hovel] Igon's Cookbook [1] 68810")]
        FingerRuinsofRhiaClimbtoFingerWeaversHovelIgonsCookbook1 = 68810,

        [Annotation(Name = "[Gravesite Plain - Southeast Poison Swamp] Battlefield Priest's Cookbook [2] 68820")]
        GravesitePlainSoutheastPoisonSwampBattlefieldPriestsCookbook2 = 68820,

        [Annotation(Name = "[Gravesite Plain - Moore] Forager Brood Cookbook [7] 68830")]
        GravesitePlainMooreForagerBroodCookbook7 = 68830,

        [Annotation(Name = "[Stone Coffin Fissure] St. Trina Disciple's Cookbook [3] 68840")]
        StoneCoffinFissureStTrinaDisciplesCookbook3 = 68840,

        [Annotation(Name = "[Cerulean Coast - Fingercreeper Beach Center] Grave Keeper's Cookbook [2] 68850")]
        CeruleanCoastFingercreeperBeachCenterGraveKeepersCookbook2 = 68850,

        [Annotation(Name = "[Ancient Ruins of Rauh - East Ruins North Pit and Tunnels] Antiquity Scholar's Cookbook [2] 68860")]
        AncientRuinsofRauhEastRuinsNorthPitandTunnelsAntiquityScholarsCookbook2 = 68860,

        [Annotation(Name = "[Cerulean Coast - Tibia Mariner] Tibia's Cookbook 68870")]
        CeruleanCoastTibiaMarinerTibiasCookbook = 68870,

        [Annotation(Name = "[Midra's Manse] Mad Craftsman's Cookbook [3] 68880")]
        MidrasManseMadCraftsmansCookbook3 = 68880,

        [Annotation(Name = "[Scadu Altus - Furnace Golem Area] Battlefield Priest's Cookbook [3] 68890")]
        ScaduAltusFurnaceGolemAreaBattlefieldPriestsCookbook3 = 68890,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Fire Knight's Cookbook [2] 68900")]
        GravesitePlainWestCastleEnsisFireKnightsCookbook2 = 68900,

        [Annotation(Name = "[Rauh Base - Shadow Commoner] Antiquity Scholar's Cookbook [1] 68910")]
        RauhBaseShadowCommonerAntiquityScholarsCookbook1 = 68910,

        [Annotation(Name = "[Cerulean Coast - Fingercreeper Beach Center] Finger-Weaver's Cookbook [1] 68920")]
        CeruleanCoastFingercreeperBeachCenterFingerWeaversCookbook1 = 68920,

        [Annotation(Name = "[Shadow Keep - West Rampart] Battlefield Priest's Cookbook [4] 68930")]
        ShadowKeepWestRampartBattlefieldPriestsCookbook4 = 68930,

        [Annotation(Name = "[Cerulean Coast - Southern Nameless Mausoleum] Grave Keeper's Cookbook [1] 68940")]
        CeruleanCoastSouthernNamelessMausoleumGraveKeepersCookbook1 = 68940,

        [Annotation(Name = "[Cerulean Coast - The Fissure South] St. Trina Disciple's Cookbook [2] 68950")]
        CeruleanCoastTheFissureSouthStTrinaDisciplesCookbook2 = 68950,

        [Annotation(Name = "[Shadow Keep - West Rampart] Hefty Cracked Pot 66980")]
        ShadowKeepWestRampartHeftyCrackedPot = 66980,

        [Annotation(Name = "[Belurat Gaol] Hefty Cracked Pot 66900")]
        BeluratGaolHeftyCrackedPot = 66900,

        [Annotation(Name = "[Belurat Gaol] Hefty Cracked Pot 66910")]
        BeluratGaolHeftyCrackedPot_ = 66910,

        [Annotation(Name = "[Belurat Gaol] Hefty Cracked Pot 66920")]
        BeluratGaolHeftyCrackedPot__ = 66920,

        [Annotation(Name = "[Bonny Gaol] Hefty Cracked Pot 66930")]
        BonnyGaolHeftyCrackedPot = 66930,

        [Annotation(Name = "[Lamenter's Gaol] Hefty Cracked Pot 66940")]
        LamentersGaolHeftyCrackedPot = 66940,

        [Annotation(Name = "[Cerulean Coast - Troll] Hefty Cracked Pot 66990")]
        CeruleanCoastTrollHeftyCrackedPot = 66990,

        [Annotation(Name = "[Gravesite Plain - Scorched Ruins] Hefty Cracked Pot 66950")]
        GravesitePlainScorchedRuinsHeftyCrackedPot = 66950,

        [Annotation(Name = "[Scadu Altus - Main Bonny Village] Hefty Cracked Pot 66970")]
        ScaduAltusMainBonnyVillageHeftyCrackedPot = 66970,

        [Annotation(Name = "[Scadu Altus - Main Bonny Village] Hefty Cracked Pot 66960")]
        ScaduAltusMainBonnyVillageHeftyCrackedPot_ = 66960,

        [Annotation(Name = "[Belurat] Scadutree Fragment 20007620")]
        BeluratScadutreeFragment = 20007620,

        [Annotation(Name = "[Belurat] Scadutree Fragment 20007820")]
        BeluratScadutreeFragment_ = 20007820,

        [Annotation(Name = "[Enir-Ilim] Scadutree Fragment 20017350")]
        EnirIlimScadutreeFragment = 20017350,

        [Annotation(Name = "[Enir-Ilim] Scadutree Fragment 20017470")]
        EnirIlimScadutreeFragment_ = 20017470,

        [Annotation(Name = "[Enir-Ilim] Scadutree Fragment 20017550")]
        EnirIlimScadutreeFragment__ = 20017550,

        [Annotation(Name = "[Shadow Keep] Scadutree Fragment 21007400")]
        ShadowKeepScadutreeFragment = 21007400,

        [Annotation(Name = "[Specimen Storehouse] Scadutree Fragment 21017200")]
        SpecimenStorehouseScadutreeFragment = 21017200,

        [Annotation(Name = "[Specimen Storehouse] Scadutree Fragment 21017500")]
        SpecimenStorehouseScadutreeFragment_ = 21017500,

        [Annotation(Name = "[Stone Coffin Fissure] Scadutree Fragment 22007000")]
        StoneCoffinFissureScadutreeFragment = 22007000,

        [Annotation(Name = "[Ancient Ruins of Rauh - South Church of the Bud] Scadutree Fragment 2044457000")]
        AncientRuinsofRauhSouthChurchoftheBudScadutreeFragment = 2044457000,

        [Annotation(Name = "[Gravesite Plain - Belurat Main Gate Cross] Scadutree Fragment 2045427700")]
        GravesitePlainBeluratMainGateCrossScadutreeFragment = 2045427700,

        [Annotation(Name = "[Gravesite Plain - Three-Path Cross] Scadutree Fragment 2046427700")]
        GravesitePlainThreePathCrossScadutreeFragment = 2046427700,

        [Annotation(Name = "[Rauh Base - Temple Town Ruins] Scadutree Fragment 2046457040")]
        RauhBaseTempleTownRuinsScadutreeFragment = 2046457040,

        [Annotation(Name = "[Rauh Base - Hippopotamus] Scadutree Fragment 2046467000")]
        RauhBaseHippopotamusScadutreeFragment = 2046467000,

        [Annotation(Name = "[Rauh Base - Fire Spritestone Cave] Scadutree Fragment 2046477750")]
        RauhBaseFireSpritestoneCaveScadutreeFragment = 2046477750,

        [Annotation(Name = "[Cerulean Coast - Hippopotamus] Scadutree Fragment 2047397070")]
        CeruleanCoastHippopotamusScadutreeFragment = 2047397070,

        [Annotation(Name = "[Gravesite Plain - South of Scorched Ruins] Scadutree Fragment 2047407100")]
        GravesitePlainSouthofScorchedRuinsScadutreeFragment = 2047407100,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Scadutree Fragment 2047447720")]
        GravesitePlainWestCastleEnsisScadutreeFragment = 2047447720,

        [Annotation(Name = "[Gravesite Plain - West Castle Ensis] Scadutree Fragment 2047447750")]
        GravesitePlainWestCastleEnsisScadutreeFragment_ = 2047447750,

        [Annotation(Name = "[Scadu Altus - Church of the Crusade] Scadutree Fragment 2x 2047467500")]
        ScaduAltusChurchoftheCrusadeScadutreeFragment2x = 2047467500,

        [Annotation(Name = "[Cerulean Coast - Cerulean Coast Cross] Scadutree Fragment 2048377050")]
        CeruleanCoastCeruleanCoastCrossScadutreeFragment = 2048377050,

        [Annotation(Name = "[Gravesite Plain - Church of Consolation] Scadutree Fragment 2x 2048417700")]
        GravesitePlainChurchofConsolationScadutreeFragment2x = 2048417700,

        [Annotation(Name = "[Gravesite Plain - Pillar Path Cross] Scadutree Fragment 2048437700")]
        GravesitePlainPillarPathCrossScadutreeFragment = 2048437700,

        [Annotation(Name = "[Gravesite Plain - East Castle Ensis] Scadutree Fragment 2048447500")]
        GravesitePlainEastCastleEnsisScadutreeFragment = 2048447500,

        [Annotation(Name = "[Scadu Altus - Highroad Cross] Scadutree Fragment 2048457520")]
        ScaduAltusHighroadCrossScadutreeFragment = 2048457520,

        [Annotation(Name = "[Scadu Altus - Furnace Golem Area] Scadutree Fragment 2048467510")]
        ScaduAltusFurnaceGolemAreaScadutreeFragment = 2048467510,

        [Annotation(Name = "[Scadu Altus - Moorth Ruins] Scadutree Fragment 2049447530")]
        ScaduAltusMoorthRuinsScadutreeFragment = 2049447530,

        [Annotation(Name = "[Scadu Altus - Moorth Highway Camp] Scadutree Fragment 2049457510")]
        ScaduAltusMoorthHighwayCampScadutreeFragment = 2049457510,

        [Annotation(Name = "[Scaduview - Specimen Storehouse Exit] Scadutree Fragment 2049487000")]
        ScaduviewSpecimenStorehouseExitScadutreeFragment = 2049487000,

        [Annotation(Name = "[Scaduview - Scadutree Chalice] Scadutree Fragment 2049497500")]
        ScaduviewScadutreeChaliceScadutreeFragment = 2049497500,

        [Annotation(Name = "[Scaduview - Scadutree Chalice] Scadutree Fragment 2049497520")]
        ScaduviewScadutreeChaliceScadutreeFragment_ = 2049497520,

        [Annotation(Name = "[Scaduview - Scadutree Chalice] Scadutree Fragment 2049497530")]
        ScaduviewScadutreeChaliceScadutreeFragment__ = 2049497530,

        [Annotation(Name = "[Scaduview - Scadutree Chalice] Scadutree Fragment 2049497540")]
        ScaduviewScadutreeChaliceScadutreeFragment___ = 2049497540,

        [Annotation(Name = "[Scaduview - Scadutree Chalice] Scadutree Fragment 2049497550")]
        ScaduviewScadutreeChaliceScadutreeFragment____ = 2049497550,

        [Annotation(Name = "[Scadu Altus - Scaduview Cross] Scadutree Fragment 2050437010")]
        ScaduAltusScaduviewCrossScadutreeFragment = 2050437010,

        [Annotation(Name = "[Scadu Altus - Scaduview Cross] Scadutree Fragment 2050437500")]
        ScaduAltusScaduviewCrossScadutreeFragment_ = 2050437500,

        [Annotation(Name = "[Scadu Altus - Bonny Village North Tree and Overlook] Scadutree Fragment 2050457730")]
        ScaduAltusBonnyVillageNorthTreeandOverlookScadutreeFragment = 2050457730,

        [Annotation(Name = "[Scadu Altus - Hippopotamus] Scadutree Fragment 2051447500")]
        ScaduAltusHippopotamusScadutreeFragment = 2051447500,

        [Annotation(Name = "[Scadu Altus - Hippopotamus] Scadutree Fragment 2051447510")]
        ScaduAltusHippopotamusScadutreeFragment_ = 2051447510,

        [Annotation(Name = "[Jagged Peak - Between Jagged Peak Mountainside and Summit] Scadutree Fragment 2053397020")]
        JaggedPeakBetweenJaggedPeakMountainsideandSummitScadutreeFragment = 2053397020,

        [Annotation(Name = "[Abyssal Woods - Abandoned Church] Scadutree Fragment 2x 2053417500")]
        AbyssalWoodsAbandonedChurchScadutreeFragment2x = 2053417500,

        [Annotation(Name = "[Gravesite Plain - Shadow Commoner] Scadutree Fragment 2049440990")]
        GravesitePlainShadowCommonerScadutreeFragment = 2049440990,

        [Annotation(Name = "[Gravesite Plain - Shadow Commoner] Scadutree Fragment 2044417995")]
        GravesitePlainShadowCommonerScadutreeFragment_ = 2044417995,

        [Annotation(Name = "[Scadu Altus - Shadow Commoner] Scadutree Fragment 2046477960")]
        ScaduAltusShadowCommonerScadutreeFragment = 2046477960,

        [Annotation(Name = "[Ancient Ruins of Rauh - Shadow Commoner] Scadutree Fragment 2047417995")]
        AncientRuinsofRauhShadowCommonerScadutreeFragment = 2047417995,

        [Annotation(Name = "[Belurat] Revered Spirit Ash 2x 20007170")]
        BeluratReveredSpiritAsh2x = 20007170,

        [Annotation(Name = "[Belurat] Revered Spirit Ash 20007700")]
        BeluratReveredSpiritAsh = 20007700,

        [Annotation(Name = "[Belurat] Revered Spirit Ash 20007800")]
        BeluratReveredSpiritAsh_ = 20007800,

        [Annotation(Name = "[Enir-Ilim] Revered Spirit Ash 2x 20017200")]
        EnirIlimReveredSpiritAsh2x = 20017200,

        [Annotation(Name = "[Enir-Ilim] Revered Spirit Ash 20017400")]
        EnirIlimReveredSpiritAsh = 20017400,

        [Annotation(Name = "[Specimen Storehouse] Revered Spirit Ash 21017020")]
        SpecimenStorehouseReveredSpiritAsh = 21017020,

        [Annotation(Name = "[Specimen Storehouse] Revered Spirit Ash 21017460")]
        SpecimenStorehouseReveredSpiritAsh_ = 21017460,

        [Annotation(Name = "[Midra's Manse] Revered Spirit Ash 28007110")]
        MidrasManseReveredSpiritAsh = 28007110,

        [Annotation(Name = "[Rauh Base - Scorpion River Catacombs Entrance] Revered Spirit Ash 2044467000")]
        RauhBaseScorpionRiverCatacombsEntranceReveredSpiritAsh = 2044467000,

        [Annotation(Name = "[Gravesite Plain - Cliffroad Terminus] Revered Spirit Ash 2045417700")]
        GravesitePlainCliffroadTerminusReveredSpiritAsh = 2045417700,

        [Annotation(Name = "[Gravesite Plain - Greatbridge North] Revered Spirit Ash 2046447700")]
        GravesitePlainGreatbridgeNorthReveredSpiritAsh = 2046447700,

        [Annotation(Name = "[Rauh Base - Temple Town Ruins] Revered Spirit Ash 2046457720")]
        RauhBaseTempleTownRuinsReveredSpiritAsh = 2046457720,

        [Annotation(Name = "[Gravesite Plain - Scorched Ruins] Revered Spirit Ash 2047417700")]
        GravesitePlainScorchedRuinsReveredSpiritAsh = 2047417700,

        [Annotation(Name = "[Gravesite Plain - East of Ensis Castle Front] Revered Spirit Ash 2047437700")]
        GravesitePlainEastofEnsisCastleFrontReveredSpiritAsh = 2047437700,

        [Annotation(Name = "[Scadu Altus - Moorth Ruins] Revered Spirit Ash 2049447500")]
        ScaduAltusMoorthRuinsReveredSpiritAsh = 2049447500,

        [Annotation(Name = "[Scadu Altus - Scaduview Cross] Revered Spirit Ash 2050437720")]
        ScaduAltusScaduviewCrossReveredSpiritAsh = 2050437720,

        [Annotation(Name = "[Scadu Altus - Main Bonny Village] Revered Spirit Ash 2050447500")]
        ScaduAltusMainBonnyVillageReveredSpiritAsh = 2050447500,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Revered Spirit Ash 2050467700")]
        ScaduAltusCastleWateringHoleSoutheastReveredSpiritAsh = 2050467700,

        [Annotation(Name = "[Belurat - Shadow Commoner] Revered Spirit Ash 20007900")]
        BeluratShadowCommonerReveredSpiritAsh = 20007900,

        [Annotation(Name = "[Midra's Manse - Fat Inquisitor] Revered Spirit Ash 20017900")]
        MidrasManseFatInquisitorReveredSpiritAsh = 20017900,

        [Annotation(Name = "[Enir-Ilim - Fat Inquisitor] Revered Spirit Ash 28007900")]
        EnirIlimFatInquisitorReveredSpiritAsh = 28007900,

        [Annotation(Name = "[Ancient Ruins of Rauh - Shadow Commoner] Revered Spirit Ash 2044467950")]
        AncientRuinsofRauhShadowCommonerReveredSpiritAsh = 2044467950,

        [Annotation(Name = "[Ancient Ruins of Rauh - Shadow Commoner] Revered Spirit Ash 2046477950")]
        AncientRuinsofRauhShadowCommonerReveredSpiritAsh_ = 2046477950,

        [Annotation(Name = "[Gravesite Plain - South of Church of Consolation] Viridian Hidden Tear 65400")]
        GravesitePlainSouthofChurchofConsolationViridianHiddenTear = 65400,

        [Annotation(Name = "[Scadu Altus - Furnace Golem Area] Crimsonburst Dried Tear 65410")]
        ScaduAltusFurnaceGolemAreaCrimsonburstDriedTear = 65410,

        [Annotation(Name = "[Rauh Base - Rot Area] Crimson-Sapping Cracked Tear 65420")]
        RauhBaseRotAreaCrimsonSappingCrackedTear = 65420,

        [Annotation(Name = "[Scadu Altus - Cathedral of Manus Metyr] Cerulean-Sapping Cracked Tear 65430")]
        ScaduAltusCathedralofManusMetyrCeruleanSappingCrackedTear = 65430,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Oil-Soaked Tear 65440")]
        ScaduAltusCastleWateringHoleSoutheastOilSoakedTear = 65440,

        [Annotation(Name = "[Scadu Altus - Castle Watering Hole Southeast] Bloodsucking Cracked Tear 65450")]
        ScaduAltusCastleWateringHoleSoutheastBloodsuckingCrackedTear = 65450,

        [Annotation(Name = "[Cerulean Coast - Cerulean Coast West] Glovewort Crystal Tear 65460")]
        CeruleanCoastCeruleanCoastWestGlovewortCrystalTear = 65460,

        [Annotation(Name = "[Gravesite Plain - Three-Path Cross] Deflecting Hardtear 65470")]
        GravesitePlainThreePathCrossDeflectingHardtear = 65470,

        [Annotation(Name = "[Bonny Gaol - Curseblade Labirith] Curseblade Meera 520760")]
        BonnyGaolCursebladeLabirithCursebladeMeera = 520760,

        [Annotation(Name = "[Rivermouth Cave - Chief Bloodfiend] Bloodfiend Hexer's Ashes 520800")]
        RivermouthCaveChiefBloodfiendBloodfiendHexersAshes = 520800,

        [Annotation(Name = "[Cerulean Coast - Cerulean Coast West] Gravebird Ashes 2046397040")]
        CeruleanCoastCeruleanCoastWestGravebirdAshes = 2046397040,

        [Annotation(Name = "[Specimen Storehouse] Fire Knight Hilde 21017800")]
        SpecimenStorehouseFireKnightHilde = 21017800,

        [Annotation(Name = "[Rauh Base - Fire Spritestone Cave] Spider Scorpion Ashes 2046477020")]
        RauhBaseFireSpritestoneCaveSpiderScorpionAshes = 2046477020,

        [Annotation(Name = "[Enir-Ilim] Inquisitor Ashes 20017310")]
        EnirIlimInquisitorAshes = 20017310,

        [Annotation(Name = "[Belurat Gaol - Demi-Human Swordmaster Onze] Demi-Human Swordsman Yosh 520750")]
        BeluratGaolDemiHumanSwordmasterOnzeDemiHumanSwordsmanYosh = 520750,

        [Annotation(Name = "[Gravesite Plain - Southeast Poison Swamp] Messmer Soldier Ashes 2049437230")]
        GravesitePlainSoutheastPoisonSwampMessmerSoldierAshes = 2049437230,

        [Annotation(Name = "[Fog Rift Catacombs] Black Knight Commander Andreas 40007810")]
        FogRiftCatacombsBlackKnightCommanderAndreas = 40007810,

        [Annotation(Name = "[Scorpion River Catacombs] Black Knight Captain Huw 40017050")]
        ScorpionRiverCatacombsBlackKnightCaptainHuw = 40017050,

        [Annotation(Name = "[Darklight Catacombs] Bigmouth Imp Ashes 40027220")]
        DarklightCatacombsBigmouthImpAshes = 40027220,

        [Annotation(Name = "[Scadu Altus - Main Bonny Village] Man-Fly Ashes 2050447710")]
        ScaduAltusMainBonnyVillageManFlyAshes = 2050447710,

        [Annotation(Name = "[Taylew's Ruined Forge] Taylew the Golem Smith 42037000")]
        TaylewsRuinedForgeTaylewtheGolemSmith = 42037000,

        [Annotation(Name = "[Rauh Base - Temple Town Ruins] Divine Bird Warrior Ornis 2046457920")]
        RauhBaseTempleTownRuinsDivineBirdWarriorOrnis = 2046457920,

        [Annotation(Name = "[Enir-Ilim] Horned Warrior Ashes 20017420")]
        EnirIlimHornedWarriorAshes = 20017420,

        [Annotation(Name = "[Finger Ruins of Rhia - Dragon Communion Priestess] Ancient Dragon Florissax 400700")]
        FingerRuinsofRhiaDragonCommunionPriestessAncientDragonFlorissax = 400700,

        [Annotation(Name = "[Scaduview - East of Fingerstone Hill Crater] Fingercreeper Ashes 2053487000")]
        ScaduviewEastofFingerstoneHillCraterFingercreeperAshes = 2053487000,

        [Annotation(Name = "[Shadow Keep - Fire Knight Queelign] Fire Knight Queelign 400690")]
        ShadowKeepFireKnightQueelignFireKnightQueelign = 400690,

        [Annotation(Name = "[Scadu Altus - Swordhand of Night Jolán] Swordhand of Night Jolán 400670")]
        ScaduAltusSwordhandofNightJolanSwordhandofNightJolan = 400670,

    }
}
