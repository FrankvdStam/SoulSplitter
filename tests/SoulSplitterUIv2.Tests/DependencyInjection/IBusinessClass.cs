using System;

namespace SoulSplitterUIv2.Tests.DependencyInjection
{
    public interface IBusinessClass : IDisposable
    {
        void DoBusinessLogic();
    }
}
