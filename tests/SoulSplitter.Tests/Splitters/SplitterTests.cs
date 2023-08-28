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

using LiveSplit.Model;
using Moq;
using NUnit.Framework;
using SoulMemory;
using SoulMemory.DarkSouls1;
using SoulSplitter.Splitters;
using SoulSplitter.UI;
using SoulSplitter.UI.Generic;
using System;
using System.Linq;

namespace SoulSplitter.Tests.Splitters
{
    [TestFixture]
    public class SplitterTests
    {
        private (Mock<ITimerModel> timerModel, MainViewModel mainViewModel, Mock<IDarkSouls1> DarkSouls1, DarkSouls1Splitter DarkSouls1Splitter) CreateMock()
        {
            //Setup a timerModel mock. It needs an internal LiveSplitState object, which has no interface and cannot be mocked easily unfortunately.
            var timerModel = new Mock<ITimerModel>();
            var liveSplitStateMock = new Mock<LiveSplitState>(null, null, null, null, null);

            timerModel.Setup(t => t.CurrentState).Returns(liveSplitStateMock.Object);
            liveSplitStateMock.Object.RegisterTimerModel(timerModel.Object);

            //Setup a viewmodel
            var mainViewModel = new MainViewModel();

            //Mock the memory reading object
            var darkSouls1 = new Mock<IDarkSouls1>();
            darkSouls1.Setup(ds1 => ds1.TryRefresh()).Returns(Result.Ok());

            //Finally create the splitter with all its dependencies
            var ds1Splitter = new DarkSouls1Splitter(timerModel.Object, darkSouls1.Object, mainViewModel);
            return (timerModel, mainViewModel, darkSouls1, ds1Splitter);
        }

        [TestCase(true, true)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(false, false)]
        public void AutoStartTests(bool shouldAutoStart, bool shouldResetInventoryIndices)
        {
            var (timerModel, mainViewModel, darkSouls1, ds1Splitter) = CreateMock();

            //Configure UI settings
            mainViewModel.DarkSouls1ViewModel.StartAutomatically = shouldAutoStart;
            mainViewModel.DarkSouls1ViewModel.ResetInventoryIndices = shouldResetInventoryIndices;
            //mainViewModel.DarkSouls1ViewModel.BooleanFlags[0].Value = shouldAutoStart;
            //mainViewModel.DarkSouls1ViewModel.BooleanFlags[1].Value = shouldResetInventoryIndices;
            //Setup mocks
            var igt = 0;
            darkSouls1.Setup(ds1 => ds1.GetInGameTimeMilliseconds()).Returns(() => { return igt; });

            var resetInventoryIndices = false;
            darkSouls1.Setup(ds1 => ds1.ResetInventoryIndices()).Callback(() =>
            {
                resetInventoryIndices = true;
            });

            var started = false;
            timerModel.Setup(t => t.Start()).Raises(t => t.OnStart += null, new EventArgs());
            timerModel.Object.CurrentState.OnStart += (o, a) =>
            {
                started = true;
            };

            //Never start, regardless of settings, when the timer is 0
            igt = 0;
            ds1Splitter.Update(mainViewModel);
            Assert.IsFalse(started, "Timer should not have started");
            Assert.IsFalse(resetInventoryIndices, "Indices should not have reset");

            //Don't start when millis above a certain treshhold (existing saves)
            igt = 200;
            ds1Splitter.Update(mainViewModel);
            Assert.IsFalse(started, "Timer should not have started");
            Assert.IsFalse(resetInventoryIndices, "Indices should not have reset");

            //Start automatically, if requested
            igt = 50;
            ds1Splitter.Update(mainViewModel);
            Assert.AreEqual(shouldAutoStart, started, "Timer start value not expected");
            //Indices won't reset when it is requested and autostart is off, because the timer will never start.
            if(shouldAutoStart)
            {
                Assert.AreEqual(shouldResetInventoryIndices, resetInventoryIndices, "Indices not behaving as expected");
            }
        }

        [Test]
        public void AutoStartResetAutoStartTest()
        {
            var (timerModel, mainViewModel, darkSouls1, ds1Splitter) = CreateMock();
            mainViewModel.DarkSouls1ViewModel.StartAutomatically = true;

            var igt = 0;
            darkSouls1.Setup(ds1 => ds1.GetInGameTimeMilliseconds()).Returns(() => { return igt; });

            var started = false;
            timerModel.Setup(t => t.Start()).Raises(t => t.OnStart += null, new EventArgs());
            timerModel.Object.OnStart += (o, a) =>
            {
                started = true;
            };

            timerModel.Setup(t => t.Reset()).Raises(t => t.OnReset += null, null, TimerPhase.NotRunning);
            timerModel.Object.OnReset += (o, a) =>
            {
                started = false;
            };

            //Timer should begin stopped.
            Assert.IsFalse(started);

            igt = 50;
            ds1Splitter.Update(mainViewModel);//autostart
            Assert.IsTrue(started);

            //Reset
            timerModel.Object.Reset();
            Assert.IsFalse(started);

            igt = 50;
            ds1Splitter.Update(mainViewModel);//autostart
            Assert.IsTrue(started);
        }


