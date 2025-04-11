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
using System.Xml.Serialization;
using SoulMemory.Enums;
using System.Xml.Schema;
using System.Xml;
using SoulMemory;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulSplitter.Ui.ViewModels.MainViewModel;


public partial class MainViewModel
{
    public string SerializeXml()
    {
        using (var writer = new StringWriter())
        {
            var serializer = CreateXmlSerializer();
            serializer.Serialize(writer, this);
            return writer.ToString();
        }
    }

    public static MainViewModel DeserializeXml(string s)
    {
        using (var reader = new StringReader(s))
        {
            var serializer = CreateXmlSerializer();
            return (MainViewModel)serializer.Deserialize(reader);
        }
    }

    private static readonly List<string> SerializedFields = new List<string>()
    {
        nameof(MainViewModel.Version),
        nameof(MainViewModel.Language),
        nameof(MainViewModel.Splits),
    };

    private static XmlSerializer CreateXmlSerializer()
    {
        //Get names of fields and properties via reflection to ignore everything by default
        var properties = typeof(MainViewModel).GetProperties();
        var fields = typeof(MainViewModel).GetFields();
        var names = properties.Select(i => i.Name).ToList();
        names.AddRange(fields.Select(i => i.Name));

        //Remove only the fields we want serialized
        SerializedFields.ForEach(i => names.Remove(i));

        var attributeOverrides = new XmlAttributeOverrides();
        names.ForEach(name => attributeOverrides.Add(typeof(MainViewModel), name, new XmlAttributes() { XmlIgnore = true }));

        return new XmlSerializer(typeof(MainViewModel),attributeOverrides);
    }
}

