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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulMemory.MemoryV2.Process;

namespace SoulMemory.Tests.MemoryV2;

[TestClass]
public class ProcessHookTests
{
    [TestInitialize]
    public void Init()
    {
        _mockProcessWrapper = new Mock<IProcessWrapper>();
        _sut = new ProcessHook("TestProcess", _mockProcessWrapper.Object);

        _sut.Hooked += () =>
        {
            _hookedInvokedCount++;
            return Result.Ok();
        };
        _sut.Exited += exception =>
        {
            _exitedInvokedCount++;
            if (exception != null)
            {
                ExitedExceptions.Add(exception);
            }
        };
    }

    private ProcessHook _sut = null!;
    private Mock<IProcessWrapper> _mockProcessWrapper = null!;
    private int _hookedInvokedCount;
    private int _exitedInvokedCount;
    public List<Exception> ExitedExceptions = new();


    [TestMethod]
    public void TryRefresh_ProcessNotRunning()
    {
        Exception? ex;
        _mockProcessWrapper
            .Setup(i => i.TryRefresh(It.IsAny<string>(), out ex))
            .Returns(ProcessRefreshResult.ProcessNotRunning);

        var refreshResult = _sut.TryRefresh();

        Assert.AreEqual(RefreshErrorReason.ProcessNotRunning, refreshResult.GetErr().Reason);
        Assert.AreEqual("Process TestProcess not running or inaccessible. Try running livesplit as admin.", refreshResult.GetErr().Message);
        Assert.AreEqual(0, ExitedExceptions.Count);
        Assert.AreEqual(0, _exitedInvokedCount);
        Assert.AreEqual(0, _hookedInvokedCount);
    }

    [TestMethod]
    public void TryRefresh_Initialized_MainModuleNull()
    {
        Exception? ex;
        _mockProcessWrapper
            .Setup(i => i.TryRefresh(It.IsAny<string>(), out ex))
            .Returns(ProcessRefreshResult.Initialized);

        _mockProcessWrapper
            .Setup(i => i.GetMainModule())
            .Returns((ProcessWrapperModule)null!);

        var refreshResult = _sut.TryRefresh();

        Assert.AreEqual(RefreshErrorReason.ScansFailed, refreshResult.GetErr().Reason);
        Assert.AreEqual("Main module is null. Try running as admin.", refreshResult.GetErr().Message);
        Assert.AreEqual(0, ExitedExceptions.Count);
        Assert.AreEqual(0, _exitedInvokedCount);
        Assert.AreEqual(0, _hookedInvokedCount);
    }

    [TestMethod]
    public void TryRefresh_Initialized_ScansFailed()
    {
        Exception? ex;
        _mockProcessWrapper
            .Setup(i => i.TryRefresh(It.IsAny<string>(), out ex))
            .Returns(ProcessRefreshResult.Initialized);
        _mockProcessWrapper.Setup(i => i.GetMainModule()).Returns(new ProcessWrapperModule
        {
            BaseAddress = (IntPtr)100,
            ModuleMemorySize = 100
        });
        _mockProcessWrapper.Setup(i => i.Is64Bit()).Returns(true);
        _mockProcessWrapper.Setup(i => i.ReadBytes(100, 100)).Returns(new byte[100]);

        _sut.PointerTreeBuilder.ScanAbsolute("TestScan1", "01 01", 0);
        _sut.PointerTreeBuilder.ScanAbsolute("TestScan2", "01 01", 0);

        var refreshResult = _sut.TryRefresh();

        Assert.AreEqual(RefreshErrorReason.ScansFailed, refreshResult.GetErr().Reason);
        Assert.AreEqual("Scans failed for TestScan1, TestScan2", refreshResult.GetErr().Message);
        Assert.AreEqual(0, ExitedExceptions.Count);
        Assert.AreEqual(0, _exitedInvokedCount);
        Assert.AreEqual(0, _hookedInvokedCount);
    }

