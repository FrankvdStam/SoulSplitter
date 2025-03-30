using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using SoulSplitterUIv2.Ui.ViewModels;

namespace SoulSplitterUIv2.Ui.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel mainViewModel)
        {
            DataContext = mainViewModel;
            InitializeComponent();
            Closing += Window_Closing;
        }

        public bool WindowShouldHide = true;
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (WindowShouldHide)
            {
                Hide();
                e.Cancel = true;
            }
        }
    }
}
