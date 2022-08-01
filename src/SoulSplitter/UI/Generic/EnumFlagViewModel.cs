using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;

namespace SoulSplitter.UI.Generic
{
    public class EnumFlagViewModel<T> : INotifyPropertyChanged where T : Enum
    {
        public EnumFlagViewModel(T tEnum)
        {
            Value = tEnum;
            Name = Value.GetDisplayName();
            Area = Value.GetDisplayDescription();
            Flag = Convert.ToUInt32(Value);
        }
        
        public T Value
        {
            get => _value;
            set => SetField(ref _value, value);
        }
        private T _value;

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

        /// <summary>
        /// Used to compare items in the filtered combobox
        /// </summary>
        public override string ToString()
        {
            return Name;
        }

        #region INotifyPropertyChanged
        private bool SetField<U>(ref U field, U value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<U>.Default.Equals(field, value)) return false;
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