    [TestMethod]
    public void TryRefresh_Initialized_Success()
    {
        Exception? ex;
        _mockProcessWrapper
            .Setup(i => i.TryRefresh(It.IsAny<string>(), out ex))
            .Returns(ProcessRefreshResult.Initialized);
        _mockProcessWrapper.Setup(i => i.GetMainModule()).Returns(new ProcessWrapperModule
        {
            BaseAddress = (IntPtr)100,
            ModuleMemorySize = 2
        });
        _mockProcessWrapper.Setup(i => i.Is64Bit()).Returns(true);
        _mockProcessWrapper.Setup(i => i.ReadBytes(100, 2)).Returns(new byte[] { 0x01, 0x01 });

        _sut.PointerTreeBuilder.ScanAbsolute("TestScan1", "01 01", 0);

        var refreshResult = _sut.TryRefresh();

        Assert.IsTrue(refreshResult.IsOk);
        Assert.AreEqual(0, ExitedExceptions.Count);
        Assert.AreEqual(0, _exitedInvokedCount);
        Assert.AreEqual(1, _hookedInvokedCount);
    }

    [TestMethod]
    public void TryRefresh_Refreshed()
    {
        Exception? ex;
        _mockProcessWrapper
           .Setup(i => i.TryRefresh(It.IsAny<string>(), out ex))
           .Returns(ProcessRefreshResult.Refreshed);
        
        var refreshResult = _sut.TryRefresh();

        Assert.IsTrue(refreshResult.IsOk);
        Assert.AreEqual(0, ExitedExceptions.Count);
        Assert.AreEqual(0, _exitedInvokedCount);
        Assert.AreEqual(0, _hookedInvokedCount);
    }

    [TestMethod]
    public void TryRefresh_Exited_No_Exception()
    {
        Exception? ex;
        _mockProcessWrapper
           .Setup(i => i.TryRefresh(It.IsAny<string>(), out ex))
           .Returns(ProcessRefreshResult.Exited);

        var refreshResult = _sut.TryRefresh();

        Assert.AreEqual(RefreshErrorReason.ProcessExited, refreshResult.GetErr().Reason);
        Assert.IsNull(refreshResult.GetErr().Message);
        Assert.IsNull(refreshResult.GetErr().Exception);
        Assert.AreEqual(0, ExitedExceptions.Count);
        Assert.AreEqual(1, _exitedInvokedCount);
        Assert.AreEqual(0, _hookedInvokedCount);
    }

    [TestMethod]
    public void TryRefresh_Error_Access_Denied()
    {
        var ex = new Exception("Access is denied");
        _mockProcessWrapper
            .Setup(i => i.TryRefresh(It.IsAny<string>(), out ex))
            .Returns(ProcessRefreshResult.Error);

        var refreshResult = _sut.TryRefresh();

        Assert.AreEqual(RefreshErrorReason.AccessDenied, refreshResult.GetErr().Reason);
        Assert.AreEqual("Access is denied. Make sure you disable easy anti cheat and try running livesplit as admin.", refreshResult.GetErr().Message);
        Assert.AreEqual(1, ExitedExceptions.Count);
        Assert.AreEqual("Access is denied", ExitedExceptions.First().Message);
        Assert.AreEqual(1, _exitedInvokedCount);
        Assert.AreEqual(0, _hookedInvokedCount);
    }

    [TestMethod]
    public void TryRefresh_Error_Unknown()
    {
        var ex = new Exception("Your computer is on fire");
        _mockProcessWrapper
            .Setup(i => i.TryRefresh(It.IsAny<string>(), out ex))
            .Returns(ProcessRefreshResult.Error);

        var refreshResult = _sut.TryRefresh();

        Assert.AreEqual(RefreshErrorReason.UnknownException, refreshResult.GetErr().Reason);
        Assert.IsNull(refreshResult.GetErr().Message);
        Assert.AreEqual("Your computer is on fire", refreshResult.GetErr().Exception?.Message);
        Assert.AreEqual(1, ExitedExceptions.Count);
        Assert.AreEqual("Your computer is on fire", ExitedExceptions.First().Message);
        Assert.AreEqual(1, _exitedInvokedCount);
        Assert.AreEqual(0, _hookedInvokedCount);
    }
}
