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
public enum KnownFlag : uint
{
    [Annotation(Name = "Bell of Awakening, Undead Parish 11010700", Description = "Bells of Awakening")]
    BellOfAwakeningUndeadParish = 11010700,

    [Annotation(Name = "Bell of Awakening, Blighttown 11400200", Description = "Bells of Awakening")]
    BellOfAwakeningBlighttown = 11400200,

    [Annotation(Name = "Lordvessel, Dark Anor Londo 11510400", Description = "Lordvessel")]
    LordvesselDarkAnorLondo = 11510400,

    [Annotation(Name = "Lordvessel, Receive Lordvessel With Gwynevere Still Alive 11510592", Description = "Lordvessel")]
    LordvesselReceiveLordvesselWithGwynevereStillAlive = 11510592,

    [Annotation(Name = "Lordvessel, Receive Lordvessel (Gwynevere Alive or Dead) 50000090", Description = "Lordvessel")]
    LordvesselReceiveLordvesselGwynevereAliveOrDead = 50000090,

    [Annotation(Name = "Anor Londo, Door to Gwynevere 11510110", Description = "Doors")]
    AnorLondoDoorToGwynevere = 11510110,

    [Annotation(Name = "Darkroot Garden, Crest of Artorias Door 61200500", Description = "Doors")]
    DarkrootGardenCrestOfArtoriasDoor = 61200500,

    [Annotation(Name = "Darkroot Garden, Sif Door 61200501", Description = "Doors")]
    DarkrootGardenSifDoor = 61200501,

    [Annotation(Name = "Demon Ruins, Shortcut Door to Lost Izalith 11410340", Description = "Doors")]
    DemonRuinsShortcutDoorToLostIzalith = 11410340,

    [Annotation(Name = "Northern Undead Asylum, Cell Door 11810103", Description = "Doors")]
    NorthernUndeadAsylumCellDoor = 11810103,

    [Annotation(Name = "Northern Undead Asylum, Asylum Demon Door 11810112", Description = "Doors")]
    NorthernUndeadAsylumAsylumDemonDoor = 11810112,

    [Annotation(Name = "Northern Undead Asylum, Big Pilgrim Door 11810110", Description = "Doors")]
    NorthernUndeadAsylumBigPilgrimDoor = 11810110,

    [Annotation(Name = "Anor Londo, Elevator Active 11510220", Description = "Elevators")]
    AnorLondoElevatorActive = 11510220,

    [Annotation(Name = "Catacombs, Entrance Lever 11300900", Description = "Levers")]
    CatacombsEntranceLever = 11300900,

    [Annotation(Name = "Duke's Archives, First Lever 11705091", Description = "Levers")]
    DukesArchivesFirstLever = 11705091,

    [Annotation(Name = "Duke's Archives, Second Lever 11705090", Description = "Levers")]
    DukesArchivesSecondLever = 11705090,

    [Annotation(Name = "New Londo Ruins, Seal Opened 11600200", Description = "Levers")]
    NewLondoRuinsSealOpened = 11600200,

    [Annotation(Name = "NPC, Andre, Talk To For First Time 71010000", Description = "NPC")]
    NPCAndreTalkToForFirstTime = 71010000,

    [Annotation(Name = "NPC, Blacksmith Giant, Talk To For First Time 71510000", Description = "NPC")]
    NPCBlacksmithGiantTalkToForFirstTime = 71510000,

    [Annotation(Name = "NPC, Crestfallen Merchant, Talk To For First Time 71500001", Description = "NPC")]
    NPCCrestfallenMerchantTalkToForFirstTime = 71500001,

    [Annotation(Name = "NPC, Dusk, Rescued From Golem 1121", Description = "NPC")]
    NPCDuskRescuedFromGolem = 1121,

    [Annotation(Name = "NPC, Dusk, Available for Summon (Said Yes After Rescue) 1122", Description = "NPC")]
    NPCDuskAvailableForSummonSaidYesAfterRescue = 1122,

    [Annotation(Name = "NPC, Dusk, Dead 1125", Description = "NPC")]
    NPCDuskDead = 1125,

    [Annotation(Name = "NPC, Lautrec, Dead 1575", Description = "NPC")]
    NPCLautrecDead = 1575,

    [Annotation(Name = "NPC, Oswald, Dead 1702", Description = "NPC")]
    NPCOswaldDead = 1702,

    [Annotation(Name = "NPC, Siegmeyer, Dead 1513", Description = "NPC")]
    NPCSiegmeyerDead = 1513,

