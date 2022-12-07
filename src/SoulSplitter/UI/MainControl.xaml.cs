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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using SoulMemory.Memory;

namespace SoulSplitter.UI
{
    /// <summary>
    /// Interaction logic for MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }
      
        public MainViewModel MainViewModel
        {
            get => (MainViewModel)DataContext;
            set => ((MainViewModel)DataContext).Update(value);
        }
        
        private void Troubleshooting_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/FrankvdStam/SoulSplitter/wiki/troubleshooting");
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void EventFlagLogger_OnClick(object sender, RoutedEventArgs e)
        {
            var games = new List<string>()
            {
                "darksoulsremastered",
                "darksoulsii",
                "darksoulsiii",
                "sekiro",
                "eldenring",
            };

            var process = Process.GetProcesses().FirstOrDefault(p => games.Contains(p.ProcessName.ToLower()));
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetAssembly(typeof(MainControl)).Location) + @"\soulinjectee.dll";

            if (process != null && File.Exists(path))
            {
                process.InjectDll(path);
            }
        }

        private void OpenSeparateWindow_OnClick(object sender, RoutedEventArgs e)
        {

        }

        public static (System.Windows.Forms.Integration.ElementHost, MainControl) GetElementHostMainControl()
        {
            var mainControl = new MainControl();
            var elementHost = new System.Windows.Forms.Integration.ElementHost();
            elementHost.Child = mainControl;
            elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            return (elementHost, mainControl);
        }

        public static (System.Windows.Forms.Form, System.Windows.Forms.Integration.ElementHost, MainControl) GetTestForm()
        {
            var form = new System.Windows.Forms.Form();
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(504, 562);
            form.MaximumSize = new System.Drawing.Size(520, 10000);
            form.MinimumSize = new System.Drawing.Size(520, 600);
            form.AcceptButton = new System.Windows.Forms.Button() { Text = "Ok", Size = new System.Drawing.Size(75, 23) };

            var (elementHost, mainControl) = GetElementHostMainControl();
            form.Controls.Add(elementHost);

            return (form, elementHost, mainControl);
        }
    }
}
