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
            
            _process.ScanPatternRelative("48 8b 05 ? ? ? ? 4c 8b 40 08 4d 85 c0 74 0d 45 0f b6 80 be 00 00 00 e9 13 00 00 00", 3, 7)
                .CreatePointer(out _igt, 0, 0xa0);
                                        
            _process.ScanPatternRelative("48 8b 0d ? ? ? ? 48 85 c9 48 89 6c 24 f8 48 8d 64 24 f8 e9 b6 e1 00 00", 3, 7)
                .CreatePointer(out _playerIns, 0, 0x18468);
        }

        public bool IsPlayerLoaded()
        {
            if (_playerIns != null)
            {
                var player = _playerIns.ReadInt64();
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
