using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using Keystone;
using SoulMemory.DarkSouls1.Internal;
using SoulMemory.Memory;
using SoulMemory.Native;
using SoulMemory.Shared;
using Architecture = Keystone.Architecture;

namespace SoulMemory.EldenRing
{
    public class EldenRing : ITimeable
    {
        public Exception Exception;
        
        private Process _process = null;

        private Pointer _igt;
        private Pointer _playerIns;
        private Pointer _playerChrPhysicsModule;
        private Pointer _menuManImp;
        private Pointer _igtFix;
        private Pointer _igtCodeCave;
        private Pointer _readEventFlag;
        private Pointer _virtualMemoryFlag;
        private Pointer _noLogo;

        private long _screenStateOffset;
        private long _blackScreenOffset;
        
        public EldenRing(bool applyIgtFix = true)
        {
            _applyIgtFix = applyIgtFix;
            Refresh();
        }

        private bool _applyIgtFix = true;


        public bool Init()
        {
            try
            {
                if (_process.HasExited)
                {
                    return false;
                }

                //Arrange version specific offsets
                if (!Version.TryParse(_process.MainModule.FileVersionInfo.ProductVersion, out Version v))
                {
                    Exception = new Exception("Failed to determine game version");
                    return false;
                }
                
                var version = GetVersion(v);
                switch (version)
                {
                    default:
                    case EldenRingVersion.Unknown:
                        _screenStateOffset = 0x728;
                        _blackScreenOffset = 0x72c;
                        break;

                    case EldenRingVersion.V102:
                        _screenStateOffset = 0x718;
                        _blackScreenOffset = 0x71c;
                        break;

                    case EldenRingVersion.V103:
                        _screenStateOffset = 0x728;
                        _blackScreenOffset = 0x72c;
                        break;
                }

                var scanCache = _process.ScanCache();
                scanCache
                    //FD4Time
                    .ScanRelative("48 8b 05 ? ? ? ? 4c 8b 40 08 4d 85 c0 74 0d 45 0f b6 80 be 00 00 00 e9 13 00 00 00", 3, 7)
                        .CreatePointer(out _igt, 0, 0xa0)

                    //WorldChrManImp  
                    .ScanRelative("48 8B 05 ? ? ? ? 48 85 C0 74 0F 48 39 88 ? ? ? ? 75 06 89 B1 5C 03 00 00 0F 28 05 ? ? ? ? 4C 8D 45 E7", 3, 7)
                        .CreatePointer(out _playerIns, 0, 0x18468)
                        .CreatePointer(out _playerChrPhysicsModule, 0, 0x18468, 0xF68)

                    //CSMenuManImp
                    .ScanRelative("48 8b 0d ? ? ? ? 48 8b 53 08 48 8b 92 d8 00 00 00 48 83 c4 20 5b", 3, 7)
                        .CreatePointer(out _menuManImp, 0)
                    
                    //.ScanRelative("48 83 3d d5 f2 60 03 00 75 46 4c 8b 05 e4 d4 62 03 4c 89 44 24 40 ba 08 00 00 00 b9 c8 01 00 00", 3, 7)
                    .ScanRelative("48 83 3d ? ? ? ? 00 75 46 4c 8b 05 ? ? ? ? 4c 89 44 24 40 ba 08 00 00 00 b9 c8 01 00 00", 3, 7)
                        .CreatePointer(out _virtualMemoryFlag, 1)

                    //IGT fix detour address
                    .ScanAbsolute("48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0 48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d ? ? ? ?", 35)
                        .CreatePointer(out _igtFix)

                     //IGT code cave
                    .ScanAbsolute("48 8b c4 55 57 41 56 48 8d 68 b8 48 81 ec 30 01 00 00 48 c7 44 24 40 fe ff ff ff 48 89 58 18 48 89 70 20")
                        .CreatePointer(out _igtCodeCave)
                    ;

                try
                {
                    //If nologo is not applied
                    scanCache
                        .ScanAbsolute("74 53 48 8B 05 ?? ?? ?? ?? 48 85 C0 75 2E 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 4C 8B C8")
                        .CreatePointer(out _noLogo);
                }
                catch
                {
                    //If nologo is already applied
                    scanCache
                        .ScanAbsolute("90 90 48 8B 05 ?? ?? ?? ?? 48 85 C0 75 2E 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 4C 8B C8")
                        .CreatePointer(out _noLogo);
                }


                //gameman  48 8b 1d ? ? ? ? 48 8b f8 48 85 db 74 18 4c 8b 03
                //EventFlagUsageParamManagerImp 48 8b 05 . . . . 48 85 c0 75 12 88 . . . . . e8 20 ec ff ff 48 89 05 . . . .

                if (_applyIgtFix && !ApplyIgtFix())
                {
                    Exception = new Exception("MIGT code injection failed");
                    return false;
                }
                
                return true;
            }
            catch (Exception e)
            {
                Exception = e;
                return false;
            }
        }

