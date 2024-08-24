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
using System.Runtime.InteropServices;

namespace SoulSplitter.Native
{
    public static class User32
    {
        private static class NativeMethods
        {
            [DllImport("user32.dll")]
            internal static extern bool RegisterHotKey(IntPtr handle, int id, uint modifiers, uint virtualKeyCode);


            [DllImport("user32.dll")]
            internal static extern bool UnregisterHotKey(IntPtr handle, int id);
        }

        public static bool RegisterHotkey(IntPtr handle, int id, uint modifiers, uint virtualKeyCode) => NativeMethods.RegisterHotKey(handle, id, modifiers, virtualKeyCode);
        public static bool UnregisterHotkey(IntPtr handle, int id) => NativeMethods.UnregisterHotKey(handle, id);

    }
}
