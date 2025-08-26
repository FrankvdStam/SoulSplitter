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
using SoulMemory.Games.DarkSouls1;

namespace SoulSplitter.Timer
{
    public delegate void UpdateTimeEventHandler(object? sender, int milliseconds);

    public class Timer : ITimer
    {
        public Timer(IServiceProvider serviceProvider, MainViewModel mainViewModel)
        {
            _serviceProvider = serviceProvider;
            mainViewModel.Game = serviceProvider.GetService<ISekiro>(); //TODO: should this be loading sekiro by default?
            _mainViewModel = mainViewModel;
            mainViewModel.Splits.CollectionChanged += (o, e) => SplitsChanged();
            _previousDropmodType = _mainViewModel.DropModType;
        }

        private readonly IServiceProvider _serviceProvider;
        private readonly MainViewModel _mainViewModel;
        private DropMod? _dropMod;

        private int _currentSplitIndex = 0;
        private Game? _previousGame;
        private bool _isRunning;
        private int _currentIgt;
        private int _previousIgt;
        private int _multiGameIgt;
        private bool _previousAreCreditsRolling = false;
        private int _currentSaveSlot;
        private bool _isWarpRequested;
        private bool _isWarping;
        private bool _warpHasPlayerBeenUnloaded;
        private DropModType _previousDropmodType;

        public event EventHandler? OnAutoStart;
        public event EventHandler? OnRequestSplit;
        public event UpdateTimeEventHandler? OnUpdateTime;

        /// <summary>
        /// Latch in which saveslot is used for this game/run
        /// </summary>
        private void LatchCurrentSaveSlot()
        {
            if (_mainViewModel.Game is ISavefileTime savefileTime)
            {
                _currentSaveSlot = savefileTime.GetCurrentSaveSlot();
            }
        }

