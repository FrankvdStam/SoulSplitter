using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoulMemory.DarkSouls2
{
    [XmlType(Namespace = "SoulMemory.DarkSouls2")]
    public enum Attribute
    {
        SoulLevel,
        Vigor,
        Endurance,
        Vitality,
        Attunement,
        Strength,
        Dexterity,
        Adaptability,
        Intelligence,
        Faith,
    }
}
