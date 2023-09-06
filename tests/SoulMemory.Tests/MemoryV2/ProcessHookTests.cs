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

using SoulMemory.MemoryV2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using SoulMemory.MemoryV2.Memory;
using SoulMemory.MemoryV2.PointerTreeBuilder;

namespace SoulMemory.Tests.MemoryV2
{
    public class ProcessHookTester : ProcessHook
    {
        public ProcessHookTester() : base("TestProcess")
        {
            Exited += (e) =>
            {
                ExitedInvokedCount++;
                if (e != null)
                {
                    ExitedExceptions.Add(e);
                }
            };

            Hooked += () =>
            {
                HookedInvokedCount++;
                return Result.Ok();
            };
        }

        public readonly List<Exception> ExitedExceptions = new List<Exception>();
        public int ExitedInvokedCount = 0;
        public int HookedInvokedCount = 0;
    }


    [TestClass]
    public class ProcessHookTests
    {
        [TestMethod]
        public void TryRefresh_ProcessNotRunning()
        {
            var mockProcessWrapper = Substitute.For<IProcessWrapper>();
            var anyStringArg = Arg.Any<string>();
            var anyException = Arg.Any<Exception>();
            mockProcessWrapper.TryRefresh(anyStringArg, out anyException).Returns(ProcessRefreshResult.ProcessNotRunning);

            var processHook = new ProcessHookTester();
            processHook.ProcessWrapper = mockProcessWrapper;
            
            var refreshResult = processHook.TryRefresh();

            Assert.AreEqual(RefreshErrorReason.ProcessNotRunning, refreshResult.GetErr().Reason);
            Assert.AreEqual("Process TestProcess not running or inaccessible. Try running livesplit as admin.", refreshResult.GetErr().Message);
            Assert.AreEqual(0, processHook.ExitedExceptions.Count);
            Assert.AreEqual(0, processHook.ExitedInvokedCount);
            Assert.AreEqual(0, processHook.HookedInvokedCount);
        }

        [TestMethod]
        public void TryRefresh_Initialized_MainModuleNull()
        {
            var mockProcessWrapper = Substitute.For<IProcessWrapper>();
            var anyStringArg = Arg.Any<string>();
            var anyException = Arg.Any<Exception>();
            mockProcessWrapper.TryRefresh(anyStringArg, out anyException).Returns(ProcessRefreshResult.Initialized);
            mockProcessWrapper.GetMainModule().Returns((ProcessWrapperModule?)null);
            
            var processHook = new ProcessHookTester();
            processHook.ProcessWrapper = mockProcessWrapper;
            
            var refreshResult = processHook.TryRefresh();
            
            Assert.AreEqual(RefreshErrorReason.ScansFailed, refreshResult.GetErr().Reason);
            Assert.AreEqual("Main module is null. Try running as admin.", refreshResult.GetErr().Message);
            Assert.AreEqual(0, processHook.ExitedExceptions.Count);
            Assert.AreEqual(0, processHook.ExitedInvokedCount);
            Assert.AreEqual(0, processHook.HookedInvokedCount);
        }

        [TestMethod]
        public void TryRefresh_Initialized_ScansFailed()
        {
            var mockProcessWrapper = Substitute.For<IProcessWrapper>();
            var anyStringArg = Arg.Any<string>();
            var anyException = Arg.Any<Exception>();
            mockProcessWrapper.TryRefresh(anyStringArg, out anyException).Returns(ProcessRefreshResult.Initialized);
            mockProcessWrapper.GetMainModule().Returns(new ProcessWrapperModule
            {
                BaseAddress = (IntPtr)100,
                ModuleMemorySize = 100,
            });
            mockProcessWrapper.Is64Bit().Returns(true);
            mockProcessWrapper.ReadBytes(100, 100).Returns(new byte[100]);

            var processHook = new ProcessHookTester();
            processHook.ProcessWrapper = mockProcessWrapper;
            processHook.PointerTreeBuilder.ScanAbsolute("TestScan1", "01 01", 0);
            processHook.PointerTreeBuilder.ScanAbsolute("TestScan2", "01 01", 0);

            var refreshResult = processHook.TryRefresh();

            Assert.AreEqual(RefreshErrorReason.ScansFailed, refreshResult.GetErr().Reason);
            Assert.AreEqual("Scans failed for TestScan1,TestScan2", refreshResult.GetErr().Message);
            Assert.AreEqual(0, processHook.ExitedExceptions.Count);
            Assert.AreEqual(0, processHook.ExitedInvokedCount);
            Assert.AreEqual(0, processHook.HookedInvokedCount);
        }

