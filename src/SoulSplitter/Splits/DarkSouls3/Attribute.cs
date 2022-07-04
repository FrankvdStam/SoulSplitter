using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoulSplitter.Splits.DarkSouls3
{
    [XmlType(Namespace = "DarkSouls3")]
    public class Attribute : INotifyPropertyChanged
    {
        [XmlElement(Namespace = "DarkSouls3")]
        public SoulMemory.DarkSouls3.Attribute AttributeType
        {
            get => _attributeType;
            set => SetField(ref _attributeType, value);
        }
        private SoulMemory.DarkSouls3.Attribute _attributeType;

        public int Level
        {
            get => _level;
            set => SetField(ref _level, value);
        }
        private int _level;

        public override string ToString()
        {
            return $"{AttributeType} {Level}";
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
