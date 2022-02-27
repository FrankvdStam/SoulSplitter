using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls2.Vanilla
{
    internal class DS2Offsets
    {
        #region BaseA

        public const string BaseAAoB = "8B F1 8B 0D ? ? ? 01 8B 01 8B 50 28 FF D2 84 C0 74 0C";
        public const int BaseOffset1 = 0x4;
        public const int BaseOffset2 = 0x0;
        public const string BaseABabyJumpAoB = "49 BA ? ? ? ? ? ? ? ? 41 FF E2 90 74 2E";
        public const int BasePtrOffset1 = 0x3;
        public const int BasePtrOffset2 = 0x7;
        public const int PlayerTypeOffset = 0x90;
        public enum PlayerType
        {
            ChrNetworkPhantomId = 0x3C,
            TeamType = 0x3D,
            CharType = 0x48
        }
        public const int GameDataManagerOffset = 0x60;
        public enum PlayerName
        {
            Name = 0xA4
        }
        public enum ForceQuit
        {
            Quit = 0xDF1
        }

        public const string ItemGiveFunc = "55 8B EC 83 EC 10 53 8B 5D 0C 56 8B 75 08 57 53 56 8B F9";
        public const int AvailableItemBagOffset = 0x8;
        public const int ItemGiveWindowPointer = 0xCC4;
        public const string ItemStruct2dDisplay = "55 8B EC 8B 45 08 0F 57 C0 8B 4D 14 53";
        public const string DisplayItem = "55 8B EC 8B 49 6C 85 C9 74 06 5D";

        public const int PointerArrayOffset1 = 0x10;
        public const int PointerArrayOffset2 = 0x94;
        public const int PointerArrayOffset3 = 0x298;
        public const int PointerArrayOffset4 = 0x248;

        public const int PlayerBaseMiscOffset = 0x60;
        public enum PlayerBaseMisc
        {
            Class = 0x64,
            NewGame = 0x68,
            //SaveSlot = 0x18A8
        }
        public const int PlayerCtrlOffset = 0x74;
        public enum PlayerCtrl
        {
            HP = 0xFC,
            HPMin = 0x100,
            HPMax = 0x104,
            HPCap = 0x108,
            SP = 0x140,
            SPMax = 0x148,
            SpeedModifier = 0x208,
        }

        public const int EquipmentOffset1 = 0x2D4;
        public const int EquipmentOffset2 = 0x14;
        public enum PlayerEquipment
        {
            Legs = 0x1F8,
            Arms = 0x1DC,
            Chest = 0x1C0,
            Head = 0x1A4,
            RightHand1 = 0xC8,
            RightHand2 = 0xF4,
            RightHand3 = 0x120,
            LeftHand1 = 0x44,
            LeftHand2 = 0x70,
            LeftHand3 = 0x9C
        }

        public const int NetSvrBloodstainManagerOffset1 = 0x90;
        public const int NetSvrBloodstainManagerOffset2 = 0x28;
        public const int NetSvrBloodstainManagerOffset3 = 0x88;
        public enum NetSvrBloodstainManager
        {
            BloodstainY = 0x38,
            BloodstainZ = 0x3C,
            BloodstainX = 0x40
        }

        public const int PlayerParamOffset = 0x378;
        public enum PlayerParam
        {
            SoulMemory = 0xE8,
            SoulMemory2 = 0xF0,
            SoulMemory3 = 0xF8,
            MaxEquipLoad = 0x38,
            Souls = 0xE8,
            TotalDeaths = 0x1A0,
            HollowLevel = 0x1A8,
            SinnerLevel = 0x1D2,
            SinnerPoints = 0x1D3
        }
        public enum Attributes
        {
            SoulLevel = 0xCC,
            VGR = 0x4,
            END = 0x6,
            VIT = 0x8,
            ATN = 0xA,
            STR = 0xC,
            DEX = 0xE,
            ADP = 0x14,
            INT = 0x10,
            FTH = 0x12
        }
        public enum Covenants
        {
            CurrentCovenant = 0x1A9,
            HeirsOfTheSunDiscovered = 0x1AB,
            HeirsOfTheSunOfTheSunRank = 0x1B5,
            HeirsOfTheSunProgress = 0x1C0,
            BlueSentinelsDiscovered = 0x1AC,
            BlueSentinelsRank = 0x1B6,
            BlueSentinelsProgress = 0x1C2,
            BrotherhoodOfBloodDiscovered = 0x1AD, // possibly wrong (0x1AA alternative)
            BrotherhoodOfBloodRank = 0x1B7, // also possibly wrong (0x1B4 alternative)
            BrotherhoodOfBloodProgress = 0x1C4, // right I think (but maybe not) (0x1C7 alternative)
            WayOfTheBlueDiscovered = 0x1AE,
            WayOfTheBlueRank = 0x1B8,
            WayOfTheBlueProgress = 0x1C6,
            RatKingDiscovered = 0x1AF,
            RatKingRank = 0x1B9,
            RatKingProgress = 0x1C8,
            BellKeepersDiscovered = 0x1B0,
            BellKeepersRank = 0x1BA,
            BellKeepersProgress = 0x1CA,
            DragonRemnantsDiscovered = 0x1B1,
            DragonRemnantsRank = 0x1BB,
            DragonRemnantsProgress = 0x1CC,
            CompanyOfChampionsDiscovered = 0x1B2,
            CompanyOfChampionsRank = 0x1BC,
            CompanyOfChampionsProgress = 0x1CE,
            PilgrimsOfDarknessDiscovered = 0x1B3,
            PilgrimsOfDarknessRank = 0x1BD,
            PilgrimsOfDarknessProgress = 0x1D0
        }

        public const int PlayerPositionOffset1 = 0xB4;
        public const int PlayerPositionOffset2 = 0xA8;

        public enum PlayerPosition
        {
            PosY = 0x20,
            PosZ = 0x24,
            PosX = 0x28,
            AngY = 0x34,
            AngZ = 0x38,
            AngX = 0x3C
        }

        public const int GravityOffset1 = 0xB8;
        public const int GravityOffset2 = 0x8;
        public enum Gravity
        {
            Gravity = 0xFC
        }
        public const int PlayerMapDataOffset1 = 0x14;
        public const int PlayerMapDataOffset2 = 0x1B0;
        public const int PlayerMapDataOffset3 = 0x10;
        public enum PlayerMapData
        {
            WarpBase = 0x120,
            WarpY1 = 0x120,
            WarpZ1 = 0x124,
            WarpX1 = 0x128,
            WarpY2 = 0x130,
            WarpZ2 = 0x134,
            WarpX2 = 0x138,
            WarpY3 = 0x140,
            WarpZ3 = 0x144,
            WarpX3 = 0x148
        }

        public const int SpEffectCtrlOffset = 0x308;
        public const string ApplySpEffectAoB = "E9 ? ? ? ? 8B 45 F4 83 C0 01 89 45 F4 E9 ? ? ? ?";

        public const int CharacterFlagsOffset = 0x490;

        public const string GiveSoulsFuncAoB = "55 8B EC 8B 01 83 EC 08 85 C0 74 20 8B 80 94 00 00 00";

        public const string SetWarpTargetFuncAoB = "55 8B EC 83 EC 44 53 56 8B 75 0C 57 56 8D 4D 0C";
        public const string WarpFuncAoB = "55 8B EC 83 EC 40 53 56 8B 75 08 8B D9 57 B9 10 00 00 00";

        public const int EventManagerOffset = 0x44;
        public const int WarpManagerOffset = 0x2C;
        public enum Bonfire
        {
            LastSetBonfireAreaID = 0xB4,
            LastSetBonfire = 0xBC
        }
        public const int BonfireLevelsOffset = 0x10;
        public enum BonfireLevels
        {
            TheFarFire = 0x12,
            FireKeepersDwelling = 0x2,
            CrestfallensRetreat = 0x42,
            CardinalTower = 0x22,
            SoldiersRest = 0x32,
            ThePlaceUnbeknownst = 0x52,
            HeidesRuin = 0x322,
            TowerofFlame = 0x312,
            TheBlueCathedral = 0x332,
            UnseenPathtoHeide = 0x1B2,
            ExileHoldingCells = 0x102,
            McDuffsWorkshop = 0x132,
            ServantsQuarters = 0x142,
            StraidsCell = 0xF2,
            TheTowerApart = 0x112,
            TheSaltfort = 0x152,
            UpperRamparts = 0x122,
            UndeadRefuge = 0x242,
            BridgeApproach = 0x252,
            UndeadLockaway = 0x262,
            UndeadPurgatory = 0x272,
            PoisonPool = 0x182,
            TheMines = 0x162,
            LowerEarthenPeak = 0x172,
            CentralEarthenPeak = 0x192,
            UpperEarthenPeak = 0x1A2,
            ThresholdBridge = 0x1D2,
            IronhearthHall = 0x1C2,
            EygilsIdol = 0x1E2,
            BelfrySolApproach = 0x1F2,
            OldAkelarre = 0x302,
            RuinedForkRoad = 0x342,
            ShadedRuins = 0x352,
            GyrmsRespite = 0x362,
            OrdealsEnd = 0x372,
            RoyalArmyCampsite = 0xB2,
            ChapelThreshold = 0xC2,
            LowerBrightstoneCove = 0xA2,
            HarvalsRestingPlace = 0x392,
            GraveEntrance = 0x382,
            UpperGutter = 0x2D2,
            CentralGutter = 0x2B2,
            BlackGulchMouth = 0x2A2,
            HiddenChamber = 0x2C2,
            KingsGate = 0x202,
            ForgottenChamber = 0x222,
            UnderCastleDrangleic = 0x232,
            CentralCastleDrangleic = 0x212,
            TowerofPrayerAmana = 0x62,
            CrumbledRuins = 0x72,
            RhoysRestingPlace = 0x82,
            RiseoftheDead = 0x92,
            UndeadCryptEntrance = 0x292,
            UndeadDitch = 0x282,
            Foregarden = 0xD2,
            RitualSite = 0xE2,
            DragonAerie = 0x2E2,
            ShrineEntrance = 0x2F2,
            SanctumWalk = 0x3A2,
            TowerofPrayerShulva = 0x402,
            PriestessChamber = 0x3B2,
            HiddenSanctumChamber = 0x3D2,
            LairoftheImperfect = 0x3E2,
            SanctumInterior = 0x3F2,
            SanctumNadir = 0x3C2,
            ThroneFloor = 0x412,
            UpperFloor = 0x432,
            Foyer = 0x422,
            LowermostFloor = 0x452,
            TheSmelterThrone = 0x462,
            IronHallwayEntrance = 0x442,
            OuterWall = 0x472,
            AbandonedDwelling = 0x482,
            InnerWall = 0x4C2,
            LowerGarrison = 0x492,
            ExpulsionChamber = 0x4B2,
            GrandCathedral = 0x4A2
        }

        public const int BossKillCountersOffset1 = 0x44;
        public const int BossKillCountersOffset2 = 0x14;
        public const int BossKillCountersOffset3 = 0x10;
        public const int BossKillCountersOffset4 = 0x4;

        public const int AiManagerOffset1 = 0x20;
        public enum AiManagerOffsets
        {
            DisableAllAi = 0x18,
        }


        public const int EquipedWeaponsOffset1 = 0x74;
        public const int EquipedWeaponsOffset2 = 0x2d4;
        public const int EquipedWeaponsOffset3 = 0x14;
        public const int EquipedWeaponsOffset4 = 0x138;

        public enum EquipedWeaponsOffsets
        {
            RightHand1 = 0x0,
        }
        #endregion

        #region BaseB
        public const string BaseBAoB = "89 45 98 A1 ? ? ? ? 89 7D 9C 89 BD ? ? ? ? 85 C0";
        public enum Connection
        {
            ConnectionType = 0x54
        }

        #endregion

        #region FCData
        public const string CameraAoB = "60 02 2c f0 f3 7f 00 00";
        public const int CameraOffset1 = 0x0;
        public const int CameraOffset2 = 0x20;
        public const int CameraOffset3 = 0x28;
        public enum Camera
        {
            CamStart = 0x170,
            CamStart2 = 0x19C,
            CamStart3 = 0x1C,
            CamX = 0x1A0,
            CamZ = 0x1A4,
            CamY = 0x1A8
        }
        #endregion

        #region Param

        public enum Param
        {
            TotalParamLength = 0x0,
            ParamName = 0xC,
            TableLength = 0x30
        }

        public const int ParamDataOffset1 = 0x18;
        public const int ParamDataOffset2 = 0x154;
        public const int ParamDataOffset3 = 0x60;
        public const int ParamDataOffset4 = 0x94;

        public const int LevelUpSoulsParamOffset = 0x2B8;
        public const int WeaponParamOffset = 0x208;
        public enum WeaponParam
        {
            ReinforceID = 0x8
        }

        public const int WeaponReinforceParamOffset = 0x238;
        public enum WeaponReinforceParam
        {
            MaxUpgrade = 0x48,
            CustomAttrID = 0xE8
        }
        public const int CustomAttrSpecParamOffset = 0x270;

        public const int ArmorParamOffset = 0x4A0;
        public enum ArmorParam
        {
            ReinforceID = 0x8
        }
        public const int ArmorReinforceParamOffset = 0x258;
        public enum ArmorReinforceParam
        {
            MaxUpgrade = 0x60,
        }

        public const int ItemParamOffset = 0x10;
        public enum ItemParam
        {
            ItemUsageID = 0x44,
            MaxHeld = 0x4A
        }

        public const int ItemUsageParamOffset = 0x20;
        public enum ItemUasgeParam
        {
            Bitfield = 0x6
        }

        #endregion

        #region Internals
        public const string SpeedFactorAccelOffset = "F3 0F 10 8E 08 02 00 00 0F 5A C0 0F 5A C9";
        public const string SpeedFactorAnimOffset = "F3 0F 10 89 08 02 00 00 8B 89 B4 00 00 00 0F 5A C0 0F 5A C9 F2 0F 59 C8 0F 57 C0 66 0F 5A C1 F3 0F 10 4D F4 0F 5A C0 89";
        public const string SpeedFactorJumpOffset = "F3 0F 10 8E 08 02 00 00 0F 5A C0 0F 5A C9 F2 0F 59 C8 0F 57 C0 66 0F 5A C1 F3 0F 10 4D F4 0F 5A C0 0F 5A C9 F2 0F 59 C1 66 0F 5A C0 F3 0F 11 45 F4";
        public const string SpeedFactorBuildupOffset = "F3 0F 10 8E 08 02 00 00 0F 5A C0 0F 5A C9 F2 0F 59 C8 0F 57 C0 66 0F 5A C1 F3 0F 10 4D EC";

        #endregion
    }
}
