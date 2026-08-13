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
using SoulMemory;
using SoulMemory.DarkSouls1;
using SoulSplitter.TestHarness;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.IntegrationTests.DarkSouls1;

[STATestClass]
public class Class1
{
    [TestInitialize]
    public void TestInitialize()
    {
        _harness = SoulComponentHarness.Create();
    }

    private SoulComponentHarness _harness;

    [STATestMethod]
    public void TestMethod1()
    {
        var darkSouls1 = new Mock<IDarkSouls1>();
         
        darkSouls1.Setup(i => i.TryRefresh()).Returns(Result.Ok());

        var update = _harness.SoulComponent.ComponentName;
        Assert.AreEqual("SoulSplitter", update);

        _harness.SelectGame(Game.DarkSouls1, darkSouls1.Object); //Select game and set mock in ISplitter
        _harness.Update(); //Get in OK state
        _harness.SetIgt(100);
    }
}

