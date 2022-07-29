using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Shared;

namespace SoulMemory.DarkSouls1
{
    public class Remastered
    {
        #region Refresh/init/reset ================================================================================================================================

        private Process _process;
        private Pointer _gameMan;
        private Pointer _playerIns;
        private Pointer _menuMan;

        public bool Refresh(out Exception exception)
        {
            exception = null;
            if (!ProcessClinger.Refresh(ref _process, "darksoulsremastered", InitPointers, ResetPointers, out Exception e))
            {
                exception = e;
                return false;
            }
            return true;
        }

        private void ResetPointers()
        {
            _gameMan = null;
        }

        private Exception InitPointers()
        {
            try
            {
                var scanCache = _process.ScanCache();

                scanCache
                    .ScanRelative("GameMan", "4c 8b 05 ? ? ? ? 48 8d 91 80 00 00 00", 3, 7)
                    .CreatePointer(out _gameMan, 0)
                    ;

                scanCache
                    .ScanRelative("WorldChrManImp", "48 8b 05 ? ? ? ? 48 8b da 48 8b 48 68", 3, 7)
                    .CreatePointer(out _playerIns, 0, 0x68)
                    ;

                scanCache
                    .ScanRelative("MenuMan", "48 8b 15 ? ? ? ? 89 82 7c 08 00 00", 3, 7)
                    .CreatePointer(out _menuMan, 0);


                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }
        #endregion

        #region Warp
        public bool IsLoaded()
        {
            if (_menuMan == null)
            {
                return false;
            }

            var state = _menuMan.ReadInt32(0x800);
            return state != 1 && state != 2;
        }

        public int GetPlayerHealth()
        {
            return _playerIns?.ReadInt32(0x3E8) ?? 0;
        }

        public bool IsWarping()
        {
            if (_gameMan == null)
            {
                return false;
            }

            if (IsLoaded())
            {
                return false;
            }

            if (GetPlayerHealth() == 0)
            {
                return false;
            }

            return _gameMan.ReadByte(0x19) == 1;
        }
        #endregion
    }
}
