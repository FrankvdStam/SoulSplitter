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

using System.Xml.Serialization;

namespace SoulMemory.DarkSouls1
{
    [XmlType(Namespace = "SoulMemory.DarkSouls1")]
    public enum Attribute : long
    {
        Vitality = 0x38,
        Attunement = 0x40,
        Endurance = 0x48,
        Strength = 0x50,
        Dexterity = 0x58,
        Resistance = 0x80,
        Intelligence = 0x60,
        Faith = 0x68,
        Humanity = 0x7C,
        SoulLevel = 0x88,
    }
}
