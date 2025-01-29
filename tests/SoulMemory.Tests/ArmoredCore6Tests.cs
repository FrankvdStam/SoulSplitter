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
using SoulMemory.MemoryV2.Memory;
using SoulMemory.MemoryV2.PointerTreeBuilder;
using SoulMemory.MemoryV2.Process;
using SoulMemory.Tests.Mocks;

namespace SoulMemory.Tests;

[TestClass]
public class ArmoredCore6Tests
{
    [TestMethod]
    [DataRow(RefreshErrorReason.ProcessNotRunning)]
    [DataRow(RefreshErrorReason.ScansFailed)]
    [DataRow(RefreshErrorReason.AccessDenied)]
    [DataRow(RefreshErrorReason.ModLoadFailed)]
    [DataRow(RefreshErrorReason.MainModuleNull)]
    [DataRow(RefreshErrorReason.ProcessExited)]
    public void Refresh_Error(RefreshErrorReason refreshError)
    {
        var processHookMock = new Mock<IProcessHook>();
        processHookMock.Setup(i => i.PointerTreeBuilder).Returns(new PointerTreeBuilder());
        processHookMock.Setup(i => i.TryRefresh()).Returns(Result.Err(new RefreshError(refreshError)));

        var ac6 = new ArmoredCore6.ArmoredCore6(processHookMock.Object);
        Assert.AreEqual(refreshError, ac6.TryRefresh().GetErr().Reason);

        processHookMock.Setup(i => i.TryRefresh()).Returns(Result.Ok());
        Assert.IsTrue(ac6.TryRefresh().IsOk);
    }

    [TestMethod]
    public void Refresh_Success()
    {
        var processHookMock = new Mock<IProcessHook>();
        processHookMock.Setup(i => i.PointerTreeBuilder).Returns(new PointerTreeBuilder());
        processHookMock.Setup(i => i.TryRefresh()).Returns(Result.Ok());

        var ac6 = new ArmoredCore6.ArmoredCore6(processHookMock.Object);
        Assert.IsTrue(ac6.TryRefresh().IsOk);
    }
    
    [TestMethod]
    public void ReadIgt()
    {
        var mock = new ProcessHookMock();
        mock.SetPointer("FD4Time", 0, 0x7FF46F5C04B0);
        
        var ac6 = new ArmoredCore6.ArmoredCore6(mock);
        Assert.IsTrue(ac6.TryRefresh().IsOk);

        mock.WriteInt32(0x7FF46F5C04B0 + 0x114, 504123);
        Assert.AreEqual(504123, ac6.GetInGameTimeMilliseconds());

        mock.WriteInt32(0x7FF46F5C04B0 + 0x114, 31535);
        Assert.AreEqual(31535, ac6.GetInGameTimeMilliseconds());
    }

    [TestMethod]
    public void WriteIgt()
    {
        var mock = new ProcessHookMock();
        mock.SetPointer("FD4Time", 0, 0x7FF46F5C04B0);

        var ac6 = new ArmoredCore6.ArmoredCore6(mock);
        Assert.IsTrue(ac6.TryRefresh().IsOk);

        ac6.WriteInGameTimeMilliseconds(40);
        Assert.AreEqual(40, ac6.GetInGameTimeMilliseconds());

        ac6.WriteInGameTimeMilliseconds(70);
        Assert.AreEqual(70, ac6.GetInGameTimeMilliseconds());
    }

    [TestMethod]
    public void ReadIsLoading()
    {
        var mock = new ProcessHookMock();
        mock.SetPointer("CSMenuMan", 0, 0x7FF46F5C04B0);

        var ac6 = new ArmoredCore6.ArmoredCore6(mock);
        Assert.IsTrue(ac6.TryRefresh().IsOk);

        mock.WriteInt32(0x7FF46F5C04B0 + 0x8e4, 1);
        Assert.IsTrue(ac6.IsLoadingScreenVisible());

        mock.WriteInt32(0x7FF46F5C04B0 + 0x8e4, 0);
        Assert.IsFalse(ac6.IsLoadingScreenVisible());
    }

    #region ReadEventFlag ==========================================================================================

