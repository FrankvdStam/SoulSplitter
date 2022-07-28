using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls1_Old
{
    public enum CheatType
    {
        PlayerNoDead = 0x0,
        PlayerExterminate = 0x1,
        AllNoStaminaConsume = 0x2,
        AllNoMpConsume = 0x3,
        AllNoArrowConsume = 0x4,
        AllNoMagicQtyConsume = 0x5,
        PlayerHide = 0x6,
        PlayerSilence = 0x7,
        AllNoDead = 0x8,
        AllNoDamage = 0x9,
        AllNoHit = 0xA,
        AllNoAttack = 0xB,
        AllNoMove = 0xC,
        AllNoUpdateAI = 0xD,
        PlayerReload = 0x12,
    }
}
