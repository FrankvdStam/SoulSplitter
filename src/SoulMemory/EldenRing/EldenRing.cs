using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.DarkSouls1.Internal;
using SoulMemory.Memory;
using SoulMemory.Native;
using SoulMemory.Shared;

namespace SoulMemory.EldenRing
{
    public class EldenRing : ITimeable
    {
        public Exception Exception;
        
        private Process _process = null;
        

        private Pointer _igt;
        private Pointer _playerIns;
        private Pointer _playerChrPhysicsModule;
        private Pointer _menuManIns;
        

        public EldenRing()
        {
            Refresh();
        }


        private bool InitPointers()
        {
            try
            {
                _process.ScanPatternRelative("48 8b 05 ? ? ? ? 4c 8b 40 08 4d 85 c0 74 0d 45 0f b6 80 be 00 00 00 e9 13 00 00 00", 3, 7)
                    .CreatePointer(out _igt, 0, 0xa0);

                _process.ScanPatternRelative("48 8b 05 ? ? ? ? 48 89 98 70 84 01 00 4c 89 ab 74 06 00 00 4c 89 ab 7c 06 00 00 44 88 ab 84 06 00 00 41 83 7f 4c 00", 3, 7)
                    .CreatePointer(out _playerIns, 0, 0x18468)
                    .CreatePointer(out _playerChrPhysicsModule, 0, 0x18468, 0xf68);

                //CSMenuManIns
                _process.ScanPatternRelative("48 8b 0d ? ? ? ? 48 8b 53 08 48 8b 92 d8 00 00 00 48 83 c4 20 5b", 3, 7)
                    .CreatePointer(out _menuManIns, 0);

                //if (!ApplyIgtFix())
                //{
                //    Exception = new Exception("MIGT code injection failed");
                //}

                return true;
            }
            catch (Exception e)
            {
                Exception = e;
                return false;
            }
        }

        private void ResetPointers()
        {
            _igt = null;
            _playerIns = null;
            _menuManIns = null;
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

        /// <summary>
        /// Returns the screen state. Will falsely report InGame when the game is starting up.
        /// </summary>
        /// <returns></returns>
        public ScreenState GetScreenState()
        {
            if (_menuManIns != null)
            {
                var screenState = _menuManIns.ReadInt32(0x718);
                if (screenState.TryParseEnum(out ScreenState s))
                {
                    return s;
                }
            }
            return ScreenState.Unknown;
        }

        private bool _pointersInitialized = false;
        public bool Refresh()
        {
            if (_process == null)
            {
                //EAC bypass methods differ. In some, people rename eldenring.exe to start_protected_game.exe
                _process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("eldenring")) ?? Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("start_protected_game"));
                
                if (_process != null)
                {
                    if (InitPointers())
                    {
                        _pointersInitialized = true;
                        return true;
                    }
                    else
                    {
                        var pointerScanException = new Exception($"Pattern scan failed.\nIs EAC disabled?\n{Exception.Message}", Exception);
                        Exception = pointerScanException;
                    }
                }

                return false;
            }
            else
            {
                if (_process.HasExited)
                {
                    _process = null;
                    _pointersInitialized = false;
                    ResetPointers();
                }

                return _pointersInitialized;
            }
        }

        public bool Attached => _process != null;

        #region Timeable
        public int GetInGameTimeMilliseconds()
        {
            return _igt?.ReadInt32() ?? 0;
        }

        public bool IsInGame()
        {
            return IsPlayerLoaded() && GetScreenState() == ScreenState.InGame;
        }

        public bool StartAutomatically()
        {
            var igt = GetInGameTimeMilliseconds();
            return igt > 0 && igt < 150;
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

            //eldenring.exe+250377 - F3 48 0F2C C1         - cvttss2si rax,xmm1

            //Scan for the code before detour address
            var igtFixEntryPoint = _process.MainModule.BaseAddress.ToInt64() + PatternScanner.Scan(_process, "48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0 48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d ? ? ? ?") + 35;

            //Check if the byte at the injection address is a jmp instruction
            var readBuffer = new byte[1];
            int readBytes = 0;
            Kernel32.ReadProcessMemory(_process.Handle, (IntPtr)igtFixEntryPoint, readBuffer, readBuffer.Length, ref readBytes);
            if (readBuffer[0] == 0xE9)
            {
                return true; //code already injected. Return.
            }


            //The location used as code cave here is the constructor of the network test title screen. This code would never run under normal circumstances so we can overwrite it.
            var codeCave = _process.MainModule.BaseAddress.ToInt64() + PatternScanner.Scan(_process, "48 8b c4 55 57 41 56 48 8d 68 b8 48 81 ec 30 01 00 00 48 c7 44 24 40 fe ff ff ff 48 89 58 18 48 89 70 20");

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
            var testything = (igtFixEntryPoint + 9) - (jumpFromAddress + 9);
            igtFixCode.AddRange(BitConverter.GetBytes(testything));


            //var asd = BitConverter.GetBytes(testything);

            //int jmpTarget = (int)((igtFixEntryPoint + 5) - (codeCave + 149 + 5));
            //igtFixCode.AddRange(BitConverter.GetBytes(jmpTarget));
            //
            //var test = ByteArrayToString(igtFixCode.ToArray());

            //Write fixes to game memory
            Ntdll.NtSuspendProcess(_process.Handle);

            //No broken timer
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
    }
}
