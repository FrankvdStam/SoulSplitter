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
using System.Linq;
using System.Text;
using SoulMemory.DarkSouls1.Parameters;
using SoulMemory.Memory;
using SoulMemory.Native;
using SoulMemory.Parameters;

namespace SoulMemory.DarkSouls1;

public class Ptde : IDarkSouls1
{
    #region Refresh/init/reset ================================================================================================================================

    private Process? _process;

    private readonly Pointer _gameMan = new();
    private readonly Pointer _gameDataMan = new();
    private readonly Pointer _playerIns = new();
    private readonly Pointer _playerGameData = new();
    private readonly Pointer _eventFlags = new();
    private readonly Pointer _inventoryIndices = new();
    private readonly Pointer _netBonfireDb = new();
    private readonly Pointer _saveInfo = new();
    private readonly Pointer _menuMan = new();
    private readonly Pointer _soloParamMan = new();
    private readonly Pointer _msgMan = new();
    private readonly Pointer _loadingScreenItems = new();
    private List<ItemLotParam> _itemLotParams = [];
    private List<TextTableEntry> _weaponDescriptionsTable = [];

    public Process? GetProcess() => _process;

    public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "darksouls", InitPointers, ResetPointers);

    public TreeBuilder GetTreeBuilder() 
    {
        var treeBuilder = new TreeBuilder();
        treeBuilder
            .ScanAbsolute("GameMan", "a1 ? ? ? ? 8b 88 ec 0b 00 00 83 79 10 01 0f 94 c0", 1) // 8b 0d ? ? ? ? 80 b9 41 0b 00 00 00 74 0d
                .AddPointer(_gameMan, 0, 0);

        treeBuilder
            .ScanAbsolute("GameDataMan", "8b 0d ? ? ? ? 8b 41 30 8b 4d 64", 2)
                .AddPointer(_gameDataMan, 0, 0)
                .AddPointer(_playerGameData, 0, 0, 0x8);

        treeBuilder
            .ScanAbsolute("MenuMan", "a1 ? ? ? ? 8b 88 e8 09 00 00 c7 01 80 3e 00 00", 1)
                .AddPointer(_menuMan, 0, 0);

        treeBuilder
            .ScanAbsolute("WorldChrManImp", "8b 0d ? ? ? ? 8b 71 3c c6 44 24 48 01", 2)
            //.CreatePointer(out _worldChrManImp, 0, 0)
                .AddPointer(_playerIns, 0, 0, 0x3c);

        treeBuilder
            .ScanAbsolute("EventFlags", "56 8B F1 8B 46 1C 50 A1 ? ? ? ? 32 C9", 8)
                .AddPointer(_eventFlags, 0, 0, 0);

        treeBuilder
            .ScanAbsolute("InventoryIndices", "8B 4C 24 34 8B 44 24 2C 89 8A 38 01 00 00 8B 90 08 01 00 00 C1 E2 10 0B 90 00 01 00 00 8B C1 8B CD 89 14 AD ? ? ? ?", 36)
                .AddPointer(_inventoryIndices, 0);

        treeBuilder
            .ScanAbsolute("NetManImp", "a1 ? ? ? ? 8b 80 5c 0b 00 00 8b 40 2c 85 c0 0f", 1) //83 3d ? ? ? ? 00 75 4b a1
                .AddPointer(_netBonfireDb, 0, 0, 0xb48);


        treeBuilder
            .ScanAbsolute("SaveInfo", "8b 0d ? ? ? ? 39 35 ? ? ? ? 73 05 b9", 2) //00 00 00 00 66 89 0D ? ? ? ? C3 CC CC CC CC CC 83 3D
                .AddPointer(_saveInfo, 0);

        treeBuilder
            .ScanAbsolute("SoloParamMan", "83 c4 0c 89 35 ? ? ? ? 5e c3 a3", 5)
                .AddPointer(_soloParamMan, 0, 0);

        treeBuilder
            .ScanAbsolute("LoadingScreenItems", "8b 96 10 01 00 00 8b 04 95 ? ? ? ? 8d be 08 01 00 00", 9)
                .AddPointer(_loadingScreenItems, 0);
        

        treeBuilder
            .ScanAbsolute("MsgMan", "c7 44 24 18 ff ff ff ff a3 ? ? ? ? e8 ? ? ? ? 8b 4c 24 10", 9)
                .AddPointer(_msgMan, 0, 0);


        //83 c4 0c 89 35 ? ? ? ? 5e c3 a3

        return treeBuilder;
    }
    
    private void ResetPointers()
    {
        _gameMan.Clear();
        _gameDataMan.Clear();
        _playerIns.Clear();
        _playerGameData.Clear();
        _eventFlags.Clear();
        _inventoryIndices.Clear();
        _netBonfireDb.Clear();
        _menuMan.Clear();
        _saveInfo.Clear();
        _soloParamMan.Clear();
        _msgMan.Clear();
        _loadingScreenItems.Clear();
        _itemLotParams.Clear();
        _weaponDescriptionsTable.Clear();
    }

    private ResultErr<RefreshError> InitPointers()
    {
        try
        {
            var treeBuilder = GetTreeBuilder();
            return MemoryScanner.TryResolvePointers(treeBuilder, _process);
        }
        catch (Exception e)
        {
            return RefreshError.FromException(e);
        }
    }
    
    #endregion
    
    public int GetAttribute(Attribute attribute) => _playerGameData.ReadInt32((long)attribute);

    public int GetInGameTimeMilliseconds() => _gameDataMan.ReadInt32(0x68);

    public int NgCount() => _gameDataMan.ReadInt32(0x3C);

    public int GetCurrentSaveSlot() => _gameMan.ReadInt32(0xA70);

    public Vector3f GetPosition() => new(_playerIns.ReadFloat(0xc50), _playerIns.ReadFloat(0xC58), _playerIns.ReadFloat(0xC54));

    public int GetPlayerHealth() => _playerIns.ReadInt32(0x2d4) ;

    public bool IsPlayerLoaded() => !_playerIns.IsNullPtr();

    public bool IsWarpRequested()
    {
        if (GetPlayerHealth() == 0)
        {
            return false;
        }

        return _gameMan.ReadByte(0x11) == 1;
    }

    

    public List<Item> GetInventory()
    {
        var itemCount = _playerGameData.ReadInt32(0x2e0);
        var keyCount = _playerGameData.ReadInt32(0x2e4);
        
        var listLength = _playerGameData.ReadInt32(0x2c8);
        var listStart = _playerGameData.ReadInt32(0x2cc);
        
        var bytes = _process!.ReadProcessMemory(listStart, listLength * 0x1c).Unwrap();
        return ItemReader.GetCurrentInventoryItems(bytes, listLength, itemCount, keyCount);
    }


    public BonfireState GetBonfireState(Bonfire bonfire)
    {
        var element = _netBonfireDb.CreatePointerFromAddress(0x24);
        element = element.CreatePointerFromAddress(0x0);
        var netBonfireDbItem = element.CreatePointerFromAddress(0x8);

        //For loop purely to have a max amount of iterations
        for (var i = 0; i < 100; i++)
        {
            if (netBonfireDbItem.IsNullPtr())
            {
                return BonfireState.Unknown;
            }

            var bonfireId = netBonfireDbItem.ReadInt32(0x4);
            if (bonfireId == (int)bonfire)
            {
                var bonfireState = netBonfireDbItem.ReadInt32(0x8);
                return (BonfireState)bonfireState;
            }

            element = element.CreatePointerFromAddress(0x0);
            netBonfireDbItem = element.CreatePointerFromAddress(0x8);
        }
        return BonfireState.Unknown;
    }

    public bool AreCreditsRolling()
    {
        var first = _menuMan.ReadInt32(0xb4);
        var second = _menuMan.ReadInt32(0xc0);
        var third = _menuMan.ReadInt32(0x6c); //This address seems like it turns into a 1 only when you are on the main menu

        return third == 0 && first == 1 && second == 1;
    }


    


    public object GetTestValue()
    {
        WriteWeaponDescription(1105000, "asdf");
        return null!;
    }

    public int GetSaveFileGameTimeMilliseconds(string path, int slot)
    {
        return Sl2Reader.GetSaveFileIgt(path, slot, true) ?? 0;
    }


    #region Event flags ================================================================================================================

    //Credit to JKAnderson for the event flag reading code, https://github.com/JKAnderson/DS-Gadget

    private static readonly Dictionary<string, int> EventFlagGroups = new()
    {
        {"0", 0x00000},
        {"1", 0x00500},
        {"5", 0x05F00},
        {"6", 0x0B900},
        {"7", 0x11300}
    };

    private static readonly Dictionary<string, int> EventFlagAreas = new()
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
        {"181", 17}
    };

    private int GetEventFlagOffset(uint eventFlagId, out uint mask)
    {
        var idString = eventFlagId.ToString("D8");
        if (idString.Length == 8)
        {
            var group = idString.Substring(0, 1);
            var area = idString.Substring(1, 3);
            var section = int.Parse(idString.Substring(4, 1));
            var number = int.Parse(idString.Substring(5, 3));

            if (EventFlagGroups.ContainsKey(group) && EventFlagAreas.ContainsKey(area))
            {
                var offset = EventFlagGroups[group];
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
        var offset = GetEventFlagOffset(eventFlagId, out var mask);
        var value = _eventFlags.ReadUInt32(offset);
        return (value & mask) != 0;
    }

    #endregion

    //Imported from CapitaineToinon. Thanks!
    
    public void ResetInventoryIndices()
    {
        for (var i = 0; i < 20; i++)
        {
            _inventoryIndices.WriteUint32(0x4 * i, uint.MaxValue);
        }
    }


    /// <summary>
    /// Returns the savefile's location
    /// </summary>
    /// <returns></returns>
    public string GetSaveFileLocation()
    {
        var myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var path = Path.Combine(myDocuments, "NBGI\\DarkSouls");
        var variable = _saveInfo.ReadInt32(0x10);
    
        if (variable != 0)
        {
            // some old gfwl savefiles are still supported

            var stringBuffer = new List<byte>(128);
            var strPointer = _saveInfo.CreatePointerFromAddress(0x0);
            var bytes = strPointer.ReadBytes(128);

            for (var i = 0; i < 128; i += 2)
            {
                if (bytes[i] == 0 && bytes[i + 1] == 0)
                {
                    break;
                }

                stringBuffer.Add(bytes[i]);
                stringBuffer.Add(bytes[i+1]);
            }

            var glfwId = Encoding.Unicode.GetString(stringBuffer.ToArray());
            path = Path.Combine(path, glfwId);
        }
    
        return Path.Combine(path, "DRAKS0005.sl2");
    }

    public void WriteItemLotParam(int rowId, Action<ItemLotParam> accessor)
    {
        if (!_itemLotParams.Any())
        {
            var paramResCap = _soloParamMan.CreatePointerFromAddress(0x2b8);
            var headerStart = paramResCap.CreatePointerFromAddress(0x20);
            _itemLotParams = ParamReader.ReadParam<ItemLotParam>(headerStart);
        }

        var itemLotParam = _itemLotParams.Find(i => i.Id == rowId);
        accessor(itemLotParam);
    }

    public void WriteWeaponDescription(uint weaponId, string description)
    {
        //weaponName 0x1d0 - 0x30
        //weaponInfo 0x1cc - 0x58
        //weaponCaption 0x1ac - 0x68

        var weaponDescriptionsPointer = _msgMan.CreatePointerFromAddress(0x68);

        if (!_weaponDescriptionsTable.Any())
        {
            _weaponDescriptionsTable = ParamReader.GetTextTables(weaponDescriptionsPointer);
        }

        var weaponDescription = _weaponDescriptionsTable.Find(i => i.ItemHighRange == weaponId);

        var dataPointer = weaponDescriptionsPointer.CreatePointerFromAddress(0x14);
        var textOffset = dataPointer.ReadInt32(weaponDescription.DataOffset * 4);
        weaponDescriptionsPointer.ReadUnicodeString(out var length, offset: textOffset);
        
        var buffer = Encoding.Unicode.GetBytes(description);
        var bytes = new byte[length];
        Array.Copy(buffer, bytes, buffer.Length);
        weaponDescriptionsPointer.WriteBytes(textOffset, bytes);
    }

    public void SetLoadingScreenItem(int index, uint item)
    {
        if (index < 62)
        {
            _loadingScreenItems.WriteUint32(index * 4, item);
        }
    }
}
