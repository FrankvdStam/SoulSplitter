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

namespace SoulSplitter.UI.Generic
{
    /// <summary>
    /// Interaction logic for SplitsTree.xaml
    /// </summary>
    public partial class SplitsTree : UserControl
    {
        public SplitsTree()
        {
            InitializeComponent();
        }

        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (sender is TreeView treeView && treeView.DataContext is BaseViewModel baseViewModel)
            {
                if (treeView.SelectedItem is SplitViewModel splitViewModel)
                {
                    baseViewModel.SplitsViewModel.SelectedSplit = splitViewModel;
                }
                else
                {
                    baseViewModel.SplitsViewModel.SelectedSplit = null;
                }
            }
        }
    }
}
