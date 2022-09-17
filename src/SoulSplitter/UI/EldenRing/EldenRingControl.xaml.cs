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

namespace SoulSplitter.UI.EldenRing
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class EldenRingControl : UserControl
    {
        private EldenRingViewModel _eldenRingViewModel;
        
        public EldenRingControl()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is EldenRingViewModel vm)
            {
                _eldenRingViewModel = vm;
            }
        }
        
        private void AddSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _eldenRingViewModel.AddSplit();
        }

        private void RemoveSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _eldenRingViewModel.RemoveSplit();
        }

        private void SplitsTreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _eldenRingViewModel.SelectedSplit = null;
            if (e.NewValue is HierarchicalSplitViewModel b)
            {
                _eldenRingViewModel.SelectedSplit = b;
            }
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (uint.TryParse(textBox.Text, out uint result))
                {
                    _eldenRingViewModel.NewSplitFlag = result;
                    return;
                }
            }
            _eldenRingViewModel.NewSplitFlag = null;
        }

        private void TextBox_OnTextChanged_CheckByte(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return;
                }

                if (byte.TryParse(textBox.Text, out byte result))
                {
                    return;
                }


            }
            //_eldenRingViewModel.NewSplitFlag = null;
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
            _eldenRingViewModel.NewSplitPosition.Area   = _eldenRingViewModel.CurrentPosition.Area  ;
            _eldenRingViewModel.NewSplitPosition.Block  = _eldenRingViewModel.CurrentPosition.Block ;
            _eldenRingViewModel.NewSplitPosition.Region = _eldenRingViewModel.CurrentPosition.Region;
            _eldenRingViewModel.NewSplitPosition.Size   = _eldenRingViewModel.CurrentPosition.Size  ;
            _eldenRingViewModel.NewSplitPosition.X      = _eldenRingViewModel.CurrentPosition.X     ;
            _eldenRingViewModel.NewSplitPosition.Y      = _eldenRingViewModel.CurrentPosition.Y     ;
            _eldenRingViewModel.NewSplitPosition.Z      = _eldenRingViewModel.CurrentPosition.Z     ;
        }
    }
}
