using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Native;
using SoulMemory.Shared;

namespace SoulMemory.DarkSouls3
{
    public class DarkSouls3
    {
        private Process _process;

        //private Pointer _menuMan = null;
        private Pointer _gameDataMan = null;
        private Pointer _playerIns = null;
        //private Pointer _nowLoadingHelperImp = null;
        private Pointer _loading = null;
        private Pointer _blackscreen = null;
        public Exception Exception;

        public DarkSouls3()
        {
            Refresh();
        }

        private bool InitPointers()
        {
            try
            {
                _process.ScanCache()
                    //.ScanRelative("menuMan", "48 8b cb 41 ff 10 4c 8b 07 48 8b d3 48 8b cf 41 ff 50 68 48 89 35 ? ? ? ? 48 8b 0d ? ? ? ? 48 85 c9 74 33 e8 ? ? ? ? 48 8b 1d ? ? ? ? 48 8b f8 48 85 db 74 18 4c 8b 03 33 d2 48 8b cb 41 ff 10 4c 8b 07 48 8b d3 48 8b cf 41 ff 50 68 48 89 35 ? ? ? ? 48 8b 5c 24 30 48 8b 74 24 38 48 83 c4 20 5f c3", 33, 7)
                    //    .CreatePointer(out _menuMan, 0)

                    //.ScanRelative("NowLoadingHelperImp", "48 8b 05 ? ? ? ? 80 78 4d 00 44 8b 8b d4 00 00 00 44 8b 83 d0 00 00 00 48 8b 93 c8 00 00 00 b9 0a 00 00 00 bf 58 02 00 00 0f 45 f9 48 8d 8b 80 00 00 00", 3, 7)
                    //    .CreatePointer(out _nowLoadingHelperImp, 0)

                    .ScanRelative("IGT", "48 8b 0d ? ? ? ? 4c 8d 44 24 40 45 33 c9 48 8b d3 40 88 74 24 28 44 88 74 24 20", 3, 7)
                        .CreatePointer(out _gameDataMan, 0)

                    .ScanRelative("playerIns", "48 8b 0d ? ? ? ? 45 33 c0 48 8d 55 e7 e8 ? ? ? ? 0f 2f 73 70 72 0d f3 ? ? ? ? ? ? ? ? 0f 11 43 70", 3, 7)
                        .CreatePointer(out _playerIns, 0, 0x80)

                   
                    .ScanRelative("Loading", "c6 05 ? ? ? ? ? e8 ? ? ? ? 84 c0 0f 94 c0 e9", 2, 7)
                        .CreatePointer(out _loading)

                    .ScanRelative("SprjFadeImp", "48 8b 0d ? ? ? ? 4c 8d 4c 24 38 4c 8d 44 24 48 33 d2", 3, 7) //0x8 = ptr to Fd4FadeSystem
                        .CreatePointer(out _blackscreen, 0x0, 0x8, 0x2ec)

                    ;

                return true;
            }
            catch(Exception e)
            {
                Exception = e;
            }
            return false;
        }

        private void ResetPointers()
        {
            _gameDataMan = null;
            _playerIns = null;
            _loading = null;
            _blackscreen = null;
        }

        public bool IsLoading()
        {
            if (_loading == null)
            {
                return true;
            }
            return _loading?.ReadInt32(-0x1) != 0;
        }

        public bool BlackscreenActive()
        {
            return _blackscreen?.ReadInt32() != 0;
        }

        //public bool Cutscene()
        //{
        //    if (_cutscene == null)
        //    {
        //        return true;
        //    }
        //
        //    return _cutscene.ReadInt32() != 2;
        //}

        public bool Refresh()
        {
            if (_process == null)
            {
                _process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("darksoulsiii"));
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
                    ResetPointers();
                }
            }
            return _process != null;
        }
        
        public bool Attached => _process != null;

        public bool IsPlayerLoaded()
        {
            if (_playerIns != null)
            {
                return _playerIns.ReadInt64() != 0;
            }
            return false;
        }

        public void WriteInGameTimeMilliseconds(int millis)
        {
            _gameDataMan?.WriteInt32(0xa4, millis);
        }

        public int GetInGameTimeMilliseconds()
        {
            return _gameDataMan?.ReadInt32(0xa4) ?? 0;
        }
    }
}
