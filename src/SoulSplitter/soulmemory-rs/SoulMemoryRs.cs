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

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using SoulMemory.soulmods;
using SoulMemory.Native;

namespace SoulSplitter.soulmemory_rs;

public static class SoulMemoryRs
{
    public static void Launch()
    {
        var games = new List<string>()
        {
            "darksouls",
            "darksoulsremastered",
            "darksoulsii",
            "darksoulsiii",
            "sekiro",
            "eldenring",
            "armoredcore6",
            "shadps4",
            "nightreign",
        };

        var process = Process.GetProcesses().FirstOrDefault(p => games.Contains(p.ProcessName.ToLower()));
        if (process == null)
        {
            return;
        }

        var x64 = process.Is64Bit().Unwrap();
        var basePath = Path.GetDirectoryName(typeof(Soulmods).Assembly.Location)!;
        var launcherPath = Path.Combine(basePath, $"{(x64 ? "launcher_x64.exe" : "launcher_x86.exe")}");
        var dllPath = Path.Combine(basePath, $"{(x64 ? "soulmemory_rs_x64.dll" : "soulmemory_rs_x86.dll")}");
        var args = $"--processname={process.ProcessName} --dllpath=\"{dllPath}\"";

        Process.Start(launcherPath, args);
    }
}
