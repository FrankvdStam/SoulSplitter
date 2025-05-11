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

use std::{slice};
use ilhook::x64::{CallbackOption, HookFlags, HookPoint, HookType, Hooker, Registers};
use log::info;
use mem_rs::helpers::{scan, to_pattern};
use mem_rs::prelude::*;
use crate::util::{Assembler};

static mut INCREMENT_IGT: Option<HookPoint> = None;

static mut IGT_BUFFER: f32 = 0.0f32;

pub fn ds3_init_migt(process: &Process)
{    
    //scan for relevant code
    let game_increment_igt_fn_address = process.scan_abs("igt_fn", "48 83 ec 68 48 c7 44 24 20 fe ff ff ff 0f 29 74 24 50", 0, Vec::new()).unwrap().get_base_address();
    let game_increment_igt_fn_address_end = process.scan_abs("igt_fn_end", "0f 28 74 24 50 44 0f 28 4c 24 40 48 83 c4 ? c3", 16, Vec::new()).unwrap().get_base_address();
    let igt_code_size = game_increment_igt_fn_address_end - game_increment_igt_fn_address;
    
    info!("game igt fn start at 0x{:x}, end at 0x{:x}, code size: {}", game_increment_igt_fn_address, game_increment_igt_fn_address_end, igt_code_size);

    //get the raw bytes of the IGT increment code, this function is protected by arxan
    let igt_code_slice: &[u8] = unsafe { slice::from_raw_parts(game_increment_igt_fn_address as *const u8, igt_code_size) };
    //info!("{:x?}", igt_code_slice);

    let game_increment_igt_callsite_address = process.scan_abs("call igt_fn", "85 ? 7f ? b2 ? 33 c9 e8 ? ? ? ? c6 83 ? ? ? ? ? f3 0f 10 47 ? e8", 25, Vec::new()).unwrap().get_base_address();
    info!("game_increment_igt_callsite_address 0x{:x}", game_increment_igt_callsite_address);

    //relocate igt function
    let copy_relocated_increment_igt_fn_address = Assembler::copy_relocate_fn_with_single_caller_x64(igt_code_slice, game_increment_igt_fn_address as u64, game_increment_igt_callsite_address as u64, false);
    info!("relocated igt fn at 0x{:x}", copy_relocated_increment_igt_fn_address);

    let igt_hook_offset = scan(igt_code_slice, &to_pattern("f3 48 0f 2c c0")).unwrap();
    unsafe { INCREMENT_IGT = Some(Hooker::new(copy_relocated_increment_igt_fn_address + igt_hook_offset, HookType::JmpBack(increment_igt_hook), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap()) };
}

unsafe extern "win64" fn increment_igt_hook(registers: *mut Registers, _:usize)
{
    let frame_delta = std::mem::transmute::<u32, f32>((*registers).xmm0 as u32);
    let mut corrected_frame_delta = frame_delta;

    //Rather than casting, like the game does, make the behavior explicit by flooring
    let floored_frame_delta = frame_delta.floor();
    let remainder = frame_delta - floored_frame_delta;
    IGT_BUFFER = IGT_BUFFER + remainder;

    if IGT_BUFFER > 1.0f32
    {
        IGT_BUFFER = IGT_BUFFER - 1f32;
        corrected_frame_delta += 1f32;
    }

    (*registers).xmm0 = std::mem::transmute::<f32, u32>(corrected_frame_delta) as u128;
    info!("frame delta: {} igt buffer: {} corrected frame delta: {}", frame_delta, IGT_BUFFER, corrected_frame_delta);
}