        public enum EldenRingVersion
        {
            V102,
            V103,
            Unknown,
        };

        public static EldenRingVersion GetVersion(Version v)
        {
            switch (v.Major)
            {
                default:
                    return EldenRingVersion.Unknown;

                case 1:
                    switch (v.Minor)
                    {
                        default:
                            return EldenRingVersion.Unknown;

                        case 2:
                            return EldenRingVersion.V102;
                        case 3:
                            return EldenRingVersion.V103;
                    }
            }
        }


        private void ResetPointers()
        {
            _igt = null;
            _playerIns = null;
            _playerChrPhysicsModule = null;
            _menuManImp = null;
            _igtFix = null;
            _igtCodeCave = null;
            _readEventFlag = null;
            _virtualMemoryFlag = null;
            _noLogo = null;
        }

        public bool IsPlayerLoaded()
        {
            if (_playerIns != null)
            {
                var player = _playerIns.ReadInt64();
                return player != 0;
            }
            return false;
        }

        public Vector3f GetPosition()
        {
            if (_playerChrPhysicsModule != null)
            {
                return new Vector3f(_playerChrPhysicsModule.ReadFloat(0x70), _playerChrPhysicsModule.ReadFloat(0x74), _playerChrPhysicsModule.ReadFloat(0x78));
            }
            return new Vector3f(0, 0, 0);
        }

        public float GetAngle()
        {
            if (_playerChrPhysicsModule != null)
            {
                return _playerChrPhysicsModule.ReadFloat(0x54);
            }
            return 0f;
        }
        
        public ScreenState GetScreenState()
        {
            var screenState = _menuManImp?.ReadInt32(_screenStateOffset) ?? (int)ScreenState.Unknown;
            if (screenState.TryParseEnum(out ScreenState s))
            {
                return s;
            }
            return ScreenState.Unknown;
        }

        private bool NoCutsceneOrBlackscreen()
        {
            var flag = _menuManImp?.ReadInt32(_blackScreenOffset);
            return flag.HasValue && flag.Value == 16;
        }

        private bool _pointersInitialized = false;
        private DateTime _requestInit;
        private readonly TimeSpan _initDelay = TimeSpan.FromSeconds(5);
        public bool Refresh()
        {
            if (_process == null)
            {
                //EAC bypass methods differ. In some, people rename eldenring.exe to start_protected_game.exe
                _process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("eldenring")) ?? Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("start_protected_game"));
                
                if (_process != null && !_process.HasExited)
                {
                    _requestInit = DateTime.Now.Add(_initDelay);
                    return false;
                }

