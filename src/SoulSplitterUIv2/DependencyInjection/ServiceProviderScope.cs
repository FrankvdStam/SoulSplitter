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

namespace SoulSplitterUIv2.DependencyInjection
{
    public class ServiceProviderScope : IDisposable, IServiceProvider
    {
        private readonly Dictionary<Type, ServiceDescriptor> _serviceDescriptors;
        private readonly IServiceProvider _serviceProvider;
        private readonly Dictionary<Type, object> _scopedServices = new Dictionary<Type, object>();

        public ServiceProviderScope(Dictionary<Type, ServiceDescriptor> serviceDescriptors, IServiceProvider serviceProvider)
        {
            _serviceDescriptors = serviceDescriptors;
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Get service of a given type
        /// Returns singletons and scoped services
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
                return _serviceProvider.GetService(serviceType);
            }
            else
            {
                if (!_scopedServices.TryGetValue(serviceDescriptor.ImplementationType, out object instance))
                {
                    instance = serviceDescriptor.Activate(this);
                    _scopedServices.Add(serviceDescriptor.ServiceType, instance);
                }
                return instance;
            }
        }

        public void Dispose()
        {
            foreach (var service in _scopedServices.Values)
            {
                if (service is IDisposable disposable)
                {
                    disposable.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }
    }

}
