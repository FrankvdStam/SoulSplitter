using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoulMemory.Memory;
using SoulMemory.Shared;

namespace SoulMemory.DarkSouls1.Internal
{
    internal class DarkSoulsRemastered : BaseMemoryReaderWriter, IDarkSouls
    {
        #region ptrs

        private readonly Pointer _gameDataManIns;
        private readonly Pointer _hostPlayerGameData;
        private readonly Pointer _worldProgression;
        private readonly Pointer _menuPrompt;
        private readonly Pointer _bonfireState;

        #endregion

        #region init/attaching =======================================================================================================================================

        public DarkSoulsRemastered()
        {
            Attach();

            _process.ScanCache()
                .ScanRelative(new byte?[] { 0x48, 0x8d, 0x0d, null, null, null, null, 0x48, 0x89, 0x8a, 0x38, 0x0a, 0x00, 0x00 }, 3, 7)
                    .CreatePointer(out _menuPrompt)

                //GameDataMan
                .ScanRelative(new byte?[] { 0x48, 0x8B, 0x05, null, null, null, null, 0x45, 0x33, 0xED, 0x48, 0x8B, 0xF1, 0x48, 0x85, 0xC0 }, 3, 7)
                    .CreatePointer(out _gameDataManIns, 0)
                    //Path: GameDataMan->hostPlayerGameData->equipGameData
                    .CreatePointer(out _hostPlayerGameData, 0, 16)
                    

                //World progression
                .ScanRelative(new byte?[] { 0x48, 0x8B, 0x0D, null, null, null, null, 0x41, 0xB8, 0x01, 0x00, 0x00, 0x00, 0x44 }, 3, 7)
                    .CreatePointer(out _worldProgression, 0, 0)

                //GameDataMan
                .ScanRelative(new byte?[] { 0x48, 0x8B, 0x05, null, null, null, null, 0x45, 0x33, 0xED, 0x48, 0x8B, 0xF1, 0x48, 0x85, 0xC0 }, 3, 7)
                    .CreatePointer(out _gameDataManIns, 0)

                .ScanRelative(new byte?[]{ 0x48, 0x8b, 0x05, null, null, null, null, 0x48, 0x05, 0x08, 0x0a, 0x00, 0x00, 0x48, 0x89, 0x44, 0x24, 0x50, 0xe8, 0x34, 0xfc, 0xfd, 0xff }, 3, 7)
                    .CreatePointer(out _bonfireState, 0, 2920, 0x28, 0)
                ;
            
            InitNetManImp();
            InitFlags();
        }
        
        public bool Attach()
        {
            if (AttachByName("DarkSoulsRemastered"))
            {
                //These ptrs must refresh every frame

                InitCharacter();
            }

            return _isHooked;
        }

        #endregion

        #region init base pointers =======================================================================================================================================
        
        private IntPtr _netManImp;

        private void InitNetManImp()
        {
            if (TryScan(
                    new byte?[]
                    {
                        0x48, 0x8b, 0x05, null, null, null, null, 0x48, 0x05, 0x08, 0x0a, 0x00, 0x00, 0x48, 0x89, 0x44,
                        0x24, 0x50, 0xe8, 0x34, 0xfc, 0xfd, 0xff
                    }, out _netManImp))
            {
                _netManImp = _netManImp + ReadInt32(_netManImp + 3) + 7;
            }
        }

     

        private IntPtr _playerIns;

        public void InitCharacter()
        {
            if (TryScan(
                    new byte?[]
                    {
                        0x48, 0x8B, 0x05, null, null, null, null, 0x48, 0x39, 0x48, 0x68, 0x0F, 0x94, 0xC0, 0xC3
                    }, out _playerIns))
            {
                _playerIns = _playerIns + ReadInt32(_playerIns + 3) + 7;
            }
        }

        private IntPtr _flags;

        private void InitFlags()
        {
            if (TryScan(
                    new byte?[]
                    {
                        0x48, 0x8B, 0x0D, null, null, null, null, 0x99, 0x33, 0xC2, 0x45, 0x33, 0xC0, 0x2B, 0xC2, 0x8D,
                        0x50, 0xF6
                    }, out _flags))
            {
                _flags = _flags + ReadInt32(_flags + 3) + 7;
            }
        }

