using System;

namespace SoulSplitterUIv2.DependencyInjection
{
    public class ServiceProviderException : Exception
    {
        public ServiceProviderException(string message) : base(message) { }
    }
}
