using PropertyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SoulMemory.Shared;
using SoulMemory.Native;
using Kernel32 = PropertyHook.Kernel32;

namespace SoulMemory.DarkSouls2.Sotfs
{
    public class DarkSouls2SotfsHook : PHook, INotifyPropertyChanged, IDarkSouls2
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public IntPtr BaseAddress => Process?.MainModule.BaseAddress ?? IntPtr.Zero;
        public string ID => Process?.Id.ToString() ?? "Not Hooked";

        private string _version;
        public string Version 
        { 
            get =>_version;
            private set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }

        public static bool Reading { get; set; }

        private PHPointer BaseASetup;
        private PHPointer GiveSoulsFunc;
        private PHPointer ItemGiveFunc;
        private PHPointer ItemStruct2dDisplay;
        private PHPointer DisplayItem;
        private PHPointer SetWarpTargetFunc;
        private PHPointer WarpManager;
        private PHPointer WarpFunc;

        private PHPointer BaseA;
        private PHPointer PlayerName;
        private PHPointer AvailableItemBag;
        private PHPointer ItemGiveWindow;
        private PHPointer PlayerBaseMisc;
        private PHPointer PlayerCtrl;
        private PHPointer PlayerPosition;
        private PHPointer PlayerGravity;
        private PHPointer PlayerParam;
        private PHPointer PlayerType;
        private PHPointer SpEffectCtrl;
        private PHPointer ApplySpEffect;
        private PHPointer PlayerMapData;
        private PHPointer EventManager;
        private PHPointer BonfireLevels;
        private PHPointer NetSvrBloodstainManager;
        private PHPointer BossKillCounters;
        private PHPointer AiManager;

        private PHPointer LevelUpSoulsParam;
        private PHPointer WeaponParam;
        private PHPointer WeaponReinforceParam;
        private PHPointer CustomAttrSpecParam;
        private PHPointer ArmorReinforceParam;
        private PHPointer ItemParam;
        private PHPointer ItemUseageParam;

        private PHPointer BaseBSetup;
        private PHPointer BaseB;
        private PHPointer Connection;

        private PHPointer Camera;
        private PHPointer Camera2;
        private PHPointer Camera3;
        private PHPointer Camera4;
        private PHPointer Camera5;

        private PHPointer SpeedFactorAccel;
        private PHPointer SpeedFactorAnim;
        private PHPointer SpeedFactorJump;
        private PHPointer SpeedFactorBuildup;

        //Cheaty
        private PHPointer RightHand1DamageMultiplierPtr;
        private PHPointer LeftHand1DamageMultiplierPtr;

        public bool Loaded => PlayerCtrl != null && PlayerCtrl.Resolve() != IntPtr.Zero;
        public bool Setup = false;

        public bool Focused => Hooked && User32.GetForegroundProcessID() == Process.Id;

        public DarkSouls2SotfsHook(int refreshInterval, int minLifetime) : base(refreshInterval, minLifetime, p => p.MainWindowTitle == "DARK SOULS II")
        {
            Version = "Not Hooked";
            BaseASetup = RegisterAbsoluteAOB(DS2SOffsets.BaseAAob);
            SpeedFactorAccel = RegisterAbsoluteAOB(DS2SOffsets.SpeedFactorAccelOffset);
            SpeedFactorAnim = RegisterAbsoluteAOB(DS2SOffsets.SpeedFactorAnimOffset);
            SpeedFactorJump = RegisterAbsoluteAOB(DS2SOffsets.SpeedFactorJumpOffset);
            SpeedFactorBuildup = RegisterAbsoluteAOB(DS2SOffsets.SpeedFactorBuildupOffset);
            GiveSoulsFunc = RegisterAbsoluteAOB(DS2SOffsets.GiveSoulsFuncAoB);
            ItemGiveFunc = RegisterAbsoluteAOB(DS2SOffsets.ItemGiveFunc);
            ItemStruct2dDisplay = RegisterAbsoluteAOB(DS2SOffsets.ItemStruct2dDisplay);
            DisplayItem = RegisterAbsoluteAOB(DS2SOffsets.DisplayItem); 
            SetWarpTargetFunc = RegisterAbsoluteAOB(DS2SOffsets.SetWarpTargetFuncAoB);
            ApplySpEffect = RegisterAbsoluteAOB(DS2SOffsets.ApplySpEffectAoB);
            WarpFunc = RegisterAbsoluteAOB(DS2SOffsets.WarpFuncAoB);

            BaseBSetup = RegisterAbsoluteAOB(DS2SOffsets.BaseBAoB);
            
            OnHooked += DS2Hook_OnHooked;
            OnUnhooked += DS2Hook_OnUnhooked;
        }
        private void DS2Hook_OnHooked(object sender, PHEventArgs e)
        {
            if (!Is64Bit)
            {
                Version = "Vanilla (Wrong)";
                return;
            }

            Version = "Scholar";

            BaseA = CreateBasePointer(BasePointerFromSetupPointer(BaseASetup));
            if (BaseA.Resolve() == IntPtr.Zero)
            {
                BaseASetup = RegisterAbsoluteAOB(DS2SOffsets.BaseABabyJumpAoB);
                RescanAOB();
                BaseA = CreateBasePointer(BasePointerFromSetupBabyJ(BaseASetup));
                Version = "BabyJump Dll";
            }

            PlayerName = CreateChildPointer(BaseA, (int)DS2SOffsets.PlayerNameOffset);
            AvailableItemBag = CreateChildPointer(PlayerName, (int)DS2SOffsets.AvailableItemBagOffset, (int)DS2SOffsets.AvailableItemBagOffset);
            ItemGiveWindow = CreateChildPointer(BaseA, (int)DS2SOffsets.ItemGiveWindowPointer);
            PlayerBaseMisc = CreateChildPointer(PlayerName, (int)DS2SOffsets.PlayerBaseMiscOffset);
            PlayerCtrl = CreateChildPointer(BaseA, (int)DS2SOffsets.PlayerCtrlOffset);
            PlayerPosition = CreateChildPointer(PlayerCtrl, (int)DS2SOffsets.PlayerPositionOffset1, (int)DS2SOffsets.PlayerPositionOffset2);
            PlayerGravity = CreateChildPointer(PlayerCtrl, (int)DS2SOffsets.PlayerMapDataOffset1);
            PlayerParam = CreateChildPointer(PlayerCtrl, (int)DS2SOffsets.PlayerParamOffset);
            PlayerType = CreateChildPointer(PlayerCtrl, (int)DS2SOffsets.PlayerTypeOffset);
            SpEffectCtrl = CreateChildPointer(PlayerCtrl, (int)DS2SOffsets.SpEffectCtrlOffset);
            PlayerMapData = CreateChildPointer(PlayerGravity, (int)DS2SOffsets.PlayerMapDataOffset2, (int)DS2SOffsets.PlayerMapDataOffset3);
            EventManager = CreateChildPointer(BaseA, (int)DS2SOffsets.EventManagerOffset);
            BonfireLevels = CreateChildPointer(EventManager, (int)DS2SOffsets.BonfireLevelsOffset1, (int)DS2SOffsets.BonfireLevelsOffset2);
            WarpManager = CreateChildPointer(EventManager, (int)DS2SOffsets.WarpManagerOffset);
            NetSvrBloodstainManager = CreateChildPointer(BaseA, (int)DS2SOffsets.NetSvrBloodstainManagerOffset1, (int)DS2SOffsets.NetSvrBloodstainManagerOffset2, (int)DS2SOffsets.NetSvrBloodstainManagerOffset3);
            BossKillCounters = CreateChildPointer(BaseA, DS2SOffsets.BossKillCountersOffset1, DS2SOffsets.BossKillCountersOffset2, DS2SOffsets.BossKillCountersOffset3, DS2SOffsets.BossKillCountersOffset4);
            AiManager = CreateChildPointer(BaseA, DS2SOffsets.AiManagerOffset1);
            RightHand1DamageMultiplierPtr = CreateChildPointer(BaseA, DS2SOffsets.EquipedWeaponsOffset1, DS2SOffsets.EquipedWeaponsOffset2, DS2SOffsets.EquipedWeaponsOffset3, DS2SOffsets.EquipedWeaponsRightHand1Offset);
            LeftHand1DamageMultiplierPtr  = CreateChildPointer(BaseA, DS2SOffsets.EquipedWeaponsOffset1, DS2SOffsets.EquipedWeaponsOffset2, DS2SOffsets.EquipedWeaponsOffset3, DS2SOffsets.EquipedWeaponsLeftHand1Offset);


            LevelUpSoulsParam = CreateChildPointer(BaseA, (int)DS2SOffsets.ParamDataOffset1, (int)DS2SOffsets.LevelUpSoulsParamOffset, (int)DS2SOffsets.ParamDataOffset2);
            WeaponParam = CreateChildPointer(BaseA, (int)DS2SOffsets.ParamDataOffset1, (int)DS2SOffsets.WeaponParamOffset, (int)DS2SOffsets.ParamDataOffset2);
            WeaponReinforceParam = CreateChildPointer(BaseA, (int)DS2SOffsets.ParamDataOffset1, (int)DS2SOffsets.WeaponReinforceParamOffset, (int)DS2SOffsets.ParamDataOffset2);
            CustomAttrSpecParam = CreateChildPointer(BaseA, (int)DS2SOffsets.ParamDataOffset1, (int)DS2SOffsets.CustomAttrSpecParamOffset, (int)DS2SOffsets.ParamDataOffset2);
            ArmorReinforceParam = CreateChildPointer(BaseA, (int)DS2SOffsets.ParamDataOffset1, (int)DS2SOffsets.ArmorReinforceParamOffset, (int)DS2SOffsets.ParamDataOffset2);
            ItemParam = CreateChildPointer(BaseA, (int)DS2SOffsets.ParamDataOffset3, (int)DS2SOffsets.ItemParamOffset, (int)DS2SOffsets.ParamDataOffset2);
            ItemUseageParam = CreateChildPointer(BaseA, (int)DS2SOffsets.ParamDataOffset3, (int)DS2SOffsets.ItemUsageParamOffset1, (int)DS2SOffsets.ItemUsageParamOffset2);

            BaseB = CreateBasePointer(BasePointerFromSetupPointer(BaseBSetup));
            Connection = CreateChildPointer(BaseB, (int)DS2SOffsets.ConnectionOffset);

            Camera = CreateBasePointer(Handle + 0x160B8D0, (int)DS2SOffsets.CameraOffset1);
            Camera2 = CreateChildPointer(Camera, (int)DS2SOffsets.CameraOffset2);
            Camera3 = CreateChildPointer(BaseA, (int)DS2SOffsets.CameraOffset2, (int)DS2SOffsets.CameraOffset2);
            Camera4 = CreateChildPointer(BaseA, (int)DS2SOffsets.CameraOffset2, (int)DS2SOffsets.CameraOffset3);
            Camera5 = CreateChildPointer(BaseA, (int)DS2SOffsets.CameraOffset2);

            

            GetLevelRequirements();
            WeaponParamOffsetDict = BuildOffsetDictionary(WeaponParam, "WEAPON_PARAM");
            WeaponReinforceParamOffsetDict = BuildOffsetDictionary(WeaponReinforceParam, "WEAPON_REINFORCE_PARAM");
            CustomAttrOffsetDict = BuildOffsetDictionary(CustomAttrSpecParam, "CUSTOM_ATTR_SPEC_PARAM");
            ArmorReinforceParamOffsetDict = BuildOffsetDictionary(ArmorReinforceParam, "ARMOR_REINFORCE_PARAM");
            ItemParamOffsetDict = BuildOffsetDictionary(ItemParam, "ITEM_PARAM");
            ItemUsageParamOffsetDict = BuildOffsetDictionary(ItemUseageParam, "ITEM_USAGE_PARAM");
            UpdateStatsProperties();
            GetSpeedhackOffsets(SpeedhackDllPath);
            Setup = true;
        }

      
        private void DS2Hook_OnUnhooked(object sender, PHEventArgs e)
        {
            Version = "Not Hooked";
            Setup = false;
        }
        public void UpdateName()
        {
            OnPropertyChanged(nameof(Name));
        }

