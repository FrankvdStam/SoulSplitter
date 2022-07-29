using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using SoulMemory.DarkSouls3;
using SoulSplitter.Splits.DarkSouls3;
using SoulSplitter.UI.DarkSouls3;

namespace SoulSplitter.Splitters
{
    public class DarkSouls3Splitter : ISplitter
    {
        private LiveSplitState _liveSplitState;
        private DarkSouls3 _darkSouls3;
        public Exception Exception { get; set; }
        private DarkSouls3ViewModel _darkSouls3ViewModel;

        public DarkSouls3Splitter(LiveSplitState state)
        {
            _darkSouls3 = new DarkSouls3();
            _liveSplitState = state;
            _liveSplitState.OnStart += OnStart;
            _liveSplitState.OnReset += OnReset;
            _liveSplitState.IsGameTimePaused = true;

            _timerModel = new TimerModel();
            _timerModel.CurrentState = state;
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


        public void Update(object settings)
        {
            _darkSouls3ViewModel = (DarkSouls3ViewModel)settings;

            RefreshDarkSouls3();

            UpdateTimer();

            UpdateAutoSplitter();
        }


        #region Timer
        private void UpdateTimer()
         {
            switch (_timerState)
            {
                case TimerState.WaitForStart:
                    if (_darkSouls3ViewModel.StartAutomatically)
                    {
                        var igt = _darkSouls3.GetInGameTimeMilliseconds();
                        if (igt > 0 && igt < 150)
                        {
                            StartTimer();
                            StartAutoSplitting();
                        }
                    }
                    break;

                case TimerState.Running:
                    var currentIgt = _darkSouls3.GetInGameTimeMilliseconds();
                    var isLoading = _darkSouls3.IsLoading();
                    var blackscreenActive = _darkSouls3.BlackscreenActive();

                    //Trace.WriteLine($"{_inGameTime} {currentIgt} {isLoading} {blackscreenActive}");

                    //Blackscreens/meme loading screens - timer is running, but game is actually loading
                    if (currentIgt != 0 && currentIgt > _inGameTime && currentIgt < _inGameTime + 1000 && (isLoading || blackscreenActive))
                    {
                        //Trace.WriteLine($"Writing IGT: {TimeSpan.FromMilliseconds(_inGameTime)}");
                        _darkSouls3.WriteInGameTimeMilliseconds(_inGameTime);
                    }
                    else
                    {
                        if (currentIgt != 0)
                        {
                            _inGameTime = currentIgt;
                        }
                    }
                    _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
                    break;
            }
        }

        private void StartTimer()
        {
            _timerState = TimerState.Running;
            _inGameTime = _darkSouls3.GetInGameTimeMilliseconds();
            _liveSplitState.IsGameTimePaused = true;
            _timerModel.Start();
        }

        private void ResetTimer()
        {
            _timerState = TimerState.WaitForStart;
            _inGameTime = 0;
            _timerModel.Reset();
        }

        private readonly TimerModel _timerModel;
        private int _inGameTime;
        private TimerState _timerState = TimerState.WaitForStart;

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
                from timingType in _darkSouls3ViewModel.Splits
                from splitType in timingType.Children
                from split in splitType.Children
                select new Split(timingType.TimingType, splitType.SplitType, split.Split)
                ).ToList();
        }

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

                        case SplitType.Boss:
                        case SplitType.Bonfire:
                        case SplitType.ItemPickup:
                        case SplitType.Flag:
                            if (!s.SplitConditionMet)
                            {
                                s.SplitConditionMet = _darkSouls3.ReadEventFlag(s.Flag);
                            }

                            if (s.SplitConditionMet)
                            {
                                ResolveSplitTiming(s);
                            }

                            break;

                        case SplitType.Attribute:
                            var currentLevel = _darkSouls3.ReadAttribute(s.Attribute.AttributeType);
                            if (!s.SplitConditionMet)
                            {
                                s.SplitConditionMet = currentLevel >= s.Attribute.Level;
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
                    if (_darkSouls3.IsLoading())
                    {
                        _timerModel.Split();
                        s.SplitTriggered = true;
                    }
                    break;
            }
        }

        #endregion

        private void RefreshDarkSouls3()
        {
            try
            {
                if (!_darkSouls3.Refresh())
                {
                    if (!_darkSouls3.Attached)
                    {
                        Exception = new Exception("Game not running");
                    }
                    else if (_darkSouls3.Exception != null)
                    {
                        Exception = _darkSouls3.Exception;
                    }
                    else
                    {
                        Exception = new Exception("unable to refresh darksoul3");
                    }
                }
                else
                {
                    Exception = null;
                }
            }
            catch (Exception e)
            {
                Exception = e;
            }
        }
    }
}
