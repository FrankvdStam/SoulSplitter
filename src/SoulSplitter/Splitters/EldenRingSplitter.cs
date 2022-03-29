using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using SoulMemory.EldenRing;
using SoulSplitter.UI;
using SoulSplitter.UI.ViewModel;

namespace SoulSplitter.Splitters
{
    internal class EldenRingSplitter : ISplitter
    {
        public Exception Exception;

        private SplitterState _splitterState;
        private EldenRing _eldenRing;
        private LiveSplitState _liveSplitState;
        private Timer _timer;

        public EldenRingSplitter(LiveSplitState state)
        {
            _liveSplitState = state;
            _splitterState = SplitterState.WaitForStart;
            _eldenRing = new EldenRing();
            _timer = new Timer(_eldenRing, state);
        }

        public void Update(object eldenRingViewModel)
        {
            //Settings from the UI
            var viewModel = (EldenRingViewModel)eldenRingViewModel;

            //Refresh attachment to ER process
            RefreshEldenRing();

            //Update the timer
            _timer.Update(TimingMethod.Igt, viewModel.StartAutomatically);

            //TODO: run auto splitter state machine
        }

        public void RefreshEldenRing()
        {
            try
            {
                if (!_eldenRing.Refresh())
                {
                    if (!_eldenRing.Attached)
                    {
                        Exception = new Exception("Game not running");
                    }
                    else if (_eldenRing.Exception != null)
                    {
                        Exception = _eldenRing.Exception;
                    }
                    else
                    {
                        Exception = new Exception("unable to refresh eldenring");
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
