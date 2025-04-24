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

using SoulMemory.Abstractions.Games;
using SoulMemory.Games.ArmoredCore6;
using SoulMemory.Games.Bloodborne;
using SoulMemory.Games.DarkSouls1;
using SoulMemory.Games.DarkSouls2;
using SoulMemory.Games.DarkSouls3;
using SoulMemory.Games.EldenRing;
using SoulMemory.Games.Sekiro;
using SoulSplitter.Resources;
using SoulSplitter.Ui.View;

namespace SoulSplitter.DependencyInjection
{
    public static class GlobalServiceProvider
    {
        private static readonly object WriteLock = new object();
        internal static IServiceProvider? _instance;

        public static IServiceProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (WriteLock)
                    {
                        var serviceCollection = new ServiceCollection();
                        serviceCollection.AddSingleton<ILanguageManager, LanguageManager>();
                        serviceCollection.AddSingleton<IDarkSouls1, DarkSouls1>();
                        serviceCollection.AddSingleton<IDarkSouls2, DarkSouls2>();
                        serviceCollection.AddSingleton<IDarkSouls3, DarkSouls3>();
                        serviceCollection.AddSingleton<ISekiro, Sekiro>();
                        serviceCollection.AddSingleton<IEldenRing, EldenRing>();
                        serviceCollection.AddSingleton<IArmoredCore6, ArmoredCore6>();
                        serviceCollection.AddSingleton<IBloodborne, Bloodborne>();

                        _instance = serviceCollection.Build();

                        ServiceProviderSource.Resolver = (type) => _instance.GetService(type);
                    }
                }
                return _instance;
            }
            //Allow overwriting for unit tests
            set
            {
                _instance = value;
            }
        }
    }
}
