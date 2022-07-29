using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using SoulMemory.DarkSouls1;
using SoulSplitter.Splits.DarkSouls1;
using SoulSplitter.UI.DarkSouls1;

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
            _timerState = TimerState.Running;
            _inGameTime = _darkSouls1.GetInGameTimeMillis();
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
        }

        #endregion

        #region Autosplitting

        private List<Split> _splits = new List<Split>();
       

        public void ResetAutoSplitting()
        {
            _splits.Clear();
        }

        public void StartAutoSplitting()
        {
            _splits = (
                from timingType in _darkSouls1ViewModel.Splits
                from splitType in timingType.Children
                from split in splitType.Children
                select new Split(timingType.TimingType, splitType.SplitType, split.Split)
            ).ToList();
        }
        private const float BoxSize = 5.0f;
        public void UpdateAutoSplitter()
        {
            TrackWarps();

            if (_timerState != TimerState.Running)
            {
                return;
            }

            foreach (var s in _splits)
            {
                if (!s.SplitTriggered)
                {
                    switch (s.SplitType)
                    {
                        default:
                            throw new Exception($"Unsupported split type {s.SplitType}");

                        case DarkSouls1SplitType.BossKill:
                        case DarkSouls1SplitType.Flag:
                            if (!s.SplitConditionMet)
                            {
                                s.SplitConditionMet = _darkSouls1.ReadEventFlag(s.Flag);
                            }
                            break;

                        case DarkSouls1SplitType.Attribute:
                            if (!s.SplitConditionMet)
                            {
                                s.SplitConditionMet = _darkSouls1.GetAttribute(s.Attribute.AttributeType) >= s.Attribute.Level;
                            }
                            break;

                        case DarkSouls1SplitType.Position:
                            if (!s.SplitConditionMet)
                            {
                                if (s.Position.X + BoxSize > _darkSouls1ViewModel.CurrentPosition.X &&
                                    s.Position.X - BoxSize < _darkSouls1ViewModel.CurrentPosition.X &&

                                    s.Position.Y + BoxSize > _darkSouls1ViewModel.CurrentPosition.Y &&
                                    s.Position.Y - BoxSize < _darkSouls1ViewModel.CurrentPosition.Y &&

                                    s.Position.Z + BoxSize > _darkSouls1ViewModel.CurrentPosition.Z &&
                                    s.Position.Z - BoxSize < _darkSouls1ViewModel.CurrentPosition.Z)
                                {
                                    s.SplitConditionMet = true;
                                }
                            }
                            break;
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
                    if (!_darkSouls1.IsLoaded())
                    {
                        _timerModel.Split();
                        s.SplitTriggered = true;
                    }
                    break;

                case TimingType.OnWarp:
                    if (!_darkSouls1.IsLoaded() && _warping)
                    {
                        _timerModel.Split();
                        s.SplitTriggered = true;
                    }
                    break;
            }
        }


        private bool _warping = false;
        private bool _warpUnload = false;
        private void TrackWarps()
        {
            //Track warps - the game handles warps before the loading screen starts.
            //That's why they have to be tracked while playing, and then resolved on the next loading screen
            if (_darkSouls1.IsWarping())
            {
                _warping = true;
            }

            if (!_warpUnload)
            {
                if (!_darkSouls1.IsLoaded())
                {
                    _warpUnload = true;
                }
            }

            if (_warpUnload)
            {
                if (_darkSouls1.IsLoaded())
                {
                    _warpUnload = false;
                    _warping = false;
                }
            }
        }
        #endregion
        
    }
}