        public void UpdateMainProperties()
        {
            OnPropertyChanged(nameof(ID));
            OnPropertyChanged(nameof(Online));
            //OnPropertyChanged(nameof(LastBonfireObj));
        }


        public void UpdateStatsProperties()
        {
            OnPropertyChanged(nameof(SoulLevel));
            OnPropertyChanged(nameof(Souls));
            OnPropertyChanged(nameof(SoulMemory));
            OnPropertyChanged(nameof(SoulMemory2));
            OnPropertyChanged(nameof(HollowLevel));
            OnPropertyChanged(nameof(SinnerLevel));
            OnPropertyChanged(nameof(SinnerPoints));
            OnPropertyChanged(nameof(Vigor));
            OnPropertyChanged(nameof(Endurance));
            OnPropertyChanged(nameof(Vitality));
            OnPropertyChanged(nameof(Attunement));
            OnPropertyChanged(nameof(Strength));
            OnPropertyChanged(nameof(Dexterity));
            OnPropertyChanged(nameof(Adaptability));
            OnPropertyChanged(nameof(Intelligence));
            OnPropertyChanged(nameof(Faith));
        }

        public void UpdatePlayerProperties()
        {
            OnPropertyChanged(nameof(Health));
            OnPropertyChanged(nameof(HealthMax));
            OnPropertyChanged(nameof(HealthCap));
            OnPropertyChanged(nameof(Stamina));
            OnPropertyChanged(nameof(MaxStamina));
            OnPropertyChanged(nameof(TeamType));
            OnPropertyChanged(nameof(CharType));
            OnPropertyChanged(nameof(PosX));
            OnPropertyChanged(nameof(PosY));
            OnPropertyChanged(nameof(PosZ));
            OnPropertyChanged(nameof(AngX));
            OnPropertyChanged(nameof(AngY));
            OnPropertyChanged(nameof(AngZ));
            OnPropertyChanged(nameof(Collision));
            OnPropertyChanged(nameof(Gravity));
            OnPropertyChanged(nameof(StableX));
            OnPropertyChanged(nameof(StableY));
            OnPropertyChanged(nameof(StableZ));
            OnPropertyChanged(nameof(LastBonfireAreaId));
        }

        public void UpdateBonfireProperties()
        {
            OnPropertyChanged(nameof(FireKeepersDwelling));
            OnPropertyChanged(nameof(TheFarFire));
            OnPropertyChanged(nameof(TheCrestfallensRetreat));
            OnPropertyChanged(nameof(CardinalTower));
            OnPropertyChanged(nameof(SoldiersRest));
            OnPropertyChanged(nameof(ThePlaceUnbeknownst));
            OnPropertyChanged(nameof(HeidesRuin));
            OnPropertyChanged(nameof(TowerofFlame));
            OnPropertyChanged(nameof(TheBlueCathedral));
            OnPropertyChanged(nameof(UnseenPathtoHeide));
            OnPropertyChanged(nameof(ExileHoldingCells));
            OnPropertyChanged(nameof(McDuffsWorkshop));
            OnPropertyChanged(nameof(ServantsQuarters));
            OnPropertyChanged(nameof(StraidsCell));
            OnPropertyChanged(nameof(TheTowerApart));
            OnPropertyChanged(nameof(TheSaltfort));
            OnPropertyChanged(nameof(UpperRamparts));
            OnPropertyChanged(nameof(UndeadRefuge));
            OnPropertyChanged(nameof(BridgeApproach));
            OnPropertyChanged(nameof(UndeadLockaway));
            OnPropertyChanged(nameof(UndeadPurgatory));
            OnPropertyChanged(nameof(PoisonPool));
            OnPropertyChanged(nameof(TheMines));
            OnPropertyChanged(nameof(LowerEarthenPeak));
            OnPropertyChanged(nameof(CentralEarthenPeak));
            OnPropertyChanged(nameof(UpperEarthenPeak));
            OnPropertyChanged(nameof(ThresholdBridge));
            OnPropertyChanged(nameof(IronhearthHall));
            OnPropertyChanged(nameof(EygilsIdol));
            OnPropertyChanged(nameof(BelfrySolApproach));
            OnPropertyChanged(nameof(OldAkelarre));
            OnPropertyChanged(nameof(RuinedForkRoad));
            OnPropertyChanged(nameof(ShadedRuins));
            OnPropertyChanged(nameof(GyrmsRespite));
            OnPropertyChanged(nameof(OrdealsEnd));
            OnPropertyChanged(nameof(RoyalArmyCampsite));
            OnPropertyChanged(nameof(ChapelThreshold));
            OnPropertyChanged(nameof(LowerBrightstoneCove));
            OnPropertyChanged(nameof(HarvalsRestingPlace));
            OnPropertyChanged(nameof(GraveEntrance));
            OnPropertyChanged(nameof(UpperGutter));
            OnPropertyChanged(nameof(CentralGutter));
            OnPropertyChanged(nameof(HiddenChamber));
            OnPropertyChanged(nameof(BlackGulchMouth));
            OnPropertyChanged(nameof(KingsGate));
            OnPropertyChanged(nameof(UnderCastleDrangleic));
            OnPropertyChanged(nameof(ForgottenChamber));
            OnPropertyChanged(nameof(CentralCastleDrangleic));
            OnPropertyChanged(nameof(TowerofPrayer));
            OnPropertyChanged(nameof(CrumbledRuins));
            OnPropertyChanged(nameof(RhoysRestingPlace));
            OnPropertyChanged(nameof(RiseoftheDead));
            OnPropertyChanged(nameof(UndeadCryptEntrance));
            OnPropertyChanged(nameof(UndeadDitch));
            OnPropertyChanged(nameof(Foregarden));
            OnPropertyChanged(nameof(RitualSite));
            OnPropertyChanged(nameof(DragonAerie));
            OnPropertyChanged(nameof(ShrineEntrance));
            OnPropertyChanged(nameof(SanctumWalk));
            OnPropertyChanged(nameof(PriestessChamber));
            OnPropertyChanged(nameof(HiddenSanctumChamber));
            OnPropertyChanged(nameof(LairoftheImperfect));
            OnPropertyChanged(nameof(SanctumInterior));
            OnPropertyChanged(nameof(TowerofPrayer));
            OnPropertyChanged(nameof(SanctumNadir));
            OnPropertyChanged(nameof(ThroneFloor));
            OnPropertyChanged(nameof(UpperFloor));
            OnPropertyChanged(nameof(Foyer));
            OnPropertyChanged(nameof(LowermostFloor));
            OnPropertyChanged(nameof(TheSmelterThrone));
            OnPropertyChanged(nameof(IronHallwayEntrance));
            OnPropertyChanged(nameof(OuterWall));
            OnPropertyChanged(nameof(AbandonedDwelling));
            OnPropertyChanged(nameof(ExpulsionChamber));
            OnPropertyChanged(nameof(InnerWall));
            OnPropertyChanged(nameof(LowerGarrison));
            OnPropertyChanged(nameof(GrandCathedral));
        }

