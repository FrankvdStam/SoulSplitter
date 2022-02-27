using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSplitter.Splits.DarkSouls1
{
    public enum TimingType
    {
        [Display(Name = "immediate")]
        Immediate,

        [Display(Name = "on load")]
        OnLoad,
    }
}
