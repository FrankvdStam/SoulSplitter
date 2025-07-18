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

use std::{thread, time::Duration, fs};

use ilhook::x64::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};
use mem_rs::prelude::*;

use log::info;

use crate::util::GLOBAL_VERSION;


static mut FPS_HOOK: Option<HookPoint> = None;
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


        // AoB scan for FPS patch
        let fn_fps_address = process.scan_abs("fps", "f3 0f 10 88 68 02 00 00 48 8d 3d", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS at 0x{:x}", fn_fps_address);

        // AoB scan for FPS custom limit patch
        let fn_fps_custom_limit_address = process.scan_abs("fps custom limit", "48 8b c8 e8 ? ? ? ? 48 8b 05 ? ? ? ? 48 85 c0 75 26 4c 8d 0d ? ? ? ? 4c 8d 05 ? ? ? ? ba b1 00 00 00 48 8d 0d ? ? ? ? e8 ? ? ? ? 48 8b 05 ? ? ? ? f3 0f 10 88 68 02 00 00 48 8d 3d", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS custom limit at 0x{:x}", fn_fps_custom_limit_address);

        // AoB scan for frame advance patch
        let fn_frame_advance_address = process.scan_abs("frame_advance", "e8 ? ? ? ? 84 c0 74 41 90 48", 10, Vec::new()).unwrap().get_base_address();
        info!("Frame advance at 0x{:x}", fn_frame_advance_address);


        // Enable frame advance patch
        FRAME_ADVANCE_HOOK = Some(Hooker::new(fn_frame_advance_address, HookType::JmpBack(frame_advance), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


        // Temporarily turn on frame-advance while patching the FPS function..
        DS3_FRAME_ADVANCE_ENABLED = true;
        DS3_FRAME_RUNNING = true;

        while DS3_FRAME_RUNNING {
            thread::sleep(Duration::from_micros(10));
        }


        // Enable FPS patch
        FPS_HOOK = Some(Hooker::new(fn_fps_address, HookType::JmpBack(fps), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

        // Enable FPS custom limit patch
        FPS_CUSTOM_LIMIT_HOOK = Some(Hooker::new(fn_fps_custom_limit_address, HookType::JmpBack(fps_custom_limit), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


        // Turn off frame-advance again..
        DS3_FRAME_ADVANCE_ENABLED = false;
    }
}

// FPS patch
unsafe extern "win64" fn fps(registers: *mut Registers, _:usize)
{
    if DS3_FPS_PATCH_ENABLED
    {
        // Flipper struct: Contains all the stuff we need
        let ptr_flipper = (*registers).rax as *const u8;


        // Prepare some frametime values that will be used a few times
        let ptr_frametime = ptr_flipper.offset(0x18) as *mut f32;
        let frametime = std::ptr::read_volatile(ptr_frametime);
        let frametime_int = (frametime * 10000000.0) as i32;
        let frametime_truncated = (frametime_int as f32) / 10000000.0;
        let frametime_cursed = f32::from_bits(frametime_truncated.to_bits() + 0x1); // Idk why, but somehow that's needed.. Thanks fromsoft.


        // Timestamp values
        // Just grab the current one and set the previous one to that - target frametime
        let ptr_timestamp_previous = ptr_flipper.offset(0x20) as *mut u64;
        let ptr_timestamp_current = ptr_flipper.offset(0x28) as *mut u64;

        let timestamp_current = std::ptr::read_volatile(ptr_timestamp_current);
        std::ptr::write_volatile(ptr_timestamp_previous, timestamp_current - (frametime_int as u64));

        // A bunch of unknown timestamps that are somewhat close to the current timestamp..
        // ..so just set them to the current timestamp and hope it works out?
        for n in 0..6 {
            let ptr_timestamp_unknown = ptr_flipper.offset(0x30 + n * 0x8) as *mut u64;
            std::ptr::write_volatile(ptr_timestamp_unknown, timestamp_current);
        }


        // Frametime history
        for n in 0..32 {
            let ptr_frametime_history = ptr_flipper.offset(0x60 + n * 0x10) as *mut u64;
            std::ptr::write_volatile(ptr_frametime_history, frametime_int as u64);
        }
        

        // FPS
        let ptr_fps = ptr_flipper.offset(0x2bc) as *mut f32;
        std::ptr::write_volatile(ptr_fps, 1.0f32 / frametime_cursed);


        // Frametimes..
        let ptr_frametime_0x264 = ptr_flipper.offset(0x264) as *mut f32;
        let ptr_frametime_0x268 = ptr_flipper.offset(0x268) as *mut f32;
        let ptr_frametime_0x26c = ptr_flipper.offset(0x26c) as *mut f32;
        std::ptr::write_volatile(ptr_frametime_0x264, frametime_truncated);
        std::ptr::write_volatile(ptr_frametime_0x268, frametime_truncated);
        std::ptr::write_volatile(ptr_frametime_0x26c, frametime_cursed);

        // ..more frametimes..
        for n in 0..16 {
            let ptr_frametime_unknown = ptr_flipper.offset(0x27c + n * 0x4) as *mut f32;
            std::ptr::write_volatile(ptr_frametime_unknown, frametime_truncated);
        }

        // ..and EVEN MORE FRAMETIMES
        for n in 0..32 {
            let ptr_frametime_unknown = ptr_flipper.offset(0x2c4 + n * 0x4) as *mut f32;
            std::ptr::write_volatile(ptr_frametime_unknown, frametime_truncated);
        }

    }
}

// FPS custom limit patch
unsafe extern "win64" fn fps_custom_limit(registers: *mut Registers, _:usize)
{
    // Flipper struct: Contains all the stuff we need
    let ptr_flipper = (*registers).rax as *const u8;

    // Frame limitting modes: 5 by default, >5 works for manual control
    // "_alternative" might be used when a debug flag is enabled?
    let ptr_frame_mode = ptr_flipper.offset(0x8) as *mut u32;
    let ptr_frame_mode_alternative = ptr_flipper.offset(0xc) as *mut u32;
    let mut frame_mode = 5;

    if DS3_FPS_PATCH_ENABLED && DS3_FPS_CUSTOM_LIMIT > 0.0f32
    { 
        // Unknown values set by the FPS limitting function in default mode
        // Since the game doesn't set them with manual control, just do what the game would do by default
        let ptr_unknown_0x14 = ptr_flipper.offset(0x14) as *mut u8;
        let ptr_unknown_0x10 = ptr_flipper.offset(0x10) as *mut u32;
        let ptr_unknown_0x270 = ptr_flipper.offset(0x270) as *mut u64;

        // Target frame delta (FPS limit)
        let ptr_target_frame_delta = ptr_flipper.offset(0x18) as *mut f32;


        // Read the stock target frame delta and calculate the custom target frame delta
        let custom_target_frame_delta = 1.0f32 / DS3_FPS_CUSTOM_LIMIT;


        frame_mode = 99; // Anything >5 should work

        // Set unknown values to what the game would set them to
        std::ptr::write_volatile(ptr_unknown_0x14, 0);
        std::ptr::write_volatile(ptr_unknown_0x10, 1);
        std::ptr::write_volatile(ptr_unknown_0x270, 0);

        // Set target frame delta
        std::ptr::write_volatile(ptr_target_frame_delta, custom_target_frame_delta);
    }

    // Set frame limitting mode
    std::ptr::write_volatile(ptr_frame_mode, frame_mode);
    std::ptr::write_volatile(ptr_frame_mode_alternative, frame_mode);
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