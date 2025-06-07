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
using System.Text;
using SoulMemory.Abstractions;
using SoulMemory.Memory;

namespace SoulMemory.Games.Nightreign
{
    public class Nightreign : IGame
    {
        private Process? _process;
        private readonly Pointer _igt = new();


        #region Refresh/init/reset ================================================================================================
        public Process? GetProcess() => _process;

        public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "nightreign", InitPointers, ResetPointers);

        public TreeBuilder GetTreeBuilder()
        {
            var treeBuilder = new TreeBuilder();
            treeBuilder
                .ScanRelative("FD4Time",
                    "48 8b 0d ? ? ? ? f3 48 0f 2c c0 01 81 f0 00 00 00", 3, 7)
                    .AddPointer(_igt, 0, 0xf0);
            return treeBuilder;
        }

        private ResultErr<RefreshError> InitPointers()
        {
            try
            {
                var treeBuilder = GetTreeBuilder();
                var result = MemoryScanner.TryResolvePointers(treeBuilder, _process);
                if (result.IsErr)
                {
                    _igt.Clear();
                    return result;
                }

                var injectResult = soulmods.Soulmods.Inject(_process!);
                if (injectResult.IsErr)
                {
                    _igt.Clear();
                    return Result.Err(new RefreshError(RefreshErrorReason.ModLoadFailed, "soulmods injection failed"));
                }
                return Result.Ok();
            }
            catch (Exception e)
            {
                if (e.Message == "Access is denied")
                {
                    _process = null;
                    return Result.Err(new RefreshError(RefreshErrorReason.AccessDenied, "Access is denied. Make sure you disable easy anti cheat and try running livesplit as admin."));
                }

                return RefreshError.FromException(e);
            }
        }

        private void ResetPointers()
        {
            _igt.Clear();
        }
        
        #endregion



        public bool ReadEventFlag(uint eventFlagId)
        {
            throw new NotImplementedException();
        }

        public int ReadInGameTimeMilliseconds()
        {
            return _igt.ReadInt32();
        }
        public void WriteInGameTimeMilliseconds(int milliseconds)
        {
            _igt.WriteInt32(milliseconds);
        }
    }
}
