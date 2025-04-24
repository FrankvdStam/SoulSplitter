//// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
//// Copyright (c) 2022 Frank van der Stam.
//// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
////
//// This program is free software: you can redistribute it and/or modify
//// it under the terms of the GNU General Public License as published by
//// the Free Software Foundation, version 3.
////
//// This program is distributed in the hope that it will be useful, but
//// WITHOUT ANY WARRANTY without even the implied warranty of
//// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//// General Public License for more details.
////
//// You should have received a copy of the GNU General Public License
//// along with this program. If not, see <http://www.gnu.org/licenses/>.

//using SoulSplitter.UiOld.Generic;
//using System.Collections.Generic;
//using System.Linq;
//using SoulSplitter.UiOld.DarkSouls1;
//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using SoulSplitter.Splits.DarkSouls1;

//namespace SoulSplitter.Tests.UI
//{
//    public enum GameType
//    {
//        DarkSouls1,
//        DarkSouls2,
//        DarkSouls3,
//        Sekiro,
//        EldenRing
//    }

//    [TestClass]
//    public class ViewModelTests
//    {
//        [TestMethod]
//        [DynamicData(nameof(TestCases))]
//        public void AddSplitTest(GameType gameType, AddSplit addSplit, TimingType timingType, SplitType splitType, object split)
//        {
//            BaseViewModel viewModel = gameType switch
//            {
//                GameType.DarkSouls1 => new DarkSouls1ViewModel(),
//                //GameType.DarkSouls3 => new DarkSouls3ViewModel(),
//                //GameType.Sekiro => new SekiroViewModel(),
//                _ => throw new Exception($"unsupported GameType {gameType}")
//            };

//            addSplit(viewModel, timingType, splitType, split);

//            Assert.AreEqual(1, viewModel.SplitsViewModel.Splits.Count);
//            Assert.AreEqual(1, viewModel.SplitsViewModel.Splits.First().Children.Count);
//            Assert.AreEqual(1, viewModel.SplitsViewModel.Splits.First().Children.First().Children.Count);

//            var splitViewModel = viewModel.SplitsViewModel.Splits.First().Children.First().Children.First();
//            Assert.AreEqual(split.ToString(), splitViewModel.Split.ToString());
//        }

//        [TestMethod]
//        public void AddMultipleSplits()
//        {
//            //Split test data into separate lists per game
//            var gameData = new Dictionary<GameType, List<(AddSplit addSplit, TimingType timingType, SplitType splitType, object split)>>();
//            foreach (var objectArray in TestCases)
//            {
//                (var gameType, var addSplit, var timingType, var splitType, var split) = 
//                    ((GameType)objectArray[0], (AddSplit)objectArray[1], (TimingType)objectArray[2], (SplitType)objectArray[3], objectArray[4]);
                
//                if (!gameData.ContainsKey(gameType))
//                {
//                    gameData[gameType] = new List<(AddSplit addSplit, TimingType timingType, SplitType splitType, object split)>();
//                }
//                gameData[gameType].Add((addSplit, timingType, splitType, split));
//            }

//            //Run tests for each gametype
//            foreach(var gameType in gameData)
//            {
//                //Test data specific to this game
//                var testData = gameType.Value;

//                //Keep track of the expected values in the test data
//                var expectedTimingTypes = new Dictionary<TimingType, int>();
//                var expectedSplitTypes = new Dictionary<SplitType, int>();

//                BaseViewModel viewModel = gameType.Key switch
//                {
//                    GameType.DarkSouls1 => new DarkSouls1ViewModel(),
//                    //GameType.DarkSouls3 => new DarkSouls3ViewModel(),
//                    //GameType.Sekiro => new SekiroViewModel(),
//                    _ => throw new Exception($"unsupported GameType {gameType}")
//                };

//                //Add all the splits defined in the testdata to the VM
//                foreach (var testCaseData in testData)
//                {
//                    //Actually adding it
//                    testCaseData.addSplit(viewModel, testCaseData.timingType, testCaseData.splitType, testCaseData.split);

//                    //Count values from test data as it is being added
//                    if (!expectedTimingTypes.ContainsKey(testCaseData.timingType))
//                    {
//                        expectedTimingTypes[testCaseData.timingType] = 0;
//                    }
//                    expectedTimingTypes[testCaseData.timingType]++;

//                    if (!expectedSplitTypes.ContainsKey(testCaseData.splitType))
//                    {
//                        expectedSplitTypes[testCaseData.splitType] = 0;
//                    }
//                    expectedSplitTypes[testCaseData.splitType]++;
//                }

//                //Count the values from the viewmodel after adding it
//                var actualTimingTypes = new Dictionary<TimingType, int>();
//                var actualSplitTypes = new Dictionary<SplitType, int>();
//                foreach (var timingViewModel in viewModel.SplitsViewModel.Splits)
//                {
//                    var timingType = timingViewModel.TimingType;

//                    foreach (var splitViewModel in timingViewModel.Children)
//                    {
//                        var splitType = splitViewModel.SplitType;

