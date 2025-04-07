using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using SoulSplitter.Ui.ViewModels.MainViewModel;

namespace SoulSplitter.Ui.View
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

        public MainViewModel MainViewModel => (MainViewModel)DataContext;


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
