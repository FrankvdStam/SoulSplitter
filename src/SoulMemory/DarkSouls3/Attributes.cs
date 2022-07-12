using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoulMemory.DarkSouls3
{
    [XmlType(Namespace = "SoulMemory.DarkSouls3")]
    public enum Attribute
    {
        Vigor = 0x44,
        Attunement = 0x48,
        Endurance = 0x4c,
        Vitality = 0x6c,
        Strength = 0x50,
        Dexterity = 0x54,
        Intelligence = 0x58,
        Faith = 0x5c,
        Luck = 0x60,

        SoulLevel = 0x70,
        Humanity = 0x68,
    }
}
