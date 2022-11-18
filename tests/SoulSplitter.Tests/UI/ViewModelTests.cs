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

using NUnit.Framework;
using SoulSplitter.UI.DarkSouls3;
using SoulSplitter.UI.Generic;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.Windows.Forms.VisualStyles;
using SoulSplitter.UI.DarkSouls1;
using SoulSplitter.UI.Sekiro;
using System;
using static SoulSplitter.Tests.UI.ViewModelTests;

namespace SoulSplitter.Tests.UI
{
    public enum GameType
    {
        DarkSouls1,
        DarkSouls2,
        DarkSouls3,
        Sekiro,
        EldenRing,
    }

    [TestFixture]
    public class ViewModelTests
    {
        [Test, TestCaseSource("TestCases")]
        public void AddSplitTest(GameType gameType, AddSplit addSplit, TimingType timingType, SplitType splitType, object split)
        {
            BaseViewModel viewModel = null;
            switch(gameType)
            {
                case GameType.DarkSouls1:
                    viewModel = new DarkSouls1ViewModel();
                    break;

                case GameType.DarkSouls3:
                    viewModel = new DarkSouls3ViewModel();
                    break;

                case GameType.Sekiro:
                    viewModel = new SekiroViewModel();
                    break;

                default:
                    throw new Exception($"unsupported GameType {gameType}");
            }

            addSplit(viewModel, timingType, splitType, split);

            Assert.AreEqual(1, viewModel.SplitsViewModel.Splits.Count);
            Assert.AreEqual(1, viewModel.SplitsViewModel.Splits.First().Children.Count);
            Assert.AreEqual(1, viewModel.SplitsViewModel.Splits.First().Children.First().Children.Count);

            var splitViewModel = viewModel.SplitsViewModel.Splits.First().Children.First().Children.First();
            Assert.AreEqual(split.ToString(), splitViewModel.Split.ToString());
        }

        [Test]
        public void AddMultipleSplits()
        {
            //Split test data into separate lists per game
            var gameData = new Dictionary<GameType, List<(AddSplit addSplit, TimingType timingType, SplitType splitType, object split)>>();
            foreach (var testCaseData in TestCases)
            {
                var gameType    = (GameType)testCaseData.OriginalArguments[0];
                var addSplit    = (AddSplit)testCaseData.OriginalArguments[1];
                var timingType  = (TimingType)testCaseData.OriginalArguments[2];
                var splitType   = (SplitType)testCaseData.OriginalArguments[3];
                var split       = testCaseData.OriginalArguments[4];

                if (!gameData.ContainsKey(gameType))
                {
                    gameData[gameType] = new List<(AddSplit addSplit, TimingType timingType, SplitType splitType, object split)>();
                }
                gameData[gameType].Add((addSplit, timingType, splitType, split));
            }

            //Run tests for each gametype
            foreach(var gameType in gameData)
            {
                //Test data specific to this game
                var testData = gameType.Value;

                //Keep track of the expected values in the test data
                var expectedTimingTypes = new Dictionary<TimingType, int>();
                var expectedSplitTypes = new Dictionary<SplitType, int>();

                BaseViewModel viewModel = null;
                switch (gameType.Key)
                {
                    case GameType.DarkSouls1:
                        viewModel = new DarkSouls1ViewModel();
                        break;

                    case GameType.DarkSouls3:
                        viewModel = new DarkSouls3ViewModel();
                        break;

                    case GameType.Sekiro:
                        viewModel = new SekiroViewModel();
                        break;

                    default:
                        throw new Exception($"unsupported GameType {gameType}");
                }

                //Add all the splits defined in the testdata to the VM
                foreach (var testCaseData in testData)
                {
                    //Actually adding it
                    testCaseData.addSplit(viewModel, testCaseData.timingType, testCaseData.splitType, testCaseData.split);

                    //Count values from test data as it is being added
                    if (!expectedTimingTypes.ContainsKey(testCaseData.timingType))
                    {
                        expectedTimingTypes[testCaseData.timingType] = 0;
                    }
                    expectedTimingTypes[testCaseData.timingType]++;

                    if (!expectedSplitTypes.ContainsKey(testCaseData.splitType))
                    {
                        expectedSplitTypes[testCaseData.splitType] = 0;
                    }
                    expectedSplitTypes[testCaseData.splitType]++;
                }

                //Count the values from the viewmodel after adding it
                var actualTimingTypes = new Dictionary<TimingType, int>();
                var actualSplitTypes = new Dictionary<SplitType, int>();
                foreach (var timingViewModel in viewModel.SplitsViewModel.Splits)
                {
                    var timingType = timingViewModel.TimingType;

                    foreach (var splitViewModel in timingViewModel.Children)
                    {
                        var splitType = splitViewModel.SplitType;

                        if (!actualTimingTypes.ContainsKey(timingType))
                        {
                            actualTimingTypes[timingType] = 0;
                        }
                        actualTimingTypes[timingType] += splitViewModel.Children.Count;

                        if (!actualSplitTypes.ContainsKey(splitType))
                        {
                            actualSplitTypes[splitType] = 0;
                        }
                        actualSplitTypes[splitType] += splitViewModel.Children.Count;
                    }
                }

                //Final assertions
                Assert.AreEqual(expectedTimingTypes.Count, actualTimingTypes.Count);
                Assert.AreEqual(expectedSplitTypes.Count, actualSplitTypes.Count);

                foreach (var expected in expectedTimingTypes)
                {
                    Assert.AreEqual(expected.Value, actualTimingTypes[expected.Key]);
                }

                foreach (var expected in expectedSplitTypes)
                {
                    Assert.AreEqual(expected.Value, actualSplitTypes[expected.Key]);
                }
            }
        }


