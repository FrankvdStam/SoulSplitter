using System;

namespace SoulSplitter.Tests.DependencyInjection
{
    public class BusinessClass : IBusinessClass
    {
        private readonly ILogger _logger;

        public BusinessClass(ILogger logger)
        {
            _logger = logger;
        }

        public void DoBusinessLogic()
        {
            _logger.Log("Doing business logic");
        }


        public Action DisposeCallback { get; set; }
        public void Dispose()
        {
            DisposeCallback?.Invoke();
        }
    }
}
