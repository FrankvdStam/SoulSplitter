using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoulSplitter.Splits.DarkSouls2
{
    public interface ISplit : INotifyPropertyChanged
    {
        SplitType SplitType { get; }
    }
}