        #region Test data

        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                AddSplit addDarkSouls1Split = AddDarkSouls1Split;
                AddSplit addDarkSouls3Split = AddDarkSouls3Split;

                //Dark Souls 1 ====================================================================================================================================================================================
                yield return new TestCaseData(GameType.DarkSouls1, addDarkSouls1Split, TimingType.Immediate,  SplitType.Boss,       SoulMemory.DarkSouls1.Boss.AsylumDemon);
                yield return new TestCaseData(GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnLoading , SplitType.Boss,       SoulMemory.DarkSouls1.Boss.FourKings);
                yield return new TestCaseData(GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnWarp    , SplitType.Boss,       SoulMemory.DarkSouls1.Boss.GreatGreyWolfSif);

                yield return new TestCaseData(GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnWarp    , SplitType.Flag,       new FlagDescription { Flag = 248157 });

                yield return new TestCaseData(GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnLoading , SplitType.Bonfire,    new SoulSplitter.Splits.DarkSouls1.BonfireState { Bonfire = SoulMemory.DarkSouls1.Bonfire.AnorLondo,  State = SoulMemory.DarkSouls1.BonfireState.Kindled2 });
                yield return new TestCaseData(GameType.DarkSouls1, addDarkSouls1Split, TimingType.Immediate , SplitType.Bonfire,    new SoulSplitter.Splits.DarkSouls1.BonfireState { Bonfire = SoulMemory.DarkSouls1.Bonfire.AshLakeDragon,  State = SoulMemory.DarkSouls1.BonfireState.Unlocked });

                yield return new TestCaseData(GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnLoading , SplitType.Position,   new VectorSize() { Size = 10 });

                yield return new TestCaseData(GameType.DarkSouls1, addDarkSouls1Split, TimingType.OnWarp    , SplitType.Attribute,  new Splits.DarkSouls1.Attribute{ AttributeType = SoulMemory.DarkSouls1.Attribute.Dexterity, Level = 10 });

