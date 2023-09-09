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
using SoulMemory.MemoryV2.Memory;

namespace SoulMemory.MemoryV2.Process
{
    /// <summary>
    /// Abstracts a hooked process and makes it injectable and testable
    /// </summary>
    public interface IProcessHook : IMemory
    {
        /// <summary>
        /// Get process wrapper object for more low level access
        /// </summary>
        /// <returns></returns>
        IProcessWrapper ProcessWrapper { get; set; }

        /// <summary>
        /// Call this often to refresh memory
        /// </summary>
        ResultErr<RefreshError> TryRefresh();

        /// <summary>
        /// Called during refresh, after a process is found, hooked and pointer scans succeed.
        /// Custom one-time initialization after hooking should live here
        /// </summary>
        event Func<ResultErr<RefreshError>> Hooked;

        /// <summary>
        /// Called during refresh after a process exits or if hooking/refreshing fails.
        /// Exception might be null.
        /// </summary>
        event Action<Exception> Exited;

        PointerTreeBuilder.PointerTreeBuilder PointerTreeBuilder { get; set; }
    }
}