//                        if (!actualTimingTypes.ContainsKey(timingType))
//                        {
//                            actualTimingTypes[timingType] = 0;
//                        }
//                        actualTimingTypes[timingType] += splitViewModel.Children.Count;

//                        if (!actualSplitTypes.ContainsKey(splitType))
//                        {
//                            actualSplitTypes[splitType] = 0;
//                        }
//                        actualSplitTypes[splitType] += splitViewModel.Children.Count;
//                    }
//                }

//                //Final assertions
//                Assert.AreEqual(expectedTimingTypes.Count, actualTimingTypes.Count);
//                Assert.AreEqual(expectedSplitTypes.Count, actualSplitTypes.Count);

//                foreach (var expected in expectedTimingTypes)
//                {
//                    Assert.AreEqual(expected.Value, actualTimingTypes[expected.Key]);
//                }

//                foreach (var expected in expectedSplitTypes)
//                {
//                    Assert.AreEqual(expected.Value, actualSplitTypes[expected.Key]);
//                }
//            }
//        }


//        #region Test data

//        private static IEnumerable<object[]> TestCases
//        {
//            get
//            {
//                AddSplit addDarkSouls1Split = AddDarkSouls1Split;
//                //AddSplit addDarkSouls3Split = AddDarkSouls3Split;
//                //AddSplit addSekiroSplit     = AddSekiroSplit;

//                //Dark Souls 1 ====================================================================================================================================================================================
//                yield return new object[] { GameType.DarkSouls1,  addDarkSouls1Split, TimingType.Immediate,  SplitType.Boss,       SoulMemory.Games.DarkSouls1.Boss.AsylumDemon };
//                yield return new object[] { GameType.DarkSouls1,  addDarkSouls1Split, TimingType.OnLoading , SplitType.Boss,       SoulMemory.Games.DarkSouls1.Boss.FourKings };
//                yield return new object[] { GameType.DarkSouls1,  addDarkSouls1Split, TimingType.OnWarp    , SplitType.Boss,       SoulMemory.Games.DarkSouls1.Boss.GreatGreyWolfSif };

//                yield return new object[] { GameType.DarkSouls1,  addDarkSouls1Split, TimingType.OnWarp    , SplitType.Flag,       new FlagDescriptionViewModel { Flag = 248157 } };

//                yield return new object[] { GameType.DarkSouls1,  addDarkSouls1Split, TimingType.OnLoading , SplitType.Bonfire,    new Splits.DarkSouls1.BonfireState { Bonfire = SoulMemory.Games.DarkSouls1.Bonfire.AnorLondo,  State = SoulMemory.Games.DarkSouls1.BonfireState.Kindled2 } };
//                yield return new object[] { GameType.DarkSouls1,  addDarkSouls1Split, TimingType.Immediate , SplitType.Bonfire,    new Splits.DarkSouls1.BonfireState { Bonfire = SoulMemory.Games.DarkSouls1.Bonfire.AshLakeDragon,  State = SoulMemory.Games.DarkSouls1.BonfireState.Unlocked } };

//                yield return new object[] { GameType.DarkSouls1,  addDarkSouls1Split, TimingType.OnLoading , SplitType.Position,   new VectorSize() { Size = 10 } };

//                yield return new object[] { GameType.DarkSouls1,  addDarkSouls1Split, TimingType.OnWarp    , SplitType.Attribute,  new Splits.DarkSouls1.Attribute{ AttributeType = SoulMemory.Games.DarkSouls1.Attribute.Dexterity, Level = 10 } };

