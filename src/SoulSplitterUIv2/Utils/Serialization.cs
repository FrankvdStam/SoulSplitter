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
using System.Linq;
using System.Xml.Serialization;
using SoulSplitterUIv2.Ui.ViewModels;
using SoulSplitterUIv2.Ui.ViewModels.MainViewModel;

namespace SoulSplitterUIv2.Utils
{
    public static class Serialization
    {
        public static string SerializeXml(MainViewModel mainViewModel)
        {
            using (var writer = new StringWriter())
            {
                var serializer = CreateXmlSerializer();
                serializer.Serialize(writer, mainViewModel);
                return writer.ToString();
            }
        }

        public static MainViewModel DeserializeXml(string s)
        {
            using (var reader = new StringReader(s))
            {
                var serializer = CreateXmlSerializer();
                return serializer.Deserialize(reader) as MainViewModel;
            }
        }

        private static readonly List<string> SerializedFields = new List<string>()
        {
            nameof(MainViewModel.Splits),
            nameof(MainViewModel.Language),
            nameof(PositionViewModel),
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

            return new XmlSerializer(typeof(MainViewModel), attributeOverrides);
        }
    }
}
