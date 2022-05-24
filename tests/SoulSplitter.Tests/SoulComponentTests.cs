using System.IO;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using LiveSplit.Model;
using Moq;
using NUnit.Framework;
using SoulSplitter.UI;

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

            var xml = MainViewModelToXml(viewModel);

            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var liveSplitStateMock = new Mock<LiveSplitState>(null, null, null, null, null);
            var component = new SoulComponent(liveSplitStateMock.Object);
            component.SetSettings(doc);

            var componentViewModel = component.MainControlFormsWrapper.MainViewModel;

            Assert.AreEqual(viewModel.EldenRingViewModel.StartAutomatically, componentViewModel.EldenRingViewModel.StartAutomatically);
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

        private const string ExampleSettings = @"<MainViewModel xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <Version>1.0.24</Version>
  <SelectedGameIndex>2</SelectedGameIndex>
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
