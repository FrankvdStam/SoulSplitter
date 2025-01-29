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

namespace SoulMemory.DarkSouls1;

[XmlType(Namespace = "SoulMemory.DarkSouls1")]
public enum Boss : uint
{
    [Annotation(Name = "Asylum Demon")]
    AsylumDemon = 16,

    [Annotation(Name = "Bell Gargoyle")]
    BellGargoyles = 3,

    [Annotation(Name = "Capra Demon")]
    CapraDemon = 11010902,

    [Annotation(Name = "Ceaseless Discharge")]
    CeaselessDischarge = 11410900,

    [Annotation(Name = "Centipede Demon")]
    CentipedeDemon = 11410901,

    [Annotation(Name = "Chaos Witch Quelaag")]
    ChaosWitchQuelaag = 9,

    [Annotation(Name = "Crossbreed Priscilla")]
    CrossbreedPriscilla = 4,

    [Annotation(Name = "Dark Sun Gwyndolin")]
    DarkSunGwyndolindolin = 11510900,

    [Annotation(Name = "Demon Firesage")]
    DemonFiresage = 11410410,

    [Annotation(Name = "Four Kings")]
    FourKings = 13,

    [Annotation(Name = "Gaping Dragon")]
    GapingDragon = 2,

    [Annotation(Name = "Great Grey Wolf Sif")]
    GreatGreyWolfSif = 5,

    [Annotation(Name = "Gwyn Lord of Cinder")]
    GwynLordOfCinder = 15,

    [Annotation(Name = "Iron Golem")]
    IronGolem = 11,

    [Annotation(Name = "Moonlight Butterfly")]
    MoonlightButterfly = 11200900,

    [Annotation(Name = "Nito")]
    Nito = 7,

    [Annotation(Name = "Ornstein And Smough")]
    OrnsteinAndSmough = 12,

    [Annotation(Name = "Pinwheel")]
    Pinwheel = 6,

    [Annotation(Name = "Seath the Scaleless")]
    SeathTheScaleless = 14,

    [Annotation(Name = "Stray Demon")]
    StrayDemon = 11810900,

    [Annotation(Name = "Taurus Demon")]
    TaurusDemon = 11010901,

    [Annotation(Name = "The Bed of Chaos")]
    BedOfChaos = 10,
    
    [Annotation(Name = "Artorias the Abysswalker")]
    ArtoriasTheAbysswalker = 11210001,
    
    [Annotation(Name = "Black Dragon Kalameet")]
    BlackDragonKalameet = 11210004,

    [Annotation(Name = "Manus, Father of the Abyss")]
    ManusFatherOfTheAbyss = 11210002,
    
    [Annotation(Name = "Sanctuary Guardian")]
    SanctuaryGuardian = 11210000,
}
