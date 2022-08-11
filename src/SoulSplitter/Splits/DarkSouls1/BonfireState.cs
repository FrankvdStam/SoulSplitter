using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SoulMemory.DarkSouls1;
using SoulMemory.Memory;

namespace SoulSplitter.Splits.DarkSouls1
{
    [XmlType(Namespace = "DarkSouls1")]
    public class BonfireState : INotifyPropertyChanged
    {
        public Bonfire? Bonfire
        {
            get => _bonfire;
            set => SetField(ref _bonfire, value);
        }
        private Bonfire? _bonfire;

        public SoulMemory.DarkSouls1.BonfireState State
        {
            get => _state;
            set => SetField(ref _state, value);
        }
        private SoulMemory.DarkSouls1.BonfireState _state;

        public override string ToString()
        {
            return $"{Bonfire.GetDisplayName()} {State.GetDisplayName()}";
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
