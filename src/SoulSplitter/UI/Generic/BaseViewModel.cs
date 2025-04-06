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

using System.ComponentModel;
using System.Xml.Serialization;
using SoulMemory;

namespace SoulSplitter.UI.Generic;

/// <summary>
/// This object attempts to provide most of the general stuff that all souls games have
/// Where needed, custom game implementations can be made
/// </summary>
public class BaseViewModel : ICustomNotifyPropertyChanged
{
    public BaseViewModel()
    {
        CopyGamePositionCommand = new RelayCommand(CopyGamePosition, (_) => true);
        RemoveSplitCommand = new RelayCommand(RemoveSplit, (_) => SplitsViewModel.SelectedSplit != null);
    }
    
    #region Field visibility

    #region new splits ============================================================================================================================================

    [XmlIgnore]
    public SplitType? NewSplitType
    {
        get => _newSplitType;
        set
        {
            this.SetField(ref _newSplitType, value);

            switch (NewSplitType)
            {
                case SplitType.Position:
                    Position = new VectorSize() { Position = CurrentPosition.Clone() };
                    break;

                case SplitType.Flag:
                    FlagDescription = new FlagDescription();
                    break;
            }
        }
    }
    private SplitType? _newSplitType;

    [XmlIgnore]
    public TimingType? NewSplitTimingType
    {
        get => _newSplitTimingType;
        set
        {
            this.SetField(ref _newSplitTimingType, value);
            NewSplitEnabledSplitType = true;
            NewSplitValue = null;
        }
    }
    private TimingType? _newSplitTimingType;

    [XmlIgnore]
    public object? NewSplitValue
    {
        get => _newSplitValue;
        set => this.SetField(ref _newSplitValue, value);
    }
    private object? _newSplitValue;
    #endregion

    [XmlIgnore]
    public bool NewSplitEnabledSplitType
    {
        get => _newSplitEnabledSplitType;
        set => this.SetField(ref _newSplitEnabledSplitType, value);
    }
    private bool _newSplitEnabledSplitType;

    #endregion

    #region Relay commands

    [XmlIgnore] 
    public RelayCommand AddSplitCommand { get; set; } = null!;

    [XmlIgnore]
    public RelayCommand RemoveSplitCommand { get; set; }

    [XmlIgnore]
    public RelayCommand CopyGamePositionCommand { get; set; }

    #endregion

    #region Functions

    private void CopyGamePosition()
    {
        if (Position != null)
        {
            Position.Position = CurrentPosition.Clone();
        }
    }

    private void RemoveSplit()
    {
        SplitsViewModel.RemoveSplit();
    }

    #endregion

    #region generic properties

    public bool StartAutomatically
    {
        get => _startAutomatically;
        set => this.SetField(ref _startAutomatically, value);
    }
    private bool _startAutomatically = true;

    public SplitsViewModel SplitsViewModel
    {
        get => _splitsViewModel;
        set => this.SetField(ref _splitsViewModel, value);
    }
    private SplitsViewModel _splitsViewModel =  new();
    
    [XmlIgnore]
    public VectorSize? Position
    {
        get => _position;
        set => this.SetField(ref _position, value);
    }
    private VectorSize? _position;

    [XmlIgnore]
    public Vector3f CurrentPosition
    {
        get => _currentPosition;
        set => this.SetField(ref _currentPosition, value);
    }
    private Vector3f _currentPosition = new(0f, 0f, 0f);

    [XmlIgnore]
    public FlagDescription? FlagDescription
    {
        get => _flagDescription;
        set => this.SetField(ref _flagDescription, value);
    }
    private FlagDescription? _flagDescription;

    #endregion

    #region ICustomNotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void InvokePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
