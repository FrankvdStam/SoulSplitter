using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSplitter.Splits.DarkSouls1
{
    public interface ISplit : INotifyPropertyChanged
    {
        SplitType SplitType { get; }
    }
}
