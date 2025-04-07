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
using LiveSplit.Updates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoulMemory;
using SoulMemory.Abstractions;
using SoulMemory.Games.Sekiro;
using SoulSplitter.Resources;
using SoulSplitter.Ui.ViewModels.MainViewModel;

namespace SoulSplitter.Tests.Timer
{
    [TestClass]
    public class TimerBlackscreenRemovalTests
    {
        [TestInitialize]
        public void Init()
        {
            _gameMock = new Mock<ISekiro>();
            _gameMock.Setup(i => i.TryRefresh()).Returns(Result.Ok());
            _gameMock.Setup(i => i.ReadInGameTimeMilliseconds()).Returns(() => _inGameTimeMilliseconds);
            _gameMock.Setup(i => i.IsBlackscreenActive()).Returns(() => _isBlackscreenActive);

            _languageManagerMock = new Mock<ILanguageManager>();

            _mainViewModel = new MainViewModel(_languageManagerMock.Object);

            _sut = new SoulSplitter.Timer(_gameMock.Object, _mainViewModel);
        }

        private Mock<ISekiro> _gameMock = null!;
        private Mock<ILanguageManager> _languageManagerMock = null!;
        private MainViewModel _mainViewModel = null!;
        private SoulSplitter.Timer _sut = null!;
        private int _inGameTimeMilliseconds = 0;
        private bool _isBlackscreenActive = false;
        
        [TestMethod]
        public void Timer_Update_Should_Invoke_UpdateTime()
        {
            var igt = 0;
            _sut.OnUpdateTime += (s, e) => igt = e;
            _sut.Start();

            _inGameTimeMilliseconds = 30;
            _sut.Update();
            Assert.AreEqual(30, igt);

            _isBlackscreenActive = true;
            _inGameTimeMilliseconds = 100;
            _sut.Update();
            Assert.AreEqual(30, igt);
            _gameMock.Verify(i => i.WriteInGameTimeMilliseconds(30), Times.Once);

            _isBlackscreenActive = false;
            _inGameTimeMilliseconds = 200;
            _sut.Update();
            Assert.AreEqual(200, igt);
        }
    }
}
