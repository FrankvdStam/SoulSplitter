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

using SoulMemory.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoulMemory.Tests;

[TestClass]
public class MemoryScannerTests
{
    private static IEnumerable<object[]> ScanTestCases
    {
        get
        {
            return new[]
            {
                //haystack, needle, count, firstindex
                new object[] { "48 8b 05 b1 c6 8B D6 48 8b 50 10 48 89 54 24 60", "8B D6 ?", 1, 5 },
                new object[] { "48 8D 15 C1 E1 10 49 8B C6 41 0B 8F 14 02 00 00 44 8B C6 42 89 0C B2 41 8B D6 49 8B CF", "C6 41 ?", 1, 8 },
                new object[] { "48 8B 0D 99 33 C2 45 33 C0 2B C2 8D 50 F6 8B 1D 32 33", "8B ? ? 33", 2, 1 },
            };
        }
    }

    [TestMethod]
    [DynamicData(nameof(ScanTestCases))]
    public void ScanAndCountTests(string haystackString, string needleString, long count, long index)
    {
        var haystack = haystackString.ToBytePattern().Select(i => (byte)i!).ToArray();
        var needle = needleString.ToBytePattern();

        var actualCount = haystack.BoyerMooreCount(needle);
        haystack.TryBoyerMooreSearch(needle, out long actualIndex);

        Assert.AreEqual(actualCount, count);
        Assert.AreEqual(actualIndex, index);
    }
}
