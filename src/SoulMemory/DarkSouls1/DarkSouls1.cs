using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SoulMemory.DarkSouls1
{
    public class DarkSouls1 : IDarkSouls1
    {
        private IDarkSouls1 _darkSouls1;

        public int GetAttribute(Attribute attribute) => _darkSouls1?.GetAttribute(attribute) ?? 0;
        public bool ReadEventFlag(uint eventFlagId) => _darkSouls1?.ReadEventFlag(eventFlagId) ?? false;
        public bool IsWarpRequested() => _darkSouls1?.IsWarpRequested() ?? false;
        public bool IsPlayerLoaded() => _darkSouls1?.IsPlayerLoaded() ?? false;
        public Vector3f GetPosition() => _darkSouls1?.GetPosition() ?? new Vector3f(0,0,0);
        public int GetInGameTimeMilliseconds() => _darkSouls1?.GetInGameTimeMilliseconds() ?? 0;
        public int NgCount() => _darkSouls1?.NgCount() ?? 0;
        public int GetCurrentSaveSlot() => _darkSouls1?.GetCurrentSaveSlot() ?? -1;
        public void ResetInventoryIndices() => _darkSouls1?.ResetInventoryIndices();
        public List<Item> GetInventory() => _darkSouls1?.GetInventory() ?? new List<Item>();
        public BonfireState GetBonfireState(Bonfire bonfire) => _darkSouls1?.GetBonfireState(bonfire) ?? BonfireState.Unknown;
        public string GetSaveFileLocation() => _darkSouls1?.GetSaveFileLocation();
        public bool IsPtde() => _darkSouls1 is Ptde;
        public int GetSaveFileGameTimeMilliseconds(string path, int slot, bool isPtde)
        { 
            return Sl2Reader.GetSaveFileIgt(path, slot, isPtde) ?? 0;
        }        

        public bool Refresh(out Exception exception)
        {
            exception = null;
            try
            {
                if (_darkSouls1 == null)
                {
                    var process = Process.GetProcesses().FirstOrDefault(i => (i.ProcessName.ToLower() == "darksouls" || i.ProcessName.ToLower() == "darksoulsremastered") && !i.HasExited && i.MainModule != null);
                    if (process == null)
                    {
                        exception = new Exception("DarkSouls not running");
                        return false;
                    }

                    if (process.ProcessName.ToLower() == "darksouls")
                    {
                        _darkSouls1 = new Ptde();
                    }
                    else
                    {
                        _darkSouls1 = new Remastered();
                    }
                    return true;
                }
                else
                {
                    if (!_darkSouls1.Refresh(out exception))
                    {
                        _darkSouls1 = null;
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }


#if DEBUG
        public object GetTestValue() => _darkSouls1?.GetTestValue();
#endif
    }
}
