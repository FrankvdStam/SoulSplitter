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
using NSubstitute;
using SoulMemory.MemoryV2.Memory;
using SoulMemory.MemoryV2.PointerTreeBuilder;
using SoulMemory.MemoryV2.Process;

namespace SoulMemory.Tests
{
    [TestClass]
    public class ArmoredCore6Tests
    {
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

        private readonly byte[] Ac6Memory = new byte[]
        {
            0x48, 0x8b, 0x35, 0x20, 0x4a, 0xdf, 0x03, 0x83, 0xf8, 0xff, 0x0f, 0x44, 0xc1, //CSEventFlagMan
            //0x33, 0xf6, 0x89, 0x75, 0x97, 0x40, 0x38, 0x75, 0x77, 0x? , 0x? , 0x48, 0x89, 0x31, //NoLogo
            //0x48, 0x8b, 0x0d, 0x? , 0x? , 0x? , 0x? , 0x0f, 0x28, 0xc8, 0xf3, 0x0f, 0x59, 0x0d, //FD4Time
            //0x48, 0x8b, 0x35, 0x? , 0x? , 0x? , 0x? , 0x33, 0xdb, 0x89, 0x5c, 0x24, 0x20, //CSMenuMan
        };


        [TestMethod]
        public void ReadMemTest()
        {
            var mock = Substitute.For<IProcessHook>();
            mock.PointerTreeBuilder.Returns(new PointerTreeBuilder());
            mock
                .TryRefresh()
                .Returns(i =>
                {
                    var fd4Time = mock.PointerTreeBuilder.Tree.First(i => i.Name == "FD4Time").Pointers.First();
                    fd4Time.Pointer.Path.Add(new PointerPath() { Offset = 0x144DA2F48 });
                    return Result.Ok();
                });

            mock
                .ReadBytes(Arg.Any<long>(), Arg.Any<int>())
                .Returns(i =>
                {
                    var address = (long)i[0];
                    var size = (int)i[1];

                    if (address == 0x144DA2F48 && size == 8)
                    {
                        return BitConverter.GetBytes(0x7FF46F5C04B0);
                    }

                    if (address == 0x7FF46F5C04B0 + 0x114 && size == 4)
                    {
                        return BitConverter.GetBytes(50681);
                    }

                    Assert.Fail();
                    return new byte[]{};
                });

            var ac6 = new SoulMemory.MemoryV2.ArmoredCore6(mock);
            Assert.IsTrue(ac6.TryRefresh().IsOk);
            

            var igt = ac6.GetInGameTimeMilliseconds();
            Assert.AreEqual(50681, igt);
        }
    }
}
