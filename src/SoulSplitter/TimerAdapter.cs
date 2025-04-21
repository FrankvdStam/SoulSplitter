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
using SoulSplitter.Abstractions;
using System;

namespace SoulSplitter;

/// <summary>
/// Adapter to connect the soulmemory timer with livesplit's interface
/// </summary>
public class TimerAdapter : ITimerAdapter
{
    public TimerAdapter(LiveSplitState liveSplitState, ITimer timer)
    {
        _liveSplitState = liveSplitState;

        TimerModel = new TimerModel();
        TimerModel.CurrentState = _liveSplitState;
        
        _liveSplitState.OnStart += OnStart;
        _liveSplitState.OnReset += OnReset;
        

        _timer = timer;
        _timer.OnAutoStart += OnStart;
        _timer.OnUpdateTime += OnUpdateTime;
        _timer.OnRequestSplit += OnRequestSplit;

        _currentSplitIndex = _liveSplitState.CurrentSplitIndex;
    }

    internal readonly TimerModel TimerModel;
    private readonly LiveSplitState _liveSplitState;
    private readonly ITimer _timer;
    private int _currentSplitIndex = 0;

    private void OnStart(object sender, EventArgs e)
    {
        _liveSplitState.IsGameTimePaused = true; //Live split resets this value - have to make sure its paused on every start.
        _timer.Start();
        TimerModel.Start();
    }

    private void OnReset(object sender, TimerPhase timerPhase)
    {
        _timer.Reset();
        TimerModel.Reset();
    }

    private void OnUpdateTime(object? sender, int milliseconds)
    {
        TimerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(milliseconds));
    }

    private void OnRequestSplit(object sender, EventArgs e)
    {
        TimerModel.Split();
    }

    public ResultErr<RefreshError> Update()
    {
        if (_currentSplitIndex != _liveSplitState.CurrentSplitIndex)
        {
            _currentSplitIndex = _liveSplitState.CurrentSplitIndex;
            _timer.SplitIndexChanged(_currentSplitIndex);
        }

        return _timer.Update();
    }

    public void Dispose()
    {
        _liveSplitState.OnStart -= OnStart;
        _liveSplitState.OnReset -= OnReset;
        _timer.OnUpdateTime -= OnUpdateTime;
        _timer.OnRequestSplit -= OnRequestSplit;
    }
}