    [Annotation(Name = "NPC, Shiva Bodyguard, Dead 1764", Description = "NPC")]
    NPCShivaBodyguardDead = 1764,

    [Annotation(Name = "Covenant Joined, Way of White 851", Description = "Join Covenants")]
    CovenantJoinedWayOfWhite = 851,

    [Annotation(Name = "Covenant Joined, Princess Guard 852", Description = "Join Covenants")]
    CovenantJoinedPrincessGuard = 852,

    [Annotation(Name = "Covenant Joined, Warrior of Sunlight 853", Description = "Join Covenants")]
    CovenantJoinedWarriorOfSunlight = 853,

    [Annotation(Name = "Covenant Joined, Darkwraith 854", Description = "Join Covenants")]
    CovenantJoinedDarkwraith = 854,

    [Annotation(Name = "Covenant Joined, Path of the Dragon 855", Description = "Join Covenants")]
    CovenantJoinedPathOfTheDragon = 855,

    [Annotation(Name = "Covenant Joined, Gravelord Servant 856", Description = "Join Covenants")]
    CovenantJoinedGravelordServant = 856,

    [Annotation(Name = "Covenant Joined, Forest Hunter 857", Description = "Join Covenants")]
    CovenantJoinedForestHunter = 857,

    [Annotation(Name = "Covenant Joined, Darkmoon Blade 858", Description = "Join Covenants")]
    CovenantJoinedDarkmoonBlade = 858,

    [Annotation(Name = "Covenant Joined, Chaos Servant 859", Description = "Join Covenants")]
    CovenantJoinedChaosServant = 859,

    [Annotation(Name = "Anor Londo, Fog Gate Rafters 11510090", Description = "Non-Boss Fog Gates")]
    AnorLondoFogGateRafters = 11510090,

    [Annotation(Name = "Anor Londo, Fog Gate Archers 11510091", Description = "Non-Boss Fog Gates")]
    AnorLondoFogGateArchers = 11510091,

    [Annotation(Name = "Duke's Archives, Fog Gate 11700083", Description = "Non-Boss Fog Gates")]
    DukesArchivesFogGate = 11700083,

    [Annotation(Name = "Northern Undead Asylum, Fog Gate 11810090", Description = "Non-Boss Fog Gates")]
    NorthernUndeadAsylumFogGate = 11810090,

    [Annotation(Name = "Sen's Fortress, Fog Gate 1 11500090", Description = "Non-Boss Fog Gates")]
    SensFortressFogGate1 = 11500090,

    [Annotation(Name = "Sen's Fortress, Fog Gate 2 11500091", Description = "Non-Boss Fog Gates")]
    SensFortressFogGate2 = 11500091,

    [Annotation(Name = "Cutscene Skipped, Ornstein and Smough 11515394", Description = "Boss Fight")]
    CutsceneSkippedOrnsteinAndSmough = 11515394,

    [Annotation(Name = "Cutscene Skipped, Centipede Demon 11415382", Description = "Boss Fight")]
    CutsceneSkippedCentipedeDemon = 11415382,

    [Annotation(Name = "Cutscene Skipped, Chaos Witch Quelaag 11405394", Description = "Boss Fight")]
    CutsceneSkippedChaosWitchQuelaag = 11405394,

    [Annotation(Name = "Cutscene Skipped, Seath 11705394", Description = "Boss Fight")]
    CutsceneSkippedSeath = 11705394,

    [Annotation(Name = "Boss Arena Entered, Bed of Chaos 11415390", Description = "Boss Fight")]
    BossArenaEnteredBedOfChaos = 11415390,

    [Annotation(Name = "Boss Arena Entered, Gravelord Nito 11315390", Description = "Boss Fight")]
    BossArenaEnteredGravelordNito = 11315390,

    [Annotation(Name = "Boss Arena Entered, Gwyn 11805394", Description = "Boss Fight")]
    BossArenaEnteredGwyn = 11805394,

    [Annotation(Name = "Boss Arena Entered, Iron Golem 11505394", Description = "Boss Fight")]
    BossArenaEnteredIronGolem = 11505394,

    [Annotation(Name = "Cutscene Skipped, Warp to Anor Londo 11500210", Description = "Other")]
    CutsceneSkippedWarpToAnorLondo = 11500210,

    [Annotation(Name = "Goughless Kalameeth Death Animation 11210063", Description = "Other")]
    GoughlessKalameethDeathAnimation = 11210063,
}
