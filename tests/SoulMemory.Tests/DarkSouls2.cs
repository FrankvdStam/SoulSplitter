using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms.VisualStyles;
using SoulMemory.DarkSouls2;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Testing.Tas;

namespace Testing
{
    [TestFixture]
    internal class DarkSouls2
    {
        private static DarkSouls2ToolAssistant _assistant;
        private static SoulMemory.DarkSouls2.DarkSouls2 _darkSouls2; 
        private static string SaveFileLocation = @"C:\Users\Frank\AppData\Roaming\DarkSoulsII\0110000104593e46";
        private static string SaveFileName = @"DS2SOFS0000.sl2";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var ReplacementSave = "Sotfs";

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
            File.Move(Environment.CurrentDirectory + $@"\saves\DarkSouls2\{ReplacementSave}\AllBossesSetup", SaveFileLocation + "\\" + SaveFileName);




            _assistant = new DarkSouls2ToolAssistant(GameType.DarkSouls2Sotfs);
            _darkSouls2 = new SoulMemory.DarkSouls2.DarkSouls2();
            _darkSouls2.Refresh();

            _assistant.MainMenuContinue();

            //Cheaty
            _darkSouls2.DisableAllAi = true;
            _darkSouls2.RightWeapon1DamageMultiplier = 999999.0f;
            _darkSouls2.LeftWeapon1DamageMultiplier = 999999.0f;
        }
        
        public delegate void KillBossMethod();

        public static List<(BossType, KillBossMethod)> BossKills = new List<(BossType, KillBossMethod)>()
        {
            (BossType.TheLastGiant                                             , KillTheLastGiant),
            (BossType.ThePursuer                                               , KillThePursuer                                                 ),
            (BossType.Dragonrider                                              , KillDragonrider                                                ),
            (BossType.OldDragonSlayer                                          , KillOldDragonSlayer                                            ),
            (BossType.FlexileSentry                                            , KillFlexileSentry                                              ),

            (BossType.RuinSentinels                                            , KillRuinSentinels                                              ),
            (BossType.BelfryGargoyles                                          , KillBelfryGargoyles                                            ),
            (BossType.LostSinner                                               , KillLostSinner                                                 ),

            (BossType.ExecutionersChariot                                      , KillExecutionersChariot                                        ),
            (BossType.TheSkeletonLords                                         , KillTheSkeletonLords                                           ),
            
            (BossType.CovetousDemon                                            , KillCovetousDemon                                              ),
            (BossType.MythaTheBanefulQueen                                     , KillMythaTheBanefulQueen                                       ),

            (BossType.SmelterDemon                                             , KillSmelterDemon                                               ),
            (BossType.OldIronKing                                              , KillOldIronKing                                                ),

            (BossType.ScorpionessNajka                                         , KillScorpionessNajka                                           ),
            (BossType.RoyalRatAuthority                                        , KillRoyalRatAuthority                                          ),
            (BossType.ProwlingMagnusAndCongregation                            , KillProwlingMagnusAndCongregation                              ),
            (BossType.TheDukesDearFreja                                        , KillTheDukesDearFreja                                          ),

            (BossType.RoyalRatVanguard                                         , KillRoyalRatVanguard                                           ),
            (BossType.TheRotten                                                , KillTheRotten                                                  ),

            (BossType.TwinDragonriders                                         , KillTwinDragonriders                                           ), 
            (BossType.Darklurker                                               , KillDarklurker                                                 ),
            (BossType.LookingGlassKnight                                       , KillLookingGlassKnight                                         ),

            (BossType.DemonOfSong                                              , KillDemonOfSong                                                ),
            (BossType.VelstadtTheRoyalAegis                                    , KillVelstadtTheRoyalAegis                                      ),
            (BossType.Vendrick                                                 , KillVendrick                                                   ),

            (BossType.GuardianDragon                                           , KillGuardianDragon                                             ),                      
            (BossType.AncientDragon                                            , KillAncientDragon                                              ),
            (BossType.GiantLord                                                , KillGiantLord                                                  ),

            (BossType.ThroneWatcherAndThroneDefender                           , KillThroneWatcherAndThroneDefender                             ),                      
            (BossType.Nashandra                                                , KillNashandra                                                  ),                      
            (BossType.AldiaScholarOfTheFirstSin                                , KillAldiaScholarOfTheFirstSin                                  ),

            //Crown of the Sunken king                  
            (BossType.ElanaSqualidQueen                                        , KillElanaSqualidQueen                                          ),
            (BossType.SinhTheSlumberingDragon                                  , KillSinhTheSlumberingDragon                                    ),     
            (BossType.AfflictedGraverobberAncientSoldierVargCerahTheOldExplorer, KillAfflictedGraveRobberAncientSoldierVargCerahTheOldExplorer  ),    
                
            //Crown of the old iron king
            (BossType.BlueSmelterDemon                                         , KillBlueSmelterDemon                                           ),                                             
            (BossType.Fumeknight                                               , KillFumeknight                                                 ),                                             
            (BossType.SirAlonne                                                , KillSirAlonne                                                  ),                                             
        
            //Crown of the Ivory king                                                                           
            (BossType.AavaTheKingsPet                                          , KillAavaTheKingsPet                                            ),
            (BossType.LudAndZallenTheKingsPets                                 , KillLudAndZallenTheKingsPets                                   ),
            (BossType.BurntIvoryKing                                           , KillBurntIvoryKing                                             ),    
         };

