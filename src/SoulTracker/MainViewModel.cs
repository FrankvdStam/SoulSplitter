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
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows.Threading;
using SoulMemory.EldenRing;

namespace SoulTracker
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            _eldenRing = new EldenRing(false);//Do not apply MIGT fix
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += (o, e) => Update();
            _timer.Start();
        }


        private readonly DispatcherTimer _timer;
        private readonly EldenRing _eldenRing;

        private readonly List<uint> _bossFlags = Enum.GetValues(typeof(Boss)).Cast<uint>().ToList();
        private void Update()
        {
            _eldenRing.Refresh();
            
            if (_eldenRing.Exception != null)
            {
                Text = _eldenRing.Exception.Message;
                return;
            }

            if (!_eldenRing.Attached)
            {
                Text = "Game not running";
                return;
            }

            try
            {
                //var bad = new List<uint>();
                var count = 0;
                foreach (var flag in _bossFlags)
                {
                    if (_eldenRing.ReadEventFlag(flag))
                    {
                        count++;
                    }
                    //else
                    //{
                    //    bad.Add(flag);
                    //    
                    //}
                }

                //foreach (var f in bad)
                //{
                //    Debug.WriteLine(f);
                //}

                Text = count.ToString();
            }
            catch (Exception e)
            {
                Text = e.Message;
            }
        }


        public string Text
        {
            get => _text;
            set => SetField(ref _text, value);
        }
        private string _text = "";

        public Color BackgroundColor
        {
            get => _backgroundColor;
            set => SetField(ref _backgroundColor, value);
        }
        private Color _backgroundColor = Color.FromRgb(4, 244, 4);

        public Color ForegroundColor
        {
            get => _foregroundColor;
            set => SetField(ref _foregroundColor, value);
        }
        private Color _foregroundColor = Colors.White;

        public int TextSize
        {
            get => _textSize;
            set => SetField(ref _textSize, value);
        }
        private int _textSize = 300;



        #region INotifyPropertyChanged
        private bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion
    }
}
