// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

// This file is part of the LiveSplit.DarkSoulsIGT distribution (https://github.com/CapitaineToinon/LiveSplit.DarkSoulsIGT).
// Copyright (c) 2022 CapitaineToinon.
// https://github.com/CapitaineToinon/LiveSplit.DarkSoulsIGT/blob/master/COPYING
// https://github.com/FrankvdStam/SoulSplitter/blob/main/CapitaineToinon%20-%20COPYING
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using SoulMemory.DarkSouls1.Parameters;
using SoulMemory.Memory;
using SoulMemory.Native;
using Pointer = SoulMemory.Memory.Pointer;

namespace SoulMemory.DarkSouls1
{
    public class Remastered : IDarkSouls1
    {
        public object GetTestValue()
        {
            if (_soloParamMan.IsNullPtr())
            {
                return null;
            }

            var paramResCap = _soloParamMan.CreatePointerFromAddress(0x570);
            var headerStart = paramResCap.CreatePointerFromAddress(0x38);
            
            var parameters = ParamReader.ReadParam<ItemLotParam>(headerStart);
            var bkh2 = parameters.Find(i => i.Id == 27901000);
            bkh2.LotItemBasePoint01 = 0;
            bkh2.LotItemBasePoint01 = 100;
            bkh2.LotItemBasePoint02 = 0;
            bkh2.LotItemBasePoint02 = 100;

            return new object();
        }
        


        #region Refresh/init/reset ================================================================================================================================

        private Process _process;

        private readonly Pointer _gameMan = new Pointer();
        private readonly Pointer _gameDataMan = new Pointer();
        private readonly Pointer _playerIns = new Pointer();
        private readonly Pointer _playerPos = new Pointer();
        private readonly Pointer _playerGameData = new Pointer();
        private readonly Pointer _eventFlags = new Pointer();
        private readonly Pointer _inventoryIndices = new Pointer();
        private readonly Pointer _netBonfireDb = new Pointer();
        private readonly Pointer _menuMan = new Pointer();
        private readonly Pointer _getRegion = new Pointer();
        private readonly Pointer _soloParamMan = new Pointer();
        private int? _steamId3;
        private bool? _isJapanese;

        public Process GetProcess() => _process;

        public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "darksoulsremastered", InitPointers, ResetPointers);

        private void ResetPointers()
        {
            _gameMan.Clear();
            _gameDataMan.Clear();
            _playerIns.Clear();
            _playerPos.Clear();
            _playerGameData.Clear();
            _eventFlags.Clear();
            _inventoryIndices.Clear();
            _netBonfireDb.Clear();
            _menuMan.Clear();
            _getRegion.Clear();
            _soloParamMan.Clear();
            _steamId3 = null;
            _isJapanese = null;
        }

        private ResultErr<RefreshError> InitPointers()
        {
            try 
            {
                var treeBuilder = GetTreeBuilder();
                var result = MemoryScanner.TryResolvePointers(treeBuilder, _process);
                if(result.IsErr)
                {
                    return result;
                }

                _steamId3 = GetSteamId3();
                _isJapanese = IsJapanese();

                return Result.Ok();
            }
            catch (Exception e)
            {
                return RefreshError.FromException(e);
            }
        }

