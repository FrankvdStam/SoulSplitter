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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.MemoryV2;
using NSubstitute;
using SoulMemory.Memory;
using SoulMemory.MemoryV2.Memory;
using SoulMemory.MemoryV2.PointerTreeBuilder;

namespace SoulMemory.Tests
{
    [TestClass]
    public class ArmoredCore6Tests
    {
        [TestInitialize]
        public void Init()
        {
            _mockProcessHook = new MockProcessHook();
            _armoredCore6 = new SoulMemory.MemoryV2.ArmoredCore6(_mockProcessHook);
        }

        private SoulMemory.MemoryV2.ArmoredCore6 _armoredCore6;
        private MockProcessHook _mockProcessHook;

        [TestMethod]
        public void Initialize_Without_Process()
        {
            var mock = Substitute.For<IProcessHook>();
            mock.PointerTreeBuilder.Returns(new PointerTreeBuilder());
            mock.TryRefresh().Returns(Result.Err(new RefreshError(RefreshErrorReason.ProcessNotRunning)));

            var ac6 = new SoulMemory.MemoryV2.ArmoredCore6(mock);
            Assert.AreEqual(RefreshErrorReason.ProcessNotRunning, ac6.TryRefresh().GetErr().Reason);
            Assert.AreEqual(RefreshErrorReason.ProcessNotRunning, ac6.TryRefresh().GetErr().Reason);

            mock.TryRefresh().Returns(Result.Ok());
            Assert.IsTrue(ac6.TryRefresh().IsOk);
        }

    }
}
