using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using SoulMemory.EldenRing;
using SoulSplitter.UI.ViewModel;

namespace SoulSplitter.Splitters
{
    internal class EldenRingSplitter : ISplitter
    {
        private SplitterState _splitterState;
        private TimerModel _timerModel;
        private EldenRing _eldenRing;
        private EldenRingViewModel _eldenRingViewModel;
        private LiveSplitState _liveSplitState;
        private int _inGameTime;

        public EldenRingSplitter(LiveSplitState state, EldenRingViewModel eldenRingViewModel)
        {
            _timerModel = new TimerModel();
            _timerModel.CurrentState = state;
            state.OnStart += OnStart;
            state.OnReset += OnReset;
            state.IsGameTimePaused = true;
            _liveSplitState = state;

            _splitterState = SplitterState.WaitForStart;
            _eldenRing = new EldenRing();
            _eldenRingViewModel = eldenRingViewModel;
        }

        #region Livesplit events
       
        private void OnStart(object sender, EventArgs e)
        {
        }
        private void OnReset(object sender, TimerPhase timerPhase)
        {
            _splitterState = SplitterState.WaitForStart;
            _inGameTime = 0;
        }

        #endregion



        public void Update(LiveSplitState state)
        {
            _liveSplitState = state;

            //Refresh attachment to ER process
            _eldenRing.Refresh();

            //Run the state machine
            RunStateMachine();
        }

        private void RunStateMachine()
        {
            switch (_splitterState)
            {
                case SplitterState.WaitForStart:
                    WaitForStart();
                    break;
                
                case SplitterState.Running:
                    Running();
                    break;
            }
        }


        #region Splitter states
        private void WaitForStart()
        {
            if (
                _eldenRingViewModel.UseInGameTime &&
                _liveSplitState.CurrentPhase != TimerPhase.Running &&
                _eldenRing.IsPlayerLoaded()
                )
            {
                var igt = _eldenRing.GetIngameTimeMilliseconds();
                if (igt > 0 && igt < 150)
                {
                    _splitterState = SplitterState.Running;
                    _timerModel.Start();
                }
            }
        }

        private void Running()
        {
            UpdateInGameTime();
        }

        private void UpdateInGameTime()
        {
            if (_eldenRingViewModel.UseInGameTime)
            {
                var igt = _eldenRing.GetIngameTimeMilliseconds();
                if (igt != 0)
                {
                    _inGameTime = igt;
                }

                _timerModel.CurrentState.SetGameTime(TimeSpan.FromMilliseconds(_inGameTime));
            }
        }

        #endregion
    }
}