        #endregion

        #region Reading game vales =======================================================================================================================================

        public int GetGameTimeInMilliseconds()
        {
            return _gameDataManIns.ReadInt32(0xA4);
        }

        public bool IsPlayerLoaded()
        {
            var instance = (IntPtr)ReadInt32(_playerIns);
            return instance != IntPtr.Zero;
        }



        public bool IsBossDefeated(BossType bossType)
        {
            var boss = _bosses.First(i => i.BossType == bossType);
            var memVal = _worldProgression.ReadByte(boss.Offset);
            
            return memVal.IsBitSet(boss.Bit);
        }

        public MenuPrompt GetMenuPrompt()
        {
            var menu = _menuPrompt.ReadByte();
            if (((int)menu).TryParseEnum(out MenuPrompt menuPrompt))
            {
                return menuPrompt;
            }

            return MenuPrompt.Unknown;
        }

        public ForcedAnimation GetForcedAnimation()
        {
            var instance = (IntPtr)ReadInt32(_playerIns);
            var playerCtrl = instance + 0x68;
            var forcedAnimationAddr = (IntPtr)ReadInt32(playerCtrl) + 0x16C;

            var anim = ReadInt32(forcedAnimationAddr);
            if (anim.TryParseEnum(out ForcedAnimation forcedAnimation))
            {
                return forcedAnimation;
            }

            return ForcedAnimation.Unknown;
        }

        public ItemPrompt GetItemPrompt()
        {
            var instance = (IntPtr)ReadInt32(_playerIns);
            var playerCtrl = instance + 0x68;
            var itemPromptAddr = (IntPtr)ReadInt32(playerCtrl) + 0x814;

            var mem = ReadInt32(itemPromptAddr);
            if (mem.TryParseEnum(out ItemPrompt itemPrompt))
            {
                return itemPrompt;
            }

            return ItemPrompt.Unknown;
        }

        public Vector3f GetPlayerPosition()
        {
            var position = (IntPtr)ReadInt32(_playerIns);
            position = (IntPtr)ReadInt32(position + 0x68);
            position = (IntPtr)ReadInt32(position + 0x18);
            position = (IntPtr)ReadInt32(position + 0x28);
            position = (IntPtr)ReadInt32(position + 0x50);
            position = (IntPtr)ReadInt32(position + 0x20);
            position = position + 0x120;

            var x = ReadFloat(position);
            var y = ReadFloat(position + 0x4);
            var z = ReadFloat(position + 0x8);
            return new Vector3f(x, y, z);
        }



        public List<Item> GetCurrentInventoryItems()
        {
            //Path: GameDataMan->hostPlayerGameData->equipGameData.equipInventoryData.equipInventoryDataSub
            const long equipInventoryDataSubOffset = 0x3b0;

            var itemCount = _hostPlayerGameData.ReadInt32(equipInventoryDataSubOffset + 48);
            var keyCount = _hostPlayerGameData.ReadInt32(equipInventoryDataSubOffset + 52);

            //Struct has 2 lists, list 1 seems to be a subset of list 2, the lists start at the same address..
            //I think the first list only contains keys. The "master" list contains both.
            var itemList2Len = _hostPlayerGameData.ReadInt32(equipInventoryDataSubOffset);
            var itemList2 = _hostPlayerGameData.ReadInt32(equipInventoryDataSubOffset + 40);

            var bytes = ReadBytes((IntPtr)itemList2, itemList2Len * 0x1c);
            var items = ItemReader.GetCurrentInventoryItems(bytes, itemList2Len, itemCount, keyCount);
            
            return items;
        }
        

