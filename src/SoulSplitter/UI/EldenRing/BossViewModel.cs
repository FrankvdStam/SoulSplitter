using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.EldenRing;
using SoulMemory.Memory;

namespace SoulSplitter.UI.EldenRing
{
    public class BossViewModel
    {
        public BossViewModel(Boss b)
        {
            Area = b.GetDisplayDescription();
            Name = b.GetDisplayName();
            Flag = (uint)b;
            Boss = b;
        }

        public override string ToString()
        {
            return Name;
        }

        public Boss Boss
        {
            get => _boss;
            set => SetField(ref _boss, value);
        }
        private Boss _boss;

        public string Area
        {
            get => _area;
            set => SetField(ref _area, value);
        }
        private string _area;

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }
        private string _name;

        public uint Flag
        {
            get => _flag;
            set => SetField(ref _flag, value);
        }
        private uint _flag;



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
