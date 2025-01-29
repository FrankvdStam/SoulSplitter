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

namespace SoulMemory.Tests;

[TestClass]
public class RefreshErrorTests
{
    [DataTestMethod]
    [DataRow(RefreshErrorReason.ProcessExited)]
    [DataRow(RefreshErrorReason.MainModuleNull)]
    [DataRow(RefreshErrorReason.ScansFailed)]
    public void RefreshError_RefreshReason(RefreshErrorReason reason)
    {
        var result = new RefreshError(reason);

        Assert.AreEqual(reason, result.Reason);
        Assert.IsNull(result.Exception);
        Assert.IsNull(result.Message);
        Assert.AreEqual(reason.ToString(), result.ToString());
    }

    [TestMethod]
    public void RefreshError_RefreshReason_Message()
    {
        var result = new RefreshError(RefreshErrorReason.ScansFailed, "FD4Time scan failed");

        Assert.AreEqual(RefreshErrorReason.ScansFailed, result.Reason);
        Assert.IsNull(result.Exception);
        Assert.AreEqual("FD4Time scan failed", result.Message);
        Assert.AreEqual("ScansFailed - FD4Time scan failed", result.ToString());
    }

    [TestMethod]
    public void RefreshError_RefreshReason_Exception()
    {
        var result = new RefreshError(RefreshErrorReason.ScansFailed, new InvalidOperationException("test"));

        Assert.AreEqual(RefreshErrorReason.ScansFailed, result.Reason);
        Assert.IsInstanceOfType<InvalidOperationException>(result.Exception);
        Assert.AreEqual("test", result.Exception.Message);
        Assert.IsNull(result.Message);
        Assert.AreEqual("ScansFailed - System.InvalidOperationException: test", result.ToString());
    }

    [TestMethod]
    public void RefreshError_FromException()
    {
        var exception = new InvalidOperationException("test");
        var resultErr = RefreshError.FromException(exception); ;

        Assert.IsFalse(resultErr.IsOk);
        Assert.IsTrue(resultErr.IsErr);
        Assert.ThrowsException<UnwrapException>(resultErr.Unwrap);

        var result = resultErr.GetErr();

        Assert.AreEqual(RefreshErrorReason.UnknownException, result.Reason);
        Assert.IsInstanceOfType<InvalidOperationException>(result.Exception);
        Assert.AreEqual("test", result.Exception.Message);
        Assert.IsNull(result.Message);
        Assert.AreEqual("UnknownException - System.InvalidOperationException: test", result.ToString());
    }
}
