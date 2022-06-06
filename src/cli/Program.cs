using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoulMemory;
using SoulMemory.DarkSouls1;
using SoulMemory.DarkSouls3;
using SoulMemory.EldenRing;
using SoulMemory.Memory;
using SoulMemory.Native;
using SoulMemory.Shared;
using SoulSplitter;
using SoulSplitter.UI;
using Item = SoulMemory.EldenRing.Item;


#pragma warning disable CS0162

namespace cli
{
    internal class Program
    {
        
        [STAThread]
        static void Main(string[] args)
        {
            //Ds3TestPatterns();
            //return;

            var ds3 = new DarkSouls3();
            while (true)
            {
                Console.WriteLine(ds3.ReadEventFlag(14000002));
                ds3.Refresh();
                Thread.Sleep(100);
            }
            ds3.Refresh();
            ds3.ReadEventFlag(14000002);//bonfire
            //ds3.ReadEventFlag(50002180);//coiled sword
            //24005192 rest gesture?
            //14000800 IND GUN boss
            return;

            var client = new SoulInjecteeClient();
            client.Send(new SoulMemory.Message()
            {
                MessageType = "DarkSouls3ReadEventFlagMessage",
                DarkSouls3ReadEventFlagMessage = new DarkSouls3ReadEventFlagMessage()
                {
                    SprjEventFlagManager = ds3.GetSprjEventFlagManAddress(),
                    EventFlagId = 50002180,
                    State = true,
                }
            });
            client.Dispose();
            return;

            


            //TestAobs();
            //return;
            //
            //using (var client = new SoulInjecteeClient())
            //{
            //}
            //return;

            //TestUi();
            //InjectDll(@"C:\projects\Dark souls\SoulSplitter\target\x86_64-pc-windows-msvc\debug\soulinjectee.dll");
            //return;

            //return;
            //var itesm = Enum.GetValues(typeof(Item)).Cast<Item>().ToList();
            //var counts = new Dictionary<string, int>();
            //
            //foreach (var i in itesm)
            //{
            //    if (!counts.ContainsKey(i.GetDisplayDescription()))
            //    {
            //        counts[i.GetDisplayDescription()] = 0;
            //    }
            //
            //    counts[i.GetDisplayDescription()]++;
            //}


            var er = new EldenRing();
            while (true)
            {
                Console.Clear();
                //var p = er.GetPosition();
                //Console.WriteLine($"FA: {p.Area} {p.Block} {p.Region} {p.Size} POS: {p.X:F2} {p.Y:F2} {p.Z:F2}");
                Console.WriteLine(er.GetTestValue());
                er.Refresh();
                Thread.Sleep(100);
            }

            //LogSetEventFlag(EventFlagLogMode.All);
            //TestAobs();
            TestUi();
            //Testy2();

             return;
            

            

            //Thread.Sleep(10000);
            
            er.Init();
            //er.ReadEventFlag(71801);

            while (true)
            {
                var items = er.ReadInventory();
                Console.Clear();

                foreach (var item in items)
                {
                    //Console.WriteLine($"{item.GetDisplayDescription()} {item.GetDisplayName()} {(uint)item}");
                }

                Thread.Sleep(100);
                er.Refresh();
            }
            


            Console.ReadKey();
            return;


            var discovery = new EventFlagDiscovery(er);

            for (;;)
            {
                discovery.Update();

                Thread.Sleep(500);
                er.Refresh();
            }
        }


        private static void Testy2()
        {
            var er = new DarkSouls1();
            er.Refresh();

            var isKill = er.IsBossDefeated(BossType.AsylumDemon);


            //for (; ; )
            //{
            //    //Console.Clear();
            //    Console.WriteLine(er.IsInGame() + " " + er.GetInGameTimeMilliseconds());
            //    Thread.Sleep(10);
            //
            //    er.Refresh();
            //}
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

        public static void TestErExe()
        {
            Console.WriteLine("start");
            Process process = null;
            while (process == null)
            {
                process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("eldenring"));
            }

            var buffer1 = new byte[process.MainModule.ModuleMemorySize];
            int read = 0;
            Kernel32.ReadProcessMemory(process.Handle, process.MainModule.BaseAddress, buffer1, buffer1.Length, ref read);

            //Thread.Sleep(10000);

            var buffer2 = new byte[process.MainModule.ModuleMemorySize];
            read = 0;
            Kernel32.ReadProcessMemory(process.Handle, process.MainModule.BaseAddress, buffer2, buffer2.Length, ref read);

            var hash1 = md5Hash(buffer1);
            var hash2 = md5Hash(buffer2);

            Console.WriteLine(hash1);
            Console.WriteLine(hash2);



            for (;;)
            {
                var buffer = new byte[process.MainModule.ModuleMemorySize];
                read = 0;
                Kernel32.ReadProcessMemory(process.Handle, process.MainModule.BaseAddress, buffer, buffer.Length, ref read);
                Console.WriteLine(md5Hash(buffer));
            }




            //while (true)
            //{
            //    Console.WriteLine(process.MainModule.ModuleMemorySize);
            //}
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
            patternCounter.AddPattern("menuMan"         , "48 8b cb 41 ff 10 4c 8b 07 48 8b d3 48 8b cf 41 ff 50 68 48 89 35 ? ? ? ? 48 8b 0d ? ? ? ? 48 85 c9 74 33 e8 ? ? ? ? 48 8b 1d ? ? ? ? 48 8b f8 48 85 db 74 18 4c 8b 03 33 d2 48 8b cb 41 ff 10 4c 8b 07 48 8b d3 48 8b cf 41 ff 50 68 48 89 35 ? ? ? ? 48 8b 5c 24 30 48 8b 74 24 38 48 83 c4 20 5f c3");
            patternCounter.AddPattern("IGT"             , "48 8b 0d ? ? ? ? 4c 8d 44 24 40 45 33 c9 48 8b d3 40 88 74 24 28 44 88 74 24 20");
            patternCounter.AddPattern("playerIns"       , "48 8b 0d ? ? ? ? 45 33 c0 48 8d 55 e7 e8 ? ? ? ? 0f 2f 73 70 72 0d f3 ? ? ? ? ? ? ? ? 0f 11 43 70");
            patternCounter.AddPattern("Loading"         , "c6 05 ? ? ? ? ? e8 ? ? ? ? 84 c0 0f 94 c0 e9");
            patternCounter.AddPattern("SprjFadeImp"     , "48 8b 0d ? ? ? ? 4c 8d 4c 24 38 4c 8d 44 24 48 33 d2");
            patternCounter.AddPattern("SprjEventFlagMan", "48 c7 05 ? ? ? ? 00 00 00 00 48 8b 7c 24 38 c7 46 54 ff ff ff ff 48 83 c4 20 5e c3");
            patternCounter.AddPattern("FieldArea"       , "4c 8b 3d ? ? ? ? 8b 45 87 83 f8 ff 74 69 48 8d 4d 8f 48 89 4d 9f 89 45 8f 48 8d 55 8f 49 8b 4f 10");

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


#if DEBUG
        public static void InjectDll(string path)
        {
            var er = new EldenRing();
            er.Init();
            er.InjectDll(path);
        }
#endif

    }
}


#pragma warning restore CS0162
