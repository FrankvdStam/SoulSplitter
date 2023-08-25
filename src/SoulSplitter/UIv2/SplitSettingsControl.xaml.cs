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

using SoulSplitter.UI.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;
using SoulMemory;
using SoulMemory.EldenRing;
using SoulSplitter.Splits;

namespace SoulSplitter.UIv2
{
    /// <summary>
    /// Interaction logic for SplitSettingsControl.xaml
    /// </summary>
    public partial class SplitSettingsControl : UserControl, INotifyPropertyChanged
    {
        public SplitSettingsControl()
        {
            CopyGamePositionCommand = new RelayCommand(CopyGamePosition, (o) => true);
            AddSplitCommand = new RelayCommand(AddSplitFunc, CanAddSplit);
            InitializeComponent();
        }


        #region Add split logic

        private bool CanAddSplit(object param)
        {
            switch (SelectedSplitType)
            {
                case SplitType.Boss:
                    return SelectedBoss != null;

                case SplitType.Attribute:
                    if (Game == Game.DarkSouls1)
                    {
                        return SelectedAttribute != null && AttributeLevel > 0 && AttributeLevel <= 99;
                    }
                    break;

                case SplitType.Bonfire:
                    if (Game == Game.DarkSouls1)
                    {
                        return SelectedBonfire != null && SelectedBonfireState != null;
                    }
                    break;

                case SplitType.Item:
                    return SelectedItem != null;

                case SplitType.Position:
                    return Position != null;

                case SplitType.Flag:
                    return FlagDescription != null;

                default:
                    throw new InvalidOperationException($"unsupported split type {SelectedSplitType}");
            }
            throw new InvalidOperationException($"Unhandled case {SelectedSplitType}");
        }

        private void AddSplitFunc(object parameter)
        {
            var flatSplit = new FlatSplit
            {
                TimingType = SelectedTimingType,
                SplitType = SelectedSplitType
            };
            
            switch (SelectedSplitType)
            {
                case SplitType.Boss:
                    flatSplit.Split = SelectedBoss;
                    break;

                case SplitType.Attribute:
                    if (Game == Game.DarkSouls1)
                    {
                        flatSplit.Split = new Splits.DarkSouls1.Attribute(){ AttributeType = (SoulMemory.DarkSouls1.Attribute)SelectedAttribute, Level = AttributeLevel};
                        break;
                    }
                    break;

                case SplitType.Bonfire:
                    if (Game == Game.DarkSouls1)
                    {
                        flatSplit.Split = new Splits.DarkSouls1.BonfireState(){ Bonfire = (SoulMemory.DarkSouls1.Bonfire)SelectedBonfire, State = (SoulMemory.DarkSouls1.BonfireState)SelectedBonfireState };
                        break;
                    }
                    break;

                case SplitType.Item:
                    flatSplit.Split = SelectedItem;
                    break;

                case SplitType.Position:
                    flatSplit.Split = new VectorSize{Description = Position.Description, Position = new Vector3f(Position.Position.X, Position.Position.Y, Position.Position.Z), Size = Position.Size};
                    break;

                case SplitType.Flag:
                    flatSplit.Split = new FlagDescription{Description = FlagDescription.Description, Flag = FlagDescription.Flag};
                    break;

                default:
                    throw new InvalidOperationException($"unsupported split type {SelectedSplitType}");
            }
            AddSplit.Execute(flatSplit);
        }



        #endregion

        #region Configuration properties

        public Game Game { get; set; }


        public static readonly DependencyProperty BooleanFlagsDependencyProperty =
            DependencyProperty.Register(nameof(BooleanFlags), typeof(ObservableCollection<BoolDescriptionViewModel>), typeof(SplitSettingsControl),
                new FrameworkPropertyMetadata(new ObservableCollection<BoolDescriptionViewModel>(), FrameworkPropertyMetadataOptions.None));

        public ObservableCollection<BoolDescriptionViewModel> BooleanFlags
        {
            get => (ObservableCollection<BoolDescriptionViewModel>)GetValue(BooleanFlagsDependencyProperty);
            set => SetValue(BooleanFlagsDependencyProperty, value);
        }

