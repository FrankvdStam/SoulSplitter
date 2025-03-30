using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulMemory.DarkSouls1;
using SoulSplitterUIv2.Resources;
using SoulSplitterUIv2.Ui.ViewModels;

namespace SoulSplitterUIv2.Tests.Ui.View.SplitControls
{
    [TestClass]
    public class EventFlagViewModelTests
    {
        [TestInitialize]
        public void Setup()
        {
            _languageManagerMock = new Mock<ILanguageManager>();
            _languageManagerMock
                .Setup(i => i.Get(It.Is<Boss>(b => b == Boss.ArtoriasTheAbysswalker)))
                .Returns(new EventFlag()
                {
                    Name = "Artorias",
                    Description = "Abyss walker",
                    Location = "Oolacile Township",
                });
        }
        private Mock<ILanguageManager> _languageManagerMock;

        [TestMethod]
        public void EventFlagView_Should_Populate_And_Cache_Search_String()
        {
            var eventFlagViewModel = new EventFlagViewModel(Boss.ArtoriasTheAbysswalker, _languageManagerMock.Object);
            Assert.AreEqual<uint>(11210001, eventFlagViewModel.Flag);
            Assert.AreEqual(Boss.ArtoriasTheAbysswalker, eventFlagViewModel.EventFlag);
            Assert.AreEqual("Artorias", eventFlagViewModel.Name);
            Assert.AreEqual("Abyss walker", eventFlagViewModel.Description);
            Assert.AreEqual("Oolacile Township", eventFlagViewModel.Location);
            Assert.AreEqual("11210001 Artorias Abyss walker Oolacile Township", eventFlagViewModel.GetFilterValue());
        }

        [TestMethod]
        public void EventFlagView_Design_Time_LanguageManager_Null_Should_Not_Throw()
        {
            try
            {
                var eventFlagViewModel = new EventFlagViewModel(Boss.ArtoriasTheAbysswalker, null);
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
