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

namespace SoulMemory.Games.DarkSouls2;

internal class Vanilla : IDarkSouls2
{
    private Process? _process;
    private readonly Pointer _eventFlagManager = new();
    private readonly Pointer _position = new();
    private readonly Pointer _loadState = new();
    private readonly Pointer _bossCounters = new();
    private readonly Pointer _attributes = new();

    #region Refresh/init/reset ================================================================================================================================
    public Process? GetProcess() => _process;

    public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "darksoulsii", InitPointers, ResetPointers);
    public int ReadInGameTimeMilliseconds() => 0;

    public void WriteInGameTimeMilliseconds(int milliseconds)
    {
    }
    private void ResetPointers()
    {
        _eventFlagManager.Clear();
        _position.Clear();
        _loadState.Clear();
        _bossCounters.Clear();
        _attributes.Clear();
    }

    public TreeBuilder GetTreeBuilder()
    {
        var treeBuilder = new TreeBuilder();
        treeBuilder
            .ScanAbsolute("GameManagerImp", "8B F1 8B 0D ? ? ? 01 8B 01 8B 50 28 FF D2 84 C0 74 0C", 4)
                .AddPointer(_eventFlagManager, 0, 0, 0x44, 0x10)
                .AddPointer(_position, 0, 0, 0x74)
                .AddPointer(_bossCounters, 0, 0, 0x44, 0x14, 0x10, 0x4)
                .AddPointer(_attributes, 0, 0, 0x74, 0x378);
        treeBuilder
            .ScanAbsolute("LoadState", "89 35 ? ? ? ? e8 ? ? ? ? 66 0f ef c0", 2)
                .AddPointer(_loadState, 0, 0);

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

    #endregion
    
    public Vector3f GetPlayerPosition()
    {
        return new Vector3f(
            _position.ReadFloat(0x88),
            _position.ReadFloat(0x80),
            _position.ReadFloat(0x84)
        );
    }

    public int GetBossKillCount(BossType bossType)
    {
        return _bossCounters.ReadInt32((long)bossType);
    }

    public bool IsLoading()
    {
        return _loadState.ReadUInt32(0x1D4) == 1;
    }

    public int GetAttribute(Attribute attribute)
    {
        var offset = _attributeOffsets[attribute];
        if (attribute == Attribute.SoulLevel)
        {
            return _attributes.ReadInt32(offset);
        }
        else
        {
            var bytes = _attributes.ReadBytes(2, offset);
            return BitConverter.ToInt16(bytes, 0);
        }
    }

    public bool ReadEventFlag(uint eventFlagId)
    {
        var eventCategory = eventFlagId / 10000 * 0x89;
        var offset = eventCategory % 0x1f * 4 + 0x10;


        //var uVar1 = ((eventCategory - eventCategory / 0x1f >> 1) + (eventCategory / 0x1f) >> 4) * 31;
        //var r8d = eventCategory - uVar1;
        //
        //var tesy = (IntPtr)_eventFlagManager.ReadInt32();
        //
        //var offset = r8d * 0x4 + 0x10;

        //var address = (IntPtr)_eventFlagManager.GetAddress();
        var vector = _eventFlagManager.CreatePointerFromAddress(offset);

        //ecx 100A9ED0
        //edx 00000011
        //res:10152830


        for (var i = 0; i < 100; i++) //Replaced infinite while with for loop, in case some memes occur and the function never returns
        {
            if (vector.IsNullPtr())
            {
                return false;
                //TODO: fix this. Should be (uVar1 * 0x1f >> 8) << 8
                //;result = uVar1 & 0xffffffffffffff00;
            }

            if (vector.ReadInt32(0x8) == eventFlagId / 10000)
            {
                var category2 = eventFlagId % 10000 >> 3;
                if (category2 < vector.ReadInt32(0x4))
                {
                    var ptr = vector.CreatePointerFromAddress(0x0);
                    var shift = (int)(0x7 - eventFlagId % 10000 & 0x7);
                    var shifted = 0x1 << shift;
                    var flagBit = ptr.ReadByte(category2);
                    return flagBit == shifted;
                }
            }
            vector = vector.CreatePointerFromAddress(0xc);
        }

        return false;
    }


    #region Lookup tables

    private readonly Dictionary<Attribute, long> _attributeOffsets = new()
    {
        { Attribute.SoulLevel   , 0xcc},
        { Attribute.Vigor       , 0x4},
        { Attribute.Endurance   , 0x6},
        { Attribute.Vitality    , 0x8},
        { Attribute.Attunement  , 0xa},
        { Attribute.Strength    , 0xc},
        { Attribute.Dexterity   , 0xe},
        { Attribute.Adaptability, 0x14},
        { Attribute.Intelligence, 0x10},
        { Attribute.Faith       , 0x12}
    };



    #endregion
}
