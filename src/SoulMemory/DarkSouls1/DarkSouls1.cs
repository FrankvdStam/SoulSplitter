using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Native;

namespace SoulMemory.DarkSouls1
{
    public class DarkSouls1 : IDarkSouls1
    {
        private IDarkSouls1 _darkSouls1;

        public int GetAttribute(Attribute attribute) => _darkSouls1?.GetAttribute(attribute) ?? 0;
        public bool ReadEventFlag(uint eventFlagId) => _darkSouls1?.ReadEventFlag(eventFlagId) ?? false;
        public bool IsWarping() => _darkSouls1?.IsWarping() ?? false;
        public bool IsLoaded() => _darkSouls1?.IsLoaded() ?? false;
        public bool IsPlayerLoaded() => _darkSouls1?.IsPlayerLoaded() ?? false;
        public Vector3f GetPosition() => _darkSouls1?.GetPosition() ?? new Vector3f(0,0,0);

        public int GetInGameTimeMillis() => _darkSouls1?.GetInGameTimeMillis() ?? 0;
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
                        //_darkSouls1 = new Remastered();
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
    }
}
