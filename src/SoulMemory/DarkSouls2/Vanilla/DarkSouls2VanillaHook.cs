
using PropertyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SoulMemory.Shared;
using Keystone;
using SoulMemory.Native;
using Kernel32 = PropertyHook.Kernel32;

namespace SoulMemory.DarkSouls2.Vanilla
{
    public class DarkSouls2VanillaHook : PHook, INotifyPropertyChanged, IDarkSouls2
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
            get => _version;
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
        private PHPointer PointerArray;
        private PHPointer DisplayItem;
        private PHPointer SetWarpTargetFunc;
        private PHPointer WarpManager;
        private PHPointer WarpFunc;

        private PHPointer BaseA;
        private PHPointer GameDataManager;
        private PHPointer AvailableItemBag;
        private PHPointer ItemGiveWindow;
        private PHPointer PlayerBaseMisc;
        private PHPointer PlayerCtrl;
        private PHPointer Equipment;
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
        private PHPointer EquipedWeapons;

        private PHPointer LevelUpSoulsParam;
        private PHPointer WeaponParam;
        private PHPointer WeaponReinforceParam;
        private PHPointer CustomAttrSpecParam;
        private PHPointer ArmorReinforceParam;
        private PHPointer ItemParam;
        private PHPointer ItemUseageParam;

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

        public bool Loaded => PlayerCtrl != null && PlayerCtrl.Resolve() != IntPtr.Zero;
        public bool Setup = false;
        public bool Multiplayer => false;// Loaded ? ConnectionType > 1 : true;
        public bool Focused => Hooked && User32.GetForegroundProcessID() == Process.Id;

        public DarkSouls2VanillaHook(int refreshInterval, int minLifetime) : base(refreshInterval, minLifetime, p => p.MainWindowTitle == "DARK SOULS II")
        {
            Version = "Not Hooked";
            BaseA = RegisterAbsoluteAOB(DS2Offsets.BaseAAoB, DS2Offsets.BaseOffset1, DS2Offsets.BaseOffset2);


            SpeedFactorAccel = RegisterAbsoluteAOB(DS2Offsets.SpeedFactorAccelOffset);
            SpeedFactorAnim = RegisterAbsoluteAOB(DS2Offsets.SpeedFactorAnimOffset);
            SpeedFactorJump = RegisterAbsoluteAOB(DS2Offsets.SpeedFactorJumpOffset);
            SpeedFactorBuildup = RegisterAbsoluteAOB(DS2Offsets.SpeedFactorBuildupOffset);
            GiveSoulsFunc = RegisterAbsoluteAOB(DS2Offsets.GiveSoulsFuncAoB);
            ItemStruct2dDisplay = RegisterAbsoluteAOB(DS2Offsets.ItemStruct2dDisplay);
            DisplayItem = RegisterAbsoluteAOB(DS2Offsets.DisplayItem);
            SetWarpTargetFunc = RegisterAbsoluteAOB(DS2Offsets.SetWarpTargetFuncAoB);
            ApplySpEffect = RegisterAbsoluteAOB(DS2Offsets.ApplySpEffectAoB);
            WarpFunc = RegisterAbsoluteAOB(DS2Offsets.WarpFuncAoB);

            //BaseBSetup = RegisterAbsoluteAOB(DS2Offsets.BaseBAoB);
            GameDataManager = CreateChildPointer(BaseA, (int)DS2Offsets.GameDataManagerOffset);
            ItemGiveFunc = RegisterAbsoluteAOB(DS2Offsets.ItemGiveFunc);
            AvailableItemBag = CreateChildPointer(GameDataManager, (int)DS2Offsets.AvailableItemBagOffset, (int)DS2Offsets.AvailableItemBagOffset);
            ItemGiveWindow = CreateChildPointer(BaseA, (int)DS2Offsets.ItemGiveWindowPointer);
            PlayerBaseMisc = CreateChildPointer(GameDataManager, (int)DS2Offsets.PlayerBaseMiscOffset);
            PointerArray = CreateChildPointer(GameDataManager, (int)DS2Offsets.PointerArrayOffset1, (int)DS2Offsets.PointerArrayOffset2, (int)DS2Offsets.PointerArrayOffset3);
            PlayerCtrl = CreateChildPointer(BaseA, (int)DS2Offsets.PlayerCtrlOffset);
            Equipment = CreateChildPointer(PlayerCtrl, (int)DS2Offsets.EquipmentOffset1, (int)DS2Offsets.EquipmentOffset2);
            PlayerPosition = CreateChildPointer(PlayerCtrl, (int)DS2Offsets.PlayerPositionOffset1, (int)DS2Offsets.PlayerPositionOffset2);
            PlayerGravity = CreateChildPointer(PlayerCtrl, (int)DS2Offsets.GravityOffset1, (int)DS2Offsets.GravityOffset2);
            PlayerMapData = CreateChildPointer(PlayerGravity, (int)DS2Offsets.PlayerMapDataOffset1, (int)DS2Offsets.PlayerMapDataOffset2, (int)DS2Offsets.PlayerMapDataOffset3);
            PlayerParam = CreateChildPointer(PlayerCtrl, (int)DS2Offsets.PlayerParamOffset);
            PlayerType = CreateChildPointer(PlayerCtrl, (int)DS2Offsets.PlayerTypeOffset);
            SpEffectCtrl = CreateChildPointer(PlayerCtrl, (int)DS2Offsets.SpEffectCtrlOffset);
            EventManager = CreateChildPointer(BaseA, (int)DS2Offsets.EventManagerOffset);
            WarpManager = CreateChildPointer(EventManager, (int)DS2Offsets.WarpManagerOffset);
            BonfireLevels = CreateChildPointer(WarpManager, (int)DS2Offsets.BonfireLevelsOffset);
            //NetSvrBloodstainManager = CreateChildPointer(BaseA, (int)DS2Offsets.NetSvrBloodstainManagerOffset1, (int)DS2Offsets.NetSvrBloodstainManagerOffset2, (int)DS2Offsets.NetSvrBloodstainManagerOffset3);
            BossKillCounters = CreateChildPointer(BaseA, DS2Offsets.BossKillCountersOffset1, DS2Offsets.BossKillCountersOffset2, DS2Offsets.BossKillCountersOffset3, DS2Offsets.BossKillCountersOffset4);
            AiManager = CreateChildPointer(BaseA, DS2Offsets.AiManagerOffset1);
            EquipedWeapons = CreateChildPointer(BaseA, DS2Offsets.EquipedWeaponsOffset1, DS2Offsets.EquipedWeaponsOffset2, DS2Offsets.EquipedWeaponsOffset3, DS2Offsets.EquipedWeaponsOffset4);

            LevelUpSoulsParam = CreateChildPointer(BaseA, (int)DS2Offsets.ParamDataOffset1, (int)DS2Offsets.LevelUpSoulsParamOffset, (int)DS2Offsets.ParamDataOffset2);
            WeaponParam = CreateChildPointer(BaseA, (int)DS2Offsets.ParamDataOffset1, (int)DS2Offsets.WeaponParamOffset, (int)DS2Offsets.ParamDataOffset2);
            WeaponReinforceParam = CreateChildPointer(BaseA, (int)DS2Offsets.ParamDataOffset1, (int)DS2Offsets.WeaponReinforceParamOffset, (int)DS2Offsets.ParamDataOffset4);
            CustomAttrSpecParam = CreateChildPointer(BaseA, (int)DS2Offsets.ParamDataOffset1, (int)DS2Offsets.CustomAttrSpecParamOffset, (int)DS2Offsets.ParamDataOffset2);
            ArmorReinforceParam = CreateChildPointer(BaseA, (int)DS2Offsets.ParamDataOffset1, (int)DS2Offsets.ArmorReinforceParamOffset, (int)DS2Offsets.ParamDataOffset4);
            ItemParam = CreateChildPointer(BaseA, (int)DS2Offsets.ParamDataOffset3, (int)DS2Offsets.ItemParamOffset, (int)DS2Offsets.ParamDataOffset4);
            ItemUseageParam = CreateChildPointer(BaseA, (int)DS2Offsets.ParamDataOffset3, (int)DS2Offsets.ItemUsageParamOffset, (int)DS2Offsets.ParamDataOffset4);

            BaseB = RegisterAbsoluteAOB(DS2Offsets.BaseBAoB, DS2Offsets.BaseOffset1, DS2Offsets.BaseOffset2);

            //Camera = CreateBasePointer(Handle + 0x160B8D0, (int)DS2Offsets.CameraOffset1);
            //Camera2 = CreateChildPointer(Camera, (int)DS2Offsets.CameraOffset2);
            //Camera3 = CreateChildPointer(BaseA, (int)DS2Offsets.CameraOffset2, (int)DS2Offsets.CameraOffset2);
            //Camera4 = CreateChildPointer(BaseA, (int)DS2Offsets.CameraOffset2, (int)DS2Offsets.CameraOffset3);
            //Camera5 = CreateChildPointer(BaseA, (int)DS2Offsets.CameraOffset2);

            OnHooked += DS2Hook_OnHooked;
            OnUnhooked += DS2Hook_OnUnhooked;
        }
        private void DS2Hook_OnHooked(object sender, PHEventArgs e)
        {
            Version = "Vanilla";

            var baseA = BaseA.Resolve();
            var levelUpSoulsParam = LevelUpSoulsParam.Resolve();
            var weaponParam = WeaponParam.Resolve();
            var weaponReinforceParam = WeaponReinforceParam.Resolve();
            var customAttrSpecParam = CustomAttrSpecParam.Resolve();
            var armorReinforceParam = ArmorReinforceParam.Resolve();
            var itemParam = ItemParam.Resolve();
            var itemUsageParam = ItemUseageParam.Resolve();

            GetLevelRequirements();
            WeaponParamOffsetDict = BuildOffsetDictionary(WeaponParam, "WEAPON_PARAM");
            WeaponReinforceParamOffsetDict = BuildOffsetDictionary(WeaponReinforceParam, "WEAPON_REINFORCE_PARAM");
            CustomAttrOffsetDict = BuildOffsetDictionary(CustomAttrSpecParam, "CUSTOM_ATTR_SPEC_PARAM");
            ArmorReinforceParamOffsetDict = BuildOffsetDictionary(ArmorReinforceParam, "ARMOR_REINFORCE_PARAM");
            ItemParamOffsetDict = BuildOffsetDictionary(ItemParam, "ITEM_PARAM");
            ItemUsageParamOffsetDict = BuildOffsetDictionary(ItemUseageParam, "ITEM_USAGE_PARAM");
            UpdateStatsProperties();
            //TODO: reenable once speedshizzle is fixed
            //GetSpeedhackOffsets(SpeedhackDllPath);
            Setup = true;
        }
        private void DS2Hook_OnUnhooked(object sender, PHEventArgs e)
        {
            Version = "Not Hooked";
            Setup = false;
        }

