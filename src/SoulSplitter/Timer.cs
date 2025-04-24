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
using SoulMemory.Abstractions;
using System.Linq;
using SoulMemory;
using SoulMemory.Abstractions.Games;
using SoulMemory.Enums;
using SoulSplitter.Abstractions;
using SoulSplitter.DependencyInjection;
using SoulSplitter.Ui.ViewModels;
using SoulSplitter.Ui.ViewModels.MainViewModel;
using SoulSplitter.Utils;
using IServiceProvider = SoulSplitter.DependencyInjection.IServiceProvider;

namespace SoulSplitter
{
    public delegate void UpdateTimeEventHandler(object? sender, int milliseconds);

    public class Timer : ITimer
    {
        public Timer(IServiceProvider serviceProvider, MainViewModel mainViewModel)
        {
            _serviceProvider = serviceProvider;
            _game = serviceProvider.GetService<ISekiro>();
            _mainViewModel = mainViewModel;
            mainViewModel.Splits.CollectionChanged += (o, e) => SplitsChanged();
        }

        private readonly IServiceProvider _serviceProvider;
        private readonly MainViewModel _mainViewModel;

        private int _currentSplitIndex = 0;
        private Game? _previousGame;
        private IGame _game;
        private bool _isRunning;
        private int _currentTime;
        private int _previousIgt;

        public event EventHandler? OnAutoStart;
        public event EventHandler? OnRequestSplit;
        public event UpdateTimeEventHandler? OnUpdateTime;
        
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
            _mainViewModel.Splits.ForEach(i =>
            {
                i.IsSplitConditionMet = false;
                i.IsDisabled = false;
            });
        }

        /// <summary>
        /// Reset timer state
        /// </summary>
        public void Reset()
        {
            if (_isRunning)
            {
                _isRunning = false;
                _previousIgt = 0;
                _currentTime = 0;
                _previousGame = null;
                OnUpdateTime?.Invoke(this, 0);
            }
        }

        public void SplitIndexChanged(int newIndex)
        {
            //Undo split. Disable the split to prevent immediate re-trigger of flag splits. 
            //This split will stay disabled during this run
            if (newIndex < _currentSplitIndex)
            {
                _currentSplitIndex = newIndex;
                var split = GetCurrentSplit()!;
                split.IsDisabled = true;
            }
            _currentSplitIndex = newIndex;
        }

        /// <summary>
        /// Update the timer, should be called every frame
        /// Handles auto start and blackscreen removal
        /// </summary>
        public ResultErr<RefreshError> Update()
        {
            UpdateActiveGame();
            var result = _game.TryRefresh();
            if (result.IsErr)
            {
                return result;
            }

            _mainViewModel.TryAndHandleError(() =>
            {
                //if the timer is not running and the selected split is position, populate the UI with
                //a position read from the game. This can't be read from _game since that will be the first split's game
                //instead fetch it from the selected split's game.
                if (!_isRunning && _mainViewModel.SelectedSplitType == SplitType.Position)
                {
                    //_game is bound to the first split or the current active split.
                    var game = GetGame(_mainViewModel.SelectedGame!.Value);
                    //only update if required
                    if (game != _game)
                    {
                        if (game.TryRefresh().IsErr)
                        {
                            return;
                        }
                    }

                    if (game is IPlayerPosition playerPosition)
                    {
                        _mainViewModel.CurrentPosition = playerPosition.GetPlayerPosition();
                    }

                    if (game is IEldenRing eldenRing)
                    {
                        _mainViewModel.CurrentEldenRingPosition = eldenRing.GetPosition();
                    }
                }
            });

            UpdateTimer();
            UpdateAutoSplitter();
            return Result.Ok();
        }
        
        private SplitViewModel? GetCurrentSplit()
        {
            if (_currentSplitIndex < 0 || _currentSplitIndex >= _mainViewModel.Splits.Count)
            {
                _mainViewModel.AddException(new ArgumentException($"CurrentSplitIndex out of bounds. _currentSplitIndex: {_currentSplitIndex} Splits.Count: {_mainViewModel.Splits.Count}"));
                return null;
            }
            return _mainViewModel.Splits[_currentSplitIndex];
        }
        
        private void SplitsChanged()
        {
            //trigger re-initialization of the game by setting this to null.
            //The idea being that we want the game to be equal to the game of the first split
            //this is important for autostart to work
            _previousGame = null;
        }

        private void UpdateActiveGame()
        {
            if (_previousGame == null)
            {
                //Can't select game if there are no splits or game is null
                if (!_mainViewModel.Splits.Any() || _mainViewModel.Splits.First().Game == null)
                {
                    return;
                }
                //Has to be first split for autostart to work
                _previousGame = _mainViewModel.Splits.First().Game;
                _game = GetGame(_previousGame!.Value);
                _previousIgt = 0;
                return;
            }

            //Check if game switch is warranted but only when the timer is running
            if (_isRunning)
            {
                var split = GetCurrentSplit();
                if (split?.Game == null)
                {
                    return;
                }

                if (_previousGame != split.Game)
                {
                    _game = GetGame(split.Game.Value);
                    _game.TryRefresh();
                    _previousGame = split.Game;
                    _previousIgt = 0;
                }
            }
        }

