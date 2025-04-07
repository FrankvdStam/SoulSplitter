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

using SoulSplitter.DependencyInjection;
using SoulMemory.Enums;
using SoulSplitter.Resources;
using SoulSplitter.Utils;

namespace SoulSplitter.Ui.ViewModels.MainViewModel;

public partial class MainViewModel
{
    private readonly ILanguageManager _languageManager;

    /// <summary>
    /// Parameterless constructor for serializing
    /// </summary>
    public MainViewModel() : this(App.ServiceProvider.GetService<ILanguageManager>())
    {

    }

    public MainViewModel(ILanguageManager languageManager)
    {
        _languageManager = languageManager;
        AddSplitCommand = new RelayCommand(AddSplit, CanAddSplit);
        RemoveSplitCommand = new RelayCommand(RemoveSplit, CanRemoveSplit);

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
                    EventFlagType = SplitConfiguration.GetSplitType(SelectedGame!.Value, SelectedSplitType!.Value)!;
                    break;

                case SplitType.Flag:
                    Flag = 0;
                    break;

                case SplitType.DarkSouls1Bonfire:
                    DarkSouls1BonfireViewModel = new DarkSouls1BonfireViewModel();
                    break;
                    
                case SplitType.Position:
                    PositionViewModel = new PositionViewModel();
                    break;

                case SplitType.EldenRingPosition:
                    EldenRingPositionViewModel = new EldenRingPositionViewModel();
                    break;

                
                case SplitType.Attribute:
                    AttributeType = SplitConfiguration.GetSplitType(SelectedGame!.Value, SelectedSplitType!.Value)!;
                    AttributeViewModel = new AttributeViewModel();
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
        PositionViewModel = null;
        Flag = null;
        AttributeViewModel = null;
        EldenRingPositionViewModel = null;
        DarkSouls1BonfireViewModel = null;
        SelectedDarkSouls1Item = null;
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

