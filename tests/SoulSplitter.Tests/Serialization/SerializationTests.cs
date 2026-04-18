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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulSplitter.Plugin.DependencyInjection;
using SoulSplitter.Plugin.Resources;
using SoulSplitter.Plugin.Serialization;
using SoulSplitter.Plugin.Ui.ViewModels;
using SoulSplitter.Plugin.Ui.ViewModels.MainViewModel;
using SoulSplitter.SoulMemory;
using SoulSplitter.SoulMemory.Enums;
using SoulSplitter.SoulMemory.Games.Sekiro;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Attribute = SoulSplitter.SoulMemory.Games.Sekiro.Attribute;

namespace SoulSplitter.Plugin.Tests.Serialization
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

            var serializedModel = new SerializedModel(mainViewModel);

            var xmlWriterSettings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true
            };

            using var stringWriter = new StringWriter();
            using var writer = XmlWriter.Create(stringWriter, xmlWriterSettings);
            var serializer = new XmlSerializer(typeof(SerializedModel));
            serializer.Serialize(writer, serializedModel);
            var str = stringWriter.ToString();



            var xml = mainViewModel.SerializeXml();
            //Assert.AreEqual(ExpectedXml, xml);

            var deserialized = MainViewModel.DeserializeXml(xml);

            Assert.IsTrue(deserialized.StartAutomatically);
            Assert.IsTrue(deserialized.OverwriteIgtOnStart);

            Assert.AreEqual(mainViewModel.Splits.Count, deserialized.Splits.Count);
            for (int i = 0; i < mainViewModel.Splits.Count; i++)
            {
                var expected = mainViewModel.Splits[i];
                var actual = deserialized.Splits[i];

                Assert.AreEqual(expected.Game, actual.Game);
                Assert.AreEqual(expected.TimingType, actual.TimingType);
                Assert.AreEqual(expected.SplitType, actual.SplitType);
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
