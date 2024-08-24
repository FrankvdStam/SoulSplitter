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

static mut IGT_BUFFER: f32 = 0.0f32;
static mut IGT_HOOK: Option<HookPoint> = None;

static mut FPS_HOOK: Option<HookPoint> = None;
static mut FPS_HISTORY_HOOK: Option<HookPoint> = None;


#[allow(unused_assignments)]
pub fn init_eldenring()
{
    unsafe
    {
        // Get ER process
        let mut process = Process::new("eldenring.exe");
        process.refresh().unwrap();

        // AoB scan for timer patch
        let fn_increment_igt_address = process.scan_abs("increment igt", "48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0 48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d ? ? ? ?", 35, Vec::new()).unwrap().get_base_address();
        info!("increment IGT at 0x{:x}", fn_increment_igt_address);

        // Timer patch
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

        // Enable timer patch
        IGT_HOOK = Some(Hooker::new(fn_increment_igt_address, HookType::JmpBack(increment_igt), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


        // AoB scan for FPS patch
        let fn_fps_address = process.scan_abs("fps", "8b 83 64 02 00 00 89 83 b4 02 00 00", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS at 0x{:x}", fn_fps_address);

        // FPS patch
        // Sets the calculated frame delta to always be the target frame delta.
        // It also sets the previous frames timestamp to be the current one minus the target frame delta.
        // This makes it so the game always behaves as if it's running at the FPS limit, with slowdowns if the PC can't keep up.
        // A second patch, "FPS history" below, is required in addition to this one to ensure accuracy.
        unsafe extern "win64" fn fps(registers: *mut Registers, _:usize)
        {
            let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

            let ptr_target_frame_delta = ptr_flipper.offset(0x1c) as *mut f32; // Target frame delta - Set in a switch/case at the start
            let ptr_timestamp_previous = ptr_flipper.offset(0x20) as *mut i64; // Previous frames timestamp
            let ptr_timestamp_current = ptr_flipper.offset(0x28) as *mut i64; // Current frames timestamp
            let ptr_frame_delta = ptr_flipper.offset(0x264) as *mut f32; // Current frames frame delta

            // Read target frame data, the current timestamp and then calculate the timestamp diff at stable FPS
            let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
            let timestamp_current = std::ptr::read_volatile(ptr_timestamp_current);
            let timestamp_diff = (target_frame_delta * 10000000.0) as i32;

            // Calculate the previous timestamp, as well as the frame delta
            let timestamp_previous = timestamp_current - (timestamp_diff as i64);
            let frame_delta = (timestamp_diff as f32) / 10000000.0;

            // Write values back
            std::ptr::write_volatile(ptr_timestamp_previous, timestamp_previous);
            std::ptr::write_volatile(ptr_frame_delta, frame_delta);
        }

        // Enable FPS patch
        FPS_HOOK = Some(Hooker::new(fn_fps_address, HookType::JmpBack(fps), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());


        // AoB scan for FPS history patch
        let fn_fps_history_address = process.scan_abs("fps history", "48 89 04 cb 0f b6 83 74 02 00 00", 0, Vec::new()).unwrap().get_base_address();
        info!("FPS history at 0x{:x}", fn_fps_history_address);

        // FPS history patch
        // Similar to the FPS patch, this sets the difference between the previous and current frames timestamps to the target frame delta.
        // This gets stored in an array with 32 elements, possibly for calculating FPS averages.
        unsafe extern "win64" fn fps_history(registers: *mut Registers, _:usize)
        {
            let ptr_flipper = (*registers).rbx as *const u8; // Flipper struct - Contains all the stuff we need

            let ptr_target_frame_delta = ptr_flipper.offset(0x1c) as *mut f32; // Target frame delta - Set in a switch/case at the start
            let ptr_frame_delta_history = ptr_flipper.offset(((*registers).rcx as u32 * 8) as isize) as *mut u64; // Frame delta history - In an array of 32, with the index incrementing each frame

            // Read the target frame delta and calculate the frame delta timestamp
            let target_frame_delta = std::ptr::read_volatile(ptr_target_frame_delta);
            let target_frame_delta_history = (target_frame_delta * 10000000.0) as u64;

            // Write values back
            std::ptr::write_volatile(ptr_frame_delta_history, target_frame_delta_history);
        }

        // Enable FPS history patch
        FPS_HISTORY_HOOK = Some(Hooker::new(fn_fps_history_address, HookType::JmpBack(fps_history), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
    }
}

pub fn calculate_igt_corrections(mut frame_delta: f32, igt_frac: &mut f32) -> f32
{
    //convert to milliseconds
    frame_delta = frame_delta * 1000f32;
    //frame_delta = frame_delta * 0.96f32; //scale to IGT

    //Rather than casting, like the game does, make the behavior explicit by flooring
    let mut floored_frame_delta = frame_delta.floor();
    let remainder = frame_delta - floored_frame_delta;
    *igt_frac = *igt_frac + remainder;

    if *igt_frac > 1.0f32
    {
        *igt_frac = *igt_frac - 1f32;
        floored_frame_delta += 1f32;
    }

    //convert back to seconds
    floored_frame_delta = floored_frame_delta / 1000f32;
    return floored_frame_delta;

    //(*registers).xmm0 = std::mem::transmute::<f32, u32>(floored_frame_delta) as u128;

}

#[cfg(test)]
mod tests
{
    #[allow(dead_code)]
    use std::time::Duration;
    use crate::util::DurationExt;
    use super::*;

    fn run_igt(iterations: usize, frame_delta: f32) -> u32
    {
        let mut igt_frac = 0.0f32;
        let mut igt = 0;

        for _ in 0..iterations
        {
            let corrected_frame_delta = calculate_igt_corrections(frame_delta, &mut igt_frac);
            let truncated = (corrected_frame_delta * 1000f32).floor() as u32;
            igt = igt + truncated;
            //println!("{} {} {} {}", corrected_frame_delta, truncated, igt, igt_frac);
        }

        return igt;
    }



    fn test(name: &str, rta: Duration, igt: Duration, framerate: f32)
    {
        let frame_delta_millis = 1000f32 / framerate;

        let measured_elapsed_millis = rta.as_millis();
        let elapsed_frames = (measured_elapsed_millis as f32 / frame_delta_millis) as usize;

        let result = run_igt(elapsed_frames, frame_delta_millis / 1000f32);
        let calculated_igt = Duration::from_millis(result as u64);

        println!("name: {}", name);
        println!("frame_delta_millis {}", frame_delta_millis);
        println!("elapsed_frames {}", elapsed_frames);
        println!("result IGT: {}", result);

        println!("Measured   RTA: {:?}", rta);
        println!("calculated igt: {:?}", calculated_igt);
        println!("ratio1        : {:?}", calculated_igt.as_millis() as f32 / rta.as_millis() as f32);
        println!("ratio2        : {:?}", rta.as_millis() as f32 / calculated_igt.as_millis() as f32);
        println!("real igt      : {:?}", igt);

        println!("============================================");
    }

    #[test]
    fn lala()
    {
        // IGT was at 7:55:12 and RTA at 8:15:00,
        let igt = Duration::from_parts(7, 55, 12, 0);
        let rta = Duration::from_parts(8, 15, 00, 0);
        test("60FPS, 8 hours RTA", rta, igt, 60.0f32);
        return;
    }


    #[test]
    fn do_it_33fps()
    {
        //After almost 6 hours, IGT was at 5:45:45 and RTA at 5:51:44, which is roughly 98.3%.
        let igt = Duration::from_parts(5, 45, 45, 0);
        let rta = Duration::from_parts(5, 51, 44, 0);
        test("33FPS, 6 hours RTA", rta, igt, 33.0f32);
        return;
    }


    #[test]
    fn measured_33fps()
    {
        let igt = Duration::from_parts(0, 2, 59, 02);
        let rta = Duration::from_parts(0, 3, 0, 93);
        test("RIVA tuner 33FPS", rta, igt, 33.0f32);
        return; //00:02:59.0200000 00:03:00.9300000 0,989443431161223
    }

    fn test_igt_iterations(iterations: usize, frame_delta: f32)
    {
        let igt = run_igt(iterations, frame_delta);

        //500 frames at 60 FPS 0.0166 frame delta
        let expected_rta = (iterations as f32 * (frame_delta * 1000f32)).floor() as u32;
        let expected_scaled = (iterations as f32 * (frame_delta * 1000f32) * 0.96f32) as u32;

        println!("expected_rta: {} expected_scaled: {} igt: {}", expected_rta, expected_scaled, igt);
    }
}
