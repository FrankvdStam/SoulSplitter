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

use std::ffi::c_void;
use log::info;
use windows::Win32::System::Memory::{MEM_COMMIT, MEM_RESERVE, PAGE_EXECUTE_READWRITE, VirtualAlloc};
use windows::Win32::System::SystemInformation::{GetSystemInfo, SYSTEM_INFO};

pub struct Memory;

impl Memory
{
    pub fn allocate_near_target(target: usize, range: usize, size: usize) -> Result<usize, ()>
    {
        let mut system_info = SYSTEM_INFO::default();
        unsafe{ GetSystemInfo(&mut system_info); }

        let min_address = target - range;
        let max_address = target + range;

        let mut address = min_address;
        while address < max_address
        {
            let alloc_result = unsafe{ VirtualAlloc(Some(address as *const c_void), size, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE) } as usize;
            info!("suitable region: {} {}", address, alloc_result);
            if alloc_result != 0
            {
                return Ok(alloc_result);
            }
            address = address + system_info.dwAllocationGranularity as usize;
        }
        return Err(());
    }
}


