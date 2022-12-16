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

namespace SoulMemory.DarkSouls2
{
    [XmlType(Namespace = "SoulMemory.DarkSouls2")]
    public enum BossType
    {
        //Base game ==========================================================================================
        [AnnotationAttribute(Name = "The Last Giant")]
        TheLastGiant = 0x7c,

        [AnnotationAttribute(Name = "The Pursuer")]
        ThePursuer = 0x70,

        [AnnotationAttribute(Name = "Executioners Chariot")]
        ExecutionersChariot = 0x34,

        [AnnotationAttribute(Name = "Looking Glass Knight")]
        LookingGlassKnight = 0x48,

        [AnnotationAttribute(Name = "The Skeleton Lords")]
        TheSkeletonLords = 0x38,

        [AnnotationAttribute(Name = "Flexile Sentry")]
        FlexileSentry = 0x54,

        [AnnotationAttribute(Name = "Lost Sinner")]
        LostSinner = 0x5c,

        [AnnotationAttribute(Name = "Belfry Gargoyles")]
        BelfryGargoyles = 0xa8,

        [AnnotationAttribute(Name = "Ruin Sentinels")]
        RuinSentinels = 0x58,

        [AnnotationAttribute(Name = "Royal Rat Vanguard")]
        RoyalRatVanguard = 0x64,

        [AnnotationAttribute(Name = "Royal Rat Authority")]
        RoyalRatAuthority = 0x6c,

        [AnnotationAttribute(Name = "Scorpioness Najka")]
        ScorpionessNajka = 0x44,

        [AnnotationAttribute(Name = "The Duke's Dear Freja")]
        TheDukesDearFreja = 0x2c,

        [AnnotationAttribute(Name = "Mytha, the Baneful Queen")]
        MythaTheBanefulQueen = 0x40,

        [AnnotationAttribute(Name = "The Rotten")]
        TheRotten = 0x68,

        [AnnotationAttribute(Name = "Old DragonSlayer")]
        OldDragonSlayer = 0x50,

        [AnnotationAttribute(Name = "Covetous Demon")]
        CovetousDemon = 0x3c,

        [AnnotationAttribute(Name = "Smelter Demon")]
        SmelterDemon = 0x60,

        [AnnotationAttribute(Name = "Old Iron King")]
        OldIronKing = 0x30,

        [AnnotationAttribute(Name = "Guardian Dragon")]
        GuardianDragon = 0x78,

        [AnnotationAttribute(Name = "Demon of Song")]
        DemonOfSong = 0x28,

        [AnnotationAttribute(Name = "Velstadt, The Royal Aegis")]
        VelstadtTheRoyalAegis = 0x8c,

        [AnnotationAttribute(Name = "Vendrick")]
        Vendrick = 0x98,
        
        [AnnotationAttribute(Name = "Darklurker")]
        Darklurker = 0x9c,

        [AnnotationAttribute(Name = "Dragonrider")]
        Dragonrider = 0x4c,

        [AnnotationAttribute(Name = "Twin Dragonriders")]
        TwinDragonriders = 0xa0,

        [AnnotationAttribute(Name = "Prowling Magnus and Congregation")]
        ProwlingMagnusAndCongregation = 0xa4,

        [AnnotationAttribute(Name = "Giant Lord")]
        GiantLord = 0x80,

        [AnnotationAttribute(Name = "Ancient Dragon")]
        AncientDragon = 0x94,

        [AnnotationAttribute(Name = "Throne Watcher and Throne Defender")]
        ThroneWatcherAndThroneDefender = 0x88,

        [AnnotationAttribute(Name = "Nashandra")]
        Nashandra = 0x84,

        [AnnotationAttribute(Name = "Aldia, Scholar of the First Sin")]
        AldiaScholarOfTheFirstSin = 0x118,

        //Crown of the Sunken king =================================================================================
        [AnnotationAttribute(Name = "Elana, Squalid Queen")]
        ElanaSqualidQueen = 0xc8,

        [AnnotationAttribute(Name = "Sinh, the Slumbering Dragon")]
        SinhTheSlumberingDragon = 0xd4,

        [AnnotationAttribute(Name = "Afflicted Graverobber, Ancient Soldier Varg, and Cerah the Old Explorer")]
        AfflictedGraverobberAncientSoldierVargCerahTheOldExplorer = 0xf4,

        //Crown of the old iron king ================================================================================

        [AnnotationAttribute(Name = "Blue Smelter Demon")]
        BlueSmelterDemon = 0xfc,

        [AnnotationAttribute(Name = "Fume knight")]
        Fumeknight                      = 0xcc,

        [AnnotationAttribute(Name = "Sir Alonne")]
        SirAlonne                       = 0xf8,

        //Crown of the Ivory king ===================================================================================
        [AnnotationAttribute(Name = "Burnt Ivory King")]
        BurntIvoryKing = 0x104,

        [AnnotationAttribute(Name = "Aava, the King's Pet")]
        AavaTheKingsPet = 0xd0,

        [AnnotationAttribute(Name = "Lud and Zallen, the King's Pets")]
        LudAndZallenTheKingsPets = 0x108,
    }
}
