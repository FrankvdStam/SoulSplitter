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


using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System.Diagnostics;
using System.IO;

namespace SoulSplitter.Build
{
    /// <summary>
    /// Replaces the first line of text starting with "version" in a given file with the given version
    /// </summary>
    public class ReplaceTomlVersion : Task
    {
        [Required] 
        public string TomlPath { get; set; } = null!;

        [Required]
        public string Version { get; set; } = null!;

        public override bool Execute()
        {
            //Utils.Debug();

            var workingDirectory = Directory.GetCurrentDirectory();
            var tomlPath = Path.Combine(workingDirectory, TomlPath);
            var lines = File.ReadAllLines(tomlPath);

            var result = false;
            for(var i = 0; i < lines.Length; i++)
            {
                if (lines[i].ToLowerInvariant().StartsWith("version"))
                {
                    lines[i] = $"version = \"{Version}\"";
                    Log.LogMessage($"Replaced version on line {i}");
                    File.WriteAllLines(tomlPath, lines);
                    result = true;
                    break;
                }
            }

            if (!result)
            {
                Log.LogError("Failed to find version");
                return false;
            }

            return true;
        }
    }
}
