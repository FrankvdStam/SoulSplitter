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

using SoulMemory.Enums;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using SoulMemory.Games.DarkSouls1;
using SoulSplitter.Utils;

namespace SoulSplitter.Ui.ViewModels.MainViewModel;

public partial class MainViewModel
{
    public string Version { get => VersionHelper.Version.ToString(); set { } }

    public Language Language
    {
        get => _language;
        set
        {
            SetField(ref _language, value);
            _languageManager.LoadLanguage(_language);
        }
    }
    private Language _language = Language.English;

    public Game? SelectedGame
    {
        get => _selectedGame;
        set
        {
            SetField(ref _selectedGame, value);
            OnSelectedGameChanged();
        }
    }
    private Game? _selectedGame;

    public bool IsGameSelected
    {
        get => _isGameSelected;
        set => SetField(ref _isGameSelected, value);
    }
    private bool _isGameSelected;

    public TimingType? SelectedTimingType
    {
        get => _selectedTimingType;
        set => SetField(ref _selectedTimingType, value);
    }
    private TimingType? _selectedTimingType;

    public SplitType? SelectedSplitType
    {
        get => _selectedSplitType;
        set
        {
            SetField(ref _selectedSplitType, value);
            OnSelectedSplitTypeChanged();
        }
    }

    private SplitType? _selectedSplitType;

    public string SplitDescription
    {
        get => _splitDescription;
        set => SetField(ref _splitDescription, value);
    }
    private string _splitDescription = null!;

    public bool IsAddSplitPopupOpen
    {
        get => _isAddSplitPopupOpen;
        set => SetField(ref _isAddSplitPopupOpen, value);
    }
    private bool _isAddSplitPopupOpen = false;

    public int SelectedNewGamePlusLevel
    {
        get => _selectedNewGamePlusLevel;
        set => SetField(ref _selectedNewGamePlusLevel, value);
    }
    private int _selectedNewGamePlusLevel = 0;

    public Enum? SelectedEventFlag
    {
        get => _selectedEventFlag;
        set => SetField(ref _selectedEventFlag, value);
    }
    private Enum? _selectedEventFlag;

    public uint? Flag
    {
        get => _flag;
        set => SetField(ref _flag, value);
    }
    private uint? _flag;

    public Type EventFlagType
    {
        get => _eventFlagType;
        set => SetField(ref _eventFlagType, value);
    }
    private Type _eventFlagType = null!;
    
    public SplitViewModel? SelectedSplit
    {
        get => _selectedSplit;
        set
        {
            SetField(ref _selectedSplit, value);
            OnSelectedSplitChanged();
        }
    }

    private SplitViewModel? _selectedSplit;

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
    private bool _overwriteIgtOnStart;

    public DropModType DropModType
    {
        get => _dropModType;
        set => SetField(ref _dropModType, value);
    }
    private DropModType _dropModType = DropModType.None;

    public DarkSouls1BonfireViewModel? DarkSouls1BonfireViewModel
    {
        get => _darkSouls1BonfireViewModel;
        set => SetField(ref _darkSouls1BonfireViewModel, value);
    }
    private DarkSouls1BonfireViewModel? _darkSouls1BonfireViewModel;

    public ObservableCollection<TimingType> TimingTypes { get; set; } = new ObservableCollection<TimingType>();
    public ObservableCollection<SplitType> SplitTypes { get; set; } = new ObservableCollection<SplitType>();
    public ObservableCollection<SplitViewModel> Splits { get; set; } = new ObservableCollection<SplitViewModel>();
    public ObservableCollection<int> NewGamePlusLevels { get; set; } = new ObservableCollection<int>(Enumerable.Range(0, 100));
}
