using SoulSplitterUIv2.Resources;
using SoulSplitterUIv2.Ui.ViewModels;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using SoulSplitterUIv2.DependencyInjection;
using SoulSplitterUIv2.Enums;

namespace SoulSplitterUIv2.Ui.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class App : Application
    {
        public App()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ILanguageManager, LanguageManager>();
            serviceCollection.AddSingleton<MainViewModel>();
            Extensions.ServiceProvider = serviceCollection.Build();

            Extensions.ServiceProvider.GetService<ILanguageManager>().LoadLanguage(Language.English);
            ServiceProviderSource.Resolver = (type) => Extensions.ServiceProvider.GetService(type);
            MainWindow = new MainWindow(Extensions.ServiceProvider.GetService<MainViewModel>());
        }

        public void ShowMainWindow()
        {
            Dispatcher.Invoke(() =>
            {
                var result = MainWindow.ShowDialog();
                MainWindow.Close();
            });
        }
    }
}
