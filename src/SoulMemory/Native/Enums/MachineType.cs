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

namespace SoulMemory.Native.Enums
{
    public enum MachineType : ushort
    {
        /// <summary>
        /// The content of this field is assumed to be applicable to any machine type
        /// </summary>
        Unknown = 0x0000,
        /// <summary>
        /// Intel 386 or later processors and compatible processors
        /// </summary>
        I386 = 0x014c,
        R3000 = 0x0162,
        /// <summary>
        ///  MIPS little endian
        /// </summary>
        R4000 = 0x0166,
        R10000 = 0x0168,
        /// <summary>
        /// MIPS little-endian WCE v2
        /// </summary>
        WCEMIPSV2 = 0x0169,
        /// <summary>
        /// Alpha AXP
        /// </summary>
        Alpha = 0x0184,
        /// <summary>
        /// Hitachi SH3
        /// </summary>
        SH3 = 0x01a2,
        /// <summary>
        /// Hitachi SH3 DSP
        /// </summary>
        SH3DSP = 0x01a3,
        /// <summary>
        /// Hitachi SH4
        /// </summary>
        SH4 = 0x01a6,
        /// <summary>
        /// Hitachi SH5
        /// </summary>
        SH5 = 0x01a8,
        /// <summary>
        /// ARM little endian
        /// </summary>
        ARM = 0x01c0,
        /// <summary>
        /// Thumb
        /// </summary>
        Thumb = 0x01c2,
        /// <summary>
        /// ARM Thumb-2 little endian
        /// </summary>
        ARMNT = 0x01c4,
        /// <summary>
        /// Matsushita AM33
        /// </summary>
        AM33 = 0x01d3,
        /// <summary>
        /// Power PC little endian
        /// </summary>
        PowerPC = 0x01f0,
        /// <summary>
        /// Power PC with floating point support
        /// </summary>
        PowerPCFP = 0x01f1,
        /// <summary>
        /// Intel Itanium processor family
        /// </summary>
        IA64 = 0x0200,
        /// <summary>
        /// MIPS16
        /// </summary>
        MIPS16 = 0x0266,
        /// <summary>
        /// Motorola 68000 series
        /// </summary>
        M68K = 0x0268,
        /// <summary>
        /// Alpha AXP 64-bit
        /// </summary>
        Alpha64 = 0x0284,
        /// <summary>
        /// MIPS with FPU
        /// </summary>
        MIPSFPU = 0x0366,
        /// <summary>
        /// MIPS16 with FPU
        /// </summary>
        MIPSFPU16 = 0x0466,
        /// <summary>
        /// EFI byte code
        /// </summary>
        EBC = 0x0ebc,
        /// <summary>
        /// RISC-V 32-bit address space
        /// </summary>
        RISCV32 = 0x5032,
        /// <summary>
        /// RISC-V 64-bit address space
        /// </summary>
        RISCV64 = 0x5064,
        /// <summary>
        /// RISC-V 128-bit address space
        /// </summary>
        RISCV128 = 0x5128,
        /// <summary>
        /// x64
        /// </summary>
        AMD64 = 0x8664,
        /// <summary>
        /// ARM64 little endian
        /// </summary>
        ARM64 = 0xaa64,
        /// <summary>
        /// LoongArch 32-bit processor family
        /// </summary>
        LoongArch32 = 0x6232,
        /// <summary>
        /// LoongArch 64-bit processor family
        /// </summary>
        LoongArch64 = 0x6264,
        /// <summary>
        /// Mitsubishi M32R little endian
        /// </summary>
        M32R = 0x9041
    }
}
