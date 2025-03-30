using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SoulSplitterUIv2.DependencyInjection
{
    public class ServiceCollection : IServiceCollection
    {
        private readonly Dictionary<Type, ServiceDescriptor> _services = new Dictionary<Type, ServiceDescriptor>();

        /// <summary>
        /// Register a given service with it's given lifetime and potential custom constructor
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        /// <param name="lifetime"></param>
        /// <param name="customConstructor"></param>
        public void AddService<TService, TImplementation>(Lifetime lifetime, Func<IServiceProvider, object> customConstructor)
        {
            
            var descriptor = new ServiceDescriptor()
            {
                ServiceType = typeof(TService),
                ImplementationType = typeof(TImplementation),
                Lifetime = lifetime,
                CustomConstructor = customConstructor,
            };
            _services.Add(descriptor.ServiceType, descriptor);
        }
        
        public ServiceProvider Build()
        {
            foreach (var serviceDescriptor in _services.Values)
            {
                //only resolve constructor if no custom ctor is given
                if (serviceDescriptor.CustomConstructor == null)
                {
                    serviceDescriptor.Constructor = ResolveConstructor(_services, serviceDescriptor) ?? throw new ServiceProviderException($"Failed to resolve constructor for {serviceDescriptor.ImplementationType}");
                }
            }
            return new ServiceProvider(_services);
        }

        private static ConstructorInfo ResolveConstructor(Dictionary<Type, ServiceDescriptor> services, ServiceDescriptor serviceDescriptor)
        {
            var constructors = serviceDescriptor.ImplementationType.GetConstructors(BindingFlags.CreateInstance | BindingFlags.Public | BindingFlags.Instance | BindingFlags.OptionalParamBinding);
            foreach (var constructor in constructors)
            {
                var parameters = constructor.GetParameters();
                if (parameters.All(p => services.ContainsKey(p.ParameterType)))
                {
                    return constructor;
                }
            }
            return null;
        }
    }
}