        private int GetRelativeOffset(IntPtr source, IntPtr dest)
        {
            return dest.ToInt32() - source.ToInt32();
        }

        //TKCode
        private Engine _keyStoneEngine = new Engine(Architecture.X86, Mode.X32);
        private void AsmExecute(string asm)
        {
            // Assemble once to determine size
            byte[] bytes = _keyStoneEngine.Assemble(asm, 0).Buffer;
            IntPtr insertPtr = Allocate((uint)bytes.Length, Kernel32.PAGE_EXECUTE_READWRITE);
            // Then rebase and inject
            // Note: you can't use String.Format here because IntPtr is not IFormattable
            bytes = _keyStoneEngine.Assemble(asm, (ulong)insertPtr.ToInt64()).Buffer;
            Kernel32.WriteBytes(Handle, insertPtr, bytes);
            Execute(insertPtr);
            Free(insertPtr);
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
            OnPropertyChanged(nameof(TowerofPrayerAmana));
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
            OnPropertyChanged(nameof(TowerofPrayerShulva));
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
            //TODO: reenable once speedshizzle is fixed
            //OnPropertyChanged(nameof(EnableSpeedFactors));
        }

        public IntPtr BasePointerFromSetupPointer(PHPointer pointer)
        {
            var readInt = pointer.ReadInt32(DS2Offsets.BasePtrOffset1);
            return pointer.ReadIntPtr(readInt + DS2Offsets.BasePtrOffset2);
        }

        public IntPtr BasePointerFromSetupBabyJ(PHPointer pointer)
        {
            return pointer.ReadIntPtr(0x0121D4D0 + DS2Offsets.BasePtrOffset2);
        }

        public byte FastQuit
        {
            set
            {
                BaseA.WriteByte((int)DS2Offsets.ForceQuit.Quit, value);
            }
        }

