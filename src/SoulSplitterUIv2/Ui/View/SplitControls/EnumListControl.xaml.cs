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

namespace SoulSplitterUIv2.Ui.View.SplitControls
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
            ItemsSource = new ObservableCollection<Enum>(Enum.GetValues(_enumType).Cast<Enum>().ToList());
        }

        public Type EnumType
        {
            get => _enumType;
            set
            {
                _enumType = value;
                UpdateEnumList();
            }
        }
        private Type _enumType;

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
