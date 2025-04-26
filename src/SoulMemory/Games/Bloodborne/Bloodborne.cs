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

using SoulMemory.Memory;
using System;
using System.Diagnostics;
using System.Threading;
using SoulMemory.Native;
using SoulMemory.Abstractions.Games;

namespace SoulMemory.Games.Bloodborne
{
    public class Bloodborne : IBloodborne
    {
        private Process? _process;
        private readonly Pointer _gameDataMan = new();
        private readonly Pointer _sprjEventFlagMan = new();
        private readonly Pointer _worldChrMan = new();
        private readonly Pointer _position = new();

        #region Refresh/init/reset ================================================================================================================================

        public Process? GetProcess() => _process;

        public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "shadPS4", InitPointers, ResetPointers);

        public TreeBuilder GetTreeBuilder()
        {
            var treeBuilder = new TreeBuilder();
            treeBuilder
                .ScanRelative("GameDataMan", "48 8d 05 ? ? ? ? 48 8b 00 03 88 94 00 00 00", 3, 7)
                    .AddPointer(_gameDataMan, 0);

            treeBuilder
                .ScanRelative("SprjEventFlagMan", "4c 8d 35 ? ? ? ? 49 83 3e 00 75 ? 49 8b 3f 48 8b 07 be f8 00 00 00", 3, 7)
                    .AddPointer(_sprjEventFlagMan, 0);

            treeBuilder
                .ScanRelative("WorldChrMan", "48 8d 15 ? ? ? ? 48 8b 12 48 85 d2 74 ? 83 f9 ff 74 ? bf 0e 06 00 00", 3, 7)
                    .AddPointer(_worldChrMan)
                    .AddPointer(_position, 0, 0x60, 0x58);

            return treeBuilder;
        }

        private ResultErr<RefreshError> InitPointers()
        {
            Thread.Sleep(3000);

            try
            {
                var ebootAddress = 0x8ffffc000;
                var getRegionResult = _process!.GetMemoryRegion(ebootAddress);
                if (getRegionResult.IsErr)
                {
                    return Result.Err(new RefreshError(RefreshErrorReason.EbootReadFailed, "Failed to read eboot memory region"));
                }

                var treeBuilder = GetTreeBuilder();
                var result = MemoryScanner.TryResolvePointers(treeBuilder, _process, getRegionResult.Unwrap());
                if (result.IsErr)
                {
                    return result;
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
            _gameDataMan.Clear();
            _sprjEventFlagMan.Clear();
            _worldChrMan.Clear();
            _position.Clear();
        }

        #endregion

        public bool ReadEventFlag(uint eventFlagId)
        {
            var divisor = _sprjEventFlagMan.ReadInt32(0x1c);
            var category = (eventFlagId / divisor); //stored in rax after; div r8d
            var leastSignificantDigits = eventFlagId - (category * divisor);//stored in r11 after; sub r11d,r8d

            var currentElement = _sprjEventFlagMan.CreatePointerFromAddress(0x38); //rdx
            var currentSubElement = currentElement.CreatePointerFromAddress(0x8);   //rcx

            while (currentSubElement.ReadByte(0x19) == '\0') //cmp [rcx+19],r9l -> r9 get's cleared before this instruction and will always be 0
            {
                if (currentSubElement.ReadInt32(0x20) < category)
                {
                    currentSubElement = currentSubElement.CreatePointerFromAddress(0x10);
                }
                else
                {
                    currentElement = currentSubElement;
                    currentSubElement = currentSubElement.CreatePointerFromAddress(0x0);
                }
            }

            if (currentElement.GetAddress() == currentSubElement.GetAddress() || category < currentElement.ReadInt32(0x20))
            {
                currentElement = currentSubElement;
            }

            if (currentElement.GetAddress() != currentSubElement.GetAddress())
            {
                var mysteryValue = currentElement.ReadInt32(0x28) - 1;

                //These if statements can obviously be optimized in C#. 
                //They are written out like this explicitly, to match the game's assembly

                long calculatedPointer = 0;

                //jump to calculate ptr if zero
                if (mysteryValue != 0)
                {
                    //jnz skip to return, otherwise set calculated ptr
                    if (mysteryValue != 1)
                    {
                        calculatedPointer = currentElement.ReadInt64(0x30);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    calculatedPointer = (_sprjEventFlagMan.ReadInt32(0x20) * currentElement.ReadInt32(0x30)) + _sprjEventFlagMan.ReadInt64(0x28);
                }

                if (calculatedPointer != 0)
                {
                    var thing = 7 - (leastSignificantDigits & 7);
                    var anotherThing = 1 << (int)thing;
                    var shifted = leastSignificantDigits >> 3;

                    var pointer = new Pointer();
                    pointer.Initialize(_process!, _sprjEventFlagMan.Is64Bit, calculatedPointer + shifted);
                    var read = pointer.ReadInt32();
                    if ((read & anotherThing) != 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public int ReadInGameTimeMilliseconds()
        {
            return _gameDataMan.ReadInt32(0x94);
        }


        public void WriteInGameTimeMilliseconds(int milliseconds)
        {
            _gameDataMan.WriteInt32(0x94, milliseconds);
        }

        public bool IsLoading()
        {
            return _worldChrMan.ReadInt64(0) == 0;
        }

        public Vector3f GetPlayerPosition()
        {
            return new Vector3f(
                _position.ReadFloat(0x9c),
                _position.ReadFloat(0xbc),
                _position.ReadFloat(0xac)
            );
        }
    }
}
