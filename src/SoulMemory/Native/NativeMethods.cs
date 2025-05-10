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

using SoulMemory.Native.Enums;
using SoulMemory.Native.Structs.Module;
using SoulMemory.Native.Structs.Process;
using SoulMemory.Native.Structs;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static SoulMemory.Native.Kernel32;

namespace SoulMemory.Native;

[ExcludeFromCodeCoverage]
internal static class NativeMethods
{
    [DllImport("user32.dll")]
    internal static extern bool RegisterHotKey(IntPtr handle, int id, uint modifiers, uint virtualKeyCode);

    [DllImport("user32.dll")]
    internal static extern bool UnregisterHotKey(IntPtr handle, int id);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    internal static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesWritten);

    [DllImport("kernel32.dll")]
    internal static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MemoryBasicInformation64 lpBuffer, uint dwLength);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool IsWow64Process(IntPtr processHandle, out bool wow64Process);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    internal static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    internal static extern IntPtr GetModuleHandleW(string lpModuleName);

    [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Auto)]
    internal static extern IntPtr CreateToolhelp32Snapshot([In] UInt32 dwFlags, [In] UInt32 th32ProcessID);

    [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Auto)]
    internal static extern bool Process32First([In] IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

    [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Auto)]
    internal static extern bool Process32Next([In] IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

    [DllImport("kernel32.dll")]
    internal static extern bool Module32FirstW(IntPtr hSnapshot, ref MODULEENTRY32W lpme);

    [DllImport("kernel32.dll")]
    internal static extern bool Module32NextW(IntPtr hSnapshot, ref MODULEENTRY32W lpme);

    [DllImport("psapi.dll", SetLastError = true)]
    internal static extern bool EnumProcessModulesEx(
        IntPtr hProcess,
        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)][In][Out] IntPtr[] lphModule,
        uint cb,
        [MarshalAs(UnmanagedType.U4)] out uint lpcbNeeded,
        ListModules dwFilterFlag
    );

    [DllImport("kernel32.dll")]
    internal static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

    [DllImport("kernel32.dll")]
    internal static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

    [DllImport("kernel32.dll")]
    internal static extern bool CloseHandle(IntPtr hObject);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

    [DllImport("kernel32.dll")]
    internal static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint dwFreeType);

    [DllImport("kernel32.dll", SetLastError = false)]
    internal static extern void GetSystemInfo(out SystemInfo info);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);
}
