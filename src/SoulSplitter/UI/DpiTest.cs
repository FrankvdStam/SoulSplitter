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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoulSplitter.UI
{
    public class DpiTest
    {
        [DllImport("User32.dll")]
        public static extern DPI_AWARENESS_CONTEXT GetThreadDpiAwarenessContext();

        [DllImport("User32.dll")]
        public static extern DPI_AWARENESS_CONTEXT GetWindowDpiAwarenessContext(IntPtr hwnd);

        [DllImport("User32.dll")]
        public static extern DPI_AWARENESS_CONTEXT SetThreadDpiAwarenessContext(DPI_AWARENESS_CONTEXT dpiContext);

        [DllImport("User32.dll")]
        public static extern DPI_AWARENESS GetAwarenessFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);

        [DllImport("user32.dll")]
        static extern IntPtr GetActiveWindow();

        public static void Testy()
        {
            try
            {
                var threadDpi = GetThreadDpiAwarenessContext();
                var windowDpi = GetWindowDpiAwarenessContext(GetActiveWindow());

                var thread = GetAwarenessFromDpiAwarenessContext(threadDpi);
                var window = GetAwarenessFromDpiAwarenessContext(windowDpi);

                Logger.Log($"Dpi test: {thread}({threadDpi}) - {window}({windowDpi})");

                if (threadDpi != windowDpi)
                {
                    SetThreadDpiAwarenessContext(windowDpi);
                }
            }
            catch (Exception e)
            {
                Logger.Log("Dpi test failed", e);
            }
        }



        public enum DPI_AWARENESS
        {
            DPI_AWARENESS_INVALID = -1,
            DPI_AWARENESS_UNAWARE = 0,
            DPI_AWARENESS_SYSTEM_AWARE = 1,
            DPI_AWARENESS_PER_MONITOR_AWARE = 2
        }

        public enum DPI_AWARENESS_CONTEXT
        {
            DPI_AWARENESS_CONTEXT_DEFAULT = 0, // Undocumented
            DPI_AWARENESS_CONTEXT_UNAWARE = -1, // Undocumented
            DPI_AWARENESS_CONTEXT_SYSTEM_AWARE = -2, // Undocumented
            DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE = -3 // Undocumented
        }
    }
}