        public TreeBuilder GetTreeBuilder()
        {
            var treeBuilder = new TreeBuilder();
            treeBuilder
                .ScanRelative("GameMan", "48 8b 05 ? ? ? ? c6 40 18 00", 3, 7)
                    .AddPointer(_gameMan, 0)
                    ;

            treeBuilder
                .ScanRelative("GameDataMan", "48 8b 05 ? ? ? ? 48 8b 50 10 48 89 54 24 60", 3, 7)
                    .AddPointer(_gameDataMan, 0)
                    .AddPointer(_playerGameData, 0, 0x10)
                    ;

            treeBuilder
                .ScanRelative("WorldChrManImp", "48 8b 0d ? ? ? ? 0f 28 f1 48 85 c9 74 ? 48 89 7c", 3, 7)
                    .AddPointer(_playerIns, 0, 0x68)
                    .AddPointer(_playerPos, 0, 0x68, 0x68, 0x28)
                    ;

            treeBuilder
                .ScanRelative("EventFlags", "48 8B 0D ? ? ? ? 99 33 C2 45 33 C0 2B C2 8D 50 F6", 3, 7)
                    .AddPointer(_eventFlags, 0, 0)
                    ;

            treeBuilder
                .ScanRelative("InventoryIndices", "48 8D 15 ? ? ? ? C1 E1 10 49 8B C6 41 0B 8F 14 02 00 00 44 8B C6 42 89 0C B2 41 8B D6 49 8B CF", 3, 7)
                    .AddPointer(_inventoryIndices)
                    ;

            treeBuilder
                .ScanRelative("FrpgNetManImp", "48 83 3d ? ? ? ? 00 48 8b f1", 3, 8)
                    .AddPointer(_netBonfireDb, 0x0, 0xb68)
                    ;

            treeBuilder
                .ScanRelative("MenuMan", "48 8b 15 ? ? ? ? 89 82 7c 08 00 00", 3, 7)
                    .AddPointer(_menuMan, 0)
                    ;

            treeBuilder
                .ScanAbsolute("GetRegion", "40 53 48 83 ec 20 bb 02 00 00 00", 0)
                    .AddPointer(_getRegion, 0)
                    ;

            //570 - itemlot
            //1C8 - npcparam
            treeBuilder
                .ScanRelative("SoloParamMan", "4C 8B 05 ? ? ? ? 48 63 C9 48 8D 04 C9", 3, 7)
                    .AddPointer(_soloParamMan, 0)
                    ;

            return treeBuilder;
        }
        #endregion
        
        public int GetAttribute(Attribute attribute) => _playerGameData?.ReadInt32(0x8 + (long)attribute) ?? 0;

        public int GetInGameTimeMilliseconds() => _gameDataMan?.ReadInt32(0xa4) ?? 0;

        public int NgCount() => _gameDataMan?.ReadInt32(0x78) ?? 0;

        public int GetCurrentSaveSlot() => _gameMan?.ReadInt32(0xaa0) ?? 0;

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

        
        public bool AreCreditsRolling()
        {
            if(_menuMan == null)
            {
                return false;
            }

            var first  = _menuMan.ReadInt32(0xc8);
            var second = _menuMan.ReadInt32(0xd4);
            var third  = _menuMan.ReadInt32(0x80); //This address seems like it turns into a 1 only when you are on the main menu

            return third == 0 && first == 1 && second == 1;
        }
        

        public List<Item> GetInventory()
        {
            if (_playerGameData == null)
            {
                return new List<Item>();
            }
            
            //Path: GameDataMan->hostPlayerGameData->equipGameData.equipInventoryData.equipInventoryDataSub
            const long equipInventoryDataSubOffset = 0x3b0;

            var itemCount = _playerGameData.ReadInt32(equipInventoryDataSubOffset + 48);
            var keyCount = _playerGameData.ReadInt32(equipInventoryDataSubOffset + 52);

            //Struct has 2 lists, list 1 seems to be a subset of list 2, the lists start at the same address..
            //I think the first list only contains keys. The "master" list contains both.
            var itemList2Len = _playerGameData.ReadInt32(equipInventoryDataSubOffset);
            var itemList2 = _playerGameData.ReadInt32(equipInventoryDataSubOffset + 40);

            var bytes = _process.ReadProcessMemory(itemList2, itemList2Len * 0x1c).Unwrap();
            var items = ItemReader.GetCurrentInventoryItems(bytes, itemList2Len, itemCount, keyCount);

            return items;
        }

        public BonfireState GetBonfireState(Bonfire bonfire)
        {
            if (_netBonfireDb == null)
            {
                return BonfireState.Unknown;
            }

            var element = _netBonfireDb.CreatePointerFromAddress(0x28);
            element = element.CreatePointerFromAddress(0x0);
            var netBonfireDbItem = element.CreatePointerFromAddress(0x10);

            //For loop purely to have a max amount of iterations
            for (var i = 0; i < 100; i++)
            {
                if (netBonfireDbItem.IsNullPtr())
                {
                    return BonfireState.Unknown;
                }

                var bonfireId = netBonfireDbItem.ReadInt32(0x8);
                if (bonfireId == (int)bonfire)
                { 
                    int bonfireState = netBonfireDbItem.ReadInt32(0xc);
                    return (BonfireState)bonfireState;
                }

                element = element.CreatePointerFromAddress(0x0);
                netBonfireDbItem = element.CreatePointerFromAddress(0x10);
            }
            return BonfireState.Unknown;
        }

        public int GetSaveFileGameTimeMilliseconds(string path, int slot)
        {
            return Sl2Reader.GetSaveFileIgt(path, slot, false) ?? 0;
        }

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

        //Imported from CapitaineToinon. Thanks!

