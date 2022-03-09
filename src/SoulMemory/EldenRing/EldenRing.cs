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
    public class EldenRing : ITimeable
    {
        public Exception Exception;
        
        private Process _process = null;
        

        private Pointer _igt;
        private Pointer _playerIns;
        private Pointer _playerChrPhysicsModule;
        private Pointer _menuManIns;
        

        public EldenRing()
        {
            Refresh();
        }


        private bool InitPointers()
        {
            try
            {
                _process.ScanPatternRelative("48 8b 05 ? ? ? ? 4c 8b 40 08 4d 85 c0 74 0d 45 0f b6 80 be 00 00 00 e9 13 00 00 00", 3, 7)
                    .CreatePointer(out _igt, 0, 0xa0);

                _process.ScanPatternRelative("48 8b 05 ? ? ? ? 48 89 98 70 84 01 00 4c 89 ab 74 06 00 00 4c 89 ab 7c 06 00 00 44 88 ab 84 06 00 00 41 83 7f 4c 00", 3, 7)
                    .CreatePointer(out _playerIns, 0, 0x18468)
                    .CreatePointer(out _playerChrPhysicsModule, 0, 0x18468, 0xf68);

                //CSMenuManIns
                _process.ScanPatternRelative("48 8b 0d ? ? ? ? 4c 8b bc 24 90 00 00 00 4c 8b b4 24 98 00 00 00 4c 8b a4 24 a0 00 00 00 48 8b b4 24 d0 00 00 00 48 8b 9c 24 c8 00 00 00", 3, 7)
                    .CreatePointer(out _menuManIns, 0);

                return true;
            }
            catch (Exception e)
            {
                Exception = e;
                return false;
            }
        }

        private void ResetPointers()
        {
            _igt = null;
            _playerIns = null;
            _menuManIns = null;
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

        public Vector3f GetPosition()
        {
            if (_playerChrPhysicsModule != null)
            {
                return new Vector3f(_playerChrPhysicsModule.ReadFloat(0x70), _playerChrPhysicsModule.ReadFloat(0x74), _playerChrPhysicsModule.ReadFloat(0x78));
            }
            return new Vector3f(0, 0, 0);
        }

        public float GetAngle()
        {
            if (_playerChrPhysicsModule != null)
            {
                return _playerChrPhysicsModule.ReadFloat(0x54);
            }
            return 0f;
        }

        /// <summary>
        /// Returns the screen state. Will falsely report InGame when the game is starting up.
        /// </summary>
        /// <returns></returns>
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

        private bool _pointersInitialized = false;
        public bool Refresh()
        {
            if (_process == null)
            {
                _process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("eldenring"));
                if (_process != null)
                {
                    if (InitPointers())
                    {
                        _pointersInitialized = true;
                        return true;
                    }
                    else
                    {
                        var pointerScanException = new Exception($"Pointer scan failed.\nIs EAC disabled?\n{Exception.Message}", Exception);
                        Exception = pointerScanException;
                    }
                }

                return false;
            }
            else
            {
                if (_process.HasExited)
                {
                    _process = null;
                    _pointersInitialized = false;
                    ResetPointers();
                }

                return _pointersInitialized;
            }
        }

        public bool Attached => _process != null;

        #region Timeable
        public int GetInGameTimeMilliseconds()
        {
            return _igt?.ReadInt32() ?? 0;
        }

        public bool IsInGame()
        {
            return IsPlayerLoaded() && GetScreenState() == ScreenState.InGame;
        }

        public bool StartAutomatically()
        {
            var igt = GetInGameTimeMilliseconds();
            return igt > 0 && igt < 150;
        }
        #endregion
    }
}
