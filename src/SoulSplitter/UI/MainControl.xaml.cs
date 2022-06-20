using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using SoulMemory.Memory;

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
        }
        
        public MainViewModel MainViewModel
        {
            get => (MainViewModel)DataContext;
            set => ((MainViewModel)DataContext).Update(value);
        }
        
        private void Troubleshooting_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/FrankvdStam/SoulSplitter/wiki/troubleshooting");
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void EventFlagLogger_OnClick(object sender, RoutedEventArgs e)
        {
            var games = new List<string>()
            {
                "darksoulsremastered",
                "darksoulsii",
                "darksoulsiii",
                "sekiro",
                "eldenring",
            };

            var process = Process.GetProcesses().FirstOrDefault(p => games.Contains(p.ProcessName.ToLower()));
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetAssembly(typeof(MainControl)).Location) + @"\soulinjectee.dll";

            if (process != null && File.Exists(path))
            {
                process.InjectDll(path);
            }
        }
    }
}
