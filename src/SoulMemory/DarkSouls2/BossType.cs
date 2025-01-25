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

namespace SoulMemory.DarkSouls2;

[XmlType(Namespace = "SoulMemory.DarkSouls2")]
public enum BossType
{
    //Base game ==========================================================================================
    [Annotation(Name = "The Last Giant")]
    TheLastGiant = 0x7c,

    [Annotation(Name = "The Pursuer")]
    ThePursuer = 0x70,

    [Annotation(Name = "Executioners Chariot")]
    ExecutionersChariot = 0x34,

    [Annotation(Name = "Looking Glass Knight")]
    LookingGlassKnight = 0x48,

    [Annotation(Name = "The Skeleton Lords")]
    TheSkeletonLords = 0x38,

    [Annotation(Name = "Flexile Sentry")]
    FlexileSentry = 0x54,

    [Annotation(Name = "Lost Sinner")]
    LostSinner = 0x5c,

    [Annotation(Name = "Belfry Gargoyles")]
    BelfryGargoyles = 0xa8,

    [Annotation(Name = "Ruin Sentinels")]
    RuinSentinels = 0x58,

    [Annotation(Name = "Royal Rat Vanguard")]
    RoyalRatVanguard = 0x64,

    [Annotation(Name = "Royal Rat Authority")]
    RoyalRatAuthority = 0x6c,

    [Annotation(Name = "Scorpioness Najka")]
    ScorpionessNajka = 0x44,

    [Annotation(Name = "The Duke's Dear Freja")]
    TheDukesDearFreja = 0x2c,

    [Annotation(Name = "Mytha, the Baneful Queen")]
    MythaTheBanefulQueen = 0x40,

    [Annotation(Name = "The Rotten")]
    TheRotten = 0x68,

    [Annotation(Name = "Old DragonSlayer")]
    OldDragonSlayer = 0x50,

    [Annotation(Name = "Covetous Demon")]
    CovetousDemon = 0x3c,

    [Annotation(Name = "Smelter Demon")]
    SmelterDemon = 0x60,

    [Annotation(Name = "Old Iron King")]
    OldIronKing = 0x30,

    [Annotation(Name = "Guardian Dragon")]
    GuardianDragon = 0x78,

    [Annotation(Name = "Demon of Song")]
    DemonOfSong = 0x28,

    [Annotation(Name = "Velstadt, The Royal Aegis")]
    VelstadtTheRoyalAegis = 0x8c,

    [Annotation(Name = "Vendrick")]
    Vendrick = 0x98,
    
    [Annotation(Name = "Darklurker")]
    Darklurker = 0x9c,

    [Annotation(Name = "Dragonrider")]
    Dragonrider = 0x4c,

    [Annotation(Name = "Twin Dragonriders")]
    TwinDragonriders = 0xa0,

    [Annotation(Name = "Prowling Magnus and Congregation")]
    ProwlingMagnusAndCongregation = 0xa4,

    [Annotation(Name = "Giant Lord")]
    GiantLord = 0x80,

    [Annotation(Name = "Ancient Dragon")]
    AncientDragon = 0x94,

    [Annotation(Name = "Throne Watcher and Throne Defender")]
    ThroneWatcherAndThroneDefender = 0x88,

    [Annotation(Name = "Nashandra")]
    Nashandra = 0x84,

    [Annotation(Name = "Aldia, Scholar of the First Sin")]
    AldiaScholarOfTheFirstSin = 0x118,

    //Crown of the Sunken king =================================================================================
    [Annotation(Name = "Elana, Squalid Queen")]
    ElanaSqualidQueen = 0xc8,

    [Annotation(Name = "Sinh, the Slumbering Dragon")]
    SinhTheSlumberingDragon = 0xd4,

    [Annotation(Name = "Afflicted Graverobber, Ancient Soldier Varg, and Cerah the Old Explorer")]
    AfflictedGraverobberAncientSoldierVargCerahTheOldExplorer = 0xf4,

    //Crown of the old iron king ================================================================================

    [Annotation(Name = "Blue Smelter Demon")]
    BlueSmelterDemon = 0xfc,

    [Annotation(Name = "Fume knight")]
    Fumeknight                      = 0xcc,

    [Annotation(Name = "Sir Alonne")]
    SirAlonne                       = 0xf8,

    //Crown of the Ivory king ===================================================================================
    [Annotation(Name = "Burnt Ivory King")]
    BurntIvoryKing = 0x104,

    [Annotation(Name = "Aava, the King's Pet")]
    AavaTheKingsPet = 0xd0,

    [Annotation(Name = "Lud and Zallen, the King's Pets")]
    LudAndZallenTheKingsPets = 0x108,
}
