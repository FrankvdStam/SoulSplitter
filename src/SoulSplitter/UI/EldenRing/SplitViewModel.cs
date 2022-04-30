﻿using System;
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

        public ObservableCollection<HierarchicalBossViewModel> Children { get; set; } = new ObservableCollection<HierarchicalBossViewModel>();

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

    public class HierarchicalBossViewModel : INotifyPropertyChanged
    {
        [XmlIgnore]
        [NonSerialized]
        public HierarchicalSplitTypeViewModel Parent;

        public Boss Boss
        {
            get => _boss;
            set => SetField(ref _boss, value);
        }
        private Boss _boss;


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






    /*

    public class SplitViewModel : INotifyPropertyChanged
    {
        public TimingType TimingType
        {
            get => _timingType;
            set => SetField(ref _timingType, value);
        }
        private TimingType _timingType;

        public SplitType SplitType
        {
            get => _splitType;
            set => SetField(ref _splitType, value);
        }
        private SplitType _splitType;

        public Boss? Boss
        {
            get => _boss;
            set => SetField(ref _boss, value);
        }
        private Boss? _boss;
        
        public bool Selected
        {
            get => _selected;
            set => SetField(ref _selected, value);
        }
        private bool _selected;



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
    */
}