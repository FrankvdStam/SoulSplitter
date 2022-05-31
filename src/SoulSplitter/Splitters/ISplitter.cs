using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;

namespace SoulSplitter.Splitters
{
    internal interface ISplitter
    {
        void Update(object settings);
        Exception Exception { get; set; }
    }
}
