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
using System.Xml.Serialization;

namespace SoulMemory.DarkSouls2
{
    [XmlType(Namespace = "SoulMemory.DarkSouls2")]
    public enum BossType
    {
        //Base game ==========================================================================================
        [Display(Name = "The Last Giant")]
        TheLastGiant = 0x7c,

        [Display(Name = "The Pursuer")]
        ThePursuer = 0x70,

        [Display(Name = "Executioners Chariot")]
        ExecutionersChariot = 0x34,

        [Display(Name = "Looking Glass Knight")]
        LookingGlassKnight = 0x48,

        [Display(Name = "The Skeleton Lords")]
        TheSkeletonLords = 0x38,

        [Display(Name = "Flexile Sentry")]
        FlexileSentry = 0x54,

        [Display(Name = "Lost Sinner")]
        LostSinner = 0x5c,

        [Display(Name = "Belfry Gargoyles")]
        BelfryGargoyles = 0xa8,

        [Display(Name = "Ruin Sentinels")]
        RuinSentinels = 0x58,

        [Display(Name = "Royal Rat Vanguard")]
        RoyalRatVanguard = 0x64,

        [Display(Name = "Royal Rat Authority")]
        RoyalRatAuthority = 0x6c,

        [Display(Name = "Scorpioness Najka")]
        ScorpionessNajka = 0x44,

        [Display(Name = "The Duke's Dear Freja")]
        TheDukesDearFreja = 0x2c,

        [Display(Name = "Mytha, the Baneful Queen")]
        MythaTheBanefulQueen = 0x40,

        [Display(Name = "The Rotten")]
        TheRotten = 0x68,

        [Display(Name = "Old DragonSlayer")]
        OldDragonSlayer = 0x50,

        [Display(Name = "Covetous Demon")]
        CovetousDemon = 0x3c,

        [Display(Name = "Smelter Demon")]
        SmelterDemon = 0x60,

        [Display(Name = "Old Iron King")]
        OldIronKing = 0x30,

        [Display(Name = "Guardian Dragon")]
        GuardianDragon = 0x78,

        [Display(Name = "Demon of Song")]
        DemonOfSong = 0x28,

        [Display(Name = "Velstadt, The Royal Aegis")]
        VelstadtTheRoyalAegis = 0x8c,

        [Display(Name = "Vendrick")]
        Vendrick = 0x98,
        
        [Display(Name = "Darklurker")]
        Darklurker = 0x9c,

        [Display(Name = "Dragonrider")]
        Dragonrider = 0x4c,

        [Display(Name = "Twin Dragonriders")]
        TwinDragonriders = 0xa0,

        [Display(Name = "Prowling Magnus and Congregation")]
        ProwlingMagnusAndCongregation = 0xa4,

        [Display(Name = "Giant Lord")]
        GiantLord = 0x80,

        [Display(Name = "Ancient Dragon")]
        AncientDragon = 0x94,

        [Display(Name = "Throne Watcher and Throne Defender")]
        ThroneWatcherAndThroneDefender = 0x88,

        [Display(Name = "Nashandra")]
        Nashandra = 0x84,

        [Display(Name = "Aldia, Scholar of the First Sin")]
        AldiaScholarOfTheFirstSin = 0x118,

        //Crown of the Sunken king =================================================================================
        [Display(Name = "Elana, Squalid Queen")]
        ElanaSqualidQueen = 0xc8,

        [Display(Name = "Sinh, the Slumbering Dragon")]
        SinhTheSlumberingDragon = 0xd4,

        [Display(Name = "Afflicted Graverobber, Ancient Soldier Varg, and Cerah the Old Explorer")]
        AfflictedGraverobberAncientSoldierVargCerahTheOldExplorer = 0xf4,

        //Crown of the old iron king ================================================================================

        [Display(Name = "Blue Smelter Demon")]
        BlueSmelterDemon = 0xfc,

        [Display(Name = "Fume knight")]
        Fumeknight                      = 0xcc,

        [Display(Name = "Sir Alonne")]
        SirAlonne                       = 0xf8,

        //Crown of the Ivory king ===================================================================================
        [Display(Name = "Burnt Ivory King")]
        BurntIvoryKing = 0x104,

        [Display(Name = "Aava, the King's Pet")]
        AavaTheKingsPet = 0xd0,

        [Display(Name = "Lud and Zallen, the King's Pets")]
        LudAndZallenTheKingsPets = 0x108,
    }
}
