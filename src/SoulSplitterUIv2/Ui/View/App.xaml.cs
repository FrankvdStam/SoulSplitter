﻿// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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

using SoulSplitterUIv2.Resources;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using SoulSplitterUIv2.DependencyInjection;
using SoulMemory.Enums;
using SoulSplitterUIv2.Ui.ViewModels.MainViewModel;

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
