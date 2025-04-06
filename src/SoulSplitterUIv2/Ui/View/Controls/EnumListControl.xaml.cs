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

using SoulSplitterUIv2.Resources;
using SoulSplitterUIv2.Ui.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace SoulSplitterUIv2.Ui.View.Controls
{
    /// <summary>
    /// Interaction logic for EnumListControl.xaml
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class EnumListControl : UserControl
    {
        public EnumListControl()
        {
            InitializeComponent();
        }

        private void UpdateEnumList()
        {
            ItemsSource = new ObservableCollection<Enum>(Enum.GetValues(EnumType).Cast<Enum>().ToList());
        }
        
        private static void UpdateEnumList(DependencyObject d, DependencyPropertyChangedEventArgs a)
        {
            if (d is EnumListControl control)
            {
                control.UpdateEnumList();
            }
        }
        
        public static readonly DependencyProperty EnumTypeDependencyProperty =
            DependencyProperty.Register(
                nameof(EnumType),
                typeof(object),
                typeof(EnumListControl),
                new FrameworkPropertyMetadata(
                    null,
                    FrameworkPropertyMetadataOptions.None,
                    new PropertyChangedCallback(UpdateEnumList)));

        public Type EnumType
        {
            get => (Type)GetValue(EnumTypeDependencyProperty);
            set
            {
                SetValue(EnumTypeDependencyProperty, value);
                UpdateEnumList();
            }
        }

        public static readonly DependencyProperty ItemsSourceDependencyProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(IEnumerable), typeof(EnumListControl),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));

        public IEnumerable ItemsSource
        {
            get => (IEnumerable)GetValue(ItemsSourceDependencyProperty);
            set => SetValue(ItemsSourceDependencyProperty, value);
        }

        public static readonly DependencyProperty SelectedValueDependencyProperty =
            DependencyProperty.Register(nameof(SelectedValue), typeof(object), typeof(EnumListControl),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public object SelectedValue
        {
            get => GetValue(SelectedValueDependencyProperty);
            set => SetValue(SelectedValueDependencyProperty, value);
        }

        public string Hint
        {
            get => _hint;
            set => SetField(ref _hint, value);
        }
        private string _hint;

        #region INotifyPropertyChanged
        private void SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
