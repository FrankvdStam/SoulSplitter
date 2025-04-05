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
using System.Windows;
using System.Windows.Controls;
using SoulMemory;
using SoulSplitterUIv2.Ui.ViewModels;

namespace SoulSplitterUIv2.Ui.View.Controls;

/// <summary>
/// Interaction logic for PositionControl.xaml
/// </summary>
public partial class PositionControl : UserControl
{
    public PositionControl()
    {
        InitializeComponent();
        CopyCurrentPositionCommand = new RelayCommand.RelayCommand((o) => PositionViewModel.Position = CurrentPosition, (o) => true);
    }

    public static readonly DependencyProperty CurrentPositionDependencyProperty =
        DependencyProperty.Register(
            nameof(CurrentPosition),
            typeof(object),
            typeof(PositionControl),
            new FrameworkPropertyMetadata(
                null,
                FrameworkPropertyMetadataOptions.None));

    public Vector3f CurrentPosition
    {
        get => (Vector3f)GetValue(CurrentPositionDependencyProperty);
        set => SetValue(CurrentPositionDependencyProperty, value);
    }

    public static readonly DependencyProperty PositionViewModelDependencyProperty =
        DependencyProperty.Register(
            nameof(PositionViewModel),
            typeof(object),
            typeof(PositionControl),
            new FrameworkPropertyMetadata(
                null,
                FrameworkPropertyMetadataOptions.None));

    public PositionViewModel PositionViewModel
    {
        get => (PositionViewModel)GetValue(PositionViewModelDependencyProperty);
        set => SetValue(PositionViewModelDependencyProperty, value);
    }

    public RelayCommand.RelayCommand CopyCurrentPositionCommand { get; set; }
}
