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

using System;

namespace SoulSplitterUIv2.DependencyInjection
{
    public static class Extensions
    {
        #region scoped ================================================================================================

        //No custom constructor
        public static void AddScoped<TImplementation>(this IServiceCollection serviceCollection)
            where TImplementation : class
            => serviceCollection.AddService<TImplementation, TImplementation>(Lifetime.Scoped, null);

        public static void AddScoped<TService, TImplementation>(this IServiceCollection serviceCollection)
            where TImplementation : class, TService
            => serviceCollection.AddService<TService, TImplementation>(Lifetime.Scoped, null);

        //Custom constructor for "lowest" base type with injected service provider
        public static void AddScoped<TImplementation>(this IServiceCollection serviceCollection, Func<IServiceProvider, TImplementation> customConstructor)
            where TImplementation : class
            => serviceCollection.AddService<TImplementation, TImplementation>(Lifetime.Scoped, customConstructor);

        public static void AddScoped<TService, TImplementation>(this IServiceCollection serviceCollection, Func<IServiceProvider, TService> customConstructor)
            where TImplementation : class, TService
            => serviceCollection.AddService<TService, TImplementation>(Lifetime.Scoped, (serviceProvider) => customConstructor(serviceProvider));

        //Custom constructor for "lowest" base type without injected service provider
        public static void AddScoped<TImplementation>(this IServiceCollection serviceCollection, Func<TImplementation> customConstructor)
            where TImplementation : class
            => serviceCollection.AddService<TImplementation, TImplementation>(Lifetime.Scoped, (serviceProvider) => customConstructor());

        public static void AddScoped<TService, TImplementation>(this IServiceCollection serviceCollection, Func<TService> customConstructor)
            where TImplementation : class, TService
            => serviceCollection.AddService<TService, TImplementation>(Lifetime.Scoped, (serviceProvider) => customConstructor());

        #endregion

        #region singleton ================================================================================================

        //No custom constructor
        public static void AddSingleton<TImplementation>(this IServiceCollection serviceCollection)
            where TImplementation : class
            => serviceCollection.AddService<TImplementation, TImplementation>(Lifetime.Singleton, null);

        public static void AddSingleton<TService, TImplementation>(this IServiceCollection serviceCollection)
            where TImplementation : class, TService
            => serviceCollection.AddService<TService, TImplementation>(Lifetime.Singleton, null);

        //Custom constructor for "lowest" base type with injected service provider
        public static void AddSingleton<TImplementation>(this IServiceCollection serviceCollection, Func<IServiceProvider, TImplementation> customConstructor)
            where TImplementation : class
            => serviceCollection.AddService<TImplementation, TImplementation>(Lifetime.Singleton, customConstructor);

        public static void AddSingleton<TService, TImplementation>(this IServiceCollection serviceCollection, Func<IServiceProvider, TService> customConstructor)
            where TImplementation : class, TService
            => serviceCollection.AddService<TService, TImplementation>(Lifetime.Singleton, (serviceProvider) => customConstructor(serviceProvider));

        //Custom constructor for "lowest" base type without injected service provider
        public static void AddSingleton<TImplementation>(this IServiceCollection serviceCollection, Func<TImplementation> customConstructor)
            where TImplementation : class
            => serviceCollection.AddService<TImplementation, TImplementation>(Lifetime.Singleton, (serviceProvider) => customConstructor());

        public static void AddSingleton<TService, TImplementation>(this IServiceCollection serviceCollection, Func<TService> customConstructor)
            where TImplementation : class, TService
            => serviceCollection.AddService<TService, TImplementation>(Lifetime.Singleton, (serviceProvider) => customConstructor());

        #endregion
        
        public static T GetService<T>(this IServiceProvider serviceProvider)
        {
            return (T)serviceProvider.GetService(typeof(T));
        }
    }
}
