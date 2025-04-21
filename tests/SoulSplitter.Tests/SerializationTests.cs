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

            var xml = mainViewModel.SerializeXml();
            //Assert.AreEqual(ExpectedXml, xml);

            var deserialized = MainViewModel.DeserializeXml(xml);

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
                        var expectedAttributeViewModel = (AttributeViewModel)expected.Split;
                        var actualAttributeViewModel = (AttributeViewModel)actual.Split;
                        Assert.AreEqual(expectedAttributeViewModel.Attribute, actualAttributeViewModel.Attribute);
                        Assert.AreEqual(expectedAttributeViewModel.Level, actualAttributeViewModel.Level);
                        break;

                    case SplitType.Position:
                        var expectedPositionViewModel = (PositionViewModel)expected.Split;
                        var actualPositionViewModel = (PositionViewModel)actual.Split;
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

        private const string ExpectedXml = @"<MainViewModel xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <Language>English</Language>
  <Version>2.0.8</Version>
  <Splits>
    <SplitViewModel>
      <Description>big boss</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Boss</SplitType>
      <Split type=""SoulMemory.Games.Sekiro.Boss"">HeadlessApe</Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>rest here</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>1</NewGamePlusLevel>
      <TimingType>OnLoading</TimingType>
      <SplitType>Bonfire</SplitType>
      <Split type=""SoulMemory.Games.Sekiro.Idol"">AshinaReservoir</Split>
    </SplitViewModel>
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
    <SplitViewModel>
      <Description>kekw</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>3</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>12.4</X>
            <Y>502.12</Y>
            <Z>245.04</Z>
          </Position>
          <Size>5</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>mystery flag</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>4</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Flag</SplitType>
      <Split type=""System.Int32"">15062400</Split>
    </SplitViewModel>
  </Splits>
  <FlagTrackerViewModel>
    <EventFlagCategories />
    <DisplayMode>Percentage</DisplayMode>
    <WindowWidth>800</WindowWidth>
    <WindowHeight>600</WindowHeight>
    <InputColumnWidth>400</InputColumnWidth>
    <CategoryPercentagesRowHeight>300</CategoryPercentagesRowHeight>
    <CategoryPercentageFontSize>30</CategoryPercentageFontSize>
    <TotalPercentageFontSize>60</TotalPercentageFontSize>
    <BackgroundColor>
      <A>255</A>
      <R>255</R>
      <G>255</G>
      <B>255</B>
      <ScA>1</ScA>
      <ScR>1</ScR>
      <ScG>1</ScG>
      <ScB>1</ScB>
    </BackgroundColor>
    <TextColor>
      <A>255</A>
      <R>0</R>
      <G>0</G>
      <B>0</B>
      <ScA>1</ScA>
      <ScR>0</ScR>
      <ScG>0</ScG>
      <ScB>0</ScB>
    </TextColor>
    <FlagsPerFrame>10</FlagsPerFrame>
  </FlagTrackerViewModel>
