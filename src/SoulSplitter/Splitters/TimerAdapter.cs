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
using System;

namespace SoulSplitter.Splitters
{
    public interface ITimerAdapter
    {
    }
    /// <summary>
    /// Adapter to connect the soulmemory timer with livesplit's interface
    /// </summary>
    public class TimerAdapter : ITimerAdapter, IDisposable
    {
        public TimerAdapter(LiveSplitState liveSplitState, Timer timer)
        {
            _liveSplitState = liveSplitState;

            _timerModel = new TimerModel();
            _timerModel.CurrentState = _liveSplitState;


            _liveSplitState.OnStart += OnStart;
            _liveSplitState.OnReset += OnReset;

            _timer = timer;
            _timer.OnUpdateTime += OnUpdateTime;
            _timer.OnRequestSplit += OnRequestSplit;

            _liveSplitState.IsGameTimePaused = true;
        }

        private readonly LiveSplitState _liveSplitState;
        private readonly TimerModel _timerModel;
        private readonly Timer _timer;

        private void OnStart(object sender, EventArgs e)
        {
            _timer.Start();
            _timerModel.Start();
        }

        private void OnReset(object sender, TimerPhase timerPhase)
        {
            _timer.Reset();
            _timerModel.Reset();
        }

        private void OnUpdateTime(object? sender, int milliseconds)
        {
            _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(milliseconds));
        }

        private void OnRequestSplit(object sender, EventArgs e)
        {
            _timerModel.Split();
        }

        public void Dispose()
        {
            _liveSplitState.OnStart -= OnStart;
            _liveSplitState.OnReset -= OnReset;
            _timer.OnUpdateTime -= OnUpdateTime;
            _timer.OnRequestSplit -= OnRequestSplit;
        }
    }
}
