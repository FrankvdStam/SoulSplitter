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
using System.Xml.Serialization;

namespace SoulSplitter.Plugin.Serialization
{
    public class AttributeModel
    {
        public AttributeModel(AttributeViewModel viewModel)
        {
            Attribute = viewModel.Attribute;
            Level = viewModel.Level;
        }

        public AttributeModel(){ }

        [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls1.Attribute),    Namespace = "DarkSouls1"   )]
        [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls2.Attribute),    Namespace = "DarkSouls2"   )]
        [XmlElement(Type = typeof(SoulMemory.Games.DarkSouls3.Attribute),    Namespace = "DarkSouls3"   )]
        [XmlElement(Type = typeof(SoulMemory.Games.Sekiro.Attribute),        Namespace = "Sekiro"       )]
        public object Attribute{ get; set; } = null!;
        public int Level { get; set; } = 10;
    }
}
