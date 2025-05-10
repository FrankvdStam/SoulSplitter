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
using System.Runtime.InteropServices;

namespace SoulMemory.Native.Structs;

public enum ProcessorArchitecture
{
    X86 = 0,
    X64 = 9,
    @Arm = -1,
    Itanium = 6,
    Unknown = 0xFFFF,
}

[StructLayout(LayoutKind.Sequential)]
public struct SystemInfo
{
    public ProcessorArchitecture ProcessorArchitecture; // WORD
    public uint PageSize; // DWORD
    public IntPtr MinimumApplicationAddress; // (long)void*
    public IntPtr MaximumApplicationAddress; // (long)void*
    public IntPtr ActiveProcessorMask; // DWORD*
    public uint NumberOfProcessors; // DWORD (WTF)
    public uint ProcessorType; // DWORD
    public uint AllocationGranularity; // DWORD
    public ushort ProcessorLevel; // WORD
    public ushort ProcessorRevision; // WORD
    
}
