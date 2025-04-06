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

using SoulMemory.Games.DarkSouls1.Parameters;
using SoulMemory.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SoulMemory.Games.DarkSouls1;

public class DarkSouls1 : IDarkSouls1
{
    private IDarkSouls1? _darkSouls1;
    public Process? GetProcess() => _darkSouls1?.GetProcess();
    public int GetAttribute(Attribute attribute) => _darkSouls1?.GetAttribute(attribute) ?? 0;
    public bool ReadEventFlag(uint eventFlagId) => _darkSouls1?.ReadEventFlag(eventFlagId) ?? false;
    public bool IsWarpRequested() => _darkSouls1?.IsWarpRequested() ?? false;
    public bool IsPlayerLoaded() => _darkSouls1?.IsPlayerLoaded() ?? false;
    public Vector3f GetPlayerPosition() => _darkSouls1?.GetPlayerPosition() ?? new Vector3f(0,0,0);
    public int ReadInGameTimeMilliseconds() => _darkSouls1?.ReadInGameTimeMilliseconds() ?? 0;
    public void WriteInGameTimeMilliseconds(int milliseconds) => _darkSouls1?.WriteInGameTimeMilliseconds(milliseconds);
    public int NgCount() => _darkSouls1?.NgCount() ?? 0;
    public int GetCurrentSaveSlot() => _darkSouls1?.GetCurrentSaveSlot() ?? -1;
    public void ResetInventoryIndices() => _darkSouls1?.ResetInventoryIndices();
    public List<Item> GetInventory() => _darkSouls1?.GetInventory() ?? [];
    public bool AreCreditsRolling() => _darkSouls1?.AreCreditsRolling() ?? false;
    public BonfireState GetBonfireState(Bonfire bonfire) => _darkSouls1?.GetBonfireState(bonfire) ?? BonfireState.Unknown;
    public string? GetSaveFileLocation() => _darkSouls1?.GetSaveFileLocation();
    public int GetSaveFileGameTimeMilliseconds(string path, int slot) => _darkSouls1?.GetSaveFileGameTimeMilliseconds(path, slot) ?? 0;
    public void WriteWeaponDescription(uint weaponId, string description) => _darkSouls1?.WriteWeaponDescription(weaponId, description);
    public void WriteItemLotParam(int rowId, Action<ItemLotParam> accessor) => _darkSouls1?.WriteItemLotParam(rowId, accessor);
    public void SetLoadingScreenItem(int index, uint item) => _darkSouls1?.SetLoadingScreenItem(index, item);


    public TreeBuilder GetTreeBuilder() => _darkSouls1?.GetTreeBuilder() ?? null!;

    public ResultErr<RefreshError> TryRefresh()
    {
        try
        {
            if (_darkSouls1 == null)
            {
                var process = Process.GetProcesses().FirstOrDefault(i => (i.ProcessName.ToLower() == "darksouls" || i.ProcessName.ToLower() == "darksoulsremastered") && !i.HasExited);
                if (process == null)
                {
                    return Result.Err(new RefreshError(RefreshErrorReason.ProcessNotRunning, "Dark Souls 1/Dark Souls Remastered not running."));
                }

                if (process.ProcessName.ToLower() == "darksouls")
                {
                    _darkSouls1 = new Ptde();
                }
                else
                {
                    _darkSouls1 = new Remastered();
                }

                Thread.Sleep(4000); //let the game boot
                return _darkSouls1.TryRefresh();
            }

            var result = _darkSouls1.TryRefresh();
            if (result.IsOk)
            {
                return Result.Ok();
            }
            _darkSouls1 = null;
            return result;
        }
        catch (Exception e)
        {
            return RefreshError.FromException(e);
        }
    }


#if DEBUG
    public object GetTestValue() => _darkSouls1?.GetTestValue()!;
#endif
}
