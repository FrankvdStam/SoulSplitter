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

namespace SoulMemory.EldenRing
{
    public enum KnownFlag : uint
    {
        [AnnotationAttribute(Name = "New Game 50")]
        NewGame = 50,

        [AnnotationAttribute(Name = "New Game +1 51")]
        NewGame1 = 51,

        [AnnotationAttribute(Name = "New Game +2 52")]
        NewGame2 = 52,

        [AnnotationAttribute(Name = "New Game +3 53")]
        NewGame3 = 53,

        [AnnotationAttribute(Name = "New Game +4 54")]
        NewGame4 = 54,

        [AnnotationAttribute(Name = "New Game +5 55")]
        NewGame5 = 55,

        [AnnotationAttribute(Name = "New Game +6 56")]
        NewGame6 = 56,

        [AnnotationAttribute(Name = "New Game +7 57")]
        NewGame7 = 57,

        [AnnotationAttribute(Name = "New Game +8 58")]
        NewGame8 = 58,

        [AnnotationAttribute(Name = "Game Starts 100")]
        GameStarts = 100,

        [AnnotationAttribute(Name = "Reaches Stranded Graveyard 101")]
        ReachesStrandedGraveyard = 101,

        [AnnotationAttribute(Name = "Reaches Limgrave Open Field 102")]
        ReachesLimgraveOpenField = 102,

        [AnnotationAttribute(Name = "Reaches Roundtable 105")]
        ReachesRoundtable = 105,

        [AnnotationAttribute(Name = "Touches the Frenzied Flame 108")]
        TouchestheFrenziedFlame = 108,

        [AnnotationAttribute(Name = "Burns the Erdtree at Forge of the Giants 110")]
        BurnstheErdtreeatForgeoftheGiants = 110,

        [AnnotationAttribute(Name = "Saw Ending Scene 120")]
        SawEndingScene = 120,

        [AnnotationAttribute(Name = "Gets 1st Great Rune 181")]
        Gets1stGreatRune = 181,

        [AnnotationAttribute(Name = "Gets 2nd Great Rune 182")]
        Gets2ndGreatRune = 182,

        [AnnotationAttribute(Name = "Gets 3rd Great Rune 183")]
        Gets3rdGreatRune = 183,

        [AnnotationAttribute(Name = "Gets 4th Great Rune 184")]
        Gets4thGreatRune = 184,

        [AnnotationAttribute(Name = "Gets 5th Great Rune 185")]
        Gets5thGreatRune = 185,

        [AnnotationAttribute(Name = "Gets 6th Great Rune 186")]
        Gets6thGreatRune = 186,

        [AnnotationAttribute(Name = "Gets 7th Great Rune 187")]
        Gets7thGreatRune = 187,

        [AnnotationAttribute(Name = "Meets Melina 951")]
        MeetsMelina = 951,

        [AnnotationAttribute(Name = "Saw Ending Scene 2 6010")]
        SawEndingScene2 = 6010,

        [AnnotationAttribute(Name = "Gets Flasks of Crimson/Cerulean Tears 60000")]
        GetsFlasksofCrimsonCeruleanTears = 60000,

        [AnnotationAttribute(Name = "Gets Flask of Wondrous Physick 60020")]
        GetsFlaskofWondrousPhysick = 60020,

        [AnnotationAttribute(Name = "Unlocks Function: Riding Torrent 60100")]
        UnlocksFunctionRidingTorrent = 60100,

        [AnnotationAttribute(Name = "Unlocks Function: Summoning Spirits 60110")]
        UnlocksFunctionSummoningSpirits = 60110,

        [AnnotationAttribute(Name = "Unlocks Function: Crafting 60120")]
        UnlocksFunctionCrafting = 60120,

        [AnnotationAttribute(Name = "Unlocks Function: Applying Ashes of War to Armaments 60130")]
        UnlocksFunctionApplyingAshesofWartoArmaments = 60130,

