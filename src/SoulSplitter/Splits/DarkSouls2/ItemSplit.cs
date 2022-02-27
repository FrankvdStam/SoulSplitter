using SoulMemory.DarkSouls1;
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
    public class ItemSplit : ISplit
    {
        public ItemSplit(){}


        public SplitType SplitType => SplitType.Item;
        





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
