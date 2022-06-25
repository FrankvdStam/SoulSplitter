using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Shared;

namespace SoulMemory.DarkSouls2.Vanilla
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

        private void ResetPointers()
        {
            _eventFlagManager = null;
            _position = null;
            _loadState = null;
        }

        private Exception InitPointers()
        {
            try
            {
                _process.ScanCache()
                    .ScanAbsolute("GameManagerImp", "8B F1 8B 0D ? ? ? 01 8B 01 8B 50 28 FF D2 84 C0 74 0C", 4)
                        .CreatePointer(out _eventFlagManager, 0, 0, 0x44, 0x10)
                        .CreatePointer(out _position, 0, 0, 0x74)
                    
                    .ScanAbsolute("LoadState", "89 35 ? ? ? ? e8 ? ? ? ? 66 0f ef c0", 2)
                        .CreatePointer(out _loadState, 0, 0);

                ;

                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        #endregion

        public Vector3f GetPosition()
        {
            if (_position == null)
            {
                return new Vector3f();
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

            return _loadState.ReadUInt32(0x1D4) == 1;
        }

        public bool ReadEventFlag(uint eventFlagId)
        {
            if (_eventFlagManager == null)
            {
                return false;
            }

            var eventCategory = (eventFlagId / 10000) * 0x89;
            var offset = (eventCategory % 0x1f) * 4 + 0x10;


            //var uVar1 = ((eventCategory - eventCategory / 0x1f >> 1) + (eventCategory / 0x1f) >> 4) * 31;
            //var r8d = eventCategory - uVar1;
            //
            //var tesy = (IntPtr)_eventFlagManager.ReadInt32();
            //
            //var offset = r8d * 0x4 + 0x10;

            //var address = (IntPtr)_eventFlagManager.GetAddress();
            var vector = _eventFlagManager.CreatePointerFromAddress(offset);

            //ecx 100A9ED0
            //edx 00000011
            //res:10152830
            

            for (int i = 0; i < 100; i++) //Replaced infinite while with for loop, in case some memes occur and the function never returns
            {
                if (vector.IsNullPtr())
                {
                    return false;
                    //TODO: fix this. Should be (uVar1 * 0x1f >> 8) << 8
                    //;result = uVar1 & 0xffffffffffffff00;
                }

                if (vector.ReadInt32(0x8) == eventFlagId / 10000)
                {
                    var category2 = eventFlagId % 10000 >> 3;
                    if (category2 < vector.ReadInt32(0x4))
                    {
                        var ptr = vector.CreatePointerFromAddress(0x0);
                        var shift = (int)(0x7 - (eventFlagId % 10000) & 0x7);
                        var shifted = 0x1 << shift;
                        var flagBit = ptr.ReadByte(category2);
                        return flagBit == shifted;
                    }
                }
                vector = vector.CreatePointerFromAddress(0xc);
            }

            return false;
        }
    }
}
