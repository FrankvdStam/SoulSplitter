// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System.Linq;
using System.Xml;
using LiveSplit.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulMemory;
using SoulSplitter.Net6.Tests;
using SoulSplitter.UI;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.Tests
{
    [TestClass]
    //[Apartment(ApartmentState.STA)]
    public class SoulComponentTests
    {
        [TestMethodSta]
        public void GetSettingsTest()
        {
            var liveSplitStateMock = new Mock<LiveSplitState>(args: [null!, null!, null!, null!, null!]);
            var component = new SoulComponent(liveSplitStateMock.Object, shouldThrowOnInvalidInstallation: false);
            var doc = new XmlDocument();
            var settings = component.GetSettings(doc);
            Assert.IsNotNull(settings.OuterXml);
            Assert.AreNotSame("", settings.OuterXml);
        }

        [TestMethod]
        public void SetSettingsTest()
        {
            var viewModel = new MainViewModel();
            viewModel.EldenRingViewModel.StartAutomatically = false;
            viewModel.SekiroViewModel.NewSplitTimingType = TimingType.Immediate;
            viewModel.SekiroViewModel.NewSplitType = SplitType.Position;
            viewModel.SekiroViewModel.Position = new VectorSize(){Position = new Vector3f(1.0f, 2.0f, 3.0f), Size = 4};
            viewModel.SekiroViewModel.AddSplitCommand.Execute(null);
            
            var xml = viewModel.Serialize();
            var deserializedViewModel = MainViewModel.Deserialize(xml);
            
            Assert.AreEqual(viewModel.EldenRingViewModel.StartAutomatically, deserializedViewModel.EldenRingViewModel.StartAutomatically);
            
            var vectorSize = deserializedViewModel.SekiroViewModel.SplitsViewModel.Splits.First().Children.First().Children.First().Split;

            Assert.AreEqual(typeof(VectorSize), vectorSize.GetType());
            Assert.AreEqual(1.0f, ((VectorSize)vectorSize).Position.X);
            Assert.AreEqual(2.0f, ((VectorSize)vectorSize).Position.Y);
            Assert.AreEqual(3.0f, ((VectorSize)vectorSize).Position.Z);
            Assert.AreEqual(4.0f, ((VectorSize)vectorSize).Size);
            Assert.IsTrue(xml.ToLowerInvariant().Contains("version"));
        }

        [TestMethodSta]
        public void VersionFromXml_Should_Not_Deserialize()
        {
            var doc = new XmlDocument();
            doc.LoadXml(XmlData.SekiroMigration1_1_0); //load a doc with version 1.1.0

            var versionFromXml = doc.GetChildNodeByName("MainViewModel").GetChildNodeByName("Version").InnerText;

            var liveSplitStateMock = new Mock<LiveSplitState>(args: [null!, null!, null!, null!, null!]);
            var component = new SoulComponent(liveSplitStateMock.Object, shouldThrowOnInvalidInstallation: false);
            component.SetSettings(doc);

            var componentViewModel = component.MainWindow.MainViewModel;

            Assert.AreEqual("1.1.0", versionFromXml);
            Assert.AreEqual(VersionHelper.Version.ToString(), componentViewModel.Version);
        }

        [TestMethodSta]
        public void SekiroMigration1_1_0Test()
        {
            var doc = new XmlDocument();
            doc.LoadXml(XmlData.SekiroMigration1_1_0);

            var liveSplitStateMock = new Mock<LiveSplitState>(args: [null!, null!, null!, null!, null!]);
            var component = new SoulComponent(liveSplitStateMock.Object, shouldThrowOnInvalidInstallation: false);
            component.SetSettings(doc);

            var componentViewModel = component.MainWindow.MainViewModel;
            Assert.AreEqual(2, componentViewModel.SekiroViewModel.SplitsViewModel.Splits.Count);
            Assert.AreEqual(3, componentViewModel.SekiroViewModel.SplitsViewModel.Splits.First().Children.Count);
        }

        [TestMethodSta]
        public void Ds3Migration_1_9_0_Test()
        {
            var doc = new XmlDocument();
            doc.LoadXml(XmlData.DarkSouls3Migration_1_9_0);

            var liveSplitStateMock = new Mock<LiveSplitState>(args: [null!, null!, null!, null!, null!]);
            var component = new SoulComponent(liveSplitStateMock.Object, shouldThrowOnInvalidInstallation: false);
            component.SetSettings(doc);

            var componentViewModel = component.MainWindow.MainViewModel;
            Assert.AreEqual(2, componentViewModel.DarkSouls3ViewModel.SplitsViewModel.Splits.Count);
            Assert.AreEqual(3, componentViewModel.DarkSouls3ViewModel.SplitsViewModel.Splits.First().Children.Count);
            Assert.AreEqual(21, componentViewModel.DarkSouls3ViewModel.SplitsViewModel.Splits.First().Children.First().Children.Count);
        }
    }
}
