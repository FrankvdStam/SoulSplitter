use chrono::prelude::*;
use detour::static_detour;
use crate::scan_cache::scan_absolute;

static_detour!{ static SetEventFlagHook: fn(u64, u32, i32); }

static mut FLAGS: Vec<u32> = Vec::new();

fn log_event_flag(rdx: u64, edx: u32, r8d: i32)
{
    unsafe {
        //Only log flags once to cleanup the output a bit
        if !FLAGS.contains(&edx)
        {
            println!("{} {} {}", Local::now().format("%H:%M:%S%.3f"), edx, r8d);
            FLAGS.push(edx);
        }
    }
    //This calls the original function without detouring, to repair the event flag system.
    SetEventFlagHook.call(rdx, edx, r8d);
}

pub fn init_event_flag_detour()
{
    unsafe
        {
            let address = scan_absolute("48 89 5c 24 08 44 8b 49 1c 44 8b d2 33 d2 41 8b c2 41 f7 f1 41 8b d8 4c 8b d9").unwrap();
            println!("set_event_flag address: 0x{:x}", address);

            let original_func: fn(u64, u32, i32) = std::mem::transmute(address        as *const fn(u64, u32, i32));
            let detour_func:   fn(u64, u32, i32) = std::mem::transmute(log_event_flag as *const fn(u64, u32, i32));

            SetEventFlagHook.initialize(original_func, detour_func).unwrap().enable().unwrap();
            println!("set_event_flag enabled: {}", SetEventFlagHook.is_enabled());
        }
}
