// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SoulMemory.EldenRing;
using SoulMemory.Memory;
using SoulMemory.Shared;
using SoulSplitter.UI;
using SoulMemory.DarkSouls1;

#pragma warning disable CS0162

namespace cli
{
    internal class Program
    {
        


        [STAThread]
        static void Main(string[] args)
        {
            TestUi();

            var ds1 = new DarkSouls1();
            ds1.Refresh(out _);

            while (true)
            {
                Console.WriteLine($"{ds1.GetInGameTimeMilliseconds()}");

                if (!ds1.Refresh(out Exception e))
                {
                    Console.WriteLine(e.Format());
                    Thread.Sleep(3000);
                    Console.Clear();
                }

                Thread.Sleep(10);
                Console.SetCursorPosition(0, 0);
                //Console.Clear();
            }
        }


        private static List<uint> ReadFlagsFromFile()
        {
            var lines = File.ReadAllLines(@"C:\temp\flags.txt");
            var flags = new List<uint>();
            foreach (var line in lines)
            {
                if (uint.TryParse(line, out uint value))
                {
                    flags.Add(value);
                }
                else
                {
                    throw new Exception($"Failed to parse flag {line}");
                }
            }
            return flags;
        }



        private static void Testy()
        {
            Pointer bossKillCount;
            Pointer AiManager;
            Pointer rightHandWeaponMultiplier;
            Pointer LeftHandWeaponMultiplier;

            var process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.StartsWith("DarkSoulsII"));

            process.ScanCache().ScanRelative("some aob", "48 8B 05 ?? ?? ?? ?? 48 8B 58 38 48 85 DB 74 ?? F6", 3, 7)
                .CreatePointer(out bossKillCount, 0x70, 0x28, 0x20, 0x8)
                .CreatePointer(out AiManager, 0x28)
                .CreatePointer(out rightHandWeaponMultiplier, 0xd0, 0x378, 0x28, 0x158)
                .CreatePointer(out LeftHandWeaponMultiplier, 0xd0, 0x378, 0x28, 0x80)
                ;

            //Disable AI
            AiManager.WriteBool(0x18, true);

            //Set crazy damage
            rightHandWeaponMultiplier.WriteFloat(999999.0f);

            //Read boss kill counters
            var lastGiantKillCount = bossKillCount.ReadInt32(0x7c);

            while (true)
            {
                Console.Clear();
                var res = bossKillCount.ToString();
                Console.WriteLine(res);
            }
        }

        public static void TestUi()
        {
            Form f = new Form();
            var c = new MainControlFormsWrapper();
            f.Width = c.Width;
            f.Height = c.Height;
            f.Controls.Add(c);
            f.ShowDialog();
        }
        
        public static string md5Hash(byte[] input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(input);
                var sb = new System.Text.StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }



