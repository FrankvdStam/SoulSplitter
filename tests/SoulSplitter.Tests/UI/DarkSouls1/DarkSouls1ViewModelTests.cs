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
using SoulSplitter.Splits.DarkSouls1;
using SoulSplitter.UI.DarkSouls1;
using SoulSplitter.UI.Generic;
using System.Collections.Generic;
using System.Linq;

namespace SoulSplitter.Tests.UI.DarkSouls1
{
    [TestFixture]
    public class DarkSouls1ViewModelTests
    {
        private static IEnumerable<TestCaseData> AddSplitTestCases
        {
            get
            {
                yield return new TestCaseData(TimingType.Immediate,  SplitType.Boss,      SoulMemory.DarkSouls1.Boss.AsylumDemon);
                yield return new TestCaseData(TimingType.OnLoading , SplitType.Boss,      SoulMemory.DarkSouls1.Boss.FourKings);
                yield return new TestCaseData(TimingType.OnWarp    , SplitType.Boss,      SoulMemory.DarkSouls1.Boss.GreatGreyWolfSif);
                                                                   
                yield return new TestCaseData(TimingType.OnWarp    , SplitType.Flag,      new FlagDescription { Flag = 248157 });
                                                                   
                yield return new TestCaseData(TimingType.OnLoading , SplitType.Bonfire,   new BonfireState { Bonfire = SoulMemory.DarkSouls1.Bonfire.AnorLondo,  State = SoulMemory.DarkSouls1.BonfireState.Kindled2 });
                yield return new TestCaseData(TimingType.Immediate , SplitType.Bonfire,   new BonfireState { Bonfire = SoulMemory.DarkSouls1.Bonfire.AshLakeDragon,  State = SoulMemory.DarkSouls1.BonfireState.Unlocked });
                                                                   
                yield return new TestCaseData(TimingType.OnLoading , SplitType.Position,  new VectorSize() { Size = 10 });

                yield return new TestCaseData(TimingType.OnWarp    , SplitType.Attribute, new Splits.DarkSouls1.Attribute{ AttributeType = SoulMemory.DarkSouls1.Attribute.Dexterity, Level = 10 });
            }
        }

        [Test, TestCaseSource("AddSplitTestCases")]
        public void AddSplit(TimingType timingType, SplitType splitType, object split)
        {
            var viewModel = new DarkSouls1ViewModel();
            viewModel.NewSplitTimingType = timingType;
            viewModel.NewSplitType = splitType;

            switch(splitType)
            {
                case SplitType.Position:
                    viewModel.Position = (VectorSize)split;
                    break;

                case SplitType.Flag:
                    viewModel.FlagDescription = (FlagDescription)split;
                    break;

                case SplitType.Bonfire:
                    viewModel.NewSplitBonfireState = (BonfireState)split;
                    break;

                default:
                    viewModel.NewSplitValue = split;
                    break;
            }

            viewModel.AddSplitCommand.Execute(null);

            Assert.AreEqual(1, viewModel.SplitsViewModel.Splits.Count);
            Assert.AreEqual(1, viewModel.SplitsViewModel.Splits.First().Children.Count);
            Assert.AreEqual(1, viewModel.SplitsViewModel.Splits.First().Children.First().Children.Count);

            var splitViewModel = viewModel.SplitsViewModel.Splits.First().Children.First().Children.First();
            Assert.AreEqual(split.ToString(), splitViewModel.Split.ToString());
        }

        [Test]
        public void AddMultipleSplits()
        {
            var expectedTimingTypes = new Dictionary<TimingType, int>();
            var expectedSplitTypes = new Dictionary<SplitType, int>();

            var viewModel = new DarkSouls1ViewModel();
            foreach(var testCaseData in AddSplitTestCases)
            {
                var timingType = (TimingType)testCaseData.OriginalArguments[0];
                var splitType = (SplitType)testCaseData.OriginalArguments[1];
                var split = testCaseData.OriginalArguments[2];

                viewModel.NewSplitType = splitType;
                viewModel.NewSplitTimingType = timingType;

                switch (splitType)
                {
                    case SplitType.Position:
                        viewModel.Position = (VectorSize)split;
                        break;

                    case SplitType.Flag:
                        viewModel.FlagDescription = (FlagDescription)split;
                        break;

                    case SplitType.Bonfire:
                        viewModel.NewSplitBonfireState = (BonfireState)split;
                        break;

                    default:
                        viewModel.NewSplitValue = split;
                        break;
                }

                viewModel.AddSplitCommand.Execute(null);

                if (!expectedTimingTypes.ContainsKey(timingType))
                {
                    expectedTimingTypes[timingType] = 0;
                }
                expectedTimingTypes[timingType]++;

                if(!expectedSplitTypes.ContainsKey(splitType))
                {
                    expectedSplitTypes[splitType] = 0;
                }
                expectedSplitTypes[splitType]++;
            }

            var actualTimingTypes = new Dictionary<TimingType, int>();
            var actualSplitTypes = new Dictionary<SplitType, int>();
            foreach(var timingViewModel in viewModel.SplitsViewModel.Splits)
            {
                var timingType = timingViewModel.TimingType;

                foreach(var splitViewModel in timingViewModel.Children)
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

            Assert.AreEqual(expectedTimingTypes.Count, actualTimingTypes.Count);
            Assert.AreEqual(expectedSplitTypes.Count, actualSplitTypes.Count);

            foreach(var expected in expectedTimingTypes)
            {
                Assert.AreEqual(expected.Value, actualTimingTypes[expected.Key]);
            }

            foreach (var expected in expectedSplitTypes)
            {
                Assert.AreEqual(expected.Value, actualSplitTypes[expected.Key]);
            }
        }
    }
}