        public void ResetInventoryIndices()
        {
            if (_inventoryIndices != null)
            {
                for (int i = 0; i < 20; i++)
                {
                    _inventoryIndices.WriteUint32(0x4 * i, uint.MaxValue);
                }
            }
        }

        /// <summary>
        /// Returns the savefile's location
        /// </summary>
        /// <returns></returns>
        public string GetSaveFileLocation()
        {
            // values may be null if called before hook, in which
            // case we can't guess the savefile location
            if (_isJapanese == null || _steamId3 == null)
            {
                return null;
            }

            if (_steamId3.Value == 0)
            {
                _steamId3 = GetSteamId3();
            }

            if (_steamId3.Value == 0)
            {
                return string.Empty;
            }
            
            var myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var japan = Path.Combine(myDocuments, "FromSoftware\\DARK SOULS REMASTERED");
            var path = Path.Combine(myDocuments, "NBGI\\DARK SOULS REMASTERED");

            if(_isJapanese.Value)
            {
                path = japan;
            }
            
            path = Path.Combine(path, $"{_steamId3}");
            return Path.Combine(path, "DRAKS0005.sl2");
        }

        /// <summary>
        /// SteamID3 used for savefile location
        /// </summary>
        private int GetSteamId3()
        {
            string name = "steam_api64.dll";
            ProcessModule module = null;

            foreach (ProcessModule item in _process.Modules)
            {
                if (item.ModuleName == name)
                {
                    module = item;
                    break;
                }
            }

            if (module == null)
            {
                throw new DllNotFoundException($"${name} not found");
            }

            return _process.ReadMemory<int>(module.BaseAddress.ToInt64() + 0x38E58).Unwrap();
        }


        private const string IsJapaneseAsm = @"0:  48 83 ec 38             sub    rsp,0x38
4:  49 be fa fa fa fa fa    movabs r14,0xfafafafafafafafa
b:  fa fa fa
e:  41 ff d6                call   r14
11: 49 be fa fa fa fa fa    movabs r14,0xfafafafafafafafa
18: fa fa fa
1b: 41 89 06                mov    DWORD PTR [r14],eax
1e: 48 83 c4 38             add    rsp,0x38
22: c3                      ret";


        private readonly Regex _assemblyRegex = new Regex(@"^[\w\d]+:\s+((?:[\w\d][\w\d] ?)+)");

        /// <summary>
        /// Convert string returned by https://defuse.ca/online-x86-assembler.htm to byte array
        /// Code by https://github.com/JKAnderson
        /// </summary>
        /// <param name="lines">out of https://defuse.ca/online-x86-assembler.htm </param>
        /// <returns>byte code</returns>
        private byte[] LoadDefuseOutput(string lines)
        {
            List<byte> bytes = new List<byte>();
            foreach (string line in Regex.Split(lines, "[\r\n]+"))
            {
                Match match = _assemblyRegex.Match(line);
                string hexes = match.Groups[1].Value;
                foreach (Match hex in Regex.Matches(hexes, @"\S+"))
                    bytes.Add(Byte.Parse(hex.Value, System.Globalization.NumberStyles.AllowHexSpecifier));
            }
            return bytes.ToArray();
        }
        

        /// <summary>
        /// Returns true if the game currently is in Japanese
        /// </summary>
        /// <returns>bool</returns>
        private bool IsJapanese()
        {
            // Calls DarkSoulsRemastered.exe+C8820 (1.03, different address in 1.03.1) and then writes the value of eax
            // to a given address. If that value is 0, the game is in Japanese.
            // That function uses the steam64 api underneath so we have no other
            // choice but calling that function manually

            var getRegionAddress = _getRegion.BaseAddress;
            IntPtr callPtr = (IntPtr)getRegionAddress;
            IntPtr resultPtr = _process.Allocate(0x4);

            // build asm and replace the function pointers
            byte[] asm = LoadDefuseOutput(IsJapaneseAsm);
            byte[] callBytes = BitConverter.GetBytes((ulong)callPtr);
            Array.Copy(callBytes, 0, asm, 0x6, 8);
            byte[] resultBytes = BitConverter.GetBytes((ulong)resultPtr);
            Array.Copy(resultBytes, 0, asm, 0x13, 8);

            _process.Execute(asm);
            var isJapanese = _process.ReadMemory<int>(resultPtr.ToInt64()).Unwrap() == 0;
            _process.Free(resultPtr);
            return isJapanese;
        }
    }
}
