using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls2.Sotfs
{
    internal class DS2SOffsets
    {
        #region BaseA

        public const string BaseAAob = "48 8B 05 ? ? ? ? 48 8B 58 38 48 85 DB 74 ? F6";
        public const string BaseABabyJumpAoB = "49 BA ? ? ? ? ? ? ? ? 41 FF E2 90 74 2E";
        public const int BasePtrOffset1 = 0x3;
        public const int BasePtrOffset2 = 0x7;
        public const int PlayerTypeOffset = 0xB0;
        public enum PlayerType
        {
            ChrNetworkPhantomId = 0x3C,
            TeamType = 0x3D,
            CharType = 0x48
        }
        public const int PlayerNameOffset = 0xA8;
        public enum PlayerName
        {
            Name = 0x114
        }

        public enum ForceQuit
        {
            Quit = 0x24B1
        }

        public const string ItemGiveFunc = "48 89 5C 24 18 56 57 41 56 48 83 EC 30 45 8B F1 41";
        public const int AvailableItemBagOffset = 0x10;
        public const int ItemGiveWindowPointer = 0x22E0;
        public const string ItemStruct2dDisplay = "40 53 48 83 EC 20 45 33 D2 45 8B D8 48 8B D9 44 89 11";
        public const string DisplayItem = "48 8B 89 D8 00 00 00 48 85 C9 0F 85 40 5E 00 00";

        public const int PlayerBaseMiscOffset = 0xC0;
        public enum PlayerBaseMisc
        {
            Class = 0x64,
            NewGame = 0x68,
            SaveSlot = 0x18A8
        }
        public const int PlayerCtrlOffset = 0xD0;
        public enum PlayerCtrl
        {
            HP = 0x168,
            HPMin = 0x16C,
            HPMax = 0x170,
            HPCap = 0x174,
            SP = 0x1AC,
            SPMax = 0x1B4,
            SpeedModifier = 0x2A8,
        }

        public enum PlayerEquipment
        {
            Legs = 0x920,
            Arms = 0x90C,
            Chest = 0x8F8,
            Head = 0x8E4,
            RightHand1 = 0x880,
            RightHand2 = 0x8A8,
            RightHand3 = 0x8D0,
            LeftHand1 = 0x86C,
            LeftHand2 = 0x894,
            LeftHand3 = 0x8BC
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

        public const int PlayerParamOffset = 0x490;
        public enum PlayerParam
        {
            SoulMemory = 0xF4,
            SoulMemory2 = 0xFC,
            MaxEquipLoad = 0x3C,
            Souls = 0xEC,
            TotalDeaths = 0x1A4,
            HollowLevel = 0x1AC,
            SinnerLevel = 0x1D6,
            SinnerPoints = 0x1D7
        }

        public enum Attributes
        {
            SoulLevel = 0xD0,
            VGR = 0x8,
            END = 0xA,
            VIT = 0xC,
            ATN = 0xE,
            STR = 0x10,
            DEX = 0x12,
            ADP = 0x18,
            INT = 0x14,
            FTH = 0x16
        }

        public enum Covenants
        {
            CurrentCovenant = 0x1AD,
            HeirsOfTheSunDiscovered = 0x1AF,
            HeirsOfTheSunOfTheSunRank = 0x1B9,
            HeirsOfTheSunProgress = 0x1C4,
            BlueSentinelsDiscovered = 0x1B0,
            BlueSentinelsRank = 0x1BA,
            BlueSentinelsProgress = 0x1C6,
            BrotherhoodOfBloodDiscovered = 0x1B1,
            BrotherhoodOfBloodRank = 0x1BB,
            BrotherhoodOfBloodProgress = 0x1CB,
            WayOfTheBlueDiscovered = 0x1B2,
            WayOfTheBlueRank = 0x1BC,
            WayOfTheBlueProgress = 0x1CA,
            RatKingDiscovered = 0x1B3,
            RatKingRank = 0x1BD,
            RatKingProgress = 0x1CC,
            BellKeepersDiscovered = 0x1B4,
            BellKeepersRank = 0x1BE,
            BellKeepersProgress = 0x1CE,
            DragonRemnantsDiscovered = 0x1B5,
            DragonRemnantsRank = 0x1BF,
            DragonRemnantsProgress = 0x1D0,
            CompanyOfChampionsDiscovered = 0x1B6,
            CompanyOfChampionsRank = 0x1C0,
            CompanyOfChampionsProgress = 0x1D2,
            PilgrimsOfDarknessDiscovered = 0x1B7,
            PilgrimsOfDarknessRank = 0x1C1,
            PilgrimsOfDarknessProgress = 0x1D4
        }

        public const int PlayerPositionOffset1 = 0xF8;
        public const int PlayerPositionOffset2 = 0xF0;

        public enum PlayerPosition
        {
            PosY = 0x20,
            PosZ = 0x24,
            PosX = 0x28,
            AngY = 0x34,
            AngZ = 0x38,
            AngX = 0x3C
        }

        public const int PlayerMapDataOffset1 = 0x100;
        public enum Gravity
        {
            Gravity = 0x134
        }
        public const int PlayerMapDataOffset2 = 0x320;
        public const int PlayerMapDataOffset3 = 0x20;
        public enum PlayerMapData
        {
            WarpBase = 0x1A0,
            WarpY1 = 0x1A0,
            WarpZ1 = 0x1A4,
            WarpX1 = 0x1A8,
            WarpY2 = 0x1B0,
            WarpZ2 = 0x1B4,
            WarpX2 = 0x1B8,
            WarpY3 = 0x1C0,
            WarpZ3 = 0x1C4,
            WarpX3 = 0x1C8
        }

        public const int SpEffectCtrlOffset = 0x3E0;
        public const string ApplySpEffectAoB = "E9 ? ? ? ? E9 ? ? ? ? 50 5A 41 51 59";

        public const int CharacterFlagsOffset = 0x490;

        public const string GiveSoulsFuncAoB = "48 83 ec 28 48 8b 01 48 85 c0 74 23 48 8b 80 b8 00 00 00";

        public const string SetWarpTargetFuncAoB = "48 89 5C 24 08 48 89 74 24 20 57 48 83 EC 60 0F B7 FA";
        public const string WarpFuncAoB = "40 53 48 83 EC 60 8B 02 48 8B D9 89 01 8B 42 04";

        public const int EventManagerOffset = 0x70;
        public const int WarpManagerOffset = 0x70;
        public enum Bonfire
        {
            LastSetBonfireAreaID = 0x164,
            LastSetBonfire = 0x16C
        }
        public const int BonfireLevelsOffset1 = 0x58;
        public const int BonfireLevelsOffset2 = 0x20;
        public enum BonfireLevels
        {
            FireKeepersDwelling = 0x2,
            TheFarFire = 0x1A,
            CrestfallensRetreat = 0x62,
            CardinalTower = 0x32,
            SoldiersRest = 0x4A,
            ThePlaceUnbeknownst = 0x7A,
            HeidesRuin = 0x4B2,
            TowerofFlame = 0x49A,
            TheBlueCathedral = 0x4CA,
            UnseenPathtoHeide = 0x28A,
            ExileHoldingCells = 0x182,
            McDuffsWorkshop = 0x1CA,
            ServantsQuarters = 0x1E2,
            StraidsCell = 0x16A,
            TheTowerApart = 0x19A,
            TheSaltfort = 0x1FA,
            UpperRamparts = 0x1B2,
            UndeadRefuge = 0x362,
            BridgeApproach = 0x37A,
            UndeadLockaway = 0x392,
            UndeadPurgatory = 0x3AA,
            PoisonPool = 0x242,
            TheMines = 0x212,
            LowerEarthenPeak = 0x22A,
            CentralEarthenPeak = 0x25A,
            UpperEarthenPeak = 0x272,
            ThresholdBridge = 0x2BA,
            IronhearthHall = 0x2A2,
            EygilsIdol = 0x2D2,
            BelfrySolApproach = 0x2EA,
            OldAkelarre = 0x482,
            RuinedForkRoad = 0x4E2,
            ShadedRuins = 0x4FA,
            GyrmsRespite = 0x512,
            OrdealsEnd = 0x52A,
            RoyalArmyCampsite = 0x10A,
            ChapelThreshold = 0x122,
            LowerBrightstoneCove = 0xF2,
            HarvalsRestingPlace = 0x55A,
            GraveEntrance = 0x542,
            UpperGutter = 0x43A,
            CentralGutter = 0x40A,
            HiddenChamber = 0x422,
            BlackGulchMouth = 0x3F2,
            KingsGate = 0x302,
            UnderCastleDrangleic = 0x34A,
            ForgottenChamber = 0x332,
            CentralCastleDrangleic = 0x31A,
            TowerofPrayer = 0x92,
            CrumbledRuins = 0xAA,
            RhoysRestingPlace = 0xC2,
            RiseoftheDead = 0xDA,
            UndeadCryptEntrance = 0x3DA,
            UndeadDitch = 0x3C2,
            Foregarden = 0x13A,
            RitualSite = 0x152,
            DragonAerie = 0x452,
            ShrineEntrance = 0x46A,
            SanctumWalk = 0x572,
            PriestessChamber = 0x58A,
            HiddenSanctumChamber = 0x5BA,
            LairoftheImperfect = 0x5D2,
            SanctumInterior = 0x5EA,
            TowerofPrayerDLC = 0x602,
            SanctumNadir = 0x5A2,
            ThroneFloor = 0x61A,
            UpperFloor = 0x64A,
            Foyer = 0x632,
            LowermostFloor = 0x67A,
            TheSmelterThrone = 0x692,
            IronHallwayEntrance = 0x662,
            OuterWall = 0x6AA,
            AbandonedDwelling = 0x6C2,
            ExpulsionChamber = 0x70A,
            InnerWall = 0x722,
            LowerGarrison = 0x6DA,
            GrandCathedral = 0x6F2
        }

        public const int BossKillCountersOffset1 = 0x70;
        public const int BossKillCountersOffset2 = 0x28;
        public const int BossKillCountersOffset3 = 0x20;
        public const int BossKillCountersOffset4 = 0x8;

        public const int AiManagerOffset1 = 0x28;

        public enum AiManagerOffsets
        {
            DisableAllAi = 0x18,
        }

        public const int EquipedWeaponsOffset1 = 0xd0;
        public const int EquipedWeaponsOffset2 = 0x378;
        public const int EquipedWeaponsOffset3 = 0x28;

        public const int EquipedWeaponsRightHand1Offset = 0x158;
        public const int EquipedWeaponsLeftHand1Offset = 0x80;

        public enum EquipWeaponOffsets
        {
            RightHand1 = 0x0,
            LeftHand1 = 0x0,
        }

        #endregion

        #region BaseB
        public const string BaseBAoB = "48 8B 0D ? ? ? ? 48 85 C9 74 ? 48 8B 49 18 E8";
        public const int ConnectionOffset = 0x38;
        public enum Connection
        {
            Online = 0x8
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
            TableLength = 0x48
        }

        public const int ParamDataOffset1 = 0x18;
        public const int ParamDataOffset2 = 0xD8;
        public const int ParamDataOffset3 = 0xA8;

        public const int LevelUpSoulsParamOffset = 0x580;
        public const int WeaponParamOffset = 0x420;
        public enum WeaponParam
        {
            ReinforceID = 0x8
        }

        public const int WeaponReinforceParamOffset = 0x470;
        public enum WeaponReinforceParam
        {
            MaxUpgrade = 0x48,
            CustomAttrID = 0xE8
        }
        public const int CustomAttrSpecParamOffset = 0x4F0;

        public const int ArmorParamOffset = 0x4A0;
        public enum ArmorParam
        {
            ReinforceID = 0x8
        }
        public const int ArmorReinforceParamOffset = 0x4B0;
        public enum ArmorReinforceParam
        {
            MaxUpgrade = 0x60,
        }

        public const int ItemParamOffset = 0x20;
        public enum ItemParam
        {
            ItemUsageID = 0x44,
            MaxHeld = 0x4A
        }

        public const int ItemUsageParamOffset1 = 0x40;
        public const int ItemUsageParamOffset2 = 0xD8;
        public enum ItemUasgeParam
        {
            Bitfield = 0x6
        }

        #endregion

        #region Internals
        public const string SpeedFactorAccelOffset = "F3 0F 59 9F A8 02 00 00 F3 0F 10 16";
        public const string SpeedFactorAnimOffset = "F3 0F 59 99 A8 02 00 00";
        public const string SpeedFactorJumpOffset = "F3 0F 59 99 A8 02 00 00 F3 0F 10 12 F3 0F 10 42 04 48 8B 89 E0 00 00 00";
        public const string SpeedFactorBuildupOffset = "F3 0F 59 99 A8 02 00 00 F3 0F 10 12 F3 0F 10 42 04 48 8B 89 E8 03 00 00";

        #endregion
    }
}