        public BonfireState GetBonfireState(Bonfire bonfire)
        {
            const int BonfireLoopMax = 100;
            //Looks like a linked list. Final element points back to the first.
            var element = _bonfireState.CreatePointerFromAddress();

            var loopCount = 0;
            while (element.GetAddress() != _bonfireState.GetAddress())
            {
                var test = element.Copy();
                test.Offsets.Clear();
                test.Offsets.Add(0x10);
                test.Offsets.Add(0x0);
                var addr = test.GetAddress();

                //Go to next element
                element = element.CreatePointerFromAddress();
                element.Offsets.Add(0x0);//Force pointer read
                element.Offsets.Add(0x0);//Force pointer read

                //Emergency escape hatch
                loopCount++;
                if (loopCount > BonfireLoopMax)
                {
                    return BonfireState.Undiscovered;
                }
            }



            var bonfireState = _bonfireState.Copy();
            var bonfireItem = bonfireState.Copy();
            
            bonfireItem.Offsets.Add(0x10);
            bonfireItem.Offsets.Add(0x0);

            var testy = bonfireState.GetAddress();

            var address = new List<long>();

            while (bonfireItem.ReadInt32() != 0)
            {
                address.Add(bonfireItem.GetAddress());
               
                var bonfireId = bonfireItem.ReadInt32(0x8);
                var bonfireStatus = bonfireItem.ReadInt32(0xc);

                if (bonfireId.TryParseEnum(out Bonfire foundBonfire) && foundBonfire == bonfire)
                {
                    if (!bonfireStatus.TryParseEnum(out BonfireState state))
                    {
                        state = BonfireState.Undiscovered;
                    }

                    return state;
                }
                
                var befpre = bonfireState.GetAddress().ToString("x8");

                bonfireState = bonfireState.Copy();
                bonfireState.Offsets.Add(0x0);
                bonfireState = bonfireState.Copy();

                var asd = bonfireState.GetAddress().ToString("x8");

                bonfireItem = bonfireState.Copy();
                bonfireItem.BaseAddress = bonfireState.GetAddress() + 0x10;
                bonfireItem.Offsets.Clear();
            }


            var sba = new StringBuilder();
            foreach (var p in address)
            {
                sba.Append($"0x{p:x}\n");
            }

            var st = sba.ToString();






            var netManImpIns = (IntPtr)ReadInt32(_netManImp);
            var frpgNetBonfireDb = (IntPtr)ReadInt32(netManImpIns + 2920);
            var unknownStruct1 = (IntPtr)ReadInt32(frpgNetBonfireDb + 0x28);
            var unknownStruct2 = (IntPtr)ReadInt32(unknownStruct1);
            var frpgNetBonfireDbItem = (IntPtr)ReadInt32(unknownStruct2 + 0x10);

            var addresses = new List<IntPtr>();
            addresses.Add(unknownStruct2);
            while (frpgNetBonfireDbItem != IntPtr.Zero)
            {
                

                var bonfireId = ReadInt32(frpgNetBonfireDbItem + 0x8);
                var bonfireStatus = ReadInt32(frpgNetBonfireDbItem + 0xc);
            
                if (bonfireId.TryParseEnum(out Bonfire foundBonfire) && foundBonfire == bonfire)
                {
                    if (!bonfireStatus.TryParseEnum(out BonfireState state))
                    {
                        state = BonfireState.Undiscovered;
                    }
            
                    return state;
                }
            
                //First pointer in this struct is a pointer to the next struct. Linked list?
                unknownStruct2 = (IntPtr)ReadInt32(unknownStruct2);
                addresses.Add(unknownStruct2);
                //Also update the pointer to the next bonfire item
                frpgNetBonfireDbItem = (IntPtr)ReadInt32(unknownStruct2 + 0x10);
            }

            var sb = new StringBuilder();
            foreach (var p in addresses)
            {
                sb.Append($"0x{p.ToInt64():x}\n");
            }

            var str = sb.ToString();
            
            return BonfireState.Undiscovered;
        }

        public ZoneType GetZone()
        {
            var netManImpIns = (IntPtr)ReadInt32(_netManImp);
            var world = ReadByte(netManImpIns + 0xa23);
            var area = ReadByte(netManImpIns + 0xa22);

            var zone = _zones.FirstOrDefault(i => i.World == world && i.Area == area);
            if (zone != null)
            {
                return zone.ZoneType;
            }

            return ZoneType.Unknown;
        }


