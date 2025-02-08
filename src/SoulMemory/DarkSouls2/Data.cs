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

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SoulMemory.DarkSouls2;

public static class Data
{
    public struct Bonfire(WarpType warpType, int areaId, ushort bonfireId, string name)
    {
        public WarpType WarpType = warpType;
        public int AreaId = areaId;
        public ushort BonfireId = bonfireId;
        public string Name = name;
    }

    public static readonly ReadOnlyCollection<Bonfire> Bonfires = new((List<Bonfire>)
    [
        new(WarpType.FireKeepersDwelling, 167903232, 2650, "Fire Keepers' Dwelling"),
        new(WarpType.TheFarFire, 168034304, 4650, "The Far Fire"),
        new(WarpType.TheCrestfallensRetreat, 168427520, 10670, "The Crestfallen's Retreat"),
        new(WarpType.CardinalTower, 168427520, 10655, "Cardinal Tower"),
        new(WarpType.SoldiersRest, 168427520, 10660, "Soldiers' Rest"),
        new(WarpType.ThePlaceUnbeknownst, 168427520, 10675, "The Place Unbeknownst"),
        new(WarpType.HeidesRuin, 169803776, 31655, "Heide's Ruin"),
        new(WarpType.TowerOfFlame, 169803776, 31650, "Tower of Flame"),
        new(WarpType.TheBlueCathedral, 169803776, 31660, "The Blue Cathedral"),
        new(WarpType.UnseenPathToHeide, 168951808, 18650, "Unseen Path to Heide"),
        new(WarpType.ExileHoldingCells, 168820736, 16655, "Exile Holding Cells"),
        new(WarpType.McDuffsWorkshop, 168820736, 16670, "McDuff's Workshop"),
        new(WarpType.ServantsQuarters, 168820736, 16675, "Servants' Quarters"),
        new(WarpType.StraidsCell, 168820736, 16650, "Straid's Cell"),
        new(WarpType.TheTowerApart, 168820736, 16660, "The Tower Apart"),
        new(WarpType.TheSaltfort, 168820736, 16685, "The Saltfort"),
        new(WarpType.UpperRamparts, 168820736, 16665, "Upper Ramparts"),
        new(WarpType.UndeadRefuge, 169279488, 23650, "Undead Refuge"),
        new(WarpType.BridgeApproach, 169279488, 23655, "Bridge Approach"),
        new(WarpType.UndeadLockaway, 169279488, 23660, "Undead Lockaway"),
        new(WarpType.UndeadPurgatory, 169279488, 23665, "Undead Purgatory"),
        new(WarpType.PoisonPool, 168886272, 17665, "Poison Pool"),
        new(WarpType.TheMines, 168886272, 17650, "The Mines"),
        new(WarpType.LowerEarthenPeak, 168886272, 17655, "Lower Earthen Peak"),
        new(WarpType.CentralEarthenPeak, 168886272, 17670, "Central Earthen Peak"),
        new(WarpType.UpperEarthenPeak, 168886272, 17675, "Upper Earthen Peak"),
        new(WarpType.ThresholdBridge, 169017344, 19655, "Threshold Bridge"),
        new(WarpType.IronHearthHall, 169017344, 19650, "Ironhearth Hall"),
        new(WarpType.EygilsIdol, 169017344, 19660, "Eygil's Idol"),
        new(WarpType.BelfrySolApproach, 169017344, 19665, "Belfry Sol Approach"),
        new(WarpType.OldAkelarre, 169672704, 29650, "Old Akelarre"),
        new(WarpType.RuinedForkRoad, 169869312, 32655, "Ruined Fork Road"),
        new(WarpType.ShadedRuins, 169869312, 32660, "Shaded Ruins"),
        new(WarpType.GyrmsRespite, 169934848, 33655, "Gyrm's Respite"),
        new(WarpType.OrdealsEnd, 169934848, 33660, "Ordeal's End"),
        new(WarpType.RoyalArmyCampsite, 168689664, 14655, "Royal Army Campsite"),
        new(WarpType.ChapelThreshold, 168689664, 14660, "Chapel Threshold"),
        new(WarpType.LowerBrightstoneCove, 168689664, 14650, "Lower Brightstone Cove"),
        new(WarpType.HarvalsRestingPlace, 170000384, 34655, "Harval's Resting Place"),
        new(WarpType.GraveEntrance, 170000384, 34650, "Grave Entrance"),
        new(WarpType.UpperGutter, 169410560, 25665, "Upper Gutter"),
        new(WarpType.CentralGutter, 169410560, 25655, "Central Gutter"),
        new(WarpType.BlackGulchMouth, 169410560, 25650, "Black Gulch Mouth"),
        new(WarpType.HiddenChamber, 169410560, 25660, "Hidden Chamber"),
        new(WarpType.KingsGate, 336920576, 21650, "King's Gate"),
        new(WarpType.UnderCastleDrangleic, 336920576, 21665, "Under Castle Drangleic"),
        new(WarpType.CentralCastleDrangleic, 336920576, 21655, "Central Castle Drangleic"),
        new(WarpType.ForgottenChamber, 336920576, 21660, "Forgotten Chamber"),
        new(WarpType.TowerofPrayerAmana, 336265216, 11650, "Tower of Prayer (Amana)"),
        new(WarpType.CrumbledRuins, 336265216, 11655, "Crumbled Ruins"),
        new(WarpType.RhoysRestingPlace, 336265216, 11660, "Rhoy's Resting Place"),
        new(WarpType.RiseoftheDead, 336265216, 11670, "Rise of the Dead"),
        new(WarpType.UndeadCryptEntrance, 337117184, 24655, "Undead Crypt Entrance"),
        new(WarpType.UndeadDitch, 337117184, 24650, "Undead Ditch"),
        new(WarpType.Foregarden, 168755200, 15650, "Foregarden"),
        new(WarpType.RitualSite, 168755200, 15655, "Ritual Site"),
        new(WarpType.DragonAerie, 169541632, 27650, "Dragon Aerie"),
        new(WarpType.ShrineEntrance, 169541632, 27655, "Shrine Entrance"),
        new(WarpType.SanctumWalk, 841154560, 35650, "Sanctum Walk"),
        new(WarpType.TowerOfPrayerShulva, 841154560, 35685, "Tower of Prayer (Shulva)"),
        new(WarpType.PriestessChamber, 841154560, 35655, "Priestess' Chamber"),
        new(WarpType.HiddenSanctumChamber, 841154560, 35670, "Hidden Sanctum Chamber"),
        new(WarpType.LairOfTheImperfect, 841154560, 35675, "Lair of the Imperfect"),
        new(WarpType.SanctumInterior, 841154560, 35680, "Sanctum Interior"),
        new(WarpType.SanctumNadir, 841154560, 35665, "Sanctum Nadir"),
        new(WarpType.ThroneFloor, 841220096, 36650, "Throne Floor"),
        new(WarpType.UpperFloor, 841220096, 36660, "Upper Floor"),
        new(WarpType.Foyer, 841220096, 36655, "Foyer"),
        new(WarpType.LowermostFloor, 841220096, 36670, "Lowermost Floor"),
        new(WarpType.SmelterThrone, 841220096, 36675, "The Smelter Throne"),
        new(WarpType.IronHallwayEntrance, 841220096, 36665, "Iron Hallway Entrance"),
        new(WarpType.OuterWall, 841285632, 37650, "Outer Wall"),
        new(WarpType.AbandonedDwelling, 841285632, 37660, "Abandoned Dwelling"),
        new(WarpType.ExpulsionChamber, 841285632, 37675, "Expulsion Chamber"),
        new(WarpType.InnerWall, 841285632, 37685, "Inner Wall"),
        new(WarpType.LowerGarrison, 841285632, 37665, "Lower Garrison"),
        new(WarpType.GrandCathedral, 841285632, 37670, "Grand Cathedral")
    ]);
}
