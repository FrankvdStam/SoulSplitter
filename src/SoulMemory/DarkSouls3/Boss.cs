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

namespace SoulMemory.DarkSouls3
{
    [XmlType(Namespace = "DarkSouls3")]
    public enum Boss : uint
    {
        //Academy of Raya Lucaria

        [AnnotationAttribute(Name = "Iudex Gundyr", Description = "Cemetery of Ash")]
        IudexGundyr = 14000800,

        [AnnotationAttribute(Name = "Vordt of the Boreal Valley", Description = "High Wall of Lothric")]
        VordtOfTheBorealValley = 13000800,

        [AnnotationAttribute(Name = "Curse-Rotted Greatwood", Description = "Undead Settlement")]
        CurseRottedGreatwood = 13100800,
        
        [AnnotationAttribute(Name = "Crystal Sage", Description = "Road of Sacrifices")]
        CrystalSage = 13300850,
        
        [AnnotationAttribute(Name = "Abyss Watchers", Description = "Farron Keep")]
        AbyssWatchers = 13300800,
        
        [AnnotationAttribute(Name = "Deacons of the Deep", Description = "Cathedral of the Deep")]
        DeaconsOfTheDeep = 13500800,
        
        [AnnotationAttribute(Name = "High Lord Wolnir", Description = "Catacombs of Carthus")]
        HighLordWolnir = 13800800,
        
        [AnnotationAttribute(Name = "Old Demon King", Description = "Smouldering Lake")]
        OldDemonKing = 13800830,
        
        [AnnotationAttribute(Name = "Pontiff Sulyvahn", Description = "Irithyll of the Boreal Valley")]
        PontiffSulyvahn = 13700850,
        
        [AnnotationAttribute(Name = "Yhorm the Giant", Description = "Profaned Capital")]
        YhormTheGiant = 13900800,
        
        [AnnotationAttribute(Name = "Aldrich, Devourer of Gods", Description = "Anor Londo")]
        AldrichDevourerOfGods = 13700800,
        
        [AnnotationAttribute(Name = "Dancer of the Boreal Valley", Description = "High Wall of Lothric")]
        DancerOfTheBorealValley = 13000890,

        [AnnotationAttribute(Name = "Dragonslayer Armour", Description = "Lothric Castle")]
        DragonslayerArmour = 13010800,

        [AnnotationAttribute(Name = "Oceiros, the Consumed King", Description = "Consumed King's Garden")]
        OceirosTheConsumedKing = 13000830,
        
        [AnnotationAttribute(Name = "Champion Gundyr", Description = "Untended Graves")]
        ChampionGundyr = 14000830,

        [AnnotationAttribute(Name = "Lothric, Younger Prince", Description = "The top of Lothric Castle")]
        LothricYoungerPrince = 13410830,

        [AnnotationAttribute(Name = "Ancient Wyvern", Description = "Archdragon Peak")]
        AncientWyvern = 13200800,
        
        [AnnotationAttribute(Name = "Nameless King", Description = "Archdragon Peak")]
        NamelessKing = 13200850,
        
        [AnnotationAttribute(Name = "Soul of Cinder", Description = "Kiln of the First Flame")]
        SoulOfCinder = 14100800,
        
        [AnnotationAttribute(Name = "Sister Friede", Description = "Painted World of Ariandel")]
        SisterFriede = 14500800,    
        
        [AnnotationAttribute(Name = "Champion's Gravetender & Gravetender Greatwolf", Description = "Painted World of Ariandel")]
        ChampionsGravetenderAndGravetenderGreatwolf = 14500860,
        
        [AnnotationAttribute(Name = "Demon in Pain & Demon From Below / Demon Prince", Description = "The Dreg Heap")]
        DemonInPainAndDemonFromBelowDemonPrince = 15000800,

        [AnnotationAttribute(Name = "Halflight, Spear of the Church", Description = "The Ringed City")]
        HalflightSpearOfTheChurch = 15100800,

        [AnnotationAttribute(Name = "Darkeater Midir", Description = "The Ringed City")]
        DarkeaterMidir = 15100850,
        
        [AnnotationAttribute(Name = "Slave Knight Gael", Description = "The Ringed City")]
        SlaveKnightGael = 15110800,
    }
}
