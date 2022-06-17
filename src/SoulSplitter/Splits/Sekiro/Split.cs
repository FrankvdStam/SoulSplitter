using System;
using SoulMemory;
using SoulMemory.Sekiro;

namespace SoulSplitter.Splits.Sekiro
{
    internal class Split
    {
        public Split(TimingType timingType, SplitType darkSouls3SplitType, object split)
        {
            TimingType = timingType;
            SplitType = darkSouls3SplitType;

            switch (SplitType)
            {
                default:
                    throw new Exception($"unsupported split type {SplitType}");

                case SplitType.Boss:
                    Boss = (Boss)split;
                    Flag = (uint)Boss;
                    break;

                case SplitType.Idol:
                    Idol = (Idol)split;
                    Flag = (uint)Idol;
                    break;

                case SplitType.Position:
                    Position = (Vector3f)split;
                    break;

                case SplitType.Flag:
                    Flag = (uint)split;
                    break;
            }
        }

        public readonly TimingType TimingType;
        public readonly SplitType SplitType;
        
        public readonly Boss Boss;
        public readonly Idol Idol;
        public readonly uint Flag;
        public readonly Vector3f Position;

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