//                ////Dark Souls 3 ====================================================================================================================================================================================
//                //yield return new object[] { GameType.DarkSouls3,  addDarkSouls3Split, TimingType.Immediate, SplitType.Boss,        SoulMemory.Games.DarkSouls3.Boss.AbyssWatchers };
//                //yield return new object[] { GameType.DarkSouls3,  addDarkSouls3Split, TimingType.OnLoading, SplitType.Boss,        SoulMemory.Games.DarkSouls3.Boss.IudexGundyr };
//                //yield return new object[] { GameType.DarkSouls3,  addDarkSouls3Split, TimingType.OnLoading, SplitType.Boss,        SoulMemory.Games.DarkSouls3.Boss.SlaveKnightGael };
//                //
//                //yield return new object[] { GameType.DarkSouls3,  addDarkSouls3Split, TimingType.Immediate, SplitType.Flag,        new FlagDescriptionViewModel { Flag = 248157 } };
//                //
//                //yield return new object[] { GameType.DarkSouls3,  addDarkSouls3Split, TimingType.OnLoading, SplitType.Bonfire,     SoulMemory.Games.DarkSouls3.Bonfire.DarkeaterMidir };
//                //yield return new object[] { GameType.DarkSouls3,  addDarkSouls3Split, TimingType.Immediate, SplitType.Bonfire,     SoulMemory.Games.DarkSouls3.Bonfire.FarronKeep };
//                //
//                //yield return new object[] { GameType.DarkSouls3,  addDarkSouls3Split, TimingType.OnLoading, SplitType.Position,    new VectorSize() { Size = 10 } };
//                //
//                //yield return new object[] { GameType.DarkSouls3,  addDarkSouls3Split, TimingType.Immediate, SplitType.Attribute,   new Splits.DarkSouls3.Attribute { AttributeType = SoulMemory.Games.DarkSouls3.Attribute.Dexterity, Level = 10 } };
//                //
//                //yield return new object[] { GameType.DarkSouls3,  addDarkSouls3Split, TimingType.Immediate, SplitType.ItemPickup,  SoulMemory.Games.DarkSouls3.ItemPickup.BlackHandKamuiOnikiriandUbadachi };
//                //
//                //Sekiro ====================================================================================================================================================================================
//             //   yield return new object[] { GameType.Sekiro,      addSekiroSplit,     TimingType.Immediate, SplitType.Boss,        SoulMemory.Games.Sekiro.Boss.EmmaTheGentleBlade };
//             //   yield return new object[] { GameType.Sekiro,      addSekiroSplit,     TimingType.OnLoading, SplitType.Boss,        SoulMemory.Games.Sekiro.Boss.LadyButterfly };
//             //
//             //   yield return new object[] { GameType.Sekiro,      addSekiroSplit,     TimingType.Immediate, SplitType.Bonfire,     SoulMemory.Games.Sekiro.Idol.AshinaCastleFortress };
//             //   yield return new object[] { GameType.Sekiro,      addSekiroSplit,     TimingType.OnLoading, SplitType.Bonfire,     SoulMemory.Games.Sekiro.Idol.AshinaOutskirts };
//             //
//             //   yield return new object[] { GameType.Sekiro,      addSekiroSplit,     TimingType.OnLoading, SplitType.Position,    new VectorSize() { Size = 10 } };
//             //
//             //   yield return new object[] { GameType.Sekiro,      addSekiroSplit,     TimingType.Immediate, SplitType.Flag,        new FlagDescriptionViewModel { Flag = 248157 } };
//            }
//        }

//        #endregion

//        #region Game specific logic
//        public delegate void AddSplit(object viewModel, TimingType timingType, SplitType splitType, object split);

//        private static void AddDarkSouls1Split(object viewModel, TimingType timingType, SplitType splitType, object split)
//        {
//            var darkSouls1ViewModel = (DarkSouls1ViewModel)viewModel;
//            darkSouls1ViewModel.NewSplitTimingType = timingType;
//            darkSouls1ViewModel.NewSplitType = splitType;

//            switch (splitType)
//            {
//                case SplitType.Position:
//                    darkSouls1ViewModel.Position = (VectorSize)split;
//                    break;

//                case SplitType.Flag:
//                    darkSouls1ViewModel.FlagDescriptionViewModel = (FlagDescriptionViewModel)split;
//                    break;

//                case SplitType.Bonfire:
//                    darkSouls1ViewModel.NewSplitBonfireState = (BonfireState)split;
//                    break;

//                default:
//                    darkSouls1ViewModel.NewSplitValue = split;
//                    break;
//            }

//            darkSouls1ViewModel.AddSplitCommand.Execute(null);
//        }

//        //private static void AddDarkSouls3Split(object viewModel, TimingType timingType, SplitType splitType, object split)
//        //{
//        //    var darkSouls3ViewModel = (DarkSouls3ViewModel)viewModel;
//        //    darkSouls3ViewModel.NewSplitTimingType = timingType;
//        //    darkSouls3ViewModel.NewSplitType = splitType;
//        //
//        //    switch (splitType)
//        //    {
//        //        case SplitType.Position:
//        //            darkSouls3ViewModel.Position = (VectorSize)split;
//        //            break;
//        //
//        //        case SplitType.Flag:
//        //            darkSouls3ViewModel.FlagDescriptionViewModel = (FlagDescriptionViewModel)split;
//        //            break;
//        //
//        //        default:
//        //            darkSouls3ViewModel.NewSplitValue = split;
//        //            break;
//        //    }
//        //
//        //    darkSouls3ViewModel.AddSplitCommand.Execute(null);
//        //}

//        //private static void AddSekiroSplit(object viewModel, TimingType timingType, SplitType splitType, object split)
//        //{
//        //    var sekiroViewModel = (SekiroViewModel)viewModel;
//        //    sekiroViewModel.NewSplitTimingType = timingType;
//        //    sekiroViewModel.NewSplitType = splitType;
//        //
//        //    switch(splitType)
//        //    {
//        //        default:
//        //            sekiroViewModel.NewSplitValue = split;
//        //            break;
//        //
//        //        case SplitType.Position:
//        //            sekiroViewModel.Position = (VectorSize)split;
//        //            break;
//        //
//        //        case SplitType.Flag:
//        //            sekiroViewModel.FlagDescriptionViewModel = (FlagDescriptionViewModel)split;
//        //            break;
//        //    }
//        //
//        //    sekiroViewModel.AddSplitCommand.Execute(null);
//        //}
//        //
//        #endregion

//    }
//}