        [AnnotationAttribute(Name = "Unlocks Function: Armor Alterations 60140")]
        UnlocksFunctionArmorAlterations = 60140,

        [AnnotationAttribute(Name = "Unlocks Function: Demigods' Armor Alterations 60150")]
        UnlocksFunctionDemigodsArmorAlterations = 60150,

        [AnnotationAttribute(Name = "Unlocks Memory Slot 0 60400")]
        UnlocksMemorySlot0 = 60400,

        [AnnotationAttribute(Name = "Unlocks Memory Slot 1 60410")]
        UnlocksMemorySlot1 = 60410,

        [AnnotationAttribute(Name = "Unlocks Memory Slot 2 60420")]
        UnlocksMemorySlot2 = 60420,

        [AnnotationAttribute(Name = "Unlocks Memory Slot 3 60430")]
        UnlocksMemorySlot3 = 60430,

        [AnnotationAttribute(Name = "Unlocks Memory Slot 4 60440")]
        UnlocksMemorySlot4 = 60440,

        [AnnotationAttribute(Name = "Unlocks Memory Slot 5 60450")]
        UnlocksMemorySlot5 = 60450,

        [AnnotationAttribute(Name = "Unlocks Memory Slot 6 60460")]
        UnlocksMemorySlot6 = 60460,

        [AnnotationAttribute(Name = "Unlocks Memory Slot 7 60470")]
        UnlocksMemorySlot7 = 60470,

        [AnnotationAttribute(Name = "Unlocks Talisman Slot 0 60500")]
        UnlocksTalismanSlot0 = 60500,

        [AnnotationAttribute(Name = "Unlocks Talisman Slot 1 60510")]
        UnlocksTalismanSlot1 = 60510,

        [AnnotationAttribute(Name = "Unlocks Talisman Slot 2 60520")]
        UnlocksTalismanSlot2 = 60520,

        [AnnotationAttribute(Name = "Unlocks Underground Map 62001")]
        UnlocksUndergroundMap = 62001,

        [AnnotationAttribute(Name = "Normal Ending A 9400")]
        NormalEndingA = 9400,

        [AnnotationAttribute(Name = "Normal Ending B 9401")]
        NormalEndingB = 9401,

        [AnnotationAttribute(Name = "Normal Ending C 9402")]
        NormalEndingC = 9402,

        [AnnotationAttribute(Name = "Normal Ending D 9403")]
        NormalEndingD = 9403,

        [AnnotationAttribute(Name = "Ranni Ending A 9404")]
        RanniEndingA = 9404,

        [AnnotationAttribute(Name = "Ranni Ending B 9405")]
        RanniEndingB = 9405,

        [AnnotationAttribute(Name = "Frenzied Flame Ending A 9406")]
        FrenziedFlameEndingA = 9406,

        [AnnotationAttribute(Name = "Frenzied Flame Ending B 9407")]
        FrenziedFlameEndingB = 9407,

        [AnnotationAttribute(Name = "Radahn Festival: Preparation 9410")]
        RadahnFestivalPreparation = 9410,

        [AnnotationAttribute(Name = "Radahn Festival: Begins 9411")]
        RadahnFestivalBegins = 9411,

        [AnnotationAttribute(Name = "Radahn Festival: Aftermath 9412")]
        RadahnFestivalAftermath = 9412,

        [AnnotationAttribute(Name = "Radahn Festival: Ends 9413")]
        RadahnFestivalEnds = 9413,

        [AnnotationAttribute(Name = "Frenzied Flame Eyes 9431")]
        FrenziedFlameEyes = 9431,

        [AnnotationAttribute(Name = "Dragon Eyes 9433")]
        DragonEyes = 9433,

        [AnnotationAttribute(Name = "Takes Dectus Lift 1038500500")]
        TakesDectusLift = 1038500500,

        [AnnotationAttribute(Name = "Takes Rold Lift 1050542200")]
        TakeGoldLift = 1050542200,
    }
}