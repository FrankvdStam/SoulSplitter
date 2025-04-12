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

using SoulMemory.Enums;

namespace SoulSplitter.Ui.ViewModels.MainViewModel
{
    public partial class MainViewModel
    {
        private object GetSplitObject()
        {
            return SelectedSplitType!.Value switch
            {
                SplitType.Boss or
                SplitType.KnownFlag or
                SplitType.ItemPickup or
                SplitType.Bonfire => SelectedEventFlag!,
                SplitType.Position => PositionViewModel!.Clone(),
                SplitType.Flag => Flag!,
                SplitType.Attribute => AttributeViewModel!.Clone(),
                SplitType.EldenRingPosition => EldenRingPositionViewModel!.Clone(),
                SplitType.DarkSouls1Bonfire => DarkSouls1BonfireViewModel!.Clone(),
                SplitType.DarkSouls1Item => SelectedDarkSouls1Item!,

                _ => throw new System.NotImplementedException(),
            };
        }


        public RelayCommand SerializeCommand { get; set; } = null!;

        #region Add split ========================================================================================
        public RelayCommand AddSplitCommand { get; set; }

        private void AddSplit(object? param)
        {
            object split = GetSplitObject();

            Splits.Add(
                new SplitViewModel(
                    SelectedGame!.Value,
                    SelectedNewGamePlusLevel,
                    SelectedTimingType!.Value,
                    SelectedSplitType!.Value,
                    split,//Deep clone so that the splits collection does not get duplicate objects
                    SplitDescription));
        }

        

        private bool CanAddSplit(object? param)
        {
            return
                SelectedGame != null &&
                SelectedTimingType != null &&
                SelectedSplitType != null &&
                (
                    SelectedEventFlag != null || 
                    PositionViewModel != null || 
                    Flag != null || 
                    AttributeViewModel != null ||
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
            SelectedSplit.NewGamePlusLevel = SelectedNewGamePlusLevel;
            SelectedSplit.TimingType = SelectedTimingType!.Value;
            SelectedSplit.SplitType = SelectedSplitType!.Value;
            SelectedSplit.Description = SplitDescription;
            SelectedSplit.Split = GetSplitObject();
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
