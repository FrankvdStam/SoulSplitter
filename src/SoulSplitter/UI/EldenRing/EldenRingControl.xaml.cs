using System.Windows;
using System.Windows.Controls;

namespace SoulSplitter.UI.EldenRing
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class EldenRingControl : UserControl
    {
        private EldenRingViewModel _eldenRingViewModel;
        
        public EldenRingControl()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is EldenRingViewModel vm)
            {
                _eldenRingViewModel = vm;
            }
        }
        
        private void AddSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _eldenRingViewModel.AddSplit();
        }

        private void RemoveSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _eldenRingViewModel.RemoveSplit();
        }

        private void SplitsTreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _eldenRingViewModel.SelectedSplit = null;
            if (e.NewValue is HierarchicalSplitViewModel b)
            {
                _eldenRingViewModel.SelectedSplit = b;
            }
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (uint.TryParse(textBox.Text, out uint result))
                {
                    _eldenRingViewModel.NewSplitFlag = result;
                    return;
                }
            }
            _eldenRingViewModel.NewSplitFlag = null;
        }
    }
}
