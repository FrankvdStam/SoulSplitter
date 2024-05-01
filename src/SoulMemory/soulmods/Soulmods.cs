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
using System.IO;
using System.Linq;
using System.Text;
using SoulMemory.Native;

namespace SoulMemory.soulmods
{
    public static class Soulmods
    {
        public static void Inject(Process process)
        {
            var basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "soulsplitter");

            var dllPath64 = Path.Combine(basePath, @"x64\soulmods.dll");
            OverwriteFile("SoulMemory.soulmods.x64.soulmods.dll", dllPath64);

            if (process.Is64Bit())
            {
                process.InjectDll(dllPath64);
            }
        }

        private static void OverwriteFile(string manifestResourceName, string path)
        {
            byte[] buffer;
            using (var stream = typeof(Soulmods).Assembly.GetManifestResourceStream(manifestResourceName))
            {
                buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
            }
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllBytes(path, buffer);
        }
    }
}
