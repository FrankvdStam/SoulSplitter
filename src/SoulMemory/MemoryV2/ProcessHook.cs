﻿// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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
using System.Linq;
using System.Xml.Linq;
using SoulMemory.Memory;
using SoulMemory.MemoryV2.Memory;
using SoulMemory.Native;
using IMemory = SoulMemory.MemoryV2.Memory.IMemory;
using MemoryExtensions = SoulMemory.MemoryV2.Memory.MemoryExtensions;
using Pointer = SoulMemory.MemoryV2.Memory.Pointer;

namespace SoulMemory.MemoryV2
{
    public class ArmoredCore6 : IGame
    {
        private readonly IProcessHook _armoredCore6;

        public ArmoredCore6() : this(null) { }

        public ArmoredCore6(IProcessHook processHook = null)
        {
            _armoredCore6 = processHook ?? new ProcessHook("armoredcore6");
            
            _eventFlagMan = new Pointer(_armoredCore6);
            _noLogo = new Pointer(_armoredCore6);
            _fd4Time = new Pointer(_armoredCore6);
            _menuMan = new Pointer(_armoredCore6);

            _armoredCore6.PointerTreeBuilder
                .ScanRelative("CSEventFlagMan", "48 8b 35 20 4a df 03 83 f8 ff 0f 44 c1", 3, 7)
                    .AddPointer(_eventFlagMan, 0, 0);

            _armoredCore6.PointerTreeBuilder
                .ScanAbsolute("NoLogo", "33 f6 89 75 97 40 38 75 77 ? ? 48 89 31", 9)
                    .AddPointer(_noLogo);

            _armoredCore6.PointerTreeBuilder
                .ScanRelative("FD4Time", "48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d", 3, 7)
                    .AddPointer(_fd4Time, 0, 0);

            _armoredCore6.PointerTreeBuilder
                .ScanRelative("CSMenuMan", "48 8b 35 ? ? ? ? 33 db 89 5c 24 20", 3, 7)
                    .AddPointer(_menuMan, 0, 0);
        }

        private readonly Pointer _eventFlagMan;
        private readonly Pointer _noLogo;
        private readonly Pointer _fd4Time;
        private readonly Pointer _menuMan;

        public int GetInGameTimeMilliseconds() => _fd4Time.ReadInt32(0x114);

        public bool IsLoadingScreenVisible()
        {
            var value = _menuMan.ReadInt32(0x8e4);
            return value != 0;
        }

        public ResultErr<RefreshError> TryRefresh() => _armoredCore6.TryRefresh();

        public SoulMemory.Memory.TreeBuilder GetTreeBuilder()
        {
            throw new NotImplementedException();
        }
        
        public Process GetProcess() => _armoredCore6.GetProcess();

        #region Read event flag ==================================================================================================================

        public void WriteEventFlag(uint eventFlagId, bool value)
        {
            var result = GetEventFlagAddress(eventFlagId, out int mask);
            if (result.IsOk)
            {
                var address = result.Unwrap();
                var read = MemoryExtensions.ReadInt32(_armoredCore6, address);
                var write = read;
                if (value)
                {
                    write |= mask;
                }
                else
                {
                    write &= ~mask;
                }
                MemoryExtensions.WriteInt32(_armoredCore6, address, write);
            }
        }
        
        public bool ReadEventFlag(uint eventFlagId)
        {
            var result = GetEventFlagAddress(eventFlagId, out int mask);
            if (result.IsOk)
            {
                var address = result.Unwrap();
                var read = MemoryExtensions.ReadInt32(_armoredCore6, address);
                return (read & mask) != 0;
            }
        
            return false;
        }
        
        private ResultOk<long> GetEventFlagAddress(uint eventFlagId, out int mask)
        {
            mask = 0;
        
            var divisor = _eventFlagMan.ReadInt32(0x1c);
            //This check does not exist in the games code; reading 0 here means something isn't initialized yet and we should check this flag again later.
            if (divisor == 0)
            {
                return Result.Err();
            }
        
            var category = (eventFlagId / divisor); //stored in rax after; div r8d
            var leastSignificantDigits = eventFlagId - (category * divisor); //stored in r11 after; sub r11d,r8d
        
            var currentElement = _eventFlagMan.Pointer64(0x38); //rdx
            var currentSubElement = currentElement.Pointer64(0x8); //rcx
        
            while (currentSubElement.ReadByte(0x19) == '\0') //cmp [rcx+19],r9l -> r9 get's cleared before this instruction and will always be 0
            {
                if (currentSubElement.ReadInt32(0x20) < category)
                {
                    currentSubElement = currentSubElement.Pointer64(0x10);
                }
                else
                {
                    currentElement = currentSubElement;
                    currentSubElement = currentSubElement.Pointer64(0x0);
                }
            }

            if (currentElement.ResolveOffsets() == currentSubElement.ResolveOffsets() || category < currentElement.ReadInt32(0x20))
            {
                currentElement = currentSubElement;
            }
        
            if (currentElement.ResolveOffsets() != currentSubElement.ResolveOffsets())
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
                    calculatedPointer = (_eventFlagMan.ReadInt32(0x20) * currentElement.ReadInt32(0x30)) +
                                        _eventFlagMan.ReadInt64(0x28);
                }
        
