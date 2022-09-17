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
using System.IO;
using System.Linq;
using SoulMemory.Shared;

namespace SoulMemory.Memory
{
    /// <summary>
    /// Use this to validate all patterns work on all versions of an executable
    /// </summary>
    public class PatternCounter
    {
        private readonly List<(string name, string pattern)> _patterns = new List<(string name, string pattern)>();
        private readonly List<(string executable, byte[] bytes)> _executables = new List<(string executable, byte[] bytes)>();



        public PatternCounter(string path)
        {
            if (Directory.Exists(path))
            {
                var executabes = Directory.EnumerateFiles(path).ToList();
                foreach (var e in executabes)
                {
                    _executables.Add((Path.GetFileName(e), File.ReadAllBytes(e)));
                }
            }
        }

        public void AddPattern(string name, string pattern)
        {
            _patterns.Add((name, pattern));
        }

        public IEnumerable<(string executable, string name, long count)> GetResults()
        {
            foreach(var e in _executables)
            {
                foreach (var pattern in _patterns)
                {
                    var count = PatternScanner.Count(e.bytes, pattern.pattern.ToByteArray());
                    yield return (e.executable, pattern.name, count);
                }
            }
        }
    }
}
