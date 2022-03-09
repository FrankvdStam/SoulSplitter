using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Native;
using SoulMemory.Shared;

namespace SoulMemory.DarkSouls3
{
    public class DarkSouls3 : ITimeable
    {
        private Process _process;

        private Pointer _menuMan = null;
        private Pointer _igt = null;
        private Pointer _playerIns = null;
        private Pointer _nowLoadingHelperImp = null;

        public DarkSouls3()
        {
            Refresh();
        }

        public bool InitPointers()
        {
            try
            {
                _process.ScanPatternRelative("48 89 35 ? ? ? ? 48 8b 5c 24 30 48 8b 74  24 38 48 83 c4 20 5f c3 83 c8 ff", 3, 7)
                    .CreatePointer(out _menuMan, 0);

                _process.ScanPatternRelative("48 8b 0d ? ? ? ? 4c 8d 44 24 40 45 33 c9 48 8b d3 40 88 74 24 28 44 88 74 24 20", 3, 7)
                    .CreatePointer(out _igt, 0);

                _process.ScanPatternRelative("48 8b 05 ? ? ? ? 48 89 98 88 00 00 00 4c 8b 05 ? ? ? ? 4c 89 44 24 38 ba 08 00 00 00 8d 4a 08", 3, 7)
                    .CreatePointer(out _playerIns, 0, 0x80);

                _process.ScanPatternRelative("48 8b 05 ? ? ? ? 80 78 4d 00 44 8b 8b d4 00 00 00 44 8b 83 d0 00 00 00 48 8b 93 c8 00 00 00 b9 0a 00 00 00 bf 58 02 00 00 0f 45 f9 48 8d 8b 80 00 00 00", 3, 7)
                    .CreatePointer(out _nowLoadingHelperImp, 0);


                return true;
            }
            catch (Exception e)
            {

            }
            return false;
        }


        public void ResetPointers()
        {
            _menuMan = null;
        }



        public void Refresh()
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
        }


        public bool IsPlayerLoaded()
        {
            if (_playerIns != null)
            {
                return _playerIns.ReadInt64() != 0;
            }
            return false;
        }



        #region Timeable
        public int GetInGameTimeMilliseconds()
        {
            return _igt?.ReadInt32(0xa4) ?? 0;
        }



        
        public bool IsInGame()
        {
            //0651740C
            var address = 0x6CD9E2FC;
            var buffer = new byte[4];
            int bufferRead = 0;
            Kernel32.ReadProcessMemory(_process.Handle, (IntPtr)address, buffer, buffer.Length, ref bufferRead);
            var value = BitConverter.ToInt32(buffer, 0);

            var nowLoadingHelperImpFlag = _nowLoadingHelperImp.ReadInt32(0x4c);

            var menuManFlag = _menuMan.ReadByte(0x34);
           
            return nowLoadingHelperImpFlag != 0 && IsPlayerLoaded();
            //return IsPlayerLoaded() && GetScreenState() == ScreenState.InGame;
        }

        public bool StartAutomatically()
        {
            var igt = GetInGameTimeMilliseconds();
            return igt > 0 && igt < 150;
        }
        #endregion
    }
}
