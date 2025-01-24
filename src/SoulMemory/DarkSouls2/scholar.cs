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
using SoulMemory.Memory;

namespace SoulMemory.DarkSouls2;

internal class Scholar : IDarkSouls2
{
    private Process? _process;
    private readonly Pointer _eventFlagManager = new();
    private readonly Pointer _position         = new();
    private readonly Pointer _loadState        = new();
    private readonly Pointer _bossCounters     = new();
    private readonly Pointer _attributes       = new();

    #region Refresh/init/reset ================================================================================================================================
    public Process? GetProcess() => _process;
    public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "darksoulsii", InitPointers, ResetPointers);
    public int GetInGameTimeMilliseconds() => 0;
    public TreeBuilder GetTreeBuilder()
    {
        var treeBuilder = new TreeBuilder();
        treeBuilder
            .ScanRelative("GameManagerImp", "48 8b 35 ? ? ? ? 48 8b e9 48 85 f6", 3, 7)
                .AddPointer(_eventFlagManager, 0, 0x70, 0x20)
                .AddPointer(_position, 0, 0xd0, 0x100)
                .AddPointer(_bossCounters, 0, 0x70, 0x28, 0x20, 0x8)
                .AddPointer(_attributes, 0, 0xd0, 0x490);

        treeBuilder
            .ScanRelative("LoadState", "48 89 05 ? ? ? ? b0 01 48 83 c4 28", 3, 7)
                .AddPointer(_loadState, 0x0);

        //.CreatePointer(out AiManager, 0x28)
        //.CreatePointer(out rightHandWeaponMultiplier, 0xd0, 0x378, 0x28, 0x158)
        //.CreatePointer(out LeftHandWeaponMultiplier, 0xd0, 0x378, 0x28, 0x80)

        return treeBuilder;
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
    
    private void ResetPointers()
    {
        _eventFlagManager.Clear();
        _position.Clear();
        _loadState.Clear();
        _bossCounters.Clear();
        _attributes.Clear();
    }

    #endregion
    
    public Vector3f GetPosition()
    {
        if (_position == null)
        {
            return new Vector3f(0, 0, 0);
        }

        return new Vector3f(
            _position.ReadFloat(0x88),
            _position.ReadFloat(0x80),
            _position.ReadFloat(0x84)
        );
    }

    public int GetBossKillCount(BossType bossType)
    {
        if (_bossCounters == null)
        {
            return 0;
        }
        return _bossCounters.ReadInt32((long)bossType);
    }

    public bool IsLoading()
    {
        if (_loadState == null)
        {
            return false;
        }

        return _loadState.ReadInt32(0x11c) == 1;
    }

    public int GetAttribute(Attribute attribute)
    {
        if (_attributes == null)
        {
            return 0;
        }

        var offset = _attributeOffsets[attribute];
        if (attribute == Attribute.SoulLevel)
        {
            return _attributes.ReadInt32(offset);
        }
        else
        {
            var bytes = _attributes.ReadBytes(2, offset);
            return (int)BitConverter.ToInt16(bytes, 0);
        }
    }

    #region Reading event flags


    public bool ReadEventFlag(uint eventFlagId)
    {
        if (_eventFlagManager == null)
        {
            return false;
        }

        var eventCategory = eventFlagId / 10000 * 0x89;
        var uVar1 = ((eventCategory - eventCategory / 0x1f >> 1) + eventCategory / 0x1f >> 4) * 31;
        var r8d = eventCategory - uVar1;

        var offset = r8d * 0x8 + 0x20;
        var vector = _eventFlagManager.CreatePointerFromAddress(offset);

        for (int i = 0; i < 100; i++) //Replaced infinite while with for loop, in case some memes occur and the function never returns
        {
            if (vector.IsNullPtr())
            {
                return false;
                //TODO: fix this. Should be (uVar1 * 0x1f >> 8) << 8
            }

            if (vector.ReadInt32(0xc) == eventFlagId / 10000)
            {
                var category2 = eventFlagId % 10000 >> 3;
                if (category2 < vector.ReadInt32(0x8))
                {
                    var ptr = vector.CreatePointerFromAddress(0x0);
                    var shift = (int)(0x7 - eventFlagId % 10000 & 0x7);
                    var shifted = 0x1 << shift;
                    var flagBit = ptr.ReadByte(category2);
                    return flagBit == shifted;
                }
            }
            vector = vector.CreatePointerFromAddress(0x10);
        }

        return false;
    }


    //Ghidra, address 7ff6ec6bcfe0
    //Ghidra did not do such a great job. Most of this was reversed straight from the assembly, while stepping through it with a debugger.
    //
    //ulonglong FUN_7ff6ec6bcfe0_maybeReadEventFlag (EventFlagManager *eventFlagManager_ptr,uint eventFlagId)
    //                   
    //
    //{
    //  uint uVar1;
    //  uint eventCategory?;
    //  ulonglong *pointer_to_vector_in_eventflagmanager;
    //  
    //  eventCategory? = (eventFlagId / 10000) * 0x89;
    //  uVar1 = (eventCategory? - eventCategory? / 0x1f >> 1) + eventCategory? / 0x1f >> 4;
    //  pointer_to_vector_in_eventflagmanager =
    //       (ulonglong *)
    //       (&(eventFlagManager_ptr->data).vector_of_pointers_start?)[eventCategory? + uVar1 * -0x1f];    //mov rdx,[rcx+r8*8+20]
    //  do {
    //    if (pointer_to_vector_in_eventflagmanager == (ulonglong *)0x0) {
    //LAB_7ff6ec6bd03f:
    //      return (ulonglong)(uint3)(uVar1 * 0x1f >> 8) << 8;
    //    }
    //    if (*(uint *)((longlong)pointer_to_vector_in_eventflagmanager + 0xc) == eventFlagId / 10000) {
    //      eventCategory? = eventFlagId % 10000 >> 3;
    //      if (eventCategory? < *(uint *)(pointer_to_vector_in_eventflagmanager + 1)) {
    //        return *pointer_to_vector_in_eventflagmanager & 0xffffffffffffff00 |
    //               (ulonglong)
    //               ((*(byte *)((ulonglong)eventCategory? + *pointer_to_vector_in_eventflagmanager) &
    //                (byte)(1 << (7 - ((byte)(eventFlagId % 10000) & 7) & 0x1f))) != 0);
    //      }
    //      goto LAB_7ff6ec6bd03f;
    //    }
    //    pointer_to_vector_in_eventflagmanager = (ulonglong *)pointer_to_vector_in_eventflagmanager[2];
    //  } while( true );
    //}   

    #endregion

    #region Lookup tables

    private readonly Dictionary<Attribute, long> _attributeOffsets = new()
    {
        { Attribute.SoulLevel   , 0xd0},
        { Attribute.Vigor       , 0x8},
        { Attribute.Endurance   , 0xa},
        { Attribute.Vitality    , 0xc},
        { Attribute.Attunement  , 0xe},
        { Attribute.Strength    , 0x10},
        { Attribute.Dexterity   , 0x12},
        { Attribute.Adaptability, 0x18},
        { Attribute.Intelligence, 0x14},
        { Attribute.Faith       , 0x16},
    };

    #endregion
}
