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

namespace SoulSplitterUIv2.Ui.View.SplitControls
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
            EventFlagList.AddRange(Enum.GetValues(_eventFlagType).Cast<Enum>().Select(i => new EventFlagViewModel(i, LanguageManager)));
        }

        #region Bindings

        public ILanguageManager LanguageManager { get; set; }

        public Type EventFlagType
        {
            get => _eventFlagType;
            set
            {
                _eventFlagType = value;
                UpdateEventFlagList();
            }
        }
        private Type _eventFlagType;

        public ObservableCollection<EventFlagViewModel> EventFlagList { get; set; } = new ObservableCollection<EventFlagViewModel>();


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
