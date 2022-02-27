
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using SoulMemory;
using SoulMemory.DarkSouls1;
using Testing.Tas;

namespace Testing
{
    [TestFixture]
    internal class DarkSouls1
    {
        private static DarkSouls1ToolAssistant _assistant;
        private static SoulMemory.DarkSouls1.DarkSouls1 _darkSouls1;


        public static string SaveFileName = "DRAKS0005.sl2";
        public static string SaveFileLocation;
        public static string ReplacementSave;


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var gameType = GameType.DarkSoulsRemastered;
            var nbgiPath = @"C:\Users\Frank\Documents\NBGI";

            switch (gameType)
            {
                case GameType.DarkSoulsRemastered:
                    SaveFileLocation = $@"{nbgiPath}\DARK SOULS REMASTERED\72957510";
                    ReplacementSave = "remastered";
                    break;

                case GameType.DarkSoulsPtde:
                    SaveFileLocation = $@"{nbgiPath}\DarkSouls\GroupMink920669";
                    ReplacementSave = "ptde";
                    break;

                //The save file is being made here but it seems like ptde/cracked use the same settings.. is kind of vague if this is using it's own savefile or not..
                case GameType.DarkSoulsCracked:
                    SaveFileLocation = $@"{nbgiPath}\DarkSouls";
                    ReplacementSave = "cracked";
                    break;

                default:
                    throw new Exception("Not supported");
            }


            //Rename current save
            if (File.Exists(SaveFileLocation + "\\" + SaveFileName))
            {
                if (File.Exists(SaveFileLocation + "\\automated_backup"))
                {
                    File.Delete(SaveFileLocation + "\\automated_backup");
                }
                File.Move(SaveFileLocation + "\\" + SaveFileName, SaveFileLocation + "\\automated_backup");
            }
            //Replace with test save
            File.Move(Environment.CurrentDirectory + $@"\saves\DarkSouls1\{ReplacementSave}\UndeadAsylum", SaveFileLocation + "\\" + SaveFileName);

            _darkSouls1 = new SoulMemory.DarkSouls1.DarkSouls1();
            _darkSouls1.SetCheat(CheatType.PlayerExterminate     , true);
            _darkSouls1.SetCheat(CheatType.PlayerNoDead          , true);
            _darkSouls1.SetCheat(CheatType.AllNoStaminaConsume   , true);
            _darkSouls1.SetCheat(CheatType.AllNoUpdateAI         , true);
            
            _assistant = new DarkSouls1ToolAssistant(_darkSouls1, gameType);
            _assistant.SaveQuit();
            _assistant.MainMenuContinue();


            //Make sure the game is running
            if (!_darkSouls1.IsGameAttached)
            {
                throw new Exception();
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _assistant.SaveQuit();
        
            //Bring the game back into a non-cheated state
            _darkSouls1.SetCheat(CheatType.PlayerExterminate     , false);
            _darkSouls1.SetCheat(CheatType.PlayerNoDead          , false);
            _darkSouls1.SetCheat(CheatType.AllNoStaminaConsume   , false);
            _darkSouls1.SetCheat(CheatType.AllNoUpdateAI         , false);
        
            //restore savefile
            File.Delete(SaveFileLocation + "\\" + SaveFileName);
            File.Move(SaveFileLocation + "\\automated_backup", SaveFileLocation + "\\" + SaveFileName);
        }

        #region Boss kills

        public delegate void KillBossMethod();

        public static List<(BossType, KillBossMethod)> BossKills = new List<(BossType, KillBossMethod)>()
        {
            (BossType.AsylumDemon       , KillAsylumDemon),
            (BossType.TaurusDemon       , KillTaurusDemon),
            (BossType.MoonlightButterfly, KillMoonlightButterfly),
            (BossType.Gargoyles         , KillGargoyles),
            (BossType.CapraDemon        , KillCapraDemon),
            (BossType.GapingDragon      , KillGapingDragon),
            (BossType.StrayDemon        , KillStrayDemon),

            (BossType.Quelaag           , KillQuelaag),
            (BossType.CeaselessDischarge, KillCeaselessDischarge),
            (BossType.Firesage          , KillFiresage),
            (BossType.CentipedeDemon    , KillCentipedeDemon),
            (BossType.BedOfChaos        , KillBedOfChaos),

            (BossType.IronGolem         , KillIronGolem),
            (BossType.OrnsteinAndSmough , KillOrnsteinAndSmough),
            (BossType.Gwyndolin         , KillGwyndolin),
            (BossType.Priscilla         , KillPriscilla),

            (BossType.Seath             , KillSeath),

            (BossType.Sif               , KillSif),
            (BossType.FourKings         , KillFourKings),
            
            (BossType.Nito              , KillNito),
            (BossType.Pinwheel          , KillPinwheel),


            (BossType.SanctuaryGuardian , KillSanctuaryGuardian),
            (BossType.Artorias          , KillArtorias),
            (BossType.Kalameet          , KillKalameet),
            (BossType.Manus             , KillManus),

            (BossType.Gwyn              , KillGwyn),
        };