</MainViewModel>";


        [TestMethod]
        public void Test()
        {
            var languageManagerMock = new Mock<ILanguageManager>();

            var serviceCollect = new ServiceCollection();
            serviceCollect.AddSingleton<ILanguageManager>(i => languageManagerMock.Object);
            GlobalServiceProvider.Instance = serviceCollect.Build();


            var deserialized = MainViewModel.DeserializeXml(ExpectedXml2);
            Assert.AreEqual(17, deserialized.Splits.Count);
        }

        private const string ExpectedXml2 = @"<MainViewModel>
  <Version>2.0.2</Version>
  <Language>English</Language>
  <StartAutomatically>True</StartAutomatically>
  <OverwriteIgtOnStart>False</OverwriteIgtOnStart>
  <Splits>
    <SplitViewModel>
      <Description>Tutorial Window (after cutscene)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>-174,4948</X>
            <Y>-32,55916</Y>
            <Z>361,0806</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Tutorial- Kuro Dialogue (gourd)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Flag</SplitType>
      <Split type=""System.UInt32"">6720</Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Tutorial- Charmless Dialogue</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Flag</SplitType>
      <Split type=""System.UInt32"">6911</Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Tutorial Whistle (after cutscene)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>-290,0234</X>
            <Y>-61,44775</Y>
            <Z>190,0379</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Tutorial- Corridor (after cutscene)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>-372,1679</X>
            <Y>-46,28377</Y>
            <Z>184,5305</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Tutorial- after Geni (after cutscene)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>125,8037</X>
            <Y>-47,19866</Y>
            <Z>-193,0773</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Ogre- first grapple</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>136,4279</X>
            <Y>-43,36351</Y>
            <Z>-122,3801</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Ogre- second grapple</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>104,6023</X>
            <Y>-25,59678</Y>
            <Z>-52,62641</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Ogre- 4th grapple (roof corner)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>209,4271</X>
            <Y>-49,64426</Y>
            <Z>102,8781</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Ogre- 5th grapple (above barn)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>192,4206</X>
            <Y>-55,01327</Y>
            <Z>116,6101</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Ogre- 1st deathblow (agro activates, not unique)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Flag</SplitType>
      <Split type=""System.UInt32"">21105053</Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Ogre- end (fog wall grapple)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>125,231</X>
            <Y>-35,41488</Y>
            <Z>140,1151</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Canyon- 1st grapple (no dc)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>-7,441105</X>
            <Y>-139,5705</Y>
            <Z>36,54788</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Canyon- end grapple</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>20,41632</X>
            <Y>-108,27</Y>
            <Z>-76,95982</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Gyoubu- eagle grapple</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Position</SplitType>
      <Split type=""SoulSplitter.Ui.ViewModels.PositionViewModel"">
        <PositionViewModel>
          <Position>
            <X>-93,38245</X>
            <Y>-51,60074</Y>
            <Z>24,59288</Z>
          </Position>
          <Size>1</Size>
        </PositionViewModel>
      </Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Gyoubu- death</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Boss</SplitType>
      <Split type=""SoulMemory.Games.Sekiro.Boss"">GyoubuMasatakaOniwa</Split>
    </SplitViewModel>
    <SplitViewModel>
      <Description>Gyoubu- Tengu dialogue (start of dialogue)</Description>
      <Game>Sekiro</Game>
      <NewGamePlusLevel>0</NewGamePlusLevel>
      <TimingType>Immediate</TimingType>
      <SplitType>Flag</SplitType>
      <Split type=""System.UInt32"">21106153</Split>
    </SplitViewModel>
  </Splits>
</MainViewModel>";

        [TestMethod]
        public void Serialization_Should_Serialize_Splits()
        {
            var languageManagerMock = new Mock<ILanguageManager>();

            var serviceCollect = new ServiceCollection();
            serviceCollect.AddSingleton<ILanguageManager>(i => languageManagerMock.Object);
            GlobalServiceProvider.Instance = serviceCollect.Build();

            var mainViewModel = new MainViewModel();
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.Immediate, SplitType.Boss, Boss.HeadlessApe, "big boss"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.OnLoading, SplitType.Bonfire, Idol.AshinaReservoir, "rest here"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.OnLoading, SplitType.Attribute, new AttributeViewModel(){ Attribute = Attribute.AttackPower, Level = 30 }, "Strong boi"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.Immediate, SplitType.Position, new PositionViewModel() { Position = new Vector3f(12.4f, 502.12f, 245.04f), Size = 5.0f }, "kekw"));
            mainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.Immediate, SplitType.Flag, 15062400, "mystery flag"));
            
            var xml = Serialization.SerializeXml(mainViewModel);
            var obj = Serialization.DeserializeXml<MainViewModel>(xml);

            Assert.AreEqual(5, obj.Splits.Count);
        }
    }
}
