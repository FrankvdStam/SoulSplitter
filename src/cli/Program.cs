using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using SoulSplitter.UI;

namespace cli
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Testy2();
            var er = new EldenRing();
            
            for (;;)
            {
                Console.Clear();
                Console.WriteLine(er.GetScreenState());
                Thread.Sleep(100);
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

            process.ScanCache().ScanRelative("48 8B 05 ?? ?? ?? ?? 48 8B 58 38 48 85 DB 74 ?? F6", 3, 7)
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
    }
}
