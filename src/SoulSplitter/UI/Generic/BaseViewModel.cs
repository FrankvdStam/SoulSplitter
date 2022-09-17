// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
