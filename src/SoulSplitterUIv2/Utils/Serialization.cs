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

using System.IO;
using System.Xml.Serialization;

namespace SoulSplitterUIv2.Utils
{
    public static class Serialization
    {
        public static string SerializeXml<T>(T t)
        {
            using var writer = new StringWriter();
            var serializer = new XmlSerializer(t!.GetType());
            serializer.Serialize(writer, t);
            return writer.ToString();
        }

        public static T DeserializeXml<T>(string s)
        {
            using var reader = new StringReader(s);
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(reader);
        }
    }
}