        #region Player
        public int Health
        {
            get => Loaded ? PlayerCtrl.ReadInt32((int)DS2Offsets.PlayerCtrl.HP) : 0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerCtrl.WriteInt32((int)DS2Offsets.PlayerCtrl.HP, value);
            }
        }
        public int HealthMax
        {
            get => Loaded ? PlayerCtrl.ReadInt32((int)DS2Offsets.PlayerCtrl.HPMax) : 0;
            set => PlayerCtrl.WriteInt32((int)DS2Offsets.PlayerCtrl.HPMax, value);
        }
        public int HealthCap
        {
            get
            {
                if (!Loaded) return 0;
                var cap = PlayerCtrl.ReadInt32((int)DS2Offsets.PlayerCtrl.HPCap);
                return cap < HealthMax ? cap : HealthMax;
            }
            set => PlayerCtrl.WriteInt32((int)DS2Offsets.PlayerCtrl.HPCap, value);
        }
        public float Stamina
        {
            get => Loaded ? PlayerCtrl.ReadSingle((int)DS2Offsets.PlayerCtrl.SP) : 0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerCtrl.WriteSingle((int)DS2Offsets.PlayerCtrl.SP, value);
            }
        }
        public float MaxStamina
        {
            get => Loaded ? PlayerCtrl.ReadSingle((int)DS2Offsets.PlayerCtrl.SPMax) : 0;
            set => PlayerCtrl.WriteSingle((int)DS2Offsets.PlayerCtrl.SPMax, value);
        }
        public byte NetworkPhantomID
        {
            get => Loaded ? PlayerType.ReadByte((int)DS2Offsets.PlayerType.ChrNetworkPhantomId) : (byte)0;
            set => PlayerType.WriteByte((int)DS2Offsets.PlayerType.ChrNetworkPhantomId, value);
        }
        public byte TeamType
        {
            get => Loaded ? PlayerType.ReadByte((int)DS2Offsets.PlayerType.TeamType) : (byte)0;
            //set => PlayerType.WriteByte((int)DS2Offsets.PlayerType.TeamType, value);
        }
        public byte CharType
        {
            get => Loaded ? PlayerType.ReadByte((int)DS2Offsets.PlayerType.CharType) : (byte)0;
            //set => PlayerType.WriteByte((int)DS2Offsets.PlayerType.CharType, value);
        }
        public float PosX
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2Offsets.PlayerPosition.PosX) : 0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerPosition.WriteSingle((int)DS2Offsets.PlayerPosition.PosX, value);
            }
        }
        public float PosY
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2Offsets.PlayerPosition.PosY) : 0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerPosition.WriteSingle((int)DS2Offsets.PlayerPosition.PosY, value);
            }
        }
        public float PosZ
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2Offsets.PlayerPosition.PosZ) : 0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerPosition.WriteSingle((int)DS2Offsets.PlayerPosition.PosZ, value);
            }
        }
        public float AngX
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2Offsets.PlayerPosition.AngX) : 0;
            set => PlayerPosition.WriteSingle((int)DS2Offsets.PlayerPosition.AngX, value);
        }
        public float AngY
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2Offsets.PlayerPosition.AngY) : 0;
            set => PlayerPosition.WriteSingle((int)DS2Offsets.PlayerPosition.AngY, value);
        }
        public float AngZ
        {
            get => Loaded ? PlayerPosition.ReadSingle((int)DS2Offsets.PlayerPosition.AngZ) : 0;
            set => PlayerPosition.WriteSingle((int)DS2Offsets.PlayerPosition.AngZ, value);
        }
        public float StableX
        {
            get => Loaded ? PlayerMapData.ReadSingle((int)DS2Offsets.PlayerMapData.WarpX1) : 0;
            set
            {
                PlayerMapData.WriteSingle((int)DS2Offsets.PlayerMapData.WarpX1, value);
                PlayerMapData.WriteSingle((int)DS2Offsets.PlayerMapData.WarpX2, value);
                PlayerMapData.WriteSingle((int)DS2Offsets.PlayerMapData.WarpX3, value);
            }
        }
        public float StableY
        {
            get => Loaded ? PlayerMapData.ReadSingle((int)DS2Offsets.PlayerMapData.WarpY1) : 0;
            set
            {
                PlayerMapData.WriteSingle((int)DS2Offsets.PlayerMapData.WarpY1, value);
                PlayerMapData.WriteSingle((int)DS2Offsets.PlayerMapData.WarpY2, value);
                PlayerMapData.WriteSingle((int)DS2Offsets.PlayerMapData.WarpY3, value);
            }
        }
        public float StableZ
        {
            get => Loaded ? PlayerMapData.ReadSingle((int)DS2Offsets.PlayerMapData.WarpZ1) : 0;
            set
            {
                PlayerMapData.WriteSingle((int)DS2Offsets.PlayerMapData.WarpZ1, value);
                PlayerMapData.WriteSingle((int)DS2Offsets.PlayerMapData.WarpZ2, value);
                PlayerMapData.WriteSingle((int)DS2Offsets.PlayerMapData.WarpZ3, value);
            }
        }
        public float BloodstainX
        {
            get => NetSvrBloodstainManager.ReadSingle((int)DS2Offsets.NetSvrBloodstainManager.BloodstainX);
        }
        public float BloodstainY
        {
            get => NetSvrBloodstainManager.ReadSingle((int)DS2Offsets.NetSvrBloodstainManager.BloodstainY);
        }
        public float BloodstainZ
        {
            get => NetSvrBloodstainManager.ReadSingle((int)DS2Offsets.NetSvrBloodstainManager.BloodstainZ);
        }
        public byte[] CameraData
        {
            get => Camera5.ReadBytes((int)0xE9C, 512);
            set => Camera5.WriteBytes((int)0xE9C, value);
        }
        public byte[] CameraData2
        {
            get => Camera4.ReadBytes((int)DS2Offsets.Camera.CamStart3, 512);
            set => Camera4.WriteBytes((int)DS2Offsets.Camera.CamStart3, value);
        }
        public float CamX
        {
            get => Camera2.ReadSingle((int)DS2Offsets.Camera.CamX);
            set => Camera2.WriteSingle((int)DS2Offsets.Camera.CamX, value);
        }
        public float CamY
        {
            get => Camera2.ReadSingle((int)DS2Offsets.Camera.CamY);
            set => Camera2.WriteSingle((int)DS2Offsets.Camera.CamY, value);
        }
        public float CamZ
        {
            get => Camera2.ReadSingle((int)DS2Offsets.Camera.CamZ);
            set => Camera2.WriteSingle((int)DS2Offsets.Camera.CamZ, value);
        }
        public float Speed
        {
            set
            {
                if (!Loaded) return;
                PlayerCtrl.WriteSingle((int)DS2Offsets.PlayerCtrl.SpeedModifier, value);
            }
        }
        public bool Gravity
        {
            get => Loaded ? !PlayerGravity.ReadBoolean((int)DS2Offsets.Gravity.Gravity) : true;
            set => PlayerGravity.WriteBoolean((int)DS2Offsets.Gravity.Gravity, !value);
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
            get => Loaded ? EventManager.ReadUInt16((int)DS2Offsets.Bonfire.LastSetBonfire) : (ushort)0;
            set => EventManager.WriteUInt16((int)DS2Offsets.Bonfire.LastSetBonfire, value);
        }
        public int LastBonfireAreaId
        {
            get => Loaded ? EventManager.ReadInt32((int)DS2Offsets.Bonfire.LastSetBonfireAreaID) : 0;
            set => EventManager.WriteInt32((int)DS2Offsets.Bonfire.LastSetBonfireAreaID, value);
        }
        //public DS2Bonfire LastBonfireObj
        //{
        //    get => Loaded ? DS2Bonfire.All.FirstOrDefault(b => b.ID == LastBonfireID) : new DS2Bonfire(0, "None");
        //    //set => Bonfire.WriteInt32((int)DS2Offsets.Bonfire.LastSetBonfire, value.ID);
        //}

        public bool Online
        {
            get => ConnectionType > 0;
        }

        public int ConnectionType
        {
            get => Hooked && BaseB != null ? BaseB.ReadInt32((int)DS2Offsets.Connection.ConnectionType) : 0;
        }


        private const string BonfireWarpAssembly = @"mov    ebp, esp
