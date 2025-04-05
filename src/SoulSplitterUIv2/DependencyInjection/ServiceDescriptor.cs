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
using System.Linq;
using System.Reflection;

namespace SoulSplitterUIv2.DependencyInjection
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get; set; } = null!;
        public Type ImplementationType { get; set; } = null!;
        public Lifetime Lifetime { get; set; }
        public ConstructorInfo Constructor { get; set; } = null!;
        public Func<IServiceProvider, object> CustomConstructor { get; set; }

        public object Activate(IServiceProvider serviceProvider)
        {
            if (CustomConstructor != null)
            {
                return CustomConstructor.Invoke(serviceProvider);
            }

            var parameters = Constructor.GetParameters().Select(i => serviceProvider.GetService(i.ParameterType)).ToList();
            if (parameters.Count > 0)
            {
                return Activator.CreateInstance(ImplementationType, parameters.ToArray());
            }
            return Activator.CreateInstance(ImplementationType);
        }
    }
}
