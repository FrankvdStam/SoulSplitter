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



use std::{ptr, thread, time::Duration};

use ilhook::x64::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};
use mem_rs::prelude::*;

use log::info;

use crate::util::GLOBAL_VERSION;

static mut IGT_HOOK: Option<HookPoint> = None;
static mut FPS_HOOK: Option<HookPoint> = None;
static mut FPS_HISTORY_HOOK: Option<HookPoint> = None;
static mut FPS_CUSTOM_LIMIT_HOOK: Option<HookPoint> = None;
static mut FRAME_ADVANCE_HOOK: Option<HookPoint> = None;
static mut EMEVD_EVENT_HOOK: Option<HookPoint> = None;

#[allow(dead_code)]
static mut HANDLE_FADE_HOOK: Option<HookPoint> = None;

#[unsafe(no_mangle)]
#[used]
pub static mut SEKIRO_FPS_PATCH_ENABLED: bool = false;

#[unsafe(no_mangle)]
#[used]
pub static mut SEKIRO_FPS_CUSTOM_LIMIT: f32 = 0.0f32;

#[unsafe(no_mangle)]
#[used]
pub static mut SEKIRO_FRAME_ADVANCE_ENABLED: bool = false;

#[unsafe(no_mangle)]
#[used]
pub static mut SEKIRO_FRAME_RUNNING: bool = false;



pub static mut IGT_BUFFER: f32 = 0.0f32;

pub static mut FADE_MAN_ADDRESS: usize = 0usize;

