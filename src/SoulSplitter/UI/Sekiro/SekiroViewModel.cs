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
using System.Linq;
using SoulMemory.Sekiro;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.UI.Sekiro
{
    public class SekiroViewModel : BaseViewModel
    {
        public SekiroViewModel()
        {
            AddSplitCommand = new RelayCommand(AddSplit, CanAddSplit);
        }

        public bool OverwriteIgtOnStart
        {
            get => _overwriteIgtOnStart;
            set => SetField(ref _overwriteIgtOnStart, value);
        }
        private bool _overwriteIgtOnStart = false;
        

        #region add/remove splits ============================================================================================================================================

        private bool CanAddSplit(object param)
        {
            if (!NewSplitTimingType.HasValue || !NewSplitType.HasValue)
            {
                return false;
            }

            switch (NewSplitType)
            {
                default:
                    throw new ArgumentException($"{NewSplitType} not supported");
            
                case SplitType.Boss:
                case SplitType.Bonfire:
                case SplitType.Attribute:
                    return NewSplitValue != null;
            
                case SplitType.Position:
                    return Position != null;

                case SplitType.Flag:
                    return FlagDescription != null;
            }
        }

        private void AddSplit(object param)
        {
            object split = null;
            switch (NewSplitType)
            {
                default:
                    throw new ArgumentException($"{NewSplitType} not supported");

                case SplitType.Boss:
                case SplitType.Bonfire:
                    split = NewSplitValue;
                    break;

                case SplitType.Position:
                    split = Position;
                    break;

                case SplitType.Attribute:
                    split = NewSplitValue;
                    break;

                case SplitType.Flag:
                    split = FlagDescription;
                    break;
            }
            SplitsViewModel.AddSplit(NewSplitTimingType.Value, NewSplitType.Value, split);

            NewSplitTimingType = null;
            NewSplitEnabledSplitType = false;
            NewSplitType = null;
        }


        #endregion

        #region Static UI source data ============================================================================================================================================

        public static ObservableCollection<EnumFlagViewModel<Boss>> Bosses { get; set; } = new ObservableCollection<EnumFlagViewModel<Boss>>(Enum.GetValues(typeof(Boss)).Cast<Boss>().Select(i => new EnumFlagViewModel<Boss>(i)));
        public static ObservableCollection<EnumFlagViewModel<Idol>> Idols { get; set; } = new ObservableCollection<EnumFlagViewModel<Idol>>(Enum.GetValues(typeof(Idol)).Cast<Idol>().Select(i => new EnumFlagViewModel<Idol>(i)));
        
        #endregion
    }
}