        public void ResetInventoryIndices()
        {
            if (TryScan(new byte?[] { 0x48, 0x8D, 0x15, null, null, null, null, 0xC1, 0xE1, 0x10, 0x49, 0x8B, 0xC6, 0x41, 0x0B, 0x8F, 0x14, 0x02, 0x00, 0x00, 0x44, 0x8B, 0xC6, 0x42, 0x89, 0x0C, 0xB2, 0x41, 0x8B, 0xD6, 0x49, 0x8B, 0xCF }, out IntPtr basePtr))
            {
                basePtr = ReadPtr(basePtr + 3) + 7;
                for (int i = 0; i < 20; i++)
                {
                    Write(basePtr + (0x4 * i), uint.MaxValue);
                }
            }
        }

        public Area GetArea()
        {
            var instance = (IntPtr)ReadInt32(_playerIns);
            var playerCtrl = (IntPtr)ReadInt32(instance + 104);

            //var multiplayerAreaId = ReadInt32(playerCtrl + 0x354);
            var areaId = ReadInt32(playerCtrl + 0x358);

            if (areaId.TryParseEnum(out Area area))
            {
                return area;
            }

            return Area.NonInvadeableArea;
        }


        public int GetPlayerHealth()
        {
            return _hostPlayerGameData.ReadInt32(20); ;
        }

        public CovenantType GetCovenant()
        {
            var covenantId = _hostPlayerGameData.ReadInt32(275);
            if (covenantId.TryParseEnum(out CovenantType covenant))
            {
                return covenant;
            }

            return CovenantType.None;
        }

        public int GetClearCount()
        {
            return _gameDataManIns.ReadInt32(0x78);
        }

        #endregion

        #region Flags

        public bool CheckFlag(int flag)
        {
            return GetEventFlagState(flag);
        }

        private bool GetEventFlagState(int id)
        {
            if (GetEventFlagAddress(id, out int address, out uint mask))
            {
                uint flags = (uint)ReadInt32((IntPtr)address);

                return (flags & mask) != 0;
            }

            return false;
        }

        private bool GetEventFlagAddress(int id, out int address, out uint mask)
        {
            string idString = id.ToString("D8");

            if (idString.Length == 8)
            {
                string group = idString.Substring(0, 1);
                string area = idString.Substring(1, 3);
                int section = int.Parse(idString.Substring(4, 1));
                int number = int.Parse(idString.Substring(5, 3));

                if (_eventFlagGroups.ContainsKey(group) && _eventFlagAreas.ContainsKey(area))
                {
                    int offset = _eventFlagGroups[group];
                    offset += _eventFlagAreas[area] * 0x500;
                    offset += section * 128;
                    offset += (number - (number % 32)) / 8;

                    var basePtr = (IntPtr)ReadInt32(_flags);
                    address = ReadInt32((IntPtr)basePtr);
                    //address = ReadInt32((IntPtr)address);
                    address += offset;

                    mask = 0x80000000 >> (number % 32);

                    return true;
                }
            }

            address = 0;
            mask = 0;

            return false;
        }

        private readonly Dictionary<string, int> _eventFlagGroups = new Dictionary<string, int>
        {
            { "0", 0x00000 },
            { "1", 0x00500 },
            { "5", 0x05F00 },
            { "6", 0x0B900 },
            { "7", 0x11300 },
        };

        private readonly Dictionary<string, int> _eventFlagAreas = new Dictionary<string, int>
        {
            { "000", 00 },
            { "100", 01 },
            { "101", 02 },
            { "102", 03 },
            { "110", 04 },
            { "120", 05 },
            { "121", 06 },
            { "130", 07 },
            { "131", 08 },
            { "132", 09 },
            { "140", 10 },
            { "141", 11 },
            { "150", 12 },
            { "151", 13 },
            { "160", 14 },
            { "170", 15 },
            { "180", 16 },
            { "181", 17 },
        };

        #endregion

