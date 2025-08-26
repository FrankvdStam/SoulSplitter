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

using SoulSplitter.Abstractions;
using System;
using SoulSplitter.Ui.ViewModels.MainViewModel;
using SoulMemory;
using SoulSplitter.Utils;

namespace SoulSplitter.Livesplit;

public class TimerComponent : ISoulSplitterComponent
{
    private DateTime _lastFailedRefresh = DateTime.MinValue;
    private readonly MainViewModel _mainViewModel;
    private readonly ITimerAdapter? _timerAdapter;

    public TimerComponent(ITimerAdapter timerAdapter, MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
        _timerAdapter = timerAdapter;
    }

    public void Update()
    {        
        try
        {
            //Timeout for 5 sec after a refresh fails
            if (DateTime.Now < _lastFailedRefresh.AddSeconds(5))
            {
                return;
            }

            var result = _timerAdapter!.Update();
            if (result.IsErr)
            {
                //For these error cases it is pointless to try again right away; it will only eat host CPU, hence the timeout.
                if (result.GetErr().Reason is
                    RefreshErrorReason.ProcessNotRunning or
                    RefreshErrorReason.ProcessExited or
                    RefreshErrorReason.ScansFailed or
                    RefreshErrorReason.AccessDenied)
                {
                    _lastFailedRefresh = DateTime.Now;
                }

                _mainViewModel.AddRefreshError(result.GetErr());
            }
        }
        catch (Exception e)
        {
            Logger.Log(e);
            _mainViewModel.AddException(e);
        }
    }
}

