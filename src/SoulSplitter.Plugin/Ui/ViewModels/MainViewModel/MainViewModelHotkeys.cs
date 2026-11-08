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
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static SoulSplitter.Plugin.Ui.View.Controls.HotkeyPicker;

namespace SoulSplitter.Plugin.Ui.ViewModels.MainViewModel
{
    public partial class MainViewModel
    {
        public ObservableCollection<HotkeyViewModel> Hotkeys { get; set; } = new();
        public HotkeyViewModel? SelectedHotkey { get; set; } = null;


        public HotkeyAction SelectedHotkeyAction
        {
            get => _selectedHotkeyAction;
            set => SetField(ref _selectedHotkeyAction, value);
        }
        private HotkeyAction _selectedHotkeyAction;

        public float SelectedFpsPatchValue
        {
            get => _selectedFpsPatchValue;
            set => _selectedFpsPatchValue = value;
        }
        private float _selectedFpsPatchValue = 60.0f;

        public void HotkeyCompleted(object? param)
        {
            if(param is HotkeyCompletedParameter hotkeyCompletedParam)
            {
                _hotkey = new Hotkey()
                {
                    Key = hotkeyCompletedParam.Key,
                    Modifiers = hotkeyCompletedParam.ModifierKeys,
                };
            }
        }

        private Hotkey? _hotkey = null;

        public bool CanRemoveHotkey()
        {
            return SelectedHotkey != null;
        }

        public void RemoveHotkey()
        {
            if(SelectedHotkey?.Id != null)
            {
                GlobalHotkey.UnregisterHotKey(SelectedHotkey!.Id!.Value); //TODO: handle globally, this doesn't work with serialization
            }

            Hotkeys.Remove(SelectedHotkey!);
            SelectedHotkey = null;
        }

       

        public bool CanAddHotkey()
        {
            if(_hotkey == null)
            {
                return false;
            }

            return true;
        }

        public void AddHotkey()
        {
            var vm = new HotkeyViewModel
            {
                Hotkey = _hotkey!,
                HotkeyAction = SelectedHotkeyAction,
                Parameter = SelectedHotkeyAction == HotkeyAction.FpsPatchSetFpsValue ? SelectedFpsPatchValue : null,
            };

            Hotkeys.Add(vm);

            vm.Id = GlobalHotkey.RegisterHotKey(vm.Hotkey, () => { Debug.WriteLine($"hotkey {vm.Hotkey} {vm.Id}"); }); //TODO: handle globally, this doesn't work with serialization
        }
    }
}