        public static readonly DependencyProperty TimingTypeDependencyProperty =
            DependencyProperty.Register(nameof(TimingTypes), typeof(ObservableCollection<EnumFlagViewModel<TimingType>>), typeof(SplitSettingsControl),
                new FrameworkPropertyMetadata(new ObservableCollection<EnumFlagViewModel<TimingType>>(), FrameworkPropertyMetadataOptions.None));

        public ObservableCollection<EnumFlagViewModel<TimingType>> TimingTypes
        {
            get => (ObservableCollection<EnumFlagViewModel<TimingType>>)GetValue(TimingTypeDependencyProperty);
            set => SetValue(TimingTypeDependencyProperty, value);
        }

        public static readonly DependencyProperty SplitTypeDependencyProperty =
            DependencyProperty.Register(nameof(SplitTypes), typeof(ObservableCollection<EnumFlagViewModel<SplitType>>), typeof(SplitSettingsControl),
                new FrameworkPropertyMetadata(new ObservableCollection<EnumFlagViewModel<SplitType>>(), FrameworkPropertyMetadataOptions.None));

        public ObservableCollection<EnumFlagViewModel<SplitType>> SplitTypes
        {
            get => (ObservableCollection<EnumFlagViewModel<SplitType>>)GetValue(SplitTypeDependencyProperty);
            set => SetValue(SplitTypeDependencyProperty, value);
        }

        public static readonly DependencyProperty BossesDependencyProperty =
            DependencyProperty.Register(nameof(Bosses), typeof(IList), typeof(SplitSettingsControl),
                new FrameworkPropertyMetadata(new ObservableCollection<EnumFlagViewModel<Enum>>(), FrameworkPropertyMetadataOptions.None));

        public ObservableCollection<EnumFlagViewModel<Enum>> Bosses
        {
            get => (ObservableCollection<EnumFlagViewModel<Enum>>)GetValue(BossesDependencyProperty);
            set => SetValue(BossesDependencyProperty, value);
        }

        public static readonly DependencyProperty AttributesDependencyProperty =
            DependencyProperty.Register(nameof(Attributes), typeof(IList), typeof(SplitSettingsControl),
                new FrameworkPropertyMetadata(new ObservableCollection<EnumFlagViewModel<Enum>>(), FrameworkPropertyMetadataOptions.None));

        public ObservableCollection<EnumFlagViewModel<Enum>> Attributes
        {
            get => (ObservableCollection<EnumFlagViewModel<Enum>>)GetValue(AttributesDependencyProperty);
            set => SetValue(AttributesDependencyProperty, value);
        }


        public static readonly DependencyProperty BonfiresDependencyProperty =
            DependencyProperty.Register(nameof(Bonfires), typeof(IList), typeof(SplitSettingsControl),
                new FrameworkPropertyMetadata(new ObservableCollection<EnumFlagViewModel<Enum>>(), FrameworkPropertyMetadataOptions.None));

        public ObservableCollection<EnumFlagViewModel<Enum>> Bonfires
        {
            get => (ObservableCollection<EnumFlagViewModel<Enum>>)GetValue(BonfiresDependencyProperty);
            set => SetValue(BonfiresDependencyProperty, value);
        }

        public static readonly DependencyProperty SplitsViewModelDependencyProperty =
            DependencyProperty.Register(nameof(SplitsViewModel), typeof(SplitsViewModel), typeof(SplitSettingsControl),
                new FrameworkPropertyMetadata(new SplitsViewModel(), FrameworkPropertyMetadataOptions.None));

        public SplitsViewModel SplitsViewModel
        {
            get => (SplitsViewModel)GetValue(SplitsViewModelDependencyProperty);
            set => SetValue(SplitsViewModelDependencyProperty, value);
        }

        public static readonly DependencyProperty ItemsDependencyProperty =
            DependencyProperty.Register(nameof(Items), typeof(IList), typeof(SplitSettingsControl),
                new FrameworkPropertyMetadata(new ObservableCollection<EnumFlagViewModel<Enum>>(), FrameworkPropertyMetadataOptions.None));
        
