using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using SoulSplitterUIv2.Ui.ViewModels;

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
