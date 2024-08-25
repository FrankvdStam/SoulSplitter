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

namespace SoulMemory.Sekiro
{
    [XmlType(Namespace = "Sekiro")]
    public enum Boss
    {
        [Annotation(Name = "Gyoubu Masataka Oniwa")]
        GyoubuMasatakaOniwa = 9301,
        
        [Annotation(Name = "Lady Butterfly")]              
        LadyButterfly = 9302,

        [Annotation(Name = "Genichiro Ashina")]            
        GenichiroAshina = 9303,
            
        [Annotation(Name = "Folding Screen Monkeys")]      
        FoldingScreenMonkeys = 9305,
        
        [Annotation(Name = "Guardian Ape")]                
        GuardianApe = 9304,
        
        [Annotation(Name = "Headless Ape")]                
        HeadlessApe = 9307,
        
        [Annotation(Name = "Corrupted Monk (ghost)")]      
        CorruptedMonkGhost = 9306,

        [Annotation(Name = "Emma, the Gentle Blade")]      
        EmmaTheGentleBlade = 9315,

        [Annotation(Name = "Isshin Ashina")]               
        IsshinAshina = 9316,

        [Annotation(Name = "Great Shinobi Owl")]            
        GreatShinobiOwl = 9308,

        [Annotation(Name = "True Corrupted Monk")]         
        TrueCorruptedMonk = 9309,

        [Annotation(Name = "Divine Dragon")]               
        DivineDragon = 9310,

        [Annotation(Name = "Owl (Father)")]                
        OwlFather = 9317,

        [Annotation(Name = "Demon of Hatred")]             
        DemonOfHatred = 9313,

        [Annotation(Name = "Isshin, the Sword Saint")]     
        IsshinTheSwordSaint = 9312,
    }
}