sub	   esp, 0xb8
push   0x2
push   0x{0:X}  
lea    edx,[ebp + -0x50]
push   edx
call   0x{1:X}           ;SetWarpTargetFunc
mov    ecx, 0x{2:X}      ;BaseA
mov    edx,[ecx+0x44]
mov    ecx,[edx+0x38]
add    esp, 0xc
lea    eax, [ebp + -0x50]
push   eax
call   0x{3:X}           ;WarpFunc
add    esp, 0xb8
ret";

        public bool Warp(ushort id, bool rest = false)
        {
            if (rest)
            {
            }

            var value = Allocate(sizeof(short));
            Kernel32.WriteBytes(Handle, value, BitConverter.GetBytes(id));
            var asm = string.Format(BonfireWarpAssembly, id.ToString("X2"), SetWarpTargetFunc.Resolve().ToString("X2"), BaseA.Resolve().ToString("X2"), WarpFunc.Resolve().ToString("X2"));

            var warped = false;
            if (!Multiplayer)
            {
                AsmExecute(asm);
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

        //TODO: properties
        //internal void ApplySpecialEffect(int spEffect)
        //{
        //    var unk = Allocate(sizeof(float));
        //    Kernel32.WriteBytes(Handle, unk, BitConverter.GetBytes(-1f));
        //
        //    var asm = string.Format(Properties.Resources.ApplySpecialEffect, spEffect.ToString("X2"), unk.ToString("X2"), SpEffectCtrl.Resolve().ToString("X2"), ApplySpEffect.Resolve().ToString("X2"));
        //    AsmExecute(asm);
        //    Free(unk);
        //}

        //TODO: resources
        //static string SpeedhackDllPath = $"{GetTxtResourceClass.ExeDir}/Resources/DLLs/Speedhack.dll";
        //public IntPtr SpeedhackDllPtr;
        //IntPtr SetupPtr;
        //IntPtr SetSpeedPtr;
        //IntPtr DetachPtr;
        //internal void Speedhack(bool enable)
        //{
        //    if (enable)
        //        EnableSpeedhack();
        //    else
        //        DisableSpeedhack();
        //}
        //
        //public void DisableSpeedhack()
        //{
        //    IntPtr detach = (IntPtr)(SpeedhackDllPtr.ToInt64() + DetachPtr.ToInt64());
        //    Kernel32.CreateRemoteThread(Handle, IntPtr.Zero, 0, detach, IntPtr.Zero, 0, IntPtr.Zero);
        //}
        //
        //private void EnableSpeedhack()
        //{
        //    IntPtr thread = IntPtr.Zero;
        //    if (SpeedhackDllPtr == IntPtr.Zero)
        //    {
        //        SpeedhackDllPtr = InjectDLL(SpeedhackDllPath);
        //    }
        //
        //    IntPtr setup = (IntPtr)(SpeedhackDllPtr.ToInt64() + SetupPtr.ToInt64());
        //    thread = Kernel32.CreateRemoteThread(Handle, IntPtr.Zero, 0, setup, IntPtr.Zero, 0, IntPtr.Zero);
        //    Kernel32.WaitForSingleObject(thread, uint.MaxValue);
        //    Kernel32.CloseHandle(thread);
        //    SetSpeed((float)Properties.Settings.Default.SpeedValue);
        //}

        //public void SetSpeed(float value)
        //{
        //    IntPtr setSpeed = (IntPtr)(SpeedhackDllPtr.ToInt64() + SetSpeedPtr.ToInt64());
        //    IntPtr valueAddress = GetPrefferedIntPtr(sizeof(float), SpeedhackDllPtr);
        //    Kernel32.WriteBytes(Handle, valueAddress, BitConverter.GetBytes(value));
        //    var thread = Kernel32.CreateRemoteThread(Handle, IntPtr.Zero, 0, setSpeed, valueAddress, 0, IntPtr.Zero);
        //    Kernel32.WaitForSingleObject(thread, uint.MaxValue);
        //    Kernel32.CloseHandle(thread);
        //    Free(valueAddress);
        //}
        //
        //private void GetSpeedhackOffsets(string path)
        //{
        //    var lib = Kernel32.LoadLibrary(path);
        //    var setupOffset = Kernel32.GetProcAddress(lib, "Setup").ToInt64() - lib.ToInt64();
        //    var setSpeedOffset = Kernel32.GetProcAddress(lib, "SetSpeed").ToInt64() - lib.ToInt64();
        //    var detachOffset = Kernel32.GetProcAddress(lib, "Detach").ToInt64() - lib.ToInt64();
        //    SetupPtr = (IntPtr)setupOffset;
        //    SetSpeedPtr = (IntPtr)setSpeedOffset;
        //    DetachPtr = (IntPtr)detachOffset;
        //    Free(lib);
        //}

        #endregion

        #region Stats
        public string Name
        {
            get => Loaded ? GameDataManager.ReadString((int)DS2Offsets.PlayerName.Name, Encoding.Unicode, 0x1F) : "";
            set
            {
                if (Reading || !Loaded) return;
                if (Name == value) return;
                GameDataManager.WriteString((int)DS2Offsets.PlayerName.Name, Encoding.Unicode, 0x1F, value);
                OnPropertyChanged(nameof(Name));
            }
        }

        public byte Class
        {
            get => Loaded ? PlayerBaseMisc.ReadByte((int)DS2Offsets.PlayerBaseMisc.Class) : (byte)255;
            set
            {
                if (Reading || !Loaded) return;
                PlayerBaseMisc.WriteByte((int)DS2Offsets.PlayerBaseMisc.Class, value);
            }
        }
        public int SoulLevel
        {
            get => Loaded ? PlayerParam.ReadInt32((int)DS2Offsets.Attributes.SoulLevel) : 0;
            set => PlayerParam.WriteInt32((int)DS2Offsets.Attributes.SoulLevel, value);
        }
        public int SoulMemory
        {
            get => Loaded ? PlayerParam.ReadInt32((int)DS2Offsets.PlayerParam.SoulMemory) : 0;
            set => PlayerParam.WriteInt32((int)DS2Offsets.PlayerParam.SoulMemory, value);
        }
        public int SoulMemory2
        {
            get => Loaded ? PlayerParam.ReadInt32((int)DS2Offsets.PlayerParam.SoulMemory2) : 0;
            set => PlayerParam.WriteInt32((int)DS2Offsets.PlayerParam.SoulMemory2, value);
        }
        public byte SinnerLevel
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.PlayerParam.SinnerLevel) : (byte)0;
            set => PlayerParam.WriteByte((int)DS2Offsets.PlayerParam.SinnerLevel, value);
        }
        public byte SinnerPoints
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.PlayerParam.SinnerPoints) : (byte)0;
            set => PlayerParam.WriteByte((int)DS2Offsets.PlayerParam.SinnerPoints, value);
        }
        public byte HollowLevel
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.PlayerParam.HollowLevel) : (byte)0;
            set => PlayerParam.WriteByte((int)DS2Offsets.PlayerParam.HollowLevel, value);
        }
        public int Souls
        {
            get => Loaded ? PlayerParam.ReadInt32((int)DS2Offsets.PlayerParam.Souls) : 0;
        }

        public short Vigor
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Attributes.VGR) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Attributes.VGR, value);
                UpdateSoulLevel();
            }
        }
        public short Endurance
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Attributes.END) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Attributes.END, value);
                UpdateSoulLevel();
            }
        }
        public short Vitality
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Attributes.VIT) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Attributes.VIT, value);
                UpdateSoulLevel();
            }
        }
        public short Attunement
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Attributes.ATN) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Attributes.ATN, value);
                UpdateSoulLevel();
            }
        }
        public short Strength
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Attributes.STR) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Attributes.STR, value);
                UpdateSoulLevel();
            }
        }
        public short Dexterity
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Attributes.DEX) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Attributes.DEX, value);
                UpdateSoulLevel();
            }
        }
        public short Adaptability
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Attributes.ADP) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Attributes.ADP, value);
                UpdateSoulLevel();
            }
        }
        public short Intelligence
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Attributes.INT) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Attributes.INT, value);
                UpdateSoulLevel();
            }
        }
        public short Faith
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Attributes.FTH) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Attributes.FTH, value);
                UpdateSoulLevel();
            }
        }
        //TODO: properties
        //public void GiveSouls(int souls)
        //{
        //    var asm = string.Format(Properties.Resources.AddSouls, PlayerParam.Resolve().ToString("X2"), souls.ToString("X2"), GiveSoulsFunc.Resolve().ToString("X2"));
        //    AsmExecute(asm);
        //}
        private void UpdateSoulLevel()
        {
            var charClass = DS2Class.All.FirstOrDefault(c => c.ID == Class);
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
        private int GetSoulLevel(DS2Class charClass)
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
            var charClass = DS2Class.All.FirstOrDefault(c => c.ID == Class);
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

            var tableLength = LevelUpSoulsParam.ReadInt32((int)DS2Offsets.Param.TableLength);
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
            get => AiManager.ReadBoolean((int)DS2Offsets.AiManagerOffsets.DisableAllAi);
            set => AiManager.WriteBoolean((int)DS2Offsets.AiManagerOffsets.DisableAllAi, value);
        }

        //GameManagerImp 0x74 -> PlayerCtrl 0x2d4 -> ChrAsmCtrl 0x14? -> 0x138? -> offset 0 = damage multiplier
        public float RightWeapon1DamageMultiplier
        {
            get => EquipedWeapons.ReadSingle((int)DS2Offsets.EquipedWeaponsOffsets.RightHand1);
            set => EquipedWeapons.WriteSingle((int)DS2Offsets.EquipedWeaponsOffsets.RightHand1, value);
        }

        //TODO: impl.
        public float LeftWeapon1DamageMultiplier
        {
            get;
            set;
        }
        #endregion



        #region Items
        //TODO: properties
        //public void GetItem(int item, short amount, byte upgrade, byte infusion, bool silent)
        //{
        //    if (silent)
        //        GiveItemSilently(item, amount, upgrade, infusion);
        //    //TODO: properties
        //    //else
        //    //    GiveItem(item, amount, upgrade, infusion);
        //}
        //
        ////TODO: properties
        ////private void GiveItem(int item, short amount, byte upgrade, byte infusion)
        ////{
        ////    //GiveItemSilently(item, amount, upgrade, infusion);
        ////    //return;
        ////
        ////    var itemStruct = Allocate(0x8A);
        ////    Kernel32.WriteBytes(Handle, itemStruct + 0x4, BitConverter.GetBytes(item));
        ////    Kernel32.WriteBytes(Handle, itemStruct + 0x8, BitConverter.GetBytes(float.MaxValue));
        ////    Kernel32.WriteBytes(Handle, itemStruct + 0xC, BitConverter.GetBytes(amount));
        ////    Kernel32.WriteByte(Handle, itemStruct + 0xE, upgrade);
        ////    Kernel32.WriteByte(Handle, itemStruct + 0xF, infusion);
        ////
        ////    var asm = string.Format(Properties.Resources.GiveItemWithMenu, itemStruct.ToString("X2"), AvailableItemBag.Resolve().ToString("X2"), ItemGiveFunc.Resolve().ToString("X2"), ItemStruct2dDisplay.Resolve().ToString("X2"),
        ////        ItemGiveWindow.Resolve().ToString("X2"), DisplayItem.Resolve().ToString("X2"), (PointerArray.Resolve() + (int)DS2Offsets.PointerArrayOffset4).ToString("X2"));
        ////    AsmExecute(asm);
        ////    Free(itemStruct);
        ////}
        //
        //private void GiveItemSilently(int item, short amount, byte upgrade, byte infusion)
        //{
        //    var itemStruct = Allocate(0x8A);
        //    Kernel32.WriteBytes(Handle, itemStruct + 0x4, BitConverter.GetBytes(item));
        //    Kernel32.WriteBytes(Handle, itemStruct + 0x8, BitConverter.GetBytes(float.MaxValue));
        //    Kernel32.WriteBytes(Handle, itemStruct + 0xC, BitConverter.GetBytes(amount));
        //    Kernel32.WriteByte(Handle, itemStruct + 0xE, upgrade);
        //    Kernel32.WriteByte(Handle, itemStruct + 0xF, infusion);
        //
        //    var asm = string.Format(Properties.Resources.GiveItemWithoutMenu, itemStruct.ToString("X2"), AvailableItemBag.Resolve().ToString("X2"), ItemGiveFunc.Resolve().ToString("X2"));
        //    AsmExecute(asm);
        //    Free(itemStruct);
        //}
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
            var paramName = pointer.ReadString((int)DS2Offsets.Param.ParamName, Encoding.UTF8, 0x18);
            if (paramName != expectedParamName)
                throw new InvalidOperationException($"Incorrect Param Pointer: {expectedParamName}");

            var tableLength = pointer.ReadInt32((int)DS2Offsets.Param.TableLength);
            var param = 0x40;
            var paramID = 0x0;
            var paramOffset = 0x4;
            var nextParam = 0xC;

            while (param < tableLength)
            {
                var itemID = pointer.ReadInt32(param + paramID);
                var itemParamOffset = pointer.ReadInt32(param + paramOffset);
                dictionary.Add(itemID, itemParamOffset);

                param += nextParam;
            }

            return dictionary;
        }
        internal int GetMaxUpgrade(DS2Item item)
        {
            switch (item.Type)
            {
                case DS2Item.ItemType.Weapon:
                    return GetWeaponMaxUpgrade(item.ID);
                case DS2Item.ItemType.Armor:
                    return GetArmorMaxUpgrade(item.ID);
                case DS2Item.ItemType.Item:
                case DS2Item.ItemType.Ring:
                    return 0;
            }

            return 0;
        }
        internal int GetMaxQuantity(DS2Item item)
        {
            switch (item.Type)
            {
                case DS2Item.ItemType.Ring:
                case DS2Item.ItemType.Weapon:
                case DS2Item.ItemType.Armor:
                    return 1;
                case DS2Item.ItemType.Item:
                    return GetMaxItemQuantity(item.ID);
            }

            return 0;
        }
        internal int GetHeld(DS2Item item)
        {
            switch (item.Type)
            {
                case DS2Item.ItemType.Ring:
                case DS2Item.ItemType.Weapon:
                case DS2Item.ItemType.Armor:
                    return 0;
                case DS2Item.ItemType.Item:
                    return GetHeldInInventory(item.ID);
            }

            return 0;
        }

        private int GetHeldInInventory(int id)
        {
            var inventorySlot = 0x18;
            var itemOffset = 0x0;
            var boxOffset = 0x4;
            var heldOffset = 0x8;
            var nextOffset = 0x10;

            var endPointer = AvailableItemBag.ReadIntPtr(0x10).ToInt32();
            var bagSize = endPointer - AvailableItemBag.Resolve().ToInt32();

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
            //    if (itemID != id)
            //    {
            //        inventorySlot += nextOffset;
            //        continue;
            //    }

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
            if (!Setup) return 0;
            return ArmorReinforceParam.ReadInt32(ArmorReinforceParamOffsetDict[id - 10000000] + (int)DS2Offsets.ArmorReinforceParam.MaxUpgrade);
        }
        private int GetWeaponMaxUpgrade(int id)
        {
            if (!Setup) return 0;
            var reinforceParamID = WeaponParam.ReadInt32(WeaponParamOffsetDict[id] + (int)DS2Offsets.WeaponParam.ReinforceID);
            return WeaponReinforceParam.ReadInt32(WeaponReinforceParamOffsetDict[reinforceParamID] + (int)DS2Offsets.WeaponReinforceParam.MaxUpgrade);
        }
        private int GetMaxItemQuantity(int id)
        {
            if (!Setup) return 0;
            return ItemParam.ReadInt16(ItemParamOffsetDict[id] + (int)DS2Offsets.ItemParam.MaxHeld);
        }

        internal List<DS2Infusion> GetWeaponInfusions(int id)
        {
            var infusions = new List<DS2Infusion>() { DS2Infusion.Infusions[0] };
            var reinforceParamID = WeaponParam.ReadInt32(WeaponParamOffsetDict[id] + (int)DS2Offsets.WeaponParam.ReinforceID);
            var customAttrID = WeaponReinforceParam.ReadInt32(WeaponReinforceParamOffsetDict[reinforceParamID] + (int)DS2Offsets.WeaponReinforceParam.CustomAttrID);
            var bitField = CustomAttrSpecParam.ReadInt32(CustomAttrOffsetDict[customAttrID]);

            if (bitField == 0)
                return infusions;

            for (int i = 1; i < DS2Infusion.Infusions.Count; i++)
            {
                if ((bitField & (1 << i)) != 0)
                    infusions.Add(DS2Infusion.Infusions[i]);
            }

            return infusions;
        }
        internal bool GetIsDroppable(int id)
        {
            if (!Setup) return false;
            var itemUsageID = ItemParam.ReadInt32(ItemParamOffsetDict[id] + (int)DS2Offsets.ItemParam.ItemUsageID);
            byte bitField = ItemUseageParam.ReadByte(ItemUsageParamOffsetDict[itemUsageID] + (int)DS2Offsets.ItemUasgeParam.Bitfield);

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
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.FireKeepersDwelling);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.FireKeepersDwelling, level);
            }
        }

        public byte TheFarFire
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.TheFarFire);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.TheFarFire, level);
            }
        }
        public byte TheCrestfallensRetreat
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.CrestfallensRetreat);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.CrestfallensRetreat, level);
            }
        }
        public byte CardinalTower
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.CardinalTower);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.CardinalTower, level);
            }
        }
        public byte SoldiersRest
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.SoldiersRest);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.SoldiersRest, level);
            }
        }
        public byte ThePlaceUnbeknownst
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.ThePlaceUnbeknownst);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.ThePlaceUnbeknownst, level);
            }
        }
        public byte HeidesRuin
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.HeidesRuin);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.HeidesRuin, level);
            }
        }
        public byte TowerofFlame
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.TowerofFlame);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.TowerofFlame, level);
            }
        }
        public byte TheBlueCathedral
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.TheBlueCathedral);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.TheBlueCathedral, level);
            }
        }
        public byte UnseenPathtoHeide
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UnseenPathtoHeide);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UnseenPathtoHeide, level);
            }
        }
        public byte ExileHoldingCells
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.ExileHoldingCells);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.ExileHoldingCells, level);
            }
        }
        public byte McDuffsWorkshop
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.McDuffsWorkshop);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.McDuffsWorkshop, level);
            }
        }
        public byte ServantsQuarters
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.ServantsQuarters);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.ServantsQuarters, level);
            }
        }
        public byte StraidsCell
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.StraidsCell);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.StraidsCell, level);
            }
        }
        public byte TheTowerApart
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.TheTowerApart);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.TheTowerApart, level);
            }
        }
        public byte TheSaltfort
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.TheSaltfort);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.TheSaltfort, level);
            }
        }
        public byte UpperRamparts
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UpperRamparts);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UpperRamparts, level);
            }
        }
        public byte UndeadRefuge
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UndeadRefuge);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UndeadRefuge, level);
            }
        }
        public byte BridgeApproach
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.BridgeApproach);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.BridgeApproach, level);
            }
        }
        public byte UndeadLockaway
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UndeadLockaway);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UndeadLockaway, level);
            }
        }
        public byte UndeadPurgatory
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UndeadPurgatory);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UndeadPurgatory, level);
            }
        }
        public byte PoisonPool
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.PoisonPool);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.PoisonPool, level);
            }
        }
        public byte TheMines
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.TheMines);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.TheMines, level);
            }
        }
        public byte LowerEarthenPeak
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.LowerEarthenPeak);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.LowerEarthenPeak, level);
            }
        }
        public byte CentralEarthenPeak
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.CentralEarthenPeak);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.CentralEarthenPeak, level);
            }
        }
        public byte UpperEarthenPeak
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UpperEarthenPeak);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UpperEarthenPeak, level);
            }
        }
        public byte ThresholdBridge
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.ThresholdBridge);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.ThresholdBridge, level);
            }
        }
        public byte IronhearthHall
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.IronhearthHall);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.IronhearthHall, level);
            }
        }
        public byte EygilsIdol
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.EygilsIdol);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.EygilsIdol, level);
            }
        }
        public byte BelfrySolApproach
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.BelfrySolApproach);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.BelfrySolApproach, level);
            }
        }
        public byte OldAkelarre
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.OldAkelarre);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.OldAkelarre, level);
            }
        }
        public byte RuinedForkRoad
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.RuinedForkRoad);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.RuinedForkRoad, level);
            }
        }
        public byte ShadedRuins
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.ShadedRuins);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.ShadedRuins, level);
            }
        }
        public byte GyrmsRespite
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.GyrmsRespite);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.GyrmsRespite, level);
            }
        }
        public byte OrdealsEnd
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.OrdealsEnd);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.OrdealsEnd, level);
            }
        }
        public byte RoyalArmyCampsite
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.RoyalArmyCampsite);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.RoyalArmyCampsite, level);
            }
        }
        public byte ChapelThreshold
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.ChapelThreshold);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.ChapelThreshold, level);
            }
        }
        public byte LowerBrightstoneCove
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.LowerBrightstoneCove);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.LowerBrightstoneCove, level);
            }
        }
        public byte HarvalsRestingPlace
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.HarvalsRestingPlace);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.HarvalsRestingPlace, level);
            }
        }
        public byte GraveEntrance
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.GraveEntrance);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.GraveEntrance, level);
            }
        }
        public byte UpperGutter
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UpperGutter);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UpperGutter, level);
            }
        }
        public byte CentralGutter
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.CentralGutter);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.CentralGutter, level);
            }
        }
        public byte HiddenChamber
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.HiddenChamber);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.HiddenChamber, level);
            }
        }
        public byte BlackGulchMouth
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.BlackGulchMouth);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.BlackGulchMouth, level);
            }
        }
        public byte KingsGate
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.KingsGate);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.KingsGate, level);
            }
        }
        public byte UnderCastleDrangleic
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UnderCastleDrangleic);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UnderCastleDrangleic, level);
            }
        }
        public byte ForgottenChamber
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.ForgottenChamber);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.ForgottenChamber, level);
            }
        }
        public byte CentralCastleDrangleic
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.CentralCastleDrangleic);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.CentralCastleDrangleic, level);
            }
        }
        public byte TowerofPrayerAmana
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.TowerofPrayerAmana);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.TowerofPrayerAmana, level);
            }
        }
        public byte CrumbledRuins
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.CrumbledRuins);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.CrumbledRuins, level);
            }
        }
        public byte RhoysRestingPlace
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.RhoysRestingPlace);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.RhoysRestingPlace, level);
            }
        }
        public byte RiseoftheDead
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.RiseoftheDead);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.RiseoftheDead, level);
            }
        }
        public byte UndeadCryptEntrance
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UndeadCryptEntrance);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UndeadCryptEntrance, level);
            }
        }
        public byte UndeadDitch
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UndeadDitch);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UndeadDitch, level);
            }
        }
        public byte Foregarden
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.Foregarden);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.Foregarden, level);
            }
        }
        public byte RitualSite
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.RitualSite);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.RitualSite, level);
            }
        }
        public byte DragonAerie
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.DragonAerie);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.DragonAerie, level);
            }
        }
        public byte ShrineEntrance
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.ShrineEntrance);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.ShrineEntrance, level);
            }
        }
        public byte SanctumWalk
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.SanctumWalk);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.SanctumWalk, level);
            }
        }
        public byte PriestessChamber
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.PriestessChamber);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.PriestessChamber, level);
            }
        }
        public byte HiddenSanctumChamber
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.HiddenSanctumChamber);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.HiddenSanctumChamber, level);
            }
        }
        public byte LairoftheImperfect
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.LairoftheImperfect);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.LairoftheImperfect, level);
            }
        }
        public byte SanctumInterior
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.SanctumInterior);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.SanctumInterior, level);
            }
        }
        public byte TowerofPrayerShulva
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.TowerofPrayerShulva);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.TowerofPrayerShulva, level);
            }
        }
        public byte SanctumNadir
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.SanctumNadir);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.SanctumNadir, level);
            }
        }
        public byte ThroneFloor
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.ThroneFloor);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.ThroneFloor, level);
            }
        }
        public byte UpperFloor
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.UpperFloor);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.UpperFloor, level);
            }
        }
        public byte Foyer
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.Foyer);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.Foyer, level);
            }
        }
        public byte LowermostFloor
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.LowermostFloor);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.LowermostFloor, level);
            }
        }
        public byte TheSmelterThrone
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.TheSmelterThrone);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.TheSmelterThrone, level);
            }
        }
        public byte IronHallwayEntrance
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.IronHallwayEntrance);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.IronHallwayEntrance, level);
            }
        }
        public byte OuterWall
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.OuterWall);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.OuterWall, level);
            }
        }
        public byte AbandonedDwelling
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.AbandonedDwelling);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.AbandonedDwelling, level);
            }
        }
        public byte ExpulsionChamber
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.ExpulsionChamber);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.ExpulsionChamber, level);
            }
        }
        public byte InnerWall
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.InnerWall);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.InnerWall, level);
            }
        }
        public byte LowerGarrison
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.LowerGarrison);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.LowerGarrison, level);
            }
        }
        public byte GrandCathedral
        {
            get
            {
                byte level = 0;

                if (Loaded)
                {
                    level = BonfireLevels.ReadByte((int)DS2Offsets.BonfireLevels.GrandCathedral);
                    level = (byte)((level + 1) / 2);
                }

                return level;
            }
            set
            {
                byte level = 0;
                if (value > 0)
                    level = (byte)(value * 2 - 1);
                BonfireLevels.WriteByte((int)DS2Offsets.BonfireLevels.GrandCathedral, level);
            }
        }

        public void UnlockBonfires()
        {
            foreach (DS2Offsets.BonfireLevels bonfire in Enum.GetValues(typeof(DS2Offsets.BonfireLevels)))
            {
                var currentLevel = BonfireLevels.ReadByte((int)bonfire);

                if (bonfire == DS2Offsets.BonfireLevels.FireKeepersDwelling)
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
                var itemID = Equipment.ReadInt32((int)DS2Offsets.PlayerEquipment.Head);

                if (DS2Item.Items.ContainsKey(itemID + 10000000))
                    return DS2Item.Items[itemID + 10000000];

                return itemID.ToString();
            }
        }
        public string Chest
        {
            get
            {
                if (!Loaded) return "";
                var itemID = Equipment.ReadInt32((int)DS2Offsets.PlayerEquipment.Chest);

                if (DS2Item.Items.ContainsKey(itemID + 10000000))
                    return DS2Item.Items[itemID + 10000000];

                return itemID.ToString();
            }
        }
        public string Arms
        {
            get
            {
                if (!Loaded) return "";
                var itemID = Equipment.ReadInt32((int)DS2Offsets.PlayerEquipment.Arms);

                if (DS2Item.Items.ContainsKey(itemID + 10000000))
                    return DS2Item.Items[itemID + 10000000];

                return itemID.ToString();
            }
        }
        public string Legs
        {
            get
            {
                if (!Loaded) return "";
                var itemID = Equipment.ReadInt32((int)DS2Offsets.PlayerEquipment.Legs);

                if (DS2Item.Items.ContainsKey(itemID + 10000000))
                    return DS2Item.Items[itemID + 10000000];

                return itemID.ToString();
            }
        }
        public string RightHand1
        {
            get
            {
                if (!Loaded) return "";
                var itemID = Equipment.ReadInt32((int)DS2Offsets.PlayerEquipment.RightHand1);

                if (DS2Item.Items.ContainsKey(itemID))
                    return DS2Item.Items[itemID];

                return itemID.ToString();
            }
        }
        public string RightHand2
        {
            get
            {
                if (!Loaded) return "";
                var itemID = Equipment.ReadInt32((int)DS2Offsets.PlayerEquipment.RightHand2);

                if (DS2Item.Items.ContainsKey(itemID))
                    return DS2Item.Items[itemID];

                return itemID.ToString();
            }
        }
        public string RightHand3
        {
            get
            {
                if (!Loaded) return "";
                var itemID = Equipment.ReadInt32((int)DS2Offsets.PlayerEquipment.RightHand3);

                if (DS2Item.Items.ContainsKey(itemID))
                    return DS2Item.Items[itemID];

                return itemID.ToString();
            }
        }
        public string LeftHand1
        {
            get
            {
                if (!Loaded) return "";
                var itemID = Equipment.ReadInt32((int)DS2Offsets.PlayerEquipment.LeftHand1);

                if (DS2Item.Items.ContainsKey(itemID))
                    return DS2Item.Items[itemID];

                return itemID.ToString();
            }
        }
        public string LeftHand2
        {
            get
            {
                if (!Loaded) return "";
                var itemID = Equipment.ReadInt32((int)DS2Offsets.PlayerEquipment.LeftHand2);

                if (DS2Item.Items.ContainsKey(itemID))
                    return DS2Item.Items[itemID];

                return itemID.ToString();
            }
        }
        public string LeftHand3
        {
            get
            {
                if (!Loaded) return "";
                var itemID = Equipment.ReadInt32((int)DS2Offsets.PlayerEquipment.LeftHand3);

                if (DS2Item.Items.ContainsKey(itemID))
                    return DS2Item.Items[itemID];

                return itemID.ToString();
            }
        }

        //TODO: properties

        //private bool _speedFactors;
        //public bool EnableSpeedFactors
        //{
        //    get => _speedFactors;
        //    set
        //    {
        //        _speedFactors = value;
        //        AccelerationStamina = value;
        //        AnimationSpeed = value;
        //        JumpSpeed = value;
        //        BuildupSpeed = value;
        //    }
        //}
        //
        //private IntPtr AccelSpeedPtr;
        //private IntPtr AccelSpeedCodePtr;
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
        //            InjectSpeedFactor(SpeedFactorAccel, ref AccelSpeedPtr, ref AccelSpeedCodePtr, Properties.Settings.Default.AccelSpeed);
        //        else
        //        {
        //            RepairSpeedFactor(SpeedFactorAccel, AccelSpeedPtr, AccelSpeedCodePtr, Properties.Resources.OgSpeedFactorAccel);
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
        //            InjectSpeedFactor(SpeedFactorAnim, ref AnimSpeedPtr, ref AnimSpeedCodePtr, Properties.Settings.Default.AnimSpeed);
        //        else
        //        {
        //            RepairSpeedFactor(SpeedFactorAnim, AnimSpeedPtr, AnimSpeedCodePtr, Properties.Resources.OgSpeedFactor);
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
        //            InjectSpeedFactor(SpeedFactorJump, ref JumpSpeedPtr, ref JumpSpeedCodePtr, Properties.Settings.Default.JumpSpeed);
        //        else
        //        {
        //            RepairSpeedFactor(SpeedFactorJump, JumpSpeedPtr, JumpSpeedCodePtr, Properties.Resources.OgSpeedFactorAccel);
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
        //            InjectSpeedFactor(SpeedFactorBuildup, ref BuildupSpeedPtr, ref BuildupSpeedCodePtr, Properties.Settings.Default.BuildupSpeed);
        //        else
        //        {
        //            RepairSpeedFactor(SpeedFactorBuildup, BuildupSpeedPtr, BuildupSpeedCodePtr, Properties.Resources.OgSpeedFactorAccel);
        //            BuildupSpeedPtr = IntPtr.Zero;
        //            BuildupSpeedCodePtr = IntPtr.Zero;
        //        }
        //    }
        //}
        //
        //private void RepairSpeedFactor(PHPointer speedFactorPointer, IntPtr valuePointer, IntPtr codePointer, string asm)
        //{
        //    var asmBytes = FasmNet.Assemble("use32\norg 0x0\n" + asm);
        //    speedFactorPointer.WriteBytes(0x0, asmBytes);
        //    Free(valuePointer);
        //    Free(codePointer);
        //}
        //
        //private void InjectSpeedFactor(PHPointer speedFactorPointer, ref IntPtr valuePointer, ref IntPtr codePointer, float value)
        //{
        //    var asmCode = string.Format(Properties.Resources.SpeedFactor, "FFFF0000", "FFFF0000");
        //    var asmCodeBytes = FasmNet.Assemble("use32\norg 0x0\n" + asmCode);
        //
        //    codePointer = GetPrefferedIntPtr(asmCodeBytes.Length, Kernel32.PAGE_EXECUTE_READWRITE);
        //    valuePointer = GetPrefferedIntPtr(sizeof(float));
        //    Kernel32.WriteBytes(Handle, valuePointer, BitConverter.GetBytes(value));
        //
        //    var offset = GetRelativeOffset(speedFactorPointer.Resolve(), codePointer);
        //    var asmInject = string.Format(Properties.Resources.SpeedFactorInject, offset.ToString("X2"));
        //    var asmInjectBytes = FasmNet.Assemble("use32\norg 0x0\n" + asmInject);
        //
        //    offset = GetRelativeOffset(codePointer, speedFactorPointer.Resolve() + asmInjectBytes.Length);
        //    asmCode = string.Format(Properties.Resources.SpeedFactor, valuePointer.ToString("X2"), offset.ToString("X2"));
        //    asmCodeBytes = FasmNet.Assemble("use32\norg 0x0\n" + asmCode);
        //    Kernel32.WriteBytes(Handle, codePointer, asmCodeBytes);
        //
        //    speedFactorPointer.WriteBytes(0x0, asmInjectBytes);
        //}

        #endregion

        #region Covenant

        public byte CurrentCovenant
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.Covenants.CurrentCovenant) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2Offsets.Covenants.CurrentCovenant, value);
            }
        }
        public string CurrentCovenantName
        {
            get => Loaded ? DS2Covenant.All.FirstOrDefault(x => x.ID == CurrentCovenant).Name : "";
        }
        public bool HeirsOfTheSunDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2Offsets.Covenants.HeirsOfTheSunDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2Offsets.Covenants.HeirsOfTheSunDiscovered, value);
            }
        }
        public byte HeirsOfTheSunRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.Covenants.HeirsOfTheSunOfTheSunRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2Offsets.Covenants.HeirsOfTheSunOfTheSunRank, value);
            }
        }
        public short HeirsOfTheSunProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Covenants.HeirsOfTheSunProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Covenants.HeirsOfTheSunProgress, value);
            }
        }
        public bool BlueSentinelsDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2Offsets.Covenants.BlueSentinelsDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2Offsets.Covenants.BlueSentinelsDiscovered, value);
            }
        }
        public byte BlueSentinelsRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.Covenants.BlueSentinelsRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2Offsets.Covenants.BlueSentinelsRank, value);
            }
        }
        public short BlueSentinelsProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Covenants.BlueSentinelsProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Covenants.BlueSentinelsProgress, value);
            }
        }
        public bool BrotherhoodOfBloodDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2Offsets.Covenants.BrotherhoodOfBloodDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2Offsets.Covenants.BrotherhoodOfBloodDiscovered, value);
            }
        }
        public byte BrotherhoodOfBloodRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.Covenants.BrotherhoodOfBloodRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2Offsets.Covenants.BrotherhoodOfBloodRank, value);
            }
        }
        public short BrotherhoodOfBloodProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Covenants.BrotherhoodOfBloodProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Covenants.BrotherhoodOfBloodProgress, value);
            }
        }
        public bool WayOfTheBlueDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2Offsets.Covenants.WayOfTheBlueDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2Offsets.Covenants.WayOfTheBlueDiscovered, value);
            }
        }
        public byte WayOfTheBlueRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.Covenants.WayOfTheBlueRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2Offsets.Covenants.WayOfTheBlueRank, value);
            }
        }
        public short WayOfTheBlueProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Covenants.WayOfTheBlueProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Covenants.WayOfTheBlueProgress, value);
            }
        }
        public bool RatKingDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2Offsets.Covenants.RatKingDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2Offsets.Covenants.RatKingDiscovered, value);
            }
        }
        public byte RatKingRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.Covenants.RatKingRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2Offsets.Covenants.RatKingRank, value);
            }
        }
        public short RatKingProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Covenants.RatKingProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Covenants.RatKingProgress, value);
            }
        }
        public bool BellKeepersDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2Offsets.Covenants.BellKeepersDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2Offsets.Covenants.BellKeepersDiscovered, value);
            }
        }
        public byte BellKeepersRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.Covenants.BellKeepersRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2Offsets.Covenants.BellKeepersRank, value);
            }
        }
        public short BellKeepersProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Covenants.BellKeepersProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Covenants.BellKeepersProgress, value);
            }
        }
        public bool DragonRemnantsDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2Offsets.Covenants.DragonRemnantsDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2Offsets.Covenants.DragonRemnantsDiscovered, value);
            }
        }
        public byte DragonRemnantsRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.Covenants.DragonRemnantsRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2Offsets.Covenants.DragonRemnantsRank, value);
            }
        }
        public short DragonRemnantsProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Covenants.DragonRemnantsProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Covenants.DragonRemnantsProgress, value);
            }
        }
        public bool CompanyOfChampionsDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2Offsets.Covenants.CompanyOfChampionsDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2Offsets.Covenants.CompanyOfChampionsDiscovered, value);
            }
        }
        public byte CompanyOfChampionsRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.Covenants.CompanyOfChampionsRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2Offsets.Covenants.CompanyOfChampionsRank, value);
            }
        }
        public short CompanyOfChampionsProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Covenants.CompanyOfChampionsProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Covenants.CompanyOfChampionsProgress, value);
            }
        }
        public bool PilgrimsOfDarknessDiscovered
        {
            get => Loaded ? PlayerParam.ReadBoolean((int)DS2Offsets.Covenants.PilgrimsOfDarknessDiscovered) : false;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteBoolean((int)DS2Offsets.Covenants.PilgrimsOfDarknessDiscovered, value);
            }
        }
        public byte PilgrimsOfDarknessRank
        {
            get => Loaded ? PlayerParam.ReadByte((int)DS2Offsets.Covenants.PilgrimsOfDarknessRank) : (byte)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteByte((int)DS2Offsets.Covenants.PilgrimsOfDarknessRank, value);
            }
        }
        public short PilgrimsOfDarknessProgress
        {
            get => Loaded ? PlayerParam.ReadInt16((int)DS2Offsets.Covenants.PilgrimsOfDarknessProgress) : (short)0;
            set
            {
                if (Reading || !Loaded) return;
                PlayerParam.WriteInt16((int)DS2Offsets.Covenants.PilgrimsOfDarknessProgress, value);
            }
        }

        #endregion

    }
}
