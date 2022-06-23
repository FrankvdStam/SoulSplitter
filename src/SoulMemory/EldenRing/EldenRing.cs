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

namespace SoulMemory.EldenRing
{
    public class EldenRing : ITimeable
    {
        public Exception Exception;
        
        private Process _process = null;

        private Pointer _igt;
        private Pointer _hud;
        private Pointer _playerIns;
        private Pointer _playerGameData;
        private Pointer _inventory;
        //private Pointer _playerChrPhysicsModule;
        private Pointer _menuManImp;
        private Pointer _igtFix;
        private Pointer _virtualMemoryFlag;
        //private Pointer _mapId;
        //private Pointer _noLogo;

        private long _screenStateOffset;
        private long _blackScreenOffset;
        private long _positionOffset;
        private long _mapIdOffset;
        private int _initialBlackscreenValue;
        
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
                
                var version = GetVersion();
                switch (version)
                {
                    default:
                    case EldenRingVersion.Unknown:
                        _screenStateOffset = 0x728;
                        _blackScreenOffset = 0x72c;
                        _positionOffset = 0x6B0;
                        _mapIdOffset = 0x6c0;
                        _initialBlackscreenValue = 16;
                        break;

                    case EldenRingVersion.V102:
                        _screenStateOffset = 0x718;
                        _blackScreenOffset = 0x71c;
                        _positionOffset = 0x6b8;
                        _mapIdOffset = 0x6c8;
                        _initialBlackscreenValue = 16;
                        break;

                    case EldenRingVersion.V103:
                        _screenStateOffset = 0x728;
                        _blackScreenOffset = 0x72c;
                        _positionOffset = 0x6b8;
                        _mapIdOffset = 0x6c8;
                        _initialBlackscreenValue = 16;
                        break;

                    case EldenRingVersion.V104:
                        _screenStateOffset = 0x728;
                        _blackScreenOffset = 0x72c;
                        _positionOffset = 0x6B0;
                        _mapIdOffset = 0x6c0;
                        _initialBlackscreenValue = 16;
                        break;

                    case EldenRingVersion.V105:
                        _screenStateOffset = 0x728;
                        _blackScreenOffset = 0x72c;
                        _positionOffset = 0x6B0;
                        _mapIdOffset = 0x6c0;
                        _initialBlackscreenValue = 17;
                        break;
                }

                var scanCache = _process.ScanCache();
                scanCache
                    //FD4Time
                    .ScanRelative("FD4Time", "48 8b 05 ? ? ? ? 4c 8b 40 08 4d 85 c0 74 0d 45 0f b6 80 be 00 00 00 e9 13 00 00 00", 3, 7)
                        .CreatePointer(out _igt, 0, 0xa0)
                        .CreatePointer(out _hud, 0, 0x58, 0x9)

                    //WorldChrManImp  
                    .ScanRelative("WorldChrManImp", "48 8B 05 ? ? ? ? 48 85 C0 74 0F 48 39 88 ? ? ? ? 75 06 89 B1 5C 03 00 00 0F 28 05 ? ? ? ? 4C 8D 45 E7", 3, 7)
                        .CreatePointer(out _playerIns       , 0, 0x18468)
                        .CreatePointer(out _playerGameData  , 0, 0x18468, 0x570)
                        .CreatePointer(out _inventory       , 0, 0x18468, 0x570, 0x5B8, 0x10, 0x0)
                        //.CreatePointer(out _mapId           , 0, 0x18468, 0x6c0)
                        //.CreatePointer(out _playerChrPhysicsModule, 0, 0x18468, 0xF68)

                    ////FieldArea
                    //.ScanRelative("FieldArea", "48 8B 0D ?? ?? ?? ?? 48 ?? ?? ?? 44 0F B6 61 ?? E8 ?? ?? ?? ?? 48 63 87 ?? ?? ?? ?? 48 ?? ?? ?? 48 85 C0", 3, 7)
                    //    .CreatePointer(out _mapId, 0, 0x190) //hitins, has map area

