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

use ilhook::x64::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};
use mem_rs::prelude::*;
use log::info;
use crate::util::GLOBAL_VERSION;
use crate::util::Version;

struct FpsOffsets
{
    target_frame_delta: isize,
    frame_delta: isize,
    timestamp_previous: isize,
    timestamp_current: isize,
    timestamp_history: isize,
}

static mut IGT_BUFFER: f32 = 0.0f32;
static mut IGT_HOOK: Option<HookPoint> = None;

static mut FPS_HOOK: Option<HookPoint> = None;
static mut FPS_HISTORY_HOOK: Option<HookPoint> = None;
static mut FPS_CUSTOM_LIMIT_HOOK: Option<HookPoint> = None;

static mut FPS_HOOK_ENABLED: bool = false;
static mut FPS_CUSTOM_LIMIT: f32 = 0.0f32;

static mut FPS_OFFSETS: FpsOffsets = FpsOffsets {
    target_frame_delta: 0x0,
    frame_delta: 0x0,
    timestamp_previous: 0x0,
    timestamp_current: 0x0,
    timestamp_history: 0x0,
};


#[allow(unused_assignments)]
pub fn init_eldenring()
{
    unsafe
    {
        info!("version: {}", GLOBAL_VERSION);
		
		// Get ER process
        let mut process = Process::new("eldenring.exe");
        process.refresh().unwrap();

        // AoB scan for timer patch
        let fn_increment_igt_address = process.scan_abs("increment igt", "48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0 48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d ? ? ? ?", 35, Vec::new()).unwrap().get_base_address();
        info!("increment IGT at 0x{:x}", fn_increment_igt_address);

        // Enable timer patch
        IGT_HOOK = Some(Hooker::new(fn_increment_igt_address, HookType::JmpBack(increment_igt), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

        // AoBs for FPS patches
        let mut fps_aob = "";
        let mut fps_history_aob = "";
        let mut fps_custom_limit_aob = "";

        // Adjust AoBs and offsets for FPS patch based on version
        // The relevant function was adjusted slightly with the release of the DLC
        if (GLOBAL_VERSION > Version { major: 2, minor: 0, build: 1, revision: 0 })
        {
            info!("Post-DLC version detected.");

            FPS_OFFSETS = FpsOffsets {
                target_frame_delta: 0x1c,
                frame_delta: 0x264,
                timestamp_previous: 0x20,
                timestamp_current: 0x28,
                timestamp_history: 0x0,
            };

            fps_aob = "8b 83 64 02 00 00 89 83 b4 02 00 00";
            fps_history_aob = "0f b6 83 74 02 00 00 89 44 cb 08";
            fps_custom_limit_aob = "0F 57 F6 44 38 BB D0 02 00 00";
        }
        else
        {
            info!("Pre-DLC version detected.");

            FPS_OFFSETS = FpsOffsets {
                target_frame_delta: 0x20,
                frame_delta: 0x26c,
                timestamp_previous: 0x28,
                timestamp_current: 0x30,
                timestamp_history: 0x68,
            };

            fps_aob = "8b 83 6c 02 00 00 89 83 bc 02 00 00";
            fps_history_aob = "0f b6 83 7c 02 00 00 89 44 cb 70";
            fps_custom_limit_aob = "0F 57 F6 44 38 BB D8 02 00 00";
        }

        // AoB scan for FPS patch
        let fn_fps_address = process.scan_abs("fps", fps_aob, 0, Vec::new()).unwrap().get_base_address();
        info!("FPS at 0x{:x}", fn_fps_address);

        // Enable FPS patch
        FPS_HOOK = Some(Hooker::new(fn_fps_address, HookType::JmpBack(fps), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

        // AoB scan for FPS history patch
        let fn_fps_history_address = process.scan_abs("fps history", fps_history_aob, 0, Vec::new()).unwrap().get_base_address();
        info!("FPS history at 0x{:x}", fn_fps_history_address);

        // Enable FPS history patch
        FPS_HISTORY_HOOK = Some(Hooker::new(fn_fps_history_address, HookType::JmpBack(fps_history), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

        // AoB scan for FPS custom limit patch
        let fn_fps_custom_limit_address = process.scan_abs("fps custom limit", fps_custom_limit_aob, 0, Vec::new()).unwrap().get_base_address();
        info!("FPS custom limit at 0x{:x}", fn_fps_custom_limit_address);

        // Enable FPS custom limit patch
        FPS_CUSTOM_LIMIT_HOOK = Some(Hooker::new(fn_fps_custom_limit_address, HookType::JmpBack(fps_custom_limit), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
    }
}

#[no_mangle]
pub extern "C" fn fps_patch_disable() // Disables FPS patch
{
    unsafe
    {
        FPS_HOOK_ENABLED = false;
    }
}

#[no_mangle]
pub extern "C" fn fps_patch_enable() // Enables FPS patch
{
    unsafe
    {
        FPS_HOOK_ENABLED = true;
    }
}

#[no_mangle]
pub extern "C" fn fps_patch_toggle() // Toggles FPS patch
{
    unsafe
    {
        FPS_HOOK_ENABLED = !FPS_HOOK_ENABLED;
    }
}


unsafe extern "win64" fn increment_igt(registers: *mut Registers, _:usize)
{
    let mut frame_delta = std::mem::transmute::<u32, f32>((*registers).xmm0 as u32);
    //convert to milliseconds
    frame_delta = frame_delta * 1000f32;
    frame_delta = frame_delta * 0.96f32; //scale to IGT

    //Rather than casting, like the game does, make the behavior explicit by flooring
    let mut floored_frame_delta = frame_delta.floor();
    let remainder = frame_delta - floored_frame_delta;
    IGT_BUFFER = IGT_BUFFER + remainder;

    if IGT_BUFFER > 1.0f32
    {
        IGT_BUFFER = IGT_BUFFER - 1f32;
        floored_frame_delta += 1f32;
    }

    (*registers).xmm1 = std::mem::transmute::<f32, u32>(floored_frame_delta) as u128;
}

// FPS patch
// Sets the calculated frame delta to always be the target frame delta.
// It also sets the previous frames timestamp to be the current one minus the target frame delta.
// This makes it so the game always behaves as if it's running at the FPS limit, with slowdowns if the PC can't keep up.
// A second patch, "FPS history" below, is required in addition to this one to ensure accuracy.
unsafe extern "win64" fn fps(registers: *mut Registers, _:usize)
{
    if FPS_HOOK_ENABLED
    {
        let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

        let ptr_target_frame_delta = ptr_flipper.offset(FPS_OFFSETS.target_frame_delta) as *mut f32; // Target frame delta - Set in a switch/case at the start
        let ptr_timestamp_previous = ptr_flipper.offset(FPS_OFFSETS.timestamp_previous) as *mut u64; // Previous frames timestamp
        let ptr_timestamp_current = ptr_flipper.offset(FPS_OFFSETS.timestamp_current) as *mut u64; // Current frames timestamp
        let ptr_frame_delta = ptr_flipper.offset(FPS_OFFSETS.frame_delta) as *mut f32; // Current frames frame delta

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
    }
}

// FPS history patch
// Similar to the FPS patch, this sets the difference between the previous and current frames timestamps to the target frame delta.
// This gets stored in an array with 32 elements, possibly for calculating FPS averages.
unsafe extern "win64" fn fps_history(registers: *mut Registers, _:usize)
{
    if FPS_HOOK_ENABLED
    {
        let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

        let ptr_target_frame_delta = ptr_flipper.offset(FPS_OFFSETS.target_frame_delta) as *mut f32; // Target frame delta - Set in a switch/case at the start
        let ptr_frame_delta_history = ptr_flipper.offset((*registers).rcx as isize * 0x8 + FPS_OFFSETS.timestamp_history) as *mut u64; // Frame delta history - In an array of 32, with the index incrementing each frame

        // Read the target frame delta and calculate the frame delta timestamp
        let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
        let target_frame_delta_history = (target_frame_delta * 10000000.0) as u64;

        // Write values back
        std::ptr::write_volatile(ptr_frame_delta_history, target_frame_delta_history);
    }
}

// FPS custom limit patch
// This patch adjusts the target frame delta based on a custom set FPS limit.
// It is only active while the FPS patch is enabled too, and uses the default value if it's set to 0 or less.
// This does not allow you to go above the stock FPS limit. It is purely a QoL patch to improve glitch consistency, not an FPS unlocker.
unsafe extern "win64" fn fps_custom_limit(registers: *mut Registers, _:usize)
{
    if FPS_HOOK_ENABLED && FPS_CUSTOM_LIMIT > 0.0f32
    {
        let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

        let ptr_target_frame_delta = ptr_flipper.offset(FPS_OFFSETS.target_frame_delta) as *mut f32; // Target frame delta - Set in a switch/case at the start

        // Read the stock target frame delta and calculate the custom target frame delta
        let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
        let custom_target_frame_delta = 1.0f32 / FPS_CUSTOM_LIMIT;

        // Make sure the custom target frame delta is higher than the stock one, in order to avoid going above the stock FPS limit
        if custom_target_frame_delta > target_frame_delta
        {
            // Write values back
            std::ptr::write_volatile(ptr_target_frame_delta, custom_target_frame_delta);
        }
    }
}