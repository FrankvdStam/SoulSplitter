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
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using SoulSplitter.ViewModels.EventFlagLogger;

namespace SoulSplitter.Views
{
    /// <summary>
    /// Interaction logic for EventFlagLoggerWindow.xaml
    /// </summary>
    public partial class EventFlagLoggerWindow : Window
    {

        private readonly DispatcherTimer _refreshTimer;

        public EventFlagLoggerWindow()
        {
            InitializeComponent();

            _refreshTimer = new DispatcherTimer();
            _refreshTimer.Tick += UpdateEvents;
            _refreshTimer.Interval = new TimeSpan(0, 0, 1);
            _refreshTimer.Start();
        }

        private async void UpdateEvents(object sender, EventArgs args)
        {
            await Task.Run(() =>
            {
                Dispatcher.Invoke(() =>
                {
                    if (DataContext is EventFlagLoggerViewModel vm)
                    {
                        vm.UpdateEvents();
                    }
                });
            });
        }
    }
}
