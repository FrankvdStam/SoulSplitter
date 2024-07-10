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
using System.Runtime.CompilerServices;
using System.Text;
using SoulMemory.Memory;
using SoulMemory.Native;
using Pointer = SoulMemory.Memory.Pointer;

namespace SoulMemory.EldenRing
{
    public class EldenRing : IGame
    {
        private Process _process = null;

        private readonly Pointer _igt = new Pointer();
        private readonly Pointer _hud = new Pointer();
        private readonly Pointer _playerIns = new Pointer();
        private readonly Pointer _playerGameData = new Pointer();
        private readonly Pointer _inventory = new Pointer();
        private readonly Pointer _menuManImp = new Pointer();
        private readonly Pointer _virtualMemoryFlag = new Pointer();
        private readonly Pointer _noLogo = new Pointer();

        private long _screenStateOffset;
        private long _positionOffset;
        private long _mapIdOffset;
        private long _playerInsOffset;
        

        #region Refresh/init/reset ================================================================================================
        public Process GetProcess() => _process;

        public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "eldenring", InitPointers, ResetPointers);

        public TreeBuilder GetTreeBuilder()
        {
            var treeBuilder = new TreeBuilder();
            treeBuilder
                .ScanRelative("FD4Time", "48 8b 05 ? ? ? ? 4c 8b 40 08 4d 85 c0 74 0d 45 0f b6 80 be 00 00 00 e9 13 00 00 00", 3, 7)
                    .AddPointer(_igt, 0, 0xa0)
                    .AddPointer(_hud, 0, 0x58, 0x9);

            treeBuilder
                .ScanRelative("WorldChrManImp", "48 8b 35 ? ? ? ? 48 85 f6 ? ? bb 01 00 00 00 89 5c 24 20 48 8b b6", 3, 7) //48 8B 05 ? ? ? ? 48 85 C0 74 0F 48 39 88 ? ? ? ? 75 06 89 B1 5C 03 00 00 0F 28 05 ? ? ? ? 4C 8D 45 E7
                    .AddPointer(_playerIns, 0, _playerInsOffset);

            treeBuilder
                .ScanRelative("MenuManImp", "48 8b 0d ? ? ? ? 48 8b 53 08 48 8b 92 d8 00 00 00 48 83 c4 20 5b", 3, 7)
                    .AddPointer(_menuManImp, 0);

            treeBuilder
                //.ScanRelative("VirtualMemoryFlag", "48 83 3d ? ? ? ? 00 75 46 4c 8b 05 ? ? ? ? 4c 89 44 24 40 ba 08 00 00 00 b9 c8 01 00 00", 3, 8)
                .ScanRelative("VirtualMemoryFlag", "44 89 7c 24 28 4c 8b 25 ? ? ? ? 4d 85 e4", 8, 7)
                    .AddPointer(_virtualMemoryFlag, 0x5);
            
            treeBuilder
                .ScanAbsolute("NoLogo", "80 bf b8 00 00 00 00 ? ? 48 8b 05 ? ? ? ? 48 85 c0 75 2e 48 8d 0d", 7)
                    .AddPointer(_noLogo);

            return treeBuilder;
        }

        private void InitializeOffsets(Version v)
        {
            var version = GetVersion(v);
            switch (version)
            {
                case EldenRingVersion.V102:
                    _screenStateOffset = 0x718;
                    _positionOffset = 0x6b8;
                    _mapIdOffset = 0x6c8;
                    _playerInsOffset = 0x18468;
                    break;

                case EldenRingVersion.V103:
                    _screenStateOffset = 0x728;
                    _positionOffset = 0x6b8;
                    _mapIdOffset = 0x6c8;
                    _playerInsOffset = 0x18468;
                    break;

                case EldenRingVersion.V104:
                case EldenRingVersion.V105:
                case EldenRingVersion.V106:
                    _screenStateOffset = 0x728;
                    _positionOffset = 0x6B0;
                    _mapIdOffset = 0x6c0;
                    _playerInsOffset = 0x18468;
                    break;

                case EldenRingVersion.V107:
                    _screenStateOffset = 0x728;
                    _positionOffset = 0x6B0;
                    _mapIdOffset = 0x6c0;
                    _playerInsOffset = 0x1e508;
                    break;

                default:
                case EldenRingVersion.V108:
                case EldenRingVersion.V109:
                case EldenRingVersion.V110:
                case EldenRingVersion.V112:
                    _screenStateOffset = 0x728;
                    _positionOffset = 0x6d4;
                    _mapIdOffset = 0x6d0;
                    _playerInsOffset = 0x1e508;
                    break;
            }
        }


