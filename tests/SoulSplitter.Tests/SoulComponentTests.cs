using System.IO;
using System.Linq;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using LiveSplit.Model;
using Moq;
using NUnit.Framework;
using SoulMemory;
using SoulSplitter.Splits.Sekiro;
using SoulSplitter.UI;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Tests
{
    [TestFixture]
    [Apartment(ApartmentState.STA)]
    public class SoulComponentTests
    {
        [Test]
        public void GetSettingsTest()
        {
            var liveSplitStateMock = new Mock<LiveSplitState>(null, null, null, null, null);
            var component = new SoulComponent(liveSplitStateMock.Object);
            var doc = new XmlDocument();
            var settings = component.GetSettings(doc);
            Assert.IsNotEmpty(settings.OuterXml);
        }

        [Test]
        public void SetSettingsTest()
        {
            var viewModel = new MainViewModel();
            viewModel.EldenRingViewModel.StartAutomatically = false;
            viewModel.SekiroViewModel.NewSplitTimingType = TimingType.Immediate;
            viewModel.SekiroViewModel.NewSplitType = SplitType.Position;
            viewModel.SekiroViewModel.NewSplitValue = new Vector3f(1.0f, 2.0f, 3.0f);
            viewModel.SekiroViewModel.AddSplitCommand.Execute(null);
            
            var xml = viewModel.Serialize();
            var deserializedViewModel = MainViewModel.Deserialize(xml);

            Assert.AreEqual(viewModel.EldenRingViewModel.StartAutomatically, deserializedViewModel.EldenRingViewModel.StartAutomatically);
            
            var vector = deserializedViewModel.SekiroViewModel.SplitsViewModel.Splits.FirstOrDefault().Children.FirstOrDefault().Children.FirstOrDefault().Split;

            Assert.AreEqual(typeof(Vector3f), vector.GetType());
            Assert.AreEqual(1.0f, ((Vector3f)vector).X);
            Assert.AreEqual(2.0f, ((Vector3f)vector).Y);
            Assert.AreEqual(3.0f, ((Vector3f)vector).Z);
        }

        private string MainViewModelToXml(MainViewModel viewModel)
        {
            var settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                Indent = true,
            };
            
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                var serializer = new XmlSerializer(viewModel.GetType());
                serializer.Serialize(writer, viewModel);
                return stream.ToString();
            }
        }


        [Test]
        public void SetSettingsTest2()
        {
            var doc = new XmlDocument();
            doc.LoadXml(ExampleSettings);

            var liveSplitStateMock = new Mock<LiveSplitState>(null, null, null, null, null);
            var component = new SoulComponent(liveSplitStateMock.Object);
            component.SetSettings(doc);

            var componentViewModel = component.MainControlFormsWrapper.MainViewModel;

            //Assert.AreEqual(viewModel.EldenRingViewModel.StartAutomatically, componentViewModel.EldenRingViewModel.StartAutomatically);
        }


        [Test]
        public void SekiroMigration1_1_0Test()
        {
            var doc = new XmlDocument();
            doc.LoadXml(SekiroMigration1_1_0);

            var liveSplitStateMock = new Mock<LiveSplitState>(null, null, null, null, null);
            var component = new SoulComponent(liveSplitStateMock.Object);
            component.SetSettings(doc);

            var componentViewModel = component.MainControlFormsWrapper.MainViewModel;
            Assert.AreEqual(2, componentViewModel.SekiroViewModel.SplitsViewModel.Splits.Count);
            Assert.AreEqual(3, componentViewModel.SekiroViewModel.SplitsViewModel.Splits.First().Children.Count);
        }








        private const string SekiroMigration1_1_0 =
            @"<MainViewModel xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <Version>1.1.0</Version>
  <SelectedGame>Sekiro</SelectedGame>
  <DarkSouls1ViewModel />
  <DarkSouls2ViewModel>
    <StartAutomatically>true</StartAutomatically>
    <Splits />
  </DarkSouls2ViewModel>
  <DarkSouls3ViewModel>
    <StartAutomatically>true</StartAutomatically>
    <Splits />
  </DarkSouls3ViewModel>
  <SekiroViewModel>
    <StartAutomatically>true</StartAutomatically>
    <OverwriteIgtOnStart>false</OverwriteIgtOnStart>
    <Splits>
      <HierarchicalTimingTypeViewModel>
        <TimingType xmlns=""Sekiro"">Immediate</TimingType>
        <Children xmlns=""Sekiro"">
          <HierarchicalSplitTypeViewModel>
            <SplitType>Boss</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">GyoubuMasatakaOniwa</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <SplitType>Idol</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Idol"">DragonspringHirataEstate</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <SplitType>Position</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xmlns:q1=""SoulMemory"" xsi:type=""q1:Vector3f"">
                  <q1:X>1</q1:X>
                  <q1:Y>2</q1:Y>
                  <q1:Z>3</q1:Z>
                </Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
      <HierarchicalTimingTypeViewModel>
        <TimingType xmlns=""Sekiro"">OnLoading</TimingType>
        <Children xmlns=""Sekiro"">
          <HierarchicalSplitTypeViewModel>
            <SplitType>Flag</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">123456</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
    </Splits>
  </SekiroViewModel>
  <EldenRingViewModel>
    <StartAutomatically>true</StartAutomatically>
    <LockIgtToZero>false</LockIgtToZero>
    <EnabledRemoveSplit>false</EnabledRemoveSplit>
    <Splits />
  </EldenRingViewModel>
