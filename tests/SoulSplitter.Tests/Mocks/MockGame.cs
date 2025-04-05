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
using SoulMemory;
using SoulMemory.Abstractions;
using SoulMemory.Memory;

namespace SoulSplitter.Tests.Mocks
{
    public class MockGame : IGame
    {
        public Dictionary<uint, bool> EventFlags = new Dictionary<uint, bool>();


        public int GetInGameTimeMilliseconds()
        {
            throw new NotImplementedException();
        }

        public Process GetProcess()
        {
            throw new NotImplementedException();
        }

        public TreeBuilder GetTreeBuilder()
        {
            throw new NotImplementedException();
        }

        public bool ReadEventFlag(uint eventFlagId)
        {
            if (EventFlags.TryGetValue(eventFlagId, out var value))
            {
                return value;
            }
            return false;
        }

        public ResultErr<RefreshError> TryRefresh()
        {
            throw new NotImplementedException();
        }
    }
}
