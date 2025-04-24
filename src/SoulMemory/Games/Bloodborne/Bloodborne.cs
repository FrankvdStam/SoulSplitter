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

        #region Refresh/init/reset ================================================================================================================================

        public Process? GetProcess() => _process;

        public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "shadPS4", InitPointers, ResetPointers);

        public TreeBuilder GetTreeBuilder()
        {
            return new TreeBuilder();
        }

        private ResultErr<RefreshError> InitPointers()
        {
            Thread.Sleep(3000);

            try
            {
                //Get eboot memory region
                var ebootAddress = 0x8ffffc000;
                var getRegionResult = _process!.GetMemoryRegion(ebootAddress);
                if (getRegionResult.IsErr)
                {
                    return Result.Err(new RefreshError(RefreshErrorReason.EbootReadFailed, "Failed to read eboot memory region"));
                }

                //Attempt to read eboot
                var size = (int)getRegionResult.Unwrap().RegionSize;
                var ebootReadResult = _process!.ReadProcessMemory(ebootAddress, size);
                if (ebootReadResult.IsErr)
                {
                    return Result.Err(new RefreshError(RefreshErrorReason.EbootReadFailed, $"Failed to read eboot contents. Region size: {size}"));
                }

                //scan eboot
                var eboot = ebootReadResult.Unwrap();

                {
                    var gameDataManPattern = "48 8d 05 ? ? ? ? 48 8b 00 03 88 94 00 00 00".ToBytePattern();
                    if (!eboot.TryBoyerMooreSearch(gameDataManPattern, out long gameDataManAddress))
                    {
                        return Result.Err(new RefreshError(RefreshErrorReason.ScansFailed, "gameDataMan pattern scan failed"));
                    }

                    var address = BitConverter.ToInt32(eboot, (int)(gameDataManAddress + 3));
                    var result = ebootAddress + gameDataManAddress + address + 7;
                    _gameDataMan.Initialize(_process!, true, result, 0);
                }

                {
                    //set event flag 023d00b0
                    var sprjEventFlagManPattern = "4c 8d 35 ? ? ? ? 49 83 3e 00 75 ? 49 8b 3f 48 8b 07 be f8 00 00 00".ToBytePattern();
                    if (!eboot.TryBoyerMooreSearch(sprjEventFlagManPattern, out long sprjEventFlagManAddress))
                    {
                        return Result.Err(new RefreshError(RefreshErrorReason.ScansFailed, "sprjEventFlagMan pattern scan failed"));
                    }

                    var address = BitConverter.ToInt32(eboot, (int)(sprjEventFlagManAddress + 3));
                    var result = ebootAddress + sprjEventFlagManAddress + address + 7;
                    _sprjEventFlagMan.Initialize(_process!, true, result, 0);
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
    }
}
