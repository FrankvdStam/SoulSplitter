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
using SoulMemory;
using SoulMemory.DarkSouls1;
using SoulSplitter.Splitters;
using SoulSplitter.UI;
using SoulSplitter.UI.Generic;
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace SoulSplitter.Tests.Splitters
{
    [TestClass]
    public class SplitterTests
    {
        
        private (Mock<ITimerModel> timerModel, MainViewModel mainViewModel, Mock<IDarkSouls1> DarkSouls1, DarkSouls1Splitter DarkSouls1Splitter) CreateMock()
        {
            //Setup a timerModel mock. It needs an internal LiveSplitState object, which has no interface and cannot be mocked easily unfortunately.
            var timerModel = new Mock<ITimerModel>();

            timerModel.Setup(t => t.Start()).Raises(t => t.OnStart += null, EventArgs.Empty);
            timerModel.Setup(t => t.Reset())
                .Raises(t => t.OnReset += null, this, TimerPhase.NotRunning);
            
            var liveSplitStateMock = new Mock<LiveSplitState>(args: [null!, null!, null!, null!, null!]);
            timerModel.Setup(i => i.CurrentState).Returns(liveSplitStateMock.Object);
            liveSplitStateMock.Object.RegisterTimerModel(timerModel.Object);

            //Setup a viewmodel
            var mainViewModel = new MainViewModel();

            //Mock the memory reading object
            var darkSouls1 = new Mock<IDarkSouls1>();
            darkSouls1.Setup(i => i.TryRefresh()).Returns(Result.Ok());

            //Finally create the splitter with all its dependencies
            var ds1Splitter = new DarkSouls1Splitter(timerModel.Object, darkSouls1.Object, mainViewModel);
            return (timerModel, mainViewModel, darkSouls1, ds1Splitter);
        }

        [DataTestMethod]
        [DataRow(true, true)]
        [DataRow(true, false)]
        [DataRow(false, true)]
        [DataRow(false, false)]
        public void AutoStartTests(bool shouldAutoStart, bool shouldResetInventoryIndices)
        {
            var (timerModel, mainViewModel, darkSouls1, ds1Splitter) = CreateMock();

            //Configure UI settings
            mainViewModel.DarkSouls1ViewModel.StartAutomatically = shouldAutoStart;
            mainViewModel.DarkSouls1ViewModel.ResetInventoryIndices = shouldResetInventoryIndices;
            //mainViewModel.DarkSouls1ViewModel.BooleanFlags[0].Value = shouldAutoStart;
            //mainViewModel.DarkSouls1ViewModel.BooleanFlags[1].Value = shouldResetInventoryIndices;
            //Setup mocks
            darkSouls1
                .SetupSequence(i => i.GetInGameTimeMilliseconds())
                .Returns(0)
                .Returns(200)
                .Returns(50);

            //Never start, regardless of settings, when the timer is 0
            ds1Splitter.Update(mainViewModel);
            timerModel.Verify(i => i.Start(), Times.Never);
            darkSouls1.Verify(i => i.ResetInventoryIndices(), Times.Never);

            //Don't start when millis above a certain threshold (existing saves)
            ds1Splitter.Update(mainViewModel);
            timerModel.Verify(i => i.Start(), Times.Never);
            darkSouls1.Verify(i => i.ResetInventoryIndices(), Times.Never);

            //Should start automatically, if requested
            ds1Splitter.Update(mainViewModel);
            if (shouldAutoStart)
            {
                timerModel.Verify(i => i.Start());
            }
            else
            {
                timerModel.Verify(i => i.Start(), Times.Never);
            }
            
            //Indices won't reset when it is requested and autostart is off, because the timer will never start.
            if (shouldAutoStart && shouldResetInventoryIndices)
            {
                darkSouls1.Verify(i => i.ResetInventoryIndices());
            }
            else
            {
                darkSouls1.Verify(i => i.ResetInventoryIndices(), Times.Never);
            }
        }

        [TestMethod]
        public void AutoStartResetAutoStartTest()
        {
            var (timerModel, mainViewModel, darkSouls1, ds1Splitter) = CreateMock();
            mainViewModel.DarkSouls1ViewModel.StartAutomatically = true;

            darkSouls1.Setup(i => i.GetInGameTimeMilliseconds()).Returns(50);

            //Timer should begin stopped.
            timerModel.Verify(i => i.Start(), Times.Never);
       
            ds1Splitter.Update(mainViewModel);//autostart
            timerModel.Verify(i => i.Start(), Times.Exactly(1));

            //Reset
            timerModel.Object.Reset();
            timerModel.Verify(i => i.Reset());

            ds1Splitter.Update(mainViewModel);//autostart
            timerModel.Verify(i => i.Start(), Times.Exactly(2));
        }

        [TestMethod]
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
            darkSouls1.Setup(i => i.GetInGameTimeMilliseconds()).Returns(50);
       
            var splitIndex = 0;
            timerModel.Setup(i => i.Split()).Callback(() =>
            {
                splitIndex++;
            });
       
            darkSouls1.Setup(i => i.IsPlayerLoaded()).Returns(true);
            darkSouls1.Setup(i => i.IsWarpRequested()).Returns(false);
       
            igt = 50;
            ds1Splitter.Update(mainViewModel); //Timer will change internal state, but not let livesplit know about the changed IGT yet on the first frame
            ds1Splitter.Update(mainViewModel); //This 2nd call will update IGT.
            timerModel.Verify(i => i.Start());

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
                        darkSouls1.Setup(d => d.ReadEventFlag((uint)split.Split)).Returns(true);
                        break;
       
                    case SplitType.Flag:
                        darkSouls1.Setup(d => d.ReadEventFlag(((FlagDescription)split.Split).Flag)).Returns(true);
                        break;
       
                    case SplitType.Attribute:
                        darkSouls1.Setup(d => d.GetAttribute(((Splits.DarkSouls1.Attribute)split.Split).AttributeType)).Returns(((Splits.DarkSouls1.Attribute)split.Split).Level);
                        break;
       
                    case SplitType.Bonfire:
                        darkSouls1.Setup(d => d.GetBonfireState(((Splits.DarkSouls1.BonfireState)split.Split).Bonfire!.Value)).Returns(((Splits.DarkSouls1.BonfireState)split.Split).State);
                        break;
       
                    case SplitType.Position:
                        var pos = ((VectorSize)split.Split).Position;
                        darkSouls1.Setup(d => d.GetPosition()).Returns(new SoulMemory.Vector3f(pos.X, pos.Y, pos.Z));
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
                        darkSouls1.Setup(d => d.IsPlayerLoaded()).Returns(false);
                        darkSouls1.Setup(d => d.IsWarpRequested()).Returns(false);

                        ds1Splitter.Update(mainViewModel); //latch quitout

                        darkSouls1.Setup(d => d.IsPlayerLoaded()).Returns(true);
                        darkSouls1.Setup(d => d.IsWarpRequested()).Returns(false);
                        break;
       
                    case TimingType.OnWarp:
                        darkSouls1.Setup(d => d.IsPlayerLoaded()).Returns(false);
                        darkSouls1.Setup(d => d.IsWarpRequested()).Returns(true);

                        ds1Splitter.Update(mainViewModel); //latch warp request
                        ds1Splitter.Update(mainViewModel); //latch player quitout
                        break;
       
                }
       
                //Final assertion: split should have been called once more time
                igt += 1000;
                darkSouls1.Setup(d => d.GetInGameTimeMilliseconds()).Returns(igt);
                ds1Splitter.Update(mainViewModel);
                Assert.AreEqual(i + 1, splitIndex, $"Unexpected index value on split {split.TimingType} {split.SplitType} {split.Split}");
       
                //It seems like GameTime might be updated from somewhere else. The logic inside livesplit is complicated.
                //I noticed that its value (in millis) can be 51.6 after setting it to 50.0
                //If this asserts starts being funny, just get rid of it.
                Assert.AreEqual(igt, timerModel.Object.CurrentState.CurrentTime.GameTime!.Value.TotalMilliseconds);

                darkSouls1.Setup(d => d.GetPosition()).Returns(new SoulMemory.Vector3f());//reset position
            }
        }
    }
}
