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
using SoulMemory.Games.EldenRing;
using SoulSplitter.Splits.EldenRing;
using SoulSplitter.UiOld;
using SoulSplitter.UiOld.EldenRing;
using SoulSplitter.UiOld.Generic;

namespace SoulSplitter.Splitters;

internal class EldenRingSplitter : ISplitter
{
    public void SetGameObject(object o)
    {
        _eldenRing = (EldenRing)o;
    }

    public object GetGameObject() => _eldenRing;

    private EldenRing _eldenRing;
    private EldenRingViewModel _eldenRingViewModel = null!;
    private readonly LiveSplitState _liveSplitState;
    private MainViewModel _mainViewModel= null!;

    public EldenRingSplitter(LiveSplitState state, EldenRing eldenRing)
    {
        _liveSplitState = state;
        _eldenRing = eldenRing;

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
        //Settings from the UI
        mainViewModel.TryAndHandleError(() =>
        {
            _eldenRingViewModel = mainViewModel.EldenRingViewModel;
        });


        ResultErr<RefreshError>? result = null;
        
        //Refresh attachment to ER process
        mainViewModel.TryAndHandleError(() =>
        {
            result = _eldenRing.TryRefresh();
            if (result.IsErr)
            {
                mainViewModel.AddRefreshError(result.GetErr());
            }
        });

        //Lock IGT to 0 if requested
        if (result!.IsOk && _eldenRingViewModel.LockIgtToZero)
        {
            mainViewModel.TryAndHandleError(() => _eldenRing.WriteInGameTimeMilliseconds(0));
            return Result.Ok();//Don't allow other features to be used while locking the timer
        }

        mainViewModel.TryAndHandleError(() =>
        {
            UpdatePosition();
        });

        mainViewModel.TryAndHandleError(() =>
        {
            UpdateTimer(_eldenRingViewModel.StartAutomatically);
        });

        mainViewModel.TryAndHandleError(() =>
        {
            UpdateAutoSplitter();
        });

        mainViewModel.TryAndHandleError(() =>
        {
            mainViewModel.FlagTrackerViewModel.Update(_eldenRing);
        });

        return result!;
    }


    private void UpdatePosition()
    {
        var position = _eldenRing.GetPosition();
        _eldenRingViewModel.CurrentEldenRingPosition.Position.Area   = position.Area  ;
        _eldenRingViewModel.CurrentEldenRingPosition.Position.Block  = position.Block ;
        _eldenRingViewModel.CurrentEldenRingPosition.Position.Region = position.Region;
        _eldenRingViewModel.CurrentEldenRingPosition.Position.Size   = position.Size  ;
        _eldenRingViewModel.CurrentEldenRingPosition.Position.X      = position.X     ;
        _eldenRingViewModel.CurrentEldenRingPosition.Position.Y      = position.Y     ;
        _eldenRingViewModel.CurrentEldenRingPosition.Position.Z      = position.Z     ;
    }

    //Starting the timer by calling Start(); on a TimerModel object will trigger more than just SoulSplitter's start event.
    //It occurred at least twice that another plugin would throw exceptions during the start event, causing SoulSplitter's start event to never be called at all.
    //That in turn never changed the timer state to running. We can not rely on this event.
    //Thats why autostarting will take care of this and doesn't need the event.
    //However, we still need this event when players start the timer manually.
    private void OnStart(object sender, EventArgs e)
    {
        StartTimer();
        StartAutoSplitting(_eldenRingViewModel);
        _mainViewModel.FlagTrackerViewModel.Start();
    }

    private void OnReset(object sender, TimerPhase timerPhase)
    {
        ResetTimer();
        ResetAutoSplitting();
        _mainViewModel.FlagTrackerViewModel.Reset();
    }

    #region Timer
    private readonly TimerModel _timerModel;
    private int _inGameTime;
    private TimerState _timerState = TimerState.WaitForStart;
    private bool _startAutomatically;

    private void StartTimer()
    {
        _liveSplitState.IsGameTimePaused = true;
        _timerState = TimerState.Running;
        try
        {
            _eldenRing.EnableHud();
        }
        catch{}
    }

    private void ResetTimer()
    {
        _timerState = TimerState.WaitForStart;
        _inGameTime = 0;
    }


