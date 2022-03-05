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
        private SplitterState _splitterState;
        private EldenRing _eldenRing;
        private EldenRingViewModel _eldenRingViewModel;
        private LiveSplitState _liveSplitState;
        private Timer _timer;

        public EldenRingSplitter(LiveSplitState state, EldenRingViewModel eldenRingViewModel)
        {
            _splitterState = SplitterState.WaitForStart;
            _eldenRing = new EldenRing();
            _eldenRingViewModel = eldenRingViewModel;

            _timer = new Timer(_eldenRing, state);
        }


        public void Update(LiveSplitState state)
        {
            _liveSplitState = state;

            //Refresh attachment to ER process
            _eldenRing.Refresh();

            //Update the timer
            _timer.Update(_eldenRingViewModel.TimingMethod, _eldenRingViewModel.StartAutomatically);

            //TODO: run auto splitter state machine
        }
    }
}
