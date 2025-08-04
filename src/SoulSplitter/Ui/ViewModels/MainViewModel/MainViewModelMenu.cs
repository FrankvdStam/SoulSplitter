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
using System.Diagnostics;
using System.Windows.Forms.Integration;
using SoulSplitter.soulmemory_rs;
using SoulSplitter.Ui.View;

namespace SoulSplitter.Ui.ViewModels.MainViewModel;

/// <summary>
/// This part of MainViewModel contains all the bindable properties required for all the different split types
/// </summary>
public partial class MainViewModel
{

    #region Menu

    public RelayCommand CommandTroubleShooting { get; }

    private const string TroubleshootingUrl = "https://soulsspeedruns.com/livesplit/";
    private void OpenTroubleshootingWebpage()
    {
        Process.Start(TroubleshootingUrl);
    }

    
    public RelayCommand CommandOpenHomepage { get; }
    private const string HomepageUrl = "https://github.com/FrankvdStam/SoulSplitter";
    private void ShowHomepage()
    {
        Process.Start(HomepageUrl);
    }
    
    public RelayCommand CommandRunEventFlagLogger { get; }

    private void RunEventFlagLogger()
    {
        TryAndHandleError(SoulMemoryRs.Launch);
    }

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


    public FlagTrackerViewModel FlagTrackerViewModel
    {
        get => _flagTrackerViewModel;
        set => SetField(ref _flagTrackerViewModel, value);
    }
    private FlagTrackerViewModel _flagTrackerViewModel = new();


    //For debugging purposes

    public RelayCommand CommandAddError { get; }

    //For debugging purposes
    private void AddErrorCommand()
    {
        AddException(new Exception("adf"));
    }

    
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

        });
    }

    
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

            //var xml = Serialize();
            //File.WriteAllText(saveFileDialog.FileName, xml);
        });
    }
    #endregion

}
