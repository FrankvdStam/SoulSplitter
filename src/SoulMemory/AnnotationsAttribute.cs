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

using System;

namespace SoulMemory;

//I used to use Dispaly(Name = "", Description = "") to add human friendly boss/bonfire names
//and locations to enum flags. When switching to .net standard, it was troublesome to get
//livesplit to properly load the data annotations lib from microsoft. Rather than fighting
//livesplit over loading it, I opted to just ditch it and use a simple attribute.
//That's why this annotion exists and why it is so similar to Display().

[AttributeUsage(AttributeTargets.Field)]
public class AnnotationAttribute : Attribute
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}