    [TestMethod]
    public void ReadEventFlag_Loop_Exit_With_Error()
    {
        var eventFlagManPtr       = 0x7FF46F5C04B0;
        var currentElementPtr     = 0x7FF46F600000;
        var currentSubElementPtr  = 0x7FF46F900000;
        var currentSubElementPtr2 = 0x7FF46FA00000;
        var currentSubElementPtr3 = 0x7FF46FC00000;


        var mock = new ProcessHookMock();
        mock.SetPointer("CSEventFlagMan", 0, eventFlagManPtr);

        mock.WriteInt32(eventFlagManPtr   + 0x1c, 1000);
        mock.WriteInt64(eventFlagManPtr   + 0x38, currentElementPtr);//current element
        mock.WriteInt64(currentElementPtr + 0x8 , currentSubElementPtr);//current sub element
        
        //while loop first branch
        mock.WriteByte(currentSubElementPtr + 0x19, 0);
        mock.WriteInt32(currentSubElementPtr + 0x20, 2103506);
        mock.WriteInt64(currentSubElementPtr + 0x0, currentSubElementPtr2);

        //while loop 2nd branch
        mock.WriteByte(currentSubElementPtr2 + 0x19, 0);
        mock.WriteInt32(currentSubElementPtr2 + 0x20, 100);
        mock.WriteInt64(currentSubElementPtr2 + 0x10, currentSubElementPtr3);

        mock.WriteByte(currentSubElementPtr3 + 0x19, 1); //end loop
        
        //Category read will return with error, resulting in false evaluation of the flag

        var ac6 = new ArmoredCore6.ArmoredCore6(mock);
        Assert.IsTrue(ac6.TryRefresh().IsOk);

        Assert.IsFalse(ac6.ReadEventFlag(2103505405));
    }

    [TestMethod]
    public void ReadEventFlag_Pointers_Resolve_To_Same_Address()
    {
        var eventFlagManPtr = 0x7FF46F5C04B0;
        var currentElementPtr = 0x7FF46F600000;

        var mock = new ProcessHookMock();
        mock.SetPointer("CSEventFlagMan", 0, eventFlagManPtr);

        mock.WriteInt32(eventFlagManPtr + 0x1c, 1000);
        mock.WriteInt64(eventFlagManPtr + 0x38, currentElementPtr);//current element
        mock.WriteInt64(currentElementPtr + 0x8, currentElementPtr);//current sub element

        //Skip loop
        mock.WriteByte(currentElementPtr + 0x19, 1);

        //skip category exit
        mock.WriteInt32(currentElementPtr + 0x20, 50);
        
        //Pointers resolve to the same address, read will return with error, resulting in false evaluation of the flag

        var ac6 = new ArmoredCore6.ArmoredCore6(mock);
        Assert.IsTrue(ac6.TryRefresh().IsOk);

        Assert.IsFalse(ac6.ReadEventFlag(2103505405));
    }


    [TestMethod]
    public void ReadEventFlag_MysteryValue_Early_Exit()
    {
        var eventFlagManPtr = 0x7FF46F5C04B0;
        var currentElementPtr = 0x7FF46F600000;
        var currentSubElementPtr = 0x7FF46F900000;
        
        var mock = new ProcessHookMock();
        mock.SetPointer("CSEventFlagMan", 0, eventFlagManPtr);

        mock.WriteInt32(eventFlagManPtr + 0x1c, 1000);
        mock.WriteInt64(eventFlagManPtr + 0x38, currentElementPtr);//current element
        mock.WriteInt64(currentElementPtr + 0x8, currentSubElementPtr);//current sub element

        //Skip loop
        mock.WriteByte(currentSubElementPtr + 0x19, 1);

        //skip category exit
        mock.WriteInt32(currentElementPtr + 0x20, 50);

        //early exit
        mock.WriteInt32(currentElementPtr + 0x28, 2);
        
        var ac6 = new ArmoredCore6.ArmoredCore6(mock);
        Assert.IsTrue(ac6.TryRefresh().IsOk);

        Assert.IsFalse(ac6.ReadEventFlag(2103505405));
    }

