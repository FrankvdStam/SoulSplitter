using SoulMemory.DarkSouls2;
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
    public class BossSplit : ISplit
    {
        public BossSplit(){}

        public SplitType SplitType => SplitType.Boss;

        private BossType _bossType = BossType.TheLastGiant;
        public BossType BossType
        {
            get => _bossType;
            set
            {
                _bossType = value;
                OnPropertyChanged();
            }
        }

        private int _killCount = 1;
        public int KillCount
        {
            get => _killCount;
            set
            {
                _killCount = value;
                OnPropertyChanged();
            }
        }

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

        public override string ToString()
        {
            return $"{BossType} {TimingType}";
        }
    }
}
