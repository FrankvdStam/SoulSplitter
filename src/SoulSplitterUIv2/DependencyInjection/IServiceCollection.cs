using System;

namespace SoulSplitterUIv2.DependencyInjection
{
    public interface IServiceCollection
    {
        void AddService<TService, TImplementation>(Lifetime lifetime, Func<IServiceProvider, object> customConstructor);
        ServiceProvider Build();
    }
}
