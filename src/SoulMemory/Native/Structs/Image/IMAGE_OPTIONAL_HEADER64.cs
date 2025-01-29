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
using SoulMemory.Native.Enums;

namespace SoulMemory.Native.Structs.Image;

[StructLayout(LayoutKind.Explicit)]
public struct IMAGE_OPTIONAL_HEADER64
{
    [FieldOffset(0)]
    public MagicType Magic;

    [FieldOffset(2)]
    public byte MajorLinkerVersion;

    [FieldOffset(3)]
    public byte MinorLinkerVersion;

    [FieldOffset(4)]
    public uint SizeOfCode;

    [FieldOffset(8)]
    public uint SizeOfInitializedData;

    [FieldOffset(12)]
    public uint SizeOfUninitializedData;

    [FieldOffset(16)]
    public uint AddressOfEntryPoint;

    [FieldOffset(20)]
    public uint BaseOfCode;

    [FieldOffset(24)]
    public ulong ImageBase;

    [FieldOffset(32)]
    public uint SectionAlignment;

    [FieldOffset(36)]
    public uint FileAlignment;

    [FieldOffset(40)]
    public ushort MajorOperatingSystemVersion;

    [FieldOffset(42)]
    public ushort MinorOperatingSystemVersion;

    [FieldOffset(44)]
    public ushort MajorImageVersion;

    [FieldOffset(46)]
    public ushort MinorImageVersion;

    [FieldOffset(48)]
    public ushort MajorSubsystemVersion;

    [FieldOffset(50)]
    public ushort MinorSubsystemVersion;

    [FieldOffset(52)]
    public uint Win32VersionValue;

    [FieldOffset(56)]
    public uint SizeOfImage;

    [FieldOffset(60)]
    public uint SizeOfHeaders;

    [FieldOffset(64)]
    public uint CheckSum;

    [FieldOffset(68)]
    public SubSystemType Subsystem;

    [FieldOffset(70)]
    public DllCharacteristicsType DllCharacteristics;

    [FieldOffset(72)]
    public ulong SizeOfStackReserve;

    [FieldOffset(80)]
    public ulong SizeOfStackCommit;

    [FieldOffset(88)]
    public ulong SizeOfHeapReserve;

    [FieldOffset(96)]
    public ulong SizeOfHeapCommit;

    [FieldOffset(104)]
    public uint LoaderFlags;

    [FieldOffset(108)]
    public uint NumberOfRvaAndSizes;

    [FieldOffset(112)]
    public IMAGE_DATA_DIRECTORY ExportTable;

    [FieldOffset(120)]
    public IMAGE_DATA_DIRECTORY ImportTable;

    [FieldOffset(128)]
    public IMAGE_DATA_DIRECTORY ResourceTable;

    [FieldOffset(136)]
    public IMAGE_DATA_DIRECTORY ExceptionTable;

    [FieldOffset(144)]
    public IMAGE_DATA_DIRECTORY CertificateTable;

    [FieldOffset(152)]
    public IMAGE_DATA_DIRECTORY BaseRelocationTable;

    [FieldOffset(160)]
    public IMAGE_DATA_DIRECTORY Debug;

    [FieldOffset(168)]
    public IMAGE_DATA_DIRECTORY Architecture;

    [FieldOffset(176)]
    public IMAGE_DATA_DIRECTORY GlobalPtr;

    [FieldOffset(184)]
    public IMAGE_DATA_DIRECTORY TLSTable;

    [FieldOffset(192)]
    public IMAGE_DATA_DIRECTORY LoadConfigTable;

    [FieldOffset(200)]
    public IMAGE_DATA_DIRECTORY BoundImport;

    [FieldOffset(208)]
    public IMAGE_DATA_DIRECTORY IAT;

    [FieldOffset(216)]
    public IMAGE_DATA_DIRECTORY DelayImportDescriptor;

    [FieldOffset(224)]
    public IMAGE_DATA_DIRECTORY CLRRuntimeHeader;

    [FieldOffset(232)]
    public IMAGE_DATA_DIRECTORY Reserved;
}
