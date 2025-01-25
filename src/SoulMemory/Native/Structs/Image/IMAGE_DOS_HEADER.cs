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

using System.Runtime.InteropServices;

namespace SoulMemory.Native.Structs.Image;

[StructLayout(LayoutKind.Sequential)]
public struct IMAGE_DOS_HEADER
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public char[] e_magic;       // Magic number
    public ushort e_cblp;    // Bytes on last page of file
    public ushort e_cp;      // Pages in file
    public ushort e_crlc;    // Relocations
    public ushort e_cparhdr;     // Size of header in paragraphs
    public ushort e_minalloc;    // Minimum extra paragraphs needed
    public ushort e_maxalloc;    // Maximum extra paragraphs needed
    public ushort e_ss;      // Initial (relative) SS value
    public ushort e_sp;      // Initial SP value
    public ushort e_csum;    // Checksum
    public ushort e_ip;      // Initial IP value
    public ushort e_cs;      // Initial (relative) CS value
    public ushort e_lfarlc;      // File address of relocation table
    public ushort e_ovno;    // Overlay number
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public ushort[] e_res1;    // Reserved words
    public ushort e_oemid;       // OEM identifier (for e_oeminfo)
    public ushort e_oeminfo;     // OEM information; e_oemid specific
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public ushort[] e_res2;    // Reserved words
    public int e_lfanew;      // File address of new exe header

    private string _e_magic
    {
        get { return new string(e_magic); }
    }

    public bool isValid
    {
        get { return _e_magic == "MZ"; }
    }
}