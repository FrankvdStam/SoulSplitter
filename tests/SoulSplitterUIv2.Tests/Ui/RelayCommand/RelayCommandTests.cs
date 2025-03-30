using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoulSplitterUIv2.Tests.Ui.RelayCommand
{
    [TestClass]
    public class RelayCommandTests
    {
        [TestMethod]
        public void RelayCommand_Ctor_Without_Execute_should_Throw()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new SoulSplitterUIv2.Ui.RelayCommand.RelayCommand(null, null));
        }

        [TestMethod]
        public void RelayCommand_Can_Execute_Null_Should_Be_True()
        {
            var relayCommand = new SoulSplitterUIv2.Ui.RelayCommand.RelayCommand((p) => { }, null);
            Assert.IsTrue(relayCommand.CanExecute(null));
            Assert.IsTrue(relayCommand.CanExecute(new object()));
        }

        [TestMethod]
        public void RelayCommand_Can_Execute_Should_Call_Method_And_Pass_Param()
        {
            var parameter = new object();
            var canExecuteCalled = false;
            var relayCommand = new SoulSplitterUIv2.Ui.RelayCommand.RelayCommand((p) => { }, (p) =>
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
            var relayCommand = new SoulSplitterUIv2.Ui.RelayCommand.RelayCommand(
                (p) =>
                {
                    executeCalled = true;
                    Assert.AreEqual(parameter, p);
                }, null
            );
            relayCommand.Execute(parameter);
            Assert.IsTrue(executeCalled);
        }
    }
}
