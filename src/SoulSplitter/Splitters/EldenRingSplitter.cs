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
using SoulMemory.EldenRing;
using SoulSplitter.Splits.EldenRing;
using SoulSplitter.UI;
using SoulSplitter.UI.EldenRing;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splitters
{
    internal class EldenRingSplitter : ISplitter
    {
        private readonly EldenRing _eldenRing;
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
            if (_eldenRingViewModel.LockIgtToZero)
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
            _eldenRingViewModel.CurrentPosition.Area   = position.Area  ;
            _eldenRingViewModel.CurrentPosition.Block  = position.Block ;
            _eldenRingViewModel.CurrentPosition.Region = position.Region;
            _eldenRingViewModel.CurrentPosition.Size   = position.Size  ;
            _eldenRingViewModel.CurrentPosition.X      = position.X     ;
            _eldenRingViewModel.CurrentPosition.Y      = position.Y     ;
            _eldenRingViewModel.CurrentPosition.Z      = position.Z     ;
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
            _eldenRing.EnableHud();
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
                        var igt = _eldenRing.GetInGameTimeMilliseconds();
                        if (igt > 0 && igt < 150)
                        {
                            _eldenRing.WriteInGameTimeMilliseconds(0);
                            StartTimer();
                            _timerModel.Start();
                            StartAutoSplitting(_eldenRingViewModel);
                        }
                    }
                    break;

                case TimerState.Running:

                    var currentIgt = _eldenRing.GetInGameTimeMilliseconds();
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

        private List<Split> _splits = new List<Split>();

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
                                if (inventoryItems == null)
                                {
                                    inventoryItems = _eldenRing.ReadInventory();
                                }
                                s.SplitConditionMet = inventoryItems.Any(i => i.Category == s.Item.Category && i.Id == s.Item.Id);
                                break;

                            case EldenRingSplitType.Position:
                                if (
                                    _eldenRingViewModel.CurrentPosition.Area    == s.Position.Area &&
                                    _eldenRingViewModel.CurrentPosition.Block   == s.Position.Block &&
                                    _eldenRingViewModel.CurrentPosition.Region  == s.Position.Region &&
                                    _eldenRingViewModel.CurrentPosition.Size    == s.Position.Size &&

                                    s.Position.X + 5.0f > _eldenRingViewModel.CurrentPosition.X &&
                                    s.Position.X - 5.0f < _eldenRingViewModel.CurrentPosition.X &&

                                    s.Position.Y + 5.0f > _eldenRingViewModel.CurrentPosition.Y &&
                                    s.Position.Y - 5.0f < _eldenRingViewModel.CurrentPosition.Y &&

                                    s.Position.Z + 5.0f > _eldenRingViewModel.CurrentPosition.Z &&
                                    s.Position.Z - 5.0f < _eldenRingViewModel.CurrentPosition.Z)
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
}
