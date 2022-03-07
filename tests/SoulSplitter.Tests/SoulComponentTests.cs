using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using LiveSplit.Model;
using Moq;
using NUnit.Framework;
using SoulSplitter.UI;
using TimingMethod = SoulSplitter.UI.TimingMethod;

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
            viewModel.EldenRingViewModel.TimingMethod = TimingMethod.Igt;

            var xml = MainViewModelToXml(viewModel);

            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var liveSplitStateMock = new Mock<LiveSplitState>(null, null, null, null, null);
            var component = new SoulComponent(liveSplitStateMock.Object);
            component.SetSettings(doc);

            var componentViewModel = component.MainControlFormsWrapper.GetMainViewModel();

            Assert.AreEqual(viewModel.EldenRingViewModel.StartAutomatically, componentViewModel.EldenRingViewModel.StartAutomatically);
            Assert.AreEqual(viewModel.EldenRingViewModel.TimingMethod      , componentViewModel.EldenRingViewModel.TimingMethod      );
        }


        


        private string MainViewModelToXml(MainViewModel viewModel)
        {
            var settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                Indent = true,
            };

            var xml = "";
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                var serializer = new XmlSerializer(viewModel.GetType());
                serializer.Serialize(writer, viewModel);
                return stream.ToString();
            }
        }
    }
}
