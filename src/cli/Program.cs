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
using SoulSplitter.UI;
using SoulMemory.DarkSouls1;
using SoulMemory.EldenRing;
using SoulMemory.Sekiro;
using SoulMemory;
using SoulSplitter.UI.Generic;

#pragma warning disable CS0162

namespace cli
{
    internal class Program
    {        
        [STAThread]
        static void Main(string[] args)
        {
            TestUi();
            return;
            


            var sekiro = new Sekiro();
            sekiro.TryRefresh();
            
            var flagWatcher = new FlagWatcher(sekiro, Enumerable.Range(6000, 1000).ToList().Select(i => (uint)i));
            while (true)
            {
                if (sekiro.TryRefresh().IsOk)
                {
                    var before1 = sekiro.ReadEventFlag(6051);
                    var before2 = sekiro.ReadEventFlag(6059);

                    sekiro.WriteEventFlag(6051, true);
                    sekiro.WriteEventFlag(6059, true);

                    var after1 = sekiro.ReadEventFlag(6051);
                    var after2 = sekiro.ReadEventFlag(6059);

                    var changes = flagWatcher.Update();
                    foreach (var change in changes)
                    {
                        Console.WriteLine($"{change.Key} {change.Value}");
                    }
                }
            }


            ValidatePatterns(); return;
            
            ////ValidatePatterns(); return;
            //
            GameLoop<EldenRing>((er) =>
            {
                Console.WriteLine(er.GetInGameTimeMilliseconds());
                Console.WriteLine(er.GetPosition());
                Console.WriteLine(er.ReadEventFlag((uint)SoulMemory.EldenRing.ItemPickup.LDChapelOfAnticipationTarnishedsWizenedFinger));
            });


            //GameLoop<DarkSouls1>((ds1) =>
            //{
            //    Console.WriteLine(ds1.GetInGameTimeMilliseconds());
            //    Console.WriteLine(ds1.ReadEventFlag((uint)SoulMemory.DarkSouls1.Boss.AsylumDemon));
            //    Console.WriteLine(ds1.GetSaveFileLocation());
            //});

            GameLoop<Sekiro>((game) =>
            {
                Console.WriteLine(game.GetInGameTimeMilliseconds());
            });
        }


        private static void GameLoop<T>(Action<T> display) where T : IGame, new()
        {
            var game = new T();
            while (true)
            {
                try
                {
                    var result = game.TryRefresh();
                    if (result.IsErr)
                    {
                        var err = result.GetErr();
                        Console.Clear();
                        Console.WriteLine(err.ToString());
                        Console.Out.Flush();
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else
                    {
                        display.Invoke(game);
                        Thread.Sleep(16);
                        Console.SetCursorPosition(0, 0);
                    }
                }
                catch(Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.ToString());
                    Thread.Sleep(3000);
                }
            }
        }

        public static void TestUi()
        {
            var (form, _, mainControl) = MainControl.GetTestForm();

            foreach(var boss in (SoulMemory.EldenRing.Boss[])Enum.GetValues(typeof(SoulMemory.EldenRing.Boss)))
            {
                mainControl.MainViewModel.EldenRingViewModel.NewSplitTimingType = SoulSplitter.UI.Generic.TimingType.Immediate;
                mainControl.MainViewModel.EldenRingViewModel.NewSplitType = SoulSplitter.Splits.EldenRing.EldenRingSplitType.Boss;
                mainControl.MainViewModel.EldenRingViewModel.NewSplitBoss = boss;
                mainControl.MainViewModel.EldenRingViewModel.AddSplit();
            }

            var flagTrackerViewModel = mainControl.MainViewModel.FlagTrackerViewModel;
            flagTrackerViewModel.EventFlagCategories.Add(new FlagTrackerCategoryViewModel { CategoryName = "Undead burg", EventFlags = new System.Collections.ObjectModel.ObservableCollection<FlagDescription>()
            {
                new FlagDescription{ Flag = 162,  Description = "stuff",      State = true},
                new FlagDescription{ Flag = 3213, Description = "more stuff", State = true},
                new FlagDescription{ Flag = 31,   Description = "more stuff", State = true},
                new FlagDescription{ Flag = 5231, Description = "more stuff", State = false},
                new FlagDescription{ Flag = 124,  Description = "more stuff", State = false},
                new FlagDescription{ Flag = 415,  Description = "more stuff", State = false},
            }});

            flagTrackerViewModel.EventFlagCategories.Add(new FlagTrackerCategoryViewModel { CategoryName = "Firelink shrine", EventFlags = new System.Collections.ObjectModel.ObservableCollection<FlagDescription>()
            {
                new FlagDescription{ Flag = 162,  Description = "stuff",      State = true},
                new FlagDescription{ Flag = 3213, Description = "more stuff", State = true},
                new FlagDescription{ Flag = 31,   Description = "more stuff", State = true},
                new FlagDescription{ Flag = 5231, Description = "more stuff", State = false},
                new FlagDescription{ Flag = 124,  Description = "more stuff", State = false},
                new FlagDescription{ Flag = 415,  Description = "more stuff", State = false},
            }});
            
            form.ShowDialog();

        }

        #region Validate patterns 
        public static void ValidatePatterns()
        {
            var validatables = new List<(string Name, IGame Game, string Directory)>()
            {
                //("Dark Souls PTDE"      , new Ptde()        , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\ptde"             ),
                //("Dark Souls Remastered", new Remastered()  , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\DSR"              ),
                //("Dark Souls 3"         , new DarkSouls3()  , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\DS3\executables"  ),
                ("Sekiro"               , new Sekiro()      , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\Sekiro"           ),
                //("Elden Ring"           , new EldenRing()   , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\eldenring"        ),
            };

            foreach(var validatable in validatables)
            {
                var tree = validatable.Game.GetTreeBuilder();
                var files = Directory.EnumerateFiles(validatable.Directory).ToList();

                Console.WriteLine($"Starting {validatable.Name}");

                var s = new Stopwatch();
                s.Start();
                
                if (!SoulMemory.Memory.MemoryScanner.TryValidatePatterns(tree, files, out List<(string fileName, string patternName, long count)> errors))
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

                var result = ds1.TryRefresh();
                if (result.IsErr)
                {
                    var err = result.GetErr();
                    Console.Clear();
                    Console.WriteLine(err.ToString());
                    Console.Out.Flush();
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

                        var result2 = ds1.TryRefresh();
                        if (result2.IsErr)
                        {
                            var err = result2.GetErr();
                            Console.WriteLine(err.ToString());
                            Console.WriteLine("Error occurred, press any key to exit.");
                            Console.Clear();
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
                    Test("GetSaveFileGameTimeMilliseconds", () => { ds1.GetSaveFileGameTimeMilliseconds(ds1.GetSaveFileLocation(), ds1.GetCurrentSaveSlot()); });


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

                var result = _eldenRing.TryRefresh();
                if (result.IsErr)
                {
                    var err = result.GetErr();
                    Console.Clear();
                    Console.WriteLine(err.ToString());
                    Console.Out.Flush();
                    Thread.Sleep(3000);
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
