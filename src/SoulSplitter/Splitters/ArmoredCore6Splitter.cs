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
using System;
using System.Collections.Generic;
using System.Linq;
using SoulMemory.ArmoredCore6;
using SoulSplitter.Splits.ArmoredCore6;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splitters;

public class ArmoredCore6Splitter(LiveSplitState state, IGame game) : BaseSplitter(state, game)
{
    private readonly ArmoredCore6 _armoredCore6 = (ArmoredCore6)game;

    public override void OnStart()
    {
        //Copy splits on start
        _splits = (
            from timingType in _mainViewModel.ArmoredCore6ViewModel.SplitsViewModel.Splits
            from splitType in timingType.Children
            from split in splitType.Children
            select new Split(timingType.TimingType, splitType.SplitType, split.Split)
        ).ToList();
    }

    public override ResultErr<RefreshError> OnUpdate()
    {
        switch (_timerState)
        {
            case TimerState.Running:
                _mainViewModel.TryAndHandleError(UpdateAutoSplitter);

                var currentIgt = _armoredCore6.GetInGameTimeMilliseconds();
                //Detect game crash or quit out
                if (currentIgt < 1000 && _inGameTime > 1000)
                {
                    _inGameTime += currentIgt;
                    _armoredCore6.WriteInGameTimeMilliseconds(_inGameTime);
                }

                if (currentIgt > _inGameTime)
                {
                    _inGameTime = currentIgt;
                }
                _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
                break;
        }


        return Result.Ok();
    }

    #region Autosplitting

    private List<Split> _splits = [];
    
    private void UpdateAutoSplitter()
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

                        case SplitType.Flag:
                            s.SplitConditionMet = _armoredCore6.ReadEventFlag(s.Flag);
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
                if (_armoredCore6.IsLoadingScreenVisible())
                {
                    _timerModel.Split();
                    s.SplitTriggered = true;
                }
                break;
        }
    }
    #endregion
}
