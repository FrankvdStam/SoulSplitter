using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using SoulMemory.EldenRing;
using SoulSplitter.Splits.EldenRing;
using SoulSplitter.UI;
using SoulSplitter.UI.EldenRing;

namespace SoulSplitter.Splitters
{
    internal class EldenRingSplitter : ISplitter
    {
        public Exception Exception { get; set; }

        private EldenRing _eldenRing;
        private EldenRingViewModel _eldenRingViewModel;
        private LiveSplitState _liveSplitState;

        public EldenRingSplitter(LiveSplitState state)
        {
            _liveSplitState = state;
            _eldenRing = new EldenRing();

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

        public void Update(object settings)
        {
            //Settings from the UI

            _eldenRingViewModel = (EldenRingViewModel)settings;

            //Refresh attachment to ER process
            Exception = !_eldenRing.Refresh(out Exception e) ? e : null;

            //Lock IGT to 0 if requested
            if (_eldenRingViewModel.LockIgtToZero)
            {
                _eldenRing.ResetIgt();
                return;//Don't allow other features to be used while locking the timer
            }

            UpdatePosition();

            //Update the timer
            UpdateTimer(TimingMethod.Igt, _eldenRingViewModel.StartAutomatically);

            UpdateAutoSplitter();
        }


        private void UpdatePosition()
        {
            var position = _eldenRing.GetPosition();
            _eldenRingViewModel.CurrentPosition.Area   = position.Area  ;
            _eldenRingViewModel.CurrentPosition.Block  = position.Block ;
            _eldenRingViewModel.CurrentPosition.Region = position.Region;
            _eldenRingViewModel.CurrentPosition.Size   = position.Size  ;
            _eldenRingViewModel.CurrentPosition.X      = position.X     ;
            _eldenRingViewModel.CurrentPosition.Y      = position.Y     ;
            _eldenRingViewModel.CurrentPosition.Z      = position.Z     ;
        }

        //Starting the timer by calling Start(); on a TimerModel object will trigger more than just SoulSplitter's start event.
        //It occurred at least twice that another plugin would throw exceptions during the start event, causing SoulSplitter's start event to never be called at all.
        //That in turn never changed the timer state to running. We can not rely on this event.
        //Thats why autostarting will take care of this and doesn't need the event.
        //However, we still need this event when players start the timer manually.
        private void OnStart(object sender, EventArgs e)
        {
            if (_timerState != TimerState.Running)
            {
                StartTimer();
                StartAutoSplitting(_eldenRingViewModel);
            }
        }

        private void OnReset(object sender, TimerPhase timerPhase)
        {
            ResetTimer();
            ResetAutoSplitting();
        }

        #region Timer
        private readonly TimerModel _timerModel;
        private int _inGameTime;
        private TimerState _timerState = TimerState.WaitForStart;
        private TimingMethod _timingMethod;
        private bool _startAutomatically;
        private bool _timerStarted;

        private void StartTimer()
        {
            //Set the state of the timer to running, but only start the RTA stopwatch if we're in game
            //IGT will automatically stop if we're no in game
            _timerState = TimerState.Running;
            _eldenRing.EnableHud();
        }

        private void ResetTimer()
        {
            _timerState = TimerState.WaitForStart;
            _inGameTime = 0;
            _timerStarted = false;
        }


        public void UpdateTimer(TimingMethod timingMethod, bool startAutomatically)
        {
            //Allow updates from the UI only when a run isn't in progress
            if (_timerState == TimerState.WaitForStart)
            {
                _startAutomatically = startAutomatically;
                _timingMethod = timingMethod;
            }

            switch (_timerState)
            {
                case TimerState.WaitForStart:
                    if (_startAutomatically)
                    {
                        if (!_timerStarted)
                        {
                            var igt = _eldenRing.GetInGameTimeMilliseconds();
                            _timerStarted = igt > 0 && igt < 150;
                        }

                        if (_timerStarted && _eldenRing.InitialLoadRemoval())
                        {
                            _eldenRing.ResetIgt();
                            StartTimer();
                            _timerModel.Start();
                            StartAutoSplitting(_eldenRingViewModel);
                        }
                    }
                    break;

                case TimerState.Running:

                    var currentIgt = _eldenRing.GetInGameTimeMilliseconds();
                    var blackscreenActive = _eldenRing.IsBlackscreenActive();


                    //Blackscreens/meme loading screens - timer is running, but game is actually loading
                    if (currentIgt != 0 && currentIgt > _inGameTime && currentIgt < _inGameTime + 1000 && blackscreenActive)
                    {
                        //Trace.WriteLine($"Writing IGT: {TimeSpan.FromMilliseconds(_inGameTime)}");
                        _eldenRing.WriteInGameTimeMilliseconds(_inGameTime);
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
        
        private void WriteTimer()
        {
            if (_timingMethod == TimingMethod.None)
            {
                return;
            }

            switch (_timingMethod)
            {
                case TimingMethod.Igt:
                    if (_eldenRing.IsInGame())
                    {
                        _inGameTime = _eldenRing.GetInGameTimeMilliseconds();
                    }
                    break;
            }

            _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
        }

        #endregion

        #region Autosplitting

        private List<Split> _splits = new List<Split>();

        public void ResetAutoSplitting()
        {
            _splits.Clear();
        }

        public void StartAutoSplitting(EldenRingViewModel eldenRingViewModel)
        {
            _splits = (
                from timingType in eldenRingViewModel.Splits
                from splitType in timingType.Children
                from split in splitType.Children
                select new Split(timingType.TimingType, splitType.EldenRingSplitType, split.Split)
                //{
                //    TimingType = timingType.TimingType,
                //    EldenRingSplitType = splitType.EldenRingSplitType,
                //    Boss = splitType.EldenRingSplitType == EldenRingSplitType.Boss ? (Boss)split.Split : Boss.AncestralSpirit,//random default
                //    Grace = splitType.EldenRingSplitType == EldenRingSplitType.Grace ? (Grace)split.Split : Grace.TheFirstStep,//random default
                //    Flag = splitType.EldenRingSplitType == EldenRingSplitType.Flag ? (uint)split.Split : 0,
                //
                //}
                ).ToList();
        }

        public void UpdateAutoSplitter()
        {
            if (_timerState != TimerState.Running)
            {
                return;
            }

            List<Item> inventoryItems = null;

            foreach (var s in _splits)
            {
                if (!s.SplitTriggered)
                {
                    switch (s.EldenRingSplitType)
                    {
                        default:
                            throw new Exception($"Unsupported split type {s.EldenRingSplitType}");

                        case EldenRingSplitType.Boss:
                        case EldenRingSplitType.Grace:
                        case EldenRingSplitType.ItemPickup:
                        case EldenRingSplitType.Flag:
                            if (!s.SplitConditionMet)
                            {
                                s.SplitConditionMet = _eldenRing.ReadEventFlag(s.Flag);
                            }

                            if (s.SplitConditionMet)
                            {
                                ResolveSplitTiming(s);
                            }

                            break;

                        case EldenRingSplitType.Item:
                            //Only get the inventory items once per livesplit tick
                            if (inventoryItems == null)
                            {
                                inventoryItems = _eldenRing.ReadInventory();
                            }

                            if (!s.SplitConditionMet)
                            {
                                s.SplitConditionMet = inventoryItems.Any(i => i.Category == s.Item.Category && i.Id == s.Item.Id);
                            }

                            if (s.SplitConditionMet)
                            {
                                ResolveSplitTiming(s);
                            }
                            break;

                        case EldenRingSplitType.Position:
                            if (!s.SplitConditionMet)
                            {
                                if (_eldenRingViewModel.CurrentPosition.Area   == s.Position.Area   &&
                                    _eldenRingViewModel.CurrentPosition.Block  == s.Position.Block  &&
                                    _eldenRingViewModel.CurrentPosition.Region == s.Position.Region &&
                                    _eldenRingViewModel.CurrentPosition.Size   == s.Position.Size)
                                {
                                    if (s.Position.X + 5.0f > _eldenRingViewModel.CurrentPosition.X &&
                                        s.Position.X - 5.0f < _eldenRingViewModel.CurrentPosition.X &&

                                        s.Position.Y + 5.0f > _eldenRingViewModel.CurrentPosition.Y &&
                                        s.Position.Y - 5.0f < _eldenRingViewModel.CurrentPosition.Y &&

                                        s.Position.Z + 5.0f > _eldenRingViewModel.CurrentPosition.Z &&
                                        s.Position.Z - 5.0f < _eldenRingViewModel.CurrentPosition.Z)
                                    {
                                        s.SplitConditionMet = true;
                                    }
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
                    if (_eldenRing.GetScreenState() == ScreenState.Loading)
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
