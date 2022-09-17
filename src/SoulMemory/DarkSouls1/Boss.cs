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

namespace SoulMemory.DarkSouls1
{
    [XmlType(Namespace = "SoulMemory.DarkSouls1")]
    public enum Boss : uint
    {
        [Display(Name = "Asylum Demon")]
        AsylumDemon = 16,

        [Display(Name = "Bell Gargoyle")]
        BellGargoyles = 3,

        [Display(Name = "Capra Demon")]
        CapraDemon = 11010902,

        [Display(Name = "Ceaseless Discharge")]
        CeaselessDischarge = 11410900,

        [Display(Name = "Centipede Demon")]
        CentipedeDemon = 11410901,

        [Display(Name = "Chaos Witch Quelaag")]
        ChaosWitchQuelaag = 9,

        [Display(Name = "Crossbreed Priscilla")]
        CrossbreedPriscilla = 4,

        [Display(Name = "Dark Sun Gwyndolin")]
        DarkSunGwyndolindolin = 11510900,

        [Display(Name = "Demon Firesage")]
        DemonFiresage = 11410410,

        [Display(Name = "Four Kings")]
        FourKings = 13,

        [Display(Name = "Gaping Dragon")]
        GapingDragon = 2,

        [Display(Name = "Great Grey Wolf Sif")]
        GreatGreyWolfSif = 5,

        [Display(Name = "Gwyn Lord of Cinder")]
        GwynLordOfCinder = 15,

        [Display(Name = "Iron Golem")]
        IronGolem = 11,

        [Display(Name = "Moonlight Butterfly")]
        MoonlightButterfly = 11200900,

        [Display(Name = "Nito")]
        Nito = 7,

        [Display(Name = "Ornstein And Smough")]
        OrnsteinAndSmough = 12,

        [Display(Name = "Pinwheel")]
        Pinwheel = 6,

        [Display(Name = "Seath the Scaleless")]
        SeathTheScaleless = 14,

        [Display(Name = "Stray Demon")]
        StrayDemon = 11810900,

        [Display(Name = "Taurus Demon")]
        TaurusDemon = 11010901,

        [Display(Name = "The Bed of Chaos")]
        BedOfChaos = 10,
        
        [Display(Name = "Artorias the Abysswalker")]
        ArtoriasTheAbysswalker = 11210001,
        
        [Display(Name = "Black Dragon Kalameet")]
        BlackDragonKalameet = 11210004,

        [Display(Name = "Manus, Father of the Abyss")]
        ManusFatherOfTheAbyss = 11210002,
        
        [Display(Name = "Sanctuary Guardian")]
        SanctuaryGuardian = 11210000,
    }
}
