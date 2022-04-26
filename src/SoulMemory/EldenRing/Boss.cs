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
        [Display(Name = "Grafted Scion")]
        GraftedScion = 10010800,

        [Display(Name = "Soldier of Godrick")]
        SoldierOfGodrick = 18000850,

        [Display(Name = "Tree Sentinel (Limgrave)")]
        TreeSentinelLimgrave = 1042360800,

        [Display(Name = "Margit, the Fell Omen")]
        MargitTheFellOmen = 10000850,

        [Display(Name = "Godrick the Grafted")]
        GodrickTheGrafted = 10000800,

        [Display(Name = "Flying Dragon Agheel")]
        FlyingDragonAgheel = 1043360800,

        [Display(Name = "Stonedigger Troll (Limgrave)")]
        StonediggerTrollLimgrave = 32010800,

        [Display(Name = "Leonine Misbegotten")]
        LeonineMisbegotten = 1043300800,

        [Display(Name = "Misbegotten Warrior & Crucible Knight")]
        MisbegottenWarriorAndCrucibleKnight = 1051360800,

        [Display(Name = "Black Blade Kindred (Bestial Sanctum")]
        BlackBladeKindredBestialSanctum = 1051430800,

        [Display(Name = "Red Wolf of Radagon")]
        RedWolfOfRadagon = 14000850,

        [Display(Name = "Rennala, Queen of the Full Moon")]
        RennalaQueenOfTheFullMoon = 14000800,

        [Display(Name = "Royal Knight Loretta")]
        RoyalKnightLoretta = 1035500800,

        [Display(Name = "Putrid Avatar (Caelid)")]
        PutridAvatarCaelid = 1047400800,

        [Display(Name = "Elemer of the Briar")]
        ElemerOfTheBriar = 1039540800,

        [Display(Name = "Full-Grown Fallingstar Beast")]
        FullGrownFallingstarBeast = 1036540800,

        [Display(Name = "Ulcerated Tree Spirit")]
        UlceratedTreeSpirit = 1037540810,

        [Display(Name = "Rykard, Lord of Blasphemy")]
        RykardLordOfBlasphemy = 16000800,

        [Display(Name = "Godskin Noble (Volcano Manor)")]
        GodskinNobleVolcanoManor = 16000850,

        [Display(Name = "Godskin Apostle (Altus Plateau)")]
        GodskinApostleAltusPlateau = 1042550800,

        [Display(Name = "Fallingstar Beast (Altus Plateau)")]
        FallingstarBeastAltusPlateau = 1041500800,

        [Display(Name = "Tree Sentinels (Leyndell, Royal Capital)")]
        TreeSentinelsLeyndellRoyalCapital = 1041510800,

        [Display(Name = "Draconic Tree Sentinel")]
        DraconicTreeSentinel = 1045520800,

        [Display(Name = "Morgot, the Omen King")]
        MorgotTheOmenKing = 11000800,

        [Display(Name = "Godskin Apostle (Caelid)")]
        GodskinApostleCaelid = 34130800,

        [Display(Name = "Death Rite Bird (Central Mountaintops of the Giants)")]
        DeathRiteBirdCentralMountaintopsOfTheGiants = 1050570800,

        [Display(Name = "Commander Niall")]
        CommanderNiall = 1051570800,

        [Display(Name = "Loretta, Knight of the Haligtree")]
        LorettaKnightOfTheHaligtree = 15000850,

        [Display(Name = "Malenia, Goddess of Rot")]
        MaleniaGoddessOfRot = 15000800,
        
        [Display(Name = "Fell Twins")]
        FellTwins = 34140850,

        //Glintstone dragon Adula 1034500800 -> at ranni's rise. With cheats, you can kill it there before it flies off
        [Display(Name = "Glintstone Dragon Adula")]
        GlintstoneDragonAdula = 1034420800,

        [Display(Name = "Mohg, Lord of Blood")]
        MohgLordOfBlood = 12050800,

        [Display(Name = "Mimic Tear")]
        MimicTear = 12020850,

        [Display(Name = "Valiant Gargoyle & Valiant Gargoyle Twinblade")]
        ValiantGargoyleAndValiantGargoyleTwinblade = 12020800,

        [Display(Name = "Regal Ancestral Spirit")]
        RegalAncestralSpirit = 12090800,

        [Display(Name = "Ancestral Spirit")]
        AncestralSpirit = 12080800,

        [Display(Name = "Dragonkin Soldier (Sofia River)")]
        DragonkinSoldierSofiaRiver = 12020830,

        [Display(Name = "Fia's Champions")]
        FiasChampions = 12030800,

        [Display(Name = "Magma Wyrm Makar")]
        MagmaWyrmMakar = 39200800,

        [Display(Name = "Bols, Carian Knight")]
        BolsCarianKnight = 1033450800,

        [Display(Name = "Bloodhound Knight Darriwil")]
        BloodhoundKnightDarriwil = 1044350800,

        [Display(Name = "Mad Pumpkin Head")]
        MadPumpkinHead = 1044360800,

        [Display(Name = "Dragonkin Soldier (Lake of Rot)")]
        DragonkinSoldierLakeOfRot = 12010850,

        [Display(Name = "Dragonkin Soldier of Nokstella")]
        DragonkinSoldierOfNokstella = 12010800,

        [Display(Name = "Astel, Naturalborn of the Void")]
        AstelNaturalbornOfTheVoid = 12040800,
        
        [Display(Name = "Glintstone Dragon Smarag")]
        GlintstoneDragonSmarag = 1034450800,

        [Display(Name = "Lichdragon Fortissax")]
        LichdragonFortissax = 12030850,

        [Display(Name = "Fire Giant")]
        FireGiant = 1052520800,

        [Display(Name = "Dragonlord Placidusax")]
        DragonlordPlacidusax = 13000830,

        [Display(Name = "Maliketh, the Black Blade")]
        MalikethTheBlackBlade = 13000800,

        [Display(Name = "Sir Gideon Ofnir, the All-Knowing")]
        SirGideonOfnirTheAllKnowing = 11050850,

        [Display(Name = "Godfrey, First Elden Lord/Hoarah Loux Warrior")]
        GodfreyFirstEldenLordHoarahLouxWarrior = 11050800,

        [Display(Name = "Radagon of the Golden Order/Elden Beast")]
        RadagonOfTheGoldenOrderEldenBeast = 19000800,

        [Display(Name = "Godskin Duo")]
        GodskinDuo = 13000850,

        //Pretty sure this is not the actual Radahn defeated flag, maybe it's for the meteor.
        //None of the flags in GameAreaParam toggle when killing Radahn, but this flag consistently gets set when detouring and logging the SetEventFlag values
        [Display(Name = "Radahn")]
        //1252382438 - tested
        //detoured 1252380800 1252382800
        Radahn = 1252380800
    }
}
