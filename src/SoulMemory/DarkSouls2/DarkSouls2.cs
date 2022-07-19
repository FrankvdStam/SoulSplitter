using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.Memory;
using SoulMemory.Native;

namespace SoulMemory.DarkSouls2
{
    public class DarkSouls2 : IDarkSouls2
    {
        private IDarkSouls2 _darkSouls2;

        public Vector3f GetPosition() => _darkSouls2?.GetPosition() ?? new Vector3f();

        public bool IsLoading() => _darkSouls2?.IsLoading() ?? false;

        public bool ReadEventFlag(uint eventFlagId) => _darkSouls2?.ReadEventFlag(eventFlagId) ?? false;

        public int GetBossKillCount(BossType bossType) => _darkSouls2?.GetBossKillCount(bossType) ?? 0;

        public int GetAttribute(Attribute attribute) => _darkSouls2?.GetAttribute(attribute) ?? 0;

        public bool Refresh(out Exception exception)
        {
            exception = null;
            try
            {
                if (_darkSouls2 == null)
                {
                    var process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower() == "darksoulsii" && !i.HasExited && i.MainModule != null);
                    if (process == null)
                    {
                        exception = new Exception("DarkSoulsII not running");
                        return false;
                    }

                    Kernel32.IsWow64Process(process.Handle, out bool isWow64Result);
                    var isScholar = !isWow64Result;
                    
                    if (isScholar)
                    {
                        _darkSouls2 = new Scholar.DarkSouls2();
                    }
                    else
                    {
                        _darkSouls2 = new Vanilla.DarkSouls2();
                    }
                    return true;
                }
                else
                {
                    if (!_darkSouls2.Refresh(out exception))
                    {
                        _darkSouls2 = null;
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