                    //CSMenuManImp
                    .ScanRelative("MenuManImp", "48 8b 0d ? ? ? ? 48 8b 53 08 48 8b 92 d8 00 00 00 48 83 c4 20 5b", 3, 7)
                        .CreatePointer(out _menuManImp, 0)
                    
                    //.ScanRelative("48 83 3d d5 f2 60 03 00 75 46 4c 8b 05 e4 d4 62 03 4c 89 44 24 40 ba 08 00 00 00 b9 c8 01 00 00", 3, 7)
                    .ScanRelative("VirtualMemoryFlag", "48 83 3d ? ? ? ? 00 75 46 4c 8b 05 ? ? ? ? 4c 89 44 24 40 ba 08 00 00 00 b9 c8 01 00 00", 3, 7)
                        .CreatePointer(out _virtualMemoryFlag, 1)

                    //IGT fix detour address
                    .ScanAbsolute("igtFix", "48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0 48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d ? ? ? ?", 35)
                        .CreatePointer(out _igtFix)
                    ;
                
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
            V104,
            V105,
            Unknown,
        };

        public EldenRingVersion GetVersion()
        {
            switch (_process?.MainModule?.FileVersionInfo.FileMinorPart)
            {
                default:
                case null:
                    return EldenRingVersion.Unknown;

                case 2:
                    return EldenRingVersion.V102;
                case 3:
                    return EldenRingVersion.V103;
                case 4:
                    return EldenRingVersion.V104;
                case 5:
                    return EldenRingVersion.V105;
            }
        }


        private void ResetPointers()
        {
            _igt = null;
            _hud = null;
            _playerIns = null;
            //_playerChrPhysicsModule = null;
            _menuManImp = null;
            _igtFix = null;
            _playerGameData = null;
            _inventory = null;
            _virtualMemoryFlag = null;
            //_noLogo = null;
        }

        public void EnableHud()
        {
            if (_hud != null)
            {
                var b = _hud.ReadByte();
                b |= 0x1; //Not sure if this whole byte is reserved for the HUD setting. Just going to write a 1 to the first bit and preserve the other bits.
                _hud.WriteByte(null, b);
            }
        }

        public Position GetPosition()
        {
            if (_playerIns == null)
            {
                return new Position()
                {
                    Area   = 0,
                    Block  = 0,
                    Region = 0,
                    Size   = 0,

                    X = 0.0f,
                    Y = 0.0f,
                    Z = 0.0f,
                };
            }

            var map = _playerIns.ReadInt32(_mapIdOffset);
            
            return new Position()
            {
                Area   = (byte)(map >> 24 & 0xff),
                Block  = (byte)(map >> 16 & 0xff),
                Region = (byte)(map >> 8  & 0xff),
                Size   = (byte)(map       & 0xff),

                X = _playerIns.ReadFloat(_positionOffset + 0x0),
                Y = _playerIns.ReadFloat(_positionOffset + 0x4),
                Z = _playerIns.ReadFloat(_positionOffset + 0x8),
            };
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
        
        public ScreenState GetScreenState()
        {
            var screenState = _menuManImp?.ReadInt32(_screenStateOffset) ?? (int)ScreenState.Unknown;
            if (screenState.TryParseEnum(out ScreenState s))
            {
                return s;
            }
            return ScreenState.Unknown;
        }

        //public int GetBlackScreenFlag()
        //{
        //    return _menuManImp?.ReadInt32(_blackScreenOffset) ?? 0;
        //}
        
        private bool NoCutsceneOrBlackscreen()
        {
            var flag = _menuManImp?.ReadInt32(_blackScreenOffset);
            return flag.HasValue && flag.Value == _initialBlackscreenValue;
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
                return _pointersInitialized;
            }
        }
        
