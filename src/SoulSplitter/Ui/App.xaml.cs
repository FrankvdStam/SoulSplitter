// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using SoulSplitter.Resources;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using SoulSplitter.DependencyInjection;
using SoulMemory.Enums;
using SoulSplitter.Ui.View;
using SoulSplitter.Ui.ViewModels.MainViewModel;
using SoulSplitter.Utils;
using Extensions = SoulSplitter.Utils.Extensions;

namespace SoulSplitter.Ui;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
[ExcludeFromCodeCoverage]
public partial class App : Application
{
    public static DependencyInjection.IServiceProvider ServiceProvider { get; set; } = null!;

    public App()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<ILanguageManager, LanguageManager>();
        serviceCollection.AddSingleton<MainViewModel>();
        ServiceProvider = serviceCollection.Build();

        ServiceProvider.GetService<ILanguageManager>().LoadLanguage(Language.English);
        ServiceProviderSource.Resolver = (type) => ServiceProvider.GetService(type);
        MainWindow = new SoulSplitter.Ui.View.MainWindow(ServiceProvider.GetService<MainViewModel>());
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
