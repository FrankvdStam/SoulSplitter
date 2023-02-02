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
using SoulMemory.Memory;

namespace SoulMemory
{
    public interface IGame
    {
        /// <summary>
        /// Refresh attachment to a game
        /// </summary>
        ResultErr<RefreshError> TryRefresh();

        /// <summary>
        /// Returns a structure that defines the memory layout of certain game structs and values
        /// Can be resolved and used to read memory, or to be scanned against a file to validate correctness of the structure
        /// </summary>
        TreeBuilder GetTreeBuilder();

        /// <summary>
        /// Read an event flag from the game and return it's state
        /// </summary>
        bool ReadEventFlag(uint eventFlagId);

        /// <summary>
        /// Get a reference to the game process
        /// Will only be a valid reference until the next call to TryRefresh
        /// </summary>
        Process GetProcess();
    }
}
