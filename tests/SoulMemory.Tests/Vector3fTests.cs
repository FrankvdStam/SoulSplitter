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
public class Vector3fTests
{
    [TestMethod]
    public void Default_Constructor()
    {
        var vec = new Vector3f();
        Assert.AreEqual(0.0f, vec.X);
        Assert.AreEqual(0.0f, vec.Y);
        Assert.AreEqual(0.0f, vec.Z);
        Assert.AreEqual($"{0.0f:N2}, {0.0:N2}, {0.0:N2}", vec.ToString());
    }

    [TestMethod]
    public void Constructor()
    {
        var vec = new Vector3f(1.1f, 2.2f, 3.3f);
        Assert.AreEqual(1.1f, vec.X);
        Assert.AreEqual(2.2f, vec.Y);
        Assert.AreEqual(3.3f, vec.Z);
        Assert.AreEqual($"{1.1f:N2}, {2.20:N2}, {3.30:N2}", vec.ToString());
    }

    [TestMethod]
    public void Clone()
    {
        var original = new Vector3f(1.1f, 2.2f, 3.3f);
        var vec = original.Clone();
        Assert.AreEqual(1.1f, vec.X);
        Assert.AreEqual(2.2f, vec.Y);
        Assert.AreEqual(3.3f, vec.Z);
        Assert.AreEqual($"{1.1f:N2}, {2.20:N2}, {3.30:N2}", vec.ToString());
    }
}
