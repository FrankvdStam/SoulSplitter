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

namespace SoulMemory.MemoryV2.Process
{
    public class ProcessHook : IProcessHook
    {
        public ProcessHook(string name)
        {
            _name = name;
        }

        private readonly string _name;

        public System.Diagnostics.Process GetProcess() => ProcessWrapper.GetProcess();

        public event Func<ResultErr<RefreshError>> Hooked;
        public event Action<Exception> Exited;
        
        public IProcessWrapper ProcessWrapper = new ProcessWrapper();
        public PointerTreeBuilder.PointerTreeBuilder PointerTreeBuilder { get; set; } = new PointerTreeBuilder.PointerTreeBuilder();

        #region Refresh =================================================================================================================================================

        /// <summary>
        /// Refresh attachment to a process
        /// </summary>
        /// <returns></returns>
        public ResultErr<RefreshError> TryRefresh()
        {
            var processRefreshResult = ProcessWrapper.TryRefresh(_name, out Exception e);
            switch (processRefreshResult)
            {
                case ProcessRefreshResult.ProcessNotRunning:
                    return Result.Err(new RefreshError(RefreshErrorReason.ProcessNotRunning, $"Process {_name} not running or inaccessible. Try running livesplit as admin."));


                //Run scans when process is initialized
                case ProcessRefreshResult.Initialized:
                    var mainModule = ProcessWrapper.GetMainModule();
                    if (mainModule == null)
                    {
                        return Result.Err(new RefreshError(RefreshErrorReason.ScansFailed, "Main module is null. Try running as admin."));
                    }

                    var baseAddress = mainModule.BaseAddress.ToInt64();
                    var memorySize = mainModule.ModuleMemorySize;
                    var is64Bit = ProcessWrapper.Is64Bit();

                    var pointerScanResult = PointerTreeBuilder.TryResolvePointers(this, baseAddress, memorySize, is64Bit);
                    if (pointerScanResult.IsErr)
                    {
                        return pointerScanResult;
                    }
                    return Hooked?.Invoke() ?? Result.Ok();


                //Standard refresh
                case ProcessRefreshResult.Refreshed:
                    return Result.Ok();


                case ProcessRefreshResult.Exited:
                    Exited?.Invoke(null);
                    return Result.Err(new RefreshError(RefreshErrorReason.ProcessExited));

                case ProcessRefreshResult.Error:
                    Exited?.Invoke(e);
                    if (e.Message == "Access is denied")
                    {
                        return Result.Err(new RefreshError(RefreshErrorReason.AccessDenied, "Access is denied. Make sure you disable easy anti cheat and try running livesplit as admin."));
                    }
                    return RefreshError.FromException(e);

                default:
                    throw new NotImplementedException($"{processRefreshResult}");
            }
        }

        #endregion

        #region IMemory

        public byte[] ReadBytes(long offset, int length) => ProcessWrapper.ReadBytes(offset, length);
        public void WriteBytes(long offset, byte[] bytes) => ProcessWrapper.WriteBytes(offset, bytes);

        #endregion

    }
}
