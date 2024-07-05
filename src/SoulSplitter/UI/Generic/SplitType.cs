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

using SoulMemory;
using System.ComponentModel.DataAnnotations;

namespace SoulSplitter.UI.Generic
{
    public enum SplitType
    {
        [Annotation(Name = "Bonfire/Grace/Idol")]
        Bonfire,

        [Annotation(Name = "Boss")]
        Boss,

        [Annotation(Name = "Position")]
        Position,

        [Annotation(Name = "Attribute")]
        Attribute,

        [Annotation(Name = "Known Flag")]
        KnownFlag,

        [Annotation(Name = "Custom Flag")]
        Flag,

        [Annotation(Name = "Iventory item")]
        Item,

        [Annotation(Name = "Item pickup")]
        ItemPickup,

        [Annotation(Name = "Credits")]
        Credits,
    }
}