    [TestMethod]
    public void ReadEventFlag_MysteryValue_Offset_0x30_0()
    {
        var eventFlagManPtr = 0x7FF46F5C04B0;
        var currentElementPtr = 0x7FF46F600000;
        var currentSubElementPtr = 0x7FF46F900000;
        var calculatedPtr = 0x7FF46FA00000;

        var mock = new ProcessHookMock();
        mock.SetPointer("CSEventFlagMan", 0, eventFlagManPtr);

        mock.WriteInt32(eventFlagManPtr + 0x1c, 1000);
        mock.WriteInt64(eventFlagManPtr + 0x38, currentElementPtr);//current element
        mock.WriteInt64(currentElementPtr + 0x8, currentSubElementPtr);//current sub element

        //Skip loop
        mock.WriteByte(currentSubElementPtr + 0x19, 1);

        //skip category exit
        mock.WriteInt32(currentElementPtr + 0x20, 50);
        
        mock.WriteInt32(currentElementPtr + 0x28, 6);
        mock.WriteInt64(currentElementPtr + 0x30, calculatedPtr);

        mock.WriteInt32(calculatedPtr + 50, 0);

        var ac6 = new ArmoredCore6.ArmoredCore6(mock);
        Assert.IsTrue(ac6.TryRefresh().IsOk);

        Assert.IsFalse(ac6.ReadEventFlag(2103505405));
    }

    [TestMethod]
    public void ReadEventFlag_MysteryValue_Offset_0x30_4()
    {
        var eventFlagManPtr = 0x7FF46F5C04B0;
        var currentElementPtr = 0x7FF46F600000;
        var currentSubElementPtr = 0x7FF46F900000;
        var calculatedPtr = 0x7FF46FA00000;

        var mock = new ProcessHookMock();
        mock.SetPointer("CSEventFlagMan", 0, eventFlagManPtr);

        mock.WriteInt32(eventFlagManPtr + 0x1c, 1000);
        mock.WriteInt64(eventFlagManPtr + 0x38, currentElementPtr);//current element
        mock.WriteInt64(currentElementPtr + 0x8, currentSubElementPtr);//current sub element

        //Skip loop
        mock.WriteByte(currentSubElementPtr + 0x19, 1);

        //skip category exit
        mock.WriteInt32(currentElementPtr + 0x20, 50);

        //mystery value
        mock.WriteInt32(currentElementPtr + 0x28, 6);
        mock.WriteInt64(currentElementPtr + 0x30, calculatedPtr);
        
        mock.WriteInt32(calculatedPtr + 50, 4);

        var ac6 = new ArmoredCore6.ArmoredCore6(mock);
        Assert.IsTrue(ac6.TryRefresh().IsOk);

        Assert.IsTrue(ac6.ReadEventFlag(2103505405));
    }

    [TestMethod]
    public void ReadEventFlag_MysteryValue_Calculate_Ptr()
    {
        var eventFlagManPtr = 0x7FF46F5C04B0;
        var currentElementPtr = 0x7FF46F600000;
        var currentSubElementPtr = 0x7FF46F900000;

        var mock = new ProcessHookMock();
        mock.SetPointer("CSEventFlagMan", 0, eventFlagManPtr);

        mock.WriteInt32(eventFlagManPtr + 0x1c, 1000);
        mock.WriteInt64(eventFlagManPtr + 0x38, currentElementPtr);//current element
        mock.WriteInt64(currentElementPtr + 0x8, currentSubElementPtr);//current sub element

        //Skip loop
        mock.WriteByte(currentSubElementPtr + 0x19, 1);

        //skip category exit
        mock.WriteInt32(currentElementPtr + 0x20, 50);

        //mystery value
        mock.WriteInt32(currentElementPtr + 0x28, 1);
        mock.WriteInt64(currentElementPtr + 0x30, 20);

        //calculate ptr (probably a bit crazy calculated, the biggest offset probably is the 64bit read at offset 0x28)
        mock.WriteInt32(eventFlagManPtr + 0x20, 10);
        mock.WriteInt32(currentElementPtr + 0x30, 10);
        mock.WriteInt64(eventFlagManPtr + 0x28, 0x7FF46FA00000);

        //flag value
        var calculatePtr = (10 * 10) + 0x7FF46FA00000;
        mock.WriteInt32(calculatePtr + 50, 4);

        var ac6 = new ArmoredCore6.ArmoredCore6(mock);
        Assert.IsTrue(ac6.TryRefresh().IsOk);

        Assert.IsTrue(ac6.ReadEventFlag(2103505405));
    }
    
    #endregion
}