        [TestCaseSource(nameof(BossKills))]
        public void BossKill((BossType, KillBossMethod) param)
        {
            var bossType = param.Item1;
            var func = param.Item2;

            var stateBefore = _darkSouls1.IsBossDefeated(bossType);
            func();
            var stateAfter = _darkSouls1.IsBossDefeated(bossType);

            Assert.AreEqual(false, stateBefore);
            Assert.AreEqual(true, stateAfter);
        }


        private static void KillAsylumDemon()
        {
            _darkSouls1.BonfireWarp(WarpType.NorthernUndeadAsylumBonfire1);
            Thread.Sleep(3000);

            _darkSouls1.Teleport(new Vector3f(3.0f, 198.0f, -25.0f), 180);
            Thread.Sleep(3000);

            _assistant.Punch();
            Thread.Sleep(7000);
        }

        private static void KillStrayDemon()
        {
            _darkSouls1.BonfireWarp(WarpType.FirelinkShrineBonfire);
            Thread.Sleep(3000);
            
            _darkSouls1.Teleport(new Vector3f(-43.0f, -31.0f, 101.0f), 180);
            Thread.Sleep(3000);
            _assistant.Interact();
            Thread.Sleep(22000); //22 sec :(
            _assistant.SkipCutscene();
            
            Thread.Sleep(1500);//game loads back into asylum
            _assistant.SkipCutscene();
            Thread.Sleep(100);
            
            //Break the floor
            _darkSouls1.Teleport(new Vector3f(3.0f, 198.0f, -22.0f), 180);
            Thread.Sleep(100);

            //Kill
            _darkSouls1.Teleport(new Vector3f(5.0f, 182.0f, -12.0f), 0);
            Thread.Sleep(2000);
            _assistant.Punch();

            Thread.Sleep(12000);
        }

        private static void KillGargoyles()
        {
            _darkSouls1.BonfireWarp(WarpType.UndeadParishNearCell);
            Thread.Sleep(3000);

            //The bossfight won't trigger unless we pass through the foggate
            _darkSouls1.Teleport(new Vector3f(17.0f, 48.0f, 74.0f), 0);
            Thread.Sleep(3000);
            _assistant.Interact();
            Thread.Sleep(3300);


            _darkSouls1.Teleport(new Vector3f(15.0f, 48.0f, 90.0f), 0);
            Thread.Sleep(1000);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            _darkSouls1.Teleport(new Vector3f(11.0f, 49.0f, 103.0f), 0);
            Thread.Sleep(500);
            _assistant.Punch();
            Thread.Sleep(1000);

            _darkSouls1.Teleport(new Vector3f(11.0f, 49.0f, 122.0f), 0);
            Thread.Sleep(4500);
            _assistant.Punch();

            Thread.Sleep(5500);
        }


        private static void KillTaurusDemon()
        {
            _darkSouls1.BonfireWarp(WarpType.UndeadBurgBonfire);
            Thread.Sleep(3000);

            //Trigger Taurus to jump down
            _darkSouls1.Teleport(new Vector3f(23.0f, 16.0f, -120.0f), 270);
            Thread.Sleep(1000);

            _darkSouls1.Teleport(new Vector3f(3.0f, 16.0f, -115.0f), 270);
            Thread.Sleep(2000);

            _assistant.Punch();
            Thread.Sleep(5500);
        }

        private static void KillMoonlightButterfly()
        {
            _darkSouls1.BonfireWarp(WarpType.DarkrootGardenBonfire);
            Thread.Sleep(3000);

            //Trigger fight
            _darkSouls1.Teleport(new Vector3f(179.0f, 8.0f, 30.0f), 312);

            //boop her head
            Thread.Sleep(12000);
            _darkSouls1.Teleport(new Vector3f(170.7f, 16.0f, 32.4f), 312);
            Thread.Sleep(1000);
            _darkSouls1.Teleport(new Vector3f(179.0f, 8.0f, 30.0f), 312);

            Thread.Sleep(5000);
        }

