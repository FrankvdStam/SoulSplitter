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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Xml;
using System.Xml.Serialization;
using SoulMemory;
using SoulSplitter.soulmemory_rs;
using SoulSplitter.UI.DarkSouls1;
using SoulSplitter.UI.DarkSouls2;
using SoulSplitter.UI.DarkSouls3;
using SoulSplitter.UI.EldenRing;
using SoulSplitter.UI.Generic;
using SoulSplitter.UI.Sekiro;
using SoulSplitter.ViewModels.Games;
using Brush = System.Windows.Media.Brush;

namespace SoulSplitter.UI;

public class MainViewModel : ICustomNotifyPropertyChanged
{
    public MainViewModel()
    {
        CommandTroubleShooting = new RelayCommand(OpenTroubleshootingWebpage, (_) => true);
        CommandRunEventFlagLogger = new RelayCommand(RunEventFlagLogger, (_) => true);
        CommandClearErrors = new RelayCommand(ClearErrors, (_) => Errors.Count > 0);
        CommandAddError = new RelayCommand(AddErrorCommand, (_) => true);
        CommandShowErrors = new RelayCommand(ShowErrorWindow, (_) => true);
        CommandOpenFlagTrackerWindow = new RelayCommand(OpenFlagTrackerWindow, (_) => true);
        CommandImportSettingsFromFile = new RelayCommand(ImportSettings, (_) => true);
        CommandExportSettingsFromFile = new RelayCommand(ExportSettings, (_) => true);
    }

    public void Update(MainViewModel mainViewModel)
    {
        SelectedGame = mainViewModel.SelectedGame;
        DarkSouls1ViewModel = mainViewModel.DarkSouls1ViewModel;
        DarkSouls2ViewModel = mainViewModel.DarkSouls2ViewModel;
        DarkSouls3ViewModel = mainViewModel.DarkSouls3ViewModel;
        SekiroViewModel = mainViewModel.SekiroViewModel;
        EldenRingViewModel = mainViewModel.EldenRingViewModel;
        ArmoredCore6ViewModel = mainViewModel.ArmoredCore6ViewModel;
        FlagTrackerViewModel = mainViewModel.FlagTrackerViewModel;
    }


    public string Version { get; set; } = VersionHelper.Version.ToString();

    public Game SelectedGame
    {
        get => _selectedGame;
        set => this.SetField(ref _selectedGame, value);
    }
    private Game _selectedGame = Game.EldenRing;

    #region Game View models

    public DarkSouls1ViewModel DarkSouls1ViewModel
    {
        get => _darkSouls1ViewModel;
        set => this.SetField(ref _darkSouls1ViewModel, value);
    }
    private DarkSouls1ViewModel _darkSouls1ViewModel = new();

    public DarkSouls2ViewModel DarkSouls2ViewModel
    {
        get => _darkSouls2ViewModel;
        set => this.SetField(ref _darkSouls2ViewModel, value);
    }
    private DarkSouls2ViewModel _darkSouls2ViewModel = new();

    public DarkSouls3ViewModel DarkSouls3ViewModel
    {
        get => _darkSouls3ViewModel;
        set => this.SetField(ref _darkSouls3ViewModel, value);
    }
    private DarkSouls3ViewModel _darkSouls3ViewModel = new();

    public SekiroViewModel SekiroViewModel
    {
        get => _sekiroViewModel;
        set => this.SetField(ref _sekiroViewModel, value);
    }
    private SekiroViewModel _sekiroViewModel = new();

    public EldenRingViewModel EldenRingViewModel
    {
        get => _eldenRingViewModel;
        set => this.SetField(ref _eldenRingViewModel, value);
    }
    private EldenRingViewModel _eldenRingViewModel = new();

    public ArmoredCore6ViewModel ArmoredCore6ViewModel
    {
        get => _armoredCore6ViewModel;
        set => this.SetField(ref _armoredCore6ViewModel, value);
    }
    private ArmoredCore6ViewModel _armoredCore6ViewModel = new();

    public FlagTrackerViewModel FlagTrackerViewModel
    {
        get => _flagTrackerViewModel;
        set => this.SetField(ref _flagTrackerViewModel, value);
    }
    private FlagTrackerViewModel _flagTrackerViewModel = new();

    #endregion

    #region Errors

    public bool IgnoreProcessNotRunningErrors
    {
        get => _ignoreProcessNotRunningErrors;
        set => this.SetField(ref _ignoreProcessNotRunningErrors, value);
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
            Error = error.ToString(),
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

    public void ClearErrors()
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
        set => this.SetField(ref _commandClearErrors, value);
    }
    private RelayCommand _commandClearErrors = null!;

