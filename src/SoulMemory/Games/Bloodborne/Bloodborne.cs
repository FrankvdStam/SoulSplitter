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

using SoulMemory.Abstractions;
using SoulMemory.Memory;
using System;
using System.Diagnostics;
using System.Threading;
using SoulMemory.Native;
using SoulMemory.MemoryV2.PointerTreeBuilder;

namespace SoulMemory.Games.Bloodborne
{
    public class Bloodborne : IGame
    {
        private Process? _process;
        private readonly Pointer _gameDataMan = new();

        #region Refresh/init/reset ================================================================================================================================

        public Process? GetProcess() => _process;

        public ResultErr<RefreshError> TryRefresh() => MemoryScanner.TryRefresh(ref _process, "shadPS4", InitPointers, ResetPointers);

        public TreeBuilder GetTreeBuilder()
        {
            var treeBuilder = new TreeBuilder();
            //treeBuilder
            //    .ScanRelative("GameDataMan", "c4 e1 fa 2c c9 48 8d 05 ? ? ? ? 48 8b 00 03 88 94 00 00 00", 3, 7)
            //        .AddPointer(_gameDataMan, 0);
            
            return treeBuilder;
        }

        private ResultErr<RefreshError> InitPointers()
        {
            Thread.Sleep(3000);

            try
            {
                var ebootAddress = 0x8ffffc000;
                var size = 0x5EC0000; //should read from shadPS4's memory map table to figure out the exact size.
                var codeReadResult = _process!.ReadProcessMemory(ebootAddress, size);
                if (codeReadResult.IsErr)
                {
                    return Result.Err(new RefreshError(RefreshErrorReason.MainModuleNull));
                }

                var bytes = codeReadResult.Unwrap();

                var pattern = "48 8d 05 ? ? ? ? 48 8b 00 03 88 94 00 00 00".ToBytePattern();
                if (!bytes.TryBoyerMooreSearch(pattern, out long gameDataManAddress))
                {
                    return Result.Err(new RefreshError(RefreshErrorReason.ScansFailed));
                }

                //404FA7C
                var address = BitConverter.ToInt32(bytes, (int)(gameDataManAddress + 3));
                var result = ebootAddress + gameDataManAddress + address + 7;
                _gameDataMan.Initialize(_process!, true, result, 0);
               
                return Result.Ok();
            }
            catch (Exception e)
            {
                return RefreshError.FromException(e);
            }
        }


        private void ResetPointers()
        {
            _gameDataMan.Clear();
        }

        #endregion


        public bool ReadEventFlag(uint eventFlagId)
        {
            return false;
        }

        public int ReadInGameTimeMilliseconds()
        {
            return _gameDataMan.ReadInt32(0x94);
        }


        public void WriteInGameTimeMilliseconds(int milliseconds)
        {
            _gameDataMan.WriteInt32(0x94, milliseconds);
        }
    }
}