                //Dark Souls 3 ====================================================================================================================================================================================
                yield return new TestCaseData(GameType.DarkSouls3, addDarkSouls3Split, TimingType.Immediate, SplitType.Boss,        SoulMemory.DarkSouls3.Boss.AbyssWatchers);
                yield return new TestCaseData(GameType.DarkSouls3, addDarkSouls3Split, TimingType.OnLoading, SplitType.Boss,        SoulMemory.DarkSouls3.Boss.IudexGundyr);
                yield return new TestCaseData(GameType.DarkSouls3, addDarkSouls3Split, TimingType.OnLoading, SplitType.Boss,        SoulMemory.DarkSouls3.Boss.SlaveKnightGael);

                yield return new TestCaseData(GameType.DarkSouls3, addDarkSouls3Split, TimingType.Immediate, SplitType.Flag,        new FlagDescription { Flag = 248157 });

                yield return new TestCaseData(GameType.DarkSouls3, addDarkSouls3Split, TimingType.OnLoading, SplitType.Bonfire,     SoulMemory.DarkSouls3.Bonfire.DarkeaterMidir);
                yield return new TestCaseData(GameType.DarkSouls3, addDarkSouls3Split, TimingType.Immediate, SplitType.Bonfire,     SoulMemory.DarkSouls3.Bonfire.FarronKeep);

                yield return new TestCaseData(GameType.DarkSouls3, addDarkSouls3Split, TimingType.OnLoading, SplitType.Position,    new VectorSize() { Size = 10 });

                yield return new TestCaseData(GameType.DarkSouls3, addDarkSouls3Split, TimingType.Immediate, SplitType.Attribute,   new Splits.DarkSouls3.Attribute { AttributeType = SoulMemory.DarkSouls3.Attribute.Dexterity, Level = 10 });

                yield return new TestCaseData(GameType.DarkSouls3, addDarkSouls3Split, TimingType.Immediate, SplitType.ItemPickup,  SoulMemory.DarkSouls3.ItemPickup.BlackHandKamuiOnikiriandUbadachi);
            }
        }

        #endregion

        #region Game specific logic
        public delegate void AddSplit(object viewModel, TimingType timingType, SplitType splitType, object split);

        private static void AddDarkSouls1Split(object viewModel, TimingType timingType, SplitType splitType, object split)
        {
            var darkSouls1ViewModel = (SoulSplitter.UI.DarkSouls1.DarkSouls1ViewModel)viewModel;
            darkSouls1ViewModel.NewSplitTimingType = timingType;
            darkSouls1ViewModel.NewSplitType = splitType;

            switch (splitType)
            {
                case SplitType.Position:
                    darkSouls1ViewModel.Position = (VectorSize)split;
                    break;

                case SplitType.Flag:
                    darkSouls1ViewModel.FlagDescription = (FlagDescription)split;
                    break;

                case SplitType.Bonfire:
                    darkSouls1ViewModel.NewSplitBonfireState = (SoulSplitter.Splits.DarkSouls1.BonfireState)split;
                    break;

                default:
                    darkSouls1ViewModel.NewSplitValue = split;
                    break;
            }

            darkSouls1ViewModel.AddSplitCommand.Execute(null);
        }

        private static void AddDarkSouls3Split(object viewModel, TimingType timingType, SplitType splitType, object split)
        {
            var darkSouls3ViewModel = (DarkSouls3ViewModel)viewModel;
            darkSouls3ViewModel.NewSplitTimingType = timingType;
            darkSouls3ViewModel.NewSplitType = splitType;

            switch (splitType)
            {
                case SplitType.Position:
                    darkSouls3ViewModel.Position = (VectorSize)split;
                    break;

                case SplitType.Flag:
                    darkSouls3ViewModel.FlagDescription = (FlagDescription)split;
                    break;

                default:
                    darkSouls3ViewModel.NewSplitValue = split;
                    break;
            }

            darkSouls3ViewModel.AddSplitCommand.Execute(null);
        }

        #endregion

    }
}
