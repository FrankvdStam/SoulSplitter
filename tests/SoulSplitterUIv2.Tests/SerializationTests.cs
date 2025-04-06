using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulMemory;
using SoulMemory.Enums;
using SoulMemory.Games.Sekiro;
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
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 0, TimingType.Immediate, SplitType.Boss, Boss.HeadlessApe, "big boss"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 1, TimingType.OnLoading, SplitType.Bonfire, Idol.AshinaReservoir, "rest here"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 2, TimingType.OnLoading, SplitType.Attribute, new AttributeViewModel(){ Attribute = Attribute.AttackPower, Level = 30 }, "Strong boi"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 3, TimingType.Immediate, SplitType.Position, new PositionViewModel() { Position = new Vector3f(12.4f, 502.12f, 245.04f), Size = 5.0f }, "kekw"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 4, TimingType.Immediate, SplitType.Flag, 15062400, "mystery flag"));
            
            var xml = Serialization.SerializeXml(mainViewModel);
            var obj = Serialization.DeserializeXml<MainViewModel>(xml);

            Assert.AreEqual(5, obj.Splits.Count);
        }
    }
}
