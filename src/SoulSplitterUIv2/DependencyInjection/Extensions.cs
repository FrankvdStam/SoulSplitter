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
