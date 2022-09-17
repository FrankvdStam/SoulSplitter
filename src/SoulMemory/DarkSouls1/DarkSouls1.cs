// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

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
        public bool AreCreditsRolling() => _darkSouls1?.AreCreditsRolling() ?? false;
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
