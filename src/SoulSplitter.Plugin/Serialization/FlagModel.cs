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

namespace SoulSplitter.Plugin.Serialization;

//This class wraps the event flag.
//When a new enum is added and serialized, it tends to get serialized as uint when allowing uints on the split object.
//By having an explicit flagmodel, there is no need to allow uints.
//That causes hard exceptions during serialization, which is preferred over later runtime issues.
public class FlagModel
{
    public FlagModel() { }
    public FlagModel(uint flag) { Flag = flag; }

    public uint Flag { get; set; } = 0;
}
