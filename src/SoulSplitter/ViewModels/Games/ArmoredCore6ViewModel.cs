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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulSplitter.Splits;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.ViewModels.Games
{
    public class ArmoredCore6ViewModel : BaseViewModel
    {
        public ArmoredCore6ViewModel()
        {
            AddSplitCommand = new RelayCommand(AddSplit, CanAddSplit);
            RemoveSplitCommand = new RelayCommand(RemoveSplit);
        }

        private bool CanAddSplit(object param)
        {
            if (param is FlatSplit flatSplit)
            {
                return true;
            }

            return false;
        }

        private void AddSplit(object param)
        {
            if (param is FlatSplit flatSplit)
            {
                SplitsViewModel.AddSplit(flatSplit.TimingType, flatSplit.SplitType, flatSplit.Split);
            }
        }

        private void RemoveSplit(object param)
        {
            SplitsViewModel.RemoveSplit();
        }


        #region Static UI source data ============================================================================================================================================

        public static ObservableCollection<EnumFlagViewModel<TimingType>> TimingTypes { get; set; } = new ObservableCollection<EnumFlagViewModel<TimingType>>()
        {
            new EnumFlagViewModel<TimingType>(TimingType.Immediate),
            new EnumFlagViewModel<TimingType>(TimingType.OnLoading),
        };

        public static ObservableCollection<EnumFlagViewModel<SplitType>> SplitTypes { get; set; } = new ObservableCollection<EnumFlagViewModel<SplitType>>()
        {
            new EnumFlagViewModel<SplitType>(SplitType.Flag),
        };

        #endregion
    }
}
