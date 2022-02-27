using SoulMemory.DarkSouls1;
using SoulMemory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SoulSplitter.Splits.DarkSouls2
{
    public class BoxSplit : ISplit
    { 
        public BoxSplit(){}

        public SplitType SplitType => SplitType.Box;
        

        public float LowerX
        {
            get => _lowerX;
            set
            {
                _lowerX = value;
                OnPropertyChanged();
            }
        }
        private float _lowerX = 0.0f;
        public float LowerY
        {
            get => _lowerY;
            set
            {
                _lowerY = value;
                OnPropertyChanged();
            }
        }
        private float _lowerY = 0.0f;
        public float LowerZ
        {
            get => _lowerZ;
            set
            {
                _lowerZ = value;
                OnPropertyChanged();
            }
        }
        private float _lowerZ = 0.0f;

        public float UpperX
        {
            get => _upperX;
            set
            {
                _upperX = value;
                OnPropertyChanged();
            }
        }
        private float _upperX = 0.0f;
        public float UpperY
        {
            get => _upperY;
            set
            {
                _upperY = value;
                OnPropertyChanged();
            }
        }
        private float _upperY = 0.0f;
        public float UpperZ
        {
            get => _upperZ;
            set
            {
                _upperZ = value;
                OnPropertyChanged();
            }
        }
        private float _upperZ = 0.0f;

        

        private TimingType _timingType = TimingType.Immediate;
        public TimingType TimingType
        {
            get => _timingType;
            set
            {
                _timingType = value;
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
