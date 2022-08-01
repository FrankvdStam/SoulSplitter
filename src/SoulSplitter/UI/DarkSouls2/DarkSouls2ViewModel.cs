using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using SoulMemory;
using SoulMemory.DarkSouls2;
using SoulSplitter.Splits.DarkSouls2;
using SoulSplitter.UI.Generic;
using Attribute = SoulSplitter.Splits.DarkSouls2.Attribute;

namespace SoulSplitter.UI.DarkSouls2
{
    public class DarkSouls2ViewModel : INotifyPropertyChanged
    {
        public bool StartAutomatically
        {
            get => _startAutomatically;
            set => SetField(ref _startAutomatically, value);
        }
        private bool _startAutomatically = true;

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

                case DarkSouls2SplitType.Position:
                    var position = (Vector3f)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => ((Vector3f)i.Split).ToString() != position.ToString()))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = position, Parent = hierarchicalSplitType });
                    }
                    break;

                case DarkSouls2SplitType.BossKill:
                    var bossKill = (BossKill)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => ((BossKill)i.Split).ToString() != bossKill.ToString()))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = bossKill, Parent = hierarchicalSplitType });
                    }
                    break;

                case DarkSouls2SplitType.Attribute:
                    var attribute = (Attribute)NewSplitValue;
                    if (hierarchicalSplitType.Children.All(i => ((Attribute)i.Split).ToString() != attribute.ToString()))
                    {
                        hierarchicalSplitType.Children.Add(new HierarchicalSplitViewModel() { Split = attribute, Parent = hierarchicalSplitType });
                    }
                    break;

                case DarkSouls2SplitType.Flag:
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
        public DarkSouls2SplitType? NewSplitType
        {
            get => _newSplitType;
            set
            {
                NewSplitPositionEnabled = false;
                NewSplitBossKillEnabled = false;
                NewSplitAttributeEnabled = false;
                NewSplitFlagEnabled = false;

                SetField(ref _newSplitType, value);
                switch (NewSplitType)
                {
                    case null:
                        break;

                    case DarkSouls2SplitType.Position:
                        NewSplitPositionEnabled = true;
                        NewSplitValue = new Vector3f(CurrentPosition.X, CurrentPosition.Y, CurrentPosition.Z);
                        break;

                    case DarkSouls2SplitType.BossKill:
                        NewSplitBossKillEnabled = true;
                        NewSplitValue = new BossKill();
                        break;

                    case DarkSouls2SplitType.Attribute:
                        NewSplitAttributeEnabled = true;
                        NewSplitValue = new Splits.DarkSouls2.Attribute();
                        break;

                    case DarkSouls2SplitType.Flag:
                        NewSplitFlagEnabled = true;
                        break;

                    default: 
                        throw new Exception($"Unsupported split type: {NewSplitType}");
                }
            }
        }
        private DarkSouls2SplitType? _newSplitType = null;

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
        public bool NewSplitPositionEnabled
        {
            get => _newSplitPositionEnabled;
            set => SetField(ref _newSplitPositionEnabled, value);
        }
        private bool _newSplitPositionEnabled = false;

        [XmlIgnore]
        public bool NewSplitBossKillEnabled
        {
            get => _newSplitBossKillEnabled;
            set => SetField(ref _newSplitBossKillEnabled, value);
        }
        private bool _newSplitBossKillEnabled = false;

        [XmlIgnore]
        public bool NewSplitAttributeEnabled
        {
            get => _newSplitAttributeEnabled;
            set => SetField(ref _newSplitAttributeEnabled, value);
        }
        private bool _newSplitAttributeEnabled = false;

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

        public static ObservableCollection<EnumFlagViewModel<BossType>> Bosses { get; set; } = new ObservableCollection<EnumFlagViewModel<BossType>>(Enum.GetValues(typeof(BossType)).Cast<BossType>().Select(i => new EnumFlagViewModel<BossType>(i)));


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
