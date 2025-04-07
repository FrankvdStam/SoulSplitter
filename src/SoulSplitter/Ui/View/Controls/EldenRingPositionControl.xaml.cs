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

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SoulMemory.Games.EldenRing;
using SoulSplitter.Ui.ViewModels;

namespace SoulSplitter.Ui.View.Controls;

/// <summary>
/// Interaction logic for PositionControl.xaml
/// </summary>
public partial class EldenRingPositionControl : UserControl
{
    public EldenRingPositionControl()
    {
        InitializeComponent();
        CopyCurrentPositionCommand = new RelayCommand((o) => EldenRingPositionViewModel.Position = CurrentEldenRingPosition, (o) => true);
    }

    public static readonly DependencyProperty CurrentPositionDependencyProperty =
        DependencyProperty.Register(
            nameof(CurrentEldenRingPosition),
            typeof(object),
            typeof(EldenRingPositionControl),
            new FrameworkPropertyMetadata(
                null,
                FrameworkPropertyMetadataOptions.None));

    public Position CurrentEldenRingPosition
    {
        get => (Position)GetValue(CurrentPositionDependencyProperty);
        set => SetValue(CurrentPositionDependencyProperty, value);
    }

    public static readonly DependencyProperty EldenRingPositionViewModelDependencyProperty =
        DependencyProperty.Register(
            nameof(EldenRingPositionViewModel),
            typeof(object),
            typeof(EldenRingPositionControl),
            new FrameworkPropertyMetadata(
                null,
                FrameworkPropertyMetadataOptions.None));

    public EldenRingPositionViewModel EldenRingPositionViewModel
    {
        get => (EldenRingPositionViewModel)GetValue(EldenRingPositionViewModelDependencyProperty);
        set => SetValue(EldenRingPositionViewModelDependencyProperty, value);
    }

    public RelayCommand CopyCurrentPositionCommand { get; set; }
}
