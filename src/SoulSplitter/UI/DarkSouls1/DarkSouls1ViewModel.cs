using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SoulMemory;
using SoulMemory.DarkSouls1;
using SoulSplitter.Splits.DarkSouls1;
using SoulSplitter.UI.Generic;
using Attribute = System.Attribute;

namespace SoulSplitter.UI.DarkSouls1
{
    public class DarkSouls1ViewModel : BaseViewModel
    {
        public DarkSouls1ViewModel()
        {
            AddSplitCommand = new RelayCommand(AddSplit, CanAddSplit);
        }

        public bool ResetIndices
        {
            get => _resetIndices;
            set => SetField(ref _resetIndices, value);
        }
        private bool _resetIndices;

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

                if (NewSplitType == SplitType.Attribute)
                {
                    NewSplitValue = new Splits.DarkSouls1.Attribute() { AttributeType = SoulMemory.DarkSouls1.Attribute.Vitality, Level = 10};
                }

                if (NewSplitType == SplitType.Position)
                {
                    Position = new VectorSize() { Position = CurrentPosition.Clone() };
                }

                if (NewSplitType == SplitType.Flag)
                {
                    FlagDescription = new FlagDescription();
                }
            }
        }
        private SplitType? _newSplitType = null;

        public object NewSplitValue
        {
            get => _newSplitValue;
            set => SetField(ref _newSplitValue, value);
        }
        private object _newSplitValue;

        #endregion
        
        #region Static UI source data ============================================================================================================================================

        public static ObservableCollection<EnumFlagViewModel<Boss>> Bosses { get; set; } = new ObservableCollection<EnumFlagViewModel<Boss>>(Enum.GetValues(typeof(Boss)).Cast<Boss>().Select(i => new EnumFlagViewModel<Boss>(i)));
     
        #endregion
    }
}
