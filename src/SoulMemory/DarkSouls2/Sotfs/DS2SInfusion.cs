using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls2.Sotfs
{
    class DS2SInfusion
    {
        public string Name;
        public int ID;
        private DS2SInfusion(string name, int value)
        {
            Name = name;
            ID = value;

        }
        public override string ToString()
        {
            return Name;
        }
        public static List<DS2SInfusion> Infusions = new List<DS2SInfusion>()
        {
            new DS2SInfusion("Normal"   , 0),
            new DS2SInfusion("Fire"     , 1),
            new DS2SInfusion("Magic"    , 2),
            new DS2SInfusion("Lightning", 3),
            new DS2SInfusion("Dark"     , 4),
            new DS2SInfusion("Poison"   , 5),
            new DS2SInfusion("Bleed"    , 6),
            new DS2SInfusion("Raw"      , 7),
            new DS2SInfusion("Enchanted", 8),
            new DS2SInfusion("Mundane"  , 9)
        };
    }
}
