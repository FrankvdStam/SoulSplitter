using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using SoulMemory.DarkSouls2;
using SoulSplitter.Splits.DarkSouls2;
using SoulSplitter.UI.DarkSouls2;
using SoulSplitter.UI.Sekiro;

namespace SoulSplitter.Splitters
{
    public class DarkSouls2Splitter : ISplitter
    {
        public Exception Exception { get; set; }
        private DarkSouls2 _darkSouls2;
        private DarkSouls2ViewModel _darkSouls2ViewModel;
        private LiveSplitState _liveSplitState;
        
        public DarkSouls2Splitter(LiveSplitState state)
        {
            _darkSouls2 = new DarkSouls2();
            _liveSplitState = state;
            _liveSplitState.OnStart += OnStart;
            _liveSplitState.OnReset += OnReset;
            _liveSplitState.IsGameTimePaused = true;

            _timerModel = new TimerModel();
            _timerModel.CurrentState = state;
        }

        #region 
        
        private void OnStart(object sender, EventArgs e)
        {
            StartTimer();
            StartAutoSplitting();
        }

        private void OnReset(object sender, TimerPhase timerPhase)
        {
            ResetTimer();
            ResetAutoSplitting();
        }

        public void Dispose()
        {
            _liveSplitState.OnStart -= OnStart;
            _liveSplitState.OnReset -= OnReset;
        }

        public void Update(object settings)
        {
            _darkSouls2ViewModel = (DarkSouls2ViewModel)settings;

            Exception = !_darkSouls2.Refresh(out Exception e) ? e : null;
            
            _darkSouls2ViewModel.CurrentPosition = _darkSouls2.GetPosition();
            
            UpdateTimer();

            UpdateAutoSplitter();
        }
        
        #endregion

        #region Timer

        private bool _previousIsLoading;
        private readonly TimerModel _timerModel;
        private TimerState _timerState = TimerState.WaitForStart;
        private Stopwatch _stopwatch = new Stopwatch();
        
        private void StartTimer()
        {
            _timerState = TimerState.Running;
            _stopwatch.Start();
            _previousIsLoading = _darkSouls2.IsLoading();
            _timerModel.Start();
        }

        private void ResetTimer()
        {
            _timerState = TimerState.WaitForStart;
            _timerModel.Reset();
        }

        private void UpdateTimer()
        {
            switch (_timerState)
            {
                case TimerState.WaitForStart:
                    //if (_darkSouls2ViewModel.StartAutomatically)
                    //{
                    //    var igt = _sekiro.GetInGameTimeMilliseconds();
                    //    if (igt > 0 && igt < 150)
                    //    {
                    //        StartTimer();
                    //        _timerModel.Start();
                    //        StartAutoSplitting();
                    //    }
                    //}
                    break;

                case TimerState.Running:
                    //Pause on loads
                    if (_previousIsLoading != _darkSouls2.IsLoading())
                    {
                        if (_darkSouls2.IsLoading())
                        {
                            _stopwatch.Stop();
                        }
                        else
                        {
                            _stopwatch.Start();
                        }
                    }
                    _previousIsLoading = _darkSouls2.IsLoading();

                    //Set time
                    _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_stopwatch.ElapsedMilliseconds));
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

        public void StartAutoSplitting()
        {
            _splits = (
                from timingType in _darkSouls2ViewModel.Splits
                from splitType in timingType.Children
                from split in splitType.Children
                select new Split(timingType.TimingType, splitType.SplitType, split.Split)
            ).ToList();
        }


        private const float _boxSize = 5.0f;
        public void UpdateAutoSplitter()
        {
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
                            
                        case DarkSouls2SplitType.Flag:
                            if (!s.SplitConditionMet)
                            {
                                s.SplitConditionMet = _darkSouls2.ReadEventFlag(s.Flag);
                            }

                            if (s.SplitConditionMet)
                            {
                                ResolveSplitTiming(s);
                            }
                            break;

                        case DarkSouls2SplitType.Position:
                            if (!s.SplitConditionMet)
                            {
                                if (s.Position.X + _boxSize > _darkSouls2ViewModel.CurrentPosition.X &&
                                    s.Position.X - _boxSize < _darkSouls2ViewModel.CurrentPosition.X &&

                                    s.Position.Y + _boxSize > _darkSouls2ViewModel.CurrentPosition.Y &&
                                    s.Position.Y - _boxSize < _darkSouls2ViewModel.CurrentPosition.Y &&

                                    s.Position.Z + _boxSize > _darkSouls2ViewModel.CurrentPosition.Z &&
                                    s.Position.Z - _boxSize < _darkSouls2ViewModel.CurrentPosition.Z)
                                {
                                    s.SplitConditionMet = true;
                                }
                            }

                            if (s.SplitConditionMet)
                            {
                                ResolveSplitTiming(s);
                            }
                            break;
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
                    if (_darkSouls2.IsLoading())
                    {
                        _timerModel.Split();
                        s.SplitTriggered = true;
                    }
                    break;
            }
        }
        #endregion
        
    }
}
