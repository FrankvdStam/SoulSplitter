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
    public enum KnownFlag : uint
    {

      [AnnotationAttribute(Name = "Bell of Awakening, Undead Parish 11010700", Description = "Bells of Awakening")]
      BellOfAwakeningUndeadParish = 11010700,

      [AnnotationAttribute(Name = "Bell of Awakening, Blighttown 11400200", Description = "Bells of Awakening")]
      BellOfAwakeningBlighttown = 11400200,

      [AnnotationAttribute(Name = "Other, Dark Anor Londo 11510400", Description = "Lordvessel")]
      OtherDarkAnorLondo = 11510400,

      [AnnotationAttribute(Name = "Other, Receive Lordvessel With Gwynevere Still Alive 11510592", Description = "Lordvessel")]
      OtherReceiveLordvesselWithGwynevereStillAlive = 11510592,

      [AnnotationAttribute(Name = "Other, Receive Lordvessel (Gwynevere Alive or Dead) 50000090", Description = "Lordvessel")]
      OtherReceiveLordvesselGwynevereAliveOrDead = 50000090,

      [AnnotationAttribute(Name = "Anor Londo, Door to Gwynevere 11510110", Description = "Doors")]
      AnorLondoDoorToGwynevere = 11510110,

      [AnnotationAttribute(Name = "Darkroot Garden, Crest of Artorias Door 61200500", Description = "Doors")]
      DarkrootGardenCrestOfArtoriasDoor = 61200500,

      [AnnotationAttribute(Name = "Darkroot Garden, Sif Door 61200501", Description = "Doors")]
      DarkrootGardenSifDoor = 61200501,

      [AnnotationAttribute(Name = "Demon Ruins, Shortcut Door to Lost Izalith 11410340", Description = "Doors")]
      DemonRuinsShortcutDoorToLostIzalith = 11410340,

      [AnnotationAttribute(Name = "Northern Undead Asylum, Cell Door 11810103", Description = "Doors")]
      NorthernUndeadAsylumCellDoor = 11810103,

      [AnnotationAttribute(Name = "Northern Undead Asylum, Asylum Demon Door 11810112", Description = "Doors")]
      NorthernUndeadAsylumAsylumDemonDoor = 11810112,

      [AnnotationAttribute(Name = "Northern Undead Asylum, Big Pilgrim Door 11810110", Description = "Doors")]
      NorthernUndeadAsylumBigPilgrimDoor = 11810110,

      [AnnotationAttribute(Name = "Anor Londo, Elevator Active 11510220", Description = "Elevators")]
      AnorLondoElevatorActive = 11510220,

      [AnnotationAttribute(Name = "Catacombs, Entrance Lever 11300900", Description = "Levers")]
      CatacombsEntranceLever = 11300900,

      [AnnotationAttribute(Name = "Duke's Archives, First Lever 11705091", Description = "Levers")]
      DukesArchivesFirstLever = 11705091,

      [AnnotationAttribute(Name = "Duke's Archives, Second Lever 11705090", Description = "Levers")]
      DukesArchivesSecondLever = 11705090,

      [AnnotationAttribute(Name = "New Londo Ruins, Seal Opened 11600200", Description = "Levers")]
      NewLondoRuinsSealOpened = 11600200,

      [AnnotationAttribute(Name = "NPC, Andre, Talk To For First Time 71010000", Description = "NPC")]
      NPCAndreTalkToForFirstTime = 71010000,

      [AnnotationAttribute(Name = "NPC, Blacksmith Giant, Talk To For First Time 71510000", Description = "NPC")]
      NPCBlacksmithGiantTalkToForFirstTime = 71510000,

      [AnnotationAttribute(Name = "NPC, Crestfallen Merchant, Talk To For First Time 71500001", Description = "NPC")]
      NPCCrestfallenMerchantTalkToForFirstTime = 71500001,

      [AnnotationAttribute(Name = "NPC, Dusk, Rescued From Golem 1121", Description = "NPC")]
      NPCDuskRescuedFromGolem = 1121,

      [AnnotationAttribute(Name = "NPC, Dusk, Available for Summon (Said Yes After Rescue) 1122", Description = "NPC")]
      NPCDuskAvailableForSummonSaidYesAfterRescue = 1122,

      [AnnotationAttribute(Name = "NPC, Dusk, Dead 1125", Description = "NPC")]
      NPCDuskDead = 1125,

      [AnnotationAttribute(Name = "NPC, Lautrec, Dead 1575", Description = "NPC")]
      NPCLautrecDead = 1575,

      [AnnotationAttribute(Name = "NPC, Oswald, Dead 1702", Description = "NPC")]
      NPCOswaldDead = 1702,

      [AnnotationAttribute(Name = "NPC, Siegmeyer, Dead 1513", Description = "NPC")]
      NPCSiegmeyerDead = 1513,

      [AnnotationAttribute(Name = "NPC, Shiva Bodyguard, Dead 1764", Description = "NPC")]
      NPCShivaBodyguardDead = 1764,

      [AnnotationAttribute(Name = "Covenant Joined, Way of White 851", Description = "Join Covenants")]
      CovenantJoinedWayOfWhite = 851,

      [AnnotationAttribute(Name = "Covenant Joined, Princess Guard 852", Description = "Join Covenants")]
      CovenantJoinedPrincessGuard = 852,

      [AnnotationAttribute(Name = "Covenant Joined, Warrior of Sunlight 853", Description = "Join Covenants")]
      CovenantJoinedWarriorOfSunlight = 853,

      [AnnotationAttribute(Name = "Covenant Joined, Darkwraith 854", Description = "Join Covenants")]
      CovenantJoinedDarkwraith = 854,

      [AnnotationAttribute(Name = "Covenant Joined, Path of the Dragon 855", Description = "Join Covenants")]
      CovenantJoinedPathOfTheDragon = 855,

      [AnnotationAttribute(Name = "Covenant Joined, Gravelord Servant 856", Description = "Join Covenants")]
      CovenantJoinedGravelordServant = 856,

      [AnnotationAttribute(Name = "Covenant Joined, Forest Hunter 857", Description = "Join Covenants")]
      CovenantJoinedForestHunter = 857,

      [AnnotationAttribute(Name = "Covenant Joined, Darkmoon Blade 858", Description = "Join Covenants")]
      CovenantJoinedDarkmoonBlade = 858,

      [AnnotationAttribute(Name = "Covenant Joined, Chaos Servant 859", Description = "Join Covenants")]
      CovenantJoinedChaosServant = 859,

      [AnnotationAttribute(Name = "Anor Londo, Fog Gate Rafters 11510090", Description = "Non-Boss Fog Gates")]
      AnorLondoFogGateRafters = 11510090,

      [AnnotationAttribute(Name = "Anor Londo, Fog Gate Archers 11510091", Description = "Non-Boss Fog Gates")]
      AnorLondoFogGateArchers = 11510091,

      [AnnotationAttribute(Name = "Duke's Archives, Fog Gate 11700083", Description = "Non-Boss Fog Gates")]
      DukesArchivesFogGate = 11700083,

      [AnnotationAttribute(Name = "Northern Undead Asylum, Fog Gate 11810090", Description = "Non-Boss Fog Gates")]
      NorthernUndeadAsylumFogGate = 11810090,

      [AnnotationAttribute(Name = "Sen's Fortress, Fog Gate 1 11500090", Description = "Non-Boss Fog Gates")]
      SensFortressFogGate1 = 11500090,

      [AnnotationAttribute(Name = "Sen's Fortress, Fog Gate 2 11500091", Description = "Non-Boss Fog Gates")]
      SensFortressFogGate2 = 11500091,

      [AnnotationAttribute(Name = "Cutscene Skipped, Ornstein and Smough 11515394", Description = "Boss Fight")]
      CutsceneSkippedOrnsteinAndSmough = 11515394,

      [AnnotationAttribute(Name = "Cutscene Skipped, Centipede Demon 11415382", Description = "Boss Fight")]
      CutsceneSkippedCentipedeDemon = 11415382,

      [AnnotationAttribute(Name = "Cutscene Skipped, Chaos Witch Quelaag 11405394", Description = "Boss Fight")]
      CutsceneSkippedChaosWitchQuelaag = 11405394,

      [AnnotationAttribute(Name = "Cutscene Skipped, Seath 11705394", Description = "Boss Fight")]
      CutsceneSkippedSeath = 11705394,

      [AnnotationAttribute(Name = "Boss Arena Entered, Bed of Chaos 11415390", Description = "Boss Fight")]
      BossArenaEnteredBedOfChaos = 11415390,

      [AnnotationAttribute(Name = "Boss Arena Entered, Gravelord Nito 11315390", Description = "Boss Fight")]
      BossArenaEnteredGravelordNito = 11315390,

      [AnnotationAttribute(Name = "Boss Arena Entered, Gwyn 11805394", Description = "Boss Fight")]
      BossArenaEnteredGwyn = 11805394,

      [AnnotationAttribute(Name = "Boss Arena Entered, Iron Golem 11505394", Description = "Boss Fight")]
      BossArenaEnteredIronGolem = 11505394,

      [AnnotationAttribute(Name = "Cutscene Skipped, Warp to Anor Londo 1511962", Description = "Other")]
      CutsceneSkippedWarpToAnorLondo = 1511962,

      [AnnotationAttribute(Name = "Goughless Kalameeth Death Animation 11210063", Description = "Other")]
      GoughlessKalameethDeathAnimation = 11210063,
    }

}