    [XmlIgnore]
    public RelayCommand CommandShowErrors
    {
        get => _commandShowErrors;
        set => this.SetField(ref _commandShowErrors, value);
    }
    private RelayCommand _commandShowErrors = null!;

    private ErrorWindow? _errorWindow;
    private void ShowErrorWindow()
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
        set => this.SetField(ref _errorCount, value);
    }
    private string _errorCount = null!;

    [XmlIgnore]
    public Brush BadgeBackgroundBrush
    {
        get => _badgeBackgroundBrush;
        set => this.SetField(ref _badgeBackgroundBrush, value);
    }
    private Brush _badgeBackgroundBrush = new SolidColorBrush(Colors.Transparent);

    [XmlIgnore]
    public Brush BadgeForegroundBrush
    {
        get => _badgeForegroundBrush;
        set => this.SetField(ref _badgeForegroundBrush, value);
    }
    private Brush _badgeForegroundBrush = new SolidColorBrush(Colors.Transparent);

    [XmlIgnore]
    public Visibility BadgeVisibilityInverse
    {
        get => _badgeVisibilityInverse;
        set => this.SetField(ref _badgeVisibilityInverse, value);
    }
    private Visibility _badgeVisibilityInverse = Visibility.Visible;

    [XmlIgnore]
    public ObservableCollection<ErrorViewModel> Errors { get; set; } = [];

    #endregion

    #region Menu

    [XmlIgnore]
    public RelayCommand CommandTroubleShooting
    {
        get => _commandTroubleShooting;
        set => this.SetField(ref _commandTroubleShooting, value);
    }
    private RelayCommand _commandTroubleShooting = null!;

    private const string TroubleshootingUrl = "https://github.com/FrankvdStam/SoulSplitter/wiki/troubleshooting";
    private void OpenTroubleshootingWebpage()
    {
        Process.Start(TroubleshootingUrl);
    }

    [XmlIgnore]
    public RelayCommand CommandRunEventFlagLogger
    {
        get => _commandRunEventFlagLogger;
        set => this.SetField(ref _commandRunEventFlagLogger, value);
    }
    private RelayCommand _commandRunEventFlagLogger = null!;

    private void RunEventFlagLogger()
    {
        TryAndHandleError(SoulMemoryRs.Launch);
    }
    
    [XmlIgnore]
    public RelayCommand CommandOpenFlagTrackerWindow
    {
        get => _commandOpenFlagTrackerWindow;
        set => this.SetField(ref _commandOpenFlagTrackerWindow, value);
    }
    private RelayCommand _commandOpenFlagTrackerWindow = null!;

    private FlagTrackerWindow? _flagTrackerWindow;
    private void OpenFlagTrackerWindow()
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
        set => this.SetField(ref _commandAddError, value);
    }
    private RelayCommand _commandAddError = null!;

    //For debugging purposes
    private void AddErrorCommand()
    {
        AddException(new Exception("adf"));
    }

    [XmlIgnore]
    public RelayCommand CommandImportSettingsFromFile
    {
        get => _commandImportSettingsFromFile;
        set => this.SetField(ref _commandImportSettingsFromFile, value);
    }
    private RelayCommand _commandImportSettingsFromFile = null!;

    private void ImportSettings()
    {
        TryAndHandleError(() =>
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "XML-File | *.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;

            if (!openFileDialog.ShowDialog() ?? false || string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                return;
            }

            ImportXml = File.ReadAllText(openFileDialog.FileName);
        });
    }

    [XmlIgnore] public string? ImportXml = null!;

    [XmlIgnore]
    public RelayCommand CommandExportSettingsFromFile
    {
        get => _commandExportSettingsFromFile;
        set => this.SetField(ref _commandExportSettingsFromFile, value);
    }
    private RelayCommand _commandExportSettingsFromFile = null!;

    private void ExportSettings()
    {
        TryAndHandleError(() =>
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.Filter = "XML-File | *.xml|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            if (!saveFileDialog.ShowDialog() ?? false || string.IsNullOrWhiteSpace(saveFileDialog.FileName))
            {
                return;
            }

            var xml = Serialize();
            File.WriteAllText(saveFileDialog.FileName, xml);
        });
    }
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
        using var stream = new StringWriter();
        using var writer = XmlWriter.Create(stream, settings);
        var serializer = new XmlSerializer(GetType());
        serializer.Serialize(writer, this);
        xml = stream.ToString();
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

    private ImageSource iconHelper = null!;

    public ImageSource IconHelper { get => iconHelper; set => this.SetField(ref iconHelper, value); }

    #region ICustomNotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    public void InvokePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
