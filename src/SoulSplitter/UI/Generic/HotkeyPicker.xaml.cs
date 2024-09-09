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

using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Input;
using SoulSplitter.UI.EldenRing;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using TextBox = System.Windows.Controls.TextBox;
using UserControl = System.Windows.Controls.UserControl;

namespace SoulSplitter.UI.Generic
{
    /// <summary>
    /// Interaction logic for HotkeyPicker.xaml
    /// </summary>
    public partial class HotkeyPicker : UserControl
    {
        public HotkeyPicker()
        {
            InitializeComponent();
        }

        public class HotkeyCompletedParameter
        {
            public object Sender;
            public ModifierKeys ModifierKeys;
            public Key Key;
        }

        public RelayCommand HotkeyCompletedCommand { get; set; }

        private bool _isActive = false;
        private ModifierKeys _modifierKeys = ModifierKeys.None;
        private Key _key = Key.None;
        private void OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (_isActive)
            {
                if (e.IsDown && sender is TextBox textBox)
                {
                    //Get modifier key and remember state
                    if (_modifierKeysLookup.TryGetValue(e.Key, out ModifierKeys modifierKeys))
                    {
                        if (!_modifierKeys.HasFlag(modifierKeys))
                        {
                            if (!string.IsNullOrWhiteSpace(textBox.Text))
                            {
                                textBox.Text += " + ";
                            }

                            textBox.Text += modifierKeys;
                            _modifierKeys |= modifierKeys;
                        }
                    }
                    else //get regular key, end listening for keypresses, invoke command
                    {
                        if (!string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            textBox.Text += " + ";
                        }

                        textBox.Text += e.Key;
                        _key = e.Key;

                        HotkeyCompletedCommand?.Execute(new HotkeyCompletedParameter
                        {
                            Sender = this,
                            Key = _key,
                            ModifierKeys = _modifierKeys
                        });
                        _isActive = false;
                    }

                    var converter = new ModifierKeysConverter();
                    e.Handled = true;
                }
            }
        }

        private void OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!_isActive && sender is TextBox textBox)
            {
                _isActive = true;
                _key = Key.None;
                _modifierKeys = ModifierKeys.None;
                textBox.Text = "";
            }
        }

        private static Dictionary<Key, ModifierKeys> _modifierKeysLookup = new Dictionary<Key, ModifierKeys>()
        {
            { Key.LeftAlt, ModifierKeys.Alt },
            { Key.RightAlt, ModifierKeys.Alt },
            { Key.System, ModifierKeys.Alt },
            { Key.LeftCtrl, ModifierKeys.Control },
            { Key.RightCtrl, ModifierKeys.Control },
            { Key.LeftShift, ModifierKeys.Shift },
            { Key.RightShift, ModifierKeys.Shift },
            { Key.LWin, ModifierKeys.Windows },
            { Key.RWin, ModifierKeys.Windows },
        };

        private void OnPreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (_isActive && sender is TextBox textBox)
            {
                _isActive = false;
                _key = Key.None;
                _modifierKeys = ModifierKeys.None;
                textBox.Text = "";
            }
        }
    }
}
