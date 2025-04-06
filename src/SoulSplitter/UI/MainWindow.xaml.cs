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

using System.ComponentModel;
using System.Windows;

namespace SoulSplitter.UI;

/// <summary>
/// Interaction logic for MainControl.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Closing += Window_Closing;

        //UiV2TabItem.Content = Application.Current.MainWindow.Content;
    }

    public bool WindowShouldHide = true;
    private void Window_Closing(object sender, CancelEventArgs e)
    {
        if (WindowShouldHide)
        {
            Hide();
            e.Cancel = true;
        }
    }
    
    public MainViewModel MainViewModel
    {
        get => (MainViewModel)DataContext;
        set => ((MainViewModel)DataContext).Update(value);
    }
}
