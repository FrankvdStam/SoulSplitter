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

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoulSplitter.Tests.Mocks;
using SoulSplitter.Ui.ViewModels;

namespace SoulSplitter.Tests.ViewModels
{
    [TestClass]
    public class FlagTrackerViewModelTests
    {
        [TestMethod]
        public void FlagTracker_Can_Not_Add()
        {
            var flagTracker = new FlagTrackerViewModel();
            Assert.IsFalse(flagTracker.CommandAddEventFlag.CanExecute(null));
        }

        [TestMethod]
        public void FlagTracker_Can_Add()
        {
            var flagTracker = new FlagTrackerViewModel();
            flagTracker.CategoryName = "Test";
            flagTracker.FlagDescriptionViewModel.Flag = 101;
            Assert.IsTrue(flagTracker.CommandAddEventFlag.CanExecute(null));
        }

        [TestMethod]
        public void FlagTracker_Add()
        {
            var flagTracker = new FlagTrackerViewModel();
            flagTracker.CategoryName = "Test";
            flagTracker.FlagDescriptionViewModel.Flag = 101;
            flagTracker.CommandAddEventFlag.Execute(null);
            Assert.AreEqual(1, flagTracker.EventFlagCategories.Count);
        }

        [TestMethod]
        public void FlagTracker_Run()
        {
            var game = new MockGame();
            var flagTracker = new FlagTrackerViewModel();

            //Add 4 flags
            flagTracker.CategoryName = "Test";
            flagTracker.FlagDescriptionViewModel.Flag = 1;
            flagTracker.CommandAddEventFlag.Execute(null);
            flagTracker.FlagDescriptionViewModel.Flag = 2;
            flagTracker.CommandAddEventFlag.Execute(null);
            flagTracker.FlagDescriptionViewModel.Flag = 3;
            flagTracker.CommandAddEventFlag.Execute(null);
            flagTracker.FlagDescriptionViewModel.Flag = 4;
            flagTracker.CommandAddEventFlag.Execute(null);

            var category = flagTracker.EventFlagCategories.First();
            var vmEventFlags = category.EventFlags;
            Assert.AreEqual(4, vmEventFlags.Count);
            
            flagTracker.Start();
            flagTracker.Update(game);

            var percentage = 0.0f;
            Assert.AreEqual($"{percentage:0.00}%", category.Progress);

            using (var enumerator = category.EventFlags.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var flag = enumerator.Current;
                    Assert.IsNotNull(flag);
                    
                    Assert.AreEqual(false, flag.State);
                    Assert.AreEqual($"{percentage:0.00}%", category.Progress);
                    Assert.AreEqual($"{percentage:0.00}%", flagTracker.Progress);
                    
                    game.EventFlags[flag.Flag] = true;
                    percentage += 25.0f;

                    flagTracker.Update(game);

                    Assert.AreEqual(true, flag.State);
                    Assert.AreEqual($"{percentage:0.00}%", category.Progress);
                    Assert.AreEqual($"{percentage:0.00}%", flagTracker.Progress);
                }
            }
        }
    }
}
