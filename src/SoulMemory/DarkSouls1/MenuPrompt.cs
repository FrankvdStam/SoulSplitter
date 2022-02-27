using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls1
{
    public enum MenuPrompt
    {
        Unknown = -1,

        None = 0,
        GameWillStartInOfflineMode = 69,
        HomewardBone = 86,
        DarkSign = 87,
        FireKeeperSoul0 = 176,//I bet each fire keeper soul has it's own ID
        BonfireWarp = 80,
        Covenant = 121,
    }
}
