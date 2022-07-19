using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using SoulMemory.DarkSouls2;

namespace SoulSplitter.Splits.DarkSouls2
{
    [XmlType(Namespace = "DarkSouls2")]
    public class BossKill : INotifyPropertyChanged
    {
        [XmlElement(Namespace = "DarkSouls2")]
        public BossType BossType
        {
            get => _bossType;
            set => SetField(ref _bossType, value);
        }
        private BossType _bossType;

        public int Count
        {
            get => _count;
            set => SetField(ref _count, value);
        }
        private int _count = 1;

        public override string ToString()
        {
            return $"{BossType} {Count}";
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
