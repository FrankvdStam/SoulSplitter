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
using SoulMemory.Shared;
using SoulSplitter.UI;

namespace cli
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Testy2();

            var er = new EldenRing();

            for (;;)
            {
                Console.Clear();
                Console.WriteLine(er.GetPosition());
                Thread.Sleep(50);

                er.Refresh();
            }
        }


        private static void Testy2()
        {
            var er = new DarkSouls3();

            for (; ; )
            {
                //Console.Clear();
                Console.WriteLine(er.IsInGame() + " " + er.GetInGameTimeMilliseconds());
                Thread.Sleep(10);

                er.Refresh();
            }
        }


        private static void Testy()
        {
            Pointer bossKillCount;
            Pointer AiManager;
            Pointer rightHandWeaponMultiplier;
            Pointer LeftHandWeaponMultiplier;

            var process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.StartsWith("DarkSoulsII"));

            process.ScanPatternRelative("48 8B 05 ?? ?? ?? ?? 48 8B 58 38 48 85 DB 74 ?? F6", 3, 7)
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
    }
}
