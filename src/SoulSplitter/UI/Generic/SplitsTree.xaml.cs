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

namespace SoulSplitter.UI.Generic
{
    /// <summary>
    /// Interaction logic for SplitsTree.xaml
    /// </summary>
    public partial class SplitsTree : UserControl
    {
        public SplitsTree()
        {
            InitializeComponent();
        }
        
        public static readonly DependencyProperty SplitsViewModelDependencyProperty =
            DependencyProperty.Register(nameof(SplitsViewModel), typeof(SplitsViewModel), typeof(SplitsTree),
                new FrameworkPropertyMetadata(new SplitsViewModel(), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public SplitsViewModel SplitsViewModel
        {
            get =>(SplitsViewModel)GetValue(SplitsViewModelDependencyProperty);
            set => SetValue(SplitsViewModelDependencyProperty, value);
        }
        
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
    }
}
