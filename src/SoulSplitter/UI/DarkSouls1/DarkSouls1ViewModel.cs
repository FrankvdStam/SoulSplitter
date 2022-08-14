using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;
using SoulMemory.DarkSouls1;
using SoulSplitter.Splits.DarkSouls1;
using SoulSplitter.UI.Generic;
using BonfireState = SoulMemory.DarkSouls1.BonfireState;

namespace SoulSplitter.UI.DarkSouls1
{
    public class DarkSouls1ViewModel : BaseViewModel
    {
        public DarkSouls1ViewModel()
        {
            AddSplitCommand = new RelayCommand(AddSplit, CanAddSplit);
        }

        public bool ResetInventoryIndices
        {
            get => _resetInventoryIndices;
            set => SetField(ref _resetInventoryIndices, value);
        }
        private bool _resetInventoryIndices = true;

        #region add/remove splits ============================================================================================================================================

        private bool CanAddSplit(object param)
        {
            if (!NewSplitTimingType.HasValue || !NewSplitType.HasValue)
            {
                return false;
            }

            switch (NewSplitType)
            {
                default:
                    throw new Exception($"{NewSplitType} not supported");

                case SplitType.Boss:
                case SplitType.Attribute:
                    return NewSplitValue != null;

                case SplitType.Position:
                    return Position != null;

                case SplitType.Flag:
                    return FlagDescription != null;

                case SplitType.Bonfire:
                    return NewSplitBonfireState != null && NewSplitBonfireState.Bonfire != null;

                case SplitType.Item:
                    return NewSplitItemState != null && NewSplitItemState.ItemType != null;
            }
        }

        private void AddSplit(object param)
        {
            object split = null;
            switch (NewSplitType)
            {
                default:
                    throw new Exception($"{NewSplitType} not supported");

                case SplitType.Boss:
                case SplitType.Attribute:
                    split = NewSplitValue;
                    break;

                case SplitType.Position:
                    split = Position;
                    break;

                case SplitType.Flag:
                    split = FlagDescription;
                    break;

                case SplitType.Bonfire:
                    split = NewSplitBonfireState;
                    break;

                case SplitType.Item:
                    split = NewSplitItemState; 
                    break;
            }
            SplitsViewModel.AddSplit(NewSplitTimingType.Value, NewSplitType.Value, split);

            NewSplitTimingType = null;
            NewSplitEnabledSplitType = false;
            NewSplitType = null;
        }


        #endregion

        #region Properties for new splits ============================================================================================================================================

        [XmlIgnore]
        public TimingType? NewSplitTimingType
        {
            get => _newSplitTimingType;
            set
            {
                SetField(ref _newSplitTimingType, value);
                NewSplitEnabledSplitType = true;
                NewSplitValue = null;
            }
        }
        private TimingType? _newSplitTimingType;

        [XmlIgnore]
        public SplitType? NewSplitType
        {
            get => _newSplitType;
            set
            {
                SetField(ref _newSplitType, value);

                switch (NewSplitType)
                {
                    case SplitType.Attribute:
                        NewSplitValue = new Splits.DarkSouls1.Attribute() { AttributeType = SoulMemory.DarkSouls1.Attribute.Vitality, Level = 10 };
                        break;

                    case SplitType.Position:
                        Position = new VectorSize() { Position = CurrentPosition.Clone() };
                        break;

                    case SplitType.Flag:
                        FlagDescription = new FlagDescription();
                        break;

                    case SplitType.Bonfire:
                        NewSplitBonfireState = new Splits.DarkSouls1.BonfireState() { State = BonfireState.Unlocked };
                        break;

                    case SplitType.Item:
                        NewSplitItemState = new ItemState();
                        break;
                }
            }
        }
        private SplitType? _newSplitType = null;

        [XmlIgnore]
        public object NewSplitValue
        {
            get => _newSplitValue;
            set => SetField(ref _newSplitValue, value);
        }
        private object _newSplitValue;

        [XmlIgnore]
        public Splits.DarkSouls1.BonfireState NewSplitBonfireState
        {
            get => _newSplitBonfireState;
            set => SetField(ref _newSplitBonfireState, value);
        }
        private Splits.DarkSouls1.BonfireState _newSplitBonfireState;

        [XmlIgnore]
        public ItemState NewSplitItemState
        {
            get => _newSplitItemState;
            set => SetField(ref _newSplitItemState, value);
        }
        private ItemState _newSplitItemState;

        #endregion
        
        #region Static UI source data ============================================================================================================================================

        public static ObservableCollection<EnumFlagViewModel<Boss>> Bosses { get; set; } = new ObservableCollection<EnumFlagViewModel<Boss>>(Enum.GetValues(typeof(Boss)).Cast<Boss>().Select(i => new EnumFlagViewModel<Boss>(i)));
        public static ObservableCollection<EnumFlagViewModel<Bonfire>> Bonfires { get; set; } = new ObservableCollection<EnumFlagViewModel<Bonfire>>(Enum.GetValues(typeof(Bonfire)).Cast<Bonfire>().Select(i => new EnumFlagViewModel<Bonfire>(i)));
        public static ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>(Item.AllItems);

        #endregion
    }
}