        public static void Ds3TestPatterns()
        {
            var patternCounter = new PatternCounter(@"C:\Users\Frank\Desktop\dark souls\runtime dumps\DS3\executables");
            patternCounter.AddPattern("NewMenuSystem"   , "48 8b 0d ? ? ? ? 48 8b 7c 24 20 48 8b 5c 24 30 48 85 c9");
            //patternCounter.AddPattern("bonfireUnlock"   , "48 8b 1d ? ? ? ? 48 8b f8 48 85 db 74 15 48 8b cb");
            //patternCounter.AddPattern("bonfireUnlock"   , "8B 13 48 83 C4 ? 5B E9 ? 54 ? ? ? BA");
            //patternCounter.AddPattern("menuMan"         , "48 8b cb 41 ff 10 4c 8b 07 48 8b d3 48 8b cf 41 ff 50 68 48 89 35 ? ? ? ? 48 8b 0d ? ? ? ? 48 85 c9 74 33 e8 ? ? ? ? 48 8b 1d ? ? ? ? 48 8b f8 48 85 db 74 18 4c 8b 03 33 d2 48 8b cb 41 ff 10 4c 8b 07 48 8b d3 48 8b cf 41 ff 50 68 48 89 35 ? ? ? ? 48 8b 5c 24 30 48 8b 74 24 38 48 83 c4 20 5f c3");
            //patternCounter.AddPattern("IGT"             , "48 8b 0d ? ? ? ? 4c 8d 44 24 40 45 33 c9 48 8b d3 40 88 74 24 28 44 88 74 24 20");
            //patternCounter.AddPattern("playerIns"       , "48 8b 0d ? ? ? ? 45 33 c0 48 8d 55 e7 e8 ? ? ? ? 0f 2f 73 70 72 0d f3 ? ? ? ? ? ? ? ? 0f 11 43 70");
            //patternCounter.AddPattern("Loading"         , "c6 05 ? ? ? ? ? e8 ? ? ? ? 84 c0 0f 94 c0 e9");
            //patternCounter.AddPattern("SprjFadeImp"     , "48 8b 0d ? ? ? ? 4c 8d 4c 24 38 4c 8d 44 24 48 33 d2");
            //patternCounter.AddPattern("SprjEventFlagMan", "48 c7 05 ? ? ? ? 00 00 00 00 48 8b 7c 24 38 c7 46 54 ff ff ff ff 48 83 c4 20 5e c3");
            //patternCounter.AddPattern("FieldArea"       , "4c 8b 3d ? ? ? ? 8b 45 87 83 f8 ff 74 69 48 8d 4d 8f 48 89 4d 9f 89 45 8f 48 8d 55 8f 49 8b 4f 10");

            foreach (var result in patternCounter.GetResults())
            {
                if (result.count != 1)
                {
                    Console.WriteLine($"Error: {result.executable} {result.name} {result.count}");
                }
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        public static void SekiroTestPatterns()
        {
            var patternCounter = new PatternCounter(@"C:\Users\Frank\Desktop\dark souls\runtime dumps\Sekiro");
            patternCounter.AddPattern("SprjFadeManImp", "48 89 35 ? ? ? ? 48 8b c7 48 8b 4d 27 48 33 cc");
            //patternCounter.AddPattern("WorldChrManImp", "48 8B 35 ? ? ? ? 44 0F 28 18");
            //patternCounter.AddPattern("SprjEventFlagMan", "48 8b 0d ? ? ? ? 32 db 85 d2 49 63 f0");
            //patternCounter.AddPattern("FieldArea", "48 8b 0d ? ? ? ? 48 85 c9 74 26 44 8b 41 28 48 8d 54 24 40");
            //patternCounter.AddPattern("Igt", "48 8b 05 ? ? ? ? 32 d2 48 8b 48 08 48 85 c9 74 13 80 b9 ba");
            

            foreach (var result in patternCounter.GetResults())
            {
                if (result.count != 1)
                {
                    Console.WriteLine($"Error: {result.executable} {result.name} {result.count}");
                }
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }



        public static void SijixAobTest()
        {
            var patternCounter = new PatternCounter(@"C:\Users\Frank\Desktop\sijix remas exe");
            patternCounter.AddPattern("GameMan", "4c 8b 05 ? ? ? ? 48 8d 91 80 00 00 00");
            patternCounter.AddPattern("GameDataMan", "48 8b 05 ? ? ? ? 48 8b 50 10 48 89 54 24 60");
            patternCounter.AddPattern("WorldChrManImp", "48 8b 05 ? ? ? ? 48 8b da 48 8b 48 68");
            patternCounter.AddPattern("EventFlags", "48 8B 0D ? ? ? ? 99 33 C2 45 33 C0 2B C2 8D 50 F6");
            patternCounter.AddPattern("InventoryIndices", "48 8D 15 ? ? ? ? C1 E1 10 49 8B C6 41 0B 8F 14 02 00 00 44 8B C6 42 89 0C B2 41 8B D6 49 8B CF");
            patternCounter.AddPattern("NetManImp", "48 8b 05 ? ? ? ? 48 05 08 0a 00 00 48 89 44 24 50 e8 34 fc fd ff");


            patternCounter.AddPattern("BASE_PTR_AOB", "48 8B 05 ? ? ? ? 48 85 C0 ? ? F3 0F 58 80 AC 00 00 00");
            patternCounter.AddPattern("ITEM_ADDR_AOB", "48 89 5C 24 18 89 54 24 10 55 56 57 41 54 41 55 41 56 41 57 48 8D 6C 24 F9");
            patternCounter.AddPattern("INVENTORY_DATA_AOB", "48 8B 05 ? ? ? ? 48 85 C0 ? ? F3 0F 58 80 AC 00 00 00");
            patternCounter.AddPattern("FLAGS_AOB", "48 8B 0D ? ? ? ? 99 33 C2 45 33 C0 2B C2 8D 50 F6");
            patternCounter.AddPattern("CHR_FOLLOW_CAM_AOB", "48 8B 0D ? ? ? ? E8 ? ? ? ? 48 8B 4E 68 48 8B 05 ? ? ? ? 48 89 48 60");

            foreach (var result in patternCounter.GetResults())
            {
                if (result.count != 1)
                {
                    Console.WriteLine($"Error: {result.executable} {result.name} {result.count}");
                }
            }

            Console.WriteLine("Done");
            Console.ReadKey();

        }


        private static Dictionary<string, byte[]> _cache = new Dictionary<string, byte[]>();

        public static void TestAobs()
        {
            //fd4 alternative 48 8b 0d ? ? ? ? 48 85 c9 74 06 48 8b 59 08

            AobCount("NoLogo", "80 bf b8 00 00 00 00 ? ? 48 8b 05 ? ? ? ? 48 85 c0 75 2e 48 8d 0d"); 
            AobCount("FieldArea", "48 8B 0D ?? ?? ?? ?? 48 ?? ?? ?? 44 0F B6 61 ?? E8 ?? ?? ?? ?? 48 63 87 ?? ?? ?? ?? 48 ?? ?? ?? 48 85 C0"); 
            AobCount("SetEventFlag", "48 89 5c 24 08 44 8b 49 1c 44 8b d2 33 d2 41 8b c2 41 f7 f1 41 8b d8 4c 8b d9"); 
            AobCount("VirtualMemoryFlag", "48 83 3d ? ? ? ? 00 75 46 4c 8b 05 ? ? ? ? 4c 89 44 24 40 ba 08 00 00 00 b9 c8 01 00 00"); 

            AobCount("FD4Time",                 "48 8b 05 ? ? ? ? 4c 8b 40 08 4d 85 c0 74 0d 45 0f b6 80 be 00 00 00 e9 13 00 00 00");
            AobCount("WorldChrManImp",          "48 8B 05 ? ? ? ? 48 85 C0 74 0F 48 39 88 ? ? ? ? 75 06 89 B1 5C 03 00 00 0F 28 05 ? ? ? ? 4C 8D 45 E7");
            AobCount("CSMenuManImp",            "48 8b 0d ? ? ? ? 48 8b 53 08 48 8b 92 d8 00 00 00 48 83 c4 20 5b");
            AobCount("IGT fix detour address",  "48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0 48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d ? ? ? ?");
            AobCount("IGT code cave",           "48 8b c4 55 57 41 56 48 8d 68 b8 48 81 ec 30 01 00 00 48 c7 44 24 40 fe ff ff ff 48 89 58 18 48 89 70 20");
            AobCount("gameman",                 "48 8b 1d ? ? ? ? 48 8b f8 48 85 db 74 18 4c 8b 03");

            Console.WriteLine("all aob's counted.");
            Console.ReadKey();
        }

        public static string Aob;
        public static void AobCount(string identifier, string aob)
        {
            //C:\Users\Frank\Desktop\dark souls\runtime dumps\DS3\executables
            var path = @"C:\Users\Frank\Desktop\dark souls\runtime dumps\exe";
            var executabes = Directory.EnumerateFiles(path).ToList();

            var pattern = aob.ToByteArray();

            foreach (var e in executabes)
            {
                if (!_cache.TryGetValue(e, out byte[] bytes))
                {
                    bytes = File.ReadAllBytes(e);
                    _cache[e] = bytes;
                }

                var count = PatternScanner.Count(bytes, pattern);
                if (count != 1)
                {
                    Console.WriteLine($"{Path.GetFileName(e)} {count} {identifier}");
                }
            }

            Console.WriteLine($"finished {identifier}");
        }

        private static void AddressFix()
        {
            var baseAddress = 0x7ff743490000;
            var addressees = new List<long>()
            {
                0x783CD9,
                0x71FC02,
                0x8AD08A,
                0x70F3A1,
                0x70F6A1,
                0x74CACF,
                0x7219C3,
                0x72165E,
                0x784353,
                0x74CAE4,
                0x7438E7,
                0x8AD889,
                0x70F43D,
            };

            foreach (var a in addressees)
            {
                Console.WriteLine($"{baseAddress + a:X}");
            }

        }

        #region stand alone bs removal for ER

        private static void StandAloneErBlackscreenRemoval()
        {
            Console.CursorVisible = false;
            int _inGameTime = 0;
            var _eldenRing = new EldenRing();
            while (true)
            {
                //Refresh, display errors if there are any
                if (!_eldenRing.Refresh(out Exception e))
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine(e.Format());
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                //
                var currentIgt = _eldenRing.GetInGameTimeMilliseconds();
                var blackscreenActive = _eldenRing.IsBlackscreenActive();


                //Blackscreens/meme loading screens - timer is running, but game is actually loading
                if (currentIgt != 0 && currentIgt > _inGameTime && currentIgt < _inGameTime + 1000 && blackscreenActive)
                {
                    //Trace.WriteLine($"Writing IGT: {TimeSpan.FromMilliseconds(_inGameTime)}");
                    _eldenRing.WriteInGameTimeMilliseconds(_inGameTime);
                }
                else
                {
                    if (currentIgt != 0)
                    {
                        _inGameTime = currentIgt;
                    }
                }

                if (_inGameTime == 0)
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("                                       ");
                }

                Console.SetCursorPosition(0, 1);
                Console.WriteLine(TimeSpan.FromMilliseconds(_inGameTime).ToString(@"hh\:mm\:ss\.fff"));

                Thread.Sleep(16);
            }
        }


        private static bool _isWarpRequested = false;
        private static bool _isWarping = false;
        private static bool _warpHasPlayerBeenUnloaded = false;
        private static void TrackWarps(DarkSouls1 _darkSouls1)
        {
            //Track warps - the game handles warps before the loading screen starts.
            //That's why they have to be tracked while playing, and then resolved on the next loading screen

            if (!_isWarpRequested)
            {
                _isWarpRequested = _darkSouls1.IsWarpRequested();
                return;
            }

            var isPlayerLoaded = _darkSouls1.IsPlayerLoaded();


            //Warp is requested - wait for loading screen
            if (_isWarpRequested)
            {
                if (!_warpHasPlayerBeenUnloaded)
                {
                    if (!isPlayerLoaded)
                    {
                        _warpHasPlayerBeenUnloaded = true;
                    }
                }
                else
                {
                    _isWarping = true;
                }

                if (_isWarping && isPlayerLoaded)
                {
                    _isWarping = false;
                    _warpHasPlayerBeenUnloaded = false;
                    _isWarpRequested = false;
                }
            }
        }
        #endregion


        public enum XInputButton : ushort
        {
            DPAD_UP = 0x0001,
            DPAD_DOWN = 0x0002,
            DPAD_LEFT = 0x0004,
            DPAD_RIGHT = 0x0008,
            START = 0x0010,
            BACK = 0x0020,
            LEFT_THUMB = 0x0040,
            RIGHT_THUMB = 0x0080,
            LEFT_SHOULDER = 0x0100,
            RIGHT_SHOULDER = 0x0200,
            A = 0x1000,
            B = 0x2000,
            X = 0x4000,
            Y = 0x8000,
        }

        public class XInputGamepad
        {
            public ushort wButtons = 0;
            public byte bLeftTrigger = 0;
            public byte bRightTrigger = 0;
            public short sThumbLX = 0;
            public short sThumbLY = 0;
            public short sThumbRX = 0;
            public short sThumbRY = 0;
        }

    }
}


#pragma warning restore CS0162
