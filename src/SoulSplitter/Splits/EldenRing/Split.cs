using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.EldenRing;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Splits.EldenRing
{
    internal class Split
    {
        public Split(TimingType timingType, EldenRingSplitType eldenRingSplitType, object split)
        {
            TimingType = timingType;
            EldenRingSplitType = eldenRingSplitType;

            switch (EldenRingSplitType)
            {
                default:
                    throw new Exception($"unsupported split type {EldenRingSplitType}");

                case EldenRingSplitType.Boss:
                    Boss = (Boss)split;
                    Flag = (uint)Boss;
                    break;

                case EldenRingSplitType.Grace:
                    Grace = (Grace)split;
                    Flag = (uint)Grace;
                    break;

                case EldenRingSplitType.ItemPickup:
                    ItemPickup = (ItemPickup)split;
                    Flag = (uint)ItemPickup;
                    break;

                case EldenRingSplitType.Flag:
                    Flag = (uint)split;
                    break;

                case EldenRingSplitType.Item:
                    Item = (Item)split;
                    break;

                case EldenRingSplitType.Position:
                    Position = (Position)split;
                    break;
            }
        }

        public readonly TimingType TimingType;
        public readonly EldenRingSplitType EldenRingSplitType;
        
        public readonly Boss Boss;
        public readonly Grace Grace;
        public readonly ItemPickup ItemPickup;
        public readonly Item Item;
        public readonly Position Position;
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
