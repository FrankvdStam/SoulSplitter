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

using SoulMemory.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace SoulSplitter.Hotkeys
{
    public static class GlobalHotkey
    {
        private static readonly List<(int id, Hotkey hotkey, Action action)> Hotkeys = new List<(int, Hotkey, Action)>();
        private static readonly ManualResetEvent WindowReadyEvent = new ManualResetEvent(false);
        public static volatile HotkeyForm HotkeyForm = null!;
        public static volatile IntPtr Handle;
        private static int _currentId;

        static GlobalHotkey()
        {
            var messageLoopThread = new Thread(delegate ()
            {
                Application.Run(new HotkeyForm(WindowReadyEvent));
            });
            messageLoopThread.Name = "MessageLoopThread";
            messageLoopThread.IsBackground = true;
            messageLoopThread.Start();
        }

        public static void OnHotkeyPressed(Hotkey hotkey)
        {
            Hotkeys.ForEach(x =>
            {
                if (hotkey.Modifiers == x.hotkey.Modifiers && hotkey.Key == x.hotkey.Key)
                {
                    x.action();
                }
            });
        }

        public static int RegisterHotKey(Hotkey hotkey, Action action)
        {
            WindowReadyEvent.WaitOne(); //wait for hotkey window to have initialized

            var virtualKeyCode = (Keys)KeyInterop.VirtualKeyFromKey(hotkey.Key);
            int id = Interlocked.Increment(ref _currentId);

            Delegate register = (Action)(() =>
            {
                User32.RegisterHotkey(
                    Handle,
                    id,
                    (uint)hotkey.Modifiers | 0x4000, //no repeat
                    (uint)virtualKeyCode);
            });

            HotkeyForm.Invoke(register);
            Hotkeys.Add((id, hotkey, action));
            return id;
        }

        public static void UnregisterHotKey(int id)
        {
            if (Hotkeys.All(i => i.id != id))
            {
                return;
            }

            Delegate unregister = (Action)(() =>
            {
                User32.UnregisterHotkey(Handle, id);
            });

            HotkeyForm.Invoke(unregister);
            Hotkeys.Remove(Hotkeys.Find(i => i.id == id));
        }
    }
}