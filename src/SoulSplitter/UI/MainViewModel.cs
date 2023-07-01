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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml;
using System.Xml.Serialization;
using SoulMemory;
using SoulMemory.Native;
using SoulSplitter.soulmemory_rs;
using SoulSplitter.UI.DarkSouls1;
using SoulSplitter.UI.DarkSouls2;
using SoulSplitter.UI.DarkSouls3;
using SoulSplitter.UI.EldenRing;
using SoulSplitter.UI.Generic;
using SoulSplitter.UI.Sekiro;
using Brush = System.Windows.Media.Brush;

namespace SoulSplitter.UI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            CommandTroubleShooting = new RelayCommand(OpenTroubleshootingWebpage, (o) => true);
            CommandRunEventFlagLogger = new RelayCommand(RunEventFlagLogger, (o) => true);
            CommandOpenSeparateSettingsWindow = new RelayCommand(OpenSeparateSettingsWindow, (o) => true);
            CommandClearErrors = new RelayCommand(ClearErrors, (o) => Errors.Count > 0);
            CommandAddError = new RelayCommand(AddErrorCommand, (o) => true);
            CommandShowErrors = new RelayCommand(ShowErrorWindow, (o) => true);
            CommandOpenFlagTrackerWindow = new RelayCommand(OpenFlagTrackerWindow, (o) => true);
        }

        public void Update(MainViewModel mainViewModel)
        {
            SelectedGame = mainViewModel.SelectedGame;
            DarkSouls1ViewModel = mainViewModel.DarkSouls1ViewModel;
            DarkSouls2ViewModel = mainViewModel.DarkSouls2ViewModel;
            DarkSouls3ViewModel = mainViewModel.DarkSouls3ViewModel;
            SekiroViewModel = mainViewModel.SekiroViewModel;
            EldenRingViewModel = mainViewModel.EldenRingViewModel;
            FlagTrackerViewModel = mainViewModel.FlagTrackerViewModel;
        }


        public string Version { get; set; } = VersionHelper.Version.ToString();

        public Game SelectedGame
        {
            get => _selectedGame;
            set => SetField(ref _selectedGame, value);
        }
        private Game _selectedGame = Game.EldenRing;

        #region Game View models

        public DarkSouls1ViewModel DarkSouls1ViewModel
        {
            get => _darkSouls1ViewModel;
            set => SetField(ref _darkSouls1ViewModel, value);
        }
        private DarkSouls1ViewModel _darkSouls1ViewModel = new DarkSouls1ViewModel();

        public DarkSouls2ViewModel DarkSouls2ViewModel
        {
            get => _darkSouls2ViewModel;
            set => SetField(ref _darkSouls2ViewModel, value);
        }
        private DarkSouls2ViewModel _darkSouls2ViewModel = new DarkSouls2ViewModel();

        public DarkSouls3ViewModel DarkSouls3ViewModel
        {
            get => _darkSouls3ViewModel;
            set => SetField(ref _darkSouls3ViewModel, value);
        }
        private DarkSouls3ViewModel _darkSouls3ViewModel = new DarkSouls3ViewModel();

        public SekiroViewModel SekiroViewModel
        {
            get => _sekiroViewModel;
            set => SetField(ref _sekiroViewModel, value);
        }
        private SekiroViewModel _sekiroViewModel = new SekiroViewModel();

        public EldenRingViewModel EldenRingViewModel
        {
            get => _eldenRingViewModel;
            set => SetField(ref _eldenRingViewModel, value);
        }
        private EldenRingViewModel _eldenRingViewModel = new EldenRingViewModel();

        public FlagTrackerViewModel FlagTrackerViewModel
        {
            get => _flagTrackerViewModel;
            set => SetField(ref _flagTrackerViewModel, value);
        }
        private FlagTrackerViewModel _flagTrackerViewModel = new FlagTrackerViewModel();

        #endregion

        #region Errors

        public bool IgnoreProcessNotRunningErrors
        {
            get => _ignoreProcessNotRunningErrors;
            set => SetField(ref _ignoreProcessNotRunningErrors, value);
        }
        private bool _ignoreProcessNotRunningErrors = true;

        public void TryAndHandleError(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Logger.Log(e);
                AddException(e);
            }
        }

        public void AddRefreshError(RefreshError error)
        {
            if(IgnoreProcessNotRunningErrors && error.Reason == RefreshErrorReason.ProcessNotRunning || error.Reason == RefreshErrorReason.ProcessExited)
            {
                return;
            }

            var errorViewModel = new ErrorViewModel
            {
                DateTime = DateTime.Now,
                Error = $"{error.Message ?? ""} {error.Exception?.ToString() ?? ""}",
            };
            AddError(errorViewModel);
        }

        public void AddException(Exception e)
        {
            var errorViewModel = new ErrorViewModel
            {
                DateTime = DateTime.Now,
                Error = e.ToString(),
            };
            AddError(errorViewModel);
        }

        private void AddError(ErrorViewModel errorViewModel)
        {
            Errors.Add(errorViewModel); 
            UpdateErrorBadge();
        }

        public void ClearErrors(object param)
        {
            Errors.Clear();
            UpdateErrorBadge();
        }

        private void UpdateErrorBadge()
        {
            if(Errors.Count == 0)
            {
                ErrorCount = "";
                BadgeBackgroundBrush = new SolidColorBrush(Colors.Transparent);
                BadgeForegroundBrush = new SolidColorBrush(Colors.Transparent);
            }
            else
            {
                BadgeBackgroundBrush = new SolidColorBrush(Colors.Red);
                BadgeForegroundBrush = new SolidColorBrush(Colors.Black);

                if(Errors.Count > 9)
                {
                    ErrorCount = "9+";
                }
                else
                {
                    ErrorCount = Errors.Count.ToString();
                }
            }
        }

        [XmlIgnore]
        public RelayCommand CommandClearErrors
        {
            get => _commandClearErrors;
            set => SetField(ref _commandClearErrors, value);
        }
        private RelayCommand _commandClearErrors;

        [XmlIgnore]
        public RelayCommand CommandShowErrors
        {
            get => _commandShowErrors;
            set => SetField(ref _commandShowErrors, value);
        }
        private RelayCommand _commandShowErrors;

        private ErrorWindow _errorWindow = null;
        private void ShowErrorWindow(object param)
        {
            if(_errorWindow == null)
            {
                _errorWindow = new ErrorWindow();
                _errorWindow.DataContext = this;
                _errorWindow.Closing += (s, arg) =>
                {
                    _errorWindow.Hide();
                    arg.Cancel = true;
                };
            }
            _errorWindow.Show();
        }

        [XmlIgnore]
        public string ErrorCount
        {
            get => _errorCount;
            set => SetField(ref _errorCount, value);
        }
        private string _errorCount;

        [XmlIgnore]
        public Brush BadgeBackgroundBrush
        {
            get => _badgeBackgroundBrush;
            set => SetField(ref _badgeBackgroundBrush, value);
        }
        private Brush _badgeBackgroundBrush = new SolidColorBrush(Colors.Transparent);

        [XmlIgnore]
        public Brush BadgeForegroundBrush
        {
            get => _badgeForegroundBrush;
            set => SetField(ref _badgeForegroundBrush, value);
        }
        private Brush _badgeForegroundBrush = new SolidColorBrush(Colors.Transparent);

        [XmlIgnore]
        public Visibility BadgeVisibilityInverse
        {
            get => _badgeVisibilityInverse;
            set => SetField(ref _badgeVisibilityInverse, value);
        }
        public Visibility _badgeVisibilityInverse = Visibility.Visible;

        [XmlIgnore]
        public ObservableCollection<ErrorViewModel> Errors { get; set; } = new ObservableCollection<ErrorViewModel>();

        #endregion

        #region Menu

        [XmlIgnore]
        public RelayCommand CommandTroubleShooting
        {
            get => _commandTroubleShooting;
            set => SetField(ref _commandTroubleShooting, value);
        }
        private RelayCommand _commandTroubleShooting;

        private const string TroubleshootingUrl = "https://github.com/FrankvdStam/SoulSplitter/wiki/troubleshooting";
        private void OpenTroubleshootingWebpage(object param)
        {
            Process.Start(TroubleshootingUrl);
        }

        [XmlIgnore]
        public RelayCommand CommandRunEventFlagLogger
        {
            get => _commandRunEventFlagLogger;
            set => SetField(ref _commandRunEventFlagLogger, value);
        }
        private RelayCommand _commandRunEventFlagLogger;

        private void RunEventFlagLogger(object sender)
        {
            SoulMemoryRs.Launch();
        }

        [XmlIgnore]
        public RelayCommand CommandOpenSeparateSettingsWindow
        {
            get => _commandOpenSeparateSettingsWindow;
            set => SetField(ref _commandOpenSeparateSettingsWindow, value);
        }
        private RelayCommand _commandOpenSeparateSettingsWindow;

        private Window _settingsWindow;
        private void OpenSeparateSettingsWindow(object sender)
        {
            if (_settingsWindow == null)
            {
                var mainControl = new MainWindow();
                mainControl.DataContext = this;

                _settingsWindow = new Window();
                ElementHost.EnableModelessKeyboardInterop(_settingsWindow);
                _settingsWindow.Title = "SoulSplitter settings";
                var iconStream = Application.GetResourceStream(new Uri("pack://application:,,,/SoulSplitter;component/soulsplitter.ico"))?.Stream;
                if (iconStream != null)
                {
                    _settingsWindow.Icon = BitmapFrame.Create(iconStream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                }
                _settingsWindow.Content = mainControl;
                _settingsWindow.Closing += (s, arg) =>
                {
                    _settingsWindow.Hide();
                    arg.Cancel = true;
                };
            }
            _settingsWindow.Show();
        }
        
        [XmlIgnore]
        public RelayCommand CommandOpenFlagTrackerWindow
        {
            get => _commandOpenFlagTrackerWindow;
            set => SetField(ref _commandOpenFlagTrackerWindow, value);
        }
        private RelayCommand _commandOpenFlagTrackerWindow;

        private FlagTrackerWindow _flagTrackerWindow;
        private void OpenFlagTrackerWindow(object sender)
        {
            if (_flagTrackerWindow == null)
            {
                _flagTrackerWindow = new FlagTrackerWindow();
                ElementHost.EnableModelessKeyboardInterop(_flagTrackerWindow);
                _flagTrackerWindow.DataContext = FlagTrackerViewModel;

                _flagTrackerWindow.Closing += (s, arg) =>
                {
                    _flagTrackerWindow.Hide();
                    arg.Cancel = true;
                };
            }
            _flagTrackerWindow.Show();
        }


        //For debugging purposes
        [XmlIgnore]
        public RelayCommand CommandAddError
        {
            get => _commandAddError;
            set => SetField(ref _commandAddError, value);
        }
        private RelayCommand _commandAddError;

        //For debugging purposes
        private void AddErrorCommand(object param)
        {
            AddException(new Exception("adf"));
        }

        #endregion

        #region Favorites



        public SplitsViewModel FavoriteSplits
        {
            get => _favoriteSplits;
            set => SetField(ref _favoriteSplits, value);
        }
        private SplitsViewModel _favoriteSplits = new SplitsViewModel();


        #endregion

        #region Serializing
        public string Serialize()
        {
            var settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                Indent = true,
            };

            var xml = "";
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                var serializer = new XmlSerializer(GetType());
                serializer.Serialize(writer, this);
                xml = stream.ToString();
            }
            return xml;
        }

        public static MainViewModel Deserialize(string xml)
        {
            var vm = xml.DeserializeXml<MainViewModel>();
            vm.DarkSouls1ViewModel.SplitsViewModel.RestoreHierarchy();
            vm.DarkSouls2ViewModel.RestoreHierarchy();
            vm.DarkSouls3ViewModel.SplitsViewModel.RestoreHierarchy();
            vm.SekiroViewModel.SplitsViewModel.RestoreHierarchy();
            vm.EldenRingViewModel.RestoreHierarchy();
            return vm;
        }

        #endregion
        
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
