using System;
using System.Windows.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulMemory;
using SoulMemory.Enums;
using SoulMemory.Games.Sekiro;
using SoulSplitter.DependencyInjection;
using SoulSplitter.Resources;
using SoulSplitter.Ui.ViewModels;
using SoulSplitter.Ui.ViewModels.MainViewModel;
using SoulSplitter.Utils;
using Attribute = SoulMemory.Games.Sekiro.Attribute;

namespace SoulSplitter.Tests
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public void TestSerialization()
        {
            var languageManagerMock = new Mock<ILanguageManager>();

            var serviceCollect = new ServiceCollection();
            serviceCollect.AddSingleton<ILanguageManager>(i => languageManagerMock.Object);
            GlobalServiceProvider.Instance = serviceCollect.Build();

            var mainViewModel = new MainViewModel();
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.Immediate, SplitType.Boss, Boss.HeadlessApe, "big boss"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.OnLoading, SplitType.Bonfire, Idol.AshinaReservoir, "rest here"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.OnLoading, SplitType.Attribute, new AttributeViewModel() { Attribute = Attribute.AttackPower, Level = 30 }, "Strong boi"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.Immediate, SplitType.Position, new PositionViewModel() { Position = new Vector3f(12.4f, 502.12f, 245.04f), Size = 5.0f }, "kekw"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.Immediate, SplitType.Flag, 15062400u, "mystery flag"));

            mainViewModel.StartAutomatically = true;
            mainViewModel.OverwriteIgtOnStart = true;

            var xml = mainViewModel.SerializeXml();
            //Assert.AreEqual(ExpectedXml, xml);

            var deserialized = MainViewModel.DeserializeXml(xml);

            Assert.IsTrue(deserialized.StartAutomatically);
            Assert.IsTrue(deserialized.OverwriteIgtOnStart);

            Assert.AreEqual(mainViewModel.Splits.Count, deserialized.Splits.Count);
            for(int i = 0; i < mainViewModel.Splits.Count; i++)
            {
                var expected = mainViewModel.Splits[i];
                var actual = deserialized.Splits[i];

                Assert.AreEqual(expected.Game       , actual.Game       );
                Assert.AreEqual(expected.TimingType , actual.TimingType );
                Assert.AreEqual(expected.SplitType  , actual.SplitType  );
                Assert.AreEqual(expected.Description, actual.Description);

                switch (expected.SplitType)
                {
                    //Simple types (enum, int) can be compared directly
                    case SplitType.Boss:
                    case SplitType.Bonfire:
                    case SplitType.ItemPickup:
                    case SplitType.KnownFlag:
                    case SplitType.Flag:
                        Assert.AreEqual(expected.Split, actual.Split);
                        break;

                    case SplitType.Attribute:
                        var expectedAttributeViewModel = (AttributeViewModel)expected.Split!;
                        var actualAttributeViewModel = (AttributeViewModel)actual.Split!;
                        Assert.AreEqual(expectedAttributeViewModel.Attribute, actualAttributeViewModel.Attribute);
                        Assert.AreEqual(expectedAttributeViewModel.Level, actualAttributeViewModel.Level);
                        break;

                    case SplitType.Position:
                        var expectedPositionViewModel = (PositionViewModel)expected.Split!;
                        var actualPositionViewModel = (PositionViewModel)actual.Split!;
                        Assert.AreEqual(expectedPositionViewModel.Position.X, actualPositionViewModel.Position.X);
                        Assert.AreEqual(expectedPositionViewModel.Position.Y, actualPositionViewModel.Position.Y);
                        Assert.AreEqual(expectedPositionViewModel.Position.Z, actualPositionViewModel.Position.Z);
                        Assert.AreEqual(expectedPositionViewModel.Size, actualPositionViewModel.Size);
                        break;

                    case SplitType.DarkSouls1Item:
                    case SplitType.EldenRingPosition:
                    case SplitType.DarkSouls1Bonfire:
                    default:
                        Assert.Fail();
                        break;
                }
            }
        }
    }
}
