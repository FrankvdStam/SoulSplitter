using System.ComponentModel.DataAnnotations;

namespace SoulSplitter
{
    public enum TimingType
    {
        [Display(Name = "immediate")]
        Immediate,
        
        [Display(Name = "on loading")]
        OnLoading,
    }
}
