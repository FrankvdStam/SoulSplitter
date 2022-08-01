using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using SoulMemory;
using SoulMemory.DarkSouls1;
using SoulMemory.Native;
using SoulSplitter.Splits.DarkSouls1;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.UI.DarkSouls1
{
    [XmlType(Namespace = "DarkSouls1")]
    public class HierarchicalTimingTypeViewModel : INotifyPropertyChanged
    {
        public TimingType TimingType
        {
            get => _timingType;
            set => SetField(ref _timingType, value);
        }
        private TimingType _timingType;
        
        public ObservableCollection<HierarchicalSplitTypeViewModel> Children { get; set; } = new ObservableCollection<HierarchicalSplitTypeViewModel>();

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

    [XmlType(Namespace = "DarkSouls1")]
    public class HierarchicalSplitTypeViewModel : INotifyPropertyChanged
    {
        [XmlIgnore]
        [NonSerialized]
        public HierarchicalTimingTypeViewModel Parent;

        public DarkSouls1SplitType SplitType
        {
            get => _splitType;
            set => SetField(ref _splitType, value);
        }
        private DarkSouls1SplitType _splitType;

        public ObservableCollection<HierarchicalSplitViewModel> Children { get; set; } = new ObservableCollection<HierarchicalSplitViewModel>();

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


    [XmlType(Namespace = "DarkSouls1")]
    [XmlInclude(typeof(Boss)), 
     XmlInclude(typeof(VectorSize)), 
     XmlInclude(typeof(Splits.DarkSouls1.Attribute)), 
     XmlInclude(typeof(FlagDescription))]
    public class HierarchicalSplitViewModel : INotifyPropertyChanged
    {
        [XmlIgnore]
        [NonSerialized]
        public HierarchicalSplitTypeViewModel Parent;

        [XmlElement(Namespace = "DarkSouls1")]
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
