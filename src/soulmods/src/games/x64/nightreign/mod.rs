use ilhook::x64::{Hooker, HookType, Registers, CallbackOption, HookFlags, HookPoint};
use mem_rs::prelude::*;
use log::info;

use crate::util::GLOBAL_VERSION;

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