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

using System.Security.Cryptography;
using System.Collections.Generic;
using System.IO;

namespace SoulMemory.Memory;

public static class BitBlt
{
    public static bool GetBitBlt(this IGame game, List<string> files, List<string> bitBlt)
    {
        var process = game.GetProcess();
        var path = Path.GetDirectoryName(process?.MainModule?.FileName);
        using var md5 = MD5.Create();
        foreach (var d in files)
        {
            using var fs = File.OpenRead($"{path}\\{d}");
            var hex = md5.ComputeHash(fs).ToHexString();
            if (!bitBlt.Contains(hex))
            {
                return true;
            }
        }
        
        return false;
    }
}
