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

using SoulMemory.Abstractions;
using System;
using SoulMemory;
using SoulMemory.Abstractions.Games;
using SoulMemory.Enums;
using SoulSplitter.Abstractions;
using SoulSplitter.Ui.ViewModels;
using SoulSplitter.Ui.ViewModels.MainViewModel;
using SoulSplitter.Utils;

namespace SoulSplitter
{
    public delegate void UpdateTimeEventHandler(object? sender, int milliseconds);

    public class Timer : ITimer
    {
        public Timer(IGame game, MainViewModel mainViewModel)
        {
            _game = game;
            _mainViewModel = mainViewModel;
        }

        private readonly IGame _game;
        private readonly MainViewModel _mainViewModel;
        private bool _isRunning;
        private int _previousIgt;

        public event EventHandler? OnAutoStart;
        public event EventHandler? OnRequestSplit;
        public event UpdateTimeEventHandler? OnUpdateTime;

        private void RequestSplit()
        {
            OnRequestSplit?.Invoke(this, null);
        }

        /// <summary>
        /// Manually start the timer. Overwrites IGT to 0 if required by settings
        /// </summary>
        public void Start()
        {
            _isRunning = true;
            if (_mainViewModel.OverwriteIgtOnStart)
            {
                _game.WriteInGameTimeMilliseconds(0);
            }
            _mainViewModel.Splits.ForEach(i => i.SplitTriggered = false);
            _mainViewModel.Splits.ForEach(i => i.SplitConditionMet = false);
        }

        /// <summary>
        /// Reset timer state
        /// </summary>
        public void Reset()
        {
            if (!_isRunning)
            {
                _isRunning = false;
                _previousIgt = 0;
                OnUpdateTime?.Invoke(this, 0);
            }
        }

        /// <summary>
        /// Update the timer, should be called every frame
        /// Handles auto start and blackscreen removal
        /// </summary>
        public ResultErr<RefreshError> Update()
        {
            var result = _game.TryRefresh();
            if (result.IsErr)
            {
                return result;
            }
            UpdateTimer();
            UpdateAutoSplitter();
            return Result.Ok();
        }

        private void UpdateTimer()
        {
            var igt = _game.ReadInGameTimeMilliseconds();
            if (!_isRunning &&
                _mainViewModel.StartAutomatically &&
                igt is > 0 and < 150)
            {
                _isRunning = true;
                OnAutoStart?.Invoke(this, null);
                _mainViewModel.Splits.ForEach(i => i.SplitTriggered = false);
                _mainViewModel.Splits.ForEach(i => i.SplitConditionMet = false);
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
                    //During blackscreen, overwrite the incremented timer value with the last known good IGT value.
                    _game.WriteInGameTimeMilliseconds(_previousIgt);
                    return; //Don't invoke UpdateTime event during black screen
                }

                //don't update IGT when it's 0 during a quitout
                if (igt != 0)
                {
                    _previousIgt = igt;
                    OnUpdateTime?.Invoke(this, igt);
                }
            }
        }

        private int ResolveNewGameLevel()
        {
            if (_game is IReadNewGameLevel readNewGameLevel)
            {
                return readNewGameLevel.ReadNewGameLevel();
            }
            return 0;
        }

