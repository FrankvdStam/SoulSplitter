using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SoulMemory;

namespace SoulSplitter.Splits.DarkSouls1
{
    [XmlType(Namespace = "DarkSouls1")]
    public class PositionSplit : INotifyPropertyChanged
    {
        public Vector3f Position
        {
            get => _position;
            set => SetField(ref _position, value);
        }
        private Vector3f _position;

        public float Size
        {
            get => _size;
            set => SetField(ref _size, value);
        }
        private float _size;

        public override string ToString()
        {
            return $"{Position}, size: {Size}";
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
