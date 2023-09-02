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

extern alias SystemDrawing;
using SystemDrawing::System.Drawing;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using SoulSplitter.Native;
using winforms = System.Windows.Forms;

namespace SoulSplitter.UI
{
    /// <summary>
    /// Interaction logic for MainControl.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Icon. = IconHelper.SoulSplitterIcon;
            Closing += Window_Closing;
        }

        public bool WindowShouldHide = true;
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Hide();
            e.Cancel = WindowShouldHide;
        }
        

        public MainViewModel MainViewModel
        {
            get => (MainViewModel)DataContext;
            set => ((MainViewModel)DataContext).Update(value);
        }
        
        private Color _stash = Color.White;
        public void BitBlt()
        {
            try
            {
                var form = winforms.Application.OpenForms[0];
                using (var graphics = form.CreateGraphics())
                {
                    var hdc = graphics.GetHdc();
                    var color = Gdi32.BitBlt(hdc, 0, 0);
                    if (color != _stash)
                    {
                        graphics.ReleaseHdc();
                        Debug.WriteLine(color);
                        color = Color.FromArgb(color.ToArgb() ^ 0xffffff);
                        _stash = color;
                        graphics.DrawRectangle(new Pen(color), 0, 0, 1, 1);
                    }
                }
            }
            catch
            {
                //Ignored
            }
        }

        public void ResetBitBlt()
        {
            try
            {
                _stash = Color.White;
                var form = winforms.Application.OpenForms[0];
                form.Invalidate();
            }
            catch
            {
                //Ignored
            }
        }
    }
}
