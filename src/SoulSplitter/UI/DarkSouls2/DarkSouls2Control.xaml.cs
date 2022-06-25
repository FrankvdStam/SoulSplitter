using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SoulMemory;
using SoulSplitter.Splits.DarkSouls2;

namespace SoulSplitter.UI.DarkSouls2
{
    /// <summary>
    /// Interaction logic for DarkSouls3Control.xaml
    /// </summary>
    public partial class DarkSouls2Control : UserControl
    {
        public DarkSouls2Control()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is DarkSouls2ViewModel vm)
            {
                _darkSouls2ViewModel = vm;
            }
        }
        private DarkSouls2ViewModel _darkSouls2ViewModel;

        private void AddSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _darkSouls2ViewModel.AddSplit();
        }

        private void RemoveSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _darkSouls2ViewModel.RemoveSplit();
        }

        private void TextBoxRawFlag_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (_darkSouls2ViewModel.NewSplitType != null && _darkSouls2ViewModel.NewSplitType == DarkSouls2SplitType.Flag && sender is TextBox textBox)
            {
                if (uint.TryParse(textBox.Text, out uint result))
                {
                    _darkSouls2ViewModel.NewSplitValue = result;
                    return;
                }
                _darkSouls2ViewModel.NewSplitValue = null;
                textBox.Text = string.Empty;
            }
        }
        private void SplitsTreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _darkSouls2ViewModel.SelectedSplit = null;
            if (e.NewValue is HierarchicalSplitViewModel b)
            {
                _darkSouls2ViewModel.SelectedSplit = b;
            }
        }

        private void OnPreviewTextInput_Float(object sender, TextCompositionEventArgs e)
        {
            if (sender is TextBox t)
            {
                var newText = t.Text + e.Text;
                if (string.IsNullOrWhiteSpace(newText) || newText == "-" || float.TryParse(newText, out _))
                {
                    return;
                }
                e.Handled = true;
            }
        }

        private void CopyPosition_OnClick(object sender, RoutedEventArgs e)
        {
            _darkSouls2ViewModel.NewSplitValue = _darkSouls2ViewModel.CurrentPosition.Clone();
        }
    }
}
