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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using SoulSplitterUIv2.Resources;
using SoulSplitterUIv2.Ui.ViewModels;

namespace SoulSplitterUIv2.Ui.View.Controls
{
    /// <summary>
    /// Interaction logic for EnumListControl.xaml
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class EventFlagListControl : UserControl
    {
        public EventFlagListControl()
        {
            InitializeComponent();
            Loaded += (o, a) => UpdateEventFlagList();
        }

        private void UpdateEventFlagList()
        {
            if (!IsLoaded)
            {
                return;
            }

            EventFlagList.Clear();

            if (EventFlagType != null)
            {
                EventFlagList.AddRange(Enum.GetValues(EventFlagType).Cast<Enum>().Select(i => new EventFlagViewModel(i, LanguageManager)));
            }
        }

        private static void UpdateEventFlagListCallback(DependencyObject d, DependencyPropertyChangedEventArgs a)
        {
            if (d is EventFlagListControl control)
            {
                control.UpdateEventFlagList();
            }
        }

        #region Bindings

        public ILanguageManager LanguageManager { get; set; }

       

        public ObservableCollection<EventFlagViewModel> EventFlagList { get; set; } = new ObservableCollection<EventFlagViewModel>();


        public static readonly DependencyProperty EventFlagTypeDependencyProperty =
            DependencyProperty.Register(
                nameof(EventFlagType), 
                typeof(object), 
                typeof(EventFlagListControl),
                new FrameworkPropertyMetadata(
                    null, 
                    FrameworkPropertyMetadataOptions.None,
                    new PropertyChangedCallback(UpdateEventFlagListCallback)));

        public Type EventFlagType
        {
            get => (Type)GetValue(EventFlagTypeDependencyProperty);
            set
            {
                SetValue(EventFlagTypeDependencyProperty, value);
                UpdateEventFlagList();
            }
        }


        public static readonly DependencyProperty SelectedValueDependencyProperty =
            DependencyProperty.Register(nameof(SelectedEventFlag), typeof(object), typeof(EventFlagListControl),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));

        public object SelectedEventFlag
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
        
        #endregion

        #region INotifyPropertyChanged
        private bool SetField<U>(ref U field, U value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<U>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion
    }
}