        private void UpdateTimer()
        {
            //Debug.WriteLine($"Timer: {_isRunning}");
            var igt = _game.ReadInGameTimeMilliseconds();
            if (!_isRunning &&
                _mainViewModel.StartAutomatically &&
                igt is > 0 and < 150)
            {
                _isRunning = true;
                OnAutoStart?.Invoke(this, null);
                _mainViewModel.Splits.ForEach(i =>
                {
                    i.IsSplitConditionMet = false;
                    i.IsDisabled = false;
                });
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
                    var increment = igt - _previousIgt;
                    _previousIgt = igt;
                    _currentTime += increment;
                    OnUpdateTime?.Invoke(this, _currentTime);
                }
            }
        }

        private void UpdateAutoSplitter()
        {
            if (!_isRunning)
            {
                return;
            }

            var split = GetCurrentSplit();
            if (
                split == null || 
                split.Split == null ||
                split.IsDisabled || 
                split.SplitType == SplitType.Manual
                )
            {
                return;
            }

            if (!split.IsSplitConditionMet)
            {
                split.IsSplitConditionMet = IsSplitConditionMet(split.SplitType, split.Split);
            }

            if (split.IsSplitConditionMet)
            {
                if (IsSplitTimingMet(split.TimingType!.Value))
                {
                    OnRequestSplit?.Invoke(this, null);
                    split.IsSplitConditionMet = false;
                }
            }
        }

        private bool IsSplitConditionMet(SplitType splitType, object split)
        {
            switch (splitType)
            {
                default:
                case SplitType.DarkSouls1Item:
                case SplitType.DarkSouls1Bonfire:
                    throw new ArgumentException($"Unsupported split type {splitType}.");

                case SplitType.Boss:
                case SplitType.Bonfire:
                case SplitType.ItemPickup:
                case SplitType.KnownFlag:
                    var eventFlag = (uint)split;
                    return _game.ReadEventFlag(eventFlag);

                case SplitType.Flag:
                    uint flag = (uint)split;
                    return _game.ReadEventFlag(flag);

                case SplitType.Attribute:
                    if (_game is not IReadAttribute readAttribute)
                    {
                        throw new ArgumentException($"Unsupported split type {splitType}. {_game} does not implement {nameof(IReadAttribute)}");
                    }

                    var attributeViewModel = (AttributeViewModel)split;
                    return readAttribute.ReadAttribute((Enum)attributeViewModel.Attribute) == attributeViewModel.Level;

                case SplitType.Position:
                    if (_game is not IPlayerPosition playerPosition)
                    {
                        throw new ArgumentException($"Unsupported split type {splitType}. {_game} does not implement {nameof(IPlayerPosition)}");
                    }

                    var positionViewModel = (PositionViewModel)split;
                    var position = playerPosition.GetPlayerPosition();
                    if (positionViewModel.Position.X + positionViewModel.Size > position.X &&
                        positionViewModel.Position.X - positionViewModel.Size < position.X &&

                        positionViewModel.Position.Y + positionViewModel.Size > position.Y &&
                        positionViewModel.Position.Y - positionViewModel.Size < position.Y &&

                        positionViewModel.Position.Z + positionViewModel.Size > position.Z &&
                        positionViewModel.Position.Z - positionViewModel.Size < position.Z)
                    {
                        return true;
                    }
                    return false;

                case SplitType.EldenRingPosition:
                    if (_game is not IEldenRing eldenRing)
                    {
                        throw new ArgumentException($"Unsupported split type {splitType}. {_game} does not implement {nameof(IEldenRing)}");
                    }

                    var vm = (EldenRingPositionViewModel)split;
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
                        return true;
                    }
                    return false;
            }
        }

        private bool IsSplitTimingMet(TimingType timingType)
        {
            switch (timingType)
            {
                case TimingType.Immediate:
                    return true;

                case TimingType.OnLoading:
                    if (_game is ILoading loading)
                    {
                        return loading.IsLoading();
                    }
                    throw new ArgumentException($"Unsupported timing type {timingType}. {_game} does not implement {nameof(ILoading)}");


                case TimingType.OnBlackscreen:
                    if (_game is IBlackscreenRemovable blackscreenRemovable)
                    {
                        return blackscreenRemovable.IsBlackscreenActive();
                    }
                    throw new ArgumentException($"Unsupported timing type {timingType}. {_game} does not implement {nameof(IBlackscreenRemovable)}");
                     
                case TimingType.OnWarp:
                default:
                    throw new ArgumentException();
            }
        }

        private IGame GetGame(Game game)
        {
            return game switch
            {
                Game.DarkSouls1 => _serviceProvider.GetService<IDarkSouls1>(),
                Game.DarkSouls2 => _serviceProvider.GetService<IDarkSouls2>(),
                Game.DarkSouls3 => _serviceProvider.GetService<IDarkSouls3>(),
                Game.Sekiro => _serviceProvider.GetService<ISekiro>(),
                Game.EldenRing => _serviceProvider.GetService<IEldenRing>(),
                Game.ArmoredCore6 => _serviceProvider.GetService<IArmoredCore6>(),
                _ => throw new Exception($"{game} not supported")
            };
        }
    }
}