#[allow(unused_assignments)]
pub fn init_sekiro()
{
    unsafe
    {
        info!("version: {}", GLOBAL_VERSION);
        
        // Get Sekiro process
        let mut process = Process::new_with_memory_type("sekiro.exe", MemoryType::Direct);
        process.refresh().unwrap();

        FADE_MAN_ADDRESS = process.scan_rel("fadeMan", "48 89 35 ? ? ? ? 48 8b c7 48 8b 4d 27 48 33 cc", 3, 7, Vec::new()).unwrap().get_base_address();
        info!("FadeMan at 0x{:x}", FADE_MAN_ADDRESS);
        
        let igt_increment_address = process.scan_abs("igt", "f3 48 0f 2c c0 01 81 9c 00 00 00 48 8b 05 ? ? ? ? 81 b8 9c 00 00 00 18 a0 93 d6 76 ? c7 80 9c 00 00 00 18 a0 93 d6", 0, Vec::new()).unwrap().get_base_address();
        info!("igt increment at 0x{:x}", igt_increment_address);
        IGT_HOOK = Some(Hooker::new(igt_increment_address, HookType::JmpBack(increment_igt_hook_fn), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

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
        let fn_fps_custom_limit_address = process.scan_abs("fps custom limit", "e8 ? ? ? ? 84 c0 74 0a c7 83 74 02 00 00 1e 00 00 00", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS custom limit at 0x{:x}", fn_fps_custom_limit_address);

        // Enable FPS custom limit patch
        FPS_CUSTOM_LIMIT_HOOK = Some(Hooker::new(fn_fps_custom_limit_address, HookType::JmpBack(fps_custom_limit), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
    

        // AoB scan for frame advance patch
        let fn_frame_advance_address = process.scan_abs("frame_advance", "e8 ? ? ? ? 84 c0 74 4e 66 0f 1f 44 00 00", 15, Vec::new()).unwrap().get_base_address();
        info!("Frame advance at 0x{:x}", fn_frame_advance_address);

        // Enable frame advance patch
        FRAME_ADVANCE_HOOK = Some(Hooker::new(fn_frame_advance_address, HookType::JmpBack(frame_advance), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

        let emevd_events_address = process.scan_abs("emevd_events", "24 20 fe ff ff ff 0f 29 b4 24 30 01 00 00", 0, Vec::new()).unwrap().get_base_address() - 14;
        info!("emevd at 0x{:x}", emevd_events_address);
        EMEVD_EVENT_HOOK = Some(Hooker::new(emevd_events_address, HookType::JmpBack(emevd_event_hook_fn), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

        //HANDLE_FADE_HOOK = Some(Hooker::new(0x140f26ed0, HookType::JmpBack(handle_fade_hook_fn), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
    }
}

#[allow(dead_code)]
unsafe extern "win64" fn handle_fade_hook_fn(registers: *mut Registers, _:usize)
{
    unsafe
    {
        let fade_plate_ptr = (*registers).rcx;
        let remo_related_ptr = (*registers).rdx;
        let fd4time_ptr = (*registers).r8;

        info!("{} {} {}", fade_plate_ptr, remo_related_ptr, fd4time_ptr);

        let time = ptr::read((fd4time_ptr + 0x8) as *const f32);
        let remote_related_time = ptr::read((remo_related_ptr) as *const f32);
        let fade_plate_time = ptr::read((fade_plate_ptr + 0x38) as *const f32);

        info!("{} {} {}", time, remote_related_time, fade_plate_time);
    }
}

//igt fix
pub unsafe extern "win64" fn increment_igt_hook_fn(registers: *mut Registers, _:usize)
{
    unsafe
    {
        if FADE_MAN_ADDRESS != 0
        {
            let fade_man1 = ptr::read(FADE_MAN_ADDRESS as *const usize);
            let fade_man2 = ptr::read((fade_man1 + 0x8) as *const usize);
            let fading = ptr::read((fade_man2 + 0x2dc) as *const i32);
            if fading != 0
            {
                (*registers).xmm0 = std::mem::transmute::<f32, u32>(0f32) as u128;
            }
            //info!("0x{:x} 0x{:x} 0x{:x} - {}", FADE_MAN_ADDRESS, fade_man1, fade_man2, fading);
        }

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
        //info!("frame delta: {} igt buffer: {} corrected frame delta: {}", frame_delta, IGT_BUFFER, corrected_frame_delta);
    }
}


// FPS patch
// Sets the calculated frame delta to always be the target frame delta.
// It also sets the previous frames timestamp to be the current one minus the target frame delta.
// This makes it so the game always behaves as if it's running at the FPS limit, with slowdowns if the PC can't keep up.
// A second patch, "FPS history" below, is required in addition to this one to ensure accuracy.
unsafe extern "win64" fn fps(registers: *mut Registers, _:usize)
{
    unsafe
    {
        if SEKIRO_FPS_PATCH_ENABLED
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
}

// FPS history patch
// Similar to the FPS patch, this sets the difference between the previous and current frames timestamps to the target frame delta.
// This gets stored in an array with 32 elements, possibly for calculating FPS averages.
unsafe extern "win64" fn fps_history(registers: *mut Registers, _:usize)
{
    unsafe
    {
        if SEKIRO_FPS_PATCH_ENABLED
        {
            let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

            let ptr_target_frame_delta = ptr_flipper.offset(0x18) as *mut f32; // Target frame delta - Set in a switch/case at the start

            // Read the target frame delta and write back the calculated frame delta timestamp
            let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
            (*registers).rax = (target_frame_delta * 10000000.0) as u64;
        }
    }
}

// FPS custom limit patch
// This patch adjusts the target frame delta based on a custom set FPS limit.
// It is only active while the FPS patch is enabled too, and uses the default value if it's set to 0 or less.
// This does not allow you to go above the stock FPS limit. It is purely a QoL patch to improve glitch consistency, not an FPS unlocker.
unsafe extern "win64" fn fps_custom_limit(registers: *mut Registers, _:usize)
{
    unsafe
    {
        if SEKIRO_FPS_PATCH_ENABLED && SEKIRO_FPS_CUSTOM_LIMIT > 0.0f32
        {
            let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

            let ptr_target_frame_delta = ptr_flipper.offset(0x18) as *mut f32; // Target frame delta - Set in a switch/case at the start

            // Read the stock target frame delta and calculate the custom target frame delta
            let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
            let custom_target_frame_delta = 1.0f32 / SEKIRO_FPS_CUSTOM_LIMIT;

            // Make sure the custom target frame delta is higher than the stock one, in order to avoid going above the stock FPS limit
            if custom_target_frame_delta > target_frame_delta
            {
                // Write values back
                std::ptr::write_volatile(ptr_target_frame_delta, custom_target_frame_delta);
            }
        }
    }
}

// Frame advance patch
unsafe extern "win64" fn frame_advance(_registers: *mut Registers, _:usize)
{
    unsafe
    {
        if SEKIRO_FRAME_ADVANCE_ENABLED
        {
            SEKIRO_FRAME_RUNNING = false;

            while !SEKIRO_FRAME_RUNNING && SEKIRO_FRAME_ADVANCE_ENABLED {
                thread::sleep(Duration::from_micros(10));
            }
        }
    }
}


#[unsafe(no_mangle)]
#[used]
pub static mut SEKIRO_DISABLE_CUTSCENES_ENABLED: bool = false;

unsafe extern "win64" fn emevd_event_hook_fn(registers: *mut Registers, _:usize)
{
    unsafe
    {
        if !SEKIRO_DISABLE_CUTSCENES_ENABLED
        {
            return;
        }

        let sprj_emk_event_ins_ptr = (*registers).r8;
        let event_type_ptr = ptr::read((sprj_emk_event_ins_ptr + 0xb0) as *const u64);
        let event_group = ptr::read(event_type_ptr as *const u64) as u32;
        let event_type = ptr::read((event_type_ptr + 0x4) as *const u64) as u32;
        let event_id = ptr::read((sprj_emk_event_ins_ptr + 0x28) as *const u64) as u32;
        let arg_struct_ptr = ptr::read((sprj_emk_event_ins_ptr + 0xb8) as *const u64);

        //if arg struct ptr is null, it is impossible to overwrite arguments
        if arg_struct_ptr == 0
        {
            return;
        }

        //SetMenuFade
        if event_group == 2003 && event_type == 82
        {
            info!("{} {} {}, SetMenuFade - replacing with ClearSpEffect", event_group, event_type, event_id);
            ptr::write((event_type_ptr + 0x0) as *mut *const u64, 2004 as *const u64);
            ptr::write((event_type_ptr + 0x4) as *mut *const u64, 21 as *const u64);
            ptr::write((arg_struct_ptr + 0x0) as *mut *const u32, 10000 as *const u32);
            ptr::write((arg_struct_ptr + 0x4) as *mut *const u32, 4700 as *const u32);
        }

        if event_group == 2002 && (
            event_type == 1  || //PlayCutsceneToAll
            event_type == 3  || //PlayCutsceneToPlayer
            event_type == 04 || //PlayCutsceneAndWarpPlayer
            event_type == 13    //PlayCutsceneAndWarpPlayerWithLighting200213
        )
        {
            info!("{} {} {} - replacing cutscene ID", event_group, event_type, event_id);
            ptr::write((arg_struct_ptr + 0x0) as *mut *const i32, 1 as *const i32);
        }
    }
}
