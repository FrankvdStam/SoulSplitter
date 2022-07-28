using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls1_Old
{
    public enum Bonfire
    {
        AnorLondoEntrance = 1511960,
        AnorLondoInterior = 1511961,
        AnorLondoPrincess = 1511950,
        AnorLondoTomb = 1511962,
        AshLakeEntrance = 1321961,
        AshLakeDragon = 1321960,
        BlighttownBridge = 1401962,
        BlighttownSwamp = 1401961,
        CatacombsEntrance = 1301960,
        CatacombsIllusion = 1301961,
        ChasmOfTheAbyss = 1211950,
        CrystalCaves = 1701950,
        DarkrootBasin = 1601961,
        DarkrootGarden = 1201961,
        DaughterOfChaos = 1401960,
        DemonRuinsCentral = 1411962,
        DemonRuinsEntrance = 1411961,
        DemonRuinsFiresage = 1411963,
        DukesArchivesBalcony = 1701960,
        DukesArchivesEntrance = 1701962,
        DukesArchivesPrison = 1701961,
        FirelinkAltar = 1801960,
        FirelinkShrine = 1021960,
        GreatHollow = 1321962,
        LostIzalithBedOfChaos = 1411950,
        LostIzalithIllusion = 1411960,
        LostIzalithLavaField = 1411964,
        OolacileSanctuary = 1211961,
        OolacileTownshipDungeon = 1211964,
        OolacileTownshipEntrance = 1211962,
        PaintedWorld = 1101960,
        SanctuaryGarden = 1211963,
        SensFortress = 1501961,
        TheAbyss = 1601950,
        TheDepths = 1001960,
        TombOfTheGiantsAlcove = 1311960,
        TombOfTheGiantsNito = 1311950,
        TombOfTheGiantsPatches = 1311961,
        UndeadAsylumCourtyard = 1811960,
        UndeadAsylumInterior = 1811961,
        UndeadBurgEntrance = 1011962,
        UndeadParishAndre = 1011964,
        UndeadParishSunlight = 1011961
    }

    public enum BonfireState
    {
        // Note that "inactive" bonfires (bonfires that are disabled because their fire keeper is dead) aren't given
        // their own state (at least not at the same memory location).
        Lit = 10,
        KindledOnce = 20,
        KindledTwice = 30,
        KindledThrice = 40,
        Undiscovered = -1,
        Unlit = 0
    }
}
