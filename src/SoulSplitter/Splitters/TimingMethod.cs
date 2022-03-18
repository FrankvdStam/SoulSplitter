using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSplitter.Splitters
{
    public enum TimingMethod
    {
        [Display(Name = "None")]
        None,

        [Display(Name = "In game time")]
        Igt,

        [Display(Name = "RTA with load removal")]
        RtaWithLoadRemoval,
    }
}
