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

using System.Diagnostics;
using SoulMemory.MemoryV2.Memory;
using SoulMemory.MemoryV2.PointerTreeBuilder;
using SoulMemory.MemoryV2.Process;

namespace SoulMemory.Tests.Mocks;

public class ProcessHookMock : IProcessHook
{
    public ProcessHookMock()
    {
        Hooked += () =>
        {
            HookedInvokedCount++;
            return HookedResult;
        };

        Exited += (e) =>
        {
            if (e != null)
            {
                ExitedExceptions.Add(e);
            }
            ExitedInvokedCount++;
        };
    }

    public Dictionary<long, byte[]> Data = new Dictionary<long, byte[]>();

    public byte[] ReadBytes(long offset, int length)
    {
        var data = Data[offset];
        if (data.Length != length)
        {
            throw new ArgumentException("Data size mismatch");
        }

        return data;
    }

    public void WriteBytes(long offset, byte[] bytes)
    {
        //Allow overwriting existing key
        if (!Data.ContainsKey(offset))
        {
            //check for overlap
            var end = offset + bytes.Length;
            foreach (var item in Data)
            {
                if (offset <= item.Key && item.Key < end)
                {
                    throw new ArgumentException("Found overlap");
                }
            }
        }

        Data[offset] = bytes;
    }

    public Process? GetProcess()
    {
        return null;
    }

    public List<(string name, int index, long address)> PointerValues = new List<(string name, int index, long address)>();

    public void SetPointer(string name, int index, long address)
    {
        //"Self jump"
        Data[address] = BitConverter.GetBytes(address);
        PointerValues.Add((name, index, address));
    }

    
    public ResultErr<RefreshError> TryRefresh()
    {
        foreach (var ptrValue in PointerValues)
        {
            var node = PointerTreeBuilder.Tree.First(i => i.Name == ptrValue.name);
            node = node.Pointers[ptrValue.index];
            node.Pointer.Path.Add(new PointerPath { Offset = ptrValue.address });
        }

        return Result.Ok();
    }

    public int HookedInvokedCount = 0;
    public int ExitedInvokedCount = 0;

    public ResultErr<RefreshError> HookedResult = Result.Ok();
    public List<Exception> ExitedExceptions = new List<Exception>();


#pragma warning disable CS0067
    public event Func<ResultErr<RefreshError>>? Hooked;
    public event Action<Exception?>? Exited;
#pragma warning restore CS0067

    public PointerTreeBuilder PointerTreeBuilder { get; set; } = new PointerTreeBuilder();
    public IProcessWrapper? ProcessWrapper { get; set; }
}
