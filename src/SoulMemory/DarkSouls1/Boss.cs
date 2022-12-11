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

namespace SoulMemory.DarkSouls1
{
    [XmlType(Namespace = "SoulMemory.DarkSouls1")]
    public enum Boss : uint
    {
        [AnnotationAttribute(Name = "Asylum Demon")]
        AsylumDemon = 16,

        [AnnotationAttribute(Name = "Bell Gargoyle")]
        BellGargoyles = 3,

        [AnnotationAttribute(Name = "Capra Demon")]
        CapraDemon = 11010902,

        [AnnotationAttribute(Name = "Ceaseless Discharge")]
        CeaselessDischarge = 11410900,

        [AnnotationAttribute(Name = "Centipede Demon")]
        CentipedeDemon = 11410901,

        [AnnotationAttribute(Name = "Chaos Witch Quelaag")]
        ChaosWitchQuelaag = 9,

        [AnnotationAttribute(Name = "Crossbreed Priscilla")]
        CrossbreedPriscilla = 4,

        [AnnotationAttribute(Name = "Dark Sun Gwyndolin")]
        DarkSunGwyndolindolin = 11510900,

        [AnnotationAttribute(Name = "Demon Firesage")]
        DemonFiresage = 11410410,

        [AnnotationAttribute(Name = "Four Kings")]
        FourKings = 13,

        [AnnotationAttribute(Name = "Gaping Dragon")]
        GapingDragon = 2,

        [AnnotationAttribute(Name = "Great Grey Wolf Sif")]
        GreatGreyWolfSif = 5,

        [AnnotationAttribute(Name = "Gwyn Lord of Cinder")]
        GwynLordOfCinder = 15,

        [AnnotationAttribute(Name = "Iron Golem")]
        IronGolem = 11,

        [AnnotationAttribute(Name = "Moonlight Butterfly")]
        MoonlightButterfly = 11200900,

        [AnnotationAttribute(Name = "Nito")]
        Nito = 7,

        [AnnotationAttribute(Name = "Ornstein And Smough")]
        OrnsteinAndSmough = 12,

        [AnnotationAttribute(Name = "Pinwheel")]
        Pinwheel = 6,

        [AnnotationAttribute(Name = "Seath the Scaleless")]
        SeathTheScaleless = 14,

        [AnnotationAttribute(Name = "Stray Demon")]
        StrayDemon = 11810900,

        [AnnotationAttribute(Name = "Taurus Demon")]
        TaurusDemon = 11010901,

        [AnnotationAttribute(Name = "The Bed of Chaos")]
        BedOfChaos = 10,
        
        [AnnotationAttribute(Name = "Artorias the Abysswalker")]
        ArtoriasTheAbysswalker = 11210001,
        
        [AnnotationAttribute(Name = "Black Dragon Kalameet")]
        BlackDragonKalameet = 11210004,

        [AnnotationAttribute(Name = "Manus, Father of the Abyss")]
        ManusFatherOfTheAbyss = 11210002,
        
        [AnnotationAttribute(Name = "Sanctuary Guardian")]
        SanctuaryGuardian = 11210000,
    }
}
