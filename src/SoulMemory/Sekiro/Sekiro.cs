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
using SoulMemory.Memory;
using SoulMemory.Native;

namespace SoulMemory.Sekiro
{
    public class Sekiro : IGame
    {
        private Process _process;
        private readonly Pointer _eventFlagMan = new Pointer();
        private readonly Pointer _fieldArea = new Pointer();
        private readonly Pointer _worldChrManImp = new Pointer();
        private readonly Pointer _igt = new Pointer();
        private readonly Pointer _position = new Pointer();
        private readonly Pointer _fadeSystem = new Pointer();
        private readonly Pointer _saveChecksum = new Pointer();
        private readonly Pointer _saveSteamId = new Pointer();
        private readonly Pointer _saveSlot = new Pointer();
        private readonly Pointer _showTutorialText = new Pointer();
        private readonly Pointer _cSMenuTutorialDialogLoadBuffer = new Pointer();
        private readonly Pointer _noLogo = new Pointer();
        
        #region Refresh/init/reset ================================================================================================================================

        public Process GetProcess() => _process;
        
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
                .ScanAbsolute("NoLogo", "b9 c8 0a 00 00 e8 ? ? ? ? 48 ? ? 48 ? ? ? ? ? ? ? 48 ? ? ? 30 48 ? ? ? ? 48", 0)
                    .AddPointer(_noLogo);
           

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

                _showTutorialText.WriteBytes(21, new byte[]{0x90, 0x90, 0x90, 0x90, 0x90 });
                _showTutorialText.WriteBytes(31, new byte[]{0x90, 0x90, 0x90, 0x90, 0x90 });

                _cSMenuTutorialDialogLoadBuffer.WriteByte(21, 0x75);

                _noLogo.WriteByte(24, 0x75);
                
                //All credit goes to Uberhalit, for finding the byte patterns https://github.com/uberhalit/SimpleSekiroSavegameHelper
                _saveChecksum.WriteBytes(null, new byte[] { 0x90, 0x90 });
                _saveSteamId.WriteByte(null, 0xeb);
                _saveSlot.WriteByte(null, 0xeb);
                
                if (!InitB3Mods())
                {
                    _igt.Clear();
                    return Result.Err(new RefreshError(RefreshErrorReason.UnknownException, "B3Mods init failed"));
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
            BitBlt = false;
        }

        #endregion

        public int GetInGameTimeMilliseconds()
        {
            return _igt?.ReadInt32() ?? 0;
        }

        public void WriteInGameTimeMilliseconds(int value)
        {
            _igt?.WriteInt32(value);
        }


        public bool IsPlayerLoaded()
        {
            return _worldChrManImp.ReadInt64(0x88) != 0;
        }

