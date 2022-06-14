using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoulMemory.Sekiro
{
    [XmlType(Namespace = "Sekiro")]
    public enum Boss
    {
        [Display(Name = "Gyoubu Masataka Oniwa")]
        GyoubuMasatakaOniwa = 9301,
        
        [Display(Name = "Lady Butterfly")]              
        LadyButterfly = 9302,

        [Display(Name = "Genichiro Ashina")]            
        GenichiroAshina = 9303,
            
        [Display(Name = "Folding Screen Monkeys")]      
        FoldingScreenMonkeys = 9305,
        
        [Display(Name = "Guardian Ape")]                
        GuardianApe = 9304,
        
        [Display(Name = "Headless Ape")]                
        HeadlessApe = 9307,
        
        [Display(Name = "Corrupted Monk (ghost)")]      
        CorruptedMonkGhost = 9306,

        [Display(Name = "Emma, the Gentle Blade")]      
        EmmaTheGentleBlade = 9315,

        [Display(Name = "Isshin Ashina")]               
        IsshinAshina = 9316,

        [Display(Name = "Great Shinobi Owl")]            
        GreatShinobiOwl = 9308,

        [Display(Name = "True Corrupted Monk")]         
        TrueCorruptedMonk = 9309,

        [Display(Name = "Divine Dragon")]               
        DivineDragon = 9310,

        [Display(Name = "Owl (Father)")]                
        OwlFather = 9317,

        [Display(Name = "Demon of Hatred")]             
        DemonOfHatred = 9313,

        [Display(Name = "Isshin, the Sword Saint")]     
        IsshinTheSwordSaint = 9312,
    }
}
