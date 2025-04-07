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
using SoulMemory.Enums;
using SoulSplitter.soulmemory_rs;
using SoulSplitter.Ui.RelayCommand;
using SoulSplitter.Ui.View;
using SoulSplitter.Ui.ViewModels;
using SoulSplitter.UiOld.DarkSouls1;
using SoulSplitter.UiOld.DarkSouls2;
using SoulSplitter.UiOld.DarkSouls3;
using SoulSplitter.UiOld.EldenRing;
using SoulSplitter.UiOld.Generic;
using SoulSplitter.Utils;
using Brush = System.Windows.Media.Brush;

namespace SoulSplitter.UiOld;

public class MainViewModel : NotifyPropertyChanged
{
    public MainViewModel()
    {
        CommandOpenUiV2 = new RelayCommand(ShowUiV2, (_) => true);
        CommandTroubleShooting = new RelayCommand(OpenTroubleshootingWebpage, (_) => true);
        CommandOpenHomepage = new RelayCommand(ShowHomepage, (_) => true);
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
        EldenRingViewModel = mainViewModel.EldenRingViewModel;
        FlagTrackerViewModel = mainViewModel.FlagTrackerViewModel;
    }
    public string Version
    {
        get { return VersionHelper.Version.ToString(); }
        set
        {
            //don't do anything - this is just to make the serializer happy
        }
    }

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
    private DarkSouls1ViewModel _darkSouls1ViewModel = new();

    public DarkSouls2ViewModel DarkSouls2ViewModel
    {
        get => _darkSouls2ViewModel;
        set => SetField(ref _darkSouls2ViewModel, value);
    }
    private DarkSouls2ViewModel _darkSouls2ViewModel = new();

    public DarkSouls3ViewModel DarkSouls3ViewModel
    {
        get => _darkSouls3ViewModel;
        set => SetField(ref _darkSouls3ViewModel, value);
    }
    private DarkSouls3ViewModel _darkSouls3ViewModel = new();

    public EldenRingViewModel EldenRingViewModel
    {
        get => _eldenRingViewModel;
        set => SetField(ref _eldenRingViewModel, value);
    }
    private EldenRingViewModel _eldenRingViewModel = new();

    public FlagTrackerViewModel FlagTrackerViewModel
    {
        get => _flagTrackerViewModel;
        set => SetField(ref _flagTrackerViewModel, value);
    }
    private FlagTrackerViewModel _flagTrackerViewModel = new();

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
            Error = error.ToString()
        };
        AddError(errorViewModel);
    }

    public void AddException(Exception e)
    {
        var errorViewModel = new ErrorViewModel
        {
            DateTime = DateTime.Now,
            Error = e.ToString()
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
    public RelayCommand CommandClearErrors { get; }

    [XmlIgnore]
    public RelayCommand CommandShowErrors { get; }

    private ErrorWindow? _errorWindow;
    private void ShowErrorWindow()
    {
        if(_errorWindow == null)
        {
            _errorWindow = new ErrorWindow();
            _errorWindow.DataContext = this;
            _errorWindow.Closing += (_, arg) =>
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
    private string _errorCount = null!;

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
    private Visibility _badgeVisibilityInverse = Visibility.Visible;

    [XmlIgnore]
    public ObservableCollection<ErrorViewModel> Errors { get; } = [];

    #endregion

    #region Menu

    [XmlIgnore] 
    public RelayCommand CommandTroubleShooting { get; }

    private const string TroubleshootingUrl = "https://soulsspeedruns.com/livesplit/";
    private void OpenTroubleshootingWebpage()
    {
        Process.Start(TroubleshootingUrl);
    }

    [XmlIgnore]
    public RelayCommand CommandOpenHomepage { get; }
    private const string HomepageUrl = "https://github.com/FrankvdStam/SoulSplitter";
    private void ShowHomepage()
    {
        Process.Start(HomepageUrl);
    }

    [XmlIgnore]
    public RelayCommand CommandOpenUiV2 { get; }
    private void ShowUiV2()
    {
        Application.Current.MainWindow.Show();
    }



    [XmlIgnore]
    public RelayCommand CommandRunEventFlagLogger { get; }

    private void RunEventFlagLogger()
    {
        TryAndHandleError(SoulMemoryRs.Launch);
    }
    
    [XmlIgnore]
    public RelayCommand CommandOpenFlagTrackerWindow { get; }

    private FlagTrackerWindow? _flagTrackerWindow;
    private void OpenFlagTrackerWindow()
    {
        if (_flagTrackerWindow == null)
        {
            _flagTrackerWindow = new FlagTrackerWindow();
            ElementHost.EnableModelessKeyboardInterop(_flagTrackerWindow);
            _flagTrackerWindow.DataContext = FlagTrackerViewModel;

            _flagTrackerWindow.Closing += (_, arg) =>
            {
                _flagTrackerWindow.Hide();
                arg.Cancel = true;
            };
        }
        _flagTrackerWindow.Show();
    }


    //For debugging purposes
    [XmlIgnore]
    public RelayCommand CommandAddError { get; }

    //For debugging purposes
    private void AddErrorCommand()
    {
        AddException(new Exception("adf"));
    }

    [XmlIgnore]
    public RelayCommand CommandImportSettingsFromFile { get; }

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

    [XmlIgnore] public string? ImportXml;

    [XmlIgnore]
    public RelayCommand CommandExportSettingsFromFile { get; }

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
            Indent = true
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
        vm.EldenRingViewModel.RestoreHierarchy();
        return vm;
    }

    #endregion

    private ImageSource iconHelper = null!;

    public ImageSource IconHelper { get => iconHelper; set => SetField(ref iconHelper, value); }
}
