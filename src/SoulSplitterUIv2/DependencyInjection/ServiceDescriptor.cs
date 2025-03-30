using System;
using System.Linq;
using System.Reflection;

namespace SoulSplitterUIv2.DependencyInjection
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get; set; }
        public Type ImplementationType { get; set; }
        public Lifetime Lifetime { get; set; }
        public ConstructorInfo Constructor { get; set; }
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
