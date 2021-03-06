using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Native;
using SoulMemory.Shared;

namespace SoulMemory.Sekiro
{
    public class Sekiro
    {
        private Process _process;

        public  Pointer _sprjEventFlagMan;
        private Pointer _fieldArea;
        private Pointer _worldChrManImp;
        private Pointer _igt;
        private Pointer _position;
        private Pointer _fadeSystem;


        #region Refresh/init/reset ================================================================================================================================
        
        public bool Refresh(out Exception exception)
        {
            exception = null;
            if (!ProcessClinger.Refresh(ref _process, "sekiro", InitPointers, ResetPointers, out Exception e))
            {
                exception = e;
                return false;
            }
            return true;
        }

        private Exception InitPointers()
        {
            Thread.Sleep(3000); //Give sekiro some time to boot

            try
            {
                _process.ScanCache()
                    .ScanRelative("SprjEventFlagMan", "48 8b 0d ? ? ? ? 48 89 5c 24 50 48 89 6c 24 58 48 89 74 24 60", 3, 7)
                        .CreatePointer(out _sprjEventFlagMan, 0)

                    .ScanRelative("FieldArea", "48 8b 0d ? ? ? ? 48 85 c9 74 26 44 8b 41 28 48 8d 54 24 40", 3, 7)
                        .CreatePointer(out _fieldArea, 0)
                    
                    .ScanRelative("WorldChrManImp", "48 8B 35 ? ? ? ? 44 0F 28 18", 3, 7)
                        .CreatePointer(out _worldChrManImp, 0)
                        .CreatePointer(out _position, 0, 0x48, 0x28)

                    .ScanRelative("Igt", "48 8b 05 ? ? ? ? 32 d2 48 8b 48 08 48 85 c9 74 13 80 b9 ba", 3, 7)
                        .CreatePointer(out _igt, 0x0, 0x9c)
                        //.CreatePointer(out _igt, 0x0, 0x70) new game cycle

                    .ScanRelative("SprjFadeManImp", "48 89 35 ? ? ? ? 48 8b c7 48 8b 4d 27 48 33 cc", 3, 7)
                        .CreatePointer(out _fadeSystem, 0x0, 0x8)
                        ;

                if (!InitB3Mods())
                {
                    throw new Exception("B3Mods init failed");
                }

                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private void ResetPointers()
        {
            _sprjEventFlagMan = null;
            _fieldArea = null;
            _worldChrManImp = null;
            _igt = null;
            _position = null;
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
            if (_worldChrManImp == null)
                return false;

            return _worldChrManImp.ReadInt64(0x88) != 0;
        }

        public Vector3f GetPlayerPosition()
        {
            return new Vector3f(_position?.ReadFloat(0x80) ?? 0f, _position?.ReadFloat(0x84) ?? 0f, _position?.ReadFloat(0x88) ?? 0f);
        }

        public bool IsBlackscreenActive()
        {
            if (_fadeSystem == null)
            {
                return false;
            }

            //0x2dc best candidate so far.
            return _fadeSystem.ReadInt32(0x2dc) != 0;
        }

        public bool Attached => _process != null;        

       
        #region Read event flag ================================================================================================================

        public bool ReadEventFlag(uint eventFlagId)
        {
            if (_sprjEventFlagMan == null || _fieldArea == null)
            {
                return false;
            }

            var eventFlagIdDiv10000000 = (int)(eventFlagId / 10000000) % 10;
            var eventFlagArea = (int)(eventFlagId / 100000) % 100;
            var eventFlagIdDiv10000 = (int)(eventFlagId / 10000) % 10;
            var eventFlagIdDiv1000 = (int)(eventFlagId / 1000) % 10;

            //14000002

            //ItemPickup 0x0?
            //Bonfire = 0x11?
            var flagWorldBlockInfoCategory = -1;
            if (!(eventFlagArea < 90) || eventFlagArea + eventFlagIdDiv10000 == 0)
            {
                flagWorldBlockInfoCategory = 0;
            }
            else
            {
                //Not implementing a case where Global_FieldArea_Ptr == (FieldArea *)0x0. I think it will just do some initialization there.
                if (_fieldArea.IsNullPtr())
                {
                    return false;
                }

                var worldInfoOwner = _fieldArea.Append(0x18).CreatePointerFromAddress();

                //Flag stored in world related struct? Looks like the game is reading a size, and then looping over a vector of structs (size 0x38)
                var size = worldInfoOwner.ReadInt32(0x8);
                //var baseAddress = (IntPtr)worldInfoOwner.Append(0x10, 0x38).GetAddress();
                var vector = worldInfoOwner.Append(0x10);

                //Loop over worldInfo structs
                for (int i = 0; i < size; i++)
                {
                    //0x00007ff4fd9ba4c3
                    var offset = (IntPtr)vector.ReadInt64() + i * 0x38;
                    var area = vector.ReadByte((i * 0x38) + 0xb);
                    if (area == eventFlagArea)
                    {
                        //function at 0x14060c650
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

                if (-1 < (int)flagWorldBlockInfoCategory)
                {
                    flagWorldBlockInfoCategory++;
                }
            }

            var testy = (IntPtr)_sprjEventFlagMan.ReadInt64(0x218);

            //7FF49E6D03C0

            //7FF49E6D03E8
            var ptr = _sprjEventFlagMan.Append(0x218, eventFlagIdDiv10000000 * 0x18, 0x0);

            if (ptr.IsNullPtr() || flagWorldBlockInfoCategory < 0)
            {
                return false;
            }

            var resultPointerAddress = new Pointer(ptr.Process, ptr.Is64Bit, (eventFlagIdDiv1000 << 4) + ptr.GetAddress() + flagWorldBlockInfoCategory * 0xa8, 0x0);
            //7FF429823090
            if (!resultPointerAddress.IsNullPtr())
            {
                var value = resultPointerAddress.ReadUInt32((long)((uint)((int)eventFlagId % 1000) >> 5) * 4);
                var mask = 1 << (0x1f - ((byte)((int)eventFlagId % 1000) & 0x1f) & 0x1f);
                var result = value & mask;
                return result != 0;
            }
            return false;
        }

        //((*(uint *)(*in_RAX + (ulonglong)((uint)(param_2 % 1000) >> 5) * 4) >> (0x1f - (param_2 % 1000 & 0x1fU) & 0x1f) & 1) != 0);


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
                        
                    logoCodeBytesPointFive = _process.ReadMemory<uint>(_process.MainModule.BaseAddress + 0xE1B1AB);
                    logoCodeBytesPointSix = _process.ReadMemory<uint>(_process.MainModule.BaseAddress + 0xE1B51B);
                    
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
            
            //TutorialMsgDialog (Tutorial popups that pause the game)
            IntPtr TutorialMsgDialog = (IntPtr)0;
            //CSTutorialDialog (Little noise making tutorial popups that come up on the left)
            IntPtr CSTutorialDialog = (IntPtr)0;
            //CSMenuTutorialDialog (Tutorial messages in the pause and warp menus)
            IntPtr CSMenuTutorialDialog = (IntPtr)0;
            
            // locating message dialog addresses
            // Cheat Engine -> Memory View
            // in the memory view window
            // Tools -> Dissect Code -> select sekiro.exe -> Start
            // wait until the process is complete
            // View -> Referenced strings
            // search for each string for respective dialog
            // TutorialMsgDialog -> "WindowName/Text"
            // CSTutorialDialog -> "LineMessageWindow_%d"
            // CSMenuTutorialDialog -> "MessageTextureWindow"
            // click the address that references the string
            // scroll up until some address and "(Call)" is found
            // click that address(Call) to be taken to the calling address
            // scroll up until a je instruction is found, this is the address you are looking for
            // to confirm, add a breakpoint to the instruction and trigger the dialog in-game. if the instruction is correct, the game should pause only when the dialog is triggered.

            //no logo
            IntPtr noLogo = (IntPtr)0; //no logo mod
                // Cheat Engine -> Memory View
                // in the memory view window -> Search -> find assembly code
                //je *
                //lea rdx,[rsp+30]
                //mov rcx,rbp
                //call *
                //nop
                //mov ebx,00000001
                //mov [rsp+20],ebx
                //movzx r9d,byte ptr [rsi+04]
                //movss xmm2,[rsi]
                //mov rdx,rax
                //mov rcx,rdi
                //call *
                //mov rdi,rax

            //timer mod
            IntPtr igtFixEntryPoint = (IntPtr)0;
                //cvttss2si rax, xmm0                      <---
                //add     [rcx+9Ch], eax  ; timer_update
                //mov     rax, cs:qword_143B47CF0
                //cmp     dword ptr [rax+9Ch], 0D693A018h
                //jbe     short loc_1407A8D41
            IntPtr igtFixCodeLoc = (IntPtr)0; //Start of TutorialMsgDialog constructor. This is dead code after applying the no-tut mod so the timer mod can be injected here
            
            // finding igtFixCodeLoc address
            // TutorialMsgDialog should be located first.
            // go to the address of TutorialMsgDialog
            // right-click on the first call instruction after the TutorialMsgDialog address and select follow
            // the instuction that you are taken to is the address you are looking for
            
            switch(version){
            case "1.02":
                TutorialMsgDialog    = (IntPtr)0x140DC7A8E;
                CSTutorialDialog     = (IntPtr)0x140D6EB98;
                CSMenuTutorialDialog = (IntPtr)0x140D6D51C;
                noLogo               = (IntPtr)0x140DEBF2B;
                igtFixEntryPoint     = (IntPtr)0x1407A8D19;
                igtFixCodeLoc        = (IntPtr)0x140DBE2D0;
                break;
            case "1.03":
                TutorialMsgDialog = (IntPtr)0x140DC83BE;
                CSTutorialDialog = (IntPtr)0x140D6F4C8;
                CSMenuTutorialDialog = (IntPtr)0x140D6DE4C;
                noLogo = (IntPtr)0x140DEC85B;
                igtFixEntryPoint = (IntPtr)0x1407A8D99;
                igtFixCodeLoc = (IntPtr)0x140DBEC00;
                break;
            case "1.05":
                TutorialMsgDialog = (IntPtr)0x140DEF53D;
                CSTutorialDialog = (IntPtr)0x140D94BC8;
                CSMenuTutorialDialog = (IntPtr)0x140D934BC;
                noLogo = (IntPtr)0x140E1B1AB;
                igtFixEntryPoint = (IntPtr)0x1407B1C89;
                igtFixCodeLoc = (IntPtr)0x140DE5B60;
                break;
            case "1.06":
                TutorialMsgDialog = (IntPtr)0x140DEF8AD;
                CSTutorialDialog = (IntPtr)0x140D94F38;
                CSMenuTutorialDialog = (IntPtr)0x140D9382C;
                noLogo = (IntPtr)0x140E1B51B;
                igtFixEntryPoint = (IntPtr)0x1407B1C89;
                igtFixCodeLoc = (IntPtr)0x140DE5ED0;
                break;  
            default:
                throw new NotImplementedException();
                break;
            }

            
            //fix detour
            var igtFixDetourCode = new List<byte>(){0xE9};
            int detourTarget = (int) (igtFixCodeLoc.ToInt64()-(igtFixEntryPoint.ToInt64()+5));
            igtFixDetourCode.AddRange(BitConverter.GetBytes(detourTarget));
            
            //fix body
            var frac = Kernel32.VirtualAllocEx(_process.Handle, IntPtr.Zero, (IntPtr)sizeof(double), Kernel32.MEM_COMMIT, Kernel32.PAGE_EXECUTE_READWRITE);
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

            int jmpTarget = (int)((igtFixEntryPoint.ToInt64()+5)-(igtFixCodeLoc.ToInt64()+103+5));
            igtFixCode.AddRange(BitConverter.GetBytes(jmpTarget));
            

            //Write fixes to game memory
            Ntdll.NtSuspendProcess(_process.Handle);

            //No Tutorials
            var result = true;
            result &= _process.WriteMemory(TutorialMsgDialog,new byte[] {0x75});
            result &= _process.WriteMemory(CSTutorialDialog, new byte[] {0x75});
            result &= _process.WriteMemory(CSMenuTutorialDialog, new byte[] {0x75});

            //No logo 
            result &= _process.WriteMemory(noLogo, new byte[] {0x75});

            //No broken timer
            result &= _process.WriteMemory(igtFixCodeLoc, igtFixCode.ToArray());
            result &= _process.WriteMemory(igtFixEntryPoint, igtFixDetourCode.ToArray()); 
          
            Ntdll.NtResumeProcess(_process.Handle);
            return result;
        }

        #endregion
    }
}
