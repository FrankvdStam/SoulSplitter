// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2024 Frank van der Stam.
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

namespace SoulMemory.EldenRing;

public enum KnownFlag : uint
{
    [Annotation(Name = "New Game 50")]
    NewGame = 50,

    [Annotation(Name = "New Game +1 51")]
    NewGame1 = 51,

    [Annotation(Name = "New Game +2 52")]
    NewGame2 = 52,

    [Annotation(Name = "New Game +3 53")]
    NewGame3 = 53,

    [Annotation(Name = "New Game +4 54")]
    NewGame4 = 54,

    [Annotation(Name = "New Game +5 55")]
    NewGame5 = 55,

    [Annotation(Name = "New Game +6 56")]
    NewGame6 = 56,

    [Annotation(Name = "New Game +7 57")]
    NewGame7 = 57,

    [Annotation(Name = "New Game +8 58")]
    NewGame8 = 58,

    [Annotation(Name = "Game Starts 100")]
    GameStarts = 100,

    [Annotation(Name = "Reaches Stranded Graveyard 101")]
    ReachesStrandedGraveyard = 101,

    [Annotation(Name = "Reaches Limgrave Open Field 102")]
    ReachesLimgraveOpenField = 102,

    [Annotation(Name = "Reaches Roundtable 105")]
    ReachesRoundtable = 105,

    [Annotation(Name = "Touches the Frenzied Flame 108")]
    TouchestheFrenziedFlame = 108,

    [Annotation(Name = "Burns the Erdtree at Forge of the Giants 110")]
    BurnstheErdtreeatForgeoftheGiants = 110,

    [Annotation(Name = "Saw Ending Scene 120")]
    SawEndingScene = 120,

    [Annotation(Name = "Gets 1st Great Rune 181")]
    Gets1stGreatRune = 181,

    [Annotation(Name = "Gets 2nd Great Rune 182")]
    Gets2ndGreatRune = 182,

    [Annotation(Name = "Gets 3rd Great Rune 183")]
    Gets3rdGreatRune = 183,

    [Annotation(Name = "Gets 4th Great Rune 184")]
    Gets4thGreatRune = 184,

    [Annotation(Name = "Gets 5th Great Rune 185")]
    Gets5thGreatRune = 185,

    [Annotation(Name = "Gets 6th Great Rune 186")]
    Gets6thGreatRune = 186,

    [Annotation(Name = "Gets 7th Great Rune 187")]
    Gets7thGreatRune = 187,

    [Annotation(Name = "Meets Melina 951")]
    MeetsMelina = 951,

    [Annotation(Name = "Saw Ending Scene 2 6010")]
    SawEndingScene2 = 6010,

    [Annotation(Name = "Gets Flasks of Crimson/Cerulean Tears 60000")]
    GetsFlasksofCrimsonCeruleanTears = 60000,

    [Annotation(Name = "Gets Flask of Wondrous Physick 60020")]
    GetsFlaskofWondrousPhysick = 60020,

    [Annotation(Name = "Unlocks Function: Riding Torrent 60100")]
    UnlocksFunctionRidingTorrent = 60100,

    [Annotation(Name = "Unlocks Function: Summoning Spirits 60110")]
    UnlocksFunctionSummoningSpirits = 60110,

    [Annotation(Name = "Unlocks Function: Crafting 60120")]
    UnlocksFunctionCrafting = 60120,

    [Annotation(Name = "Unlocks Function: Applying Ashes of War to Armaments 60130")]
    UnlocksFunctionApplyingAshesofWartoArmaments = 60130,

    [Annotation(Name = "Unlocks Function: Armor Alterations 60140")]
    UnlocksFunctionArmorAlterations = 60140,

    [Annotation(Name = "Unlocks Function: Demigods' Armor Alterations 60150")]
    UnlocksFunctionDemigodsArmorAlterations = 60150,

    [Annotation(Name = "Unlocks Memory Slot 0 60400")]
    UnlocksMemorySlot0 = 60400,

    [Annotation(Name = "Unlocks Memory Slot 1 60410")]
    UnlocksMemorySlot1 = 60410,

    [Annotation(Name = "Unlocks Memory Slot 2 60420")]
    UnlocksMemorySlot2 = 60420,

    [Annotation(Name = "Unlocks Memory Slot 3 60430")]
    UnlocksMemorySlot3 = 60430,

    [Annotation(Name = "Unlocks Memory Slot 4 60440")]
    UnlocksMemorySlot4 = 60440,

    [Annotation(Name = "Unlocks Memory Slot 5 60450")]
    UnlocksMemorySlot5 = 60450,

    [Annotation(Name = "Unlocks Memory Slot 6 60460")]
    UnlocksMemorySlot6 = 60460,

    [Annotation(Name = "Unlocks Memory Slot 7 60470")]
    UnlocksMemorySlot7 = 60470,

    [Annotation(Name = "Unlocks Talisman Slot 0 60500")]
    UnlocksTalismanSlot0 = 60500,

    [Annotation(Name = "Unlocks Talisman Slot 1 60510")]
    UnlocksTalismanSlot1 = 60510,

    [Annotation(Name = "Unlocks Talisman Slot 2 60520")]
    UnlocksTalismanSlot2 = 60520,

    [Annotation(Name = "Unlocks Underground Map 62001")]
    UnlocksUndergroundMap = 62001,

    [Annotation(Name = "Normal Ending A 9400")]
    NormalEndingA = 9400,

    [Annotation(Name = "Normal Ending B 9401")]
    NormalEndingB = 9401,

    [Annotation(Name = "Normal Ending C 9402")]
    NormalEndingC = 9402,

    [Annotation(Name = "Normal Ending D 9403")]
    NormalEndingD = 9403,

    [Annotation(Name = "Ranni Ending A 9404")]
    RanniEndingA = 9404,

    [Annotation(Name = "Ranni Ending B 9405")]
    RanniEndingB = 9405,

    [Annotation(Name = "Frenzied Flame Ending A 9406")]
    FrenziedFlameEndingA = 9406,

    [Annotation(Name = "Frenzied Flame Ending B 9407")]
    FrenziedFlameEndingB = 9407,

    [Annotation(Name = "Radahn Festival: Preparation 9410")]
    RadahnFestivalPreparation = 9410,

    [Annotation(Name = "Radahn Festival: Begins 9411")]
    RadahnFestivalBegins = 9411,

    [Annotation(Name = "Radahn Festival: Aftermath 9412")]
    RadahnFestivalAftermath = 9412,

    [Annotation(Name = "Radahn Festival: Ends 9413")]
    RadahnFestivalEnds = 9413,

    [Annotation(Name = "Frenzied Flame Eyes 9431")]
    FrenziedFlameEyes = 9431,

    [Annotation(Name = "Dragon Eyes 9433")]
    DragonEyes = 9433,

    [Annotation(Name = "Takes Dectus Lift 1038500500")]
    TakesDectusLift = 1038500500,

    [Annotation(Name = "Takes Rold Lift 1050542200")]
    TakeGoldLift = 1050542200,
}