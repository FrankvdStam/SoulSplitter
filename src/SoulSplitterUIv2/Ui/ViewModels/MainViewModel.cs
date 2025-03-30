using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using SoulSplitterUIv2.DependencyInjection;
using SoulSplitterUIv2.Enums;
using SoulSplitterUIv2.Resources;
using Boss = SoulMemory.Games.EldenRing.Boss;

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
            Splits.Add(new SplitViewModel(SelectedGame.Value, SelectedNewGamePlusLevel, SelectedTimingType.Value, SelectedSplitType.Value, SelectedBoss.Value, SplitDescription));
        }

        private bool CanAddSplit(object param)
        {
            return
                SelectedGame != null &&
                SelectedTimingType != null &&
                SelectedSplitType != null &&
                SelectedBoss != null;
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
            set => SetField(ref _selectedSplitType, value);
        }
        private SplitType? _selectedSplitType;

        public Boss? SelectedBoss
        {
            get => _selectedBoss;
            set => SetField(ref _selectedBoss, value);
        }
        private Boss? _selectedBoss;

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

        public RelayCommand.RelayCommand AddSplitCommand
        { 
            get => _addSplitCommand;
            set => _addSplitCommand = value;
        }
        private RelayCommand.RelayCommand _addSplitCommand;

        public RelayCommand.RelayCommand SerializeCommand
        {
            get => _serializeCommand;
            set => _serializeCommand = value;
        }
        private RelayCommand.RelayCommand _serializeCommand;
        
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
                TimingTypes.AddRange(SelectedGame.GetAttribute<TimingTypesAttribute>().TimingTypes);
                SplitTypes.AddRange(SelectedGame.GetAttribute<SplitTypesAttribute>().SplitTypes);
            }
        }

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