        private static void KillCapraDemon()
        {
            _darkSouls1.BonfireWarp(WarpType.UndeadBurgBonfire);
            Thread.Sleep(3000);

            _darkSouls1.Teleport(new Vector3f(-81.0f, -43.0f, -2.5f), 0); 
            Thread.Sleep(2000);

            _assistant.Punch();
            Thread.Sleep(5500);
        }

        private static void KillGapingDragon()
        {
            _darkSouls1.BonfireWarp(WarpType.DepthsGapingDragonsRoom);
            Thread.Sleep(3000);

            //Trigger cutscene & boss spawn
            _darkSouls1.Teleport(new Vector3f(-167.0f, -100.0f, -10.0f), 0);
            Thread.Sleep(1000);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            //Teleport to boss & kill
            _darkSouls1.Teleport(new Vector3f(-170.0f, -100.0f, 25.0f), 0);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(7000);
        }

        private static void KillQuelaag()
        {
            _darkSouls1.BonfireWarp(WarpType.BlighttownSwampBonfire);
            Thread.Sleep(3000);
            
            _darkSouls1.Teleport(new Vector3f(16.0f, -237.0f, 113.0f), 0);
            Thread.Sleep(2000);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            _darkSouls1.Teleport(new Vector3f(74.5f, -238.7f, 125.0f), 90);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(6000);
        }

        private static void KillCeaselessDischarge()
        {
            _darkSouls1.BonfireWarp(WarpType.DemonRuinsBonfire1);
            Thread.Sleep(3500);

            //Foggate must be traversed to active the fight
            _darkSouls1.Teleport(new Vector3f(248.0f, -283.0f, 70.0f), 49);
            Thread.Sleep(2000);
            _assistant.Interact();
            Thread.Sleep(3000);

            _darkSouls1.Teleport(new Vector3f(405.0f, -278.0f, 48.0f), 82);
            Thread.Sleep(2000);

            _assistant.UseItem();
            Thread.Sleep(15000);

            _assistant.SkipCutscene();
            Thread.Sleep(1000);
        }

        private static void KillFiresage()
        {
            _darkSouls1.BonfireWarp(WarpType.DemonRuinsBonfire2);
            Thread.Sleep(3000);

            _darkSouls1.Teleport(new Vector3f(119.0f, -341.0f, 127.0f), 317);
            Thread.Sleep(2000);

            _assistant.Punch();
            Thread.Sleep(8000);
        }

        private static void KillCentipedeDemon()
        {
            _darkSouls1.BonfireWarp(WarpType.DemonRuinsBonfire3);
            Thread.Sleep(3000);

            //Trigger fight
            _darkSouls1.Teleport(new Vector3f(167, -383.0f, 78.0f), 140);
            Thread.Sleep(1000);
            _assistant.SkipCutscene();
            Thread.Sleep(1000);

            _darkSouls1.Teleport(new Vector3f(203.2f, -383.7f, 49.5f), 9);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(8000);
        }

        private static void KillBedOfChaos()
        {
            _darkSouls1.BonfireWarp(WarpType.LostIzalithBonfire2);
            Thread.Sleep(3000);

            //kill right
            _darkSouls1.Teleport(new Vector3f(572.8f, -440.13f, 421.1f), 4);
            Thread.Sleep(2000);
            _assistant.Punch(); 
            Thread.Sleep(1500);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            //kill left
            _darkSouls1.Teleport(new Vector3f(556.2f, -440.13f, 440.4f), 84);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(1500);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            //Kill middle
            _darkSouls1.Teleport(new Vector3f(581.4f, -444.0f, 445.0f), 14);
            Thread.Sleep(1500);
            _assistant.Punch();
            Thread.Sleep(6000);
        }

        private static void KillIronGolem()
        {
            _darkSouls1.BonfireWarp(WarpType.SensFortressBonfire);
            Thread.Sleep(3000);

            //trigger fight
            _darkSouls1.Teleport(new Vector3f(84.0f, 82.0f, 255.5f), 90);
            Thread.Sleep(100);

            _darkSouls1.Teleport(new Vector3f(123.7f, 82.0f, 255.5f), 90);
            Thread.Sleep(2000);

            _assistant.Punch();
            Thread.Sleep(5000);
        }