                if (calculatedPointer != 0)
                {
                    var thing = 7 - (leastSignificantDigits & 7);
                    mask = 1 << (int)thing;
                    var shifted = leastSignificantDigits >> 3;
                    return Result.Ok(calculatedPointer + shifted);
                }
            }
        
            return Result.Err();
        }
        
        #endregion
    }
    
    public interface IProcessHook : IMemory
    {
        /// <summary>
        /// Get access to the underlying process
        /// </summary>
        Process GetProcess();

        /// <summary>
        /// Call this often to refresh memory
        /// </summary>
        ResultErr<RefreshError> TryRefresh();

        /// <summary>
        /// Called during refresh, after a process is found, hooked and pointer scans succeed.
        /// Custom one-time initialization after hooking should live here
        /// </summary>
        event Func<ResultErr<RefreshError>> Hooked;

        /// <summary>
        /// Called during refresh after a process exits or if hooking/refreshing fails.
        /// Exception might be null.
        /// </summary>
        event Action<Exception> Exited;

        PointerTreeBuilder.PointerTreeBuilder PointerTreeBuilder { get; set; }
    }


    public class ProcessHook : IProcessHook
    {
        public ProcessHook(string name)
        {
            _name = name;
        }

        private readonly string _name;

        public Process GetProcess() => ProcessWrapper.GetProcess();

        public event Func<ResultErr<RefreshError>> Hooked;
        public event Action<Exception> Exited;


        public IProcessWrapper ProcessWrapper = new ProcessWrapper();
        public PointerTreeBuilder.PointerTreeBuilder PointerTreeBuilder { get; set; } = new PointerTreeBuilder.PointerTreeBuilder();

        #region Refresh =================================================================================================================================================
        
        /// <summary>
        /// Refresh attachment to a process
        /// </summary>
        /// <returns></returns>
        public ResultErr<RefreshError> TryRefresh()
        {
            var processRefreshResult = ProcessWrapper.TryRefresh(_name, out Exception e);
            switch (processRefreshResult)
            {
                case ProcessRefreshResult.ProcessNotRunning:
                    return Result.Err(new RefreshError(RefreshErrorReason.ProcessNotRunning, $"Process {_name} not running or inaccessible. Try running livesplit as admin."));


                //Run scans when process is initialized
                case ProcessRefreshResult.Initialized:
                    var mainModule = ProcessWrapper.GetMainModule();
                    if (mainModule == null)
                    {
                        return Result.Err(new RefreshError(RefreshErrorReason.ScansFailed, "Main module is null. Try running as admin."));
                    }

                    var baseAddress = mainModule.BaseAddress.ToInt64();
                    var memorySize = mainModule.ModuleMemorySize;
                    var is64Bit = ProcessWrapper.Is64Bit();

                    var pointerScanResult = PointerTreeBuilder.TryResolvePointers(this, baseAddress, memorySize, is64Bit);
                    if (pointerScanResult.IsErr)
                    {
                        return pointerScanResult;
                    }
                    return Hooked?.Invoke() ?? Result.Ok();


                //Standard refresh
                case ProcessRefreshResult.Refreshed:
                    return Result.Ok();


                case ProcessRefreshResult.Exited:
                    Exited?.Invoke(null);
                    return Result.Err(new RefreshError(RefreshErrorReason.ProcessExited));

                case ProcessRefreshResult.Error:
                    Exited?.Invoke(e);
                    if (e.Message == "Access is denied")
                    {
                        return Result.Err(new RefreshError(RefreshErrorReason.AccessDenied, "Access is denied. Make sure you disable easy anti cheat and try running livesplit as admin."));
                    }
                    return RefreshError.FromException(e);
                    
                default:
                    throw new NotImplementedException($"{processRefreshResult}");
            }
        }

        #endregion

        #region IMemory

        public byte[] ReadBytes(long offset, int length) => ProcessWrapper.ReadBytes(offset, length);
        public void WriteBytes(long offset, byte[] bytes) => ProcessWrapper.WriteBytes(offset, bytes);

        #endregion
        
    }
}
