using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using SoulMemory;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.UI.Generic
{
    public class SplitsViewModel : INotifyPropertyChanged
    {
        public void AddSplit(TimingType timingType, SplitType splitType, object split)
        {
            var splitTimingViewModel = Splits.FirstOrDefault(i => i.TimingType == timingType);
            if (splitTimingViewModel == null)
            {
                splitTimingViewModel = new SplitTimingViewModel() { TimingType = timingType };
                Splits.Add(splitTimingViewModel);
            }

            var splitTypeViewModel = splitTimingViewModel.Children.FirstOrDefault(i => i.SplitType == splitType);
            if (splitTypeViewModel == null)
            {
                splitTypeViewModel = new SplitTypeViewModel() { SplitType = splitType, Parent = splitTimingViewModel };
                splitTimingViewModel.Children.Add(splitTypeViewModel);
            }

            if (splitTypeViewModel.Children.All(i => i.Split.ToString() != split.ToString()))
            {
                splitTypeViewModel.Children.Add(new SplitViewModel() { Split = split, Parent = splitTypeViewModel });
            }
        }

        public void RemoveSplit()
        {
            if (SelectedSplit != null)
            {
                var parent = SelectedSplit.Parent;
                parent.Children.Remove(SelectedSplit);
                if (parent.Children.Count <= 0)
                {
                    var nextParent = parent.Parent;
                    nextParent.Children.Remove(parent);
                    if (nextParent.Children.Count <= 0)
                    {
                        Splits.Remove(nextParent);
                    }
                }

                SelectedSplit = null;
            }
        }

        public void RestoreHierarchy()
        {
            //When serializing the model, we can't serialize the parent relation, because that would be a circular reference. Instead, parents are not serialized.
            //After deserializing, the parent relations must be restored.

            foreach (var timingType in Splits)
            {
                foreach (var splitType in timingType.Children)
                {
                    splitType.Parent = timingType;
                    foreach (var split in splitType.Children)
                    {
                        split.Parent = splitType;
                    }
                }
            }
        }

        [XmlIgnore]
        public SplitViewModel SelectedSplit
        {
            get => _selectedSplit;
            set => SetField(ref _selectedSplit, value);
        }
        private SplitViewModel _selectedSplit;


        public ObservableCollection<SplitTimingViewModel> Splits { get; set; } = new ObservableCollection<SplitTimingViewModel>();

        #region INotifyPropertyChanged

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion
    }

    public class SplitTimingViewModel : INotifyPropertyChanged
    {
        public TimingType TimingType
        {
            get => _timingType;
            set => SetField(ref _timingType, value);
        }
        private TimingType _timingType;
        
        public ObservableCollection<SplitTypeViewModel> Children { get; set; } = new ObservableCollection<SplitTypeViewModel>();

        #region INotifyPropertyChanged

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion
    }
    
    public class SplitTypeViewModel : INotifyPropertyChanged
    {
        [XmlIgnore]
        [NonSerialized]
        public SplitTimingViewModel Parent;

        public SplitType SplitType
        {
            get => _splitType;
            set => SetField(ref _splitType, value);
        }
        private SplitType _splitType;


        public ObservableCollection<SplitViewModel> Children { get; set; } = new ObservableCollection<SplitViewModel>();

        #region INotifyPropertyChanged

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion
    }

    [XmlInclude(typeof(VectorSize)),
     XmlInclude(typeof(FlagDescription)),
     XmlInclude(typeof(Splits.DarkSouls1.Attribute))]
    public class SplitViewModel : INotifyPropertyChanged
    {
        [XmlIgnore]
        [NonSerialized]
        public SplitTypeViewModel Parent;
        
        public object Split
        {
            get => _split;
            set => SetField(ref _split, value);
        }
        private object _split;

        #region INotifyPropertyChanged

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion
    }
}
