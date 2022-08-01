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

namespace SoulSplitter.UI.Generic
{
    /// <summary>
    /// This object attempts to provide most of the general stuff that all souls games have
    /// Where needed, custom game implementations can be made
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
            CopyGamePositionCommand = new RelayCommand(CopyGamePosition, (o) => true);
            RemoveSplitCommand = new RelayCommand(RemoveSplit, (o) => SplitsViewModel.SelectedSplit != null);
        }

        #region Field visibility

        [XmlIgnore]
        public bool NewSplitEnabledSplitType
        {
            get => _newSplitEnabledSplitType;
            set => SetField(ref _newSplitEnabledSplitType, value);
        }
        private bool _newSplitEnabledSplitType = false;

        #endregion

        #region Relay commands
        [XmlIgnore]
        public RelayCommand AddSplitCommand
        {
            get => _addSplitCommand;
            set => SetField(ref _addSplitCommand, value);
        }
        private RelayCommand _addSplitCommand;

        [XmlIgnore]
        public RelayCommand RemoveSplitCommand
        {
            get => _removeSplitCommand;
            set => SetField(ref _removeSplitCommand, value);
        }
        private RelayCommand _removeSplitCommand;

        [XmlIgnore]
        public RelayCommand CopyGamePositionCommand
        {
            get => _copyGamePositionCommand;
            set => SetField(ref _copyGamePositionCommand, value);
        }
        private RelayCommand _copyGamePositionCommand;

        #endregion

        #region Functions

        private void CopyGamePosition(object param)
        {
            Position.Position = CurrentPosition.Clone();
        }

        private void RemoveSplit(object param)
        {
            SplitsViewModel.RemoveSplit();
        }

        #endregion

        #region generic properties

        public bool StartAutomatically
        {
            get => _startAutomatically;
            set => SetField(ref _startAutomatically, value);
        }
        private bool _startAutomatically = true;

        public SplitsViewModel SplitsViewModel
        {
            get => _splitsViewModel;
            set => SetField(ref _splitsViewModel, value);
        }
        private SplitsViewModel _splitsViewModel =  new SplitsViewModel();
        
        [XmlIgnore]
        public VectorSize Position
        {
            get => _position;
            set => SetField(ref _position, value);
        }
        private VectorSize _position;

        [XmlIgnore]
        public Vector3f CurrentPosition
        {
            get => _currentPosition;
            set => SetField(ref _currentPosition, value);
        }
        private Vector3f _currentPosition = new Vector3f(0f, 0f, 0f);

        [XmlIgnore]
        public FlagDescription FlagDescription
        {
            get => _flagDescription;
            set => SetField(ref _flagDescription, value);
        }
        private FlagDescription _flagDescription;

        #endregion

        #region INotifyPropertyChanged ============================================================================================================================================

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
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