        [TestCaseSource(nameof(BossKills))]
        public void BossKill((BossType, KillBossMethod) param)
        {
            var bossType = param.Item1;
            var func = param.Item2;

            var stateBefore = _darkSouls2.GetBossKillCount(bossType);
            func();
            var stateAfter = _darkSouls2.GetBossKillCount(bossType);

            Assert.AreEqual(0, stateBefore, "Initial boss kill count not 0");
            Assert.AreEqual(1, stateAfter, "Boss kill count not 1 after killing");
        }

        #region Boss kills

        private static void KillTheLastGiant()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.CardinalTower);

            Teleport(-144.2992f, 93.41512f, -40.57851f, 0.99f, 0.17f, 0.0f);
            EnterFogGate();
            _assistant.SkipCutscene();

            _darkSouls2.RightWeapon1DamageMultiplier = 999999.0f;

            Teleport(-127.565f, 98.29201f, -40.52358f, 0.55f, -0.83f, 0.0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.TheLastGiant);
        }

        private static void KillThePursuer()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.CardinalTower);

            Teleport(-216.288f, 138.7449f, 10.05f, 1.00f, 0.01f, 0.0f);
            //_assistant.Forward();
            //Thread.Sleep(1000);
            //_assistant.Stop();
            EnterFogGate();
            _assistant.SkipCutscene();

            Teleport(-192.542f, 139.3123f, 10.05004f, 1.00f, 0.01f, 0.0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.ThePursuer);
        }

        private static void KillDragonrider()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.HeidesRuin);

            Teleport(283.9956f, -2.403367f, -14.72153f, 0.71f,  0.70f);
            Thread.Sleep(100);

            Teleport(283.9246f, 10.08016f, -14.72153f, 0.67f, 0.74f, 0.0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.Dragonrider);
        }

        private static void KillOldDragonSlayer()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.HeidesRuin);

            Teleport(168.1138f, -149.4831f, 8.032109f, 0.56f, -0.83f, 0.0f);
            Thread.Sleep(100);

            Teleport(158.2881f, -178.6479f, 8.032104f, 0.58f, -0.81f, 0.0f);
            Stepy();
            Teleport(158.2881f, -178.6479f, 8.032104f, 0.58f, -0.81f, 0.0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.OldDragonSlayer);
        }

        private static void KillFlexileSentry()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.UnseenPathToHeide);

            //Hit the lever to ring the bell - boss arena not actually loaded in...
            Teleport(540.7324f, -44.99958f, -42.34491f, 0.81f, 0.59f, 0.0f);
            Stepy();
            Teleport(540.7324f, -44.99958f, -42.34491f, 0.81f, 0.59f, 0.0f);
            _assistant.Interact();
            Thread.Sleep(38000);

            //Trigger boss
            Teleport(519.8405f, 20.76741f, -71.60835f, 0.7562454f, -0.6542881f, 0f);
            Thread.Sleep(100);

            Teleport(522.5f, 7.5f, -71.6f, 0.83f, -0.56f, 0.0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.FlexileSentry);
        }


        private static void KillRuinSentinels()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.TheTowerApart);

            //538.8829f, -143.596f, 11.41f, 0.7437765f, -0.6684284f, 0fw

            Teleport(539.4946f, -145.5069f, 7.249999f, -0.8622801f, 0.5064317f, 0f);
            Stepy();

            Teleport(535.4788f, -146.997f, 7.250006f, 0.02462085f, 0.9996969f, 0f);
            _assistant.Punch();
            Thread.Sleep(800);

            Teleport(541.4403f, -167.3513f, 7.251741f, 0.5715336f, 0.8205787f, 0f);
            _assistant.Punch();
            Thread.Sleep(800);

            Teleport(559.6871f, -156.7965f, 7.301271f, 0.1796253f, 0.9837351f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.RuinSentinels);
        }

        private static void KillBelfryGargoyles()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.ServantsQuarters, true);
            _darkSouls2.Gravity = false;

            Teleport(518.3754f, -188.5599f, 14.75585f, 0.6680135f, -0.7441492f, 0f);
            Stepy();

            Teleport(503.3614f, -215.426f, 14.71966f, 0.03083f, -0.9995247f, 0f);
            _assistant.WrathOfGods();
            Thread.Sleep(400);

            Teleport(504.3544f, -195.4429f, 14.6674f, -0.008927338f, 0.9999602f, 0f);
            _assistant.WrathOfGods();
            Thread.Sleep(1000);//stamina

            Teleport(517.7093f, -204.0215f, 13.50345f, 0.9991025f, 0.04235904f, 0f);
            _assistant.WrathOfGods();
            Thread.Sleep(1000);//stamina

            Teleport(516.8539f, -219.2879f, 13.65764f, 0.9979326f, -0.0642696f, 0f);
            _assistant.WrathOfGods();
            Thread.Sleep(400);
            
            WaitForBossDeath(BossType.BelfryGargoyles);
        }

        private static void KillLostSinner()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.TheSaltfort);

            Teleport(552.9021f, -122.9815f, -77.01114f, -0.002994459f, 0.9999956f, 0f);
            EnterFogGate();
            Thread.Sleep(500);

            _assistant.SkipCutscene();
            Thread.Sleep(100);

            Teleport(536.4653f, -122.3683f, -76.9723f, -0.02929096f, 0.999571f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.LostSinner);
        }

        private static void KillExecutionersChariot()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.BridgeApproach);

            Teleport(-42.01416f, -248.7039f, 47.73362f, -0.1496944f, 0.9887323f, 0f);
            EnterFogGate();
            Thread.Sleep(500);

            _assistant.SkipCutscene();
            Thread.Sleep(100);

            Teleport(-52.72106f, -271.7752f, 47.63641f, 0.9828793f, -0.1842504f, 2.204081E-13f);
            _assistant.Punch();
            Thread.Sleep(1000);

            //He won't die unless you have it run...
            //TP out of the way first
            Teleport(-49.56203f, -262.6841f, 47.2913f, -0.09203673f, 0.9957556f, 1.874111E-13f);
            _darkSouls2.DisableAllAi = false;

            Thread.Sleep(3000);
            Teleport(-65.9415f, -277.0759f, 47.25572f, 0.7200707f, -0.6939008f, 2.547025E-13f);
            _assistant.Punch();
            Thread.Sleep(1000);

            _darkSouls2.DisableAllAi = true;

            WaitForBossDeath(BossType.ExecutionersChariot);
        }

        private static void KillTheSkeletonLords()
        {
            //One hit kill not working :( 
            //Skellies spawn in random spots & don't pop up with AI disable. 
            //Not worth automating for now

            _darkSouls2.Refresh();
            Warp(WarpType.UndeadLockaway, true);
            
            _darkSouls2.Gravity = false;
            Teleport(233.7822f, -406.6223f, 36.97942f, 0.9802294f, -0.1978644f, 0f);
            Thread.Sleep(100);
            
            Teleport(251.6044f, -424.8639f, 39.5064f, 0.8734001f, -0.4870034f, 0f);
            _assistant.Punch();
            Thread.Sleep(1000);

            Teleport(254.9198f, -416.3326f, 39.48125f, 0.9554882f, -0.2950294f, 0f);
            _assistant.Punch();
            Thread.Sleep(1000);

            Teleport(257.1877f, -405.1932f, 39.49393f, 0.9656522f, 0.259838f, 0f);
            _assistant.Punch();
            Thread.Sleep(1000);

            var before = _darkSouls2.GetBossKillCount(BossType.TheSkeletonLords);

            Teleport(235.7607f, -402.2172f, 39.00628f, 0.9789585f, -0.2040595f, 0f);
            _darkSouls2.DisableAllAi = false;
            Thread.Sleep(15000);
            for (int i = 0; i < 20; i++)
            {
                _assistant.WrathOfGods();
                Thread.Sleep(2000);

                //Optimization, need to return from here because WaitForBossDeath will wait the full duration
                if (before < _darkSouls2.GetBossKillCount(BossType.TheSkeletonLords))
                {
                    _darkSouls2.DisableAllAi = true;
                    _darkSouls2.Gravity = true;
                    return;
                }
            }
            
            _darkSouls2.DisableAllAi = true;
            _darkSouls2.Gravity = true;
            WaitForBossDeath(BossType.TheSkeletonLords);
        }

        private static void KillCovetousDemon()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.LowerEarthenPeak);

            Teleport(530.9958f, -537.2256f, 52.5626f, 0.9998356f, -0.01813193f, 0f);
            Thread.Sleep(100);

            Teleport(547.6569f, -535.8986f, 52.57252f, 0.8600638f, -0.5101865f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.CovetousDemon);
        }

        private static void KillMythaTheBanefulQueen()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.UpperEarthenPeak);

            Teleport(535.1716f, -561.9955f, 85.66965f, 0.9999912f, 0.004212124f, 0f);
            Thread.Sleep(100);

            Teleport(553.2562f, -561.7311f, 85.71891f, 0.9999124f, 0.01323587f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.MythaTheBanefulQueen);
        }

        private static void KillSmelterDemon()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.IronHearthHall);

            Teleport(651.0932f, -708.2863f, 176.362f, 0.8871373f, -0.4615056f, 0f);
            Thread.Sleep(100);

            Teleport(655.5945f, -717.3021f, 176.362f, 0.834821f, -0.5505215f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.SmelterDemon);
        }

        private static void KillOldIronKing()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.EygilsIdol);

            Teleport(722.0f, -650.219f, 166.55f, 0.9787122f, 0.2052375f, 0f);
            Thread.Sleep(500);
            _darkSouls2.Gravity = false;
            Stepy();
            EnterFogGate();
            Thread.Sleep(100);

            _assistant.SkipCutscene();
            Thread.Sleep(100);

            Teleport(741.4323f, -607.2257f, 166.34f, 0.8017324f, 0.5976831f, 0.0f);
            _assistant.Punch();

            Thread.Sleep(1000);
            Teleport(725.5041f, -636.8213f, 166.55f, 0.9047604f, 0.4259209f, 0.0f);
            _darkSouls2.Gravity = true;
            WaitForBossDeath(BossType.OldIronKing);
        }

        private static void KillScorpionessNajka()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.ShadedRuins);

            _darkSouls2.Gravity = false;
            Teleport(-288.4196f, -458.6359f, 85.38277f, 0.18f, 0.98f, 0f);
            EnterFogGate();

            Teleport(-308.0217f, -453.8119f, 84.82339f, 0.04489959f, 0.9989915f, 0f);
            Thread.Sleep(100);
            _assistant.WrathOfGods();

            ////Warp to safety - enabling gravity will kill here.
            //Thread.Sleep(500);
            //Teleport(-308.0217f, -453.8119f, 84.82339f, 0.04489959f, 0.9989915f, 0f);


            _darkSouls2.Gravity = true;
            WaitForBossDeath(BossType.ScorpionessNajka);
        }

        private static void KillRoyalRatAuthority()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.OrdealsEnd);

            Teleport(-176.6047f, -540.4107f, 107.7579f, 0.3795179f, 0.9251844f, 0f);
            EnterFogGate();
            Thread.Sleep(100);

            Teleport(-180.7013f, -490.3983f, 116.141f, 0.7309332f, 0.682449f, 0f);
            Thread.Sleep(1000);
            _assistant.Punch();
            WaitForBossDeath(BossType.RoyalRatAuthority);
        }



        private static void KillProwlingMagnusAndCongregation()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.RoyalArmyCampsite);

            Teleport(-52.02335f, -628.2833f, 116.229f, 0.958371f, -0.285526f, 0f);
            Stepy(200);

            Teleport(-48.87807f, -637.5546f, 116.229f, 0.9565416f, -0.291596f, 0f);
            _assistant.WrathOfGods();
            WaitForBossDeath(BossType.ProwlingMagnusAndCongregation);
        }


        private static void KillTheDukesDearFreja()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.LowerBrightstoneCove);

            Teleport(-128.9043f, -584.8237f, 72.64446f, 0.9295461f, 0.3687061f, 0f);
            
            Thread.Sleep(1000);//loading delay
            Stepy();
            Teleport(-128.9043f, -584.8237f, 72.64446f, 0.9295461f, 0.3687061f, 0f);

            EnterFogGate();
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            Teleport(-113.1296f, -575.7199f, 72.81606f, 0.964104f, 0.265525f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.TheDukesDearFreja);
        }

        private static void KillRoyalRatVanguard()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.GraveEntrance, true);

            _darkSouls2.Gravity = false;

            //Trigger rat spawns
            Teleport(32.25637f, -122.8448f, -29.92383f, -0.02292544f, 0.9997372f, 0f);
            Thread.Sleep(100);

            //4 ceiling rats
            Teleport(19.18131f, -116.7103f, -23.4f, 0.9984979f, 0.05478978f, 0f);
            _assistant.WrathOfGods();

            //2 wall rats
            Teleport(41.29175f, -116.3281f, -28.40342f, 0.9999127f, -0.01321686f, 0f);
            _assistant.WrathOfGods();

            //2 wall rats
            Teleport(28.55047f, -103.1247f, -29.40342f, 0.6507047f, -0.7593309f, 0f);
            _assistant.WrathOfGods();
            Thread.Sleep(1500);//stamina

            //2 wall rats
            Teleport(20.03862f, -103.8155f, -29.78669f, 0.7458475f, 0.6661168f, 0f);
            Thread.Sleep(100);
            _assistant.WrathOfGods();
            Thread.Sleep(1500);//stamina

            //Boss rat
            Teleport(26.28662f, -121.4838f, -23.52934f, 0.0484067f, 0.9988278f, 0f);
            Thread.Sleep(300);
            _assistant.WrathOfGods();
            WaitForBossDeath(BossType.RoyalRatVanguard);
        }

        private static void KillTheRotten()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.HiddenChamber);


            Teleport(-98.20769f, -242.6064f, -226.5909f, -0.3603652f, 0.9328113f, 0f);
            EnterFogGate();
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            Teleport(-109.0756f, -257.8265f, -227.0485f, -0.3957669f, 0.9183511f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.TheRotten);
        }

        private static void KillTwinDragonriders()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.ForgottenChamber);

            Teleport(-363.1313f, -467.5252f, 108.8724f, 0.769821f, -0.6382598f, 0f);
            Stepy();

            Teleport(-363.4253f, -491.4017f, 108.8724f, 0.7511528f, -0.6601285f, 0f);
            _assistant.Punch();
            Thread.Sleep(1000);


            Teleport(-370.713f, -490.875f, 114.7914f, 0.7696062f, -0.6385188f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.TwinDragonriders);
        }

        private static void KillDarklurker()
        {
            //Talk 3x
            _darkSouls2.Refresh();
            Warp(WarpType.UnderCastleDrangleic);
            
            Teleport(-322.9447f, -447.0854f, 66.0f, 0.9464179f, -0.3229447f, 0f);
            Thread.Sleep(100);

            _assistant.Interact();
            Thread.Sleep(7500);//Load

            Teleport(300.7141f, -984.8495f, 15.26324f, 0.6546905f, -0.755897f, 0f);
            Thread.Sleep(7500);//Load

            Teleport(285.1255f, -1026.406f, 12.45084f, 0.8856965f, -0.4642647f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.Darklurker);
        }

        private static void KillLookingGlassKnight()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.CentralCastleDrangleic);

            Teleport(-341.9656f, -636.6098f, 103.1522f, 0.7070987f, -0.7071149f, 0f);
            Thread.Sleep(100);

            Teleport(-342.5707f, -651.1853f, 103.6844f, 0.7822062f, -0.6230196f, 0f);
            Thread.Sleep(1000);//Wait for load
            _assistant.Punch();
            WaitForBossDeath(BossType.LookingGlassKnight);
        }

        private static void KillDemonOfSong()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.RhoysRestingPlace);

            _darkSouls2.Gravity = false;
            
            //-169.1916f, -1070.287f, -31.28806f, 0.8263331f, -0.5631817f, 0f
            Teleport(-168.3759f, -1071.915f, -31.36784f, 0.8738585f, -0.4861803f, 0f);
            Stepy();

            Teleport(-140.6143f, -1095.306f, -29.9576f, 0.8637663f, -0.5038928f, 0f);
            _assistant.Punch();
            Thread.Sleep(1000);

            _darkSouls2.Gravity = true;
            WaitForBossDeath(BossType.DemonOfSong);
        }

        private static void KillVelstadtTheRoyalAegis()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.UndeadDitch);

            Teleport(-70.57273f, -1003.883f, -132.2887f, 0.9717425f, 0.2360435f, 0.0f);
            Stepy(delayAfter: 300);
            Teleport(-70.57273f, -1003.883f, -132.2887f, 0.9717425f, 0.2360435f, 0.0f);
            EnterFogGate();
            _assistant.SkipCutscene();
            Thread.Sleep(100);

            Teleport(-50.9524f, -990.7194f, -132.2918f, 0.9634183f, 0.2680023f, 0.0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.VelstadtTheRoyalAegis);
        }

        private static void KillVendrick()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.UndeadDitch);
            
            Teleport(-12.7881f, -967.4067f, -137.45f, -0.9583284f, -0.285669f, 0.0f);
            Stepy(delayAfter: 300);
            Thread.Sleep(100);
            Teleport(-12.7881f, -967.4067f, -137.45f, -0.9583284f, -0.285669f, 0.0f);
            Thread.Sleep(100);
            _assistant.Punch();
            WaitForBossDeath(BossType.Vendrick);
        }

        private static void KillGuardianDragon()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.RitualSite);

            Teleport(-249.4329f, -750.7266f, 80.42351f, 0.699955f, -0.7141869f, 0f);
            Thread.Sleep(100);

            Teleport(-249.8779f, -768.4272f, 80.44767f, 0.6094859f, -0.7927969f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.GuardianDragon);
        }

        private static void KillAncientDragon()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.ShrineEntrance);

            //Teleport and talk
            Teleport(-701.9946f, -863.2504f, 336.2798f, 0.008504139f, 0.9999639f, 0f);
            Thread.Sleep(100);

            //Going for the single punch death doesnt work here, the boss will just respawn. Have to piss it off first and then kill it.
            //In order to piss it off, we need normal damage as to not insta kill it.
            var temp = _darkSouls2.RightWeapon1DamageMultiplier;
            _darkSouls2.RightWeapon1DamageMultiplier = 1;

            Teleport(-718.5923f, -854.1175f, 336.2798f, 0.2420077f, 0.9702743f, 0f);
            for (int i = 0; i < 5; i++)
            {
                _assistant.Punch();
                Thread.Sleep(800);
            }
            //Restore damage
            _darkSouls2.RightWeapon1DamageMultiplier = temp;
            _assistant.Punch();
            WaitForBossDeath(BossType.AncientDragon);
        }

        private static void KillGiantLord()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.ThePlaceUnbeknownst);

            Teleport(-151.5625f, 43.66145f, -11.07213f, 0.8743922f, -0.4852198f, 0f);
            Thread.Sleep(100);
            _assistant.Interact();
            Thread.Sleep(1000);
            _assistant.SkipCutscene();
            Thread.Sleep(7000);//loading

            //Trigger something
            Teleport(-174.231f, 136.8959f, -3.960498f, 0.02019417f, 0.9997962f, 0f);

            Teleport(-270.6749f, 137.5556f, -3.960497f, -0.02595183f, 0.9996632f, 0f);
            Thread.Sleep(200);
            _assistant.Punch();
            WaitForBossDeath(BossType.GiantLord);
        }

        private static void KillThroneWatcherAndThroneDefender()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.KingsGate, true);

            Teleport(-257.4019f, -703.2492f, -5.902482f, 0.8592502f, -0.5115555f, 0f);
            Stepy();

            Teleport(-248.6757f, -721.6929f, -5.905015f, 0.9960781f, -0.08847825f, 0f);
            _assistant.WrathOfGods();
            WaitForBossDeath(BossType.ThroneWatcherAndThroneDefender);
        }

        private static void KillNashandra()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.KingsGate, true);

            Teleport(-258.6429f, -700.9271f, -5.898954f, 0.8488359f, -0.5286564f, 0f);
            Stepy();
            EnterFogGate();
            _assistant.SkipCutscene();
            Thread.Sleep(100);
            
            Teleport(-243.8391f, -729.8668f, -5.906105f, 0.8693683f, -0.4941648f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.Nashandra);
        }
        

        //Bit messy - vendrick needs to be dead + need to talk to aldia + need all primal bonfires lit.
        private static void KillAldiaScholarOfTheFirstSin()
        {
            _darkSouls2.Refresh();

            //Aldia's setup. Has been pre-executed on the save file
            //void LightBonfire(WarpType w, float x, float y, float z, float angX, float angY, float angZ)
            //{
            //    Warp(w);
            //    Teleport(x, y, z, angX, angY, angZ);
            //    Stepy();
            //    Teleport(x, y, z, angX, angY, angZ);
            //    _assistant.Interact();
            //    Thread.Sleep(2000);
            //}
            //
            //
            //
            ////Light all primal bonfires
            //LightBonfire(WarpType.TheSaltfort, 485.0911f, -122.4796f, -80.8193f, -0.03144895f, 0.9995054f, 0f);
            //LightBonfire(WarpType.EygilsIdol, 687.6362f, -660.1639f, 157.8474f, -0.2208004f, 0.975319f, 0f);
            //LightBonfire(WarpType.LowerBrightstoneCove, -71.89282f, -481.3606f, 70.78493f, 0.8535874f, 0.5209496f, 5.004893E-10f);
            //LightBonfire(WarpType.HiddenChamber, -142.9112f, -276.4015f, -226.7903f, 0.5292883f, 0.8484421f, 0f);
            //
            //
            ////Talk to Aldia
            //Thread.Sleep(8000);
            //Teleport(-141.6214f, -280.385f, -226.7903f, 0.5997878f, 0.8001591f, 0f);
            //Talk(40);
            //
            //LightBonfire(WarpType.UndeadCryptEntrance, -103.234f, -1064.716f, -138.7701f, -0.2735352f, 0.961862f, 0f);
            //Thread.Sleep(8000);
            //Teleport(-100.1953f, -1062.884f, -138.7701f, -0.2383954f, 0.9711682f, 0f);
            //Talk(60);
            //
            //LightBonfire(WarpType.ShrineEntrance, -450.8727f, -856.2551f, 273.6532f, -0.2626956f, 0.9648788f, 0f);
            //Thread.Sleep(4000);
            //Teleport(-449.6854f, -856.6855f, 273.6532f, -0.04421941f, 0.9990219f, 0f);
            //Talk(45);

            void Talk(int max)
            {
                for (int i = 0; i < max; i++)
                {
                    _assistant.Interact();
                    Thread.Sleep(200);
                }
            }

            Warp(WarpType.KingsGate);
            Teleport(-257.4019f, -703.2492f, -5.902482f, 0.8592502f, -0.5115555f, 0f);
            Stepy();
            
            //Wait for aldia
            Thread.Sleep(5000);
            Talk(20);

            //Rather than messing with the AI, I discovered the boss spawns if you reenter the room
            Warp(WarpType.KingsGate);
            Teleport(-257.4019f, -703.2492f, -5.902482f, 0.8592502f, -0.5115555f, 0f);
            Stepy();

            Teleport(-245.8946f, -724.2142f, -5.905397f, 0.8430981f, -0.5377598f, 0f);
            _assistant.Punch();
            //Don't fall out of the world
            Thread.Sleep(1000);
            Teleport(-245.8946f, -724.2142f, -5.905397f, 0.8430981f, -0.5377598f, 0f);

            WaitForBossDeath(BossType.AldiaScholarOfTheFirstSin);
        }

        private static void KillElanaSqualidQueen()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.SanctumNadir);

            Teleport(-32.20347f, -96.00011f, -71.60806f, 0.8229124f, -0.5681683f, 0f);
            Thread.Sleep(500);

            Teleport(-21.46941f, -124.8502f, -71.62186f, 0.7958438f, -0.6055019f, 0f);
            Thread.Sleep(500);
            _assistant.Punch();
            WaitForBossDeath(BossType.ElanaSqualidQueen);
        }

        private static void KillSinhTheSlumberingDragon()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.SanctumNadir);

            Teleport(-2.672512f, -176.8107f, -79.31393f, 0.8322052f, -0.5544677f, 0f);
            Thread.Sleep(100);

            Teleport(15.96981f, -229.4955f, -79.15872f, 0.8966454f, -0.4427494f, 0f);
            Thread.Sleep(500);
            _assistant.Punch();
            WaitForBossDeath(BossType.SinhTheSlumberingDragon);
        }

        private static void KillAfflictedGraveRobberAncientSoldierVargCerahTheOldExplorer()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.PriestessChamber);

            Teleport(109.9681f, -10.09036f, 18.96916f, -0.05549607f, 0.9984589f, 0f);
            Stepy();

            Teleport(73.93964f, -7.458941f, 18.88369f, 0.7975449f, -0.6032596f, 0f);
            _assistant.WrathOfGods();
            
            WaitForBossDeath(BossType.AfflictedGraverobberAncientSoldierVargCerahTheOldExplorer);
        }

        private static void KillBlueSmelterDemon()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.IronHallwayEntrance);

            Teleport(458.5782f, -251.8682f, -26.8277f, 0.3559672f, 0.9344985f, 0f);
            Stepy();

            Teleport(446.6096f, -243.5859f, -26.82539f, 0.4178481f, 0.9085169f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.BlueSmelterDemon);
        }

        private static void KillFumeknight()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.LowermostFloor);

            Teleport(388.2416f, -163.3057f, -59.36797f, 0.9166772f, 0.3996284f, 0f);
            Thread.Sleep(100);

            Teleport(404.0809f, -145.5095f, -60.97324f, 0.923202f, 0.384315f, 0f);
            _darkSouls2.DisableAllAi = false;
            Thread.Sleep(100);
            _darkSouls2.DisableAllAi = true;
            
            Thread.Sleep(2500);

            Teleport(406.6652f, -142.486f, -61.08553f, 0.9107626f, 0.4129304f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.Fumeknight);
        }

        private static void KillSirAlonne()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.SmelterThrone);
            
            Teleport(698.1125f, -100.2904f, 52.71057f, 0.9995792f, -0.02900848f, 0f);
            Stepy();

            Teleport(713.8814f, -100.1707f, 53.0f, 0.9999343f, 0.01146176f, 0f);
            _darkSouls2.DisableAllAi = false;
            Thread.Sleep(4000);
            _darkSouls2.DisableAllAi = true;
            Thread.Sleep(3000);

            _assistant.Punch();
            WaitForBossDeath(BossType.SirAlonne);
        }

        private static void KillAavaTheKingsPet()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.OuterWall);

            Teleport(-27.03299f, -84.49769f, -23.44006f, 0.8955125f, 0.4450365f, 0f);
            Thread.Sleep(100);

            Teleport(-13.90753f, -33.58223f, -23.7194f, 0.760806f, 0.6489794f, 0f);
            Thread.Sleep(100);

            Teleport(-15.66036f, 6.625735f, -16.71936f, 0.9934688f, -0.114104f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.AavaTheKingsPet);
        }

        private static void KillLudAndZallenTheKingsPets()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.ExpulsionChamber);

            Teleport(-221.4566f, -143.1071f, -23.96864f, -0.9621204f, 0.2726249f, 0f);
            Thread.Sleep(100);
            _assistant.Interact();
            Thread.Sleep(18000);//animation/loading

            Teleport(362.5037f, -380.3581f, -69.55492f, 0.9941067f, -0.1084068f, 0f);
            Thread.Sleep(100);
            
            Teleport(376.6656f, -417.0503f, -63.46661f, 0.9601678f, 0.2794242f, 0f);
            _assistant.Punch();
            Thread.Sleep(1000);

            Teleport(405.408f, -370.8523f, -64.03514f, 0.9724956f, -0.2329215f, 0f);
            _assistant.Punch();
            WaitForBossDeath(BossType.LudAndZallenTheKingsPets);
        }

        private static void KillBurntIvoryKing()
        {
            _darkSouls2.Refresh();
            Warp(WarpType.GrandCathedral, true);

            Teleport(-53.61311f, 212.4491f, -6.083361f, 0.7111562f, 0.703034f, 0f);
            Thread.Sleep(100);
            Teleport(-54.04584f, 223.935f, -280.89f, 0.7111554f, 0.7030348f, 0f);


            for (int i = 0; i < 3; i++)
            {
                //Spawn wave
                Thread.Sleep(5000);
                _darkSouls2.DisableAllAi = false;
                Thread.Sleep(3000);
                _darkSouls2.DisableAllAi = true;
                Thread.Sleep(5000);

                //Kill wave
                Teleport(-37.7976f, 247.7531f, -281.7451f, 0.9650452f, 0.2620838f, 0f);
                _assistant.WrathOfGods();
                Thread.Sleep(1000);

                Teleport(-44.07336f, 264.4214f, -282.3272f, 0.8386676f, 0.5446436f, 0f);
                _assistant.WrathOfGods();
                Thread.Sleep(1000);

                Teleport(-65.28857f, 263.5982f, -282.2985f, 0.7399114f, 0.6727043f, 0f);
                _assistant.WrathOfGods();
                Thread.Sleep(1000);

                //Back to start
                //Teleport(-54.04584f, 223.935f, -280.89f, 0.7111554f, 0.7030348f, 0f);
            }


            Teleport(-55.20835f, 291.0321f, -283.7508f, 0.8621157f, 0.5067115f, 0f);
            Thread.Sleep(30000);

            _darkSouls2.DisableAllAi = false;
            Thread.Sleep(1500);
            _darkSouls2.DisableAllAi = true;

            Thread.Sleep(10000);
            _assistant.Punch();
            WaitForBossDeath(BossType.BurntIvoryKing);
        }
        
        #endregion


        #region Helpers
        private static void Stepy(int delayStep = 100, int delayAfter = 300)
        {
            _assistant.Forward();
            Thread.Sleep(delayStep);
            _assistant.Stop();
            Thread.Sleep(delayAfter);
        }

        private static void EnterFogGate()
        {
            _assistant.Interact();
            Thread.Sleep(5000);
        }

        private static void Teleport(float x, float y, float z, float angX = 0.0f, float angY = 0.0f, float angZ = 0.0f)
        {
            _darkSouls2.StableX = x;
            _darkSouls2.StableY = y;
            _darkSouls2.StableZ = z;
            _darkSouls2.AngX = angX;
            _darkSouls2.AngY = angY;
            _darkSouls2.AngZ = angZ;
            Thread.Sleep(500);
        }

        private static void TeleportWithoutDelay(float x, float y, float z, float angX = 0.0f, float angY = 0.0f, float angZ = 0.0f)
        {
            _darkSouls2.StableX = x;
            _darkSouls2.StableY = y;
            _darkSouls2.StableZ = z;
            _darkSouls2.AngX = angX;
            _darkSouls2.AngY = angY;
            _darkSouls2.AngZ = angZ;
        }

        private static void Warp(WarpType warpType, bool rest = false)
        {
            _darkSouls2.Warp(warpType, rest);
            Thread.Sleep(7000);
        }

        private static void WaitForBossDeath(BossType boss, int maxWait = 15000)
        {
            var initial = _darkSouls2.GetBossKillCount(boss);
            var end = DateTime.Now.AddMilliseconds(maxWait);

            while (DateTime.Now < end)
            {
                if (initial != _darkSouls2.GetBossKillCount(boss))
                {
                    return;
                }
                Thread.Sleep(100);
            }
        }

        #endregion

    }
}
