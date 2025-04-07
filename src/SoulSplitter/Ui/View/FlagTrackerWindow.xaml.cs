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
using SoulSplitter.Ui.ViewModels;

namespace SoulSplitter.Ui.View;

public partial class FlagTrackerWindow : Window
{
    public FlagTrackerWindow()
    {
        InitializeComponent();
    }

    private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
        if (DataContext is FlagTrackerViewModel flagTrackerViewModel)
        {
            if (e.NewValue is FlagDescriptionViewModel flagDescription)
            {
                flagTrackerViewModel.SelectedFlagDescription = flagDescription;
            }
            else
            {
                flagTrackerViewModel.SelectedFlagDescription = null;
            }
        }
    }
}
