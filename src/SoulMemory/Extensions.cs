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

using System;
using System.Collections.Generic;
using System.Xml;

namespace SoulMemory
{
    public static class Extensions
    {
        public static bool TryParseEnum<T>(this int value, out T result)
        {
            result = default;
            if (Enum.IsDefined(typeof(T), value))
            {
                result = (T)(object)value;
                return true;
            }
            return false;
        }

        public static bool TryParseEnum<T>(this uint value, out T result)
        {
            result = default;
            if (Enum.IsDefined(typeof(T), value))
            {
                result = (T)(object)value;
                return true;
            }
            return false;
        }

        public static XmlNode GetChildNodeByName(this XmlNode node, string childName)
        {
            var lower = childName.ToLower();
            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName.ToLower() == lower)
                {
                    return child;
                }
            }
            throw new ArgumentException($"{childName} not found");
        }

        public static IEnumerable<XmlNode> Enumerate(this XmlNodeList list)
        {
            foreach (XmlNode node in list)
            {
                yield return node;
            }
        }

        public static bool IsBitSet(this long l, int index)
        {
            return (l & ((long)0x1 << index)) != 0;
        }

        public static long SetBit(this long l, int index)
        {
            return l | ((long)0x1 << index);
        }

        public static long ClearBit(this long l, int index)
        {
            return l & ~((long)0x1 << index);
        }

    }
}
