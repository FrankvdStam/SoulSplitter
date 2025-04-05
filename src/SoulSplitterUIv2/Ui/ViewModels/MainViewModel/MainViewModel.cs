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
using SoulSplitterUIv2.DependencyInjection;
using SoulMemory.Enums;
using SoulSplitterUIv2.Resources;

namespace SoulSplitterUIv2.Ui.ViewModels.MainViewModel;

public partial class MainViewModel : INotifyPropertyChanged
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
        //TODO: SelectedEventFlag is hardcoded here
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

    #region UI logic

    private void OnSelectedGameChanged()
    {
        IsGameSelected = SelectedGame != null;
        SelectedTimingType = null;
        SelectedSplitType = null;
        ClearSplit();

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
        ClearSplit();
        if (SelectedSplitType != null)
        {
            switch (SelectedSplitType)
            {
                case SplitType.Boss:
                case SplitType.KnownFlag:
                case SplitType.ItemPickup:
                case SplitType.Bonfire:
                    SelectedEventFlagType = SplitConfiguration.GetSplitType(SelectedGame!.Value, SelectedSplitType!.Value)!;
                    break;

                case SplitType.Position:
                    PositionViewModel = new PositionViewModel();
                    break;
            }
            
        }
    }

    /// <summary>
    /// Clears only the split object - event flag, boss position, etc.
    /// </summary>
    private void ClearSplit()
    {
        SelectedEventFlag = null;
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

}

