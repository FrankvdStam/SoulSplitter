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

namespace SoulMemory.Games.DarkSouls1;

public enum Bonfire
{
    UndeadAsylumCourtyard = 1811960,
    UndeadAsylumInterior = 1811961,
    FirelinkShrine = 1021960,
    FirelinkAltarLordvessel = 1801960,
    UndeadBurg = 1011962,
    UndeadBurgSunlightAltar = 1011961,
    UndeadParishAndre = 1011964,
    DarkrootGarden = 1201961,
    DarkrootBasin = 1601961,
    Depths = 1001960,
    BlighttownCatwalk = 1401962,
    BlighttownSwamp = 1401961,
    DaughterOfChaos = 1401960,
    TheGreatHollow = 1321962,
    AshLake = 1321961,
    AshLakeDragon = 1321960,
    DemonRuinsEntrance = 1411961,
    DemonRuinsStaircase = 1411962,
    DemonRuinsCatacombs = 1411963,
    LostIzalithLavaPits = 1411964,
    LostIzalith2 = 1411960,
    LostIzalithHeartOfChaos = 1411950,
    SensFortress = 1501961,
    AnorLondo = 1511960,
    AnorLondoDarkmoonTomb = 1511962,
    AnorLondoResidence = 1511961,
    AnorLondoChamberOfThePrincess = 1511950,
    PaintedWorldOfAriamis = 1101960,
    DukesArchives1 = 1701962,
    DukesArchives2 = 1701961,
    DukesArchives3 = 1701960,
    CrystalCave = 1701950,
    Catacombs1 = 1301960,
    Catacombs2 = 1301961,
    TombOfTheGiantsPatches = 1311961,
    TombOfTheGiants2 = 1311960,
    TombOfTheGiantsAltarOfTheGravelord = 1311950,
    TheAbyss = 1601950,
    OolacileSanctuaryGarden = 1211963,
    OolacileSanctuary = 1211961,
    OolacileTownship = 1211962,
    OolacileTownshipDungeon = 1211964,
    ChasmOfTheAbyss = 1211950
}

public enum BonfireState
{
    Unknown = -1,
    Discovered = 0,
    Unlocked = 10,
    Kindled1 = 20,
    Kindled2 = 30,
    Kindled3 = 40
}
