using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Shared;

namespace SoulMemory.Sekiro
{
    public class Sekiro
    {
        private Process _process;

        private Pointer _sprjEventFlagMan;
        private Pointer _fieldArea;

        private bool InitPointers()
        {
            try
            {
                _process.ScanCache()
                    .ScanRelative("SprjEventFlagMan", "48 8b 1d ? ? ? ? 4c 89 64 24 30 44 8b e2 4c 89 7c 24 20 48 85 db", 3, 7)
                        .CreatePointer(out _sprjEventFlagMan, 0)

                    .ScanRelative("FieldArea", "48 8b 0d ? ? ? ? 48 85 c9 74 26 44 8b 41 28 48 8d 54 24 40", 3, 7)
                        .CreatePointer(out _fieldArea, 0);
                    ;

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        #region Refresh ================================================================================================================================

        private void ResetPointers()
        {
            _sprjEventFlagMan = null;
            _fieldArea = null;
        }

        public bool Refresh()
        {
            if (_process == null)
            {
                _process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("sekiro"));
                if (_process != null)
                {
                    if (!InitPointers())
                    {
                        _process = null;
                    }
                }
            }
            else
            {
                if (_process.HasExited)
                {
                    _process = null;
                    ResetPointers();
                }
            }
            return _process != null;
        }

        #endregion

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

        //             ((*(uint *)(*in_RAX + (ulonglong)((uint)(param_2 % 1000) >> 5) * 4) >> (0x1f - (param_2 % 1000 & 0x1fU) & 0x1f) & 1) != 0);


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

    }
}
