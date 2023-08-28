﻿// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory;
using SoulMemory.ArmoredCore6;
using SoulSplitter.UI;

namespace SoulSplitter.Splitters
{
    abstract class BaseSplitter
    {
        protected readonly IGame _game;
        protected readonly LiveSplitState _liveSplitState;
        protected readonly TimerModel _timerModel;
        protected MainViewModel _mainViewModel;
        protected int _inGameTime;
        protected TimerState _timerState = TimerState.WaitForStart;


        public BaseSplitter(LiveSplitState state, IGame game)
        {
            _liveSplitState = state;
            _liveSplitState.OnStart += InternalStart;
            _liveSplitState.OnReset += InternalReset;
            _liveSplitState.IsGameTimePaused = true;
            _game = game;

            _timerModel = new TimerModel();
            _timerModel.CurrentState = state;
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
        }

        private void InternalReset(object sender, TimerPhase timerPhase)
        {
            _timerState = TimerState.WaitForStart;
            _inGameTime = 0;
            _timerModel.Reset();
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
        public virtual void OnReset() { }

        #endregion
    }
}
