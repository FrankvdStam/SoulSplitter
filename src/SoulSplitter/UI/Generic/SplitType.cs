using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulSplitter.UI.Generic
{
    public enum SplitType
    {
        [Display(Name = "Bonfire")]
        Bonfire,

        [Display(Name = "Boss")]
        Boss,

        [Display(Name = "Position")]
        Position,

        [Display(Name = "Attribute")]
        Attribute,

        [Display(Name = "Flag")]
        Flag,

        [Display(Name = "Item")]
        Item,
    }
}
