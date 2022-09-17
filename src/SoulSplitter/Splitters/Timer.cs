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
using System.Diagnostics;
using System.Threading;
using LiveSplit.Model;
using SoulMemory;

namespace SoulSplitter.Splitters
{
    internal enum TimerState
    {
        WaitForStart,
        Running,
        Paused,
    }

    /// <summary>
    /// Abstraction over timing methods
    /// </summary>
    internal class Timer
    {
        private ITimeable _timeable;
        private LiveSplitState _liveSplitState;
        private readonly TimerModel _timerModel;
        private long _inGameTime;
        private TimerState _timerState = TimerState.WaitForStart;
        private readonly Stopwatch _rtaStopwatch = new Stopwatch();

        public Timer(ITimeable timeable, LiveSplitState state)
        {
            _timeable = timeable;

            _liveSplitState = state;
            _liveSplitState.OnStart += OnStart;
            _liveSplitState.OnReset += OnReset;
            _liveSplitState.IsGameTimePaused = true;

            _timerModel = new TimerModel();
            _timerModel.CurrentState = _liveSplitState;

            InitStopwatch();
        }

        private void InitStopwatch()
        {
            try
            {
                //https://www.codeproject.com/Articles/61964/Performance-Tests-Precise-Run-Time-Measurements-wi

                //// Uses the second Core or Processor for the Test
                //Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(2);
                // Prevents "Normal" processes 
                // from interrupting Threads
                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;      
               
                // Prevents "Normal" Threads 
                // from interrupting this thread
                Thread.CurrentThread.Priority = ThreadPriority.Highest;
            }
            catch
            {
                // ignored
            }
        }


        public void Split()
        {
            _timerModel.Split();
        }

        private void OnStart(object sender, EventArgs e)
        {
            //Set the state of the timer to running, but only start the RTA stopwatch if we're in game
            //IGT will automatically stop if we're no in game
            _timerState = TimerState.Running;
            _previousIsInGame = _timeable.IsInGame();
            if (_previousIsInGame)
            {
                _rtaStopwatch.Start();
            }
        }

        private void OnReset(object sender, TimerPhase timerPhase)
        {
            _timerState = TimerState.WaitForStart;
            _inGameTime = 0;
            _timerStarted = false;
            _rtaStopwatch.Reset();
        }
        
        private TimingMethod _timingMethod;
        private bool _startAutomatically;
        private bool _timerStarted;
        public void Update(TimingMethod timingMethod, bool startAutomatically)
        {
            //Allow updates from the UI only when a run isn't in progress
            if (_timerState == TimerState.WaitForStart)
            {
                _startAutomatically = startAutomatically;
                _timingMethod = timingMethod;
            }

            switch (_timerState)
            {
                case TimerState.WaitForStart:
                    if (_startAutomatically)
                    {
                        if (!_timerStarted)
                        {
                            var igt = _timeable.GetInGameTimeMilliseconds();
                            _timerStarted = igt > 0 && igt < 150;
                        }

                        if (_timerStarted && _timeable.InitialLoadRemoval())
                        {
                            _timeable.ResetIgt();
                            _timerModel.Start();
                        }
                    }
                    break;

                case TimerState.Running:
                    UpdateTimer();
                    break;
            }
        }

        private bool _previousIsInGame = false;
        private void UpdateTimer()
        {
            if (_timingMethod == TimingMethod.None)
            {
                return;
            }

            switch (_timingMethod)
            {
                case TimingMethod.Igt:
                    if (_timeable.IsInGame())
                    {
                        _inGameTime = _timeable.GetInGameTimeMilliseconds();
                        //_timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
                    }
                    break;

                case TimingMethod.RtaWithLoadRemoval:
                    var currentIsInGame = _timeable.IsInGame();
                    if (_previousIsInGame != currentIsInGame)
                    {
                        if (currentIsInGame)
                        {
                            _rtaStopwatch.Start();
                        }
                        else
                        {
                            _rtaStopwatch.Stop();
                        }
                    }
                    //_timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_rtaStopwatch.ElapsedMilliseconds));
                    _inGameTime = _rtaStopwatch.ElapsedMilliseconds;
                    _previousIsInGame = currentIsInGame;
                    break;
            }

            _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
        }
    }
}
