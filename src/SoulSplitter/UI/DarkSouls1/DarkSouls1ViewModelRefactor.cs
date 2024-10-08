﻿// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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
using System.Xml.Serialization;
using SoulMemory.DarkSouls1;
using SoulSplitter.Splits;
using SoulSplitter.Splits.DarkSouls1;
using SoulSplitter.UI.Generic;
using Attribute = SoulMemory.DarkSouls1.Attribute;
using BonfireState = SoulMemory.DarkSouls1.BonfireState;

namespace SoulSplitter.UI.DarkSouls1
{
    public class DarkSouls1ViewModelRefactor : BaseViewModel
    {
        public DarkSouls1ViewModelRefactor()
        {
            AddSplitCommand = new RelayCommand(AddSplit, CanAddSplit);
        }

        public new bool StartAutomatically => BooleanFlags[0].Value;
        public bool ResetInventoryIndices => BooleanFlags[1].Value;
        
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
                case SplitType.Attribute:
                    return NewSplitValue != null;

                case SplitType.Position:
                    return Position != null;

                case SplitType.Flag:
                    return FlagDescription != null;

                case SplitType.Bonfire:
                    return NewSplitBonfireState != null && NewSplitBonfireState.Bonfire != null;

                case SplitType.Item:
                    return NewSplitItemState != null && NewSplitItemState.ItemType != null;

                case SplitType.Credits:
                    return NewSplitTimingType != null;
            }
        }

        private void AddSplit(object param)
        {
            if (param is FlatSplit f)
            {
                SplitsViewModel.AddSplit(f.TimingType, f.SplitType, f.Split);
            }
        }


        #endregion

        #region Properties for new splits ============================================================================================================================================

        [XmlIgnore]
        public new SplitType? NewSplitType
        {
            get => _newSplitType;
            set
            {
                SetField(ref _newSplitType, value);

                switch (NewSplitType)
                {
                    case SplitType.Attribute:
                        NewSplitValue = new Splits.DarkSouls1.Attribute() { AttributeType = SoulMemory.DarkSouls1.Attribute.Vitality, Level = 10 };
                        break;

                    case SplitType.Position:
                        Position = new VectorSize() { Position = CurrentPosition.Clone() };
                        break;

                    case SplitType.Flag:
                        FlagDescription = new FlagDescription();
                        break;

                    case SplitType.Bonfire:
                        NewSplitBonfireState = new Splits.DarkSouls1.BonfireState() { State = BonfireState.Unlocked };
                        break;

                    case SplitType.Item:
                        NewSplitItemState = new ItemState();
                        break;
                }
            }
        }

        private SplitType? _newSplitType = null;

        [XmlIgnore]
        public Splits.DarkSouls1.BonfireState NewSplitBonfireState
        {
            get => _newSplitBonfireState;
            set => SetField(ref _newSplitBonfireState, value);
        }

        private Splits.DarkSouls1.BonfireState _newSplitBonfireState;

        [XmlIgnore]
        public ItemState NewSplitItemState
        {
            get => _newSplitItemState;
            set => SetField(ref _newSplitItemState, value);
        }

        private ItemState _newSplitItemState;

        #endregion

        #region Static UI source data ============================================================================================================================================
        public ObservableCollection<BoolDescriptionViewModel> BooleanFlags { get; set; } = new ObservableCollection<BoolDescriptionViewModel>()
        {
            new BoolDescriptionViewModel(){ Description = "Start automatically",     Value = true },
            new BoolDescriptionViewModel(){ Description = "Reset inventory indices", Value = true }
        };

        public static ObservableCollection<EnumFlagViewModel<TimingType>> TimingTypes { get; set; } = new ObservableCollection<EnumFlagViewModel<TimingType>>()
        {
            new EnumFlagViewModel<TimingType>(TimingType.Immediate),
            new EnumFlagViewModel<TimingType>(TimingType.OnLoading),
            new EnumFlagViewModel<TimingType>(TimingType.OnWarp),
        };

        public static ObservableCollection<EnumFlagViewModel<SplitType>> SplitTypes { get; set; } = new ObservableCollection<EnumFlagViewModel<SplitType>>()
        {
            new EnumFlagViewModel<SplitType>(SplitType.Boss),
            new EnumFlagViewModel<SplitType>(SplitType.Attribute),
            new EnumFlagViewModel<SplitType>(SplitType.Bonfire),
            new EnumFlagViewModel<SplitType>(SplitType.Item),
            new EnumFlagViewModel<SplitType>(SplitType.Position),
            new EnumFlagViewModel<SplitType>(SplitType.Flag),
        };
        
        public static ObservableCollection<EnumFlagViewModel<Boss>> Bosses { get; set; } = EnumFlagViewModel<Boss>.GetEnumViewModels();
        public static ObservableCollection<EnumFlagViewModel<Attribute>> Attributes { get; set; } = EnumFlagViewModel<Attribute>.GetEnumViewModels();
        public static ObservableCollection<EnumFlagViewModel<Bonfire>> Bonfires { get; set; } = EnumFlagViewModel<Bonfire>.GetEnumViewModels();
        public static ObservableCollection<EnumFlagViewModel<ItemType>> Items { get; set; } = EnumFlagViewModel<ItemType>.GetEnumViewModels();
        
        #endregion
    }
}
