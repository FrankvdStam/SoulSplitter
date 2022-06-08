using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls3
{

    public enum Boss : uint
    {
        //Academy of Raya Lucaria

        [Display(Name = "Iudex Gundyr", Description = "Cemetery of Ash")]
        IudexGundyr = 14000800,

        [Display(Name = "Vordt of the Boreal Valley", Description = "High Wall of Lothric")]
        VordtOfTheBorealValley = 13000800,

        [Display(Name = "Curse-Rotted Greatwood", Description = "Undead Settlement")]
        CurseRottedGreatwood = 13100800,
        
        [Display(Name = "Crystal Sage", Description = "Road of Sacrifices")]
        CrystalSage = 13300850,
        
        [Display(Name = "Abyss Watchers", Description = "Farron Keep")]
        AbyssWatchers = 13300800,
        
        [Display(Name = "Deacons of the Deep", Description = "Cathedral of the Deep")]
        DeaconsOfTheDeep = 13500800,
        
        [Display(Name = "High Lord Wolnir", Description = "Catacombs of Carthus")]
        HighLordWolnir = 13800800,
        
        [Display(Name = "Old Demon King", Description = "Smouldering Lake")]
        OldDemonKing = 13800830,
        
        [Display(Name = "Pontiff Sulyvahn", Description = "Irithyll of the Boreal Valley")]
        PontiffSulyvahn = 13700850,
        
        [Display(Name = "Yhorm the Giant", Description = "Profaned Capital")]
        YhormTheGiant = 13900800,
        
        [Display(Name = "Aldrich, Devourer of Gods", Description = "Anor Londo")]
        AldrichDevourerOfGods = 13700800,
        
        [Display(Name = "Dancer of the Boreal Valley", Description = "High Wall of Lothric")]
        DancerOfTheBorealValley = 13000890,

        [Display(Name = "Dragonslayer Armour", Description = "Lothric Castle")]
        DragonslayerArmour = 13010800,

        [Display(Name = "Oceiros, the Consumed King", Description = "Consumed King's Garden")]
        OceirosTheConsumedKing = 13000830,
        
        [Display(Name = "Champion Gundyr", Description = "Untended Graves")]
        ChampionGundyr = 14000830,

        [Display(Name = "Lothric, Younger Prince", Description = "The top of Lothric Castle")]
        LothricYoungerPrince = 13410830,

        [Display(Name = "Ancient Wyvern", Description = "Archdragon Peak")]
        AncientWyvern = 13200800,
        
        [Display(Name = "Nameless King", Description = "Archdragon Peak")]
        NamelessKing = 13200850,
        
        [Display(Name = "Soul of Cinder", Description = "Kiln of the First Flame")]
        SoulOfCinder = 14100800,
        
        [Display(Name = "Sister Friede", Description = "Painted World of Ariandel")]
        SisterFriede = 14500800,    
        
        [Display(Name = "Champion's Gravetender & Gravetender Greatwolf", Description = "Painted World of Ariandel")]
        ChampionsGravetenderAndGravetenderGreatwolf = 14500860,
        
        [Display(Name = "Demon in Pain & Demon From Below / Demon Prince", Description = "The Dreg Heap")]
        DemonInPainAndDemonFromBelowDemonPrince = 15000800,

        [Display(Name = "Halflight, Spear of the Church", Description = "The Ringed City")]
        HalflightSpearOfTheChurch = 15100800,

        [Display(Name = "Darkeater Midir", Description = "The Ringed City")]
        DarkeaterMidir = 15100850,
        
        [Display(Name = "Slave Knight Gael", Description = "The Ringed City")]
        SlaveKnightGael = 15110800,
    }
}
