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
using System.Linq;
using SoulMemory.Native;

namespace SoulMemory.MemoryV2.Process
{
    public class ProcessWrapper : IProcessWrapper
    {
        private System.Diagnostics.Process? _process;
        public System.Diagnostics.Process? GetProcess() => _process;
        public bool Is64Bit() => _process?.Is64Bit() ?? false;
        public ProcessWrapperModule? GetMainModule() => _process?.MainModule == null ? null : ProcessWrapperModule.FromProcessModule(_process.MainModule);

        public List<ProcessWrapperModule> GetProcessModules()
        {
            return (from object pm in _process?.Modules select ProcessWrapperModule.FromProcessModule((ProcessModule)pm)).ToList();
        }

        /// <summary>
        /// Refresh attachment to a process
        /// </summary>
        /// <returns></returns>
        public ProcessRefreshResult TryRefresh(string name, out Exception? exception)
        {
            exception = null;

            try
            {
                //Process not attached - find it in the process list
                if (_process == null)
                {
                    _process = System.Diagnostics.Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower() == name.ToLower() && !i.HasExited);
                    if (_process == null)
                    {
                        return ProcessRefreshResult.ProcessNotRunning;
                    }
                    else
                    {
                        return ProcessRefreshResult.Initialized;
                    }
                }
                //Process is attached, make sure it is still running
                else
                {
                    if (_process.HasExited)
                    {
                        _process = null;
                        return ProcessRefreshResult.Exited;
                    }

                    //Nothing going on, process still running
                    return ProcessRefreshResult.Refreshed;
                }
            }
            catch (Exception e)
            {
                exception = e;
                _process = null;
                return ProcessRefreshResult.Error;
            }
        }

        #region IMemory

        public byte[] ReadBytes(long offset, int length)
        {
            if (_process == null)
            {
                return new byte[length];
            }
            return _process.ReadProcessMemoryNoError(offset, length);
        }

        public void WriteBytes(long offset, byte[] bytes) => _process?.WriteProcessMemoryNoError(offset, bytes);

        #endregion
    }
}
