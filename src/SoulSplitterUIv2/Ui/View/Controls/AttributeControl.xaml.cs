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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using SoulSplitterUIv2.Ui.ViewModels;

namespace SoulSplitterUIv2.Ui.View.Controls
{
    /// <summary>
    /// Interaction logic for EnumListControl.xaml
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class AttributeControl : UserControl
    {
        public AttributeControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty AttributeTypeDependencyProperty =
            DependencyProperty.Register(
                nameof(AttributeType),
                typeof(object),
                typeof(AttributeControl),
                new FrameworkPropertyMetadata(
                    null,
                    FrameworkPropertyMetadataOptions.None));

        public Type AttributeType
        {
            get => (Type)GetValue(AttributeTypeDependencyProperty);
            set => SetValue(AttributeTypeDependencyProperty, value);
        }

        public static readonly DependencyProperty AttributeViewModelDependencyProperty =
            DependencyProperty.Register(
                nameof(AttributeViewModel),
                typeof(object),
                typeof(AttributeControl),
                new FrameworkPropertyMetadata(
                    null,
                    FrameworkPropertyMetadataOptions.None));

        public AttributeViewModel AttributeViewModel
        {
            get => (AttributeViewModel)GetValue(AttributeViewModelDependencyProperty);
            set => SetValue(AttributeViewModelDependencyProperty, value);
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
