using System.Windows.Forms.VisualStyles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulMemory;
using SoulMemory.Abstractions;
using SoulMemory.Enums;
using SoulMemory.Games.Sekiro;
using SoulSplitter.DependencyInjection;
using SoulSplitter.Resources;
using SoulSplitter.Ui;
using SoulSplitter.Ui.ViewModels;
using SoulSplitter.Ui.ViewModels.MainViewModel;
using SoulSplitter.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            App.ServiceProvider = serviceCollect.Build();

            var mainViewModel = new MainViewModel();
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 0, TimingType.Immediate, SplitType.Boss, Boss.HeadlessApe, "big boss"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 1, TimingType.OnLoading, SplitType.Bonfire, Idol.AshinaReservoir, "rest here"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 2, TimingType.OnLoading, SplitType.Attribute, new AttributeViewModel() { Attribute = Attribute.AttackPower, Level = 30 }, "Strong boi"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 3, TimingType.Immediate, SplitType.Position, new PositionViewModel() { Position = new Vector3f(12.4f, 502.12f, 245.04f), Size = 5.0f }, "kekw"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 4, TimingType.Immediate, SplitType.Flag, 15062400, "mystery flag"));

            var xml = mainViewModel.SerializeXml();
            Assert.AreEqual(ExpectedXml, xml);

            var deserialized = MainViewModel.DeserializeXml(xml);

            Assert.AreEqual(mainViewModel.Splits.Count, deserialized.Splits.Count);
            for(int i = 0; i < mainViewModel.Splits.Count; i++)
            {
                var expected = mainViewModel.Splits[i];
                var actual = deserialized.Splits[i];

                Assert.AreEqual(expected.Game            , actual.Game            );
                Assert.AreEqual(expected.NewGamePlusLevel, actual.NewGamePlusLevel);
                Assert.AreEqual(expected.TimingType      , actual.TimingType      );
                Assert.AreEqual(expected.SplitType       , actual.SplitType       );
                Assert.AreEqual(expected.Split.ToString(), actual.Split.ToString());
                Assert.AreEqual(expected.Description     , actual.Description     );
            }
        }

        private const string ExpectedXml = @"<?xml version=""1.0"" encoding=""utf-16""?>
<MainViewModel xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <Language>English</Language>
  <Version>2.0.2</Version>
  <Splits>
    <SplitViewModel>
      <SplitViewModel>
        <Description>big boss</Description>
        <Game>Sekiro</Game>
        <NewGamePlusLevel>0</NewGamePlusLevel>
        <TimingType>Immediate</TimingType>
        <SplitType>Boss</SplitType>
        <Split type=""SoulMemory.Games.Sekiro.Boss"">HeadlessApe</Split>
      </SplitViewModel>
    </SplitViewModel>
    <SplitViewModel>
      <SplitViewModel>
        <Description>rest here</Description>
        <Game>Sekiro</Game>
        <NewGamePlusLevel>1</NewGamePlusLevel>
        <TimingType>OnLoading</TimingType>
        <SplitType>Bonfire</SplitType>
        <Split type=""SoulMemory.Games.Sekiro.Idol"">AshinaReservoir</Split>
      </SplitViewModel>
    </SplitViewModel>
    <SplitViewModel>
      <SplitViewModel>
        <Description>Strong boi</Description>
        <Game>Sekiro</Game>
        <NewGamePlusLevel>2</NewGamePlusLevel>
        <TimingType>OnLoading</TimingType>
        <SplitType>Attribute</SplitType>
        <Split type=""SoulSplitter.Ui.ViewModels.AttributeViewModel"">
          <AttributeViewModel>
            <Attribute type=""SoulMemory.Games.Sekiro.Attribute"">AttackPower</Attribute>
            <Level>30</Level>
          </AttributeViewModel>
        </Split>
      </SplitViewModel>
    </SplitViewModel>
    <SplitViewModel>
      <SplitViewModel>
        <Description>kekw</Description>
        <Game>Sekiro</Game>
        <NewGamePlusLevel>3</NewGamePlusLevel>
        <TimingType>Immediate</TimingType>
        <SplitType>Position</SplitType>
        <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
          <PositionViewModel>
            <Position>
              <X>12,4</X>
              <Y>502,12</Y>
              <Z>245,04</Z>
            </Position>
            <Size>5</Size>
          </PositionViewModel>
        </Split>
      </SplitViewModel>
    </SplitViewModel>
    <SplitViewModel>
      <SplitViewModel>
        <Description>mystery flag</Description>
        <Game>Sekiro</Game>
        <NewGamePlusLevel>4</NewGamePlusLevel>
        <TimingType>Immediate</TimingType>
        <SplitType>Flag</SplitType>
        <Split type=""System.Int32"">15062400</Split>
      </SplitViewModel>
    </SplitViewModel>
  </Splits>
</MainViewModel>";


        [TestMethod]
        public void Serialization_Should_Serialize_Splits()
        {
            var languageManagerMock = new Mock<ILanguageManager>();

            var serviceCollect = new ServiceCollection();
            serviceCollect.AddSingleton<ILanguageManager>(i => languageManagerMock.Object);
            App.ServiceProvider = serviceCollect.Build();

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
