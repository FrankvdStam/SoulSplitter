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

namespace SoulTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        private MainViewModel _mainViewModel;

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is MainViewModel vm)
            {
                _mainViewModel = vm;
            }
        }


        //private SettingsWindow _settingsWindow;
        //
        //private void Settings_OnClick(object sender, RoutedEventArgs e)
        //{ 
        //    _settingsWindow = new SettingsWindow();
        //    _settingsWindow.DataContext = _mainViewModel;
        //    _settingsWindow.Show();
        //}
    }
}
