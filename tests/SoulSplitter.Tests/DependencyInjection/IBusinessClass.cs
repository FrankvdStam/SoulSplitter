using System;

namespace SoulSplitter.Tests.DependencyInjection
{
    public interface IBusinessClass : IDisposable
    {
        void DoBusinessLogic();
    }
}