        public ObservableCollection<EnumFlagViewModel<Enum>> Items
        {
            get => (ObservableCollection<EnumFlagViewModel<Enum>>)GetValue(ItemsDependencyProperty);
            set => SetValue(ItemsDependencyProperty, value);
        }

        public static readonly DependencyProperty GamePositionDependencyProperty =
            DependencyProperty.Register(nameof(GamePosition), typeof(Vector3f), typeof(SplitSettingsControl),
                new FrameworkPropertyMetadata(new Vector3f(), FrameworkPropertyMetadataOptions.None));

        public Vector3f GamePosition
        {
            get => (Vector3f)GetValue(GamePositionDependencyProperty);
            set => SetValue(GamePositionDependencyProperty, value);
        }

        public static readonly DependencyProperty AddSplitDependencyProperty =
            DependencyProperty.Register(nameof(AddSplit), typeof(RelayCommand), typeof(SplitSettingsControl),
                new FrameworkPropertyMetadata(new RelayCommand(null), FrameworkPropertyMetadataOptions.None));

        public RelayCommand AddSplit
        {
            get => (RelayCommand)GetValue(AddSplitDependencyProperty);
            set => SetValue(AddSplitDependencyProperty, value);
        }

        #endregion

        #region Commands

        public RelayCommand AddSplitCommand
        {
            get => _addSplitCommand;
            set => SetField(ref _addSplitCommand, value);
        }
        private RelayCommand _addSplitCommand;

        public RelayCommand RemoveSplitCommand
        {
            get => _removeSplitCommand;
            set => SetField(ref _removeSplitCommand, value);
        }
        private RelayCommand _removeSplitCommand;

        public RelayCommand CopyGamePositionCommand
        {
            get => _copyGamePositionCommand;
            set => SetField(ref _copyGamePositionCommand, value);
        }
        private RelayCommand _copyGamePositionCommand;

        private void CopyGamePosition(object param)
        {
            Position.Position = GamePosition.Clone();
        }
        #endregion

        #region Selected properties

        public TimingType SelectedTimingType
        {
            get => _selectedTimingType;
            set => SetField(ref _selectedTimingType, value);
        }
        private TimingType _selectedTimingType = TimingType.Immediate;

        public SplitType SelectedSplitType
        {
            get => _selectedSplitType;
            set => SetField(ref _selectedSplitType, value);
        }
        private SplitType _selectedSplitType = SplitType.Boss;

        public Enum SelectedBoss
        {
            get => _selectedBoss;
            set => SetField(ref _selectedBoss, value);
        }
        private Enum _selectedBoss;

        public Enum SelectedBonfire
        {
            get => _selectedBonfire;
            set => SetField(ref _selectedBonfire, value);
        }
        private Enum _selectedBonfire;

        //For dark souls 1 specifically
        public Enum SelectedBonfireState
        {
            get => _selectedBonfireState;
            set => SetField(ref _selectedBonfireState, value);
        }
        private Enum _selectedBonfireState;

        public Enum SelectedAttribute
        {
            get => _selectedAttribute;
            set => SetField(ref _selectedAttribute, value);
        }
        private Enum _selectedAttribute;

        public int AttributeLevel
        {
            get => _attributeLevel;
            set => SetField(ref _attributeLevel, value);
        }
        private int _attributeLevel = 10;

        public Enum SelectedItem
        {
            get => _selectedItem;
            set => SetField(ref _selectedItem, value);
        }
        private Enum _selectedItem;

        public VectorSize Position
        {
            get => _position;
            set => SetField(ref _position, value);
        }
        private VectorSize _position = new VectorSize();

        public FlagDescription FlagDescription
        {
            get => _flagDescription;
            set => SetField(ref _flagDescription, value);
        }
        private FlagDescription _flagDescription = new FlagDescription();
        #endregion


        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (sender is TreeView treeView)
            {
                if (treeView.SelectedItem is SplitViewModel splitViewModel)
                {
                    SplitsViewModel.SelectedSplit = splitViewModel;
                }
                else
                {
                    SplitsViewModel.SelectedSplit = null;
                }
            }
        }


        #region INotifyPropertyChanged
        private bool SetField<U>(ref U field, U value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<U>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion

    }
}
