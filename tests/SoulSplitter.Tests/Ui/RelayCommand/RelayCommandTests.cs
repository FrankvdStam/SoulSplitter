using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoulSplitter.Tests.Ui.RelayCommand
{
    [TestClass]
    public class RelayCommandTests
    {
        [TestMethod]
        public void RelayCommand_Can_Execute_Null_Should_Be_True()
        {
            var relayCommand = new SoulSplitter.Ui.RelayCommand.RelayCommand((p) => { });
            Assert.IsTrue(relayCommand.CanExecute(null));
            Assert.IsTrue(relayCommand.CanExecute(new object()));
        }

        [TestMethod]
        public void RelayCommand_Can_Execute_Should_Call_Method_And_Pass_Param()
        {
            var parameter = new object();
            var canExecuteCalled = false;
            var relayCommand = new SoulSplitter.Ui.RelayCommand.RelayCommand((p) => { }, (p) =>
            {
                canExecuteCalled = true;
                Assert.AreEqual(parameter, p);
                return true;
            });
            Assert.IsTrue(relayCommand.CanExecute(parameter));
            Assert.IsTrue(canExecuteCalled);
        }

        [TestMethod]
        public void RelayCommand_Execute_Should_Call_Method_And_Pass_Param()
        {
            var parameter = new object();
            var executeCalled = false;
            var relayCommand = new SoulSplitter.Ui.RelayCommand.RelayCommand(
                (p) =>
                {
                    executeCalled = true;
                    Assert.AreEqual(parameter, p);
                }
            );
            relayCommand.Execute(parameter);
            Assert.IsTrue(executeCalled);
        }
    }
}
