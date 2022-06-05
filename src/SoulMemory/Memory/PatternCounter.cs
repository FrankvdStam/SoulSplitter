using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
