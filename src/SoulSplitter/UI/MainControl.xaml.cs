using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using SoulSplitter.Splits;
using SoulSplitter.UI.ViewModel;

namespace SoulSplitter.UI
{
    /// <summary>
    /// Interaction logic for MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();

            _mainViewModel = (MainViewModel)DataContext;
        }

        private MainViewModel _mainViewModel;

        public MainViewModel GetMainViewModel()
        {
            return _mainViewModel;
        }

        public void SetMainViewModel(MainViewModel vm)
        {
            _mainViewModel = vm;
        }
    }
}
