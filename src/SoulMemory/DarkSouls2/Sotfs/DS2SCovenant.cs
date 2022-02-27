using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls2.Sotfs
{
    internal class DS2SCovenant
    {
        private static Regex BonfireEntryRx = new Regex(@"^(?<id>\S+) (?<name>.+) \((?<levels>\S+)\)$");

        public string Name;
        public byte ID;
        public string Levels;

        private DS2SCovenant(string config)
        {
            Match bonfireEntry = BonfireEntryRx.Match(config);
            Name = bonfireEntry.Groups["name"].Value;
            ID = Convert.ToByte(bonfireEntry.Groups["id"].Value);
            Levels = bonfireEntry.Groups["levels"].Value;
        }
        public override string ToString()
        {
            return Name;
        }

        public static List<DS2SCovenant> All = new List<DS2SCovenant>();

        //TODO fix resources
        //static DS2SCovenant()
        //{
        //    foreach (string line in Regex.Split(GetTxtResourceClass.GetTxtResource("Resources/Systems/Covenants.txt"), "[\r\n]+"))
        //    {
        //        if (GetTxtResourceClass.IsValidTxtResource(line)) //determine if line is a valid resource or not
        //            All.Add(new DS2SCovenant(line));
        //    };
        //}
    }
}
