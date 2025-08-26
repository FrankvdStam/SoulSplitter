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

using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace SoulSplitter.Hotkeys
{
    public class HotkeyForm : Form
    {
        public HotkeyForm(ManualResetEvent windowReadyEvent)
        {
            GlobalHotkey.Handle = Handle;
            GlobalHotkey.HotkeyForm = this;
            windowReadyEvent.Set();
        }

        protected override void WndProc(ref Message windowMessage)
        {
            base.WndProc(ref windowMessage);

            if (windowMessage.Msg == 0x0312) //0x0312 is the hotkey message
            {
                var key = KeyInterop.KeyFromVirtualKey((int)windowMessage.LParam >> 16 & 0xFFFF);
                var modifier = (ModifierKeys)((int)windowMessage.LParam & 0xFFFF);
                GlobalHotkey.OnHotkeyPressed(new Hotkey() { Modifiers = modifier, Key = key });
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }
    }
}
