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
using LiveSplit.Model;
using SoulMemory;
using SoulMemory.DarkSouls2;
using SoulSplitter.Splits.DarkSouls2;
using SoulSplitter.UI;
using SoulSplitter.UI.DarkSouls2;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splitters;

public class DarkSouls2Splitter : ISplitter
{
    private readonly DarkSouls2 _darkSouls2;
    private DarkSouls2ViewModel _darkSouls2ViewModel = null!;
    private MainViewModel _mainViewModel = null!;
    private readonly LiveSplitState _liveSplitState;
    
    public DarkSouls2Splitter(LiveSplitState state, DarkSouls2 darkSouls2)
    {
        _darkSouls2 = darkSouls2;
        _liveSplitState = state;
        _liveSplitState.OnStart += OnStart;
        _liveSplitState.OnReset += OnReset;
        _liveSplitState.IsGameTimePaused = true;

        _timerModel = new TimerModel();
        _timerModel.CurrentState = state;
    }

    public void SetViewModel(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }

    #region 

    private void OnStart(object sender, EventArgs e)
    {
        StartTimer();
        StartAutoSplitting();
    }

    private void OnReset(object sender, TimerPhase timerPhase)
    {
        ResetTimer();
        ResetAutoSplitting();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _liveSplitState.OnStart -= OnStart;
            _liveSplitState.OnReset -= OnReset;
        }
    }


    public ResultErr<RefreshError> Update(MainViewModel mainViewModel)
    {
        _darkSouls2ViewModel = mainViewModel.DarkSouls2ViewModel;

        _darkSouls2.TryRefresh();
        
        _darkSouls2ViewModel.CurrentPosition = _darkSouls2.GetPosition();
        
        UpdateTimer();

        UpdateAutoSplitter();

        mainViewModel.TryAndHandleError(() =>
        {
            mainViewModel.FlagTrackerViewModel.Update(_darkSouls2);
        });

        return Result.Ok();
    }
    
    #endregion

    #region Timer

    private bool _previousIsLoading;
    private readonly TimerModel _timerModel;
    private TimerState _timerState = TimerState.WaitForStart;
    
    private void StartTimer()
    {
        _timerState = TimerState.Running;
        _liveSplitState.IsGameTimePaused = false;
        _previousIsLoading = _darkSouls2.IsLoading();
        _timerModel.Start();
    }

    private void ResetTimer()
    {
        _timerState = TimerState.WaitForStart;
        _liveSplitState.IsGameTimePaused = true;
        _timerModel.Reset();
    }

    private void UpdateTimer()
    {
        switch (_timerState)
        {
            case TimerState.WaitForStart:
                if (_darkSouls2ViewModel.StartAutomatically)
                {
                    var loading = _darkSouls2.IsLoading();
                    if (!loading)
                    {
                        var position = _darkSouls2.GetPosition();
                        if(
                            position.Y < -322.0f && position.Y > -323.0f &&
                            position.X < -213.0f && position.X > -214.0f)
                        {
                            _timerModel.Start();
                        }
                    }
                }
                break;

            case TimerState.Running:
                //Pause on loads
                if (_previousIsLoading != _darkSouls2.IsLoading())
                {
                    if (_darkSouls2.IsLoading())
                    {
                        _liveSplitState.IsGameTimePaused = true;
                    }
                    else
                    {
                        _liveSplitState.IsGameTimePaused = false;
                    }
                }
                _previousIsLoading = _darkSouls2.IsLoading();
                break;
        }
    }
    
    #endregion

    #region Autosplitting

    private List<Split> _splits = [];

    public void ResetAutoSplitting()
    {
        _splits.Clear();
    }

    public void StartAutoSplitting()
    {
        _splits = (
            from timingType in _darkSouls2ViewModel.Splits
            from splitType in timingType.Children
            from split in splitType.Children
            select new Split(timingType.TimingType, splitType.SplitType, split.Split)
        ).ToList();
    }


    private const float _boxSize = 5.0f;
    public void UpdateAutoSplitter()
    {
        if (_timerState != TimerState.Running)
        {
            return;
        }
        
        foreach (var s in _splits)
        {
            if (!s.SplitTriggered)
            {
                if (!s.SplitConditionMet)
                {
                    switch (s.SplitType)
                    {
                        default:
                            throw new ArgumentException($"Unsupported split type {s.SplitType}");

                        case DarkSouls2SplitType.Flag:
                            s.SplitConditionMet = _darkSouls2.ReadEventFlag(s.Flag);                                
                            break;

                        case DarkSouls2SplitType.BossKill:
                            s.SplitConditionMet = _darkSouls2.GetBossKillCount(s.BossKill.BossType) == s.BossKill.Count;                                
                            break;

                        case DarkSouls2SplitType.Attribute:
                            s.SplitConditionMet = _darkSouls2.GetAttribute(s.Attribute.AttributeType) >= s.Attribute.Level;                                
                            break;

                        case DarkSouls2SplitType.Position:
                            if (s.Position.X + _boxSize > _darkSouls2ViewModel.CurrentPosition.X &&
                                s.Position.X - _boxSize < _darkSouls2ViewModel.CurrentPosition.X &&

                                s.Position.Y + _boxSize > _darkSouls2ViewModel.CurrentPosition.Y &&
                                s.Position.Y - _boxSize < _darkSouls2ViewModel.CurrentPosition.Y &&

                                s.Position.Z + _boxSize > _darkSouls2ViewModel.CurrentPosition.Z &&
                                s.Position.Z - _boxSize < _darkSouls2ViewModel.CurrentPosition.Z)
                            {
                                s.SplitConditionMet = true;
                            }
                            break;
                    }
                }

                if (s.SplitConditionMet)
                {
                    ResolveSplitTiming(s);
                }
            }
        }
    }

    private void ResolveSplitTiming(Split s)
    {
        switch (s.TimingType)
        {
            default:
                throw new ArgumentException($"Unsupported timing type {s.TimingType}");

            case TimingType.Immediate:
                _timerModel.Split();
                s.SplitTriggered = true;
                break;

            case TimingType.OnLoading:
                if (_darkSouls2.IsLoading())
                {
                    _timerModel.Split();
                    s.SplitTriggered = true;
                }
                break;
        }
    }
    #endregion
    
}