        public int GetTestValue()
        {
            if (_menuManImp == null)
            {
                return 0;
            }


            var screenState = GetScreenState();
            var flag = _menuManImp.ReadInt32(0x18);
            //010101 -> IG
            //010000 -> cutscene
            //010001 -> blackscreen

            var t = flag & 0x1;
            var thing = flag >> 8 & 0x1;

            if (screenState == ScreenState.InGame)
            {
                if (
                    (flag       & 0x1) == 1 &&
                    (flag >> 8  & 0x1) == 0 &&
                    (flag >> 16 & 0x1) == 1
                   )
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            return 0;

            //if (
            //    screenState == ScreenState.InGame &&
            //    (flag       & 0x1) == 1 && 
            //    (flag >> 8  & 0x1) == 0 &&
            //    (flag >> 16 & 0x1) == 1 
            //    )
            //{
            //    return 1;
            //}
            //
            ////if (screenState == ScreenState.InGame && flag == 65793)
            ////{
            ////    return 1;
            ////}
            //return 0;
        }

        public bool Attached => _process != null;
        
        #region Read inventory
        //Got some help from Nordgaren to read the inventory. Cheers!
        //https://github.com/Nordgaren/Erd-Tools

        private const int InventoryEntrySize = 0x14;
        
        private int DeleteFromEnd(int num, int n)
        {
            for (int i = 1; num != 0; i++)
            {
                num = num / 10;
        
                if (i == n)
                    return num;
            }
        
            return 0;
        }
        
        public List<Item> ReadInventory()
        {
            var items = new List<Item>();
            
            if (_playerGameData == null || _inventory == null)
            {
                return items;
            }
            
            var inventoryCount = _playerGameData.ReadInt32(0x420);
            var inventory = _inventory.ReadBytes(inventoryCount * InventoryEntrySize);
        
            for (int i = 0; i < inventoryCount; i++)
            {
                var itemIndex = i * InventoryEntrySize;
        
               
        
                var itemId = BitConverter.ToInt32(new byte[]
                {
                    inventory[itemIndex + 0x4],
                    inventory[itemIndex + 0x5],
                    inventory[itemIndex + 0x6],
                    0x0,
                }, 0);
        
                byte cat = inventory[itemIndex + 0X7];
                byte mask = 0xF0;
                cat &= mask;
                var category = (Category)(cat * 0x1000000);
        
                if (category == Category.Weapons)
                {
                    itemId = DeleteFromEnd(itemId, 2) * 100;
                }
        
                var item = Item.FromLookupTable(category, (uint)itemId);
                if (item != null)
                {
                    Console.WriteLine($"{item.GroupName} {item.Name}");
                    items.Add(item);
                }
            }
        
            return items;
        }

        #endregion

        #region Read event flag

        public bool ReadEventFlag(uint flagId)
        {
            if (_virtualMemoryFlag == null)
            {
                return false;
            }

            var divisor = _virtualMemoryFlag.ReadInt32(0x1c);
            //This check does not exist in the games code; reading 0 here means something isn't initialized yet and we should check this flag again later.
            if (divisor == 0)
            {
                return false;
            }

            var category = (flagId / divisor); //stored in rax after; div r8d
            var leastSignificantDigits = flagId - (category * divisor);//stored in r11 after; sub r11d,r8d

            var currentElement = _virtualMemoryFlag.CreatePointerFromAddress(0x38); //rdx
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
                    calculatedPointer = (_virtualMemoryFlag.ReadInt32(0x20) * currentElement.ReadInt32(0x30)) + _virtualMemoryFlag.ReadInt64(0x28);
                }

                //var ptr = (_virtualMemoryFlag.ReadInt32(0x20) * currentElement.ReadInt32(0x30)) + _virtualMemoryFlag.ReadInt64(0x28);
                if (calculatedPointer != 0)
                {
                    var thing = 7 - (leastSignificantDigits & 7);
                    var anotherThing = 1 << (int)thing;
                    var shifted = leastSignificantDigits >> 3;

                    var pointer = new Pointer(_process, _virtualMemoryFlag.Is64Bit, calculatedPointer + shifted);
                    var read = pointer.ReadInt32();
                    if ((read & anotherThing) != 0)
                    {
                        return true;
                    }
                }
            }

            return false;

            // From Ghidra, elden ring 1.03.2 runtime dump.
            // param_1 is rcx, holds a pointer to the VirtualMemoryFlag instance
            // param_2 is edx, holds the event flag ID