        private ResultErr<RefreshError> InitPointers()
        {
            try
            {
                var versionString = _process?.MainModule?.FileVersionInfo.ProductVersion ?? "Read failed";
                if (!Version.TryParse(versionString, out Version v))
                {
                    return Result.Err(new RefreshError(RefreshErrorReason.UnknownException, $"Unable to determine game version: {versionString}"));
                }

                InitializeOffsets(v);

                var treeBuilder = GetTreeBuilder();
                var result = MemoryScanner.TryResolvePointers(treeBuilder, _process);
                if (result.IsErr)
                {
                    _igt.Clear();
                    return result;
                }

                ApplyNoLogo();

                if (!soulmods.Soulmods.Inject(_process))
                {
                    _igt.Clear();
                    return Result.Err(new RefreshError(RefreshErrorReason.UnknownException, "soulmods injection failed"));
                }
                
                return Result.Ok();
            }
            catch (Exception e)
            {
                if(e.Message == "Access is denied")
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
            _hud.Clear();
            _playerIns.Clear();
            _playerGameData.Clear();
            _inventory.Clear();
            _menuManImp.Clear();
            _virtualMemoryFlag.Clear();
            _noLogo.Clear();
        }

        #endregion


        public enum EldenRingVersion
        {
            V102,
            V103,
            V104,
            V105,
            V106,
            V107,
            V108,
            V109,
            V110,
            V112,
            Unknown,
        };

        public EldenRingVersion GetVersion(Version v)
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
                        case 4:
                            return EldenRingVersion.V104;
                        case 5:
                            return EldenRingVersion.V105;
                        case 6:
                            return EldenRingVersion.V106;
                        case 7:
                            return EldenRingVersion.V107;
                        case 8:
                            return EldenRingVersion.V108;
                        case 9:
                            return EldenRingVersion.V109;
                        case 10:
                            return EldenRingVersion.V110;
                    }

                case 2:
                    switch (v.Minor)
                    {
                        default:
                            return EldenRingVersion.Unknown;
                        case 2:
                            return EldenRingVersion.V112;
                    }
            }
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
            var player = _playerIns.ReadInt64();
            return player != 0;
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
        
        public bool IsBlackscreenActive()
        {
            var screenState = GetScreenState();
            if (screenState != ScreenState.InGame)
            {
                return false;
            }

            var flag = _menuManImp.ReadInt32(0x18);

            if (
                (flag       & 0x1) == 1 &&
                (flag >> 8  & 0x1) == 0 &&
                (flag >> 16 & 0x1) == 1
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ApplyNoLogo()
        {
            _process.NtSuspendProcess();
            _noLogo.WriteBytes(null, new byte[] { 0x90, 0x90 });
            _process.NtResumeProcess();
        }


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

        public bool ReadEventFlag(uint eventFlagId)
        {
            var divisor = _virtualMemoryFlag.ReadInt32(0x1c);
            //This check does not exist in the games code; reading 0 here means something isn't initialized yet and we should check this flag again later.
            if (divisor == 0)
            {
                return false;
            }

            var category = (eventFlagId / divisor); //stored in rax after; div r8d
            var leastSignificantDigits = eventFlagId - (category * divisor);//stored in r11 after; sub r11d,r8d

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

                if (calculatedPointer != 0)
                {
                    var thing = 7 - (leastSignificantDigits & 7);
                    var anotherThing = 1 << (int)thing;
                    var shifted = leastSignificantDigits >> 3;

                    var pointer = new Pointer();
                    pointer.Initialize(_process, _virtualMemoryFlag.Is64Bit, calculatedPointer + shifted);
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
            return _igt.ReadInt32();
        }
        public void WriteInGameTimeMilliseconds(int milliseconds)
        {
            _igt.WriteInt32(milliseconds);
        }

        #endregion
    }
}
