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
        private Pointer _bossCounters;
        private Pointer _attributes;

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
            _bossCounters = null;
            _attributes = null;
        }

        private Exception InitPointers()
        {
            try
            {
                _process.ScanCache()
                    .ScanAbsolute("GameManagerImp", "8B F1 8B 0D ? ? ? 01 8B 01 8B 50 28 FF D2 84 C0 74 0C", 4)
                        .CreatePointer(out _eventFlagManager, 0, 0, 0x44, 0x10)
                        .CreatePointer(out _position, 0, 0, 0x74)
                        .CreatePointer(out _bossCounters, 0, 0, 0x44, 0x14, 0x10, 0x4)
                        .CreatePointer(out _attributes, 0, 0, 0x74, 0x378)
                    
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
                _position.ReadFloat(0x88),
                _position.ReadFloat(0x80),
                _position.ReadFloat(0x84)
            );
        }

        public int GetBossKillCount(BossType bossType)
        {
            if (_bossCounters == null)
            {
                return 0;
            }
            return _bossCounters.ReadInt32((long)bossType);
        }

        public bool IsLoading()
        {
            if (_loadState == null)
            {
                return false;
            }

            return _loadState.ReadUInt32(0x1D4) == 1;
        }

        public int GetAttribute(Attribute attribute)
        {
            if (_attributes == null)
            {
                return 0;
            }

            var offset = _attributeOffsets[attribute];
            if (attribute == Attribute.SoulLevel)
            {
                return _attributes.ReadInt32(offset);
            }
            else
            {
                var bytes = _attributes.ReadBytes(2, offset);
                return (int)BitConverter.ToInt16(bytes, 0);
            }
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


        #region Lookup tables

        private readonly Dictionary<Attribute, long> _attributeOffsets = new Dictionary<Attribute, long>()
        {
            { Attribute.SoulLevel   , 0xcc},
            { Attribute.Vigor       , 0x4},
            { Attribute.Endurance   , 0x6},
            { Attribute.Vitality    , 0x8},
            { Attribute.Attunement  , 0xa},
            { Attribute.Strength    , 0xc},
            { Attribute.Dexterity   , 0xe},
            { Attribute.Adaptability, 0x14},
            { Attribute.Intelligence, 0x10},
            { Attribute.Faith       , 0x12},
        };



        #endregion
    }
}
