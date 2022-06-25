using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls2
{
    public interface IDarkSouls2
    {
        bool Refresh(out Exception exception);
        Vector3f GetPosition();
        bool IsLoading();
        bool ReadEventFlag(uint eventFlagId);

    }
}
