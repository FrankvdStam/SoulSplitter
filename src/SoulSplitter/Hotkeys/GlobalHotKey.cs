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
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using SoulSplitter.Native;

namespace SoulSplitter.Hotkeys;

public static class GlobalHotKey
{
    private static readonly List<(int id, ModifierKeys modifier, Key key, Action action)> Hotkeys = [];
    private static readonly ManualResetEvent WindowReadyEvent = new(false);
    public static volatile HotkeyForm? HotkeyForm;
    public static volatile IntPtr Handle;
    private static int _currentId;

    static GlobalHotKey()
    {
        var messageLoopThread = new Thread(delegate ()
        {
            Application.Run(new HotkeyForm(WindowReadyEvent));
        });
        messageLoopThread.Name = "MessageLoopThread";
        messageLoopThread.IsBackground = true;
        messageLoopThread.Start();
    }

    public static void OnHotkeyPressed(ModifierKeys modifier, Key key)
    {
        Hotkeys.ForEach(x =>
        {
            if (modifier == x.modifier && key == x.key)
            {
                x.action();
            }
        });
    }

    public static int RegisterHotKey(ModifierKeys modifier, Key key, Action action)
    {
        WindowReadyEvent.WaitOne(); //wait for hotkey window to have initialized

        var virtualKeyCode = (Keys)KeyInterop.VirtualKeyFromKey(key);
        int id = Interlocked.Increment(ref _currentId);

        Delegate register = (Action)(() =>
        {
            User32.RegisterHotkey(
                Handle,
                id,
                (uint)modifier | 0x4000, //no repeat
                (uint)virtualKeyCode);
        });

        HotkeyForm?.Invoke(register);
        Hotkeys.Add((id, modifier, key, action));
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

        HotkeyForm?.Invoke(unregister);
        Hotkeys.Remove(Hotkeys.Find(i => i.id == id));
    }
}

public class HotkeyForm : Form
{
    public HotkeyForm(ManualResetEvent windowReadyEvent)
    {
        GlobalHotKey.Handle = Handle;
        GlobalHotKey.HotkeyForm = this;
        windowReadyEvent.Set();
    }

    protected override void WndProc(ref Message windowMessage)
    {
        base.WndProc(ref windowMessage);

        if (windowMessage.Msg == 0x0312) //0x0312 is the hotkey message
        {
            var key = KeyInterop.KeyFromVirtualKey((int)windowMessage.LParam >> 16 & 0xFFFF);
            var modifier = (ModifierKeys)((int)windowMessage.LParam & 0xFFFF);
            GlobalHotKey.OnHotkeyPressed(modifier, key);
        }
    }

    protected override void SetVisibleCore(bool value)
    {
        base.SetVisibleCore(false);
    }
}