        public Vector3f GetPlayerPosition()
        {
            return new Vector3f(_position?.ReadFloat(0x80) ?? 0f, _position?.ReadFloat(0x84) ?? 0f, _position?.ReadFloat(0x88) ?? 0f);
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
                for (int i = 0; i < size; i++)
                {
                    var area = vector.ReadByte((i * 0x38) + 0xb);
                    if (area == eventFlagArea)
                    {
                        var count = vector.ReadByte(i * 0x38 + 0x20);
                        var index = 0;
                        var found = false;
                        Pointer worldInfoBlockVector = null;

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
                            flagWorldBlockInfoCategory = worldInfoBlockVector.ReadInt32((index * 0xb0) + 0x20);
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
            resultPointerAddress.Initialize(ptr.Process, ptr.Is64Bit, (eventFlagIdDiv1000 << 4) + ptr.GetAddress() + flagWorldBlockInfoCategory * 0xa8, 0x0);
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
        
        #region Savefile mods

        

        #endregion

        #region BitBlt

        public bool BitBlt
        {
            get
            {
                lock (_bitBltLock)
                {
                    return _bitBlt;
                }
            }
            private set
            {
                lock (_bitBltLock)
                {
                    _bitBlt = value;
                }
            }
        }

        private bool _bitBlt = false;
        private readonly object _bitBltLock = new object();

        private readonly List<string> _files = new List<string>{ "sekiro.exe", "data1.bdt", "data2.bdt", "data3.bdt", "data4.bdt", "data5.bdt" };

        private readonly List<string> _bitBltValues = new List<string>
        {
            "0E 0A 84 07 C7 8E 89 6A 73 D8 F2 7D A3 D4 C0 CC",
            "BE B9 5E E1 B9 87 29 19 4D A3 05 FD EB 63 1A 70",
            "77 59 13 22 FC 7B 93 F8 8C 94 94 95 BC E9 D0 89",
            "8D 88 50 B7 69 62 40 F5 26 EA 90 CA A9 39 93 54",
            "97 31 E0 AB 34 BC 42 C3 F5 EE CF 64 F8 38 7B A9",
            "6C 50 A5 31 44 52 25 9E 12 0C 3D 8B E2 66 3E 0D",
        };

        #endregion

        #region B3LYP's timer & mods
        //All credit goes to B3LYP, https://github.com/pawREP
        /*
            Sekiro Speerunning Plugin by B3
            v1.8

            Features:
                - Fixed timer implementation.
                - Auto start
                - No logo mod.
                - No tutorial mod.
            
            Patches: 
                23/04/19 v1.1 
                 - Compatibility for game version 1.03
                 - fixed timer flickering. (thanks CapitaineToinon)
                 
                
                29/10/20 v1.2
                 - Made IGT work for game version 1.06 (contributed by 56#1363)
                
                
                30/12/20 v1.3
                 - Fixed the addresses for no logo, tutorial skip, and igt fix code location (contributed by RefinedHornet#4765)
                
                
                03/01/21 v1.4 (contributed by RefinedHornet#4765)
                 - Now by default, timer only automatically starts when a new game is started or when the next new game cycle is started
                 - Included a Practice/Testing mode that auto starts similarly to old versions
                 - Introduced a offset value that takes the igt value from timer start and subtracts from current igt value to always start the timer at 0, except for new games
                
                15/01/21 v1.5
                 - Added auto start for guantlets (contributed by RefinedHornet#4765)
                 
                19/01/21 v1.6
                 - Compatibility for game version 1.05 (contributed by RefinedHornet#4765)
                 
                27/02/21 v1.7
                 - Fixed a bug where the script couldn't detect the version between 1.05 and 1.06 if the script was initiated again after the patches were applied (contributed by RefinedHornet#4765)
                 
                06/03/21 v1.8 (contributed by RefinedHornet#4765)
                 - Fixed a bug where files with over 600 hours had countdown style timers
		         - Made the precision of rounding a variable for ease of change, removed casting of Round method return to float to avoid rounding errors

            If you have issues or questions message me (B3LYP#2159)
            on the Sekiro Speedrunning Discord (https://discord.gg/DVXvRPu)

            Technical:
                This plugin modifies the in-game timer of Sekiro to make it run at the correct 
                speed independent of frame rate. The fix as C++ code for reference:

                ''' 
                void updateTimerOriginal(float frame_time){
                    igt += static_cast<unsigned int>(frame_time); 
                }

                void updateTimerNew(float frame_time){
                    static float frac = 0.f;
                    frac += frame_time - static_cast<unsigned int>(frame_time);
                    if(frac >= 1.f){
                        frame_time++;
                        frac--;
                    }
                    igt += static_cast<unsigned int>(frame_time); 
                }
                '''
                    */

        private bool InitB3Mods()
        {
            /*We have to wait a little for SteamDRM to decrypt the exe.
            This could potentially cause issues. Replace with code that
            detects decryption if necessary
            */
            

            string version;

            uint logoCodeBytesPointFive = 0;
            uint logoCodeBytesPointSix = 0;


            switch (_process?.MainModule?.ModuleMemorySize){
                case 67727360:
                    version = "1.02";
                    break;
                case 67731456:
                    version = "1.03";
                    break;
                case 70066176:
                        // if the first 4 bytes at found logo code matches 74 30 48 8D or 75 30 48 8D to account for changes already being applied
                        
                    logoCodeBytesPointFive = _process.ReadMemory<uint>(_process.MainModule.BaseAddress.ToInt64() + 0xE1B1AB).Unwrap();
                    logoCodeBytesPointSix = _process.ReadMemory<uint>(_process.MainModule.BaseAddress.ToInt64() + 0xE1B51B).Unwrap();
                    
                    if(logoCodeBytesPointFive == 0x8D483074 || logoCodeBytesPointFive == 0x8D483075){
                        version = "1.05";
                    }
                    else if(logoCodeBytesPointSix == 0x8D483074 || logoCodeBytesPointSix == 0x8D483075){
                        version = "1.06";
                    }
                    else
                    {
                        return false;
                    }
                    break;
                default:
                    return false;
            }
            

            //timer mod
            long igtFixEntryPoint = 0;
            //cvttss2si rax, xmm0                      <---
            //add     [rcx+9Ch], eax  ; timer_update
            //mov     rax, cs:qword_143B47CF0
            //cmp     dword ptr [rax+9Ch], 0D693A018h
            //jbe     short loc_1407A8D41
            long igtFixCodeLoc = 0; //Start of TutorialMsgDialog constructor. This is dead code after applying the no-tut mod so the timer mod can be injected here
            
            // finding igtFixCodeLoc address
            // TutorialMsgDialog should be located first.
            // go to the address of TutorialMsgDialog
            // right-click on the first call instruction after the TutorialMsgDialog address and select follow
            // the instuction that you are taken to is the address you are looking for
            
            switch(version){
            case "1.02":
                igtFixEntryPoint     = 0x1407A8D19;
                igtFixCodeLoc        = 0x140DBE2D0;
                break;
            case "1.03":
                igtFixEntryPoint     = 0x1407A8D99;
                igtFixCodeLoc        = 0x140DBEC00;
                break;
            case "1.05":
                igtFixEntryPoint     = 0x1407B1C89;
                igtFixCodeLoc        = 0x140DE5B60;
                break;
            case "1.06":
                igtFixEntryPoint     = 0x1407B1C89;
                igtFixCodeLoc        = 0x140DE5ED0;
                break;  
            default:
                throw new NotImplementedException();
            }

            
            //fix detour
            var igtFixDetourCode = new List<byte>(){0xE9};
            int detourTarget = (int) (igtFixCodeLoc-(igtFixEntryPoint+5));
            igtFixDetourCode.AddRange(BitConverter.GetBytes(detourTarget));

            //fix body
            var frac = _process.Allocate(sizeof(double));
            var igtFixCode = new List<byte>(){
                0x53, //push rbx
                0x48, 0xBB //mov rbx, fracAddress
                };
            igtFixCode.AddRange(BitConverter.GetBytes((long)frac));
            igtFixCode.AddRange(new byte[]{
                0x44, 0x0F, 0x10, 0xF0, //movups xmm14, xmm0
                0xF3, 0x45, 0x0F, 0x5A, 0xF6, //cvtss2sd xmm14, xmm14
                0xF2, 0x49, 0x0F, 0x2C, 0xC6, //cvttsd2si rax, xmm14
                0xF2, 0x4C, 0x0F, 0x2A, 0xF8, //cvtsi2sd xmm15, rax
                0xF2, 0x45, 0x0F, 0x5C, 0xF7, //subsd xmm14, xmm15
                0x66, 0x44, 0x0F, 0x10, 0x3B, //movupd xmm15, [rbx]
                0xF2, 0x45, 0x0F, 0x58, 0xFE, //addsd xmm15, xmm14
                0x66, 0x44, 0x0F, 0x11, 0x3B, //movupd [rbx], xmm15
                0xF2, 0x49, 0x0F, 0x2C, 0xC7, //cvttsd2si rax, xmm15
                0x48, 0x85, 0xC0, //test rax, rax
                0x74, 0x1D, //jz +1D
                0x90, 0x90, 0x90, 0x90, //nop
                0xF2, 0x4C, 0x0F, 0x2A, 0xF0, //cvtsi2sd xmm14, rax
                0xF2, 0x45, 0x0F, 0x5C, 0xFE, //subsd xmm15, xmm14
                0x66, 0x44, 0x0F, 0x11, 0x3B, //movupd [rbx], xmm15
                0xF2, 0x45, 0x0F, 0x5A, 0xF6, //cvtsd2ss xmm14, xmm14
                0xF3, 0x41, 0x0F, 0x58, 0xC6, //addss xmm0, xmm14
                0x45, 0x0F, 0x57, 0xF6, //xorps xmm14, xmm14
                0x45, 0x0F, 0x57, 0xFF, //xorps xmm15, xmm15
                0x5B, //pop rbx
                0xF3, 0x48, 0x0F, 0x2C, 0xC0, //cvttss2si rax,xmm0
                0xE9 //jmp return igtFixEntryPoint +5
                });

            int jmpTarget = (int)((igtFixEntryPoint+5)-(igtFixCodeLoc+103+5));
            igtFixCode.AddRange(BitConverter.GetBytes(jmpTarget));


            //Write fixes to game memory
            _process.NtSuspendProcess();

            var result = true;
            //No broken timer
            result &= _process.WriteProcessMemory(igtFixCodeLoc, igtFixCode.ToArray());
            result &= _process.WriteProcessMemory(igtFixEntryPoint, igtFixDetourCode.ToArray());

            _process.NtResumeProcess();
            return result;
        }

        #endregion
    }
}
