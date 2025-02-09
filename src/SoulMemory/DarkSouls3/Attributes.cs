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

namespace SoulMemory.DarkSouls3;

[XmlType(Namespace = "SoulMemory.DarkSouls3")]
public enum Attribute
{
    Vigor = 0x44,
    Attunement = 0x48,
    Endurance = 0x4c,
    Vitality = 0x6c,
    Strength = 0x50,
    Dexterity = 0x54,
    Intelligence = 0x58,
    Faith = 0x5c,
    Luck = 0x60,

    SoulLevel = 0x70,
    Humanity = 0x68
}