        #region data/lookup tables =======================================================================================================================================

        private struct Boss
        {
            public Boss(BossType bossType, int offset, int bit)
            {
                BossType = bossType;
                Offset = offset;
                Bit = bit;
            }

            public BossType BossType;
            public int Offset;
            public int Bit;
        }

        private readonly List<Boss> _bosses = new List<Boss>()
        {

            new Boss(BossType.AsylumDemon,          0x1   , 7),
            new Boss(BossType.TaurusDemon,          0xF73 , 2),
            new Boss(BossType.MoonlightButterfly,   0x1E73, 3),
            new Boss(BossType.Gargoyles,            0x3   , 4),
            new Boss(BossType.CapraDemon,           0xF73 , 1),
            new Boss(BossType.GapingDragon,         0x3   , 5),
            new Boss(BossType.StrayDemon,           0xF73 , 4),

            new Boss(BossType.Quelaag,              0x2   , 6),
            new Boss(BossType.CeaselessDischarge,   0x3C73, 3),
            new Boss(BossType.Firesage,             0x3C30, 5),
            new Boss(BossType.CentipedeDemon,       0x3C73, 2),
            new Boss(BossType.BedOfChaos,           0x2   , 5),

            new Boss(BossType.IronGolem,            0x2   , 4),
            new Boss(BossType.OrnsteinAndSmough,    0x2   , 3),
            new Boss(BossType.Gwyndolin,            0x4673, 3),
            new Boss(BossType.Priscilla,            0x3   , 3),

            new Boss(BossType.Sif,                  0x3   , 2),
            new Boss(BossType.FourKings,            0x2   , 2),

            new Boss(BossType.Gwyn,                 0x2   , 0),

            new Boss(BossType.Pinwheel,             0x3   , 1),
            new Boss(BossType.Nito,                 0x3   , 0),

            new Boss(BossType.Seath,                0x2   , 1),

            new Boss(BossType.Manus,                0x1   , 6),
            new Boss(BossType.Artorias,             0x2303, 6),
            new Boss(BossType.Kalameet,             0x2303, 3),
            new Boss(BossType.SanctuaryGuardian,    0x2303, 7),
        };

        private class Zone
        {
            public Zone(int world, int area, ZoneType zoneType)
            {
                World = world;
                Area = area;
                ZoneType = zoneType;
            }

            public int World;
            public int Area;
            public ZoneType ZoneType;
        }

        private readonly List<Zone> _zones = new List<Zone>()
        {
            new Zone(10, 0, ZoneType.Depths),
            new Zone(10, 1, ZoneType.UndeadBurgAndUndeadParish),
            new Zone(10, 2, ZoneType.Firelink),
            new Zone(11, 0, ZoneType.PaintedWorldOfAriamis),
            new Zone(12, 0, ZoneType.DarkrootGardenAndDarkrootBasin),
            new Zone(12, 1, ZoneType.EntireDlc),
            new Zone(13, 0, ZoneType.Catacombs),
            new Zone(13, 1, ZoneType.TombOfTheGiants),
            new Zone(13, 2, ZoneType.GreatHollowAndAshLake),
            new Zone(14, 0, ZoneType.BlightTownAndQuelaagsDomain),
            new Zone(14, 1, ZoneType.DemonRuinsAndLostIzalith),
            new Zone(15, 0, ZoneType.SensFortress),
            new Zone(15, 1, ZoneType.AnorLondo),
            new Zone(16, 0, ZoneType.NewLondoRuinsValleyofDrakesTheAbyss),
            new Zone(17, 0, ZoneType.DukesArchivesAndCrystalCave),
            new Zone(18, 0, ZoneType.FirelinkAltarAndKilnoftheFirstFlame),
            new Zone(18, 1, ZoneType.UndeadAsylum),
        };

        #endregion

#if DEBUG
        public int GetTestValue()
        {
            var instance = (IntPtr)ReadInt32(_playerIns);

            return instance.ToInt32();
        }

