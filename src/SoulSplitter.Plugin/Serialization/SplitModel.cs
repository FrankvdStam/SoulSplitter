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

using SoulSplitter.Plugin.Ui.ViewModels;
using SoulSplitter.SoulMemory.Enums;
using System.Xml.Serialization;

namespace SoulSplitter.Plugin.Serialization;

[XmlType(TypeName = "Split")]
public class SplitModel
{
    public SplitModel(SplitViewModel vm) : this(vm.Game!.Value, vm.TimingType, vm.SplitType, vm.Split, vm.Description){ }

    public SplitModel(Game game, TimingType? timingType, SplitType splitType, object? split, string description)
    {
        Game = game;
        TimingType = timingType;
        SplitType = splitType;
        Description = description;

        Split = split switch
        {
            AttributeViewModel attributeViewModel => new AttributeModel(attributeViewModel),
            uint flag => new FlagModel(flag),
            _ => split
        };
    }

    public SplitViewModel CreateSplitsViewModel()
    {
        return new SplitViewModel
        {
            Game = Game,
            TimingType = TimingType,
            SplitType = SplitType,
            Description = Description,

            Split = Split switch
            {
                AttributeModel attributeModel => new AttributeViewModel { Attribute = attributeModel.Attribute, Level = attributeModel.Level },
                FlagModel flagModel => flagModel.Flag,
                _ => Split
            }
        };       
    }

    public SplitModel(){ }

    public Game Game { get; set; }
    public TimingType? TimingType { get; set; }
    public SplitType SplitType { get; set; }

    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls1.Boss),         Namespace = "DarkSouls1"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls1.Bonfire),      Namespace = "DarkSouls1"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls1.BonfireState), Namespace = "DarkSouls1"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls1.DropModType),  Namespace = "DarkSouls1"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls1.ItemType),     Namespace = "DarkSouls1"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls1.KnownFlag),    Namespace = "DarkSouls1"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls1.Item),         Namespace = "DarkSouls1"   )]
    [XmlElement(Type = typeof(DarkSouls1BonfireViewModel),               Namespace = "DarkSouls1"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls2.Boss),         Namespace = "DarkSouls2"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls3.Boss),         Namespace = "DarkSouls3"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls3.Bonfire),      Namespace = "DarkSouls3"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls3.ItemPickup),   Namespace = "DarkSouls3"   )]
    [XmlElement(Type = typeof(SoulMemory.Games.Sekiro.Boss),             Namespace = "Sekiro"       )]
    [XmlElement(Type = typeof(SoulMemory.Games.Sekiro.Idol),             Namespace = "Sekiro"       )]
    [XmlElement(Type = typeof(SoulMemory.Games.EldenRing.Boss),          Namespace = "EldenRing"    )]
    [XmlElement(Type = typeof(SoulMemory.Games.EldenRing.Grace),         Namespace = "EldenRing"    )]
    [XmlElement(Type = typeof(SoulMemory.Games.EldenRing.ItemPickup),    Namespace = "EldenRing"    )]
    [XmlElement(Type = typeof(SoulMemory.Games.EldenRing.KnownFlag),     Namespace = "EldenRing"    )]
    [XmlElement(Type = typeof(SoulMemory.Games.Nightreign.Boss),         Namespace = "Nightreign"   )]
    [XmlElement(Type = typeof(AttributeModel)                                                       )]
    [XmlElement(Type = typeof(PositionViewModel)                                                    )]
    [XmlElement(Type = typeof(EldenRingPositionViewModel)                                           )]
    [XmlElement(Type = typeof(FlagModel)                                                            )]
    public object? Split { get; set; }
    public string Description { get; set; } = null!;
}
