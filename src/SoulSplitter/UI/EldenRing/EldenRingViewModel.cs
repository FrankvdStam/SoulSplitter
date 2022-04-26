using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using SoulMemory.EldenRing;
using SoulSplitter.Splits.EldenRing;

namespace SoulSplitter.UI.EldenRing
{
    public class EldenRingViewModel : INotifyPropertyChanged
    {
        public EldenRingViewModel()
        {
            //AddSplit(TimingType.OnLoading, EldenRingSplitType.Boss, Boss.BolsCarianKnight);
            //AddSplit(TimingType.OnLoading, EldenRingSplitType.Boss, Boss.AncestralSpirit);
            //AddSplit(TimingType.Immediate, EldenRingSplitType.Boss, Boss.GlintstoneDragonSmarag);
            //AddSplit(TimingType.Immediate, EldenRingSplitType.Boss, Boss.BlackBladeKindredBestialSanctum);
            //AddSplit(TimingType.Immediate, EldenRingSplitType.Boss, Boss.CommanderNiall);
        }



        private bool _startAutomatically = true;
        public bool StartAutomatically
        {
            get => _startAutomatically;
            set => SetField(ref _startAutomatically, value);
        }


        private bool _noLogo = false;
        public bool NoLogo
        {
            get => _noLogo;
            set => SetField(ref _noLogo, value);
        }


        #region Adding new splits ================================================================================================================

        public TimingType? NewSplitTimingType
        {
            get => _newSplitTimingType;
            set
            {
                SetField(ref _newSplitTimingType, value);
                EnabledSplitType = NewSplitTimingType.HasValue;
            }
        }

        private TimingType? _newSplitTimingType;
        
        public bool EnabledSplitType
        {
            get => _enabledSplitType;
            set => SetField(ref _enabledSplitType, value);
        }
        private bool _enabledSplitType = false;

        public EldenRingSplitType? NewSplitType
        {
            get => _newSplitType;
            set
            {
                SetField(ref _newSplitType, value);
                EnabledBossSplit = NewSplitType.HasValue && NewSplitType.Value == EldenRingSplitType.Boss;
            }
        }

        private EldenRingSplitType? _newSplitType;

        public bool EnabledBossSplit
        {
            get => _enabledBossSplit;
            set => SetField(ref _enabledBossSplit, value);
        }
        private bool _enabledBossSplit;


        public Boss? NewSplitBoss
        {
            get => _newSplitBoss;
            set
            {
                SetField(ref _newSplitBoss, value);
                EnabledAddSplit = NewSplitBoss.HasValue;
            }
        }

        private Boss? _newSplitBoss;

        public bool EnabledAddSplit
        {
            get => _enabledAddSplit;
            set => SetField(ref _enabledAddSplit, value);
        }
        private bool _enabledAddSplit;


        public void AddSplit()
        {
            AddSplit(NewSplitTimingType.Value, NewSplitType.Value, NewSplitBoss.Value);

            NewSplitTimingType = null;
            NewSplitType = null;
            NewSplitBoss = null;
        }

        private void AddSplit(TimingType timingType, EldenRingSplitType eldenRingSplitType, Boss boss)
        {
            var hierarchicalTimingType = Splits.FirstOrDefault(i => i.TimingType == timingType);
            if (hierarchicalTimingType == null)
            {
                hierarchicalTimingType = new HierarchicalTimingTypeViewModel() { TimingType = timingType };
                Splits.Add(hierarchicalTimingType);
            }

            var hierarchicalSplitType = hierarchicalTimingType.Children.FirstOrDefault(i => i.EldenRingSplitType == eldenRingSplitType);
            if (hierarchicalSplitType == null)
            {
                hierarchicalSplitType = new HierarchicalSplitTypeViewModel() { EldenRingSplitType = eldenRingSplitType, Parent = hierarchicalTimingType };
                hierarchicalTimingType.Children.Add(hierarchicalSplitType);
            }

            switch (eldenRingSplitType)
            {
                case EldenRingSplitType.Boss:
                    if (!hierarchicalSplitType.Children.Any(i => i.Boss == boss))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalBossViewModel() { Boss = boss, Parent = hierarchicalSplitType });
                    }
                    break;
            }
        }



        #endregion

        #region Removing splits
        public bool EnabledRemoveSplit
        {
            get => _enabledRemoveSplit;
            set => SetField(ref _enabledRemoveSplit, value);
        }
        private bool _enabledRemoveSplit;

        public object SelectedSplit
        {
            get => _selectedSplit;
            set
            {
                SetField(ref _selectedSplit, value);
                EnabledRemoveSplit = SelectedSplit != null;
            }
        }
        private object _selectedSplit = null;
        
        public void RemoveSplit()
        {
            if (SelectedSplit != null)
            {
                if (SelectedSplit is HierarchicalBossViewModel b)
                {
                    var parent = b.Parent;
                    parent.Children.Remove(b);
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
        }
        #endregion

        #region Splits hierarchy

        public void RestoreHierarchy()
        {
            //When serializing the model, we can't serialize the parent relation, because that would be a circular reference. Instead, parent's are not serialized.
            //After deserializing, the parent relations must be restored.

            foreach (var timingType in Splits)
            {
                foreach (var splitType in timingType.Children)
                {
                    splitType.Parent = timingType;
                    foreach (var boss in splitType.Children)
                    {
                        boss.Parent = splitType;
                    }
                }
            }
        }

        #endregion


        public ObservableCollection<HierarchicalTimingTypeViewModel> Splits { get; set; }= new ObservableCollection<HierarchicalTimingTypeViewModel>();





        //source lists
        public static ObservableCollection<Boss> Bosses { get; set; } = new ObservableCollection<Boss>(Enum.GetValues(typeof(Boss)).Cast<Boss>());
        
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

    public class TimingSplitsCollection : INotifyPropertyChanged
    {
        public TimingType? TimingType
        {
            get => _timingType;
            set => SetField(ref _timingType, value);
        }
        private TimingType? _timingType;



        //public TimingType TimingType;
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
