using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulMemory.Enums;
using SoulSplitter.Resources;
using SoulSplitter.Ui.ViewModels.MainViewModel;

namespace SoulSplitter.Tests.Ui.ViewModel
{
    [TestClass]
    public class MainViewModelTests
    {
        [TestMethod]
        public void MainViewModel_IsGameSelected_Should_Reflect_SelectedGame_Property()
        {
            var languageManagerMock = new Mock<ILanguageManager>();
            var sut = new MainViewModel(languageManagerMock.Object);

            Assert.IsFalse(sut.IsGameSelected);
            Assert.IsNull(sut.SelectedGame);
            sut.SelectedGame = Game.DarkSouls1;
            Assert.IsTrue(sut.IsGameSelected);
            Assert.IsNotNull(sut.SelectedGame);
            sut.SelectedGame = null;
            Assert.IsFalse(sut.IsGameSelected);
            Assert.IsNull(sut.SelectedGame);
        }

        [TestMethod]
        public void MainViewModel_IsGameSelected_Should_Reset_Other_Split_Options()
        {
            var languageManagerMock = new Mock<ILanguageManager>();
            var sut = new MainViewModel(languageManagerMock.Object);

            sut.SelectedGame = Game.DarkSouls1;
            sut.SelectedTimingType = TimingType.OnWarp;
            sut.SelectedSplitType = SplitType.Boss;
            sut.SelectedEventFlag = SoulMemory.Games.DarkSouls1.Boss.CapraDemon;

            sut.SelectedGame = Game.DarkSouls2;
            Assert.IsNull(sut.SelectedTimingType);
            Assert.IsNull(sut.SelectedSplitType);
            Assert.IsNull(sut.SelectedEventFlag);
        }

        [TestMethod] 
        public void MainViewModel_Selecting_Game_Should_Load_Available_TimingTypes()
        {
            var languageManagerMock = new Mock<ILanguageManager>();
            var sut = new MainViewModel(languageManagerMock.Object);

            Assert.AreEqual(0, sut.TimingTypes.Count);
            sut.SelectedGame = Game.DarkSouls1;
            CollectionAssert.Contains(sut.TimingTypes, TimingType.Immediate);
            CollectionAssert.Contains(sut.TimingTypes, TimingType.OnLoading);
            CollectionAssert.Contains(sut.TimingTypes, TimingType.OnWarp);

            sut.SelectedGame = Game.Sekiro;
            CollectionAssert.Contains(sut.TimingTypes, TimingType.Immediate);
            CollectionAssert.Contains(sut.TimingTypes, TimingType.OnLoading);
            CollectionAssert.DoesNotContain(sut.TimingTypes, TimingType.OnWarp);
        }

        [TestMethod]
        public void MainViewModel_Selecting_Game_Should_Load_Available_SplitTypes()
        {
            var languageManagerMock = new Mock<ILanguageManager>();
            var sut = new MainViewModel(languageManagerMock.Object);

            Assert.AreEqual(0, sut.SplitTypes.Count);
            sut.SelectedGame = Game.DarkSouls1;
            CollectionAssert.Contains(sut.SplitTypes, SplitType.Boss);
            CollectionAssert.Contains(sut.SplitTypes, SplitType.Attribute);
            CollectionAssert.Contains(sut.SplitTypes, SplitType.DarkSouls1Bonfire);

            sut.SelectedGame = Game.ArmoredCore6;
            CollectionAssert.DoesNotContain(sut.SplitTypes, SplitType.Bonfire);
            CollectionAssert.DoesNotContain(sut.SplitTypes, SplitType.Boss);
            CollectionAssert.DoesNotContain(sut.SplitTypes, SplitType.Attribute);
            CollectionAssert.Contains(sut.SplitTypes, SplitType.Flag);
        }
    }
}
