using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using SoulMemory;

namespace SoulSplitter.UI
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
        private TimerModel _timerModel;
        private int _inGameTime;
        private TimerState _timerState = TimerState.WaitForStart;

        public Timer(ITimeable timeable, LiveSplitState state)
        {
            _timeable = timeable;

            _liveSplitState = state;
            _liveSplitState.OnStart += OnStart;
            _liveSplitState.OnReset += OnReset;
            _liveSplitState.IsGameTimePaused = true;

            _timerModel = new TimerModel();
            _timerModel.CurrentState = _liveSplitState;
        }

        public void Split()
        {
            _timerModel.Split();
        }

        private void OnStart(object sender, EventArgs e)
        {
            _timerState = TimerState.Running;
            _previousIsInGame = _timeable.IsInGame();
            
            //If the timer is started manually, on a loading screen, IsInGame will return false. Need to pause the timer in that case.
            if (!_previousIsInGame)
            {
                _timerModel.Pause();
            }
        }

        private void OnReset(object sender, TimerPhase timerPhase)
        {
            _timerState = TimerState.WaitForStart;
            _inGameTime = 0;
        }
        

        private TimingMethod _timingMethod;
        private bool _startAutomatically;
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
                    if (_startAutomatically && _timeable.StartAutomatically())
                    {
                        _timerModel.Start();
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

            //Always update IGT, for comparison. Might move this back into its own state later.
            if (_timeable.IsInGame())
            {
                _inGameTime = _timeable.GetInGameTimeMilliseconds();
                _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
            }


            //Always update RTA, for comparison. Might move this back into its own state later.
            var currentIsInGame = _timeable.IsInGame();
            if (_previousIsInGame != currentIsInGame)
            {
                //Calling Pause() when the timer is paused resumes it. Would rather have an explicit Resume().
                //Because there is no explicit resume, calling pause can cause issues.
                //For instance, starting the timer during a loading screen would cause RTA to be counting loading screens instead of time spent in game.
                //Hence we have to check for the timer's state.

                if (currentIsInGame)
                {
                    if (_timerModel.CurrentState.CurrentPhase != TimerPhase.Running)
                    {
                        _timerModel.Pause();
                    }
                }
                else
                {
                    if (_timerModel.CurrentState.CurrentPhase != TimerPhase.Paused)
                    {
                        _timerModel.Pause();
                    }
                }

            }
            _previousIsInGame = currentIsInGame;

            








            switch (_timingMethod)
            {
                //case TimingMethod.Igt:
                //    if (_timeable.IsInGame())
                //    {
                //        _inGameTime = _timeable.GetInGameTimeMilliseconds(); 
                //        _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
                //    }
                //    break;



                //case TimingMethod.RtaWithLoadRemoval:
                //    //Detect a change
                //    var currentIsInGame = _timeable.IsInGame();
                //    if (_previousIsInGame != currentIsInGame)
                //    {
                //        //Calling Pause() when the timer is paused resumes it. Would rather have an explicit Resume().
                //        //Theoretically, there could be an issue here when for whatever reason the IsInGame gets desynced with the timerModel's pause state, and it would only count the time of loading screens..
                //        
                //        if (currentIsInGame)
                //        {
                //            _timerModel.Pause();
                //        }
                //        else
                //        {
                //            _timerModel.Pause();
                //        }
                //
                //    }
                //    _previousIsInGame = currentIsInGame;
                //    break;
            }
        }
    }
}
