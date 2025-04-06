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
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulSplitter.Splits;
using SoulSplitter.UiOld.Generic;
using SoulSplitter.ViewModels.Games;

namespace SoulSplitter.Tests.ViewModels.Games
{
    [TestClass]
    public class ArmoredCore6ViewModelTests
    {
        [TestMethod]
        public void ViewModel_Add_Flag()
        {
            var vm = new ArmoredCore6ViewModel();
            vm.AddSplitCommand.Execute(new FlatSplit()
            {
                TimingType = TimingType.Immediate,
                SplitType = SplitType.Flag,
                Split = new FlagDescription()
                {
                    Flag = 10101,
                    Description = "test"
                }
            });

            Assert.AreEqual(1, vm.SplitsViewModel.TotalSplitsCount);
            Assert.AreEqual(TimingType.Immediate, vm.SplitsViewModel.Splits.First().TimingType);
            Assert.AreEqual(SplitType.Flag, vm.SplitsViewModel.Splits.First().Children.First().SplitType);
            Assert.IsInstanceOfType<FlagDescription>(vm.SplitsViewModel.Splits.First().Children.First().Children.First().Split);
            var flagDesc = (FlagDescription)vm.SplitsViewModel.Splits.First().Children.First().Children.First().Split;
            Assert.AreEqual((uint)10101, flagDesc.Flag);
            Assert.AreEqual("test", flagDesc.Description);
        }

        [TestMethod]
        public void ViewModel_Remove_Split()
        {
            var vm = new ArmoredCore6ViewModel();
            vm.AddSplitCommand.Execute(new FlatSplit()
            {
                TimingType = TimingType.Immediate,
                SplitType = SplitType.Flag,
                Split = new FlagDescription()
                {
                    Flag = 10101,
                    Description = "test"
                }
            });

            vm.SplitsViewModel.SelectedSplit = vm.SplitsViewModel.Splits.First().Children.First().Children.First();
            vm.RemoveSplitCommand.Execute(null);

            Assert.AreEqual(0, vm.SplitsViewModel.TotalSplitsCount);
        }

        [TestMethod]
        public void ViewModel_Remove_Split_No_Exception()
        {
            var vm = new ArmoredCore6ViewModel();
            try
            {
                vm.RemoveSplitCommand.Execute(null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
    }
}
