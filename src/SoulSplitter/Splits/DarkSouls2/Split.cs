using System;
using SoulMemory;

namespace SoulSplitter.Splits.DarkSouls2
{
    internal class Split
    {
        public Split(TimingType timingType, DarkSouls2SplitType darkSouls2SplitType, object split)
        {
            TimingType = timingType;
            SplitType = darkSouls2SplitType;

            switch (SplitType)
            {
                default:
                    throw new Exception($"unsupported split type {SplitType}");

                case DarkSouls2SplitType.Position:
                    Position = (Vector3f)split;
                    break;

                case DarkSouls2SplitType.BossKill:
                    BossKill = (BossKill)split;
                    break;

                case DarkSouls2SplitType.Attribute:
                    Attribute = (Attribute)split;
                    break;

                case DarkSouls2SplitType.Flag:
                    Flag = (uint)split;
                    break;
            }
        }

        public readonly TimingType TimingType;
        public readonly DarkSouls2SplitType SplitType;
        
        public readonly uint Flag;
        public readonly Vector3f Position;
        public readonly BossKill BossKill;
        public readonly Attribute Attribute;

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