            //                         **************************************************************
            //                         *                                                            *
            //                         *  FUNCTION                                                  *
            //                         **************************************************************
            //                         bool __fastcall ReadEventFlag(longlong param_1, uint par
            //         bool              AL:1           <RETURN>                                XREF[1]:     7ff743a6a8c4(W)  
            //         longlong          RCX:8          param_1
            //         uint              EDX:4          param_2                                 XREF[1]:     7ff743a6a8a4(W)  
            //         undefined8        RDX:8          currentElement                          XREF[1]:     7ff743a6a8a4(W)  
            //         undefined8        RAX:8          calculated_pointer                      XREF[1]:     7ff743a6a8c4(W)  
            //         undefined8        HASH:5ff087e   firstElement
            //                         ReadEventFlag                                   XREF[8]:     FUN_7ff743a451a0:7ff743a451aa(c), 
            //                                                                                      FUN_7ff743a451d0:7ff743a45212(c), 
            //                                                                                      FUN_7ff743a45260:7ff743a452a2(c), 
            //                                                                                      FUN_7ff743a45580:7ff743a45663(c), 
            //                                                                                      SetEventFlag:7ff743a45a28(c), 
            //                                                                                      FUN_7ff743a45ae0:7ff743a45b04(c), 
            //                                                                                      FUN_7ff743a45ba0:7ff743a45bf0(c), 
            //                                                                                      FUN_7ff743a45ca0:7ff743a45cf0(c)  
            //7ff743a6a850 44 8b 41 1c     MOV        R8D,dword ptr [param_1 + 0x1c]
            //7ff743a6a854 44 8b da        MOV        R11D,param_2
            //7ff743a6a857 33 d2           XOR        param_2,param_2
            //7ff743a6a859 41 8b c3        MOV        EAX,R11D
            //7ff743a6a85c 41 f7 f0        DIV        R8D
            //7ff743a6a85f 4c 8b d1        MOV        R10,param_1
            //7ff743a6a862 45 33 c9        XOR        R9D,R9D
            //7ff743a6a865 44 0f af c0     IMUL       R8D,EAX
            //7ff743a6a869 45 2b d8        SUB        R11D,R8D
            //7ff743a6a86c 4c 8b 41 38     MOV        R8,qword ptr [param_1 + 0x38]
            //7ff743a6a870 49 8b d0        MOV        param_2,R8
            //7ff743a6a873 49 8b 48 08     MOV        param_1,qword ptr [R8 + 0x8]
            //7ff743a6a877 44 38 49 19     CMP        byte ptr [param_1 + 0x19],R9B
            //7ff743a6a87b 75 1a           JNZ        after_element_loop
            //7ff743a6a87d 0f 1f 00        NOP        dword ptr [RAX]


            //                         element_loop                                    XREF[1]:     7ff743a6a895(j)  
            //7ff743a6a880 39 41 20        CMP        dword ptr [param_1 + 0x20],EAX
            //7ff743a6a883 73 06           JNC        LAB_7ff743a6a88b
            //7ff743a6a885 48 8b 49 10     MOV        param_1,qword ptr [param_1 + 0x10]
            //7ff743a6a889 eb 06           JMP        LAB_7ff743a6a891
            //                         LAB_7ff743a6a88b                                XREF[1]:     7ff743a6a883(j)  
            //7ff743a6a88b 48 8b d1        MOV        param_2,param_1
            //7ff743a6a88e 48 8b 09        MOV        param_1,qword ptr [param_1]
            //                         LAB_7ff743a6a891                                XREF[1]:     7ff743a6a889(j)  
            //7ff743a6a891 44 38 49 19     CMP        byte ptr [param_1 + 0x19],R9B
            //7ff743a6a895 74 e9           JZ         element_loop


