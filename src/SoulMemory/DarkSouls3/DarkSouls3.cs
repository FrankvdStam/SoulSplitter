using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Shared;

namespace SoulMemory.DarkSouls3
{
    public class DarkSouls3 : ITimeable
    {
        private Process _process;

        private Pointer _menuMan = null;
        private Pointer _igt = null;

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



        #region Timeable
        public int GetInGameTimeMilliseconds()
        {
            return _igt?.ReadInt32(0xa4) ?? 0;
        }

        public bool IsInGame()
        {
            var thing = _menuMan.ReadByte(0x28c);

            return thing != 0;
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