                return false;
            }
            else
            {
                if (!_pointersInitialized && _requestInit < DateTime.Now)
                {
                    if (Init())
                    {
                        _pointersInitialized = true;
                        return true;
                    }
                    else
                    {
                        var pointerScanException = new Exception($"Pattern scan failed, is EAC disabled? {Exception?.Message}", Exception);
                        Exception = pointerScanException;
                    }
                }

                try
                {
                    if (_process.HasExited)
                    {
                        _process = null;
                        _pointersInitialized = false;
                        ResetPointers();
                    }
                }
                catch
                {
                    _process = null;
                    _pointersInitialized = false;
                    ResetPointers();
                }

                if (_pointersInitialized)
                {
                    if (EnableNoLogo != _previousEnableNoLogo)
                    {
                        NoLogo(EnableNoLogo);
                        _previousEnableNoLogo = EnableNoLogo;
                    }
                }

                return _pointersInitialized;
            }
        }

        public int GetTestValue()
        {
            return _menuManImp?.ReadInt32(_blackScreenOffset) ?? 0;
        }

        public bool Attached => _process != null;


        #region Nologo

        private bool _previousEnableNoLogo = false;
        public bool EnableNoLogo = false;
        public void NoLogo(bool apply)
        {
            if (_noLogo == null)
            {
                return;
            }

            if (apply)
            {
                _noLogo.WriteByte(0x0, 0x90);
                _noLogo.WriteByte(0x1, 0x90);
            }
            else
            {
                _noLogo.WriteByte(0x0, 0x74);
                _noLogo.WriteByte(0x1, 0x53);
            }
        }
        

        #endregion

        #region Read event flag

        private IntPtr _virtualMemoryFlagLogAddress;

        public void InitEventFlagDetour()
        {
            //Overwrite code cave used by igt with a SetEventFlag detour

            //7ff68671b040 set event
            //7ff686ab8af0 code cave


            _process.ScanCache()
                .ScanAbsolute("48 89 5c 24 08 44 8b 49 1c 44 8b d2 33 d2 41 8b c2 41 f7 f1 41 8b d8 4c 8b d9")
                .CreatePointer(out Pointer p);

            


            long codeCave = _igtCodeCave.GetAddress();
            long setEventFlag = p.GetAddress();

            var readBuffer = new byte[1];
            int readBytes = 0;
            Kernel32.ReadProcessMemory(_process.Handle, (IntPtr)setEventFlag, readBuffer, readBuffer.Length, ref readBytes);
            if (readBuffer[0] == 0xE9)
            {
                return; //code already injected. Return.
            }

            //params
            //1   CSFD4VirtualMemoryFlag* virtualMemoryFlag   RCX: 8
            //2   uint flagId  EDX: 4
            //3   int param_3 R8D: 4


            //0:  53                      push rbx
            //1:  48 bb 00 00 d6 c7 b5    movabs rbx,0x1b5c7d60000
            //8:  01 00 00
            //b:  48 89 0b                mov QWORD PTR[rbx],rcx
            //e:  48 bb 08 00 d6 c7 b5    movabs rbx,0x1b5c7d60008
            //15: 01 00 00
            //18: 89 13                   mov DWORD PTR[rbx],edx
            //1a: 48 bb 12 00 60 7d 5c    movabs rbx,0x1b5c7d600012
            //21: 1b 00 00
            //24: 44 89 03                mov DWORD PTR[rbx],r8d
            //27: 5b                      pop    rbx


            _virtualMemoryFlagLogAddress = Kernel32.VirtualAllocEx(_process.Handle, IntPtr.Zero, (IntPtr)sizeof(long) + sizeof(uint) + sizeof(int), Kernel32.MEM_COMMIT, Kernel32.PAGE_EXECUTE_READWRITE);

            var assembly = $@"
                        push rbx
                        movabs rbx,0x{_virtualMemoryFlagLogAddress.ToInt64():X2}

                        mov QWORD PTR[rbx],rcx
                        movabs rbx,0x{_virtualMemoryFlagLogAddress.ToInt64() + sizeof(long):X2}

                        mov DWORD PTR[rbx],edx
                        movabs rbx,0x{_virtualMemoryFlagLogAddress.ToInt64() + sizeof(long) + sizeof(uint):X2}

                        mov DWORD PTR[rbx],r8d
                        pop rbx

                        mov    QWORD PTR [rsp+0x8],rbx
                        ";

            var assembler = new Keystone.Engine(Architecture.X86, Mode.X64);
            assembler.ThrowOnError = true;
            var assembleResult = assembler.Assemble(assembly, (ulong)_igtCodeCave.GetAddress()).Buffer.ToList();
         
            assembleResult.Add(0xE9);//jmp

            var jumpFromAddress = codeCave + assembleResult.Count;
            var jmpAddress = (int)(setEventFlag + 9) - (jumpFromAddress + 9) + 1;
            assembleResult.AddRange(BitConverter.GetBytes((int)jmpAddress));

#if DEBUG
            var debugHexStr = assembleResult.ToArray().ToHexString();
            Debug.WriteLine(debugHexStr);
#endif            

            var detour = new List<byte>() { 0xE9 };
            int detourTarget = (int)(codeCave - (setEventFlag + 5));
            detour.AddRange(BitConverter.GetBytes(detourTarget));

            //Write fixes to game memory
            Ntdll.NtSuspendProcess(_process.Handle);
            
            var result = Kernel32.WriteProcessMemory(_process.Handle, (IntPtr)codeCave, assembleResult.ToArray(), (uint)assembleResult.Count, out uint bytesWritten);
            result &= Kernel32.WriteProcessMemory(_process.Handle, (IntPtr)setEventFlag, detour.ToArray(), (uint)detour.Count, out bytesWritten);
            
            Ntdll.NtResumeProcess(_process.Handle);
        }


        public (long, uint, int) ReadLoggedEventFlag()
        {
            var buffer = new byte[sizeof(long) + sizeof(uint) + sizeof(int)];
            var read = 0;
            Kernel32.ReadProcessMemory(_process.Handle, _virtualMemoryFlagLogAddress, buffer, buffer.Length, ref read);

            return 
            (
                BitConverter.ToInt64(buffer, 0),
                BitConverter.ToUInt32(buffer, 8),
                BitConverter.ToInt32(buffer, 12)
            );
        }

        public bool ReadEventFlag(uint flagId)
        {
            if (_virtualMemoryFlag == null)
            {
                return false;
            }

            var divisor = _virtualMemoryFlag.ReadInt32(0x1c);
            if (divisor == 0)
            {
                divisor = 1000;
            }

            var category = (flagId / divisor);
            var leastSignificantDigits = flagId - (category * divisor);

            var currentElement = _virtualMemoryFlag.CreatePointerFromAddress(0x38);
            var currentSubElement = currentElement.CreatePointerFromAddress(0x8);
            
            while (currentSubElement.ReadByte(0x19) == '\0')
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

            if (currentElement.GetAddress() == _virtualMemoryFlag.ReadInt64(0x38) || category < _virtualMemoryFlag.ReadInt32(0x20))
            {
                currentElement = _virtualMemoryFlag.CreatePointerFromAddress(0x38);
            }

            if (currentElement.GetAddress() != _virtualMemoryFlag.ReadInt64(0x38))
            {
                var ret = 0;
                if (currentElement.ReadInt32(0x28) - 1 == 1)
                {
                    throw new Exception("flag not supported");
                    //lVar3 = (ulonglong)(uint)(*(int*)(currentElement + 6) * *(int*)(param_1 + 0x20)) +
                    //        *(longlong*)(param_1 + 0x28);
                }
                else
                {
                    //if (currentElement.ReadInt32(0x28) - 1 != 2)
                    //{
                    //    return false;
                    //}
                    ret = currentElement.ReadInt32(0x30);
                }

                var ptr = (_virtualMemoryFlag.ReadInt32(0x20) * currentElement.ReadInt32(0x30)) + _virtualMemoryFlag.ReadInt64(0x28);
                if (ptr != 0)
                {
                    var thing = 7 - (leastSignificantDigits & 7);
                    var anotherThing = 1 << (int)thing;
                    var shifted = leastSignificantDigits >> 3;

                    var pointer = new Pointer(_process, _virtualMemoryFlag.Is64Bit, ptr + shifted);
                    var read = pointer.ReadInt32();
                    if ((read & anotherThing) != 0)
                    {
                        return true;
                    }
                }
            }

            return false;


            //uVar3 = param_2 / *(uint*)(param_1 + 0x1c);
            //uVar8 = param_2 - *(uint*)(param_1 + 0x1c) * uVar3;
            //puVar2 = *(undefined8**)(param_1 + 0x38);
            //cVar1 = *(char*)((longlong)(undefined8*)puVar2[1] + 0x19);
            //puVar7 = puVar2;
            //puVar6 = (undefined8*)puVar2[1];
            //while (cVar1 == '\0')
            //{
            //    if (*(uint*)(puVar6 + 4) < uVar3)
            //    {
            //        puVar5 = (undefined8*)puVar6[2];
            //        puVar6 = puVar7;
            //    }
            //    else
            //    {
            //        puVar5 = (undefined8*)*puVar6;
            //    }
            //    puVar7 = puVar6;
            //    puVar6 = puVar5;
            //    cVar1 = *(char*)((longlong)puVar5 + 0x19);
            //}
            //if ((puVar7 == puVar2) || (uVar3 < *(uint*)(puVar7 + 4)))
            //{
            //    puVar7 = puVar2;
            //}
            //bVar9 = false;
            //if (puVar7 != puVar2)
            //{
            //    if (*(int*)(puVar7 + 5) == 1)
            //    {
            //        lVar4 = (ulonglong)(uint)(*(int*)(puVar7 + 6) * *(int*)(param_1 + 0x20)) +
            //                *(longlong*)(param_1 + 0x28);
            //    }
            //    else
            //    {
            //        if (*(int*)(puVar7 + 5) != 2)
            //        {
            //            return false;
            //        }
            //        lVar4 = puVar7[6];
            //    }
            //    bVar9 = false;
            //    if (lVar4 != 0)
            //    {
            //        bVar9 = (*(byte*)((ulonglong)(uVar8 >> 3) + lVar4) &
            //                 (byte)(1 << (7 - ((byte)uVar8 & 7) & 0x1f))) != 0;
            //    }
            //}
            //return bVar9;
        }
        
        #endregion

        #region Timeable
        public int GetInGameTimeMilliseconds()
        {
            return _igt?.ReadInt32() ?? 0;
        }

        public bool IsInGame()
        {
            return IsPlayerLoaded() && GetScreenState() == ScreenState.InGame;
        }
        
        public bool InitialLoadRemoval() => NoCutsceneOrBlackscreen();

        public void ResetIgt()
        {
            _igt?.WriteInt32(0);
        }
        #endregion

        #region B3's IGT fix
        /*
          Copyright © 2022 B3

          Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

          The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

          THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
        */

        //movups       Move Unaligned Packed Single-Precision Floating-Point Values
        //cvtss2sd     Convert Scalar Single-Precision Floating-Point Value to Scalar Double-Precision Floating-Point Value
        //cvttsd2si    Convert with Truncation Scalar Double-Precision Floating-Point Value to Signed Integer
        //cvtpd2ps     Convert Packed Double-Precision Floating-Point Values to Packed Single-Precision Floating-Point Values
        //subsd        Subtract Scalar Double-Precision Floating-Point Value
        //movupd       Move Unaligned Packed Double-Precision Floating-Point Values
        //addsd        Add Scalar Double-Precision Floating-Point Values

        public bool ApplyIgtFix()
        {
            if (_process == null)
            {
                return false;
            }

            long igtFixEntryPoint = _igtFix.GetAddress();
            long codeCave = _igtCodeCave.GetAddress();

            //Check if the byte at the injection address is a jmp instruction
            var readBuffer = new byte[1];
            int readBytes = 0;
            Kernel32.ReadProcessMemory(_process.Handle, (IntPtr)igtFixEntryPoint, readBuffer, readBuffer.Length, ref readBytes);
            if (readBuffer[0] == 0xE9)
            {
                return true; //code already injected. Return.
            }

            //The location used as code cave here is the constructor of the network test title screen. This code would never run under normal circumstances so we can overwrite it.
            //fix detour
            var igtFixDetourCode = new List<byte>() { 0xE9 };
            int detourTarget = (int)(codeCave - (igtFixEntryPoint + 5));
            igtFixDetourCode.AddRange(BitConverter.GetBytes(detourTarget));


            //fix body
            var frac = Kernel32.VirtualAllocEx(_process.Handle, IntPtr.Zero, (IntPtr)sizeof(double), Kernel32.MEM_COMMIT, Kernel32.PAGE_EXECUTE_READWRITE);
            var scale = Kernel32.VirtualAllocEx(_process.Handle, IntPtr.Zero, (IntPtr)sizeof(float), Kernel32.MEM_COMMIT, Kernel32.PAGE_EXECUTE_READWRITE);

            var buffer = BitConverter.GetBytes(0.96f);
            var writeRes = Kernel32.WriteProcessMemory(_process.Handle, (IntPtr)scale, buffer.ToArray(), (uint)buffer.Length, out uint written);

            var igtFixCode = new List<byte>(){
                0x53,                        //push   rbx
                0x48, 0xBB                   //movabs rbx, frac address
            };
            igtFixCode.AddRange(BitConverter.GetBytes((long)frac));

            igtFixCode.AddRange(new byte[]
            {
                0x51,                        //push   rcx
                0x48, 0xb9,                  //movabs rcx, scale address
            });
            igtFixCode.AddRange(BitConverter.GetBytes((long)scale));
            igtFixCode.AddRange(new byte[]
            {
                0x44, 0x0f, 0x10, 0x39,       //movups    xmm15, XMMWORD PTR [rcx]   ; read scale value
                0xF3, 0x41, 0x0F, 0x59, 0xCF, //mulss     xmm1,  xmm15               ; multiply frame delta by scale
                0x44, 0x0F, 0x10, 0xF1,       //movups    xmm14, xmm1                ; frame time to double
                0xF3, 0x45, 0x0F, 0x5A, 0xF6, //cvtss2sd  xmm14, xmm14               ; 
                0xF2, 0x49, 0x0F, 0x2C, 0xC6, //cvttsd2si rax,   xmm14               ; cast scaled frametime to int
                0xF2, 0x4C, 0x0F, 0x2A, 0xF8, //cvtsi2sd  xmm15, rax                 ; cast int frametime to double
                0xF2, 0x45, 0x0F, 0x5C, 0xF7, //subsd     xmm14, xmm15               ; subtract int frametime from double frametime -> only the fracture remains
                0x66, 0x44, 0x0F, 0x10, 0x3B, //movupd    xmm15, [rbx]               ; load previous fracture
                0xF2, 0x45, 0x0F, 0x58, 0xFE, //addsd     xmm15, xmm14               ; add fractures
                0x66, 0x44, 0x0F, 0x11, 0x3B, //movupd    [rbx], xmm15               ; store new fracture
                0xF2, 0x49, 0x0F, 0x2C, 0xC7, //cvttsd2si rax,   xmm15               ; cast fracture to int
                0x48, 0x85, 0xC0,             //test      rax,   rax                 ; if fracture is 1 or bigger
                0x74, 0x1D,                   //jz        +1D                        ; 
                0x90, 0x90, 0x90, 0x90,       //nop                                  ;
                0xF2, 0x4C, 0x0F, 0x2A, 0xF0, //cvtsi2sd  xmm14, rax                 ; convert fracture back to double (will always be 1)
                0xF2, 0x45, 0x0F, 0x5C, 0xFE, //subsd     xmm15, xmm14               ; remove from fracture
                0x66, 0x44, 0x0F, 0x11, 0x3B, //movupd    [rbx], xmm15               ; store remainder of fracture
                0xF2, 0x45, 0x0F, 0x5A, 0xF6, //cvtsd2ss  xmm14, xmm14               ; convert fracture from double to single
                0xF3, 0x41, 0x0F, 0x58, 0xCE, //addss     xmm1, xmm14                ; add fracture to frame delta
                                              //jz landing                           ; jz lands on the next line
                0x45, 0x0F, 0x57, 0xF6,       //xorps     xmm14, xmm14               ; zero xmm14
                0x45, 0x0F, 0x57, 0xFF,       //xorps     xmm15, xmm15               ; zero xmm15
                0x59,                         //pop rcx                              ;
                0x5B,                         //pop rbx                              ;
                0xF3, 0x48, 0x0F, 0x2C, 0xC1, //cvttss2si rax,xmm1                   ; cast unscaled frame delta to int in rax (eax will be added to igt)
                0xE9                          //jmp return igtFixEntryPoint +5
            });

            var jumpFromAddress = codeCave + igtFixCode.Count - 1;//minus jmp instruction
            var jmpAddress = (igtFixEntryPoint + 9) - (jumpFromAddress + 9);
            igtFixCode.AddRange(BitConverter.GetBytes(jmpAddress));
            var str = igtFixCode.ToArray().ToHexString().Replace("-", " ");


            //Write fixes to game memory
            Ntdll.NtSuspendProcess(_process.Handle);
            
            var result = Kernel32.WriteProcessMemory(_process.Handle, (IntPtr)codeCave, igtFixCode.ToArray(), (uint)igtFixCode.Count, out uint bytesWritten);
            result &= Kernel32.WriteProcessMemory(_process.Handle, (IntPtr)igtFixEntryPoint, igtFixDetourCode.ToArray(), (uint)igtFixDetourCode.Count, out bytesWritten);

            Ntdll.NtResumeProcess(_process.Handle);

            return result;
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2} ", b);
            return hex.ToString();
        }

        #endregion

        #region Dll injection
