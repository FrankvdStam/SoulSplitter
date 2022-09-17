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

using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace SoulSplitter.UI
{
    public partial class MainControlFormsWrapper : UserControl
    {
        public MainControlFormsWrapper()
        {
            _mainControl = new MainControl();
            Width = (int)_mainControl.Width + 15;
            Height = (int)_mainControl.Height + 15;

            AutoScaleMode = AutoScaleMode.Font; //Fix scaling issues (100%, 150%, etc, in windows display settings)

            SuspendLayout();
            _elementHost = new ElementHost();
            _elementHost.Location = new System.Drawing.Point(0, 0);
            _elementHost.Name = "ElementHost";
            _elementHost.Size = new System.Drawing.Size((int)_mainControl.Width, (int)_mainControl.Height);
            _elementHost.TabIndex = 0;
            _elementHost.Text = "ElementHost";
            _elementHost.Child = _mainControl;
            Controls.Add(_elementHost);

            ResumeLayout(false);
        }

        public MainViewModel MainViewModel
        {
            get => _mainControl.MainViewModel;
            set => _mainControl.MainViewModel = value;
        }
        
        private ElementHost _elementHost;
        private UI.MainControl _mainControl;
    }
}
