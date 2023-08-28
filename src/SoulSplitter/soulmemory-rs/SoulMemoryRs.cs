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

using LiveSplit.ComponentUtil;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SoulSplitter.soulmemory_rs
{
    internal static class SoulMemoryRs
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
            };

            var process = Process.GetProcesses().FirstOrDefault(p => games.Contains(p.ProcessName.ToLower()));
            if(process == null)
            {
                return;
            }

            var basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "soulsplitter");

            OverwriteFile("SoulSplitter.soulmemory_rs.x64.launcher.exe"     , Path.Combine(basePath, @"x64\launcher.exe"));
            OverwriteFile("SoulSplitter.soulmemory_rs.x64.soulmemory_rs.dll", Path.Combine(basePath, @"x64\soulmemory_rs.dll"));
            OverwriteFile("SoulSplitter.soulmemory_rs.x86.launcher.exe"     , Path.Combine(basePath, @"x86\launcher.exe"));
            OverwriteFile("SoulSplitter.soulmemory_rs.x86.soulmemory_rs.dll", Path.Combine(basePath, @"x86\soulmemory_rs.dll"));

            Process.Start(process.Is64Bit()
                ? Path.Combine(basePath, @"x64\launcher.exe")
                : Path.Combine(basePath, @"x86\launcher.exe"));
        }

        private static void OverwriteFile(string manifestResourceName, string path)
        {
            byte[] buffer;
            using(var stream = typeof(SoulMemoryRs).Assembly.GetManifestResourceStream(manifestResourceName))
            {
                buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
            }
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllBytes(path, buffer);
        }
    }
}
