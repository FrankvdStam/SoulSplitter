using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.DarkSouls1.Internal;
using SoulMemory.Memory;
using SoulMemory.Shared;

namespace SoulMemory.EldenRing
{
    public class EldenRing
    {
        public Exception PointerScanException;
        private Process _process = null;
        private Pointer _igt;
        private Pointer _playerIns;
        private Pointer _menuManIns;
        

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


        private bool InitPointers()
        {
            try
            {
                _process.ScanPatternRelative("48 8b 05 ? ? ? ? 4c 8b 40 08 4d 85 c0 74 0d 45 0f b6 80 be 00 00 00 e9 13 00 00 00", 3, 7)
                    .CreatePointer(out _igt, 0, 0xa0);

                _process.ScanPatternRelative("48 8b 05 ? ? ? ? 48 89 98 70 84 01 00 4c 89 ab 74 06 00 00 4c 89 ab 7c 06 00 00 44 88 ab 84 06 00 00 41 83 7f 4c 00", 3, 7)
                    .CreatePointer(out _playerIns, 0, 0x18468);

                //CSMenuManIns
                _process.ScanPatternRelative("48 8b 0d ? ? ? ? 4c 8b bc 24 90 00 00 00 4c 8b b4 24 98 00 00 00 4c 8b a4 24 a0 00 00 00 48 8b b4 24 d0 00 00 00 48 8b 9c 24 c8 00 00 00", 3, 7)
                    .CreatePointer(out _menuManIns, 0);

                return true;
            }
            catch (Exception ex)
            {
                PointerScanException = ex;
                return false;
            }
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


        public ScreenState GetScreenState()
        {
            if (_menuManIns != null)
            {
                var screenState = _menuManIns.ReadInt32(0x718);
                if (screenState.TryParseEnum(out ScreenState s))
                {
                    return s;
                }
            }
            return ScreenState.Unknown;
        }


        public void Refresh()
        {
            if (_process == null)
            {
                _process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("eldenring"));
                if (_process != null)
                {
                    if (!InitPointers())
                    {
                        _process = null;
                    }
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
