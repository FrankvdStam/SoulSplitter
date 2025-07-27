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
using System.Diagnostics;
using SoulMemory.Abstractions.Games;
using SoulMemory.Memory;

namespace SoulMemory.Games.Nightreign
{
    public class Nightreign : INightreign
    {
        private Process? _process;
        private readonly Pointer _igt = new();
        private readonly Pointer _eventFlagMan = new();


        #region Refresh/init/reset ================================================================================================
        public Process? GetProcess() => _process;

        public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "nightreign", InitPointers, ResetPointers);

        public TreeBuilder GetTreeBuilder()
        {
            var treeBuilder = new TreeBuilder();
            treeBuilder
                .ScanRelative("GameDataMan", "48 8b 0d ? ? ? ? 4c 8b 89 ? ? ? ? 4d 85 c9", 3, 7)
                    .AddPointer(_igt, 0, 0xf0);

            treeBuilder
                .ScanRelative("EventFlagMan", "48 8b 35 ? ? ? ? 0f b6 e8 48 85 f6", 3, 7)
                .AddPointer(_eventFlagMan, 0);

            return treeBuilder;
        }

        private ResultErr<RefreshError> InitPointers()
        {
            try
            {
                var treeBuilder = GetTreeBuilder();
                var result = MemoryScanner.TryResolvePointers(treeBuilder, _process);
                if (result.IsErr)
                {
                    _igt.Clear();
                    return result;
                }

                var injectResult = soulmods.Soulmods.Inject(_process!);
                if (injectResult.IsErr)
                {
                    _igt.Clear();
                    return Result.Err(new RefreshError(RefreshErrorReason.ModLoadFailed, "soulmods injection failed"));
                }
                return Result.Ok();
            }
            catch (Exception e)
            {
                if (e.Message == "Access is denied")
                {
                    _process = null;
                    return Result.Err(new RefreshError(RefreshErrorReason.AccessDenied, "Access is denied. Make sure you disable easy anti cheat and try running livesplit as admin."));
                }

                return RefreshError.FromException(e);
            }
        }

        private void ResetPointers()
        {
            _igt.Clear();
        }
        
        #endregion

        public bool ReadEventFlag(uint eventFlagId)
        {
            var divisor = _eventFlagMan.ReadInt32(0x1c);
            //This check does not exist in the games code; reading 0 here means something isn't initialized yet and we should check this flag again later.
            if (divisor == 0)
            {
                return false;
            }

            var category = (eventFlagId / divisor); //stored in rax after; div r8d
            var leastSignificantDigits = eventFlagId - (category * divisor); //stored in r11 after; sub r11d,r8d

            var currentElement = _eventFlagMan.CreatePointerFromAddress(0x38); //rdx
            var currentSubElement = currentElement.CreatePointerFromAddress(0x8); //rcx

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

            if (currentElement.GetAddress() == currentSubElement.GetAddress() ||
                category < currentElement.ReadInt32(0x20))
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
                    calculatedPointer = (_eventFlagMan.ReadInt32(0x20) * currentElement.ReadInt32(0x30)) +
                                        _eventFlagMan.ReadInt64(0x28);
                }

                if (calculatedPointer != 0)
                {
                    var thing = 7 - (leastSignificantDigits & 7);
                    var anotherThing = 1 << (int)thing;
                    var shifted = leastSignificantDigits >> 3;

                    var pointer = new Pointer();
                    pointer.Initialize(_process!, _eventFlagMan.Is64Bit, calculatedPointer + shifted);
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
            return _igt.ReadInt32();
        }
        public void WriteInGameTimeMilliseconds(int milliseconds)
        {
            _igt.WriteInt32(milliseconds);
        }
    }
}
