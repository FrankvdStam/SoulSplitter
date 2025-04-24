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

using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using SoulSplitter.Ui.ViewModels;

namespace SoulSplitter.Ui.View.Controls
{
    [ExcludeFromCodeCoverage]
    public partial class DarkSouls1BonfireControl : UserControl
    {
        public DarkSouls1BonfireControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty DarkSouls1BonfireViewModelDependencyProperty =
            DependencyProperty.Register(
                nameof(DarkSouls1BonfireViewModel),
                typeof(DarkSouls1BonfireViewModel),
                typeof(DarkSouls1BonfireControl),
                new FrameworkPropertyMetadata(
                    null,
                    FrameworkPropertyMetadataOptions.None));

        public DarkSouls1BonfireViewModel DarkSouls1BonfireViewModel
        {
            get => (DarkSouls1BonfireViewModel)GetValue(DarkSouls1BonfireViewModelDependencyProperty);
            set => SetValue(DarkSouls1BonfireViewModelDependencyProperty, value);
        }

        
        #region INotifyPropertyChanged
        private void SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion
    }
}
