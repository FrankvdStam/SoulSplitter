using System;
using SoulMemory;
using SoulMemory.Sekiro;
using SoulSplitter.Splits.DarkSouls1;
using SoulSplitter.UI;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splits.Sekiro
{
    internal class Split
    {
        public Split(TimingType timingType, SplitType splitType, object split)
        {
            TimingType = timingType;
            SplitType = splitType;

            switch (SplitType)
            {
                default:
                    throw new Exception($"unsupported split type {SplitType}");

                case SplitType.Boss:
                    Boss = (Boss)split;
                    Flag = (uint)Boss;
                    break;

                case SplitType.Bonfire:
                    Idol = (Idol)split;
                    Flag = (uint)Idol;
                    break;

                case SplitType.Position:
                    Position = (VectorSize)split;
                    break;

                case SplitType.Flag:
                    Flag = ((FlagDescription)split).Flag;
                    break;
            }
        }

        public readonly TimingType TimingType;
        public readonly SplitType SplitType;
        
        public readonly Boss Boss;
        public readonly Idol Idol;
        public readonly uint Flag;
        public readonly VectorSize Position;

        /// <summary>
        /// Set to true when split conditions are met. Does not trigger a split until timing conditions are met
        /// </summary>
        public bool SplitConditionMet = false;
        
        /// <summary>
        /// True after this split object cause a split. No longer need to check split conditions
        /// </summary>
        public bool SplitTriggered = false;
    }
}
