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

namespace SoulMemory.Enums;

public enum SplitType
{
    Boss,
    Flag,
    KnownFlag,
    //Inventory item, specific to ds1
    DarkSouls1Item,
    ItemPickup,
    //"Normal" position is always a vec3
    Position,
    //Elden Ring position is a vec3 but also includes map coordinates
    EldenRingPosition,
    //"Normal" bonfire/idol/grace is an event flag
    Bonfire,
    //DS1 bonfires are some sort of linked list, all other games handle this via event flags.
    DarkSouls1Bonfire,
    Attribute,
}
