﻿// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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

namespace SoulMemory.EldenRing;

public class Position
{
    public byte Area;
    public byte Block;
    public byte Region;
    public byte Size;

    public float X;
    public float Y;
    public float Z;

    public override string ToString()
    {
        return $"m{Area:D2}_{Block:D2}_{Region:D2}_{Size:D2} - ({X:F2}, {Y:F2}, {Z:F2})";
    }
}
