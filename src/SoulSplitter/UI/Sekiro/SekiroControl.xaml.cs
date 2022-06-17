using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SoulMemory;
using SoulSplitter.Splits.Sekiro;

namespace SoulSplitter.UI.Sekiro
{
    /// <summary>
    /// Interaction logic for DarkSouls3Control.xaml
    /// </summary>
    public partial class SekiroControl : UserControl
    {
        public SekiroControl()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is SekiroViewModel vm)
            {
                _sekiroViewModel = vm;
            }
        }
        private SekiroViewModel _sekiroViewModel;

        private void AddSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _sekiroViewModel.AddSplit();
        }

        private void RemoveSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _sekiroViewModel.RemoveSplit();
        }

        private void TextBoxRawFlag_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (_sekiroViewModel.NewSplitType != null && _sekiroViewModel.NewSplitType == SplitType.Flag && sender is TextBox textBox)
            {
                if (uint.TryParse(textBox.Text, out uint result))
                {
                    _sekiroViewModel.NewSplitValue = result;
                    return;
                }
                _sekiroViewModel.NewSplitValue = null;
                textBox.Text = string.Empty;
            }
        }
        private void SplitsTreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _sekiroViewModel.SelectedSplit = null;
            if (e.NewValue is HierarchicalSplitViewModel b)
            {
                _sekiroViewModel.SelectedSplit = b;
            }
        }

        private void OnPreviewTextInput_Float(object sender, TextCompositionEventArgs e)
        {
            if (sender is TextBox t)
            {
                var newText = t.Text + e.Text;
                if (string.IsNullOrWhiteSpace(newText) || float.TryParse(newText, out _))
                {
                    return;
                }
                e.Handled = true;
            }
        }

        private void CopyPosition_OnClick(object sender, RoutedEventArgs e)
        {
            _sekiroViewModel.NewSplitValue = _sekiroViewModel.CurrentPosition.Clone();
        }
    }
}
