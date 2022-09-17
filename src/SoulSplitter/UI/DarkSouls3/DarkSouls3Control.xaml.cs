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
using SoulSplitter.Splits.DarkSouls3;

namespace SoulSplitter.UI.DarkSouls3
{
    /// <summary>
    /// Interaction logic for DarkSouls3Control.xaml
    /// </summary>
    public partial class DarkSouls3Control : UserControl
    {
        public DarkSouls3Control()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is DarkSouls3ViewModel vm)
            {
                _darkSouls3ViewModel = vm;
            }
        }
        private DarkSouls3ViewModel _darkSouls3ViewModel;

        private void AddSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _darkSouls3ViewModel.AddSplit();
        }

        private void RemoveSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _darkSouls3ViewModel.RemoveSplit();
        }

        private void TextBoxRawFlag_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (_darkSouls3ViewModel.NewSplitType != null && _darkSouls3ViewModel.NewSplitType == SplitType.Flag && sender is TextBox textBox)
            {
                if (uint.TryParse(textBox.Text, out uint result))
                {
                    _darkSouls3ViewModel.NewSplitValue = result;
                    return;
                }
                _darkSouls3ViewModel.NewSplitValue = null;
                textBox.Text = string.Empty;
            }
        }
        private void SplitsTreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _darkSouls3ViewModel.SelectedSplit = null;
            if (e.NewValue is HierarchicalSplitViewModel b)
            {
                _darkSouls3ViewModel.SelectedSplit = b;
            }
        }
    }
}
