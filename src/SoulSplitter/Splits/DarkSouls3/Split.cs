using System;
using SoulMemory.DarkSouls3;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splits.DarkSouls3
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

                case SplitType.Bonfire:
                    Bonfire = (Bonfire)split;
                    Flag = (uint)Bonfire;
                    break;

                case SplitType.ItemPickup:
                    ItemPickup = (ItemPickup)split;
                    Flag = (uint)ItemPickup;
                    break;

                case SplitType.Attribute:
                    Attribute = (Attribute)split;
                    break;

                case SplitType.Flag:
                    Flag = (uint)split;
                    break;
            }
        }

        public readonly TimingType TimingType;
        public readonly SplitType SplitType;
        
        public readonly Boss Boss;
        public readonly Bonfire Bonfire;
        public readonly ItemPickup ItemPickup;
        public readonly Attribute Attribute;
        public readonly uint Flag;

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