            //                         after_element_loop                              XREF[1]:     7ff743a6a87b(j)  
            //7ff743a6a897 49 3b d0        CMP        param_2,R8                                                                  after while loop
            //7ff743a6a89a 74 05           JZ         LAB_7ff743a6a8a1
            //7ff743a6a89c 3b 42 20        CMP        EAX,dword ptr [param_2 + 0x20]
            //7ff743a6a89f 73 03           JNC        LAB_7ff743a6a8a4
            //                         LAB_7ff743a6a8a1                                XREF[1]:     7ff743a6a89a(j)  
            //7ff743a6a8a1 49 8b d0        MOV        param_2,R8
            //                         LAB_7ff743a6a8a4                                XREF[1]:     7ff743a6a89f(j)  
            //7ff743a6a8a4 49 3b d0        CMP        currentElement,R8                                                           skip to return
            //7ff743a6a8a7 74 49           JZ         skip_to_return
            //7ff743a6a8a9 8b 4a 28        MOV        param_1,dword ptr [currentElement + 0x28]                                   Read value from currentElement + 0x28 (usually 1 when debugging)
            //7ff743a6a8ac 83 e9 01        SUB        param_1,0x1                                                                 subtract 1
            //7ff743a6a8af 74 0b           JZ         build_pointer                                                               if value is 0, jump to build_pointer
            //7ff743a6a8b1 83 f9 01        CMP        param_1,0x1                                                                 compare value to 1 - if equal, sets the zero flag
            //7ff743a6a8b4 75 3c           JNZ        skip_to_return                                                              if zero flag is NOT set, jump to skip_to_return
            //7ff743a6a8b6 48 8b 42 30     MOV        RAX,qword ptr [currentElement + 0x30]                                       do not build pointer, instead consider [currentElement + 0x30] as the built pointer
            //7ff743a6a8ba eb 0c           JMP        bitwise_operations
            //                         build_pointer                                   XREF[1]:     7ff743a6a8af(j)  
            //7ff743a6a8bc 8b 42 30        MOV        EAX,dword ptr [currentElement + 0x30]
            //7ff743a6a8bf 41 0f af        IMUL       EAX,dword ptr [R10 + 0x20]
            //             42 20
            //7ff743a6a8c4 49 03 42 28     ADD        calculated_pointer,qword ptr [R10 + 0x28]


            //                         bitwise_operations                              XREF[1]:     7ff743a6a8ba(j)  
            //7ff743a6a8c8 48 85 c0        TEST       calculated_pointer,calculated_pointer
            //7ff743a6a8cb 74 25           JZ         skip_to_return
            //7ff743a6a8cd b9 07 00        MOV        param_1,0x7
            //             00 00
            //7ff743a6a8d2 41 8b d3        MOV        currentElement,R11D
            //7ff743a6a8d5 83 e2 07        AND        currentElement,0x7
            //7ff743a6a8d8 41 b8 01        MOV        R8D,0x1
            //             00 00 00
            //7ff743a6a8de 2b ca           SUB        param_1,currentElement
            //7ff743a6a8e0 41 d3 e0        SHL        R8D,param_1
            //7ff743a6a8e3 41 8b cb        MOV        param_1,R11D
            //7ff743a6a8e6 48 c1 e9 03     SHR        param_1,0x3
            //7ff743a6a8ea 44 84 04 01     TEST       byte ptr [param_1 + calculated_pointer*0x1],R8B
            //7ff743a6a8ee 41 0f 95 c1     SETNZ      R9B


            //                         skip_to_return                                  XREF[3]:     7ff743a6a8a7(j), 7ff743a6a8b4(j), 
            //                                                                                      7ff743a6a8cb(j)  
            //7ff743a6a8f2 41 8b c1        MOV        calculated_pointer,R9D
            //7ff743a6a8f5 c3              RET
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

            //Check if the byte at the injection address is a jmp instruction
            var readBuffer = new byte[1];
            int readBytes = 0;
            Kernel32.ReadProcessMemory(_process.Handle, (IntPtr)igtFixEntryPoint, readBuffer, readBuffer.Length, ref readBytes);
            if (readBuffer[0] == 0xE9)
            {
                return true; //code already injected. Return.
            }

            _process.ScanCache()
                .ScanAbsolute("igtCodeCave", "48 8b c4 55 57 41 56 48 8d 68 b8 48 81 ec 30 01 00 00 48 c7 44 24 40 fe ff ff ff 48 89 58 18 48 89 70 20")
                .CreatePointer(out Pointer igtCodeCave);
            long codeCave = igtCodeCave.GetAddress();

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