        /// <summary>
        /// Manually start the timer. Overwrites IGT to 0 if required by settings
        /// </summary>
        public void Start()
        {
            _isRunning = true;
            if (_mainViewModel.OverwriteIgtOnStart)
            {
                _mainViewModel.Game!.WriteInGameTimeMilliseconds(0);
            }

            LatchCurrentSaveSlot();

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
                _currentIgt = 0;
                _multiGameIgt = 0;
                _currentSaveSlot = -1;
                _previousGame = null;
                _previousAreCreditsRolling = false;
                _isWarpRequested = false;
                _isWarping = false;
                _warpHasPlayerBeenUnloaded = false;
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
            var result = _mainViewModel.Game!.TryRefresh();
            if (result.IsErr)
            {
                _dropMod = null;
                return result;
            }

            _mainViewModel.TryAndHandleError(() =>
            {
                //if the timer is not running and the selected split is position, populate the UI with
                //a position read from the game. This can't be read from _game since that will be the first split's game
                //instead fetch it from the selected split's game.
                if (!_isRunning && _mainViewModel.SelectedSplitType is SplitType.Position or SplitType.EldenRingPosition)
                {
                    //_game is bound to the first split or the current active split.
                    var game = GetGame(_mainViewModel.SelectedGame!.Value);
                    //only update if required
                    if (game != _mainViewModel.Game)
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
            TrackWarps();
            UpdateAutoSplitter();
            UpdateDropMod();
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
                _mainViewModel.Game = GetGame(_previousGame!.Value);
                _previousIgt = 0;
                _multiGameIgt = 0;
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
                    _mainViewModel.Game = GetGame(split.Game.Value);
                    _mainViewModel.Game.TryRefresh();
                    _previousGame = split.Game;
                    _previousIgt = 0;
                    _multiGameIgt = _currentIgt;
                    LatchCurrentSaveSlot();
                }
            }
        }

        private void UpdateTimer()
        {
            //Debug.WriteLine($"Timer: {_isRunning}");
            _currentIgt = _mainViewModel.Game!.ReadInGameTimeMilliseconds();
            if (!_isRunning &&
                _mainViewModel.StartAutomatically &&
                _currentIgt is > 0 and < 150)
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
                    _mainViewModel.Game is not ISekiro &&
                    _mainViewModel.Game is IBlackscreenRemovable blackscreenRemovable &&
                    blackscreenRemovable.IsBlackscreenActive() &&
                    _currentIgt != 0 &&                                             //Igt timer has starter
                    _currentIgt > _previousIgt &&                                   //Igt has increased since previous frame
                    _currentIgt < _previousIgt + 1000)                              //Igt has not increased by more than 1 second
                {
                    //During blackscreen, overwrite the incremented timer value with the last known good IGT value.
                    _mainViewModel.Game.WriteInGameTimeMilliseconds(_previousIgt);
                    return; //Don't invoke UpdateTime event during black screen
                }

                if (_mainViewModel.Game is ISavefileTime savefileTime)
                {
                    var areCreditsRolling = savefileTime.AreCreditsRolling();

                    if (
                        //Detect going from a savefile to the main menu
                        //Only do this once to prevent save file reading race conditions
                        _currentIgt == 0 && _previousIgt != 0 ||

                        //When the credits are active, show savefile time as well
                        areCreditsRolling && !_previousAreCreditsRolling
                        )
                    {
                        var saveFileTime = savefileTime.GetSaveFileGameTimeMilliseconds(savefileTime.GetSaveFileLocation()!, _currentSaveSlot);
                        _currentIgt = saveFileTime;
                        //only trigger reading savefile once
                        _previousIgt = 0;
                        _previousAreCreditsRolling = false;
                        OnUpdateTime?.Invoke(this, _multiGameIgt + _currentIgt);
                        return;
                    }
                    _previousAreCreditsRolling = areCreditsRolling;
                }

                //don't update IGT when it's 0 during a quitout
                if (_currentIgt != 0)
                {
                    _previousIgt = _currentIgt;
                    OnUpdateTime?.Invoke(this, _multiGameIgt + _currentIgt);
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
                    return _mainViewModel.Game!.ReadEventFlag(eventFlag);

                case SplitType.Flag:
                    uint flag = (uint)split;
                    return _mainViewModel.Game!.ReadEventFlag(flag);

                case SplitType.Attribute:
                    if (_mainViewModel.Game is not IReadAttribute readAttribute)
                    {
                        throw new ArgumentException($"Unsupported split type {splitType}. {_mainViewModel.Game} does not implement {nameof(IReadAttribute)}");
                    }

                    var attributeViewModel = (AttributeViewModel)split;
                    return readAttribute.ReadAttribute((Enum)attributeViewModel.Attribute) == attributeViewModel.Level;

                case SplitType.Position:
                    if (_mainViewModel.Game is not IPlayerPosition playerPosition)
                    {
                        throw new ArgumentException($"Unsupported split type {splitType}. {_mainViewModel.Game} does not implement {nameof(IPlayerPosition)}");
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
                    if (_mainViewModel.Game is not IEldenRing eldenRing)
                    {
                        throw new ArgumentException($"Unsupported split type {splitType}. {_mainViewModel.Game} does not implement {nameof(IEldenRing)}");
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
                    if (_mainViewModel.Game is ILoading loading)
                    {
                        return loading.IsLoading();
                    }
                    throw new ArgumentException($"Unsupported timing type {timingType}. {_mainViewModel.Game} does not implement {nameof(ILoading)}");


                case TimingType.OnBlackscreen:
                    if (_mainViewModel.Game is IBlackscreenRemovable blackscreenRemovable)
                    {
                        return blackscreenRemovable.IsBlackscreenActive();
                    }
                    throw new ArgumentException($"Unsupported timing type {timingType}. {_mainViewModel.Game} does not implement {nameof(IBlackscreenRemovable)}");

                case TimingType.OnWarp:
                    if (_mainViewModel.Game is IDarkSouls1 darkSouls1)
                    {
                        return !darkSouls1.IsPlayerLoaded() && _isWarping;
                    }
                    throw new ArgumentException($"Unsupported timing type {timingType}. {_mainViewModel.Game} does not implement {nameof(IDarkSouls1)}");

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
                Game.Bloodborne => _serviceProvider.GetService<IBloodborne>(),
                Game.Nightreign => _serviceProvider.GetService<INightreign>(),
                _ => throw new Exception($"{game} not supported")
            };
        }



        private void TrackWarps()
        {
            //Track warps - the game handles warps before the loading screen starts.
            //That's why they have to be tracked while playing, and then resolved on the next loading screen

            if (_mainViewModel.Game is IDarkSouls1 darkSouls1)
            {
                if (!_isWarpRequested)
                {
                    _isWarpRequested = darkSouls1.IsWarpRequested();
                    return;
                }

                var isPlayerLoaded = darkSouls1.IsPlayerLoaded();

                //Warp is requested - wait for loading screen
                if (_isWarpRequested)
                {
                    if (!_warpHasPlayerBeenUnloaded)
                    {
                        if (!isPlayerLoaded)
                        {
                            _warpHasPlayerBeenUnloaded = true;
                        }
                    }
                    else
                    {
                        _isWarping = true;
                    }

                    if (_isWarping && isPlayerLoaded)
                    {
                        _isWarping = false;
                        _warpHasPlayerBeenUnloaded = false;
                        _isWarpRequested = false;
                    }
                }
            }
        }
        
        private void UpdateDropMod()
        {
            if (_mainViewModel.Game is IDarkSouls1 darkSouls1)
            {
                if (_previousDropmodType != _mainViewModel.DropModType && _mainViewModel.DropModType == DropModType.None)
                {
                    darkSouls1.GetProcess()!.Kill();
                    _previousDropmodType = _mainViewModel.DropModType;
                    return;
                }

                _previousDropmodType = _mainViewModel.DropModType;

                //check init request
                if (_mainViewModel.DropModType != DropModType.None && _dropMod == null)
                {
                    _dropMod = new DropMod(darkSouls1);
                    switch (_mainViewModel.DropModType)
                    {
                        default:
                            throw new InvalidOperationException($"Invalid DropModType {_mainViewModel.DropModType}");

                        case DropModType.AnyPercent:
                            _dropMod.InitBkh();
                            break;

                        case DropModType.AllAchievements:
                            _dropMod.InitAllAchievements();
                            break;
                    }
                }

                //update
                switch (_mainViewModel.DropModType)
                {
                    default:
                    case DropModType.None:
                    case DropModType.AnyPercent:
                        break;

                    case DropModType.AllAchievements:
                        _dropMod!.UpdateAllAchievements();
                        break;
                }
            }
        }
    }
}
