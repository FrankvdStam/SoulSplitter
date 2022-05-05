using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SoulSplitter
{
    internal static class Extensions
    {
        public static T DeserializeXml<T>(this string xml) where T : class
        {
            if (string.IsNullOrWhiteSpace(xml))
            {
                return default(T);
            }

            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
        

        public static string SerializeXml(this object obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }

            var settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                Indent = true,
            };

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(writer, obj);
                return stream.ToString();
            }
        }


        public static string GetDisplayName(this Enum enumValue)
        {
            var displayName = enumValue
                .GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                .GetCustomAttribute<DisplayAttribute>()?
                .GetName();

            if (string.IsNullOrEmpty(displayName))
            {
                displayName = enumValue.ToString();
            }
            return displayName;
        }

        public static string GetDisplayDescription(this Enum enumValue)
        {
            var displayName = enumValue
                .GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                .GetCustomAttribute<DisplayAttribute>()?
                .GetDescription();

            if (string.IsNullOrEmpty(displayName))
            {
                displayName = enumValue.ToString();
            }
            return displayName;
        }
    }
}
