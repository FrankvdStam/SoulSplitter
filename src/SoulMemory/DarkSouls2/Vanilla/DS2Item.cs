using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls2.Vanilla
{
    class DS2Item : IComparable<DS2Item>
    {
        public enum ItemType
        {
            Weapon = 0,
            Armor = 1,
            Item = 2,
            Ring = 3
        }

        private static Regex ItemEntryRx = new Regex(@"^\s*(?<id>\S+)\s+(?<name>.+)$");

        private bool ShowID;

        public string Name;
        public int ID;
        public ItemType Type;

        public static Dictionary<int, string> Items = new Dictionary<int, string>()
        {
            {3400000 ,"Fist"},
            {21001100 ,"Naked"},
            {21001101 ,"Naked"},
            {21001102 ,"Naked"},
            {21001103 ,"Naked"}
        };

        public DS2Item(string config, int type, bool showID)
        {
            Match itemEntry = ItemEntryRx.Match(config);
            ID = Convert.ToInt32(itemEntry.Groups["id"].Value);
            Type = (ItemType)type;
            ShowID = showID;
            if (showID)
                Name = ID.ToString() + ": " + itemEntry.Groups["name"].Value;
            else
                Name = itemEntry.Groups["name"].Value;

            Items.Add(ID, itemEntry.Groups["name"].Value);
        }
        public override string ToString()
        {
            return Name;
        }
        public int CompareTo(DS2Item other)
        {
            if (ShowID)
                return ID.CompareTo(other.ID);
            else
                return Name.CompareTo(other.Name);
        }
    }
}