#if DEBUG
        public void InjectDll(string path)
        {
            //Get a process handle
            IntPtr processHandle = Kernel32.OpenProcess(Kernel32.PROCESS_CREATE_THREAD | 
                                                        Kernel32.PROCESS_QUERY_INFORMATION | 
                                                        Kernel32.PROCESS_VM_OPERATION | 
                                                        Kernel32.PROCESS_VM_WRITE | 
                                                        Kernel32.PROCESS_VM_READ, false, _process.Id);

            //Allocate a buffer in the target process, copy the path to the target dll into this 
            IntPtr allocatedDllFileName = Kernel32.VirtualAllocEx(processHandle, IntPtr.Zero, (IntPtr)((path.Length + 1) * Marshal.SizeOf(typeof(char))), Kernel32.MEM_COMMIT | Kernel32.MEM_RESERVE, Kernel32.PAGE_READWRITE);
            Kernel32.WriteProcessMemory(processHandle, allocatedDllFileName, Encoding.Default.GetBytes(path), (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char))), out uint _);

            //Get handles to library loading related functions
            IntPtr loadLibraryA     = Kernel32.GetProcAddress(Kernel32.GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            //Load dll by having the target process call loadLibraryA
            var loadThread = Kernel32.CreateRemoteThread(processHandle, IntPtr.Zero, 0, loadLibraryA, allocatedDllFileName, 0, IntPtr.Zero);
            Kernel32.WaitForSingleObject(loadThread, 10000);

            Kernel32.VirtualFreeEx(processHandle, allocatedDllFileName, IntPtr.Zero, Kernel32.MEM_RELEASE);
        }
#endif
#endregion
    }
}
