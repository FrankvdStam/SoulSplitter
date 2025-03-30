using System;

namespace SoulSplitterUIv2.DependencyInjection
{
    public interface IServiceProvider
    {
        object GetService(Type serviceType);
    }
}
