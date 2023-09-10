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
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SoulMemory
{
    /// <summary>
    /// Util to easily track event flag changes, helps with debugging.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class FlagWatcher
    {
        public FlagWatcher(IGame game, IEnumerable<uint> flags)
        {
            _game = game;
            foreach (var flag in flags)
            {
                _flags.Add(flag, _game.ReadEventFlag(flag));
            }
        }

        private readonly IGame _game;
        private readonly Dictionary<uint, bool> _flags = new Dictionary<uint, bool>();

        public Dictionary<uint, bool> Update()
        {
            var result = new Dictionary<uint, bool>();
            for (int i = 0; i < _flags.Count; i++)
            {
                var flag = _flags.ElementAt(i);
                var value = _game.ReadEventFlag(flag.Key);
                if (value != flag.Value)
                {
                    result.Add(flag.Key, value);
                    _flags[flag.Key] = value;
                }
            }
            return result;
        }
    }
}
