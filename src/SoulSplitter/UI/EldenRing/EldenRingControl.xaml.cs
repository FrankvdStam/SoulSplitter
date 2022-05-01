using System.Windows;
using System.Windows.Controls;

namespace SoulSplitter.UI.EldenRing
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class EldenRingControl : UserControl
    {
        private EldenRingViewModel _EldenRingViewModel;
        
        public EldenRingControl()
        {
            InitializeComponent();
            DataContextChanged += new DependencyPropertyChangedEventHandler(OnDataContextChanged);
        }

        void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is EldenRingViewModel vm)
            {
                _EldenRingViewModel = vm;
            }
        }
        
        private void AddSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _EldenRingViewModel.AddSplit();
        }

        private void RemoveSplit_OnClick(object sender, RoutedEventArgs e)
        {
            _EldenRingViewModel.RemoveSplit();
        }

        private void SplitsTreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _EldenRingViewModel.SelectedSplit = null;
            if (e.NewValue is HierarchicalSplitViewModel b)
            {
                _EldenRingViewModel.SelectedSplit = b;
            }
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                var txt = textBox.Text;
                if (uint.TryParse(txt, out uint result))
                {
                    _EldenRingViewModel.NewSplitFlag = result;
                    return;
                }
            }
            _EldenRingViewModel.NewSplitFlag = null;
        }
    }
}
