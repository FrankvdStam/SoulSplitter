using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoulMemory.DarkSouls1;
using SoulMemory.DarkSouls3;
using SoulMemory.EldenRing;
using SoulMemory.Memory;
using SoulMemory.Native;
using SoulMemory.Shared;
using SoulSplitter;
using SoulSplitter.UI;

namespace cli
{
    internal class Program
    {
        
        [STAThread]
        static void Main(string[] args)
        {
            var er = new EldenRing();
            er.Refresh();

            while (true)
            {
                er.ResetIgt();
                er.Refresh();
            }


            return;


        //InjectDll(@"C:\projects\Dark souls\SoulSplitter\target\x86_64-pc-windows-msvc\debug\soulinjectee.dll");
        //LogSetEventFlag(EventFlagLogMode.All);
        //TestAobs();
        //TestUi();
            //Testy2();


//           return;
            

            

            //Thread.Sleep(10000);
            
            er.Init();
            //er.ReadEventFlag(71801);



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



        private static Dictionary<string, byte[]> _cache = new Dictionary<string, byte[]>();

        public static void TestAobs()
        {
            //fd4 alternative 48 8b 0d ? ? ? ? 48 85 c9 74 06 48 8b 59 08

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


        public static void AobCount(string identifier, string aob)
        {
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
