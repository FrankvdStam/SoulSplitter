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
using SoulMemory;
using SoulMemory.ArmoredCore6;
using SoulMemory.DarkSouls1;
using SoulMemory.Sekiro;
using SoulSplitter.UI;
using SoulSplitter.UI.Sekiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSplitter.Splitters
{
    internal class ArmoredCore6Splitter : ISplitter
    {
        private readonly ArmoredCore6 _armoredCore6;
        private MainViewModel _mainViewModel;
        private readonly LiveSplitState _liveSplitState;

        public ArmoredCore6Splitter(LiveSplitState state, ArmoredCore6 armoredCore6)
        {
            _armoredCore6 = armoredCore6;
            _liveSplitState = state;
            _liveSplitState.OnStart += OnStart;
            _liveSplitState.OnReset += OnReset;
            _liveSplitState.IsGameTimePaused = true;

            _timerModel = new TimerModel();
            _timerModel.CurrentState = state;
        }

        public ResultErr<RefreshError> Update(MainViewModel mainViewModel)
        {
            var result = _armoredCore6.TryRefresh();
            if (result.IsErr)
            {
                mainViewModel.AddRefreshError(result.GetErr());
            }

            mainViewModel.TryAndHandleError(UpdateTimer);

            mainViewModel.TryAndHandleError(() =>
            {
                mainViewModel.FlagTrackerViewModel.Update(_armoredCore6);
            });

            return result;
        }
        
        public void SetViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        private void OnStart(object sender, EventArgs e)
        {
            StartTimer();
            _mainViewModel.FlagTrackerViewModel.Start();
        }

        private void OnReset(object sender, TimerPhase timerPhase)
        {
            ResetTimer();
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

        #region Timer
        private readonly TimerModel _timerModel;
        private int _inGameTime;
        private TimerState _timerState = TimerState.WaitForStart;

        private void StartTimer()
        {
            _liveSplitState.IsGameTimePaused = true;
            _timerState = TimerState.Running;
            _inGameTime = _armoredCore6.GetInGameTimeMilliseconds();
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
                case TimerState.Running:
                    var currentIgt = _armoredCore6.GetInGameTimeMilliseconds();
                    if (currentIgt > _inGameTime)
                    {
                        _inGameTime = currentIgt;
                    }
                    _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
                    break;

            }
        }

        #endregion
    }
}
