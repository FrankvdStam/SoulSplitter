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

namespace SoulMemory.Tests
{
    [TestClass]
    public class ResultTests
    {
        [TestMethod]
        public void Result_Ok()
        {
            Result result = Result.Ok();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsOk);
            Assert.IsFalse(result.IsErr);
            Assert.That.DoesNotThrow(result.Unwrap);
            Assert.AreEqual("Ok", result.ToString());
        }

        [TestMethod]
        public void Result_Err()
        {
            Result result = Result.Err();

            Assert.IsNotNull(result);
            Assert.IsFalse(result.IsOk);
            Assert.IsFalse(result);
            Assert.IsTrue(result.IsErr);
            Assert.ThrowsException<UnwrapException>(result.Unwrap);
            Assert.AreEqual("Err", result.ToString());
        }

        [TestMethod]
        public void ResultOk_Ok()
        {
            ResultOk<string> result = Result.Ok("test");

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsOk);
            Assert.IsTrue(result);
            Assert.IsFalse(result.IsErr);
            Assert.That.DoesNotThrow(() => result.Unwrap());
            Assert.AreEqual("test", result.Unwrap());
            Assert.AreEqual("Ok: test", result.ToString());
        }

        [TestMethod]
        public void ResultOk_Err()
        {
            ResultOk<string> result = Result.Err();

            Assert.IsNotNull(result);
            Assert.IsFalse(result.IsOk);
            Assert.IsFalse(result);
            Assert.IsTrue(result.IsErr);
            Assert.ThrowsException<UnwrapException>(() => result.Unwrap());
            Assert.AreEqual("Err", result.ToString());
        }

        [TestMethod]
        public void ResultErr_Ok()
        {
            ResultErr<string> result = Result.Ok();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsOk);
            Assert.IsTrue(result);
            Assert.IsFalse(result.IsErr);
            Assert.AreEqual(default, result.GetErr());
            Assert.That.DoesNotThrow(() => result.Unwrap());
            Assert.AreEqual("Ok", result.ToString());
        }

        [TestMethod]
        public void ResultErr_Err()
        {
            ResultErr<string> result = Result.Err("test");

            Assert.IsNotNull(result);
            Assert.IsFalse(result.IsOk);
            Assert.IsFalse(result);
            Assert.IsTrue(result.IsErr);
            Assert.ThrowsException<UnwrapException>(() => result.Unwrap());
            Assert.AreEqual("test", result.GetErr());
            Assert.AreEqual("Err: test", result.ToString());
        }

        [TestMethod]
        public void ResultOkErr_Ok()
        {
            Result<bool, string> result = Result.Ok(true);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsOk);
            Assert.IsTrue(result);
            Assert.IsFalse(result.IsErr);
            Assert.IsTrue(result.Unwrap());
            Assert.AreEqual(default, result.GetErr());
            Assert.AreEqual("Ok: True", result.ToString());
        }

        [TestMethod]
        public void ResultOkErr_Err()
        {
            Result<bool, string> result = Result.Err("test");
            Assert.IsNotNull(result);
            Assert.IsFalse(result.IsOk);
            Assert.IsFalse(result);
            Assert.IsTrue(result.IsErr);
            Assert.ThrowsException<UnwrapException>(() => result.Unwrap());
            Assert.AreEqual("test", result.GetErr());
            Assert.AreEqual("Err: test", result.ToString());
        }
    }
}
