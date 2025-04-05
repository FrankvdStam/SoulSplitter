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
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SoulMemory.DependencyInjection
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
        public void AddService<TService, TImplementation>(Lifetime lifetime, Func<IServiceProvider, object>? customConstructor)
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

        private static ConstructorInfo? ResolveConstructor(Dictionary<Type, ServiceDescriptor> services, ServiceDescriptor serviceDescriptor)
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
