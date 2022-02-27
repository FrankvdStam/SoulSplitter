using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SoulSplitter.Splits;
using SoulMemory.DarkSouls2;
using SoulSplitter.Splits.DarkSouls2;

namespace SoulSplitter.UI
{
    public class SplitViewModel : INotifyPropertyChanged
    {
        public static ObservableCollection<SplitType> SplitTypesItemsSource { get; set; } = new ObservableCollection<SplitType>(Enum.GetValues(typeof(SplitType)).Cast<SplitType>());
        public static ObservableCollection<BossType> BossTypeItemsSource { get; set; } = new ObservableCollection<BossType>(Enum.GetValues(typeof(BossType)).Cast<BossType>());
        public static ObservableCollection<TimingType> TimingTypeItemsSource { get; set; } = new ObservableCollection<TimingType>(Enum.GetValues(typeof(TimingType)).Cast<TimingType>());


        public SplitViewModel()
        {
            BossSplit = new BossSplit();
        }

        public SplitViewModel(ISplit split)
        {
            //Changing the splittype will default initialize the appropriate split type. Using the private field won't raise a property changed event.
            _splitType = split.SplitType;
            _split = split;
        }
        

        private ISplit _split;
        public BossSplit BossSplit
        {
            get
            {
                if (SplitType == SplitType.Boss)
                {
                    return (BossSplit)_split;
                }
                return null;
            }
            set
            {
                _split = value;
                OnPropertyChanged();
            }
        }

        public ItemSplit ItemSplit
        {
            get
            {
                if (SplitType == SplitType.Item)
                {
                    return (ItemSplit)_split;
                }
                return null;
            }
            set
            {
                _split = value;
                OnPropertyChanged();
            }
        }

        public BoxSplit BoxSplit
        {
            get
            {
                if (SplitType == SplitType.Box)
                {
                    return (BoxSplit)_split;
                }
                return null;
            }
            set
            {
                _split = value;
                OnPropertyChanged();
            }
        }


        
        private SplitType _splitType;
        public SplitType SplitType
        {
            get => _splitType;
            set
            {
                _splitType = value;

                switch (_splitType)
                {
                    case SplitType.Boss:
                        BossSplit = new BossSplit();
                        break;

                    case SplitType.Item:
                        ItemSplit = new ItemSplit();
                        break;

                    case SplitType.Box:
                        BoxSplit = new BoxSplit();
                        break;
                }

                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public override string ToString()
        {
            return _split?.ToString() ?? "No split";
        }
    }
}
