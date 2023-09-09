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
using SoulMemory.Memory;
using Pointer = SoulMemory.Memory.Pointer;

namespace SoulMemory.DarkSouls3
{
    public class DarkSouls3 : IGame
    {
        private Process _process;
        private readonly Pointer _gameDataMan = new Pointer();
        private readonly Pointer _playerGameData = new Pointer();
        private readonly Pointer _playerIns = new Pointer();
        private readonly Pointer _newMenuSystem = new Pointer();
        private readonly Pointer _loading = new Pointer();
        private readonly Pointer _blackscreen = new Pointer();
        private readonly Pointer _sprjEventFlagMan = new Pointer();
        private readonly Pointer _fieldArea = new Pointer();
        private readonly Pointer _sprjChrPhysicsModule = new Pointer();
        private long _igtOffset;

        public Process GetProcess() => _process;
        public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "darksoulsiii", InitPointers, ResetPointers);

        public TreeBuilder GetTreeBuilder()
        {
            var treeBuilder = new TreeBuilder();
            treeBuilder
                .ScanRelative("NewMenuSystem", "48 8b 0d ? ? ? ? 48 8b 7c 24 20 48 8b 5c 24 30 48 85 c9", 3, 7)
                    .AddPointer(_newMenuSystem, 0);

            treeBuilder
                .ScanRelative("GameDataMan", "48 8b 0d ? ? ? ? 4c 8d 44 24 40 45 33 c9 48 8b d3 40 88 74 24 28 44 88 74 24 20", 3, 7)
                    .AddPointer(_gameDataMan, 0)
                    .AddPointer(_playerGameData, 0, 0x10);

            treeBuilder
                .ScanRelative("playerIns", "48 8b 0d ? ? ? ? 45 33 c0 48 8d 55 e7 e8 ? ? ? ? 0f 2f 73 70 72 0d f3 ? ? ? ? ? ? ? ? 0f 11 43 70", 3, 7)
                    .AddPointer(_playerIns, 0, 0x80)
                    .AddPointer(_sprjChrPhysicsModule, 0, 0x40, 0x28);

            treeBuilder
                .ScanRelative("Loading", "c6 05 ? ? ? ? ? e8 ? ? ? ? 84 c0 0f 94 c0 e9", 2, 7)
                    .AddPointer(_loading);

            treeBuilder
                .ScanRelative("SprjFadeImp", "48 8b 0d ? ? ? ? 4c 8d 4c 24 38 4c 8d 44 24 48 33 d2", 3, 7) //0x8 = ptr to Fd4FadeSystem
                    .AddPointer(_blackscreen, 0x0, 0x8, 0x2ec);

            treeBuilder
                .ScanRelative("SprjEventFlagMan", "48 c7 05 ? ? ? ? 00 00 00 00 48 8b 7c 24 38 c7 46 54 ff ff ff ff 48 83 c4 20 5e c3", 3, 11)
                    .AddPointer(_sprjEventFlagMan, 0x0);

            treeBuilder
                .ScanRelative("FieldArea", "4c 8b 3d ? ? ? ? 8b 45 87 83 f8 ff 74 69 48 8d 4d 8f 48 89 4d 9f 89 45 8f 48 8d 55 8f 49 8b 4f 10", 3, 7)
                    .AddPointer(_fieldArea);

            return treeBuilder;
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

                //Clear count: 0x78 -> likely subject to the same shift that happens to IGT offset
                switch (GetVersion(v))
                {
                    default:
                        _igtOffset = 0xa4;
                        break;

                    case DarkSouls3Version.V104:
                        _igtOffset = 0x9c;
                        break;

                    case DarkSouls3Version.Later:
                        _igtOffset = 0xa4;
                        break;
                }

                var treeBuilder = GetTreeBuilder();
                return MemoryScanner.TryResolvePointers(treeBuilder, _process);
            }
            catch(Exception e)
            {
                return RefreshError.FromException(e);
            }
        }
        
        private void ResetPointers()
        {
            _gameDataMan.Clear();
            _playerGameData.Clear();
            _playerIns.Clear();
            _loading.Clear();
            _blackscreen.Clear();
            _sprjEventFlagMan.Clear();
            _fieldArea.Clear();
            _sprjChrPhysicsModule.Clear();
        }



        public enum DarkSouls3Version
        {
            V104,
            Later,
        };

        public static DarkSouls3Version GetVersion(Version v)
        {
            if (v.Minor <= 4)
            {
                return DarkSouls3Version.V104;
            }

            return DarkSouls3Version.Later;
        }
        
        public bool IsLoading()
        {
            if (_loading == null)
            {
                return true;
            }
            return _loading?.ReadInt32(-0x1) != 0;
        }

        public bool BlackscreenActive()
        {
            return _blackscreen?.ReadInt32() != 0;
        }

        public bool Attached => _process != null;

        public bool IsPlayerLoaded()
        {
            if (_playerIns != null)
            {
                return _playerIns.ReadInt64() != 0;
            }
            return false;
        }

        public void WriteInGameTimeMilliseconds(int millis)
        {
            _gameDataMan?.WriteInt32(_igtOffset, millis);
        }

        public int GetInGameTimeMilliseconds()
        {
            return _gameDataMan?.ReadInt32(_igtOffset) ?? 0;
        }

        public Vector3f GetPosition()
        {
            if(_sprjChrPhysicsModule == null)
            {
                return new Vector3f();
            }
            return new Vector3f
            (
                _sprjChrPhysicsModule.ReadFloat(0x80),
                _sprjChrPhysicsModule.ReadFloat(0x84),
                _sprjChrPhysicsModule.ReadFloat(0x88)
            );
        }

        #region Read attributes

        public int ReadAttribute(Attribute attribute)
        {
            if (_playerGameData != null && _newMenuSystem != null && IsPlayerLoaded() && _newMenuSystem.ReadInt32(0x88) != 3)
            {
                return _playerGameData.ReadInt32((long)attribute);
            }

            return -1;
        }


        #endregion

        #region read event flags
        public bool ReadEventFlag(uint eventFlagId)
        {
            var eventFlagIdDiv10000000 = (int)(eventFlagId / 10000000) % 10;
            var eventFlagArea          = (int)(eventFlagId / 100000  ) % 100;
            var eventFlagIdDiv10000    = (int)(eventFlagId / 10000   ) % 10;
            var eventFlagIdDiv1000     = (int)(eventFlagId / 1000    ) % 10;

            //14000002

            //ItemPickup 0x0?
            //Bonfire = 0x11?
            var flagWorldBlockInfoCategory = -1;
            if (eventFlagArea >= 90 || eventFlagArea + eventFlagIdDiv10000 == 0)
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

                var worldInfoOwner = _fieldArea.Append(0x0, 0x10).CreatePointerFromAddress();

                //Flag stored in world related struct? Looks like the game is reading a size, and then looping over a vector of structs (size 0x38)
                var size = worldInfoOwner.ReadInt32(0x8);
                var vector = worldInfoOwner.Append(0x10);

                //Loop over worldInfo structs
                for (int i = 0; i < size; i++)
                {
                    //0x00007ff4fd9ba4c3
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
                                var flag = worldInfoBlockVector.ReadInt32((index * 0x70) + 0x8);

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
                            flagWorldBlockInfoCategory = worldInfoBlockVector.ReadInt32((index * 0x70) + 0x20);
                            break;
                        }
                    }
                }

                if (-1 < flagWorldBlockInfoCategory)
                {
                    flagWorldBlockInfoCategory++;
                }
            }


            var ptr = _sprjEventFlagMan.Append(0x218, eventFlagIdDiv10000000 * 0x18, 0x0);

            if (ptr.IsNullPtr() || flagWorldBlockInfoCategory < 0)
            {
                return false;
            }

            var resultPointerAddress = new Pointer();
            resultPointerAddress.Initialize(ptr.Process, ptr.Is64Bit, (eventFlagIdDiv1000 << 4) + ptr.GetAddress() + flagWorldBlockInfoCategory * 0xa8, 0x0);

            if (!resultPointerAddress.IsNullPtr())
            {
                var value = resultPointerAddress.ReadUInt32((long)((uint)((int)eventFlagId % 1000) >> 5) * 4);
                var mask = 1 << (0x1f - ((byte)((int)eventFlagId % 1000) & 0x1f) & 0x1f);
                var result = value & mask;
                return result != 0;
            }
            return false;
        }

        //get_event_flag_pointer at 0x1404c7140
        //
        //longlong get_event_flag_pointer(longlong SprjEventFlagMan_ptr, uint eventFlagId, bool state)
        //
        //{
        //    int func_1_result_int;
        //    ulonglong func_1_result;
        //    longlong lVar1;
        //    longlong lVar2;
        //    uint eventFlagDiv_1000;
        //    ulonglong eventFlagDiv_10000000;
        //    uint local_res8[2];
        //
        //    /* Returns a pointer to the event flag. Pointer must be read, at on offset,
        //       obtained with some bitmagic applied to the event flag, to get a value
        //       indicating if the flag is set or not */
        //    if ((*(char*)(SprjEventFlagMan_ptr + 0x228) == '\0') || ((int)eventFlagId < 0))
        //    {
        //        return 0;
        //    }
        //    eventFlagDiv_10000000 = (ulonglong)(uint)(((int)eventFlagId / 10000000) % 10);
        //    eventFlagDiv_1000 = ((int)eventFlagId / 1000) % 10;
        //    func_1_result =
        //         func_1(SprjEventFlagMan_ptr, ((int)eventFlagId / 100000) % 100, ((int)eventFlagId / 10000) % 10
        //                , state);
        //    func_1_result_int = (int)func_1_result;
        //    if (state == false)
        //    {
        //        /* If fieldarea not initialized (Main menu?) */
        //        if (Global_FieldArea_Ptr != (FieldArea*)0x0)
        //        {
        //            FUN_1404c46b0(Global_FieldArea_Ptr->WorldInfoOwner_ptr2, local_res8,
        //                          *(undefined4*)&Global_FieldArea_Ptr->field4_0x20);
        //            is_param_smaller_than_90(local_res8[0] >> 0x18);
        //        }
        //        /* Section is repeated bellow.
        //           Looks like the compiler failed to optimize this properly.
        //           It seems like param3 and Global_FieldArea_Ptr if statements are the only real
        //           difference, and the code is duplicated by the compiler */
        //        lVar1 = *(longlong*)(*(longlong*)(SprjEventFlagMan_ptr + 0x218) + eventFlagDiv_10000000 * 0x18);
        //        if ((lVar1 == 0) || (func_1_result_int < 0))
        //        {
        //            return 0;
        //        }
        //        lVar2 = (ulonglong)eventFlagDiv_1000 << 4;
        //        lVar1 = (longlong)func_1_result_int * 0xa8 + lVar1;
        //    }
        //    else
        //    {
        //        lVar2 = *(longlong*)(*(longlong*)(SprjEventFlagMan_ptr + 0x218) + eventFlagDiv_10000000 * 0x18);
        //        if (lVar2 == 0)
        //        {
        //            return 0;
        //        }
        //        if (func_1_result_int < 0)
        //        {
        //            return 0;
        //        }
        //        lVar1 = (ulonglong)eventFlagDiv_1000 << 4;
        //        lVar2 = (longlong)func_1_result_int * 0xa8 + lVar2;
        //    }
        //    return lVar1 + lVar2;
        //}

        #endregion
    }
}