        public void UpdateCovenantProperties()
        {
            OnPropertyChanged(nameof(CurrentCovenant));
            OnPropertyChanged(nameof(CurrentCovenantName));
            OnPropertyChanged(nameof(HeirsOfTheSunDiscovered));
            OnPropertyChanged(nameof(HeirsOfTheSunRank));
            OnPropertyChanged(nameof(HeirsOfTheSunProgress));
            OnPropertyChanged(nameof(BlueSentinelsDiscovered));
            OnPropertyChanged(nameof(BlueSentinelsRank));
            OnPropertyChanged(nameof(BlueSentinelsProgress));
            OnPropertyChanged(nameof(BrotherhoodOfBloodDiscovered));
            OnPropertyChanged(nameof(BrotherhoodOfBloodRank));
            OnPropertyChanged(nameof(BrotherhoodOfBloodProgress));
            OnPropertyChanged(nameof(WayOfTheBlueDiscovered));
            OnPropertyChanged(nameof(WayOfTheBlueRank));
            OnPropertyChanged(nameof(WayOfTheBlueProgress));
            OnPropertyChanged(nameof(RatKingDiscovered));
            OnPropertyChanged(nameof(RatKingRank));
            OnPropertyChanged(nameof(RatKingProgress));
            OnPropertyChanged(nameof(BellKeepersDiscovered));
            OnPropertyChanged(nameof(BellKeepersRank));
            OnPropertyChanged(nameof(BellKeepersProgress));
            OnPropertyChanged(nameof(DragonRemnantsDiscovered));
            OnPropertyChanged(nameof(DragonRemnantsRank));
            OnPropertyChanged(nameof(DragonRemnantsProgress));
            OnPropertyChanged(nameof(CompanyOfChampionsDiscovered));
            OnPropertyChanged(nameof(CompanyOfChampionsRank));
            OnPropertyChanged(nameof(CompanyOfChampionsProgress));
            OnPropertyChanged(nameof(PilgrimsOfDarknessDiscovered));
            OnPropertyChanged(nameof(PilgrimsOfDarknessRank));
            OnPropertyChanged(nameof(PilgrimsOfDarknessProgress));
        }
        public void UpdateInternalProperties()
        {
            OnPropertyChanged(nameof(Head));
            OnPropertyChanged(nameof(Chest));
            OnPropertyChanged(nameof(Arms));
            OnPropertyChanged(nameof(Legs));
            OnPropertyChanged(nameof(RightHand1));
            OnPropertyChanged(nameof(RightHand2));
            OnPropertyChanged(nameof(RightHand3));
            OnPropertyChanged(nameof(LeftHand1));
            OnPropertyChanged(nameof(LeftHand2));
            OnPropertyChanged(nameof(LeftHand3));
            OnPropertyChanged(nameof(EnableSpeedFactors));
        }

        public IntPtr BasePointerFromSetupPointer(PHPointer pointer)
        {
            var readInt = pointer.ReadInt32(DS2SOffsets.BasePtrOffset1);
            return pointer.ReadIntPtr(readInt + DS2SOffsets.BasePtrOffset2);
        }

        public IntPtr BasePointerFromSetupBabyJ(PHPointer pointer)
        {
            return pointer.ReadIntPtr(0x0121D4D0 + DS2SOffsets.BasePtrOffset2);
        }

        public byte FastQuit
        {
            set
            {
                BaseA.WriteByte((int)DS2SOffsets.ForceQuit.Quit, value);
            }
        }

