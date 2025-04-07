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
using System.Windows.Media;
using System.Windows;
using System.Xml.Serialization;
using SoulMemory;
using SoulSplitter.Ui.View;
using SoulSplitter.Utils;

namespace SoulSplitter.Ui.ViewModels.MainViewModel;

/// <summary>
/// This part of MainViewModel contains all the bindable properties required for all the different split types
/// </summary>
public partial class MainViewModel
{
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
        if (IgnoreProcessNotRunningErrors && error.Reason == RefreshErrorReason.ProcessNotRunning || error.Reason == RefreshErrorReason.ProcessExited)
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
        if (Errors.Count == 0)
        {
            ErrorCount = "";
            BadgeBackgroundBrush = new SolidColorBrush(Colors.Transparent);
            BadgeForegroundBrush = new SolidColorBrush(Colors.Transparent);
        }
        else
        {
            BadgeBackgroundBrush = new SolidColorBrush(Colors.Red);
            BadgeForegroundBrush = new SolidColorBrush(Colors.Black);

            if (Errors.Count > 9)
            {
                ErrorCount = "9+";
            }
            else
            {
                ErrorCount = Errors.Count.ToString();
            }
        }
    }

    public RelayCommand CommandClearErrors { get; }

    public RelayCommand CommandShowErrors { get; }

    private ErrorWindow? _errorWindow;
    private void ShowErrorWindow()
    {
        if (_errorWindow == null)
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

    public string ErrorCount
    {
        get => _errorCount;
        set => SetField(ref _errorCount, value);
    }
    private string _errorCount = null!;

    public Brush BadgeBackgroundBrush
    {
        get => _badgeBackgroundBrush;
        set => SetField(ref _badgeBackgroundBrush, value);
    }
    private Brush _badgeBackgroundBrush = new SolidColorBrush(Colors.Transparent);

    public Brush BadgeForegroundBrush
    {
        get => _badgeForegroundBrush;
        set => SetField(ref _badgeForegroundBrush, value);
    }
    private Brush _badgeForegroundBrush = new SolidColorBrush(Colors.Transparent);

    public Visibility BadgeVisibilityInverse
    {
        get => _badgeVisibilityInverse;
        set => SetField(ref _badgeVisibilityInverse, value);
    }
    private Visibility _badgeVisibilityInverse = Visibility.Visible;

    public ObservableCollection<ErrorViewModel> Errors { get; } = [];
}
