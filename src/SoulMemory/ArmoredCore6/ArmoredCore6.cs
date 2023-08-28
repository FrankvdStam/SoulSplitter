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
using System.Management;

namespace SoulMemory.ArmoredCore6
{
    public class ArmoredCore6 : IGame
    {
        private Process _process = null;
        private readonly Pointer _csEventFlagMan = new Pointer();
        private readonly Pointer _noLogo = new Pointer();
        private readonly Pointer _incrementIgt = new Pointer();
        private readonly Pointer _fd4Time = new Pointer();

        public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "armoredcore6", InitPointers, ResetPointers);


        public TreeBuilder GetTreeBuilder()
        {
            var treeBuilder = new TreeBuilder();
            treeBuilder
                .ScanRelative("CSEventFlagMan", "48 8b 35 20 4a df 03 83 f8 ff 0f 44 c1", 3, 7)
                    .AddPointer(_csEventFlagMan, 0)
                    .AddPointer(_noLogo, 0);
            treeBuilder
                .ScanAbsolute("NoLogo", "33 f6 89 75 97 40 38 75 77 ? ? 48 89 31", 9)
                    .AddPointer(_noLogo);
            
            treeBuilder
                .ScanRelative("FD4Time", "48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d", 3, 7)
                    .AddPointer(_fd4Time, 0);

            

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
                    return result;
                }

                _noLogo.WriteBytes(null, new byte[]{0x90, 0x90});
                return InjectMods();
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

        private ResultErr<RefreshError> InjectMods()
        {
            Exception exception = null;
            try
            {
                soulsmods.Soulsmods.Inject(_process);
            }
            catch(Exception e) { exception = e; } 
            
            foreach(ProcessModule module in _process.Modules)
            {
                if (module.ModuleName == "soulsmods.dll")
                {
                    return Result.Ok();
                }
            }

            if (exception != null)
            {
                return Result.Err(new RefreshError(RefreshErrorReason.ModLoadFailed, exception));
            }

            return Result.Err(new RefreshError(RefreshErrorReason.ModLoadFailed, "module not loaded"));
        }

        private void ResetPointers()
        {
            _csEventFlagMan.Clear();
            _noLogo.Clear();
        }

        public Process GetProcess() => _process;

        public int GetInGameTimeMilliseconds() => _fd4Time.ReadInt32(0x114);

        #region Read event flag

        public void WriteEventFlag(uint eventFlagId, bool value)
        {
            var result = GetEventFlagAddress(eventFlagId, out int mask);
            if (result.IsOk)
            {
                var pointer = result.Unwrap();
                var read = pointer.ReadInt32();
                var write = read;
                if (value)
                {
                    write |= mask;
                }
                else
                {
                    write &= ~mask;
                }
                pointer.WriteInt32(write);
            }
        }

        public bool ReadEventFlag(uint eventFlagId)
        {
            var result = GetEventFlagAddress(eventFlagId, out int mask);
            if (result.IsOk)
            {
                var pointer = result.Unwrap();
                var read = pointer.ReadInt32();
                return (read & mask) != 0;
            }

            return false;
        }

        public ResultOk<Pointer> GetEventFlagAddress(uint eventFlagId, out int mask)
        {
            mask = 0;

            var divisor = _csEventFlagMan.ReadInt32(0x1c);
            //This check does not exist in the games code; reading 0 here means something isn't initialized yet and we should check this flag again later.
            if (divisor == 0)
            {
                return Result.Err();
            }

            var category = (eventFlagId / divisor); //stored in rax after; div r8d
            var leastSignificantDigits = eventFlagId - (category * divisor); //stored in r11 after; sub r11d,r8d

            var currentElement = _csEventFlagMan.CreatePointerFromAddress(0x38); //rdx
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
                        return Result.Err();
                    }
                }
                else
                {
                    calculatedPointer = (_csEventFlagMan.ReadInt32(0x20) * currentElement.ReadInt32(0x30)) +
                                        _csEventFlagMan.ReadInt64(0x28);
                }

                if (calculatedPointer != 0)
                {
                    var thing = 7 - (leastSignificantDigits & 7);
                    mask = 1 << (int)thing;
                    var shifted = leastSignificantDigits >> 3;

                    var pointer = new Pointer();
                    pointer.Initialize(_process, _csEventFlagMan.Is64Bit, calculatedPointer + shifted);
                    return Result.Ok(pointer);
                }
            }

            return Result.Err();
        }

        #endregion
    }
}
