using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SoulSplitter.Splits;
using SoulSplitter.Splits.DarkSouls2;

namespace SoulSplitter.UI.ViewModel
{
    public class EldenRingViewModel : INotifyPropertyChanged
    {
        public static ObservableCollection<TimingMethod> TimingMethods { get; set; } = new ObservableCollection<TimingMethod>(Enum.GetValues(typeof(TimingMethod)).Cast<TimingMethod>());


        private bool _startAutomatically = true;
        public bool StartAutomatically
        {
            get => _startAutomatically;
            set
            {
                _startAutomatically = value;
                OnPropertyChanged();
            }
        }


        private TimingMethod _timingMethod = TimingMethod.RtaWithLoadRemoval;
        public TimingMethod TimingMethod
        {
            get => _timingMethod;
            set
            {
                _timingMethod = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
