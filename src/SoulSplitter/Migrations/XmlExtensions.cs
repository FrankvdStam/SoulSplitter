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
using System.Xml;

namespace SoulSplitter.Migrations;

internal static class XmlExtensions
{
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

    public static void ForEachChildNodeByName(this XmlNode node, string childName, Action<XmlNode> action)
    {
        var lower = childName.ToLower();
        foreach (XmlNode child in node.ChildNodes)
        {
            if (child.LocalName.ToLower() == lower)
            {
                action(child);
            }
        }
    }
}
