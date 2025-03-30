using System;
using System.Collections.Generic;

namespace SoulSplitterUIv2.DependencyInjection
{
    public class ServiceProvider : IServiceProvider
    {
        private readonly Dictionary<Type, ServiceDescriptor> _serviceDescriptors;
        private readonly Dictionary<Type, object> _singletons = new Dictionary<Type, object>();

        public ServiceProvider(Dictionary<Type, ServiceDescriptor> serviceDescriptors)
        {
            _serviceDescriptors = serviceDescriptors;
        }

        /// <summary>
        /// Get service of a given type
        /// When there is no scope active, only singletons can be retrieved
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns>Service of the given type</returns>
        /// <exception cref="ServiceProviderException"></exception>
        public object GetService(Type serviceType)
        {
            if (!_serviceDescriptors.TryGetValue(serviceType, out ServiceDescriptor serviceDescriptor))
            {
                throw new ServiceProviderException($"{serviceType} is not registered");
            }

            if (serviceDescriptor.Lifetime == Lifetime.Singleton)
            {
                if (!_singletons.TryGetValue(serviceDescriptor.ServiceType, out object instance))
                {
                    instance = serviceDescriptor.Activate(this);
                    _singletons.Add(serviceDescriptor.ServiceType, instance);
                }
                return instance;
            }
            else
            {
                throw new ServiceProviderException($"{serviceType} is not a singleton and requires a scope");
            }
        }

        public ServiceProviderScope CreateScope() => new ServiceProviderScope(_serviceDescriptors, this);
    }
}