        [Test]
        public void AutoSplitTests()
        {
            var (timerModel, mainViewModel, darkSouls1, ds1Splitter) = CreateMock();
            var testSplits = MockAutoSplitData.TestCases.Where(i => i.GameType == UI.GameType.DarkSouls1).ToList();

            //Configure UI settings
            mainViewModel.DarkSouls1ViewModel.StartAutomatically = true;
            mainViewModel.DarkSouls1ViewModel.ResetInventoryIndices = true;
            //mainViewModel.DarkSouls1ViewModel.BooleanFlags[0].Value = true;
            //mainViewModel.DarkSouls1ViewModel.BooleanFlags[1].Value = true;

            foreach (var split in testSplits)
            {
                split.AddSplit(mainViewModel.DarkSouls1ViewModel, split.TimingType, split.SplitType, split.Split);
            }

            //Setup mocks
            var igt = 0;
            darkSouls1.Setup(ds1 => ds1.GetInGameTimeMilliseconds()).Returns(() => { return igt; });

            var currentPosition = new SoulMemory.Vector3f();
            darkSouls1.Setup(ds1 => ds1.GetPosition()).Returns(() => { return currentPosition; });

            var started = false;
            timerModel.Setup(t => t.Start()).Raises(t => t.OnStart += null, new EventArgs());
            timerModel.Object.OnStart += (o, a) =>
            {
                timerModel.Object.CurrentState.CurrentPhase = TimerPhase.Running;
                started = true;
            };

            var splitIndex = 0;
            timerModel.Setup(t => t.Split()).Callback(() =>
            {
                splitIndex++;
            });

            var playerLoaded = true;
            darkSouls1.Setup(ds1 => ds1.IsPlayerLoaded()).Returns(() => { return playerLoaded; });

            var warpRequested = false;
            darkSouls1.Setup(ds1 => ds1.IsWarpRequested()).Returns(() => { return warpRequested; });

            igt = 50;
            ds1Splitter.Update(mainViewModel); //Timer will change internal state, but not let livesplit know about the changed IGT yet on the first frame
            ds1Splitter.Update(mainViewModel); //This 2nd call will update IGT.
            Assert.IsTrue(started);
            //Assert.AreEqual(igt, timerModel.Object.CurrentState.CurrentTime.GameTime.Value.TotalMilliseconds);

            Assert.AreEqual(0, splitIndex);
            for(int i = 0; i < testSplits.Count; i++)
            {
                var split = testSplits[i];

                //Trigger a split
                switch(split.SplitType)
                {
                    default:
                        throw new Exception();

                    case SplitType.Boss:
                        darkSouls1.Setup(ds1 => ds1.ReadEventFlag((uint)split.Split)).Returns(() => { return true; });
                        break;

                    case SplitType.Flag:
                        darkSouls1.Setup(ds1 => ds1.ReadEventFlag(((FlagDescription)split.Split).Flag)).Returns(() => { return true; });
                        break;

                    case SplitType.Attribute:
                        darkSouls1.Setup(ds1 => ds1.GetAttribute(((Splits.DarkSouls1.Attribute)split.Split).AttributeType)).Returns(() => { return ((Splits.DarkSouls1.Attribute)split.Split).Level; });
                        break;

                    case SplitType.Bonfire:
                        darkSouls1.Setup(ds1 => ds1.GetBonfireState(((Splits.DarkSouls1.BonfireState)split.Split).Bonfire.Value)).Returns(() => { return ((Splits.DarkSouls1.BonfireState)split.Split).State; });
                        break;

                    case SplitType.Position:
                        var pos = ((VectorSize)split.Split).Position;
                        currentPosition = new SoulMemory.Vector3f(pos.X, pos.Y, pos.Z);
                        break;
                }

                //Trigger timing
                switch(split.TimingType)
                {
                    default:
                        throw new Exception();

                    case TimingType.Immediate:
                        break;

                    case TimingType.OnLoading:
                        playerLoaded = false;
                        warpRequested = false;

                        ds1Splitter.Update(mainViewModel); //latch quitout

                        playerLoaded = true;
                        warpRequested = false;
                        break;

                    case TimingType.OnWarp:
                        playerLoaded = false;
                        warpRequested = true;

                        ds1Splitter.Update(mainViewModel); //latch warp request
                        ds1Splitter.Update(mainViewModel); //latch player quitout
                        break;

                }

                //Final assertion: split should have been called once more time
                igt += 1000;
                ds1Splitter.Update(mainViewModel);
                Assert.AreEqual(i + 1, splitIndex, $"Unexpected index value on split {split.TimingType} {split.SplitType} {split.Split}");

                //It seems like GameTime might be updated from somewhere else. The logic inside livesplit is complicated.
                //I noticed that its value (in millis) can be 51.6 after setting it to 50.0
                //If this asserts starts being funny, just get rid of it.
                Assert.AreEqual(igt, timerModel.Object.CurrentState.CurrentTime.GameTime.Value.TotalMilliseconds);

                currentPosition = new SoulMemory.Vector3f();//reset position
            }
        }
    }
}
