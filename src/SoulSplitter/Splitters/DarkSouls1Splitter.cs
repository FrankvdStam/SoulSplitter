using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using SoulMemory.DarkSouls1;
using SoulSplitter.Splits.DarkSouls1;
using SoulSplitter.UI.DarkSouls1;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splitters
{
    internal class DarkSouls1Splitter : ISplitter
    {
        private LiveSplitState _liveSplitState;
        private DarkSouls1 _darkSouls1;
        private DarkSouls1ViewModel _darkSouls1ViewModel;
        public Exception Exception { get; set; }

        public DarkSouls1Splitter(LiveSplitState state)
        {
            _darkSouls1 = new DarkSouls1();
            _liveSplitState = state;
            _liveSplitState.OnStart += OnStart;
            _liveSplitState.OnReset += OnReset;
            _liveSplitState.IsGameTimePaused = true;

            _timerModel = new TimerModel();
            _timerModel.CurrentState = state;
        }

        public void Update(object settings)
        {
            _darkSouls1ViewModel = (DarkSouls1ViewModel)settings;

            Exception = !_darkSouls1.Refresh(out Exception e) ? e : null;

            _darkSouls1ViewModel.CurrentPosition = _darkSouls1.GetPosition();

            UpdateTimer();

            UpdateAutoSplitter();
        }

        public void Dispose()
        {
            _liveSplitState.OnStart -= OnStart;
            _liveSplitState.OnReset -= OnReset;
        }

        private void OnStart(object sender, EventArgs e)
        {
            StartTimer();
            StartAutoSplitting();
        }

        private void OnReset(object sender, TimerPhase timerPhase)
        {
            ResetTimer();
        }

        #region Timer

        private readonly TimerModel _timerModel;
        private int _inGameTime;
        private TimerState _timerState = TimerState.WaitForStart;

        private void StartTimer()
        {
            if (_darkSouls1ViewModel.ResetInventoryIndices)
            {
                _darkSouls1.ResetInventoryIndices();
            }

            _liveSplitState.IsGameTimePaused = true;
            _timerState = TimerState.Running;
            _inGameTime = _darkSouls1.GetInGameTimeMilliseconds();
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
                case TimerState.WaitForStart:
                    if (_darkSouls1ViewModel.StartAutomatically)
                    {
                        var igt = _darkSouls1.GetInGameTimeMilliseconds();
                        if (igt > 0 && igt < 150)
                        {
                            StartTimer();
                            StartAutoSplitting();
                        }
                    }
                    break;

                case TimerState.Running:
                    var currentIgt = _darkSouls1.GetInGameTimeMilliseconds();
                    if (currentIgt != 0)
                    {
                        _inGameTime = currentIgt;
                    }
                    else
                    {
                        _inGameTime = _darkSouls1.GetSaveFileGameTimeMilliseconds();
                    }

                    _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
                    break;
            }
        }

        #endregion

        #region Autosplitting

        private List<Split> _splits = new List<Split>();
       

        public void ResetAutoSplitting()
        {
            _splits.Clear();
        }

        private void StartAutoSplitting()
        {
            _splits = (
                from timingType in _darkSouls1ViewModel.SplitsViewModel.Splits
                from splitType in timingType.Children
                from split in splitType.Children
                select new Split(timingType.TimingType, splitType.SplitType, split.Split)
            ).ToList();
        }

        public void UpdateAutoSplitter()
        {
            TrackWarps();

            if (_timerState != TimerState.Running)
            {
                return;
            }

            List<Item> inventory = null;
            foreach (var s in _splits)
            {
                if (!s.SplitTriggered)
                {
                    if (!s.SplitConditionMet)
                    {
                        switch (s.SplitType)
                        {
                            default:
                                throw new Exception($"Unsupported split type {s.SplitType}");

                            case SplitType.Boss:
                            case SplitType.Flag:
                                s.SplitConditionMet = _darkSouls1.ReadEventFlag(s.Flag);
                                break;

                            case SplitType.Attribute:
                                s.SplitConditionMet = _darkSouls1.GetAttribute(s.Attribute.AttributeType) >= s.Attribute.Level;
                                break;

                            case SplitType.Position:
                                if (s.Position.Position.X + s.Position.Size > _darkSouls1ViewModel.CurrentPosition.X &&
                                    s.Position.Position.X - s.Position.Size < _darkSouls1ViewModel.CurrentPosition.X &&

                                    s.Position.Position.Y + s.Position.Size > _darkSouls1ViewModel.CurrentPosition.Y &&
                                    s.Position.Position.Y - s.Position.Size < _darkSouls1ViewModel.CurrentPosition.Y &&

                                    s.Position.Position.Z + s.Position.Size > _darkSouls1ViewModel.CurrentPosition.Z &&
                                    s.Position.Position.Z - s.Position.Size < _darkSouls1ViewModel.CurrentPosition.Z)
                                {
                                    s.SplitConditionMet = true;
                                }
                                break;

                            case SplitType.Bonfire:
                                s.SplitConditionMet = _darkSouls1.GetBonfireState(s.BonfireState.Bonfire.Value) == s.BonfireState.State;
                                break;

                            case SplitType.Item:
                                if (inventory == null)
                                {
                                    inventory = _darkSouls1.GetInventory();
                                }
                                s.SplitConditionMet = inventory.Any(i => i.ItemType == s.ItemState.ItemType);
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
                    throw new Exception($"Unsupported timing type {s.TimingType}");

                case TimingType.Immediate:
                    _timerModel.Split();
                    s.SplitTriggered = true;
                    break;

                case TimingType.OnLoading:
                    if (!s.Quitout && !_darkSouls1.IsPlayerLoaded())
                    {
                        s.Quitout = true;
                    }

                    if (s.Quitout && _darkSouls1.IsPlayerLoaded())
                    {
                        _timerModel.Split();
                        s.SplitTriggered = true;
                    }
                    break;

                case TimingType.OnWarp:
                    if (!_darkSouls1.IsPlayerLoaded() && _isWarping)
                    {
                        _timerModel.Split();
                        s.SplitTriggered = true;
                    }
                    break;
            }
        }



        private bool _isWarpRequested = false;
        private bool _isWarping = false;
        private bool _warpHasPlayerBeenUnloaded = false;

        private void TrackWarps()
        {
            //Track warps - the game handles warps before the loading screen starts.
            //That's why they have to be tracked while playing, and then resolved on the next loading screen

            if (!_isWarpRequested)
            {
                _isWarpRequested = _darkSouls1.IsWarpRequested();
                return;
            }

            var isPlayerLoaded = _darkSouls1.IsPlayerLoaded();


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
        #endregion
    }
}
