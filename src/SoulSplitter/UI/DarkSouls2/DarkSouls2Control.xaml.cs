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
using SoulSplitter.Splits.DarkSouls2;

namespace SoulSplitter.UI.DarkSouls2
{
    /// <summary>
    /// Interaction logic for DarkSouls3Control.xaml
    /// </summary>
    public partial class DarkSouls2Control : UserControl
    {
        public DarkSouls2Control()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is DarkSouls2ViewModel vm)
            {
                _darkSouls2ViewModel = vm;
            }
        }
        private DarkSouls2ViewModel _darkSouls2ViewModel;

        private void AddSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _darkSouls2ViewModel.AddSplit();
        }

        private void RemoveSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _darkSouls2ViewModel.RemoveSplit();
        }

        private void TextBoxRawFlag_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (_darkSouls2ViewModel.NewSplitType != null && _darkSouls2ViewModel.NewSplitType == DarkSouls2SplitType.Flag && sender is TextBox textBox)
            {
                if (uint.TryParse(textBox.Text, out uint result))
                {
                    _darkSouls2ViewModel.NewSplitValue = result;
                    return;
                }
                _darkSouls2ViewModel.NewSplitValue = null;
                textBox.Text = string.Empty;
            }
        }
        private void SplitsTreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _darkSouls2ViewModel.SelectedSplit = null;
            if (e.NewValue is HierarchicalSplitViewModel b)
            {
                _darkSouls2ViewModel.SelectedSplit = b;
            }
        }

        private void OnPreviewTextInput_Float(object sender, TextCompositionEventArgs e)
        {
            if (sender is TextBox t)
            {
                var newText = t.Text + e.Text;
                if (string.IsNullOrWhiteSpace(newText) || newText == "-" || float.TryParse(newText, out _))
                {
                    return;
                }
                e.Handled = true;
            }
        }

        private void CopyPosition_OnClick(object sender, RoutedEventArgs e)
        {
            _darkSouls2ViewModel.NewSplitValue = _darkSouls2ViewModel.CurrentPosition.Clone();
        }
    }
}
