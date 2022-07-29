using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SoulSplitter.Splits.DarkSouls1;

namespace SoulSplitter.UI.DarkSouls1
{
    /// <summary>
    /// Interaction logic for DarkSouls1Control.xaml
    /// </summary>
    public partial class DarkSouls1Control : UserControl
    {
        public DarkSouls1Control()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is DarkSouls1ViewModel vm)
            {
                _darkSouls1ViewModel = vm;
            }
        }
        private DarkSouls1ViewModel _darkSouls1ViewModel;

        private void AddSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _darkSouls1ViewModel.AddSplit();
        }

        private void RemoveSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _darkSouls1ViewModel.RemoveSplit();
        }


        private void TextBoxRawFlag_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (_darkSouls1ViewModel.NewSplitType != null && _darkSouls1ViewModel.NewSplitType == DarkSouls1SplitType.Flag && sender is TextBox textBox)
            {
                if (uint.TryParse(textBox.Text, out uint result))
                {
                    ((FlagDescription)_darkSouls1ViewModel.NewSplitValue).Flag = result;
                    return;
                }
                _darkSouls1ViewModel.NewSplitValue = null;
                textBox.Text = string.Empty;
            }
        }

        private void SplitsTreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _darkSouls1ViewModel.SelectedSplit = null;
            if (e.NewValue is HierarchicalSplitViewModel b)
            {
                _darkSouls1ViewModel.SelectedSplit = b;
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
            _darkSouls1ViewModel.NewSplitValue = _darkSouls1ViewModel.CurrentPosition.Clone();
        }
    }
}
