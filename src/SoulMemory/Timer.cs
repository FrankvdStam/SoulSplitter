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

namespace SoulMemory
{
    public delegate void UpdateTimeEventHandler(object? sender, int milliseconds);

    public class TimerSettings
    {
        public bool AutoStart { get; set; }
        public bool OverwriteIgtOnStart { get; set; }
    }

    public class Timer
    {
        public Timer(IGame game, TimerSettings timerSettings)
        {
            _game = game;
            _timerSettings = timerSettings;
        }

        private readonly IGame _game;
        private readonly TimerSettings _timerSettings;
        private bool _isRunning;
        private int _previousIgt;

        public event EventHandler? OnAutoStart;
        public event EventHandler? OnRequestSplit;
        public event UpdateTimeEventHandler? OnUpdateTime;

        public void RequestSplit()
        {
            OnRequestSplit?.Invoke(this, null);
        }

        /// <summary>
        /// Manually start the timer. Overwrites IGT to 0 if required by settings
        /// </summary>
        public void Start()
        {
            _isRunning = true;
            if (_timerSettings.OverwriteIgtOnStart && _game is IBlackscreenRemovable blackscreenRemovable)
            {
                blackscreenRemovable.WriteInGameTimeMilliseconds(0);
            }
        }

        /// <summary>
        /// Reset timer state
        /// </summary>
        public void Reset()
        {
            _isRunning = false;
            _previousIgt = 0;
            OnUpdateTime?.Invoke(this, 0);
        }

        /// <summary>
        /// Update the timer, should be called every frame
        /// Handles auto start and blackscreen removal
        /// </summary>
        public void Update()
        {
            var igt = _game.GetInGameTimeMilliseconds();
            if (!_isRunning && 
                _timerSettings.AutoStart &&
                igt is > 0 and < 150)
            {
                _isRunning = true;
                OnAutoStart?.Invoke(this, null);
            }

            if (_isRunning)
            {
                if (
                    _game is IBlackscreenRemovable blackscreenRemovable && 
                    blackscreenRemovable.IsBlackscreenActive() &&
                    igt != 0 &&                                             //Igt timer has starter
                    igt > _previousIgt &&                                   //Igt has increased since previous frame
                    igt < _previousIgt + 1000)                              //Igt has not increased by more than 1 second
                {
                    //During blackscreen, overwrite the incremented timer value with the last known good IGT value. Don't invoke UpdateTime event.
                    blackscreenRemovable.WriteInGameTimeMilliseconds(_previousIgt);
                }
                
                _previousIgt = igt;
                OnUpdateTime?.Invoke(this, igt);
            }
        }
    }
}