        private void ResolveSplitCondition(SplitViewModel split)
        {
            switch (split.SplitType)
            {
                case SplitType.DarkSouls1Item:
                case SplitType.DarkSouls1Bonfire:
                    throw new ArgumentException($"Unsupported split type {split.SplitType}.");

                case SplitType.Boss:
                case SplitType.Bonfire:
                case SplitType.ItemPickup:
                case SplitType.KnownFlag:
                    var eventFlag = (uint)split.Split;
                    split.SplitConditionMet = _game.ReadEventFlag(eventFlag);
                    break;

                case SplitType.Flag:
                    uint flag = (uint)split.Split;
                    split.SplitConditionMet = _game.ReadEventFlag(flag);
                    break;

                case SplitType.Attribute:
                    if (_game is not IReadAttribute readAttribute)
                    {
                        throw new ArgumentException($"Unsupported split type {split.SplitType}. {_game} does not implement {nameof(IReadAttribute)}");
                    }

                    var attributeViewModel = (AttributeViewModel)split.Split;
                    split.SplitConditionMet = readAttribute.ReadAttribute(attributeViewModel.Attribute) == attributeViewModel.Level; 
                    break;

                case SplitType.Position:
                    if (_game is not IPlayerPosition playerPosition)
                    {
                        throw new ArgumentException($"Unsupported split type {split.SplitType}. {_game} does not implement {nameof(IPlayerPosition)}");
                    }

                    var positionViewModel = (PositionViewModel)split.Split;
                    var position = playerPosition.GetPlayerPosition();
                    if (positionViewModel.Position.X + positionViewModel.Size > position.X &&
                        positionViewModel.Position.X - positionViewModel.Size < position.X &&

                        positionViewModel.Position.Y + positionViewModel.Size > position.Y &&
                        positionViewModel.Position.Y - positionViewModel.Size < position.Y &&

                        positionViewModel.Position.Z + positionViewModel.Size > position.Z &&
                        positionViewModel.Position.Z - positionViewModel.Size < position.Z)
                    {
                        split.SplitConditionMet = true;
                    }
                    break;

                case SplitType.EldenRingPosition:
                    if (_game is not IEldenRing eldenRing)
                    {
                        throw new ArgumentException($"Unsupported split type {split.SplitType}. {_game} does not implement {nameof(IEldenRing)}");
                    }

                    var vm = (EldenRingPositionViewModel)split.Split;
                    var currentPosition = eldenRing.GetPosition();
                    if (
                        vm.Position.Area == currentPosition.Area &&
                        vm.Position.Block == currentPosition.Block &&
                        vm.Position.Region == currentPosition.Region &&
                        vm.Position.Size == currentPosition.Size &&

                        currentPosition.X + vm.Size > vm.Position.X &&
                        currentPosition.X - vm.Size < vm.Position.X &&

                        currentPosition.Y + vm.Size > vm.Position.Y &&
                        currentPosition.Y - vm.Size < vm.Position.Y &&

                        currentPosition.Z + vm.Size > vm.Position.Z &&
                        currentPosition.Z - vm.Size < vm.Position.Z)
                    {
                        split.SplitConditionMet = true;
                    }
                    break;
            }
        }

        private void ResolveSplitTiming(SplitViewModel split)
        {
            switch (split.TimingType)
            {
                case TimingType.Immediate:
                    split.SplitTriggered = true;
                    RequestSplit();
                    break;

                case TimingType.OnLoading:
                    if (_game is ILoading loading)
                    {
                        if (loading.IsLoading())
                        {
                            RequestSplit();
                            split.SplitTriggered = true;
                        }
                        break;
                    }
                    throw new ArgumentException($"Unsupported timing type {split.TimingType}. {_game} does not implement {nameof(ILoading)}");


                case TimingType.OnBlackscreen:
                    if (_game is IBlackscreenRemovable blackscreenRemovable)
                    {
                        if (blackscreenRemovable.IsBlackscreenActive())
                        {
                            split.SplitConditionMet = true;
                            RequestSplit();
                        }
                        break;
                    }
                    throw new ArgumentException($"Unsupported timing type {split.TimingType}. {_game} does not implement {nameof(IBlackscreenRemovable)}");
                     
                case TimingType.OnWarp:
                default:
                    throw new ArgumentException();
            }
        }

        private void UpdateAutoSplitter()
        {
            if (!_isRunning)
            {
                return;
            }

            foreach (var split in _mainViewModel.Splits)
            {
                //Skip splits that are already triggered
                if (split.SplitTriggered)
                {
                    continue;
                }

                //ignore splits that don't match the current ng+ level
                var newGameLevel = ResolveNewGameLevel();
                if (split.NewGamePlusLevel != newGameLevel)
                {
                    continue;
                }

                if (!split.SplitConditionMet)
                {
                    ResolveSplitCondition(split);
                }

                if (split.SplitConditionMet)
                {
                    ResolveSplitTiming(split);
                }
            }
        }
    }
}
