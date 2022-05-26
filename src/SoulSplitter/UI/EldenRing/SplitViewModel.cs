using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SoulMemory.EldenRing;
using SoulSplitter.Splits.EldenRing;

namespace SoulSplitter.UI.EldenRing
{
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

    public class HierarchicalSplitTypeViewModel : INotifyPropertyChanged
    {
        [XmlIgnore]
        [NonSerialized]
        public HierarchicalTimingTypeViewModel Parent;

        public EldenRingSplitType EldenRingSplitType
        {
            get => _eldenRingSplitType;
            set => SetField(ref _eldenRingSplitType, value);
        }
        private EldenRingSplitType _eldenRingSplitType;

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

    [XmlInclude(typeof(Boss))]
    [XmlInclude(typeof(Grace))]
    [XmlInclude(typeof(ItemPickup))]
    [XmlInclude(typeof(uint))]
    [XmlInclude(typeof(Item))]
    [XmlInclude(typeof(Position))]
    public class HierarchicalSplitViewModel : INotifyPropertyChanged
    {
        [XmlIgnore]
        [NonSerialized]
        public HierarchicalSplitTypeViewModel Parent;

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
