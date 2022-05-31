use std::{ptr, slice};
use chrono::Local;
use detour::static_detour;
use log::info;
use crate::scan_cache::{scan_absolute};


static_detour!{ static SetEventGuideFlagHook: fn(u64, i64); }

//static mut FLAGS: Vec<u32> = Vec::new();

fn log_event_flag(rdx: u64, edx: i64)
{
    //edx = ptr to int
    let deref = unsafe{ ptr::read(edx as *const i64) };
    //let deref: i64 = unsafe { std::mem::transmute(edx as *const i64) };
    info!("event key guide {:x} {:x} {:x}", rdx, edx, deref);
    SetEventGuideFlagHook.call(rdx, edx);
}

pub fn init_event_guide_flag_detour()
{
    unsafe
        {
            //

            //For some reason, the code we're after exists twice when the game is running...
            //Gota figure that out later
            //let address = MODULE_BASE + 0x46D870;

            //let address = scan_absolute("48 89 5c 24 08 48 89 74 24 10 57 48 83 ec 20").unwrap();
            let address = scan_absolute("48 89 5c 24 20 56 48 83 ec 20 45 33 db 48 8b f2 48 8b d9 45 33 c9 4c 8d 51 34 66 0f 1f 44 00 00 45 8b 02 45 85 c0 74 2b 41 8b c0 48 8d 4b 34 83 e0 1f").unwrap();
            //let address = scan_absolute("85 d2 0f 84 06 01 00 00 53 48 83 ec 20 8b c2 48 89 7c 24 48 48 8d 79 34 83 e0 1f 48 8b d9 48 c1 e0 04 48 03 f8 39 17 0f 85 d7 00 00 00").unwrap();
            info!("set_event_guide_flag address: 0x{:x}", address);

            let original_func: fn(u64, i64) = std::mem::transmute(address        as *const fn(u64, i64));
            let detour_func:   fn(u64, i64) = std::mem::transmute(log_event_flag as *const fn(u64, i64));

            SetEventGuideFlagHook.initialize(original_func, detour_func).unwrap().enable().unwrap();
            info!("set_event_guide_flag enabled: {}", SetEventGuideFlagHook.is_enabled());
        }
}

pub fn disable_event_guide_flag_detour()
{
    unsafe { SetEventGuideFlagHook.disable() };
}