using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.DarkSouls3;

namespace cli
{
    internal class EventFlagDiscovery
    {
        private DarkSouls3 _darkSouls3;
        public EventFlagDiscovery(DarkSouls3 darkSouls3)
        {
            _darkSouls3 = darkSouls3;
           
            foreach (var f in _flags)
            {
                var val = _darkSouls3.ReadEventFlag(f);
                if (val)
                {
                    Console.WriteLine($"event flag {f} enabled during init");
                }
                _dictionary[f] = val;
            }
        }

        public void Update()
        {
            foreach (var f in _flags)
            {
                var previous = _dictionary[f];
                var current = _darkSouls3.ReadEventFlag(f);
                _dictionary[f] = current;

                if (previous != current)
                {
                    Console.WriteLine($"flag {f} went from {previous} to {current}");
                }
            }
        }



        private Dictionary<uint, bool> _dictionary = new Dictionary<uint, bool>();

        private List<uint> _flags = new List<uint>()
        {
            13000830,
            13000890,
            13010800,
            13100800,
            13200800,
            13200850,
            13300800,
            13300850,
            13410830,
            13500800,
            13600800,
            13600850,
            13700800,
            13700850,
            13800800,
            13800830,
            13900800,
            14000800,
            14000830,
            14100800,
            14500800,
            14500860,
            15000800,
            15100800,
            15100850,
            15110800,

            //2000800,
            //2000801,
            //2010800,
            //2010800,
            //2910400,
            //2920800,
            //3000800,
            //3000830,
            //3000899,
            //3010800,
            //3100800,
            //3200800,
            //3200851,
            //3300801,
            //3300850,
            //3410830,
            //3500800,
            //3600800,
            //3600850,
            //3700800,
            //3700850,
            //3800800,
            //3800830,
            //3900800,
            //4000800,
            //4000830,
            //4100800,
            //4500800,
            //4500860,
            //5000801,
            //5000802,
            //5100800,
            //5100850,
            //5110800,
        };
    }
}
