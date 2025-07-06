//c5 fa 59 0d 74 ac 43 03 c4 e1 fa 2c c9 48 8d 05 6c f6 04 04

use std::ffi::c_void;
use ilhook::x64::{CallbackOption, HookFlags, HookPoint, HookType, Hooker, Registers};
use log::info;
use mem_rs::helpers::{scan, to_pattern};
use mem_rs::prelude::*;
use windows::Win32::System::Memory::{VirtualQuery, MEMORY_BASIC_INFORMATION};

static mut INCREMENT_IGT: Option<HookPoint> = None;

static mut IGT_BUFFER: f32 = 0.0f32;

pub fn init_bloodborne()
{
    let mut process = Process::new("shadps4.exe");
    process.refresh().unwrap();
        
    let eboot_base_address = 0x8ffffc000usize;
    let mut mbi = MEMORY_BASIC_INFORMATION::default();
    unsafe { VirtualQuery(Some(eboot_base_address as *const c_void), &mut mbi, size_of::<MEMORY_BASIC_INFORMATION>()) ; }


    //thread '<unnamed>' panicked at src\soulmods\src\console.rs:22:28:
    //called `Result::unwrap()` on an `Err` value: Error { code: HRESULT(0x80070005), message: "Access is denied." }
    //note: run with `RUST_BACKTRACE=1` environment variable to display a backtrace
    
    info!("eboot at 0x{:x} - 0x{:x}", eboot_base_address, mbi.RegionSize);

    let mut game_code_bytes: Vec<u8> = vec![0; mbi.RegionSize];
    let read_result = process.read_memory_abs(eboot_base_address, game_code_bytes.as_mut_slice());
    info!("eboot read: {}, {}", read_result, game_code_bytes.len());
    
    let igt_increment_fn_address = eboot_base_address + scan(&game_code_bytes, &to_pattern("c4 e1 fa 2c c8 48 8d 05 ? ? ? ? 48 8b 00")).expect("igt increment fn scan failed");
    info!("increment igt fn at 0x{:x}", igt_increment_fn_address);

    unsafe { INCREMENT_IGT = Some(Hooker::new(igt_increment_fn_address, HookType::JmpBack(increment_igt_hook), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap()) };
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