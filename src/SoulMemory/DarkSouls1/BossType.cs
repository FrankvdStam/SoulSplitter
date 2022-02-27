using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls1
{
    public enum BossType
    {
        [Display(Name = "Artorias")]
        Artorias,

        [Display(Name = "Asylum Demon")]
        AsylumDemon,

        [Display(Name = "Bed of Chaos")]
        BedOfChaos,

        [Display(Name = "Capra Demon")]
        CapraDemon,

        [Display(Name = "Ceaseless Discharge")]
        CeaselessDischarge,

        [Display(Name = "Centipede Demon")]
        CentipedeDemon,

        [Display(Name = "Firesage")]
        Firesage,

        [Display(Name = "Four Kings")]
        FourKings,

        [Display(Name = "Gaping Dragon")]
        GapingDragon,

        [Display(Name = "Gargoyles")]
        Gargoyles,

        [Display(Name = "Gwyn")]
        Gwyn,

        [Display(Name = "Gwyndolin")]
        Gwyndolin,

        [Display(Name = "Iron Golem")]
        IronGolem,

        [Display(Name = "Kalameet")]
        Kalameet,

        [Display(Name = "Manus")]
        Manus,

        [Display(Name = "Moonlight Butterfly")]
        MoonlightButterfly,

        [Display(Name = "Nito")]
        Nito,

        [Display(Name = "Ornstein and Smough")]
        OrnsteinAndSmough,

        [Display(Name = "Pinwheel")]
        Pinwheel,

        [Display(Name = "Priscilla")]
        Priscilla,

        [Display(Name = "Quelaag")]
        Quelaag,

        [Display(Name = "Sanctuary Guardian")]
        SanctuaryGuardian,

        [Display(Name = "Seath")]
        Seath,

        [Display(Name = "Sif")]
        Sif,

        [Display(Name = "Stray Demon")]
        StrayDemon,

        [Display(Name = "Taurus Demon")]
        TaurusDemon
    }
}
