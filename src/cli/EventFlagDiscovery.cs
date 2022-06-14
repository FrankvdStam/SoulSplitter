using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Sekiro;

namespace cli
{
    internal class EventFlagDiscovery
    {
        private Sekiro _sekiro;
        public EventFlagDiscovery(Sekiro sekiro)
        {
            _sekiro = sekiro;
           
            foreach (var f in _flags)
            {
                var val = _sekiro.ReadEventFlag(f);
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
                var current = _sekiro.ReadEventFlag(f);
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
            11120000,
            12000005,
            
            9317,
            9315,
            9316,
            9312,
        };
    }
}
