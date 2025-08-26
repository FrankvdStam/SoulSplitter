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

//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;
//using SoulMemory;
//using SoulMemory.Abstractions;
//using SoulSplitter.Resources;
//using SoulSplitter.Ui.ViewModels.MainViewModel;
//
//namespace SoulSplitter.Tests.Timer
//{
//    [TestClass]
//    public class TimerTests
//    {
//        [TestInitialize]
//        public void Init()
//        {
//            _gameMock = new Mock<IGame>();
//            _gameMock.Setup(i => i.TryRefresh()).Returns(Result.Ok());
//            _gameMock.Setup(i => i.ReadInGameTimeMilliseconds()).Returns(() => _inGameTimeMilliseconds);
//
//            _languageManagerMock = new Mock<ILanguageManager>();
//
//            _mainViewModel = new MainViewModel(_languageManagerMock.Object);
//
//            _sut = new SoulSplitter.Timer(_gameMock.Object, _mainViewModel);
//        }
//
//        private Mock<IGame> _gameMock = null!;
//        private Mock<ILanguageManager> _languageManagerMock = null!;
//        private MainViewModel _mainViewModel = null!;
//        private SoulSplitter.Timer _sut = null!;
//        private int _inGameTimeMilliseconds = 0;
//
//        [TestMethod]
//        public void Timer_Update_Should_Refresh_IGame_And_Forward_RefreshErrors()
//        {
//            _gameMock.Setup(i => i.TryRefresh()).Returns(RefreshError.FromException(new ArgumentException("test")));
//
//            var result = _sut.Update();
//            _gameMock.Verify(i => i.TryRefresh(), Times.Once);
//            Assert.AreEqual(result.GetErr()!.Exception!.Message, "test");
//        }
//
//        [TestMethod]
//        public void Timer_Auto_Start_Should_Invoke()
//        {
//            _mainViewModel.StartAutomatically = true;
//            var triggered = false;
//            _sut.OnAutoStart += (s, e) => triggered = true;
//            
//            _sut.Update();
//            Assert.IsFalse(triggered);
//
//            _inGameTimeMilliseconds = 100;
//            _sut.Update();
//            Assert.IsTrue(triggered);
//        }
//
//        [TestMethod]
//        public void Timer_Update_Should_Invoke_UpdateTime()
//        {
//            var igt = 0;
//            _sut.OnUpdateTime += (s, e) => igt = e;
//            _sut.Start();
//
//            _inGameTimeMilliseconds = 30;
//            _sut.Update();
//            Assert.AreEqual(30, igt);
//
//            _inGameTimeMilliseconds = 100;
//            _sut.Update();
//            Assert.AreEqual(100, igt);
//        }
//    }
//}
