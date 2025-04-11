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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows;
using SoulMemory.Games.DarkSouls1;
using SoulMemory.Games.EldenRing;
using SoulMemory;
using SoulMemory.Enums;
using SoulMemory.Parameters;
using SoulMemory.Abstractions;
using SoulSplitter.Ui.ViewModels;
using SoulMemory.Games.Sekiro;
using SoulSplitter.Ui.View;
using SoulSplitter.Ui.ViewModels.MainViewModel;

#pragma warning disable CS0162

namespace cli
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            //var a = ResourceUtils.GenerateResourceDictionaryForEventFlag(typeof(KnownFlag));
            TestUi(true);
            return;
            GameLoop<EldenRing>(
                (d) =>
                {
                    Console.WriteLine(d.ReadNewGameLevel());
                    //var dropmod = new DropMod(d);
                    //dropmod.InitBkh();
                    //
                    //
                    //
                    //var igtElapsed = TimeSpan.FromMilliseconds(d.GetInGameTimeMilliseconds());
                    //Console.WriteLine($"IGT: {igtElapsed}");
                }
            );

            ValidatePatterns();return;

            TestUi();
            //GlobalHotKey.RegisterHotKey(ModifierKeys.Alt, Key.A, () =>{ Debug.WriteLine("A"); });
            //GlobalHotKey.RegisterHotKey(ModifierKeys.Alt, Key.S, () =>{ Debug.WriteLine("S"); });
            //GlobalHotKey.RegisterHotKey(ModifierKeys.Alt, Key.D, () =>{ Debug.WriteLine("D"); });

            var er = new EldenRing();
            er.TryRefresh();
            er.WriteInGameTimeMilliseconds(0);


            //TestUi();
            
        }


        private static void DropModBkh()
        {
            DropMod((_, d) => d.InitBkh(), (_, _) => { });
        }

        private static void DropModAA()
        {
            DropMod((_, d) => d.InitAllAchievements(), (_, d) => d.UpdateAllAchievements());
        }

        private static void DropMod(Action<DarkSouls1, DropMod> install, Action<DarkSouls1, DropMod> update)
        {
            var darkSouls1 = new DarkSouls1();
            var dropMod = new DropMod(darkSouls1);
            var hasInitialized = false;
            while (true)
            {
                try
                {
                    var result = darkSouls1.TryRefresh();

                    //Detect first time attaching 
                    if (!hasInitialized && result.IsOk)
                    {
                        Thread.Sleep(3000); //Let the game boot
                        install(darkSouls1, dropMod);
                        hasInitialized = true;
                    }

                    if (result.IsErr)
                    {
                        hasInitialized = false;
                        var err = result.GetErr();
                        Console.Clear();
                        Console.WriteLine(err.ToString());
                        Console.Out.Flush();
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else
                    {
                        update(darkSouls1, dropMod);
                        Thread.Sleep(16);
                        Console.SetCursorPosition(0, 0);
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.ToString());
                    Thread.Sleep(3000);
                    hasInitialized = false;
                }
            }
        }

        private static void GameLoop<T>(Action<T> display) where T : IGame
        {
            var game = (T)Activator.CreateInstance(
                typeof(T),
                BindingFlags.CreateInstance | BindingFlags.Public | BindingFlags.Instance | BindingFlags.OptionalParamBinding, 
                null, 
                new object[] { }, 
                CultureInfo.CurrentCulture);

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
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.ToString());
                    Thread.Sleep(3000);
                }
            }
        }

        public static void TestUi(bool withTestData = true)
        {
            var app = new SoulSplitter.Ui.App();
            app.InitializeComponent();
            var mainViewModel = new MainViewModel();
            var mainWindow = new MainWindow(mainViewModel);
            app.MainWindow = mainWindow;
            mainWindow.WindowShouldHide = false; //In livesplit, the window hides. Here it should exit.
            mainWindow.MainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 0, TimingType.Immediate, SplitType.Boss, SoulMemory.Games.Sekiro.Boss.HeadlessApe, "big boss"));
            mainWindow.MainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 1, TimingType.OnLoading, SplitType.Bonfire, Idol.AshinaReservoir, "rest here"));
            mainWindow.MainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 2, TimingType.OnLoading, SplitType.Attribute, new AttributeViewModel() { Attribute = SoulMemory.Games.Sekiro.Attribute.AttackPower, Level = 30 }, "Strong boi"));
            mainWindow.MainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 3, TimingType.Immediate, SplitType.Position, new PositionViewModel() { Position = new Vector3f(12.4f, 502.12f, 245.04f), Size = 5.0f }, "kekw"));
            mainWindow.MainViewModel.Splits.Add(new SplitViewModel(Game.Sekiro, 4, TimingType.Immediate, SplitType.Flag, 15062400u, "mystery flag"));
            mainWindow.ShowDialog();

            mainWindow.WindowShouldHide = false;
            mainWindow.Close();
            app.Shutdown();
        }
        
        #region Validate patterns 
        public static void ValidatePatterns()
        {
            var validatables = new List<(string Name, IGame Game, string Directory)>()
            {
                //("Dark Souls PTDE"      , new Ptde()        , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\ptde"             ),
                //("Dark Souls Remastered", new Remastered()  , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\DSR"              ),
                //("Dark Souls 3"         , new DarkSouls3()  , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\DS3\executables"  ),
                //("Sekiro"               , new Sekiro()      , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\Sekiro"           )
                ("Elden Ring"           , new EldenRing()   , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\eldenring"        ),
                //("Armored Core 6"           , new SoulMemory.ArmoredCore6.ArmoredCore6()   , @"C:\Users\Frank\Desktop\dark souls\runtime dumps\ac6"        ),
            };

            foreach (var validatable in validatables)
            {
                var tree = validatable.Game.GetTreeBuilder();
                var files = Directory.EnumerateFiles(validatable.Directory).ToList();

                Console.WriteLine($"Starting {validatable.Name}");

                var s = new Stopwatch();
                s.Start();

                if (!SoulMemory.Memory.MemoryScanner.TryValidatePatterns(tree, files, out var errors))
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
                Console.WriteLine($"{ds1.ReadInGameTimeMilliseconds()}");

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

                    Test("GetAttribute", () => { ds1.GetAttribute(SoulMemory.Games.DarkSouls1.Attribute.Strength); });
                    Test("ReadEventFlag", () => { ds1.ReadEventFlag(16); });
                    Test("IsWarpRequested", () => { ds1.IsWarpRequested(); });
                    Test("IsPlayerLoaded", () => { ds1.IsPlayerLoaded(); });
                    Test("GetPlayerPosition", () => { ds1.GetPlayerPosition(); });
                    Test("NgCount", () => { ds1.NgCount(); });
                    Test("GetCurrentSaveSlot", () => { ds1.GetCurrentSaveSlot(); });
                    Test("ResetInventoryIndices", () => { ds1.ResetInventoryIndices(); });
                    Test("GetInventory", () => { ds1.GetInventory(); });
                    Test("AreCreditsRolling", () => { ds1.AreCreditsRolling(); });
                    Test("GetBonfireState", () => { ds1.GetBonfireState(Bonfire.UndeadAsylumCourtyard); });
                    Test("GetSaveFileLocation", () => { ds1.GetSaveFileLocation(); });
                    Test("GetSaveFileGameTimeMilliseconds", () => { ds1.GetSaveFileGameTimeMilliseconds(ds1.GetSaveFileLocation() ?? "", ds1.GetCurrentSaveSlot()); });


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

        #region Param generation

        private static void GenerateParams()
        {
            var classHeader = @"// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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

using SoulMemory.Memory;
using SoulMemory.Parameters;
using System;

namespace SoulMemory.DarkSouls1.Parameters
{";

            var files = Directory.EnumerateFiles(@"C:\Users\Frank\Desktop\DS modders tools\DSMapStudio-1.08\Assets\Paramdex\DS1R\Defs").ToList();
            foreach (var f in files)
            {
                var fileName = Path.GetFileName(f);
                var className = fileName.Replace(".xml", "");
                fileName = fileName.Replace(".xml", ".cs");
                var result = ParamClassGenerator.GenerateFromXml(File.ReadAllText(f), className, classHeader);
                File.WriteAllText(@"C:\temp\" + fileName, result);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        #endregion
    }
}

#pragma warning restore CS0162
