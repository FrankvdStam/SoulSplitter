using System.ComponentModel.DataAnnotations;

namespace SoulSplitter.UI.Generic
{
    public enum TimingType
    {
        [Display(Name = "immediate")]
        Immediate,
        
        [Display(Name = "on loading")]
        OnLoading,

        [Display(Name = "on blackscreen")]
        OnBlackscreen,

        [Display(Name = "on warp")]
        OnWarp,
    }
}
