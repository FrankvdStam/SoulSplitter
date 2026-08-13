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

using SoulSplitter.Plugin.Hotkeys;

namespace SoulSplitter.Plugin.Ui.ViewModels
{
    public enum HotkeyAction
    {
        FpsPatchDisable,
        FpsPatchSetFpsValue,
    }

    public class HotkeyViewModel : NotifyPropertyChanged
    {
        public Hotkey Hotkey
        {
            get => _hotkey;
            set => SetField(ref _hotkey, value);
        }
        private Hotkey _hotkey = null!;

        public HotkeyAction HotkeyAction
        {
            get => _hotkeyAction;
            set => SetField(ref _hotkeyAction, value);
        }
        private HotkeyAction _hotkeyAction;

        public object? Parameter
        {
            get => _parameter;
            set => SetField(ref _parameter, value);
        }
        private object? _parameter = null;

        public int? Id;
    }
}
