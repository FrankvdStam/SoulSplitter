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

using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;
using SoulSplitter.UiOld.Generic;

namespace SoulSplitter;

internal static class Extensions
{
    public static T DeserializeXml<T>(this string xml) where T : class
    {
        if (string.IsNullOrWhiteSpace(xml))
        {
            return default(T)!;
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

    public static bool SetField<TField>(this ICustomNotifyPropertyChanged viewModel, ref TField field, TField value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<TField>.Default.Equals(field, value))
        {
            return false;
        }

        field = value;
        viewModel.InvokePropertyChanged(propertyName!);
        return true;
    }
}
