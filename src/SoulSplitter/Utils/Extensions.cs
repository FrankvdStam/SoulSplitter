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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace SoulSplitter.Utils;

internal static class Extensions
{
    public static T DeserializeXml<T>(this string xml) where T : class
    {
        if (string.IsNullOrWhiteSpace(xml))
        {
            return default!;
        }

        var serializer = new XmlSerializer(typeof(T));
        using var reader = new StringReader(xml);
        return (T)serializer.Deserialize(reader);
    }


    public static string SerializeXml(this object? obj)
    {
        if (obj == null)
        {
            return string.Empty;
        }

        var settings = new XmlWriterSettings()
        {
            OmitXmlDeclaration = true,
            Indent = true
        };

        using var stream = new StringWriter();
        using var writer = XmlWriter.Create(stream, settings);
        var serializer = new XmlSerializer(obj.GetType());
        serializer.Serialize(writer, obj);
        return stream.ToString();
    }

    public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
    {
        foreach (var item in enumerable)
        {
            action(item);
        }
    }

    public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> range) => range.ForEach(collection.Add);
}