        public void SetCheat(CheatType cheatType, bool enabled)
        {
            if (TryScan(new byte?[]{ 0x80, 0x3D, null, null, null, null, 0x00, 0x48, 0x8b, 0x8f, null, null, null, null, 0x0f, 0xb6, 0xdb }, out IntPtr chrDbg))
            {
                chrDbg = chrDbg + ReadInt32(chrDbg + 2) + 7;
                var bytes = BitConverter.GetBytes(enabled);
                Write(chrDbg + (int)cheatType, bytes);
            }
        }


        //Warping code was stolen from Nordgaren, https://github.com/Nordgaren/DSR-Gadget-Local-Loader

        private const string BonfireWarpAssembly = @"0:  48 b9 fe fe fe fe fe    movabs rcx,0xfefefefefefefefe
7:  fe fe fe
a:  48 8b 09                mov    rcx,QWORD PTR [rcx]
d:  ba 01 00 00 00          mov    edx,0x1
12: 48 83 ec 38             sub    rsp,0x38
16: 49 be fe fe fe fe fe    movabs r14,0xfefefefefefefefe
1d: fe fe fe
20: 41 ff d6                call   r14
23: 48 83 c4 38             add    rsp,0x38
27: c3                      ret ";

        private IntPtr _bonfireWarp = IntPtr.Zero;
        private IntPtr _chrClassWarp = IntPtr.Zero;

        public void BonfireWarp(WarpType warpType)
        {
            if (_bonfireWarp == IntPtr.Zero)
            {
                TryScan(new byte?[] { 0x48, 0x89, 0x5C, 0x24, 0x08, 0x57, 0x48, 0x83, 0xEC, 0x20, 0x48, 0x8B, 0xD9, 0x8B, 0xFA, 0x48, 0x8B, 0x49, 0x08, 0x48, 0x85, 0xC9, 0x0F, 0x84, null, null, null, null, 0xE8, null, null, null, null, 0x48, 0x8B, 0x4B, 0x08 }, out _bonfireWarp);
            }

            if (_chrClassWarp == IntPtr.Zero)
            {
                if(TryScan(new byte?[]{ 0x48, 0x8B, 0x05, null, null, null, null, 0x66, 0x0F, 0x7F, 0x80, null, null, null, null, 0x0F, 0x28, 0x02, 0x66, 0x0F, 0x7F, 0x80, null, null, null, null, 0xC6, 0x80 }, out _chrClassWarp))
                {
                    _chrClassWarp = _chrClassWarp + ReadInt32(_chrClassWarp + 3) + 7;
                }
            }


            var chrClassWarpIns = (IntPtr)ReadInt32(_chrClassWarp);
            //var lastBonfire = (WarpType)ReadInt32(chrClassWarpIns + 0xB34);
            WriteInt32(chrClassWarpIns + 0xB34, (int)warpType);
            
            byte[] asm = AssemblyHelper.LoadDefuseOutput(BonfireWarpAssembly);
            byte[] bytes = BitConverter.GetBytes(_gameDataManIns.BaseAddress);
            Array.Copy(bytes, 0, asm, 0x2, 8);
            bytes = BitConverter.GetBytes(_bonfireWarp.ToInt64());
            Array.Copy(bytes, 0, asm, 0x18, 8);
            Execute(asm);
        }


        //Teleporting code was stolen from Nordgaren, https://github.com/Nordgaren/DSR-Gadget-Local-Loader
        public void Teleport(Vector3f position, float angle)
        {
            var instance = (IntPtr)ReadInt32(_playerIns);
            var playerCtrl = instance + 0x68;
            playerCtrl = (IntPtr)ReadInt32(playerCtrl);
            playerCtrl = (IntPtr)ReadInt32(playerCtrl + 104);

            WriteFloat(playerCtrl + 0x110, position.X);
            WriteFloat(playerCtrl + 0x114, position.Y);
            WriteFloat(playerCtrl + 0x118, position.Z);
            WriteFloat(playerCtrl + 0x124, angle.DegreeToRadians());
            var bytes = BitConverter.GetBytes(true);
            Write(playerCtrl + 0x108, bytes);
        }
#endif
    }
}
