using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Native;
using SoulMemory.Shared;

namespace SoulMemory.DarkSouls1
{
    internal class Ptde : IDarkSouls1
    {
        #region Refresh/init/reset ================================================================================================================================

        private Process _process;

        private Pointer _gameDataMan;
        private Pointer _worldChrManImp;
        private Pointer _playerIns;
        private Pointer _playerGameData;
        private Pointer _eventFlags;

        public bool Refresh(out Exception exception)
        {
            exception = null;
            if (!ProcessClinger.Refresh(ref _process, "darksouls", InitPointers, ResetPointers, out Exception e))
            {
                exception = e;
                return false;
            }
            return true;
        }

        private void ResetPointers()
        {
            _gameDataMan = null;
            _worldChrManImp = null;
            _playerIns = null;
            _playerGameData = null;
            _eventFlags = null;
        }

        private Exception InitPointers()
        {
            try
            {
                var scanCache = _process.ScanCache();

                scanCache
                    .ScanAbsolute("GameDataMan", "8b 0d ? ? ? ? 8b 41 30 8b 4d 64", 2)
                    .CreatePointer(out _gameDataMan, 0, 0)
                    .CreatePointer(out _playerGameData, 0, 0, 0x8)
                    ;

                scanCache
                    .ScanAbsolute("WorldChrManImp", "8b 0d ? ? ? ? 8b 71 3c c6 44 24 48 01", 2)
                    .CreatePointer(out _worldChrManImp, 0, 0)
                    .CreatePointer(out _playerIns, 0, 0, 0x3c);
                    ;


                scanCache
                    .ScanAbsolute("WorldChrManImp", "56 8B F1 8B 46 1C 50 A1 ? ? ? ? 32 C9", 8)
                    .CreatePointer(out _eventFlags, 0, 0, 0)
                    ;

                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        #endregion

        public int GetAttribute(Attribute attribute) => _playerGameData?.ReadInt32((long)attribute) ?? 0;


        #region Event flags

        //Credit to JKAnderson for the event flag reading code, https://github.com/JKAnderson/DS-Gadget

        private static Dictionary<string, int> _eventFlagGroups = new Dictionary<string, int>()
        {
            {"0", 0x00000},
            {"1", 0x00500},
            {"5", 0x05F00},
            {"6", 0x0B900},
            {"7", 0x11300},
        };

        private static Dictionary<string, int> _eventFlagAreas = new Dictionary<string, int>()
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
                int section = int.Parse(idString.Substring(4, 1));
                int number = int.Parse(idString.Substring(5, 3));

                if (_eventFlagGroups.ContainsKey(group) && _eventFlagAreas.ContainsKey(area))
                {
                    int offset = _eventFlagGroups[group];
                    offset += _eventFlagAreas[area] * 0x500;
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
