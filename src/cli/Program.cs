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
using SoulSplitter.UI;
using SoulMemory.DarkSouls1;
using SoulMemory.DarkSouls3;
using SoulMemory.Sekiro;
using SoulMemory.EldenRing;
using SoulMemory.Memory;
using SoulMemory.Shared;
using System.Security.Cryptography;
using SoulMemory;
using System.Text;

#pragma warning disable CS0162

namespace cli
{
    internal class Program
    {
        


        [STAThread]
        static void Main(string[] args)
        {
            var ds3 = new DarkSouls3();
            
            GameLoop(ds3, () =>
            {
                Console.WriteLine($"{ds3.GetInGameTimeMilliseconds()}");
                Console.WriteLine($"peepo: {ds3.ReadEventFlag((uint)SoulMemory.DarkSouls3.Boss.IudexGundyr)}");
            });

            var ds1 = new DarkSouls1();
            ds1.TryRefresh(out _);

            while (true)
            {
                Console.WriteLine($"{ds1.GetInGameTimeMilliseconds()}");

                if (!ds1.TryRefresh(out Exception e))
                {
                    Console.WriteLine(e);
                    Thread.Sleep(3000);
                    Console.Clear();
                }

                var isAsAlive = ds1.ReadEventFlag((uint)SoulMemory.DarkSouls1.Boss.AsylumDemon);

                Thread.Sleep(10);
                Console.SetCursorPosition(0, 0);
                //Console.Clear();
            }
        }

        private static void GameLoop<T>(T game, Action display) where T : IGame
        {
            while (true)
            {
                if (!game.TryRefresh(out Exception e))
                {
                    Console.Clear();
                    Console.WriteLine(e);
                    Console.Out.Flush();
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    display.Invoke();
                    Thread.Sleep(16);
                    Console.SetCursorPosition(0, 0);
                }
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

        #region Validate patterns 
        public static void ValidatePatterns()
        {
            var validatables = new List<(string Name, IGame Game, string Directory)>()
            {
                ("Dark Souls Remastered", new Remastered(), @"C:\Users\Frank\Desktop\dark souls\runtime dumps\DSR"              ),
                ("Dark Souls 3"         , new DarkSouls3(), @"C:\Users\Frank\Desktop\dark souls\runtime dumps\DS3\executables"  ),
            };

            foreach(var validatable in validatables)
            {
                var tree = validatable.Game.GetTreeBuilder();
                var files = Directory.EnumerateFiles(validatable.Directory).ToList();

                Console.WriteLine($"Starting {validatable.Name}");

                var s = new Stopwatch();
                s.Start();
                
                if (!SoulMemory.MemoryV2.MemoryScanner.TryValidatePatterns(tree, files, out List<(string fileName, string patternName, long count)> errors))
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine($"{error.fileName} {error.patternName} {error.count}");
                    }
                }

                s.Stop();
                Console.WriteLine($"Finished {validatable.Name}, elapsed {s.Elapsed}");
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        #endregion

        #region Ds1 diagnostic

        private static void Ds1Diagnostic()
        {
            var ds1 = new DarkSouls1();
            while (true)
            {
                Console.WriteLine($"{ds1.GetInGameTimeMilliseconds()}");

                if (!ds1.TryRefresh(out Exception e))
                {
                    Console.WriteLine(e.Format());
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    void Test(string name, Action f)
                    {
                        Console.WriteLine(name);
                        f();
                        Thread.Sleep(5000);
                        if (!ds1.TryRefresh(out Exception exc))
                        {
                            Console.WriteLine(exc.ToString());
                            Console.WriteLine("Error occurred, press any key to exit.");
                            Console.ReadKey();
                        }
                    }

                    Test("GetAttribute", () => { ds1.GetAttribute(SoulMemory.DarkSouls1.Attribute.Strength); });
                    Test("ReadEventFlag", () => { ds1.ReadEventFlag(16); });
                    Test("IsWarpRequested", () => { ds1.IsWarpRequested(); });
                    Test("IsPlayerLoaded", () => { ds1.IsPlayerLoaded(); });
                    Test("GetPosition", () => { ds1.GetPosition(); });
                    Test("NgCount", () => { ds1.NgCount(); });
                    Test("GetCurrentSaveSlot", () => { ds1.GetCurrentSaveSlot(); });
                    Test("ResetInventoryIndices", () => { ds1.ResetInventoryIndices(); });
                    Test("GetInventory", () => { ds1.GetInventory(); });
                    Test("AreCreditsRolling", () => { ds1.AreCreditsRolling(); });
                    Test("GetBonfireState", () => { ds1.GetBonfireState(SoulMemory.DarkSouls1.Bonfire.UndeadAsylumCourtyard); });
                    Test("GetSaveFileLocation", () => { ds1.GetSaveFileLocation(); });
                    Test("IsPtde", () => { ds1.IsPtde(); });
                    Test("GetSaveFileGameTimeMilliseconds", () => { ds1.GetSaveFileGameTimeMilliseconds(ds1.GetSaveFileLocation(), ds1.GetCurrentSaveSlot(), ds1.IsPtde()); });


                    Console.WriteLine("Done, press any key to exit.");
                    Console.ReadKey();
                    return;
                }

                Thread.Sleep(10);
                Console.SetCursorPosition(0, 0);
                //Console.Clear();
            }
        }

        #endregion

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

        #endregion
    }
}

#pragma warning restore CS0162
