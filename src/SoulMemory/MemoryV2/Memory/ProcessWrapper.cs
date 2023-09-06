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

using SoulMemory.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SoulMemory.MemoryV2.Memory
{
    public enum ProcessRefreshResult
    {
        ProcessNotRunning,
        Initialized,
        Exited,
        Error,
        Refreshed,
    }

    public class ProcessWrapperModule
    {
        public string ModuleName { get; set; }
        
        public string FileName { get; set; }
        
        public IntPtr BaseAddress { get; set; }
        
        public int ModuleMemorySize { get; set; }

        public static ProcessWrapperModule FromProcessModule(ProcessModule module)
        {
            return new ProcessWrapperModule
            {
                ModuleName = module.ModuleName,
                FileName = module.FileName,
                BaseAddress = module.BaseAddress,
                ModuleMemorySize = module.ModuleMemorySize,
            };
        }
    }

    public interface IProcessWrapper : IMemory
    {
        ProcessRefreshResult TryRefresh(string name, out Exception exception);
        ProcessWrapperModule GetMainModule();
        List<ProcessWrapperModule> GetProcessModules();
        Process GetProcess();
        bool Is64Bit();
    }

    public class ProcessWrapper : IProcessWrapper
    {
        private Process _process;
        public Process GetProcess() => _process;
        public bool Is64Bit() => _process.Is64Bit();
        public ProcessWrapperModule GetMainModule() => _process.MainModule == null ? null : ProcessWrapperModule.FromProcessModule(_process.MainModule);

        public List<ProcessWrapperModule> GetProcessModules()
        {
            var result = new List<ProcessWrapperModule>();
            foreach (var pm in _process.Modules)
            {
                result.Add(ProcessWrapperModule.FromProcessModule((ProcessModule)pm));
            }
            return result;
        }

        /// <summary>
        /// Refresh attachment to a process
        /// </summary>
        /// <returns></returns>
        public ProcessRefreshResult TryRefresh(string name, out Exception exception)
        {
            exception = null;

            try
            {
                //Process not attached - find it in the process list
                if (_process == null)
                {
                    _process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower() == name.ToLower() && !i.HasExited);
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

        public byte[] ReadBytes(long offset, int length) => _process.ReadProcessMemory(offset, length).Unwrap();
        public void WriteBytes(long offset, byte[] bytes) => _process.WriteProcessMemory(offset, bytes).Unwrap();

        #endregion
    }
}