        [TestMethod]
        public void TryRefresh_Initialized_Success()
        {
            var mockProcessWrapper = Substitute.For<IProcessWrapper>();
            var anyStringArg = Arg.Any<string>();
            var anyException = Arg.Any<Exception>();
            mockProcessWrapper.TryRefresh(anyStringArg, out anyException).Returns(ProcessRefreshResult.Initialized);
            mockProcessWrapper.GetMainModule().Returns(new ProcessWrapperModule
            {
                BaseAddress = (IntPtr)100,
                ModuleMemorySize = 2,
            });
            mockProcessWrapper.Is64Bit().Returns(true);
            mockProcessWrapper.ReadBytes(100, 2).Returns(new byte[]{0x01,0x01});

            var processHook = new ProcessHookTester();
            processHook.ProcessWrapper = mockProcessWrapper;
            processHook.PointerTreeBuilder.ScanAbsolute("TestScan1", "01 01", 0);

            var refreshResult = processHook.TryRefresh();

            Assert.IsTrue(refreshResult.IsOk);
            Assert.AreEqual(0, processHook.ExitedExceptions.Count);
            Assert.AreEqual(0, processHook.ExitedInvokedCount);
            Assert.AreEqual(1, processHook.HookedInvokedCount);
        }

        [TestMethod]
        public void TryRefresh_Refreshed()
        {
            var mockProcessWrapper = Substitute.For<IProcessWrapper>();
            var anyStringArg = Arg.Any<string>();
            var anyException = Arg.Any<Exception>();
            mockProcessWrapper.TryRefresh(anyStringArg, out anyException).Returns(ProcessRefreshResult.Refreshed);

            var processHook = new ProcessHookTester();
            processHook.ProcessWrapper = mockProcessWrapper;

            var refreshResult = processHook.TryRefresh();

            Assert.IsTrue(refreshResult.IsOk);
            Assert.AreEqual(0, processHook.ExitedExceptions.Count);
            Assert.AreEqual(0, processHook.ExitedInvokedCount);
            Assert.AreEqual(0, processHook.HookedInvokedCount);
        }

        [TestMethod]
        public void TryRefresh_Exited_No_Exception()
        {
            var mockProcessWrapper = Substitute.For<IProcessWrapper>();
            var anyStringArg = Arg.Any<string>();
            var anyException = Arg.Any<Exception>();
            mockProcessWrapper.TryRefresh(anyStringArg, out anyException).Returns(ProcessRefreshResult.Exited);
           
            var processHook = new ProcessHookTester();
            processHook.ProcessWrapper = mockProcessWrapper;

            var refreshResult = processHook.TryRefresh();

            Assert.AreEqual(RefreshErrorReason.ProcessExited, refreshResult.GetErr().Reason);
            Assert.IsNull(refreshResult.GetErr().Message);
            Assert.IsNull(refreshResult.GetErr().Exception);
            Assert.AreEqual(0, processHook.ExitedExceptions.Count);
            Assert.AreEqual(1, processHook.ExitedInvokedCount);
            Assert.AreEqual(0, processHook.HookedInvokedCount);
        }

        [TestMethod]
        public void TryRefresh_Error_Access_Denied()
        {
            var mockProcessWrapper = Substitute.For<IProcessWrapper>();
            var anyStringArg = Arg.Any<string>();
            mockProcessWrapper
                .TryRefresh(anyStringArg, out Arg.Any<Exception>())
                .Returns(i =>
                {
                    i[1] = new Exception("Access is denied");
                    return ProcessRefreshResult.Error;
                });

            var processHook = new ProcessHookTester();
            processHook.ProcessWrapper = mockProcessWrapper;

            var refreshResult = processHook.TryRefresh();

            Assert.AreEqual(RefreshErrorReason.AccessDenied, refreshResult.GetErr().Reason);
            Assert.AreEqual("Access is denied. Make sure you disable easy anti cheat and try running livesplit as admin.", refreshResult.GetErr().Message);
            Assert.AreEqual(1, processHook.ExitedExceptions.Count);
            Assert.AreEqual("Access is denied", processHook.ExitedExceptions.First().Message);
            Assert.AreEqual(1, processHook.ExitedInvokedCount);
            Assert.AreEqual(0, processHook.HookedInvokedCount);
        }

        [TestMethod]
        public void TryRefresh_Error_Unknown()
        {
            var mockProcessWrapper = Substitute.For<IProcessWrapper>();
            var anyStringArg = Arg.Any<string>();
            mockProcessWrapper
                .TryRefresh(anyStringArg, out Arg.Any<Exception>())
                .Returns(i =>
                {
                    i[1] = new Exception("Your computer is on fire");
                    return ProcessRefreshResult.Error;
                });

            var processHook = new ProcessHookTester();
            processHook.ProcessWrapper = mockProcessWrapper;

            var refreshResult = processHook.TryRefresh();

            Assert.AreEqual(RefreshErrorReason.UnknownException, refreshResult.GetErr().Reason);
            Assert.IsNull(refreshResult.GetErr().Message);
            Assert.AreEqual("Your computer is on fire", refreshResult.GetErr().Exception.Message);
            Assert.AreEqual(1, processHook.ExitedExceptions.Count);
            Assert.AreEqual("Your computer is on fire", processHook.ExitedExceptions.First().Message);
            Assert.AreEqual(1, processHook.ExitedInvokedCount);
            Assert.AreEqual(0, processHook.HookedInvokedCount);
        }
    }
}
