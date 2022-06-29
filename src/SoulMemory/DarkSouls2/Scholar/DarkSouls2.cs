using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Shared;

namespace SoulMemory.DarkSouls2.Scholar
{
    internal class DarkSouls2 : IDarkSouls2
    {
        private Process _process;
        private Pointer _eventFlagManager;
        private Pointer _position;
        private Pointer _loadState;

        #region Refresh/init/reset ================================================================================================================================

        public bool Refresh(out Exception exception)
        {
            exception = null;
            if (!ProcessClinger.Refresh(ref _process, "darksoulsii", InitPointers, ResetPointers, out Exception e))
            {
                exception = e;
                return false;
            }
            return true;
        }


        private Exception InitPointers()
        {
            try
            {
                _process.ScanCache()
                    .ScanRelative("GameManagerImp", "48 8b 35 ? ? ? ? 48 8b e9 48 85 f6", 3, 7)
                        .CreatePointer(out _eventFlagManager, 0, 0x70, 0x20)
                        .CreatePointer(out _position, 0, 0xd0, 0x100);
                    //.CreatePointer(out AiManager, 0x28)
                    //.CreatePointer(out rightHandWeaponMultiplier, 0xd0, 0x378, 0x28, 0x158)
                    //.CreatePointer(out LeftHandWeaponMultiplier, 0xd0, 0x378, 0x28, 0x80)


                _process.ScanCache()
                    .ScanRelative("LoadState", "48 89 05 ? ? ? ? b0 01 48 83 c4 28", 3, 7)
                        .CreatePointer(out _loadState, 0x0);
                    ;

                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private void ResetPointers()
        {
            _eventFlagManager = null;
            _position = null;
            _loadState = null;
        }

        #endregion

        public Vector3f GetPosition()
        {
            if (_position == null)
            {
                return new Vector3f(0, 0, 0);
            }
            
            return new Vector3f(
                _position.ReadFloat(0x80),
                _position.ReadFloat(0x84),
                _position.ReadFloat(0x88)
            );
        }

        public bool IsLoading()
        {
            if (_loadState == null)
            {
                return false;
            }

            return _loadState.ReadInt32(0x11c) == 1;
        }


        #region Reading event flags

        
        public bool ReadEventFlag(uint eventFlagId)
        {
            if (_eventFlagManager == null)
            {
                return false;
            }

            var eventCategory = (eventFlagId / 10000) * 0x89;
            var uVar1 = ((eventCategory - eventCategory  / 0x1f >> 1) + (eventCategory  / 0x1f) >> 4) * 31;
            var r8d = eventCategory - uVar1;

            var offset = r8d * 0x8 + 0x20;
            var vector = _eventFlagManager.CreatePointerFromAddress(offset);
            ulong result = 0;

            for(int i = 0; i < 100; i++) //Replaced infinite while with for loop, in case some memes occur and the function never returns
            {
                if (vector.IsNullPtr())
                {
                    return false;
                    //TODO: fix this. Should be (uVar1 * 0x1f >> 8) << 8
                    result = uVar1 & 0xffffffffffffff00;
                    return result != 0;
                }

                if (vector.ReadInt32(0xc) == eventFlagId / 10000)
                {
                    var category2 = eventFlagId % 10000 >> 3;
                    if (category2 < vector.ReadInt32(0x8))
                    {
                        var ptr = vector.CreatePointerFromAddress(0x0);
                        var shift = (int)(0x7 - (eventFlagId % 10000) & 0x7);
                        var shifted = 0x1 << shift;
                        var flagBit = ptr.ReadByte(category2);
                        return flagBit == shifted;
                    }
                }
                vector = vector.CreatePointerFromAddress(0x10);
            }

            return false;
        }


        //Ghidra, address 7ff6ec6bcfe0
        //Ghidra did not do such a great job. Most of this was reversed straight from the assembly, while stepping through it with a debugger.
        //
        //ulonglong FUN_7ff6ec6bcfe0_maybeReadEventFlag (EventFlagManager *eventFlagManager_ptr,uint eventFlagId)
        //                   
        //
        //{
        //  uint uVar1;
        //  uint eventCategory?;
        //  ulonglong *pointer_to_vector_in_eventflagmanager;
        //  
        //  eventCategory? = (eventFlagId / 10000) * 0x89;
        //  uVar1 = (eventCategory? - eventCategory? / 0x1f >> 1) + eventCategory? / 0x1f >> 4;
        //  pointer_to_vector_in_eventflagmanager =
        //       (ulonglong *)
        //       (&(eventFlagManager_ptr->data).vector_of_pointers_start?)[eventCategory? + uVar1 * -0x1f];    //mov rdx,[rcx+r8*8+20]
        //  do {
        //    if (pointer_to_vector_in_eventflagmanager == (ulonglong *)0x0) {
        //LAB_7ff6ec6bd03f:
        //      return (ulonglong)(uint3)(uVar1 * 0x1f >> 8) << 8;
        //    }
        //    if (*(uint *)((longlong)pointer_to_vector_in_eventflagmanager + 0xc) == eventFlagId / 10000) {
        //      eventCategory? = eventFlagId % 10000 >> 3;
        //      if (eventCategory? < *(uint *)(pointer_to_vector_in_eventflagmanager + 1)) {
        //        return *pointer_to_vector_in_eventflagmanager & 0xffffffffffffff00 |
        //               (ulonglong)
        //               ((*(byte *)((ulonglong)eventCategory? + *pointer_to_vector_in_eventflagmanager) &
        //                (byte)(1 << (7 - ((byte)(eventFlagId % 10000) & 7) & 0x1f))) != 0);
        //      }
        //      goto LAB_7ff6ec6bd03f;
        //    }
        //    pointer_to_vector_in_eventflagmanager = (ulonglong *)pointer_to_vector_in_eventflagmanager[2];
        //  } while( true );
        //}   

        #endregion
    }
}