</MainViewModel>";

        private const string ExampleSettings = @"<MainViewModel xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <Version>1.0.24</Version>
  <SelectedGameIndex>2</SelectedGameIndex>
  <SekiroViewModel>
    <StartAutomatically>true</StartAutomatically>
    <Splits>
      <HierarchicalTimingTypeViewModel>
        <TimingType xmlns=""Sekiro"">Immediate</TimingType>
        <Children xmlns=""Sekiro"">
          <HierarchicalSplitTypeViewModel>
            <SplitType>Position</SplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Vector3f"">
                  <X xmlns="""">-304.803772</X>
                  <Y xmlns="""">-53.6740761</Y>
                  <Z xmlns="""">305.3302</Z>
                </Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
    </Splits>
  </SekiroViewModel>
  <EldenRingViewModel>
    <StartAutomatically>true</StartAutomatically>
    <LockIgtToZero>false</LockIgtToZero>
    <EnabledRemoveSplit>false</EnabledRemoveSplit>
    <Splits>
      <HierarchicalTimingTypeViewModel>
        <TimingType>Immediate</TimingType>
        <Children>
          <HierarchicalSplitTypeViewModel>
            <EldenRingSplitType>Flag</EldenRingSplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">60000</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">1034447900</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">11007175</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">13007150</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <EldenRingSplitType>Grace</EldenRingSplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">Gatefront</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">StormhillShack</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">SouthRayaLucariaGate</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">MainAcademyGate</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">DragonTempleRooftop</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
      <HierarchicalTimingTypeViewModel>
        <TimingType>OnLoading</TimingType>
        <Children>
          <HierarchicalSplitTypeViewModel>
            <EldenRingSplitType>Grace</EldenRingSplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">LiurniaHighwaySouth</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">DragonTemple</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">TempleOfEiglay</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Grace"">TheFourBelfries</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <EldenRingSplitType>Flag</EldenRingSplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">1034457100</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">520670</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""xsd:unsignedInt"">16007020</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
          <HierarchicalSplitTypeViewModel>
            <EldenRingSplitType>Boss</EldenRingSplitType>
            <Children>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">GodskinDuoCrumblingFarumAzula</Split>
              </HierarchicalSplitViewModel>
              <HierarchicalSplitViewModel>
                <Split xsi:type=""Boss"">MalikethTheBlackBladeCrumblingFarumAzula</Split>
              </HierarchicalSplitViewModel>
            </Children>
          </HierarchicalSplitTypeViewModel>
        </Children>
      </HierarchicalTimingTypeViewModel>
    </Splits>
  </EldenRingViewModel>
<DarkSouls1ViewModel />
  <DarkSouls2ViewModel>
    <Splits />
  </DarkSouls2ViewModel>
</MainViewModel>";
    }
}
