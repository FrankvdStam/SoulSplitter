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

namespace SoulMemory.DarkSouls2
{
    public static class Data
    {
        public struct Bonfire
        {
            public Bonfire(WarpType warpType, int areaId, ushort bonfireId, string name)
            {
                WarpType = warpType;
                AreaId = areaId;
                BonfireId = bonfireId;
                Name = name;
            }

            public WarpType WarpType;
            public int AreaId;
            public ushort BonfireId;
            public string Name;
        }

        //TODO: move name string to display name attribute on WarpType enum
        public static List<Bonfire> Bonfires = new List<Bonfire>()
        {
            new Bonfire(WarpType.FireKeepersDwelling    , 167903232, 2650 , "Fire Keepers' Dwelling"),
            new Bonfire(WarpType.TheFarFire             , 168034304, 4650 , "The Far Fire"),
            new Bonfire(WarpType.TheCrestfallensRetreat , 168427520, 10670, "The Crestfallen's Retreat"),
            new Bonfire(WarpType.CardinalTower          , 168427520, 10655, "Cardinal Tower"),
            new Bonfire(WarpType.SoldiersRest           , 168427520, 10660, "Soldiers' Rest"),
            new Bonfire(WarpType.ThePlaceUnbeknownst    , 168427520, 10675, "The Place Unbeknownst"),
            new Bonfire(WarpType.HeidesRuin             , 169803776, 31655, "Heide's Ruin"),
            new Bonfire(WarpType.TowerOfFlame           , 169803776, 31650, "Tower of Flame"),
            new Bonfire(WarpType.TheBlueCathedral       , 169803776, 31660, "The Blue Cathedral"),
            new Bonfire(WarpType.UnseenPathToHeide      , 168951808, 18650, "Unseen Path to Heide"),
            new Bonfire(WarpType.ExileHoldingCells      , 168820736, 16655, "Exile Holding Cells"),
            new Bonfire(WarpType.McDuffsWorkshop        , 168820736, 16670, "McDuff's Workshop"),
            new Bonfire(WarpType.ServantsQuarters       , 168820736, 16675, "Servants' Quarters"),
            new Bonfire(WarpType.StraidsCell            , 168820736, 16650, "Straid's Cell"),
            new Bonfire(WarpType.TheTowerApart          , 168820736, 16660, "The Tower Apart"),
            new Bonfire(WarpType.TheSaltfort            , 168820736, 16685, "The Saltfort"),
            new Bonfire(WarpType.UpperRamparts          , 168820736, 16665, "Upper Ramparts"),
            new Bonfire(WarpType.UndeadRefuge           , 169279488, 23650, "Undead Refuge"),
            new Bonfire(WarpType.BridgeApproach         , 169279488, 23655, "Bridge Approach"),
            new Bonfire(WarpType.UndeadLockaway         , 169279488, 23660, "Undead Lockaway"),
            new Bonfire(WarpType.UndeadPurgatory        , 169279488, 23665, "Undead Purgatory"),
            new Bonfire(WarpType.PoisonPool             , 168886272, 17665, "Poison Pool"),
            new Bonfire(WarpType.TheMines               , 168886272, 17650, "The Mines"),
            new Bonfire(WarpType.LowerEarthenPeak       , 168886272, 17655, "Lower Earthen Peak"),
            new Bonfire(WarpType.CentralEarthenPeak     , 168886272, 17670, "Central Earthen Peak"),
            new Bonfire(WarpType.UpperEarthenPeak       , 168886272, 17675, "Upper Earthen Peak"),
            new Bonfire(WarpType.ThresholdBridge        , 169017344, 19655, "Threshold Bridge"),
            new Bonfire(WarpType.IronHearthHall         , 169017344, 19650, "Ironhearth Hall"),
            new Bonfire(WarpType.EygilsIdol             , 169017344, 19660, "Eygil's Idol"),
            new Bonfire(WarpType.BelfrySolApproach      , 169017344, 19665, "Belfry Sol Approach"),
            new Bonfire(WarpType.OldAkelarre            , 169672704, 29650, "Old Akelarre"),
            new Bonfire(WarpType.RuinedForkRoad         , 169869312, 32655, "Ruined Fork Road"),
            new Bonfire(WarpType.ShadedRuins            , 169869312, 32660, "Shaded Ruins"),
            new Bonfire(WarpType.GyrmsRespite           , 169934848, 33655, "Gyrm's Respite"),
            new Bonfire(WarpType.OrdealsEnd             , 169934848, 33660, "Ordeal's End"),
            new Bonfire(WarpType.RoyalArmyCampsite      , 168689664, 14655, "Royal Army Campsite"),
            new Bonfire(WarpType.ChapelThreshold        , 168689664, 14660, "Chapel Threshold"),
            new Bonfire(WarpType.LowerBrightstoneCove   , 168689664, 14650, "Lower Brightstone Cove"),
            new Bonfire(WarpType.HarvalsRestingPlace    , 170000384, 34655, "Harval's Resting Place"),
            new Bonfire(WarpType.GraveEntrance          , 170000384, 34650, "Grave Entrance"),
            new Bonfire(WarpType.UpperGutter            , 169410560, 25665, "Upper Gutter"),
            new Bonfire(WarpType.CentralGutter          , 169410560, 25655, "Central Gutter"),
            new Bonfire(WarpType.BlackGulchMouth        , 169410560, 25650, "Black Gulch Mouth"),
            new Bonfire(WarpType.HiddenChamber          , 169410560, 25660, "Hidden Chamber"),
            new Bonfire(WarpType.KingsGate              , 336920576, 21650, "King's Gate"),
            new Bonfire(WarpType.UnderCastleDrangleic   , 336920576, 21665, "Under Castle Drangleic"),
            new Bonfire(WarpType.CentralCastleDrangleic , 336920576, 21655, "Central Castle Drangleic"),
            new Bonfire(WarpType.ForgottenChamber       , 336920576, 21660, "Forgotten Chamber"),
            new Bonfire(WarpType.TowerofPrayerAmana     , 336265216, 11650, "Tower of Prayer (Amana)"),
            new Bonfire(WarpType.CrumbledRuins          , 336265216, 11655, "Crumbled Ruins"),
            new Bonfire(WarpType.RhoysRestingPlace      , 336265216, 11660, "Rhoy's Resting Place"),
            new Bonfire(WarpType.RiseoftheDead          , 336265216, 11670, "Rise of the Dead"),
            new Bonfire(WarpType.UndeadCryptEntrance    , 337117184, 24655, "Undead Crypt Entrance"),
            new Bonfire(WarpType.UndeadDitch            , 337117184, 24650, "Undead Ditch"),
            new Bonfire(WarpType.Foregarden             , 168755200, 15650, "Foregarden"),
            new Bonfire(WarpType.RitualSite             , 168755200, 15655, "Ritual Site"),
            new Bonfire(WarpType.DragonAerie            , 169541632, 27650, "Dragon Aerie"),
            new Bonfire(WarpType.ShrineEntrance         , 169541632, 27655, "Shrine Entrance"),
            new Bonfire(WarpType.SanctumWalk            , 841154560, 35650, "Sanctum Walk"),
            new Bonfire(WarpType.TowerOfPrayerShulva    , 841154560, 35685, "Tower of Prayer (Shulva)"),
            new Bonfire(WarpType.PriestessChamber       , 841154560, 35655, "Priestess' Chamber"),
            new Bonfire(WarpType.HiddenSanctumChamber   , 841154560, 35670, "Hidden Sanctum Chamber"),
            new Bonfire(WarpType.LairOfTheImperfect     , 841154560, 35675, "Lair of the Imperfect"),
            new Bonfire(WarpType.SanctumInterior        , 841154560, 35680, "Sanctum Interior"),
            new Bonfire(WarpType.SanctumNadir           , 841154560, 35665, "Sanctum Nadir"),
            new Bonfire(WarpType.ThroneFloor            , 841220096, 36650, "Throne Floor"),
            new Bonfire(WarpType.UpperFloor             , 841220096, 36660, "Upper Floor"),
            new Bonfire(WarpType.Foyer                  , 841220096, 36655, "Foyer"),
            new Bonfire(WarpType.LowermostFloor         , 841220096, 36670, "Lowermost Floor"),
            new Bonfire(WarpType.SmelterThrone       , 841220096, 36675, "The Smelter Throne"),
            new Bonfire(WarpType.IronHallwayEntrance    , 841220096, 36665, "Iron Hallway Entrance"),
            new Bonfire(WarpType.OuterWall              , 841285632, 37650, "Outer Wall"),
            new Bonfire(WarpType.AbandonedDwelling      , 841285632, 37660, "Abandoned Dwelling"),
            new Bonfire(WarpType.ExpulsionChamber       , 841285632, 37675, "Expulsion Chamber"),
            new Bonfire(WarpType.InnerWall              , 841285632, 37685, "Inner Wall"),
            new Bonfire(WarpType.LowerGarrison          , 841285632, 37665, "Lower Garrison"),
            new Bonfire(WarpType.GrandCathedral         , 841285632, 37670, "Grand Cathedral"),
        };
    }
}
