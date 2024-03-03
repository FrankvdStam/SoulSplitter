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
using System.Threading;
using SoulMemory.DarkSouls1;
using SoulMemory.DarkSouls2;
using SoulMemory.DarkSouls3;
using SoulMemory.Sekiro;
using SoulMemory.EldenRing;

#pragma warning disable CS0162

namespace clitimer
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Re-enable the cursor and move down a line on CTRL + C, in order to properly clean up timer stuff
            Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs e) =>
            {
                Console.CursorVisible = true;
                Console.SetCursorPosition(0, Console.CursorTop + 1);
            };

            // Prompt the user for which game to use the timer on
            Console.Write("[1] Dark Souls 1\n[2] Dark Souls 2\n[3] Dark Souls 3\n[S] Sekiro\n[E] Elden Ring\nSelect game: ");
            var sel = Console.Read();

            // Not the prettiest, but whatever, merging all of them probably wouldn't have been much nicer
            switch (Convert.ToChar(sel))
            {
                case '1':
                    ds1Timer();
                    break;
                case '2':
                    ds2Timer();
                    break;
                case '3':
                    ds3Timer();
                    break;
                case 'E':
                case 'e':
                    eldenringTimer();
                    break;
                case 'S':
                case 's':
                    sekiroTimer();
                    break;
            }

            // Generic error message because why not
            Console.WriteLine("Unknown or unimplemented. Exiting..");

            return;
        }

        private static void ds1Timer()
        {
            // Set the cursor invisible, because we don't want to see it over the timer
            Console.CursorVisible = false;

            // Prep
            int _inGameTime = 0;
            var _ds1 = new DarkSouls1();
            bool hadError = false;

            // Timer loop, refreshes roughly every frame @ 60 FPS
            // Prints the current time or error and immediately moves back a line (or multiple at least for longer errors)
            // Resizing the terminal while it's running might not work well
            while (true)
            {
                // Refresh, display errors if there are any
                var result = _ds1.TryRefresh();
                if (result.IsErr)
                {
                    var err = result.GetErr();
                    Console.WriteLine(err.ToString());
                    Console.SetCursorPosition(0, Console.CursorTop - (int)Math.Ceiling((float)err.ToString().Length / (float)Console.WindowWidth));
                    hadError = true;
                    continue;
                }
                else if (hadError)
                {
                    Console.Write(new String(' ', Console.BufferWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    hadError = false;
                }

                // Get ingame time
                var currentIgt = _ds1.GetInGameTimeMilliseconds();
                if (currentIgt != 0)
                {
                    _inGameTime = currentIgt;
                }

                // Finally format the current time and output it
                TimeSpan ts = TimeSpan.FromMilliseconds(_inGameTime);
                Console.WriteLine($"{(int)ts.TotalHours:D2}" + ts.ToString(@"\:mm\:ss\.fff"));
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Thread.Sleep(16);
            }
        }

        private static void ds2Timer()
        {
            // Set the cursor invisible, because we don't want to see it over the timer
            Console.CursorVisible = false;

            // Prep
            int _inGameTime = 0;
            var _ds2 = new DarkSouls2();
            bool hadError = false;

            // Timer loop, refreshes roughly every frame @ 60 FPS
            // Prints the current time or error and immediately moves back a line (or multiple at least for longer errors)
            // Resizing the terminal while it's running might not work well
            while (true)
            {
                // Refresh, display errors if there are any
                var result = _ds2.TryRefresh();
                if (result.IsErr)
                {
                    var err = result.GetErr();
                    Console.WriteLine(err.ToString());
                    Console.SetCursorPosition(0, Console.CursorTop - (int)Math.Ceiling((float)err.ToString().Length / (float)Console.WindowWidth));
                    hadError = true;
                    continue;
                }
                else if (hadError)
                {
                    Console.Write(new String(' ', Console.BufferWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    hadError = false;
                }

                // Get ingame time
                var currentIgt = _ds2.GetInGameTimeMilliseconds();
                if (currentIgt != 0)
                {
                    _inGameTime = currentIgt;
                }

                // Finally format the current time and output it
                TimeSpan ts = TimeSpan.FromMilliseconds(_inGameTime);
                Console.WriteLine($"{(int)ts.TotalHours:D2}" + ts.ToString(@"\:mm\:ss\.fff"));
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Thread.Sleep(16);
            }
        }

        private static void ds3Timer()
        {
            // Set the cursor invisible, because we don't want to see it over the timer
            Console.CursorVisible = false;

            // Prep
            int _inGameTime = 0;
            var _ds3 = new DarkSouls3();
            bool hadError = false;

            // Timer loop, refreshes roughly every frame @ 60 FPS
            // Prints the current time or error and immediately moves back a line (or multiple at least for longer errors)
            // Resizing the terminal while it's running might not work well
            while (true)
            {
                // Refresh, display errors if there are any
                var result = _ds3.TryRefresh();
                if (result.IsErr)
                {
                    var err = result.GetErr();
                    Console.WriteLine(err.ToString());
                    Console.SetCursorPosition(0, Console.CursorTop - (int)Math.Ceiling((float)err.ToString().Length / (float)Console.WindowWidth));
                    hadError = true;
                    continue;
                }
                else if (hadError)
                {
                    Console.Write(new String(' ', Console.BufferWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    hadError = false;
                }

                // Get ingame time and blackscreen state
                var currentIgt = _ds3.GetInGameTimeMilliseconds();
                var blackscreenActive = _ds3.BlackscreenActive();

                // Blackscreens / meme loading screens - timer is running, but game is actually loading
                if (currentIgt != 0 && currentIgt > _inGameTime && currentIgt < _inGameTime + 1000 && blackscreenActive)
                {
                    _ds3.WriteInGameTimeMilliseconds(_inGameTime);
                }
                else
                {
                    if (currentIgt != 0)
                    {
                        _inGameTime = currentIgt;
                    }
                }

                // Finally format the current time and output it
                TimeSpan ts = TimeSpan.FromMilliseconds(_inGameTime);
                Console.WriteLine($"{(int)ts.TotalHours:D2}" + ts.ToString(@"\:mm\:ss\.fff"));
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Thread.Sleep(16);
            }
        }

        private static void sekiroTimer()
        {
            // Set the cursor invisible, because we don't want to see it over the timer
            Console.CursorVisible = false;

            // Prep
            int _inGameTime = 0;
            var _sekiro = new Sekiro();
            bool hadError = false;

            // Timer loop, refreshes roughly every frame @ 60 FPS
            // Prints the current time or error and immediately moves back a line (or multiple at least for longer errors)
            // Resizing the terminal while it's running might not work well
            while (true)
            {
                // Refresh, display errors if there are any
                var result = _sekiro.TryRefresh();
                if (result.IsErr)
                {
                    var err = result.GetErr();
                    Console.WriteLine(err.ToString());
                    Console.SetCursorPosition(0, Console.CursorTop - (int)Math.Ceiling((float)err.ToString().Length / (float)Console.WindowWidth));
                    hadError = true;
                    continue;
                }
                else if (hadError)
                {
                    Console.Write(new String(' ', Console.BufferWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    hadError = false;
                }

                // Get ingame time and blackscreen state
                var currentIgt = _sekiro.GetInGameTimeMilliseconds();
                var blackscreenActive = _sekiro.IsBlackscreenActive();

                // Blackscreens / meme loading screens - timer is running, but game is actually loading
                if (currentIgt != 0 && currentIgt > _inGameTime && currentIgt < _inGameTime + 1000 && blackscreenActive)
                {
                    _sekiro.WriteInGameTimeMilliseconds(_inGameTime);
                }
                else
                {
                    if (currentIgt != 0)
                    {
                        _inGameTime = currentIgt;
                    }
                }

                // Finally format the current time and output it
                TimeSpan ts = TimeSpan.FromMilliseconds(_inGameTime);
                Console.WriteLine($"{(int)ts.TotalHours:D2}" + ts.ToString(@"\:mm\:ss\.fff"));
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Thread.Sleep(16);
            }
        }

        private static void eldenringTimer()
        {
            // Set the cursor invisible, because we don't want to see it over the timer
            Console.CursorVisible = false;

            // Prep
            int _inGameTime = 0;
            var _er = new EldenRing();
            bool hadError = false;

            // Timer loop, refreshes roughly every frame @ 60 FPS
            // Prints the current time or error and immediately moves back a line (or multiple at least for longer errors)
            // Resizing the terminal while it's running might not work well
            while (true)
            {
                // Refresh, display errors if there are any
                var result = _er.TryRefresh();
                if (result.IsErr)
                {
                    var err = result.GetErr();
                    Console.WriteLine(err.ToString());
                    Console.SetCursorPosition(0, Console.CursorTop - (int)Math.Ceiling((float)err.ToString().Length / (float)Console.WindowWidth));
                    hadError = true;
                    continue;
                }
                else if (hadError)
                {
                    Console.Write(new String(' ', Console.BufferWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    hadError = false;
                }

                // Get ingame time and blackscreen state
                var currentIgt = _er.GetInGameTimeMilliseconds();
                var blackscreenActive = _er.IsBlackscreenActive();

                // Blackscreens / meme loading screens - timer is running, but game is actually loading
                if (currentIgt != 0 && currentIgt > _inGameTime && currentIgt < _inGameTime + 1000 && blackscreenActive)
                {
                    _er.WriteInGameTimeMilliseconds(_inGameTime);
                }
                else
                {
                    if (currentIgt != 0)
                    {
                        _inGameTime = currentIgt;
                    }
                }

                // Finally format the current time and output it
                TimeSpan ts = TimeSpan.FromMilliseconds(_inGameTime);
                Console.WriteLine($"{(int)ts.TotalHours:D2}" + ts.ToString(@"\:mm\:ss\.fff"));
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Thread.Sleep(16);
            }
        }

    }
}

#pragma warning restore CS0162
