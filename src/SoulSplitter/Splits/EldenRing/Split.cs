using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.EldenRing;

namespace SoulSplitter.Splits.EldenRing
{
    internal class Split
    {
        public TimingType TimingType;
        public EldenRingSplitType EldenRingSplitType;
        public Boss Boss;
        public bool BossDefeated = false;

        public bool Triggered = false;
    }
}
