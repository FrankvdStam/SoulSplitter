using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulSplitter.DependencyInjection;

namespace SoulSplitter.Tests.DependencyInjection
{
    [TestClass]
    public class ServiceProviderTests
    {
        #region singletons =============================================================================

        [TestMethod]
        public void Singleton_Concrete_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<Logger>();

            var serviceProvider = serviceCollection.Build();
            var logger = serviceProvider.GetService<Logger>();
            Assert.IsNotNull(logger);
        }

        [TestMethod]
        public void Singleton_Interfaced_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ILogger, Logger>();

            var serviceProvider = serviceCollection.Build();
            ILogger logger = serviceProvider.GetService<ILogger>();
            Assert.IsInstanceOfType(logger, typeof(Logger));
        }

        [TestMethod]
        public void Singleton_Constructors_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ILogger, Logger>();
            serviceCollection.AddSingleton<IBusinessClass, BusinessClass>();

            var serviceProvider = serviceCollection.Build();
            IBusinessClass businessClass = serviceProvider.GetService<IBusinessClass>();
            Assert.IsInstanceOfType(businessClass, typeof(BusinessClass));
        }

        [TestMethod]
        public void Singleton_In_Scope_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ILogger, Logger>();
            serviceCollection.AddSingleton<IBusinessClass, BusinessClass>();

            var serviceProvider = serviceCollection.Build();
            using (var scope = serviceProvider.CreateScope())
            {
                IBusinessClass businessClass = scope.GetService<IBusinessClass>();
                Assert.IsInstanceOfType(businessClass, typeof(BusinessClass));
            }
        }

        [TestMethod]
        public void Singleton_Custom_Constructor_Concrete_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<Logger>(() => new Logger());
            var serviceProvider = serviceCollection.Build();
            var logger = serviceProvider.GetService<Logger>();
            Assert.IsInstanceOfType(logger, typeof(Logger));
        }

        [TestMethod]
        public void Singleton_Custom_Constructor_Interface_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ILogger, Logger>(() => new Logger());
            var serviceProvider = serviceCollection.Build();
            var logger = serviceProvider.GetService<ILogger>();
            Assert.IsInstanceOfType(logger, typeof(Logger));
        }

        [TestMethod]
        public void Singleton_Custom_Constructor_Service_Provider_Concrete_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ILogger, Logger>();
            serviceCollection.AddSingleton<BusinessClass>((s) => new BusinessClass(s.GetService<ILogger>()));
            var serviceProvider = serviceCollection.Build();
            var businessClass = serviceProvider.GetService<BusinessClass>();
            Assert.IsInstanceOfType(businessClass, typeof(BusinessClass));
        }

        [TestMethod]
        public void Singleton_Custom_Constructor_Service_Provider_Interfaced_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ILogger, Logger>();
            serviceCollection.AddSingleton<IBusinessClass, BusinessClass>((s) => new BusinessClass(s.GetService<ILogger>()));
            var serviceProvider = serviceCollection.Build();
            var businessClass = serviceProvider.GetService<IBusinessClass>();
            Assert.IsInstanceOfType(businessClass, typeof(BusinessClass));
        }

        #endregion

        #region scoped =============================================================================

        [TestMethod]
        public void Scoped_Service_Should_Throw_Without_Scope()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ILogger, Logger>();

            var serviceProvider = serviceCollection.Build();
            Assert.ThrowsException<ServiceProviderException>(() => serviceProvider.GetService<ILogger>());
        }

        [TestMethod]
        public void Scoped_Service_Concrete_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<Logger>();

            var serviceProvider = serviceCollection.Build();
            using (var scope = serviceProvider.CreateScope())
            {
                var logger = scope.GetService<Logger>();
                Assert.IsNotNull(logger);
            }
        }

        [TestMethod]
        public void Scoped_Service_Interfaced_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ILogger, Logger>();

            var serviceProvider = serviceCollection.Build();
            using (var scope = serviceProvider.CreateScope())
            {
                var logger = scope.GetService<ILogger>();
                Assert.IsNotNull(logger);
            }
        }

        [TestMethod]
        public void Scoped_Service_Constructors_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ILogger, Logger>();
            serviceCollection.AddScoped<IBusinessClass, BusinessClass>();

            var serviceProvider = serviceCollection.Build();
            using (var scope = serviceProvider.CreateScope())
            {
                IBusinessClass businessClass = scope.GetService<IBusinessClass>();
                Assert.IsInstanceOfType(businessClass, typeof(BusinessClass));
            }
        }

        [TestMethod]
        public void Scoped_Service_Custom_Constructor_Concrete_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<Logger>(() => new Logger());
            var serviceProvider = serviceCollection.Build();

            using (var scope = serviceProvider.CreateScope())
            {
                var logger = scope.GetService<Logger>();
                Assert.IsInstanceOfType(logger, typeof(Logger));
            }
        }

        [TestMethod]
        public void Scoped_Service_Custom_Constructor_Interfaced_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ILogger, Logger>(() => new Logger());
            var serviceProvider = serviceCollection.Build();

            using (var scope = serviceProvider.CreateScope())
            {
                var logger = scope.GetService<ILogger>();
                Assert.IsInstanceOfType(logger, typeof(Logger));
            }
        }

        [TestMethod]
        public void Scoped_Service_Custom_Constructor_Service_Provider_Concrete_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ILogger, Logger>();
            serviceCollection.AddScoped<BusinessClass>((s) => new BusinessClass(s.GetService<ILogger>()));
            var serviceProvider = serviceCollection.Build();

            using (var scope = serviceProvider.CreateScope())
            {
                var businessClass = scope.GetService<BusinessClass>();
                Assert.IsInstanceOfType(businessClass, typeof(BusinessClass));
            }
        }

        [TestMethod]
        public void Scoped_Service_Custom_Constructor_Service_Provider_Interfaced_Type_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ILogger, Logger>();
            serviceCollection.AddScoped<IBusinessClass, BusinessClass>((s) => new BusinessClass(s.GetService<ILogger>()));
            var serviceProvider = serviceCollection.Build();

            using (var scope = serviceProvider.CreateScope())
            {
                var businessClass = scope.GetService<IBusinessClass>();
                Assert.IsInstanceOfType(businessClass, typeof(BusinessClass));
            }
        }

        [TestMethod]
        public void Scoped_Services_Should_Dispose()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ILogger, Logger>();
            serviceCollection.AddScoped<IBusinessClass, BusinessClass>();

            var serviceProvider = serviceCollection.Build();

            bool disposed = false;
            using (var scope = serviceProvider.CreateScope())
            {
                var businessClass = (BusinessClass)scope.GetService<IBusinessClass>();
                businessClass.DisposeCallback = () => { disposed = true; };
            }

            Assert.IsTrue(disposed);
        }

        #endregion

        #region Mixed =============================================================================

        [TestMethod]
        public void Mixed_Services_Should_Resolve()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ILogger>(() => new Logger());
            serviceCollection.AddScoped<IBusinessClass, BusinessClass>();

            var serviceProvider = serviceCollection.Build();
            var logger = serviceProvider.GetService<ILogger>();
            Assert.IsNotNull(logger);
            Assert.IsInstanceOfType(logger, typeof(Logger));

            Assert.ThrowsException<ServiceProviderException>(() => serviceProvider.GetService<IBusinessClass>());

            using (var scope = serviceProvider.CreateScope())
            {
                IBusinessClass businessClass = scope.GetService<IBusinessClass>();
                Assert.IsInstanceOfType(businessClass, typeof(BusinessClass));
            }
        }

        #endregion

        
    }
}
