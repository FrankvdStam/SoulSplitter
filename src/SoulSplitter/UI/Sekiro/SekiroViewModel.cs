using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using SoulMemory;
using SoulMemory.Sekiro;
using SoulSplitter.Splits.Sekiro;
using SoulSplitter.UI.Sekiro;

namespace SoulSplitter.UI.Sekiro
{
    public class SekiroViewModel : INotifyPropertyChanged
    {
        public bool StartAutomatically
        {
            get => _startAutomatically;
            set => SetField(ref _startAutomatically, value);
        }
        private bool _startAutomatically = true;
        
        public bool OverwriteIgtOnStart
        {
            get => _overwriteIgtOnStart;
            set => SetField(ref _overwriteIgtOnStart, value);
        }
        private bool _overwriteIgtOnStart = false;

        [XmlIgnore]
        public Vector3f CurrentPosition
        {
            get => _currentPosition;
            set => SetField(ref _currentPosition, value);
        }
        private Vector3f _currentPosition = new Vector3f(0f,0f,0f);


        #region add/remove splits ============================================================================================================================================
        public void AddSplit()
        {
            if (NewSplitTimingType == null ||
                NewSplitType == null ||
                NewSplitValue == null)
            {
                return;
            }

            var hierarchicalTimingType = Splits.FirstOrDefault(i => i.TimingType == NewSplitTimingType);
            if (hierarchicalTimingType == null)
            {
                hierarchicalTimingType = new HierarchicalTimingTypeViewModel() { TimingType = NewSplitTimingType.Value };
                Splits.Add(hierarchicalTimingType);
            }

            var hierarchicalSplitType = hierarchicalTimingType.Children.FirstOrDefault(i => i.SplitType == NewSplitType);
            if (hierarchicalSplitType == null)
            {
                hierarchicalSplitType = new HierarchicalSplitTypeViewModel() { SplitType = NewSplitType.Value, Parent = hierarchicalTimingType };
                hierarchicalTimingType.Children.Add(hierarchicalSplitType);
            }

            switch (NewSplitType)
            {
                default:
                    throw new Exception($"split type not supported: {NewSplitType}");

                case SplitType.Boss:
                    var boss = (Boss)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => (Boss)i.Split != boss))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = boss, Parent = hierarchicalSplitType });
                    }
                    break;

                case SplitType.Idol:
                    var idol = (Idol)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => (Idol)i.Split != idol))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = idol, Parent = hierarchicalSplitType });
                    }
                    break;

                case SplitType.Position:
                    var position = (Vector3f)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => ((Vector3f)i.Split).ToString() != position.ToString()))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = position, Parent = hierarchicalSplitType });
                    }
                    break;

                case SplitType.Flag:
                    var flag = (uint)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => (uint)i.Split != flag))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = flag, Parent = hierarchicalSplitType });
                    }
                    break;
            }

            NewSplitTimingType = null;
            NewSplitType = null;
            NewSplitValue = null;
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

        
        public ObservableCollection<HierarchicalTimingTypeViewModel> Splits { get; set; } = new ObservableCollection<HierarchicalTimingTypeViewModel>();
        #endregion

        #region Properties for new splits ============================================================================================================================================

        [XmlIgnore]
        public TimingType? NewSplitTimingType
        {
            get => _newSplitTimingType;
            set
            {
                SetField(ref _newSplitTimingType, value);
                NewSplitTypeEnabled = true;
            }
        }
        private TimingType? _newSplitTimingType = null;

        [XmlIgnore]
        public SplitType? NewSplitType
        {
            get => _newSplitType;
            set
            {
                NewSplitBossEnabled = false;
                NewSplitIdolEnabled = false;
                NewSplitPositionEnabled = false;
                NewSplitFlagEnabled = false;

                SetField(ref _newSplitType, value);
                switch (NewSplitType)
                {
                    case null:
                        break;

                    case SplitType.Boss:
                        NewSplitBossEnabled = true;
                        break;

                    case SplitType.Idol:
                        NewSplitIdolEnabled = true;
                        break;

                    case SplitType.Position:
                        NewSplitPositionEnabled = true;
                        NewSplitValue = new Vector3f(CurrentPosition.X, CurrentPosition.Y, CurrentPosition.Z);
                        break;

                    case SplitType.Flag:
                        NewSplitFlagEnabled = true;
                        break;

                    default: 
                        throw new Exception($"Unsupported split type: {NewSplitType}");
                }
            }
        }
        private SplitType? _newSplitType = null;

        [XmlIgnore]
        public object NewSplitValue
        {
            get => _newSplitValue;
            set
            {
                SetField(ref _newSplitValue, value);
                NewSplitAddEnabled = NewSplitValue != null;
            }
        }
        private object _newSplitValue = null;
        
        [XmlIgnore]
        public bool NewSplitTypeEnabled
        {
            get => _newSplitTypeEnabled;
            set => SetField(ref _newSplitTypeEnabled, value);
        }
        private bool _newSplitTypeEnabled = false;

        [XmlIgnore]
        public bool NewSplitBossEnabled
        {
            get => _newSplitBossEnabled;
            set => SetField(ref _newSplitBossEnabled, value);
        }
        private bool _newSplitBossEnabled = false;

        [XmlIgnore]
        public bool NewSplitIdolEnabled
        {
            get => _newSplitIdolEnabled;
            set => SetField(ref _newSplitIdolEnabled, value);
        }
        private bool _newSplitIdolEnabled = false;

        [XmlIgnore]
        public bool NewSplitPositionEnabled
        {
            get => _newSplitPositionEnabled;
            set => SetField(ref _newSplitPositionEnabled, value);
        }
        private bool _newSplitPositionEnabled = false;

        [XmlIgnore]
        public bool NewSplitFlagEnabled
        {
            get => _newSplitFlagEnabled;
            set => SetField(ref _newSplitFlagEnabled, value);
        }
        private bool _newSplitFlagEnabled = false;

        [XmlIgnore]
        public bool NewSplitAddEnabled
        {
            get => _newSplitAddEnabled;
            set => SetField(ref _newSplitAddEnabled, value);
        }
        private bool _newSplitAddEnabled = false;

        [XmlIgnore]
        public bool RemoveSplitEnabled
        {
            get => _removeSplitEnabled;
            set => SetField(ref _removeSplitEnabled, value);
        }
        private bool _removeSplitEnabled = false;

        [XmlIgnore]
        public HierarchicalSplitViewModel SelectedSplit
        {
            get => _selectedSplit;
            set
            {
                SetField(ref _selectedSplit, value);
                RemoveSplitEnabled = SelectedSplit != null;
            }
        }
        private HierarchicalSplitViewModel _selectedSplit = null;

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
                    foreach (var split in splitType.Children)
                    {
                        split.Parent = splitType;
                    }
                }
            }
        }

        #endregion

        #region Static UI source data ============================================================================================================================================

        public static ObservableCollection<EnumFlagViewModel<Boss>> Bosses { get; set; } = new ObservableCollection<EnumFlagViewModel<Boss>>(Enum.GetValues(typeof(Boss)).Cast<Boss>().Select(i => new EnumFlagViewModel<Boss>(i)));
        public static ObservableCollection<EnumFlagViewModel<Idol>> Idols { get; set; } = new ObservableCollection<EnumFlagViewModel<Idol>>(Enum.GetValues(typeof(Idol)).Cast<Idol>().Select(i => new EnumFlagViewModel<Idol>(i)));
        
        #endregion

        #region INotifyPropertyChanged ============================================================================================================================================

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
