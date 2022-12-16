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
using SoulMemory.DarkSouls3;
using SoulSplitter.Splits.DarkSouls3;
using SoulSplitter.UI;
using SoulSplitter.UI.DarkSouls3;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splitters
{
    public class DarkSouls3Splitter : ISplitter
    {
        private LiveSplitState _liveSplitState;
        private DarkSouls3 _darkSouls3;
        private DarkSouls3ViewModel _darkSouls3ViewModel;

        public DarkSouls3Splitter(LiveSplitState state)
        {
            _darkSouls3 = new DarkSouls3();
            _liveSplitState = state;
            _liveSplitState.OnStart += OnStart;
            _liveSplitState.OnReset += OnReset;
            _liveSplitState.IsGameTimePaused = true;

            _timerModel = new TimerModel();
            _timerModel.CurrentState = state;
        }

        public void Dispose()
        {
            _liveSplitState.OnStart -= OnStart;
            _liveSplitState.OnReset -= OnReset;
        }

        private void OnStart(object sender, EventArgs e)
        {
            StartTimer();
            StartAutoSplitting();
        }

        private void OnReset(object sender, TimerPhase timerPhase)
        {
            ResetTimer();
        }


        public ResultErr<RefreshError> Update(MainViewModel mainViewModel)
        {
            mainViewModel.TryAndHandleError(() =>
            {
                _darkSouls3ViewModel = mainViewModel.DarkSouls3ViewModel;
            });

            var result = _darkSouls3.TryRefresh();
            if (result.IsErr)
            {
                mainViewModel.AddRefreshError(result.GetErr());
            }

            mainViewModel.TryAndHandleError(() =>
            {
                if (_darkSouls3ViewModel.LockIgtToZero)
                {
                    _darkSouls3.WriteInGameTimeMilliseconds(0);
                    return; //Don't allow the timer to run when IGT is locked
                }
            });

            mainViewModel.TryAndHandleError(() =>
            {
                _darkSouls3ViewModel.CurrentPosition = _darkSouls3.GetPosition();
            });

            mainViewModel.TryAndHandleError(() =>
            {
                UpdateTimer();
            });

            mainViewModel.TryAndHandleError(() =>
            {
                UpdateAutoSplitter();
            });

            return result;
        }

        #region Timer
        private void UpdateTimer()
         {
            switch (_timerState)
            {
                case TimerState.WaitForStart:
                    if (_darkSouls3ViewModel.StartAutomatically)
                    {
                        var igt = _darkSouls3.GetInGameTimeMilliseconds();
                        if (igt > 0 && igt < 150)
                        {
                            StartTimer();
                            StartAutoSplitting();
                        }
                    }
                    break;

                case TimerState.Running:
                    var currentIgt = _darkSouls3.GetInGameTimeMilliseconds();
                    var isLoading = _darkSouls3.IsLoading();
                    var blackscreenActive = _darkSouls3.BlackscreenActive();

                    //Trace.WriteLine($"{_inGameTime} {currentIgt} {isLoading} {blackscreenActive}");

                    //Blackscreens/meme loading screens - timer is running, but game is actually loading
                    if (currentIgt != 0 && currentIgt > _inGameTime && currentIgt < _inGameTime + 1000 && (isLoading || blackscreenActive))
                    {
                        //Trace.WriteLine($"Writing IGT: {TimeSpan.FromMilliseconds(_inGameTime)}");
                        _darkSouls3.WriteInGameTimeMilliseconds(_inGameTime);
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

        private void StartTimer()
        {
            _timerState = TimerState.Running;
            _inGameTime = _darkSouls3.GetInGameTimeMilliseconds();
            _liveSplitState.IsGameTimePaused = true;
            _timerModel.Start();
        }

        private void ResetTimer()
        {
            _timerState = TimerState.WaitForStart;
            _inGameTime = 0;
            _timerModel.Reset();
        }

        private readonly TimerModel _timerModel;
        private int _inGameTime;
        private TimerState _timerState = TimerState.WaitForStart;

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
                from timingType in _darkSouls3ViewModel.SplitsViewModel.Splits
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
                                throw new Exception($"Unsupported split type {s.SplitType}");

                            case SplitType.Boss:
                            case SplitType.Bonfire:
                            case SplitType.ItemPickup:
                            case SplitType.Flag:
                                s.SplitConditionMet = _darkSouls3.ReadEventFlag(s.Flag);
                                break;

                            case SplitType.Attribute:
                                var currentLevel = _darkSouls3.ReadAttribute(s.Attribute.AttributeType);
                                s.SplitConditionMet = currentLevel >= s.Attribute.Level;
                                break;

                            case SplitType.Position:
                                if (s.Position.Position.X + s.Position.Size > _darkSouls3ViewModel.CurrentPosition.X &&
                                    s.Position.Position.X - s.Position.Size < _darkSouls3ViewModel.CurrentPosition.X &&
                                    
                                    s.Position.Position.Y + s.Position.Size > _darkSouls3ViewModel.CurrentPosition.Y &&
                                    s.Position.Position.Y - s.Position.Size < _darkSouls3ViewModel.CurrentPosition.Y &&
                                    
                                    s.Position.Position.Z + s.Position.Size > _darkSouls3ViewModel.CurrentPosition.Z &&
                                    s.Position.Position.Z - s.Position.Size < _darkSouls3ViewModel.CurrentPosition.Z)
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
                    throw new Exception($"Unsupported timing type {s.TimingType}");

                case TimingType.Immediate:
                    _timerModel.Split();
                    s.SplitTriggered = true;
                    break;

                case TimingType.OnLoading:
                    if (_darkSouls3.IsLoading())
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
