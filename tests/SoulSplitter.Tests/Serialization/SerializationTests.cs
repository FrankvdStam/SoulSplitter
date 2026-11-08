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
using SoulSplitter.SoulMemory.Games.DarkSouls1;
using SoulSplitter.SoulMemory.Games.EldenRing;
using SoulSplitter.SoulMemory.Games.Sekiro;

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

            var expectedMainViewModel = new MainViewModel();
            expectedMainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.Immediate, SplitType.Boss, SoulSplitter.SoulMemory.Games.Sekiro.Boss.HeadlessApe, "big boss"));
            expectedMainViewModel.Splits.Add(new SplitViewModel(Game.DarkSouls1, TimingType.OnLoading, SplitType.Bonfire, SoulSplitter.SoulMemory.Games.DarkSouls1.Boss.GapingDragon, "rest here"));
            expectedMainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.OnLoading, SplitType.Bonfire, Idol.AshinaReservoir, "rest here"));
            expectedMainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.OnLoading, SplitType.Attribute, new AttributeViewModel() { Attribute = SoulSplitter.SoulMemory.Games.Sekiro.Attribute.AttackPower, Level = 30 }, "Strong boi"));
            expectedMainViewModel.Splits.Add(new SplitViewModel(Game.DarkSouls3, TimingType.OnLoading, SplitType.Attribute, new AttributeViewModel() { Attribute = SoulSplitter.SoulMemory.Games.DarkSouls3.Attribute.Vigor, Level = 56 }, "Healthy"));
            expectedMainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.Immediate, SplitType.Position, new PositionViewModel() { Position = new Vector3f(12.4f, 502.12f, 245.04f), Size = 5.0f }, "kekw"));
            expectedMainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.Immediate, SplitType.EldenRingPosition, new EldenRingPositionViewModel() { Position = new Position { Area = 15, Block = 12, Region = 6, Size = 21, X = 12.45f, Y = 24.09f, Z = 3.12f }, Size = 5.0f }, "pos2"));
            expectedMainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, TimingType.Immediate, SplitType.Flag, 15062400u, "mystery flag"));
            expectedMainViewModel.Splits.Add(new SplitViewModel(Game.DarkSouls1, TimingType.Immediate, SplitType.DarkSouls1Item, new SoulSplitter.SoulMemory.Games.DarkSouls1.Item("Catarina Helm", 10000, ItemType.CatarinaHelm, ItemCategory.Armor, 1, ItemUpgrade.Unique), "ds1 item"));
            expectedMainViewModel.Splits.Add(new SplitViewModel(Game.DarkSouls1, TimingType.Immediate, SplitType.DarkSouls1Bonfire, new DarkSouls1BonfireViewModel(){ Bonfire = Bonfire.AshLake, BonfireState = BonfireState.Kindled2 }, "mystery flag"));

            expectedMainViewModel.StartAutomatically = true;
            expectedMainViewModel.OverwriteIgtOnStart = true;

            var serializedModel = new SerializedModel(expectedMainViewModel);

            var serializedXmlRound1 = SerializedModel.Serialize(serializedModel);
            var deserializedRound1 = SerializedModel.Deserialize(serializedXmlRound1);
            var serializedXmlRound2 = SerializedModel.Serialize(deserializedRound1);
            var actualDeserialized = SerializedModel.Deserialize(serializedXmlRound2);

            Assert.AreEqual(serializedXmlRound1, serializedXmlRound2);

            var deserialized = new MainViewModel();
            actualDeserialized.FillMainViewModel(deserialized);

            Assert.IsTrue(deserialized.StartAutomatically);
            Assert.IsTrue(deserialized.OverwriteIgtOnStart);

            Assert.AreEqual(expectedMainViewModel.Splits.Count, deserialized.Splits.Count);
            for (int i = 0; i < expectedMainViewModel.Splits.Count; i++)
            {
                var expected = expectedMainViewModel.Splits[i];
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

                    case SplitType.EldenRingPosition:
                        var expectedEldenRingPositionViewModel = (EldenRingPositionViewModel)expected.Split!;
                        var actualEldenRingPostionViewModel = (EldenRingPositionViewModel)actual.Split!;                        
                        Assert.AreEqual(expectedEldenRingPositionViewModel.Position.Area   , actualEldenRingPostionViewModel.Position.Area  );
                        Assert.AreEqual(expectedEldenRingPositionViewModel.Position.Block  , actualEldenRingPostionViewModel.Position.Block );
                        Assert.AreEqual(expectedEldenRingPositionViewModel.Position.Region , actualEldenRingPostionViewModel.Position.Region);
                        Assert.AreEqual(expectedEldenRingPositionViewModel.Position.Size   , actualEldenRingPostionViewModel.Position.Size  );
                        Assert.AreEqual(expectedEldenRingPositionViewModel.Position.X      , actualEldenRingPostionViewModel.Position.X     );
                        Assert.AreEqual(expectedEldenRingPositionViewModel.Position.Y      , actualEldenRingPostionViewModel.Position.Y     );
                        Assert.AreEqual(expectedEldenRingPositionViewModel.Position.Z      , actualEldenRingPostionViewModel.Position.Z     );
                        Assert.AreEqual(expectedEldenRingPositionViewModel.Size            , actualEldenRingPostionViewModel.Size           );
                        break;

                    case SplitType.DarkSouls1Item:
                        var expectedItem = (SoulSplitter.SoulMemory.Games.DarkSouls1.Item)expected.Split!;
                        var actualItem = (SoulSplitter.SoulMemory.Games.DarkSouls1.Item)actual.Split!;
                        Assert.AreEqual(expectedItem.Name           , actualItem.Name);
                        Assert.AreEqual(expectedItem.Id             , actualItem.Id);
                        Assert.AreEqual(expectedItem.ItemType       , actualItem.ItemType);
                        Assert.AreEqual(expectedItem.Category       , actualItem.Category);
                        Assert.AreEqual(expectedItem.StackLimit     , actualItem.StackLimit);
                        Assert.AreEqual(expectedItem.Quantity       , actualItem.Quantity);
                        Assert.AreEqual(expectedItem.Upgrade        , actualItem.Upgrade);
                        Assert.AreEqual(expectedItem.Infusion       , actualItem.Infusion);
                        Assert.AreEqual(expectedItem.UpgradeLevel   , actualItem.UpgradeLevel);
                        break;

                    case SplitType.DarkSouls1Bonfire:
                        var expectedBonfire = (DarkSouls1BonfireViewModel)expected.Split!;
                        var actualBonfire = (DarkSouls1BonfireViewModel)actual.Split!;
                        Assert.AreEqual(expectedBonfire.Bonfire, actualBonfire.Bonfire);
                        Assert.AreEqual(expectedBonfire.BonfireState, actualBonfire.BonfireState);
                        break;

                    default:
                        Assert.Fail();
                        break;
                }
            }
        }
    }
}
