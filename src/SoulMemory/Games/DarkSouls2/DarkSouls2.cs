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
using System.Diagnostics;
using System.Linq;
using SoulMemory.Abstractions.Games;
using SoulMemory.Memory;
using SoulMemory.Native;

namespace SoulMemory.Games.DarkSouls2;

public class DarkSouls2 : IDarkSouls2
{
    public int ReadInGameTimeMilliseconds() => 0;

    public void WriteInGameTimeMilliseconds(int milliseconds)
    {
    }

    private IDarkSouls2? _darkSouls2;
    public Process? GetProcess() => _darkSouls2?.GetProcess();
    public Vector3f GetPlayerPosition() => _darkSouls2?.GetPlayerPosition() ?? new Vector3f();
    public bool IsLoading() => _darkSouls2?.IsLoading() ?? false;
    public bool ReadEventFlag(uint eventFlagId) => _darkSouls2?.ReadEventFlag(eventFlagId) ?? false;
    public int GetBossKillCount(Boss bossType) => _darkSouls2?.GetBossKillCount(bossType) ?? 0;
    public int ReadAttribute(Enum attribute) => _darkSouls2?.ReadAttribute(attribute) ?? 0;
    public TreeBuilder GetTreeBuilder() => _darkSouls2?.GetTreeBuilder() ?? null!;

    public ResultErr<RefreshError> TryRefresh()
    {
        try
        {
            if (_darkSouls2 == null)
            {
                var process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower() == "darksoulsii" && i is { HasExited: false, MainModule: not null });
                if (process == null)
                {
                    return Result.Err(new RefreshError(RefreshErrorReason.ProcessNotRunning, "Dark Souls 2 vanilla/scholar not running."));
                }

                var isScholar = process.Is64Bit().Unwrap();
                
                if (isScholar)
                {
                    _darkSouls2 = new Scholar();
                }
                else
                {
                    _darkSouls2 = new Vanilla();
                }
                return Result.Ok();
            }
            else
            {
                var result = _darkSouls2.TryRefresh();
                if (result.IsErr)
                {
                    _darkSouls2 = null!;
                    return result;
                }
                return Result.Ok();
            }
        }
        catch (Exception e)
        {
            return RefreshError.FromException(e);
        }
    }
}
