use std::thread;
use std::time::Duration;
use ilhook::x64::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};
use mem_rs::prelude::*;
use log::info;

use crate::util::GLOBAL_VERSION;

static mut FPS_HOOK: Option<HookPoint> = None;
static mut FPS_HISTORY_HOOK: Option<HookPoint> = None;
static mut FPS_CUSTOM_LIMIT_HOOK: Option<HookPoint> = None;
static mut FRAME_ADVANCE_HOOK: Option<HookPoint> = None;


#[unsafe(no_mangle)]
#[used]
pub static mut NR_FPS_PATCH_ENABLED: bool = false;

#[unsafe(no_mangle)]
#[used]
pub static mut NR_FPS_CUSTOM_LIMIT: f32 = 0.0f32;

#[unsafe(no_mangle)]
#[used]
pub static mut NR_FRAME_ADVANCE_ENABLED: bool = false;

#[unsafe(no_mangle)]
#[used]
pub static mut NR_FRAME_RUNNING: bool = false;

static mut IGT_BUFFER: f32 = 0.0f32;
static mut IGT_HOOK: Option<HookPoint> = None;

pub fn init_nightreign()
{
    unsafe
    {
        info!("version: {}", GLOBAL_VERSION);
        let mut process = Process::new_with_memory_type("nightreign.exe", MemoryType::Direct);
        process.refresh().unwrap();

        let fn_increment_igt_address = process.scan_abs("increment igt", "f3 0f 59 05 48 fd 01 03 48 8b 0d ? ? ? ? f3 48 0f 2c c0", 8, Vec::new()).unwrap().get_base_address();
        info!("increment IGT at 0x{:x}", fn_increment_igt_address);
        
        IGT_HOOK = Some(Hooker::new(fn_increment_igt_address, HookType::JmpBack(increment_igt_hook), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

        // AoB scan for FPS patch
        let fn_fps_address = process.scan_abs("fps", "f3 0f 10 83 6c 02 00 00 f3 0f 11 83 bc 02 00 00", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS at 0x{:x}", fn_fps_address);

        // Enable FPS patch
        FPS_HOOK = Some(Hooker::new(fn_fps_address, HookType::JmpBack(fps), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

        // AoB scan for FPS history patch
        let fn_fps_history_address = process.scan_abs("fps history", "48 89 44 cb 68 0f b6 83 7c 02 00 00 89 44 cb 70", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS history at 0x{:x}", fn_fps_history_address);

        // Enable FPS history patch
        FPS_HISTORY_HOOK = Some(Hooker::new(fn_fps_history_address, HookType::JmpBack(fps_history), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());

        // AoB scan for FPS custom limit patch
        let fn_fps_custom_limit_address = process.scan_abs("fps custom limit", "45 0f 57 f6 40 38 bb d8 02 00 00", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS custom limit at 0x{:x}", fn_fps_custom_limit_address);

        // Enable FPS custom limit patch
        FPS_CUSTOM_LIMIT_HOOK = Some(Hooker::new(fn_fps_custom_limit_address, HookType::JmpBack(fps_custom_limit), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


        // AoB scan for frame advance patch
        let fn_frame_advance_address = process.scan_abs("frame_advance", "e8 ? ? ? ? e8 ? ? ? ? 84 c0 74 4f", 21, Vec::new()).unwrap().get_base_address();
        info!("Frame advance at 0x{:x}", fn_frame_advance_address);

        // Enable frame advance patch
        FRAME_ADVANCE_HOOK = Some(Hooker::new(fn_frame_advance_address, HookType::JmpBack(frame_advance), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
    }
}

unsafe extern "win64" fn increment_igt_hook(registers: *mut Registers, _:usize)
{
    unsafe
    {
        let frame_delta = std::mem::transmute::<u32, f32>((*registers).xmm0 as u32);
        let mut corrected_frame_delta = frame_delta;
        corrected_frame_delta = corrected_frame_delta * 0.96f32; //scale to igt

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
        if NR_FPS_PATCH_ENABLED
        {
            let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

            let ptr_target_frame_delta = ptr_flipper.offset(0x20) as *mut f32; // Target frame delta - Set in a switch/case at the start
            let ptr_timestamp_previous = ptr_flipper.offset(0x28) as *mut u64; // Previous frames timestamp
            let ptr_timestamp_current = ptr_flipper.offset(0x30) as *mut u64; // Current frames timestamp
            let ptr_frame_delta = ptr_flipper.offset(0x26c) as *mut f32; // Current frames frame delta

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
}

// FPS history patch
// Similar to the FPS patch, this sets the difference between the previous and current frames timestamps to the target frame delta.
// This gets stored in an array with 32 elements, possibly for calculating FPS averages.
unsafe extern "win64" fn fps_history(registers: *mut Registers, _:usize)
{
    unsafe
    {
        if NR_FPS_PATCH_ENABLED
        {
            let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

            let ptr_target_frame_delta = ptr_flipper.offset(0x20) as *mut f32; // Target frame delta - Set in a switch/case at the start

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
        if NR_FPS_PATCH_ENABLED && NR_FPS_CUSTOM_LIMIT > 0.0f32
        {
            let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

            let ptr_target_frame_delta = ptr_flipper.offset(0x20) as *mut f32; // Target frame delta - Set in a switch/case at the start

            // Read the stock target frame delta and calculate the custom target frame delta
            let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
            let custom_target_frame_delta = 1.0f32 / NR_FPS_CUSTOM_LIMIT;

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
        if NR_FRAME_ADVANCE_ENABLED
        {
            NR_FRAME_RUNNING = false;

            while !NR_FRAME_RUNNING && NR_FRAME_ADVANCE_ENABLED {
                thread::sleep(Duration::from_micros(10));
            }
        }
    }
}