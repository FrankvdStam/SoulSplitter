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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using SoulSplitterUIv2.DependencyInjection;
using SoulMemory.Enums;
using SoulSplitterUIv2.Resources;

namespace SoulSplitterUIv2.Ui.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly ILanguageManager _languageManager;

        /// <summary>
        /// Parameterless constructor for serializing
        /// </summary>
        public MainViewModel() : this(Extensions.ServiceProvider.GetService<ILanguageManager>())
        {

        }

        public MainViewModel(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
            AddSplitCommand = new RelayCommand.RelayCommand(AddSplit, CanAddSplit);
        }


        private void AddSplit(object param)
        {
            //IsAddSplitPopupOpen = false;
            Splits.Add(new SplitViewModel(SelectedGame.Value, SelectedNewGamePlusLevel, SelectedTimingType.Value, SelectedSplitType.Value, SelectedEventFlag, SplitDescription));
        }

        private bool CanAddSplit(object param)
        {
            return
                SelectedGame != null &&
                SelectedTimingType != null &&
                SelectedSplitType != null &&
                SelectedEventFlag != null;
        }
        
        #region UI bindable properties
        public string Version { get; set; } = "2";

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

        //public Boss? SelectedBoss
        //{
        //    get => _selectedBoss;
        //    set => SetField(ref _selectedBoss, value);
        //}
        //private Boss? _selectedBoss;

        public string SplitDescription
        {
            get => _splitDescription;
            set => SetField(ref _splitDescription, value);
        }
        private string _splitDescription;

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

        public Enum SelectedEventFlag
        {
            get => _selectedEventFlag;
            set => SetField(ref _selectedEventFlag, value);
        }
        private Enum _selectedEventFlag;

        public Type SelectedEventFlagType
        {
            get => _selectedEventFlagType;
            set => SetField(ref _selectedEventFlagType, value);
        }
        private Type _selectedEventFlagType;

        public RelayCommand.RelayCommand AddSplitCommand { get; set; }

        public RelayCommand.RelayCommand RemoveSplitCommand { get; set; }
        
        public RelayCommand.RelayCommand SerializeCommand { get; set; }

        public ObservableCollection<TimingType> TimingTypes { get; set; } = new ObservableCollection<TimingType>();
        public ObservableCollection<SplitType> SplitTypes { get; set; } = new ObservableCollection<SplitType>();
        public ObservableCollection<SplitViewModel> Splits { get; set; } = new ObservableCollection<SplitViewModel>();
        public ObservableCollection<int> NewGamePlusLevels { get; set; } = new ObservableCollection<int>(Enumerable.Range(0, 100));

        #endregion
    
        #region UI logic

        private void OnSelectedGameChanged()
        {
            IsGameSelected = SelectedGame != null;
            SelectedTimingType = null;
            SelectedSplitType = null;
            SelectedEventFlag = null;

            TimingTypes.Clear();
            SplitTypes.Clear();

            if (IsGameSelected)
            {
                TimingTypes.AddRange(SplitConfiguration.GetSupportedTimingTypes(SelectedGame!.Value));
                SplitTypes.AddRange(SplitConfiguration.GetSupportedSplitTypes(SelectedGame!.Value));
            }
        }

        private void OnSelectedSplitTypeChanged()
        {
            SelectedEventFlag = null;
            if (SelectedSplitType != null)
            {
                SelectedEventFlagType = SplitConfiguration.GetSplitType(SelectedGame!.Value, SelectedSplitType!.Value);
            }
        }

        ///Game + SplitType -> event flag enum type lookup table
        private Dictionary<Game, Dictionary<SplitType, Type>> _eventFlagEnumTypeLookupTable =
            new Dictionary<Game, Dictionary<SplitType, Type>>()
            {
                {
                    Game.DarkSouls1,
                    new Dictionary<SplitType, Type> { { SplitType.Boss, typeof(SoulMemory.Games.DarkSouls1.Boss) } }
                }
            };

        #endregion

        #region Language

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

        #endregion


        #region INotifyPropertyChanged
        private bool SetField<TField>(ref TField field, TField value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<TField>.Default.Equals(field, value)) return false;
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