        #region Player
        public int Health
        {
            get => Loaded ? PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerCtrl.HP) : 0;
            set 
            {
                if (Reading || !Loaded) return;
                PlayerCtrl.WriteInt32((int)DS2SOffsets.PlayerCtrl.HP, value);
            }
        }
        public int HealthMax
        {
            get => Loaded ? PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerCtrl.HPMax) : 0;
            set => PlayerCtrl.WriteInt32((int)DS2SOffsets.PlayerCtrl.HPMax, value);
        }
        public int HealthCap
        {
            get 
            {
                if (!Loaded) return 0;
                var cap = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerCtrl.HPCap);
                return cap < HealthMax ? cap : HealthMax;
            }
            set => PlayerCtrl.WriteInt32((int)DS2SOffsets.PlayerCtrl.HPCap, value);
        }
        public float Stamina
        {
            get => Loaded ? PlayerCtrl.ReadSingle((int)DS2SOffsets.PlayerCtrl.SP) : 0;
            set 
            { 
                if (Reading || !Loaded) return;
                PlayerCtrl.WriteSingle((int)DS2SOffsets.PlayerCtrl.SP, value);
            }
        }
        public float MaxStamina
        {
            get => Loaded ? PlayerCtrl.ReadSingle((int)DS2SOffsets.PlayerCtrl.SPMax) : 0;
            set => PlayerCtrl.WriteSingle((int)DS2SOffsets.PlayerCtrl.SPMax, value);
        }
        public byte NetworkPhantomID
        {
            get => Loaded ? PlayerType.ReadByte((int)DS2SOffsets.PlayerType.ChrNetworkPhantomId) : (byte)0;
            set => PlayerType.WriteByte((int)DS2SOffsets.PlayerType.ChrNetworkPhantomId, value);
        }
        public byte TeamType
        {
            get => Loaded ? PlayerType.ReadByte((int)DS2SOffsets.PlayerType.TeamType) : (byte)0;
            //set => PlayerType.WriteByte((int)DS2SOffsets.PlayerType.TeamType, value);
        }
        public byte CharType
        {
            get => Loaded ? PlayerType.ReadByte((int)DS2SOffsets.PlayerType.CharType) : (byte)0;
            //set => PlayerType.WriteByte((int)DS2SOffsets.PlayerType.CharType, value);
        }
        public float PosX
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2SOffsets.PlayerPosition.PosX) : 0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerPosition.WriteSingle((int)DS2SOffsets.PlayerPosition.PosX, value);
            }
        }
        public float PosY
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2SOffsets.PlayerPosition.PosY) : 0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerPosition.WriteSingle((int)DS2SOffsets.PlayerPosition.PosY, value);
            }
        }
        public float PosZ
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2SOffsets.PlayerPosition.PosZ) : 0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerPosition.WriteSingle((int)DS2SOffsets.PlayerPosition.PosZ, value);
            }
        }
        public float AngX
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2SOffsets.PlayerPosition.AngX) : 0;
            set => PlayerPosition.WriteSingle((int)DS2SOffsets.PlayerPosition.AngX, value);
        }
        public float AngY
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2SOffsets.PlayerPosition.AngY) : 0;
            set => PlayerPosition.WriteSingle((int)DS2SOffsets.PlayerPosition.AngY, value);
        }
        public float AngZ
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2SOffsets.PlayerPosition.AngZ) : 0;
            set => PlayerPosition.WriteSingle((int)DS2SOffsets.PlayerPosition.AngZ, value);
        }
        public float StableX
        {
            get => Loaded ? PlayerMapData.ReadSingle((int)DS2SOffsets.PlayerMapData.WarpX1) : 0;
            set
            {
                PlayerMapData.WriteSingle((int)DS2SOffsets.PlayerMapData.WarpX1, value);
                PlayerMapData.WriteSingle((int)DS2SOffsets.PlayerMapData.WarpX2, value);
                PlayerMapData.WriteSingle((int)DS2SOffsets.PlayerMapData.WarpX3, value);
            }
        }
        public float StableY
        {
            get => Loaded ? PlayerMapData.ReadSingle((int)DS2SOffsets.PlayerMapData.WarpY1) : 0;
            set
            {
                PlayerMapData.WriteSingle((int)DS2SOffsets.PlayerMapData.WarpY1, value);
                PlayerMapData.WriteSingle((int)DS2SOffsets.PlayerMapData.WarpY2, value);
                PlayerMapData.WriteSingle((int)DS2SOffsets.PlayerMapData.WarpY3, value);
            }
        }
        public float StableZ
        {
            get => Loaded ? PlayerMapData.ReadSingle((int)DS2SOffsets.PlayerMapData.WarpZ1) : 0;
            set
            {
                PlayerMapData.WriteSingle((int)DS2SOffsets.PlayerMapData.WarpZ1, value);
                PlayerMapData.WriteSingle((int)DS2SOffsets.PlayerMapData.WarpZ2, value);
                PlayerMapData.WriteSingle((int)DS2SOffsets.PlayerMapData.WarpZ3, value);
            }
        }
        public float BloodstainX
        {
            get => NetSvrBloodstainManager.ReadSingle((int)DS2SOffsets.NetSvrBloodstainManager.BloodstainX);
        }
        public float BloodstainY
        {
            get => NetSvrBloodstainManager.ReadSingle((int)DS2SOffsets.NetSvrBloodstainManager.BloodstainY);
        }
        public float BloodstainZ
        {
            get => NetSvrBloodstainManager.ReadSingle((int)DS2SOffsets.NetSvrBloodstainManager.BloodstainZ);
        }
        public byte[] CameraData
        {
            get => Camera5.ReadBytes((int)0xE9C, 64);
            set => Camera5.WriteBytes((int)0xE9C, value);
        }
        public byte[] CameraData2
        {
            get => Camera4.ReadBytes((int)DS2SOffsets.Camera.CamStart3, 512);
            set => Camera4.WriteBytes((int)DS2SOffsets.Camera.CamStart3, value);
        }
        public float CamX
        {
            get => Camera2.ReadSingle((int)DS2SOffsets.Camera.CamX);
            set => Camera2.WriteSingle((int)DS2SOffsets.Camera.CamX, value);
        }
        public float CamY
        {
            get => Camera2.ReadSingle((int)DS2SOffsets.Camera.CamY);
            set => Camera2.WriteSingle((int)DS2SOffsets.Camera.CamY, value);
        }
        public float CamZ
        {
            get => Camera2.ReadSingle((int)DS2SOffsets.Camera.CamZ);
            set => Camera2.WriteSingle((int)DS2SOffsets.Camera.CamZ, value);
        }
        public float Speed
        {
            set 
            {
                if (!Loaded) return;
                PlayerCtrl.WriteSingle((int)DS2SOffsets.PlayerCtrl.SpeedModifier, value); 
            }
        }
        public bool Gravity
        {
            get => Loaded ? !PlayerGravity.ReadBoolean((int)DS2SOffsets.Gravity.Gravity) : true;
            set => PlayerGravity.WriteBoolean((int)DS2SOffsets.Gravity.Gravity, !value);
        }
        public bool Collision
        {
            get => Loaded ? NetworkPhantomID != 18 && NetworkPhantomID != 19 : true;
            set
            {
                if (Reading || !Loaded) return;
                if (value)
                    NetworkPhantomID = 0;
                else
                    NetworkPhantomID = 18;
            }
        }
        public ushort LastBonfireId
        {
            get => Loaded ? EventManager.ReadUInt16((int)DS2SOffsets.Bonfire.LastSetBonfire) : (ushort)0;
            set => EventManager.WriteUInt16((int)DS2SOffsets.Bonfire.LastSetBonfire, value);
        }
        public int LastBonfireAreaId
        {
            get => Loaded ? EventManager.ReadInt32((int)DS2SOffsets.Bonfire.LastSetBonfireAreaID) : 0;
            set => EventManager.WriteInt32((int)DS2SOffsets.Bonfire.LastSetBonfireAreaID, value);
        }
        public bool Multiplayer => Loaded ? ConnectionType > 1 : true;
        public bool Online => Loaded ? ConnectionType > 0 : true;
        public int ConnectionType => Hooked && Connection != null ? Connection.ReadInt32((int)DS2SOffsets.Connection.Online) : 0;
        public bool Warp(ushort id, bool rest = false)
        {
            if (rest)
            {
                ApplySpecialEffect(110000010);
            }

            var value = Allocate(sizeof(short));
            Kernel32.WriteBytes(Handle, value, BitConverter.GetBytes(id));

            var asm = (byte[])DS2SAssembly.BonfireWarp.Clone();
            var bytes = BitConverter.GetBytes(value.ToInt64());
            Array.Copy(bytes, 0x0, asm, 0x9, bytes.Length);
            bytes = BitConverter.GetBytes(SetWarpTargetFunc.Resolve().ToInt64());
            Array.Copy(bytes, 0x0, asm, 0x21, bytes.Length);
            bytes = BitConverter.GetBytes(WarpManager.Resolve().ToInt64());
            Array.Copy(bytes, 0x0, asm, 0x2E, bytes.Length);
            bytes = BitConverter.GetBytes(WarpFunc.Resolve().ToInt64());
            Array.Copy(bytes, 0x0, asm, 0x3B, bytes.Length);

            var warped = false;
            if (!Multiplayer)
            {
                Execute(asm);
                warped = true;
            }

            Free(value);
            return warped;
        }

        public void Warp(WarpType warpType, bool rest = false)
        {
            var bonfire = Data.Bonfires.First(i => i.WarpType == warpType);
            LastBonfireId = bonfire.BonfireId;
            LastBonfireAreaId = bonfire.AreaId;
            Warp(bonfire.BonfireId, rest);
        }

        internal void ApplySpecialEffect(int spEffect)
        {
            var effectStruct = Allocate(0x16);
            Kernel32.WriteBytes(Handle, effectStruct, BitConverter.GetBytes(spEffect));
            Kernel32.WriteBytes(Handle, effectStruct + 0x4, BitConverter.GetBytes(0x1));
            Kernel32.WriteBytes(Handle, effectStruct + 0xC, BitConverter.GetBytes(0x219));

            var unk = Allocate(sizeof(float));
            Kernel32.WriteBytes(Handle, unk, BitConverter.GetBytes(-1f));

            var asm = (byte[])DS2SAssembly.ApplySpecialEffect.Clone();
            var bytes = BitConverter.GetBytes(effectStruct.ToInt64());
            Array.Copy(bytes, 0x0, asm, 0x6, bytes.Length);
            bytes = BitConverter.GetBytes(SpEffectCtrl.Resolve().ToInt64());
            Array.Copy(bytes, 0x0, asm, 0x10, bytes.Length);
            bytes = BitConverter.GetBytes(unk.ToInt64());
            Array.Copy(bytes, 0x0, asm, 0x1A, bytes.Length);
            bytes = BitConverter.GetBytes(ApplySpEffect.Resolve().ToInt64());
            Array.Copy(bytes, 0x0, asm, 0x2E, bytes.Length);

            Execute(asm);
            Free(effectStruct);
            Free(unk);
        }

        //TODO: fix resources
        static string SpeedhackDllPath = "";//$"{GetTxtResourceClass.ExeDir}/Resources/DLLs/Speedhack.dll";
        public IntPtr SpeedhackDllPtr;
        IntPtr SetupPtr;
        IntPtr SetSpeedPtr;
        IntPtr DetachPtr;
        internal void Speedhack(bool enable)
        {
            if (enable)
                EnableSpeedhack();
            else
                DisableSpeedhack();
        }

        public void DisableSpeedhack()
        {
            IntPtr detach = (IntPtr)(SpeedhackDllPtr.ToInt64() + DetachPtr.ToInt64());
            Kernel32.CreateRemoteThread(Handle, IntPtr.Zero, 0, detach, IntPtr.Zero, 0, IntPtr.Zero);
        }

        private void EnableSpeedhack()
        {
            IntPtr thread = IntPtr.Zero;
            if (SpeedhackDllPtr == IntPtr.Zero)
            {
                SpeedhackDllPtr = InjectDLL(SpeedhackDllPath);
            }

            IntPtr setup = (IntPtr)(SpeedhackDllPtr.ToInt64() + SetupPtr.ToInt64());
            thread = Kernel32.CreateRemoteThread(Handle, IntPtr.Zero, 0, setup, IntPtr.Zero, 0, IntPtr.Zero);
            Kernel32.WaitForSingleObject(thread, uint.MaxValue);

            //TODO fix properties
            //SetSpeed((float)Properties.Settings.Default.SpeedValue);
            SetSpeed(2.0f);
        }

        public void SetSpeed(float value)
        {
            IntPtr setSpeed = (IntPtr)(SpeedhackDllPtr.ToInt64() + SetSpeedPtr.ToInt64());
            IntPtr valueAddress = GetPrefferedIntPtr(sizeof(float), SpeedhackDllPtr);
            Kernel32.WriteBytes(Handle, valueAddress, BitConverter.GetBytes(value));
            var thread = Kernel32.CreateRemoteThread(Handle, IntPtr.Zero, 0, setSpeed, valueAddress, 0, IntPtr.Zero);
            Kernel32.WaitForSingleObject(thread, uint.MaxValue);
            Free(valueAddress);
        }

        private void GetSpeedhackOffsets(string path)
        {
            var lib = Kernel32.LoadLibrary(path);
            var setupOffset = Kernel32.GetProcAddress(lib, "Setup").ToInt64() - lib.ToInt64();
            var setSpeedOffset = Kernel32.GetProcAddress(lib, "SetSpeed").ToInt64() - lib.ToInt64();
            var detachOffset = Kernel32.GetProcAddress(lib, "Detach").ToInt64() - lib.ToInt64();
            SetupPtr = (IntPtr)setupOffset;
            SetSpeedPtr = (IntPtr)setSpeedOffset;
            DetachPtr = (IntPtr)detachOffset;
            Free(lib);
        }

        #endregion

        #region Stats
        public string Name
        {
            get => Loaded ? PlayerName.ReadString((int)DS2SOffsets.PlayerName.Name, Encoding.Unicode, 0x22) : "";
            set
            {
                if (Reading || !Loaded) return;
                if (Name == value) return;
                PlayerName.WriteString((int)DS2SOffsets.PlayerName.Name, Encoding.Unicode, 0x22, value);
                OnPropertyChanged(nameof(Name));
            }
        }

        public byte Class
        {
            get => Loaded ? PlayerBaseMisc.ReadByte((int)DS2SOffsets.PlayerBaseMisc.Class) : (byte)255;
            set
            {
                if (Reading || !Loaded) return;
                PlayerBaseMisc.WriteByte((int)DS2SOffsets.PlayerBaseMisc.Class, value);
            }
        }
        public int SoulLevel
        {
            get => Loaded ? PlayerParam.ReadInt32((int)DS2SOffsets.Attributes.SoulLevel) : 0;
            set => PlayerParam.WriteInt32((int)DS2SOffsets.Attributes.SoulLevel, value);
        }
        public int SoulMemory
        {
            get => Loaded ? PlayerParam.ReadInt32((int)DS2SOffsets.PlayerParam.SoulMemory) : 0;
            set => PlayerParam.WriteInt32((int)DS2SOffsets.PlayerParam.SoulMemory, value);
        }
        public int SoulMemory2
        {
            get => Loaded ? PlayerParam.ReadInt32((int)DS2SOffsets.PlayerParam.SoulMemory2) : 0;
            set => PlayerParam.WriteInt32((int)DS2SOffsets.PlayerParam.SoulMemory2, value);
        }
        public byte SinnerLevel
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.PlayerParam.SinnerLevel) : (byte)0;
            set => PlayerParam.WriteByte((int)DS2SOffsets.PlayerParam.SinnerLevel, value);
        }
        public byte SinnerPoints
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.PlayerParam.SinnerPoints) : (byte)0;
            set => PlayerParam.WriteByte((int)DS2SOffsets.PlayerParam.SinnerPoints, value);
        }
        public byte HollowLevel
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.PlayerParam.HollowLevel) : (byte)0;
            set => PlayerParam.WriteByte((int)DS2SOffsets.PlayerParam.HollowLevel, value);
        }
        public int Souls
        {
            get => Loaded ? PlayerParam.ReadInt32((int)DS2SOffsets.PlayerParam.Souls) : 0;
        }

        public short Vigor
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Attributes.VGR) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Attributes.VGR, value);
                UpdateSoulLevel();
            }
        }
        public short Endurance
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Attributes.END) : (short)0;
            set 
            { 
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Attributes.END, value);
                UpdateSoulLevel();
            }
        }
        public short Vitality
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Attributes.VIT) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Attributes.VIT, value);
                UpdateSoulLevel();
            }
        }
        public short Attunement
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Attributes.ATN) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Attributes.ATN, value);
                UpdateSoulLevel();
            }
        }
        public short Strength
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Attributes.STR) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Attributes.STR, value);
                UpdateSoulLevel();
            }
        }
        public short Dexterity
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Attributes.DEX) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Attributes.DEX, value);
                UpdateSoulLevel();
            }
        }
        public short Adaptability
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Attributes.ADP) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Attributes.ADP, value);
                UpdateSoulLevel();
            }
        }
        public short Intelligence
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Attributes.INT) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Attributes.INT, value);
                UpdateSoulLevel();
            }
        }
        public short Faith
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Attributes.FTH) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Attributes.FTH, value);
                UpdateSoulLevel();
            }
        }
        public void GiveSouls(int souls)
        {
            var asm = (byte[])DS2SAssembly.AddSouls.Clone();

            var bytes = BitConverter.GetBytes(PlayerParam.Resolve().ToInt64());
            Array.Copy(bytes, 0, asm, 0x6, 8);
            bytes = BitConverter.GetBytes(souls);
            Array.Copy(bytes, 0, asm, 0x11, 4);
            bytes = BitConverter.GetBytes(GiveSoulsFunc.Resolve().ToInt64());
            Array.Copy(bytes, 0, asm, 0x17, 8);
            Execute(asm);
        }
        private void UpdateSoulLevel()
        {
            var charClass = DS2SClass.All.FirstOrDefault(c => c.ID == Class);
            if (charClass == null) return;

            var soulLevel = GetSoulLevel(charClass);
            SoulLevel = soulLevel;
            var reqSoulMemory = GetRequiredSoulMemory(soulLevel, charClass.SoulLevel);
            if (reqSoulMemory > SoulMemory)
            {
                SoulMemory = reqSoulMemory;
                SoulMemory2 = reqSoulMemory;
            }
        }
        private int GetSoulLevel(DS2SClass charClass)
        {
            int sl = charClass.SoulLevel;
            sl += Vigor - charClass.Vigor;
            sl += Attunement - charClass.Attunement;
            sl += Vitality - charClass.Vitality;
            sl += Endurance - charClass.Endurance;
            sl += Strength - charClass.Strength;
            sl += Dexterity - charClass.Dexterity;
            sl += Adaptability - charClass.Adaptability;
            sl += Intelligence - charClass.Intelligence;
            sl += Faith - charClass.Faith;
            return sl;
        }
        public void ResetSoulMemory()
        {
            var charClass = DS2SClass.All.FirstOrDefault(c => c.ID == Class);
            if (charClass == null) return;

            var soulLevel = GetSoulLevel(charClass);
            var reqSoulMemory = GetRequiredSoulMemory(soulLevel, charClass.SoulLevel);

            SoulMemory = reqSoulMemory;
            SoulMemory2 = reqSoulMemory;
        }
        private int GetRequiredSoulMemory(int SL, int baseSL)
        {
            int soulMemory = 0;
            for (int i = baseSL; i < SL; i++)
            {
                var index = i <= 850 ? i : 850;
                soulMemory += Levels[index];
            }
            return soulMemory;
        }

        public static List<int> Levels;
        private void GetLevelRequirements()
        {
            Levels = new List<int>();
            var paramName = LevelUpSoulsParam.ReadString(0xC, Encoding.UTF8, 0x18);
            if (paramName != "CHR_LEVEL_UP_SOULS_PARAM")
                throw new InvalidOperationException("Incorrect Param Pointer: LEVEL_UP_SOULS_PARAM");

            var tableLength = LevelUpSoulsParam.ReadInt32((int)DS2SOffsets.Param.TableLength);
            var paramID = 0x40;
            var paramOffset = 0x48;
            var nextParam = 0x18;
            var slOffset = 0x8;

            while (paramID < tableLength)
            {
                var soulReqOffset = LevelUpSoulsParam.ReadInt32(paramOffset);
                var soulReq = LevelUpSoulsParam.ReadInt32(soulReqOffset + slOffset);
                Levels.Add(soulReq);

                paramID += nextParam;
                paramOffset += nextParam;
            }
        }

        #endregion

        #region Wasted

        public int GetBossKillCount(BossType bossType)
        {
            return BossKillCounters.ReadInt32((int)bossType);
        }

        public bool DisableAllAi
        {
            get => AiManager.ReadBoolean((int)DS2SOffsets.AiManagerOffsets.DisableAllAi);
            set => AiManager.WriteBoolean((int)DS2SOffsets.AiManagerOffsets.DisableAllAi, value);
        }
        
        //GameManagerImp 0xD0 -> PlayerCtrl 0x378 -> ChrAsmCtrl -> ? 0x28 -> ? 0x158/0x80 ? + weapon offset
        public float RightWeapon1DamageMultiplier
        {
            get => RightHand1DamageMultiplierPtr.ReadSingle((int)DS2SOffsets.EquipWeaponOffsets.RightHand1);
            set => RightHand1DamageMultiplierPtr.WriteSingle((int)DS2SOffsets.EquipWeaponOffsets.RightHand1, value);
        }

        public float LeftWeapon1DamageMultiplier
        {
            get => LeftHand1DamageMultiplierPtr.ReadSingle((int)DS2SOffsets.EquipWeaponOffsets.LeftHand1);
            set => LeftHand1DamageMultiplierPtr.WriteSingle((int)DS2SOffsets.EquipWeaponOffsets.LeftHand1, value);
        }

        #endregion

        #region Items
        public void GetItem(int item, short amount, byte upgrade, byte infusion, bool silent)
        {
            if (silent)
                GiveItemSilently(item, amount, upgrade, infusion);
            else
                GiveItem(item, amount, upgrade, infusion);
        }

        private void GiveItem(int item, short amount, byte upgrade, byte infusion)
        {
            var itemStruct = Allocate(0x8A);

            Kernel32.WriteBytes(Handle, itemStruct + 0x4, BitConverter.GetBytes(item));
            Kernel32.WriteBytes(Handle, itemStruct + 0x8, BitConverter.GetBytes(float.MaxValue));
            Kernel32.WriteBytes(Handle, itemStruct + 0xC, BitConverter.GetBytes(amount));
            Kernel32.WriteByte(Handle, itemStruct + 0xE, upgrade);
            Kernel32.WriteByte(Handle, itemStruct + 0xF, infusion);

            var asm = (byte[])DS2SAssembly.GetItem.Clone();

            var bytes = BitConverter.GetBytes(0x1);
            Array.Copy(bytes, 0, asm, 0x9, 4);
            bytes = BitConverter.GetBytes(itemStruct.ToInt64());
            Array.Copy(bytes, 0, asm, 0xF, 8);
            bytes = BitConverter.GetBytes(AvailableItemBag.Resolve().ToInt64());
            Array.Copy(bytes, 0, asm, 0x1C, 8);
            bytes = BitConverter.GetBytes(ItemGiveFunc.Resolve().ToInt64());
            Array.Copy(bytes, 0, asm, 0x29, 8);
            bytes = BitConverter.GetBytes(0x1);
            Array.Copy(bytes, 0, asm, 0x36, 4);
            bytes = BitConverter.GetBytes(itemStruct.ToInt64());
            Array.Copy(bytes, 0, asm, 0x3C, 8);
            bytes = BitConverter.GetBytes(ItemStruct2dDisplay.Resolve().ToInt64());
            Array.Copy(bytes, 0, asm, 0x54, 8);
            bytes = BitConverter.GetBytes(ItemGiveWindow.Resolve().ToInt64());
            Array.Copy(bytes, 0, asm, 0x66, 8);
            bytes = BitConverter.GetBytes(DisplayItem.Resolve().ToInt64());
            Array.Copy(bytes, 0, asm, 0x70, 8);

            Execute(asm);
            Free(itemStruct);
        }

        private void GiveItemSilently(int item, short amount, byte upgrade, byte infusion)
        {
            var itemStruct = Allocate(0x8A);
            Kernel32.WriteBytes(Handle, itemStruct + 0x4, BitConverter.GetBytes(item));
            Kernel32.WriteBytes(Handle, itemStruct + 0x8, BitConverter.GetBytes(float.MaxValue));
            Kernel32.WriteBytes(Handle, itemStruct + 0xC, BitConverter.GetBytes(amount));
            Kernel32.WriteByte(Handle, itemStruct + 0xE, upgrade);
            Kernel32.WriteByte(Handle, itemStruct + 0xF, infusion);

            var asm = (byte[])DS2SAssembly.GetItemNoMenu.Clone();

            var bytes = BitConverter.GetBytes(0x1);
            Array.Copy(bytes, 0, asm, 0x6, 4);
            bytes = BitConverter.GetBytes(itemStruct.ToInt64());
            Array.Copy(bytes, 0, asm, 0xC, 8);
            bytes = BitConverter.GetBytes(AvailableItemBag.Resolve().ToInt64());
            Array.Copy(bytes, 0, asm, 0x19, 8);
            bytes = BitConverter.GetBytes(ItemGiveFunc.Resolve().ToInt64());
            Array.Copy(bytes, 0, asm, 0x26, 8);

            Execute(asm);
            Free(itemStruct);
        }
        #endregion

        #region Params

        private static Dictionary<int, int> WeaponParamOffsetDict;
        private static Dictionary<int, int> WeaponReinforceParamOffsetDict;
        private static Dictionary<int, int> CustomAttrOffsetDict;
        private static Dictionary<int, int> ArmorReinforceParamOffsetDict;
        private static Dictionary<int, int> ItemParamOffsetDict;
        private static Dictionary<int, int> ItemUsageParamOffsetDict;


        private Dictionary<int, int> BuildOffsetDictionary(PHPointer pointer, string expectedParamName)
        {
            var dictionary = new Dictionary<int, int>();
            var paramName = pointer.ReadString((int)DS2SOffsets.Param.ParamName, Encoding.UTF8, 0x18);
            if (paramName != expectedParamName)
                throw new InvalidOperationException($"Incorrect Param Pointer: {expectedParamName}");

            var tableLength = pointer.ReadInt32((int)DS2SOffsets.Param.TableLength);
            var param = 0x40;
            var paramID = 0x0;
            var paramOffset = 0x8;
            var nextParam = 0x18;

            while (param < tableLength)
            {
                var itemID = pointer.ReadInt32(param + paramID);
                var itemParamOffset = pointer.ReadInt32(param + paramOffset);
                dictionary.Add(itemID, itemParamOffset);

                param += nextParam;
            }

            return dictionary;
        }
        internal int GetMaxUpgrade(DS2SItem item)
        {
            switch (item.Type)
            {
                case DS2SItem.ItemType.Weapon:
                    return GetWeaponMaxUpgrade(item.ID);
                case DS2SItem.ItemType.Armor:
                    return GetArmorMaxUpgrade(item.ID);
                case DS2SItem.ItemType.Item:
                case DS2SItem.ItemType.Ring:
                    return 0;
            }

            return 0;
        }
        internal int GetMaxQuantity(DS2SItem item)
        {
            switch (item.Type)
            {
                case DS2SItem.ItemType.Ring:
                case DS2SItem.ItemType.Weapon:
                case DS2SItem.ItemType.Armor:
                    return 1;
                case DS2SItem.ItemType.Item:
                    return GetMaxItemQuantity(item.ID);
            }

            return 0;
        }
        internal int GetHeld(DS2SItem item)
        {
            switch (item.Type)
            {
                case DS2SItem.ItemType.Ring:
                case DS2SItem.ItemType.Weapon:
                case DS2SItem.ItemType.Armor:
                    return 0;
                case DS2SItem.ItemType.Item:
                    return GetHeldInInventory(item.ID);
            }

            return 0;
        }
        
        private int GetHeldInInventory(int id)
        {
            var inventorySlot = 0x30;
            var itemOffset = 0x0;
            var boxOffset = 0x4;
            var heldOffset = 0x8;
            var nextOffset = 0x10;

            var endPointer = AvailableItemBag.ReadIntPtr(0x10).ToInt64();
            var bagSize = endPointer - AvailableItemBag.Resolve().ToInt64();

            var inventory = AvailableItemBag.ReadBytes(0x0, (uint)bagSize);

            while (inventorySlot < bagSize)
            {
                var itemID = BitConverter.ToInt32(inventory, inventorySlot + itemOffset);
                if (itemID != id)
                {
                    inventorySlot += nextOffset;
                    continue;
                }
                var boxValue = BitConverter.ToInt32(inventory, inventorySlot + boxOffset);
                var held = BitConverter.ToInt32(inventory, inventorySlot + heldOffset);

                if (itemID == id)
                    if (boxValue == 0)
                        return held;

                inventorySlot += nextOffset;
            }

            //while (inventorySlot < bagSize)
            //{
            //    var itemID = AvailableItemBag.ReadInt32(inventorySlot + itemOffset);
            //    var boxValue = AvailableItemBag.ReadInt32(inventorySlot + boxOffset);
            //    var held = AvailableItemBag.ReadInt32(inventorySlot + heldOffset);

            //    if (itemID == id)
            //        if (boxValue == 0)
            //            return held;

            //    inventorySlot += nextOffset;
            //}

            return 0;
        }
        private int GetArmorMaxUpgrade(int id)
        {
            if  (!Setup) return 0;
            return ArmorReinforceParam.ReadInt32(ArmorReinforceParamOffsetDict[id - 10000000] + (int)DS2SOffsets.ArmorReinforceParam.MaxUpgrade);
        }
        private int GetWeaponMaxUpgrade(int id)
        {
            if (!Setup) return 0;
            var reinforceParamID = WeaponParam.ReadInt32(WeaponParamOffsetDict[id] + (int)DS2SOffsets.WeaponParam.ReinforceID);
            return WeaponReinforceParam.ReadInt32(WeaponReinforceParamOffsetDict[reinforceParamID] + (int)DS2SOffsets.WeaponReinforceParam.MaxUpgrade);
        }
        private int GetMaxItemQuantity(int id)
        {
            if (!Setup) return 0;
            return ItemParam.ReadInt16(ItemParamOffsetDict[id] + (int)DS2SOffsets.ItemParam.MaxHeld);
        }

        internal List<DS2SInfusion> GetWeaponInfusions(int id)
        {
            var infusions = new List<DS2SInfusion>() { DS2SInfusion.Infusions[0] };
            var reinforceParamID = WeaponParam.ReadInt32(WeaponParamOffsetDict[id] + (int)DS2SOffsets.WeaponParam.ReinforceID);
            var customAttrID = WeaponReinforceParam.ReadInt32(WeaponReinforceParamOffsetDict[reinforceParamID] + (int)DS2SOffsets.WeaponReinforceParam.CustomAttrID);
            var bitField = CustomAttrSpecParam.ReadInt32(CustomAttrOffsetDict[customAttrID]);

            if (bitField == 0)
                return infusions;

            for (int i = 1; i < DS2SInfusion.Infusions.Count; i++)
            {
                if ((bitField & (1 << i)) != 0)
                    infusions.Add(DS2SInfusion.Infusions[i]);
            }

            return infusions;
        }
        internal bool GetIsDroppable(int id)
        {
            if (!Setup) return false;
            var itemUsageID = ItemParam.ReadInt32(ItemParamOffsetDict[id] + (int)DS2SOffsets.ItemParam.ItemUsageID);
            byte bitField = ItemUseageParam.ReadByte(ItemUsageParamOffsetDict[itemUsageID] + (int)DS2SOffsets.ItemUasgeParam.Bitfield);

            if (bitField == 0)
                return false;

            return (bitField & 4) != 0;
        }

        #endregion

        #region Bonfires
        public byte FireKeepersDwelling
        {
            get 
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.FireKeepersDwelling);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.FireKeepersDwelling, level);
            }
        }

        public byte TheFarFire
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.TheFarFire);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.TheFarFire, level);
            }
        }
        public byte TheCrestfallensRetreat
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.CrestfallensRetreat);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.CrestfallensRetreat, level);
            }
        }
        public byte CardinalTower
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.CardinalTower);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.CardinalTower, level);
            }
        }
        public byte SoldiersRest
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.SoldiersRest);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.SoldiersRest, level);
            }
        }
        public byte ThePlaceUnbeknownst
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.ThePlaceUnbeknownst);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.ThePlaceUnbeknownst, level);
            }
        }
        public byte HeidesRuin
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.HeidesRuin);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.HeidesRuin, level);
            }
        }
        public byte TowerofFlame
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.TowerofFlame);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.TowerofFlame, level);
            }
        }
        public byte TheBlueCathedral
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.TheBlueCathedral);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.TheBlueCathedral, level);
            }
        }
        public byte UnseenPathtoHeide
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UnseenPathtoHeide);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UnseenPathtoHeide, level);
            }
        }
        public byte ExileHoldingCells
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.ExileHoldingCells);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.ExileHoldingCells, level);
            }
        }
        public byte McDuffsWorkshop
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.McDuffsWorkshop);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.McDuffsWorkshop, level);
            }
        }
        public byte ServantsQuarters
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.ServantsQuarters);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.ServantsQuarters, level);
            }
        }
        public byte StraidsCell
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.StraidsCell);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.StraidsCell, level);
            }
        }
        public byte TheTowerApart
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.TheTowerApart);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.TheTowerApart, level);
            }
        }
        public byte TheSaltfort
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.TheSaltfort);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.TheSaltfort, level);
            }
        }
        public byte UpperRamparts
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UpperRamparts);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UpperRamparts, level);
            }
        }
        public byte UndeadRefuge
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UndeadRefuge);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UndeadRefuge, level);
            }
        }
        public byte BridgeApproach
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.BridgeApproach);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.BridgeApproach, level);
            }
        }
        public byte UndeadLockaway
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UndeadLockaway);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UndeadLockaway, level);
            }
        }
        public byte UndeadPurgatory
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UndeadPurgatory);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UndeadPurgatory, level);
            }
        }
        public byte PoisonPool
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.PoisonPool);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.PoisonPool, level);
            }
        }
        public byte TheMines
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.TheMines);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.TheMines, level);
            }
        }
        public byte LowerEarthenPeak
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.LowerEarthenPeak);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.LowerEarthenPeak, level);
            }
        }
        public byte CentralEarthenPeak
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.CentralEarthenPeak);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.CentralEarthenPeak, level);
            }
        }
        public byte UpperEarthenPeak
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UpperEarthenPeak);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UpperEarthenPeak, level);
            }
        }
        public byte ThresholdBridge
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.ThresholdBridge);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.ThresholdBridge, level);
            }
        }
        public byte IronhearthHall
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.IronhearthHall);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.IronhearthHall, level);
            }
        }
        public byte EygilsIdol
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.EygilsIdol);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.EygilsIdol, level);
            }
        }
        public byte BelfrySolApproach
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.BelfrySolApproach);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.BelfrySolApproach, level);
            }
        }
        public byte OldAkelarre
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.OldAkelarre);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.OldAkelarre, level);
            }
        }
        public byte RuinedForkRoad
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.RuinedForkRoad);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.RuinedForkRoad, level);
            }
        }
        public byte ShadedRuins
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.ShadedRuins);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.ShadedRuins, level);
            }
        }
        public byte GyrmsRespite
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.GyrmsRespite);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.GyrmsRespite, level);
            }
        }
        public byte OrdealsEnd
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.OrdealsEnd);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.OrdealsEnd, level);
            }
        }
        public byte RoyalArmyCampsite
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.RoyalArmyCampsite);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.RoyalArmyCampsite, level);
            }
        }
        public byte ChapelThreshold
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.ChapelThreshold);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.ChapelThreshold, level);
            }
        }
        public byte LowerBrightstoneCove
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.LowerBrightstoneCove);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.LowerBrightstoneCove, level);
            }
        }
        public byte HarvalsRestingPlace
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.HarvalsRestingPlace);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.HarvalsRestingPlace, level);
            }
        }
        public byte GraveEntrance
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.GraveEntrance);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.GraveEntrance, level);
            }
        }
        public byte UpperGutter
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UpperGutter);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UpperGutter, level);
            }
        }
        public byte CentralGutter
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.CentralGutter);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.CentralGutter, level);
            }
        }
        public byte HiddenChamber
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.HiddenChamber);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.HiddenChamber, level);
            }
        }
        public byte BlackGulchMouth
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.BlackGulchMouth);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.BlackGulchMouth, level);
            }
        }
        public byte KingsGate
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.KingsGate);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.KingsGate, level);
            }
        }
        public byte UnderCastleDrangleic
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UnderCastleDrangleic);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UnderCastleDrangleic, level);
            }
        }
        public byte ForgottenChamber
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.ForgottenChamber);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.ForgottenChamber, level);
            }
        }
        public byte CentralCastleDrangleic
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.CentralCastleDrangleic);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.CentralCastleDrangleic, level);
            }
        }
        public byte TowerofPrayer
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.TowerofPrayer);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.TowerofPrayer, level);
            }
        }
        public byte CrumbledRuins
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.CrumbledRuins);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.CrumbledRuins, level);
            }
        }
        public byte RhoysRestingPlace
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.RhoysRestingPlace);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.RhoysRestingPlace, level);
            }
        }
        public byte RiseoftheDead
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.RiseoftheDead);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.RiseoftheDead, level);
            }
        }
        public byte UndeadCryptEntrance
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UndeadCryptEntrance);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UndeadCryptEntrance, level);
            }
        }
        public byte UndeadDitch
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UndeadDitch);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UndeadDitch, level);
            }
        }
        public byte Foregarden
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.Foregarden);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.Foregarden, level);
            }
        }
        public byte RitualSite
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.RitualSite);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.RitualSite, level);
            }
        }
        public byte DragonAerie
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.DragonAerie);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.DragonAerie, level);
            }
        }
        public byte ShrineEntrance
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.ShrineEntrance);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.ShrineEntrance, level);
            }
        }
        public byte SanctumWalk
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.SanctumWalk);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.SanctumWalk, level);
            }
        }
        public byte PriestessChamber
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.PriestessChamber);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.PriestessChamber, level);
            }
        }
        public byte HiddenSanctumChamber
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.HiddenSanctumChamber);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.HiddenSanctumChamber, level);
            }
        }
        public byte LairoftheImperfect
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.LairoftheImperfect);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.LairoftheImperfect, level);
            }
        }
        public byte SanctumInterior
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.SanctumInterior);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.SanctumInterior, level);
            }
        }
        public byte TowerofPrayerDLC
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.TowerofPrayerDLC);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.TowerofPrayerDLC, level);
            }
        }
        public byte SanctumNadir
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.SanctumNadir);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.SanctumNadir, level);
            }
        }
        public byte ThroneFloor
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.ThroneFloor);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.ThroneFloor, level);
            }
        }
        public byte UpperFloor
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.UpperFloor);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.UpperFloor, level);
            }
        }
        public byte Foyer
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.Foyer);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.Foyer, level);
            }
        }
        public byte LowermostFloor
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.LowermostFloor);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.LowermostFloor, level);
            }
        }
        public byte TheSmelterThrone
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.TheSmelterThrone);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.TheSmelterThrone, level);
            }
        }
        public byte IronHallwayEntrance
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.IronHallwayEntrance);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.IronHallwayEntrance, level);
            }
        }
        public byte OuterWall
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.OuterWall);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.OuterWall, level);
            }
        }
        public byte AbandonedDwelling
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.AbandonedDwelling);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.AbandonedDwelling, level);
            }
        }
        public byte ExpulsionChamber
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.ExpulsionChamber);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.ExpulsionChamber, level);
            }
        }
        public byte InnerWall
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.InnerWall);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.InnerWall, level);
            }
        }
        public byte LowerGarrison
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.LowerGarrison);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.LowerGarrison, level);
            }
        }
        public byte GrandCathedral
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2SOffsets.BonfireLevels.GrandCathedral);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2SOffsets.BonfireLevels.GrandCathedral, level);
            }
        }

        public void UnlockBonfires()
        {
            foreach (DS2SOffsets.BonfireLevels bonfire in Enum.GetValues(typeof(DS2SOffsets.BonfireLevels)))
            {
                var currentLevel = BonfireLevels.ReadByte((int)bonfire);

                if (bonfire == DS2SOffsets.BonfireLevels.FireKeepersDwelling)
                        continue;

                if (currentLevel == 0)
                    BonfireLevels.WriteByte((int)bonfire, 1);
            }
        }

        #endregion

        #region Internal

        public string Head
        {
            get
            {
                if (!Loaded) return "";
                var itemID = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerEquipment.Head);

                if (DS2SItem.Items.ContainsKey(itemID + 10000000))
                    return DS2SItem.Items[itemID + 10000000];

                return itemID.ToString();
            }
        }
        public string Chest
        {
            get
            {
                if (!Loaded) return "";
                var itemID = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerEquipment.Chest);

                if (DS2SItem.Items.ContainsKey(itemID + 10000000))
                    return DS2SItem.Items[itemID + 10000000];

                return itemID.ToString();
            }
        }
        public string Arms
        {
            get
            {
                if (!Loaded) return "";
                var itemID = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerEquipment.Arms);

                if (DS2SItem.Items.ContainsKey(itemID + 10000000))
                    return DS2SItem.Items[itemID + 10000000];

                return itemID.ToString();
            }
        }
        public string Legs
        {
            get
            {
                if (!Loaded) return "";
                var itemID = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerEquipment.Legs);

                if (DS2SItem.Items.ContainsKey(itemID + 10000000))
                    return DS2SItem.Items[itemID + 10000000];

                return itemID.ToString();
            }
        }
        public string RightHand1
        {
            get
            {
                if (!Loaded) return "";
                var itemID = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerEquipment.RightHand1);

                if (DS2SItem.Items.ContainsKey(itemID))
                    return DS2SItem.Items[itemID];

                return itemID.ToString();
            }
        }
        public string RightHand2
        {
            get
            {
                if (!Loaded) return "";
                var itemID = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerEquipment.RightHand2);

                if (DS2SItem.Items.ContainsKey(itemID))
                    return DS2SItem.Items[itemID];

                return itemID.ToString();
            }
        }
        public string RightHand3
        {
            get
            {
                if (!Loaded) return "";
                var itemID = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerEquipment.RightHand3);

                if (DS2SItem.Items.ContainsKey(itemID))
                    return DS2SItem.Items[itemID];

                return itemID.ToString();
            }
        }
        public string LeftHand1
        {
            get
            {
                if (!Loaded) return "";
                var itemID = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerEquipment.LeftHand1);

                if (DS2SItem.Items.ContainsKey(itemID))
                    return DS2SItem.Items[itemID];

                return itemID.ToString();
            }
        }
        public string LeftHand2
        {
            get
            {
                if (!Loaded) return "";
                var itemID = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerEquipment.LeftHand2);

                if (DS2SItem.Items.ContainsKey(itemID))
                    return DS2SItem.Items[itemID];

                return itemID.ToString();
            }
        }
        public string LeftHand3
        {
            get
            {
                if (!Loaded) return "";
                var itemID = PlayerCtrl.ReadInt32((int)DS2SOffsets.PlayerEquipment.LeftHand3);

                if (DS2SItem.Items.ContainsKey(itemID))
                    return DS2SItem.Items[itemID];

                return itemID.ToString();
            }
        }
        private bool _speedFactors;
        public bool EnableSpeedFactors
        {
            get => _speedFactors;
            set
            {
                _speedFactors = value;
                //TODO: fix properties 
                //AccelerationStamina = value;
                //AnimationSpeed = value;
                //JumpSpeed = value;
                //BuildupSpeed = value;
            }
        }

        private IntPtr AccelSpeedPtr;
        private IntPtr AccelSpeedCodePtr;

        //TODO: fix properties
        //public float AccelSpeed
        //{
        //    get => AccelSpeedPtr != IntPtr.Zero ? BitConverter.ToSingle(Kernel32.ReadBytes(Handle, AccelSpeedPtr, 0x4), 0x0) : Properties.Settings.Default.AccelSpeed;
        //    set
        //    {
        //        if (AccelSpeedPtr != IntPtr.Zero)
        //            Kernel32.WriteBytes(Handle, AccelSpeedPtr, BitConverter.GetBytes(value));
        //
        //        Properties.Settings.Default.AccelSpeed = value;
        //    }
        //}
        //private bool _accelerationStamina;
        //public bool AccelerationStamina
        //{
        //    get => _accelerationStamina;
        //    set
        //    {
        //        _accelerationStamina = value;
        //        if (_accelerationStamina)
        //            InjectSpeedFactor(SpeedFactorAccel, ref AccelSpeedPtr, ref AccelSpeedCodePtr, (byte[])DS2SAssembly.SpeedFactorAccel.Clone(), Properties.Settings.Default.AccelSpeed);
        //        else
        //        {
        //            RepairSpeedFactor(SpeedFactorAccel, AccelSpeedPtr, AccelSpeedCodePtr, (byte[])DS2SAssembly.OgSpeedFactorAccel.Clone());
        //            AccelSpeedPtr = IntPtr.Zero;
        //            AccelSpeedCodePtr = IntPtr.Zero;
        //        }
        //    }
        //}
        //
        //private IntPtr AnimSpeedPtr;
        //private IntPtr AnimSpeedCodePtr;
        //public float AnimSpeed
        //{
        //    get => AnimSpeedPtr != IntPtr.Zero ? BitConverter.ToSingle(Kernel32.ReadBytes(Handle, AnimSpeedPtr, 0x4), 0x0) : Properties.Settings.Default.AnimSpeed;
        //    set
        //    {
        //        if (AnimSpeedPtr != IntPtr.Zero)
        //            Kernel32.WriteBytes(Handle, AnimSpeedPtr, BitConverter.GetBytes(value));
        //
        //        Properties.Settings.Default.AnimSpeed = value;
        //    }
        //}
        //private bool _animationSpeed;
        //public bool AnimationSpeed
        //{
        //    get => _animationSpeed;
        //    set
        //    {
        //        _animationSpeed = value;
        //        if (_animationSpeed)
        //            InjectSpeedFactor(SpeedFactorAnim, ref AnimSpeedPtr, ref AnimSpeedCodePtr, (byte[])DS2SAssembly.SpeedFactor.Clone(), Properties.Settings.Default.AnimSpeed);
        //        else
        //        {
        //            RepairSpeedFactor(SpeedFactorAnim, AnimSpeedPtr, AnimSpeedCodePtr, (byte[])DS2SAssembly.OgSpeedFactor.Clone());
        //            AnimSpeedPtr = IntPtr.Zero;
        //            AnimSpeedCodePtr = IntPtr.Zero;
        //        }
        //    }
        //}
        //
        //private IntPtr JumpSpeedPtr;
        //private IntPtr JumpSpeedCodePtr;
        //public float JumpSpeedValue
        //{
        //    get => JumpSpeedPtr != IntPtr.Zero ? BitConverter.ToSingle(Kernel32.ReadBytes(Handle, JumpSpeedPtr, 0x4), 0x0) : Properties.Settings.Default.JumpSpeed;
        //    set
        //    {
        //        if (JumpSpeedPtr != IntPtr.Zero)
        //            Kernel32.WriteBytes(Handle, JumpSpeedPtr, BitConverter.GetBytes(value));
        //
        //        Properties.Settings.Default.JumpSpeed = value;
        //    }
        //}
        //private bool _jumpSpeed;
        //public bool JumpSpeed
        //{
        //    get => _jumpSpeed;
        //    set
        //    {
        //        _jumpSpeed = value;
        //        if (_jumpSpeed)
        //            InjectSpeedFactor(SpeedFactorJump, ref JumpSpeedPtr, ref JumpSpeedCodePtr, (byte[])DS2SAssembly.SpeedFactor.Clone(), Properties.Settings.Default.JumpSpeed);
        //        else
        //        {
        //            RepairSpeedFactor(SpeedFactorJump, JumpSpeedPtr, JumpSpeedCodePtr, (byte[])DS2SAssembly.OgSpeedFactor.Clone());
        //            JumpSpeedPtr = IntPtr.Zero;
        //            JumpSpeedCodePtr = IntPtr.Zero;
        //        }
        //    }
        //}
        //
        //private IntPtr BuildupSpeedPtr;
        //private IntPtr BuildupSpeedCodePtr;
        //public float BuildupSpeedValue
        //{
        //    get => BuildupSpeedPtr != IntPtr.Zero ? BitConverter.ToSingle(Kernel32.ReadBytes(Handle, BuildupSpeedPtr, 0x4), 0x0) : Properties.Settings.Default.BuildupSpeed;
        //    set
        //    {
        //        if (BuildupSpeedPtr != IntPtr.Zero)
        //            Kernel32.WriteBytes(Handle, BuildupSpeedPtr, BitConverter.GetBytes(value));
        //
        //        Properties.Settings.Default.BuildupSpeed = value;
        //    }
        //}
        //private bool _buildupSpeed;
        //public bool BuildupSpeed
        //{
        //    get => _buildupSpeed;
        //    set
        //    {
        //        _buildupSpeed = value;
        //        if (_buildupSpeed)
        //            InjectSpeedFactor(SpeedFactorBuildup, ref BuildupSpeedPtr, ref BuildupSpeedCodePtr, (byte[])DS2SAssembly.SpeedFactor.Clone(), Properties.Settings.Default.BuildupSpeed);
        //        else
        //        {
        //            RepairSpeedFactor(SpeedFactorBuildup, BuildupSpeedPtr, BuildupSpeedCodePtr, (byte[])DS2SAssembly.OgSpeedFactor.Clone());
        //            BuildupSpeedPtr = IntPtr.Zero;
        //            BuildupSpeedCodePtr = IntPtr.Zero;
        //        }
        //    }
        //}

        private void RepairSpeedFactor(PHPointer speedFactorPointer, IntPtr valuePointer, IntPtr codePointer, byte[] asm)
        {
            speedFactorPointer.WriteBytes(0x0, asm);
            Free(valuePointer);
            Free(codePointer);
        }
        private void InjectSpeedFactor(PHPointer speedFactorPointer, ref IntPtr valuePointer, ref IntPtr codePointer, byte[] asm, float value)
        {
            var inject = new byte[0x11];
            Array.Copy(asm, inject, inject.Length);
            var newCode = new byte[0x18];
            Array.Copy(asm, inject.Length, newCode, 0x0, newCode.Length);

            valuePointer = Allocate(sizeof(float));
            var valuePointerBytes = BitConverter.GetBytes(valuePointer.ToInt64());
            codePointer = Allocate(sizeof(float), Kernel32.PAGE_EXECUTE_READWRITE);
            var codePointerBytes = BitConverter.GetBytes(codePointer.ToInt64());

            Array.Copy(valuePointerBytes, 0x0, newCode, 0x2, valuePointerBytes.Length);
            Array.Copy(codePointerBytes, 0x0, inject, 0x3, valuePointerBytes.Length);

            Kernel32.WriteBytes(Handle, valuePointer, BitConverter.GetBytes(value));
            Kernel32.WriteBytes(Handle, codePointer, newCode);
            speedFactorPointer.WriteBytes(0x0, inject);
        }

        #endregion

        #region Covenant

        public byte CurrentCovenant
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.Covenants.CurrentCovenant) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2SOffsets.Covenants.CurrentCovenant, value);
            }
        }
        public string CurrentCovenantName
        {
            get => Loaded ? DS2SCovenant.All.FirstOrDefault(x => x.ID == CurrentCovenant).Name : "";
        }
        public bool HeirsOfTheSunDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2SOffsets.Covenants.HeirsOfTheSunDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2SOffsets.Covenants.HeirsOfTheSunDiscovered, value);
            }
        }
        public byte HeirsOfTheSunRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.Covenants.HeirsOfTheSunOfTheSunRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2SOffsets.Covenants.HeirsOfTheSunOfTheSunRank, value);
            }
        }
        public short HeirsOfTheSunProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Covenants.HeirsOfTheSunProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Covenants.HeirsOfTheSunProgress, value);
            }
        }
        public bool BlueSentinelsDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2SOffsets.Covenants.BlueSentinelsDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2SOffsets.Covenants.BlueSentinelsDiscovered, value);
            }
        }
        public byte BlueSentinelsRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.Covenants.BlueSentinelsRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2SOffsets.Covenants.BlueSentinelsRank, value);
            }
        }
        public short BlueSentinelsProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Covenants.BlueSentinelsProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Covenants.BlueSentinelsProgress, value);
            }
        }
        public bool BrotherhoodOfBloodDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2SOffsets.Covenants.BrotherhoodOfBloodDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2SOffsets.Covenants.BrotherhoodOfBloodDiscovered, value);
            }
        }
        public byte BrotherhoodOfBloodRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.Covenants.BrotherhoodOfBloodRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2SOffsets.Covenants.BrotherhoodOfBloodRank, value);
            }
        }
        public short BrotherhoodOfBloodProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Covenants.BrotherhoodOfBloodProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Covenants.BrotherhoodOfBloodProgress, value);
            }
        }
        public bool WayOfTheBlueDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2SOffsets.Covenants.WayOfTheBlueDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2SOffsets.Covenants.WayOfTheBlueDiscovered, value);
            }
        }
        public byte WayOfTheBlueRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.Covenants.WayOfTheBlueRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2SOffsets.Covenants.WayOfTheBlueRank, value);
            }
        }
        public short WayOfTheBlueProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Covenants.WayOfTheBlueProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Covenants.WayOfTheBlueProgress, value);
            }
        }
        public bool RatKingDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2SOffsets.Covenants.RatKingDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2SOffsets.Covenants.RatKingDiscovered, value);
            }
        }
        public byte RatKingRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.Covenants.RatKingRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2SOffsets.Covenants.RatKingRank, value);
            }
        }
        public short RatKingProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Covenants.RatKingProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Covenants.RatKingProgress, value);
            }
        }
        public bool BellKeepersDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2SOffsets.Covenants.BellKeepersDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2SOffsets.Covenants.BellKeepersDiscovered, value);
            }
        }
        public byte BellKeepersRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.Covenants.BellKeepersRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2SOffsets.Covenants.BellKeepersRank, value);
            }
        }
        public short BellKeepersProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Covenants.BellKeepersProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Covenants.BellKeepersProgress, value);
            }
        }
        public bool DragonRemnantsDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2SOffsets.Covenants.DragonRemnantsDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2SOffsets.Covenants.DragonRemnantsDiscovered, value);
            }
        }
        public byte DragonRemnantsRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.Covenants.DragonRemnantsRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2SOffsets.Covenants.DragonRemnantsRank, value);
            }
        }
        public short DragonRemnantsProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Covenants.DragonRemnantsProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Covenants.DragonRemnantsProgress, value);
            }
        }
        public bool CompanyOfChampionsDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2SOffsets.Covenants.CompanyOfChampionsDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2SOffsets.Covenants.CompanyOfChampionsDiscovered, value);
            }
        }
        public byte CompanyOfChampionsRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.Covenants.CompanyOfChampionsRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2SOffsets.Covenants.CompanyOfChampionsRank, value);
            }
        }
        public short CompanyOfChampionsProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Covenants.CompanyOfChampionsProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Covenants.CompanyOfChampionsProgress, value);
            }
        }
        public bool PilgrimsOfDarknessDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2SOffsets.Covenants.PilgrimsOfDarknessDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2SOffsets.Covenants.PilgrimsOfDarknessDiscovered, value);
            }
        }
        public byte PilgrimsOfDarknessRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2SOffsets.Covenants.PilgrimsOfDarknessRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2SOffsets.Covenants.PilgrimsOfDarknessRank, value);
            }
        }
        public short PilgrimsOfDarknessProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2SOffsets.Covenants.PilgrimsOfDarknessProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2SOffsets.Covenants.PilgrimsOfDarknessProgress, value);
            }
        }

        #region Cheaty

        public float RightHand1DamageMultiplier
        {
            get => RightHand1DamageMultiplierPtr.ReadSingle(0);
            set => RightHand1DamageMultiplierPtr.WriteSingle(0, value);
        }

        #endregion

        #endregion
        

    }
}
