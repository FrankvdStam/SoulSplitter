using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls1
{
    internal interface IDarkSouls1
    {
        bool Refresh(out Exception exception);
        bool ReadEventFlag(uint eventFlagId);
        int GetAttribute(Attribute attribute);
        bool IsWarpRequested();
        bool IsPlayerLoaded();
        int GetInGameTimeMilliseconds();
        int NgCount();
        int GetCurrentSaveSlot();
        Vector3f GetPosition();
        void ResetInventoryIndices();
        List<Item> GetInventory();
        BonfireState GetBonfireState(Bonfire bonfire);
        string GetSaveFileLocation();

#if DEBUG
        object GetTestValue();
#endif
    }
}
