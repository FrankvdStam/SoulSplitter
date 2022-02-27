using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls2.Vanilla
{
    class DS2Infusion
    {
        public string Name;
        public int ID;
        private DS2Infusion(string name, int value)
        {
            Name = name;
            ID = value;

        }
        public override string ToString()
        {
            return Name;
        }
        public static List<DS2Infusion> Infusions = new List<DS2Infusion>()
        {
            new DS2Infusion("Normal", 0),
            new DS2Infusion("Fire", 1),
            new DS2Infusion("Magic", 2),
            new DS2Infusion("Lightning", 3),
            new DS2Infusion("Dark", 4),
            new DS2Infusion("Poison", 5),
            new DS2Infusion("Bleed", 6),
            new DS2Infusion("Raw", 7),
            new DS2Infusion("Enchanted", 8),
            new DS2Infusion("Mundane", 9)
        };
    }
}
