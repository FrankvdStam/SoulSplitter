using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulMemory.Enums;
using SoulMemory.Games.EldenRing;
using SoulSplitterUIv2.DependencyInjection;
using SoulSplitterUIv2.Resources;
using SoulSplitterUIv2.Ui.ViewModels;
using SoulSplitterUIv2.Ui.ViewModels.MainViewModel;
using SoulSplitterUIv2.Utils;

namespace SoulSplitterUIv2.Tests
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public void Serialization_Should_Serialize_Splits()
        {
            var languageManagerMock = new Mock<ILanguageManager>();

            var serviceCollect = new ServiceCollection();
            serviceCollect.AddSingleton<ILanguageManager>(i => languageManagerMock.Object);
            Extensions.ServiceProvider = serviceCollect.Build();

            var mainViewModel = new MainViewModel();
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 0, TimingType.Immediate, SplitType.Boss, Boss.AdanThiefOfFireMalefactorsEvergaolLiurnia, "asdf"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.EldenRing, 99, TimingType.OnLoading, SplitType.Boss, Boss.CommanderONeilEastAeoniaSwampCaelid, "peepo"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.DarkSouls3, 12, TimingType.OnWarp, SplitType.Boss, Boss.TreeSentinelTreeSentinelDuoAltusPlateau, "1234"));

            var xml = Serialization.SerializeXml(mainViewModel);
            var obj = Serialization.DeserializeXml(xml);

            Assert.AreEqual(3, obj.Splits.Count);
        }
    }
}
