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
use ilhook::x64::{CallbackOption, HookFlags, HookPoint, HookType, Hooker, Registers};
use log::info;
use mem_rs::helpers::{scan, to_pattern};
use mem_rs::prelude::*;
use windows::Win32::System::Memory::{VirtualQuery, MEMORY_BASIC_INFORMATION};

static mut INCREMENT_IGT: Option<HookPoint> = None;

pub(crate) static mut IGT_BUFFER: f32 = 0.0f32;

pub fn init_bloodborne()
{
    let mut process = Process::new_with_memory_type("shadps4.exe", MemoryType::Direct);
    process.refresh().unwrap();

    let main_module = process.get_main_module();
    let exports = main_module.get_exports();

    let result = exports.iter().find(|&export|  export.0.to_ascii_lowercase().contains("g_eboot_address"));
    if result.is_none()
    {
        panic!("g_eboot_address export not found");
    }

    let eboot_base_export = result.unwrap().1;
    info!("eboot_base_export: 0x{:x}", eboot_base_export);

    let eboot_base_address = process.read_u64_abs(eboot_base_export);
    info!("eboot_base_address: 0x{:x}", eboot_base_address);

    let mut mbi = MEMORY_BASIC_INFORMATION::default();
    unsafe { VirtualQuery(Some(eboot_base_address as *const c_void), &mut mbi, size_of::<MEMORY_BASIC_INFORMATION>()) ; }


    //thread '<unnamed>' panicked at src\soulmods\src\console.rs:22:28:
    //called `Result::unwrap()` on an `Err` value: Error { code: HRESULT(0x80070005), message: "Access is denied." }
    //note: run with `RUST_BACKTRACE=1` environment variable to display a backtrace
    
    info!("eboot at 0x{:x} - 0x{:x}", eboot_base_address, mbi.RegionSize);

    let mut game_code_bytes: Vec<u8> = vec![0; mbi.RegionSize];
    process.read_memory_abs(eboot_base_address as usize, game_code_bytes.as_mut_slice());

    let igt_increment_fn_address = eboot_base_address as usize + scan(&game_code_bytes, &to_pattern("c4 e1 fa 2c c8 48 8d 05 ? ? ? ? 48 8b 00")).expect("igt increment fn scan failed");
    info!("increment igt fn at 0x{:x}", igt_increment_fn_address);

    unsafe { INCREMENT_IGT = Some(Hooker::new(igt_increment_fn_address, HookType::JmpBack(increment_igt_hook), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap()) };
}

pub unsafe extern "win64" fn increment_igt_hook(registers: *mut Registers, _:usize)
{
    unsafe
    {
        let mut frame_delta = f32::from_bits((*registers).xmm0 as u32);
        frame_delta = frame_delta * 0.96f32; //scale to igt

        //Rather than casting, like the game does, make the behavior explicit by flooring
        let mut floored_frame_delta = frame_delta.floor();
        let remainder = frame_delta - floored_frame_delta;
        IGT_BUFFER = IGT_BUFFER + remainder;

        if IGT_BUFFER > 1.0f32
        {
            IGT_BUFFER = IGT_BUFFER - 1f32;
            floored_frame_delta += 1f32;
        }

        (*registers).xmm0 = f32::to_bits(floored_frame_delta) as u128;
    }
}