    public void UpdateTimer(bool startAutomatically)
    {
        //Allow updates from the UI only when a run isn't in progress
        if (_timerState == TimerState.WaitForStart)
        {
            _startAutomatically = startAutomatically;
        }

        switch (_timerState)
        {
            case TimerState.WaitForStart:
                if (_startAutomatically)
                {
                    var igt = _eldenRing.ReadInGameTimeMilliseconds();
                    if (igt is > 0 and < 150)
                    {
                        _eldenRing.WriteInGameTimeMilliseconds(0);
                        StartTimer();
                        _timerModel.Start();
                        StartAutoSplitting(_eldenRingViewModel);
                    }
                }
                break;

            case TimerState.Running:

                var currentIgt = _eldenRing.ReadInGameTimeMilliseconds();
                var blackscreenActive = _eldenRing.IsBlackscreenActive();


                //Blackscreens/meme loading screens - timer is running, but game is actually loading
                if (currentIgt != 0 && currentIgt > _inGameTime && currentIgt < _inGameTime + 1000 && blackscreenActive)
                {
                    _eldenRing.WriteInGameTimeMilliseconds(_inGameTime);
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

    private List<Split> _splits = [];

    public void ResetAutoSplitting()
    {
        _splits.Clear();
    }

    public void StartAutoSplitting(EldenRingViewModel eldenRingViewModel)
    {
        _splits = (
            from timingType in eldenRingViewModel.Splits
            from splitType in timingType.Children
            from split in splitType.Children
            select new Split(timingType.TimingType, splitType.EldenRingSplitType, split.Split)
            ).ToList();
    }

    public void UpdateAutoSplitter()
    {
        if (_timerState != TimerState.Running)
        {
            return;
        }

        List<Item>? inventoryItems = null;

        foreach (var s in _splits)
        {
            if (!s.SplitTriggered)
            {
                if (!s.SplitConditionMet)
                {
                    switch (s.EldenRingSplitType)
                    {
                        default:
                            throw new ArgumentException($"Unsupported split type {s.EldenRingSplitType}");

                        case EldenRingSplitType.Boss:
                        case EldenRingSplitType.Grace:
                        case EldenRingSplitType.ItemPickup:
                        case EldenRingSplitType.KnownFlag:
                        case EldenRingSplitType.Flag:
                            s.SplitConditionMet = _eldenRing.ReadEventFlag(s.Flag);
                            break;

                        case EldenRingSplitType.Item:
                            //Only get the inventory items once per livesplit tick
                            inventoryItems ??= _eldenRing.ReadInventory();
                            s.SplitConditionMet = inventoryItems.Any(i => i.Category == s.Item.Category && i.Id == s.Item.Id);
                            break;

                        case EldenRingSplitType.Position:
                            if (
                                _eldenRingViewModel.CurrentEldenRingPosition.Position.Area    == s.Position.Area &&
                                _eldenRingViewModel.CurrentEldenRingPosition.Position.Block   == s.Position.Block &&
                                _eldenRingViewModel.CurrentEldenRingPosition.Position.Region  == s.Position.Region &&
                                _eldenRingViewModel.CurrentEldenRingPosition.Position.Size    == s.Position.Size &&

                                s.Position.X + _eldenRingViewModel.CurrentEldenRingPosition.Size > _eldenRingViewModel.CurrentEldenRingPosition.Position.X &&
                                s.Position.X - _eldenRingViewModel.CurrentEldenRingPosition.Size < _eldenRingViewModel.CurrentEldenRingPosition.Position.X &&

                                s.Position.Y + _eldenRingViewModel.CurrentEldenRingPosition.Size > _eldenRingViewModel.CurrentEldenRingPosition.Position.Y &&
                                s.Position.Y - _eldenRingViewModel.CurrentEldenRingPosition.Size < _eldenRingViewModel.CurrentEldenRingPosition.Position.Y &&

                                s.Position.Z + _eldenRingViewModel.CurrentEldenRingPosition.Size > _eldenRingViewModel.CurrentEldenRingPosition.Position.Z &&
                                s.Position.Z - _eldenRingViewModel.CurrentEldenRingPosition.Size < _eldenRingViewModel.CurrentEldenRingPosition.Position.Z)
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
                if (_eldenRing.GetScreenState() == ScreenState.Loading)
                {
                    _timerModel.Split();
                    s.SplitTriggered = true;
                }
                break;

            case TimingType.OnBlackscreen:
                if (_eldenRing.IsBlackscreenActive())
                {
                    _timerModel.Split();
                    s.SplitTriggered = true;
                }
                break;
        }
    }

   
    #endregion
}
