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

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using SoulSplitterUIv2.Ui.ViewModels;

namespace SoulSplitterUIv2.Ui.View.SplitControls
{
    /// <summary>
    /// Interaction logic for SplitsList.xaml
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class SplitsList : UserControl
    {
        public SplitsList()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SplitsDependencyProperty =
            DependencyProperty.Register(nameof(Splits), typeof(ObservableCollection<SplitViewModel>), typeof(SplitsList),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));


        public ObservableCollection<SplitViewModel> Splits { get; set; } = new ObservableCollection<SplitViewModel>();

        //public static readonly DependencyProperty SelectedValueDependencyProperty =
        //    DependencyProperty.Register(nameof(SelectedEventFlag), typeof(Enum), typeof(SplitsList),
        //        new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));
    }
}
