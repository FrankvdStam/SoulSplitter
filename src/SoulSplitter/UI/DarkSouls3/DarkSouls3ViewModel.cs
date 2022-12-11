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
using System.Xml.Serialization;
using SoulMemory.DarkSouls3;
using SoulSplitter.UI.Generic;
using Attribute = SoulSplitter.Splits.DarkSouls3.Attribute;

namespace SoulSplitter.UI.DarkSouls3
{
    public class DarkSouls3ViewModel : BaseViewModel
    {
        public DarkSouls3ViewModel()
        {
            AddSplitCommand = new RelayCommand(AddSplit, CanAddSplit);
        }

        #region add/remove splits ============================================================================================================================================

        private bool CanAddSplit(object param) 
        {
            if(NewSplitTimingType == null || NewSplitType == null)
            {
                return false;
            }
            
            if(NewSplitType == SplitType.Flag)
            {
                return FlagDescription != null;
            }

            if(NewSplitType == SplitType.Position)
            {
                return Position != null;
            }

            return NewSplitValue != null;
        }

        private void AddSplit(object param)
        {
            object split = null;
            switch (NewSplitType)
            {
                default:
                    throw new Exception($"{NewSplitType} not supported");

                case SplitType.Boss:
                case SplitType.Bonfire:
                case SplitType.ItemPickup:
                case SplitType.Attribute:
                    split = NewSplitValue;
                    break;

                case SplitType.Position:
                    split = Position;
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

        #region Properties for new splits ============================================================================================================================================

        public bool LockIgtToZero
        {
            get => _lockIgtToZero;
            set => SetField(ref _lockIgtToZero, value);
        }
        private bool _lockIgtToZero = false;

        [XmlIgnore]
        public new SplitType? NewSplitType
        {
            get => _newSplitType;
            set
            {
                SetField(ref _newSplitType, value);

                if(NewSplitType == SplitType.Attribute)
                {
                    NewSplitValue = new Attribute() { AttributeType = SoulMemory.DarkSouls3.Attribute.Vigor, Level = 10 };
                }

                if(NewSplitType == SplitType.Position)
                {
                    Position = new VectorSize() { Position = CurrentPosition.Clone() };
                }

                if(NewSplitType == SplitType.Flag)
                {
                    FlagDescription = new FlagDescription();
                }
            }
        }
        private SplitType? _newSplitType = null;

        #endregion

        #region Static UI source data ============================================================================================================================================

        public static ObservableCollection<EnumFlagViewModel<Boss>> Bosses { get; set; } = new ObservableCollection<EnumFlagViewModel<Boss>>(Enum.GetValues(typeof(Boss)).Cast<Boss>().Select(i => new EnumFlagViewModel<Boss>(i)));
        public static ObservableCollection<EnumFlagViewModel<Bonfire>> Bonfires { get; set; } = new ObservableCollection<EnumFlagViewModel<Bonfire>>(Enum.GetValues(typeof(Bonfire)).Cast<Bonfire>().Select(i => new EnumFlagViewModel<Bonfire>(i)));
        public static ObservableCollection<EnumFlagViewModel<ItemPickup>> ItemPickups { get; set; } = new ObservableCollection<EnumFlagViewModel<ItemPickup>>(Enum.GetValues(typeof(ItemPickup)).Cast<ItemPickup>().Select(i => new EnumFlagViewModel<ItemPickup>(i)));

        #endregion
    }
}
