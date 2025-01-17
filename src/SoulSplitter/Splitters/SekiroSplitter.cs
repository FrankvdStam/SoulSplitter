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
using SoulMemory.Sekiro;
using SoulSplitter.Splits.Sekiro;
using SoulSplitter.UI;
using SoulSplitter.UI.Generic;
using SoulSplitter.UI.Sekiro;

namespace SoulSplitter.Splitters;

public class SekiroSplitter : ISplitter
{
    private readonly Sekiro _sekiro;
    private SekiroViewModel _sekiroViewModel = null!;
    private readonly LiveSplitState _liveSplitState;
    private MainViewModel _mainViewModel = null!;

    public SekiroSplitter(LiveSplitState state, Sekiro sekiro)
    {
        _sekiro = sekiro;
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
        _mainViewModel.FlagTrackerViewModel.Start();
    }

    private void OnReset(object sender, TimerPhase timerPhase)
    {
        ResetTimer();
        ResetAutoSplitting();
        _mainViewModel.FlagTrackerViewModel.Reset();
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

        mainViewModel.TryAndHandleError(() =>
        {
            _sekiroViewModel = mainViewModel.SekiroViewModel;
        });

        var result = _sekiro.TryRefresh();
        if (result.IsErr)
        {
            mainViewModel.AddRefreshError(result.GetErr());
        }

        mainViewModel.TryAndHandleError(() =>
        {
            _sekiroViewModel.CurrentPosition = _sekiro.GetPlayerPosition();
        });

        mainViewModel.TryAndHandleError(() =>
        {
            UpdateTimer();
        });

        mainViewModel.TryAndHandleError(() =>
        {
            UpdateAutoSplitter();
        });

        mainViewModel.TryAndHandleError(() =>
        {
            mainViewModel.FlagTrackerViewModel.Update(_sekiro);
        });

        return result;
    }
    
    #endregion

    #region Timer
    private readonly TimerModel _timerModel;
    private int _inGameTime;
    private TimerState _timerState = TimerState.WaitForStart;
    
    private void StartTimer()
    {
        if (_sekiroViewModel.OverwriteIgtOnStart)
        {
            _sekiro.WriteInGameTimeMilliseconds(0);
        }

        _liveSplitState.IsGameTimePaused = true;
        _timerState = TimerState.Running;
        _inGameTime = _sekiro.GetInGameTimeMilliseconds();
        _timerModel.Start();
    }

    private void ResetTimer()
    {
        _timerState = TimerState.WaitForStart;
        _inGameTime = 0;
        _timerModel.Reset();
    }

    private void UpdateTimer()
    {
        switch (_timerState)
        {
            case TimerState.WaitForStart:
                if (_sekiroViewModel.StartAutomatically)
                {
                    var igt = _sekiro.GetInGameTimeMilliseconds();
                    if (igt > 0 && igt < 150)
                    {
                        StartTimer();
                        _timerModel.Start();
                        StartAutoSplitting();
                    }
                }
                break;

            case TimerState.Running:
                var currentIgt = _sekiro.GetInGameTimeMilliseconds();
                var blackscreenActive = _sekiro.IsBlackscreenActive();



                //Blackscreens/meme loading screens - timer is running, but game is actually loading
                if (currentIgt != 0 && currentIgt > _inGameTime && currentIgt < _inGameTime + 1000 && blackscreenActive)
                {
                    _sekiro.WriteInGameTimeMilliseconds(_inGameTime);
                }
                else
                {
                    if (currentIgt != 0)
                    {
                        _inGameTime = currentIgt;
                    }
                }

                _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
                break;
        }
    }
    
    #endregion

    #region Autosplitting

    private List<Split> _splits = new List<Split>();

    public void ResetAutoSplitting()
    {
        _splits.Clear();
    }

    public void StartAutoSplitting()
    {
        _splits = (
            from timingType in _sekiroViewModel.SplitsViewModel.Splits
            from splitType in timingType.Children
            from split in splitType.Children
            select new Split(timingType.TimingType, splitType.SplitType, split.Split)
        ).ToList();
    }
    
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

                        case SplitType.Boss:
                        case SplitType.Bonfire:
                        case SplitType.Flag:
                            s.SplitConditionMet = _sekiro.ReadEventFlag(s.Flag);
                            break;

                        case SplitType.Position:
                            if (s.Position.Position.X + s.Position.Size > _sekiroViewModel.CurrentPosition.X &&
                                s.Position.Position.X - s.Position.Size < _sekiroViewModel.CurrentPosition.X &&

                                s.Position.Position.Y + s.Position.Size > _sekiroViewModel.CurrentPosition.Y &&
                                s.Position.Position.Y - s.Position.Size < _sekiroViewModel.CurrentPosition.Y &&

                                s.Position.Position.Z + s.Position.Size > _sekiroViewModel.CurrentPosition.Z &&
                                s.Position.Position.Z - s.Position.Size < _sekiroViewModel.CurrentPosition.Z)
                            {
                                s.SplitConditionMet = true;
                            }
                            break;

                        case SplitType.Attribute:
                            var level = _sekiro.GetAttribute(s.Attribute.AttributeType);
                            s.SplitConditionMet = level >= s.Attribute.Level;
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
                if (!_sekiro.IsPlayerLoaded())
                {
                    _timerModel.Split();
                    s.SplitTriggered = true;
                }
                break;
        }
    }
    #endregion
}
