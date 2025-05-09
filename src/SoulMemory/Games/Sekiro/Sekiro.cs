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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using SoulMemory.Abstractions.Games;
using SoulMemory.Memory;
using SoulMemory.Native;

namespace SoulMemory.Games.Sekiro;

public class Sekiro : ISekiro
{
    private Process? _process;
    private readonly Pointer _eventFlagMan = new();
    private readonly Pointer _fieldArea = new();
    private readonly Pointer _worldChrManImp = new();
    private readonly Pointer _igt = new();
    private readonly Pointer _position = new();
    private readonly Pointer _fadeSystem = new();
    private readonly Pointer _saveChecksum = new();
    private readonly Pointer _saveSteamId = new();
    private readonly Pointer _saveSlot = new();
    private readonly Pointer _showTutorialText = new();
    private readonly Pointer _cSMenuTutorialDialogLoadBuffer = new();
    private readonly Pointer _cSTutorialDialogLoadBuffer = new();
    private readonly Pointer _noLogo = new();
    private readonly Pointer _playerGameData = new();
    
    #region Refresh/init/reset ================================================================================================================================

    public Process? GetProcess() => _process;
    
    public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "sekiro", InitPointers, ResetPointers);

    public TreeBuilder GetTreeBuilder()
    {
        //MenuMan AOB is 48 8b 05 ? ? ? ? 0f b6 d1 48 8b 88 08 33 00 00 3, 7

        var treeBuilder = new TreeBuilder();
        treeBuilder
            .ScanRelative("EventFlagMan", "48 8b 0d ? ? ? ? 48 89 5c 24 50 48 89 6c 24 58 48 89 74 24 60", 3, 7)
                .AddPointer(_eventFlagMan, 0);

        treeBuilder
            .ScanRelative("FieldArea", "48 8b 0d ? ? ? ? 48 85 c9 74 26 44 8b 41 28 48 8d 54 24 40", 3, 7)
                .AddPointer(_fieldArea, 0);

        treeBuilder
            .ScanRelative("WorldChrManImp", "48 8B 35 ? ? ? ? 44 0F 28 18", 3, 7)
                .AddPointer(_worldChrManImp, 0)
                .AddPointer(_position, 0, 0x48, 0x28);

        treeBuilder
            .ScanRelative("Igt", "48 8b 05 ? ? ? ? 32 d2 48 8b 48 08 48 85 c9 74 13 80 b9 ba", 3, 7)
                .AddPointer(_igt, 0x0, 0x9c);
        //.CreatePointer(out _igt, 0x0, 0x70) new game cycle

        treeBuilder
            .ScanRelative("FadeManImp", "48 89 35 ? ? ? ? 48 8b c7 48 8b 4d 27 48 33 cc", 3, 7)
                .AddPointer(_fadeSystem, 0x0, 0x8);

        treeBuilder
            .ScanRelative("PlayerGameData", "48 8b 0d ? ? ? ? 48 8b 41 20 c6 04 02 00", 3, 7)
                .AddPointer(_playerGameData, 0x0, 0x8);

        //These 3 save file related AOB's where found by Uberhalit, thanks for letting me use them!
        //https://github.com/uberhalit/SimpleSekiroSavegameHelper/
        //MIT licensed https://github.com/uberhalit/SimpleSekiroSavegameHelper/blob/master/LICENSE
        treeBuilder
            .ScanAbsolute("Save checksum", "38 84 0C ? ? ? ? ? ? FF ? 48 ? ? 83 ? 10 72", 7)
                .AddPointer(_saveChecksum);

        treeBuilder
            .ScanAbsolute("Save SteamID", "45 84 FF ? ? B9 06 00 00 00 EB ? B9 07 00 00 00", 3)
                .AddPointer(_saveSteamId);

        treeBuilder
            .ScanAbsolute("Save slot", "48 8B 05 ? ? ? ? 40 38 B8 ? ? ? ? ? ? E8 ? ? ? ? E8 ? ? ? ? B8 06 00 00 00", 14)
                .AddPointer(_saveSlot);

        //Replacement of b3's mods to hide tutorials
        treeBuilder
            .ScanAbsolute("ShowTutorialText", "8b ? ? 89 ? ? ? 44 ? ? ? 44 ? ? ? 8b ? 48 ? ? ? ? ? ? ? ? 90 48 ? ? ? ? ? ? ? ? 90", 0)
                .AddPointer(_showTutorialText);

        treeBuilder
            .ScanAbsolute("CSMenuTutorialDialogLoadBuffer", "b9 50 0c ? ? e8 ? ? ? ? 48 ? ? ? ? ? ? ? 48 ? ? ? ? 4c", 0)
                .AddPointer(_cSMenuTutorialDialogLoadBuffer);

        treeBuilder 
            .ScanAbsolute("CSTutorialDialogLoadBuffer", "b9 ? 0e 00 00 e8 ? ? ? ? 48 8b e8 48 89 84 24 c8 00 00 00 48 85 c0 ? ?", 0)
            .AddPointer(_cSTutorialDialogLoadBuffer);

        

        treeBuilder
            .ScanAbsolute("NoLogo", "b9 c8 0a 00 00 e8 ? ? ? ? 48 ? ? 48 ? ? ? ? ? ? ? 48 ? ? ? 30 48 ? ? ? ? 48", 0)
                .AddPointer(_noLogo);

        //treeBuilder
        //    .ScanAbsolute("igt", "f3 48 0f 2c c0 01 81 9c 00 00 00 48 8b 05 ? ? ? ? 81 b8 9c 00 00 00 18 a0 93 d6 76 ? c7 80 9c 00 00 00 18 a0 93 d6", 0)
        //    .AddPointer(_noLogo);
        

        //

        return treeBuilder;
    }

    private ResultErr<RefreshError> InitPointers()
    {
        Thread.Sleep(3000); //Give sekiro some time to boot

        try
        {
            var treeBuilder = GetTreeBuilder();
            var result = MemoryScanner.TryResolvePointers(treeBuilder, _process);
            if (result.IsErr)
            {
                return result;
            }

            _showTutorialText.WriteBytes(21, [0x90, 0x90, 0x90, 0x90, 0x90]);
            _showTutorialText.WriteBytes(31, [0x90, 0x90, 0x90, 0x90, 0x90]);

            _cSMenuTutorialDialogLoadBuffer.WriteByte(21, 0x75);
            _cSTutorialDialogLoadBuffer.WriteByte(24, 0x75);

            _noLogo.WriteByte(24, 0x75);
            
            //All credit goes to Uberhalit, for finding the byte patterns https://github.com/uberhalit/SimpleSekiroSavegameHelper
            _saveChecksum.WriteBytes(null, [0x90, 0x90]);
            _saveSteamId.WriteByte(null, 0xeb);
            _saveSlot.WriteByte(null, 0xeb);
            
            var soulmodsInjectResult = soulmods.Soulmods.Inject(_process!);
            if (soulmodsInjectResult.IsErr)
            {
                _igt.Clear();
                return Result.Err(new RefreshError(RefreshErrorReason.UnknownException, "Soulmods injection failed"));
            }
            
            return Result.Ok();
        }
        catch (Exception e)
        {
            return RefreshError.FromException(e);
        }
    }
    
    
    private void ResetPointers()
    {
        _eventFlagMan.Clear();
        _fieldArea.Clear();
        _worldChrManImp.Clear();
        _igt.Clear();
        _position.Clear();
        _fadeSystem.Clear();
        _saveChecksum.Clear();
        _saveSteamId.Clear();
        _saveSlot.Clear();
        _showTutorialText.Clear();
        _cSMenuTutorialDialogLoadBuffer.Clear();
        _noLogo.Clear();
        _playerGameData.Clear();
    }

    #endregion

    public int ReadInGameTimeMilliseconds()
    {
        return _igt.ReadInt32();
    }

    public void WriteInGameTimeMilliseconds(int value)
    {
        _igt.WriteInt32(value);
    }

    public int ReadAttribute(Enum attribute)
    {
        return attribute switch
        {
            Attribute.Vitality => _playerGameData.ReadInt32(0x44) + 9,
            Attribute.AttackPower => _playerGameData.ReadInt32(0x48),
            _ => throw new ArgumentException($"{attribute} not supported")
        };
    }

    public bool IsPlayerLoaded()
    {
        return _worldChrManImp.ReadInt64(0x88) != 0;
    }

    public bool IsLoading() => !IsPlayerLoaded();

    public Vector3f GetPlayerPosition()
    {
        return new Vector3f(_position.ReadFloat(0x80), _position.ReadFloat(0x84), _position.ReadFloat(0x88));
    }

    public bool IsBlackscreenActive()
    {
        //0x2dc best candidate so far.
        return _fadeSystem.ReadInt32(0x2dc) != 0;
    }
    
    #region event flags ================================================================================================================

    public void WriteEventFlag(uint eventFlagId, bool eventFlagValue)
    {
        var resultAddress = GetEventFlagAddress(eventFlagId);
        if (resultAddress.IsOk)
        {
            var pointer = resultAddress.Unwrap();

            var valueOffset = (long)((uint)((int)eventFlagId % 1000) >> 5) * 4;
            var value = pointer.ReadUInt32(valueOffset);
            var mask = 1 << (0x1f - ((byte)((int)eventFlagId % 1000) & 0x1f) & 0x1f);

            var newValue = value;
            if (eventFlagValue)
            {
                newValue |= (uint)mask;
            }
            else
            {
                newValue &= ~(uint)mask;
            }
            pointer.WriteUint32(valueOffset, newValue);
        }
    }

    public bool ReadEventFlag(uint eventFlagId)
    {
        var resultAddress = GetEventFlagAddress(eventFlagId);
        if (resultAddress.IsOk)
        {
            var pointer = resultAddress.Unwrap();
            var value = pointer.ReadUInt32((long)((uint)((int)eventFlagId % 1000) >> 5) * 4);
            var mask = 1 << (0x1f - ((byte)((int)eventFlagId % 1000) & 0x1f) & 0x1f);
            var result = value & mask;
            return result != 0;
        }
        return false;
    }

    private ResultOk<Pointer> GetEventFlagAddress(uint eventFlagId)
    {
        var eventFlagIdDiv10000000 = (int)(eventFlagId / 10000000) % 10;
        var eventFlagArea = (int)(eventFlagId / 100000) % 100;
        var eventFlagIdDiv10000 = (int)(eventFlagId / 10000) % 10;
        var eventFlagIdDiv1000 = (int)(eventFlagId / 1000) % 10;

        var flagWorldBlockInfoCategory = -1;
        if (eventFlagArea >= 90 || eventFlagArea + eventFlagIdDiv10000 == 0)
        {
            flagWorldBlockInfoCategory = 0;
        }
        else
        {
            var worldInfoOwner = _fieldArea.Append(0x18).CreatePointerFromAddress();

            //Flag stored in world related struct? Looks like the game is reading a size, and then looping over a vector of structs (size 0x38)
            var size = worldInfoOwner.ReadInt32(0x8);
            var vector = worldInfoOwner.Append(0x10);

            //Loop over worldInfo structs
            for (var i = 0; i < size; i++)
            {
                var area = vector.ReadByte((i * 0x38) + 0xb);
                if (area == eventFlagArea)
                {
                    var count = vector.ReadByte(i * 0x38 + 0x20);
                    var index = 0;
                    var found = false;
                    Pointer? worldInfoBlockVector = null;

                    if (count >= 1)
                    {
                        //Loop over worldBlockInfo structs, size 0xe
                        while (true)
                        {
                            worldInfoBlockVector = vector.CreatePointerFromAddress(i * 0x38 + 0x28);
                            var flag = worldInfoBlockVector.ReadInt32((index * 0xb0) + 0x8);

                            if ((flag >> 0x10 & 0xff) == eventFlagIdDiv10000 && flag >> 0x18 == eventFlagArea)
                            {
                                found = true;
                                break;
                            }

                            index++;
                            if (count <= index)
                            {
                                found = false;
                                break;
                            }
                        }
                    }

                    if (found)
                    {
                        flagWorldBlockInfoCategory = worldInfoBlockVector!.ReadInt32((index * 0xb0) + 0x20);
                        break;
                    }
                }
            }

            if (-1 < flagWorldBlockInfoCategory)
            {
                flagWorldBlockInfoCategory++;
            }
        }

        var ptr = _eventFlagMan.Append(0x218, eventFlagIdDiv10000000 * 0x18, 0x0);

        if (ptr.IsNullPtr() || flagWorldBlockInfoCategory < 0)
        {
            return Result.Err();
        }

        //Whats with this name... -_-
        var resultPointerAddress = new Pointer();
        resultPointerAddress.Initialize(ptr.Process!, ptr.Is64Bit, (eventFlagIdDiv1000 << 4) + ptr.GetAddress() + flagWorldBlockInfoCategory * 0xa8, 0x0);
        if (resultPointerAddress.IsNullPtr())
        {
            return Result.Err();
        }
        return Result.Ok(resultPointerAddress);
    }

    //Ghidra, sekiro 1.06, at 1406c63f0, sekiro.exe + 0x6c63f0
    //
    //
    //longlong GetEventFlag(longlong param_1, int param_2, byte param_3)
    //{
    //    longlong lVar1;
    //    int iVar2;
    //    ulonglong uVar3;
    //    uint uVar4;
    //    ulonglong uVar5;
    //    uint local_res8[2];
    //
    //    if ((*(char*)(param_1 + 0x228) == '\0') || (param_2 < 0))
    //    {
    //        return 0;
    //    }
    //    uVar5 = (ulonglong)(uint)((param_2 / 10000000) % 10);
    //    uVar4 = (param_2 / 1000) % 10;
    //    uVar3 = FUN_1406c6090(param_1, (param_2 / 100000) % 100, (param_2 / 10000) % 10, (ulonglong)param_3);
    //    iVar2 = (int)uVar3;
    //    if (param_3 == 0)
    //    {
    //        if (Global_FieldArea_Ptr != 0)
    //        {
    //            FUN_1406c40c0(*(longlong*)(Global_FieldArea_Ptr + 0x18), local_res8,
    //                *(int*)(Global_FieldArea_Ptr + 0x28));
    //            FUN_140c4fcf0(local_res8[0] >> 0x18);
    //        }
    //        lVar1 = *(longlong*)(*(longlong*)(param_1 + 0x218) + uVar5 * 0x18);
    //        if ((lVar1 != 0) && (-1 < iVar2))
    //        {
    //            return (longlong)iVar2 * 0xa8 + lVar1 + (ulonglong)uVar4 * 0x10;
    //        }
    //    }
    //    else
    //    {
    //        lVar1 = *(longlong*)(*(longlong*)(param_1 + 0x218) + uVar5 * 0x18);
    //        if ((lVar1 != 0) && (-1 < iVar2))
    //        {
    //            return (ulonglong)uVar4 * 0x10 + (longlong)iVar2 * 0xa8 + lVar1;
    //        }
    //    }
    //    return 0;
    //}

    #endregion
    
}
