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
    internal class Remastered : IDarkSouls1
    {
        #region Refresh/init/reset ================================================================================================================================

        private Process _process;

        private Pointer _gameMan;
        private Pointer _gameDataMan;
        private Pointer _playerIns;
        private Pointer _playerPos;
        private Pointer _playerGameData;
        private Pointer _eventFlags;

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
                    .ScanRelative("GameDataMan", "48 8b 05 ? ? ? ? 48 8b 50 10 48 89 54 24 60", 3, 7)
                    .CreatePointer(out _gameDataMan, 0)
                    .CreatePointer(out _playerGameData, 0, 0x10)
                    ;

                scanCache
                    .ScanRelative("WorldChrManImp", "48 8b 05 ? ? ? ? 48 8b da 48 8b 48 68", 3, 7)
                    .CreatePointer(out _playerIns, 0, 0x68)
                    .CreatePointer(out _playerPos, 0, 0x68, 0x68, 0x28)
                    ;

                scanCache
                    .ScanRelative("EventFlags", "48 8B 0D ? ? ? ? 99 33 C2 45 33 C0 2B C2 8D 50 F6", 3, 7)
                    .CreatePointer(out _eventFlags, 0)
                    ;
                
                //scanCache
                //    .ScanRelative("MenuMan", "48 8b 15 ? ? ? ? 89 82 7c 08 00 00", 3, 7)
                //    .CreatePointer(out _menuMan, 0);


                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }
        #endregion
        public int GetAttribute(Attribute attribute) => _playerGameData?.ReadInt32(0x8 + (long)attribute) ?? 0;

        public int GetInGameTimeMilliseconds() => _gameDataMan?.ReadInt32(0xa4) ?? 0;

        public Vector3f GetPosition() => _playerPos == null ? new Vector3f(0, 0, 0) : new Vector3f(_playerPos.ReadFloat(0x10), _playerPos.ReadFloat(0x14), _playerPos.ReadFloat(0x18));

        public int GetPlayerHealth() => _playerIns?.ReadInt32(0x3e8) ?? 0;

        public bool IsPlayerLoaded() => !_playerIns?.IsNullPtr() ?? false;

        public bool IsWarpRequested()
        {
            if (_gameMan == null)
            {
                return false;
            }

            if (GetPlayerHealth() == 0)
            {
                return false;
            }

            return _gameMan.ReadByte(0x19) == 1;
        }

        public object GetTestValue() => null;

        #region eventflags

        //Credit to JKAnderson for the event flag reading code, https://github.com/JKAnderson/DSR-Gadget

        private static readonly Dictionary<string, int> EventFlagGroups = new Dictionary<string, int>()
        {
            {"0", 0x00000},
            {"1", 0x00500},
            {"5", 0x05F00},
            {"6", 0x0B900},
            {"7", 0x11300},
        };
        
        private static readonly Dictionary<string, int> EventFlagAreas = new Dictionary<string, int>()
        {
            {"000", 00},
            {"100", 01},
            {"101", 02},
            {"102", 03},
            {"110", 04},
            {"120", 05},
            {"121", 06},
            {"130", 07},
            {"131", 08},
            {"132", 09},
            {"140", 10},
            {"141", 11},
            {"150", 12},
            {"151", 13},
            {"160", 14},
            {"170", 15},
            {"180", 16},
            {"181", 17},
        };

        private int GetEventFlagOffset(uint eventFlagId, out uint mask)
        {
            string idString = eventFlagId.ToString("D8");
            if (idString.Length == 8)
            {
                string group = idString.Substring(0, 1);
                string area = idString.Substring(1, 3);
                int section = Int32.Parse(idString.Substring(4, 1));
                int number = Int32.Parse(idString.Substring(5, 3));

                if (EventFlagGroups.ContainsKey(group) && EventFlagAreas.ContainsKey(area))
                {
                    int offset = EventFlagGroups[group];
                    offset += EventFlagAreas[area] * 0x500;
                    offset += section * 128;
                    offset += (number - (number % 32)) / 8;

                    mask = 0x80000000 >> (number % 32);
                    return offset;
                }
            }
            throw new ArgumentException("Unknown event flag ID: " + eventFlagId);
        }

        public bool ReadEventFlag(uint eventFlagId)
        {
            if (_eventFlags == null)
            {
                return false;
            }

            int offset = GetEventFlagOffset(eventFlagId, out uint mask);
            uint value = _eventFlags.ReadUInt32(offset);
            return (value & mask) != 0;
        }
        #endregion
    }
}
