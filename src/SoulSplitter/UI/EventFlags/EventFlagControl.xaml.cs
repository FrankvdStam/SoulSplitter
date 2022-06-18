using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using SoulMemory;
using SoulMemory.Memory;

namespace SoulSplitter.UI.EventFlags
{
    /// <summary>
    /// Interaction logic for DarkSouls3Control.xaml
    /// </summary>
    public partial class EventFlagControl : UserControl, INotifyPropertyChanged
    {
        public EventFlagControl()
        {
            InitializeComponent();
            DataContext = this; 
            _updateTimer = new DispatcherTimer(TimeSpan.FromSeconds(3), DispatcherPriority.Normal, OnUpdateTimerTick, Dispatcher);
        }
        
        private SoulInjecteeClient _soulInjecteeClient = new SoulInjecteeClient();
        private DispatcherTimer _updateTimer;


        #region Properties
        
        public bool Connected
        {
            get => _connected;
            set => SetField(ref _connected, value);
        }
        private bool _connected = false;
        
        public EventFlagLogMode LogMode
        {
            get => _LogMode;
            set => SetField(ref _LogMode, value);
        }
        private EventFlagLogMode _LogMode = EventFlagLogMode.Unique;
        
        public ObservableCollection<uint> EventFlags { get; set; } = new ObservableCollection<uint>();
        
        public uint EventFlag
        {
            get => _eventFlag;
            set => SetField(ref _eventFlag, value);
        }
        private uint _eventFlag;

        #endregion


        public async void OnUpdateTimerTick(object sender, EventArgs args)
        {
            if (!_soulInjecteeClient.IsConnected)
            {
                await Task.Run(() => _soulInjecteeClient.TryConnect());
            }
            Connected = _soulInjecteeClient.IsConnected;
        }




        
        private void Enable_OnClick(object sender, RoutedEventArgs e)
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
            if (process != null)
            {
                process.InjectDll(@"C:\projects\Dark souls\SoulSplitter\target\x86_64-pc-windows-msvc\debug\soulinjectee.dll");
            }
        }

        private void Disable_OnClick(object sender, RoutedEventArgs e)
        {
            if (Connected)
            {
                _soulInjecteeClient.Unload();
                Connected = _soulInjecteeClient.IsConnected;
            }
        }

        private void TextBoxRawFlag_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (uint.TryParse(textBox.Text, out uint result))
                {
                    return;
                }
                textBox.Text = string.Empty;
            }
        }

        private void AddFlag_OnClick(object sender, RoutedEventArgs e)
        {
            if (!EventFlags.Contains(EventFlag))
            {
                EventFlags.Add(EventFlag);
                UpdateFlags();
            }
        }

        private void RemoveFlag_OnClick(object sender, RoutedEventArgs e)
        {
            if (EventFlags.Contains(EventFlag))
            {
                EventFlags.Remove(EventFlag);
                UpdateFlags();
            }
        }

        private void UpdateFlags()
        {
            if (Connected)
            {
                _soulInjecteeClient.EventFlagSetExclusions(EventFlags.ToList());
            }
        }

        #region INotifyPropertyChanged

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? ""));
        }

        #endregion

        
    }
}
