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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace SoulSplitter.Ui.ViewModels.MainViewModel;

public partial class MainViewModel
{
    public string SerializeXml()
    {
        var xmlWriterSettings = new XmlWriterSettings
        {
            Indent = true,
            OmitXmlDeclaration = true
        };

        using var stringWriter = new StringWriter();
        using var writer = XmlWriter.Create(stringWriter, xmlWriterSettings);
        var serializer = CreateXmlSerializer();
        serializer.Serialize(writer, this);
        return stringWriter.ToString();
    }

    public static MainViewModel DeserializeXml(string s)
    {
        using var reader = new StringReader(s);
        var serializer = CreateXmlSerializer();
        return (MainViewModel)serializer.Deserialize(reader);
    }

    private static readonly List<string> SerializedFields = new List<string>()
    {
        nameof(MainViewModel.Version),
        nameof(MainViewModel.Language),
        nameof(MainViewModel.Splits),
        nameof(MainViewModel.FlagTrackerViewModel),
    };

    private static readonly Type[] ExtraTypes = [
        typeof(PositionViewModel),
        typeof(AttributeViewModel),
    ];

    private static readonly Type[] ExtraTypesWithNamespace =
    [
        typeof(SoulMemory.Games.DarkSouls1.Boss),
        typeof(SoulMemory.Games.DarkSouls1.Attribute),
        typeof(SoulMemory.Games.DarkSouls1.Bonfire),
        typeof(SoulMemory.Games.DarkSouls1.BonfireState),
        typeof(SoulMemory.Games.DarkSouls1.DropModType),
        typeof(SoulMemory.Games.DarkSouls1.ItemType),
        typeof(SoulMemory.Games.DarkSouls1.KnownFlag),

        typeof(SoulMemory.Games.DarkSouls2.Boss),
        typeof(SoulMemory.Games.DarkSouls2.Attribute),

        typeof(SoulMemory.Games.DarkSouls3.Boss),
        typeof(SoulMemory.Games.DarkSouls3.Bonfire),
        typeof(SoulMemory.Games.DarkSouls3.Attribute),
        typeof(SoulMemory.Games.DarkSouls3.ItemPickup),

        typeof(SoulMemory.Games.Sekiro.Boss),
        typeof(SoulMemory.Games.Sekiro.Idol),
        typeof(SoulMemory.Games.Sekiro.Attribute),

        typeof(SoulMemory.Games.EldenRing.Boss),
        typeof(SoulMemory.Games.EldenRing.Grace),
        typeof(SoulMemory.Games.EldenRing.ItemPickup),
        typeof(SoulMemory.Games.EldenRing.KnownFlag),
    ];

    private static XmlSerializer CreateXmlSerializer()
    {
        //Get names of fields and properties via reflection to ignore everything by default
        var properties = typeof(MainViewModel).GetProperties();
        var names = properties.Select(i => i.Name).ToList();

        //Remove only the fields we want serialized
        SerializedFields.ForEach(i => names.Remove(i));

        var attributeOverrides = new XmlAttributeOverrides();
        names.ForEach(name => attributeOverrides.Add(typeof(MainViewModel), name, new XmlAttributes() { XmlIgnore = true }));

        attributeOverrides.Add(typeof(SplitViewModel), nameof(SplitViewModel.IsSplitConditionMet), new XmlAttributes() { XmlIgnore = true });
        attributeOverrides.Add(typeof(SplitViewModel), nameof(SplitViewModel.IsDisabled), new XmlAttributes() { XmlIgnore = true });
        
        foreach (var type in ExtraTypesWithNamespace)
        {
            attributeOverrides.Add(type, new XmlAttributes { XmlType = new XmlTypeAttribute() { Namespace = type.Namespace } });
        }

        var combinedExtraTypes = ExtraTypes.Union(ExtraTypesWithNamespace).ToArray();
        return new XmlSerializer(typeof(MainViewModel), attributeOverrides, combinedExtraTypes, null, null);
    }
}

