using System;
using SoulMemory;
using SoulMemory.DarkSouls1;
using SoulSplitter.UI;

namespace SoulSplitter.Splits.DarkSouls1
{
    internal class Split
    {
        public Split(TimingType timingType, DarkSouls1SplitType splitType, object split)
        {
            TimingType = timingType;
            SplitType = splitType;

            switch (SplitType)
            {
                default:
                    throw new Exception($"unsupported split type {SplitType}");

                case DarkSouls1SplitType.BossKill:
                    Boss = (Boss)split;
                    Flag = (uint)Boss;
                    break;
                    
                case DarkSouls1SplitType.Attribute:
                    Attribute = (Attribute)split;
                    break;

                case DarkSouls1SplitType.Position:
                    Position = (Vector3f)split;
                    break;
                    
                case DarkSouls1SplitType.Flag:
                    Flag = ((FlagDescription)split).Flag;
                    break;
            }
        }

        public readonly TimingType TimingType;
        public readonly DarkSouls1SplitType SplitType;
        
        public readonly Boss Boss;
        public readonly Attribute Attribute;
        public readonly Vector3f Position;
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
