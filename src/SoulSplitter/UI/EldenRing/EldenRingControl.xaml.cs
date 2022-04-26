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
            if (e.NewValue is HierarchicalBossViewModel b)
            {
                _EldenRingViewModel.SelectedSplit = b;
            }
        }
    }
}
