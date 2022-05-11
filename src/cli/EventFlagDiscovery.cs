using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.EldenRing;

namespace cli
{
    internal class EventFlagDiscovery
    {
        private EldenRing _eldenRing;
        public EventFlagDiscovery(EldenRing eldenRing)
        {
            _eldenRing = eldenRing;
            
            var knownBosses = Enum.GetValues(typeof(Boss)).Cast<uint>().ToList();
            
            foreach (var b in knownBosses)
            {
                _flags.Remove(b);
            }
            
            foreach (var f in _flags)
            {
                var val = _eldenRing.ReadEventFlag(f);
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
                var current = _eldenRing.ReadEventFlag(f);
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
            //SONAF pickup
            76228,
            76247,

        };
    }
}
