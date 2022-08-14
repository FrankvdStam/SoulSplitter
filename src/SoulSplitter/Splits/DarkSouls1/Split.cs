using System;
using SoulMemory;
using SoulMemory.DarkSouls1;
using SoulSplitter.UI;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splits.DarkSouls1
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
                    
                case SplitType.Attribute:
                    Attribute = (Attribute)split;
                    break;

                case SplitType.Position:
                    Position = (VectorSize)split;
                    break;
                    
                case SplitType.Flag:
                    Flag = ((FlagDescription)split).Flag;
                    break;

                case SplitType.Item:
                    ItemState = (ItemState)split;
                    break;

                case SplitType.Bonfire:
                    BonfireState = (BonfireState)split;
                    break;
            }
        }

        public readonly TimingType TimingType;
        public readonly SplitType SplitType;
        
        public readonly Boss Boss;
        public readonly Attribute Attribute;
        public readonly ItemState ItemState;
        public readonly BonfireState BonfireState;
        public readonly VectorSize Position;
        public readonly uint Flag;

        /// <summary>
        /// Set to true when split conditions are met. Does not trigger a split until timing conditions are met
        /// </summary>
        public bool SplitConditionMet = false;
        
        /// <summary>
        /// True after this split object cause a split. No longer need to check split conditions
        /// </summary>
        public bool SplitTriggered = false;
        
        public bool Quitout = false;
    }
}
