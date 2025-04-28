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
using System.Linq;
using System.Windows.Media;
using SoulMemory.Enums;

namespace SoulSplitter.Ui.ViewModels.MainViewModel
{
    public partial class MainViewModel
    {
        private object? GetSplitObject()
        {
            return SelectedSplitType!.Value switch
            {
                SplitType.Boss or
                SplitType.KnownFlag or
                SplitType.ItemPickup or
                SplitType.Bonfire => SelectedEventFlag!,
                SplitType.Position => PositionViewModel!.Clone(), //Deepclone to break reference with other viewmodels
                SplitType.Flag => Flag!,
                SplitType.Attribute => AttributeViewModel!.Clone(),
                SplitType.EldenRingPosition => EldenRingPositionViewModel!.Clone(),
                SplitType.DarkSouls1Bonfire => DarkSouls1BonfireViewModel!.Clone(),
                SplitType.DarkSouls1Item => SelectedDarkSouls1Item!,
                SplitType.Manual => null,
                _ => throw new System.NotImplementedException(),
            };
        }

        public void UpdateLivesplitSplits(List<string> livesplitSplits)
        {
            try
            {
                Splits.CollectionChanged -= OnSplitsChanged;
                _livesplitSplits = livesplitSplits;
                var difference = _livesplitSplits.Count - Splits.Count;
                if (difference > 0)
                {
                    var game = Splits.Any() ? Splits.Last().Game : null;
                    game ??= SelectedGame;
                    game ??= Game.DarkSouls1;
                    for (int i = 0; i < difference; i++)
                    {
                        Splits.Add(new SplitViewModel() { Game = game, SplitType = SplitType.Manual});
                    }
                }
            }
            catch(Exception ex)
            {
                AddException(ex);
            }
            finally
            {
                OnSplitsChanged(null!, null!);
                Splits.CollectionChanged += OnSplitsChanged;
            }
        }
        
        private List<string> _livesplitSplits = new List<string>();
        
        private void OnSplitsChanged(object sender, EventArgs args)
        {
            for (var i = 0; i < _livesplitSplits.Count; i++)
            {
                if (i < Splits.Count)
                {
                    Splits[i].LivesplitTitle = _livesplitSplits[i];
                    Splits[i].BackgroundColor = new SolidColorBrush(Colors.White);
                }
            }

            for (var i = 0; i < Splits.Count; i++)
            {
                if (i >= _livesplitSplits.Count)
                {
                    Splits[i].LivesplitTitle = "";
                    Splits[i].BackgroundColor = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Splits[i].BackgroundColor = new SolidColorBrush(Colors.White);
                }
            }
        }

        public RelayCommand SerializeCommand { get; set; } = null!;

        #region Add split ========================================================================================
        public RelayCommand AddSplitCommand { get; set; }

        private void AddSplit(object? param)
        {
            if (SelectedSplitType == SplitType.Manual)
            {
                Splits.Add(
                    new SplitViewModel()
                    {
                        Game = SelectedGame,
                        SplitType = SplitType.Manual,
                    });
                return;
            }

            var split = GetSplitObject();

            Splits.Add(
                new SplitViewModel(
                    SelectedGame!.Value,
                    SelectedTimingType!.Value,
                    SelectedSplitType!.Value,
                    split,
                    SplitDescription));
        }

        private bool CanAddSplit(object? param)
        {
            if (SelectedSplitType == SplitType.Manual && SelectedGame != null)
            {
                return true;
            }

            return
                SelectedGame != null &&
                SelectedTimingType != null &&
                SelectedSplitType != null &&
                (
                    SelectedEventFlag != null || 
                    PositionViewModel != null || 
                    Flag != null || 
                    AttributeViewModel is { Attribute: not null } ||
                    EldenRingPositionViewModel != null ||
                    DarkSouls1BonfireViewModel != null ||
                    SelectedDarkSouls1Item != null
                );
        }

        #endregion

        #region Save existing split ========================================================================================

        public RelayCommand SaveExistingSplitCommand { get; set; }

        private void SaveExistingSplit(object? param)
        {
            SelectedSplit!.Game = SelectedGame!.Value;
            SelectedSplit.TimingType = SelectedTimingType;
            SelectedSplit.SplitType = SelectedSplitType!.Value;
            SelectedSplit.Description = SplitDescription;
            SelectedSplit.Split = GetSplitObject();

            //Trigger CollectionChanged event when saving items
            var index = Splits.IndexOf(SelectedSplit);
            Splits[index] = SelectedSplit;
        }

        private bool CanSaveExistingSplit(object? param)
        {
            return SelectedSplit != null && CanAddSplit(null);
        }

        #endregion

        #region remove split ========================================================================================

        public RelayCommand RemoveSplitCommand { get; set; }

        public void RemoveSplit(object? param)
        {
            if (SelectedSplit != null)
            {
                Splits.Remove(SelectedSplit);
                SelectedSplit = null;
            }
        }

        private bool CanRemoveSplit(object? param)
        {
            return SelectedSplit != null;
        }

        #endregion
    }
}
