using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Shared;

namespace SoulMemory.EldenRing
{
    public class EldenRing
    {
        private Process _process = null;
        private Pointer _igt;
        private Pointer _playerIns;

        public EldenRing()
        {
            Refresh();
        }

        public int GetIngameTimeMilliseconds()
        {
            if (_igt != null)
            {
                return _igt.ReadInt32();
            }
            return 0;
        }


        private void InitPointers()
        {
            _process.ScanPatternRelative("48 8b 05 ? ? ? ? 44 8b c1 48 8b 48 08 48 85 c9 74 5e 45 85 c0 74 32 41 83 f8 01 75 53 0f b6 81 01 01 00 00", 3, 7)
                .CreatePointer(out _igt, 0, 0xa0);

            _process.ScanPatternRelative("48 8b 0d ? ? ? ? 48 85 c9 0f 85 12 09 45 fb e9 df 08 45 fb 48 89 04 24 48 8b 5c 24 10", 3, 7)
                .CreatePointer(out _playerIns, 0, 0x18468, 0x178, 0x10);
        }

        public bool IsPlayerLoaded()
        {
            if (_playerIns != null)
            {
                var player = _playerIns.ReadInt32();
                return player != 0;
            }
            return false;
        }


        public void Refresh()
        {
            if (_process == null)
            {
                _process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("eldenring"));
                if (_process != null)
                {
                    InitPointers();
                }
            }
            else
            {
                if (_process.HasExited)
                {
                    _process = null;
                }
            }
        }
    }
}