        private static void KillOrnsteinAndSmough()
        {
            _darkSouls1.BonfireWarp(WarpType.AnorLondoGwynevereBonfire);
            Thread.Sleep(3000);

            //Trigger fight
            _darkSouls1.Teleport(new Vector3f(538.0f, 143.0f, 255.0f), 0);
            Thread.Sleep(1000);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            //kill o, skip wait and skip cutscene
            _darkSouls1.Teleport(new Vector3f(577.0f, 143.0f, 253.0f), 90);
            Thread.Sleep(1500);
            _assistant.Punch();
            Thread.Sleep(4500);
            _assistant.SkipCutscene();

            //kill s, skip wait and skip cutscene
            _darkSouls1.Teleport(new Vector3f(571.0f, 143.0f, 255.0f), 90);
            Thread.Sleep(1500);
            _assistant.Punch();

            Thread.Sleep(5500);
        }


        private static void KillGwyndolin()
        {
            _darkSouls1.BonfireWarp(WarpType.AnorLondoGwyndolinonfire);
            Thread.Sleep(3500);

            //Trigger fight
            _darkSouls1.Teleport(new Vector3f(436.0f, 60.0f, 255.0f), 90);
            Thread.Sleep(1000);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            _darkSouls1.Teleport(new Vector3f(479.0f, 30.0f, 255.0f), 90);
            Thread.Sleep(100);
            _assistant.Punch();
            Thread.Sleep(1000);
            _assistant.SkipCutscene();

            Thread.Sleep(2000);
        }

        private static void KillPriscilla()
        {
            _darkSouls1.BonfireWarp(WarpType.PaintedWorldOfAriamisBonfire);
            Thread.Sleep(3500);

            _darkSouls1.Teleport(new Vector3f(-22.8f, 60.2f, 697.5f), 180);
            Thread.Sleep(2000);

            _assistant.Punch();
            Thread.Sleep(1000);

            //She talks when dying. Skip through the dialog so that it doesn't interfere with potential quitouts.
            for (int i = 0; i < 3; i++)
            {
                _assistant.Interact();
                Thread.Sleep(100);
            }
            Thread.Sleep(6000);
        }

        private static void KillSeath()
        {
            _darkSouls1.BonfireWarp(WarpType.TheDukesArchivesBalconyBonfire);
            Thread.Sleep(3000);

            //Trigger fight
            _darkSouls1.Teleport(new Vector3f(120.0f, 136.0f, 845.6f), 300);
            Thread.Sleep(1000);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            //Kill crystal
            _darkSouls1.Teleport(new Vector3f(86.0f, 134.5f, 872.4f), 295);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(1000);

            _darkSouls1.Teleport(new Vector3f(120.0f, 134.0f, 842.0f), 300);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(1000);

            //clear popups, so that they don't interfere with potential quitouts.
            for (int i = 0; i < 3; i++)
            {
                _assistant.Interact();
                Thread.Sleep(100);
            }

            Thread.Sleep(8000);
        }

        private static void KillSif()
        {
            _darkSouls1.BonfireWarp(WarpType.DarkrootGardenBonfire);
            Thread.Sleep(3000);
            
            //Trigger fight
            _darkSouls1.Teleport(new Vector3f(253.3f, -16.0f, -320.0f), 20);
            Thread.Sleep(1000);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            _darkSouls1.Teleport(new Vector3f(261.8f, -17.0f, -299.2f), 25);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(3000);

            //Equip abyss ring
            _assistant.EquipArtoriasRing(); 
            Thread.Sleep(500);
        }

        private static void KillFourKings()
        {
            //Have to get the ring from sif. Can't survive in the abyss with cheats.
            if (!_darkSouls1.IsBossDefeated(BossType.Sif))
            {
                KillSif();
            }

            _darkSouls1.BonfireWarp(WarpType.AbyssBonfire);
            Thread.Sleep(3000);

            _darkSouls1.Teleport(new Vector3f(13.3f, -311.0f, 8.0f), 273);
            Thread.Sleep(10000);

            _assistant.Punch();
            Thread.Sleep(2000);
            _assistant.SkipCutscene();

            Thread.Sleep(3000);
        }


