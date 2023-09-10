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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using SoulSplitter.soulmemory_rs;

namespace SoulSplitter.ViewModels.EventFlagLogger
{
    public class EventFlagLoggerViewModel : INotifyPropertyChanged
    {
        private readonly ISoulMemoryWebClient _webClient;
        public EventFlagLoggerViewModel(ISoulMemoryWebClient soulMemoryWebClient = null)
        {
            _webClient = soulMemoryWebClient ?? new SoulMemoryWebClient();

            
        }

        public void UpdateEvents()
        {
        
            var result = _webClient.GetEventFlags();
            if (result.IsOk)
            {
                var flags = result.Unwrap();
                flags.ForEach(i => EventFlags.Add(new EventFlagViewModel(i.Item1, i.Item2, i.Item3)));
            }
        }


        public ObservableCollection<EventFlagViewModel> EventFlags { get; set; } = new ObservableCollection<EventFlagViewModel>();


        #region INotifyPropertyChanged ============================================================================================================================================
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion
    }
}
