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
using System;
using SoulMemory;
using SoulSplitter.UI;
using SoulMemory.DarkSouls2;

namespace SoulSplitter.Splitters;

public abstract class BaseSplitter : ISplitter
{
    public void SetGameObject(object o)
    {
        _game = (IGame)o;
    }

    public object GetGameObject() => _game;

    protected IGame _game;
    protected readonly LiveSplitState _liveSplitState;
    protected readonly TimerModel _timerModel;
    protected MainViewModel _mainViewModel = null!;
    protected int _inGameTime;
    protected TimerState _timerState = TimerState.WaitForStart;


    protected BaseSplitter(LiveSplitState state, IGame game)
    {
        _liveSplitState = state;
        _liveSplitState.OnStart += InternalStart;
        _liveSplitState.OnReset += InternalReset;
        _liveSplitState.IsGameTimePaused = true;
        _game = game;

        _timerModel = new TimerModel();
        _timerModel.CurrentState = state;
    }
    public ResultErr<RefreshError> Update(MainViewModel mainViewModel)
    {
        var refreshResult = _game.TryRefresh();
        if (refreshResult.IsErr)
        {
            return refreshResult;
        }

        _mainViewModel.TryAndHandleError(() => _mainViewModel.FlagTrackerViewModel.Update(_game));
        return OnUpdate();
    }

    public void SetViewModel(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }

    private void InternalStart(object sender, EventArgs e)
    {
        _liveSplitState.IsGameTimePaused = true;
        _timerState = TimerState.Running;
        _inGameTime = _game.GetInGameTimeMilliseconds();
        _mainViewModel.FlagTrackerViewModel.Start();
        _timerModel.Start();
        OnStart();
    }

    private void InternalReset(object sender, TimerPhase timerPhase)
    {
        _timerState = TimerState.WaitForStart;
        _inGameTime = 0;
        _mainViewModel.FlagTrackerViewModel.Reset();
        _timerModel.Reset();
        OnReset();
    }

    #region Disposing

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _liveSplitState.OnStart -= InternalStart;
            _liveSplitState.OnReset -= InternalReset;
        }
    }

    public virtual void OnStart() { }
    public virtual ResultErr<RefreshError> OnUpdate() { return Result.Ok();}
    public virtual void OnReset() { }

    #endregion
}
