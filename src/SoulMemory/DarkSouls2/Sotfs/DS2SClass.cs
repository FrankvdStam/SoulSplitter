using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoulMemory.DarkSouls2.Sotfs
{
    class DS2SClass
    {
        private static Regex ClassEntryRx = new Regex(@"^(?<id>\S+) (?<sl>\S+) (?<vig>\S+) (?<end>\S+) (?<vit>\S+) (?<att>\S+) (?<str>\S+) (?<dex>\S+) (?<adp>\S+) (?<int>\S+) (?<fth>\S+) (?<name>.+)$");

        public string Name;
        public byte ID;
        public short SoulLevel;
        public short Vigor;
        public short Endurance;
        public short Vitality;
        public short Attunement;
        public short Strength;
        public short Dexterity;
        public short Adaptability;
        public short Intelligence;
        public short Faith;

        private DS2SClass(string config)
        {
            Match classEntry = ClassEntryRx.Match(config);
            Name = classEntry.Groups["name"].Value;
            ID = Convert.ToByte(classEntry.Groups["id"].Value);
            SoulLevel = Convert.ToInt16(classEntry.Groups["sl"].Value);
            Vigor = Convert.ToInt16(classEntry.Groups["vig"].Value);
            Endurance = Convert.ToInt16(classEntry.Groups["end"].Value);
            Vitality = Convert.ToInt16(classEntry.Groups["vit"].Value);
            Attunement = Convert.ToInt16(classEntry.Groups["att"].Value);
            Strength = Convert.ToInt16(classEntry.Groups["str"].Value);
            Dexterity = Convert.ToInt16(classEntry.Groups["dex"].Value);
            Adaptability = Convert.ToInt16(classEntry.Groups["adp"].Value);
            Intelligence = Convert.ToInt16(classEntry.Groups["int"].Value);
            Faith = Convert.ToInt16(classEntry.Groups["fth"].Value);
        }

        public override string ToString()
        {
            return Name;
        }

        public static List<DS2SClass> All = new List<DS2SClass>();

        //TODO fix resources
        //static DS2SClass()
        //{
        //    foreach (string line in Regex.Split(GetTxtResourceClass.GetTxtResource(@"Resources\Systems\Classes.txt"), "[\r\n]+"))
        //    {
        //        if (GetTxtResourceClass.IsValidTxtResource(line)) //determine if line is a valid resource or not
        //            All.Add(new DS2SClass(line));
        //    }
        //}
    }
}