        private static void KillPinwheel()
        {
            _darkSouls1.BonfireWarp(WarpType.TomboftheGiantsEntrance);
            Thread.Sleep(3000);

            //Trigger fight
            _darkSouls1.Teleport(new Vector3f(45.0f, -165.8f, 140.0f), 0);
            Thread.Sleep(1000);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            _darkSouls1.Teleport(new Vector3f(46.0f, -165.8f, 145.0f), 0);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(1000);

            //open menu to not get stuck in kindle message
            _assistant.Menu();
            Thread.Sleep(6000);
            _assistant.Menu();
            Thread.Sleep(100);
        }

        private static void KillNito()
        {
            _darkSouls1.BonfireWarp(WarpType.TomboftheGiantsBonfire2);
            Thread.Sleep(3000);

            //Trigger fight
            _darkSouls1.Teleport(new Vector3f(-126.7f, -265.0f, -30.7f), 277);
            Thread.Sleep(1000);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            //kill
            _darkSouls1.Teleport(new Vector3f(-153.3f, -265.1f, -47.2f), 263);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(12000);
        }
       
        

        private static void KillSanctuaryGuardian()
        {
            _darkSouls1.BonfireWarp(WarpType.OolacileSanctuaryBonfire); 
            Thread.Sleep(3000);

            //kill
            _darkSouls1.Teleport(new Vector3f(964.0f, -320.9f, 512.4f), 158);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(5000);
        }

        private static void KillArtorias()
        {
            _darkSouls1.BonfireWarp(WarpType.OolacileTownshipBonfire);
            Thread.Sleep(3500);

            //Trigger fight
            _darkSouls1.Teleport(new Vector3f(1035.2f, -330.0f, 810.8f), 71);
            Thread.Sleep(3000);
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            //kill
            _darkSouls1.Teleport(new Vector3f(1057.0f, -330.0f, 815.0f), 78);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(7000);
        }
        private static void KillKalameet()
        {
            _darkSouls1.BonfireWarp(WarpType.OolacileTownshipBonfire);
            Thread.Sleep(3500);

            //Trigger kalameet flyby
            _darkSouls1.Teleport(new Vector3f(854.2f, -344.3f, 736.3f), 238);
            Thread.Sleep(1000);
            
            //bait + wait
            _darkSouls1.Teleport(new Vector3f(801.0f, -372.0f, 798.9f), 0);
            Thread.Sleep(18000);

            //Death from above + get back in arena
            _darkSouls1.Teleport(new Vector3f(801.0f, -342.0f, 818.9f), 0);
            Thread.Sleep(3000);
            _darkSouls1.Teleport(new Vector3f(801.0f, -372.0f, 798.9f), 0);


            Thread.Sleep(18000);
        }
        //private static void KillKalameet()
        //{
        //    _darkSouls.BonfireWarp(WarpType.OolacileTownshipBonfire);
        //    Thread.Sleep(3000);
        //
        //    //Trigger kalameet flyby
        //    _darkSouls.Teleport(new Vector3f(854.2f, -344.3f, 736.3f), 238);
        //    Thread.Sleep(1000);
        //
        //    //bait + wait
        //    _darkSouls.Teleport(new Vector3f(801.0f, -372.0f, 798.9f), 0);
        //    Thread.Sleep(18000);
        //
        //    //Death from above + get back in arena
        //    _darkSouls.Teleport(new Vector3f(801.0f, -342.0f, 818.9f), 0);
        //    Thread.Sleep(3000);
        //    _darkSouls.Teleport(new Vector3f(801.0f, -372.0f, 798.9f), 0);
        //
        //
        //    Thread.Sleep(18000);
        //}

        private static void KillManus()
        {
            _darkSouls1.BonfireWarp(WarpType.ChasmOfTheAbyssManus);
            Thread.Sleep(3000);

            _darkSouls1.Teleport(new Vector3f(853.7f, -576.8f, 855.9f), 304);
            Thread.Sleep(2000);
            _assistant.Punch();
            Thread.Sleep(7000);
        }

        private static void KillGwyn()
        {
            _darkSouls1.BonfireWarp(WarpType.KilnoftheFirstFlameGwyn);
            Thread.Sleep(3000);

            _darkSouls1.Teleport(new Vector3f(417.4f, -116.0f, 169.0f), 300);
            Thread.Sleep(100);

            _darkSouls1.Teleport(new Vector3f(387.0f, -117.6f, 190.2f), 318);
            Thread.Sleep(1500);
            _assistant.Punch();
            Thread.Sleep(13000);
        }

        #endregion

        public void Sleep(int millis)
        {
            Thread.Sleep(millis);
        }
    }
}
