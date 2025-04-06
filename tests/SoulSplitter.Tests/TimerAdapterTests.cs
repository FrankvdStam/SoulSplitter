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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LiveSplit.Model;
using LiveSplit.Options;
using LiveSplit.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulSplitter.Abstractions;
using LayoutSettings = LiveSplit.Options.LayoutSettings;

namespace SoulSplitter.Tests
{
    [TestClass]
    public class TimerAdapterTests
    {
        private LiveSplitState GetLivesplitState()
        {
            var run = new Mock<IRun>();
            var segment = new Segment("segment");
            segment.SegmentHistory.Add(0, Time.Zero);
            segment.SegmentHistory.Add(1, Time.Zero);


            IEnumerator<ISegment> enumerator = (new ISegment[]{ segment }).Cast<ISegment>().GetEnumerator();
            
            run
                .Setup(i => i.GetEnumerator())
                .Returns((new ISegment[] { segment }).Cast<ISegment>().GetEnumerator());

            run
                .Setup(i => i[0])
                .Returns(segment);

            run
                .Setup(i => i.Count)
                .Returns(1);

            run
                .Setup(i => i.AttemptHistory)
                .Returns(new List<Attempt>{});

            run
                .Setup(i => i.CustomComparisons)
                .Returns(Enumerable.Empty<string>().ToList());

            var layout = new Mock<ILayout>();
            var layoutSettings = new LayoutSettings();
            var settings = new Mock<ISettings>();

            var s = new LiveSplitState(run.Object, new Form(), layout.Object, layoutSettings, settings.Object);
            s.CurrentSplitIndex = 0;

            return s;
        }

        [TestMethod]
        public void TimerAdapter_Update_Should_Call_Timer_Update()
        {
            var liveSplitStateMock = new Mock<LiveSplitState>(args: [null!, null!, null!, null!, null!]);
            var timerMock = new Mock<ITimer>();
            var sut = new TimerAdapter(liveSplitStateMock.Object, timerMock.Object);
            sut.Update();
            timerMock.Verify(x => x.Update(), Times.Once);
        }

        [TestMethod]
        public void Live_split_TimerModel_Manual_Start_Should_Start_Timer()
        {
            var liveSplitState = GetLivesplitState();
            var timerMock = new Mock<ITimer>();
            var sut = new TimerAdapter(liveSplitState, timerMock.Object);
            var timerModel = sut.TimerModel;
            
            timerModel.Start();
            timerMock.Verify(x => x.Start(), Times.Once);
        }

        [TestMethod]
        public void Live_split_LiveSplitState_Manual_Reset_Should_Reset_Timer()
        {
            var liveSplitState = GetLivesplitState();
            var timerMock = new Mock<ITimer>();
            var sut = new TimerAdapter(liveSplitState, timerMock.Object);
            var timerModel = sut.TimerModel;
            timerModel.Start();//Timer needs to be in started state in order to be reset-able
            try
            {
                timerModel.Reset(false);
            }
            catch
            {
                //bit of a meme, livesplit will throw a bunch of exceptions because of the mocked state.
            }
            timerMock.Verify(x => x.Reset(), Times.Once);
        }

        [TestMethod]
        public void Timer_OnAutoStart_Should_Start_Live_Split()
        {
            var liveSplitState = GetLivesplitState();
            var timerMock = new Mock<ITimer>();
            
            var sut = new TimerAdapter(liveSplitState, timerMock.Object);
            var timerModel = sut.TimerModel;

            var triggered = false;
            timerModel.OnStart += (s, a) => triggered = true; 
            timerMock.Raise(i => i.OnAutoStart += null, EventArgs.Empty);
            Assert.IsTrue(triggered);
        }

        [TestMethod]
        public void Timer_OnRequestSplit_Should_Trigger_Split()
        {
            var liveSplitState = GetLivesplitState();
            var timerMock = new Mock<ITimer>();

            var sut = new TimerAdapter(liveSplitState, timerMock.Object);
            var timerModel = sut.TimerModel;
            timerModel.Start();

            var triggered = false;
            timerModel.OnSplit += (s, a) => triggered = true;
            timerMock.Raise(i => i.OnRequestSplit += null, EventArgs.Empty);
            Assert.IsTrue(triggered);
        }

        [TestMethod]
        public void Timer_OnUpdateTime_Should_Update_Igt()
        {
            var liveSplitState = GetLivesplitState();
            var timerMock = new Mock<ITimer>();

            var sut = new TimerAdapter(liveSplitState, timerMock.Object);
            var timerModel = sut.TimerModel;
            timerModel.Start();

            timerMock.Raise(i => i.OnUpdateTime += null, null, 1234);
            var time = timerModel.CurrentState.CurrentTime;
            Assert.AreEqual(time.GameTime, TimeSpan.FromMilliseconds(1234));
        }
    }
}
