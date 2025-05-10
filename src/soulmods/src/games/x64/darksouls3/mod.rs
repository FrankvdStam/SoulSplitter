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

mod migt;

#[allow(dead_code)]

use mem_rs::prelude::*;
use std::{thread, time::Duration};
use ilhook::x64::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};

use log::info;
use crate::games::x64::darksouls3::migt::ds3_init_migt;
use crate::util::*;

static mut FPS_HOOK: Option<HookPoint> = None;
static mut FPS_HISTORY_HOOK: Option<HookPoint> = None;
static mut FPS_CUSTOM_LIMIT_HOOK: Option<HookPoint> = None;
static mut FRAME_ADVANCE_HOOK: Option<HookPoint> = None;


#[no_mangle]
#[used]
pub static mut DS3_FPS_PATCH_ENABLED: bool = false;

#[no_mangle]
#[used]
pub static mut DS3_FPS_CUSTOM_LIMIT: f32 = 0.0f32;

#[no_mangle]
#[used]
pub static mut DS3_FRAME_ADVANCE_ENABLED: bool = false;

#[no_mangle]
#[used]
pub static mut DS3_FRAME_RUNNING: bool = false;




#[allow(unused_assignments)]
pub fn init_darksouls3()
{
    unsafe
        {
            info!("version: {}", GLOBAL_VERSION);

            // Get DS3 process
            let mut process = Process::new("darksoulsiii.exe");
            process.refresh().unwrap();

            ds3_init_migt(&process);

            // AoB scan for FPS patch
            let fn_fps_address = process.scan_abs("fps", "f3 0f 58 93 64 02 00 00 41 0f 2f d4", 0, Vec::new()).unwrap().get_base_address();
            info!("FPS at 0x{:x}", fn_fps_address);

            // Enable FPS patch
            FPS_HOOK = Some(Hooker::new(fn_fps_address, HookType::JmpBack(fps), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


            // AoB scan for FPS history patch
            let fn_fps_history_address = process.scan_abs("fps history", "48 89 04 cb 0f b6 83 78 02 00 00", 0, Vec::new()).unwrap().get_base_address();
            info!("FPS history at 0x{:x}", fn_fps_history_address);

            // Enable FPS history patch
            FPS_HISTORY_HOOK = Some(Hooker::new(fn_fps_history_address, HookType::JmpBack(fps_history), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


            // AoB scan for FPS custom limit patch
            let fn_fps_custom_limit_address = process.scan_abs("fps custom limit", "f3 44 0f 10 2d ? ? ? ? 44 38 a3 58 03 00 00", 0, Vec::new()).unwrap().get_base_address();
            info!("FPS custom limit at 0x{:x}", fn_fps_custom_limit_address);

            // Enable FPS custom limit patch
            FPS_CUSTOM_LIMIT_HOOK = Some(Hooker::new(fn_fps_custom_limit_address, HookType::JmpBack(fps_custom_limit), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


            // AoB scan for frame advance patch
            let fn_frame_advance_address = process.scan_abs("frame_advance", "e8 ? ? ? ? 84 c0 74 41 90 48", 10, Vec::new()).unwrap().get_base_address();
            info!("Frame advance at 0x{:x}", fn_frame_advance_address);

            // Enable frame advance patch
            FRAME_ADVANCE_HOOK = Some(Hooker::new(fn_frame_advance_address, HookType::JmpBack(frame_advance), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
        }
}

// FPS patch
// Sets the calculated frame delta to always be the target frame delta.
// It also sets the previous frames timestamp to be the current one minus the target frame delta.
// This makes it so the game always behaves as if it's running at the FPS limit, with slowdowns if the PC can't keep up.
// A second patch, "FPS history" below, is required in addition to this one to ensure accuracy.
unsafe extern "win64" fn fps(registers: *mut Registers, _:usize)
{
    if DS3_FPS_PATCH_ENABLED
    {
        let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

        let ptr_target_frame_delta = ptr_flipper.offset(0x18) as *mut f32; // Target frame delta - Set in a switch/case at the start
        let ptr_timestamp_previous = ptr_flipper.offset(0x20) as *mut u64; // Previous frames timestamp
        let ptr_timestamp_current = ptr_flipper.offset(0x28) as *mut u64; // Current frames timestamp
        let ptr_frame_delta = ptr_flipper.offset(0x264) as *mut f32; // Current frames frame delta
        let ptr_frame_delta_copy = ptr_flipper.offset(0x2b8) as *mut f32; // Current frames frame delta - Copy that's assigned differently than in ER, so we assign it manually too

        // Read target frame data, the current timestamp and then calculate the timestamp diff at stable FPS
        let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
        let timestamp_current = std::ptr::read_volatile(ptr_timestamp_current);
        let timestamp_diff = (target_frame_delta * 10000000.0) as i32;

        // Calculate the previous timestamp, as well as the frame delta
        let timestamp_previous = timestamp_current - (timestamp_diff as u64);
        let frame_delta = (timestamp_diff as f32) / 10000000.0;

        // Write values back
        std::ptr::write_volatile(ptr_timestamp_previous, timestamp_previous);
        std::ptr::write_volatile(ptr_frame_delta, frame_delta);
        std::ptr::write_volatile(ptr_frame_delta_copy, frame_delta);
    }
}


// FPS history patch
// Similar to the FPS patch, this sets the difference between the previous and current frames timestamps to the target frame delta.
// This gets stored in an array with 32 elements, possibly for calculating FPS averages.
unsafe extern "win64" fn fps_history(registers: *mut Registers, _:usize)
{
    if DS3_FPS_PATCH_ENABLED
    {
        let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

        let ptr_target_frame_delta = ptr_flipper.offset(0x18) as *mut f32; // Target frame delta - Set in a switch/case at the start

        // Read the target frame delta and write back the calculated frame delta timestamp
        let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
        (*registers).rax = (target_frame_delta * 10000000.0) as u64;
    }
}

// FPS custom limit patch
// This patch adjusts the target frame delta based on a custom set FPS limit.
// It is only active while the FPS patch is enabled too, and uses the default value if it's set to 0 or less.
// This does not allow you to go above the stock FPS limit. It is purely a QoL patch to improve glitch consistency, not an FPS unlocker.
unsafe extern "win64" fn fps_custom_limit(registers: *mut Registers, _:usize)
{
    if DS3_FPS_PATCH_ENABLED && DS3_FPS_CUSTOM_LIMIT > 0.0f32
    {
        let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

        let ptr_target_frame_delta = ptr_flipper.offset(0x18) as *mut f32; // Target frame delta - Set in a switch/case at the start

        // Read the stock target frame delta and calculate the custom target frame delta
        let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
        let custom_target_frame_delta = 1.0f32 / DS3_FPS_CUSTOM_LIMIT;

        // Make sure the custom target frame delta is higher than the stock one, in order to avoid going above the stock FPS limit
        if custom_target_frame_delta > target_frame_delta
        {
            // Write values back
            std::ptr::write_volatile(ptr_target_frame_delta, custom_target_frame_delta);
        }
    }
}

// Frame advance patch
unsafe extern "win64" fn frame_advance(_registers: *mut Registers, _:usize)
{
    if DS3_FRAME_ADVANCE_ENABLED
    {
        DS3_FRAME_RUNNING = false;

        while !DS3_FRAME_RUNNING && DS3_FRAME_ADVANCE_ENABLED {
            thread::sleep(Duration::from_micros(10));
        }
    }
}