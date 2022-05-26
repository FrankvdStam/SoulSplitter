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
    public class PositionViewModel : INotifyPropertyChanged
    {
        public PositionViewModel()
        {
        }
        
        public Position Position = new Position();


        public byte Area
        {
            get => Position.Area;
            set => SetField(ref Position.Area, value);
        }

        public byte Block
        {
            get => Position.Block;
            set => SetField(ref Position.Block, value);
        }

        public byte Region
        {
            get => Position.Region;
            set => SetField(ref Position.Region, value);
        }

        public byte Size
        {
            get => Position.Size;
            set => SetField(ref Position.Size, value);
        }


        public float X
        {
            get => Position.X;
            set => SetField(ref Position.X, value);
        }

        public float Y
        {
            get => Position.Y;
            set => SetField(ref Position.Y, value);
        }

        public float Z
        {
            get => Position.Z;
            set => SetField(ref Position.Z, value);
        }

        
        public override string ToString()
        {
            return Position.ToString();
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
