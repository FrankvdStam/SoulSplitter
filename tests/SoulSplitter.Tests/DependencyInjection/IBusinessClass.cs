using System;

namespace SoulSplitter.Plugin.Tests.DependencyInjection
{
    public interface IBusinessClass : IDisposable
    {
        void DoBusinessLogic();
    }
}
