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

namespace SoulSplitter.UiOld.EldenRing;

/// <summary>
/// Interaction logic for UserControl1.xaml
/// </summary>
public partial class EldenRingControl : UserControl
{
    public EldenRingControl()
    {
        InitializeComponent();
    }
    
    private EldenRingViewModel GetEldenRingViewModel()
    {
        return (DataContext as EldenRingViewModel)!;
    }

    private void AddSplit_OnClick(object sender, RoutedEventArgs e)
    {
        GetEldenRingViewModel().AddSplit();
    }

    private void RemoveSplit_OnClick(object sender, RoutedEventArgs e)
    {
        GetEldenRingViewModel().RemoveSplit();
    }

    private void SplitsTreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
        GetEldenRingViewModel().SelectedSplit = null;
        if (e.NewValue is HierarchicalSplitViewModel b)
        {
            GetEldenRingViewModel().SelectedSplit = b;
        }
    }

    private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        if (sender is TextBox textBox && uint.TryParse(textBox.Text, out var result))
        {
            GetEldenRingViewModel().NewSplitFlag = result;
            return;
        }
        GetEldenRingViewModel().NewSplitFlag = null;
    }

    private void OnPreviewTextInput_Byte(object sender, TextCompositionEventArgs e)
    {
        if (sender is TextBox t)
        {
            var newText = t.Text + e.Text;
            if (string.IsNullOrWhiteSpace(newText) || byte.TryParse(newText, out _))
            {
                return;
            }
            e.Handled = true;
        }
    }

    private void OnPreviewTextInput_Float(object sender, TextCompositionEventArgs e)
    {
        if (sender is TextBox t)
        {
            var newText = t.Text + e.Text;
            if (string.IsNullOrWhiteSpace(newText) || float.TryParse(newText, out _))
            {
                return;
            }
            e.Handled = true;
        }
    }

    private void CopyPosition_OnClick(object sender, RoutedEventArgs e)
    {
        var vm = GetEldenRingViewModel();
        vm.NewSplitPosition!.Position.Area  = vm.CurrentEldenRingPosition.Position.Area  ;
        vm.NewSplitPosition.Position.Block  = vm.CurrentEldenRingPosition.Position.Block ;
        vm.NewSplitPosition.Position.Region = vm.CurrentEldenRingPosition.Position.Region;
        vm.NewSplitPosition.Position.Size   = vm.CurrentEldenRingPosition.Position.Size  ;
        vm.NewSplitPosition.Position.X      = vm.CurrentEldenRingPosition.Position.X     ;
        vm.NewSplitPosition.Position.Y      = vm.CurrentEldenRingPosition.Position.Y     ;
        vm.NewSplitPosition.Position.Z      = vm.CurrentEldenRingPosition.Position.Z     ;
    }
}
