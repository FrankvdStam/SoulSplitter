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
        public bool UseInGameTime
        {
            get => _useInGameTime;
            set
            {
                _useInGameTime = value;
                OnPropertyChanged();
            }
        }

        private bool _useInGameTime = true;



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
